Imports DevExpress.XtraSplashScreen

Public Class frmSlSaleCusDebt
    Dim vDt As New DataTable
    Dim stload As Integer = 0
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")

    Private Sub frmSlSaleCusDebt_Load(sender As Object, e As EventArgs) Handles Me.Load
        mdLoadShow()
        setCmbGroupComp(cmbGroupComp)
        BindData()
        stload = 1
        mdLoadCommitt()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        BindData()
        SplashScreenManager.CloseForm(False)
    End Sub

    Sub BindData()
      
        vDt.Clear()
        mdCnOpen()
        'sCommand.CommandText = "SELECT sl.idCus, sl.CusName, BnM.DocCode As CodeBill, BnM.DateDoc As DateBill, sl.idSale, " & _
        '                       "sl.DocRef, sl.DateSale, sl.PaymentTerms, sl.DatePay, CASE " & _
        '                       "WHEN mt.DateTf <= '" & ksbDateToString(dtpSaleS.Value.ToShortDateString) & "' " & _
        '                       "THEN (sl.TotalNet - ISNULL(sl.TotalPay,0)) ELSE sl.TotalNet END As TotalNet, " & _
        '                       "sl.stpay FROM vSmSaleMt sl LEFT OUTER JOIN SmSaleBnDt Bnd ON sl.idsale = BnD.idSale " & _
        '                       "LEFT OUTER JOIN SmSaleBnMt Bnm ON BnD.idBN = BnM.idBN LEFT OUTER JOIN SmSalePayDt dt " & _
        '                       "ON sl.idSale = dt.idSale LEFT OUTER JOIN SmSalePayMt mt ON dt.idSalePay = mt.idSalepay " & _
        '                       "WHERE sl.DateSale >= '25580101' AND (sl.idPM = 49 Or sl.idPM = 50 Or sl.idPM = 51) AND sl.idComp = " & sIdComp & " " & _
        '                       "AND sl.idPsCancel IS NULL AND BnM.idPsCancel IS NULL AND sl.stPay = '' " & _
        '                       "AND CusName IS NOT NULL AND sl.DateSale <= '" & ksbDateToString(dtpSaleS.Value.ToShortDateString) & "' " & vWHERE & " " & _
        '                       "UNION SELECT sl.idCus, sl.CusName, BnM.DocCode As CodeBill, BnM.DateDoc As DateBill, " & _
        '                       "sl.idSale, sl.DocRef, sl.DateSale, sl.PaymentTerms, sl.DatePay, " & _
        '                       "(sl.TotalNet - ISNULL(sl.TotalPay,0)) As TotalNet, sl.stpay FROM vSmSalemt sl " & _
        '                       "LEFT OUTER JOIN SmSaleBnDt Bnd ON sl.idsale = BnD.idSale LEFT OUTER JOIN SmSaleBnMt Bnm " & _
        '                       "ON BnD.idBN = BnM.idBN LEFT OUTER JOIN SmSalePayDt dt ON sl.idSale = dt.idSale " & _
        '                       "LEFT OUTER JOIN SmSalePayMt mt ON dt.idSalePay = mt.idSalepay " & _
        '                       "WHERE sl.DateSale >= '25580101' AND (sl.idPM = 49 Or sl.idPM = 50 Or sl.idPM = 51) " & _
        '                       "AND sl.idComp = " & sIdComp & " AND sl.idPsCancel IS NULL AND BnM.idPsCancel IS NULL " & _
        '                       "AND mt.idPsCancel IS NULL AND sl.stpay = '1' AND mt.DateTf > '" & ksbDateToString(dtpSaleS.Value.ToShortDateString) & "' " & _
        '                       "AND CusName IS NOT NULL" 

        sCommand.CommandText = "SELECT sl.idCus, sl.CusName, BnM.DocCode As CodeBill, BnM.DateDocD As DateBill, sl.idSale, " & vbNewLine & _
                               "sl.DocRef, sl.DateSaleD, sl.PaymentTerms, devsk.fncStrDateToDateTime(sl.DatePay) As DatePay, " & vbNewLine & _
                               "(CASE WHEN mt.DateTfD <= '" & dtpSaleS.Value.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " & vbNewLine & _
                                      "THEN (sl.TotalNet - ISNULL(sl.TotalPay,0)) " & vbNewLine & _
                                      "ELSE sl.TotalNet END) As TotalNet, sl.stpay, sl.PsSale " & vbNewLine & _
                               "FROM vSmSaleMtx sl " & vbNewLine & _
                               "LEFT OUTER JOIN SmSaleBnDt Bnd ON sl.idsale = BnD.idSale " & vbNewLine & _
                               "LEFT OUTER JOIN SmSaleBnMt Bnm ON BnD.idBN = BnM.idBN " & vbNewLine & _
                               "LEFT OUTER JOIN SmSalePayDt dt ON sl.idSale = dt.idSale " & vbNewLine & _
                               "LEFT OUTER JOIN SmSalePayMt mt ON dt.idSalePay = mt.idSalepay " & vbNewLine & _
                               "WHERE (sl.DateSaleD BETWEEN '2015-01-01' AND '" & dtpSaleS.Value.ToString("yyyy-MM-dd", _cultureEnInfo) & "') " & vbNewLine & _
                               "AND sl.idPM IN (49,50,51) AND sl.idComp = " & cmbGroupComp.SelectedValue & " AND sl.idPsCancel IS NULL " & vbNewLine & _
                               "AND BnM.idPsCancel IS NULL AND sl.stPay = '' AND CusName IS NOT NULL " & vbNewLine & _
                               "UNION " & vbNewLine & _
                               "SELECT sl.idCus, sl.CusName, BnM.DocCode As CodeBill, BnM.DateDocD As DateBill, sl.idSale, " & vbNewLine & _
                               "sl.DocRef, sl.DateSaleD, sl.PaymentTerms, sl.DatePay, " & vbNewLine & _
                               "(sl.TotalNet - ISNULL(sl.TotalPay,0)) As TotalNet, sl.stpay, sl.PsSale " & vbNewLine & _
                               "FROM vSmSalemtx sl " & vbNewLine & _
                               "LEFT OUTER JOIN SmSaleBnDt Bnd ON sl.idsale = BnD.idSale " & vbNewLine & _
                               "LEFT OUTER JOIN SmSaleBnMt Bnm ON BnD.idBN = BnM.idBN " & vbNewLine & _
                               "LEFT OUTER JOIN SmSalePayDt dt ON sl.idSale = dt.idSale " & vbNewLine & _
                               "LEFT OUTER JOIN SmSalePayMt mt ON dt.idSalePay = mt.idSalepay " & vbNewLine & _
                               "WHERE sl.DateSaleD >= '2015-01-01' AND sl.idPM IN (49,50,51) " & vbNewLine & _
                               "AND sl.idComp = " & cmbGroupComp.SelectedValue & " AND sl.idPsCancel IS NULL AND BnM.idPsCancel IS NULL " & vbNewLine & _
                               "AND mt.idPsCancel IS NULL  AND CusName IS NOT NULL " & vbNewLine & _
                               "AND (sl.stpay = '1' AND mt.DateTfD > '" & dtpSaleS.Value.ToString("yyyy-MM-dd", _cultureEnInfo) & "')"
        sAdapter.Fill(vDt)
            ' MessageBox.Show(sCommand.CommandText)

        GridControl1.DataSource = vDt
        FilterGridview()
    End Sub

    Private Sub FilterGridview()
        Dim StrFilter As String = "1 = 1 "

        If ChkPsSale.Checked = True Then
            StrFilter &= " AND [PsSale] like '%" & lblPsSale.Text.Trim & "%'"
        End If

        If ChkCus.Checked = True Then
            StrFilter &= " AND [CusName] like '%" & lblCus.Text.Trim & "%'"
        End If


        GVDebt.ActiveFilterString = StrFilter

        Dim totalNet As Double = 0.0
        For i As Integer = 0 To GVDebt.DataRowCount - 1
            totalNet = totalNet + GVDebt.GetDataRow(i).Item("TotalNet")
        Next
        txtTotalNet.Text = Format(totalNet, "#,###0.00##")
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelect, cmbGroupComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblCus.Tag = vFrm.idCus
            lblCus.Text = vFrm.CusName
        End If
    End Sub

    Private Sub ChkCus_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCus.CheckedChanged
        If Me.ChkCus.Checked = True Then
            Me.btnCustomer.Enabled = True
        Else
            Me.btnCustomer.Enabled = False
            Me.lblCus.Text = ""
        End If
    End Sub

    Private Sub btnPsSale_Click(sender As Object, e As EventArgs) Handles btnPsSale.Click
        Dim vFrm As New frmPsSaleSelect(frmPsSaleSelect.eProcess.eNormal, Nothing, "", "", 1, cmbGroupComp.SelectedValue)
        ' vFrm.GetidComp(cmbGroupComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblPsSale.Tag = vFrm.idPs
            lblPsSale.Text = vFrm.SaleName
        End If
    End Sub

    Private Sub ChkPsSale_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPsSale.CheckedChanged
        If Me.ChkPsSale.Checked = True Then
            Me.btnPsSale.Enabled = True
        Else
            Me.btnPsSale.Enabled = False
            Me.lblPsSale.Text = ""
        End If
    End Sub


    Private Sub lblPsSale_TextChanged(sender As Object, e As EventArgs) Handles lblPsSale.TextChanged
        FilterGridview()
    End Sub


    Private Sub lblCus_TextChanged(sender As Object, e As EventArgs) Handles lblCus.TextChanged
        FilterGridview()
    End Sub


    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub dtpSaleS_ValueChanged(sender As Object, e As EventArgs) Handles dtpSaleS.ValueChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub
End Class