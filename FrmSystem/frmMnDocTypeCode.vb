Imports System.Data.SqlClient

''' <summary>
''' หน้าจัดการ "รหัสเอกสาร" (dDocumentCode) โดยเลือก "ประเภทเอกสาร" (dDocumentType) เป็น ComboBox ใน DataGridView
''' มีปุ่ม Popup สำหรับเพิ่ม/แก้ไขประเภทเอกสาร (frmDocTypePopup)
''' สร้างคอนโทรลด้วยโค้ดทั้งหมด จึงใช้แทนไฟล์เดิมได้เลย (ไม่ต้องลากวางใน Designer)
''' </summary>
Public Class frmMnDocTypeCode

    Private dtCode As DataTable
    Private dtType As DataTable

    Private _loading As Boolean = False
    Private _lastComp As Integer = -1D
    Dim stLoad As Integer = 0


    Private Sub frmMnDocTypeCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "จัดการรหัสเอกสาร"
        'BuildUI()

        setCmbGroupComp(Me.cmbGroupComp)
        LoadTypes()
        LoadCodes()
        stLoad = 1
    End Sub



    Public Sub LoadTypes()
        mdCnOpen()
        dtType = New DataTable
        sCommand.CommandText = "SELECT idDocType, DocTypeName " & vbNewLine &
                                "FROM dDocumentType " & vbNewLine &
                                "WHERE idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                "AND ISNULL(stDel,0) = 0 " & vbNewLine &
                                "ORDER BY idDocType"

        sAdapter.Fill(dtType)

        rptDocType.DataSource = dtType
        rptDocType.ValueMember = "idDocType"
        rptDocType.DisplayMember = "DocTypeName"

        rptDocType.Columns.Clear()
        rptDocType.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DocTypeName"))
        rptDocType.ShowHeader = False
    End Sub

    Private Sub LoadCodes()
        'dgv.EndEdit()
        LoadTypes()

        dtCode = New DataTable
        sCommand.CommandText = "SELECT idDocCode, idDocType, DocCode, Note, CAST(ISNULL(stRight,0) AS bit) AS stRight, idComp" & vbNewLine &
                                "FROM dDocumentCode " & vbNewLine &
                                "WHERE idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                "AND ISNULL(stDel,0) = 0 " & vbNewLine &
                                "ORDER BY DocCode"

        sAdapter.Fill(dtCode)
        ' แถวใหม่ใน Grid จะได้ idComp ของบริษัทที่เลือกอัตโนมัติ
        'If dtCode.Columns.Contains("idComp") Then dtCode.Columns("idComp").DefaultValue = CurrentComp
        GCDocType.DataSource = dtCode
    End Sub

    Private Function HasPendingChanges() As Boolean
        GVDoctype.CloseEditor()
        GVDoctype.UpdateCurrentRow()

        Return dtCode IsNot Nothing AndAlso dtCode.GetChanges() IsNot Nothing
    End Function

    Private Sub btnType_Click(sender As Object, e As EventArgs) Handles btnType.Click
        'If CurrentComp < 0 Then Return
        Using f As New frmDocTypePopup(cmbGroupComp.SelectedValue, cmbGroupComp.Text)
            f.ShowDialog(Me)
        End Using
        'dgv.EndEdit()
        LoadTypes()
        'dgv.Refresh()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If SaveData() Then
            MessageBox.Show("บันทึกเรียบร้อย", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCodes()
        End If
    End Sub

    Private Sub GVDoctype_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVDoctype.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "colNo" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If
    End Sub

    Private Function RightValue(r As DataRow) As Object
        If Not IsDBNull(r("stRight")) AndAlso Convert.ToBoolean(r("stRight")) Then Return 1
        Return DBNull.Value
    End Function

    Private Function SaveData() As Boolean
        GVDoctype.CloseEditor()
        GVDoctype.UpdateCurrentRow()
        ' ---- ตรวจสอบข้อมูล ----
        For Each r As DataRow In dtCode.Rows
            If r.RowState = DataRowState.Deleted Then Continue For
            If IsDBNull(r("idDocType")) Then
                MessageBox.Show("กรุณาเลือกประเภทเอกสาร", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'SelectRow(r)
                Return False
            End If
            If String.IsNullOrWhiteSpace(Convert.ToString(r("DocCode"))) Then
                MessageBox.Show("กรุณากรอกรหัสเอกสาร", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'SelectRow(r)
                Return False
            End If
        Next

        If dtCode.GetChanges() Is Nothing Then
            MessageBox.Show("ไม่มีข้อมูลที่เปลี่ยนแปลง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        ' ---- บันทึกใน Transaction เดียว ----
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

                For Each r As DataRow In dtCode.Rows
                    Select Case r.RowState

                        Case DataRowState.Added
                            mycommand.CommandText = "INSERT INTO dDocumentCode (idDocType, DocCode, Note, idComp, stRight, idPsUpdate, DateUpdate) " &
                                                    "VALUES (@t, @code, @note, @comp, @right, @ps, GETDATE())"
                            With mycommand.Parameters
                                .Add("@t", SqlDbType.Int).Value = r("idDocType")
                                .Add("@code", SqlDbType.VarChar).Value = r("DocCode")
                                .Add("@note", SqlDbType.VarChar).Value = r("Note")
                                .Add("@comp", SqlDbType.VarChar).Value = cmbGroupComp.SelectedValue
                                .Add("@right", SqlDbType.VarChar).Value = RightValue(r)
                                .Add("@ps", SqlDbType.Int).Value = sPsId
                            End With

                            mycommand.ExecuteNonQuery()
                            mycommand.Parameters.Clear()


                        Case DataRowState.Modified
                            mycommand.CommandText = "UPDATE dDocumentCode SET " & vbNewLine &
                                                    "idDocType = @t, " & vbNewLine &
                                                    "DocCode = @code, " & vbNewLine &
                                                    "Note = @note, " & vbNewLine &
                                                    "stRight = @right, " & vbNewLine &
                                                    "idPsUpdate = @ps, " & vbNewLine &
                                                    "DateUpdate = GETDATE() " & vbNewLine &
                                                    "WHERE idDocCode = @id"

                            With mycommand.Parameters
                                .Add("@t", SqlDbType.Int).Value = r("idDocType")
                                .Add("@code", SqlDbType.VarChar).Value = r("DocCode")
                                .Add("@note", SqlDbType.VarChar).Value = r("Note")
                                .Add("@right", SqlDbType.VarChar).Value = RightValue(r)
                                .Add("@ps", SqlDbType.Int).Value = sPsId
                                .Add("@id", SqlDbType.Int).Value = r("idDocCode", DataRowVersion.Original)
                            End With

                            mycommand.ExecuteNonQuery()
                            mycommand.Parameters.Clear()

                        Case DataRowState.Deleted   ' ลบแบบ Soft delete
                            Dim id As Object = r("idDocCode", DataRowVersion.Original)
                            mycommand.CommandText = "UPDATE dDocumentCode SET stDel = " & sPsId & ", DateDelete = GETDATE()" &
                                                    "WHERE idDocCode = " & id
                            mycommand.ExecuteNonQuery()


                    End Select
                Next
                mytransaction.Commit()
                Return True
            Catch ex As Exception
                mytransaction.Rollback()
                MessageBox.Show("บันทึกไม่สำเร็จ: " & ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            mdCnOpen()
            LoadCodes()
        End If
    End Sub

    Private Sub rptDel_Click(sender As Object, e As EventArgs) Handles rptDel.Click
        Dim rh As Integer = GVDoctype.FocusedRowHandle
        If rh < 0 Then Return          ' แถวใหม่ (#) หรือไม่มีแถว ไม่ต้องลบ

        If MessageBox.Show("ต้องการลบรหัสเอกสารนี้หรือไม่?", "ยืนยันการลบ",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            GVDoctype.DeleteRow(rh)    ' แถวจะหายจากตาราง และถูกลบในฐานข้อมูลตอนกดบันทึก
        End If
    End Sub
End Class
