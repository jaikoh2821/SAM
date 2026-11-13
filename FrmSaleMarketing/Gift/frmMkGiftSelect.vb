Public Class frmMkGiftSelect
    Public pidStore As String
    Public pidInv As String
    Public pInvName_ As String
    Public pAmount As String
    Public pUnitName As String

    Private Sub frmMkGiftSelect_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ShowDatOnGrid()
    End Sub

    Private Sub ShowDatOnGrid()
        Dim sDt As New DataTable
        Dim ScreenData As String = ""

        If CHKName.Checked = True Then
            ScreenData = " AND InvName_ LIKE '%" + txtName.Text + "%' "
        Else
            ScreenData = ""
        End If

        mdLoadShow()
        mdCnOpen2()
        sCommand.CommandText = "SELECT idStore, idInv,InvName_ , Amount, UnitName, StoreName FROM vInvStock WHERE 1=1 AND idSection = 44 " + ScreenData + " ORDER BY InvName_"
        sAdapter.Fill(sDt)
        dgvData.DataSource = sDt
        mdLoadCommitt()
        If dgvData.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูล")
        End If

    End Sub

    Private Sub btn_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show.Click
        ShowDatOnGrid()
    End Sub

    Private Sub CHKName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKName.CheckedChanged
        If CHKName.Checked = True Then
            txtName.Enabled = True
        Else
            txtName.Enabled = False
        End If
    End Sub

    Private Sub dgvData_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellContentClick

        If dgvData.Columns(e.ColumnIndex).Name = colselect.Name Then
            pidStore = dgvData.Rows(e.RowIndex).Cells(idStore.Name).Value
            pidInv = dgvData.Rows(e.RowIndex).Cells(idInv.Name).Value
            pInvName_ = dgvData.Rows(e.RowIndex).Cells(InvName_.Name).Value
            pAmount = dgvData.Rows(e.RowIndex).Cells(Amount.Name).Value
            pUnitName = dgvData.Rows(e.RowIndex).Cells(UnitName.Name).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub
End Class