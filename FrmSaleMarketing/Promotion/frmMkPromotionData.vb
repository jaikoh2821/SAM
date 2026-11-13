Public Class frmMkPromotionData
    Dim eEvent As eProcess
    Dim stPage As String

    Enum eProcess
        eView
        eCancel
        eNewAndEdit
        ' eSelect
        'eEdit
    End Enum

    Sub New(ByVal aProcess As eProcess)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eNewAndEdit
                stPage = 1
                'Case eProcess.eEdit
                '    stPage = 2
            Case eProcess.eView
                stPage = 3
            Case eProcess.eCancel
                stPage = 4            
        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmMkPromotionData_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If stPage = 1 Then 'New
            Me.Text = "กำหนด/แก้ไขรายละเอียดโปรโมชั่น"
            Me.btnNew.Visible = True
            dgvPromotion.Columns("ColEdit").Visible = True
            'ElseIf stPage = 2 Then 'Edit
            '    Me.Text = "แก้ไขข้อมูลโปรโมชั่น"
            '    dgvPromotion.Columns("ColEdit").Visible = True
        ElseIf stPage = 3 Then 'View
            Me.Text = "ข้อมูลโปรโมชั่น"
            dgvPromotion.Columns("ColDetail").Visible = True
        ElseIf stPage = 4 Then 'Cancel
            Me.Text = "ยกเลิกโปรโมชั่น"
            dgvPromotion.Columns("ColCancel").Visible = True
        End If

        mdLoadShow()
        cmbProType()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub cmbProType()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT idProType, ProTypeName From SmPromotionType Order By idProType"
        sAdapter.Fill(sDt)

        With cmbPmtType
            .DisplayMember = "ProTypeName"
            .ValueMember = "idProType"
            .DataSource = sDt
        End With
    End Sub

    Sub BindData()
        Dim vWhere As String = ""

        If Me.ChkProName.Checked = True Then
            vWhere = vWhere & " AND mt.ProName LIKE '%" + Me.txtProName.Text + "%' "
        End If

        If Me.ChkProType.Checked = True Then
            vWhere = vWhere & " AND mt.idProType = '" & Me.cmbPmtType.SelectedValue & "'"
        End If

        If stPage = 1 Then 'New / Edit :: Not Show Cancel list
            vWhere = vWhere & " AND mt.idPsCancel IS NULL "
        End If

        If Me.rdbOpen.Checked = True Then
            vWhere = vWhere & " AND mt.stProOpen = 0 AND mt.idPsCancel IS NULL "
        ElseIf Me.rdbClose.Checked = True Then
            vWhere = vWhere & " AND mt.stProOpen = 1 AND mt.idPsCancel IS NULL "
        End If

        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT mt.idPromotion, mt.ProName, pro.ProTypeName, mt.stProOpen, " & _
                               "'' As ProOpen, mt.stPdOfPro, '' As ProOdPd, p1.PsName As PsPro, " & _
                               "mt.Note, mt.idPsCancel, p2.Psname As PsCancel, mt.CancelNote FROM SmPromotionMt mt " & _
                               "LEFT OUTER JOIN vPerson p1 ON mt.idPsPro = p1.idPs LEFT OUTER JOIN " & _
                               "vPerson p2 On mt.idPsCancel = p2.idPs LEFT OUTER JOIN SmPromotionType pro " & _
                               "ON mt.idProType = pro.idProType " & _
                               "WHERE mt.idComp = '" & sIdComp & "' " & vWhere
        sAdapter.Fill(sDt)
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลโปรโมชั่น", sSystemName)
            dgvPromotion.DataSource = sDt
            Me.txtTotalNet.Text = Format(dgvPromotion.Rows.Count, "#,##0")
            Exit Sub
        Else
            For i As Integer = 0 To sDt.Rows.Count - 1
                If sDt.Rows(i).Item("stProOpen") = 0 Then
                    sDt.Rows(i).Item("ProOpen") = "เปิดใช้โปรโมชั่น"
                ElseIf sDt.Rows(i).Item("stProOpen") = 1 Then
                    sDt.Rows(i).Item("ProOpen") = "ไม่เปิดใช้โปรโมชั่น"
                End If

                If sDt.Rows(i).Item("stPdOfPro") = 0 Then
                    sDt.Rows(i).Item("ProOdPd") = "ทุกรายการสินค้า"
                ElseIf sDt.Rows(i).Item("stPdOfPro") = 1 Then
                    sDt.Rows(i).Item("ProOdPd") = "เฉพาะรายการผักซอง"
                ElseIf sDt.Rows(i).Item("stPdOfPro") = 2 Then
                    sDt.Rows(i).Item("ProOdPd") = "เฉพาะรายการผักซอง กลุ่ม OP"
                ElseIf sDt.Rows(i).Item("stPdOfPro") = 3 Then
                    sDt.Rows(i).Item("ProOdPd") = "เฉพาะรายการผักซอง กลุ่ม F1"
                ElseIf sDt.Rows(i).Item("stPdOfPro") = 4 Then
                    sDt.Rows(i).Item("ProOdPd") = "ผูกกับสินค้าเฉพาะบางรายการ"
                ElseIf sDt.Rows(i).Item("stPdOfPro") = 5 Then
                    sDt.Rows(i).Item("ProOdPd") = "ผูกกับสินค้าเฉพาะบางรายการ"
                ElseIf sDt.Rows(i).Item("stPdOfPro") = 6 Then
                    sDt.Rows(i).Item("ProOdPd") = "ผูกกับสินค้าเฉพาะบางรายการ"
                End If
            Next


            dgvPromotion.DataSource = sDt
            ksbCountRowDgv(dgvPromotion, ColNum.Name)

            For i As Integer = 0 To dgvPromotion.Rows.Count - 1
                If IsDBNull(dgvPromotion.Rows(i).Cells("ColidPsCancel").Value) = False Then 'Cancel
                    dgvPromotion.Rows(i).DefaultCellStyle.BackColor = Color.Salmon
                    Dim f As Font = dgvPromotion.DefaultCellStyle.Font
                    dgvPromotion.Rows(i).DefaultCellStyle.Font = New Font(f, FontStyle.Strikeout)
                Else 'Not Cancel
                    If dgvPromotion.Rows(i).Cells("ColstProOpen").Value = 0 Then 'Promotion Open
                        dgvPromotion.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192)
                        dgvPromotion.Rows(i).Cells("ColDetail").Style.BackColor = Color.White
                        dgvPromotion.Rows(i).Cells("ColCancel").Style.BackColor = Color.White
                        dgvPromotion.Rows(i).Cells("ColEdit").Style.BackColor = Color.White
                        dgvPromotion.Rows(i).Cells("ColChk").Style.BackColor = Color.White
                    End If
                End If
            Next

            Me.txtTotalNet.Text = Format(dgvPromotion.Rows.Count, "#,##0")

        End If

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim vFrm As New frmMkPromotionDetail(frmMkPromotionDetail.eProcess.eNew, Nothing)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

  
    Private Sub btnSFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSFindAll.Click
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub ChkProName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkProName.CheckedChanged
        If Me.ChkProName.Checked = True Then
            Me.txtProName.Enabled = True
            Me.txtProName.Focus()
        Else
            Me.txtProName.Enabled = False
        End If
    End Sub

    Private Sub ChkProType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkProType.CheckedChanged
        If Me.ChkProType.Checked = True Then
            Me.cmbPmtType.Enabled = True
        Else
            Me.cmbPmtType.Enabled = False
        End If
    End Sub

    Private Sub dgvPromotion_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPromotion.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If IsDBNull(dgvPromotion.CurrentRow.Cells("ColidPsCancel").Value) = False Then
            MessageBox.Show("ผู้ยกเลิก : " & dgvPromotion.CurrentRow.Cells("ColPsCancel").Value & vbNewLine & "ยกเลิกสาเหตุ : " & dgvPromotion.CurrentRow.Cells("ColCanCelNote").Value, sSystemName)
        End If
    End Sub

    Private Sub dgvPromotion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPromotion.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        '----Edit ----'
        If dgvPromotion.Columns(e.ColumnIndex).Name = ColEdit.Name Then
            If IsDBNull(dgvPromotion.CurrentRow.Cells("ColidPsCancel").Value) = True Then
                Dim idPro As Integer = dgvPromotion.CurrentRow.Cells("ColidPromotion").Value
                Dim vFrm As New frmMkPromotionDetail(frmMkPromotionDetail.eProcess.eEdit, idPro)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    mdLoadShow()
                    BindData()
                    mdLoadCommitt()
                End If
            End If
        End If

        '----viewData ----'
        If dgvPromotion.Columns(e.ColumnIndex).Name = ColDetail.Name Then
            If IsDBNull(dgvPromotion.CurrentRow.Cells("ColidPsCancel").Value) = True Then
                Dim idPro As Integer = dgvPromotion.CurrentRow.Cells("ColidPromotion").Value
                Dim vFrm As New frmMkPromotionDetail(frmMkPromotionDetail.eProcess.eview, idPro)
                vFrm.Show()
            End If
        End If

        '----CancelData ----'
        If dgvPromotion.Columns(e.ColumnIndex).Name = ColCancel.Name Then
            If IsDBNull(dgvPromotion.CurrentRow.Cells("ColidPsCancel").Value) = True Then
                Dim idPro As Integer = dgvPromotion.CurrentRow.Cells("ColidPromotion").Value
                Dim vFrm As New frmMkPromotionDetail(frmMkPromotionDetail.eProcess.eCancel, idPro)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    mdLoadShow()
                    BindData()
                    mdLoadCommitt()
                End If
            End If
        End If

    End Sub
End Class