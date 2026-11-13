Public Class frmLotReturnSelect

    Enum eProcess
        eLotRTSelect
    End Enum

    Public dtSmSale As New DataTable

    Dim gidPartner As Integer = 0
    Dim aProcess As eProcess
    Dim stLoad As Integer = 0
    Dim idSaleCutDt As New DataTable
    Dim gidComp As Integer = 0
    Dim gPartnerName As String = ""
    Dim DefaultDate As Date
    Sub New(ByVal Process As eProcess, ByVal vDateMFG As Date, ByVal idPartner As Integer,
            ByVal PartnerName As String, ByVal idComp As Integer, ByVal idSaleDt As DataTable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        DefaultDate = vDateMFG
        gidPartner = idPartner
        aProcess = Process
        gPartnerName = PartnerName
        gidComp = idComp
        idSaleCutDt = idSaleDt
    End Sub

    Private Sub frmLotReturnSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInvGroup()
        fnAddDataTable(dtSmSale)
        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()
        SetDefaultInvGroup()
        FilterDataOnGrid()
        stLoad = 1

    End Sub

    Private Sub SetDefaultInvGroup()
        Select Case gidComp
            Case 4, 5, 10, 13, 58
                cmbInvName.SelectedValue = 2 'FG
            Case 12
                cmbInvName.SelectedValue = 28 'ฮอร์โมน
            Case 55, 60
                cmbInvName.SelectedValue = 29 'พลาสติก
            Case 2, 3
                cmbInvName.SelectedValue = 1 ' เมล็ดพันธ์วัตถุดิบ
            Case 7, 11, 59, 63, 64
                cmbInvName.SelectedValue = 3 'เบ็ดเตล็ด
            Case 7
                cmbInvName.SelectedValue = 36 'ปุ๋ย
            Case 54
                cmbInvName.SelectedValue = 33 'ผลสด
            Case 8
                cmbInvName.SelectedValue = 40 'โสหุ้ย
            Case Else
                cmbInvName.SelectedValue = 3 'เบ็ดเตล็ด
        End Select
    End Sub

    Private Sub fnAddDataTable(ByVal dt As DataTable)

        dt.Columns.Add("idSale", System.Type.GetType("System.Int64"))
        dt.Columns.Add("idSaleDt", System.Type.GetType("System.Int64"))
        dt.Columns.Add("DocRef", System.Type.GetType("System.String"))
        dt.Columns.Add("idLot", System.Type.GetType("System.Int64"))
        dt.Columns.Add("LotNo", System.Type.GetType("System.String"))
        dt.Columns.Add("idProduct", System.Type.GetType("System.Int64"))
        dt.Columns.Add("ProductName", System.Type.GetType("System.String"))
        dt.Columns.Add("idUnit", System.Type.GetType("System.Int64"))
        dt.Columns.Add("UnitName", System.Type.GetType("System.String"))
        dt.Columns.Add("PriceSale", System.Type.GetType("System.Double")) 'ราคาขาย
        dt.Columns.Add("AmtSale", System.Type.GetType("System.Double")) 'จำนวนขาย
        dt.Columns.Add("DateGen", System.Type.GetType("System.DateTime"))
        dt.Columns.Add("AmountRT", System.Type.GetType("System.Double"))
        dt.Columns.Add("idInvGroup", System.Type.GetType("System.Int64"))
    End Sub

    Private Sub BindData()

        Dim vWhere As String = ""
        If idSaleCutDt.Rows.Count > 0 Then
            Dim stridCut As String = ""

            For i As Integer = 1 To idSaleCutDt.Rows.Count - 1
                stridCut = stridCut & " AND (dt.idSaleDt <> " & idSaleCutDt.Rows(i).Item("idSaleDt") & ") "
            Next

            vWhere = vWhere & " AND (dt.idSaleDt <> " & idSaleCutDt.Rows(0).Item("idSaleDt") & stridCut & ") "
        End If

        If gidComp = 4 Or gidComp = 10 Then
            vWhere = vWhere & " AND lm.CompRec IN (4,10) "
        Else
            vWhere = vWhere & " AND lm.CompRec = " & gidComp
        End If

        If rdbOnlyCus.Checked = True Then
            vWhere = vWhere & "AND mt.idPartner = " & gidPartner
        End If

        Dim sDt As New DataTable

        sCommand.CommandText = "SELECT CONVERT(bit,0) As chk, mt.DocRef, dt.idSaleDt, mt.idSale, dt.idLot, dt.LotNo, dt.idProduct, dt.idUnit, dt.ProductName, inv.idInvGroup, " & vbNewLine &
                                "lm.DateGen, unit.UnitName, dt.Price, dt.Amount As AmtSale, mt.PartnerNameBill As PartnerName, mt.idPartner" & vbNewLine &
                                "FROM SmSaleDtAll As dt" & vbNewLine &
                                "LEFT JOIN SmSaleMt As mt ON dt.idSale = mt.idSale" & vbNewLine &
                                "LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine &
                                "LEFT JOIN dInvLotMain As lm ON dt.idLot = lm.idLot" & vbNewLine &
                                "LEFT JOIN dInventoryMain As inv ON lm.idInvMain = inv.idInvMain" & vbNewLine &
                                "WHERE ISNULL(lm.stDel,0) = 0  " & vbNewLine &
                                "AND mt.idPsCancel Is NULL" & vbNewLine &
                                vWhere & vbNewLine &
                                "Order By DocRef ASC"

        sAdapter.Fill(sDt)

        GCProduct.DataSource = sDt
    End Sub

    Private Sub LoadInvGroup()
        mdCnOpen()
        Dim dtInvGroup As New DataTable

        sCommand.CommandText = "SELECT Distinct idInvGroup, InvGroupName " & vbNewLine &
                               "FROM dInvGroup " & vbNewLine &
                               "Where idInvGroup <> 30  AND stSaleProduct = 1 ORDER BY InvGroupName ASC "
        'WHERE stSaleProduct = 1

        sAdapter.Fill(dtInvGroup)

        If dtInvGroup.Rows.Count > 0 Then
            cmbInvName.DisplayMember = "InvGroupName"
            cmbInvName.ValueMember = "idInvGroup"
            cmbInvName.DataSource = dtInvGroup

        End If

    End Sub

    Private Sub rdbAllSale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAllSale.CheckedChanged, rdbOnlyCus.CheckedChanged
        If stLoad = 1 Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()

            FilterDataOnGrid()
        End If
    End Sub

    Private Sub cmbInvName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbInvName.SelectedValueChanged
        If stLoad = 1 Then
            FilterDataOnGrid()
        End If
    End Sub

    Private Sub FilterDataOnGrid()
        Dim StrFilter = " [idInvGroup] = " & cmbInvName.SelectedValue

        Dim tx As String = txtInvName.Text
        Dim tx_a As String() = tx.Split(" ")
        Dim a_and As String = ""
        Dim strPdPk As String = ""
        If tx_a.Length > 0 Then
            For Each txt As String In tx_a
                If Not txt.Equals("") Then
                    strPdPk += a_and & "" & String.Format(" [ProductName] Like '%{0}%' ", txt)
                End If
                a_and = " and "
            Next
        End If

        If chkInvName.Checked = True And strPdPk <> "" Then
            StrFilter &= " AND " & strPdPk
        End If

        If chkLotNo.Checked = True And txtLotNo.Text.Trim <> "" Then
            StrFilter &= " AND [LotNo] Like '%" & txtLotNo.Text.Trim & "%'"
        End If

        GVProduct.ActiveFilterString = StrFilter
        GVProduct.ExpandAllGroups()
        txtCount.Text = Format(GVProduct.DataRowCount, "#,##0")
    End Sub

    Private Sub txtInvName_TextChanged(sender As Object, e As EventArgs) Handles txtInvName.TextChanged
        If stLoad = 1 Then
            FilterDataOnGrid()
        End If
    End Sub

    Private Sub chkInvName_CheckedChanged(sender As Object, e As EventArgs) Handles chkInvName.CheckedChanged
        If stLoad = 1 Then
            If chkInvName.Checked = True Then
                txtInvName.Enabled = True
                txtInvName.Focus()
            Else
                txtInvName.Enabled = False
                txtInvName.Text = ""
            End If
        End If
    End Sub

    Private Sub chkLotNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkLotNo.CheckedChanged
        If stLoad = 1 Then
            If chkLotNo.Checked = True Then
                txtLotNo.Enabled = True
                txtLotNo.Focus()
            Else
                txtLotNo.Enabled = False
                txtLotNo.Text = ""
            End If
        End If
    End Sub

    Private Sub txtLotNo_TextChanged(sender As Object, e As EventArgs) Handles txtLotNo.TextChanged
        If stLoad = 1 Then
            FilterDataOnGrid()
        End If
    End Sub

    Private Sub rptSelect_Click(sender As Object, e As EventArgs) Handles rptSelect.Click

        Dim dr_ As DataRow = dtSmSale.NewRow

        dr_("idSale") = GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, "idSale")
        dr_("idSaleDt") = GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, "idSaleDt")
        dr_("DocRef") = GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, "DocRef")
        dr_("idLot") = GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, "idLot")
        dr_("LotNo") = GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, "LotNo")
        dr_("idProduct") = GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, "idProduct")
        dr_("ProductName") = GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, "ProductName")
        dr_("idUnit") = GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, "idUnit")
        dr_("UnitName") = GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, "UnitName")
        dr_("PriceSale") = GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, "Price")
        dr_("AmtSale") = GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, "AmtSale")
        dr_("DateGen") = GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, "DateGen")
        dr_("idInvGroup") = GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, "idInvGroup")
        dr_("AmountRT") = 1
        dtSmSale.Rows.Add(dr_)

        GCSelected.DataSource = dtSmSale
    End Sub

    Private Sub btnAddLot_Click(sender As Object, e As EventArgs) Handles btnAddLot.Click
        Dim dt As New DataTable

        Dim vFrm As New frmSlReturnNoBill(frmSlReturnNoBill.eProcess.eAddNew, Date.Now, gidComp, "", gidPartner, gPartnerName, dt, 0)

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim dr_ As DataRow = dtSmSale.NewRow

            dr_("idSale") = vFrm.dtSmSale.Rows(0).Item("idSale")
            dr_("idSaleDt") = vFrm.dtSmSale.Rows(0).Item("idSaleDt")
            dr_("DocRef") = vFrm.dtSmSale.Rows(0).Item("DocRef")
            dr_("idLot") = vFrm.dtSmSale.Rows(0).Item("idLot")
            dr_("LotNo") = vFrm.dtSmSale.Rows(0).Item("LotNo")
            dr_("idProduct") = vFrm.dtSmSale.Rows(0).Item("idProduct")
            dr_("ProductName") = vFrm.dtSmSale.Rows(0).Item("ProductName")
            dr_("idUnit") = vFrm.dtSmSale.Rows(0).Item("idUnit")
            dr_("UnitName") = vFrm.dtSmSale.Rows(0).Item("UnitName")
            dr_("PriceSale") = 0
            dr_("AmtSale") = 0
            dr_("DateGen") = vFrm.dtSmSale.Rows(0).Item("DateGen")
            dr_("idInvGroup") = vFrm.dtSmSale.Rows(0).Item("idInvGroup")
            dr_("AmountRT") = vFrm.dtSmSale.Rows(0).Item("AmountRT")
            dtSmSale.Rows.Add(dr_)

            GCSelected.DataSource = dtSmSale
        End If
    End Sub

    Private Sub btnSel_Click(sender As Object, e As EventArgs) Handles btnSel.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class