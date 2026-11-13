Public Class frmNoteRejectReturn
    Public txtReject As String = ""
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtNote.Text.Trim = "" Or txtNote.Text.Trim = "0" Or txtNote.Text.Trim = "-" Or txtNote.Text.Trim.Length < 5 Then
            MessageBox.Show("กรุณาระบุสาเหตุ Reject ให้ชัดเจน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            txtReject = txtNote.Text.Trim

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmNoteRejectReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtNote.Focus()
    End Sub
End Class