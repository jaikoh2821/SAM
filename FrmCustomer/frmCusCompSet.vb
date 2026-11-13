Public Class frmCusCompSet
    Dim Result As DialogResult

    Private Sub frmCusCompSet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbCompany()
        SetCompGrid()
        Me.txtCusName.Focus()
    End Sub

    Private Sub cmbCompany()
        mdCnOpen2()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT idComp, CompName FROM dCompany WHERE idComp <> 0 AND stSale = 1 Order By CompName"
        sAdapter.Fill(sDt)
        With cmbComp
            .DisplayMember = "CompName"
            .ValueMember = "idComp"
            .DataSource = sDt
        End With
    End Sub

    Private Sub SetCusOfComp()
        If Me.cmbComp.SelectedValue <> Nothing Then
            dgvCustomer.Rows.Clear()
            mdCnOpen()
            Dim sDt2 As New DataTable
            sCommand.CommandText = "SELECT s.idCus, c.CusName_ FROM dCusCompSet s LEFT OUTER JOIN vCustomer c " & _
                                   "ON s.idCus = c.idCus WHERE s.idComp = " & Me.cmbComp.SelectedValue & " Order By c.CusName_"
            sAdapter.Fill(sDt2)

            If sDt2.Rows.Count > 0 Then
                For i As Integer = 0 To sDt2.Rows.Count - 1
                    With dgvCustomer
                        Dim rc As Integer = dgvCustomer.RowCount
                        .Rows.Add()
                        .Rows(rc).Cells("ColNum").Value = rc + 1
                        .Rows(rc).Cells("ColidCus").Value = sDt2.Rows(i).Item("idCus")
                        .Rows(rc).Cells("colCusName").Value = sDt2.Rows(i).Item("CusName_")
                    End With
                Next
            Else
                dgvCustomer.Rows.Clear()
                SetAllCus()
                'dgvCustomer.DataSource = sDt2
                'ksbCountRowDgv(dgvCustomer, ColNum.Name)
            End If

        End If
    End Sub

    Private Sub SetAllCus()
        Dim vWHERE As String = ""

        vWHERE = vWHERE & " WHERE CusName_ LIKE '%" + Trim(txtCusName.Text) + "%' "
        For i As Integer = 0 To dgvCustomer.Rows.Count - 1
            vWHERE = vWHERE & " AND idCus <> " & dgvCustomer.Rows(i).Cells("ColidCus").Value & " "
        Next

        mdCnOpen()
        Dim sDt2 As New DataTable
        sCommand.CommandText = "SELECT idCus, CusName_ FROM vCustomer " & vWHERE & " Order By CusName_"
        sAdapter.Fill(sDt2)

        If sDt2.Rows.Count = 0 Then
            DGV_AllCus.DataSource = sDt2
            Exit Sub
        Else
            DGV_AllCus.DataSource = sDt2
            ksbCountRowDgv(DGV_AllCus, ColNumAll.Name)
        End If

    End Sub

    Private Sub txtCusName_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtCusName.KeyDown
        If e.KeyCode = Keys.Enter Then SetAllCus()
    End Sub

    'Sub CompanySet()
    '    Dim sDt As New DataTable
    '    sDt.Clear()

    '    mdCnOpen()
    '    sCommand.CommandText = "SELECT idComp, CompName FROM dCompany WHERE idComp <> 0"
    '    sAdapter.Fill(sDt)

    '    If sDt.Rows.Count = 0 Then
    '        MessageBox.Show("ไม่พบข้อมูล", sSystemName)
    '        DGVCompany.DataSource = sDt
    '        Exit Sub
    '    Else
    '        DGVCompany.DataSource = sDt
    '        'ksbCountRowDgv(dgvCusAdr, ColCount.Name)
    '        'mdConvertDateInGrid(dgvCusAdr, ColDateUpd)
    '    End If
    'End Sub


    'Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim ChkidCus As New DataTable
    '    ChkidCus.Columns.Add("idCus", System.Type.GetType("System.Int32"))

    '    For i As Integer = 0 To dgvCustomer.Rows.Count - 1
    '        ChkidCus.Rows.Add()
    '        ChkidCus.Rows(i).Item("idCus") = dgvCustomer.Rows(i).Cells("ColidCus").Value
    '    Next

    '    Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eChkSetComp)
    '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

    '    End If

    'End Sub

    'Private Sub cmbComp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbComp.SelectedIndexChanged
    '    SetCusOfComp()
    '    SetAllCus()
    'End Sub

    Private Sub cmbComp_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbComp.SelectedValueChanged
        SetCusOfComp()
        SetAllCus()
    End Sub

    Private Sub DGV_AllCus_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_AllCus.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If DGV_AllCus.Columns(e.ColumnIndex).Name = ColSelect.Name Then
            'Add grid CusSet
            With dgvCustomer
                Dim rc As Integer = dgvCustomer.RowCount
                .Rows.Add()
                .Rows(rc).Cells("ColNum").Value = rc + 1
                .Rows(rc).Cells("ColidCus").Value = DGV_AllCus.Rows(e.RowIndex).Cells(ColidCusAll.Name).Value
                .Rows(rc).Cells("colCusName").Value = DGV_AllCus.Rows(e.RowIndex).Cells(ColCusNameAll.Name).Value
            End With

            'Bind New AllCus
            SetAllCus()
        End If


    End Sub


    Private Sub dgvCustomer_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomer.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvCustomer.Columns(e.ColumnIndex).Name = ColDel.Name Then
            Result = MsgBox("คุณต้องการยกเลิกการผูกลูกค้ารายนี้กับบริษัท " & Me.cmbComp.Text & " ใช่หรือไม่", MsgBoxStyle.YesNo)
            If Result = Windows.Forms.DialogResult.Yes Then
                'mdCnOpen()
                'sCommand.CommandText = "Delete dCusCompSet Where idCus = " & dgvCustomer.Rows(e.RowIndex).Cells(ColidCus.Name).Value & " " & _
                '                       "AND idComp = " & Me.cmbComp.SelectedValue & ""
                'sCommand.ExecuteNonQuery()

                dgvCustomer.Rows.Remove(dgvCustomer.CurrentRow)
                'Bind New AllCus
                SetAllCus()

            End If
        End If

    End Sub

    Private Sub bntSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntSearch.Click
        SetAllCus()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If dgvCustomer.Rows.Count = 0 Then
            MessageBox.Show("กรุณาเลือกลูกค้าเพื่อผูกกับบริษัทอย่างน้อย 1 รายการ ก่อนกดปุ่มบันทึก", sSystemName)
            Exit Sub
        End If

        mdCnOpen()
        'Delete All of Customer
        sCommand.CommandText = "Delete dCusCompSet Where idComp = " & Me.cmbComp.SelectedValue & ""
        sCommand.ExecuteNonQuery()

        'New Insert
        For i As Integer = 0 To dgvCustomer.Rows.Count - 1
            sCommand.CommandText = "INSERT INTO dCusCompSet (idCus, idComp) VALUES " & _
                                   " (" & dgvCustomer.Rows(i).Cells("ColidCus").Value & ", " & _
                                   "" & Me.cmbComp.SelectedValue & ")"
            sCommand.ExecuteNonQuery()
        Next

        'For i As Integer = 0 To dgvCustomer.Rows.Count - 1
        '    Dim ChkDt As New DataTable
        '    ChkDt.Clear()
        '    sCommand.CommandText = "Select * From dCusCompSet WHERE idCus = " & dgvCustomer.Rows(i).Cells("ColidCus").Value & " " & _
        '                           "AND idComp = " & Me.cmbComp.SelectedValue & ""
        '    sAdapter.Fill(ChkDt)
        '    If ChkDt.Rows.Count = 0 Then
        '        'New Insert
        '        sCommand.CommandText = "INSERT INTO dCusCompSet (idCus, idComp) VALUES " & _
        '                             " (" & dgvCustomer.Rows(i).Cells("ColidCus").Value & ", " & _
        '                             "" & Me.cmbComp.SelectedValue & ")"
        '        sCommand.ExecuteNonQuery()
        '    End If
        'Next

        MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName)
    End Sub

    '************************************** Tab 2 *****************************************'
    Private Sub SetCompGrid()
        mdCnOpen2()
        Dim sDt3 As New DataTable
        sCommand.CommandText = "SELECT idComp, CompName FROM dCompany WHERE idComp <> 0 AND stSale = 1 Order By CompName"
        sAdapter.Fill(sDt3)

        If sDt3.Rows.Count > 0 Then
            DGVCompany.DataSource = sDt3
            'ksbCountRowDgv(dgvCustomer, ColNum.Name)
        End If
    End Sub

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelect, cmbComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            For j As Integer = 0 To DGVCompany.Rows.Count - 1
                Me.DGVCompany.Rows(j).Cells("ColCheckbox").Value = False
            Next

            lblCus.Tag = vFrm.idCus
            lblCus.Text = vFrm.CusName

            Dim ChkDt As New DataTable
            ChkDt.Clear()
            sCommand.CommandText = "Select idComp From dCusCompSet WHERE idCus = " & Me.lblCus.Tag & " "
            sAdapter.Fill(ChkDt)

            For i As Integer = 0 To ChkDt.Rows.Count - 1
                For j As Integer = 0 To DGVCompany.Rows.Count - 1
                    If ChkDt.Rows(i).Item("idComp") = DGVCompany.Rows(j).Cells("ColidComp").Value Then
                        Me.DGVCompany.Rows(j).Cells("ColCheckbox").Value = True
                    End If
                Next
            Next

        End If
    End Sub

    Private Sub btnSave2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave2.Click
        Dim stChk As Integer = 0
        For i As Integer = 0 To DGVCompany.Rows.Count - 1
            If Me.DGVCompany.Rows(i).Cells("ColCheckbox").Value = True Then
                stChk = 1
            End If
        Next

        If stChk = 0 Then ' No checkbox
            MessageBox.Show("กรุณาเลือกบริษัทอย่างน้อย 1 รายการ ก่อนกดปุ่มบันทึก", sSystemName)
            Exit Sub
        Else
            mdCnOpen()

            'Delete All of Customer
            sCommand.CommandText = "Delete dCusCompSet Where idCus = " & Me.lblCus.Tag & ""
            sCommand.ExecuteNonQuery()

            'New Insert
            For i As Integer = 0 To DGVCompany.Rows.Count - 1
                If Me.DGVCompany.Rows(i).Cells("ColCheckbox").Value = True Then
                    sCommand.CommandText = "INSERT INTO dCusCompSet (idCus, idComp) VALUES " & _
                                           " (" & Me.lblCus.Tag & ", " & _
                                           "" & DGVCompany.Rows(i).Cells("ColidComp").Value & ")"
                    sCommand.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName)
        End If
    End Sub
End Class