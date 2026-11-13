Public Class frmMkGiftCauseData
    Dim Result As DialogResult

    Private Sub frmMkGiftCauseData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sDt As New DataTable
        mdCnOpen()
        sCommand.CommandText = "Select * From MkGiftCauseD"
        sAdapter.Fill(sDt)
        dgv_GiftCus.DataSource = sDt
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim GCDup As String
        Dim GC As String
        Dim chk As Integer = 0
        Dim chk_row As Integer = 0

        For i As Integer = 0 To dgv_GiftCus.Rows.Count - 2
            With dgv_GiftCus.Rows(i)
                chk_row = 0
                GC = .Cells("ColCase").Value.ToString
                If GC = "" Then
                    MessageBox.Show("กรุณากรอกวัตถุประสงค์การแจกของ", sSystemName)
                    Exit Sub
                End If
            End With

            For j As Integer = 0 To dgv_GiftCus.Rows.Count - 2
                With dgv_GiftCus.Rows(j)
                    GCDup = .Cells("ColCase").Value.ToString
                End With

                If GC = GCDup Then
                    chk_row = chk_row + 1
                    If chk_row > 1 Then
                        MessageBox.Show("วัตถุประสงค์การแจกของซ้ำกับข้อมูลเดิม", sSystemName)
                        Exit Sub
                    End If
                End If
            Next
        Next

        For i As Integer = 0 To dgv_GiftCus.Rows.Count - 2
            chk = 1
            Dim vWhere As String = ""
            If dgv_GiftCus.Rows(i).Cells("ColidGC").Value.ToString = "" Then
                sCommand.CommandText = "Insert Into MkGiftCauseD(Cause, Note)"
                sCommand.CommandText &= " Values('" & dgv_GiftCus.Rows(i).Cells("ColCase").Value & "','" & dgv_GiftCus.Rows(i).Cells("Colnote").Value & "')"
                sCommand.ExecuteNonQuery()
            Else
                vWhere = " Where idGC='" & dgv_GiftCus.Rows(i).Cells("ColidGC").Value & "'"
                sCommand.CommandText = "Update MkGiftCauseD Set Cause='" & dgv_GiftCus.Rows(i).Cells("ColCase").Value & "',Note='" & dgv_GiftCus.Rows(i).Cells("Colnote").Value & "'" & vWhere
                sCommand.ExecuteNonQuery()
            End If
        Next

        If chk = 0 Then
            MessageBox.Show("กรุณาระบุวัตถุประสงค์การแจกของ", sSystemName)
        Else
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName)

            mdCnOpen()
            Dim Dt As New DataTable
            Dt.Clear()
            sCommand.CommandText = " Select * From MkGiftCauseD"
            sAdapter.Fill(Dt)
            dgv_GiftCus.DataSource = Dt
            'ksbCountRowDgv(dgv_GiftCus, colCount.Name)
        End If
    End Sub

    Private Sub dgv_GiftCus_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_GiftCus.CellContentClick
        If dgv_GiftCus.Columns(e.ColumnIndex).Name = Me.colDel.Name Then
            Dim ChkDelDt As New DataTable
            sCommand.CommandText = " Select idGC From MkGiftCusMt Where idGC ='" & dgv_GiftCus.Rows(e.RowIndex).Cells("ColidGC").Value & "'"
            sAdapter.Fill(ChkDelDt)
            If ChkDelDt.Rows.Count <> 0 Then
                MessageBox.Show("ไม่สามารถลบได้ ข้อมูลนี้มีการนำไปใช้แล้ว", sSystemName)
            Else
                Result = MsgBox("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", MsgBoxStyle.YesNo, sSystemName)
                If Result = Windows.Forms.DialogResult.Yes Then
                    Dim del_Dt As New DataTable
                    del_Dt.Clear()
                    sCommand.CommandText = " Select Cause,Note From MkGiftCauseD Where idGC ='" & dgv_GiftCus.Rows(e.RowIndex).Cells("ColidGC").Value & "'"
                    sAdapter.Fill(del_Dt)

                    If del_Dt.Rows.Count <> 0 Then 'have information
                        sCommand.CommandText = "DELETE FROM MkGiftCauseD WHERE idGC ='" & dgv_GiftCus.Rows(e.RowIndex).Cells("ColidGC").Value & "' "
                        sCommand.ExecuteNonQuery()
                        dgv_GiftCus.Rows.Remove(dgv_GiftCus.CurrentRow)
                    Else
                        Try
                            dgv_GiftCus.Rows.Remove(dgv_GiftCus.CurrentRow)
                        Catch ex As Exception
                            Exit Try
                        End Try

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgv_GiftCus_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgv_GiftCus.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgv_GiftCus.RowHeadersWidth < CInt((size.Width + 20)) Then
            dgv_GiftCus.RowHeadersWidth = CInt((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, _
                              e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) _
                                                      / 2))
    End Sub
End Class