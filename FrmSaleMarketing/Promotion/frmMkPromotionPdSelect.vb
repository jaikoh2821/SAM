Public Class frmMkPromotionPdSelect
    Dim stPage As Integer = 0
    Dim eEvent As eProcess
    Public IdSent As New DataTable
    Dim idCut As New DataTable
    Public idSentBack As Integer = 0
    Public PdPkName As String = ""
    Public idPkUnit As Integer = 0
    Public PkUnitName As String = ""
    'Public idPlant As Integer = 0

    Enum eProcess
        ePdTName
        ePdName
        ePlant
        ePdPk
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idCutDt As DataTable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.ePdTName
                stPage = 1
                dgvPd.Columns("ColName").HeaderText = "ชื่อทางการค้า"
            Case eProcess.ePdName
                stPage = 2
                dgvPd.Columns("ColName").HeaderText = "ชื่อสินค้า"
                dgvPd.Columns("ColPlantName").Visible = True
            Case eProcess.ePlant
                stPage = 3
                dgvPd.Columns("ColName").HeaderText = "ชื่อพืช"
            Case eProcess.ePdPk
                stPage = 4
                dgvPd.Columns("ColName").HeaderText = "ชื่อสินค้าสำเร็จรูป"
                Me.ChkWeight.Visible = True
                Me.cmbWeight.Visible = True
                Me.cmbUnit.Visible = True
        End Select
        eEvent = aProcess
        idCut = idCutDt
    End Sub


    Private Sub frmMkPromotionPdSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SelectWeight()
        SelectUnitW()
        BindData()
    End Sub

    Private Sub frmMkPromotionPdSelect_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtPdName.Focus()
    End Sub

    Private Sub SelectWeight()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select distinct Weight From dPackingW WHERE stFlower IS NULL ORDER BY Weight"
        sAdapter.Fill(sDt)
        With cmbWeight
            .DisplayMember = "Weight"
            .ValueMember = "Weight"
            .DataSource = sDt
        End With
    End Sub

    Private Sub SelectUnitW()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select distinct idUnitW, UnitW From dUnitW"
        sAdapter.Fill(sDt)
        With cmbUnit
            .DisplayMember = "UnitW"
            .ValueMember = "idUnitW"
            .DataSource = sDt
        End With
    End Sub

    Private Sub BindData()

        Dim vSQL As String = ""
        If stPage = 1 Then 'PdTradName
            vSQL = "SELECT idPdT As fId, PdTradeName As fName FROM vSlPdTradeNameD " & _
                   "WHERE PdTradeName Like '%" & txtPdName.Text & "%' Order by PdTradeName "
        ElseIf stPage = 2 Then 'PdName
            vSQL = "SELECT distinct idPdN As fId, PdName As fName, PlantName FROM vSlPdTradeNameD " & _
                   "WHERE  PdName Like '%" & txtPdName.Text & "%' Order by  PdName"

        ElseIf stPage = 3 Then 'idPlant
            vSQL = "SELECT distinct idPlant As fId, PlantName As fName FROM vSlPdTradeNameD " & _
                   "WHERE PlantName Like '%" & txtPdName.Text & "%' Order by PlantName"
        ElseIf stPage = 4 Then 'idPdPk
            Dim vWhere As String = ""
            If Me.ChkWeight.Checked = True Then
                vWhere = vWhere & " AND Weight = " & Me.cmbWeight.SelectedValue & " AND " & _
                                  "idUnitW = " & Me.cmbUnit.SelectedValue & " "

            End If

            vSQL = "SELECT idPdPk As fId, PdPkName As fName, idPkUnit, PkUnitName FROM vPackingPdSet " & _
                   "WHERE PdPkName Like '%" & txtPdName.Text & "%' " & vWhere & " Order by PdPkName"
        End If

        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = vSQL
        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            dgvPd.DataSource = sDt
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้าวัตถุดิบ", sSystemName)
            Exit Sub
        Else
            dgvPd.DataSource = sDt

            For j As Integer = 0 To idCut.Rows.Count - 1
                For i As Integer = 0 To dgvPd.Rows.Count - 1
                    If idCut.Rows(j).Item("fidCut") = Me.dgvPd.Rows(i).Cells(ColID.Name).Value Then
                        Me.dgvPd.Rows(i).Cells(colSelect.Name).Value = True
                    End If

                Next
            Next

        End If
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        IdSent.Columns.Add("fId", System.Type.GetType("System.Int32"))
        IdSent.Columns.Add("fName", System.Type.GetType("System.String"))
        IdSent.Rows.Clear()

        For i As Integer = 0 To dgvPd.Rows.Count - 1
            If Me.dgvPd.Rows(i).Cells(colSelect.Name).Value = True Then
                IdSent.Rows.Add(Me.dgvPd.Rows(i).Cells(ColID.Name).Value, Me.dgvPd.Rows(i).Cells(ColName.Name).Value)
            End If
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnSchPd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchPd.Click
        BindData()
    End Sub

    Private Sub txtPdName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPdName.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindData()
        End If
    End Sub

    Private Sub dgvPd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPd.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If


        If dgvPd.Columns(e.ColumnIndex).Name = ColChoose.Name Then
            idSentBack = dgvPd.Rows(e.RowIndex).Cells(ColID.Name).Value

            If stPage = 4 Then
                PdPkName = dgvPd.Rows(e.RowIndex).Cells(ColName.Name).Value
                idPkUnit = dgvPd.Rows(e.RowIndex).Cells(ColidPkUnit.Name).Value
                PkUnitName = dgvPd.Rows(e.RowIndex).Cells(ColPkUnitName.Name).Value
            End If
            'If stPage = 1 Then 'idPdT
            '    idPdT = CStr(dgvPd.Rows(e.RowIndex).Cells(ColID.Name).Value)
            'ElseIf stPage = 2 Then 'idPdN
            '    idPdN = CStr(dgvPd.Rows(e.RowIndex).Cells(ColID.Name).Value)
            'ElseIf stPage = 3 Then 'idPlant
            '    idPlant = CStr(dgvPd.Rows(e.RowIndex).Cells(ColID.Name).Value)
            'End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub


    Private Sub ChkWeight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkWeight.CheckedChanged
        If Me.ChkWeight.Checked = True Then
            Me.cmbWeight.Enabled = True
            Me.cmbUnit.Enabled = True
        Else
            Me.cmbWeight.Enabled = False
            Me.cmbUnit.Enabled = False
        End If
    End Sub
End Class