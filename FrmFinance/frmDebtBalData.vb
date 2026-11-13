Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing

Public Class frmDebtBalData
    Dim stLoad As Integer = 0
    Dim sDt As New DataTable
    Dim vAddress As String = ""
    Dim vContact As String = ""
    Dim vCompCode As String = ""

    Private Sub frmDebtBalData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdLoadShow()
        setCmbGroupComp(cmbGroupComp)
        SetHeaderRpt()
        ' dtpDate.Value = DateTime.Now
        stLoad = 1
        mdLoadCommitt()
    End Sub

    Private Sub btnCus_Click(sender As Object, e As EventArgs) Handles btnCus.Click
        sDt.Rows.Clear()
        txtTotalNet.Text = "0.00"
        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelect, cmbGroupComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblCus.Tag = vFrm.idCus
            lblCus.Text = vFrm.CusName

            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Sub BindData()
        mdCnOpen()
        sDt.Clear()

        sCommand.CommandText = "SELECT * FROM (
                                    SELECT 1 As typ, idSale, DateSaleD, DocRef, devsk.convertStrToDate(DatePay) As DatePay,
                                           TotalNet, TotalPay, (TotalNet - ISNULL(TotalPay, 0)) As Bal
                                    FROM SmSaleMt
                                    WHERE idCus = " & lblCus.Tag & " And idComp = " & cmbGroupComp.SelectedValue & " AND idPsCancel Is NULL AND stPay <> '1'
                                          AND idSaleCode Not IN (1,18) 
                                    UNION ALL
                                    SELECT 2 As typ, rMt.idSaleReturn, DateReturnD As DateReturn, code.ReturnCode + ' ' + rMt.DocRef As DocRef,
                                           NULL As DatePay, -(rMt.Total) As Total, 0 As TotalPay, -(rMt.Total) As Bal
                                    FROM SmSaleReturnMt rMt 
                                    LEFT JOIN SmSaleReturnCode code ON rMt.idRTDocCode = code.idRTDocCode
                                    WHERE rMt.idCus = " & lblCus.Tag & " And rMt.idComp = " & cmbGroupComp.SelectedValue & " AND rMt.idPsCancel Is NULL 
                                          AND NOT EXISTS (SELECT 1 FROM SmSalePayDt dt
                                                          LEFT JOIN SmSalePayMt mt ON dt.idSalePay = mt.idSalePay
                                                          WHERE dt.idSaleReturn = rMt.idSaleReturn AND mt.idPsCancel IS NULL
                                                    )
                                    UNION ALL
                                    SELECT CASE WHEN cr.NoteType = 2 THEN 3 ELSE 4 END As typ,cr.idNote, cr.DateNote, cr.DocRef, NULL As DatePay,
                                           CASE WHEN cr.NoteType = 2 THEN cr.TotalNet ELSE -(cr.TotalNet) END As TotalNet,0 As TotalPay, 
                                           CASE WHEN cr.NoteType = 2 THEN cr.TotalNet ELSE -(cr.TotalNet) END As Bal
                                    FROM devsk.SmCreditDebitNoteMt cr
                                    LEFT JOIN devsk.dPartner p ON cr.idPartner = p.idPartner
                                    WHERE cr.NoteType IN (1, 2) AND cr.idPsCancel IS NULL AND p.idCus = " & lblCus.Tag & " AND cr.idComp = " & cmbGroupComp.SelectedValue & " 
                                          AND NOT EXISTS (SELECT 1 FROM SmSalePayDt dt
                                                          LEFT JOIN SmSalePayMt mt ON dt.idSalePay = mt.idSalePay
                                                          WHERE mt.idPsCancel IS NULL 
                                                          AND ((cr.NoteType = 2 AND dt.idDbnMt = cr.idNote) OR (cr.NoteType = 1 AND dt.idCrnMt = cr.idNote))
                                                    )
                             ) AS ResultTable WHERE ResultTable.Bal <> 0
                               ORDER by ResultTable.DateSaleD, ResultTable.typ ASC"

        'sCommand.CommandText = "SELECT 1 As typ, idSale, DateSaleD, DocRef, devsk.convertStrToDate(DatePay) As DatePay," & vbNewLine &
        '                       "TotalNet, TotalPay, (TotalNet - ISNULL(TotalPay, 0)) As Bal" & vbNewLine &
        '                       "From SmSaleMt" & vbNewLine &
        '                       "WHERE idCus = " & lblCus.Tag & " And idComp = " & cmbGroupComp.SelectedValue & " " & vbNewLine &
        '                       "AND idPsCancel Is NULL " & vbNewLine &
        '                       "AND TotalNet <> TotalPay " & vbNewLine &
        '                       "AND idSaleCode Not IN (1,18) " & vbNewLine &
        '                       "UNION" & vbNewLine &
        '                        "SELECT 2 As typ, rMt.idSaleReturn, DateReturnD As DateReturn,code.ReturnCode + ' ' + rMt.DocRef As DocRef," & vbNewLine &
        '                          "NULL As DatePay, -(rMt.Total) As Total, 0 As TotalPay, -(rMt.Total) As Bal" & vbNewLine &
        '                          "FROM SmSaleReturnMt rMt " & vbNewLine &
        '                          "LEFT JOIN SmSaleReturnCode code ON rMt.idRTDocCode = code.idRTDocCode" & vbNewLine &
        '                          "Where rMt.idSaleReturn not IN (SELECT idSaleReturn " & vbNewLine &
        '                                                      "FROM SmSalePayDt dt" & vbNewLine &
        '                                                      "LEFT JOIN SmSalePayMt mt ON dt.idSalePay = mt.idSalePay" & vbNewLine &
        '                                                      "Where idSaleReturn Is Not NULL" & vbNewLine &
        '                                                      "AND mt.idPsCancel IS NULL)" & vbNewLine &
        '                          "AND rMt.idCus =  " & lblCus.Tag & vbNewLine &
        '                          "And rMt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
        '                          "AND rMt.idPsCancel Is NULL " & vbNewLine &
        '                          "Order by typ ASC, DateSaleD"

        'Dim enUS As New System.Globalization.CultureInfo("en-US")
        'Dim dateStr As String = dtpDate.Value.ToString("yyyy-MM-dd", enUS) & " 23:59:59"
        'sCommand.CommandText = "DECLARE @AsOfDate DATETIME = '" & dateStr & "'; 
        '                        SELECT 1 As typ, mt.idSale, DateSaleD, DocRef, 
        '                               Format(devsk.convertStrToDate(DatePay),'dd/MM/yy','th') As DatePay, mt.TotalNet,       
        '                               COALESCE(pay.PaidAmountAsOf, mt.TotalPay, 0) As TotalPay,     
        '                      (mt.TotalNet - COALESCE(pay.PaidAmountAsOf, mt.TotalPay, 0)) As Bal
        '                        FROM SmSaleMt mt
        '                        LEFT JOIN (
        '                            SELECT dt.idSale, SUM(dt.AmountPay) AS PaidAmountAsOf
        '                            FROM SmSalePayDt dt
        '                            INNER JOIN SmSalePayMt pmt ON dt.idSalePay = pmt.idSalePay
        '                            WHERE pmt.idPsCancel IS NULL AND pmt.DateTfD <= @AsOfDate
        '                            GROUP BY dt.idSale
        '                        ) pay ON mt.idSale = pay.idSale
        '                        WHERE mt.idCus = " & lblCus.Tag & " AND mt.idComp = " & cmbGroupComp.SelectedValue & " AND mt.idPsCancel Is NULL 
        '                              AND idSaleCode Not IN (1,18) AND mt.DateSaleD <= @AsOfDate 
        '                              AND mt.TotalNet > COALESCE(pay.PaidAmountAsOf, mt.TotalPay, 0)   
        '                        UNION
        '                        SELECT 2 As typ,rMt.idSaleReturn,rMt.DateReturnD,code.ReturnCode + ' ' + rMt.DocRef, '-' As DatePay,
        '                               -(rMt.Total) As Total,0 As TotalPay,-(rMt.Total) As Bal
        '                        FROM SmSaleReturnMt rMt 
        '                        LEFT JOIN SmSaleReturnCode code ON rMt.idRTDocCode = code.idRTDocCode
        '                        WHERE rMt.idComp = " & cmbGroupComp.SelectedValue & " AND rMt.idPsCancel Is NULL 
        '                           AND rMt.idCus = " & lblCus.Tag & "  AND rMt.DateReturnD <= @AsOfDate
        '                              AND rMt.idSaleReturn not IN (SELECT dt.idSaleReturn FROM SmSalePayDt dt
        '                                                           LEFT JOIN SmSalePayMt pmt ON dt.idSalePay = pmt.idSalePay
        '                                                           WHERE dt.idSaleReturn Is Not NULL
        '                                                                 AND pmt.idPsCancel IS NULL AND pmt.DateTfD <= @AsOfDate
        '                                                          )                                   
        '                       ORDER by DateSaleD, typ ASC"
        sAdapter.Fill(sDt)
        GCData.DataSource = sDt

        If sDt.Rows.Count = 0 Then
            SplashScreenManager.CloseForm(False)
            MessageBox.Show("ไม่พบข้อมูลยอดหนี้คงเหลือ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTotalNet.Text = "0.00"
            btnDebtBalRpt.Enabled = False
            btnPdf.Enabled = False
            Exit Sub
        Else
            Dim TotalNet As Double = 0.0
            For i As Integer = 0 To GvShowData.DataRowCount - 1
                TotalNet = TotalNet + GvShowData.GetDataRow(i).Item("Bal")
            Next
            txtTotalNet.Text = Format(TotalNet, "#,##0.00")
            btnDebtBalRpt.Enabled = True
            btnPdf.Enabled = True
        End If
    End Sub

    Sub SetHeaderRpt()
        Dim dt As New DataTable
        mdCnOpen2()
        sCommand.CommandText = "Select c.CompCode,c.Address,ISNULL(c.Tel, '') As Tel,ISNULL(c.Fax, '') As Fax,c.TaxCode,c.PostCode,p.ProvinceName " &
                                   "From dCompany c " & vbNewLine &
                                   "INNER JOIN dProvinceFix p ON c.idProvince = p.idProvince " & vbNewLine &
                                   "Where idComp = " & cmbGroupComp.SelectedValue
        sAdapter.Fill(dt)
        If dt.Rows(0).Item("Tel") = "" Then
            dt.Rows(0).Item("Tel") = "-"
        End If
        If dt.Rows(0).Item("Fax") = "" Then
            dt.Rows(0).Item("Fax") = "-"
        End If
        vAddress = dt.Rows(0).Item("Address").ToString & " จ." & dt.Rows(0).Item("ProvinceName").ToString & " " & dt.Rows(0).Item("PostCode")
        vContact = "Tel: " & Trim(dt.Rows(0).Item("Tel")) & "  Fax: " & dt.Rows(0).Item("Fax").ToString
        vCompCode = dt.Rows(0).Item("CompCode")
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If lblCus.Text.Trim = "" Then
            MessageBox.Show("กรุณาระบุชื่อลูกค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCus.Focus()
            Exit Sub
        End If

        mdCnOpen()
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        BindData()
        SplashScreenManager.CloseForm(False)
    End Sub
    Private Sub GvShowData_CustomDrawCell(sender As Object, e As Views.Base.RowCellCustomDrawEventArgs) Handles GvShowData.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub btnDebtBalRpt_Click(sender As Object, e As EventArgs) Handles btnDebtBalRpt.Click
        If lblCus.Text.Trim = "" Then
            MessageBox.Show("กรุณาระบุลูกค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCus.Focus()
            Exit Sub
        ElseIf sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูลยอดหนี้คงเหลือ จึงไม่สามารถออกหนังสือแจ้งยอดหนี้คงเหลือได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Dim vAddress As String = ""
        'Dim vContact As String = ""
        'Dim dt As New DataTable
        'mdCnOpen2()
        'sCommand.CommandText = "Select c.Address, ISNULL(c.Tel, '') As Tel, ISNULL(c.Fax, '') As Fax, c.TaxCode, c.PostCode, p.ProvinceName " &
        '                       "From dCompany c " & vbNewLine &
        '                       "INNER JOIN dProvinceFix p ON c.idProvince = p.idProvince " & vbNewLine &
        '                       "Where idComp = " & cmbGroupComp.SelectedValue
        'sAdapter.Fill(dt)

        'If dt.Rows(0).Item("Tel") = "" Then
        '    dt.Rows(0).Item("Tel") = "-"
        'End If
        'If dt.Rows(0).Item("Fax") = "" Then
        '    dt.Rows(0).Item("Fax") = "-"
        'End If

        'vAddress = dt.Rows(0).Item("Address").ToString & " จ." & dt.Rows(0).Item("ProvinceName").ToString & " " & dt.Rows(0).Item("PostCode")
        'vContact = "Tel: " & Trim(dt.Rows(0).Item("Tel")) & "  Fax: " & dt.Rows(0).Item("Fax").ToString

        Dim DebtBalDt As New DataTable
        DebtBalDt.Clear()

        mdCnOpen()
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        sCommand.CommandText = "SELECT * FROM (
                                    SELECT 1 As typ, idSale,c.CusName_ As CusName,c.Address As CusAddress,
		                                   (CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As CusTel,
			                               c.CusCode,DateSaleD, DocRef, devsk.convertStrToDate(DatePay) As DatePay,
                                           TotalNet, TotalPay, (TotalNet - ISNULL(TotalPay, 0)) As Bal
                                    FROM SmSaleMt mt
	                                LEFT JOIN vCustomer c ON mt.idCus = c.idCus
                                    WHERE mt.idCus = " & lblCus.Tag & " And mt.idComp = " & cmbGroupComp.SelectedValue & " AND idPsCancel Is NULL 
                                          AND idSaleCode Not IN (1,18) AND stPay <> '1'
                                    UNION ALL
                                    SELECT 2 As typ, rMt.idSaleReturn,c.CusName_ As CusName,c.Address As CusAddress,
		                                   (CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As CusTel,
		                                   c.CusCode, DateReturnD As DateReturn, code.ReturnCode + ' ' + rMt.DocRef As DocRef,
                                           NULL As DatePay, -(rMt.Total) As Total, 0 As TotalPay, -(rMt.Total) As Bal
                                    FROM SmSaleReturnMt rMt 
                                    LEFT JOIN SmSaleReturnCode code ON rMt.idRTDocCode = code.idRTDocCode
	                                LEFT JOIN vCustomer c ON rmt.idCus = c.idCus
                                    WHERE rMt.idCus = " & lblCus.Tag & " And rMt.idComp = " & cmbGroupComp.SelectedValue & " AND rMt.idPsCancel Is NULL 
                                          AND NOT EXISTS (SELECT 1 FROM SmSalePayDt dt
                                                          LEFT JOIN SmSalePayMt mt ON dt.idSalePay = mt.idSalePay
                                                          WHERE dt.idSaleReturn = rMt.idSaleReturn AND mt.idPsCancel IS NULL
                                                    )
                                    UNION ALL
                                    SELECT CASE WHEN cr.NoteType = 2 THEN 3 ELSE 4 END As typ,cr.idNote,c.CusName_ As CusName,c.Address As CusAddress,
		                                   (CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As CusTel,
		                                   c.CusCode, cr.DateNote, cr.DocRef, NULL As DatePay,
                                           CASE WHEN cr.NoteType = 2 THEN cr.TotalNet ELSE -(cr.TotalNet) END As TotalNet,0 As TotalPay, 
                                           CASE WHEN cr.NoteType = 2 THEN cr.TotalNet ELSE -(cr.TotalNet) END As Bal
                                    FROM devsk.SmCreditDebitNoteMt cr
                                    LEFT JOIN devsk.dPartner p ON cr.idPartner = p.idPartner
	                                LEFT JOIN vCustomer c ON p.idCus = c.idCus
                                    WHERE cr.NoteType IN (1, 2) AND cr.idPsCancel IS NULL AND p.idCus =  " & lblCus.Tag & " AND cr.idComp = " & cmbGroupComp.SelectedValue & " 
                                          AND NOT EXISTS (SELECT 1 FROM SmSalePayDt dt
                                                          LEFT JOIN SmSalePayMt mt ON dt.idSalePay = mt.idSalePay
                                                          WHERE mt.idPsCancel IS NULL 
                                                          AND ((cr.NoteType = 2 AND dt.idDbnMt = cr.idNote) OR (cr.NoteType = 1 AND dt.idCrnMt = cr.idNote))
                                                    )
                           ) AS ResultTable WHERE ResultTable.Bal <> 0
                             ORDER by ResultTable.DateSaleD, ResultTable.typ ASC"

        'sCommand.CommandText = "SELECT 1 As typ,mt.idSale,c.CusName_ As CusName,c.Address As CusAddress, " & vbNewLine &
        '                       "(CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As CusTel, " & vbNewLine &
        '                       "c.CusCode, DateSaleD, DocRef, " & vbNewLine &
        '                       "Format(devsk.convertStrToDate(DatePay),'dd/MM/yy','th') As DatePay," & vbNewLine &
        '                       "mt.TotalNet, mt.TotalPay, (mt.TotalNet - ISNULL(mt.TotalPay, 0)) As Bal" & vbNewLine &
        '                       "From SmSaleMt mt" & vbNewLine &
        '                       "LEFT JOIN vCustomer c ON mt.idCus = c.idCus " & vbNewLine &
        '                       "WHERE mt.idCus = " & lblCus.Tag & " And mt.idComp = " & cmbGroupComp.SelectedValue & " " & vbNewLine &
        '                       "AND mt.idPsCancel Is NULL AND mt.TotalNet <> mt.TotalPay" & vbNewLine &
        '                       "AND idSaleCode Not IN (1,18)" & vbNewLine &
        '                       "Union" & vbNewLine &
        '                       "SELECT 2 As typ, rMt.idSaleReturn , 'ยอดรับคืน' As CusName, '' As CusAddress, '' As CusTel, '' As CusCode, " & vbNewLine &
        '                       "rMt.DateReturnD, code.ReturnCode + ' ' + rMt.DocRef, '-' As DatePay," & vbNewLine &
        '                       " -(rMt.Total) As Total, 0 As TotalPay, -(rMt.Total) As Bal" & vbNewLine &
        '                        "FROM SmSaleReturnMt rMt " & vbNewLine &
        '                        "LEFT JOIN SmSaleReturnCode code ON rMt.idRTDocCode = code.idRTDocCode" & vbNewLine &
        '                        "Where rMt.idSaleReturn not IN (SELECT idSaleReturn " & vbNewLine &
        '                                                        "FROM SmSalePayDt dt" & vbNewLine &
        '                                                        "LEFT JOIN SmSalePayMt mt ON dt.idSalePay = mt.idSalePay" & vbNewLine &
        '                                                        "Where idSaleReturn Is Not NULL" & vbNewLine &
        '                                                        "AND mt.idPsCancel IS NULL)" & vbNewLine &
        '                        "AND rMt.idCus =  " & lblCus.Tag & vbNewLine &
        '                        "And rMt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
        '                        "AND rMt.idPsCancel Is NULL " & vbNewLine &
        '                        "Order by DateSaleD,typ ASC"

        'Dim enUS As New System.Globalization.CultureInfo("en-US")
        'Dim dateStr As String = dtpDate.Value.ToString("yyyy-MM-dd", enUS) & " 23:59:59"
        'sCommand.CommandText = "DECLARE @AsOfDate DATETIME = '" & dateStr & "'; 
        '                        SELECT 1 As typ,mt.idSale,c.CusName_ As CusName,c.Address As CusAddress,
        '                            (CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As CusTel,
        '                            c.CusCode,mt.DateSaleD,DocRef, 
        '                               Format(devsk.convertStrToDate(DatePay),'dd/MM/yyyy','th') As DatePay, mt.TotalNet,       
        '                               COALESCE(pay.PaidAmountAsOf, mt.TotalPay, 0) As TotalPay,     
        '                      (mt.TotalNet - COALESCE(pay.PaidAmountAsOf, mt.TotalPay, 0)) As Bal
        '                        FROM SmSaleMt mt
        '                        LEFT JOIN vCustomer c ON mt.idCus = c.idCus
        '                        LEFT JOIN (
        '                                SELECT dt.idSale, SUM(dt.AmountPay) AS PaidAmountAsOf
        '                                FROM SmSalePayDt dt
        '                                INNER JOIN SmSalePayMt pmt ON dt.idSalePay = pmt.idSalePay
        '                                WHERE pmt.idPsCancel IS NULL AND pmt.DateTfD <= @AsOfDate
        '                                GROUP BY dt.idSale
        '                                ) pay ON mt.idSale = pay.idSale
        '                        WHERE mt.idCus = " & lblCus.Tag & " AND mt.idComp = " & cmbGroupComp.SelectedValue & " AND mt.idPsCancel Is NULL 
        '                              AND idSaleCode Not IN (1,18) AND mt.DateSaleD <= @AsOfDate 
        '                              AND mt.TotalNet > COALESCE(pay.PaidAmountAsOf, mt.TotalPay, 0)   
        '                        UNION
        '                        SELECT 2 As typ,rMt.idSaleReturn As idSale,cr.CusName_ As CusName,cr.Address As CusAddress, 
        '                            (CASE cr.TelOffice WHEN '' THEN cr.Mobile1 ELSE cr.TelOffice END) As CusTel,
        '                            cr.CusCode As CusCode,rMt.DateReturnD As DateSaleD,code.ReturnCode + ' ' + rMt.DocRef, '-' As DatePay,
        '                               -(rMt.Total) As Total, 0 As TotalPay, -(rMt.Total) As Bal
        '                        FROM SmSaleReturnMt rMt 
        '                        LEFT JOIN SmSaleReturnCode code ON rMt.idRTDocCode = code.idRTDocCode
        '                        LEFT JOIN vCustomer cr ON rMt.idCus = cr.idCus
        '                        WHERE rMt.idComp = " & cmbGroupComp.SelectedValue & " AND rMt.idPsCancel Is NULL 
        '                           AND rMt.idCus = " & lblCus.Tag & "  AND rMt.DateReturnD <= @AsOfDate
        '                              AND rMt.idSaleReturn not IN (SELECT dt.idSaleReturn FROM SmSalePayDt dt
        '                                                           LEFT JOIN SmSalePayMt pmt ON dt.idSalePay = pmt.idSalePay
        '                                                           WHERE dt.idSaleReturn Is Not NULL
        '                                                                 AND pmt.idPsCancel IS NULL AND pmt.DateTfD <= @AsOfDate)                                   
        '                        ORDER by DateSaleD,typ ASC"
        sAdapter.Fill(DebtBalDt)

        Dim vFrm As New FrmReportView
        Dim vRpt As New crpDebtBalance
        vRpt.SetDataSource(DebtBalDt)
        vRpt.SetParameterValue(vRpt.Parameter_ptCompName.ParameterFieldName, cmbGroupComp.Text.Trim)
        vRpt.SetParameterValue(vRpt.Parameter_ptCompAddress.ParameterFieldName, vAddress.ToString)
        vRpt.SetParameterValue(vRpt.Parameter_ptCompContact.ParameterFieldName, vContact.ToString)
        vRpt.SetParameterValue(vRpt.Parameter_ptDateAs.ParameterFieldName, Date.Today)
        vFrm.crView.ReportSource = vRpt

        SplashScreenManager.CloseForm(False)
        vFrm.Show()
    End Sub

    Public Sub ExportToPdfCustom(ByVal rpt As ReportDocument, ByVal pdfPath As String)
        Try
            Dim pDoc As New PrintDocument()
            pDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF"
            pDoc.PrinterSettings.PrintToFile = True
            pDoc.PrinterSettings.PrintFileName = pdfPath

            rpt.PrintOptions.PrinterName = "Microsoft Print to PDF"
            rpt.PrintToPrinter(pDoc.PrinterSettings, pDoc.PrinterSettings.DefaultPageSettings, False)
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            sDt.Rows.Clear()
            txtTotalNet.Text = "0.00"
            btnDebtBalRpt.Enabled = False
            btnPdf.Enabled = False
            SetHeaderRpt()
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs)
        If stLoad = 1 Then
            sDt.Rows.Clear()
            txtTotalNet.Text = "0.00"
            btnDebtBalRpt.Enabled = False
            btnPdf.Enabled = False
        End If
    End Sub

    Private Sub btnPdf_Click(sender As Object, e As EventArgs) Handles btnPdf.Click
        If lblCus.Text.Trim = "" Then
            MessageBox.Show("กรุณาระบุลูกค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCus.Focus()
            Exit Sub
        ElseIf sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูลยอดหนี้คงเหลือ จึงไม่สามารถออกหนังสือแจ้งยอดหนี้คงเหลือได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim _cultureTHInfo As New Globalization.CultureInfo("th-TH")
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "PDF File|*.pdf"
        saveFileDialog1.FileName = vCompCode & "_Cus" & lblCus.Tag & "_" & Date.Today.ToString("ddMMyyyy", _cultureTHInfo) & ".pdf"

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            Dim DebtBalDt As New DataTable
            mdCnOpen()

            sCommand.CommandText = "SELECT * FROM (
                                    SELECT 1 As typ, idSale,c.CusName_ As CusName,c.Address As CusAddress,
		                                   (CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As CusTel,
			                               c.CusCode,DateSaleD, DocRef, devsk.convertStrToDate(DatePay) As DatePay,
                                           TotalNet, TotalPay, (TotalNet - ISNULL(TotalPay, 0)) As Bal
                                    FROM SmSaleMt mt
	                                LEFT JOIN vCustomer c ON mt.idCus = c.idCus
                                    WHERE mt.idCus = " & lblCus.Tag & " And mt.idComp = " & cmbGroupComp.SelectedValue & " AND idPsCancel Is NULL 
                                          AND idSaleCode Not IN (1,18) AND stPay <> '1'
                                    UNION ALL
                                    SELECT 2 As typ, rMt.idSaleReturn,c.CusName_ As CusName,c.Address As CusAddress,
		                                   (CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As CusTel,
		                                   c.CusCode, DateReturnD As DateReturn, code.ReturnCode + ' ' + rMt.DocRef As DocRef,
                                           NULL As DatePay, -(rMt.Total) As Total, 0 As TotalPay, -(rMt.Total) As Bal
                                    FROM SmSaleReturnMt rMt 
                                    LEFT JOIN SmSaleReturnCode code ON rMt.idRTDocCode = code.idRTDocCode
	                                LEFT JOIN vCustomer c ON rmt.idCus = c.idCus
                                    WHERE rMt.idCus = " & lblCus.Tag & " And rMt.idComp = " & cmbGroupComp.SelectedValue & " AND rMt.idPsCancel Is NULL 
                                          AND NOT EXISTS (SELECT 1 FROM SmSalePayDt dt
                                                          LEFT JOIN SmSalePayMt mt ON dt.idSalePay = mt.idSalePay
                                                          WHERE dt.idSaleReturn = rMt.idSaleReturn AND mt.idPsCancel IS NULL
                                                    )
                                    UNION ALL
                                    SELECT CASE WHEN cr.NoteType = 2 THEN 3 ELSE 4 END As typ,cr.idNote,c.CusName_ As CusName,c.Address As CusAddress,
		                                   (CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As CusTel,
		                                   c.CusCode, cr.DateNote, cr.DocRef, NULL As DatePay,
                                           CASE WHEN cr.NoteType = 2 THEN cr.TotalNet ELSE -(cr.TotalNet) END As TotalNet,0 As TotalPay, 
                                           CASE WHEN cr.NoteType = 2 THEN cr.TotalNet ELSE -(cr.TotalNet) END As Bal
                                    FROM devsk.SmCreditDebitNoteMt cr
                                    LEFT JOIN devsk.dPartner p ON cr.idPartner = p.idPartner
	                                LEFT JOIN vCustomer c ON p.idCus = c.idCus
                                    WHERE cr.NoteType IN (1, 2) AND cr.idPsCancel IS NULL AND p.idCus =  " & lblCus.Tag & " AND cr.idComp = " & cmbGroupComp.SelectedValue & " 
                                          AND NOT EXISTS (SELECT 1 FROM SmSalePayDt dt
                                                          LEFT JOIN SmSalePayMt mt ON dt.idSalePay = mt.idSalePay
                                                          WHERE mt.idPsCancel IS NULL 
                                                          AND ((cr.NoteType = 2 AND dt.idDbnMt = cr.idNote) OR (cr.NoteType = 1 AND dt.idCrnMt = cr.idNote))
                                                    )
                           ) AS ResultTable WHERE ResultTable.Bal <> 0
                             ORDER by ResultTable.DateSaleD, ResultTable.typ ASC"

            'Dim enUS As New System.Globalization.CultureInfo("en-US")
            'Dim dateStr As String = dtpDate.Value.ToString("yyyy-MM-dd", enUS) & " 23:59:59"
            'sCommand.CommandText = "DECLARE @AsOfDate DATETIME = '" & dateStr & "'; 
            '                    SELECT 1 As typ,mt.idSale,c.CusName_ As CusName,c.Address As CusAddress,
            '                        (CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As CusTel,
            '                        c.CusCode,mt.DateSaleD,DocRef, 
            '                           Format(devsk.convertStrToDate(DatePay),'dd/MM/yyyy','th') As DatePay, mt.TotalNet,       
            '                           COALESCE(pay.PaidAmountAsOf, mt.TotalPay, 0) As TotalPay,     
            '                  (mt.TotalNet - COALESCE(pay.PaidAmountAsOf, mt.TotalPay, 0)) As Bal
            '                    FROM SmSaleMt mt
            '                    LEFT JOIN vCustomer c ON mt.idCus = c.idCus
            '                    LEFT JOIN (
            '                            SELECT dt.idSale, SUM(dt.AmountPay) AS PaidAmountAsOf
            '                            FROM SmSalePayDt dt
            '                            INNER JOIN SmSalePayMt pmt ON dt.idSalePay = pmt.idSalePay
            '                            WHERE pmt.idPsCancel IS NULL AND pmt.DateTfD <= @AsOfDate
            '                            GROUP BY dt.idSale
            '                            ) pay ON mt.idSale = pay.idSale
            '                    WHERE mt.idCus = " & lblCus.Tag & " AND mt.idComp = " & cmbGroupComp.SelectedValue & " AND mt.idPsCancel Is NULL 
            '                          AND idSaleCode Not IN (1,18) AND mt.DateSaleD <= @AsOfDate 
            '                          AND mt.TotalNet > COALESCE(pay.PaidAmountAsOf, mt.TotalPay, 0)   
            '                    UNION
            '                    SELECT 2 As typ,rMt.idSaleReturn As idSale,cr.CusName_ As CusName,cr.Address As CusAddress, 
            '                        (CASE cr.TelOffice WHEN '' THEN cr.Mobile1 ELSE cr.TelOffice END) As CusTel,
            '                        cr.CusCode As CusCode,rMt.DateReturnD As DateSaleD,code.ReturnCode + ' ' + rMt.DocRef, '-' As DatePay,
            '                           -(rMt.Total) As Total, 0 As TotalPay, -(rMt.Total) As Bal
            '                    FROM SmSaleReturnMt rMt 
            '                    LEFT JOIN SmSaleReturnCode code ON rMt.idRTDocCode = code.idRTDocCode
            '                    LEFT JOIN vCustomer cr ON rMt.idCus = cr.idCus
            '                    WHERE rMt.idComp = " & cmbGroupComp.SelectedValue & " AND rMt.idPsCancel Is NULL 
            '                       AND rMt.idCus = " & lblCus.Tag & "  AND rMt.DateReturnD <= @AsOfDate
            '                          AND rMt.idSaleReturn not IN (SELECT dt.idSaleReturn FROM SmSalePayDt dt
            '                                                       LEFT JOIN SmSalePayMt pmt ON dt.idSalePay = pmt.idSalePay
            '                                                       WHERE dt.idSaleReturn Is Not NULL
            '                                                             AND pmt.idPsCancel IS NULL AND pmt.DateTfD <= @AsOfDate)                                   
            '                    ORDER by DateSaleD,typ ASC"


            sAdapter.Fill(DebtBalDt)

            Dim vRpt As New crpDebtBalance
            vRpt.SetDataSource(DebtBalDt)
            vRpt.SetParameterValue(vRpt.Parameter_ptCompName.ParameterFieldName, cmbGroupComp.Text.Trim)
            vRpt.SetParameterValue(vRpt.Parameter_ptCompAddress.ParameterFieldName, vAddress.ToString)
            vRpt.SetParameterValue(vRpt.Parameter_ptCompContact.ParameterFieldName, vContact.ToString)
            vRpt.SetParameterValue(vRpt.Parameter_ptDateAs.ParameterFieldName, Date.Today)

            ExportToPdfCustom(vRpt, saveFileDialog1.FileName)
            SplashScreenManager.CloseForm(False)
            MessageBox.Show("Export PDF เรียบร้อยแล้ว", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class