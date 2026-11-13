Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid

Public Class frmSlBnTs
    Dim Result As DialogResult
    Dim MainDt As New DataTable
    Dim idBill_ As Integer = 0
    Dim eEvent As eProcess
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")

    Enum eProcess
        eNewBill
        eviewData
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idBill As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If aProcess = eProcess.eviewData Then
            idBill_ = idBill
        End If

        eEvent = aProcess
    End Sub

    Private Sub frmSlBnTs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        mdCnOpen()
        Me.lblDateTs.Text = Date.Today
        Me.lblPsTs.Text = sPsName
        Me.lblPsTs.Tag = sPsId

        MainDt.Columns.Add("idSale", System.Type.GetType("System.Int32"))
        MainDt.Columns.Add("DocRef", System.Type.GetType("System.String"))
        MainDt.Columns.Add("DateSaleD", System.Type.GetType("System.DateTime"))
        MainDt.Columns.Add("PaymentTerms", System.Type.GetType("System.String"))
        MainDt.Columns.Add("PsSale", System.Type.GetType("System.String"))
        MainDt.Columns.Add("Debt", System.Type.GetType("System.Double"))
        MainDt.Columns.Add("Note", System.Type.GetType("System.String"))

        If eEvent = eProcess.eNewBill Then 'New
            Dim vFrm As New frmCusDebtList(frmCusDebtList.eProcess.eSelectBn)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

                Me.lblCustomer.Tag = vFrm.idPsCus
                Me.lblCustomer.Text = vFrm.PsCusName + " / " + Format(vFrm.DebtCus, "#,##0.00").ToString
                Me.lblCompName.Text = vFrm.CompNameTs
                Me.lblCompName.Tag = vFrm.idCompTs

                If vFrm.pidSale = 0 Then 'Retrun from tab i : Customer case
                    '----Select All Bill Of Customer Select-----'
                    Dim sDt As New DataTable
                    sCommand.CommandText = "Select mt.idSale, mt.DocRef, mt.DateSaleD, pm.PaymentTerms, p.PsName As PsSale,  " & vbNewLine & _
                                           "(ISNULL(mt.TotalNet,0) - ISNULL(mt.TotalPay,0)) As AmtDebt, mt.Note " & vbNewLine & _
                                           "From SmSaleMt mt " & vbNewLine & _
                                           "LEFT JOIN SmPaymentTermsD pm ON mt.idPm = pm.idPM" & vbNewLine & _
                                           "LEFT JOIN vPersonxSelect p ON mt.idPsSale = p.idPs " & vbNewLine & _
                                           "Where mt.idComp = " & Me.lblCompName.Tag & vbNewLine & _
                                           "AND Year(mt.DateSaleD)  >= 2019  " & vbNewLine & _
                                           "AND mt.idPM NOT IN (53, 57)  " & vbNewLine & _
                                           "AND mt.idSaleCode NOT IN (1,18) " & vbNewLine & _
                                           "AND mt.idPsCancel Is NULL" & vbNewLine & _
                                           "AND mt.stpay <> '1' AND ((ISNULL(mt.TotalNet,0) - ISNULL(mt.TotalPay,0)) > 0) " & vbNewLine & _
                                           "AND idCus = " & vFrm.idPsCus
                    sAdapter.Fill(sDt)
                    For i As Integer = 0 To sDt.Rows.Count - 1
                        MainDt.Rows.Add(sDt.Rows(i).Item("idSale"), sDt.Rows(i).Item("DocRef"), sDt.Rows(i).Item("DateSaleD"), _
                                       sDt.Rows(i).Item("PaymentTerms"), sDt.Rows(i).Item("PsSale"), _
                                       sDt.Rows(i).Item("AmtDebt"), sDt.Rows(i).Item("Note"))
                    Next

                Else 'Return from tab ii : Sale-Bill case
                    MainDt.Rows.Add(vFrm.pidSale, vFrm.pDocRef, vFrm.pDateSaleD, vFrm.pPayment, vFrm.pPsSale, vFrm.DebtCus, vFrm.pNote)
                End If

                gc2.DataSource = MainDt
                SumTotal()
            Else
                Me.Close()
            End If


        ElseIf eEvent = eProcess.eviewData Then 'ViewData
            Me.Text = "รายละเอียดรายการออกใบวางบิล"
            ColDelete.Visible = False

            '*****Show data from SmSaleBnMt******'
            Dim vDt As New DataTable
            vDt.Clear()
            sCommand.CommandText = "SELECT c.CusName_, mt.DateDocD, mt.Note, FORMAT (mt.DateTsD, 'd', 'th') As DateSale, mt.idPsTs, " & vbNewLine & _
                                   "p1.PsName As PsTs, mt.Total, mt.idComp, com.CompName  " & vbNewLine & _
                                   "FROM SmSaleBnMt mt  " & vbNewLine & _
                                   "LEFT OUTER JOIN vPersonxSelect p1 ON mt.idPsTs = p1.idPs " & vbNewLine & _
                                   "LEFT OUTER JOIN vCustomer c ON mt.idCus = c.idCus" & vbNewLine & _
                                   "LEFT OUTER JOIN PchInvAndProject.dbo.dCompany com ON mt.idComp = com.idComp " & vbNewLine & _
                                   "WHERE idBn = '" & idBill_ & "'"
            sAdapter.Fill(vDt)

            Me.lblCompName.Text = vDt.Rows(0).Item("CusName_")
            Me.lblCustomer.Text = vDt.Rows(0).Item("CompName")
            Me.lblCustomer.Tag = vDt.Rows(0).Item("idComp")
            Me.dtpDateBill.Value = vDt.Rows(0).Item("DateDocD")
            Me.txtNote.Text = vDt.Rows(0).Item("Note")
            Me.txtNote.Enabled = False
            Me.lblDateTs.Text = vDt.Rows(0).Item("DateSale")
            Me.lblPsTs.Text = vDt.Rows(0).Item("PsTs")
            Me.lblPsTs.Tag = vDt.Rows(0).Item("idPsTs")
            Me.txtTotal.Text = Format(vDt.Rows(0).Item("Total"), "#,##0")

            '*****Show data from SmSaleBnDt + vSmSaleMt ******'
            Dim sDt2 As New DataTable
            sDt2.Clear()
            sCommand.CommandText = "SELECT dt.idSale, sl.DocRef, FORMAT (sl.DateSaleD, 'd', 'th') As DateSaleD , pm.PaymentTerms, " & vbNewLine & _
                                   "p.PsName As PsSale, dt.Amount As Debt, sl.Note  " & vbNewLine & _
                                   "FROM SmSaleBnDt dt " & vbNewLine & _
                                   "LEFT JOIN SmSaleMt sl ON dt.idSale = sl.idSale " & vbNewLine & _
                                   "LEFT JOIN SmPaymentTermsD pm ON sl.idPm = pm.idPM " & vbNewLine & _
                                   "LEFT JOIN vPersonxSelect p ON sl.idPsSale = p.idPs " & vbNewLine & _
                                   "WHERE dt.idBn = " & idBill_
            sAdapter.Fill(sDt2)

            For i As Integer = 0 To sDt2.Rows.Count - 1
                MainDt.Rows.Add(sDt2.Rows(i).Item("idSale"), sDt2.Rows(i).Item("DocRef"), sDt2.Rows(i).Item("DateSaleD"), _
                               sDt2.Rows(i).Item("PaymentTerms"), sDt2.Rows(i).Item("PsSale"), _
                               sDt2.Rows(i).Item("Debt"), sDt2.Rows(i).Item("Note"))
            Next

            gc2.DataSource = MainDt
            SumTotal()

            'sDt2.Columns.Add("Num", System.Type.GetType("System.String"))
            'For i As Integer = 0 To sDt2.Rows.Count - 1
            '    sDt2.Rows(i).Item("Num") = i + 1
            'Next
            'dgvBill.DataSource = sDt2
            'dgvBill.Columns("ColDel").Visible = False

            Me.btnSave.Visible = False
            Me.btnSelect.Visible = False

        End If
        mdLoadCommitt()
    End Sub

    'Private Sub lbDebt_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '    Dim dt As New DataTable
    '    Dim idCus As String = ""
    '    Dim Cusname As String = ""
    '    Dim vFrm As New frmSlSaleDebt(frmSlSaleDebt.eProcess.eViewBn, dt, idCus, Cusname)
    '    vFrm.Show()
    'End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If Me.lblCustomer.Text = "" Then
            MessageBox.Show("กรุณาเลือกลูกค้าที่ต้องการออกใบวางบิล ก่อนเลือกรายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else

            Dim ChkidSale As New DataTable
            ChkidSale.Columns.Add("idSale", System.Type.GetType("System.Int32"))

            For i As Integer = 0 To MainDt.Rows.Count - 1
                ChkidSale.Rows.Add()
                ChkidSale.Rows(i).Item("idSale") = MainDt.Rows(i).Item("idSale")
            Next


            Dim vFrm As New frmSlSaleDebt(frmSlSaleDebt.eProcess.eSelectBn, ChkidSale, Me.lblCustomer.Tag, Me.lblCustomer.Text, _
                                          lblCompName.Tag, lblCompName.Text)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                For i As Integer = 0 To vFrm.idSaleDt.Rows.Count - 1

                    MainDt.Rows.Add(vFrm.idSaleDt.Rows(i).Item("idSale"), vFrm.idSaleDt.Rows(i).Item("DocRef"), vFrm.idSaleDt.Rows(i).Item("DateSaleD"), _
                                    vFrm.idSaleDt.Rows(i).Item("PaymentTerms"), vFrm.idSaleDt.Rows(i).Item("PsSale"), _
                                    vFrm.idSaleDt.Rows(i).Item("AmtDebt"), vFrm.idSaleDt.Rows(i).Item("Note"))
                Next
                SumTotal()
            End If
        End If
    End Sub

    'Delete
    Private Sub rptbtnDel_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptbtnDel.ButtonClick
        Result = MsgBox("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
        If Result = Windows.Forms.DialogResult.Yes Then
            Dim dr As DataRow = gv2.GetDataRow(gv2.FocusedRowHandle)
            dr.Delete()
        End If
        SumTotal()
    End Sub

    Sub SumTotal()
        Dim TotalNet As Double = 0.0
        For i As Integer = 0 To gv2.DataRowCount - 1
            TotalNet = TotalNet + gv2.GetDataRow(i).Item("Debt")
        Next
        txtTotal.Text = Format(TotalNet, "#,##0.00")
    End Sub

    Private Sub gv2_CustomDrawCell(sender As Object, e As Views.Base.RowCellCustomDrawEventArgs) Handles gv2.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If gv2.RowCount = 0 Then
            MessageBox.Show("กรุณาเลือกรายการบิลขายอย่างน้อย 1 รายการ เพื่อทำรายการออกใบวางบิล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Dim result As DialogResult
            result = MessageBox.Show("ต้องการบันทึกข้อมูลนี้ใช่หรือไม่?", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                '----insert---'
                mdCnOpen()
                Dim idBN As Integer = AddSmSaleBnMt()
                AddSmSaleBnDt(idBN)

                SplashScreenManager.CloseForm(False)
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    '-------------------- GEN DocCode --------------------'
    Function getDocCode(ByVal Prefixcode As String) As String
        Dim DocCode As String = ""
        Dim nextOrder As String = ""
        Dim CodeYear As String = ""

        ' mdCnOpen()
        Dim sDt As New DataTable
        sDs.Tables.Clear()
        sCommand.CommandText = "SELECT MAX(DocCode) AS max_DocCode, MAX(SUBSTRING(DocCode, 3, 2)) AS year_docCode " & vbNewLine & _
                               "FROM SmSaleBnMt " & vbNewLine & _
                               "WHERE idComp = " & Me.lblCompName.Tag
        sAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("year_docCode")) = True Then
            DocCode = Prefixcode & "-" & "00001"
        Else
            CodeYear = "BN" & sDt.Rows(0).Item("year_docCode")
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocCode"), 5)

            If IsDBNull(sDt.Rows(0).Item("max_DocCode")) = True Then
                DocCode = Prefixcode & "-" & "00001"
            ElseIf Prefixcode <> CodeYear Then
                DocCode = Prefixcode & "-" & "00001"
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
                DocCode = Prefixcode & "-" & nextOrder
            End If
        End If
        Return DocCode
    End Function

    Function AddSmSaleBnMt() As Integer
        '---insert SmSaleBnMt Table---'
        Dim DocCode As String = ""
        Dim getDate As String = CType(Date.Today, String)
        Dim Prefixcode As String = ""

        Prefixcode = "BN" & (Microsoft.VisualBasic.Right(getDate, 2))
        DocCode = getDocCode(Prefixcode)

        Dim dtpDateBill_ As DateTime = Convert.ToDateTime(dtpDateBill.Value, _cultureEnInfo)

        sCommand.CommandText = "Insert Into SmSaleBnMt(DocCode, DateDocD, DateTsD, idCus, Note, idPsTs, Total, idComp) " & _
                                "Values('" & DocCode & "', '" & dtpDateBill_.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "', " & _
                                " GETDATE(), " & Me.lblCustomer.Tag & ", '" & Trim(txtNote.Text) & "', " & _
                                "" & sPsId & ", '" & CDbl(txtTotal.Text) & "', " & lblCompName.Tag & ")"

        '' sCommand.CommandText = "Delete From SmSaleMt"
        Dim query2 As String = "Select @@Identity"
        sCommand.ExecuteNonQuery()
        sCommand.CommandText = query2
        Dim idBN As Integer = sCommand.ExecuteScalar()

        Return idBN
    End Function

    Sub AddSmSaleBnDt(ByVal idBN As Integer)
        For i As Integer = 0 To MainDt.Rows.Count - 1
            '---insert SmSaleBnDt Table---'
            sCommand.CommandText = "Insert Into SmSaleBnDt(idBN, idSale, Amount) Values(" & idBN & ", " & _
                                   "" & MainDt.Rows(i).Item("idSale") & ", " & MainDt.Rows(i).Item("Debt") & ") "
            sCommand.ExecuteNonQuery()

            '---Update SmSaleMt Table---'
            sCommand.CommandText = "Update SmSaleMt Set idBN =" & idBN & " WHERE idSale = " & MainDt.Rows(i).Item("idSale") & ""
            sCommand.ExecuteNonQuery()
        Next
    End Sub

    'Private Sub btnFCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim vFrm As New frmCusDebtList(frmCusDebtList.eProcess.eSelectBn)

    '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        Me.dgvBill.Rows.Clear()
    '        Me.lblCustomer.Tag = vFrm.idPsCus
    '        Me.lblCustomer.Text = vFrm.PsCusName + " / " + Format(vFrm.DebtCus, "#,##0.00").ToString

    '        dgvBill.Rows.Clear()
    '        Dim vWHERE As String = ""
    '        If vFrm.idSale <> Nothing Then
    '            vWHERE = " AND idSale = " & vFrm.idSale & ""
    '        End If

    '        '----Select All Bill Of Customer Select-----'
    '        Dim sDt As New DataTable
    '        mdCnOpen()
    '        'sCommand.CommandText = "Select idSale, DocCode, DateSale, PaymentTerms, Transport, " & _
    '        '                       "PsSale, PsSet, PsSent, PsTs, TotalNet, TotalPay, Note " & _
    '        '                       "From vSmSaleMt Where idCus = '" & vFrm.idPsCus & "' " & vWHERE


    '        sCommand.CommandText = "SELECT mt.idSale, mt.DocCode, mt.DateSaleD, pm.PaymentTerms, p.PsName As PsSale, p2.PsName As PsTs, (mt.TotalNet - mt.TotalPay) As AmtDebt" & vbNewLine & _
    '                                "FROM SmSaleMt As mt" & vbNewLine & _
    '                                "LEFT JOIN SmPaymentTermsD pm ON mt.idPm = pm.idPM" & vbNewLine & _
    '                                "LEFT JOIN vPersonxSelect p ON mt.idPsSale = p.idPs " & vbNewLine & _
    '                                "LEFT JOIN vPersonxSelect p2 ON mt.idPsTs = p.idPs" & vbNewLine & _
    '                                "WHERE idCus =" & vFrm.idPsCus & "' " & vWHERE
    '        sAdapter.Fill(sDt)

    '        For i As Integer = 0 To sDt.Rows.Count - 1

    '            dgvBill.Rows.Add("", sDt.Rows(i).Item("idSale"), sDt.Rows(i).Item("DocCode"), sDt.Rows(i).Item("DateSaleD"), _
    '                           sDt.Rows(i).Item("PaymentTerms"), sDt.Rows(i).Item("PsSale"), _
    '                           sDt.Rows(i).Item("PsTs"), sDt.Rows(i).Item("AmtDebt"), sDt.Rows(i).Item("Note"))
    '        Next


    '        SumTotal()
    '    End If
    'End Sub


End Class