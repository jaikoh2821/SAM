Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmSlSaleGroupDt
    Dim dtMain As New DataTable
    Dim stLoad As Integer = 0
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Enum eProcess
        eNew
        eView
    End Enum

    Dim xProcess As eProcess
    Sub New(ByVal aProcess As eProcess, ByVal idGroupMt As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub
    Private Sub FrmSlSaleGroupDt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setCmbGroupComp(Me.cmbGroupComp)
        initDataTable(dtMain)

        GCSaleSH.DataSource = dtMain
        stLoad = 1
    End Sub


    Private Sub btnSelDoc_Click(sender As Object, e As EventArgs) Handles btnSelDoc.Click
        If lblPartnerName.Text = "" Then
            MessageBox.Show("กรุณาเลือกชื่อลูกค้าที่ต้องการจัดกลุ่ม " & vbNewLine &
                            "ก่อนเลือกใบแจ้งหนี้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        Dim strIDSel As String = "0"

        If GVSaleSH.DataRowCount > 0 Then
            strIDSel = GVSaleSH.GetRowCellValue(0, ColidSale)
            For i As Integer = 1 To GVSaleSH.DataRowCount - 1
                strIDSel = strIDSel & "," & GVSaleSH.GetRowCellValue(i, ColidSale)
            Next
        End If

        Dim strPartnerNames As String = ""
        If lblPartnerName.Text.Trim <> "" Then
            strPartnerNames = lblPartnerName.Text.Trim
            Dim strarr() As String
            strarr = strPartnerNames.Split("-")

            For Each s As String In strarr
                strPartnerNames = s
            Next
        End If

        Dim vFrm As New FrmSaleSHSelect(FrmSaleSHSelect.eProcess.eSel, strIDSel, cmbGroupComp.SelectedValue, strPartnerNames)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            mdLoadShow()
            For i As Integer = 0 To vFrm.dtSel.Rows.Count - 1
                GVSaleSH.AddNewRow()
                Dim row As Integer = GVSaleSH.GetRowHandle(GVSaleSH.DataRowCount)

                With GVSaleSH
                    .SetRowCellValue(row, ColidSaleMt, vFrm.dtSel.Rows(i).Item("idSale"))
                    .SetRowCellValue(row, ColDocRef, vFrm.dtSel.Rows(i).Item("DocRef"))
                    .SetRowCellValue(row, ColidPartner, vFrm.dtSel.Rows(i).Item("idPartner"))
                    .SetRowCellValue(row, ColCusName, "ปุ๋ย,ยา " & vFrm.dtSel.Rows(i).Item("PartnerNameBill"))
                    .SetRowCellValue(row, ColDateSale, vFrm.dtSel.Rows(i).Item("DateSaleD"))
                    .SetRowCellValue(row, ColTotalNet1, vFrm.dtSel.Rows(i).Item("TotalNet"))
                    .SetRowCellValue(row, ColBathText, "บาท")
                End With

                GVSaleSH.UpdateCurrentRow()
            Next
            mdLoadCommitt()
        End If
    End Sub
    Private Sub GGVSaleSH_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GVSaleSH.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If
    End Sub
    Private Sub initDataTable(sender As Object)
        sender.Columns.Add("idSale", System.Type.GetType("System.Int32"))
        sender.Columns.Add("DocRef", System.Type.GetType("System.String"))
        sender.Columns.Add("idPartnerBill", System.Type.GetType("System.Int32"))
        sender.Columns.Add("PartnerNameBill", System.Type.GetType("System.String"))
        sender.Columns.Add("TotalNet", System.Type.GetType("System.Double"))
        sender.Columns.Add("idJobMt", System.Type.GetType("System.Int32"))
        sender.Columns.Add("ZoneName", System.Type.GetType("System.String"))
        sender.Columns.Add("DateSaleD", System.Type.GetType("System.DateTime"))
        sender.Columns.Add("BathText", System.Type.GetType("System.String"))
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If GVSaleSH.DataRowCount = 0 Then
            MessageBox.Show("กรุณาเลือกใบแจ้งหนี้ที่ต้องการรวบรวมอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            If lblPartnerName.Text = "" Then
                MessageBox.Show("กรุณาเลือกชื่อลูกค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

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

                    Dim Group_DocCode As String = ""
                    Dim getDate As String = CType(Date.Today, String)

                    Dim Prefixcode As String = "IV-GR"

                    Prefixcode = Prefixcode & (Microsoft.VisualBasic.Right(getDate, 2))
                    Group_DocCode = getDocCode_Group(Prefixcode)


                    Dim idGroupMt As Integer = 0
                    Dim dateGrBill As DateTime = Convert.ToDateTime(dtpGroupBill.Value, _cultureEnInfo)

                    Dim query As String = "INSERT Into SmSaleGroupMt(DocCodeGroup, DateDocGroup, idPartnerGroup, PartnerNameGroup, idPsTs , DateTs, idComp, Note) " & vbNewLine &
                                          "Values('" & Group_DocCode & "'," & "'" & dateGrBill.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "'," & vbNewLine &
                                          Me.lblPartnerName.Tag & ",'" & Me.lblPartnerName.Text.Trim & "'," & sPsId & ",GETDATE(), " & cmbGroupComp.SelectedValue & "," & vbNewLine &
                                          "'" & txtNote.Text.Trim & "')"
                    mycommand.CommandText = query

                    Dim query2 As String = "Select @@Identity"
                    mycommand.ExecuteNonQuery()
                    mycommand.CommandText = query2
                    idGroupMt = mycommand.ExecuteScalar()

                    Dim SumTotalNet As Double = 0
                    '--- Insert SmSaleDtAll----'
                    For i As Integer = 0 To GVSaleSH.DataRowCount - 1
                        Dim dr As DataRow = GVSaleSH.GetDataRow(i)

                        SumTotalNet = SumTotalNet + dr.Item("TotalNet")
                        'ถ้าไม่มี Insert
                        mycommand.CommandText = "Insert Into SmSaleGroupDt(idGroupMt, idSale, DocRef, idPartnerBill, PartnerNameBill, TotalBill) " & vbNewLine &
                                                            "Values(" & idGroupMt & ", " & vbNewLine &
                                                            dr.Item("idSale") & ", " & vbNewLine &
                                                            "'" & dr.Item("DocRef") & "', " & vbNewLine &
                                                             dr.Item("idPartnerBill") & ", " & vbNewLine &
                                                            "'" & dr.Item("PartnerNameBill") & "', " & vbNewLine &
                                                            CDbl(dr.Item("TotalNet")) & ")"
                        mycommand.ExecuteNonQuery()

                        mycommand.CommandText = "UPDATE SmSaleMt SET stGroup = 1 WHERE idSale = " & dr.Item("idSale")
                        mycommand.ExecuteNonQuery()
                    Next

                    mycommand.CommandText = "UPDATE SmSaleGroupMt SET TotalNet = " & SumTotalNet & " WHERE idGroupMt = " & idGroupMt
                    mycommand.ExecuteNonQuery()

                    ' Attempt to commit the transaction.
                    mytransaction.Commit()
                    'SplashScreenManager.CloseForm(False)
                    mdLoadCommitt()
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()

                Catch ex As Exception
                    ' Attempt to roll back the transaction.
                    Try
                        mytransaction.Rollback()
                        'SplashScreenManager.CloseForm(False)
                        mdLoadCommitt()
                        MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                                 sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

                    Catch e2x As Exception
                        'SplashScreenManager.CloseForm(False)
                        mdLoadCommitt()
                        'MessageBox.Show(ex.Message, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                                 sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    End Try

                End Try


            End Using
        End If
    End Sub

    Function getDocCode_Group(ByVal Prefixcode As String) As String
        Dim DocCode As String = ""
        Dim nextOrder As String = ""
        Dim CodeYear As String = ""


        mdCnOpen()
        Dim sDt As New DataTable
        sDs.Tables.Clear()
        ' sCommand.CommandText = "SELECT MAX(DocCode) AS max_DocCode, MAX(SUBSTRING(DocCode, 3, 2)) AS year_docCode FROM SmSaleOrderMt"
        sCommand.CommandText = "SELECT MAX(DocCodeGroup) as max_DocCode, SUBSTRING(MAX(DocCodeGroup), 3, 2) AS year_docCode" & vbNewLine &
                               "FROM SmSaleGroupMt " & vbNewLine &
                               "WHERE idComp = " & cmbGroupComp.SelectedValue
        sAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocCode")) = True Then
            DocCode = Prefixcode & "/" & "00001"
        Else
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocCode"), 5)
            Dim temp As Integer
            temp = CInt(RunningCode) + 1
            If temp < 10 Then
                nextOrder = "0000" & CStr(temp)
            ElseIf temp < 100 Then
                nextOrder = "000" & CStr(temp)
            ElseIf temp < 1000 Then
                nextOrder = "00" & CStr(temp)
            ElseIf temp < 10000 Then
                nextOrder = "0" & CStr(temp)
            Else
                nextOrder = CStr(temp)
            End If
            DocCode = Prefixcode & "/" & nextOrder
        End If

        Return DocCode
    End Function

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelectAllChkSt, cmbGroupComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

            Me.lblPartnerName.Tag = vFrm.idPartner
            Me.lblPartnerName.Text = vFrm.CusName
        End If
    End Sub

    Private Sub rptDel_Click(sender As Object, e As EventArgs) Handles rptDel.Click
        If GVSaleSH.FocusedRowHandle >= 0 Then
            If lbrMsg.MsgQuestion("คุณต้องการลบรายการใช่หรือไม่?") = True Then
                Dim dr As DataRow = GVSaleSH.GetDataRow(GVSaleSH.FocusedRowHandle)
                dr.Delete()
                dtMain.AcceptChanges()
            End If


        End If
    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            lblPartnerName.Text = ""
            dtMain.Clear()
            GCSaleSH.DataSource = dtMain
        End If
    End Sub

    Private Sub lblPartnerName_TextChanged(sender As Object, e As EventArgs) Handles lblPartnerName.TextChanged
        If stLoad = 1 Then
            dtMain.Clear()
            GCSaleSH.DataSource = dtMain
        End If
    End Sub
End Class