Public Class frmCompSelect
    Public mId As Integer
    Public mName As String
    Private Sub TxtPsSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCompName.KeyDown
        If e.KeyCode = Keys.Enter Then pSetData()
    End Sub
    Private Sub pSetData()
        mdCnOpen()
        Dim sDt As New DataTable
        sDs.Tables.Clear()
        sCommand.CommandText = "Select CompName,idComp From dCompanyCenter Where CompName Like '%" & txtCompName.Text & "%'  Order By CompName"
        sAdapter.Fill(sDt)
        dgvData.DataSource = sDt
    End Sub
    Private Sub dgvData_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvData.Columns(e.ColumnIndex).Name = colSelect.Name Then
            mId = CInt(dgvData.Rows(e.RowIndex).Cells(idComp.Name).Value)
            mName = CStr(dgvData.Rows(e.RowIndex).Cells(colCompName.Name).Value)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub frmCompSelect_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        pSetData()
        txtCompName.Focus()
    End Sub
End Class