Public Class frmTspType
    Dim dt1 As New DataTable
    Dim DelTspType As String = ""

    Private Sub frmMenuManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showDataOnGrid1()
    End Sub

    Private Sub showDataOnGrid1()
        mdCnOpen()
        dt1.Clear()
        sCommand.CommandText = "SELECT idTspType, TspCode, TspTypeName, Note FROM dTspType WHERE idTspType <> 1 ORDER BY TspTypeName"
        sAdapter.Fill(dt1)
        dgvData1.DataSource = dt1
    End Sub

    Private Sub dgvExpense_RowPostPaint1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData1.RowPostPaint
        Me.dgvData1("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Private Sub dgvData1_RowsAdded_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvData1.RowsAdded
        For i As Integer = 0 To dgvData1.Rows.Count - 1
            dgvData1.Rows(i).Cells(del.Name).Value = My.Resources.ResourceManager.GetObject("Actions-button-cancel-icon (1)")
        Next
    End Sub

    Private Sub dgvData1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData1.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Try
            If dgvData1.Columns(e.ColumnIndex).Name = del.Name Then

                If Me.dgvData1.Rows.Count <> 1 Then
                    Dim Result As MsgBoxResult
                    Result = MessageBox.Show("คุณต้องการลบข้อมูลนี้ ใช่หรือไม่  ?", "SAM", MessageBoxButtons.YesNo, _
                                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If Result = MsgBoxResult.Yes Then
                        mdCnOpen()
                        'เช็คข้อมูลถูกนำไปใช้หรือยัง
                        Dim chk_idTspType As New DataTable
                        sCommand.CommandText = "SELECT COUNT(idTspType) As Cnt_idTspType FROM dTsp WHERE idTspType='" & dgvData1.Rows(e.RowIndex).Cells(idTspType.Name).Value & "'"
                        sAdapter.Fill(chk_idTspType)

                        If chk_idTspType.Rows(0).Item("Cnt_idTspType") > 0 Then
                            MessageBox.Show("ไม่สามารถลบข้อมูลนี้ได้เนื่องจาก" & Environment.NewLine & "  -  ข้อมูลถูกนำไปใช้แล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If

                        If dgvData1.Rows(e.RowIndex).Cells(idTspType.Name).Value.ToString() <> "" Then
                            DelTspType &= "DELETE FROM dTspType WHERE idTspType='" & dgvData1.Rows(e.RowIndex).Cells(idTspType.Name).Value & "'"
                        End If
                        Me.dt1.Rows.RemoveAt(e.RowIndex)
                    End If
                End If
            End If
        Catch ex As Exception
            Try
                Me.dgvData1.Rows.RemoveAt(e.RowIndex)
            Catch exc As Exception
                MessageBox.Show("ไม่สามารถลบแถวนี้ได้", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Try
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim SQL As String = ""
        Dim dv1 As New DataView(dt1)
        Dim dv2 As New DataView(dt1)
        Dim dr As DataRowView

        Dim updateTspType As String = "UPDATE dTspType SET TspTypeName='"
        For i As Integer = 0 To dgvData1.Rows.Count - 2
            dr = dv1(i)
            If dr.Row.RowState = DataRowState.Added Then
                SQL &= "INSERT INTO dTspType (TspCode, TspTypeName, Note) VALUES ('" & dv1.Item(i).Row.Item("TspCode") & "', '" & dv1.Item(i).Row.Item("TspTypeName") & "','" & dv1.Item(i).Row.Item("Note") & "')" & Environment.NewLine
            End If
            If dr.Row.RowState = DataRowState.Modified Then
                SQL &= updateTspType & dv1.Item(i).Row.Item("TspTypeName") & "', TspCode = '" & dv1.Item(i).Row.Item("TspCode") & "', Note='" & dv1.Item(i).Row.Item("Note") & "' WHERE idTspType='" & dv1.Item(i).Row.Item("idTspType") & "'" & Environment.NewLine
            End If
            'เช็คข้อมูลซ้ำ
            dv2.RowFilter = "TspTypeName =  '" & dv1.Item(i).Row.Item("TspTypeName") & "'"
            If dv2.Count > 1 Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจาก " & Environment.NewLine & " -  มีประเภทการขนส่งซ้ำ ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                SQL = ""
                Exit Sub
            End If
            'เช็คข้อมูลว่าง
            If dv1.Item(i).Row.Item("TspTypeName").ToString = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจาก" & Environment.NewLine & " -  มีประเภทการขนส่งว่าง ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                SQL = ""
                Exit Sub
            End If

            'เช็คข้อมูลซ้ำ
            dv2.RowFilter = "TspCode =  '" & dv1.Item(i).Row.Item("TspCode") & "'"
            If dv2.Count > 1 Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจาก " & Environment.NewLine & " -  มีรหัสการขนส่งซ้ำ ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                SQL = ""
                Exit Sub
            End If
            'เช็คข้อมูลว่าง
            If dv1.Item(i).Row.Item("TspCode").ToString = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจาก" & Environment.NewLine & " -  มีรหัสการขนส่งว่าง ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                SQL = ""
                Exit Sub
            End If
        Next

        If SQL = "" And DelTspType = "" Then
            MessageBox.Show("กรุณาทำรายการก่อนกด 'บันทึก'", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'MessageBox.Show(SQL & DelTspType)
        Try
            Dim result As New DialogResult
            result = MessageBox.Show("ต้องการบันทึกข้อมูล ใช่หรือไม่ ?", "SAM", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = Windows.Forms.DialogResult.Yes Then
                mdCnOpen()
                sCommand.CommandText = SQL & DelTspType
                sCommand.ExecuteNonQuery()
                showDataOnGrid1()
                DelTspType = ""
                MessageBox.Show("ระบบได้ทำการบันทึกข้อมูลเรียบร้อยแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Class
