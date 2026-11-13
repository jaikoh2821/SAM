Public Class frmCusAdsSent
    Public idCusRefAddr As Integer = 0
    Dim idCustomer As Integer
    Dim stPage As Integer = 0
    Dim eEvent As eProcess

    Enum eProcess
        eData
        eSelect
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idCus As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eData
                stPage = 1
                ColSelect.Visible = False
            Case eProcess.eSelect
                Me.Text = "เลือกที่อยู่จัดส่งของ"
                stPage = 2
                Me.btnAddNew.Visible = False
                ColEditCus.Visible = False
                Me.Panel1.Visible = False
                idCustomer = idCus

        End Select
        ' idRef = idCusRefAddr
        eEvent = aProcess
    End Sub

    Private Sub frmCusAdsSent_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        BindData()
        If eProcess.eSelect Then
            txtPsRec.Focus()
        End If
    End Sub

    Private Sub btnFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindAll.Click
        BindData()
    End Sub

    Private Sub BindData()
        mdCnOpen()
        mdLoadShow()

        Dim vWhere As String = ""
        If stPage = 2 Then 'eSelect
            vWhere = vWhere & " AND s.idCus = " & idCustomer
        End If

        If ChkCus.Checked = True Then
            vWhere = vWhere & " AND c.CusName_ Like'%" & txtCusName.Text & "%'"
        End If

        If ChkAddrS.Checked = True Then
            vWhere = vWhere & " And s.AddressS Like'%" & txtAddressS.Text & "%'"
        End If


        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "Select  s.idCusRefAddr, s.idCus, c.CusName_,s.PsRecName, s.AddressS, s.Tel, p.PsName As PsUpdate, " &
                               "devsk.fncStrDateToDateTime(s.DateUpdate) As DateUpdate, c.stActive, ts.TspTypeName As TspName, " &
                               "tp.PayTspName As PayTspName, sp.SupName From dCustomerAdrSent s " &
                                "LEFT OUTER JOIN dTspType ts ON s.idTsp = ts.idTspType " &
                               "LEFT OUTER JOIN dPayTspType tp ON s.idPayTsp = tp. idPayTsp " &
                               "LEFT OUTER JOIN PchInvAndProject.dbo.vSupplier sp ON s.idSupTsp = sp.idSup " &
                               "LEFT OUTER JOIN vCustomer c ON s.idCus = c.idCus LEFT OUTER JOIN vPerson p " &
                               "ON s.idPsUpdate = p.idPs WHERE s.stDel IS NULL " & vWhere & " Order by c.CusName_"
        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            GCAdrSent.DataSource = sDt
            Exit Sub
        Else
            'For i As Integer = 0 To sDt.Rows.Count - 1
            '    If Not IsDBNull(sDt.Rows(i).Item("DateUpdate")) Then
            '        sDt.Rows(i).Item("DateUpdate") = ksbStringToDate(sDt.Rows(i).Item("DateUpdate"))
            '    End If
            'Next
            GCAdrSent.DataSource = sDt
            GVAdrSent.ExpandAllGroups()

            Me.txtCount.Text = Format(sDt.Rows.Count, "#,##0")
        End If
        mdLoadCommitt()
    End Sub

    Private Sub txtCusName_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtCusName.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindData()
        End If
    End Sub

    Private Sub txtAddressS_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtAddressS.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindData()
        End If
    End Sub

    Private Sub RepositoryItemButtonEdit2_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit2.ButtonClick
        Dim vFrm As New frmCusAdsSentDetail(frmCusAdsSentDetail.eProcess.eEdit, GVAdrSent.GetRowCellValue(GVAdrSent.FocusedRowHandle, ColidCusRefAddr))
        'vFrm.ShowTextCus(GVAdrSent.GetRowCellValue(GVAdrSent.FocusedRowHandle, ColidCus))
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            BindData()
            'CountNoAddr()
            'CountNoAddrS()
        End If
    End Sub

    Private Sub ChkCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCus.CheckedChanged
        If Me.ChkCus.Checked = False Then
            Me.txtCusName.Enabled = False
            Me.txtCusName.Text = ""
        Else
            Me.txtCusName.Enabled = True
            Me.txtCusName.Focus()
        End If
    End Sub

    Private Sub ChkAddr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAddr.CheckedChanged
        If Me.ChkAddr.Checked = False Then
            Me.txtAddress.Enabled = False
        Else
            Me.txtAddress.Enabled = True
        End If
    End Sub

    Private Sub ChkAddrS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAddrS.CheckedChanged
        If Me.ChkAddrS.Checked = False Then
            Me.txtAddressS.Enabled = False
            Me.txtAddressS.Text = ""
        Else
            Me.txtAddressS.Enabled = True
            Me.txtAddressS.Focus()
        End If
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim vFrm As New frmCusAdsSentDetail(frmCusAdsSentDetail.eProcess.eAddNew, GVAdrSent.GetRowCellValue(GVAdrSent.FocusedRowHandle, ColidCusRefAddr))
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            BindData()
            'CountNoAddr()
            'CountNoAddrS()
        End If
    End Sub

    Private Sub GVSaleMt_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVAdrSent.RowCellStyle
        If GVAdrSent.GetRowCellValue(e.RowHandle, ColstActive) = 1 Then ' No Active
            e.Appearance.BackColor = Color.LightPink
            ' e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Strikeout)
        End If
    End Sub

    Private Sub RepositoryItemCheckEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.Click
        idCusRefAddr = GVAdrSent.GetRowCellValue(GVAdrSent.FocusedRowHandle, ColidCusRefAddr)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub txtPsRec_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPsRec.KeyUp
        GVAdrSent.ActiveFilterString = schGrid(txtPsRec.Text, {"PsRecName"})
    End Sub

End Class