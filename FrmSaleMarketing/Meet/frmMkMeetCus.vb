Public Class frmMkMeetCus
    Dim dt1 As New DataTable
    Public sMeetName As String
    Public sIdMeet As String
    Dim eEvent As eProcess
    Dim DelMeetData As String = ""

    Enum eProcess
        eAdditon
        eChange
    End Enum

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eAdditon
                Me.dgvData1.Columns(Me.change.Name).Visible = False
                btn_save.Visible = True
                Text = "ทำรายการบันทึกหัวข้อการเข้าพบคู่ค้า"
                MaximizeBox = False
                MinimizeBox = False
            Case eProcess.eChange
                'me.dgvData1.
                Me.dgvData1.AllowUserToAddRows = False
                Me.dgvData1.Columns(Me.change.Name).Visible = True
                Me.dgvData1.Columns(Me.MeetName.Name).ReadOnly = True
                Me.dgvData1.Columns(Me.MeetName.Name).DefaultCellStyle.BackColor = Color.WhiteSmoke
                Me.dgvData1.Columns(Me.MeetNote.Name).DefaultCellStyle.BackColor = Color.WhiteSmoke
                Me.dgvData1.Columns(Me.MeetNote.Name).ReadOnly = True
                Me.dgvData1.Columns(Me.del.Name).Visible = False
                btn_save.Visible = False
                Text = "เลือกหัวข้อการเข้าพบคู่ค้า"
                MaximizeBox = False
                MinimizeBox = False
        End Select
        eEvent = aProcess
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showDataOnGrid1()
    End Sub

    Private Sub showDataOnGrid1()
        Dim dt As New DataTable
        mdCnOpen()
        dt1.Clear()
        sCommand.CommandText = "SELECT idMeet, MeetName, MeetNote From SmMkMeetData  ORDER BY MeetName ASC"
        sAdapter.Fill(dt1)
        dgvData1.DataSource = dt1
    End Sub

    Private Sub dgvExpense_RowPostPaint1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData1.RowPostPaint
        Me.dgvData1("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim SQL As String = ""
        Dim dv1 As New DataView(dt1)
        Dim dv2 As New DataView(dt1)
        Dim dr As DataRowView

        Dim UpDateMeet As String = "UPDATE SmMkMeetData SET MeetName='"
        For i As Integer = 0 To dgvData1.Rows.Count - 2
            dr = dv1(i)
            If dr.Row.RowState = DataRowState.Added Then
                SQL &= "INSERT INTO SmMkMeetData (MeetName, MeetNote) VALUES ('" & dv1.Item(i).Row.Item("MeetName") & "', " & IIf(IsDBNull(dv1.Item(i).Row.Item("MeetNote")), "NULL", "'" & dv1.Item(i).Row.Item("MeetNote") & "'") & ")" & Environment.NewLine
            End If
            If dr.Row.RowState = DataRowState.Modified Then
                SQL &= UpDateMeet & dv1.Item(i).Row.Item("MeetName") & "', MeetNote=" & IIf(IsDBNull(dv1.Item(i).Row.Item("MeetNote")), "NULL", "'" & dv1.Item(i).Row.Item("MeetNote") & "'") & " WHERE idMeet='" & dv1.Item(i).Row.Item("idMeet") & "'" & Environment.NewLine
            End If
            'เช็คข้อมูลซ้ำ
            dv2.RowFilter = "MeetName = '" & dv1.Item(i).Row.Item("MeetName") & "'"
            If dv2.Count > 1 Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจาก " & Environment.NewLine & " -  หัวข้อการเข้าพบคู่ค้าซ้ำ ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                SQL = ""
                Exit Sub
            End If
            'เช็คข้อมูลว่าง
            If dv1.Item(i).Row.Item("MeetName").ToString = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจาก " & Environment.NewLine & " -  มีหัวข้อการเข้าพบคู่ค้าว่าง ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                SQL = ""
                Exit Sub
            End If
        Next
        If SQL = "" And DelMeetData = "" Then
            MessageBox.Show("กรุณาทำรายการก่อนกด 'บันทึก'", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'MessageBox.Show(SQL & DelMeetData)
        Try
            Dim result As New DialogResult
            result = MessageBox.Show("ต้องการบันทึกข้อมูล ใช่หรือไม่ ?", "SAM", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = Windows.Forms.DialogResult.Yes Then
                mdCnOpen()
                sCommand.CommandText = SQL & DelMeetData
                sCommand.ExecuteNonQuery()
                DelMeetData = ""
                showDataOnGrid1()
                MessageBox.Show("ระบบได้ทำการบันทึกข้อมูลเรียบร้อยแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvData1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData1.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Dim frm As New frmMkMeetCusTs
        If dgvData1.Columns(e.ColumnIndex).Name = change.Name And Not dgvData1.Rows(e.RowIndex).Cells(idMeet.Name).Value Is DBNull.Value Then
            sMeetName = dgvData1.Rows(e.RowIndex).Cells(MeetName.Name).Value
            sIdMeet = dgvData1.Rows(e.RowIndex).Cells(idMeet.Name).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        Try
            mdCnOpen()
            If dgvData1.Columns(e.ColumnIndex).Name = del.Name Then
                Dim CurRow As Integer
                CurRow = Me.dgvData1.CurrentRow.Index

                If Me.dgvData1.Rows.Count <> 1 Then
                    Dim Result As MsgBoxResult
                    Result = MessageBox.Show("คุณต้องการลบหัวข้อ  '" & dgvData1.Rows(e.RowIndex).Cells(MeetName.Name).Value & "'  ?", "ยืนยัน", MessageBoxButtons.YesNo, _
                                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If Result = MsgBoxResult.Yes Then
                        'เช็คข้อมูลถูกนำไปใช้หรือยัง
                        Dim chk_idMeet As New DataTable
                        sCommand.CommandText = "SELECT COUNT(idMeet) As Cnt_idMeet FROM SmMkMeet WHERE idMeet='" & dgvData1.Rows(e.RowIndex).Cells(idMeet.Name).Value & "'"
                        sAdapter.Fill(chk_idMeet)
                        If chk_idMeet.Rows(0).Item("Cnt_idMeet") > 0 Then
                            MessageBox.Show("ไม่สามารถลบข้อมูลนี้ได้เนื่องจาก" & Environment.NewLine & "  -  ข้อมูลถูกนำไปใช้แล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                        If dgvData1.Rows(e.RowIndex).Cells(idMeet.Name).Value.ToString() <> "" Then
                            DelMeetData &= "DELETE FROM SmMkMeetData WHERE idMeet = '" & dgvData1.Rows(e.RowIndex).Cells(idMeet.Name).Value & "'" & Environment.NewLine
                        End If
                        'sCommand.CommandText = "DELETE FROM SmMkMeetData WHERE (idMeet = '" & dgvData1.Rows(e.RowIndex).Cells(idMeet.Name).Value & "')"
                        'sCommand.ExecuteNonQuery()
                        Me.dt1.Rows.RemoveAt(CurRow)
                    End If
                End If
            End If
        Catch ex As Exception
            Try
                Dim CurRow As Integer
                CurRow = Me.dgvData1.CurrentRow.Index
                Me.dgvData1.Rows.RemoveAt(CurRow)
            Catch exc As Exception
                MessageBox.Show("ไม่สามารถลบแถวนี้ได้", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Try
    End Sub

    Private Sub dgvData1_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvData1.RowsAdded
        For i As Integer = 0 To dgvData1.Rows.Count - 1
            dgvData1.Rows(i).Cells(del.Name).Value = My.Resources.ResourceManager.GetObject("Actions-button-cancel-icon (1)")
            dgvData1.Rows(i).Cells(change.Name).Value = My.Resources.ResourceManager.GetObject("Actions-true")
        Next
    End Sub
End Class
