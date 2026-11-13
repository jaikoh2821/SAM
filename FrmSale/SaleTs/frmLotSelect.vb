Imports System.Linq
Imports System.Windows.Controls

Public Class frmLotSelect
    Enum eProcess
        eSelectxLot
        eSelectxInv
        eSelectSH 'เลือก Lot Sohui
        eSelectOrder 'เลือกมาจาก Order
    End Enum

    Dim gidComp As Integer = 0
    Dim gidInvMain As Integer = 0
    Dim gCompName As String = ""
    Dim gInvName As String = ""
    Dim gLotNo As String = ""
    Dim xProcess As eProcess
    Public dtLotReturn As New DataTable
    Dim dtSelectedInMain As New DataTable
    'Dim xstridLotBack As String = "0"
    Sub New(ByVal aProcess As eProcess, ByVal idComp As Integer, ByVal CompName As String, ByVal LotNo As String,
            ByVal idInvMain As Integer, ByVal InvName As String, Optional ByVal dtSelected As DataTable = Nothing)
        ', ByVal stridLotBack As String
        InitializeComponent()

        gidComp = idComp
        gidInvMain = idInvMain
        gCompName = CompName
        gInvName = InvName
        gLotNo = LotNo
        'xstridLotBack = stridLotBack
        xProcess = aProcess

        ' ถ้ามีการส่ง DataTable รายการที่เลือกแล้วมา ให้เก็บไว้
        If dtSelected IsNot Nothing Then
            dtSelectedInMain = dtSelected.Copy()
        End If

        initDataTable(dtLotReturn)
    End Sub


    Private Sub frmLotSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mdLoadShow()
        BindData()
        mdLoadCommitt()

        Dim arridCompAsg As Integer() = {2, 3}

        If arridCompAsg.Contains(gidComp) Then
            ColDocCode_PO.Visible = True
        End If




        Select Case xProcess
            Case eProcess.eSelectxInv, eProcess.eSelectSH, eProcess.eSelectOrder
                lblInvName.Visible = True
                lblInvName.Text = gInvName
                colProductName.GroupIndex = -1
                colProductName.Visible = False

            Case eProcess.eSelectxLot
                txtLotNo.Text = gLotNo
        End Select

    End Sub

    Private Sub frmLotSelect_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtLotNo.Focus()
        SendKeys.SendWait("{right}")
    End Sub


    Private Sub initDataTable(sender As Object)
        sender.Columns.Add("idLot", System.Type.GetType("System.Int64"))
        sender.Columns.Add("LotNo", System.Type.GetType("System.String"))
        sender.Columns.Add("AmtStock", System.Type.GetType("System.Double"))
        sender.Columns.Add("DtType", System.Type.GetType("System.Int64"))
        sender.Columns.Add("idLotSPM", System.Type.GetType("System.Int64"))
        sender.Columns.Add("idWh", System.Type.GetType("System.Int64"))
        sender.Columns.Add("idInvGroup", System.Type.GetType("System.Int64"))
        sender.Columns.Add("idInvMain", System.Type.GetType("System.Int64"))
        sender.Columns.Add("InvName", System.Type.GetType("System.String"))
        sender.Columns.Add("idUnit", System.Type.GetType("System.Int64"))
        sender.Columns.Add("UnitName", System.Type.GetType("System.String"))
        sender.Columns.Add("InvCode", System.Type.GetType("System.String"))
        sender.Columns.Add("idSubType", System.Type.GetType("System.Int64"))
        sender.Columns.Add("idRefLot", System.Type.GetType("System.Int64"))
        sender.Columns.Add("full_lock", System.Type.GetType("System.String"))
        sender.Columns.Add("CompRec", System.Type.GetType("System.Int64"))
        sender.Columns.Add("pWeight", System.Type.GetType("System.Double"))
        sender.Columns.Add("idUnitW", System.Type.GetType("System.Int64"))
        sender.Columns.Add("DateGen", System.Type.GetType("System.DateTime"))
        sender.Columns.Add("PDAge", System.Type.GetType("System.String"))
        sender.Columns.Add("AmtStockBal", System.Type.GetType("System.Double"))
        sender.Columns.Add("DocCode_PO", System.Type.GetType("System.String"))
    End Sub

    Private Sub BindData()
        Dim ds0 As New DataSet
        Dim sDt As New DataTable
        Dim vWhere As String = ""

        If gidComp = 10 Or gidComp = 4 Then 'สตาร์อะกรีเทค
            vWhere = vWhere & " AND (lm.CompRec = 4 OR lm.CompRec = " & gidComp & ") "
        Else
            vWhere = vWhere & " AND lm.CompRec = " & gidComp & " "
        End If

        mdCnOpen()
        Dim txtAlert As String = ""
        '------สนใจ idWh เจาะจง idInvMain
        Select Case xProcess
            Case eProcess.eSelectxInv, eProcess.eSelectSH, eProcess.eSelectOrder

                'If xProcess = eProcess.eSelectOrder Then
                '    vWhere = vWhere & vbNewLine &
                '            "AND ref.idRefLot Not IN (" & xstridLotBack & ")"
                'End If

                sCommand.CommandText = "SELECT cast(0 as bit) as chk, bMt.DocCode As DocCode_PO, lm.idSaleOrderDt, lm.idLot, inv.idInvMain, ref.idWh,  ISNULL(inv.InvCode,'') As InvCode, lm.CompRec," & vbNewLine &
                                "(CASE WHEN ISNULL(d.ShortName,'') = '' THEN inv.InvName ELSE inv.InvName + ' : ' + d.ShortName + '' END) As InvNameShow, inv.InvName," & vbNewLine &
                                "d.ShortName, inv.idInvGroup, lm.LotNo, unit.idUnit, g.InvGroupName, " & vbNewLine &
                                "unit.UnitName, inv.idSubType, g.DtType, ISNULL(lm.idLotSPM,0) As idLotSPM, d.Weight, d.idUnitW, sfg.WPerPack, ref.Amount, ref.Amount As AmtStockBal," & vbNewLine &
                                "inv.idSubType, ref.idRefLot, ISNULL(lm.idSaleOrderDt,0) As idSaleOrderDt, devsk.fncChkLotCount(ref.idLot) As stCountStock," & vbNewLine &
                                "swh.full_lock + CASE WHEN ISNULL(ref.idBox,0) <> 0 THEN '>' + pn.PartnerName ELSE '' END As full_lock, lm.DateGen," & vbNewLine &
                                "ConCat(FORMAT(DATEDIFF(day, lm.DateGen, GETDATE()),'#,##0'),' วัน') As PDAge" & vbNewLine &
                                "FROM vInvLotRefWh_RStock As ref" & vbNewLine &
                                "LEFT JOIN WimReturnBox rtb On ref.idBox = rtb.idBox And ref.idBox Is Not NULL" & vbNewLine &
                                "LEFT JOIN SmSaleReturnDt sDt ON rtb.idSaleReturnDt = sDt.idSaleReturnDt " & vbNewLine &
                                "LEFT JOIN SmSaleReturnMt sMt ON sDt.idSaleReturn = sMt.idSaleReturn " & vbNewLine &
                                "LEFT JOIN dPartner pn ON sMt.idPartner = pn.idPartner" & vbNewLine &
                                "LEFT JOIN dInvLotMain As lm ON  ref.idLot = lm.idLot" & vbNewLine &
                                "LEFT JOIN dInventoryMain As inv ON lm.idInvMain = inv.idInvMain" & vbNewLine &
                                "LEFT JOIN dInvGroup As g ON inv.idInvGroup = g.idInvGroup" & vbNewLine &
                                "LEFT JOIN dInvUnit As unit ON ref.idUnit = unit.idUnit " & vbNewLine &
                                "LEFT JOIN SsWareHouse As swh ON ref.idWh = swh.idWh" & vbNewLine &
                                "LEFT JOIN dPackingPdSet As d ON inv.idSubType = d.idPdPk And inv.idInvGroup = 2" & vbNewLine &
                                "LEFT JOIN dSeedFlPackage sfg ON inv.idSubType = sfg.idFlPk AND inv.idInvgroup = 42" & vbNewLine &
                                "LEFT JOIN SmSaleOrderDt oDt ON oDt.idSaleOrderDt = ISNULL(lm.idSaleOrderDt,-1)" & vbNewLine &
                                "LEFT JOIN SmSaleOrderMt oMt On oDt.idSaleOrder = oMt.idSaleOrder" & vbNewLine &
                                "LEFT JOIN PkPOBuyMt bMt On oMt.idPOTs = bMt.idPOTs" & vbNewLine &
                                "WHERE lm.stDel Is NULL" & vbNewLine &
                                "--And inv.stNotSale Is NULL" & vbNewLine &
                                "And ref.Amount > 0" & vbNewLine &
                                "And lm.idInvMain = " & gidInvMain & vbNewLine &
                                "AND ref.idWh Not In (5503)" & vbNewLine &
                                 vWhere & vbNewLine &
                                 "Order By lm.DateGen DESC"

                txtAlert = "ไม่พบ Stock คงเหลือของสินค้า " & gInvName

            Case eProcess.eSelectxLot

                sCommand.CommandText = "Select cast(0 As bit) As chk, lm.idLot, '' As DocCode_PO, inv.idInvMain, ref.idWh, ISNULL(inv.InvCode,'') As InvCode, lm.CompRec," & vbNewLine &
                           "(CASE WHEN ISNULL(d.ShortName,'') = '' THEN inv.InvName ELSE inv.InvName + ' : ' + d.ShortName + '' END) As InvNameShow, inv.InvName, " & vbNewLine &
                           "d.ShortName, inv.idInvGroup, lm.LotNo, unit.idUnit, g.InvGroupName, " & vbNewLine &
                           "unit.UnitName, inv.idSubType, g.DtType, ISNULL(lm.idLotSPM,0) As idLotSPM, d.Weight, d.idUnitW, sfg.WPerPack, ref.Amount, ref.Amount As AmtStockBal," & vbNewLine &
                           "inv.idSubType, ref.idRefLot, ISNULL(lm.idSaleOrderDt,0) As idSaleOrderDt, devsk.fncChkLotCount(ref.idLot) As stCountStock," & vbNewLine &
                           "swh.full_lock + CASE WHEN ISNULL(ref.idBox,0) <> 0 THEN '>' + pn.PartnerName ELSE '' END As full_lock, lm.DateGen, " & vbNewLine &
                           "ConCat(DATEDIFF(day, lm.DateGen, GETDATE()),' วัน') As PDAge" & vbNewLine &
                           "FROM vInvLotRefWh_RStock As ref" & vbNewLine &
                           "LEFT JOIN WimReturnBox rtb On ref.idBox = rtb.idBox And ref.idBox Is Not NULL" & vbNewLine &
                           "LEFT JOIN SmSaleReturnDt sDt ON rtb.idSaleReturnDt = sDt.idSaleReturnDt " & vbNewLine &
                           "LEFT JOIN SmSaleReturnMt sMt ON sDt.idSaleReturn = sMt.idSaleReturn " & vbNewLine &
                           "LEFT JOIN dPartner pn ON sMt.idPartner = pn.idPartner" & vbNewLine &
                           "LEFT JOIN dInvLotMain As lm ON  ref.idLot = lm.idLot" & vbNewLine &
                           "LEFT JOIN dInventoryMain As inv ON lm.idInvMain = inv.idInvMain" & vbNewLine &
                           "LEFT JOIN dInvGroup As g ON inv.idInvGroup = g.idInvGroup" & vbNewLine &
                           "LEFT JOIN dInvUnit As unit ON ref.idUnit = unit.idUnit " & vbNewLine &
                           "LEFT JOIN SsWareHouse As swh ON ref.idWh = swh.idWh" & vbNewLine &
                           "LEFT JOIN dPackingPdSet As d ON inv.idSubType = d.idPdPk And inv.idInvGroup = 2" & vbNewLine &
                           "LEFT JOIN dSeedFlPackage sfg ON inv.idSubType = sfg.idFlPk AND inv.idInvgroup = 42" & vbNewLine &
                           "WHERE lm.stDel Is NULL" & vbNewLine &
                           "--AND inv.stNotSale Is NULL" & vbNewLine &
                           "AND ref.Amount > 0" & vbNewLine &
                           "AND ref.idWh Not In (5503)" & vbNewLine &
                           "AND lm.LotNo LIKE '%" & gLotNo & "%'" & vbNewLine &
                            vWhere & vbNewLine & " Order By lm.DateGen DESC"

                txtAlert = "ไม่พบ Stock คงเหลือของ LotNo." & gLotNo

        End Select

        sAdapter.Fill(sDt)

        '-----------24/9/69--เพิ่มหักลบยอดที่เคยเลือกไปในหน้าหลักแล้ว---------------------------
        If dtSelectedInMain IsNot Nothing AndAlso dtSelectedInMain.Rows.Count > 0 Then
            For Each row As DataRow In sDt.Rows
                Dim idRefLot As Long = Convert.ToInt64(row("idRefLot"))
                Dim idLot As Long = Convert.ToInt64(row("idLot"))

                ' ค้นหาจำนวนที่ถูกเลือกใช้ไปแล้วในหน้าหลัก (เทียบจาก idRefLot หรือ idLot)
                Dim usedAmt As Double = 0

                ' ตัวอย่าง: ค้นหาใน dtSelectedInMain โดยเช็ค Column "idRefLot" (หรือ "idLot" ตามโครงสร้างหน้าหลัก)
                If dtSelectedInMain.Columns.Contains("idRefLot") Then
                    Dim foundRows As DataRow() = dtSelectedInMain.Select("idRefLot = " & idRefLot)
                    For Each fRow As DataRow In foundRows
                        ' สมมุติว่า column จำนวนขายในหน้าหลักชื่อ "Amount" หรือ "Qty"
                        If dtSelectedInMain.Columns.Contains("AmountCut") Then
                            usedAmt += Convert.ToDouble(fRow("AmountCut"))
                        End If
                    Next
                End If

                ' หักลบยอด Stock จริง ด้วยยอดที่ถูกเลือกไปแล้ว
                Dim currentAmt As Double = Convert.ToDouble(row("AmtStockBal"))
                row("AmtStockBal") = currentAmt - usedAmt
            Next

            ' ลบ Row ที่มียอดคงเหลือ <= 0 ออกจาก DataTable เพื่อไม่ให้เลือกได้อีก
            Dim zeroRows() As DataRow = sDt.Select("AmtStockBal <= 0")
            For Each r As DataRow In zeroRows
                sDt.Rows.Remove(r)
            Next
            sDt.AcceptChanges()
        End If

        '----------------------------------------------------------
        If sDt.Rows.Count = 0 Then
            MessageBox.Show(txtAlert, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            Exit Sub
        ElseIf sDt.Rows.Count = 1 And (xProcess <> eProcess.eSelectSH And xProcess <> eProcess.eSelectOrder) Then
            'ถ้ามี Lot เดียวให้ส่งกลับเลยโดยไม่ต้องเปิด Form

            Dim dr_ As DataRow = dtLotReturn.NewRow

            If sDt.Rows(0).Item("stCountStock") = 1 Then
                MessageBox.Show("ไม่สามารถเลือก Lot No. " & sDt.Rows(0).Item("LotNo") & " ได้ " & vbNewLine &
                              "เนื่องจากอยู่ในกระบวนการรออนุมัติปรับสต็อก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim pWeight As Double = 0
                Dim idUnitW As Integer = 0

                If sDt.Rows(0).Item("idInvGroup") = 2 Then
                    pWeight = sDt.Rows(0).Item("Weight")
                    idUnitW = sDt.Rows(0).Item("idUnitW")
                ElseIf sDt.Rows(0).Item("idInvGroup") = 42 Then
                    pWeight = sDt.Rows(0).Item("WPerPack")
                    idUnitW = 1
                End If


                dr_("idLot") = sDt.Rows(0).Item("idLot")
                dr_("LotNo") = sDt.Rows(0).Item("LotNo")
                dr_("AmtStock") = sDt.Rows(0).Item("Amount")
                dr_("DtType") = sDt.Rows(0).Item("DtType")
                dr_("idLotSPM") = sDt.Rows(0).Item("idLotSPM")
                dr_("idWh") = sDt.Rows(0).Item("idWh")
                dr_("full_lock") = sDt.Rows(0).Item("full_lock")
                dr_("InvCode") = sDt.Rows(0).Item("InvCode")
                dr_("idInvGroup") = sDt.Rows(0).Item("idInvGroup")
                dr_("idInvMain") = sDt.Rows(0).Item("idInvMain")
                dr_("InvName") = sDt.Rows(0).Item("InvName")
                dr_("idUnit") = sDt.Rows(0).Item("idUnit")
                dr_("UnitName") = sDt.Rows(0).Item("UnitName")
                dr_("idSubType") = sDt.Rows(0).Item("idSubType")
                dr_("idRefLot") = sDt.Rows(0).Item("idRefLot")
                dr_("full_lock") = sDt.Rows(0).Item("full_lock")
                dr_("CompRec") = sDt.Rows(0).Item("CompRec")
                dr_("pWeight") = pWeight
                dr_("idUnitW") = idUnitW
                dr_("DateGen") = sDt.Rows(0).Item("DateGen")
                dr_("AmtStockBal") = sDt.Rows(0).Item("AmtStockBal")
                dr_("DocCode_PO") = sDt.Rows(0).Item("DocCode_PO")
                dtLotReturn.Rows.Add(dr_)
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        End If


        GCLot.DataSource = sDt
        txtCount.Text = Format(GVLot.DataRowCount, "#,##0")
    End Sub

    Private Sub txtLotNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLotNo.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtLotNo_TextChanged(sender As Object, e As EventArgs) Handles txtLotNo.TextChanged

        GVLot.ActiveFilterString = " LotNo Like '%" & Trim(txtLotNo.Text) & "%'"

    End Sub

    Private Sub rptSelect_Click(sender As Object, e As EventArgs) Handles rptSelect.Click
        Dim dr As DataRow = GVLot.GetDataRow(GVLot.FocusedRowHandle)

        If dr.Item("stCountStock") = 1 Then
            MessageBox.Show("ไม่สามารถเลือก Lot นี้ได้ " & vbNewLine &
                          "เนื่องจากอยู่ในกระบวนการรออนุมัติปรับสต็อก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If

        Dim pWeight As Double = 0
        Dim idUnitW As Integer = 0

        If dr.Item("idInvGroup") = 2 Then
            pWeight = dr.Item("Weight")
            idUnitW = dr.Item("idUnitW")
        ElseIf dr.Item("idInvGroup") = 42 Then
            pWeight = dr.Item("WPerPack")
            idUnitW = 1
        End If

        Dim dr_ As DataRow = dtLotReturn.NewRow

        dr_("idLot") = dr("idLot")
        dr_("LotNo") = dr("LotNo")
        dr_("AmtStock") = dr("Amount")
        dr_("DtType") = dr("DtType")
        dr_("idLotSPM") = dr("idLotSPM")
        dr_("idWh") = dr("idWh")
        dr_("InvCode") = dr("InvCode")
        dr_("idInvGroup") = dr("idInvGroup")
        dr_("idInvMain") = dr("idInvMain")
        dr_("InvName") = dr("InvName")
        dr_("idUnit") = dr("idUnit")
        dr_("UnitName") = dr("UnitName")
        dr_("idSubType") = dr("idSubType")
        dr_("idRefLot") = dr("idRefLot")
        dr_("full_lock") = dr("full_lock")
        dr_("CompRec") = dr("CompRec")
        dr_("idUnitW") = idUnitW
        dr_("pWeight") = pWeight
        dr_("DateGen") = dr("DateGen")
        dr_("PDAge") = dr("PDAge")
        dr_("AmtStockBal") = dr("AmtStockBal")
        dr_("DocCode_PO") = dr("DocCode_PO")
        dtLotReturn.Rows.Add(dr_)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub GVLot_KeyDown(sender As Object, e As KeyEventArgs) Handles GVLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dr As DataRow = GVLot.GetDataRow(GVLot.FocusedRowHandle)

            Dim pWeight As Double = 0
            Dim idUnitW As Integer = 0

            If dr.Item("idInvGroup") = 2 Then
                pWeight = dr.Item("Weight")
                idUnitW = dr.Item("idUnitW")
            ElseIf dr.Item("idInvGroup") = 42 Then
                pWeight = dr.Item("WPerPack")
                idUnitW = 1
            End If

            Dim dr_ As DataRow = dtLotReturn.NewRow

            dr_("idLot") = dr("idLot")
            dr_("LotNo") = dr("LotNo")
            dr_("AmtStock") = dr("Amount")
            dr_("DtType") = dr("DtType")
            dr_("idLotSPM") = dr("idLotSPM")
            dr_("idWh") = dr("idWh")
            dr_("InvCode") = dr("InvCode")
            dr_("idInvGroup") = dr("idInvGroup")
            dr_("idInvMain") = dr("idInvMain")
            dr_("InvName") = dr("InvName")
            dr_("idUnit") = dr("idUnit")
            dr_("UnitName") = dr("UnitName")
            dr_("idSubType") = dr("idSubType")
            dr_("idRefLot") = dr("idRefLot")
            dr_("full_lock") = dr("full_lock")
            dr_("CompRec") = dr("CompRec")
            dr_("idUnitW") = idUnitW
            dr_("pWeight") = pWeight
            dr_("AmtStockBal") = dr("AmtStockBal")
            dr_("DocCode_PO") = dr("DocCode_PO")
            dtLotReturn.Rows.Add(dr_)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub GVLot_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVLot.RowCellStyle
        Dim _mark As String = GVLot.GetRowCellValue(e.RowHandle, "LotNo")

        If _mark = gLotNo Then
            e.Appearance.BackColor = Color.LightSkyBlue
        End If

    End Sub
End Class