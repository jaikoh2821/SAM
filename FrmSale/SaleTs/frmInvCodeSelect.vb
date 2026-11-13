Public Class frmInvCodeSelect
    Enum eProcess
        eSelect
    End Enum

    Dim Process As eProcess
    Dim gInvCode As String = ""
    Dim gidComp As Integer = 0
    Public dtInvCode As New DataTable
    Sub New(ByVal aProcess As eProcess, ByVal InvCode As String)
        InitializeComponent()

        gInvCode = InvCode
        Process = aProcess
    End Sub

    Private Sub BindData()
        mdCnOpen()
        Dim dt As New DataTable
        sCommand.CommandText = "SELECT InvCode, idInvMain, InvName, unit.UnitName, unit.idUnit, inv.idInvGroup, inv.idSubType, g.DtType, fg.ShortName," & vbNewLine & _
                                "ISNULL(fg.PriceBill,0) As PriceBill_fg, ISNULL(fg.PriceWholesale,0) As PriceWholesale_fg, IsNULL(fg.PriceRetail,0) As PriceRetail_fg, " & vbNewLine & _
                                "IsNULL(pdo.Price,0) As PricePdo_pdo, IsNULL(pdo.CreditThirty,0) As CreditThirty_pdo, IsNULL(pdo.CreditSixty,0) As CreditSixty_pdo , IsNULL(sfg.Price,0) As PriceSeedFg_fg " & vbNewLine & _
                                "FROM dInventoryMain inv " & vbNewLine & _
                                "LEFT JOIN dInvGroup g ON inv.idInvGroup = g.idInvGroup" & vbNewLine & _
                                "LEFT JOIN dInvUnit unit ON inv.idUnit = unit.idUnit" & vbNewLine & _
                                "LEFT JOIN dPackingPdSet fg ON inv.idSubType = fg.idPdPk AND inv.idInvGroup = 2" & vbNewLine & _
                                "LEFT JOIN SmPdOtherD pdo On inv.idSubType = pdo.idPdo AND g.stpdOther = 1" & vbNewLine & _
                                "LEFT JOIN dSeedFlPackage sfg ON inv.idSubType = sfg.idFlPk AND inv.idInvgroup = 42" & vbNewLine & _
                                "Where InvCode Like '%" & gInvCode & "%'"
        sAdapter.Fill(dt)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูลรหัสสินค้า " & gInvCode & vbNewLine & "กรุณาตรวจสอบข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            GCInvCode.DataSource = dt
            txtCount.Text = Format(GVInvCode.DataRowCount, "#,##0")
        End If

    End Sub

    Private Sub initDataTable(sender As Object)
        sender.Columns.Add("InvCode", System.Type.GetType("System.String"))
        sender.Columns.Add("idInvMain", System.Type.GetType("System.Int64"))
        sender.Columns.Add("InvName", System.Type.GetType("System.String"))
        sender.Columns.Add("idInvGroup", System.Type.GetType("System.Int32"))
        sender.Columns.Add("UnitName", System.Type.GetType("System.String"))
        sender.Columns.Add("idUnit", System.Type.GetType("System.Int32"))
        sender.Columns.Add("idSubType", System.Type.GetType("System.Int32"))
        sender.Columns.Add("ShortName", System.Type.GetType("System.String"))
        sender.Columns.Add("PriceBill_fg", System.Type.GetType("System.Double"))
        sender.Columns.Add("PriceWholesale_fg", System.Type.GetType("System.Double"))
        sender.Columns.Add("PriceRetail_fg", System.Type.GetType("System.Double"))
        sender.Columns.Add("PricePdo_pdo", System.Type.GetType("System.Double"))
        sender.Columns.Add("CreditThirty_pdo", System.Type.GetType("System.Double"))
        sender.Columns.Add("CreditSixty_pdo", System.Type.GetType("System.Double"))
        sender.Columns.Add("PriceSeedFg_sfg", System.Type.GetType("System.Double"))
        sender.Columns.Add("DtType", System.Type.GetType("System.Int32"))
    End Sub

    Private Sub frmInvCodeSelect_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtInvCode.Focus()
        SendKeys.SendWait("{right}")

    End Sub

    Private Sub frmInvCodeSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Process = eProcess.eSelect Then
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If

        txtInvCode.Text = gInvCode

        initDataTable(dtInvCode)
    End Sub

    Private Sub txtInvName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInvCode.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub GCInvCode_KeyDown(sender As Object, e As KeyEventArgs) Handles GCInvCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dr As DataRow = GVInvCode.GetDataRow(GVInvCode.FocusedRowHandle)
            Dim dr_ As DataRow = dtInvCode.NewRow

            dr_("idInvMain") = dr("idInvMain")
            dr_("InvName") = dr("InvName")
            dr_("InvCode") = dr("InvCode")
            dr_("DtType") = dr("DtType")
            dr_("idUnit") = dr("idUnit")
            dr_("UnitName") = dr("UnitName")
            dr_("idSubType") = dr("idSubType")
            dr_("idInvGroup") = dr("idInvGroup")
            dr_("PriceBill_fg") = dr("PriceBill_fg")
            dr_("PriceWholesale_fg") = dr("PriceWholesale_fg")
            dr_("PriceRetail_fg") = dr("PriceRetail_fg")
            dr_("PricePdo_pdo") = dr("PricePdo_pdo")
            dr_("CreditThirty_pdo") = dr("CreditThirty_pdo")
            dr_("CreditSixty_pdo") = dr("CreditSixty_pdo")
            dr_("PriceSeedFg_sfg") = dr("PriceSeedFg_fg")

            dtInvCode.Rows.Add(dr_)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub rptSelect_Click(sender As Object, e As EventArgs) Handles rptSelect.Click
        Dim dr As DataRow = GVInvCode.GetDataRow(GVInvCode.FocusedRowHandle)
        Dim dr_ As DataRow = dtInvCode.NewRow

        dr_("idInvMain") = dr("idInvMain")
        dr_("InvName") = dr("InvName")
        dr_("InvCode") = dr("InvCode")
        dr_("DtType") = dr("DtType")
        dr_("idUnit") = dr("idUnit")
        dr_("UnitName") = dr("UnitName")
        dr_("idSubType") = dr("idSubType")
        dr_("idInvGroup") = dr("idInvGroup")
        dr_("PriceBill_fg") = dr("PriceBill_fg")
        dr_("PriceWholesale_fg") = dr("PriceWholesale_fg")
        dr_("PriceRetail_fg") = dr("PriceRetail_fg")
        dr_("PricePdo_pdo") = dr("PricePdo_pdo")
        dr_("CreditThirty_pdo") = dr("CreditThirty_pdo")
        dr_("CreditSixty_pdo") = dr("CreditSixty_pdo")
        dr_("PriceSeedFg_sfg") = dr("PriceSeedFg_fg")
        dtInvCode.Rows.Add(dr_)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub txtInvName_TextChanged(sender As Object, e As EventArgs) Handles txtInvCode.TextChanged

        GVInvCode.ActiveFilterString = "[InvCode] Like '%" & Trim(txtInvCode.Text) & "%'"
        txtCount.Text = Format(GVInvCode.DataRowCount, "#,##0")
    End Sub
End Class