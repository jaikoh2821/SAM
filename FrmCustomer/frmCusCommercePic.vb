
Public Class frmCusCommercePic

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
        If chkNoCusCard.Checked = True Then
            vWhere2 = "AND (stPicCard = '0' OR stPicCard IS NULL) "
        Else
            vWhere2 = ""
        End If

        Dim vWhere3 As String = ""
        If chkNoCusRegistration.Checked = True Then
            vWhere3 = "AND (stPicRegist = '0' OR stPicRegist IS NULL) "
        Else
            vWhere3 = ""
        End If

        Dim vWhere4 As String = ""
        If chkNoCusCommercial.Checked = True Then
            vWhere4 = "AND (stCusComm = '0' OR stCusComm IS NULL) "
        Else
            vWhere4 = ""
        End If

        Dim vWhere5 As String = ""
        If chkNoCusBusiness.Checked = True Then
            vWhere5 = "AND (stCusBusiness = '0' OR stCusBusiness IS NULL) "
        Else
            vWhere5 = ""
        End If

        Dim vWhere6 As String = ""
        If chkNoCusBusinessEtc.Checked = True Then
            vWhere6 = "AND (stCusBusinessEtc = '0' OR stCusBusinessEtc IS NULL) "
        Else
            vWhere6 = ""
        End If


        mdCnOpen()
        mdLoadShow()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select CusName_,Address,idCus,stPicCard,stPicRegist,stCusComm,stCusBusiness,stCusBusinessEtc From vCustomer WHERE stDel = '0'" & vWhere & vWhere2 & vWhere3 & vWhere4 & vWhere5 & vWhere6 & "Order by CusName ASC"
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

        dgvCusComPic.DataSource = sDt

        getNumChkNo()

        If sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่มีข้อมูล")
        Else
            checkCusComPic()
        End If

        mdLoadCommitt()
        dgvCusComPic.Focus()

    End Sub

    Private Sub getNumChkNo()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select stPicCard,stPicRegist,stCusComm,stCusBusiness,stCusBusinessEtc From dCustomer WHERE stDel = '0'"
        sAdapter.Fill(sDt)

        Dim countStPicCard As Integer = 0
        Dim countStPicRegist As Integer = 0
        Dim countStCusComm As Integer = 0
        Dim countStCusBusiness As Integer = 0
        Dim countStCusBusinessEtc As Integer = 0

        For i As Integer = 0 To sDt.Rows.Count - 1
            If sDt.Rows(i).Item("stPicCard") IsNot DBNull.Value Then
                If sDt.Rows(i).Item("stPicCard") = "0" Then
                    countStPicCard += 1
                End If
            Else
                countStPicCard += 1
            End If

            If sDt.Rows(i).Item("stPicRegist") IsNot DBNull.Value Then
                If sDt.Rows(i).Item("stPicRegist") = "0" Then
                    countStPicRegist += 1
                End If
            Else
                countStPicRegist += 1
            End If

            If sDt.Rows(i).Item("stCusComm") IsNot DBNull.Value Then
                If sDt.Rows(i).Item("stCusComm") = "0" Then
                    countStCusComm += 1
                End If
            Else
                countStCusComm += 1
            End If

            If sDt.Rows(i).Item("stCusBusiness") IsNot DBNull.Value Then
                If sDt.Rows(i).Item("stCusBusiness") = "0" Then
                    countStCusBusiness += 1
                End If
            Else
                countStCusBusiness += 1
            End If

            If sDt.Rows(i).Item("stCusBusinessEtc") IsNot DBNull.Value Then
                If sDt.Rows(i).Item("stCusBusinessEtc") = "0" Then
                    countStCusBusinessEtc += 1
                End If
            Else
                countStCusBusinessEtc += 1
            End If
        Next

        lbNoCusCard.Text = countStPicCard & " ราย"
        lbNoCusRegistration.Text = countStPicRegist & " ราย"
        lbNoCusCommercial.Text = countStCusComm & " ราย"
        lbNoCusBusiness.Text = countStCusBusiness & " ราย"
        lbNoCusBusinessEtc.Text = countStCusBusinessEtc & " ราย"
    End Sub

    Private Sub checkCusComPic()
        For i As Integer = 0 To dgvCusComPic.Rows.Count - 1
            If dgvCusComPic.Rows(i).Cells(stPicCard.Name).Value IsNot DBNull.Value Then
                If dgvCusComPic.Rows(i).Cells(stPicCard.Name).Value = "1" Then
                    dgvCusComPic.Rows(i).Cells(colCusCard.Name).Value = True
                End If
            End If
            If dgvCusComPic.Rows(i).Cells(stPicRegist.Name).Value IsNot DBNull.Value Then
                If dgvCusComPic.Rows(i).Cells(stPicRegist.Name).Value = "1" Then
                    dgvCusComPic.Rows(i).Cells(colCusRegistration.Name).Value = True
                End If
            End If
            If dgvCusComPic.Rows(i).Cells(stCusComm.Name).Value IsNot DBNull.Value Then
                If dgvCusComPic.Rows(i).Cells(stCusComm.Name).Value = "1" Then
                    dgvCusComPic.Rows(i).Cells(colCusCommercial.Name).Value = True
                End If
            End If
            If dgvCusComPic.Rows(i).Cells(stCusBusiness.Name).Value IsNot DBNull.Value Then
                If dgvCusComPic.Rows(i).Cells(stCusBusiness.Name).Value = "1" Then
                    dgvCusComPic.Rows(i).Cells(colCusBusiness.Name).Value = True
                End If
            End If
            If dgvCusComPic.Rows(i).Cells(stCusBusinessEtc.Name).Value IsNot DBNull.Value Then
                If dgvCusComPic.Rows(i).Cells(stCusBusinessEtc.Name).Value = "1" Then
                    dgvCusComPic.Rows(i).Cells(colCusBusinessEtc.Name).Value = True
                End If
            End If
        Next
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

    Private Sub dgvCusComPic_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCusComPic.Sorted
        checkCusComPic()
    End Sub

    Private Sub dgvCusComPic_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCusComPic.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvCusComPic.Columns(e.ColumnIndex).Name = colEdit.Name Then
            Dim frm As New frmCusCommercePicDetail

            Dim id As Integer = dgvCusComPic.Rows(e.RowIndex).Cells(idCus.Name).Value
            Dim cusName As String = dgvCusComPic.Rows(e.RowIndex).Cells(colCusName.Name).Value
            Dim address As String = dgvCusComPic.Rows(e.RowIndex).Cells(colAddress.Name).Value
            Dim psName As String = dgvCusComPic.Rows(e.RowIndex).Cells(colPsName.Name).Value

            frm.setValues(id, cusName, address, psName)
            frm.ShowDialog()

            If frm.checkChange = 1 Then
                loadData()
            End If
        End If
    End Sub

    Private Sub frmCusCommercePic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getNumChkNo()
    End Sub
End Class