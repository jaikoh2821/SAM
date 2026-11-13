Public Class frmCusLevelSet
    Dim sDt As New DataTable
    Dim sDt2 As New DataTable
    Dim sDt3 As New DataTable
    Dim sDt4 As New DataTable
    Dim sDt5 As New DataTable
    Dim vWhere As String = " WHERE stDel = '0' ORDER BY CusName"
    Dim psubtype As String = ""

    Sub mdLoadShow()

    End Sub
    Sub mdLoadCommitt()

    End Sub
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim pidCus As String
        Dim answer As DialogResult
        Dim i As Integer = 0
        If psubtype <> "" And psubtype <> "1" Then
            answer = MessageBox.Show("ยืนยันการบันทึก", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If answer = vbYes Then
                mdLoadShow()
                mdCnOpen()

                For i = 0 To sDt5.Rows.Count - 1
                    pidCus = sDt5.Rows(i).ItemArray(0)
                    sCommand.CommandText = "UPDATE dCustomer SET idCusType = NULL WHERE idCus = " + pidCus
                    sCommand.ExecuteNonQuery()
                Next

                For i = 0 To dgvDataCus.Rows.Count - 1
                    pidCus = dgvDataCus.Rows(i).Cells(idCus.Name).Value
                    sCommand.CommandText = "UPDATE dCustomer SET idCusType =" + psubtype + " WHERE idCus = " + pidCus
                    sCommand.ExecuteNonQuery()
                Next
                dgvDataCus.Refresh()
                dgvDataCus2.Refresh()
                mdLoadCommitt()
            End If
            ShowDataOnGrid(vWhere)
        Else
            MessageBox.Show("ไม่สามารถทำการบันทึกได้ กรุณาเลือกประเภทของธุรกิจ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub dgvExpense_RowPostPaint2(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvDataCus.RowPostPaint
        Me.dgvDataCus("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub
    Private Sub dgvExpense_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvDataCus2.RowPostPaint
        Me.dgvDataCus2("autonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Private Sub frmCusLevelSet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        mdCnOpen()
        Dim sDt As New DataTable
        Dim sDtTemp As New DataTable
        sCommand.CommandText = "SELECT * FROM dCusType Order by CusType ASC"
        sAdapter.Fill(sDt)

        'For i As Integer = 0 To sDt.Rows.Count
        SupTypeList.DataSource = sDt
        SupTypeList.DisplayMember = "CusType"
        SupTypeList.ValueMember = "idCusType"
        'Next
        mdCnOpen()
        sCommand.CommandText = "SELECT REPLACE(CONVERT(varchar(128), CONVERT(money, COUNT(*) , 1), 1), '.00', '') As cnt FROM dCustomer WHERE stDel = '0' AND idCusType = '1' "
        sAdapter.Fill(sDtTemp)
        lbtotal.Text = "มี " + sDtTemp.Rows(0).ItemArray(0).ToString + " รายการ"
        mdLoadCommitt()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ptxtsname As String = txtsname.Text
        Dim padd As String = txtadd.Text
        psubtype = SupTypeList.SelectedValue.ToString
        If psubtype <> "" And psubtype <> "1" Then
            If CHKname.Checked = False And AddcusCheck.Checked = False Then
                vWhere = " WHERE stDel = '0' "
            ElseIf CHKname.Checked = True And AddcusCheck.Checked = False Then
                vWhere = " WHERE CusName LIKE '%" + txtsname.Text + "%'"
            ElseIf CHKname.Checked = False And AddcusCheck.Checked = True Then
                vWhere = " WHERE Address LIKE '%" + txtadd.Text + "%'"
            ElseIf CHKname.Checked = True And AddcusCheck.Checked = True Then
                vWhere = " WHERE CusName LIKE '%" + txtsname.Text + "%' AND Address LIKE '%" + txtadd.Text + "%'"
            End If

            If chknull.Checked = True Then
                vWhere += " AND dCustomer.idCusType = '1' AND stDel = '0' ORDER BY CusName"
            Else
                vWhere += " OR dCustomer.idCusType = " + psubtype + " AND stDel = '0' ORDER BY CusName"
            End If
        Else
            If CHKname.Checked = False And AddcusCheck.Checked = False Then
                If chknull.Checked = True Then
                    vWhere = " WHERE stDel = '0' AND dCustomer.idCusType = 1 ORDER BY CusName"
                Else
                    vWhere = " WHERE stDel = '0' ORDER BY CusName"
                End If
            ElseIf CHKname.Checked = True And AddcusCheck.Checked = False Then
                vWhere = " WHERE CusName LIKE '%" + txtsname.Text + "%'  "
                If chknull.Checked = True Then
                    vWhere += " AND stDel = '0' AND dCustomer.idCusType = 1 ORDER BY CusName"
                Else
                    vWhere += " or dCustomer.idCusType = " + psubtype + " AND stDel = '0' ORDER BY CusName"
                End If
            ElseIf CHKname.Checked = False And AddcusCheck.Checked = True Then
                vWhere = " WHERE Address LIKE '%" + txtadd.Text + "%' "
                If chknull.Checked = True Then
                    vWhere += " AND stDel = '0' AND dCustomer.idCusType = 1 ORDER BY CusName"
                Else
                    vWhere += " or dCustomer.idCusType = " + psubtype + " AND stDel = '0' ORDER BY CusName"
                End If
            ElseIf CHKname.Checked = True And AddcusCheck.Checked = True Then
                vWhere = " WHERE CusName LIKE '%" + txtsname.Text + "%' AND Address LIKE '%" + txtadd.Text + "%'"
                If chknull.Checked = True Then
                    vWhere += " AND stDel = '0' AND dCustomer.idCusType = 1 ORDER BY CusName"
                Else
                    vWhere += " or dCustomer.idCusType = " + psubtype + " AND stDel = '0' ORDER BY CusName"
                End If
            End If

        End If

        mdLoadShow()
        ShowDataOnGrid2(vWhere)
        mdLoadCommitt()
    End Sub

    Private Sub ShowDataOnGrid2(ByVal sWhere As String)
        psubtype = SupTypeList.SelectedValue.ToString
        Dim searchedValue As String
        Dim searchedValue2 As String
        Dim j As Integer = 0
        mdCnOpen()
        sDt.Clear()
        sCommand.CommandText = "SELECT  idCus, CusName, Address, dCustomer.idCusType , CusType FROM dCustomer LEFT OUTER JOIN dCusType ON dCustomer.idCusType = dCusType.idCusType " + sWhere
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
    Private Sub SupTypeList_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupTypeList.SelectionChangeCommitted
        mdLoadShow()
        Dim sDt_Temp As New DataTable
        sDt_Temp.Clear()
        CHKname.Checked = False
        AddcusCheck.Checked = False
        chknull.Checked = False
        psubtype = SupTypeList.SelectedValue.ToString
        If SupTypeList.SelectedValue.ToString = "1" Then
            vWhere = " WHERE stDel = '0' ORDER BY CusName"
        Else
            vWhere = " WHERE dCustomer.idCusType <> " + psubtype + " AND stDel = '0' ORDER BY CusName"
        End If
        ShowDataOnGrid(vWhere)
        sDt5.Clear()
        sCommand.CommandText = "SELECT  idCus, CusName, Address, dCustomer.idCusType, CusType FROM dCustomer LEFT OUTER JOIN dCusType ON dCustomer.idCusType = dCusType.idCusType WHERE dCustomer.idCusType = " + psubtype + " AND stDel = '0' ORDER BY CusName"
        sAdapter.Fill(sDt5)
        sCommand.CommandText = "SELECT idCusType, CusType, Note, PriceRetail, PriceBill, PriceWholeSale, REPLACE(CONVERT(varchar(128), CONVERT(money, CreditTotal , 1), 1), '.00', '') As CreditTotal FROM dCusType WHERE idCusType = " + psubtype
        sAdapter.Fill(sDt_Temp)
        prlabel.Text = sDt_Temp.Rows(0).Item(3).ToString + "%"
        pblabel.Text = sDt_Temp.Rows(0).Item(4).ToString + "%"
        pwlabel.Text = sDt_Temp.Rows(0).Item(5).ToString + "%"
        lbCreditTotal.Text = sDt_Temp.Rows(0).Item(6).ToString + "  บาท"

        If sDt_Temp.Rows(0).Item(2).ToString = "" Then
            notelabel.Text = "- "
        Else
            notelabel.Text = sDt_Temp.Rows(0).Item(2).ToString
        End If
        SumTotal()
        mdLoadCommitt()
    End Sub

    Private Sub ShowDataOnGrid(ByVal sWhere As String)
        psubtype = SupTypeList.SelectedValue.ToString
        Dim searchedValue As String
        Dim searchedValue2 As String
        Dim j As Integer = 0
        mdCnOpen()
        sDt.Clear()
        sDt2.Clear()
        sCommand.CommandText = "SELECT  idCus, CusName, Address, dCustomer.idCusType, CusType FROM dCustomer LEFT OUTER JOIN dCusType ON dCustomer.idCusType = dCusType.idCusType " + sWhere
        sAdapter.Fill(sDt)

        sCommand.CommandText = "SELECT  idCus, CusName, Address, dCustomer.idCusType , CusType FROM dCustomer LEFT OUTER JOIN dCusType ON dCustomer.idCusType = dCusType.idCusType WHERE dCustomer.idCusType = " + psubtype + " AND stDel = '0' ORDER BY CusName"
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

    Private Sub changimg()
        For i As Integer = 0 To dgvDataCus.Rows.Count - 1
            dgvDataCus.Rows(i).Cells(colCancel.Name).Value = My.Resources.ResourceManager.GetObject("cross_circle_frame")
        Next
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

    Private Sub AddcusCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddcusCheck.CheckedChanged
        If AddcusCheck.Checked = True Then
            txtadd.Enabled = True
        End If
        If AddcusCheck.Checked = False Then
            txtadd.Enabled = False
            txtadd.Text = ""
        End If
    End Sub

    Private Sub dgvDataCus_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataCus.CellClick
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
                ptypecus = ""
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
        SumTotal()
        mdLoadCommitt()
    End Sub

    Private Sub dgvDataCus2_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataCus2.CellClick
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
                pCusTypeName = ""
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
        SumTotal()
        mdLoadCommitt()
    End Sub
    Sub SumTotal()
        Me.Label7.Text = "รายการทั้งหมด  " & Format(dgvDataCus.Rows.Count, "#,##0") & "  รายการ"
    End Sub
End Class