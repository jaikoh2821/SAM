Public Class frmPsSaleComm
    Dim Status As Integer
    Dim idPdT As Integer = 0
    Private Sub frmPsSaleComm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdCnOpen()
        'Load_Data()
    End Sub
    Dim strDate As String = ""
    Dim strDateY As String = ""
    Dim strDateM As String = ""
    Private Sub Load_Data()
        If txt_YM.Text = "" Then
            MessageBox.Show("กรุณาเลือกเดือน/ปี")
            Exit Sub
        End If
        Dim vPsc As New DataView
        Dim vPsc2 As New DataView
        Dim vWhere As String = ""
        Dim sWhere As String = ""
        'Dim strDate As String = ""
        'strDate = ""
        'Dim month As String
        'If dtpMonth.Value.Month < 10 Then
        'month = "0" & dtpMonth.Value.Month
        'Else
        'month = dtpMonth.Value.Month
        'End If
        'strDate = (dtpMonth.Value.Year + 543) & month
        vWhere = "Where DateComm = '" & strDate & "'"
        sWhere = "Where s.DateCommP = '" & strDate & "' AND "
        If chbPdT.Checked = True Then
            If txt_PdTName.Text <> "" Then
                sWhere += "s.idPdT = " & idPdT
            Else
                MessageBox.Show("กรุณาเลือกสินค้า")
                Exit Sub
            End If
        Else
            sWhere = (Microsoft.VisualBasic.Left(sWhere, sWhere.Length - 4))
        End If
        Dim Psc As New DataTable
        Psc.Clear()
        Dim Psc2 As New DataTable
        Psc2.Clear()
        Dim dTG As New DataTable
        'sCommand.CommandText = "SELECT idComm, DateComm, (CASE WHEN RIGHT(PayComm, 3) = '.00' THEN replace(PayComm, '.00', '') WHEN SUBSTRING(RIGHT(PayComm, 3), 3, 1) = '0' THEN CONVERT(varchar, FLOOR(PayComm)) + '.' + SUBSTRING(CONVERT(varchar, PARSENAME(PayComm, 1)), 1, 1) WHEN RIGHT(PayComm, 3) = '.00' AND SUBSTRING(RIGHT(PayComm, 3), 3, 1) = '0' THEN CONVERT(varchar, PayComm) END) AS PayComm," & _
        '    "(CASE WHEN RIGHT(Comm, 3) = '.00' THEN replace(Comm, '.00', '') WHEN SUBSTRING(RIGHT(Comm, 3), 3, 1) = '0' THEN CONVERT(varchar, FLOOR(Comm)) + '.' + SUBSTRING(CONVERT(varchar, PARSENAME(Comm, 1)), 1, 1) WHEN RIGHT(Comm, 3) = '.00' AND SUBSTRING(RIGHT(Comm, 3), 3, 1) = '0' THEN CONVERT(varchar, Comm) END) AS Comm " & _
        '    "FROM SmPsSaleComm " & vWhere & " ORDER BY PayComm DESC"
        sCommand.CommandText = "SELECT idComm, DateComm,PayComm, (CASE WHEN RIGHT(Comm, 3) = '.00' THEN " & _
                            "replace(Comm, '.00', '') WHEN SUBSTRING(RIGHT(Comm, 3), 3, 1) = '0' THEN " & _
                            "CONVERT(varchar, FLOOR(Comm)) + '.' + SUBSTRING(CONVERT(varchar, PARSENAME(Comm, 1)), 1, 1) " & _
                            "WHEN RIGHT(Comm, 3) = '.00' AND SUBSTRING(RIGHT(Comm, 3), 3, 1) = '0' THEN " & _
                            "CONVERT(varchar, Comm) END) AS Comm " & _
                            "FROM SmPsSaleComm " & vWhere & " AND idComp = " & sIdComp & " ORDER BY PayComm DESC"
        sAdapter.Fill(Psc)
        '"(CASE WHEN RIGHT(s.PayCommP, 3) = '.00' THEN replace(s.PayCommP, '.00', '') WHEN SUBSTRING(RIGHT(s.PayCommP, 3), 3, 1) = '0' THEN CONVERT(varchar, FLOOR(s.PayCommP)) + '.' + SUBSTRING(CONVERT(varchar, PARSENAME(s.PayCommP, 1)), 1, 1) WHEN RIGHT(s.PayCommP, 3) = '.00' AND SUBSTRING(RIGHT(s.PayCommP, 3), 3, 1) = '0' THEN CONVERT(varchar, s.PayCommP) END) AS PayComm ," & _
        sCommand.CommandText = "SELECT s.idCommP as idComm, s.DateCommP as DateComm,s.PayCommP as PayComm , " & _
                               "(CASE WHEN RIGHT(s.CommP, 3) = '.00' THEN replace(s.CommP, '.00', '') " & _
                               "WHEN SUBSTRING(RIGHT(s.CommP, 3), 3, 1) = '0' THEN " & _
                               "CONVERT(varchar, FLOOR(s.CommP)) + '.' + SUBSTRING(CONVERT(varchar, PARSENAME(s.CommP, 1)), 1, 1) " & _
                               "WHEN RIGHT(s.CommP, 3) = '.00' AND SUBSTRING(RIGHT(s.CommP, 3), 3, 1) = '0' THEN " & _
                               "CONVERT(varchar, s.CommP) END) AS Comm, s.idPdT ,v.PdTradeName, " & _
                               "(CASE WHEN RIGHT(sPd.Target, 3) = '.00' THEN replace(sPd.Target, '.00', '') " & _
                               "WHEN SUBSTRING(RIGHT(sPd.Target, 3), 3, 1) = '0' THEN CONVERT(varchar, " & _
                               "FLOOR(sPd.Target)) + '.' + SUBSTRING(CONVERT(varchar, PARSENAME(sPd.Target, 1)), 1, 1) " & _
                               "WHEN RIGHT(sPd.Target, 3) = '.00' AND SUBSTRING(RIGHT(sPd.Target, 3), 3, 1) = '0' THEN " & _
                               "CONVERT(varchar, sPd.Target) END) AS Target FROM SmPsSaleCommProduct as s " & _
                               "INNER JOIN vSlPdTradeNameD as v ON s.idPdT = v.idPdT LEFT JOIN SmMkTargetPd as sPd ON s.idPdT = sPd.idPdT " & sWhere & " AND sPd.YM = '" & strDate & "' AND s.idComp = " & sIdComp
        sAdapter.Fill(Psc2)
        dTG.Clear()
        sCommand.CommandText = "SELECT Target FROM SmMkTarget Where YM ='" & strDate & "'"
        sAdapter.Fill(dTG)
        Dim DateComm As String
        For i As Integer = 0 To Psc.Rows.Count - 1
            DateComm = Psc.Rows(i).Item("DateComm")
            DateComm = DateComm.Substring(0, 6) + "01"
            DateComm = ksbStringToDate(DateComm)
            Psc.Rows(i).Item("DateComm") = DateComm.Substring(3)
        Next
        For i As Integer = 0 To Psc2.Rows.Count - 1
            DateComm = Psc2.Rows(i).Item("DateComm")
            DateComm = DateComm.Substring(0, 6) + "01"
            DateComm = ksbStringToDate(DateComm)
            Psc2.Rows(i).Item("DateComm") = DateComm.Substring(3)
        Next
        If dTG.Rows.Count <> 0 Then
            txt_target.Text = Format(dTG.Rows(0).Item("Target"), "###,###,##0.00")
        Else
            txt_target.Text = 0
        End If
        vPsc = New DataView(Psc)
        'vPsc.Sort = "PayComm DESC"
        dgvComm.DataSource = vPsc
        ksbCountRowDgv(dgvComm, colautonum.Name)
        For i As Integer = 0 To dgvComm.Rows.Count - 1
            Dim a As Double = Psc.Rows(i).Item("PayComm")
            If i = 0 Then
                dgvComm.Rows(i).Cells(colPay.Name).Value = Format(a, "###,###,##0") & " ขึ้นไป"
            Else
                Dim b As Double = Psc.Rows(i - 1).Item("PayComm")
                dgvComm.Rows(i).Cells(colPay.Name).Value = Format(a, "###,###,##0") & " - " & Format(b - 1, "###,###,##0")
            End If
        Next
        'ksbDgvConvertNumberFormat(dgvComm, colPay.Name)
        vPsc2 = New DataView(Psc2)
        vPsc2.Sort = "PayComm DESC"
        dgvCommP.DataSource = vPsc2
        ksbCountRowDgv(dgvCommP, colautonum2.Name)
        'ksbDgvConvertNumberFormat(dgvCommP, colPayCommP.Name)
        mdDgvConvertNumberFormat(dgvCommP, colTargetPd.Name)
    End Sub
    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Dim frm As New frmPsSaleCommDetail(frmPsSaleCommDetail.eProcess.eADD, 0)
        frm.get_valueDate(strDate)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            Load_Data()
        End If
    End Sub
    Private Sub btn_add2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add2.Click
        Dim frm As New frmPsSaleCommDetail(frmPsSaleCommDetail.eProcess.eADD, 1)
        frm.get_valueDate(strDate)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            Load_Data()
        End If
    End Sub
    Private Sub btn_seed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_seed.Click
        Dim frm_s As New frmPdTSerach(frmPdTSerach.eProcess.eAll)
        frm_s.ShowDialog()
        If frm_s.idPdT > 0 Then
            idPdT = frm_s.idPdT
            txt_PdTName.Text = frm_s.PdTName
            Load_Data()
        End If
    End Sub

    Private Sub chb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbPdT.CheckedChanged
        'txt_PdTName.Enabled = chbPdT.Checked
        btn_seed.Enabled = chbPdT.Checked
        If chbPdT.Checked = False Then
            txt_PdTName.Text = ""
            Load_Data()
        End If
    End Sub

    Private Sub dgvComm_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvComm.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvComm.Columns(e.ColumnIndex).Name = coledit.Name Then
            Dim frm As New frmPsSaleCommDetail(frmPsSaleCommDetail.eProcess.eUDATE, 0)
            frm.get_value(dgvComm.Rows(e.RowIndex).Cells(col_idComm.Name).Value)
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                Load_Data()
            End If
        End If
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub dgvCommP_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCommP.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvCommP.Columns(e.ColumnIndex).Name = coledit2.Name Then
            Dim frm As New frmPsSaleCommDetail(frmPsSaleCommDetail.eProcess.eUDATE, 1)
            frm.get_value(dgvCommP.Rows(e.RowIndex).Cells(colidCommP.Name).Value)
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                Load_Data()
            End If
        End If
    End Sub
    Dim SumTotalNetY As Double
    Dim SumTotalNetM As Double
    Dim txtdatey As String
    Dim txtdatem As String
    Private Sub btn_YM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_YM.Click
        Dim dST As New DataTable
        dST.Clear()
        Dim frm As New frmMYSelect(frmMYSelect.eProcess.eYM)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            strDate = frm.str_Date
            txt_YM.Text = frm.txt_Date
            btn_add.Enabled = True
            btn_add2.Enabled = True
            strDateY = frm.str_DateY
            dST.Clear()
            sCommand.CommandText = "SELECT ISNULL(SUM(TotalSale),0.00) AS TotalNet FROM vSmSaleMt " & _
                                   "WHERE (SUBSTRING(DateSale, 1, 6) = '" & strDateY & "')"
            sAdapter.Fill(dST)
            SumTotalNetY = dST.Rows(0).Item("TotalNet")
            txtdatey = frm.txt_DateY
            lb_Y.Text = "ยอดขาย " & frm.txt_DateY
            txt_TotalNetY.Text = Format(dST.Rows(0).Item("TotalNet"), "###,###,##0.00")
            strDateM = frm.str_DateM
            dST.Clear()
            sCommand.CommandText = "SELECT ISNULL(SUM(TotalSale),0.00) AS TotalNet FROM vSmSaleMt " & _
                                   "WHERE (SUBSTRING(DateSale, 1, 6) = '" & strDateM & "')"
            sAdapter.Fill(dST)
            SumTotalNetM = dST.Rows(0).Item("TotalNet")
            txtdatem = frm.txt_DateM
            lb_M.Text = "ยอดขาย " & frm.txt_DateM
            txt_TotalNetM.Text = Format(dST.Rows(0).Item("TotalNet"), "###,###,##0.00")
            Load_Data()
            Dim target As Double = txt_target.Text.Replace(",", String.Empty)
            Dim PerY As Double = ((target - SumTotalNetY) / SumTotalNetY) * 100
            Dim PerM As Double = ((target - SumTotalNetM) / SumTotalNetM) * 100
            lb_PerY.Text = "เปอร์เซ็นส่วนต่างยอดขาย " & txtdatey
            txt_PerY.Text = Format(PerY, "##0.00") & " %"
            lb_PerM.Text = "เปอร์เซ็นส่วนต่างยอดขาย " & txtdatem
            txt_PerM.Text = Format(PerM, "##0.00") & " %"
        End If
    End Sub

    
End Class