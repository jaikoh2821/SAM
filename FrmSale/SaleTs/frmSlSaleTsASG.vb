Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls


Public Class frmSlSaleTsASG
    Enum eProcess
        eNewOrder
        eEditOrder
        eViewOrder
    End Enum
    Public sDt_flagpic_Rec As New DataTable
    Public CountPic As Integer = 0 'จำนวนรูป
    Dim stBType As Integer = 111 '**ไม่ใช้
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim dtRptUnit As New DataTable
    Dim Process As eProcess
    Dim stLoad As Integer = 0
    Dim ds As New DataSet
    Dim dtWaitSale As New DataTable
    Dim idSaleOrder As Integer = 0
    Dim idCus As Integer = 0
    Dim idFM As Integer = 0
    Dim idPartner As Integer = 0
    Dim idSaleS As Integer = 0
    Dim DocCodeChk As String = ""
    Dim SumSvFree As Double = 0
    Dim dt_Note As New DataTable
    Dim Result As DialogResult
    Dim stASG As Integer = 0
    Sub New(ByVal aProcess As eProcess, Optional ByVal idSale As Integer = 0, Optional ByVal dt As DataTable = Nothing)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Process = aProcess

        dtWaitSale = dt
        idSaleS = idSale
    End Sub


    Private Sub frmSlSaleTsASG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        setCmbGroupComp(Me.cmbGroupComp)
        SetDatainRpt()

        mdCnOpen()
        cmbTransport()
        cmbTps()
        cmbDRefCode()
        cmbPayTps()

        SetRightNoRight()

        InitialDatatable()

        dt_Note.Columns.Add("Note", System.Type.GetType("System.String"))
        gcNote.DataSource = dt_Note

        Select Case Process
            Case eProcess.eNewOrder
                stLbl_DateTs.Text = "วันที่ทำรายการ : " & Date.Today
                stLbl_PsTs.Text = "ผู้ทำรายการ : " & sPsName
                stLbl_PsTs.Tag = sPsId

                cmbGroupComp.SelectedValue = dtWaitSale.Rows(0).Item("idComp")

                fnLoadDataWaitToSale()

            Case eProcess.eViewOrder
                Me.Text = "ข้อมูลรายการขายสินค้าจากรายการสั่งซื้อ"
                ColAddLot.Visible = False
                ColDel.Visible = False
                ColAmtStock.Visible = False
                mdLoadShow()
                BindData()
                mdLoadCommitt()

                btnSave.Visible = False
                SimpleButton1.Visible = False

            Case eProcess.eEditOrder
                Me.Text = "แก้ไขรายการขายสินค้าจากรายการสั่งซื้อ"

                mdLoadShow()
                BindData()
                mdLoadCommitt()

                btnSave.Visible = True
                SimpleButton1.Visible = False
        End Select


        stLoad = 1
    End Sub

    Private Sub BindData()
        '------Show vSmSaleMt----'          
        Dim vDt As New DataTable

        sCommand.CommandText = "Select v.idSale, v.PartnerNameBill As CusName, v.DocCode, v.DocRefAcc, v.idSaleCode,  v.DocRef, ts.TspTypeName As Transport, " & vbNewLine &
                             "td.PaymentTerms, v.DateSale, v.DatePay, v.DateTsD, v.TimeTs, v.note, ISNULL(p2.PsName,'-') As PsSale, " & vbNewLine &
                             "v.idPsSale, p1.PsName As PsTs, v.idPsTs, v.TotalW, c.Note As NoteCus, ISNULL(v.stBillType,0) As stBillType," & vbNewLine &
                             "v.idPM, v.idTs, v.Total, ISNULL(v.DiscountPerc,0) As DiscountPerc, ISNULL(v.DiscountAmout,0) As DiscountAmout, ISNULL(v.DiscountBath,0) As DiscountBath, v.TotalNet, v.stPrice, v.stRight, " & vbNewLine &
                             "c.CusNameCon_, c.MobileCon, ISNull(c.AddressS, '') As AddressS, v.stBillType, t.idCusType, t.CusType, t.PriceRetail, " & vbNewLine &
                             "t.PriceBill, t.PriceWholeSale, t.Note As CusNote, v.stLot, v.idPayTsp, v.idSupTsp, ISNULL(p3.PsName,'-') As PsOrder, ISNULL(v.idPsOrder,0) As idPsOrder," & vbNewLine &
                             "sup.SupName, v.stBillOrder, ad.AddressS As AddressSent, v.idCusRefAddr, ad.PsRecName, ISNULL(v.SumService,0) As SumService," & vbNewLine &
                             "v.idPartner, IsNULL(v.idCus, 0) As idCus, ISNULL(v.idFm,0) As idFm, v.DateSaleD, v.DateTsD , v.idComp, IsNULL(v.idSend,0) As idSend, ISNULL(idSlAVxST,0) As idSlAVxST" & vbNewLine &
                             "FROM SmSaleMt v  " & vbNewLine &
                             "LEFT JOIN dPartner p ON v.idPartner = p.idPartner" & vbNewLine &
                             "LEFT OUTER JOIN vCustomer c ON v.idCus = c.idCus  " & vbNewLine &
                             "LEFT OUTER JOIN dCusType t ON c.idCusType = t.idCusType " & vbNewLine &
                             "LEFT JOIN vPersonxSelect p1 ON v.idPsTs = p1.idPs" & vbNewLine &
                             "LEFT JOIN vPersonxSelect p2 ON v.idPsSale = p2.idPs" & vbNewLine &
                              "LEFT JOIN vPersonxSelect p3 ON v.idPsOrder = p3.idPs" & vbNewLine &
                             "LEFT JOIN PchInvAndProject.dbo.dSupplier sup ON v.idSupTsp = sup.idSup" & vbNewLine &
                             "LEFT JOIN dTspType ts ON v.idTS = ts.idTspType " & vbNewLine &
                             "LEFT JOIN SmPaymentTermsD As td ON v.idPM  = td.idPM " & vbNewLine &
                             "LEFT JOIN dCustomerAdrSent As ad ON v.idCusRefAddr = ad.idCusRefAddr " & vbNewLine &
                             "WHERE v.idSale = " & idSaleS


        sAdapter.Fill(vDt)
        stBType = vDt.Rows(0).Item("stBillType")

        lblPartnerName.Text = vDt.Rows(0).Item("CusName")
        cmbGroupComp.SelectedValue = vDt.Rows(0).Item("idComp")
        cmbDRefCode()
        '-----------------GridViewNote--------------
        Dim dtNote As New DataTable
        dtNote.Columns.Add("Note", System.Type.GetType("System.String"))

        If vDt.Rows(0).Item("Note") <> "" Then
            Dim drNote As DataRow = dtNote.NewRow()

            Dim strArr() As String
            If IsDBNull(vDt.Rows(0).Item("Note")) Then
                vDt.Rows(0).Item("Note") = ""
            End If

            strArr = vDt.Rows(0).Item("Note").Split("\")

            For count As Integer = 0 To strArr.Length - 1
                dt_Note.Rows.Add(strArr(count))
            Next

            gcNote.DataSource = dt_Note
            gcNote.Focus()
        End If


        lblPsOrder.Text = vDt.Rows(0).Item("PsOrder")
        lblPsOrder.Tag = vDt.Rows(0).Item("idPsOrder")

        stLbl_PsTs.Text = "ผู้ทำรายการ: " & vDt.Rows(0).Item("PsTs")
        stLbl_PsTs.Tag = vDt.Rows(0).Item("PsTs")
        stLbl_DateTs.Text = "วันที่ทำรายการ: " & vDt.Rows(0).Item("DateTsD")

        SumSvFree = vDt.Rows(0).Item("SumService")
        If Not IsDBNull(vDt.Rows(0).Item("NoteCus")) Then
            lblCusNote.Text = vDt.Rows(0).Item("NoteCus")
        End If

        If Not IsDBNull(vDt.Rows(0).Item("stBillOrder")) Then
            ColCodeOrder.Visible = True
            ColCodeOrder.VisibleIndex = 2
            colAmtOrder.Visible = True
            colAmtOrder.VisibleIndex = 7
        End If

        lblDocCode.Text = vDt.Rows(0).Item("DocCode")
        If IsDBNull(vDt.Rows(0).Item("DocRefAcc")) = True Then
            lblRefAcc.Text = ""
        Else
            lblRefAcc.Text = vDt.Rows(0).Item("DocRefAcc")
        End If

        Me.cmbDRCode.SelectedValue = vDt.Rows(0).Item("idSaleCode")

        Dim DocRef() As String = vDt.Rows(0).Item("DocRef").ToString.Split(" ")

        If DocRef.Length > 1 Then
            'cmbDRCode.Text = DocRef(0)
            txtDocRef.Text = DocRef(1)
        End If

        If Not IsDBNull(vDt.Rows(0).Item("idTs")) Then
            CmbTs.SelectedValue = vDt.Rows(0).Item("idTs")
        End If
        cmbTp.SelectedValue = vDt.Rows(0).Item("idPM")

        If cmbTp.SelectedValue = 55 Then 'ชำระมัดจำ ชำระเงินมัดจำ 50.00%
            Dim PrePay As Double = (CDbl(vDt.Rows(0).Item("TotalNet")) * 50) / 100
            Me.txtPrePay.Text = Format(PrePay, "#,##0.00")
        End If

        dtpSale.Value = vDt.Rows(0).Item("DateSaleD")
        dtpPay.Value = ksbStringToDate(vDt.Rows(0).Item("DatePay"))

        idFM = vDt.Rows(0).Item("idFm")
        idPartner = vDt.Rows(0).Item("idPartner")
        idCus = vDt.Rows(0).Item("idCus")

        lblPsSale.Text = vDt.Rows(0).Item("PsSale")
        lblPsSale.Tag = vDt.Rows(0).Item("idPsSale")

        'Me.btnAddressS.Enabled = True
        If Not IsDBNull(vDt.Rows(0).Item("AddressSent")) Then
            lblAddr.Text = vDt.Rows(0).Item("AddressSent")
            lblAddr.Tag = vDt.Rows(0).Item("idCusRefAddr")
        Else ' Old case : No set idCusRefAddr on SmSaleMt
            lblAddr.Text = vDt.Rows(0).Item("AddressS")
            lblAddr.Tag = 0
        End If

        If Not IsDBNull(vDt.Rows(0).Item("PsRecName")) Then
            lblCusRec.Text = vDt.Rows(0).Item("PsRecName")
        End If

        If Not IsDBNull(vDt.Rows(0).Item("idPayTsp")) Then
            cmbTypePayTrp.SelectedValue = vDt.Rows(0).Item("idPayTsp")
        End If
        If Not IsDBNull(vDt.Rows(0).Item("idSupTsp")) Then
            Me.lblTspComp.Tag = vDt.Rows(0).Item("idSupTsp")
            Me.lblTspComp.Text = vDt.Rows(0).Item("SupName")
        End If

        txtTotalBFDisc.Text = Format(vDt.Rows(0).Item("Total"), "#,##0.00##")
        txtTotalNet.Text = Format(vDt.Rows(0).Item("TotalNet"), "#,##0.00##")

        If vDt.Rows(0).Item("DiscountPerc") <> 0 Then
            rdbPerDisc.Checked = True
            txtAmtPerc.Enabled = True
            txtDiscBath.Enabled = False

            txtAmtPerc.Text = Format(vDt.Rows(0).Item("DiscountPerc"), "#,##0.####")
            lblPerc.Text = Format(vDt.Rows(0).Item("DiscountBath"), "#,##0.00##")
        ElseIf vDt.Rows(0).Item("DiscountAmout") <> 0 Then
            rdbBathDisc.Checked = True
            txtDiscBath.Enabled = True
            txtAmtPerc.Enabled = False

            txtDiscBath.Text = Format(vDt.Rows(0).Item("DiscountAmout"), "#,##0.00##")
        End If

        If Not IsDBNull(vDt.Rows(0).Item("stRight")) Then
            If vDt.Rows(0).Item("stRight") = 1 Then
                Me.rdbRight.Checked = True
            ElseIf vDt.Rows(0).Item("stRight") = 0 Then
                Me.rdbNoRight.Checked = True
            End If
        End If


        Me.cmbDRCode.Enabled = False

        ' ----- SmSaleDt/DtPd/DtOther ------'
        ' Dim fieldPrice As String = ""
        If IsDBNull(vDt.Rows(0).Item("stPrice")) Then
            ' strdb = 1
            Me.rdbWhole.Checked = True
            '   fieldPrice = "PriceBill"
        ElseIf vDt.Rows(0).Item("stPrice") = 1 Then
            ' strdb = 1
            Me.rdbBill.Checked = True
            '  fieldPrice = "PriceBill"
        ElseIf vDt.Rows(0).Item("stPrice") = 2 Then
            ' strdb = 1
            Me.rdbRetail.Checked = True
            '  fieldPrice = "PriceRetail"
        ElseIf vDt.Rows(0).Item("stPrice") = 3 Then
            'strdb = 1
            Me.rdbWhole.Checked = True
            ' fieldPrice = "PriceWholesale"
        End If

        '----Show SmSaleDtAll on dgv ----'
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT cast(0 As bit) As chk, dt.CodeOrder, pk.PdCode, ISNULL(dt.idLot,0) As idLot, dt.LotNo, dt.LotNo As LotNoHide, dt.Amount, lm.CompRec, ord.AmountPiece As AmtOrder, dt.Amount As AmtSale," & vbNewLine &
                               "dt.Price, inv.idInvGroup, inv.idSubType, dt.DiscountPerc As PercDisc, dt.DiscountPerc As DisCountPercHide, dt.DiscountBath, dt.Price As PriceSale, dt.PriceBfDis As PriceNormal, " & vbNewLine &
                               "dt.PriceBfDis, dt.ProductName, dt.idSaleDt, dt.idUnit, dt.idProduct As idInvMain, dt.stCutStock, oMt.DocCode As CodeOrder, oMt.Note As NotePO," & vbNewLine &
                               "IsNULL(lm.idLotSPM,0) As idLotSPM, ISNULL(dt.idWh,0) As idWh, inv.idInvGroup, unit.UnitName, dt.No, dt.stWIMAllRec, (dt.Price * dt.Amount) As Total, dt.Amount As OldAmt, " & vbNewLine &
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
                                "LEFT JOIN SmSaleOrderMt oMt ON ord.idSaleOrder = oMt.idSaleOrder" & vbNewLine &
                               "WHERE dt.idSale = " & idSaleS & " Order By dt.No"
        sAdapter.Fill(sDt)

        GCSale.DataSource = sDt


        For j As Integer = 0 To DGVBind.DataRowCount - 1

            'DGVBind.GetDataRow(j).Item("Total") = DGVBind.GetDataRow(j).Item("Price") * DGVBind.GetDataRow(j).Item("Amount")

            If Not IsDBNull(DGVBind.GetDataRow(j).Item("idLot")) Then
                Dim SumStock As Double = 0.0
                For n As Integer = 0 To DGVBind.DataRowCount - 1
                    'idPdPkLot ที่เลือกมา มีในรายการแล้ว
                    If DGVBind.GetDataRow(n).Item("idLot") = DGVBind.GetDataRow(j).Item("idLot") And
                       DGVBind.GetDataRow(n).Item("idInvGroup") = DGVBind.GetDataRow(j).Item("idInvGroup") And
                       DGVBind.GetDataRow(n).Item("idWh") = DGVBind.GetDataRow(j).Item("idWh") Then

                        Dim OldAmt As Double = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(j).Item("idUnit"), DGVBind.GetDataRow(j).Item("idInvGroup"),
                                                        CDbl(DGVBind.GetDataRow(n).Item("OldAmt")), DGVBind.GetDataRow(j).Item("idInvMain"))

                        SumStock = SumStock + OldAmt
                    End If

                Next

                DGVBind.GetDataRow(j).Item("AmtStock") = CDbl(DGVBind.GetDataRow(j).Item("AmtStock")) + SumStock
            End If
        Next


        SumTotalNew()

    End Sub
    Private Sub SetDatainRpt()
        mdCnOpen()

        sCommand.CommandText = "SELECT unit.idUnit, unit.UnitName " & vbNewLine &
                               "FROM  dInvUnit unit " &
                               "WHERE stDel IS NULL "
        sAdapter.Fill(dtRptUnit)

        rptUnit.Columns.Clear()
        rptUnit.Columns.Add(New LookUpColumnInfo("UnitName"))
        rptUnit.DataSource = dtRptUnit

        rptUnit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub cmbPayTps()
        'mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select * From dPayTspType"
        sAdapter.Fill(sDt)
        With cmbTypePayTrp
            .DisplayMember = "PayTspName"
            .ValueMember = "idPayTsp"
            .DataSource = sDt
        End With
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

    Private Sub cmbTransport()
        'mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idTspType, TspTypeName From dTspType WHERE idTspType = 1 OR idTspType = 7 OR idTspType = 15 " & _
                               "OR idTspType = 16 OR idTspType = 21 Order By idTspType"
        sAdapter.Fill(sDt)
        With CmbTs
            .DisplayMember = "TspTypeName"
            .ValueMember = "idTspType"
            .DataSource = sDt
        End With
    End Sub

    Private Sub cmbDRefCode()
        'mdCnOpen()
        Dim sDt As New DataTable
        'sCommand.CommandText = "Select idSaleCode, SaleCode From SmSaleDocCode WHERE SaleCode IN (SELECT SaleCode From " & _
        '                       "SmSaleCodeComp WHERE idComp = " & sIdComp & " AND SaleCode <> 'XY')"
        sCommand.CommandText = "Select idSaleCode, SaleCode " & vbNewLine & _
                                "From SmSaleDocCode " & vbNewLine & _
                                "WHERE idSaleCode IN (SELECT idSaleCode From " & vbNewLine & _
                                "SmSaleCodeComp WHERE idComp = " & cmbGroupComp.SelectedValue & ")" & vbNewLine & _
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

    Private Sub InitialDatatable()
        Dim dtMaster As New DataTable
        dtMaster.Columns.Add("No", GetType(Integer))
        dtMaster.Columns.Add("idSaleOrderDt", GetType(Integer))
        dtMaster.Columns.Add("CodeOrder", GetType(String))
        dtMaster.Columns.Add("InvCode", GetType(String))
        dtMaster.Columns.Add("idInvMain", GetType(Integer))
        dtMaster.Columns.Add("idInvGroup", GetType(Integer))
        dtMaster.Columns.Add("ProductName", GetType(String))
        dtMaster.Columns.Add("AmtOrder", GetType(Double))
        dtMaster.Columns.Add("AmtSale", GetType(Double)) 'จำนวนขายรวม (รวมจาก Lot No. แต่ละ InvMain)
        dtMaster.Columns.Add("AmtStock", GetType(Double)) 'จำนวนคงเหลือใน Stock
        dtMaster.Columns.Add("idUnit", GetType(Integer))
        dtMaster.Columns.Add("UnitName", GetType(String))
        dtMaster.Columns.Add("PriceNormal", GetType(Double)) 'ราคาปกติ
        dtMaster.Columns.Add("PriceSale", GetType(Double)) 'ราคาขาย
        dtMaster.Columns.Add("PercDisc", GetType(Double)) 'ส่วนลด %
        dtMaster.Columns.Add("BathDisc", GetType(Double)) 'ส่วนลด (บาท)
        dtMaster.Columns.Add("Total", GetType(Double)) 'รวมเป็นเงิน
        dtMaster.Columns.Add("NotePO", GetType(String)) 'หมายเหตุ PO
        dtMaster.Columns.Add("LotNo", GetType(String))
        dtMaster.Columns.Add("idLot", GetType(Integer))
        dtMaster.Columns.Add("idWh", GetType(Integer))
        dtMaster.Columns.Add("OldAmt", GetType(Double))
        dtMaster.Columns.Add("idRefLot", GetType(Integer))
        dtMaster.Columns.Add("UnitNamePO", GetType(String))
        dtMaster.Columns.Add("idLotSPM", GetType(Integer))
        dtMaster.Columns.Add("DtType", GetType(Integer))
        dtMaster.Columns.Add("idPOTs", GetType(Integer))
        dtMaster.Columns.Add("idPODt", GetType(Integer))
        dtMaster.Columns.Add("DocCode_PO", GetType(String))

        dtMaster.Columns.Add("pWeight", System.Type.GetType("System.Double"))
        dtMaster.Columns.Add("idUnitW", System.Type.GetType("System.Int64"))
        dtMaster.TableName = "mt"


        GCSale.DataSource = dtMaster
    End Sub

    Private Sub fnLoadDataWaitToSale()
        If dtWaitSale IsNot Nothing Then
            stASG = 6 'ถ้ามาจาก Order เป็นขายจากในเครือ
            lblDocOrder.Text = dtWaitSale.Rows(0).Item("DocCode")
            ' dtpOrder.Value = dtWaitSale.Rows(0).Item("DateOrderD")

            'If Not IsDBNull(dtWaitSale.Rows(0).Item("DateRequireD")) Then
            '    dtpRequire.Value = dtWaitSale.Rows(0).Item("DateRequireD")
            'End If

            lblNoteOrder.Text = dtWaitSale.Rows(0).Item("NoteOrder")
            lblPartnerName.Text = dtWaitSale.Rows(0).Item("PartnerName")
            lblPartnerName.Tag = dtWaitSale.Rows(0).Item("idPartner")

            idCus = dtWaitSale.Rows(0).Item("idCus")
            idPartner = dtWaitSale.Rows(0).Item("idPartner")


            If Not IsDBNull(dtWaitSale.Rows(0).Item("PsOrder")) Then
                lblPsOrder.Text = dtWaitSale.Rows(0).Item("PsOrder")
            Else
                If Not IsDBNull(dtWaitSale.Rows(0).Item("idPOTs")) Then
                    lblPsOrder.Text = "สั่งซื้อจากระบบ PO"
                End If
            End If


            fnSetPartnerData(idPartner, dtWaitSale.Rows(0).Item("idComp"))


            cmbGroupComp.Enabled = False



            For i As Integer = 0 To dtWaitSale.Rows.Count - 1

                Dim dr As DataRow = dtWaitSale.Rows(i)
                DGVBind.AddNewRow()
                Dim dtLotFIFO As DataTable = fnSetDefualtLotFIFO(dr.Item("idInvMain"))
                With DGVBind
                    .SetFocusedRowCellValue(colNo, dr.Item("i"))
                    .SetFocusedRowCellValue(ColCodeOrder, dr.Item("DocCode"))
                    .SetFocusedRowCellValue(Col_idSaleOrderDt, dr.Item("idSaleOrderDt"))
                    .SetFocusedRowCellValue(ColPriceNormal, dr.Item("dNET"))
                    .SetFocusedRowCellValue(ColInvCode, dr.Item("InvCode"))
                    .SetFocusedRowCellValue(colidInvGroup, dr.Item("idInvGroup"))
                    .SetFocusedRowCellValue(colidInvMain, dr.Item("idInvMain"))
                    .SetFocusedRowCellValue(ColProductName, dr.Item("InvName"))
                    .SetFocusedRowCellValue(colAmtOrder, dr.Item("AmtOrder")) ' AmtOrder
                    .SetFocusedRowCellValue(ColUnitPO, dr.Item("UnitNameOrd"))
                    .SetFocusedRowCellValue(ColDtType, dr.Item("DtType"))
                    .SetFocusedRowCellValue(ColExp, 0)
                    .SetFocusedRowCellValue(Col_OldAmt, 0)
                    .SetFocusedRowCellValue(ColLot, If(dtLotFIFO.Rows.Count = 0, "", dtLotFIFO.Rows(0).Item("LotNo")))
                    .SetFocusedRowCellValue(Col_idLot, If(dtLotFIFO.Rows.Count = 0, 0, dtLotFIFO.Rows(0).Item("idLot")))
                    .SetFocusedRowCellValue(ColAmtStock, If(dtLotFIFO.Rows.Count = 0, 0, dtLotFIFO.Rows(0).Item("AmtStock")))

                    .SetFocusedRowCellValue(ColPriceNormal, dr.Item("dNET"))
                    .SetFocusedRowCellValue(ColPriceSale, dr.Item("dNET"))
                    .SetFocusedRowCellValue(colidRefLot, If(dtLotFIFO.Rows.Count = 0, 0, dtLotFIFO.Rows(0).Item("idRefLot")))
                    .SetFocusedRowCellValue(colidWh, If(dtLotFIFO.Rows.Count = 0, "", dtLotFIFO.Rows(0).Item("idWh")))
                    .SetFocusedRowCellValue(ColidUnit, dr.Item("idUnit"))
                    .SetFocusedRowCellValue(colUnitName, dr.Item("UnitName"))
                    .SetFocusedRowCellValue(colidLotSPM, If(dtLotFIFO.Rows.Count = 0, "", dtLotFIFO.Rows(0).Item("idLotSPM")))

                    .SetFocusedRowCellValue(ColAmtSale, If(DGVBind.GetFocusedRowCellValue("AmtOrder") >= DGVBind.GetFocusedRowCellValue("AmtStock"), DGVBind.GetFocusedRowCellValue("AmtStock"), DGVBind.GetFocusedRowCellValue("AmtOrder"))) 'Set Default Amount Sale

                    .SetFocusedRowCellValue(ColPercDiscount, 0)
                    .SetFocusedRowCellValue(ColBathDiscount, 0)
                    .SetFocusedRowCellValue(ColExp, DGVBind.GetFocusedRowCellValue("AmtSale") * DGVBind.GetFocusedRowCellValue("PriceSale"))
                    .SetFocusedRowCellValue(ColidPOTs, dr.Item("idPOTs"))
                    .SetFocusedRowCellValue(ColidPODt, dr.Item("idPODt"))
                    .SetFocusedRowCellValue(ColNotePO, dr.Item("NoteOrder"))
                    .SetFocusedRowCellValue(ColDocCodePO, dr.Item("DocCode_PO"))
                    .SetFocusedRowCellValue(ColpWeight, dr.Item("pWeight"))
                    .SetFocusedRowCellValue(ColidUnitW, dr.Item("idUnitW"))
                End With

                DGVBind.UpdateCurrentRow()
                DGVBind.RefreshData()
            Next



            SumTotalNew()
        End If
    End Sub

    Private Sub fnSetPartnerData(ByVal gidPartner As Integer, ByVal gidComp As Integer)
        mdCnOpen()
        Dim dtRegion As New DataTable

        sCommand.CommandText = "SELECT c.idPsSale, p.PsName As PsSaleName, ps.idPM" & vbNewLine & _
                                "FROM SmRegionPsSaleComp c " & vbNewLine & _
                                "LEFT JOIN  SmMkCusPs ps ON  c.idRegionC = ps.idRegionC AND ps.idComp = c.idComp" & vbNewLine & _
                                "LEFT JOIN dPartner pn ON ps.idCus = pn.idCus" & vbNewLine & _
                                "LEFT JOIN vPersonxSelect p ON c.idPsSale = p.idPs" & vbNewLine & _
                                "WHERE pn.idPartner = " & gidPartner & "" & vbNewLine & _
                                "AND ps.idComp = " & gidComp
        sAdapter.Fill(dtRegion)

        If dtRegion.Rows.Count <> 0 Then

            Me.lblPsSale.Text = dtRegion.Rows(0).Item("PsSaleName")
            Me.lblPsSale.Tag = dtRegion.Rows(0).Item("idPsSale")
            Me.cmbTp.SelectedValue = dtRegion.Rows(0).Item("idPM")
            'End If

        Else 'ไม่มีเขตการขายของลูกค้านี้

            Dim Dt2 As New DataTable
            Dt2.Clear()
            sCommand.CommandText = "SELECT p.idPs As idPsSale, p.PsName As PsSale " & vbNewLine & _
                                   "FROM SmSaleMt mt" & vbNewLine & _
                                   "LEFT JOIN vPersonxSelect p ON mt.idPsSale = p.idPs" & vbNewLine & _
                                   "Where mt.idComp = " & gidComp & vbNewLine & _
                                   "AND mt.idPartner = " & gidPartner & vbNewLine & _
                                   "ORDER By idSale DESC"
            sAdapter.Fill(Dt2)
            If Dt2.Rows.Count <> 0 Then
                MessageBox.Show("ลูกค้าคนนี้ไม่มีข้อมูลผูกกับพนักงานขาย ระบบจะดึงพนักงานขายที่มีประวัติการขายกับลูกค้าครั้งล่าสุด", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.lblPsSale.Text = Dt2.Rows(0).Item("PsSale")
                Me.lblPsSale.Tag = Dt2.Rows(0).Item("idPsSale")
            Else
                MessageBox.Show("ลูกค้าคนนี้ไม่มีข้อมูลผูกกับพนักงานขาย และไม่มีประวัติการขายสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub DGVBind_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles DGVBind.CellValueChanged
        If DGVBind.DataRowCount > 0 Then
            Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)
            Dim navigator As ControlNavigator = GCSale.EmbeddedNavigator
            'Amount Change
            If e.Column.Name = ColAmtSale.Name Or e.Column.Name = ColidUnit.Name Then

                If IsDBNull(dr.Item("AmtSale")) Then
                    dr.Item("AmtSale") = 0.0
                End If

                If e.Column.Name = ColAmtSale.Name Then

                    If IsDBNull("idLot") Then
                        dr.Item("idLot") = 0
                    End If

                    If dr.Item("idLot") = 0 And dr.Item("idInvGroup") <> 30 And dr.Item("AmtSale") <> 0 Then

                        MessageBox.Show("กรุณาเลือก Lot สินค้า ก่อนระบุจำนวนขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        dr.Item("AmtSale") = 0.0

                    End If
                End If


                If Not IsDBNull(DGVBind.GetRowCellValue(e.RowHandle, ColCodeOrder.Name)) Then
                    If DGVBind.GetRowCellValue(e.RowHandle, ColCodeOrder.Name) <> Nothing Then
                        If DGVBind.GetRowCellValue(e.RowHandle, ColAmtSale.Name) > DGVBind.GetRowCellValue(e.RowHandle, colAmtOrder.Name) Then
                            MessageBox.Show("จำนวนที่ทำรายการขายมากกว่าจำนวนที่สั่งซื้อ กรุณาตรวจสอบความถูกต้องอีกครั้ง" & vbCrLf &
                            "หากยืนยันว่าข้อมูลดังกล่าวถูกต้อง ให้ทำรายการถัดไป", sSystemName)
                        End If
                    ElseIf DGVBind.GetRowCellValue(e.RowHandle, ColCodeOrder.Name) <> "" Then
                        If DGVBind.GetRowCellValue(e.RowHandle, ColAmtSale.Name) > DGVBind.GetRowCellValue(e.RowHandle, colAmtOrder.Name) Then
                            MessageBox.Show("จำนวนที่ทำรายการขายมากกว่าจำนวนที่สั่งซื้อ กรุณาตรวจสอบความถูกต้องอีกครั้ง" & vbCrLf &
                            "หากยืนยันว่าข้อมูลดังกล่าวถูกต้อง ให้ทำรายการถัดไป", sSystemName)
                        End If
                    End If
                End If

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

                                    '---------------------Check วัสดุ เพื่อ Convert หน่วย
                                    AmountUse = fnCalAmtxUnit(sCommand, sDr.Item("idUnit"), sDr.Item("idInvGroup"),
                                                       CDbl(sDr.Item("AmtSale")), sDr.Item("idInvMain"))

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


            If e.Column.Name = ColidUnit.Name Then

                Dim SumAmtOfLot As Double = 0.0
                For i As Integer = 0 To DGVBind.DataRowCount - 1
                    Dim sDr As DataRow = DGVBind.GetDataRow(i)

                    If (sDr.Item("idLot") = dr.Item("idLot")) And sDr.Item("idInvMain") = dr.Item("idInvMain") And (sDr.Item("idRefLot") = dr.Item("idRefLot")) Then

                        Dim AmountUse As Double = 0.0
                        If IsDBNull(sDr.Item("AmtSale")) Then
                            sDr.Item("AmtSale") = 0.0
                        End If

                        AmountUse = fnCalAmtxUnit(sCommand, sDr.Item("idUnit"), sDr.Item("idInvGroup"),
                                                      CDbl(sDr.Item("AmtSale")), sDr.Item("idInvMain"))

                        SumAmtOfLot = SumAmtOfLot + AmountUse
                    End If
                Next

                ' Dim vAmtStockC As Double = 
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

                SumcolAmountExpNewGrid()
            End If

            'PriceChange
            If e.Column.Name = ColPriceNormal.Name Then

                If IsDBNull(dr.Item("PriceNormal")) Then
                    dr.Item("PriceNormal") = 0.0
                Else
                    dr.Item("PriceNormal") = CDbl(dr.Item("PriceNormal"))
                End If

                SumcolAmountExpNewGrid()
            End If

            'PriceSale
            If e.Column.Name = ColPriceSale.Name Then

                If IsDBNull(dr.Item("PriceSale")) Then
                    dr.Item("PriceSale") = 0.0
                End If

                If dr.Item("PriceNormal") = 0 Then
                    dr.Item("PriceNormal") = dr.Item("PriceSale")
                End If

                'chkUnit()
                SumcolAmountExpNewGrid()
            End If

            'Discount %
            If e.Column.Name = ColPercDiscount.Name Then

                If IsDBNull(dr.Item("PriceSale")) Then
                    dr.Item("PriceSale") = 0.0
                End If

                If IsDBNull(dr.Item("PercDisc")) Then
                    dr.Item("PercDisc") = 0.0
                End If

                If dr.Item("PercDisc") > 100 Then
                    MessageBox.Show("จำนวนส่วนลดเกิน 100% ไม่ได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    dr.Item("PercDisc") = 0.0
                    dr.Item("PriceSale") = 0.0
                End If

                dr.Item("PercDisc") = Format(CDbl(dr.Item("PercDisc")), "#,##0.00")
                If dr.Item("PercDisc") <> 0.0 Then
                    dr.Item("BathDisc") = 0.0
                End If
                'chkUnit()
                SumcolAmountExpNewGrid()
            End If

            'Discount Bath
            If e.Column.Name = ColBathDiscount.Name Then

                If IsDBNull(dr.Item("PriceSale")) Then
                    dr.Item("PriceSale") = 0.0
                End If

                If IsDBNull(dr.Item("BathDisc")) Then
                    dr.Item("BathDisc") = 0.0
                End If

                If dr.Item("BathDisc") > dr.Item("PriceNormal") Then
                    MessageBox.Show("จำนวนส่วนลดมากกว่าราคาปกติไม่ได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    dr.Item("BathDisc") = 0.0
                    dr.Item("PriceSale") = 0.0
                End If

                dr.Item("BathDisc") = Format(CDbl(dr.Item("BathDisc")), "#,##0.00")
                If dr.Item("BathDisc") <> 0.0 Then
                    dr.Item("PercDisc") = 0.0
                End If

                SumcolAmountExpNewGrid()
            End If

            'dr.Item("stEdit") = 1

        End If
    End Sub

    Private Sub SumcolAmountExpNewGrid()
        Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)
        '----- Check ส่วนลด %  ------'
        If IsDBNull(DGVBind.GetFocusedRowCellValue(ColPercDiscount)) Then
            dr.Item("PercDisc") = 0.0
        End If
        '----- Check ส่วนลด Bath  ------'
        If IsDBNull(DGVBind.GetFocusedRowCellValue(ColBathDiscount)) Then
            dr.Item("BathDisc") = 0.0
        End If

        If IsDBNull(DGVBind.GetFocusedRowCellValue(ColExp)) Then
            dr.Item("Total") = 0.0
        End If

        If IsDBNull(DGVBind.GetFocusedRowCellValue(ColAmtSale)) Then
            dr.Item("AmtSale") = 0.0
        End If

        If IsDBNull(DGVBind.GetFocusedRowCellValue(ColPriceSale)) Then
            dr.Item("PriceSale") = 0.0
        End If

        '------------Calculate ส่วนลด (%)------------
        If CDbl(DGVBind.GetFocusedRowCellValue(ColPercDiscount)) = 0.0 Then
            dr.Item("PriceSale") = DGVBind.GetFocusedRowCellValue(ColPriceNormal)
        ElseIf CDbl(DGVBind.GetFocusedRowCellValue(ColPercDiscount)) > 0.0 Then
            dr.Item("PriceSale") = DGVBind.GetFocusedRowCellValue(ColPriceNormal) - (DGVBind.GetFocusedRowCellValue(ColPriceNormal) * DGVBind.GetFocusedRowCellValue(ColPercDiscount)) / 100
            Console.WriteLine(DGVBind.GetFocusedRowCellValue(ColPriceNormal) - (DGVBind.GetFocusedRowCellValue(ColPriceNormal) * DGVBind.GetFocusedRowCellValue(ColPercDiscount)) / 100)
        Else 'ส่วนลดติดลย
            dr.Item("PerDisc") = 0.0
            dr.Item("PriceSale") = DGVBind.GetFocusedRowCellValue(ColPriceSale)
        End If

        '------------Calculate ส่วนลด (Bath)------------
        'If CDbl(DGVBind.GetFocusedRowCellValue(ColBathDiscount)) = 0.0 Then
        'dr.Item("PriceSale") = DGVBind.GetFocusedRowCellValue(ColPriceNormal)
        If CDbl(DGVBind.GetFocusedRowCellValue(ColBathDiscount)) > 0.0 Then
            dr.Item("PriceSale") = DGVBind.GetFocusedRowCellValue(ColPriceNormal) - DGVBind.GetFocusedRowCellValue(ColBathDiscount)
        Else
            dr.Item("BathDisc") = 0.0
        End If


        dr.Item("Total") = DGVBind.GetFocusedRowCellValue("PriceSale") * DGVBind.GetFocusedRowCellValue("AmtSale")

        dr.Item("PriceSale") = Format(CDbl(DGVBind.GetFocusedRowCellValue(ColPriceSale)), "#,##0.00##")
        dr.Item("PriceNormal") = Format(CDbl(DGVBind.GetFocusedRowCellValue(ColPriceNormal)), "#,##0.00##")
        dr.Item("Total") = Format(CDbl(DGVBind.GetFocusedRowCellValue(ColExp)), "#,##0.00##")

        SumTotalNew()
    End Sub


    Private Sub btnAddressS_Click(sender As Object, e As EventArgs) Handles btnAddressS.Click
        Dim vFrm As New frmCusAdsSent(frmCusAdsSent.eProcess.eSelect, idCus)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblAddr.Tag = vFrm.idCusRefAddr 'idRef update to dCustomer

            mdCnOpen()
            Dim sDt As New DataTable
            sDt.Rows.Clear()
            sCommand.CommandText = "Select s.AddressS, s.stFromS, s.PsRecName, s.idTsp, s.idPayTsp, s.idSupTsp, sp.SupName " &
                                   "From dCustomerAdrSent s LEFT OUTER JOIN PchInvAndProject.dbo.vSupplier sp ON s.idSupTsp = sp.idSup " &
                                   "Where s.idCusRefAddr = " & vFrm.idCusRefAddr
            sAdapter.Fill(sDt)

            Me.lblAddr.Text = sDt.Rows(0).Item("AddressS")
            Me.lblCusRec.Text = sDt.Rows(0).Item("PsRecName")
            Me.CmbTs.SelectedValue = sDt.Rows(0).Item("idTsp")
            Me.cmbTypePayTrp.SelectedValue = sDt.Rows(0).Item("idPayTsp")
            If Not IsDBNull(sDt.Rows(0).Item("idSupTsp")) Then
                If sDt.Rows(0).Item("idSupTsp") <> 0 Then
                    '--- Set TransportComp ----'
                    Dim TspDt As New DataTable
                    TspDt.Rows.Clear()
                    sCommand.CommandText = "Select idCusRefAddr, idSupTsp, SupName FROM vCusAdrSetTransport WHERE " &
                                   "idCus = " & vFrm.idCusRefAddr & " AND idComp = " & cmbGroupComp.SelectedValue
                    sAdapter.Fill(TspDt)

                    If TspDt.Rows.Count = 0 Then
                        Me.lblTspComp.Tag = sDt.Rows(0).Item("idSupTsp")
                        Me.lblTspComp.Text = sDt.Rows(0).Item("SupName")
                    ElseIf TspDt.Rows.Count = 1 Then
                        Me.lblTspComp.Tag = TspDt.Rows(0).Item("idSupTsp")
                        Me.lblTspComp.Text = TspDt.Rows(0).Item("SupName")
                    Else 'มีหลายรายการ
                        For i As Integer = 0 To TspDt.Rows.Count - 1
                            If vFrm.idCusRefAddr = TspDt.Rows(i).Item("idCusRefAddr") Then
                                Me.lblTspComp.Tag = TspDt.Rows(i).Item("idSupTsp")
                                Me.lblTspComp.Text = TspDt.Rows(i).Item("SupName")
                            End If
                        Next
                    End If

                End If
            End If
        End If
    End Sub

    Public Function ExpandDetailsT(ByVal gv As GridView)
        For i As Integer = 0 To gv.DataRowCount - 1
            gv.SetMasterRowExpanded(i, True)
        Next
        Return gv
    End Function

    Private Sub rptCheckPrice_Click(sender As Object, e As EventArgs) Handles rptCheckPrice.Click
        If DGVBind.FocusedRowHandle >= 0 Then
            Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)
            Dim vFrm As New frmSlPrice(frmSlPrice.eProcess.eViewPrice, DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idInvMain"), idPartner, cmbGroupComp.SelectedValue)

            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                dr.Item("PriceSale") = vFrm.PriceSelect
                dr.Item("PriceNormal") = vFrm.PriceSelect
                dr.Item("PercDisc") = Format(CDbl(0.0), "#,##0.00")
                dr.Item("Total") = DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("PriceSale") * DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtSale")
            End If

            SumTotalNew()
        End If
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

        If rdbPerDisc.Checked = True Then
            txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - (CDbl(txtTotalBFDisc.Text.Trim) * CDbl(txtAmtPerc.Text.Trim) / 100), "#,##0.00##")
        ElseIf rdbBathDisc.Checked = True Then
            txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - CDbl(txtDiscBath.Text.Trim), "#,##0.00##")
        End If
    End Sub

    Private Sub btnRefDoc_Click(sender As Object, e As EventArgs) Handles btnRefDoc.Click
        Dim vFrm As New frmSaleDocCode
        vFrm.Show()
    End Sub

    Private Sub rpttxtLotNo_KeyDown(sender As Object, e As KeyEventArgs) Handles rpttxtLotNo.KeyDown
        Dim navigator As ControlNavigator = GCSale.EmbeddedNavigator
        If e.KeyCode = Keys.Back Then
            Exit Sub
        End If

        If idPartner = 0 Then
            MessageBox.Show("กรุณาเลือกลูกค้าก่อนทำรายการขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SendKeys.SendWait("{BACKSPACE}")
            navigator.Buttons.DoClick(navigator.Buttons.Remove)

            Exit Sub
        End If


        If e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Enter Then

            mdCnOpen()

            navigator.Buttons.DoClick(navigator.Buttons.EndEdit)

            Dim eText As String = ""
            Dim sLotNo As String = ""
            Dim sidInvMain As Integer = 0
            Dim sInvName As String = ""

            If DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "LotNo") = "" And IsDBNull(DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain")) Then
                MessageBox.Show("กรุณาระบุ Lot No. เพื่อค้นหาข้อมูล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If IsDBNull(DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain")) Then
                eText = frmLotSelect.eProcess.eSelectxLot
                sLotNo = DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "LotNo")
                sidInvMain = 0
                sInvName = ""

            Else
                eText = frmLotSelect.eProcess.eSelectxInv
                sLotNo = DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "LotNo")
                sidInvMain = DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain")
                sInvName = DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "ProductName")
            End If

            Dim vFrm As New frmLotSelect(eText, cmbGroupComp.SelectedValue, cmbGroupComp.Text, sLotNo, sidInvMain, sInvName)

            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

                If vFrm.dtLotReturn.Rows.Count > 0 And DGVBind.DataRowCount > 0 Then

                    If IsDBNull(DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idSaleDt")) Then
                        DGVBind.SetFocusedRowCellValue("idSaleDt", 0)
                    End If

                    DGVBind.SetFocusedRowCellValue("PdCode", vFrm.dtLotReturn.Rows(0).Item("InvCode"))
                    DGVBind.SetFocusedRowCellValue("idInvMain", vFrm.dtLotReturn.Rows(0).Item("idInvMain"))

                    DGVBind.SetFocusedRowCellValue("ProductName", vFrm.dtLotReturn.Rows(0).Item("InvName"))
                    DGVBind.SetFocusedRowCellValue("LotNo", vFrm.dtLotReturn.Rows(0).Item("LotNo"))
                    DGVBind.SetFocusedRowCellValue("idInvGroup", vFrm.dtLotReturn.Rows(0).Item("idInvGroup"))
                    DGVBind.SetFocusedRowCellValue("idLotSPM", vFrm.dtLotReturn.Rows(0).Item("idLotSPM"))
                    DGVBind.SetFocusedRowCellValue("idSubType", vFrm.dtLotReturn.Rows(0).Item("idSubType"))
                    DGVBind.SetFocusedRowCellValue("idRefLot", vFrm.dtLotReturn.Rows(0).Item("idRefLot"))

                    Dim dtSetPrice As New DataTable
                    dtSetPrice.Clear()

                    sCommand.CommandText = "SELECT CONVERT(bit,0) As ChkKey, gr.DtType, ic.InvCode, main.idInvMain, main.InvName, main.idInvGroup, gr.InvGroupName," & vbNewLine &
                                             "unit.UnitName, main.idUnit, main.idSubType, fg.ShortName," & vbNewLine &
                                             "ISNULL(fg.PriceBill,0) As PriceBill_fg, ISNULL(fg.PriceWholesale,0) As PriceWholesale_fg, IsNULL(fg.PriceRetail,0) As PriceRetail_fg," & vbNewLine &
                                             "IsNULL(pdo.Price,0) As PricePdo_pdo, IsNULL(pdo.CreditThirty,0) As CreditThirty_pdo, IsNULL(pdo.CreditSixty,0) As CreditSixty_pdo , " & vbNewLine &
                                             "IsNULL(sfg.Price,0) As PriceSeedFg_sfg, ISNULL(d.Price,0) As PriceSeed ," & vbNewLine &
                                              "(SELECT ISNull(SUM(Amount), 0.0)" & vbNewLine &
                                                  "FROM dInvLotMain As d" & vbNewLine &
                                                  "LEFT JOIN dInvLotRefWh As w ON d.idLot = w.idLot" & vbNewLine &
                                                  "WHERE d.idInvMain = main.idInvMain AND stDel Is NULL AND d.CompRec = " & cmbGroupComp.SelectedValue & ") As amount" & vbNewLine &
                                              "FROM dInventoryMain As main" & vbNewLine &
                                              "LEFT JOIN dInvUnit As unit ON main.idUnit = unit.idUnit " & vbNewLine &
                                              "LEFT JOIN dInvGroup As gr ON main.idInvGroup = gr.idInvGroup" & vbNewLine &
                                               "LEFT JOIN dInvCode As ic ON main.idInvMain = ic.idInvMain " & vbNewLine &
                                              "LEFT JOIN dPackingPdSet fg ON main.idSubType = fg.idPdPk AND main.idInvGroup = 2" & vbNewLine &
                                              "LEFT JOIN SmPdOtherD pdo On main.idSubType = pdo.idPdo AND gr.stpdOther = 1" & vbNewLine &
                                              "LEFT JOIN dSeedFlPackage sfg ON main.idSubType = sfg.idFlPk AND main.idInvgroup = 42" & vbNewLine &
                                              "LEFT JOIN dSeedProductPrice d ON main.idInvMain = d.idInvMain AND main.idInvGroup = 1 AND d.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                              "WHERE  main.idInvmain = " & vFrm.dtLotReturn.Rows(0).Item("idInvMain")
                    sAdapter.Fill(dtSetPrice)

                    fnSetPriceNormal(dtSetPrice)
                    ' DGVBind.SetFocusedRowCellValue("PriceNormal", 0) 'ส่วนลด %
                    DGVBind.SetFocusedRowCellValue("PercDisc", 0) 'ส่วนลด %
                    DGVBind.SetFocusedRowCellValue("BathDisc", 0) 'ส่วนลด (บาท)
                    'DGVBind.SetFocusedRowCellValue("PriceSale", 0) 'ราคาขาย
                    DGVBind.SetFocusedRowCellValue("OldAmt", 0)

                    ' DGVBind.SetFocusedRowCellValue("Total", 0) 'รวมเป็นเงิน


                    'DGVBind.SetFocusedRowCellValue("AmtStock", vFrm.dtLotReturn.Rows(0).Item("AmtStock")) 'จน.คงเหลือใน Stock
                    DGVBind.SetFocusedRowCellValue("idWh", vFrm.dtLotReturn.Rows(0).Item("idWh"))
                    DGVBind.SetFocusedRowCellValue("DtType", vFrm.dtLotReturn.Rows(0).Item("DtType"))
                    DGVBind.SetFocusedRowCellValue("CompRec", vFrm.dtLotReturn.Rows(0).Item("CompRec"))




                    Dim SumStockinBill As Double = 0.0

                    For j As Integer = 0 To DGVBind.DataRowCount - 1
                        If Not IsDBNull(DGVBind.GetDataRow(j).Item("idLot")) Then
                            If DGVBind.GetDataRow(j).Item("idLot") <> 0 Then
                                If (DGVBind.GetDataRow(j).Item("idLot") = vFrm.dtLotReturn.Rows(0).Item("idLot")) And
                                (DGVBind.GetDataRow(j).Item("idWh") = vFrm.dtLotReturn.Rows(0).Item("idWh")) Then

                                    Dim CalAmt As Double = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(j).Item("idUnit"), DGVBind.GetDataRow(j).Item("idInvGroup"),
                                                       CDbl(DGVBind.GetDataRow(j).Item("OldAmt")), DGVBind.GetDataRow(j).Item("idInvMain"))


                                    SumStockinBill = SumStockinBill + CalAmt
                                End If
                            End If
                        End If
                    Next
                    DGVBind.SetFocusedRowCellValue("idLot", vFrm.dtLotReturn.Rows(0).Item("idLot"))

                    If DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idInvGroup") <> 30 Then
                        DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtStock") = vFrm.dtLotReturn.Rows(0).Item("AmtStock") + SumStockinBill

                    ElseIf DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("idInvGroup") = 30 Then
                        'ถ้าเป็น idInvGroup = 30 ให้ Stock = 0
                        DGVBind.GetDataRow(DGVBind.FocusedRowHandle).Item("AmtStock") = 0
                    End If

                    DGVBind.SetFocusedRowCellValue("idUnit", vFrm.dtLotReturn.Rows(0).Item("idUnit"))
                    DGVBind.SetFocusedRowCellValue("UnitName", vFrm.dtLotReturn.Rows(0).Item("UnitName"))

                    Dim defaultAmtSale As Double = 0.0
                    If vFrm.dtLotReturn.Rows(0).Item("AmtStock") >= 1 And cmbGroupComp.SelectedValue <> 2 Then
                        defaultAmtSale = 1
                    Else
                        defaultAmtSale = vFrm.dtLotReturn.Rows(0).Item("AmtStock")
                    End If

                    DGVBind.SetFocusedRowCellValue("AmtSale", defaultAmtSale)  'จำนวนขาย

                    SendKeys.SendWait("{Right}")
                    'Else
                    '    navigator.Buttons.DoClick(navigator.Buttons.Remove)
                End If
            Else
                navigator.Buttons.DoClick(navigator.Buttons.Remove)
            End If
        End If


    End Sub

    Private Sub fnSetPriceNormal(ByVal dt As DataTable)
        Dim dtLastPrice As New DataTable
        Dim gLastPrice As Double = 0.0

        Dim PriceNormal As Double = 0
        Dim LastPrice As Double = 0

        sCommand.CommandText = "SELECT Top(1) ISNULL(dt.Price,0) As LastPrice " & vbNewLine &
                                "FROM SmSaleDtAll dt " & vbNewLine &
                                "LEFT OUTER JOIN SmSaleMt mt ON dt.idsale = mt.idSale " & vbNewLine &
                                "WHERE mt.idPartner = " & idPartner & vbNewLine &
                                "AND dt.idProduct =  " & DGVBind.GetRowCellValue(DGVBind.FocusedRowHandle, "idInvMain") & vbNewLine &
                                "AND mt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                "AND dt.Price > 0 " & vbNewLine &
                                "Order by mt.DateSale DESC "
        sAdapter.Fill(dtLastPrice)

        If dtLastPrice.Rows.Count <> 0 Then
            gLastPrice = dtLastPrice.Rows(0).Item("LastPrice")
        End If

        Select Case dt.Rows(0).Item("idInvGroup")
            Case 1 'สินค้าวัตถุดิบ
                PriceNormal = dt.Rows(0).Item("PriceSeed")

                If gLastPrice <> 0 Then
                    LastPrice = gLastPrice
                Else
                    LastPrice = dt.Rows(0).Item("PriceSeed")
                End If

            Case 2 'สินค้าสำเร็จรูป FG
                If Me.rdbWhole.Checked = True Then
                    PriceNormal = dt.Rows(0).Item("PriceWholesale_fg")
                ElseIf Me.rdbRetail.Checked = True Then
                    PriceNormal = dt.Rows(0).Item("PriceRetail_fg")
                ElseIf Me.rdbBill.Checked = True Then
                    PriceNormal = dt.Rows(0).Item("PriceBill_fg")
                End If

            Case 29 'สินค้าพลาสติก
                If Me.cmbTp.SelectedValue = 49 Then  ' credit 30
                    PriceNormal = dt.Rows(0).Item("CreditThirty_pdo")
                    If gLastPrice <> 0 Then
                        LastPrice = gLastPrice
                    Else
                        LastPrice = dt.Rows(0).Item("CreditThirty_pdo")
                    End If

                ElseIf Me.cmbTp.SelectedValue = 50 Then  ' credit 60
                    PriceNormal = dt.Rows(0).Item("CreditSixty_pdo")
                    If gLastPrice <> 0 Then
                        LastPrice = gLastPrice
                    Else
                        LastPrice = dt.Rows(0).Item("CreditSixty_pdo")
                    End If

                Else  ' Other
                    PriceNormal = dt.Rows(0).Item("PricePdo_pdo")
                    If gLastPrice <> 0 Then
                        LastPrice = gLastPrice
                    Else
                        LastPrice = dt.Rows(0).Item("PricePdo_pdo")
                    End If
                End If

            Case 42 ' สินค้าเมล็ดพันธุ์สำเร็จรูป FG (หน่วย ซอง)
                PriceNormal = dt.Rows(0).Item("PriceSeedFg_sfg")

            Case Else ' Other Type except FG (idInvGroup = 2)

                PriceNormal = dt.Rows(0).Item("PricePdo_pdo")

                If gLastPrice <> 0 Then
                    LastPrice = gLastPrice
                Else
                    LastPrice = dt.Rows(0).Item("PricePdo_pdo")
                End If
        End Select

        If PriceNormal <> 0 Then
            LastPrice = PriceNormal
        Else
            LastPrice = gLastPrice
            PriceNormal = gLastPrice
        End If


        DGVBind.SetFocusedRowCellValue("PriceNormal", PriceNormal)
        DGVBind.SetFocusedRowCellValue("PriceSale", LastPrice)
        DGVBind.SetFocusedRowCellValue("Total", LastPrice)
    End Sub

    Private Sub GVLotToSale_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs)
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNo" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If
    End Sub

    Private Sub cmbDRCode_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbDRCode.SelectedValueChanged
        If stLoad = 1 Then
            CheckCodeRefDup()

            '--- Check ถูกหลัก/ไม่ถูกหลัก ---'
            If Me.cmbDRCode.Text <> "" Then
                mdCnOpen()
                SetRightNoRight()
            End If
        End If
    End Sub

    Private Sub SetRightNoRight()
        Dim tempDt As New DataTable

        sCommand.CommandText = "SELECT stRight " & vbNewLine &
                               "FROM SmSaleCodeComp " & vbNewLine &
                               "WHERE idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                               "AND SaleCode = '" & Me.cmbDRCode.Text & "'"
        sAdapter.Fill(tempDt)

        If tempDt.Rows(0).Item("stRight") = 1 Then
            Me.rdbRight.Checked = True
        Else
            Me.rdbNoRight.Checked = True
        End If
    End Sub

    Private Sub CheckCodeRefDup()
        mdCnOpen()
        mdLoadShow()
        If Trim(Me.txtDocRef.Text) <> "" Then
            Dim CodeRef As String = Trim(Me.cmbDRCode.Text) & " " & Trim(Me.txtDocRef.Text)

            If CodeRef <> DocCodeChk Then
                '----Check DocRef -------'
                Dim dRefDt As New DataTable
                Dim vWHERE As String = ""

                If Process = eProcess.eEditOrder Then 'EditData
                    vWHERE = " AND idSale <> " & idSaleS & ""
                End If

                sCommand.CommandText = "Select mt.DocCode, mt.DateSale, mt.DocRef, mt.idPscancel, p.PartnerName" & vbNewLine &
                                        "From SmSaleMt mt " & vbNewLine &
                                        "LEFT OUTER JOIN dPartner p ON mt.idPartner = p.idPartner  " & vbNewLine &
                                        "Where mt.idPscancel IS NULL AND mt.DocRef = '" & CodeRef & "' AND mt.idComp = " & cmbGroupComp.SelectedValue & "" & vWHERE
                sAdapter.Fill(dRefDt)

                If dRefDt.Rows.Count > 0 Then
                    mdLoadCommitt()
                    DocCodeChk = ""
                    MessageBox.Show("เลขที่อ้างอิงซ้ำกับข้อมูลเดิม รายละเอียดรายการดังนี้ " & vbCrLf & "เลขที่รายการ : " & dRefDt.Rows(0).Item("DocCode") & vbCrLf &
                    "วันที่ขาย : " & ksbStringToDate(dRefDt.Rows(0).Item("DateSale")) & vbCrLf &
                    "ชื่อลูกค้า : " & dRefDt.Rows(0).Item("PartnerName") & vbCrLf & vbCrLf &
                    "***หากต้องการบันทึก ให้เพิ่มตัวอักษรหลังรหัส ดังนี้" & vbCrLf &
                    "   A : แอ๊ดว้านซีดส์" & vbCrLf &
                    "   F : โฟลเทคซีดส์" & vbCrLf & " เช่น 5710001A หรือ 5710001F", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtDocRef.Focus()
                    Exit Sub
                End If
                DocCodeChk = CodeRef
            End If
        End If
        mdLoadCommitt()
    End Sub

    Private Function fnSetDefualtLotFIFO(ByVal idInvMain As Integer) As DataTable
        mdCnOpen()

        Dim dtLot As New DataTable
        Dim strComp As String = ""
        Dim strQidLot As String = ""
        If cmbGroupComp.SelectedValue = 4 Or cmbGroupComp.SelectedValue = 10 Then
            strComp = "AND lm.CompRec IN (4,10)"
        Else
            strComp = "AND lm.CompRec = " & cmbGroupComp.SelectedValue
        End If

        sCommand.CommandText = "SELECT ref.idRefLot, lm.idLot, inv.idInvMain, ref.idWh, inv.idUnit, inv.InvName, " & vbNewLine & _
                               "d.ShortName, inv.idInvGroup, lm.LotNo, unit.idUnit, g.InvGroupName, " & vbNewLine & _
                               "unit.UnitName, swh.WareHouseName, inv.idSubType, g.DtType, ISNULL(lm.idLotSPM,0) As idLotSPM," & vbNewLine & _
                               "(ref.Amount - (SELECT ISNULL(SUM(AmountWaitChange),0) " & vbNewLine & _
                                                "FROM WimWaitCutDt wDt " & vbNewLine & _
                                                "LEFT JOIN WimWaitCutMt wMt ON wDt.idWaitCutMt = wMt.idWaitCutMt" & vbNewLine & _
                                                "WHERE wDt.idLot = lm.idLot" & vbNewLine & _
                                                "AND ref.idWh = wDt.idWh" & vbNewLine & _
                                                "AND wDt.stWait Is NULL" & vbNewLine & _
                                                "AND wMt.stCancel Is NULL" & vbNewLine & _
                                                "AND wDt.stDel Is NULL)) As AmtStock" & vbNewLine & _
                               "FROM dInvLotRefWh As ref" & vbNewLine & _
                               "LEFT JOIN dInvLotMain As lm ON  ref.idLot = lm.idLot" & vbNewLine & _
                               "LEFT JOIN dInventoryMain As inv ON lm.idInvMain = inv.idInvMain" & vbNewLine & _
                               "LEFT JOIN dInvGroup As g ON inv.idInvGroup = g.idInvGroup" & vbNewLine & _
                               "LEFT JOIN dInvUnit As unit ON ref.idUnit = unit.idUnit " & vbNewLine & _
                               "LEFT JOIN SsWareHouse As swh ON ref.idWh = swh.idWh" & vbNewLine & _
                               "LEFT JOIN dPackingPdSet As d ON inv.idSubType = d.idPdPk And inv.idInvGroup = 2" & vbNewLine & _
                               "WHERE lm.stDel Is NULL" & vbNewLine & _
                               "AND (ref.Amount - (SELECT ISNULL(SUM(AmountWaitChange),0) " & vbNewLine & _
                                                "FROM WimWaitCutDt wDt " & vbNewLine & _
                                                "LEFT JOIN WimWaitCutMt wMt ON wDt.idWaitCutMt = wMt.idWaitCutMt" & vbNewLine & _
                                                "WHERE wDt.idLot = lm.idLot" & vbNewLine & _
                                                "AND ref.idWh = wDt.idWh" & vbNewLine & _
                                                "AND wDt.stWait Is NULL" & vbNewLine & _
                                                "AND wMt.stCancel Is NULL" & vbNewLine & _
                                                "AND wDt.stDel Is NULL)) > 0" & vbNewLine & _
                               "AND lm.idInvMain = " & idInvMain & vbNewLine & _
                                strQidLot & vbNewLine & _
                                strComp & vbNewLine & " Order By lm.DateGen"

        sAdapter.Fill(dtLot)

        Return dtLot

    End Function

    Private Function fnCalAmtxUnit(ByVal mycommand As SqlCommand, ByVal idUnit As Integer, ByVal idInvGroup As Integer, ByVal AmtSale As Double, ByVal idInvMain As Integer) As Double
        Dim CalAmt As Double = 0.0
        Dim myAdapter = New SqlDataAdapter(mycommand)
        '------แปลงหน่วย ก่อน คืน + เพิ่ม สต๊อกกกกกก
        If idInvGroup = 1 And idUnit = 1 Then ' วัตถุดิบ + กรัม
            CalAmt = CDbl(AmtSale) / 1000

        Else

            Dim dtInvUnitSub As New DataTable
            mdCnOpen()

            dtInvUnitSub.Clear()

            mycommand.CommandText = "SELECT ISNULL(AmtMainperSub,0) As AmtMainperSub, idSubUnit, idUnit " & vbNewLine & _
                                   "FROM  dInvUnitSub " & vbNewLine & _
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

        Dim dtS As DataTable = dtRptUnit.Clone
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
                drs = dtRptUnit.Select("idUnit IN (1,2) ")
            Else
                drs = dtRptUnit.Select("idUnit IN (" & temp_.Rows(0).Item("idUnit") & ")")
            End If

        Else

            'Dim idUnitSub As New DataTable
            'sCommand.CommandText = "SELECT idUnit, idSubUnit FROM dInvUnitSub WHERE idInvMain = " & idInvMain
            'sAdapter.Fill(idUnitSub)

            'If idUnitSub.Rows.Count > 0 Then
            '    If idUnit = idUnitSub.Rows(0).Item("idSubUnit") Then
            '        StrUnit &= idUnitSub.Rows(0).Item("idSubUnit").ToString + ","

            '        For i As Integer = 0 To idUnitSub.Rows.Count - 1
            '            'Dim dr As DataRow = dr.Item("idUnit").Rows(i)
            '            StrUnit &= idUnitSub.Rows(i).Item("idUnit").ToString
            '            StrUnit &= ","
            '        Next

            '    Else

            '        StrUnit &= idUnit.ToString + ","

            '        ' If idUnitSub.Rows.Count > 0 Then
            '        For i As Integer = 0 To idUnitSub.Rows.Count - 1
            '            'Dim dr As DataRow = dr.Item("idSubUnit").Rows(i)
            '            StrUnit &= idUnitSub.Rows(i).Item("idSubUnit").ToString
            '            StrUnit &= ","

            '        Next
            '        'End If

            '    End If
            '    drs = dtRptUnit.Select("idUnit in(" & StrUnit & ")")
            'Else
            drs = dtRptUnit.Select("idUnit = " & idUnit)
            'End If
        End If

        For Each dr As DataRow In drs
            dtS.ImportRow(dr)
        Next

        Return dtS


    End Function

    Private Sub rptDel_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptDel.ButtonClick
        If DGVBind.FocusedRowHandle >= 0 Then

            If lbrMsg.MsgQuestion("คุณต้องการลบรายการใช่หรือไม่?") = True Then
                Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)
                dr.Delete()
            End If

            SumTotalNew()

        End If

    End Sub

    Private Sub rdbBathDisc_CheckedChanged(sender As Object, e As EventArgs) Handles rdbBathDisc.CheckedChanged
        If stLoad = 1 Then
            If rdbBathDisc.Checked = True Then
                txtAmtPerc.Text = 0
                lblPerc.Text = 0
                txtAmtPerc.Enabled = False
                txtDiscBath.Enabled = True
                txtDiscBath.Focus()
            Else
                txtDiscBath.Text = 0
                txtDiscBath.Enabled = False
            End If

            If rdbPerDisc.Checked = True Then
                lblPerc.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) * CDbl(txtAmtPerc.Text.Trim) / 100, "#,##0.00##")
                txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - (CDbl(txtTotalBFDisc.Text.Trim) * CDbl(txtAmtPerc.Text.Trim) / 100), "#,##0.00##")
            ElseIf rdbBathDisc.Checked = True Then
                txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - CDbl(txtDiscBath.Text.Trim), "#,##0.00##")
            End If

        End If
    End Sub

    Private Sub rdbPerDisc_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPerDisc.CheckedChanged
        If stLoad = 1 Then
            If rdbPerDisc.Checked = True Then
                txtAmtPerc.Text = 0
                txtAmtPerc.Enabled = True
                txtAmtPerc.Focus()
            Else
                txtDiscBath.Text = 0
                txtDiscBath.Enabled = False


            End If

            If rdbPerDisc.Checked = True Then
                lblPerc.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) * CDbl(txtAmtPerc.Text.Trim) / 100, "#,##0.00##")
                txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - (CDbl(txtTotalBFDisc.Text.Trim) * CDbl(txtAmtPerc.Text.Trim) / 100), "#,##0.00##")
            ElseIf rdbBathDisc.Checked = True Then
                txtTotalNet.Text = Format(CDbl(txtTotalBFDisc.Text.Trim) - CDbl(txtDiscBath.Text.Trim), "#,##0.00##")
            End If
        End If
    End Sub

    Private Sub rptAddLot_Click(sender As Object, e As EventArgs) Handles rptAddLot.Click

        Dim dr As DataRow = DGVBind.GetDataRow(DGVBind.FocusedRowHandle)

        DGVBind.AddNewRow()

        With DGVBind
            .SetFocusedRowCellValue(colNo, dr("No"))
            .SetFocusedRowCellValue(ColCodeOrder, dr("CodeOrder"))
            .SetFocusedRowCellValue(Col_idSaleOrderDt, dr.Item("idSaleOrderDt"))
            .SetFocusedRowCellValue(ColInvCode, dr.Item("InvCode"))
            .SetFocusedRowCellValue(colidInvGroup, dr.Item("idInvGroup"))
            .SetFocusedRowCellValue(colidInvMain, dr("idInvMain"))
            .SetFocusedRowCellValue(ColProductName, dr("ProductName"))
            .SetFocusedRowCellValue(colAmtOrder, dr.Item("AmtOrder")) ' AmtOrder
            .SetFocusedRowCellValue(ColUnitPO, dr.Item("UnitNamePO"))

            .SetFocusedRowCellValue(ColLot, "")
            .SetFocusedRowCellValue(Col_idLot, 0)
            .SetFocusedRowCellValue(ColAmtStock, 0)

            .SetFocusedRowCellValue(ColPriceNormal, dr.Item("PriceNormal"))
            .SetFocusedRowCellValue(ColPriceSale, dr.Item("PriceSale"))
            .SetFocusedRowCellValue(colidRefLot, 0)
            .SetFocusedRowCellValue(colidWh, 0)
            .SetFocusedRowCellValue(ColidUnit, dr.Item("idUnit"))
            .SetFocusedRowCellValue(colUnitName, dr.Item("UnitName"))

            .SetFocusedRowCellValue(ColAmtSale, 0) 'Set Default Amount Sale

            .SetFocusedRowCellValue(ColPercDiscount, dr.Item("PercDisc"))
            .SetFocusedRowCellValue(ColBathDiscount, dr.Item("BathDisc"))
            .SetFocusedRowCellValue(ColExp, dr.Item("Total"))
            .SetFocusedRowCellValue(Col_OldAmt, 0)

            .SetFocusedRowCellValue(ColNotePO, dr.Item("NotePO"))
            .SetFocusedRowCellValue(ColidPODt, dr.Item("idPODt"))
            .SetFocusedRowCellValue(ColidPOTs, dr.Item("idPOTs"))
            .SetFocusedRowCellValue(ColidUnitW, dr.Item("idUnitW"))
            .SetFocusedRowCellValue(ColpWeight, dr.Item("pWeight"))


        End With

        DGVBind.UpdateCurrentRow()
        DGVBind.RefreshData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If lblPartnerName.Text = "" Then

            MessageBox.Show("กรุณาเลือกชื่อลูกค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf lblPsSale.Text = "" Then

            MessageBox.Show("กรุณาเลือกเจ้าหน้าที่ขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf txtDocRef.Text = "" Then

            MessageBox.Show("กรุณากรอกเลขที่อ้างอิง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtDocRef.Focus()
            Exit Sub
        ElseIf Me.rdbRight.Checked = False And Me.rdbNoRight.Checked = False Then

            MessageBox.Show("กรุณาเลือกประเภทบิลถูกหลัก/ไม่ถูกหลักก่อนกดบันทึก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        mdCnOpen()

        'Sum Amount each Lot
        Dim tempSaleDt As New DataTable
        tempSaleDt.Columns.Add("idLot", System.Type.GetType("System.Int64"))
        tempSaleDt.Columns.Add("idInvGroup", System.Type.GetType("System.Int64"))
        tempSaleDt.Columns.Add("SumAmount", System.Type.GetType("System.Double"))
        tempSaleDt.Columns.Add("OldAmount", System.Type.GetType("System.Double"))
        'tempSaleDt.Columns.Add("idWh", System.Type.GetType("System.Double"))
        tempSaleDt.Columns.Add("idRefLot", System.Type.GetType("System.Int64"))
        '--------------------NEW GRID----------------------------------
        '--------------------------------------------------------------
        For i As Integer = 0 To DGVBind.DataRowCount - 1
            '*****Check row is nothing*****'
            If IsDBNull(DGVBind.GetDataRow(i).Item("idInvMain")) Then
                MessageBox.Show("มีลำดับข้อมูล ที่ไม่มีรายการสินค้า กรุณาตรวจสอบก่อนบันทึกอีกครั้ง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' ถ้าเคสที่ ขายแบบไม่มี Lot ก็จะรอด ISDBNULL(DGVBind.GetDataRow(i).Item("idLot"))
            If IsDBNull(DGVBind.GetDataRow(i).Item("idLot")) Then
                DGVBind.GetDataRow(i).Item("idLot") = 0
            End If

            If DGVBind.GetDataRow(i).Item("idInvGroup") <> 30 And DGVBind.GetDataRow(i).Item("idLot") = 0 Then
                MessageBox.Show("กรุณาเลือก Lot ของสินค้าให้ครบทุกรายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If DGVBind.GetDataRow(i).Item("AmtSale") = 0 Then
                MessageBox.Show("มีบางรายการระบุจำนวนขายเท่ากับ 0 ระบบจึงไม่สามารถบันทึกข้อมูลได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            '--- Check Stock ----'
            Dim AmountUse As Double = fnCalAmtxUnit(sCommand, DGVBind.GetDataRow(i).Item("idUnit"), DGVBind.GetDataRow(i).Item("idInvGroup"),
                                DGVBind.GetDataRow(i).Item("AmtSale"), DGVBind.GetDataRow(i).Item("idInvMain"))

            If i = 0 Then '1st row
                tempSaleDt.Rows.Add(DGVBind.GetDataRow(i).Item("idLot"), DGVBind.GetDataRow(i).Item("idInvGroup"), AmountUse,
                                        DGVBind.GetDataRow(i).Item("OldAmt"), DGVBind.GetDataRow(i).Item("idRefLot"))
            Else

                Dim stAdd As Integer = 0
                For j As Integer = 0 To tempSaleDt.Rows.Count - 1
                    If DGVBind.GetDataRow(i).Item("idLot") = tempSaleDt.Rows(j).Item("idLot") And
                           DGVBind.GetDataRow(i).Item("idInvGroup") = tempSaleDt.Rows(j).Item("idInvGroup") And
                           DGVBind.GetDataRow(i).Item("idRefLot") = tempSaleDt.Rows(j).Item("idRefLot") Then

                        'tempSaleDt.Rows(j).Item("SumAmount") = tempSaleDt.Rows(j).Item("SumAmount") + AmountUse
                        tempSaleDt.Rows(j).Item("OldAmount") = tempSaleDt.Rows(j).Item("OldAmount") + DGVBind.GetDataRow(i).Item("OldAmt")

                        stAdd = 1
                        Exit For

                    End If
                Next

                If stAdd = 0 Then 'Now row in Dt >> Add New Row
                    tempSaleDt.Rows.Add(DGVBind.GetDataRow(i).Item("idLot"), DGVBind.GetDataRow(i).Item("idInvGroup"), AmountUse,
                                            DGVBind.GetDataRow(i).Item("OldAmt"), DGVBind.GetDataRow(i).Item("idRefLot"))
                End If

            End If

            'Check % DisCount
            If IsDBNull(DGVBind.GetDataRow(i).Item("PercDisc")) Then
                DGVBind.GetDataRow(i).Item("PercDisc") = 0
            End If
            If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
            End If

            'Check Bath DisCount
            If IsDBNull(DGVBind.GetDataRow(i).Item("BathDisc")) Then
                DGVBind.GetDataRow(i).Item("BathDisc") = 0
            End If
            If DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
            End If

        Next  ' Next loop DGVCombine
        '--------------------------------------------------------------
        '--------------------------------------------------------------
        For i As Integer = 0 To tempSaleDt.Rows.Count - 1

                If tempSaleDt.Rows(i).Item("idInvGroup") <> 30 Then 'ไม่ใช่ค่าขนส่ง 
                    Dim sDt As New DataTable
                    sDt.Clear()

                    sCommand.CommandText = "SELECT main.InvName, unit.UnitName, " & vbNewLine &
                                             "(ref.Amount - (SELECT ISNULL(SUM(AmountWaitChange),0) " & vbNewLine &
                                                            "FROM WimWaitCutDt wDt " & vbNewLine &
                                                            "LEFT JOIN WimWaitCutMt wMt ON wDt.idWaitCutMt = wMt.idWaitCutMt" & vbNewLine &
                                                            "WHERE wDt.idLot = lm.idLot" & vbNewLine &
                                                            "AND ref.idWh = wDt.idWh" & vbNewLine &
                                                            "AND wDt.stWait Is NULL" & vbNewLine &
                                                            "AND wMt.stCancel Is NULL" & vbNewLine &
                                                            "AND wDt.stDel Is NULL)) As Amount" & vbNewLine &
                                          "FROM dInvLotRefWh As ref " & vbNewLine &
                                          "LEFT JOIN dInvLotMain As lm ON ref.idLot = lm.idLot " & vbNewLine &
                                          "LEFT JOIN dInventoryMain As main ON lm.idInvMain = main.idInvMain" & vbNewLine &
                                          "LEFT JOIN dInvUnit As unit ON ref.idUnit = unit.idUnit" & vbNewLine &
                                          "WHERE ref.idRefLot = " & tempSaleDt.Rows(i).Item("idRefLot")

                    sAdapter.Fill(sDt)


                    Dim AllStock As Double = sDt.Rows(0).Item("Amount") + tempSaleDt.Rows(i).Item("OldAmount")
                    If AllStock < tempSaleDt.Rows(i).Item("SumAmount") Then  ' Stock < AllSaleAmount

                        MessageBox.Show("จำนวน " & sDt.Rows(0).Item("InvName") & " คงเหลือใน Stock ไม่เพียงพอ ระบบจึงไม่สามารถทำรายการขายได้" & vbCrLf &
                              "(จำนวนขายรวม : " & Format(tempSaleDt.Rows(i).Item("SumAmount"), "#,##0.00##") & " " & sDt.Rows(0).Item("UnitName") &
                              " แต่จำนวน Stock คงเหลือ : " & Format(AllStock, "#,##0.00##") & " " &
                              sDt.Rows(0).Item("UnitName") & ")", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        Exit Sub
                    End If
                End If
            Next

        Select Case Process
            Case eProcess.eNewOrder 'AddData
                '----insert----'
                idSaleS = AddSmSale()

                If idSaleS = 0 Then
                    Exit Sub
                Else
                    'send to line when Company is Siam Advance Host, idComp = 11
                    'fnNoticeLine(idSaleS)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
        End Select
    End Sub

    'Private Sub fnNoticeLine(ByVal gidSale As Integer)

    '    Dim strSmSaleDt As String = ""
    '    If DGVBind.RowCount >= 2 Then
    '        For i As Integer = 0 To 1
    '            ' Dim dr_ As DataRow = gMainReturn.NewRow
    '            strSmSaleDt = strSmSaleDt & "- " & DGVBind.GetRowCellValue(i, "DocCode_PO") & " " & DGVBind.GetRowCellValue(i, "ProductName") & " จำนวน: " & Format(DGVBind.GetRowCellValue(i, "Amount"), "#,##0.####") & " " & DGVBind.GetRowCellValue(i, "UnitName") & " ราคา: ฿" & Format(DGVBind.GetRowCellValue(i, "Price"), "#,##0.####") & " รวม: ฿" & Format(DGVBind.GetRowCellValue(i, "Total"), "#,##0.####") & vbNewLine
    '        Next

    '        If DGVBind.RowCount <> 2 Then
    '            strSmSaleDt = strSmSaleDt & ". . ." & vbNewLine
    '        End If

    '    Else

    '        strSmSaleDt = strSmSaleDt & "- " & DGVBind.GetRowCellValue(0, "DocCode_PO") & " " & DGVBind.GetRowCellValue(0, "ProductName") & " จำนวน: " & Format(DGVBind.GetRowCellValue(0, "Amount"), "#,##0.####") & " " & DGVBind.GetRowCellValue(0, "UnitName") & " ราคา: ฿" & Format(DGVBind.GetRowCellValue(0, "Price"), "#,##0.####") & " รวม: ฿" & Format(DGVBind.GetRowCellValue(0, "Total"), "#,##0.####") & vbNewLine

    '    End If

    '    Dim strStatusApp As String = ""
    '    Dim strApp1 As String = sAprBaseUrl & "/sam/aprBill/accept/" & gidSale
    '    Dim strApp2 As String = sAprBaseUrl & "/sam/aprBill/check/" & gidSale
    '    Dim strApp3 As String = sAprBaseUrl & "/sam/aprBill/approve/" & gidSale
    '    Dim strApp4 As String = sAprBaseUrl & "/sam/aprBill/approve/" & gidSale

    '    strStatusApp = strStatusApp & "ผู้รับทราบ : " & ShrinkURL(strApp1) & vbCrLf &
    '     "ผู้ตรวจสอบ : " & ShrinkURL(strApp2) & vbCrLf &
    '     "ผู้อนุมัติ 1 : " & ShrinkURL(strApp3) & vbCrLf &
    '    "ผู้อนุมัติ 2 : " & ShrinkURL(strApp4)


    '    mdCnOpen()
    '    Dim dt As New DataTable
    '    '---------------- Line Alert (InsertDB-Way) ------------------------'
    '    Dim LineId As Integer = 0 'Test-Line Group (Line ID: 2 ห้องทดสอบแจ้งเตือนไลน์)

    '    sCommand.CommandText = "SELECT parentid " & vbNewLine &
    '                                        "FROM PchInvAndProject.devsk.dGroupCompMap" & vbNewLine &
    '                                        "WHERE stActive = 1" & vbNewLine &
    '                                        "AND idComp = " & cmbGroupComp.SelectedValue

    '    sAdapter.Fill(dt)

    '    If dt.Rows(0).Item("parentid") = 1 Then ' AV Group
    '        LineId = 60
    '    ElseIf dt.Rows(0).Item("parentid") = 2 Then 'GR Group
    '        LineId = 61
    '    ElseIf dt.Rows(0).Item("parentid") = 3 Then 'FL Group
    '        LineId = 62
    '    End If

    '    If cmbGroupComp.SelectedValue = 64 Then
    '        LineId = 131
    '    ElseIf cmbGroupComp.SelectedValue = 5 Then
    '        LineId = 2 ' ห้องทดสอบ
    '    End If

    '    Dim NoteMt As String = ""
    '    Dim count As Integer = dt_Note.Rows.Count

    '    If count = 0 Then
    '        NoteMt = ""
    '    Else
    '        NoteMt = gvNote.GetDataRow(0).Item("Note")

    '        For i As Integer = 1 To gvNote.DataRowCount - 1
    '            NoteMt &= "\" & gvNote.GetDataRow(i).Item("Note")
    '        Next
    '        NoteMt = NoteMt.Replace("'", "''")
    '    End If


    '    Dim MsgLine = "เรียนผู้อนุมัติ (" & cmbGroupComp.Text & ")" & vbCrLf &
    '                              "เลขที่อ้างอิง: " & cmbDRCode.Text & " " & Trim(txtDocRef.Text) & vbCrLf &
    '                              "ชื่อลูกค้า: " & Trim(lblPartnerName.Text) & vbCrLf &
    '                              "หมายเหตุ: " & Trim(NoteMt) & vbCrLf &
    '                              "จำนวนเงินสุทธิ: " & txtTotalNet.Text & " บาท" & vbCrLf &
    '                              Trim(stLbl_PsTs.Text) & vbCrLf &
    '                              "-----------รายการ-----------" & vbCrLf &
    '                              strSmSaleDt & vbCrLf &
    '                              "> สถานะอนุมัติ และลิ้งค์ทำรายการ <" & vbCrLf &
    '                               strStatusApp

    '    'Console.WriteLine(LineId)

    '    'Console.WriteLine(MsgLine)

    '    sCommand.CommandText = "INSERT INTO LineNotify(lineID, Messages, idPsTs) " &
    '                                        "VALUES(" & LineId & ", '" & MsgLine & "', " & sPsId & ")"
    '    sCommand.ExecuteNonQuery()

    '    'MessageBox.Show("แจ้งเตือนไลน์ เรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

    'End Sub

    Private Function ShrinkURL(ByVal strURL As String) As String

        Dim URL As String
        URL = "http://tinyurl.com/api-create.php?url=" & strURL

        Dim objWebRequest As Net.HttpWebRequest
        Dim objWebResponse As Net.HttpWebResponse

        Dim srReader As IO.StreamReader

        Dim strHTML As String

        objWebRequest = CType(Net.WebRequest.Create(URL),
           Net.HttpWebRequest)
        objWebRequest.Method = "GET"

        objWebResponse = CType(objWebRequest.GetResponse(),
           Net.HttpWebResponse)
        srReader = New IO.StreamReader(objWebResponse _
           .GetResponseStream)

        strHTML = srReader.ReadToEnd

        srReader.Close()
        objWebResponse.Close()
        objWebRequest.Abort()

        Return strHTML

    End Function

    Function AddSmSale() As Integer
        Dim idSale As Integer = 0

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
                If Process = eProcess.eEditOrder Then 'EditData
                    vWHERE = " AND idSale <> " & idSaleS & ""
                End If

                Dim stDup As Boolean = fnChkDocCodeDup(mycommand, DocRef, vWHERE)
                Dim stBillType As String = "8"

                If stDup = False Then

                    If stASG <> 0 Then 'ขายบริษัทในเครือ
                        stBillType = "6"

                    End If

                    idSale = fnNewAddSmSaleMt(mycommand, 0, sDocCode, sDocRefAcc, cmbDRCode.SelectedValue, DocRef, NoteMt, lblPsSale.Tag, stBillType,
                                              cmbTp.SelectedValue, CmbTs.SelectedValue, stRight, cmbGroupComp.SelectedValue, idPartner, Trim(lblPartnerName.Text), idCus, idFM,
                                              cmbTypePayTrp.SelectedValue, Me.lblTspComp.Tag, lblAddr.Tag)

                    If idSale = 0 Then
                        Return idSale
                        Exit Function
                    Else

                        If DGVBind.DataRowCount > 0 Then 'มีรายการสินค้า
                            '--- Insert SmSaleDtAll----'
                            For i As Integer = 0 To DGVBind.DataRowCount - 1
                                Dim dr As DataRow = DGVBind.GetDataRow(i)
                                fnNewAddSmSaleDtAll(mycommand, dr, idSale, i + 1)

                                'If Not IsDBNull(dr.Item("idSaleOrderDt")) Then
                                '    mycommand.CommandText = "Update SmSaleOrderDt Set AmountSale = AmountSale + " & dr.Item("AmtSale") & " WHERE idSaleOrderDt = " & dr.Item("idSaleOrderDt")
                                '    mycommand.ExecuteNonQuery()

                                '    Dim dtAmtOrder As New DataTable
                                '    mycommand.CommandText = "SELECT ISNULL(AmountSale,0) As AmountSale, AmountPiece FROM SmSaleOrderDt Where idSaleOrderDt = " & dr.Item("idSaleOrderDt")
                                '    myAdapter.Fill(dtAmtOrder)

                                '    If dtAmtOrder.Rows(0).Item("AmountSale") >= dtAmtOrder.Rows(0).Item("AmountPiece") Then
                                '        mycommand.CommandText = "Update SmSaleOrderDt Set StAllSale = 1 WHERE idSaleOrderDt = " & dr.Item("idSaleOrderDt")
                                '        mycommand.ExecuteNonQuery()
                                '    End If
                                'End If

                                '---Update SmSaleOrderDt Table---'
                                Dim stAllSaleDt As New DataTable
                                stAllSaleDt.Rows.Clear()
                                mycommand.CommandText = "SELECT stAllSale, AmountPiece, IsNull(AmountSale,0) As AmountSale " & vbNewLine &
                                                        "FROM SmSaleOrderDt  " & vbNewLine &
                                                        "WHERE idSaleOrderDt = " & dr.Item("idSaleOrderDt")
                                myAdapter.Fill(stAllSaleDt)

                                If stAllSaleDt.Rows.Count > 0 Then
                                    If IsDBNull(stAllSaleDt.Rows(0).Item("stAllSale")) Then 'มี Order ที่ยังไม่ได้ขาย
                                        Dim NewSale As Integer = stAllSaleDt.Rows(0).Item("AmountSale") + dr.Item("AmtSale")

                                        If stAllSaleDt.Rows(0).Item("AmountPiece") <= NewSale Then 'Order หมดแล้ว หรือ order เกิน
                                            mycommand.CommandText = "Update SmSaleOrderDt Set stAllSale = 1, AmountSale = " & NewSale & vbNewLine &
                                                                   "WHERE idSaleOrderDt = " & dr.Item("idSaleOrderDt")
                                        Else ' ยังมี Order เหลือ
                                            mycommand.CommandText = "Update SmSaleOrderDt Set AmountSale = " & NewSale & vbNewLine &
                                                                   "WHERE idSaleOrderDt = " & dr.Item("idSaleOrderDt")
                                        End If
                                        mycommand.ExecuteNonQuery()
                                    End If
                                End If

                            Next



                            '---- Update SumService in SmSaleMt ----'
                            mycommand.CommandText = "Update SmSaleMt Set SumService = " & SumSvFree & " WHERE idSale = " & idSale
                            mycommand.ExecuteNonQuery()

                            mycommand.CommandText = "EXEC WaitCutTs '4','SmSaleMt','SmSaleDtAll','idSale'," & idSale & "," & cmbGroupComp.SelectedValue & "," & sPsId & ",'1'"
                            mycommand.ExecuteNonQuery()

                        End If
                    End If
                End If

                'up image
                For j As Integer = 0 To sDt_flagpic_Rec.Rows.Count - 1
                    If sDt_flagpic_Rec.Rows(j).Item(2) = "1" Then
                        upFile(j + 1, sDt_flagpic_Rec.Rows(j).Item(0), idSale)
                    End If
                Next


                ' Attempt to commit the transaction.
                mytransaction.Commit()
                'SplashScreenManager.CloseForm(False)
                mdLoadCommitt()
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return idSale

            Catch ex As Exception
                ' Attempt to roll back the transaction.
                Try
                    mytransaction.Rollback()
                    'SplashScreenManager.CloseForm(False)
                    mdLoadCommitt()
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                             sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    idSale = 0
                    Return idSale
                Catch e2x As Exception
                    idSale = 0
                    'SplashScreenManager.CloseForm(False)
                    mdLoadCommitt()
                    'MessageBox.Show(ex.Message, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                             sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Return idSale
                End Try

            End Try


        End Using

        Return 0
    End Function

    Function fnNewAddSmSaleMt(ByVal mycommand As SqlCommand, ByVal idSale As Integer, ByVal sDocCode As String, ByVal sDocRefAcc As String, ByVal idSaleCode As Integer, ByVal sDocRef As String,
                              ByVal NoteMt As String, ByVal sidPsSale As Integer, ByVal BillType As Integer, ByVal Payment As Integer, ByVal Transport As Integer,
                              ByVal stRight As Integer, ByVal idComp As Integer, ByVal sidPartner As Integer, ByVal PartnerNameBill As String, ByVal sidCus As Integer, ByVal sidFM As Integer,
                              ByVal idPayTs As Integer, ByVal idSupTsp As Integer, ByVal idCusRefAddr As Integer) As Integer


        If Process = eProcess.eEditOrder Then  'Update

            mycommand.CommandText = "UPDATE SmSaleMt SET DateSale = @DateSale, DateSaleD = @DateSaleD, DatePay = @DatePay, DateTs = @DateTs, DateTsD = @DateTsD, " &
                              "TimeTs = @TimeTs, DocCode = @DocCode, DocRefAcc = @DocRefAcc, idSaleCode =  @idSaleCode, DocRef = @DocRef, Note = @Note, " &
                              "TotalNet = @TotalNet, Total = @Total, idPsTs = @idPsTs, idPsSale = @idPsSale, stBillType = @stBillType, stPay = @stPay, idPM =  @idPM, " &
                              "idTS = @idTS, stRight = @stRight, idComp = @idComp, idPayTsp = @idPayTsp, idSupTsp = @idSupTsp, " &
                              "idCusRefAddr = @idCusRefAddr, stLot = @stLot, idPartner = @idPartner, PartnerNameBill = @PartnerNameBill, idCus = @idCus, idFM = @idFM, " &
                              "DiscountAmout = @DiscountAmout, DiscountPerc = @DiscountPerc, DiscountBath = @DiscountBath) " &
                              "WHERE idSale = @idSale"

            mycommand.Parameters.Add("@idSale", SqlDbType.Int).Value = idSale

        ElseIf Process = eProcess.eNewOrder Then 'Insert

            mycommand.CommandText = "INSERT Into SmSaleMt(DateSale, DateSaleD, DatePay, DateTs, DateTsD, TimeTs, DocCode, DocRefAcc, idSaleCode, DocRef, Note, " &
                              "TotalNet, Total, idPsTs, idPsSale, stBillType, stPay, idPM, idTS, stRight, idComp, idPayTsp, idSupTsp, " &
                              "idCusRefAddr, stLot, idPartner, PartnerNameBill, idCus, idFM, DiscountAmout, DiscountPerc, DiscountBath, DateSaleSys ) " &
                              "Values(@DateSale, @DateSaleD, @DatePay, @DateTs, @DateTsD, @TimeTs, @DocCode, @DocRefAcc, @idSaleCode, @DocRef, @Note, @TotalNet, @Total," &
                              "@idPsTs, @idPsSale, @stBillType, @stPay, @idPM, @idTS, @stRight, @idComp, @idPayTsp, @idSupTsp, @idCusRefAddr, @stLot, @idPartner, @PartnerNameBill," &
                              "@idCus, @idFM, @DiscountAmout, @DiscountPerc, @DiscountBath, @DateSaleSys)"

        End If

        With mycommand.Parameters
            .Add("@DateSale", SqlDbType.VarChar).Value = ksbDateToString(dtpSale.Value.ToShortDateString) 'ตามหน้า
            .Add("@DateSaleD", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpSale.Value, _cultureEnInfo) 'ตามหน้า
            .Add("@DatePay", SqlDbType.VarChar).Value = ksbDateToString(dtpPay.Value.ToShortDateString) 'ตามหน้า
            .Add("@DateTs", SqlDbType.VarChar).Value = ksbDateToString(Date.Today) 'ตามหน้า
            .Add("@DateTsD", SqlDbType.DateTime).Value = DateTime.Now 'ตามหน้า
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

    Private Function fnNewAddSmSaleDtAll(ByVal vCommand As SqlCommand, ByVal dr As DataRow, ByVal idSale As Integer, ByVal No As Integer) As Integer
        SumSvFree = 0
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
            strParameter = " idSaleOrderDt, CodeOrder,"
            strValue = "" & dr.Item("idSaleOrderDt") & ",'" & dr.Item("CodeOrder") & "',"

            '---Update stBillOrder : SmSaleMt----'
            vCommand.CommandText = "Update SmSaleMt Set stBillOrder = 1 WHERE idSale = '" & idSale & "'"
            vCommand.ExecuteNonQuery()
        End If

        '--------------DtType = 1 : สินค้าทั่วไป-------------
        If dr.Item("idInvGroup") = 2 Then


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

            '------------------------------------------SPM PART------------------------------------
            'If dr.Item("idLotSPM") <> 0 Then
            '    'check stock 
            '    If CDbl(dr.Item("AmtStock")) = CalAmt Then 'ขายทั้งหมด
            '        vCommand.CommandText = "Update SsLotMt SET idSale = " & idSale & ", SaleSAM = 1 WHERE idLot = " & dr.Item("idLotSPM") & ""
            '        vCommand.ExecuteNonQuery()
            '    Else 'ขายบางส่วน
            '        vCommand.CommandText = "Update SsLotMt SET WUpdate = WUpdate - " & CalAmt &
            '                                ", SaleCut = SaleCut + " & CalAmt & vbNewLine &
            '                                "WHERE idLot = " & dr.Item("idLotSPM") & ""
            '        vCommand.ExecuteNonQuery()
            '    End If
            'End If
            '--------------------------------------------------------------------------------------

        ElseIf dr.Item("idInvGroup") = 30 Then
            ' รวมยอดค่าบริการ (ค่าขนส่ง)
            SumSvFree = SumSvFree + CDbl(dr.Item("Total"))

        End If


        Dim ProductName As String = Trim(dr.Item("ProductName"))
        ProductName = Replace(ProductName, "'", "''")

        vCommand.CommandText = "INSERT Into SmSaleDtAll(idSale, " & strParameter & " idProduct, ProductName, idLot, LotNo, Amount, idUnit," & vbNewLine &
                                "PriceBfDis, DiscountPerc, DiscountBath, Price, stCutStock, No, DtType, idWh, idPOTs, idPODt, pWeight, idUnitW, TotalDt)" & vbNewLine &
                                "VALUES(@idSale, " & strValue & "  @idProduct, @ProductName, @idLot, @LotNo, @Amount, @idUnit," & vbNewLine &
                                "@PriceBfDis, @DiscountPerc, @DiscountBath, @Price, @stCutStock, @No, @DtType, @idWh, @idPOTs, @idPODt, @pWeight, @idUnitW, @TotalDt)"


        With vCommand.Parameters
            .Add("@idSale", SqlDbType.Int).Value = idSale
            .Add("@idProduct", SqlDbType.Int).Value = dr.Item("idInvMain")
            .Add("@ProductName", SqlDbType.VarChar).Value = Trim(ProductName)
            .Add("@idLot", SqlDbType.Int).Value = dr.Item("idLot")
            .Add("@LotNo", SqlDbType.VarChar).Value = LotNo
            .Add("@Amount", SqlDbType.Float).Value = CDbl(dr.Item("AmtSale"))
            .Add("@idUnit", SqlDbType.Int).Value = dr.Item("idUnit")
            .Add("@PriceBfDis", SqlDbType.Float).Value = CDbl(dr.Item("PriceNormal"))
            .Add("@DiscountPerc", SqlDbType.Float).Value = CDbl(dr.Item("PercDisc"))
            .Add("@DiscountBath", SqlDbType.Float).Value = CDbl(dr.Item("BathDisc"))
            .Add("@Price", SqlDbType.Float).Value = CDbl(dr.Item("PriceSale"))
            .Add("@stCutStock", SqlDbType.Int).Value = 0 ' Send to cut On WimWaitCut
            .Add("@No", SqlDbType.Int).Value = No
            .Add("@DtType", SqlDbType.Int).Value = dr.Item("DtType")
            .Add("@idWh", SqlDbType.Int).Value = dr.Item("idWh")
            .Add("@idPOTs", SqlDbType.Int).Value = dr.Item("idPOTs")
            .Add("@idPODt", SqlDbType.Int).Value = dr.Item("idPODt")
            .Add("@pWeight", SqlDbType.Float).Value = If(dr.Item("pWeight") = 0, DBNull.Value, dr.Item("pWeight"))
            .Add("@idUnitW", SqlDbType.Int).Value = If(dr.Item("idUnitW") = 0, DBNull.Value, dr.Item("idUnitW"))
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
    Private Sub upFile(ByVal namefile As String, ByVal locationname As String, ByVal idSale As String)
        My.Computer.Network.UploadFile(locationname, "ftp://" & sHost & "/SAM/SaleTs/" + idSale + "_" + namefile + ".jpg", sFtpUser, sFtpPass)
    End Sub

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

        Dim PrefixCode As String = ""
        Dim DocRefAcc As String = ""
        Dim nextOrder As String = ""
        ' Dim CodeYear As String = ""
        Dim st3Position As Integer = 0
        Dim myAdapter As New SqlDataAdapter(myCommand)

        If idComp = 4 Then  ' AVS
            If Process = eProcess.eNewOrder Or
                    stBType = 0 Or stBType = 2 Then 'ขายสินค้าทั่วไป/ขายดอกไม้ (ในประเทศ)/ขายสินค้ารวมทุกประเภท
                If Me.rdbNoRight.Checked = True Then 'ไม่ถูกหลัก
                    If Me.lblPsSale.Tag = 9 Then
                        PrefixCode = "CC"
                    Else
                        PrefixCode = "IV"
                    End If
                ElseIf Me.rdbRight.Checked = True Then 'ถูกหลัก    
                    PrefixCode = "AV"
                End If
            End If
        ElseIf idComp = 10 Then  ' STAR
            If Process = eProcess.eEditOrder Or
                stBType = 0 Or stBType = 2 Then 'ขายสินค้าทั่วไป/ขายดอกไม้ (ในประเทศ)/ขายสินค้ารวมทุกประเภท
                If Me.rdbNoRight.Checked = True Then 'ไม่ถูกหลัก
                    PrefixCode = "SC"
                ElseIf Me.rdbRight.Checked = True Then 'ถูกหลัก    
                    PrefixCode = "IV"
                End If
            End If
        ElseIf idComp = 12 Then 'VC : เอวีอะโกร
            PrefixCode = "IVC"
            st3Position = 1
            'If stPage = 12 Then 'เมนูสินค้าตัวอย่าง
            '    PrefixCode = "110"
            '    st3Position = 1
            'Else
            '    '----Update เพิ่มเมื่อเก็บข้่อมูลเกี่ยวกับพลาสติก+ถาดเพาะ+ฮอร์โมน+อาหารเสริม-----'
            'End If
        ElseIf idComp = 55 Then 'V1 : AVC (ขายพลาสติก)
            PrefixCode = "IV"
        Else  ' บริษัทอื่นๆ
            PrefixCode = "IV"
        End If 'End Check idComp

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

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim eText As String = ""

        If Me.lblPsSale.Text = "" Then
            eText = frmCustomerSelect.eProcess.eSelectAllChkSt
        Else 'ผูกกับ Sale
            eText = frmCustomerSelect.eProcess.ePsSale
        End If

        Dim vFrm As New frmCustomerSelect(eText, cmbGroupComp.SelectedValue)

        If Me.lblPsSale.Text <> "" Then
            vFrm.idPs = Me.lblPsSale.Tag
        End If

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            If vFrm.Note = "" Then
                lblCusNote.Text = " -"
            Else
                lblCusNote.Text = vFrm.Note
            End If

            stASG = vFrm.sstASG

            idFM = vFrm.idFm
            idPartner = vFrm.idPartner

            Me.lblPartnerName.Tag = vFrm.idPartner
            idCus = vFrm.idCus
            Me.lblPartnerName.Text = vFrm.CusName


            If vFrm.idCus <> 0 Then
                Me.lblAddr.Text = vFrm.AddressS
                Me.lblAddr.Tag = vFrm.idRefAdrS
                Me.lblCusRec.Text = vFrm.vPsRecName
            Else
                btnAddressS.Visible = False
                Me.lblAddr.Text = vFrm.Address
                Me.lblCusRec.Text = lblPartnerName.Text
            End If



            Me.CmbTs.SelectedValue = vFrm.idTsp
            Me.cmbTypePayTrp.SelectedValue = vFrm.idPayTsp

            If vFrm.idTsp = 0 Then
                Dim dtidTsp As New DataTable
                sCommand.CommandText = "Select idTsp, idPayTsp, idSupTsp " & vbNewLine &
                                       "FROM dCustomer  " & vbNewLine &
                                       "WHERE idCus = " & vFrm.idCus & ""
                sAdapter.Fill(dtidTsp)

                If vFrm.idCus <> 0 Then
                    Me.CmbTs.SelectedValue = dtidTsp.Rows(0).Item("idTsp")
                Else
                    'Farmer default 16 (พนักงานบริษัท)
                    Me.CmbTs.SelectedValue = 16
                End If

            End If

            Me.btnAddressS.Enabled = True

            '--- Set TransportComp ----'
            mdCnOpen()
            Dim TspDt As New DataTable
            TspDt.Rows.Clear()
            'sCommand.CommandText = "Select idSupTsp, SupName FROM vCusAdrSetTransport WHERE " & _
            '                       "idCusRefAddr = " & vFrm.idRefAdrS & " AND idComp = " & sIdComp
            sCommand.CommandText = "Select idCusRefAddr, idSupTsp, SupName " & vbNewLine &
                                   "FROM vCusAdrSetTransport  " & vbNewLine &
                                   "WHERE idCus = " & vFrm.idCus & " AND idComp = " & cmbGroupComp.SelectedValue
            sAdapter.Fill(TspDt)

            If TspDt.Rows.Count = 0 Then
                Me.lblTspComp.Tag = vFrm.idSupTsp
                Me.lblTspComp.Text = vFrm.SupName

            ElseIf TspDt.Rows.Count = 1 Then
                Me.lblTspComp.Tag = TspDt.Rows(0).Item("idSupTsp")
                Me.lblTspComp.Text = TspDt.Rows(0).Item("SupName")

            Else 'มีหลายรายการ
                For i As Integer = 0 To TspDt.Rows.Count - 1
                    If vFrm.idRefAdrS = TspDt.Rows(i).Item("idCusRefAddr") Then
                        Me.lblTspComp.Tag = TspDt.Rows(i).Item("idSupTsp")
                        Me.lblTspComp.Text = TspDt.Rows(i).Item("SupName")
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub btnTspComp_Click(sender As Object, e As EventArgs) Handles btnTspComp.Click
        Dim vFrm As New frmTspCompSelect(frmTspCompSelect.eProcess.eAll)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblTspComp.Tag = vFrm.idSup
            Me.lblTspComp.Text = vFrm.SupName
        End If
    End Sub

    Private Sub btnSale_Click(sender As Object, e As EventArgs) Handles btnSale.Click
        If Me.lblPartnerName.Text = "" Then
            Dim vFrm As New frmPsSaleSelect(frmPsSaleSelect.eProcess.eNormal, Nothing, Me.lblPartnerName.Text, idCus, 1, cmbGroupComp.SelectedValue)
            'vFrm.GetidComp(gidComp)
            ' vFrm.ShowText(PsCustomer, idPsCus, 1) 'No Customer
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

                lblPsSale.Tag = vFrm.idPs
                lblPsSale.Text = vFrm.SaleName
            End If
        Else
            Dim vFrm As New frmPsSaleSelect(frmPsSaleSelect.eProcess.eNormal, Nothing, Me.lblPartnerName.Text, idCus, 0, cmbGroupComp.SelectedValue)
            'vFrm.GetidComp(gidComp)
            '  vFrm.ShowText(Me.lblPsCus.Text, Me.lblPsCus.Tag, 0) 'have Customer
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

                'PsSaleName = vFrm.SaleName
                lblPsSale.Tag = vFrm.idPs
                lblPsSale.Text = vFrm.SaleName
            End If
        End If
    End Sub

    Private Sub CmbTs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTs.SelectedIndexChanged
        If Me.CmbTs.SelectedValue = 21 Then ' บริษัทขนส่ง
            Me.btnTspComp.Enabled = True
            Me.cmbTypePayTrp.Enabled = True
        Else
            Me.btnTspComp.Enabled = False
            Me.cmbTypePayTrp.Enabled = False
            Me.lblTspComp.Tag = Nothing
            Me.lblTspComp.Text = ""
            Me.cmbTypePayTrp.SelectedValue = 1
        End If
    End Sub

    Private Sub cmbTp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTp.SelectedIndexChanged
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

                If dt.Rows(0).Item("PayPerc") <> 0 Then
                    Me.txtPercP.Text = dt.Rows(0).Item("PayPerc")
                    Dim PrePay As Double = (CDbl(txtTotalNet.Text) * dt.Rows(0).Item("PayPerc")) / 100
                    Me.txtPrePay.Text = Format(PrePay, "#,##0.00")
                Else
                    Me.txtPercP.Text = 0
                    Me.txtPrePay.Text = 0
                End If

                If Me.cmbTp.SelectedValue = 49 Then 'credit 30
                    For i As Integer = 0 To DGVBind.DataRowCount - 1
                        If DGVBind.GetDataRow(i).Item("idInvGroup") = 29 Then 'สินค้าอื่นๆ (ไม่ใช่เมล็ด)
                            Dim PriceTempDt As New DataTable
                            PriceTempDt.Clear()
                            mdCnOpen()
                            'sCommand.CommandText = "SELECT CreditThirty FROM SmPdOtherD WHERE idPdO = " & DGVBind.GetDataRow(i).Item("idSubType") & ""
                            sCommand.CommandText = "SELECT CreditThirty" & vbNewLine &
                                                    "FROM SmPdOtherD d" & vbNewLine &
                                                    "LEFT JOIN dInventoryMain main ON d.idPdO = main.idSubType " & vbNewLine &
                                                    "LEFT JOIN dInvGroup g ON main.idInvGroup = g.idInvGroup" & vbNewLine &
                                                    "WHERE idPdO = " & DGVBind.GetDataRow(i).Item("idSubType") & vbNewLine &
                                                    "AND g.stPdOther = 1"

                            sAdapter.Fill(PriceTempDt)

                            If PriceTempDt.Rows.Count > 0 Then
                                If Not IsDBNull(PriceTempDt.Rows(0).Item("CreditThirty")) Then
                                    DGVBind.GetDataRow(i).Item("PriceNormal") = PriceTempDt.Rows(0).Item("CreditThirty")

                                    If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                                        DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
                                    ElseIf DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                                        DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
                                    Else
                                        DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal")
                                    End If

                                    DGVBind.GetDataRow(i).Item("Total") = DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("AmtSale")
                                End If
                            End If
                        End If

                    Next

                    SumTotalNew()
                ElseIf Me.cmbTp.SelectedValue = 50 Then 'credit 60

                    For i As Integer = 0 To DGVBind.DataRowCount - 1
                        If DGVBind.GetDataRow(i).Item("idInvGroup") = 29 Then 'สินค้าอื่นๆ (ไม่ใช่เมล็ด)
                            Dim PriceTempDt As New DataTable
                            PriceTempDt.Clear()
                            mdCnOpen()
                            'sCommand.CommandText = "SELECT CreditSixty FROM SmPdOtherD WHERE idPdO = " & DGVBind.GetDataRow(i).Item("idSubType") & ""
                            sCommand.CommandText = "SELECT CreditSixty" & vbNewLine &
                                                  "FROM SmPdOtherD d" & vbNewLine &
                                                  "LEFT JOIN dInventoryMain main ON d.idPdO = main.idSubType " & vbNewLine &
                                                  "LEFT JOIN dInvGroup g ON main.idInvGroup = g.idInvGroup" & vbNewLine &
                                                  "WHERE idPdO = " & DGVBind.GetDataRow(i).Item("idSubType") & vbNewLine &
                                                  "AND g.stPdOther = 1"
                            sAdapter.Fill(PriceTempDt)

                            If PriceTempDt.Rows.Count > 0 Then
                                If Not IsDBNull(PriceTempDt.Rows(0).Item("CreditSixty")) Then
                                    DGVBind.GetDataRow(i).Item("PriceNormal") = PriceTempDt.Rows(0).Item("CreditSixty")

                                    If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                                        DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
                                    ElseIf DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                                        DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
                                    Else
                                        DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal")
                                    End If

                                    DGVBind.GetDataRow(i).Item("Total") = DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("AmtSale")
                                End If
                            End If
                        End If
                    Next
                    SumTotalNew()
                Else

                    For i As Integer = 0 To DGVBind.DataRowCount - 1
                        If DGVBind.GetDataRow(i).Item("idInvGroup") = 29 Then 'สินค้าอื่นๆ (ไม่ใช่เมล็ด)
                            Dim PriceTempDt As New DataTable
                            PriceTempDt.Clear()
                            mdCnOpen()
                            'sCommand.CommandText = "SELECT Price FROM SmPdOtherD WHERE idPdO = " & DGVBind.GetDataRow(i).Item("idSubType") & ""
                            sCommand.CommandText = "SELECT Price" & vbNewLine &
                                           "FROM SmPdOtherD d" & vbNewLine &
                                           "LEFT JOIN dInventoryMain main ON d.idPdO = main.idSubType " & vbNewLine &
                                           "LEFT JOIN dInvGroup g ON main.idInvGroup = g.idInvGroup" & vbNewLine &
                                           "WHERE idPdO = " & DGVBind.GetDataRow(i).Item("idSubType") & vbNewLine &
                                           "AND g.stPdOther = 1"

                            sAdapter.Fill(PriceTempDt)

                            If PriceTempDt.Rows.Count > 0 Then
                                DGVBind.GetDataRow(i).Item("PriceNormal") = PriceTempDt.Rows(0).Item("Price")

                                If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                                    DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
                                ElseIf DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                                    DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
                                Else
                                    'f DGVBind.GetDataRow(i).Item("BathDisc") = 0 Then
                                    DGVBind.GetDataRow(i).Item("PriceNormal") = DGVBind.GetDataRow(i).Item("PriceNormal")
                                End If

                                DGVBind.GetDataRow(i).Item("Total") = DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("AmtSale")
                            End If
                        End If

                    Next
                    SumTotalNew()
                End If

            End If 'End check stPage
        End If
    End Sub

    Private Sub rdbWhole_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbWhole.CheckedChanged
        If Me.rdbWhole.Checked = True Then
            For i As Integer = 0 To DGVBind.DataRowCount - 1
                If DGVBind.GetDataRow(i).Item("idInvGroup") = 2 Then 'สินค้าสำเร็จรูป FG
                    mdCnOpen()
                    Dim dt As New DataTable
                    sDs.Tables.Clear()
                    sCommand.CommandText = "Select PriceWholesale From dPackingPdSet Where idPdPk = " & DGVBind.GetDataRow(i).Item("idSubType")
                    sAdapter.Fill(dt)

                    If dt.Rows.Count <> 0 Then

                        DGVBind.GetDataRow(i).Item("PriceNormal") = dt.Rows(0).Item("PriceWholesale")

                        DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal")
                        '----- Check ส่วนลด  ------'
                        If Not IsDBNull(DGVBind.GetDataRow(i).Item("PercDisc")) Then
                            If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                                DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
                            End If
                        End If
                        '----- Check ส่วนลด (Bath)  ------'
                        If Not IsDBNull(DGVBind.GetDataRow(i).Item("BathDisc")) Then
                            If DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                                DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
                            End If
                        End If

                        DGVBind.GetDataRow(i).Item("Total") = DGVBind.GetDataRow(i).Item("PriceSale") * DGVBind.GetDataRow(i).Item("AmtSale")

                    End If
                End If
            Next

            SumTotalNew()
        End If
    End Sub

    Private Sub rdbRetail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbRetail.CheckedChanged
        If Me.rdbRetail.Checked = True Then
            For i As Integer = 0 To DGVBind.DataRowCount - 1
                If DGVBind.GetDataRow(i).Item("idInvGroup") = 2 Then 'สินค้าทั่วไป
                    mdCnOpen()
                    Dim dt As New DataTable
                    dt.Clear()
                    sCommand.CommandText = "Select PriceRetail From dPackingPdSet Where idPdPk = " & DGVBind.GetDataRow(i).Item("idSubType")
                    sAdapter.Fill(dt)

                    If dt.Rows.Count <> 0 Then


                        DGVBind.GetDataRow(i).Item("PriceNormal") = dt.Rows(0).Item("PriceRetail")
                        DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal")

                        '----- Check ส่วนลด  ------'
                        If Not IsDBNull(DGVBind.GetDataRow(i).Item("PercDisc")) Then
                            If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                                DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
                            End If
                        End If
                        '----- Check ส่วนลด (Bath)  ------'
                        If Not IsDBNull(DGVBind.GetDataRow(i).Item("BathDisc")) Then
                            If DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                                DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
                            End If
                        End If
                        DGVBind.GetDataRow(i).Item("Total") = DGVBind.GetDataRow(i).Item("PriceSale") * DGVBind.GetDataRow(i).Item("AmtSale")

                    End If
                End If
            Next
            SumTotalNew()
        End If
    End Sub

    Private Sub rdbBill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbBill.CheckedChanged
        If DGVBind.DataRowCount > 1 Then
            If Me.rdbBill.Checked = True Then
                For i As Integer = 0 To DGVBind.DataRowCount - 1
                    If DGVBind.GetDataRow(i).Item("idInvGroup") = 2 Then 'สินค้าทั่วไป
                        mdCnOpen()
                        Dim dt As New DataTable
                        sDs.Tables.Clear()
                        sCommand.CommandText = "Select PriceBill From dPackingPdSet Where idPdPk = " & DGVBind.GetDataRow(i).Item("idSubType")
                        sAdapter.Fill(dt)

                        If dt.Rows.Count <> 0 Then

                            DGVBind.GetDataRow(i).Item("PriceNormal") = dt.Rows(0).Item("PriceBill")
                            DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal")

                            '----- Check ส่วนลด  ------'
                            If Not IsDBNull(DGVBind.GetDataRow(i).Item("PercDisc")) Then
                                If DGVBind.GetDataRow(i).Item("PercDisc") > 0 Then
                                    DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - (DGVBind.GetDataRow(i).Item("PriceNormal") * DGVBind.GetDataRow(i).Item("PercDisc")) / 100
                                End If
                            End If
                            '----- Check ส่วนลด (Bath)  ------'
                            If Not IsDBNull(DGVBind.GetDataRow(i).Item("BathDisc")) Then
                                If DGVBind.GetDataRow(i).Item("BathDisc") > 0 Then
                                    DGVBind.GetDataRow(i).Item("PriceSale") = DGVBind.GetDataRow(i).Item("PriceNormal") - DGVBind.GetDataRow(i).Item("BathDisc")
                                End If
                            End If
                            DGVBind.GetDataRow(i).Item("Total") = DGVBind.GetDataRow(i).Item("PriceSale") * DGVBind.GetDataRow(i).Item("AmtSale")
                        End If
                    End If
                Next
                SumTotalNew()

            End If
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim strIDSel As String = "0"

        If DGVBind.DataRowCount > 0 Then
            strIDSel = DGVBind.GetRowCellValue(0, Col_idSaleOrderDt)
            For i As Integer = 1 To DGVBind.DataRowCount - 1
                strIDSel = strIDSel & "," & DGVBind.GetRowCellValue(i, Col_idSaleOrderDt)
            Next
        End If


        Dim vFrm As New frmSlOrderToSale(frmSlOrderToSale.eProcess.eBackOrder, lblPartnerName.Text, lblPartnerName.Tag, cmbGroupComp.SelectedValue, strIDSel)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            For i As Integer = 0 To vFrm.gMainReturn.Rows.Count - 1

                Dim dr As DataRow = vFrm.gMainReturn.Rows(i)
                DGVBind.AddNewRow()
                Dim dtLotFIFO As DataTable = fnSetDefualtLotFIFO(dr.Item("idInvMain"))
                With DGVBind
                    .SetFocusedRowCellValue(colNo, dr.Item("i"))
                    .SetFocusedRowCellValue(ColCodeOrder, dr.Item("DocCode"))
                    .SetFocusedRowCellValue(Col_idSaleOrderDt, dr.Item("idSaleOrderDt"))
                    .SetFocusedRowCellValue(ColPriceNormal, dr.Item("dNET"))
                    .SetFocusedRowCellValue(ColInvCode, dr.Item("InvCode"))
                    .SetFocusedRowCellValue(colidInvGroup, dr.Item("idInvGroup"))
                    .SetFocusedRowCellValue(colidInvMain, dr.Item("idInvMain"))
                    .SetFocusedRowCellValue(ColProductName, dr.Item("InvName"))
                    .SetFocusedRowCellValue(colAmtOrder, dr.Item("AmtOrder")) ' AmtOrder
                    .SetFocusedRowCellValue(ColUnitPO, dr.Item("UnitNameOrd"))
                    .SetFocusedRowCellValue(ColDtType, dr.Item("DtType"))
                    .SetFocusedRowCellValue(ColExp, 0)
                    .SetFocusedRowCellValue(Col_OldAmt, 0)
                    .SetFocusedRowCellValue(ColLot, If(dtLotFIFO.Rows.Count = 0, "", dtLotFIFO.Rows(0).Item("LotNo")))
                    .SetFocusedRowCellValue(Col_idLot, If(dtLotFIFO.Rows.Count = 0, 0, dtLotFIFO.Rows(0).Item("idLot")))
                    .SetFocusedRowCellValue(ColAmtStock, If(dtLotFIFO.Rows.Count = 0, 0, dtLotFIFO.Rows(0).Item("AmtStock")))

                    .SetFocusedRowCellValue(ColPriceNormal, dr.Item("dNET"))
                    .SetFocusedRowCellValue(ColPriceSale, dr.Item("dNET"))
                    .SetFocusedRowCellValue(colidRefLot, If(dtLotFIFO.Rows.Count = 0, 0, dtLotFIFO.Rows(0).Item("idRefLot")))
                    .SetFocusedRowCellValue(colidWh, If(dtLotFIFO.Rows.Count = 0, "", dtLotFIFO.Rows(0).Item("idWh")))
                    .SetFocusedRowCellValue(ColidUnit, dr.Item("idUnit"))
                    .SetFocusedRowCellValue(colUnitName, dr.Item("UnitName"))
                    .SetFocusedRowCellValue(colidLotSPM, If(dtLotFIFO.Rows.Count = 0, "", dtLotFIFO.Rows(0).Item("idLotSPM")))

                    .SetFocusedRowCellValue(ColAmtSale, If(DGVBind.GetFocusedRowCellValue("AmtOrder") >= DGVBind.GetFocusedRowCellValue("AmtStock"), DGVBind.GetFocusedRowCellValue("AmtStock"), DGVBind.GetFocusedRowCellValue("AmtOrder"))) 'Set Default Amount Sale

                    .SetFocusedRowCellValue(ColPercDiscount, 0)
                    .SetFocusedRowCellValue(ColBathDiscount, 0)
                    .SetFocusedRowCellValue(ColExp, DGVBind.GetFocusedRowCellValue("AmtSale") * DGVBind.GetFocusedRowCellValue("PriceSale"))
                    .SetFocusedRowCellValue(ColidPOTs, dr.Item("idPOTs"))
                    .SetFocusedRowCellValue(ColidPODt, dr.Item("idPODt"))
                    .SetFocusedRowCellValue(ColNotePO, dr.Item("NoteOrder"))
                    .SetFocusedRowCellValue(ColDocCodePO, dr.Item("DocCode_PO"))
                    .SetFocusedRowCellValue(ColpWeight, dr.Item("pWeight"))
                    .SetFocusedRowCellValue(ColidUnitW, dr.Item("idUnitW"))
                End With

                DGVBind.UpdateCurrentRow()
                DGVBind.RefreshData()
            Next



            SumTotalNew()
        End If

    End Sub

End Class