Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.Runtime.Serialization
Imports DevExpress.XtraEditors

Public Class frmSlReturnTsJU
    Dim MainReturn As New DataTable
    Dim NewPdDt As New DataTable
    Dim Result As DialogResult
    Dim idSaleReturn_ As Integer
    Dim Process As eProcess
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim idRTWh As Integer = 0
    Dim idFM As Integer = 0
    Dim idPartner As Integer = 0
    Dim idCus As Integer = 0
    Dim dtDel As New DataTable
    Dim dtJUDel As New DataTable
    Dim stLoad As Integer = 0
    Dim chxCompany As Integer = 0
    Dim idRtAVxST As Integer = 0
    Enum eProcess
        eNewReturn
        eEdit 'JUDt
        eviewData
        eCancel 'JUDt
        eAccept 'JUDt
        eCheck 'JUDt
        eApprove 'JUDt
        eManageReject
        eAddJUPd 'Add New Product
        ' eDelete
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idSaleReturn As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess

            Case eProcess.eNewReturn
                Me.lblDateTs.Text = Date.Today
                Me.lblPsTs.Text = sPsName
                Me.lblPsTs.Tag = sPsId
                Me.txtDocRef.Focus()

            Case eProcess.eEdit
                Me.Text = "แก้ไขรายการคืนสินค้า (รหัส JU)"

                cmbGroupComp.Enabled = False

            Case eProcess.eAddJUPd
                Me.Text = "เลือกสินค้าใหม่ทดแทน"
                SetToolBox()

                cmbGroupComp.Enabled = False

                btnCustomer.Visible = False

                ColDel.Visible = False

                ColLotno.OptionsColumn.ReadOnly = True
                ColLotno.OptionsColumn.AllowEdit = False

                ColInvName.OptionsColumn.ReadOnly = True
                ColInvName.OptionsColumn.AllowEdit = False

                ColDocCode.OptionsColumn.ReadOnly = True
                ColDocCode.OptionsColumn.AllowEdit = False

                ColAmtRT.OptionsColumn.ReadOnly = True
                ColAmtRT.OptionsColumn.AllowEdit = False

                ColUnitName.OptionsColumn.ReadOnly = True
                ColUnitName.OptionsColumn.AllowEdit = False

                ColWh.OptionsColumn.ReadOnly = True
                ColWh.OptionsColumn.AllowEdit = False

                ColPrice.OptionsColumn.ReadOnly = True
                ColPrice.OptionsColumn.AllowEdit = False

                ColRTPrice.OptionsColumn.ReadOnly = True
                ColRTPrice.OptionsColumn.AllowEdit = False

                ColRTValuePerc.OptionsColumn.ReadOnly = True
                ColRTValuePerc.OptionsColumn.AllowEdit = False

                ColSummary.OptionsColumn.ReadOnly = True
                ColSummary.OptionsColumn.AllowEdit = False

                ColPdCode.OptionsColumn.ReadOnly = True
                ColPdCode.OptionsColumn.AllowEdit = False

                Me.btnSave.Visible = True

            Case eProcess.eviewData
                Me.Text = "รายละเอียดรายการคืนสินค้า (รหัส JU)"

                SetToolBox()
                SetToolBoxNotAddxEdit()
             
            Case eProcess.eCancel
                Me.Text = "ยกเลิกรายการคืนสินค้า (รหัส JU)"
                Me.btnDelete.Visible = True

                SetToolBox()
                SetToolBoxNotAddxEdit()
           
            Case eProcess.eAccept
                Me.Text = "รับทราบ รายการคืนสินค้า JU"
                Me.btnProcess.Visible = True
                Me.btnProcess.Text = "รับทราบ"
                Me.btnProcess.Image = My.Resources.ResourceManager.GetObject("check_icon555")

                SetToolBox()
                SetToolBoxNotAddxEdit()
            Case eProcess.eCheck
                Me.Text = "ตรวจสอบ รายการคืนสินค้า JU"
                Me.btnProcess.Visible = True
                Me.btnProcess.Text = "ตรวจสอบ"
                Me.btnProcess.Image = My.Resources.ResourceManager.GetObject("clear_tick_icon")

                SetToolBox()
                SetToolBoxNotAddxEdit()
            Case eProcess.eApprove
                Me.Text = "อนุมัติ รายการคืนสินค้า JU"
                Me.btnProcess.Visible = True
                Panel7.Visible = True
                Me.btnProcess.Text = "บันทึกการอนุมัติ"
                Me.btnProcess.Image = My.Resources.ResourceManager.GetObject("iconcorrect16")

                SetToolBox()
                SetToolBoxNotAddxEdit()
            Case eProcess.eManageReject
                idSaleReturn_ = idSaleReturn
                lblRejectCase.Visible = True
                lblRejectCase.Visible = True

                SetToolBoxNotAddxEdit()



        End Select

        Process = aProcess
        idSaleReturn_ = idSaleReturn
    End Sub

    Private Sub frmSlReturnTsJU_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        setCmbGroupComp(Me.cmbGroupComp)

        ReturnCause()
        ReturnDocCode()

        initialDataTable(MainReturn)
        initialDataTable(dtDel)
        GCReturn.DataSource = MainReturn

        '---- Set New Product ----'
        initDtNewPd(NewPdDt)
        initDtNewPd(dtJUDel)
        GCNewPd.DataSource = NewPdDt

        If Process <> eProcess.eNewReturn Then
            BindData()
        End If

        cmbWhOnGrid()
        stLoad = 1

    End Sub

    Private Sub SetToolBoxNotAddxEdit()
        cmbGroupComp.Enabled = False
        btnCustomer.Visible = False

        ColDel.Visible = False
        ColDel_n.Visible = False

        ColLotno.OptionsColumn.ReadOnly = True
        ColLotno.OptionsColumn.AllowEdit = False

        ColInvName.OptionsColumn.ReadOnly = True
        ColDocCode.OptionsColumn.ReadOnly = True
        ColAmtRT.OptionsColumn.ReadOnly = True
        ColUnitName.OptionsColumn.ReadOnly = True
        ColWh.OptionsColumn.ReadOnly = True

        ColPrice.OptionsColumn.ReadOnly = True
        ColRTPrice.OptionsColumn.ReadOnly = True
        ColRTValuePerc.OptionsColumn.ReadOnly = True
        ColSummary.OptionsColumn.ReadOnly = True
        ColPdCode.OptionsColumn.ReadOnly = True
        ColInvName_n.OptionsColumn.ReadOnly = True
        ColAmount_n.OptionsColumn.ReadOnly = True

        ColInvName.OptionsColumn.AllowEdit = False
        ColDocCode.OptionsColumn.AllowEdit = False
        ColAmtRT.OptionsColumn.AllowEdit = False
        ColUnitName.OptionsColumn.AllowEdit = False
        ColWh.OptionsColumn.AllowEdit = False

        ColPrice.OptionsColumn.AllowEdit = False
        ColRTPrice.OptionsColumn.AllowEdit = False
        ColRTValuePerc.OptionsColumn.AllowEdit = False
        ColSummary.OptionsColumn.AllowEdit = False

        ColPdCode.OptionsColumn.AllowEdit = False
        ColInvName_n.OptionsColumn.AllowEdit = False
        ColAmount_n.OptionsColumn.AllowEdit = False


        GvReturn.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
        GvReturn.OptionsView.NewItemRowPosition = DevExpress.Utils.DefaultBoolean.Default

        GVNewPd.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
        GVNewPd.OptionsView.NewItemRowPosition = DevExpress.Utils.DefaultBoolean.Default

        rptInvName.Appearance.ForeColor = Color.Black
        rptLotNo.Appearance.ForeColor = Color.Black
    End Sub



    Private Sub initDtNewPd(ByVal Datatable As DataTable)
        Datatable.Columns.Add("idInvMain", System.Type.GetType("System.Int32"))
        Datatable.Columns.Add("PdCode", System.Type.GetType("System.String"))
        Datatable.Columns.Add("InvName", System.Type.GetType("System.String"))
        Datatable.Columns.Add("Amount", System.Type.GetType("System.Double"))
        Datatable.Columns.Add("UnitName", System.Type.GetType("System.String"))
        Datatable.Columns.Add("idUnit", System.Type.GetType("System.Int32"))
        Datatable.Columns.Add("idJUDt", System.Type.GetType("System.Int32"))


    End Sub

    Private Sub SetToolBox()
        Me.cmbDRCode.Enabled = False
        Me.txtDocRef.Enabled = False
        Me.dtpReturn.Enabled = False
        Me.cmbCauseReturn.Enabled = False
        Me.btnCustomer.Visible = False
        Me.btnPsSale.Visible = False
        Me.btnPsReturn.Visible = False
        Me.txtNote.Enabled = False

        Me.btnSave.Visible = False

        'ColDel.Visible = False
        'ColDel_n.Visible = False
        'ColAmtRT.OptionsColumn.ReadOnly = True
        'ColAmtRT.OptionsColumn.AllowEdit = False
        'ColLotno.OptionsColumn.ReadOnly = True
        'ColLotno.OptionsColumn.AllowEdit = False
        'ColAmount_n.OptionsColumn.ReadOnly = True
        'ColAmount_n.OptionsColumn.AllowEdit = False
    End Sub

    Sub BindData()

        mdCnOpen()
        Dim vDt As New DataTable
        vDt.Clear()
        sCommand.CommandText = "Select DocNum, idRTDocCode, DocRef, DateReturnD, idRtCause, p.PartnerName As CusName, mt.idPartner, mt.idCus, mt.idFm, idPsSale, " & vbNewLine & _
                               "ISNULL(ps.PsName, '-') As PsSale, idPsReturn,ISNULL(pr.PsName,'-') As PsReturn, Total, Note, DateTsD, pt.PsName As PsTs, RejectNote, " & vbNewLine & _
                               "ISNULL(idRtAVxST,0) As idRtAVxST" & vbNewLine & _
                               "From SmSaleReturnMt mt " & vbNewLine & _
                               "LEFT JOIN dPartner p ON mt.idPartner = p.idPartner" & vbNewLine & _
                               "LEFT JOIN vPersonxSelect ps ON mt.idPsSale = ps.idPs" & vbNewLine & _
                               "LEFT JOIN vPersonxSelect pr ON mt.idPsSale = pr.idPs" & vbNewLine & _
                               "LEFT JOIN vPersonxSelect pt ON mt.idPsTs = pt.idPs" & vbNewLine & _
                               "Where idSaleReturn = " & idSaleReturn_
        sAdapter.Fill(vDt)

        idPartner = vDt.Rows(0).Item("idPartner")
        idRtAVxST = vDt.Rows(0).Item("idRtAVxST")
        If IsDBNull(vDt.Rows(0).Item("idCus")) Then
            idFM = vDt.Rows(0).Item("idFM")
        Else
            idCus = vDt.Rows(0).Item("idCus")
        End If

        Me.lblDocNum.Text = vDt.Rows(0).Item("DocNum")
        Me.cmbDRCode.SelectedValue = vDt.Rows(0).Item("idRTDocCode")
        Me.txtDocRef.Text = vDt.Rows(0).Item("DocRef")
        Me.dtpReturn.Value = vDt.Rows(0).Item("DateReturnD")
        Me.cmbCauseReturn.SelectedValue = vDt.Rows(0).Item("idRtCause")
        Me.lblPsCus.Text = vDt.Rows(0).Item("CusName")
        Me.lblPsCus.Tag = vDt.Rows(0).Item("idCus")
        Me.lblPsSale.Text = vDt.Rows(0).Item("PsSale")
        Me.lblPsSale.Tag = vDt.Rows(0).Item("idPsSale")
        Me.lblPsReturn.Text = vDt.Rows(0).Item("PsReturn")
        Me.lblPsReturn.Tag = vDt.Rows(0).Item("idPsReturn")
        Me.lblDateTs.Text = vDt.Rows(0).Item("DateTsD")
        Me.lblPsTs.Text = vDt.Rows(0).Item("PsTs")
        Me.txtNote.Text = vDt.Rows(0).Item("Note")
        If Not IsDBNull(vDt.Rows(0).Item("RejectNote")) Then
            Me.lblRejectCase.Text = vDt.Rows(0).Item("RejectNote")
        End If

        '*****Show data from SmSaleReturnDt ******'
        MainReturn.Rows.Clear()
        mdCnOpen()
        sCommand.CommandText = "SELECT dt.idSaleReturnDt, sl.idSaleDt, dt.idLotSale, dt.idSale, ISNULL(lm.DateGen,'') As DateGen, " & vbNewLine & _
                              "dt.LotNoRt As LotNo,dt.LotNoRt As LotNoHide, inv.InvName, ISNULL(dt.AmountReturn, 0.0) As AmountRT, ISNULL(dt.AmountReturn, 0.0) As AmountRTHide,   " & vbNewLine & _
                              "unit.UnitName, dt.Price, dt.Price As PriceHide, ISNULL(dt.RTValuePerc, 0.0) As RTValuePerc,ISNULL(dt.RTValuePerc, 0.0) As RTValuePercHide," & _
                              "ISNULL(dt.RTPrice, 0.00) As RTPrice,  ISNULL(dt.RTPrice, 0.00) As RTPriceHide,  " & vbNewLine & _
                              "(ISNULL(dt.AmountReturn,0.0) * ISNULL(dt.RTPrice, 0.00)) As Exp, ISNULL(lm.DateGen,'') As DateGen, dt.idUnit, dt.idUnit As idUnitHide, dt.idInvMain, " & vbNewLine & _
                              "sl.Amount - ISNUll((Select SUM(rd.AmountReturn) " & vbNewLine & _
                                                    "From SmSaleReturnDt rd " & vbNewLine & _
                                                    "LEFT OUTER JOIN SmSaleReturnMt rm ON rd.idSaleReturn = rm.idSaleReturn " & vbNewLine & _
                                                    "WHERE rd.idSaleDt = dt.idSaleDt " & vbNewLine & _
                                                    "AND rm.idPsCancel IS NULL), 0.00) As BalanceRT,  " & vbNewLine & _
                              "dt.idWh, dt.idWh As idWhHide, dt.idLotReturn, dt.idInvMain, dt.idLot, inv.idUnit, '' As DocRef, mt.idComp, inv.idInvGroup" & vbNewLine & _
                              "FROM SmSaleReturnDt dt " & vbNewLine & _
                              "LEFT OUTER JOIN SmSaleDtAll sl ON dt.idSaleDt = sl.idSaleDt " & vbNewLine & _
                              "LEFT JOIN SmSaleReturnMt mt ON dt.idSaleReturn = mt.idSaleReturn" & vbNewLine & _
                              "LEFT JOIN dInvUnit unit ON dt.idUnit = unit.idUnit" & vbNewLine & _
                              "LEFT JOIN dInvLotMain lm ON dt.idLot = lm.idLot " & vbNewLine & _
                              "LEFT JOIN dInvLotRefWh As lot ON dt.idLot = lot.idLot And dt.idWh = lot.idWh" & vbNewLine & _
                              "LEFT JOIN dInventoryMain As inv ON dt.idInvMain = inv.idInvmain" & vbNewLine & _
                              "WHERE dt.idSaleReturn = " & idSaleReturn_


        sAdapter.Fill(MainReturn)

        cmbGroupComp.SelectedValue = MainReturn.Rows(0).Item("idComp")

        GCReturn.DataSource = MainReturn
        GvReturn.ExpandAllGroups()
        SumReturn()

        '*****Show data from SmSaleReturnJUDt ******'
        NewPdDt.Rows.Clear()
        sCommand.CommandText = "SELECT dt.idJUDt, dt.idInvMain, inv.InvName, Amount, dt.idUnit, unit.UnitName, inv.InvCode As PdCode " & vbNewLine & _
                               "FROM SmSaleReturnJUDt As dt " & vbNewLine & _
                               "LEFT JOIN dInventoryMain As inv ON dt.idinvMain = inv.idInvMain" & vbNewLine & _
                               "LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine & _
                               "WHERE idSaleReturn = " & idSaleReturn_
        sAdapter.Fill(NewPdDt)

        GCNewPd.DataSource = NewPdDt
        SumNewPd()
    End Sub

    Private Sub initialDataTable(ByRef dataTable As DataTable)
        dataTable.Columns.Add("idSaleDt", System.Type.GetType("System.Int64"))
        dataTable.Columns.Add("idLot", System.Type.GetType("System.Int64"))
        dataTable.Columns.Add("idSale", System.Type.GetType("System.Int64"))
        dataTable.Columns.Add("DocRef", System.Type.GetType("System.String"))
        dataTable.Columns.Add("LotNo", System.Type.GetType("System.String"))
        dataTable.Columns.Add("idInvMain", System.Type.GetType("System.Int32"))
        dataTable.Columns.Add("InvName", System.Type.GetType("System.String"))
        dataTable.Columns.Add("AmountRT", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("UnitName", System.Type.GetType("System.String"))
        dataTable.Columns.Add("idWh", System.Type.GetType("System.Int32")) 'use stType in SsWarehouse
        dataTable.Columns.Add("DateGen", System.Type.GetType("System.String"))
        dataTable.Columns.Add("idUnit", System.Type.GetType("System.Int32"))
        dataTable.Columns.Add("BalanceRT", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("idLotSale", System.Type.GetType("System.Int32"))
        dataTable.Columns.Add("Price", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("RTValuePerc", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("RTPrice", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("Exp", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("idSaleReturnDt", System.Type.GetType("System.Int32"))
        dataTable.Columns.Add("idLotReturn", System.Type.GetType("System.Int32"))
        dataTable.Columns.Add("AmountRTHide", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("LotNoHide", System.Type.GetType("System.String"))
        dataTable.Columns.Add("idWhHide", System.Type.GetType("System.Int32"))
        dataTable.Columns.Add("PriceHide", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("RTValueHide", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("RTValuePercHide", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("idInvGroup", System.Type.GetType("System.Int32"))
    End Sub

    Private Sub ReturnCause()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idRtCause, ReturnCause From SmSaleReturnCause WHERE stDel IS NULL"
        sAdapter.Fill(sDt)
        With cmbCauseReturn
            .DisplayMember = "ReturnCause"
            .ValueMember = "idRtCause"
            .DataSource = sDt
        End With
    End Sub

    Private Sub ReturnDocCode()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idRTDocCode, ReturnCode From SmSaleReturnCode WHERE stDel IS NULL AND idRTDocCode = 2"
        sAdapter.Fill(sDt)
        With cmbDRCode
            .DisplayMember = "ReturnCode"
            .ValueMember = "idRTDocCode"
            .DataSource = sDt
        End With
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        chxCompany = 0
        If GvReturn.DataRowCount > 0 Then


            Dim result As DialogResult = MessageBox.Show("ระบบจะทำการลบรายการคืนสินค้าทั้งหมด" & vbCrLf & "ยืนยันจะเปลี่ยนแปลงชื่อลูกค้าใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If result = Windows.Forms.DialogResult.Yes Then
                lblPsCus.Text = ""
                lblPsCus.Tag = 0
                lblPsSale.Text = ""
                lblPsReturn.Text = ""
                txtCntSumReturn.Text = 0
                txtCntReturn.Text = 0
                txtNewPd.Text = 0
                Me.lblPsSale.Tag = 0
                idPartner = 0

                fnKeptDataForRTStk()
                fnKeptDataJUPdForDelete()
                MainReturn.Clear()
                NewPdDt.Clear()
            Else
                Exit Sub
            End If

            SumReturn()
        End If

        Dim tempWh As New DataTable
        tempWh.Clear()
        Dim idComp As Integer = cmbGroupComp.SelectedValue

        If idComp = 10 Then
            idComp = 4
        End If
        mdCnOpen()
        sCommand.CommandText = "SELECT idWh FROM SsWarehouse WHERE idComp = " & idComp & " AND stType = 1" 'คลังรับคืน
        sAdapter.Fill(tempWh)

        If tempWh.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูลคลังรับคืนของบริษัทนี้ " & vbNewLine & "กรุณาเพิ่มคลังที่ระบบ WIM ก่อนทำรายการรับคืน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            idRTWh = tempWh.Rows(0).Item("idWh")
        End If

        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelectAllChkSt, cmbGroupComp.SelectedValue)

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            idFM = vFrm.idFm
            idPartner = vFrm.idPartner
            idCus = vFrm.idCus

            Me.lblPsCus.Tag = vFrm.idCus

            Me.lblPsCus.Text = vFrm.CusName

            If stLoad = 1 And chxCompany = 0 Then
                setPsData()
            End If

        End If
    End Sub

    Private Sub fnKeptDataForRTStk()

        For i As Integer = 0 To GvReturn.DataRowCount - 1
            Dim dr As DataRow = GvReturn.GetDataRow(i)
            Dim drtemp As DataRow = dtDel.NewRow()

            If Not IsDBNull(dr.Item("idSaleReturnDt")) Then

                drtemp("idSaleReturnDt") = dr.Item("idSaleReturnDt")
                drtemp("idWh") = dr.Item("idWh")
                drtemp("idInvMain") = dr.Item("idInvMain")
                drtemp("idLot") = dr.Item("idLot")
                drtemp("LotNo") = dr.Item("LotNo")
                drtemp("AmountRT") = dr.Item("AmountRT")
                dtDel.Rows.Add(drtemp)
                dtDel.AcceptChanges()
            End If


        Next

    End Sub

    Private Sub fnKeptDataJUPdForDelete()
        For i As Integer = 0 To GVNewPd.DataRowCount - 1
            Dim dr As DataRow = GVNewPd.GetDataRow(i)
            Dim drtemp As DataRow = dtJUDel.NewRow()
            If Not IsDBNull(dr.Item("idJUDt")) Then

                drtemp("idJUDt") = dr.Item("idJUDt")

                dtJUDel.Rows.Add(drtemp)
                dtJUDel.AcceptChanges()
            End If


        Next
    End Sub

    Private Sub setPsData()
        Dim dt As New DataTable
        Dim Dt2 As New DataTable
        'PsCustomer = Me.lblPsCus.Text
        'idPsCus = Me.lblPsCus.Tag
        dt.Clear()
        'sCommand.CommandText = "Select m.idPs, p.PsName " & vbNewLine & _
        '                             "From SmMkCusPs m " & vbNewLine & _
        '                             "LEFT OUTER JOIN vPersonxSelect p ON m.idPs = p.idPs " & _
        '                             "Where m.idComp = " & cmbGroupComp.SelectedValue & _
        '                             "AND m.idCus = (SELECT idCus FROM dPartner Where idPartner = " & idPartner & ")"
        'sCommand.CommandText = "SELECT p.PsName, ds.idPsSale As idPs  " & vbNewLine & _
        '                           "FROM SmMkCusPs ps" & vbNewLine & _
        '                           "LEFT JOIN SmRegionPsSaleSet As s ON ps.idRegion = s.idRegion" & vbNewLine & _
        '                           "LEFT JOIN dPsSalecompSet As ds ON s.idPsComSet = ds.idPsComSet AND ps.idComp = ds.idComp" & vbNewLine & _
        '                           "LEFT JOIN vPersonxSelect p ON ds.idPsSale = p.idPs" & vbNewLine & _
        '                           "WHERE ds.idComp = " & cmbGroupComp.SelectedValue & vbNewLine & _
        '                           "AND ps.idCus = (SELECT idCus FROM dPartner Where idPartner = " & idPartner & ")"
        sCommand.CommandText = "SELECT c.idPsSale As idPs, p.PsName " & vbNewLine & _
                               "FROM SmRegionPsSaleComp c " & vbNewLine & _
                               "LEFT JOIN  SmMkCusPs ps ON  c.idRegionC = ps.idRegionC AND ps.idComp = c.idComp" & vbNewLine & _
                               "LEFT JOIN vPersonxSelect p ON c.idPsSale = p.idPs" & vbNewLine & _
                               "WHERE ps.idCus =  (SELECT idCus FROM dPartner Where idPartner = " & idPartner & ")" & vbNewLine & _
                               "AND ps.idComp = " & cmbGroupComp.SelectedValue
        sAdapter.Fill(dt)

        If dt.Rows.Count = 1 Then
            Me.lblPsSale.Tag = dt.Rows(0).Item("idPs")
            Me.lblPsSale.Text = dt.Rows(0).Item("PsName")
            Me.lblPsReturn.Tag = dt.Rows(0).Item("idPs")
            Me.lblPsReturn.Text = dt.Rows(0).Item("PsName")
        Else
            If dt.Rows.Count <> 0 Then
                '---- มีพนังานขายหลายคน
                Dim PsSaleList As String = ""
                For i As Integer = 0 To dt.Rows.Count - 1
                    If i = 0 Then
                        PsSaleList = dt.Rows(i).Item("PsName")
                    Else
                        PsSaleList = PsSaleList & ", " & dt.Rows(i).Item("PsName") & " "
                    End If
                Next
                MessageBox.Show("ลูกค้าคนนี้มีข้อมูลผูกกับพนักงานขายหลายคน ได้แก่ " & PsSaleList & "ระบบจะดึงพนักงานขายที่มีประวัติการขายกับลูกค้าครั้งล่าสุด", _
                                sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else 'ไม่มีพนักงานขาย
                MessageBox.Show("ลูกค้าคนนี้ไม่มีข้อมูลผูกกับพนักงานขาย ระบบจะดึงพนักงานขายที่มีประวัติการขายกับลูกค้าครั้งล่าสุด", sSystemName, _
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Dt2.Clear()
            sCommand.CommandText = "Select idPsSale, p.PsName As PsSale " & vbNewLine & _
                                    "From SmSaleMt mt " & vbNewLine & _
                                    "LEFT JOIN vPersonxSelect p ON mt.idPsSale = p.idPs" & vbNewLine & _
                                    "Where mt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine & _
                                    "AND idPartner = " & idPartner & vbNewLine & _
                                    "ORDER By idSale DESC"
            sAdapter.Fill(Dt2)

            If Dt2.Rows.Count <> 0 Then
                Me.lblPsSale.Tag = Dt2.Rows(0).Item("idPsSale")
                Me.lblPsSale.Text = Dt2.Rows(0).Item("PsSale")
                Me.lblPsReturn.Tag = Dt2.Rows(0).Item("idPsSale")
                Me.lblPsReturn.Text = Dt2.Rows(0).Item("PsSale")
            Else
                MessageBox.Show("ลูกค้าคนนี้ไม่มีข้อมูลผูกกับพนักงานขาย และไม่มีประวัติการขายสินค้า", sSystemName, _
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub

    Private Sub btnPsSale_Click(sender As Object, e As EventArgs) Handles btnPsSale.Click
        If Me.lblPsCus.Text = "" Then
            Dim vFrm As New frmPsSaleSelect(frmPsSaleSelect.eProcess.eNormal, Nothing, Me.lblPsCus.Text, Me.lblPsCus.Tag, 1, cmbGroupComp.SelectedValue)
            ' vFrm.ShowText(Me.lblPsCus.Text, Me.lblPsCus.Tag, 1) 'No Customer
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                lblPsSale.Tag = vFrm.idPs
                lblPsSale.Text = vFrm.SaleName
                Me.lblPsReturn.Tag = vFrm.idPs
                Me.lblPsReturn.Text = vFrm.SaleName
            End If
        Else
            Dim vFrm As New frmPsSaleSelect(frmPsSaleSelect.eProcess.eNormal, Nothing, Me.lblPsCus.Text, Me.lblPsCus.Tag, 0, cmbGroupComp.SelectedValue)
            ' vFrm.ShowText(Me.lblPsCus.Text, Me.lblPsCus.Tag, 0) 'have Customer
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                lblPsSale.Tag = vFrm.idPs
                lblPsSale.Text = vFrm.SaleName
                Me.lblPsReturn.Tag = vFrm.idPs
                Me.lblPsReturn.Text = vFrm.SaleName
            End If
        End If
    End Sub

    Private Sub btnPsReturn_Click(sender As Object, e As EventArgs) Handles btnPsReturn.Click
        Dim vFrm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPsReturn.Tag = vFrm.mId
            Me.lblPsReturn.Text = vFrm.mName
        End If
    End Sub

    Private Sub SumReturn()
        Dim CntReturn As Integer = 0
        Dim CntSumReturn As Decimal = 0.0
        For i As Integer = 0 To GvReturn.DataRowCount - 1
            CntReturn += GvReturn.GetDataRow(i).Item("AmountRT")
            CntSumReturn += GvReturn.GetDataRow(i).Item("Exp")
        Next

        txtCntReturn.Text = Format(CntReturn, "#,##0.00##")
        txtCntSumReturn.Text = Format(CntSumReturn, "#,##0.00")
    End Sub

    Private Sub SumNewPd()
        Dim CntNewPd As Integer = 0
        For i As Integer = 0 To GVNewPd.DataRowCount - 1
            CntNewPd += GVNewPd.GetDataRow(i).Item("Amount")
        Next
        txtNewPd.Text = Format(CntNewPd, "#,##0.00##")
    End Sub


    Private Sub GvReturn_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvReturn.CellValueChanged

        Dim Amt As Double = 0
        Dim Price As Double = 0
        Dim Cost As Double = 0
        Dim PriceRT As Double = 0

        If Not IsDBNull(GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColAmtRT)) Then
            Amt = GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColAmtRT)
        Else
            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColAmtRT, 1)
        End If

        If Not IsDBNull(GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColPrice)) Then
            Price = GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColPrice)
        End If

        If Not IsDBNull(GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColRTValuePerc)) Then
            Cost = GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColRTValuePerc)
        End If

        If Not IsDBNull(GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColRTPrice)) Then
            PriceRT = GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColRTPrice)
        End If


        If e.Column.Name = ColAmtRT.Name Then
            'If GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColidSale) <> 0 Then
            '    ' จำนวนคืน > จำนวนขายที่สามารถคืนได้
            '    If GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColAmtRT) > GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColBalanceRT) Then
            '        mdLoadCommitt()
            '        Dim vMsg As String = "จำนวนสินค้าที่คืนมากกว่าจำนวนสินค้าที่ขาย" & vbCrLf & _
            '            "** จำนวนสินค้าขายที่สามารถคืนได้ " & Format(GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColBalanceRT), "#,##0.00##") & " " & _
            '            GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColUnitName) & " **"
            '        MessageBox.Show(vMsg, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '        GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColAmtRT, GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColBalanceRT))
            '        GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColSummary, Calculate(Price, PriceRT, Cost) * GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColBalanceRT))
            '        SumReturn()
            '        Exit Sub
            '    Else

            '        GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColSummary, Calculate(Price, PriceRT, Cost) * Amt)
            '        SumReturn()
            '    End If
            'Else
            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColSummary, Calculate(Price, PriceRT, Cost) * Amt)
            SumReturn()
            'End If
        End If

        If e.Column.Name = ColPrice.Name Then
            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColRTPrice, Calculate(Price, PriceRT, Cost))
            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColSummary, Calculate(Price, PriceRT, Cost) * Amt)

            SumReturn()
        End If

        If e.Column.Name = ColRTValuePerc.Name Then
            If GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColRTValuePerc) > 100 Then
                Dim vMsg As String = "% มูลค่าคืนสินค้า ไม่สามารถเกิน 100"
                MessageBox.Show(vMsg, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColRTValuePerc, 0.0)
            ElseIf GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColRTValuePerc) = 0 Then
                GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColRTPrice, 0.0)
                GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColSummary, 0.0)
            Else
                GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColRTPrice, Calculate(Price, PriceRT, Cost))
                GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColSummary, Calculate(Price, PriceRT, Cost) * Amt)
            End If

            SumReturn()
        End If

        If e.Column.Name = ColRTPrice.Name Then
            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColSummary, Calculate(Price, PriceRT, 0) * Amt)
            SumReturn()
        End If

        If e.Column.Name = ColLotno.Name Then

            'If GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColidSale) = 0 Then
            '    mdCnOpen()
            '    Dim sDt As New DataTable
            '    If GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColdtType) = 1 Then ' สินค้าทั่วไป
            '        sCommand.CommandText = "Select idPdPk, idPdPkLot, ISNULL(DateGen, '') As DateGen, ISNULL(CostPerPiece, 0.00) As  CostPerPiece " & _
            '                               "From vPackingPdSetLot WHERE CompRec = " & sIdComp & " AND LotNum = '" & GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColLotno) & "'"
            '    ElseIf GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColdtType) = 2 Then 'สินค้าอื่นๆ
            '        sCommand.CommandText = "Select idPdO As idPdPk, idPdOLot As idPdPkLot, ISNULL(MFGDate, '') As DateGen, ISNULL(CostPerPiece, 0.00) As  CostPerPiece " & _
            '                               "From vSmPdOtherDLot WHERE CompRec = " & sIdComp & " AND LotNum = '" & GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColLotno) & "'"
            '    ElseIf GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColdtType) = 3 Then 'สินค้าวัตถุดิบ
            '        sCommand.CommandText = "Select idPd As idPdPk, idPdLot As idPdPkLot, ISNULL(DateRec, '') As DateGen, ISNULL(CostPerPiece, 0.00) As  CostPerPiece " & _
            '                              "From vPkPdLotStock WHERE CompRec = " & sIdComp & " AND LotNum = '" & GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColLotno) & "'"
            '    End If
            '    sAdapter.Fill(sDt)

            '    If sDt.Rows.Count <> 0 Then
            '        If sDt.Rows(0).Item("idPdPk") = GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColidPdPk) Then
            '            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColDateGen, ksbStringToDate(sDt.Rows(0).Item("DateGen")))
            '            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColidLot, sDt.Rows(0).Item("idPdPkLot"))
            '        End If

            '    End If
            'End If
        End If


        'If GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColidSale) = 0 Then
        '    SumReturn()
        'Else
        '    If Col.Name = "ColAmtRT" Then
        '        ' จำนวนคืน > จำนวนขายที่สามารถคืนได้
        '        If GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColAmtRT) > GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColBalanceRT) Then
        '            mdLoadCommitt()
        '            Dim vMsg As String = "จำนวนสินค้าที่คืนมากกว่าจำนวนสินค้าที่ขาย" & vbCrLf & _
        '                "** จำนวนสินค้าขายที่สามารถคืนได้ " & Format(GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColBalanceRT), "#,###.00") & " " & _
        '                GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColUnit) & " **"
        '            MessageBox.Show(vMsg, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColAmtRT, GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColBalanceRT))
        '            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColSummary, Calculate(Price, PriceRT, Cost) * GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColBalanceRT))
        '            SumReturn()
        '            Exit Sub
        '        Else
        '            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColSummary, Calculate(Price, PriceRT, Cost) * Amt)
        '            SumReturn()
        '        End If
        '    ElseIf Col.Name = "ColPriceBfDis" Then
        '        GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColPriceReturn, Calculate(Price, PriceRT, Cost))
        '        GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColSummary, Calculate(Price, PriceRT, Cost) * Amt)

        '    ElseIf Col.Name = "ColCostPd" Then
        '        If GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColCostPd) > 100 Then
        '            mdLoadCommitt()
        '            Dim vMsg As String = "% มูลค่าคืนสินค้า ไม่สามารถเกิน 100"
        '            MessageBox.Show(vMsg, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColCostPd, 0.0)
        '            SumReturn()
        '            Exit Sub
        '        ElseIf GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, ColCostPd) = 0 Then
        '            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColPriceReturn, 0.0)
        '            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColSummary, 0.0)
        '            SumReturn()
        '        Else
        '            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColPriceReturn, Calculate(Price, PriceRT, Cost))
        '            GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColSummary, Calculate(Price, PriceRT, Cost) * Amt)
        '            SumReturn()
        '        End If

        '    ElseIf Col.Name = "ColPriceReturn" Then
        '        GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, ColSummary, Calculate(Price, PriceRT, 0) * Amt)
        '        SumReturn()

        '    End If
        'End If

    End Sub


    'Private Sub GvReturn_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvReturn.CellValueChanging
    '    Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column

    '    Dim dr As DataRow = GvReturn.GetDataRow(GvReturn.FocusedRowHandle)
    '    If Col.Name = "ColLotno" Then
    '        dr("LotNo") = e.Value.ToString.ToUpper
    '        GvReturn.RefreshEditor(True)

    '    End If
    'End Sub

    Function Calculate(ByVal Price As Double, ByVal PriceRT As Double, ByVal CostPd As Double) As Double
        Dim Summary As Double = 0
        If CostPd > 0 Then
            Summary = ((CostPd / 100) * Price)
        Else
            Summary = PriceRT
        End If
        Return Summary
    End Function

    Private Sub GVNewPd_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVNewPd.CellValueChanged
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColAmount_n" Then
            SumNewPd()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If idRtAVxST <> 0 Then
            MessageBox.Show("ไม่สามารถแก้ไขรายการรับคืนนี้ได้ " & vbCrLf & " เนื่องจากเป็นรายการที่ถูกบันทึกด้วยระบบ AUTO BILL", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If



        If Me.txtDocRef.Text = "" Then
            MessageBox.Show("กรุณากรอกเลขที่อ้างอิง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtDocRef.Focus()
            Exit Sub
        ElseIf Me.lblPsReturn.Text = "" Then
            MessageBox.Show("กรุณาเลือกผู้รับคืนสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.btnPsReturn.Focus()
            Exit Sub
        ElseIf Me.GvReturn.RowCount = 0 Then
            MessageBox.Show("กรุณาเลือกรายการคืนสินค้าอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else

            For i As Integer = 0 To MainReturn.Rows.Count - 1
                If MainReturn.Rows(i).Item("AmountRT") = 0 Then
                    MessageBox.Show("กรุณาระบุจำนวนคืนให้ถูกต้อง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                ElseIf IsDBNull(MainReturn.Rows(i).Item("LotNo")) And cmbGroupComp.SelectedValue <> 12 Then
                    MessageBox.Show("กรุณาระบุ Lot No. ให้ครบทุกรายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                ElseIf MainReturn.Rows(i).Item("LotNo") = "" And cmbGroupComp.SelectedValue <> 12 Then
                    MessageBox.Show("กรุณาระบุ Lot No. ให้ครบทุกรายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Next

            For i As Integer = 0 To NewPdDt.Rows.Count - 1
                If NewPdDt.Rows(i).Item("Amount") = 0 Then
                    MessageBox.Show("กรุณาระบุจำนวนที่ต้องการให้ถูกต้อง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Next

            mdLoadShow()
            Using myconnection As New SqlConnection(conStr)
                myconnection.Open()
                Dim mycommand As New SqlCommand()
                Dim mytransaction As SqlTransaction
                Dim myAdapter = New SqlDataAdapter(mycommand)

                ' Start a local transaction
                mytransaction = myconnection.BeginTransaction()

                ' Must assign both transaction object and connection
                ' to Command object for a pending local transaction.
                mycommand.Connection = myconnection
                mycommand.Transaction = mytransaction
                Try
                    '--------------(1) Call Stored Procedure--------------------------
                    'If Process = eProcess.eNewReturn Then 'New
                    '    Dim idSaleReturn As Integer = 0

                    '    idSaleReturn = AddxEditSmSaleReturnMt_SP(mycommand, 0) 'New Insert idSaleReturn = 0


                    '    If GvReturn.RowCount > 0 Then 'มีรายการคืนสินค้า
                    '        '----ADD Data to SmSaleReturnDt-----'
                    '        For i As Integer = 0 To GvReturn.DataRowCount - 1
                    '            Dim dr As DataRow = GvReturn.GetDataRow(i)
                    '            AddSmSaleReturnDt_SP(mycommand, idSaleReturn, dr)
                    '        Next
                    '    End If

                    '    If GVNewPd.RowCount > 0 Then 'มีรายการเลือกสินค้าใหม่ทดแทน
                    '        '----ADD Data to SmSaleReturnJUDt-----'
                    '        For i As Integer = 0 To GVNewPd.DataRowCount - 1
                    '            Dim dr As DataRow = GVNewPd.GetDataRow(i)
                    '            AddxEditSmSaleReturnJUDt_SP(mycommand, idSaleReturn, dr)
                    '        Next
                    '    End If


                    '    mycommand.CommandText = "EXECUTE WaitRecieveTs '2','SmSaleReturnMt','SmSaleReturnDt','idSaleReturn'," & idSaleReturn & "," & _
                    '                        cmbGroupComp.SelectedValue & " ," & sPsId & " ,'1'"

                    '    mycommand.ExecuteNonQuery()


                    'Else ' edit / ManageReject
                    '    If Process = eProcess.eManageReject Then ' ManageReject
                    '        mycommand.CommandText = "Update SmSaleReturnMt Set idPsAccept = NULL, DateAccept = NULL, idPsCheck = NULL, " & _
                    '                                "DateCheck = NULL, stApp = NULL, idPsApprove = NULL, DateApprove = NULL, RejectNote = NULL " & _
                    '                                "WHERE idSaleReturn = " & idSaleReturn_
                    '        mycommand.ExecuteNonQuery()
                    '    End If

                    '    Dim idSaleReturn As Integer = 0
                    '    idSaleReturn = AddxEditSmSaleReturnMt_SP(mycommand, idSaleReturn_) 'Nre Insert idSaleReturn = 0

                    '    ' Edit SmSaleReturnDt
                    '    For i As Integer = 0 To GvReturn.DataRowCount - 1
                    '        Dim dr As DataRow = GvReturn.GetDataRow(i)
                    '        EditSmSaleReturnDt_SP(mycommand, idSaleReturn, dr)
                    '    Next

                    '    ' Edit SmSaleReturnJUDt
                    '    For i As Integer = 0 To GVNewPd.DataRowCount - 1
                    '        Dim dr As DataRow = GVNewPd.GetDataRow(i)
                    '        AddxEditSmSaleReturnJUDt_SP(mycommand, idSaleReturn, dr)
                    '    Next


                    '    mycommand.CommandText = "SELECT ISNULL([devsk].[WimCheckstUseRecieveWait] (" & idSaleReturn & " , 2) ,0) As stRec"
                    '    Dim stRec As Integer = mycommand.ExecuteScalar

                    '    If stRec = 1 Then
                    '        MessageBox.Show("รายการนี้ถูกรับของเข้าคลังแล้ว ไม่สามารถแก้ไขได้", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    '        Exit Sub
                    '    Else
                    '        mycommand.CommandText = "EXECUTE WaitRecieveTsEdit '2','SmSaleReturnMt','SmSaleReturnDt','idSaleReturn'," & idSaleReturn & "," & _
                    '                                cmbGroupComp.SelectedValue & " ," & sPsId & " ,'2'"

                    '        mycommand.ExecuteNonQuery()
                    '    End If


                    'End If

                    '-------------------------(1) END----------------------------------

                    '---------------- *[1]* Old Call Stock--------------------
                    If Process = eProcess.eNewReturn Then 'New

                        Dim idSaleReturn As Integer = 0

                        Dim idComp = cmbGroupComp.SelectedValue

                        If idComp = 10 Then
                            idComp = 4
                        End If

                        If cmbGroupComp.SelectedValue = 10 Then

                            idSaleReturn = fnRTBtwSTxAV(mycommand)
                        Else

                            idSaleReturn = AddSmSaleReturnMt(mycommand)

                            If GvReturn.RowCount > 0 Then 'มีรายการคืนสินค้า
                                '----ADD Data to SmSaleReturnDt-----'
                                For i As Integer = 0 To GvReturn.DataRowCount - 1
                                    Dim dr As DataRow = GvReturn.GetDataRow(i)
                                    AddSmSaleReturnDt(idSaleReturn, dr, mycommand, i + 1, idComp)
                                Next
                            End If

                            If GVNewPd.RowCount > 0 Then 'มีรายการเลือกสินค้าใหม่ทดแทน
                                '----ADD Data to SmSaleReturnJUDt-----'
                                For i As Integer = 0 To GVNewPd.DataRowCount - 1
                                    Dim dr As DataRow = GVNewPd.GetDataRow(i)
                                    AddSmSaleReturnJUDt(idSaleReturn, dr, mycommand)
                                Next
                            End If
                        End If




                    Else ' edit / ManageReject
                        If Process = eProcess.eManageReject Then ' ManageReject
                            mycommand.CommandText = "Update SmSaleReturnMt Set idPsAccept = NULL, DateAccept = NULL, idPsCheck = NULL, " & _
                                                    "DateCheck = NULL, stApp = NULL, idPsApprove = NULL, DateApprove = NULL, RejectNote = NULL " & _
                                                    "WHERE idSaleReturn = " & idSaleReturn_
                            mycommand.ExecuteNonQuery()
                        End If

                        EditSmSaleReturn(mycommand)
                        EditSmSaleReturnJUDt(mycommand)

                        Dim dtidReturnAV As New DataTable
                        mycommand.CommandText = "SELECT idSaleReturn As idSaleReturnAV FROM SmSaleReturnMt WHERE idRtAVxST = " & idSaleReturn_
                        myAdapter.Fill(dtidReturnAV)

                        If dtidReturnAV.Rows.Count > 0 Then
                            EditRtAVxStar(mycommand, dtidReturnAV.Rows(0).Item("idSaleReturnAV"))
                            EditJUDtAVxST(mycommand, dtidReturnAV.Rows(0).Item("idSaleReturnAV"))
                        End If


                    End If
                    '-----------------------END *[1]*---------------------------'



                    ' Attempt to commit the transaction.
                    mytransaction.Commit()
                    mdLoadCommitt()
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()

                Catch ex As Exception
                    ' Attempt to roll back the transaction.
                    Try
                        mytransaction.Rollback()
                        mdLoadCommitt()
                        'MessageBox.Show("Commit Exception Type: ระบบเกิดข้อผิดพลาด ไม่สามารถบันทึกรายการได้", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                        MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
                                            sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                        Exit Sub
                    Catch e2x As Exception
                        mdLoadCommitt()
                        MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
                                             sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                        Exit Sub
                    End Try
                Finally
                    myconnection.Close()
                End Try
            End Using
        End If
    End Sub

    Private Sub EditRtAVxStar(ByVal mycommand As SqlCommand, ByVal idReturnAV As Integer) 'Edit

        Dim SumTotal As Double = 0.0
        Dim myAdapter As New SqlDataAdapter(mycommand)

        '--Update SmSaleMt (Auto Bill)
        'mycommand.CommandText = "UPDATE SET " & CDbl(txtTotalNet.Text)
        'Case 1: insert New Row/Lot
        Dim dtRtDtCaseAdd As New DataTable

        mycommand.CommandText = "SELECT idSale, idSaleDt, (SELECT idSaleReturn FROM SmSaleReturnMt Where idRtAVxST = " & idSaleReturn_ & ") As idReturnAV , idLot," & vbNewLine & _
                                "AmountReturn As AmountRT, Price, RTValuePerc, RTPrice, idUnit, idWh, LotNoRT As LotNo, idInvMain" & vbNewLine & _
                                "FROM SmSaleReturnDt" & vbNewLine & _
                                "Where idSaleReturn = " & idSaleReturn_ & vbNewLine & _
                                "AND idLot Not IN ( SELECT idLot FROM SmSaleReturnDt WHERE idSaleReturn = " & idReturnAV & ")"

        myAdapter.Fill(dtRtDtCaseAdd)

        If dtRtDtCaseAdd.Rows.Count > 0 Then
            For i As Integer = 0 To dtRtDtCaseAdd.Rows.Count - 1
                Dim dr As DataRow = dtRtDtCaseAdd.Rows(i)
                AddSmSaleReturnDtNoAddStock(mycommand, dr.Item("idReturnAV"), dr, i + 1)
            Next
        End If

        'Case 2: Delete Row/Lot 
        Dim dtRtDtCaseDel As New DataTable

        mycommand.CommandText = "SELECT idSaleReturnDt, idSale, idSaleDt, (SELECT idSaleReturn FROM SmSaleReturnMt Where idRtAVxST = " & idSaleReturn_ & ") As idReturnAV , idLot," & vbNewLine & _
                                  "AmountReturn, Price, RTValuePerc, RTPrice, idUnit, idWh, LotNoRT, idInvMain" & vbNewLine & _
                                  "FROM SmSaleReturnDt" & vbNewLine & _
                                  "Where idSaleReturn = " & idReturnAV & vbNewLine & _
                                   "AND idLot Not IN ( SELECT idLot FROM SmSaleReturnDt WHERE idSaleReturn = " & idSaleReturn_ & ")"

        myAdapter.Fill(dtRtDtCaseDel)

        If dtRtDtCaseDel.Rows.Count > 0 Then
            For i As Integer = 0 To dtRtDtCaseDel.Rows.Count - 1
                Dim dr As DataRow = dtRtDtCaseDel.Rows(i)

                mycommand.CommandText = "DELETE SmSaleReturnDt " & vbNewLine & _
                                        "FROM SmSaleReturnDt " & vbNewLine & _
                                        "WHERE idSaleReturnDt = " & dr.Item("idSaleReturnDt")

                mycommand.ExecuteNonQuery()
            Next
        End If

        Dim dtSlDtCaseUpdate As New DataTable
        'Case 3: Update Data
        For i As Integer = 0 To GvReturn.DataRowCount - 1

            Dim dr As DataRow = GvReturn.GetDataRow(i)

            dtSlDtCaseUpdate.Clear()

            mycommand.CommandText = "SELECT idSaleReturnDt" & vbNewLine & _
                                    "FROM SmSaleReturnDt" & vbNewLine & _
                                    "WHERE idSaleReturn =  " & idReturnAV & " AND idLot = " & dr.Item("idLot")

            myAdapter.Fill(dtSlDtCaseUpdate)

            If dtSlDtCaseUpdate.Rows.Count > 0 Then


                'Case 3: Edit Data On Old Row
                mycommand.CommandText = "UPDATE SmSaleReturnDt SET " & vbNewLine & _
                                        "idLot = " & dr.Item("idLot") & " , " & vbNewLine & _
                                        "idInvMain = " & dr.Item("idInvMain") & "," & vbNewLine & _
                                        "LotNoRT = '" & dr.Item("LotNo") & "'," & vbNewLine &
                                        "idWh = " & dr.Item("idWh") & " , " & vbNewLine & _
                                        "idUnit = " & dr.Item("idUnit") & " , " & vbNewLine &
                                        "RTPrice = " & CDbl(dr.Item("RTPrice")) & " , " & vbNewLine &
                                        "RTValuePerc = " & dr.Item("RTValuePerc") & " , " & vbNewLine &
                                        "Price = " & CDbl(dr.Item("Price")) & " , " & vbNewLine &
                                         "AmountReturn = " & CDbl(dr.Item("AmountRT")) & " , " & vbNewLine &
                                        "No = " & i + 1 & vbNewLine &
                                        "WHERE idSaleReturnDt =  " & dtSlDtCaseUpdate.Rows(0).Item("idSaleReturnDt")
                mycommand.ExecuteNonQuery()
            End If

            SumTotal = SumTotal + dr.Item("Exp")
        Next


        '---- Update SumService in SmSaleMt ----'
        mycommand.CommandText = "Update SmSaleReturnMt Set Total = " & SumTotal & vbNewLine & _
                                "WHERE idSaleReturn = " & idReturnAV
        mycommand.ExecuteNonQuery()

    End Sub

    Private Function fnRTBtwSTxAV(ByVal mycommand As SqlCommand) As Integer
        Dim myAdapter As New SqlDataAdapter(mycommand)

        '--Auto Gen Bill Return Between ST to AV (idComp = 4)
        Dim getDate As String = CType(Date.Today, String)
        Dim YAndM As String = Microsoft.VisualBasic.Left(ksbDateToString(Date.Today), 6)
        Dim YAndM_Cut As String = Microsoft.VisualBasic.Right(YAndM, 4)

        Dim sDocRef As String = YAndM_Cut

        Dim nextOrder As String = ""

        Dim sDt As New DataTable
        mycommand.CommandText = "SELECT MAX(DocRef) as max_DocRef FROM SmSaleReturnMt " & _
                               "WHERE SUBSTRING(DocRef,1,7) = '" & sDocRef & "' AND idComp = 4 AND idPartner = 2851"
        myAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocRef")) = True Then
            sDocRef = YAndM_Cut & "0001"
        Else
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocRef"), 4)
            Dim temp As Integer
            temp = CInt(RunningCode) + 1
            If temp < 10 Then
                nextOrder = "000" & CStr(temp)
            ElseIf temp < 100 Then
                nextOrder = "00" & CStr(temp)
            ElseIf temp < 1000 Then
                nextOrder = "0" & CStr(temp)
            Else
                nextOrder = CStr(temp)
            End If

            sDocRef = YAndM_Cut & nextOrder

        End If


        Dim idRtAV = ADDxEditSmSaleReturnMt(mycommand, 0, 4, 2851, 2873, 0, 0, 0, sDocRef)


        If GvReturn.DataRowCount > 0 Then 'มีรายการคืนสินค้า'----ADD Data to SmSaleReturnDt-----'
            For i As Integer = 0 To GvReturn.DataRowCount - 1
                Dim dr As DataRow = GvReturn.GetDataRow(i)
                AddSmSaleReturnDtNoAddStock(mycommand, idRtAV, dr, i + 1)
            Next
        End If

        If GVNewPd.RowCount > 0 Then 'มีรายการเลือกสินค้าใหม่ทดแทน
            '----ADD Data to SmSaleReturnJUDt-----'
            For i As Integer = 0 To GVNewPd.DataRowCount - 1
                Dim dr As DataRow = GVNewPd.GetDataRow(i)
                AddSmSaleReturnJUDt(idRtAV, dr, mycommand)
            Next
        End If


        Dim idRtSt As Integer = 0

        idRtSt = ADDxEditSmSaleReturnMt(mycommand, 0, cmbGroupComp.SelectedValue, idPartner, idCus, idFm, lblPsReturn.Tag, lblPsSale.Tag, Trim(txtDocRef.Text))

        mycommand.CommandText = "UPDATE SmSaleReturnMt SET idRTAVxST = " & idRtSt & "Where idSaleReturn = " & idRtAV
        mycommand.ExecuteNonQuery()

        If GvReturn.DataRowCount > 0 Then 'มีรายการคืนสินค้า'----ADD Data to SmSaleReturnDt-----'
            For i As Integer = 0 To GvReturn.DataRowCount - 1
                Dim dr As DataRow = GvReturn.GetDataRow(i)
                AddSmSaleReturnDt(idRtSt, dr, mycommand, i + 1, 4)
            Next
        End If

        If GVNewPd.RowCount > 0 Then 'มีรายการเลือกสินค้าใหม่ทดแทน
            '----ADD Data to SmSaleReturnJUDt-----'
            For i As Integer = 0 To GVNewPd.DataRowCount - 1
                Dim dr As DataRow = GVNewPd.GetDataRow(i)
                AddSmSaleReturnJUDt(idRtSt, dr, mycommand)
            Next
        End If

        Return idRtSt
    End Function



    Private Sub EditSmSaleReturn(ByVal xCommand As SqlCommand)

        Dim xAdapter = New SqlDataAdapter(xCommand)
        '----Update SmSaleReturnMt-------------------------------------------------
        Dim getDate As String = CType(Date.Today, String)
        Dim dtpReturnCvt As DateTime = Convert.ToDateTime(dtpReturn.Value, _cultureEnInfo)
        Dim YearRT As Integer = Microsoft.VisualBasic.Right(getDate, 4)
        Dim MonthRT As Integer = CType(Date.Today.Month, Integer)
        Dim stridCus As String = ""

        If idFM = 0 Then
            stridCus = "idCus = " & idCus & ", idFm = NULL, idPartner = " & idPartner

        ElseIf idCus = 0 Then

            stridCus = "idCus = NULL, idFm = " & idFM & ", idPartner = " & idPartner
        End If


        xCommand.CommandText = "Update SmSaleReturnMt Set DocNum = '" & Trim(Me.lblDocNum.Text) & "', YearRT = " & YearRT & ", MonthRT = " & MonthRT & ", " &
                               "DateReturnD = '" & dtpReturnCvt.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "'," &
                               "idRTDocCode = " & Me.cmbDRCode.SelectedValue & ", DocRef = '" & Trim(txtDocRef.Text) & "', " &
                               stridCus & ", idRtCause = " & Me.cmbCauseReturn.SelectedValue & ", " &
                               "idPsSale = " & lblPsSale.Tag & ", Total = " & CDbl(txtCntSumReturn.Text) & ", idPsReturn = " & lblPsReturn.Tag & ", " &
                               "idPsTs = " & sPsId & ", DateTsD = GETDATE(), " &
                               "Note = '" & Trim(Me.txtNote.Text) & "', idComp = " & cmbGroupComp.SelectedValue & " WHERE idSaleReturn = " & idSaleReturn_
        xCommand.ExecuteNonQuery()


        '-------------------------------------------------------------------------
        'Case 2: Row Delete
        If dtDel.Rows.Count > 0 Then
            For j As Integer = 0 To dtDel.Rows.Count - 1
                Dim drDel As DataRow = dtDel.Rows(j)

                'xCommand.CommandText = "UPDATE dInvLotRefWh SET AmountRec = ISNULL(AmountRec,0) - " & CDbl(drDel.Item("AmountRT")) & vbNewLine & _
                '                                        "WHERE idLot =  " & drDel.Item("idLot") & " AND idWh = " & drDel.Item("idWh")
                'xCommand.ExecuteNonQuery()

                '----คืนสต๊อก เมื่อมีการลบ Row 
                If drDel.Item("idInvMain") <> 9766 Then
                    InvLotMainUpdate(2, drDel.Item("idInvMain"), drDel.Item("idLot"), CDbl(drDel.Item("AmountRT")),
                                "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", drDel.Item("LotNo"), drDel.Item("idWh"), xCommand)
                End If

                xCommand.CommandText = "DELETE FROM SmSaleReturnDt WHERE idSaleReturnDt = " & drDel.Item("idSaleReturnDt")
                xCommand.ExecuteNonQuery()

                'drDel.Delete()
                'dtDel.AcceptChanges()

            Next

            dtDel.AcceptChanges()

        End If

        '-------Update SmSaleReturnDt---------------------------------------------
        For i As Integer = 0 To MainReturn.Rows.Count - 1

            Dim dr As DataRow = MainReturn.Rows(i)

            'Case 1: insert New Row
            If IsDBNull(dr.Item("idSaleReturnDt")) Then

                Dim idComp As Integer = cmbGroupComp.SelectedValue

                If idComp = 10 Then
                    idComp = 4
                End If

                AddSmSaleReturnDt(idSaleReturn_, dr, xCommand, i + 1, idComp)
            End If

            'Case 3: Row Update

            '3.1 Check Stockcard used (Check on value amount column change)
            If Not IsDBNull(dr.Item("idSaleReturnDt")) Then
                '----Some column Change
                If dr.Item("LotNo") = dr.Item("LotNoHide") Or dr.Item("idWh") = dr.Item("idWhHide") Or dr.Item("Price") = dr.Item("PriceHide") _
                    Or dr.Item("RTValuePerc") = dr.Item("RTValuePercHide") Or dr.Item("RTPrice") = dr.Item("RTPriceHide") Or dr.Item("AmountRT") = dr.Item("AmountRTHide") Then

                    xCommand.CommandText = "UPDATE SmSaleReturnDt SET AmountReturn = " & dr.Item("AmountRT") & " , " & vbNewLine &
                                           "LotNoRT = '" & dr.Item("LotNo") & "' , " & vbNewLine &
                                           "idWh = " & dr.Item("idWh") & " , " & vbNewLine &
                                           "Price = " & dr.Item("Price") & " , " & vbNewLine &
                                           "RTValuePerc = " & dr.Item("RTValuePerc") & " , " & vbNewLine &
                                           "RTPrice = " & dr.Item("RTPrice") & vbNewLine &
                                           "WHERE idSaleReturnDt =  " & dr.Item("idSaleReturnDt")
                    xCommand.ExecuteNonQuery()


                    If dr.Item("AmountRT") <> dr.Item("AmountRTHide") And dr.Item("idWh") = dr.Item("idWhHide") Then

                        If Process = eProcess.eEdit Then

                            'คืนตัวเดิมลง Stock
                            InvLotMainUpdate(2, MainReturn.Rows(i).Item("idInvMain"), MainReturn.Rows(i).Item("idLot"), CDbl(MainReturn.Rows(i).Item("AmountRTHide")), _
                                           "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", MainReturn.Rows(i).Item("LotNo"), MainReturn.Rows(i).Item("idWh"), xCommand)

                            'เพิ่มเข้า Stock ใหม่
                            InvLotMainUpdate(1, MainReturn.Rows(i).Item("idInvMain"), MainReturn.Rows(i).Item("idLot"), CDbl(MainReturn.Rows(i).Item("AmountRT")), _
                                          "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", MainReturn.Rows(i).Item("LotNo"), MainReturn.Rows(i).Item("idWh"), xCommand)
                        End If

                    ElseIf dr.Item("idWh") <> dr.Item("idWhHide") Then

                        'ตัด AmountRec ออกจากรับคืน idWh นั้น
                        'xCommand.CommandText = "UPDATE dInvLotRefWh SET AmountRec = ISNULL(AmountRec,0) - " & CDbl(MainReturn.Rows(i).Item("AmountRTHide")) & vbNewLine & _
                        '                                "WHERE idLot =  " & MainReturn.Rows(i).Item("idLot") & " AND idWh = " & MainReturn.Rows(i).Item("idWhHide")
                        'xCommand.ExecuteNonQuery()


                        'คืนตัวเดิมลง Stock 
                        InvLotMainUpdate(2, MainReturn.Rows(i).Item("idInvMain"), MainReturn.Rows(i).Item("idLot"), CDbl(MainReturn.Rows(i).Item("AmountRTHide")), _
                                            "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", MainReturn.Rows(i).Item("LotNo"), _
                                           MainReturn.Rows(i).Item("idWhHide"), xCommand)

                        '-- Check lot ว่า มีอยู่แล้วในคลังที่เลือกไหม --'
                        Dim LotWh As New DataTable
                        LotWh.Clear()
                        xCommand.CommandText = "SELECT * FROM dInvLotRefWh WHERE idLot = " & MainReturn.Rows(i).Item("idLot") & vbNewLine & _
                                                " AND idWh = " & MainReturn.Rows(i).Item("idWh")
                        xAdapter.Fill(LotWh)

                        'Update idLotMain in SmSaleReturnMt
                        xCommand.CommandText = "UPDATE SmSaleReturnDt SET idLot = " & MainReturn.Rows(i).Item("idLot") & " WHERE idSaleReturnDt = " & dr.Item("idSaleReturnDt")
                        xCommand.ExecuteNonQuery()

                        If LotWh.Rows.Count > 0 Then
                            'แสดงว่ามี Lot นั้นยังอยู่ในคลัง ให้บวก Amount เพิ่มเข้าไปใน Lot
                            '--Case 2: Has idLot--
                            '----2.1 Return Same Warehouse-----
                            'เพิ่ม AmountRec ใน idWh เดิม
                            'xCommand.CommandText = "UPDATE dInvLotRefWh SET AmountRec = ISNULL(AmountRec,0) + " & CDbl(MainReturn.Rows(i).Item("AmountRT")) & vbNewLine & _
                            '                       "WHERE idLot =  " & MainReturn.Rows(i).Item("idLot") & " AND idWh = " & MainReturn.Rows(i).Item("idWh")
                            'xCommand.ExecuteNonQuery()

                            'Call InvLotMainUpdate for add Amount before call stockcard
                            InvLotMainUpdate(1, MainReturn.Rows(i).Item("idInvMain"), MainReturn.Rows(i).Item("idLot"), CDbl(MainReturn.Rows(i).Item("AmountRT")), _
                                             "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", MainReturn.Rows(i).Item("LotNo"), MainReturn.Rows(i).Item("idWh"), xCommand)

                        Else
                            '----2.2 Return Other Warehouse----
                            ' Sum Amount ก่อน Insert ตัวใหม่เข้าไป
                            Dim sDt As New DataTable
                            xCommand.CommandText = "SELECT Sum(Amount) As Amount FROM dInvLotRefWh WHERE idLot = " & MainReturn.Rows(i).Item("idLot")
                            xAdapter.Fill(sDt)

                            Dim AmountLot As Double
                            If sDt.Rows.Count = 0 Then
                                AmountLot = 0
                            Else
                                AmountLot = sDt.Rows(0).Item("Amount")
                            End If

                            '----2.2 Return Other Warehouse----
                            'Insert old idLot that has new idWh
                            xCommand.CommandText = "INSERT INTO dInvLotRefWh(idLot, idWh, AmountRec, Amount, idUnit, CostDt) Values(" & MainReturn.Rows(i).Item("idLot") & _
                                                    ", " & MainReturn.Rows(i).Item("idWh") & "," & CDbl(MainReturn.Rows(i).Item("AmountRT")) & "," & _
                                                    CDbl(MainReturn.Rows(i).Item("AmountRT")) & "," & MainReturn.Rows(i).Item("idUnit") & ",0.00)"

                            xCommand.ExecuteScalar()

                            InvLotStockCard(1, MainReturn.Rows(i).Item("idInvMain"), MainReturn.Rows(i).Item("idLot"), CDbl(MainReturn.Rows(i).Item("AmountRT")), _
                                            CDbl(AmountLot), "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", MainReturn.Rows(i).Item("LotNo"), _
                                            MainReturn.Rows(i).Item("idWh"), xCommand)
                        End If

                    End If
                End If
            End If

        Next
        '-------------------------------------------------------------------------
    End Sub

    '-------------------- GEN DocNum --------------------'
    Function getDocNum(ByVal Prefixcode As String, ByVal vCommand As SqlCommand) As String
        Dim vAdapter = New SqlDataAdapter(vCommand)
        Dim DocNum As String = ""
        Dim nextOrder As String = ""
        'Dim CodeYear As String = ""

        ' mdCnOpen()
        Dim sDt As New DataTable
        sDt.Clear()
        vCommand.CommandText = "SELECT MAX(DocNum) as max_DocNum FROM SmSaleReturnMt"
        vAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocNum")) = True Then
            DocNum = "SR" & Prefixcode & "/" & "00001"
        Else
            Dim max_DocCode As String = sDt.Rows(0).Item("max_DocNum")
            ' Dim yearDoc As String = Microsoft.VisualBasic.Left(sDt.Rows(0).Item("max_DocNum"), 2)
            Dim yearDoc As String = sDt.Rows(0).Item("max_DocNum").ToString.Substring(2, 2)
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocNum"), 5)

            If Prefixcode <> yearDoc Then
                DocNum = "SR" & Prefixcode & "/" & "00001"
            Else
                Dim temp As Integer
                temp = CInt(RunningCode) + 1
                If temp < 10 Then
                    nextOrder = "0000" & CStr(temp)
                ElseIf temp < 100 Then
                    nextOrder = "000" & CStr(temp)
                ElseIf temp < 1000 Then
                    nextOrder = "00" & CStr(temp)
                ElseIf temp < 10000 Then
                    nextOrder = "0" & CStr(temp)
                Else
                    nextOrder = CStr(temp)
                End If
                DocNum = "SR" & Prefixcode & "/" & nextOrder
            End If
        End If
        Return DocNum
    End Function

    Function AddSmSaleReturnMt(ByVal vCommand As SqlCommand) As Integer

        Dim idSaleReturn As Integer = 0
        Dim Prefixcode As String = ""
        Dim getDate As String = CType(Date.Today, String)
        Dim DocNum As String = ""
        Dim YearRT As Integer = Microsoft.VisualBasic.Right(getDate, 4)
        Dim MonthRT As Integer = CType(Date.Today.Month, Integer)
        Dim dtpReturnCvt As DateTime = Convert.ToDateTime(dtpReturn.Value, _cultureEnInfo)
        Prefixcode = (Microsoft.VisualBasic.Right(getDate, 2))
        DocNum = getDocNum(Prefixcode, vCommand)

        Dim stridCus As String = ""
        Dim qidCus As String = ""

        If idFM = 0 Then
            stridCus = "idCus"

        ElseIf lblPsCus.Tag = 0 Then
            stridCus = "idFm"
            lblPsCus.Tag = idFM
        End If

        If idFM = 0 And lblPsCus.Tag <> 0 Then
            'Case เป็น Customer อย่างเดียว
            stridCus = "idCus"
            qidCus = lblPsCus.Tag
        ElseIf lblPsCus.Tag = 0 And idFM <> 0 Then
            'Case เป็น Farmer อย่างเดียว
            stridCus = "idFm"
            qidCus = idFM

        ElseIf lblPsCus.Tag <> 0 And idFM <> 0 Then
            'Case เป็นทั้ง Customer และ Farmer 
            stridCus = "idCus, idFm"
            qidCus = lblPsCus.Tag & "," & idFM
        End If



        Dim query As String = "Insert Into SmSaleReturnMt(DocNum, YearRT, MonthRT, DateReturnD, idRTDocCode, DocRef, " & stridCus & ", " &
                               "idRtCause, idPsSale, Total, idPsReturn, idPsTs, DateTsD, Note, idComp, idPartner, DateReturnSys) " &
                               "Values('" & DocNum & "', " & YearRT & ", " & MonthRT & ", " &
                               "'" & dtpReturnCvt.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "'," & Me.cmbDRCode.SelectedValue & ", " &
                               "'" & Trim(txtDocRef.Text) & "', " & qidCus & ", " & Me.cmbCauseReturn.SelectedValue & ", " &
                               "" & lblPsSale.Tag & ", " & CDbl(Me.txtCntSumReturn.Text) & ", " & lblPsReturn.Tag & ", " &
                               "" & sPsId & ", GETDATE(), '" & Trim(Me.txtNote.Text) & "', " & cmbGroupComp.SelectedValue & "," & idPartner & ", GETDATE())"
        vCommand.ExecuteNonQuery()

        vCommand.CommandText = query

        Dim query2 As String = "Select @@Identity"
        vCommand.ExecuteNonQuery()
        vCommand.CommandText = query2
        idSaleReturn = vCommand.ExecuteScalar()

        Return idSaleReturn
    End Function

    Private Sub AddSmSaleReturnDt(ByVal idSaleReturn As Integer, ByVal dr As DataRow, ByVal vCommand As SqlCommand, ByVal i As Integer, ByVal idComp As Integer)

        Dim vAdapter = New SqlDataAdapter(vCommand)

        Dim idSaleReturnDt As Integer = 0
        Dim idlotxInv As Integer = 0

        If IsDBNull(dr.Item("idSale")) Then
            dr.Item("idSale") = 0
        End If

        If IsDBNull(dr.Item("idSaleDt")) Then
            dr.Item("idSaleDt") = 0
        End If

        If IsDBNull(dr.Item("idLot")) Then
            dr.Item("idLot") = 0
        End If

        If dr.Item("idLot") = 0 Then

            Dim dtLot As New DataTable
            vCommand.CommandText = "Select idLot FROM dInvLotMain WHERE LotNo = '" & dr.Item("LotNo") & "' AND idinvMain = " & dr.Item("idInvMain") & " AND CompRec = " & cmbGroupComp.SelectedValue & " AND stDel Is NULL"
            vAdapter.Fill(dtLot)

            If dtLot.Rows.Count > 0 Then
                dr.Item("idLot") = dtLot.Rows(0).Item("idLot")
            End If
        End If


        Dim strDt As String = "Insert Into SmSaleReturnDt(No, idSaleReturn, idSale, idSaleDt, idLotSale, AmountReturn, AmtRTBal," &
                                  "Price, RTValuePerc, RTPrice, idUnit, idWh, LotNoRT, idInvMain) " &
                                  "Values(" & i & "," & idSaleReturn & ", " & dr.Item("idSale") & ", " &
                                  "" & dr.Item("idSaleDt") & ", " &
                                  "" & dr.Item("idLot") & ", " &
                                  "" & CDbl(dr.Item("AmountRT")) & ", " & CDbl(dr.Item("AmountRT")) & ", " &
                                  "" & CDbl(dr.Item("Price")) & ", " & CDbl(dr.Item("RTValuePerc")) & ", " &
                                  "" & CDbl(dr.Item("RTPrice")) & ", " & dr.Item("idUnit") & ", " &
                                  "" & dr.Item("idWh") & ", '" & dr.Item("LotNo") & "'," &
                                  "" & dr.Item("idInvMain") & ")"
        vCommand.CommandText = strDt

        Dim query4 As String = "Select @@Identity"
        vCommand.ExecuteNonQuery()
        vCommand.CommandText = query4
        idSaleReturnDt = vCommand.ExecuteScalar()

        '--------------- IN New Structure --------------
        'No idLot In Old Structure
        If dr.Item("idInvMain") <> 9766 Then

            If dr.Item("idLot") = 0 Then
                Dim strFl As String = ""
                Dim strQFl As String = ""

                If dr.Item("idInvGroup") = 2 Then
                    Dim idFL As Integer = fnFindFormula(vCommand, dr.Item("LotNo"), dr.Item("idInvMain"), cmbGroupComp.SelectedValue)

                    If idFL <> 0 Then
                        strFl = ", idFl"
                        strQFl = "," & idFL
                    End If

                End If

                '------New Structure------'
                '------Insert New idLot in dInvLotMain When No idPdPkLot
                Dim str As String = "INSERT INTO dInvLotmain (idInvMain, LotNo, DateGen, CompRec, idPsUpDate, DateUpDate, Cost, CostPerUnit " & strFl & ")" &
                                    " VALUES (" & dr.Item("idInvMain") & ",'" & dr.Item("LotNo") & "', GETDATE(), " &
                                    "" & idComp & ", " & sPsId & ", GETDATE(), " & dr.Item("Exp") & "," & dr.Item("RTPrice") & strQFl & ")"
                vCommand.CommandText = str

                Dim query As String = "Select @@Identity"
                vCommand.ExecuteNonQuery()
                vCommand.CommandText = query
                idlotxInv = vCommand.ExecuteScalar()

                '------Insert Amount return and Warehouse in dInvLotRefWh
                vCommand.CommandText = "INSERT INTO dInvLotRefWh(idLot, idWh, AmountRec, Amount, idUnit, CostDt) Values(" & idlotxInv & ", " & dr.Item("idWh") &
                                    "," & CDbl(dr.Item("AmountRT")) & "," & CDbl(dr.Item("AmountRT")) & "," & dr.Item("idUnit") & ",0.00)"
                vCommand.ExecuteNonQuery()

                '------Stockcard-Inventory
                InvLotStockCard(1, dr.Item("idInvMain"), idlotxInv, CDbl(dr.Item("AmountRT")), CDbl(0), "เมนู" & Me.Text, idSaleReturn,
                                "SAM", "SmSaleReturnMt", dr.Item("LotNo"), dr.Item("idWh"), vCommand)

                'Update idLot IN SmSaleReturnDt
                vCommand.CommandText = "UPDATE SmSaleReturnDt SET idLot = " & idlotxInv & " WHERE idSaleReturnDt = " & idSaleReturnDt
                vCommand.ExecuteNonQuery()

            Else
                'Has idPdPkLot
                If dr.Item("idLot") <> 0 Then
                    '-- Check lot ว่า มีอยู่แล้วในคลังที่เลือกไหม --'
                    Dim LotWh As New DataTable
                    LotWh.Clear()
                    vCommand.CommandText = "SELECT * FROM dInvLotRefWh WHERE idLot = " & dr.Item("idLot") & vbNewLine &
                                            " AND idWh = " & dr.Item("idWh")
                    vAdapter.Fill(LotWh)

                    'Update idLotMain in SmSaleReturnMt
                    vCommand.CommandText = "UPDATE SmSaleReturnDt SET idLot = " & dr.Item("idLot") & " WHERE idSaleReturnDt = " & idSaleReturnDt
                    vCommand.ExecuteNonQuery()

                    If LotWh.Rows.Count > 0 Then
                        'แสดงว่ามี Lot นั้นยังอยู่ในคลัง ให้บวก Amount เพิ่มเข้าไปใน Lot
                        '--Case 2: Has idLot--
                        '----2.1 Return Same Warehouse-----
                        'บวกเพิ่ม AmountRec ของ Lot เดิม คลังเดิม
                        vCommand.CommandText = "UPDATE dInvLotRefWh SET AmountRec = ISNULL(AmountRec,0) + " & CDbl(dr.Item("AmountRT")) & vbNewLine &
                                 "WHERE idLot =  " & dr.Item("idLot") & " AND idWh = " & dr.Item("idWh")
                        vCommand.ExecuteNonQuery()


                        'Call InvLotMainUpdate for add Amount before call stockcard
                        InvLotMainUpdate(1, dr.Item("idInvMain"), dr.Item("idLot"), CDbl(dr.Item("AmountRT")), "เมนู" & Me.Text, idSaleReturn,
                                    "SAM", "SmSaleReturnMt", dr.Item("LotNo"), dr.Item("idWh"), vCommand)

                    Else
                        '----2.2 Return Other Warehouse----
                        ' Sum Amount ก่อน Insert ตัวใหม่เข้าไป
                        Dim sDt As New DataTable
                        vCommand.CommandText = "SELECT Sum(Amount) As Amount FROM dInvLotRefWh WHERE idLot = " & dr.Item("idLot")
                        vAdapter.Fill(sDt)

                        Dim AmountLot As Double
                        If sDt.Rows.Count = 0 Then
                            AmountLot = 0
                        Else
                            AmountLot = sDt.Rows(0).Item("Amount")
                        End If

                        vCommand.CommandText = "INSERT INTO dInvLotRefWh(idLot, idWh, AmountRec, Amount, idUnit, CostDt) Values(" & dr.Item("idLot") & ", " &
                                            dr.Item("idWh") & "," & CDbl(dr.Item("AmountRT")) & "," & CDbl(dr.Item("AmountRT")) & "," &
                                            dr.Item("idUnit") & ",0.00)"
                        vCommand.ExecuteNonQuery()

                        InvLotStockCard(1, dr.Item("idInvMain"), dr.Item("idLot"), CDbl(dr.Item("AmountRT")),
                                        CDbl(AmountLot), "เมนู" & Me.Text, idSaleReturn, "SAM", "SmSaleReturnMt", dr.Item("LotNo"),
                                        dr.Item("idWh"), vCommand)
                    End If
                End If
            End If
        End If

    End Sub

    Sub AddSmSaleReturnJUDt(ByVal idSaleReturn As Integer, ByVal dr As DataRow, ByVal vCommand As SqlCommand)


        vCommand.CommandText = "Insert Into SmSaleReturnJUDt(idSaleReturn, Amount, idUnit, idInvMain) " & _
                               "Values(" & idSaleReturn & "," & CDbl(dr.Item("Amount")) & ", " & _
                               "" & dr.Item("idUnit") & "," & dr.Item("idInvMain") & ")"
        vCommand.ExecuteNonQuery()

    End Sub

    Sub EditSmSaleReturnJUDt(ByVal xCommand As SqlCommand) 'Edit-JU

        'Case 2: Delete Row
        If dtJUDel.Rows.Count > 0 Then
            For j As Integer = 0 To dtJUDel.Rows.Count - 1
                Dim drJUDel As DataRow = dtJUDel.Rows(j)

                xCommand.CommandText = "DELETE FROM SmSaleReturnJUDt WHERE idJUDt = " & drJUDel.Item("idJUDt")
                xCommand.ExecuteNonQuery()

                drJUDel.Delete()
                dtJUDel.AcceptChanges()
            Next
        End If

        For i As Integer = 0 To NewPdDt.Rows.Count - 1

            Dim dr As DataRow = NewPdDt.Rows(i)

            'Case 1: insert New Row
            If IsDBNull(dr.Item("idJUDt")) Then
                AddSmSaleReturnJUDt(idSaleReturn_, dr, xCommand)
            End If

            'Case 3: Row Update
            If Not IsDBNull(dr.Item("idJUDt")) Then
                xCommand.CommandText = "UPDATE SmSaleReturnJUDt SET " & vbNewLine & _
                                       "idSaleReturn = " & idSaleReturn_ & "," & vbNewLine & _
                                       "Amount = " & CDbl(NewPdDt.Rows(i).Item("Amount")) & "," & vbNewLine & _
                                       "idUnit = " & NewPdDt.Rows(i).Item("idUnit") & "," & vbNewLine & _
                                       "idInvMain = " & NewPdDt.Rows(i).Item("idInvMain") & vbNewLine & _
                                       "WHERE idJUDt = " & dr.Item("idJUDt")
                xCommand.ExecuteNonQuery()
            End If

        Next

    End Sub


    '-------------Function For Call Stored Procedure--------------------
    Private Function AddxEditSmSaleReturnMt_SP(ByVal xCommand As SqlCommand, ByVal idSaleReturn As Integer) As Integer

        Dim DocNum As String = ""
        Dim Prefixcode As String = ""

        Dim YearRT As Integer = dtpReturn.Value.Year

        If YearRT < 2500 Then
            YearRT = YearRT + 543
        End If

        Dim MonthRT As Integer = dtpReturn.Value.Month

        If Process = eProcess.eNewReturn Then 'Insert

            Dim getDate As String = CType(YearRT, String)

            Prefixcode = (Microsoft.VisualBasic.Right(getDate, 2))
            DocNum = getDocNum(Prefixcode, xCommand)

            xCommand.CommandText = "Insert Into SmSaleReturnMt(DocNum, YearRT, MonthRT, DateReturnD, idRTDocCode, DocRef, " & _
                                   "idRtCause, idPsSale, Total, idPsReturn, idPsTs, DateTsD, Note, idComp, idPartner, idCus, idFM) " & _
                                   "Values(@DocNum, @YearRT, @MonthRT, @DateReturnD, @idRTDocCode, @DocRef, " & _
                                   "@idRtCause, @idPsSale, @Total, @idPsReturn, @idPsTs, @DateTsD, @Note, @idComp, @idPartner, @idCus, @idFM)"

        ElseIf Process = eProcess.eEdit Then


            xCommand.CommandText = "UPDATE SmSaleReturnMt SET DocNum = @DocNum, YearRT = @YearRT, MonthRT = @MonthRT, DateReturnD = @DateReturnD, " & vbNewLine & _
                                   "idRTDocCode = @idRTDocCode, DocRef = @DocRef, idRtCause = @idRtCause, idPsSale = @idPsSale, Total = @Total, idPsReturn = @idPsReturn, " & vbNewLine & _
                                   "idPsTs = @idPsTs, DateTsD = @DateTsD, Note = @Note , idComp = @idComp, idPartner = @idPartner, idCus = @idCus, idFM = @idFM" & vbNewLine & _
                                   "WHERE idSaleReturn = @idSaleReturn "

            xCommand.Parameters.Add("@idSaleReturn", SqlDbType.Int).Value = idSaleReturn
        End If

        With xCommand.Parameters
            .Add("@DocNum", SqlDbType.VarChar).Value = DocNum
            .Add("@YearRT", SqlDbType.VarChar).Value = YearRT
            .Add("@MonthRT", SqlDbType.VarChar).Value = MonthRT
            .Add("@DateReturnD", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpReturn.Value, _cultureEnInfo)
            .Add("@idRTDocCode", SqlDbType.Int).Value = Me.cmbDRCode.SelectedValue
            .Add("@DocRef", SqlDbType.VarChar).Value = Trim(txtDocRef.Text)
            .Add("@idRtCause", SqlDbType.Int).Value = Me.cmbCauseReturn.SelectedValue
            .Add("@idPsSale", SqlDbType.Int).Value = lblPsSale.Tag
            .Add("@Total", SqlDbType.Decimal).Value = CDbl(Me.txtCntSumReturn.Text)
            .Add("@idPsReturn", SqlDbType.Int).Value = lblPsReturn.Tag
            .Add("@idPsTs", SqlDbType.Int).Value = sPsId
            .Add("@DateTsD", SqlDbType.DateTime).Value = Date.Now
            .Add("@Note", SqlDbType.VarChar).Value = Trim(Me.txtNote.Text)
            .Add("@idComp", SqlDbType.Int).Value = cmbGroupComp.SelectedValue
            .Add("@idPartner", SqlDbType.Int).Value = idPartner
            .Add("@idCus", SqlDbType.Int).Value = idCus
            .Add("@idFM", SqlDbType.Int).Value = idFM
        End With

        xCommand.ExecuteNonQuery()
        xCommand.Parameters.Clear()

        If idSaleReturn = 0 Then
            Dim qr2 As String = "Select @@Identity"
            xCommand.CommandText = qr2

            idSaleReturn = xCommand.ExecuteScalar()
        End If

        Return idSaleReturn

    End Function

    Private Sub AddSmSaleReturnDt_SP(ByVal xCommand As SqlCommand, ByVal idSaleReturn As Integer, ByVal dr As DataRow)

        xCommand.CommandText = "INSERT INTO SmSaleReturnDt(idSaleReturn, idSale, idSaleDt, idLot, AmountReturn, " & vbNewLine & _
                                         "Price, RTValuePerc, RTPrice, idUnit, idWh, LotNoRT, idInvMain) " & vbNewLine & _
                                         "VALUES(@idSaleReturn, @idSale, @idSaleDt, @idLot, @AmountReturn, " & vbNewLine & _
                                         "@Price, @RTValuePerc, @RTPrice, @idUnit, @idWh, @LotNoRT, @idInvMain)"

        With xCommand.Parameters
            .Add("@idSaleReturn", SqlDbType.Int).Value = idSaleReturn
            .Add("@idSale", SqlDbType.Int).Value = dr.Item("idSale")
            .Add("@idSaleDt", SqlDbType.Int).Value = dr.Item("idSaleDt")
            .Add("@idLot", SqlDbType.Int).Value = dr.Item("idLot")
            .Add("@AmountReturn", SqlDbType.Decimal).Value = CDbl(dr.Item("AmountRT"))
            .Add("@Price", SqlDbType.Decimal).Value = CDbl(dr.Item("Price"))
            .Add("@RTValuePerc", SqlDbType.Decimal).Value = CDbl(dr.Item("RTValuePerc"))
            .Add("@RTPrice", SqlDbType.Decimal).Value = CDbl(dr.Item("RTPrice"))
            .Add("@idUnit", SqlDbType.Int).Value = dr.Item("idUnit")
            .Add("@idWh", SqlDbType.Int).Value = dr.Item("idWh")
            .Add("@LotNoRT", SqlDbType.VarChar).Value = dr.Item("LotNo")
            .Add("@idInvMain", SqlDbType.Int).Value = dr.Item("idInvMain")
        End With

        xCommand.ExecuteNonQuery()
        xCommand.Parameters.Clear()
    End Sub

    Private Sub AddxEditSmSaleReturnJUDt_SP(ByVal xCommand As SqlCommand, ByVal idSaleReturn As Integer, ByVal dr As DataRow)

        If Process = eProcess.eNewReturn Then
            xCommand.CommandText = "INSERT INTO SmSaleReturnJUDt(idSaleReturn, Amount, idUnit, idInvMain) " & vbNewLine & _
                                   "Values(@idSaleReturn, @Amount, @idUnit, @idInvMain)"
            'xCommand.ExecuteNonQuery()

        ElseIf Process = eProcess.eEdit Then

            'Case 2: Delete Row
            If dtJUDel.Rows.Count > 0 Then
                For j As Integer = 0 To dtJUDel.Rows.Count - 1
                    Dim drJUDel As DataRow = dtJUDel.Rows(j)

                    xCommand.CommandText = "DELETE FROM SmSaleReturnJUDt WHERE idJUDt = " & drJUDel.Item("idJUDt")
                    xCommand.ExecuteNonQuery()

                    drJUDel.Delete()
                    dtJUDel.AcceptChanges()
                Next
            End If

            'Case 1: insert New Row
            If IsDBNull(dr.Item("idJUDt")) Then
                AddSmSaleReturnJUDt(idSaleReturn_, dr, xCommand)
            End If

            'Case 3: Row Update
            If Not IsDBNull(dr.Item("idJUDt")) Then

                xCommand.CommandText = "UPDATE SmSaleReturnJUDt SET idSaleReturn = @idSaleReturn, Amount = @Amount, idUnit = @idUnit, idInvMain = @idInvMain " & vbNewLine & _
                                        "WHERE idJUDt = @idJUDt"

                xCommand.Parameters.Add("@idJUDt", SqlDbType.Int).Value = dr.Item("idJUDt")

            End If
        End If

        With xCommand.Parameters
            .Add("@idSaleReturn", SqlDbType.Decimal).Value = idSaleReturn
            .Add("@Amount", SqlDbType.Decimal).Value = CDbl(dr.Item("Amount"))
            .Add("@idUnit", SqlDbType.Int).Value = dr.Item("idUnit")
            .Add("@idInvMain", SqlDbType.Int).Value = dr.Item("idInvMain")
        End With


        xCommand.ExecuteNonQuery()
        xCommand.Parameters.Clear()
    End Sub

    Private Sub EditSmSaleReturnDt_SP(ByVal xCommand As SqlCommand, ByVal idSaleReturn As Integer, ByVal dr As DataRow)

        Dim xAdapter = New SqlDataAdapter(xCommand)
        '----Update SmSaleReturnMt-------------------------------------------------
        Dim getDate As String = CType(Date.Today, String)
        Dim dtpReturnCvt As DateTime = Convert.ToDateTime(dtpReturn.Value, _cultureEnInfo)
        Dim YearRT As Integer = Microsoft.VisualBasic.Right(getDate, 4)
        Dim MonthRT As Integer = CType(Date.Today.Month, Integer)
        Dim stridCus As String = ""

        '------------Edit Cut Stock Verson--------------
        If idFM = 0 And idCus <> 0 Then
            stridCus = "idCus = " & idCus & ", idFm = NULL, idPartner = " & idPartner

        ElseIf idFM <> 0 And idCus = 0 Then

            stridCus = "idCus = NULL, idFm = " & idFM & ", idPartner = " & idPartner

        ElseIf idFM <> 0 And idCus <> 0 Then
            stridCus = "idCus = " & idCus & ", idFm = " & idFM & ", idPartner = " & idPartner
        End If


        xCommand.CommandText = "Update SmSaleReturnMt Set DocNum = '" & Trim(Me.lblDocNum.Text) & "', YearRT = " & YearRT & ", MonthRT = " & MonthRT & ", " &
                               "DateReturnD = '" & dtpReturnCvt.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "'," &
                               "idRTDocCode = " & Me.cmbDRCode.SelectedValue & ", DocRef = '" & Trim(txtDocRef.Text) & "', " &
                               stridCus & ", idRtCause = " & Me.cmbCauseReturn.SelectedValue & ", " &
                               "idPsSale = " & lblPsSale.Tag & ", Total = " & CDbl(txtCntSumReturn.Text) & ", idPsReturn = " & lblPsReturn.Tag & ", " &
                               "idPsTs = " & sPsId & ", DateTsD = GETDATE(), " &
                               "Note = '" & Trim(Me.txtNote.Text) & "', idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                               "WHERE idSaleReturn = " & idSaleReturn
        xCommand.ExecuteNonQuery()


        '-------------------------------------------------------------------------
        'Case 2: Row Delete
        If dtDel.Rows.Count > 0 Then
            For j As Integer = 0 To dtDel.Rows.Count - 1
                Dim drDel As DataRow = dtDel.Rows(j)

                xCommand.CommandText = "DELETE FROM SmSaleReturnDt WHERE idSaleReturnDt = " & drDel.Item("idSaleReturnDt")
                xCommand.ExecuteNonQuery()

                'drDel.Delete()
                'dtDel.AcceptChanges()

            Next
            dtDel.AcceptChanges()
        End If

        '-------Update SmSaleReturnDt---------------------------------------------

        'Case 1: insert New Row
        If IsDBNull(dr.Item("idSaleReturnDt")) Then
            Dim idComp As Integer = cmbGroupComp.SelectedValue

            If idComp = 10 Then
                idComp = 4
            End If

            AddSmSaleReturnDt(idSaleReturn_, dr, xCommand, "SAM-5", idComp)
        End If

        'Case 3: Row Update

        '3.1 Check Stockcard used (Check on value amount column change)
        If Not IsDBNull(dr.Item("idSaleReturnDt")) Then
            '----Some column Change
            If dr.Item("LotNo") = dr.Item("LotNoHide") Or dr.Item("idWh") = dr.Item("idWhHide") Or dr.Item("Price") = dr.Item("PriceHide") _
                Or dr.Item("RTValuePerc") = dr.Item("RTValuePercHide") Or dr.Item("RTPrice") = dr.Item("RTPriceHide") Or dr.Item("AmountRT") = dr.Item("AmountRTHide") Then

                xCommand.CommandText = "UPDATE SmSaleReturnDt SET AmountReturn = " & dr.Item("AmountRT") & " , " & vbNewLine &
                                       "LotNoRT = '" & dr.Item("LotNo") & "' , " & vbNewLine &
                                       "idWh = " & dr.Item("idWh") & " , " & vbNewLine &
                                       "Price = " & dr.Item("Price") & " , " & vbNewLine &
                                       "RTValuePerc = " & dr.Item("RTValuePerc") & " , " & vbNewLine &
                                       "RTPrice = " & dr.Item("RTPrice") & vbNewLine &
                                       "WHERE idSaleReturnDt =  " & dr.Item("idSaleReturnDt")
                xCommand.ExecuteNonQuery()

            End If
        End If
        '-------------------------------------------------------------------------
    End Sub
    '-------------------------------------------------------------------
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        mdCnOpen()
        '----------- *[3]* Check stock Use--------------'
        For i As Integer = 0 To MainReturn.Rows.Count - 1
            Dim tempDt As New DataTable

            sCommand.CommandText = "Select (AmountRec-Amount) As diffUse " & vbNewLine & _
                                    "FROM dInvLotRefWh " & vbNewLine & _
                                    "WHERE idLot =" & MainReturn.Rows(i).Item("idLot") & vbNewLine & _
                                    "AND idWh = " & MainReturn.Rows(i).Item("idWh")
            sAdapter.Fill(tempDt)

            If tempDt.Rows(0).Item("diffUse") > 0 Then
                MessageBox.Show("รายการนี้ไม่สามารถยกเลิกได้ เนื่องจากสินค้าบางส่วนถูกนำไปใช้ในกระบวนการอื่นแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

        Next
        '------------------*[3]* END ---------------------

        Result = MsgBox("คุณต้องการยกเลิกรายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
        If Result = Windows.Forms.DialogResult.Yes Then
            Dim CancelNote As String = " "
            CancelNote = InputBox("ระบุสาเหตุการยกเลิก", sSystemName)
            If CancelNote.Length = 0 Then
                MessageBox.Show("กรุณาระบุสาเหตุการยกเลิก", sSystemName)
                Exit Sub
            Else
                mdLoadShow()
                Using myconnection As New SqlConnection(conStr)
                    myconnection.Open()
                    Dim mycommand As New SqlCommand()
                    Dim mytransaction As SqlTransaction
                    Dim myAdapter = New SqlDataAdapter(mycommand)

                    ' Start a local transaction
                    mytransaction = myconnection.BeginTransaction()

                    ' Must assign both transaction object and connection
                    ' to Command object for a pending local transaction.
                    mycommand.Connection = myconnection
                    mycommand.Transaction = mytransaction
                    Try
                        mycommand.CommandText = "UPDATE SmSaleReturnMt " & vbNewLine & _
                                                "SET idPsCancel = " & sPsId & ", " & vbNewLine & _
                                                "CancelNote = '" & CancelNote & "'" & vbNewLine & _
                                                "WHERE idSaleReturn = " & idSaleReturn_
                        mycommand.ExecuteNonQuery()

                        Dim dtidSaleAV As New DataTable
                        mycommand.CommandText = "SELECT idSaleReturn FROM SmSaleReturnMt Where idRtAVxST = " & idSaleReturn_
                        myAdapter.Fill(dtidSaleAV)

                        If dtidSaleAV.Rows.Count > 0 Then
                            mycommand.CommandText = "Update SmSaleReturnMt Set idPsCancel = " & sPsId & " , CancelNote = 'ระบบยกเลิกรับคืนอัตโนมัติระหว่าง AV-ST' " & _
                                                  "Where idSaleReturn = " & dtidSaleAV.Rows(0).Item("idSaleReturn")
                            mycommand.ExecuteNonQuery()
                        End If

                        '-----------------(4) Cancel Stored Procedure------------------------
                        'mycommand.CommandText = "SELECT ISNULL([devsk].[WimCheckstUseRecieveWait] (" & idSaleReturn_ & " , 2) ,0) As stRec"
                        'Dim stRec As Integer = mycommand.ExecuteScalar

                        'If stRec = 1 Then
                        '    MessageBox.Show("รายการนี้ถูกรับของเข้าคลังแล้ว ไม่สามารถยกเลิกได้", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        '    Exit Sub
                        'Else
                        '    mycommand.CommandText = "EXECUTE WaitRecieveTsEdit '2','SmSaleReturnMt','SmSaleReturnDt','idSaleReturn'," & idSaleReturn_ & "," & _
                        '                            cmbGroupComp.SelectedValue & " ," & sPsId & " ,'3'"

                        '    mycommand.ExecuteNonQuery()
                        'End If

                        '-----------------------END (4)----------------------------------------

                        '-------------------*[4]* Cancel Cut Stock--------------------------
                        '--- Cancel stock : stDel = 1 ---'
                        For i As Integer = 0 To MainReturn.Rows.Count - 1

                            '-------New Structure
                            If IsDBNull(MainReturn.Rows(i).Item("idLotReturn")) Then
                                If Not IsDBNull(MainReturn.Rows(i).Item("idLot")) Then
                                    '---Call before StockCard in New Structure ---'

                                    'mycommand.CommandText = "UPDATE dInvLotRefWh SET AmountRec = ISNULL(AmountRec,0) - " & CDbl(MainReturn.Rows(i).Item("AmountRT")) & vbNewLine & _
                                    '                        "WHERE idLot =  " & MainReturn.Rows(i).Item("idLot") & " AND idWh = " & MainReturn.Rows(i).Item("idWh")
                                    'mycommand.ExecuteNonQuery()

                                    InvLotMainUpdate(2, MainReturn.Rows(i).Item("idInvMain"), MainReturn.Rows(i).Item("idLot"), CDbl(MainReturn.Rows(i).Item("AmountRT")), _
                                    "เมนู" & Me.Text, MainReturn.Rows(i).Item("idLot"), "SAM", "SmSaleReturnMt", MainReturn.Rows(i).Item("LotNo"), MainReturn.Rows(i).Item("idWh"), mycommand)
                                End If
                            Else
                                If Not IsDBNull(MainReturn.Rows(i).Item("idLot")) Then
                                    '-- Stock Card in New Structure--'
                                    mycommand.CommandText = "UPDATE dInvLotMain SET stDel = 1 WHERE idLot = " & MainReturn.Rows(i).Item("idLot")
                                    mycommand.ExecuteNonQuery()


                                    InvLotStockCard(2, MainReturn.Rows(i).Item("idInvMain"), MainReturn.Rows(i).Item("idLot"), CDbl(MainReturn.Rows(i).Item("tempAmountRT")), _
                                                CDbl(MainReturn.Rows(i).Item("tempAmountRT")), "เมนู" & Me.Text, MainReturn.Rows(i).Item("idLot"), "SAM", "SmSaleReturnMt", _
                                                MainReturn.Rows(i).Item("LotNo"), MainReturn.Rows(i).Item("idWh"), mycommand)
                                End If
                            End If

                        Next
                        '----------------------END *[4]*-------------------------------------

                        ' Attempt to commit the transaction.
                        mytransaction.Commit()
                        mdLoadCommitt()
                        MessageBox.Show("ยกเลิกรายการเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()

                    Catch ex As Exception
                        ' Attempt to roll back the transaction.
                        Try
                            mytransaction.Rollback()
                            mdLoadCommitt()
                            MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
                                            sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                            Exit Sub
                        Catch e2x As Exception
                            mdLoadCommitt()
                            MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
                                            sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                            Exit Sub
                        End Try
                    Finally
                        myconnection.Close()
                    End Try
                End Using

            End If
        End If
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        If Process = eProcess.eAccept Then 'accept
            mdCnOpen()
            sCommand.CommandText = "UPDATE SmSaleReturnMt SET idPsAccept = " & sPsId & ", DateAccept = GETDATE() " & _
                                   "WHERE idSaleReturn = " & idSaleReturn_
            sCommand.ExecuteNonQuery()

            MessageBox.Show("รับทราบเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        ElseIf Process = eProcess.eCheck Then ' check
            mdCnOpen()
            sCommand.CommandText = "UPDATE SmSaleReturnMt SET idPsCheck = " & sPsId & ", DateCheck = GETDATE()  " & _
                                 "WHERE idSaleReturn = " & idSaleReturn_
            sCommand.ExecuteNonQuery()

            MessageBox.Show("ตรวจสอบเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        ElseIf Process = eProcess.eApprove Then ' approve
            If Me.rdbApv.Checked = False And Me.rdbNoApv.Checked = False And Me.rdbReject.Checked = False Then
                mdLoadCommitt()
                MessageBox.Show("กรุณาเลือก อนุมัติ/ไม่อนุมัติ/Reject รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf Me.rdbReject.Checked = True And Trim(Me.txtRejectNote.Text) = "" Then
                mdLoadCommitt()
                MessageBox.Show("กรุณาระบุสาเหตุการ Reject", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.txtRejectNote.Focus()
                Exit Sub
            Else
                mdLoadShow()
                Using myconnection As New SqlConnection(conStr)
                    myconnection.Open()
                    Dim mycommand As New SqlCommand()
                    Dim mytransaction As SqlTransaction

                    ' Start a local transaction
                    mytransaction = myconnection.BeginTransaction()

                    ' Must assign both transaction object and connection
                    ' to Command object for a pending local transaction.
                    mycommand.Connection = myconnection
                    mycommand.Transaction = mytransaction
                    Dim vAdapter = New SqlDataAdapter(mycommand)
                    Try
                        Dim vMsg As String = ""
                        If Me.rdbApv.Checked = True Then
                            mycommand.CommandText = "UPDATE SmSaleReturnMt SET stApp = 1, idPsApprove = " & sPsId & ", " & _
                                                    "DateApprove = GETDATE()  WHERE idSaleReturn = " & idSaleReturn_
                            mycommand.ExecuteNonQuery()

                            vMsg = "อนุมัติรายการเรียบร้อยแล้ว"
                        ElseIf Me.rdbNoApv.Checked = True Then
                            mycommand.CommandText = "UPDATE SmSaleReturnMt SET stApp = 0, idPsApprove = " & sPsId & ", " & _
                                                   "DateApprove = GETDATE()  WHERE idSaleReturn = " & idSaleReturn_
                            mycommand.ExecuteNonQuery()

                            '--- Cancel stock : stDel = 1 ---'
                            '----------------------*[5]* Reject Cut Stock-------------------------
                            For i As Integer = 0 To MainReturn.Rows.Count - 1

                                '---------------New Structure
                                If IsDBNull(MainReturn.Rows(i).Item("idLotReturn")) Then
                                    If Not IsDBNull(MainReturn.Rows(i).Item("idLotMain")) Then

                                        '--- Call Edit stock before call stockcard in New Structure ---'
                                        InvLotMainUpdate(2, MainReturn.Rows(i).Item("idInvMain"), MainReturn.Rows(i).Item("idLotMain"), CDbl(MainReturn.Rows(i).Item("tempAmountRT")), _
                                                        "เมนู" & Me.Text, MainReturn.Rows(i).Item("idPdPkLot"), "SAM", "SmSaleReturnMt", MainReturn.Rows(i).Item("LotNo"), _
                                                        MainReturn.Rows(i).Item("idWh"), mycommand)
                                    End If

                                Else
                                    If Not IsDBNull(MainReturn.Rows(i).Item("idLotMain")) Then
                                        ' -- UPDATE to dInvLotMain: stock สินค้า --'
                                        mycommand.CommandText = "UPDATE dInvLotRefWh SET Amount = 0 WHERE idLot = " & MainReturn.Rows(i).Item("idLotMain") & " AND idWh = " & MainReturn.Rows(i).Item("idWh")
                                        mycommand.ExecuteNonQuery()

                                        mycommand.CommandText = "UPDATE dInvLotMain SET stDel = 1 WHERE idLot = " & MainReturn.Rows(i).Item("idLotMain")
                                        mycommand.ExecuteNonQuery()

                                        '--- Call StockCard in New Structure ---'
                                        InvLotMainUpdate(2, MainReturn.Rows(i).Item("idInvMain"), MainReturn.Rows(i).Item("idLotMain"), CDbl(MainReturn.Rows(i).Item("tempAmountRT")), _
                                                        "เมนู" & Me.Text, MainReturn.Rows(i).Item("idLotReturn"), "SAM", _
                                                        "SmSaleReturnMt", MainReturn.Rows(i).Item("LotNo"), MainReturn.Rows(i).Item("idWh"), mycommand)
                                    End If

                                End If

                            Next
                            '--------------------------*[5]* END--------------------------------

                            '-----------------------(5) Reject Call SP--------------------------
                            'mycommand.CommandText = "SELECT ISNULL([devsk].[WimCheckstUseRecieveWait] (" & idSaleReturn_ & " , 2) ,0) As stRec"
                            'Dim stRec As Integer = mycommand.ExecuteScalar

                            'If stRec = 1 Then
                            '    MessageBox.Show("รายการนี้ถูกรับของเข้าคลังแล้ว ไม่สามารถบันทึกไม่อนุมัติรายการรับคืนได้", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                            '    Exit Sub
                            'Else
                            '    '----ส่งไปยกเลิกรายการรอรับสินค้าเข้าคลัง
                            '    mycommand.CommandText = "EXECUTE WaitRecieveTsEdit '2','SmSaleReturnMt','SmSaleReturnDt','idSaleReturn'," & idSaleReturn_ & "," & _
                            '                            cmbGroupComp.SelectedValue & " ," & sPsId & " ,'3'"

                            '    mycommand.ExecuteNonQuery()
                            'End If

                            '-------------------------(5) END-----------------------------------


                            vMsg = "บันทึกไม่อนุมัติรายการเรียบร้อยแล้ว"
                        ElseIf Me.rdbReject.Checked = True Then
                            mycommand.CommandText = "UPDATE SmSaleReturnMt SET stApp = 2, idPsApprove = " & sPsId & ", " & _
                                                 "DateApprove = GETDATE() , " & _
                                                 "RejectNote = '" & Me.txtRejectNote.Text & "' WHERE idSaleReturn = " & idSaleReturn_
                            mycommand.ExecuteNonQuery()
                            vMsg = "บันทึก Reject และสาเหตุการ Reject รายการเรียบร้อยแล้ว"
                        End If

                        ' Attempt to commit the transaction.
                        mytransaction.Commit()
                        mdLoadCommitt()
                        MessageBox.Show(vMsg, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = DialogResult.OK
                        Me.Close()

                    Catch ex As Exception
                        ' Attempt to roll back the transaction.
                        Try
                            mytransaction.Rollback()
                            mdLoadCommitt()
                            MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
                                            sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                            Exit Sub
                        Catch e2x As Exception
                            mdLoadCommitt()
                            MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
                                            sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                            Exit Sub
                        End Try
                    Finally
                        myconnection.Close()
                    End Try
                End Using
            End If
        End If
    End Sub


    Private Sub rdbReject_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdbReject.CheckedChanged
        If Me.rdbReject.Checked = True Then
            Me.txtRejectNote.Enabled = True
        Else
            Me.txtRejectNote.Enabled = False
        End If
    End Sub

    Private Sub cmbWhOnGrid()
        'Dim riLookup As New RepositoryItemLookUpEdit()
        Dim sDt As New DataTable

        Dim idComp As Integer = cmbGroupComp.SelectedValue

        If idComp = 10 Then
            idComp = 4
        End If

        sCommand.CommandText = "Select idWh, WareHouseName" & vbNewLine & _
                               "FROM SsWarehouse " & vbNewLine & _
                               "WHERE stWh = 0" & vbNewLine & _
                               "AND idParrent = 0  " & vbNewLine & _
                               "AND idComp = " & idComp & " AND stDel = 0 AND StApprove = 1"

        '"AND idComp = " & cmbGroupComp.SelectedValue & " AND (stType = 0 OR stType = 1) AND StApprove = 1"
        sAdapter.Fill(sDt)

        rptWarehouse.Columns.Clear()
        rptWarehouse.Columns.Add(New LookUpColumnInfo("WareHouseName"))
        rptWarehouse.DataSource = sDt

        rptWarehouse.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        ' Specify the dropdown height.
        rptWarehouse.DropDownRows = sDt.Rows.Count
    End Sub


    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            chxCompany = 1

            lblPsCus.Text = ""
            lblPsCus.Tag = 0
            lblPsSale.Text = ""
            lblPsReturn.Text = ""
            txtCntSumReturn.Text = 0
            txtCntReturn.Text = 0
            Me.lblPsSale.Tag = 0
            idPartner = 0

            MainReturn.Clear()
            NewPdDt.Clear()
            cmbWhOnGrid()

        End If
    End Sub

    'Private Sub btnNoBill_Click(sender As Object, e As EventArgs) Handles btnNoBill.Click
    '    If Me.lblPsCus.Text = "" Then
    '        MessageBox.Show("กรุณาเลือกลูกค้า ก่อนเลือกรายการคืนสินค้า", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
    '        Exit Sub
    '    End If

    '    cmbWhOnGrid()
    '    Dim tempWh As New DataTable
    '    sCommand.CommandText = "SELECT idWh FROM SsWarehouse WHERE idComp = " & cmbGroupComp.SelectedValue & " AND stType = 1" 'คลังรับคืน
    '    sAdapter.Fill(tempWh)

    '    If tempWh.Rows.Count = 0 Then
    '        MessageBox.Show("ไม่พบข้อมูลคลังรับคืนของบริษัทนี้ " & vbNewLine & "กรุณาเพิ่มคลังที่ระบบ WIM ก่อนทำรายการรับคืน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Exit Sub
    '    Else
    '        idRTWh = tempWh.Rows(0).Item("idWh")
    '    End If

    '    Dim idBackDt As New DataTable
    '    idBackDt.Columns.Add("idSaleDt", System.Type.GetType("System.String"))
    '    'idBackDt.Columns.Add("Amount", System.Type.GetType("System.Double"))

    '    Dim k As Integer = 0
    '    '-------------------------------NEW GRID-------------------------------
    '    For i As Integer = 0 To GvReturn.DataRowCount - 1
    '        If Not IsDBNull(GvReturn.GetDataRow(i).Item("idSaleDt")) Then
    '            If GvReturn.GetDataRow(i).Item("idSaleDt") <> 0 Then
    '                idBackDt.Rows.Add()
    '                idBackDt.Rows(k).Item("idSaleDt") = GvReturn.GetDataRow(i).Item("idSaleDt")
    '                k = k + 1
    '            End If
    '        End If
    '    Next


    '    Dim vFrm As New frmSlReturnNoBill(frmSlReturnNoBill.eProcess.eTs153, Me.dtpReturn.Value, cmbGroupComp.SelectedValue, "", 0, "", idBackDt)
    '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then


    '        mdCnOpen()
    '        Dim LPriceDt As New DataTable
    '        LPriceDt.Clear()
    '        Dim ChkPrice As Double = 0.0

    '        MainReturn.Rows.Add(0, vFrm.dtSmSale.Rows(0).Item("idLot"), 0, "", vFrm.dtSmSale.Rows(0).Item("LotNo").ToUpper, vFrm.dtSmSale.Rows(0).Item("idInvMain"), vFrm.dtSmSale.Rows(0).Item("InvName"), _
    '                            vFrm.dtSmSale.Rows(0).Item("AmtSale"), vFrm.dtSmSale.Rows(0).Item("UnitName"), _
    '                          idRTWh, vFrm.dtSmSale.Rows(0).Item("DateGen"), vFrm.dtSmSale.Rows(0).Item("idUnit"), 0, vFrm.dtSmSale.Rows(0).Item("idLot"), ChkPrice, 100, ChkPrice, 0)

    '        GCReturn.DataSource = MainReturn
    '        SumReturn()
    '    End If

    '    GvReturn.ExpandAllGroups()
    'End Sub

    'Private Sub btnPdInc_Click(sender As Object, e As EventArgs) Handles btnPdInc.Click

    '    If Me.lblPsCus.Text = "" Then
    '        MessageBox.Show("กรุณาเลือกลูกค้า ก่อนเลือกรายการคืนสินค้า", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
    '        Exit Sub
    '    End If

    '    Dim idBackDt As New DataTable
    '    idBackDt.Columns.Add("NewidSaleDt", System.Type.GetType("System.String"))
    '    idBackDt.Columns.Add("Amount", System.Type.GetType("System.Int64"))

    '    For i As Integer = 0 To MainReturn.Rows.Count - 1
    '        'check unit
    '        'If MainReturn.Rows(i).Item("dtType") = 3 And MainReturn.Rows(i).Item("idPKUnit") = 1 Then 'ขายวัตถุดิบ + หน่วย กรัม
    '        '    MainReturn.Rows(i).Item("AmountRT") = MainReturn.Rows(i).Item("AmountRT") / 1000
    '        'End If

    '        idBackDt.Rows.Add(MainReturn.Rows(i).Item("idSaleDt"), MainReturn.Rows(i).Item("AmountRT"))
    '    Next

    '    Dim vFrm As New frmSlReturnSaleList(frmSlReturnSaleList.eProcess.eSelectReturn, idBackDt, idPartner, Me.lblPsCus.Text, cmbGroupComp.SelectedValue, "", lblPsSale.Tag, lblPsSale.Text)
    '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        Dim ReturnDt As New DataTable

    '        cmbWhOnGrid()
    '        mdCnOpen()
    '        mdLoadShow()

    '        For i As Integer = 0 To vFrm.getDt.Rows.Count - 1

    '            MainReturn.Rows.Add(vFrm.getDt.Rows(i).Item("idSaleDt"), vFrm.getDt.Rows(i).Item("idLot"), vFrm.getDt.Rows(i).Item("idSale"), _
    '                             vFrm.getDt.Rows(i).Item("DocRef"), vFrm.getDt.Rows(i).Item("Lotno"), vFrm.getDt.Rows(i).Item("idProduct"), _
    '                             vFrm.getDt.Rows(i).Item("ProductName"), 0.0, vFrm.getDt.Rows(i).Item("UnitName"), idRTWh, vFrm.getDt.Rows(i).Item("DateGen"), _
    '                             vFrm.getDt.Rows(i).Item("idUnit"), vFrm.getDt.Rows(i).Item("BalanceRT"), vFrm.getDt.Rows(i).Item("idLot"), _
    '                             vFrm.getDt.Rows(i).Item("Price"), 100, vFrm.getDt.Rows(i).Item("Price"), 0)

    '        Next
    '        GvReturn.ExpandAllGroups()

    '        GCReturn.DataSource = MainReturn


    '        SumReturn()
    '    End If
    '    mdLoadCommitt()
    'End Sub



    'Private Sub btnNewPd_Click(sender As Object, e As EventArgs) Handles btnNewPd.Click

    '    Dim vFrm As New frmAllInvSelect(frmAllInvSelect.eProcess.eAll, cmbGroupComp.SelectedValue)
    '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

    '        NewPdDt.Rows.Add(vFrm.sdt1.Rows(0).Item("idInvMain"), "", vFrm.sdt1.Rows(0).Item("InvName"), 0.0, vFrm.sdt1.Rows(0).Item("UnitName"), vFrm.sdt1.Rows(0).Item("idUnit"))

    '        GCNewPd.DataSource = NewPdDt

    '        SumNewPd()
    '    End If
    'End Sub

    Private Sub rptLotNo_KeyDown(sender As Object, e As KeyEventArgs) Handles rptLotNo.KeyDown
        Dim navigator As ControlNavigator = GCReturn.EmbeddedNavigator

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Space Then

            If idPartner = 0 Then
                MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการเลือก Lot สินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)

            'If GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, "LotNo") = "" Then
            '    MessageBox.Show("กรุณาระบุ Lot No. เพื่อทำการค้นหา", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If
            Dim idBackDt As New DataTable
            idBackDt.Columns.Add("idSaleDt", System.Type.GetType("System.String"))

            Dim k As Integer = 0
            '-------------------------------NEW GRID-------------------------------
            For i As Integer = 0 To GvReturn.DataRowCount - 1
                If Not IsDBNull(GvReturn.GetDataRow(i).Item("idSaleDt")) Then
                    If GvReturn.GetDataRow(i).Item("idSaleDt") <> 0 Then
                        idBackDt.Rows.Add()
                        idBackDt.Rows(k).Item("idSaleDt") = GvReturn.GetDataRow(i).Item("idSaleDt")
                        k = k + 1
                    End If
                End If
            Next
            Dim idInvMain As Integer = 0
            If Not IsDBNull(GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, "idInvMain")) Then
                idInvMain = GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, "idInvMain")
            End If

            If IsDBNull(GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, "LotNo")) Then
                GvReturn.SetRowCellValue(GvReturn.FocusedRowHandle, "LotNo", "")
            End If
            Dim vFrm As New frmSlReturnNoBill(frmSlReturnNoBill.eProcess.eTs153, Me.dtpReturn.Value, cmbGroupComp.SelectedValue,
                                              GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, "LotNo"), idPartner, Trim(lblPsCus.Text), idBackDt,
                                              idInvMain)

                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim idComp As Integer = cmbGroupComp.SelectedValue

                    If idComp = 10 Then
                        idComp = 4
                    End If
                    mdCnOpen()

                    Dim tempWh As New DataTable
                    sCommand.CommandText = "SELECT idWh FROM SsWarehouse WHERE idComp = " & idComp & " AND stType = 1 AND stDel = 0" 'คลังรับคืน
                    sAdapter.Fill(tempWh)

                    If tempWh.Rows.Count = 0 Then
                        MessageBox.Show("ไม่พบข้อมูลคลังรับคืนของบริษัทนี้ " & vbNewLine & "กรุณาเพิ่มคลังที่ระบบ WIM ก่อนทำรายการรับคืน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        idRTWh = tempWh.Rows(0).Item("idWh")
                    End If

                    If vFrm.dtSmSale.Rows(0).Item("idSale") = 0 Then
                        vFrm.dtSmSale.Rows(0).Item("PriceSale") = fnSetPricNormal(vFrm.dtSmSale.Rows(0).Item("idProduct")) 'ถ้าไม่ใช่อ้างอิงรายการขาย ให้ไปหาราคาปกติมาใส่
                    End If

                    fnSetDataOnGrid(vFrm.dtSmSale.Rows(0), idRTWh)

                    'Set Second Row ++
                    For i As Integer = 1 To vFrm.dtSmSale.Rows.Count - 1
                        vFrm.dtSmSale.Rows(i).Item("PriceSale") = fnSetPricNormal(vFrm.dtSmSale.Rows(i).Item("idProduct")) 'ถ้าไม่ใช่อ้างอิงรายการขาย ให้ไปหาราคาปกติมาใส่
                        GvReturn.AddNewRow()
                        fnSetDataOnGrid(vFrm.dtSmSale.Rows(i), idRTWh)

                    Next

                    GvReturn.RefreshData()

                Else
                    navigator.Buttons.DoClick(navigator.Buttons.Remove)
                End If
            End If

        'SumReturn()
    End Sub

    Private Function fnSetPricNormal(ByVal idInvMain As Integer) As Double
        mdCnOpen()
        Dim PriceNormal As Double = 0
        Dim dt As New DataTable

        sCommand.CommandText = "SELECT inv.idInvGroup, ISNULL(fg.PriceBill,0) As PriceBill_fg, IsNULL(pdo.Price,0) As PricePdo_pdo, " & vbNewLine & _
                                "IsNULL(sfg.Price,0) As PriceSeedFg_sfg, ISNULL(d.Price,0) As PriceSeed" & vbNewLine & _
                                "FROM dInventoryMain As inv " & vbNewLine & _
                                "LEFT JOIN dInvGroup As gr ON inv.idInvGroup = gr.idInvgroup" & vbNewLine & _
                                "LEFT JOIN dPackingPdSet fg ON inv.idSubType = fg.idPdPk AND inv.idInvGroup = 2" & vbNewLine & _
                                "LEFT JOIN SmPdOtherD pdo On inv.idSubType = pdo.idPdo AND gr.stpdOther = 1" & vbNewLine & _
                                "LEFT JOIN dSeedFlPackage sfg ON inv.idSubType = sfg.idFlPk AND inv.idInvgroup = 42" & vbNewLine &
                                "LEFT JOIN dSeedProductPrice d ON inv.idInvMain = d.idInvMain AND inv.idInvGroup = 1 AND d.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                "WHERE inv.idInvMain = " & idInvMain

        sAdapter.Fill(dt)

        Select Case dt.Rows(0).Item("idInvGroup")

            Case 1 'สินค้าวัตถุดิบ
                PriceNormal = dt.Rows(0).Item("PriceSeed")

            Case 2 'สินค้าสำเร็จรูป FG
                PriceNormal = dt.Rows(0).Item("PriceBill_fg")

            Case 42 ' สินค้าเมล็ดพันธุ์สำเร็จรูป FG (หน่วย ซอง)
                PriceNormal = dt.Rows(0).Item("PriceSeedFg_sfg")

            Case Else ' Other Type except FG (idInvGroup = 2)
                PriceNormal = dt.Rows(0).Item("PricePdo_pdo")

        End Select

        Return PriceNormal
    End Function

    Private Sub fnSetDataOnGrid(ByVal dr As DataRow, ByVal idWh As Integer)
        GvReturn.SetFocusedRowCellValue("idSale", dr.Item("idSale"))
        GvReturn.SetFocusedRowCellValue("idSaleDt", dr.Item("idSaleDt"))
        GvReturn.SetFocusedRowCellValue("DocRef", dr.Item("DocRef"))
        GvReturn.SetFocusedRowCellValue("idLot", dr.Item("idLot"))
        GvReturn.SetFocusedRowCellValue("LotNo", dr.Item("Lotno").ToUpper)
        GvReturn.SetFocusedRowCellValue("idInvMain", dr.Item("idProduct"))
        GvReturn.SetFocusedRowCellValue("InvName", dr.Item("ProductName"))
        GvReturn.SetFocusedRowCellValue("idUnit", dr.Item("idUnit"))
        GvReturn.SetFocusedRowCellValue("UnitName", dr.Item("UnitName"))
        GvReturn.SetFocusedRowCellValue("idWh", idWh)
        GvReturn.SetFocusedRowCellValue("AmountRT", dr.Item("AmountRT"))
        GvReturn.SetFocusedRowCellValue("RTPrice", dr.Item("AmountRT") * dr.Item("PriceSale"))
        GvReturn.SetFocusedRowCellValue("Price", dr.Item("PriceSale"))
        GvReturn.SetFocusedRowCellValue("RTValuePerc", 100)
        GvReturn.SetFocusedRowCellValue("BalanceRT", dr.Item("AmtSale"))
        GvReturn.SetFocusedRowCellValue("Exp", dr.Item("AmountRT") * dr.Item("PriceSale"))
        GvReturn.SetFocusedRowCellValue("DateGen", dr.Item("DateGen"))
        GvReturn.SetFocusedRowCellValue("idInvGroup", dr.Item("idInvGroup"))
    End Sub

    Private Sub rptTxtDocSale_KeyDown(sender As Object, e As KeyEventArgs) Handles rptTxtDocSale.KeyDown
        Dim navigator As ControlNavigator = GCReturn.EmbeddedNavigator

        If idPartner = 0 Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนระบุเลขที่บิลขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            navigator.Buttons.DoClick(navigator.Buttons.Remove)
            SendKeys.Send("^{TAB}")
            SendKeys.Send("^{TAB}")
            SendKeys.Send("{TAB}")
            SendKeys.Send("{TAB}")
            SendKeys.Send("{TAB}")
            SendKeys.Send("{TAB}")
            SendKeys.Send("{TAB}")

            Exit Sub
        End If
        If e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Enter Then
            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)

            If GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, "DocRef") = "" Then
                MessageBox.Show("กรุณาระบุ เลขที่บิลขาย เพื่อทำการค้นหา", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                navigator.Buttons.DoClick(navigator.Buttons.Remove)
                Exit Sub
            End If

            Dim idBackDt As New DataTable
            idBackDt.Columns.Add("idSaleDt", System.Type.GetType("System.String"))
            idBackDt.Columns.Add("Amount", System.Type.GetType("System.Double"))

            Dim k As Integer = 0
            '-------------------------------NEW GRID-------------------------------
            For i As Integer = 0 To GvReturn.DataRowCount - 1
                If Not IsDBNull(GvReturn.GetDataRow(i).Item("idSaleDt")) Then
                    If GvReturn.GetDataRow(i).Item("idSaleDt") <> 0 Then
                        idBackDt.Rows.Add()
                        idBackDt.Rows(k).Item("idSaleDt") = GvReturn.GetDataRow(i).Item("idSaleDt")
                        k = k + 1
                    End If
                End If
            Next

            Dim vFrm As New frmSlReturnSaleList(frmSlReturnSaleList.eProcess.eSelectReturn, idBackDt, idPartner, Me.lblPsCus.Text, cmbGroupComp.SelectedValue, _
                                                GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, "DocRef"), lblPsSale.Tag, lblPsSale.Text)

            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Set First Row
                fnSetDataOnGrid(vFrm.getDt.Rows(0), idRTWh)

                'Set Second Row ++
                For i As Integer = 1 To vFrm.getDt.Rows.Count - 1

                    GvReturn.AddNewRow()
                    fnSetDataOnGrid(vFrm.getDt.Rows(i), idRTWh)

                Next

                GvReturn.RefreshData()
            Else
                navigator.Buttons.DoClick(navigator.Buttons.Remove)
            End If

        End If

        SumReturn()
    End Sub

    Private Sub rptInvName_KeyDown(sender As Object, e As KeyEventArgs) Handles rptInvName.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F5 Then
            fnSelDataOfProductName()
        End If
    End Sub

    Private Sub rptInvName_Click(sender As Object, e As EventArgs) Handles rptInvName.Click
        fnSelDataOfProductName()
    End Sub

    Private Sub fnSelDataOfProductName()
        Dim navigator As ControlNavigator = GCNewPd.EmbeddedNavigator

        If idPartner = 0 Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการเลือกสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Dim navigator As ControlNavigator = GCReturnMt.EmbeddedNavigator
        If GVNewPd.FocusedRowHandle >= 0 Then
            navigator.Buttons.DoClick(navigator.Buttons.Edit)
        Else
            'ถ้า เป็น NewItemRow
            navigator.Buttons.DoClick(navigator.Buttons.Append)
            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
        End If

        fnSetDataOfProduct()

        If IsDBNull(GVNewPd.GetRowCellValue(GVNewPd.FocusedRowHandle, "idInvMain")) Then
            navigator.Buttons.DoClick(navigator.Buttons.Remove)
            Exit Sub
        End If
    End Sub

    Private Sub fnSetDataOfProduct()

        Dim vFrm As New frmAllInvSelect(frmAllInvSelect.eProcess.eAll, cmbGroupComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim LPriceDt As New DataTable
            LPriceDt.Clear()
            Dim ChkPrice As Double = 0.0

            sCommand.CommandText = "SELECT TOP 1 d.Price " & vbNewLine & _
                                   "FROM SmSaleDtAll As d  " & vbNewLine & _
                                   "LEFT JOIN SmSaleMt m ON d.idSale = m.idSale" & vbNewLine & _
                                   "WHERE m.idPsCancel IS NULL " & vbNewLine & _
                                   "AND m.idPartner = " & idPartner & "  " & vbNewLine & _
                                   "AND d.Price > 0 " & vbNewLine & _
                                   "AND d.idProduct = " & vFrm.sdt1.Rows(0).Item("idInvMain") & "  " & _
                                   "Order BY m.DateSaleD DESC"

            sAdapter.Fill(LPriceDt)

            If LPriceDt.Rows.Count = 0 Then ' ไม่พบประวัติการขาย >>> check price list

                If Not IsDBNull(vFrm.sdt1.Rows(0).Item("PriceBill_fg")) Then

                    ChkPrice = vFrm.sdt1.Rows(0).Item("PriceBill_fg")

                ElseIf Not IsDBNull(vFrm.sdt1.Rows(0).Item("PricePdo_pdo")) Then

                    ChkPrice = vFrm.sdt1.Rows(0).Item("PricePdo_pdo")
                Else

                    ChkPrice = 0.0
                End If
            End If

            GVNewPd.SetFocusedRowCellValue("PdCode", vFrm.sdt1.Rows(0).Item("InvCode"))
            GVNewPd.SetFocusedRowCellValue("idInvMain", vFrm.sdt1.Rows(0).Item("idInvMain"))
            GVNewPd.SetFocusedRowCellValue("InvName", vFrm.sdt1.Rows(0).Item("InvName"))
            GVNewPd.SetFocusedRowCellValue("Amount", 1)
            GVNewPd.SetFocusedRowCellValue("UnitName", vFrm.sdt1.Rows(0).Item("UnitName"))
            GVNewPd.SetFocusedRowCellValue("idUnit", vFrm.sdt1.Rows(0).Item("idUnit"))


            GVNewPd.RefreshData()
            SumNewPd()

        End If
    End Sub

    Private Sub rptPdCode_KeyDown(sender As Object, e As KeyEventArgs) Handles rptPdCode.KeyDown
        If e.KeyCode = Keys.Back Then
            Exit Sub
        End If

        Dim navigator As ControlNavigator = GCNewPd.EmbeddedNavigator

        If idPartner = 0 Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SendKeys.SendWait("{BACKSPACE}")
            navigator.Buttons.DoClick(navigator.Buttons.Remove)
            Exit Sub
        End If

        'Dim PdCode_Temp As String = ""

        If e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Enter Then
            mdCnOpen()

            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)

            If GVNewPd.GetRowCellValue(GVNewPd.FocusedRowHandle, "PdCode") = "" Then
                MessageBox.Show("กรุณาระบุรหัสสินค้า เพื่อค้นหาข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            'PdCode_Temp = GVNewPd.GetRowCellValue(GVNewPd.FocusedRowHandle, "PdCode")
            Dim vFrm As New frmInvCodeSelect(frmInvCodeSelect.eProcess.eSelect, GVNewPd.GetRowCellValue(GVNewPd.FocusedRowHandle, "PdCode"))

            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                GVNewPd.SetFocusedRowCellValue("PdCode", vFrm.dtInvCode.Rows(0).Item("InvCode"))
                GVNewPd.SetFocusedRowCellValue("idInvMain", vFrm.dtInvCode.Rows(0).Item("idInvMain"))
                GVNewPd.SetFocusedRowCellValue("InvName", vFrm.dtInvCode.Rows(0).Item("InvName"))
                GVNewPd.SetFocusedRowCellValue("Amount", 1)
                GVNewPd.SetFocusedRowCellValue("UnitName", vFrm.dtInvCode.Rows(0).Item("UnitName"))
                GVNewPd.SetFocusedRowCellValue("idUnit", vFrm.dtInvCode.Rows(0).Item("idUnit"))

            Else
                navigator.Buttons.DoClick(navigator.Buttons.Remove)
            End If
        End If
    End Sub

    Private Sub rptDel_KeyDown(sender As Object, e As KeyEventArgs) Handles rptDel.KeyDown
        If GvReturn.FocusedRowHandle >= 0 Then
            If e.KeyCode = Keys.Enter Then
                Dim dr As DataRow = GvReturn.GetDataRow(GvReturn.FocusedRowHandle)

                Dim drtemp As DataRow = dtDel.NewRow()

                Result = MessageBox.Show("คุณต้องการลบรายการนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If Result = Windows.Forms.DialogResult.OK Then
                    If Not IsDBNull(dr.Item("idSaleReturnDt")) Then
                        drtemp("idSaleReturnDt") = dr.Item("idSaleReturnDt")
                        drtemp("idInvMain") = dr.Item("idInvMain")
                        drtemp("idLot") = dr.Item("idLot")
                        drtemp("AmountRT") = dr.Item("AmountRT")
                        drtemp("LotNo") = dr.Item("LotNo")
                        drtemp("idWh") = dr.Item("idWh")
                        dtDel.Rows.Add(drtemp)
                    End If

                    dr.Delete()
                    MainReturn.AcceptChanges()
                End If
                SumReturn()
            End If
        End If

    End Sub

    '--Del Returnlist----'
    Private Sub rptDel_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptDel.ButtonClick
        If GvReturn.FocusedRowHandle >= 0 Then
            Dim dr As DataRow = GvReturn.GetDataRow(GvReturn.FocusedRowHandle)

            Dim drtemp As DataRow = dtDel.NewRow()

            Result = MessageBox.Show("คุณต้องการลบรายการนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If Result = Windows.Forms.DialogResult.OK Then
                If Not IsDBNull(dr.Item("idSaleReturnDt")) Then
                    drtemp("idSaleReturnDt") = dr.Item("idSaleReturnDt")
                    drtemp("idInvMain") = dr.Item("idInvMain")
                    drtemp("idLot") = dr.Item("idLot")
                    drtemp("AmountRT") = dr.Item("AmountRT")
                    drtemp("LotNo") = dr.Item("LotNo")
                    drtemp("idWh") = dr.Item("idWh")
                    dtDel.Rows.Add(drtemp)
                End If

                dr.Delete()
                MainReturn.AcceptChanges()
            End If
            SumReturn()
        End If
    End Sub

    '--Del New Pd----'
    Private Sub rptJUDel_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptJUDel.ButtonClick
        If GVNewPd.FocusedRowHandle >= 0 Then
            Dim dr As DataRow = GVNewPd.GetDataRow(GVNewPd.FocusedRowHandle)

            Dim drtemp As DataRow = dtJUDel.NewRow()

            Result = MessageBox.Show("คุณต้องการลบรายการนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If Result = Windows.Forms.DialogResult.OK Then
                If Not IsDBNull(dr.Item("idJUDt")) Then
                    drtemp("idJuDt") = dr.Item("idJUDt")
                    dtJUDel.Rows.Add(drtemp)
                End If

                dr.Delete()
                NewPdDt.AcceptChanges()
            End If

            SumNewPd()
        End If

    End Sub

    Private Sub rptJUDel_KeyDown(sender As Object, e As KeyEventArgs) Handles rptJUDel.KeyDown
        If GVNewPd.FocusedRowHandle >= 0 Then
            If e.KeyCode = Keys.Enter Then
                Dim dr As DataRow = GVNewPd.GetDataRow(GVNewPd.FocusedRowHandle)

                Dim drtemp As DataRow = dtJUDel.NewRow()

                Result = MessageBox.Show("คุณต้องการลบรายการนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If Result = Windows.Forms.DialogResult.OK Then
                    If Not IsDBNull(dr.Item("idJUDt")) Then
                        drtemp("idJuDt") = dr.Item("idJUDt")
                        dtJUDel.Rows.Add(drtemp)
                    End If

                    dr.Delete()
                    NewPdDt.AcceptChanges()
                End If

                SumNewPd()
            End If
        End If
    End Sub

    Private Sub rptWarehouse_Click(sender As Object, e As EventArgs) Handles rptWarehouse.Click
        If GvReturn.FocusedRowHandle < 0 Then
            rptWarehouse.ReadOnly = True
        Else
            rptWarehouse.ReadOnly = False
        End If
    End Sub

    Private Sub AddSmSaleReturnDtNoAddStock(ByVal xCommand As SqlCommand, ByVal idSaleReturn As Integer, ByVal dr As DataRow, ByVal No As Integer)

        xCommand.CommandText = "INSERT INTO SmSaleReturnDt(idSaleReturn, idSale, idSaleDt, idLot, AmountReturn, " & vbNewLine & _
                                         "Price, RTValuePerc, RTPrice, idUnit, idWh, LotNoRT, idInvMain) " & vbNewLine & _
                                         "VALUES(@idSaleReturn, @idSale, @idSaleDt, @idLot, @AmountReturn, " & vbNewLine & _
                                         "@Price, @RTValuePerc, @RTPrice, @idUnit, @idWh, @LotNoRT, @idInvMain)"

        With xCommand.Parameters
            .Add("@idSaleReturn", SqlDbType.Int).Value = idSaleReturn
            .Add("@idSale", SqlDbType.Int).Value = dr.Item("idSale")
            .Add("@idSaleDt", SqlDbType.Int).Value = dr.Item("idSaleDt")
            .Add("@idLot", SqlDbType.Int).Value = dr.Item("idLot")
            .Add("@AmountReturn", SqlDbType.Decimal).Value = CDbl(dr.Item("AmountRT"))
            .Add("@Price", SqlDbType.Decimal).Value = CDbl(dr.Item("Price"))
            .Add("@RTValuePerc", SqlDbType.Decimal).Value = CDbl(dr.Item("RTValuePerc"))
            .Add("@RTPrice", SqlDbType.Decimal).Value = CDbl(dr.Item("RTPrice"))
            .Add("@idUnit", SqlDbType.Int).Value = dr.Item("idUnit")
            .Add("@idWh", SqlDbType.Int).Value = dr.Item("idWh")
            .Add("@LotNoRT", SqlDbType.VarChar).Value = dr.Item("LotNo")
            .Add("@idInvMain", SqlDbType.Int).Value = dr.Item("idInvMain")
            .Add("@No", SqlDbType.Int).Value = No
        End With

        xCommand.ExecuteNonQuery()
        xCommand.Parameters.Clear()
    End Sub

    Private Function ADDxEditSmSaleReturnMt(ByVal xCommand As SqlCommand, ByVal idSaleReturn As Integer, ByVal idComp As Integer, _
                                            ByVal gidPartner As Integer, ByVal gidCus As Integer, ByVal gidFM As Integer, _
                                            ByVal gidPsReturn As Integer, ByVal gidPsSale As Integer, ByVal DocRef As String) As Integer

        Dim DocNum As String = ""
        Dim Prefixcode As String = ""

        Dim YearRT As Integer = dtpReturn.Value.Year

        If YearRT < 2500 Then
            YearRT = YearRT + 543
        End If

        Dim MonthRT As Integer = dtpReturn.Value.Month


        Dim getDate As String = CType(YearRT, String)

        Prefixcode = (Microsoft.VisualBasic.Right(getDate, 2))
        DocNum = getDocNum(Prefixcode, xCommand)

        xCommand.CommandText = "Insert Into SmSaleReturnMt(DocNum, YearRT, MonthRT, DateReturnD, idRTDocCode, DocRef, " &
                               "idRtCause, idPsSale, Total, idPsReturn, idPsTs, DateTsD, Note, idComp, idPartner, idCus, idFM, DateReturnSys) " &
                               "Values(@DocNum, @YearRT, @MonthRT, @DateReturnD, @idRTDocCode, @DocRef, " &
                               "@idRtCause, @idPsSale, @Total, @idPsReturn, @idPsTs, @DateTsD, @Note, @idComp, @idPartner, @idCus, @idFM, @DateReturnSys)"


        With xCommand.Parameters
            .Add("@DocNum", SqlDbType.VarChar).Value = DocNum
            .Add("@YearRT", SqlDbType.VarChar).Value = YearRT
            .Add("@MonthRT", SqlDbType.VarChar).Value = MonthRT
            .Add("@DateReturnD", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpReturn.Value, _cultureEnInfo)
            .Add("@idRTDocCode", SqlDbType.Int).Value = Me.cmbDRCode.SelectedValue
            .Add("@DocRef", SqlDbType.VarChar).Value = DocRef
            .Add("@idRtCause", SqlDbType.Int).Value = Me.cmbCauseReturn.SelectedValue
            .Add("@idPsSale", SqlDbType.Int).Value = gidPsSale
            .Add("@Total", SqlDbType.Decimal).Value = CDbl(txtCntSumReturn.Text)
            .Add("@idPsReturn", SqlDbType.Int).Value = gidPsReturn
            .Add("@idPsTs", SqlDbType.Int).Value = sPsId
            .Add("@DateTsD", SqlDbType.DateTime).Value = Date.Now
            .Add("@Note", SqlDbType.VarChar).Value = Trim(Me.txtNote.Text)
            .Add("@idComp", SqlDbType.Int).Value = idComp
            .Add("@idPartner", SqlDbType.Int).Value = gidPartner
            .Add("@idCus", SqlDbType.Int).Value = gidCus
            .Add("@idFM", SqlDbType.Int).Value = gidFM
            .Add("@DateReturnSys", SqlDbType.DateTime).Value = DateTime.Now
        End With

        xCommand.ExecuteNonQuery()
        xCommand.Parameters.Clear()

        If idSaleReturn = 0 Then
            Dim qr2 As String = "Select @@Identity"
            xCommand.CommandText = qr2

            idSaleReturn = xCommand.ExecuteScalar()
        End If

        Return idSaleReturn

    End Function

    Sub EditJUDtAVxST(ByVal myCommand As SqlCommand, ByVal idReturnAV As Integer) 'Edit-JU

        Dim myAdapter As New SqlDataAdapter(myCommand)

        '--Update SmSaleMt (Auto Bill)
        'mycommand.CommandText = "UPDATE SET " & CDbl(txtTotalNet.Text)
        'Case 1: insert New Row/Lot
        Dim dtRtDtCaseAdd As New DataTable

        myCommand.CommandText = "SELECT (SELECT idSaleReturn FROM SmSaleReturnMt Where idRtAVxST = " & idSaleReturn_ & ") As idSaleReturn , Amount, idUnit, idInvMain" & vbNewLine & _
                                "FROM SmSaleReturnJUDt" & vbNewLine & _
                                "Where idSaleReturn = " & idSaleReturn_ & vbNewLine & _
                                "AND idInvMain Not IN ( SELECT idInvMain FROM SmSaleReturnJUDt WHERE idSaleReturn = " & idReturnAV & ")"

        myAdapter.Fill(dtRtDtCaseAdd)

        If dtRtDtCaseAdd.Rows.Count > 0 Then
            For i As Integer = 0 To dtRtDtCaseAdd.Rows.Count - 1
                Dim dr As DataRow = dtRtDtCaseAdd.Rows(i)

                'Case 1: insert New Row
                AddSmSaleReturnJUDt(idReturnAV, dr, myCommand)

            Next
        End If

        'Case 2: Delete Row/Lot 
        Dim dtRtDtCaseDel As New DataTable

        myCommand.CommandText = "SELECT (SELECT idSaleReturn FROM SmSaleReturnMt Where idRtAVxST = " & idSaleReturn_ & ") As idSaleReturn , Amount, idUnit, idInvMain, idJUDt" & vbNewLine & _
                                "FROM SmSaleReturnJUDt" & vbNewLine & _
                                "Where idSaleReturn = " & idReturnAV & vbNewLine & _
                                "AND idInvMain Not IN ( SELECT idInvMain FROM SmSaleReturnJUDt WHERE idSaleReturn = " & idSaleReturn_ & ")"


        myAdapter.Fill(dtRtDtCaseDel)

        If dtRtDtCaseDel.Rows.Count > 0 Then
            For i As Integer = 0 To dtRtDtCaseDel.Rows.Count - 1
                Dim dr As DataRow = dtRtDtCaseDel.Rows(i)

                myCommand.CommandText = "DELETE SmSaleReturnJUDt " & vbNewLine & _
                                        "FROM SmSaleReturnJUDt " & vbNewLine & _
                                        "WHERE idJUDt = " & dr.Item("idJUDt")

                myCommand.ExecuteNonQuery()
            Next
        End If

        Dim dtSlDtCaseUpdate As New DataTable

        For i As Integer = 0 To GVNewPd.DataRowCount - 1

            Dim dr As DataRow = GVNewPd.GetDataRow(i)

            dtSlDtCaseUpdate.Clear()

            myCommand.CommandText = "SELECT idJUDt" & vbNewLine & _
                                    "FROM SmSaleReturnJUDt" & vbNewLine & _
                                    "WHERE idSaleReturn =  " & idReturnAV & " AND idInvMain = " & dr.Item("idInvMain")

            myAdapter.Fill(dtSlDtCaseUpdate)

            'Case 3: Row Update
            If Not IsDBNull(dr.Item("idJUDt")) Then
                myCommand.CommandText = "UPDATE SmSaleReturnJUDt SET " & vbNewLine & _
                                       "idSaleReturn = " & idReturnAV & "," & vbNewLine & _
                                       "Amount = " & CDbl(dr.Item("Amount")) & "," & vbNewLine & _
                                       "idUnit = " & dr.Item("idUnit") & "," & vbNewLine & _
                                       "idInvMain = " & dr.Item("idInvMain") & vbNewLine & _
                                       "WHERE idJUDt = " & dtSlDtCaseUpdate.Rows(0).Item("idJUDt")
                myCommand.ExecuteNonQuery()
            End If

        Next

    End Sub

    Private Function fnFindFormula(ByVal vCommand As SqlCommand, ByVal LotNo As String, ByVal idInvMain As Integer, ByVal idComp As Integer) As Integer
        Dim myAdapter As New SqlDataAdapter(vCommand)
        Dim idFL As Integer = 0

        Dim dtFl As New DataTable

        'Step 1: Find หาสูตร จาก LotNo, idInvMain และ CompRec เดิม
        vCommand.CommandText = "SELECT idFl " & vbNewLine & _
                               "FROM dInvLotMain " & vbNewLine & _
                               "WHERE idInvMain = " & idInvMain & vbNewLine & _
                               "AND CompRec = " & cmbGroupComp.SelectedValue & vbNewLine & _
                               "AND LotNo = '" & LotNo & "'" & vbNewLine & _
                               "AND stDel Is NULL"
        myAdapter.Fill(dtFl)


        If dtFl.Rows.Count = 0 Then
            'ไม่มีสูตรจาก Lot No. เดิม
            'Step 2: Find หาสูตรจาก idInvMain ที่มี stMain 
            dtFl.Clear()
            vCommand.CommandText = "SELECT idFl " & vbNewLine & _
                                   "FROM vInventoryFG As fg " & vbNewLine & _
                                   "LEFT JOIN SlPdFormula As fl ON fg.idPdT = fl.idPdT AND fl.stMain = 1" & vbNewLine & _
                                   "WHERE fg.idInvMain = " & idInvMain & vbNewLine & _
                                   "AND fl.idComp = " & cmbGroupComp.SelectedValue & vbNewLine & _
                                   "AND fl.idPsCancel IS NULL"
            myAdapter.Fill(dtFl)

            If dtFl.Rows.Count <> 0 Then
                'มีสูตร ที่เป็น stMain
                idFL = dtFl.Rows(0).Item("idFl")

            Else
                '---ไม่มี stMain ให้หาสูตรอื่นๆ เอา Row แรก
                'Step 3: Find หาสูตรจาก idInvMain ที่ไม่กำหนด stMain
                dtFl.Clear()
                vCommand.CommandText = "SELECT idFl " & vbNewLine & _
                                       "FROM vInventoryFG As fg " & vbNewLine & _
                                       "LEFT JOIN SlPdFormula As fl ON fg.idPdT = fl.idPdT " & vbNewLine & _
                                       "WHERE fg.idInvMain = " & idInvMain & vbNewLine & _
                                       "AND fl.idComp = " & cmbGroupComp.SelectedValue & vbNewLine & _
                                       "AND fl.idPsCancel IS NULL"
                myAdapter.Fill(dtFl)

                If dtFl.Rows.Count <> 0 Then
                    idFL = dtFl.Rows(0).Item("idFl")
                End If

            End If

        Else
            'มีสูตรจาก Lot No. เดิม
            idFL = dtFl.Rows(0).Item("idFl")
        End If

        Return idFL

    End Function

    Private Sub rptProductName_Click(sender As Object, e As EventArgs) Handles rptProductName.Click
        fnSelDataOfInvName()
    End Sub

    Private Sub rptProductName_KeyDown(sender As Object, e As KeyEventArgs) Handles rptProductName.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F5 Then
            fnSelDataOfInvName()
        End If
    End Sub

    Private Sub fnSelDataOfInvName()
        Dim navigator As ControlNavigator = GCReturn.EmbeddedNavigator

        If idPartner = 0 Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการเลือกสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Dim navigator As ControlNavigator = GCReturnMt.EmbeddedNavigator
        If GvReturn.FocusedRowHandle >= 0 Then
            navigator.Buttons.DoClick(navigator.Buttons.Edit)
        Else
            'ถ้า เป็น NewItemRow
            navigator.Buttons.DoClick(navigator.Buttons.Append)
            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
        End If

        fnSetDataOfInvName()

        If IsDBNull(GvReturn.GetRowCellValue(GvReturn.FocusedRowHandle, "idInvMain")) Then
            navigator.Buttons.DoClick(navigator.Buttons.Remove)
            Exit Sub
        End If
    End Sub
    Private Sub fnSetDataOfInvName()

        Dim vFrm As New frmAllInvSelect(frmAllInvSelect.eProcess.eAll, cmbGroupComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim LPriceDt As New DataTable
            LPriceDt.Clear()
            Dim ChkPrice As Double = 0.0

            sCommand.CommandText = "SELECT TOP 1 d.Price " & vbNewLine &
                                   "FROM SmSaleDtAll As d  " & vbNewLine &
                                   "LEFT JOIN SmSaleMt m ON d.idSale = m.idSale" & vbNewLine &
                                   "WHERE m.idPsCancel IS NULL " & vbNewLine &
                                   "AND m.idPartner = " & idPartner & "  " & vbNewLine &
                                   "AND d.Price > 0 " & vbNewLine &
                                   "AND d.idProduct = " & vFrm.sdt1.Rows(0).Item("idInvMain") & "  " &
                                   "Order BY m.DateSaleD DESC"

            sAdapter.Fill(LPriceDt)

            If LPriceDt.Rows.Count = 0 Then ' ไม่พบประวัติการขาย >>> check price list

                If Not IsDBNull(vFrm.sdt1.Rows(0).Item("PriceBill_fg")) Then

                    ChkPrice = vFrm.sdt1.Rows(0).Item("PriceBill_fg")

                ElseIf Not IsDBNull(vFrm.sdt1.Rows(0).Item("PricePdo_pdo")) Then

                    ChkPrice = vFrm.sdt1.Rows(0).Item("PricePdo_pdo")
                Else

                    ChkPrice = 0.0
                End If
            End If

            GvReturn.SetFocusedRowCellValue("PdCode", vFrm.sdt1.Rows(0).Item("InvCode"))
            GvReturn.SetFocusedRowCellValue("idInvMain", vFrm.sdt1.Rows(0).Item("idInvMain"))
            GvReturn.SetFocusedRowCellValue("InvName", vFrm.sdt1.Rows(0).Item("InvName"))
            GvReturn.SetFocusedRowCellValue("Amount", 1)
            GvReturn.SetFocusedRowCellValue("UnitName", vFrm.sdt1.Rows(0).Item("UnitName"))
            GvReturn.SetFocusedRowCellValue("idUnit", vFrm.sdt1.Rows(0).Item("idUnit"))
            GvReturn.SetFocusedRowCellValue("idInvGroup", vFrm.sdt1.Rows(0).Item("idInvGroup"))
            GvReturn.SetFocusedRowCellValue("idWh", idRTWh) 'use stType in SsWarehouse

            GvReturn.RefreshData()
            SumNewPd()

        End If
    End Sub

End Class