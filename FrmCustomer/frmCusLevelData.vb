Public Class frmCusLevelData
    Dim sDt As New DataTable
    Dim IdType As String
    Dim pname As String
    Dim pnote As String
    Dim prprice As String
    Dim pbprice As String
    Dim pwprice As String
    Dim CreditTotals As String

    Sub mdLoadShow()

    End Sub
    Sub mdLoadCommitt()

    End Sub

    'Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim answer As DialogResult
    '    answer = MessageBox.Show("ยืนยันการบันทึก", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '    If answer = vbYes Then
    '        mdLoadShow()
    '        mdCnOpen()
    '        sCommand.CommandText = "DELETE FROM dCusType WHERE idCusType <> 1 "
    '        sCommand.ExecuteNonQuery()
    '        For i As Integer = 0 To dgvData.Rows.Count - 2
    '            If dgvData.Rows(i).Cells(CusType.Name).Value <> "" Then
    '                sCommand.CommandText = "INSERT INTO dCusType (CusType, Note) VALUES ('" & dgvData.Rows(i).Cells(CusType.Name).Value & "','" & dgvData.Rows(i).Cells(Note.Name).Value & "')"
    '                sCommand.ExecuteNonQuery()
    '            End If
    '        Next
    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '        MessageBox.Show("บันทึกข้อมูลเรียบร้อย")
    '        mdLoadCommitt()
    '    End If

    'End Sub
    Private Sub dgvExpense_RowPostPaint2(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData.RowPostPaint
        Me.dgvData("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Private Sub changimg()
        For i As Integer = 0 To dgvData.Rows.Count - 1
            dgvData.Rows(i).Cells(colcancel.Name).Value = My.Resources.ResourceManager.GetObject("check")
        Next
    End Sub

    Private Sub dgvData_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvData.RowsAdded
        For i As Integer = 0 To dgvData.Rows.Count - 1
            dgvData.Rows(i).Cells(colcancel.Name).Value = My.Resources.ResourceManager.GetObject("check")
        Next
    End Sub
    Public Sub ShowDataOnGrid()
        mdCnOpen()
        sDt.Clear()
        sCommand.CommandText = "Select idCusType, CusType, Note, PriceRetail, PriceBill, PriceWholeSale, REPLACE(CONVERT(varchar(128), CONVERT(money, CreditTotal , 1), 1), '.00', '') As CreditTotal FROM dCusType WHERE idCusType <> 1 Order by CusType ASC"
        sAdapter.Fill(sDt)
        dgvData.DataSource = sDt
        changimg()
    End Sub

    Private Sub frmCusLevelData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        ShowDataOnGrid()
        mdLoadCommitt()
    End Sub

    Private Sub dgvData_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellClick

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvData.Rows(e.RowIndex).Cells(idCusType.Name).Value Is DBNull.Value Then
            IdType = ""
        Else
            IdType = dgvData.Rows(e.RowIndex).Cells(idCusType.Name).Value
        End If
        If dgvData.Rows(e.RowIndex).Cells(CusType.Name).Value Is DBNull.Value Then
            pname = ""
        Else
            pname = dgvData.Rows(e.RowIndex).Cells(CusType.Name).Value
        End If
        If dgvData.Rows(e.RowIndex).Cells(PriceRetail.Name).Value Is DBNull.Value Then
            prprice = ""
        Else
            prprice = dgvData.Rows(e.RowIndex).Cells(PriceRetail.Name).Value
        End If
        If dgvData.Rows(e.RowIndex).Cells(PriceBill.Name).Value Is DBNull.Value Then
            pbprice = ""
        Else
            pbprice = dgvData.Rows(e.RowIndex).Cells(PriceBill.Name).Value
        End If
        If dgvData.Rows(e.RowIndex).Cells(PriceWholeSale.Name).Value Is DBNull.Value Then
            pwprice = ""
        Else
            pwprice = dgvData.Rows(e.RowIndex).Cells(PriceWholeSale.Name).Value
        End If
        If dgvData.Rows(e.RowIndex).Cells(Note.Name).Value Is DBNull.Value Then
            pnote = ""
        Else
            pnote = dgvData.Rows(e.RowIndex).Cells(Note.Name).Value
        End If
        If dgvData.Rows(e.RowIndex).Cells(CreditTotal.Name).Value Is DBNull.Value Then
            CreditTotals = ""
        Else
            CreditTotals = dgvData.Rows(e.RowIndex).Cells(CreditTotal.Name).Value
        End If

        'If dgvData.Columns(e.ColumnIndex).Name = colcancel.Name Then
        '    answer = MessageBox.Show("ต้องการลบระดับ", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '    If answer = vbYes Then
        '        If CHK_Data() Then
        '            mdLoadShow()
        '            mdCnOpen()
        '            sCommand.CommandText = "DELETE FROM dCusType WHERE idCusType = " + dgvData.Rows(e.RowIndex).Cells(idCusType.Name).Value.ToString
        '            sCommand.ExecuteNonQuery()

        '            sDt.Rows(e.RowIndex).Delete()
        '            sDt.AcceptChanges()
        '            dgvData.DataSource = sDt
        '            changimg()
        '            MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว")
        '            mdLoadCommitt()
        '        Else
        '            MessageBox.Show("ไม่สามารถลบข้อมูลได้ เนื่องจากข้อมูลกำลังถูกใช้งานอยู่")
        '        End If
        '    End If
        'End If


        If dgvData.Columns(e.ColumnIndex).Name = colcancel.Name Then
            Dim frm As New frmCusLevelDetail
            frm.Get_Type(2)
            frm.Get_Value(IdType, pname, pnote, prprice, pbprice, pwprice, CreditTotals)
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                mdLoadShow()
                ShowDataOnGrid()
                mdLoadCommitt()
            End If
        End If
        

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New frmCusLevelDetail
        frm.Get_Type(1)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            mdLoadShow()
            ShowDataOnGrid()
            mdLoadCommitt()
        End If
    End Sub

    Function CHK_Data() As Boolean
        Dim sDt_temp As New DataTable
        mdCnOpen()
        sDt_temp.Clear()
        sCommand.CommandText = "Select COUNT(*) FROM dCustomer WHERE idCusType =" + IdType
        sAdapter.Fill(sDt_temp)
        If sDt_temp.Rows(0).Item(0) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class