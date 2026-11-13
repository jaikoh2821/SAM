Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Data
Imports DevExpress.XtraSplashScreen

Public Class frmSaleSummaryMonth
    Dim idCustomer As Integer = 0
    Dim dtPsName As New DataTable
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim stLoad As Integer = 0

    Private Sub frmSaleSummaryMonth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdLoadShow()
        'sPsId = 238 '239   '//For Test

        Dim itemValues As String() = New String() {"V", "H", "F"}
        For Each value As String In itemValues
            CheckedComboBoxType.Properties.Items.Add(value, CheckState.Checked, True)
        Next value

        setCmbGroupComp(Me.cmbGroupComp)
        'Dim dtCompName As New DataTable
        'ShowDataOnCombo(dtCompName, "SELECT idComp , CompName FROM PchInvAndProject.dbo.dCompany WHERE stDel IS NULL", cmbGroupComp, "idComp", "CompName")
        'cmbGroupComp.SelectedValue = sIdComp

        dtpMs.MaxDate = DateTime.Today
        dtpMs.Value = DateTime.Today.AddMonths(-6)
        dtpMe.MaxDate = DateTime.Today

        dtPsName.Columns.Add("idPs", System.Type.GetType("System.Int64"))
        dtPsName.Columns.Add("PsName", System.Type.GetType("System.String"))

        Dim stLine = fnSetSaleLine()

        If stLine = 0 Then
            Me.Close()
            Exit Sub

        Else
            cmbPsSale.SelectedValue = sPsId
            ShowDataOnGrid()
        End If

        stLoad = 1
        mdLoadCommitt()
    End Sub

    Private Function fnSetSaleLine() As Integer
        dtPsName.Clear()
        ' SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        mdCnOpen()
        Dim PsTemp As New DataTable
        Dim stLine = 0
        sCommand.CommandText = "SELECT idPs, PsName, LevelNode FROM SmPsSaleLine WHERE idComp = " & cmbGroupComp.SelectedValue & " AND idPs = " & sPsId
        sAdapter.Fill(PsTemp)
        If PsTemp.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสายงาน และยอดขายของคุณ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return stLine

            Exit Function
        Else
            stLine = 1
            CheckChild(PsTemp.Rows(0).Item("idPs"), PsTemp.Rows(0).Item("PsName"), PsTemp.Rows(0).Item("LevelNode"))
        End If

        Dim IDWHERE As String = ""

        If dtPsName.Rows.Count <> 0 Then
            IDWHERE = IDWHERE & dtPsName.Rows(0).Item("idPs")

            For i As Integer = 1 To dtPsName.Rows.Count - 1
                'If Not IsDBNull(dtPsName.Rows(0).Item("PsName")) Then
                IDWHERE = IDWHERE & ", " & dtPsName.Rows(i).Item("idPs")
                'End If

            Next

            If IDWHERE <> "" Then
                IDWHERE = " AND idPsSale IN (" & IDWHERE & ") "
            End If
        End If

        ShowDataOnCombo(dtPsName, "SELECT DISTINCT idPsSale, PsSale FROM vSmSaleMt WHERE idComp = " & cmbGroupComp.SelectedValue & " AND idPsCancel IS NULL " & IDWHERE, cmbPsSale, "idPsSale", "PsSale")
        'SplashScreenManager.CloseForm(False)
        Return stLine

    End Function

    Private Sub CheckChild(ByVal idParent As String, ByVal ParentName As String, ByVal LevelNode As Integer)
        If idParent Is DBNull.Value Then
            Exit Sub
        Else
            dtPsName.Rows.Add(idParent, ParentName)
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


    Private Sub CHKPsSale_CheckedChanged(sender As Object, e As EventArgs) Handles cbPsSale.CheckedChanged
        If stLoad = 1 Then
            If cbPsSale.Checked Then
                ShowDataOnCombo(dtPsName, "SELECT DISTINCT idPsSale, PsSale FROM vSmSaleMt WHERE idComp = " & cmbGroupComp.SelectedValue & " AND idPsCancel IS NULL ", cmbPsSale, "idPsSale", "PsSale")

                cmbPsSale.Enabled = True
            Else
                dtPsName.Clear()
                cmbPsSale.Enabled = False
            End If
            fnClearDataONGrid()
        End If
    End Sub

#Region "ShowDataOnCombo"
    Private Sub ShowDataOnCombo(ByVal sDtName As DataTable, ByVal SQL As String, ByVal ComboName As ComboBox, ByVal ValueMember As String, ByVal DisplayMember As String)
        mdCnOpen()
        sDtName.Clear()

        sCommand.CommandText = SQL
        sAdapter.Fill(sDtName)
        If sDtName.Rows.Count = 0 Then
            ComboName.Text = "--ไม่พบข้อมูล--"
            ComboName.Enabled = False
            Exit Sub
        ElseIf sDtName.Rows.Count <> 0 Then
            With ComboName
                .DataSource = sDtName
                .ValueMember = ValueMember
                .DisplayMember = DisplayMember
            End With
        End If
    End Sub
#End Region

    Private Sub CHKCus_CheckedChanged(sender As Object, e As EventArgs) Handles cbCus.CheckedChanged
        If cbCus.Checked = True Then
            btnCus.Enabled = True
            btnCus.Focus()
        Else
            btnCus.Enabled = False
            lblCus.Tag = Nothing
            lblCus.Text = ""
        End If

        If stLoad = 1 Then
            fnClearDataONGrid()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If Me.rdbGenPC.Checked = True And Trim(Me.CheckedComboBoxType.Text) = "" Then
            MessageBox.Show("กรุณาระบุสินค้าผักซอง V, H, F อย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If stLoad = 1 Then
            fnClearDataONGrid()
        End If
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        ShowDataOnGrid()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub ShowDataOnGrid()
        'mdLoadShow()
        Dim strShowUnit As String = ""

        '------Set การแสดงข้อมูล 1: ยอดขาย, 2: จำนวนขาย (Kg), 3: จำนวนขาย (หน่วยขาย)
        Dim ShowType As Integer
        If rdbSale.Checked = True Then
            ShowType = 1
            strShowUnit = "(บาท)"
        ElseIf rdbKg.Checked = True Then
            ShowType = 2
            strShowUnit = "(Kg)"
        ElseIf rdbUnitSale.Checked = True Then
            ShowType = 3
            strShowUnit = "(หน่วย)"
        End If
        '----------------------------------------------------------------

        '---------Set การแสดงยอดขาย 0: ทั้งหมด, 1: ในประเทศ (Code: 210) , 2: ต่างประเทศ
        Dim stSalePd As Integer = 0

        If Me.rdbThai.Checked = True Then   ' ในประเทศ : 210 is Thailand
            stSalePd = 1

        ElseIf Me.rdbExp.Checked = True Then  ' ต่างประเทศ
            stSalePd = 2

        End If
        '----------------------------------------------------------------

        '---------------------Set เจ้าหน้าที่ขาย-------------------------------
        Dim idPsSale As Integer = 999999

        If cbPsSale.Checked = True And cmbPsSale.Text <> "--ไม่พบข้อมูล--" Then
            idPsSale = cmbPsSale.SelectedValue

        Else
            idPsSale = 999999
        End If
        '------------------------------------------------------------------

        '-----------------------Set ลูกค้า----------------------------------
        Dim idCus As Integer = 999999

        If cbCus.Checked = True And lblCus.Text <> "" Then
            idCus = idCustomer

        Else
            idCus = 999999
        End If
        '----------------------------------------------------------------

        '----------------Set ประเภทสินค้า---------------
        Dim CheckGenP As Integer
        Dim CheckMatP As Integer
        Dim CheckTxt As Integer
        Dim vHFStr As String = ""
        'สินค้าเมล็ดพันธุ์สำเร็จรูป
        If Me.CheckGenP.Checked = True Then
            If Me.rdbGenPA.Checked = True Then
                CheckGenP = 1

            ElseIf Me.rdbGenPN.Checked = True Then
                CheckGenP = 2

            ElseIf Me.rdbGenPC.Checked = True Then
                CheckGenP = 3

                If Me.CheckedComboBoxType.Text = "V, H, F" Then
                    vHFStr = ""
                    CheckTxt = 0
                Else
                    vHFStr = Me.CheckedComboBoxType.Text
                    CheckTxt = 1
                End If
            End If
        End If
        'สินค้าเมล็ดพันธุ์วัตถุดิบ
        If Me.CheckMatP.Checked = True Then
            CheckMatP = 1

        End If
        '--------------------------------------------------

        Dim pConnection = New SqlConnection

        With pConnection
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connStrxP
            .Open()
        End With

        Dim pCommand = New SqlCommand(sSql, pConnection) With {.CommandTimeout = 1000}
        Dim pAdapter = New SqlDataAdapter(pCommand)

        Dim dtAllPlantMt As New DataTable
        Dim dtAllPlantDt As New DataTable
        Dim ds0 As New DataSet

        Dim sDateS As DateTime = Convert.ToDateTime(dtpMs.Value, _cultureEnInfo)
        Dim sMonthS As Integer = sDateS.Month
        Dim sYearS As Integer = sDateS.Year
        Dim sDateE As DateTime = Convert.ToDateTime(dtpMe.Value, _cultureEnInfo)
        Dim sMonthE As Integer = sDateE.Month
        Dim sYearE As Integer = sDateE.Year

        '----- Set Column on DatagridView Following DateTimePicker
        Dim nMonth As Integer = MonthDifference(dtpMs.Value, dtpMe.Value)
        Dim month As Integer = dtpMs.Value.Month
        Dim Year As Integer = dtpMs.Value.Year


        If Microsoft.VisualBasic.Right(dtpMs.Text, 4) > 2500 Then
            Year = Year + 543
        End If

        Dim addGVPlant As New GridColumn
        With addGVPlant
            .Name = "ColNum"
            .Visible = True
            .Caption = "ลำดับ"
            .OptionsColumn.AllowEdit = False
            .OptionsColumn.ReadOnly = True
            .AppearanceCell.BackColor = Color.Gainsboro
            .AppearanceCell.Options.UseBackColor = True
            .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .AppearanceCell.Options.UseTextOptions = True

            .MaxWidth = 45
            .MinWidth = 45
        End With
        GVPlant.Columns.Add(addGVPlant)

        Dim addGVPlant1 As New GridColumn
        With addGVPlant1
            .Name = "colPlantName"
            .Visible = True
            .FieldName = "PlantName"
            .Caption = "ชื่อพืช"
            .UnboundType = UnboundColumnType.String
            .OptionsColumn.AllowEdit = False
            .OptionsColumn.ReadOnly = True
            .AppearanceCell.BackColor = Color.LightBlue
            .AppearanceCell.Options.UseBackColor = True
            .AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            .MinWidth = 120
        End With
        GVPlant.Columns.Add(addGVPlant1)

        Dim addGVPlant2 As New GridColumn
        With addGVPlant2
            .Name = "colSumByPlant"
            .Visible = True
            .FieldName = "SumByPlant"
            .Caption = "ยอดรวมทั้งหมด " & strShowUnit
            .UnboundType = UnboundColumnType.Decimal
            .OptionsColumn.AllowEdit = False
            .OptionsColumn.ReadOnly = True
            .AppearanceCell.BackColor = Color.PaleGreen
            .AppearanceCell.Options.UseBackColor = True
            .AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .AppearanceHeader.Options.UseTextOptions = True
            .DisplayFormat.FormatString = "#,##0.00####"
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            .MinWidth = 95
            .MaxWidth = 95
        End With
        GVPlant.Columns.Add(addGVPlant2)

        pCommand.CommandText = "DECLARE @tpb_SmSalePlant TABLE(" & vbNewLine & _
                        "idPlant		int," & vbNewLine & _
                        "PlantName		varchar(1000)," & vbNewLine & _
                        "YearSale	    int," & vbNewLine & _
                        "MonthSale	    int," & vbNewLine & _
                        "SumValue	    decimal(20,6));" & vbNewLine & _
                        "INSERT INTO @tpb_SmSalePlant(idPlant,PlantName,YearSale,MonthSale,SumValue)" & vbNewLine & _
                        "exec [sp_frmSaleSummaryMonthx01] " & ShowType & "," & cmbGroupComp.SelectedValue & "," & stSalePd & "," & _
                        sMonthS & "," & sYearS & "," & sMonthE & "," & sYearE & "," & _
                        idPsSale & "," & idCus & "," & CheckGenP & "," & CheckMatP & "," & CheckTxt & ",'" & vHFStr & "'" & vbNewLine

        pCommand.CommandText &= "DECLARE @tpb_PlantSumMonth table(" & vbNewLine & _
                                "idPlant		int," & vbNewLine & _
                                "PlantName		varchar(1000)," & vbNewLine & _
                                "SumByPlant     decimal(20,6) not null," & vbNewLine


        For i As Integer = 0 To nMonth
            Dim Name As String = Year & "" & month

            pCommand.CommandText &= "A" & Name & "			decimal(20,6) not null"

            If i <> nMonth Then
                pCommand.CommandText &= "," & vbNewLine
            Else
                pCommand.CommandText &= ");" & vbNewLine
            End If

            If month = 12 Then
                month = 1
                Year = Year + 1
            Else
                month = month + 1
            End If
        Next

        pCommand.CommandText &= " INSERT INTO @tpb_PlantSumMonth " & vbNewLine & _
                                " SELECT a.idPlant, a.PlantName," & vbNewLine & _
                                " (SELECT coalesce(SUM(Aa.SumValue),0) " & vbNewLine & _
                                " FROM @tpb_SmSalePlant Aa" & vbNewLine & _
                                " WHERE  Aa.idPlant = a.idPlant) As SumByPlant, " & vbNewLine

        Dim month1 As Integer = dtpMs.Value.Month
        Dim year1 As Integer = dtpMs.Value.Year

        If Microsoft.VisualBasic.Right(dtpMs.Text, 4) > 2500 Then
            year1 = year1 + 543
        End If

        For k As Integer = 0 To nMonth
            Dim Name As String = year1 & "" & month1
            Dim shortYear As Integer = year1
            Dim gc As New GridColumn
            With gc
                .Name = Name
                .Visible = True
                .FieldName = "A" & Name
                .Caption = ThaiMonth(month1) & " " & (shortYear.ToString).Substring(2, 2) & " " & strShowUnit
                .UnboundType = UnboundColumnType.Decimal
                .OptionsColumn.AllowEdit = False
                .OptionsColumn.ReadOnly = True
                .AppearanceCell.BackColor = Color.Gainsboro
                .AppearanceCell.Options.UseBackColor = True
                .AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
                .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .AppearanceHeader.Options.UseTextOptions = True
                .MaxWidth = 95
                .MinWidth = 95
                .DisplayFormat.FormatString = "#,##0.00####"
                .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom

            End With

            GVPlant.Columns.Add(gc)

            pCommand.CommandText &= " (SELECT coalesce(SUM(Aa.SumValue),0) " & vbNewLine & _
                                        " FROM @tpb_SmSalePlant Aa" & vbNewLine & _
                                        " WHERE Aa.monthSale = " & month1 & vbNewLine & _
                                        " AND Aa.YearSale = " & sYearS & vbNewLine & _
                                        " AND Aa.idPlant = a.idPlant) As A" & Name & vbNewLine

            If k <> nMonth Then
                pCommand.CommandText &= ","
            End If

            If month1 = 12 Then
                month1 = 1
                sYearS = sYearS + 1
                year1 = year1 + 1
            Else
                month1 = month1 + 1
            End If
        Next

        pCommand.CommandText &= " FROM @tpb_SmSalePlant a" & vbNewLine & _
                                " GROUP BY idPlant, PlantName" & vbNewLine & _
                                " SELECT * FROM @tpb_PlantSumMonth Order by PlantName ASC"
        pAdapter.Fill(dtAllPlantMt)

        If dtAllPlantMt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim addGVPdT1 As New GridColumn

        With addGVPdT1
            .Name = "ColNumPdT"
            .Visible = True
            .Caption = "ลำดับ"
            .OptionsColumn.AllowEdit = False
            .OptionsColumn.ReadOnly = True
            .AppearanceCell.BackColor = Color.Gainsboro
            .AppearanceCell.Options.UseBackColor = True
            .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .AppearanceCell.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .AppearanceHeader.Options.UseTextOptions = True
            .MaxWidth = 45
            .MinWidth = 45
        End With

        GVPdT.Columns.Add(addGVPdT1)

        Dim addGVPdT As New GridColumn
        With addGVPdT
            .Name = "colPdTName"
            .Visible = True
            .FieldName = "PdTName"
            .Caption = "ชื่อทางการค้า"
            .UnboundType = UnboundColumnType.String
            .OptionsColumn.AllowEdit = False
            .OptionsColumn.ReadOnly = True
            .AppearanceCell.BackColor = Color.LightBlue
            .AppearanceCell.Options.UseBackColor = True
            .AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .AppearanceHeader.Options.UseTextOptions = True
            .MinWidth = 180
        End With
        GVPdT.Columns.Add(addGVPdT)

        Dim addGVPdT2 As New GridColumn
        With addGVPdT2
            .Name = "colSumByPdT"
            .Visible = True
            .FieldName = "SumByPdT"
            .Caption = "ยอดรวมทั้งหมด " & strShowUnit
            .UnboundType = UnboundColumnType.Decimal
            .OptionsColumn.AllowEdit = False
            .OptionsColumn.ReadOnly = True
            .AppearanceCell.BackColor = Color.PaleGreen
            .AppearanceCell.Options.UseBackColor = True
            .AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .AppearanceHeader.Options.UseTextOptions = True
            .DisplayFormat.FormatString = "#,##0.00####"
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            .MinWidth = 95
            .MaxWidth = 95
        End With
        GVPdT.Columns.Add(addGVPdT2)

        'Set ค่า sYears ใหม่หลังจากที่มันโดนบวกไปแล้ว
        sYearS = sDateS.Year
        '----------------------DT----------------------------------
        pCommand.CommandText = ""
        pCommand.CommandText = "DECLARE @tpb_SmSalePdT TABLE(" & vbNewLine & _
                       "idPdT       int," & vbNewLine & _
                       "PdTName		varchar(1000)," & vbNewLine & _
                       "idPlant		int," & vbNewLine & _
                       "YearSale	int," & vbNewLine & _
                       "MonthSale	int," & vbNewLine & _
                       "SumValue	decimal(20,6));" & vbNewLine & _
                       "INSERT INTO @tpb_SmSalePdT(idPdT,PdTName,idPlant,YearSale,MonthSale,SumValue)" & vbNewLine & _
                       "exec [sp_frmSaleSummaryMonthx02] " & ShowType & "," & cmbGroupComp.SelectedValue & "," & stSalePd & "," & _
                       sMonthS & "," & sYearS & "," & sMonthE & "," & sYearE & "," & _
                       idPsSale & "," & idCus & "," & CheckGenP & "," & CheckMatP & "," & CheckTxt & ",'" & vHFStr & "'" & vbNewLine

        pCommand.CommandText &= "DECLARE @tpb_PlantSumMonthx02 table(" & vbNewLine & _
                                "idPdT          int," & vbNewLine & _
                                "PdTName		varchar(1000)," & vbNewLine & _
                                "idPlant		int," & vbNewLine & _
                                "SumByPdT       decimal(20,6) not null," & vbNewLine

        Dim month2 As Integer = dtpMs.Value.Month
        Dim year2 As Integer = dtpMs.Value.Year

        If Microsoft.VisualBasic.Right(dtpMs.Text, 4) > 2500 Then
            year2 = year2 + 543
        End If
        For i As Integer = 0 To nMonth
            Dim Name As String = year2 & "" & month2

            pCommand.CommandText &= "A" & Name & "			decimal(20,6) not null"

            If i <> nMonth Then
                pCommand.CommandText &= "," & vbNewLine
            Else
                pCommand.CommandText &= ");" & vbNewLine
            End If

            If month2 = 12 Then
                month2 = 1
                year2 = year2 + 1
            Else
                month2 = month2 + 1
            End If

        Next

        pCommand.CommandText &= " INSERT INTO @tpb_PlantSumMonthx02 " & vbNewLine & _
                                " SELECT a.idPdT, a.PdTName, a.idPlant," & vbNewLine & _
                                " (SELECT coalesce(SUM(Aa.SumValue),0) " & vbNewLine & _
                                " FROM @tpb_SmSalePdT Aa" & vbNewLine & _
                                " WHERE  Aa.idPdT = a.idPdT) As SumByPdT, " & vbNewLine
        Dim month4 As Integer = dtpMs.Value.Month
        Dim year4 As Integer = dtpMs.Value.Year

        If Microsoft.VisualBasic.Right(dtpMs.Text, 4) > 2500 Then
            year4 = year4 + 543
        End If


        For k As Integer = 0 To nMonth
            Dim Name As String = year4 & "" & month4
            Dim shortYear As Integer = year4
            Dim gc As New GridColumn
            With gc
                .Name = Name
                .Visible = True
                .FieldName = "A" & Name
                .Caption = ThaiMonth(month4) & " " & (shortYear.ToString).Substring(2, 2) & " " & strShowUnit
                .UnboundType = UnboundColumnType.Decimal
                .OptionsColumn.AllowEdit = False
                .OptionsColumn.ReadOnly = True
                .AppearanceCell.BackColor = Color.Gainsboro
                .AppearanceCell.Options.UseBackColor = True
                .AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
                .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .AppearanceHeader.Options.UseTextOptions = True
                .AppearanceCell.Options.UseFont = True
                .AppearanceCell.Options.UseTextOptions = True
                .MaxWidth = 95
                .MinWidth = 95
                .DisplayFormat.FormatString = "#,##0.00####"
                .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom

            End With

            GVPdT.Columns.Add(gc)

            pCommand.CommandText &= " (SELECT coalesce(SUM(Aa.SumValue),0) " & vbNewLine & _
                                        " FROM @tpb_SmSalePdT Aa" & vbNewLine & _
                                        " WHERE Aa.monthSale = " & month4 & vbNewLine & _
                                        " AND Aa.YearSale = " & sYearS & vbNewLine & _
                                        " AND Aa.idPdT = a.idPdT) As A" & Name & vbNewLine
            If k <> nMonth Then
                pCommand.CommandText &= ","
            End If

            If month4 = 12 Then
                month4 = 1
                sYearS = sYearS + 1
                year4 = year4 + 1
            Else
                month4 = month4 + 1
            End If
        Next

        pCommand.CommandText &= " FROM @tpb_SmSalePdT a" & vbNewLine & _
                                " GROUP BY idPdT, PdTName, idPlant" & vbNewLine & _
                                " SELECT * FROM @tpb_PlantSumMonthx02 Order by PdTName ASC"
        pAdapter.Fill(dtAllPlantDt)


        ds0.Tables.Clear()
        ds0.Tables.Add(dtAllPlantMt)
        ds0.Tables.Add(dtAllPlantDt)

        Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idPlant")
        Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idPlant")

        ds0.Relations.Add("ชื่อทางการค้า", keyColumn, foreignColumn)

        GCPlant.DataSource = ds0.Tables(0)
        Dim TempFilterHelper As FilterHelper = New FilterHelper(GVPlant)
        GCPlant.ForceInitialize()

        GCPlant.LevelTree.Nodes.Add("ชื่อทางการค้า", GVPdT)
        GVPlant.ExpandGroupLevel(0)

        'mdLoadCommitt()

    End Sub

    Private Function ThaiMonth(ByVal month As Integer) As String
        Dim strMonth As String = ""
        If month = 1 Then
            strMonth = "มกราคม"
        ElseIf month = 2 Then
            strMonth = "กุมภาพันธ์"
        ElseIf month = 3 Then
            strMonth = "มีนาคม"
        ElseIf month = 4 Then
            strMonth = "เมษายน"
        ElseIf month = 5 Then
            strMonth = "พฤษภาคม"
        ElseIf month = 6 Then
            strMonth = "มิถุนายน"
        ElseIf month = 7 Then
            strMonth = "กรกฎาคม"
        ElseIf month = 8 Then
            strMonth = "สิงหาคม"
        ElseIf month = 9 Then
            strMonth = "กันยายน"
        ElseIf month = 10 Then
            strMonth = "ตุลาคม"
        ElseIf month = 11 Then
            strMonth = "พฤศจิกายน"
        ElseIf month = 12 Then
            strMonth = "ธันวาคม"
        End If

        Return strMonth
    End Function

    Private Sub btnCus_Click(sender As Object, e As EventArgs) Handles btnCus.Click
        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelect, cmbGroupComp.SelectedValue)
        vFrm.ShowDialog()
        idCustomer = vFrm.idCus
        lblCus.Text = vFrm.CusName
    End Sub

    Public Shared Function MonthDifference(ByVal first As DateTime, ByVal second As DateTime) As Integer
        Return Math.Abs((first.Month - second.Month) + 12 * (first.Year - second.Year))
    End Function

    Private Sub CheckGenP_CheckedChanged(sender As Object, e As EventArgs) Handles CheckGenP.CheckedChanged
        If CheckGenP.Checked = True Then
            DirectCast(rdbGenPA, RadioButton).Checked = True
            DirectCast(rdbGenPA, RadioButton).Enabled = True
            DirectCast(rdbGenPN, RadioButton).Enabled = True
            DirectCast(rdbGenPC, RadioButton).Enabled = True
        Else
            DirectCast(rdbGenPA, RadioButton).Checked = False
            DirectCast(rdbGenPN, RadioButton).Checked = False
            DirectCast(rdbGenPC, RadioButton).Checked = False
            DirectCast(rdbGenPA, RadioButton).Enabled = False
            DirectCast(rdbGenPN, RadioButton).Enabled = False
            DirectCast(rdbGenPC, RadioButton).Enabled = False

            If Me.CheckGenP.Checked = False And Me.CheckMatP.Checked = False Then
                MessageBox.Show("กรุณาระบุประเภทสินค้าอย่างน้อย 1 ประเภท", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.CheckGenP.Checked = True
            End If

        End If

        fnClearDataONGrid()
    End Sub

    Private Sub CheckMatP_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMatP.CheckedChanged
        If Me.CheckGenP.Checked = False And Me.CheckMatP.Checked = False Then
            MessageBox.Show("กรุณาระบุประเภทสินค้าอย่างน้อย 1 ประเภท", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.CheckMatP.Checked = True
        End If

        fnClearDataONGrid()
    End Sub

    Private Sub cbFindPlantName_CheckedChanged(sender As Object, e As EventArgs) Handles cbFindPlantName.CheckedChanged
        If cbFindPlantName.Checked = True Then
            txtPlantName.Enabled = True
            txtPlantName.Focus()
        Else
            txtPlantName.Enabled = False
            txtPlantName.Text = ""
        End If
        If stLoad = 1 Then
            fnClearDataONGrid()
        End If
    End Sub

    Private Sub chkPdT_CheckedChanged(sender As Object, e As EventArgs) Handles chkPdT.CheckedChanged
        If chkPdT.Checked = True Then
            txtPdTName.Enabled = True
            txtPdTName.Focus()
        Else
            txtPdTName.Enabled = False
            txtPdTName.Text = ""
        End If
        GVPlant.FindFilterText = txtPdTName.Text
        GVPlant.ExpandAllGroups()
    End Sub

    Private Sub rdbGenPC_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGenPC.CheckedChanged
        If rdbGenPC.Checked = True Then
            Me.CheckedComboBoxType.Enabled = True
        Else
            Me.CheckedComboBoxType.Enabled = False
        End If
    End Sub

    Private Sub BGSummary_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVPlant.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub GVPdT_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVPdT.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNumPdT" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub FilterOnGrid()
        Dim sql = ""

        If cbFindPlantName.Checked = True Then
            sql &= " AND [PlantName] like '%" & txtPlantName.Text & "%'"
        End If

        GVPlant.ActiveFilterString = " 1=1" + sql
    End Sub

    Private Sub txtInvName_KeyUp(sender As Object, e As EventArgs) Handles txtPlantName.TextChanged
        FilterOnGrid()
    End Sub

    Private Sub txtPdTName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPdTName.KeyUp
        GVPlant.FindFilterText = txtPdTName.Text
        GVPlant.ExpandAllGroups()
    End Sub

    Private Sub fnClearDataONGrid()
        Dim dt As New DataTable
        GVPlant.Columns.Clear()
        GVPdT.Columns.Clear()

        GCPlant.DataSource = dt
    End Sub

    Private Sub rdbThai_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAllSale.CheckedChanged, rdbThai.CheckedChanged, rdbExp.CheckedChanged
        If stLoad = 1 Then
            fnClearDataONGrid()
        End If
    End Sub

    Private Sub rdbSale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSale.CheckedChanged, rdbKg.CheckedChanged, _
                 rdbUnitSale.CheckedChanged, cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            fnClearDataONGrid()

            Dim stLine = fnSetSaleLine()

            If stLine = 0 Then
                Me.Close()
                Exit Sub
            Else
                cmbPsSale.SelectedValue = sPsId
                SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                ShowDataOnGrid()
                SplashScreenManager.CloseForm(False)
            End If
        End If
    End Sub

    Private Sub rdbGenPA_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGenPA.CheckedChanged, rdbGenPN.CheckedChanged, rdbGenPC.CheckedChanged
        If stLoad = 1 Then
            fnClearDataONGrid()
        End If
    End Sub

    Private Sub dtpMs_ValueChanged(sender As Object, e As EventArgs) Handles dtpMs.ValueChanged, dtpMe.ValueChanged
        If stLoad = 1 Then
            fnClearDataONGrid()
        End If
    End Sub

End Class