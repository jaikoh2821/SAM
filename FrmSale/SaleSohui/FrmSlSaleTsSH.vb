Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class FrmSlSaleTsSH
    Enum eProcess
        eCrBillFrWait 'สร้างบิลขาย จากรายการรอเบิกโสหุ้ย
        eEdit
        eView
    End Enum

    Dim xProcess As eProcess
    Dim _dtUnit As New DataTable 'เก็บ unit ที่โหลดมาใส่ rptUnit ทั้งหมด เพื่อเอาไปใช้ใน fn getDataLookUp
    Dim dtMain As New DataTable
    Dim dt_Note As New DataTable
    Dim dtDel As New DataTable
    Dim gdrWaitCrBillMt As DataRowView
    Dim drWaitCrBillDt() As DataRow

    Dim idPartner As Integer = 0
    Dim idFm As Integer = 0
    Dim SumSvFree As Double = 0.0 'รวมค่าบริการขนส่ง

    Dim gidJobMt As Integer = 0
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim stLoad As Integer = 0
    Dim DocCodeChk As String = ""

    Dim gidSale As Integer = 0 'Use for Case Edit
    Sub New(ByVal aProcess As eProcess, ByRef drWaitCrBillMt As DataRowView, ByVal drDetail() As DataRow, ByVal idJobMt As Integer, ByVal idSale As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eEdit
                Me.Text = "แก้ไขรายการขายสินค้าโสหุ้ย"

            Case eProcess.eView
                Me.Text = "ข้อมูลรายการขายสินค้าโสหุ้ย"
                btnSave.Visible = False
                txtDocRef.Enabled = False
                dtpSale.Enabled = False
                rdbRight.Enabled = False
                rdbNoRight.Enabled = False
                btnRefDoc.Visible = False
                dtpJob.Enabled = False
                dtpPay.Enabled = False
                cmbTp.Enabled = False
                ColSelLot.Visible = False
                ColDel.Visible = False
                ColLotNo.OptionsColumn.AllowEdit = False
                ColLotNo.OptionsColumn.ReadOnly = True
                ColLotNo.AppearanceCell.BackColor = Color.Gainsboro
        End Select

        xProcess = aProcess
        gidJobMt = idJobMt
        gidSale = idSale
        gdrWaitCrBillMt = drWaitCrBillMt
        drWaitCrBillDt = drDetail
    End Sub

    Private Sub FrmSlSaleTsSH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        setCmbGroupComp(Me.cmbGroupComp)
        mdCnOpen()
        SetDatainRpt()
        cmbTps() 'เงื่อนไขชำระเงิน
        fnAddDataTable(dtMain)
        AddDatatableDel(dtDel)

        stLbl_DateTs.Text = "วันที่ทำรายการ : " & Date.Today & ".เวลา " & TimeOfDay.ToString("HH:mm") & " น"
        stLbl_PsTs.Text = "ผู้ทำรายการ : " & sPsName
        stLbl_PsTs.Tag = sPsId
        GCSale.DataSource = dtMain

        If xProcess = eProcess.eCrBillFrWait Then
            mdCnOpen()
            LoadDataWaitSell()
            cmbDRefCode()
        Else
            mdCnOpen()
            BindData()
            mdLoadCommitt()

        End If
        stLoad = 1
    End Sub

    Private Sub BindData()
        Dim dt As New DataTable
        sCommand.CommandText = "Select smt.DocRef, smt.DateTs, smt.stRight, smt.idPM, smt.idPsTs, psts.PsName As PsTs, " & vbNewLine &
                                    "shMt.RecCode, smt.PartnerNameBill, shMt.JobNo, smt.idSaleCode, smt.TotalNet, smt.Total, " & vbNewLine &
                                    "smt.idComp, shMt.idJobMt, jDt.idJob, RecCode, [devsk].[convertStrToDate](RecDate) As RecDate, p.PartnerName, Imt.StrainCode, " & vbNewLine &
                                    "shMt.PlantName +' : '+ shMt.SeedTypeName As Seed, ps.PsName As PsTs, " & vbNewLine &
                                    "(Select Sum(shDt.shPrice*shDt.shAmount ) From PdIndexShJobDt shDt Where shDt.idJobMt = shMt.idJobMt) As TotalMt," & vbNewLine &
                                    "shMt.SeasonName, shMt.ZoneName, shMt.PsSupport," & vbNewLine &
                                    "substring(jDt.DateMete,7,2)+'/'+substring(jDt.DateMete,5,2)+'/'+substring(jDt.DateMete,1,4) As DateMete" & vbNewLine &
                                    "From SmSaleMt smt" & vbNewLine &
                                    "LEFT JOIN vPdIndexShJobMt shMt ON smt.idJobMt = shMt.idJobMt " & vbNewLine &
                                    "Left Join PdIndexJobDt jDt ON shMt.idJob = jDt.idJob" & vbNewLine &
                                    "Left Join dPartner p ON jDt.idFm = p.idFm" & vbNewLine &
                                    "Left Join vPersonxSelect ps ON shMt.idPs = ps.idPs" & vbNewLine &
                                    "Left Join PdIndexMt Imt ON jDt.idIndex = Imt.idIndex " & vbNewLine &
                                    "Left Join dSeedType st ON Imt.idSeedType = st.idSeedType" & vbNewLine &
                                    "Left Join dSeed s ON st.idSeed = s.idSeed" & vbNewLine &
                                    "Left Join PdIndexMt mt ON jDt.idIndex = mt.idIndex " & vbNewLine &
                                    "Left Join dSeasonOfProduce d ON mt.idSeasonPd = d.idSeasonPd " & vbNewLine &
                                    "Left Join vPersonxSelect psts ON smt.idPsTs = psts.idPs" & vbNewLine &
                                    "WHERE smt.idSale = " & gidSale
        sAdapter.Fill(dt)


        cmbGroupComp.SelectedValue = dt.Rows(0).Item("idComp")
        cmbDRefCode()
        lblDocCodeSH.Text = dt.Rows(0).Item("RecCode")
        lblFarmerName.Text = dt.Rows(0).Item("PartnerNameBill")
        lblJobNo.Text = dt.Rows(0).Item("JobNo")

        lblSeason.Text = dt.Rows(0).Item("SeasonName")
        lblStrainCode.Text = dt.Rows(0).Item("StrainCode")
        lblSeedName.Text = dt.Rows(0).Item("Seed")
        dtpJob.Value = dt.Rows(0).Item("DateMete")
        lblZone.Text = dt.Rows(0).Item("ZoneName")
        lblPSsupport.Text = dt.Rows(0).Item("PsSupport")
        txtTotalBFDisc.Text = Format(dt.Rows(0).Item("Total"), "#,###.00")
        txtTotalNet.Text = Format(dt.Rows(0).Item("TotalNet"), "#,###.00")

        If Not IsDBNull(dt.Rows(0).Item("stRight")) Then
            If dt.Rows(0).Item("stRight") = 1 Then
                Me.rdbRight.Checked = True
            ElseIf dt.Rows(0).Item("stRight") = 0 Then
                Me.rdbNoRight.Checked = True
            End If
        End If

        stLbl_DateTs.Text = "วันที่ทำรายการ : " & ksbStringToDate(dt.Rows(0).Item("DateTs"))
        stLbl_PsTs.Text = "ผู้ทำรายการ : " & dt.Rows(0).Item("PsTs")
        stLbl_PsTs.Tag = dt.Rows(0).Item("idPsTs")

        Me.cmbDRCode.SelectedValue = dt.Rows(0).Item("idSaleCode")

        Dim DocRef() As String = dt.Rows(0).Item("DocRef").ToString.Split(" ")

        If DocRef.Length > 1 Then
            'cmbDRCode.Text = DocRef(0)
            txtDocRef.Text = DocRef(1)
        End If

        cmbTp.SelectedValue = dt.Rows(0).Item("idPM")

        If cmbTp.SelectedValue = 55 Then 'ชำระมัดจำ ชำระเงินมัดจำ 50.00%
            Dim PrePay As Double = (CDbl(dt.Rows(0).Item("TotalNet")) * 50) / 100
            Me.txtPrePay.Text = Format(PrePay, "#,##0.00")
        End If

        '----Show SmSaleDtAll on dgv ----'
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT cast(0 As bit) As chk, dt.CodeOrder, pk.PdCode, ISNULL(dt.idLot,0) As idLot, dt.LotNo, dt.LotNo As LotNoHide, dt.Amount As AmtSale, lm.CompRec," & vbNewLine &
                               "dt.Price As PriceSale, dt.TotalDt As Total, inv.idInvGroup, inv.idSubType, dt.DiscountPerc, dt.DiscountPerc As DisCountPercHide, dt.DiscountBath, " & vbNewLine &
                               "dt.PriceBfDis, dt.ProductName, dt.idSaleDt, dt.idUnit, dt.idProduct As idInvMain, dt.stCutStock, sw.full_lock As WareHouseName," & vbNewLine &
                               "IsNULL(lm.idLotSPM,0) As idLotSPM, ISNULL(dt.idWh,0) As idWh, inv.idInvGroup, unit.UnitName, dt.No, dt.stWIMAllRec,  " & vbNewLine &
                               "dt.AmtWIMRecBal, dt.DtType, ISNULL((wh.Amount - (SELECT ISNULL(SUM(AmountWaitChange),0) " & vbNewLine &
                                                                                "FROM WimWaitCutDt wDt " & vbNewLine &
                                                                                "LEFT JOIN WimWaitCutMt wMt ON wDt.idWaitCutMt = wMt.idWaitCutMt" & vbNewLine &
                                                                                "WHERE wDt.idLot = lm.idLot " & vbNewLine &
                                                                                "AND wh.idWh = wDt.idWh" & vbNewLine &
                                                                                "AND wDt.stWait Is NULL" & vbNewLine &
                                                                                "AND wMt.stCancel Is NULL " & vbNewLine &
                                                                                "AND wDt.stDel Is NULL)),0) As AmtStock, ISNULL(wh.idRefLot,0) As idRefLot, ISNULL(dt.pWeight,0) As pWeight, ISNULL(dt.idUnitW,0) As idUnitW, ISNULL(stCutStock,0) As stCutStock" & vbNewLine &
                               "FROM SmSaleDtAll dt " & vbNewLine &
                               "LEFT JOIN dInvLotMain lm ON dt.idLot = lm.idLot " & vbNewLine &
                               "LEFT JOIN dInvLotRefWh wh ON lm.idLot = wh.idLot AND wh.idWh = dt.idWh" & vbNewLine &
                               "LEFT JOIN dInventoryMain inv ON dt.idProduct = inv.idInvMain" & vbNewLine &
                               "LEFT JOIN dInvUnit unit ON dt.idUnit = unit.idUnit" & vbNewLine &
                               "LEFT JOIN dPackingPdSet As pk ON inv.idSubType = pk.idPdPk AND inv.idInvGroup = 2" & vbNewLine &
                               "LEFT JOIN SmSaleOrderDt ord ON dt.idSaleOrderDt = ord.idSaleOrderDt " & vbNewLine &
                               "LEFT JOIN SsWareHouse sw ON dt.idWh = sw.idWh " & vbNewLine &
                               "WHERE dt.idSale = " & gidSale & " Order By dt.No"
        sAdapter.Fill(sDt)

        GCSale.DataSource = sDt
    End Sub
    Private Sub cmbDRefCode()
        'mdCnOpen()
        Dim sDt As New DataTable
        'sCommand.CommandText = "Select idSaleCode, SaleCode From SmSaleDocCode WHERE SaleCode IN (SELECT SaleCode From " & _
        '                       "SmSaleCodeComp WHERE idComp = " & sIdComp & " AND SaleCode <> 'XY')"
        sCommand.CommandText = "Select idSaleCode, SaleCode " & vbNewLine &
                                "From SmSaleDocCode " & vbNewLine &
                                "WHERE idSaleCode IN (SELECT idSaleCode From " & vbNewLine &
                                "SmSaleCodeComp WHERE idComp = " & cmbGroupComp.SelectedValue & ")" & vbNewLine &
                                "AND stDel Is NULL"
        sAdapter.Fill(sDt)

        With cmbDRCode
            .DisplayMember = "SaleCode"
            .ValueMember = "idSaleCode"
            .DataSource = sDt
        End With

        If sDt.Rows.Count = 0 Then
            MessageBox.Show("บริษัทนี้ยังไม่ได้กำหนดรหัสเอกสาร จึงไม่สามารถทำรายการขายได้" & vbNewLine & "กรุณาแจ้งผู้พัฒนาระบบ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Exit Sub
        End If

    End Sub

    Private Sub cmbTps()
        'mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idPM, PaymentTerms From SmPaymentTermsD WHERE idPM <> 75 Order By PaymentTerms" 'ไม่แสดงเงื่อนไขของบิล XY
        sAdapter.Fill(sDt)
        With cmbTp
            .DisplayMember = "PaymentTerms"
            .ValueMember = "idPM"
            .DataSource = sDt
        End With
    End Sub

    Private Sub LoadDataWaitSell()
        If gdrWaitCrBillMt IsNot Nothing Then

            lblDocCodeSH.Text = gdrWaitCrBillMt.Item("RecCode")
            lblFarmerName.Text = gdrWaitCrBillMt.Item("PartnerName")
            lblJobNo.Text = gdrWaitCrBillMt.Item("JobNo")

            Dim dt As New DataTable
            sCommand.CommandText = "Select comp.CompCode, comp.idComp, shMt.idJobMt, p.idPartner, jDt.idJob, RecCode, [devsk].[convertStrToDate](RecDate) As RecDate, p.PartnerName, Imt.StrainCode, " & vbNewLine &
                                    "shMt.PlantName +' : '+ shMt.SeedTypeName As Seed, ps.PsName As PsTs, " & vbNewLine &
                                    "(Select Sum(shDt.shPrice*shDt.shAmount ) From PdIndexShJobDt shDt Where shDt.idJobMt = shMt.idJobMt) As TotalMt," & vbNewLine &
                                    "shMt.SeasonName, shMt.ZoneName, shMt.PsSupport," & vbNewLine &
                                    "substring(jDt.DateMete,7,2)+'/'+substring(jDt.DateMete,5,2)+'/'+substring(jDt.DateMete,1,4) As DateMete" & vbNewLine &
                                    "From vPdIndexShJobMt shMt " & vbNewLine &
                                    "Left Join PdIndexJobDt jDt ON shMt.idJob = jDt.idJob" & vbNewLine &
                                    "Left Join dPartner p ON jDt.idFm = p.idFm" & vbNewLine &
                                    "Left Join vPersonxSelect ps ON shMt.idPs = ps.idPs" & vbNewLine &
                                    "Left Join PdIndexMt Imt ON jDt.idIndex = Imt.idIndex " & vbNewLine &
                                    "Left Join dSeedType st ON Imt.idSeedType = st.idSeedType" & vbNewLine &
                                    "Left Join dSeed s ON st.idSeed = s.idSeed" & vbNewLine &
                                    "Left Join PdIndexMt mt ON jDt.idIndex = mt.idIndex " & vbNewLine &
                                    "Left Join dSeasonOfProduce d ON mt.idSeasonPd = d.idSeasonPd " & vbNewLine &
                                    "Left Join PchInvAndProject.dbo.dCompany comp ON shMt.idCompb = comp.idCompb  " & vbNewLine &
                                    "WHERE shMt.idJobMt = " & gidJobMt
            sAdapter.Fill(dt)

            If gdrWaitCrBillMt.Item("idComp") = 3 Then
                cmbGroupComp.SelectedValue = 8
            Else
                cmbGroupComp.SelectedValue = gdrWaitCrBillMt.Item("idComp")
            End If


            lblSeason.Text = dt.Rows(0).Item("SeasonName")
            lblStrainCode.Text = dt.Rows(0).Item("StrainCode")
            lblSeedName.Text = dt.Rows(0).Item("Seed")
            dtpJob.Value = dt.Rows(0).Item("DateMete")
            lblZone.Text = dt.Rows(0).Item("ZoneName")
            lblPSsupport.Text = dt.Rows(0).Item("PsSupport")

            idPartner = dt.Rows(0).Item("idPartner")

            For Each dr As DataRow In drWaitCrBillDt
                DGVBind.AddNewRow()
                With DGVBind
                    '.SetRowCellValue(row, clidMt, dr.Item("idMt"))
                    .SetFocusedRowCellValue(colidInvMain, dr.Item("idInvMain"))
                    .SetFocusedRowCellValue(ColProductName, dr.Item("InvName"))
                    .SetFocusedRowCellValue(ColAmtSale, dr.Item("shAmount"))
                    .SetFocusedRowCellValue(ColidUnit, dr.Item("idUnit"))
                    .SetFocusedRowCellValue(ColPriceSale, dr.Item("shPrice"))
                    .SetFocusedRowCellValue(ColExp, dr.Item("shPrice") * dr.Item("shAmount"))
                End With

                DGVBind.UpdateCurrentRow()
            Next

            DGVBind.RefreshData()
            SumcolAmountExpNewGrid()
        End If
    End Sub
    Private Sub AddDatatableDel(ByVal dt As DataTable)
        dt.Columns.Add("idLot", System.Type.GetType("System.Int64"))
        dt.Columns.Add("idInvMain", System.Type.GetType("System.Int64"))
        dt.Columns.Add("idWh", System.Type.GetType("System.Int64"))
        dt.Columns.Add("idSaleDt", System.Type.GetType("System.Int64"))
        dt.Columns.Add("AmtSale", System.Type.GetType("System.Double"))
        dt.Columns.Add("LotNo", System.Type.GetType("System.String"))
        dt.Columns.Add("idSaleOrderDt", System.Type.GetType("System.Int64"))
        dt.Columns.Add("idUnit", System.Type.GetType("System.Int64"))
    End Sub

    Private Sub fnAddDataTable(ByVal dt As DataTable)
        dt.Columns.Add("idSaleDt", System.Type.GetType("System.Int64"))
        dt.Columns.Add("idInvMain", System.Type.GetType("System.Int64"))
        dt.Columns.Add("idLot", System.Type.GetType("System.Int64"))
        dt.Columns.Add("LotNo", System.Type.GetType("System.String"))
        dt.Columns.Add("LotNoHide", System.Type.GetType("System.String"))
        dt.Columns.Add("ProductName", System.Type.GetType("System.String"))
        dt.Columns.Add("AmtStock", System.Type.GetType("System.Double"))
        dt.Columns.Add("AmtSale", System.Type.GetType("System.Double")) 'จำนวนขาย
        dt.Columns.Add("AmtSaleHide", System.Type.GetType("System.Double")) 'จำนวนขาย
        dt.Columns.Add("UnitName", System.Type.GetType("System.String"))
        dt.Columns.Add("PriceSale", System.Type.GetType("System.Double")) 'ราคาขาย     
        dt.Columns.Add("PriceSaleHide", System.Type.GetType("System.Double")) 'ราคาขาย
        dt.Columns.Add("Total", System.Type.GetType("System.Double")) 'รวมเป็นเงิน
        dt.Columns.Add("idUnit", System.Type.GetType("System.Int64"))
        dt.Columns.Add("idWh", System.Type.GetType("System.Int64"))
        dt.Columns.Add("WareHouseName", System.Type.GetType("System.String"))
        dt.Columns.Add("idInvGroup", System.Type.GetType("System.Int64"))
        dt.Columns.Add("idRefLot", System.Type.GetType("System.Int64"))
        dt.Columns.Add("OldAmt", System.Type.GetType("System.Double")) 'จำนวนขาย ()
        dt.Columns.Add("DtType", System.Type.GetType("System.Int64"))
    End Sub

    Private Sub SetDatainRpt()

        Dim dt As New DataTable
        sCommand.CommandText = "Select unit.idUnit, unit.UnitName " & vbNewLine &
                               "FROM  dInvUnit unit " &
                               "WHERE stDel Is NULL "
        sAdapter.Fill(dt)

        rptUnit.Columns.Clear()
        rptUnit.Columns.Add(New LookUpColumnInfo("UnitName"))
        rptUnit.DataSource = dt
        _dtUnit = dt
        rptUnit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Function fnCalAmtxUnit(ByVal mycommand As SqlCommand, ByVal idUnit As Integer, ByVal idInvGroup As Integer, ByVal AmtSale As Double, ByVal idInvMain As Integer) As Double
        Dim CalAmt As Double = 0.0
        Dim myAdapter = New SqlDataAdapter(mycommand)

        '------แปลงหน่วย ก่อน คืน + เพิ่ม สต๊อกกกกกก
        If idInvGroup = 1 And idUnit = 1 Then ' วัตถุดิบ + กรัม
            CalAmt = CDbl(AmtSale) / 1000

        Else

            Dim dtInvUnitSub As New DataTable

            dtInvUnitSub.Clear()

            mycommand.CommandText = "SELECT ISNULL(AmtMainperSub,0) As AmtMainperSub, idSubUnit, idUnit " & vbNewLine &
                                   "FROM  dInvUnitSub " & vbNewLine &
                                   "WHERE idSubUnit = " & idUnit & " AND idInvMain = " & idInvMain
            myAdapter.Fill(dtInvUnitSub)

            If dtInvUnitSub.Rows.Count > 0 Then 'มี idSubUnit
                'Check ว่า idUnit ที่เลือกตอนนี้เป็น Unit หลัก หรือ Unit รอง
                If idUnit = dtInvUnitSub.Rows(0).Item("idSubUnit") Then 'แสดงว่าเป็นหน่วยรอง ต้อง  Convert

                    CalAmt = CDbl(AmtSale) * dtInvUnitSub.Rows(0).Item("AmtMainperSub")

                End If

            Else
                CalAmt = CDbl(AmtSale)

            End If
        End If

        Return CalAmt
    End Function

    Private Sub DGVBind_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles DGVBind.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If
    End Sub

    Private Sub DGVBind_ShownEditor(sender As Object, e As EventArgs) Handles DGVBind.ShownEditor
        If DGVBind.FocusedRowHandle >= 0 Then
            Dim view As ColumnView = DirectCast(sender, ColumnView)
            If view.FocusedColumn.FieldName = "idUnit" Then
                Dim editor As LookUpEdit = CType(view.ActiveEditor, LookUpEdit)
                Dim idUnit As Integer = view.GetFocusedRowCellValue("idUnit")
                Dim idInvMain As Integer = view.GetFocusedRowCellValue("idInvMain")
                Dim dt As DataTable = getDataLookup(idUnit, idInvMain)
                editor.Properties.DataSource = dt
                rptUnit.DropDownRows = dt.Rows.Count
            End If
        End If
    End Sub

    Private Function getDataLookup(ByVal idUnit As Integer, ByVal idInvMain As Integer) As DataTable

        Dim dtS As DataTable = _dtUnit.Clone
        Dim drs() As DataRow
        Dim StrUnit As String = ""
        mdCnOpen()
        Dim temp_ As New DataTable
        sCommand.CommandText = "SELECT idUnit, idInvGroup FROM  dInventoryMain WHERE idInvMain = " & idInvMain
        sAdapter.Fill(temp_)
        mdLoadCommitt()
        Dim idInvGroup As Integer = temp_.Rows(0).Item("idInvGroup")

        If idInvGroup = 1 Then

            If temp_.Rows(0).Item("idUnit") = 2 Then
                drs = _dtUnit.Select("idUnit IN (1,2) ")
            Else
                drs = _dtUnit.Select("idUnit IN (" & temp_.Rows(0).Item("idUnit") & ")")
            End If

        Else

            Dim dtUnitSub As New DataTable
            sCommand.CommandText = "SELECT idUnit, idSubUnit FROM dInvUnitSub WHERE idInvMain = " & idInvMain
            sAdapter.Fill(dtUnitSub)

            If dtUnitSub.Rows.Count > 0 Then
                If idUnit = dtUnitSub.Rows(0).Item("idSubUnit") Then
                    StrUnit &= dtUnitSub.Rows(0).Item("idSubUnit").ToString + ","

                    For i As Integer = 0 To dtUnitSub.Rows.Count - 1
                        StrUnit &= dtUnitSub.Rows(i).Item("idUnit").ToString
                        StrUnit &= ","
                    Next

                Else

                    StrUnit &= idUnit.ToString + ","

                    For i As Integer = 0 To dtUnitSub.Rows.Count - 1
                        StrUnit &= dtUnitSub.Rows(i).Item("idSubUnit").ToString
                        StrUnit &= ","
                    Next

                End If
                drs = _dtUnit.Select("idUnit in(" & StrUnit & ")")
            Else
                drs = _dtUnit.Select("idUnit = " & idUnit)
            End If
        End If


        For Each dr As DataRow In drs
            dtS.ImportRow(dr)
        Next

        Return dtS

    End Function

    Private Sub btnRefDoc_Click(sender As Object, e As EventArgs) Handles btnRefDoc.Click
        Dim vFrm As New frmSaleDocCode
        vFrm.Show()
    End Sub

    Private Sub rptUnit_Click(sender As Object, e As EventArgs) Handles rptUnit.Click
        If DGVBind.FocusedRowHandle < 0 Then
            rptUnit.ReadOnly = True
        Else
            rptUnit.ReadOnly = False
        End If
    End Sub


    Function getDocCode(ByVal Prefixcode As String, ByVal xCommand As SqlCommand) As String
        Dim DocCode As String = ""
        Dim nextOrder As String = ""

        Dim xAdapter = New SqlDataAdapter(xCommand)

        Dim sDt As New DataTable
        sDs.Tables.Clear()

        xCommand.CommandText = "SELECT MAX(DocCode) as max_DocCode FROM SmSaleMt"
        xAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocCode")) = True Then
            DocCode = Prefixcode & "/" & "000001"
        Else
            Dim max_DocCode As String = sDt.Rows(0).Item("max_DocCode")
            Dim yearDoc As String = Microsoft.VisualBasic.Left(sDt.Rows(0).Item("max_DocCode"), 2)
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocCode"), 6)

            If Prefixcode <> yearDoc Then
                DocCode = Prefixcode & "/" & "000001"
            Else
                Dim temp As Integer
                temp = CInt(RunningCode) + 1
                If temp < 10 Then
                    nextOrder = "00000" & CStr(temp)
                ElseIf temp < 100 Then
                    nextOrder = "0000" & CStr(temp)
                ElseIf temp < 1000 Then
                    nextOrder = "000" & CStr(temp)
                ElseIf temp < 10000 Then
                    nextOrder = "00" & CStr(temp)
                ElseIf temp < 100000 Then
                    nextOrder = "0" & CStr(temp)
                Else
                    nextOrder = CStr(temp)
                End If
                DocCode = Prefixcode & "/" & nextOrder
            End If
        End If
        Return DocCode
    End Function

    '-------------------- GEN DocRefAcc : รันเลขที่ทางบัญชี --------------------'
    Function getDocRefAcc(ByVal YearAndMonth As String, ByVal xCommand As SqlCommand) As String
        Dim xAdapter = New SqlDataAdapter(xCommand)

        Dim PrefixCode As String = "IV"
        Dim DocRefAcc As String = ""
        Dim nextOrder As String = ""
        ' Dim CodeYear As String = ""
        Dim st3Position As Integer = 0

        Dim fieldSub As String = ""
        If st3Position = 1 Then
            fieldSub = "SUBSTRING(DocRefAcc,1,8)"
        Else
            fieldSub = "SUBSTRING(DocRefAcc,1,7)"
        End If

        DocRefAcc = PrefixCode & " " & YearAndMonth
        mdCnOpen()
        Dim sDt As New DataTable
        sDs.Tables.Clear()
        xCommand.CommandText = "SELECT MAX(DocRefAcc) as max_DocRefAcc FROM SmSaleMt " &
                               "WHERE " & fieldSub & "= '" & DocRefAcc & "' AND idComp = '" & cmbGroupComp.SelectedValue & "'"
        xAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocRefAcc")) = True Then
            DocRefAcc = PrefixCode & " " & YearAndMonth & "0001"
        Else
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocRefAcc"), 4)
            Dim temp As Integer
            temp = CInt(RunningCode) + 1
            If temp < 10 Then
                nextOrder = "000" & CStr(temp)
            ElseIf temp < 100 Then
                nextOrder = "00" & CStr(temp)
            ElseIf temp < 1000 Then
                nextOrder = "0" & CStr(temp)
            Else
                nextOrder = CStr(temp)
            End If
            DocRefAcc = PrefixCode & " " & YearAndMonth & nextOrder

        End If
        Return DocRefAcc
    End Function

    Private Sub rptDel_Click(sender As Object, e As EventArgs) Handles rptDel.Click
        If DGVBind.FocusedRowHandle >= 0 Then
            If lbrMsg.MsgQuestion("คุณต้องการลบรายการใช่หรือไม่?") = True Then
                Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)

                If Not IsDBNull(dr("idSaleDt")) Then
                    If dr("idSaleDt") <> 0 Then
                        Dim drtemp As DataRow = dtDel.NewRow()
                        drtemp("idInvMain") = dr("idInvMain")
                        drtemp("idLot") = dr("idLot")
                        drtemp("idWh") = dr("idWh")
                        drtemp("idSaleDt") = dr("idSaleDt")
                        drtemp("AmtSale") = dr("AmtSale")
                        drtemp("LotNo") = dr("LotNo")
                        drtemp("idUnit") = dr("idUnit")
                        dtDel.Rows.Add(drtemp)
                    End If
                End If

                dr.Delete()

                dtMain.AcceptChanges()
                SumTotalNew()
            End If

        End If
    End Sub

    Private Sub DGVBind_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles DGVBind.CellValueChanged

        Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)

        If e.Column.Name = ColPriceSale.Name Or e.Column.Name = ColAmtSale.Name Then

            If Not IsDBNull(dr.Item("idLot")) Then
                If dr.Item("idLot") <> 0 Then
                    Dim SumAmtOfLot As Double = 0.0
                    Dim AmountUse As Double = 0.0

                    For i As Integer = 0 To DGVBind.DataRowCount - 1
                        AmountUse = 0

                        Dim sDr As DataRow = DGVBind.GetDataRow(i)

                        If Not IsDBNull(sDr.Item("idLot")) Then

                            If (sDr.Item("idLot") = dr.Item("idLot")) And
                               (sDr.Item("idInvGroup") = dr.Item("idInvGroup")) And
                                (sDr.Item("idRefLot") = dr.Item("idRefLot")) Then

                                If IsDBNull(sDr.Item("AmtSale")) Then
                                    sDr.Item("AmtSale") = 0.0
                                End If

                                AmountUse = fnCalAmtxUnit(sCommand, dr.Item("idUnit"), dr.Item("idInvGroup"), dr.Item("AmtSale"), dr.Item("idInvMain"))

                                SumAmtOfLot = SumAmtOfLot + AmountUse
                            End If

                        End If

                    Next

                    SumAmtOfLot = Math.Round(SumAmtOfLot, 6, MidpointRounding.AwayFromZero)

                    If dr.Item("AmtStock") < SumAmtOfLot Then  ' Stock < AllSaleAmount
                        Dim ShowUnit As String = ""

                        If dr.Item("idUnit") = 1 Then '"กรัม" Then
                            ShowUnit = "กิโลกรัม"
                        Else
                            ShowUnit = DGVBind.GetDataRow(e.RowHandle).Item("UnitName")
                        End If

                        MessageBox.Show("จำนวนสินค้าคงเหลือใน Stock ไม่เพียงพอต่อความต้องการ" & vbCrLf &
                                        "(จำนวนขายรวม : " & Format(SumAmtOfLot, "#,##0.00##") & " " & ShowUnit &
                                        " แต่จำนวน Stock คงเหลือ : " & Format(DGVBind.GetDataRow(e.RowHandle).Item("AmtStock"), "#,##0.00##") & " " & ShowUnit & ")", sSystemName)

                        dr.Item("AmtSale") = 0.0
                    End If
                End If

                SumcolAmountExpNewGrid()
            End If
        End If
    End Sub

    Private Sub SumcolAmountExpNewGrid()
        Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)

        If IsDBNull(DGVBind.GetFocusedRowCellValue(ColExp)) Then
            dr.Item("Total") = 0.0
        End If

        If IsDBNull(DGVBind.GetFocusedRowCellValue(ColAmtSale)) Then
            dr.Item("AmtSale") = 0.0
        End If

        If IsDBNull(DGVBind.GetFocusedRowCellValue(ColPriceSale)) Then
            dr.Item("PriceSale") = 0.0
        End If

        dr.Item("Total") = DGVBind.GetFocusedRowCellValue("PriceSale") * DGVBind.GetFocusedRowCellValue("AmtSale")

        dr.Item("PriceSale") = Format(CDbl(DGVBind.GetFocusedRowCellValue(ColPriceSale)), "#,##0.00##")
        dr.Item("Total") = Format(CDbl(DGVBind.GetFocusedRowCellValue(ColExp)), "#,##0.00##")

        SumTotalNew()
    End Sub
    Private Sub SumTotalNew()
        Dim Total As Double = 0.0

        For i As Integer = 0 To DGVBind.DataRowCount - 1
            If IsDBNull(DGVBind.GetDataRow(i).Item("Total")) Then
                DGVBind.GetDataRow(i).Item("Total") = 0.0
            End If

            If IsDBNull(DGVBind.GetDataRow(i).Item("PriceSale")) Then
                DGVBind.GetDataRow(i).Item("PriceSale") = 0.0
            End If

            Total += DGVBind.GetDataRow(i).Item("Total")
        Next

        txtTotalBFDisc.Text = Format(Total, "#,##0.00##")
        txtTotalNet.Text = Format(Total, "#,##0.00##")
    End Sub

    Private Sub fnSetDataLotNo(ByVal dtLotReturn As DataTable)

        'check stock : หัก stock ของ rows ก่อนหน้า
        Dim SumStockinBill As Double = 0.0
        Dim AmountUse As Double = 0.0


        For j As Integer = 0 To DGVBind.DataRowCount - 1
            AmountUse = 0

            If (DGVBind.GetDataRow(j).Item("idLot") = dtLotReturn.Rows(0).Item("idLot")) And
                (DGVBind.GetDataRow(j).Item("idWh") = dtLotReturn.Rows(0).Item("idWh")) Then

                '-----เปลี่ยนหน่วยก่อน

                AmountUse = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(j).Item("idUnit"), DGVBind.GetDataRow(j).Item("idInvGroup"),
                                          DGVBind.GetDataRow(j).Item("AmtSale"), DGVBind.GetDataRow(j).Item("idInvMain"))


                SumStockinBill = SumStockinBill + AmountUse
            End If
        Next

        DGVBind.SetFocusedRowCellValue("LotNo", dtLotReturn.Rows(0).Item("LotNo"))
        DGVBind.SetFocusedRowCellValue("idLot", dtLotReturn.Rows(0).Item("idLot"))
        DGVBind.SetFocusedRowCellValue("idWh", dtLotReturn.Rows(0).Item("idWh"))
        DGVBind.SetFocusedRowCellValue("AmtStock", dtLotReturn.Rows(0).Item("AmtStock"))
        DGVBind.SetFocusedRowCellValue("idSubType", dtLotReturn.Rows(0).Item("idSubType"))

        If DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idInvGroup") <> 30 Then
            DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtStock") = DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtStock") + SumStockinBill

        ElseIf DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idInvGroup") = 30 Then
            'ถ้าเป็น idInvGroup = 30 ให้ Stock = 0
            DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtStock") = 0
        End If

        SendKeys.SendWait("{Right}")
    End Sub

    Private Sub rptSelLot_Click(sender As Object, e As EventArgs) Handles rptSelLot.Click

        Dim eText As String = ""
        Dim sLotNo As String = ""
        Dim sidInvMain As Integer = 0
        Dim sInvName As String = ""

        Dim vFrm As New frmLotSelect(frmLotSelect.eProcess.eSelectSH, cmbGroupComp.SelectedValue, cmbGroupComp.Text, "",
                                       DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain"), DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "ProductName"))

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            If vFrm.dtLotReturn.Rows.Count = 1 Then
                Dim dr As DataRow = vFrm.dtLotReturn.Rows(0)


                DGVBind.SetFocusedRowCellValue("idSaleDt", 0)

                DGVBind.SetFocusedRowCellValue("idLot", dr.Item("idLot"))
                DGVBind.SetFocusedRowCellValue("idInvGroup", dr.Item("idInvGroup"))
                DGVBind.SetFocusedRowCellValue("idWh", dr.Item("idWh"))
                DGVBind.SetFocusedRowCellValue("LotNo", dr.Item("LotNo"))
                DGVBind.SetFocusedRowCellValue("AmtStock", dr.Item("AmtStock"))
                DGVBind.SetFocusedRowCellValue("OldAmt", 0)
                DGVBind.SetFocusedRowCellValue("idRefLot", dr.Item("idRefLot"))
                ' row("idSubType") = vFrm.dtLotReturn.Rows(i).Item("idSubType")
                DGVBind.SetFocusedRowCellValue("DtType", dr.Item("DtType"))
                DGVBind.SetFocusedRowCellValue("WareHouseName", dr.Item("full_lock"))

                'Dim SumStockinBill As Double = 0.0

                'For j As Integer = 0 To DGVBind.DataRowCount - 1
                '    If (DGVBind.GetDataRow(j).Item("idLot") = Row.Item("idLot")) And
                '            (DGVBind.GetDataRow(j).Item("idWh") = Row.Item("idWh")) Then

                '        '-----เปลี่ยนหน่วยก่อน
                '        DGVBind.GetDataRow(j).Item("OldAmt") = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(j).Item("idUnit"),
                '                                                                 DGVBind.GetDataRow(j).Item("idInvGroup"),
                '                                                                    DGVBind.GetDataRow(j).Item("AmtSale"), DGVBind.GetDataRow(j).Item("idInvMain"))
                '    End If

                '    SumStockinBill = SumStockinBill + DGVBind.GetDataRow(j).Item("OldAmt")
                'Next

                'If DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idInvGroup") <> 30 Then
                '    DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtStock") = DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtStock") + SumStockinBill
                'End If
            End If
        Else

        End If

    End Sub

    '-------------------- GEN DocCode --------------------'
    Function getDocCode(ByVal mycommand As SqlCommand, ByVal Prefixcode As String) As String
        Dim DocCode As String = ""
        Dim nextOrder As String = ""
        'Dim CodeYear As String = ""
        Dim myAdapter As New SqlDataAdapter(mycommand)
        Dim sDt As New DataTable
        sDs.Tables.Clear()
        'sCommand.CommandText = "SELECT MAX(SUBSTRING(DocCode, 4, 6)) AS max_DocCode, MAX(SUBSTRING(DocCode, 1, 2)) AS year_docCode FROM SmSaleMt"
        mycommand.CommandText = "SELECT MAX(DocCode) as max_DocCode FROM SmSaleMt"
        myAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocCode")) = True Then
            DocCode = Prefixcode & "/" & "000001"
        Else
            Dim max_DocCode As String = sDt.Rows(0).Item("max_DocCode")
            Dim yearDoc As String = Microsoft.VisualBasic.Left(sDt.Rows(0).Item("max_DocCode"), 2)
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocCode"), 6)

            'CodeYear = sDt.Rows(0).Item("year_docCode")
            If Prefixcode <> yearDoc Then
                DocCode = Prefixcode & "/" & "000001"
            Else
                Dim temp As Integer
                temp = CInt(RunningCode) + 1
                If temp < 10 Then
                    nextOrder = "00000" & CStr(temp)
                ElseIf temp < 100 Then
                    nextOrder = "0000" & CStr(temp)
                ElseIf temp < 1000 Then
                    nextOrder = "000" & CStr(temp)
                ElseIf temp < 10000 Then
                    nextOrder = "00" & CStr(temp)
                ElseIf temp < 100000 Then
                    nextOrder = "0" & CStr(temp)
                Else
                    nextOrder = CStr(temp)
                End If
                DocCode = Prefixcode & "/" & nextOrder
            End If
        End If
        Return DocCode
    End Function

    '-------------------- GEN DocRefAcc : รันเลขที่ทางบัญชี --------------------'
    Function getDocRefAcc(ByVal myCommand As SqlCommand, ByVal YearAndMonth As String, ByVal idComp As Integer) As String

        Dim PrefixCode As String = "IV"
        Dim DocRefAcc As String = ""
        Dim nextOrder As String = ""
        ' Dim CodeYear As String = ""
        Dim st3Position As Integer = 0
        Dim myAdapter As New SqlDataAdapter(myCommand)

        Dim fieldSub As String = ""
        If st3Position = 1 Then
            fieldSub = "SUBSTRING(DocRefAcc,1,8)"
        Else
            fieldSub = "SUBSTRING(DocRefAcc,1,7)"
        End If

        DocRefAcc = PrefixCode & " " & YearAndMonth

        Dim sDt As New DataTable
        myCommand.CommandText = "SELECT MAX(DocRefAcc) as max_DocRefAcc FROM SmSaleMt " &
                               "WHERE " & fieldSub & "= '" & DocRefAcc & "' AND idComp = '" & idComp & "'"
        myAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocRefAcc")) = True Then
            DocRefAcc = PrefixCode & " " & YearAndMonth & "0001"
        Else
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocRefAcc"), 4)
            Dim temp As Integer
            temp = CInt(RunningCode) + 1
            If temp < 10 Then
                nextOrder = "000" & CStr(temp)
            ElseIf temp < 100 Then
                nextOrder = "00" & CStr(temp)
            ElseIf temp < 1000 Then
                nextOrder = "0" & CStr(temp)
            Else
                nextOrder = CStr(temp)
            End If
            DocRefAcc = PrefixCode & " " & YearAndMonth & nextOrder

        End If
        Return DocRefAcc
    End Function

    Private Function fnChkDocCodeDup(ByVal myCommand As SqlCommand, DocRef As String, ByVal vWHERE As String) As Boolean
        'Check DocCode Duplicate Before Insert into Database
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim dtChkDup As New DataTable
        myCommand.CommandText = "Select mt.DocCode, mt.DateSale, mt.DocRef, mt.idPscancel, p.PartnerName  " & vbNewLine &
                               "From SmSaleMt mt " & vbNewLine &
                               "LEFT OUTER JOIN dPartner p ON mt.idPartner = p.idPartner " & vbNewLine &
                               "WHERE mt.idPscancel IS NULL " & vbNewLine &
                               "AND mt.DocRef = '" & DocRef & "' " & vbNewLine &
                               "AND mt.idComp = " & cmbGroupComp.SelectedValue & "" & vWHERE
        myAdapter.Fill(dtChkDup)


        'For i As Integer = 0 To dRefDt.Rows.Count - 1
        If dtChkDup.Rows.Count > 0 Then
            'If CodeRef = dRefDt.Rows(i).Item("DocRef") Then
            DocCodeChk = ""
            MessageBox.Show("เลขที่อ้างอิงซ้ำกับข้อมูลเดิม รายละเอียดรายการดังนี้ " & vbCrLf & "เลขที่รายการ : " & dtChkDup.Rows(0).Item("DocCode") & vbCrLf &
            "วันที่ขาย : " & ksbStringToDate(dtChkDup.Rows(0).Item("DateSale")) & vbCrLf &
            "ชื่อลูกค้า : " & dtChkDup.Rows(0).Item("PartnerName") & vbCrLf & vbCrLf &
            "***หากต้องการบันทึก ให้เพิ่มตัวอักษรหลังรหัส ดังนี้" & vbCrLf &
            "   A : แอ๊ดว้านซีดส์" & vbCrLf &
            "   F : โฟลเทคซีดส์" & vbCrLf & " เช่น 5710001A หรือ 5710001F", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' MessageBox.Show("เลขที่อ้างอิงซ้ำกับข้อมูลเดิม", sSystemName)

            Me.txtDocRef.Focus()
            Return True 'มีเลขที่อ้างอิงซ้ำ
            Exit Function
            'End If
        End If

        Return False 'ไม่มีเลขที่อ้างอิงซ้ำ
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        '-------------------Check ข้อมูลก่อนบันทึก------------------
        If txtDocRef.Text = "" Then
            MessageBox.Show("กรุณากรอกเลขที่อ้างอิง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtDocRef.Focus()
            Exit Sub
        ElseIf Me.rdbRight.Checked = False And Me.rdbNoRight.Checked = False Then
            MessageBox.Show("กรุณาเลือกประเภทบิลถูกหลัก/ไม่ถูกหลักก่อนกดบันทึก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For i As Integer = 0 To DGVBind.DataRowCount - 1

            If IsDBNull(DGVBind.GetDataRow(i).Item("idLot")) Then
                DGVBind.GetDataRow(i).Item("idLot") = 0
            End If

            If DGVBind.GetDataRow(i).Item("idLot") = 0 Then
                MessageBox.Show("กรุณาเลือก Lot ของสินค้าให้ครบทุกรายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next

        '-------------------------------------------------------
        Using myconnection As New SqlConnection(conStr)
            myconnection.Open()
            Dim mycommand As New SqlCommand()
            ' Dim mycommand As SqlCommand = myconnection.CreateCommand()
            Dim mytransaction As SqlTransaction
            Dim myAdapter As New SqlDataAdapter(mycommand)
            ' Start a local transaction
            mytransaction = myconnection.BeginTransaction()

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            mycommand.Connection = myconnection
            mycommand.Transaction = mytransaction

            Try
                Dim getDate As String = CType(Date.Today, String)
                Dim YAndM As String = Microsoft.VisualBasic.Left(ksbDateToString(Date.Today), 6)
                Dim YAndM_Cut As String = Microsoft.VisualBasic.Right(YAndM, 4)
                Dim Prefixcode As String = (Microsoft.VisualBasic.Right(getDate, 2))

                Dim sDocCode As String = getDocCode(mycommand, Prefixcode)
                Dim sDocRefAcc As String = getDocRefAcc(mycommand, YAndM_Cut, cmbGroupComp.SelectedValue)
                Dim DocRef As String = Me.cmbDRCode.Text & " " & Trim(Me.txtDocRef.Text)
                Dim stRight As Integer = 0
                Dim NoteMt As String = ""
                Dim count As Integer = dt_Note.Rows.Count

                If count = 0 Then
                    NoteMt = ""
                Else
                    NoteMt = gvNote.GetDataRow(0).Item("Note")

                    For i As Integer = 1 To gvNote.DataRowCount - 1
                        NoteMt &= "\" & gvNote.GetDataRow(i).Item("Note")
                    Next
                    NoteMt = NoteMt.Replace("'", "''")
                End If

                If Me.rdbRight.Checked = True Then
                    stRight = 1
                ElseIf Me.rdbNoRight.Checked = True Then
                    stRight = 0
                End If

                Dim vWHERE As String = ""
                If xProcess = eProcess.eEdit Then 'EditData
                    vWHERE = " AND idSale <> " & gidSale & ""
                End If

                Dim stDup As Boolean = fnChkDocCodeDup(mycommand, DocRef, vWHERE)
                Dim stBillType As String = "8"
                Dim NewidSale As Integer = 0
                If stDup = False Then

                    NewidSale = fnNewAddSmSaleMt(mycommand, 0, sDocCode, sDocRefAcc, cmbDRCode.SelectedValue, DocRef, NoteMt, 0, stBillType,
                                              cmbTp.SelectedValue, 0, stRight, cmbGroupComp.SelectedValue, idPartner, Trim(lblFarmerName.Text), lblFarmerName.Tag, idFm,
                                             0, 0, 0)

                    If DGVBind.DataRowCount > 0 Then 'มีรายการสินค้า
                        '--- Insert SmSaleDtAll----'
                        For i As Integer = 0 To DGVBind.DataRowCount - 1
                            Dim dr As DataRow = DGVBind.GetDataRow(i)
                            fnNewAddSmSaleDtAll(mycommand, dr, NewidSale, i + 1)
                        Next

                        '---- Update SumService in SmSaleMt ----'
                        mycommand.CommandText = "Update SmSaleMt Set SumService = " & SumSvFree & " WHERE idSale = " & NewidSale
                        mycommand.ExecuteNonQuery()

                        mycommand.CommandText = "EXEC WaitCutTs '4','SmSaleMt','SmSaleDtAll','idSale'," & NewidSale & "," & cmbGroupComp.SelectedValue & "," & sPsId & ",'1'"
                        mycommand.ExecuteNonQuery()

                    End If
                    '---- Update SumService in SmSaleMt ----'
                    mycommand.CommandText = "Update PdIndexShJobMt Set idBillSAM = " & NewidSale & " WHERE idJobMt = " & gidJobMt
                    mycommand.ExecuteNonQuery()

                End If

                ' Attempt to commit the transaction.
                mytransaction.Commit()
                'SplashScreenManager.CloseForm(False)
                mdLoadCommitt()
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Catch ex As Exception
                ' Attempt to roll back the transaction.
                Try
                    mytransaction.Rollback()
                    'SplashScreenManager.CloseForm(False)
                    mdLoadCommitt()
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                             sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                Catch e2x As Exception
                    'SplashScreenManager.CloseForm(False)
                    mdLoadCommitt()
                    'MessageBox.Show(ex.Message, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                             sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                End Try
            End Try
        End Using

    End Sub

    Private Function fnNewAddSmSaleDtAll(ByVal vCommand As SqlCommand, ByVal dr As DataRow, ByVal idSale As Integer, ByVal No As Integer) As Integer
        'SumSvFree = 0
        Dim idSaleDt As Integer = 0
        Dim vAdapter = New SqlDataAdapter(vCommand)
        Dim strParameter As String = ""
        Dim strValue As String = ""

        Dim LotNo As String = ""

        If IsDBNull(dr.Item("LotNo")) Then
            LotNo = ""
        Else
            LotNo = Trim(dr.Item("LotNo"))
        End If

        '--------------DtType = 1 : สินค้าทั่วไป-------------
        If dr.Item("idInvGroup") = 2 Then
            If IsDBNull(dr.Item("CodeOrder")) Then  ' ไม่มี codeOrder
                strParameter = ""
                strValue = ""
            ElseIf dr.Item("CodeOrder") = Nothing Then
                strParameter = ""
                strValue = ""
            ElseIf dr.Item("CodeOrder") = "" Then
                strParameter = ""
                strValue = ""
            Else 'มี order
                strParameter = ", idSaleOrderDt, CodeOrder"
                strValue = "," & dr.Item("idSaleOrderDt") & "," & dr.Item("CodeOrder")

                '---Update stBillOrder : SmSaleMt----'
                vCommand.CommandText = "Update SmSaleMt Set stBillOrder = 1 WHERE idSale = '" & idSale & "'"
                vCommand.ExecuteNonQuery()
            End If

            '---Update SmSaleOrderDt Table---'
            Dim stAllSaleDt As New DataTable
            stAllSaleDt.Rows.Clear()
            vCommand.CommandText = "SELECT stAllSale, AmountPiece, IsNull(AmountSale,0) As AmountSale FROM SmSaleOrderDt WHERE " &
                                   "idSaleOrderDt = '" & dr.Item("idSaleOrderDt") & "'"
            vAdapter.Fill(stAllSaleDt)

            If stAllSaleDt.Rows.Count > 0 Then
                If IsDBNull(stAllSaleDt.Rows(0).Item("stAllSale")) Then 'มี Order ที่ยังไม่ได้ขาย
                    Dim NewSale As Integer = stAllSaleDt.Rows(0).Item("AmountSale") + dr.Item("AmtSale")

                    If stAllSaleDt.Rows(0).Item("AmountPiece") <= NewSale Then 'Order หมดแล้ว หรือ order เกิน
                        vCommand.CommandText = "Update SmSaleOrderDt Set stAllSale = 1, AmountSale = " & NewSale & " " &
                                               "WHERE idSaleOrderDt = '" & dr.Item("idSaleOrderDt") & "'"
                    Else ' ยังมี Order เหลือ
                        vCommand.CommandText = "Update SmSaleOrderDt Set AmountSale = " & NewSale & " " &
                                               "WHERE idSaleOrderDt = '" & dr.Item("idSaleOrderDt") & "'"
                    End If
                    vCommand.ExecuteNonQuery()
                End If
            End If

            '-----DtType = 3: สินค้าเมล็ดพันธุ์วัตถุดิบ------
        ElseIf dr.Item("idInvGroup") = 1 Then
            Dim CalAmt As Double = 0.0

            If dr.Item("idUnit") = 1 Then ' กรัม
                CalAmt = CDbl(dr.Item("AmtSale")) / 1000

            Else ' หน่วยอื่นๆ ที่ไม่ใช่กรัม + กิโลกรัม
                CalAmt = CDbl(dr.Item("AmtSale"))
                'idUnit = 3 ' หน่วยซอง
            End If

        ElseIf dr.Item("idInvGroup") = 30 Then
            ' รวมยอดค่าบริการ (ค่าขนส่ง)
            SumSvFree = SumSvFree + CDbl(dr.Item("Total"))

        End If


        Dim ProductName As String = Trim(dr.Item("ProductName"))
        ProductName = Replace(ProductName, "'", "''")

        vCommand.CommandText = "INSERT Into SmSaleDtAll(idSale, " & strParameter & " idProduct, ProductName, idLot, LotNo, Amount, idUnit," & vbNewLine &
                                "PriceBfDis, DiscountPerc, DiscountBath, Price, stCutStock, No, DtType, idWh, TotalDt)" & vbNewLine &
                                "VALUES(@idSale, " & strValue & "  @idProduct, @ProductName, @idLot, @LotNo, @Amount, @idUnit," & vbNewLine &
                                "@PriceBfDis, @DiscountPerc, @DiscountBath, @Price, @stCutStock, @No, @DtType, @idWh, @TotalDt)"


        With vCommand.Parameters
            .Add("@idSale", SqlDbType.Int).Value = idSale
            .Add("@idProduct", SqlDbType.Int).Value = dr.Item("idInvMain")
            .Add("@ProductName", SqlDbType.VarChar).Value = Trim(ProductName)
            .Add("@idLot", SqlDbType.Int).Value = dr.Item("idLot")
            .Add("@LotNo", SqlDbType.VarChar).Value = LotNo
            .Add("@Amount", SqlDbType.Float).Value = CDbl(dr.Item("AmtSale"))
            .Add("@idUnit", SqlDbType.Int).Value = dr.Item("idUnit")
            .Add("@PriceBfDis", SqlDbType.Float).Value = CDbl(dr.Item("PriceSale"))
            .Add("@DiscountPerc", SqlDbType.Float).Value = DBNull.Value
            .Add("@DiscountBath", SqlDbType.Float).Value = DBNull.Value
            .Add("@Price", SqlDbType.Float).Value = CDbl(dr.Item("PriceSale"))
            .Add("@stCutStock", SqlDbType.Int).Value = 0 ' Send to cut On WimWaitCut
            .Add("@No", SqlDbType.Int).Value = No
            .Add("@DtType", SqlDbType.Int).Value = dr.Item("DtType")
            .Add("@idWh", SqlDbType.Int).Value = dr.Item("idWh")
            .Add("@TotalDt", SqlDbType.Float).Value = CDbl(dr.Item("Total"))
        End With

        vCommand.ExecuteNonQuery()
        vCommand.Parameters.Clear()

        If idSaleDt = 0 Then
            Dim qr2 As String = "Select @@Identity"
            vCommand.CommandText = qr2

            idSaleDt = vCommand.ExecuteScalar()
        End If

        Return idSaleDt

    End Function

    Function fnNewAddSmSaleMt(ByVal mycommand As SqlCommand, ByVal idSale As Integer, ByVal sDocCode As String, ByVal sDocRefAcc As String, ByVal idSaleCode As Integer, ByVal sDocRef As String,
                              ByVal NoteMt As String, ByVal sidPsSale As Integer, ByVal BillType As Integer, ByVal Payment As Integer, ByVal Transport As Integer,
                              ByVal stRight As Integer, ByVal idComp As Integer, ByVal sidPartner As Integer, ByVal PartnerNameBill As String, ByVal sidCus As Integer, ByVal sidFM As Integer,
                              ByVal idPayTs As Integer, ByVal idSupTsp As Integer, ByVal idCusRefAddr As Integer) As Integer


        If xProcess = eProcess.eEdit Then  'Update

            mycommand.CommandText = "UPDATE SmSaleMt SET DateSale = @DateSale, DateSaleD = @DateSaleD, DatePay = @DatePay, DateTs = @DateTs, DateTsD = @DateTsD, " &
                              "TimeTs = @TimeTs, DocCode = @DocCode, DocRefAcc = @DocRefAcc, idSaleCode =  @idSaleCode, DocRef = @DocRef, Note = @Note, " &
                              "TotalNet = @TotalNet, Total = @Total, idPsTs = @idPsTs, idPsSale = @idPsSale, stBillType = @stBillType, stPay = @stPay, idPM =  @idPM, " &
                              "idTS = @idTS, stRight = @stRight, idComp = @idComp, idPayTsp = @idPayTsp, idSupTsp = @idSupTsp, " &
                              "idCusRefAddr = @idCusRefAddr, stLot = @stLot, idPartner = @idPartner, PartnerNameBill = @PartnerNameBill, idCus = @idCus, idFM = @idFM, " &
                              "DiscountAmout = @DiscountAmout, DiscountPerc = @DiscountPerc, DiscountBath = @DiscountBath) " &
                              "WHERE idSale = @idSale"

            mycommand.Parameters.Add("@idSale", SqlDbType.Int).Value = idSale

        ElseIf xProcess = eProcess.eCrBillFrWait Then 'Insert
            mycommand.CommandText = "INSERT Into SmSaleMt(DateSale, DateSaleD, DatePay, DateTs, DateTsD, TimeTs, DocCode, DocRefAcc, idSaleCode, DocRef, Note, " &
                              "TotalNet, Total, idPsTs, idPsSale, stBillType, stPay, idPM, idTS, stRight, idComp, idPayTsp, idSupTsp, " &
                              "idCusRefAddr, stLot, idPartner, PartnerNameBill, idCus, idFM, DiscountAmout, DiscountPerc, DiscountBath, DateSaleSys, idJobMt) " &
                              "Values(@DateSale, @DateSaleD, @DatePay, @DateTs, @DateTsD, @TimeTs, @DocCode, @DocRefAcc, @idSaleCode, @DocRef, @Note, @TotalNet, @Total," &
                              "@idPsTs, @idPsSale, @stBillType, @stPay, @idPM, @idTS, @stRight, @idComp, @idPayTsp, @idSupTsp, @idCusRefAddr, @stLot, @idPartner, @PartnerNameBill," &
                              "@idCus, @idFM, @DiscountAmout, @DiscountPerc, @DiscountBath, @DateSaleSys, @idJobMt)"

        End If

        With mycommand.Parameters
            .Add("@DateSale", SqlDbType.VarChar).Value = ksbDateToString(dtpSale.Value.ToShortDateString) 'ตามหน้า
            .Add("@DateSaleD", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpSale.Value, _cultureEnInfo) 'ตามหน้า
            .Add("@DatePay", SqlDbType.VarChar).Value = ksbDateToString(dtpPay.Value.ToShortDateString) 'ตามหน้า
            .Add("@DateTs", SqlDbType.VarChar).Value = ksbDateToString(Date.Now.ToShortDateString) 'ตามหน้า
            .Add("@DateTsD", SqlDbType.DateTime).Value = Date.Now 'ตามหน้า
            .Add("@TimeTs", SqlDbType.VarChar).Value = DateTime.Now.ToShortTimeString 'ตามหน้า
            .Add("@DocCode", SqlDbType.VarChar).Value = sDocCode 'Parameter 
            .Add("@DocRefAcc", SqlDbType.VarChar).Value = sDocRefAcc 'Parameter 
            .Add("@idSaleCode", SqlDbType.Int).Value = idSaleCode 'Parameter (Me.cmbDRCode.SelectedValue)
            .Add("@DocRef", SqlDbType.VarChar).Value = sDocRef 'Parameter 
            .Add("@Note", SqlDbType.VarChar).Value = NoteMt 'Parameter (Note)
            .Add("@TotalNet", SqlDbType.Float).Value = CDbl(txtTotalNet.Text) 'ตามหน้า
            .Add("@Total", SqlDbType.Float).Value = CDbl(txtTotalBFDisc.Text) 'ยอด Total ก่อนหักส่วนลด
            .Add("@idPsTs", SqlDbType.Int).Value = stLbl_PsTs.Tag 'ตามหน้า
            .Add("@idPsSale", SqlDbType.Int).Value = sidPsSale  'Parameter (AutoBill เป็น 0)
            .Add("@stBillType", SqlDbType.Int).Value = BillType 'Parameter
            .Add("@stPay", SqlDbType.VarChar).Value = ""
            .Add("@idPM", SqlDbType.Int).Value = Payment
            .Add("@idTS", SqlDbType.Int).Value = Transport
            .Add("@stRight", SqlDbType.Int).Value = stRight 'Parameter (รอถาม)
            .Add("@idComp", SqlDbType.Int).Value = idComp 'Parameter
            .Add("@idPayTsp", SqlDbType.Int).Value = idPayTs 'cmbTypePayTrp.SelectedValue 'การจ่ายเงินขนส่ง
            .Add("@idSupTsp", SqlDbType.Int).Value = idSupTsp 'บริษัทขนส่ง
            .Add("@idCusRefAddr", SqlDbType.Int).Value = idCusRefAddr 'ที่อยู่จัดส่ง lblAddr
            .Add("@stLot", SqlDbType.Int).Value = 1
            .Add("@idPartner", SqlDbType.Int).Value = sidPartner 'Parameter
            .Add("@PartnerNameBill", SqlDbType.VarChar).Value = PartnerNameBill 'Parameter
            .Add("@idCus", SqlDbType.Int).Value = If(sidCus = 0, DBNull.Value, sidCus)  'Parameter
            .Add("@idFM", SqlDbType.Int).Value = If(sidFM = 0, DBNull.Value, sidFM)  'Parameter
            '----------------ADD ON 25.01.2567--------------------------
            .Add("@DiscountAmout", SqlDbType.Float).Value = CDbl(txtDiscBath.Text) 'จำนวนส่วนลด (Bath)
            .Add("@DiscountPerc", SqlDbType.Float).Value = CDbl(txtAmtPerc.Text) 'ให้ % ส่วนลด
            .Add("@DiscountBath", SqlDbType.Float).Value = CDbl(lblPerc.Text) ' คำนวณ % ส่วนลด จาก Total * จำนวน %/100
            .Add("@DateSaleSys", SqlDbType.DateTime).Value = DateTime.Now
            .Add("@idJobMt", SqlDbType.Int).Value = gidJobMt
        End With

        mycommand.ExecuteNonQuery()
        mycommand.Parameters.Clear()

        If idSale = 0 Then
            Dim qr2 As String = "Select @@Identity"
            mycommand.CommandText = qr2

            idSale = mycommand.ExecuteScalar()
        End If


        Return idSale
    End Function

    Private Sub cmbTp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTp.SelectedIndexChanged
        If DGVBind.DataRowCount >= 0 Then
            mdCnOpen()
            Dim dt As New DataTable
            sDs.Tables.Clear()
            sCommand.CommandText = "Select PayDay, PayPerc From SmPaymentTermsD Where idPM =" & Me.cmbTp.SelectedValue & ""
            sAdapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("PayDay") <> 0 Then
                    Dim DateSale As Date = dtpSale.Value
                    Me.dtpPay.Value = DateSale.AddDays(dt.Rows(0).Item("PayDay"))
                Else
                    Me.dtpPay.Value = Date.Today
                End If

            End If 'End check stPage
        End If
    End Sub

End Class