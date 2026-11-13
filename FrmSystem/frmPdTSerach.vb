Public Class frmPdTSerach
    Dim strPP As String = "PP"
    Dim Status As Integer
    Dim vWhere As String
    Dim st_ As Integer = 0
    Dim dPdT_ As DataGridView
    Enum eProcess
        ePP
        eAll
        eMul
    End Enum
    Sub New(ByVal aProcess As eProcess)
        InitializeComponent()
        Select Case aProcess
            Case eProcess.ePP
                Status = 0
                Me.DGV_PdT.Columns("colPP").Visible = True
                Me.chkpp.Visible = True
            Case eProcess.eAll
                Status = 1
            Case eProcess.eMul
                Status = 2
                DGV_PdT.Columns("colPdt").Visible = False
                DGV_PdT.Columns("colSel2").Visible = True
                btn_add.Visible = True
        End Select
    End Sub
    Sub get_valuePP(ByVal PP As String)
        strPP = PP
    End Sub
    Sub get_value(ByVal st As Integer)
        st_ = st
    End Sub
    Public Sub getDGV(ByVal dPs As DataGridView)
        dPdT_ = dPs
    End Sub
    Dim pDt As New DataTable
    Dim pDt1 As New DataTable
    Dim vPdT As New DataView
    Sub Load_Data()
        If st_ = 1 Then
            If strPP = "PP3" Then
                DGV_PdT.Columns(colPdTnameEN.Name).Visible = True
            End If
            chkpp.Checked = True
            'Dim pDt As New DataTable

            'pDt.Clear()
            'sCommand.CommandText = "Select idPdT , PdTradeName, " & strPP & " As PP, idSeedType ,idSeedKind,PlantTypeName,idType  FROM vSlPdTradeNameD WHERE " & strPP & " = '' OR " & strPP & " IS NULL"
            'sAdapter.Fill(pDt)

            pDt.Clear()
            sCommand.CommandText = "Select idPdT , PdTradeName, PdTradeNameEN, " & strPP & " As PP, idSeedType ,idSeedKind,PlantTypeName,idType,stPPNot  FROM vSlPdTradeNameD WHERE " & strPP & " = '' OR " & strPP & " IS NULL Order by PdTradeName ASC"
            sAdapter.Fill(pDt)
            Me.DGV_PdT.DataSource = pDt
            Me.Label2.Visible = True
            Me.Label2.Text = "สินค้าทั้งหมด " & pDt.Rows.Count & " รายการ"
            For i As Integer = 0 To pDt.Rows.Count - 1
                If Me.DGV_PdT.Rows(i).Cells(Me.colstPPNot.Name).Value.ToString = "1" Then
                    Me.DGV_PdT.Rows(i).DefaultCellStyle.BackColor = Color.Salmon
                End If
            Next

        ElseIf Status = 2 Then
            pDt.Clear()
            sCommand.CommandText = "Select idPdT , PdTradeName, " & strPP & " As PP, idSeedType ,idSeedKind,PlantTypeName,idType,stPPNot  FROM vSlPdTradeNameD Order by PdTradeName ASC"
            sAdapter.Fill(pDt)
            pDt.Columns.Add("chkPdT", System.Type.GetType("System.Boolean"))
            For i As Integer = 0 To pDt.Rows.Count - 1
                pDt.Rows(i).Item("chkPdT") = False
            Next
            Me.Label2.Visible = True
            Me.Label2.Text = "สินค้าทั้งหมด " & pDt.Rows.Count & " รายการ"
        Else
            'Dim pDt As New DataTable
            pDt.Clear()
            sCommand.CommandText = "Select idPdT , PdTradeName, " & strPP & " As PP, idSeedType ,idSeedKind,PlantTypeName,idType,stPPNot  FROM vSlPdTradeNameD Order by PdTradeName ASC"
            sAdapter.Fill(pDt)
            Me.DGV_PdT.DataSource = pDt
            Me.Label2.Visible = True
            Me.Label2.Text = "สินค้าทั้งหมด " & pDt.Rows.Count & " รายการ"
        End If
    End Sub
    Private Sub frmPdTSerach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdCnOpen()
        Load_Data()
        If Status = 2 Then
            chk_Person()
            vPdT = New DataView(pDt)
            DGV_PdT.DataSource = vPdT
        End If
        Me.txt_Sname.Focus()
    End Sub
    Private Sub txt_Sname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Sname.KeyDown
        If e.KeyCode = Keys.Enter And (Status = 0 Or Status = 1) Then
            vWhere = "WHERE "
            mdCnOpen()
            If Me.chkpp.Checked = True Then
                vWhere += strPP & " = '' Or " & strPP & " IS NULL AND"
            End If
            If Me.txt_Sname.Text <> "" Then
                vWhere += " PdTradeName LIKE '%" & Me.txt_Sname.Text & "%' AND"
            End If
            'If Me.chkpp.Checked = False And Me.txt_Sname.Text = "" Then
            '    vWhere = ""
            'Else
            '    vWhere = (Microsoft.VisualBasic.Left(vWhere, vWhere.Length - 3))
            'End If
            'If Me.txt_Sname.Text <> "" Then
            'vWhere += "PdTradeName LIKE '%" & Me.txt_Sname.Text & "%'"
            'Else
            'vWhere = (Microsoft.VisualBasic.Left(vWhere, vWhere.Length - 4))
            'End If
            'Dim pDt As New DataTable
            'pDt.Clear()
            'sCommand.CommandText = "Select idPdT , PdTradeName,  " & strPP & " As PP, idSeedType ,idSeedKind,PlantTypeName,idType  FROM vSlPdTradeNameD " & vWhere
            'sAdapter.Fill(pDt)
            'Me.Label2.Visible = True
            'Me.Label2.Text = "สินค้าทั้งหมด " & pDt.Rows.Count & " รายการ"
            If Me.chkpp.Checked = False And Me.txt_Sname.Text = "" Then
                vWhere = ""
            Else
                vWhere = (Microsoft.VisualBasic.Left(vWhere, vWhere.Length - 3))
            End If
            pDt.Clear()
            sCommand.CommandText = "Select idPdT , PdTradeName, PdTradeNameEN, " & strPP & " As PP, idSeedType ,idSeedKind,PlantTypeName,idType,stPPNot  FROM vSlPdTradeNameD " & vWhere & " Order by PdTradeName ASC"
            sAdapter.Fill(pDt)
            Me.Label2.Visible = True
            Me.Label2.Text = "สินค้าทั้งหมด " & pDt.Rows.Count & " รายการ"
            Me.DGV_PdT.DataSource = pDt
            For i As Integer = 0 To pDt.Rows.Count - 1
                If Me.DGV_PdT.Rows(i).Cells(Me.colstPPNot.Name).Value.ToString = "1" Then
                    Me.DGV_PdT.Rows(i).DefaultCellStyle.BackColor = Color.Salmon
                End If
            Next
        ElseIf e.KeyCode = Keys.Enter And (Status = 2) Then
            PsChang()
            If txt_Sname.Text <> "" Then
                vPdT.RowFilter = "PdTradeName LIKE '%" & txt_Sname.Text & "%'"
                DGV_PdT.DataSource = vPdT
                Me.Label2.Visible = True
                Me.Label2.Text = "สินค้าทั้งหมด " & DGV_PdT.Rows.Count & " รายการ"
            End If
        End If
    End Sub
    Public idPdT As Integer
    Public idSeedType As Integer
    Public PdTName As String
    Public idSK As Integer
    Public PTName As String
    Public idType As Integer
    Public PP_ As String
    Public strPdT As String = ""

    Private Sub DGV_PdT_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_PdT.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If Me.DGV_PdT.Columns(e.ColumnIndex).Name = Me.colPdt.Name Then
            idPdT = Me.DGV_PdT.Rows(e.RowIndex).Cells(colidPdT.Name).Value
            If strPP = "PP3" Then
                PdTName = Me.DGV_PdT.Rows(e.RowIndex).Cells(colPdTnameEN.Name).Value
            Else
                PdTName = Me.DGV_PdT.Rows(e.RowIndex).Cells(colPdTname.Name).Value
            End If

            idSeedType = Me.DGV_PdT.Rows(e.RowIndex).Cells(colidSeedType.Name).Value
            idSK = Me.DGV_PdT.Rows(e.RowIndex).Cells(colidSeedKind.Name).Value
            PTName = Me.DGV_PdT.Rows(e.RowIndex).Cells(colPlantTypeName.Name).Value
            If Me.DGV_PdT.Rows(e.RowIndex).Cells(colPP.Name).Value Is DBNull.Value Then
                PP_ = ""
            Else
                PP_ = Me.DGV_PdT.Rows(e.RowIndex).Cells(colPP.Name).Value
            End If
            If Me.DGV_PdT.Rows(e.RowIndex).Cells(colidtype.Name).Value Is DBNull.Value Then
                idType = 0
            Else
                idType = Me.DGV_PdT.Rows(e.RowIndex).Cells(colidtype.Name).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
    Private Sub chk_Person()
        If dPdT_.Rows.Count > 0 Then
            For i As Integer = 0 To dPdT_.Rows.Count - 1
                For j As Integer = 0 To pDt.Rows.Count - 1
                    If dPdT_.Rows(i).Cells("colidPdT").Value = pDt.Rows(j).Item("idPdT") Then
                        pDt.Rows(j).Item("chkPdT") = True
                        'Else
                    End If
                Next
            Next
        End If
    End Sub
    Private Sub PsChang()
        For i As Integer = 0 To DGV_PdT.Rows.Count - 1
            'Dim a As Boolean = DGV_Menu.Rows(i).Cells(col_select.Name).Value
            For j As Integer = 0 To pDt.Rows.Count - 1
                If DGV_PdT.Rows(i).Cells(colidPdT.Name).Value = pDt.Rows(j).Item("idPdT") Then
                    If DGV_PdT.Rows(i).Cells(colSel2.Name).Value = True Then
                        pDt.Rows(j).Item("chkPdT") = DGV_PdT.Rows(i).Cells(colSel2.Name).Value
                    Else
                        pDt.Rows(j).Item("chkPdT") = False
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        PsChang()
        Dim checkS As Boolean = False
        For i As Integer = 0 To Me.pDt.Rows.Count - 1
            If pDt.Rows(i).Item("chkPdT") = True Then
                checkS = True
                strPdT += pDt.Rows(i).Item("idPdT") & ","
            End If
        Next
        If checkS = False Then
            MessageBox.Show("ยังไม่ได้เลือกบุคคล")
            Exit Sub
        End If
        strPdT = (Microsoft.VisualBasic.Left(strPdT, strPdT.Length - 1))
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class