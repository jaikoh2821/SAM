Public Class frmCusBusinessStDetail
    Dim idCus As Integer

    Public Sub setValues(ByVal id As Integer, ByVal cusName As String, ByVal address As String, ByVal note As String, ByVal st As String, ByVal psName As String)
        idCus = id
        lbCusName.Text = cusName
        lbAddress.Text = address
        lbPsName.Text = psName
        tbNote.Text = note

        If st = "1" Then
            cbBuy.Checked = True
        ElseIf st = "2" Then
            cbSale.Checked = True
        ElseIf st = "3" Then
            cbBuy.Checked = True
            cbSale.Checked = True
        End If

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If cbBuy.Checked = False And cbSale.Checked = False Then
            MessageBox.Show("กรุณาเลือกสถานะ", sSystemName)
        Else
            Dim status As String
            If cbBuy.Checked = True And cbSale.Checked = False Then
                status = "1"
            ElseIf cbBuy.Checked = False And cbSale.Checked = True Then
                status = "2"
            Else
                status = "3"
            End If
            mdCnOpen()
            sCommand.CommandText = "UPDATE dCustomer SET  NoteCusBusiness = '" & tbNote.Text & "',stBusinessType = '" & status & "' Where idCus = " & idCus
            sCommand.ExecuteNonQuery()

            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName)
            DialogResult = Windows.Forms.DialogResult.OK

        End If
    End Sub
End Class