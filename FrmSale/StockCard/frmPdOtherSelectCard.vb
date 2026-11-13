Public Class frmPdOtherSelectCard
    Public idPdO As Integer = 0
    Public PdoName As String = ""
    Public pAmount As Integer = 0
    Public pdoLotName As String = ""
    Public pdoUnitName As String = ""

    Dim Process As eProcess

    Enum eProcess
        eSelect 'เพิ่มรายการ
        eSelectLot 'แก้ไขรายการ
    End Enum

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If aProcess = eProcess.eSelect Then
            CHKLotNum.Visible = False
            txtLotNum.Visible = False
            LotNum.Visible = False
            ColPerbox.Visible = True
            Amount.Visible = False
            Process = eProcess.eSelect
        End If
        If aProcess = eProcess.eSelectLot Then
            LotNum.Visible = True
            ColPerbox.Visible = False
            Amount.Visible = True
            Process = eProcess.eSelectLot
        End If

    End Sub

    Private Sub frmPdOtherSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbPdoType()
        BindData()
    End Sub

    Private Sub BindData()
        mdCnOpen()
        mdLoadShow()
        Dim sDt As New DataTable
        Dim vWHERE As String = ""

        If Me.ChkPd.Checked = True Then
            vWHERE = vWHERE & " AND PdoName Like '%" & txtPdName.Text & "%' "
        End If

        If Me.ChkType.Checked = True Then
            vWHERE = vWHERE & " AND idPdoType = '" & cmbType.SelectedValue & "' "
        End If
        If Me.CHKLotNum.Checked = True Then
            vWHERE = vWHERE & " AND LotNum = '" & txtLotNum.Text & "' "
        End If


        sDt.Clear()
        If Process = eProcess.eSelect Then
            sCommand.CommandText = "SELECT idPdO, Title, PdoTypeName, Perbox FROM vSmPdOtherD " & _
                              "WHERE (stDel  = 0 OR stDel IS NULL) " & vWHERE & " Order by Title"
            sAdapter.Fill(sDt)
        Else
            sCommand.CommandText = "SELECT idPdOLot,idPdO,LotNum, Title, PdoTypeName,Amount,UnitName,Perbox FROM vSmPdOtherDLot " & _
                               "WHERE (stDel  = 0 OR stDel IS NULL) AND CompRec = " & sIdComp & " " & vWHERE & " Order by Title"
            sAdapter.Fill(sDt)
        End If

        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        dgvPd.DataSource = sDt

        mdLoadCommitt()
        Me.ChkPd.Focus()
    End Sub

    Private Sub cmbPdoType()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT distinct idPdoType, PdoTypeName From SmPdOtherTypeD"
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
        BindData()
    End Sub

    Private Sub txtPdName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPdName.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindData()
        End If
    End Sub

    Private Sub txtLotNum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLotNum.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindData()
        End If
    End Sub


    Private Sub dgvPd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPd.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvPd.Columns(e.ColumnIndex).Name = colSelect.Name Then
            If Process = eProcess.eSelect Then
                idPdO = CInt(dgvPd.Rows(e.RowIndex).Cells(ColidPdO.Name).Value)
                PdoName = dgvPd.Rows(e.RowIndex).Cells(ColTitle.Name).Value
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                idPdO = CInt(dgvPd.Rows(e.RowIndex).Cells(idPdOLot.Name).Value)
                PdoName = dgvPd.Rows(e.RowIndex).Cells(ColTitle.Name).Value
                pAmount = CInt(dgvPd.Rows(e.RowIndex).Cells(Amount.Name).Value)
                pdoLotName = dgvPd.Rows(e.RowIndex).Cells(LotNum.Name).Value
                pdoUnitName = dgvPd.Rows(e.RowIndex).Cells(UnitName.Name).Value
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

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

    Private Sub CHKLotNum_CheckedChanged(sender As Object, e As EventArgs) Handles CHKLotNum.CheckedChanged
        If CHKLotNum.Checked = True Then
            txtLotNum.Enabled = True
        Else
            txtLotNum.Enabled = False
        End If
    End Sub
End Class