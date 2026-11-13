Public Class frmMkCusAddressSendDoc
    Dim sDtCustomer As New DataTable
    Dim Result As DialogResult

    Private Sub frmMkCusAddressSendDoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdCnOpen()
        sCommand.CommandText = "SELECT '' as CusName, '' as ApName, '' as PvName, ' 'as CusNameConn, '' as Address, '' as idCus, '' as Del FROM dCustomer"
        sAdapter.Fill(sDtCustomer)
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eAddressSent, sIdComp)
        vFrm.Get_DataChkBox(sDtCustomer)
        vFrm.ShowDialog()

        If vFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            dgvCustomer.DataSource = sDtCustomer
            ksbCountRowDgv(dgvCustomer, ColNum.Name)
        End If
    End Sub

    Private Sub btnShowDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDoc.Click
        Dim dGiftCusMany_ As New DataTable
        dGiftCusMany_.Clear()

        mdCnOpen()
        dGiftCusMany_.Columns.Add("idCus", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("PsRec", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("CompRec", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("AddressRec", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("TelRec", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("PsGift", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("AddressRec1", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("AddressRec2", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("AddressRec3", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("AddressRec4", System.Type.GetType("System.String"))

        Dim j As Integer = 0

        For i As Integer = 0 To Me.dgvCustomer.Rows.Count - 1
            dGiftCusMany_.Rows.Add()
            dGiftCusMany_.Rows(j).Item("idCus") = Me.dgvCustomer.Rows(i).Cells(Cusid.Name).Value
            dGiftCusMany_.Rows(j).Item("PsGift") = ""
            j = j + 1
        Next

        Dim vFrm As New frmMkGiftDocSelect(frmMkGiftDocSelect.eProcess.eDataSet2, dGiftCusMany_)
        vFrm.Show()
    End Sub

    Private Sub dgvCustomer_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomer.CellContentClick
        '----Delete---'
        If dgvCustomer.Columns(e.ColumnIndex).Name = Me.ColDel.Name Then
            Result = MsgBox("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
            If Result = Windows.Forms.DialogResult.Yes Then
                dgvCustomer.Rows.Remove(dgvCustomer.CurrentRow)
                ksbCountRowDgv(dgvCustomer, ColNum.Name)
            End If
        End If
    End Sub
End Class