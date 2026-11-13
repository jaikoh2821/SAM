Public Class frmCusSelect
    Public idCusList As New List(Of Integer)
    Public cusNameList As New List(Of String)

    Private Sub loadData()
        Dim vWhere As String = " "
        If chkCusName.Checked = True And chkAddress.Checked = False Then
            vWhere = " AND CusName_ Like '%" & txtCusName.Text & "%' "
        ElseIf chkCusName.Checked = False And chkAddress.Checked = True Then
            vWhere = " AND Address Like '%" & txtAddress.Text & "%' "
        ElseIf chkCusName.Checked = True And chkAddress.Checked = True Then
            vWhere = " AND CusName_ Like '%" & txtCusName.Text & "%' And Address Like '%" & txtAddress.Text & "%' "
        Else
            vWhere = " "
        End If

        mdCnOpen()
        mdLoadShow()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select CusName_,Address,idCus From vCustomer WHERE stDel = '0' AND CusName_ IS NOT NULL AND Address IS NOT NULL" & vWhere & "Order by CusName_ ASC"
        sAdapter.Fill(sDt)

        dgvCus.DataSource = sDt

        If sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่มีข้อมูล", sSystemName)
        End If

        mdLoadCommitt()

    End Sub

    Private Sub btnSFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSFindAll.Click
        loadData()
    End Sub

    Private Sub chkCusName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCusName.CheckedChanged
        If chkCusName.Checked = True Then
            txtCusName.Enabled = True
            txtCusName.Focus()
        Else
            txtCusName.Enabled = False
        End If
    End Sub

    Private Sub chkAddress_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAddress.CheckedChanged
        If chkAddress.Checked = True Then
            txtAddress.Enabled = True
            txtAddress.Focus()
        Else
            txtAddress.Enabled = False
        End If
    End Sub

    Private Sub txtCusName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCusName.KeyPress
        If (e.KeyChar = Chr(Keys.Enter)) Then
            loadData()
        End If
    End Sub

    Private Sub txtAddress_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddress.KeyPress
        If (e.KeyChar = Chr(Keys.Enter)) Then
            loadData()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        For i As Integer = 0 To dgvCus.Rows.Count - 1
            With dgvCus.Rows(i)
                If .Cells(colCheck.Name).Value = True Then
                    idCusList.Add(.Cells(idCus.Name).Value)
                    cusNameList.Add(.Cells(colCusName.Name).Value)
                End If
            End With
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class