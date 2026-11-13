Public Class FrmRptInvoice
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim stLoad As Integer = 0
    Private Sub FrmRptInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpSaleS.Value = Date.Today
        dtpSaleE.Value = Date.Today
        dtpMonthS.Value = Date.Today
        dtpMonthE.Value = Date.Today

        If Date.IsLeapYear(Date.Today.Year) = 1 Then
            dtpYear.Value = Date.Today
        Else

            dtpYear.Value = Date.Today.AddDays(-1)
        End If

        setCmbGroupComp(Me.cmbGroupComp)

        cmbOrderBy.SelectedIndex = 0

        stLoad = 1
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

    Private Sub rdbMonthNow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMonthNow.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbMonthNow.Checked = True Then
                Me.dtpMonthNow.Enabled = True
            Else
                Me.dtpMonthNow.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        mdCnOpen()
        Dim dtRptInvoice As New DataTable
        Dim vWhere As String = ""
        Dim strDate As String = ""
        Dim vField As String = ""

        If Me.rdbDateSale.Checked = True Then
            vField = "s.DateSaleD"
        ElseIf Me.rdbDateTs.Checked = True Then
            vField = "s.DateTsD"
        End If

        If Me.rdbDate.Checked = True Then
            Dim firstDate As DateTime = Convert.ToDateTime(dtpSaleS.Value, _cultureEnInfo)
            Dim lastDate As DateTime = Convert.ToDateTime(dtpSaleE.Value, _cultureEnInfo)
            vWhere = vWhere & " AND " & vField & " Between '" & firstDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " &
                              "And '" & lastDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' "

            strDate = "ประจำงวด " & dtpSaleS.Value & " -  " & dtpSaleE.Value
        ElseIf Me.rdbMonth.Checked = True Then

            Dim sDateS As DateTime = Convert.ToDateTime(dtpMonthS.Value, _cultureEnInfo)
            Dim sMonthS As Integer = sDateS.Month
            Dim sYearS As Integer = sDateS.Year
            Dim sDateE As DateTime = Convert.ToDateTime(dtpMonthE.Value, _cultureEnInfo)
            Dim sMonthE As Integer = sDateE.Month
            Dim sYearE As Integer = sDateE.Year

            vWhere = vWhere & " AND year(" & vField & ") * 100 + month(" & vField & ") " &
                              "BETWEEN " & sYearS & " * 100 + " & sMonthS & " AND " & sYearE & " * 100 + " & sMonthE & ""

            strDate = "ระหว่างงวดเดือน" & fnChangeMonth(dtpMonthS.Value.Month, dtpMonthS.Value.Year + 543) & " - " & fnChangeMonth(dtpMonthE.Value.Month, dtpMonthE.Value.Year + 543)

        ElseIf Me.rdbYear.Checked = True Then

            Dim sDateY As DateTime = Convert.ToDateTime(dtpYear.Value, _cultureEnInfo)
            Dim sYearY As Integer = sDateY.Year
            vWhere = vWhere & " AND YEAR(" & vField & ") = " & sYearY

            strDate = "ประจำงวดปี " & dtpYear.Value.Year + 543

        ElseIf Me.rdbMonthNow.Checked = True Then

            Dim sDateMN As DateTime = Convert.ToDateTime(dtpMonthNow.Value, _cultureEnInfo)
            Dim sMonthMN As Integer = sDateMN.Month
            Dim sYearMN As Integer = sDateMN.Year
            vWhere = vWhere & " AND Month(" & vField & ") = " & sMonthMN & " AND YEAR(" & vField & ") = " & sYearMN
            strDate = "ประจำงวดเดือน" & fnChangeMonth(dtpMonthNow.Value.Month, dtpMonthNow.Value.Year + 543)
        End If

        Dim strOrderby As String = ""
        If cmbOrderBy.SelectedIndex = 0 Then
            strOrderby = "s.DocRef "
        ElseIf cmbOrderBy.SelectedIndex = 1 Then
            strOrderby = "s.DateSaleD "
        ElseIf cmbOrderBy.SelectedIndex = 2 Then
            strOrderby = "p6.PsName "
        ElseIf cmbOrderBy.SelectedIndex = 3 Then
            strOrderby = "s.PartnerNameBill "
        End If

        Dim str As String = " ASC"

        If rdbDESC.Checked = True Then
            str = " DESC"
        End If

        'cmbOrderBy.Items.Add("เลขที่อินวอยซ์")
        'cmbOrderBy.Items.Add("วันที่ขายสินค้า")
        'cmbOrderBy.Items.Add("พนักงานขาย")
        'cmbOrderBy.Items.Add("ชื่อลูกค้า")


        sCommand.CommandText = "SELECT s.DocRef, s.DocCode, s.DateSaleD, s.PartnerNameBill As CustName, p6.PsName As PsSaleName, s.Total, " & vbNewLine &
                                "ISNULL(s.DiscountAmout,0) As DiscountAmout, ISNULL(s.DiscountPerc,0) As DiscountPerc, ISNULL(s.DiscountBath,0) As DiscountBath, s.TotalNet " & vbNewLine &
                                "From SmSaleMt s " & vbNewLine &
                                "LEFT JOIN dPartner v ON s.idPartner = v.idPartner " & vbNewLine &
                                "LEFT JOIN vPersonShort p6 ON s.idPsSale = p6.idPs" & vbNewLine &
                                "WHERE s.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                "AND ISNULL(s.idSlAVxST,0) = 0" & vbNewLine &
                                "AND s.idPsCancel Is NULL" & vbNewLine &
                                vWhere & vbNewLine &
                                "Order by " & strOrderby & str

        sAdapter.Fill(dtRptInvoice)

        If dtRptInvoice.Rows.Count = 0 Then
            MessageBox.Show("ไม่สามารถออกรายงานได้" & vbNewLine &
                            "เนื่องจากไม่พบข้อมูลตามเงื่อนไข ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        Else


            Dim vRpt As New crpInvoiceRpt
            vRpt.SetDataSource(dtRptInvoice)
            vRpt.SetParameterValue(vRpt.Parameter_strDate.ParameterFieldName, strDate)
            vRpt.SetParameterValue(vRpt.Parameter_strCompanyName.ParameterFieldName, cmbGroupComp.Text)


            '--show from cystalreport--'
            Dim vFrmRpt As New FrmReportView
            vFrmRpt.crView.ReportSource = vRpt
            vFrmRpt.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            vFrmRpt.crView.ShowExportButton = False
            vFrmRpt.crView.ShowGroupTreeButton = False
            vFrmRpt.Show()
        End If
    End Sub

    Private Function fnChangeMonth(ByVal Month As Integer, ByVal Year As String) As String
        Dim strDate As String = ""

        If Month = "1" Then
            strDate = " มกราคม " & Year
        ElseIf Month = "2" Then
            strDate = " กุมภาพันธ์ " & Year
        ElseIf Month = "3" Then
            strDate = " มีนาคม " & Year
        ElseIf Month = "4" Then
            strDate = " เมษายน " & Year
        ElseIf Month = "5" Then
            strDate = " พฤษภาคม " & Year
        ElseIf Month = "6" Then
            strDate = " มิถุนายน " & Year
        ElseIf Month = "7" Then
            strDate = " กรกฎาคม " & Year
        ElseIf Month = "8" Then
            strDate = " สิงหาคม " & Year
        ElseIf Month = "9" Then
            strDate = " กันยายน " & Year
        ElseIf Month = "10" Then
            strDate = " ตุลาคม " & Year
        ElseIf Month = "11" Then
            strDate = " พฤศจิกายน " & Year
        ElseIf Month = "12" Then
            strDate = " ธันวาคม " & Year
        End If

        Return strDate
    End Function

End Class