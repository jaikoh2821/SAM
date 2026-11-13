Public Class frmSlReturnDocCode
    Dim Result As DialogResult

    Private Sub frmSlReturnDocCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showDataOnGrid()
    End Sub

    Private Sub showDataOnGrid()
        mdCnOpen()
        Dim RTDt As New DataTable
        RTDt.Clear()
        sCommand.CommandText = " Select idRTDocCode, ReturnCode, Note From SmSaleReturnCode WHERE stDel IS NULL"
        sAdapter.Fill(RTDt)

        Me.dgvReturnCode.DataSource = RTDt
    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        For i As Integer = 0 To dgvReturnCode.Rows.Count - 2
            If IsDBNull(dgvReturnCode.Rows(i).Cells("ColReturnCode").Value) Then
                MessageBox.Show("ไม่สามารถบันทึกได้ เนื่องจากมีบางรายการไม่ได้ระบุรหัสเอกสาร", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf dgvReturnCode.Rows(i).Cells("ColReturnCode").Value = "" Then
                MessageBox.Show("ไม่สามารถบันทึกได้ เนื่องจากมีบางรายการไม่ได้ระบุรหัสเอกสาร", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'For j As Integer = 0 To dgvReturnCode.Rows.Count - 2
            '    If dgvReturnCode.Rows(i).Cells("ColReturnCode").Value = dgvReturnCode.Rows(j).Cells("ColReturnCode").Value Then
            '        MessageBox.Show("ไม่สามารถบันทึกได้ เนื่องจากมีรหัสเอกสารซ้ำกัน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '        Exit Sub
            '    End If
            'Next
        Next

        mdCnOpen()
        For i As Integer = 0 To dgvReturnCode.Rows.Count - 2
            If dgvReturnCode.Rows(i).Cells("ColidRTDocCode").Value.ToString = "" Then
                sCommand.CommandText = "INSERT INTO SmSaleReturnCode(ReturnCode, Note) VALUES('" & dgvReturnCode.Rows(i).Cells("ColReturnCode").Value & "', " & _
                                       "'" & dgvReturnCode.Rows(i).Cells("ColNote").Value & "')"
                sCommand.ExecuteNonQuery()
            Else
                sCommand.CommandText = "UPDATE SmSaleReturnCode SET ReturnCode = '" & dgvReturnCode.Rows(i).Cells("ColReturnCode").Value & "', " & _
                                       "Note = '" & dgvReturnCode.Rows(i).Cells("ColNote").Value & "'" & _
                                       "Where idRTDocCode = '" & dgvReturnCode.Rows(i).Cells("ColidRTDocCode").Value & "' "
                sCommand.ExecuteNonQuery()
            End If
        Next

        MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        showDataOnGrid()

    End Sub

    Private Sub dgvReturnCode_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReturnCode.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        '----Delete---'
        If dgvReturnCode.Columns(e.ColumnIndex).Name = Me.ColDel.Name Then
            Result = MsgBox("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
            If Result = Windows.Forms.DialogResult.Yes Then
                Try
                    mdCnOpen()
                    sCommand.CommandText = "UPDATE SmSaleReturnCode SET stDel =  1 Where " & _
                                           "idRTDocCode = '" & dgvReturnCode.Rows(e.RowIndex).Cells("ColidRTDocCode").Value & "' "
                    sCommand.ExecuteNonQuery()

                    dgvReturnCode.Rows.Remove(dgvReturnCode.CurrentRow)
                    MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'showDataOnGrid()
                Catch ex As Exception
                    MessageBox.Show("แถวสุดท้ายของรายการไม่สามารถลบได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End Try
            End If
        End If

    End Sub

End Class
