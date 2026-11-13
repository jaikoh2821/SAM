Public Class frmSlPdoTypeData
    Dim dt1 As New DataTable
    Dim DelProductType As String = ""

    Private Sub frmMenuManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showDataOnGrid1()
    End Sub

    Private Sub showDataOnGrid1()
        mdCnOpen()
        dt1.Clear()
        sCommand.CommandText = "SELECT idPdoType, PdoTypeName, PdoTypeNote FROM SmPdOtherTypeD WHERE idPdoType <> 1 ORDER BY idPdoType"
        sAdapter.Fill(dt1)
        dgvData1.DataSource = dt1
    End Sub

    Private Sub dgvData1_RowPostPaint1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData1.RowPostPaint
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
                        Dim DtChk_idPdoType As New DataTable
                        sCommand.CommandText = "SELECT COUNT(idPdoType) As Cnt_idPdoType FROM SmPdOtherD WHERE idPdoType='" & dgvData1.Rows(e.RowIndex).Cells(idPdoType.Name).Value & "'"
                        sAdapter.Fill(DtChk_idPdoType)

                        If DtChk_idPdoType.Rows(0).Item("Cnt_idPdoType") > 0 Then
                            MessageBox.Show("ไม่สามารถลบข้อมูลนี้ได้เนื่องจาก" & Environment.NewLine & "  -  ข้อมูลถูกนำไปใช้แล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If

                        If dgvData1.Rows(e.RowIndex).Cells(idPdoType.Name).Value.ToString() <> "" Then
                            DelProductType &= "DELETE FROM SmPdOtherTypeD WHERE idPdoType=" & dgvData1.Rows(e.RowIndex).Cells(idPdoType.Name).Value & Environment.NewLine
                        End If
                        'sCommand.CommandText = "DELETE FROM SmPdOtherTypeD WHERE idPdoType='" & dgvData1.Rows(e.RowIndex).Cells(idPdoType.Name).Value & "'"
                        'sCommand.ExecuteNonQuery()
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

        Dim updateProductType As String = "UPDATE SmPdOtherTypeD SET PdoTypeName='"

        For i As Integer = 0 To dgvData1.Rows.Count - 2
            dr = dv1(i)
            If dr.Row.RowState = DataRowState.Added Then
                SQL &= "INSERT INTO SmPdOtherTypeD (PdoTypeName, PdoTypeNote) VALUES ('" & dv1.Item(i).Row.Item("PdoTypeName") & "', " & IIf(IsDBNull(dv1.Item(i).Row.Item("PdoTypeNote")), "NULL", "'" & dv1.Item(i).Row.Item("PdoTypeNote") & "'") & ")" & Environment.NewLine
            End If
            If dr.Row.RowState = DataRowState.Modified Then
                SQL &= updateProductType & dv1.Item(i).Row.Item("PdoTypeName") & "', PdoTypeNote=" & IIf(IsDBNull(dv1.Item(i).Row.Item("PdoTypeNote")), "NULL", "'" & dv1.Item(i).Row.Item("PdoTypeNote") & "'") & "  WHERE idPdoType=" & dv1.Item(i).Row.Item("idPdoType") & Environment.NewLine
            End If

            'เช็คข้อมูลซ้ำ
            dv2.RowFilter = "PdoTypeName =  '" & dv1.Item(i).Row.Item("PdoTypeName") & "'"
            If dv2.Count > 1 Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจาก " & Environment.NewLine & " -  มีประเภทการสินค้าซ้ำ ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                SQL = ""
                Exit Sub
            End If
            'เช็คข้อมูลว่าง
            If dv1.Item(i).Row.Item("PdoTypeName").ToString = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจาก" & Environment.NewLine & " -  มีประเภทการสินค้าว่าง ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                SQL = ""
                Exit Sub
            End If
        Next

        If SQL = "" And DelProductType = "" Then
            MessageBox.Show("กรุณาทำรายการก่อนกด 'บันทึก'", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'MessageBox.Show(SQL & DelProductType)
        Try
            Dim result As New DialogResult
            result = MessageBox.Show("ต้องการบันทึกข้อมูล ใช่หรือไม่ ?", "SAM", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = Windows.Forms.DialogResult.Yes Then
                mdCnOpen()
                sCommand.CommandText = SQL & DelProductType
                sCommand.ExecuteNonQuery()
                showDataOnGrid1()
                DelProductType = ""
                MessageBox.Show("ระบบได้ทำการบันทึกข้อมูลเรียบร้อยแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Class