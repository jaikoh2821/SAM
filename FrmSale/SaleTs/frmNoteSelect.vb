Imports System.Data.SqlClient
Imports DevExpress.XtraSplashScreen

Public Class frmNoteSelect
    ' Dim MainReturn As New DataTable
    Public Note As String = ""
    Dim gidComp As Integer = 0
    Dim stload As Integer = 0

    Enum eProcess
        eAdd
        eSelect
    End Enum

    Dim aEvent As eProcess
    Dim dtDel As New DataTable
    Dim dtData As New DataTable

    Sub New(ByVal aProcess As eProcess, ByVal idComp As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        aEvent = aProcess

        If aEvent = eProcess.eSelect Then
            Me.Text = "เลือกคำอธิบายรายการ"
            colDel.Visible = False
            pnSave.Visible = False
            gidComp = idComp
        ElseIf aEvent = eProcess.eAdd Then
            Me.Text = "เพิ่ม/แก้ไขคำอธิบายรายการ"
            GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True
            GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            colNote.OptionsColumn.AllowEdit = True
            colNote.OptionsColumn.ReadOnly = False
        End If

        fnAddDataTable(dtDel)
        fnAddDataTable(dtData)
    End Sub

    Private Sub fnAddDataTable(ByRef dataTable As DataTable)
        dataTable.Columns.Add("Note", System.Type.GetType("System.String"))
        dataTable.Columns.Add("idNote", System.Type.GetType("System.Int64"))
    End Sub

    Private Sub frmSelNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdLoadShow()
        setCmbGroupComp(cmbGroupComp)
        'mdCnOpen()
        'Dim dt As New DataTable
        'sCommand.CommandText = "SELECT CompName " & vbNewLine &
        '                        "FROM [PchInvAndProject].[dbo].[dCompany]" & vbNewLine &
        '                        "WHERE idComp = " & gidComp
        'sAdapter.Fill(dt)


        'lblCompanyName.Text = dt.Rows(0).Item("CompName")

        If aEvent = eProcess.eSelect Then
            cmbGroupComp.SelectedValue = gidComp
            cmbGroupComp.Enabled = False
        End If
        ShowDataOnGrid()
        stload = 1
        GridView1.Focus()
        mdLoadCommitt()
    End Sub

    Private Sub ShowDataOnGrid()
        mdCnOpen()
        dtData.Clear()
        Try
            sCommand.CommandText = "SELECT d.idNote, d.Note ,d.Note As NoteHide " & vbNewLine &
                                    "FROM dCenterNote As d " & vbNewLine &
                                    "WHERE d.idComp = " & cmbGroupComp.SelectedValue
            sAdapter.Fill(dtData)

            GridControl1.DataSource = dtData
            If dtData.Rows.Count = 0 And aEvent = eProcess.eSelect Then
                mdLoadCommitt()
                MessageBox.Show("ไม่พบข้อมูลคำอธิบายรายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        Using myconnection As New SqlConnection(conStr)
            myconnection.Open()
            Dim mycommand As New SqlCommand()
            ' Dim mycommand As SqlCommand = myconnection.CreateCommand()
            Dim mytransaction As SqlTransaction

            ' Start a local transaction
            mytransaction = myconnection.BeginTransaction()

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            mycommand.Connection = myconnection
            mycommand.Transaction = mytransaction


            Try
                For j As Integer = 0 To GridView1.RowCount - 2
                    Dim dr As DataRow = GridView1.GetDataRow(j)
                    Dim Note As String = ""
                    Note = dr.Item("Note").Replace("'", "''")


                    'Case1: Add New Note
                    If IsDBNull(dr.Item("idNote")) Then
                        Dim str As String = "INSERT INTO dCenterNote (Note, idComp,idPsUpdate,DateUpdate) " & vbNewLine & _
                                            "VALUES ('" & Note & "', " & cmbGroupComp.SelectedValue & "," & sPsId & ", GETDATE())"

                        mycommand.CommandText = str
                        mycommand.ExecuteNonQuery()
                    End If

                    'Case2: Row Delete
                    If dtDel.Rows.Count <> 0 Or (IsDBNull(GridView1.GetDataRow(j).Item("Note")) And Not IsDBNull(GridView1.GetDataRow(j).Item("Note"))) Then
                        For i As Integer = 0 To dtDel.Rows.Count - 1
                            Dim drDel As DataRow = dtDel.Rows(i)
                            mycommand.CommandText = "DELETE FROM dCenterNote WHERE idNote = " & drDel.Item("idNote")
                            mycommand.ExecuteNonQuery()
                        Next
                    End If

                    'Case3: Change Data Note (Row Update) 
                    If Not IsDBNull(dr.Item("idNote")) Then
                        Dim drOld As DataRow = dtData.Rows(j)
                        If drOld.Item("NoteHide") <> GridView1.GetDataRow(j).Item("Note") Then
                            If (GridView1.GetDataRow(j).Item("Note") <> "" And (Not IsDBNull(GridView1.GetDataRow(j).Item("idNote")))) Then
                                mycommand.CommandText = "UPDATE dCenterNote SET Note = '" & Note & "', idPsUpdate = " & sPsId & ", DateUpDate = GETDATE() WHERE idNote = " & GridView1.GetDataRow(j).Item("idNote")
                                mycommand.ExecuteNonQuery()
                            ElseIf (GridView1.GetDataRow(j).Item("Note") = "" And Not IsDBNull(GridView1.GetDataRow(j).Item("idNote"))) Then

                                mycommand.CommandText = "DELETE FROM dCenterNote WHERE idNote = " & GridView1.GetDataRow(j).Item("idNote")
                                mycommand.ExecuteNonQuery()

                            End If
                        End If

                    End If
                Next

                mytransaction.Commit()
                ShowDataOnGrid()
                SplashScreenManager.CloseForm(False)
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                ' Attempt to roll back the transaction.
                mytransaction.Rollback()
                SplashScreenManager.CloseForm(False)
                MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
                                         sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            End Try
        End Using
    End Sub

    Private Sub GridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles GridView1.KeyUp
        If e.KeyCode = Keys.Enter And aEvent = eProcess.eSelect Then
            If GridView1.RowCount = 0 Then
                Exit Sub
            End If
            Note = GridView1.GetDataRow(GridView1.FocusedRowHandle).Item("Note")
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub GridControl1_EditorKeyUp(sender As Object, e As KeyEventArgs) Handles GridControl1.EditorKeyUp
        If aEvent = eProcess.eAdd AndAlso e.KeyCode = Keys.Enter Then
            If GridView1.RowCount = 0 Then
                Exit Sub
            Else
                GridView1.FocusedRowHandle = GridView1.FocusedRowHandle + 1
            End If
        End If

    End Sub

    Private Sub GridView1_CustomDrawCell_1(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "colNum" And GridView1.RowCount Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub rptDel_Click(sender As Object, e As EventArgs) Handles rptDel.Click
        Dim focus As Integer = GridView1.GetFocusedDataSourceRowIndex
        'Console.WriteLine(focus)
        'บรรทัดสุดท้าย
        If focus <> -2147483648 Then
            Dim result As DialogResult
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim drtemp As DataRow = dtDel.NewRow()
            result = MessageBox.Show("คุณต้องการจะลบรายการนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = Windows.Forms.DialogResult.OK Then
                drtemp("idNote") = dr.Item("idNote")
                drtemp("Note") = dr.Item("Note")
                dtDel.Rows.Add(drtemp)
                dr.Delete()
                dtData.AcceptChanges()
            End If
        End If
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        If GridView1.RowCount = 0 Then
            Exit Sub
        End If

        Note = GridView1.GetDataRow(GridView1.FocusedRowHandle).Item("Note")
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmbGroupComp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedIndexChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            ShowDataOnGrid()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub
End Class