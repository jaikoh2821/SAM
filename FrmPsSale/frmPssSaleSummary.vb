Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports DevExpress.XtraSplashScreen

Public Class frmPssSaleSummary
    Dim idPsSaleClick As Integer = 0
    Dim ImagePsSale As New ImageList()
    Dim dSSMAll As New DataTable
    Dim stLoad As Integer = 0
    Dim dPsSale As New DataTable
    Dim vMyTableTemp As New DataView
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Private Property GridControl As Object

    Private Sub frmPssSaleSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        dPsSale.Columns.Add("idPs", System.Type.GetType("System.Int32"))
        dPsSale.Columns.Add("String", System.Type.GetType("System.String"))

        setCmbGroupComp(Me.cmbGroupComp)
        LoadInvGroup()
        Me.rdbAllType.Checked = True
        Load_PsLine()
        ' Load_Data()
        stLoad = 1
        mdLoadCommitt()
    End Sub

    Private Sub LoadInvGroup()
        mdCnOpen()
        Dim dtInvGroup As New DataTable
        sCommand.CommandText = "SELECT idInvGroup, InvGroupName FROM dInvGroup " & vbNewLine & _
                               "WHERE stSaleRpt = 1 Order by InvGroupName"
        sAdapter.Fill(dtInvGroup)

        cmbInvGroup.DisplayMember = "InvGroupName"
        cmbInvGroup.ValueMember = "idInvGroup"
        cmbInvGroup.DataSource = dtInvGroup

    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            ClearAll()
            'Load_Data()
            Load_PsLine()
            SplashScreenManager.CloseForm(False)
            ' Load_PsLine()
        End If
    End Sub

    Private Function getImg(ByVal url As String) As System.Drawing.Image
        Dim objImage As IO.MemoryStream
        Dim objwebClient As System.Net.WebClient
        Dim vImg As Image

        Try
            objwebClient = New System.Net.WebClient()
            objImage = New IO.MemoryStream(objwebClient.DownloadData(url))
            vImg = Image.FromStream(objImage)

            objwebClient.Dispose()
            Return vImg
        Catch ex As Exception
            vImg = Nothing
            Return vImg
        End Try
    End Function

    Private Sub Load_PsLine()
        'sPsId = 238 '239  '//For Test

        mdCnOpen()
        ' Dim dPsSale As New DataTable
        Dim PsTemp As New DataTable
        dPsSale.Clear()
        sCommand.CommandText = "SELECT idPs, PsName, LevelNode " & vbNewLine & _
                               "FROM SmPsSaleLine WHERE idComp = " & cmbGroupComp.SelectedValue & " AND idPs = " & sPsId

        'sCommand.CommandText = "SELECT p.idPs, p.PsName FROM vPersonxSelect p " & vbNewLine & _
        '                       "INNER JOIN dPsSale s ON p.idPs = s.idPs " & vbNewLine & _
        '                       "INNER JOIN dPsSaleCompSet c ON  p.idPs = c.idPsSale " & vbNewLine & _
        '                       "WHERE s.stCancel Is NULL And c.idComp = " & cmbGroupComp.SelectedValue & " ORDER BY p.PsName"

        sAdapter.Fill(PsTemp)

        If PsTemp.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสายงานขายของคุณ ในบริษัทนี้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            dPsSale.Rows.Clear()
            CheckChild(PsTemp.Rows(0).Item("idPs"), PsTemp.Rows(0).Item("PsName"), PsTemp.Rows(0).Item("LevelNode"))
        End If

        'ImagePsSale.ImageSize = New Size(48, 60)
        For i As Integer = 0 To dPsSale.Rows.Count - 1
            Dim url As String = "http://" & sHost & "/spm/images/pPs/" & dPsSale.Rows(i).Item("idPs") & ".jpg"
            Dim psimg As Image = getImg(url)
            If psimg Is Nothing = False Then
                ImagePsSale.Images.Add(dPsSale.Rows(i).Item("idPs").ToString, psimg)
                ' Else
                ' ImagePsSale.Images.Add(dPsSale.Rows(i).Item("idPs").ToString, My.Resources.ResourceManager.GetObject("User-male-icon"))
            End If
        Next

        Dim IDWHERE As String = ""
        If dPsSale.Rows.Count <> 0 Then
            IDWHERE = IDWHERE & dPsSale.Rows(0).Item("idPs")

            For i As Integer = 1 To dPsSale.Rows.Count - 1
                IDWHERE = IDWHERE & ", " & dPsSale.Rows(i).Item("idPs")
            Next
            If IDWHERE <> "" Then
                IDWHERE = " AND ps.idPs IN (" & IDWHERE & ") "
            End If
        End If

        Load_Data(IDWHERE)
    End Sub

    Private Sub CheckChild(ByVal idParent As String, ByVal ParentName As String, ByVal LevelNode As Integer)
        If idParent Is DBNull.Value Then
            Exit Sub
        Else
            dPsSale.Rows.Add(idParent, ParentName)
            Dim dt As New DataTable
            sCommand.CommandText = "SELECT idPs, PsName, LevelNode FROM SmPsSaleLine WHERE idComp = " & cmbGroupComp.SelectedValue & " AND " & _
                                   "Parent = " & idParent & " AND LevelNode = " & LevelNode + 1
            sAdapter.Fill(dt)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    CheckChild(dt.Rows(i).Item("idPs"), dt.Rows(i).Item("PsName"), dt.Rows(i).Item("LevelNode"))
                Next
            End If
        End If
    End Sub

    Private Sub Load_Data(ByVal vidWHERE As String)
        Dim dSSM As New DataTable
        Dim vWHERE As String = ""

        If rbDay.Checked = True Then
            Dim firstDate As DateTime = Convert.ToDateTime(dtpS.Value, _cultureEnInfo)
            Dim lastDate As DateTime = Convert.ToDateTime(dtpE.Value, _cultureEnInfo)
            vWHERE = vWHERE & " AND mt.DateSaleD Between '" & firstDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " & _
                              "And '" & lastDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' "

        ElseIf rbMonth.Checked = True Then
            Dim sDateMN As DateTime = Convert.ToDateTime(dtpMonth.Value, _cultureEnInfo)
            Dim sMonthMN As Integer = sDateMN.Month
            Dim sYearMN As Integer = sDateMN.Year
            vWHERE = vWHERE & " AND Month(mt.DateSaleD) = " & sMonthMN & " AND YEAR(mt.DateSaleD) = " & sYearMN

        ElseIf rbYear.Checked = True Then
            Dim sDateY As DateTime = Convert.ToDateTime(dtpYear.Value, _cultureEnInfo)
            Dim sYearY As Integer = sDateY.Year

            vWHERE = vWHERE & " AND YEAR(mt.DateSaleD) = " & sYearY
        End If

        If Me.rdbSelectType.Checked = True Then 'select idInvGroup
            vWHERE = vWHERE & " AND inv.idInvGroup = " & cmbInvGroup.SelectedValue

            If Me.ChkNoPriceLow.Checked = True Then 'ไม่ sum สินค้าผักซอง
                vWHERE = vWHERE & " AND pk.idType = '0' "
            End If

            If Me.ChkOnlyPriceLow.Checked = True Then 'sum เฉพาะสินค้าผักซอง
                vWHERE = vWHERE & " AND pk.idType = '1' "
            End If
        End If

        Dim pConnection = New SqlConnection
        With pConnection
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connStrxP
            .Open()
        End With
        Dim pCommand = New SqlCommand(sSql, pConnection) With {.CommandTimeout = 1000}
        Dim pAdapter = New SqlDataAdapter(pCommand)

        'pCommand.CommandText = "SELECT ps.idPs, ps.PsName, SUM(dt.Amount*dt.Price) AS TotalNet " & vbNewLine & _
        '                       "FROM vPersonxSelect AS ps " & vbNewLine & _
        '                       "LEFT OUTER JOIN SmSaleMt AS mt ON ps.idPs = mt.idPsSale " & vbNewLine & _
        '                       "LEFT OUTER JOIN vSmSaleDetail_Amt dt " & _
        '                       "ON mt.idSale = dt.idSale WHERE mt.idSaleCode NOT IN (1,18) AND dt.Price > 0.0 AND mt.idPsCancel IS NULL " & _
        '                       "AND mt.idComp = " & sIdComp & " AND ps.stSale = '1' " & _
        '                       "AND dt.dtType <> 4 " & vWHERE & " GROUP BY ps.idPs, ps.PsName Order by TotalNet DESC"

        pCommand.CommandText = "SELECT ps.idPs, ps.PsName, SUM(dt.Amount*dt.Price) AS TotalNet " & vbNewLine & _
                               "FROM vPersonxSelect AS ps " & vbNewLine & _
                               "LEFT OUTER JOIN SmSaleMt AS mt ON ps.idPs = mt.idPsSale " & vbNewLine & _
                               "LEFT OUTER JOIN SmSaleDtAll dt ON mt.idSale = dt.idSale " & vbNewLine & _
                               "LEFT JOIN dInventoryMain inv ON dt.idProduct= inv.idInvMain " & vbNewLine & _
                               "LEFT JOIN dPackingPdSet pk On inv.idSubType = pk.idPdPk AND inv.idInvGroup = 2 " & vbNewLine & _
                               "WHERE mt.idSaleCode NOT IN (1,18) AND dt.Price > 0.0 AND mt.idPsCancel IS NULL " & vbNewLine & _
                               "dt.idProduct <> 9766 AND mt.idComp = " & cmbGroupComp.SelectedValue & vWHERE & vidWHERE & " " & vbNewLine & _
                               "GROUP BY ps.idPs, ps.PsName Order by TotalNet DESC"

        pAdapter.Fill(dSSM)

        dSSMAll = New DataTable
        dSSMAll.Clear()
        'sCommand.CommandText = "SELECT mt.idPsSale, mt.idCus, dt.PdPkName, ISNULL(p.PdTradeName, '') As PdTradeName, " & _
        '                       "ISNULL(dt.PlantName, '') As PlantName, dt.idPkUnit, " & _
        '                       "CAST((CASE dt.PkUnitName WHEN 'กรัม' THEN (dt.Amount/1000) ELSE dt.Amount END) As Decimal(10,4)) As Amount, " & _
        '                       "(CASE dt.PkUnitName WHEN 'กรัม' THEN 'กิโลกรัม' ELSE dt.PkUnitName END) As PkUnitName, " & _
        '                       "CAST((dt.Amount * dt.Price) As Decimal(10,2)) AS TotalNet, dt.Perbox FROM vSmSaleDetail dt " & _
        '                       "LEFT OUTER JOIN SmSaleMt AS mt ON dt.idSale = mt.idSale LEFT OUTER JOIN vPackingPdSet_Select AS p " & _
        '                       "ON dt.idPdPk = p.idPdPk Where mt.idSaleCode NOT IN (1,18) AND dt.Price > 0.0 AND mt.idPsCancel Is NULL And " & _
        '                       "mt.idComp = " & sIdComp & " And dt.dtType <> 4 " & vWHERE

        sCommand.CommandText = "SELECT mt.idPsSale, mt.idCus, dt.idProduct, dt.ProductName As PdPkName, " & vbNewLine & _
                               "Pk.idPdT, ISNULL(pk.PdTradeName, '') As PdTradeName, " & vbNewLine & _
                                "(CASE WHEN inv.idInvGroup = 1 THEN s.idSeed " & vbNewLine & _
                               "      WHEN inv.idInvGroup = 2 THEN pk.idPlant " & vbNewLine & _
                               "      ELSE NULL END) AS idPlant, " & vbNewLine & _
                               "(CASE WHEN inv.idInvGroup = 1 THEN s.SeedName " & vbNewLine & _
                               "      WHEN inv.idInvGroup = 2 THEN pk.PlantName " & vbNewLine & _
                               "      ELSE NULL END) AS PlantName, " & vbNewLine & _
                               "dt.idUnit As idPkUnit, (dt.Amount/ISNULL(u.CvtUnit,1)) As Amount, " & vbNewLine & _
                               "(CASE dt.idUnit WHEN 1 THEN 'กิโลกรัม' ELSE u.UnitName END) As PkUnitName, " & vbNewLine & _
                               "(dt.Amount * dt.Price) AS TotalNet " & vbNewLine & _
                               "FROM SmSaleDtAll dt " & vbNewLine & _
                               "LEFT JOIN SmSaleMt AS mt ON dt.idSale = mt.idSale " & vbNewLine & _
                               "LEFT JOIN dInventoryMain inv ON dt.idProduct= inv.idInvMain " & vbNewLine & _
                               "LEFT JOIN vPackingPdSet2 pk On inv.idSubType = pk.idPdPk AND inv.idInvGroup = 2 " & vbNewLine & _
                               "LEFT JOIN vSeedProduct s ON inv.idSubType = s.idPd AND inv.idInvGroup = 1 " & vbNewLine & _
                               "LEFT JOIN dInvUnit u On dt.idUnit = u.idUnit " & vbNewLine & _
                               "WHERE mt.idSaleCode NOT IN (1,18) AND dt.Price > 0.0 AND mt.idPsCancel Is NULL " & vbNewLine & _
                               "AND  dt.idProduct <> 9766 And mt.idComp = " & cmbGroupComp.SelectedValue & vWHERE

        sAdapter.Fill(dSSMAll)

        pConnection.Close()


        DGV_AllSale.DataSource = dSSM
        'ksbCountRowDgv(DGV_AllSale, colautonum.Name)
        Calratio(DGV_AllSale, colratio.Name, colTotalNet.Name)
        Dim MyTable As New DataTable
        MyTable.Columns.Add("ID")
        MyTable.Columns.Add("Data")
        MyTable.Columns.Add("TotalNet", System.Type.GetType("System.Double"))
        MyTable.Columns.Add("ratio", System.Type.GetType("System.Decimal"))
        MyTable.Columns.Add("Amount", System.Type.GetType("System.Double"))
        MyTable.Columns.Add("PkUnitName", System.Type.GetType("System.String"))

        GridSale.DataSource = MyTable
        'GCTemp.DataSource = MyTable
        pbPsSale.Image = Nothing
        Chart1.Visible = False
        btn_ShowChart.Enabled = False
        btnPrint.Enabled = False

        If dSSM.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลยอดขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Load_Data2(ByVal idPsSale As Integer)
        btn_ShowChart.Enabled = True
        Chart1.Visible = True
        Dim vMyTable As New DataView(dSSMAll)
        Dim MyTable As New DataTable
        Dim MyTable2 As New DataTable
        Dim Data As String = ""
        Dim ID As String = ""
        vMyTable.RowFilter = "idPsSale =" & idPsSale '& " AND TotalNet <> 0"
        If rbSeed.Checked = True Then
            Data = "PlantName"
            ID = "idPlant"
        ElseIf rbPdt.Checked = True Then
            Data = "PdTradeName"
            ID = "idPdT"
        ElseIf rbTotalNet.Checked = True Then
            Data = "PdPkName"
            ID = "idProduct"
        ElseIf rbAmount.Checked = True Then
            Data = "PdPkName"
            ID = "idProduct"
        End If
        MyTable.Columns.Add("ID")
        MyTable.Columns.Add("Data")
        MyTable.Columns.Add("TotalNet", System.Type.GetType("System.Double"))
        MyTable.Columns.Add("Amount", System.Type.GetType("System.Double"))
        MyTable.Columns.Add("PkUnitName", System.Type.GetType("System.String"))
        'If rbAmount.Checked = True Then
        '    MyTable.Columns.Add("Amount", System.Type.GetType("System.Double"))
        '    MyTable.Columns.Add("PkUnitName")
        'End If
        MyTable.Columns.Add("ratio", System.Type.GetType("System.Decimal"))
        Dim sum As Decimal = 0
        Dim sum2 As Decimal = 0
        Dim sumAmount As Double = 0
        Dim dubList As New List(Of Integer)
        Dim checkDup As Integer = 0
        For i As Integer = 0 To vMyTable.Count - 1
            checkDup = 0
            If dubList.Count > 0 Then
                If dubList.Contains(i) Then
                    checkDup = 1
                End If
            End If

            If checkDup = 0 Then
                sum = 0
                sumAmount = 0
                For j As Integer = 0 To vMyTable.Count - 1
                    If vMyTable(i).Item(Data).ToString.Trim = vMyTable(j).Item(Data).ToString.Trim Then
                        sum2 = 0
                        'If vMyTable(j).Item("idPkUnit") = 3 Then
                        '    sum2 = vMyTable(j).Item("TotalNet") * vMyTable(j).Item("Perbox")
                        'Else
                        sum2 = vMyTable(j).Item("TotalNet")
                        'End If
                        sum += sum2
                        sumAmount += vMyTable(j).Item("Amount")
                        dubList.Add(j)
                    End If
                Next
                Dim r As DataRow = MyTable.NewRow()
                r("ID") = vMyTable(i).Item(ID)
                r("Data") = vMyTable(i).Item(Data)
                r("TotalNet") = sum
                If rbAmount.Checked = True Then
                    r("Amount") = sumAmount
                    r("PkUnitName") = vMyTable(i).Item("PkUnitName")
                End If
                r("ratio") = 0
                MyTable.Rows.Add(r)
            End If
        Next
        Dim SumTotalNet As Double = 0
        Dim SumAmountAll As Double
        For i As Integer = 0 To MyTable.Rows.Count - 1
            SumTotalNet += MyTable.Rows(i).Item("TotalNet")
            If rbAmount.Checked = True Then
                SumAmountAll += MyTable.Rows(i).Item("Amount")
            End If
        Next
        For i As Integer = 0 To MyTable.Rows.Count - 1
            If rbAmount.Checked = True Then
                If SumAmountAll <> 0 Then
                    MyTable.Rows(i).Item("ratio") = FormatNumber((MyTable.Rows(i).Item("Amount") * 100) / SumAmountAll, 2)
                Else
                    MyTable.Rows(i).Item("ratio") = 0
                End If
            Else
                If SumTotalNet <> 0 Then
                    MyTable.Rows(i).Item("ratio") = FormatNumber((MyTable.Rows(i).Item("TotalNet") * 100) / SumTotalNet, 2)
                Else
                    MyTable.Rows(i).Item("ratio") = 0
                End If
            End If

        Next
        vMyTable = New DataView(MyTable)
        vMyTableP = New DataView(MyTable)
        'If rbName.Checked = True Then
        '    vMyTable.Sort = "Data ASC"
        'ElseIf rbRatio.Checked = True Then
        If rbAmount.Checked = True Then
            vMyTable.Sort = "Amount DESC"
        Else
            vMyTable.Sort = "TotalNet DESC"
        End If
        'End If

        'vMyTable.Sort = "TotalNet DESC"
        GridSale.DataSource = vMyTable
        GCTemp.DataSource = vMyTable
        vMyTableTemp = vMyTable
        'ksbCountRowDgv(DGV_Sale, col_autonum.Name)

        '---------------------------------------
        pbPsSale.Image = getImg("http://" & sHost & "/spm/images/pPs/" & idPsSale.ToString & ".jpg")


        '------------------- chart -------------------'
        If gvTemp.RowCount >= 5 Then
            txt_numchart.Text = "5"
            Load_Chart(CInt(txt_numchart.Text))
        Else
            txt_numchart.Text = DGV_Sale.RowCount
            Load_Chart(gvTemp.RowCount)
        End If
    End Sub

    Private Sub Load_Chart(ByVal n As Integer)
        'Dim gv As New DataGridView
        'gv.DataSource = vMyTableTemp
        'Dim m As Integer = gv.RowCount
        Dim yValues(n) As Double '() '= {1000, 1000, 1000} ' Getting values from Textboxes 
        Dim xValues(n) As String '() '= {"Invoice Amount", "Time Amount", "Bill Amount"} ' Headings
        Dim seriesName As String = Nothing

        For i As Integer = 0 To n - 1
            If rbAmount.Checked = True Then
                'yValues(i) = DGV_Sale.Row(i).Cells(col_Amount.Name).Value
                yValues(i) = gvTemp.GetDataRow(i).Item("Amount")
            Else
                'yValues(i) = DGV_Sale.Rows(i).Cells(col_TotalNet.Name).Value
                yValues(i) = gvTemp.GetDataRow(i).Item("TotalNet")

            End If
            If rbSeed.Checked = True Then
                'xValues(i) = DGV_Sale.Rows(i).Cells(col_SeedName.Name).Value
                xValues(i) = gvTemp.GetDataRow(i).Item("Data")

            ElseIf rbPdt.Checked = True Then
                'xValues(i) = DGV_Sale.Rows(i).Cells(col_PdTName.Name).Value
                xValues(i) = gvTemp.GetDataRow(i).Item("Data")

            ElseIf rbTotalNet.Checked = True Or rbAmount.Checked = True Then
                'xValues(i) = DGV_Sale.Rows(i).Cells(col_PdPkName.Name).Value
                xValues(i) = gvTemp.GetDataRow(i).Item("Data")

            End If
        Next
        ' Note 1 : Clear chart before fill - VERY IMPORTANT and can generate exception if you are generating
        '          multiple charts in loop and have not included below lines !
        ' Note 2 : Chrt variable here is the Name of your Chart 
        Chart1.Series.Clear()
        Chart1.Titles.Clear()


        'Chart1.Series("Series1").ChartType = SeriesChartType.Pie
        ' Give unique Series Name
        seriesName = "ChartInv"
        Chart1.Series.Add(seriesName)

        ' Bind X and Y values
        Chart1.Series(seriesName).Points.DataBindXY(xValues, yValues)
        ' Chart Area Modification (Optional)
        Chart1.Palette = ChartColorPalette.BrightPastel
        'Dim CArea As ChartArea = Chart1.ChartAreas(0)
        'CArea.BackColor = Color.Azure
        'CArea.ShadowColor = Color.Red
        'CArea.Area3DStyle.Enable3D = True

        '' Define Custom Chart Colors
        'Chart1.Series(seriesName).Points(0).Color = Color.MediumSeaGreen
        'Chart1.Series(seriesName).Points(1).Color = Color.PaleGreen
        'Chart1.Series(seriesName).Points(2).Color = Color.LawnGreen

        ' Define Chart Type
        Chart1.Series(seriesName).ChartType = SeriesChartType.Pie

        Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True

        ' Formatting the Chart Title
        'Dim T As Title = Chart1.Titles.Add("Amount Distribution")
        'With T
        '    .ForeColor = Color.Black
        '    .BackColor = Color.LightBlue
        '    .Font = New System.Drawing.Font("Times New Roman", 11.0F, System.Drawing.FontStyle.Bold)
        '    .BorderColor = Color.Black
        'End With

        ' If you want to show Chart Legends
        Chart1.Legends(0).Enabled = True

        ' If you don't want to show data values and headings as label inside each Pie in chart
        Chart1.Series(seriesName)("PieLabelStyle") = "Disabled"
        Chart1.Series("ChartInv").IsValueShownAsLabel = False


        ' If you want to show datavalues as label inside each Pie in chart
        Chart1.Series("ChartInv").IsValueShownAsLabel = True
        'Chart1.Width = 500
        Chart1.Series("ChartInv").LabelForeColor = Color.Tomato
        Chart1.Series("ChartInv").Label = "#PERCENT{P2}"
        ' Chart1.Series("ChartInv").Label = "#VALY{C2}"
        Chart1.Series("ChartInv").LabelAngle = 0
        Chart1.Series("ChartInv")("PieLabelStyle") = "Outside"
        'Chart1.Series("ChartInv").BorderWidth = 1
        'Chart1.Series("ChartInv").BorderColor = System.Drawing.Color.Black
        Chart1.Series("ChartInv").LegendText = "#VALX " '(#VALY{C2})"
        'Chart1.Legends("Legend1").Position.X = 80
        'Chart1.Legends("Legend1").Position.Y = 1
        Chart1.Legends("Legend1").Enabled = True
        Chart1.Legends("Legend1").LegendStyle = LegendStyle.Table
        Chart1.Legends("Legend1").Font = New Font("Times New Roman", 8, FontStyle.Regular)
        Chart1.Legends("Legend1").Docking = Docking.Top
        Chart1.Legends("Legend1").Alignment = System.Drawing.StringAlignment.Center
    End Sub

    Private Sub Calratio(ByVal dgv As DataGridView, ByVal colratio As String, ByVal coltotal As String)
        Dim SumTotalNet As Double = 0
        For i As Integer = 0 To dgv.Rows.Count - 1
            SumTotalNet += dgv.Rows(i).Cells(coltotal).Value
        Next
        For i As Integer = 0 To dgv.Rows.Count - 1
            dgv.Rows(i).Cells(colratio).Value = FormatNumber(((dgv.Rows(i).Cells(coltotal).Value * 100) / SumTotalNet), 2)
        Next
    End Sub

    Private Sub rbMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMonth.CheckedChanged
        dtpMonth.Enabled = rbMonth.Checked
    End Sub

    Private Sub rbYear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbYear.CheckedChanged
        dtpYear.Enabled = rbYear.Checked
    End Sub

    Private Sub DGV_AllSale_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_AllSale.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If DGV_AllSale.Columns(e.ColumnIndex).Name = colSelect.Name Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            DGV_AllSale.Rows(e.RowIndex).Cells(colSelect.Name).Value = True
            For i As Integer = 0 To DGV_AllSale.Rows.Count - 1
                If i <> e.RowIndex Then
                    DGV_AllSale.Rows(i).Cells(colSelect.Name).Value = False
                End If
            Next

            Load_Data2(DGV_AllSale.Rows(e.RowIndex).Cells(colidPsSale.Name).Value)
            idPsSaleClick = (DGV_AllSale.Rows(e.RowIndex).Cells(colidPsSale.Name).Value)
            btnPrint.Enabled = True
            PsSaleP = DGV_AllSale.Rows(e.RowIndex).Cells(colPsSale.Name).Value
            SumTotalNetP = FormatNumber(DGV_AllSale.Rows(e.RowIndex).Cells(colTotalNet.Name).Value, 2)
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        'Load_Data()
        Load_PsLine()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub btn_ShowChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ShowChart.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        Load_Chart(CInt(txt_numchart.Text))
        SplashScreenManager.CloseForm(False)

    End Sub

    Private Sub txt_numchart_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_numchart.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub rbSeed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSeed.CheckedChanged
        If rbSeed.Checked = True Then
            ClearAll()

            col_SeedName.VisibleIndex = 0
            col_TotalNet.VisibleIndex = 1
            col_ratio.VisibleIndex = 2

            rdbPackage.Checked = False
            rbPdt.Checked = False
            rbTotalNet.Checked = False

            col_SeedName.Visible = True
            col_PdTName.Visible = False
            col_PdPkName.Visible = False
            col_TotalNet.Visible = True
            col_Amount.Visible = False
            col_PkUnitName.Visible = False
            'DGV_Sale.Columns(col_SeedName.Name).Visible = True
            'DGV_Sale.Columns(col_PdTName.Name).Visible = False
            'DGV_Sale.Columns(col_PdPkName.Name).Visible = False

            'DGV_Sale.Columns(col_TotalNet.Name).Visible = True
            'DGV_Sale.Columns(col_Amount.Name).Visible = False
            'DGV_Sale.Columns(col_PkUnitName.Name).Visible = False
        End If
    End Sub

    Private Sub rbPdt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPdt.CheckedChanged
        If rbPdt.Checked = True Then
            rbTotalNet.Checked = False

            ClearAll()
            col_PdTName.VisibleIndex = 0
            col_TotalNet.VisibleIndex = 1
            col_ratio.VisibleIndex = 2

            col_SeedName.Visible = False
            col_PdTName.Visible = True
            col_PdPkName.Visible = False

            col_TotalNet.Visible = True
            col_Amount.Visible = False
            col_PkUnitName.Visible = False

            Me.txtSearch.Text = ""
            'DGV_Sale.Columns(col_SeedName.Name).Visible = False
            'DGV_Sale.Columns(col_PdTName.Name).Visible = True
            'DGV_Sale.Columns(col_PdPkName.Name).Visible = False

            'DGV_Sale.Columns(col_TotalNet.Name).Visible = True
            'DGV_Sale.Columns(col_Amount.Name).Visible = False
            'DGV_Sale.Columns(col_PkUnitName.Name).Visible = False
        End If
    End Sub

    Private Sub rbDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDay.CheckedChanged
        dtpS.Enabled = rbDay.Checked
        dtpE.Enabled = rbDay.Checked
    End Sub

    Dim PsSaleP As String
    Dim SumTotalNetP As String
    Dim vMyTableP As DataView

    'Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
    '    Dim ptSort As String = ""
    '    Dim stShow As String = ""
    '    If rbSeed.Checked = True Then
    '        ptSort = "ประเภทพืช "
    '        stShow = "Plant"
    '    ElseIf rbPdt.Checked = True Then
    '        ptSort = "ประเภทสินค้า "
    '        stShow = "Pdt"
    '    ElseIf rdbPackage.Checked = True Then
    '        ptSort = "ประเภท Package "
    '        If rbAmount.Checked = True Then
    '            stShow = "Pk2"
    '        Else
    '            stShow = "Pk1"
    '        End If
    '    End If

    '    'If rbName.Checked = True Then
    '    '    ptSort += "เรียงข้อมูลตามชื่อ"
    '    '    vMyTableP.Sort = "Data ASC"
    '    'ElseIf rbRatio.Checked = True Then
    '    ptSort += "เรียงข้อมูลตามสัดส่วน"
    '    If rbAmount.Checked = True Then
    '        vMyTableP.Sort = "Amount DESC"
    '    Else
    '        vMyTableP.Sort = "TotalNet DESC"
    '    End If
    '    'End If
    '    '----------------------------------------Close Crystal Report------------------------------
    '    'Dim vRpt As New crpPssSaleSummary
    '    'vRpt.SetDataSource(vMyTableP)
    '    'vRpt.SetParameterValue(vRpt.Parameter_ptTitle.ParameterFieldName, "รายงานสรุปยอดขายเจ้าหน้าที่ขาย")
    '    'vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
    '    'vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, mdPsPrint())
    '    'vRpt.SetParameterValue(vRpt.Parameter_ptSort.ParameterFieldName, ptSort)
    '    'vRpt.SetParameterValue(vRpt.Parameter_stShow.ParameterFieldName, stShow)
    '    'vRpt.SetParameterValue(vRpt.Parameter_ptName.ParameterFieldName, PsSaleP)
    '    'vRpt.SetParameterValue(vRpt.Parameter_ptSumTotalNet.ParameterFieldName, SumTotalNetP)
    '    ''vRpt.SetParameterValue(vRpt.Parameter_ptData.ParameterFieldName, "ข้อมูล : " & ptData)

    '    'Dim vFrm As New frmReportView
    '    'vFrm.crView.ReportSource = vRpt
    '    'vFrm.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None '*** GroupTree ****'
    '    'vFrm.Show()
    '    ''mdRptShow(vRpt)
    '    '----------------------------------------Close Crystal Report------------------------------
    'End Sub

    Private Sub ClearAll()
        Dim MyTableS As New DataTable
        MyTableS.Columns.Add("idPs")
        MyTableS.Columns.Add("PsName")
        MyTableS.Columns.Add("TotalNet")
        DGV_AllSale.DataSource = MyTableS

        Dim MyTable As New DataTable
        MyTable.Columns.Add("Data")
        MyTable.Columns.Add("TotalNet", System.Type.GetType("System.Decimal"))
        MyTable.Columns.Add("ratio", System.Type.GetType("System.Decimal"))
        MyTable.Columns.Add("Amount", System.Type.GetType("System.Double"))
        MyTable.Columns.Add("PkUnitName", System.Type.GetType("System.String"))

        GridSale.DataSource = MyTable
        'GridCus.DataSource = MyTable
        pbPsSale.Image = Nothing
        Chart1.Visible = False
        btn_ShowChart.Enabled = False
        btnPrint.Enabled = False
    End Sub

    Private Sub ClearSelect()
        'Dim MyTableS As New DataTable
        'MyTableS.Columns.Add("idPs")
        'MyTableS.Columns.Add("PsName")
        'MyTableS.Columns.Add("TotalNet")
        'DGV_AllSale.DataSource = MyTableS
        Dim MyTable As New DataTable
        MyTable.Columns.Add("Data")
        MyTable.Columns.Add("TotalNet", System.Type.GetType("System.Decimal"))
        MyTable.Columns.Add("ratio", System.Type.GetType("System.Decimal"))
        MyTable.Columns.Add("Amount", System.Type.GetType("System.Double"))
        MyTable.Columns.Add("PkUnitName", System.Type.GetType("System.String"))

        GridSale.DataSource = MyTable
        'GridCus.DataSource = MyTable
        pbPsSale.Image = Nothing
        Chart1.Visible = False
        btn_ShowChart.Enabled = False
        btnPrint.Enabled = False
        For i As Integer = 0 To DGV_AllSale.Rows.Count - 1
            DGV_AllSale.Rows(i).Cells(colSelect.Name).Value = False
        Next
    End Sub

    Private Sub rbName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbName.CheckedChanged
        ClearSelect()
    End Sub

    Private Sub rbRatio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRatio.CheckedChanged
        ClearSelect()
    End Sub

    Private Sub rbTotalNet_CheckedChanged(sender As Object, e As EventArgs) Handles rbTotalNet.CheckedChanged
        If Me.rbTotalNet.Checked = True Then
            ClearAll()
            col_PdPkName.VisibleIndex = 0
            col_TotalNet.VisibleIndex = 1
            col_ratio.VisibleIndex = 2
            col_SeedName.Visible = False
            col_PdTName.Visible = False
            col_PdPkName.Visible = True
            col_TotalNet.Visible = True
            col_Amount.Visible = False
            col_PkUnitName.Visible = False

            Me.txtSearch.Text = ""
            'DGV_Sale.Columns(col_SeedName.Name).Visible = False
            'DGV_Sale.Columns(col_PdTName.Name).Visible = False
            'DGV_Sale.Columns(col_PdPkName.Name).Visible = True

            'DGV_Sale.Columns(col_TotalNet.Name).Visible = True
            'DGV_Sale.Columns(col_Amount.Name).Visible = False
            'DGV_Sale.Columns(col_PkUnitName.Name).Visible = False
        End If
    End Sub

    Private Sub rbAmount_CheckedChanged(sender As Object, e As EventArgs) Handles rbAmount.CheckedChanged
        If Me.rbAmount.Checked = True Then
            ClearAll()
            col_PdPkName.VisibleIndex = 0
            col_Amount.VisibleIndex = 1
            col_PkUnitName.VisibleIndex = 2
            col_ratio.VisibleIndex = 3
            col_SeedName.Visible = False
            col_PdTName.Visible = False
            col_PdPkName.Visible = True
            col_TotalNet.Visible = False
            col_Amount.Visible = True
            col_PkUnitName.Visible = True

            Me.txtSearch.Text = ""
            'DGV_Sale.Columns(col_SeedName.Name).Visible = False
            'DGV_Sale.Columns(col_PdTName.Name).Visible = False
            'DGV_Sale.Columns(col_PdPkName.Name).Visible = True

            'DGV_Sale.Columns(col_TotalNet.Name).Visible = False
            'DGV_Sale.Columns(col_Amount.Name).Visible = True
            'DGV_Sale.Columns(col_PkUnitName.Name).Visible = True
        End If
    End Sub

    Private Sub rdbAllType_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAllType.CheckedChanged
        If Me.rdbAllType.Checked = True Then
            ClearAll()
            cmbInvGroup.Enabled = False

            Me.ChkNoPriceLow.Checked = False
            Me.ChkOnlyPriceLow.Checked = False
            Me.ChkNoPriceLow.Visible = False
            Me.ChkOnlyPriceLow.Visible = False

            Me.rdbPackage.Checked = True
            Me.rbSeed.Enabled = False
            Me.rbPdt.Enabled = False
        End If
    End Sub

    Private Sub rdbSelectType_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSelectType.CheckedChanged
        If rdbSelectType.Checked = True Then
            ClearAll()
            cmbInvGroup.Enabled = True
        End If
    End Sub

    Private Sub cmbInvGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbInvGroup.SelectedIndexChanged
        ClearAll()
        Me.txtSearch.Text = ""
        Select Case cmbInvGroup.SelectedValue
            Case 1 'เมล็ดพันธุ์วัตถุดิบ
                Me.ChkNoPriceLow.Checked = False
                Me.ChkOnlyPriceLow.Checked = False
                Me.ChkNoPriceLow.Visible = False
                Me.ChkOnlyPriceLow.Visible = False
                ' col_SeedName.VisibleIndex = 0
                Me.rbSeed.Checked = True
                Me.rbSeed.Enabled = True
                Me.rbPdt.Enabled = False
            Case 2 'FG
                Me.ChkNoPriceLow.Visible = True
                Me.ChkOnlyPriceLow.Visible = True

                'col_SeedName.VisibleIndex = 0
                'col_TotalNet.VisibleIndex = 1
                'col_ratio.VisibleIndex = 2
                Me.rbSeed.Enabled = True
                Me.rbPdt.Enabled = True
                Me.rbSeed.Checked = True
            Case Else
                Me.ChkNoPriceLow.Checked = False
                Me.ChkOnlyPriceLow.Checked = False
                Me.ChkNoPriceLow.Visible = False
                Me.ChkOnlyPriceLow.Visible = False

                Me.rdbPackage.Checked = True
                Me.rbSeed.Enabled = False
                Me.rbPdt.Enabled = False
        End Select
    End Sub

    Private Sub ChkNoPriceLow_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNoPriceLow.CheckedChanged
        If Me.ChkNoPriceLow.Checked = True Then
            ClearAll()
            Me.ChkOnlyPriceLow.Checked = False
        End If
    End Sub

    Private Sub ChkOnlyPriceLow_CheckedChanged(sender As Object, e As EventArgs) Handles ChkOnlyPriceLow.CheckedChanged
        If Me.ChkOnlyPriceLow.Checked = True Then
            ClearAll()
            Me.ChkNoPriceLow.Checked = False
        End If
    End Sub

    Private Sub rdbPackage_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPackage.CheckedChanged
        ' ClearAll()
        If rdbPackage.Checked = True Then
            rbTotalNet.Enabled = rdbPackage.Checked
            rbAmount.Enabled = rdbPackage.Checked
            rbSeed.Checked = False
            rbPdt.Checked = False
            rbTotalNet.Checked = True
        Else
            Me.rbTotalNet.Enabled = False
            Me.rbAmount.Enabled = False
            Me.rbTotalNet.Checked = True
        End If

        Me.txtSearch.Text = ""
    End Sub

    Private Sub DGV_AllSale_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DGV_AllSale.RowPostPaint
        Me.DGV_AllSale("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Private Sub txt_numchart_TextChanged(sender As Object, e As EventArgs) Handles txt_numchart.TextChanged
        If gvTemp.RowCount <> 0 Then
            If txt_numchart.Text = "" Then
                If gvTemp.RowCount >= 5 Then
                    txt_numchart.Text = "5"
                Else
                    txt_numchart.Text = gvTemp.RowCount
                End If
            End If
            If CInt(txt_numchart.Text) > gvTemp.RowCount Then
                MessageBox.Show("จำนวนข้อมูลที่ระบุให้แสดงในกราฟ มากกว่าจำนวนชื่อสินค้าที่ขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_numchart.Text = gvTemp.RowCount
            End If
        End If
    End Sub

    Private Sub DGV_Sale_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        If e.Info.IsRowIndicator Then
            e.Info.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        DGV_Sale.ActiveFilterString = schGrid(txtSearch.Text, {"Data"})
    End Sub


    Private Sub DGV_Sale_CustomDrawRowIndicator_1(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles DGV_Sale.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            e.Info.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub rptHyperLinkEdit_Click(sender As Object, e As EventArgs) Handles rptHyperLinkEdit.Click
        Dim vWHERENext As String = " AND mt.idComp = " & cmbGroupComp.SelectedValue & " AND idPsSale =" & idPsSaleClick

        If rbDay.Checked = True Then
            Dim firstDate As DateTime = Convert.ToDateTime(dtpS.Value, _cultureEnInfo)
            Dim lastDate As DateTime = Convert.ToDateTime(dtpE.Value, _cultureEnInfo)
            vWHERENext = vWHERENext & " AND mt.DateSaleD Between '" & firstDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " & _
                                      "And '" & lastDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' "
        ElseIf rbMonth.Checked = True Then
            Dim sDateMN As DateTime = Convert.ToDateTime(dtpMonth.Value, _cultureEnInfo)
            Dim sMonthMN As Integer = sDateMN.Month
            Dim sYearMN As Integer = sDateMN.Year
            vWHERENext = vWHERENext & " AND Month(mt.DateSaleD) = " & sMonthMN & " AND YEAR(mt.DateSaleD) = " & sYearMN
        ElseIf rbYear.Checked = True Then
            Dim sDateY As DateTime = Convert.ToDateTime(dtpYear.Value, _cultureEnInfo)
            Dim sYearY As Integer = sDateY.Year
            vWHERENext = vWHERENext & " AND YEAR(mt.DateSaleD) = " & sYearY
        End If

        If Me.rdbSelectType.Checked = True Then 'select idInvGroup
            vWHERENext = vWHERENext & " AND inv.idInvGroup = " & cmbInvGroup.SelectedValue

            If Me.ChkNoPriceLow.Checked = True Then 'ไม่ sum สินค้าผักซอง
                vWHERENext = vWHERENext & " AND dt.idType = '0' "
            End If

            If Me.ChkOnlyPriceLow.Checked = True Then 'sum เฉพาะสินค้าผักซอง
                vWHERENext = vWHERENext & " AND dt.idType = '1' "
            End If
        End If

        If rbSeed.Checked = True Then
            vWHERENext = vWHERENext & " AND dt.idPlant = " & DGV_Sale.GetRowCellValue(DGV_Sale.FocusedRowHandle, ColID)
        ElseIf rbPdt.Checked = True Then
            vWHERENext = vWHERENext & " AND dt.idPdT = " & DGV_Sale.GetRowCellValue(DGV_Sale.FocusedRowHandle, ColID)
        ElseIf rbTotalNet.Checked = True Then
            vWHERENext = vWHERENext & " AND dt.idProduct = " & DGV_Sale.GetRowCellValue(DGV_Sale.FocusedRowHandle, ColID)
        ElseIf rbAmount.Checked = True Then
            vWHERENext = vWHERENext & " AND dt.idProduct = " & DGV_Sale.GetRowCellValue(DGV_Sale.FocusedRowHandle, ColID)
        End If

        Dim vFrm As New frmPssSalePriceDetail(vWHERENext, DGV_Sale.GetRowCellValue(DGV_Sale.FocusedRowHandle, col_PdPkName))
        vFrm.ShowDialog()
    End Sub


End Class