Public Class frmSetDebtCus
    Dim status As Integer

    Private Sub frmSetDebtCus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.MaxDate = Today
        DateTimePicker1.Value = Today
        loadData()
    End Sub

    Private Sub loadData()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Debt From SmDebtYear_ WHERE Year_ = '" & (DateTimePicker1.Value.Year + 543) & "'"
        sAdapter.Fill(sDt)

        Dim sDt2 As New DataTable
        sCommand.CommandText = "Select Month_,Debt From SmDebtMonth_ WHERE Year_ = '" & (DateTimePicker1.Value.Year + 543) & "'"
        sAdapter.Fill(sDt2)

        sDt2.Columns.Add("MonthName")

        If sDt.Rows.Count > 0 Then
            status = 1
            tbDebtYear.Text = Format(sDt.Rows(0).Item(0), "#,##0.00")

        Else
            tbDebtYear.Text = ""

            status = 0
            For j As Integer = 0 To 11
                Dim r As DataRow = sDt2.NewRow()
                r("Month_") = j + 1
                r("Debt") = DBNull.Value
                sDt2.Rows.Add(r) 
            Next
        End If

        For k As Integer = 0 To sDt2.Rows.Count - 1
            Select Case k
                Case 0 : sDt2.Rows(k).Item("MonthName") = "1 / มกราคม"
                Case 1 : sDt2.Rows(k).Item("MonthName") = "2 / กุมภาพันธ์"
                Case 2 : sDt2.Rows(k).Item("MonthName") = "3 / มีนาคม"
                Case 3 : sDt2.Rows(k).Item("MonthName") = "4 / เมษายน"
                Case 4 : sDt2.Rows(k).Item("MonthName") = "5 / พฤษภาคม"
                Case 5 : sDt2.Rows(k).Item("MonthName") = "6 / มิถุนายน"
                Case 6 : sDt2.Rows(k).Item("MonthName") = "7 / กรกฎาคม"
                Case 7 : sDt2.Rows(k).Item("MonthName") = "8 / สิงหาคม"
                Case 8 : sDt2.Rows(k).Item("MonthName") = "9 / กันยายน"
                Case 9 : sDt2.Rows(k).Item("MonthName") = "10 / ตุลาคม"
                Case 10 : sDt2.Rows(k).Item("MonthName") = "11 / พฤศจิกายน"
                Case 11 : sDt2.Rows(k).Item("MonthName") = "12 / ธันวาคม"

            End Select

        Next

        dgvDebt.DataSource = sDt2
    End Sub


    Private Sub dgvDebt_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDebt.EditingControlShowing

        RemoveHandler e.Control.KeyPress, AddressOf dgvDebtKeypress
        AddHandler e.Control.KeyPress, AddressOf dgvDebtKeypress

    End Sub

    Private Sub dgvDebtKeypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If CheckDigitOnly(Asc(e.KeyChar)) Then
            MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข")
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub tbDebtYear_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbDebtYear.KeyPress
        If CheckDigitOnly(Asc(e.KeyChar)) Then
            MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข")
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If tbDebtYear.Text = "" Then
            MessageBox.Show("กรุณาระบุยอดหนี้ทั้งปี")
            tbDebtYear.Focus()
        Else

            For i As Integer = 0 To dgvDebt.Rows.Count - 1
                If dgvDebt.Rows(i).Cells(colDebt.Name).Value.ToString = "" Then
                    MessageBox.Show("กรุณาระบุยอดหนี้ค้างให้ครบทุกเดือน")
                    Exit Sub
                End If
            Next

            Dim sum As Decimal = 0
            For k As Integer = 0 To dgvDebt.Rows.Count - 1
                sum += CType(dgvDebt.Rows(k).Cells(colDebt.Name).Value, Decimal)
            Next

            If sum <> CType(tbDebtYear.Text, Decimal) Then
                MessageBox.Show("บันทึกไม่ได้เนื่องจากผลรวมยอดหนี้ค้างแต่ละเดือนไม่เท่ากับยอดหนี้ทั้งปี")
            Else
                mdCnOpen()
                If status = 0 Then
                    sCommand.CommandText = "INSERT INTO SmDebtYear_ (Year_,Debt) VALUES ('" & (DateTimePicker1.Value.Year + 543) & "'," & CType(tbDebtYear.Text, Decimal) & ")"
                    sCommand.ExecuteNonQuery()

                    For j As Integer = 0 To dgvDebt.Rows.Count - 1
                        sCommand.CommandText = "INSERT INTO SmDebtMonth_ (Year_,Month_,Debt) VALUES ('" & (DateTimePicker1.Value.Year + 543) & "','" & dgvDebt.Rows(j).Cells(colMonth.Name).Value & "'," & CType(dgvDebt.Rows(j).Cells(colDebt.Name).Value, Decimal) & ")"
                        sCommand.ExecuteNonQuery()
                    Next
                Else
                    sCommand.CommandText = "UPDATE SmDebtYear_ SET Debt = " & CType(tbDebtYear.Text, Decimal) & " WHERE Year_ = '" & (DateTimePicker1.Value.Year + 543) & "'"
                    sCommand.ExecuteNonQuery()

                    For j As Integer = 0 To dgvDebt.Rows.Count - 1
                        sCommand.CommandText = "UPDATE SmDebtMonth_ SET Debt = " & CType(dgvDebt.Rows(j).Cells(colDebt.Name).Value, Decimal) & " WHERE Year_ = '" & (DateTimePicker1.Value.Year + 543) & "' AND Month_ = '" & dgvDebt.Rows(j).Cells(colMonth.Name).Value & "'"
                        sCommand.ExecuteNonQuery()
                    Next
                End If

                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว")
                loadData()
            End If

        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        loadData()
    End Sub

    Private Sub dgvDebt_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDebt.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvDebt.Columns(e.ColumnIndex).Name = colSelect.Name Then
            If status = 0 Then
                MessageBox.Show("ยังไม่ได้บันทึกข้อมูล")
            Else
                Dim frm As New frmSetDebtCusDetail

                Dim year As Integer = (DateTimePicker1.Value.Year + 543)
                Dim month As Integer = dgvDebt.Rows(e.RowIndex).Cells(colMonth.Name).Value
                Dim monthName As String = dgvDebt.Rows(e.RowIndex).Cells(colMonthName.Name).Value

                frm.setValues(year, month, monthName)
                frm.ShowDialog()
                loadData()
            End If
            
        End If
    End Sub

End Class