Public Class frmTspCompSelect
    Dim stPage As Integer = 0
    Dim eEvent As eProcess
    Public idSup As Integer = 0
    Public SupName As String = ""

    Enum eProcess
        eAll
    End Enum

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eAll
                stPage = 1
        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmTspCompSelect_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        mdLoadShow()
        BindData()
        mdLoadCommitt()

        Me.txtSupName.Focus()
    End Sub

    Sub BindData()
        'mdPOP_Connect()
        mdCnOpen2()

        Dim sDt As New DataTable
        sDs.Tables.Clear()
        Dim vWHERE As String = ""

        Dim tx As String = txtSupName.Text
        Dim tx_a As String() = tx.Split(" ")
        Dim a_and As String = ""
        Dim strPdPk As String = ""
        If tx_a.Length > 0 Then
            For Each txt As String In tx_a
                If Not txt.Equals("") Then
                    strPdPk += a_and & "" & String.Format(" SupName Like '%{0}%' ", txt)
                End If
                a_and = " and "
            Next
        End If

        If strPdPk <> "" Then
            vWHERE = " AND " & strPdPk
        End If


        'sCommand.CommandText = "Select idSup, SupName From vSupplier WHERE idSupType = 2 " & vWHERE & " Order By SupName "
        sCommand.CommandText = "SELECT  idSup, SupName FROM vSupplier  WHERE stDel is null AND idSup " & _
                               "IN (Select idSup FROM setSuppType WHERE idSupType = 2)  " & vWHERE & " ORDER BY SupName"
        sAdapter.Fill(sDt)

        GCTsp.DataSource = sDt

        If sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูลบริษัทขนส่ง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnSchPd_Click(sender As Object, e As EventArgs) Handles btnSchPd.Click
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub


    Private Sub txtNationName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSupName.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick
        idSup = GVTransport.GetRowCellValue(GVTransport.FocusedRowHandle, ColidSup)
        SupName = GVTransport.GetRowCellValue(GVTransport.FocusedRowHandle, ColSupName)

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class