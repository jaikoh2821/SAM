Public Class frmCusTfBankNone
    Public idCus As String = ""
    Public CusNames As String = ""
    Dim dtCus As New DataTable

    Private Sub ShowDataOnGrid()
        mdCnOpen()
        dtCus.Clear()
        sCommand.CommandText = "SELECT LTRIM(CusName) As CusName, Address, idCus " & _
                                " FROM vCustomer"
        sAdapter.Fill(dtCus)
        Dim dtCheckRepateCus As New DataTable
        dtCheckRepateCus.Clear()
        sCommand.CommandText = "SELECT idCus FROM dCusTfBank  GROUP BY idCus"
        sAdapter.Fill(dtCheckRepateCus)
        For i As Integer = 0 To dtCheckRepateCus.Rows.Count - 1
            For Each dr As DataRow In dtCus.Select("idCus=" & dtCheckRepateCus.Rows(i).Item("idCus"))
                dr.Delete()
            Next
        Next
        dgvCusNon.DataSource = dtCus
        lbCntCus.Text = cntRowsGrid(dgvCusNon)
    End Sub

    Private Sub frmCusTfBankNone_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowDataOnGrid()
    End Sub

    Private Sub dgvCusNon_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCusNon.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvCusNon.Columns(e.ColumnIndex).Name = change.Name Then
            idCus = dgvCusNon.Rows(e.RowIndex).Cells("idCus_").Value
            CusNames = dgvCusNon.Rows(e.RowIndex).Cells("CusName_").Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Function cntRowsGrid(ByVal dgvName As DataGridView) As String
        Dim cnt = "ลูกค้าที่ยังไม่ได้กำหนดธนาคาร           " & Format(dgvName.Rows.Count, "#,##0") & "           รายการ"
        Return cnt
    End Function

    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dv As New DataView(dtCus)
            dv.RowFilter = "CusName LIKE  '%" & txtSearch.Text.Trim() & "%'"
            dv.Sort = "CusName"
            dgvCusNon.DataSource = dv
            If dgvCusNon.Rows.Count < 1 Then
                MessageBox.Show("ไม่พบที่ค้นหา", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            lbCntCus.Text = cntRowsGrid(dgvCusNon)
        End If
    End Sub

    Private Sub dgvCusNon_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvCusNon.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgvCusNon.RowHeadersWidth < CInt((size.Width + 20)) Then
            dgvCusNon.RowHeadersWidth = CInt((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub
End Class