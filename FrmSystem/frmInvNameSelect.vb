Public Class frmInvNameSelect
    Dim eEvent As eProcess
    Dim pidComp As Integer
    Dim stLoadS, stLoadH, stLoadP, stLoadF, stLoadE As Integer

    Public idInvMain, idUnit, idInvGroup As Integer
    Public InvName, UnitName As String
    Public PriceBill, PriceRetailn30, PriceWholesalen60 As Double

    Enum eProcess
        eSelect
        eMaltiSelect 'Not Code
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal xidComp As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eSelect
                Me.btnSelectAll_Fg.Visible = False
                Me.btnSelectAll_Mrl.Visible = False
                Me.btnSelectAll_Hmn.Visible = False
                Me.btnSelectAll_Ptc.Visible = False
                Me.btnSelectAll_Fsh.Visible = False
                Me.btnSelectAll_Etc.Visible = False
        End Select
        eEvent = aProcess
        pidComp = xidComp
    End Sub

    Private Sub frmInvNameSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindFGData()
        Me.txtPdName_Fg.Focus()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        Select Case Me.TabControl1.SelectedTabPageIndex
            Case 0 'FG
                Me.txtPdName_Fg.Focus()
            Case 1 'Seed
                If stLoadS <> 1 Then
                    BindSeedsData()
                End If
                Me.txtPdName_Sd.Focus()
            Case 2 'Hormone
                If stLoadH <> 1 Then
                    BindHormoneData()
                End If
                Me.txtPdName_Hm.Focus()
            Case 3 'Plastic
                If stLoadP <> 1 Then
                    BindPlasticData()
                End If
                Me.txtPdName_Pt.Focus()
            Case 4 'Fresh
                If stLoadF <> 1 Then
                    BindFreshData()
                End If
                Me.txtPdName_Fsh.Focus()
            Case 5 'Etc
                If stLoadE <> 1 Then
                    BindEtcData()
                End If
                Me.txtPdName_Etc.Focus()
        End Select
    End Sub

#Region "FG-TAB"

    Private Sub BindFGData()
        mdCnOpen()
        mdLoadShow()
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT CONVERT(bit,0) As ChkKey, inv.idInvMain, inv.InvName, pk.ShortName, pk.SeedName, pk.PriceBill, " & _
                               "pk.PriceRetail, pk.PriceWholesale, u.UnitName, inv.idUnit, pk.idPdPk, inv.idInvGroup " & _
                               "FROM dInventoryMain inv " & _
                               "LEFT JOIN vpackingPdSet_Select pk ON inv.idSubType = pk.idPdPk AND inv.idInvGroup = 2 " & _
                               "LEFT JOIN dInvUnit u On inv.idUnit = u.idUnit " & _
                               "LEFT JOIN PchInvAndProject.dbo.dCompany c ON pk.idComp = c.idComp " & _
                               "WHERE inv.idInvGroup = 2 And stActive Is NULL And pk.idComp = " & pidComp & " Order by inv.InvName"
        sAdapter.Fill(sDt)
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Exit Sub
        End If
        GC_FgPd.DataSource = sDt
        gv_FgPd.ExpandAllGroups()
        mdLoadCommitt()
    End Sub

    Private Sub txtPdName_Fg_TextChanged(sender As Object, e As EventArgs) Handles txtPdName_Fg.TextChanged
        FilterGrid_FG()
    End Sub

    Private Sub FilterGrid_FG()
        'Dim tx As String = txtPdName_Fg.Text
        'Dim tx_a As String() = tx.Split(" ")
        'Dim a_and As String = ""
        'Dim strInvName As String = ""
        'Dim strShortName As String = ""
        'If tx_a.Length > 0 Then
        '    For Each txt As String In tx_a
        '        If Not txt.Equals("") Then
        '            strInvName += a_and & "" & String.Format(" [InvName] like '%{0}%' ", txt)
        '            strShortName += a_and & "" & String.Format(" [ShortName] like '%{0}%' ", txt)
        '        End If
        '        a_and = " and "
        '    Next
        'End If

        gv_FgPd.ActiveFilterString = " [InvName] like '%" & Trim(txtPdName_Fg.Text) & "%' " & _
                                     "OR [ShortName] like '%" & Trim(txtPdName_Fg.Text) & "%'"
    End Sub

    'eMaltiSelect-FG : Not Code
    Private Sub btnSelectAll_Fg_Click(sender As Object, e As EventArgs) Handles btnSelectAll_Fg.Click

    End Sub

    'eSelect-FG
    Private Sub rptChkEdit_Click(sender As Object, e As EventArgs) Handles rptChkEdit.Click
        Dim dr As DataRow = gv_FgPd.GetDataRow(gv_FgPd.FocusedRowHandle)
        'Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GCPlastic.FocusedView
        'Dim dr_1 As DataRow = detailView.GetDataRow(detailView.FocusedRowHandle)
        idInvMain = dr.Item("idInvMain")
        InvName = dr.Item("InvName")
        UnitName = dr.Item("UnitName")
        idUnit = dr.Item("idUnit")
        PriceBill = dr.Item("PriceBill")
        PriceRetailn30 = dr.Item("PriceRetail")
        PriceWholesalen60 = dr.Item("PriceWholesale")
        idInvGroup = dr.Item("idInvGroup")

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region

#Region "Seeds-TAB"
    Private Sub BindSeedsData()
        mdCnOpen()
        mdLoadShow()
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT CONVERT(bit,0) As ChkKey, inv.idInvMain, inv.InvName, pd.SeedName, " & _
                                "u.UnitName, inv.idUnit, pd.idPd, inv.idInvGroup " & _
                                "FROM dInventoryMain inv " & _
                                "LEFT JOIN vSeedProduct pd ON inv.idSubType = pd.idPd AND inv.idInvGroup = 1 " & _
                                "LEFT JOIN dInvUnit u On inv.idUnit = u.idUnit " & _
                                "WHERE inv.idInvGroup = 1 And stActive Is NULL  Order by inv.InvName"
        sAdapter.Fill(sDt)
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Exit Sub
        End If
        GCMeterial.DataSource = sDt
        gvMeterial.ExpandAllGroups()
        stLoadS = 1
        mdLoadCommitt()
    End Sub

    Private Sub txtPdName_Sd_TextChanged(sender As Object, e As EventArgs) Handles txtPdName_Sd.TextChanged
        FilterGridxSeeds()
    End Sub

    Private Sub FilterGridxSeeds()
        gvMeterial.ActiveFilterString = " [InvName] like '%" & Trim(txtPdName_Sd.Text) & "%' " & _
                                     "OR [SeedName] like '%" & Trim(txtPdName_Sd.Text) & "%'"
    End Sub

    'eMaltiSelect-Seeds : Not Code
    Private Sub btnSelectAll_Mrl_Click(sender As Object, e As EventArgs) Handles btnSelectAll_Mrl.Click

    End Sub

    'eSelect-Seeds
    Private Sub rptChkMat_Click(sender As Object, e As EventArgs) Handles rptChkMat.Click
        Dim dr As DataRow = gvMeterial.GetDataRow(gvMeterial.FocusedRowHandle)

        idInvMain = dr.Item("idInvMain")
        InvName = dr.Item("InvName")
        UnitName = dr.Item("UnitName")
        idUnit = dr.Item("idUnit")
        'PriceBill = 0.0
        'PriceRetail = 0.0
        'PriceWholesale = 0.0
        idInvGroup = dr.Item("idInvGroup")

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region

#Region "Hormone-TAB"
    Private Sub BindHormoneData()
        mdCnOpen()
        mdLoadShow()
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT CONVERT(bit,0) As ChkKey, inv.idInvMain, inv.InvName, pd.PdoName, " & _
                                "u.UnitName, inv.idUnit, pd.Price, pd.idPdo, inv.idInvGroup " & _
                                "FROM dInventoryMain inv " & _
                                "LEFT JOIN SmPdOtherD pd ON inv.idSubType = pd.idPdo AND inv.idInvGroup = 28 " & _
                                "LEFT JOIN dInvUnit u On inv.idUnit = u.idUnit " & _
                                "WHERE inv.idInvGroup = 28 And stActive Is NULL  Order by inv.InvName"
        sAdapter.Fill(sDt)
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Exit Sub
        End If
        GCHormone.DataSource = sDt
        gvHormone.ExpandAllGroups()
        stLoadH = 1
        mdLoadCommitt()
    End Sub

    Private Sub txtPdName_Hm_TextChanged(sender As Object, e As EventArgs) Handles txtPdName_Hm.TextChanged
        FilterGridxHormone()
    End Sub

    Private Sub FilterGridxHormone()
        gvHormone.ActiveFilterString = " [InvName] like '%" & Trim(txtPdName_Hm.Text) & "%' "
    End Sub

    'eMaltiSelect-Hormone : Not Code
    Private Sub btnSelectAll_Hmn_Click(sender As Object, e As EventArgs) Handles btnSelectAll_Hmn.Click

    End Sub

    'eSelect-Hormone
    Private Sub rptCheckHme_Click(sender As Object, e As EventArgs) Handles rptCheckHme.Click
        Dim dr As DataRow = gvHormone.GetDataRow(gvHormone.FocusedRowHandle)

        idInvMain = dr.Item("idInvMain")
        InvName = dr.Item("InvName")
        UnitName = dr.Item("UnitName")
        idUnit = dr.Item("idUnit")
        PriceBill = dr.Item("Price")
        idInvGroup = dr.Item("idInvGroup")

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

#End Region

#Region "Plastic-TAB"
    Private Sub BindPlasticData()
        mdCnOpen()
        mdLoadShow()
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT CONVERT(bit,0) As ChkKey, inv.idInvMain, inv.InvName, pd.PdoName, " & _
                               "u.UnitName, inv.idUnit, pd.Price, pd.CreditThirty, pd.CreditSixty, pd.idPdo, inv.idInvGroup " & _
                               "FROM dInventoryMain inv " & _
                               "LEFT JOIN SmPdOtherD pd ON inv.idSubType = pd.idPdo AND inv.idInvGroup = 29 " & _
                               "LEFT JOIN dInvUnit u On inv.idUnit = u.idUnit " & _
                               "WHERE inv.idInvGroup = 29 And stActive Is NULL  Order by inv.InvName"
        sAdapter.Fill(sDt)
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Exit Sub
        End If
        GCPlastic.DataSource = sDt
        gvPlastic.ExpandAllGroups()
        stLoadP = 1
        mdLoadCommitt()
    End Sub

    Private Sub txtPdName_Pt_TextChanged(sender As Object, e As EventArgs) Handles txtPdName_Pt.TextChanged
        FilterGridxPlastic()
    End Sub

    Private Sub FilterGridxPlastic()
        gvPlastic.ActiveFilterString = " [InvName] like '%" & Trim(txtPdName_Pt.Text) & "%' "
    End Sub

    'eMaltiSelect-Plastic : Not Code
    Private Sub btnSelectAll_Ptc_Click(sender As Object, e As EventArgs) Handles btnSelectAll_Ptc.Click

    End Sub

    'eSelect-Plastic
    Private Sub rptCheckPtc_Click(sender As Object, e As EventArgs) Handles rptCheckPtc.Click
        Dim dr As DataRow = gvPlastic.GetDataRow(gvPlastic.FocusedRowHandle)

        idInvMain = dr.Item("idInvMain")
        InvName = dr.Item("InvName")
        UnitName = dr.Item("UnitName")
        idUnit = dr.Item("idUnit")
        PriceBill = dr.Item("Price")
        PriceRetailn30 = dr.Item("CreditThirty")
        PriceWholesalen60 = dr.Item("CreditSixty")
        idInvGroup = dr.Item("idInvGroup")

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region

#Region "Fresh-TAB"
    Private Sub BindFreshData()
        mdCnOpen()
        mdLoadShow()
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT CONVERT(bit,0) As ChkKey, inv.idInvMain, inv.InvName,u.UnitName, " & _
                                "inv.idUnit, pd.Price, pd.idPdo, inv.idInvGroup " & _
                                "FROM dInventoryMain inv " & _
                                "LEFT JOIN SmPdOtherD pd ON inv.idSubType = pd.idPdo AND inv.idInvGroup = 33 " & _
                                "LEFT JOIN dInvUnit u On inv.idUnit = u.idUnit " & _
                                "WHERE inv.idInvGroup = 33 And stActive Is NULL  Order by inv.InvName"
        sAdapter.Fill(sDt)
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Exit Sub
        End If
        GCFresh.DataSource = sDt
        gvFresh.ExpandAllGroups()
        stLoadF = 1
        mdLoadCommitt()
    End Sub

    Private Sub txtPdName_Fsh_TextChanged(sender As Object, e As EventArgs) Handles txtPdName_Fsh.TextChanged
        FilterGridxFresh()
    End Sub

    Private Sub FilterGridxFresh()
        gvFresh.ActiveFilterString = " [InvName] like '%" & Trim(txtPdName_Fsh.Text) & "%' "
    End Sub

    'eMaltiSelect-Fresh : Not Code
    Private Sub btnSelectAll_Fsh_Click(sender As Object, e As EventArgs) Handles btnSelectAll_Fsh.Click

    End Sub

    'eSelect-Fresh
    Private Sub rptCheckFsh_Click(sender As Object, e As EventArgs) Handles rptCheckFsh.Click
        Dim dr As DataRow = gvFresh.GetDataRow(gvFresh.FocusedRowHandle)

        idInvMain = dr.Item("idInvMain")
        InvName = dr.Item("InvName")
        UnitName = dr.Item("UnitName")
        idUnit = dr.Item("idUnit")
        PriceBill = dr.Item("Price")
        idInvGroup = dr.Item("idInvGroup")

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region

#Region "ETC-TAB"
    Private Sub BindEtcData()
        mdCnOpen()
        mdLoadShow()
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT CONVERT(bit,0) As ChkKey, inv.idInvMain, inv.InvName,u.UnitName, " & _
                              "inv.idUnit, pd.Price, pd.idPdo, inv.idInvGroup " & _
                              "FROM dInventoryMain inv " & _
                              "LEFT JOIN SmPdOtherD pd ON inv.idSubType = pd.idPdo AND inv.idInvGroup = 3 " & _
                              "LEFT JOIN dInvUnit u On inv.idUnit = u.idUnit " & _
                              "WHERE inv.idInvGroup = 3 And stActive Is NULL  Order by inv.InvName"
        sAdapter.Fill(sDt)
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Exit Sub
        End If
        GCEtc.DataSource = sDt
        gvEtc.ExpandAllGroups()
        stLoadE = 1
        mdLoadCommitt()
    End Sub

    Private Sub txtPdName_Etc_TextChanged(sender As Object, e As EventArgs) Handles txtPdName_Etc.TextChanged
        FilterGridxEtc()
    End Sub

    Private Sub FilterGridxEtc()
        gvEtc.ActiveFilterString = " [InvName] like '%" & Trim(txtPdName_Etc.Text) & "%' "
    End Sub

    'eMaltiSelect-Etc : Not Code

    Private Sub btnSelectAll_Etc_Click(sender As Object, e As EventArgs) Handles btnSelectAll_Etc.Click

    End Sub

    'eSelect-Fresh
    Private Sub rptCheckEtc_Click(sender As Object, e As EventArgs) Handles rptCheckEtc.Click
        Dim dr As DataRow = gvEtc.GetDataRow(gvEtc.FocusedRowHandle)

        idInvMain = dr.Item("idInvMain")
        InvName = dr.Item("InvName")
        UnitName = dr.Item("UnitName")
        idUnit = dr.Item("idUnit")
        PriceBill = dr.Item("Price")
        idInvGroup = dr.Item("idInvGroup")

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region











End Class