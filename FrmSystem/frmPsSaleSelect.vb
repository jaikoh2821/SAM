Imports DevExpress.XtraSplashScreen

Public Class frmPsSaleSelect
    Public idPs As String
    Public SaleName As String
    Dim cusName As String
    Dim idPsSaleCut As New DataTable
    Dim idCus As String
    Dim CodeID As Integer = 0
    Dim stPage As Integer = 0
    Dim stload As Integer = 0
    Dim eEvent As eProcess
    Dim gidComp As Integer = 0

    Enum eProcess
        eNormal
        eCutSale
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idPsSale As DataTable, ByVal PsCustomer As String, ByVal vidCus As String, _
            ByVal idCode As Integer, ByVal idComp As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eNormal
                stPage = 1
            Case eProcess.eCutSale
                stPage = 2
                idPsSaleCut = idPsSale
        End Select
        cusName = PsCustomer
        idCus = vidCus
        CodeID = idCode
        eEvent = aProcess

        gidComp = idComp
    End Sub

    'Public Sub GetidComp(ByVal idComp As Integer)
    '    gidComp = idComp
    'End Sub

    Private Sub frmPsSaleSelect_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If CodeID = 1 Then
            Me.lblPsCus.Visible = False
            Me.Label6.Visible = False
            Me.rdbSaleTC.Checked = False
            Me.rdbSaleTC.Enabled = False
            Me.rdbSaleBill.Enabled = False
            Me.rdbSaleAll.Checked = True
        Else
            Me.lblPsCus.Text = cusName
            Me.lblPsCus.Tag = idCus
        End If

        BindData()
        stload = 1
    End Sub

    Sub BindData()
        mdCnOpen()
        mdLoadShow()
        'SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        Dim sDt As New DataTable
        sDs.Tables.Clear()
        Dim vWHERE As String = ""

        If stPage = 2 Then ' case cut sale
            For i As Integer = 0 To idPsSaleCut.Rows.Count - 1
                vWHERE = vWHERE & " AND m.idPs <> " & idPsSaleCut.Rows(i).Item("idPsSale") & " "
            Next
        End If

        If Me.rdbSaleTC.Checked = True Then

            sCommand.CommandText = "SELECT c.idPsSale As idPs, p.PsName " & vbNewLine & _
                               "FROM SmRegionPsSaleComp c " & vbNewLine & _
                               "LEFT JOIN  SmMkCusPs ps ON  c.idRegionC = ps.idRegionC AND ps.idComp = c.idComp" & vbNewLine & _
                               "LEFT JOIN vPersonxSelect p ON c.idPsSale = p.idPs" & vbNewLine & _
                               "WHERE ps.idCus = " & Me.lblPsCus.Tag & vbNewLine & _
                               "AND ps.idComp = " & gidComp

        ElseIf Me.rdbSaleBill.Checked = True Then

            sCommand.CommandText = "Select distinct m.idPsSale as idPs, ps.PsName " & vbNewLine & _
                                   "From SmSaleMt m " & vbNewLine & _
                                   "LEFT JOIN vPersonxSelect ps ON m.idPsSale = ps.idPs" & vbNewLine & _
                                   "Where m.idComp = " & gidComp & vbNewLine & _
                                   "AND m.idCus = '" & Me.lblPsCus.Tag & "'" & vWHERE & ""

        ElseIf Me.rdbSaleAll.Checked = True Then

            'sCommand.CommandText = "Select m.idPs, m.PsName " & vbNewLine & _
            '                        "From vPersonxSelect m " & vbNewLine & _
            '                        "INNER JOIN dPsSaleCompSet c ON m.idPs = c.idPsSale " & vbNewLine & _
            '                        "INNER JOIN dPsSale p ON m.idPs = p.idPs" & vbNewLine & _
            '                        "Where c.idComp = " & gidComp & vbNewLine & _
            '                        "AND m.stDel = 0 " & vbNewLine & _
            '                        "AND m.idStWork <> 4" & vbNewLine & _
            '                        "AND p.stCanCel IS NULL" & vbNewLine & _
            '                        "Order By m.PsName"
            'If gidComp = 2 Or gidComp = 3 Then
            sCommand.CommandText = "SELECT Distinct p.idPs, p.PsName " & vbNewLine &
                                   "FROM dPsSaleComp c " & vbNewLine &
                                   "LEFT JOIN vPersonxSelect p ON c.idPs = p.idPs" & vbNewLine &
                                   "WHERE  c.idComp = " & gidComp & vbNewLine &
                                   "AND c.stCancel Is NULL" & vbNewLine &
                                   "AND p.idStWork = 1" & vbNewLine &
                                   "Order By p.PsName"

            'Else
            '    sCommand.CommandText = "SELECT Distinct c.idPsSale As idPs, p.PsName " & vbNewLine & _
            '                       "FROM SmRegionPsSaleComp c " & vbNewLine & _
            '                       "LEFT JOIN vPersonxSelect p ON c.idPsSale = p.idPs" & vbNewLine & _
            '                       "WHERE  c.idComp = " & gidComp & vbNewLine & _
            '                       "Order By p.PsName"
            'End If



        ElseIf Me.rdbSaleQuit.Checked = True Then

            sCommand.CommandText = "SELECT Distinct m.idPs, m.PsName" & vbNewLine & _
                                    "FROM dPsSaleComp s " & vbNewLine & _
                                    "LEFT JOIN vPersonxSelect m ON s.idPs =  m.idPs" & vbNewLine & _
                                    "WHERE m.idStWork = 4" & vbNewLine & _
                                    "AND s.idComp = " & gidComp & vbNewLine & _
                                    "Order By m.PsName"

        End If

        sAdapter.Fill(sDt)
        'Me.dgSale.DataSource = sDt
        GCSale.DataSource = sDt
        mdLoadCommitt()
        'SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub rpsSelect_Click(sender As Object, e As EventArgs) Handles rpsSelect.Click
        idPs = CInt(GVSale.GetDataRow(GVSale.FocusedRowHandle).Item("idPs"))
        SaleName = CStr(GVSale.GetDataRow(GVSale.FocusedRowHandle).Item("PsName"))
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub rdbSaleTC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSaleTC.CheckedChanged
        If CodeID = 0 And stload = 1 Then
            BindData()
        End If

    End Sub

    Private Sub rdbSaleBill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSaleBill.CheckedChanged
        If stload = 1 Then
            BindData()
        End If
    End Sub

    Private Sub rdbSaleAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSaleAll.CheckedChanged
        If stload = 1 Then
            BindData()
        End If
    End Sub

    Private Sub rdbSaleQuit_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSaleQuit.CheckedChanged
        If stload = 1 Then
            BindData()
        End If
    End Sub
    
    Private Sub GVSale_KeyDown(sender As Object, e As KeyEventArgs) Handles GVSale.KeyDown
        If e.KeyCode = Keys.Enter Then
            idPs = CInt(GVSale.GetDataRow(GVSale.FocusedRowHandle).Item("idPs"))
            SaleName = CStr(GVSale.GetDataRow(GVSale.FocusedRowHandle).Item("PsName"))
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class