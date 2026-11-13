Imports System.Data.SqlClient
Imports DevExpress.XtraSplashScreen

Public Class frmCreditDebitNoteData

    Enum eProcess
        eAddxEditCreditNote
        eViewCreditNote
        eCancelCreditNote
        eAddxEditDebitNote
        eViewDebitNote
        eCancelDebitNote
        eSelectDebit
        eSelectCredit
    End Enum

    Dim Process As eProcess
    Dim stLoad As Integer = 0
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim strTxt As String = ""
    Public _dt As New DataTable
    Sub New(ByVal aProcess As eProcess, Optional aIdCus As Integer = 0, Optional aCusName As String = "")

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        My.Application.ChangeCulture("th-TH")

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            '---ลดหนี้/เพิ่มหนี้
            Case eProcess.eAddxEditCreditNote
                ColDoc.Visible = False
                Me.Text = "ทำรายการ/แก้ไขรายการลดหนี้"
                strTxt = "ลดหนี้"
                GVCreditNoteMt.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
            Case eProcess.eViewCreditNote
                btnNew.Visible = False
                rptEdit.Buttons(0).Image = My.Resources.Resources.gv_document_open
                ColEdit.Caption = "ข้อมูล"
                Me.Text = "ข้อมูลรายการลดหนี้"
                strTxt = "ลดหนี้"
                GVCreditNoteMt.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
            Case eProcess.eCancelCreditNote
                btnNew.Visible = False
                rptEdit.Buttons(0).Image = My.Resources.Resources.cross_circle_frame
                ColEdit.Caption = "ยกเลิก"
                ColDoc.Visible = False
                Me.Text = "ยกเลิกรายการลดหนี้"
                strTxt = "ลดหนี้"
                GVCreditNoteMt.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
            Case eProcess.eAddxEditDebitNote
                ColDoc.Visible = False
                Me.Text = "ทำรายการ/แก้ไขรายการเพิ่มหนี้"
                btnNew.Text = "ทำรายการเพิ่มหนี้"
                strTxt = "เพิ่มหนี้"
                ColDateNote.Caption = "วันที่เพิ่มหนี้"
                GVCreditNoteMt.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
            Case eProcess.eViewDebitNote
                btnNew.Visible = False
                rptEdit.Buttons(0).Image = My.Resources.Resources.gv_document_open
                ColEdit.Caption = "ข้อมูล"
                Me.Text = "ข้อมูลรายการเพิ่มหนี้"
                strTxt = "เพิ่มหนี้"
                ColDateNote.Caption = "วันที่เพิ่มหนี้"
                GVCreditNoteMt.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
            Case eProcess.eCancelDebitNote
                btnNew.Visible = False
                rptEdit.Buttons(0).Image = My.Resources.Resources.cross_circle_frame
                ColEdit.Caption = "ยกเลิก"
                ColDoc.Visible = False
                Me.Text = "ยกเลิกรายการเพิ่มหนี้"
                strTxt = "เพิ่มหนี้"
                ColDateNote.Caption = "วันที่เพิ่มหนี้"
                GVCreditNoteMt.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
            Case eProcess.eSelectDebit
                btnNew.Visible = False
                rptEdit.Buttons(0).Image = My.Resources.Resources.cross_circle_frame
                ColEdit.Visible = False
                ColDoc.Visible = False

                Me.Text = "เลือกรายการเพิ่มหนี้"
                strTxt = "เพิ่มหนี้"
                ColDateNote.Caption = "วันที่เพิ่มหนี้"
                cbCus.Checked = True
                cbCus.Enabled = False
                txtPartnerName.Tag = aIdCus
                txtPartnerName.Text = aCusName
                btnCustomer.Enabled = False
                rdbYear.Checked = True
                dtpYear.Enabled = True
                btnOK.Visible = True
        End Select
        Process = aProcess
    End Sub

    Private Sub frmCreditNoteData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpYear.Value = Date.Now

      
        BindData()


        stLoad = 1
    End Sub

    Private Sub BindData()
        mdConnectDbSPM()
        'mdCnOpen()
        mdLoadShow()
        Dim vWhere As String = "WHERE mt.idComp IN ( " & sIdComp & ")"

        Dim vField As String = "mt.DateNote"

        If Process = eProcess.eViewCreditNote Or Process = eProcess.eCancelCreditNote Or Process = eProcess.eAddxEditCreditNote Or Process = eProcess.eSelectCredit Then
            '---Credit Note
            vWhere = vWhere & " AND mt.NoteType = 1"
        Else
            '---Debit Note
            vWhere = vWhere & " AND mt.NoteType = 2"
        End If

        If Me.rdbDate.Checked = True Then
            Dim firstDate As DateTime = Convert.ToDateTime(dtpCreditNS.Value, _cultureEnInfo)
            Dim lastDate As DateTime = Convert.ToDateTime(dtpCreditNE.Value, _cultureEnInfo)
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
        End If
        If cbCus.Checked = True Then
            vWhere &= " And mt.idPartner = " & txtPartnerName.Tag
        End If

        Dim ds0 As New DataSet
        Dim MainDt As New DataTable
        Dim SubDt As New DataTable


        sCommand.CommandText = "SELECT ISNULL(dc.DocCode,'') + ' ' + mt.DocRef As DocRef, comp.CompCode, mt.idNote, mt.DocCode , mt.DateNote, pn.PartnerName, mt.idComp," & vbNewLine &
                               "mt.TotalSale, mt.TotalNew, mt.TotalDiff, mt.Note, mt.idPsCancel, p.PsName As PsCancelName, mt.CancelNote, mt.DateCancel, comp.CompName " & vbNewLine &
                               "FROM devsk.SmCreditDebitNoteMt mt " & vbNewLine &
                               "LEFT JOIN dDocumentCode dc ON mt.idDocCode = dc.idDocCode" & vbNewLine &
                               "LEFT JOIN devsk.dPartner pn ON mt.idPartner = pn.idPartner" & vbNewLine &
                               "LEFT JOIN PchInvAndProject.dbo.dCompany comp ON mt.idComp = comp.idComp" & vbNewLine &
                               "LEFT JOIN devsk.vPersonxSelect p ON mt.idPsCancel = p.idPs" & vbNewLine &
                                vWhere & vbNewLine &
                               "Order By mt.DateNote DESC, mt.DocCode DESC"
        sAdapter.Fill(MainDt)
        '   "LEFT JOIN SmCreditNoteDt dt ON mt.idCreditN = dt.idCreditN" & vbNewLine & _

        sCommand.CommandText = "SELECT dt.idNote, inv.InvCode, inv.InvName As ProductName, sDt.LotNo, dt.Amount, u.UnitName, dt.PriceSale,  " & vbNewLine &
                               "dt.PriceNew, dt.PriceDiff, dt.Amount*dt.PriceDiff As TotalPriceDiff, sMt.DocRef, sMt.DateSaleD  " & vbNewLine &
                               "FROM devsk.SmCreditDebitNoteDt dt " & vbNewLine &
                               "LEFT JOIN devsk.SmCreditDebitNoteMt mt ON dt.idNote = mt.idNote " & vbNewLine &
                               "LEFT JOIN SmSaleDtAll sDt ON dt.idSaleDt = sDt.idSaleDt" & vbNewLine &
                               "LEFT JOIN SmSaleMt sMt ON sDt.idSale = sMt.idSale" & vbNewLine &
                               "LEFT JOIN devsk.dInvUnit u ON dt.idUnit = u.idUnit" & vbNewLine &
                               "LEFT JOIN devsk.dInventoryMain inv ON dt.idProduct = inv.idInvMain" & vbNewLine &
                               vWhere & vbNewLine &
                               "Order By mt.DateNote DESC, mt.DocCode DESC, sDt.No ASC"

        sAdapter.Fill(SubDt)


        ds0.Tables.Clear()
        ds0.Tables.Add(MainDt)
        ds0.Tables.Add(SubDt)

        Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idNote")
        Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idNote")

        ds0.Relations.Add("รายการ" & strTxt, keyColumn, foreignColumn)

        If ds0.Tables(0).Rows.Count <= 0 Then
            MessageBox.Show("ไม่พบข้อมูลรายการ" & strTxt, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        GCCreditNote.DataSource = ds0.Tables(0)
        GCCreditNote.ForceInitialize()

        GCCreditNote.LevelTree.Nodes.Add("รายการ" & strTxt, GVCreditNoteDt)
        GVCreditNoteDt.ExpandAllGroups()

        mdLoadCommitt()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If Process = eProcess.eAddxEditCreditNote Then
            Dim vFrm As New frmCreditDebitNoteTs(frmCreditDebitNoteTs.eProcess.eAddCredit, 0)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                BindData()
                btnNew.PerformClick()
            End If

        ElseIf Process = eProcess.eAddxEditDebitNote Then
            Dim vFrm As New frmCreditDebitNoteTs(frmCreditDebitNoteTs.eProcess.eAddDebit, 0)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                BindData()
                btnNew.PerformClick()
            End If
        End If

    End Sub


    Private Sub GVCreditNoteDt_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVCreditNoteDt.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNo" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If
    End Sub

    Private Sub GVCreditNoteMt_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVCreditNoteMt.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If
    End Sub

    Private Sub btnSFindAll_Click(sender As Object, e As EventArgs) Handles btnSFindAll.Click
        '  mdCnOpen()
        ' SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        ' mdLoadShow()
        BindData()
        ' mdLoadCommitt()
        '  SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub fnFilterDataOnGrid()
        Dim StrFilter As String = ""


        If cbDocCode.Checked = True Then
            StrFilter &= " AND [DocCode] LIKE '%" & Trim(txtDocCode.Text) & "%'"
        End If


        If cbCus.Checked = True Then
            StrFilter &= " AND [PartnerName] LIKE '%" & Trim(txtPartnerName.Text) & "%'"
        End If

        GVCreditNoteMt.ActiveFilterString = " 1=1 " + StrFilter
    End Sub

    Private Sub cbDocCode_CheckedChanged(sender As Object, e As EventArgs) Handles cbDocCode.CheckedChanged
        If stLoad = 1 Then
            If cbDocCode.Checked = True Then
                txtDocCode.Enabled = True
                txtDocCode.Focus()
            Else
                txtDocCode.Enabled = False
                txtDocCode.Text = ""
            End If

            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub ChkCus_CheckedChanged(sender As Object, e As EventArgs) Handles cbCus.CheckedChanged
        If stLoad = 1 Then
            If cbCus.Checked = True Then
                txtPartnerName.Enabled = True
                txtPartnerName.Focus()
                btnCustomer.Enabled = True
            Else
                txtPartnerName.Enabled = False
                txtPartnerName.Text = ""
                btnCustomer.Enabled = False
            End If

            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub txtDocCode_TextChanged(sender As Object, e As EventArgs) Handles txtDocCode.TextChanged, txtPartnerName.TextChanged
        If stLoad = 1 Then
            fnFilterDataOnGrid()
        End If
    End Sub


    Private Sub rptEdit_Click(sender As Object, e As EventArgs) Handles rptEdit.Click

        If IsDBNull(GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColidPsCancel)) Then
            Select Case Process
                Case eProcess.eAddxEditCreditNote
                    Dim vFrm As New frmCreditDebitNoteTs(frmCreditDebitNoteTs.eProcess.eEditCredit, GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColidNote))
                    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        mdCnOpen()
                        mdLoadShow()  ' SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                        BindData()
                        mdLoadCommitt()  ' SplashScreenManager.CloseForm(False)
                    End If

                Case eProcess.eViewCreditNote
                    Dim vFrm As New frmCreditDebitNoteTs(frmCreditDebitNoteTs.eProcess.eViewCredit, GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColidNote))
                    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        mdCnOpen()
                        mdLoadShow()  '    SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                        BindData()
                        mdLoadCommitt()  '   SplashScreenManager.CloseForm(False)
                    End If

                Case eProcess.eCancelCreditNote
                    Dim vFrm As New frmCreditDebitNoteTs(frmCreditDebitNoteTs.eProcess.eCancelCredit, GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColidNote))
                    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        mdCnOpen()
                        mdLoadShow()  '     SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                        BindData()
                        mdLoadCommitt()  '  SplashScreenManager.CloseForm(False)
                    End If

                Case eProcess.eAddxEditDebitNote
                    Dim vFrm As New frmCreditDebitNoteTs(frmCreditDebitNoteTs.eProcess.eEditDebit, GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColidNote))
                    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        mdCnOpen()
                        mdLoadShow()  '   SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                        BindData()
                        mdLoadCommitt()  '  SplashScreenManager.CloseForm(False)
                    End If

                Case eProcess.eViewDebitNote
                    Dim vFrm As New frmCreditDebitNoteTs(frmCreditDebitNoteTs.eProcess.eViewDebit, GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColidNote))
                    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        mdCnOpen()
                        mdLoadShow()  '   SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                        BindData()
                        mdLoadCommitt()  '  SplashScreenManager.CloseForm(False)
                    End If

                Case eProcess.eCancelDebitNote
                    Dim vFrm As New frmCreditDebitNoteTs(frmCreditDebitNoteTs.eProcess.eCancelDebit, GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColidNote))
                    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        mdCnOpen()
                        mdLoadShow()  '  SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                        BindData()
                        mdLoadCommitt()  '   SplashScreenManager.CloseForm(False)
                    End If

            End Select
        End If


    End Sub

    Private Sub GVCreditNoteMt_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVCreditNoteMt.RowCellStyle
        If Not IsDBNull(GVCreditNoteMt.GetRowCellValue(e.RowHandle, ColidPsCancel)) Then
            e.Appearance.BackColor = Color.Salmon
            e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Strikeout)
        End If

    End Sub

    Private Sub GVCreditNoteMt_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVCreditNoteMt.RowClick
        If e.RowHandle < 0 Then
            Exit Sub
        End If

        If Not IsDBNull(GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColidPsCancel)) Then
            MessageBox.Show("ผู้ยกเลิก : " & GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColPsCancel) & vbNewLine & _
                            "สาเหตุยกเลิก : " & GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, colNoteCancel), sSystemName)
        End If
    End Sub

    Private Sub fnGetrptCreditNote()

        Dim AddressComp As String = ""
        Dim CompnameEng As String = ""
        Dim AddressEng As String = ""
        Dim TelComp As String = ""
        Dim FaxComp As String = ""
        Dim TexCode As String = ""
        Dim stSignPsSale As Integer = 0
        Dim strDocRef As String = ""

        Dim dtCreditNote As New DataTable

        Dim dt As New DataTable
        mdCnOpen2()
        sCommand.CommandText = "Select Address_, Tel, Fax, TaxCode, ISNULL(CompNameEng, '') As CompNameEng, " & _
                               "ISNULL(AddressEng_, '') As  AddressEng " & vbNewLine & _
                               "From vCompany Where idComp = " & GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColidComp)

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

        '---Partner Data------
        dtCreditNote.Columns.Add("PartnerName", System.Type.GetType("System.String"))
        dtCreditNote.Columns.Add("pAddress", System.Type.GetType("System.String"))
        dtCreditNote.Columns.Add("pTel", System.Type.GetType("System.String"))
        dtCreditNote.Columns.Add("Fax", System.Type.GetType("System.String"))
        dtCreditNote.Columns.Add("TaxCode", System.Type.GetType("System.String"))

        '----------------------
        dtCreditNote.Columns.Add("DocRef", System.Type.GetType("System.String"))
        dtCreditNote.Columns.Add("DocCode", System.Type.GetType("System.String"))
        dtCreditNote.Columns.Add("DateCreditNote", System.Type.GetType("System.String"))
        dtCreditNote.Columns.Add("ProductName", System.Type.GetType("System.String"))
        dtCreditNote.Columns.Add("Amount", System.Type.GetType("System.Double"))
        dtCreditNote.Columns.Add("UnitName", System.Type.GetType("System.String"))
        dtCreditNote.Columns.Add("PriceNew", System.Type.GetType("System.Double"))
        dtCreditNote.Columns.Add("TotalSale", System.Type.GetType("System.Double"))
        dtCreditNote.Columns.Add("TotalDiff", System.Type.GetType("System.Double"))
        dtCreditNote.Columns.Add("TotalNew", System.Type.GetType("System.Double"))
        dtCreditNote.Columns.Add("TotalNet", System.Type.GetType("System.Double"))
        dtCreditNote.Columns.Add("VAT", System.Type.GetType("System.String"))
        dtCreditNote.Columns.Add("VATAmount", System.Type.GetType("System.Double"))
        dtCreditNote.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))
        dtCreditNote.Columns.Add("picSignPsTs", System.Type.GetType("System.Byte[]"))
        dtCreditNote.Columns.Add("DateTs", System.Type.GetType("System.String"))
        dtCreditNote.Columns.Add("PriceDiff", System.Type.GetType("System.Double"))
        dtCreditNote.Columns.Add("Note", System.Type.GetType("System.String"))
        Dim dtTemp As New DataTable
        mdCnOpen()

        sCommand.CommandText = "SELECT comp.CompCode, mt.idNote, mt.DocCode, ps.PartnerName, mt.idComp, mt.idPsTs, mt.Note," & vbNewLine &
                              "mt.TotalSale, mt.TotalNew, mt.TotalDiff, mt.TotalNet,  mt.Note, mt.idPsCancel, p.PsName As PsCancelName, mt.CancelNote, mt.DateCancel, comp.CompName, " & vbNewLine &
                              "inv.InvCode, inv.InvName As ProductName, sDt.LotNo, dt.Amount, u.UnitName, dt.PriceSale,dt.PriceNew, " & vbNewLine &
                              "dt.PriceDiff, dt.Amount*dt.PriceDiff As TotalPriceDiff, ps.pAddress,  ps.pTel, c.Fax, c.TaxCode," & vbNewLine &
                              "mt.VAT, mt.VATAmount, mt.DocCode, FORMAT(mt.DateNote, 'd', 'th') As DateNote, mt.DateTs, sMt.DocRef" & vbNewLine &
                              "FROM devsk.SmCreditDebitNoteDt dt" & vbNewLine &
                              "LEFT JOIN devsk.SmCreditDebitNoteMt mt ON dt.idNote = mt.idNote " & vbNewLine &
                              "LEFT JOIN PchInvAndProject.dbo.dCompany comp ON mt.idComp = comp.idComp" & vbNewLine &
                              "LEFT JOIN devsk.vPersonxSelect p ON mt.idPsCancel = p.idPs" & vbNewLine &
                              "LEFT JOIN SmSaleDtAll sDt ON dt.idSaleDt = sDt.idSaleDt" & vbNewLine &
                              "LEFT JOIN SmSaleMt sMt ON sDt.idSale = sMt.idSale" & vbNewLine &
                              "LEFT JOIN devsk.dInvUnit u ON dt.idUnit = u.idUnit" & vbNewLine &
                              "LEFT JOIN devsk.dInventoryMain inv ON dt.idProduct = inv.idInvMain" & vbNewLine &
                              "LEFT JOIN devsk.dPartner ps ON mt.idPartner = ps.idPartner" & vbNewLine &
                              "LEFT OUTER JOIN dCustomer c ON ps.idCus = c.idCus " &
                              "WHERE mt.idNote =" & GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColidNote) & vbNewLine &
                              "AND PriceDiff <> 0" & vbNewLine &
                              "Order By mt.DateNote DESC, mt.DocCode DESC"
        sAdapter.Fill(dtTemp)

        'Dim strDocRef As String = ""

        '--- จุดที่ 1: แถวแรก ---
        If dtTemp.Rows.Count > 0 AndAlso Not IsDBNull(dtTemp.Rows(0).Item("DocRef")) Then
            strDocRef = dtTemp.Rows(0).Item("DocRef").ToString()
        End If

        For i As Integer = 0 To dtTemp.Rows.Count - 1
            Dim rc As Integer = dtCreditNote.Rows.Count
            dtCreditNote.Rows.Add()

            If i > 0 AndAlso Not IsDBNull(dtTemp.Rows(i).Item("DocRef")) Then
                Dim curDocRef As String = dtTemp.Rows(i).Item("DocRef").ToString()
                If curDocRef <> "" Then
                    If strDocRef = "" Then
                        strDocRef = curDocRef
                    ElseIf Not strDocRef.Contains(curDocRef) Then
                        strDocRef = strDocRef & "," & curDocRef
                    End If
                End If
            End If

            '---Partner Data------
            dtCreditNote.Rows(rc).Item("PartnerName") = dtTemp.Rows(i).Item("PartnerName")
            dtCreditNote.Rows(rc).Item("pAddress") = dtTemp.Rows(i).Item("pAddress")
            dtCreditNote.Rows(rc).Item("pTel") = dtTemp.Rows(i).Item("pTel")
            dtCreditNote.Rows(rc).Item("Fax") = dtTemp.Rows(i).Item("Fax")
            dtCreditNote.Rows(rc).Item("TaxCode") = dtTemp.Rows(i).Item("TaxCode")

            '---------------------------

            dtCreditNote.Rows(rc).Item("DocCode") = dtTemp.Rows(i).Item("DocCode")
            dtCreditNote.Rows(rc).Item("DateCreditNote") = dtTemp.Rows(i).Item("DateNote")
            dtCreditNote.Rows(rc).Item("ProductName") = dtTemp.Rows(i).Item("ProductName")
            dtCreditNote.Rows(rc).Item("Amount") = dtTemp.Rows(i).Item("Amount")
            dtCreditNote.Rows(rc).Item("UnitName") = dtTemp.Rows(i).Item("UnitName")
            dtCreditNote.Rows(rc).Item("PriceNew") = dtTemp.Rows(i).Item("PriceNew")
            dtCreditNote.Rows(rc).Item("PriceDiff") = dtTemp.Rows(i).Item("PriceDiff")
            dtCreditNote.Rows(rc).Item("TotalSale") = dtTemp.Rows(i).Item("TotalSale")
            dtCreditNote.Rows(rc).Item("TotalDiff") = dtTemp.Rows(i).Item("TotalDiff")
            dtCreditNote.Rows(rc).Item("TotalNew") = dtTemp.Rows(i).Item("TotalNew")
            dtCreditNote.Rows(rc).Item("TotalNet") = dtTemp.Rows(i).Item("TotalNet")

            dtCreditNote.Rows(rc).Item("VATAmount") = dtTemp.Rows(i).Item("VATAmount")

            dtCreditNote.Rows(rc).Item("DateTs") = dtTemp.Rows(i).Item("DateTs")
            If dtTemp.Rows(i).Item("Note") = "" Then
                dtCreditNote.Rows(rc).Item("Note") = "-"
            Else
                dtCreditNote.Rows(rc).Item("Note") = dtTemp.Rows(i).Item("Note")
            End If

        Next

        Dim URL As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColidComp) & ".jpg"
        Dim client As New System.Net.WebClient
        Dim buffer As Byte()
        Dim pic() As Byte

        Try
            buffer = client.DownloadData(URL)
            Dim stream1 As New System.IO.MemoryStream(buffer)
            Dim binReader1 As New IO.BinaryReader(stream1)
            pic = binReader1.ReadBytes(stream1.Length)
            For i As Integer = 0 To dtCreditNote.Rows.Count - 1
                dtCreditNote.Rows(i).Item("picComp") = pic
            Next
        Catch ex As Exception
            ' Noimage
        End Try

        '---sign PsTs Pic---'
        Dim URL2 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & dtTemp.Rows(0).Item("idPsTs") & ".png"
        'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
        Try
            buffer = client.DownloadData(URL2)
            Dim stream As New System.IO.MemoryStream(buffer)
            Dim binReader As New IO.BinaryReader(stream)
            pic = binReader.ReadBytes(stream.Length)
            For i As Integer = 0 To dtCreditNote.Rows.Count - 1
                dtCreditNote.Rows(i).Item("picSignPsTs") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try

        Dim strHeaderEng As String = ""
        Dim strHeaderTH As String = ""

        If Process = eProcess.eViewCreditNote Then
            strHeaderEng = "ใบลดหนี้ / ใบกำกับภาษี"
            strHeaderTH = "CREDIT NOTE / TAX INVOICE"
        ElseIf Process = eProcess.eViewDebitNote Then
            strHeaderEng = "ใบเพิ่มหนี้ / ใบกำกับภาษี"
            strHeaderTH = "DEBIT NOTE / TAX INVOICE"
        End If

        Dim vRpt As New crpCreditDebitNote
        vRpt.SetDataSource(dtCreditNote)
        'vRpt.SetParameterValue(vRpt.Parameter_idSale.ParameterFieldName, GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColidSale1))
        vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColCompName))
        vRpt.SetParameterValue(vRpt.Parameter_CompNameEng.ParameterFieldName, CompnameEng)
        vRpt.SetParameterValue(vRpt.Parameter_AddressCompEng.ParameterFieldName, AddressEng)
        vRpt.SetParameterValue(vRpt.Parameter_AddressComp.ParameterFieldName, AddressComp)
        vRpt.SetParameterValue(vRpt.Parameter_CompTel.ParameterFieldName, TelComp)
        vRpt.SetParameterValue(vRpt.Parameter_CompFax.ParameterFieldName, FaxComp)
        vRpt.SetParameterValue(vRpt.Parameter_TaxCode.ParameterFieldName, TexCode)
        vRpt.SetParameterValue(vRpt.Parameter_ptVATType.ParameterFieldName, 1) '1 = แบบถอด VAT
        vRpt.SetParameterValue(vRpt.Parameter_pDocRef.ParameterFieldName, strDocRef)
        vRpt.SetParameterValue(vRpt.Parameter_HeaderTxtEng.ParameterFieldName, strHeaderTH)
        vRpt.SetParameterValue(vRpt.Parameter_HeaderTxtTH.ParameterFieldName, strHeaderEng)
        'vRpt.SetParameterValue(vRpt.Parameter_stSignPsSale.ParameterFieldName, stSignPsSale)

        '--show from cystalreport--'
        Dim vFrmRpt As New FrmReportView
        vFrmRpt.crView.ReportSource = vRpt
        vFrmRpt.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        vFrmRpt.crView.ShowExportButton = False
        vFrmRpt.crView.ShowGroupTreeButton = False
        vFrmRpt.Show()

      
    End Sub



    Private Sub rptDoc_Click(sender As Object, e As EventArgs) Handles rptDoc.Click
        If IsDBNull(GVCreditNoteMt.GetRowCellValue(GVCreditNoteMt.FocusedRowHandle, ColidPsCancel)) Then
            mdLoadShow() '   SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            fnGetrptCreditNote()
            mdLoadCommitt() ' SplashScreenManager.CloseForm(False)

        End If
    End Sub

    Private Sub rdbMonth_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMonth.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbMonth.Checked = True Then
                Me.dtpMonthS.Enabled = True
                Me.dtpMonthE.Enabled = True

            Else
                Me.dtpMonthS.Enabled = False
                Me.dtpMonthE.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbYear_CheckedChanged(sender As Object, e As EventArgs) Handles rdbYear.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbYear.Checked = True Then
                Me.dtpYear.Enabled = True

            Else
                Me.dtpYear.Enabled = False
            End If


        End If
    End Sub

    Private Sub rdbDate_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDate.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbDate.Checked = True Then
                Me.dtpCreditNS.Enabled = True
                Me.dtpCreditNE.Enabled = True
            Else
                Me.dtpCreditNS.Enabled = False
                Me.dtpCreditNE.Enabled = False
            End If


        End If
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelect, 0)
        vFrm.pbPartnerName = Trim(txtPartnerName.Text)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

            Me.txtPartnerName.Tag = vFrm.idPartner
            Me.txtPartnerName.Text = vFrm.CusName


        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim ar() As Integer = GVCreditNoteMt.GetSelectedRows
        If ar.Length > 0 Then
            Dim dt As DataTable = DirectCast(GVCreditNoteMt.DataSource, DataTable).Clone
            Dim i As Integer = 0
            For Each row As Integer In ar
                dt.ImportRow(GVCreditNoteMt.GetDataRow(row))
            Next
            _dt = dt
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("กรุณาเลือกรายการ")
        End If
    End Sub
End Class