Public Class frmSlPdTradeSelect
    Public pId As Integer
    Public pName As String
    Public pPrice As Double
    Public ArrayIdPdT() As Integer
    Public ChkStatus As String
    Public SelectTM As String
    Dim mIdPdT() As Integer, mPdTradeName() As String, mPlantTypeName() As String, mDetail() As String, mPricePerKg() As Double
    Public ReadOnly Property ppIdPdT()
        Get
            Return mIdPdT
        End Get
    End Property
    Public ReadOnly Property ppPdTradeName()
        Get
            Return mPdTradeName
        End Get
    End Property
    Public ReadOnly Property ppPlantTypeName()
        Get
            Return mPlantTypeName
        End Get
    End Property
    Public ReadOnly Property ppDetail()
        Get
            Return mDetail
        End Get
    End Property
    'Public ReadOnly Property ppPricePerKg()
    '   Get
    '      Return mPricePerKg
    ' End Get
    'End Property
    Enum ePc
        eSelect
        eCheck
    End Enum
    Dim mPc As ePc

    Sub New(ByVal aPc As ePc)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If aPc = ePc.eSelect Then
            colSelect.Visible = True
            colCheck.Visible = False
            btnAdd.Visible = False
        End If
    End Sub

    Private Sub dgvData_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvData.Columns(e.ColumnIndex).Name = colSelect.Name Then
            pId = dgvData.Rows(e.RowIndex).Cells(idPdT.Name).Value
            pName = dgvData.Rows(e.RowIndex).Cells(colPdTradeName.Name).Value
            If dgvData.Rows(e.RowIndex).Cells(PricePerKg.Name).Value.ToString = "" Then dgvData.Rows(e.RowIndex).Cells(PricePerKg.Name).Value = 0
            pPrice = dgvData.Rows(e.RowIndex).Cells(PricePerKg.Name).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If    
    End Sub
    Private Sub dgvData_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

    End Sub
    Private Sub pSetData()
        Dim vWhere As String = " "
        If chkPdName.Checked = True And chkPlantName.Checked = False Then
            vWhere = " Where PdTradeName Like '%" & txtPdName.Text & "%' "
        ElseIf chkPdName.Checked = False And chkPlantName.Checked = True Then
            vWhere = " Where PlantTypeName Like '%" & txtPlantName.Text & "%' "
        ElseIf chkPdName.Checked = True And chkPlantName.Checked = True Then
            vWhere = " Where PdTradeName Like '%" & txtPdName.Text & "%' And PlantTypeName Like '%" & txtPlantName.Text & "%' "
        ElseIf SelectTM = " " Then
            vWhere = " "
        Else
            vWhere &= SelectTM
        End If

        Dim i As Integer = 0
        If ChkStatus = "เลือกแล้ว" Then
            ShowDataOnGridSameValue(vWhere, ArrayIdPdT)
        Else
            ShowDataOnGrid(vWhere)
        End If

    End Sub
    Private Sub btnSFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSFindAll.Click
        pSetData()
    End Sub
    Public Sub ShowDataOnGrid(ByVal sWhere As String)
        mdCnOpen()
        Dim sDt As New DataTable
        Dim vWhere As String = sWhere
        sCommand.CommandText = "Select PdTradeName,PlantTypeName,Detail,PricePerKg,idPdT From vSlPdTradeNameD" & vWhere & " Order by PdTradeName ASC"
        sAdapter.Fill(sDt)
        dgvData.DataSource = sDt
    End Sub
    Public Sub ShowDataOnGridSameValue(ByVal sWhere As String, ByVal sIdPdT() As Integer)
        mdCnOpen()
        Dim sDt As New DataTable
        Dim vWhere As String = sWhere
        sCommand.CommandText = "Select PdTradeName,PlantTypeName,Detail,PricePerKg,idPdT From vSlPdTradeNameD" & vWhere & " Order by idPdT ASC"
        sAdapter.Fill(sDt)
        dgvData.DataSource = sDt
        For i As Integer = 0 To dgvData.Rows.Count - 1
            If i > Val(dgvData.Rows.Count - 1) Then
                Exit For
            End If
            For j As Integer = 0 To sIdPdT.Length - 1
                If dgvData.Rows(i).Cells(idPdT.Name).Value = sIdPdT(j) Then
                    dgvData.Rows.Remove(dgvData.Rows(i))
                End If
            Next
        Next
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim idPdTArray(dgvData.Rows.Count - 1) As Integer
        Dim PdTradeNameArray(dgvData.Rows.Count - 1) As String
        Dim PlantTypeNameArray(dgvData.Rows.Count - 1) As String
        Dim DetailArray(dgvData.Rows.Count - 1) As String
        For i As Integer = 0 To dgvData.Rows.Count - 1
            With dgvData.Rows(i)
                If .Cells(colCheck.Name).Value = True Then
                    idPdTArray(i) = .Cells(idPdT.Name).Value
                    PdTradeNameArray(i) = .Cells(colPdTradeName.Name).Value
                    PlantTypeNameArray(i) = .Cells(colPlantTypeName.Name).Value
                    DetailArray(i) = .Cells(colDetail.Name).Value
                End If
            End With
        Next
        mIdPdT = idPdTArray
        mPdTradeName = PdTradeNameArray
        mPlantTypeName = PlantTypeNameArray
        mDetail = DetailArray
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub chkPdName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPdName.CheckedChanged
        If chkPdName.Checked = True Then
            txtPdName.Enabled = True
            txtPdName.Focus()
        Else
            txtPdName.Enabled = False
        End If
    End Sub

    Private Sub chkPlantName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlantName.CheckedChanged
        If chkPlantName.Checked = True Then
            txtPlantName.Enabled = True
            txtPlantName.Focus()
        Else
            txtPlantName.Enabled = False
        End If
    End Sub

    Private Sub txtPdName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPdName.KeyDown
        If e.KeyCode = Keys.Enter Then pSetData()
    End Sub

    Private Sub txtPlantName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlantName.KeyDown
        If e.KeyCode = Keys.Enter Then pSetData()
    End Sub
End Class