Public Class frmPdPkLotSelect
    Dim lotDtCut As New DataTable
    Public getLotDt As New DataTable
    Public pidPdPkLot As Integer = 0
    Dim sDt3 As New DataTable
    Dim stPage As Integer = 0
    Dim eEvent As eProcess

    Enum eProcess
        ePdGen  ' สินค้าทั่วไป
        ePdPack   ' สินค้าผักซอง
        ePdAll  ' สินค้าทั้งหมด
        ePdFolwer   ' สินค้าดอกไม้
        ePdAllLot 'สินค้าทุก Lot ที่หมดแล้วด้วย
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idPdPkLotdt As DataTable)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.ePdGen
                stPage = 1
            Case eProcess.ePdPack
                stPage = 2
            Case eProcess.ePdAll
                stPage = 3
            Case eProcess.ePdFolwer
                stPage = 4
            Case eProcess.ePdAllLot
                stPage = 5
        End Select
        lotDtCut = idPdPkLotdt
        eEvent = aProcess
    End Sub

    Private Sub frmPdPkLotSelect_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        getLotDt.Columns.Add("idPdPkLot", System.Type.GetType("System.Int64"))
        Me.txtPdName.Focus()

        BindData()
        If stPage = 5 Then
            Me.btn_add.Visible = False
            Me.ChkNoStock.Checked = False
            Me.ChkNoStock.Visible = False
        End If
    End Sub

   
    Private Sub BindData()
        mdCnOpen()
        mdLoadShow()
        For i As Integer = 0 To sDt3.Rows.Count - 1
            If sDt3.Rows(i).Item("ChkKey") = True Then
                Dim stAddlot As Integer = 0
                For j As Integer = 0 To getLotDt.Rows.Count - 1
                    If sDt3.Rows(i).Item("idPdPkLot") = getLotDt.Rows(j).Item("idPdPkLot") Then
                        stAddlot = 1
                        Exit For
                    End If
                Next

                If stAddlot = 0 Then
                    getLotDt.Rows.Add(sDt3.Rows(i).Item("idPdPkLot"))
                End If
            End If
        Next

        Dim vWhere As String = ""

        If stPage = 1 Then  ' สินค้าทั่วไป
            vWhere = vWhere & "  AND  (l.idType IS NULL or l.idType = '0') "
        ElseIf stPage = 2 Then   ' สินค้าผักซอง
            vWhere = vWhere & "  AND  l.idType = '1' "
        ElseIf stPage = 4 Then  ' สินค้าดอกไม้         
            vWhere = vWhere & "  AND  l.idSeedKind = '2' "
        End If

        If ChkPd.Checked = True Then
            Dim tx As String = txtPdName.Text
            Dim tx_a As String() = tx.Split(" ")
            Dim a_and As String = ""
            Dim strPdPk As String = ""
            If tx_a.Length > 0 Then
                For Each txt As String In tx_a
                    If Not txt.Equals("") Then
                        strPdPk += a_and & "" & String.Format(" l.PdPkName Like '%{0}%' ", txt)
                    End If
                    a_and = " and "
                Next
            End If

            If strPdPk <> "" Then
                vWhere = vWhere & " AND " & strPdPk
            End If
        End If

        If ChkLot.Checked = True Then
            vWhere = vWhere & " AND  l.LotNum = '" & txtLot.Text & "' "
        End If

        If Me.ChkNoStock.Checked = True Then
            vWhere = vWhere & " AND l.Amount > '0' "
        End If

        If lotDtCut.Rows.Count > 0 Then
            Dim stridCut As String = ""
            For i As Integer = 1 To lotDtCut.Rows.Count - 1
                stridCut = stridCut & " AND l.idPdPkLot <> " & lotDtCut.Rows(i).Item("idPdPkLot") & " "
            Next

            vWhere = vWhere & " AND (l.idPdPkLot <> " & lotDtCut.Rows(0).Item("idPdPkLot") & stridCut & ") "
        End If

        If sIdComp = 10 Then 'สตาร์อะกรีเทค
            vWhere = vWhere & " AND (l.CompRec = 4 OR l.CompRec = " & sIdComp & ") "
        Else
            vWhere = vWhere & " AND l.CompRec = " & sIdComp & " "
        End If


        Dim vUnit1 As String = ""
        vUnit1 = " AND p.idUnitW = 1 "

        Dim vUnit2 As String = ""
        vUnit2 = " AND p.idUnitW = 2 "

        Dim ds0 As New DataSet
        Dim sDt As New DataTable
        Dim sDt2 As New DataTable


        sDt.Clear()
        'sCommand.CommandText = "Select p.idPdPk, p.PdPkName, p.ShortName, SUM(l.Amount) As Amount, p.PkUnitName, " & _
        '                       "(p.Weight * p.Amount) As WightOfKg From vPackingPdSet p LEFT OUTER JOIN " & _
        '                       "vSlPdTradeNameD t ON p.idPdT = t.idPdT LEFT OUTER JOIN vPackingPdSetLot l " & _
        '                       "ON p.idPdPk = l.idPdPk WHERE p.stDel IS NULL AND l.CompRec = " & sIdComp & vWhere & vUnit2 & " Group By p.idPdPk, p.PdPkName, " & _
        '                       "p.ShortName, p.PkUnitName,p.Weight UNION " & _
        '                       "Select p.idPdPk, p.PdPkName, p.ShortName, p.Amount, p.PkUnitName, (p.Weight*p.Amount/1000) As WightOfKg " & _
        '                       "From vPackingPdSet p LEFT OUTER JOIN vSlPdTradeNameD t ON p.idPdT = t.idPdT " & _
        '                       "LEFT OUTER JOIN dPackingPdSetLot l ON p.idPdPk = l.idPdPk WHERE " & _
        '                       "p.stDel IS NULL AND l.CompRec = " & sIdComp & vWhere & vUnit1 & " Group By p.idPdPk, p.PdPkName, " & _
        '                       "p.ShortName, p.PkUnitName,p.Weight Order by p.PdPkName"
        'sCommand.CommandText = "SELECT idPdPk,  PdPkName, ShortName, Amount, PkUnitName, (Weight*Amount/1000) As WightOfKg " & _
        '                      "FROM  (Select p.idPdPk, p.PdPkName, p.ShortName, SUM(l.Amount) As Amount, p.PkUnitName, p.Weight " & _
        '                      "From vPackingPdSet p LEFT OUTER JOIN vSlPdTradeNameD t ON p.idPdT = t.idPdT " & _
        '                      "LEFT OUTER JOIN vPackingPdSetLot l ON p.idPdPk = l.idPdPk WHERE p.stDel IS NULL AND l.stDel = 0 " & _
        '                      "AND l.CompRec = " & sIdComp & vWhere & vUnit1 & " Group By p.idPdPk, p.PdPkName, p.ShortName, " & _
        '                      "p.PkUnitName,p.Weight) as db1 UNION SELECT idPdPk,  PdPkName, ShortName, Amount, PkUnitName, " & _
        '                      "(Weight*Amount) As WightOfKg FROM  (Select p.idPdPk, p.PdPkName, p.ShortName, SUM(l.Amount) As Amount, " & _
        '                      "p.PkUnitName, p.Weight From vPackingPdSet p LEFT OUTER JOIN vSlPdTradeNameD t ON " & _
        '                      "p.idPdT = t.idPdT LEFT OUTER JOIN vPackingPdSetLot l ON p.idPdPk = l.idPdPk " & _
        '                      "WHERE p.stDel IS NULL AND l.stDel = 0 AND l.CompRec = " & sIdComp & vWhere & vUnit2 & " Group By p.idPdPk, p.PdPkName, " & _
        '                      "p.ShortName, p.PkUnitName,p.Weight) as db2 Order by PdPkName"
        sCommand.CommandText = "Select l.idPdPk, l.PdPkName, l.ShortName, SUM(l.Amount) As Amount, l.PkUnitName " & _
                              "From vPackingPdSetLotxSelect l WHERE ISNULL(l.stDel,0) = 0 AND l.stType <> 1  " & vWhere & " Group By " & _
                              "l.idPdPk, l.PdPkName, l.ShortName, l.PkUnitName Order by l.PdPkName"
        sAdapter.Fill(sDt)

        sDt2.Clear()
        'sCommand.CommandText = "Select l.idPdPk, l.LotNum, l.Amount, l.WareHouseName, " & _
        '                       "devsk.fncStrDateToDateTime(r.DateDoc) As DateDoc, l.idPdPkLot " & _
        '                       "From vPackingPdSetLot l LEFT OUTER JOIN PkPdPkUpdateRec r " & _
        '                       "On l.idUpdate = r.idUpdate LEFT OUTER JOIN vPackingPdSet p " & _
        '                       "On l.idPdPk = p.idPdPk LEFT OUTER JOIN vSlPdTradeNameD t " & _
        '                       "ON p.idPdT = t.idPdT WHERE p.stDel IS NULL AND l.CompRec = " & sIdComp & vWhere & " Order by l.idPdPkLot"
        'sCommand.CommandText = "Select l.idPdPk, l.idPdPkLot, l.LotNum, l.Amount, l.DateGen, l.WareHouseName, l.CompNameRec As CompName, l.CompRec " & _
        '                       "From vPackingPdSetLot l LEFT OUTER JOIN vPackingPdSet p On l.idPdPk = p.idPdPk LEFT OUTER JOIN vSlPdTradeNameD t " & _
        '                       "ON p.idPdT = t.idPdT WHERE l.stDel = 0 AND l.CompRec = " & sIdComp & vWhere & " Order by l.idPdPkLot"

        sCommand.CommandText = "Select l.idPdPk, l.idPdPkLot, l.LotNum, l.Amount, devsk.fncStrDateToDateTime(DateGen) As DateGen, " & _
                              "l.WareHouseName, l.CompNameRec As CompName, " & _
                               "l.CompRec From vPackingPdSetLotxSelect l WHERE l.stDel = 0 And l.stType <> 1 " & vWhere & " Order by l.idPdPkLot"
        sAdapter.Fill(sDt2)
        sDt2.Columns.Add("ChkKey", System.Type.GetType("System.Boolean"))

        For i As Integer = 0 To sDt2.Rows.Count - 1
            ' sDt2.Rows(i).Item("DateDoc") = ksbStringToDate(sDt2.Rows(i).Item("DateDoc"))
            sDt2.Rows(i).Item("ChkKey") = False
            For j As Integer = 0 To getLotDt.Rows.Count - 1
                If sDt2.Rows(i).Item("idPdPkLot") = getLotDt.Rows(j).Item("idPdPkLot") Then
                    sDt2.Rows(i).Item("ChkKey") = True
                End If
            Next
        Next
        sDt3 = sDt2

        ds0.Tables.Clear()
        ds0.Tables.Add(sDt)
        ds0.Tables.Add(sDt2)

        Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idPdPk")
        Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idPdPk")

        ds0.Relations.Add("ล็อตสินค้า", keyColumn, foreignColumn)

        GridControl1.DataSource = ds0.Tables(0)
        GridControl1.ForceInitialize()

        GridControl1.LevelTree.Nodes.Add("ล็อตสินค้า", GridView2)

        mdLoadCommitt()
        If sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

    End Sub

    Private Sub ChkPd_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPd.CheckedChanged
        If Me.ChkPd.Checked = True Then
            Me.txtPdName.Enabled = True
            Me.txtPdName.Focus()
        Else
            Me.txtPdName.Enabled = False
        End If
    End Sub

    Private Sub ChkLot_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLot.CheckedChanged
        If Me.ChkLot.Checked = True Then
            Me.txtLot.Enabled = True
            Me.txtLot.Focus()
        Else
            Me.txtLot.Enabled = False
        End If
    End Sub

    Private Sub btnSchPd_Click(sender As Object, e As EventArgs) Handles btnSchPd.Click
        BindData()
    End Sub

    Private Sub txtPdName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPdName.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindData()
        End If
    End Sub

    Private Sub txtLot_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindData()
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        For i As Integer = 0 To sDt3.Rows.Count - 1
            If sDt3.Rows(i).Item("ChkKey") = True Then
                Dim stAddlot2 As Integer = 0
                For j As Integer = 0 To getLotDt.Rows.Count - 1
                    If sDt3.Rows(i).Item("idPdPkLot") = getLotDt.Rows(j).Item("idPdPkLot") Then
                        stAddlot2 = 1
                        Exit For
                    End If
                Next

                If stAddlot2 = 0 Then
                    getLotDt.Rows.Add(sDt3.Rows(i).Item("idPdPkLot"))
                End If
            End If
        Next

        If getLotDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("กรุณาเลือกล็อตสินค้าอย่างน้อย 1 รายการ", sSystemName)
            Exit Sub
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub RepositoryItemCheckEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.Click
        If stPage = 5 Then
            Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GridControl1.FocusedView
            pidPdPkLot = detailView.GetRowCellValue(detailView.FocusedRowHandle, ColidPdPkLot)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If



    End Sub
End Class