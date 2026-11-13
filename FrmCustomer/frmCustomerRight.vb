Public Class frmCustomerRight
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable
    Dim dt3 As New DataTable

#Region "CreateDatatable"

    Private Sub CreateDatatable()
        '------------------------- Add Columns DataTable1 -------------------------------
        dt1.Columns.Add("CusName_", GetType(String))
        dt1.Columns.Add("Address", GetType(String))
        dt1.Columns.Add("PsName", GetType(String))
        dt1.Columns.Add("idCus", GetType(Int32))

        '------------------------- Add Columns DataTable2 -------------------------------
        dt2.Columns.Add("CusName2", GetType(String))
        dt2.Columns.Add("Address2", GetType(String))
        dt2.Columns.Add("PsName2", GetType(String))
        dt2.Columns.Add("idCus2", GetType(Int32))

        '------------------------- Add Columns DataTable3 -------------------------------
        dt3.Columns.Add("CusName3", GetType(String))
        dt3.Columns.Add("Address3", GetType(String))
        dt3.Columns.Add("PsName3", GetType(String))
        dt3.Columns.Add("idCus3", GetType(Int32))

    End Sub
#End Region
    Private Function SetPsName(ByVal sDtPkGrid As DataTable, ByVal vWhere As String, ByVal colSDataRow As String, ByVal GridNumber As Integer)
        Dim dtSetString As New DataTable
        dtSetString.Clear()
        Dim SQL As String = ""
        Select Case GridNumber
            Case 1 : SQL = "c.CusName_, c.Address,'' As PsName,  sm.idCus"
            Case 2 : SQL = "c.CusName_ As CusName2, c.Address As Address2,'' As PsName2, sm.idCus As idCus2 "
            Case 3 : SQL = "c.CusName_ As CusName3, c.Address As Address3,'' As PsName3,sm.idCus As idCus3 "

        End Select

        sCommand.CommandText = "SELECT " & SQL & _
                               " FROM dbo.SmMkCusPs AS sm INNER JOIN dbo.dCustomer " & _
                               " ON sm.idCus = dbo.dCustomer.idCus LEFT OUTER JOIN " & _
                               " dbo.vPerson AS p ON sm.idPs = p.idPs LEFT OUTER JOIN" & _
                               " dbo.vCustomer AS c ON c.idCus = sm.idCus" & _
                               " WHERE  " & vWhere & _
                               " GROUP BY c.CusName_, c.Address, sm.idCus"
        sAdapter.Fill(dtSetString)

        For i As Integer = 0 To dtSetString.Rows.Count - 1
            Dim j As Integer = 0
            For Each dr As DataRow In sDtPkGrid.Select(colSDataRow & " = '" & dtSetString.Rows(i).Item(3).ToString & "'")
                If j = 0 Then
                    dtSetString.Rows(i).Item(2) = dr.Item(2)
                    j = j + 1
                Else
                    dtSetString.Rows(i).Item(2) &= ", " & dr.Item(2)
                End If
            Next
        Next
        Return dtSetString
    End Function
#Region "ShowDataOnGrid"
    Public Sub ShowDataOnGrid1()
        dt1.Clear()
        mdCnOpen()
        dt1.Clear()
        sCommand.CommandText = "SELECT   c.CusName_, c.Address, sm.idCus, p.PsName " & _
                               " FROM dbo.SmMkCusPs AS sm INNER JOIN dbo.dCustomer " & _
                               " ON sm.idCus = dbo.dCustomer.idCus LEFT OUTER JOIN " & _
                               " dbo.vPerson AS p ON sm.idPs = p.idPs LEFT OUTER JOIN " & _
                               " dbo.vCustomer AS c ON c.idCus = sm.idCus " & _
                               " WHERE (dbo.dCustomer.stRight IS NULL) " 
        sAdapter.Fill(dt1)

        'ComboPsName Value
        Dim dv As New DataView(dt1)
        Dim dt_Group As DataTable

        dt_Group = dv.ToTable(True, New String() {"PsName"})
        Me.ComboPsName.DataSource = dt_Group
        Me.ComboPsName.ValueMember = "PsName"          'เก็บค่า ลงฐานข้อมูล
        Me.ComboPsName.DisplayMember = "PsName"     'นำข้อมูลในฐานข้อมูลมาแสดง

        Dim PsN As New AutoCompleteStringCollection
        Dim sComboPsN As String

        For i As Integer = 0 To dt_Group.Rows.Count - 1 'นับแถวในฐานข้อมูล
            sComboPsN = dt_Group.Rows.Item(i).Item("PsName").ToString()  'ช่วยในการค้นหาจากการพิมพ์ข้อมูลผ่าน Combobox และเลือก Combobox 
            PsN.Add(sComboPsN)
        Next

        Me.ComboPsName.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.ComboPsName.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.ComboPsName.AutoCompleteCustomSource = PsN

        dt1 = SetPsName(dt1, "(dbo.dCustomer.stRight IS NULL)", "idCus", 1)
        dt1.DefaultView.Sort = "CusName_"
        dgvData1.DataSource = dt1
        SumTotal1()

    End Sub

    Public Sub ShowDataOnGrid2()
        dt2.Clear()
        mdCnOpen()
        sCommand.CommandText = "SELECT p.PsName As PsName2, c.CusName_ As CusName2, c.Address As Address2, sm.idCus As idCus2" & _
                                " FROM dbo.SmMkCusPs AS sm INNER JOIN dbo.dCustomer" & _
                                " ON sm.idCus = dbo.dCustomer.idCus LEFT OUTER JOIN" & _
                                " dbo.vPerson AS p ON sm.idPs = p.idPs LEFT OUTER JOIN" & _
                                " dbo.vCustomer AS c ON c.idCus = sm.idCus" & _
                                " WHERE (dbo.dCustomer.stRight = '1')"

        sAdapter.Fill(dt2)
        dt2 = SetPsName(dt2, "(dbo.dCustomer.stRight = '1')", "idCus2", 2)
        dt2.DefaultView.Sort = "CusName2"
        dgvData2.DataSource = dt2
        SumTotal2()

    End Sub

    Public Sub ShowDataOnGrid3()
        dt3.Clear()
        mdCnOpen()
        sCommand.CommandText = "SELECT p.PsName As PsName3, c.CusName_ As CusName3, c.Address As Address3, sm.idCus As idCus3" & _
                                " FROM dbo.SmMkCusPs AS sm INNER JOIN dbo.dCustomer" & _
                                " ON sm.idCus = dbo.dCustomer.idCus LEFT OUTER JOIN" & _
                                " dbo.vPerson AS p ON sm.idPs = p.idPs LEFT OUTER JOIN" & _
                                " dbo.vCustomer AS c ON c.idCus = sm.idCus" & _
                                " WHERE (dbo.dCustomer.stRight = '0')"
        sAdapter.Fill(dt3)
        dt3 = SetPsName(dt3, "(dbo.dCustomer.stRight = '0')", "idCus3", 3)
        dt3.DefaultView.Sort = "CusName3"
        dgvData3.DataSource = dt3
        SumTotal3()

    End Sub
#End Region

    Private Sub dgvExpense_RowPostPaint1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData1.RowPostPaint
        Me.dgvData1("colautonum", e.RowIndex).Value = e.RowIndex + 1

    End Sub
    
    Private Sub dgvExpense_RowPostPaint2(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData2.RowPostPaint
        Me.dgvData2("colautonumT", e.RowIndex).Value = e.RowIndex + 1

    End Sub

    Private Sub dgvExpense_RowPostPaint3(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData3.RowPostPaint
        Me.dgvData3("colautonumF", e.RowIndex).Value = e.RowIndex + 1

    End Sub

    Private Sub frmCustomerRight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateDatatable()
        mdLoadShow()
        ShowDataOnGrid1()
        ShowDataOnGrid2()
        ShowDataOnGrid3()
        mdLoadCommitt()
    End Sub

    Sub SumTotal1()
        Me.Label1.Text = "ยังไม่กำหนดทั้งหมด  " & Format(dgvData1.Rows.Count, "#,##0") & "  รายการ"
        If dgvData1.Rows.Count = 0 Then
            cbPsName.Checked = False
            cbSearchCus.Checked = False
            txtSearch()
        End If
    End Sub

    Sub SumTotal2()
        Me.Label2.Text = "ลูกค้าถูกหลักทั้งหมด  " & Format(dgvData2.Rows.Count, "#,##0") & "  รายการ"
        
    End Sub

    Sub SumTotal3()
        Me.Label3.Text = "ลูกค้าไม่ถูกหลักทั้งหมด  " & Format(dgvData3.Rows.Count, "#,##0") & "  รายการ"
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim UPDATE_Right As String = "UPDATE  dbo.dCustomer SET stRight='1' WHERE idCus='"
        Dim UPDATE_NotRight As String = "UPDATE  dbo.dCustomer SET stRight='0' WHERE idCus='"
        Dim UPDATE_Return As String = "UPDATE  dbo.dCustomer SET stRight=NULL WHERE idCus='"
        Dim CusUpdate As String = ""

        For Each item As DataRow In dt1.Rows
            If item.RowState = DataRowState.Added Then
                CusUpdate += UPDATE_Return & item.Item(3) & "'" & Environment.NewLine
            End If
        Next
        For Each item As DataRow In dt2.Rows
            If item.RowState = DataRowState.Added Then
                CusUpdate += UPDATE_Right & item.Item(3) & "'" & Environment.NewLine
            End If
        Next
        For Each item As DataRow In dt3.Rows
            If item.RowState = DataRowState.Added Then
                CusUpdate += UPDATE_NotRight & item.Item(3) & "'" & Environment.NewLine
            End If
        Next
        
        If CusUpdate = "" Then
            MessageBox.Show("กรุณาทำรายการก่อนกด 'บันทึก' ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Dim Result As DialogResult
            Result = MsgBox("คุณต้องการบันทึกข้อมูลนี้ ใช่หรือไม่ ", MsgBoxStyle.YesNo)
            If Result = Windows.Forms.DialogResult.Yes Then
                mdCnOpen()
                sCommand.CommandText = CusUpdate
                sCommand.ExecuteNonQuery()
                mdLoadShow()
                ShowDataOnGrid1()
                ShowDataOnGrid2()
                ShowDataOnGrid3()
                mdLoadCommitt()
                MessageBox.Show("ระบบได้บันทึกข้อมูลเรียบร้อยแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

#Region "CellClickDataGrid1"

    Private Sub dgvData1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData1.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvData1.Columns(e.ColumnIndex).Name = CusRight.Name Then

            ''------------------------- Add Data DataTable 2 -------------------------------
            Dim dr As DataRow
            dr = dt2.NewRow

            dr("CusName2") = dgvData1.Rows(e.RowIndex).Cells(CusName_.Name).Value
            dr("Address2") = dgvData1.Rows(e.RowIndex).Cells(Address.Name).Value
            dr("PsName2") = dgvData1.Rows(e.RowIndex).Cells(PsName.Name).Value
            dr("idCus2") = dgvData1.Rows(e.RowIndex).Cells(idCus.Name).Value
            dgvData1.Rows.RemoveAt(e.RowIndex)
            dt2.Rows.Add(dr)

            dt2.DefaultView.Sort = "CusName2"
            dgvData2.DataSource = dt2

            'Set จำนวนทั้งหมด
            SumTotal1()
            SumTotal2()

        End If
        If dgvData1.Columns(e.ColumnIndex).Name = CusNotRight.Name Then

            '------------------------- Add Data DataTable 3 -------------------------------
            Dim dr As DataRow
            dr = dt3.NewRow

            dr("CusName3") = dgvData1.Rows(e.RowIndex).Cells(CusName_.Name).Value
            dr("Address3") = dgvData1.Rows(e.RowIndex).Cells(Address.Name).Value
            dr("PsName3") = dgvData1.Rows(e.RowIndex).Cells(PsName.Name).Value
            dr("idCus3") = dgvData1.Rows(e.RowIndex).Cells(idCus.Name).Value

            dgvData1.Rows.RemoveAt(e.RowIndex)
            dt3.Rows.Add(dr)

            dt3.DefaultView.Sort = "CusName3"
            dgvData3.DataSource = dt3

            'Set จำนวนทั้งหมด
            SumTotal1()
            SumTotal3()
        End If
    End Sub
#End Region
#Region "CellClickDataGrid2"
    Private Sub dgvData2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData2.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvData2.Columns(e.ColumnIndex).Name = btTrueOut.Name Then

            '------------------------- Add Data DataTable -------------------------------
            Dim dr As DataRow
            dr = dt1.NewRow

            dr("CusName_") = dgvData2.Rows(e.RowIndex).Cells(CusName2.Name).Value
            dr("Address") = dgvData2.Rows(e.RowIndex).Cells(Address2.Name).Value
            dr("PsName") = dgvData2.Rows(e.RowIndex).Cells(PsName2.Name).Value
            dr("idCus") = dgvData2.Rows(e.RowIndex).Cells(idCus2.Name).Value
            dgvData2.Rows.RemoveAt(e.RowIndex)
            dt1.Rows.Add(dr)

            dt1.DefaultView.Sort = "CusName_"
            dgvData1.DataSource = dt1

            'Set จำนวนทั้งหมด
            SumTotal1()
            SumTotal2()

        End If
    End Sub
#End Region
#Region "CellClickDataGrid3"

    Private Sub dgvData3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData3.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvData3.Columns(e.ColumnIndex).Name = btFalseOut.Name Then

            '------------------------- Add Data DataTable -------------------------------
            Dim dr As DataRow
            dr = dt1.NewRow

            dr("CusName_") = dgvData3.Rows(e.RowIndex).Cells(CusName3.Name).Value
            dr("Address") = dgvData3.Rows(e.RowIndex).Cells(Address3.Name).Value
            dr("PsName") = dgvData3.Rows(e.RowIndex).Cells(PsName3.Name).Value
            dr("idCus") = dgvData3.Rows(e.RowIndex).Cells(idCus3.Name).Value
            dgvData3.Rows.RemoveAt(e.RowIndex)
            dt1.Rows.Add(dr)

            dt1.DefaultView.Sort = "CusName_"
            dgvData1.DataSource = dt1

            'Set จำนวนทั้งหมด
            SumTotal1()
            SumTotal3()

        End If
    End Sub
#End Region

    Private Sub cbSearchCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSearchCus.CheckedChanged
        If cbSearchCus.Checked = True Then
            txtSearchCus.Enabled = True
        Else
            txtSearchCus.Text = ""
            txtSearchCus.Enabled = False
        End If
    End Sub

    Private Sub cbPsName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPsName.CheckedChanged
        If cbPsName.Checked = True Then
            ComboPsName.Enabled = True
        Else
            ComboPsName.Enabled = False
        End If
    End Sub

    Private Sub txtSearch()
        Dim dv As New DataView(dt1)
        Dim strSubCombo As String = ""
        If cbPsName.Checked = True And cbSearchCus.Checked = True Then
            strSubCombo = ComboPsName.SelectedValue
            dv.RowFilter = "CusName_ LIKE  '%" & txtSearchCus.Text & "%' AND PsName LIKE  '%" & strSubCombo & "%'"
        ElseIf cbSearchCus.Checked = True Then
            dv.RowFilter = "CusName_ LIKE  '%" & txtSearchCus.Text & "%'"
        ElseIf cbPsName.Checked = True Then
            dv.RowFilter = "PsName LIKE  '%" & ComboPsName.SelectedValue & "%'"

        End If
        dv.Sort = "CusName_"
        dgvData1.DataSource = dv
        SumTotal1()
        If dgvData1.Rows.Count < 1 Then
            MessageBox.Show("ไม่พบที่ค้นหา", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearch.Click
        txtSearch()
    End Sub

    Private Sub txtSearchCus_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchCus.KeyPress
        Select Case Asc(e.KeyChar)
            'block enter
            Case 13 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = True
        End Select
    End Sub
End Class