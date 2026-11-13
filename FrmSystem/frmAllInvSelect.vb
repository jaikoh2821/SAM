Imports DevExpress.XtraSplashScreen

Public Class frmAllInvSelect
    Public sdt1 As New DataTable
    Private process As eProcess
    Dim xidComp_ As Integer
    Dim sDtInv As New DataTable
    Dim xInvName As String
    Enum eProcess
        eAll
        eMaltiSelect
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal xidComp As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Select Case aProcess
            Case eProcess.eAll
                ColSelectMalti.Visible = False
            Case eProcess.eMaltiSelect
                col_select.Visible = False
                btnMalti.Visible = True
        End Select

        xidComp_ = xidComp
        process = aProcess

        initDataTable(sdt1)
        'initDataTabla(sdt2)
        'idCompWhere = idCompGet
    End Sub

    Public Sub GetInvName(ByVal InvName As String)
        xInvName = InvName
    End Sub

    Private Sub frmAllInvSelect_Load(sender As Object, e As EventArgs) Handles Me.Load
        mdCnOpen()
        mdLoadShow()
        LoadPkType()
        SetDefaultInvGroup()
        ShowDataOnGrid()
        mdLoadCommitt()
    End Sub

    Private Sub frmPackingMaterialSelect_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtInvName.Text = xInvName
        txtInvName.Focus()
    End Sub

    Private Sub SetDefaultInvGroup()
        Select Case xidComp_
            Case 4, 5, 10, 13, 58
                cmbInvName.SelectedValue = 2 'FG
            Case 12
                cmbInvName.SelectedValue = 28 'ฮอร์โมน
            Case 55, 60
                cmbInvName.SelectedValue = 29 'พลาสติก
            Case 2, 3
                cmbInvName.SelectedValue = 1 ' เมล็ดพันธ์วัตถุดิบ
            Case 7, 11, 59, 63, 64
                cmbInvName.SelectedValue = 3 'เบ็ดเตล็ด
            Case 7
                cmbInvName.SelectedValue = 36 'ปุ๋ย
            Case 54
                cmbInvName.SelectedValue = 33 'ผลสด
            Case 8
                cmbInvName.SelectedValue = 40 'โสหุ้ย
            Case Else
                cmbInvName.SelectedValue = 3 'เบ็ดเตล็ด
        End Select
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        mdCnOpen()
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        ShowDataOnGrid()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub LoadPkType()
        Dim d_PkType As New DataTable
        sCommand.CommandText = "SELECT idInvGroup, InvGroupName " & _
                               "FROM dInvGroup WHERE stDel IS NULL Order by InvGroupName"
        sAdapter.Fill(d_PkType)
        cmbInvName.DisplayMember = "InvGroupName"
        cmbInvName.ValueMember = "idInvGroup"
        cmbInvName.DataSource = d_PkType
    End Sub

    Private Sub ShowDataOnGrid()
        Dim vWhere As String = "WHERE main.stActive Is NULL " & vbNewLine &
                               "AND main.stNotSale Is NULL"

        mdCnOpen()
        sCommand.CommandText = "SELECT CONVERT(bit,0) As ChkKey, gr.DtType, IsNULL(main.InvCode, '') As InvCode, main.idInvMain, main.InvName, main.idInvGroup, gr.InvGroupName," & vbNewLine &
                              "unit.UnitName, main.idUnit, main.idSubType, fg.ShortName, ISNULL(fg.Perbox, 0) As Perbox, " & vbNewLine &
                              "ISNULL(fg.PriceBill,0) As PriceBill_fg, ISNULL(fg.PriceWholesale,0 ) As PriceWholesale_fg, ISNULL(fg.PriceRetail,0) As PriceRetail_fg," & vbNewLine &
                              "ISNULL(pdo.CreditThirty,0) As CreditThirty_pdo, ISNULL(pdo.CreditSixty,0) As CreditSixty_pdo, " & vbNewLine & _
                               "IsNULL(pdo.Price,0) As PricePdo_pdo, IsNULL(sfg.Price,0) As PriceSeedFg_sfg, ISNULL(d.Price,0) As PriceSeed " & vbNewLine &
                               "FROM dInventoryMain As main" & vbNewLine &
                               "LEFT JOIN dInvUnit As unit ON main.idUnit = unit.idUnit " & vbNewLine &
                               "LEFT JOIN dInvGroup As gr ON main.idInvGroup = gr.idInvGroup" & vbNewLine &
                               "LEFT JOIN dPackingPdSet fg ON main.idSubType = fg.idPdPk AND main.idInvGroup = 2" & vbNewLine &
                               "LEFT JOIN SmPdOtherD pdo On main.idSubType = pdo.idPdo AND gr.stpdOther = 1" & vbNewLine &
                               "LEFT JOIN dSeedFlPackage sfg ON main.idSubType = sfg.idFlPk AND main.idInvgroup = 42" & vbNewLine &
                               "LEFT JOIN dSeedProductPrice d ON main.idInvMain = d.idInvMain AND main.idInvGroup = 1 AND d.idComp = " & xidComp_ & vbNewLine &
                               vWhere

        'sCommand.CommandText = "SELECT CONVERT(bit,0) As ChkKey, gr.DtType, IsNULL(main.InvCode, '') As InvCode, main.idInvMain, main.InvName, main.idInvGroup, gr.InvGroupName," & vbNewLine &
        '                       "unit.UnitName, main.idUnit, main.idSubType, fg.ShortName," & vbNewLine &
        '                       "fg.PriceBill, fg.PriceWholesale, fg.PriceRetail," & vbNewLine &
        '                       "pdo.Price As PricePdo, pdo.CreditThirty, pdo.CreditSixty, sfg.Price As PriceSeedFg," & vbNewLine &
        '                        "(SELECT ISNull(SUM(Amount), 0.0)" & vbNewLine &
        '                            "FROM dInvLotMain As d" & vbNewLine &
        '                            "LEFT JOIN dInvLotRefWh As w ON d.idLot = w.idLot" & vbNewLine &
        '                            "WHERE d.idInvMain = main.idInvMain AND stDel Is NULL AND d.CompRec = " & xidComp_ & ") As amount" & vbNewLine &
        '                        "FROM dInventoryMain As main" & vbNewLine &
        '                        "LEFT JOIN dInvUnit As unit ON main.idUnit = unit.idUnit " & vbNewLine &
        '                        "LEFT JOIN dInvGroup As gr ON main.idInvGroup = gr.idInvGroup" & vbNewLine &
        '                        "LEFT JOIN dPackingPdSet fg ON main.idSubType = fg.idPdPk AND main.idInvGroup = 2" & vbNewLine &
        '                        "LEFT JOIN SmPdOtherD pdo On main.idSubType = pdo.idPdo AND gr.stpdOther = 1" & vbNewLine &
        '                        "LEFT JOIN dSeedFlPackage sfg ON main.idSubType = sfg.idFlPk AND main.idInvgroup = 42" & vbNewLine &
        '                        vWhere
        sAdapter.Fill(sDtInv)
        gc2.DataSource = sDtInv
        gv2.ExpandAllGroups()

        If sDtInv.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        txtCount.Text = Format(gv2.DataRowCount, "#,##0")
    End Sub

    Private Sub initDataTable(sender As Object)
        sender.Columns.Add("idInvMain", System.Type.GetType("System.Int64"))
        sender.Columns.Add("InvName", System.Type.GetType("System.String"))
        sender.Columns.Add("idInvGroup", System.Type.GetType("System.Int32"))
        sender.Columns.Add("UnitName", System.Type.GetType("System.String"))
        sender.Columns.Add("idUnit", System.Type.GetType("System.Int32"))
        sender.Columns.Add("idSubType", System.Type.GetType("System.Int32"))
        sender.Columns.Add("ShortName", System.Type.GetType("System.String"))
        sender.Columns.Add("amount", System.Type.GetType("System.Double"))
        sender.Columns.Add("PriceBill_fg", System.Type.GetType("System.Double"))
        sender.Columns.Add("PriceWholesale_fg", System.Type.GetType("System.Double"))
        sender.Columns.Add("PriceRetail_fg", System.Type.GetType("System.Double"))
        sender.Columns.Add("PricePdo_pdo", System.Type.GetType("System.Double"))
        sender.Columns.Add("CreditThirty_pdo", System.Type.GetType("System.Double"))
        sender.Columns.Add("CreditSixty_pdo", System.Type.GetType("System.Double"))
        sender.Columns.Add("PriceSeedFg_sfg", System.Type.GetType("System.Double"))
        sender.Columns.Add("PriceSeed", System.Type.GetType("System.Double"))
        sender.Columns.Add("InvCode", System.Type.GetType("System.String"))
        sender.Columns.Add("DtType", System.Type.GetType("System.Int32"))
        sender.Columns.Add("Perbox", System.Type.GetType("System.Int32"))
    End Sub

    Private Sub ChkType_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInvGroup.CheckedChanged
        If ChkInvGroup.Checked = False Then
            cmbInvName.Enabled = False
        Else
            cmbInvName.Enabled = True
        End If
        FilterDataOnGrid()
    End Sub

    Private Sub ChkName_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInvName.CheckedChanged
        If ChkInvName.Checked = False Then
            txtInvName.Enabled = False
            txtInvName.Text = ""
        Else
            txtInvName.Enabled = True
            txtInvName.Focus()
        End If

        ' FilterDataOnGrid()
    End Sub

    Private Sub FilterDataOnGrid()
        Dim StrFilter = " 1=1 "

        If ChkInvGroup.Checked = True Then
            StrFilter &= " AND [idInvGroup] = " & cmbInvName.SelectedValue
        End If

        Dim tx As String = txtInvName.Text
        Dim tx_a As String() = tx.Split(" ")
        Dim a_and As String = ""
        Dim strPdPk As String = ""
        If tx_a.Length > 0 Then
            For Each txt As String In tx_a
                If Not txt.Equals("") Then
                    strPdPk += a_and & "" & String.Format(" [InvName] Like '%{0}%' ", txt)
                End If
                a_and = " and "
            Next
        End If

        If ChkInvName.Checked = True And strPdPk <> "" Then
            StrFilter &= " AND " & strPdPk
        End If


        Dim tx2 As String = txtInvName.Text
        Dim tx_a2 As String() = tx2.Split(" ")
        Dim a_and2 As String = ""
        Dim strPdPk2 As String = ""
        If tx_a2.Length > 0 Then
            For Each txt2 As String In tx_a2
                If Not txt2.Equals("") Then
                    strPdPk2 += a_and2 & "" & String.Format(" [ShortName] Like '%{0}%' ", txt2)
                End If
                a_and2 = " OR "
            Next
        End If

        If ChkInvName.Checked = True And strPdPk2 <> "" Then
            StrFilter &= " OR " & strPdPk2
        End If


        gv2.ActiveFilterString = StrFilter
        gv2.ExpandAllGroups()
        txtCount.Text = Format(gv2.DataRowCount, "#,##0")
    End Sub

    Private Sub cmbInvName_TextChanged(sender As Object, e As EventArgs) Handles cmbInvName.TextChanged
        FilterDataOnGrid()
    End Sub

    Private Sub txtInvName_TextChanged(sender As Object, e As EventArgs) Handles txtInvName.TextChanged
        FilterDataOnGrid()
    End Sub

    'Private Sub Gv_PayMt_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gv2.RowCellStyle
    '    Select Case process
    '        Case eProcess.eAll
    '            If e.Column.Name = ColInvName.Name Or e.Column.Name = colShortName.Name Or e.Column.Name = ColInvGroupName.Name Or e.Column.Name = col_amount.Name Or e.Column.Name = col_unitName.Name Then
    '                e.Appearance.ForeColor = System.Drawing.Color.Black
    '            End If
    '    End Select

    'End Sub

    Private Sub cbType_CheckedChanged(sender As Object, e As EventArgs) Handles cbType.CheckedChanged
        If cbType.Checked = True Then
            ColInvGroupName.GroupIndex = 0
            gv2.CollapseAllGroups()
        Else
            ColInvGroupName.GroupIndex = -1
            gv2.ExpandAllGroups()
        End If
    End Sub

    Private Sub btnMalti_Click(sender As Object, e As EventArgs) Handles btnMalti.Click
        Dim dv As New DataView(sDtInv)
        dv.RowFilter = "ChkKey=True"
        For i As Integer = 0 To dv.Count - 1
            Dim dr_ As DataRow = sdt1.NewRow

            dr_("idInvMain") = dv.Item(i).Item("idInvMain")
            dr_("InvName") = dv.Item(i).Item("InvName")
            dr_("idInvGroup") = dv.Item(i).Item("idInvGroup")
            dr_("UnitName") = dv.Item(i).Item("UnitName")
            dr_("idUnit") = dv.Item(i).Item("idUnit")
            dr_("idSubType") = dv.Item(i).Item("idSubType")
            dr_("ShortName") = dv.Item(i).Item("ShortName")
            'dr_("amount") = dv.Item(i).Item("amount")
            dr_("amount") = 0
            dr_("PriceBill_fg") = dv.Item(i).Item("PriceBill_fg")
            dr_("PriceWholesale_fg") = dv.Item(i).Item("PriceWholesale_fg")
            dr_("PriceRetail_fg") = dv.Item(i).Item("PriceRetail_fg")
            dr_("PricePdo_pdo") = dv.Item(i).Item("PricePdo_pdo")
            dr_("CreditThirty_pdo") = dv.Item(i).Item("CreditThirty_pdo")
            dr_("CreditSixty_pdo") = dv.Item(i).Item("CreditSixty_pdo")
            dr_("PriceSeedFg_sfg") = dv.Item(i).Item("PriceSeedFg_sfg")
            dr_("PriceSeed") = dv.Item(i).Item("PriceSeed")
            dr_("DtType") = dv.Item(i).Item("DtType")
            dr_("Perbox") = dv.Item(i).Item("Perbox")
            sdt1.Rows.Add(dr_)

        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        Dim dr As DataRow = gv2.GetDataRow(gv2.FocusedRowHandle)
        Dim dr_ As DataRow = sdt1.NewRow

        dr_("idInvMain") = dr("idInvMain")
        dr_("InvName") = dr("InvName")
        dr_("idInvGroup") = dr("idInvGroup")
        dr_("UnitName") = dr("UnitName")
        dr_("idUnit") = dr("idUnit")
        dr_("idSubType") = dr("idSubType")
        dr_("ShortName") = dr("ShortName")
        dr_("amount") = 0
        dr_("PriceBill_fg") = dr("PriceBill_fg")
        dr_("PriceWholesale_fg") = dr("PriceWholesale_fg")
        dr_("PriceRetail_fg") = dr("PriceRetail_fg")
        dr_("PricePdo_pdo") = dr("PricePdo_pdo")
        dr_("CreditThirty_pdo") = dr("CreditThirty_pdo")
        dr_("CreditSixty_pdo") = dr("CreditSixty_pdo")
        dr_("PriceSeedFg_sfg") = dr("PriceSeedFg_sfg")
        dr_("PriceSeed") = dr("PriceSeed")
        dr_("InvCode") = dr("InvCode")
        dr_("DtType") = dr("DtType")
        dr_("Perbox") = dr("Perbox")
        sdt1.Rows.Add(dr_)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub gv2_KeyDown(sender As Object, e As KeyEventArgs) Handles gv2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dr As DataRow = gv2.GetDataRow(gv2.FocusedRowHandle)
            Dim dr_ As DataRow = sdt1.NewRow

            dr_("idInvMain") = dr("idInvMain")
            dr_("InvName") = dr("InvName")
            dr_("idInvGroup") = dr("idInvGroup")
            dr_("UnitName") = dr("UnitName")
            dr_("idUnit") = dr("idUnit")
            dr_("idSubType") = dr("idSubType")
            dr_("ShortName") = dr("ShortName")
            dr_("amount") = 0
            dr_("PriceBill_fg") = dr("PriceBill_fg")
            dr_("PriceWholesale_fg") = dr("PriceWholesale_fg")
            dr_("PriceRetail_fg") = dr("PriceRetail_fg")
            dr_("PricePdo_pdo") = dr("PricePdo_pdo")
            dr_("CreditThirty_pdo") = dr("CreditThirty_pdo")
            dr_("CreditSixty_pdo") = dr("CreditSixty_pdo")
            dr_("PriceSeedFg_sfg") = dr("PriceSeedFg_sfg")
            dr_("PriceSeed") = dr("PriceSeed")
            dr_("InvCode") = dr("InvCode")
            dr_("DtType") = dr("DtType")
            dr_("Perbox") = dr("Perbox")
            sdt1.Rows.Add(dr_)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class