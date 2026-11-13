Public Class FrmOrderWaitToSale
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim xProcess As eProcess
    Dim stLoad As Integer = 0
    Dim ds0 As New DataSet
    Enum eProcess
        eBillTs
        eMNBill
    End Enum

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        xProcess = aProcess
    End Sub

    Private Sub frmApvSaleReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpOrderS.Value = Date.Today
        dtpOrderE.Value = Date.Today
        dtpMonth.Value = Date.Today
        dtpYear.Value = Date.Today

        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()

        stLoad = 1

    End Sub

    Private Sub BindData()

        ds0 = New DataSet
        Dim vWhere As String = " WHERE sMt.idComp IN( " & SIdCompStr & ")"

        If xProcess = eProcess.eBillTs Then
            vWhere = vWhere & vbNewLine &
                     "AND sMt.idPsCancel Is NULL "
        End If

        Dim strDate As String = ""
        If rdbDateReturn.Checked = True Then
            strDate = "sMt.DateOrderD"
        ElseIf rdbDateTs.Checked = True Then
            strDate = "sMt.DateTsD"
        End If

        If Me.rdbDate.Checked = True Then

            Dim firstDate As DateTime = Convert.ToDateTime(dtpOrderS.Value, _cultureEnInfo)
            Dim lastDate As DateTime = Convert.ToDateTime(dtpOrderE.Value, _cultureEnInfo)

            vWhere = vWhere & " And " & strDate & " Between '" & firstDate.ToString("yyyy-MM-dd 00:00:00.000", _cultureEnInfo) & "' " &
                              "And '" & lastDate.ToString("yyyy-MM-dd 23:59:00.000", _cultureEnInfo) & "' "

        ElseIf Me.rdbMonth.Checked = True Then

            Dim sDateS As DateTime = Convert.ToDateTime(dtpMonth.Value, _cultureEnInfo)
            Dim sMonthS As Integer = sDateS.Month
            Dim sYearY As Integer = sDateS.Year

            vWhere = vWhere & " AND YEAR(" & strDate & ") = " & sYearY & "AND MONTH(" & strDate & ") = " & sMonthS

        ElseIf Me.rdbYear.Checked = True Then
            Dim sDateY As DateTime = Convert.ToDateTime(dtpYear.Value, _cultureEnInfo)
            Dim sYearY As Integer = sDateY.Year
            vWhere = vWhere & " AND YEAR(" & strDate & ") = " & sYearY

        End If


        Dim MainDt As New DataTable  ' SaleReturnMt
        Dim SubDt As New DataTable  ' SaleReturnDt

        sCommand.CommandText = "SELECT wMt.idWaitCutMt, sMt.idComp, sMt.idSaleOrder, PsTs.PsName As PsTsName, sMt.idPsSale, PsSale.PsName As PsSaleName, " & vbNewLine &
                                "sMt.idComp, comp.CompCode,  PsCC.PsName As PsCancel, sMt.CancelNote, c.Note As NoteCus," & vbNewLine &
                                "ISNULL(sMt.idCusRefAddr,0) As idCusRefAddr, ISNULL(p.idCus,0) As idCus,  " & vbNewLine &
                                "sMt.DocCode, sMt.idPartner, p.PartnerName, sMt.DateOrderD, ISNULL(sMt.DocRef, '-') As DocRef, sMt.DateTsD," & vbNewLine &
                                "IsNULL(c.idComp, 0) As stASG, ISNULL(se.AddressS, p.pAddress ) As AddressS, ISNULL(c.idRefAdrS,0) As idRefAdrS," & vbNewLine &
                                "IsNULL(p.pAddress,'') As Address, ISNULL(se.PsRecName, '') As PsRecName, ISNULL(se.idTsp,0) AS idTspS, ISNULL(se.idPayTsp, 1) AS idPayTspS," & vbNewLine &
                                "ISNULL(se.idSupTsp,0) AS idSupTspS, ISNULL(sup.SupName,'') AS SupNameS" & vbNewLine &
                                "FROM WimWaitCutMt wMt" & vbNewLine &
                                "LEFT JOIN SmSaleOrderMt sMt ON wMt.idMt = sMt.idSaleOrder" & vbNewLine &
                                "LEFT JOIN dPartner p On sMt.idPartner = p.idPartner" & vbNewLine &
                                "LEFT JOIN dCustomer c On p.idCus = c.idCus" & vbNewLine &
                                "LEFT JOIN dCustomerAdrSent As se On c.idRefAdrS = se.idCusRefAddr " & vbNewLine &
                                "LEFT JOIN PchInvAndProject.dbo.dSupplier As sup ON se.idSupTsp = sup.idSup" & vbNewLine &
                                "LEFT JOIN vPerSonxselect PsTs On sMt.idPsTs = PsTs.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect PsSale On sMt.idPsSale = PsSale.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect PsCC On sMt.idPsCancel = PsCC.idPs" & vbNewLine &
                                "LEFT JOIN PchInvAndProject.dbo.dCompany As comp On sMt.idComp = comp.idComp  " & vbNewLine &
                                vWhere & vbNewLine &
                                "AND wMt.ProcessName = 'Order รอเปิดบิลขาย' " & vbNewLine &
                                "AND sMt.idPsCancel Is NULL " & vbNewLine &
                                "Order by sMt.DocCode DESC"


        sAdapter.Fill(MainDt)
        MainDt.TableName = "WimWaitCutMt"
        MainDt.Columns.Add("ChkKey", System.Type.GetType("System.Boolean"))

        For i As Integer = 0 To MainDt.Rows.Count - 1
            MainDt.Rows(i).Item("ChkKey") = False
        Next

        Dim tempDt As New DataTable

        sCommand.CommandText = "Select lb.idLotBook, sMt.idSaleOrder, dt.idWaitCutDt, dt.idInvMain, inv.InvName, dt.AmountWait As AmtSale, sDt.Price, sDt.idUnit," & vbNewLine &
                                "lb.Amount As AmtOrder, dt.idLot, lm.LotNo, u.UnitName, devsk.StrWareHouse(dt.idWh,'') As WareHouseName," & vbNewLine &
                                "ISNULL(dt.idRefLot,0) As idRefLot, lb.idSaleOrderDt, ISNULL(ig.DtType,0) As DtType," & vbNewLine &
                                "inv.idInvGroup, inv.InvCode, sMt.DocCode As CodeOrder, lm.CompRec, swh.full_lock, wh.idWh, wh.Amount As AmtStock," & vbNewLine &
                                "u.UnitName" & vbNewLine &
                                "FROM WimWaitCutDt dt" & vbNewLine &
                                "LEFT JOIN WimWaitCutMt mt ON dt.idWaitCutMt = mt.idWaitCutMt" & vbNewLine &
                                "LEFT JOIN SmSaleOrderLotBook lb ON dt.idDtRef = lb.idLotBook" & vbNewLine &
                                "LEFT JOIN SmSaleOrderDt sDt ON lb.idSaleOrderDt = sDt.idSaleOrderDt" & vbNewLine &
                                "LEFT JOIN dInventoryMain inv ON dt.idInvMain = inv.idInvMain" & vbNewLine &
                                "LEFT JOIN dInvGroup ig ON inv.idInvGroup = ig.idInvGroup" & vbNewLine &
                                "LEFT JOIN dInvUnit u ON sDt.idUnit= u.idUnit" & vbNewLine &
                                "LEFT JOIN dInvLotMain lm ON dt.idLot = lm.idLot" & vbNewLine &
                                "LEFT JOIN dInvLotRefWh wh ON dt.idRefLot = wh.idRefLot" & vbNewLine &
                                "LEFT JOIN SmSaleOrderMt sMt ON sDt.idSaleOrder = sMt.idSaleOrder " & vbNewLine &
                                "LEFT JOIN SsWareHouse swh ON wh.idWh = swh.idWh" & vbNewLine &
                                 vWhere & vbNewLine &
                                 "AND mt.ProcessName = 'Order รอเปิดบิลขาย' " & vbNewLine &
                                "AND sMt.idPsCancel Is NULL "

        sAdapter.Fill(tempDt)
        tempDt.TableName = "WimWaitCutDt"


        ds0.Tables.Clear()
        ds0.Tables.Add(MainDt)
        ds0.Tables.Add(tempDt)

        Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idSaleOrder")
        Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idSaleOrder")

        ds0.Relations.Add("รายการ", keyColumn, foreignColumn)

        If ds0.Tables(0).Rows.Count <= 0 Then
            MessageBox.Show("ไม่พบข้อมูลออเดอร์รอเปิดบิลขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        GCWaitOrderToBill.DataSource = ds0.Tables(0)
        GCWaitOrderToBill.ForceInitialize()

        GCWaitOrderToBill.LevelTree.Nodes.Add("รายการ", GVSmSaleOrderDt)

        txtCount.Text = Format(GVSmSaleOrderMt.DataRowCount, "#,##0")

    End Sub

    Private Sub GVReturnMt_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVSmSaleOrderMt.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNumMt" Then

            e.DisplayText = (e.RowHandle + 1).ToString

        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub rdbMonthNow_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMonth.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbMonth.Checked = True Then
                Me.dtpMonth.Enabled = True
            Else
                Me.dtpMonth.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbYear_CheckedChanged(sender As Object, e As EventArgs) Handles rdbYear.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbYear.Checked = True Then
                Me.dtpYear.Enabled = True
            Else
                Me.dtpYear.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbDate_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDate.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbDate.Checked = True Then
                Me.dtpOrderS.Enabled = True
                Me.dtpOrderE.Enabled = True
            Else
                Me.dtpOrderS.Enabled = False
                Me.dtpOrderE.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbDateReturn_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDateReturn.CheckedChanged
        If stLoad = 1 Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub rdbDateTs_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDateTs.CheckedChanged
        If stLoad = 1 Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub btnNewBill_Click(sender As Object, e As EventArgs) Handles btnNewBill.Click
        Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eAddCombine, 0, 0)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub rptCrateBill_Click(sender As Object, e As EventArgs) Handles rptCrateBill.Click
        Dim dr As DataRowView = GVSmSaleOrderMt.GetFocusedRow
        Dim drDetail() As DataRow = ds0.Tables("WimWaitCutDt").Select("idSaleOrder=" & dr.Item("idSaleOrder"))

        Dim vFrm As New frmSlSaleOrderToBill(frmSlSaleOrderToBill.eProcess.eWaitOrder, 0, 0, dr, drDetail)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub
End Class