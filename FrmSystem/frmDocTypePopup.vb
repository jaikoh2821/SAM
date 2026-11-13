Imports System.Data.SqlClient

''' <summary>
''' Popup เพิ่ม/แก้ไข/ลบ ประเภทเอกสาร (dDocumentType) ของบริษัทที่ส่งเข้ามา
''' สร้างคอนโทรลด้วยโค้ดทั้งหมด ไม่ต้องมี Designer
''' ถ้าสร้างเป็น Form ใหม่ใน Visual Studio ให้ลบไฟล์ .Designer.vb ที่ถูกสร้างอัตโนมัติออก หรือเพิ่มเป็นไฟล์ Class ธรรมดาแล้วเปลี่ยนเป็น Inherits Form
''' </summary>
Public Class frmDocTypePopup
    Inherits Form

    Private ReadOnly _idComp As Integer
    Private ReadOnly _CompName As String
    Private WithEvents dgv As New DataGridView
    Private WithEvents btnSave As New Button
    Private WithEvents btnClose As New Button
    Private ReadOnly bs As New BindingSource
    Private dt As DataTable

    Public Sub New(idComp As Integer, CompName As String)
        _idComp = idComp
        _CompName = CompName
        Me.Text = "จัดการประเภทเอกสาร (" & _CompName & ")"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.ClientSize = New Size(420, 420)
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedDialog

        Dim lbl As New Label With {
            .Text = "พิมพ์ในแถวว่างล่างสุดเพื่อเพิ่ม | แก้ไขชื่อได้เลย | กด Delete เพื่อลบ",
            .AutoSize = True, .Location = New Point(12, 10)}

        dgv.RowHeadersVisible = True
        dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgv.RowHeadersWidth = 50
        dgv.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.RowHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Regular)
        dgv.RowHeadersDefaultCellStyle.ForeColor = Color.Black
        dgv.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White

        dgv.SetBounds(12, 34, 396, 330)
        dgv.AutoGenerateColumns = False
        dgv.AllowUserToAddRows = True
        dgv.AllowUserToDeleteRows = True
        dgv.BackgroundColor = SystemColors.Window
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "colId", .DataPropertyName = "idDocType", .Visible = False, .ReadOnly = True})
        dgv.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "colName", .HeaderText = "ชื่อประเภทเอกสาร", .DataPropertyName = "DocTypeName", .MaxInputLength = 200})
        dgv.DataSource = bs

        dgv.Columns("colName").HeaderCell.Style.Font = New Font("Tahoma", 9, FontStyle.Bold)
        dgv.Columns("colName").DefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Regular)


        btnSave.Text = "บันทึก"
        btnSave.SetBounds(228, 376, 85, 30)
        btnClose.Text = "ปิด"
        btnClose.SetBounds(323, 376, 85, 30)

        btnSave.Font = New Font("Tahoma", 9, FontStyle.Bold)
        btnClose.Font = New Font("Tahoma", 9, FontStyle.Bold)

        Me.Controls.AddRange(New Control() {lbl, dgv, btnSave, btnClose})
        Me.AcceptButton = Nothing
        Me.CancelButton = btnClose
    End Sub

    Private Sub frmDocTypePopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.RowHeadersWidth = 50

        mdCnOpen()
        LoadData()
    End Sub

    Private Sub LoadData()
        dt = New DataTable
        sCommand.CommandText = "SELECT idDocType, DocTypeName, idComp " & vbNewLine &
                               "FROM dDocumentType " & vbNewLine &
                               "WHERE idComp = " & _idComp & vbNewLine &
                               "AND ISNULL(stDel,0) = 0 ORDER BY idDocType"
        sAdapter.Fill(dt)
        dt.Columns("idComp").DefaultValue = _idComp
        bs.DataSource = dt
    End Sub

    Private Sub dgv_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv.UserDeletingRow
        If MessageBox.Show("ต้องการลบประเภทเอกสารนี้หรือไม่?", "ยืนยันการลบ",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dgv.EndEdit()
        bs.EndEdit()

        For Each r As DataRow In dt.Rows
            If r.RowState = DataRowState.Deleted Then Continue For
            If String.IsNullOrWhiteSpace(Convert.ToString(r("DocTypeName"))) Then
                MessageBox.Show("กรุณากรอกชื่อประเภทเอกสาร", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Next

        If dt.GetChanges() Is Nothing Then Return

        Using myconnection As New SqlConnection(conStr)
            myconnection.Open()
            Dim mycommand As New SqlCommand()
            ' Dim mycommand As SqlCommand = myconnection.CreateCommand()
            Dim mytransaction As SqlTransaction
            Dim myAdapter As New SqlDataAdapter(mycommand)
            ' Start a local transaction
            mytransaction = myconnection.BeginTransaction()

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            mycommand.Connection = myconnection
            mycommand.Transaction = mytransaction

            Try
                For Each r As DataRow In dt.Rows
                    Select Case r.RowState

                        Case DataRowState.Added

                            mycommand.CommandText = "INSERT INTO dDocumentType (DocTypeName, idComp, idPsUpdate, DateUpdate)" &
                                                    "VALUES (@n, @comp, @ps, GETDATE())"
                            With mycommand.Parameters
                                .Add("@n", SqlDbType.VarChar).Value = r("DocTypeName")
                                .Add("@comp", SqlDbType.VarChar).Value = _idComp
                                .Add("@ps", SqlDbType.Int).Value = sPsId
                            End With

                            mycommand.ExecuteNonQuery()
                            mycommand.Parameters.Clear()

                        Case DataRowState.Modified
                            Dim id As Object = r("idDocType", DataRowVersion.Original)
                            mycommand.CommandText = "UPDATE dDocumentType SET DocTypeName=@n, idPsUpdate=@ps, DateUpdate=GETDATE() " &
                                                    "WHERE idDocType=@id"

                            With mycommand.Parameters
                                .Add("@n", SqlDbType.VarChar).Value = r("DocTypeName")
                                .Add("@ps", SqlDbType.Int).Value = sPsId
                                .Add("@id", SqlDbType.Int).Value = id
                            End With
                            mycommand.ExecuteNonQuery()
                            mycommand.Parameters.Clear()

                        Case DataRowState.Deleted
                            Dim id As Object = r("idDocType", DataRowVersion.Original)

                            mycommand.CommandText = "UPDATE dDocumentType SET stDel=" & sPsId & ", DateDelete = GETDATE()" &
                                                    "WHERE idDocType=@id"
                            With mycommand.Parameters
                                .Add("@id", SqlDbType.Int).Value = id
                            End With

                            mycommand.ExecuteNonQuery()
                            mycommand.Parameters.Clear()
                    End Select
                Next
                mytransaction.Commit()
            Catch ex As Exception
                mytransaction.Rollback()
                MessageBox.Show(ex.Message, "บันทึกไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LoadData()
                Return
            End Try
        End Using

        MessageBox.Show("บันทึกเรียบร้อย", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub RenumberRows()
        For i As Integer = 0 To dgv.Rows.Count - 1
            If Not dgv.Rows(i).IsNewRow Then
                dgv.Rows(i).HeaderCell.Value = (i + 1).ToString()
            End If
        Next
    End Sub

    Private Sub dgv_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgv.DataBindingComplete
        RenumberRows()
    End Sub

    Private Sub dgv_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv.RowsAdded
        RenumberRows()
    End Sub

    Private Sub dgv_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgv.RowsRemoved
        RenumberRows()
    End Sub

End Class
