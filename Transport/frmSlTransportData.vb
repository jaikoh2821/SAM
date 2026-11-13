Public Class frmSlTransportData

    Dim sDt As New DataTable
    Dim OrderBy As String = ""
    Dim sDtCombo As New DataTable

    Private Sub frmSlTransportData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowDataOnGrid("")
        ShowComboBoxTsb()
    End Sub

    Private Sub ShowComboBoxTsb()
        mdCnOpen()

        sCommand.CommandText = "SELECT case when idTspType = 1 then 0 else 1 end as sort, idTspType, TspTypeName FROM dTspType ORDER BY sort,TspTypeName"
        sAdapter.Fill(sDtCombo)

        Me.ComboTspType.DataSource = sDtCombo
        Me.ComboTspType.ValueMember = "idTspType"          'เก็บค่า ลงฐานข้อมูล
        Me.ComboTspType.DisplayMember = "TspTypeName"     'นำข้อมูลในฐานข้อมูลมาแสดง

        Dim TbName As New AutoCompleteStringCollection
        Dim sTbName As String

        For i As Integer = 0 To sDt.Rows.Count - 1 'นับแถวในฐานข้อมูล
            sTbName = sDt.Rows.Item(i).Item("TspTypeName").ToString()  'ช่วยในการค้นหาจากการพิมพ์ข้อมูลผ่าน Combobox และเลือก Combobox 
            TbName.Add(sTbName)

        Next

        Me.ComboTspType.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.ComboTspType.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.ComboTspType.AutoCompleteCustomSource = TbName
        
    End Sub

    Private Sub ShowDataOnGrid(ByVal vWhere As String)
        mdCnOpen()
        sDt.Clear()
        If RdTspName.Checked = True Then
            OrderBy = "TspName"
        ElseIf RdTspShort.Checked = True Then
            OrderBy = "Short_null, TspShort"
        ElseIf Rdimportance.Checked = True Then
            OrderBy = "is_null, importance"
        End If
        sCommand.CommandText = "SELECT d.idTsp, d.importance, d.TspShort, d.TspName, d.TspAddress, d.TspTel, " & _
        "d.TspArea, d.TspNote , case when d.importance is null then 1 else 0 end as is_null, case when d.TspShort is null then 1 else 0 end as Short_null, " & _
        "d.idTspType, t.TspTypeName FROM dTsp As d INNER JOIN dTspType As t ON d.idTspType = t.idTspType WHERE d.idTsp <> 1 " & vWhere & "  ORDER BY  " & OrderBy
        sAdapter.Fill(sDt)
        dgvData1.DataSource = sDt
        txtSearch()
        SumTotal()
    End Sub

    Private Sub dgvData1_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData1.CellContentClick
        If dgvData1.Columns(e.ColumnIndex).Name = editTranSport.Name Then

            Dim frm As New frmTspDetail
            frm.GetidTsp(dgvData1.Rows(e.RowIndex).Cells(idTsp.Name).Value)
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                chkCheckBoxTsp()
            End If
        End If

    End Sub

    Private Sub dgvData1_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData1.RowPostPaint
        Me.dgvData1("colautonum", e.RowIndex).Value = e.RowIndex + 1

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New frmTspDetail
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            chkCheckBoxTsp()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSearch()
        End If
    End Sub

    Sub SumTotal()
        Me.Label3.Text = "รายการทั้งหมด  " & Format(dgvData1.Rows.Count, "#,##0") & "  รายการ"

    End Sub

    Private Sub txtSearch()
        Dim dv As New DataView(sDt)
        dv.RowFilter = "TspName LIKE '%" & txt_Search.Text & "%' Or   TspShort LIKE '%" & txt_Search.Text & "%' Or TspAddress LIKE '%" & txt_Search.Text & "%'"

        If RdTspName.Checked = True Then
            dv.Sort = "TspName"
        ElseIf RdTspShort.Checked = True Then
            dv.Sort = "Short_null, TspShort"
        ElseIf Rdimportance.Checked = True Then
            dv.Sort = "is_null, importance"
        End If

        dgvData1.DataSource = dv
        If dgvData1.Rows.Count < 1 Then
            MessageBox.Show("ไม่พบที่ค้นหา", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        SumTotal()
    End Sub

    Private Sub chkCheckBoxTsp()
        If CbShowTsp.Checked = True Then
            ComboTspType.Enabled = True
            ShowDataOnGrid("And d.idTspType ='" & ComboTspType.SelectedValue & "'")
        Else
            ComboTspType.Enabled = False
            ShowDataOnGrid("")
        End If
    End Sub
    Private Sub Rdimportance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdimportance.CheckedChanged
        Try
            txtSearch()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RdTspShort_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdTspShort.CheckedChanged
        Try
            txtSearch()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub RdTspName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdTspName.CheckedChanged
        Try
            txtSearch()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboTspType_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboTspType.SelectionChangeCommitted
        chkCheckBoxTsp()
    End Sub

    Private Sub ComboTspType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboTspType.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dv As New DataView(sDtCombo)
            dv.RowFilter = "TspTypeName ='" & ComboTspType.Text & "'"
            If dv.Count = 0 Then
                MessageBox.Show("ไม่สามารถค้นหาข้อมูลนี้ได้เนื่องจาก" & Environment.NewLine & "  - ใส่ข้อมูลค้นหาผิดรูปแบบที่กำหนดให้", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            chkCheckBoxTsp()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbShowTsp.CheckedChanged
        chkCheckBoxTsp()
    End Sub
End Class