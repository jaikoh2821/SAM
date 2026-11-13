Public Class frmSlJuPdSelect
    Dim stPage As String = 0
    Dim eEvent As eProcess
    Dim idInvMain As Integer
    Dim InvName As String = ""
    Dim sDtCopy As New DataTable
    Public getLotDt As New DataTable
    Dim idLotCut As New DataTable
    'Public idCus As Integer = 0
    'Public CusName As String = ""

    Enum eProcess
        eSelectPdAll
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal vidInvMain As Integer, ByVal vInvName As String, ByVal vidLotCut As DataTable)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eSelectPdAll
                stPage = 1
                idInvMain = vidInvMain
                InvName = vInvName
                idLotCut = vidLotCut
        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmSlJuPdSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getLotDt.Columns.Add("idLot", System.Type.GetType("System.Int64"))
        getLotDt.Columns.Add("LotNo", System.Type.GetType("System.String"))
        getLotDt.Columns.Add("Amount", System.Type.GetType("System.Double"))
        getLotDt.Columns.Add("idInvMain", System.Type.GetType("System.Int64"))
        getLotDt.Columns.Add("UnitName", System.Type.GetType("System.String"))
        getLotDt.Columns.Add("idUnit", System.Type.GetType("System.Int64"))
        getLotDt.Columns.Add("Price_fg", System.Type.GetType("System.Double"))
        getLotDt.Columns.Add("Price_Pdo", System.Type.GetType("System.Double"))
        getLotDt.Columns.Add("idWh", System.Type.GetType("System.Int64"))
        getLotDt.Columns.Add("idInvGroup", System.Type.GetType("System.Int64"))

        mdLoadShow()
        Me.lblPdName.Text = "สินค้า: " & InvName
        BindData()
        mdLoadCommitt()

        Me.txtLotno.Focus()
    End Sub

    Private Sub BindData()
        Dim vWhere As String = ""
        If Trim(Me.txtLotno.Text) <> "" Then
            'If dtType = 3 Then ' สินค้าวัตถุดิบ
            '    vWhere = vWhere & " AND LotCodeRef = '" & Trim(Me.txtLotno.Text) & "'"
            'Else
            vWhere = vWhere & " AND LotNo = '" & Trim(Me.txtLotno.Text) & "'"
            'End If
        End If

        If idLotCut.Rows.Count > 0 Then
            Dim vField As String = "lm.idLot"

            Dim stridCut As String = ""
            For i As Integer = 1 To idLotCut.Rows.Count - 1
                stridCut = stridCut & " AND (" & vField & " <> " & idLotCut.Rows(i).Item("idLot") & " or wh.idWh <> " & idLotCut.Rows(i).Item("idWh") & ")"
            Next

            vWhere = vWhere & " AND (" & vField & " <> " & idLotCut.Rows(0).Item("idLot") & " or wh.idWh <> " & idLotCut.Rows(0).Item("idWh") & ")" & stridCut
        End If


        Dim sDt As New DataTable
        mdCnOpen()
        sDt.Clear()

        sCommand.CommandText = "SELECT lm.idLot, lm.LotNo, wh.Amount, lm.DateGen, sw.WareHouseName, unit.UnitName, unit.idUnit, inv.idInvMain," & vbNewLine & _
                                "ISNULL(d.PriceBill,0) As Price_fg, ISNULL(o.Price,0) As Price_Pdo, wh.idWh, g.DtType, inv.idInvGroup" & vbNewLine & _
                                "FROM dInvLotRefWh wh" & vbNewLine & _
                                "LEFT JOIN dInvLotMain lm ON wh.idLot = lm.idLot" & vbNewLine & _
                                "LEFT JOIN SsWareHouse sw ON wh.idWh = sw.idWh" & vbNewLine & _
                                "LEFT JOIN dInvUnit unit ON wh.idUnit = unit.idUnit" & vbNewLine & _
                                "LEFT JOIN dInventoryMain inv ON lm.idInvMain = inv.idInvMain" & vbNewLine & _
                                "LEFT JOIN dInvGroup g ON inv.idInvGroup = g.idInvGroup" & vbNewLine & _
                                "LEFT JOIN dPackingPdSet As d ON inv.idSubType = d.idPdPk And inv.idInvGroup = 2" & vbNewLine & _
                                "LEFT JOIN SmPdOtherD As o ON inv.idSubType = o.idPdO AND g.stPdOther = 1" & vbNewLine & _
                                "WHERE lm.stDel Is NULL AND wh.Amount > 0 AND lm.idInvMain = " & idInvMain & vWhere

        sAdapter.Fill(sDt)
        sDt.Columns.Add("ChkKey", System.Type.GetType("System.Boolean"))

        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            GCProduct.DataSource = sDt
            Exit Sub
        Else
            For i As Integer = 0 To sDt.Rows.Count - 1
                sDt.Rows(i).Item("ChkKey") = False
            Next
            GCProduct.DataSource = sDt
        End If
        sDtCopy = sDt
    End Sub

    Private Sub btnSchPd_Click(sender As Object, e As EventArgs) Handles btnSchPd.Click
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub txtLotno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLotno.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        For i As Integer = 0 To sDtCopy.Rows.Count - 1
            If sDtCopy.Rows(i).Item("ChkKey") = True Then

                getLotDt.Rows.Add(sDtCopy.Rows(i).Item("idLot"), sDtCopy.Rows(i).Item("LotNo"), _
                                  sDtCopy.Rows(i).Item("Amount"), sDtCopy.Rows(i).Item("idInvMain"), sDtCopy.Rows(i).Item("UnitName"), _
                                  sDtCopy.Rows(i).Item("idUnit"), sDtCopy.Rows(i).Item("Price_fg"), sDtCopy.Rows(i).Item("Price_Pdo"), _
                                  sDtCopy.Rows(i).Item("idWh"), sDtCopy.Rows(i).Item("idInvGroup"))
            End If
        Next

        If getLotDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("กรุณาเลือกล็อตสินค้าอย่างน้อย 1 รายการ", sSystemName)
            Exit Sub
        Else

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub GVPd_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVPd.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub
End Class