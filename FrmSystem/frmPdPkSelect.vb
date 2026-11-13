Public Class frmPdPkSelect
    Public idPdPk As String
    Public PdCodeS As String
    Public ShortName As String
    Public PdPkName As String
    Public Weight As Double
    Public Unit As String
    Public idUnit As String
    Public idPkUnit As String
    Public PerBox As Integer
    Public PriceBill As Double
    Public PriveWh As Double
    Public PriceRetail As Double
    Public Barcode As String
    Public strPdPk As String = ""
    Public PkUnitName As String
    Public pidPdPkLot As String
    Public PdPkLotNo As String
    Dim stPage As Integer = 0
    Dim eEvent As eProcess
    Dim dPdPk As DataGridView
    Dim vPdPk As New DataView
    Dim idPdPk_Rec As String = ""
    ' Dim lastIndexColCell As Integer = 0  ' Tab Grid

    Dim sDt As New DataTable
    Dim sqlLot As Integer = 0  ' 0 : sql No Lot / 1: sql Lot

    Enum eProcess
        ePdGen  ' สินค้าทั่วไป
        ePdPack   ' สินค้าผักซอง
        ePdAll  ' สินค้าทั้งหมด
        ePdFolwer   ' สินค้าดอกไม้
        ' ePdAllMul  ' เลือกได้หลายสินค้า
        ePromotion  ' เลือกสินค้าที่ผูกกับโปรโมชั่น
        ePdAmount  ' เลือกดูจำนวนคงเหลือ
        ePdLotSelect  ' เลือก Lot ALl
        ePdGenLot  ' เลือก lot สินค้าทั่วไป
        ePdPackLot  ' เลือก lot สินค้าผักซอง
        ePdFolwerLot  ' เลือก lot สินค้าดอกไม้
        eLotOnlyidPdPk '  เลือก lot ระบุ idPdPk
    End Enum

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.ePdGen
                stPage = 1
                sqlLot = 0
            Case eProcess.ePdPack
                stPage = 2
                sqlLot = 0
            Case eProcess.ePdAll
                stPage = 3
                sqlLot = 0
            Case eProcess.ePdFolwer
                stPage = 4
                sqlLot = 0
                'Case eProcess.ePdAllMul
                'stPage = 5
                'sqlLot = 0
                'btn_add.Visible = True
                'dgvPd.Columns(col_sel2.Name).Visible = True
                'dgvPd.Columns(colSelect.Name).Visible = False
            Case eProcess.ePromotion
                stPage = 6
                sqlLot = 0
                Me.Panel1.Visible = False
                Me.Panel2.Visible = False
                dgvPd.Columns(ColPriceBill.Name).Visible = False
                dgvPd.Columns(ColPriceRetail.Name).Visible = False
                dgvPd.Columns(ColPriceWholesale.Name).Visible = False
            Case eProcess.ePdAmount
                sqlLot = 0
                dgvPd.Columns(Amount.Name).Visible = True
                dgvPd.Columns(ColPkUnitName.Name).Visible = True
                dgvPd.Columns(ColPriceWholesale.Name).Visible = False
                dgvPd.Columns(ColPriceRetail.Name).Visible = False
                dgvPd.Columns(ColPriceBill.Name).Visible = False
                stPage = 7
            Case eProcess.ePdLotSelect
                sqlLot = 1
                dgvPd.Columns(Amount.Name).Visible = True
                dgvPd.Columns(ColLotNum.Name).Visible = True
                dgvPd.Columns(ColPkUnitName.Name).Visible = True
                dgvPd.Columns(ColPriceWholesale.Name).Visible = False
                dgvPd.Columns(ColPriceRetail.Name).Visible = False
                dgvPd.Columns(ColPriceBill.Name).Visible = False
                Me.ChkNoStock.Visible = True
                Me.ChkLot.Visible = True
                Me.txtLot.Visible = True
                stPage = 8
            Case eProcess.ePdGenLot
                sqlLot = 1
                dgvPd.Columns(Amount.Name).Visible = True
                dgvPd.Columns(ColLotNum.Name).Visible = True
                dgvPd.Columns(ColPkUnitName.Name).Visible = True
                dgvPd.Columns(ColPriceWholesale.Name).Visible = False
                dgvPd.Columns(ColPriceRetail.Name).Visible = False
                dgvPd.Columns(ColPriceBill.Name).Visible = False
                Me.ChkNoStock.Visible = True
                Me.ChkLot.Visible = True
                Me.txtLot.Visible = True
                stPage = 9
            Case eProcess.ePdPackLot
                sqlLot = 1
                dgvPd.Columns(Amount.Name).Visible = True
                dgvPd.Columns(ColLotNum.Name).Visible = True
                dgvPd.Columns(ColPkUnitName.Name).Visible = True
                dgvPd.Columns(ColPriceWholesale.Name).Visible = False
                dgvPd.Columns(ColPriceRetail.Name).Visible = False
                dgvPd.Columns(ColPriceBill.Name).Visible = False
                Me.ChkNoStock.Visible = True
                Me.ChkLot.Visible = True
                Me.txtLot.Visible = True
                stPage = 10
            Case eProcess.ePdFolwerLot
                sqlLot = 1
                dgvPd.Columns(Amount.Name).Visible = True
                dgvPd.Columns(ColLotNum.Name).Visible = True
                dgvPd.Columns(ColPkUnitName.Name).Visible = True
                dgvPd.Columns(ColPriceWholesale.Name).Visible = False
                dgvPd.Columns(ColPriceRetail.Name).Visible = False
                dgvPd.Columns(ColPriceBill.Name).Visible = False
                Me.ChkNoStock.Visible = True
                Me.ChkLot.Visible = True
                Me.txtLot.Visible = True
                stPage = 11
            Case eProcess.eLotOnlyidPdPk
                sqlLot = 1
                dgvPd.Columns(Amount.Name).Visible = True
                dgvPd.Columns(ColLotNum.Name).Visible = True
                dgvPd.Columns(ColPkUnitName.Name).Visible = True
                dgvPd.Columns(ColPriceWholesale.Name).Visible = False
                dgvPd.Columns(ColPriceRetail.Name).Visible = False
                dgvPd.Columns(ColPriceBill.Name).Visible = False
                Me.ChkNoStock.Visible = True
                Me.ChkLot.Visible = True
                Me.txtLot.Visible = True
                stPage = 12
        End Select
        eEvent = aProcess
    End Sub

    Public Sub ShowText(ByVal idPdPk As String)
        idPdPk_Rec = idPdPk
    End Sub

    Public Sub getDGV(ByVal dPs As DataGridView)
        dPdPk = dPs
    End Sub

    Private Sub frmPdPkSelect_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ' cmbWeights()
        Me.ChkPd.Checked = True
        Me.txtPdName.Enabled = True
        Me.txtPdName.Focus()
        If stPage = 5 Then
            mdLoadShow()
            Load_PdPk()
            BindData()
            mdLoadCommitt()
        ElseIf stPage = 6 Then
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        ElseIf stPage = 12 Then
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If

    End Sub

    'Private Sub cmbWeights()
    '    mdCnOpen()
    '    Dim sDt As New DataTable
    '    sCommand.CommandText = "Select distinct Weight From dPackingW"
    '    sAdapter.Fill(sDt)
    '    With cmbWeight
    '        .DisplayMember = "Weight"
    '        .ValueMember = "Weight"
    '        .DataSource = sDt
    '    End With

    '    Dim Dt As New DataTable
    '    sCommand.CommandText = "Select distinct idUnitW, UnitW From dUnitW"
    '    sAdapter.Fill(Dt)
    '    With CmbUnitW
    '        .DisplayMember = "UnitW"
    '        .ValueMember = "idUnitW"
    '        .DataSource = Dt
    '    End With
    'End Sub

    Private Sub BindData()
        If stPage <> 5 Then
            Dim vWhere As String = ""

            If stPage = 6 Then  '  ePromotion
                Dim Str() As String
                Str = idPdPk_Rec.ToString().Split("|")

                vWhere = vWhere & " AND p.idPdPk = " & Str(0) & " "
                For i As Integer = 1 To Str.Length - 1
                    vWhere = vWhere & " OR p.idPdPk = " & Str(i) & " "
                Next
            ElseIf stPage = 12 Then
                Me.Panel2.Visible = False
                Me.Panel1.Visible = False
                vWhere = vWhere & " AND p.idPdPk = " & idPdPk_Rec & " "
            Else  ' Other
                If ChkPd.Checked = True Then
                    Dim tx As String = txtPdName.Text
                    Dim tx_a As String() = tx.Split(" ")
                    Dim a_and As String = ""
                    Dim strPdPk As String = ""
                    If tx_a.Length > 0 Then
                        For Each txt As String In tx_a
                            If Not txt.Equals("") Then
                                strPdPk += a_and & "" & String.Format(" PdPkName Like '%{0}%' ", txt)
                            End If
                            a_and = " and "
                        Next
                    End If

                    If strPdPk <> "" Then
                        vWhere = vWhere & " AND " & strPdPk
                    End If
                End If

                If ChkLot.Checked = True Then
                    'If vWhere = "" Then
                    '    vWhere = vWhere & "WHERE lot.LotNum = '" & txtLot.Text & "' "
                    'Else
                    vWhere = vWhere & " AND  lot.LotNum = '" & txtLot.Text & "' "
                    ' End If

            End If

                'If ChkPd.Checked = True And ChkWeight.Checked = False Then
                '    vWhere = " Where (p.PdPkName Like '%" & txtPdName.Text & "%' OR p.ShortName Like '%" & txtPdName.Text & "%') "
                '    'vWhere = " Where p.PdPkName Like '%" & txtPdName.Text & "%' "
                'ElseIf ChkPd.Checked = False And ChkWeight.Checked = True Then
                '    vWhere = " Where p.Weight = '" & cmbWeight.SelectedValue & "' AND p.idUnitW='" & CmbUnitW.SelectedValue & "' "
                'ElseIf ChkPd.Checked = True And ChkWeight.Checked = True Then
                '    vWhere = " Where p.PdPkName Like '%" & txtPdName.Text & "%' And p.Weight = '" & cmbWeight.SelectedValue & "' " & _
                '             "AND p.idUnitW='" & CmbUnitW.SelectedValue & "' "
                'End If

                If stPage = 1 Or stPage = 9 Then  ' สินค้าทั่วไป
                    'If vWhere = "" Then
                    '    vWhere = " Where (p.idType Is NULL or p.idType = '0') "
                    'Else
                    vWhere = vWhere & " AND (p.idType IS NULL or p.idType = '0') "
                    'End If
                ElseIf stPage = 2 Or stPage = 10 Then   ' สินค้าผักซอง
                    'If vWhere = "" Then
                    '    'vWhere = " Where p.idType = '1' AND t.idSeedKind <> '2' "
                    '    vWhere = " Where p.idType = '1' "
                    'Else
                    'vWhere = vWhere & " AND p.idType = '1' AND t.idSeedKind <> '2' "
                    vWhere = vWhere & " AND p.idType = '1' "
                    'End If
                ElseIf stPage = 4 Or stPage = 11 Then  ' สินค้าดอกไม้
                    'If vWhere = "" Then
                    '    vWhere = " Where t.idSeedKind = '2' "
                    'Else
                    vWhere = vWhere & " AND t.idSeedKind = '2' "
                    'End If
            End If

                End If  ' End Check stpage = 6

                mdCnOpen()

                sDt.Clear()
                If sqlLot = 0 Then
                sCommand.CommandText = "Select p.idPdPk, p.PdCode, p.Barcode, p.PdPkName, p.ShortName, p.Weight, p.UnitW, " & _
                                       "p.idUnitW, p.idPkUnit, p.PkUnitName, p.PriceBill, p.PriceWholesale, " & _
                                       "p.PriceRetail, p.PerBox, t.idSeedKind,p.Amount From vPackingPdSet p " & _
                                       "LEFT OUTER JOIN vSlPdTradeNameD t ON p.idPdT = t.idPdT WHERE " & _
                                       "p.stDel IS NULL AND p.idComp = " & sIdComp & vWhere & " Order by p.PdPkName"
            ElseIf sqlLot = 1 Then
                If Me.ChkNoStock.Checked = True Then
                    'If vWhere = " " Then
                    '    vWhere = "Where lot.Amount > '0' "
                    'Else


                    vWhere = vWhere & " AND lot.Amount > '0' "
                    'End If

            End If

                sCommand.CommandText = "Select lot.idPdPkLot , lot.LotNum , p.idPdPk, p.PdCode, p.Barcode, p.PdPkName, " & _
                                       "p.ShortName, p.Weight, p.UnitW, " & _
                                       "p.idUnitW, p.idPkUnit, p.PkUnitName, p.PriceBill, p.PriceWholesale, " & _
                                       "p.PriceRetail, p.PerBox, t.idSeedKind, lot.Amount From dPackingPdSetLot lot " & _
                                       "LEFT JOIN vPackingPdSet p ON p.idPdPk = lot.idPdPk " & _
                                       "LEFT OUTER JOIN vSlPdTradeNameD t ON p.idPdT = t.idPdT WHERE " & _
                                       "p.stDel IS NULL AND lot.CompRec = " & sIdComp & vWhere & " Order by p.PdPkName"
                End If
                sAdapter.Fill(sDt)
                dgvPd.DataSource = sDt

                If sDt.Rows.Count = 0 Then
                    mdLoadCommitt()
                    MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName)
                    Exit Sub
                End If
        Else
                PsChang()
                If ChkPd.Checked = True And ChkWeight.Checked = False Then
                    vPdPk.RowFilter = "(PdPkName Like '%" & txtPdName.Text & "%' OR ShortName Like '%" & txtPdName.Text & "%')"
                    'vWhere = " Where p.PdPkName Like '%" & txtPdName.Text & "%' "
                ElseIf ChkPd.Checked = False And ChkWeight.Checked = True Then
                    vPdPk.RowFilter = "Weight = '" & cmbWeight.SelectedValue & "' AND idUnitW='" & CmbUnitW.SelectedValue & "' "
                ElseIf ChkPd.Checked = True And ChkWeight.Checked = True Then
                    vPdPk.RowFilter = "PdPkName Like '%" & txtPdName.Text & "%' And Weight = '" & cmbWeight.SelectedValue & "' AND idUnitW='" & CmbUnitW.SelectedValue & "' "
                End If
                dgvPd.DataSource = vPdPk
        End If
    End Sub

    Private Sub Load_PdPk()
        sDt.Clear()
        sCommand.CommandText = "Select p.idPdPk, p.PdCode, p.Barcode, p.PdPkName, p.ShortName, p.Weight, p.UnitW, " & _
                               "p.idUnitW, p.idPkUnit, p.PkUnitName, p.PriceBill, p.PriceWholesale, " & _
                               "p.PriceRetail, p.PerBox, t.idSeedKind,p.Amount From vPackingPdSet p " & _
                               "LEFT OUTER JOIN vSlPdTradeNameD t ON p.idPdT = t.idPdT WHERE p.stDel IS NULL AND p.idComp = " & sIdComp & " Order by p.PdPkName"
        sAdapter.Fill(sDt)
        sDt.Columns.Add("chkPdPk", System.Type.GetType("System.Boolean"))
        For i As Integer = 0 To sDt.Rows.Count - 1
            sDt.Rows(i).Item("chkPdPk") = False
        Next
        chk_Person()
        vPdPk = New DataView(sDt)
    End Sub

    Private Sub btnSearchPs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchPd.Click
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub txtPdName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPdName.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub txtLot_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub dgvPd_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPd.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvPd.Columns(e.ColumnIndex).Name = colSelect.Name Then
            idPdPk = CStr(dgvPd.Rows(e.RowIndex).Cells(idPd.Name).Value)

            If IsDBNull(dgvPd.Rows(e.RowIndex).Cells(colPdName.Name).Value) Then
                '--Nothing--'
            Else
                Me.PdPkName = CStr(dgvPd.Rows(e.RowIndex).Cells(colPdName.Name).Value)
            End If

            If IsDBNull(dgvPd.Rows(e.RowIndex).Cells(PdCode.Name).Value) Then
                '--Nothing--'
            Else
                Me.PdCodeS = CStr(dgvPd.Rows(e.RowIndex).Cells(PdCode.Name).Value)
            End If

            If IsDBNull(dgvPd.Rows(e.RowIndex).Cells(ColuShortName.Name).Value) Then
                '--Nothing--'
            Else
                Me.ShortName = CStr(dgvPd.Rows(e.RowIndex).Cells(ColuShortName.Name).Value)
            End If
            Me.pidPdPkLot = dgvPd.Rows(e.RowIndex).Cells(idPdPkLot.Name).Value
            Me.PdPkLotNo = dgvPd.Rows(e.RowIndex).Cells(ColLotNum.Name).Value
            Me.Weight = CDbl(dgvPd.Rows(e.RowIndex).Cells(WeightPd.Name).Value)
            Me.Unit = CStr(dgvPd.Rows(e.RowIndex).Cells(UnitW.Name).Value)
            Me.idUnit = CStr(dgvPd.Rows(e.RowIndex).Cells(colidUnitW.Name).Value)
            Me.idPkUnit = CStr(dgvPd.Rows(e.RowIndex).Cells(colidPkUnit.Name).Value)
            Me.PkUnitName = CStr(dgvPd.Rows(e.RowIndex).Cells(ColPkUnitName.Name).Value)
            If IsDBNull(dgvPd.Rows(e.RowIndex).Cells(ColPerBox.Name).Value) Then
                '---nothing---'
            Else
                Me.PerBox = CInt(dgvPd.Rows(e.RowIndex).Cells(ColPerBox.Name).Value)
            End If
            Me.PriceBill = CDbl(dgvPd.Rows(e.RowIndex).Cells(ColPriceBill.Name).Value)
            Me.PriveWh = CDbl(dgvPd.Rows(e.RowIndex).Cells(ColPriceWholesale.Name).Value)
            Me.PriceRetail = CDbl(dgvPd.Rows(e.RowIndex).Cells(ColPriceRetail.Name).Value)
            If Not IsDBNull(dgvPd.Rows(e.RowIndex).Cells(ColBarcode.Name).Value) Then
                Me.Barcode = CStr(dgvPd.Rows(e.RowIndex).Cells(ColBarcode.Name).Value)
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub ChkPd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPd.CheckedChanged
        If Me.ChkPd.Checked = True Then
            Me.txtPdName.Enabled = True
            Me.txtPdName.Focus()
        Else
            Me.txtPdName.Enabled = False
        End If
    End Sub

    Private Sub ChkWeight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkWeight.CheckedChanged
        If Me.ChkWeight.Checked = True Then
            Me.cmbWeight.Enabled = True
            Me.CmbUnitW.Enabled = True
            Me.cmbWeight.Focus()
        Else
            Me.cmbWeight.Enabled = False
            Me.CmbUnitW.Enabled = False
        End If
    End Sub

    Private Sub chk_Person()
        If dPdPk.Rows.Count > 0 Then
            For i As Integer = 0 To dPdPk.Rows.Count - 1
                For j As Integer = 0 To sDt.Rows.Count - 1
                    If dPdPk.Rows(i).Cells("colidPdPk").Value = sDt.Rows(j).Item("idPdPk") Then
                        sDt.Rows(j).Item("chkPdPk") = True
                        'Else
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub PsChang()
        For i As Integer = 0 To dgvPd.Rows.Count - 1
            'Dim a As Boolean = DGV_Menu.Rows(i).Cells(col_select.Name).Value
            For j As Integer = 0 To sDt.Rows.Count - 1
                If dgvPd.Rows(i).Cells(idPd.Name).Value = sDt.Rows(j).Item("idPdPk") Then
                    If dgvPd.Rows(i).Cells(col_sel2.Name).Value = True Then
                        sDt.Rows(j).Item("chkPdPk") = dgvPd.Rows(i).Cells(col_sel2.Name).Value
                    Else
                        sDt.Rows(j).Item("chkPdPk") = False
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        PsChang()
        Dim checkS As Boolean = False
        For i As Integer = 0 To sDt.Rows.Count - 1
            If sDt.Rows(i).Item("chkPdPk") = True Then
                checkS = True
                strPdPk += sDt.Rows(i).Item("idPdPk") & ","
            End If
        Next
        If checkS = False Then
            MessageBox.Show("ยังไม่ได้เลือกบุคคล")
            Exit Sub
        End If
        strPdPk = (Microsoft.VisualBasic.Left(strPdPk, strPdPk.Length - 1))
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    'Private Sub dgvPd_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPd.CellEnter
    '    If sender.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly Then
    '        If lastIndexColCell > e.ColumnIndex Then
    '            SendKeys.Send("+{TAB}")
    '        Else
    '            SendKeys.Send("{TAB}")
    '        End If
    '    End If
    '    lastIndexColCell = e.ColumnIndex
    'End Sub

    Private Sub dgvPd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvPd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If dgvPd.CurrentCell.RowIndex < 0 Then
                Exit Sub
            End If

            If dgvPd.Columns(dgvPd.CurrentCell.ColumnIndex).Name = colSelect.Name Then
                idPdPk = CStr(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(idPd.Name).Value)

                If Not IsDBNull(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(colPdName.Name).Value) Then
                    Me.PdPkName = CStr(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(colPdName.Name).Value)
                End If

                If Not IsDBNull(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(PdCode.Name).Value) Then
                    Me.PdCodeS = CStr(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(PdCode.Name).Value)
                End If

                If Not IsDBNull(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColuShortName.Name).Value) Then
                    Me.ShortName = CStr(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColuShortName.Name).Value)
                End If

                Me.Weight = CDbl(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(WeightPd.Name).Value)
                Me.Unit = CStr(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(UnitW.Name).Value)
                Me.idUnit = CStr(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(colidUnitW.Name).Value)
                Me.idPkUnit = CStr(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(colidPkUnit.Name).Value)
                Me.PkUnitName = CStr(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColPkUnitName.Name).Value)
                If IsDBNull(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColPerBox.Name).Value) Then
                    '---nothing---'
                Else
                    Me.PerBox = CInt(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColPerBox.Name).Value)
                End If
                Me.PriceBill = CDbl(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColPriceBill.Name).Value)
                Me.PriveWh = CDbl(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColPriceWholesale.Name).Value)
                Me.PriceRetail = CDbl(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColPriceRetail.Name).Value)
                If Not IsDBNull(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColBarcode.Name).Value) Then
                    Me.Barcode = CStr(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColBarcode.Name).Value)
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End If
    End Sub

    Private Sub ChkLot_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLot.CheckedChanged
        If Me.ChkLot.Checked = True Then
            Me.txtLot.Enabled = True
            Me.txtLot.Focus()
        Else
            Me.txtLot.Enabled = False
        End If
    End Sub

   
End Class