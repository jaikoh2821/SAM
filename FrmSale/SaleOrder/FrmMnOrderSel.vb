Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Helpers.GridStateHelper
Imports System.Collections.Generic ' ตัวนี้สำคัญมากเพื่อให้ใช้ List(Of T) ได้
Imports System.Linq ' เผื่อใช้สำหรับจัดการข้อมูลชุด

Public Class FrmMnOrderSel
    Enum eProcess
        eSelOrder
    End Enum

    Public MainReturn As New DataTable
    Dim xProcess As eProcess
    Dim gidComp As Integer = 0
    Dim gidPartner As Integer = 0
    Dim gPartNerName As String = ""
    Dim xstridOrderDt As String = ""
    Dim stLoad As Integer = 0
    Dim dtOrderDtSel As New DataTable

    Dim dtOrderMain As New DataTable
    Dim dtOrderLot As New DataTable
    Dim ds_Right As New DataSet

    Dim ds_Left As New DataSet
    Sub New(ByVal aProcess As eProcess, ByVal idComp As Integer, ByVal idPartner As Integer, ByVal PartNerName As String, ByVal stridOrderDt As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        xProcess = aProcess
        gidComp = idComp
        gidPartner = idPartner
        gPartNerName = PartNerName
        xstridOrderDt = stridOrderDt
    End Sub

    Sub BuildColumns()
        dtOrderMain.Columns.Add("idSaleOrder", System.Type.GetType("System.Int32"))
        dtOrderMain.Columns.Add("idSaleOrderDt", System.Type.GetType("System.Int32"))
        dtOrderMain.Columns.Add("PdCode", System.Type.GetType("System.String"))
        dtOrderMain.Columns.Add("DocCode", System.Type.GetType("System.String"))
        dtOrderMain.Columns.Add("DocRef", System.Type.GetType("System.String"))
        dtOrderMain.Columns.Add("idInvGroup", System.Type.GetType("System.Int32"))
        dtOrderMain.Columns.Add("idInvMain", System.Type.GetType("System.Int32"))
        dtOrderMain.Columns.Add("DtType", System.Type.GetType("System.Int32"))
        dtOrderMain.Columns.Add("InvName", System.Type.GetType("System.String"))
        dtOrderMain.Columns.Add("AmtOrder", System.Type.GetType("System.Double"))
        dtOrderMain.Columns.Add("AmtSale", System.Type.GetType("System.Double"))
        dtOrderMain.Columns.Add("UnitName", System.Type.GetType("System.String"))
        dtOrderMain.Columns.Add("idUnit", System.Type.GetType("System.Int32"))
        dtOrderMain.Columns.Add("DateTsD", System.Type.GetType("System.DateTime"))
        dtOrderMain.Columns.Add("TimeTs", System.Type.GetType("System.String"))
        dtOrderMain.Columns.Add("NoteOrder", System.Type.GetType("System.String"))
        dtOrderMain.Columns.Add("PsSale", System.Type.GetType("System.String"))
        dtOrderMain.Columns.Add("idSubType", System.Type.GetType("System.Int32"))

        dtOrderMain.Columns.Add("PriceWholesale_fg", System.Type.GetType("System.Double"))
        dtOrderMain.Columns.Add("PriceRetail_fg", System.Type.GetType("System.Double"))
        dtOrderMain.Columns.Add("PriceBill_fg", System.Type.GetType("System.Double"))
        dtOrderMain.Columns.Add("idPdoType", System.Type.GetType("System.Double"))
        dtOrderMain.Columns.Add("CreditThirty_pdo", System.Type.GetType("System.Double"))
        dtOrderMain.Columns.Add("CreditSixty_pdo", System.Type.GetType("System.Double"))
        dtOrderMain.Columns.Add("PricePdo_pdo", System.Type.GetType("System.Double"))
        dtOrderMain.Columns.Add("PriceSeed", System.Type.GetType("System.Double"))

        dtOrderMain.Columns.Add("idUnitW", System.Type.GetType("System.Int32"))
        dtOrderMain.Columns.Add("pWeight", System.Type.GetType("System.Double"))
        dtOrderMain.Columns.Add("WPerPack", System.Type.GetType("System.Double"))
        dtOrderMain.Columns.Add("idCusRefAddr", System.Type.GetType("System.Int32"))
        dtOrderMain.Columns.Add("idType", System.Type.GetType("System.Int32"))

        dtOrderMain.TableName = "OrderDt"
        ds_Right.Tables.Add(dtOrderMain)

        dtOrderLot.Columns.Add("idSaleOrderDt", System.Type.GetType("System.Int32"))
        dtOrderLot.Columns.Add("idRefLot", System.Type.GetType("System.Int32"))
        dtOrderLot.Columns.Add("idWh", System.Type.GetType("System.Int32"))
        dtOrderLot.Columns.Add("LotNo", System.Type.GetType("System.String"))
        dtOrderLot.Columns.Add("WareHouseName", System.Type.GetType("System.String"))
        dtOrderLot.Columns.Add("AmtBal", System.Type.GetType("System.Double"))
        dtOrderLot.Columns.Add("UnitNameBal", System.Type.GetType("System.String"))
        dtOrderLot.Columns.Add("AmountCut", System.Type.GetType("System.Double"))
        dtOrderLot.Columns.Add("idUnitBal", System.Type.GetType("System.Int32"))
        dtOrderLot.Columns.Add("DateGen", System.Type.GetType("System.DateTime"))
        dtOrderLot.Columns.Add("idLot", System.Type.GetType("System.Int32"))
        dtOrderLot.Columns.Add("PDAge", System.Type.GetType("System.String"))
        dtOrderLot.Columns.Add("idLotSPM", System.Type.GetType("System.Int32"))
        dtOrderLot.Columns.Add("CompRec", System.Type.GetType("System.Int32"))
        dtOrderLot.Columns.Add("AmtCurStock", System.Type.GetType("System.Double"))
        dtOrderLot.Columns.Add("DocCode_PO", System.Type.GetType("System.String"))

        dtOrderLot.TableName = "idLot"
        ds_Right.Tables.Add(dtOrderLot)

        Dim keyColumn As DataColumn = ds_Right.Tables("OrderDt").Columns("idSaleOrderDt")
        Dim foreignColumn As DataColumn = ds_Right.Tables("idLot").Columns("idSaleOrderDt")
        ds_Right.Relations.Add("Lot สำหรับขาย", keyColumn, foreignColumn)

        GCLotFIFO.DataSource = ds_Right.Tables("OrderDt")
        GCLotFIFO.ForceInitialize()
        GCLotFIFO.LevelTree.Nodes.Add("Lot สำหรับขาย", GVLotSale)

        GCOrder.DataSource = dtOrderDtSel
    End Sub
    Private Sub FrmMnOrderSel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildColumns()
        InitColDtBack()
        lblPartnerName.Text = "ลูกค้า :  " & gPartNerName

        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()


        Dim arridCompAsg As Integer() = {2, 3}

        If Not arridCompAsg.Contains(gidComp) Then
            ColDocCode_PO.Visible = False
            ColDocCodeRef.Visible = False
        Else
            ColWHName.Visible = False
        End If

        stLoad = 1

    End Sub
    Private Sub FrmMnOrderSel_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtOrderNo.Focus()
    End Sub
    Private Sub InitColDtBack()
        MainReturn.Columns.Add("idSubType", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("PdCode", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("CodeOrder", System.Type.GetType("System.String")) 'เลขที่รายการสั่งซื้อ
        MainReturn.Columns.Add("LotNo", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("ProductName", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("AmtStock", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("AmtOrder", System.Type.GetType("System.Double")) 'จน.สั่งซื้อ
        MainReturn.Columns.Add("AmtSale", System.Type.GetType("System.Double")) 'จำนวนขาย
        MainReturn.Columns.Add("UnitName", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("idUnit", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idSaleOrderDt", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idSaleDt", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("OldStock", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("OldAmt", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("CompRec", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idLot", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("chk", System.Type.GetType("System.Boolean"))
        MainReturn.Columns.Add("idInvMain", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idLotSPM", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idWh", System.Type.GetType("System.Int64"))

        MainReturn.Columns.Add("idInvGroup", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("DtType", System.Type.GetType("System.Int64"))

        MainReturn.Columns.Add("AmtWIMRecBal", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("stWIMAllRec", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idRefLot", System.Type.GetType("System.Int64"))
        MainReturn.Columns.Add("idPkPORecDt", System.Type.GetType("System.Int64"))

        MainReturn.Columns.Add("pWeight", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("idUnitW", System.Type.GetType("System.Int64"))

        MainReturn.Columns.Add("full_lock", System.Type.GetType("System.String"))

        MainReturn.Columns.Add("PriceWholesale_fg", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("PriceRetail_fg", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("PriceBill_fg", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("idPdoType", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("CreditThirty_pdo", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("CreditSixty_pdo", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("PricePdo_pdo", System.Type.GetType("System.Double"))
        MainReturn.Columns.Add("PriceSeed", System.Type.GetType("System.Double"))

        MainReturn.Columns.Add("idCusRefAddr", System.Type.GetType("System.Int32"))
        MainReturn.Columns.Add("idType", System.Type.GetType("System.Int32"))
    End Sub
    Private Sub BindData()
        ds_Left = New DataSet
        Dim vWhere As String = ""
        Dim arrIDComp As Integer() = {2, 3}

        vWhere = "WHERE mt.idComp = " & gidComp & vbNewLine &
                 "AND mt.idPsCancel Is Null " & vbNewLine &
                 "AND Year(mt.DateOrderD) >= 2023"

        If Not arrIDComp.Contains(gidComp) Then
            vWhere = vWhere & vbNewLine &
                     "AND ISNULL(mt.stApp,0) = 1"

        End If

        Dim SmSaleOrderMt As New DataTable

        sCommand.CommandText = "SELECT cast(0 as bit) as Chk, mt.idSaleOrder, mt.idComp, c.PartnerName, c.idPartner, c.idCus , mt.DocCode," & vbNewLine &
                                "IIF(IsNull(mt.idPOTs,0) = 0, mt.DocRef, bMt.DocCode) As DocRef, mt.DateOrderD, mt.DateRequireD, " & vbNewLine &
                               "p1.PsShortname As PsSale, P2.PsName As PsOrder,  0 As stEnough, mt.TimeTs, mt.DateTsD, " & vbNewLine &
                               "(CASE ISNULL(mt.stSysOrder, 0) When  0 Then 'PC' WHEN 1 THEN 'Mobile' WHEN 2 THEN 'Web Browser' WHEN 3 THEN 'PO' END) AS stSysText," & vbNewLine &
                                "mt.Note As NoteOrder, ISNULL(mt.idPOTs,0) As idPOTs, ISNULL(mt.idCusRefAddr, 0) As idCusRefAddr" & vbNewLine &
                                "From SmSaleOrderMt mt" & vbNewLine &
                                "LEFT JOIN dPartner c ON mt.idPartner = c.idPartner " & vbNewLine &
                                "Left JOIN vPersonxSelect p1 On mt.idPsSale = p1.idPs " & vbNewLine &
                                "LEFT JOIN vPersonxSelect p2 ON mt.idPsOrder = p2.idPs " & vbNewLine &
                                "LEFT JOIN PkPOBuyMt bMt ON ISNULL(mt.idPOTs,0) = bMt.idPOTs " & vbNewLine &
                                 vWhere & vbNewLine &
                                "AND mt.idPartner = " & gidPartner & vbNewLine &
                                "AND mt.stOrd Is NULL" & vbNewLine &
                                "AND bMt.DateComplete Is NULL" & vbNewLine &
                                "--AND ISNULL(mt.stApp,0) = 1"
        sAdapter.Fill(SmSaleOrderMt)
        SmSaleOrderMt.TableName = "SmSaleOrderMt"

        Dim SmSaleOrderDt As New DataTable

        If Not arrIDComp.Contains(gidComp) Then
            sCommand.CommandText = "SELECT  dt.idSaleOrder, dt.idSaleOrderDt, ic.InvCode, dt.idInvMain, inv.InvName, ig.DtType, inv.idSubType, ISNULL(dt.idType,0) As idType," & vbNewLine &
                                  "((IsNULL(dt.Amount,0)) - ISNULL(dt.AmountSale,0)) As AmtOrder, inv.idInvGroup,  d.idUnitW, d.Weight As pWeight, sfg.WPerPack, " & vbNewLine &
                                  "inv.idInvGroup, u.UnitName As UnitNameOrd, IsNULL(dt.idUnitSale,0) As idUnitOrd, us.idUnit, us.UnitName, 0 As stEnough, inv.idSubType, mt.DocCode, " & vbNewLine &
                                  " bDt.dNET, mt.Note As NoteOrder, ISNULL(mt.idPOTs,0) As idPOTs, ISNULL(dt.idPODt,0) As idPODt, bMt.DocCode As DocCode_PO," & vbNewLine &
                                  "IsNULL(d.PriceBill,0) As PriceBill_fg, IsNULL(d.PriceWholesale,0) As PriceWholesale_fg, IsNULL(d.PriceRetail,0) As PriceRetail_fg," & vbNewLine &
                                  "ISNULL(CreditThirty, 0) As CreditThirty_pdo, ISNULL(CreditSixty,0) As CreditSixty_pdo, IsNULL(o.Price,0) As PricePdo_pdo," & vbNewLine &
                                  "ISNULL(o.idPdoType, 0) As idPdoType, CASE WHEN inv.idInvGroup = 2 THEN d.PdCode ELSE ic.InvCode END As PdCode, ISNULL(mt.idCusRefAddr, 0) As idCusRefAddr, " & vbNewLine &
                                  "IsNULL(sfg.Price,0) As PriceSeedFg_sfg, ISNULL(p.Price,0) As PriceSeed, mt.TimeTs, mt.DateTsD, IIF(IsNull(mt.idPOTs,0) = 0, mt.DocRef, bMt.DocCode) As DocRef, mt.Note As NoteOrder, p1.PsName As PsSale" & vbNewLine &
                                  "FROM SmSaleOrderDt dt" & vbNewLine &
                                  "LEFT JOIN SmSaleOrderMt mt ON dt.idSaleOrder = mt.idSaleOrder" & vbNewLine &
                                  "LEFT JOIN dPartner c ON mt.idPartner = c.idPartner " & vbNewLine &
                                  "LEFT JOIN dInventoryMain inv ON dt.idInvMain = inv.idInvMain" & vbNewLine &
                                  "LEFT JOIN dInvGroup ig ON inv.idInvGroup = ig.idInvGroup" & vbNewLine &
                                  "LEFT JOIN dInvCode ic ON inv.idInvMain = ic.idInvMain" & vbNewLine &
                                  "LEFT JOIN dInvUnit u ON dt.idUnit = u.idUnit" & vbNewLine &
                                  "LEFT JOIN dInvUnit us ON inv.idUnit = us.idUnit" & vbNewLine &
                                  "LEFT JOIN dInvGroup As gr ON inv.idInvGroup = gr.idInvGroup" & vbNewLine &
                                  "LEFT JOIN PkPOBuyDt bDt ON dt.idPODt = bDt.idPODt AND dt.idPODt Is Not NULL" & vbNewLine &
                                  "LEFT JOIN PkPOBuyMt bMt ON ISNULL(mt.idPOTs,0) = bMt.idPOTs" & vbNewLine &
                                  "LEFT JOIN dPackingPdSet d On inv.idSubType = d.idPdPk And inv.idInvGroup = 2" & vbNewLine &
                                  "LEFT JOIN SmPdOtherD o On inv.idSubType = o.idPdO And ig.stPdOther = 1" & vbNewLine &
                                  "Left Join dSeedFlPackage sfg On inv.idSubType = sfg.idFlPk And inv.idInvgroup = 42" & vbNewLine &
                                  "Left Join dSeedProductPrice p On inv.idInvMain = p.idInvMain And inv.idInvGroup = 1 And p.idComp = " & gidComp & vbNewLine &
                                  "Left JOIN vPersonxSelect p1 On mt.idPsSale = p1.idPs " & vbNewLine &
                                   vWhere & vbNewLine &
                                  "And dt.StAllSale Is NULL " & vbNewLine &
                                  "--AND ISNULL(mt.stApp,0) = 1" & vbNewLine &
                                  "AND mt.idPartner = " & gidPartner & vbNewLine &
                                  "AND mt.stOrd Is NULL" & vbNewLine &
                                  "AND bMt.DateComplete Is NULL" & vbNewLine &
                                  "AND dt.idPsCancel IS NULL" & vbNewLine &
                                  "ORDER BY " & vbNewLine &
                                    "CASE " & vbNewLine &
                                         "WHEN d.idType = 1 THEN 0" & vbNewLine &
                                         "Else 1" & vbNewLine &
                                     "End," & vbNewLine &
                                     "Case " & vbNewLine &
                                         "WHEN d.idType = 1 " & vbNewLine &
                                             "And (d.shCode Is NULL Or d.shNo Is NULL)" & vbNewLine &
                                         "THEN 1" & vbNewLine &
                                         "WHEN d.idType = 1 " & vbNewLine &
                                         "THEN 0" & vbNewLine &
                                     "End," & vbNewLine &
                                     "Case " & vbNewLine &
                                         "WHEN d.idType = 1 THEN d.shCode" & vbNewLine &
                                     "End," & vbNewLine &
                                     "Case " & vbNewLine &
                                         "WHEN d.idType = 1 THEN d.shNo" & vbNewLine &
                                     "End," & vbNewLine &
                                     "Case " & vbNewLine &
                                         "WHEN d.idType <> 1 Or d.idType Is NULL" & vbNewLine &
                                         "THEN dt.idSaleOrderDt" & vbNewLine &
                                     "End"
            '"CASE " & vbNewLine &
            '      "WHEN d.ShortName LIKE 'F%' THEN 1" & vbNewLine &
            '      "WHEN d.ShortName LIKE 'H%' THEN 2" & vbNewLine &
            '      "WHEN d.ShortName LIKE 'V%' THEN 3" & vbNewLine &
            '      "Else 4" & vbNewLine &
            '  "End ASC, " & vbNewLine &
            '"d.ShortName ASC," & vbNewLine &
            '"dt.idSaleOrderDt Asc"
        Else
            sCommand.CommandText = "Select  dt.idSaleOrder, dt.idSaleOrderDt, ic.InvCode, dt.idInvMain, inv.InvName, ig.DtType, inv.idSubType, ISNULL(dt.idType,0) As idType," & vbNewLine &
                                  "((ISNULL(dt.Amount, 0) * 1.2) - ISNULL(dt.AmountSale, 0) ) As AmtOrder, inv.idInvGroup,  d.idUnitW, d.Weight As pWeight, sfg.WPerPack, " & vbNewLine &
                                  "inv.idInvGroup, u.UnitName As UnitNameOrd, IsNULL(dt.idUnitSale,0) As idUnitOrd, us.idUnit, us.UnitName, 0 As stEnough, inv.idSubType, mt.DocCode, " & vbNewLine &
                                  "bDt.dNET, mt.Note As NoteOrder, ISNULL(mt.idPOTs,0) As idPOTs, ISNULL(dt.idPODt,0) As idPODt, bMt.DocCode As DocCode_PO," & vbNewLine &
                                  "IsNULL(d.PriceBill,0) As PriceBill_fg, IsNULL(d.PriceWholesale,0) As PriceWholesale_fg, IsNULL(d.PriceRetail,0) As PriceRetail_fg," & vbNewLine &
                                  "ISNULL(CreditThirty, 0) As CreditThirty_pdo, ISNULL(CreditSixty,0) As CreditSixty_pdo, IsNULL(o.Price,0) As PricePdo_pdo," & vbNewLine &
                                  "ISNULL(o.idPdoType, 0) As idPdoType, Case When inv.idInvGroup = 2 Then d.PdCode Else ic.InvCode End As PdCode, ISNULL(mt.idCusRefAddr, 0) As idCusRefAddr, " & vbNewLine &
                                  "IsNULL(sfg.Price,0) As PriceSeedFg_sfg, ISNULL(p.Price,0) As PriceSeed, mt.TimeTs, mt.DateTsD, IIF(IsNull(mt.idPOTs,0) = 0, mt.DocRef, bMt.DocCode) As DocRef, mt.Note As NoteOrder, p1.PsName As PsSale" & vbNewLine &
                                  "FROM SmSaleOrderDt dt" & vbNewLine &
                                  "LEFT JOIN SmSaleOrderMt mt On dt.idSaleOrder = mt.idSaleOrder" & vbNewLine &
                                  "LEFT JOIN dPartner c On mt.idPartner = c.idPartner " & vbNewLine &
                                  "LEFT JOIN dInventoryMain inv On dt.idInvMain = inv.idInvMain" & vbNewLine &
                                  "LEFT JOIN dInvGroup ig On inv.idInvGroup = ig.idInvGroup" & vbNewLine &
                                  "LEFT JOIN dInvCode ic On inv.idInvMain = ic.idInvMain" & vbNewLine &
                                  "LEFT JOIN dInvUnit u On dt.idUnit = u.idUnit" & vbNewLine &
                                  "LEFT JOIN dInvUnit us On inv.idUnit = us.idUnit" & vbNewLine &
                                  "LEFT JOIN dInvGroup As gr On inv.idInvGroup = gr.idInvGroup" & vbNewLine &
                                  "LEFT JOIN PkPOBuyDt bDt On dt.idPODt = bDt.idPODt And dt.idPODt Is Not NULL" & vbNewLine &
                                  "LEFT JOIN PkPOBuyMt bMt On ISNULL(mt.idPOTs,0) = bMt.idPOTs" & vbNewLine &
                                  "LEFT JOIN dPackingPdSet d On inv.idSubType = d.idPdPk And inv.idInvGroup = 2" & vbNewLine &
                                  "LEFT JOIN SmPdOtherD o On inv.idSubType = o.idPdO And ig.stPdOther = 1" & vbNewLine &
                                  "Left Join dSeedFlPackage sfg On inv.idSubType = sfg.idFlPk And inv.idInvgroup = 42" & vbNewLine &
                                  "Left Join dSeedProductPrice p On inv.idInvMain = p.idInvMain And inv.idInvGroup = 1 And p.idComp = " & gidComp & vbNewLine &
                                  "Left JOIN vPersonxSelect p1 On mt.idPsSale = p1.idPs " & vbNewLine &
                                   vWhere & vbNewLine &
                                  "And dt.StAllSale Is NULL " & vbNewLine &
                                  "And mt.idPartner = " & gidPartner & vbNewLine &
                                  "And mt.stOrd Is NULL" & vbNewLine &
                                  "And bMt.DateComplete Is NULL" & vbNewLine &
                                  "And dt.idPsCancel Is NULL" & vbNewLine &
                                  "--AND ISNULL(mt.stApp,0) = 1" & vbNewLine &
                                  "Order By dt.idSaleOrderDt ASC"
        End If

        sAdapter.Fill(SmSaleOrderDt)
        SmSaleOrderDt.TableName = "SmSaleOrderDt"
        ds_Left.Tables.Clear()

        ds_Left.Tables.Add(SmSaleOrderMt)
        ds_Left.Tables.Add(SmSaleOrderDt)

        Dim keyColumn As DataColumn = ds_Left.Tables(0).Columns("idSaleOrder")
        Dim foreignColumn As DataColumn = ds_Left.Tables(1).Columns("idSaleOrder")

        ds_Left.Relations.Add("รายการสั่งซื้อสินค้า", keyColumn, foreignColumn)

        If ds_Left.Tables(0).Rows.Count <= 0 Then
            MessageBox.Show("ไม่พบข้อมูลรายการสั่งซื้อสินค้า" & vbNewLine &
                            "ของลูกค้า : " & gPartNerName, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCount.Text = Format(GVOrderMt.DataRowCount, "0")
            Me.Close()
            Exit Sub
        Else
            GCOrder.DataSource = ds_Left.Tables(0)
            GCOrder.ForceInitialize()

            GCOrder.LevelTree.Nodes.Add("รายการสั่งซื้อสินค้า", GVOrderDt)
        End If
    End Sub

    Private Sub GVOrderMt_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GVOrderMt.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If
    End Sub
    Private Sub GVSaleOrder_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GVSaleOrder.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNumC" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If
    End Sub
    Private Sub GVOrderDt_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GVOrderDt.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNo" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If
    End Sub
    Private Sub rptSel_MouseUp(sender As Object, e As MouseEventArgs)
        GVOrderMt.RefreshData()

        Dim dt As DataTable = DirectCast(GVOrderMt.DataSource, DataView).ToTable

        Dim dv As New DataView(dt)
        dv.RowFilter = "Chk=True"
        lblSelected.Text = Format(dv.Count, "#,##0")
    End Sub
    Private Sub btnLotADD_Click(sender As Object, e As EventArgs) Handles btnLotADD.Click
        Dim dt As DataTable = DirectCast(GVOrderMt.DataSource, DataView).ToTable

        dtOrderDtSel.Clear()
        Dim dv As New DataView(dt)
        dv.RowFilter = "Chk=True"

        For i As Integer = 0 To dv.Count - 1
            Dim dr As DataRow = dtOrderDtSel.NewRow
            dr("DocCode") = dv.Item(i).Item("DocCode")
            dr("idSaleOrderDt") = dv.Item(i).Item("idSaleOrderDt")
            dr("idInvMain") = dv.Item(i).Item("idInvMain")
            dr("InvName") = dv.Item(i).Item("InvName")
            dr("AmtOrder") = dv.Item(i).Item("AmtOrder")
            dr("UnitName") = dv.Item(i).Item("UnitName")
            dr("idUnit") = dv.Item(i).Item("idUnit")
            dr("idInvGroup") = dv.Item(i).Item("idInvGroup")

            dtOrderDtSel.Rows.Add(dr)

        Next

        Dim vFrm As New FrmLotOrderSel(FrmLotOrderSel.eProcess.eLotFIFO, gidComp, dtOrderDtSel)
        vFrm.Show()
    End Sub
    Private Sub rptSelOrder_Click(sender As Object, e As EventArgs) Handles rptSelOrder.Click
        fnSetOrderAll()
    End Sub
    Private Sub GVOrderMt_KeyDown(sender As Object, e As KeyEventArgs) Handles GVOrderMt.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Then
            fnSetOrderAll()
        End If
    End Sub

    Private Sub fnSetOrderAll()
        ' 1. สร้าง Dictionary เก็บตารางสต็อกแยกตามสินค้า (idInvMain) เพื่อไม่ให้ Query ซ้ำซ้อน
        Dim dtStockTemp As New Dictionary(Of Integer, DataTable)

        ' --- 2. วนลูปรายการสั่งซื้อ (ฝั่งซ้าย) ---
        Dim dr_OrderMt As DataRowView = GVOrderMt.GetFocusedRow
        Dim drDetail() As DataRow = ds_Left.Tables("SmSaleOrderDt").Select("idSaleOrder=" & dr_OrderMt.Item("idSaleOrder"))
        For Each dr As DataRow In drDetail
            Dim dr1_ As DataRow = dtOrderMain.NewRow
            dr1_("idSaleOrder") = dr.Item("idSaleOrder")
            dr1_("idSaleOrderDt") = dr.Item("idSaleOrderDt")
            dr1_("DocCode") = dr.Item("DocCode")
            dr1_("DocRef") = dr.Item("DocRef")
            dr1_("DateTsD") = dr.Item("DateTsD")
            dr1_("TimeTs") = dr.Item("TimeTs")
            dr1_("NoteOrder") = dr.Item("NoteOrder")
            dr1_("PsSale") = dr.Item("PsSale")
            dr1_("PdCode") = dr.Item("PdCode")
            dr1_("idInvMain") = dr.Item("idInvMain")
            dr1_("InvName") = dr.Item("InvName")
            dr1_("AmtOrder") = dr.Item("AmtOrder")
            dr1_("UnitName") = dr.Item("UnitName")
            dr1_("idUnit") = dr.Item("idUnit")
            dr1_("idInvGroup") = dr.Item("idInvGroup")
            dr1_("idSubType") = dr.Item("idSubType")
            dr1_("PriceWholesale_fg") = dr.Item("PriceWholesale_fg")
            dr1_("PriceRetail_fg") = dr.Item("PriceRetail_fg")
            dr1_("PriceBill_fg") = dr.Item("PriceBill_fg")
            dr1_("idPdoType") = dr.Item("idPdoType")
            dr1_("CreditThirty_pdo") = dr.Item("CreditThirty_pdo")
            dr1_("CreditSixty_pdo") = dr.Item("CreditSixty_pdo")
            dr1_("PricePdo_pdo") = dr.Item("PricePdo_pdo")
            dr1_("PriceSeed") = dr.Item("PriceSeed")
            dr1_("DtType") = dr.Item("DtType")
            dr1_("pWeight") = dr.Item("pWeight")
            dr1_("idUnitW") = dr.Item("idUnitW")
            dr1_("WPerPack") = dr.Item("WPerPack")
            dr1_("idCusRefAddr") = dr.Item("idCusRefAddr")
            dr1_("idType") = dr.Item("idType")

            dtOrderMain.Rows.Add(dr1_)

            Dim CurrentidInvMain As Integer = CInt(dr.Item("idInvMain"))
            ' 3. ถ้าสินค้าตัวนี้ยังไม่มีใน Temp ให้ไป Query มาครั้งเดียว
            If Not dtStockTemp.ContainsKey(CurrentidInvMain) Then
                Dim dtNewStock As DataTable = fnQueryLotFIFO_ByProduct(dr.Item("idInvMain"), dr("idSaleOrderDt"))
                dtStockTemp.Add(CurrentidInvMain, dtNewStock)
            End If

            ' 4. เรียกใช้ฟังก์ชันตัดยอด โดยส่ง DataTable Temp ไป
            FIFOLotForSale(dr1_("idSaleOrderDt"), dr1_("AmtOrder"), dtStockTemp(CurrentidInvMain))
            CalForSumAmtSale()
        Next

        GVSaleOrder.RefreshData()
        ExpandDetailsT(GVSaleOrder)

        Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GCOrder.FocusedView
        detailView.DeleteRow(detailView.FocusedRowHandle)
        GVOrderMt.RefreshData()

        txtCount.Text = Format(GVOrderMt.DataRowCount, "#,##0")
        txtCountLot.Text = Format(GVSaleOrder.DataRowCount, "#,##0")

        btnBack.Enabled = True
    End Sub

    Private Function fnQueryLotFIFO_ByProduct(ByVal idInvMain As Integer, ByVal idSaleOrderDt As Integer) As DataTable
        Dim dtReturn As New DataTable

        Dim BoundDateGen As String = ""
        If gidComp = 12 Then
            BoundDateGen = "365"
        Else
            If rdb90.Checked = True Then
                BoundDateGen = "90"
            ElseIf rdb60.Checked = True Then
                BoundDateGen = "60"
            ElseIf rdb30.Checked = True Then
                BoundDateGen = "30"
            End If
        End If

        Dim strComp As String = ""

        If gidComp = 10 Then
            strComp = "(4,10)"
        Else
            strComp = "(" & gidComp & ")"
        End If

        Dim CompASG() As Integer = {2, 3}

        If Not CompASG.Contains(gidComp) Then
            sCommand.CommandText = "Select w.idRefLot, w.idWh, lm.LotNo, s.full_lock As WareHouseName ,w.Amount As AmtBal, w.Amount As AmtCurStock,  lm.DateGen, u.UnitName As UnitNameBal, ISNULL(lm.idLotSPM,0) As idLotSPM, " & vbNewLine &
                               "0 As AmountCut, lm.idLot, w.idUnit As idUnitBal, CONCAT(FORMAT(DATEDIFF(day, lm.DateGen, GETDATE()), '#,##0'),' วัน') AS PDAge, lm.CompRec" & vbNewLine &
                               "FROM devsk.vInvLotRefWh_RStock w" & vbNewLine &
                               "LEFT JOIN dInvLotMain lm ON w.idLot = lm.idLot" & vbNewLine &
                               "LEFT JOIN devsk.dInventoryMain i ON lm.idInvMain = i.idInvMain" & vbNewLine &
                               "LEFT JOIN dbo.SsWarehouse s ON w.idWh = s.idWh" & vbNewLine &
                               "LEFT JOIN dInvUnit u On w.idUnit = u.idUnit" & vbNewLine &
                               "WHERE w.Amount > 0 " & vbNewLine &
                               "And lm.StDel Is NULL" & vbNewLine &
                               "And lm.CompRec IN " & strComp & vbNewLine &
                               "And lm.idInvMain = " & idInvMain & vbNewLine &
                               "AND DATEDIFF(day, lm.DateGen, GETDATE()) <= " & BoundDateGen & vbNewLine &
                               "AND w.idWh Not In(5503)" & vbNewLine &
                               "Order by lm.DateGen DESC"
            sAdapter.Fill(dtReturn)
        Else
            sCommand.CommandText = "Select bMt.DocCode As DocCode_PO, w.idRefLot, w.idWh, lm.LotNo, s.full_lock As WareHouseName," & vbNewLine &
                              "w.Amount As AmtBal, w.Amount As AmtCurStock,  lm.DateGen, u.UnitName As UnitNameBal, ISNULL(lm.idLotSPM,0) As idLotSPM, " & vbNewLine &
                              "0 As AmountCut, lm.idLot, w.idUnit As idUnitBal, CONCAT(FORMAT(DATEDIFF(day, lm.DateGen, GETDATE()), '#,##0'),' วัน') AS PDAge, lm.CompRec" & vbNewLine &
                              "FROM devsk.vInvLotRefWh_RStock w" & vbNewLine &
                              "LEFT JOIN dInvLotMain lm ON w.idLot = lm.idLot" & vbNewLine &
                              "LEFT JOIN devsk.dInventoryMain i ON lm.idInvMain = i.idInvMain" & vbNewLine &
                              "LEFT JOIN dbo.SsWarehouse s ON w.idWh = s.idWh" & vbNewLine &
                              "LEFT JOIN dInvUnit u On w.idUnit = u.idUnit" & vbNewLine &
                              "LEFT JOIN SmSaleOrderDt oDt ON oDt.idSaleOrderDt = ISNULL(lm.idSaleOrderDt,-1)" & vbNewLine &
                              "LEFT JOIN SmSaleOrderMt oMt On oDt.idSaleOrder = oMt.idSaleOrder" & vbNewLine &
                              "LEFT JOIN PkPOBuyMt bMt On oMt.idPOTs = bMt.idPOTs" & vbNewLine &
                              "WHERE w.Amount > 0 " & vbNewLine &
                              "And lm.StDel Is NULL" & vbNewLine &
                              "And lm.CompRec IN " & strComp & vbNewLine &
                              "And lm.idInvMain = " & idInvMain & vbNewLine &
                              "AND ISNULL(lm.idSaleOrderDt,-1) =" & idSaleOrderDt & vbNewLine &
                              "AND DATEDIFF(day, lm.DateGen, GETDATE()) <= " & BoundDateGen & vbNewLine &
                              "Order by lm.DateGen DESC"
            sAdapter.Fill(dtReturn)

            If dtReturn.Rows.Count = 0 Then
                sCommand.CommandText = "Select bMt.DocCode As DocCode_PO, w.idRefLot, w.idWh, lm.LotNo, s.full_lock As WareHouseName," & vbNewLine &
                                      "w.Amount As AmtBal, w.Amount As AmtCurStock,  lm.DateGen, u.UnitName As UnitNameBal, ISNULL(lm.idLotSPM,0) As idLotSPM, " & vbNewLine &
                                      "0 As AmountCut, lm.idLot, w.idUnit As idUnitBal, CONCAT(FORMAT(DATEDIFF(day, lm.DateGen, GETDATE()), '#,##0'),' วัน') AS PDAge, lm.CompRec" & vbNewLine &
                                      "FROM devsk.vInvLotRefWh_RStock w" & vbNewLine &
                                      "LEFT JOIN dInvLotMain lm ON w.idLot = lm.idLot" & vbNewLine &
                                      "LEFT JOIN devsk.dInventoryMain i ON lm.idInvMain = i.idInvMain" & vbNewLine &
                                      "LEFT JOIN dbo.SsWarehouse s ON w.idWh = s.idWh" & vbNewLine &
                                      "LEFT JOIN dInvUnit u On w.idUnit = u.idUnit" & vbNewLine &
                                      "LEFT JOIN SmSaleOrderDt oDt ON oDt.idSaleOrderDt = ISNULL(lm.idSaleOrderDt,-1)" & vbNewLine &
                                      "LEFT JOIN SmSaleOrderMt oMt On oDt.idSaleOrder = oMt.idSaleOrder" & vbNewLine &
                                      "LEFT JOIN PkPOBuyMt bMt On oMt.idPOTs = bMt.idPOTs" & vbNewLine &
                                      "WHERE w.Amount > 0 " & vbNewLine &
                                      "And lm.StDel Is NULL" & vbNewLine &
                                      "And lm.CompRec IN " & strComp & vbNewLine &
                                      "And lm.idInvMain = " & idInvMain & vbNewLine &
                                      "--AND ISNULL(lm.idSaleOrderDt,-1) =" & idSaleOrderDt & vbNewLine &
                                      "AND DATEDIFF(day, lm.DateGen, GETDATE()) <= " & BoundDateGen & vbNewLine &
                                      "Order by lm.DateGen DESC"
                sAdapter.Fill(dtReturn)
            End If

        End If


        Return dtReturn
    End Function

    Private Sub rptSelDt_Click(sender As Object, e As EventArgs) Handles rptSelDt.Click
        fnSetOrderEachDt()
    End Sub

    Dim dtStockTemp_EashDt As New Dictionary(Of Integer, DataTable)
    Private Sub fnSetOrderEachDt()

        ' 1. เข้าถึง GridView ที่กำลังถูกใช้งานอยู่
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(GCOrder.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)

        If view IsNot Nothing Then
            ' 2. ดึง DataRow ของแถวที่คลิกออกมา
            ' GetDataRow จะใช้ได้เมื่อ DataSource ของ Grid เป็น DataTable/DataView
            Dim dr As DataRow = view.GetDataRow(view.FocusedRowHandle)

            If dr IsNot Nothing Then
                Dim dr1_ As DataRow = dtOrderMain.NewRow()
                dr1_("idSaleOrder") = dr("idSaleOrder")
                dr1_("idSaleOrderDt") = dr("idSaleOrderDt")
                dr1_("DocCode") = dr("DocCode")
                dr1_("DocRef") = dr("DocRef")
                dr1_("DateTsD") = dr.Item("DateTsD")
                dr1_("TimeTs") = dr.Item("TimeTs")
                dr1_("NoteOrder") = dr.Item("NoteOrder")
                dr1_("PsSale") = dr.Item("PsSale")

                dr1_("PdCode") = dr("PdCode")
                dr1_("AmtOrder") = dr("AmtOrder")
                dr1_("UnitName") = dr.Item("UnitName")
                dr1_("idUnit") = dr.Item("idUnit")
                dr1_("idInvGroup") = dr.Item("idInvGroup")
                dr1_("idInvMain") = dr.Item("idInvMain")
                dr1_("InvName") = dr.Item("InvName")
                dr1_("idSubType") = dr.Item("idSubType")

                dr1_("PriceWholesale_fg") = dr.Item("PriceWholesale_fg")
                dr1_("PriceRetail_fg") = dr.Item("PriceRetail_fg")
                dr1_("PriceBill_fg") = dr.Item("PriceBill_fg")
                dr1_("idPdoType") = dr.Item("idPdoType")
                dr1_("CreditThirty_pdo") = dr.Item("CreditThirty_pdo")
                dr1_("CreditSixty_pdo") = dr.Item("CreditSixty_pdo")
                dr1_("PricePdo_pdo") = dr.Item("PricePdo_pdo")
                dr1_("PriceSeed") = dr.Item("PriceSeed")
                dr1_("DtType") = dr.Item("DtType")
                dr1_("pWeight") = dr.Item("pWeight")
                dr1_("idUnitW") = dr.Item("idUnitW")
                dr1_("WPerPack") = dr.Item("WPerPack")
                dr1_("idCusRefAddr") = dr.Item("idCusRefAddr")
                dr1_("idType") = dr.Item("idType")

                dtOrderMain.Rows.Add(dr1_)

                '--- AUTO SET LOT ---'
                Dim CurrentidInvMain As Integer = CInt(dr.Item("idInvMain"))
                ' 3. ถ้าสินค้าตัวนี้ยังไม่มีใน Temp ให้ไป Query มาครั้งเดียว
                If Not dtStockTemp_EashDt.ContainsKey(CurrentidInvMain) Then
                    Dim dtNewStock As DataTable = fnQueryLotFIFO_ByProduct(dr.Item("idInvMain"), dr.Item("idSaleOrderDt"))
                    dtStockTemp_EashDt.Add(CurrentidInvMain, dtNewStock)
                End If

                ' 4. เรียกใช้ฟังก์ชันตัดยอด โดยส่ง DataTable Temp ไป
                FIFOLotForSale(dr1_("idSaleOrderDt"), dr1_("AmtOrder"), dtStockTemp_EashDt(CurrentidInvMain))
                CalForSumAmtSale()

                GVSaleOrder.RefreshData()
                ExpandDetailsT(GVSaleOrder)

                Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GCOrder.FocusedView
                detailView.DeleteRow(detailView.FocusedRowHandle)
                GVOrderMt.RefreshData()
                txtCount.Text = Format(GVOrderMt.DataRowCount, "#,##0")
                txtCountLot.Text = Format(GVSaleOrder.DataRowCount, "#,##0")

                btnBack.Enabled = True
            End If
        End If
    End Sub

    ' เพิ่ม Parameter dtLotFIFO เข้ามา และใช้ ByRef
    Private Sub FIFOLotForSale(ByVal idSaleOrderDt As Integer, ByVal AmtOrder As Double, ByRef dtLotFIFO As DataTable)
        Dim SumCut As Double = 0

        ' วนลูปตาม Lot ที่มีในคลังจำลอง
        For j As Integer = 0 To dtLotFIFO.Rows.Count - 1
            ' 1. ดึงยอดล่าสุดจาก DataTable (ByRef จะทำให้มันเห็นค่าที่ถูกบรรทัดก่อนหน้าหักไปแล้ว)
            Dim currentStock As Double = Convert.ToDouble(dtLotFIFO.Rows(j).Item("AmtCurStock"))

            ' 2. ถ้า Lot นี้หมดแล้ว หรือ ตัดครบยอด Order แล้ว ให้ข้าม/ออกจากลูป
            If currentStock <= 0 Then Continue For
            If SumCut >= AmtOrder Then Exit For

            ' 3. คำนวณยอดที่ยังขาดอยู่
            Dim AmtNeed As Double = AmtOrder - SumCut
            Dim dr_ As DataRow = dtOrderLot.NewRow

            ' (ยัดค่าใส่ dr_ ของเดิมนาย...)
            dr_("idSaleOrderDt") = idSaleOrderDt
            dr_("idRefLot") = dtLotFIFO.Rows(j).Item("idRefLot")
            dr_("LotNo") = dtLotFIFO.Rows(j).Item("LotNo")
            dr_("WareHouseName") = dtLotFIFO.Rows(j).Item("WareHouseName")
            dr_("AmtBal") = dtLotFIFO.Rows(j).Item("AmtBal")
            dr_("UnitNameBal") = dtLotFIFO.Rows(j).Item("UnitNameBal")
            dr_("idUnitBal") = dtLotFIFO.Rows(j).Item("idUnitBal")
            dr_("DateGen") = dtLotFIFO.Rows(j).Item("DateGen")
            dr_("idLot") = dtLotFIFO.Rows(j).Item("idLot")
            dr_("PDAge") = dtLotFIFO.Rows(j).Item("PDAge")
            dr_("idWh") = dtLotFIFO.Rows(j).Item("idWh")
            dr_("idLotSPM") = dtLotFIFO.Rows(j).Item("idLotSPM")
            dr_("CompRec") = dtLotFIFO.Rows(j).Item("CompRec")
            dr_("AmtCurStock") = currentStock

            Dim CompASG() As Integer = {2, 3}

            If CompASG.Contains(gidComp) Then
                dr_("DocCode_PO") = dtLotFIFO.Rows(j).Item("DocCode_PO")
            End If

            ' 4. ทำการตัดยอด (Logic หัวใจสำคัญ)
            If AmtNeed <= currentStock Then
                ' กรณีสต็อกพอ: ตัดเท่าที่ขาด
                dr_("AmountCut") = AmtNeed
                SumCut += AmtNeed
                dtLotFIFO.Rows(j).Item("AmtCurStock") = currentStock - AmtNeed ' หักออกจริงในตัวแปรกลาง
            Else
                ' กรณีสต็อกไม่พอ: เอาให้หมด Lot
                dr_("AmountCut") = currentStock
                SumCut += currentStock
                dtLotFIFO.Rows(j).Item("AmtCurStock") = 0 ' เซตเป็น 0 เพื่อให้ลำดับถัดไปข้าม Lot นี้
            End If

            dtOrderLot.Rows.Add(dr_)
        Next
    End Sub

    'Private Sub FIFOLotForSale(ByVal idSaleOrderDt As Integer, ByVal strInvName As String, ByVal AmtOrder As Double)

    '    Dim dtLotFIFO As New DataTable

    '    Dim BoundDateGen As String = ""
    '    If rdb90.Checked = True Then
    '        BoundDateGen = "90"
    '    ElseIf rdb60.Checked = True Then
    '        BoundDateGen = "60"
    '    ElseIf rdb30.Checked = True Then
    '        BoundDateGen = "30"
    '    End If

    '    Dim strComp As String = ""

    '    If gidComp = 10 Then
    '        strComp = "(4,10)"
    '    Else
    '        strComp = "(" & gidComp & ")"
    '    End If

    '    sCommand.CommandText = "Select w.idRefLot, w.idWh, lm.LotNo, s.full_lock As WareHouseName ,w.Amount As AmtBal,  lm.DateGen, u.UnitName As UnitNameBal, ISNULL(lm.idLotSPM,0) As idLotSPM, " & vbNewLine &
    '                           "0 As AmountCut, lm.idLot, oDt.idSaleOrderDt, w.idUnit As idUnitBal, CONCAT(FORMAT(DATEDIFF(day, lm.DateGen, GETDATE()), '#,##0'),' วัน') AS PDAge, lm.CompRec" & vbNewLine &
    '                           "FROM devsk.vInvLotRefWh_RStock w" & vbNewLine &
    '                           "LEFT JOIN dInvLotMain lm ON w.idLot = lm.idLot" & vbNewLine &
    '                           "LEFT JOIN devsk.dInventoryMain i ON lm.idInvMain = i.idInvMain" & vbNewLine &
    '                           "LEFT JOIN dbo.SmSaleOrderDt oDt On i.idInvMain = oDt.idInvMain" & vbNewLine &
    '                           "LEFT JOIN dbo.SsWarehouse s ON w.idWh = s.idWh" & vbNewLine &
    '                           "LEFT JOIN dInvUnit u On w.idUnit = u.idUnit" & vbNewLine &
    '                           "WHERE w.Amount > 0 " & vbNewLine &
    '                           "And lm.StDel Is NULL" & vbNewLine &
    '                           "And lm.CompRec IN " & strComp & vbNewLine &
    '                           "And oDt.idSaleOrderDt = " & idSaleOrderDt & vbNewLine &
    '                           "AND DATEDIFF(day, lm.DateGen, GETDATE()) <= " & BoundDateGen & vbNewLine &
    '                           "Order by lm.DateGen DESC"
    '    sAdapter.Fill(dtLotFIFO)
    '    '-- มี Lot สำหรับขายตามวันที่ผลิตที่เลือก --'
    '    Dim SumCut As Double = 0 'Sum จำนวนเบิกทุก Lot

    '    For j As Integer = 0 To dtLotFIFO.Rows.Count - 1

    '        Dim currentStock As Double = Convert.ToDouble(dtLotFIFO.Rows(j).Item("AmtBal"))
    '        If currentStock <= 0 Then Continue For ' ถ้า Lot นี้หมดแล้ว ข้ามไป Lot ถัดไปเลย

    '        Dim AmtCutNow As Double = AmtOrder - SumCut

    '        If AmtOrder > SumCut Then 'จำนวนสั่งซื้อ > จำนวนที่เบิก
    '            Dim dr_ As DataRow = dtOrderLot.NewRow
    '            dr_("idSaleOrderDt") = idSaleOrderDt
    '            dr_("idRefLot") = dtLotFIFO.Rows(j).Item("idRefLot")
    '            dr_("LotNo") = dtLotFIFO.Rows(j).Item("LotNo")
    '            dr_("WareHouseName") = dtLotFIFO.Rows(j).Item("WareHouseName")
    '            dr_("AmtBal") = dtLotFIFO.Rows(j).Item("AmtBal")
    '            dr_("UnitNameBal") = dtLotFIFO.Rows(j).Item("UnitNameBal")
    '            dr_("idUnitBal") = dtLotFIFO.Rows(j).Item("idUnitBal")
    '            dr_("DateGen") = dtLotFIFO.Rows(j).Item("DateGen")
    '            dr_("idLot") = dtLotFIFO.Rows(j).Item("idLot")
    '            dr_("PDAge") = dtLotFIFO.Rows(j).Item("PDAge")
    '            dr_("idWh") = dtLotFIFO.Rows(j).Item("idWh")
    '            dr_("idLotSPM") = dtLotFIFO.Rows(j).Item("idLotSPM")
    '            dr_("CompRec") = dtLotFIFO.Rows(j).Item("CompRec")

    '            If AmtCutNow <= dtLotFIFO.Rows(j).Item("AmtBal") Then 'Stock เพียงพอต่อความต้องการใช้
    '                dr_("AmountCut") = AmtCutNow
    '                SumCut = SumCut + AmtCutNow
    '            Else
    '                dr_("AmountCut") = dtLotFIFO.Rows(j).Item("AmtBal")
    '                SumCut = SumCut + dtLotFIFO.Rows(j).Item("AmtBal")
    '            End If

    '            dtOrderLot.Rows.Add(dr_)
    '        End If

    '    Next
    'End Sub
    Private Sub CalForSumAmtSale()
        ds_Right.Tables("OrderDt").AcceptChanges()
        ds_Right.Tables("idLot").AcceptChanges()

        GVLotSale.UpdateCurrentRow()

        For i As Integer = 0 To ds_Right.Tables("OrderDt").Rows.Count - 1
            Dim obAmtCut As Object

            Dim row As DataRow = ds_Right.Tables("OrderDt").Rows(i)

            ' ตรวจสอบว่าแถวไม่ได้ถูกลบอยู่
            If row.RowState <> DataRowState.Deleted Then
                If ds_Right.Tables("OrderDt").Rows(i).Item("idSaleOrderDt") <> 0 Then
                    obAmtCut = ds_Right.Tables("idLot").Compute("Sum(AmountCut)", "idSaleOrderDt = " & ds_Right.Tables("OrderDt").Rows(i).Item("idSaleOrderDt"))
                End If
            End If


            'Dim amt As Double = If(IsDBNull(obAmt) = True, 0, CDbl(obAmt))
            ds_Right.Tables("OrderDt").Rows(i).Item("AmtSale") = If(IsDBNull(obAmtCut) = True, 0, CDbl(obAmtCut))
        Next
    End Sub
    Private Function ExpandDetailsT(ByVal gv As GridView)
        For i As Integer = 0 To gv.DataRowCount - 1
            gv.SetMasterRowExpanded(i, True)
        Next
        Return gv
    End Function
    Private Sub rptAddLot_Click(sender As Object, e As EventArgs) Handles rptAddLot.Click
        Dim currentHandle As Integer = GVSaleOrder.FocusedRowHandle

        ' 1. ประกาศตัวแปร List เพื่อเก็บ ID ของแถวที่กางอยู่ (ต้องประกาศไว้ตรงนี้!)
        Dim expandedKeys As New List(Of Object)

        ' วนลูปเก็บ ID ของทุก Master Row ที่กางอยู่ ณ ตอนนี้
        For i As Integer = 0 To GVSaleOrder.DataRowCount - 1
            If GVSaleOrder.GetMasterRowExpanded(i) Then
                ' ใช้ Field "idSaleOrderDt" เป็น Key ในการจำ
                Dim id As Object = GVSaleOrder.GetRowCellValue(i, "idSaleOrderDt")
                If id IsNot Nothing Then expandedKeys.Add(id)
            End If
        Next

        ' 2. เรียกฟังก์ชันเพิ่ม Lot หรือ Refresh ข้อมูลของเพื่อน
        fnAddLotBySelf()

        ' 3. สั่งกางคืน (ใช้ BeginInvoke เพื่อรอให้ UI วาดข้อมูลใหม่เสร็จก่อน)
        Me.BeginInvoke(Sub()
                           ' ใช้ BeginUpdate เพื่อกันจอกระตุก
                           GVSaleOrder.BeginUpdate()
                           Try
                               ' ตอนนี้ expandedKeys จะถูกส่งต่อเข้ามาใน Sub นี้ได้โดยไม่ Error
                               For Each key As Integer In expandedKeys
                                   ' หาตำแหน่ง Row ใหม่หลังจาก Refresh
                                   Dim handle As Integer = GVSaleOrder.LocateByValue("idSaleOrderDt", key)

                                   ' ถ้าเจอ Row เดิม ให้สั่งกางออก
                                   If handle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                                       GVSaleOrder.SetMasterRowExpanded(handle, True)
                                   End If
                               Next
                           Finally
                               GVSaleOrder.EndUpdate()
                           End Try
                       End Sub)


        If currentHandle >= 0 Then
            ' สั่งให้ Grid กางรายการลูก (Detail) ของแถวนี้ออกมา
            GVSaleOrder.SetMasterRowExpanded(currentHandle, True)

            ' (เสริม) ถ้าอยากให้มันเลื่อนหน้าจอไปโฟกัสที่รายการลูกที่เพิ่งเพิ่มมาด้วย
            GVSaleOrder.FocusedRowHandle = currentHandle
        End If

    End Sub
    Private Sub fnAddLotBySelf()
        Dim stridLot As String = "0"

        If dtOrderLot.Rows.Count > 0 Then
            stridLot = dtOrderLot.Rows(0).Item("idRefLot")
            For i As Integer = 1 To dtOrderLot.Rows.Count - 1
                stridLot = stridLot & "," & dtOrderLot.Rows(i).Item("idRefLot")
            Next
        End If

        Dim dr As DataRow = GVSaleOrder.GetFocusedDataRow

        Dim vFrm As New frmLotSelect(frmLotSelect.eProcess.eSelectOrder, gidComp, "", "", dr.Item("idInvMain"), dr.Item("InvName"), dtOrderLot)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim dtRefLot As DataTable = vFrm.dtLotReturn
            Dim SumCut As Double = 0

            For i As Integer = 0 To dtRefLot.Rows.Count - 1

                Dim obSumAmtCut As Object
                If ds_Right.Tables("OrderDt").Rows(i).Item("idSaleOrderDt") <> 0 Then
                    obSumAmtCut = ds_Right.Tables("idLot").Compute("Sum(AmountCut)", "idSaleOrderDt = " & dr.Item("idSaleOrderDt")) 'Sum จำนวนเบิกทุก Lot
                End If

                SumCut = If(IsDBNull(obSumAmtCut) = True, 0, CDbl(obSumAmtCut))

                Dim AmtCutNow As Double = dr.Item("AmtOrder") - SumCut

                If dr.Item("AmtOrder") > SumCut Then 'จำนวนสั่งซื้อ > จำนวนที่เบิก

                    Dim drn As DataRow = ds_Right.Tables("idLot").NewRow
                    With drn
                        drn("idSaleOrderDt") = dr.Item("idSaleOrderDt")
                        drn("idRefLot") = dtRefLot.Rows(i).Item("idRefLot")
                        drn("idLot") = dtRefLot.Rows(i).Item("idLot")
                        drn("LotNo") = dtRefLot.Rows(i).Item("LotNo")
                        drn("WareHouseName") = dtRefLot.Rows(i).Item("full_lock")

                        drn("AmtBal") = dtRefLot.Rows(i).Item("AmtStock")

                        drn("UnitNameBal") = dtRefLot.Rows(i).Item("UnitName")
                        drn("idUnitBal") = dtRefLot.Rows(i).Item("idUnit")
                        drn("DateGen") = dtRefLot.Rows(i).Item("DateGen")
                        drn("PDAge") = dtRefLot.Rows(i).Item("PDAge")
                        drn("idWh") = dtRefLot.Rows(i).Item("idWh")
                        drn("idLotSPM") = dtRefLot.Rows(i).Item("idLotSPM")
                        drn("CompRec") = dtRefLot.Rows(i).Item("CompRec")

                        Dim CompASG() As Integer = {2, 3}

                        If CompASG.Contains(gidComp) Then
                            drn("DocCode_PO") = dtRefLot.Rows(i).Item("DocCode_PO")
                        End If

                        ' ดึงค่า "จน. ที่ใช้ได้" (4.00) จาก Pop-up
                        Dim AmtStockBal As Double = Convert.ToDouble(dtRefLot.Rows(i).Item("AmtStockBal"))

                        ' 2. คำนวณช่อง "จำนวนขาย" (AmountCut)
                        If AmtCutNow <= AmtStockBal Then
                            ' ถ้าความต้องการ (6.00) น้อยกว่าสต๊อกที่ใช้ได้ ให้ใส่ AmtCutNow
                            drn("AmountCut") = AmtCutNow
                            SumCut += AmtCutNow
                        Else
                            ' ถ้าความต้องการ (6.00) มากกว่าสต๊อกที่ใช้ได้ (4.00) ให้ใส่สต๊อกที่เหลือจริง (4.00)
                            drn("AmountCut") = AmtStockBal
                            SumCut += AmtStockBal
                        End If


                        'If AmtCutNow <= dtRefLot.Rows(i).Item("AmtStock") Then 'Stock เพียงพอต่อความต้องการใช้
                        '    drn("AmountCut") = AmtCutNow
                        '    SumCut = SumCut + AmtCutNow
                        'Else
                        '    drn("AmountCut") = dtRefLot.Rows(i).Item("AmtStock")
                        '    SumCut = SumCut + dtRefLot.Rows(i).Item("AmtStock")
                        'End If

                    End With
                    ds_Right.Tables("idLot").Rows.Add(drn)
                Else
                    MessageBox.Show(dr.Item("InvName") & " ขายเกินจำนวนสั่งซื้อ กรุณาตรวจสอบ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

            Next

            GCLotFIFO.DataSource = Nothing
            GCLotFIFO.DataSource = ds_Right.Tables("OrderDt")
            'ExpandDetailsT(GVSaleOrder)
            GVSaleOrder.ExpandAllGroups()
            CalForSumAmtSale()
        End If

    End Sub
    'Private Sub rptDelDt_Click(sender As Object, e As EventArgs) Handles rptDelDt.Click
    '    Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GCLotFIFO.FocusedView
    '    Dim result As DialogResult
    '    result = MessageBox.Show("คุณต้องการลบ Lot No. นี้ใช่หรือไม่", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
    '    If result = Windows.Forms.DialogResult.OK Then

    '        detailView.DeleteRow(detailView.FocusedRowHandle)
    '        ds_Right.AcceptChanges()
    '        GVLotSale.RefreshData()

    '        GVSaleOrder.RefreshData()
    '        ExpandDetailsT(GVSaleOrder)
    '        GVSaleOrder.ExpandAllGroups()
    '        CalForSumAmtSale()

    '    End If
    'End Sub

    Private Sub rptDelDt_Click(sender As Object, e As EventArgs) Handles rptDelDt.Click
        Dim detailView As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(GCLotFIFO.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        If detailView Is Nothing Then Exit Sub

        ' 1. จดจำสถานะ (ทำก่อน Refresh)
        Dim expandedKeys As New List(Of Object)
        For i As Integer = 0 To GVSaleOrder.DataRowCount - 1
            If GVSaleOrder.GetMasterRowExpanded(i) Then
                Dim val = GVSaleOrder.GetRowCellValue(i, "idSaleOrderDt")
                If val IsNot Nothing AndAlso Not IsDBNull(val) Then
                    expandedKeys.Add(val)
                End If
            End If
        Next

        Dim result As DialogResult = MessageBox.Show("คุณต้องการลบ Lot No. นี้ใช่หรือไม่", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.OK Then
            ' 2. ลบข้อมูลตามปกติ
            detailView.DeleteRow(detailView.FocusedRowHandle)
            ds_Right.AcceptChanges()

            ' 3. Refresh ข้อมูล (จังหวะนี้มันจะหุบช่างมัน)
            GVLotSale.RefreshData()
            GVSaleOrder.RefreshData()
            CalForSumAmtSale()

            ' 4. **ไม้ตาย** สั่งให้มันกางออก "หลังจาก" หน้าจอวาดเสร็จแล้ว (ใช้ BeginInvoke)
            ' สั่งกางคืน (ใช้ไม้ตาย BeginInvoke)
            Me.BeginInvoke(New Action(Sub()
                                          GVSaleOrder.BeginUpdate()
                                          Try
                                              For Each k As Integer In expandedKeys
                                                  Dim rowHdl As Integer = GVSaleOrder.LocateByValue("idSaleOrderDt", k)
                                                  If rowHdl <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                                                      GVSaleOrder.SetMasterRowExpanded(rowHdl, True)
                                                  End If
                                              Next
                                          Finally
                                              GVSaleOrder.EndUpdate()
                                          End Try
                                      End Sub))
        End If
    End Sub
    ' --- เก็บค่า "จำนวนขาย" เดิมก่อนเริ่มแก้ไข เพื่อใช้ย้อนกลับเมื่อขายเกินจำนวนสั่งซื้อ ---
    Private _oldAmtCut As Object = Nothing
    Private _oldAmtCutRow As DataRow = Nothing
    Private _revertingAmtCut As Boolean = False

    ' ย้อนค่าจำนวนขายของแถวที่แก้ กลับเป็นค่าเดิมก่อนแก้ไข (ไม่ให้ CellValueChanged ตรวจซ้ำ)
    Private Sub RevertAmtCut(ByVal gv As GridView, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs, ByVal drLot As DataRow)
        Dim oldVal As Object = 0.0
        If _oldAmtCutRow Is drLot AndAlso _oldAmtCut IsNot Nothing AndAlso Not IsDBNull(_oldAmtCut) Then
            oldVal = _oldAmtCut
        End If

        _revertingAmtCut = True
        Try
            gv.SetRowCellValue(e.RowHandle, e.Column, oldVal)
        Finally
            _revertingAmtCut = False
        End Try
    End Sub

    Private Sub GVLotSale_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GVLotSale.ShowingEditor
        Dim gv As GridView = CType(sender, GridView)
        If gv.FocusedColumn IsNot Nothing AndAlso gv.FocusedColumn.FieldName = "AmountCut" Then
            _oldAmtCutRow = gv.GetDataRow(gv.FocusedRowHandle)
            _oldAmtCut = gv.GetFocusedRowCellValue("AmountCut")
        End If
    End Sub

    Private Sub GVLotSale_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVLotSale.CellValueChanged
        If stLoad = 1 Then
            ' ===== ตรวจสอบ: จำนวนขายรวมของรายการสั่งซื้อ ต้องไม่เกินจำนวนสั่งซื้อ =====
            If _revertingAmtCut Then Exit Sub   ' กำลังย้อนค่ากลับ ไม่ต้องตรวจซ้ำ

            If e.Column IsNot Nothing AndAlso e.Column.FieldName = "AmountCut" Then
                Dim gvCur As GridView = CType(sender, GridView)
                Dim drLot As DataRow = gvCur.GetDataRow(e.RowHandle)

                ' ===== ตรวจสอบ: จำนวนขายของ Lot ต้องไม่เกินจำนวนคงเหลือในสต๊อก (AmtBal) =====
                If drLot IsNot Nothing AndAlso Not IsDBNull(drLot.Item("AmtBal")) Then
                    Dim amtBal As Double = CDbl(drLot.Item("AmtBal"))
                    Dim amtNew As Double = If(IsDBNull(drLot.Item("AmountCut")), 0, CDbl(drLot.Item("AmountCut")))

                    If Math.Round(amtNew - amtBal, 6) > 0 Then
                        RevertAmtCut(gvCur, e, drLot)
                        MessageBox.Show("Lot No." & CStr(drLot.Item("LotNo")) & vbNewLine &
                                        "มีจำนวนขาย : " & Format(amtNew, "#,##0.00") & " " & drLot.Item("UnitNameBal") & vbNewLine &
                                        "แต่จำนวน Stock คงเหลือ : " & Format(amtBal, "#,##0.00") & " " & drLot.Item("UnitNameBal") & vbNewLine &
                                        "Stock ไม่เพียงพอสำหรับการขาย ระบบจึงไม่สามารถทำรายการต่อได้",
                                        "แจ้งเตือน Stock ไม่เพียงพอสำหรับขาย", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        Exit Sub
                    End If
                End If

                If drLot IsNot Nothing AndAlso Not IsDBNull(drLot.Item("idSaleOrderDt")) Then
                    Dim idDt As Integer = CInt(drLot.Item("idSaleOrderDt"))
                    Dim drOrders() As DataRow = ds_Right.Tables("OrderDt").Select("idSaleOrderDt = " & idDt)

                    If drOrders.Length > 0 AndAlso Not IsDBNull(drOrders(0).Item("AmtOrder")) Then
                        Dim amtOrder As Double = CDbl(drOrders(0).Item("AmtOrder"))
                        Dim obSum As Object = ds_Right.Tables("idLot").Compute("Sum(AmountCut)", "idSaleOrderDt = " & idDt)
                        Dim sumSale As Double = If(IsDBNull(obSum), 0, CDbl(obSum))

                        If Math.Round(sumSale - amtOrder, 6) > 0 Then
                            RevertAmtCut(gvCur, e, drLot)

                            MessageBox.Show("สินค้า : " & CStr(drOrders(0).Item("InvName")) & vbNewLine &
                                            "มีจำนวนขายรวม : " & Format(sumSale, "#,##0.00") & " " & drOrders(0).Item("UnitName") & vbNewLine &
                                            "แต่จำนวนสั่งซื้อ : " & Format(amtOrder, "#,##0.00") & " " & drOrders(0).Item("UnitName") & vbNewLine &
                                            "จำนวนขายมากกว่าจำนวนสั่งซื้อ ระบบจึงไม่สามารถทำรายการต่อได้",
                                            "แจ้งเตือนจำนวนขายเกินจำนวนสั่งซื้อ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End If
                End If
            End If

            ' 1. ประกาศตัวแปร List เพื่อเก็บ ID ของแถวที่กางอยู่ (ต้องประกาศไว้ตรงนี้!)
            Dim expandedKeys As New List(Of Object)

            ' วนลูปเก็บ ID ของทุก Master Row ที่กางอยู่ ณ ตอนนี้
            For i As Integer = 0 To GVSaleOrder.DataRowCount - 1
                If GVSaleOrder.GetMasterRowExpanded(i) Then
                    ' ใช้ Field "idSaleOrderDt" เป็น Key ในการจำ
                    Dim id As Object = GVSaleOrder.GetRowCellValue(i, "idSaleOrderDt")
                    If id IsNot Nothing Then expandedKeys.Add(id)
                End If
            Next

            ' 2. เรียกฟังก์ชันเพิ่ม Lot หรือ Refresh ข้อมูลของเพื่อน
            CalForSumAmtSale()

            ' 3. สั่งกางคืน (ใช้ BeginInvoke เพื่อรอให้ UI วาดข้อมูลใหม่เสร็จก่อน)
            Me.BeginInvoke(Sub()
                               ' ใช้ BeginUpdate เพื่อกันจอกระตุก
                               GVSaleOrder.BeginUpdate()
                               Try
                                   ' ตอนนี้ expandedKeys จะถูกส่งต่อเข้ามาใน Sub นี้ได้โดยไม่ Error
                                   For Each key As Integer In expandedKeys
                                       ' หาตำแหน่ง Row ใหม่หลังจาก Refresh
                                       Dim handle As Integer = GVSaleOrder.LocateByValue("idSaleOrderDt", key)

                                       ' ถ้าเจอ Row เดิม ให้สั่งกางออก
                                       If handle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                                           GVSaleOrder.SetMasterRowExpanded(handle, True)
                                       End If
                                   Next
                               Finally
                                   GVSaleOrder.EndUpdate()
                               End Try
                           End Sub)
        End If
    End Sub
    Private Sub rptAddLot_KeyDown(sender As Object, e As KeyEventArgs) Handles rptAddLot.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.Enter Then

            ' 1. ประกาศตัวแปร List เพื่อเก็บ ID ของแถวที่กางอยู่ (ต้องประกาศไว้ตรงนี้!)
            Dim expandedKeys As New List(Of Object)

            ' วนลูปเก็บ ID ของทุก Master Row ที่กางอยู่ ณ ตอนนี้
            For i As Integer = 0 To GVSaleOrder.DataRowCount - 1
                If GVSaleOrder.GetMasterRowExpanded(i) Then
                    ' ใช้ Field "idSaleOrderDt" เป็น Key ในการจำ
                    Dim id As Object = GVSaleOrder.GetRowCellValue(i, "idSaleOrderDt")
                    If id IsNot Nothing Then expandedKeys.Add(id)
                End If
            Next

            ' 2. เรียกฟังก์ชันเพิ่ม Lot หรือ Refresh ข้อมูลของเพื่อน
            fnAddLotBySelf()

            ' 3. สั่งกางคืน (ใช้ BeginInvoke เพื่อรอให้ UI วาดข้อมูลใหม่เสร็จก่อน)
            Me.BeginInvoke(Sub()
                               ' ใช้ BeginUpdate เพื่อกันจอกระตุก
                               GVSaleOrder.BeginUpdate()
                               Try
                                   ' ตอนนี้ expandedKeys จะถูกส่งต่อเข้ามาใน Sub นี้ได้โดยไม่ Error
                                   For Each key As Integer In expandedKeys
                                       ' หาตำแหน่ง Row ใหม่หลังจาก Refresh
                                       Dim handle As Integer = GVSaleOrder.LocateByValue("idSaleOrderDt", key)

                                       ' ถ้าเจอ Row เดิม ให้สั่งกางออก
                                       If handle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                                           GVSaleOrder.SetMasterRowExpanded(handle, True)
                                       End If
                                   Next
                               Finally
                                   GVSaleOrder.EndUpdate()
                               End Try
                           End Sub)

            Dim currentHandle As Integer = GVSaleOrder.FocusedRowHandle
            If currentHandle >= 0 Then
                ' สั่งให้ Grid กางรายการลูก (Detail) ของแถวนี้ออกมา
                GVSaleOrder.SetMasterRowExpanded(currentHandle, True)

                ' (เสริม) ถ้าอยากให้มันเลื่อนหน้าจอไปโฟกัสที่รายการลูกที่เพิ่งเพิ่มมาด้วย
                GVSaleOrder.FocusedRowHandle = currentHandle
            End If

        End If
    End Sub
    Private Sub rptDelMt_Click(sender As Object, e As EventArgs) Handles rptDelMt.Click

        ' เมื่อคลิกปุ่มลบที่ Grid ฝั่งขวา (ระดับ Lot)
        If MessageBox.Show("คุณต้องการลบ Lot No. นี้ใช่หรือไม่", "SAM System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

            ' 1. ประกาศตัวแปร List เพื่อเก็บ ID ของแถวที่กางอยู่ (ต้องประกาศไว้ตรงนี้!)
            Dim expandedKeys As New List(Of Object)

            ' วนลูปเก็บ ID ของทุก Master Row ที่กางอยู่ ณ ตอนนี้
            For i As Integer = 0 To GVSaleOrder.DataRowCount - 1
                If GVSaleOrder.GetMasterRowExpanded(i) Then
                    ' ใช้ Field "idSaleOrderDt" เป็น Key ในการจำ
                    Dim id As Object = GVSaleOrder.GetRowCellValue(i, "idSaleOrderDt")
                    If id IsNot Nothing Then expandedKeys.Add(id)
                End If
            Next

            ' 1. เข้าถึง Row ของ Lot ที่กำลังจะลบ (ฝั่งขวา)
            Dim viewLotRight As GridView = TryCast(GCLotFIFO.FocusedView, GridView)
            Dim drRemoved As DataRow = viewLotRight.GetDataRow(viewLotRight.FocusedRowHandle)

            If drRemoved IsNot Nothing Then
                ' 2. ไปค้นหา Row ใน SmSaleOrderDt (DataTable ฝั่งซ้าย)
                ' เพื่อคืนค่ายอดที่เลือกไปแล้วกลับมา
                Dim drLeftItems As DataRow() = ds_Left.Tables("SmSaleOrderMt").Select("idSaleOrder = " & drRemoved.Item("idSaleOrder"))

                If drLeftItems.Length > 0 Then
                    ' 2. ถ้ามีหัวอยู่แล้ว สร้าง Row ลูกใหม่ยัดเข้า SmSaleOrderDt
                    Dim drNewDt As DataRow = ds_Left.Tables("SmSaleOrderDt").NewRow()

                    ' 3. ก๊อปปี้ค่ากลับไปให้ครบตามโครงสร้างเดิม
                    drNewDt("idSaleOrder") = drRemoved.Item("idSaleOrder") ' สำคัญมาก! ต้องตรงกันเพื่อให้ Relation ผูกติด
                    drNewDt("idSaleOrderDt") = drRemoved("idSaleOrderDt")
                    drNewDt("DocCode") = drRemoved("DocCode")
                    drNewDt("DocRef") = drRemoved("DocRef")
                    drNewDt("DateTsD") = drRemoved("DateTsD")
                    drNewDt("TimeTs") = drRemoved("TimeTs")
                    drNewDt("NoteOrder") = drRemoved("NoteOrder")
                    drNewDt("PsSale") = drRemoved("PsSale")

                    drNewDt("PdCode") = drRemoved("PdCode")
                    drNewDt("InvName") = drRemoved("InvName")
                    drNewDt("idInvMain") = drRemoved("idInvMain")
                    drNewDt("UnitName") = drRemoved("UnitName")
                    drNewDt("idUnit") = drRemoved("idUnit")
                    drNewDt("AmtOrder") = drRemoved("AmtOrder")
                    drNewDt("idInvGroup") = drRemoved.Item("idInvGroup")
                    drNewDt("idSubType") = drRemoved.Item("idSubType")
                    drNewDt("PriceWholesale_fg") = drRemoved.Item("PriceWholesale_fg")
                    drNewDt("PriceRetail_fg") = drRemoved.Item("PriceRetail_fg")
                    drNewDt("PriceBill_fg") = drRemoved.Item("PriceBill_fg")
                    drNewDt("idPdoType") = drRemoved.Item("idPdoType")
                    drNewDt("CreditThirty_pdo") = drRemoved.Item("CreditThirty_pdo")
                    drNewDt("CreditSixty_pdo") = drRemoved.Item("CreditSixty_pdo")
                    drNewDt("PricePdo_pdo") = drRemoved.Item("PricePdo_pdo")
                    drNewDt("PriceSeed") = drRemoved.Item("PriceSeed")
                    drNewDt("DtType") = drRemoved.Item("DtType")
                    drNewDt("pWeight") = drRemoved.Item("pWeight")
                    drNewDt("idUnitW") = drRemoved.Item("idUnitW")
                    drNewDt("WPerPack") = drRemoved.Item("WPerPack")
                    drNewDt("idCusRefAddr") = drRemoved.Item("idCusRefAddr")

                    ' 4. Add กลับเข้าตารางลูกฝั่งซ้าย
                    ds_Left.Tables("SmSaleOrderDt").Rows.Add(drNewDt)
                    ds_Left.Tables("SmSaleOrderDt").AcceptChanges()
                Else
                    'ถ้าไม่มี ให้สร้าง SmSaleOrderMt ก่อน แล้วยัดลูก
                    Dim drNewMt As DataRow = ds_Left.Tables("SmSaleOrderMt").NewRow()
                    drNewMt("idSaleOrder") = drRemoved.Item("idSaleOrder") ' สำคัญมาก! ต้องตรงกันเพื่อให้ Relation ผูกติด
                    drNewMt("DocCode") = drRemoved("DocCode")
                    drNewMt("DocRef") = drRemoved("DocRef")
                    drNewMt("DateTsD") = drRemoved("DateTsD")
                    drNewMt("TimeTs") = drRemoved("TimeTs")
                    drNewMt("NoteOrder") = drRemoved("NoteOrder")
                    drNewMt("PsSale") = drRemoved("PsSale")

                    ds_Left.Tables("SmSaleOrderMt").Rows.Add(drNewMt)
                    ds_Left.Tables("SmSaleOrderMt").AcceptChanges()


                    ' 2. ถ้ามีหัวอยู่แล้ว สร้าง Row ลูกใหม่ยัดเข้า SmSaleOrderDt
                    Dim drNewDt As DataRow = ds_Left.Tables("SmSaleOrderDt").NewRow()
                    ' 3. ก๊อปปี้ค่ากลับไปให้ครบตามโครงสร้างเดิม
                    drNewDt("idSaleOrder") = drRemoved.Item("idSaleOrder") ' สำคัญมาก! ต้องตรงกันเพื่อให้ Relation ผูกติด
                    drNewDt("idSaleOrderDt") = drRemoved("idSaleOrderDt")
                    drNewDt("DocCode") = drRemoved("DocCode")
                    drNewDt("DocRef") = drRemoved("DocRef")
                    drNewDt("DateTsD") = drRemoved("DateTsD")
                    drNewDt("TimeTs") = drRemoved("TimeTs")
                    drNewDt("NoteOrder") = drRemoved("NoteOrder")
                    drNewDt("PsSale") = drRemoved("PsSale")
                    drNewDt("PdCode") = drRemoved("PdCode")
                    drNewDt("InvName") = drRemoved("InvName")
                    drNewDt("idInvMain") = drRemoved("idInvMain")
                    drNewDt("UnitName") = drRemoved("UnitName")
                    drNewDt("idUnit") = drRemoved("idUnit")
                    drNewDt("AmtOrder") = drRemoved("AmtOrder")
                    drNewDt("idInvGroup") = drRemoved.Item("idInvGroup")
                    drNewDt("idSubType") = drRemoved.Item("idSubType")
                    drNewDt("PriceWholesale_fg") = drRemoved.Item("PriceWholesale_fg")
                    drNewDt("PriceRetail_fg") = drRemoved.Item("PriceRetail_fg")
                    drNewDt("PriceBill_fg") = drRemoved.Item("PriceBill_fg")
                    drNewDt("idPdoType") = drRemoved.Item("idPdoType")
                    drNewDt("CreditThirty_pdo") = drRemoved.Item("CreditThirty_pdo")
                    drNewDt("CreditSixty_pdo") = drRemoved.Item("CreditSixty_pdo")
                    drNewDt("PricePdo_pdo") = drRemoved.Item("PricePdo_pdo")
                    drNewDt("PriceSeed") = drRemoved.Item("PriceSeed")
                    drNewDt("DtType") = drRemoved.Item("DtType")
                    drNewDt("pWeight") = drRemoved.Item("pWeight")
                    drNewDt("idUnitW") = drRemoved.Item("idUnitW")
                    drNewDt("WPerPack") = drRemoved.Item("WPerPack")
                    drNewDt("idCusRefAddr") = drRemoved.Item("idCusRefAddr")
                    ' 4. Add กลับเข้าตารางลูกฝั่งซ้าย
                    ds_Left.Tables("SmSaleOrderDt").Rows.Add(drNewDt)
                    ds_Left.Tables("SmSaleOrderDt").AcceptChanges()
                End If

                ' 4. ลบแถว Lot นี้ออกจากฝั่งขวา
                drRemoved.Delete()

                ' 6. Refresh ทั้ง 2 ฝั่งเพื่อให้ตัวเลขหน้าจออัปเดต
                GCLotFIFO.RefreshDataSource()
                GCOrder.RefreshDataSource()

                GVLotSale.RefreshData()

                'ExpandDetailsT(GVSaleOrder)
                CalForSumAmtSale()
                GVOrderMt.RefreshData()


                txtCountLot.Text = Format(GVSaleOrder.DataRowCount, "#,##0")
                txtCount.Text = Format(GVOrderMt.DataRowCount, "#,##0")

                If GVSaleOrder.DataRowCount = 0 Then
                    btnBack.Enabled = False
                Else
                    btnBack.Enabled = True
                End If


                ' 3. สั่งกางคืน (ใช้ BeginInvoke เพื่อรอให้ UI วาดข้อมูลใหม่เสร็จก่อน)
                Me.BeginInvoke(Sub()
                                   ' ใช้ BeginUpdate เพื่อกันจอกระตุก
                                   GVSaleOrder.BeginUpdate()
                                   Try
                                       ' ตอนนี้ expandedKeys จะถูกส่งต่อเข้ามาใน Sub นี้ได้โดยไม่ Error
                                       For Each key As Integer In expandedKeys
                                           ' หาตำแหน่ง Row ใหม่หลังจาก Refresh
                                           Dim handle As Integer = GVSaleOrder.LocateByValue("idSaleOrderDt", key)

                                           ' ถ้าเจอ Row เดิม ให้สั่งกางออก
                                           If handle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                                               GVSaleOrder.SetMasterRowExpanded(handle, True)
                                           End If
                                       Next
                                   Finally
                                       GVSaleOrder.EndUpdate()
                                   End Try
                               End Sub)


            End If
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        If dtOrderLot.Rows.Count = 0 Then
            MessageBox.Show("กรุณาเลือก Lot เพื่อขายสินค้าอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For i As Integer = 0 To dtOrderMain.Rows.Count - 1
            Dim drMain As DataRow = dtOrderMain.Rows(i)

            Dim dv As New DataView(dtOrderLot)
            dv.RowFilter = "idSaleOrderDt = " & drMain.Item("idSaleOrderDt")

            For j As Integer = 0 To dv.Count - 1
                Dim drBack As DataRow = MainReturn.NewRow
                '---Main
                drBack("idSaleOrderDt") = drMain.Item("idSaleOrderDt")
                drBack("idInvMain") = drMain.Item("idInvMain")
                drBack("idInvGroup") = drMain.Item("idInvGroup")
                drBack("ProductName") = drMain.Item("InvName")
                drBack("idSubType") = drMain.Item("idSubType")
                drBack("PdCode") = drMain.Item("PdCode")
                drBack("CodeOrder") = drMain.Item("DocCode")
                drBack("AmtOrder") = drMain.Item("AmtOrder")
                drBack("PriceWholesale_fg") = drMain.Item("PriceWholesale_fg")
                drBack("PriceRetail_fg") = drMain.Item("PriceRetail_fg")
                drBack("PriceBill_fg") = drMain.Item("PriceBill_fg")
                drBack("idPdoType") = drMain.Item("idPdoType")
                drBack("CreditThirty_pdo") = drMain.Item("CreditThirty_pdo")
                drBack("CreditSixty_pdo") = drMain.Item("CreditSixty_pdo")
                drBack("PricePdo_pdo") = drMain.Item("PricePdo_pdo")
                drBack("PriceSeed") = drMain.Item("PriceSeed")
                drBack("DtType") = drMain.Item("DtType")
                drBack("idCusRefAddr") = drMain.Item("idCusRefAddr")
                drBack("idType") = drMain.Item("idType")

                If drMain.Item("idInvGroup") = 2 Then
                    drBack("pWeight") = drMain.Item("pWeight")
                    drBack("idUnitW") = drMain.Item("idUnitW")
                ElseIf drMain.Item("idInvGroup") = 42 Then
                    drBack("pWeight") = drMain.Item("WPerPack")
                    drBack("idUnitW") = 1
                End If

                '---Lot
                drBack("idLot") = dv.Item(j).Item("idLot")
                drBack("LotNo") = dv.Item(j).Item("LotNo")
                drBack("AmtStock") = dv.Item(j).Item("AmtBal")
                drBack("AmtSale") = dv.Item(j).Item("AmountCut")
                drBack("UnitName") = dv.Item(j).Item("UnitNameBal")
                drBack("idUnit") = dv.Item(j).Item("idUnitBal")
                drBack("idLotSPM") = dv.Item(j).Item("idLotSPM")
                drBack("full_lock") = dv.Item(j).Item("WareHouseName")
                drBack("idRefLot") = dv.Item(j).Item("idRefLot")
                drBack("idWh") = dv.Item(j).Item("idWh")
                drBack("idLotSPM") = dv.Item(j).Item("idLotSPM")
                drBack("CompRec") = dv.Item(j).Item("CompRec")

                MainReturn.Rows.Add(drBack)
            Next
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub
    Private Sub FilterDataOnGrid()
        Dim StrFilter = " 1=1 "

        If cbOrderNo.Checked = True And txtOrderNo.Text.Trim <> "" Then
            StrFilter &= " AND [DocCode] Like '%" & txtOrderNo.Text.Trim & "%'"
        End If

        If cbDocRef.Checked = True And txtDocRef.Text.Trim <> "" Then
            StrFilter &= " AND [DocRef] Like '%" & txtDocRef.Text.Trim & "%'"
        End If


        GVOrderMt.ActiveFilterString = StrFilter
        GVOrderMt.ExpandAllGroups()
        txtCount.Text = Format(GVOrderMt.DataRowCount, "#,##0")
    End Sub
    Private Sub txtInvName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDocRef.KeyDown, txtOrderNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            FilterDataOnGrid()
        End If
    End Sub
    Private Sub cbDocRef_CheckedChanged(sender As Object, e As EventArgs) Handles cbDocRef.CheckedChanged
        If stLoad = 1 Then
            If cbDocRef.Checked = True Then
                txtDocRef.Enabled = True
                txtDocRef.Focus()
            Else
                txtDocRef.Enabled = False
                txtDocRef.Text = ""
            End If
        End If
    End Sub
    Private Sub cbOrderNo_CheckedChanged(sender As Object, e As EventArgs) Handles cbOrderNo.CheckedChanged
        If stLoad = 1 Then
            If cbOrderNo.Checked = True Then
                txtOrderNo.Enabled = True
            Else
                txtOrderNo.Enabled = False
                txtOrderNo.Text = ""
            End If
        End If
    End Sub

    Private Sub rdb30_CheckedChanged(sender As Object, e As EventArgs) Handles rdb30.CheckedChanged
        If stLoad = 1 Then
            If rdb30.Checked = True Then
                dtStockTemp_EashDt.Clear()
                GCLotFIFO.DataSource = Nothing
                GCLotFIFO.DataSource = ds_Right.Tables("OrderDt")
                dtOrderLot.Clear()
                ds_Right.AcceptChanges()
                GVLotSale.RefreshData()

                mdCnOpen()
                mdLoadShow()
                For i As Integer = 0 To ds_Right.Tables("OrderDt").Rows.Count - 1
                    Dim dr As DataRow = ds_Right.Tables("OrderDt").Rows(i)

                    Dim CurrentidInvMain As Integer = CInt(dr.Item("idInvMain"))
                    ' 3. ถ้าสินค้าตัวนี้ยังไม่มีใน Temp ให้ไป Query มาครั้งเดียว
                    If Not dtStockTemp_EashDt.ContainsKey(CurrentidInvMain) Then
                        Dim dtNewStock As DataTable = fnQueryLotFIFO_ByProduct(dr.Item("idInvMain"), dr.Item("idSaleOrderDt"))
                        dtStockTemp_EashDt.Add(CurrentidInvMain, dtNewStock)
                    End If

                    ' 4. เรียกใช้ฟังก์ชันตัดยอด โดยส่ง DataTable Temp ไป
                    FIFOLotForSale(dr("idSaleOrderDt"), dr("AmtOrder"), dtStockTemp_EashDt(CurrentidInvMain))

                    CalForSumAmtSale()
                    GVSaleOrder.ExpandAllGroups()

                Next
                mdLoadCommitt()


                txtCount.Text = Format(GVOrderMt.DataRowCount, "#,##0")
                txtCountLot.Text = Format(GVSaleOrder.DataRowCount, "#,##0")
            End If
        End If
    End Sub
    Private Sub rdb60_CheckedChanged(sender As Object, e As EventArgs) Handles rdb60.CheckedChanged
        If stLoad = 1 Then
            If rdb60.Checked = True Then
                dtStockTemp_EashDt.Clear()
                GCLotFIFO.DataSource = Nothing
                GCLotFIFO.DataSource = ds_Right.Tables("OrderDt")
                dtOrderLot.Clear()
                ds_Right.AcceptChanges()
                GVLotSale.RefreshData()

                mdCnOpen()
                mdLoadShow()
                For i As Integer = 0 To ds_Right.Tables("OrderDt").Rows.Count - 1
                    Dim dr As DataRow = ds_Right.Tables("OrderDt").Rows(i)

                    Dim CurrentidInvMain As Integer = CInt(dr.Item("idInvMain"))
                    ' 3. ถ้าสินค้าตัวนี้ยังไม่มีใน Temp ให้ไป Query มาครั้งเดียว
                    If Not dtStockTemp_EashDt.ContainsKey(CurrentidInvMain) Then
                        Dim dtNewStock As DataTable = fnQueryLotFIFO_ByProduct(dr.Item("idInvMain"), dr.Item("idSaleOrderDt"))
                        dtStockTemp_EashDt.Add(CurrentidInvMain, dtNewStock)
                    End If

                    ' 4. เรียกใช้ฟังก์ชันตัดยอด โดยส่ง DataTable Temp ไป
                    FIFOLotForSale(dr("idSaleOrderDt"), dr("AmtOrder"), dtStockTemp_EashDt(CurrentidInvMain))

                    CalForSumAmtSale()
                    GVSaleOrder.ExpandAllGroups()
                Next
                mdLoadCommitt()

                txtCount.Text = Format(GVOrderMt.DataRowCount, "#,##0")
                txtCountLot.Text = Format(GVSaleOrder.DataRowCount, "#,##0")
            End If
        End If
    End Sub
    Private Sub rdb90_CheckedChanged(sender As Object, e As EventArgs) Handles rdb90.CheckedChanged
        If stLoad = 1 Then
            If rdb90.Checked = True Then
                dtStockTemp_EashDt.Clear()
                GCLotFIFO.DataSource = Nothing
                GCLotFIFO.DataSource = ds_Right.Tables("OrderDt")
                dtOrderLot.Clear()
                ds_Right.AcceptChanges()
                GVLotSale.RefreshData()


                mdCnOpen()
                mdLoadShow()
                For i As Integer = 0 To ds_Right.Tables("OrderDt").Rows.Count - 1
                    Dim dr As DataRow = ds_Right.Tables("OrderDt").Rows(i)

                    Dim CurrentidInvMain As Integer = CInt(dr.Item("idInvMain"))
                    ' 3. ถ้าสินค้าตัวนี้ยังไม่มีใน Temp ให้ไป Query มาครั้งเดียว
                    If Not dtStockTemp_EashDt.ContainsKey(CurrentidInvMain) Then
                        Dim dtNewStock As DataTable = fnQueryLotFIFO_ByProduct(dr.Item("idInvMain"), dr.Item("idSaleOrderDt"))
                        dtStockTemp_EashDt.Add(CurrentidInvMain, dtNewStock)
                    End If

                    ' 4. เรียกใช้ฟังก์ชันตัดยอด โดยส่ง DataTable Temp ไป
                    FIFOLotForSale(dr("idSaleOrderDt"), dr("AmtOrder"), dtStockTemp_EashDt(CurrentidInvMain))

                    CalForSumAmtSale()
                    GVSaleOrder.ExpandAllGroups()
                Next
                mdLoadCommitt()

                txtCount.Text = Format(GVOrderMt.DataRowCount, "#,##0")
                txtCountLot.Text = Format(GVSaleOrder.DataRowCount, "#,##0")
            End If
        End If
    End Sub

    Private Sub GVSaleOrder_DataSourceChanged(sender As Object, e As EventArgs) Handles GVSaleOrder.DataSourceChanged
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If view IsNot Nothing Then
            view.ExpandAllGroups()
        End If
    End Sub

End Class