Imports System.Data.SqlClient
Imports System.Windows.Controls
Imports DevExpress.XtraEditors
'Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCreditDebitNoteTs

    Dim gidNote As Integer = 0
    Dim gidSale As Integer = 0
    Dim stLoad As Integer = 0
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim dtMain As New DataTable
    Dim NoteType As Integer = 0
    Dim idCus As Integer = 0
    Dim dtDel As New DataTable
    Dim chkSpaceBar As Integer = 0
    'Dim Prefixcode As String = ""
    Dim DocTypeName As String = ""
    Enum eProcess
        eAddCredit
        eEditCredit
        eViewCredit
        eCancelCredit

        eAddDebit
        eEditDebit
        eViewDebit
        eCancelDebit
    End Enum

    Dim Process As eProcess

    Sub New(ByVal aProcess As eProcess, ByVal idCreditN As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eAddCredit
                Me.Text = "ทำรายการลดหนี้"
                NoteType = 1
                'Prefixcode = "CN"
                DocTypeName = "ใบลดหนี้"
            Case eProcess.eViewCredit
                Me.Text = "รายละเอียดรายการลดหนี้"
                btnSave.Visible = False
                txtNote.Enabled = False
                txtPartnerName.Enabled = False
                btnCustomer.Visible = False
                txtDocImpress.Enabled = False
                dtpDateNote.Enabled = False
                ColPriceNew.OptionsColumn.ReadOnly = True
                ColPriceNew.OptionsColumn.AllowEdit = False
                ColDel.Visible = False
            Case eProcess.eEditCredit 'แก้ไขรายการขายสินค้ารวมทุกประเภท
                Me.Text = "แก้ไขรายการลดหนี้"
                txtDocRef.Enabled = True
                NoteType = 1
                'Prefixcode = "CN"
            Case eProcess.eCancelCredit
                Me.Text = "ยกเลิกรายการลดหนี้"
                btnCancel.Visible = True
                btnSave.Visible = False
                btnSave.Visible = False
                txtNote.Enabled = False
                txtPartnerName.Enabled = False
                btnCustomer.Visible = False
                txtDocImpress.Enabled = False
                dtpDateNote.Enabled = False
                ColPriceNew.OptionsColumn.ReadOnly = True
                ColPriceNew.OptionsColumn.AllowEdit = False
                ColDel.Visible = False
            Case eProcess.eAddDebit
                Me.Text = "ทำรายการเพิ่มหนี้"
                lblDocCode.Text = "- - - - - - - - - - "
                'lblNote.Text = "DN"
                NoteType = 2
                lblDateNote.Text = "วันที่เพิ่มหนี้"
                lblDateNote.Location = New Point(341, 75)
                'Prefixcode = "DN"
                DocTypeName = "ใบเพิ่มหนี้"
            Case eProcess.eViewDebit
                Me.Text = "รายละเอียดรายการเพิ่มหนี้"
                btnSave.Visible = False
                txtNote.Enabled = False
                txtPartnerName.Enabled = False
                btnCustomer.Visible = False
                txtDocImpress.Enabled = False
                dtpDateNote.Enabled = False
                ColPriceNew.OptionsColumn.ReadOnly = True
                ColPriceNew.OptionsColumn.AllowEdit = False
                lblDateNote.Text = "วันที่เพิ่มหนี้"
                'lblNote.Text = "DN"
                lblDateNote.Location = New Point(341, 75)
                ColDel.Visible = False
            Case eProcess.eEditDebit 'แก้ไขรายการขายสินค้ารวมทุกประเภท
                Me.Text = "แก้ไขรายการเพิ่มหนี้"
                txtDocRef.Enabled = True
                NoteType = 2
                lblDateNote.Text = "วันที่เพิ่มหนี้"
                'lblNote.Text = "DN"
                lblDateNote.Location = New Point(341, 75)
               ' Prefixcode = "DN"
            Case eProcess.eCancelDebit
                Me.Text = "ยกเลิกรายการเพิ่มหนี้"
                btnCancel.Visible = True
                btnSave.Visible = False
                btnSave.Visible = False
                txtNote.Enabled = False
                txtPartnerName.Enabled = False
                btnCustomer.Visible = False
                txtDocImpress.Enabled = False
                dtpDateNote.Enabled = False
                ColPriceNew.OptionsColumn.ReadOnly = True
                ColPriceNew.OptionsColumn.AllowEdit = False
                lblDateNote.Text = "วันที่เพิ่มหนี้"
                'lblNote.Text = "DN"
                lblDateNote.Location = New Point(341, 75)

                ColDel.Visible = False
        End Select

        Process = aProcess
        gidNote = idCreditN


    End Sub

    Private Sub frmCreditNoteTs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        setCmbGroupComp(Me.cmbGroupComp)

        fnAddDataTable()

        If Process = eProcess.eAddCredit Or Process = eProcess.eAddDebit Then  ' Add New-Combine
            mdConnectDbSPM()
            cmbDRefCode()
            cmbGroupComp.Focus()

            stLbl_DateTs.Text = "วันที่ทำรายการ : " & Date.Today
            stLbl_PsTs.Text = "ผู้ทำรายการ : " & sPsName
            stLbl_PsTs.Tag = sPsId

            Me.dtpDateNote.Value = Date.Today

            GCSale.DataSource = dtMain

        Else ' Edit / view

            cmbGroupComp.Enabled = False
            dtDel.Columns.Add("idNoteDt", System.Type.GetType("System.Int64"))

            dtpDateNote.Focus()
            mdConnectDbSPM()
            'mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
            SendKeys.Send("{TAB}")

        End If

        stLoad = 1
    End Sub

    Private Sub cmbDRefCode()

        Dim sDt As New DataTable

        sCommand.CommandText = "Select d.idDocCode, d.DocCode " & vbNewLine &
                                "From dDocumentCode d" & vbNewLine &
                                "LEFT JOIN dDocumentType t ON d.idDocType = t.idDocType AND t.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                "WHERE t.DocTypeName = '" & DocTypeName & "'" & vbNewLine &
                                "AND d.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                "AND d.stDel Is NULL"
        sAdapter.Fill(sDt)

        With cmbDRCode
            .DisplayMember = "DocCode"
            .ValueMember = "idDocCode"
            .DataSource = sDt
        End With

        If sDt.Rows.Count = 0 Then
            MessageBox.Show("บริษัทนี้ยังไม่ได้กำหนดรหัสเอกสารประเภท '" & DocTypeName & "'" & vbNewLine &
                            "จึงไม่สามารถทำรายการได้ กรุณาแจ้งผู้พัฒนาระบบ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Exit Sub
        End If

    End Sub

    Private Sub fnAddDataTable()
        dtMain.Columns.Add("idNoteDt", System.Type.GetType("System.Int64"))
        dtMain.Columns.Add("DocRef", System.Type.GetType("System.String"))
        dtMain.Columns.Add("DateSaleD", System.Type.GetType("System.String"))
        dtMain.Columns.Add("idSaleDt", System.Type.GetType("System.Int64"))
        dtMain.Columns.Add("InvCode", System.Type.GetType("System.String"))
        dtMain.Columns.Add("idProduct", System.Type.GetType("System.Int64"))
        dtMain.Columns.Add("ProductName", System.Type.GetType("System.String"))
        dtMain.Columns.Add("LotNo", System.Type.GetType("System.String"))
        dtMain.Columns.Add("AmtSale", System.Type.GetType("System.Double"))
        dtMain.Columns.Add("idUnit", System.Type.GetType("System.Int64"))
        dtMain.Columns.Add("UnitName", System.Type.GetType("System.String"))
        dtMain.Columns.Add("PriceSale", System.Type.GetType("System.Double"))
        dtMain.Columns.Add("PriceNew", System.Type.GetType("System.Double"))
        dtMain.Columns.Add("PriceDiff", System.Type.GetType("System.Double"))
        dtMain.Columns.Add("TotalPriceDiff", System.Type.GetType("System.Double"))
    End Sub

    Private Sub BindData()

        Dim dt As New DataTable
        sCommand.CommandText = "SELECT mt.idDocCode, t.DocTypeName, mt.DocCode, dt.idNote, inv.InvCode, inv.InvName As ProductName, ISNULL(sDt.LotNo,'') As LotNo, dt.Amount, u.UnitName, dt.PriceSale,  " & vbNewLine &
                              "dt.PriceNew, dt.PriceDiff, dt.Amount*dt.PriceDiff As TotalPriceDiff, mt.TotalSale, mt.TotalNew, mt.TotalDiff," & vbNewLine &
                              "sMt.DateSaleD, pn.PartnerName As PartnerNameBill, ISNULL(p.PsName,'') As PsSaleName, dt.Amount As AmtSale, mt.Note, " & vbNewLine &
                              "dt.idNoteDt, sDt.idSaleDt, sDt.idProduct, sDt.idUnit, sMt.DocRef, mt.DateNote, " & vbNewLine &
                              "mt.DocRef As DocRefImpress," & vbNewLine &
                              "mt.Vat, mt.VATAmount, mt.TotalNet, pTs.PsName As PsTsName, mt.idPsTs, mt.DateTs, u.UnitName, mt.idPartner, mt.idComp" & vbNewLine &
                              "FROM SmCreditDebitNoteDt dt " & vbNewLine &
                              "LEFT JOIN SmCreditDebitNoteMt mt ON dt.idNote = mt.idNote " & vbNewLine &
                              "LEFT JOIN dPartner pn ON mt.idPartner = pn.idPartner" & vbNewLine &
                              "LEFT JOIN SmSaleDtAll sDt ON dt.idSaleDt = sDt.idSaleDt" & vbNewLine &
                              "LEFT JOIN SmSaleMt sMt ON sDt.idSale = sMt.idSale" & vbNewLine &
                              "LEFT JOIN dInvUnit u ON dt.idUnit = u.idUnit" & vbNewLine &
                              "LEFT JOIN dInventoryMain inv ON dt.idProduct = inv.idInvMain" & vbNewLine &
                              "LEFT JOIN vPersonxSelect p ON sMt.idPsSale = p.idPs" & vbNewLine &
                              "LEFT JOIN dDocumentCode d ON mt.idDocCode = d.idDocCode AND d.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                              "LEFT JOIN dDocumentType t On d.idDocType = t.idDocType And t.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                               "LEFT JOIN vPersonxSelect pTs On mt.idPsTs = pTs.idPs" & vbNewLine &
                              "WHERE mt.idNote = " & gidNote & vbNewLine &
                              " Order By mt.DateNote DESC, mt.DocCode DESC"

        sAdapter.Fill(dt)


        cmbGroupComp.SelectedValue = dt.Rows(0).Item("idComp")
        dtpDateNote.Value = dt.Rows(0).Item("DateNote")
        'txtDocImpress.Text = dt.Rows(0).Item("DocRefImpress")
        lblDocCode.Text = dt.Rows(0).Item("DocCode")
        'txtSaleCode.Text = dt.Rows(0).Item("SaleCode")
        txtNote.Text = dt.Rows(0).Item("Note")

        cmbDRCode.SelectedValue = dt.Rows(0).Item("idDocCode")

        Dim DocRef() As String = dt.Rows(0).Item("DocRefImpress").ToString.Split(" ")

        If DocRef.Length > 1 Then
            txtDocImpress.Text = DocRef(1)
        Else
            txtDocImpress.Text = dt.Rows(0).Item("DocRefImpress")
        End If

        DocTypeName = dt.Rows(0).Item("DocTypeName")
        cmbDRefCode()
        txtPartnerName.Text = dt.Rows(0).Item("PartnerNameBill")
        txtPartnerName.Tag = dt.Rows(0).Item("idPartner")
        lblPsSale.Text = dt.Rows(0).Item("PsSaleName")
        lblTotalSale.Text = Format(dt.Rows(0).Item("TotalSale"), "#,##0.00")
        lblTotalNew.Text = Format(dt.Rows(0).Item("TotalNew"), "#,##0.00")
        lblTotalDiff.Text = Format(dt.Rows(0).Item("TotalDiff"), "#,##0.00")
        'VATAmount = Format(dt.Rows(0).Item("VATAmount"), "#,##0.00")
        txtTotalNet.Text = Format(dt.Rows(0).Item("TotalNet"), "#,##0.00")

        stLbl_DateTs.Text = "วันที่ทำรายการ : " & dt.Rows(0).Item("DateTs")
        stLbl_PsTs.Text = "ผู้ทำรายการ : " & dt.Rows(0).Item("PsTsName")
        stLbl_PsTs.Tag = dt.Rows(0).Item("idPsTs")


        GCSale.DataSource = dt

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

    Private Sub DGVBind_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles DGVBind.CellValueChanged

        If DGVBind.DataRowCount >= 0 And DGVBind.FocusedRowHandle >= 0 Then
            Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)

            If e.Column.Name = ColPriceNew.Name Then
                If IsDBNull(dr.Item("PriceSale")) Then
                    dr.Item("PriceSale") = 0.0
                End If

                If IsDBNull(dr.Item("PriceNew")) Then
                    dr.Item("PriceNew") = 0.0
                End If

                If Process = eProcess.eAddCredit Or Process = eProcess.eEditCredit Then
                    If dr.Item("PriceSale") < dr.Item("PriceNew") Then
                        MessageBox.Show("มูลค่าที่ถูกต้อง ไม่สามารถมากกว่ามูลค่าเดิมได้ " & vbNewLine & _
                                        "กรุณาตรวจสอบอีกครั้ง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        DGVBind.SetRowCellValue(DGVBind.FocusedRowHandle, "PriceNew", dr.Item("PriceSale"))

                    End If

                    DGVBind.SetRowCellValue(DGVBind.FocusedRowHandle, "PriceDiff", dr.Item("PriceSale") - dr.Item("PriceNew"))
                    DGVBind.SetRowCellValue(DGVBind.FocusedRowHandle, "TotalPriceDiff", dr.Item("PriceDiff") * dr.Item("AmtSale"))
                End If


                If Process = eProcess.eAddDebit Or Process = eProcess.eEditDebit Then
                    If dr.Item("PriceSale") > dr.Item("PriceNew") Then
                        MessageBox.Show("มูลค่าที่ถูกต้อง ไม่สามารถน้อยกว่ามูลค่าเดิมได้ " & vbNewLine & _
                                        "กรุณาตรวจสอบอีกครั้ง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        DGVBind.SetRowCellValue(DGVBind.FocusedRowHandle, "PriceNew", dr.Item("PriceSale"))

                    End If

                    DGVBind.SetRowCellValue(DGVBind.FocusedRowHandle, "PriceDiff", dr.Item("PriceNew") - dr.Item("PriceSale"))
                    DGVBind.SetRowCellValue(DGVBind.FocusedRowHandle, "TotalPriceDiff", dr.Item("PriceDiff") * dr.Item("AmtSale"))

                End If


            End If

            SumTotalNew()
        End If
    End Sub

    Private Sub SumTotalNew()
        Dim Total As Double = 0.0

        For i As Integer = 0 To DGVBind.DataRowCount - 1
            If IsDBNull(DGVBind.GetDataRow(i).Item("TotalPriceDiff")) Then
                DGVBind.GetDataRow(i).Item("TotalPriceDiff") = 0.0
            End If
            Total += DGVBind.GetDataRow(i).Item("TotalPriceDiff")
        Next

        lblTotalDiff.Text = Format(Total, "#,##0.00##")
        txtTotalNet.Text = Format(Total, "#,##0.00##")

        lblTotalNew.Text = Format((CDbl(lblTotalSale.Text) - CDbl(lblTotalDiff.Text)), "#,##0.00##")

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If DGVBind.DataRowCount <= 0 Then
            MessageBox.Show("กรุณาเลือกรายการขาย เพื่อบันทึกการ" & Me.Text, sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Exit Sub
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
                Dim vWHERE As String = ""
                Dim idNote As Integer = 0
                If Process = eProcess.eEditDebit Or Process = eProcess.eEditCredit Then 'EditData
                    vWHERE = " AND idNote <> " & gidNote & ""
                End If

                If Process = eProcess.eAddCredit Or Process = eProcess.eAddDebit Then

                    Dim stDup As Boolean = fnChkDocCodeDup(mycommand, vWHERE)

                    If stDup = False Then
                        idNote = ADDxEditSmCreditNoteMt(mycommand, 0, gidSale)

                        If idNote = 0 Then
                            Exit Sub
                        Else

                            For i As Integer = 0 To DGVBind.DataRowCount - 1
                                Dim dr As DataRow = DGVBind.GetDataRow(i)
                                ADDxEditSmCreditNoteDt(mycommand, idNote, dr)
                            Next
                        End If
                    Else
                        Exit Sub
                    End If

                ElseIf Process = eProcess.eEditCredit Or Process = eProcess.eEditDebit Then

                    ADDxEditSmCreditNoteMt(mycommand, gidNote, gidSale)

                    For i As Integer = 0 To DGVBind.DataRowCount - 1
                        Dim dr As DataRow = DGVBind.GetDataRow(i)
                        ADDxEditSmCreditNoteDt(mycommand, gidNote, dr)
                    Next

                End If


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

    End Sub

    Private Function fnChkDocCodeDup(ByVal myCommand As SqlCommand, ByVal vWHERE As String) As Boolean
        'Check DocCode Duplicate Before Insert into Database
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim dtChkDup As New DataTable
        myCommand.CommandText = "Select mt.DocCode, mt.DateNote, mt.DocRef, mt.idPscancel, p.PartnerName  " & vbNewLine &
                               "From devsk.SmCreditDebitNoteMt mt " & vbNewLine &
                               "LEFT OUTER JOIN devsk.dPartner p ON mt.idPartner = p.idPartner " & vbNewLine &
                               "WHERE mt.idPscancel IS NULL " & vbNewLine &
                               "AND mt.DocRef = '" & cmbDRCode.Text & " " & Trim(txtDocImpress.Text) & "' " & vbNewLine &
                               "AND mt.NoteType = " & NoteType & vbNewLine &
                               "AND mt.idComp = " & cmbGroupComp.SelectedValue & "" & vWHERE
        myAdapter.Fill(dtChkDup)


        'For i As Integer = 0 To dRefDt.Rows.Count - 1
        If dtChkDup.Rows.Count > 0 Then
            'If CodeRef = dRefDt.Rows(i).Item("DocRef") Then

            MessageBox.Show("เลขที่อ้างอิงซ้ำกับข้อมูลเดิม รายละเอียดรายการดังนี้ " & vbCrLf & "เลขที่รายการ : " & dtChkDup.Rows(0).Item("DocCode") & vbCrLf & _
            "วันที่ลดหนี้ : " & ksbStringToDate(dtChkDup.Rows(0).Item("DateNote")) & vbCrLf & _
            "ชื่อลูกค้า : " & dtChkDup.Rows(0).Item("PartnerName") & vbCrLf & vbCrLf & _
            "***หากต้องการบันทึก ให้เพิ่มตัวอักษรหลังรหัส ดังนี้" & vbCrLf & _
            "   A : แอ๊ดว้านซีดส์" & vbCrLf & _
            "   F : โฟลเทคซีดส์" & vbCrLf & " เช่น 6502001A หรือ 6502001F", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' MessageBox.Show("เลขที่อ้างอิงซ้ำกับข้อมูลเดิม", sSystemName)

            Return True 'มีเลขที่อ้างอิงซ้ำ
            Exit Function
            'End If
        End If

        Return False 'ไม่มีเลขที่อ้างอิงซ้ำ
    End Function


    Private Function ADDxEditSmCreditNoteMt(ByVal xCommand As SqlCommand, ByVal idNote As Integer, ByVal idSale As Integer) As Integer

        Dim DocCode As String = ""
       

        If Process = eProcess.eEditCredit Or Process = eProcess.eEditDebit Then 'Update

            xCommand.CommandText = "UPDATE devsk.SmCreditDebitNoteMt SET  DateNote = @DateNote, DateTs = @DateTs, " & vbNewLine & _
                                   "idPsTs = @idPsTs, TotalSale = @TotalSale, TotalNew = @TotalNew, TotalDiff = @TotalDiff, " & vbNewLine & _
                                   "TotalNet = @TotalNet, Note = @Note, DocRef = @DocRef " & vbNewLine & _
                                   "WHERE idNote = @idNote "

            xCommand.Parameters.Add("@idNote", SqlDbType.Int).Value = idNote

        ElseIf Process = eProcess.eAddCredit Or Process = eProcess.eAddDebit Then 'Insert

            DocCode = fnAutoRunDocCode(cmbDRCode.Text.Trim, xCommand)

            xCommand.CommandText = "Insert Into devsk.SmCreditDebitNoteMt(idDocCode, DocCode, DocRef, DateNote, DateTs, idPsTs, TotalSale, TotalNew, TotalDiff, " & vbNewLine &
                                    "TotalNet, Note, idPartner, idComp, VAT, NoteType) " &
                                   "Values(@idDocCode, @DocCode, @DocRef, @DateNote, @DateTs, @idPsTs, @TotalSale, @TotalNew, @TotalDiff, @TotalNet, @Note, @idPartner, @idComp, @VAT, @NoteType)"

        End If

        If Trim(txtDocImpress.Text) = "" Then
            cmbDRCode.Text = ""
        End If

        With xCommand.Parameters
            .Add("@idDocCode", SqlDbType.Int).Value = cmbDRCode.SelectedValue
            .Add("@DocCode", SqlDbType.VarChar).Value = DocCode
            .Add("@DocRef", SqlDbType.VarChar).Value = Trim(txtDocImpress.Text)
            .Add("@DateNote", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpDateNote.Value, _cultureEnInfo)
            .Add("@DateTs", SqlDbType.DateTime).Value = Date.Now
            .Add("@idPsTs", SqlDbType.Int).Value = sPsId
            .Add("@TotalSale", SqlDbType.Float).Value = CDbl(lblTotalSale.Text)
            .Add("@TotalNew", SqlDbType.Float).Value = CDbl(lblTotalNew.Text)
            .Add("@TotalDiff", SqlDbType.Float).Value = CDbl(lblTotalDiff.Text)
            .Add("@TotalNet", SqlDbType.Float).Value = CDbl(txtTotalNet.Text)
            .Add("@Note", SqlDbType.VarChar).Value = txtNote.Text
            .Add("@idPartner", SqlDbType.Int).Value = txtPartnerName.Tag
            .Add("@idComp", SqlDbType.Int).Value = cmbGroupComp.SelectedValue
            .Add("@VAT", SqlDbType.Int).Value = 0
            .Add("@NoteType", SqlDbType.Int).Value = NoteType
        End With

        xCommand.ExecuteNonQuery()
        xCommand.Parameters.Clear()

        If idNote = 0 Then
            Dim qr2 As String = "Select @@Identity"
            xCommand.CommandText = qr2

            idNote = xCommand.ExecuteScalar()
        End If

        Return idNote

    End Function

    Private Function fnAutoRunDocCode(ByVal gPrefixcode As String, ByVal xCommand As SqlCommand) As String
        Dim myAdapter As New SqlDataAdapter(xCommand)

        Dim YAndM As String = Microsoft.VisualBasic.Left(ksbDateToString(Date.Today), 6)
        Dim YAndM_Cut As String = Microsoft.VisualBasic.Right(YAndM, 4)

        Dim DocCode As String = gPrefixcode & " " & YAndM_Cut

        Dim nextOrder As String = ""

        Dim sDt As New DataTable

        xCommand.CommandText = "SELECT MAX(DocCode) as max_DocCode " & vbNewLine &
                                "FROM devsk.SmCreditDebitNoteMt " &
                                "WHERE SUBSTRING(DocCode,1,6) = '" & DocCode & "'" & vbNewLine &
                                "AND NoteType = " & NoteType
        myAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocCode")) = True Then
            DocCode = gPrefixcode & " " & YAndM_Cut & "001"
        Else
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocCode"), 3)
            Dim temp As Integer = 0

            temp = CInt(RunningCode) + 1

            If temp < 10 Then
                nextOrder = "00" & CStr(temp)
            ElseIf temp < 100 Then
                nextOrder = "0" & CStr(temp)
            Else
                nextOrder = CStr(temp)
            End If

            DocCode = gPrefixcode & YAndM_Cut & nextOrder

        End If

        Return DocCode
    End Function

    Private Sub ADDxEditSmCreditNoteDt(ByVal xCommand As SqlCommand, ByVal idNote As Integer, ByVal dr As DataRow)

        ' -------------------------------------------------------------
        ' 1. จัดการลบแถวใน dtDel ออกก่อนเป็นอันดับแรก (ไม่ว่าจะ Insert หรือ Update)
        ' -------------------------------------------------------------
        If dtDel IsNot Nothing AndAlso dtDel.Rows.Count > 0 Then
            xCommand.CommandText = "DELETE FROM SmCreditDebitNoteDt WHERE idNoteDt = @idNoteDtDel"
            xCommand.Parameters.Clear()
            xCommand.Parameters.Add("@idNoteDtDel", SqlDbType.Int)

            For Each dr1 As DataRow In dtDel.Rows
                If Not IsDBNull(dr1.Item("idNoteDt")) Then
                    xCommand.Parameters("@idNoteDtDel").Value = dr1.Item("idNoteDt")
                    xCommand.ExecuteNonQuery()
                End If
            Next

            ' เคลียร์รายการที่ลบแล้ว เพื่อไม่ให้ทำงานซ้ำในรอบถัดไป
            dtDel.Rows.Clear()
        End If

        ' Clear Parameters เตรียมพร้อมสำหรับ Insert / Update
        xCommand.Parameters.Clear()

        ' -------------------------------------------------------------
        ' 2. ตรวจสอบว่าเป็นกรณี Update หรือ Insert
        ' -------------------------------------------------------------
        Dim isUpdate As Boolean = (Process = eProcess.eEditCredit OrElse Process = eProcess.eEditDebit) _
                              AndAlso Not IsDBNull(dr.Item("idNoteDt"))

        If isUpdate Then
            ' --- UPDATE ---
            xCommand.CommandText = "UPDATE SmCreditDebitNoteDt SET " &
                               "PriceNew = @PriceNew, PriceDiff = @PriceDiff " &
                               "WHERE idNoteDt = @idNoteDt"

            xCommand.Parameters.Add("@idNoteDt", SqlDbType.Int).Value = dr.Item("idNoteDt")
        Else
            ' --- INSERT ---
            xCommand.CommandText = "INSERT INTO SmCreditDebitNoteDt (idNote, idSaleDt, idProduct, Amount, idUnit, PriceSale, PriceNew, PriceDiff) " &
                               "VALUES (@idNote, @idSaleDt, @idProduct, @Amount, @idUnit, @PriceSale, @PriceNew, @PriceDiff)"

            xCommand.Parameters.Add("@idNote", SqlDbType.Int).Value = idNote
            xCommand.Parameters.Add("@idSaleDt", SqlDbType.Int).Value = dr.Item("idSaleDt")
            xCommand.Parameters.Add("@idProduct", SqlDbType.Int).Value = dr.Item("idProduct")
        End If

        ' Parameter ที่ใช้ร่วมกันทั้ง Update และ Insert (หรือกำหนดเพิ่มตามต้องการ)
        With xCommand.Parameters
            .Add("@Amount", SqlDbType.Float).Value = dr.Item("AmtSale")
            .Add("@idUnit", SqlDbType.Int).Value = dr.Item("idUnit")
            .Add("@PriceSale", SqlDbType.Float).Value = dr.Item("PriceSale")
            .Add("@PriceNew", SqlDbType.Float).Value = dr.Item("PriceNew")
            .Add("@PriceDiff", SqlDbType.Float).Value = dr.Item("PriceDiff")
        End With

        ' บันทึกข้อมูล
        xCommand.ExecuteNonQuery()
        xCommand.Parameters.Clear()
    End Sub

    Private Sub txtDocRef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocRef.KeyPress

        Select Case Asc(e.KeyChar)
            Case 65 To 90 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 48 To 57  'A-Z
                e.Handled = False
            Case 97 To 122  'a-z
                e.Handled = False
            Case 78 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False

            Case 8 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
                chkSpaceBar = 0
            Case 32
                e.Handled = False
                chkSpaceBar = chkSpaceBar + 1
            Case 21 'F5
                e.Handled = False
            Case 10 'Enter
                e.Handled = False
                chkSpaceBar = 0
            Case Else
                'MessageBox.Show(Asc(e.KeyChar))
                e.Handled = True
                Exit Select
        End Select



        If Asc(e.KeyChar) = 32 And chkSpaceBar > 1 Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim pCondition As String = ""
        Dim dateNow As DateTime = Convert.ToDateTime(Date.Now, _cultureEnInfo)

        Dim CancelNote As String = InputBox("ระบุสาเหตุการยกเลิก", sSystemName)
        CancelNote = CancelNote.Trim()

        If CancelNote <> "" And CancelNote <> "0" And CancelNote <> "-" And CancelNote.Length > 5 Then
            pCondition = "CancelNote = '" & CancelNote & "', idPsCancel = " & sPsId & ", DateCancel = '" & dateNow.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "' "
        Else
            mdLoadCommitt()
            MessageBox.Show("กรุณาระบุสาเหตุการยกเลิกให้ชัดเจน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

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

                '**** update idpscancel in PkPORecMt *****
                mycommand.CommandText = "UPDATE devsk.SmCreditDebitNoteMt " & vbNewLine & _
                                "SET " & pCondition & vbNewLine & _
                                "WHERE idNote = " & gidNote
                mycommand.ExecuteNonQuery()


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
                                    sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Catch e2x As Exception
                    mdLoadCommitt()
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
                                    sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End Try
            Finally
                myconnection.Close()
            End Try
        End Using
        mdLoadCommitt()
    End Sub


    Private Sub txtDocRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDocRef.KeyDown
        If e.KeyCode = Keys.Enter Then
            chkSpaceBar = 0 'clear status chkSpaceBar
            btnCustomer.Visible = False

            Dim ext As String = txtDocRef.Text.Replace(" ", " ")
            Dim vWhere As String = "AND idSaleDt Not IN (0"

            If DGVBind.DataRowCount > 0 Then
                vWhere = vWhere & DGVBind.GetDataRow(0).Item("idSaleDt")

                For i As Integer = 1 To DGVBind.DataRowCount - 1
                    vWhere = vWhere & "," & DGVBind.GetDataRow(i).Item("idSaleDt")
                Next
            End If

            vWhere = vWhere & ")"

            Dim vFrm As New frmSlDataSelect(frmSlDataSelect.eProcess.eSlDataSelect, Trim(txtDocRef.Text), cmbGroupComp.SelectedValue, txtPartnerName.Tag, vWhere)

            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                'gidSale = vFrm.idSale
                For i As Integer = 0 To vFrm.dtPublic.Rows.Count - 1
                    Dim dr As DataRow = vFrm.dtPublic.Rows(i)
                    fnSetDataToDGV(dr, vFrm.DateSaleD, vFrm.idSale)
                Next
                'fnSetSlMtxDt(gidSale)
            End If
        End If
    End Sub

    Private Sub fnSetDataToDGV(ByVal dr As DataRow, ByVal DateSaleD As String, ByVal idSale As Integer)

        DGVBind.AddNewRow()

        DGVBind.SetFocusedRowCellValue("idSale", idSale)
        DGVBind.SetFocusedRowCellValue("idSaleDt", dr.Item("idSaleDt"))
        DGVBind.SetFocusedRowCellValue("DocRef", Trim(txtDocRef.Text))
        DGVBind.SetFocusedRowCellValue("DateSaleD", DateSaleD)
        DGVBind.SetFocusedRowCellValue("InvCode", dr.Item("InvCode"))
        DGVBind.SetFocusedRowCellValue("idProduct", dr.Item("idProduct"))
        DGVBind.SetFocusedRowCellValue("ProductName", dr.Item("ProductName"))
        DGVBind.SetFocusedRowCellValue("LotNo", dr.Item("LotNo"))
        DGVBind.SetFocusedRowCellValue("AmtSale", dr.Item("AmtSale"))
        DGVBind.SetFocusedRowCellValue("idUnit", dr.Item("idUnit"))
        DGVBind.SetFocusedRowCellValue("UnitName", dr.Item("UnitName"))
        DGVBind.SetFocusedRowCellValue("PriceSale", dr.Item("PriceSale"))
        DGVBind.SetFocusedRowCellValue("PriceNew", dr.Item("PriceSale"))
        DGVBind.SetFocusedRowCellValue("PriceDiff", 0)
        DGVBind.SetFocusedRowCellValue("TotalPriceDiff", 0)
        DGVBind.RefreshData()

        fnSumPriceSale()
    End Sub


    Private Sub fnSumPriceSale()
        Dim Total As Double = 0.0

        For i As Integer = 0 To DGVBind.DataRowCount - 1
            If IsDBNull(DGVBind.GetDataRow(i).Item("PriceSale")) Then
                DGVBind.GetDataRow(i).Item("PriceSale") = 0.0
            End If

            If IsDBNull(DGVBind.GetDataRow(i).Item("AmtSale")) Then
                DGVBind.GetDataRow(i).Item("AmtSale") = 0.0
            End If

            Total += DGVBind.GetDataRow(i).Item("PriceSale") * DGVBind.GetDataRow(i).Item("AmtSale")
        Next

        lblTotalSale.Text = Format(Total, "#,##0.00##")
    End Sub


    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click

        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelectAllChkSt, cmbGroupComp.SelectedValue)
        vFrm.pbPartnerName = Trim(txtPartnerName.Text)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

            Me.txtPartnerName.Tag = vFrm.idPartner
            Me.txtPartnerName.Text = vFrm.CusName

            txtDocRef.Enabled = True

        End If
    End Sub

    Private Sub txtPartnerName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPartnerName.KeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F5) And Trim(txtPartnerName.Text) = "" Then
            Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelectAllChkSt, cmbGroupComp.SelectedValue)
            vFrm.pbPartnerName = Trim(txtPartnerName.Text)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

                Me.txtPartnerName.Tag = vFrm.idPartner
                Me.txtPartnerName.Text = vFrm.CusName

                idCus = vFrm.idCus

                txtDocRef.Enabled = True
                fnSearchPsSale()
            End If
        ElseIf (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F5) And Trim(txtPartnerName.Text) <> "" Then

            dtMain.Clear()
            GCSale.DataSource = dtMain

            Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelectAllChkSt, cmbGroupComp.SelectedValue)
            vFrm.pbPartnerName = Trim(txtPartnerName.Text)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

                Me.txtPartnerName.Tag = vFrm.idPartner
                Me.txtPartnerName.Text = vFrm.CusName

                idCus = vFrm.idCus
                txtDocRef.Enabled = True
                fnSearchPsSale()
            End If

        End If

    End Sub

    Private Sub fnSearchPsSale()
        mdConnectDbSPM()
        'mdCnOpen()
        Dim dt As New DataTable

        sCommand.CommandText = "Select m.idPs, p.PsName, m.idPM " & vbNewLine & _
                                "From SmMkCusPs m " & vbNewLine & _
                                "LEFT OUTER JOIN devsk.vPersonxSelect p ON m.idPs = p.idPs " & _
                                "Where m.idComp = " & cmbGroupComp.SelectedValue & " AND m.idCus = " & idCus & ""
        sAdapter.Fill(dt)

        Me.lblPsSale.Text = dt.Rows(0).Item("PsName")
        Me.lblPsSale.Tag = dt.Rows(0).Item("idPs")
    End Sub


    Private Sub rptDel_Click(sender As Object, e As EventArgs) Handles rptDel.Click
        If DGVBind.FocusedRowHandle >= 0 Then
            If lbrMsg.MsgQuestion("คุณต้องการลบรายการใช่หรือไม่?") = True Then
                Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)
                If Not IsDBNull(dr("idNoteDt")) Then
                    Dim drtemp As DataRow = dtDel.NewRow()
                    drtemp("idNoteDt") = dr("idNoteDt")
                    dtDel.Rows.Add(drtemp)
                End If
                dr.Delete()

                dtMain.AcceptChanges()
                fnSumPriceSale()
                SumTotalNew()
            End If
        End If
    End Sub

    Private Sub rptPriceNew_Click(sender As Object, e As EventArgs) Handles rptPriceNew.Click
        If DGVBind.FocusedRowHandle < 0 Then
            rptPriceNew.ReadOnly = True
        Else
            rptPriceNew.ReadOnly = False
        End If
    End Sub

    Private Sub txtDocImpress_Leave(sender As Object, e As EventArgs) Handles txtDocImpress.Leave
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
                Dim vWHERE As String = ""
                If Process = eProcess.eEditCredit Or Process = eProcess.eEditDebit Then 'EditData
                    vWHERE = " AND idNote <> " & gidNote & ""
                End If

                If Process <> eProcess.eViewCredit And Process <> eProcess.eCancelCredit And Process <> eProcess.eViewDebit And Process <> eProcess.eCancelDebit Then  'view/Accept/Check/Approve
                    fnChkDocCodeDup(mycommand, vWHERE)

                End If
            Catch

            End Try
        End Using

    End Sub

    Private Sub btnPdInc_Click(sender As Object, e As EventArgs) Handles btnPdInc.Click
        If Me.txtPartnerName.Text = "" Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim vFrm As New frmAllInvSelect(frmAllInvSelect.eProcess.eAll, cmbGroupComp.SelectedValue)

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            DGVBind.AddNewRow()

            DGVBind.SetFocusedRowCellValue("PdCode", vFrm.sdt1.Rows(0).Item("InvCode"))
            DGVBind.SetFocusedRowCellValue("ProductName", vFrm.sdt1.Rows(0).Item("InvName"))

            DGVBind.SetFocusedRowCellValue("idSale", 0)
            DGVBind.SetFocusedRowCellValue("idSaleDt", 0)
            DGVBind.SetFocusedRowCellValue("DocRef", "")
            DGVBind.SetFocusedRowCellValue("DateSaleD", DBNull.Value)
            DGVBind.SetFocusedRowCellValue("InvCode", vFrm.sdt1.Rows(0).Item("InvCode"))
            DGVBind.SetFocusedRowCellValue("idProduct", vFrm.sdt1.Rows(0).Item("idInvMain"))
            DGVBind.SetFocusedRowCellValue("ProductName", vFrm.sdt1.Rows(0).Item("InvName"))
            DGVBind.SetFocusedRowCellValue("LotNo", "")
            DGVBind.SetFocusedRowCellValue("AmtSale", 0)
            DGVBind.SetFocusedRowCellValue("idUnit", vFrm.sdt1.Rows(0).Item("idUnit"))
            DGVBind.SetFocusedRowCellValue("UnitName", vFrm.sdt1.Rows(0).Item("UnitName"))
            DGVBind.SetFocusedRowCellValue("PriceSale", 0)
            DGVBind.SetFocusedRowCellValue("PriceNew", 0)
            DGVBind.SetFocusedRowCellValue("PriceDiff", 0)
            DGVBind.SetFocusedRowCellValue("TotalPriceDiff", 0)
            DGVBind.RefreshData()

            fnSumPriceSale()

        End If
    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            mdConnectDbSPM()
            cmbDRefCode()
        End If
    End Sub
End Class