'Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid
Public Class frmDebtBalDataAllCus
    Dim stLoad As Integer = 0
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim _cultureTHInfo As New Globalization.CultureInfo("th-TH")
    Private Sub frmDebtBalDataAllCus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpSaleS.Value = Date.Today
        dtpSaleE.Value = Date.Today
        dtpMonthS.Value = Date.Today
        dtpMonthE.Value = Date.Today
        dtpYear.Value = Date.Today
        dtpMonthNow.Value = Date.Today
        dtpMonthNow.Format = DateTimePickerFormat.Custom
        dtpMonthNow.CustomFormat = "MMMMyyyy"

        mdLoadShow()
        setCmbGroupComp(cmbGroupComp)
        Dim dt As DataTable = BindData()
        dt.Columns.Add("CollectBal", System.Type.GetType("System.Double"))
        GCData.DataSource = dt
        If GvShowData.DataRowCount > 1 Then
            GvShowData.SetRowCellValue(0, "CollectBal", GvShowData.GetDataRow(0).Item("Bal"))

            For i As Integer = 1 To GvShowData.DataRowCount - 1
                GvShowData.SetRowCellValue(i, "CollectBal", GvShowData.GetDataRow(i - 1).Item("CollectBal") + GvShowData.GetDataRow(i).Item("Bal"))
            Next

            GCData.Refresh()
            GvShowData.ExpandAllGroups()
            Dim TotalNet As Double = 0.0
            For i As Integer = 0 To GvShowData.DataRowCount - 1
                TotalNet = TotalNet + GvShowData.GetDataRow(i).Item("Bal")
            Next
            txtTotalNet.Text = Format(TotalNet, "#,##0.00")
        End If
        stLoad = 1
        mdLoadCommitt()
    End Sub

    'Sub BindData()
    '    mdCnOpen()
    '    sDt.Clear()

    '    Dim vField As String = "DateSaleD"
    '    Dim vWhere As String = "Where 1 = 1"

    '    If Me.rdbDate.Checked = True Then
    '        Dim firstDate As DateTime = Convert.ToDateTime(dtpSaleS.Value, _cultureEnInfo)
    '        Dim lastDate As DateTime = Convert.ToDateTime(dtpSaleE.Value, _cultureEnInfo)
    '        vWhere = vWhere & " AND " & vField & " Between '" & firstDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " &
    '                          "And '" & lastDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' "

    '    ElseIf Me.rdbMonth.Checked = True Then

    '        Dim sDateS As DateTime = Convert.ToDateTime(dtpMonthS.Value, _cultureEnInfo)
    '        Dim sMonthS As Integer = sDateS.Month
    '        Dim sYearS As Integer = sDateS.Year
    '        Dim sDateE As DateTime = Convert.ToDateTime(dtpMonthE.Value, _cultureEnInfo)
    '        Dim sMonthE As Integer = sDateE.Month
    '        Dim sYearE As Integer = sDateE.Year

    '        vWhere = vWhere & " AND year(" & vField & ") * 100 + month(" & vField & ") " &
    '                          "BETWEEN " & sYearS & " * 100 + " & sMonthS & " AND " & sYearE & " * 100 + " & sMonthE & ""

    '    ElseIf Me.rdbYear.Checked = True Then

    '        Dim sDateY As DateTime = Convert.ToDateTime(dtpYear.Value, _cultureEnInfo)
    '        Dim sYearY As Integer = sDateY.Year
    '        vWhere = vWhere & " AND YEAR(" & vField & ") = " & sYearY

    '    ElseIf Me.rdbMonthNow.Checked = True Then

    '        Dim sDateMN As DateTime = Convert.ToDateTime(dtpMonthNow.Value, _cultureEnInfo)
    '        Dim sMonthMN As Integer = sDateMN.Month
    '        Dim sYearMN As Integer = sDateMN.Year
    '        vWhere = vWhere & " AND Month(" & vField & ") = " & sMonthMN & " AND YEAR(" & vField & ") = " & sYearMN
    '    End If

    '    If cbPartner.Checked = True And lblPartnerName.Tag IsNot Nothing Then
    '        vWhere = vWhere & " AND idPartner = " & lblPartnerName.Tag
    '    End If

    '    If cbPsSale.Checked = True And lblPsSale.Tag IsNot Nothing Then
    '        vWhere = vWhere & " AND idPsSale = " & lblPsSale.Tag
    '    End If

    '    sCommand.CommandText = "With A As(SELECT 1 As typ, mt.idPartner, cus.CusCode + ' - ' + p.PartNerName As PartnerName, mt.idPsSale, idSale, DateSaleD, DocRef, devsk.convertStrToDate(DatePay) As DatePay," & vbNewLine &
    '                           "TotalNet, TotalPay, (TotalNet - ISNULL(TotalPay, 0)) As Bal, mt.idComp" & vbNewLine &
    '                           "From SmSaleMt mt" & vbNewLine &
    '                           "LEFT JOIN dPartner p ON mt.idPartner = p.idPartner" & vbNewLine &
    '                           "LEFT JOIN dCustomer cus ON p.idCus = cus.idCus" & vbNewLine &
    '                           "WHERE mt.idComp = " & cmbGroupComp.SelectedValue & " " & vbNewLine &
    '                           "AND idPsCancel Is NULL " & vbNewLine &
    '                           "AND TotalNet <> TotalPay " & vbNewLine &
    '                           "AND idSaleCode Not IN (1,18) " & vbNewLine &
    '                           "UNION" & vbNewLine &
    '                            "SELECT 2 As typ, rMt.idPartner, cus.CusCode + ' - ' + p.PartNerName As PartnerName, rMt.idPsSale, rMt.idSaleReturn, DateReturnD As DateReturn,code.ReturnCode + ' ' + rMt.DocRef As DocRef," & vbNewLine &
    '                              "DateReturnD As DatePay, -(rMt.Total) As Total, 0 As TotalPay, -(rMt.Total) As Bal, rMt.idComp" & vbNewLine &
    '                              "FROM SmSaleReturnMt rMt " & vbNewLine &
    '                              "LEFT JOIN dPartner p ON rMt.idPartner = p.idPartner" & vbNewLine &
    '                              "LEFT JOIN dCustomer cus ON p.idCus = cus.idCus" & vbNewLine &
    '                              "LEFT JOIN SmSaleReturnCode code ON rMt.idRTDocCode = code.idRTDocCode" & vbNewLine &
    '                              "Where rMt.idSaleReturn not IN (SELECT idSaleReturn " & vbNewLine &
    '                                                          "FROM SmSalePayDt dt" & vbNewLine &
    '                                                          "LEFT JOIN SmSalePayMt mt ON dt.idSalePay = mt.idSalePay" & vbNewLine &
    '                                                          "Where idSaleReturn Is Not NULL" & vbNewLine &
    '                                                          "AND mt.idPsCancel IS NULL)" & vbNewLine &
    '                              "And rMt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
    '                              "AND rMt.idPsCancel Is NULL) " & vbNewLine &
    '                              "SELECT p.PsName As PsSaleName, *" & vbNewLine &
    '                              "FROM A" & vbNewLine &
    '                              "LEFT JOIN vPersonxSelect p ON A.idPsSale = p.idPs" & vbNewLine &
    '                              vWhere & vbNewLine &
    '                              "Order by typ ASC, DateSaleD"

    '    sAdapter.Fill(sDt)


    '    GCData.DataSource = sDt

    '    If sDt.Rows.Count = 0 Then
    '        SplashScreenManager.CloseForm(False)
    '        MessageBox.Show("ไม่พบข้อมูลยอดหนี้คงเหลือ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Exit Sub
    '    End If

    'End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        mdLoadShow()
        Dim dt As DataTable = BindData()
        dt.Columns.Add("CollectBal", System.Type.GetType("System.Double"))

        GCData.DataSource = dt

        mdLoadCommitt()
        If GvShowData.DataRowCount > 1 Then
            GvShowData.SetRowCellValue(0, "CollectBal", GvShowData.GetDataRow(0).Item("Bal"))

            For i As Integer = 1 To GvShowData.DataRowCount - 1
                GvShowData.SetRowCellValue(i, "CollectBal", GvShowData.GetDataRow(i - 1).Item("CollectBal") + GvShowData.GetDataRow(i).Item("Bal"))
            Next

            GCData.Refresh()
            GvShowData.ExpandAllGroups()

            Dim TotalNet As Double = 0.0
            For i As Integer = 0 To GvShowData.DataRowCount - 1
                TotalNet = TotalNet + GvShowData.GetDataRow(i).Item("Bal")
            Next
            txtTotalNet.Text = Format(TotalNet, "#,##0.00")
        End If

        'SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub GvShowData_CustomDrawCell(sender As Object, e As Views.Base.RowCellCustomDrawEventArgs) Handles GvShowData.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub rdbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDate.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbDate.Checked = True Then
                Me.dtpSaleS.Enabled = True
                Me.dtpSaleE.Enabled = True
            Else
                Me.dtpSaleS.Enabled = False
                Me.dtpSaleE.Enabled = False
            End If

            GCData.DataSource = Nothing
            btnDebtBalRpt.Enabled = False
            txtTotalNet.Text = Format(0, "#,##0.00")

        End If
    End Sub

    Private Sub rdbYear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbYear.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbYear.Checked = True Then
                Me.dtpYear.Enabled = True
            Else
                Me.dtpYear.Enabled = False
            End If

            GCData.DataSource = Nothing
            btnDebtBalRpt.Enabled = False
            txtTotalNet.Text = Format(0, "#,##0.00")
        End If
    End Sub

    Private Sub rdbMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMonth.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbMonth.Checked = True Then
                Me.dtpMonthS.Enabled = True
                Me.dtpMonthE.Enabled = True
            Else
                Me.dtpMonthS.Enabled = False
                Me.dtpMonthE.Enabled = False
            End If

            GCData.DataSource = Nothing
            btnDebtBalRpt.Enabled = False
            txtTotalNet.Text = Format(0, "#,##0.00")
        End If
    End Sub

    Private Sub rdbMonthNow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMonthNow.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbMonthNow.Checked = True Then
                Me.dtpMonthNow.Enabled = True
            Else
                Me.dtpMonthNow.Enabled = False
            End If

            GCData.DataSource = Nothing
            btnDebtBalRpt.Enabled = False
            txtTotalNet.Text = Format(0, "#,##0.00")
        End If
    End Sub

    Private Sub btnPartner_Click(sender As Object, e As EventArgs) Handles btnPartner.Click
        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelect, cmbGroupComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblPartnerName.Tag = vFrm.idPartner
            lblPartnerName.Text = vFrm.CusName

            GCData.DataSource = Nothing
            btnDebtBalRpt.Enabled = False
            txtTotalNet.Text = Format(0, "#,##0.00")
        End If
    End Sub

    Private Sub cbPartner_CheckedChanged(sender As Object, e As EventArgs) Handles cbPartner.CheckedChanged
        If stLoad = 1 Then
            If cbPartner.Checked = True Then
                btnPartner.Enabled = True
            Else
                lblPartnerName.Text = ""
                lblPartnerName.Tag = Nothing
                btnPartner.Enabled = False

                GCData.DataSource = Nothing
                btnDebtBalRpt.Enabled = False
            End If
        End If
    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            GCData.DataSource = Nothing
            btnDebtBalRpt.Enabled = False
            txtTotalNet.Text = Format(0, "#,##0.00")
        End If
    End Sub

    Private Sub btnPsSale_Click(sender As Object, e As EventArgs) Handles btnPsSale.Click
        Dim vFrm As New frmPsSaleSelect(frmPsSaleSelect.eProcess.eNormal, Nothing, "", 0, 1, cmbGroupComp.SelectedValue)

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblPsSale.Tag = vFrm.idPs
            lblPsSale.Text = vFrm.SaleName

            GCData.DataSource = Nothing
            btnDebtBalRpt.Enabled = False
            txtTotalNet.Text = Format(0, "#,##0.00")
        End If
    End Sub

    Private Sub cbPsSale_CheckedChanged(sender As Object, e As EventArgs) Handles cbPsSale.CheckedChanged
        If stLoad = 1 Then
            If cbPsSale.Checked = True Then
                btnPsSale.Enabled = True
            Else
                lblPsSale.Text = ""
                lblPsSale.Tag = Nothing
                btnPartner.Enabled = False

                GCData.DataSource = Nothing
                btnDebtBalRpt.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnDebtBalRpt_Click(sender As Object, e As EventArgs) Handles btnDebtBalRpt.Click
        'SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        mdLoadShow()
        Dim DebtBalDt As DataTable = DirectCast(GvShowData.DataSource, DataView).ToTable
        'Dim DebtBalDt As New DataTable

        'DebtBalDt = BindData()

        'DebtBalDt.Columns.Add("CollectBal", System.Type.GetType("System.Double"))

        'DebtBalDt.Rows(0).Item("CollectBal") = GvShowData.GetDataRow(0).Item("Bal")

        'For i As Integer = 1 To GvShowData.DataRowCount
        '    DebtBalDt.Rows(i - 1).Item("CollectBal") = GvShowData.GetDataRow(i - 1).Item("CollectBal") + GvShowData.GetDataRow(i).Item("Bal")
        'Next

        Dim strDateofBill As String = ""
        Dim strPsSaleName As String = ""
        If rdbDate.Checked = True Then
            Dim DateThaiS As DateTime = Convert.ToDateTime(dtpSaleS.Value, _cultureTHInfo)
            Dim DateThaiE As DateTime = Convert.ToDateTime(dtpSaleE.Value, _cultureTHInfo)
            strDateofBill = "ประจำวันที่ " & DateThaiS & " ถึง " & DateThaiE
        ElseIf rdbMonth.Checked = True Then
            Dim YDateThaiS As Integer = dtpMonthS.Value.Year + 543
            Dim YDateThaiE As Integer = dtpMonthE.Value.Year + 543
            strDateofBill = "ประจำเดือน " & dtpMonthS.Value.Month & "/" & YDateThaiS & " ถึง " & dtpMonthE.Value.Month & "/" & YDateThaiE
        ElseIf rdbMonthNow.Checked = True Then
            Dim YDateThaiNow As Integer = dtpMonthNow.Value.Year + 543
            strDateofBill = "ประจำเดือน " & dtpMonthNow.Value.Month & "/" & YDateThaiNow
        ElseIf rdbYear.Checked = True Then
            Dim YDateThai As Integer = dtpYear.Value.Year + 543
            strDateofBill = "ประจำปี " & YDateThai
        End If

        If cbPsSale.Checked = True And lblPsSale.Tag IsNot Nothing Then
            strPsSaleName = "พนง.ขาย " & lblPsSale.Text.Trim
        End If

        Dim vFrm As New FrmReportView
        Dim vRpt As New crpDebtBalAllCus
        vRpt.SetDataSource(DebtBalDt)
        vRpt.SetParameterValue(vRpt.Parameter_ptCompName.ParameterFieldName, cmbGroupComp.Text.Trim)
        vRpt.SetParameterValue(vRpt.Parameter_ptDateOfBill.ParameterFieldName, strDateofBill)
        vRpt.SetParameterValue(vRpt.Parameter_PsSaleName.ParameterFieldName, strPsSaleName)
        vFrm.crView.ReportSource = vRpt

        mdLoadCommitt()
        'SplashScreenManager.CloseForm(False)
        vFrm.Show()

    End Sub

    Private Function BindData() As DataTable
        Dim dtBalAllCus As New DataTable

        Dim vField As String = "DateSaleD"
        Dim vWhere As String = "Where 1 = 1"

        If chkDateSale.Checked = True Then
            If Me.rdbDate.Checked = True Then
                Dim firstDate As DateTime = Convert.ToDateTime(dtpSaleS.Value, _cultureEnInfo)
                Dim lastDate As DateTime = Convert.ToDateTime(dtpSaleE.Value, _cultureEnInfo)
                vWhere = vWhere & " AND " & vField & " Between '" & firstDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " &
                                  "And '" & lastDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' "

            ElseIf Me.rdbMonth.Checked = True Then

                Dim sDateS As DateTime = Convert.ToDateTime(dtpMonthS.Value, _cultureEnInfo)
                Dim sMonthS As Integer = sDateS.Month
                Dim sYearS As Integer = sDateS.Year
                Dim sDateE As DateTime = Convert.ToDateTime(dtpMonthE.Value, _cultureEnInfo)
                Dim sMonthE As Integer = sDateE.Month
                Dim sYearE As Integer = sDateE.Year

                vWhere = vWhere & " AND year(" & vField & ") * 100 + month(" & vField & ") " &
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
            End If
        End If

        If cbPartner.Checked = True And lblPartnerName.Tag IsNot Nothing Then
            vWhere = vWhere & " AND A.idPartner = " & lblPartnerName.Tag
        End If

        If cbPsSale.Checked = True And lblPsSale.Tag IsNot Nothing Then
            vWhere = vWhere & " AND A.idPsSale = " & lblPsSale.Tag
        End If
        mdCnOpen()
        sCommand.CommandText = "With A As(SELECT 1 As typ, mt.idPartner, mt.idSale, DateSaleD, DocRef, " & vbNewLine &
                               "Format(devsk.convertStrToDate(DatePay),'dd/MM/yy','th') As DatePay," & vbNewLine &
                               "mt.TotalNet, mt.TotalPay, (mt.TotalNet - ISNULL(mt.TotalPay, 0)) As Bal, PayDay, mt.idPsSale" & vbNewLine &
                               "From SmSaleMt mt" & vbNewLine &
                               "LEFT JOIN SmPaymentTermsD s ON mt.idPM = s.idPM" & vbNewLine &
                               "Where ISNULL(idSlAVxST,0) = 0" & vbNewLine &
                               "AND idPsCancel Is NULL " & vbNewLine &
                               "AND mt.stPay <> '1'" & vbNewLine &
                               "AND idSaleCode Not IN (1,18) " & vbNewLine &
                               "AND mt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                               "Union" & vbNewLine &
                               "SELECT 2 As typ, rMt.idPartner, rMt.idSaleReturn ,  rMt.DateReturnD, code.ReturnCode + ' ' + rMt.DocRef, Format(DateReturnD,'dd/MM/yy','th') As DatePay," & vbNewLine &
                                " -(rMt.Total) As Total, 0 As TotalPay, -(rMt.Total) As Bal, 0 As PayDay, rMt.idPsSale" & vbNewLine &
                                "FROM SmSaleReturnMt rMt " & vbNewLine &
                                "LEFT JOIN SmSaleReturnCode code ON rMt.idRTDocCode = code.idRTDocCode" & vbNewLine &
                                "Where rMt.idSaleReturn not IN (SELECT idSaleReturn " & vbNewLine &
                                                                "FROM SmSalePayDt dt" & vbNewLine &
                                                                "LEFT JOIN SmSalePayMt mt ON dt.idSalePay = mt.idSalePay" & vbNewLine &
                                                                "Where idSaleReturn Is Not NULL" & vbNewLine &
                                                                "AND mt.idPsCancel IS NULL) " & vbNewLine &
                                "AND ISNULL(idRtAVxST,0) = 0" & vbNewLine &
                                "AND rMt.idRTDocCode Not In (2) " & vbNewLine &
                                "AND rMt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                "Union " & vbNewLine &
                                "Select 3 As typ, mt.idPartner, mt.idNote, mt.DateNote, mt.DocCode, Format(DateNote,'dd/MM/yy','th') As DateNote, -(mt.TotalNet) , 0 As TotalPay , -(mt.TotalNet) , 0 As PayDay, mt.idPsTs" & vbNewLine &
                                "FROM SmCreditDebitNoteMt mt" & vbNewLine &
                                "WHERE mt.idPsCancel Is NULL" & vbNewLine &
                                "And mt.NoteType = 1 " & vbNewLine &
                                "AND mt.idComp = " & cmbGroupComp.SelectedValue &
                                "Union" & vbNewLine &
                                "Select 4 As typ, mt.idPartner, mt.idNote, mt.DateNote, mt.DocCode, Format(DateNote,'dd/MM/yy','th') As DateNote, mt.TotalNet , 0 As TotalPay , mt.TotalNet , 0 As PayDat,mt.idPsTs" & vbNewLine &
                                "FROM SmCreditDebitNoteMt mt" & vbNewLine &
                                "WHERE mt.idPsCancel Is NULL" & vbNewLine &
                                "AND mt.NoteType = 2 " & vbNewLine &
                                "AND mt.idComp = " & cmbGroupComp.SelectedValue & ")" & vbNewLine &
                                "Select typ, A.idPartner, cus.CusCode, p.PartnerName, p.PartnerName As CusName, A.idSale, " & vbNewLine &
                                "A.DateSaleD, A.DocRef, A.DatePay, A.TotalNet, A.TotalPay, A.Bal, A.PayDay, ps.PsName As PsSaleName" & vbNewLine &
                                "from A " & vbNewLine &
                                "LEFT JOIN dPartner p ON A.idPartner = p.idPartner " & vbNewLine &
                                "LEFT JOIN dCustomer cus ON p.idCus = cus.idCus AND p.idCus Is NOT NULL" & vbNewLine &
                                "LEFT JOIN vPersonxSelect ps ON A.idPsSale = ps.idPs" & vbNewLine &
                                vWhere & vbNewLine &
                                "AND A.Bal <> 0" & vbNewLine &
                                "Order by typ ASC, DateSaleD"

        sAdapter.Fill(dtBalAllCus)


        If dtBalAllCus.Rows.Count = 0 Then
            btnDebtBalRpt.Enabled = False
            MessageBox.Show("ไม่พบข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            mdLoadCommitt()
            Return dtBalAllCus
            Exit Function
        Else
            btnDebtBalRpt.Enabled = True
        End If

        Return dtBalAllCus
    End Function

    Private Sub chkDateSale_CheckedChanged(sender As Object, e As EventArgs) Handles chkDateSale.CheckedChanged
        If stLoad = 1 Then
            If chkDateSale.Checked = True Then
                gbDateSale.Enabled = True
            Else
                gbDateSale.Enabled = False
            End If
        End If
    End Sub
    Private Sub chkBill_CheckedChanged(sender As Object, e As EventArgs) Handles chkBill.CheckedChanged
        If stLoad = 1 Then
            If chkBill.Checked = True Then
                cmbBill.Enabled = True
            Else
                cmbBill.Enabled = False
            End If
        End If
    End Sub
End Class