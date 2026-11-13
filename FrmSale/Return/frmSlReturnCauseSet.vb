Public Class frmSlReturnCauseSet
    Dim Result As DialogResult

    Private Sub frmSlReturnCauseSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showDataOnGrid()
    End Sub

    Private Sub showDataOnGrid()
        mdCnOpen()
        Dim RTDt As New DataTable
        RTDt.Clear()
        sCommand.CommandText = " Select idRtCause, ReturnCause From SmSaleReturnCause WHERE stDel IS NULL"
        sAdapter.Fill(RTDt)

        Me.dgvReturn.DataSource = RTDt
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        For i As Integer = 0 To dgvReturn.Rows.Count - 2
            If IsDBNull(dgvReturn.Rows(i).Cells("ColReturnCause").Value) Then
                MessageBox.Show("ไม่สามารถบันทึกได้ เนื่องจากมีบางรายการไม่ได้ระบุสาเหตุการรับคืนสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf dgvReturn.Rows(i).Cells("ColReturnCause").Value = "" Then
                MessageBox.Show("ไม่สามารถบันทึกได้ เนื่องจากมีบางรายการไม่ได้ระบุสาเหตุการรับคืนสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next

        mdCnOpen()
        For i As Integer = 0 To dgvReturn.Rows.Count - 2
            If dgvReturn.Rows(i).Cells("ColidRtCause").Value.ToString = "" Then
                sCommand.CommandText = "INSERT INTO SmSaleReturnCause(ReturnCause) VALUES('" & dgvReturn.Rows(i).Cells("ColReturnCause").Value & "')"
                sCommand.ExecuteNonQuery()
            Else
                sCommand.CommandText = "UPDATE SmSaleReturnCause SET ReturnCause = '" & dgvReturn.Rows(i).Cells("ColReturnCause").Value & "' " & _
                                       "Where idRtCause = '" & dgvReturn.Rows(i).Cells("ColidRtCause").Value & "' "
                sCommand.ExecuteNonQuery()
            End If
        Next

        MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        showDataOnGrid()
    End Sub

    Private Sub dgvReturn_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReturn.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        '----Delete---'
        If dgvReturn.Columns(e.ColumnIndex).Name = Me.ColDel.Name Then
            Result = MsgBox("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
            If Result = Windows.Forms.DialogResult.Yes Then
                Try
                    mdCnOpen()
                    sCommand.CommandText = "UPDATE SmSaleReturnCause SET stDel =  1 Where " & _
                                           "idRtCause = '" & dgvReturn.Rows(e.RowIndex).Cells("ColidRtCause").Value & "' "
                    sCommand.ExecuteNonQuery()

                    dgvReturn.Rows.Remove(dgvReturn.CurrentRow)
                    MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'showDataOnGrid()
                Catch ex As Exception
                    MessageBox.Show("แถวสุดท้ายของรายการไม่สามารถลบได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End Try
            End If
        End If
    End Sub

    Private Sub dgvReturn_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvReturn.RowPostPaint
        Me.dgvReturn("ColNum", e.RowIndex).Value = e.RowIndex + 1
    End Sub

End Class