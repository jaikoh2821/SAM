Imports System.Net
Imports System.IO
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports System.Text
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Layout.Modes
Imports System.Threading
Imports System.Linq
Imports System.Linq.Dynamic.Core

Public Class frmSlSaleTs
    Public sDt_flagpic_Rec As New DataTable
    Public CountPic As Integer = 0 'จำนวนรูป
    Dim Result As DialogResult
    Dim idSaleS As Integer = 0
    Public PsCustomer As String = ""
    Public idPsCus As Integer = 0
    Public idPs As Integer = 0

    Dim DocCodeChk As String = ""
    Dim vFrmACAp As New Form
    Dim idSlAVxST As Integer = 0
    Dim MainReturn As New DataTable
    'Dim tempCollect As New DataTable 'idPdPk & Amount before Edit
    Dim tempDelete As New DataTable ' Amount Delete for case Edit
    Dim _dt As New DataTable
    Dim dt_Note As New DataTable
    Dim dtDel As New DataTable

    Dim eEvent As eProcess
    Dim stBType As Integer = 111 '**ไม่ใช้
    Dim stBillForChkSum As Integer = 111 '**ไม่ใช้
    Dim stASG As Integer = 0
    Dim idFm As Integer = 0
    Dim idPartner As Integer = 0
    Dim idCus As Integer = 0
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim stRecWIM As Integer = 0
    Dim NoteChangePrice As String = ""
    Dim stLoad As Integer = 0
    Dim stridLot As String = ""
    Dim idSend As Integer = 0
    'Dim idSlAVxStar As Integer = 0 'สถานะขายอัตโนัมัติ ระหว่าง บ.AV และ บ.Star
    Dim SumSvFree As Double = 0.0 'รวมยอดค่าบริการ (ขนส่ง)
    Dim findCutStock As Integer = 0 'สถานะ Cut stock ตรง (ขายแบบเก่า)
    Dim stCut As Integer = 0 'สถานะเบิกของออกจากคลัง 0: ยังไม่ได้เบิก 1: เบิกออกจากคลังแล้ว
    Dim stDraft As Integer = 0 'สถานะแบบร่าง 0: Bill จริง || 1: Draft 
    Dim gidSaleOrder As Integer = 0

    Dim idSaleOrder_BillCont As Integer = 0 'Select idSaleOrder Case บิลต่อเนื่อง
    Enum eProcess
        eView
        eAccept
        eCheck
        eApprove
        eAddCombine
        eEditCombine
        eAddPic
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idSaleShow As String, ByVal gstCut As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eView
                Me.Text = "รายละเอียดรายการขายสินค้า"
                Me.btnPdInc.Visible = False
                cmbGroupComp.Enabled = False
                ColLot.OptionsColumn.ReadOnly = True
                ColLot.OptionsColumn.AllowEdit = False

                ColAmtSale.OptionsColumn.ReadOnly = True
                ColAmtSale.OptionsColumn.AllowEdit = False

                ColidUnit.OptionsColumn.ReadOnly = True
                ColidUnit.OptionsColumn.AllowEdit = False

                colAmtOrder.OptionsColumn.ReadOnly = True
                colAmtOrder.OptionsColumn.AllowEdit = False

                ColPercDiscount.OptionsColumn.ReadOnly = True
                ColPercDiscount.OptionsColumn.AllowEdit = False

                ColBathDiscount.OptionsColumn.ReadOnly = True
                ColBathDiscount.OptionsColumn.AllowEdit = False

                ColPriceNormal.OptionsColumn.ReadOnly = True
                ColPriceNormal.OptionsColumn.AllowEdit = False

                ColPdCode.OptionsColumn.ReadOnly = True
                ColPdCode.OptionsColumn.AllowEdit = False

                ColCodeOrder.OptionsColumn.ReadOnly = True
                ColCodeOrder.OptionsColumn.AllowEdit = False

                ColPriceSale.OptionsColumn.ReadOnly = True
                ColPriceSale.OptionsColumn.AllowEdit = False

                ColProductName.OptionsColumn.ReadOnly = True
                ColProductName.OptionsColumn.AllowEdit = False

                DGVBind.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
                DGVBind.OptionsView.NewItemRowPosition = DevExpress.Utils.DefaultBoolean.Default

                rptProductName.Appearance.ForeColor = Color.Black
                'rptLotNo.Appearance.ForeColor = Color.Black

                GBDiscount.Enabled = False
                btnSave.Visible = False
                btnDraft.Visible = False
                Panel3.Visible = False
                Panel8.Visible = False
            Case eProcess.eAddPic
                Me.Text = "แนบรูปภาพอ้างอิงรายการขายสินค้า"
                cmbGroupComp.Enabled = False
                btnSale.Enabled = False
                txtDocRef.Enabled = False

                cmbTp.Enabled = False
                rdbWhole.Enabled = False
                rdbBill.Enabled = False
                rdbRetail.Enabled = False
                dtpPay.Enabled = False

                btnCustomer.Enabled = False
                rdbRight.Enabled = False
                rdbNoRight.Enabled = False
                cmbDRCode.Enabled = False
                CmbTs.Enabled = False
                btnTspComp.Enabled = False
                cmbTypePayTrp.Enabled = False
                dtpSale.Enabled = False
                btnAddressS.Enabled = False
                ColLot.OptionsColumn.ReadOnly = True
                ColLot.OptionsColumn.AllowEdit = False
                ColLot.AppearanceCell.BackColor = Color.Gainsboro
                ColAmtSale.OptionsColumn.ReadOnly = True
                ColAmtSale.OptionsColumn.AllowEdit = False
                ColAmtSale.AppearanceCell.BackColor = Color.Gainsboro
                ColidUnit.OptionsColumn.ReadOnly = True
                ColidUnit.OptionsColumn.AllowEdit = False
                ColidUnit.AppearanceCell.BackColor = Color.Gainsboro
                colAmtOrder.OptionsColumn.ReadOnly = True
                colAmtOrder.OptionsColumn.AllowEdit = False
                ColPdCode.OptionsColumn.ReadOnly = True
                ColPdCode.OptionsColumn.AllowEdit = False
                ColPdCode.AppearanceCell.BackColor = Color.Gainsboro
                ColCodeOrder.OptionsColumn.ReadOnly = True
                ColCodeOrder.OptionsColumn.AllowEdit = False
                ColProductName.OptionsColumn.ReadOnly = True
                ColProductName.OptionsColumn.AllowEdit = False
                ColProductName.AppearanceCell.BackColor = Color.Gainsboro
                DGVBind.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
                DGVBind.OptionsView.NewItemRowPosition = DevExpress.Utils.DefaultBoolean.Default
                ColChxProductName.Visible = False
                ColDel.Visible = False

                rptProductName.Appearance.ForeColor = Color.Black
                'rptLotNo.Appearance.ForeColor = Color.Black
                Panel8.Visible = False
                btnSave.Visible = True
                btn_img.Visible = True
                btnPdInc.Visible = False
                ColLastPrice.Visible = False
                btnPsOrder.Visible = False
                Panel6.Visible = False
                Panel3.Visible = False
                Panel2.Visible = False
            Case eProcess.eAccept
                Me.Text = "รับทราบ รายการขายสินค้า"
                Me.btnPdInc.Visible = False
                Me.btnSave.Image = SAM.My.Resources.Resources.ApproveAll
                Me.btnSave.Text = "รับทราบ"
                Panel8.Visible = False
            Case eProcess.eCheck
                Me.Text = "ตรวจสอบ รายการขายสินค้า"
                Me.btnPdInc.Visible = False
                Me.btnSave.Image = SAM.My.Resources.Resources.ApproveAll
                Me.btnSave.Text = "ตรวจสอบ"
                Panel8.Visible = False
            Case eProcess.eApprove
                Me.Text = "อนุมัติ รายการขายสินค้า"
                Me.btnPdInc.Visible = False
                Panel8.Visible = False
            Case eProcess.eEditCombine 'แก้ไขรายการขายสินค้ารวมทุกประเภท
                Me.Text = "แก้ไขรายการขายสินค้า"
                Me.Panel3.Visible = True

        End Select

        eEvent = aProcess
        idSaleS = idSaleShow
        stCut = gstCut
    End Sub


    Private Sub frmSlSaleTs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        dt_Note.Columns.Add("Note", System.Type.GetType("System.String"))
        gcNote.DataSource = dt_Note

        SetDatainRpt()
        setCmbGroupComp(Me.cmbGroupComp)

        tempDelete.Columns.Add("idLot", System.Type.GetType("System.Int32"))
        tempDelete.Columns.Add("AmtDel", System.Type.GetType("System.Double"))
        tempDelete.Columns.Add("idUnit", System.Type.GetType("System.Int32"))
        tempDelete.Columns.Add("idWh", System.Type.GetType("System.Int32"))

        fnAddDataTable()
        AddDatatableDel()

        Select Case eEvent
            Case eProcess.eAddCombine ' Add New-Combine
                Me.Panel3.Visible = True
                Me.Text = "ทำรายการขายสินค้า"
                stLbl_DateTs.Text = "วันที่ทำรายการ : " & Date.Today
                stLbl_PsTs.Text = "ผู้ทำรายการ : " & sPsName
                stLbl_PsTs.Tag = sPsId

                If tempDateSale = "" Then
                    Me.dtpSale.Value = Date.Today
                Else
                    Me.dtpSale.Value = ksbStringToDate(tempDateSale)
                End If

                mdCnOpen()
                cmbTransport()
                cmbTps()
                cmbDRefCode()
                cmbPayTps()
                Me.cmbDRCode.Focus()

                ' fnAddDatatoDT("", "Lot", "เลือกสินค้า", 0, 0, 0, "", 0, 0.0, 0.0, 0, 0, 0, 0, 0, 0, 0, 0, cmbGroupComp.SelectedValue, 0, False, 0, 0, 0, 0, 0, 999, 0)
                GCSale.DataSource = MainReturn

            Case Else ' Edit / view

                If stCut <> 0 And eEvent = eProcess.eEditCombine Then 'มีการเบิกของออกจากคลังแล้ว สามารถแก้ไขได้เฉพาะราคา
                    MessageBox.Show("รายการนี้มีการเบิกของออกจากคลังแล้ว" & vbCrLf &
                                    "สามารถแก้ไขได้เฉพาะราคาเท่านั้น", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.btnPdInc.Visible = False
                    cmbGroupComp.Enabled = False
                    btnSale.Enabled = False
                    txtDocRef.Enabled = False

                    cmbTp.Enabled = False
                    rdbWhole.Enabled = False
                    rdbBill.Enabled = False
                    rdbRetail.Enabled = False
                    dtpPay.Enabled = False

                    btnPsOrder.Enabled = False
                    btnCustomer.Enabled = False
                    rdbRight.Enabled = False
                    rdbNoRight.Enabled = False
                    cmbDRCode.Enabled = False
                    CmbTs.Enabled = False
                    btnTspComp.Enabled = False
                    cmbTypePayTrp.Enabled = False
                    dtpSale.Enabled = False
                    btnAddressS.Enabled = False
                    ColLot.OptionsColumn.ReadOnly = True
                    ColLot.OptionsColumn.AllowEdit = False
                    ColLot.AppearanceCell.BackColor = Color.Gainsboro
                    ColAmtSale.OptionsColumn.ReadOnly = True
                    ColAmtSale.OptionsColumn.AllowEdit = False
                    ColAmtSale.AppearanceCell.BackColor = Color.Gainsboro
                    ColidUnit.OptionsColumn.ReadOnly = True
                    ColidUnit.OptionsColumn.AllowEdit = False
                    ColidUnit.AppearanceCell.BackColor = Color.Gainsboro
                    colAmtOrder.OptionsColumn.ReadOnly = True
                    colAmtOrder.OptionsColumn.AllowEdit = False
                    ColPdCode.OptionsColumn.ReadOnly = True
                    ColPdCode.OptionsColumn.AllowEdit = False
                    ColPdCode.AppearanceCell.BackColor = Color.Gainsboro
                    ColCodeOrder.OptionsColumn.ReadOnly = True
                    ColCodeOrder.OptionsColumn.AllowEdit = False
                    ColProductName.OptionsColumn.ReadOnly = True
                    ColProductName.OptionsColumn.AllowEdit = False
                    ColProductName.AppearanceCell.BackColor = Color.Gainsboro
                    DGVBind.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
                    DGVBind.OptionsView.NewItemRowPosition = DevExpress.Utils.DefaultBoolean.Default
                    ColChxProductName.Visible = False
                    ColDel.Visible = False
                    btnOrderSel.Visible = False
                    rptProductName.Appearance.ForeColor = Color.Black
                    'rptLotNo.Appearance.ForeColor = Color.Black
                End If

                Dim dt1 As New DataTable
                mdCnOpen()
                sCommand.CommandText = "SELECT stWIMAllRec FROM SmSaleDtAll WHERE idSale = " & idSaleS & " AND stWIMAllRec IN(1) "
                sAdapter.Fill(dt1)

                If dt1.Rows.Count > 0 Then
                    btnPdInc.Visible = False
                    ColDel.Visible = False
                    ColAmtSale.OptionsColumn.ReadOnly = True
                    ColAmtSale.OptionsColumn.AllowEdit = False

                    ColAmtSale.AppearanceCell.BackColor = Color.Gainsboro

                    stRecWIM = 1
                End If

                cmbDRefCode()
                cmbTransport()
                cmbTps()
                cmbPayTps()


                cmbGroupComp.Enabled = False
                mdCnOpen()

                mdLoadShow()
                BindData()
                mdLoadCommitt()
                SendKeys.Send("{TAB}")

        End Select

        'SumTotalNew()
        '----Check StBtnOrderPic ----'
        'Dim StbtnOrderPic As Integer = 0

        ''-------------------------NEW GRID---------------------------
        'For i As Integer = 0 To DGVBind.RowCount - 1
        '    If Not IsDBNull(DGVBind.GetDataRow(i).Item("CodeOrder")) Then
        '        If IsDBNull(DGVBind.GetDataRow(i).Item("CodeOrder")) Or DGVBind.GetDataRow(i).Item("CodeOrder") <> "" Then
        '            StbtnOrderPic = 1
        '            ' Me.btmOrderPic.Visible = True
        '        End If
        '    End If
        'Next
        ''------------------------------------------------------------
        'If StbtnOrderPic = 1 Then
        '    Me.btmOrderPic.Visible = True
        'End If

        stLoad = 1

    End Sub

    Private Sub BindData()
        '------Show vSmSaleMt----'          
        Dim vDt As New DataTable

        sCommand.CommandText = "SELECT v.idSale, v.PartnerNameBill As CusName, v.DocCode, v.DocRefAcc, v.idSaleCode,  v.DocRef, ts.TspTypeName As Transport, " & vbNewLine &
                             "td.PaymentTerms, v.DateSale, v.DatePay, v.DateTs, v.TimeTs, v.note, ISNULL(p2.PsName,'-') As PsSale, " & vbNewLine &
                             "v.idPsSale, p1.PsName As PsTs, v.idPsTs, v.TotalW, c.Note As NoteCus, ISNULL(v.stBillType,0) As stBillType," & vbNewLine &
                             "v.idPM, v.idTs, v.Total, ISNULL(v.DiscountPerc,0) As DiscountPerc, ISNULL(v.DiscountAmout,0) As DiscountAmout, ISNULL(v.DiscountBath,0) As DiscountBath, v.TotalNet, v.stPrice, v.stRight, " & vbNewLine &
                             "c.CusNameCon_, c.MobileCon, ISNull(c.AddressS, '') As AddressS, v.stBillType, t.idCusType, t.CusType, t.PriceRetail, " & vbNewLine &
                             "t.PriceBill, t.PriceWholeSale, t.Note As CusNote, v.stLot, v.idPayTsp, v.idSupTsp, ISNULL(p3.PsName,'-') As PsOrder, ISNULL(v.idPsOrder,0) As idPsOrder," & vbNewLine &
                             "sup.SupName, v.stBillOrder, ad.AddressS As AddressSent, v.idCusRefAddr, ad.PsRecName, ISNULL(v.SumService,0) As SumService," & vbNewLine &
                             "v.idPartner, IsNULL(v.idCus, 0) As idCus, ISNULL(v.idFm,0) As idFm, v.DateSaleD, v.DateTsD , v.idComp, IsNULL(v.idSend,0) As idSend, ISNULL(idSlAVxST,0) As idSlAVxST, " & vbNewLine &
                             "ISNULL(CASE WHEN v.idComp = 10 THEN (SELECT CASE  WHEN m.idWaitCutMt Is NULL THEN 1 " & vbNewLine &
                                                            "WHEN  m.stNoApprove  Is NULL THEN 0 Else 1 END " & vbNewLine &
                                                            "FROM SmSaleMt  " & vbNewLine &
                                                            "LEFT JOIN WimWaitCutMt m ON SmSaleMt.idSale = m.idMt And ProcessID = 4 " & vbNewLine &
                                                            "WHERE SmSaleMt.idSlAVxST = v.idSale) " & vbNewLine &
                             "WHEN wMt.idWaitCutMt Is NULL THEN 1 " & vbNewLine &
                             "ELSE CASE WHEN wMt.stNoApprove Is NULL THEN 0 Else 1 END END,0) As stNoApprove" & vbNewLine &
                             "FROM SmSaleMt v  " & vbNewLine &
                             "LEFT JOIN dPartner p ON v.idPartner = p.idPartner" & vbNewLine &
                             "LEFT OUTER JOIN vCustomer c ON v.idCus = c.idCus  " & vbNewLine &
                             "LEFT OUTER JOIN dCusType t ON c.idCusType = t.idCusType " & vbNewLine &
                             "LEFT JOIN vPersonxSelect p1 ON v.idPsTs = p1.idPs" & vbNewLine &
                             "LEFT JOIN vPersonxSelect p2 ON v.idPsSale = p2.idPs" & vbNewLine &
                              "LEFT JOIN vPersonxSelect p3 ON v.idPsOrder = p3.idPs" & vbNewLine &
                             "LEFT JOIN PchInvAndProject.dbo.dSupplier sup ON v.idSupTsp = sup.idSup" & vbNewLine &
                             "LEFT JOIN dTspType ts ON v.idTS = ts.idTspType " & vbNewLine &
                             "LEFT JOIN SmPaymentTermsD As td ON v.idPM  = td.idPM " & vbNewLine &
                             "LEFT JOIN dCustomerAdrSent As ad ON v.idCusRefAddr = ad.idCusRefAddr " & vbNewLine &
                             "LEFT JOIN WimWaitCutMt wMt ON wMt.idMt = v.idSale And wMt.ProcessID = 4" & vbNewLine &
                             "WHERE v.idSale = " & idSaleS & ""


        sAdapter.Fill(vDt)
        stBType = vDt.Rows(0).Item("stBillType")
        idSlAVxST = vDt.Rows(0).Item("idSlAVxST")
        cmbGroupComp.SelectedValue = vDt.Rows(0).Item("idComp")

        'Bill จริง ไม่ใช่ Draft
        If vDt.Rows(0).Item("stNoApprove") = 0 Then
            btnDraft.Visible = False
            Panel3.Visible = False
        Else
            If eEvent <> eProcess.eEditCombine Then
                Panel3.BringToFront()
                Panel1.BringToFront()
                Panel2.BringToFront()
            End If
            Panel6.Visible = True

        End If


        cmbDRefCode()
        '-----------------GridViewNote--------------
        Dim dtNote As New DataTable
        dtNote.Columns.Add("Note", System.Type.GetType("System.String"))

        If vDt.Rows(0).Item("Note") <> "" Then
            Dim drNote As DataRow = dtNote.NewRow()

            Dim strArr() As String
            If IsDBNull(vDt.Rows(0).Item("Note")) Then
                vDt.Rows(0).Item("Note") = ""
            End If

            strArr = vDt.Rows(0).Item("Note").Split("\")

            For count As Integer = 0 To strArr.Length - 1
                dt_Note.Rows.Add(strArr(count))
            Next

            gcNote.DataSource = dt_Note
            gcNote.Focus()
        End If

        '-------------------------------------------
        'idSlAVxStar = vDt.Rows(0).Item("idSlAVxST")

        If vDt.Rows(0).Item("idSlAVxST") <> 0 Or stCut = 1 Then
            btnSale.Enabled = False
            btnAddressS.Enabled = False
            txtDocRef.Enabled = False
            cmbDRCode.Enabled = False
            dtpSale.Enabled = False
            rdbNoRight.Enabled = False
            rdbRight.Enabled = False
        End If

        lblPsOrder.Text = vDt.Rows(0).Item("PsOrder")
        lblPsOrder.Tag = vDt.Rows(0).Item("idPsOrder")

        idSend = vDt.Rows(0).Item("idSend")
        SumSvFree = vDt.Rows(0).Item("SumService")
        If Not IsDBNull(vDt.Rows(0).Item("NoteCus")) Then
            lblCusNote.Text = vDt.Rows(0).Item("NoteCus")
        End If

        If Not IsDBNull(vDt.Rows(0).Item("stBillOrder")) Then
            ColCodeOrder.Visible = True
            ColCodeOrder.VisibleIndex = 2
            colAmtOrder.Visible = True
            colAmtOrder.VisibleIndex = 7
        End If

        If Not IsDBNull(vDt.Rows(0).Item("stBillType")) Then
            stBillForChkSum = vDt.Rows(0).Item("stBillType") '*** Use in case Accept/check/Approve
        End If

        lblDocCode.Text = vDt.Rows(0).Item("DocCode")
        If IsDBNull(vDt.Rows(0).Item("DocRefAcc")) = True Then
            lblRefAcc.Text = ""
        Else
            lblRefAcc.Text = vDt.Rows(0).Item("DocRefAcc")
        End If

        Me.cmbDRCode.SelectedValue = vDt.Rows(0).Item("idSaleCode")

        Dim DocRef() As String = vDt.Rows(0).Item("DocRef").ToString.Split(" ")

        If DocRef.Length > 1 Then
            'cmbDRCode.Text = DocRef(0)
            txtDocRef.Text = DocRef(1)
        End If

        If Not IsDBNull(vDt.Rows(0).Item("idTs")) Then
            CmbTs.SelectedValue = vDt.Rows(0).Item("idTs")
        End If
        cmbTp.SelectedValue = vDt.Rows(0).Item("idPM")

        If cmbTp.SelectedValue = 55 Then 'ชำระมัดจำ ชำระเงินมัดจำ 50.00%
            Dim PrePay As Double = (CDbl(vDt.Rows(0).Item("TotalNet")) * 50) / 100
            Me.txtPrePay.Text = Format(PrePay, "#,##0.00")
        End If

        dtpSale.Value = vDt.Rows(0).Item("DateSaleD")
        dtpPay.Value = ksbStringToDate(vDt.Rows(0).Item("DatePay"))

        lblPsCus.Text = vDt.Rows(0).Item("CusName")

        lblPsCus.Tag = vDt.Rows(0).Item("idCus")
        idFm = vDt.Rows(0).Item("idFm")
        idPartner = vDt.Rows(0).Item("idPartner")
        idCus = vDt.Rows(0).Item("idCus")

        lblPsSale.Text = vDt.Rows(0).Item("PsSale")
        lblPsSale.Tag = vDt.Rows(0).Item("idPsSale")


        stLbl_DateTs.Text = "วันที่ทำรายการ : " & ksbStringToDate(vDt.Rows(0).Item("DateTs"))
        stLbl_PsTs.Text = "ผู้ทำรายการ : " & vDt.Rows(0).Item("PsTs")
        stLbl_PsTs.Tag = vDt.Rows(0).Item("idPsTs")

        'Me.btnAddressS.Enabled = True
        If Not IsDBNull(vDt.Rows(0).Item("AddressSent")) Then
            lblAddr.Text = vDt.Rows(0).Item("AddressSent")
            lblAddr.Tag = vDt.Rows(0).Item("idCusRefAddr")
        Else ' Old case : No set idCusRefAddr on SmSaleMt
            lblAddr.Text = vDt.Rows(0).Item("AddressS")
            lblAddr.Tag = 0
        End If

        If Not IsDBNull(vDt.Rows(0).Item("PsRecName")) Then
            lblCusRec.Text = vDt.Rows(0).Item("PsRecName")
        End If

        If Not IsDBNull(vDt.Rows(0).Item("idPayTsp")) Then
            cmbTypePayTrp.SelectedValue = vDt.Rows(0).Item("idPayTsp")
        End If
        If Not IsDBNull(vDt.Rows(0).Item("idSupTsp")) Then
            Me.lblTspComp.Tag = vDt.Rows(0).Item("idSupTsp")
            Me.lblTspComp.Text = vDt.Rows(0).Item("SupName")
        End If

        txtTotalBFDisc.Text = Format(vDt.Rows(0).Item("Total"), "#,##0.00##")
        txtTotalNet.Text = Format(vDt.Rows(0).Item("TotalNet"), "#,##0.00##")

        If vDt.Rows(0).Item("DiscountPerc") <> 0 Then
            rdbPerDisc.Checked = True
            txtAmtPerc.Enabled = True
            txtDiscBath.Enabled = False

            txtAmtPerc.Text = Format(vDt.Rows(0).Item("DiscountPerc"), "#,##0.####")
            lblPerc.Text = Format(vDt.Rows(0).Item("DiscountBath"), "#,##0.00##")
        ElseIf vDt.Rows(0).Item("DiscountAmout") <> 0 Then
            rdbBathDisc.Checked = True
            txtDiscBath.Enabled = True
            txtAmtPerc.Enabled = False

            txtDiscBath.Text = Format(vDt.Rows(0).Item("DiscountAmout"), "#,##0.00##")
        End If

        If Not IsDBNull(vDt.Rows(0).Item("stRight")) Then
            If vDt.Rows(0).Item("stRight") = 1 Then
                Me.rdbRight.Checked = True
            ElseIf vDt.Rows(0).Item("stRight") = 0 Then
                Me.rdbNoRight.Checked = True
            End If
        End If


        'Me.cmbDRCode.Enabled = False

        ' ----- SmSaleDt/DtPd/DtOther ------'
        ' Dim fieldPrice As String = ""
        If IsDBNull(vDt.Rows(0).Item("stPrice")) Then
            ' strdb = 1
            Me.rdbWhole.Checked = True
            '   fieldPrice = "PriceBill"
        ElseIf vDt.Rows(0).Item("stPrice") = 1 Then
            ' strdb = 1
            Me.rdbBill.Checked = True
            '  fieldPrice = "PriceBill"
        ElseIf vDt.Rows(0).Item("stPrice") = 2 Then
            ' strdb = 1
            Me.rdbRetail.Checked = True
            '  fieldPrice = "PriceRetail"
        ElseIf vDt.Rows(0).Item("stPrice") = 3 Then
            'strdb = 1
            Me.rdbWhole.Checked = True
            ' fieldPrice = "PriceWholesale"
        End If

        '----Show SmSaleDtAll on dgv ----'
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT cast(0 As bit) As chk, dt.CodeOrder, CASE WHEN inv.idInvGroup = 2 THEN pk.PdCode ELSE ic.InvCode END As PdCode , ISNULL(dt.idLot,0) As idLot, dt.LotNo, dt.LotNo As LotNoHide, dt.Amount, lm.CompRec," & vbNewLine &
                               "dt.Price, inv.idInvGroup, inv.idSubType, dt.DiscountPerc, dt.DiscountPerc As DisCountPercHide, dt.DiscountBath, " & vbNewLine &
                               "dt.PriceBfDis, dt.ProductName, dt.idSaleDt, dt.idUnit, dt.idProduct As idInvMain, dt.stCutStock, " & vbNewLine &
                               "sw.full_lock, ISNULL(dt.idSaleOrderDt,0) As idSaleOrderDt, ISNULL(ord.idSaleOrder,0) As idSaleOrder," & vbNewLine &
                               "IsNULL(lm.idLotSPM,0) As idLotSPM, ISNULL(dt.idWh,0) As idWh, inv.idInvGroup, unit.UnitName, dt.No, dt.stWIMAllRec,  " & vbNewLine &
                               "dt.AmtWIMRecBal, dt.DtType," & vbNewLine &
                               "ISNULL((wh.Amount - (SELECT ISNULL(SUM(AmountWaitChange),0) " & vbNewLine &
                                                                                "FROM WimWaitCutDt wDt " & vbNewLine &
                                                                                "LEFT JOIN WimWaitCutMt wMt On wDt.idWaitCutMt = wMt.idWaitCutMt" & vbNewLine &
                                                                                "WHERE wDt.idRefLot = wh.idRefLot " & vbNewLine &
                                                                                "And wDt.stWait Is NULL" & vbNewLine &
                                                                                "And wMt.stCancel Is NULL " & vbNewLine &
                                                                                "And wDt.stDel Is NULL" & vbNewLine &
                                                                                ")),0) As AmtStock, " & vbNewLine &
                               "ISNULL(wh.idRefLot,0) As idRefLot, ISNULL(dt.pWeight,0) As pWeight, ISNULL(dt.idUnitW,0) As idUnitW, ISNULL(stCutStock,0) As stCutStock" & vbNewLine &
                               "FROM SmSaleDtAll dt " & vbNewLine &
                               "LEFT JOIN dInvLotMain lm On dt.idLot = lm.idLot " & vbNewLine &
                               "LEFT JOIN dInvLotRefWh wh On dt.idRefLot = wh.idRefLot" & vbNewLine &
                               "--LEFT JOIN vInvLotRefWh_RStock wh On dt.idRefLot = wh.idRefLot" & vbNewLine &
                               "LEFT JOIN dInventoryMain inv On dt.idProduct = inv.idInvMain" & vbNewLine &
                               "LEFT JOIN dInvCode ic On inv.idInvMain = ic.idInvMain" & vbNewLine &
                               "LEFT JOIN dInvUnit unit On dt.idUnit = unit.idUnit" & vbNewLine &
                               "LEFT JOIN dPackingPdSet As pk On inv.idSubType = pk.idPdPk And inv.idInvGroup = 2" & vbNewLine &
                               "LEFT JOIN SmSaleOrderDt ord On dt.idSaleOrderDt = ord.idSaleOrderDt " & vbNewLine &
                               "LEFT JOIN SsWareHouse sw On dt.idWh = sw.idWh " & vbNewLine &
                               "WHERE dt.idSale = " & idSaleS & " Order By dt.No"

        sAdapter.Fill(sDt)

        If sDt.Rows.Count > 0 Then
            gidSaleOrder = sDt.Rows(0)("idSaleOrder")
        End If

        For i As Integer = 0 To sDt.Rows.Count - 1


            Dim drNew As DataRow = MainReturn.NewRow()

            drNew("PdCode") = sDt.Rows(i)("PdCode")

            If Not IsDBNull(sDt.Rows(i)("CodeOrder")) Then
                drNew("CodeOrder") = sDt.Rows(i)("CodeOrder")
                ColCodeOrder.Visible = True
            End If



            If Not IsDBNull(sDt.Rows(i)("LotNo")) Then
                drNew("LotNo") = sDt.Rows(i)("LotNo")
                drNew("LotNoHide") = sDt.Rows(i)("LotNo")
            End If

            drNew("ProductName") = sDt.Rows(i)("ProductName")
            drNew("idSubType") = sDt.Rows(i)("idSubType")
            'drNew("AmtOrder") = sDt.Rows(i)("AmtOrder")
            drNew("AmtSale") = sDt.Rows(i)("Amount")
            drNew("AmtSaleHide") = sDt.Rows(i)("Amount")
            drNew("UnitName") = sDt.Rows(i)("UnitName")
            drNew("idWh") = sDt.Rows(i)("idWh")
            drNew("idWhHide") = sDt.Rows(i)("idWh")
            drNew("idInvGroup") = sDt.Rows(i)("idInvGroup")
            drNew("idInvGroupHide") = sDt.Rows(i)("idInvGroup")
            drNew("DtType") = sDt.Rows(i)("DtType")
            drNew("idRefLot") = sDt.Rows(i)("idRefLot")
            drNew("idRefLotHide") = sDt.Rows(i)("idRefLot")

            If Not IsDBNull(sDt.Rows(i)("PriceBfDis")) Then
                drNew("PriceNormal") = sDt.Rows(i)("PriceBfDis")
                drNew("PriceNormalHide") = sDt.Rows(i)("PriceBfDis")
            End If

            If IsDBNull(sDt.Rows(i)("DiscountPerc")) Then
                drNew("PercDisc").Value = 0
                drNew("PercDiscHide") = 0
            Else
                drNew("PercDisc") = sDt.Rows(i)("DiscountPerc")
                drNew("PercDiscHide") = sDt.Rows(i)("DiscountPerc")
            End If

            If IsDBNull(sDt.Rows(i)("DiscountBath")) Then
                drNew("BathDisc") = 0
                drNew("BathDiscHide") = 0
            Else
                drNew("BathDisc") = sDt.Rows(i)("DiscountBath")
                drNew("BathDiscHide") = sDt.Rows(i)("DiscountBath")
            End If

            drNew("PriceSale") = sDt.Rows(i)("Price")
            drNew("PriceSaleHide") = sDt.Rows(i)("Price")
            drNew("idUnit") = sDt.Rows(i)("idUnit")
            drNew("idUnitHide") = sDt.Rows(i)("idUnit")
            drNew("idSaleDt") = sDt.Rows(i)("idSaleDt")
            drNew("OldAmt") = sDt.Rows(i)("Amount")
            drNew("AmtStock") = sDt.Rows(i)("AmtStock")
            drNew("OldStock") = sDt.Rows(i)("AmtStock")
            drNew("idLot") = sDt.Rows(i)("idLot")
            drNew("idLotHide") = sDt.Rows(i)("idLot")
            drNew("idInvMain") = sDt.Rows(i)("idInvMain")
            drNew("idInvMainHide") = sDt.Rows(i)("idInvMain")
            drNew("chk") = sDt.Rows(i)("chk")
            drNew("idLotSPM") = sDt.Rows(i).Item("idLotSPM")
            'drNew("No") = sDt.Rows(i).Item("No")
            drNew("AmtWIMRecBal") = sDt.Rows(i).Item("AmtWIMRecBal")
            drNew("stWIMAllRec") = sDt.Rows(i).Item("stWIMAllRec")
            drNew("stCutStock") = sDt.Rows(i).Item("stCutStock")
            drNew("CompRec") = sDt.Rows(i).Item("CompRec")
            drNew("pWeight") = sDt.Rows(i).Item("pWeight")
            drNew("idUnitW") = sDt.Rows(i).Item("idUnitW")
            drNew("full_lock") = sDt.Rows(i).Item("full_lock")
            drNew("idSaleOrderDt") = sDt.Rows(i).Item("idSaleOrderDt")
            MainReturn.Rows.Add(drNew)
        Next

        GCSale.DataSource = MainReturn

        For j As Integer = 0 To DGVBind.DataRowCount - 1

            'If DGVBind.GetDataRow(j).Item("idUnit") = 1 Then  ' ขายสินค้าทั่วไป
            '    'Add rows to tempcollect
            '    tempCollect.Rows.Add(DGVBind.GetDataRow(j).Item("idInvMain"), DGVBind.GetDataRow(j).Item("AmtSale"), 0, 0)
            'End If
            DGVBind.GetDataRow(j).Item("Total") = Math.Round(DGVBind.GetDataRow(j).Item("PriceSale") * DGVBind.GetDataRow(j).Item("AmtSale"), 2, MidpointRounding.AwayFromZero)
            If Not IsDBNull(DGVBind.GetDataRow(j).Item("idLot")) Then
                Dim SumStock As Double = 0.0

                '    tempstock.Rows.Clear()
                For n As Integer = 0 To DGVBind.DataRowCount - 1


                    'Dim OldAmt As Double = DGVBind.GetDataRow(n).Item("OldAmt")
                    'idPdPkLot ที่เลือกมา มีในรายการแล้ว
                    If DGVBind.GetDataRow(n).Item("idLot") = DGVBind.GetDataRow(j).Item("idLot") And
                       DGVBind.GetDataRow(n).Item("idInvGroup") = DGVBind.GetDataRow(j).Item("idInvGroup") And
                       DGVBind.GetDataRow(n).Item("idWh") = DGVBind.GetDataRow(j).Item("idWh") Then

                        Dim OldAmt As Double = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(j).Item("idUnit"), DGVBind.GetDataRow(j).Item("idInvGroup"),
                                                        CDbl(DGVBind.GetDataRow(n).Item("OldAmt")), DGVBind.GetDataRow(j).Item("idInvMain"))

                        SumStock = SumStock + OldAmt
                    End If

                Next

                DGVBind.GetDataRow(j).Item("AmtStock") = CDbl(DGVBind.GetDataRow(j).Item("AmtStock")) + SumStock
            End If
        Next


        SumTotalNew()


        If eEvent = eProcess.eView Or eEvent = eProcess.eAccept Or eEvent = eProcess.eCheck Or eEvent = eProcess.eApprove Then
            Me.txtDocRef.Enabled = False
            Me.dtpSale.Enabled = False
            Me.dtpPay.Enabled = False
            Me.cmbTp.Enabled = False
            Me.rdbWhole.Enabled = False
            Me.rdbRetail.Enabled = False
            Me.rdbBill.Enabled = False
            Me.rdbRight.Enabled = False
            Me.rdbNoRight.Enabled = False
            Me.btnCustomer.Enabled = False
            Me.btnSale.Enabled = False
            Me.txtPercP.Enabled = False
            Me.btnAddressS.Enabled = False
            Me.btnTspComp.Enabled = False
            Me.CmbTs.Enabled = False
            Me.cmbTypePayTrp.Enabled = False

            Me.btnPsOrder.Enabled = False
            Me.btnRefDoc.Enabled = False

            '---------------------NEW------------------------
            ColDel.Visible = False
            ColLastPrice.Visible = False
            ColChxProductName.Visible = False

            If Not IsDBNull(vDt.Rows(0).Item("stBillOrder")) Then 'order bill
                ColCodeOrder.Visible = True
                colAmtOrder.Visible = True
            Else
                ColCodeOrder.Visible = False
                colAmtOrder.Visible = False
            End If
            '------------------------------------------------
            If eEvent = eProcess.eApprove Then 'Approve
                Me.rdbAppNo.Visible = True
                Me.rdbAppOK.Visible = True

            End If
        End If

        '----ถ้ามีรายการจากระบบขนส่งแล้ว ให้ปิด
        If idSend <> 0 Then
            CmbTs.Enabled = False

            cmbTypePayTrp.Enabled = False
            btnAddressS.Enabled = False
            btnTspComp.Enabled = False
            btnCustomer.Enabled = False
        End If
        '--------------------


        Me.btnRefDoc.Focus()
    End Sub

    Private Sub SetDatainRpt()
        mdCnOpen()

        sCommand.CommandText = "Select unit.idUnit, unit.UnitName " & vbNewLine &
                               "FROM  dInvUnit unit " &
                               "WHERE stDel Is NULL "
        sAdapter.Fill(_dt)

        rptUnit.Columns.Clear()
        rptUnit.Columns.Add(New LookUpColumnInfo("UnitName"))
        rptUnit.DataSource = _dt

        rptUnit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub btnTspComp_Click(sender As Object, e As EventArgs) Handles btnTspComp.Click
        Dim vFrm As New frmTspCompSelect(frmTspCompSelect.eProcess.eAll)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblTspComp.Tag = vFrm.idSup
            Me.lblTspComp.Text = vFrm.SupName
        End If
    End Sub

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        Dim eText As String = ""

        If Me.lblPsSale.Text = "" Then
            eText = frmCustomerSelect.eProcess.eSelectAllChkSt
        Else 'ผูกกับ Sale
            eText = frmCustomerSelect.eProcess.ePsSale
        End If

        Dim vFrm As New frmCustomerSelect(eText, cmbGroupComp.SelectedValue)

        If Me.lblPsSale.Text <> "" Then
            vFrm.idPs = Me.lblPsSale.Tag
        End If

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            If vFrm.Note = "" Then
                lblCusNote.Text = " -"
            Else
                lblCusNote.Text = vFrm.Note
            End If

            stASG = vFrm.sstASG

            idFm = vFrm.idFm
            idPartner = vFrm.idPartner

            Me.lblPsCus.Tag = vFrm.idCus
            idPsCus = vFrm.idCus
            Me.lblPsCus.Text = vFrm.CusName
            PsCustomer = vFrm.CusName

            If vFrm.idCus <> 0 Then
                Me.lblAddr.Text = vFrm.AddressS
                Me.lblAddr.Tag = vFrm.idRefAdrS
                Me.lblCusRec.Text = vFrm.vPsRecName
            Else
                btnAddressS.Visible = False
                Me.lblAddr.Text = vFrm.Address
                Me.lblCusRec.Text = lblPsCus.Text
            End If

            Me.CmbTs.SelectedValue = vFrm.idTsp
            Me.cmbTypePayTrp.SelectedValue = vFrm.idPayTsp

            If vFrm.idTsp = 0 Then
                Dim dtidTsp As New DataTable
                sCommand.CommandText = "Select idTsp, idPayTsp, idSupTsp " & vbNewLine &
                                       "FROM dCustomer  " & vbNewLine &
                                       "WHERE idCus = " & vFrm.idCus & ""
                sAdapter.Fill(dtidTsp)

                If vFrm.idCus <> 0 Then
                    Me.CmbTs.SelectedValue = dtidTsp.Rows(0).Item("idTsp")
                Else
                    'Farmer default 16 (พนักงานบริษัท)
                    Me.CmbTs.SelectedValue = 16
                End If

            End If

            Me.btnAddressS.Enabled = True

            '--- Set TransportComp ----'
            mdCnOpen()
            Dim TspDt As New DataTable
            TspDt.Rows.Clear()
            'sCommand.CommandText = "Select idSupTsp, SupName FROM vCusAdrSetTransport WHERE " & _
            '                       "idCusRefAddr = " & vFrm.idRefAdrS & " And idComp = " & sIdComp
            sCommand.CommandText = "Select idCusRefAddr, idSupTsp, SupName, ISNULL(idPayTsp,0) As idPayTsp " & vbNewLine &
                                   "FROM vCusAdrSetTransport  " & vbNewLine &
                                   "WHERE idCus = " & vFrm.idCus & vbNewLine &
                                   "And idComp = " & cmbGroupComp.SelectedValue
            sAdapter.Fill(TspDt)

            If TspDt.Rows.Count = 0 Then
                Me.lblTspComp.Tag = vFrm.idSupTsp
                Me.lblTspComp.Text = vFrm.SupName

            ElseIf TspDt.Rows.Count = 1 Then
                Me.lblTspComp.Tag = TspDt.Rows(0).Item("idSupTsp")
                Me.lblTspComp.Text = TspDt.Rows(0).Item("SupName")

                If TspDt.Rows(0).Item("idPayTsp") <> 0 Then
                    cmbTypePayTrp.SelectedValue = TspDt.Rows(0).Item("idPayTsp")
                End If
            Else 'มีหลายรายการ
                    For i As Integer = 0 To TspDt.Rows.Count - 1
                    If vFrm.idRefAdrS = TspDt.Rows(i).Item("idCusRefAddr") Then
                        Me.lblTspComp.Tag = TspDt.Rows(i).Item("idSupTsp")
                        Me.lblTspComp.Text = TspDt.Rows(i).Item("SupName")
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub btnSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSale.Click
        If Me.lblPsCus.Text = "" Then
            Dim vFrm As New frmPsSaleSelect(frmPsSaleSelect.eProcess.eNormal, Nothing, PsCustomer, idPsCus, 1, cmbGroupComp.SelectedValue)
            'vFrm.GetidComp(gidComp)
            ' vFrm.ShowText(PsCustomer, idPsCus, 1) 'No Customer
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                idPs = vFrm.idPs
                'PsSaleName = vFrm.SaleName
                lblPsSale.Tag = vFrm.idPs
                lblPsSale.Text = vFrm.SaleName
            End If
        Else
            Dim vFrm As New frmPsSaleSelect(frmPsSaleSelect.eProcess.eNormal, Nothing, Me.lblPsCus.Text, Me.lblPsCus.Tag, 0, cmbGroupComp.SelectedValue)
            'vFrm.GetidComp(gidComp)
            '  vFrm.ShowText(Me.lblPsCus.Text, Me.lblPsCus.Tag, 0) 'have Customer
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                idPs = vFrm.idPs
                'PsSaleName = vFrm.SaleName
                lblPsSale.Tag = vFrm.idPs
                lblPsSale.Text = vFrm.SaleName
            End If
        End If
    End Sub

    Private Sub SumTotalNew()
        Dim Total As Double = 0.0

        For i As Integer = 0 To DGVBind.DataRowCount - 1

            If IsDBNull(DGVBind.GetDataRow(i).Item("Total")) Then
                DGVBind.GetDataRow(i).Item("Total") = 0.0
            End If

            If IsDBNull(DGVBind.GetDataRow(i).Item("PriceSale")) Then
                DGVBind.GetDataRow(i).Item("PriceSale") = 0.0
            End If

            Total += DGVBind.GetDataRow(i).Item("Total")
        Next

        'txtTotalNet.Text = Format(Total, "#,##0.00##")

        txtTotalBFDisc.Text = Format(Total, "#,##0.00##")


        If rdbPerDisc.Checked = True Then
            txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - (CDbl(txtTotalBFDisc.Text.Trim) * CDbl(txtAmtPerc.Text.Trim) / 100), "#,##0.00##")
        ElseIf rdbBathDisc.Checked = True Then
            txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - CDbl(txtDiscBath.Text.Trim), "#,##0.00##")
        End If
    End Sub

    Private Sub SumcolAmountExpNewGrid()
        Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)
        '----- Check ส่วนลด %  ------'
        If IsDBNull(DGVBind.GetFocusedRowCellValue(ColPercDiscount)) Then
            dr.Item("PercDisc") = 0.0
        End If
        '----- Check ส่วนลด Bath  ------'
        If IsDBNull(DGVBind.GetFocusedRowCellValue(ColBathDiscount)) Then
            dr.Item("BathDisc") = 0.0
        End If

        If IsDBNull(DGVBind.GetFocusedRowCellValue(ColTotalDt)) Then
            dr.Item("Total") = 0.0
        End If

        If IsDBNull(DGVBind.GetFocusedRowCellValue(ColAmtSale)) Then
            dr.Item("AmtSale") = 0.0
        End If

        If IsDBNull(DGVBind.GetFocusedRowCellValue(ColPriceSale)) Then
            dr.Item("PriceSale") = 0.0
        End If

        '------------Calculate ส่วนลด (%)------------
        If CDbl(DGVBind.GetFocusedRowCellValue(ColPercDiscount)) = 0.0 Then
            dr.Item("PriceSale") = DGVBind.GetFocusedRowCellValue(ColPriceNormal)
        ElseIf CDbl(DGVBind.GetFocusedRowCellValue(ColPercDiscount)) > 0.0 Then
            dr.Item("PriceSale") = DGVBind.GetFocusedRowCellValue(ColPriceNormal) - (DGVBind.GetFocusedRowCellValue(ColPriceNormal) * DGVBind.GetFocusedRowCellValue(ColPercDiscount)) / 100
            Console.WriteLine(DGVBind.GetFocusedRowCellValue(ColPriceNormal) - (DGVBind.GetFocusedRowCellValue(ColPriceNormal) * DGVBind.GetFocusedRowCellValue(ColPercDiscount)) / 100)
        Else 'ส่วนลดติดลย
            dr.Item("PerDisc") = 0.0
            dr.Item("PriceSale") = DGVBind.GetFocusedRowCellValue(ColPriceSale)
        End If

        '------------Calculate ส่วนลด (Bath)------------
        'If CDbl(DGVBind.GetFocusedRowCellValue(ColBathDiscount)) = 0.0 Then
        'dr.Item("PriceSale") = DGVBind.GetFocusedRowCellValue(ColPriceNormal)
        If CDbl(DGVBind.GetFocusedRowCellValue(ColBathDiscount)) > 0.0 Then
            dr.Item("PriceSale") = DGVBind.GetFocusedRowCellValue(ColPriceNormal) - DGVBind.GetFocusedRowCellValue(ColBathDiscount)
        Else
            dr.Item("BathDisc") = 0.0
        End If


        dr.Item("Total") = Math.Round(DGVBind.GetFocusedRowCellValue("PriceSale") * DGVBind.GetFocusedRowCellValue("AmtSale"), 2, MidpointRounding.AwayFromZero)

        dr.Item("PriceSale") = Format(CDbl(DGVBind.GetFocusedRowCellValue(ColPriceSale)), "#,##0.00##")
        dr.Item("PriceNormal") = Format(CDbl(DGVBind.GetFocusedRowCellValue(ColPriceNormal)), "#,##0.00##")
        dr.Item("Total") = Format(CDbl(DGVBind.GetFocusedRowCellValue(ColTotalDt)), "#,##0.00##")

        SumTotalNew()
    End Sub

    Private Sub cmbPayTps()
        'mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select * From dPayTspType"
        sAdapter.Fill(sDt)
        With cmbTypePayTrp
            .DisplayMember = "PayTspName"
            .ValueMember = "idPayTsp"
            .DataSource = sDt
        End With
    End Sub

    Private Sub cmbTps()
        'mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idPM, PaymentTerms From SmPaymentTermsD WHERE idPM <> 75 Order By PaymentTerms" 'ไม่แสดงเงื่อนไขของบิล XY
        sAdapter.Fill(sDt)
        With cmbTp
            .DisplayMember = "PaymentTerms"
            .ValueMember = "idPM"
            .DataSource = sDt
        End With
    End Sub

    Private Sub cmbTransport()
        'mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idTspType, TspTypeName " & vbNewLine &
                                "From dTspType " & vbNewLine &
                                "WHERE idTspType IN (1,7,15,16,21) " & vbNewLine &
                                "Order By idTspType"
        sAdapter.Fill(sDt)
        With CmbTs
            .DisplayMember = "TspTypeName"
            .ValueMember = "idTspType"
            .DataSource = sDt
        End With
    End Sub

    Private Sub cmbDRefCode()
        'mdCnOpen()
        Dim sDt As New DataTable
        'sCommand.CommandText = "Select idSaleCode, SaleCode From SmSaleDocCode WHERE SaleCode In (Select SaleCode From " & _
        '                       "SmSaleCodeComp WHERE idComp = " & sIdComp & " And SaleCode <> 'XY')"
        sCommand.CommandText = "Select idSaleCode, SaleCode " & vbNewLine & _
                                "From SmSaleDocCode " & vbNewLine & _
                                "WHERE idSaleCode IN (SELECT idSaleCode From " & vbNewLine & _
                                "SmSaleCodeComp WHERE idComp = " & cmbGroupComp.SelectedValue & ")" & vbNewLine & _
                                "AND stDel Is NULL"
        sAdapter.Fill(sDt)

        With cmbDRCode
            .DisplayMember = "SaleCode"
            .ValueMember = "idSaleCode"
            .DataSource = sDt
        End With

        With cmbBillSaleCont
            .DisplayMember = "SaleCode"
            .ValueMember = "idSaleCode"
            .DataSource = sDt
        End With

        If sDt.Rows.Count = 0 Then
            MessageBox.Show("บริษัทนี้ยังไม่ได้กำหนดรหัสเอกสาร จึงไม่สามารถทำรายการขายได้" & vbNewLine & "กรุณาแจ้งผู้พัฒนาระบบ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Exit Sub
        End If

    End Sub

    Private Sub upFile(ByVal namefile As String, ByVal locationname As String, ByVal idSale As String)
        My.Computer.Network.UploadFile(locationname, "ftp://" & sHost & "/SAM/SaleTs/" + idSale + "_" + namefile + ".jpg", sFtpUser, sFtpPass)
    End Sub

    Private Sub delFile(ByVal locationname As String, ByVal idSaleEdit As String)
        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://" & sHost & "/SAM/SaleTs/" + idSaleEdit + "_" + locationname + ".jpg"), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential(sFtpUser, sFtpPass)
        request.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
        request.GetResponse()
    End Sub

    '-------------------- GEN DocCode --------------------'
    Function getDocCode(ByVal mycommand As SqlCommand, ByVal Prefixcode As String) As String
        Dim DocCode As String = ""
        Dim nextOrder As String = ""
        'Dim CodeYear As String = ""
        Dim myAdapter As New SqlDataAdapter(mycommand)
        Dim sDt As New DataTable
        sDs.Tables.Clear()
        'sCommand.CommandText = "SELECT MAX(SUBSTRING(DocCode, 4, 6)) AS max_DocCode, MAX(SUBSTRING(DocCode, 1, 2)) AS year_docCode FROM SmSaleMt"
        mycommand.CommandText = "SELECT MAX(DocCode) as max_DocCode FROM SmSaleMt"
        myAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocCode")) = True Then
            DocCode = Prefixcode & "/" & "000001"
        Else
            Dim max_DocCode As String = sDt.Rows(0).Item("max_DocCode")
            Dim yearDoc As String = Microsoft.VisualBasic.Left(sDt.Rows(0).Item("max_DocCode"), 2)
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocCode"), 6)

            'CodeYear = sDt.Rows(0).Item("year_docCode")
            If Prefixcode <> yearDoc Then
                DocCode = Prefixcode & "/" & "000001"
            Else
                Dim temp As Integer
                temp = CInt(RunningCode) + 1
                If temp < 10 Then
                    nextOrder = "00000" & CStr(temp)
                ElseIf temp < 100 Then
                    nextOrder = "0000" & CStr(temp)
                ElseIf temp < 1000 Then
                    nextOrder = "000" & CStr(temp)
                ElseIf temp < 10000 Then
                    nextOrder = "00" & CStr(temp)
                ElseIf temp < 100000 Then
                    nextOrder = "0" & CStr(temp)
                Else
                    nextOrder = CStr(temp)
                End If
                DocCode = Prefixcode & "/" & nextOrder
            End If
        End If
        Return DocCode
    End Function

    '-------------------- GEN DocRefAcc : รันเลขที่ทางบัญชี --------------------'
    Function getDocRefAcc(ByVal myCommand As SqlCommand, ByVal YearAndMonth As String, ByVal idComp As Integer) As String
        Dim myAdapter As New SqlDataAdapter(myCommand)
        'IV cmbDRCode.Text : 69 ปี : 05 เดือน : 0001 ลำดับ
        'แยกตามเลขที่เอกสาร & Company
        Dim PrefixCode As String = cmbDRCode.Text

        ' Dim YearAndMonth As String = DateTime.Now.ToString("yyMM", New System.Globalization.CultureInfo("th-TH"))

        ' 1. สร้างรูปแบบการค้นหาด้วย LIKE (เช่น "IV 6905%" หรือ "110 6905%") 
        ' วิธีนี้จะเข้าไปแทนที่ระบบ SUBSTRING เดิมทั้งหมด ไม่ต้องเช็คตำแหน่ง 7 หรือ 8 หลักให้ปวดหัวแล้วครับ
        Dim SearchPattern As String = PrefixCode & " " & YearAndMonth & "%"

        ' 2. ปรับ SQL ให้คืนค่ากลับมาเป็น String เสมอ ถ้ายังไม่มีข้อมูลจะส่งค่าว่าง "" มาแทน
        ' ใช้ LIKE ค้นหาและใส่เครื่องหมายเดี่ยวครอบครอบ idComp ให้ปลอดภัย
        myCommand.CommandText = "SELECT ISNULL(MAX(DocRefAcc), '') as max_DocRefAcc " & vbNewLine &
                        "FROM SmSaleMt " & vbNewLine &
                        "WHERE DocRefAcc LIKE '" & SearchPattern & "' " & vbNewLine &
                        "AND idComp = '" & idComp & "'"

        Dim sDt As New DataTable
        myAdapter.Fill(sDt)

        Dim lastDoc As String = sDt.Rows(0).Item("max_DocRefAcc").ToString()
        Dim temp As Integer = 1 ' ค่าเริ่มต้นกรณีเป็นบิลแรกของเดือน

        ' 3. ถ้ามีเลขเดิมอยู่แล้ว ค่อยดึง 4 ตัวท้ายมาบวกเพิ่ม 1
        If Not String.IsNullOrEmpty(lastDoc) Then
            Dim RunningCode As String = Microsoft.VisualBasic.Right(lastDoc, 4)
            temp = CInt(RunningCode) + 1
        End If

        ' 4. รวมร่างรหัสบิลออกมาบรรทัดเดียวจบ ไม่ต้องพึ่ง If หลายชั้น
        ' ใช้ .ToString("D4") เติมเลข 0 ข้างหน้าให้เป็น 4 หลักอัตโนมัติ
        Dim DocRefAcc As String = PrefixCode & " " & YearAndMonth & temp.ToString("D4")

        Return DocRefAcc
        Return DocRefAcc

        'Dim PrefixCode As String = ""
        'Dim DocRefAcc As String = ""
        'Dim nextOrder As String = ""
        '' Dim CodeYear As String = ""
        'Dim st3Position As Integer = 0
        'Dim myAdapter As New SqlDataAdapter(myCommand)

        'If idComp = 4 Then  ' AVS
        '    If eEvent = eProcess.eAddCombine Or _
        '            stBType = 0 Or stBType = 2 Then 'ขายสินค้าทั่วไป/ขายดอกไม้ (ในประเทศ)/ขายสินค้ารวมทุกประเภท
        '        If Me.rdbNoRight.Checked = True Then 'ไม่ถูกหลัก
        '            If Me.lblPsSale.Tag = 9 Then
        '                PrefixCode = "CC"
        '            Else
        '                PrefixCode = "IV"
        '            End If
        '        ElseIf Me.rdbRight.Checked = True Then 'ถูกหลัก    
        '            PrefixCode = "AV"
        '        End If
        '    End If
        'ElseIf idComp = 10 Then  ' STAR
        '    If eEvent = eProcess.eAddCombine Or _
        '        stBType = 0 Or stBType = 2 Then 'ขายสินค้าทั่วไป/ขายดอกไม้ (ในประเทศ)/ขายสินค้ารวมทุกประเภท
        '        If Me.rdbNoRight.Checked = True Then 'ไม่ถูกหลัก
        '            PrefixCode = "SC"
        '        ElseIf Me.rdbRight.Checked = True Then 'ถูกหลัก    
        '            PrefixCode = "IV"
        '        End If
        '    End If
        'ElseIf idComp = 12 Then 'VC : เอวีอะโกร
        '    PrefixCode = "IVC"
        '    st3Position = 1
        '    'If stPage = 12 Then 'เมนูสินค้าตัวอย่าง
        '    '    PrefixCode = "110"
        '    '    st3Position = 1
        '    'Else
        '    '    '----Update เพิ่มเมื่อเก็บข้่อมูลเกี่ยวกับพลาสติก+ถาดเพาะ+ฮอร์โมน+อาหารเสริม-----'
        '    'End If
        'ElseIf idComp = 55 Then 'V1 : AVC (ขายพลาสติก)
        '    PrefixCode = "IV"
        'Else  ' บริษัทอื่นๆ
        '    PrefixCode = "IV"
        'End If 'End Check idComp

        'Dim fieldSub As String = ""
        'If st3Position = 1 Then
        '    fieldSub = "SUBSTRING(DocRefAcc,1,8)"
        'Else
        '    fieldSub = "SUBSTRING(DocRefAcc,1,7)"
        'End If

        'DocRefAcc = PrefixCode & " " & YearAndMonth

        'Dim sDt As New DataTable
        'myCommand.CommandText = "SELECT MAX(DocRefAcc) as max_DocRefAcc FROM SmSaleMt " & _
        '                       "WHERE " & fieldSub & "= '" & DocRefAcc & "' AND idComp = '" & idComp & "'"
        'myAdapter.Fill(sDt)

        'If IsDBNull(sDt.Rows(0).Item("max_DocRefAcc")) = True Then
        '    DocRefAcc = PrefixCode & " " & YearAndMonth & "0001"
        'Else
        '    Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocRefAcc"), 4)
        '    Dim temp As Integer
        '    temp = CInt(RunningCode) + 1
        '    If temp < 10 Then
        '        nextOrder = "000" & CStr(temp)
        '    ElseIf temp < 100 Then
        '        nextOrder = "00" & CStr(temp)
        '    ElseIf temp < 1000 Then
        '        nextOrder = "0" & CStr(temp)
        '    Else
        '        nextOrder = CStr(temp)
        '    End If
        '    DocRefAcc = PrefixCode & " " & YearAndMonth & nextOrder

        'End If
        'Return DocRefAcc
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Select Case eEvent
            Case eProcess.eAddPic

                'up image
                For j As Integer = 0 To sDt_flagpic_Rec.Rows.Count - 1
                    If sDt_flagpic_Rec.Rows(j).Item(2) = "1" Then
                        upFile(j + 1, sDt_flagpic_Rec.Rows(j).Item(0), idSaleS)
                    End If
                Next


                MessageBox.Show("แนบรูปภาพเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()

            Case eProcess.eApprove
                Dim stApp As Boolean = SmSaleSaveApprove()

                If stApp = False Then
                    Exit Sub
                End If

            Case eProcess.eAccept 'Accept
                SmSaleSaveAccept()

            Case eProcess.eCheck 'Check
                SmSaleSaveCheck()

            Case Else

                If idSlAVxST <> 0 Then
                    MessageBox.Show("ไม่สามารถแก้ไขรายการขายนี้ได้ " & vbCrLf & " เนื่องจากเป็นรายการที่ถูกบันทึกด้วยระบบ AUTO BILL", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If


                If stRecWIM = 1 Then 'แก้ไขรายการ ที่
                    NoteChangePrice = InputBox("ระบุสาเหตุ การเปลี่ยนแปลงข้อมูล", sSystemName)

                    If NoteChangePrice.Length = 0 Then
                        MessageBox.Show("กรุณาระบุสาเหตุ การเปลี่ยนแปลงข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        Result = Windows.Forms.DialogResult.Yes
                    End If
                Else

                    Result = MsgBox("คุณต้องการบันทึกรายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
                End If

                If Result = Windows.Forms.DialogResult.Yes Then

                    If lblPsCus.Text = "" Then

                        MessageBox.Show("กรุณาเลือกชื่อลูกค้าที่ต้องการรวบรวมใบแจ้งหนี้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    ElseIf lblPsSale.Text = "" Then

                        MessageBox.Show("กรุณาเลือกเจ้าหน้าที่ขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    ElseIf txtDocRef.Text = "" Then

                        MessageBox.Show("กรุณากรอกเลขที่อ้างอิง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.txtDocRef.Focus()
                        Exit Sub
                    ElseIf Me.rdbRight.Checked = False And Me.rdbNoRight.Checked = False Then

                        MessageBox.Show("กรุณาเลือกประเภทบิลถูกหลัก/ไม่ถูกหลักก่อนกดบันทึก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub

                    End If

                    mdCnOpen()

                    'Sum Amount each Lot
                    Dim tempSaleDt As New DataTable
                        tempSaleDt.Columns.Add("idLot", System.Type.GetType("System.Int64"))
                        tempSaleDt.Columns.Add("idInvGroup", System.Type.GetType("System.Int64"))
                        tempSaleDt.Columns.Add("SumAmount", System.Type.GetType("System.Double"))
                        tempSaleDt.Columns.Add("OldAmount", System.Type.GetType("System.Double"))
                        'tempSaleDt.Columns.Add("idWh", System.Type.GetType("System.Double"))
                        tempSaleDt.Columns.Add("idRefLot", System.Type.GetType("System.Int64"))
                        '--------------------NEW GRID----------------------------------
                        '--------------------------------------------------------------
                        For i As Integer = 0 To DGVBind.DataRowCount - 1
                            '*****Check row is nothing*****'
                            If IsDBNull(DGVBind.GetDataRow(i).Item("idInvMain")) Then
                                MessageBox.Show("มีลำดับข้อมูล ที่ไม่มีรายการสินค้า กรุณาตรวจสอบก่อนบันทึกอีกครั้ง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If

                            ' ถ้าเคสที่ ขายแบบไม่มี Lot ก็จะรอด ISDBNULL(DGVBind.GetDataRow(i).Item("idLot"))
                            If IsDBNull(DGVBind.GetDataRow(i).Item("idLot")) Then
                                DGVBind.GetDataRow(i).Item("idLot") = 0
                            End If

                            If DGVBind.GetDataRow(i).Item("idInvGroup") <> 30 And DGVBind.GetDataRow(i).Item("idLot") = 0 Then
                                MessageBox.Show("กรุณาเลือก Lot ของสินค้าให้ครบทุกรายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If

                            If DGVBind.GetDataRow(i).Item("AmtSale") = 0 Then
                                MessageBox.Show("มีบางรายการระบุจำนวนขายเท่ากับ 0 ระบบจึงไม่สามารถบันทึกข้อมูลได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If

                            '--- Check Stock ----'
                            Dim AmountUse As Double = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(i).Item("idUnit"), DGVBind.GetDataRow(i).Item("idInvGroup"),
                                            DGVBind.GetDataRow(i).Item("AmtSale"), DGVBind.GetDataRow(i).Item("idInvMain"))

                            If i = 0 Then '1st row
                                tempSaleDt.Rows.Add(DGVBind.GetDataRow(i).Item("idLot"), DGVBind.GetDataRow(i).Item("idInvGroup"), AmountUse,
                                                    DGVBind.GetDataRow(i).Item("OldAmt"), DGVBind.GetDataRow(i).Item("idRefLot"))
                            Else

                                Dim stAdd As Integer = 0
                                For j As Integer = 0 To tempSaleDt.Rows.Count - 1
                                    If DGVBind.GetDataRow(i).Item("idLot") = tempSaleDt.Rows(j).Item("idLot") And
                                       DGVBind.GetDataRow(i).Item("idInvGroup") = tempSaleDt.Rows(j).Item("idInvGroup") And
                                       DGVBind.GetDataRow(i).Item("idRefLot") = tempSaleDt.Rows(j).Item("idRefLot") Then

                                        'tempSaleDt.Rows(j).Item("SumAmount") = tempSaleDt.Rows(j).Item("SumAmount") + AmountUse
                                        tempSaleDt.Rows(j).Item("OldAmount") = tempSaleDt.Rows(j).Item("OldAmount") + DGVBind.GetDataRow(i).Item("OldAmt")

                                        stAdd = 1
                                        Exit For

                                    End If
                                Next

                                If stAdd = 0 Then 'Now row in Dt >> Add New Row
                                    tempSaleDt.Rows.Add(DGVBind.GetDataRow(i).Item("idLot"), DGVBind.GetDataRow(i).Item("idInvGroup"), AmountUse,
                                                        DGVBind.GetDataRow(i).Item("OldAmt"), DGVBind.GetDataRow(i).Item("idRefLot"))
                                End If

                            End If

                            'Check % DisCount
                            If IsDBNull(DGVBind.GetDataRow(i).Item("PercDisc")) Then
                                DGVBind.GetDataRow(i).Item("PercDisc") = 0
                            End If
                            If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                                DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
                            End If

                            'Check Bath DisCount
                            If IsDBNull(DGVBind.GetDataRow(i).Item("BathDisc")) Then
                                DGVBind.GetDataRow(i).Item("BathDisc") = 0
                            End If
                            If DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                                DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
                            End If

                        Next  ' Next loop DGVCombine
                        '--------------------------------------------------------------
                        '--------------------------------------------------------------
                        For i As Integer = 0 To tempSaleDt.Rows.Count - 1

                            If tempSaleDt.Rows(i).Item("idInvGroup") <> 30 Then 'ไม่ใช่ค่าขนส่ง 
                            Dim sDt As New DataTable
                            sCommand.CommandText = "SELECT main.InvName, unit.UnitName, " & vbNewLine &
                                                   "ISNULL((SELECT Amount FROM devsk.vInvLotRefWh_RStock WHERE idRefLot = " & tempSaleDt.Rows(i).Item("idRefLot") & "), 0)" & vbNewLine &
                                                   "+" & vbNewLine &
                                                   "ISNULL((SELECT SUM(Amount) FROM SmSaleDtAll WHERE idSale = " & idSaleS & " And idRefLot = " & tempSaleDt.Rows(i).Item("idRefLot") & "), 0) As Amount" & vbNewLine &
                                                   "FROM dInvLotRefWh As ref " & vbNewLine &
                                                   "LEFT JOIN dInvLotMain As lm On ref.idLot = lm.idLot " & vbNewLine &
                                                   "LEFT JOIN dInventoryMain As main On lm.idInvMain = main.idInvMain" & vbNewLine &
                                                   "LEFT JOIN dInvUnit As unit On ref.idUnit = unit.idUnit" & vbNewLine &
                                                   "WHERE ref.idRefLot = " & tempSaleDt.Rows(i).Item("idRefLot")

                            sAdapter.Fill(sDt)


                                Dim AllStock As Double = sDt.Rows(0).Item("Amount") + tempSaleDt.Rows(i).Item("OldAmount")
                                If AllStock < tempSaleDt.Rows(i).Item("SumAmount") Then  ' Stock < AllSaleAmount

                                    MessageBox.Show("จำนวน " & sDt.Rows(0).Item("InvName") & " คงเหลือใน Stock ไม่เพียงพอ ระบบจึงไม่สามารถทำรายการขายได้" & vbCrLf &
                                          "(จำนวนขายรวม : " & Format(tempSaleDt.Rows(i).Item("SumAmount"), "#,##0.00##") & " " & sDt.Rows(0).Item("UnitName") &
                                          " แต่จำนวน Stock คงเหลือ : " & Format(AllStock, "#,##0.00##") & " " &
                                          sDt.Rows(0).Item("UnitName") & ")", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)

                                    Exit Sub
                                End If
                            End If
                        Next

                        Select Case eEvent
                            Case eProcess.eAddCombine 'AddData
                                '----insert----'
                                idSaleS = AddSmSale()

                                mdCnOpen()
                                sCommand.CommandText = "UPDATE WimWaitCutMt SET stNoApprove = NULL WHERE idMt = " & idSaleS & " AND ProcessID = 4"
                                sCommand.ExecuteNonQuery()

                                If idSaleS = 0 Then
                                    Exit Sub
                                Else
                                    'send to line when Company is Siam Advance Host, idComp = 11
                                    If cmbGroupComp.SelectedValue = 11 Then
                                        fnLineNotice()
                                    End If

                                    Me.DialogResult = Windows.Forms.DialogResult.OK
                                    Me.Close()
                                End If

                            Case eProcess.eEditCombine ' EditData

                                Using myconnection As New SqlConnection(conStr)
                                    myconnection.Open()
                                    Dim mycommand As New SqlCommand()
                                    ' Dim mycommand As SqlCommand = myconnection.CreateCommand()
                                    Dim mytransaction As SqlTransaction
                                    Dim myAdapter As New SqlDataAdapter(mycommand)
                                    ' Start a local transaction
                                    mytransaction = myconnection.BeginTransaction()

                                    ' Must assign both transaction object and connection
                                    ' to Command object for a pending local transaction.
                                    mycommand.Connection = myconnection
                                    mycommand.Transaction = mytransaction

                                    Try
                                        '---Update---'
                                        EditSmSaleMtAndDt(mycommand)

                                        Dim didComp As Integer = 0
                                        Dim idSaleSP As Integer = idSaleS
                                        Dim stChkCompRec As Integer = 0
                                        If cmbGroupComp.SelectedValue = 10 Then
                                            didComp = 4

                                            Dim dt As New DataTable
                                            mycommand.CommandText = "SELECT idSale FROM SmSaleMt WHERE idSlAvxST = " & idSaleS
                                            myAdapter.Fill(dt)
                                            idSaleSP = dt.Rows(0).Item("idSale")

                                        Else
                                            didComp = cmbGroupComp.SelectedValue
                                        End If

                                        '---- Update SumService in SmSaleMt ----'
                                        mycommand.CommandText = "Update SmSaleMt Set SumService = " & SumSvFree & " WHERE idSale = " & idSaleS
                                        mycommand.ExecuteNonQuery()

                                        Dim dtidSaleAV As New DataTable
                                        mycommand.CommandText = "SELECT idSale As idSaleAV FROM SmSaleMt WHERE idSlAVxST = " & idSaleS
                                        myAdapter.Fill(dtidSaleAV)

                                        If dtidSaleAV.Rows.Count > 0 Then
                                            EditSlAVxStar(mycommand, dtidSaleAV.Rows(0).Item("idSaleAV"))
                                        End If

                                        Dim dtChkCompRec As New DataTable

                                        mycommand.CommandText = "SELECT Distinct CompRec " & vbNewLine &
                                                                "FROM SmSaleDtAll dt" & vbNewLine &
                                                                "LEFT JOIN dInvLotMain lm ON dt.idLot = lm.idLot" & vbNewLine &
                                                                "WHERE dt.idSale = " & idSaleSP & vbNewLine &
                                                                "AND lm.idInvMain <> 9766"
                                        myAdapter.Fill(dtChkCompRec)

                                        Dim dtChkWaitCompRec As New DataTable

                                        mycommand.CommandText = "SELECT Distinct CompRec " & vbNewLine &
                                                               "FROM WimWaitCutDt wDt" & vbNewLine &
                                                               "LEFT JOIN WimWaitCutMt wMt ON wDt.idWaitCutMt = wMt.idWaitCutMt" & vbNewLine &
                                                               "LEFT JOIN dInvLotMain lm ON wDt.idLot = lm.idLot" & vbNewLine &
                                                               "WHERE wMt.idMt IN (" & idSaleSP & "," & idSaleS & ")" & vbNewLine &
                                                               "AND wMt.ProcessID = 4"
                                        myAdapter.Fill(dtChkWaitCompRec)


                                        If dtChkCompRec.Rows.Count > 1 Or dtChkWaitCompRec.Rows.Count > 1 Then
                                            stChkCompRec = 1
                                            EditWaitCutAVxST(mycommand, idSaleS, idSaleSP)
                                        End If

                                        Dim dtCountWait As New DataTable
                                        mycommand.CommandText = "SELECT * FROM WimWaitcutMt WHERE idMt = " & idSaleSP & " AND ProcessID = 4"
                                        myAdapter.Fill(dtCountWait)


                                        If DGVBind.DataRowCount > 0 And findCutStock = 0 And dtCountWait.Rows.Count = 0 Then
                                            ' Insert WimWaitCutMt/Dt ถ้ายังไม่เคย insert
                                            mycommand.CommandText = "EXEC WaitCutTs '4','SmSaleMt','SmSaleDtAll','idSale'," & idSaleSP & "," & didComp & "," & sPsId & ",'1'"
                                            mycommand.ExecuteNonQuery()

                                        End If

                                        If stChkCompRec = 0 And stCut = 0 Then

                                            mycommand.CommandText = "EXEC WaitCutTsEdit '4','SmSaleMt','SmSaleDtAll','idSale'," & idSaleSP & "," & didComp & "," & sPsId & ",'2'"
                                            mycommand.ExecuteNonQuery()

                                        End If

                                        mycommand.CommandText = "UPDATE WimWaitCutMt SET stNoApprove = NULL WHERE idMt = " & idSaleSP & " AND ProcessID = 4"
                                        mycommand.ExecuteNonQuery()

                                        mycommand.CommandText = "UPDATE SmSaleMt SET idPsCrateBill = " & sPsId & ", DateCrateBill = GETDATE() WHERE idSale = " & idSaleS
                                        mycommand.ExecuteNonQuery()

                                        mytransaction.Commit()

                                        MessageBox.Show("บันทึกแก้ไขเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Me.DialogResult = Windows.Forms.DialogResult.OK
                                        Me.Close()

                                    Catch ex As Exception
                                        ' Attempt to roll back the transaction. 
                                        Try
                                            mytransaction.Rollback()

                                            MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                                                    sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                                        Catch e2x As Exception

                                            MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                                                     sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                                        End Try
                                    End Try
                                End Using

                        End Select

                    End If ' End Check dialog : YES
        End Select
    End Sub

    Private Sub EditWaitCutAVxST(ByVal mycommand As SqlCommand, ByVal idSaleST As Integer, ByVal idSaleAV As Integer)
        Dim myAdapter As New SqlDataAdapter(mycommand)
        Dim dtWaitMt As New DataTable
        Dim idWaitMtAV As Integer = 0
        Dim idWaitMtST As Integer = 0

        mycommand.CommandText = "SELECT Distinct idWaitCutMt, idComp " & vbNewLine &
                                 "FROM  WimWaitCutMt " & vbNewLine &
                                 "WHERE idMt IN (" & idSaleST & "," & idSaleAV & ")" & vbNewLine &
                                 "AND ProcessID = 4" & vbNewLine &
                                 "AND idPsCancel Is NULL"
        myAdapter.Fill(dtWaitMt)

        Dim strIdWaitCutMt As String = dtWaitMt.Rows(0).Item("idWaitCutMt")

        For i As Integer = 0 To dtWaitMt.Rows.Count - 1
            If dtWaitMt.Rows(i).Item("idComp") = 4 Then
                idWaitMtAV = dtWaitMt.Rows(i).Item("idWaitCutMt")
            Else
                idWaitMtST = dtWaitMt.Rows(i).Item("idWaitCutMt")
            End If
        Next

        'ถ้า เปิดมาแก้ไขแล้ว อันเดิมเป็น Lot แต่ของ AV แต่มาเพิ่ม Lot ของ ST ให้ insert Mt ของ ST ก่อน
        Dim count As Integer = dt_Note.Rows.Count
        Dim NoteMt As String = ""
        If count = 0 Then
            NoteMt = ""
        Else
            NoteMt = gvNote.GetDataRow(0).Item("Note")

            For i As Integer = 1 To gvNote.DataRowCount - 1
                NoteMt &= "\" & gvNote.GetDataRow(i).Item("Note")
            Next
            NoteMt = NoteMt.Replace("'", "''")
        End If

        If idWaitMtST = 0 Then
            idWaitMtST = fnInsertxWaitCutMt(mycommand, Me.cmbDRCode.Text & " " & Trim(Me.txtDocRef.Text), NoteMt, idSaleST, 10, dtpSale.Value, Date.Now)
        ElseIf idWaitMtAV = 0 Then
            Dim dt As New DataTable

            mycommand.CommandText = "SELECT sl.idSlAvxSt " & vbNewLine &
                                    "FROM WimWaitCutMt mt " & vbNewLine &
                                    "LEFT JOIN SmSaleMt sl On mt.idmt = sl.idSale AND ProcessID = 4" & vbNewLine &
                                    "WHERE sl.idSale = " & idSaleAV
            myAdapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                dt.Clear()
                mycommand.CommandText = "SELECT DocRef + '(ST: ' + (SELECT DocRef FROM SmSaleMt Where idSale = " & dt.Rows(0).Item("idSlAvxSt") & ")+')' As DocRef" & vbNewLine &
                                                                    "FROM SmSaleMt WHERE idSale = " & idSaleAV
                myAdapter.Fill(dt)
            End If

            idWaitMtAV = fnInsertxWaitCutMt(mycommand, dt.Rows(0).Item("DocRef"), NoteMt, idSaleAV, 4, dtpSale.Value, Date.Now)
        End If

        For i As Integer = 1 To dtWaitMt.Rows.Count - 1
            strIdWaitCutMt &= "," & dtWaitMt.Rows(i).Item("idWaitCutMt")
        Next
        '---Case1: Delete (มีใน WimWaitCutDt แต่ไม่มีใน SmSaleDtAll)
        mycommand.CommandText = "DELETE WimWaitCutDt  " & vbNewLine &
                                "FROM WimWaitCutDt " & vbNewLine &
                                "WHERE idDtRef NOT IN (SELECT idSaleDt " & vbNewLine &
                                                       "FROM SmSaleDtAll " & vbNewLine &
                                                       "WHERE idSale IN (" & idSaleAV & "," & idSaleST & ")) " & vbNewLine &
                                "AND idWaitCutMt IN (" & strIdWaitCutMt & ")"
        mycommand.ExecuteNonQuery()



        '---Case2: Insert (มีใน SmSaleDtAll แต่ไม่มีใน WimWaitCutDt)
        '--- 2.1: Insert (มีใน SmSaleDtAll แต่ไม่มีใน WimWaitCutDt) ของ บริษัท ST
        Dim dtSlEXWaitDtST As New DataTable
        mycommand.CommandText = "SELECT lm.CompRec, sDt.Amount As AmtSale, sDt.idProduct As idInvMain , wh.idRefLot, sDt.* " & vbNewLine &
                                 "FROM SmSaleDtAll sDt" & vbNewLine &
                                 "LEFT JOIN dInvLotMain lm ON sDt.idLot = lm.idLot" & vbNewLine &
                                 "LEFT JOIN dInvLotRefWh wh ON lm.idLot = wh.idLot AND wh.idWh = sDt.idWh" & vbNewLine &
                                 "WHERE idSaleDt NOT IN (SELECT idDtRef " & vbNewLine &
                                                         "FROM WimWaitCutDt dt" & vbNewLine &
                                                         "LEFT JOIN WimWaitCutMt mt ON dt.idWaitCutMt = mt.idWaitCutMt" & vbNewLine &
                                                         "WHERE dt.idWaitCutMt =" & idWaitMtST & vbNewLine &
                                                         "AND mt.ProcessID = 4)" & vbNewLine &
                                 "AND sDt.idSale =" & idSaleST & vbNewLine &
                                 "AND lm.CompRec = 10" & vbNewLine &
                                 "AND sDt.idProduct <> 9766"

        myAdapter.Fill(dtSlEXWaitDtST)

        For i As Integer = 0 To dtSlEXWaitDtST.Rows.Count - 1
            Dim dr As DataRow = dtSlEXWaitDtST.Rows(i)

            fnInsertxWaitCutDt(mycommand, dr.Item("idSaleDt"), idWaitMtST, dr)

        Next

        '--- 2.2: Insert (มีใน SmSaleDtAll แต่ไม่มีใน WimWaitCutDt) ของ บริษัท AV
        Dim dtSlExWaitDTAV As New DataTable
        mycommand.CommandText = "SELECT lm.CompRec, sDt.Amount As AmtSale, sDt.idProduct As idInvMain , sDt.* " & vbNewLine &
                                    "FROM SmSaleDtAll sDt" & vbNewLine &
                                    "LEFT JOIN dInvLotMain lm ON sDt.idLot = lm.idLot" & vbNewLine &
                                    "WHERE idSaleDt NOT IN (SELECT idDtRef " & vbNewLine &
                                                            "FROM WimWaitCutDt dt" & vbNewLine &
                                                            "LEFT JOIN WimWaitCutMt mt ON dt.idWaitCutMt = mt.idWaitCutMt" & vbNewLine &
                                                            "WHERE dt.idWaitCutMt =" & idWaitMtAV & vbNewLine &
                                                            "AND mt.ProcessID = 4)" & vbNewLine &
                                    "AND sDt.idSale =" & idSaleAV & vbNewLine &
                                    "AND lm.CompRec = 4" & vbNewLine &
                                    "AND sDt.idProduct <> 9766"

        myAdapter.Fill(dtSlExWaitDTAV)

        For i As Integer = 0 To dtSlExWaitDTAV.Rows.Count - 1
            Dim dr As DataRow = dtSlExWaitDTAV.Rows(i)

            fnInsertxWaitCutDt(mycommand, dr.Item("idSaleDt"), idWaitMtAV, dr)
        Next

        '--- 3: UPDATE WimWaitCutDt 
        '---3.1 UPDATE ST
        Dim dtUpdateWaitDtST As New DataTable
        mycommand.CommandText = "SELECT * " & vbNewLine &
                                 "FROM SmSaleDtAll sDt" & vbNewLine &
                                  "LEFT JOIN dInvLotMain lm ON sDt.idLot = lm.idLot" & vbNewLine &
                                 "WHERE sDt.idSale =" & idSaleST & vbNewLine &
                                 "AND lm.CompRec = 10"

        myAdapter.Fill(dtUpdateWaitDtST)

        For i As Integer = 0 To dtUpdateWaitDtST.Rows.Count - 1
            Dim dr As DataRow = dtUpdateWaitDtST.Rows(i)

            mycommand.CommandText = "UPDATE WimWaitCutDt SET " & vbNewLine &
                                    "WimWaitCutDt.idLot = " & dr.Item("idLot") & "," & vbNewLine &
                                    "WimWaitCutDt.idDtRef = " & dr.Item("idSaleDt") & "," & vbNewLine &
                                    "WimWaitCutDt.idInvMain	= " & dr.Item("idProduct") & "," & vbNewLine &
                                    "WimWaitCutDt.AmountWait = " & dr.Item("Amount") & "," & vbNewLine &
                                    "WimWaitCutDt.AmountWaitBal = " & dr.Item("Amount") & "," & vbNewLine &
                                    "WimWaitCutDt.idUnitNew = " & dr.Item("idUnit") & "," & vbNewLine &
                                    "WimWaitCutDt.idwh	 = " & dr.Item("idwh") & "," & vbNewLine &
                                    "WimWaitCutDt.idRefLot	 = " & dr.Item("idRefLot") & "," & vbNewLine &
                                    "WimWaitCutDt.AmountWaitChange = [devsk].[WimWaitCutDtCalAmtUnit](" & dr.Item("idProduct") & "," & dr.Item("idUnit") & "," & dr.Item("Amount") & ")" & vbNewLine &
                                    "FROM WimWaitCutDt " & vbNewLine &
                                    "LEFT JOIN SmSaleDtAll ON WimWaitCutDt.idDtRef =  SmSaleDtAll.idSaleDt" & vbNewLine &
                                    "WHERE SmSaleDtAll.idSale = " & idSaleST & vbNewLine &
                                    "AND WimWaitCutDt.idDtRef = " & dr.Item("idSaleDt") & vbNewLine &
                                    "AND IdWaitCutMt = " & idWaitMtST
            mycommand.ExecuteNonQuery()
        Next

        '---3.2 UPDATE AV
        Dim dtUpdateWaitDtAV As New DataTable
        mycommand.CommandText = "SELECT * " & vbNewLine &
                                 "FROM SmSaleDtAll sDt" & vbNewLine &
                                  "LEFT JOIN dInvLotMain lm ON sDt.idLot = lm.idLot" & vbNewLine &
                                 "WHERE sDt.idSale =" & idSaleAV & vbNewLine &
                                 "AND lm.CompRec = 4"

        myAdapter.Fill(dtUpdateWaitDtAV)

        For i As Integer = 0 To dtUpdateWaitDtAV.Rows.Count - 1
            Dim dr As DataRow = dtUpdateWaitDtAV.Rows(i)

            mycommand.CommandText = "UPDATE WimWaitCutDt SET " & vbNewLine &
                                    "WimWaitCutDt.idLot = " & dr.Item("idLot") & "," & vbNewLine &
                                    "WimWaitCutDt.idDtRef = " & dr.Item("idSaleDt") & "," & vbNewLine &
                                    "WimWaitCutDt.idInvMain	= " & dr.Item("idProduct") & "," & vbNewLine &
                                    "WimWaitCutDt.AmountWait = " & dr.Item("Amount") & "," & vbNewLine &
                                    "WimWaitCutDt.AmountWaitBal = " & dr.Item("Amount") & "," & vbNewLine &
                                    "WimWaitCutDt.idUnitNew = " & dr.Item("idUnit") & "," & vbNewLine &
                                    "WimWaitCutDt.idwh	 = " & dr.Item("idwh") & "," & vbNewLine &
                                    "WimWaitCutDt.AmountWaitChange = [devsk].[WimWaitCutDtCalAmtUnit](" & dr.Item("idProduct") & "," & dr.Item("idUnit") & "," & dr.Item("Amount") & ")" & vbNewLine &
                                    "FROM WimWaitCutDt " & vbNewLine &
                                    "LEFT JOIN SmSaleDtAll ON WimWaitCutDt.idDtRef =  SmSaleDtAll.idSaleDt" & vbNewLine &
                                    "WHERE SmSaleDtAll.idSale = " & idSaleAV & vbNewLine &
                                    "AND WimWaitCutDt.idDtRef = " & dr.Item("idSaleDt") & vbNewLine &
                                    "AND IdWaitCutMt = " & idWaitMtAV
            mycommand.ExecuteNonQuery()
        Next

        '---1.1 ถ้า Dt ของบริษัท ST ถูกลบทั้งหมดให้ลบ Mt ด้วย
        Dim dtChkCountDtST As New DataTable

        mycommand.CommandText = "SELECT * " & vbNewLine &
                                "FROM  WimWaitCutDt " & vbNewLine &
                                "WHERE idWaitCutMt =" & idWaitMtST
        myAdapter.Fill(dtChkCountDtST)

        If dtChkCountDtST.Rows.Count = 0 Then
            mycommand.CommandText = "DELETE WimWaitCutMt  " & vbNewLine &
                                    "FROM WimWaitCutMt " & vbNewLine &
                                    "WHERE idWaitCutMt =" & idWaitMtST
            mycommand.ExecuteNonQuery()

        End If

        '---1.2 ถ้า Dt ของบริษัท AV ถูกลบทั้งหมดให้ลบ Mt ด้วย
        Dim dtChkCountDtAV As New DataTable

        mycommand.CommandText = "SELECT * " & vbNewLine &
                                "FROM  WimWaitCutDt " & vbNewLine &
                                "WHERE idWaitCutMt =" & idWaitMtAV
        myAdapter.Fill(dtChkCountDtAV)

        If dtChkCountDtAV.Rows.Count = 0 Then

            mycommand.CommandText = "DELETE WimWaitCutMt  " & vbNewLine &
                                     "FROM WimWaitCutMt " & vbNewLine &
                                     "WHERE idWaitCutMt =" & idWaitMtAV
            mycommand.ExecuteNonQuery()
        End If


    End Sub



    Private Sub EditSmSaleMtAndDtxCutStock(ByVal mycommand As SqlCommand) 'Edit
        SumSvFree = 0
        Dim stRight As Integer = 0
        '  mdCnOpen()
        '---Update SmSaleMt Table---'
        Dim stPrice As String = ""
        'Dim LevelDis As String = ""
        Dim DocRef As String = ""
        Dim stfield As String = ""

        If eEvent = eProcess.eEditCombine Then 'Edit สินค้ารวมทุกประเภท
            If stBType = 6 Then 'แก้ไข ขายสินค้าในเครือ
                stfield = ", stBillType = '6' "
            ElseIf stBType = 8 Then 'แก้ไข สินค้ารวมทุกประเภท
                stfield = ", stBillType = '8' "
            End If
        End If

        If Me.rdbWhole.Checked = True Then
            stPrice = "3"
        ElseIf Me.rdbRetail.Checked = True Then
            stPrice = "2"
        ElseIf Me.rdbBill.Checked = True Then
            stPrice = "1"
        Else
            stPrice = " NULL"
        End If

        Dim vidSupTsp As String
        If Me.lblTspComp.Tag = Nothing Then
            vidSupTsp = " NULL"
        Else
            vidSupTsp = Me.lblTspComp.Tag
        End If

        Dim vidCusRefAddr As String
        If Me.lblAddr.Tag = 0 Then
            vidCusRefAddr = " NULL"
        Else
            vidCusRefAddr = Me.lblAddr.Tag
        End If

        If Me.rdbRight.Checked = True Then
            stRight = 1
        ElseIf Me.rdbNoRight.Checked = True Then
            stRight = 0
        End If

        DocRef = Me.cmbDRCode.Text & " " & Trim(Me.txtDocRef.Text)

        Dim myAdapter = New SqlDataAdapter(mycommand)

        Dim Note As String = "" 'txtNote.Text
        Dim stSend As Integer = 0
        Dim count As Integer = dt_Note.Rows.Count

        If count = 0 Then
            Note = ""
        Else
            Note = gvNote.GetDataRow(0).Item("Note")

            For i As Integer = 1 To gvNote.DataRowCount - 1
                Note &= "\" & gvNote.GetDataRow(i).Item("Note")
            Next
            Note = Note.Replace("'", "''")
        End If

        Dim dtpSaleD As DateTime = Convert.ToDateTime(dtpSale.Value, _cultureEnInfo)

        Dim stridCus As String = ""

        If idFm = 0 And idCus <> 0 Then
            stridCus = "idCus = " & lblPsCus.Tag & ", idFm = NULL, idPartner = " & idPartner

        ElseIf idFm <> 0 And idCus = 0 Then

            stridCus = "idCus = NULL, idFm = " & idFm & ", idPartner = " & idPartner

        ElseIf idFm <> 0 And idCus <> 0 Then
            stridCus = "idCus = " & lblPsCus.Tag & ", idFm = " & idFm & ", idPartner = " & idPartner
        End If

        'Try
        mycommand.CommandText = "Update SmSaleMt Set DateSale ='" & ksbDateToString(dtpSale.Value.ToShortDateString) & "', " & vbNewLine &
                                "DateSaleD = '" & dtpSaleD.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "'," & vbNewLine &
                                "DatePay = '" & ksbDateToString(dtpPay.Value.ToShortDateString) & "', " & vbNewLine &
                                "DateTs = '" & ksbDateToString(Date.Today) & "', TimeTs = CONVERT(VARCHAR(5),GETDATE(),108), " & vbNewLine &
                                "DateTsD = GETDATE()," & vbNewLine &
                                "DocCode = '" & lblDocCode.Text & "', idSaleCode = '" & Me.cmbDRCode.SelectedValue & "', DocRef = '" & DocRef & "', " & vbNewLine &
                                "Note = '" & Note & "', TotalNet='" & CDbl(txtTotalNet.Text) & "', Total = '" & CDbl(txtTotalNet.Text) & "' ," & vbNewLine &
                                "" & stridCus & ", idPsTs = '" & sPsId & "', idPsSale='" & lblPsSale.Tag & "', " & vbNewLine &
                                "stPay = '', idPM ='" & cmbTp.SelectedValue & "', idTS ='" & CmbTs.SelectedValue & "', " & vbNewLine &
                                "idPayTsp = " & cmbTypePayTrp.SelectedValue & ", idSupTsp = " & vidSupTsp & ", " & vbNewLine &
                                "idCusRefAddr = " & vidCusRefAddr & ", stRight = '" & stRight & "'" & stfield & vbNewLine &
                                ",stPrice = " & stPrice & ", " & vbNewLine &
                                "PartnerNameBill = '" & Trim(lblPsCus.Text) & "'" & vbNewLine &
                                "Where idSale = '" & idSaleS & "'"
        mycommand.ExecuteNonQuery()

        ' Dim ToTalBfDis1 As Double = 0.0

        'Case 2: Row Delete
        If dtDel.Rows.Count > 0 Then
            For j As Integer = 0 To dtDel.Rows.Count - 1
                Dim drDel As DataRow = dtDel.Rows(j)

                ''-----Delete From New Structure
                ''----คืนสต๊อก เมื่อมีการลบ Row ทิ้ง
                If drDel.Item("idLot") <> 0 Then

                    Dim CalAmtDel As Double = 0.0

                    CalAmtDel = fnCalAmtxUnit(mycommand, drDel.Item("idUnit"), drDel.Item("idInvGroup"), drDel.Item("AmtSale"), drDel.Item("idInvMain"))


                    InvLotMainUpdate(1, drDel.Item("idInvMain"), drDel.Item("idLot"), CalAmtDel,
                                    "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", drDel.Item("LotNo"), drDel.Item("idWh"), mycommand)

                End If

                mycommand.CommandText = "DELETE FROM SmSaleDtAll WHERE idSaleDt = " & drDel.Item("idSaleDt")
                mycommand.ExecuteNonQuery()

            Next
        End If

        For i As Integer = 0 To DGVBind.DataRowCount - 1
            '
            Dim dr As DataRow = DGVBind.GetDataRow(i)

            If dr.Item("idInvGroup") = 30 Then
                SumSvFree = SumSvFree + dr.Item("Total")
            End If

            'Case 1: insert New Row/Lot
            If dr.Item("idSaleDt") = 0 Then
                'AddSmSaleDtAll(mycommand, dr, idSaleS, i + 1)
                fnNewAddSmSaleDtAll(mycommand, dr, idSaleS, i + 1, 0)
            End If

            'Case 3: Edit Data On Old Row
            If dr.Item("idSaleDt") <> 0 Then

                If dr.Item("AmtSale") <> dr.Item("AmtSaleHide") Or dr.Item("PriceNormal") <> dr.Item("PriceNormalHide") _
                    Or dr.Item("PercDisc") <> dr.Item("PercDiscHide") Or dr.Item("BathDisc") <> dr.Item("BathDiscHide") _
                    Or dr.Item("PriceSale") <> dr.Item("PriceSaleHide") Or dr.Item("idInvMain") <> dr.Item("idInvMainHide") _
                    Or dr.Item("idLot") <> dr.Item("idLotHide") Then

                    Dim stLotChange As Integer = 0

                    If dr.Item("AmtSale") <> dr.Item("AmtSaleHide") And dr.Item("idLot") = dr.Item("idLotHide") Then

                        Dim CalAmtHide As Double = 0.0
                        Dim CalAmt As Double = 0.0
                        CalAmtHide = fnCalAmtxUnit(mycommand, dr.Item("idUnit"), dr.Item("idInvGroup"), dr.Item("AmtSaleHide"), dr.Item("idInvMain"))
                        CalAmt = fnCalAmtxUnit(mycommand, dr.Item("idUnit"), dr.Item("idInvGroup"), dr.Item("AmtSale"), dr.Item("idInvMain"))

                        ' คืนสต๊อก จำนวนขาย เก่า (Lot เดิม)
                        InvLotMainUpdate(1, dr.Item("idInvMain"), dr.Item("idLot"), CalAmtHide,
                                     "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", dr.Item("LotNo"), dr.Item("idWh"), mycommand)

                        ' ตัดสต๊อก จำนวนขาย ใหม่ (Lot เดิม)
                        InvLotMainUpdate(2, dr.Item("idInvMain"), dr.Item("idLot"), CalAmt,
                                    "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", dr.Item("LotNo"), dr.Item("idWh"), mycommand)

                    End If

                    mycommand.CommandText = "UPDATE SmSaleDtAll SET " & vbNewLine &
                                            "Amount = " & dr.Item("AmtSale") & " , " & vbNewLine &
                                            "PriceBfDis = " & dr.Item("PriceNormal") & " , " & vbNewLine &
                                            "DiscountPerc = " & dr.Item("PercDisc") & " , " & vbNewLine &
                                            "DiscountBath = " & dr.Item("BathDisc") & " , " & vbNewLine &
                                            "Price = " & dr.Item("PriceSale") & vbNewLine &
                                            "WHERE idSaleDt =  " & dr.Item("idSaleDt")
                    mycommand.ExecuteNonQuery()

                    If dr.Item("idInvMain") <> dr.Item("idInvMainHide") Then
                        Dim ProductName As String = Trim(dr.Item("ProductName"))
                        ProductName = Replace(ProductName, "'", "''")

                        mycommand.CommandText = "UPDATE SmSaleDtAll SET " & vbNewLine &
                                             "idProduct = " & dr.Item("idInvMain") & " , " & vbNewLine &
                                             "ProductName = '" & ProductName & "' , " & vbNewLine &
                                             "idUnit = " & dr.Item("idUnit") & vbNewLine &
                                             "WHERE idSaleDt =  " & dr.Item("idSaleDt")
                        mycommand.ExecuteNonQuery()

                        Dim CalAmtHide As Double = 0.0
                        Dim CalAmt As Double = 0.0
                        CalAmtHide = fnCalAmtxUnit(mycommand, dr.Item("idUnit"), dr.Item("idInvGroup"), dr.Item("AmtSaleHide"), dr.Item("idInvMainHide"))
                        CalAmt = fnCalAmtxUnit(mycommand, dr.Item("idUnit"), dr.Item("idInvGroup"), dr.Item("AmtSale"), dr.Item("idInvMain"))


                        ' คืนสต๊อก idInvMain เก่า (Lot เก่าด้วย)
                        InvLotMainUpdate(1, dr.Item("idInvMainHide"), dr.Item("idLotHide"), CalAmtHide,
                                     "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", dr.Item("LotNoHide"), dr.Item("idWhHide"), mycommand)

                        ' ตัดสต๊อก idInvMain ใหม่ (Lot ใหม่ ด้วย)
                        InvLotMainUpdate(2, dr.Item("idInvMain"), dr.Item("idLot"), CalAmt,
                                    "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", dr.Item("LotNo"), dr.Item("idWh"), mycommand)

                        stLotChange = 1
                    End If

                    If dr.Item("idLot") <> dr.Item("idLotHide") Then
                        mycommand.CommandText = "UPDATE SmSaleDtAll SET " & vbNewLine &
                                                "idLot = " & dr.Item("idLot") & " , " & vbNewLine &
                                                "LotNo = '" & dr.Item("LotNo") & "'," & vbNewLine &
                                                "idWh = " & dr.Item("idWh") & "" & vbNewLine &
                                                "WHERE idSaleDt = " & dr.Item("idSaleDt")
                        mycommand.ExecuteNonQuery()

                        If stLotChange = 0 Then
                            ' คืนสต๊อก Lot เก่า
                            InvLotMainUpdate(1, dr.Item("idInvMainHide"), dr.Item("idLotHide"), CDbl(dr.Item("AmtSaleHide")),
                                         "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", dr.Item("LotNoHide"), dr.Item("idWhHide"), mycommand)

                            ' ตัดสต๊อก Lot ใหม่
                            InvLotMainUpdate(2, dr.Item("idInvMain"), dr.Item("idLot"), CDbl(dr.Item("AmtSale")),
                                        "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", dr.Item("LotNo"), dr.Item("idWh"), mycommand)
                        End If


                    End If

                    '--- แจ้งเตือน เมื่อมีการเปลี่ยนแปลงราคา
                    If dr.Item("PriceSale") <> dr.Item("PriceSaleHide") Then

                        If stRecWIM = 1 Then
                            If Not IsDBNull(dr.Item("stEdit")) Then
                                Dim dtStApp As New DataTable
                                mycommand.CommandText = "SELECT IsNULL(stApprove,0) As stApprove, idTs " & vbNewLine &
                                                        "FROM EditSaleSAMxWIM " & vbNewLine &
                                                        "WHERE idSale = " & idSaleS & vbNewLine &
                                                        "AND idSaleDt = " & dr.Item("idSaleDt") & vbNewLine &
                                                        "Order by  idTs DESC"
                                myAdapter.Fill(dtStApp)

                                If dtStApp.Rows.Count = 0 Then
                                    mycommand.CommandText = "INSERT INTO EditSaleSAMxWIM (DateTs, idPsTs, idSaleDt, idSale, Note) " & vbNewLine &
                                                               "VALUES ( GETDATE()," & sPsId & ", " & dr.Item("idSaleDt") & "," & idSaleS & ",'" & Trim(NoteChangePrice) & "')"
                                    mycommand.ExecuteNonQuery()

                                ElseIf dtStApp.Rows(0).Item("stApprove") = 1 Then

                                    mycommand.CommandText = "INSERT INTO EditSaleSAMxWIM (DateTs, idPsTs, idSaleDt, idSale, Note) " & vbNewLine &
                                                           "VALUES ( GETDATE()," & sPsId & ", " & dr.Item("idSaleDt") & "," & idSaleS & ",'" & Trim(NoteChangePrice) & "')"
                                    mycommand.ExecuteNonQuery()
                                ElseIf dtStApp.Rows(0).Item("stApprove") = 0 Then

                                    mycommand.CommandText = "Update EditSaleSAMxWIM Set DateTs = GETDATE(), idPsTs = " & sPsId & ", Note = '" & Trim(NoteChangePrice) & "' Where idTs = " & dtStApp.Rows(0).Item("idTs")
                                    mycommand.ExecuteNonQuery()
                                End If

                                If stSend = 0 Then
                                    fnLineNotiWhenPriceChange(mycommand)
                                    stSend = 1
                                End If

                            End If
                        End If
                    End If
                End If
            End If

            mycommand.CommandText = "Update SmSaleDtAll Set No = " & i + 1 & " WHERE idSaleDt = " & dr.Item("idSaleDt")
            mycommand.ExecuteNonQuery()

        Next

        '---- Update SumService in SmSaleMt ----'
        mycommand.CommandText = "Update SmSaleMt Set SumService = " & SumSvFree & " WHERE idSale = " & idSaleS
        mycommand.ExecuteNonQuery()
    End Sub
#Region "SaleBtwAVxST"

    Private Function fnSlBtwAVxStar(ByVal mycommand As SqlCommand) As Integer

        Dim myAdapter As New SqlDataAdapter(mycommand)


        Dim getDate As String = CType(Date.Today, String)
        Dim YAndM As String = Microsoft.VisualBasic.Left(ksbDateToString(Date.Today), 6)
        Dim YAndM_Cut As String = Microsoft.VisualBasic.Right(YAndM, 4)
        Dim Prefixcode As String = (Microsoft.VisualBasic.Right(getDate, 2))

        Dim sDocCode As String = getDocCode(mycommand, Prefixcode)
        Dim sDocRefAcc As String = getDocRefAcc(mycommand, YAndM_Cut, 4) ' AV ขายให้ ST
        Dim sDocRef As String = "111" & " " & YAndM_Cut

        Dim nextOrder As String = ""

        Dim sDt As New DataTable
        mycommand.CommandText = "SELECT MAX(DocRef) as max_DocRef FROM SmSaleMt " &
                               "WHERE SUBSTRING(DocRef,1,8) = '" & sDocRef & "' AND idComp = 4 AND idPartner = 2851"
        myAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocRef")) = True Then
            sDocRef = "111" & " " & YAndM_Cut & "0001"
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

            sDocRef = "111" & " " & YAndM_Cut & nextOrder

        End If

        'STEP 1: Insert SmSaleMt/SmSaleDtAll (Sale AV: Customer: Star)
        '--- Fix Parameter ---
        '---idSaleCode : 2 (SaleCode is 111)
        '---BillType : 6 (ขายในเครือ)
        '---idComp : 4 (AV เป็นผู้ขายให้ ST)
        '---idPsSale : 0 (เป็น Auto Bill ไม่มี พนง ขาย)
        '---idPartner : 2851 (ลูกค้า บจก.สตาร์อะกรีเทค )
        '---idCus : 2873 (ลูกค้า บจก.สตาร์อะกรีเทค )
        '---PartnerNameBill : (ลูกค้า บจก.สตาร์อะกรีเทค )
        '---idTranSport : 7 (ลูกค้ามารับเอง)
        '---idPayMent : 50 (เครดิต 60 วัน)
        '---stRight : 0 (ไม่ถูกหลักสรรพากร)
        Dim idSaleAV As Integer = 0

        Dim vWHERE As String = ""
        If eEvent = eProcess.eEditCombine Then 'EditData
            vWHERE = " AND idSale <> " & idSaleS & ""
        End If

        '---บันทึก AV ขาย ST
        idSaleAV = fnNewAddSmSaleMt(mycommand, 0, sDocCode, sDocRefAcc, 2, sDocRef, "", 0, 6, 50, 7, 0, 4, 2851, "บจก.สตาร์อะกรีเทค ", 2873, 0, 1, 0, 0)

        '-----บันทึก ST ขาย ลูกค้า
        sDocCode = getDocCode(mycommand, Prefixcode)
        sDocRefAcc = getDocRefAcc(mycommand, YAndM_Cut, cmbGroupComp.SelectedValue)
        Dim DocRef As String = Me.cmbDRCode.Text & " " & Trim(Me.txtDocRef.Text)
        Dim stRight As Integer = 0
        Dim NoteMt As String = ""
        Dim count As Integer = dt_Note.Rows.Count

        If count = 0 Then
            NoteMt = ""
        Else
            NoteMt = gvNote.GetDataRow(0).Item("Note")

            For i As Integer = 1 To gvNote.DataRowCount - 1
                NoteMt &= "\" & gvNote.GetDataRow(i).Item("Note")
            Next
            NoteMt = NoteMt.Replace("'", "''")
        End If

        If Me.rdbRight.Checked = True Then
            stRight = 1
        ElseIf Me.rdbNoRight.Checked = True Then
            stRight = 0
        End If

        Dim idSaleST As Integer = 0
        Dim stBillType As Integer = 8 'นอกเครือ

        If stASG <> 0 Then
            stBillType = 6 'ในเครือ
        End If

        idSaleST = fnNewAddSmSaleMt(mycommand, 0, sDocCode, sDocRefAcc, cmbDRCode.SelectedValue, DocRef, NoteMt, lblPsSale.Tag, stBillType,
                                  cmbTp.SelectedValue, CmbTs.SelectedValue, stRight, cmbGroupComp.SelectedValue, idPartner, Trim(lblPsCus.Text), lblPsCus.Tag, idFm,
                                  cmbTypePayTrp.SelectedValue, Me.lblTspComp.Tag, lblAddr.Tag)

        '----Update idSlAVxST (idSale ของ ST ขายให้ลูกค้า) ที่บิลของ AV ขายให้ ST
        mycommand.CommandText = "UPDATE SmSaleMt SET idSlAVxST = " & idSaleST & " Where idSale = " & idSaleAV
        mycommand.ExecuteNonQuery()

        Dim SumTotalExTrans As Double = 0.0
        'Dim SumTransport As Double = 0.0
        If DGVBind.DataRowCount > 0 Then 'มีรายการสินค้า
            '--- Insert SmSaleDtAll----'

            Dim idWaitCutST As Integer = 0
            Dim idWaitCutAV As Integer = 0

            For i As Integer = 0 To DGVBind.DataRowCount - 1
                Dim idSaleDtAV As Integer = 0

                Dim dr As DataRow = DGVBind.GetDataRow(i)

                If dr.Item("idInvMain") <> 9766 Then
                    SumTotalExTrans = SumTotalExTrans + dr.Item("Total")
                    'ElseIf dr.Item("idInvMain") = 9766 Then
                    '    SumTransport = SumTransport + dr.Item("Total")
                End If

                '---บันทึกรายการขายสินค้าขาย AV ให้ ST
                idSaleDtAV = fnNewAddSmSaleDtAll(mycommand, dr, idSaleAV, i + 1, 1)

                '---บันทึกรายการขายสินค้าของ ST ให้ลูกค้า
                Dim idSaleDtST As Integer = fnNewAddSmSaleDtAll(mycommand, dr, idSaleST, i + 1, 0)

                mycommand.CommandText = "UPDATE SmSaleDtAll SET idSaleDtAVxST = " & idSaleDtST & "Where idSaleDt = " & idSaleDtAV
                mycommand.ExecuteNonQuery()

                'กรณี CompRec ของ idLot = 10 อยู่แล้ว ให้ส่งเบิกเป็นidComp 10 เลย
                If dr.Item("CompRec") = cmbGroupComp.SelectedValue Then
                    If idWaitCutST = 0 Then
                        idWaitCutST = fnInsertxWaitCutMt(mycommand, DocRef, NoteMt, idSaleST, dr.Item("CompRec"), Date.Now, Date.Now)
                    End If

                    If dr.Item("idInvMain") <> 9766 Then
                        fnInsertxWaitCutDt(mycommand, idSaleDtST, idWaitCutST, dr)
                    End If

                Else
                    If idWaitCutAV = 0 Then
                        idWaitCutAV = fnInsertxWaitCutMt(mycommand, DocRef, NoteMt, idSaleAV, 4, Date.Now, Date.Now)
                    End If

                    fnInsertxWaitCutDt(mycommand, idSaleDtAV, idWaitCutAV, dr)
                End If
            Next
        End If

        Dim dtFTransport As New DataTable

        mycommand.CommandText = "SELECT idSaleDt FROM SmSaleDtAll WHERE idSale = " & idSaleAV & " AND idProduct = 9766"
        myAdapter.Fill(dtFTransport)

        For i As Integer = 0 To dtFTransport.Rows.Count - 1
            mycommand.CommandText = "DELETE SmSaleDtAll " & vbNewLine &
                                    "FROM SmSaleDtAll " & vbNewLine &
                                    "WHERE idSaleDt = " & dtFTransport.Rows(i).Item("idSaleDt")

            mycommand.ExecuteNonQuery()
        Next

        'Dim idWaitCutMtAV As Integer = 0
        ''---ส่งไปรอเบิก เพื่อตัดของจากคลัง AV 
        'mycommand.CommandText = "EXEC WaitCutTs '4','SmSaleMt','SmSaleDtAll','idSale'," & idSaleAV & "," & 4 & "," & sPsId & ",'1'"
        'mycommand.ExecuteNonQuery()

        'Dim qr2 As String = "Select @@Identity"
        'mycommand.CommandText = qr2

        'idWaitCutMtAV = mycommand.ExecuteScalar()


        ''----ลบรายการรอเบิก ที่ Lot CompRec = 10
        'Dim dtCompRec As New DataTable

        'mycommand.CommandText = "SELECT idWaitCutDt " & vbNewLine & _
        '                        "FROM WimWaitCutDt dt" & vbNewLine & _
        '                        "LEFT JOIN dInvLotMain lm ON dt.idLot = lm.idLot" & vbNewLine & _
        '                        "WHERE lm.CompRec = " & cmbGroupComp.SelectedValue & vbNewLine & _
        '                        "AND idWaitCutMt = " & idWaitCutMtAV
        'myAdapter.Fill(dtCompRec)

        'For i As Integer = 0 To dtCompRec.Rows.Count - 1
        '    mycommand.CommandText = "DELETE WimWaitCutDt " & vbNewLine & _
        '                            "FROM WimWaitCutDt " & vbNewLine & _
        '                            "WHERE idWaitCutDt = " & dtCompRec.Rows(i).Item("idWaitCutDt")

        '    mycommand.ExecuteNonQuery()
        'Next

        mycommand.CommandText = "Update SmSaleMt Set SumService = " & SumSvFree & " WHERE idSale = " & idSaleST
        mycommand.ExecuteNonQuery()


        mycommand.CommandText = "UPDATE SmSaleMt SET Total = " & SumTotalExTrans & ",TotalNet = " & SumTotalExTrans & ", SumService = 0.0" & vbNewLine &
                               "Where idSale = " & idSaleAV
        mycommand.ExecuteNonQuery()

        If stDraft = 1 Then
            mycommand.CommandText = "UPDATE WimWaitCutMt SET stNoApprove = 1 WHERE idMt = " & idSaleAV & " AND ProcessId = 4"
            mycommand.ExecuteNonQuery()
        Else
            mycommand.CommandText = "UPDATE WimWaitCutMt SET stNoApprove = NULL WHERE idMt = " & idSaleAV & " AND ProcessId = 4"
            mycommand.ExecuteNonQuery()
        End If


        Return idSaleST
    End Function

    Function fnInsertxWaitCutMt(ByVal mycommand As SqlCommand, ByVal DocRef As String, ByVal NoteMt As String, ByVal idSaleST As Integer,
                           ByVal CompRec As Integer, ByVal DocDate As DateTime, ByVal DateTs As DateTime) As Integer

        Dim idWaitCutMt As Integer = 0
        mycommand.CommandText = "INSERT Into WimWaitCutMt (DocCode,DocDate,Note,ProcessID,ProcessName, SystemRef,TbName, IdMt,idcomp,IdPsTs,DateTs)" & vbNewLine &
                                           "VALUES(@DocCode, @DocDate, @Note, @ProcessID, @ProcessName, @SystemRef, @TbName, @IdMt, @idcomp, @IdPsTs, @DateTs)"

        With mycommand.Parameters
            .Add("@DocCode", SqlDbType.VarChar).Value = DocRef
            .Add("@DocDate", SqlDbType.DateTime).Value = DocDate
            .Add("@Note", SqlDbType.VarChar).Value = NoteMt
            .Add("@ProcessID", SqlDbType.Int).Value = 4
            .Add("@ProcessName", SqlDbType.VarChar).Value = "การขายสินค้า"
            .Add("@SystemRef", SqlDbType.VarChar).Value = "SAM"
            .Add("@TbName", SqlDbType.VarChar).Value = "SmSaleMt"
            .Add("@IdMt", SqlDbType.Int).Value = idSaleST
            .Add("@idcomp", SqlDbType.Int).Value = CompRec
            .Add("@IdPsTs", SqlDbType.Int).Value = sPsId
            .Add("@DateTs", SqlDbType.DateTime).Value = DateTs
        End With

        mycommand.ExecuteNonQuery()
        mycommand.Parameters.Clear()


        Dim qr2 As String = "Select @@Identity"
        mycommand.CommandText = qr2

        idWaitCutMt = mycommand.ExecuteScalar()

        Return idWaitCutMt
    End Function

    Private Sub fnInsertxWaitCutDt(ByVal mycommand As SqlCommand, ByVal idSaleDtST As Integer, ByVal idWaitCutMt As Integer, ByVal dr As DataRow)

        mycommand.CommandText = "INSERT Into WimWaitCutDt (idLot,idDtRef,idInvMain,AmountWait,AmountWaitBal,idUnitNew,idwh,idRefLot, AmountWaitChange,IdWaitCutMt)" & vbNewLine &
                                       "VALUES(@idLot,@idDtRef,@idInvMain,@AmountWait,@AmountWaitBal,@idUnitNew,@idwh, @idRefLot,[devsk].[WimWaitCutDtCalAmtUnit](" & dr.Item("idInvMain") & "," & dr.Item("idUnit") & "," & dr.Item("AmtSale") & "),@IdWaitCutMt)"

        With mycommand.Parameters
            .Add("@idLot", SqlDbType.Int).Value = dr.Item("idLot")
            .Add("@idDtRef", SqlDbType.Int).Value = idSaleDtST
            .Add("@idInvMain", SqlDbType.Int).Value = dr.Item("idInvMain")
            .Add("@AmountWait", SqlDbType.Float).Value = dr.Item("AmtSale")
            .Add("@AmountWaitBal", SqlDbType.Float).Value = dr.Item("AmtSale")
            .Add("@idUnitNew", SqlDbType.Int).Value = dr.Item("idUnit")
            .Add("@idwh", SqlDbType.Int).Value = dr.Item("idWh")
            .Add("@IdWaitCutMt", SqlDbType.Int).Value = idWaitCutMt
            .Add("idRefLot", SqlDbType.Int).Value = dr.Item("idRefLot")

        End With

        mycommand.ExecuteNonQuery()
        mycommand.Parameters.Clear()
    End Sub

    Function fnNewAddSmSaleMt(ByVal mycommand As SqlCommand, ByVal idSale As Integer, ByVal sDocCode As String, ByVal sDocRefAcc As String, ByVal idSaleCode As Integer, ByVal sDocRef As String,
                              ByVal NoteMt As String, ByVal sidPsSale As Integer, ByVal BillType As Integer, ByVal Payment As Integer, ByVal Transport As Integer,
                              ByVal stRight As Integer, ByVal idComp As Integer, ByVal sidPartner As Integer, ByVal PartnerNameBill As String, ByVal sidCus As Integer, ByVal sidFM As Integer,
                              ByVal idPayTs As Integer, ByVal idSupTsp As Integer, ByVal idCusRefAddr As Integer) As Integer


        If eEvent = eProcess.eEditCombine Then  'Update

            mycommand.CommandText = "UPDATE SmSaleMt SET DateSale = @DateSale, DateSaleD = @DateSaleD, DatePay = @DatePay, DateTs = @DateTs, DateTsD = @DateTsD, " &
                              "TimeTs = @TimeTs, DocCode = @DocCode, DocRefAcc = @DocRefAcc, idSaleCode =  @idSaleCode, DocRef = @DocRef, Note = @Note, " &
                              "TotalNet = @TotalNet, Total = @Total, idPsTs = @idPsTs, idPsSale = @idPsSale, stBillType = @stBillType, stPay = @stPay, idPM =  @idPM, " &
                              "idTS = @idTS, stRight = @stRight, idComp = @idComp, idPayTsp = @idPayTsp, idSupTsp = @idSupTsp, " &
                              "idCusRefAddr = @idCusRefAddr, stLot = @stLot, idPartner = @idPartner, PartnerNameBill = @PartnerNameBill, idCus = @idCus, idFM = @idFM, " &
                              "DiscountAmout = @DiscountAmout, DiscountPerc = @DiscountPerc, DiscountBath = @DiscountBath, idPsOrder = @idPsOrder) " &
                              "WHERE idSale = @idSale"

            mycommand.Parameters.Add("@idSale", SqlDbType.Int).Value = idSale

        ElseIf eEvent = eProcess.eAddCombine Then 'Insert

            mycommand.CommandText = "INSERT Into SmSaleMt(DateSale, DateSaleD, DatePay, DateTs, DateTsD, TimeTs, DocCode, DocRefAcc, idSaleCode, DocRef, Note, " &
                              "TotalNet, Total, idPsTs, idPsSale, stBillType, stPay, idPM, idTS, stRight, idComp, idPayTsp, idSupTsp, " &
                              "idCusRefAddr, stLot, idPartner, PartnerNameBill, idCus, idFM, DiscountAmout, DiscountPerc, DiscountBath, idPsOrder, DateSaleSys) " &
                              "Values(@DateSale, @DateSaleD, @DatePay, @DateTs, @DateTsD, @TimeTs, @DocCode, @DocRefAcc, @idSaleCode, @DocRef, @Note, @TotalNet, @Total," &
                              "@idPsTs, @idPsSale, @stBillType, @stPay, @idPM, @idTS, @stRight, @idComp, @idPayTsp, @idSupTsp, @idCusRefAddr, @stLot, @idPartner, @PartnerNameBill," &
                              "@idCus, @idFM, @DiscountAmout, @DiscountPerc, @DiscountBath, @idPsOrder, @DateSaleSys)"

        End If

        With mycommand.Parameters
            .Add("@DateSale", SqlDbType.VarChar).Value = ksbDateToString(dtpSale.Value.ToShortDateString) 'ตามหน้า
            .Add("@DateSaleD", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpSale.Value, _cultureEnInfo) 'ตามหน้า
            .Add("@DatePay", SqlDbType.VarChar).Value = ksbDateToString(dtpPay.Value.ToShortDateString) 'ตามหน้า
            .Add("@DateTs", SqlDbType.VarChar).Value = ksbDateToString(Date.Now.ToShortDateString) 'ตามหน้า
            .Add("@DateTsD", SqlDbType.DateTime).Value = Date.Now 'ตามหน้า
            .Add("@TimeTs", SqlDbType.VarChar).Value = DateTime.Now.ToShortTimeString 'ตามหน้า
            .Add("@DocCode", SqlDbType.VarChar).Value = sDocCode 'Parameter 
            .Add("@DocRefAcc", SqlDbType.VarChar).Value = sDocRefAcc 'Parameter 
            .Add("@idSaleCode", SqlDbType.Int).Value = idSaleCode 'Parameter (Me.cmbDRCode.SelectedValue)
            .Add("@DocRef", SqlDbType.VarChar).Value = sDocRef 'Parameter 
            .Add("@Note", SqlDbType.VarChar).Value = NoteMt 'Parameter (Note)
            .Add("@TotalNet", SqlDbType.Float).Value = CDbl(txtTotalNet.Text) 'ตามหน้า
            .Add("@Total", SqlDbType.Float).Value = CDbl(txtTotalBFDisc.Text) 'ยอด Total ก่อนหักส่วนลด
            .Add("@idPsTs", SqlDbType.Int).Value = stLbl_PsTs.Tag 'ตามหน้า
            .Add("@idPsSale", SqlDbType.Int).Value = sidPsSale  'Parameter (AutoBill เป็น 0)
            .Add("@stBillType", SqlDbType.Int).Value = BillType 'Parameter
            .Add("@stPay", SqlDbType.VarChar).Value = ""
            .Add("@idPM", SqlDbType.Int).Value = Payment
            .Add("@idTS", SqlDbType.Int).Value = Transport
            .Add("@stRight", SqlDbType.Int).Value = stRight 'Parameter (รอถาม)
            .Add("@idComp", SqlDbType.Int).Value = idComp 'Parameter
            .Add("@idPayTsp", SqlDbType.Int).Value = idPayTs 'cmbTypePayTrp.SelectedValue 'การจ่ายเงินขนส่ง
            .Add("@idSupTsp", SqlDbType.Int).Value = idSupTsp 'บริษัทขนส่ง
            .Add("@idCusRefAddr", SqlDbType.Int).Value = idCusRefAddr 'ที่อยู่จัดส่ง lblAddr
            .Add("@stLot", SqlDbType.Int).Value = 1
            .Add("@idPartner", SqlDbType.Int).Value = sidPartner 'Parameter
            .Add("@PartnerNameBill", SqlDbType.VarChar).Value = PartnerNameBill 'Parameter
            .Add("@idCus", SqlDbType.Int).Value = If(sidCus = 0, DBNull.Value, sidCus)  'Parameter
            .Add("@idFM", SqlDbType.Int).Value = If(sidFM = 0, DBNull.Value, sidFM)  'Parameter
            '----------------ADD ON 25.01.2567--------------------------
            .Add("@DiscountAmout", SqlDbType.Float).Value = CDbl(txtDiscBath.Text) 'จำนวนส่วนลด (Bath)
            .Add("@DiscountPerc", SqlDbType.Float).Value = CDbl(txtAmtPerc.Text) 'ให้ % ส่วนลด
            .Add("@DiscountBath", SqlDbType.Float).Value = CDbl(lblPerc.Text) ' คำนวณ % ส่วนลด จาก Total * จำนวน %/100
            .Add("@idPsOrder", SqlDbType.Int).Value = If(lblPsOrder.Tag Is Nothing Or lblPsOrder.Tag = 0, DBNull.Value, lblPsOrder.Tag)  'ผู้สั่ง (เพิ่ม label 29/3/67)
            .Add("@DateSaleSys", SqlDbType.DateTime).Value = DateTime.Now
        End With

        mycommand.ExecuteNonQuery()
        mycommand.Parameters.Clear()

        If idSale = 0 Then
            Dim qr2 As String = "Select @@Identity"
            mycommand.CommandText = qr2

            idSale = mycommand.ExecuteScalar()
        End If


        Return idSale
    End Function

    Private Function fnNewAddSmSaleDtAll(ByVal vCommand As SqlCommand, ByVal dr As DataRow, ByVal idSale As Integer, ByVal No As Integer, ByVal stAuto As Integer) As Integer
        'SumSvFree = 0
        Dim idSaleDt As Integer = 0
        Dim vAdapter = New SqlDataAdapter(vCommand)
        Dim strParameter As String = ""
        Dim strValue As String = ""

        Dim LotNo As String = ""

        If IsDBNull(dr.Item("LotNo")) Then
            LotNo = ""
        Else
            LotNo = Trim(dr.Item("LotNo"))
        End If

        '--------------DtType = 1 : สินค้าทั่วไป-------------
        If IsDBNull(dr.Item("CodeOrder")) Then  ' ไม่มี codeOrder
            strParameter = ""
            strValue = ""
        ElseIf dr.Item("CodeOrder") = Nothing Then
            strParameter = ""
            strValue = ""
        ElseIf dr.Item("CodeOrder") = "" Then
            strParameter = ""
            strValue = ""
        Else 'มี order
            strParameter = " idSaleOrderDt, CodeOrder,"
            strValue = dr.Item("idSaleOrderDt") & ", '" & dr.Item("CodeOrder") & "',"

            '---Update stBillOrder : SmSaleMt----'
            'vCommand.CommandText = "Update SmSaleMt Set stBillOrder = 1 WHERE idSale = '" & idSale & "'"
            'vCommand.ExecuteNonQuery()
        End If

        '---Update SmSaleOrderDt Table---'
        If stAuto = 0 Then 'stAuto = 0 : Update AmountSale ปกติ, stAuto = 1 : ไม่ต้อง Update เพราะเป็นเคส AUTO บิล AV ขาย ST
            If Not IsDBNull(dr.Item("idSaleOrderDt")) Then

                '--1. Update AmountSale + เข้าไปก่อน
                vCommand.CommandText = "UPDATE SmSaleOrderDt SET AmountSale =  (ISNULL(AmountSale,0) + " & dr.Item("AmtSale") & ")" & vbNewLine &
                                    "WHERE idSaleOrderDt=" & dr.Item("idSaleOrderDt")

                vCommand.ExecuteNonQuery()

                '--2. ตรวจสอบว่า AmountSale >= AmountOrder หรือยัง
                Dim stAllSaleDt As New DataTable
                vCommand.CommandText = "SELECT stAllSale, AmountPiece, IsNull(AmountSale,0) As AmountSale, idSaleOrder " & vbNewLine &
                                    "FROM SmSaleOrderDt  " & vbNewLine &
                                    "WHERE idSaleOrderDt = " & dr.Item("idSaleOrderDt")
                vAdapter.Fill(stAllSaleDt)

                If stAllSaleDt.Rows.Count > 0 Then
                    '--2.1 ถ้าจำนวนขาย >= จำนวนสั่งซื้อแล้ว ให้ Update stAllSale = 1
                    If stAllSaleDt.Rows(0).Item("AmountPiece") <= stAllSaleDt.Rows(0).Item("AmountSale") Then 'Order หมดแล้ว หรือ order เกิน
                        vCommand.CommandText = "Update SmSaleOrderDt Set stAllSale = 1" & vbNewLine &
                                                "WHERE idSaleOrderDt = " & dr.Item("idSaleOrderDt")
                        vCommand.ExecuteNonQuery()
                    End If


                    '--3. ตรวจสอบว่า ที่ OrderDt ขายครบทุกรายการสั่งซื้อแล้วหรือยัง
                    Dim dtOrd As New DataTable
                    vCommand.CommandText = "SELECT Sum(ISNULL(stAllSale,0)) SumAllSale, Count(idSaleOrderDt) As cntDt  " & vbNewLine &
                                           "FROM SmSaleOrderDt " & vbNewLine &
                                           "WHERE idSaleOrder = " & stAllSaleDt.Rows(0).Item("idSaleOrder") & vbNewLine &
                                           "AND idPsCancel Is NULL"
                    vAdapter.Fill(dtOrd)

                    If dtOrd.Rows.Count > 0 Then
                        If dtOrd.Rows(0).Item("SumAllSale") = dtOrd.Rows(0).Item("cntDt") Then
                            vCommand.CommandText = "UPDATE SmSaleOrderMt SET stOrd = 1 " & vbNewLine &
                                      "WHERE idSaleOrder = " & stAllSaleDt.Rows(0).Item("idSaleOrder")

                            vCommand.ExecuteNonQuery()
                        End If
                    End If
                End If
            End If
        End If

        '-----DtType = 3: สินค้าเมล็ดพันธุ์วัตถุดิบ------
        If dr.Item("idInvGroup") = 1 Then
            Dim CalAmt As Double = 0.0

            If dr.Item("idUnit") = 1 Then ' กรัม
                CalAmt = CDbl(dr.Item("AmtSale")) / 1000

            Else ' หน่วยอื่นๆ ที่ไม่ใช่กรัม + กิโลกรัม
                CalAmt = CDbl(dr.Item("AmtSale"))
                'idUnit = 3 ' หน่วยซอง
            End If

        ElseIf dr.Item("idInvGroup") = 30 Then
            ' รวมยอดค่าบริการ (ค่าขนส่ง)
            SumSvFree = SumSvFree + CDbl(dr.Item("Total"))
        End If


        Dim ProductName As String = Trim(dr.Item("ProductName"))
        ProductName = Replace(ProductName, "'", "''")

        If IsDBNull(dr.Item("pWeight")) Then
            dr.Item("pWeight") = 0
        End If

        If IsDBNull(dr.Item("idUnitW")) Then
            dr.Item("idUnitW") = 0
        End If

        If dr.Item("idInvGroup") = 1 Then
            dr.Item("pWeight") = 1
            dr.Item("idUnitW") = dr.Item("idUnit")
        End If


        'vCommand.CommandText = "INSERT Into SmSaleDtAll(idSale, " & strParameter & " idProduct, ProductName, idLot, LotNo, Amount, idUnit," & vbNewLine &
        '                        "PriceBfDis, DiscountPerc, DiscountBath, Price, stCutStock, No, DtType, idWh, idPkPORecDt, pWeight, idUnitW, TotalDt, idRefLot)" & vbNewLine &
        '                        "VALUES(" & idSale & ", " & strValue & dr.Item("idInvMain") & ", @ProductName, @idLot, @LotNo, @Amount, @idUnit," & vbNewLine &
        '                        "@PriceBfDis, @DiscountPerc, @DiscountBath, @Price, @stCutStock, @No, @DtType, @idWh, @idPkPORecDt, @pWeight, @idUnitW, @TotalDt, @idRefLot)"



        vCommand.CommandText = "INSERT Into SmSaleDtAll(idSale, " & strParameter & "idProduct, ProductName, idLot, LotNo, Amount, idUnit," & vbNewLine &
                                "PriceBfDis, DiscountPerc, DiscountBath, Price, stCutStock, No, DtType, idWh, idPkPORecDt, pWeight, idUnitW, TotalDt, idRefLot)" & vbNewLine &
                                "VALUES(@idSale, " & strValue & "@idProduct, @ProductName, @idLot, @LotNo, @Amount, @idUnit," & vbNewLine &
                                "@PriceBfDis, @DiscountPerc, @DiscountBath, @Price, @stCutStock, @No, @DtType, @idWh, @idPkPORecDt, @pWeight, @idUnitW, @TotalDt, @idRefLot)"

        With vCommand.Parameters
            .Add("@idSale", SqlDbType.Int).Value = idSale
            .Add("@idProduct", SqlDbType.Int).Value = dr.Item("idInvMain")
            .Add("@ProductName", SqlDbType.VarChar).Value = Trim(ProductName)
            .Add("@idLot", SqlDbType.Int).Value = dr.Item("idLot")
            .Add("@LotNo", SqlDbType.VarChar).Value = LotNo
            .Add("@Amount", SqlDbType.Float).Value = CDbl(dr.Item("AmtSale"))
            .Add("@idUnit", SqlDbType.Int).Value = dr.Item("idUnit")
            .Add("@PriceBfDis", SqlDbType.Float).Value = CDbl(dr.Item("PriceNormal"))
            .Add("@DiscountPerc", SqlDbType.Float).Value = CDbl(dr.Item("PercDisc"))
            .Add("@DiscountBath", SqlDbType.Float).Value = CDbl(dr.Item("BathDisc"))
            .Add("@Price", SqlDbType.Float).Value = CDbl(dr.Item("PriceSale"))
            .Add("@stCutStock", SqlDbType.Int).Value = 0 ' Send to cut On WimWaitCut
            .Add("@No", SqlDbType.Int).Value = No
            .Add("@DtType", SqlDbType.Int).Value = dr.Item("DtType")
            .Add("@idWh", SqlDbType.Int).Value = dr.Item("idWh")
            .Add("@idPkPORecDt", SqlDbType.Int).Value = dr.Item("idPkPORecDt")
            .Add("@pWeight", SqlDbType.Float).Value = If(dr.Item("pWeight") = 0, DBNull.Value, dr.Item("pWeight"))
            .Add("@idUnitW", SqlDbType.Int).Value = If(dr.Item("idUnitW") = 0, DBNull.Value, dr.Item("idUnitW"))
            .Add("@TotalDt", SqlDbType.Float).Value = CDbl(dr.Item("Total"))
            .Add("@idRefLot", SqlDbType.Int).Value = dr.Item("idRefLot")
        End With

        vCommand.ExecuteNonQuery()
        vCommand.Parameters.Clear()

        If idSaleDt = 0 Then
            Dim qr2 As String = "Select @@Identity"
            vCommand.CommandText = qr2

            idSaleDt = vCommand.ExecuteScalar()
        End If

        Return idSaleDt
    End Function


    Private Function fnChkDocCodeDup(ByVal myCommand As SqlCommand, DocRef As String, ByVal vWHERE As String) As Boolean
        'Check DocCode Duplicate Before Insert into Database
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim dtChkDup As New DataTable
        myCommand.CommandText = "Select mt.DocCode, mt.DateSale, mt.DocRef, mt.idPscancel, p.PartnerName  " & vbNewLine &
                               "From SmSaleMt mt " & vbNewLine &
                               "LEFT OUTER JOIN dPartner p ON mt.idPartner = p.idPartner " & vbNewLine &
                               "WHERE mt.idPscancel IS NULL " & vbNewLine &
                               "AND mt.DocRef = '" & DocRef & "' " & vbNewLine &
                               "AND mt.idComp = " & cmbGroupComp.SelectedValue & "" & vWHERE
        myAdapter.Fill(dtChkDup)


        'For i As Integer = 0 To dRefDt.Rows.Count - 1
        If dtChkDup.Rows.Count > 0 Then
            'If CodeRef = dRefDt.Rows(i).Item("DocRef") Then
            DocCodeChk = ""
            MessageBox.Show("เลขที่อ้างอิงซ้ำกับข้อมูลเดิม รายละเอียดรายการดังนี้ " & vbCrLf & "เลขที่รายการ : " & dtChkDup.Rows(0).Item("DocCode") & vbCrLf &
            "วันที่ขาย : " & ksbStringToDate(dtChkDup.Rows(0).Item("DateSale")) & vbCrLf &
            "ชื่อลูกค้า : " & dtChkDup.Rows(0).Item("PartnerName") & vbCrLf & vbCrLf &
            "***หากต้องการบันทึก ให้เพิ่มตัวอักษรหลังรหัส ดังนี้" & vbCrLf &
            "   A : แอ๊ดว้านซีดส์" & vbCrLf &
            "   F : โฟลเทคซีดส์" & vbCrLf & " เช่น 5710001A หรือ 5710001F", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' MessageBox.Show("เลขที่อ้างอิงซ้ำกับข้อมูลเดิม", sSystemName)

            Me.txtDocRef.Focus()
            Return True 'มีเลขที่อ้างอิงซ้ำ
            Exit Function
            'End If
        End If

        Return False 'ไม่มีเลขที่อ้างอิงซ้ำ
    End Function

    Private Sub EditSlAVxStar(ByVal mycommand As SqlCommand, ByVal idSaleAV As Integer) 'Edit

        Dim SumTotal As Double = 0.0
        Dim myAdapter As New SqlDataAdapter(mycommand)

        '--Update SmSaleMt (Auto Bill)
        'mycommand.CommandText = "UPDATE SET " & CDbl(txtTotalNet.Text)
        'Case 1: insert New Row/Lot
        Dim dtSlDtCaseAdd As New DataTable

        mycommand.CommandText = "SELECT idSaleDt, (SELECT idSale FROM SmSaleMt Where idSlAVxST = " & idSaleS & ") As idSaleAV , dt.idLot, dt.TotalDt As Total," & vbNewLine &
                                "idProduct As idInvMain, ProductName, dt.idUnit, idWh, dt.idRefLot, Amount As AmtSale, dt.LotNo, dt.CodeOrder, dt.idSaleOrderDt, dt.idPkPORecDt," & vbNewLine &
                                "PriceBfDis As PriceNormal, DiscountPerc As PercDisc, DiscountBath As BathDisc, Price As PriceSale, DtType, inv.idInvGroup, ISNULL(idLotSPM,0) As idLotSPM, ISNULL(dt.pWeight,0) As pWeight, ISNULL(idUnitW,0) As idUnitW " & vbNewLine &
                                "FROM SmSaleDtAll dt" & vbNewLine &
                                "LEFT JOIN dInventoryMain inv ON dt.idProduct = inv.idInvMain" & vbNewLine &
                                "LEFT JOIN dInvLotMain lm ON dt.idLot = lm.idLot" & vbNewLine &
                                "Where idSale = " & idSaleS & vbNewLine &
                                "AND idSaleDt Not IN (SELECT idSaleDtAVxST FROM SmSaleDtAll WHERE idSale = " & idSaleAV & ")" & vbNewLine &
                                "AND idProduct <> 9766"

        myAdapter.Fill(dtSlDtCaseAdd)

        If dtSlDtCaseAdd.Rows.Count > 0 Then
            For i As Integer = 0 To dtSlDtCaseAdd.Rows.Count - 1
                Dim dr As DataRow = dtSlDtCaseAdd.Rows(i)
                Dim idSaleDtAV As Integer = fnNewAddSmSaleDtAll(mycommand, dr, dtSlDtCaseAdd.Rows(i).Item("idSaleAV"), DGVBind.DataRowCount + 1, 1)

                mycommand.CommandText = "UPDATE SmSaleDtAll SET idSaleDtAVxST = " & dtSlDtCaseAdd.Rows(i).Item("idSaleDt") & "Where idSaleDt = " & idSaleDtAV
                mycommand.ExecuteNonQuery()
            Next
        End If

        'Case 2: Delete Row/Lot 
        Dim dtSlDtCaseDel As New DataTable

        mycommand.CommandText = "SELECT idSaleDt, (SELECT idSale FROM SmSaleMt Where idSlAVxST = " & idSaleS & ") As idSaleAV , idLot, " & vbNewLine &
                                "idProduct As idInvMain, ProductName, idUnit, idWh, Amount As AmtSale, LotNo," & vbNewLine &
                                "PriceBfDis As PriceNormal, DiscountPerc As PercDisc, DiscountBath As BathDisc, Price As PriceSale, DtType" & vbNewLine &
                                "FROM SmSaleDtAll" & vbNewLine &
                                "Where idSale =  " & idSaleAV & vbNewLine &
                                "AND idSaleDtAVxST Not IN (SELECT idSaleDt FROM SmSaleDtAll WHERE idSale = " & idSaleS & ")" & vbNewLine &
                                "AND idProduct <> 9766"

        myAdapter.Fill(dtSlDtCaseDel)

        If dtSlDtCaseDel.Rows.Count > 0 Then
            For i As Integer = 0 To dtSlDtCaseDel.Rows.Count - 1
                Dim dr As DataRow = dtSlDtCaseDel.Rows(i)

                mycommand.CommandText = "DELETE SmSaleDtAll " & vbNewLine &
                                        "FROM SmSaleDtAll " & vbNewLine &
                                        "WHERE idSaleDt = " & dr.Item("idSaleDt")

                mycommand.ExecuteNonQuery()
            Next
        End If

        Dim dtSlDtCaseUpdate As New DataTable
        'Case 3: Update Data
        For i As Integer = 0 To DGVBind.DataRowCount - 1

            Dim dr As DataRow = DGVBind.GetDataRow(i)
            If Not IsDBNull("idSaleDt") Then
                If dr.Item("idInvMain") <> 9766 Then
                    SumTotal = SumTotal + dr.Item("Total")
                End If
                dtSlDtCaseUpdate.Clear()

                mycommand.CommandText = "SELECT idSaleDt" & vbNewLine &
                                        "FROM SmSaleDtAll" & vbNewLine &
                                        "WHERE idProduct <> 9766 " & vbNewLine &
                                        "AND idSale =  " & idSaleAV & vbNewLine &
                                        "--AND idLot = " & dr.Item("idLot") & vbNewLine &
                                        "AND idSaleDtAVxST = " & dr.Item("idSaleDt")

                myAdapter.Fill(dtSlDtCaseUpdate)

                If dtSlDtCaseUpdate.Rows.Count > 0 Then
                    Dim ProductName As String = Trim(dr.Item("ProductName"))
                    ProductName = Replace(ProductName, "'", "''")

                    'Case 3: Edit Data On Old Row
                    mycommand.CommandText = "UPDATE SmSaleDtAll SET " & vbNewLine &
                                            "idProduct = " & dr.Item("idInvMain") & " , " & vbNewLine &
                                            "ProductName = '" & ProductName & "' , " & vbNewLine &
                                            "idLot = " & dr.Item("idLot") & " , " & vbNewLine &
                                            "LotNo = '" & dr.Item("LotNo") & "'," & vbNewLine &
                                            "idWh = " & dr.Item("idWh") & "," & vbNewLine &
                                            "idRefLot = " & dr.Item("idRefLot") & "," & vbNewLine &
                                            "idUnit = " & dr.Item("idUnit") & "," & vbNewLine &
                                            "Amount = " & dr.Item("AmtSale") & " , " & vbNewLine &
                                            "PriceBfDis = " & dr.Item("PriceNormal") & " , " & vbNewLine &
                                            "DiscountPerc = " & dr.Item("PercDisc") & " , " & vbNewLine &
                                            "DiscountBath = " & dr.Item("BathDisc") & " , " & vbNewLine &
                                            "Price = " & dr.Item("PriceSale") & " , " & vbNewLine &
                                            "No = " & i + 1 & vbNewLine & " , " & vbNewLine &
                                            "TotalDt = " & dr.Item("Total") & vbNewLine &
                                            "WHERE idSaleDt =  " & dtSlDtCaseUpdate.Rows(0).Item("idSaleDt")
                    mycommand.ExecuteNonQuery()
                End If
            End If
        Next

        '---- Update SumService in SmSaleMt ----'
        mycommand.CommandText = "Update SmSaleMt Set TotalNet = " & SumTotal & ", " & vbNewLine &
                                "Total = " & SumTotal & vbNewLine &
                                "WHERE idSale = " & idSaleAV
        mycommand.ExecuteNonQuery()

    End Sub

#End Region

    Private Function SmSaleSaveApprove() As Boolean
        Result = MsgBox("คุณต้องการอนุมัติ หรือไม่อนุมัติรายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
        If Result = Windows.Forms.DialogResult.Yes Then
            If Me.rdbAppOK.Checked = True Then  ' อนุมัติ
                mdCnOpen()
                '---Update SmSaleMt Table---'
                sCommand.CommandText = "IF (NOT EXISTS(SELECT idPsApp FROM SmSaleMt WHERE idSale = " & idSaleS & " AND idPsApp IS NOT NULL) )" & vbNewLine &
                                                   "BEGIN" & vbNewLine &
                                                        "Update SmSaleMt  SET idPsApp = " & sPsId & " , DateApp  = '" & ksbDateToString(Date.Today) & "'" & vbNewLine &
                                                        "WHERE idSale = " & idSaleS & vbNewLine &
                                                   "End" & vbNewLine &
                                               "Else " & vbNewLine &
                                                    "BEGIN" & vbNewLine &
                                                        "Update SmSaleMt SET idPsApp2 = " & sPsId & " , DateApp2 = GetDate() " & vbNewLine &
                                                        "WHERE idSale = " & idSaleS & vbNewLine &
                                                    "End"
                sCommand.ExecuteNonQuery()

            ElseIf Me.rdbAppNo.Checked = True Then  ' ไม่อนุมัติ
                mdCnOpen()
                '---Update SmSaleMt Table---'
                sCommand.CommandText = "IF (NOT EXISTS(SELECT idPsApp FROM SmSaleMt WHERE idSale = " & idSaleS & " AND idPsApp IS NOT NULL) )" & vbNewLine &
                                                   "BEGIN" & vbNewLine &
                                                        "Update SmSaleMt  SET idPsApp = " & sPsId & " , DateApp  = '" & ksbDateToString(Date.Today) & "' , stApp = '0'" & vbNewLine &
                                                        "WHERE idSale = " & idSaleS & vbNewLine &
                                                   "End" & vbNewLine &
                                               "Else " & vbNewLine &
                                                    "BEGIN" & vbNewLine &
                                                        "Update SmSaleMt SET idPsApp2 = " & sPsId & " , DateApp2 = GetDate(), stApp = '0' " & vbNewLine &
                                                        "WHERE idSale = " & idSaleS & vbNewLine &
                                                    "End"
                sCommand.ExecuteNonQuery()

                '-------------------------------------------NEW GRID------------------------------------------
                '---------------------------------------------------------------------------------------------
                For i As Integer = 0 To DGVBind.DataRowCount - 1
                    If Not IsDBNull(DGVBind.GetDataRow(i).Item("idLot")) Then  ' case cut stock ----> not approve ---> return stock

                        If DGVBind.GetDataRow(i).Item("idLot") <> 0 Then

                            'Lot in New Sysytem
                            If Not IsDBNull(DGVBind.GetDataRow(i).Item("idLot")) Then

                                'ไม่อนุมัติ ให้ยกเลิกสถานะรอเบิก
                                sCommand.CommandText = "EXEC WaitCutTs '4','SmSaleMt','SmSaleDtAll','idSale'," & idSaleS & "," & cmbGroupComp.SelectedValue & "," & sPsId & ",'3'"
                                sCommand.ExecuteNonQuery()
                            End If
                        End If
                    End If
                Next
                '---------------------------------------------------------------------------------------------
                '---------------------------------------------------------------------------------------------

                MessageBox.Show("ระบบยืนยันการไม่อนุมัติรายการเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                vFrmACAp.Close()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Return False
                Exit Function
            Else
                MessageBox.Show("กรุณาเลือกอนุมัติ หรือไม่อนุมัติก่อนทำการบันทึก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            Dim sDt As New DataTable
            sCommand.CommandText = "Select idPsAccept, idPsCheck, idPsApp, idPsApp2 From SmSaleMt Where idSale = " & idSaleS
            sAdapter.Fill(sDt)
            If Not IsDBNull(sDt.Rows(0).Item("idPsAccept")) And Not IsDBNull(sDt.Rows(0).Item("idPsCheck")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp2")) Then
                '----Update stApp----'
                sCommand.CommandText = "Update SmSaleMt Set stApp = '1' Where idSale = " & idSaleS
                sCommand.ExecuteNonQuery()
                MessageBox.Show("กระบวนการนี้เป็นการยืนยันขั้นตอนลำดับสุดท้าย ลำดับที่ 4 โดยหลังจากขั้นตอนนี้สามารถออกเอกสารได้ และรายการจะถูกส่งไปยังขั้นตอนจัดส่งสินค้าต่อไป", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("อนุมัติเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
                vFrmACAp.Close()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
        Return False
    End Function

    Private Sub SmSaleSaveCheck()
        Result = MsgBox("คุณต้องการตรวจสอบรายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
        If Result = Windows.Forms.DialogResult.Yes Then
            mdCnOpen()
            '---Update SmSaleMt Table---'
            sCommand.CommandText = "Update SmSaleMt Set idPsCheck = " & sPsId & ", DateChcek ='" & ksbDateToString(Date.Today) & "' " &
                                   "Where idSale='" & idSaleS & "'"
            sCommand.ExecuteNonQuery()

            Dim sDt As New DataTable
            sCommand.CommandText = "Select idPsAccept, idPsCheck, idPsApp From SmSaleMt Where idSale = " & idSaleS
            sAdapter.Fill(sDt)
            If Not IsDBNull(sDt.Rows(0).Item("idPsAccept")) And Not IsDBNull(sDt.Rows(0).Item("idPsCheck")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp")) Then
                '----Update stApp----'
                sCommand.CommandText = "Update SmSaleMt Set stApp = '1' Where idSale = " & idSaleS
                sCommand.ExecuteNonQuery()
                MessageBox.Show("กระบวนการนี้เป็นการยืนยันขั้นตอนลำดับสุดท้าย ลำดับที่ 3 " & vbCrLf &
                                " โดยหลังจากขั้นตอนนี้สามารถออกเอกสารได้ และรายการจะถูกส่งไปยังขั้นตอนจัดส่งสินค้าต่อไป", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                vFrmACAp.Close()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("ตรวจสอบเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                vFrmACAp.Close()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub SmSaleSaveAccept()
        Result = MsgBox("คุณต้องการรับทราบรายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
        If Result = Windows.Forms.DialogResult.Yes Then
            mdCnOpen()
            '---Update SmSaleMt Table---'
            sCommand.CommandText = "Update SmSaleMt Set idPsAccept = " & sPsId & " , DateAccept = '" & ksbDateToString(Date.Today) & "' " &
                                   "Where idSale= '" & idSaleS & "'"
            sCommand.ExecuteNonQuery()

            Dim sDt As New DataTable
            sCommand.CommandText = "Select idPsAccept, idPsCheck, idPsApp From SmSaleMt Where idSale= " & idSaleS
            sAdapter.Fill(sDt)

            If Not IsDBNull(sDt.Rows(0).Item("idPsAccept")) And Not IsDBNull(sDt.Rows(0).Item("idPsCheck")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp")) Then
                '----Update stApp----'
                sCommand.CommandText = "Update SmSaleMt Set stApp='1' Where idSale= " & idSaleS
                sCommand.ExecuteNonQuery()

                MessageBox.Show("กระบวนการนี้เป็นการยืนยันขั้นตอนลำดับสุดท้าย ลำดับที่ 3 " & vbCrLf &
                                "โดยหลังจากขั้นตอนนี้สามารถออกเอกสารได้ และรายการจะถูกส่งไปยังขั้นตอนจัดส่งสินค้าต่อไป", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                vFrmACAp.Close()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("รับทราบเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                vFrmACAp.Close()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Function AddSmSale() As Integer
        Dim idSale As Integer = 0

        Using myconnection As New SqlConnection(conStr)
            myconnection.Open()
            Dim mycommand As New SqlCommand()
            ' Dim mycommand As SqlCommand = myconnection.CreateCommand()
            Dim mytransaction As SqlTransaction
            Dim myAdapter As New SqlDataAdapter(mycommand)
            ' Start a local transaction
            mytransaction = myconnection.BeginTransaction()

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            mycommand.Connection = myconnection
            mycommand.Transaction = mytransaction

            Try

                If cmbGroupComp.SelectedValue = 10 Then
                    '---Case ST ขายให้ลูกค้าคนอื่นที่ไม่ใช่บริษัทในเครือ
                    idSale = fnSlBtwAVxStar(mycommand)
                Else
                    Dim getDate As String = CType(Date.Today, String)
                    Dim YAndM As String = Microsoft.VisualBasic.Left(ksbDateToString(Date.Today), 6)
                    Dim YAndM_Cut As String = Microsoft.VisualBasic.Right(YAndM, 4)
                    Dim Prefixcode As String = (Microsoft.VisualBasic.Right(getDate, 2))

                    Dim sDocCode As String = getDocCode(mycommand, Prefixcode)
                    Dim sDocRefAcc As String = getDocRefAcc(mycommand, YAndM_Cut, cmbGroupComp.SelectedValue)
                    Dim DocRef As String = Me.cmbDRCode.Text & " " & Trim(Me.txtDocRef.Text)
                    Dim stRight As Integer = 0
                    Dim NoteMt As String = ""
                    Dim count As Integer = dt_Note.Rows.Count

                    If count = 0 Then
                        NoteMt = ""
                    Else
                        NoteMt = gvNote.GetDataRow(0).Item("Note")

                        For i As Integer = 1 To gvNote.DataRowCount - 1
                            NoteMt &= "\" & gvNote.GetDataRow(i).Item("Note")
                        Next
                        NoteMt = NoteMt.Replace("'", "''")
                    End If

                    If Me.rdbRight.Checked = True Then
                        stRight = 1
                    ElseIf Me.rdbNoRight.Checked = True Then
                        stRight = 0
                    End If

                    Dim vWHERE As String = ""
                    If eEvent = eProcess.eEditCombine Then 'EditData
                        vWHERE = " AND idSale <> " & idSaleS & ""
                    End If

                    Dim stDup As Boolean = fnChkDocCodeDup(mycommand, DocRef, vWHERE)
                    Dim stBillType As String = "8"

                    If stDup = False Then

                        If stASG <> 0 Then 'ขายบริษัทในเครือ
                            stBillType = "6"

                        End If

                        idSale = fnNewAddSmSaleMt(mycommand, 0, sDocCode, sDocRefAcc, cmbDRCode.SelectedValue, DocRef, NoteMt, lblPsSale.Tag, stBillType,
                                                  cmbTp.SelectedValue, CmbTs.SelectedValue, stRight, cmbGroupComp.SelectedValue, idPartner, Trim(lblPsCus.Text), lblPsCus.Tag, idFm,
                                                  cmbTypePayTrp.SelectedValue, Me.lblTspComp.Tag, lblAddr.Tag)

                        If idSale = 0 Then
                            Return idSale
                            Exit Function
                        Else
                            'Dim idSaleOrder_last As Integer = 0
                            If DGVBind.DataRowCount > 0 Then 'มีรายการสินค้า
                                '--- Insert SmSaleDtAll----'
                                For i As Integer = 0 To DGVBind.DataRowCount - 1
                                    Dim dr As DataRow = DGVBind.GetDataRow(i)

                                    Dim idSaleDtNew As Integer = fnNewAddSmSaleDtAll(mycommand, dr, idSale, i + 1, 0)

                                    If Not IsDBNull(dr.Item("idSaleOrderDt")) Then

                                        Dim dt As New DataTable
                                        mycommand.CommandText = "SELECT ISNULL(idPODt,0) As idPODt, ISNULL(idPOTs,0) As idPOTs " & vbNewLine &
                                                                "FROM SmSaleOrderDt dt" & vbNewLine &
                                                                "LEFT JOIN SmSaleOrderMt mt ON dt.idSaleOrder = mt.idSaleOrder" & vbNewLine &
                                                                "Where idSaleOrderDt = " & dr.Item("idSaleOrderDt")
                                        myAdapter.Fill(dt)

                                        If dt.Rows.Count > 0 Then
                                            If dt.Rows(0).Item("idPOTs") <> 0 Then

                                                mycommand.CommandText = "Update SmSaleDtAll Set " & vbNewLine &
                                                                    "idPOTs = " & dt.Rows(0).Item("idPOTs") & ", " & vbNewLine &
                                                                    "idPODt = " & dt.Rows(0).Item("idPODt") & vbNewLine &
                                                                    "WHERE idSaleDt = " & idSaleDtNew
                                                mycommand.ExecuteNonQuery()
                                            End If
                                        End If

                                    End If


                                Next

                                '---- Update SumService in SmSaleMt ----'
                                mycommand.CommandText = "Update SmSaleMt Set SumService = " & SumSvFree & " WHERE idSale = " & idSale
                                mycommand.ExecuteNonQuery()

                                mycommand.CommandText = "EXEC WaitCutTs '4','SmSaleMt','SmSaleDtAll','idSale'," & idSale & "," & cmbGroupComp.SelectedValue & "," & sPsId & ",'1'"
                                mycommand.ExecuteNonQuery()

                            End If
                        End If
                    End If
                End If

                'up image
                For j As Integer = 0 To sDt_flagpic_Rec.Rows.Count - 1
                    If sDt_flagpic_Rec.Rows(j).Item(2) = "1" Then
                        upFile(j + 1, sDt_flagpic_Rec.Rows(j).Item(0), idSale)
                    End If
                Next


                ' Attempt to commit the transaction.
                mytransaction.Commit()
                'SplashScreenManager.CloseForm(False)
                mdLoadCommitt()
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return idSale

            Catch ex As Exception
                ' Attempt to roll back the transaction.
                Try
                    mytransaction.Rollback()
                    'SplashScreenManager.CloseForm(False)
                    mdLoadCommitt()
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                             sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    idSale = 0
                    Return idSale
                Catch e2x As Exception
                    idSale = 0
                    'SplashScreenManager.CloseForm(False)
                    mdLoadCommitt()
                    'MessageBox.Show(ex.Message, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                             sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Return idSale
                End Try

            End Try


        End Using

        Return 0
    End Function

    Sub fnInsertxUpdateOrderDt(ByVal mycommand As SqlCommand, ByVal idSaleOrder_last As Integer, ByVal idSaleDtNew As Integer, ByVal drOrderDt As DataRow, ByVal i As Integer)
        Dim myAdapter As New SqlDataAdapter(mycommand)
        'SmSaleOrderDt
        'Insert Row แรกก่อน
        If i = 0 Then
            Dim queryDt As String = "Insert Into SmSaleOrderDt(idSaleOrder, idInvMain, PdName, Amount, AmountPiece, Price, idUnit, stAllSale) " & vbNewLine &
                             "Values(" & idSaleOrder_last & ", " & CInt(drOrderDt.Item("idInvMain")) & ", " & vbNewLine &
                             "'" & drOrderDt.Item("ProductName") & "', " & vbNewLine &
                             CDbl(drOrderDt.Item("AmtSale")) & ", " & vbNewLine &
                             CDbl(drOrderDt.Item("AmtSale")) & ", " & vbNewLine &
                             CDbl(drOrderDt.Item("PriceSale")) & ", " & vbNewLine &
                             CInt(drOrderDt.Item("idUnit")) & ", 1)"
            mycommand.CommandText = queryDt

            Dim qDt As String = "Select @@Identity"
            mycommand.ExecuteNonQuery()
            mycommand.CommandText = qDt
            Dim idSaleOrderDt As Integer = mycommand.ExecuteScalar()

            'Update idSaleOrder + idSaleOrderDt To SmSaleDtAll
            mycommand.CommandText = "Update SmSaleDtAll Set idSaleOrderDt = " & idSaleOrderDt & " WHERE idSaleDt = " & idSaleDtNew
            mycommand.ExecuteNonQuery()
        Else

            Dim dtSlOrder As New DataTable

            mycommand.CommandText = "Select idSaleOrderDt " & vbNewLine &
                                    "FROM SmSaleOrderDt" & vbNewLine &
                                    "WHERE idInvMain = " & drOrderDt.Item("idInvMain") & vbNewLine &
                                    "AND Price = " & drOrderDt.Item("PriceSale") & vbNewLine &
                                    "AND idSaleOrder = " & idSaleOrder_last
            myAdapter.Fill(dtSlOrder)

            If dtSlOrder.Rows.Count > 0 Then
                mycommand.CommandText = "UPDATE SmSaleOrderDt SET Amount = Amount + " & CDbl(drOrderDt.Item("AmtSale")) & vbNewLine &
                                            ", AmountPiece = AmountPiece + " & CDbl(drOrderDt.Item("AmtSale")) & vbNewLine &
                                            "WHERE idSaleOrderDt = " & dtSlOrder.Rows(0).Item("idSaleOrderDt")
                mycommand.ExecuteNonQuery()
                'Update idSaleOrder + idSaleOrderDt To SmSaleDtAll
                mycommand.CommandText = "Update SmSaleDtAll Set idSaleOrderDt = " & dtSlOrder.Rows(0).Item("idSaleOrderDt") & " WHERE idSaleDt = " & idSaleDtNew
                mycommand.ExecuteNonQuery()
            Else
                Dim queryDt As String = "Insert Into SmSaleOrderDt(idSaleOrder, idInvMain, PdName, Amount, AmountPiece, Price, idUnit, stAllSale) " & vbNewLine &
                                        "Values(" & idSaleOrder_last & ", " & CInt(drOrderDt.Item("idInvMain")) & ", " & vbNewLine &
                                         "'" & drOrderDt.Item("ProductName") & "', " & vbNewLine &
                                         CDbl(drOrderDt.Item("AmtSale")) & ", " & vbNewLine &
                                         CDbl(drOrderDt.Item("AmtSale")) & ", " & vbNewLine &
                                         CDbl(drOrderDt.Item("PriceSale")) & ", " & vbNewLine &
                                         CInt(drOrderDt.Item("idUnit")) & ", 1)"
                mycommand.CommandText = queryDt

                Dim qDt As String = "Select @@Identity"
                mycommand.ExecuteNonQuery()
                mycommand.CommandText = qDt
                Dim idSaleOrderDt As Integer = mycommand.ExecuteScalar()

                'Update idSaleOrder + idSaleOrderDt To SmSaleDtAll
                mycommand.CommandText = "Update SmSaleDtAll Set idSaleOrderDt = " & idSaleOrderDt & " WHERE idSaleDt = " & idSaleDtNew
                mycommand.ExecuteNonQuery()
            End If
        End If
    End Sub
    Function getDocCode_Order(ByVal Prefixcode As String) As String
        Dim DocCode As String = ""
        Dim nextOrder As String = ""
        Dim CodeYear As String = ""


        mdCnOpen()
        Dim sDt As New DataTable
        sDs.Tables.Clear()
        ' sCommand.CommandText = "SELECT MAX(DocCode) AS max_DocCode, MAX(SUBSTRING(DocCode, 3, 2)) AS year_docCode FROM SmSaleOrderMt"
        sCommand.CommandText = "SELECT MAX(DocCode) as max_DocCode, SUBSTRING(MAX(DocCode), 3, 2) AS year_docCode" & vbNewLine &
                               "FROM SmSaleOrderMt " & vbNewLine &
                               "WHERE stSysOrder IS NULL " & vbNewLine &
                               "AND idComp = " & cmbGroupComp.SelectedValue
        sAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocCode")) = True Then
            DocCode = Prefixcode & "/" & "00001"
        Else
            CodeYear = "SO" & sDt.Rows(0).Item("year_docCode")
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocCode"), 5)

            If Prefixcode <> CodeYear Then
                DocCode = Prefixcode & "/" & "00001"
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
                DocCode = Prefixcode & "/" & nextOrder
            End If
        End If
        Return DocCode
    End Function
    '---insert SmSaleMt Table---'
    'Function AddSmSaleMt() As Integer

    '    Dim DocCode As String = ""
    '    Dim getDate As String = CType(Date.Today, String)
    '    Dim Prefixcode As String = ""
    '    Dim stRight As Integer
    '    Dim DocRef As String = ""
    '    Dim stfield As String = ""
    '    Dim stValue As String = ""
    '    Dim YAndM As String = Microsoft.VisualBasic.Left(ksbDateToString(Date.Today), 6)
    '    Dim YAndM_Cut As String = Microsoft.VisualBasic.Right(YAndM, 4)

    '    Dim DocRefAcc As String = ""
    '    Dim idSale_last As Integer = 0

    '    If eEvent = eProcess.eAddCombine Then 'Add ขายสินค้ารวมทุกประเภท   
    '        stfield = ", stBillType"
    '        stValue = ", '8'"
    '    End If

    '    If stASG <> 0 Then 'ขายบริษัทในเครือ
    '        stfield = ", stBillType"
    '        stValue = ", '6'"
    '    End If

    '    Dim vidSupTsp As String
    '    If Me.lblTspComp.Tag = Nothing Then
    '        vidSupTsp = " NULL"
    '    Else
    '        vidSupTsp = Me.lblTspComp.Tag
    '    End If

    '    Dim vidCusRefAddr As String
    '    If Me.lblAddr.Tag = 0 Then
    '        vidCusRefAddr = " NULL"
    '    Else
    '        vidCusRefAddr = Me.lblAddr.Tag
    '    End If

    '    If Me.rdbRight.Checked = True Then
    '        stRight = 1
    '    ElseIf Me.rdbNoRight.Checked = True Then
    '        stRight = 0
    '    End If
    '    Prefixcode = (Microsoft.VisualBasic.Right(getDate, 2))

    '    DocCode = getDocCode(sCommand, Prefixcode)
    '    DocRefAcc = getDocRefAcc(sCommand, YAndM_Cut, cmbGroupComp.SelectedValue)
    '    'DocRef = Me.cmbDRCode.SelectedValue & " " & Trim(Me.txtDocRef.Text)
    '    DocRef = Me.cmbDRCode.Text & " " & Trim(Me.txtDocRef.Text)

    '    Dim vWHERE As String = ""
    '    If eEvent = eProcess.eEditCombine Then 'EditData
    '        vWHERE = " AND idSale <> " & idSaleS & ""
    '    End If


    '    'Check DocCode Duplicate Before Insert into Database
    '    Dim dtChkDup As New DataTable
    '    sCommand.CommandText = "Select mt.DocCode, mt.DateSale, mt.DocRef, mt.idPscancel, p.PartnerName  " & vbNewLine & _
    '                           "From SmSaleMt mt " & vbNewLine & _
    '                           "LEFT OUTER JOIN dPartner p ON mt.idPartner = p.idPartner " & vbNewLine & _
    '                           "WHERE mt.idPscancel IS NULL " & vbNewLine & _
    '                           "AND mt.DocRef = '" & DocRef & "' " & vbNewLine & _
    '                           "AND mt.idComp = " & cmbGroupComp.SelectedValue & "" & vWHERE
    '    sAdapter.Fill(dtChkDup)


    '    'For i As Integer = 0 To dRefDt.Rows.Count - 1
    '    If dtChkDup.Rows.Count > 0 Then
    '        'If CodeRef = dRefDt.Rows(i).Item("DocRef") Then
    '        mdLoadCommitt()
    '        DocCodeChk = ""
    '        MessageBox.Show("เลขที่อ้างอิงซ้ำกับข้อมูลเดิม รายละเอียดรายการดังนี้ " & vbCrLf & "เลขที่รายการ : " & dtChkDup.Rows(0).Item("DocCode") & vbCrLf & _
    '        "วันที่ขาย : " & ksbStringToDate(dtChkDup.Rows(0).Item("DateSale")) & vbCrLf & _
    '        "ชื่อลูกค้า : " & dtChkDup.Rows(0).Item("PartnerName") & vbCrLf & vbCrLf & _
    '        "***หากต้องการบันทึก ให้เพิ่มตัวอักษรหลังรหัส ดังนี้" & vbCrLf & _
    '        "   A : แอ๊ดว้านซีดส์" & vbCrLf & _
    '        "   F : โฟลเทคซีดส์" & vbCrLf & " เช่น 5710001A หรือ 5710001F", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        ' MessageBox.Show("เลขที่อ้างอิงซ้ำกับข้อมูลเดิม", sSystemName)

    '        Me.txtDocRef.Focus()
    '        Return 0
    '        Exit Function
    '        'End If
    '    End If


    '    '  --- temp DateSale ใช้ชั่วคราวช่วงคีย์ย้อนหลัง ---'
    '    tempDateSale = ksbDateToString(dtpSale.Value.ToShortDateString)
    '    '  ---------------------------------------'

    '    'mdCnOpenTest()
    '    Using myconnection As New SqlConnection(conStr)
    '        myconnection.Open()
    '        Dim mycommand As New SqlCommand()
    '        ' Dim mycommand As SqlCommand = myconnection.CreateCommand()
    '        Dim mytransaction As SqlTransaction

    '        ' Start a local transaction
    '        mytransaction = myconnection.BeginTransaction()

    '        ' Must assign both transaction object and connection
    '        ' to Command object for a pending local transaction.
    '        mycommand.Connection = myconnection
    '        mycommand.Transaction = mytransaction
    '        Dim Note As String 'txtNote.Text

    '        Dim count As Integer = dt_Note.Rows.Count
    '        'Console.WriteLine(count)
    '        If count = 0 Then
    '            Note = ""
    '        Else
    '            Note = gvNote.GetDataRow(0).Item("Note")

    '            For i As Integer = 1 To gvNote.DataRowCount - 1
    '                Note &= "\" & gvNote.GetDataRow(i).Item("Note")
    '            Next
    '            Note = Note.Replace("'", "''")
    '        End If

    '        'SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
    '        mdLoadShow()
    '        Dim dtpSaleD As DateTime = Convert.ToDateTime(dtpSale.Value, _cultureEnInfo)

    '        Dim stridCus As String = ""
    '        Dim qidCus As String = ""

    '        If idFm = 0 And lblPsCus.Tag <> 0 Then
    '            'Case เป็น Customer อย่างเดียว
    '            stridCus = "idCus"
    '            qidCus = lblPsCus.Tag
    '        ElseIf lblPsCus.Tag = 0 And idFm <> 0 Then
    '            'Case เป็น Farmer อย่างเดียว
    '            stridCus = "idFm"
    '            qidCus = idFm

    '        ElseIf lblPsCus.Tag <> 0 And idFm <> 0 Then
    '            'Case เป็นทั้ง Customer และ Farmer 
    '            stridCus = "idCus, idFm"
    '            qidCus = lblPsCus.Tag & "," & idFm
    '        End If

    '        Try
    '            'LastChkSumTotal()
    '            Dim query As String = "Insert Into SmSaleMt(DateSale, DateSaleD, DatePay, DateTs, DateTsD, TimeTs, DocCode, DocRefAcc, idSaleCode, DocRef, Note, " & _
    '                                  "TotalNet, Total, " & stridCus & ", idPsTs, idPsSale, " & _
    '                                  "stPay, idPM, idTS, stRight, idComp, idPayTsp, idSupTsp, " & _
    '                                  "idCusRefAddr " & stfield & ", stLot, idPartner, PartnerNameBill) " & _
    '                                  "Values('" & ksbDateToString(dtpSale.Value.ToShortDateString) & "', '" & dtpSaleD.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "' , " & _
    '                                  "'" & ksbDateToString(dtpPay.Value.ToShortDateString) & "', " & _
    '                                  "'" & ksbDateToString(lblDateTs.Text) & "', GETDATE(), CONVERT(VARCHAR(5),GETDATE(),108), " & _
    '                                  "'" & DocCode & "', '" & DocRefAcc & "', '" & Me.cmbDRCode.SelectedValue & "', " & _
    '                                  "'" & DocRef & "', '" & Note & "', " & CDbl(txtTotalNet.Text) & ", " & CDbl(txtTotalNet.Text) & ", " & _
    '                                  "" & qidCus & ", " & lblPsTs.Tag & ", " & lblPsSale.Tag & ", " & _
    '                                  "'', '" & cmbTp.SelectedValue & "', '" & CmbTs.SelectedValue & "'," & _
    '                                  "'" & stRight & "', " & cmbGroupComp.SelectedValue & ", " & cmbTypePayTrp.SelectedValue & ", " & _
    '                                  "" & vidSupTsp & ", " & vidCusRefAddr & "" & stValue & ", 1," & idPartner & ", '" & Trim(lblPsCus.Text) & "')"
    '            mycommand.CommandText = query

    '            Dim query2 As String = "Select @@Identity"
    '            mycommand.ExecuteNonQuery()
    '            mycommand.CommandText = query2
    '            idSale_last = mycommand.ExecuteScalar()

    '            'fnNewAddSmSale(0, DocCode, DocRefAcc, Me.cmbDRCode.SelectedValue, DocRef, Note, lblPsSale.Tag, stValue, stRight, cmbTp.SelectedValue, _
    '            '               CmbTs.SelectedValue, cmbGroupComp.SelectedValue, idPartner, lblPsCus.Text, lblPsCus.Tag, idFm)


    '            '***************** Open **************************
    '            If DGVBind.DataRowCount > 0 Then 'มีรายการสินค้า
    '                '--- Insert SmSaleDtAll----'

    '                For i As Integer = 0 To DGVBind.DataRowCount - 1
    '                    Dim dr As DataRow = DGVBind.GetDataRow(i)
    '                    AddSmSaleDtAll(mycommand, dr, idSale_last, i + 1)
    '                Next

    '                'mycommand.CommandText = "EXEC WaitCutTs '4','SmSaleMt','SmSaleDtAll','idSale'," & idSale_last & "," & cmbGroupComp.SelectedValue & "," & sPsId & ",'1'"
    '                'mycommand.ExecuteNonQuery()
    '            End If

    '            'up image
    '            For j As Integer = 0 To sDt_flagpic_Rec.Rows.Count - 1
    '                If sDt_flagpic_Rec.Rows(j).Item(2) = "1" Then
    '                    upFile(j + 1, sDt_flagpic_Rec.Rows(j).Item(0), idSale_last)
    '                End If
    '            Next

    '            ' Attempt to commit the transaction.
    '            mytransaction.Commit()
    '            'SplashScreenManager.CloseForm(False)
    '            mdLoadCommitt()
    '            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Return idSale_last
    '        Catch ex As Exception
    '            ' Attempt to roll back the transaction.
    '            Try
    '                mytransaction.Rollback()
    '                'SplashScreenManager.CloseForm(False)
    '                mdLoadCommitt()
    '                MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
    '                                         sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
    '                idSale_last = 0
    '                Return idSale_last
    '            Catch e2x As Exception
    '                idSale_last = 0
    '                'SplashScreenManager.CloseForm(False)
    '                mdLoadCommitt()
    '                'MessageBox.Show(ex.Message, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
    '                                         sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
    '                Return idSale_last
    '            End Try

    '        End Try
    '    End Using

    '    'SplashScreenManager.CloseForm(False)
    '    mdLoadCommitt()
    'End Function

    '------ LINE Notification ------
    Sub fnLineNotice()

        mdCnOpen()
        'Dim strMsg As String = " - " & DGVBind.GetDataRow(0).Item("ProductName") & " จำนวน " & DGVBind.GetDataRow(0).Item("AmtSale") & " " & DGVBind.GetDataRow(0).Item("UnitName") & vbCrLf
        'For i As Integer = 1 To DGVBind.DataRowCount - 1
        '    strMsg &= "  - " & DGVBind.GetDataRow(i).Item("ProductName") & " จำนวน " & DGVBind.GetDataRow(i).Item("AmtSale") & " " & DGVBind.GetDataRow(i).Item("UnitName") & vbCrLf
        'Next

        Dim SumDisCount As Double = 0.0
        Dim strDis As String = ""

        If DGVBind.GetDataRow(0).Item("PercDisc") <> 0 Then
            SumDisCount = DGVBind.GetDataRow(0).Item("Amtsale") * (DGVBind.GetDataRow(0).Item("PriceNormal") - DGVBind.GetDataRow(0).Item("PriceSale"))
            strDis = " | ส่วนลด ฿" & Format(CDbl(DGVBind.GetDataRow(0).Item("PriceNormal") - DGVBind.GetDataRow(0).Item("PriceSale")), "#,##0.##") & ""
        End If

        Dim strMsg As String = "1." & DGVBind.GetDataRow(0).Item("ProductName") & " | จ.น. " & DGVBind.GetDataRow(0).Item("AmtSale") & " " &
                DGVBind.GetDataRow(0).Item("UnitName") & " | ราคา/หน่วย ฿" & Format(CDbl(DGVBind.GetDataRow(0).Item("PriceNormal")), "#,##0.##") &
                strDis & " | รวม ฿" & Format(CDbl(DGVBind.GetDataRow(0).Item("Total")), "#,##0.##") & vbCrLf

        For i As Integer = 1 To DGVBind.DataRowCount - 1
            strDis = ""
            If DGVBind.GetDataRow(i).Item("PercDisc") <> 0.0 Then
                SumDisCount = SumDisCount + (DGVBind.GetDataRow(i).Item("Amtsale") * (DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("PriceSale")))
                strDis = " | ส่วนลด ฿" & Format(CDbl(DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("PriceSale")), "#,##0.##") & ""
            End If

            strMsg &= " " & i + 1 & "." & DGVBind.GetDataRow(i).Item("ProductName") & " | จ.น. " & DGVBind.GetDataRow(i).Item("AmtSale") & " " &
                DGVBind.GetDataRow(i).Item("UnitName") & " | ราคา/หน่วย ฿" & Format(CDbl(DGVBind.GetDataRow(i).Item("PriceNormal")), "#,##0.##") &
                strDis & " | รวม ฿" & Format(CDbl(DGVBind.GetDataRow(i).Item("Total")), "#,##0.##") & vbCrLf
        Next

        strMsg &= vbCrLf & ">> รวมส่วนลดทั้งหมด " & Format(CDbl(SumDisCount), "#,##0.##") & " บาท" & vbCrLf
        strMsg &= ">> รวมเป็นเงินสุทธิ " & Format(CDbl(txtTotalNet.Text), "#,##0.##") & " บาท"


        '---------------- Line Alert (InsertDB-Way) ------------------------'

        Dim MsgLine = String.Format("ลูกค้า: {0} " & vbCrLf &
                                     "รายการสินค้า:" & vbCrLf & " {1} ", Trim(Me.lblPsCus.Text), strMsg)

        sCommand.CommandText = "INSERT INTO LineNotify(lineID, Messages, idPsTs) " &
                                "VALUES( 56, '" & MsgLine & "', " & sPsId & ")"
        sCommand.ExecuteNonQuery()

    End Sub

    '------ LINE Notification ------
    Sub fnLineNotiWhenPriceChange(ByVal vCommand As SqlCommand)

        '---------------- Line Alert (InsertDB-Way) ------------------------'
        Dim LineId As Integer = 74 'Test-Line Group (Line ID: 2 ห้องทดสอบแจ้งเตือนไลน์)
        'Lind ID: 74 ( ห้อง WIM )
        Dim MsgLine = String.Format("แจ้งการเปลี่ยนแปลงราคา" & vbCrLf &
                                     "เลขที่อ้างอิงรายการขาย: {0}" & vbCrLf &
                                     "ชื่อลูกค้า: {1} " & vbCrLf &
                                     "ชื่อ Supplier: {2} ", (cmbDRCode.Text & txtDocRef.Text), Trim(Me.lblPsCus.Text), Trim(cmbGroupComp.Text))

        vCommand.CommandText = "INSERT INTO LineNotify(lineID, Messages, idPsTs) " &
                                "VALUES(" & LineId & ", '" & MsgLine & "', " & sPsId & ")"
        vCommand.ExecuteNonQuery()


    End Sub

    Private Sub EditSmSaleMtAndDt(ByVal mycommand As SqlCommand) 'Edit
        SumSvFree = 0
        Dim stRight As Integer = 0
        '---Update SmSaleMt Table---'
        Dim stPrice As String = ""
        Dim DocRef As String = ""
        Dim stfield As String = ""

        If eEvent = eProcess.eEditCombine Then 'Edit สินค้ารวมทุกประเภท
            If stBType = 6 Then 'แก้ไข ขายสินค้าในเครือ
                stfield = ", stBillType = '6' "
            ElseIf stBType = 8 Then 'แก้ไข สินค้ารวมทุกประเภท
                stfield = ", stBillType = '8' "
            End If
        End If

        If Me.rdbWhole.Checked = True Then
            stPrice = "3"
        ElseIf Me.rdbRetail.Checked = True Then
            stPrice = "2"
        ElseIf Me.rdbBill.Checked = True Then
            stPrice = "1"
        Else
            stPrice = " NULL"
        End If

        Dim vidSupTsp As String
        If Me.lblTspComp.Tag = Nothing Then
            vidSupTsp = " NULL"
        Else
            vidSupTsp = Me.lblTspComp.Tag
        End If

        Dim vidCusRefAddr As String
        If Me.lblAddr.Tag = 0 Then
            vidCusRefAddr = " NULL"
        Else
            vidCusRefAddr = Me.lblAddr.Tag
        End If

        If Me.rdbRight.Checked = True Then
            stRight = 1
        ElseIf Me.rdbNoRight.Checked = True Then
            stRight = 0
        End If

        DocRef = Me.cmbDRCode.Text & " " & Trim(Me.txtDocRef.Text)


        Dim myAdapter = New SqlDataAdapter(mycommand)

        Dim Note As String = "" 'txtNote.Text
        Dim stSend As Integer = 0
        Dim count As Integer = dt_Note.Rows.Count

        If count = 0 Then
            Note = ""
        Else
            Note = gvNote.GetDataRow(0).Item("Note")

            For i As Integer = 1 To gvNote.DataRowCount - 1
                Note &= "\" & gvNote.GetDataRow(i).Item("Note")
            Next
            Note = Note.Replace("'", "''")
        End If

        Dim dtpSaleD As DateTime = Convert.ToDateTime(dtpSale.Value, _cultureEnInfo)

        Dim stridCus As String = ""

        If lblPsCus.Tag Is Nothing Then
            lblPsCus.Tag = 0
        End If

        If idFm = 0 And lblPsCus.Tag <> 0 Then
            stridCus = "idCus = " & lblPsCus.Tag & ", idFm = NULL, idPartner = " & idPartner

        ElseIf idFm <> 0 And lblPsCus.Tag = 0 Then

            stridCus = "idCus = NULL, idFm = " & idFm & ", idPartner = " & idPartner

        ElseIf idFm <> 0 And lblPsCus.Tag <> 0 Then
            stridCus = "idCus = " & lblPsCus.Tag & ", idFm = " & idFm & ", idPartner = " & idPartner
        End If

        'Try
        mycommand.CommandText = "Update SmSaleMt Set DateSale ='" & ksbDateToString(dtpSale.Value.ToShortDateString) & "', " & vbNewLine &
                                "DateSaleD = '" & dtpSaleD.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "'," & vbNewLine &
                                "DatePay = '" & ksbDateToString(dtpPay.Value.ToShortDateString) & "', " & vbNewLine &
                                "DateTs = '" & ksbDateToString(Date.Today) & "', TimeTs = CONVERT(VARCHAR(5),GETDATE(),108), " & vbNewLine &
                                "DateTsD = GETDATE()," & vbNewLine &
                                "DocCode = '" & lblDocCode.Text & "', idSaleCode = '" & Me.cmbDRCode.SelectedValue & "', DocRef = '" & DocRef & "', " & vbNewLine &
                                "Note = '" & Note & "', TotalNet='" & CDbl(txtTotalNet.Text) & "', Total = '" & CDbl(txtTotalBFDisc.Text) & "' ," & vbNewLine &
                                "" & stridCus & ", idPsTs = '" & sPsId & "', idPsSale='" & lblPsSale.Tag & "', " & vbNewLine &
                                "stPay = '', idPM ='" & cmbTp.SelectedValue & "', idTS ='" & CmbTs.SelectedValue & "', " & vbNewLine &
                                "idPayTsp = " & cmbTypePayTrp.SelectedValue & ", idSupTsp = " & vidSupTsp & ", " & vbNewLine &
                                "idCusRefAddr = " & vidCusRefAddr & ", stRight = '" & stRight & "'" & stfield & vbNewLine &
                                ",stPrice = " & stPrice & ", " & vbNewLine &
                                "PartnerNameBill = '" & Trim(lblPsCus.Text) & "'" & vbNewLine &
                                ", DiscountPerc = " & CDbl(txtAmtPerc.Text.Trim) & " , DiscountBath = " & CDbl(lblPerc.Text.Trim) & ", DiscountAmout = " & CDbl(txtDiscBath.Text.Trim) & vbNewLine &
                                ", idPsOrder = " & If(lblPsOrder.Tag Is Nothing Or lblPsOrder.Tag = 0, "NULL", lblPsOrder.Tag) & vbNewLine &
                                "Where idSale = '" & idSaleS & "'"
        mycommand.ExecuteNonQuery()

        'Case 2: Row Delete
        If dtDel.Rows.Count > 0 Then
            For j As Integer = 0 To dtDel.Rows.Count - 1
                Dim drDel As DataRow = dtDel.Rows(j)

                If IsDBNull(drDel.Item("stCutStock")) Then
                    drDel.Item("stCutStock") = 0
                End If

                'If drDel.Item("stCutStock") = 0 And IsDBNull(drDel.Item("stEdit")) Then
                '    mycommand.CommandText = "UPDATE WimWaitCutDt SET stDel = 1 WHERE idDtRef = " & drDel.Item("idSaleDt")
                '    mycommand.ExecuteNonQuery()

                'ElseIf drDel.Item("stCutStock") = 1 Then
                '    findCutStock = 1
                '    If drDel.Item("idLot") <> 0 Then

                '        Dim CalAmtDel As Double = 0.0

                '        CalAmtDel = fnCalAmtxUnit(mycommand, drDel.Item("idUnit"), drDel.Item("idInvGroup"), drDel.Item("AmtSale"), drDel.Item("idInvMain"))


                '        InvLotMainUpdate(1, drDel.Item("idInvMain"), drDel.Item("idLot"), CalAmtDel,
                '                        "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", drDel.Item("LotNo"), drDel.Item("idWh"), mycommand)

                '    End If


                'End If

                If IsDBNull(drDel.Item("idSaleOrderDt")) Then
                    drDel.Item("idSaleOrderDt") = 0
                End If

                If drDel.Item("idSaleOrderDt") <> 0 Then
                    mycommand.CommandText = "UPDATE SmSaleOrderDt SET AmountSale = AmountSale - " & CDbl(drDel.Item("AmtSale")) & vbNewLine &
                                            "WHERE idSaleOrderDt = " & drDel.Item("idSaleOrderDt")
                    mycommand.ExecuteNonQuery()

                    '--2. ตรวจสอบว่า AmountSale >= AmountOrder หรือยัง
                    Dim stAllSaleDt As New DataTable
                    mycommand.CommandText = "SELECT stAllSale, AmountPiece, IsNull(AmountSale,0) As AmountSale, idSaleOrder " & vbNewLine &
                                            "FROM SmSaleOrderDt  " & vbNewLine &
                                            "WHERE idSaleOrderDt = " & drDel.Item("idSaleOrderDt")
                    myAdapter.Fill(stAllSaleDt)

                    If stAllSaleDt.Rows.Count > 0 Then
                        '--2.1 ถ้าจำนวนขาย >= จำนวนสั่งซื้อแล้ว ให้ Update stAllSale = 1
                        If stAllSaleDt.Rows(0).Item("AmountPiece") <= stAllSaleDt.Rows(0).Item("AmountSale") Then 'Order หมดแล้ว หรือ order เกิน
                            mycommand.CommandText = "Update SmSaleOrderDt Set stAllSale = 1" & vbNewLine &
                                                   "WHERE idSaleOrderDt = " & drDel.Item("idSaleOrderDt")
                            mycommand.ExecuteNonQuery()
                        Else
                            mycommand.CommandText = "Update SmSaleOrderDt Set stAllSale = NULL" & vbNewLine &
                                                  "WHERE idSaleOrderDt = " & drDel.Item("idSaleOrderDt")
                            mycommand.ExecuteNonQuery()
                        End If
                    End If

                    '--3. ตรวจสอบว่า ที่ OrderDt ขายครบทุกรายการสั่งซื้อแล้วหรือยัง
                    Dim dtOrd As New DataTable
                    mycommand.CommandText = "SELECT Sum(ISNULL(stAllSale,0)) SumAllSale, Count(idSaleOrderDt) As cntDt  " & vbNewLine &
                                           "FROM SmSaleOrderDt " & vbNewLine &
                                           "WHERE idSaleOrder = " & stAllSaleDt.Rows(0).Item("idSaleOrder")
                    myAdapter.Fill(dtOrd)

                    If dtOrd.Rows(0).Item("SumAllSale") = dtOrd.Rows(0).Item("cntDt") Then
                        mycommand.CommandText = "UPDATE SmSaleOrderMt SET stOrd = 1 " & vbNewLine &
                                              "WHERE idSaleOrder = " & stAllSaleDt.Rows(0).Item("idSaleOrder")

                        mycommand.ExecuteNonQuery()
                    Else
                        mycommand.CommandText = "UPDATE SmSaleOrderMt SET stOrd = NULL " & vbNewLine &
                                              "WHERE idSaleOrder = " & stAllSaleDt.Rows(0).Item("idSaleOrder")

                        mycommand.ExecuteNonQuery()
                    End If

                End If

                mycommand.CommandText = "DELETE FROM SmSaleDtAll WHERE idSaleDt = " & drDel.Item("idSaleDt")
                mycommand.ExecuteNonQuery()

            Next

            dtDel.AcceptChanges()
        End If

        For i As Integer = 0 To DGVBind.DataRowCount - 1
            '
            Dim dr As DataRow = DGVBind.GetDataRow(i)

            If dr.Item("idInvGroup") = 30 Then
                SumSvFree = SumSvFree + dr.Item("Total")
            End If

            'Case 1: insert New Row/Lot
            If dr.Item("idSaleDt") = 0 Then
                Dim idSaleDt As Integer = fnNewAddSmSaleDtAll(mycommand, dr, idSaleS, i + 1, 0)

                '-----Insert New case when Old Case (stCutStock have 1 row)

                For j As Integer = 0 To DGVBind.DataRowCount - 1
                    Dim d As DataRow = DGVBind.GetDataRow(j)
                    If Not IsDBNull(d.Item("stCutStock")) Then
                        If d.Item("stCutStock") = 1 Then
                            findCutStock = 1
                            Exit For
                        End If
                    End If
                Next

                If findCutStock = 1 Then
                    If Not IsDBNull(dr.Item("idLot")) Then

                        If (dr.Item("idLot") <> 0) Then
                            Dim LotNo As String = ""

                            If IsDBNull(dr.Item("LotNo")) Then
                                LotNo = ""
                            Else
                                LotNo = Trim(dr.Item("LotNo"))
                            End If

                            Dim CalAmt As Double = 0.0

                            CalAmt = fnCalAmtxUnit(mycommand, dr.Item("idUnit"), dr.Item("idInvGroup"), CDbl(dr.Item("AmtSale")), dr.Item("idInvMain"))

                            '--- UPDATE InvLot : New System ---'
                            InvLotMainUpdate(2, dr.Item("idInvmain"), dr.Item("idLot"), CalAmt, "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", LotNo,
                                             dr.Item("idWh"), mycommand)
                        End If
                    End If

                End If

                '------------------------------------------------------------------
                'Row ที่พึ่ง Add เข้ามาใหม่ มาจาก Order
                If Not IsDBNull(dr.Item("idSaleOrderDt")) Then
                    If dr.Item("idSaleOrderDt") <> 0 Then
                        '--1. Update AmountSale + เข้าไปก่อน
                        mycommand.CommandText = "UPDATE SmSaleOrderDt SET AmountSale =  (ISNULL(AmountSale,0) + " & CDbl(dr.Item("AmtSale")) & ")" & vbNewLine &
                                            "WHERE idSaleOrderDt=" & dr.Item("idSaleOrderDt")

                        mycommand.ExecuteNonQuery()

                        '--2. ตรวจสอบว่า AmountSale >= AmountOrder หรือยัง
                        Dim stAllSaleDt As New DataTable
                        mycommand.CommandText = "SELECT stAllSale, AmountPiece, IsNull(AmountSale,0) As AmountSale, idSaleOrder " & vbNewLine &
                                                "FROM SmSaleOrderDt  " & vbNewLine &
                                                "WHERE idSaleOrderDt = " & dr.Item("idSaleOrderDt")
                        myAdapter.Fill(stAllSaleDt)

                        If stAllSaleDt.Rows.Count > 0 Then
                            '--2.1 ถ้าจำนวนขาย >= จำนวนสั่งซื้อแล้ว ให้ Update stAllSale = 1
                            If stAllSaleDt.Rows(0).Item("AmountPiece") <= stAllSaleDt.Rows(0).Item("AmountSale") Then 'Order หมดแล้ว หรือ order เกิน
                                mycommand.CommandText = "Update SmSaleOrderDt Set stAllSale = 1" & vbNewLine &
                                                       "WHERE idSaleOrderDt = " & dr.Item("idSaleOrderDt")
                                mycommand.ExecuteNonQuery()
                            End If
                        End If

                        '--3. ตรวจสอบว่า ที่ OrderDt ขายครบทุกรายการสั่งซื้อแล้วหรือยัง
                        Dim dtOrd As New DataTable
                        mycommand.CommandText = "SELECT Sum(ISNULL(stAllSale,0)) SumAllSale, Count(idSaleOrderDt) As cntDt  " & vbNewLine &
                                               "FROM SmSaleOrderDt " & vbNewLine &
                                               "WHERE idSaleOrder = " & stAllSaleDt.Rows(0).Item("idSaleOrder")
                        myAdapter.Fill(dtOrd)

                        If dtOrd.Rows(0).Item("SumAllSale") = dtOrd.Rows(0).Item("cntDt") Then
                            mycommand.CommandText = "UPDATE SmSaleOrderMt SET stOrd = 1 " & vbNewLine &
                                                  "WHERE idSaleOrder = " & stAllSaleDt.Rows(0).Item("idSaleOrder")

                            mycommand.ExecuteNonQuery()
                        End If


                        'Update idSaleOrder + idSaleOrderDt To SmSaleDtAll
                        mycommand.CommandText = "Update SmSaleDtAll Set idSaleOrderDt = " & dr.Item("idSaleOrderDt") & " WHERE idSaleDt = " & idSaleDt
                        mycommand.ExecuteNonQuery()
                    End If
                End If


                    'If IsDBNull(dr.Item("idSaleOrderDt")) Then
                    '    'ถ้าเป็น NULL แสดงว่าเป็น Case Add Row
                    '    '---มาหาว่า มี idInvMain & Price นี้ยัง ถ้ามี Update, ถ้าไม่มี Insert
                    '    Dim dtOrderDt As New DataTable
                    '    mycommand.CommandText = "SELECT oMt.idSaleOrder, oDt.idSaleOrderDt " & vbNewLine &
                    '                           "FROM SmSaleOrderDt oDt" & vbNewLine &
                    '                           "LEFT JOIN SmSaleOrderMt oMt ON oDt.idSaleOrder = oMt.idSaleOrder" & vbNewLine &
                    '                           "WHERE oMt.idSaleOrder = " & gidSaleOrder & vbNewLine &
                    '                           "AND oDt.idInvMain = " & dr.Item("idInvMain") & vbNewLine &
                    '                           "AND oDt.Price = '" & dr.Item("PriceSale") & "'"

                    '    myAdapter.Fill(dtOrderDt)

                    '    'ถ้ามี Update
                    '    If dtOrderDt.Rows.Count > 0 Then
                    '        mycommand.CommandText = "UPDATE SmSaleOrderDt SET Amount = Amount + " & CDbl(dr.Item("AmtSale")) & vbNewLine &
                    '                            ", AmountPiece = AmountPiece + " & CDbl(dr.Item("AmtSale")) & vbNewLine &
                    '                            "WHERE idSaleOrderDt = " & dtOrderDt.Rows(0).Item("idSaleOrderDt")
                    '        mycommand.ExecuteNonQuery()
                    '        'Update idSaleOrder + idSaleOrderDt To SmSaleDtAll
                    '        mycommand.CommandText = "Update SmSaleDtAll Set idSaleOrderDt = " & dtOrderDt.Rows(0).Item("idSaleOrderDt") & " WHERE idSaleDt = " & idSaleDt
                    '        mycommand.ExecuteNonQuery()
                    '    Else
                    '        'ถ้าไม่มี Insert
                    '        Dim queryDt As String = "Insert Into SmSaleOrderDt(idSaleOrder, idInvMain, PdName, Amount, AmountPiece, Price, idUnit, stAllSale) " & vbNewLine &
                    '                            "Values(" & gidSaleOrder & ", " & CInt(dr.Item("idInvMain")) & ", " & vbNewLine &
                    '                             "'" & dr.Item("ProductName") & "', " & vbNewLine &
                    '                             CDbl(dr.Item("AmtSale")) & ", " & vbNewLine &
                    '                             CDbl(dr.Item("AmtSale")) & ", " & vbNewLine &
                    '                             CDbl(dr.Item("PriceSale")) & ", " & vbNewLine &
                    '                             CInt(dr.Item("idUnit")) & ", 1)"
                    '        mycommand.CommandText = queryDt

                    '        Dim qDt As String = "Select @@Identity"
                    '        mycommand.ExecuteNonQuery()
                    '        mycommand.CommandText = qDt
                    '        Dim idSaleOrderDt As Integer = mycommand.ExecuteScalar()

                    '        'Update idSaleOrder + idSaleOrderDt To SmSaleDtAll
                    '        mycommand.CommandText = "Update SmSaleDtAll Set idSaleOrderDt = " & idSaleOrderDt & " WHERE idSaleDt = " & idSaleDt
                    '        mycommand.ExecuteNonQuery()
                    '    End If
                    'End If

                End If

                'Case 3: Edit Data On Old Row
                If dr.Item("idSaleDt") <> 0 Then

                If dr.Item("AmtSale") <> dr.Item("AmtSaleHide") Or dr.Item("PriceNormal") <> dr.Item("PriceNormalHide") _
                    Or dr.Item("PercDisc") <> dr.Item("PercDiscHide") Or dr.Item("BathDisc") <> dr.Item("BathDiscHide") _
                    Or dr.Item("PriceSale") <> dr.Item("PriceSaleHide") Or dr.Item("idInvMain") <> dr.Item("idInvMainHide") _
                    Or dr.Item("idLot") <> dr.Item("idLotHide") Or dr.Item("idUnit") <> dr.Item("idUnitHide") _
                    Or dr.Item("idRefLot") <> dr.Item("idRefLotHide") Then

                    Dim stLotChange As Integer = 0

                    If dr.Item("stCutStock") = 1 Then
                        findCutStock = 1
                        If dr.Item("AmtSale") <> dr.Item("AmtSaleHide") And dr.Item("idLot") = dr.Item("idLotHide") Then

                            Dim CalAmtHide As Double = 0.0
                            Dim CalAmt As Double = 0.0
                            CalAmtHide = fnCalAmtxUnit(mycommand, dr.Item("idUnitHide"), dr.Item("idInvGroupHide"), dr.Item("AmtSaleHide"), dr.Item("idInvMain"))
                            CalAmt = fnCalAmtxUnit(mycommand, dr.Item("idUnit"), dr.Item("idInvGroup"), dr.Item("AmtSale"), dr.Item("idInvMain"))

                            ' คืนสต๊อก จำนวนขาย เก่า (Lot เดิม)
                            InvLotMainUpdate(1, dr.Item("idInvMain"), dr.Item("idLot"), CalAmtHide,
                                         "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", dr.Item("LotNo"), dr.Item("idWh"), mycommand)

                            ' ตัดสต๊อก จำนวนขาย ใหม่ (Lot เดิม)
                            InvLotMainUpdate(2, dr.Item("idInvMain"), dr.Item("idLot"), CalAmt,
                                        "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", dr.Item("LotNo"), dr.Item("idWh"), mycommand)

                        End If
                    End If

                    If IsDBNull(dr.Item("pWeight")) Then
                        dr.Item("pWeight") = 0
                    End If

                    If IsDBNull(dr.Item("idUnitW")) Then
                        dr.Item("idUnitW") = 0
                    End If

                    If dr.Item("idInvGroup") = 1 Then
                        dr.Item("pWeight") = 1
                        dr.Item("idUnitW") = dr.Item("idUnit")
                    End If

                    Dim pWeight As String = ""
                    Dim idUnitW As String = ""

                    If dr.Item("pWeight") = 0 Then
                        pWeight = "NULL"
                    Else
                        pWeight = dr.Item("pWeight").ToString
                    End If

                    If dr.Item("idUnitW") = 0 Then
                        idUnitW = "NULL"
                    Else
                        idUnitW = dr.Item("idUnitW").ToString
                    End If

                    mycommand.CommandText = "UPDATE SmSaleDtAll SET " & vbNewLine &
                                            "Amount = " & dr.Item("AmtSale") & " , " & vbNewLine &
                                            "PriceBfDis = " & dr.Item("PriceNormal") & " , " & vbNewLine &
                                            "DiscountPerc = " & dr.Item("PercDisc") & " , " & vbNewLine &
                                            "DiscountBath = " & dr.Item("BathDisc") & " , " & vbNewLine &
                                            "Price = " & dr.Item("PriceSale") & " , " & vbNewLine &
                                            "idUnit = " & dr.Item("idUnit") & " , " & vbNewLine &
                                            "idUnitW = " & idUnitW & " , " & vbNewLine &
                                            "pWeight = " & pWeight & " , " & vbNewLine &
                                            "TotalDt = " & dr.Item("Total") & "," & vbNewLine &
                                            "idWh = " & dr.Item("idWh") & "," & vbNewLine &
                                            "idRefLot = " & dr.Item("idRefLot") & vbNewLine &
                                            "WHERE idSaleDt =  " & dr.Item("idSaleDt")
                    mycommand.ExecuteNonQuery()

                    If dr.Item("idInvMain") <> dr.Item("idInvMainHide") Then
                        Dim ProductName As String = Trim(dr.Item("ProductName"))
                        ProductName = Replace(ProductName, "'", "''")

                        mycommand.CommandText = "UPDATE SmSaleDtAll SET " & vbNewLine &
                                             "idProduct = " & dr.Item("idInvMain") & " , " & vbNewLine &
                                             "ProductName = '" & ProductName & "' , " & vbNewLine &
                                             "idUnit = " & dr.Item("idUnit") & vbNewLine &
                                             "WHERE idSaleDt =  " & dr.Item("idSaleDt")
                        mycommand.ExecuteNonQuery()

                        If IsDBNull(dr.Item("stCutStock")) Then
                            dr.Item("stCutStock") = 0
                        End If

                        If dr.Item("stCutStock") = 1 Then
                            Dim CalAmtHide As Double = 0.0
                            Dim CalAmt As Double = 0.0
                            CalAmtHide = fnCalAmtxUnit(mycommand, dr.Item("idUnit"), dr.Item("idInvGroup"), dr.Item("AmtSaleHide"), dr.Item("idInvMainHide"))
                            CalAmt = fnCalAmtxUnit(mycommand, dr.Item("idUnit"), dr.Item("idInvGroup"), dr.Item("AmtSale"), dr.Item("idInvMain"))


                            ' คืนสต๊อก idInvMain เก่า (Lot เก่าด้วย)
                            InvLotMainUpdate(1, dr.Item("idInvMainHide"), dr.Item("idLotHide"), CalAmtHide,
                                         "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", dr.Item("LotNoHide"), dr.Item("idWhHide"), mycommand)

                            ' ตัดสต๊อก idInvMain ใหม่ (Lot ใหม่ ด้วย)
                            InvLotMainUpdate(2, dr.Item("idInvMain"), dr.Item("idLot"), CalAmt,
                                        "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", dr.Item("LotNo"), dr.Item("idWh"), mycommand)

                            stLotChange = 1
                        End If

                    End If

                    If dr.Item("idLot") <> dr.Item("idLotHide") Then
                        mycommand.CommandText = "UPDATE SmSaleDtAll SET " & vbNewLine &
                                                "idLot = " & dr.Item("idLot") & " , " & vbNewLine &
                                                "LotNo = '" & dr.Item("LotNo") & "'," & vbNewLine &
                                                "idWh = " & dr.Item("idWh") & "," & vbNewLine &
                                                "idRefLot = " & dr.Item("idRefLot") & "" & vbNewLine &
                                                "WHERE idSaleDt = " & dr.Item("idSaleDt")
                        mycommand.ExecuteNonQuery()

                        If dr.Item("stCutStock") = 1 Then
                            If stLotChange = 0 Then
                                ' คืนสต๊อก Lot เก่า
                                InvLotMainUpdate(1, dr.Item("idInvMainHide"), dr.Item("idLotHide"), CDbl(dr.Item("AmtSaleHide")),
                                             "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", dr.Item("LotNoHide"), dr.Item("idWhHide"), mycommand)

                                ' ตัดสต๊อก Lot ใหม่
                                InvLotMainUpdate(2, dr.Item("idInvMain"), dr.Item("idLot"), CDbl(dr.Item("AmtSale")),
                                            "เมนู" & Me.Text, idSaleS, "SAM", "SmSaleMt", dr.Item("LotNo"), dr.Item("idWh"), mycommand)
                            End If
                        End If
                    End If

                    '--- แจ้งเตือน เมื่อมีการเปลี่ยนแปลงราคา
                    If dr.Item("PriceSale") <> dr.Item("PriceSaleHide") Then

                        If stRecWIM = 1 Then
                            If Not IsDBNull(dr.Item("stEdit")) Then
                                Dim dtStApp As New DataTable
                                mycommand.CommandText = "SELECT IsNULL(stApprove,0) As stApprove, idTs " & vbNewLine &
                                                        "FROM EditSaleSAMxWIM " & vbNewLine &
                                                        "WHERE idSale = " & idSaleS & vbNewLine &
                                                        "AND idSaleDt = " & dr.Item("idSaleDt") & vbNewLine &
                                                        "Order by  idTs DESC"
                                myAdapter.Fill(dtStApp)

                                If dtStApp.Rows.Count = 0 Then
                                    mycommand.CommandText = "INSERT INTO EditSaleSAMxWIM (DateTs, idPsTs, idSaleDt, idSale, Note) " & vbNewLine &
                                                               "VALUES ( GETDATE()," & sPsId & ", " & dr.Item("idSaleDt") & "," & idSaleS & ",'" & Trim(NoteChangePrice) & "')"
                                    mycommand.ExecuteNonQuery()

                                ElseIf dtStApp.Rows(0).Item("stApprove") = 1 Then

                                    mycommand.CommandText = "INSERT INTO EditSaleSAMxWIM (DateTs, idPsTs, idSaleDt, idSale, Note) " & vbNewLine &
                                                           "VALUES ( GETDATE()," & sPsId & ", " & dr.Item("idSaleDt") & "," & idSaleS & ",'" & Trim(NoteChangePrice) & "')"
                                    mycommand.ExecuteNonQuery()
                                ElseIf dtStApp.Rows(0).Item("stApprove") = 0 Then

                                    mycommand.CommandText = "Update EditSaleSAMxWIM Set DateTs = GETDATE(), idPsTs = " & sPsId & ", Note = '" & Trim(NoteChangePrice) & "' Where idTs = " & dtStApp.Rows(0).Item("idTs")
                                    mycommand.ExecuteNonQuery()
                                End If

                                If stSend = 0 Then
                                    fnLineNotiWhenPriceChange(mycommand)
                                    stSend = 1
                                End If

                            End If
                        End If
                    End If
                End If
            End If

            mycommand.CommandText = "Update SmSaleDtAll Set No = " & i + 1 & " WHERE idSaleDt = " & dr.Item("idSaleDt")
            mycommand.ExecuteNonQuery()

            '-----CASE Edit SmSaleOrderDt
            If Not IsDBNull(dr.Item("stEdit")) And Not IsDBNull(dr.Item("idSaleOrderDt")) Then

                If dr.Item("idSaleOrderDt") <> 0 Then

                    '--1. Update AmountSale เดิม - ก่อน แล้ว + เข้าไปใหม่ก่อน
                    mycommand.CommandText = "UPDATE SmSaleOrderDt SET AmountSale = (ISNULL(AmountSale,0) - " & dr.Item("AmtSaleHide") & ") + " & dr.Item("AmtSale") & vbNewLine &
                                            "WHERE idSaleOrderDt=" & dr.Item("idSaleOrderDt")

                    mycommand.ExecuteNonQuery()

                    '--2. ตรวจสอบว่า AmountSale >= AmountOrder หรือยัง
                    Dim stAllSaleDt As New DataTable
                    mycommand.CommandText = "SELECT stAllSale, AmountPiece, IsNull(AmountSale,0) As AmountSale, idSaleOrder " & vbNewLine &
                                    "FROM SmSaleOrderDt  " & vbNewLine &
                                    "WHERE idSaleOrderDt = " & dr.Item("idSaleOrderDt")
                    myAdapter.Fill(stAllSaleDt)

                    If stAllSaleDt.Rows.Count > 0 Then
                        '--2.1 ถ้าจำนวนขาย >= จำนวนสั่งซื้อแล้ว ให้ Update stAllSale = 1
                        If stAllSaleDt.Rows(0).Item("AmountPiece") <= stAllSaleDt.Rows(0).Item("AmountSale") Then 'Order หมดแล้ว หรือ order เกิน
                            mycommand.CommandText = "Update SmSaleOrderDt Set stAllSale = 1" & vbNewLine &
                                           "WHERE idSaleOrderDt = " & dr.Item("idSaleOrderDt")
                            mycommand.ExecuteNonQuery()
                        End If
                    End If

                    '--3. ตรวจสอบว่า ที่ OrderDt ขายครบทุกรายการสั่งซื้อแล้วหรือยัง
                    Dim dtOrd As New DataTable
                    mycommand.CommandText = "SELECT Sum(ISNULL(stAllSale,0)) SumAllSale, Count(idSaleOrderDt) As cntDt  " & vbNewLine &
                                   "FROM SmSaleOrderDt " & vbNewLine &
                                   "WHERE idSaleOrder = " & stAllSaleDt.Rows(0).Item("idSaleOrder")
                    myAdapter.Fill(dtOrd)

                    If dtOrd.Rows(0).Item("SumAllSale") = dtOrd.Rows(0).Item("cntDt") Then
                        mycommand.CommandText = "UPDATE SmSaleOrderMt SET stOrd = 1 " & vbNewLine &
                                      "WHERE idSaleOrder = " & stAllSaleDt.Rows(0).Item("idSaleOrder")

                        mycommand.ExecuteNonQuery()
                    End If


                    'Dim dtAmt As New DataTable
                    'mycommand.CommandText = "SELECT ISNULL(AmountSale, 0.0) As AmountSale, idSaleOrder " & vbNewLine &
                    '                        "FROM SmSaleOrderDt WHERE idWaitRecDt= " & dr.Item("idSaleOrderDt")
                    'myAdapter.Fill(dtAmt)

                    'mycommand.CommandText = "UPDATE SmSaleOrderDt SET AmountSale = " & dtAmt.Rows(0).Item("AmountSale") & " - (ISNULL(AmountSale,0) + " & dr.Item("AmountSale") & ")" & vbNewLine &
                    '                        "WHERE idSaleOrderDt=" & dr.Item("idSaleOrderDt")

                    'mycommand.ExecuteNonQuery()

                    'mycommand.CommandText = "SELECT Count(ISNULL(stAllSale,0)) cntAllSale, Count(idSaleOrderDt) As cntDt  " & vbNewLine &
                    '                        "FROM SmSaleOrderDt WHERE idSaleOrder = " & dtAmt.Rows(0).Item("idSaleOrder")
                    'myAdapter.Fill(dtAmt)

                    'If dtAmt.Rows(0).Item("cntAllSale") = dtAmt.Rows(0).Item("cntDt") Then
                    '    mycommand.CommandText = "UPDATE SmSaleOrderMt SET stOrd = 1 " & vbNewLine &
                    '                             "WHERE idSaleOrder = " & dtAmt.Rows(0).Item("idSaleOrder")

                    '    mycommand.ExecuteNonQuery()
                    'End If
                End If
            End If
        Next
    End Sub

    Private Sub CmbTs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTs.SelectedIndexChanged
        If Me.CmbTs.SelectedValue = 21 Then ' บริษัทขนส่ง
            Me.btnTspComp.Enabled = True
            Me.cmbTypePayTrp.Enabled = True
        Else
            Me.btnTspComp.Enabled = False
            Me.cmbTypePayTrp.Enabled = False
            Me.lblTspComp.Tag = Nothing
            Me.lblTspComp.Text = ""
            Me.cmbTypePayTrp.SelectedValue = 1
        End If
    End Sub

    Private Sub rdbWhole_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbWhole.CheckedChanged
        If Me.rdbWhole.Checked = True Then
            For i As Integer = 0 To DGVBind.DataRowCount - 1
                If DGVBind.GetDataRow(i).Item("idInvGroup") = 2 Then 'สินค้าสำเร็จรูป FG
                    mdCnOpen()
                    Dim dt As New DataTable
                    sDs.Tables.Clear()
                    sCommand.CommandText = "Select PriceWholesale From dPackingPdSet Where idPdPk = " & DGVBind.GetDataRow(i).Item("idSubType")
                    sAdapter.Fill(dt)

                    If dt.Rows.Count <> 0 Then

                        DGVBind.GetDataRow(i).Item("PriceNormal") = dt.Rows(0).Item("PriceWholesale")

                        DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal")
                        '----- Check ส่วนลด  ------'
                        If Not IsDBNull(DGVBind.GetDataRow(i).Item("PercDisc")) Then
                            If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                                DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
                            End If
                        End If
                        '----- Check ส่วนลด (Bath)  ------'
                        If Not IsDBNull(DGVBind.GetDataRow(i).Item("BathDisc")) Then
                            If DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                                DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
                            End If
                        End If

                        DGVBind.GetDataRow(i).Item("Total") = DGVBind.GetDataRow(i).Item("PriceSale") * DGVBind.GetDataRow(i).Item("AmtSale")

                    End If
                End If
            Next

            SumTotalNew()
        End If
    End Sub

    Private Sub rdbRetail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbRetail.CheckedChanged
        If Me.rdbRetail.Checked = True Then
            For i As Integer = 0 To DGVBind.DataRowCount - 1
                If DGVBind.GetDataRow(i).Item("idInvGroup") = 2 Then 'สินค้าทั่วไป
                    mdCnOpen()
                    Dim dt As New DataTable
                    dt.Clear()
                    sCommand.CommandText = "Select PriceRetail From dPackingPdSet Where idPdPk = " & DGVBind.GetDataRow(i).Item("idSubType")
                    sAdapter.Fill(dt)

                    If dt.Rows.Count <> 0 Then


                        DGVBind.GetDataRow(i).Item("PriceNormal") = dt.Rows(0).Item("PriceRetail")
                        DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal")

                        '----- Check ส่วนลด  ------'
                        If Not IsDBNull(DGVBind.GetDataRow(i).Item("PercDisc")) Then
                            If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                                DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
                            End If
                        End If
                        '----- Check ส่วนลด (Bath)  ------'
                        If Not IsDBNull(DGVBind.GetDataRow(i).Item("BathDisc")) Then
                            If DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                                DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
                            End If
                        End If
                        DGVBind.GetDataRow(i).Item("Total") = DGVBind.GetDataRow(i).Item("PriceSale") * DGVBind.GetDataRow(i).Item("AmtSale")

                    End If
                End If
            Next
            SumTotalNew()
        End If
    End Sub

    Private Sub rdbBill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbBill.CheckedChanged
        If DGVBind.DataRowCount > 1 Then
            If Me.rdbBill.Checked = True Then
                For i As Integer = 0 To DGVBind.DataRowCount - 1
                    If DGVBind.GetDataRow(i).Item("idInvGroup") = 2 Then 'สินค้าทั่วไป
                        mdCnOpen()
                        Dim dt As New DataTable
                        sDs.Tables.Clear()
                        sCommand.CommandText = "Select PriceBill From dPackingPdSet Where idPdPk = " & DGVBind.GetDataRow(i).Item("idSubType")
                        sAdapter.Fill(dt)

                        If dt.Rows.Count <> 0 Then

                            DGVBind.GetDataRow(i).Item("PriceNormal") = dt.Rows(0).Item("PriceBill")
                            DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal")

                            '----- Check ส่วนลด  ------'
                            If Not IsDBNull(DGVBind.GetDataRow(i).Item("PercDisc")) Then
                                If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                                    DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
                                End If
                            End If
                            '----- Check ส่วนลด (Bath)  ------'
                            If Not IsDBNull(DGVBind.GetDataRow(i).Item("BathDisc")) Then
                                If DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                                    DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
                                End If
                            End If
                            DGVBind.GetDataRow(i).Item("Total") = DGVBind.GetDataRow(i).Item("PriceSale") * DGVBind.GetDataRow(i).Item("AmtSale")
                        End If
                    End If
                Next
                SumTotalNew()

            End If
        End If
    End Sub

    Private Sub btnRefDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefDoc.Click
        Dim vFrm As New frmSaleDocCode
        vFrm.Show()
    End Sub

    Private Sub btn_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_img.Click
        If eEvent = eProcess.eAddCombine Then 'AddNew      
            If sDt_flagpic_Rec.Rows.Count = 0 Then  ' No img
                Dim vFrm As New frmSlSalePic(frmSlSalePic.eProcess.eAddNew, "", Nothing)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    sDt_flagpic_Rec = vFrm.sDt_flagpic
                End If
            Else  ' has img
                Dim vFrm As New frmSlSalePic(frmSlSalePic.eProcess.eAddNewPlus, "", sDt_flagpic_Rec)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    sDt_flagpic_Rec = vFrm.sDt_flagpic
                End If
            End If
        ElseIf eEvent = eProcess.eEditCombine Or eEvent = eProcess.eAddPic Then 'EditData
            Dim vFrm As New frmSlSalePic(frmSlSalePic.eProcess.eEdit, idSaleS, Nothing)
            vFrm.Show()
        ElseIf eEvent = eProcess.eAccept Or eEvent = eProcess.eCheck Or eEvent = eProcess.eApprove Then 'Accept/Check/Approve
            vFrmACAp = New frmSlSalePicShow(frmSlSalePicShow.eProcess.eShowBillSale, idSaleS, Me.Location)
            vFrmACAp.Show()
        ElseIf eEvent = eProcess.eView Then 'view
            Dim vFrm As New frmSlSalePicShow(frmSlSalePicShow.eProcess.eView, idSaleS, Nothing)
            vFrm.Show()
        End If
    End Sub

    Private Sub cmbTp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTp.SelectedIndexChanged
        If DGVBind.DataRowCount >= 0 Then
            mdCnOpen()
            Dim dt As New DataTable
            sDs.Tables.Clear()
            sCommand.CommandText = "Select PayDay, PayPerc From SmPaymentTermsD Where idPM =" & Me.cmbTp.SelectedValue & ""
            sAdapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("PayDay") <> 0 Then
                    Dim DateSale As Date = dtpSale.Value
                    Me.dtpPay.Value = DateSale.AddDays(dt.Rows(0).Item("PayDay"))
                Else
                    Me.dtpPay.Value = Date.Today
                End If

                If dt.Rows(0).Item("PayPerc") <> 0 Then
                    Me.txtPercP.Text = dt.Rows(0).Item("PayPerc")
                    Dim PrePay As Double = (CDbl(txtTotalNet.Text) * dt.Rows(0).Item("PayPerc")) / 100
                    Me.txtPrePay.Text = Format(PrePay, "#,##0.00")
                Else
                    Me.txtPercP.Text = 0
                    Me.txtPrePay.Text = 0
                End If

                If Me.cmbTp.SelectedValue = 49 Then 'credit 30
                    For i As Integer = 0 To DGVBind.DataRowCount - 1
                        If DGVBind.GetDataRow(i).Item("idInvGroup") = 29 Then 'สินค้าอื่นๆ (ไม่ใช่เมล็ด)
                            Dim PriceTempDt As New DataTable
                            PriceTempDt.Clear()
                            mdCnOpen()
                            'sCommand.CommandText = "SELECT CreditThirty FROM SmPdOtherD WHERE idPdO = " & DGVBind.GetDataRow(i).Item("idSubType") & ""
                            sCommand.CommandText = "SELECT CreditThirty" & vbNewLine &
                                                    "FROM SmPdOtherD d" & vbNewLine &
                                                    "LEFT JOIN dInventoryMain main ON d.idPdO = main.idSubType " & vbNewLine &
                                                    "LEFT JOIN dInvGroup g ON main.idInvGroup = g.idInvGroup" & vbNewLine &
                                                    "WHERE idPdO = " & DGVBind.GetDataRow(i).Item("idSubType") & vbNewLine &
                                                    "AND g.stPdOther = 1"

                            sAdapter.Fill(PriceTempDt)

                            If PriceTempDt.Rows.Count > 0 Then
                                If Not IsDBNull(PriceTempDt.Rows(0).Item("CreditThirty")) Then
                                    DGVBind.GetDataRow(i).Item("PriceNormal") = PriceTempDt.Rows(0).Item("CreditThirty")

                                    If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                                        DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
                                    ElseIf DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                                        DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
                                    Else
                                        DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal")
                                    End If

                                    DGVBind.GetDataRow(i).Item("Total") = DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("AmtSale")
                                End If
                            End If
                        End If

                    Next

                    SumTotalNew()
                ElseIf Me.cmbTp.SelectedValue = 50 Then 'credit 60

                    For i As Integer = 0 To DGVBind.DataRowCount - 1
                        If DGVBind.GetDataRow(i).Item("idInvGroup") = 29 Then 'สินค้าอื่นๆ (ไม่ใช่เมล็ด)
                            Dim PriceTempDt As New DataTable
                            PriceTempDt.Clear()
                            mdCnOpen()
                            'sCommand.CommandText = "SELECT CreditSixty FROM SmPdOtherD WHERE idPdO = " & DGVBind.GetDataRow(i).Item("idSubType") & ""
                            sCommand.CommandText = "SELECT CreditSixty" & vbNewLine &
                                                  "FROM SmPdOtherD d" & vbNewLine &
                                                  "LEFT JOIN dInventoryMain main ON d.idPdO = main.idSubType " & vbNewLine &
                                                  "LEFT JOIN dInvGroup g ON main.idInvGroup = g.idInvGroup" & vbNewLine &
                                                  "WHERE idPdO = " & DGVBind.GetDataRow(i).Item("idSubType") & vbNewLine &
                                                  "AND g.stPdOther = 1"
                            sAdapter.Fill(PriceTempDt)

                            If PriceTempDt.Rows.Count > 0 Then
                                If Not IsDBNull(PriceTempDt.Rows(0).Item("CreditSixty")) Then
                                    DGVBind.GetDataRow(i).Item("PriceNormal") = PriceTempDt.Rows(0).Item("CreditSixty")

                                    If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                                        DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
                                    ElseIf DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                                        DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
                                    Else
                                        DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal")
                                    End If

                                    DGVBind.GetDataRow(i).Item("Total") = DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("AmtSale")
                                End If
                            End If
                        End If
                    Next
                    SumTotalNew()
                Else

                    For i As Integer = 0 To DGVBind.DataRowCount - 1
                        If DGVBind.GetDataRow(i).Item("idInvGroup") = 29 Then 'สินค้าอื่นๆ (ไม่ใช่เมล็ด)
                            Dim PriceTempDt As New DataTable
                            PriceTempDt.Clear()
                            mdCnOpen()
                            'sCommand.CommandText = "SELECT Price FROM SmPdOtherD WHERE idPdO = " & DGVBind.GetDataRow(i).Item("idSubType") & ""
                            sCommand.CommandText = "SELECT Price" & vbNewLine &
                                           "FROM SmPdOtherD d" & vbNewLine &
                                           "LEFT JOIN dInventoryMain main ON d.idPdO = main.idSubType " & vbNewLine &
                                           "LEFT JOIN dInvGroup g ON main.idInvGroup = g.idInvGroup" & vbNewLine &
                                           "WHERE idPdO = " & DGVBind.GetDataRow(i).Item("idSubType") & vbNewLine &
                                           "AND g.stPdOther = 1"

                            sAdapter.Fill(PriceTempDt)

                            If PriceTempDt.Rows.Count > 0 Then
                                DGVBind.GetDataRow(i).Item("PriceNormal") = PriceTempDt.Rows(0).Item("Price")

                                If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                                    DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
                                ElseIf DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                                    DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
                                Else
                                    'f DGVBind.GetDataRow(i).Item("BathDisc") = 0 Then
                                    DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal")
                                End If

                                DGVBind.GetDataRow(i).Item("Total") = DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("AmtSale")
                            End If
                        End If

                    Next
                    SumTotalNew()
                End If

            End If 'End check stPage
        End If
    End Sub

    '-----------Open Comment when send to PN
    Private Sub btmOrderPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sDt As New DataTable
        Dim idOrder_temp As New DataTable
        idOrder_temp.Columns.Add("idSaleOrder", Type.GetType("System.Decimal"))

        Dim d As Integer = 0
        '-----------------NEW-----------------------------
        For i As Integer = 0 To DGVBind.DataRowCount - 1
            If Not IsDBNull(DGVBind.GetDataRow(i).Item("idSaleOrderDt")) Then
                sDt.Clear()
                sCommand.CommandText = "SELECT idSaleOrder " & vbNewLine &
                                        "FROM SmSaleOrderDt  " &
                                        "WHERE idSaleOrderDt = " & DGVBind.GetDataRow(i).Item("idSaleOrderDt")
                sAdapter.Fill(sDt)

                idOrder_temp.Rows.Add()
                idOrder_temp.Rows(d).Item("idSaleOrder") = sDt.Rows(0).Item("idSaleOrder")
                d = d + 1
            End If
        Next
        '-------------------------------------------------
        Dim vFrm As New frmSlOrderPic(frmSlOrderPic.eProcess.eViewFromSale, Nothing, idOrder_temp)
        vFrm.Show()
    End Sub

    Private Sub AddDatatableDel()
        dtDel.Columns.Add("idLot", System.Type.GetType("System.Int64"))
        dtDel.Columns.Add("idInvMain", System.Type.GetType("System.Int64"))
        dtDel.Columns.Add("idWh", System.Type.GetType("System.Int64"))
        dtDel.Columns.Add("idSaleDt", System.Type.GetType("System.Int64"))
        dtDel.Columns.Add("AmtSale", System.Type.GetType("System.Double"))
        dtDel.Columns.Add("LotNo", System.Type.GetType("System.String"))
        dtDel.Columns.Add("idUnit", System.Type.GetType("System.Int64"))
        dtDel.Columns.Add("idInvGroup", System.Type.GetType("System.Int64"))
        dtDel.Columns.Add("stCutStock", System.Type.GetType("System.Int64"))
        dtDel.Columns.Add("idSaleOrderDt", System.Type.GetType("System.Int64"))
        dtDel.Columns.Add("full_lock", System.Type.GetType("System.String"))
    End Sub

#Region "fnAddDataTable"
    Private Sub fnAddDataTable()
        MainReturn.Columns.Add("idSubType", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("PdCode", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("CodeOrder", System.Type.GetType("System.String")) 'เลขที่รายการสั่งซื้อ
        MainReturn.Columns.Add("LotNo", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("LotNoHide", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("ProductName", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("AmtStock", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("AmtOrder", System.Type.GetType("System.Double")) 'จน.สั่งซื้อ
        MainReturn.Columns.Add("AmtSale", System.Type.GetType("System.Double")) 'จำนวนขาย
        MainReturn.Columns.Add("AmtSaleHide", System.Type.GetType("System.Double")) 'จำนวนขาย
        MainReturn.Columns.Add("UnitName", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("PriceNormal", System.Type.GetType("System.Double")) 'ราคาปกติ
        MainReturn.Columns.Add("PriceNormalHide", System.Type.GetType("System.Double")) 'ราคาปกติ
        MainReturn.Columns.Add("PercDisc", System.Type.GetType("System.Double")) 'ส่วนลด %
        MainReturn.Columns.Add("PercDiscHide", System.Type.GetType("System.Double")) 'ส่วนลด %
        MainReturn.Columns.Add("BathDisc", System.Type.GetType("System.Double")) 'ส่วนลด (บาท)
        MainReturn.Columns.Add("BathDiscHide", System.Type.GetType("System.Double")) 'ส่วนลด (บาท)
        MainReturn.Columns.Add("PriceSale", System.Type.GetType("System.Double")) 'ราคาขาย
        MainReturn.Columns.Add("PriceSaleHide", System.Type.GetType("System.Double")) 'ราคาขาย
        MainReturn.Columns.Add("Total", System.Type.GetType("System.Double")) 'รวมเป็นเงิน
        MainReturn.Columns.Add("idUnit", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idUnitHide", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idSaleOrderDt", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idSaleDt", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("OldStock", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("OldAmt", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("CompRec", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idLot", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idLotHide", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("chk", System.Type.GetType("System.Boolean"))
        MainReturn.Columns.Add("idInvMain", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idInvMainHide", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idLotSPM", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idWh", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idWhHide", System.Type.GetType("System.Int64"))

        MainReturn.Columns.Add("idInvGroup", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idInvGroupHide", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("DtType", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("stEdit", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("AmtWIMRecBal", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("stWIMAllRec", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idRefLot", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idRefLotHide", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idPkPORecDt", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("stCutStock", System.Type.GetType("System.Int64"))

        MainReturn.Columns.Add("pWeight", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("idUnitW", System.Type.GetType("System.Int64"))

        MainReturn.Columns.Add("full_lock", System.Type.GetType("System.String"))

    End Sub
#End Region

    Private Sub btnPdInc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPdInc.Click
        If Me.lblPsCus.Text = "" Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการเลือกสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ColCodeOrder.Visible = False
        colAmtOrder.Visible = False


        Dim vFrm As New frmInvLotSelect
        vFrm.GetCompany(cmbGroupComp.SelectedValue, cmbGroupComp.Text)

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            mdCnOpen()

            For round As Integer = 0 To vFrm.MainReturn.Rows.Count - 1

                Dim defaultAmtSale As Double = 0
                Dim PriceNormal As Double = 0
                Dim LastPrice As Double = 0.0 'ราคาขายล่าสุด

                Dim dtLastPrice As New DataTable
                Dim gLastPrice As Double = 0.0
                sCommand.CommandText = "SELECT TOP(1) ISNULL(dt.Price,0) As LastPrice " & vbNewLine &
                                        "FROM SmSaleDtAll dt " & vbNewLine &
                                        "LEFT OUTER JOIN SmSaleMt mt ON dt.idsale = mt.idSale " & vbNewLine &
                                        "WHERE mt.idPartner = " & idPartner & vbNewLine &
                                        "AND dt.idProduct =  " & vFrm.MainReturn.Rows(round).Item("idInvMain") & vbNewLine &
                                        "AND mt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                        "AND ISNULL(dt.Price,0) > 0" & vbNewLine &
                                        "Order by mt.DateSale DESC "
                sAdapter.Fill(dtLastPrice)

                If dtLastPrice.Rows.Count <> 0 Then
                    gLastPrice = dtLastPrice.Rows(0).Item("LastPrice")
                End If

                '---Default จำนวนขาย
                If vFrm.MainReturn.Rows(round).Item("AmtStock") >= 1 And cmbGroupComp.SelectedValue <> 2 Then
                    defaultAmtSale = 1
                Else
                    If Not IsDBNull(vFrm.MainReturn.Rows(round).Item("AmtStock")) Then
                        defaultAmtSale = vFrm.MainReturn.Rows(round).Item("AmtStock")
                    End If
                End If

                If Me.rdbWhole.Checked = True Then
                    PriceNormal = vFrm.MainReturn.Rows(round).Item("PriceWholesale_fg")
                ElseIf Me.rdbRetail.Checked = True Then
                    PriceNormal = vFrm.MainReturn.Rows(round).Item("PriceRetail_fg")
                ElseIf Me.rdbBill.Checked = True Then
                    PriceNormal = vFrm.MainReturn.Rows(round).Item("PriceBill_fg")
                End If

                If vFrm.MainReturn.Rows(round).Item("idPdoType") = 3 Then  ' พลาสติกคลุมดิน
                    If Me.cmbTp.SelectedValue = 49 Then  ' credit 30
                        PriceNormal = vFrm.MainReturn.Rows(round).Item("CreditThirty_pdo")
                        If gLastPrice <> 0 Then
                            LastPrice = gLastPrice
                        Else
                            LastPrice = vFrm.MainReturn.Rows(round).Item("CreditThirty_pdo")
                        End If

                    ElseIf Me.cmbTp.SelectedValue = 50 Then  ' credit 60
                        PriceNormal = vFrm.MainReturn.Rows(round).Item("CreditSixty_pdo")
                        If gLastPrice <> 0 Then
                            LastPrice = gLastPrice
                        Else
                            LastPrice = vFrm.MainReturn.Rows(round).Item("CreditSixty_pdo")
                        End If

                    Else  ' Other
                        PriceNormal = vFrm.MainReturn.Rows(round).Item("PricePdo_pdo")
                        If gLastPrice <> 0 Then
                            LastPrice = gLastPrice
                        Else
                            LastPrice = vFrm.MainReturn.Rows(round).Item("PricePdo_pdo")
                        End If
                    End If

                ElseIf vFrm.MainReturn.Rows(round).Item("idInvGroup") <> 2 Then  ' Other Type except FG (idInvGroup = 2)
                    If IsDBNull(vFrm.MainReturn.Rows(round).Item("PricePdo_pdo")) Then
                        PriceNormal = 0.0
                    Else
                        PriceNormal = vFrm.MainReturn.Rows(round).Item("PricePdo_pdo")
                    End If
                End If

                If vFrm.MainReturn.Rows(round).Item("idInvGroup") = 1 Then  ' Other Type except FG (idInvGroup = 2)
                    PriceNormal = vFrm.MainReturn.Rows(round).Item("PriceSeed")
                End If

                If PriceNormal <> 0 Then
                    LastPrice = PriceNormal
                Else
                    LastPrice = gLastPrice
                    PriceNormal = gLastPrice
                End If

                DGVBind.AddNewRow()
                DGVBind.SetFocusedRowCellValue("PdCode", vFrm.MainReturn.Rows(round).Item("PdCode"))
                DGVBind.SetFocusedRowCellValue("LotNo", vFrm.MainReturn.Rows(round).Item("LotNo"))

                If IsDBNull(vFrm.MainReturn.Rows(round).Item("idInvMain")) Then
                    DGVBind.SetFocusedRowCellValue("idInvMain", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("idInvMain", vFrm.MainReturn.Rows(round).Item("idInvMain"))
                End If

                DGVBind.SetFocusedRowCellValue("ProductName", vFrm.MainReturn.Rows(round).Item("InvName"))

                DGVBind.SetFocusedRowCellValue("AmtOrder", 0)
                DGVBind.SetFocusedRowCellValue("OldAmt", 0)

                DGVBind.SetFocusedRowCellValue("PriceNormal", PriceNormal)
                DGVBind.SetFocusedRowCellValue("PercDisc", 0.0)
                DGVBind.SetFocusedRowCellValue("BathDisc", 0.0)
                DGVBind.SetFocusedRowCellValue("PriceSale", LastPrice)
                DGVBind.SetFocusedRowCellValue("Total", LastPrice)
                DGVBind.SetFocusedRowCellValue("idSaleDt", 0)
                DGVBind.SetFocusedRowCellValue("idRefLot", vFrm.MainReturn.Rows(round).Item("idRefLot"))
                DGVBind.SetFocusedRowCellValue("CompRec", vFrm.MainReturn.Rows(round).Item("CompRec"))
                DGVBind.SetFocusedRowCellValue("idUnitW", vFrm.MainReturn.Rows(round).Item("idUnitW"))
                DGVBind.SetFocusedRowCellValue("pWeight", vFrm.MainReturn.Rows(round).Item("pWeight"))


                If IsDBNull(vFrm.MainReturn.Rows(round).Item("idWh")) Then
                    DGVBind.SetFocusedRowCellValue("idWh", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("idWh", vFrm.MainReturn.Rows(round).Item("idWh"))
                    DGVBind.SetFocusedRowCellValue("full_lock", vFrm.MainReturn.Rows(round).Item("full_lock"))
                End If

                If IsDBNull(vFrm.MainReturn.Rows(round).Item("idLotSPM")) Then
                    DGVBind.SetFocusedRowCellValue("idLotSPM", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("idLotSPM", vFrm.MainReturn.Rows(round).Item("idLotSPM"))
                End If

                If IsDBNull(vFrm.MainReturn.Rows(round).Item("idInvGroup")) Then
                    DGVBind.SetFocusedRowCellValue("idInvGroup", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("idInvGroup", vFrm.MainReturn.Rows(round).Item("idInvGroup"))
                End If

                If IsDBNull(vFrm.MainReturn.Rows(round).Item("DtType")) Then
                    DGVBind.SetFocusedRowCellValue("DtType", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("DtType", vFrm.MainReturn.Rows(round).Item("DtType"))
                End If

                If IsDBNull(vFrm.MainReturn.Rows(round).Item("idSubType")) Then
                    DGVBind.SetFocusedRowCellValue("idSubType", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("idSubType", vFrm.MainReturn.Rows(round).Item("idSubType"))
                End If

                'check stock : หัก stock ของ rows ก่อนหน้า
                Dim SumStockinBill As Double = 0.0

                For j As Integer = 0 To DGVBind.DataRowCount - 1
                    If IsDBNull(vFrm.MainReturn.Rows(round).Item("idLot")) Then
                        vFrm.MainReturn.Rows(round).Item("idLot") = 0
                    End If

                    If vFrm.MainReturn.Rows(round).Item("idLot") <> 0 Then
                        If (DGVBind.GetDataRow(j).Item("idLot") = vFrm.MainReturn.Rows(round).Item("idLot")) And
                           (DGVBind.GetDataRow(j).Item("idRefLot") = vFrm.MainReturn.Rows(round).Item("idRefLot")) Then

                            Dim CalAmt As Double = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(j).Item("idUnit"), DGVBind.GetDataRow(j).Item("idInvGroup"),
                                                               CDbl(DGVBind.GetDataRow(j).Item("OldAmt")), DGVBind.GetDataRow(j).Item("idInvMain"))


                            SumStockinBill = SumStockinBill + CalAmt
                        End If

                    End If
                Next

                If vFrm.MainReturn.Rows(round).Item("idInvGroup") <> 30 Then
                    If IsDBNull(vFrm.MainReturn.Rows(round).Item("AmtStock")) Then
                        DGVBind.SetFocusedRowCellValue("AmtStock", SumStockinBill)
                    Else
                        DGVBind.SetFocusedRowCellValue("AmtStock", vFrm.MainReturn.Rows(round).Item("AmtStock") + SumStockinBill)

                    End If
                ElseIf vFrm.MainReturn.Rows(round).Item("idInvGroup") = 30 Then
                    'ถ้าเป็น idInvGroup = 30 ให้ Stock = 0
                    DGVBind.SetFocusedRowCellValue("AmtStock", 1)
                End If

                If IsDBNull(vFrm.MainReturn.Rows(round).Item("idLot")) Then
                    DGVBind.SetFocusedRowCellValue("idLot", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("idLot", vFrm.MainReturn.Rows(round).Item("idLot"))
                End If

                DGVBind.SetFocusedRowCellValue("UnitName", vFrm.MainReturn.Rows(round).Item("UnitName"))

                If IsDBNull(vFrm.MainReturn.Rows(round).Item("idUnit")) Then
                    DGVBind.SetFocusedRowCellValue("idUnit", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("idUnit", vFrm.MainReturn.Rows(round).Item("idUnit"))
                End If

                DGVBind.SetFocusedRowCellValue("AmtSale", defaultAmtSale)
                DGVBind.RefreshData()

                Dim AmountUse As Double = 0.0
                Dim SumAmtOfLot As Double = 0.0

                For j As Integer = 0 To DGVBind.DataRowCount - 1
                    If (DGVBind.GetDataRow(j).Item("idLot") = vFrm.MainReturn.Rows(round).Item("idLot")) And
                           (DGVBind.GetDataRow(j).Item("idRefLot") = vFrm.MainReturn.Rows(round).Item("idRefLot")) Then

                        AmountUse = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(j).Item("idUnit"), DGVBind.GetDataRow(j).Item("idInvGroup"),
                                                               CDbl(DGVBind.GetDataRow(j).Item("AmtSale")), DGVBind.GetDataRow(j).Item("idInvMain"))

                        SumAmtOfLot = SumAmtOfLot + AmountUse

                        SumAmtOfLot = Math.Round(SumAmtOfLot, 6, MidpointRounding.AwayFromZero)

                        If DGVBind.GetDataRow(j).Item("AmtStock") < SumAmtOfLot Then  ' Stock < AllSaleAmount
                            Dim ShowUnit As String = ""

                            If DGVBind.GetDataRow(j).Item("idUnit") = 1 Then '"กรัม" Then
                                ShowUnit = "กิโลกรัม"
                            Else
                                ShowUnit = DGVBind.GetDataRow(j).Item("UnitName")
                            End If

                            MessageBox.Show("จำนวนสินค้าคงเหลือใน Stock ไม่เพียงพอต่อความต้องการ" & vbCrLf &
                                            "(จำนวนขายรวม : " & Format(SumAmtOfLot, "#,##0.00##") & " " & ShowUnit &
                                            " แต่จำนวน Stock คงเหลือ : " & Format(DGVBind.GetDataRow(j).Item("AmtStock"), "#,##0.00##") & " " & ShowUnit & ")", sSystemName)

                            DGVBind.SetRowCellValue(j, "AmtSale", 0)

                        End If
                    End If
                Next

                For j As Integer = 0 To tempDelete.Rows.Count - 1 ' รายการที่ลบ : ไม่แสดงใน gridview
                    If IsDBNull(tempDelete.Rows(j).Item("idLot")) Then
                        tempDelete.Rows(j).Item("idLot") = 0
                    End If

                    If (tempDelete.Rows(j).Item("idLot") = vFrm.MainReturn.Rows(round).Item("idLot")) And
                      (tempDelete.Rows(j).Item("idRefLot") = vFrm.MainReturn.Rows(round).Item("idRefLot")) Then
                        If IsDBNull(tempDelete.Rows(j).Item("AmtDel")) Then
                            SumStockinBill = SumStockinBill
                        Else
                            SumStockinBill = SumStockinBill + tempDelete.Rows(j).Item("AmtDel")
                        End If

                    End If
                Next
            Next

        End If  ' End dialogresult 

        mdLoadCommitt()
        SumTotalNew()
    End Sub

    Private Function fnCalAmtxUnit(ByVal mycommand As SqlCommand, ByVal idUnit As Integer, ByVal idInvGroup As Integer, ByVal AmtSale As Double, ByVal idInvMain As Integer) As Double
        Dim CalAmt As Double = 0.0
        Dim myAdapter = New SqlDataAdapter(mycommand)
        '------แปลงหน่วย ก่อน คืน + เพิ่ม สต๊อกกกกกก
        If idInvGroup = 1 And idUnit = 1 Then ' วัตถุดิบ + กรัม
            CalAmt = CDbl(AmtSale) / 1000

        Else

            Dim dtInvUnitSub As New DataTable
            'mdCnOpen()

            dtInvUnitSub.Clear()

            mycommand.CommandText = "SELECT ISNULL(AmtMainperSub,0) As AmtMainperSub, idSubUnit, idUnit " & vbNewLine &
                                   "FROM  dInvUnitSub " & vbNewLine &
                                   "WHERE idSubUnit = " & idUnit & " AND idInvMain = " & idInvMain
            myAdapter.Fill(dtInvUnitSub)

            If dtInvUnitSub.Rows.Count > 0 Then 'มี idSubUnit
                'Check ว่า idUnit ที่เลือกตอนนี้เป็น Unit หลัก หรือ Unit รอง
                If idUnit = dtInvUnitSub.Rows(0).Item("idSubUnit") Then 'แสดงว่าเป็นหน่วยรอง ต้อง  Convert

                    CalAmt = CDbl(AmtSale) * dtInvUnitSub.Rows(0).Item("AmtMainperSub")

                End If

            Else
                CalAmt = CDbl(AmtSale)

            End If
        End If

        Return CalAmt
    End Function


    Private Sub CheckCodeRefDup()
        mdCnOpen()
        mdLoadShow()
        If Trim(Me.txtDocRef.Text) <> "" Then
            Dim CodeRef As String = Trim(Me.cmbDRCode.Text) & " " & Trim(Me.txtDocRef.Text)

            If CodeRef <> DocCodeChk Then
                '----Check DocRef -------'
                Dim dRefDt As New DataTable
                Dim vWHERE As String = ""

                If eEvent = eProcess.eEditCombine Then 'EditData
                    vWHERE = " AND idSale <> " & idSaleS & ""
                End If

                sCommand.CommandText = "Select mt.DocCode, mt.DateSale, mt.DocRef, mt.idPscancel, p.PartnerName" & vbNewLine &
                                        "From SmSaleMt mt " & vbNewLine &
                                        "LEFT OUTER JOIN dPartner p ON mt.idPartner = p.idPartner  " & vbNewLine &
                                        "Where mt.idPscancel IS NULL AND mt.DocRef = '" & CodeRef & "' AND mt.idComp = " & cmbGroupComp.SelectedValue & "" & vWHERE
                sAdapter.Fill(dRefDt)

                If dRefDt.Rows.Count > 0 Then
                    mdLoadCommitt()
                    DocCodeChk = ""
                    MessageBox.Show("เลขที่อ้างอิงซ้ำกับข้อมูลเดิม รายละเอียดรายการดังนี้ " & vbCrLf & "เลขที่รายการ : " & dRefDt.Rows(0).Item("DocCode") & vbCrLf &
                    "วันที่ขาย : " & ksbStringToDate(dRefDt.Rows(0).Item("DateSale")) & vbCrLf &
                    "ชื่อลูกค้า : " & dRefDt.Rows(0).Item("PartnerName") & vbCrLf & vbCrLf &
                    "***หากต้องการบันทึก ให้เพิ่มตัวอักษรหลังรหัส ดังนี้" & vbCrLf &
                    "   A : แอ๊ดว้านซีดส์" & vbCrLf &
                    "   F : โฟลเทคซีดส์" & vbCrLf & " เช่น 5710001A หรือ 5710001F", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtDocRef.Focus()
                    Exit Sub
                End If
                DocCodeChk = CodeRef
            End If
        End If
        mdLoadCommitt()
    End Sub

    Private Sub txtDocRef_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDocRef.KeyDown
        If e.KeyCode = Keys.Enter Then
            If eEvent <> eProcess.eView And eEvent <> eProcess.eAccept And eEvent <> eProcess.eCheck And eEvent <> eProcess.eApprove Then  'view/Accept/Check/Approve
                CheckCodeRefDup()
            End If
        End If
    End Sub

    Private Sub txtDocRef_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDocRef.Leave
        If eEvent <> eProcess.eView And eEvent <> eProcess.eAccept And eEvent <> eProcess.eCheck And eEvent <> eProcess.eApprove Then  'view/Accept/Check/Approve
            CheckCodeRefDup()
        End If
    End Sub

    Private Sub cmbDRCode_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDRCode.SelectedValueChanged
        If eEvent <> eProcess.eView And eEvent <> eProcess.eAccept And eEvent <> eProcess.eCheck And eEvent <> eProcess.eApprove Then   'view/Accept/Check/Approve
            CheckCodeRefDup()

            '--- Check ถูกหลัก/ไม่ถูกหลัก ---'
            If Me.cmbDRCode.Text <> "" Then
                Dim tempDt As New DataTable
                ' mdCnOpen()
                sCommand.CommandText = "Select stRight From SmSaleCodeComp Where idComp = " & cmbGroupComp.SelectedValue & " AND SaleCode = '" & Me.cmbDRCode.Text & "'"
                sAdapter.Fill(tempDt)

                If tempDt.Rows(0).Item("stRight") = 1 Then
                    Me.rdbRight.Checked = True
                Else
                    Me.rdbNoRight.Checked = True
                End If
            End If
        End If
    End Sub

    Private Sub frmSlSaleTs_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        vFrmACAp.Close()
    End Sub

    Private Sub btnAddressS_Click(sender As Object, e As EventArgs) Handles btnAddressS.Click

        Dim vFrm As New frmCusAdsSent(frmCusAdsSent.eProcess.eSelect, Me.lblPsCus.Tag)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblAddr.Tag = vFrm.idCusRefAddr 'idRef update to dCustomer

            mdCnOpen()


            '--- Set TransportComp ----'
            '---เชคขนส่งจากเงื่อนไขพิเศษก่อน---
            Dim TspDt As New DataTable
            TspDt.Rows.Clear()
            sCommand.CommandText = "Select v.idCusRefAddr,s.AddressS, s.PsRecName, s.idTsp, s.idSupTsp, sp.SupName, ISNULL(s.idPayTsp,0) As idPayTsp " & vbNewLine &
                                   "FROM vCusAdrSetTransport v " & vbNewLine &
                                   "LEFT JOIn dCustomerAdrSent s ON v.idCusRefAddr = s.idCusRefAddr" & vbNewLine &
                                   "LEFT OUTER JOIN PchInvAndProject.dbo.vSupplier sp ON s.idSupTsp = sp.idSup " & vbNewLine &
                                   "WHERE v.idCusRefAddr = " & vFrm.idCusRefAddr & vbNewLine &
                                   "AND v.idComp = " & cmbGroupComp.SelectedValue
            sAdapter.Fill(TspDt)


            If TspDt.Rows.Count = 0 Then  'ไม่มีรายการในขนส่งพิเศษนี้  
                Dim sDt As New DataTable
                sCommand.CommandText = "Select s.AddressS, s.stFromS, s.PsRecName, s.idTsp, ISNULL(s.idPayTsp,0) As idPayTsp, ISNULL(s.idSupTsp,0) As idSupTsp, ISNULL(sp.SupName,'') As SupName " &
                                 "From dCustomerAdrSent s " & vbNewLine &
                                 "LEFT OUTER JOIN PchInvAndProject.dbo.vSupplier sp ON s.idSupTsp = sp.idSup " & vbNewLine &
                                 "Where s.idCusRefAddr = " & vFrm.idCusRefAddr
                sAdapter.Fill(sDt)

                Me.lblAddr.Text = sDt.Rows(0).Item("AddressS")
                Me.lblCusRec.Text = sDt.Rows(0).Item("PsRecName")
                Me.CmbTs.SelectedValue = sDt.Rows(0).Item("idTsp")
                Me.cmbTypePayTrp.SelectedValue = sDt.Rows(0).Item("idPayTsp")

                Me.lblTspComp.Tag = sDt.Rows(0).Item("idSupTsp")
                Me.lblTspComp.Text = sDt.Rows(0).Item("SupName")

                If sDt.Rows(0).Item("idPayTsp") <> 0 Then
                    cmbTypePayTrp.SelectedValue = sDt.Rows(0).Item("idPayTsp")
                End If

            ElseIf TspDt.Rows.Count = 1 Then   'มีแค่ 1 รายการขนส่ง
                Me.lblAddr.Text = TspDt.Rows(0).Item("AddressS")
                Me.lblCusRec.Text = TspDt.Rows(0).Item("PsRecName")
                Me.CmbTs.SelectedValue = TspDt.Rows(0).Item("idTsp")

                Me.lblTspComp.Tag = TspDt.Rows(0).Item("idSupTsp")
                Me.lblTspComp.Text = TspDt.Rows(0).Item("SupName")

                If TspDt.Rows(0).Item("idPayTsp") <> 0 Then
                    cmbTypePayTrp.SelectedValue = TspDt.Rows(0).Item("idPayTsp")
                End If

            Else 'มีหลายรายการ
                For i As Integer = 0 To TspDt.Rows.Count - 1
                    If vFrm.idCusRefAddr = TspDt.Rows(i).Item("idCusRefAddr") Then
                        Me.lblTspComp.Tag = TspDt.Rows(i).Item("idSupTsp")
                        Me.lblTspComp.Text = TspDt.Rows(i).Item("SupName")
                    End If
                Next
            End If
        End If

    End Sub

    Private Sub DGVBind_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles DGVBind.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If

    End Sub

    Private Sub rptCheckPrice_Click(sender As Object, e As EventArgs) Handles rptCheckPrice.Click
        If DGVBind.FocusedRowHandle >= 0 Then
            Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)
            Dim vFrm As New frmSlPrice(frmSlPrice.eProcess.eViewPrice, DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idInvMain"), idPartner, cmbGroupComp.SelectedValue)

            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                dr.Item("PriceSale") = vFrm.PriceSelect
                dr.Item("PriceNormal") = vFrm.PriceSelect
                dr.Item("PercDisc") = Format(CDbl(0.0), "#,##0.00")
                dr.Item("Total") = DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("PriceSale") * DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtSale")
            End If

            SumTotalNew()
        End If

    End Sub


    Private Sub rptCheckPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles rptCheckPrice.KeyDown
        If DGVBind.FocusedRowHandle >= 0 And Keys.Enter Then
            Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)
            Dim vFrm As New frmSlPrice(frmSlPrice.eProcess.eViewPrice, DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idInvMain"), idPartner, cmbGroupComp.SelectedValue)

            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                dr.Item("PriceSale") = vFrm.PriceSelect
                dr.Item("PercDisc") = Format(CDbl(0.0), "#,##0.00")
                dr.Item("Total") = DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("PriceSale") * DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtSale")
            End If

            SumTotalNew()
        End If
    End Sub

    Private Sub DGVBind_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles DGVBind.CellValueChanged
        If DGVBind.DataRowCount > 0 Then
            Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)
            Dim navigator As ControlNavigator = GCSale.EmbeddedNavigator
            'Amount Change
            If e.Column.Name = ColAmtSale.Name Or e.Column.Name = ColidUnit.Name Then

                If IsDBNull(dr.Item("AmtSale")) Then
                    dr.Item("AmtSale") = 0.0
                End If

                If e.Column.Name = ColAmtSale.Name Then

                    'If IsDBNull(dr.Item("idLot")) Or IsDBNull(dr.Item("idInvMain")) Then
                    '    MessageBox.Show("กรุณา ระบุ ชื่อสินค้า หรือ Lot No.", sSystemName)

                    '    Exit Sub
                    'End If

                    If IsDBNull("idLot") Then
                        dr.Item("idLot") = 0
                    End If

                    If dr.Item("idLot") = 0 And dr.Item("idInvGroup") <> 30 And dr.Item("AmtSale") <> 0 Then

                        MessageBox.Show("กรุณาเลือก Lot สินค้า ก่อนระบุจำนวนขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        dr.Item("AmtSale") = 0.0

                    End If
                End If


                If Not IsDBNull(DGVBind.GetRowCellValue(e.RowHandle, ColCodeOrder.Name)) Then
                    If DGVBind.GetRowCellValue(e.RowHandle, ColCodeOrder.Name) <> Nothing Then
                        If DGVBind.GetRowCellValue(e.RowHandle, ColAmtSale.Name) > DGVBind.GetRowCellValue(e.RowHandle, colAmtOrder.Name) Then
                            MessageBox.Show("จำนวนที่ทำรายการขายมากกว่าจำนวนที่สั่งซื้อ กรุณาตรวจสอบความถูกต้องอีกครั้ง" & vbCrLf &
                                            "หากยืนยันว่าข้อมูลดังกล่าวถูกต้อง ให้ทำรายการถัดไป", sSystemName)
                        End If
                    ElseIf DGVBind.GetRowCellValue(e.RowHandle, ColCodeOrder.Name) <> "" Then
                        If DGVBind.GetRowCellValue(e.RowHandle, ColAmtSale.Name) > DGVBind.GetRowCellValue(e.RowHandle, colAmtOrder.Name) Then
                            MessageBox.Show("จำนวนที่ทำรายการขายมากกว่าจำนวนที่สั่งซื้อ กรุณาตรวจสอบความถูกต้องอีกครั้ง" & vbCrLf &
                                            "หากยืนยันว่าข้อมูลดังกล่าวถูกต้อง ให้ทำรายการถัดไป", sSystemName)
                        End If
                    End If
                End If

                If Not IsDBNull(dr.Item("idLot")) Then
                    If dr.Item("idLot") <> 0 Then
                        Dim SumAmtOfLot As Double = 0.0
                        Dim AmountUse As Double = 0.0

                        For i As Integer = 0 To DGVBind.DataRowCount - 1
                            AmountUse = 0

                            Dim sDr As DataRow = DGVBind.GetDataRow(i)

                            If Not IsDBNull(sDr.Item("idLot")) Then

                                If (sDr.Item("idLot") = dr.Item("idLot")) And
                                   (sDr.Item("idInvGroup") = dr.Item("idInvGroup")) And
                                   (sDr.Item("idRefLot") = dr.Item("idRefLot")) Then

                                    If IsDBNull(sDr.Item("AmtSale")) Then
                                        sDr.Item("AmtSale") = 0.0
                                    End If

                                    '---------------------Check วัสดุ เพื่อ Convert หน่วย
                                    AmountUse = fnCalAmtxUnit(sCommand, sDr.Item("idUnit"), sDr.Item("idInvGroup"),
                                                       CDbl(sDr.Item("AmtSale")), sDr.Item("idInvMain"))

                                    SumAmtOfLot = SumAmtOfLot + AmountUse
                                End If

                            End If

                        Next

                        SumAmtOfLot = Math.Round(SumAmtOfLot, 6, MidpointRounding.AwayFromZero)

                        If dr.Item("AmtStock") < SumAmtOfLot Then  ' Stock < AllSaleAmount
                            Dim ShowUnit As String = ""

                            If dr.Item("idUnit") = 1 Then '"กรัม" Then
                                ShowUnit = "กิโลกรัม"
                            Else
                                ShowUnit = DGVBind.GetDataRow(e.RowHandle).Item("UnitName")
                            End If

                            MessageBox.Show("จำนวนสินค้าคงเหลือใน Stock ไม่เพียงพอต่อความต้องการ" & vbCrLf &
                                            "(จำนวนขายรวม : " & Format(SumAmtOfLot, "#,##0.00##") & " " & ShowUnit &
                                            " แต่จำนวน Stock คงเหลือ : " & Format(DGVBind.GetDataRow(e.RowHandle).Item("AmtStock"), "#,##0.00##") & " " & ShowUnit & ")", sSystemName)

                            dr.Item("AmtSale") = 0.0
                        End If
                    End If

                    SumcolAmountExpNewGrid()
                End If
            End If


            If e.Column.Name = ColidUnit.Name Then

                Dim SumAmtOfLot As Double = 0.0
                For i As Integer = 0 To DGVBind.DataRowCount - 1
                    Dim sDr As DataRow = DGVBind.GetDataRow(i)

                    If (sDr.Item("idLot") = dr.Item("idLot")) And sDr.Item("idInvMain") = dr.Item("idInvMain") And (sDr.Item("idRefLot") = dr.Item("idRefLot")) Then

                        Dim AmountUse As Double = 0.0
                        If IsDBNull(sDr.Item("AmtSale")) Then
                            sDr.Item("AmtSale") = 0.0
                        End If

                        AmountUse = fnCalAmtxUnit(sCommand, sDr.Item("idUnit"), sDr.Item("idInvGroup"),
                                                      CDbl(sDr.Item("AmtSale")), sDr.Item("idInvMain"))

                        SumAmtOfLot = SumAmtOfLot + AmountUse
                    End If
                Next

                ' Dim vAmtStockC As Double = 
                If dr.Item("AmtStock") < SumAmtOfLot Then  ' Stock < AllSaleAmount

                    Dim ShowUnit As String = ""

                    If dr.Item("idUnit") = 1 Then '"กรัม" Then
                        ShowUnit = "กิโลกรัม"
                    Else
                        ShowUnit = DGVBind.GetDataRow(e.RowHandle).Item("UnitName")
                    End If

                    MessageBox.Show("จำนวนสินค้าคงเหลือใน Stock ไม่เพียงพอต่อความต้องการ" & vbCrLf &
                                    "(จำนวนขายรวม : " & Format(SumAmtOfLot, "#,##0.00##") & " " & ShowUnit &
                                    " แต่จำนวน Stock คงเหลือ : " & Format(DGVBind.GetDataRow(e.RowHandle).Item("AmtStock"), "#,##0.00##") & " " & ShowUnit & ")", sSystemName)

                    dr.Item("AmtSale") = 0.0
                End If

                SumcolAmountExpNewGrid()
            End If

            'PriceChange
            If e.Column.Name = ColPriceNormal.Name Then

                'If IsDBNull(dr.Item("idLot")) Or IsDBNull(dr.Item("idInvMain")) Then
                '    MessageBox.Show("กรุณา ระบุ ชื่อสินค้า หรือ Lot No.", sSystemName)

                '    Exit Sub
                'End If


                If IsDBNull(dr.Item("PriceNormal")) Then
                    dr.Item("PriceNormal") = 0.0
                Else
                    dr.Item("PriceNormal") = CDbl(dr.Item("PriceNormal"))
                End If
                'chkUnit()
                SumcolAmountExpNewGrid()
            End If

            'PriceSale
            If e.Column.Name = ColPriceSale.Name Then

                'If IsDBNull(dr.Item("idLot")) Or IsDBNull(dr.Item("idInvMain")) Then
                '    MessageBox.Show("กรุณา ระบุ ชื่อสินค้า หรือ Lot No.", sSystemName)

                '    Exit Sub
                'End If

                If IsDBNull(dr.Item("PriceSale")) Then
                    dr.Item("PriceSale") = 0.0
                End If

                If dr.Item("PriceNormal") = 0 Then
                    dr.Item("PriceNormal") = dr.Item("PriceSale")
                End If

                'chkUnit()
                SumcolAmountExpNewGrid()
            End If

            'Discount %
            If e.Column.Name = ColPercDiscount.Name Then

                'If IsDBNull(dr.Item("idLot")) Or IsDBNull(dr.Item("idInvMain")) Then
                '    MessageBox.Show("กรุณา ระบุ ชื่อสินค้า หรือ Lot No.", sSystemName)

                '    Exit Sub
                'End If

                If IsDBNull(dr.Item("PriceSale")) Then
                    dr.Item("PriceSale") = 0.0
                End If

                If IsDBNull(dr.Item("PercDisc")) Then
                    dr.Item("PercDisc") = 0.0
                End If

                If dr.Item("PercDisc") > 100 Then
                    MessageBox.Show("จำนวนส่วนลดเกิน 100% ไม่ได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    dr.Item("PercDisc") = 0.0
                    dr.Item("PriceSale") = 0.0
                End If

                dr.Item("PercDisc") = Format(CDbl(dr.Item("PercDisc")), "#,##0.00")
                If dr.Item("PercDisc") <> 0.0 Then
                    dr.Item("BathDisc") = 0.0
                End If
                'chkUnit()
                SumcolAmountExpNewGrid()
            End If

            'Discount Bath
            If e.Column.Name = ColBathDiscount.Name Then
                'If IsDBNull(dr.Item("idLot")) Or IsDBNull(dr.Item("idInvMain")) Then
                '    MessageBox.Show("กรุณา ระบุ ชื่อสินค้า หรือ Lot No.", sSystemName)

                '    Exit Sub
                'End If

                If IsDBNull(dr.Item("PriceSale")) Then
                    dr.Item("PriceSale") = 0.0
                End If

                If IsDBNull(dr.Item("BathDisc")) Then
                    dr.Item("BathDisc") = 0.0
                End If

                If dr.Item("BathDisc") > dr.Item("PriceNormal") Then
                    MessageBox.Show("จำนวนส่วนลดมากกว่าราคาปกติไม่ได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    dr.Item("BathDisc") = 0.0
                    dr.Item("PriceSale") = 0.0
                End If

                dr.Item("BathDisc") = Format(CDbl(dr.Item("BathDisc")), "#,##0.00")
                If dr.Item("BathDisc") <> 0.0 Then
                    dr.Item("PercDisc") = 0.0
                End If

                SumcolAmountExpNewGrid()
            End If

            dr.Item("stEdit") = 1

        End If
    End Sub

    Private Sub DGVBind_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGVBind.KeyPress

        Dim navigator As ControlNavigator = GCSale.EmbeddedNavigator
        If DGVBind.FocusedRowHandle >= 0 Then
            Dim view As GridView = CType(sender, GridView)

            If view.FocusedColumn.FieldName = "PriceSale" Or view.FocusedColumn.FieldName = "PriceNormal" Or view.FocusedColumn.FieldName = "PercDisc" _
                Or view.FocusedColumn.FieldName = "BathDisc" Or view.FocusedColumn.FieldName = "AmtSale" Then
                If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            End If
        Else
            If stCut = 1 Then
                navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
                navigator.Buttons.DoClick(navigator.Buttons.Remove)
                Exit Sub
            Else
                navigator.Buttons.DoClick(navigator.Buttons.Remove)
                Exit Sub
            End If
        End If

    End Sub

    Private Sub rptDel_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptDel.ButtonClick
        If DGVBind.FocusedRowHandle >= 0 Then
            If lbrMsg.MsgQuestion("คุณต้องการลบรายการใช่หรือไม่?") = True Then
                Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)
                Dim drtemp As DataRow = dtDel.NewRow()
                drtemp("idInvMain") = dr("idInvMain")
                drtemp("idLot") = dr("idLot")
                drtemp("idWh") = dr("idWh")
                drtemp("idSaleDt") = dr("idSaleDt")
                drtemp("AmtSale") = dr("AmtSale")
                drtemp("LotNo") = dr("LotNo")
                drtemp("idUnit") = dr("idUnit")
                drtemp("idInvGroup") = dr("idInvGroup")
                drtemp("stCutStock") = dr("stCutStock")
                drtemp("idSaleOrderDt") = dr("idSaleOrderDt")

                dtDel.Rows.Add(drtemp)

                dr.Delete()

                MainReturn.AcceptChanges()
                SumTotalNew()
            End If
        End If

    End Sub

    Private Sub rptDel_KeyDown(sender As Object, e As KeyEventArgs) Handles rptDel.KeyDown
        If DGVBind.FocusedRowHandle >= 0 And e.KeyCode = Keys.Enter Then
            If lbrMsg.MsgQuestion("คุณต้องการลบรายการใช่หรือไม่?") = True Then
                Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)
                Dim drtemp As DataRow = dtDel.NewRow()
                drtemp("idInvMain") = dr("idInvMain")
                drtemp("idLot") = dr("idLot")
                drtemp("idWh") = dr("idWh")
                drtemp("idSaleDt") = dr("idSaleDt")
                drtemp("AmtSale") = dr("AmtSale")
                drtemp("LotNo") = dr("LotNo")
                drtemp("stCutStock") = dr("stCutStock")
                dtDel.Rows.Add(drtemp)

                dr.Delete()

                MainReturn.AcceptChanges()
                SumTotalNew()
            End If
        End If
    End Sub

    Private Sub DGVBind_ShownEditor(sender As Object, e As EventArgs) Handles DGVBind.ShownEditor
        If DGVBind.FocusedRowHandle >= 0 Then
            Dim view As ColumnView = DirectCast(sender, ColumnView)
            If view.FocusedColumn.FieldName = "idUnit" Then
                Dim editor As LookUpEdit = CType(view.ActiveEditor, LookUpEdit)
                Dim idUnit As Integer = view.GetFocusedRowCellValue("idUnit")
                Dim idInvMain As Integer = view.GetFocusedRowCellValue("idInvMain")
                Dim dt As DataTable = getDataLookup(idUnit, idInvMain)
                editor.Properties.DataSource = dt
                rptUnit.DropDownRows = dt.Rows.Count
            End If
        End If
    End Sub

    Private Function getDataLookup(ByVal idUnit As Integer, ByVal idInvMain As Integer) As DataTable

        Dim dtS As DataTable = _dt.Clone
        Dim drs() As DataRow
        Dim StrUnit As String = ""
        mdCnOpen()
        Dim temp_ As New DataTable
        sCommand.CommandText = "SELECT idUnit, idInvGroup FROM dInventoryMain WHERE idInvMain = " & idInvMain
        sAdapter.Fill(temp_)
        mdLoadCommitt()
        Dim idInvGroup As Integer = temp_.Rows(0).Item("idInvGroup")

        If idInvGroup = 1 Then

            If temp_.Rows(0).Item("idUnit") = 2 Then
                drs = _dt.Select("idUnit IN (1,2) ")
            Else
                drs = _dt.Select("idUnit IN (" & temp_.Rows(0).Item("idUnit") & ")")
            End If

        Else

            Dim idUnitSub As New DataTable
            sCommand.CommandText = "SELECT idUnit, idSubUnit FROM dInvUnitSub WHERE idInvMain = " & idInvMain
            sAdapter.Fill(idUnitSub)

            If idUnitSub.Rows.Count > 0 Then
                If idUnit = idUnitSub.Rows(0).Item("idSubUnit") Then
                    StrUnit &= idUnitSub.Rows(0).Item("idSubUnit").ToString + ","

                    For i As Integer = 0 To idUnitSub.Rows.Count - 1
                        'Dim dr As DataRow = dr.Item("idUnit").Rows(i)
                        StrUnit &= idUnitSub.Rows(i).Item("idUnit").ToString
                        StrUnit &= ","
                    Next

                Else

                    StrUnit &= idUnit.ToString + ","

                    ' If idUnitSub.Rows.Count > 0 Then
                    For i As Integer = 0 To idUnitSub.Rows.Count - 1
                        'Dim dr As DataRow = dr.Item("idSubUnit").Rows(i)
                        StrUnit &= idUnitSub.Rows(i).Item("idSubUnit").ToString
                        StrUnit &= ","

                    Next
                    'End If

                End If
                drs = _dt.Select("idUnit in(" & StrUnit & ")")
            Else
                drs = _dt.Select("idUnit = " & idUnit)
            End If
        End If


        For Each dr As DataRow In drs
            dtS.ImportRow(dr)
        Next

        Return dtS


    End Function

    Private Sub gcNote_EditorKeyUp(sender As Object, e As KeyEventArgs) Handles gcNote.EditorKeyUp
        If e.KeyCode = Keys.F5 Then
            'AndAlso gvNote.SelectedRowsCount > 0 Then
            Dim vFrm As New frmNoteSelect(frmNoteSelect.eProcess.eSelect, cmbGroupComp.SelectedValue)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If gvNote.FocusedRowHandle >= 0 Then
                    Dim drNew As DataRow = dt_Note.Rows(gvNote.FocusedRowHandle)
                    drNew("Note") = vFrm.Note
                    gvNote.RefreshData()
                    e.Handled = True
                Else
                    dt_Note.Rows.Add(vFrm.Note)
                    gvNote.RefreshData()
                    e.Handled = True

                End If
            End If
        End If

        If e.KeyCode = Keys.Enter AndAlso gvNote.FocusedRowHandle > 0 Then
            gvNote.FocusedRowHandle = gvNote.FocusedRowHandle + 1
        End If

    End Sub

    Private Sub gvNote_KeyUp(sender As Object, e As KeyEventArgs) Handles gvNote.KeyUp

        If e.KeyCode = Keys.F5 Then
            'AndAlso gvNote.SelectedRowsCount > 0 Then
            Dim vFrm As New frmNoteSelect(frmNoteSelect.eProcess.eSelect, cmbGroupComp.SelectedValue)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If gvNote.FocusedRowHandle >= 0 Then
                    Dim drNew As DataRow = dt_Note.Rows(gvNote.FocusedRowHandle)
                    drNew("Note") = vFrm.Note
                    gvNote.RefreshData()
                    e.Handled = True
                Else
                    dt_Note.Rows.Add(vFrm.Note)
                    gvNote.RefreshData()
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub gcNote_EditorKeyPress(sender As Object, e As KeyPressEventArgs) Handles gcNote.EditorKeyPress
        If e.KeyChar = "F5" Then
            'AndAlso gvNote.SelectedRowsCount > 0 Then
            Dim vFrm As New frmNoteSelect(frmNoteSelect.eProcess.eSelect, cmbGroupComp.SelectedValue)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If gvNote.FocusedRowHandle >= 0 Then
                    Dim drNew As DataRow = dt_Note.Rows(gvNote.FocusedRowHandle)
                    drNew("Note") = vFrm.Note
                    gvNote.RefreshData()
                    e.Handled = True
                Else
                    dt_Note.Rows.Add(vFrm.Note)
                    gvNote.RefreshData()
                    e.Handled = True
                    'Console.WriteLine(gvNote.FocusedRowHandle)
                End If
            End If
        End If
    End Sub

    Private Sub GridControl_EditorKeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles GCSale.EditorKeyPress
        Dim grid As GridControl = CType(sender, GridControl)
        DGVBind_KeyPress(grid.FocusedView, e)
    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            idPartner = 0
            lblPsCus.Text = ""
            lblCusNote.Text = ""
            lblPsSale.Text = ""
            lblCusRec.Text = ""
            lblAddr.Text = ""

            cmbDRefCode()
            CmbTs.SelectedValue = 0
            lblTspComp.Text = ""
            cmbTypePayTrp.SelectedValue = 0
            MainReturn.Clear()
        End If
    End Sub

    Private Sub lblPsCus_TextChanged(sender As Object, e As EventArgs) Handles lblPsCus.TextChanged
        If stLoad = 1 And Trim(lblPsCus.Text) <> "" Then
            '--- Set PsSale ---'
            Dim dtRegion As New DataTable
            PsCustomer = Me.lblPsCus.Text
            idPsCus = Me.lblPsCus.Tag

            cmbBillSaleCont.Enabled = True
            txtBillSaleCont.Enabled = True

            btnSale.Enabled = True

            sCommand.CommandText = "SELECT c.idPsSale, p.PsName As PsSaleName, ps.idPM" & vbNewLine &
                                    "FROM SmRegionPsSaleComp c " & vbNewLine &
                                    "LEFT JOIN  SmMkCusPs ps ON  c.idRegionC = ps.idRegionC AND ps.idComp = c.idComp" & vbNewLine &
                                    "LEFT JOIN vPersonxSelect p ON c.idPsSale = p.idPs" & vbNewLine &
                                    "WHERE ps.idCus = " & lblPsCus.Tag & "" & vbNewLine &
                                    "AND ps.idComp = " & cmbGroupComp.SelectedValue
            sAdapter.Fill(dtRegion)

            If dtRegion.Rows.Count <> 0 Then

                Me.lblPsSale.Text = dtRegion.Rows(0).Item("PsSaleName")
                Me.lblPsSale.Tag = dtRegion.Rows(0).Item("idPsSale")
                Me.cmbTp.SelectedValue = dtRegion.Rows(0).Item("idPM")
                'End If

            Else 'ไม่มีเขตการขายของลูกค้านี้

                Dim Dt2 As New DataTable
                Dt2.Clear()
                sCommand.CommandText = "SELECT p.idPs As idPsSale, p.PsName As PsSale " & vbNewLine &
                                       "FROM SmSaleMt mt" & vbNewLine &
                                       "LEFT JOIN vPersonxSelect p ON mt.idPsSale = p.idPs" & vbNewLine &
                                       "Where mt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                       "AND mt.idPartner = " & idPartner & vbNewLine &
                                       "ORDER By idSale DESC"
                sAdapter.Fill(Dt2)
                If Dt2.Rows.Count <> 0 Then
                    MessageBox.Show("ลูกค้าคนนี้ไม่มีข้อมูลผูกกับพนักงานขาย ระบบจะดึงพนักงานขายที่มีประวัติการขายกับลูกค้าครั้งล่าสุด", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.lblPsSale.Text = Dt2.Rows(0).Item("PsSale")
                    Me.lblPsSale.Tag = Dt2.Rows(0).Item("idPsSale")
                Else
                    MessageBox.Show("ลูกค้าคนนี้ไม่มีข้อมูลผูกกับพนักงานขาย และไม่มีประวัติการขายสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        End If
    End Sub

    Private Sub rptProductName_Click(sender As Object, e As EventArgs) Handles rptProductName.Click
        If idPartner = 0 Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการเลือกสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim navigator As ControlNavigator = GCSale.EmbeddedNavigator
        If DGVBind.FocusedRowHandle >= 0 Then
            navigator.Buttons.DoClick(navigator.Buttons.Edit)
        Else
            'ถ้า เป็น NewItemRow
            navigator.Buttons.DoClick(navigator.Buttons.Append)
            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
        End If

        fnSetLotNoByFrm()

        If IsDBNull(DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain")) Then
            navigator.Buttons.DoClick(navigator.Buttons.Remove)
            Exit Sub
        End If
    End Sub

    Private Sub rptProductName_KeyDown(sender As Object, e As KeyEventArgs) Handles rptProductName.KeyDown

        If idPartner = 0 Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการเลือกสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim navigator As ControlNavigator = GCSale.EmbeddedNavigator
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F5 Then

            If DGVBind.FocusedRowHandle >= 0 Then
                navigator.Buttons.DoClick(navigator.Buttons.Edit)
            Else
                'ถ้า เป็น NewItemRow
                navigator.Buttons.DoClick(navigator.Buttons.Append)
                navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
            End If

            fnSetLotNoByFrm()

            If IsDBNull(DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain")) Then
                navigator.Buttons.DoClick(navigator.Buttons.Remove)
                Exit Sub
            End If
        End If

    End Sub

    Private Sub rptLotNo_Click(sender As Object, e As EventArgs)
        Dim navigator As ControlNavigator = GCSale.EmbeddedNavigator
        If DGVBind.FocusedRowHandle >= 0 Then
            navigator.Buttons.DoClick(navigator.Buttons.Edit)
        Else
            navigator.Buttons.DoClick(navigator.Buttons.Append)
            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
        End If

        If IsDBNull(DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain")) Then
            navigator.Buttons.DoClick(navigator.Buttons.Remove)
            MessageBox.Show("กรุณาระบุรายการสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            'Dim vFrm As New frmLotSelect(frmLotSelect.eProcess.eSelect, cmbGroupComp.SelectedValue, cmbGroupComp.Text, _
            '                             DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain"), DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "ProductName"))
            Dim vFrm As New frmLotSelect(frmLotSelect.eProcess.eSelectxLot, cmbGroupComp.SelectedValue, cmbGroupComp.Text,
                                        DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "LotNo"), 0, "")
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If vFrm.dtLotReturn.Rows.Count > 0 Then
                    fnSetDataLotNo(vFrm.dtLotReturn)
                Else
                    navigator.Buttons.DoClick(navigator.Buttons.Remove)
                End If
            End If
        End If
    End Sub

    Private Sub rptLotNo_KeyDown(sender As Object, e As KeyEventArgs)
        Dim navigator As ControlNavigator = GCSale.EmbeddedNavigator
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F5 Then

            If DGVBind.FocusedRowHandle >= 0 Then
                navigator.Buttons.DoClick(navigator.Buttons.Edit)
            Else
                navigator.Buttons.DoClick(navigator.Buttons.Append)
                navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
            End If

            If IsDBNull(DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain")) Then

                navigator.Buttons.DoClick(navigator.Buttons.Remove)
                MessageBox.Show("กรุณาระบุรายการสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                Dim vFrm As New frmLotSelect(frmLotSelect.eProcess.eSelectxLot, cmbGroupComp.SelectedValue, cmbGroupComp.Text,
                                             DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "LotNo"), 0, "")

                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

                    If vFrm.dtLotReturn.Rows.Count > 0 Then
                        fnSetDataLotNo(vFrm.dtLotReturn)
                    Else
                        navigator.Buttons.DoClick(navigator.Buttons.Remove)
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub fnSetLotNoByFrm()
        Dim vFrm As New frmAllInvSelect(frmAllInvSelect.eProcess.eAll, cmbGroupComp.SelectedValue)
        'vFrm.GetInvName(DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "ProductName"))

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

            If vFrm.sdt1.Rows(0).Item("idInvGroup") = 30 Then
                DGVBind.SetFocusedRowCellValue("PdCode", "")
                DGVBind.SetFocusedRowCellValue("idInvMain", vFrm.sdt1.Rows(0).Item("idInvMain"))
                DGVBind.SetFocusedRowCellValue("idLot", 0)
                DGVBind.SetFocusedRowCellValue("ProductName", vFrm.sdt1.Rows(0).Item("InvName"))
                DGVBind.SetFocusedRowCellValue("idRefLot", 0)

                DGVBind.SetFocusedRowCellValue("LotNo", "")
                DGVBind.SetFocusedRowCellValue("AmtStock", 1) 'จน.คงเหลือใน Stock
                DGVBind.SetFocusedRowCellValue("PriceNormal", 0) 'ราคาปกติ
                DGVBind.SetFocusedRowCellValue("PercDisc", 0) 'ส่วนลด %
                DGVBind.SetFocusedRowCellValue("BathDisc", 0) 'ส่วนลด (บาท)
                DGVBind.SetFocusedRowCellValue("PriceSale", 0) 'ราคาขาย
                DGVBind.SetFocusedRowCellValue("Total", 0) 'รวมเป็นเงิน
                DGVBind.SetFocusedRowCellValue("AmtOrder", 0) 'จน.สั่งซื้อ
                DGVBind.SetFocusedRowCellValue("CompRec", cmbGroupComp.SelectedValue)
                DGVBind.SetFocusedRowCellValue("chk", False)
                DGVBind.SetFocusedRowCellValue("idLotSPM", 0)
                DGVBind.SetFocusedRowCellValue("idWh", 0)
                DGVBind.SetFocusedRowCellValue("idInvGroup", vFrm.sdt1.Rows(0).Item("idInvGroup"))
                DGVBind.SetFocusedRowCellValue("DtType", vFrm.sdt1.Rows(0).Item("DtType"))
                DGVBind.SetFocusedRowCellValue("idSubType", vFrm.sdt1.Rows(0).Item("idSubType"))
                DGVBind.SetFocusedRowCellValue("idSaleDt", 0)

                DGVBind.SetFocusedRowCellValue("UnitName", vFrm.sdt1.Rows(0).Item("UnitName"))
                DGVBind.SetFocusedRowCellValue("idUnit", vFrm.sdt1.Rows(0).Item("idUnit"))
                DGVBind.SetFocusedRowCellValue("AmtSale", 1)  'จำนวนขาย 
                DGVBind.SetFocusedRowCellValue("pWeight", 0)
                DGVBind.SetFocusedRowCellValue("idUnitW", 0)
                DGVBind.RefreshData()

            Else

                If IsDBNull(DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idSaleDt")) Then
                    DGVBind.SetFocusedRowCellValue("idSaleDt", 0)
                End If

                DGVBind.SetFocusedRowCellValue("PdCode", vFrm.sdt1.Rows(0).Item("InvCode"))
                DGVBind.SetFocusedRowCellValue("idInvMain", vFrm.sdt1.Rows(0).Item("idInvMain"))
                DGVBind.SetFocusedRowCellValue("ProductName", vFrm.sdt1.Rows(0).Item("InvName"))
                DGVBind.SetFocusedRowCellValue("idInvGroup", vFrm.sdt1.Rows(0).Item("idInvGroup"))
                DGVBind.SetFocusedRowCellValue("idRefLot", 0)


                fnSetPriceNormal(vFrm.sdt1)
                DGVBind.SetFocusedRowCellValue("UnitName", vFrm.sdt1.Rows(0).Item("UnitName"))

                fnSetDefualtLotFIFO(vFrm.sdt1.Rows(0).Item("idInvMain"))

                DGVBind.SetFocusedRowCellValue("AmtOrder", 0) 'จน.สั่งซื้อ
                DGVBind.SetFocusedRowCellValue("PercDisc", 0) 'ส่วนลด %
                DGVBind.SetFocusedRowCellValue("BathDisc", 0) 'ส่วนลด (บาท)
                DGVBind.SetFocusedRowCellValue("AmtSaleHide", 0)
                DGVBind.SetFocusedRowCellValue("idSaleOrderDt", 0)
                DGVBind.SetFocusedRowCellValue("CodeOrder", "")


                DGVBind.SetFocusedRowCellValue("OldStock", 0)
                DGVBind.SetFocusedRowCellValue("OldAmt", 0)
                DGVBind.SetFocusedRowCellValue("CompRec", cmbGroupComp.SelectedValue)
                DGVBind.SetFocusedRowCellValue("chk", False)
                DGVBind.SetFocusedRowCellValue("idLotSPM", 0)

                DGVBind.SetFocusedRowCellValue("DtType", vFrm.sdt1.Rows(0).Item("DtType"))
                DGVBind.SetFocusedRowCellValue("idSubType", vFrm.sdt1.Rows(0).Item("idSubType"))


                DGVBind.SetFocusedRowCellValue("idUnit", vFrm.sdt1.Rows(0).Item("idUnit"))

                DGVBind.RefreshData()
            End If
        End If
    End Sub

    Private Sub fnSetPriceNormal(ByVal dt As DataTable)
        Dim dtLastPrice As New DataTable
        Dim gLastPrice As Double = 0.0

        Dim PriceNormal As Double = 0
        Dim LastPrice As Double = 0

        sCommand.CommandText = "SELECT Top(1) ISNULL(dt.Price,0) As LastPrice " & vbNewLine &
                                "FROM SmSaleDtAll dt " & vbNewLine &
                                "LEFT OUTER JOIN SmSaleMt mt ON dt.idsale = mt.idSale " & vbNewLine &
                                "WHERE mt.idPartner = " & idPartner & vbNewLine &
                                "AND dt.idProduct =  " & DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain") & vbNewLine &
                                "AND mt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                "AND dt.Price > 0 " & vbNewLine &
                                "Order by mt.DateSale DESC "
        sAdapter.Fill(dtLastPrice)

        If dtLastPrice.Rows.Count <> 0 Then
            gLastPrice = dtLastPrice.Rows(0).Item("LastPrice")
        End If

        Select Case dt.Rows(0).Item("idInvGroup")
            Case 1 'สินค้าวัตถุดิบ
                PriceNormal = dt.Rows(0).Item("PriceSeed")

                If gLastPrice <> 0 Then
                    LastPrice = gLastPrice
                Else
                    LastPrice = dt.Rows(0).Item("PriceSeed")
                End If

            Case 2 'สินค้าสำเร็จรูป FG
                If Me.rdbWhole.Checked = True Then
                    PriceNormal = dt.Rows(0).Item("PriceWholesale_fg")
                ElseIf Me.rdbRetail.Checked = True Then
                    PriceNormal = dt.Rows(0).Item("PriceRetail_fg")
                ElseIf Me.rdbBill.Checked = True Then
                    PriceNormal = dt.Rows(0).Item("PriceBill_fg")
                End If

            Case 29 'สินค้าพลาสติก
                If Me.cmbTp.SelectedValue = 49 Then  ' credit 30
                    PriceNormal = dt.Rows(0).Item("CreditThirty_pdo")
                    If gLastPrice <> 0 Then
                        LastPrice = gLastPrice
                    Else
                        LastPrice = dt.Rows(0).Item("CreditThirty_pdo")
                    End If

                ElseIf Me.cmbTp.SelectedValue = 50 Then  ' credit 60
                    PriceNormal = dt.Rows(0).Item("CreditSixty_pdo")
                    If gLastPrice <> 0 Then
                        LastPrice = gLastPrice
                    Else
                        LastPrice = dt.Rows(0).Item("CreditSixty_pdo")
                    End If

                Else  ' Other
                    PriceNormal = dt.Rows(0).Item("PricePdo_pdo")
                    If gLastPrice <> 0 Then
                        LastPrice = gLastPrice
                    Else
                        LastPrice = dt.Rows(0).Item("PricePdo_pdo")
                    End If
                End If

            Case 42 ' สินค้าเมล็ดพันธุ์สำเร็จรูป FG (หน่วย ซอง)
                PriceNormal = dt.Rows(0).Item("PriceSeedFg_sfg")

            Case Else ' Other Type except FG (idInvGroup = 2)

                PriceNormal = dt.Rows(0).Item("PricePdo_pdo")

                If gLastPrice <> 0 Then
                    LastPrice = gLastPrice
                Else
                    LastPrice = dt.Rows(0).Item("PricePdo_pdo")
                End If
        End Select

        If PriceNormal <> 0 Then
            LastPrice = PriceNormal
        Else
            LastPrice = gLastPrice
            PriceNormal = gLastPrice
        End If


        DGVBind.SetFocusedRowCellValue("PriceNormal", PriceNormal)
        DGVBind.SetFocusedRowCellValue("PriceSale", LastPrice)
        DGVBind.SetFocusedRowCellValue("Total", LastPrice)
    End Sub

    Private Sub fnSetDefualtLotFIFO(ByVal idInvMain As Integer)
        mdCnOpen()

        Dim dtLot As New DataTable
        Dim strComp As String = ""
        Dim strQidLot As String = ""
        If cmbGroupComp.SelectedValue = 4 Or cmbGroupComp.SelectedValue = 10 Then
            strComp = "AND lm.CompRec IN (4,10)"
        Else
            strComp = "AND lm.CompRec = " & cmbGroupComp.SelectedValue
        End If

        If Trim(stridLot) <> "" Then
            strQidLot = " AND ref.idRefLot Not IN (" & stridLot & ")"
        End If

        sCommand.CommandText = "SELECT ref.idRefLot, lm.idLot, inv.idInvMain, ref.idWh, inv.idUnit, inv.InvName, " & vbNewLine &
                               "d.ShortName, inv.idInvGroup, lm.LotNo, unit.idUnit, g.InvGroupName, d.Weight, d.idUnitW, sfg.WPerPack, " & vbNewLine &
                               "unit.UnitName, inv.idSubType, g.DtType, ISNULL(lm.idLotSPM,0) As idLotSPM," & vbNewLine &
                               "(ref.Amount - (SELECT ISNULL(SUM(AmountWaitChange),0) " & vbNewLine &
                                                "FROM WimWaitCutDt wDt " & vbNewLine &
                                                "LEFT JOIN WimWaitCutMt wMt ON wDt.idWaitCutMt = wMt.idWaitCutMt" & vbNewLine &
                                                "WHERE wDt.idLot = lm.idLot" & vbNewLine &
                                                "AND ref.idWh = wDt.idWh" & vbNewLine &
                                                "AND wDt.stWait Is NULL" & vbNewLine &
                                                "AND wMt.stCancel Is NULL" & vbNewLine &
                                                "AND wDt.stDel Is NULL)) As AmtStock," & vbNewLine &
                               "swh.full_lock + CASE WHEN ISNULL(ref.idBox,0) <> 0 THEN '>' + pn.PartnerName ELSE '' END As full_lock" & vbNewLine &
                               "FROM dInvLotRefWh As ref" & vbNewLine &
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
                               "AND inv.stNotSale Is NULL" & vbNewLine &
                               "AND (ref.Amount - (SELECT ISNULL(SUM(AmountWaitChange),0) " & vbNewLine &
                                                "FROM WimWaitCutDt wDt " & vbNewLine &
                                                "LEFT JOIN WimWaitCutMt wMt ON wDt.idWaitCutMt = wMt.idWaitCutMt" & vbNewLine &
                                                "WHERE wDt.idLot = lm.idLot" & vbNewLine &
                                                "AND ref.idWh = wDt.idWh" & vbNewLine &
                                                "AND wDt.stWait Is NULL" & vbNewLine &
                                                "AND wMt.stCancel Is NULL" & vbNewLine &
                                                "AND wDt.stDel Is NULL)) > 0" & vbNewLine &
                               "AND lm.idInvMain = " & idInvMain & vbNewLine &
                               "AND devsk.fncChkLotCount(lm.idLot) = 0" & vbNewLine &
                                strQidLot & vbNewLine &
                                strComp & vbNewLine & " Order By lm.DateGen"

        sAdapter.Fill(dtLot)

        If dtLot.Rows.Count > 0 Then
            Dim defaultAmtSale As Double = 0.0
            If dtLot.Rows(0).Item("AmtStock") >= 1 And cmbGroupComp.SelectedValue <> 2 Then
                defaultAmtSale = 1
            Else
                defaultAmtSale = dtLot.Rows(0).Item("AmtStock")
            End If

            Dim SumStockinBill As Double = 0.0

            For j As Integer = 0 To DGVBind.DataRowCount - 1
                If Not IsDBNull(DGVBind.GetDataRow(j).Item("idLot")) Then
                    If (DGVBind.GetDataRow(j).Item("idLot") = dtLot.Rows(0).Item("idLot")) And
                        (DGVBind.GetDataRow(j).Item("idWh") = dtLot.Rows(0).Item("idWh")) Then

                        Dim CalAmt As Double = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(j).Item("idUnit"), DGVBind.GetDataRow(j).Item("idInvGroup"),
                                               CDbl(DGVBind.GetDataRow(j).Item("OldAmt")), DGVBind.GetDataRow(j).Item("idInvMain"))


                        SumStockinBill = SumStockinBill + CalAmt
                    End If
                End If

            Next

            Dim pWeight As Double = 0
            Dim idUnitW As Integer = 0

            If dtLot.Rows(0).Item("idInvGroup") = 2 Then
                pWeight = dtLot.Rows(0).Item("Weight")
                idUnitW = dtLot.Rows(0).Item("idUnitW")
            ElseIf dtLot.Rows(0).Item("idInvGroup") = 42 Then
                pWeight = dtLot.Rows(0).Item("WPerPack")
                idUnitW = 1
            End If


            DGVBind.SetFocusedRowCellValue("idLot", dtLot.Rows(0).Item("idLot"))
            DGVBind.SetFocusedRowCellValue("LotNo", dtLot.Rows(0).Item("LotNo"))
            DGVBind.SetFocusedRowCellValue("AmtStock", dtLot.Rows(0).Item("AmtStock") + SumStockinBill) 'จน.คงเหลือใน Stock
            DGVBind.SetFocusedRowCellValue("idWh", dtLot.Rows(0).Item("idWh"))

            DGVBind.SetFocusedRowCellValue("idUnit", dtLot.Rows(0).Item("idUnit"))
            DGVBind.SetFocusedRowCellValue("AmtSale", defaultAmtSale)
            DGVBind.SetFocusedRowCellValue("idLotSPM", dtLot.Rows(0).Item("idLotSPM"))
            DGVBind.SetFocusedRowCellValue("idRefLot", dtLot.Rows(0).Item("idRefLot"))
            DGVBind.SetFocusedRowCellValue("pWeight", pWeight)
            DGVBind.SetFocusedRowCellValue("idUnitW", idUnitW)
            DGVBind.SetFocusedRowCellValue("full_lock", dtLot.Rows(0).Item("full_lock"))
        Else
            DGVBind.SetFocusedRowCellValue("idLot", 0)
            DGVBind.SetFocusedRowCellValue("LotNo", "")
            DGVBind.SetFocusedRowCellValue("AmtStock", 0) 'จน.คงเหลือใน Stock
            DGVBind.SetFocusedRowCellValue("idWh", 0)
            DGVBind.SetFocusedRowCellValue("AmtSale", 0)
            DGVBind.SetFocusedRowCellValue("idLotSPM", 0)
        End If

    End Sub

    Private Sub fnSetDataLotNo(ByVal dtLotReturn As DataTable)


        'check stock : หัก stock ของ rows ก่อนหน้า
        Dim SumStockinBill As Double = 0.0

        For j As Integer = 0 To DGVBind.DataRowCount - 1
            If (DGVBind.GetDataRow(j).Item("idLot") = dtLotReturn.Rows(0).Item("idLot")) And
                (DGVBind.GetDataRow(j).Item("idWh") = dtLotReturn.Rows(0).Item("idWh")) Then

                Dim CalAmt As Double = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(j).Item("idUnit"), DGVBind.GetDataRow(j).Item("idInvGroup"),
                                                         CDbl(DGVBind.GetDataRow(j).Item("OldAmt")), DGVBind.GetDataRow(j).Item("idInvMain"))

                SumStockinBill = SumStockinBill + CalAmt
            End If
        Next

        For j As Integer = 0 To tempDelete.Rows.Count - 1 ' รายการที่ลบ : ไม่แสดงใน gridview
            If (tempDelete.Rows(j).Item("idLot") = dtLotReturn.Rows(0).Item("idLot")) And
                (tempDelete.Rows(j).Item("idWh") = dtLotReturn.Rows(0).Item("idWh")) Then
                SumStockinBill = SumStockinBill + tempDelete.Rows(j).Item("AmtDel")
            End If
        Next

        DGVBind.SetFocusedRowCellValue("LotNo", dtLotReturn.Rows(0).Item("LotNo"))
        DGVBind.SetFocusedRowCellValue("idLot", dtLotReturn.Rows(0).Item("idLot"))
        DGVBind.SetFocusedRowCellValue("idWh", dtLotReturn.Rows(0).Item("idWh"))
        DGVBind.SetFocusedRowCellValue("AmtStock", dtLotReturn.Rows(0).Item("AmtStock"))
        DGVBind.SetFocusedRowCellValue("idLotSPM", dtLotReturn.Rows(0).Item("idLotSPM"))
        DGVBind.SetFocusedRowCellValue("idSubType", dtLotReturn.Rows(0).Item("idSubType"))
        DGVBind.SetFocusedRowCellValue("pWeight", dtLotReturn.Rows(0).Item("pWeight"))
        DGVBind.SetFocusedRowCellValue("idUnitW", dtLotReturn.Rows(0).Item("idUnitW"))
        DGVBind.SetFocusedRowCellValue("full_lock", dtLotReturn.Rows(0).Item("full_lock"))

        If DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idInvGroup") <> 30 Then
            DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtStock") = DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtStock") + SumStockinBill

        ElseIf DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idInvGroup") = 30 Then
            'ถ้าเป็น idInvGroup = 30 ให้ Stock = 0
            DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtStock") = 0
        End If

        SendKeys.SendWait("{Right}")
    End Sub

    Private Sub rptPdCode_KeyDown(sender As Object, e As KeyEventArgs) Handles rptPdCode.KeyDown
        If e.KeyCode = Keys.Back Then
            Exit Sub
        End If

        Dim navigator As ControlNavigator = GCSale.EmbeddedNavigator
        If idPartner = 0 Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SendKeys.SendWait("{BACKSPACE}")
            navigator.Buttons.DoClick(navigator.Buttons.Remove)
            Exit Sub
        End If


        Dim PdCode_Temp As String = ""
        If e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Enter Then
            mdCnOpen()


            'navigator.Buttons.DoClick(navigator.Buttons.Append)
            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)

            If DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "PdCode") = "" Then
                MessageBox.Show("กรุณาระบุรหัสสินค้า เพื่อค้นหาข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            PdCode_Temp = DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "PdCode")
            Dim vFrm As New frmInvCodeSelect(frmInvCodeSelect.eProcess.eSelect, DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "PdCode"))

            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

                If vFrm.dtInvCode.Rows.Count > 0 And DGVBind.DataRowCount > 0 Then
                    DGVBind.SetFocusedRowCellValue("PdCode", vFrm.dtInvCode.Rows(0).Item("InvCode"))
                    DGVBind.SetFocusedRowCellValue("idInvMain", vFrm.dtInvCode.Rows(0).Item("idInvMain"))
                    DGVBind.SetFocusedRowCellValue("idLot", 0)
                    DGVBind.SetFocusedRowCellValue("ProductName", vFrm.dtInvCode.Rows(0).Item("InvName"))
                    DGVBind.SetFocusedRowCellValue("LotNo", "")
                    DGVBind.SetFocusedRowCellValue("AmtStock", 0) 'จน.คงเหลือใน Stock
                    DGVBind.SetFocusedRowCellValue("AmtOrder", 0) 'จน.สั่งซื้อ

                    fnSetPriceNormal(vFrm.dtInvCode) ' Set ราคาปกติ

                    DGVBind.SetFocusedRowCellValue("PercDisc", 0) 'ส่วนลด %
                    DGVBind.SetFocusedRowCellValue("BathDisc", 0) 'ส่วนลด (บาท)
                    'DGVBind.SetFocusedRowCellValue("PriceSale", 0) 'ราคาขาย
                    'DGVBind.SetFocusedRowCellValue("Total", 0) 'รวมเป็นเงิน
                    'DGVBind.SetFocusedRowCellValue("AmtSaleHide", 0)
                    DGVBind.SetFocusedRowCellValue("idSaleOrderDt", 0)
                    DGVBind.SetFocusedRowCellValue("idSaleDt", 0)
                    DGVBind.SetFocusedRowCellValue("OldStock", 0)
                    DGVBind.SetFocusedRowCellValue("OldAmt", 0)
                    DGVBind.SetFocusedRowCellValue("CompRec", cmbGroupComp.SelectedValue)
                    DGVBind.SetFocusedRowCellValue("chk", False)
                    DGVBind.SetFocusedRowCellValue("idLotSPM", 0)
                    DGVBind.SetFocusedRowCellValue("idWh", 0)
                    DGVBind.SetFocusedRowCellValue("idInvGroup", vFrm.dtInvCode.Rows(0).Item("idInvGroup"))
                    DGVBind.SetFocusedRowCellValue("DtType", vFrm.dtInvCode.Rows(0).Item("DtType"))
                    DGVBind.SetFocusedRowCellValue("idSubType", vFrm.dtInvCode.Rows(0).Item("idSubType"))


                    DGVBind.SetFocusedRowCellValue("UnitName", vFrm.dtInvCode.Rows(0).Item("UnitName"))
                    DGVBind.SetFocusedRowCellValue("idUnit", vFrm.dtInvCode.Rows(0).Item("idUnit"))
                    DGVBind.SetFocusedRowCellValue("AmtSale", 0)  'จำนวนขาย

                    fnSetDefualtLotFIFO(vFrm.dtInvCode.Rows(0).Item("idInvMain"))
                Else
                    navigator.Buttons.DoClick(navigator.Buttons.Remove)
                End If

            End If
        End If

    End Sub

    Private Sub rptUnit_Click(sender As Object, e As EventArgs) Handles rptUnit.Click
        If DGVBind.FocusedRowHandle < 0 Then
            rptUnit.ReadOnly = True
        Else
            rptUnit.ReadOnly = False
        End If
    End Sub

    Private Sub rptChx_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles rptChx.ButtonClick
        If DGVBind.FocusedRowHandle >= 0 And Not IsDBNull(DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain")) Then
            If DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idInvGroup") = 1 Then
                'ถ้าเป็นเมล็ดพันธุ์วัตถุดิบ ให้ DialogBox มาเพื่อถามว่าจะเปลี่ยนชื่อ ProductName ไหม
                Dim NewProductName As String = ""

                NewProductName = InputBox("ต้องการเปลี่ยนแปลงชื่อสินค้า หรือไม่", sSystemName, DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("ProductName"))

                If NewProductName.Length = 0 Then
                    MessageBox.Show("กรุณาระบุชื่อสินค้าให้ชัดเจน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    DGVBind.SetFocusedRowCellValue("ProductName", NewProductName)
                End If
            Else
                MessageBox.Show("สินค้าประเภทนี้ ไม่สามารถเปลี่ยนแปลงชื่อสินค้าได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub DGVBind_KeyDown(sender As Object, e As KeyEventArgs) Handles DGVBind.KeyDown
        Dim navigator As ControlNavigator = GCSale.EmbeddedNavigator
        If DGVBind.FocusedRowHandle < 0 And stCut = 1 Then
            If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Enter Then

                'MessageBox.Show("กรุณาเลือกสินค้า ก่อนทำรายการอื่นๆ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
                navigator.Buttons.DoClick(navigator.Buttons.Remove)
                Exit Sub
            End If
        Else
            If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Enter Then
                navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub rpttxtLotNo_KeyDown(sender As Object, e As KeyEventArgs) Handles rpttxtLotNo.KeyDown
        Dim navigator As ControlNavigator = GCSale.EmbeddedNavigator
        If e.KeyCode = Keys.Back Then
            Exit Sub
        End If

        If idPartner = 0 Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SendKeys.SendWait("{BACKSPACE}")
            navigator.Buttons.DoClick(navigator.Buttons.Remove)

            Exit Sub
        End If


        If e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Enter Then

            mdCnOpen()

            Dim LotNoNew As String = ""
            If eEvent = eProcess.eEditCombine And Not IsDBNull(DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idLot")) Then
                navigator.Buttons.DoClick(navigator.Buttons.EndEdit)

                If lbrMsg.MsgQuestion("คุณต้องการแทนที่รายการนี้ใช่หรือไม่?") = False Then
                    Exit Sub
                    'If DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idSaleDt") <> 0 Then
                    '    Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)
                    '    Dim dv As New DataView(MainReturn)
                    '    dv.RowFilter = "idSaleDt = " & dr("idSaleDt")

                    '    Dim drtemp As DataRow = dtDel.NewRow()
                    '    drtemp("idInvMain") = dv.Item(0).Item("idInvMainHide")
                    '    drtemp("idLot") = dv.Item(0).Item("idLot")
                    '    drtemp("idWh") = dv.Item(0).Item("idWh")
                    '    drtemp("full_lock") = dv.Item(0).Item("full_lock")

                    '    drtemp("idSaleDt") = dv.Item(0).Item("idSaleDt")
                    '    drtemp("AmtSale") = dv.Item(0).Item("AmtSale")
                    '    drtemp("LotNo") = dv.Item(0).Item("LotNoHide")
                    '    drtemp("stCutStock") = dv.Item(0).Item("stCutStock")
                    '    'DGVBind.SetFocusedRowCellValue("idRefLot", vFrm.dtLotReturn.Rows(0).Item("idRefLot"))
                    '    LotNoNew = dr.Item("LotNo")
                    '    dtDel.Rows.Add(drtemp)

                    '    dr.Delete()

                    '    MainReturn.AcceptChanges()
                    '    'SumTotalNew()
                    '    navigator.Buttons.DoClick(navigator.Buttons.Append)
                    '    navigator.Buttons.DoClick(navigator.Buttons.EndEdit)

                    '    DGVBind.SetFocusedRowCellValue("LotNo", LotNoNew)

                    'End If

                End If
            End If

            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)

            Dim eText As String = ""
            Dim sLotNo As String = ""
            Dim sidInvMain As Integer = 0
            Dim sInvName As String = ""

            If DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "LotNo") = "" And IsDBNull(DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain")) Then
                MessageBox.Show("กรุณาระบุ Lot No. เพื่อค้นหาข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If IsDBNull(DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain")) Then
                eText = frmLotSelect.eProcess.eSelectxLot
                sLotNo = DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "LotNo")
                sidInvMain = 0
                sInvName = ""

            Else
                eText = frmLotSelect.eProcess.eSelectxInv
                sLotNo = DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "LotNo")
                sidInvMain = DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain")
                sInvName = DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "ProductName")
            End If

            Dim vFrm As New frmLotSelect(eText, cmbGroupComp.SelectedValue, cmbGroupComp.Text, sLotNo, sidInvMain, sInvName)

            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

                If vFrm.dtLotReturn.Rows.Count > 0 And DGVBind.DataRowCount > 0 Then

                    If IsDBNull(DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idSaleDt")) Then
                        DGVBind.SetFocusedRowCellValue("idSaleDt", 0)
                    End If

                    DGVBind.SetFocusedRowCellValue("PdCode", vFrm.dtLotReturn.Rows(0).Item("InvCode"))
                    DGVBind.SetFocusedRowCellValue("idInvMain", vFrm.dtLotReturn.Rows(0).Item("idInvMain"))

                    DGVBind.SetFocusedRowCellValue("ProductName", vFrm.dtLotReturn.Rows(0).Item("InvName"))
                    DGVBind.SetFocusedRowCellValue("LotNo", vFrm.dtLotReturn.Rows(0).Item("LotNo"))
                    DGVBind.SetFocusedRowCellValue("idInvGroup", vFrm.dtLotReturn.Rows(0).Item("idInvGroup"))
                    DGVBind.SetFocusedRowCellValue("idLotSPM", vFrm.dtLotReturn.Rows(0).Item("idLotSPM"))
                    DGVBind.SetFocusedRowCellValue("idSubType", vFrm.dtLotReturn.Rows(0).Item("idSubType"))
                    DGVBind.SetFocusedRowCellValue("idRefLot", vFrm.dtLotReturn.Rows(0).Item("idRefLot"))

                    Dim dtSetPrice As New DataTable
                    dtSetPrice.Clear()

                    sCommand.CommandText = "SELECT CONVERT(bit,0) As ChkKey, gr.DtType, ic.InvCode, main.idInvMain, main.InvName, main.idInvGroup, gr.InvGroupName," & vbNewLine &
                                             "unit.UnitName, main.idUnit, main.idSubType, fg.ShortName, " & vbNewLine &
                                             "ISNULL(fg.PriceBill,0) As PriceBill_fg, ISNULL(fg.PriceWholesale,0) As PriceWholesale_fg, IsNULL(fg.PriceRetail,0) As PriceRetail_fg," & vbNewLine &
                                             "IsNULL(pdo.Price,0) As PricePdo_pdo, IsNULL(pdo.CreditThirty,0) As CreditThirty_pdo, IsNULL(pdo.CreditSixty,0) As CreditSixty_pdo , " & vbNewLine &
                                             "IsNULL(sfg.Price,0) As PriceSeedFg_sfg, ISNULL(d.Price,0) As PriceSeed ," & vbNewLine &
                                              "(SELECT ISNull(SUM(Amount), 0.0)" & vbNewLine &
                                                  "FROM dInvLotMain As d" & vbNewLine &
                                                  "LEFT JOIN dInvLotRefWh As w ON d.idLot = w.idLot" & vbNewLine &
                                                  "WHERE d.idInvMain = main.idInvMain AND stDel Is NULL AND d.CompRec = " & cmbGroupComp.SelectedValue & ") As amount" & vbNewLine &
                                              "FROM dInventoryMain As main" & vbNewLine &
                                              "LEFT JOIN dInvUnit As unit ON main.idUnit = unit.idUnit " & vbNewLine &
                                              "LEFT JOIN dInvGroup As gr ON main.idInvGroup = gr.idInvGroup" & vbNewLine &
                                               "LEFT JOIN dInvCode As ic ON main.idInvMain = ic.idInvMain " & vbNewLine &
                                              "LEFT JOIN dPackingPdSet fg ON main.idSubType = fg.idPdPk AND main.idInvGroup = 2" & vbNewLine &
                                              "LEFT JOIN SmPdOtherD pdo On main.idSubType = pdo.idPdo AND gr.stpdOther = 1" & vbNewLine &
                                              "LEFT JOIN dSeedFlPackage sfg ON main.idSubType = sfg.idFlPk AND main.idInvgroup = 42" & vbNewLine &
                                              "LEFT JOIN dSeedProductPrice d ON main.idInvMain = d.idInvMain AND main.idInvGroup = 1 AND d.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                              "WHERE  main.idInvmain = " & vFrm.dtLotReturn.Rows(0).Item("idInvMain")
                    sAdapter.Fill(dtSetPrice)

                    fnSetPriceNormal(dtSetPrice)
                    ' DGVBind.SetFocusedRowCellValue("PriceNormal", 0) 'ส่วนลด %
                    DGVBind.SetFocusedRowCellValue("PercDisc", 0) 'ส่วนลด %
                    DGVBind.SetFocusedRowCellValue("BathDisc", 0) 'ส่วนลด (บาท)
                    'DGVBind.SetFocusedRowCellValue("PriceSale", 0) 'ราคาขาย
                    DGVBind.SetFocusedRowCellValue("OldAmt", 0)

                    ' DGVBind.SetFocusedRowCellValue("Total", 0) 'รวมเป็นเงิน


                    'DGVBind.SetFocusedRowCellValue("AmtStock", vFrm.dtLotReturn.Rows(0).Item("AmtStock")) 'จน.คงเหลือใน Stock


                    DGVBind.SetFocusedRowCellValue("idWh", vFrm.dtLotReturn.Rows(0).Item("idWh"))
                    DGVBind.SetFocusedRowCellValue("full_lock", vFrm.dtLotReturn.Rows(0).Item("full_lock"))
                    DGVBind.SetFocusedRowCellValue("DtType", vFrm.dtLotReturn.Rows(0).Item("DtType"))
                    DGVBind.SetFocusedRowCellValue("CompRec", vFrm.dtLotReturn.Rows(0).Item("CompRec"))
                    DGVBind.SetFocusedRowCellValue("pWeight", vFrm.dtLotReturn.Rows(0).Item("pWeight"))
                    DGVBind.SetFocusedRowCellValue("idUnitW", vFrm.dtLotReturn.Rows(0).Item("idUnitW"))
                    DGVBind.SetFocusedRowCellValue("idRefLot", vFrm.dtLotReturn.Rows(0).Item("idRefLot"))



                    Dim SumStockinBill As Double = 0.0

                    For j As Integer = 0 To DGVBind.DataRowCount - 1
                        If Not IsDBNull(DGVBind.GetDataRow(j).Item("idLot")) Then
                            If (DGVBind.GetDataRow(j).Item("idLot") = vFrm.dtLotReturn.Rows(0).Item("idLot")) And
                                    (DGVBind.GetDataRow(j).Item("idWh") = vFrm.dtLotReturn.Rows(0).Item("idWh")) Then

                                Dim CalAmt As Double = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(j).Item("idUnit"), DGVBind.GetDataRow(j).Item("idInvGroup"),
                                                           CDbl(DGVBind.GetDataRow(j).Item("OldAmt")), DGVBind.GetDataRow(j).Item("idInvMain"))


                                SumStockinBill = SumStockinBill + CalAmt
                            End If
                        End If

                    Next
                    DGVBind.SetFocusedRowCellValue("idLot", vFrm.dtLotReturn.Rows(0).Item("idLot"))

                    If DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idInvGroup") <> 30 Then
                        DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtStock") = vFrm.dtLotReturn.Rows(0).Item("AmtStock") + SumStockinBill

                    ElseIf DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idInvGroup") = 30 Then
                        'ถ้าเป็น idInvGroup = 30 ให้ Stock = 0
                        DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtStock") = 0
                    End If

                    DGVBind.SetFocusedRowCellValue("idUnit", vFrm.dtLotReturn.Rows(0).Item("idUnit"))
                    DGVBind.SetFocusedRowCellValue("UnitName", vFrm.dtLotReturn.Rows(0).Item("UnitName"))

                    Dim defaultAmtSale As Double = 0.0
                    If vFrm.dtLotReturn.Rows(0).Item("AmtStock") >= 1 And cmbGroupComp.SelectedValue <> 2 Then
                        defaultAmtSale = 1
                    Else
                        defaultAmtSale = vFrm.dtLotReturn.Rows(0).Item("AmtStock")
                    End If

                    DGVBind.SetFocusedRowCellValue("AmtSale", defaultAmtSale)  'จำนวนขาย

                    SendKeys.SendWait("{Right}")
                    'Else
                    '    navigator.Buttons.DoClick(navigator.Buttons.Remove)
                End If
                'Else
                '    navigator.Buttons.DoClick(navigator.Buttons.Remove)
            End If
        End If


    End Sub

    '--------------ทำรายการขายจากรายการสั่งซื้อ------------------
    'Private Sub btnOrderInc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrderInc.Click

    '    Dim navigator As ControlNavigator = GCSale.EmbeddedNavigator
    '    'If DGVBind.FocusedRowHandle >= 0 Then
    '    '    navigator.Buttons.DoClick(navigator.Buttons.Edit)
    '    'Else
    '    '    navigator.Buttons.DoClick(navigator.Buttons.Append)
    '    '    navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
    '    'End If

    '    If idPartner = 0 Then
    '        MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        SendKeys.SendWait("{BACKSPACE}")
    '        navigator.Buttons.DoClick(navigator.Buttons.Remove)

    '        Exit Sub
    '    End If


    '    'Dim idCusBack As Integer = 0
    '    'Dim orBack As New DataTable
    '    'orBack.Columns.Add("idSaleOrderDt", Type.GetType("System.Int32"))

    '    Dim k As Integer = 0
    '    '-------------------------------NEW GRID-------------------------------
    '    'For i As Integer = 0 To DGVBind.DataRowCount - 1
    '    '    If Not IsDBNull(DGVBind.GetDataRow(i).Item("idSaleOrderDt")) Then
    '    '        If DGVBind.GetDataRow(i).Item("idSaleOrderDt") <> Nothing Then
    '    '            orBack.Rows.Add()
    '    '            orBack.Rows(k).Item("idSaleOrderDt") = DGVBind.GetDataRow(i).Item("idSaleOrderDt")
    '    '            k = k + 1
    '    '        End If
    '    '    End If
    '    'Next
    '    '-----------------------------------------------------------------------

    '    ' Dim OrderAgain As New DataTable
    '    Dim vFrm As New frmSlOrderSelect(frmSlOrderSelect.eProcess.eSelect, cmbGroupComp.SelectedValue, idPartner, Trim(lblPsCus.Text))
    '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then


    '        For i As Integer = 0 To vFrm.gMainReturn.Rows.Count - 1
    '            colAmtOrder.Visible = True
    '            colAmtOrder.VisibleIndex = 4
    '            'Dim stEnough As Integer = 0
    '            'Dim chkBalAmtOrder As Double = vFrm.gMainReturn.Rows(i).Item("AmtOrder")
    '            'Dim NumLoop As Integer = 0
    '            'Do Until stEnough = 1

    '            'If i <> 0 Then
    '            navigator.Buttons.DoClick(navigator.Buttons.Append)
    '            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
    '            'End If

    '            'If IsDBNull(DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idSaleDt")) Then
    '            '    DGVBind.SetFocusedRowCellValue("idSaleDt", 0)
    '            '    'DGVBind.SetFocusedRowCellValue("No", 999)
    '            'End If
    '            DGVBind.SetFocusedRowCellValue("idSaleOrderDt", vFrm.gMainReturn.Rows(i).Item("idSaleOrderDt"))
    '            DGVBind.SetFocusedRowCellValue("PdCode", vFrm.gMainReturn.Rows(i).Item("InvCode"))
    '            DGVBind.SetFocusedRowCellValue("idInvMain", vFrm.gMainReturn.Rows(i).Item("idInvMain"))
    '            DGVBind.SetFocusedRowCellValue("ProductName", vFrm.gMainReturn.Rows(i).Item("InvName"))
    '            DGVBind.SetFocusedRowCellValue("idInvGroup", vFrm.gMainReturn.Rows(i).Item("idInvGroup"))


    '            fnSetPriceNormal(vFrm.gMainReturn)
    '            DGVBind.SetFocusedRowCellValue("LotNo", "")
    '            DGVBind.SetFocusedRowCellValue("idLot", 0)
    '            DGVBind.SetFocusedRowCellValue("idWh", 0)
    '            'fnSetDefualtLotFIFO(vFrm.gMainReturn.Rows(i).Item("idInvMain"))

    '            DGVBind.SetFocusedRowCellValue("AmtStock", 0)
    '            DGVBind.SetFocusedRowCellValue("AmtOrder", vFrm.gMainReturn.Rows(i).Item("AmtOrder")) 'จน.สั่งซื้อ
    '            'DGVBind.SetFocusedRowCellValue("PriceNormal", 0) 'ราคาปกติ
    '            DGVBind.SetFocusedRowCellValue("PercDisc", 0) 'ส่วนลด %
    '            DGVBind.SetFocusedRowCellValue("BathDisc", 0) 'ส่วนลด (บาท)
    '            ' DGVBind.SetFocusedRowCellValue("PriceSale", 0) 'ราคาขาย
    '            'DGVBind.SetFocusedRowCellValue("Total", 0) 'รวมเป็นเงิน
    '            'DGVBind.SetFocusedRowCellValue("AmtSaleHide", vFrm.gMainReturn.Rows(i).Item("AmtOrder"))
    '            'DGVBind.SetFocusedRowCellValue("idSaleOrderDt", 0)

    '            DGVBind.SetFocusedRowCellValue("OldStock", 0)
    '            DGVBind.SetFocusedRowCellValue("OldAmt", 0)
    '            DGVBind.SetFocusedRowCellValue("CompRec", cmbGroupComp.SelectedValue)
    '            DGVBind.SetFocusedRowCellValue("chk", False)
    '            DGVBind.SetFocusedRowCellValue("idLotSPM", 0)

    '            'DGVBind.SetFocusedRowCellValue("DtType", vFrm.gMainReturn.Rows(0).Item("DtType"))
    '            'DGVBind.SetFocusedRowCellValue("idSubType", vFrm.gMainReturn.Rows(0).Item("idSubType"))

    '            DGVBind.SetFocusedRowCellValue("UnitName", vFrm.gMainReturn.Rows(i).Item("UnitName"))
    '            DGVBind.SetFocusedRowCellValue("idUnit", vFrm.gMainReturn.Rows(i).Item("idUnit"))

    '            'If stEnough = 0 Then
    '            '    If NumLoop = 0 Then
    '            '        'stridLot = "(lm.idLot <>" & DGVBind.GetFocusedRowCellValue(Col_idLot) & " AND ref.idWh <> " & DGVBind.GetFocusedRowCellValue(colidWh) & ")"
    '            '        stridLot = DGVBind.GetFocusedRowCellValue(colidRefLot)
    '            '    Else
    '            '        'stridLot = stridLot & " AND (lm.idLot <>" & DGVBind.GetFocusedRowCellValue(Col_idLot) & " AND ref.idWh <> " & DGVBind.GetFocusedRowCellValue(colidWh) & ")"
    '            '        stridLot = stridLot & "," & DGVBind.GetFocusedRowCellValue(colidRefLot)
    '            '    End If

    '            '    Dim SumAmtStockInLot As Double = 0.0
    '            '    For j As Integer = 0 To DGVBind.DataRowCount - 1
    '            '        If DGVBind.GetRowCellValue(j, colidInvMain) = DGVBind.GetFocusedRowCellValue(colidInvMain) Then
    '            '            SumAmtStockInLot = SumAmtStockInLot + DGVBind.GetRowCellValue(j, ColAmtStock)
    '            '        End If
    '            '    Next

    '            '    'Console.WriteLine(DGVBind.GetFocusedRowCellValue(ColAmtStock))
    '            '    If vFrm.gMainReturn.Rows(i).Item("AmtOrder") <= SumAmtStockInLot Then
    '            '        stEnough = 1
    '            '        DGVBind.SetFocusedRowCellValue("AmtSale", chkBalAmtOrder)
    '            '        DGVBind.GetFocusedRowCellValue(ColAmtSale)

    '            '    Else
    '            '        chkBalAmtOrder = chkBalAmtOrder - DGVBind.GetFocusedRowCellValue(ColAmtStock)
    '            '        DGVBind.SetFocusedRowCellValue("AmtSale", DGVBind.GetFocusedRowCellValue(ColAmtStock))
    '            '        'Console.WriteLine(DGVBind.GetFocusedRowCellValue(ColAmtSale))
    '            '        'stridLot = stridLot
    '            '        'Console.WriteLine(stridLot)
    '            '    End If
    '            'End If  ' End Result OK

    '            'NumLoop = NumLoop + 1
    '            'Loop

    '        Next

    '        DGVBind.RefreshData()
    '    End If

    'End Sub

    Private Sub lblCusRec_Click(sender As Object, e As EventArgs) Handles lblCusRec.Click

        If idSend <> 0 Then
            MessageBox.Show("ไม่สามารถแก้ไขชื่อผู้รับได้" & vbNewLine & "หากต้องการแก้ไข กรุณายกเลิกรายการขนส่งก่อน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

    Private Sub lblTspComp_Click(sender As Object, e As EventArgs) Handles lblTspComp.Click
        If idSend <> 0 Then
            MessageBox.Show("ไม่สามารถแก้ไขบริษัทขนส่งได้" & vbNewLine & "หากต้องการแก้ไข กรุณายกเลิกรายการขนส่งก่อน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub


    Private Sub txtDiscBath_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAmtPerc.KeyUp, txtDiscBath.KeyUp
        If stLoad = 1 Then

            If rdbPerDisc.Checked = True Then
                If txtAmtPerc.Text = "" Then
                    txtAmtPerc.Text = 0
                End If
                lblPerc.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) * CDbl(txtAmtPerc.Text.Trim) / 100, "#,##0.00##")
                txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - (CDbl(txtTotalBFDisc.Text.Trim) * CDbl(txtAmtPerc.Text.Trim) / 100), "#,##0.00##")
            ElseIf rdbBathDisc.Checked = True Then
                txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - CDbl(txtDiscBath.Text.Trim), "#,##0.00##")
            End If
        End If
    End Sub

    'Private Sub txtAmtPerc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmtPerc.KeyUp, txtDiscBath.KeyUp
    '    If stLoad = 1 Then

    '        If rdbPerDisc.Checked = True Then
    '            lblPerc.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) * CDbl(txtAmtPerc.Text.Trim) / 100, "#,##0.00##")
    '            txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - (CDbl(txtTotalBFDisc.Text.Trim) * CDbl(txtAmtPerc.Text.Trim) / 100), "#,##0.00##")
    '        ElseIf rdbBathDisc.Checked = True Then
    '            txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - CDbl(txtDiscBath.Text.Trim), "#,##0.00##")
    '        End If
    '    End If

    'End Sub

    Private Sub rdbBathDisc_CheckedChanged(sender As Object, e As EventArgs) Handles rdbBathDisc.CheckedChanged
        If stLoad = 1 Then
            If rdbBathDisc.Checked = True Then
                txtAmtPerc.Text = 0
                lblPerc.Text = 0
                txtAmtPerc.Enabled = False
                txtDiscBath.Enabled = True
                txtDiscBath.Focus()
            Else
                txtDiscBath.Text = 0
                txtDiscBath.Enabled = False
            End If

            If rdbPerDisc.Checked = True Then
                lblPerc.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) * CDbl(txtAmtPerc.Text.Trim) / 100, "#,##0.00##")
                txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - (CDbl(txtTotalBFDisc.Text.Trim) * CDbl(txtAmtPerc.Text.Trim) / 100), "#,##0.00##")
            ElseIf rdbBathDisc.Checked = True Then
                txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - CDbl(txtDiscBath.Text.Trim), "#,##0.00##")
            End If

        End If
    End Sub

    Private Sub rdbPerDisc_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPerDisc.CheckedChanged
        If stLoad = 1 Then
            If rdbPerDisc.Checked = True Then
                txtAmtPerc.Text = 0
                txtAmtPerc.Enabled = True
                txtAmtPerc.Focus()
            Else
                txtDiscBath.Text = 0
                txtDiscBath.Enabled = False


            End If

            If rdbPerDisc.Checked = True Then
                lblPerc.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) * CDbl(txtAmtPerc.Text.Trim) / 100, "#,##0.00##")
                txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - (CDbl(txtTotalBFDisc.Text.Trim) * CDbl(txtAmtPerc.Text.Trim) / 100), "#,##0.00##")
            ElseIf rdbBathDisc.Checked = True Then
                txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - CDbl(txtDiscBath.Text.Trim), "#,##0.00##")
            End If
        End If
    End Sub

    Private Sub btnPsOrder_Click(sender As Object, e As EventArgs) Handles btnPsOrder.Click
        Dim frm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPsOrder.Text = frm.mName
            Me.lblPsOrder.Tag = frm.mId
        End If
    End Sub

    Private Sub btnDraft_Click(sender As Object, e As EventArgs) Handles btnDraft.Click
        If idSlAVxST <> 0 Then
            MessageBox.Show("ไม่สามารถแก้ไขรายการขายนี้ได้ " & vbCrLf &
                            " เนื่องจากเป็นรายการที่ถูกบันทึกด้วยระบบ AUTO BILL", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If stRecWIM = 1 Then 'แก้ไขรายการ ที่
            NoteChangePrice = InputBox("ระบุสาเหตุ การเปลี่ยนแปลงข้อมูล", sSystemName)

            If NoteChangePrice.Length = 0 Then
                MessageBox.Show("กรุณาระบุสาเหตุ การเปลี่ยนแปลงข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                Result = Windows.Forms.DialogResult.Yes
            End If
        Else

            Result = MsgBox("คุณต้องการบันทึก 'แบบร่าง' รายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
        End If

        If Result = Windows.Forms.DialogResult.Yes Then

            If lblPsCus.Text = "" Then

                MessageBox.Show("กรุณาเลือกชื่อลูกค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf lblPsSale.Text = "" Then

                MessageBox.Show("กรุณาเลือกเจ้าหน้าที่ขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf txtDocRef.Text = "" Then

                MessageBox.Show("กรุณากรอกเลขที่อ้างอิง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.txtDocRef.Focus()
                Exit Sub
            ElseIf Me.rdbRight.Checked = False And Me.rdbNoRight.Checked = False Then

                MessageBox.Show("กรุณาเลือกประเภทบิลถูกหลัก/ไม่ถูกหลักก่อนกดบันทึก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub

            End If

            mdCnOpen()

            'Sum Amount each Lot
            Dim tempSaleDt As New DataTable
            tempSaleDt.Columns.Add("idLot", System.Type.GetType("System.Int64"))
            tempSaleDt.Columns.Add("idInvGroup", System.Type.GetType("System.Int64"))
            tempSaleDt.Columns.Add("SumAmount", System.Type.GetType("System.Double"))
            tempSaleDt.Columns.Add("OldAmount", System.Type.GetType("System.Double"))
            'tempSaleDt.Columns.Add("idWh", System.Type.GetType("System.Double"))
            tempSaleDt.Columns.Add("idRefLot", System.Type.GetType("System.Int64"))
            '--------------------NEW GRID----------------------------------
            '--------------------------------------------------------------
            For i As Integer = 0 To DGVBind.DataRowCount - 1
                '*****Check row is nothing*****'
                If IsDBNull(DGVBind.GetDataRow(i).Item("idInvMain")) Then
                    MessageBox.Show("มีลำดับข้อมูล ที่ไม่มีรายการสินค้า กรุณาตรวจสอบก่อนบันทึกอีกครั้ง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' ถ้าเคสที่ ขายแบบไม่มี Lot ก็จะรอด ISDBNULL(DGVBind.GetDataRow(i).Item("idLot"))
                If IsDBNull(DGVBind.GetDataRow(i).Item("idLot")) Then
                    DGVBind.GetDataRow(i).Item("idLot") = 0
                End If

                If DGVBind.GetDataRow(i).Item("idInvGroup") <> 30 And DGVBind.GetDataRow(i).Item("idLot") = 0 Then
                    MessageBox.Show("กรุณาเลือก Lot ของสินค้าให้ครบทุกรายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                If DGVBind.GetDataRow(i).Item("AmtSale") = 0 Then
                    MessageBox.Show("มีบางรายการระบุจำนวนขายเท่ากับ 0 ระบบจึงไม่สามารถบันทึกข้อมูลได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                '--- Check Stock ----'
                Dim AmountUse As Double = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(i).Item("idUnit"), DGVBind.GetDataRow(i).Item("idInvGroup"),
                                        DGVBind.GetDataRow(i).Item("AmtSale"), DGVBind.GetDataRow(i).Item("idInvMain"))

                If i = 0 Then '1st row
                    tempSaleDt.Rows.Add(DGVBind.GetDataRow(i).Item("idLot"), DGVBind.GetDataRow(i).Item("idInvGroup"), AmountUse,
                                                DGVBind.GetDataRow(i).Item("OldAmt"), DGVBind.GetDataRow(i).Item("idRefLot"))
                Else

                    Dim stAdd As Integer = 0
                    For j As Integer = 0 To tempSaleDt.Rows.Count - 1
                        If DGVBind.GetDataRow(i).Item("idLot") = tempSaleDt.Rows(j).Item("idLot") And
                                   DGVBind.GetDataRow(i).Item("idInvGroup") = tempSaleDt.Rows(j).Item("idInvGroup") And
                                   DGVBind.GetDataRow(i).Item("idRefLot") = tempSaleDt.Rows(j).Item("idRefLot") Then

                            'tempSaleDt.Rows(j).Item("SumAmount") = tempSaleDt.Rows(j).Item("SumAmount") + AmountUse
                            tempSaleDt.Rows(j).Item("OldAmount") = tempSaleDt.Rows(j).Item("OldAmount") + DGVBind.GetDataRow(i).Item("OldAmt")

                            stAdd = 1
                            Exit For

                        End If
                    Next

                    If stAdd = 0 Then 'Now row in Dt >> Add New Row
                        tempSaleDt.Rows.Add(DGVBind.GetDataRow(i).Item("idLot"), DGVBind.GetDataRow(i).Item("idInvGroup"), AmountUse,
                                                    DGVBind.GetDataRow(i).Item("OldAmt"), DGVBind.GetDataRow(i).Item("idRefLot"))
                    End If

                End If

                'Check % DisCount
                If IsDBNull(DGVBind.GetDataRow(i).Item("PercDisc")) Then
                    DGVBind.GetDataRow(i).Item("PercDisc") = 0
                End If
                If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                    DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
                End If

                'Check Bath DisCount
                If IsDBNull(DGVBind.GetDataRow(i).Item("BathDisc")) Then
                    DGVBind.GetDataRow(i).Item("BathDisc") = 0
                End If
                If DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                    DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
                End If

            Next  ' Next loop DGVCombine
            '--------------------------------------------------------------
            '--------------------------------------------------------------
            For i As Integer = 0 To tempSaleDt.Rows.Count - 1

                If tempSaleDt.Rows(i).Item("idInvGroup") <> 30 Then 'ไม่ใช่ค่าขนส่ง 
                    Dim sDt As New DataTable
                    sDt.Clear()

                    sCommand.CommandText = "SELECT main.InvName, unit.UnitName, " & vbNewLine &
                                                     "(ref.Amount - (SELECT ISNULL(SUM(AmountWaitChange),0) " & vbNewLine &
                                                                    "FROM WimWaitCutDt wDt " & vbNewLine &
                                                                    "LEFT JOIN WimWaitCutMt wMt ON wDt.idWaitCutMt = wMt.idWaitCutMt" & vbNewLine &
                                                                    "WHERE wDt.idLot = lm.idLot" & vbNewLine &
                                                                    "AND ref.idWh = wDt.idWh" & vbNewLine &
                                                                    "AND wDt.stWait Is NULL" & vbNewLine &
                                                                    "AND wMt.stCancel Is NULL" & vbNewLine &
                                                                    "AND wDt.stDel Is NULL)) As Amount" & vbNewLine &
                                                  "FROM dInvLotRefWh As ref " & vbNewLine &
                                                  "LEFT JOIN dInvLotMain As lm ON ref.idLot = lm.idLot " & vbNewLine &
                                                  "LEFT JOIN dInventoryMain As main ON lm.idInvMain = main.idInvMain" & vbNewLine &
                                                  "LEFT JOIN dInvUnit As unit ON ref.idUnit = unit.idUnit" & vbNewLine &
                                                  "WHERE ref.idRefLot = " & tempSaleDt.Rows(i).Item("idRefLot")

                    sAdapter.Fill(sDt)


                    Dim AllStock As Double = sDt.Rows(0).Item("Amount") + tempSaleDt.Rows(i).Item("OldAmount")
                    If AllStock < tempSaleDt.Rows(i).Item("SumAmount") Then  ' Stock < AllSaleAmount

                        MessageBox.Show("จำนวน " & sDt.Rows(0).Item("InvName") & " คงเหลือใน Stock ไม่เพียงพอ ระบบจึงไม่สามารถทำรายการขายได้" & vbCrLf &
                                      "(จำนวนขายรวม : " & Format(tempSaleDt.Rows(i).Item("SumAmount"), "#,##0.00##") & " " & sDt.Rows(0).Item("UnitName") &
                                      " แต่จำนวน Stock คงเหลือ : " & Format(AllStock, "#,##0.00##") & " " &
                                      sDt.Rows(0).Item("UnitName") & ")", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        Exit Sub
                    End If
                End If
            Next

            Select Case eEvent
                Case eProcess.eAddCombine 'AddData
                    '----insert----'

                    stDraft = 1
                    idSaleS = AddSmSale()

                    If idSaleS = 0 Then
                        Exit Sub
                    Else
                        mdCnOpen()
                        sCommand.CommandText = "UPDATE WimWaitCutMt SET stNoApprove = 1 WHERE idMt = " & idSaleS & " AND ProcessID = 4"
                        sCommand.ExecuteNonQuery()

                        sCommand.CommandText = "UPDATE SmSaleMt SET idPsDraft = " & sPsId & ", DateDraft = GETDATE() WHERE idSale = " & idSaleS
                        sCommand.ExecuteNonQuery()

                        'send to line when Company is Siam Advance Host, idComp = 11
                        If cmbGroupComp.SelectedValue = 11 Then
                            fnLineNotice()
                        End If

                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If

                Case eProcess.eEditCombine ' EditData

                    Using myconnection As New SqlConnection(conStr)
                        myconnection.Open()
                        Dim mycommand As New SqlCommand()
                        ' Dim mycommand As SqlCommand = myconnection.CreateCommand()
                        Dim mytransaction As SqlTransaction
                        Dim myAdapter As New SqlDataAdapter(mycommand)
                        ' Start a local transaction
                        mytransaction = myconnection.BeginTransaction()

                        ' Must assign both transaction object and connection
                        ' to Command object for a pending local transaction.
                        mycommand.Connection = myconnection
                        mycommand.Transaction = mytransaction

                        Try
                            '---Update---'
                            EditSmSaleMtAndDt(mycommand)

                            Dim didComp As Integer = 0
                            Dim idSaleSP As Integer = idSaleS
                            Dim stChkCompRec As Integer = 0
                            If cmbGroupComp.SelectedValue = 10 Then
                                didComp = 4

                                Dim dt As New DataTable
                                mycommand.CommandText = "SELECT idSale FROM SmSaleMt WHERE idSlAvxST = " & idSaleS
                                myAdapter.Fill(dt)
                                idSaleSP = dt.Rows(0).Item("idSale")

                            Else
                                didComp = cmbGroupComp.SelectedValue
                            End If

                            '---- Update SumService in SmSaleMt ----'
                            mycommand.CommandText = "Update SmSaleMt Set SumService = " & SumSvFree & " WHERE idSale = " & idSaleS
                            mycommand.ExecuteNonQuery()

                            Dim dtidSaleAV As New DataTable
                            mycommand.CommandText = "SELECT idSale As idSaleAV FROM SmSaleMt WHERE idSlAVxST = " & idSaleS
                            myAdapter.Fill(dtidSaleAV)

                            If dtidSaleAV.Rows.Count > 0 Then
                                EditSlAVxStar(mycommand, dtidSaleAV.Rows(0).Item("idSaleAV"))
                            End If

                            Dim dtChkCompRec As New DataTable

                            mycommand.CommandText = "SELECT Distinct CompRec " & vbNewLine &
                                                            "FROM SmSaleDtAll dt" & vbNewLine &
                                                            "LEFT JOIN dInvLotMain lm ON dt.idLot = lm.idLot" & vbNewLine &
                                                            "WHERE dt.idSale = " & idSaleSP & vbNewLine &
                                                            "AND lm.idInvMain <> 9766"
                            myAdapter.Fill(dtChkCompRec)

                            Dim dtChkWaitCompRec As New DataTable

                            mycommand.CommandText = "SELECT Distinct CompRec " & vbNewLine &
                                                           "FROM WimWaitCutDt wDt" & vbNewLine &
                                                           "LEFT JOIN WimWaitCutMt wMt ON wDt.idWaitCutMt = wMt.idWaitCutMt" & vbNewLine &
                                                           "LEFT JOIN dInvLotMain lm ON wDt.idLot = lm.idLot" & vbNewLine &
                                                           "WHERE wMt.idMt IN (" & idSaleSP & "," & idSaleS & ")" & vbNewLine &
                                                           "AND wMt.ProcessID = 4"
                            myAdapter.Fill(dtChkWaitCompRec)


                            If dtChkCompRec.Rows.Count > 1 Or dtChkWaitCompRec.Rows.Count > 1 Then
                                stChkCompRec = 1
                                EditWaitCutAVxST(mycommand, idSaleS, idSaleSP)
                            End If

                            Dim dtCountWait As New DataTable
                            mycommand.CommandText = "SELECT * FROM WimWaitcutMt WHERE idMt = " & idSaleSP & " AND ProcessID = 4"
                            myAdapter.Fill(dtCountWait)


                            If DGVBind.DataRowCount > 0 And findCutStock = 0 And dtCountWait.Rows.Count = 0 Then
                                ' Insert WimWaitCutMt/Dt ถ้ายังไม่เคย insert
                                mycommand.CommandText = "EXEC WaitCutTs '4','SmSaleMt','SmSaleDtAll','idSale'," & idSaleSP & "," & didComp & "," & sPsId & ",'1'"
                                mycommand.ExecuteNonQuery()

                            End If

                            If stChkCompRec = 0 And stCut = 0 Then

                                mycommand.CommandText = "EXEC WaitCutTsEdit '4','SmSaleMt','SmSaleDtAll','idSale'," & idSaleSP & "," & didComp & "," & sPsId & ",'2'"
                                mycommand.ExecuteNonQuery()
                            End If
                            mytransaction.Commit()

                            mycommand.CommandText = "UPDATE WimWaitCutMt SET stNoApprove = 1 WHERE idMt = " & idSaleSP & " AND ProcessID = 4"
                            mycommand.ExecuteNonQuery()


                            MessageBox.Show("บันทึกการแก้ไขข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()

                        Catch ex As Exception
                            ' Attempt to roll back the transaction. 
                            Try
                                mytransaction.Rollback()

                                MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                                                sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                            Catch e2x As Exception

                                MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                                                 sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                            End Try
                        End Try
                    End Using
            End Select
        End If

    End Sub

    Private Sub btnOrderSel_Click(sender As Object, e As EventArgs) Handles btnOrderSel.Click
        If Me.lblPsCus.Text = "" Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการเลือกรายการสั่งซื้อ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim strIDSel As String = "0"

        If DGVBind.DataRowCount > 0 Then
            If Not IsDBNull(DGVBind.GetRowCellValue(0, Col_idSaleOrderDt)) Then
                strIDSel = DGVBind.GetRowCellValue(0, Col_idSaleOrderDt)
            End If

            For i As Integer = 1 To DGVBind.DataRowCount - 1
                If IsDBNull(DGVBind.GetRowCellValue(i, Col_idSaleOrderDt)) Then
                    DGVBind.SetRowCellValue(i, Col_idSaleOrderDt, 0)
                End If
                strIDSel = strIDSel & "," & DGVBind.GetRowCellValue(i, Col_idSaleOrderDt)
            Next
        End If

        Dim vFrm As New FrmMnOrderSel(FrmMnOrderSel.eProcess.eSelOrder, cmbGroupComp.SelectedValue, idPartner, Me.lblPsCus.Text.Trim, strIDSel)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

            mdCnOpen()
            For round As Integer = 0 To vFrm.MainReturn.Rows.Count - 1
                '-----กรณีมี idCusRefAddr ที่ Set มาจาก Order----- 
                If vFrm.MainReturn.Rows(round).Item("idCusRefAddr") <> 0 Then
                    Dim sDt As New DataTable
                    sCommand.CommandText = "Select s.AddressS, s.stFromS, s.PsRecName, s.idTsp, ISNULL(s.idPayTsp,0) As idPayTsp, ISNULL(s.idSupTsp,0) As idSupTsp, ISNULL(sp.SupName,'') As SupName " &
                                     "From dCustomerAdrSent s " & vbNewLine &
                                     "LEFT OUTER JOIN PchInvAndProject.dbo.vSupplier sp ON s.idSupTsp = sp.idSup " & vbNewLine &
                                     "Where s.idCusRefAddr = " & vFrm.MainReturn.Rows(round).Item("idCusRefAddr")
                    sAdapter.Fill(sDt)

                    lblAddr.Tag = vFrm.MainReturn.Rows(round).Item("idCusRefAddr")
                    Me.lblAddr.Text = sDt.Rows(0).Item("AddressS")
                    Me.lblCusRec.Text = sDt.Rows(0).Item("PsRecName")
                    Me.CmbTs.SelectedValue = sDt.Rows(0).Item("idTsp")
                    Me.cmbTypePayTrp.SelectedValue = sDt.Rows(0).Item("idPayTsp")

                    Me.lblTspComp.Tag = sDt.Rows(0).Item("idSupTsp")
                    Me.lblTspComp.Text = sDt.Rows(0).Item("SupName")

                    If sDt.Rows(0).Item("idPayTsp") <> 0 Then
                        cmbTypePayTrp.SelectedValue = sDt.Rows(0).Item("idPayTsp")
                    End If
                End If

                Dim defaultAmtSale As Double = 0
                Dim PriceNormal As Double = 0
                Dim LastPrice As Double = 0.0 'ราคาขายล่าสุด

                Dim dtLastPrice As New DataTable
                Dim gLastPrice As Double = 0.0
                sCommand.CommandText = "SELECT TOP(1) ISNULL(dt.Price,0) As LastPrice " & vbNewLine &
                                            "FROM SmSaleDtAll dt " & vbNewLine &
                                            "LEFT OUTER JOIN SmSaleMt mt ON dt.idsale = mt.idSale " & vbNewLine &
                                            "WHERE mt.idPartner = " & idPartner & vbNewLine &
                                            "AND dt.idProduct =  " & vFrm.MainReturn.Rows(round).Item("idInvMain") & vbNewLine &
                                            "AND mt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                            "AND ISNULL(dt.Price,0) > 0" & vbNewLine &
                                            "Order by mt.DateSale DESC "
                sAdapter.Fill(dtLastPrice)

                If dtLastPrice.Rows.Count <> 0 Then
                    gLastPrice = dtLastPrice.Rows(0).Item("LastPrice")
                End If

                If Me.rdbWhole.Checked = True Then
                    PriceNormal = vFrm.MainReturn.Rows(round).Item("PriceWholesale_fg")
                ElseIf Me.rdbRetail.Checked = True Then
                    PriceNormal = vFrm.MainReturn.Rows(round).Item("PriceRetail_fg")
                ElseIf Me.rdbBill.Checked = True Then
                    PriceNormal = vFrm.MainReturn.Rows(round).Item("PriceBill_fg")
                End If

                If vFrm.MainReturn.Rows(round).Item("idPdoType") = 3 Then  ' พลาสติกคลุมดิน
                    If Me.cmbTp.SelectedValue = 49 Then  ' credit 30
                        PriceNormal = vFrm.MainReturn.Rows(round).Item("CreditThirty_pdo")
                        If gLastPrice <> 0 Then
                            LastPrice = gLastPrice
                        Else
                            LastPrice = vFrm.MainReturn.Rows(round).Item("CreditThirty_pdo")
                        End If

                    ElseIf Me.cmbTp.SelectedValue = 50 Then  ' credit 60
                        PriceNormal = vFrm.MainReturn.Rows(round).Item("CreditSixty_pdo")
                        If gLastPrice <> 0 Then
                            LastPrice = gLastPrice
                        Else
                            LastPrice = vFrm.MainReturn.Rows(round).Item("CreditSixty_pdo")
                        End If

                    Else  ' Other
                        PriceNormal = vFrm.MainReturn.Rows(round).Item("PricePdo_pdo")
                        If gLastPrice <> 0 Then
                            LastPrice = gLastPrice
                        Else
                            LastPrice = vFrm.MainReturn.Rows(round).Item("PricePdo_pdo")
                        End If
                    End If

                ElseIf vFrm.MainReturn.Rows(round).Item("idInvGroup") <> 2 Then  ' Other Type except FG (idInvGroup = 2)
                    If IsDBNull(vFrm.MainReturn.Rows(round).Item("PricePdo_pdo")) Then
                        PriceNormal = 0.0
                    Else
                        PriceNormal = vFrm.MainReturn.Rows(round).Item("PricePdo_pdo")
                    End If
                End If

                If vFrm.MainReturn.Rows(round).Item("idInvGroup") = 1 Then  ' Other Type except FG (idInvGroup = 2)
                    PriceNormal = vFrm.MainReturn.Rows(round).Item("PriceSeed")
                End If

                If PriceNormal <> 0 Then
                    LastPrice = PriceNormal
                Else
                    LastPrice = gLastPrice
                    PriceNormal = gLastPrice
                End If

                If vFrm.MainReturn.Rows(round).Item("idType") = 2 Then 'ของแถม
                    PriceNormal = 0
                    LastPrice = 0
                End If

                DGVBind.AddNewRow()
                ColCodeOrder.Visible = True
                colAmtOrder.Visible = True
                ColCodeOrder.VisibleIndex = 1
                colAmtOrder.VisibleIndex = 5

                DGVBind.SetFocusedRowCellValue("CodeOrder", vFrm.MainReturn.Rows(round).Item("CodeOrder"))
                DGVBind.SetFocusedRowCellValue("idSaleOrderDt", vFrm.MainReturn.Rows(round).Item("idSaleOrderDt"))
                DGVBind.SetFocusedRowCellValue("PdCode", vFrm.MainReturn.Rows(round).Item("PdCode"))
                DGVBind.SetFocusedRowCellValue("LotNo", vFrm.MainReturn.Rows(round).Item("LotNo"))
                DGVBind.SetFocusedRowCellValue("idSaleDt", 0)
                If IsDBNull(vFrm.MainReturn.Rows(round).Item("idInvMain")) Then
                    DGVBind.SetFocusedRowCellValue("idInvMain", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("idInvMain", vFrm.MainReturn.Rows(round).Item("idInvMain"))
                End If


                DGVBind.SetFocusedRowCellValue("ProductName", vFrm.MainReturn.Rows(round).Item("ProductName"))

                DGVBind.SetFocusedRowCellValue("AmtOrder", vFrm.MainReturn.Rows(round).Item("AmtOrder"))
                DGVBind.SetFocusedRowCellValue("OldAmt", 0)

                DGVBind.SetFocusedRowCellValue("PriceNormal", PriceNormal)
                DGVBind.SetFocusedRowCellValue("PercDisc", 0.0)
                DGVBind.SetFocusedRowCellValue("BathDisc", 0.0)
                DGVBind.SetFocusedRowCellValue("PriceSale", LastPrice)

                'DGVBind.SetFocusedRowCellValue("idSaleDt", 0)
                DGVBind.SetFocusedRowCellValue("idRefLot", vFrm.MainReturn.Rows(round).Item("idRefLot"))
                DGVBind.SetFocusedRowCellValue("CompRec", vFrm.MainReturn.Rows(round).Item("CompRec"))
                DGVBind.SetFocusedRowCellValue("idUnitW", vFrm.MainReturn.Rows(round).Item("idUnitW"))
                DGVBind.SetFocusedRowCellValue("pWeight", vFrm.MainReturn.Rows(round).Item("pWeight"))


                If IsDBNull(vFrm.MainReturn.Rows(round).Item("idWh")) Then
                    DGVBind.SetFocusedRowCellValue("idWh", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("idWh", vFrm.MainReturn.Rows(round).Item("idWh"))
                    DGVBind.SetFocusedRowCellValue("full_lock", vFrm.MainReturn.Rows(round).Item("full_lock"))
                End If

                If IsDBNull(vFrm.MainReturn.Rows(round).Item("idLotSPM")) Then
                    DGVBind.SetFocusedRowCellValue("idLotSPM", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("idLotSPM", vFrm.MainReturn.Rows(round).Item("idLotSPM"))
                End If

                If IsDBNull(vFrm.MainReturn.Rows(round).Item("idInvGroup")) Then
                    DGVBind.SetFocusedRowCellValue("idInvGroup", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("idInvGroup", vFrm.MainReturn.Rows(round).Item("idInvGroup"))
                End If

                If IsDBNull(vFrm.MainReturn.Rows(round).Item("DtType")) Then
                    DGVBind.SetFocusedRowCellValue("DtType", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("DtType", vFrm.MainReturn.Rows(round).Item("DtType"))
                End If

                If IsDBNull(vFrm.MainReturn.Rows(round).Item("idSubType")) Then
                    DGVBind.SetFocusedRowCellValue("idSubType", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("idSubType", vFrm.MainReturn.Rows(round).Item("idSubType"))
                End If

                'check stock : หัก stock ของ rows ก่อนหน้า
                Dim SumStockinBill As Double = 0.0

                For j As Integer = 0 To DGVBind.DataRowCount - 1
                    If IsDBNull(vFrm.MainReturn.Rows(round).Item("idLot")) Then
                        vFrm.MainReturn.Rows(round).Item("idLot") = 0
                    End If

                    If vFrm.MainReturn.Rows(round).Item("idLot") <> 0 Then
                        If (DGVBind.GetDataRow(j).Item("idLot") = vFrm.MainReturn.Rows(round).Item("idLot")) And
                               (DGVBind.GetDataRow(j).Item("idRefLot") = vFrm.MainReturn.Rows(round).Item("idRefLot")) Then

                            Dim CalAmt As Double = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(j).Item("idUnit"), DGVBind.GetDataRow(j).Item("idInvGroup"),
                                                                   CDbl(DGVBind.GetDataRow(j).Item("OldAmt")), DGVBind.GetDataRow(j).Item("idInvMain"))


                            SumStockinBill = SumStockinBill + CalAmt
                        End If

                    End If
                Next

                If vFrm.MainReturn.Rows(round).Item("idInvGroup") <> 30 Then
                    If IsDBNull(vFrm.MainReturn.Rows(round).Item("AmtStock")) Then
                        DGVBind.SetFocusedRowCellValue("AmtStock", SumStockinBill)
                    Else
                        DGVBind.SetFocusedRowCellValue("AmtStock", vFrm.MainReturn.Rows(round).Item("AmtStock") + SumStockinBill)

                    End If
                ElseIf vFrm.MainReturn.Rows(round).Item("idInvGroup") = 30 Then
                    'ถ้าเป็น idInvGroup = 30 ให้ Stock = 0
                    DGVBind.SetFocusedRowCellValue("AmtStock", 1)
                End If

                If IsDBNull(vFrm.MainReturn.Rows(round).Item("idLot")) Then
                    DGVBind.SetFocusedRowCellValue("idLot", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("idLot", vFrm.MainReturn.Rows(round).Item("idLot"))
                End If

                DGVBind.SetFocusedRowCellValue("UnitName", vFrm.MainReturn.Rows(round).Item("UnitName"))

                If IsDBNull(vFrm.MainReturn.Rows(round).Item("idUnit")) Then
                    DGVBind.SetFocusedRowCellValue("idUnit", 0)
                Else
                    DGVBind.SetFocusedRowCellValue("idUnit", vFrm.MainReturn.Rows(round).Item("idUnit"))
                End If

                DGVBind.SetFocusedRowCellValue("AmtSale", vFrm.MainReturn.Rows(round).Item("AmtSale"))
                DGVBind.SetFocusedRowCellValue("Total", LastPrice * vFrm.MainReturn.Rows(round).Item("AmtSale"))
                DGVBind.SetFocusedRowCellValue("AmtSaleHide", vFrm.MainReturn.Rows(round).Item("AmtSale"))
                DGVBind.SetFocusedRowCellValue("CompRec", vFrm.MainReturn.Rows(round).Item("CompRec"))

                DGVBind.RefreshData()

                Dim AmountUse As Double = 0.0
                Dim SumAmtOfLot As Double = 0.0

                For j As Integer = 0 To DGVBind.DataRowCount - 1
                    If (DGVBind.GetDataRow(j).Item("idLot") = vFrm.MainReturn.Rows(round).Item("idLot")) And
                               (DGVBind.GetDataRow(j).Item("idRefLot") = vFrm.MainReturn.Rows(round).Item("idRefLot")) Then

                        AmountUse = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(j).Item("idUnit"), DGVBind.GetDataRow(j).Item("idInvGroup"),
                                                                   CDbl(DGVBind.GetDataRow(j).Item("AmtSale")), DGVBind.GetDataRow(j).Item("idInvMain"))

                        SumAmtOfLot = SumAmtOfLot + AmountUse

                        SumAmtOfLot = Math.Round(SumAmtOfLot, 6, MidpointRounding.AwayFromZero)

                        If DGVBind.GetDataRow(j).Item("AmtStock") < SumAmtOfLot Then  ' Stock < AllSaleAmount
                            Dim ShowUnit As String = ""

                            If DGVBind.GetDataRow(j).Item("idUnit") = 1 Then '"กรัม" Then
                                ShowUnit = "กิโลกรัม"
                            Else
                                ShowUnit = DGVBind.GetDataRow(j).Item("UnitName")
                            End If

                            MessageBox.Show("จำนวนสินค้าคงเหลือใน Stock ไม่เพียงพอต่อความต้องการ" & vbCrLf &
                                                "(จำนวนขายรวม : " & Format(SumAmtOfLot, "#,##0.00##") & " " & ShowUnit &
                                                " แต่จำนวน Stock คงเหลือ : " & Format(DGVBind.GetDataRow(j).Item("AmtStock"), "#,##0.00##") & " " & ShowUnit & ")", sSystemName)

                            DGVBind.SetRowCellValue(j, "AmtSale", 0)

                        End If
                    End If
                Next

                For j As Integer = 0 To tempDelete.Rows.Count - 1 ' รายการที่ลบ : ไม่แสดงใน gridview
                    If IsDBNull(tempDelete.Rows(j).Item("idLot")) Then
                        tempDelete.Rows(j).Item("idLot") = 0
                    End If

                    If (tempDelete.Rows(j).Item("idLot") = vFrm.MainReturn.Rows(round).Item("idLot")) And
                          (tempDelete.Rows(j).Item("idRefLot") = vFrm.MainReturn.Rows(round).Item("idRefLot")) Then
                        If IsDBNull(tempDelete.Rows(j).Item("AmtDel")) Then
                            SumStockinBill = SumStockinBill
                        Else
                            SumStockinBill = SumStockinBill + tempDelete.Rows(j).Item("AmtDel")
                        End If

                    End If
                Next
            Next

        End If  ' End dialogresult 

        DGVBind.RefreshData()
        mdLoadCommitt()
        SumTotalNew()

    End Sub

    Private Sub txtBillSaleCont_Leave(sender As Object, e As EventArgs) Handles txtBillSaleCont.Leave
        If eEvent <> eProcess.eView And eEvent <> eProcess.eAccept And eEvent <> eProcess.eCheck And eEvent <> eProcess.eApprove Then  'view/Accept/Check/Approve
            If Trim(Me.txtBillSaleCont.Text) <> "" Then
                mdCnOpen()
                Dim dtBillCont As New DataTable
                Dim dtOrder As New DataTable
                Dim txtBillSaleCont As String = Me.cmbBillSaleCont.Text & " " & Trim(Me.txtBillSaleCont.Text)
                sCommand.CommandText = "Select oMt.idSaleOrder, sMt.idSale " & vbNewLine &
                                        "FROM SmSaleOrderDt oDt" & vbNewLine &
                                        "LEFT JOIN SmSaleOrderMt oMt On oDt.idSaleOrder = oMt.idSaleOrder" & vbNewLine &
                                        "LEFT JOIN SmSaleDtAll sDt On oDt.idSaleOrderDt = sDt.idSaleOrderDt" & vbNewLine &
                                        "LEFT JOIN SmSaleMt sMt On sDt.idSale = sMt.idSale" & vbNewLine &
                                        "WHERE sMt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                        "And sMt.idPartner = " & idPartner & vbNewLine &
                                        "And sMt.DocRef = '" & Trim(txtBillSaleCont) & "'" & vbNewLine &
                                        "AND sMt.idPsCancel Is NULL"
                sAdapter.Fill(dtBillCont)

                If dtBillCont.Rows.Count = 0 Then
                    MessageBox.Show("กรุณาตรวจสอบ!!" & vbNewLine &
                                    "ไม่พบข้อมูลเลขที่อ้างอิง " & txtBillSaleCont, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    idSaleOrder_BillCont = dtBillCont.Rows(0).Item("idSaleOrder")
                End If
                mdLoadCommitt()
            End If
        End If

    End Sub


    '
    'Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
    '    If Me.lblPsCus.Text = "" Then
    '        MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการเลือกสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Exit Sub
    '    End If

    '    Dim strIDSel As String = "0"

    '    If DGVBind.DataRowCount > 0 Then
    '        strIDSel = DGVBind.GetRowCellValue(0, Col_idSaleOrderDt)
    '        For i As Integer = 1 To DGVBind.DataRowCount - 1
    '            strIDSel = strIDSel & "," & DGVBind.GetRowCellValue(i, Col_idSaleOrderDt)
    '        Next
    '    End If


    '    Dim vFrm As New frmSlOrderToSale(frmSlOrderToSale.eProcess.eBackOrder, lblPsCus.Text, idPartner, cmbGroupComp.SelectedValue, strIDSel)
    '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        For round As Integer = 0 To vFrm.gMainReturn.Rows.Count - 1

    '            Dim defaultAmtSale As Double = 0
    '            Dim PriceNormal As Double = 0
    '            Dim LastPrice As Double = 0.0 'ราคาขายล่าสุด

    '            Dim dtLastPrice As New DataTable
    '            Dim gLastPrice As Double = 0.0
    '            sCommand.CommandText = "SELECT TOP(1) ISNULL(dt.Price,0) As LastPrice " & vbNewLine &
    '                                    "FROM SmSaleDtAll dt " & vbNewLine &
    '                                    "LEFT OUTER JOIN SmSaleMt mt ON dt.idsale = mt.idSale " & vbNewLine &
    '                                    "WHERE mt.idPartner = " & idPartner & vbNewLine &
    '                                    "AND dt.idProduct =  " & vFrm.gMainReturn.Rows(round).Item("idInvMain") & vbNewLine &
    '                                    "AND mt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
    '                                    "AND ISNULL(dt.Price,0) > 0" & vbNewLine &
    '                                    "Order by mt.DateSale DESC "
    '            sAdapter.Fill(dtLastPrice)

    '            If dtLastPrice.Rows.Count <> 0 Then
    '                gLastPrice = dtLastPrice.Rows(0).Item("LastPrice")
    '            End If

    '            '---Default จำนวนขาย
    '            If vFrm.gMainReturn.Rows(round).Item("AmtStock") >= 1 And cmbGroupComp.SelectedValue <> 2 Then
    '                defaultAmtSale = 1
    '            Else
    '                If Not IsDBNull(vFrm.gMainReturn.Rows(round).Item("AmtStock")) Then
    '                    defaultAmtSale = vFrm.gMainReturn.Rows(round).Item("AmtStock")
    '                End If
    '            End If

    '            If Me.rdbWhole.Checked = True Then
    '                PriceNormal = vFrm.gMainReturn.Rows(round).Item("PriceWholesale_fg")
    '            ElseIf Me.rdbRetail.Checked = True Then
    '                PriceNormal = vFrm.gMainReturn.Rows(round).Item("PriceRetail_fg")
    '            ElseIf Me.rdbBill.Checked = True Then
    '                PriceNormal = vFrm.gMainReturn.Rows(round).Item("PriceBill_fg")
    '            End If

    '            If vFrm.gMainReturn.Rows(round).Item("idPdoType") = 3 Then  ' พลาสติกคลุมดิน
    '                If Me.cmbTp.SelectedValue = 49 Then  ' credit 30
    '                    PriceNormal = vFrm.gMainReturn.Rows(round).Item("CreditThirty_pdo")
    '                    If gLastPrice <> 0 Then
    '                        LastPrice = gLastPrice
    '                    Else
    '                        LastPrice = vFrm.gMainReturn.Rows(round).Item("CreditThirty_pdo")
    '                    End If

    '                ElseIf Me.cmbTp.SelectedValue = 50 Then  ' credit 60
    '                    PriceNormal = vFrm.gMainReturn.Rows(round).Item("CreditSixty_pdo")
    '                    If gLastPrice <> 0 Then
    '                        LastPrice = gLastPrice
    '                    Else
    '                        LastPrice = vFrm.gMainReturn.Rows(round).Item("CreditSixty_pdo")
    '                    End If

    '                Else  ' Other
    '                    PriceNormal = vFrm.gMainReturn.Rows(round).Item("PricePdo_pdo")
    '                    If gLastPrice <> 0 Then
    '                        LastPrice = gLastPrice
    '                    Else
    '                        LastPrice = vFrm.gMainReturn.Rows(round).Item("PricePdo_pdo")
    '                    End If
    '                End If

    '            ElseIf vFrm.gMainReturn.Rows(round).Item("idInvGroup") <> 2 Then  ' Other Type except FG (idInvGroup = 2)
    '                If IsDBNull(vFrm.gMainReturn.Rows(round).Item("PricePdo_pdo")) Then
    '                    PriceNormal = 0.0
    '                Else
    '                    PriceNormal = vFrm.gMainReturn.Rows(round).Item("PricePdo_pdo")
    '                End If
    '            End If

    '            If vFrm.gMainReturn.Rows(round).Item("idInvGroup") = 1 Then  ' Other Type except FG (idInvGroup = 2)
    '                PriceNormal = vFrm.gMainReturn.Rows(round).Item("PriceSeed")
    '            End If

    '            If PriceNormal <> 0 Then
    '                LastPrice = PriceNormal
    '            Else
    '                LastPrice = gLastPrice
    '                PriceNormal = gLastPrice
    '            End If

    '            DGVBind.AddNewRow()
    '            DGVBind.SetFocusedRowCellValue("PdCode", vFrm.gMainReturn.Rows(round).Item("InvCode"))
    '            DGVBind.SetFocusedRowCellValue("LotNo", "")

    '            If IsDBNull(vFrm.gMainReturn.Rows(round).Item("idInvMain")) Then
    '                DGVBind.SetFocusedRowCellValue("idInvMain", 0)
    '            Else
    '                DGVBind.SetFocusedRowCellValue("idInvMain", vFrm.gMainReturn.Rows(round).Item("idInvMain"))
    '            End If

    '            DGVBind.SetFocusedRowCellValue("ProductName", vFrm.gMainReturn.Rows(round).Item("InvName"))

    '            DGVBind.SetFocusedRowCellValue("AmtOrder", 0)
    '            DGVBind.SetFocusedRowCellValue("OldAmt", 0)

    '            DGVBind.SetFocusedRowCellValue("PriceNormal", PriceNormal)
    '            DGVBind.SetFocusedRowCellValue("PercDisc", 0.0)
    '            DGVBind.SetFocusedRowCellValue("BathDisc", 0.0)
    '            DGVBind.SetFocusedRowCellValue("PriceSale", LastPrice)
    '            DGVBind.SetFocusedRowCellValue("Total", LastPrice)
    '            DGVBind.SetFocusedRowCellValue("idSaleDt", 0)
    '            DGVBind.SetFocusedRowCellValue("idRefLot", 0)
    '            DGVBind.SetFocusedRowCellValue("CompRec", 0)
    '            DGVBind.SetFocusedRowCellValue("idUnitW", vFrm.gMainReturn.Rows(round).Item("idUnitW"))
    '            DGVBind.SetFocusedRowCellValue("pWeight", vFrm.gMainReturn.Rows(round).Item("pWeight"))

    '            DGVBind.SetFocusedRowCellValue("idWh", 0)
    '            DGVBind.SetFocusedRowCellValue("idLotSPM", 0)


    '            If IsDBNull(vFrm.gMainReturn.Rows(round).Item("idInvGroup")) Then
    '                DGVBind.SetFocusedRowCellValue("idInvGroup", 0)
    '            Else
    '                DGVBind.SetFocusedRowCellValue("idInvGroup", vFrm.gMainReturn.Rows(round).Item("idInvGroup"))
    '            End If

    '            If IsDBNull(vFrm.gMainReturn.Rows(round).Item("DtType")) Then
    '                DGVBind.SetFocusedRowCellValue("DtType", 0)
    '            Else
    '                DGVBind.SetFocusedRowCellValue("DtType", vFrm.gMainReturn.Rows(round).Item("DtType"))
    '            End If

    '            If IsDBNull(vFrm.gMainReturn.Rows(round).Item("idSubType")) Then
    '                DGVBind.SetFocusedRowCellValue("idSubType", 0)
    '            Else
    '                DGVBind.SetFocusedRowCellValue("idSubType", vFrm.gMainReturn.Rows(round).Item("idSubType"))
    '            End If

    '            'check stock : หัก stock ของ rows ก่อนหน้า
    '            Dim SumStockinBill As Double = 0.0

    '            For j As Integer = 0 To DGVBind.DataRowCount - 1
    '                If IsDBNull(vFrm.gMainReturn.Rows(round).Item("idLot")) Then
    '                    vFrm.gMainReturn.Rows(round).Item("idLot") = 0
    '                End If

    '                If vFrm.gMainReturn.Rows(round).Item("idLot") <> 0 Then
    '                    If (DGVBind.GetDataRow(j).Item("idLot") = vFrm.gMainReturn.Rows(round).Item("idLot")) And
    '                       (DGVBind.GetDataRow(j).Item("idRefLot") = vFrm.gMainReturn.Rows(round).Item("idRefLot")) Then

    '                        Dim CalAmt As Double = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(j).Item("idUnit"), DGVBind.GetDataRow(j).Item("idInvGroup"),
    '                                                           CDbl(DGVBind.GetDataRow(j).Item("OldAmt")), DGVBind.GetDataRow(j).Item("idInvMain"))


    '                        SumStockinBill = SumStockinBill + CalAmt
    '                    End If

    '                End If
    '            Next

    '            If vFrm.gMainReturn.Rows(round).Item("idInvGroup") <> 30 Then
    '                If IsDBNull(vFrm.gMainReturn.Rows(round).Item("AmtStock")) Then
    '                    DGVBind.SetFocusedRowCellValue("AmtStock", SumStockinBill)
    '                Else
    '                    DGVBind.SetFocusedRowCellValue("AmtStock", vFrm.gMainReturn.Rows(round).Item("AmtStock") + SumStockinBill)

    '                End If
    '            ElseIf vFrm.gMainReturn.Rows(round).Item("idInvGroup") = 30 Then
    '                'ถ้าเป็น idInvGroup = 30 ให้ Stock = 0
    '                DGVBind.SetFocusedRowCellValue("AmtStock", 1)
    '            End If

    '            DGVBind.SetFocusedRowCellValue("idLot", 0)

    '            DGVBind.SetFocusedRowCellValue("UnitName", vFrm.gMainReturn.Rows(round).Item("UnitName"))

    '            DGVBind.SetFocusedRowCellValue("idUnit", 0)

    '            DGVBind.SetFocusedRowCellValue("AmtSale", defaultAmtSale)
    '            DGVBind.RefreshData()

    '        Next


    '        SumTotalNew()
    '    End If

    'End Sub


End Class
