
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmSlOrderToSale

    Dim xProcess As eProcess
    Public gMainReturn As New DataTable

    Dim CopyOrderDt As New DataTable
    Dim dtOrder As New DataTable
    Private WithEvents xTimer As New System.Windows.Forms.Timer
    Dim stLoad As Integer = 0
    Dim xidPartner As Integer = 0
    Dim xCusName As String = ""
    Dim xidComp As Integer = 0
    Dim xstridOrderDt As String = "0"
    Enum eProcess
        eNew
        eBackOrder
        eClose
        eSelect
        'eEditOrder
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal CusName As String, ByVal idPartner As Integer, ByVal idComp As Integer, ByVal stridOrderDt As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        xCusName = CusName
        xidPartner = idPartner
        xidComp = idComp
        xstridOrderDt = stridOrderDt

        xProcess = aProcess
    End Sub

    Private Sub frmSlOrderToSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        setCmbGroupComp(Me.cmbGroupComp)

        initDataTable(gMainReturn)
        initDataTable(CopyOrderDt)

        If xProcess = eProcess.eSelect Then

            lblPartner.Tag = xidPartner
            lblPartner.Text = xCusName

            btnCustomer.Visible = False
            Panel2.Visible = False
            Panel3.Visible = True
            ' btnSaleTs.Image =
            cmbGroupComp.SelectedValue = xidComp
            cmbGroupComp.Enabled = False

            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()

        ElseIf xProcess = eProcess.eBackOrder Then
            lblPartner.Tag = xidPartner
            lblPartner.Text = xCusName

            btnCustomer.Visible = False
            Panel2.Visible = False
            Panel3.Visible = True
            ' btnSaleTs.Image =
            cmbGroupComp.SelectedValue = xidComp
            cmbGroupComp.Enabled = False

            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()

            cbReadyToOrder.Checked = True

        End If


        'SampleCallEveryXMinute(300000) ' 1000 ms = 1 sec so 60000 ms = 1 min
        'StartTimer()
        stLoad = 1
    End Sub

    'Public Sub SampleCallEveryXMinute(TickValue As Integer)
    '    xTimer = New System.Windows.Forms.Timer
    '    xTimer.Interval = TickValue
    'End Sub

    'Private Sub Timer_Tick() Handles xTimer.Tick

    '    'cntOldMt = cntMt
    '    mdCnOpen()
    '    SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
    '    BindData()
    '    SplashScreenManager.CloseForm(False)
    'End Sub

    'Public Sub StartTimer()
    '    xTimer.Start()
    'End Sub

    Private Sub initDataTable(sender As Object)

        sender.Columns.Add("idSaleOrder", System.Type.GetType("System.Int64"))
        sender.Columns.Add("idSaleOrderDt", System.Type.GetType("System.Int64"))
        sender.Columns.Add("idInvMain", System.Type.GetType("System.Int64"))
        sender.Columns.Add("InvName", System.Type.GetType("System.String"))
        sender.Columns.Add("idInvGroup", System.Type.GetType("System.Int32"))
        sender.Columns.Add("UnitNameOrd", System.Type.GetType("System.String"))
        sender.Columns.Add("idUnitOrd", System.Type.GetType("System.Int32"))
        sender.Columns.Add("UnitName", System.Type.GetType("System.String"))
        sender.Columns.Add("idUnit", System.Type.GetType("System.Int32"))
        sender.Columns.Add("idSubType", System.Type.GetType("System.Int32"))
        sender.Columns.Add("ShortName", System.Type.GetType("System.String"))
        sender.Columns.Add("AmtOrder", System.Type.GetType("System.Double"))
        sender.Columns.Add("AmtStock", System.Type.GetType("System.Double"))
        sender.Columns.Add("PriceBill_fg", System.Type.GetType("System.Double"))
        sender.Columns.Add("PriceWholesale_fg", System.Type.GetType("System.Double"))
        sender.Columns.Add("PriceRetail_fg", System.Type.GetType("System.Double"))
        sender.Columns.Add("idPdOType", System.Type.GetType("System.Int32"))
        sender.Columns.Add("PricePdo_pdo", System.Type.GetType("System.Double"))
        sender.Columns.Add("CreditThirty_pdo", System.Type.GetType("System.Double"))
        sender.Columns.Add("CreditSixty_pdo", System.Type.GetType("System.Double"))
        sender.Columns.Add("PriceSeedFg_sfg", System.Type.GetType("System.Double"))
        sender.Columns.Add("InvCode", System.Type.GetType("System.String"))
        sender.Columns.Add("DtType", System.Type.GetType("System.Int32"))
        sender.Columns.Add("DocCode", System.Type.GetType("System.String"))
        sender.Columns.Add("PriceSeed", System.Type.GetType("System.Double"))
        sender.Columns.Add("PartnerName", System.Type.GetType("System.String"))
        sender.Columns.Add("idPartner", System.Type.GetType("System.Int32"))
        sender.Columns.Add("idCus", System.Type.GetType("System.Int32"))
        sender.Columns.Add("idComp", System.Type.GetType("System.Int32"))
        sender.Columns.Add("stSelect", System.Type.GetType("System.Int32"))
        sender.Columns.Add("dNET", System.Type.GetType("System.Double"))
        sender.Columns.Add("i", System.Type.GetType("System.Int32"))
        sender.Columns.Add("NoteOrder", System.Type.GetType("System.String"))
        sender.Columns.Add("PsOrder", System.Type.GetType("System.String"))
        sender.Columns.Add("idPOTs", System.Type.GetType("System.Int32"))
        sender.Columns.Add("idPODt", System.Type.GetType("System.Int32"))
        sender.Columns.Add("DocCode_PO", System.Type.GetType("System.String"))
        sender.Columns.Add("pWeight", System.Type.GetType("System.Double"))
        sender.Columns.Add("idUnitW", System.Type.GetType("System.Int64"))

    End Sub

    Private Sub BindData()

        If lblPartner.Tag = Nothing Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนค้นหาข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim vWhere As String = ""
            dtOrder.Clear()

            vWhere = "WHERE mt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                    "AND mt.idPsCancel Is Null " & vbNewLine &
                    "AND Year(mt.DateOrderD) >= 2023"


            If xProcess = eProcess.eBackOrder Then
                vWhere = vWhere & vbNewLine &
                        "AND dt.idSaleOrderDt Not In(" & xstridOrderDt & ")"
            End If



            sCommand.CommandText = "SELECT cast(0 as bit) as Chk, mt.idComp, c.PartnerName, c.idPartner, c.idCus , mt.DocCode, mt.DateOrderD, mt.DateRequireD, dt.idSaleOrder, dt.idSaleOrderDt, ic.InvCode, dt.idInvMain, inv.InvName, " & vbNewLine &
                                    "((IsNULL(dt.Amount,0)) - ISNULL(dt.AmountSale,0)) As AmtOrder, fg.idUnitW, fg.Weight, inv.idInvGroup, sfg.WPerPack, " & vbNewLine &
                                    "ISNULL((SELECT ISNULL(SUM(Amount),0)" & vbNewLine &
                                            "FROM dInvLotRefWh wh " & vbNewLine &
                                            "LEFT JOIN dInvLotMain lm ON wh.idLot = lm.idLot " & vbNewLine &
                                            "WHERE lm.idInvMain = dt.idInvMain" & vbNewLine &
                                            "AND lm.CompRec = mt.idComp), 0 ) - ISNULL((SELECT ISNULL(SUM(AmountWaitChange),0)" & vbNewLine &
                                                                                        "FROM  WimWaitCutDt wDt" & vbNewLine &
                                                                                        "LEFT JOIN WimWaitCutMt wMt ON wDt.idWaitCutMt = wMt.idWaitCutMt" & vbNewLine &
                                                                                        "WHERE wMt.stCancel Is NULL" & vbNewLine &
                                                                                        "AND wDt.stDel Is NULL" & vbNewLine &
                                                                                        "AND mt.idComp = wMt.idComp" & vbNewLine &
                                                                                        "AND wMt.stCancel Is NULL" & vbNewLine &
                                                                                        "AND wMt.stUseCut Is NULL" & vbNewLine &
                                                                                        "AND dt.idInvMain = wDt.idInvMain),0)  As AmtStock," & vbNewLine &
                                   "inv.idInvGroup,  p1.PsShortName As PsSale, P2.PsName As PsOrder, ISNULL(pdo.idPdoType,0) As idPdoType," & vbNewLine &
                                   "u.UnitName As UnitNameOrd, IsNULL(dt.idUnitSale,0) As idUnitOrd, us.idUnit, us.UnitName, 0 As stEnough, inv.idSubType, fg.ShortName, mt.DocCode, " & vbNewLine &
                                   "ISNULL(fg.PriceBill,0) As PriceBill_fg, ISNULL(fg.PriceWholesale,0 ) As PriceWholesale_fg, ISNULL(fg.PriceRetail,0) As PriceRetail_fg," & vbNewLine &
                                   "ISNULL(pdo.CreditThirty,0) As CreditThirty_pdo, ISNULL(pdo.CreditSixty,0) As CreditSixty_pdo, " & vbNewLine &
                                   "IsNULL(pdo.Price,0) As PricePdo_pdo, IsNULL(sfg.Price,0) As PriceSeedFg_sfg, gr.DtType, inv.idUnit As idUnitInv, dt.stPacking, '' As status," & vbNewLine &
                                   "(CASE ISNULL(mt.stSysOrder,0) WHEN  0 THEN 'PC' WHEN 1 THEN 'Mobile' WHEN 2 THEN 'Web Browser' WHEN 3 THEN 'PO' END) AS stSysText," & vbNewLine &
                                   "us.UnitName As UnitNameStk, ISNULL(ds.Price,0) As PriceSeed, bDt.dNET, mt.Note As NoteOrder, ISNULL(mt.idPOTs,0) As idPOTs, ISNULL(dt.idPODt,0) As idPODt, bMt.DocCode As DocCode_PO" & vbNewLine &
                                   "FROM SmSaleOrderDt dt" & vbNewLine &
                                   "LEFT JOIN SmSaleOrderMt mt ON dt.idSaleOrder = mt.idSaleOrder" & vbNewLine &
                                   "LEFT JOIN dPartner c ON mt.idPartner = c.idPartner " & vbNewLine &
                                   "LEFT JOIN dInventoryMain inv ON dt.idInvMain = inv.idInvMain" & vbNewLine &
                                   "LEFT JOIN dInvCode ic ON inv.idInvMain = ic.idInvMain" & vbNewLine &
                                   "LEFT JOIN dInvUnit u ON dt.idUnit = u.idUnit" & vbNewLine &
                                   "LEFT JOIN dInvUnit us ON inv.idUnit = us.idUnit" & vbNewLine &
                                   "LEFT JOIN dInvGroup As gr ON inv.idInvGroup = gr.idInvGroup" & vbNewLine &
                                   "LEFT JOIN dPackingPdSet fg ON inv.idSubType = fg.idPdPk AND inv.idInvGroup = 2" & vbNewLine &
                                   "LEFT JOIN SmPdOtherD pdo ON inv.idSubType = pdo.idPdo AND gr.stpdOther = 1" & vbNewLine &
                                   "LEFT JOIN dSeedFlPackage sfg ON inv.idSubType = sfg.idFlPk AND inv.idInvgroup = 42" & vbNewLine &
                                   "LEFT JOIN dSeedProductPrice ds ON inv.idInvMain = ds.idInvMain AND inv.idInvGroup = 1 AND ds.idComp = mt.idcomp" & vbNewLine &
                                   "LEFT JOIN vPersonxSelect p1 ON mt.idPsSale = p1.idPs " & vbNewLine &
                                   "LEFT JOIN vPersonxSelect p2 ON mt.idPsOrder = p2.idPs " & vbNewLine &
                                   "LEFT JOIN PkPOBuyDt bDt ON dt.idPODt = bDt.idPODt AND dt.idPODt Is Not NULL" & vbNewLine &
                                   "LEFT JOIN PkPOBuyMt bMt ON bDt.idPOTs = bMt.idPOTs" & vbNewLine &
                                    vWhere & vbNewLine &
                                   "AND ((IsNULL(dt.Amount,0)) - ISNULL(dt.AmountSale,0)) > 0 " & vbNewLine &
                                   "AND mt.idPartner = " & lblPartner.Tag

            sAdapter.Fill(dtOrder)



            Dim tAmtStock As Double = 0.0

            For i As Integer = 0 To dtOrder.Rows.Count - 1

                If dtOrder.Rows(i).Item("idUnitOrd") = 1 Then
                    tAmtStock = dtOrder.Rows(i).Item("AmtStock") * 1000
                Else
                    tAmtStock = dtOrder.Rows(i).Item("AmtStock")
                End If

                If tAmtStock >= dtOrder.Rows(i).Item("AmtOrder") Then
                    dtOrder.Rows(i).Item("stEnough") = 1
                    dtOrder.Rows(i).Item("status") = "พร้อมขาย"
                Else
                    If tAmtStock <> 0 Then
                        dtOrder.Rows(i).Item("stEnough") = 1
                        dtOrder.Rows(i).Item("status") = "มีบางส่วน"
                    End If
                End If

                If Not IsDBNull(dtOrder.Rows(i).Item("stPacking")) Then
                    If dtOrder.Rows(i).Item("stPacking") = 0 Then
                        dtOrder.Rows(i).Item("status") = "อยู่ระหว่างผลิต"
                    End If
                End If
            Next

            If dtOrder.Rows.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูลรายการสั่งซื้อ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                If xProcess = eProcess.eSelect Then
                    Me.Close()
                Else
                    Exit Sub
                End If
            Else
                GCSaleOrder.DataSource = dtOrder
            End If
        End If
    End Sub

    Private Sub GVSaleOrderMt_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GVSaleOrder.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub


    Private Sub GVSaleOrderMt_KeyDown(sender As Object, e As KeyEventArgs) Handles GVSaleOrder.KeyDown

        If e.KeyCode = Keys.Enter Then
            If GVSaleOrder.GetMasterRowExpanded(GVSaleOrder.FocusedRowHandle) = False Then
                GVSaleOrder.SetMasterRowExpanded(GVSaleOrder.FocusedRowHandle, True)

            Else
                GVSaleOrder.CollapseAllDetails()
            End If
        End If

    End Sub

    Private Sub GVSaleOrder_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GVSaleOrder.RowCellStyle

        'If GVSaleOrder.GetRowCellValue(e.RowHandle, ColAmount) > GVSaleOrder.GetRowCellValue(e.RowHandle, ColAmtStock) Then
        '    e.Appearance.ForeColor = Color.Gray
        '    e.Appearance.BackColor = Color.Gainsboro
        'Else
        '    If e.Column.Name = ColstShow.Name Then
        '        e.Appearance.ForeColor = Color.Green
        '    End If
        'End If

    End Sub


    Private Sub cbReadyToOrder_CheckedChanged(sender As Object, e As EventArgs) Handles cbReadyToOrder.CheckedChanged
        fnFilterDataOnGrid()
    End Sub


    Dim idPartner1st As Integer = 0

    Private Sub rptSel_Click(sender As Object, e As EventArgs) Handles rptSel.Click


        Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GCSaleOrder.FocusedView
        Dim status As String = detailView.GetRowCellValue(detailView.FocusedRowHandle, ColstShow)

        If status = "รอผลิต" Or status = "อยู่ระหว่างผลิต" Then
            MessageBox.Show("ไม่สามารถเลือกรายการได้" & vbNewLine & "เนื่องจากรายการนี้ '" & status & "'", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    detailView.SetFocusedRowCellValue("Chk", False)
            Exit Sub
        Else
            idPartner1st = GVSaleOrder.GetRowCellValue(GVSaleOrder.FocusedRowHandle, ColidPartner)
        End If


    End Sub

    Private Sub btnSaleTs_Click(sender As Object, e As EventArgs) Handles btnSaleTs.Click

        CopyOrderDt.Clear()
        If dtOrder.Rows.Count > 0 Then
            Dim dv As New DataView(dtOrder)
            dv.RowFilter = "Chk = True"


            If dv.Count > 0 Then
                For i As Integer = 0 To dv.Count - 1

                    Dim dr_ As DataRow = CopyOrderDt.NewRow

                    Dim pWeight As Double = 0
                    Dim idUnitW As Integer = 0

                    If dv.Item(i).Item("idInvGroup") = 2 Then
                        pWeight = dv.Item(i).Item("Weight")
                        idUnitW = dv.Item(i).Item("idUnitW")
                    ElseIf dv.Item(i).Item("idInvGroup") = 42 Then
                        pWeight = dv.Item(i).Item("WPerPack")
                        idUnitW = 1
                    End If


                    dr_("i") = i + 1
                    dr_("idComp") = dv.Item(i).Item("idComp")
                    dr_("idPartner") = dv.Item(i).Item("idPartner")
                    dr_("PartnerName") = dv.Item(i).Item("PartnerName")
                    dr_("idCus") = dv.Item(i).Item("idCus")
                    dr_("idInvMain") = dv.Item(i).Item("idInvMain")
                    dr_("idSaleOrder") = dv.Item(i).Item("idSaleOrder")
                    dr_("idSaleOrderDt") = dv.Item(i).Item("idSaleOrderDt")
                    dr_("idInvMain") = dv.Item(i).Item("idInvMain")
                    dr_("InvName") = dv.Item(i).Item("InvName")
                    dr_("idInvGroup") = dv.Item(i).Item("idInvGroup")
                    dr_("UnitNameOrd") = dv.Item(i).Item("UnitNameOrd")
                    dr_("idUnitOrd") = dv.Item(i).Item("idUnitOrd")
                    dr_("UnitName") = dv.Item(i).Item("UnitName")
                    dr_("idUnit") = dv.Item(i).Item("idUnit")
                    dr_("idSubType") = dv.Item(i).Item("idSubType")
                    dr_("ShortName") = dv.Item(i).Item("ShortName")
                    dr_("AmtOrder") = dv.Item(i).Item("AmtOrder")
                    dr_("AmtStock") = dv.Item(i).Item("AmtStock")
                    dr_("InvCode") = dv.Item(i).Item("InvCode")
                    dr_("idPdoType") = dv.Item(i).Item("idPdoType")
                    dr_("PriceBill_fg") = dv.Item(i).Item("PriceBill_fg")
                    dr_("PriceWholesale_fg") = dv.Item(i).Item("PriceWholesale_fg")
                    dr_("PriceRetail_fg") = dv.Item(i).Item("PriceRetail_fg")
                    dr_("PricePdo_pdo") = dv.Item(i).Item("PricePdo_pdo")
                    dr_("CreditThirty_pdo") = dv.Item(i).Item("CreditThirty_pdo")
                    dr_("CreditSixty_pdo") = dv.Item(i).Item("CreditSixty_pdo")
                    dr_("PriceSeedFg_sfg") = dv.Item(i).Item("PriceSeedFg_sfg")
                    dr_("PriceSeed") = dv.Item(i).Item("PriceSeed")
                    dr_("DtType") = dv.Item(i).Item("DtType")
                    dr_("DocCode") = dv.Item(i).Item("DocCode")
                    dr_("stSelect") = 0
                    dr_("dNET") = dv.Item(i).Item("dNET")
                    dr_("NoteOrder") = dv.Item(i).Item("NoteOrder")
                    dr_("PsOrder") = dv.Item(i).Item("PsOrder")
                    dr_("idPOTs") = dv.Item(i).Item("idPOTs")
                    dr_("idPODt") = dv.Item(i).Item("idPODt")
                    dr_("DocCode_PO") = dv.Item(i).Item("DocCode_PO")
                    dr_("pWeight") = pWeight
                    dr_("idUnitW") = idUnitW
                    CopyOrderDt.Rows.Add(dr_)

                Next

                Dim vFrm As New frmSlSaleTsASG(frmSlSaleTsASG.eProcess.eNewOrder, 0, CopyOrderDt)

                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    mdCnOpen()
                    mdLoadShow()
                    BindData()
                    mdLoadShow()
                    mdLoadCommitt()
                End If


                'Dim vFrm As New frmSlOrderLotSelect(CopyOrderDt, cmbGroupComp.SelectedValue)

                'If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                '    mdCnOpen()
                '    SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                '    BindData()
                '    SplashScreenManager.CloseForm(False)
                'End If

            Else
                MessageBox.Show("กรุณาเลือกอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else
            MessageBox.Show("กรุณาเลือกอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub


    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click

        Dim vFrm As New frmSlOrderToSaleCustomer(frmSlOrderToSaleCustomer.eProcess.eSelect, cmbGroupComp.SelectedValue, cmbGroupComp.Text)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPartner.Tag = vFrm.idPartner
            Me.lblPartner.Text = vFrm.PartnerName

            If vFrm.idPartner <> 0 Then
                mdCnOpen()
                mdLoadShow()
                BindData()
                mdLoadShow()
                mdLoadCommitt()

                stLoad = 1
            End If
        End If

    End Sub


    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            lblPartner.Tag = Nothing
            lblPartner.Text = ""

            GCSaleOrder.DataSource = Nothing
        End If

    End Sub

    Private Sub fnFilterDataOnGrid()
        Dim StrFilter As String = ""

        If cbReadyToOrder.Checked = True Then
            StrFilter = " AND stEnough = 1"
        End If

        If chkDocCode.Checked = True Then
            StrFilter &= " AND [DocCode] LIKE '%" & Trim(txtDocCode.Text) & "%'"
        End If

        If cbDocCodePO.Checked = True Then
            StrFilter &= " AND [DocCode_PO] LIKE '%" & Trim(txtDocCodePO.Text) & "%'"
        End If


        GVSaleOrder.ActiveFilterString = " 1=1" + StrFilter

    End Sub

    Private Sub lblPsCus_TextChanged(sender As Object, e As EventArgs) Handles lblPartner.TextChanged
        fnFilterDataOnGrid()
    End Sub

    Private Sub chkDocCode_CheckedChanged(sender As Object, e As EventArgs) Handles chkDocCode.CheckedChanged
        If chkDocCode.Checked = True Then
            txtDocCode.Enabled = True
            txtDocCode.Focus()
        Else
            txtDocCode.Enabled = False
            txtDocCode.Clear()
        End If

        fnFilterDataOnGrid()

    End Sub

    Private Sub cbDocCodePO_CheckedChanged(sender As Object, e As EventArgs) Handles cbDocCodePO.CheckedChanged
        If cbDocCodePO.Checked = True Then
            txtDocCodePO.Enabled = True
            txtDocCodePO.Focus()
        Else
            txtDocCodePO.Enabled = False
            txtDocCodePO.Clear()
        End If

        fnFilterDataOnGrid()
    End Sub

    Private Sub chkDoc_CheckedChanged(sender As Object, e As EventArgs) Handles chkDoc.CheckedChanged
        fnGroupColumn()
    End Sub

    Private Sub fnGroupColumn()

        'If chkCus.Checked = True And chkDoc.Checked = True Then
        '    ColPartnerName.GroupIndex = 0
        '    ColDocCode.GroupIndex = 1
        'ElseIf chkDoc.Checked = True And chkCus.Checked = False Then
        '    ColPartnerName.GroupIndex = -1
        '    ColDocCode.GroupIndex = 0
        If chkDoc.Checked = True Then
            'ColPartnerName.GroupIndex = 0
            ColDocCode.GroupIndex = 0
        Else
            'ColPartnerName.GroupIndex = -1
            ColDocCode.GroupIndex = -1
        End If
    End Sub

    Private Sub txtDocCode_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDocCode.KeyUp
        fnFilterDataOnGrid()
    End Sub

    Private Sub txtDocCodePO_TextChanged(sender As Object, e As EventArgs) Handles txtDocCodePO.KeyUp
        fnFilterDataOnGrid()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadShow()
        mdLoadCommitt()
    End Sub

  
    Private Sub frmSlOrderToSale_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        xTimer.Stop()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If dtOrder.Rows.Count > 0 Then
            Dim dv As New DataView(dtOrder)
            dv.RowFilter = "Chk = True"

            If dv.Count > 0 Then
                For i As Integer = 0 To dv.Count - 1

                    Dim dr_ As DataRow = gMainReturn.NewRow

                    Dim pWeight As Double = 0
                    Dim idUnitW As Integer = 0

                    If dv.Item(i).Item("idInvGroup") = 2 Then
                        pWeight = dv.Item(i).Item("Weight")
                        idUnitW = dv.Item(i).Item("idUnitW")
                    ElseIf dv.Item(i).Item("idInvGroup") = 42 Then
                        pWeight = dv.Item(i).Item("WPerPack")
                        idUnitW = 1
                    End If


                    dr_("i") = i + 1
                    dr_("idComp") = dv.Item(i).Item("idComp")
                    dr_("idPartner") = dv.Item(i).Item("idPartner")
                    dr_("PartnerName") = dv.Item(i).Item("PartnerName")
                    dr_("idCus") = dv.Item(i).Item("idCus")
                    dr_("idInvMain") = dv.Item(i).Item("idInvMain")
                    dr_("idSaleOrder") = dv.Item(i).Item("idSaleOrder")
                    dr_("idSaleOrderDt") = dv.Item(i).Item("idSaleOrderDt")
                    dr_("idInvMain") = dv.Item(i).Item("idInvMain")
                    dr_("InvName") = dv.Item(i).Item("InvName")
                    dr_("idInvGroup") = dv.Item(i).Item("idInvGroup")
                    dr_("UnitNameOrd") = dv.Item(i).Item("UnitNameOrd")
                    dr_("idUnitOrd") = dv.Item(i).Item("idUnitOrd")
                    dr_("UnitName") = dv.Item(i).Item("UnitName")
                    dr_("idUnit") = dv.Item(i).Item("idUnit")
                    dr_("idSubType") = dv.Item(i).Item("idSubType")
                    dr_("ShortName") = dv.Item(i).Item("ShortName")
                    dr_("AmtOrder") = dv.Item(i).Item("AmtOrder")
                    dr_("AmtStock") = dv.Item(i).Item("AmtStock")
                    dr_("InvCode") = dv.Item(i).Item("InvCode")
                    dr_("idPdoType") = dv.Item(i).Item("idPdoType")
                    dr_("PriceBill_fg") = dv.Item(i).Item("PriceBill_fg")
                    dr_("PriceWholesale_fg") = dv.Item(i).Item("PriceWholesale_fg")
                    dr_("PriceRetail_fg") = dv.Item(i).Item("PriceRetail_fg")
                    dr_("PricePdo_pdo") = dv.Item(i).Item("PricePdo_pdo")
                    dr_("CreditThirty_pdo") = dv.Item(i).Item("CreditThirty_pdo")
                    dr_("CreditSixty_pdo") = dv.Item(i).Item("CreditSixty_pdo")
                    dr_("PriceSeedFg_sfg") = dv.Item(i).Item("PriceSeedFg_sfg")
                    dr_("PriceSeed") = dv.Item(i).Item("PriceSeed")
                    dr_("DtType") = dv.Item(i).Item("DtType")
                    dr_("DocCode") = dv.Item(i).Item("DocCode")
                    dr_("stSelect") = 0
                    dr_("dNET") = dv.Item(i).Item("dNET")
                    dr_("NoteOrder") = dv.Item(i).Item("NoteOrder")
                    dr_("PsOrder") = dv.Item(i).Item("PsOrder")
                    dr_("idPOTs") = dv.Item(i).Item("idPOTs")
                    dr_("idPODt") = dv.Item(i).Item("idPODt")
                    dr_("DocCode_PO") = dv.Item(i).Item("DocCode_PO")
                    dr_("pWeight") = pWeight
                    dr_("idUnitW") = idUnitW
                    gMainReturn.Rows.Add(dr_)

                Next
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub
End Class