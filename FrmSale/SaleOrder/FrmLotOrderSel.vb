Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmLotOrderSel

    Enum eProcess
        eLotFIFO
    End Enum
    Dim xProcess As eProcess
    Dim gidComp As Integer = 0
    Dim gOrderDt As New DataTable

    Dim dtOrderMain As New DataTable
    Dim dtOrderLot As New DataTable
    Dim ds As New DataSet
    Dim stLoad As Integer = 0
    Dim stShowMsgBox As Integer = 0
    Sub New(ByVal aProcess As eProcess, ByVal idComp As Integer, ByVal dtOrderDt As DataTable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        gidComp = idComp
        gOrderDt = dtOrderDt

        xProcess = aProcess
    End Sub

    Private Sub FrmLotOrderSel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtOrderMain.Rows.Clear()
        dtOrderLot.Rows.Clear()

        BuildColumns()

        mdCnOpen()
        For i As Integer = 0 To gOrderDt.Rows.Count - 1
            Dim dr1_ As DataRow = dtOrderMain.NewRow
            dr1_("idSaleOrderDt") = gOrderDt.Rows(i).Item("idSaleOrderDt")
            dr1_("DocCode") = gOrderDt.Rows(i).Item("DocCode")
            dr1_("idInvMain") = gOrderDt.Rows(i).Item("idInvMain")
            dr1_("InvName") = gOrderDt.Rows(i).Item("InvName")
            dr1_("AmtOrder") = gOrderDt.Rows(i).Item("AmtOrder")
            dr1_("UnitName") = gOrderDt.Rows(i).Item("UnitName")
            dr1_("idUnit") = gOrderDt.Rows(i).Item("idUnit")

            dtOrderMain.Rows.Add(dr1_)
        Next

        '--- AUTO SET LOT ---'
        FIFOLotForSale()
        ExpandDetailsT(GVSaleOrder)
        CalForSumAmtSale()
        stLoad = 1
    End Sub

    Private Sub CalForSumAmtSale()
        Dim dt As DataTable = ds.Tables("dt")

        GVLotSale.UpdateCurrentRow()

        For i As Integer = 0 To ds.Tables("mt").Rows.Count - 1
            Dim obAmt As Object
            If ds.Tables("mt").Rows(i).Item("idSaleOrderDt") <> 0 Then
                obAmt = ds.Tables("dt").Compute("Sum(AmountCut)", "idSaleOrderDt = " & ds.Tables("mt").Rows(i).Item("idSaleOrderDt"))
            End If

            'Dim amt As Double = If(IsDBNull(obAmt) = True, 0, CDbl(obAmt))
            ds.Tables("mt").Rows(i).Item("AmtSale") = If(IsDBNull(obAmt) = True, 0, CDbl(obAmt))
        Next
    End Sub
    Sub BuildColumns()
        dtOrderMain.Columns.Add("idSaleOrderDt", System.Type.GetType("System.Int32"))
        dtOrderMain.Columns.Add("DocCode", System.Type.GetType("System.String"))
        dtOrderMain.Columns.Add("idInvMain", System.Type.GetType("System.Int32"))
        dtOrderMain.Columns.Add("InvName", System.Type.GetType("System.String"))
        dtOrderMain.Columns.Add("AmtOrder", System.Type.GetType("System.Double"))
        dtOrderMain.Columns.Add("AmtSale", System.Type.GetType("System.Double"))
        dtOrderMain.Columns.Add("UnitName", System.Type.GetType("System.String"))
        dtOrderMain.Columns.Add("idUnit", System.Type.GetType("System.Int32"))
        dtOrderMain.TableName = "mt"
        ds.Tables.Add(dtOrderMain)

        dtOrderLot.Columns.Add("idSaleOrderDt", System.Type.GetType("System.Int32"))
        dtOrderLot.Columns.Add("idRefLot", System.Type.GetType("System.Int32"))
        dtOrderLot.Columns.Add("LotNo", System.Type.GetType("System.String"))
        dtOrderLot.Columns.Add("WareHouseName", System.Type.GetType("System.String"))
        dtOrderLot.Columns.Add("AmtBal", System.Type.GetType("System.Double"))
        dtOrderLot.Columns.Add("UnitNameBal", System.Type.GetType("System.String"))
        dtOrderLot.Columns.Add("AmountCut", System.Type.GetType("System.Double"))
        dtOrderLot.Columns.Add("idUnitBal", System.Type.GetType("System.Int32"))
        dtOrderLot.Columns.Add("DateGen", System.Type.GetType("System.DateTime"))
        dtOrderLot.Columns.Add("idLot", System.Type.GetType("System.Int32"))
        dtOrderLot.Columns.Add("PDAge", System.Type.GetType("System.String"))
        dtOrderLot.TableName = "dt"
        ds.Tables.Add(dtOrderLot)

        Dim keyColumn As DataColumn = ds.Tables("mt").Columns("idSaleOrderDt")
        Dim foreignColumn As DataColumn = ds.Tables("dt").Columns("idSaleOrderDt")
        ds.Relations.Add("Lot สำหรับขาย", keyColumn, foreignColumn)

        GCLotFIFO.DataSource = ds.Tables("mt")
        GCLotFIFO.ForceInitialize()
        GCLotFIFO.LevelTree.Nodes.Add("Lot สำหรับขาย", GVLotSale)
    End Sub

    Private Sub FIFOLotForSale()
        mdCnOpen()
        For i As Integer = 0 To dtOrderMain.Rows.Count - 1

            Dim dtLotFIFO As New DataTable

            Dim BoundDateGen As String = ""
            If rdb90.Checked = True Then
                BoundDateGen = "90"
            ElseIf rdb60.Checked = True Then
                BoundDateGen = "60"
            ElseIf rdb30.Checked = True Then
                BoundDateGen = "30"
            End If
            sCommand.CommandText = "Select w.idRefLot, lm.LotNo, s.full_lock As WareHouseName ,w.Amount As AmtBal,  lm.DateGen, u.UnitName As UnitNameBal, " & vbNewLine &
                                   "0 As AmountCut, lm.idLot, oDt.idSaleOrderDt, w.idUnit As idUnitBal, CONCAT(FORMAT(DATEDIFF(day, lm.DateGen, GETDATE()), '#,##0'),' วัน') AS PDAge" & vbNewLine &
                                   " --ConCat (CASE WHEN DATEPART(YEAR,  GETDATE() - lm.DateGen) > 1900 Then DATEPART(YEAR, GETDATE() - lm.DateGen) - 1900 ELSE 0 END , ' ปี '," & vbNewLine &
                                   "--Case WHEN DATEPART(MONTH,  GETDATE() - lm.DateGen) > 1 THEN DATEPART(MONTH,  GETDATE() - lm.DateGen) - 1 ELSE 0 END, ' เดือน '," & vbNewLine &
                                   "--CASE When DATEPART(DAY,  GETDATE()- lm.DateGen) > 1 Then DATEPART(DAY, GETDATE() - lm.DateGen) - 1 Else 0 End , ' วัน') As PDAge" & vbNewLine &
                                   "FROM devsk.vInvLotRefWh_RStock w" & vbNewLine &
                                   "LEFT JOIN dInvLotMain lm ON w.idLot = lm.idLot" & vbNewLine &
                                   "LEFT JOIN devsk.dInventoryMain i ON lm.idInvMain = i.idInvMain" & vbNewLine &
                                   "LEFT JOIN dbo.SmSaleOrderDt oDt On i.idInvMain = oDt.idInvMain" & vbNewLine &
                                   "LEFT JOIN dbo.SsWarehouse s ON w.idWh = s.idWh" & vbNewLine &
                                   "LEFT JOIN dInvUnit u On w.idUnit = u.idUnit" & vbNewLine &
                                   "WHERE w.Amount > 0 " & vbNewLine &
                                   "And lm.StDel Is NULL" & vbNewLine &
                                   "And lm.CompRec = " & gidComp & vbNewLine &
                                   "And oDt.idSaleOrderDt = " & gOrderDt.Rows(i).Item("idSaleOrderDt") & vbNewLine &
                                   "AND DATEDIFF(day, lm.DateGen, GETDATE()) <= " & BoundDateGen & vbNewLine &
                                   "Order by lm.DateGen DESC"
            sAdapter.Fill(dtLotFIFO)

            If dtLotFIFO.Rows.Count = 0 Then

                MessageBox.Show("สินค้านี้ไม่สามารถขายได้ เนื่องจาก " & gOrderDt.Rows(i).Item("InvName") & vbNewLine &
                                "ที่อายุสินค้าไม่เกิน " & BoundDateGen & " วัน ไม่มี Stock คงเหลือในระบบ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub
            Else
                '-- มี Lot สำหรับขายตามวันที่ผลิตที่เลือก --'
                Dim SumCut As Double = 0 'Sum จำนวนเบิกทุก Lot

                For j As Integer = 0 To dtLotFIFO.Rows.Count - 1
                    Dim AmtCutNow As Double = dtOrderMain.Rows(i).Item("AmtOrder") - SumCut

                    If dtOrderMain.Rows(i).Item("AmtOrder") > SumCut Then 'จำนวนสั่งซื้อ > จำนวนที่เบิก
                        Dim dr_ As DataRow = dtOrderLot.NewRow
                        dr_("idSaleOrderDt") = dtOrderMain.Rows(i).Item("idSaleOrderDt")
                        dr_("idRefLot") = dtLotFIFO.Rows(j).Item("idRefLot")
                        dr_("LotNo") = dtLotFIFO.Rows(j).Item("LotNo")
                        dr_("WareHouseName") = dtLotFIFO.Rows(j).Item("WareHouseName")
                        dr_("AmtBal") = dtLotFIFO.Rows(j).Item("AmtBal")
                        dr_("UnitNameBal") = dtLotFIFO.Rows(j).Item("UnitNameBal")
                        dr_("idUnitBal") = dtLotFIFO.Rows(j).Item("idUnitBal")
                        dr_("DateGen") = dtLotFIFO.Rows(j).Item("DateGen")
                        dr_("idLot") = dtLotFIFO.Rows(j).Item("idLot")
                        dr_("PDAge") = dtLotFIFO.Rows(j).Item("PDAge")

                        If AmtCutNow <= dtLotFIFO.Rows(j).Item("AmtBal") Then 'Stock เพียงพอต่อความต้องการใช้
                            dr_("AmountCut") = AmtCutNow
                            SumCut = SumCut + AmtCutNow
                        Else
                            dr_("AmountCut") = dtLotFIFO.Rows(j).Item("AmtBal")
                            SumCut = SumCut + dtLotFIFO.Rows(j).Item("AmtBal")
                        End If

                        dtOrderLot.Rows.Add(dr_)
                    End If

                Next
            End If
        Next
    End Sub
    Private Function ExpandDetailsT(ByVal gv As GridView)
        For i As Integer = 0 To gv.DataRowCount - 1
            gv.SetMasterRowExpanded(i, True)
        Next
        Return gv
    End Function

    Private Sub rdb60_CheckedChanged(sender As Object, e As EventArgs) Handles rdb60.CheckedChanged, rdb30.CheckedChanged, rdb90.CheckedChanged
        If stLoad = 1 Then
            GCLotFIFO.DataSource = Nothing
            GCLotFIFO.DataSource = ds.Tables("mt")

            ds.AcceptChanges()
            GVLotSale.RefreshData()

            FIFOLotForSale()
            CalForSumAmtSale()
        End If

    End Sub

    Private Sub rptAddLot_Click(sender As Object, e As EventArgs) Handles rptAddLot.Click
        fnAddLotBySelf()
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

        Dim vFrm As New frmLotSelect(frmLotSelect.eProcess.eSelectOrder, gidComp, "", "", dr.Item("idInvMain"), dr.Item("InvName"))
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim dtRefLot As DataTable = vFrm.dtLotReturn
            Dim SumCut As Double = 0



            For i As Integer = 0 To dtRefLot.Rows.Count - 1

                Dim obSumAmtCut As Object
                If ds.Tables("mt").Rows(i).Item("idSaleOrderDt") <> 0 Then
                    obSumAmtCut = ds.Tables("dt").Compute("Sum(AmountCut)", "idSaleOrderDt = " & dr.Item("idSaleOrderDt")) 'Sum จำนวนเบิกทุก Lot
                End If

                SumCut = If(IsDBNull(obSumAmtCut) = True, 0, CDbl(obSumAmtCut))

                Dim AmtCutNow As Double = dr.Item("AmtOrder") - SumCut

                If dr.Item("AmtOrder") > SumCut Then 'จำนวนสั่งซื้อ > จำนวนที่เบิก

                    Dim drn As DataRow = ds.Tables("dt").NewRow
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

                        If AmtCutNow <= dtRefLot.Rows(i).Item("AmtStock") Then 'Stock เพียงพอต่อความต้องการใช้
                            drn("AmountCut") = AmtCutNow
                            SumCut = SumCut + AmtCutNow
                        Else
                            drn("AmountCut") = dtRefLot.Rows(i).Item("AmtStock")
                            SumCut = SumCut + dtRefLot.Rows(i).Item("AmtStock")
                        End If

                    End With
                    ds.Tables("dt").Rows.Add(drn)
                Else
                    MessageBox.Show(dr.Item("InvName") & " ขายเกินจำนวนสั่งซื้อ กรุณาตรวจสอบ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

            Next

            GCLotFIFO.DataSource = Nothing
            GCLotFIFO.DataSource = ds.Tables("mt")
            ExpandDetailsT(GVSaleOrder)
            CalForSumAmtSale()
        End If

    End Sub
    Private Sub rptbtnDel_Click(sender As Object, e As EventArgs) Handles rptbtnDel.Click
        Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GCLotFIFO.FocusedView
        Dim result As DialogResult
        result = MessageBox.Show("คุณต้องการลบ Lot No. นี้ใช่หรือไม่", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            detailView.DeleteRow(detailView.FocusedRowHandle)
            ds.AcceptChanges()
            GVLotSale.RefreshData()

            ExpandDetailsT(GVSaleOrder)
            CalForSumAmtSale()
        End If
    End Sub

    Private Sub GVLotSale_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVLotSale.CellValueChanged
        If stLoad = 1 Then
            CalForSumAmtSale()
        End If
    End Sub

    Private Sub rptAddLot_KeyDown(sender As Object, e As KeyEventArgs) Handles rptAddLot.KeyDown
        If e.KeyCode = Keys.Escape Then
            fnAddLotBySelf()
        End If
    End Sub


End Class