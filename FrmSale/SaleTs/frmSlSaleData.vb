Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing

Public Class frmSlSaleData
    Dim CopyMainDt As New DataTable
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Public idSaleShow As String
    Dim eEvent As eProcess
    Dim stload As Integer = 0
    Dim CopySmSaleDt As New DataTable

    Enum eProcess
        eAddCombine
        eView
        eCancel
        eAccept
        eCheck
        eApprove
        eCancelApv
        eAddXY
        eAddBack 'บันทึกขายสิินค้าย้อนหลัง (No Lot)
    End Enum

    Sub New(ByVal aProcess As eProcess)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        My.Application.ChangeCulture("th-TH")

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess

            Case eProcess.eView
                rptEdit.Buttons(0).Image = My.Resources.Resources.gv_document_open
                ColEdit1.Caption = "ข้อมูล"
                ColDoc.Visible = True
                ColChk1.Visible = False
                ColAct.Visible = False
                ColCheck1.Visible = False
                ColApprove1.Visible = False
                ColCancelApv.Visible = False
                ColCancel.Visible = False

                ColSendLine.Visible = True
                'colPrintMul.Visible = True
                'colPrintMul.VisibleIndex = 1
                ColSendLine.VisibleIndex = 2
                ColEdit1.VisibleIndex = 3
                ColDoc.VisibleIndex = 4

                ColAddPic.VisibleIndex = 5
                'btnPrintMulti.Visible = True
                pnPrint.Visible = True
            Case eProcess.eCancel
                Me.Text = "ยกเลิกรายการขายสินค้า"
                Me.ChkCancel.Visible = False
                ColChk1.Visible = False
                ColAct.Visible = False
                ColCheck1.Visible = False
                ColApprove1.Visible = False
                ColDoc.Visible = False
                ColEdit1.Visible = False
                ColCancelApv.Visible = False

            Case eProcess.eAccept
                Me.ChkCancel.Visible = False
                Me.Text = "รายการรอรับทราบรายการขายสินค้า"
                ColCancel.Visible = False
                ColCheck1.Visible = False
                ColApprove1.Visible = False
                ColDoc.Visible = False
                ColEdit1.Visible = False
                ColCancelApv.Visible = False
                ColChk1.Caption = "รับทราบหลายรายการ"
                Panel5.Visible = True
                Me.btnApprove.Visible = True
                Me.btnApprove.Text = "   รับทราบรายการที่เลือก"

            Case eProcess.eCheck
                Me.ChkCancel.Visible = False
                Me.Text = "รายการรอตรวจสอบรายการขายสินค้า"
                ColCancel.Visible = False
                ColAct.Visible = False
                ColApprove1.Visible = False
                ColDoc.Visible = False
                ColEdit1.Visible = False
                ColCancelApv.Visible = False
                ColChk1.Caption = "ตรวจสอบหลายรายการ"
                Panel5.Visible = True
                Me.btnApprove.Visible = True
                Me.btnApprove.Text = "ตรวจสอบรายการที่เลือก"

            Case eProcess.eApprove
                Me.ChkCancel.Visible = False
                Me.Text = "รายการรออนุมัติรายการขายสินค้า"
                ColCancel.Visible = False
                ColAct.Visible = False
                ColCheck1.Visible = False
                ColDoc.Visible = False
                ColEdit1.Visible = False
                ColCancelApv.Visible = False
                ColChk1.Caption = "อนุมัติหลายรายการ"
                Panel5.Visible = True
                Me.btnApprove.Visible = True
                Me.btnApprove.Text = "อนุมัติรายการที่เลือก"

            Case eProcess.eAddCombine, eProcess.eAddBack  'ทำรายการขายสินค้ารวมทุกประเภท
                Panel6.Visible = True
                Me.btnNew.Visible = True
                ColChk1.Visible = False
                ColCancel.Visible = False
                ColCheck1.Visible = False
                ColApprove1.Visible = False
                ColDoc.Visible = False
                ColAct.Visible = False
                ColCancelApv.Visible = False

                colAddTransport.Visible = True
                ColEdit1.VisibleIndex = 1
                colAddTransport.VisibleIndex = 2
                btnNew.PerformClick()
                pnPrint.Visible = True

            Case eProcess.eCancelApv  ' ยกเลิกรายการรับทราบ/ตรวจสอบ/อนุมัติ
                Me.Text = "ยกเลิกรายการ รับทราบ/ตรวจสอบ/อนุมัติ"
                ColChk1.Visible = False
                ColAct.Visible = False
                ColCheck1.Visible = False
                ColApprove1.Visible = False
                ColCancel.Visible = False
                ColDoc.Visible = False
                ColEdit1.Visible = False

            Case eProcess.eAddXY  'ทำรายการขายสินค้าจากรายการคืน (JU--->XY)
                Me.btnNew.Visible = True
                ColChk1.Visible = False
                ColCancel.Visible = False
                ColCheck1.Visible = False
                ColApprove1.Visible = False
                ColDoc.Visible = False
                ColAct.Visible = False
                ColCancelApv.Visible = False
                Me.Text = "ข้อมูลรายการขายสินค้าจากรายการคืน (JU-->XY)"
        End Select

        eEvent = aProcess
    End Sub

    Private Sub frmSlSaleData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpSaleS.Value = Date.Today
        dtpSaleE.Value = Date.Today
        dtpMonthS.Value = Date.Today
        dtpMonthE.Value = Date.Today
        If Date.IsLeapYear(Date.Today.Year) = 1 Then
            dtpYear.Value = Date.Today
        Else

            dtpYear.Value = Date.Today.AddDays(-1)
        End If

        dtpMonthNow.Value = Date.Today
        dtpMonthNow.Format = DateTimePickerFormat.Custom
        dtpMonthNow.CustomFormat = "MMMMyyyy"

        setCmbGroupComp(Me.cmbGroupComp)

        If eEvent = eProcess.eAddCombine Or eEvent = eProcess.eAddBack Then
            btnNew.PerformClick()
        End If

        cmbDRefCode()
        cmbTransports()

        mdCnOpen()
        mdLoadShow()
        BindData()
        SumTotal()
        mdLoadCommitt()

        stload = 1
    End Sub

    Private Sub btnSFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSFindAll.Click
        mdCnOpen()
        mdLoadShow()
        BindData()
        SumTotal()
        mdLoadCommitt()
    End Sub

    Private Sub cmbDRefCode()

        mdCnOpen()
        Dim vWhere As String = ""
        If chkComp.Checked = True Then
            vWhere = "WHERE idComp IN (" & cmbGroupComp.SelectedValue & ")"
        Else
            vWhere = "WHERE idComp IN (" & SIdCompStr & ")"
        End If

        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT idSaleCode, SaleCode " & vbNewLine & _
                                "FROM SmSaleDocCode " & vbNewLine & _
                                "WHERE idSaleCode IN (SELECT idSaleCode From SmSaleCodeComp " & vWhere & ")"
        sAdapter.Fill(sDt)

        With CCbEditDoc
            .Properties.DisplayMember = "SaleCode"
            .Properties.ValueMember = "idSaleCode"
            .Properties.DataSource = sDt

        End With

    End Sub

    Private Sub cmbTransports()

        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT idTspType, TspTypeName " & vbNewLine & _
                                "FROM dTspType" & vbNewLine & _
                                "WHERE idTspType = 7 OR idTspType = 15 " & _
                                "OR idTspType = 16 OR idTspType = 21 Order By idTspType"
        sAdapter.Fill(sDt)
        With cmbTsp
            .DisplayMember = "TspTypeName"
            .ValueMember = "idTspType"
            .DataSource = sDt
        End With
    End Sub

    Private Sub BindData()
        Dim vWhere As String = " WHERE idJobMt Is NULL "

        If chkComp.Checked = True Then
            vWhere = vWhere & " AND s.idComp = " & cmbGroupComp.SelectedValue
        End If

        If cbSlAVxST.Checked = True Then
            vWhere = vWhere & " AND ISNULL(s.idSlAVxST,0) <> 0"
        Else
            vWhere = vWhere & " AND ISNULL(s.idSlAVxST,0) = 0"
        End If

        Dim vField As String = ""
        If Me.rdbDateSale.Checked = True Then
            vField = "s.DateSaleD"
        ElseIf Me.rdbDateTs.Checked = True Then
            vField = "s.DateTsD"
        End If

        If Me.rdbDate.Checked = True Then
            Dim firstDate As DateTime = Convert.ToDateTime(dtpSaleS.Value, _cultureEnInfo)
            Dim lastDate As DateTime = Convert.ToDateTime(dtpSaleE.Value, _cultureEnInfo)
            vWhere = vWhere & " AND " & vField & " Between '" & firstDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " & _
                              "And '" & lastDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' "

        ElseIf Me.rdbMonth.Checked = True Then

            Dim sDateS As DateTime = Convert.ToDateTime(dtpMonthS.Value, _cultureEnInfo)
            Dim sMonthS As Integer = sDateS.Month
            Dim sYearS As Integer = sDateS.Year
            Dim sDateE As DateTime = Convert.ToDateTime(dtpMonthE.Value, _cultureEnInfo)
            Dim sMonthE As Integer = sDateE.Month
            Dim sYearE As Integer = sDateE.Year

            vWhere = vWhere & " AND year(" & vField & ") * 100 + month(" & vField & ") " & _
                              "BETWEEN " & sYearS & " * 100 + " & sMonthS & " AND " & sYearE & " * 100 + " & sMonthE & ""

        ElseIf Me.rdbYear.Checked = True Then

            Dim sDateY As DateTime = Convert.ToDateTime(dtpYear.Value, _cultureEnInfo)
            Dim sYearY As Integer = sDateY.Year
            vWhere = vWhere & " AND YEAR(" & vField & ") = " & sYearY

        ElseIf Me.rdbMonthNow.Checked = True Then

            Dim sDateMN As DateTime = Convert.ToDateTime(dtpMonthNow.Value, _cultureEnInfo)
            Dim sMonthMN As Integer = sDateMN.Month
            Dim sYearMN As Integer = sDateMN.Year
            vWhere = vWhere & " AND Month(" & vField & ") = " & sMonthMN & " AND YEAR(" & vField & ") = " & sYearMN

        ElseIf Me.rdbBack7.Checked = True Then
            Dim DateTDAY As DateTime = Convert.ToDateTime(Date.Today, _cultureEnInfo)
            Dim Dateback As Date = DateAdd(DateInterval.Day, -6, Convert.ToDateTime(Date.Today, _cultureEnInfo))

            vWhere = vWhere & " AND " & vField & " BETWEEN '" & Dateback.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " & _
                              "AND '" & DateTDAY.ToString("yyyy-MM-dd", _cultureEnInfo) & "' "
        End If

        If eEvent = eProcess.eCancel Then  ' eCancel
            vWhere = vWhere & "And s.idPsAccept Is Null AND s.idPsCheck Is Null AND s.DateChcek Is Null AND s.idPsApp Is Null And s.DateApp Is Null And s.stApp Is Null"

        ElseIf eEvent = eProcess.eAccept Then  ' รับทราบ
            vWhere = vWhere & " And s.idPsAccept Is Null And s.DateAccept Is Null And s.idPsCancel Is Null " & _
                              "And (s.stApp <> '0' or s.stApp Is Null) "

        ElseIf eEvent = eProcess.eCheck Then  ' ตรวจสอบ
            vWhere = vWhere & " And s.idPsCheck Is Null And s.DateChcek Is Null And s.idPsCancel Is Null " & _
                              "And (s.stApp <> '0' or s.stApp Is Null) "

        ElseIf eEvent = eProcess.eApprove Then  ' อนุมัติ
            vWhere &= " AND (s.idPsApp IS NULL OR s.idPsApp2 Is NULL) "
            vWhere &= "AND ISNULL(s.idPsApp,0) <> " & sPsId & " "
            vWhere &= "AND ISNULL(s.idPsApp2,0) <> " & sPsId & " "
            vWhere &= "And s.idPsCancel Is Null "
            vWhere &= "AND s.stApp Is Null "

            'vWhere = vWhere & " And s.idPsApp Is Null And s.DateApp Is Null And s.stApp Is Null " & _
            '                  "And s.idPsCancel Is Null "

        ElseIf eEvent = eProcess.eCancelApv Then  ' ยกเลิกรับทราบ/ตรวจสอบ/อนุมัติ
            vWhere = vWhere & " And s.idPsCancel Is Null And (s.idPsAccept Is NOT Null OR s.idPsCheck Is NOT Null OR s.idPsApp Is NOT Null OR s.idPsApp2 Is NOT Null) "

        ElseIf eEvent = eProcess.eAddXY Then
            vWhere = vWhere & " And s.stBillType = 9 "

        ElseIf eEvent = eProcess.eAddBack Then
            vWhere = vWhere & " And ISNULL(s.stLot,0) = 0 "

        End If 'End stPage

        If ChkCancel.Checked = True Then
            vWhere = vWhere & " AND s.idPsCancel Is Null "
        End If

        Dim pConnection = New SqlConnection
        With pConnection
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connStrxP
            .Open()
        End With
        Dim pCommand = New SqlCommand(sSql, pConnection) With {.CommandTimeout = 10000}
        Dim pAdapter = New SqlDataAdapter(pCommand)

        Dim ds0 As New DataSet
        Dim MainDt As New DataTable  ' SaleMt
        Dim SubDt As New DataTable  ' SaleDt

        'MainDt.Clear()

        pCommand.CommandText = "SELECT CONVERT(bit,0) As chk, s.idSale, s.DocRef, s.DateSaleD As DateSale, sc.SaleCode, s.idPartner," & vbNewLine &
                                "devsk.fncStrDateToDateTime(s.DatePay) As DatePay, s.PartnerNameBill As CusName ,  " & vbNewLine &
                                "s.Total,  s.TotalNet, ISNULL(p6.PsName, '-') As PsSale, " & vbNewLine &
                                "s.DocCode, s.DocRefAcc, p1.PsName As PsTs, s.DateTsD As DateTs, s.TimeTs, s.TotalW, " & vbNewLine &
                                "ts.TspTypeName As Transport, s.idTs, t.PaymentTerms, comp.CompCode, " & vbNewLine &
                                "s.idPsCancel, s.CancelNote, p2.PsName As PsCancel, ISNULL(p3.PsName,'') As PsAccept, " & vbNewLine &
                                "devsk.fncStrDateToDateTime(s.DateAccept) As DateAccept, ISNULL(p4.PsName,'') As PsCheck, " & vbNewLine &
                                "devsk.fncStrDateToDateTime(s.DateChcek) As DateChcek, ISNULL(p5.PsName,'') As PsApp, ISNULL(p7.PsName,'') As PsApp2, s.DateApp2," & vbNewLine &
                                "devsk.fncStrDateToDateTime(s.DateApp) As DateApp, REPLACE(s.Note, '\', ' ') As Note,  ISNULL(s.stBillOrder,0) As stBillOrder, " & vbNewLine &
                                "s.stPromotion, s.idPsAppPromotion, s.stBillType, s.idCus , s.idComp, ISNULL(s.idSlAVxST, 0) As idSlAVxST, " & vbNewLine &
                                "IsNULL(ap.ApName, '-') As ApName, ISNULL(pv.PvName, '-' ) As PvName, IsNULL(s.idSend,0) As idSend, comp.CompName As CompanyName, " & vbNewLine &
                                "IIF( s.stLot IS NULL, '' ,CASE WHEN s.idComp = 10 THEN (SELECT CASE WHEN m.idWaitCutMt Is NULL THEN 'Draft' " & vbNewLine &
                                                              "WHEN  m.stNoApprove  IS NULL THEN '' Else 'Draft' END" & vbNewLine &
                                                              "FROM SmSaleMt " & vbNewLine &
                                                              "LEFT JOIN WimWaitCutMt m ON SmSaleMt.idSale = m.idMt AND ProcessID = 4" & vbNewLine &
                                                              "WHERE SmSaleMt.idSlAVxST = s.idSale)" & vbNewLine &
                                "WHEN wMt.idWaitCutMt Is NULL THEN 'Draft' " & vbNewLine &
                                "ELSE CASE WHEN wMt.stNoApprove IS NULL THEN '' Else 'Draft' END END) As stWaitCut" & vbNewLine &
                                "From SmSaleMt s " & vbNewLine &
                                "LEFT JOIN dPartner v ON s.idPartner = v.idPartner " & vbNewLine &
                                "LEFT JOIN SmSaleDocCode sc ON s.idSaleCode = sc.idSaleCode" & vbNewLine &
                                "LEFT JOIN dAp ap ON v.pidAp = ap.idAp" & vbNewLine &
                                "LEFT JOIN dProvinceFixSale As pv ON v.pidPv = pv.idPv" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p1 ON s.idPsTs = p1.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p2 ON s.idPsCancel = p2.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p3 ON s.idPsAccept = p3.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p4 ON s.idPsCheck = p4.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p5 ON s.idPsApp = p5.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p6 ON s.idPsSale = p6.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p7 ON s.idPsApp2 = p7.idPs" & vbNewLine &
                                "LEFT JOIN dTspType ts ON s.idTS = ts.idTspType " & vbNewLine &
                                "LEFT JOIN SmPaymentTermsD As t ON s.idPM  = t.idPM " & vbNewLine &
                                "LEFT JOIN PchInvAndProject.dbo.dCompany As comp ON s.idComp = comp.idComp" & vbNewLine &
                                "LEFT JOIN WimWaitCutMt wMt ON s.idSale = wMt.idMt AND wMt.ProcessID = 4" & vbNewLine &
                                "" & vWhere & " AND s.idComp IN (" & SIdCompStr & ")  Order by s.DocCode DESC"
        pAdapter.Fill(MainDt)

        MainDt.Columns.Add("ChkKey", System.Type.GetType("System.Boolean"))

        For i As Integer = 0 To MainDt.Rows.Count - 1
            MainDt.Rows(i).Item("ChkKey") = False
        Next

        '----------------------- Dt table ----------------------------'
        Dim tempDt As New DataTable

        'tempDt.Clear()

        pCommand.CommandText = "Select dt.No, dt.CodeOrder As OrderNo, bMt.DocCode As PONo, " & vbNewLine &
                               "CASE WHEN main.idInvGroup = 2 THEN pk.PdCode ELSE ic.InvCode END As InvCode, " & vbNewLine &
                               " dt.idSale, dt.idSaleDt, dt.idProduct, dt.idLot, pk.PdCode, dt.LotNo, dt.ProductName, s.idCus, s.idPsSale, " &
                               "dt.Amount, unit.UnitName, ISNULL(dt.DiscountPerc,0) As Discount, ISNULL(dt.DiscountBath,0) As DiscountBath, " &
                               "dt.Price, dt.TotalDt As ExSump, dt.idWh, bMt.DocCode As DocCode_PO, sw.full_lock " & vbNewLine &
                               "FROM SmSaleDtAll dt  " &
                               "LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine &
                               "LEFT OUTER JOIN SmSaleMt s ON dt.idSale = s.idSale " & vbNewLine &
                               "LEFT JOIN dInventoryMain As main ON dt.idProduct = main.idInvMain" & vbNewLine &
                               "LEFT JOIN dInvCode ic ON main.idInvMain = ic.idInvMain" & vbNewLine &
                               "LEFT JOIN dPackingPdSet As pk ON main.idSubType = pk.idPdPk AND main.idInvGroup = 2" & vbNewLine &
                               "LEFT JOIN PkPOBuyMt bMt ON dt.idPOTs = bMt.idPOTs" & vbNewLine &
                               "LEFT JOIN SsWareHouse sw ON dt.idWh = sw.idWh" & vbNewLine &
                               vWhere & " AND s.idComp IN (" & SIdCompStr & ")  Order by dt.No"

        pAdapter.Fill(tempDt)
        pConnection.Close()

        CopyMainDt = MainDt
        ds0.Tables.Clear()
        ds0.Tables.Add(MainDt)
        ds0.Tables.Add(tempDt)

        CopySmSaleDt = tempDt

        Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idSale")
        Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idSale")

        ds0.Relations.Add("รายการ", keyColumn, foreignColumn)

        If ds0.Tables(0).Rows.Count <= 0 Then
            MessageBox.Show("ไม่พบข้อมูลรายการขายสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        GridControl1.DataSource = ds0.Tables(0)
        GridControl1.ForceInitialize()

        GridControl1.LevelTree.Nodes.Add("รายการ", GVSaleDt)
        GridControl1.Refresh()
        stload = 1
        fnFilterDataOnGrid()
    End Sub

    Sub SumTotal()
        Dim TotalNet As Double = 0.0
        'For i As Integer = 0 To CopyMainDt.Rows.Count - 1
        '    If IsDBNull(CopyMainDt.Rows(i).Item("idPsCancel")) = True Then
        '        TotalNet += CopyMainDt.Rows(i).Item("TotalNet")
        '    End If
        'Next
        For i As Integer = 0 To GVSaleMt.DataRowCount - 1
            If IsDBNull(GVSaleMt.GetRowCellValue(i, "idPsCancel")) = True Then
                TotalNet += GVSaleMt.GetRowCellValue(i, "TotalNet")
            End If
        Next

        txtTotalNet.Text = Format(TotalNet, "#,##0.00##")
    End Sub

    Private Sub ChkDoc_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDoc.CheckedChanged

        If Me.ChkDoc.Checked = True Then
            Me.CCbEditDoc.Enabled = True
            Me.CCbEditDoc.Focus()
        Else
            Me.CCbEditDoc.Enabled = False
            'Me.CCbEditDoc.Properties.Items.Clear()
            For Each item As CheckedListBoxItem In CCbEditDoc.Properties.GetItems()
                item.CheckState = CheckState.Unchecked
            Next item

            'fnFilterDataOnGrid()
        End If

        'If stload = 1 Then
        '    fnFilterDataOnGrid()
        'End If
    End Sub

    Private Sub ChkCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCus.CheckedChanged
        If stload = 1 Then
            If Me.ChkCus.Checked = True Then
                Me.txtCusName.Enabled = True
                txtCusName.Focus()
            Else
                Me.txtCusName.Enabled = False
                txtCusName.Text = ""
                fnFilterDataOnGrid()
            End If
        End If
    End Sub

    Private Sub btnApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprove.Click
        Dim stMsg As Integer = 0
        Dim ChkRow As Integer = 0
        For i As Integer = 0 To CopyMainDt.Rows.Count - 1
            If CopyMainDt.Rows(i).Item("ChkKey") = True Then
                ChkRow = 1 ' มีอย่างน้อย 1 รายการที่เลือก
            End If
        Next

        If ChkRow = 0 Then
            Select Case eEvent
                Case eProcess.eAccept
                    MessageBox.Show("กรุณาเลือกรายการที่ต้องการรับทราบอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case eProcess.eCheck
                    MessageBox.Show("กรุณาเลือกรายการที่ต้องการตรวจสอบอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case eProcess.eApprove
                    MessageBox.Show("กรุณาเลือกรายการที่ต้องการอนุมัติอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select
            Exit Sub
        End If

        mdCnOpen()
        mdLoadShow()

        For i As Integer = 0 To CopyMainDt.Rows.Count - 1
            If CopyMainDt.Rows(i).Item("ChkKey") = True Then

                '---Update SmSaleMt Table---'
                Select Case eEvent

                    Case eProcess.eAccept  ' Accept
                        sCommand.CommandText = "Update SmSaleMt Set idPsAccept = " & sPsId & " , DateAccept = '" & ksbDateToString(Date.Today) & "' " &
                                               "Where idSale= " & CopyMainDt.Rows(i).Item("idSale") & ""

                    Case eProcess.eCheck ' Check
                        sCommand.CommandText = "Update SmSaleMt Set idPsCheck = " & sPsId & ", DateChcek = '" & ksbDateToString(Date.Today) & "' " &
                                               "Where idSale= " & CopyMainDt.Rows(i).Item("idSale") & ""

                    Case eProcess.eApprove  ' Approve

                        sCommand.CommandText = "IF (NOT EXISTS(SELECT idPsApp FROM SmSaleMt WHERE idSale = " & CopyMainDt.Rows(i).Item("idSale") & " AND idPsApp IS NOT NULL) )" & vbNewLine &
                                                   "BEGIN" & vbNewLine &
                                                        "Update SmSaleMt  SET idPsApp = " & sPsId & " , DateApp  = '" & ksbDateToString(Date.Today) & "'" & vbNewLine &
                                                        "WHERE idSale = " & CopyMainDt.Rows(i).Item("idSale") & vbNewLine &
                                                   "End" & vbNewLine &
                                               "Else " & vbNewLine &
                                                    "BEGIN" & vbNewLine &
                                                        "Update SmSaleMt SET idPsApp2 = " & sPsId & " , DateApp2 = GetDate() " & vbNewLine &
                                                        "WHERE idSale = " & CopyMainDt.Rows(i).Item("idSale") & vbNewLine &
                                                    "End"
                End Select

                sCommand.ExecuteNonQuery()


                Dim sDt As New DataTable
                sCommand.CommandText = "Select idPsAccept, idPsCheck, idPsApp, idPsApp2 From SmSaleMt Where idSale= " & CopyMainDt.Rows(i).Item("idSale") & ""
                sAdapter.Fill(sDt)

                If Not IsDBNull(sDt.Rows(0).Item("idPsAccept")) And Not IsDBNull(sDt.Rows(0).Item("idPsCheck")) And
                    Not IsDBNull(sDt.Rows(0).Item("idPsApp")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp2")) Then
                    '----Update stApp----'
                    sCommand.CommandText = "Update SmSaleMt Set stApp='1' Where idSale=" & CopyMainDt.Rows(i).Item("idSale") & ""
                    sCommand.ExecuteNonQuery()
                    stMsg = 1
                End If

            End If
        Next
        mdLoadCommitt()

        If stMsg = 1 Then
            MessageBox.Show("กระบวนการนี้มีบางรายการ เป็นการยืนยันขั้นตอนลำดับสุดท้าย ลำดับที่ 4", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Select Case eEvent
                Case eProcess.eAccept  'Accept
                    MessageBox.Show("รับทราบเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case eProcess.eCheck  'Check
                    MessageBox.Show("ตรวจสอบเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case eProcess.eApprove   'Approve
                    MessageBox.Show("อนุมัติเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        End If

        'SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        'BindData()
        'SplashScreenManager.CloseForm(False)

    End Sub

    Private Sub rdbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDate.CheckedChanged
        If stload = 1 Then
            If Me.rdbDate.Checked = True Then
                Me.dtpSaleS.Enabled = True
                Me.dtpSaleE.Enabled = True
            Else
                Me.dtpSaleS.Enabled = False
                Me.dtpSaleE.Enabled = False
            End If


        End If
    End Sub

    Private Sub rdbYear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbYear.CheckedChanged
        If stload = 1 Then
            If Me.rdbYear.Checked = True Then
                Me.dtpYear.Enabled = True
            Else
                Me.dtpYear.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMonth.CheckedChanged
        If stload = 1 Then
            If Me.rdbMonth.Checked = True Then
                Me.dtpMonthS.Enabled = True
                Me.dtpMonthE.Enabled = True
            Else
                Me.dtpMonthS.Enabled = False
                Me.dtpMonthE.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        Select Case eEvent
            Case eProcess.eAddXY

                Dim tempDt As New DataTable
                Dim vFrm As New frmSlReturnData(frmSlReturnData.eProcess.eNewSale, Nothing, tempDt)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    mdCnOpen()
                    BindData()
                    SumTotal()
                End If
            Case eProcess.eAddBack
                Dim vFrm As New frmSlSaleBack(frmSlSaleBack.eProcess.eAddBack, 0)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    mdCnOpen()
                    BindData()
                    SumTotal()
                    btnNew.PerformClick()
                End If
            Case Else
                Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eAddCombine, 0, 0)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    mdCnOpen()
                    BindData()
                    SumTotal()
                    btnNew.PerformClick()
                End If
        End Select


    End Sub

    Private Sub ChkPsSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPsSale.CheckedChanged
        If stload = 1 Then
            If Me.ChkPsSale.Checked = True Then

                Me.txtPsSale.Enabled = True
                txtPsSale.Focus()
            Else
                Me.txtPsSale.Enabled = False
                Me.txtPsSale.Text = ""
                fnFilterDataOnGrid()
            End If
        End If
    End Sub

    Private Sub rdbMonthNow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMonthNow.CheckedChanged
        If stload = 1 Then
            If Me.rdbMonthNow.Checked = True Then
                Me.dtpMonthNow.Enabled = True
            Else
                Me.dtpMonthNow.Enabled = False
            End If
        End If
    End Sub

    Private Sub ChkDocCode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDocCode.CheckedChanged
        If stload = 1 Then
            If Me.ChkDocCode.Checked = True Then
                Me.txtDocCode.Enabled = True
                Me.txtDocCode.Focus()

            Else
                Me.txtDocCode.Enabled = False
                Me.txtDocCode.Text = ""
                fnFilterDataOnGrid()
            End If
        End If
    End Sub


    Private Sub ChkTsp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkTsp.CheckedChanged
        If stload = 1 Then
            If Me.ChkTsp.Checked = True Then
                Me.cmbTsp.Enabled = True
            Else
                Me.cmbTsp.Enabled = False
                fnFilterDataOnGrid()
            End If

        End If
    End Sub

    Private Sub ChkDocRef_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDocRef.CheckedChanged
        If stload = 1 Then
            If Me.ChkDocRef.Checked = True Then
                Me.txtDocRef.Enabled = True

                Me.txtDocRef.Focus()
            Else
                Me.txtDocRef.Enabled = False
                txtDocRef.Text = ""
                fnFilterDataOnGrid()
            End If
        End If
    End Sub

    'Show Data & Edit
    Private Sub rptEdit_Click(sender As Object, e As EventArgs) Handles rptEdit.Click
        ' Dim stPass As Integer = 0
        If IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidCancel1)) = True Then

            idSaleShow = GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)
            'Dim idSent As Integer = GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidSend)

            If eEvent = eProcess.eCancel Or eEvent = eProcess.eAccept Or eEvent = eProcess.eCheck Or eEvent = eProcess.eApprove Or eEvent = eProcess.eView Then
                If IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillType1)) Then
                    Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eView, idSaleShow, 0)
                    vFrm.ShowDialog()
                ElseIf GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillType1) = 9 Then 'บิล XY จากรายการคืน JU
                    Dim vFrm As New frmSlReturnToSale(frmSlReturnToSale.eProcess.eEdit, 0, idSaleShow, GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp))
                    vFrm.ShowDialog()
                Else
                    Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eView, idSaleShow, 0)
                    vFrm.ShowDialog()

                    'If GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillOrder1) = 0 Then
                    '    Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eView, idSaleShow, 0)
                    '    vFrm.ShowDialog()

                    'ElseIf GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillOrder1) = 1 Then
                    '    Dim vFrm As New frmSlSaleTsASG(frmSlSaleTsASG.eProcess.eViewOrder, GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1))
                    '    vFrm.ShowDialog()
                    'End If
                End If


            ElseIf eEvent = eProcess.eAddCombine Then 'eAddCombine

                'SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                mdCnOpen()
                Dim stEdit As Integer = 0
                'Dim dtEdit As New DataTable
                If GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp) = 10 Then
                    Dim dtidSaleAV As New DataTable
                    sCommand.CommandText = "SELECT idSale As idSaleAV FROM SmSaleMt WHERE idSlAVxST = " & idSaleShow
                    sAdapter.Fill(dtidSaleAV)

                    sCommand.CommandText = "select  ISNULL(devsk.[WimCheckstUseCutWait] (" & dtidSaleAV.Rows(0).Item("idSaleAV") & ",4),0)"
                    stEdit = sCommand.ExecuteScalar
                Else
                    sCommand.CommandText = "select  ISNULL(devsk.[WimCheckstUseCutWait] (" & idSaleShow & ",4),0)"
                    stEdit = sCommand.ExecuteScalar
                End If


                'SplashScreenManager.CloseForm(False)
                'If stEdit = 0 Then


                'Dim stRec As Integer = 0

                'sCommand.CommandText = "SELECT ISNULL(devsk.[WimCheckstUseRecieveWait] (" & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1) & ",11),0)"
                'stRec = sCommand.ExecuteScalar

                'If stRec <> 0 Then
                '    MessageBox.Show("ไม่สามารถแก้ไขรายการนี้ได้" & vbNewLine & _
                '                    "เนื่องจาก " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColCusName1) & " มีการรับสินค้าเข้าคลังแล้ว" & vbNewLine & _
                '                    "หากต้องการแก้ไข กรุณายกเลิกรายการรับก่อน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                '        Exit Sub
                'End If

                If GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColPsAccept1) = "" And
                        GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColPsCheck1) = "" And
                        GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColPsApp) = "" Then


                    Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eEditCombine, idSaleShow, stEdit)

                    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

                        BindData()
                        SumTotal()
                    End If

                    'If GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillOrder1) = 0 Then

                    '    Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eEditCombine, idSaleShow, stEdit)

                    '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

                    '        BindData()
                    '        SumTotal()
                    '    End If
                    'ElseIf GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillOrder1) = 1 Then
                    '    Dim vFrm As New frmSlSaleTsASG(frmSlSaleTsASG.eProcess.eEditOrder, GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1))

                    '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

                    '        BindData()
                    '        SumTotal()
                    '    End If
                    'End If

                Else

                    MessageBox.Show("รายการนี้ไม่สามารถแก้ไขข้อมูลได้" & vbCrLf & "เนื่องจากมีการรับทราบ ตรวจสอบ อนุมัติแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                'Else

                '    MessageBox.Show("รายการนี้สามารถแก้ไขได้เฉพาะราคา" & vbCrLf & "เนื่องจากมีการเบิกของออกจากคลังแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    Exit Sub
                'End If
            ElseIf eEvent = eProcess.eAddBack Then
                If GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColPsAccept1) = "" And
                        GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColPsCheck1) = "" And
                        GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColPsApp) = "" Then
                    Dim vFrm As New frmSlSaleBack(frmSlSaleBack.eProcess.eEditBack, idSaleShow)
                    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        BindData()
                        SumTotal()
                    End If
                End If


            ElseIf eEvent = eProcess.eAddXY Then
                    Dim vFrm As New frmSlReturnToSale(frmSlReturnToSale.eProcess.eEdit, 0, idSaleShow, GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp))
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    mdLoadShow()
                    BindData()
                    SumTotal()
                    mdLoadCommitt()
                End If

            End If

        End If


    End Sub

    ' Show Bill
    Private Sub rptDoc_Click(sender As Object, e As EventArgs) Handles rptDoc.Click
        If IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidCancel1)) = True Then
            'idSaleShow = GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)

            mdCnOpen()
            Dim ChkDt As New DataTable
            sCommand.CommandText = "SELECT stTbApv FROM devsk.TblApvStatus where TblName = 'SmSaleMt'"
            sAdapter.Fill(ChkDt)

            Dim chkComp As New DataTable
            'sCommand.CommandText = "SELECT idComp FROM PchInvAndProject.devsk.dGroupCompMap " & vbNewLine & _
            '                       "WHERE parentid IN (2,3) AND idComp = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp) & " AND stActive = 1"
            sCommand.CommandText = "SELECT ISNULL(TypeInvoice, '0') As TypeInvoice " & vbNewLine & _
                                    "FROM PchInvAndProject.dbo.dCompany " & vbNewLine & _
                                    "WHERE idComp = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp) & vbNewLine & _
                                    "AND stDel IS NULL"
            sAdapter.Fill(chkComp)


            If ChkDt.Rows(0).Item("stTbApv") = 0 Then 'No Check Approve

                'If GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp) = 2 Or GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp) = 3 Then
                If chkComp.Rows(0).Item("TypeInvoice") = "1" Then
                    fnGetReport(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp))
                Else
                    Dim vFrm As New frmVATSelect
                    vFrm.ShowText(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1), GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp))
                    vFrm.ShowDialog()
                End If


            Else ' Check status Approve
                If IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColPsAccept1)) = False _
                And IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColPsCheck1)) = False _
                And IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColPsApp)) = False Then

                    If chkComp.Rows(0).Item("TypeInvoice") = "1" Then
                        fnGetReport(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp))
                    Else
                        Dim vFrm As New frmVATSelect
                        vFrm.ShowText(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1), GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp))
                        vFrm.ShowDialog()
                    End If
                Else
                    MessageBox.Show("รายการยังไม่ผ่านกระบวนการรับทราบ ตรวจสอบ อนุมัติ จึงไม่สามารถออกใบส่งสินค้าได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub


    Private Sub fnGetReport(ByVal idComp As Integer)

        Dim AddressComp As String = ""
        Dim CompnameEng As String = ""
        Dim AddressEng As String = ""
        Dim TelComp As String = ""
        Dim FaxComp As String = ""
        Dim TexCode As String = ""
        Dim stSignPsSale As Integer = 0

        Dim dt As New DataTable
        mdCnOpen2()
        sCommand.CommandText = "Select Address_, Tel, Fax, TaxCode, ISNULL(CompNameEng, '') As CompNameEng, " & _
                               "ISNULL(AddressEng_, '') As  AddressEng From vCompany Where idComp = " & cmbGroupComp.SelectedValue & ""
        sAdapter.Fill(dt)

        AddressComp = dt.Rows(0).Item("Address_")
        CompnameEng = dt.Rows(0).Item("CompNameEng")
        AddressEng = dt.Rows(0).Item("AddressEng")

        If IsDBNull(Trim(dt.Rows(0).Item("Tel"))) Then
            TelComp = "-"
        Else
            TelComp = Trim(dt.Rows(0).Item("Tel"))
        End If

        If IsDBNull(dt.Rows(0).Item("Fax")) Then
            FaxComp = "-"
        Else
            FaxComp = Trim(dt.Rows(0).Item("Fax"))
        End If

        If IsDBNull(dt.Rows(0).Item("TaxCode")) Then
            TexCode = "-"
        Else
            TexCode = dt.Rows(0).Item("TaxCode")
        End If

        '****พิมพ์ใบส่งของ****-
        Dim DeliveryDoc As New DataTable
        DeliveryDoc.Clear()
        DeliveryDoc.Columns.Add("idSale", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("DateTs", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("DateSale", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("DatePay", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("DocCode", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("DocRef", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("Total", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("DiscountAmout", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("DiscountPerc", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("TotalNet", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("CusName", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("PsSale", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("PaymentTerms", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("Transport", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("note", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("idPdPk", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("Amount", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("Price", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("DisPerc", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("DiscountBath", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("PdPkName", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("idPkUnit", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("PkUnitName", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("PdCode", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("address", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("AddressS", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("Tel", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("Fax", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("idPsSale", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("idCus", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("picSignPsSale", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("RegianName", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("PriceBfDis", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("TaxCode", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("PsRecName", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("picSignPsTs", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("idPsTs", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("idPsAccept", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("idPsCheck", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("idPsApprove", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("idPsApprove2", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("picSignAccept", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("picSignCheck", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("picSignApprove", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("picSignApprove2", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("DocCode_PO", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("idComp", System.Type.GetType("System.Int32"))

        DeliveryDoc.Columns.Add("idPsSender", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("picSignPsSender", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("idPsRec", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("picSignPsRec", System.Type.GetType("System.Byte[]"))



        mdCnOpen()


        Dim sDt3 As New DataTable
        sDt3.Clear()

        sCommand.CommandText = "Select m.idSale, m.DateTsD As DateTs, m.DateSaleD As DateSale, m.idComp," & vbNewLine &
                             "devsk.fncStrDateToDateTime(m.DatePay) As DatePay, m.DocCode, m.DocRef, m.Total, ISNULL(m.DiscountAmout,0) As DisCountAmout, " & vbNewLine &
                             "ISNULL(m.DiscountPerc,0) As DiscountPerc, m.TotalNet, m.PartnerNameBill As CusName, m.PsSale, m.PaymentTerms, m.Transport, m.note, " & vbNewLine &
                             "idProduct, d.Amount, d.Price, d.PriceBfDis, " & vbNewLine &
                             "d.ProductName, d.Lotno, d.idUnit, unit.UnitName, '' As PdCode, " & vbNewLine &
                             "p.pAddress As address, m.AddressS, p.pTel As Tel, inv.idInvgroup, " & vbNewLine &
                             "c.Fax, c.TaxCode, m.idPsSale, m.idPsSet, m.idPsSend, m.idCus, m.PsRecName, m.TelOfAddrSent, ISNULL(m.stFromS, 1) As stFromS, " & vbNewLine &
                             "m.idPsTs, m.idPsAccept, m.idPsCheck, m.idPsApp As idPsApprove, m.idPsApp2 As idPsApprove2, IsNULL(lq.Grad, '') As Grad,
                             ISNULL((CASE WHEN d.DiscountPerc <> 0 THEN ((d.DiscountPerc*d.PriceBfDis)/100) ELSE d.DiscountBath END),0) As DisCount, ISNULL(bMt.DocCode,'-') As DocCode_PO, m.idPsSender, m.idPsRec" & vbNewLine &
                             "FROM vSmSaleDtAllxSlTs d " & vbNewLine &
                             "LEFT OUTER JOIN vSmSaleMt m ON d.idSale = m.idSale " & vbNewLine &
                             "LEFT JOIN dInvLotQuality lq ON d.idLot = lq.idLot" & vbNewLine &
                             "LEFT JOIN dPartner p ON m.idPartner = p.idPartner" & vbNewLine &
                             "LEFT JOIN dInventoryMain inv ON d.idProduct = inv.idInvMain" & vbNewLine &
                             "LEFT OUTER JOIN dCustomer c ON m.idCus = c.idCus " &
                             "LEFT JOIN dInvUnit As unit ON d.idUnit = unit.idUnit" & vbNewLine &
                             "LEFT JOIN PkPOBuyMt bMt ON d.idPOTs = bMt.idPOTs" & vbNewLine &
                             "WHERE m.idSale = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1) & vbNewLine &
                             "Order by No ASC"
        sAdapter.Fill(sDt3)
        '(CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END)
        For i As Integer = 0 To sDt3.Rows.Count - 1
            Dim rc As Integer = DeliveryDoc.Rows.Count
            DeliveryDoc.Rows.Add()

            DeliveryDoc.Rows(rc).Item("idSale") = sDt3.Rows(i).Item("idSale")
            DeliveryDoc.Rows(rc).Item("DateTs") = Format(sDt3.Rows(i).Item("DateTs"), "dd/MM/yyyy")
            DeliveryDoc.Rows(rc).Item("DateSale") = Format(sDt3.Rows(i).Item("DateSale"), "dd/MM/yyyy")
            DeliveryDoc.Rows(rc).Item("DatePay") = Format(sDt3.Rows(i).Item("DatePay"), "dd/MM/yyyy")
            DeliveryDoc.Rows(rc).Item("DocCode") = sDt3.Rows(i).Item("DocCode")
            DeliveryDoc.Rows(rc).Item("DocRef") = sDt3.Rows(i).Item("DocRef")
            DeliveryDoc.Rows(rc).Item("Total") = sDt3.Rows(i).Item("Total")
            DeliveryDoc.Rows(rc).Item("DiscountAmout") = sDt3.Rows(i).Item("DiscountAmout")
            DeliveryDoc.Rows(rc).Item("DiscountPerc") = sDt3.Rows(i).Item("DiscountPerc")


            DeliveryDoc.Rows(rc).Item("TotalNet") = sDt3.Rows(i).Item("TotalNet")
            DeliveryDoc.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
            DeliveryDoc.Rows(rc).Item("PsSale") = sDt3.Rows(i).Item("PsSale")
            DeliveryDoc.Rows(rc).Item("PaymentTerms") = sDt3.Rows(i).Item("PaymentTerms")
            DeliveryDoc.Rows(rc).Item("Transport") = sDt3.Rows(i).Item("Transport")
            DeliveryDoc.Rows(rc).Item("note") = sDt3.Rows(i).Item("note")
            DeliveryDoc.Rows(rc).Item("idPdPk") = sDt3.Rows(i).Item("idProduct")
            DeliveryDoc.Rows(rc).Item("Amount") = sDt3.Rows(i).Item("Amount")
            DeliveryDoc.Rows(rc).Item("Price") = sDt3.Rows(i).Item("Price")
            DeliveryDoc.Rows(rc).Item("DiscountBath") = sDt3.Rows(i).Item("DisCount")
            DeliveryDoc.Rows(rc).Item("DocCode_PO") = sDt3.Rows(i).Item("DocCode_PO")
            DeliveryDoc.Rows(rc).Item("idComp") = sDt3.Rows(i).Item("idComp")

            If sDt3.Rows(i).Item("idInvgroup") = 30 Then 'ค่าขนส่ง
                DeliveryDoc.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("ProductName")
            Else
                If sDt3.Rows(i).Item("idInvgroup") = 1 And sDt3.Rows(i).Item("Grad") <> "" Then

                    DeliveryDoc.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("ProductName") & vbNewLine & "Lot No. : " & sDt3.Rows(i).Item("Lotno") & " (Grad: " & sDt3.Rows(i).Item("Grad") & ")"
                Else
                    DeliveryDoc.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("ProductName") & vbNewLine & "Lot No. : " & sDt3.Rows(i).Item("Lotno")
                End If
            End If

            DeliveryDoc.Rows(rc).Item("idPkUnit") = sDt3.Rows(i).Item("idUnit")
            DeliveryDoc.Rows(rc).Item("PkUnitName") = sDt3.Rows(i).Item("UnitName")
            DeliveryDoc.Rows(rc).Item("PdCode") = sDt3.Rows(i).Item("PdCode")
            DeliveryDoc.Rows(rc).Item("address") = sDt3.Rows(i).Item("address")
            'If sDt.Rows(i).Item("idPV") = 1 Then
            '    DeliveryDoc.Rows(rc).Item("address") = sDt.Rows(i).Item("address").ToString.Replace("เขต", vbNewLine & "เขต")
            'Else
            '    DeliveryDoc.Rows(rc).Item("address") = sDt.Rows(i).Item("address").ToString.Replace("อ.", vbNewLine & "อ.")
            'End If
            ' DeliveryDoc.Rows(rc).Item("AddressS") = sDt3.Rows(i).Item("AddressS")
            DeliveryDoc.Rows(rc).Item("Tel") = sDt3.Rows(i).Item("Tel")
            DeliveryDoc.Rows(rc).Item("Fax") = sDt3.Rows(i).Item("Fax")
            DeliveryDoc.Rows(rc).Item("idPsSale") = sDt3.Rows(i).Item("idPsSale")
            DeliveryDoc.Rows(rc).Item("idCus") = sDt3.Rows(i).Item("idCus")
            DeliveryDoc.Rows(rc).Item("PriceBfDis") = sDt3.Rows(i).Item("PriceBfDis")
            DeliveryDoc.Rows(rc).Item("TaxCode") = sDt3.Rows(i).Item("TaxCode")
            'If Not IsDBNull(sDt3.Rows(i).Item("PsRecName")) Then
            '    DeliveryDoc.Rows(rc).Item("PsRecName") = sDt3.Rows(i).Item("PsRecName")
            'End If
            DeliveryDoc.Rows(rc).Item("idPsTs") = sDt3.Rows(i).Item("idPsTs")
            DeliveryDoc.Rows(rc).Item("idPsAccept") = sDt3.Rows(i).Item("idPsAccept")
            DeliveryDoc.Rows(rc).Item("idPsCheck") = sDt3.Rows(i).Item("idPsCheck")
            DeliveryDoc.Rows(rc).Item("idPsApprove") = sDt3.Rows(i).Item("idPsApprove")
            DeliveryDoc.Rows(rc).Item("idPsApprove2") = sDt3.Rows(i).Item("idPsApprove2")

            DeliveryDoc.Rows(rc).Item("idPsSender") = sDt3.Rows(i).Item("idPsSender")
            DeliveryDoc.Rows(rc).Item("idPsRec") = sDt3.Rows(i).Item("idPsRec")
        Next

        'Dim URL As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & gidComp & ".jpg"
        'Dim client As New System.Net.WebClient
        'Dim buffer As Byte()
        'Dim pic() As Byte

        Dim URL1 As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp) & ".jpg"
        Dim client As New System.Net.WebClient
        Dim buffer As Byte()
        Dim pic() As Byte

        Try
            buffer = client.DownloadData(URL1)
            Dim stream1 As New System.IO.MemoryStream(buffer)
            Dim binReader1 As New IO.BinaryReader(stream1)
            pic = binReader1.ReadBytes(stream1.Length)
            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picComp") = pic
            Next
        Catch ex As Exception
            ' Noimage
        End Try

        'If sIdComp = 11 Then 'siamAdvanceHost
        '---sign PsTs Pic---'

        Dim URL2 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & sDt3.Rows(0).Item("idPsTs") & ".png"
        'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
        Try
            buffer = client.DownloadData(URL2)
            Dim stream As New System.IO.MemoryStream(buffer)
            Dim binReader As New IO.BinaryReader(stream)
            pic = binReader.ReadBytes(stream.Length)
            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picSignPsTs") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try

        '---sign PsAccept Pic---'
        Dim URL3 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & DeliveryDoc.Rows(0).Item("idPsAccept") & ".png"
        Try
            buffer = client.DownloadData(URL3)
            Dim stream2 As New System.IO.MemoryStream(buffer)
            Dim binReader2 As New IO.BinaryReader(stream2)
            pic = binReader2.ReadBytes(stream2.Length)

            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picSignAccept") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try


        '---sign PsCheck Pic---'
        Dim URL4 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & DeliveryDoc.Rows(0).Item("idPsCheck") & ".png"
        Try
            buffer = client.DownloadData(URL4)
            Dim stream3 As New System.IO.MemoryStream(buffer)
            Dim binReader3 As New IO.BinaryReader(stream3)
            pic = binReader3.ReadBytes(stream3.Length)

            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picSignCheck") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try


        '---sign PsApprove Pic---'
        Dim URL5 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & DeliveryDoc.Rows(0).Item("idPsApprove") & ".png"

        Try
            buffer = client.DownloadData(URL5)
            Dim stream4 As New System.IO.MemoryStream(buffer)
            Dim binReader4 As New IO.BinaryReader(stream4)
            pic = binReader4.ReadBytes(stream4.Length)

            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picSignApprove") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try

        '---sign PsApprove2 Pic---'
        Dim URL6 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & DeliveryDoc.Rows(0).Item("idPsApprove2") & ".png"

        Try
            buffer = client.DownloadData(URL6)
            Dim stream5 As New System.IO.MemoryStream(buffer)
            Dim binReader5 As New IO.BinaryReader(stream5)
            pic = binReader5.ReadBytes(stream5.Length)

            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picSignApprove2") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try

        '---sign picSignPsSender Pic---'
        Dim URL7 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & DeliveryDoc.Rows(0).Item("idPsSender") & ".png"

        Try
            buffer = client.DownloadData(URL7)
            Dim stream6 As New System.IO.MemoryStream(buffer)
            Dim binReader5 As New IO.BinaryReader(stream6)
            pic = binReader5.ReadBytes(stream6.Length)

            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picSignPsSender") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try


        '---sign picSignPsRec Pic---'
        Dim URL8 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & DeliveryDoc.Rows(0).Item("idPsRec") & ".png"

        Try
            buffer = client.DownloadData(URL8)
            Dim stream7 As New System.IO.MemoryStream(buffer)
            Dim binReader5 As New IO.BinaryReader(stream7)
            pic = binReader5.ReadBytes(stream7.Length)

            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picSignPsRec") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try

        Dim RegionDt As New DataTable
        RegionDt.Clear()

        sCommand.CommandText = "Select r.RegionName, ps.idPsSale" & vbNewLine &
                                "From SmRegionDComp r" & vbNewLine &
                                "Left Join SmMkCusPs p ON p.idRegionC = r.idRegion" & vbNewLine &
                                "Left Join SmRegionPsSaleComp ps ON ps.idRegionC = r.idRegion " & vbNewLine &
                                "WHERE ps.idComp = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp) & vbNewLine &
                                "And p.idCus = " & DeliveryDoc.Rows(0).Item("idCus") & vbNewLine &
                                "AND ps.idPsSale = " & DeliveryDoc.Rows(0).Item("idPsSale")



        'sCommand.CommandText = "Select r.RegionName, s.idPsSale FROM SmRegionSaleSet AS s LEFT OUTER JOIN " & _
        '                       "SmRegionD AS r ON s.idRegion = r.idRegion Where " & _
        '                       "s.idPsSale = '" & DeliveryDoc.Rows(0).Item("idPsSale") & "'"
        sAdapter.Fill(RegionDt)
        Dim Regionlist As String = ""
        For i As Integer = 0 To RegionDt.Rows.Count - 1
            If i = 0 Then
                Regionlist = RegionDt.Rows(i).Item("RegionName")
            Else
                Regionlist = Regionlist & ", " & RegionDt.Rows(i).Item("RegionName")
            End If
        Next

        For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
            DeliveryDoc.Rows(i).Item("RegianName") = Regionlist
        Next

        Dim BillName As String = "ใบส่งของ / ใบวางบิล"

        If GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp) = 64 Then 'A Print Company
            BillName = "ใบแจ้งหนี้ / ใบส่งของ"
        ElseIf GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp) = 3 Then
            BillName = "ใบส่งของ / ใบแจ้งหนี้ / ใบวางบิล"
        End If

        Dim vRpt As New crpDeliveryBill
        vRpt.SetDataSource(DeliveryDoc)
        vRpt.SetParameterValue(vRpt.Parameter_idSale.ParameterFieldName, GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1))
        vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColCompName))
        vRpt.SetParameterValue(vRpt.Parameter_CompNameEng.ParameterFieldName, CompnameEng)
        vRpt.SetParameterValue(vRpt.Parameter_AddressCompEng.ParameterFieldName, AddressEng)
        vRpt.SetParameterValue(vRpt.Parameter_AddressComp.ParameterFieldName, AddressComp)
        vRpt.SetParameterValue(vRpt.Parameter_CompTel.ParameterFieldName, TelComp)
        vRpt.SetParameterValue(vRpt.Parameter_CompFax.ParameterFieldName, If(FaxComp = "", "-", FaxComp))
        vRpt.SetParameterValue(vRpt.Parameter_TaxCode.ParameterFieldName, TexCode)
        vRpt.SetParameterValue(vRpt.Parameter_BillName.ParameterFieldName, BillName)
        'vRpt.SetParameterValue(vRpt.Parameter_stSignPsSale.ParameterFieldName, stSignPsSale)

        '--show from cystalreport--'
        Dim vFrmRpt As New FrmReportView
        vFrmRpt.crView.ReportSource = vRpt
        vFrmRpt.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        vFrmRpt.crView.ShowExportButton = False
        vFrmRpt.crView.ShowGroupTreeButton = False
        vFrmRpt.Show()
    End Sub

    ' Cancel

    Private Sub rptCancel_Click(sender As Object, e As EventArgs) Handles rptCancel.Click
        If eEvent = eProcess.eCancel Then  ' eCancel

            '------Check สถานะ AUTO BILL จาก ST
            If GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidSlAVxST) <> 0 Then
                MessageBox.Show("ไม่สามารถยกเลิกรายการนี้ได้" & vbNewLine & _
                                "เนื่องจากเป็นรายการที่ถูกบันทึกด้วยระบบ AUTO BILL" & vbNewLine & _
                                "หากต้องการยกเลิก กรุณายกเลิกที่รายการขายต้นทาง (ST)", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub

            End If

            '------Check สถานะเบิกของออกจากคลัง
            mdCnOpen()
            Dim stEdit As Integer = 0
            sCommand.CommandText = "SELECT ISNULL(devsk.[WimCheckstUseCutWait] (" & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1) & ",4),0)"
            stEdit = sCommand.ExecuteScalar

            If stEdit <> 0 Then
                MessageBox.Show("รายการนี้ไม่สามารถยกเลิกได้" & vbCrLf & "เนื่องจากมีการเบิกแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            '------Check สถานะขนส่ง
            If GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidSend) <> 0 Then
                MessageBox.Show("ไม่สามารถยกเลิกรายการนี้ได้" & vbNewLine &
                                        "เนื่องจากอยู่ในขั้นตอนการขนส่งแล้ว" & vbNewLine &
                                        "หากต้องการยกเลิก กรุณายกเลิกรายการขนส่งก่อน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            '-------สถานะ คนรับทราบตรวจสอบ อนุมัติ
            If GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColPsAccept1) = "" And _
               GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColPsCheck1) = "" And _
               GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColPsApp) = "" Then

                If GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillOrder1) Then

                End If

                If IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidCancel1)) = True Then


                    '-------ถ้ามีการรับเข้าคลังแล้ว จะยกเลิกการขายไม่ได้ (ในอนาคต ลบ Process นี้ได้ ใช้เชคจากรอรับแทน)
                    Dim dt1 As New DataTable
                    mdCnOpen()
                    sCommand.CommandText = "SELECT stWIMAllRec FROM SmSaleDtAll WHERE idSale = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1) & " AND stWIMAllRec IN(1) "
                    sAdapter.Fill(dt1)

                    If dt1.Rows.Count > 0 Then
                        MessageBox.Show("ไม่สามารถยกเลิกรายการนี้ได้" & vbNewLine & _
                                        "เนื่องจาก " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColCusName1) & " มีการรับสินค้าเข้าคลังแล้ว" & vbNewLine & _
                                        "หากต้องการยกเลิก กรุณายกเลิกรายการรับสินค้าในเครือก่อน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    'Dim stRec As Integer = 0

                    'sCommand.CommandText = "SELECT ISNULL(devsk.[WimCheckstUseRecieveWait] (" & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1) & ",11),0)"
                    'stRec = sCommand.ExecuteScalar

                    'If stRec <> 0 Then
                    '    MessageBox.Show("ไม่สามารถยกเลิกรายการนี้ได้" & vbNewLine & _
                    '                    "เนื่องจาก " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColCusName1) & " มีการรับสินค้าเข้าคลังแล้ว" & vbNewLine & _
                    '                    "หากต้องการยกเลิก กรุณายกเลิกรายการรับก่อน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '    Exit Sub
                    'End If


                    Dim CancelNote As String = " "
                    CancelNote = InputBox("ระบุสาเหตุการยกเลิก", sSystemName)
                    If CancelNote.Length = 0 Then
                        MessageBox.Show("กรุณาระบุสาเหตุการยกเลิก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                            Dim myAdapter = New SqlDataAdapter(mycommand)
                            Try
                                Dim dtidSaleAV As New DataTable
                                mycommand.CommandText = "SELECT idSale FROM SmSaleMt Where idSlAVxST = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)
                                myAdapter.Fill(dtidSaleAV)

                                If dtidSaleAV.Rows.Count > 0 Then
                                    'Cancel Bill AUTO ขาย AV -> ST
                                    mycommand.CommandText = "Update SmSaleMt Set idPsCancel = " & sPsId & " , CancelNote = 'ระบบยกเลิกขายอัตโนมัติระหว่าง AV-ST' " &
                                                          "Where idSale = " & dtidSaleAV.Rows(0).Item("idSale")
                                    mycommand.ExecuteNonQuery()

                                    'ยกเลิกรอเบิก AV
                                    mycommand.CommandText = "EXEC WaitCutTs '4','SmSaleMt','SmSaleDtAll','idSale'," & dtidSaleAV.Rows(0).Item("idSale") &
                                                           "," & cmbGroupComp.SelectedValue & "," & sPsId & ",'3'"
                                    mycommand.ExecuteNonQuery()

                                    'ยกเลิกบิลขาย ST -> ลูกค้า
                                    mycommand.CommandText = "Update SmSaleMt Set idPsCancel = " & sPsId & " , CancelNote = '" & CancelNote & "' " &
                                                        "Where idSale = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)
                                    mycommand.ExecuteNonQuery()

                                    'ยกเลิกรอเบิก ST
                                    mycommand.CommandText = "EXEC WaitCutTs '4','SmSaleMt','SmSaleDtAll','idSale'," & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1) &
                                                                "," & cmbGroupComp.SelectedValue & "," & sPsId & ",'3'"
                                    mycommand.ExecuteNonQuery()


                                    Dim UpdateDtAll As New DataTable
                                    'mycommand.CommandText = "SELECT idSaleDtOther, idPdOLot, Amount, stCutStock, idJUDt, idSaleReturn FROM SmSaleDtOther Where " & _
                                    '                       "idSale ='" & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1) & "'"
                                    mycommand.CommandText = "SELECT dt.idSaleDt, dt.LotNo, dt.Amount, ISNULL(dt.idSaleOrderDt,0) As idSaleOrderDt, ISNULL(oDt.idSaleOrder,0) As idSaleOrder, " & vbNewLine &
                                                           "dt.idSaleReturn, dt.idJUDt, ISNULL(dt.idLot,0) As idLot, dt.idProduct, dt.idWh , dt.idUnit, inv.idInvGroup" & vbNewLine &
                                                           "FROM SmSaleDtAll dt " & vbNewLine &
                                                           "LEFT JOIN SmSaleOrderDt oDt ON dt.idSaleOrderDt = oDt.idSaleOrderDt" & vbNewLine &
                                                           "LEFT JOIN dInventoryMain inv ON dt.idProduct = inv.idInvMain" & vbNewLine &
                                                           "Where dt.idSale = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)

                                    myAdapter.Fill(UpdateDtAll)

                                    For i As Integer = 0 To UpdateDtAll.Rows.Count - 1
                                        If UpdateDtAll.Rows(i).Item("idSaleOrderDt") <> 0 Then
                                            mycommand.CommandText = "UPDATE SmSaleOrderDt SET Amount = Amount - " & CDbl(UpdateDtAll.Rows(i).Item("Amount")) & vbNewLine &
                                                                    ", AmountPiece = AmountPiece - " & CDbl(UpdateDtAll.Rows(i).Item("Amount")) & vbNewLine &
                                                                    "WHERE idSaleOrderDt = " & UpdateDtAll.Rows(i).Item("idSaleOrderDt")
                                            mycommand.ExecuteNonQuery()

                                            Dim dtAmtOrder As New DataTable
                                            mycommand.CommandText = "SELECT Amount FROM SmSaleOrderDt Where idSaleOrderDt = " & UpdateDtAll.Rows(i).Item("idSaleOrderDt")
                                            myAdapter.Fill(dtAmtOrder)

                                            If dtAmtOrder.Rows(0).Item("Amount") = 0 Then
                                                mycommand.CommandText = "DELETE FROM SmSaleOrderDt Where idSaleOrderDt = " & UpdateDtAll.Rows(i).Item("idSaleOrderDt")
                                                mycommand.ExecuteNonQuery()
                                            End If

                                            Dim dtOrderMt As New DataTable
                                            mycommand.CommandText = "SELECT idSaleOrderDt FROM SmSaleOrderDt Where idSaleOrder = " & UpdateDtAll.Rows(i).Item("idSaleOrder")
                                            myAdapter.Fill(dtOrderMt)

                                            If dtOrderMt.Rows.Count = 0 Then
                                                mycommand.CommandText = "DELETE FROM SmSaleOrderMt Where idSaleOrder = " & UpdateDtAll.Rows(i).Item("idSaleOrder")
                                                mycommand.ExecuteNonQuery()
                                            End If

                                        End If
                                    Next


                                    mytransaction.Commit()
                                    BindData()
                                    SumTotal()
                                    mdLoadCommitt()
                                    MessageBox.Show("ยกเลิกรายการเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    Exit Sub
                                End If


                                mycommand.CommandText = "Update SmSaleMt Set idPsCancel = " & sPsId & " , CancelNote = '" & CancelNote & "' " & _
                                                        "Where idSale = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)
                                mycommand.ExecuteNonQuery()

                                mycommand.CommandText = "EXEC WaitCutTs '4','SmSaleMt','SmSaleDtAll','idSale'," & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1) & _
                                                            "," & cmbGroupComp.SelectedValue & "," & sPsId & ",'3'"
                                mycommand.ExecuteNonQuery()

                                '----ถ้าเป็นบิลขายจากบริษัทในเครือ ให้ยกเลิกรายการรับด้วย
                                'If GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle , ColstBillType1) = 6
                                '    Dim dtASG As New DataTable 
                                '    mycommand.CommandText = "SELECT idComp FROM PchInvAndProject.dbo.dCompany WHERE idPartner = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidPartner) 
                                '    myAdapter.Fill(dtASG)

                                '    mycommand.CommandText = "EXEC WaitRecieveTsEdit  '11','SmSaleMt','SmSaleDtAll','idSale'," & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1) & "," & dtASG.Rows(0).Item("idComp") & ",0,'3'"
                                '    mycommand.ExecuteNonQuery()
                                'End If

                                Dim dt As New DataTable

                                mycommand.CommandText = "SELECT * " & vbNewLine & _
                                                        "FROM WimWaitCutMt Where idMt = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1) & vbNewLine & _
                                                        "AND ProcessID = 4 "

                                myAdapter.Fill(dt)

                                '----Check ถ้ามีรายการใน WimWaitCutMt ไม่ต้องคืนสต๊อก 
                                If dt.Rows.Count = 0 Then

                                    Dim UpdateDtAll As New DataTable
                                    'mycommand.CommandText = "SELECT idSaleDtOther, idPdOLot, Amount, stCutStock, idJUDt, idSaleReturn FROM SmSaleDtOther Where " & _
                                    '                       "idSale ='" & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1) & "'"
                                    mycommand.CommandText = "SELECT dt.idSaleDt, dt.LotNo, dt.Amount, ISNULL(dt.idSaleOrderDt,0) As idSaleOrderDt," & vbNewLine &
                                                            "ISNULL(oDt.idSaleOrder,0) As idSaleOrder, " & vbNewLine &
                                                            "dt.idSaleReturn, dt.idJUDt, ISNULL(dt.idLot,0) As idLot, dt.idProduct, dt.idWh , dt.idUnit, inv.idInvGroup" & vbNewLine &
                                                            "FROM SmSaleDtAll dt " & vbNewLine &
                                                            "LEFT JOIN SmSaleOrderDt oDt On dt.idSaleOrderDt = oDt.idSaleOrderDt" & vbNewLine &
                                                            "LEFT JOIN dInventoryMain inv On dt.idProduct = inv.idInvMain" & vbNewLine &
                                                            "Where idSale = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)

                                    myAdapter.Fill(UpdateDtAll)

                                    For i As Integer = 0 To UpdateDtAll.Rows.Count - 1

                                        'Case Order
                                        If UpdateDtAll.Rows(i).Item("idSaleOrderDt") <> 0 Then
                                            Dim stAllSaleDt As New DataTable
                                            mycommand.CommandText = "Select stAllSale, AmountPiece, IsNull(AmountSale,0) As AmountSale " & vbNewLine &
                                                                    "FROM SmSaleOrderDt  " & vbNewLine &
                                                                    "WHERE idSaleOrderDt = " & UpdateDtAll.Rows(i).Item("idSaleOrderDt")
                                            myAdapter.Fill(stAllSaleDt)

                                            If stAllSaleDt.Rows.Count > 0 Then
                                                If IsDBNull(stAllSaleDt.Rows(0).Item("stAllSale")) Then 'มี Order ที่ยังไม่ได้ขาย
                                                    Dim NewSale As Double = stAllSaleDt.Rows(0).Item("AmountSale") + UpdateDtAll.Rows(i).Item("Amount")

                                                    If stAllSaleDt.Rows(0).Item("AmountPiece") <= NewSale Then 'Order หมดแล้ว หรือ order เกิน
                                                        mycommand.CommandText = "Update SmSaleOrderDt Set stAllSale = 1, AmountSale = " & NewSale & vbNewLine &
                                                                               "WHERE idSaleOrderDt = " & UpdateDtAll.Rows(i).Item("idSaleOrderDt")
                                                    Else ' ยังมี Order เหลือ
                                                        mycommand.CommandText = "Update SmSaleOrderDt Set stAllSale = NULL, AmountSale = " & NewSale & vbNewLine &
                                                                                "WHERE idSaleOrderDt = " & UpdateDtAll.Rows(i).Item("idSaleOrderDt")
                                                    End If
                                                    mycommand.ExecuteNonQuery()

                                                    Dim dtSumAllSale As New DataTable
                                                    mycommand.CommandText = "Select ISNULL(stAllSale,0) As stAlLSale, Count(idSaleOrderDt) As cntOrderDt " & vbNewLine &
                                                                           "FROM SmSaleOrderDt  " & vbNewLine &
                                                                           "WHERE idSaleOrder = " & UpdateDtAll.Rows(i).Item("idSaleReturn")
                                                    myAdapter.Fill(dtSumAllSale)

                                                    If dtSumAllSale.Rows.Count > 0 Then
                                                        If dtSumAllSale.Rows(0).Item("stAlLSale") = dtSumAllSale.Rows(0).Item("cntOrderDt") Then
                                                            'ขายครบหมดแล้ว
                                                            mycommand.CommandText = "Update SmSaleOrderMt Set stOrd = 1" & vbNewLine &
                                                                                    "WHERE idSaleOrder = " & UpdateDtAll.Rows(i).Item("idSaleOrder")
                                                        ElseIf dtSumAllSale.Rows(0).Item("stAlLSale") = 0 Then
                                                            'ยังไม่มีรายการที่ถูกเอาไปขาย
                                                            mycommand.CommandText = "Update SmSaleOrderMt Set stOrd = NULL " & vbNewLine &
                                                                                    "WHERE idSaleOrder = " & UpdateDtAll.Rows(i).Item("idSaleOrder")
                                                        Else
                                                            'ขายแล้วบางส่วน
                                                            mycommand.CommandText = "Update SmSaleOrderMt Set stOrd = 2 " & vbNewLine &
                                                                                   "WHERE idSaleOrder = " & UpdateDtAll.Rows(i).Item("idSaleOrder")
                                                        End If
                                                        mycommand.ExecuteNonQuery()
                                                    End If
                                                End If
                                            End If
                                            'mycommand.CommandText = "UPDATE SmSaleOrderDt Set Amount = Amount - " & CDbl(UpdateDtAll.Rows(i).Item("Amount")) & vbNewLine &
                                            '                        ", AmountPiece = AmountPiece - " & CDbl(UpdateDtAll.Rows(i).Item("Amount")) & vbNewLine &
                                            '                        "WHERE idSaleOrderDt = " & UpdateDtAll.Rows(i).Item("idSaleOrderDt")
                                            'mycommand.ExecuteNonQuery()

                                            'Dim dtAmtOrder As New DataTable
                                            'mycommand.CommandText = "Select Amount FROM SmSaleOrderDt Where idSaleOrderDt = " & UpdateDtAll.Rows(i).Item("idSaleOrderDt")
                                            'myAdapter.Fill(dtAmtOrder)

                                            'If dtAmtOrder.Rows(0).Item("Amount") = 0 Then
                                            '    mycommand.CommandText = "DELETE FROM SmSaleOrderDt Where idSaleOrderDt = " & UpdateDtAll.Rows(i).Item("idSaleOrderDt")
                                            '    mycommand.ExecuteNonQuery()
                                            'End If

                                            'Dim dtOrderMt As New DataTable
                                            'mycommand.CommandText = "Select idSaleOrderDt FROM SmSaleOrderDt Where idSaleOrder = " & UpdateDtAll.Rows(i).Item("idSaleOrder")
                                            'myAdapter.Fill(dtOrderMt)

                                            'If dtOrderMt.Rows.Count = 0 Then
                                            '    mycommand.CommandText = "DELETE FROM SmSaleOrderMt Where idSaleOrder = " & UpdateDtAll.Rows(i).Item("idSaleOrder")
                                            '    mycommand.ExecuteNonQuery()
                                            'End If

                                        End If

                                        If UpdateDtAll.Rows(i).Item("idLot") <> 0 Then

                                            Dim dtInvUnitSub As New DataTable

                                            If UpdateDtAll.Rows(i).Item("idUnit") = 1 Then ' กรัม

                                                UpdateDtAll.Rows(i).Item("Amount") = CDbl(UpdateDtAll.Rows(i).Item("Amount")) / 1000

                                            Else
                                                mycommand.CommandText = "Select ISNULL(AmtMainperSub,0) As AmtMainperSub, idSubUnit, idUnit " & vbNewLine &
                                                                        "FROM dInvUnitSub " & vbNewLine &
                                                                        "WHERE idSubUnit = " & UpdateDtAll.Rows(i).Item("idUnit") & vbNewLine &
                                                                        "And idInvMain = " & UpdateDtAll.Rows(i).Item("idProduct")
                                                myAdapter.Fill(dtInvUnitSub)

                                                If dtInvUnitSub.Rows.Count > 0 Then 'มี idSubUnit
                                                    'Check ว่า idUnit ที่เลือกตอนนี้เป็น Unit หลัก หรือ Unit รอง
                                                    If dtInvUnitSub.Rows(0).Item("idUnit") = dtInvUnitSub.Rows(0).Item("idSubUnit") Then 'แสดงว่าเป็นหน่วยรอง ต้อง  Convert
                                                        UpdateDtAll.Rows(i).Item("Amount") = CDbl(dtInvUnitSub.Rows(0).Item("Amount")) * dtInvUnitSub.Rows(0).Item("AmtMainperSub")

                                                    End If
                                                End If
                                            End If
                                            '--- Return StockCard InvLot : New System ---'
                                            InvLotMainUpdate(1, UpdateDtAll.Rows(i).Item("idProduct"), UpdateDtAll.Rows(i).Item("idLot"),
                                                             UpdateDtAll.Rows(i).Item("Amount"), "เมนู" & Me.Text,
                                                             GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1), "SAM",
                                                             "SmSaleMt", UpdateDtAll.Rows(i).Item("LotNo"), UpdateDtAll.Rows(i).Item("idWh"), mycommand)

                                        End If


                                        'เพิ่ม code Return Amount JU
                                        If Not IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillType1)) Then
                                            If GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillType1) = 9 Then 'บิล XY จากรายการคืน JU
                                                'UPDATE Amount Cut
                                                mycommand.CommandText = "UPDATE SmSaleReturnJUDt Set AmountCut = (Select ISNULL(AmountCut, 0.0)  As AmountCut FROM SmSaleReturnJUDt " &
                                                                       "WHERE idJUDt = " & UpdateDtAll.Rows(i).Item("idJUDt") & ") - " & CDbl(UpdateDtAll.Rows(i).Item("Amount")) & " " &
                                                                       "WHERE idJUDt = " & UpdateDtAll.Rows(i).Item("idJUDt") & ""
                                                mycommand.ExecuteNonQuery()

                                                mycommand.CommandText = "Update SmSaleReturnMt Set stAllCut = NULL WHERE idSaleReturn = " & UpdateDtAll.Rows(i).Item("idSaleReturn")
                                                mycommand.ExecuteNonQuery()
                                            End If
                                        End If



                                    Next
                                End If

                                ' Attempt to commit the transaction.
                                mytransaction.Commit()
                                BindData()
                                SumTotal()
                                mdLoadCommitt()
                                MessageBox.Show("ยกเลิกรายการเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Catch ex As Exception
                                ' Attempt to roll back the transaction.
                                Try
                                    mytransaction.Rollback()
                                    MessageBox.Show("Commit Exception Type: ระบบเกิดข้อผิดพลาด ไม่สามารถบันทึกรายการได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    mytransaction.Commit()
                                Catch e2x As Exception
                                    'MessageBox.Show(ex.Message, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    MessageBox.Show("Commit Exception Type: ระบบเกิดข้อผิดพลาด ไม่สามารถบันทึกรายการได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    mytransaction.Commit()
                                End Try
                                'Finally
                                '    myconnection.Close()
                            End Try
                        End Using

                    End If
                End If


            Else
                MessageBox.Show("รายการนี้ไม่สามารถทำการยกเลิกได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        End If
    End Sub

    ' Cancel Accept/Check/Approve
    Private Sub RepositoryItemButtonEdit7_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit7.Click
        Dim CancelNote As String = " "
        CancelNote = InputBox("ระบุสาเหตุยกเลิกรายการ รับทราบ/ตรวจสอบ/อนุมัติ", sSystemName)
        If CancelNote.Length = 0 Then
            MessageBox.Show("กรุณาระบุสาเหตุยกเลิกรายการ รับทราบ/ตรวจสอบ/อนุมัติ", sSystemName)
            Exit Sub
        Else
            mdLoadShow()
            '---insert SmSaleCancelApv Table---'
            sCommand.CommandText = "Insert Into SmSaleCancelApv(idSale, idPsCancel, CancelNote, DateCancel) " & _
                                   "Values(" & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1) & ", " & _
                                   "" & sPsId & ", '" & CancelNote & "', '" & ksbDateToString(Date.Today) & "')"
            sCommand.ExecuteNonQuery()

            Dim ChkAppDt As New DataTable
            sCommand.CommandText = "Select stApp From SmSaleMt Where idSale = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)
            sAdapter.Fill(ChkAppDt)

            'If Not IsDBNull(ChkAppDt.Rows(0).Item("stApp")) Then
            '    If ChkAppDt.Rows(0).Item("stApp") = 0 Then ' No Apv




            '        '--- Return Cut SmSaleDt ---'
            '        'Dim UpdateDtAll As New DataTable

            '        'sCommand.CommandText = "SELECT dt.idSaleDt, dt.idLot, dt.LotNo, dt.idProduct, dt.Amount, dt.idWh, dt.stCutStock, inv.idInvGroup" & vbNewLine & _
            '        '                        "FROM SmSaleDtAll dt" & vbNewLine & _
            '        '                        "LEFT JOIN dInventoryMain inv ON dt.idProduct = inv.idInvMain" & vbNewLine & _
            '        '                        "WHERE dt.idSale = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)

            '        'sAdapter.Fill(UpdateDtAll)

            '        'For i As Integer = 0 To UpdateDtAll.Rows.Count - 1
            '        '    If Not IsDBNull(UpdateDtAll.Rows(i).Item("stCutStock")) Then
            '        '        If UpdateDtAll.Rows(i).Item("stCutStock") = 1 Then

            '        '            Dim dtInvUnitSub As New DataTable

            '        '            sCommand.CommandText = "SELECT ISNULL(AmtMainperSub,0) As AmtMainperSub, idSubUnit, idUnit " & vbNewLine & _
            '        '                                    "FROM  dInvUnitSub WHERE idSubUnit = " & UpdateDtAll.Rows(i).Item("idUnit") & vbNewLine & _
            '        '                                    "AND idInvMain = " & UpdateDtAll.Rows(i).Item("idProduct")
            '        '            sAdapter.Fill(dtInvUnitSub)

            '        '            If dtInvUnitSub.Rows.Count > 0 Then 'มี idSubUnit
            '        '                'Check ว่า idUnit ที่เลือกตอนนี้เป็น Unit หลัก หรือ Unit รอง
            '        '                If dtInvUnitSub.Rows(0).Item("idUnit") = dtInvUnitSub.Rows(0).Item("idSubUnit") Then 'แสดงว่าเป็นหน่วยรอง ต้อง  Convert
            '        '                    UpdateDtAll.Rows(i).Item("Amount") = CDbl(dtInvUnitSub.Rows(0).Item("Amount")) * dtInvUnitSub.Rows(0).Item("AmtMainperSub")

            '        '                End If
            '        '            End If
            '        '            'End If

            '        '            'Lot in New Sysytem
            '        '            'If Not IsDBNull(UpdateDtAll.Rows(i).Item("idLot")) Then
            '        '            '    '--- UPDATE InvLot : New System ---'
            '        '            '    InvLotMainUpdate(2, UpdateDtAll.Rows(i).Item("idProduct"), UpdateDtAll.Rows(i).Item("idLot"), UpdateDtAll.Rows(i).Item("Amount"), "เมนู" & Me.Text, _
            '        '            '                     GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1), "SAM", "SmSaleMt", UpdateDtAll.Rows(i).Item("Lotno"), _
            '        '            '                     UpdateDtAll.Rows(i).Item("idWh"), sCommand)
            '        '            'End If

            '        '        End If
            '        '    End If
            '        'Next
            '    End If
            'End If


            ' --- clear All status Accept/Check/Approve ----'
            sCommand.CommandText = "UPDATE SmSaleMt SET idPsAccept = NULL, DateAccept = NULL, idPsCheck = NULL, DateChcek = NULL, " & vbNewLine &
                                   "idPsApp = NULL, DateApp = NULL, stApp = NULL, idPsApp2 = NULL, DateApp2 = NULL " & vbNewLine &
                                   "WHERE idSale = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)
            sCommand.ExecuteNonQuery()

            BindData()
            SumTotal()
            mdLoadCommitt()
            MessageBox.Show("ยกเลิกรายการ รับทราบ/ตรวจสอบ/อนุมัติ เรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub GVSaleMt_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVSaleMt.RowCellStyle

        If Not IsDBNull(GVSaleMt.GetRowCellValue(e.RowHandle, ColidCancel1)) Then
            e.Appearance.BackColor = Color.Salmon
            e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Strikeout)
        End If

        If GVSaleMt.GetRowCellValue(e.RowHandle, ColstBillOrder1) = 1 Then
            ' If e.Column.Name <> ColCancelApv.Name And e.Column.Name <> ColEdit1.Name And e.Column.Name <> ColDoc.Name Then
            e.Appearance.BackColor = Color.PowderBlue
            'End If
        End If

    End Sub

    Private Sub GVSaleMt_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVSaleMt.RowClick
        If e.RowHandle < 0 Then
            Exit Sub
        End If

        If Not IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidCancel1)) Then
            MessageBox.Show("ผู้ยกเลิก : " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColPsCancel1) & vbNewLine & "ยกเลิกสาเหตุ : " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColCancelNote), sSystemName)
        End If
    End Sub

    'Accept
    Private Sub RepositoryItemButtonEdit3_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit3.Click
        If IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidCancel1)) = True Then
            idSaleShow = GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)
            If IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillType1)) Then 'บิลทั่วไป
                Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eAccept, idSaleShow, 0)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    BindData()
                    SumTotal()
                End If
            ElseIf GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillType1) = 9 Then 'บิล XY จากรายการคืน JU
                Dim vFrm As New frmSlReturnToSale(frmSlReturnToSale.eProcess.eAccept, Nothing, idSaleShow, GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp))

                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    BindData()
                    SumTotal()
                End If
            Else
                Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eAccept, idSaleShow, 0)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    BindData()
                    SumTotal()
                End If
            End If
        End If
    End Sub

    'Check
    Private Sub RepositoryItemButtonEdit4_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit4.Click
        If IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidCancel1)) = True Then
            idSaleShow = GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)
            If IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillType1)) Then 'บิลทั่วไป
                Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eCheck, idSaleShow, 0)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    BindData()
                    SumTotal()
                End If
            ElseIf GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillType1) = 9 Then 'บิล XY จากรายการคืน JU
                Dim vFrm As New frmSlReturnToSale(frmSlReturnToSale.eProcess.eCheck, Nothing, idSaleShow, GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp))
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    BindData()
                    SumTotal()
                End If
            Else
                Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eCheck, idSaleShow, 0)

                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    BindData()
                    SumTotal()
                End If
            End If

        End If
    End Sub

    ' Approve
    Private Sub RepositoryItemButtonEdit5_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit5.Click
        If IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidCancel1)) = True Then
            idSaleShow = GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)
            If IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillType1)) Then 'บิลทั่วไป
                Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eApprove, idSaleShow, 0)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    BindData()
                    SumTotal()
                End If
            ElseIf GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColstBillType1) = 9 Then 'บิล XY จากรายการคืน JU
                Dim vFrm As New frmSlReturnToSale(frmSlReturnToSale.eProcess.eApprove, Nothing, idSaleShow, GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp))
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    BindData()
                    SumTotal()
                End If
            Else
                Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eApprove, idSaleShow, 0)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    BindData()
                    SumTotal()
                End If
            End If
        End If
    End Sub

    Private Sub GVSaleMt_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVSaleMt.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stload = 1 Then
            cmbDRefCode()

            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub fnFilterDataOnGrid()
        Dim StrFilter As String = ""

        If chkComp.Checked = True Then
            StrFilter &= " AND [idComp] = " & cmbGroupComp.SelectedValue

        End If

        If ChkDocCode.Checked = True And txtDocCode.Text.Trim <> "" Then
            StrFilter &= " AND [DocCode] LIKE '%" & Trim(txtDocCode.Text) & "%'"

        End If

        If ChkDocRef.Checked = True And txtDocRef.Text.Trim <> "" Then
            StrFilter &= " AND [DocRef] LIKE '%" & Trim(txtDocRef.Text) & "%'"

        End If

        If ChkTsp.Checked = True Then
            StrFilter &= " AND [idTs] = " & cmbTsp.SelectedValue

        End If

        If ChkStOrd.Checked = True Then
            StrFilter &= " AND [stBillOrder] = 1"

        End If

        '---ไม่แสดงรายการที่ยกเลิก
        If ChkCancel.Checked = True Then
            StrFilter &= " AND [idPsCancel] Is NULL "

        End If

        If ChkCus.Checked = True And txtCusName.Text.Trim <> "" Then
            StrFilter &= " AND [CusName] LIKE '%" & Trim(txtCusName.Text) & "%'"

        End If

        If ChkPsSale.Checked = True And txtPsSale.Text.Trim <> "" Then
            StrFilter &= " AND [PsSale] Like '%" & Trim(txtPsSale.Text) & "%'"

        End If

        If ChkDoc.Checked Then
            Dim strEditDoc As String = Trim(CCbEditDoc.Text)
            strEditDoc = strEditDoc.Replace(", ", "%' Or [DocRef] Like '%")
            StrFilter &= " AND ([SaleCode] LIKE '%" & Trim(strEditDoc) & "%')"

        End If

        If cbDraft.Checked = True Then
            StrFilter &= " AND [stWaitCut] = 'Draft'"
        End If

        GVSaleMt.ActiveFilterString = " 1=1" + StrFilter
        txtCount.Text = Format(GVSaleMt.DataRowCount, "#,##0")
        txtCountDt.Text = Format(GetChildRowCount(GVSaleMt), "#,##0")

        'Dim totalNet As Double = 0.0
        'For i As Integer = 0 To GVSaleMt.DataRowCount - 1
        '    totalNet = totalNet + GVSaleMt.GetDataRow(i).Item("TotalNet")
        'Next

        ''For i As Integer = 0 To GVSaleMt.DataRowCount - 1
        ''    If IsDBNull(GVSaleMt.GetRowCellValue(i, "idPsCancle")) Then
        ''        totalNet = totalNet + GVSaleMt.GetRowCellValue(i, "TotalNet")
        ''    End If
        ''Next

        'txtTotalNet.Text = Format(totalNet, "#,###0.00##")
        SumTotal()
    End Sub

    Private Function GetChildRowCount(ByRef View As GridView) As Integer
        Dim RowCount As Integer
        View.BeginUpdate()
        Try
            Dim dataRowCount As Integer = View.DataRowCount
            Dim rHandle As Integer
            For rHandle = 0 To dataRowCount - 1
                View.SetMasterRowExpanded(rHandle, True)
                Dim childView As ColumnView = View.GetDetailView(rHandle, 0)
                If Not IsNothing(childView) Then
                    RowCount = RowCount + childView.RowCount
                End If
            Next
        Catch ex As Exception
            'XtraMessageBox.Show(ex.Message, "DampoDesk", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            View.EndUpdate()
        End Try
        Return RowCount
    End Function

    Private Sub cmbTsp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTsp.SelectedValueChanged
        If stload = 1 Then
            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub ChkCancel_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCancel.CheckedChanged
        If stload = 1 Then
            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub chkComp_CheckedChanged(sender As Object, e As EventArgs) Handles chkComp.CheckedChanged
        If stload = 1 Then
            If chkComp.Checked = True Then
                cmbGroupComp.Enabled = True
            Else
                cmbGroupComp.Enabled = False
                fnFilterDataOnGrid()
            End If
            cmbDRefCode()

        End If
    End Sub

    'Private Sub txtCusName_TextChanged(sender As Object, e As EventArgs) Handles txtCusName.TextChanged, txtDocCode.TextChanged, txtDocRef.TextChanged, txtPsSale.TextChanged
    '    If stload = 1 Then
    '        fnFilterDataOnGrid()
    '    End If
    'End Sub

    Private Sub CCbEditDoc_EditValueChanged(sender As Object, e As EventArgs) Handles CCbEditDoc.EditValueChanged
        If stload = 1 Then
            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub ChkStOrd_CheckedChanged(sender As Object, e As EventArgs) Handles ChkStOrd.CheckedChanged, cbDraft.CheckedChanged
        If stload = 1 Then
            fnFilterDataOnGrid()
        End If
    End Sub


    Private Sub rptLineNoti_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles rptLineNoti.ButtonClick
        'fnNoticeLine()

        If IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidCancel1)) = True Then
            Dim Result As DialogResult
            Result = MessageBox.Show("คุณต้องการส่งการแจ้งเตือนไลน์ ใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If Result = Windows.Forms.DialogResult.Yes Then
                Dim dv As New DataView(CopySmSaleDt)
                dv.RowFilter = "idSale = " & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idSale")
                Dim strSmSaleDt As String = ""

                If GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("stBillOrder") = 1 Then

                    If dv.Count >= 2 Then
                        For i As Integer = 0 To 1
                            strSmSaleDt = strSmSaleDt & "- " & dv.Item(i).Item("DocCode_PO") & " |" & dv.Item(i).Item("ProductName") & " จำนวน: " & Format(dv.Item(i).Item("Amount"), "#,##0.####") & " " & dv.Item(i).Item("UnitName") & " ราคา: ฿" & Format(dv.Item(i).Item("Price"), "#,##0.####") & " รวม: ฿" & Format(dv.Item(i).Item("ExSump"), "#,##0.####") & vbNewLine
                        Next

                        If dv.Count <> 2 Then
                            strSmSaleDt = strSmSaleDt & ". . ." & vbNewLine
                        End If

                    Else

                        strSmSaleDt = strSmSaleDt & "- " & dv.Item(0).Item("DocCode_PO") & " |" & dv.Item(0).Item("ProductName") & " จำนวน: " & Format(dv.Item(0).Item("Amount"), "#,##0.####") & " " & dv.Item(0).Item("UnitName") & " ราคา: ฿" & Format(dv.Item(0).Item("Price"), "#,##0.####") & " รวม: ฿" & Format(dv.Item(0).Item("ExSump"), "#,##0.####") & vbNewLine

                    End If

                Else

                    If dv.Count >= 2 Then
                        For i As Integer = 0 To 1
                            ' Dim dr_ As DataRow = gMainReturn.NewRow
                            strSmSaleDt = strSmSaleDt & "- " & dv.Item(i).Item("ProductName") & " จำนวน: " & Format(dv.Item(i).Item("Amount"), "#,##0.####") & " " & dv.Item(i).Item("UnitName") & " ราคา: ฿" & Format(dv.Item(i).Item("Price"), "#,##0.####") & " รวม: ฿" & Format(dv.Item(i).Item("ExSump"), "#,##0.####") & vbNewLine
                        Next

                        If dv.Count <> 2 Then
                            strSmSaleDt = strSmSaleDt & ". . ." & vbNewLine
                        End If

                    Else

                        strSmSaleDt = strSmSaleDt & "- " & dv.Item(0).Item("ProductName") & " จำนวน: " & Format(dv.Item(0).Item("Amount"), "#,##0.####") & " " & dv.Item(0).Item("UnitName") & " ราคา: ฿" & Format(dv.Item(0).Item("Price"), "#,##0.####") & " รวม: ฿" & Format(dv.Item(0).Item("ExSump"), "#,##0.####") & vbNewLine

                    End If
                End If


                Dim strStatusApp As String = ""

                If Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsAccept")) = "" Then
                    strStatusApp = strStatusApp & "ผู้รับทราบ : " & ShrinkURL("https://seedsgroup.dyndns.org/approve/sam/aprBill/accept/" & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idSale")) & vbCrLf
                Else
                    strStatusApp = strStatusApp & "ผู้รับทราบ : " & Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsAccept")) & vbCrLf
                End If

                If Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsCheck")) = "" Then
                    strStatusApp = strStatusApp & "ผู้ตรวจสอบ : " & ShrinkURL("https://seedsgroup.dyndns.org/approve/sam/aprBill/check/" & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idSale")) & vbCrLf
                Else
                    strStatusApp = strStatusApp & "ผู้ตรวจสอบ : " & Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsCheck")) & vbCrLf
                End If

                If Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsApp")) = "" Then
                    strStatusApp = strStatusApp & "ผู้อนุมัติ 1 : " & ShrinkURL("https://seedsgroup.dyndns.org/approve/sam/aprBill/approve/" & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idSale")) & vbCrLf
                Else
                    strStatusApp = strStatusApp & "ผู้อนุมัติ 1 : " & Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsApp")) & vbCrLf
                End If

                If Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsApp2")) = "" Then
                    strStatusApp = strStatusApp & "ผู้อนุมัติ 2 : " & ShrinkURL("https://seedsgroup.dyndns.org/approve/sam/aprBill/approve/" & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idSale")) & vbCrLf
                Else
                    strStatusApp = strStatusApp & "ผู้อนุมัติ 2 : " & Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsApp2")) & vbCrLf
                End If

                mdCnOpen()

                If Result = Windows.Forms.DialogResult.Yes Then
                    Dim dt As New DataTable
                    '---------------- Line Alert (InsertDB-Way) ------------------------'
                    Dim LineId As Integer = 0 'Test-Line Group (Line ID: 2 ห้องทดสอบแจ้งเตือนไลน์)

                    sCommand.CommandText = "SELECT parentid " & vbNewLine &
                                            "FROM PchInvAndProject.devsk.dGroupCompMap" & vbNewLine &
                                            "WHERE stActive = 1" & vbNewLine &
                                            "AND idComp = " & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idComp")

                    sAdapter.Fill(dt)

                    If dt.Rows(0).Item("parentid") = 1 Then ' AV Group
                        LineId = 60
                    ElseIf dt.Rows(0).Item("parentid") = 2 Then 'GR Group
                        LineId = 61
                    ElseIf dt.Rows(0).Item("parentid") = 3 Then 'FL Group
                        LineId = 62
                    End If

                    If GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idComp") = 64 Then
                        LineId = 131
                    ElseIf GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idComp") = 5 Then
                        LineId = 2 ' ห้องทดสอบ
                    ElseIf GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idComp") = 59 Then
                        LineId = 144 ' ห้องทดสอบ
                    End If


                    Dim MsgLine = "เรียนผู้อนุมัติ (" & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("CompanyName") & ")" & vbCrLf &
                                  "เลขที่อ้างอิง: " & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("DocRef") & vbCrLf &
                                  "ชื่อลูกค้า: " & Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("CusName")) & vbCrLf &
                                  "หมายเหตุ: " & Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("Note")) & vbCrLf &
                                  "จำนวนเงินสุทธิ: " & Format(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("TotalNet"), "#,##0.####") & " บาท" & vbCrLf &
                                  "ผู้ทำรายการ: " & Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsTs")) & vbCrLf &
                                  "-----------รายการ-----------" & vbCrLf &
                                  strSmSaleDt & vbCrLf &
                                  "> สถานะอนุมัติ และลิ้งค์ทำรายการ <" & vbCrLf &
                                   strStatusApp

                    'Console.WriteLine(LineId)

                    'Console.WriteLine(MsgLine)

                    sCommand.CommandText = "INSERT INTO LineNotify(lineID, Messages, idPsTs) " &
                                            "VALUES(" & LineId & ", '" & MsgLine & "', " & sPsId & ")"
                    sCommand.ExecuteNonQuery()

                    MessageBox.Show("แจ้งเตือนไลน์ เรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End If
        End If
    End Sub

    Private Function ShrinkURL(ByVal strURL As String) As String

        Dim URL As String
        URL = "http://tinyurl.com/api-create.php?url=" & strURL

        Dim objWebRequest As Net.HttpWebRequest
        Dim objWebResponse As Net.HttpWebResponse

        Dim srReader As IO.StreamReader

        Dim strHTML As String

        objWebRequest = CType(Net.WebRequest.Create(URL),  _
           Net.HttpWebRequest)
        objWebRequest.Method = "GET"

        objWebResponse = CType(objWebRequest.GetResponse(),  _
           Net.HttpWebResponse)
        srReader = New IO.StreamReader(objWebResponse _
           .GetResponseStream)

        strHTML = srReader.ReadToEnd

        srReader.Close()
        objWebResponse.Close()
        objWebRequest.Abort()

        Return strHTML

    End Function


    'Private Sub cbSlAVxST_CheckedChanged(sender As Object, e As EventArgs) Handles cbSlAVxST.CheckedChanged
    '    If stload = 1 Then
    '        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
    '        BindData()
    '        SplashScreenManager.CloseForm(False)
    '    End If
    'End Sub

    Private Sub rptAddTransport_Click(sender As Object, e As EventArgs) Handles rptAddTransport.Click

        If IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidCancel1)) = True Then
            Dim vFrm As New frmAddTransport()
            vFrm.idSaleMt = GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)

            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                mdCnOpen()
                mdLoadShow()
                BindData()
                SumTotal()
                mdLoadCommitt()
            End If
        End If

    End Sub

    Private Sub txtDocRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDocRef.KeyDown, txtCusName.KeyDown, txtDocCode.KeyDown, txtPsSale.KeyDown
        If e.KeyCode = Keys.Enter Then
            fnFilterDataOnGrid()
        End If
    End Sub

    'Private Sub btnPrintMulti_Click(sender As Object, e As EventArgs) Handles btnPrintMulti.Click

    '    Dim dv As New DataView(CopyMainDt)
    '    dv.RowFilter = "chk=True"
    '    Dim stridSale As String = ""

    '    stridSale = dv.Item(0).Item("idSale")
    '    For i As Integer = 0 To dv.Count - 1
    '        stridSale = stridSale & ","
    '        stridSale = stridSale & dv.Item(i).Item("idSale")

    '    Next


    '    mdCnOpen()
    '    'SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
    '    mdLoadShow()
    '    Dim stSignPsSale As Integer = 0

    '    '****พิมพ์ใบส่งของ****-
    '    Dim DeliveryDoc As New DataTable
    '    DeliveryDoc.Clear()
    '    DeliveryDoc.Columns.Add("idSale", System.Type.GetType("System.Int32"))
    '    DeliveryDoc.Columns.Add("DateTs", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("DateSale", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("DatePay", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("DocCode", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("DocRef", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("Total", System.Type.GetType("System.Double"))
    '    DeliveryDoc.Columns.Add("DiscountAmout", System.Type.GetType("System.Double"))
    '    DeliveryDoc.Columns.Add("DiscountPerc", System.Type.GetType("System.Double"))
    '    DeliveryDoc.Columns.Add("DiscountBath", System.Type.GetType("System.Double"))
    '    DeliveryDoc.Columns.Add("TotalNet", System.Type.GetType("System.Double"))
    '    DeliveryDoc.Columns.Add("CusName", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("PsSale", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("PaymentTerms", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("Transport", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("note", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("idPdPk", System.Type.GetType("System.Int32"))
    '    DeliveryDoc.Columns.Add("Amount", System.Type.GetType("System.Double"))
    '    DeliveryDoc.Columns.Add("Price", System.Type.GetType("System.Double"))
    '    DeliveryDoc.Columns.Add("DisPerc", System.Type.GetType("System.Double"))
    '    DeliveryDoc.Columns.Add("PdPkName", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("idPkUnit", System.Type.GetType("System.Int32"))
    '    DeliveryDoc.Columns.Add("PkUnitName", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("PdCode", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("address", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("AddressS", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("Tel", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("Fax", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("idPsSale", System.Type.GetType("System.Int32"))
    '    DeliveryDoc.Columns.Add("idCus", System.Type.GetType("System.Int32"))
    '    DeliveryDoc.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))
    '    DeliveryDoc.Columns.Add("picSignPsSale", System.Type.GetType("System.Byte[]"))
    '    DeliveryDoc.Columns.Add("RegianName", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("PriceBfDis", System.Type.GetType("System.Double"))
    '    DeliveryDoc.Columns.Add("TaxCode", System.Type.GetType("System.String"))
    '    DeliveryDoc.Columns.Add("PsRecName", System.Type.GetType("System.String"))

    '    Dim sDt3 As New DataTable
    '    sDt3.Clear()
    '    sCommand.CommandText = "Select m.idSale, m.DateTsD As DateTs, m.DateSaleD As DateSale, " & vbNewLine &
    '                           "devsk.fncStrDateToDateTime(m.DatePay) As DatePay, m.DocCode, m.DocRef, m.Total, m.DiscountAmout, " & vbNewLine &
    '                           "m.DiscountPerc, m.TotalNet, m.PartnerNameBill As CusName, m.PsSale, m.PaymentTerms, m.Transport, m.note, " & vbNewLine &
    '                           "idProduct, d.Amount, d.Price, d.PriceBfDis, ISNULL(d.DiscountPerc,0.00) As DisPerc, ISNULL(d.DiscountBath,0.00) As DiscountBath, " & vbNewLine &
    '                           "d.ProductName, d.idInvGroup, d.Lotno, d.idUnit, unit.UnitName, '' As PdCode, " & vbNewLine &
    '                           "c.address, m.AddressS, (CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As Tel, " & vbNewLine &
    '                           "c.Fax, c.TaxCode, m.idPsSale, m.idPsSet, m.idPsSend, m.idCus, m.PsRecName, m.TelOfAddrSent, ISNULL(m.stFromS, 1) As stFromS, " & vbNewLine &
    '                           "(CASE WHEN d.DiscountPerc <> 0 THEN ((d.DiscountPerc*d.PriceBfDis)/100) ELSE d.DiscountBath END) As DisCount" & vbNewLine &
    '                           "FROM vSmSaleDtAll d " & vbNewLine &
    '                           "LEFT OUTER JOIN vSmSaleMt m ON d.idSale = m.idSale " & vbNewLine &
    '                           "LEFT OUTER JOIN dPartner pn ON m.idPartner = pn.idPartner" & vbNewLine &
    '                           "LEFT OUTER JOIN dCustomer c ON m.idCus=c.idCus " &
    '                           "LEFT JOIN dInvUnit As unit ON d.idUnit = unit.idUnit" & vbNewLine &
    '                           "WHERE m.idSale IN ( " & stridSale & ")"
    '    sAdapter.Fill(sDt3)

    '    For i As Integer = 0 To sDt3.Rows.Count - 1
    '        Dim rc As Integer = DeliveryDoc.Rows.Count
    '        DeliveryDoc.Rows.Add()

    '        DeliveryDoc.Rows(rc).Item("idSale") = sDt3.Rows(i).Item("idSale")
    '        DeliveryDoc.Rows(rc).Item("DateTs") = Format(sDt3.Rows(i).Item("DateTs"), "dd/MM/yyyy")
    '        DeliveryDoc.Rows(rc).Item("DateSale") = Format(sDt3.Rows(i).Item("DateSale"), "dd/MM/yyyy")
    '        DeliveryDoc.Rows(rc).Item("DatePay") = Format(sDt3.Rows(i).Item("DatePay"), "dd/MM/yyyy")
    '        DeliveryDoc.Rows(rc).Item("DocCode") = sDt3.Rows(i).Item("DocCode")
    '        DeliveryDoc.Rows(rc).Item("DocRef") = sDt3.Rows(i).Item("DocRef")
    '        DeliveryDoc.Rows(rc).Item("Total") = sDt3.Rows(i).Item("Total")
    '        DeliveryDoc.Rows(rc).Item("DiscountAmout") = sDt3.Rows(i).Item("DiscountAmout")
    '        DeliveryDoc.Rows(rc).Item("DiscountPerc") = sDt3.Rows(i).Item("DisCount")
    '        DeliveryDoc.Rows(rc).Item("TotalNet") = sDt3.Rows(i).Item("TotalNet")
    '        DeliveryDoc.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
    '        DeliveryDoc.Rows(rc).Item("PsSale") = sDt3.Rows(i).Item("PsSale")
    '        DeliveryDoc.Rows(rc).Item("PaymentTerms") = sDt3.Rows(i).Item("PaymentTerms")
    '        DeliveryDoc.Rows(rc).Item("Transport") = sDt3.Rows(i).Item("Transport")
    '        'DeliveryDoc.Rows(rc).Item("note") = sDt3.Rows(i).Item("note")
    '        DeliveryDoc.Rows(rc).Item("idPdPk") = sDt3.Rows(i).Item("idProduct")
    '        DeliveryDoc.Rows(rc).Item("Amount") = sDt3.Rows(i).Item("Amount")
    '        DeliveryDoc.Rows(rc).Item("Price") = sDt3.Rows(i).Item("Price")
    '        DeliveryDoc.Rows(rc).Item("DisPerc") = sDt3.Rows(i).Item("DisCount")
    '        DeliveryDoc.Rows(rc).Item("DiscountBath") = sDt3.Rows(i).Item("DisCount")
    '        If sDt3.Rows(i).Item("idInvGroup") = 30 Then 'ค่าขนส่ง
    '            DeliveryDoc.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("ProductName")
    '        Else
    '            DeliveryDoc.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("ProductName") & vbNewLine & "Lot No. : " & sDt3.Rows(i).Item("Lotno")
    '        End If
    '        DeliveryDoc.Rows(rc).Item("idPkUnit") = sDt3.Rows(i).Item("idUnit")
    '        DeliveryDoc.Rows(rc).Item("PkUnitName") = sDt3.Rows(i).Item("UnitName")
    '        DeliveryDoc.Rows(rc).Item("PdCode") = sDt3.Rows(i).Item("PdCode")
    '        DeliveryDoc.Rows(rc).Item("address") = sDt3.Rows(i).Item("address")
    '        'If sDt.Rows(i).Item("idPV") = 1 Then
    '        '    DeliveryDoc.Rows(rc).Item("address") = sDt.Rows(i).Item("address").ToString.Replace("เขต", vbNewLine & "เขต")
    '        'Else
    '        '    DeliveryDoc.Rows(rc).Item("address") = sDt.Rows(i).Item("address").ToString.Replace("อ.", vbNewLine & "อ.")
    '        'End If
    '        ' DeliveryDoc.Rows(rc).Item("AddressS") = sDt3.Rows(i).Item("AddressS")
    '        DeliveryDoc.Rows(rc).Item("Tel") = sDt3.Rows(i).Item("Tel")
    '        DeliveryDoc.Rows(rc).Item("Fax") = sDt3.Rows(i).Item("Fax")
    '        DeliveryDoc.Rows(rc).Item("idPsSale") = sDt3.Rows(i).Item("idPsSale")
    '        DeliveryDoc.Rows(rc).Item("idCus") = sDt3.Rows(i).Item("idCus")
    '        DeliveryDoc.Rows(rc).Item("PriceBfDis") = sDt3.Rows(i).Item("PriceBfDis")
    '        DeliveryDoc.Rows(rc).Item("TaxCode") = sDt3.Rows(i).Item("TaxCode")
    '        'If Not IsDBNull(sDt3.Rows(i).Item("PsRecName")) Then
    '        '    DeliveryDoc.Rows(rc).Item("PsRecName") = sDt3.Rows(i).Item("PsRecName")
    '        'End If
    '    Next

    '    '-------------------------- Footer Detail -------------------------------'
    '    If sDt3.Rows(0).Item("stFromS") = "0" Then 'Address row
    '        DeliveryDoc.Rows.Add() 'empty row
    '        Dim rowi As Integer = DeliveryDoc.Rows.Count
    '        DeliveryDoc.Rows.Add()
    '        If Not IsDBNull(sDt3.Rows(0).Item("PsRecName")) Then
    '            DeliveryDoc.Rows(rowi).Item("PdPkName") = "ส่ง : " & sDt3.Rows(0).Item("PsRecName")
    '        Else
    '            DeliveryDoc.Rows(rowi).Item("PdPkName") = "ส่ง : "
    '        End If

    '        DeliveryDoc.Rows.Add()
    '        DeliveryDoc.Rows(rowi + 1).Item("PdPkName") = sDt3.Rows(0).Item("AddressS")
    '        DeliveryDoc.Rows.Add()
    '        If sDt3.Rows(0).Item("TelOfAddrSent") <> "" Then
    '            DeliveryDoc.Rows(rowi + 2).Item("PdPkName") = "โทร. " & sDt3.Rows(0).Item("TelOfAddrSent")
    '        Else
    '            DeliveryDoc.Rows(rowi + 2).Item("PdPkName") = "โทร. - "
    '        End If
    '    End If


    '    If sDt3.Rows(0).Item("note") <> "" Then 'Address row
    '        Dim strArr() As String
    '        strArr = sDt3.Rows(0).Item("Note").Split("\")

    '        DeliveryDoc.Rows.Add() 'empty row
    '        Dim rowN As Integer = DeliveryDoc.Rows.Count
    '        DeliveryDoc.Rows.Add()
    '        DeliveryDoc.Rows(rowN).Item("PdPkName") = "หมายเหตุ : " & strArr(0)

    '        For ai As Integer = 1 To strArr.Length - 1
    '            rowN = rowN + 1
    '            DeliveryDoc.Rows.Add()
    '            DeliveryDoc.Rows(rowN).Item("PdPkName") = strArr(ai)
    '        Next
    '    End If
    '    '------------------------------ END Footer --------------------------------------'

    '    'Dim URL As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & gidComp & ".jpg"
    '    'Dim client As New System.Net.WebClient
    '    'Dim buffer As Byte()
    '    'Dim pic() As Byte

    '    'Try
    '    '    buffer = client.DownloadData(URL)
    '    '    Dim stream As New System.IO.MemoryStream(buffer)
    '    '    Dim binReader As New IO.BinaryReader(stream)
    '    '    pic = binReader.ReadBytes(stream.Length)
    '    '    For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
    '    '        DeliveryDoc.Rows(i).Item("picComp") = pic
    '    '    Next
    '    'Catch ex As Exception
    '    '    ' Noimage
    '    'End Try

    '    'If gidComp = 11 Then 'siamAdvanceHost
    '    '    '---sign PsSale Pic---'
    '    '    Dim URL2 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & DeliveryDoc.Rows(0).Item("idPsSale") & ".png"
    '    '    'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
    '    '    Try
    '    '        buffer = client.DownloadData(URL2)
    '    '        Dim stream As New System.IO.MemoryStream(buffer)
    '    '        Dim binReader As New IO.BinaryReader(stream)
    '    '        pic = binReader.ReadBytes(stream.Length)
    '    '        For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
    '    '            DeliveryDoc.Rows(i).Item("picSignPsSale") = pic
    '    '        Next
    '    '    Catch ex As Exception
    '    '        stSignPsSale = 1
    '    '        'Noimage
    '    '    End Try
    '    'Else
    '    '    stSignPsSale = 1 'Noimage
    '    'End If


    '    Dim dtCustomer As New DataTable
    '    sDt3.Clear()
    '    sCommand.CommandText = "Select m.idSale, m.DateTsD As DateTs, m.DateSaleD As DateSale, " & vbNewLine &
    '                           "devsk.fncStrDateToDateTime(m.DatePay) As DatePay, m.DocCode, m.DocRef, m.Total, m.DiscountAmout, " & vbNewLine &
    '                           "m.DiscountPerc, m.TotalNet, m.PartnerNameBill As CusName, m.PsSale, m.PaymentTerms, m.Transport, m.note, " & vbNewLine &
    '                           "c.address, m.AddressS, (CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As Tel, " & vbNewLine &
    '                           "c.Fax, c.TaxCode, m.idPsSale, m.idPsSet, m.idPsSend, m.idCus, m.PsRecName, m.TelOfAddrSent, ISNULL(m.stFromS, 1) As stFromS" & vbNewLine &
    '                           "FROM  vSmSaleMt m " & vbNewLine &
    '                           "LEFT OUTER JOIN dPartner pn ON m.idPartner = pn.idPartner" & vbNewLine &
    '                           "LEFT OUTER JOIN dCustomer c ON m.idCus = c.idCus " &
    '                           "WHERE m.idSale IN ( " & stridSale & ")"
    '    sAdapter.Fill(dtCustomer)

    '    'Dim RegionDt As New DataTable
    '    'RegionDt.Clear()
    '    'sCommand.CommandText = "Select r.RegionName, ps.idPsSale" & vbNewLine &
    '    '                        "From SmRegionDComp r" & vbNewLine &
    '    '                        "Left Join SmMkCusPs p ON p.idRegionC = r.idRegion" & vbNewLine &
    '    '                        "Left Join SmRegionPsSaleComp ps ON ps.idRegionC = r.idRegion " & vbNewLine &
    '    '                        "WHERE ps.idComp = " & gidComp & vbNewLine &
    '    '                        "And p.idCus = " & DeliveryDoc.Rows(0).Item("idCus") & vbNewLine &
    '    '                        "AND ps.idPsSale = " & DeliveryDoc.Rows(0).Item("idPsSale")

    '    'sAdapter.Fill(RegionDt)
    '    'Dim Regionlist As String = ""
    '    'For i As Integer = 0 To RegionDt.Rows.Count - 1
    '    '    If i = 0 Then
    '    '        Regionlist = RegionDt.Rows(i).Item("RegionName")
    '    '    Else
    '    '        Regionlist = Regionlist & ", " & RegionDt.Rows(i).Item("RegionName")
    '    '    End If
    '    'Next
    '    'For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
    '    '    DeliveryDoc.Rows(i).Item("RegianName") = Regionlist
    '    'Next



    '    Dim vRpt As New crpInvoice9x11_Multi
    '    'vRpt.OpenSubreport("Customer").SetDataSource(dtCustomer)
    '    'vRpt.OpenSubreport("ProductSale").SetDataSource(DeliveryDoc)
    '    vRpt.OpenSubreport("crpInvoice9x11.rpt").SetDataSource(DeliveryDoc)
    '    'vRpt.SetDataSource(DeliveryDoc)
    '    'vRpt.SetParameterValue(vRpt.Parameter_idSale.ParameterFieldName, 0)
    '    vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, sCompName)
    '    vRpt.SetParameterValue(vRpt.Parameter_CompNameEng.ParameterFieldName, "")
    '    vRpt.SetParameterValue(vRpt.Parameter_AddressCompEng.ParameterFieldName, "")
    '    vRpt.SetParameterValue(vRpt.Parameter_AddressComp.ParameterFieldName, "")
    '    'vRpt.SetParameterValue(vRpt.Parameter_CompTel.ParameterFieldName, "")
    '    'vRpt.SetParameterValue(vRpt.Parameter_CompFax.ParameterFieldName, "")
    '    'vRpt.SetParameterValue(vRpt.Parameter_TaxCode.ParameterFieldName, "")
    '    'vRpt.SetParameterValue(vRpt.Parameter_stSignPsSale.ParameterFieldName, stSignPsSale)
    '    'vRpt.SetParameterValue(vRpt.Parameter_ptVATType.ParameterFieldName, 2)

    '    '--show from cystalreport--'
    '    Dim vFrmRpt As New FrmReportView
    '    vFrmRpt.crView.ReportSource = vRpt
    '    vFrmRpt.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    '    vFrmRpt.crView.ShowExportButton = False
    '    vFrmRpt.crView.ShowGroupTreeButton = False
    '    vFrmRpt.Show()
    '    mdLoadCommitt()
    '    'SplashScreenManager.CloseForm(False)
    'End Sub

    Private Sub fnNoticeLine()

        Dim Result As DialogResult
        Result = MessageBox.Show("คุณต้องการส่งการแจ้งเตือนไลน์ ใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If Result = Windows.Forms.DialogResult.Yes Then
            Dim dv As New DataView(CopySmSaleDt)
            dv.RowFilter = "idSale = " & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idSale")
            Dim strSmSaleDt As String = ""

            If dv.Count >= 2 Then
                For i As Integer = 0 To 1
                    ' Dim dr_ As DataRow = gMainReturn.NewRow
                    strSmSaleDt = strSmSaleDt & "- เลขที่ PO : " & dv.Item(i).Item("DocCode_PO") & " | " & dv.Item(i).Item("ProductName") & " จำนวน: " & Format(dv.Item(i).Item("Amount"), "#,##0.####") & " " & dv.Item(i).Item("UnitName") & " ราคา: ฿" & Format(dv.Item(i).Item("Price"), "#,##0.####") & " รวม: ฿" & Format(dv.Item(i).Item("ExSump"), "#,##0.####") & vbNewLine
                Next

                If dv.Count <> 2 Then
                    strSmSaleDt = strSmSaleDt & ". . ." & vbNewLine
                End If

            Else

                strSmSaleDt = strSmSaleDt & "- เลขที่ PO : " & dv.Item(0).Item("DocCode_PO") & " " & dv.Item(0).Item("ProductName") & " จำนวน: " & Format(dv.Item(0).Item("Amount"), "#,##0.####") & " " & dv.Item(0).Item("UnitName") & " ราคา: ฿" & Format(dv.Item(0).Item("Price"), "#,##0.####") & " รวม: ฿" & Format(dv.Item(0).Item("ExSump"), "#,##0.####") & vbNewLine
                'strSmSaleDt = strSmSaleDt & "- " & dv.GetRowCellValue(0, "CodeOrder") & " " & dv.GetRowCellValue(0, "ProductName") & " จำนวน: " & Format(DGVBind.GetRowCellValue(0, "Amount"), "#,##0.####") & " " & DGVBind.GetRowCellValue(0, "UnitName") & " ราคา: ฿" & Format(DGVBind.GetRowCellValue(0, "Price"), "#,##0.####") & " รวม: ฿" & Format(DGVBind.GetRowCellValue(0, "Total"), "#,##0.####")
            End If

            Dim strStatusApp As String = ""

            If Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsAccept")) = "" Then
                strStatusApp = strStatusApp & "ผู้รับทราบ : " & ShrinkURL(sAprBaseUrl & "/sam/aprBill/accept/" & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idSale")) & vbCrLf
            Else
                strStatusApp = strStatusApp & "ผู้รับทราบ : " & Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsAccept")) & vbCrLf
            End If

            If Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsCheck")) = "" Then
                strStatusApp = strStatusApp & "ผู้ตรวจสอบ : " & ShrinkURL(sAprBaseUrl & "/sam/aprBill/check/" & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idSale")) & vbCrLf
            Else
                strStatusApp = strStatusApp & "ผู้ตรวจสอบ : " & Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsCheck")) & vbCrLf
            End If

            If Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsApp")) = "" Then
                strStatusApp = strStatusApp & "ผู้อนุมัติ 1 : " & ShrinkURL(sAprBaseUrl & "/sam/aprBill/approve/" & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idSale")) & vbCrLf
            Else
                strStatusApp = strStatusApp & "ผู้อนุมัติ 1 : " & Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsApp")) & vbCrLf
            End If

            If Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsApp2")) = "" Then
                strStatusApp = strStatusApp & "ผู้อนุมัติ 2 : " & ShrinkURL(sAprBaseUrl & "/sam/aprBill/approve/" & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idSale")) & vbCrLf
            Else
                strStatusApp = strStatusApp & "ผู้อนุมัติ 2 : " & Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsApp2")) & vbCrLf
            End If

            mdCnOpen()

            If Result = Windows.Forms.DialogResult.Yes Then
                Dim dt As New DataTable
                '---------------- Line Alert (InsertDB-Way) ------------------------'
                Dim LineId As Integer = 0 'Test-Line Group (Line ID: 2 ห้องทดสอบแจ้งเตือนไลน์)

                sCommand.CommandText = "SELECT parentid " & vbNewLine &
                                            "FROM PchInvAndProject.devsk.dGroupCompMap" & vbNewLine &
                                            "WHERE stActive = 1" & vbNewLine &
                                            "AND idComp = " & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idComp")

                sAdapter.Fill(dt)

                If dt.Rows(0).Item("parentid") = 1 Then ' AV Group
                    LineId = 60
                ElseIf dt.Rows(0).Item("parentid") = 2 Then 'GR Group
                    LineId = 61
                ElseIf dt.Rows(0).Item("parentid") = 3 Then 'FL Group
                    LineId = 62
                End If

                If GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idComp") = 64 Then
                    LineId = 131
                ElseIf GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("idComp") = 5 Then
                    LineId = 2 ' ห้องทำสอบ
                End If


                Dim MsgLine = "เรียนผู้อนุมัติ (" & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("CompanyName") & ")" & vbCrLf &
                                  "เลขที่อ้างอิง: " & GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("DocRef") & vbCrLf &
                                  "ชื่อลูกค้า: " & Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("CusName")) & vbCrLf &
                                  "หมายเหตุ: " & Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("Note")) & vbCrLf &
                                  "จำนวนเงินสุทธิ: " & Format(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("TotalNet"), "#,##0.####") & " บาท" & vbCrLf &
                                  "ผู้ทำรายการ: " & Trim(GVSaleMt.GetDataRow(GVSaleMt.FocusedRowHandle).Item("PsTs")) & vbCrLf &
                                  "-----------รายการ-----------" & vbCrLf &
                                  strSmSaleDt & vbCrLf &
                                  "> สถานะอนุมัติ และลิ้งค์ทำรายการ <" & vbCrLf &
                                   strStatusApp

                'Console.WriteLine(LineId)

                Console.WriteLine(MsgLine)

                'sCommand.CommandText = "INSERT INTO LineNotify(lineID, Messages, idPsTs) " &
                '                            "VALUES(" & LineId & ", '" & MsgLine & "', " & sPsId & ")"
                'sCommand.ExecuteNonQuery()

                MessageBox.Show("แจ้งเตือนไลน์ เรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If


        '    Dim strSmSaleDt As String = ""
        'If DGVBind.RowCount >= 2 Then
        '    For i As Integer = 0 To 1
        '        ' Dim dr_ As DataRow = gMainReturn.NewRow
        '        strSmSaleDt = strSmSaleDt & "- " & DGVBind.GetRowCellValue(i, "CodeOrder") & " " & DGVBind.GetRowCellValue(i, "ProductName") & " จำนวน: " & Format(DGVBind.GetRowCellValue(i, "Amount"), "#,##0.####") & " " & DGVBind.GetRowCellValue(i, "UnitName") & " ราคา: ฿" & Format(DGVBind.GetRowCellValue(i, "Price"), "#,##0.####") & " รวม: ฿" & Format(DGVBind.GetRowCellValue(i, "Total"), "#,##0.####") & vbNewLine
        '    Next

        '    If DGVBind.RowCount <> 2 Then
        '        strSmSaleDt = strSmSaleDt & ". . ." & vbNewLine
        '    End If

        'Else

        '    strSmSaleDt = strSmSaleDt & "- " & DGVBind.GetRowCellValue(0, "CodeOrder") & " " & DGVBind.GetRowCellValue(0, "ProductName") & " จำนวน: " & Format(DGVBind.GetRowCellValue(0, "Amount"), "#,##0.####") & " " & DGVBind.GetRowCellValue(0, "UnitName") & " ราคา: ฿" & Format(DGVBind.GetRowCellValue(0, "Price"), "#,##0.####") & " รวม: ฿" & Format(DGVBind.GetRowCellValue(0, "Total"), "#,##0.####") & vbNewLine

        'End If

        'Dim strStatusApp As String = ""

        'strStatusApp = strStatusApp & "ผู้รับทราบ : " & ShrinkURL(sAprBaseUrl & "/sam/aprBill/accept/" & gidSale) & vbCrLf &
        'strStatusApp = strStatusApp & "ผู้ตรวจสอบ : " & ShrinkURL(sAprBaseUrl & "/sam/aprBill/check/" & gidSale) & vbCrLf &
        'strStatusApp = strStatusApp & "ผู้อนุมัติ 1 : " & ShrinkURL(sAprBaseUrl & "/sam/aprBill/approve/" & gidSale) & vbCrLf &
        'strStatusApp = strStatusApp & "ผู้อนุมัติ 2 : " & ShrinkURL(sAprBaseUrl & "/sam/aprBill/approve/" & gidSale)


        'mdCnOpen()
        'Dim dt As New DataTable
        ''---------------- Line Alert (InsertDB-Way) ------------------------'
        'Dim LineId As Integer = 0 'Test-Line Group (Line ID: 2 ห้องทดสอบแจ้งเตือนไลน์)

        'sCommand.CommandText = "SELECT parentid " & vbNewLine &
        '                                    "FROM PchInvAndProject.devsk.dGroupCompMap" & vbNewLine &
        '                                    "WHERE stActive = 1" & vbNewLine &
        '                                    "AND idComp = " & cmbGroupComp.SelectedValue

        'sAdapter.Fill(dt)

        'If dt.Rows(0).Item("parentid") = 1 Then ' AV Group
        '    LineId = 60
        'ElseIf dt.Rows(0).Item("parentid") = 2 Then 'GR Group
        '    LineId = 61
        'ElseIf dt.Rows(0).Item("parentid") = 3 Then 'FL Group
        '    LineId = 62
        'End If

        'If cmbGroupComp.SelectedValue = 64 Then
        '    LineId = 131
        'ElseIf cmbGroupComp.SelectedValue = 5 Then
        '    LineId = 2 ' ห้องทดสอบ
        'End If

        'Dim NoteMt As String = ""
        'Dim count As Integer = dt_Note.Rows.Count

        'If count = 0 Then
        '    NoteMt = ""
        'Else
        '    NoteMt = gvNote.GetDataRow(0).Item("Note")

        '    For i As Integer = 1 To gvNote.DataRowCount - 1
        '        NoteMt &= "\" & gvNote.GetDataRow(i).Item("Note")
        '    Next
        '    NoteMt = NoteMt.Replace("'", "''")
        'End If


        'Dim MsgLine = "เรียนผู้อนุมัติ (" & cmbGroupComp.Text & ")" & vbCrLf &
        '                          "เลขที่อ้างอิง: " & cmbDRCode.Text & " " & Trim(txtDocRef.Text) & vbCrLf &
        '                          "ชื่อลูกค้า: " & Trim(lblPartnerName.Text) & vbCrLf &
        '                          "หมายเหตุ: " & Trim(NoteMt) & vbCrLf &
        '                          "จำนวนเงินสุทธิ: " & Format(txtTotalNet.Text, "#,##0.####") & " บาท" & vbCrLf &
        '                          "ผู้ทำรายการ: " & Trim(stLbl_PsTs.Text) & vbCrLf &
        '                          "-----------รายการ-----------" & vbCrLf &
        '                          strSmSaleDt & vbCrLf &
        '                          "> สถานะอนุมัติ และลิ้งค์ทำรายการ <" & vbCrLf &
        '                           strStatusApp

        ''Console.WriteLine(LineId)

        ''Console.WriteLine(MsgLine)

        'sCommand.CommandText = "INSERT INTO LineNotify(lineID, Messages, idPsTs) " &
        '                                    "VALUES(" & LineId & ", '" & MsgLine & "', " & sPsId & ")"
        'sCommand.ExecuteNonQuery()

        ''MessageBox.Show("แจ้งเตือนไลน์ เรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub rptAddPic_Click(sender As Object, e As EventArgs) Handles rptAddPic.Click
        idSaleShow = GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)

        Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eAddPic, idSaleShow, 0)
        vFrm.ShowDialog()
    End Sub

    Private Sub btnPrintMulti_Click(sender As Object, e As EventArgs) Handles btnPrintMulti.Click
        Dim vFrm As New frmPrintCont
        vFrm.ShowDialog()
    End Sub

End Class