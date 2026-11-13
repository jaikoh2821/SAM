Public Class frmSsQcPersonSelect
    Dim status As Integer
    Dim dt1 As New DataTable

    Dim dPs_ As DataGridView
    Enum eProcess
        eMul
        eSin
        eRdSale
    End Enum
    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eMul
                status = 1
                txtSName.Visible = False
                RdSales.Visible = False
                RdAll.Visible = False
            Case eProcess.eSin
                status = 0
                DGV_person.Columns("colSel").Visible = False
                DGV_person.Columns("colSel2").Visible = True
                btn_add.Enabled = False
                txtSName.Visible = False
                RdSales.Visible = False
                RdAll.Visible = False
            Case eProcess.eRdSale
                'status = 0
                DGV_person.Columns(Me.col_PosName.Name).DefaultCellStyle.BackColor = Color.Gainsboro
                DGV_person.Columns(Me.col_CompName.Name).DefaultCellStyle.BackColor = Color.Gainsboro
                DGV_person.Columns(Me.colPsName.Name).DefaultCellStyle.BackColor = Color.Gainsboro
                DGV_person.Columns("colSel").Visible = False
                DGV_person.Columns("colSel2").Visible = True
                btn_add.Visible = False
                CHKname.Visible = False
                CHKPosition.Visible = False
                txt_name.Visible = False
                txtSName.Visible = True
                MaximizeBox = False
                MinimizeBox = False
                Text = "เลือกพนักงาน"
        End Select
    End Sub
    Public Sub getvalue(ByVal dPs As DataGridView)
        dPs_ = dPs
    End Sub
    Dim vPs As DataView
    Private Sub frmSsQcPersonSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        

        mdCnOpen()
        Load_Person()
        If status = 1 Then
            chk_Person()
        End If
        vPs = New DataView(pDt)
        DGV_person.DataSource = vPs
        Dim sDtTemp As New DataTable
        sCommand.CommandText = "SELECT DISTINCT PositionName FROM vPerson"
        sAdapter.Fill(sDtTemp)
        comboposition.DataSource = sDtTemp
        comboposition.DisplayMember = "PositionName"
        comboposition.ValueMember = "PositionName"
        comboposition.SelectedValue = ""


        If eProcess.eRdSale Then
            If RdSales.Checked = True Then
                mdCnOpen()
                Dim sDt As New DataTable
                sCommand.CommandText = "SELECT idPs, PsName, PositionName, CompName FROM vPerson " & _
                                        " WHERE stSale = '1' ORDER BY PsName "

                sAdapter.Fill(sDt)
                DGV_person.DataSource = sDt
            Else
                mdCnOpen()
                Dim sDt As New DataTable
                sCommand.CommandText = "SELECT idPs, PsName, PositionName, CompName FROM vPerson ORDER BY PsName "
                sAdapter.Fill(sDt)
                DGV_person.DataSource = sDt
            End If
        End If
        'DGV_person.DataSource = pDt

    End Sub
    Dim pDt As New DataTable
    Private Sub Load_Person()
        pDt.Clear()
        sCommand.CommandText = "Select idPs , PsName ,PositionName, CompName  FROM vPerson ORDER BY PsName "
        sAdapter.Fill(pDt)
        pDt.Columns.Add("chkPs", System.Type.GetType("System.Boolean"))
        For i As Integer = 0 To pDt.Rows.Count - 1
            pDt.Rows(i).Item("chkPs") = False
        Next
    End Sub
    Private Sub chk_Person()
        If dPs_.Rows.Count > 0 Then
            For i As Integer = 0 To dPs_.Rows.Count - 1
                For j As Integer = 0 To pDt.Rows.Count - 1
                    If dPs_.Rows(i).Cells("col_idPs").Value = pDt.Rows(j).Item("idPs") Then
                        pDt.Rows(j).Item("chkPs") = True
                        'Else
                    End If
                Next
            Next
        End If
    End Sub
    Public id As Integer
    Public PsName As String
    Public idPs As String = ""
    Private Sub DGV_person_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_person.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If Me.DGV_person.Columns(e.ColumnIndex).Name = Me.colSel2.Name Then
            id = Me.DGV_person.Rows(e.RowIndex).Cells(colidPs.Name).Value
            PsName = Me.DGV_person.Rows(e.RowIndex).Cells(colPsName.Name).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub


    Private Sub txt_name_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            PsChang()
            If CHKPosition.Checked = True And comboposition.SelectedValue <> "" Then
                vPs.RowFilter = "PsName LIKE '%" & Me.txt_name.Text & "%' AND PositionName LIKE '%" & comboposition.SelectedValue & "%'"
            Else
                vPs.RowFilter = "PsName LIKE '%" & Me.txt_name.Text & "%'"
            End If
            'vPs.RowFilter = "PsName LIKE '%" & Me.txt_name.Text & "%'"
            DGV_person.DataSource = vPs

        End If
    End Sub

    Private Sub PsChang()
        For i As Integer = 0 To DGV_person.Rows.Count - 1
            'Dim a As Boolean = DGV_Menu.Rows(i).Cells(col_select.Name).Value
            For j As Integer = 0 To pDt.Rows.Count - 1
                If DGV_person.Rows(i).Cells(colidPs.Name).Value = pDt.Rows(j).Item("idPs") Then
                    If DGV_person.Rows(i).Cells(colSel.Name).Value = True Then
                        pDt.Rows(j).Item("chkPs") = DGV_person.Rows(i).Cells(colidPs.Name).Value
                    Else
                        pDt.Rows(j).Item("chkPs") = False
                    End If
                End If
            Next
        Next
    End Sub
    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        PsChang()
        Dim checkS As Boolean = False
        For i As Integer = 0 To Me.pDt.Rows.Count - 1
            If pDt.Rows(i).Item("chkPs") = True Then
                checkS = True
                idPs += pDt.Rows(i).Item("idPs") & ","
            End If
        Next
        If checkS = False Then
            MessageBox.Show("ยังไม่ได้เลือกบุคคล")
            Exit Sub
        End If
        idPs = (Microsoft.VisualBasic.Left(idPs, idPs.Length - 1))
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub CHK_Comp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKPosition.CheckedChanged
        If CHKPosition.Checked = True Then
            comboposition.Enabled = True
        Else
            comboposition.Enabled = False
            comboposition.Text = ""
        End If
        If CHKPosition.Checked = False And CHKname.Checked = False Then
            PsChang()
            vPs = New DataView(pDt)
            DGV_person.DataSource = vPs
        End If
    End Sub
    Private Sub CHKname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKname.CheckedChanged
        If CHKname.Checked = True Then
            txt_name.Enabled = True
        Else
            txt_name.Enabled = False
            txt_name.Text = ""
        End If
        If CHKPosition.Checked = False And CHKname.Checked = False Then
            PsChang()
            vPs = New DataView(pDt)
            DGV_person.DataSource = vPs
        End If
    End Sub

    Private Sub comboposition_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboposition.SelectedIndexChanged
        If CHKPosition.Checked = True Then
            PsChang()
            If CHKname.Checked = True And txt_name.Text <> "" Then
                vPs.RowFilter = "PsName LIKE '%" & Me.txt_name.Text & "%' AND PositionName LIKE '%" & comboposition.SelectedValue & "%'"
            Else
                'if comboposition.SelectedValue <> "" Then
                vPs.RowFilter = "PositionName LIKE '%" & comboposition.SelectedValue & "%'"
                'End If
            End If
            DGV_person.DataSource = vPs
        End If

    End Sub

    Private Sub RdSales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdSales.CheckedChanged
        Dim sDt As New DataTable
        mdCnOpen()
        If RdSales.Checked = True Then
            comboposition.Enabled = False
            'sCommand.CommandText = "SELECT DISTINCT p.idPs , p.PsName ,p.PositionName, p.CompName FROM dbo.SmMkCusPs AS sm INNER JOIN " & _
            '               " dbo.vPerson AS p ON sm.idPs = p.idPs LEFT OUTER JOIN " & _
            '                " dbo.vCustomer AS c ON c.idCus = sm.idCus WHERE (p.idPosition = '2') ORDER BY p.PsName"
            sCommand.CommandText = "SELECT idPs, PsName, PositionName, CompName FROM vPerson " & _
                                               " WHERE stSale = '1' ORDER BY PsName "

            sAdapter.Fill(sDt)
            DGV_person.DataSource = sDt
            dt1 = sDt
        Else
            comboposition.Enabled = True
            sCommand.CommandText = "SELECT idPs, PsName, PositionName, CompName FROM vPerson  ORDER BY PsName "

            sAdapter.Fill(sDt)
            DGV_person.DataSource = sDt
            dt1 = sDt
        End If
    End Sub

    Private Sub txtSName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim sDt As New DataTable
            Dim dv As New DataView(dt1)
            If RdSales.Checked = True Then
                dv.RowFilter = "PsName LIKE  '%" & txtSName.Text & "%'"

            Else
                dv.RowFilter = "PsName LIKE  '%" & txtSName.Text & "%' AND PositionName LIKE '%" & comboposition.SelectedValue & "%'"
            End If
            DGV_person.DataSource = dv
        End If

    End Sub

    Private Sub dgvExpense_RowPostPaint1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DGV_person.RowPostPaint
        Me.DGV_person("colautonum", e.RowIndex).Value = e.RowIndex + 1

    End Sub
    'Private Sub txtSearch()

    '    Dim dv As New DataView(dt1)
    '    Dim strSubCombo As String = ""
    '    If cbPsName.Checked = True And cbSearchCus.Checked = True Then
    '        strSubCombo = ComboPsName.SelectedValue
    '        dv.RowFilter = "CusName_ LIKE  '%" & txtSearchCus.Text & "%' AND PsName LIKE  '%" & strSubCombo & "%'"
    '    ElseIf cbSearchCus.Checked = True Then
    '        dv.RowFilter = "CusName_ LIKE  '%" & txtSearchCus.Text & "%'"
    '    ElseIf cbPsName.Checked = True Then
    '        dv.RowFilter = "PsName LIKE  '%" & ComboPsName.SelectedValue & "%'"

    '    End If
    '    dgvData1.DataSource = dv
    '    dgvData1.Sort(dgvData1.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
    '    dgvData1.DataSource = dv
    '    If dgvData1.Rows.Count < 1 Then
    '        MessageBox.Show("ไม่พบที่ค้นหา", "SAM")
    '    End If

    'End Sub
End Class