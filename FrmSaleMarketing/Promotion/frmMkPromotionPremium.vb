Public Class frmMkPromotionPremium
    Public idInvN As Integer
    Public InvName As String

    Private Sub frmMkPromotionPremium_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        BindData()
    End Sub

    Private Sub BindData()

        Dim vDt As New DataTable
        mdLoadShow()
        mdCnOpen2()
        sCommand.CommandText = "SELECT idInv, InvName_ FROM vInventory WHERE idsection = 54 ORDER BY InvName_"
        sAdapter.Fill(vDt)
        dgvPremium.DataSource = vDt
        mdLoadCommitt()
    End Sub

    Private Sub dgvPremium_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPremium.CellClick

        If dgvPremium.Columns(e.ColumnIndex).Name = colSelect.Name Then
            idInvN = dgvPremium.Rows(e.RowIndex).Cells(colidInv.Name).Value
            InvName = dgvPremium.Rows(e.RowIndex).Cells(ColInvName.Name).Value

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub


End Class