Public Class frmSaleDocCode

    Private Sub frmSaleDocCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select SaleCode, Note, idSaleCode From SmSaleDocCode"
        sAdapter.Fill(sDt)
        If sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            GCNote.DataSource = sDt
            Exit Sub
        Else
            GCNote.DataSource = sDt
        End If
    End Sub

    Private Sub GVNote_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVNote.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

End Class