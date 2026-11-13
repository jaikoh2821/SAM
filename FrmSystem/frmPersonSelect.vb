'Update New Grid & New view (vPersonxSelect) by Chatnaree P. Date: 22/4/2563
Public Class frmPersonSelect
    Public mId As Integer
    Public mCode, mName As String ', mNameF, mNameS, mNickName
    Public sDtPs2 As New DataTable
    Public sDtPs As New DataTable
    Dim screen_data As String = ""
    Dim arraylist As New ArrayList
    Dim Process As eProcess

    Public dIdComp As Integer

    Enum eProcess
        eSelect
        ' eCheckbox
        ePsSale
        ePsPay
    End Enum

    Sub New(ByVal aProcess As eProcess)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Select Case aProcess
            Case eProcess.eSelect
                ColSelect.Visible = False
                'dgvData.Columns(colChk.Name).Visible = False
                'dgvData.Columns(colSelect.Name).Visible = True

                'Case eProcess.eCheckbox
                '    dgvData.Columns(colChk.Name).Visible = True
                '    dgvData.Columns(colSelect.Name).Visible = False
                '    btn_save.Visible = True
                '    Me.Text = "เลือกพนักงาน"

            Case eProcess.ePsSale
                Me.Text = "เลือกเจ้าหน้าที่ขาย"
                ColSelect.Visible = False
            Case eProcess.ePsPay
                Me.Text = "เลือกผู้รักษาเงินสดย่อย"
                ColSelect.Visible = False
        End Select

        Process = aProcess

    End Sub
    Private Sub frmCtPsSelect_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtCondition.Focus()
        Select Case Process
            'Case eProcess.eCheckbox
            '    setDataCheckBox()
            Case eProcess.ePsPay 'ผู้รักษาเงินสดย่อย เพิ่มเมื่อวันที่ 7/2/2562 ดอม ณัฐสิทธิ์
                setDataPsPay()
            Case Else
                pSetData()
        End Select
        Me.CenterToScreen()
    End Sub

    Private Sub pSetData()
        mdCnOpen()
        mdLoadShow()
        Dim vWhere As String = ""
        'If txtCondition.Text.Trim <> "" Then
        '    vWhere &= "AND PsName LIKE '%" + txtCondition.Text + "%' "
        'End If

        If Process = eProcess.ePsSale Then
            vWhere &= "AND idPosition = 2 "
        End If

        Dim vDt As New DataTable
        sCommand.CommandText = "SELECT idPs, PsCode, PsName, PositionName, CompName " & vbNewLine &
                                "FROM vPersonxSelect " & vbNewLine &
                                "WHERE stDel = 0 AND idStWork <> 4 " & vWhere & vbNewLine &
                                "ORDER BY PsName"
        sAdapter.Fill(vDt)
        If vDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลพนักงาน", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Exit Sub
        End If
        GC_Person.DataSource = vDt
        mdLoadCommitt()
    End Sub

    Private Sub setDataPsPay()
        mdCnOpen()
        mdLoadShow()
        'Dim vWhere As String = ""
        'If txtCondition.Text.Trim <> "" Then
        '    vWhere &= " AND pch.psPay LIKE '%" + txtCondition.Text + "%' "
        'End If

        Dim temp As New DataTable
        sCommand.CommandText = "SELECT pch.psPay AS PsName, pch.idPsPay As idPs, gr.PsCode, gr.PositionName, com.CompName " & vbNewLine &
                                "FROM pchinvandproject.dbo.vPchCashSubStart pch " & vbNewLine &
                                "LEFT JOIN gr_group.devsk.vPersonxSelect gr ON pch.idPsPay = gr.idps" & vbNewLine &
                                "LEFT JOIN pchinvandproject.dbo.dCompany com ON pch.idComp = com.idcomp" & vbNewLine &
                                "WHERE pch.idComp = " & dIdComp & vbNewLine &
                                "AND pch.idPsPay NOT IN (SELECT recid FROM HR_Seeds.hr.vw_employeeresign WHERE delstatus = 0)" & vbNewLine &
                                "ORDER BY pch.idPsPay ASC"
        sAdapter.Fill(temp)
        If temp.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลพนักงาน", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Exit Sub
        End If
        GC_Person.DataSource = temp
        mdLoadCommitt()
    End Sub

    Private Sub rpsSelect_Click(sender As Object, e As EventArgs) Handles rpsSelect.Click
        Dim dr As DataRow = gv_Person.GetDataRow(gv_Person.FocusedRowHandle)
        mId = dr.Item("idPs")
        mCode = dr.Item("PsCode")
        mName = dr.Item("PsName")

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub gv_Person_KeyDown(sender As Object, e As KeyEventArgs) Handles gv_Person.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dr As DataRow = gv_Person.GetDataRow(gv_Person.FocusedRowHandle)
            mId = dr.Item("idPs")
            mCode = dr.Item("PsCode")
            mName = dr.Item("PsName")

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    'Private Sub setDataCheckBox()
    '    Dim searchedValue As String
    '    Dim searchedValue2 As String

    '    For n As Integer = 0 To dgvData.Rows.Count - 1
    '        If CBool(dgvData.Rows(n).Cells(colChk.Name).Value) = True Then
    '            arraylist.Add(dgvData.Rows(n).Cells(colPsId.Name).Value)
    '        End If
    '    Next
    '    mdLoadShow()
    '    mdCnOpen()

    '    Dim vWhere As String = ""
    '    If txtCondition.Text.Trim <> "" Then
    '        vWhere &= "AND PsName LIKE '%" + txtCondition.Text + "%' "
    '    End If

    '    sDtPs2.Clear()
    '    sCommand.CommandText = "SELECT idPs, PsCode, PsName, Positions, CompName " & vbNewLine &
    '                            "FROM vPerson " & vbNewLine &
    '                            "WHERE stDel = 0 AND idStWork <> 4 " & vWhere & vbNewLine &
    '                            "ORDER BY PsName"
    '    sAdapter.Fill(sDtPs2)
    '    dgvData.DataSource = sDtPs2

    '    For i As Integer = 0 To dgvData.Rows.Count - 1
    '        searchedValue = dgvData.Rows(i).Cells(colPsId.Name).Value
    '        For j As Integer = 0 To arraylist.Count - 1
    '            searchedValue2 = arraylist(j)
    '            If searchedValue2 = searchedValue Then
    '                dgvData.Rows(i).Cells(colChk.Name).Value = True
    '            End If
    '        Next
    '    Next

    '    For i As Integer = 0 To dgvData.Rows.Count - 1
    '        searchedValue = dgvData.Rows(i).Cells(colPsId.Name).Value
    '        For j As Integer = 0 To sDtPs.Rows.Count - 1
    '            searchedValue2 = sDtPs.Rows(j).Item(1)
    '            If searchedValue2 = searchedValue Then
    '                dgvData.Rows(i).Cells(colChk.Name).Value = True
    '            End If
    '        Next
    '    Next

    '    If dgvData.Rows.Count = 0 Then
    '        mdLoadCommitt()
    '        MessageBox.Show("ไม่พบข้อมูล", sSystemName)
    '    End If

    '    mdLoadCommitt()

    'End Sub

    'Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Select Case Process
    '        'Case eProcess.eCheckbox
    '        '    setDataCheckBox()
    '        Case eProcess.ePsPay 'ผู้รักษาเงินสดย่อย เพิ่มเมื่อวันที่ 7/2/2562 ดอม ณัฐสิทธิ์
    '            setDataPsPay()
    '        Case Else
    '            pSetData()
    '    End Select

    'End Sub

    Public Sub setCompPsPaySelect(ByVal id As Integer)
        dIdComp = id
    End Sub


    'Private Sub txtCondition_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCondition.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        Select Case Process
    '            'Case eProcess.eCheckbox
    '            '    setDataCheckBox()
    '            'Case eProcess.ePsPay
    '            '    setDataPsPay()
    '            Case Else
    '                pSetData()
    '        End Select
    '    End If
    'End Sub

    'Private Sub dgvData_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    If dgvData.Columns(e.ColumnIndex).Name = colSelect.Name Then
    '        mId = dgvData.Rows(e.RowIndex).Cells(colPsId.Name).Value
    '        mCode = dgvData.Rows(e.RowIndex).Cells(colPsCode.Name).Value
    '        mName = dgvData.Rows(e.RowIndex).Cells(colPsName.Name).Value
    '        'mNameF = dgvData.Rows(e.RowIndex).Cells(colPsNameF.Name).Value
    '        'mNameS = dgvData.Rows(e.RowIndex).Cells(colPsNameS.Name).Value
    '        'mNickName = dgvData.Rows(e.RowIndex).Cells(colPsNickName.Name).Value
    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '    End If
    'End Sub

    Public Sub Get_DataChkBox(ByVal sDt As DataTable)
        sDtPs = sDt
    End Sub

    Private Sub txtCondition_TextChanged(sender As Object, e As EventArgs) Handles txtCondition.TextChanged
        FilterGridxPerson()
    End Sub

    Private Sub FilterGridxPerson()
        gv_Person.ActiveFilterString = " [PsName] like '%" & Trim(txtCondition.Text) & "%' "
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        arraylist.Clear()
        'For n As Integer = 0 To dgvData.Rows.Count - 1
        '    If CBool(dgvData.Rows(n).Cells(colChk.Name).Value) = True Then
        '        arraylist.Add(dgvData.Rows(n).Cells(colPsId.Name).Value)
        '    End If
        'Next
        'Dim searchedValue As String
        'Dim searchedValue2 As String
        'sDtPs.Clear()

        'For i As Integer = 0 To dgvData.Rows.Count - 1
        '    searchedValue = dgvData.Rows(i).Cells(colPsId.Name).Value
        '    For j As Integer = 0 To arraylist.Count - 1
        '        searchedValue2 = arraylist(j)
        '        If searchedValue2 = searchedValue Then
        '            sDtPs.Rows.Add(dgvData.Rows(i).Cells(colPsName.Name).Value, dgvData.Rows(i).Cells(colPsId.Name).Value)
        '        End If
        '    Next
        'Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class