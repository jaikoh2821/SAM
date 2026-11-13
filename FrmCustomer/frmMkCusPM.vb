Public Class frmMkCusPM
    Dim sDt As New DataTable
    Dim sDt2 As New DataTable
    Dim sDt3 As New DataTable
    Dim sDt4 As New DataTable
    Dim sDt5 As New DataTable
    Dim vWhere As String = " 1=1 AND stDel = '0' "
    Dim sWhere As String = " 1=1 AND stDel = '0' "
    Dim flag As String = 0
    Dim psubtype As String = ""
    Private Sub changimg()
        For i As Integer = 0 To dgvDataCus.Rows.Count - 1
            dgvDataCus.Rows(i).Cells(colCancel.Name).Value = My.Resources.ResourceManager.GetObject("cross_circle_frame")
        Next
    End Sub
    Private Sub dgvExpense_RowPostPaint2(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvDataCus.RowPostPaint
        Me.dgvDataCus("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub
    Private Sub dgvExpense_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvDataCus2.RowPostPaint
        Me.dgvDataCus2("autonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub
    Private Sub frmMkCusPM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        mdCnOpen()
        Dim sDt As New DataTable
        Dim sDtTemp As New DataTable
        sCommand.CommandText = "SELECT * FROM SmPaymentTermsD Order by idPM ASC"
        sAdapter.Fill(sDt)

        'For i As Integer = 0 To sDt.Rows.Count
        selectPmType.DataSource = sDt
        selectPmType.DisplayMember = "PaymentTerms"
        selectPmType.ValueMember = "idPM"
        'Next
        mdCnOpen()
        ShowDataOnGrid(vWhere)
        ShowDataOnGrid2(sWhere)
        mdLoadCommitt()
        flag = 1
    End Sub

    Private Sub ShowDataOnGrid2(ByVal vWhere As String)
        psubtype = selectPmType.SelectedValue.ToString
        Dim searchedValue As String
        Dim searchedValue2 As String
        Dim j As Integer = 0
        mdCnOpen()
        sDt.Clear()
        sCommand.CommandText = "SELECT  idCus, CusName_ , Address, SmPaymentTermsD.idPM , PaymentTerms FROM vCustomer LEFT OUTER JOIN SmPaymentTermsD ON vCustomer.idPM = SmPaymentTermsD.idPM WHERE " + vWhere
        sAdapter.Fill(sDt)
        sDt2 = sDt4
        dgvDataCus.DataSource = sDt2

        For i As Integer = 0 To dgvDataCus.Rows.Count - 1
            searchedValue = dgvDataCus.Rows(i).Cells(idCus.Name).Value
            Do While j <= dgvDataCus2.Rows.Count - 1
                searchedValue2 = dgvDataCus2.Rows(j).Cells(idCus2.Name).Value
                If searchedValue2 = searchedValue Then
                    sDt.Rows(j).Delete()
                    sDt.AcceptChanges()
                End If
                j += 1
            Loop
            j = 0
        Next
        dgvDataCus2.DataSource = sDt
        If dgvDataCus2.RowCount = 0 Then
            MessageBox.Show("ไม่พบข้อมูล")
        End If

        sDt3 = sDt
        sDt4 = sDt2
        changimg()

    End Sub
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pidCus As String
        Dim answer As DialogResult
        Dim i As Integer = 0
        answer = MessageBox.Show("ยืนยันการบันทึก", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If answer = vbYes Then
            mdLoadShow()
            mdCnOpen()

            For i = 0 To dgvDataCus2.Rows.Count - 1
                pidCus = dgvDataCus2.Rows(i).Cells(idCus2.Name).Value
                sCommand.CommandText = "UPDATE dCustomer SET idPM =" & selectPmType.SelectedValue.ToString & " WHERE idCus = " + pidCus
                sCommand.ExecuteNonQuery()
            Next
            ShowDataOnGrid(vWhere)
            mdLoadCommitt()
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim ptxtsname As String = txtsname.Text
        If CHKname.Checked = True Then
            vWhere = " stDel = '0' AND CusName_ LIKE '%" & txtsname.Text & "%' "
        End If
        mdLoadShow()
        ShowDataOnGrid2(vWhere)
        mdLoadCommitt()
    End Sub

    Private Sub selectPmType_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectPmType.SelectionChangeCommitted
        mdLoadShow()
        Dim sDt_Temp As New DataTable
        sDt_Temp.Clear()

        psubtype = selectPmType.SelectedValue.ToString
        sWhere = " (vCustomer.idPM is null or vCustomer.idPM <> " & psubtype & " ) AND stDel = '0' ORDER BY CusName_ "
        ShowDataOnGrid(sWhere)
        sDt5.Clear()
        sCommand.CommandText = "SELECT  idCus, CusName_, Address, SmPaymentTermsD.idPM, PaymentTerms FROM vCustomer LEFT OUTER JOIN SmPaymentTermsD ON vCustomer.idPM = SmPaymentTermsD.idPM WHERE vCustomer.idPM = " & psubtype & " AND stDel = '0' ORDER BY CusName_"
        sAdapter.Fill(sDt5)
        sCommand.CommandText = "SELECT * FROM SmPaymentTermsD WHERE idPM = " & psubtype
        sAdapter.Fill(sDt_Temp)
        mdLoadCommitt()
    End Sub

    Private Sub btn_save_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim pidCus As String
        Dim answer As DialogResult
        Dim i As Integer = 0
        answer = MessageBox.Show("ยืนยันการบันทึก", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        sCommand.CommandText = "SELECT  idCus, CusName_, Address, SmPaymentTermsD.idPM, PaymentTerms FROM vCustomer LEFT OUTER JOIN SmPaymentTermsD ON vCustomer.idPM = SmPaymentTermsD.idPM WHERE vCustomer.idPM = " & psubtype & " AND stDel = '0' ORDER BY CusName_"
        sAdapter.Fill(sDt5)
        If answer = vbYes Then
            mdLoadShow()
            mdCnOpen()

            For i = 0 To sDt5.Rows.Count - 1
                pidCus = sDt5.Rows(i).ItemArray(0)
                sCommand.CommandText = "UPDATE dCustomer SET idPM = NULL WHERE idCus = " & pidCus
                sCommand.ExecuteNonQuery()
            Next

            For i = 0 To dgvDataCus.Rows.Count - 1
                pidCus = dgvDataCus.Rows(i).Cells(idCus.Name).Value
                sCommand.CommandText = "UPDATE dCustomer SET idPM =" & selectPmType.SelectedValue.ToString & " WHERE idCus = " & pidCus
                sCommand.ExecuteNonQuery()
            Next
            dgvDataCus.Refresh()
            dgvDataCus2.Refresh()
            mdLoadCommitt()
        End If
        ShowDataOnGrid(sWhere)
    End Sub

    Private Sub dgvDataCus2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataCus2.CellContentClick
        mdLoadShow()
        Dim pidcus As Integer
        Dim pcusname2 As String
        Dim ppic As Bitmap
        Dim padd As String
        Dim searchedValue As Integer
        Dim i As Integer = 0
        Dim checkans As Integer = 0
        Dim pCusTypeName As String
        Dim pCusType As String
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvDataCus2.Columns(e.ColumnIndex).Name = colselect2.Name And (psubtype <> "" And psubtype <> "1") Then
            pidcus = dgvDataCus2.Rows(e.RowIndex).Cells(idCus2.Name).Value
            pcusname2 = dgvDataCus2.Rows(e.RowIndex).Cells(CusName2.Name).Value
            ppic = My.Resources.ResourceManager.GetObject("cross_circle_frame")

            If dgvDataCus2.Rows(e.RowIndex).Cells(idCusType2.Name).Value Is DBNull.Value Then
                pCusTypeName = 0
            Else
                pCusTypeName = dgvDataCus2.Rows(e.RowIndex).Cells(idCusType2.Name).Value
            End If
            If dgvDataCus2.Rows(e.RowIndex).Cells(Address2.Name).Value Is DBNull.Value Then
                padd = ""
            Else
                padd = dgvDataCus2.Rows(e.RowIndex).Cells(Address2.Name).Value
            End If
            If dgvDataCus2.Rows(e.RowIndex).Cells(CusType2.Name).Value Is DBNull.Value Then
                pCusType = ""
            Else
                pCusType = dgvDataCus2.Rows(e.RowIndex).Cells(CusType2.Name).Value
            End If

            While checkans = 0
                searchedValue = sDt.Rows(i).ItemArray(0)
                If (searchedValue = pidcus) Then
                    checkans = 1
                Else
                    i += 1
                End If
            End While
            sDt3.Rows.RemoveAt(i)
            sDt4.Rows.Add(pidcus, pcusname2, padd, pCusTypeName, pCusType)
            dgvDataCus.DataSource = sDt4
            dgvDataCus2.DataSource = sDt3
        End If
        changimg()
        mdLoadCommitt()
    End Sub

    Private Sub dgvDataCus_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataCus.CellContentClick
        mdLoadShow()
        Dim pidcus As Integer
        Dim psubname2 As String
        Dim padd As String
        Dim ptypecus As String
        Dim pCusType As String
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvDataCus.Columns(e.ColumnIndex).Name = colCancel.Name Then
            pidcus = dgvDataCus.Rows(e.RowIndex).Cells(idCus.Name).Value
            psubname2 = dgvDataCus.Rows(e.RowIndex).Cells(CusName.Name).Value
            padd = dgvDataCus.Rows(e.RowIndex).Cells(Address.Name).Value
            If dgvDataCus.Rows(e.RowIndex).Cells(idCusType.Name).Value Is DBNull.Value Then
                ptypecus = 0
            Else
                ptypecus = dgvDataCus.Rows(e.RowIndex).Cells(idCusType.Name).Value
            End If
            If dgvDataCus.Rows(e.RowIndex).Cells(CusType.Name).Value Is DBNull.Value Then
                pCusType = ""
            Else
                pCusType = dgvDataCus.Rows(e.RowIndex).Cells(CusType.Name).Value
            End If

            sDt4.Rows.RemoveAt(e.RowIndex)
            sDt3.Rows.Add(pidcus, psubname2, padd, ptypecus, pCusType)
            dgvDataCus.DataSource = sDt4
            dgvDataCus2.DataSource = sDt3
            dgvDataCus.Refresh()
            dgvDataCus2.Refresh()
            dgvDataCus2.Sort(dgvDataCus2.Columns(3), System.ComponentModel.ListSortDirection.Ascending)

        End If
        changimg()
        mdLoadCommitt()
    End Sub

    Private Sub ShowDataOnGrid(ByVal sWhere As String)
        psubtype = selectPmType.SelectedValue.ToString
        Dim searchedValue As String
        Dim searchedValue2 As String
        Dim j As Integer = 0
        mdCnOpen()
        sDt.Clear()
        sDt2.Clear()
        If CHKname.Checked = True Then
            sWhere &= " AND stDel = '0' AND CusName_ LIKE '%" & txtsname.Text & "%' "
        End If
        sCommand.CommandText = "SELECT  idCus, CusName_, Address, SmPaymentTermsD.idPM, PaymentTerms FROM vCustomer LEFT OUTER JOIN SmPaymentTermsD ON vCustomer.idPM = SmPaymentTermsD.idPM WHERE " & sWhere
        sAdapter.Fill(sDt)

        sCommand.CommandText = "SELECT  idCus, CusName_, Address, SmPaymentTermsD.idPM, PaymentTerms FROM vCustomer LEFT OUTER JOIN SmPaymentTermsD ON vCustomer.idPM = SmPaymentTermsD.idPM WHERE SmPaymentTermsD.idPM = " & psubtype & " AND stDel = '0' ORDER BY CusName_"
        sAdapter.Fill(sDt2)
        dgvDataCus.DataSource = sDt2

        For i As Integer = 0 To dgvDataCus.Rows.Count - 1
            searchedValue = dgvDataCus.Rows(i).Cells(idCus.Name).Value
            Do While j <= dgvDataCus2.Rows.Count - 1
                searchedValue2 = dgvDataCus2.Rows(j).Cells(idCus2.Name).Value
                If searchedValue2 = searchedValue Then
                    sDt.Rows(j).Delete()
                    sDt.AcceptChanges()
                End If
                j += 1
            Loop
            j = 0
        Next
        dgvDataCus2.DataSource = sDt

        sDt3 = sDt
        sDt4 = sDt2
        changimg()

    End Sub

    Private Sub CHKname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKname.CheckedChanged
        If CHKname.Checked = True Then
            txtsname.Enabled = True
        End If
        If CHKname.Checked = False Then
            txtsname.Enabled = False
            txtsname.Text = ""
        End If
    End Sub
End Class