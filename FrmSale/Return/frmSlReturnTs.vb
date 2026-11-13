'---------------------------------------
'-------Pattaraporn Chuanchai-----------
'----Insert New Structure in 3 Cases----
'-------Edit Update 31.08.2562----------
'----10.05.2564 Send to SP WaitRec------
'----08.07.2564 Tab AND Key On Grid-----
'----25.12.2564 Auto Bill Return AV-ST--

Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors

Public Class frmSlReturnTs

    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")

    Private MainReturn As New DataTable
    Dim dtDel As New DataTable

    Dim Result As DialogResult
    Dim idSaleReturn_ As Integer = 0
    Dim DocCodeChk As String = ""
    Dim aProcess As eProcess

    Dim idRTWh As Integer = 0
    Dim idFm As Integer = 0
    Dim idPartner As Integer = 0
    Dim idCus As Integer = 0
    Dim stLoad As Integer = 0
    Dim chxCompany As Integer = 0
    Dim idRtAVxST As Integer = 0
    Enum eProcess
        eNewReturn
        eEdit
        eviewData
        eCancel
        eAccept
        eCheck
        eApprove
        eManageReject
        eNewRT151
        eEdit151
    End Enum

    Sub New(ByVal Process As eProcess, ByVal idSaleReturn As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case Process

            Case eProcess.eNewReturn
                Me.Text = "ทำรายการคืนสินค้า (รหัส 153)"
                cmbGroupComp.Enabled = True

            Case eProcess.eEdit
                Me.Text = "แก้ไขรายการคืนสินค้า (รหัส 153)"

            Case eProcess.eNewRT151
                Me.Text = "ทำรายการคืนสินค้า (รหัส 151)"
                ColWh.Visible = False
                'Me.bntPdSelect.Visible = True

                cmbGroupComp.Enabled = True

            Case eProcess.eEdit151
                Me.Text = "แก้ไขรายการคืนสินค้า (รหัส 151)"
                ColWh.Visible = False
                'Me.bntPdSelect.Visible = True

            Case eProcess.eviewData
                Me.Text = "ข้อมูลรายการคืนสินค้า"
                SetToolBox()
                SetToolBoxNotAddxEdit()

            Case eProcess.eCancel
                Me.Text = "ยกเลิกรายการคืนสินค้า"
                SetToolBox()
                btnDelete.Visible = True
                SetToolBoxNotAddxEdit()

            Case eProcess.eAccept
                Me.Text = "รับทราบ รายการคืนสินค้า"
                Me.btnProcess.Visible = True
                Me.btnProcess.Text = " รับทราบ"
                Me.btnProcess.Image = My.Resources.ResourceManager.GetObject("check_icon555")
                SetToolBox()
                SetToolBoxNotAddxEdit()

            Case eProcess.eCheck
                Me.Text = "ตรวจสอบ รายการคืนสินค้า"
                Me.btnProcess.Visible = True
                Me.btnProcess.Text = " ตรวจสอบ"
                Me.btnProcess.Image = My.Resources.ResourceManager.GetObject("clear_tick_icon")
                SetToolBox()
                SetToolBoxNotAddxEdit()

            Case eProcess.eApprove
                Me.Text = "อนุมัติ รายการคืนสินค้า"
                Me.btnProcess.Visible = True
                Panel7.Visible = True
                Me.btnProcess.Text = " บันทึกการอนุมัติ"
                Me.btnProcess.Image = My.Resources.ResourceManager.GetObject("iconcorrect16")
                SetToolBox()
                SetToolBoxNotAddxEdit()

            Case eProcess.eManageReject
                lblRejectCase.Visible = True
                lblRejectCase.Visible = True
                SetToolBoxNotAddxEdit()

        End Select

        idSaleReturn_ = idSaleReturn
        aProcess = Process
    End Sub

    Private Sub frmSlReturnTs_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

        setCmbGroupComp(Me.cmbGroupComp)
        ReturnCause()
        ReturnDocCode()

        initialDataTable(MainReturn)
        initialDataTable(dtDel)
        GCReturnMt.DataSource = MainReturn

        If aProcess = eProcess.eNewReturn Or aProcess = eProcess.eNewRT151 Then 'NewReturn 153/151     
            ' cmbWh.SelectedValue = 89 ' set default คลังตรวจสอบ
            Me.lblDateTs.Text = Date.Today
            Me.lblPsTs.Text = sPsName
            Me.lblPsTs.Tag = sPsId
            Me.txtDocRef.Focus()


            GCReturnMt.DataSource = MainReturn
        Else
            '*****Show data from SmSaleReturnMt******'
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()

            If Me.cmbDRCode.SelectedValue = 8 Then '151
                ColWh.Visible = False
            End If

            'Me.btnCustomer.Visible = False

        End If 'End stPage

        cmbWhOnGrid()
        stLoad = 1

    End Sub

    Private Sub SetToolBoxNotAddxEdit()
        btnCustomer.Visible = False
        cmbGroupComp.Enabled = False
        ColDocCode.OptionsColumn.ReadOnly = True
        ColLotno.OptionsColumn.ReadOnly = True
        ColProductName.OptionsColumn.ReadOnly = True
        ColAmtRT.OptionsColumn.ReadOnly = True
        ColUnitName.OptionsColumn.ReadOnly = True
        ColWh.OptionsColumn.ReadOnly = True
        ColPricePerUnit.OptionsColumn.ReadOnly = True
        ColRTPrice.OptionsColumn.ReadOnly = True
        ColRTValue.OptionsColumn.ReadOnly = True

        ColDocCode.OptionsColumn.AllowEdit = False
        ColLotno.OptionsColumn.AllowEdit = False
        ColProductName.OptionsColumn.AllowEdit = False
        ColAmtRT.OptionsColumn.AllowEdit = False
        ColUnitName.OptionsColumn.AllowEdit = False
        ColWh.OptionsColumn.AllowEdit = False
        ColPricePerUnit.OptionsColumn.AllowEdit = False
        ColRTPrice.OptionsColumn.AllowEdit = False
        ColRTValue.OptionsColumn.AllowEdit = False

    End Sub


    Private Sub SetToolBox()
        Me.cmbDRCode.Enabled = False
        Me.txtDocRef.Enabled = False
        Me.dtpReturn.Enabled = False
        Me.cmbCauseReturn.Enabled = False

        Me.btnPsSale.Visible = False
        Me.btnPsReturn.Visible = False
        ' Me.cmbWh.Enabled = False
        Me.txtNote.Enabled = False

        Me.btnSave.Visible = False
        If aProcess = eProcess.eCancel Then
            Me.btnDelete.Visible = True
        Else
            Me.btnDelete.Visible = False
        End If

        ColDel.Visible = False
        ColAmtRT.OptionsColumn.ReadOnly = True
        ColAmtRT.OptionsColumn.AllowEdit = False
        ColRTValue.OptionsColumn.ReadOnly = True
        ColRTValue.OptionsColumn.AllowEdit = False
        ColRTPrice.OptionsColumn.ReadOnly = True
        ColRTPrice.OptionsColumn.AllowEdit = False
        ColLotno.OptionsColumn.ReadOnly = True
        ColLotno.OptionsColumn.AllowEdit = False
        ColWh.OptionsColumn.ReadOnly = True
        ColWh.OptionsColumn.AllowEdit = False
        ColPricePerUnit.OptionsColumn.ReadOnly = True
        ColPricePerUnit.OptionsColumn.AllowEdit = False
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

        dataTable.Columns.Add("Price", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("RTValuePerc", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("RTPrice", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("Exp", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("DateGen", System.Type.GetType("System.String"))
        dataTable.Columns.Add("idUnit", System.Type.GetType("System.Int32"))
        dataTable.Columns.Add("BalanceRT", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("idSaleReturnDt", System.Type.GetType("System.Int32"))
        dataTable.Columns.Add("idLotReturn", System.Type.GetType("System.Int32"))
        dataTable.Columns.Add("idLotSale", System.Type.GetType("System.Int32"))

        dataTable.Columns.Add("AmountRTHide", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("LotNoHide", System.Type.GetType("System.String"))
        dataTable.Columns.Add("idWhHide", System.Type.GetType("System.Int32"))
        dataTable.Columns.Add("PriceHide", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("RTValueHide", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("RTValuePercHide", System.Type.GetType("System.Double"))
        'dataTable.Columns.Add("tempAmountRT", System.Type.GetType("System.Double"))
        dataTable.Columns.Add("idInvGroup", System.Type.GetType("System.Int32"))
    End Sub

    Private Sub BindData()
        Dim vDt As New DataTable
        vDt.Clear()


        sCommand.CommandText = "Select DocNum, idRTDocCode, DocRef, DateReturnD, idRtCause, p.PartnerName As CusName, mt.idPartner, IsNULL(mt.idCus,0) As idCus, ISNULL(mt.idFM,0) As idFM," & vbNewLine & _
                               "idPsSale, ISNULL(ps1.PsName, '-') As PsSale, idPsReturn, ISNULL(ps2.PsName,'-') As PsReturn, Total, Note, DateTsD, ps.PsName As PsTs, RejectNote, mt.idComp,  " & vbNewLine & _
                               "IsNULL(idRtAVxST, 0 ) As idRtAVxST" & vbNewLine & _
                               "From SmSaleReturnMt As mt " & vbNewLine & _
                               "LEFT JOIN vPersonxSelect ps ON mt.idPsTs = ps.idPs" & vbNewLine & _
                               "LEFT JOIN vPersonxSelect ps1 ON mt.idPsSale = ps1.idPs" & vbNewLine & _
                               "LEFT JOIN vPersonxSelect ps2 ON mt.idPsReturn = ps2.idPs" & vbNewLine & _
                               "LEFT JOIN dPartner p ON mt.idPartner = p.idPartner" & vbNewLine & _
                               "Where idSaleReturn = " & idSaleReturn_
        sAdapter.Fill(vDt)

        idRtAVxST = vDt.Rows(0).Item("idRtAVxST")



        cmbGroupComp.SelectedValue = vDt.Rows(0).Item("idComp")

        Me.lblDocNum.Text = vDt.Rows(0).Item("DocNum")
        Me.cmbDRCode.SelectedValue = vDt.Rows(0).Item("idRTDocCode")
        Me.txtDocRef.Text = vDt.Rows(0).Item("DocRef")
        Me.dtpReturn.Value = vDt.Rows(0).Item("DateReturnD")
        Me.cmbCauseReturn.SelectedValue = vDt.Rows(0).Item("idRtCause")
        Me.lblPsCus.Text = vDt.Rows(0).Item("CusName")
        lblPsCus.Tag = vDt.Rows(0).Item("idCus")

        idFm = vDt.Rows(0).Item("idFm")
        idPartner = vDt.Rows(0).Item("idPartner")
        idCus = vDt.Rows(0).Item("idCus")

        Me.lblPsSale.Text = vDt.Rows(0).Item("PsSale")
        Me.lblPsSale.Tag = vDt.Rows(0).Item("idPsSale")
        Me.lblPsReturn.Text = vDt.Rows(0).Item("PsReturn")
        Me.lblPsReturn.Tag = vDt.Rows(0).Item("idPsReturn")
        Me.lblDateTs.Text = vDt.Rows(0).Item("DateTsD")
        Me.lblPsTs.Text = vDt.Rows(0).Item("PsTs")
        Me.txtNote.Text = vDt.Rows(0).Item("Note")

        If Not IsDBNull(vDt.Rows(0).Item("RejectNote")) Then
            Me.lblRejectCase.Text = "สาเหตุ Reject: " & vDt.Rows(0).Item("RejectNote")
        End If

        '*****Show data from SmSaleReturnDt ******'
        MainReturn.Rows.Clear()
        'Dim ReturnDt As New DataTable
        'ReturnDt.Clear()
        sCommand.CommandText = "SELECT dt.idSaleReturnDt, sl.idSaleDt, dt.idLotSale, ISNULL(dt.idSale,0) As idSale, ISNULL(lm.DateGen,'') As DateGen, " & vbNewLine & _
                               "dt.LotNoRt As LotNo, dt.LotNoRt As LotNoHide, inv.InvName, ISNULL(dt.AmountReturn, 0.0) As AmountRT, inv.idInvGroup, " & vbNewLine & _
                               "ISNULL(dt.AmountReturn, 0.0) As AmountRTHide, unit.UnitName, dt.Price, dt.Price As PriceHide,  " & vbNewLine & _
                               "ISNULL(dt.RTValuePerc, 0.0) As RTValuePerc, ISNULL(dt.RTValuePerc, 0.0) As RTValuePercHide, " & vbNewLine & _
                               "ISNULL(dt.RTPrice, 0.00) As RTPrice, ISNULL(dt.RTPrice, 0.00) As RTPriceHide, (ISNULL(dt.AmountReturn,0.0) * ISNULL(dt.RTPrice, 0.00)) As Exp, " & _
                               "dt.idUnit, dt.idInvMain,  " & vbNewLine & _
                               "IsNULL(sl.Amount - ISNUll((Select SUM(rd.AmountReturn) " & vbNewLine & _
                                                     "From SmSaleReturnDt rd " & vbNewLine & _
                                                     "LEFT OUTER JOIN SmSaleReturnMt rm ON rd.idSaleReturn = rm.idSaleReturn " & vbNewLine & _
                                                     "WHERE rd.idSaleDt = dt.idSaleDt " & vbNewLine & _
                                                     "AND rm.idPsCancel IS NULL), 0.00),0) As BalanceRT,  " & vbNewLine & _
                               "ISNULL(dt.idWh,0) As idWh, ISNULL(dt.idWh,0) As idWhHide, dt.idLotReturn, dt.idInvMain, dt.idLot, inv.idUnit, IsNULL(smt.DocRef,'')  As DocRef" & vbNewLine & _
                               "FROM SmSaleReturnDt dt " & vbNewLine & _
                               "LEFT OUTER JOIN SmSaleDtAll sl ON dt.idSaleDt = sl.idSaleDt " & vbNewLine & _
                               "LEFT JOIN SmSaleReturnMt mt ON dt.idSaleReturn = mt.idSaleReturn" & vbNewLine & _
                               "LEFT JOIN dInvUnit unit ON dt.idUnit = unit.idUnit" & vbNewLine & _
                               "LEFT JOIN dInvLotMain lm ON dt.idLot = lm.idLot " & vbNewLine & _
                               "LEFT JOIN dInvLotRefWh As lot ON dt.idLot = lot.idLot And dt.idWh = lot.idWh" & vbNewLine & _
                               "LEFT JOIN dInventoryMain As inv ON dt.idInvMain = inv.idInvmain" & vbNewLine & _
                               "LEFT JOIN SmSaleMt As smt ON dt.idSale = smt.idSale" & vbNewLine & _
                               "WHERE dt.idSaleReturn = " & idSaleReturn_ & vbNewLine & _
                               "Order By dt.No ASC"

        sAdapter.Fill(MainReturn)

        GCReturnMt.DataSource = MainReturn

        GVReturnDt.ExpandAllGroups()
        SumTotal()
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

    Private Sub CheckCodeRefDup()
        mdCnOpen()
        mdLoadShow()

        '--- Check DocCode Dup ---'
        If Trim(Me.txtDocRef.Text) <> "" Then
            Dim CodeRef As String = Trim(Me.cmbDRCode.Text) & " " & Trim(Me.txtDocRef.Text)

            If CodeRef <> DocCodeChk Then
                '----Check DocRef -------'
                Dim dRefDt As New DataTable
                Dim vWHERE As String = ""

                If aProcess = eProcess.eEdit Then 'Edit
                    vWHERE = " AND idSaleReturn <> " & idSaleReturn_ & ""
                End If


                sCommand.CommandText = "select DocNum, DateReturnD, Concat(code.ReturnCode, ' ' ,mt.DocRef) As DocRefCode, p.PartnerName " & _
                                       "From SmSaleReturnMt mt  " & vbNewLine & _
                                       "LEFT JOIN SmSaleReturnCode As code ON mt.idRTDocCode = code.idRTDocCode" & vbNewLine & _
                                       "LEFT JOIN dPartner As p ON mt.idPartner = p.idPartner" & vbNewLine & _
                                       "Where idPscancel IS NULL AND idComp = " & cmbGroupComp.SelectedValue & " " & vWHERE
                sAdapter.Fill(dRefDt)

                For i As Integer = 0 To dRefDt.Rows.Count - 1
                    Dim test As String = CodeRef & "/" & dRefDt.Rows(i).Item("DocRefCode")
                    If CodeRef = dRefDt.Rows(i).Item("DocRefCode") Then
                        mdLoadCommitt()
                        DocCodeChk = ""
                        MessageBox.Show("เลขที่อ้างอิงซ้ำกับข้อมูลเดิม รายละเอียดรายการดังนี้ " & vbCrLf & "เลขที่รายการ : " & dRefDt.Rows(i).Item("DocNum") & vbCrLf & _
                            "วันที่คืนสินค้า : " & dRefDt.Rows(i).Item("DateReturnD") & vbCrLf & _
                            "ชื่อลูกค้า : " & dRefDt.Rows(i).Item("PartnerName"), sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Me.txtDocRef.Focus()
                        Exit Sub
                    End If
                Next

                DocCodeChk = CodeRef
            End If
        End If

        mdLoadCommitt()
    End Sub

    Private Sub cmbDRCode_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbDRCode.SelectedValueChanged

        If stLoad = 1 And (aProcess = eProcess.eNewReturn Or aProcess = eProcess.eEdit Or aProcess = eProcess.eNewRT151 Or aProcess = eProcess.eEdit151) Then ' New / Edit
            CheckCodeRefDup()
        End If
    End Sub

    Private Sub txtDocRef_Leave(sender As Object, e As EventArgs) Handles txtDocRef.Leave
        If stLoad = 1 And (aProcess = eProcess.eNewReturn Or aProcess = eProcess.eEdit Or aProcess = eProcess.eNewRT151 Or aProcess = eProcess.eEdit151) Then ' New / Edit
            CheckCodeRefDup()
        End If
    End Sub

    Private Sub txtDocRef_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDocRef.KeyDown
        If e.KeyCode = Keys.Enter Then
            If stLoad = 1 And (aProcess = eProcess.eNewReturn Or aProcess = eProcess.eEdit Or aProcess = eProcess.eNewRT151 Or aProcess = eProcess.eEdit151) Then ' New / Edit
                CheckCodeRefDup()
            End If
        End If
    End Sub


    Private Sub cmbWhOnGrid()

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

        rptWareHouse.Columns.Clear()
        rptWareHouse.Columns.Add(New LookUpColumnInfo("WareHouseName"))
        rptWareHouse.DataSource = sDt

        rptWareHouse.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        ' Specify the dropdown height.
        rptWareHouse.DropDownRows = sDt.Rows.Count
    End Sub

    Private Sub ReturnDocCode()
        'mdCnOpen()
        Dim sDt As New DataTable
        If aProcess = eProcess.eNewReturn Then
            sCommand.CommandText = "Select idRTDocCode, ReturnCode From SmSaleReturnCode WHERE idRTDocCode = 1 "

        ElseIf aProcess = eProcess.eNewRT151 Then
            sCommand.CommandText = "Select idRTDocCode, ReturnCode From SmSaleReturnCode WHERE idRTDocCode = 8 "

        Else

            sCommand.CommandText = "Select idRTDocCode, ReturnCode From SmSaleReturnCode WHERE (idRTDocCode = 1 OR idRTDocCode = 8)"
        End If

        sAdapter.Fill(sDt)

        With cmbDRCode
            .DisplayMember = "ReturnCode"
            .ValueMember = "idRTDocCode"
            .DataSource = sDt
        End With
    End Sub

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        chxCompany = 0
        If GVReturnDt.DataRowCount > 0 Then


            Dim result As DialogResult = MessageBox.Show("ระบบจะทำการลบรายการคืนสินค้าทั้งหมด" & vbCrLf & "ยืนยันจะเปลี่ยนแปลงชื่อลูกค้าใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If result = Windows.Forms.DialogResult.Yes Then
                lblPsCus.Text = ""
                lblPsCus.Tag = 0
                lblPsSale.Text = ""
                lblPsReturn.Text = ""
                txtTotal.Text = 0
                txtCntReturn.Text = 0
                Me.lblPsSale.Tag = 0
                idPartner = 0

                fnKeptDataForRTStk()

                MainReturn.Clear()

            Else
                Exit Sub
            End If

            SumTotal()
        End If

        Dim tempWh As New DataTable
        tempWh.Clear()

        mdCnOpen()
        Dim idComp As Integer = cmbGroupComp.SelectedValue

        If idComp = 10 Then
            idComp = 4
        End If
        sCommand.CommandText = "SELECT idWh FROM SsWarehouse WHERE idComp = " & idComp & " AND stType = 1 AND stDel = 0" 'คลังรับคืน
        sAdapter.Fill(tempWh)

        If tempWh.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูลคลังรับคืนของบริษัทนี้ " & vbNewLine & "กรุณาเพิ่มคลังที่ระบบ WIM ก่อนทำรายการรับคืน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            idRTWh = tempWh.Rows(0).Item("idWh")
        End If

        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelectAllChkSt, cmbGroupComp.SelectedValue)

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            idFm = vFrm.idFm
            idPartner = vFrm.idPartner
            idCus = vFrm.idCus
            Me.lblPsCus.Tag = vFrm.idCus

            Me.lblPsCus.Text = vFrm.CusName
        End If

    End Sub

    Private Sub fnKeptDataForRTStk()

        For i As Integer = 0 To MainReturn.Rows.Count - 1
            Dim dr As DataRow = MainReturn.Rows(i)

            Dim drtemp As DataRow = dtDel.NewRow()

            If Not IsDBNull(dr.Item("idSaleReturnDt")) Then
                drtemp("idSaleReturnDt") = dr.Item("idSaleReturnDt")
                drtemp("idWh") = dr.Item("idWh")
                drtemp("idInvMain") = dr.Item("idInvMain")
                drtemp("idLot") = dr.Item("idLot")
                drtemp("LotNo") = dr.Item("LotNo")
                drtemp("AmountRT") = dr.Item("AmountRT")
                drtemp("idInvGroup") = dr.Item("idInvGroup")
                drtemp("idUnit") = dr.Item("idUnit")
                dtDel.Rows.Add(drtemp)
            End If

            dtDel.AcceptChanges()
        Next

    End Sub


    Private Sub lblPsCus_TextChanged(sender As Object, e As EventArgs) Handles lblPsCus.TextChanged
        If stLoad = 1 And chxCompany = 0 Then

            Dim dt As New DataTable
            Dim Dt2 As New DataTable
            'PsCustomer = Me.lblPsCus.Text
            'idPsCus = Me.lblPsCus.Tag
            dt.Clear()
            'sCommand.CommandText = "Select m.idPs, p.PsName " & vbNewLine & _
            '                        "From SmMkCusPs m " & vbNewLine & _
            '                        "LEFT JOIN vPersonxSelect p ON m.idPs = p.idPs " & _
            '                        "Where m.idComp = " & cmbGroupComp.SelectedValue & _
            '                        "AND m.idCus = (SELECT idCus FROM dPartner Where idPartner = " & idPartner & ")"

            'sCommand.CommandText = "SELECT p.PsName, ds.idPsSale As idPs  " & vbNewLine & _
            '                        "FROM SmMkCusPs ps" & vbNewLine & _
            '                        "LEFT JOIN SmRegionPsSaleSet As s ON ps.idRegion = s.idRegion" & vbNewLine & _
            '                        "LEFT JOIN dPsSalecompSet As ds ON s.idPsComSet = ds.idPsComSet AND ps.idComp = ds.idComp" & vbNewLine & _
            '                        "LEFT JOIN vPersonxSelect p ON ds.idPsSale = p.idPs" & vbNewLine & _
            '                        "WHERE ds.idComp = " & cmbGroupComp.SelectedValue & vbNewLine & _
            '                        "AND ps.idCus = (SELECT idCus FROM dPartner Where idPartner = " & idPartner & ")"
            'sAdapter.Fill(dt)

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
            Else
                If dt.Rows.Count <> 0 Then
                    '---- มีพนักงานขายหลายคน
                    Dim PsSaleList As String = ""
                    For i As Integer = 0 To dt.Rows.Count - 1
                        If i = 0 Then
                            PsSaleList = dt.Rows(i).Item("PsName")
                        Else
                            PsSaleList = PsSaleList & ", " & dt.Rows(i).Item("PsName") & " "
                        End If
                    Next
                    MessageBox.Show("ลูกค้าคนนี้มีข้อมูลผูกกับพนักงานขายหลายคน ได้แก่ " & PsSaleList & "ระบบจะดึงพนักงานขายที่มีประวัติการขายกับลูกค้าครั้งล่าสุด", _
                                    sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Else 'ไม่มีพนักงานขาย
                    MessageBox.Show("ลูกค้าคนนี้ไม่มีข้อมูลผูกกับพนักงานขาย ระบบจะดึงพนักงานขายที่มีประวัติการขายกับลูกค้าครั้งล่าสุด", _
                                    sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Dt2.Clear()
                sCommand.CommandText = "SELECT mt.idPsSale, p.PsName As PsSale " & vbNewLine & _
                                       "FROM SmSaleMt mt" & vbNewLine & _
                                       "LEFT JOIN vPersonxSelect As p ON mt.idPsSale = p.idPs" & vbNewLine & _
                                       "Where mt.idComp = " & cmbGroupComp.SelectedValue & "  " & vbNewLine & _
                                       "AND mt.idPartner = " & idPartner & vbNewLine & _
                                       "ORDER By idSale DESC"
                sAdapter.Fill(Dt2)

                If Dt2.Rows.Count <> 0 Then
                    Me.lblPsSale.Tag = Dt2.Rows(0).Item("idPsSale")
                    Me.lblPsSale.Text = Dt2.Rows(0).Item("PsSale")
                Else
                    MessageBox.Show("ลูกค้าคนนี้ไม่มีข้อมูลผูกกับพนักงานขาย และไม่มีประวัติการขายสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
            'End If

        End If

    End Sub

    Private Sub lblPsSale_TextChanged(sender As Object, e As EventArgs) Handles lblPsSale.TextChanged
        If stLoad = 1 Then
            If Me.lblPsSale.Text <> "" Then
                Me.lblPsReturn.Tag = Me.lblPsSale.Tag
                Me.lblPsReturn.Text = Me.lblPsSale.Text
            End If
        End If
    End Sub

    Private Sub btnPsSale_Click(sender As Object, e As EventArgs) Handles btnPsSale.Click
        If Me.lblPsCus.Text = "" Then
            Dim vFrm As New frmPsSaleSelect(frmPsSaleSelect.eProcess.eNormal, Nothing, Me.lblPsCus.Text, Me.lblPsCus.Tag, 1, cmbGroupComp.SelectedValue)
            'vFrm.GetidComp(cmbGroupComp.SelectedValue)
            ' vFrm.ShowText(Me.lblPsCus.Text, Me.lblPsCus.Tag, 1) 'No Customer
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                lblPsSale.Tag = vFrm.idPs
                lblPsSale.Text = vFrm.SaleName

            End If
        Else
            Dim vFrm As New frmPsSaleSelect(frmPsSaleSelect.eProcess.eNormal, Nothing, Me.lblPsCus.Text, Me.lblPsCus.Tag, 0, cmbGroupComp.SelectedValue)
            'vFrm.GetidComp(cmbGroupComp.SelectedValue)
            'vFrm.ShowText(Me.lblPsCus.Text, Me.lblPsCus.Tag, 0) 'have Customer
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                lblPsSale.Tag = vFrm.idPs
                lblPsSale.Text = vFrm.SaleName
            End If
        End If
    End Sub

    Private Sub SumcolAmountExp()

        If GVReturnDt.FocusedRowHandle >= 0 Then
            Dim SumRow As Double = GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColRTPrice) * GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColAmtRT)
            GVReturnDt.SetRowCellValue(GVReturnDt.FocusedRowHandle, ColExp, SumRow)
        End If

    End Sub

    Private Sub SumTotal()
        Dim Total As Double = 0.0
        Dim CntReturn As Integer = 0

        For i As Integer = 0 To GVReturnDt.DataRowCount - 1
            Total += GVReturnDt.GetDataRow(i).Item("Exp")
            CntReturn += GVReturnDt.GetDataRow(i).Item("AmountRT")
        Next

        txtTotal.Text = Format(Total, "#,##0.00##")
        txtCntReturn.Text = Format(CntReturn, "#,##0")
    End Sub

    Private Sub btnPsReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPsReturn.Click
        Dim vFrm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPsReturn.Tag = vFrm.mId
            Me.lblPsReturn.Text = vFrm.mName
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

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
            'ElseIf Me.txtNote.Text = "" Then
            '    MessageBox.Show("กรุณาระบุสาเหตุการคืนสินค้า", sSystemName)
            '    Me.txtNote.Focus()
            '    Exit Sub
        ElseIf Me.GVReturnDt.RowCount = 0 Then
            MessageBox.Show("กรุณาเลือกรายการคืนสินค้าอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            If aProcess = eProcess.eNewReturn Or aProcess = eProcess.eEdit Then 'New/Edit 153
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
            End If

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

                    If aProcess = eProcess.eNewReturn Or aProcess = eProcess.eNewRT151 Then 'New

                        '------------(1) Call Stored Procedure Add SmSaleReturn -----------------
                        'Dim idSaleReturn As Integer = 0
                        'idSaleReturn = ADDxEditSmSaleReturnMt_SP(mycommand, 0) 'eNewReturn

                        'If GVReturnDt.DataRowCount > 0 Then 'มีรายการคืนสินค้า

                        '    For i As Integer = 0 To GVReturnDt.DataRowCount - 1
                        '        Dim dr As DataRow = GVReturnDt.GetDataRow(i)

                        '        ADDSmSaleReturnDt_SP(mycommand, idSaleReturn, dr)
                        '    Next
                        'End If

                        'mycommand.CommandText = "EXECUTE WaitRecieveTs '2','SmSaleReturnMt','SmSaleReturnDt','idSaleReturn'," & idSaleReturn & "," & _
                        '                        cmbGroupComp.SelectedValue & " ," & sPsId & " ,'1'"

                        'mycommand.ExecuteNonQuery()

                        '---------------------(1) END Add SmSaleReturn --------------------------

                        '-----------------*[1]* Add SmSaleRerunMt/Dt Cut Stock-------------------
                        Dim idSaleReturn As Integer = 0

                        Dim idComp = cmbGroupComp.SelectedValue

                        If idComp = 10 Then
                            idComp = 4
                        End If

                        If cmbGroupComp.SelectedValue = 10 Then

                            idSaleReturn = fnRTBtwSTxAV(mycommand)
                        Else

                            idSaleReturn = ADDxEditSmSaleReturnMt(mycommand, 0, idComp, idPartner, idCus, idFm, lblPsReturn.Tag, lblPsSale.Tag, Trim(txtDocRef.Text))

                            If idSaleReturn = 0 Then

                                Exit Sub
                            Else

                                If GVReturnDt.DataRowCount > 0 Then 'มีรายการคืนสินค้า'----ADD Data to SmSaleReturnDt-----'
                                    For i As Integer = 0 To GVReturnDt.DataRowCount - 1
                                        Dim dr As DataRow = GVReturnDt.GetDataRow(i)
                                        AddSmSaleReturnDt(idSaleReturn, dr, mycommand, "SAM-5", i + 1, idComp)
                                    Next
                                End If

                            End If
                        End If

                        '------------------------*[1]* END ---------------------------------------

                    Else ' edit / ManageReject
                        Dim TextCardNote As String = "SAM-6"

                        If aProcess = eProcess.eManageReject Then ' ManageReject
                            mycommand.CommandText = "Update SmSaleReturnMt Set idPsAccept = NULL, DateAccept = NULL, idPsCheck = NULL, " & _
                                                    "DateCheck = NULL, stApp = NULL, idPsApprove = NULL, DateApprove = NULL, RejectNote = NULL " & _
                                                    "WHERE idSaleReturn = " & idSaleReturn_
                            mycommand.ExecuteNonQuery()

                            TextCardNote = "SAM-9"
                        End If

                        '--------------*[2]* EditSmSaleReturnMt/Dt Cut Stock-------------------
                        EditSmSaleReturnDt(mycommand, idSaleReturn_)

                        Dim dtidReturnAV As New DataTable
                        mycommand.CommandText = "SELECT idSaleReturn As idSaleReturnAV FROM SmSaleReturnMt WHERE idRtAVxST = " & idSaleReturn_
                        myAdapter.Fill(dtidReturnAV)

                        If dtidReturnAV.Rows.Count > 0 Then
                            EditRtAVxStar(mycommand, dtidReturnAV.Rows(0).Item("idSaleReturnAV"))
                        End If


                        '---------------------*[2]* END ---------------------------------------

                        '------------(2) Call Stored Procedure Edit SmSaleReturnMt/Dt ---------
                        'Dim idSaleReturn As Integer = 0
                        'idSaleReturn = ADDxEditSmSaleReturnMt_SP(mycommand, idSaleReturn_) 'Update SmSaleReturnMt
                        'EditSmSaleReturnDt_SP(mycommand, idSaleReturn) 'Update SmSaleReturnDt


                        'mycommand.CommandText = "SELECT ISNULL([devsk].[WimCheckstUseRecieveWait] (" & idSaleReturn & " , 2) ,0) As stRec"
                        'Dim stRec As Integer = mycommand.ExecuteScalar

                        'If stRec = 1 Then
                        '    MessageBox.Show("รายการนี้ถูกรับของเข้าคลังแล้ว ไม่สามารถแก้ไขได้", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        '    Exit Sub
                        'Else
                        '    mycommand.CommandText = "EXECUTE WaitRecieveTsEdit '2','SmSaleReturnMt','SmSaleReturnDt','idSaleReturn'," & idSaleReturn & "," & _
                        '                            cmbGroupComp.SelectedValue & " ," & sPsId & " ,'2'"

                        '    mycommand.ExecuteNonQuery()
                        'End If
                        '-------------------(2) END Edit SmSaleReturnMt/Dt -----------------
                    End If

                    ' Attempt to commit the transaction.
                    mytransaction.Commit()
                    mdLoadCommitt()
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
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
                ADDSmSaleReturnDtxNoAddStock(mycommand, dtRtDtCaseAdd.Rows(i).Item("idReturnAV"), dr, GVReturnDt.DataRowCount + 1)
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
        For i As Integer = 0 To GVReturnDt.DataRowCount - 1

            Dim dr As DataRow = GVReturnDt.GetDataRow(i)

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
    '-------------------- GEN DocNum --------------------'
    Function getDocNum(ByVal Prefixcode As String, ByVal vCommand As SqlCommand) As String
        Dim vAdapter = New SqlDataAdapter(vCommand)
        Dim DocNum As String = ""
        Dim nextOrder As String = ""
        Dim CodeYear As String = ""

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

    Private Function AddSmSaleReturnMt(ByVal vCommand As SqlCommand) As Integer
        Dim idSaleReturn As Integer = 0
        Dim Prefixcode As String = ""

        Dim YearRT As Integer = dtpReturn.Value.Year

        If YearRT < 2500 Then
            YearRT = YearRT + 543
        End If

        Dim getDate As String = CType(YearRT, String)

        Dim DocNum As String = ""

        Prefixcode = (Microsoft.VisualBasic.Right(getDate, 2))
        DocNum = getDocNum(Prefixcode, vCommand)

        'Dim YearRT As Integer = dtpReturn.Value.Year
        Dim MonthRT As Integer = dtpReturn.Value.Month
        ' mdCnOpen()
        'Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
        Dim dtpReturnCvt As DateTime = Convert.ToDateTime(dtpReturn.Value, _cultureEnInfo)

        Dim stridCus As String = ""
        Dim qidCus As String = ""
        If idFm = 0 And lblPsCus.Tag <> 0 Then
            'Case เป็น Customer อย่างเดียว
            stridCus = "idCus"
            qidCus = lblPsCus.Tag
        ElseIf lblPsCus.Tag = 0 And idFm <> 0 Then
            'Case เป็น Farmer อย่างเดียว
            stridCus = "idFm"
            qidCus = idFm

        ElseIf lblPsCus.Tag <> 0 And idFm <> 0 Then
            'Case เป็นทั้ง Customer และ Farmer 
            stridCus = "idCus, idFm"
            qidCus = lblPsCus.Tag & "," & idFm
        End If


        Dim query As String = "Insert Into SmSaleReturnMt(DocNum, YearRT, MonthRT, DateReturnD, idRTDocCode, DocRef, " & stridCus & ", " &
                               "idRtCause, idPsSale, Total, idPsReturn, idPsTs, DateTsD, Note, idComp, idPartner) " &
                               "Values('" & DocNum & "', " & YearRT & ", " & MonthRT & ", " &
                               "'" & dtpReturnCvt.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "'," & Me.cmbDRCode.SelectedValue & ", " &
                               "'" & Trim(txtDocRef.Text) & "', " & qidCus & ", " & Me.cmbCauseReturn.SelectedValue & ", " &
                               "" & lblPsSale.Tag & ", " & CDbl(txtTotal.Text) & ", " & lblPsReturn.Tag & ", " &
                               "" & sPsId & ", GETDATE(), '" & Trim(Me.txtNote.Text) & "', " & cmbGroupComp.SelectedValue & "," & idPartner & ")"
        vCommand.ExecuteNonQuery()

        vCommand.CommandText = query

        Dim query2 As String = "Select @@Identity"
        vCommand.ExecuteNonQuery()
        vCommand.CommandText = query2
        idSaleReturn = vCommand.ExecuteScalar()

        Return idSaleReturn
    End Function

    Private Sub AddSmSaleReturnDt(ByVal idSaleReturn As Integer, ByVal dr As DataRow, ByVal vCommand As SqlCommand, _
                                  ByVal CardNote As String, ByVal i As Integer, ByVal idComp As Integer)

        Dim vAdapter = New SqlDataAdapter(vCommand)
        '---insert SmSaleReturnDt Table---'
        Dim AmountRT As Double = fnCalAmtxUnit(vCommand, dr.Item("idUnit"), dr.Item("idInvGroup"), dr.Item("AmountRT"), dr.Item("idInvMain"))
        Select Case aProcess
            Case eProcess.eNewReturn, eProcess.eEdit '---- 153 ----'

                '-----------Cut Stock Card-----------------
                Dim idLotReturn As Integer = 0
                Dim idSaleReturnDt As Integer = 0

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
                    vCommand.CommandText = "Select idLot FROM dInvLotMain WHERE LotNo = '" & dr.Item("LotNo") & "' AND idInvMain = " & dr.Item("idInvMain") & " AND CompRec = " & cmbGroupComp.SelectedValue & " AND stDel Is NULL"
                    vAdapter.Fill(dtLot)

                    If dtLot.Rows.Count > 0 Then
                        dr.Item("idLot") = dtLot.Rows(0).Item("idLot")
                    End If
                End If

                Dim strDt As String = "Insert Into SmSaleReturnDt(No, idSaleReturn, idSale, idSaleDt, idLotSale, AmountReturn, " &
                                          "Price, RTValuePerc, RTPrice, idUnit, idWh, LotNoRT, idInvMain, idLot) " &
                                          "Values(" & i & "," & idSaleReturn & ", " & dr.Item("idSale") & ", " &
                                          "" & dr.Item("idSaleDt") & ", " &
                                          "" & dr.Item("idLot") & ", " &
                                          "" & CDbl(dr.Item("AmountRT")) & ", " &
                                          "" & CDbl(dr.Item("Price")) & ", " & CDbl(dr.Item("RTValuePerc")) & ", " &
                                          "" & CDbl(dr.Item("RTPrice")) & ", '" & dr.Item("idUnit") & "', " &
                                          "" & dr.Item("idWh") & ", '" & dr.Item("LotNo") & "'," &
                                          "" & dr.Item("idInvMain") & "," & dr.Item("idLot") & ")"

                vCommand.CommandText = strDt

                Dim query4 As String = "Select @@Identity"
                vCommand.ExecuteNonQuery()
                vCommand.CommandText = query4
                idSaleReturnDt = vCommand.ExecuteScalar()

                '--------------- IN New Structure --------------
                'idInvMain <> 9766
                If dr.Item("idInvMain") <> 9766 Then
                    'No idLot In Old Structure
                    If dr.Item("idLot") = 0 Then
                        Dim idlotxInv As Integer = 0

                        Dim strFl As String = ""
                        Dim strQFl As String = ""

                        If dr.Item("idInvGroup") = 2 Then
                            Dim idFL As Integer = fnFindFormula(vCommand, dr.Item("LotNo"), dr.Item("idInvMain"), cmbGroupComp.SelectedValue)

                            If idFL <> 0 Then
                                strFl = ", idFl"
                                strQFl = "," & idFL
                            End If

                        End If

                        '------------New Structure------------
                        '--Case 1: No idLot---
                        '------Insert New idLot in dInvLotMain
                        Dim str As String = "INSERT INTO dInvLotmain (idInvMain, LotNo, DateGen, CompRec, idPsUpDate, DateUpDate, Cost, CostPerUnit,  idLotOldSys" & strFl & ")" &
                                            " VALUES (" & dr.Item("idInvMain") & ",'" & dr.Item("LotNo") & "', GETDATE(), " &
                                            "" & idComp & ", " & sPsId & ", GETDATE(), " & dr.Item("Exp") & "," & dr.Item("RTPrice") & "," & idLotReturn & strQFl & ")"
                        vCommand.CommandText = str

                        Dim query As String = "Select @@Identity"
                        vCommand.ExecuteNonQuery()
                        vCommand.CommandText = query
                        idlotxInv = vCommand.ExecuteScalar()

                        '------Insert Amount return and Warehouse in dInvLotRefWh
                        vCommand.CommandText = "INSERT INTO dInvLotRefWh(idLot, idWh, AmountRec, Amount, idUnit, CostDt) Values(" & idlotxInv & ", " &
                                        dr.Item("idWh") & "," & AmountRT & "," & AmountRT &
                                        "," & dr.Item("idUnit") & ",0.00)"
                        vCommand.ExecuteNonQuery()


                        '------Stockcard-Inventory    Dim AmountRTHide As Double = fnCalAmtxUnit(xCommand, dr.Item("idUnit"), dr.Item("idInvGroup"), dr.Item("AmountRTHide"), dr.Item("idInvMain"))

                        InvLotStockCard(1, dr.Item("idInvMain"), idlotxInv, AmountRT, CDbl(0),
                                    "เมนู" & Me.Text, idSaleReturn, "SAM", "SmSaleReturnMt", dr.Item("LotNo"), dr.Item("idWh"), vCommand)


                        vCommand.CommandText = "UPDATE SmSaleReturnDt SET idLot = " & idlotxInv & ", idLotReturn = " & idlotxInv & " WHERE idSaleReturnDt = " & idSaleReturnDt
                        vCommand.ExecuteNonQuery()


                    ElseIf dr.Item("idLot") <> 0 Then
                        '-- Check lot ว่า มีอยู่แล้วในคลังที่เลือกไหม --'
                        Dim LotWh As New DataTable

                        vCommand.CommandText = "SELECT idRefLot FROM dInvLotRefWh WHERE idLot = " & dr.Item("idLot") & vbNewLine &
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
                            vCommand.CommandText = "UPDATE dInvLotRefWh SET AmountRec = ISNULL(AmountRec,0) + " & AmountRT & vbNewLine &
                              "WHERE idLot =  " & dr.Item("idLot") & " AND idWh = " & dr.Item("idWh")
                            vCommand.ExecuteNonQuery()

                            'Call InvLotMainUpdate for add Amount before call stockcard
                            InvLotMainUpdate(1, dr.Item("idInvMain"), dr.Item("idLot"), AmountRT,
                                         "เมนู" & Me.Text, idSaleReturn, "SAM", "SmSaleReturnMt", dr.Item("LotNo"), dr.Item("idWh"), vCommand)

                        Else
                            '----2.2 Return Other Warehouse----
                            ' Sum Amount ก่อน Insert ตัวใหม่เข้าไป
                            Dim sDt As New DataTable
                            vCommand.CommandText = "SELECT Sum(Amount) As Amount FROM dInvLotRefWh WHERE idLot = " & dr.Item("idLot")
                            vAdapter.Fill(sDt)

                            Dim AmountLot As Double
                            If IsDBNull(sDt.Rows(0).Item("Amount")) Then
                                AmountLot = 0
                            Else
                                AmountLot = sDt.Rows(0).Item("Amount")
                            End If

                            '----2.2 Return Other Warehouse----
                            'Insert old idLot that has new idWh
                            vCommand.CommandText = "INSERT INTO dInvLotRefWh(idLot, idWh, AmountRec, Amount, idUnit, CostDt) Values(" & dr.Item("idLot") &
                                                ", " & dr.Item("idWh") & "," & AmountRT & "," & AmountRT & "," & dr.Item("idUnit") & ",0.00)"

                            vCommand.ExecuteScalar()

                            InvLotStockCard(1, dr.Item("idInvMain"), dr.Item("idLot"), AmountRT,
                                            CDbl(AmountLot), "เมนู" & Me.Text, idSaleReturn, "SAM", "SmSaleReturnMt", dr.Item("LotNo"),
                                            dr.Item("idWh"), vCommand)
                        End If
                    End If
                End If


            Case eProcess.eNewRT151, eProcess.eEdit151 '---- 151 ----'

                vCommand.CommandText = "Insert Into SmSaleReturnDt(No, idSaleReturn, idSale, idSaleDt, idLot, AmountReturn, " &
                                       "Price, RTValuePerc, RTPrice, idUnit, LotNoRT, idInvMain) " &
                                       "Values(" & i & "," & idSaleReturn & ", " & dr.Item("idSale") & ", " &
                                       "" & dr.Item("idSaleDt") & ", " & dr.Item("idLot") & ", " &
                                       "" & CDbl(dr.Item("AmountRT")) & ", " &
                                       "" & CDbl(dr.Item("Price")) & ", " & CDbl(dr.Item("RTValuePerc")) & ", " &
                                       "" & CDbl(dr.Item("RTPrice")) & ", '" & dr.Item("idUnit") & "', " &
                                       "'" & dr.Item("LotNo") & "'," & dr.Item("idInvMain") & ")"
                vCommand.ExecuteNonQuery()
        End Select

    End Sub

    Private Sub EditSmSaleReturnDt(ByVal xCommand As SqlCommand, ByVal idSaleReturn As Integer)

        Dim xAdapter = New SqlDataAdapter(xCommand)
        '----Update SmSaleReturnMt-------------------------------------------------
        Dim dtpReturnCvt As DateTime = Convert.ToDateTime(dtpReturn.Value, _cultureEnInfo)
        Dim MonthRT As Integer = CType(dtpReturn.Value.Month, Integer)
        Dim stridCus As String = ""

        Dim YearRT As Integer = dtpReturn.Value.Year

        If YearRT < 2500 Then
            YearRT = YearRT + 543
        End If

        '------------Edit Cut Stock Verson--------------
        'If idFm = 0 Then
        '    stridCus = "idCus = " & idCus & ", idFm = NULL, idPartner = " & idPartner

        'ElseIf idCus = 0 Then

        '    stridCus = "idCus = NULL, idFm = " & idFm & ", idPartner = " & idPartner
        'End If

        If idFm = 0 And idCus <> 0 Then
            stridCus = "idCus = " & lblPsCus.Tag & ", idFm = NULL, idPartner = " & idPartner

        ElseIf idFm <> 0 And idCus = 0 Then

            stridCus = "idCus = NULL, idFm = " & idFm & ", idPartner = " & idPartner

        ElseIf idFm <> 0 And idCus <> 0 Then
            stridCus = "idCus = " & lblPsCus.Tag & ", idFm = " & idFm & ", idPartner = " & idPartner
        End If

        xCommand.CommandText = "Update SmSaleReturnMt Set DocNum = '" & Trim(Me.lblDocNum.Text) & "', YearRT = " & YearRT & ", MonthRT = " & MonthRT & ", " &
                               "DateReturnD = '" & dtpReturnCvt.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "'," &
                               "idRTDocCode = " & Me.cmbDRCode.SelectedValue & ", DocRef = '" & Trim(txtDocRef.Text) & "', " &
                               stridCus & ", idRtCause = " & Me.cmbCauseReturn.SelectedValue & ", " &
                               "idPsSale = " & lblPsSale.Tag & ", Total = " & CDbl(txtTotal.Text) & ", idPsReturn = " & lblPsReturn.Tag & ", " &
                               "idPsTs = " & sPsId & ", DateTsD = GETDATE(), " &
                               "Note = '" & Trim(Me.txtNote.Text) & "', idComp = " & cmbGroupComp.SelectedValue & " WHERE idSaleReturn = " & idSaleReturn_


        xCommand.ExecuteNonQuery()


        '-------------------------------------------------------------------------
        'Case 2: Row Delete
        If dtDel.Rows.Count > 0 Then
            For j As Integer = 0 To dtDel.Rows.Count - 1
                Dim drDel As DataRow = dtDel.Rows(j)
                If drDel.Item("idInvMain") <> 9766 Then
                    'xCommand.CommandText = "UPDATE dInvLotRefWh SET AmountRec = ISNULL(AmountRec,0) - " & CDbl(drDel.Item("AmountRT")) & vbNewLine & _
                    '                                          "WHERE idLot =  " & drDel.Item("idLot") & " AND idWh = " & drDel.Item("idWh")
                    'xCommand.ExecuteNonQuery()

                    '----คืนสต๊อก เมื่อมีการลบ Row ทิ้ง
                    Dim AmountRT As Double = fnCalAmtxUnit(xCommand, drDel.Item("idUnit"), drDel.Item("idInvGroup"), drDel.Item("AmountRT"), drDel.Item("idInvMain"))
                    InvLotMainUpdate(2, drDel.Item("idInvMain"), drDel.Item("idLot"), AmountRT,
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
        For i As Integer = 0 To GVReturnDt.DataRowCount - 1

            Dim dr As DataRow = GVReturnDt.GetDataRow(i)

            'Case 1: insert New Row
            Dim idComp As Integer = cmbGroupComp.SelectedValue

            If idComp = 10 Then
                idComp = 4
            End If

            If IsDBNull(dr.Item("idSaleReturnDt")) Then
                AddSmSaleReturnDt(idSaleReturn_, dr, xCommand, "SAM-5", i + 1, idComp)
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

                    Dim AmountRTHide As Double = fnCalAmtxUnit(xCommand, dr.Item("idUnit"), dr.Item("idInvGroup"), dr.Item("AmountRTHide"), dr.Item("idInvMain"))
                    Dim AmountRT As Double = fnCalAmtxUnit(xCommand, dr.Item("idUnit"), dr.Item("idInvGroup"), dr.Item("AmountRT"), dr.Item("idInvMain"))

                    If dr.Item("AmountRT") <> dr.Item("AmountRTHide") And dr.Item("idWh") = dr.Item("idWhHide") Then

                        If aProcess = eProcess.eEdit Then

                            'คืนตัวเดิมลง Stock
                           

                            InvLotMainUpdate(2, dr.Item("idInvMain"), dr.Item("idLot"), AmountRTHide, _
                                           "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", dr.Item("LotNo"), dr.Item("idWh"), xCommand)

                            'เพิ่มเข้า Stock ใหม่
                            InvLotMainUpdate(1, dr.Item("idInvMain"), dr.Item("idLot"), AmountRT, _
                                          "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", dr.Item("LotNo"), dr.Item("idWh"), xCommand)
                        End If

                    ElseIf dr.Item("idWh") <> dr.Item("idWhHide") Then

                        'ตัด AmountRec ออกจากรับคืน idWh นั้น
                        'xCommand.CommandText = "UPDATE dInvLotRefWh SET AmountRec = ISNULL(AmountRec,0) - " & CDbl(dr.Item("AmountRTHide")) & vbNewLine & _
                        '                                "WHERE idLot =  " & dr.Item("idLot") & " AND idWh = " & dr.Item("idWhHide")
                        'xCommand.ExecuteNonQuery()

                        'คืนตัวเดิมลง Stock 
                        InvLotMainUpdate(2, dr.Item("idInvMain"), dr.Item("idLot"), AmountRTHide, _
                                            "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", dr.Item("LotNo"), _
                                           dr.Item("idWhHide"), xCommand)

                        '-- Check lot ว่า มีอยู่แล้วในคลังที่เลือกไหม --'
                        Dim LotWh As New DataTable
                        LotWh.Clear()
                        xCommand.CommandText = "SELECT * FROM dInvLotRefWh WHERE idLot = " & dr.Item("idLot") & vbNewLine & _
                                                " AND idWh = " & dr.Item("idWh")
                        xAdapter.Fill(LotWh)

                        'Update idLotMain in SmSaleReturnMt
                        xCommand.CommandText = "UPDATE SmSaleReturnDt SET idLot = " & dr.Item("idLot") & " WHERE idSaleReturnDt = " & dr.Item("idSaleReturnDt")
                        xCommand.ExecuteNonQuery()

                        If LotWh.Rows.Count > 0 Then
                            'แสดงว่ามี Lot นั้นยังอยู่ในคลัง ให้บวก Amount เพิ่มเข้าไปใน Lot
                            '--Case 2: Has idLot--
                            '----2.1 Return Same Warehouse-----
                            'เพิ่ม AmountRec ใน idWh เดิม
                            'xCommand.CommandText = "UPDATE dInvLotRefWh SET AmountRec = ISNULL(AmountRec,0) + " & CDbl(dr.Item("AmountRT")) & vbNewLine & _
                            '                       "WHERE idLot =  " & dr.Item("idLot") & " AND idWh = " & dr.Item("idWh")
                            'xCommand.ExecuteNonQuery()


                            'Call InvLotMainUpdate for add Amount before call stockcard
                            InvLotMainUpdate(1, dr.Item("idInvMain"), dr.Item("idLot"), AmountRT, _
                                             "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", dr.Item("LotNo"), dr.Item("idWh"), xCommand)

                        Else
                            '----2.2 Return Other Warehouse----
                            ' Sum Amount ก่อน Insert ตัวใหม่เข้าไป
                            Dim sDt As New DataTable
                            xCommand.CommandText = "SELECT Sum(Amount) As Amount FROM dInvLotRefWh WHERE idLot = " & dr.Item("idLot")
                            xAdapter.Fill(sDt)

                            Dim AmountLot As Double = 0
                            If sDt.Rows.Count <> 0 Then
                                AmountLot = sDt.Rows(0).Item("Amount")
                            End If

                            '----2.2 Return Other Warehouse----
                            'Insert old idLot that has new idWh
                            xCommand.CommandText = "INSERT INTO dInvLotRefWh(idLot, idWh, AmountRec, Amount, idUnit, CostDt) Values(" & MainReturn.Rows(i).Item("idLot") & _
                                                    ", " & dr.Item("idWh") & "," & AmountRT & "," & AmountRT & "," & dr.Item("idUnit") & ",0.00)"

                            xCommand.ExecuteScalar()
                         
                            InvLotStockCard(1, dr.Item("idInvMain"), dr.Item("idLot"), AmountRT, _
                                            CDbl(AmountLot), "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", dr.Item("LotNo"), _
                                            dr.Item("idWh"), xCommand)
                        End If

                    End If
                End If
            End If

        Next
        '------------------------------------------------------------------------

    End Sub

    Private Function fnCalAmtxUnit(ByVal mycommand As SqlCommand, ByVal idUnit As Integer, ByVal idInvGroup As Integer, ByVal Amount As Double, ByVal idInvMain As Integer) As Double
        Dim CalAmt As Double = 0.0
        Dim myAdapter = New SqlDataAdapter(mycommand)
        '------แปลงหน่วย ก่อน คืน + เพิ่ม สต๊อกกกกกก
        If idInvGroup = 1 And idUnit = 1 Then ' วัตถุดิบ + กรัม
            CalAmt = CDbl(Amount) / 1000

        Else

            Dim dtInvUnitSub As New DataTable
            mdCnOpen()

            dtInvUnitSub.Clear()

            mycommand.CommandText = "SELECT ISNULL(AmtMainperSub,0) As AmtMainperSub, idSubUnit, idUnit " & vbNewLine & _
                                   "FROM  dInvUnitSub " & vbNewLine & _
                                   "WHERE idSubUnit = " & idUnit & " AND idInvMain = " & idInvMain
            myAdapter.Fill(dtInvUnitSub)

            If dtInvUnitSub.Rows.Count > 0 Then 'มี idSubUnit
                'Check ว่า idUnit ที่เลือกตอนนี้เป็น Unit หลัก หรือ Unit รอง
                If idUnit = dtInvUnitSub.Rows(0).Item("idSubUnit") Then 'แสดงว่าเป็นหน่วยรอง ต้อง  Convert

                    CalAmt = CDbl(Amount) * dtInvUnitSub.Rows(0).Item("AmtMainperSub")

                End If

            Else
                CalAmt = CDbl(Amount)

            End If
        End If

        Return CalAmt
    End Function

    '-----------------Function For Call Stored Procedure--------------------
    Private Function ADDxEditSmSaleReturnMt_SP(ByVal xCommand As SqlCommand, ByVal idSaleReturn As Integer) As Integer

        Dim DocNum As String = ""
        Dim Prefixcode As String = ""

        Dim YearRT As Integer = dtpReturn.Value.Year

        If YearRT < 2500 Then
            YearRT = YearRT + 543
        End If
        Dim MonthRT As Integer = dtpReturn.Value.Month

        If aProcess = eProcess.eEdit Or aProcess = eProcess.eEdit151 Then 'Update

            xCommand.CommandText = "UPDATE SmSaleReturnMt SET DocNum = @DocNum, YearRT = @YearRT, MonthRT = @MonthRT, DateReturnD = @DateReturnD, " & vbNewLine & _
                                   "idRTDocCode = @idRTDocCode, DocRef = @DocRef, idRtCause = @idRtCause, idPsSale = @idPsSale, Total = @Total, idPsReturn = @idPsReturn, " & vbNewLine & _
                                   "idPsTs = @idPsTs, DateTsD = @DateTsD, Note = @Note , idComp = @idComp, idPartner = @idPartner, idCus = @idCus, idFM = @idFM" & vbNewLine & _
                                   "WHERE idSaleReturn = @idSaleReturn "

            xCommand.Parameters.Add("@idSaleReturn", SqlDbType.Int).Value = idSaleReturn

        ElseIf aProcess = eProcess.eNewReturn Or aProcess = eProcess.eNewRT151 Then 'Insert

            Dim getDate As String = CType(YearRT, String)

            Prefixcode = (Microsoft.VisualBasic.Right(getDate, 2))
            DocNum = getDocNum(Prefixcode, xCommand)

            xCommand.CommandText = "Insert Into SmSaleReturnMt(DocNum, YearRT, MonthRT, DateReturnD, idRTDocCode, DocRef, " & _
                                   "idRtCause, idPsSale, Total, idPsReturn, idPsTs, DateTsD, Note, idComp, idPartner, idCus, idFM) " & _
                                   "Values(@DocNum, @YearRT, @MonthRT, @DateReturnD, @idRTDocCode, @DocRef, " & _
                                   "@idRtCause, @idPsSale, @Total, @idPsReturn, @idPsTs, @DateTsD, @Note, @idComp, @idPartner, @idCus, @idFM)"

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
            .Add("@Total", SqlDbType.Decimal).Value = CDbl(txtTotal.Text)
            .Add("@idPsReturn", SqlDbType.Int).Value = lblPsReturn.Tag
            .Add("@idPsTs", SqlDbType.Int).Value = sPsId
            .Add("@DateTsD", SqlDbType.DateTime).Value = Date.Now
            .Add("@Note", SqlDbType.VarChar).Value = Trim(Me.txtNote.Text)
            .Add("@idComp", SqlDbType.Int).Value = cmbGroupComp.SelectedValue
            .Add("@idPartner", SqlDbType.Int).Value = idPartner
            .Add("@idCus", SqlDbType.Int).Value = idCus
            .Add("@idFM", SqlDbType.Int).Value = idFm
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

    Private Sub ADDSmSaleReturnDt_SP(ByVal xCommand As SqlCommand, ByVal idSaleReturn As Integer, ByVal dr As DataRow)

        Select Case aProcess
            Case aProcess = eProcess.eNewReturn Or eProcess.eEdit

                xCommand.CommandText = "INSERT INTO SmSaleReturnDt(idSaleReturn, idSale, idSaleDt, idLot, AmountReturn, " & vbNewLine & _
                                        "Price, RTValuePerc, RTPrice, idUnit, idWh, LotNoRT, idInvMain) " & vbNewLine & _
                                        "VALUES(@idSaleReturn, @idSale, @idSaleDt, @idLot, @AmountReturn, " & vbNewLine & _
                                        "@Price, @RTValuePerc, @RTPrice, @idUnit, @idWh, @LotNoRT, @idInvMain)"

        End Select

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
            .Add("@idWh", SqlDbType.Int).Value = If(aProcess = eProcess.eNewRT151, DBNull.Value, dr.Item("idWh"))
            .Add("@LotNoRT", SqlDbType.VarChar).Value = dr.Item("LotNo")
            .Add("@idInvMain", SqlDbType.Int).Value = dr.Item("idInvMain")
        End With

        xCommand.ExecuteNonQuery()
        xCommand.Parameters.Clear()
    End Sub

    Private Sub EditSmSaleReturnDt_SP(ByVal xCommand As SqlCommand, ByVal idSaleReturn As Integer)

        Dim xAdapter = New SqlDataAdapter(xCommand)
        '----Update SmSaleReturnMt-------------------------------------------------
        Dim dtpReturnCvt As DateTime = Convert.ToDateTime(dtpReturn.Value, _cultureEnInfo)
        Dim MonthRT As Integer = CType(dtpReturn.Value.Month, Integer)
        Dim stridCus As String = ""

        Dim YearRT As Integer = dtpReturn.Value.Year

        If YearRT < 2500 Then
            YearRT = YearRT + 543
        End If

        '------------Edit Cut Stock Verson--------------
        If idFm = 0 And idCus <> 0 Then
            stridCus = "idCus = " & idCus & ", idFm = NULL, idPartner = " & idPartner

        ElseIf idFm <> 0 And idCus = 0 Then

            stridCus = "idCus = NULL, idFm = " & idFm & ", idPartner = " & idPartner

        ElseIf idFm <> 0 And idCus <> 0 Then
            stridCus = "idCus = " & idCus & ", idFm = " & idFm & ", idPartner = " & idPartner
        End If


        xCommand.CommandText = "Update SmSaleReturnMt Set DocNum = '" & Trim(Me.lblDocNum.Text) & "', YearRT = " & YearRT & ", MonthRT = " & MonthRT & ", " & vbNewLine &
                               "DateReturnD = '" & dtpReturnCvt.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "'," & vbNewLine &
                               "idRTDocCode = " & Me.cmbDRCode.SelectedValue & ", DocRef = '" & Trim(txtDocRef.Text) & "', " & vbNewLine &
                               stridCus & ", idRtCause = " & Me.cmbCauseReturn.SelectedValue & ", " & vbNewLine &
                               "idPsSale = " & lblPsSale.Tag & ", Total = " & CDbl(txtTotal.Text) & ", idPsReturn = " & lblPsReturn.Tag & ", " & vbNewLine &
                               "idPsTs = " & sPsId & ", DateTsD = GETDATE(), " & vbNewLine &
                               "Note = '" & Trim(Me.txtNote.Text) & "', idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                               "WHERE idSaleReturn = " & idSaleReturn_
        xCommand.ExecuteNonQuery()


        '-------------------------------------------------------------------------

        '-------Update SmSaleReturnDt---------------------------------------------

        'Case 2: Row Delete
        If dtDel.Rows.Count > 0 Then
            For j As Integer = 0 To dtDel.Rows.Count - 1
                Dim drDel As DataRow = dtDel.Rows(j)

                If Not IsDBNull(drDel.Item("idSaleReturnDt")) Then
                    xCommand.CommandText = "DELETE FROM SmSaleReturnDt WHERE idSaleReturnDt = " & drDel.Item("idSaleReturnDt")
                    xCommand.ExecuteNonQuery()

                    'drDel.Delete()
                    'dtDel.AcceptChanges()
                End If

            Next
            dtDel.AcceptChanges()
        End If


        For i As Integer = 0 To GVReturnDt.DataRowCount - 1

            Dim dr As DataRow = GVReturnDt.GetDataRow(i)

            'Case 1: insert New Row
            If IsDBNull(dr.Item("idSaleReturnDt")) Then
                ADDSmSaleReturnDt_SP(xCommand, idSaleReturn_, dr)
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
        Next
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If Me.cmbDRCode.SelectedValue <> 8 Then ' Not 151
            '----- *[4]* Check stock Use------'
            For i As Integer = 0 To MainReturn.Rows.Count - 1
                If Not IsDBNull(MainReturn.Rows(i).Item("idLot")) Then
                    Dim tempDt As New DataTable
                    tempDt.Clear()
                    mdCnOpen()
                    sCommand.CommandText = "Select (AmountRec-Amount) As diffUse " & vbNewLine & _
                                  "FROM dInvLotRefWh " & vbNewLine & _
                                  "WHERE idLot =" & MainReturn.Rows(i).Item("idLot") & vbNewLine & _
                                  "AND idWh = " & MainReturn.Rows(i).Item("idWh")
                    sAdapter.Fill(tempDt)

                    If tempDt.Rows(0).Item("diffUse") > 0 Then
                        MessageBox.Show("รายการนี้ไม่สามารถยกเลิกได้ เนื่องจากสินค้าบางส่วนถูกนำไปใช้ในกระบวนการอื่นแล้ว", sSystemName, _
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End If
            Next
            '------------END *[4]*----------------
        End If

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
                                                "CancelNote ='" & CancelNote & "'" & vbNewLine & _
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


                        '----------------------------(3) Delete SmSaleReturn SP------------------------------------

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


                        '---------------------------------(3) END ---------------------------------------------------

                        '------------------------*[3]* Delete SmSaleReturn Real Stock----------------------------------
                        If Me.cmbDRCode.SelectedValue <> 8 Then ' Not 151
                            '--- Cancel stock : stDel = 1 ---'
                            For i As Integer = 0 To MainReturn.Rows.Count - 1
                                'Dim AmountRTHide As Double = fnCalAmtxUnit(mycommand, MainReturn.Rows(i).Item("idUnit"), MainReturn.Rows(i).Item("idInvGroup"), MainReturn.Rows(i).Item("AmountRTHide"), _
                                'MainReturn.Rows(i).Item("idInvMain"))
                                Dim AmountRT As Double = fnCalAmtxUnit(mycommand, MainReturn.Rows(i).Item("idUnit"), MainReturn.Rows(i).Item("idInvGroup"), _
                                                                       MainReturn.Rows(i).Item("AmountRT"), MainReturn.Rows(i).Item("idInvMain"))
                                '-------New Structure
                                If IsDBNull(MainReturn.Rows(i).Item("idLotReturn")) Then
                                    If Not IsDBNull(MainReturn.Rows(i).Item("idLot")) Then
                                        '---Call before StockCard in New Structure ---'

                                        'mycommand.CommandText = "UPDATE dInvLotRefWh SET AmountRec = ISNULL(AmountRec,0) - " & CDbl(MainReturn.Rows(i).Item("AmountRT")) & vbNewLine & _
                                        ' "WHERE idLot =  " & MainReturn.Rows(i).Item("idLot") & " AND idWh = " & MainReturn.Rows(i).Item("idWh")
                                        'mycommand.ExecuteNonQuery()
                                        InvLotMainUpdate(2, MainReturn.Rows(i).Item("idInvMain"), MainReturn.Rows(i).Item("idLot"), AmountRT, _
                                        "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", MainReturn.Rows(i).Item("LotNo"), MainReturn.Rows(i).Item("idWh"), mycommand)
                                    End If
                                Else
                                    If Not IsDBNull(MainReturn.Rows(i).Item("idLot")) Then
                                        ' -- UPDATE : stock in new Structure --'

                                        mycommand.CommandText = "UPDATE dInvLotMain SET stDel = 1 WHERE idLot = " & MainReturn.Rows(i).Item("idLot")
                                        mycommand.ExecuteNonQuery()

                                        '-- Stock Card in New Structure--'
                                        InvLotMainUpdate(2, MainReturn.Rows(i).Item("idInvMain"), MainReturn.Rows(i).Item("idLot"), AmountRT, _
                                                     "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", MainReturn.Rows(i).Item("LotNo"), MainReturn.Rows(i).Item("idWh"), mycommand)
                                    End If
                                End If
                            Next

                        End If
                        '---------------------------------*[3]* END ---------------------------------------------------
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

    Private Sub GvShowData_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVReturnDt.CellValueChanged
        '   Dim dr As DataRow = GvShowData.GetFocusedDataRow
        'Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If e.Column.Name = ColAmtRT.Name Then 'And Me.cmbDRCode.SelectedValue <> 8
            '' จำนวนคืน > จำนวนขายที่สามารถคืนได้
            'If Not IsDBNull(GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColidSale)) Then
            '    If GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColidSale) <> 0 Then
            '        If GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColAmtRT) > GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColBalanceRT) Then
            '            mdLoadCommitt()
            '            Dim vMsg As String = "จำนวนสินค้าที่คืนมากกว่าจำนวนสินค้าที่ขาย" & vbCrLf & _
            '                "** จำนวนสินค้าขายที่สามารถคืนได้ " & Format(GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColBalanceRT), "#,##0.00##") & " " & _
            '                GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColUnitName) & " **"
            '            MessageBox.Show(vMsg, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '            GVReturnDt.SetRowCellValue(GVReturnDt.FocusedRowHandle, ColAmtRT, GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColBalanceRT))
            '            SumcolAmountExp()
            '            SumTotal()
            '            Exit Sub
            '        End If
            '    End If
            'End If

            SumcolAmountExp()
            SumTotal()
        End If

        If e.Column.Name = ColRTValue.Name Then
            If GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColRTValue) > 100 Then
                MessageBox.Show(" % มูลค่าคืนสินค้า ไม่สามารถเกิน 100", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                GVReturnDt.SetRowCellValue(GVReturnDt.FocusedRowHandle, ColRTValue, 0.0)
                GVReturnDt.SetRowCellValue(GVReturnDt.FocusedRowHandle, ColRTPrice, 0.0)
            Else
                Dim CalValue As Double = (GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColPricePerUnit) * GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColRTValue)) / 100
                GVReturnDt.SetRowCellValue(GVReturnDt.FocusedRowHandle, ColRTPrice, CalValue)
            End If
            SumcolAmountExp()
            SumTotal()
        End If

        If e.Column.Name = ColRTPrice.Name Then
            SumcolAmountExp()
            SumTotal()
        End If

        If e.Column.Name = ColPricePerUnit.Name Then

            If IsDBNull(GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColPricePerUnit)) Then
                GVReturnDt.SetFocusedRowCellValue(ColPricePerUnit, 0)
            End If

            If IsDBNull(GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColRTValue)) Then
                GVReturnDt.SetFocusedRowCellValue(ColRTValue, 0)
            End If

            Dim CalValue As Double = (GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColPricePerUnit) * GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, ColRTValue)) / 100
            GVReturnDt.SetRowCellValue(GVReturnDt.FocusedRowHandle, ColRTPrice, CalValue)
        End If



    End Sub

    Private Sub rdbReject_CheckedChanged(sender As Object, e As EventArgs) Handles rdbReject.CheckedChanged
        If Me.rdbReject.Checked = True Then
            Me.txtRejectNote.Enabled = True
        Else
            Me.txtRejectNote.Enabled = False
        End If
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        If aProcess = eProcess.eAccept Then 'accept
            mdCnOpen()
            sCommand.CommandText = "UPDATE SmSaleReturnMt SET idPsAccept = " & sPsId & ", DateAcceptD = GETDATE() " & _
                                   "WHERE idSaleReturn = " & idSaleReturn_
            sCommand.ExecuteNonQuery()

            MessageBox.Show("รับทราบเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        ElseIf aProcess = eProcess.eCheck Then ' check
            mdCnOpen()
            sCommand.CommandText = "UPDATE SmSaleReturnMt SET idPsCheck = " & sPsId & ", DateCheckD = GETDATE() " & _
                                 "WHERE idSaleReturn = " & idSaleReturn_
            sCommand.ExecuteNonQuery()

            MessageBox.Show("ตรวจสอบเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        ElseIf aProcess = eProcess.eApprove Then ' approve
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
                    Try
                        Dim vMsg As String = ""
                        If Me.rdbApv.Checked = True Then
                            mycommand.CommandText = "UPDATE SmSaleReturnMt SET stApp = 1, idPsApprove = " & sPsId & ", " & _
                                                    "DateApproveD = GETDATE() WHERE idSaleReturn = " & idSaleReturn_
                            mycommand.ExecuteNonQuery()

                            vMsg = "อนุมัติรายการเรียบร้อยแล้ว"
                        ElseIf Me.rdbNoApv.Checked = True Then
                            mycommand.CommandText = "UPDATE SmSaleReturnMt SET stApp = 0, idPsApprove = " & sPsId & ", " & _
                                                   "DateApproveD = GETDATE() WHERE idSaleReturn = " & idSaleReturn_
                            mycommand.ExecuteNonQuery()

                            If Me.cmbDRCode.SelectedValue <> 8 Then ' Not 151
                                '--- Cancel stock : stDel = 1 ---'
                                '----------------------*[5]* Reject Cut Stock-------------------------
                                For i As Integer = 0 To MainReturn.Rows.Count - 1
                                    Dim TempAmountRT As Double = fnCalAmtxUnit(mycommand, MainReturn.Rows(i).Item("idUnit"), MainReturn.Rows(i).Item("idInvGroup"), MainReturn.Rows(i).Item("tempAmountRT"), _
                                                                               MainReturn.Rows(i).Item("idInvMain"))
                                    '---------------New Structure
                                    If IsDBNull(MainReturn.Rows(i).Item("idLotReturn")) Then
                                        If Not IsDBNull(MainReturn.Rows(i).Item("idLot")) Then

                                            '--- Call Edit stock before call stockcard in New Structure ---'

                                            InvLotMainUpdate(2, MainReturn.Rows(i).Item("idInvMain"), MainReturn.Rows(i).Item("idLot"), TempAmountRT, _
                                                            "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", MainReturn.Rows(i).Item("LotNo"), _
                                                            MainReturn.Rows(i).Item("idWh"), mycommand)
                                        End If

                                    Else
                                        If Not IsDBNull(MainReturn.Rows(i).Item("idLot")) Then
                                            ' -- UPDATE to dInvLotMain: stock สินค้า --'
                                            'mycommand.CommandText = "UPDATE dInvLotRefWh SET Amount = 0 WHERE idLot = " & MainReturn.Rows(i).Item("idLotMain") & " AND idWh = " & MainReturn.Rows(i).Item("idWh")
                                            'mycommand.ExecuteNonQuery()

                                            mycommand.CommandText = "UPDATE dInvLotMain SET stDel = 1 WHERE idLot = " & MainReturn.Rows(i).Item("idLot")
                                            mycommand.ExecuteNonQuery()

                                            '--- Call StockCard in New Structure ---'
                                            InvLotMainUpdate(2, MainReturn.Rows(i).Item("idInvMain"), MainReturn.Rows(i).Item("idLot"), TempAmountRT, _
                                                            "เมนู" & Me.Text, idSaleReturn_, "SAM", "SmSaleReturnMt", MainReturn.Rows(i).Item("LotNo"), _
                                                            MainReturn.Rows(i).Item("idWh"), mycommand)
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
                            End If

                            vMsg = "บันทึกไม่อนุมัติรายการเรียบร้อยแล้ว"

                        ElseIf Me.rdbReject.Checked = True Then
                            mycommand.CommandText = "UPDATE SmSaleReturnMt SET stApp = 2, idPsApprove = " & sPsId & ", " & _
                                                 "DateApproveD = GETDATE(), " & _
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

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then

            chxCompany = 1

            lblPsCus.Text = ""
            lblPsCus.Tag = 0
            lblPsSale.Text = ""
            lblPsReturn.Text = ""
            txtTotal.Text = 0
            txtCntReturn.Text = 0
            Me.lblPsSale.Tag = 0
            idPartner = 0
            MainReturn.Clear()

            cmbWhOnGrid()
            MainReturn.Clear()
        End If
    End Sub

    Private Sub rptDel_Click(sender As Object, e As EventArgs) Handles rptDel.Click
        If GVReturnDt.FocusedRowHandle >= 0 Then
            Dim dr As DataRow = GVReturnDt.GetDataRow(GVReturnDt.FocusedRowHandle)

            Dim drtemp As DataRow = dtDel.NewRow()

            Result = MessageBox.Show("คุณต้องการจะลบรายการนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If Result = Windows.Forms.DialogResult.OK Then

                If Not IsDBNull(dr.Item("idSaleReturnDt")) Then
                    drtemp("idSaleReturnDt") = dr.Item("idSaleReturnDt")
                    drtemp("idWh") = dr.Item("idWh")
                    drtemp("idInvMain") = dr.Item("idInvMain")
                    drtemp("idInvGroup") = dr.Item("idInvGroup")
                    drtemp("idUnit") = dr.Item("idUnit")
                    drtemp("idLot") = dr.Item("idLot")
                    drtemp("LotNo") = dr.Item("LotNo")
                    drtemp("AmountRT") = dr.Item("AmountRT")
                    dtDel.Rows.Add(drtemp)

                End If

                dr.Delete()

                MainReturn.AcceptChanges()
                SumTotal()
            End If
        End If

    End Sub

    Private Sub rptDel_KeyDown(sender As Object, e As KeyEventArgs) Handles rptDel.KeyDown
        If GVReturnDt.FocusedRowHandle >= 0 Then
            If e.KeyCode = Keys.Enter Then
                Dim dr As DataRow = GVReturnDt.GetDataRow(GVReturnDt.FocusedRowHandle)

                Dim drtemp As DataRow = dtDel.NewRow()

                Result = MessageBox.Show("คุณต้องการจะลบรายการนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If Result = Windows.Forms.DialogResult.OK Then
                    If Not IsDBNull(dr.Item("idSaleReturnDt")) Then
                        drtemp("idSaleReturnDt") = dr.Item("idSaleReturnDt")
                        drtemp("idWh") = dr.Item("idWh")
                        drtemp("idInvMain") = dr.Item("idInvMain")
                        drtemp("idInvGroup") = dr.Item("idInvGroup")
                        drtemp("idUnit") = dr.Item("idUnit")
                        drtemp("idLot") = dr.Item("idLot")
                        drtemp("LotNo") = dr.Item("LotNo")
                        drtemp("AmountRT") = dr.Item("AmountRT")
                        dtDel.Rows.Add(drtemp)
                    End If
                End If

                dr.Delete()

                MainReturn.AcceptChanges()
                SumTotal()
            End If

        End If
    End Sub

    Private Sub rpttxtLotNo_KeyDown(sender As Object, e As KeyEventArgs) Handles rpttxtLotNo.KeyDown
        Dim navigator As ControlNavigator = GCReturnMt.EmbeddedNavigator

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F5 Then

            If idPartner = 0 Then
                MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการเลือก Lot สินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)

            'If GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, "LotNo") = "" Then
            '    MessageBox.Show("กรุณาระบุ Lot No. เพื่อทำการค้นหา", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If
            Dim idBackDt As New DataTable
            idBackDt.Columns.Add("idSaleDt", System.Type.GetType("System.String"))
            'idBackDt.Columns.Add("Amount", System.Type.GetType("System.Double"))

            Dim k As Integer = 0
            '-------------------------------NEW GRID-------------------------------
            For i As Integer = 0 To GVReturnDt.DataRowCount - 1
                If Not IsDBNull(GVReturnDt.GetDataRow(i).Item("idSaleDt")) Then
                    If GVReturnDt.GetDataRow(i).Item("idSaleDt") <> 0 Then
                        idBackDt.Rows.Add()
                        idBackDt.Rows(k).Item("idSaleDt") = GVReturnDt.GetDataRow(i).Item("idSaleDt")
                        k = k + 1
                    End If
                End If
            Next

            Dim idInvMain As Integer = 0
            If Not IsDBNull(GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, "idInvMain")) Then
                idInvMain = GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, "idInvMain")
            End If

            Dim vFrm As New frmSlReturnNoBill(frmSlReturnNoBill.eProcess.eTs153, Me.dtpReturn.Value, cmbGroupComp.SelectedValue,
                                              GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, "LotNo"), idPartner, Trim(lblPsCus.Text), idBackDt,
                                              idInvMain)

            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                mdCnOpen()

                Dim idComp As Integer = cmbGroupComp.SelectedValue
                If idComp = 10 Then
                    idComp = 4
                End If

                Dim tempWh As New DataTable
                sCommand.CommandText = "SELECT idWh FROM SsWarehouse WHERE idComp = " & idComp & " AND stType = 1" 'คลังรับคืน
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

                'Set First Row
                fnSetDataOnGrid(vFrm.dtSmSale.Rows(0), idRTWh)

                'Set Second Row ++
                For i As Integer = 1 To vFrm.dtSmSale.Rows.Count - 1
                    vFrm.dtSmSale.Rows(i).Item("PriceSale") = fnSetPricNormal(vFrm.dtSmSale.Rows(i).Item("idProduct")) 'ถ้าไม่ใช่อ้างอิงรายการขาย ให้ไปหาราคาปกติมาใส่
                    GVReturnDt.AddNewRow()
                    fnSetDataOnGrid(vFrm.dtSmSale.Rows(i), idRTWh)

                Next

                GVReturnDt.RefreshData()

                'fnSetDataOnGrid(vFrm.dtSmSale.Rows(0), idRTWh)
                GVReturnDt.RefreshData()
                SumTotal()

            Else
                navigator.Buttons.DoClick(navigator.Buttons.Remove)
            End If
        End If
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


    Private Sub rptDocSale_KeyDown(sender As Object, e As KeyEventArgs) Handles rptDocSale.KeyDown
        Dim navigator As ControlNavigator = GCReturnMt.EmbeddedNavigator

        If e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Enter Then
            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)

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

            If GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, "DocRef") = "" Then
                MessageBox.Show("กรุณาระบุ เลขที่บิลขาย เพื่อทำการค้นหา", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                navigator.Buttons.DoClick(navigator.Buttons.Remove)
                Exit Sub
            End If

            Dim idBackDt As New DataTable
            idBackDt.Columns.Add("idSaleDt", System.Type.GetType("System.String"))
            idBackDt.Columns.Add("Amount", System.Type.GetType("System.Double"))

            Dim k As Integer = 0
            '-------------------------------NEW GRID-------------------------------
            For i As Integer = 0 To GVReturnDt.DataRowCount - 1
                If Not IsDBNull(GVReturnDt.GetDataRow(i).Item("idSaleDt")) Then
                    If GVReturnDt.GetDataRow(i).Item("idSaleDt") <> 0 Then
                        idBackDt.Rows.Add()
                        idBackDt.Rows(k).Item("idSaleDt") = GVReturnDt.GetDataRow(i).Item("idSaleDt")
                        k = k + 1
                    End If
                End If
            Next

            Dim vFrm As New frmSlReturnSaleList(frmSlReturnSaleList.eProcess.eSelectReturn, idBackDt, idPartner, Me.lblPsCus.Text, cmbGroupComp.SelectedValue, _
                                                GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, "DocRef"), lblPsSale.Tag, lblPsSale.Text)

            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Set First Row
                fnSetDataOnGrid(vFrm.getDt.Rows(0), idRTWh)

                'Set Second Row ++
                For i As Integer = 1 To vFrm.getDt.Rows.Count - 1

                    GVReturnDt.AddNewRow()
                    fnSetDataOnGrid(vFrm.getDt.Rows(i), idRTWh)

                Next

                GVReturnDt.RefreshData()
            Else
                navigator.Buttons.DoClick(navigator.Buttons.Remove)
            End If

        End If
    End Sub


    Private Sub fnSetDataOnGrid(ByVal dr As DataRow, ByVal idWh As Integer)
        GVReturnDt.SetFocusedRowCellValue("idSale", dr.Item("idSale"))
        GVReturnDt.SetFocusedRowCellValue("idSaleDt", dr.Item("idSaleDt"))
        GVReturnDt.SetFocusedRowCellValue("DocRef", dr.Item("DocRef"))
        GVReturnDt.SetFocusedRowCellValue("idLot", dr.Item("idLot"))

        GVReturnDt.SetFocusedRowCellValue("LotNo", dr.Item("Lotno").ToUpper)
        GVReturnDt.SetFocusedRowCellValue("idInvMain", dr.Item("idProduct"))
        GVReturnDt.SetFocusedRowCellValue("InvName", dr.Item("ProductName"))

        GVReturnDt.SetFocusedRowCellValue("idUnit", dr.Item("idUnit"))

        GVReturnDt.SetFocusedRowCellValue("UnitName", dr.Item("UnitName"))
        GVReturnDt.SetFocusedRowCellValue("idWh", idWh)
        GVReturnDt.SetFocusedRowCellValue("AmountRT", dr.Item("AmountRT"))

        GVReturnDt.SetFocusedRowCellValue("Price", dr.Item("PriceSale"))
        GVReturnDt.SetFocusedRowCellValue("RTPrice", dr.Item("AmountRT") * dr.Item("PriceSale"))
        GVReturnDt.SetFocusedRowCellValue("RTValuePerc", 100)
        GVReturnDt.SetFocusedRowCellValue("BalanceRT", dr.Item("AmtSale"))
        GVReturnDt.SetFocusedRowCellValue("Exp", dr.Item("AmountRT") * dr.Item("PriceSale"))
        GVReturnDt.SetFocusedRowCellValue("DateGen", dr.Item("DateGen"))

        GVReturnDt.SetFocusedRowCellValue("idInvGroup", dr.Item("idInvGroup"))
    End Sub

    Private Sub rptWareHouse_Click(sender As Object, e As EventArgs) Handles rptWareHouse.Click
        If GVReturnDt.FocusedRowHandle < 0 Then
            rptWareHouse.ReadOnly = True
        Else
            rptWareHouse.ReadOnly = False
        End If
    End Sub

    Private Sub GVReturnDt_KeyDown(sender As Object, e As KeyEventArgs) Handles GVReturnDt.KeyDown
        Dim navigator As ControlNavigator = GCReturnMt.EmbeddedNavigator
        If GVReturnDt.FocusedRowHandle < 0 Then
            If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Enter Then

                'MessageBox.Show("กรุณาเลือกสินค้า ก่อนทำรายการอื่นๆ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
                navigator.Buttons.DoClick(navigator.Buttons.Remove)
                Exit Sub
            End If

        End If
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

        If aProcess = eProcess.eEdit Or aProcess = eProcess.eEdit151 Then 'Update

            xCommand.CommandText = "UPDATE SmSaleReturnMt SET DocNum = @DocNum, YearRT = @YearRT, MonthRT = @MonthRT, DateReturnD = @DateReturnD, " & vbNewLine & _
                                   "idRTDocCode = @idRTDocCode, DocRef = @DocRef, idRtCause = @idRtCause, idPsSale = @idPsSale, Total = @Total, idPsReturn = @idPsReturn, " & vbNewLine & _
                                   "idPsTs = @idPsTs, DateTsD = @DateTsD, Note = @Note , idComp = @idComp, idPartner = @idPartner, idCus = @idCus, idFM = @idFM" & vbNewLine & _
                                   "WHERE idSaleReturn = @idSaleReturn "

            xCommand.Parameters.Add("@idSaleReturn", SqlDbType.Int).Value = idSaleReturn

        ElseIf aProcess = eProcess.eNewReturn Or aProcess = eProcess.eNewRT151 Then 'Insert

            Dim getDate As String = CType(YearRT, String)

            Prefixcode = (Microsoft.VisualBasic.Right(getDate, 2))
            DocNum = getDocNum(Prefixcode, xCommand)

            xCommand.CommandText = "Insert Into SmSaleReturnMt(DocNum, YearRT, MonthRT, DateReturnD, idRTDocCode, DocRef, " &
                                   "idRtCause, idPsSale, Total, idPsReturn, idPsTs, DateTsD, Note, idComp, idPartner, idCus, idFM, DateReturnSys) " &
                                   "Values(@DocNum, @YearRT, @MonthRT, @DateReturnD, @idRTDocCode, @DocRef, " &
                                   "@idRtCause, @idPsSale, @Total, @idPsReturn, @idPsTs, @DateTsD, @Note, @idComp, @idPartner, @idCus, @idFM, @DateReturnSys)"

        End If

        With xCommand.Parameters
            .Add("@DocNum", SqlDbType.VarChar).Value = DocNum
            .Add("@YearRT", SqlDbType.VarChar).Value = YearRT
            .Add("@MonthRT", SqlDbType.VarChar).Value = MonthRT
            .Add("@DateReturnD", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpReturn.Value, _cultureEnInfo)
            .Add("@idRTDocCode", SqlDbType.Int).Value = Me.cmbDRCode.SelectedValue
            .Add("@DocRef", SqlDbType.VarChar).Value = DocRef
            .Add("@idRtCause", SqlDbType.Int).Value = Me.cmbCauseReturn.SelectedValue
            .Add("@idPsSale", SqlDbType.Int).Value = gidPsSale
            .Add("@Total", SqlDbType.Decimal).Value = CDbl(txtTotal.Text)
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

    Private Function fnRTBtwSTxAV(ByVal mycommand As SqlCommand) As Integer
        Dim myAdapter As New SqlDataAdapter(mycommand)

        '--Auto Gen Bill Return Between ST to AV (idComp = 4)
        Dim getDate As String = CType(Date.Today, String)
        Dim YAndM As String = Microsoft.VisualBasic.Left(ksbDateToString(Date.Today), 6)
        Dim YAndM_Cut As String = Microsoft.VisualBasic.Right(YAndM, 4)
        Dim Prefixcode As String = (Microsoft.VisualBasic.Right(getDate, 2))


        Dim sDocRef As String = "CN" & " " & YAndM_Cut

        Dim nextOrder As String = ""

        Dim sDt As New DataTable
        mycommand.CommandText = "SELECT MAX(DocRef) as max_DocRef FROM SmSaleReturnMt " & _
                               "WHERE SUBSTRING(DocRef,1,7) = '" & sDocRef & "' AND idComp = 4 AND idPartner = 2851"
        myAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocRef")) = True Then
            sDocRef = "CN" & " " & YAndM_Cut & "001"
        Else
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocRef"), 3)
            Dim temp As Integer
            temp = CInt(RunningCode) + 1

            If temp < 100 Then
                nextOrder = "00" & CStr(temp)
            ElseIf temp < 1000 Then
                nextOrder = "0" & CStr(temp)
            Else
                nextOrder = CStr(temp)
            End If

            sDocRef = "CN" & YAndM_Cut & nextOrder

        End If

        Dim idRtAV = ADDxEditSmSaleReturnMt(mycommand, 0, 4, 2851, 2873, 0, 0, 0, sDocRef)


        If GVReturnDt.DataRowCount > 0 Then 'มีรายการคืนสินค้า'----ADD Data to SmSaleReturnDt-----'
            For i As Integer = 0 To GVReturnDt.DataRowCount - 1
                Dim dr As DataRow = GVReturnDt.GetDataRow(i)
                ADDSmSaleReturnDtxNoAddStock(mycommand, idRtAV, dr, i + 1)
            Next
        End If

        Dim idRtSt As Integer = 0

        idRtSt = ADDxEditSmSaleReturnMt(mycommand, 0, cmbGroupComp.SelectedValue, idPartner, idCus, idFm, lblPsReturn.Tag, lblPsSale.Tag, Trim(txtDocRef.Text))

        mycommand.CommandText = "UPDATE SmSaleReturnMt SET idRTAVxST = " & idRtSt & "Where idSaleReturn = " & idRtAV
        mycommand.ExecuteNonQuery()

        If GVReturnDt.DataRowCount > 0 Then 'มีรายการคืนสินค้า'----ADD Data to SmSaleReturnDt-----'
            For i As Integer = 0 To GVReturnDt.DataRowCount - 1
                Dim dr As DataRow = GVReturnDt.GetDataRow(i)
                AddSmSaleReturnDt(idRtSt, dr, mycommand, "SAM-5", i + 1, 4)
            Next
        End If


        Return idRtSt
    End Function

    Private Sub ADDSmSaleReturnDtxNoAddStock(ByVal xCommand As SqlCommand, ByVal gidSaleReturn As Integer, ByVal dr As DataRow, ByVal No As Integer)

        xCommand.CommandText = "INSERT INTO SmSaleReturnDt(idSaleReturn, idSale, idSaleDt, idLot, AmountReturn, " & vbNewLine & _
                                "Price, RTValuePerc, RTPrice, idUnit, idWh, LotNoRT, idInvMain) " & vbNewLine & _
                                "VALUES(@idSaleReturn, @idSale, @idSaleDt, @idLot, @AmountReturn, " & vbNewLine & _
                                "@Price, @RTValuePerc, @RTPrice, @idUnit, @idWh, @LotNoRT, @idInvMain)"


        With xCommand.Parameters
            .Add("@idSaleReturn", SqlDbType.Int).Value = gidSaleReturn
            .Add("@idSale", SqlDbType.Int).Value = dr.Item("idSale")
            .Add("@idSaleDt", SqlDbType.Int).Value = dr.Item("idSaleDt")
            .Add("@idLot", SqlDbType.Int).Value = dr.Item("idLot")
            .Add("@AmountReturn", SqlDbType.Decimal).Value = CDbl(dr.Item("AmountRT"))
            .Add("@Price", SqlDbType.Decimal).Value = CDbl(dr.Item("Price"))
            .Add("@RTValuePerc", SqlDbType.Decimal).Value = CDbl(dr.Item("RTValuePerc"))
            .Add("@RTPrice", SqlDbType.Decimal).Value = CDbl(dr.Item("RTPrice"))
            .Add("@idUnit", SqlDbType.Int).Value = dr.Item("idUnit")
            .Add("@idWh", SqlDbType.Int).Value = If(aProcess = eProcess.eNewRT151, DBNull.Value, dr.Item("idWh"))
            .Add("@LotNoRT", SqlDbType.VarChar).Value = dr.Item("LotNo")
            .Add("@idInvMain", SqlDbType.Int).Value = dr.Item("idInvMain")
            .Add("@No", SqlDbType.Int).Value = No
        End With

        xCommand.ExecuteNonQuery()
        xCommand.Parameters.Clear()
    End Sub

#Region "rptProductName"
    Private Sub rptProductName_Click(sender As Object, e As EventArgs) Handles rptProductName.Click
        fnSelDataOfProductName()
    End Sub

    Private Sub rptProductName_KeyDown(sender As Object, e As KeyEventArgs) Handles rptProductName.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F5 Then
            fnSelDataOfProductName()
        End If
    End Sub


    Private Sub fnSelDataOfProductName()
        Dim navigator As ControlNavigator = GCReturnMt.EmbeddedNavigator

        If idPartner = 0 Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการเลือกสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Dim navigator As ControlNavigator = GCReturnMt.EmbeddedNavigator
        If GVReturnDt.FocusedRowHandle >= 0 Then
            navigator.Buttons.DoClick(navigator.Buttons.Edit)
        Else
            'ถ้า เป็น NewItemRow
            navigator.Buttons.DoClick(navigator.Buttons.Append)
            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
        End If

        fnSetDataOfProduct()

        If IsDBNull(GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, "idInvMain")) Then
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

            GVReturnDt.SetFocusedRowCellValue("idSaleDt", 0)
            GVReturnDt.SetFocusedRowCellValue("idLot", 0)
            GVReturnDt.SetFocusedRowCellValue("idSale", 0)
            GVReturnDt.SetFocusedRowCellValue("DocRef", "")
            GVReturnDt.SetFocusedRowCellValue("LotNo", "")
            GVReturnDt.SetFocusedRowCellValue("idInvMain", vFrm.sdt1.Rows(0).Item("idInvMain"))
            GVReturnDt.SetFocusedRowCellValue("InvName", vFrm.sdt1.Rows(0).Item("InvName"))
            GVReturnDt.SetFocusedRowCellValue("AmountRT", 1)
            GVReturnDt.SetFocusedRowCellValue("UnitName", vFrm.sdt1.Rows(0).Item("UnitName"))
            GVReturnDt.SetFocusedRowCellValue("idWh", idRTWh) 'use stType in SsWarehouse

            GVReturnDt.SetFocusedRowCellValue("RTPrice", 1 * ChkPrice)
            GVReturnDt.SetFocusedRowCellValue("Price", ChkPrice)
            GVReturnDt.SetFocusedRowCellValue("RTValuePerc", 100)

            GVReturnDt.SetFocusedRowCellValue("Exp", 1 * ChkPrice)
            GVReturnDt.SetFocusedRowCellValue("DateGen", "")
            GVReturnDt.SetFocusedRowCellValue("idUnit", vFrm.sdt1.Rows(0).Item("idUnit"))
            GVReturnDt.SetFocusedRowCellValue("idInvGroup", vFrm.sdt1.Rows(0).Item("idInvGroup"))
            GVReturnDt.RefreshData()
            SumTotal()

        End If

    End Sub
#End Region

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

    Private Sub btnAddLotRT_Click(sender As Object, e As EventArgs) Handles btnAddLotRT.Click
        If Me.lblPsCus.Text = "" Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการเลือกสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idBackDt As New DataTable
        idBackDt.Columns.Add("idSaleDt", System.Type.GetType("System.String"))
        'idBackDt.Columns.Add("Amount", System.Type.GetType("System.Double"))

        Dim k As Integer = 0

        For i As Integer = 0 To GVReturnDt.DataRowCount - 1
            If Not IsDBNull(GVReturnDt.GetDataRow(i).Item("idSaleDt")) Then
                If GVReturnDt.GetDataRow(i).Item("idSaleDt") <> 0 Then
                    idBackDt.Rows.Add()
                    idBackDt.Rows(k).Item("idSaleDt") = GVReturnDt.GetDataRow(i).Item("idSaleDt")
                    k = k + 1
                End If
            End If
        Next

        Dim idInvMain As Integer = 0
        If Not IsDBNull(GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, "idInvMain")) Then
            idInvMain = GVReturnDt.GetRowCellValue(GVReturnDt.FocusedRowHandle, "idInvMain")
        End If

        Dim vFrm As New frmLotReturnSelect(frmLotReturnSelect.eProcess.eLotRTSelect, Me.dtpReturn.Value, idPartner, lblPsCus.Text.Trim,
                                           cmbGroupComp.SelectedValue, idBackDt)



        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            For i As Integer = 0 To vFrm.dtSmSale.Rows.Count - 1
                vFrm.dtSmSale.Rows(i).Item("PriceSale") = fnSetPricNormal(vFrm.dtSmSale.Rows(i).Item("idProduct")) 'ถ้าไม่ใช่อ้างอิงรายการขาย ให้ไปหาราคาปกติมาใส่
                GVReturnDt.AddNewRow()
                fnSetDataOnGrid(vFrm.dtSmSale.Rows(i), idRTWh)
            Next
        End If
    End Sub

End Class