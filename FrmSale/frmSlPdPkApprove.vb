Public Class frmSlPdPkApprove
    Dim wType As New Integer
    Dim chkevent As New Integer
    Sub mdLoadShow()

    End Sub
    Sub mdLoadCommitt()

    End Sub
    Sub New(ByVal aTypeWork As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        wType = aTypeWork
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
    'Public Sub GetTypeAndGetData(ByVal Type_Work As Integer)
    '    wType = Type_Work
    '    If wType = 1 Then
    '        CHKcheck.Checked = True
    '    Else
    '        CHKapp.Checked = True
    '    End If
    '    'pSetData()
    'End Sub
    Private Sub dgvExpense_RowPostPaint2(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData.RowPostPaint
        Me.dgvData("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub
    Private Sub pSetData()
        Dim j As Integer = 0
        Dim k As Integer = 0
        Dim vWhere As String = " "
        Dim SelectTM As String = " "
        DataNumber()

        If CHKname.Checked = True And CHKcheck.Checked = True And CHKapp.Checked = False Then
            vWhere = " Where PdTradeName Like '%" & txtsname.Text & "%' AND PsChk IS NULL"
        ElseIf CHKname.Checked = True And CHKcheck.Checked = False And CHKapp.Checked = True Then
            vWhere = " Where PdTradeName Like '%" & txtsname.Text & "%' AND PsApp IS NULL"
        ElseIf CHKname.Checked = True And CHKcheck.Checked = True And CHKapp.Checked = True Then
            vWhere = " Where PdTradeName Like '%" & txtsname.Text & "%' AND PsApp IS NULL"
        ElseIf CHKname.Checked = True And CHKcheck.Checked = False And CHKapp.Checked = False Then
            vWhere = " Where PdTradeName Like '%" & txtsname.Text & "%' "
        ElseIf CHKname.Checked = False And CHKcheck.Checked = False And CHKapp.Checked = True Then
            vWhere = " Where PsApp IS NULL"
        ElseIf CHKname.Checked = False And CHKcheck.Checked = True And CHKapp.Checked = False Then
            vWhere = " Where PsApp IS NULL AND PsChk IS NULL"
        ElseIf CHKname.Checked = False And CHKcheck.Checked = True And CHKapp.Checked = True Then
            vWhere = " Where PsApp IS NULL AND PsChk IS NULL "
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
        sCommand.CommandText = "SELECT COUNT(*) AS allrow,(SELECT COUNT(*) FROM vPackingPdSet WHERE idPsApp IS NULL) AS appnum,(SELECT   COUNT(*) FROM vPackingPdSet WHERE (idPsChk IS NULL)) AS checknum FROM vPackingPdSet "
        sAdapter.Fill(dtb)
        Label1.Text = dtb.Rows(0).ItemArray(2).ToString + " รายการ"
        Label2.Text = dtb.Rows(0).ItemArray(1).ToString + " รายการ"
        Label3.Text = "รายการทั้งหมด " + dtb.Rows(0).ItemArray(0).ToString + " รายการ"

    End Sub

    Public Sub ShowDataOnGrid(ByVal sWhere As String)
        mdCnOpen()
        Dim sDt As New DataTable
        Dim vWhere As String = sWhere
        sCommand.CommandText = "SELECT idPdT,idPdPk,PdPkName, PriceRetail, PriceBill, PriceWholesale, PerBox, PsChk, PsApp , idPsChk, idPsApp, DateApp, DateChk FROM vPackingPdSet" & vWhere & " Order by PdPkName ASC"
        sAdapter.Fill(sDt)
        dgvData.DataSource = sDt
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
    Private Sub frmSlPdApprove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub dgvData_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellClick
        Dim answer As DialogResult
        Dim mes As String
        Dim frmDetail As New frmSlPdPkApproveDetail
        Dim pidPdPk As New Integer
        Dim pName As String
        Dim pPriceRetail As String
        Dim pPriceBill As String
        Dim pPriceWholeSale As String
        Dim pPerBox As String
        Dim pPsApp As String
        Dim pPsCheck As String
        Dim pDateCheck As String
        Dim pDateApp As String
        Dim pidPsApp As Integer
        Dim pidPsCheck As Integer
        Dim pidPdT As String

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
            pidPdPk = dgvData.Rows(e.RowIndex).Cells(idPdPk.Name).Value
            answer = MessageBox.Show("ต้องการยกเลิกการ" & mes, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = vbYes Then
                mdCnOpen()
                sCommand.CommandText = "UPDATE dPackingPdSet SET idPsChk = NULL ,DateChk = NULL WHERE idPdPk = " & pidPdPk
                sCommand.ExecuteNonQuery()
                MessageBox.Show("ยกเลิกการ" & mes & "เรียบร้อย")
                pSetData()
            End If
        ElseIf dgvData.Columns(e.ColumnIndex).Name = colcancel.Name And dgvData.Rows(e.RowIndex).Cells(idPsApp.Name).Value IsNot DBNull.Value And wType = 2 Then
            pidPdPk = dgvData.Rows(e.RowIndex).Cells(idPdPk.Name).Value
            answer = MessageBox.Show("ต้องการยกเลิกการ" & mes, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = vbYes Then
                mdCnOpen()
                sCommand.CommandText = "UPDATE dPackingPdSet SET idPsApp = NULL ,DateApp = NULL WHERE idPdPk = " & pidPdPk
                sCommand.ExecuteNonQuery()
                MessageBox.Show("ยกเลิกการ" & mes & "เรียบร้อย")
                pSetData()
            End If
        End If



        If dgvData.Columns(e.ColumnIndex).Name = colselect.Name Then
            pidPdPk = dgvData.Rows(e.RowIndex).Cells(idPdPk.Name).Value
            pidPdT = dgvData.Rows(e.RowIndex).Cells(idPdT.Name).Value
            pName = dgvData.Rows(e.RowIndex).Cells(PdPkName.Name).Value
            If dgvData.Rows(e.RowIndex).Cells(PriceRetail.Name).Value Is DBNull.Value Then
                pPriceRetail = ""
            Else
                pPriceRetail = dgvData.Rows(e.RowIndex).Cells(PriceRetail.Name).Value
            End If
            
            If dgvData.Rows(e.RowIndex).Cells(PriceBill.Name).Value Is DBNull.Value Then
                pPriceBill = ""
            Else
                pPriceBill = dgvData.Rows(e.RowIndex).Cells(PriceBill.Name).Value
            End If
            If dgvData.Rows(e.RowIndex).Cells(PriceWholeSale.Name).Value Is DBNull.Value Then
                pPriceWholeSale = ""
            Else
                pPriceWholeSale = dgvData.Rows(e.RowIndex).Cells(PriceWholeSale.Name).Value
            End If
            If dgvData.Rows(e.RowIndex).Cells(PerBox.Name).Value Is DBNull.Value Then
                pPerBox = ""
            Else
                pPerBox = dgvData.Rows(e.RowIndex).Cells(PerBox.Name).Value
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

            frmDetail.Get_value(pidPdT, pidPdPk, pName, pPriceRetail, pPriceBill, pPriceWholeSale, pPerBox, pPsApp, pPsCheck, pDateCheck, pDateApp, pidPsApp, pidPsCheck, wType)
            frmDetail.ShowDialog()
        End If

        If frmDetail.DialogResult = Windows.Forms.DialogResult.OK Then
            pSetData()
        End If
        mdLoadCommitt()
    End Sub

    Private Sub CHKname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKname.CheckedChanged

        If CHKname.Checked = True Then
            txtsname.Enabled = True
        Else
            txtsname.Enabled = False
        End If

    End Sub

    Private Sub frmSlPdPkApprove_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        mdLoadShow()
        pSetData()
        If wType = 1 Then
            Me.Text = "การตรวจสอบราคาสินค้าบรรจุขาย"
        Else
            Me.Text = "การอนุมัติราคาสินค้าบรรจุขาย"
        End If
        mdLoadCommitt()
    End Sub
End Class