Public Class frmCusBusinessSt

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

        Dim vWhere2 As String = ""
        If rbCusBuy.Checked = True Then
            vWhere2 = "AND stBusinessType = '1' "
        ElseIf rbCusSale.Checked = True Then
            vWhere2 = "AND stBusinessType = '2' "
        ElseIf rbCusBoth.Checked = True Then
            vWhere2 = "AND stBusinessType = '3' "
        ElseIf rbUnknown.Checked = True Then
            vWhere2 = "AND stBusinessType IS NULL "
        Else
            vWhere2 = ""
        End If

        mdCnOpen()
        mdLoadShow()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select CusName_,Address,NoteCusBusiness,idCus,stBusinessType From vCustomer WHERE stDel = '0' AND CusName_ IS NOT NULL AND Address IS NOT NULL" & vWhere & vWhere2 & "Order by CusName_ ASC"
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

        End If

        dgvCusBusinessSt.DataSource = sDt

        getNumChkType()

        If sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่มีข้อมูล", sSystemName)
        Else
            checkCusStatus()
        End If

        mdLoadCommitt()
        dgvCusBusinessSt.Focus()

    End Sub

    Private Sub checkCusStatus()
        For i As Integer = 0 To dgvCusBusinessSt.Rows.Count - 1
            If dgvCusBusinessSt.Rows(i).Cells(stBusinessType.Name).Value IsNot DBNull.Value Then
                If dgvCusBusinessSt.Rows(i).Cells(stBusinessType.Name).Value = "1" Then
                    dgvCusBusinessSt.Rows(i).Cells(colBuy.Name).Value = True
                ElseIf dgvCusBusinessSt.Rows(i).Cells(stBusinessType.Name).Value = "2" Then
                    dgvCusBusinessSt.Rows(i).Cells(colSale.Name).Value = True
                Else
                    dgvCusBusinessSt.Rows(i).Cells(colBuy.Name).Value = True
                    dgvCusBusinessSt.Rows(i).Cells(colSale.Name).Value = True
                End If
            End If
        Next
    End Sub

    Private Sub getNumChkType()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select stBusinessType From vCustomer WHERE stDel = '0' AND CusName_ IS NOT NULL AND Address IS NOT NULL"
        sAdapter.Fill(sDt)

        Dim countCusBuy As Integer = 0
        Dim countCusSale As Integer = 0
        Dim countCusBoth As Integer = 0
        Dim countUnknown As Integer = 0

        For i As Integer = 0 To sDt.Rows.Count - 1
            If sDt.Rows(i).Item("stBusinessType") IsNot DBNull.Value Then
                If sDt.Rows(i).Item("stBusinessType") = "1" Then
                    countCusBuy += 1
                ElseIf sDt.Rows(i).Item("stBusinessType") = "2" Then
                    countCusSale += 1
                ElseIf sDt.Rows(i).Item("stBusinessType") = "3" Then
                    countCusBoth += 1
                End If
            Else
                countUnknown += 1
            End If
        Next

        lbCusBuy.Text = countCusBuy & " ราย"
        lbCusSale.Text = countCusSale & " ราย"
        lbCusBoth.Text = countCusBoth & " ราย"
        lbUnknown.Text = countUnknown & " ราย"
        lbTotal.Text = sDt.Rows.Count & " ราย"

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

    Private Sub btnSFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSFindAll.Click
        loadData()
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

    Private Sub frmCusBusinessSt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getNumChkType()
    End Sub

    Private Sub dgvCusBusinessSt_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCusBusinessSt.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvCusBusinessSt.Columns(e.ColumnIndex).Name = colEdit.Name Then
            Dim frm As New frmCusBusinessStDetail

            Dim id As Integer = dgvCusBusinessSt.Rows(e.RowIndex).Cells(idCus.Name).Value
            Dim cusName As String = dgvCusBusinessSt.Rows(e.RowIndex).Cells(colCusName.Name).Value
            Dim address As String = dgvCusBusinessSt.Rows(e.RowIndex).Cells(colAddress.Name).Value
            Dim psName As String = dgvCusBusinessSt.Rows(e.RowIndex).Cells(colPsName.Name).Value
            Dim status As String = ""
            Dim note As String = ""

            If dgvCusBusinessSt.Rows(e.RowIndex).Cells(colNoteCusBusiness.Name).Value IsNot DBNull.Value Then
                note = dgvCusBusinessSt.Rows(e.RowIndex).Cells(colNoteCusBusiness.Name).Value
            End If

            If dgvCusBusinessSt.Rows(e.RowIndex).Cells(stBusinessType.Name).Value IsNot DBNull.Value Then
                status = dgvCusBusinessSt.Rows(e.RowIndex).Cells(stBusinessType.Name).Value
            End If

            frm.setValues(id, cusName, address, note, status, psName)
            frm.ShowDialog()

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                loadData()
            End If
        End If
    End Sub

    Private Sub dgvCusBusinessSt_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCusBusinessSt.Sorted
        checkCusStatus()
    End Sub

End Class