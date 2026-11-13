Imports System.Net
Imports System.IO
Imports System.Data.SqlClient
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmSlOrderTs
    Dim MainDt As New DataTable
    Dim eEvent As eProcess
    Dim idSaleOrder_ As Integer
    Private _dt As New DataTable
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")

    'Dim idPdPk As String
    'Dim PdCodeA As String
    'Dim PdPkNameA As String
    'Dim WeightPd As Double
    'Dim UnitA As String
    'Dim idUnitA As String
    'Dim idPkUnitA As String
    Dim Result As DialogResult
    'Dim idSaleOrderS As String
    'Dim PerBoxA As Integer
    'Dim BarCodeA As String
    'Dim ShortNameA As String
    Public Pdidpk As String
    Public OrderAmt As Integer
    Public UnitPk As Integer
    Public Perbox As Integer
    Public AmtWeight As Integer
    Public OrderUnit As Integer
    'Public PsCustomer As String
    ' Public idPsCus As String

    ' Dim flDt As New DataTable
    ' Dim stBtn As Integer = 0
    Public sDt_flagpic_Rec As New DataTable
    'Dim idSaleOrDtDel As New DataTable
    ' Dim f As Integer = 0
    ' Dim lastIndexColCell As Integer = 0 'Tab Grid

    Enum eProcess
        eAdd
        eEdit
        eShow
        eClose
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idSaleOrder As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eAdd
                Me.Text = "ทำรายการสั่งซื้อสินค้า"
                lblDateTs.Text = Date.Today
                lblPsTs.Text = sPsName
                lblPsTs.Tag = sPsId
                lblPsOrder.Text = sPsName
                lblPsOrder.Tag = sPsId
                'Me.btnSave.Visible = True
                Panel8.Visible = True

            Case eProcess.eEdit
                Me.Text = "แก้ไขรายการสั่งซื้อสินค้า"

            Case eProcess.eClose
                Me.Text = "ทำรายการปิดการสั่งซื้อ"
                dtpOrder.Enabled = False
                dtpRequire.Enabled = False
                btnPsCus.Visible = False
                btnPsOrder.Visible = False
                btnPsSale.Visible = False
                txtNote.Enabled = False

                btnNewPd.Visible = False

                ColDel.Visible = False
                ColAmtSale.Visible = True
                ColAmtBal.Visible = True
                ColSel.Visible = True
                'ColStatus.Visible = True

                ColSel.VisibleIndex = 0
                ColNum.VisibleIndex = 1
                ColPdCode.VisibleIndex = 2
                ColProductName.VisibleIndex = 3
                ColAmount.VisibleIndex = 4
                ColAmtSale.VisibleIndex = 5
                ColAmtBal.VisibleIndex = 6
                ColidUnit.VisibleIndex = 7
                ColNoteDt.VisibleIndex = 8
                'ColStatus.Visible = 9
                ColAmtSale.OptionsColumn.ReadOnly = True
                ColAmtSale.OptionsColumn.AllowEdit = False
                ColAmtBal.OptionsColumn.ReadOnly = True
                ColAmtBal.OptionsColumn.AllowEdit = False

                ColPdCode.OptionsColumn.ReadOnly = True
                ColPdCode.OptionsColumn.AllowEdit = False

                ColProductName.OptionsColumn.ReadOnly = True
                ColProductName.OptionsColumn.AllowEdit = False

                ColAmount.OptionsColumn.ReadOnly = True
                ColAmount.OptionsColumn.AllowEdit = False

                ColidUnit.OptionsColumn.ReadOnly = True
                ColidUnit.OptionsColumn.AllowEdit = False

                ColNoteDt.OptionsColumn.ReadOnly = True
                ColNoteDt.OptionsColumn.AllowEdit = False


                GvOrder.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
                GvOrder.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                Panel2.Visible = True
                Panel8.Visible = False
                Panel1.Visible = False
                Panel4.Visible = True
            Case eProcess.eShow
                Me.Text = "ข้อมูลรายการสั่งซื้อสินค้า"
                dtpOrder.Enabled = False
                dtpRequire.Enabled = False
                btnPsCus.Visible = False
                btnPsOrder.Visible = False
                btnPsSale.Visible = False
                txtNote.Enabled = False
                'btnSave.Visible = False
                Panel8.Visible = False
                btnNewPd.Visible = False
                ColDel.Visible = False

                ColPdCode.OptionsColumn.ReadOnly = True
                ColPdCode.OptionsColumn.AllowEdit = False
                ColProductName.OptionsColumn.ReadOnly = True
                ColProductName.OptionsColumn.AllowEdit = False
                ColAmount.OptionsColumn.ReadOnly = True
                ColAmount.OptionsColumn.AllowEdit = False
                ColidUnit.OptionsColumn.ReadOnly = True
                ColidUnit.OptionsColumn.AllowEdit = False
                ColNoteDt.OptionsColumn.ReadOnly = True
                ColNoteDt.OptionsColumn.AllowEdit = False
        End Select

        idSaleOrder_ = idSaleOrder
        eEvent = aProcess

        ' Ctrl_TabStop(Me)
    End Sub

    Private Sub frmSlOrderTs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setCmbGroupComp(cmbGroupComp)

        mdCnOpen()
        mdLoadShow()
        SetDatainRpt()

        MainDt.Columns.Add("PdCode", System.Type.GetType("System.String"))
        MainDt.Columns.Add("ProductName", System.Type.GetType("System.String"))
        MainDt.Columns.Add("Price", System.Type.GetType("System.Double"))
        MainDt.Columns.Add("Amount", System.Type.GetType("System.Double"))
        MainDt.Columns.Add("idUnit", System.Type.GetType("System.Int32"))
        MainDt.Columns.Add("NoteDt", System.Type.GetType("System.String"))
        MainDt.Columns.Add("idSaleOrderDt", System.Type.GetType("System.Int64"))
        MainDt.Columns.Add("idInvMain", System.Type.GetType("System.Int64"))
        MainDt.Columns.Add("idInvGroup", System.Type.GetType("System.Int32"))
        MainDt.Columns.Add("idSubType", System.Type.GetType("System.Int32"))
        MainDt.Columns.Add("idUnitPd", System.Type.GetType("System.Int32"))
        MainDt.Columns.Add("Perbox", System.Type.GetType("System.Int32"))
        MainDt.Columns.Add("AmtSale", System.Type.GetType("System.Double"))

        Select Case eEvent
            Case eProcess.eAdd
                GcOrder.DataSource = MainDt
            Case eProcess.eShow, eProcess.eEdit, eProcess.eClose
                BindData()
        End Select

        mdLoadCommitt()
    End Sub

    Private Sub BindData()
        '------Show vSmSaleOrderMt----'
        Dim vDt As New DataTable
        vDt.Clear()
        sCommand.CommandText = "SELECT m.idComp, m.DocCode, FORMAT(m.DateOrderD, 'd', 'th') As DateOrderD, " & vbNewLine &
                               "FORMAT(m.DateRequireD, 'd', 'th') As DateRequireD, " & vbNewLine &
                               "ISNULL(m.DateTsD, '') As DateTsD, c.PartnerName, m.idPartner, " & vbNewLine &
                               "c.pNote, m.idPsSale, p1.PsName As PsSale, m.idPsOrder, " & vbNewLine &
                               "(CASE m.idPsOrder WHEN 0 THEN 'System' ELSE P2.PsName END) As PsOrder, " & vbNewLine &
                               "(CASE m.idPsTs WHEN 0 THEN 'System' ELSE p3.PsName END) As PsTs, ISNULL(m.Note,'') As Note" & vbNewLine &
                               "From SmSaleOrderMt m " & vbNewLine &
                               "LEFT JOIN dPartner c ON m.idPartner = c.idPartner " & vbNewLine &
                               "LEFT JOIN vPersonxSelect p1 ON m.idPsSale = p1.idPs " & vbNewLine &
                               "LEFT JOIN vPersonxSelect p2 ON m.idPsOrder = p2.idPs " & vbNewLine &
                               "LEFT JOIN vPersonxSelect p3 ON m.idPsTs = p3.idPs " & vbNewLine &
                               "WHERE m.idSaleOrder = " & idSaleOrder_
        sAdapter.Fill(vDt)

        cmbGroupComp.SelectedValue = vDt.Rows(0).Item("idComp")
        cmbGroupComp.Enabled = False
        lblDocCode.Text = vDt.Rows(0).Item("DocCode")
        dtpOrder.Value = vDt.Rows(0).Item("DateOrderD")

        If Not IsDBNull(vDt.Rows(0).Item("DateRequireD")) Then
            dtpRequire.Value = vDt.Rows(0).Item("DateRequireD")
        End If

        lblDateTs.Text = vDt.Rows(0).Item("DateTsD")
        lblPsCus.Text = vDt.Rows(0).Item("PartnerName")
        lblPsCus.Tag = vDt.Rows(0).Item("idPartner")
        lblCusNote.Text = vDt.Rows(0).Item("pNote")
        If Not IsDBNull(vDt.Rows(0).Item("idPsOrder")) Then
            lblPsOrder.Text = vDt.Rows(0).Item("PsOrder")
            lblPsOrder.Tag = vDt.Rows(0).Item("idPsOrder")
        End If
        If Not IsDBNull(vDt.Rows(0).Item("idPsSale")) Then
            lblPsSale.Text = vDt.Rows(0).Item("PsSale")
            lblPsSale.Tag = vDt.Rows(0).Item("idPsSale")
        End If
        lblPsTs.Text = vDt.Rows(0).Item("PsTs")
        txtNote.Text = vDt.Rows(0).Item("note")

        '----Show SmSaleOrderDt on dgv -----'
        Dim sDt As New DataTable

        sCommand.CommandText = "With A As(SELECT ROW_NUMBER() OVER(PARTITION BY d.idSaleOrder ORDER BY d.idSaleOrderDt) As Num, CONVERT(bit,0) AS Sel," & vbNewLine &
                               "d.idSaleOrder, d.idSaleOrderDt, d.idInvMain, p.InvCode, p.InvName As ProductName, d.Amount, u.UnitName, d.Note As NoteDt, " & vbNewLine &
                               "p.idUnit As idUnitPd, p.idInvGroup, d.idUnit, " & vbNewLine &
                               "ISNULL((SELECT Perbox FROm dPackingPdSet WHERE idpdPk = p.idSubType ANd p.idInvGroup = 2), 0) As Perbox," & vbNewLine &
                               "ISNULL((SELECT SUM(Amount) " & vbNewLine &
                                       "FROM SmSaleDtAll dt" & vbNewLine &
                                       "LEFT JOIN SmSaleMt mt ON dt.idSale = mt.idSale" & vbNewLine &
                                       "Where dt.idSaleOrderDt = d.idSaleOrderDt" & vbNewLine &
                                       "And mt.idPsCanCel IS NULL " & vbNewLine &
                                       "And idSlAVxST Is NULL" & vbNewLine &
                                       "AND d.idPscancel Is NULL),0) As AmtSale, ISNULL(d.Price, 0) As Price " & vbNewLine &
                               "FROM SmSaleOrderDt d " & vbNewLine &
                               "LEFT OUTER JOIN SmSaleOrderMt m On d.idSaleOrder = m.idSaleOrder " & vbNewLine &
                               "LEFT OUTER JOIN dInventoryMain p On d.idInvMain = p.idInvMain " & vbNewLine &
                               "LEFT OUTER JOIN dInvUnit u On d.idUnit = u.idUnit  " & vbNewLine &
                               "WHERE d.idSaleOrder = " & idSaleOrder_ & vbNewLine &
                               "AND d.idPsCancel Is NULL) " & vbNewLine &
                               "SELECT *, (Amount-AmtSale) As AmtBal, CASE WHEN (Amount-AmtSale) = 0 THEN 1  ELSE 0 END As stBal " & vbNewLine &
                               "--CASE WHEN (Amount-AmtSale) = 0 THEN 'ขายหมดแล้ว' WHEN (Amount-AmtSale) > 0 THEN 'ขายแล้วบางส่วน' ELSE 'ยังไม่เปิดบิล' END As stBal " & vbNewLine &
                               "FROM A " & vbNewLine &
                               "Order by idSaleOrderDt ASC"
        'sCommand.CommandText = "SELECT CONVERT(bit,0) AS Sel, d.idSaleOrderDt, inv.InvCode As PdCode, inv.InvName As ProductName, d.Amount, d.idUnit, d.Note As NoteDt, " & vbNewLine &
        '                       "d.idInvMain, inv.idInvGroup, inv.idSubType, inv.idUnit As idUnitPd, " & vbNewLine &
        '                       "ISNULL((SELECT Perbox FROm dPackingPdSet WHERE idpdPk = inv.idSubType ANd inv.idInvGroup = 2), 0) As Perbox," & vbNewLine &
        '                       "ISNULL((SELECT SUM(Amount) " & vbNewLine &
        '                               "FROM SmSaleDtAll dt" & vbNewLine &
        '                               "LEFT JOIN SmSaleMt mt ON dt.idSale = mt.idSale" & vbNewLine &
        '                                "Where dt.idSaleOrderDt = d.idSaleOrderDt" & vbNewLine &
        '                                "And mt.idPsCanCel IS NULL " & vbNewLine &
        '                                "And idSlAVxST Is NULL),0) As AmtSale " & vbNewLine &
        '                       "FROM SmSaleOrderDt d " &
        '                       "LEFT JOIN dInventoryMain inv On d.idInvMain = inv.idInvMain " & vbNewLine &
        '                       "LEFT JOIN dInvUnit u On d.idUnit = u.idUnit " & vbNewLine &
        '                       "WHERE d.idSaleOrder = " & idSaleOrder_ & vbNewLine &
        '                       "AND d.idPsCancel Is NULL" & vbNewLine &
        '                       "Order By d.idSaleOrderDt"
        sAdapter.Fill(sDt)
        GcOrder.DataSource = sDt

        MainDt = sDt
        For i As Integer = 0 To sDt.Rows.Count - 1
            Dim dt As DataTable = getDataLookup(sDt.Rows(i).Item("idUnitPd"), sDt.Rows(i).Item("idInvMain"),
                                                sDt.Rows(i).Item("idInvGroup"), sDt.Rows(i).Item("Perbox"))
            GvOrder.SetRowCellValue(i, ColUnit.Name, sDt.Rows(i).Item("idUnit"))
            rptUnit.DropDownRows = dt.Rows.Count
        Next
    End Sub

    Private Sub SetDatainRpt()
        sCommand.CommandText = "Select unit.idUnit, unit.UnitName " & vbNewLine & _
                               "FROM  dInvUnit unit WHERE stDel Is NULL "
        sAdapter.Fill(_dt)

        rptUnit.Columns.Clear()
        rptUnit.Columns.Add(New LookUpColumnInfo("UnitName"))
        rptUnit.DataSource = _dt

        rptUnit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Function getDataLookup(ByVal idUnit As Integer, ByVal idInvMain As Integer, ByVal idInvGroup As Integer, _
                                   ByVal Perbox As Integer) As DataTable
        Dim dtS As DataTable = _dt.Clone
        Dim drs() As DataRow
        Dim StrUnit As String = ""

        mdCnOpen()

        Select Case idInvGroup
            Case 1 'Seeds
                drs = _dt.Select("idUnit In (1,2) ")
            Case 2 'FG
                If Perbox > 0 Then
                    drs = _dt.Select("idUnit In (" & idUnit & ", 1, 2, 5) ")
                Else
                    drs = _dt.Select("idUnit In (" & idUnit & ", 1, 2) ")
                End If
            Case 28, 36, 37, 39 'ปุ๋ย/ยา/สารจับใบ/ฮอรืโมน
                drs = _dt.Select("idUnit In (" & idUnit & ", 5) ")
            Case Else
                Dim idUnitSub As New DataTable
                sCommand.CommandText = "Select idUnit, idSubUnit FROM dInvUnitSub WHERE idInvMain = " & idInvMain
                sAdapter.Fill(idUnitSub)
                If idUnitSub.Rows.Count > 0 Then
                    If idUnit = idUnitSub.Rows(0).Item("idSubUnit") Then
                        StrUnit &= idUnitSub.Rows(0).Item("idSubUnit").ToString + ","
                        For i As Integer = 0 To idUnitSub.Rows.Count - 1
                            StrUnit &= idUnitSub.Rows(i).Item("idUnit").ToString
                            StrUnit &= ","
                        Next
                    Else
                        StrUnit &= idUnit.ToString + ","
                        For i As Integer = 0 To idUnitSub.Rows.Count - 1
                            StrUnit &= idUnitSub.Rows(i).Item("idSubUnit").ToString
                            StrUnit &= ","
                        Next
                    End If
                    drs = _dt.Select("idUnit In(" & StrUnit & ")")
                Else
                    drs = _dt.Select("idUnit = " & idUnit)
                End If
        End Select

        For Each dr As DataRow In drs
            dtS.ImportRow(dr)
        Next
        Return dtS
    End Function

    Private Sub btnPsCus_Click(sender As Object, e As EventArgs) Handles btnPsCus.Click
        Dim eText As String = ""
        If Me.lblPsSale.Text = "" Then
            eText = frmCustomerSelect.eProcess.eSelectAllChkSt
        Else
            eText = frmCustomerSelect.eProcess.ePsSale
        End If

        Dim vFrm As New frmCustomerSelect(eText, cmbGroupComp.SelectedValue)
        If Me.lblPsSale.Text <> "" Then
            vFrm.idPs = Me.lblPsSale.Tag
        End If

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPsCus.Tag = vFrm.idPartner 'Change idCus to idPartner 6/1/2564
            Me.lblPsCus.Text = vFrm.CusName
            Dim idCus As Integer = vFrm.idCus
            If vFrm.Note = "" Then
                lblCusNote.Text = " -"
            Else
                lblCusNote.Text = vFrm.Note
            End If

            '--- Set PsSale ---'
            Dim dt As New DataTable

            sCommand.CommandText = "Select c.idPsSale, p.PsName As PsSaleName, ps.idPM" & vbNewLine &
                                    "FROM SmRegionPsSaleComp c " & vbNewLine &
                                    "LEFT JOIN  SmMkCusPs ps On  c.idRegionC = ps.idRegionC And ps.idComp = c.idComp" & vbNewLine &
                                    "LEFT JOIN vPersonxSelect p On c.idPsSale = p.idPs" & vbNewLine &
                                    "WHERE ps.idCus = " & idCus & vbNewLine &
                                    "And ps.idComp = " & cmbGroupComp.SelectedValue
            sAdapter.Fill(dt)

            If dt.Rows.Count <> 0 Then
                Me.lblPsSale.Text = dt.Rows(0).Item("PsSaleName")
                Me.lblPsSale.Tag = dt.Rows(0).Item("idPsSale")
            Else 'ไม่มีพนักงานขาย
                Dim Dt2 As New DataTable
                Dt2.Clear()
                sCommand.CommandText = "Select TOP 1 idPsSale, p.Psname As PsSale " & vbNewLine &
                                       "FROm SmSaleOrderMt m " & vbNewLine &
                                       "LEFT OUTER JOIN vPersonxSelect p On m.idPsSale = p.idPs " & vbNewLine &
                                       "WHERE m.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                       "And m.idPartner = " & vFrm.idPartner & vbNewLine &
                                       "ORDER By m.idSaleOrder DESC"
                sAdapter.Fill(Dt2)
                If Dt2.Rows.Count <> 0 Then
                    MessageBox.Show("ลูกค้าคนนี้ไม่มีข้อมูลผูกกับพนักงานขาย ระบบจะดึงพนักงานขายที่ลูกค้ามีประวัติการสั่งซื้อครั้งล่าสุด", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.lblPsSale.Text = Dt2.Rows(0).Item("PsSale")
                    Me.lblPsSale.Tag = Dt2.Rows(0).Item("idPsSale")
                Else
                    MessageBox.Show("ไม่พบข้อมูลผูกกับพนักงานขาย และไม่พบประวัติการสั่งซื้อสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub btnPsSale_Click(sender As Object, e As EventArgs) Handles btnPsSale.Click
        If Me.lblPsCus.Text = "" Then
            Dim vFrm As New frmPsSaleSelect(frmPsSaleSelect.eProcess.eNormal, Nothing, "", 0, 1, cmbGroupComp.SelectedValue)
            ' vFrm.GetidComp(cmbGroupComp.SelectedValue)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                lblPsSale.Tag = vFrm.idPs
                lblPsSale.Text = vFrm.SaleName
            End If
        Else
            Dim vFrm As New frmPsSaleSelect(frmPsSaleSelect.eProcess.eNormal, Nothing, Me.lblPsCus.Text, Me.lblPsCus.Tag, 0, cmbGroupComp.SelectedValue)
            ' vFrm.GetidComp(cmbGroupComp.SelectedValue)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                lblPsSale.Tag = vFrm.idPs
                lblPsSale.Text = vFrm.SaleName
            End If
        End If
    End Sub

    Private Sub btnPsOrder_Click(sender As Object, e As EventArgs) Handles btnPsOrder.Click
        Dim vFrm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPsOrder.Tag = vFrm.mId
            Me.lblPsOrder.Text = vFrm.mName
        End If
    End Sub

    Private Sub btnNewPd_Click(sender As Object, e As EventArgs) Handles btnNewPd.Click
        Dim vFrm As New frmAllInvSelect(frmAllInvSelect.eProcess.eMaltiSelect, cmbGroupComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            For i As Integer = 0 To vFrm.sdt1.Rows.Count - 1
                Dim SetPrice As Double = 0.0
                Select Case vFrm.sdt1.Rows(i).Item("idInvGroup")
                    Case 2 'FG
                        SetPrice = vFrm.sdt1.Rows(i).Item("PriceBill_fg")
                    Case 3, 28, 33, 36, 37, 38, 39 'เบ็ดเตล็ด/Hormaone/Fresh/ปุ๋ย/ยา/สารขับใข/อุปกรณ์เกษตร
                        SetPrice = vFrm.sdt1.Rows(i).Item("PricePdo_pdo")
                    Case 29 'Plastic                      
                        SetPrice = vFrm.sdt1.Rows(i).Item("PricePdo_pdo")
                    Case 42 'เมล็ดดอกไม้บรรจุซอง
                        SetPrice = vFrm.sdt1.Rows(i).Item("PriceSeedFg_sfg")
                End Select


                Dim drNew As DataRow = MainDt.NewRow()
                drNew("idsaleOrderDt") = 0
                drNew("ProductName") = vFrm.sdt1.Rows(i).Item("InvName")
                drNew("Price") = SetPrice
                drNew("Amount") = 0
                drNew("idUnit") = vFrm.sdt1.Rows(i).Item("idUnit")
                drNew("Note") = ""
                drNew("idInvMain") = vFrm.sdt1.Rows(i).Item("idInvMain")
                drNew("idInvGroup") = vFrm.sdt1.Rows(i).Item("idInvGroup")
                drNew("idSubType") = vFrm.sdt1.Rows(i).Item("idSubType")
                drNew("Perbox") = vFrm.sdt1.Rows(i).Item("Perbox")

                MainDt.Rows.Add(drNew)
                GcOrder.DataSource = MainDt

                Dim dt As DataTable = getDataLookup(vFrm.sdt1.Rows(i).Item("idUnit"), vFrm.sdt1.Rows(i).Item("idInvMain"),
                                                    vFrm.sdt1.Rows(i).Item("idInvGroup"), vFrm.sdt1.Rows(i).Item("Perbox"))
                GvOrder.SetRowCellValue(i, ColUnit.Name, vFrm.sdt1.Rows(i).Item("idUnit"))
                rptUnit.DropDownRows = dt.Rows.Count
            Next
        End If
    End Sub

    'Private Sub stStockPd(ByVal rowi As Integer)
    '    'Case1:check stock vPackingPdSet
    '    Dim orderAmt As Integer = 0
    '    Dim WeightKg As Double = 0
    '    Dim stAmtStock As Integer = 0

    '    Dim sum_W As Double 'น้ำหนักทั้งหมด
    '    Dim MixPerc As Double
    '    Dim chk_MixPerc As Double 'ค่าน้ำหนักส่วนผสมเพื่อนำไปเปรียบเทียบ
    '    Dim idPd As Integer
    '    Dim Order_BalanceAVS As Double
    '    Dim Order_BalanceOther As Double
    '    Dim chk_Status As Integer
    '    Dim chk_AVS As Integer 'check AVS เก็บค่าว่าพอหรือไม่  0=ไม่พอ  1=พอ
    '    Dim chk_Other As Integer 'check บริษัทอื่นๆ เก็บค่าว่าพอหรือไม่  0=ไม่พอ  1=พอ
    '    Dim Order_BalanceProcess As Double

    '    mdCnOpen()
    '    Dim sDt As New DataTable
    '    sCommand.CommandText = "Select Amount, idPkUnit, Weight, idUnitW, idPdT From vPackingPdSet Where idPdPk='" & dgvExpenseOrder.Rows(rowi).Cells("PdPkid").Value & "'"
    '    sAdapter.Fill(sDt)
    '    If dgvExpenseOrder.Rows(rowi).Cells("colUnit").Value = 1 Or dgvExpenseOrder.Rows(rowi).Cells("colUnit").Value = 2 Or dgvExpenseOrder.Rows(rowi).Cells("colUnit").Value = 4 Or dgvExpenseOrder.Rows(rowi).Cells("colUnit").Value = 6 Then
    '        orderAmt = dgvExpenseOrder.Rows(rowi).Cells("colAmount").Value
    '    ElseIf dgvExpenseOrder.Rows(rowi).Cells("colUnit").Value = 3 Then 'กล่อง
    '        orderAmt = dgvExpenseOrder.Rows(rowi).Cells("colAmount").Value * dgvExpenseOrder.Rows(rowi).Cells("ColPerBox").Value
    '    ElseIf dgvExpenseOrder.Rows(rowi).Cells("colUnit").Value = 5 Then 'kg
    '        If sDt.Rows(0).Item("idUnitW") = 1 Then
    '            WeightKg = sDt.Rows(0).Item("Weight") / 1000
    '        Else
    '            WeightKg = sDt.Rows(0).Item("Weight")
    '        End If
    '        orderAmt = dgvExpenseOrder.Rows(rowi).Cells("colAmount").Value / WeightKg
    '    End If

    '    '******** 1st Case: check stock vPackingPdSet ***************'
    '    If (orderAmt <= sDt.Rows(0).Item("Amount")) And sDt.Rows(0).Item("Amount") > 0 Then
    '        dgvExpenseOrder.Rows(rowi).DefaultCellStyle.BackColor = Color.GreenYellow 'พอ
    '    Else
    '        stAmtStock = 1 'ไม่พอ
    '    End If


    '    If stAmtStock = 1 Then
    '        Dim Formula_Dt As New DataTable
    '        Formula_Dt.Clear()
    '        sCommand.CommandText = "Select idFl,idPd,MixPerc From SlPdIngredient Where idPdT=" & sDt.Rows(0).Item("idPdT") & ""
    '        sAdapter.Fill(Formula_Dt)
    '        Formula_Dt.DefaultView.Sort = "idFl ASC"
    '        If Formula_Dt.Rows.Count = 0 Then
    '            If stBtn = 1 Then
    '                mdLoadCommitt()
    '                MessageBox.Show("ไม่มีข้อมูลส่วนผสมสินค้า จึงไม่สามารถตรวจสอบสต๊อกสินค้าได้ ", sSystemName)
    '            End If

    '            Exit Sub
    '        End If

    '        '******** 2st Case:check material AVS only ***************'
    '        pDataOngrid(sDt.Rows(0).Item("idPdT"))
    '        chk_MixPerc = 0
    '        sum_W = 0
    '        Dim W_Kg As Double = 0
    '        If dgvExpenseOrder.Rows(rowi).Cells("colUnit").Value = 1 Or dgvExpenseOrder.Rows(rowi).Cells("colUnit").Value = 2 Or dgvExpenseOrder.Rows(rowi).Cells("colUnit").Value = 4 Or dgvExpenseOrder.Rows(rowi).Cells("colUnit").Value = 6 Then 'กระป๋อง,ซอง,กระสอบ,ถุง
    '            Order_BalanceAVS = dgvExpenseOrder.Rows(rowi).Cells("colAmount").Value - sDt.Rows(0).Item("Amount")
    '            sum_W = Order_BalanceAVS * sDt.Rows(0).Item("Weight")
    '            If sDt.Rows(0).Item("idUnitW") = 1 Then 'กรัม แปลงเป็น กก
    '                sum_W = sum_W / 1000
    '            End If
    '        ElseIf dgvExpenseOrder.Rows(rowi).Cells("colUnit").Value = 3 Then 'กล่อง
    '            Perbox = dgvExpenseOrder.Rows(rowi).Cells("ColPerBox").Value
    '            Order_BalanceAVS = (dgvExpenseOrder.Rows(rowi).Cells("colAmount").Value * Perbox) - sDt.Rows(0).Item("Amount")
    '            sum_W = Order_BalanceAVS * sDt.Rows(0).Item("Weight")
    '            If sDt.Rows(0).Item("idUnitW") = 1 Then 'กรัม แปลงเป็น กก
    '                sum_W = sum_W / 1000
    '            End If
    '        ElseIf dgvExpenseOrder.Rows(rowi).Cells("colUnit").Value = 5 Then 'กก
    '            If sDt.Rows(0).Item("idUnitW") = 1 Then 'กรัม แปลงเป็น กก
    '                W_Kg = sDt.Rows(0).Item("Weight") / 1000
    '            Else
    '                W_Kg = sDt.Rows(0).Item("Weight")
    '            End If
    '            Order_BalanceAVS = dgvExpenseOrder.Rows(rowi).Cells("colAmount").Value - (sDt.Rows(0).Item("Amount") * W_Kg)
    '            sum_W = Order_BalanceAVS
    '        End If
    '        Dim count As Integer = 0 'ตัวนับจำนวนส่วนผสมในแต่ละสูตร
    '        Dim j As Integer = 0
    '        For i As Integer = 0 To Formula_Dt.Rows.Count - 1
    '            chk_AVS = 0
    '            count = 0
    '            For j = i To Formula_Dt.Rows.Count - 1
    '                If Formula_Dt.Rows.Item(i).Item("idFl") = Formula_Dt.Rows.Item(j).Item("idFl") Then
    '                    idPd = Formula_Dt.Rows.Item(j).Item("idPd")
    '                    MixPerc = Formula_Dt.Rows.Item(j).Item("MixPerc")
    '                    chk_MixPerc = sum_W * (MixPerc / 100)
    '                    'check ส่วนผสมใน stock AVS
    '                    For n As Integer = 0 To flDt.Rows.Count - 1
    '                        If idPd = flDt.Rows.Item(n).Item("idPd") Then
    '                            If chk_MixPerc <= flDt.Rows(n).Item("Balance_avs") Then
    '                                chk_AVS = chk_AVS + 1 'พอ
    '                            Else
    '                                chk_AVS = chk_AVS + 0 'ไม่พอ
    '                            End If
    '                            Exit For
    '                        End If
    '                    Next
    '                    count += 1
    '                Else
    '                    j = j - 1
    '                    Exit For
    '                End If
    '            Next
    '            If count = chk_AVS Then
    '                dgvExpenseOrder.Rows(rowi).DefaultCellStyle.BackColor = Color.Khaki ' material avs stock พอ
    '                dgvExpenseOrder.Rows(rowi).Cells("colProduct").Style.BackColor = Color.Khaki
    '                dgvExpenseOrder.Rows(rowi).Cells("colCountExp").Style.BackColor = Color.Khaki
    '                dgvExpenseOrder.Rows(rowi).Cells("ColPerBox").Style.BackColor = Color.Khaki
    '                chk_Status = 1 'พอ
    '                mdLoadCommitt()
    '                Exit Sub
    '            End If
    '            i = j
    '        Next
    '        If count <> chk_AVS Then
    '            'MessageBox.Show("ส่วนผสมใน AVS ไม่เพียงพอต่อความต้องการ ", sSystemName)
    '            chk_Status = 0 'ไม่พอ
    '        End If

    '        '******** 3nd Case: check material Green + Flo ***************'
    '        '###### ใน AVS ไม่พอ >>> Check บริษัท อื่นๆ #####################
    '        If chk_Status = 0 Then
    '            For i As Integer = 0 To Formula_Dt.Rows.Count - 1
    '                chk_Other = 0
    '                count = 0
    '                For j = i To Formula_Dt.Rows.Count - 1
    '                    If Formula_Dt.Rows.Item(i).Item("idFl") = Formula_Dt.Rows.Item(j).Item("idFl") Then
    '                        idPd = Formula_Dt.Rows.Item(j).Item("idPd")
    '                        MixPerc = Formula_Dt.Rows.Item(j).Item("MixPerc")
    '                        chk_MixPerc = sum_W * (MixPerc / 100)
    '                        'check ส่วนผสมใน stock AVS
    '                        For n As Integer = 0 To flDt.Rows.Count - 1
    '                            Dim id_ As Integer = flDt.Rows.Item(n).Item("idPd")
    '                            Dim Name_ As String = flDt.Rows.Item(n).Item("PdName")
    '                            If idPd = flDt.Rows.Item(n).Item("idPd") Then
    '                                Dim sum_Other As Double = flDt.Rows(n).Item("S6_Green") + flDt.Rows(n).Item("S6_Flo")
    '                                Order_BalanceOther = chk_MixPerc - flDt.Rows(n).Item("Balance_avs")
    '                                If Order_BalanceOther <= sum_Other Then
    '                                    chk_Other = chk_Other + 1 'พอ
    '                                Else
    '                                    chk_Other = chk_Other + 0 'ไม่พอ
    '                                End If
    '                                Exit For
    '                            End If
    '                        Next
    '                        count += 1
    '                    Else
    '                        j = j - 1
    '                        Exit For
    '                    End If
    '                Next
    '                If count = chk_Other Then
    '                    dgvExpenseOrder.Rows(rowi).DefaultCellStyle.BackColor = Color.MediumPurple ' material avs + green + Flo พอ
    '                    dgvExpenseOrder.Rows(rowi).Cells("colProduct").Style.BackColor = Color.MediumPurple
    '                    dgvExpenseOrder.Rows(rowi).Cells("colCountExp").Style.BackColor = Color.MediumPurple
    '                    dgvExpenseOrder.Rows(rowi).Cells("ColPerBox").Style.BackColor = Color.MediumPurple
    '                    chk_Status = 1 'พอ
    '                    Exit For
    '                End If
    '                i = j
    '            Next
    '            If count <> chk_Other Then
    '                chk_Status = 0 'ไม่พอ
    '            End If
    '        End If

    '        '******** 4nd Case: check between processes Green + Flo ***************'
    '        '###### บริษัท อื่นๆ ไม่พอ >>>> check เมล็ดระหว่างกระบวนการ Green + Flo #####################
    '        If chk_Status = 0 Then
    '            For i As Integer = 0 To Formula_Dt.Rows.Count - 1
    '                ' idFl_ = Formula_Dt.Rows.Item(i).Item("idFl")
    '                chk_Other = 0
    '                count = 0
    '                For j = i To Formula_Dt.Rows.Count - 1
    '                    If Formula_Dt.Rows.Item(i).Item("idFl") = Formula_Dt.Rows.Item(j).Item("idFl") Then
    '                        idPd = Formula_Dt.Rows.Item(j).Item("idPd")
    '                        MixPerc = Formula_Dt.Rows.Item(j).Item("MixPerc")
    '                        chk_MixPerc = sum_W * (MixPerc / 100)
    '                        'check ส่วนผสมใน stock AVS
    '                        For n As Integer = 0 To flDt.Rows.Count - 1
    '                            Dim id_ As Integer = flDt.Rows.Item(n).Item("idPd")
    '                            Dim Name_ As String = flDt.Rows.Item(n).Item("PdName")
    '                            If idPd = flDt.Rows.Item(n).Item("idPd") Then
    '                                Order_BalanceProcess = chk_MixPerc - flDt.Rows(n).Item("Balance_avs") - (flDt.Rows(n).Item("S6_Green") + flDt.Rows(n).Item("S6_Flo"))
    '                                If Order_BalanceProcess <= flDt.Rows(n).Item("BalancePc_") Then
    '                                    chk_Other = chk_Other + 1 'พอ
    '                                Else
    '                                    chk_Other = chk_Other + 0 'ไม่พอ
    '                                End If
    '                                Exit For
    '                            End If
    '                        Next
    '                        count += 1
    '                    Else
    '                        j = j - 1
    '                        Exit For
    '                    End If
    '                Next
    '                If count = chk_Other Then
    '                    dgvExpenseOrder.Rows(rowi).DefaultCellStyle.BackColor = Color.DarkOrange ' material avs + green + Flo พอ
    '                    dgvExpenseOrder.Rows(rowi).Cells("colProduct").Style.BackColor = Color.DarkOrange
    '                    dgvExpenseOrder.Rows(rowi).Cells("colCountExp").Style.BackColor = Color.DarkOrange
    '                    dgvExpenseOrder.Rows(rowi).Cells("ColPerBox").Style.BackColor = Color.DarkOrange
    '                    chk_Status = 1 'พอ
    '                    Exit For
    '                End If
    '                i = j
    '            Next
    '            If count <> chk_Other Then
    '                dgvExpenseOrder.Rows(rowi).DefaultCellStyle.BackColor = Color.Salmon
    '                dgvExpenseOrder.Rows(rowi).Cells("colProduct").Style.BackColor = Color.Salmon
    '                dgvExpenseOrder.Rows(rowi).Cells("colCountExp").Style.BackColor = Color.Salmon
    '                dgvExpenseOrder.Rows(rowi).Cells("ColPerBox").Style.BackColor = Color.Salmon
    '                chk_Status = 0 'ไม่พอ
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub pDataOngrid(ByVal idPdT As String)
    '    mdCnOpen()
    '    Dim vDt_ As New DataTable
    '    Dim vFields As String = ""

    '    vFields = "idPd, PdName, SeedTypeName, "
    '    vFields &= "ISNULL((SELECT SUM(Amount) FROM dbo.PkPdLotStock WHERE idPd = vSsProductStoreBalance.idPd),0.00) As AvStock, "
    '    vFields &= "isnull(S6,0.00) as S6,"
    '    vFields &= "ISNULL((SELECT SUM(EstimateW) AS Expr1 FROM dbo.vPdIndexJobDt WHERE (stCancel IS NULL) AND (idPd = vSsProductStoreBalance.idPd) " & _
    '            " AND (idSeedType = vSsProductStoreBalance.idSeedType) AND (idCompb = vSsProductStoreBalance.idCompb) And (idJobLine <> '0' And idJobLine <> '9' " & _
    '            " And idJobLine <> '10')),0.00) AS EstimateW,0.00 as BalancePc, "
    '    vFields &= " ISNULL((isnull(S1NOW,0.00)+isnull(WIP1,0.00)+isnull(Bake,0.00)+isnull(S2,0.00)+isnull(S3,0.00)+isnull(S4,0.00)+isnull(WIP4,0.00)" & _
    '          "+isnull(S5,0.00)+isnull(S6,0.00)),0.00) as StoreBalance,SalePrice,0.00 as SaleValue,idCompb "
    '    sCommand.CommandText = "Select " & vFields & " From vSsProductStoreBalance WHERE idPd IS NOT NULL Order By StoreBalance"
    '    sAdapter.Fill(vDt_)

    '    pDataAll(idPdT)

    '    For Each vDr As DataRow In vDt_.Rows
    '        vDr.Item("SaleValue") = vDr.Item("SalePrice") * vDr.Item("StoreBalance")
    '        vDr.Item("BalancePc") = vDr.Item("StoreBalance") - vDr.Item("S6")
    '    Next

    '    For i As Integer = 0 To vDt_.Rows.Count - 1
    '        For j As Integer = 0 To flDt.Rows.Count - 1
    '            If vDt_.Rows(i).Item("PdName") = flDt.Rows(j).Item("PdName") Then
    '                If vDt_.Rows(i).Item("idCompb") = 2 Then
    '                    flDt.Rows(j).Item("Balance_Green") = Format(vDt_.Rows(i).Item("StoreBalance"), "#,##0.00")
    '                    flDt.Rows(j).Item("BalancePC_Green") = Format(vDt_.Rows(i).Item("BalancePc"), "#,##0.00")
    '                    flDt.Rows(j).Item("S6_Green") = Format(vDt_.Rows(i).Item("S6"), "#,##0.00")
    '                End If
    '                If vDt_.Rows(i).Item("idCompb") = 1 Then
    '                    flDt.Rows(j).Item("Balance_Flo") = Format(vDt_.Rows(i).Item("StoreBalance"), "#,##0.00")
    '                    flDt.Rows(j).Item("BalancePC_Flo") = Format(vDt_.Rows(i).Item("BalancePc"), "#,##0.00")
    '                    flDt.Rows(j).Item("S6_Flo") = Format(vDt_.Rows(i).Item("S6"), "#,##0.00")
    '                End If

    '                'If vDt_.Rows(i).Item("idCompb") = 8 Then
    '                flDt.Rows(j).Item("Balance_avs") = Format(vDt_.Rows(i).Item("AvStock"), "#,##0.00")
    '                'End If
    '                flDt.Rows(j).Item("StoreBalance_") = Format(flDt.Rows(j).Item("Balance_Green") + flDt.Rows(j).Item("Balance_Flo") + flDt.Rows(j).Item("Balance_avs"), "#,##0.00")
    '                flDt.Rows(j).Item("BalancePc_") = Format(flDt.Rows(j).Item("BalancePC_Green") + flDt.Rows(j).Item("BalancePC_Flo"), "#,##0.00")
    '            End If
    '        Next
    '    Next
    'End Sub

    'Private Sub pDataAll(ByVal idPdT As String)
    '    flDt.Clear()
    '    sCommand.CommandText = "Select Distinct v.idPd,v.PdName,v.SeedTypeName,0.00 As BalancePC_Green,0.00 As BalancePC_Flo,0.00 As S6_Green,0.00 As S6_Flo " & _
    '                           ",0.00 As Balance_Green,0.00 As Balance_Flo,0.00 As Balance_avs,0.00 As StoreBalance_,0.00 As BalancePc_ From vSeedProduct v " & _
    '                           "LEFT JOIN SlPdIngredient i ON i.idPd = v.idPd " & _
    '                           "LEFT JOIN vSsProductStoreBalance s ON i.idPd = s.idPd " & _
    '                           "Where i.idPdT = " & idPdT & " Order By v.SeedTypeName"
    '    sAdapter.Fill(flDt)
    'End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If lblPsCus.Text = "" Then
            MessageBox.Show("กรุณาระบุชื่อลูกค้า", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            btnPsCus.Focus()
            Exit Sub
        ElseIf lblPsSale.Text = "" Then
            MessageBox.Show("กรุณาระบุเจ้าหน้าที่ขาย", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            btnPsSale.Focus()
            Exit Sub
        ElseIf lblPsOrder.Text = "" Then
            MessageBox.Show("กรุณาระบุผู้รับคำสั่งซื้อ", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            btnPsOrder.Focus()
            Exit Sub
        ElseIf Me.GvOrder.RowCount = 1 Then
            MessageBox.Show("กรุณาเลือกรายการสินค้าอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            Exit Sub
        Else
            For i As Integer = 0 To GvOrder.DataRowCount - 1
                If GvOrder.GetDataRow(i).Item("Amount") = 0 Then
                    MessageBox.Show("มีบางรายการระบุจำนวนสั่งซื้อเป็น 0 กรุณาตรวจสอบ", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                If IsDBNull(GvOrder.GetDataRow(i).Item("idInvMain")) Then
                    MessageBox.Show("มีบางรายการไม่ได้ระบุรายการสินค้า กรุณาตรวจสอบ", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Next

        End If

        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
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

                If eEvent = eProcess.eAdd Then 'NewData  
                    Dim vAdapter = New SqlDataAdapter(mycommand)
                    '----Check Dup Order -----'
                    Dim DateOrder As DateTime = Convert.ToDateTime(dtpOrder.Value, _cultureEnInfo)
                    Dim DateRequire As DateTime = Convert.ToDateTime(dtpRequire.Value, _cultureEnInfo)

                    Dim chkDt As New DataTable
                    mycommand.CommandText = "SELECT idSaleOrder From SmSaleOrderMt " & vbNewLine &
                                           "WHERE DateOrderD = '" & DateOrder.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " &
                                           "AND DateRequireD = '" & DateRequire.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " &
                                           "AND idpartner = " & Me.lblPsCus.Tag & " AND idPsSale = " & Me.lblPsSale.Tag
                    myAdapter.Fill(chkDt)

                    If chkDt.Rows.Count > 0 Then 'มีรายการที่มีโอกาสซ้ำ check Dt ต่อไป
                        For i As Integer = 0 To chkDt.Rows.Count - 1 'loop Mt (อาจจะมีซ้ำรายการ)
                            '---Check จำนวน row ว่าเท่ากันมั้ย----'
                            Dim RowDt As New DataTable
                            RowDt.Clear()
                            mycommand.CommandText = "SELECT ISNULL(COUNT(idSaleOrderDt), 0) As CntOfDt " & vbNewLine &
                                                   "FROM SmSaleOrderDt WHERE idSaleOrder = " & chkDt.Rows(i).Item("idSaleOrder")
                            myAdapter.Fill(RowDt)
                            If RowDt.Rows(0).Item("CntOfDt") = GvOrder.RowCount - 1 Then 'จำนวนรายการที่สั่งเท่ากัน เช็ครายละเอียดต่อไป
                                Dim aDt As New DataTable
                                Dim stDup As Integer = 0
                                For j As Integer = 0 To GvOrder.DataRowCount - 1
                                    aDt.Clear()
                                    mycommand.CommandText = "SELECT idSaleOrderDt FROM SmSaleOrderDt WHERE " &
                                                           "idSaleOrder = " & chkDt.Rows(i).Item("idSaleOrder") & " AND " &
                                                           "idInvMain  = " & CInt(GvOrder.GetDataRow(j).Item("idInvmain")) & " AND " &
                                                           "Amount = " & CDbl(GvOrder.GetDataRow(j).Item("Amount"))
                                    myAdapter.Fill(aDt)
                                    If aDt.Rows.Count = 0 Then 'มีรายการไม่ซ้ำ
                                        stDup = 1
                                    End If
                                Next

                                If stDup = 0 Then 'ซ้ำทุกรายการ
                                    Dim showDt As New DataTable
                                    showDt.Clear()
                                    mycommand.CommandText = "SELECT mt.DocCode, mt.DateTsD, p.PsName As PsTs, " & vbNewLine &
                                                           "(CASE ISNULL(mt.stSysOrder,0) WHEN  0 THEN 'PC' WHEN 1 THEN 'Mobile' WHEN 2 THEN 'Web Browser' END) As stSysOrder " &
                                                           "FROM SmSaleOrderMt mt " & vbNewLine &
                                                           "LEFT OUTER JOIN vPersonxSelect p ON mt.idPsTs = p.idPs " &
                                                           "WHERE mt.idSaleOrder = " & chkDt.Rows(i).Item("idSaleOrder")
                                    myAdapter.Fill(showDt)

                                    SplashScreenManager.CloseForm(False)
                                    Result = MsgBox("รายการสั่งซื้อที่ต้องการบันทึกมีข้อมูลซ้ำกับ" & vbNewLine & "รายการสั่งซื้อเลขที่ : " & showDt.Rows(0).Item("DocCode") & vbCrLf &
                                             "วันที่ทำรายการ : " & ksbStringToDate(showDt.Rows(0).Item("DateTsD")) & vbNewLine &
                                             " ผู้ทำรายการ : " & showDt.Rows(0).Item("PsTs") & vbCrLf & "ช่องทางการทำรายการ : " &
                                             showDt.Rows(0).Item("stSysOrder") & vbCrLf & "คุณต้องการจะบันทึกข้อมูลการสั่งซื้อนี้ต่อหรือไม่? ", MsgBoxStyle.YesNo)

                                    If Result = Windows.Forms.DialogResult.Yes Then
                                        AddSmSaleOrderMt(mycommand)
                                        Exit For
                                    Else
                                        Exit Sub
                                    End If
                                End If
                            End If

                            If i = chkDt.Rows.Count - 1 Then
                                AddSmSaleOrderMt(mycommand)
                            End If
                        Next 'End Next loop Mt


                    Else ' mt ไม่มีข้อมูลซ้ำ
                        AddSmSaleOrderMt(mycommand)
                    End If

                    ' CheckDuplicateIntsert(mycommand)
                    'AddSmQtMt(mycommand)

                Else 'EditData
                    UpdateSmSaleOrderMt(mycommand)
                End If

                mytransaction.Commit()
                SplashScreenManager.CloseForm(False)
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Catch ex As Exception
                ' Attempt to roll back the transaction.
                Try
                    mytransaction.Rollback()
                    SplashScreenManager.CloseForm(False)
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                    sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                Catch e2x As Exception
                    SplashScreenManager.CloseForm(False)
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                    sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                End Try
            Finally
                myconnection.Close()
            End Try
        End Using

    End Sub

    'Sub CheckDuplicateIntsert(ByVal vCommand As SqlCommand)
    '    Dim vAdapter = New SqlDataAdapter(vCommand)
    '    '----Check Dup Order -----'
    '    Dim DateOrder As DateTime = Convert.ToDateTime(dtpOrder.Value, _cultureEnInfo)
    '    Dim DateRequire As DateTime = Convert.ToDateTime(dtpRequire.Value, _cultureEnInfo)

    '    Dim chkDt As New DataTable
    '    chkDt.Clear()
    '    vCommand.CommandText = "SELECT idSaleOrder From SmSaleOrderMt " & vbNewLine & _
    '                           "WHERE DateOrderD = '" & DateOrder.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " & _
    '                           "AND DateRequireD = '" & DateRequire.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " & _
    '                           "AND idpartner = " & Me.lblPsCus.Tag & " AND idPsSale = " & Me.lblPsSale.Tag
    '    vAdapter.Fill(chkDt)

    '    If chkDt.Rows.Count > 0 Then 'มีรายการที่มีโอกาสซ้ำ check Dt ต่อไป
    '        For i As Integer = 0 To chkDt.Rows.Count - 1 'loop Mt (อาจจะมีซ้ำรายการ)
    '            '---Check จำนวน row ว่าเท่ากันมั้ย----'
    '            Dim RowDt As New DataTable
    '            RowDt.Clear()
    '            vCommand.CommandText = "SELECT ISNULL(COUNT(idSaleOrderDt), 0) As CntOfDt " & vbNewLine & _
    '                                   "FROM SmSaleOrderDt WHERE idSaleOrder = " & chkDt.Rows(i).Item("idSaleOrder")
    '            vAdapter.Fill(RowDt)
    '            If RowDt.Rows(0).Item("CntOfDt") = GvOrder.RowCount - 1 Then 'จำนวนรายการที่สั่งเท่ากัน เช็ครายละเอียดต่อไป
    '                Dim aDt As New DataTable
    '                Dim stDup As Integer = 0
    '                For j As Integer = 0 To GvOrder.DataRowCount - 1
    '                    aDt.Clear()
    '                    vCommand.CommandText = "SELECT idSaleOrderDt FROM SmSaleOrderDt WHERE " & _
    '                                           "idSaleOrder = " & chkDt.Rows(i).Item("idSaleOrder") & " AND " & _
    '                                           "idInvMain  = " & CInt(GvOrder.GetDataRow(j).Item("idInvmain")) & " AND " & _
    '                                           "Amount = " & CDbl(GvOrder.GetDataRow(j).Item("Amount"))
    '                    vAdapter.Fill(aDt)
    '                    If aDt.Rows.Count = 0 Then 'มีรายการไม่ซ้ำ
    '                        stDup = 1
    '                    End If
    '                Next

    '                If stDup = 0 Then 'ซ้ำทุกรายการ
    '                    Dim showDt As New DataTable
    '                    showDt.Clear()
    '                    vCommand.CommandText = "SELECT mt.DocCode, mt.DateTsD, p.PsName As PsTs, " & vbNewLine & _
    '                                           "(CASE ISNULL(mt.stSysOrder,0) WHEN  0 THEN 'PC' WHEN 1 THEN 'Mobile' WHEN 2 THEN 'Web Browser' END) As stSysOrder " & _
    '                                           "FROM SmSaleOrderMt mt " & vbNewLine & _
    '                                           "LEFT OUTER JOIN vPersonxSelect p ON mt.idPsTs = p.idPs " & _
    '                                           "WHERE mt.idSaleOrder = " & chkDt.Rows(i).Item("idSaleOrder")
    '                    vAdapter.Fill(showDt)

    '                    SplashScreenManager.CloseForm(False)
    '                    Result = MsgBox("รายการสั่งซื้อที่ต้องการบันทึกมีข้อมูลซ้ำกับ รายการสั่งซื้อเลขที่ : " & showDt.Rows(0).Item("DocCode") & vbCrLf & _
    '                             "วันที่ทำรายการ : " & ksbStringToDate(showDt.Rows(0).Item("DateTsD")) & _
    '                             " ผู้ทำรายการ : " & showDt.Rows(0).Item("PsTs") & vbCrLf & "ช่องทางการทำรายการ : " & _
    '                             showDt.Rows(0).Item("stSysOrder") & vbCrLf & "คุณต้องการจะบันทึกข้อมูลการสั่งซื้อนี้ต่อหรือไม่? ", MsgBoxStyle.YesNo)

    '                    If Result = Windows.Forms.DialogResult.Yes Then
    '                        '----insert---'
    '                        ' SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
    '                        AddSmSaleOrderMt(vCommand)
    '                        ' SplashScreenManager.CloseForm(False)
    '                    Else
    '                        Exit Sub
    '                    End If
    '                End If
    '            End If

    '            If i = chkDt.Rows.Count - 1 Then
    '                'insert
    '                ' SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
    '                AddSmSaleOrderMt(vCommand)
    '                ' SplashScreenManager.CloseForm(False)
    '            End If
    '        Next 'End Next loop Mt
    '    Else ' mt ไม่มีข้อมูลซ้ำ
    '        'SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
    '        AddSmSaleOrderMt(vCommand)
    '        ' SplashScreenManager.CloseForm(False)
    '    End If

    'End Sub

    Private Sub AddSmSaleOrderMt(ByVal xCommand As SqlCommand)
        ' mdCnOpen()
        '---insert SmSaleOrderMt Table---'
        Dim DocCode As String = ""
        Dim getDate As String = CType(Date.Today, String)
        Dim Prefixcode As String = "SO"
        Dim idSaleOrder_last As String = ""
        ' Dim timeTs As String = ""

        Prefixcode = Prefixcode & (Microsoft.VisualBasic.Right(getDate, 2))
        DocCode = getDocCode(Prefixcode)
        Dim dtDateOrderD As DateTime = Convert.ToDateTime(dtpOrder.Value, _cultureEnInfo)
        Dim DateRequireD As DateTime = Convert.ToDateTime(dtpRequire.Value, _cultureEnInfo)

        Dim query As String = "Insert Into SmSaleOrderMt(DateOrderD, DateTsD, TimeTs, DateRequireD, DocCode, Note, " &
                              "idPsTs, idPsOrder, idPartner, idPsSale, idComp) " & vbNewLine &
                              "Values('" & dtDateOrderD.ToString("yyyy-MM-dd", _cultureEnInfo) & "', GETDATE(), " & vbNewLine &
                              "CONVERT(VARCHAR(5),GETDATE(),108), '" & DateRequireD.ToString("yyyy-MM-dd", _cultureEnInfo) & "', " & vbNewLine &
                              "'" & DocCode & "', '" & txtNote.Text.Trim & "', " & lblPsTs.Tag & ", " & lblPsOrder.Tag & ", " & vbNewLine &
                              "" & lblPsCus.Tag & ", " & lblPsSale.Tag & ", " & cmbGroupComp.SelectedValue & ")"
        xCommand.CommandText = query

        Dim query2 As String = "Select @@Identity"
        xCommand.ExecuteNonQuery()
        xCommand.CommandText = query2
        idSaleOrder_last = xCommand.ExecuteScalar()


        '----insert SmSaleOrderDt----'
        AddSmSaleOrderDt(idSaleOrder_last, xCommand)

        'up image
        For j As Integer = 0 To sDt_flagpic_Rec.Rows.Count - 1
            If sDt_flagpic_Rec.Rows(j).Item(2) = "1" Then
                'upFile(sDt_flagpic.Rows(j).Item(3), sDt_flagpic.Rows(j).Item(0), idSale)
                upFile(j + 1, sDt_flagpic_Rec.Rows(j).Item(0), idSaleOrder_last)
            End If
        Next
    End Sub

    Private Sub upFile(ByVal namefile As String, ByVal locationname As String, ByVal idOrder As String)
        My.Computer.Network.UploadFile(locationname, "ftp://" & sHost & "/images/pSaleOrder/" + idOrder + "_" + namefile + ".jpg", sFtpUser, sFtpPass)
    End Sub

    Sub AddSmSaleOrderDt(ByVal idSaleOrder As Integer, ByVal vCommand As SqlCommand)
        '---insert SmSaleOrderDt Table---'
        For i As Integer = 0 To GvOrder.DataRowCount - 1
            vCommand.CommandText = "Insert Into SmSaleOrderDt(idSaleOrder, idInvMain, pdName, Amount, Price, idUnit, Note) " & vbNewLine &
                                   "Values(" & idSaleOrder & ", " & CInt(GvOrder.GetDataRow(i).Item("idInvMain")) & ", " & vbNewLine &
                                   "'" & GvOrder.GetDataRow(i).Item("ProductName") & "', " & vbNewLine &
                                   CDbl(GvOrder.GetDataRow(i).Item("Amount")) & ", " & vbNewLine &
                                   CDbl(GvOrder.GetDataRow(i).Item("Price")) & ", " & vbNewLine &
                                   CInt(GvOrder.GetDataRow(i).Item("idUnit")) & ", " & vbNewLine &
                                   "'" & GvOrder.GetDataRow(i).Item("NoteDt") & "')"
            vCommand.ExecuteNonQuery()
        Next

    End Sub

    Sub UpdateSmSaleOrderMt(ByVal vCommand As SqlCommand)
        Dim dtDateOrderD As DateTime = Convert.ToDateTime(dtpOrder.Value, _cultureEnInfo)
        Dim DateRequireD As DateTime = Convert.ToDateTime(dtpRequire.Value, _cultureEnInfo)

        '---Update SmSaleOrderMt Table---'
        vCommand.CommandText = "Update SmSaleOrderMt Set DateOrderD ='" & dtDateOrderD.ToString("yyyy-MM-dd", _cultureEnInfo) & "', " & vbNewLine &
                               "DateTsD = GETDATE(), TimeTs = CONVERT(VARCHAR(5),GETDATE(),108), " & vbNewLine &
                               "DateRequireD = '" & DateRequireD.ToString("yyyy-MM-dd", _cultureEnInfo) & "', " & vbNewLine &
                               "Note= '" & txtNote.Text.Trim & "', idPsTs= " & sPsId & ", idPsOrder =" & lblPsOrder.Tag & ", " & vbNewLine &
                               "idPartner = " & lblPsCus.Tag & ", idPsSale = " & lblPsSale.Tag & vbNewLine &
                               ", stApp = NULL WHERE idSaleOrder = " & idSaleOrder_
        vCommand.ExecuteNonQuery()


        '---Update SmSaleOrderDt Table---'
        UpdateSmSaleOrderDt(vCommand)
    End Sub

    Sub UpdateSmSaleOrderDt(ByVal vCommand As SqlCommand)
        Dim dv As New DataView(MainDt)

        'Old-Dt >>> Update
        Dim StridOrderDt As String = ""
        dv.RowFilter = "idSaleOrderDt <> 0"
        For i As Integer = 0 To dv.Count - 1
            StridOrderDt &= dv.Item(i).Item("idSaleOrderDt") & ","
            vCommand.CommandText = "UPDATE SmSaleOrderDt SET idInvMain = " & CInt(dv.Item(i).Item("idInvMain")) & ", " & vbNewLine &
                                   "pdName = '" & dv.Item(i).Item("Productname") & "', " & vbNewLine &
                                   "Amount = " & CDbl(dv.Item(i).Item("Amount")) & ", " & vbNewLine &
                                   "Price = " & CDbl(dv.Item(i).Item("Price")) & ", " & vbNewLine &
                                   "idUnit = " & CInt(dv.Item(i).Item("idUnit")) & ", " & vbNewLine &
                                   "Note = '" & (dv.Item(i).Item("NoteDt")) & "' " & vbNewLine &
                                   "WHERE idSaleOrderDt = " & dv.Item(i).Item("idSaleOrderDt")
            vCommand.ExecuteNonQuery()
        Next

        'Old-Dt >>> Delete
        Dim WHERExDel As String = ""
        If StridOrderDt <> "" Then
            WHERExDel = " AND idSaleOrderDt NOT IN (" & StridOrderDt.Substring(0, StridOrderDt.Length - 1) & ")"
        End If

        'vCommand.CommandText = "Delete SmSaleOrderDt Where idSaleOrder =  " & idSaleOrder_ & WHERExDel
        'vCommand.ExecuteNonQuery()
        vCommand.CommandText = "Update SmSaleOrderDt Set idPsCancel = " & sPsId & ", CancelNote = 'ลบจาก ERP' Where idSaleOrder = " & idSaleOrder_ & WHERExDel
        vCommand.ExecuteNonQuery()


        'New-Dt >>> Insert
        dv.RowFilter = "idSaleOrderDt = 0"
        For i As Integer = 0 To dv.Count - 1
            vCommand.CommandText = "Insert Into SmSaleOrderDt(idSaleOrder, idInvMain, pdName, Amount, Price, idUnit, Note) " &
                                  "Values(" & idSaleOrder_ & ", " & CInt(dv.Item(i).Item("idInvMain")) & ", " &
                                  "'" & dv.Item(i).Item("ProductName") & "'," &
                                  "" & CDbl(dv.Item(i).Item("Amount")) & ", " &
                                  "" & CDbl(dv.Item(i).Item("Price")) & ", " &
                                  "" & CInt(dv.Item(i).Item("idUnit")) & ", " &
                                  "'" & dv.Item(i).Item("NoteDt") & "')"
            vCommand.ExecuteNonQuery()
        Next

    End Sub

    '-------------------- GEN DocCode --------------------'
    Function getDocCode(ByVal Prefixcode As String) As String
        Dim DocCode As String = ""
        Dim nextOrder As String = ""
        Dim CodeYear As String = ""


        mdCnOpen()
        Dim sDt As New DataTable
        sDs.Tables.Clear()
        ' sCommand.CommandText = "SELECT MAX(DocCode) AS max_DocCode, MAX(SUBSTRING(DocCode, 3, 2)) AS year_docCode FROM SmSaleOrderMt"
        sCommand.CommandText = "SELECT MAX(DocCode) as max_DocCode, SUBSTRING(MAX(DocCode), 3, 2) AS year_docCode" & vbNewLine &
                               "FROM SmSaleOrderMt WHERE stSysOrder IS NULL AND idComp = " & cmbGroupComp.SelectedValue
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

    'Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    mdCnOpen()
    '    Dim strSql As String = ""
    '    '---Update SmSaleOrderMt Table---'
    '    sCommand.CommandText = "Update SmSaleOrderMt Set idPsAccept='" & sPsId & "', DateAccept='" & ksbDateToString(Date.Today) & "' " & _
    '                           "Where idSaleOrder='" & idSO & "'"
    '    sCommand.ExecuteNonQuery()

    '    Dim sDt As New DataTable
    '    sCommand.CommandText = "Select idPsAccept, idPsCheck, idPsApp From SmSaleOrderMt Where idSaleOrder='" & idSO & "'"
    '    sAdapter.Fill(sDt)
    '    If Not IsDBNull(sDt.Rows(0).Item("idPsAccept")) And Not IsDBNull(sDt.Rows(0).Item("idPsCheck")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp")) Then
    '        '----Update stApp----'
    '        sCommand.CommandText = "Update SmSaleOrderMt Set stApp='1' Where idSaleOrder='" & idSO & "'"
    '        sCommand.ExecuteNonQuery()
    '        MessageBox.Show("กระบวนการนี้เป็นการยืนยันขั้นตอนลำดับสุดท้าย ลำดับที่ 3", sSystemName)
    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '    Else
    '        MessageBox.Show("รับทราบเรียบร้อยแล้ว", sSystemName)
    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '    End If
    'End Sub

    'Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    mdCnOpen()
    '    '---Update SmSaleOrderMt Table---'
    '    sCommand.CommandText = "Update SmSaleOrderMt Set idPsCheck='" & sPsId & "', DateCheck ='" & ksbDateToString(Date.Today) & "' " & _
    '                           "Where idSaleOrder='" & idSO & "'"
    '    sCommand.ExecuteNonQuery()

    '    Dim sDt As New DataTable
    '    sCommand.CommandText = "Select idPsAccept, idPsCheck, idPsApp From SmSaleOrderMt Where idSaleOrder='" & idSO & "'"
    '    sAdapter.Fill(sDt)
    '    If Not IsDBNull(sDt.Rows(0).Item("idPsAccept")) And Not IsDBNull(sDt.Rows(0).Item("idPsCheck")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp")) Then
    '        '----Update stApp----'
    '        sCommand.CommandText = "Update SmSaleOrderMt Set stApp='1' Where idSaleOrder='" & idSO & "'"
    '        sCommand.ExecuteNonQuery()
    '        MessageBox.Show("กระบวนการนี้เป็นการยืนยันขั้นตอนลำดับสุดท้าย ลำดับที่ 3", sSystemName)
    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '    Else
    '        MessageBox.Show("ตรวจสอบเรียบร้อยแล้ว", sSystemName)
    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '    End If
    'End Sub

    'Private Sub btnApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'If Me.txtApprove.Text <> "" Then
    '    '    MessageBox.Show("รายการนี้ผ่านการอนุมัติแล้ว", sSystemName)
    '    '    Exit Sub
    '    'End If

    '    If Me.rdbAppOK.Checked = True Then
    '        mdCnOpen()
    '        '---Update SmSaleOrderMt Table---'
    '        sCommand.CommandText = "Update SmSaleOrderMt Set idPsApp='" & sPsId & "', DateApp='" & ksbDateToString(Date.Today) & "' " & _
    '                               "Where idSaleOrder='" & idSO & "'"
    '        sCommand.ExecuteNonQuery()
    '    ElseIf Me.rdbAppNo.Checked = True Then
    '        mdCnOpen()
    '        '---Update SmSaleOrderMt Table---'
    '        sCommand.CommandText = "Update SmSaleOrderMt Set idPsApp='" & sPsId & "', DateApp='" & ksbDateToString(Date.Today) & "', " & _
    '                               "stApp='0' Where idSaleOrder='" & idSO & "'"
    '        sCommand.ExecuteNonQuery()
    '        MessageBox.Show("ระบบยืนยันการไม่อนุมัติรายการเรียบร้อยแล้ว", sSystemName)
    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '        Exit Sub
    '    Else
    '        MessageBox.Show("กรุณาเลือกอนุมัติ หรือไม่อนุมัติก่อนทำการบันทึก", sSystemName)
    '        Exit Sub
    '    End If

    '    Dim sDt As New DataTable
    '    sCommand.CommandText = "Select idPsAccept, idPsCheck, idPsApp From SmSaleOrderMt Where idSaleOrder='" & idSO & "'"
    '    sAdapter.Fill(sDt)
    '    If Not IsDBNull(sDt.Rows(0).Item("idPsAccept")) And Not IsDBNull(sDt.Rows(0).Item("idPsCheck")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp")) Then
    '        '----Update stApp----'
    '        sCommand.CommandText = "Update SmSaleOrderMt Set stApp='1' Where idSaleOrder='" & idSO & "'"
    '        sCommand.ExecuteNonQuery()
    '        MessageBox.Show("กระบวนการนี้เป็นการยืนยันขั้นตอนลำดับสุดท้าย ลำดับที่ 3", sSystemName)
    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '    Else
    '        Dim Dt As New DataTable
    '        sCommand.CommandText = "Select PsApp, DateApp From vSmSaleOrderMt Where idSaleOrder='" & idSO & "'"
    '        sAdapter.Fill(Dt)

    '        'If IsDBNull(Dt.Rows(0).Item("PsApp")) = True Then
    '        '    Me.txtApprove.Text = ""
    '        'Else
    '        '    Me.txtApprove.Text = Dt.Rows(0).Item("PsApp")
    '        'End If
    '        MessageBox.Show("ตรวจสอบเรียบร้อยแล้ว", sSystemName)

    '    End If
    'End Sub


    'Private Sub btnChkStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    For i As Integer = 0 To dgvExpenseOrder.Rows.Count - 2
    '        If dgvExpenseOrder.Rows(i).Cells("PdPkid").Value = Nothing Then
    '            MessageBox.Show("กรุณาตรวจสอบรายการที่ไม่มีข้อมูล และลบออกจากตารางก่อน", sSystemName)
    '            Exit Sub
    '        Else

    '            If dgvExpenseOrder.Rows(i).Cells("colUnit").Value = 3 And dgvExpenseOrder.Rows(i).Cells("ColPerBox").Value = 0 Then
    '                '---Nothing----'
    '            Else
    '                '---check สถานะสีของ stock---'
    '                mdLoadShow()
    '                stStockPd(i)
    '                mdLoadCommitt()
    '            End If
    '        End If
    '    Next
    'End Sub

    Private Sub GvOrder_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GvOrder.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If
    End Sub

    Private Sub btn_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_img.Click
        Dim tempDt As New DataTable

        If eEvent = eProcess.eAdd Then 'AddNew       
            Dim vFrm As New frmSlOrderPic(frmSlOrderPic.eProcess.eAddNew, "", tempDt)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                sDt_flagpic_Rec = vFrm.sDt_flagpic
            End If
        ElseIf eEvent = eProcess.eEdit Then 'EditData
            Dim vFrm As New frmSlOrderPic(frmSlOrderPic.eProcess.eEdit, idSaleOrder_, tempDt)
            vFrm.Show()
        Else  'view
            Dim vFrm As New frmSlOrderPic(frmSlOrderPic.eProcess.eView, idSaleOrder_, tempDt)
            vFrm.Show()
        End If
    End Sub

    Private Sub GvOrder_ShownEditor(sender As Object, e As EventArgs) Handles GvOrder.ShownEditor
        If GvOrder.FocusedRowHandle >= 0 Then
            Dim view As ColumnView = DirectCast(sender, ColumnView)
            If view.FocusedColumn.FieldName = "idUnit" And Not IsDBNull(view.GetFocusedRowCellValue("idInvMain")) Then
                Dim editor As LookUpEdit = CType(view.ActiveEditor, LookUpEdit)
                Dim dt As DataTable = getDataLookup(view.GetFocusedRowCellValue("idUnitPd"), view.GetFocusedRowCellValue("idInvMain"),
                                                    view.GetFocusedRowCellValue("idInvGroup"), view.GetFocusedRowCellValue("Perbox"))
                editor.Properties.DataSource = dt
                rptUnit.DropDownRows = dt.Rows.Count
            End If
        End If
    End Sub

    Private Sub GridControl_EditorKeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles GcOrder.EditorKeyPress
        Dim grid As GridControl = CType(sender, GridControl)
        GvOrder_KeyPress(grid.FocusedView, e)
    End Sub

    Private Sub GvOrder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GvOrder.KeyPress
        Dim view As GridView = CType(sender, GridView)

        If view.FocusedColumn.FieldName = "Amount" Then
            If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub GvOrder_KeyUp(sender As Object, e As KeyEventArgs) Handles GvOrder.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmSlOrderTs_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub rptUnit_Click(sender As Object, e As EventArgs) Handles rptUnit.Click
        If GvOrder.FocusedRowHandle < 0 Then
            rptUnit.ReadOnly = True
        Else
            rptUnit.ReadOnly = False
        End If
    End Sub

    'search by productname
    Private Sub rptProductName_Click(sender As Object, e As EventArgs) Handles rptProductName.Click
        Dim navigator As ControlNavigator = GcOrder.EmbeddedNavigator
        If GvOrder.FocusedRowHandle >= 0 Then
            navigator.Buttons.DoClick(navigator.Buttons.Edit)
        Else
            'ถ้า เป็น NewItemRow
            navigator.Buttons.DoClick(navigator.Buttons.Append)
            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
        End If

        fnSetProduct()

        If IsDBNull(GvOrder.GetRowCellValue(GvOrder.FocusedRowHandle, "idInvMain")) Then
            navigator.Buttons.DoClick(navigator.Buttons.Remove)
        End If
    End Sub

    Private Sub rptProductName_KeyDown(sender As Object, e As KeyEventArgs) Handles rptProductName.KeyDown
        Dim navigator As ControlNavigator = GcOrder.EmbeddedNavigator
        If e.KeyCode = Keys.Enter Then

            If GvOrder.FocusedRowHandle >= 0 Then
                navigator.Buttons.DoClick(navigator.Buttons.Edit)
            Else
                'ถ้า เป็น NewItemRow
                navigator.Buttons.DoClick(navigator.Buttons.Append)
                navigator.Buttons.DoClick(navigator.Buttons.EndEdit)
            End If

            fnSetProduct()

            If IsDBNull(GvOrder.GetRowCellValue(GvOrder.FocusedRowHandle, "idInvMain")) Then
                navigator.Buttons.DoClick(navigator.Buttons.Remove)
            End If
        End If
    End Sub

    Private Sub fnSetProduct()
        Dim vFrm As New frmAllInvSelect(frmAllInvSelect.eProcess.eAll, cmbGroupComp.SelectedValue)
        'vFrm.GetInvName(GvOrder.GetRowCellValue(GvOrder.FocusedRowHandle, "ProductName"))

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Dim SetPrice As Double = 0.0
            'Select Case vFrm.sdt1.Rows(0).Item("idInvGroup")
            '    Case 2 'FG
            '        SetPrice = vFrm.sdt1.Rows(0).Item("PriceBill_fg")
            '    Case 3, 28, 33, 36, 37, 38, 39 'เบ็ดเตล็ด/Hormaone/Fresh/ปุ๋ย/ยา/สารขับใข/อุปกรณ์เกษตร
            '        SetPrice = vFrm.sdt1.Rows(0).Item("PricePdo_pdo")
            '    Case 29 'Plastic                      
            '        SetPrice = vFrm.sdt1.Rows(0).Item("PricePdo_pdo")
            '    Case 42 'เมล็ดดอกไม้บรรจุซอง
            '        SetPrice = vFrm.sdt1.Rows(0).Item("PriceSeedFg_sfg")
            'End Select

            'GvOrder.SetFocusedRowCellValue("No", 999)
            GvOrder.SetFocusedRowCellValue("PdCode", vFrm.sdt1.Rows(0).Item("InvCode"))
            GvOrder.SetFocusedRowCellValue("ProductName", vFrm.sdt1.Rows(0).Item("InvName"))
            ' GvOrder.SetFocusedRowCellValue("Price", SetPrice)
            If IsDBNull(GvOrder.GetRowCellValue(GvOrder.FocusedRowHandle, "Amount")) Then
                GvOrder.SetFocusedRowCellValue("Amount", 0)
            End If
            GvOrder.SetFocusedRowCellValue("idUnit", vFrm.sdt1.Rows(0).Item("idUnit"))
            GvOrder.SetFocusedRowCellValue("NoteDt", "")
            GvOrder.SetFocusedRowCellValue("idSaleOrderDt", 0)
            GvOrder.SetFocusedRowCellValue("idInvMain", vFrm.sdt1.Rows(0).Item("idInvMain"))
            GvOrder.SetFocusedRowCellValue("UnitName", vFrm.sdt1.Rows(0).Item("UnitName"))
            GvOrder.SetFocusedRowCellValue("idInvGroup", vFrm.sdt1.Rows(0).Item("idInvGroup"))
            GvOrder.SetFocusedRowCellValue("idSubType", vFrm.sdt1.Rows(0).Item("idSubType"))
            GvOrder.SetFocusedRowCellValue("idUnitPd", vFrm.sdt1.Rows(0).Item("idUnit"))
            GvOrder.SetFocusedRowCellValue("Perbox", vFrm.sdt1.Rows(0).Item("Perbox"))
            GvOrder.SetFocusedRowCellValue("AmtSale", 0)
            GvOrder.SetFocusedRowCellValue("Price", 0)
            GvOrder.RefreshData()
        End If
    End Sub



    Private Sub rptPdCode_KeyDown(sender As Object, e As KeyEventArgs) Handles rptPdCode.KeyDown
        Dim PdCode_Temp As String = ""
        If e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Enter Then
            mdCnOpen()
            Dim navigator As ControlNavigator = GcOrder.EmbeddedNavigator
            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)

            If GvOrder.GetRowCellValue(GvOrder.FocusedRowHandle, "PdCode") = "" Then
                MessageBox.Show("กรุณาระบุรหัสสินค้า เพื่อค้นหาข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            PdCode_Temp = GvOrder.GetRowCellValue(GvOrder.FocusedRowHandle, "PdCode")
            Dim vFrm As New frmInvCodeSelect(frmInvCodeSelect.eProcess.eSelect, GvOrder.GetRowCellValue(GvOrder.FocusedRowHandle, "PdCode"))
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If vFrm.dtInvCode.Rows.Count > 0 And GvOrder.DataRowCount > 0 Then
                    GvOrder.SetFocusedRowCellValue("PdCode", vFrm.dtInvCode.Rows(0).Item("InvCode"))
                    GvOrder.SetFocusedRowCellValue("ProductName", vFrm.dtInvCode.Rows(0).Item("InvName"))
                    'GvOrder.SetFocusedRowCellValue("Price", SetPrice)
                    If IsDBNull(GvOrder.GetRowCellValue(GvOrder.FocusedRowHandle, "Amount")) Then
                        GvOrder.SetFocusedRowCellValue("Amount", 0)
                    End If
                    GvOrder.SetFocusedRowCellValue("idUnit", vFrm.dtInvCode.Rows(0).Item("idUnit"))
                    GvOrder.SetFocusedRowCellValue("NoteDt", "")
                    GvOrder.SetFocusedRowCellValue("idSaleOrderDt", 0)
                    GvOrder.SetFocusedRowCellValue("idInvMain", vFrm.dtInvCode.Rows(0).Item("idInvMain"))
                    GvOrder.SetFocusedRowCellValue("UnitName", vFrm.dtInvCode.Rows(0).Item("UnitName"))
                    GvOrder.SetFocusedRowCellValue("idInvGroup", vFrm.dtInvCode.Rows(0).Item("idInvGroup"))
                    GvOrder.SetFocusedRowCellValue("idSubType", vFrm.dtInvCode.Rows(0).Item("idSubType"))
                    GvOrder.SetFocusedRowCellValue("idUnitPd", vFrm.dtInvCode.Rows(0).Item("idUnit"))
                Else
                    'navigator.Buttons.DoClick(navigator.Buttons.Remove)
                    MessageBox.Show("ไม่พบข้อมูลรหัสสินค้า " & GvOrder.GetRowCellValue(GvOrder.FocusedRowHandle, "PdCode") & vbNewLine & "กรุณาตรวจสอบข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    navigator.Buttons.DoClick(navigator.Buttons.Remove)

                End If
            End If



        End If
    End Sub

    Private Sub rptDel_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptDel.ButtonClick
        If GvOrder.FocusedRowHandle >= 0 Then
            'เชคจำนวนสั่งซื้อ กับจำนวนขาย ถ้าไม่เท่ากัน แสดงว่า มีการเอาไปเปิดบิลขายแล้ว
            If GvOrder.GetRowCellValue(GvOrder.FocusedRowHandle, "AmtSale") <> 0 Then
                MessageBox.Show("รายการนี้ไม่สามารถแก้ไขได้ เนื่องจากรายการนี้อยู่ในขั้นตอนการขายสินค้าแล้ว" & vbNewLine &
                            "หากต้องการแก้ไข กรุณายกเลิกรายการขายสินค้าก่อน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub

            End If

            If lbrMsg.MsgQuestion("คุณต้องการลบรายการใช่หรือไม่?") = True Then
                Dim dr As DataRow = GvOrder.GetDataRow(GvOrder.FocusedRowHandle)
                dr.Delete()

                MainDt.AcceptChanges()
            End If
        End If

    End Sub

    Private Sub rptDel_KeyDown(sender As Object, e As KeyEventArgs) Handles rptDel.KeyDown
        If GvOrder.FocusedRowHandle >= 0 And e.KeyCode = Keys.Enter Then
            If lbrMsg.MsgQuestion("คุณต้องการลบรายการใช่หรือไม่?") = True Then
                Dim dr As DataRow = GvOrder.GetDataRow(GvOrder.FocusedRowHandle)
                dr.Delete()

                MainDt.AcceptChanges()
            End If
        End If
    End Sub

    'Private Sub GvOrder_MouseDown(sender As Object, e As MouseEventArgs) Handles GvOrder.MouseDown
    '    Dim view As GridView = TryCast(sender, GridView)
    '    Dim hitInfo As Views.Grid.ViewInfo.GridHitInfo = View.CalcHitInfo(e.Location)
    '    If hitInfo.InRowCell Then
    '        View.FocusedRowHandle = hitInfo.RowHandle
    '        View.FocusedColumn = hitInfo.Column
    '        DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = True
    '        If e.Clicks = 2 AndAlso e.Button = System.Windows.Forms.MouseButtons.Left Then
    '            View.ShowEditor()
    '        End If
    '    End If
    'End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        lblPsCus.Tag = 0
        lblPsCus.Text = ""
        lblCusNote.Text = ""
        lblPsSale.Tag = 0
        lblPsSale.Text = ""
    End Sub

    Private Sub GvOrder_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GvOrder.CellValueChanged
        If GvOrder.DataRowCount > 0 Then
            Dim dr As DataRow = GvOrder.GetDataRow(GvOrder.FocusedRowHandle)

            If e.Column.Name = ColAmount.Name Then

                If IsDBNull(dr.Item("Amount")) Then
                    dr.Item("Amount") = 0
                End If

                If e.Column.Name = ColAmtSale.Name Then

                    If dr.Item("Amtsale") <> 0 Then

                        MessageBox.Show("รายการนี้ไม่สามารถแก้ไขได้ เนื่องจากรายการนี้อยู่ในขั้นตอนการขายสินค้าแล้ว" & vbNewLine &
                                        "หากต้องการแก้ไข กรุณายกเลิกรายการขายสินค้าก่อน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        dr.Item("AmtSale") = 0.0
                    End If

                End If
            End If
        End If


    End Sub

    Private Sub rptSel_Click(sender As Object, e As EventArgs) Handles rptSel.Click

        If GvOrder.FocusedRowHandle < 0 Then
            rptSel.ReadOnly = True


        Else
            rptSel.ReadOnly = False
            If GvOrder.GetDataRow(GvOrder.FocusedRowHandle).Item("stBal") = 1 Then
                MessageBox.Show("รายการนี้ไม่สามารถปิดได้" & vbNewLine &
                                "เนื่องจากเปิดบิลขายหมดแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
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


                For i As Integer = 0 To GvOrder.RowCount - 1
                    If GvOrder.GetDataRow(i).Item("Sel") = True Then
                        '--1. Update stClose ที่ SmSaleOrderDt
                        mycommand.CommandText = "Update SmSaleOrderDt Set stClose = 1, idPsCancel = " & sPsId & vbNewLine &
                                                ", CancelNote = 'ปิดรายการ' " & vbNewLine &
                                                "WHERE idSaleOrderDt = " & GvOrder.GetDataRow(i).Item("idSaleOrderDt")
                        mycommand.ExecuteNonQuery()


                        '--2. ตรวจสอบว่า ที่ OrderDt ขายครบทุกรายการสั่งซื้อแล้วหรือยัง
                        Dim dtOrd As New DataTable
                        mycommand.CommandText = "SELECT ISNULL(Sum(ISNULL(stAllSale,0)),0) SumAllSale, Count(idSaleOrderDt) As cntDt  " & vbNewLine &
                                                "FROM SmSaleOrderDt dt" & vbNewLine &
                                                "WHERE dt.idSaleOrder = " & idSaleOrder_ & vbNewLine &
                                                "AND dt.idPsCancel Is NULL"
                        myAdapter.Fill(dtOrd)

                        If dtOrd.Rows.Count > 0 Then
                            If dtOrd.Rows(0).Item("SumAllSale") = dtOrd.Rows(0).Item("cntDt") Then
                                mycommand.CommandText = "UPDATE SmSaleOrderMt SET stOrd = 1 " & vbNewLine &
                                          "WHERE idSaleOrder = " & idSaleOrder_

                                mycommand.ExecuteNonQuery()
                            End If
                        End If

                    End If
                Next

                mytransaction.Commit()
                SplashScreenManager.CloseForm(False)
                MessageBox.Show("ปิดรายการสั่งซื้อเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Catch ex As Exception
                ' Attempt to roll back the transaction.
                Try
                    mytransaction.Rollback()
                    SplashScreenManager.CloseForm(False)
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                    sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                Catch e2x As Exception
                    SplashScreenManager.CloseForm(False)
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                    sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                End Try
            Finally
                myconnection.Close()
            End Try
        End Using
    End Sub

    Dim stSel As Boolean = False

    Private isAllSelected As Boolean = False

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        ' 1. ตรวจสอบก่อนว่ามีข้อมูลใน Grid ไหม
        If GvOrder.DataRowCount <= 0 Then Return

        ' 2. สลับสถานะ (ถ้าเดิมเป็น False ให้เป็น True / ถ้าเดิมเป็น True ให้เป็น False)
        isAllSelected = Not isAllSelected

        ' 3. วนลูปเพื่อเปลี่ยนค่าในคอลัมน์เลือก (สมมติชื่อคอลัมน์คือ "ChkKey")
        For i As Integer = 0 To GvOrder.DataRowCount - 1
            If GvOrder.GetDataRow(i).Item("stBal") = 0 Then
                GvOrder.SetRowCellValue(i, "Sel", isAllSelected)
            End If
        Next

        ' 4. เปลี่ยนข้อความบนปุ่มเพื่อให้ User ไม่งง
        If isAllSelected Then
            btnSelectAll.Text = "ยกเลิกเลือกทั้งหมด"
        Else
            btnSelectAll.Text = "เลือกรายการทั้งหมด"
        End If

        ' 5. บังคับให้ Grid บันทึกค่าลง DataTable ทันที
        GvOrder.PostEditor()
        GvOrder.UpdateCurrentRow()
    End Sub

    'Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
    '    For i As Integer = 0 To GvOrder.RowCount - 1
    '        GvOrder.SetRowCellValue(i, "Sel", True)

    '    Next

    '    stSel = True

    '    If stSel = True Then
    '        btnClose.Text = "ยกเลิกเลือกทั้งหมด"
    '    Else

    '    End If
    'End Sub
End Class