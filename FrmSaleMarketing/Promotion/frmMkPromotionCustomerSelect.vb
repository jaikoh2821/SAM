Public Class frmMkPromotionCustomerSelect
    Public idCus As Integer = 0
    Public CusName As String = ""


    Private Sub frmMkPromotionCustomerSelect_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Sub BindData()
      
        mdCnOpen()
        Dim sDt As New DataTable

        sCommand.CommandText = "SELECT DISTINCT mt.idCus, c.CusName_, 0 As CntPro FROM SmPromotionUseMt mt " & _
                               "LEFT OUTER JOIN vCustomer c ON mt.idCus = c.idCus LEFT OUTER JOIN SmPromotionMt pro " & _
                               "ON mt.idPromotion = pro.idPromotion WHERE pro.idProType <> 1 " & _
                               "AND pro.idProType <> 6 AND mt.stApprove IS NULL " & _
                               "AND c.CusName_ Like '%" & Me.txtCus.Text & "%' ORDER BY c.CusName_"
        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูล", sSystemName)
            dgvCusPro.DataSource = sDt
            txtTotalNet.Text = Format(dgvCusPro.Rows.Count, "#,##0")
            ' SumTotal()
            Exit Sub
        Else
            For i As Integer = 0 To sDt.Rows.Count - 1
                Dim tempDt As New DataTable

                sCommand.CommandText = "SELECT DISTINCT COUNT(mt.idProUse) As CntPro FROM SmPromotionUseMt mt " & _
                                       "LEFT OUTER JOIN SmPromotionMt pro ON mt.idPromotion = pro.idPromotion " & _
                                       "WHERE pro.idProType <> 1 AND pro.idProType <> 6 AND mt.stApprove IS NULL " & _
                                       "AND mt.idCus = " & sDt.Rows(i).Item("idCus") & ""
                sAdapter.Fill(tempDt)

                sDt.Rows(i).Item("CntPro") = tempDt.Rows(0).Item("CntPro")
            Next


            dgvCusPro.DataSource = sDt
            ksbCountRowDgv(dgvCusPro, ColNum.Name)
            txtTotalNet.Text = Format(dgvCusPro.Rows.Count, "#,##0")
            'SumTotal()
        End If
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub txtCus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCus.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindData()
        End If
    End Sub

    Private Sub dgvCusPro_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCusPro.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvCusPro.Columns(e.ColumnIndex).Name = ColSelect.Name Then
            idCus = CInt(dgvCusPro.Rows(e.RowIndex).Cells(ColidCus.Name).Value)
            CusName = CStr(dgvCusPro.Rows(e.RowIndex).Cells(ColCusName.Name).Value)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub
End Class