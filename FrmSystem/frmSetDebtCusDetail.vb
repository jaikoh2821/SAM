Public Class frmSetDebtCusDetail
    Dim idCusList As New List(Of Integer)
    Dim cusNameList As New List(Of String)
    Dim year As Integer
    Dim month As Integer
    Dim debtMonth As Decimal
    Dim aDtDebtCus As New DataTable
    Dim delIdCusList As New List(Of Integer)

    Public Sub setValues(ByVal y As Integer, ByVal m As Integer, ByVal monthName As String)
        year = y
        month = m

        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Debt From SmDebtMonth_ WHERE Year_ = '" & year & "' AND Month_ = '" & month & "'"
        sAdapter.Fill(sDt)

        debtMonth = sDt.Rows(0).Item(0)

        Label1.Text = "ปี " & year & " เดือน " & monthName & " มียอดหนี้ค้าง : " & Format(debtMonth, "#,##0.00") & " บาท"

    End Sub

    Private Sub loadData()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select v.CusName_,s.Debt,v.idCus From vCustomer v,SmDebtCus_ s WHERE v.idCus = s.idCus AND s.Year_ = '" & year & "' AND s.Month_ = '" & month & "' Order by v.CusName_ ASC"
        sAdapter.Fill(sDt)
        aDtDebtCus = sDt

        aDtDebtCus.Columns.Add("status")
        For i As Integer = 0 To aDtDebtCus.Rows.Count - 1
            aDtDebtCus.Rows(i).Item("status") = 1
        Next
        dgvDebtCus.DataSource = aDtDebtCus
    End Sub

    Private Sub btPkSelect2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPkSelect2.Click
        Dim frm As New frmCusSelect

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            idCusList = frm.idCusList
            cusNameList = frm.cusNameList

            For i As Integer = 0 To idCusList.Count - 1
                Dim checkDup As Integer = 0
                For j As Integer = 0 To dgvDebtCus.Rows.Count - 1
                    If dgvDebtCus.Rows(j).Cells(idCus.Name).Value = idCusList(i) Then
                        checkDup = 1
                    End If
                Next

                If checkDup = 0 Then
                    Dim r As DataRow = aDtDebtCus.NewRow()
                    r("CusName_") = cusNameList(i)
                    r("idCus") = idCusList(i)
                    r("status") = 0

                    aDtDebtCus.Rows.Add(r)
                End If
                
            Next

            dgvDebtCus.DataSource = aDtDebtCus
        End If
    End Sub

    Private Sub frmSetDebtCusDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub dgvDebtCus_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDebtCus.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvDebtCus.Columns(e.ColumnIndex).Name = colDel.Name Then
            If dgvDebtCus.Rows(e.RowIndex).Cells(status.Name).Value = 1 Then
                delIdCusList.Add(dgvDebtCus.Rows(e.RowIndex).Cells(idCus.Name).Value)
            End If

            For i As Integer = 0 To aDtDebtCus.Rows.Count - 1
                If aDtDebtCus.Rows(i).Item("idCus") = dgvDebtCus.Rows(e.RowIndex).Cells(idCus.Name).Value Then
                    aDtDebtCus.Rows(i).Delete()
                    aDtDebtCus.AcceptChanges()
                    Exit For
                End If
            Next

            dgvDebtCus.DataSource = aDtDebtCus

        End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        For i As Integer = 0 To dgvDebtCus.Rows.Count - 1
            If dgvDebtCus.Rows(i).Cells(colDebt.Name).Value.ToString = "" Then
                MessageBox.Show("กรุณาระบุยอดหนี้ค้างให้ครบทุกราย")
                Exit Sub
            End If
        Next

        Dim sum As Decimal = 0
        For k As Integer = 0 To dgvDebtCus.Rows.Count - 1
            sum += CType(dgvDebtCus.Rows(k).Cells(colDebt.Name).Value, Decimal)
        Next

        If sum <> debtMonth Then
            MessageBox.Show("บันทึกไม่ได้เนื่องจากผลรวมยอดหนี้ค้างแต่ละรายไม่เท่ากับยอดหนี้ทั้งเดือน")
        Else
            mdCnOpen()
            For j As Integer = 0 To dgvDebtCus.Rows.Count - 1
                If dgvDebtCus.Rows(j).Cells(status.Name).Value = 0 Then
                    sCommand.CommandText = "INSERT INTO SmDebtCus_ (idCus,Year_,Month_,Debt) VALUES (" & dgvDebtCus.Rows(j).Cells(idCus.Name).Value & ",'" & year & "','" & month & "'," & CType(dgvDebtCus.Rows(j).Cells(colDebt.Name).Value, Decimal) & ")"
                Else
                    sCommand.CommandText = "UPDATE SmDebtCus_ SET Debt = " & CType(dgvDebtCus.Rows(j).Cells(colDebt.Name).Value, Decimal) & " WHERE idCus = " & dgvDebtCus.Rows(j).Cells(idCus.Name).Value & " AND Year_ = '" & year & "' AND Month_ = '" & month & "'"
                End If

                sCommand.ExecuteNonQuery()

            Next

            For l As Integer = 0 To delIdCusList.Count - 1
                sCommand.CommandText = "Delete From SmDebtCus_ WHERE idCus = " & delIdCusList(l) & " AND Year_ = '" & year & "' AND Month_ = '" & month & "'"
                sCommand.ExecuteNonQuery()
            Next
            delIdCusList.Clear()
            
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว")
            loadData()
        End If

    End Sub

    Private Sub dgvDebtCus_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDebtCus.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf dgvDebCustKeypress
        AddHandler e.Control.KeyPress, AddressOf dgvDebCustKeypress
    End Sub

    Private Sub dgvDebCustKeypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If CheckDigitOnly(Asc(e.KeyChar)) Then
            MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข")
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
End Class