Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmInvLotSelect
    Public MainReturn As New DataTable
    Public DtType As Integer
    Public idPdOService As Integer = 0
    Dim gidComp As Integer = 0
    Dim gCompName As String = ""
    Dim stLoad As Integer = 0

    Private Sub frmInvLotSelect_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtInvName.Focus()
        LoadInvGroup()
        fnAddDataTable()
        BindDatabyInvGroup()
        stLoad = 1
        SetDefaultInvGroup()
        FilterDataOnGrid()
        Me.Text = "เลือกสินค้า (" & gCompName & ")"

    End Sub

    Public Sub GetCompany(ByVal idComp As Integer, ByVal CompName As String)
        gidComp = idComp
        gCompName = CompName
    End Sub

    Private Sub SetDefaultInvGroup()
        Select Case gidComp
            Case 4, 10, 13, 58, 5
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


#Region "fnAddDataTable"
    Private Sub fnAddDataTable()
        MainReturn.Columns.Add("idInvMain", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("InvName", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("LotNo", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("idLot", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idInvGroup", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("UnitName", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("idUnit", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("AmtStock", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("DtType", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idSubType", System.Type.GetType("System.Int64"))
        'MainReturn.Columns.Add("idPdPkLot", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idWh", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("PriceBill_fg", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("PriceWholesale_fg", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("PriceRetail_fg", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("CreditThirty_pdo", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("CreditSixty_pdo", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("PricePdo_pdo", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("idPdoType", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("PdCode", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("idLotSPM", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("PriceSeed", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("idRefLot", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idSaleOrderDt", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("CompRec", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("pWeight", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("idUnitW", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("full_lock", System.Type.GetType("System.String"))
    End Sub
#End Region

    Private Sub LoadInvGroup()
        mdCnOpen()
        Dim dtInvGroup As New DataTable

        sCommand.CommandText = "SELECT Distinct idInvGroup, InvGroupName " & vbNewLine & _
                               "FROM dInvGroup " & vbNewLine & _
                               "Where idInvGroup IN (SELECT inv.idInvGroup " & vbNewLine & _
                                                    "FROM dInvLotRefWh wh " & vbNewLine & _
                                                    "LEFT JOIN dInvLotMain main  ON main.idLot = wh.idLot" & vbNewLine & _
                                                    "LEFT JOIN dInventorymain inv ON main.idInvMain = inv.idInvMain" & vbNewLine & _
                                                    "WHERE main.CompRec IN (" & gidComp & ")" & vbNewLine & _
                                                    "AND wh.Amount > 0 AND main.stDel Is NULL)" & " AND idInvGroup <> 30  ORDER BY InvGroupName ASC "
        'WHERE stSaleProduct = 1

        sAdapter.Fill(dtInvGroup)

        If dtInvGroup.Rows.Count > 0 Then
            cmbInvName.DisplayMember = "InvGroupName"
            cmbInvName.ValueMember = "idInvGroup"
            cmbInvName.DataSource = dtInvGroup
        Else

            MessageBox.Show("ไม่พบ Lot สินค้าของ " & gCompName, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Exit Sub

        End If

    End Sub

    Private Sub BindDatabyInvGroup()
        Dim ds0 As New DataSet
        Dim sDt As New DataTable
        Dim vWhere As String = ""

        If gidComp = 10 Or gidComp = 4 Then 'สตาร์อะกรีเทค
            vWhere = vWhere & " AND (lm.CompRec = 4 OR lm.CompRec = " & gidComp & ") "
        Else
            vWhere = vWhere & " AND lm.CompRec = " & gidComp & " "
        End If

        mdCnOpen()
        mdLoadShow()

        sCommand.CommandText = "SELECT lm.idLot, inv.idInvMain, ref.idWh, lm.CompRec, inv.InvName, inv.InvName As InvNameShow," & vbNewLine &
                               "d.ShortName, inv.idInvGroup, lm.LotNo, unit.idUnit, g.InvGroupName, d.idUnitW, d.Weight, sfg.WPerPack, " & vbNewLine &
                               "unit.UnitName, swh.full_lock + CASE WHEN ISNULL(ref.idBox,0) <> 0 THEN '>' + pn.PartnerName ELSE '' END As full_lock, " & vbNewLine &
                               " inv.idSubType, IsNULL(lm.idLotOldSys,0) As idPdPkLot, g.dtType, ref.Amount," & vbNewLine &
                               "IsNULL(d.PriceBill,0) As PriceBill_fg, IsNULL(d.PriceWholesale,0) As PriceWholesale_fg, IsNULL(d.PriceRetail,0) As PriceRetail_fg," & vbNewLine &
                               "ISNULL(CreditThirty,0) As CreditThirty_pdo, ISNULL(CreditSixty,0) As CreditSixty_pdo, IsNULL(o.Price,0) As PricePdo_pdo," & vbNewLine &
                               "ISNULL(o.idPdoType,0) As idPdoType, CASE WHEN inv.idInvGroup = 2 THEN d.PdCode ELSE ISNULL(ic.InvCode,'') END As PdCode, IsNULL(sfg.Price,0) As PriceSeedFg_sfg, ISNULL(p.Price,0) As PriceSeed, " & vbNewLine &
                               "IsnULL(lm.idLotSPM,0) As idLotSPM," & vbNewLine &
                               "ref.idRefLot, ISNULL(lm.idSaleOrderDt,0) As idSaleOrderDt, devsk.fncChkLotCount(lm.idLot) As stCountStock" & vbNewLine &
                               "FROM vInvLotRefWh_RStock As ref" & vbNewLine &
                               "Left JOIN WimReturnBox rtb On ref.idBox = rtb.idBox And ref.idBox Is Not NULL" & vbNewLine &
                               "LEFT JOIN SmSaleReturnDt sDt ON rtb.idSaleReturnDt = sDt.idSaleReturnDt " & vbNewLine &
                               "LEFT JOIN SmSaleReturnMt sMt ON sDt.idSaleReturn = sMt.idSaleReturn " & vbNewLine &
                               "LEFT JOIN dPartner pn ON sMt.idPartner = pn.idPartner" & vbNewLine &
                               "LEFT JOIN dInvLotMain As lm On  ref.idLot = lm.idLot" & vbNewLine &
                               "LEFT JOIN dInventoryMain As inv On lm.idInvMain = inv.idInvMain" & vbNewLine &
                               "LEFT JOIN dInvCode As ic On inv.idInvMain = ic.idInvMain " & vbNewLine &
                               "LEFT JOIN dInvGroup As g On inv.idInvGroup = g.idInvGroup" & vbNewLine &
                               "LEFT JOIN dInvUnit As unit On ref.idUnit = unit.idUnit " & vbNewLine &
                               "LEFT JOIN SsWareHouse As swh On ref.idWh = swh.idWh" & vbNewLine &
                               "LEFT JOIN dPackingPdSet As d On inv.idSubType = d.idPdPk And inv.idInvGroup = 2" & vbNewLine &
                               "LEFT JOIN SmPdOtherD As o On inv.idSubType = o.idPdO And g.stPdOther = 1" & vbNewLine &
                               "LEFT JOIN dSeedFlPackage sfg On inv.idSubType = sfg.idFlPk And inv.idInvgroup = 42" & vbNewLine &
                               "LEFT JOIN dSeedProductPrice p On inv.idInvMain = p.idInvMain And inv.idInvGroup = 1 And p.idComp = " & gidComp & vbNewLine &
                               "WHERE lm.stDel Is NULL" & vbNewLine &
                               "And ref.Amount > 0" & vbNewLine &
                               "--And inv.stNotSale Is NULL" & vbNewLine &
                               vWhere

        sAdapter.Fill(sDt)

        GCProduct.DataSource = sDt

        txtCount.Text = Format(GVProduct.DataRowCount, "#,##0")
        mdLoadCommitt()
        'GVProduct.ExpandAllGroups()
    End Sub

    Private Sub FilterDataOnGrid()
        Dim sql = " [Amount] > 0 "

        'If ChkNoStock.Checked = True Then
        '    sql &= " And [Amount] > 0 "
        'End If

        If ChkInvGroup.Checked = True Then
            sql &= " And [idInvGroup] = " & cmbInvName.SelectedValue
        End If

        If chkLotNo.Checked = True Then
            sql &= " And [LotNo] Like '%" & Trim(txtLotNo.Text) & "%'"
        End If

        If chkInvName.Checked = True Then
            Dim str As String = txtInvName.Text
            Dim parts As String() = str.Split(New Char() {" "})

            Dim part As String
            For Each part In parts
                sql &= " AND [InvName] LIKE '%" & Trim(part) & "%'"
            Next
        End If

        GVProduct.ActiveFilterString = sql

        If chkLotNo.Checked = True And Trim(txtLotNo.Text) <> "" Then
            GVProduct.ExpandAllGroups()
        Else
            GVProduct.CollapseAllGroups()
        End If

        txtCount.Text = Format(GVProduct.DataRowCount, "#,##0")
    End Sub


    Private Sub cmbInvName_TextChanged(sender As Object, e As EventArgs) Handles cmbInvName.TextChanged
        If stLoad = 1 Then
            FilterDataOnGrid()
        End If
    End Sub

    Private Sub chkInvName_CheckedChanged(sender As Object, e As EventArgs) Handles chkInvName.CheckedChanged
        If Me.chkInvName.Checked = True Then
            Me.txtInvName.Enabled = True
            Me.txtInvName.Focus()
        Else
            Me.txtInvName.Enabled = False
            Me.txtInvName.Text = ""
        End If
    End Sub

    Private Sub chkLotNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkLotNo.CheckedChanged
        If Me.chkLotNo.Checked = True Then
            Me.txtLotNo.Enabled = True
            Me.txtLotNo.Focus()
        Else
            Me.txtLotNo.Enabled = False
            Me.txtLotNo.Text = ""

            GVProduct.CollapseAllGroups()
        End If
    End Sub

    Private Sub rptBtnSelect_Click(sender As Object, e As EventArgs) Handles rptSelect.Click

        Dim dr As DataRow
        Dim result As Boolean = True

        dr = GVProduct.GetDataRow(GVProduct.FocusedRowHandle)

        Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GCProduct.FocusedView
        Dim dr_1 As DataRow = detailView.GetDataRow(detailView.FocusedRowHandle)

        If dr_1.Item("idSaleOrderDt") <> 0 Then

            result = fnChkReserveLot(dr_1.Item("idSaleOrderDt"))
        End If

        If dr.Item("stCountStock") = 1 Then
            MessageBox.Show("ไม่สามารถเลือก Lot นี้ได้ " & vbNewLine &
                               "เนื่องจากอยู่ในกระบวนการรออนุมัติปรับสต็อก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If result = True Then

            Dim pWeight As Double = 0
            Dim idUnitW As Integer = 0

            If dr_1.Item("idInvGroup") = 2 Then
                pWeight = dr_1.Item("Weight")
                idUnitW = dr_1.Item("idUnitW")
            ElseIf dr_1.Item("idInvGroup") = 42 Then
                pWeight = dr_1.Item("WPerPack")
                idUnitW = 1
            End If


            Dim InvName As String = dr.Item("InvName")
            Dim idInvMain As Integer = dr.Item("idInvMain")
            Dim idLot As Integer = dr_1.Item("idLot")
            Dim LotNo As String = dr_1.Item("LotNo")
            Dim idInvGroup As Integer = dr_1.Item("idInvGroup")
            Dim UnitName As String = dr.Item("UnitName")
            Dim idUnit As Integer = dr.Item("idUnit")
            Dim AmtStock As Double = dr_1.Item("Amount")
            Dim dtType_ As Integer = dr.Item("dtType")
            Dim idSubType As Double = dr_1.Item("idSubType")
            'Dim idLotOldSys As Integer = dr_1.Item("idPdPkLot")
            Dim idWh As Integer = dr_1.Item("idWh")
            Dim PriceBill_fg As Double = dr_1.Item("PriceBill_fg")
            Dim PriceWholeSale_fg As Double = dr_1.Item("PriceWholeSale_fg")
            Dim PriceRetail_fg As Double = dr_1.Item("PriceRetail_fg")
            Dim CreditThirty_pdo As Double = dr_1.Item("CreditThirty_pdo")
            Dim CreditSixty_pdo As Double = dr_1.Item("CreditSixty_pdo")
            Dim PricePdo_pdo As Double = dr_1.Item("PricePdo_pdo")

            Dim idPdOType As Integer = dr_1.Item("idPdOType")
            Dim PdCode As String = dr_1.Item("PdCode")
            Dim idLotSPM As Integer = dr_1.Item("idLotSPM")
            Dim PriceSeed As Double = dr_1.Item("PriceSeed")
            Dim idRefLot As Integer = dr_1.Item("idRefLot")
            Dim idSaleOrderDt As Integer = dr_1.Item("idSaleOrderDt")
            Dim CompRec As Integer = dr_1.Item("CompRec")

            fnAddDatatoDGVSelected(idInvMain, InvName, LotNo, idLot, idInvGroup, UnitName, idUnit, AmtStock, dtType_, idSubType, idWh,
                                   PriceBill_fg, PriceWholeSale_fg, PriceRetail_fg, CreditThirty_pdo, CreditSixty_pdo, PricePdo_pdo,
                                   idPdOType, PdCode, idLotSPM, PriceSeed, idRefLot, idSaleOrderDt, CompRec, pWeight, idUnitW, dr_1.Item("full_lock"))
        Else
            Exit Sub
        End If

    End Sub

    Private Sub fnAddDatatoDGVSelected(ByVal idInvMain As Integer, ByVal InvName As String, ByVal LotNo As String,
                                       ByVal idLot As Integer, ByVal idInvGroup As Integer, ByVal UnitName As String,
                                       ByVal idUnit As Integer, ByVal AmtStock As Double, ByVal dtType_ As Integer,
                                       ByVal idSubType As Integer, ByVal idWh As Integer,
                                       ByVal PriceBill_fg As Double, ByVal PriceWholeSale_fg As Double, ByVal PriceRetail_fg As Double,
                                       ByVal CreditThirty_pdo As Double, ByVal CreditSixty_pdo As Double, ByVal PricePdo_pdo As Double,
                                       ByVal idPdOType As Integer, ByVal PdCode As String, ByVal idLotSPM As Integer, ByVal PriceSeed As Double,
                                       ByVal idRefLot As Integer, ByVal idSaleOrderDt As Integer, ByVal CompRec As Integer, ByVal pWeight As Double,
                                       ByVal idUnitW As Integer, ByVal WareHouseName As String)

        Dim drNew As DataRow = MainReturn.NewRow()
        drNew("idInvMain") = idInvMain
        drNew("InvName") = InvName
        drNew("LotNo") = LotNo
        drNew("idLot") = idLot
        drNew("idInvGroup") = idInvGroup
        drNew("UnitName") = UnitName
        drNew("idUnit") = idUnit
        drNew("AmtStock") = AmtStock
        drNew("DtType") = dtType_
        drNew("idSubType") = idSubType
        'drNew("idPdPkLot") = idLotOldSys
        drNew("idWh") = idWh
        drNew("PriceBill_fg") = PriceBill_fg
        drNew("PriceWholeSale_fg") = PriceWholeSale_fg
        drNew("PriceRetail_fg") = PriceRetail_fg
        drNew("CreditThirty_pdo") = CreditThirty_pdo
        drNew("CreditSixty_pdo") = CreditSixty_pdo
        drNew("PricePdo_pdo") = PricePdo_pdo
        drNew("idPdOType") = idPdOType
        drNew("PdCode") = PdCode
        drNew("idLotSPM") = idLotSPM
        drNew("PriceSeed") = PriceSeed
        drNew("idRefLot") = idRefLot
        drNew("idSaleOrderDt") = idSaleOrderDt
        drNew("CompRec") = CompRec
        drNew("pWeight") = pWeight
        drNew("idUnitW") = idUnitW
        drNew("full_lock") = WareHouseName

        MainReturn.Rows.Add(drNew)
        GCSelected.DataSource = MainReturn

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub GVSelected_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GVSelected.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "colNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub txtLotNo_TextChanged(sender As Object, e As EventArgs) Handles txtLotNo.TextChanged
        If stLoad = 1 Then
            FilterDataOnGrid()
        End If

    End Sub

    Private Sub ButtonUp_Click(sender As Object, e As EventArgs) Handles ButtonUp.Click
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = GVSelected
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        If index <= 0 Then Exit Sub

        Dim row1 As DataRow = view.GetDataRow(index)
        Dim row2 As DataRow = view.GetDataRow((index - 1))

        Dim LotNo1 As Object = row1("LotNo")
        Dim LotNo2 As Object = row2("LotNo")
        row1("LotNo") = LotNo2
        row2("LotNo") = LotNo1

        Dim InvName1 As Object = row1("InvName")
        Dim InvName2 As Object = row2("InvName")
        row1("InvName") = InvName2
        row2("InvName") = InvName1

        Dim idLot1 As Object = row1("idLot")
        Dim idLot2 As Object = row2("idLot")
        row1("idLot") = idLot2
        row2("idLot") = idLot1

        Dim idInvGroup1 As Object = row1("idInvGroup")
        Dim idInvGroup2 As Object = row2("idInvGroup")
        row1("idInvGroup") = idInvGroup2
        row2("idInvGroup") = idInvGroup1

        Dim UnitName1 As Object = row1("UnitName")
        Dim UnitName2 As Object = row2("UnitName")
        row1("UnitName") = UnitName2
        row2("UnitName") = UnitName1

        Dim idUnit1 As Object = row1("idUnit")
        Dim idUnit2 As Object = row2("idUnit")
        row1("idUnit") = idUnit2
        row2("idUnit") = idUnit1

        Dim AmtStock1 As Object = row1("AmtStock")
        Dim AmtStock2 As Object = row2("AmtStock")
        row1("AmtStock") = AmtStock2
        row2("AmtStock") = AmtStock1

        Dim DtType1 As Object = row1("DtType")
        Dim DtType2 As Object = row2("DtType")
        row1("DtType") = DtType2
        row2("DtType") = DtType1

        Dim idSubType1 As Object = row1("idSubType")
        Dim idSubType2 As Object = row2("idSubType")
        row1("idSubType") = idSubType2
        row2("idSubType") = idSubType1

        Dim idWh1 As Object = row1("idWh")
        Dim idWh2 As Object = row2("idWh")
        row1("idWh") = idWh2
        row2("idWh") = idWh1

        Dim pWeight1 As Object = row1("pWeight")
        Dim pWeight2 As Object = row2("pWeight")
        row1("pWeight") = pWeight2
        row2("pWeight") = pWeight1

        Dim idUnitW1 As Object = row1("idUnitW")
        Dim idUnitW2 As Object = row2("idUnitW")
        row1("idUnitW") = idUnitW2
        row2("idUnitW") = idUnitW1


        view.FocusedRowHandle = index - 1
    End Sub

    Private Sub ButtonDown_Click(sender As Object, e As EventArgs) Handles ButtonDown.Click
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = GVSelected
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        If index >= view.DataRowCount - 1 Then Exit Sub

        Dim row1 As DataRow = view.GetDataRow(index)
        Dim row2 As DataRow = view.GetDataRow((index + 1))

        Dim LotNo1 As Object = row1("LotNo")
        Dim LotNo2 As Object = row2("LotNo")
        row1("LotNo") = LotNo2
        row2("LotNo") = LotNo1

        Dim InvName1 As Object = row1("InvName")
        Dim InvName2 As Object = row2("InvName")
        row1("InvName") = InvName2
        row2("InvName") = InvName1

        Dim idLot1 As Object = row1("idLot")
        Dim idLot2 As Object = row2("idLot")
        row1("idLot") = idLot2
        row2("idLot") = idLot1

        Dim idInvGroup1 As Object = row1("idInvGroup")
        Dim idInvGroup2 As Object = row2("idInvGroup")
        row1("idInvGroup") = idInvGroup2
        row2("idInvGroup") = idInvGroup1

        Dim UnitName1 As Object = row1("UnitName")
        Dim UnitName2 As Object = row2("UnitName")
        row1("UnitName") = UnitName2
        row2("UnitName") = UnitName1

        Dim idUnit1 As Object = row1("idUnit")
        Dim idUnit2 As Object = row2("idUnit")
        row1("idUnit") = idUnit2
        row2("idUnit") = idUnit1

        Dim AmtStock1 As Object = row1("AmtStock")
        Dim AmtStock2 As Object = row2("AmtStock")
        row1("AmtStock") = AmtStock2
        row2("AmtStock") = AmtStock1

        Dim DtType1 As Object = row1("DtType")
        Dim DtType2 As Object = row2("DtType")
        row1("DtType") = DtType2
        row2("DtType") = DtType1

        Dim idSubType1 As Object = row1("idSubType")
        Dim idSubType2 As Object = row2("idSubType")
        row1("idSubType") = idSubType2
        row2("idSubType") = idSubType1

        Dim idWh1 As Object = row1("idWh")
        Dim idWh2 As Object = row2("idWh")
        row1("idWh") = idWh2
        row2("idWh") = idWh1

        Dim pWeight1 As Object = row1("pWeight")
        Dim pWeight2 As Object = row2("pWeight")
        row1("pWeight") = pWeight2
        row2("pWeight") = pWeight1

        Dim idUnitW1 As Object = row1("idUnitW")
        Dim idUnitW2 As Object = row2("idUnitW")
        row1("idUnitW") = idUnitW2
        row2("idUnitW") = idUnitW1

        view.FocusedRowHandle = index + 1
    End Sub

    Private Sub rptDel_Click(sender As Object, e As EventArgs) Handles rptDel.Click
        If lbrMsg.MsgQuestion("คุณต้องการลบรายการใช่หรือไม่?") = True Then
            Dim dr As DataRow = GVSelected.GetDataRow(GVSelected.FocusedRowHandle)
            dr.Delete()
            MainReturn.AcceptChanges()
        End If
    End Sub


    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPage Is tpTransport Then
            Dim sDt As New DataTable

            sCommand.CommandText = "SELECT invmain.idSubType, invmain.idInvMain, invmain.InvName, invmain.idInvGroup,unit.UnitName, unit.idUnit, 4 As DtType, " & vbNewLine & _
                               " 1 Amount,0 As idWh" & vbNewLine & _
                               "FROM  dInventoryMain invmain " & vbNewLine & _
                               "LEFT JOIN dInvUnit As unit ON invmain.idUnit = unit.idUnit " & vbNewLine & _
                               "WHERE invmain.idInvGroup = 30 AND invmain.stActive Is NULL"
            sAdapter.Fill(sDt)

            GridControl2.DataSource = sDt
            txtSearch.Focus()
        End If

    End Sub

    Private Sub rptSelectTransport_Click(sender As Object, e As EventArgs) Handles rptSelectTransport.Click
        Dim dr As DataRow

        dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)

        Dim pWeight As Double = 0
        Dim idUnitW As Integer = 0

        If dr.Item("idInvGroup") = 2 Then
            pWeight = dr.Item("Weight")
            idUnitW = dr.Item("idUnitW")
        ElseIf dr.Item("idInvGroup") = 42 Then
            pWeight = dr.Item("WPerPack")
            idUnitW = 1
        End If


        Dim InvName As String = dr.Item("InvName")
        Dim idInvMain As Integer = dr.Item("idInvMain")
        Dim idLot As Integer = 0
        Dim LotNo As String = ""
        Dim idInvGroup As Integer = dr.Item("idInvGroup")
        Dim UnitName As String = dr.Item("UnitName")
        Dim idUnit As Integer = dr.Item("idUnit")
        Dim AmtStock As Double = dr.Item("Amount")
        Dim dtType_ As Integer = 4
        Dim idSubType As Integer = dr.Item("idSubType")
        'Dim idPdPkLot As Integer = dr.Item("idSubType")
        Dim idWh As Integer = dr.Item("idWh")
        Dim PriceBill_fg As Double = 0
        Dim PriceWholeSale_fg As Double = 0
        Dim PriceRetail_fg As Double = 0
        Dim CreditThirty_pdo As Double = 0
        Dim CreditSixty_pdo As Double = 0
        Dim PricePdo_pdo As Double = 0
        Dim idPdOType As Integer = 0
        Dim PdCode As String = ""
        Dim idLotSPM As Integer = 0
        Dim PriceSeed As Double = 0
        Dim WareHouseName As String = ""
        fnAddDatatoDGVSelected(idInvMain, InvName, LotNo, idLot, idInvGroup, UnitName, idUnit, AmtStock, dtType_, idSubType, idWh,
                               PriceBill_fg, PriceWholeSale_fg, PriceRetail_fg, CreditThirty_pdo, CreditSixty_pdo, PricePdo_pdo, idPdOType, PdCode, idLotSPM, PriceSeed, 0, 0, gidComp, pWeight, idUnitW, WareHouseName)
    End Sub


    Private Sub txtInvName_TextChanged(sender As Object, e As EventArgs) Handles txtInvName.TextChanged
        If stLoad = 1 Then
            FilterDataOnGrid()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        GridView2.ActiveFilterString = " InvName like '%" & Trim(txtSearch.Text) & "%'"
        lblCountTp.Text = Format(GridView2.DataRowCount, "#,##0")
    End Sub

    Private Sub chkInvType_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInvGroup.CheckedChanged
        If stLoad = 1 Then
            FilterDataOnGrid()
        End If
    End Sub

    Private Sub Button9_KeyDown(sender As Object, e As KeyEventArgs) Handles Button9.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub rptDel_KeyDown(sender As Object, e As KeyEventArgs) Handles rptDel.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lbrMsg.MsgQuestion("คุณต้องการลบรายการใช่หรือไม่?") = True Then
                Dim dr As DataRow = GVSelected.GetDataRow(GVSelected.FocusedRowHandle)
                dr.Delete()
                MainReturn.AcceptChanges()
            End If
        End If
    End Sub

    Private Sub GVProduct_KeyDown(sender As Object, e As KeyEventArgs) Handles GVProduct.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dr As DataRow

            dr = GVProduct.GetDataRow(GVProduct.FocusedRowHandle)
            Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GCProduct.FocusedView
            Dim dr_1 As DataRow = detailView.GetDataRow(detailView.FocusedRowHandle)

            Dim pWeight As Double = 0
            Dim idUnitW As Integer = 0

            If dr_1.Item("idInvGroup") = 2 Then
                pWeight = dr_1.Item("Weight")
                idUnitW = dr_1.Item("idUnitW")
            ElseIf dr_1.Item("idInvGroup") = 42 Then
                pWeight = dr_1.Item("WPerPack")
                idUnitW = 1
            End If

            Dim InvName As String = dr.Item("InvName")
            Dim idInvMain As Integer = dr.Item("idInvMain")
            Dim idLot As Integer = dr_1.Item("idLot")
            Dim LotNo As String = dr_1.Item("LotNo")
            Dim idInvGroup As Integer = dr_1.Item("idInvGroup")
            Dim UnitName As String = dr.Item("UnitName")
            Dim idUnit As Integer = dr.Item("idUnit")
            Dim AmtStock As Double = dr_1.Item("Amount")
            Dim dtType_ As Integer = dr.Item("dtType")
            Dim idSubType As Integer = dr_1.Item("idSubType")
            'Dim idLotOldSys As Integer = dr_1.Item("idPdPkLot")
            Dim idWh As Integer = dr_1.Item("idWh")
            Dim PriceBill_fg As Double = dr.Item("PriceBill_fg")
            Dim PriceWholeSale_fg As Double = dr.Item("PriceWholeSale_fg")
            Dim PriceRetail_fg As Double = dr.Item("PriceRetail_fg")
            Dim CreditThirty_pdo As Double = dr.Item("CreditThirty_pdo")
            Dim CreditSixty_pdo As Double = dr.Item("CreditSixty_pdo")
            Dim PricePdo_pdo As Double = dr.Item("PricePdo_pdo")
            Dim idPdOType As Integer = dr.Item("idPdOType")
            Dim PdCode As String = dr.Item("PdCode")
            Dim idLotSPM As Integer = dr.Item("idLotSPM")
            Dim PriceSeed As Double = dr.Item("PriceSeed")
            Dim idRefLot As Integer = dr.Item("idRefLot")
            Dim idSaleOrderDt As Integer = dr.Item("idSaleOrderDt")
            Dim WareHouseName As String = dr.Item("full_lock")
            fnAddDatatoDGVSelected(idInvMain, InvName, LotNo, idLot, idInvGroup, UnitName, idUnit, AmtStock, dtType_, idSubType, idWh,
                                   PriceBill_fg, PriceWholeSale_fg, PriceRetail_fg, CreditThirty_pdo, CreditSixty_pdo, PricePdo_pdo,
                                   idPdOType, PdCode, idLotSPM, PriceSeed, idRefLot, idSaleOrderDt, dr.Item("CompRec"), pWeight, idUnitW, WareHouseName)
            SendKeys.Send("^{TAB}")
            SendKeys.Send("^{TAB}")
            SendKeys.Send("{TAB}")
            SendKeys.Send("{TAB}")
            txtInvName.SelectAll()
        End If
    End Sub

    Private Sub GridView2_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dr As DataRow

            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)

            Dim pWeight As Double = 0
            Dim idUnitW As Integer = 0

            If dr.Item("idInvGroup") = 2 Then
                pWeight = dr.Item("Weight")
                idUnitW = dr.Item("idUnitW")
            ElseIf dr.Item("idInvGroup") = 42 Then
                pWeight = dr.Item("WPerPack")
                idUnitW = 1
            End If


            Dim InvName As String = dr.Item("InvName")
            Dim idInvMain As Integer = dr.Item("idInvMain")
            Dim idLot As Integer = 0
            Dim LotNo As String = ""
            Dim idInvGroup As Integer = dr.Item("idInvGroup")
            Dim UnitName As String = dr.Item("UnitName")
            Dim idUnit As Integer = dr.Item("idUnit")
            Dim AmtStock As Double = dr.Item("Amount")
            Dim dtType_ As Integer = 4
            Dim idSubType As Double = dr.Item("idSubType")
            'Dim idPdPkLot As Integer = dr.Item("idSubType")
            Dim idWh As Integer = dr.Item("idWh")
            Dim PriceBill_fg As Double = 0
            Dim PriceWholeSale_fg As Double = 0
            Dim PriceRetail_fg As Double = 0
            Dim CreditThirty_pdo As Double = 0
            Dim CreditSixty_pdo As Double = 0
            Dim PricePdo_pdo As Double = 0
            Dim idPdOType As Integer = 0
            Dim PdCode As String = ""
            Dim idLotSPM As Integer = 0
            Dim PriceSeed As Double = 0
            Dim WareHouseName As String = dr.Item("full_lock")

            fnAddDatatoDGVSelected(idInvMain, InvName, LotNo, idLot, idInvGroup, UnitName, idUnit, AmtStock, dtType_, idSubType, idWh,
                                   PriceBill_fg, PriceWholeSale_fg, PriceRetail_fg, CreditThirty_pdo, CreditSixty_pdo, PricePdo_pdo,
                                   idPdOType, PdCode, idLotSPM, PriceSeed, 0, 0, gidComp, pWeight, idUnitW, WareHouseName)
        End If

    End Sub

    Private Sub cmbInvName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbInvName.SelectedValueChanged
        If stLoad = 1 Then
            FilterDataOnGrid()
        End If
    End Sub

    Private Function fnChkReserveLot(ByVal idSaleOrderDt As Integer) As Boolean
        Dim bl As Boolean = True
        mdCnOpen()
        Dim dt As New DataTable
        sCommand.CommandText = "SELECT mt.DocCode, p.PartnerName, mt.DateOrderD" & vbNewLine & _
                                "FROM SmSaleOrderMt mt" & vbNewLine & _
                                "LEFT JOIN SmSaleOrderDt dt ON mt.idSaleOrder = dt.idSaleOrder" & vbNewLine & _
                                "LEFT JOIN dPartner p ON mt.idPartner = p.idPartner" & vbNewLine & _
                                "WHERE dt.idSaleOrderDt = " & idSaleOrderDt
        sAdapter.Fill(dt)


        If dt.Rows.Count <> 0 Then

            Dim result As DialogResult = MessageBox.Show("สินค้า Lot นี้ถูก Packing เพื่อการสั่งซื้อ" & vbCrLf &
                                                         "เลขที่ (Order No.): " & dt.Rows(0).Item("DocCode") & vbCrLf &
                                                         "ลูกค้าที่ทำการสั่งซื้อ: " & dt.Rows(0).Item("PartnerName") & vbCrLf &
                                                         "วันที่ต้องการสินค้า: " & dt.Rows(0).Item("DateOrderD") & vbCrLf & vbCrLf &
                                                         "ยืนยันที่จะใช้ Lot นี้ เพื่อทำการขาย หรือไม่", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Information)


            If result = Windows.Forms.DialogResult.Yes Then
                'GVLot.SetFocusedRowCellValue("chk", True)
                bl = True
            Else
                bl = False
            End If
        End If

        Return bl

    End Function

End Class