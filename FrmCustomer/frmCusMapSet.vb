Public Class frmCusMapSet
    Private Sub loadData()
        Dim vWhere As String = " "
        If chkCusName.Checked = True And chkAddress.Checked = False Then
            vWhere = " AND CusName Like '%" & txtCusName.Text & "%' "
        ElseIf chkCusName.Checked = False And chkAddress.Checked = True Then
            vWhere = " AND Address Like '%" & txtAddress.Text & "%' "
        ElseIf chkCusName.Checked = True And chkAddress.Checked = True Then
            vWhere = " AND CusName Like '%" & txtCusName.Text & "%' And Address Like '%" & txtAddress.Text & "%' "
        Else
            vWhere = " "
        End If

        Dim vWhere2 As String = ""
        If chkNoMapSet.Checked = True Then
            vWhere2 = "AND ((Latitude = '' OR Latitude IS NULL) OR (Longitude = '' OR Longitude IS NULL)) "
        Else
            vWhere2 = ""
        End If

        mdCnOpen()
        mdLoadShow()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select CusName,Address,idCus,Latitude,Longitude From dCustomer WHERE stDel = '0'" & vWhere & vWhere2 & "Order by CusName ASC"
        sAdapter.Fill(sDt)
        sDt.Columns.Add("PsName")

        If sDt.Rows.Count > 0 Then

            Dim sDt2 As New DataTable
            sCommand.CommandText = "Select vPerson.PsName,SmMkCusPs.idCus From vPerson,SmMkCusPs WHERE vPerson.idPs = SmMkCusPs.idPs Order by vPerson.PsName ASC"
            sAdapter.Fill(sDt2)

            For i As Integer = 0 To sDt.Rows.Count - 1
                sDt.Rows(i).Item("PsName") = ""
                Dim first As Integer = 1
                For j As Integer = 0 To sDt2.Rows.Count - 1
                    If sDt.Rows(i).Item("idCus") = sDt2.Rows(j).Item("idCus") Then
                        If first = 1 Then
                            sDt.Rows(i).Item("PsName") &= sDt2.Rows(j).Item("PsName")
                            first = 0
                        Else
                            sDt.Rows(i).Item("PsName") &= " , " & sDt2.Rows(j).Item("PsName")
                        End If
                    End If
                Next
            Next

            If chkPsName.Checked = True And txtPsName.Text <> "" Then
                Dim k As Integer = 0

                Do While k <= sDt.Rows.Count - 1
                    If sDt.Rows(k).Item("PsName").ToString.Contains(txtPsName.Text) = False Then
                        sDt.Rows(k).Delete()
                        sDt.AcceptChanges()
                        Continue Do
                    End If
                    k += 1
                Loop
            End If
        End If

        dgvCusMapSet.DataSource = sDt

        getNumChkNoMapSet()

        If sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่มีข้อมูล")
        End If

        mdLoadCommitt()
        dgvCusMapSet.Focus()

    End Sub

    Private Sub getNumChkNoMapSet()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Latitude,Longitude From dCustomer WHERE stDel = '0' AND ((Latitude = '' OR Latitude IS NULL) OR (Longitude = '' OR Longitude IS NULL))"
        sAdapter.Fill(sDt)

        lbNoMapSet.Text = sDt.Rows.Count & " ราย"

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

    Private Sub chkPsName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPsName.CheckedChanged
        If chkPsName.Checked = True Then
            txtPsName.Enabled = True
            txtPsName.Focus()
        Else
            txtPsName.Enabled = False
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

    Private Sub txtPsName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPsName.KeyPress
        If (e.KeyChar = Chr(Keys.Enter)) Then
            loadData()
        End If
    End Sub

    Private Sub frmCusMapSet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getNumChkNoMapSet()
    End Sub

    Private Sub dgvCusMapSet_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCusMapSet.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvCusMapSet.Columns(e.ColumnIndex).Name = colEdit.Name Then
            Dim frm As New frmCusMapSetDetail

            Dim id As Integer = dgvCusMapSet.Rows(e.RowIndex).Cells(idCus.Name).Value
            Dim cusName As String = dgvCusMapSet.Rows(e.RowIndex).Cells(colCusName.Name).Value
            Dim address As String = dgvCusMapSet.Rows(e.RowIndex).Cells(colAddress.Name).Value
            Dim psName As String = dgvCusMapSet.Rows(e.RowIndex).Cells(colPsName.Name).Value
            Dim lat As String = ""
            Dim lng As String = ""

            If dgvCusMapSet.Rows(e.RowIndex).Cells(colLatitude.Name).Value IsNot DBNull.Value Then
                lat = dgvCusMapSet.Rows(e.RowIndex).Cells(colLatitude.Name).Value
            End If

            If dgvCusMapSet.Rows(e.RowIndex).Cells(colLongitude.Name).Value IsNot DBNull.Value Then
                lng = dgvCusMapSet.Rows(e.RowIndex).Cells(colLongitude.Name).Value
            End If

            frm.setValues(id, cusName, address, psName, lat, lng)
            frm.ShowDialog()

            If frm.checkChange = 1 Then
                loadData()
            End If
        End If
    End Sub
End Class