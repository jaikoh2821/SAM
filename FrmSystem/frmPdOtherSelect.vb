Public Class frmPdOtherSelect
    Public idPdO As Integer = 0
    Dim stPage As String = 0
    Dim eEvent As eProcess

    Enum eProcess
        eNormalPdO
        eHormone
        ePlastic
    End Enum

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eNormalPdO
                stPage = 1
            Case eProcess.eHormone
                stPage = 2
            Case eProcess.ePlastic
                stPage = 3
        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmPdOtherSelect_shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        mdLoadShow()
        Select Case stPage
            Case 1  ' Sale
                cmbPdoType()
                BindData()
            Case 2 ' sale Hormone
                ' TabControl1.TabPages.Remove(TabOther)
                TabControl1.TabPages.Remove(TabPlastic)
                Me.TabControl1.SelectedIndex = 1
                Me.txtHormone.Focus()
            Case 3 ' sale Plastic
                ' TabControl1.TabPages.Remove(TabOther)
                TabControl1.TabPages.Remove(TabHormone)
                Me.TabControl1.SelectedIndex = 1
                Me.txtPlastic.Focus()
        End Select

        mdLoadCommitt()
        Me.txtPdName.Focus()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                Me.txtPdName.Focus()
            Case 1
                Me.txtHormone.Focus()
            Case 2
                Me.txtPlastic.Focus()
        End Select
    End Sub

    Private Sub BindData()
        Dim sDt As New DataTable
        Dim vWHERE As String = ""

        If Me.ChkPd.Checked = True Then
            Dim tx As String = txtPdName.Text
            Dim tx_a As String() = tx.Split(" ")
            Dim a_and As String = ""
            Dim strPdPk As String = ""
            If tx_a.Length > 0 Then
                For Each txt As String In tx_a
                    If Not txt.Equals("") Then
                        strPdPk += a_and & "" & String.Format(" Title Like '%{0}%' ", txt)
                    End If
                    a_and = " and "
                Next
            End If

            If strPdPk <> "" Then
                vWHERE = vWHERE & " AND " & strPdPk
            End If

            'vWHERE = vWHERE & " AND p.PdoName Like '%" & txtPdName.Text & "%' "
        End If

        If Me.ChkType.Checked = True Then
            vWHERE = vWHERE & " AND p.idPdoType = '" & cmbType.SelectedValue & "' "
        End If

        mdCnOpen()
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdO, p.Title, t.PdoTypeName, p.Perbox FROM SmPdOtherD p " & _
                               "LEFT OUTER JOIN SmPdOtherTypeD t ON p.idPdoType = t.idPdoType " & _
                               "WHERE p.stDel IS NULL " & vWHERE & " AND p.idPdoType <> 2 AND p.idPdoType <> 3 Order by p.Title"
        sAdapter.Fill(sDt)
        dgvPd.DataSource = sDt
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName)
            Exit Sub
        End If

        Me.ChkPd.Focus()
    End Sub

    Private Sub cmbPdoType()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT distinct idPdoType, PdoTypeName From SmPdOtherTypeD WHERE idPdoType <> 2 AND idPdoType <> 3 "
        sAdapter.Fill(sDt)

        With Me.cmbType
            .DisplayMember = "PdoTypeName"
            .ValueMember = "idPdoType"
            .DataSource = sDt
        End With

    End Sub

    Private Sub ChkPd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPd.CheckedChanged
        If Me.ChkPd.Checked = True Then
            Me.txtPdName.Enabled = True
            Me.txtPdName.Focus()
        Else
            Me.txtPdName.Enabled = False
        End If
    End Sub

    Private Sub ChkType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkType.CheckedChanged
        If Me.ChkType.Checked = True Then
            Me.cmbType.Enabled = True
            Me.cmbType.Focus()
        Else
            Me.cmbType.Enabled = False
        End If
    End Sub

    Private Sub btnSchPd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchPd.Click
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub txtPdName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPdName.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub dgvPd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPd.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvPd.Columns(e.ColumnIndex).Name = colSelect.Name Then
            idPdO = CInt(dgvPd.Rows(e.RowIndex).Cells(ColidPdO.Name).Value)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub dgvPd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvPd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If dgvPd.CurrentCell.RowIndex < 0 Then
                Exit Sub
            End If

            If dgvPd.Columns(dgvPd.CurrentCell.ColumnIndex).Name = colSelect.Name Then
                idPdO = CInt(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColidPdO.Name).Value)

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End If
    End Sub

#Region "Pd-Hormone"
    Private Sub BindDataHormone()
        Dim sDt As New DataTable
        Dim vWHERE As String = ""

        Dim tx As String = txtHormone.Text
        Dim tx_a As String() = tx.Split(" ")
        Dim a_and As String = ""
        Dim strPdPk As String = ""
        If tx_a.Length > 0 Then
            For Each txt As String In tx_a
                If Not txt.Equals("") Then
                    strPdPk += a_and & "" & String.Format(" Title Like '%{0}%' ", txt)
                End If
                a_and = " and "
            Next
        End If

        If strPdPk <> "" Then
            vWHERE = vWHERE & " AND " & strPdPk
        End If


        mdCnOpen()
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdO, p.Title, p.Perbox FROM SmPdOtherD p " & _
                                   "LEFT OUTER JOIN SmPdOtherTypeD t ON p.idPdoType = t.idPdoType " & _
                                   "WHERE p.stDel IS NULL " & vWHERE & " AND p.idPdoType = 2 Order by p.Title"
        sAdapter.Fill(sDt)
        DGVHormone.DataSource = sDt
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName)
            Exit Sub
        End If
    End Sub

    Private Sub btnHormone_Click(sender As Object, e As EventArgs) Handles btnHormone.Click
        mdLoadShow()
        BindDataHormone()
        mdLoadCommitt()
    End Sub

    Private Sub txtHormone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHormone.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindDataHormone()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub DGVHormone_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVHormone.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If DGVHormone.Columns(e.ColumnIndex).Name = ColSelectH.Name Then
            idPdO = CInt(DGVHormone.Rows(e.RowIndex).Cells(ColidPdoH.Name).Value)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub DGVHormone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVHormone.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If DGVHormone.CurrentCell.RowIndex < 0 Then
                Exit Sub
            End If

            If DGVHormone.Columns(DGVHormone.CurrentCell.ColumnIndex).Name = ColSelectH.Name Then
                idPdO = CInt(DGVHormone.Rows(DGVHormone.CurrentCell.RowIndex).Cells(ColidPdoH.Name).Value)

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

#End Region

#Region "Pd-Palstic"
    Private Sub BindDataPlastic()
        Dim sDt As New DataTable
        Dim vWHERE As String = ""

        Dim tx As String = txtPlastic.Text
        Dim tx_a As String() = tx.Split(" ")
        Dim a_and As String = ""
        Dim strPdPk As String = ""
        If tx_a.Length > 0 Then
            For Each txt As String In tx_a
                If Not txt.Equals("") Then
                    strPdPk += a_and & "" & String.Format(" Title Like '%{0}%' ", txt)
                End If
                a_and = " and "
            Next
        End If

        If strPdPk <> "" Then
            vWHERE = vWHERE & " AND " & strPdPk
        End If


        mdCnOpen()
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdO, p.Title FROM SmPdOtherD p " & _
                                   "LEFT OUTER JOIN SmPdOtherTypeD t ON p.idPdoType = t.idPdoType " & _
                                   "WHERE p.stDel IS NULL " & vWHERE & " AND p.idPdoType = 3 Order by p.Title"
        sAdapter.Fill(sDt)
        DGVPlastic.DataSource = sDt
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName)
            Exit Sub
        End If
    End Sub

    Private Sub btnPlastic_Click(sender As Object, e As EventArgs) Handles btnPlastic.Click
        mdLoadShow()
        BindDataPlastic()
        mdLoadCommitt()
    End Sub

    Private Sub txtPlastic_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlastic.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindDataPlastic()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub DGVPlastic_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPlastic.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If DGVPlastic.Columns(e.ColumnIndex).Name = ColSelectP.Name Then
            idPdO = CInt(DGVPlastic.Rows(e.RowIndex).Cells(ColidPdOP.Name).Value)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub DGVPlastic_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVPlastic.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If DGVPlastic.CurrentCell.RowIndex < 0 Then
                Exit Sub
            End If

            If DGVPlastic.Columns(DGVPlastic.CurrentCell.ColumnIndex).Name = ColSelectP.Name Then
                idPdO = CInt(DGVPlastic.Rows(DGVPlastic.CurrentCell.RowIndex).Cells(ColidPdOP.Name).Value)

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

#End Region

    
End Class