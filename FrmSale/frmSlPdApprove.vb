Public Class frmSlPdApprove
    Dim wType As New Integer
    Dim chkevent As New Integer
    Sub mdLoadShow()

    End Sub
    Sub mdLoadCommitt()

    End Sub
    Sub New(ByVal Type_Work As Byte)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        wType = Type_Work
        If wType = 1 Then
            CHKcheck.Checked = True
        Else
            CHKapp.Checked = True
        End If
    End Sub
    Private Sub btn_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show.Click
        mdLoadShow()
        pSetData()
        mdLoadCommitt()
    End Sub
    Private Sub dgvExpense_RowPostPaint2(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData.RowPostPaint
        Me.dgvData("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub
    'Public Sub GetTypeAndGetData(ByVal Type_Work As Integer)
    '    wType = Type_Work
    '    If wType = 1 Then
    '        CHKcheck.Checked = True
    '    Else
    '        CHKapp.Checked = True
    '    End If
    '    'pSetData()
    'End Sub

    Private Sub pSetData()
        Dim j As Integer = 0
        Dim k As Integer = 0
        Dim vWhere As String = " "
        Dim SelectTM As String = " "
        DataNumber()
        If CHKname.Checked = True And CHKtype.Checked = False And CHKcheck.Checked = False And CHKapp.Checked = False Then
            vWhere = " Where PdTradeName Like '%" & txtName.Text & "%' "
        ElseIf CHKname.Checked = False And CHKtype.Checked = True And CHKcheck.Checked = False And CHKapp.Checked = False Then
            vWhere = " Where PdTradeName Like '%" & txttype.Text & "%' "
        ElseIf CHKname.Checked = True And CHKtype.Checked = True And CHKcheck.Checked = False And CHKapp.Checked = False Then
            vWhere = " Where PdTradeName Like '%" & txtName.Text & "%' And PlantTypeName Like '%" & txttype.Text & "%' "

        ElseIf CHKname.Checked = True And CHKtype.Checked = False And CHKcheck.Checked = True And CHKapp.Checked = False Then
            vWhere = " Where PdTradeName Like '%" & txtName.Text & "%' AND PsCheck IS NULL"
        ElseIf CHKname.Checked = True And CHKtype.Checked = False And CHKcheck.Checked = False And CHKapp.Checked = True Then
            vWhere = " Where PdTradeName Like '%" & txtName.Text & "%' AND PsApp IS NULL"
        ElseIf CHKname.Checked = True And CHKtype.Checked = False And CHKcheck.Checked = True And CHKapp.Checked = True Then
            vWhere = " Where PdTradeName Like '%" & txtName.Text & "%' AND PsApp IS NULL AND PsCheck IS NULL"

        ElseIf CHKname.Checked = False And CHKtype.Checked = True And CHKcheck.Checked = True And CHKapp.Checked = False Then
            vWhere = " Where PlantTypeName Like '%" & txttype.Text & "%' AND PsCheck IS NULL"
        ElseIf CHKname.Checked = False And CHKtype.Checked = True And CHKcheck.Checked = False And CHKapp.Checked = True Then
            vWhere = " Where PlantTypeName Like '%" & txttype.Text & "%' AND PsApp IS NULL"
        ElseIf CHKname.Checked = False And CHKtype.Checked = True And CHKcheck.Checked = True And CHKapp.Checked = True Then
            vWhere = " Where PlantTypeName Like '%" & txttype.Text & "%' AND PsApp IS NULL AND PsCheck IS NULL"

        ElseIf CHKname.Checked = True And CHKtype.Checked = True And CHKcheck.Checked = True And CHKapp.Checked = False Then
            vWhere = " Where PdTradeName Like '%" & txtName.Text & "%' And PlantTypeName Like '%" & txttype.Text & "%' AND PsCheck IS NULL"
        ElseIf CHKname.Checked = True And CHKtype.Checked = True And CHKcheck.Checked = False And CHKapp.Checked = True Then
            vWhere = " Where PdTradeName Like '%" & txtName.Text & "%' And PlantTypeName Like '%" & txttype.Text & "%' AND PsApp IS NULL"
        ElseIf CHKname.Checked = True And CHKtype.Checked = True And CHKcheck.Checked = True And CHKapp.Checked = True Then
            vWhere = " Where PdTradeName Like '%" & txtName.Text & "%' And PlantTypeName Like '%" & txttype.Text & "%' AND PsApp IS NULL"

        ElseIf CHKname.Checked = False And CHKtype.Checked = False And CHKcheck.Checked = False And CHKapp.Checked = True Then
            vWhere = " Where PdTradeName Like '%" & txtName.Text & "%' And PlantTypeName Like '%" & txttype.Text & "%' AND PsApp IS NULL"
        ElseIf CHKname.Checked = False And CHKtype.Checked = False And CHKcheck.Checked = True And CHKapp.Checked = False Then
            vWhere = " Where PdTradeName Like '%" & txtName.Text & "%' And PlantTypeName Like '%" & txttype.Text & "%' AND PsCheck IS NULL AND PsApp IS NULL "


        ElseIf SelectTM = " " Then
            vWhere = " "
        Else
            vWhere &= SelectTM
        End If
        vWhere &= ""
        ShowDataOnGrid(vWhere)

        If wType = 1 Then
            For i As Integer = 0 To dgvData.Rows.Count - 1
                If dgvData.Rows(i).Cells(idPsCheck.Name).Value Is DBNull.Value Or dgvData.Rows(i).Cells(idPsApp.Name).Value IsNot DBNull.Value Then
                    dgvData.Rows(i).Cells(colcancel.Name).Value = My.Resources.ResourceManager.GetObject("cross_circle_frame_black")
                    j += 1
                End If
            Next
        Else
            For i As Integer = 0 To dgvData.Rows.Count - 1
                If dgvData.Rows(i).Cells(idPsApp.Name).Value Is DBNull.Value Then
                    dgvData.Rows(i).Cells(colcancel.Name).Value = My.Resources.ResourceManager.GetObject("cross_circle_frame_black")
                    k += 1
                End If
            Next
        End If


    End Sub

    Private Sub DataNumber()
        Dim dtb As New DataTable
        mdCnOpen()
        sCommand.CommandText = "SELECT COUNT(*) AS allrow,(SELECT COUNT(*) FROM vSlPdTradeNameD WHERE idPsApp IS NULL) AS appnum,(SELECT   COUNT(*) FROM dbo.vSlPdTradeNameD WHERE (idPsCheck IS NULL)) AS checknum FROM vSlPdTradeNameD "
        sAdapter.Fill(dtb)
        Label1.Text = dtb.Rows(0).ItemArray(2).ToString + " รายการ"
        Label2.Text = dtb.Rows(0).ItemArray(1).ToString + " รายการ"
        Label3.Text = "รายการทั้งหมด " + dtb.Rows(0).ItemArray(0).ToString + " รายการ"

    End Sub

    Public Sub ShowDataOnGrid(ByVal sWhere As String)
        mdCnOpen()
        Dim sDt As New DataTable
        Dim vWhere As String = sWhere
        sCommand.CommandText = "Select idPdT, PdTradeName, PlantTypeName, idPlant, Trademark, PP, idPsApp, DateApp, DateCheck, idPsCheck, PsAdd, PsApp, PsCheck From vSlPdTradeNameD " & vWhere & " Order by PdTradeName ASC"
        sAdapter.Fill(sDt)
        dgvData.DataSource = sDt
    End Sub

    Private Sub CHKname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKname.CheckedChanged
        If CHKname.Checked = True Then
            txtName.Enabled = True
            txtName.Focus()
        Else
            txtName.Enabled = False
        End If
    End Sub

    Private Sub CHKtype_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKtype.CheckedChanged
        If CHKtype.Checked = True Then
            txttype.Enabled = True
            txttype.Focus()
        Else
            txttype.Enabled = False
        End If
    End Sub

    Private Sub dgvData_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellClick
        Dim answer As DialogResult
        Dim mes As String
        Dim frmDetail As New frmSlPdApproveDetail
        Dim pIdT As New Integer
        Dim pName As String
        Dim pPlantType As String
        Dim pTrademark As String
        Dim pPP As String
        Dim pPsAdd As String
        Dim pPsApp As String
        Dim pPsCheck As String
        Dim pDateCheck As String
        Dim pDateApp As String
        Dim pidPsApp As Integer
        Dim pidPsCheck As Integer

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If wType = 1 Then
            mes = "ตรวจสอบ"
        Else
            mes = "อนุมัติ"
        End If
        mdLoadShow()
        If dgvData.Columns(e.ColumnIndex).Name = colcancel.Name And dgvData.Rows(e.RowIndex).Cells(idPsCheck.Name).Value IsNot DBNull.Value And wType = 1 And dgvData.Rows(e.RowIndex).Cells(idPsApp.Name).Value Is DBNull.Value Then
            pIdT = dgvData.Rows(e.RowIndex).Cells(idPdT.Name).Value
            answer = MessageBox.Show("ต้องการยกเลิกการ" & mes, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = vbYes Then
                mdCnOpen()
                sCommand.CommandText = "UPDATE SlPdTradeNameD SET idPsCheck = NULL ,DateCheck = NULL WHERE idPdT = " & pIdT
                sCommand.ExecuteNonQuery()
                MessageBox.Show("ยกเลิกการ" & mes & "เรียบร้อย")
                pSetData()
            End If
        ElseIf dgvData.Columns(e.ColumnIndex).Name = colcancel.Name And dgvData.Rows(e.RowIndex).Cells(idPsApp.Name).Value IsNot DBNull.Value And wType = 2 Then
            pIdT = dgvData.Rows(e.RowIndex).Cells(idPdT.Name).Value
            answer = MessageBox.Show("ต้องการยกเลิกการ" & mes, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = vbYes Then
                mdCnOpen()
                sCommand.CommandText = "UPDATE SlPdTradeNameD SET idPsApp = NULL ,DateApp = NULL WHERE idPdT = " & pIdT
                sCommand.ExecuteNonQuery()
                MessageBox.Show("ยกเลิกการ" & mes & "เรียบร้อย")
                pSetData()
            End If
        End If



        If dgvData.Columns(e.ColumnIndex).Name = colselect.Name Then
            pIdT = dgvData.Rows(e.RowIndex).Cells(idPdT.Name).Value
            pName = dgvData.Rows(e.RowIndex).Cells(colPdTradeName.Name).Value
            pPlantType = dgvData.Rows(e.RowIndex).Cells(colPlantTypeName.Name).Value

            If dgvData.Rows(e.RowIndex).Cells(colTrademark.Name).Value Is DBNull.Value Then
                pTrademark = ""
            Else
                pTrademark = dgvData.Rows(e.RowIndex).Cells(colTrademark.Name).Value
            End If
            If dgvData.Rows(e.RowIndex).Cells(colPP.Name).Value Is DBNull.Value Then
                pPP = ""
            Else
                pPP = dgvData.Rows(e.RowIndex).Cells(colPP.Name).Value
            End If
            If dgvData.Rows(e.RowIndex).Cells(colPsAdd.Name).Value Is DBNull.Value Then
                pPsAdd = ""
            Else
                pPsAdd = dgvData.Rows(e.RowIndex).Cells(colPsAdd.Name).Value
            End If
            If dgvData.Rows(e.RowIndex).Cells(colPsApp.Name).Value Is DBNull.Value Then
                pPsApp = ""
            Else
                pPsApp = dgvData.Rows(e.RowIndex).Cells(colPsApp.Name).Value
            End If
            If dgvData.Rows(e.RowIndex).Cells(colPsCheck.Name).Value Is DBNull.Value Then
                pPsCheck = ""
            Else
                pPsCheck = dgvData.Rows(e.RowIndex).Cells(colPsCheck.Name).Value
            End If
            If dgvData.Rows(e.RowIndex).Cells(DateCheck.Name).Value Is DBNull.Value Then
                pDateCheck = ""
            Else
                pDateCheck = dgvData.Rows(e.RowIndex).Cells(DateCheck.Name).Value
            End If
            If dgvData.Rows(e.RowIndex).Cells(DateApp.Name).Value Is DBNull.Value Then
                pDateApp = ""
            Else
                pDateApp = dgvData.Rows(e.RowIndex).Cells(DateApp.Name).Value
            End If
            If dgvData.Rows(e.RowIndex).Cells(idPsApp.Name).Value Is DBNull.Value Then
                pidPsApp = -1
            Else
                pidPsApp = dgvData.Rows(e.RowIndex).Cells(idPsApp.Name).Value
            End If
            If dgvData.Rows(e.RowIndex).Cells(idPsCheck.Name).Value Is DBNull.Value Then
                pidPsCheck = -1
            Else
                pidPsCheck = dgvData.Rows(e.RowIndex).Cells(idPsCheck.Name).Value
            End If

            frmDetail.Get_value(pIdT, pName, pPlantType, pTrademark, pPP, pPsAdd, pPsApp, pPsCheck, pDateCheck, pDateApp, pidPsApp, pidPsCheck, wType)
            frmDetail.ShowDialog()
        End If

        If frmDetail.DialogResult = Windows.Forms.DialogResult.OK Then
            pSetData()
        End If
        mdLoadCommitt()
    End Sub

    Private Sub frmSlPdApprove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub dgvData_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvData.Sorted
        If wType = 1 Then
            For i As Integer = 0 To dgvData.Rows.Count - 1
                If dgvData.Rows(i).Cells(idPsCheck.Name).Value Is DBNull.Value Or dgvData.Rows(i).Cells(idPsApp.Name).Value IsNot DBNull.Value Then
                    dgvData.Rows(i).Cells(colcancel.Name).Value = My.Resources.ResourceManager.GetObject("cross_circle_frame_black")
                End If
            Next
        Else
            For i As Integer = 0 To dgvData.Rows.Count - 1
                If dgvData.Rows(i).Cells(idPsApp.Name).Value Is DBNull.Value Then
                    dgvData.Rows(i).Cells(colcancel.Name).Value = My.Resources.ResourceManager.GetObject("cross_circle_frame_black")
                End If
            Next
        End If
    End Sub

    Private Sub frmSlPdApprove_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        mdLoadShow()
        pSetData()
        If wType = 1 Then
            Me.Text = "การตรวจสอบสินค้า"
        Else
            Me.Text = "การอนุมัติสินค้า"
        End If
        mdLoadCommitt()
    End Sub
End Class