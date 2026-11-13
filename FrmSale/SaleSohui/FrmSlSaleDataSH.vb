Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmSlSaleDataSH
    Dim stload As Integer = 0
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim xProcess As eProcess
    Enum eProcess
        eView
        eEdit
        eCancel
    End Enum

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eEdit
                Me.Text = "แก้ไขรายการขายสินค้าโสหุ้ย"
                ColDoc.Visible = False
                ColCancel.Visible = False
                ColView.Visible = False
            Case eProcess.eView
                Me.Text = "ข้อมูลรายการขายสินค้าโสหุ้ย"
                ColEdit.Visible = False
                ColCancel.Visible = False
            Case eProcess.eCancel
                Me.Text = "ยกเลิกรายการขายสินค้าโสหุ้ย"
                ColEdit.Visible = False
                ColDoc.Visible = False
                ColView.Visible = False
        End Select

        xProcess = aProcess

    End Sub

    Private Sub FrmSlSaleDataSH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdCnOpen()
        mdLoadShow()
        setCmbGroupComp(Me.cmbGroupComp)
        BindData()
        SumTotal()
        mdLoadCommitt()

        stload = 1
    End Sub

    Sub SumTotal()
        Dim TotalNet As Double = 0.0
        For i As Integer = 0 To GVSaleMt.DataRowCount - 1
            If IsDBNull(GVSaleMt.GetRowCellValue(i, "idPsCancel")) = True Then
                TotalNet += GVSaleMt.GetRowCellValue(i, "TotalNet")
            End If
        Next

        txtTotalNet.Text = Format(TotalNet, "#,##0.00##")
    End Sub

    Private Sub GVSaleMt_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVSaleMt.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Function GetChildRowCount(ByRef View As GridView) As Integer
        Dim RowCount As Integer
        View.BeginUpdate()
        Try
            Dim dataRowCount As Integer = View.DataRowCount
            Dim rHandle As Integer
            For rHandle = 0 To dataRowCount - 1
                View.SetMasterRowExpanded(rHandle, True)
                Dim childView As ColumnView = View.GetDetailView(rHandle, 0)
                If Not IsNothing(childView) Then
                    RowCount = RowCount + childView.RowCount
                End If
            Next
        Catch ex As Exception
            'XtraMessageBox.Show(ex.Message, "DampoDesk", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            View.EndUpdate()
        End Try
        Return RowCount
    End Function

    Private Sub BindData()
        Dim vWhere As String = " WHERE idJobMt Is NOT NULL "

        Dim vField As String = ""
        If Me.rdbDateSale.Checked = True Then
            vField = "s.DateSaleD"
        ElseIf Me.rdbDateTs.Checked = True Then
            vField = "s.DateTsD"
        End If

        If Me.rdbDate.Checked = True Then
            Dim firstDate As DateTime = Convert.ToDateTime(dtpSaleS.Value, _cultureEnInfo)
            Dim lastDate As DateTime = Convert.ToDateTime(dtpSaleE.Value, _cultureEnInfo)
            vWhere = vWhere & " AND " & vField & " Between '" & firstDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " &
                              "And '" & lastDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' "

        ElseIf Me.rdbMonth.Checked = True Then

            Dim sDateS As DateTime = Convert.ToDateTime(dtpMonthS.Value, _cultureEnInfo)
            Dim sMonthS As Integer = sDateS.Month
            Dim sYearS As Integer = sDateS.Year
            Dim sDateE As DateTime = Convert.ToDateTime(dtpMonthE.Value, _cultureEnInfo)
            Dim sMonthE As Integer = sDateE.Month
            Dim sYearE As Integer = sDateE.Year

            vWhere = vWhere & " AND year(" & vField & ") * 100 + month(" & vField & ") " &
                              "BETWEEN " & sYearS & " * 100 + " & sMonthS & " AND " & sYearE & " * 100 + " & sMonthE & ""

        ElseIf Me.rdbYear.Checked = True Then

            Dim sDateY As DateTime = Convert.ToDateTime(dtpYear.Value, _cultureEnInfo)
            Dim sYearY As Integer = sDateY.Year
            vWhere = vWhere & " AND YEAR(" & vField & ") = " & sYearY

        ElseIf Me.rdbMonthNow.Checked = True Then

            Dim sDateMN As DateTime = Convert.ToDateTime(dtpMonthNow.Value, _cultureEnInfo)
            Dim sMonthMN As Integer = sDateMN.Month
            Dim sYearMN As Integer = sDateMN.Year
            vWhere = vWhere & " AND Month(" & vField & ") = " & sMonthMN & " AND YEAR(" & vField & ") = " & sYearMN
        End If

        If xProcess = eProcess.eCancel Then  ' eCancel
            vWhere = vWhere & "And s.idPsCanCel Is NULL"

        End If 'End stPage

        Dim pConnection = New SqlConnection
        With pConnection
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connStrxP
            .Open()
        End With
        Dim pCommand = New SqlCommand(sSql, pConnection) With {.CommandTimeout = 10000}
        Dim pAdapter = New SqlDataAdapter(pCommand)

        Dim ds0 As New DataSet
        Dim MainDt As New DataTable  ' SaleMt
        Dim SubDt As New DataTable  ' SaleDt

        'MainDt.Clear()

        pCommand.CommandText = "SELECT CONVERT(bit,0) As chk, s.idSale, s.DocRef, s.DateSaleD As DateSale, sc.SaleCode, s.idPartner," & vbNewLine &
                                "devsk.fncStrDateToDateTime(s.DatePay) As DatePay, s.PartnerNameBill As CusName ,  " & vbNewLine &
                                "s.Total,  s.TotalNet, ISNULL(p6.PsName, '-') As PsSale, " & vbNewLine &
                                "s.DocCode, s.DocRefAcc, p1.PsName As PsTs, s.DateTsD As DateTs, s.TimeTs, s.TotalW, " & vbNewLine &
                                "ts.TspTypeName As Transport, s.idTs, t.PaymentTerms, comp.CompCode, " & vbNewLine &
                                "s.idPsCancel, s.CancelNote, p2.PsName As PsCancel, ISNULL(p3.PsName,'') As PsAccept, " & vbNewLine &
                                "devsk.fncStrDateToDateTime(s.DateAccept) As DateAccept, ISNULL(p4.PsName,'') As PsCheck, " & vbNewLine &
                                "devsk.fncStrDateToDateTime(s.DateChcek) As DateChcek, ISNULL(p5.PsName,'') As PsApp, ISNULL(p7.PsName,'') As PsApp2, s.DateApp2," & vbNewLine &
                                "devsk.fncStrDateToDateTime(s.DateApp) As DateApp, REPLACE(s.Note, '\', ' ') As Note,  ISNULL(s.stBillOrder,0) As stBillOrder, " & vbNewLine &
                                "s.stPromotion, s.idPsAppPromotion, s.stBillType, s.idCus , s.idComp, ISNULL(s.idSlAVxST, 0) As idSlAVxST, " & vbNewLine &
                                "IsNULL(ap.ApName, '-') As ApName, ISNULL(pv.PvName, '-' ) As PvName, IsNULL(s.idSend,0) As idSend, comp.CompName As CompanyName, " & vbNewLine &
                                "CASE WHEN s.idComp = 10 THEN (SELECT CASE WHEN  m.stNoApprove  IS NULL THEN '' Else 'Draft' END" & vbNewLine &
                                                              "FROM SmSaleMt " & vbNewLine &
                                                              "LEFT JOIN WimWaitCutMt m ON SmSaleMt.idSale = m.idMt AND ProcessID = 4" & vbNewLine &
                                                              "WHERE SmSaleMt.idSlAVxST = s.idSale)" & vbNewLine &
                                "ELSE CASE WHEN wMt.stNoApprove IS NULL THEN '' Else 'Draft' END END As stWaitCut, s.idJobMt" & vbNewLine &
                                "From SmSaleMt s " & vbNewLine &
                                "LEFT JOIN dPartner v ON s.idPartner = v.idPartner " & vbNewLine &
                                "LEFT JOIN SmSaleDocCode sc ON s.idSaleCode = sc.idSaleCode" & vbNewLine &
                                "LEFT JOIN dAp ap ON v.pidAp = ap.idAp" & vbNewLine &
                                "LEFT JOIN dProvinceFixSale As pv ON v.pidPv = pv.idPv" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p1 ON s.idPsTs = p1.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p2 ON s.idPsCancel = p2.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p3 ON s.idPsAccept = p3.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p4 ON s.idPsCheck = p4.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p5 ON s.idPsApp = p5.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p6 ON s.idPsSale = p6.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p7 ON s.idPsApp2 = p7.idPs" & vbNewLine &
                                "LEFT JOIN dTspType ts ON s.idTS = ts.idTspType " & vbNewLine &
                                "LEFT JOIN SmPaymentTermsD As t ON s.idPM  = t.idPM " & vbNewLine &
                                "LEFT JOIN PchInvAndProject.dbo.dCompany As comp ON s.idComp = comp.idComp" & vbNewLine &
                                "LEFT JOIN WimWaitCutMt wMt ON s.idSale = wMt.idMt AND wMt.ProcessID = 4" & vbNewLine &
                                "" & vWhere & " AND s.idComp IN (" & SIdCompStr & ")  Order by s.DocCode DESC"
        pAdapter.Fill(MainDt)

        MainDt.Columns.Add("ChkKey", System.Type.GetType("System.Boolean"))

        For i As Integer = 0 To MainDt.Rows.Count - 1
            MainDt.Rows(i).Item("ChkKey") = False
        Next

        '----------------------- Dt table ----------------------------'
        Dim tempDt As New DataTable

        'tempDt.Clear()

        pCommand.CommandText = "Select dt.idSale, dt.idSaleDt, dt.idProduct, dt.idLot, pk.PdCode, dt.LotNo, dt.ProductName, s.idCus, s.idPsSale, " &
                               "dt.Amount, unit.UnitName, ISNULL(dt.DiscountPerc,0) As Discount, ISNULL(dt.DiscountBath,0) As DiscountBath, " &
                               "dt.Price, dt.Amount * dt.Price As ExSump, dt.idWh, bMt.DocCode As DocCode_PO, sw.full_lock " & vbNewLine &
                               "FROM SmSaleDtAll dt  " &
                               "LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine &
                               "LEFT OUTER JOIN SmSaleMt s ON dt.idSale = s.idSale " & vbNewLine &
                               "LEFT JOIN dInventoryMain As main ON dt.idProduct = main.idInvMain" & vbNewLine &
                               "LEFT JOIN dPackingPdSet As pk ON main.idSubType = pk.idPdPk AND main.idInvGroup = 2" & vbNewLine &
                               "LEFT JOIN PkPOBuyMt bMt ON dt.idPOTs = bMt.idPOTs" & vbNewLine &
                               "LEFT JOIN SsWareHouse sw ON dt.idWh = sw.idWh" & vbNewLine &
                               vWhere & " AND s.idComp IN (" & SIdCompStr & ")  Order by dt.No"

        pAdapter.Fill(tempDt)
        pConnection.Close()

        ds0.Tables.Clear()
        ds0.Tables.Add(MainDt)
        ds0.Tables.Add(tempDt)

        Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idSale")
        Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idSale")

        ds0.Relations.Add("รายการ", keyColumn, foreignColumn)

        If ds0.Tables(0).Rows.Count <= 0 Then
            MessageBox.Show("ไม่พบข้อมูลรายการขายสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        GridControl1.DataSource = ds0.Tables(0)
        GridControl1.ForceInitialize()

        GridControl1.LevelTree.Nodes.Add("รายการ", GVSaleDt)
        GridControl1.Refresh()

        txtCount.Text = Format(GVSaleMt.DataRowCount, "#,##0")
        txtCountDt.Text = Format(GetChildRowCount(GVSaleMt), "#,##0")

        stload = 1
    End Sub

    Private Sub rptDoc_Click(sender As Object, e As EventArgs) Handles rptDoc.Click
        If IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidPsCancel)) = True Then
            'idSaleShow = GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale1)
            fnGetReport(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidComp))
        End If
    End Sub

    Private Sub fnGetReport(ByVal idComp As Integer)

        Dim AddressComp As String = ""
        Dim CompnameEng As String = ""
        Dim AddressEng As String = ""
        Dim TelComp As String = ""
        Dim FaxComp As String = ""
        Dim TexCode As String = ""
        Dim stSignPsSale As Integer = 0

        Dim dt As New DataTable
        mdCnOpen2()
        sCommand.CommandText = "Select Address_, Tel, Fax, TaxCode, ISNULL(CompNameEng, '') As CompNameEng, " &
                               "ISNULL(AddressEng_, '') As  AddressEng From vCompany Where idComp = " & idComp & ""
        sAdapter.Fill(dt)

        AddressComp = dt.Rows(0).Item("Address_")
        CompnameEng = dt.Rows(0).Item("CompNameEng")
        AddressEng = dt.Rows(0).Item("AddressEng")

        If IsDBNull(Trim(dt.Rows(0).Item("Tel"))) Then
            TelComp = "-"
        Else
            TelComp = Trim(dt.Rows(0).Item("Tel"))
        End If

        If IsDBNull(dt.Rows(0).Item("Fax")) Then
            FaxComp = "-"
        Else
            FaxComp = Trim(dt.Rows(0).Item("Fax"))
        End If

        If IsDBNull(dt.Rows(0).Item("TaxCode")) Then
            TexCode = "-"
        Else
            TexCode = dt.Rows(0).Item("TaxCode")
        End If

        '****พิมพ์ใบส่งของ****-
        Dim DeliveryDoc As New DataTable
        DeliveryDoc.Clear()
        DeliveryDoc.Columns.Add("idSale", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("DateTs", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("DateSale", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("DatePay", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("DocCode", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("DocRef", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("Total", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("DiscountAmout", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("DiscountPerc", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("TotalNet", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("CusName", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("PsSale", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("PaymentTerms", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("Transport", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("note", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("idPdPk", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("Amount", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("Price", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("DisPerc", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("DiscountBath", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("PdPkName", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("idPkUnit", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("PkUnitName", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("PdCode", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("address", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("AddressS", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("Tel", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("Fax", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("idPsSale", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("idCus", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("picSignPsSale", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("RegianName", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("PriceBfDis", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("TaxCode", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("PsRecName", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("picSignPsTs", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("idPsTs", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("idPsAccept", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("idPsCheck", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("idPsApprove", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("idPsApprove2", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("picSignAccept", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("picSignCheck", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("picSignApprove", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("picSignApprove2", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("DocCode_PO", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("idComp", System.Type.GetType("System.Int32"))

        DeliveryDoc.Columns.Add("idPsSender", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("picSignPsSender", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("idPsRec", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("picSignPsRec", System.Type.GetType("System.Byte[]"))
        mdCnOpen()


        Dim sDt3 As New DataTable
        sDt3.Clear()

        sCommand.CommandText = "Select m.idSale, m.DateTsD As DateTs, m.DateSaleD As DateSale, m.idComp," & vbNewLine &
                             "devsk.fncStrDateToDateTime(m.DatePay) As DatePay, m.DocCode, m.DocRef, m.Total, ISNULL(m.DiscountAmout,0) As DisCountAmout, " & vbNewLine &
                             "ISNULL(m.DiscountPerc,0) As DiscountPerc, m.TotalNet, m.PartnerNameBill As CusName, m.PsSale, m.PaymentTerms, m.Transport, m.note, " & vbNewLine &
                             "idProduct, d.Amount, d.Price, d.PriceBfDis, " & vbNewLine &
                             "d.ProductName, d.Lotno, d.idUnit, unit.UnitName, '' As PdCode, " & vbNewLine &
                             "p.pAddress As address, m.AddressS, p.pTel As Tel, inv.idInvgroup, " & vbNewLine &
                             "c.Fax, c.TaxCode, m.idPsSale, m.idPsSet, m.idPsSend, m.idCus, m.PsRecName, m.TelOfAddrSent, ISNULL(m.stFromS, 1) As stFromS, " & vbNewLine &
                             "m.idPsTs, m.idPsAccept, m.idPsCheck, m.idPsApp As idPsApprove, m.idPsApp2 As idPsApprove2, IsNULL(lq.Grad, '') As Grad,
                             ISNULL((CASE WHEN d.DiscountPerc <> 0 THEN ((d.DiscountPerc*d.PriceBfDis)/100) ELSE d.DiscountBath END),0) As DisCount, ISNULL(bMt.DocCode,'-') As DocCode_PO, m.idPsSender, m.idPsRec" & vbNewLine &
                             "FROM vSmSaleDtAllxSlTs d " & vbNewLine &
                             "LEFT OUTER JOIN vSmSaleMt m ON d.idSale = m.idSale " & vbNewLine &
                             "LEFT JOIN dInvLotQuality lq ON d.idLot = lq.idLot" & vbNewLine &
                             "LEFT JOIN dPartner p ON m.idPartner = p.idPartner" & vbNewLine &
                             "LEFT JOIN dInventoryMain inv ON d.idProduct = inv.idInvMain" & vbNewLine &
                             "LEFT OUTER JOIN dCustomer c ON m.idCus = c.idCus " &
                             "LEFT JOIN dInvUnit As unit ON d.idUnit = unit.idUnit" & vbNewLine &
                             "LEFT JOIN PkPOBuyMt bMt ON d.idPOTs = bMt.idPOTs" & vbNewLine &
                             "WHERE m.idSale = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale) & vbNewLine &
                             "Order by No ASC"
        sAdapter.Fill(sDt3)
        '(CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END)
        For i As Integer = 0 To sDt3.Rows.Count - 1
            Dim rc As Integer = DeliveryDoc.Rows.Count
            DeliveryDoc.Rows.Add()

            DeliveryDoc.Rows(rc).Item("idSale") = sDt3.Rows(i).Item("idSale")
            DeliveryDoc.Rows(rc).Item("DateTs") = Format(sDt3.Rows(i).Item("DateTs"), "dd/MM/yyyy")
            DeliveryDoc.Rows(rc).Item("DateSale") = Format(sDt3.Rows(i).Item("DateSale"), "dd/MM/yyyy")
            DeliveryDoc.Rows(rc).Item("DatePay") = Format(sDt3.Rows(i).Item("DatePay"), "dd/MM/yyyy")
            DeliveryDoc.Rows(rc).Item("DocCode") = sDt3.Rows(i).Item("DocCode")
            DeliveryDoc.Rows(rc).Item("DocRef") = sDt3.Rows(i).Item("DocRef")
            DeliveryDoc.Rows(rc).Item("Total") = sDt3.Rows(i).Item("Total")
            DeliveryDoc.Rows(rc).Item("DiscountAmout") = sDt3.Rows(i).Item("DiscountAmout")
            DeliveryDoc.Rows(rc).Item("DiscountPerc") = sDt3.Rows(i).Item("DiscountPerc")


            DeliveryDoc.Rows(rc).Item("TotalNet") = sDt3.Rows(i).Item("TotalNet")
            DeliveryDoc.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
            DeliveryDoc.Rows(rc).Item("PsSale") = sDt3.Rows(i).Item("PsSale")
            DeliveryDoc.Rows(rc).Item("PaymentTerms") = sDt3.Rows(i).Item("PaymentTerms")
            DeliveryDoc.Rows(rc).Item("Transport") = sDt3.Rows(i).Item("Transport")
            DeliveryDoc.Rows(rc).Item("note") = sDt3.Rows(i).Item("note")
            DeliveryDoc.Rows(rc).Item("idPdPk") = sDt3.Rows(i).Item("idProduct")
            DeliveryDoc.Rows(rc).Item("Amount") = sDt3.Rows(i).Item("Amount")
            DeliveryDoc.Rows(rc).Item("Price") = sDt3.Rows(i).Item("Price")
            DeliveryDoc.Rows(rc).Item("DiscountBath") = sDt3.Rows(i).Item("DisCount")
            DeliveryDoc.Rows(rc).Item("DocCode_PO") = sDt3.Rows(i).Item("DocCode_PO")
            DeliveryDoc.Rows(rc).Item("idComp") = sDt3.Rows(i).Item("idComp")

            If sDt3.Rows(i).Item("idInvgroup") = 30 Then 'ค่าขนส่ง
                DeliveryDoc.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("ProductName")
            Else
                If sDt3.Rows(i).Item("idInvgroup") = 1 And sDt3.Rows(i).Item("Grad") <> "" Then

                    DeliveryDoc.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("ProductName") & vbNewLine & "Lot No. : " & sDt3.Rows(i).Item("Lotno") & " (Grad: " & sDt3.Rows(i).Item("Grad") & ")"
                Else
                    DeliveryDoc.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("ProductName") & vbNewLine & "Lot No. : " & sDt3.Rows(i).Item("Lotno")
                End If
            End If

            DeliveryDoc.Rows(rc).Item("idPkUnit") = sDt3.Rows(i).Item("idUnit")
            DeliveryDoc.Rows(rc).Item("PkUnitName") = sDt3.Rows(i).Item("UnitName")
            DeliveryDoc.Rows(rc).Item("PdCode") = sDt3.Rows(i).Item("PdCode")
            DeliveryDoc.Rows(rc).Item("address") = sDt3.Rows(i).Item("address")
            'If sDt.Rows(i).Item("idPV") = 1 Then
            '    DeliveryDoc.Rows(rc).Item("address") = sDt.Rows(i).Item("address").ToString.Replace("เขต", vbNewLine & "เขต")
            'Else
            '    DeliveryDoc.Rows(rc).Item("address") = sDt.Rows(i).Item("address").ToString.Replace("อ.", vbNewLine & "อ.")
            'End If
            ' DeliveryDoc.Rows(rc).Item("AddressS") = sDt3.Rows(i).Item("AddressS")
            DeliveryDoc.Rows(rc).Item("Tel") = sDt3.Rows(i).Item("Tel")
            DeliveryDoc.Rows(rc).Item("Fax") = sDt3.Rows(i).Item("Fax")
            DeliveryDoc.Rows(rc).Item("idPsSale") = sDt3.Rows(i).Item("idPsSale")
            DeliveryDoc.Rows(rc).Item("idCus") = sDt3.Rows(i).Item("idCus")
            DeliveryDoc.Rows(rc).Item("PriceBfDis") = sDt3.Rows(i).Item("PriceBfDis")
            DeliveryDoc.Rows(rc).Item("TaxCode") = sDt3.Rows(i).Item("TaxCode")
            'If Not IsDBNull(sDt3.Rows(i).Item("PsRecName")) Then
            '    DeliveryDoc.Rows(rc).Item("PsRecName") = sDt3.Rows(i).Item("PsRecName")
            'End If
            DeliveryDoc.Rows(rc).Item("idPsTs") = sDt3.Rows(i).Item("idPsTs")
            DeliveryDoc.Rows(rc).Item("idPsAccept") = sDt3.Rows(i).Item("idPsAccept")
            DeliveryDoc.Rows(rc).Item("idPsCheck") = sDt3.Rows(i).Item("idPsCheck")
            DeliveryDoc.Rows(rc).Item("idPsApprove") = sDt3.Rows(i).Item("idPsApprove")
            DeliveryDoc.Rows(rc).Item("idPsApprove2") = sDt3.Rows(i).Item("idPsApprove2")


            DeliveryDoc.Rows(rc).Item("idPsSender") = sDt3.Rows(i).Item("idPsSender")
            DeliveryDoc.Rows(rc).Item("idPsRec") = sDt3.Rows(i).Item("idPsRec")
        Next


        Dim URL As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, colidComp) & ".jpg"
        Dim client As New System.Net.WebClient
        Dim buffer As Byte()
        Dim pic() As Byte

        Try
            buffer = client.DownloadData(URL)
            Dim stream1 As New System.IO.MemoryStream(buffer)
            Dim binReader1 As New IO.BinaryReader(stream1)
            pic = binReader1.ReadBytes(stream1.Length)
            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picComp") = pic
            Next
        Catch ex As Exception
            ' Noimage
        End Try

        'If sIdComp = 11 Then 'siamAdvanceHost
        '---sign PsTs Pic---'

        Dim URL2 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & sDt3.Rows(0).Item("idPsTs") & ".png"
        'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
        Try
            buffer = client.DownloadData(URL2)
            Dim stream As New System.IO.MemoryStream(buffer)
            Dim binReader As New IO.BinaryReader(stream)
            pic = binReader.ReadBytes(stream.Length)
            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picSignPsTs") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try

        '---sign PsAccept Pic---'
        Dim URL3 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & DeliveryDoc.Rows(0).Item("idPsAccept") & ".png"
        Try
            buffer = client.DownloadData(URL3)
            Dim stream2 As New System.IO.MemoryStream(buffer)
            Dim binReader2 As New IO.BinaryReader(stream2)
            pic = binReader2.ReadBytes(stream2.Length)

            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picSignAccept") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try


        '---sign PsCheck Pic---'
        Dim URL4 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & DeliveryDoc.Rows(0).Item("idPsCheck") & ".png"
        Try
            buffer = client.DownloadData(URL4)
            Dim stream3 As New System.IO.MemoryStream(buffer)
            Dim binReader3 As New IO.BinaryReader(stream3)
            pic = binReader3.ReadBytes(stream3.Length)

            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picSignCheck") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try


        '---sign PsApprove Pic---'
        Dim URL5 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & DeliveryDoc.Rows(0).Item("idPsApprove") & ".png"

        Try
            buffer = client.DownloadData(URL5)
            Dim stream4 As New System.IO.MemoryStream(buffer)
            Dim binReader4 As New IO.BinaryReader(stream4)
            pic = binReader4.ReadBytes(stream4.Length)

            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picSignApprove") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try

        '---sign PsApprove Pic---'
        Dim URL6 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & DeliveryDoc.Rows(0).Item("idPsApprove2") & ".png"

        Try
            buffer = client.DownloadData(URL6)
            Dim stream5 As New System.IO.MemoryStream(buffer)
            Dim binReader5 As New IO.BinaryReader(stream5)
            pic = binReader5.ReadBytes(stream5.Length)

            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picSignApprove2") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try


        '---sign picSignPsSender Pic---'
        Dim URL7 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & DeliveryDoc.Rows(0).Item("idPsSender") & ".png"

        Try
            buffer = client.DownloadData(URL7)
            Dim stream6 As New System.IO.MemoryStream(buffer)
            Dim binReader5 As New IO.BinaryReader(stream6)
            pic = binReader5.ReadBytes(stream6.Length)

            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picSignPsSender") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try


        '---sign picSignPsRec Pic---'
        Dim URL8 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & DeliveryDoc.Rows(0).Item("idPsRec") & ".png"

        Try
            buffer = client.DownloadData(URL8)
            Dim stream7 As New System.IO.MemoryStream(buffer)
            Dim binReader5 As New IO.BinaryReader(stream7)
            pic = binReader5.ReadBytes(stream7.Length)

            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picSignPsRec") = pic
            Next
        Catch ex As Exception
            stSignPsSale = 1
            'Noimage
        End Try

        Dim vRpt As New crpSohui
        vRpt.SetDataSource(DeliveryDoc)
        vRpt.SetParameterValue(vRpt.Parameter_idSale.ParameterFieldName, GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale))
        vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColCompName))
        vRpt.SetParameterValue(vRpt.Parameter_CompNameEng.ParameterFieldName, CompnameEng)
        vRpt.SetParameterValue(vRpt.Parameter_AddressCompEng.ParameterFieldName, AddressEng)
        vRpt.SetParameterValue(vRpt.Parameter_AddressComp.ParameterFieldName, AddressComp)
        vRpt.SetParameterValue(vRpt.Parameter_CompTel.ParameterFieldName, TelComp)
        vRpt.SetParameterValue(vRpt.Parameter_CompFax.ParameterFieldName, FaxComp)
        vRpt.SetParameterValue(vRpt.Parameter_TaxCode.ParameterFieldName, TexCode)
        'vRpt.SetParameterValue(vRpt.Parameter_stSignPsSale.ParameterFieldName, stSignPsSale)

        '--show from cystalreport--'
        Dim vFrmRpt As New FrmReportView
        vFrmRpt.crView.ReportSource = vRpt
        vFrmRpt.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        vFrmRpt.crView.ShowExportButton = False
        vFrmRpt.crView.ShowGroupTreeButton = False
        vFrmRpt.Show()
    End Sub

    Private Sub btnSFindAll_Click(sender As Object, e As EventArgs) Handles btnSFindAll.Click
        mdCnOpen()
        mdLoadShow()
        BindData()
        SumTotal()
        mdLoadCommitt()
    End Sub

    Private Sub rptCancel_Click(sender As Object, e As EventArgs) Handles rptCancel.Click
        '------Check สถานะเบิกของออกจากคลัง
        mdCnOpen()
        Dim stEdit As Integer = 0
        sCommand.CommandText = "SELECT ISNULL(devsk.[WimCheckstUseCutWait] (" & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale) & ",4),0)"
        stEdit = sCommand.ExecuteScalar

        If stEdit <> 0 Then
            MessageBox.Show("รายการนี้ไม่สามารถยกเลิกได้" & vbCrLf & "เนื่องจากมีการเบิกแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        Dim CancelNote As String = " "
        CancelNote = InputBox("ระบุสาเหตุการยกเลิก", sSystemName)
        If CancelNote.Length = 0 Then
            MessageBox.Show("กรุณาระบุสาเหตุการยกเลิก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            mdLoadShow()
            Using myconnection As New SqlConnection(conStr)
                myconnection.Open()
                Dim mycommand As New SqlCommand()
                Dim mytransaction As SqlTransaction

                ' Start a local transaction
                mytransaction = myconnection.BeginTransaction()

                ' Must assign both transaction object and connection
                ' to Command object for a pending local transaction.
                mycommand.Connection = myconnection
                mycommand.Transaction = mytransaction
                Dim myAdapter = New SqlDataAdapter(mycommand)

                Try

                    mycommand.CommandText = "Update SmSaleMt Set idPsCancel = " & sPsId & " , CancelNote = '" & CancelNote & "' " &
                                                    "Where idSale = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale)
                    mycommand.ExecuteNonQuery()

                    mycommand.CommandText = "EXEC WaitCutTs '4','SmSaleMt','SmSaleDtAll','idSale'," & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidSale) &
                                                        "," & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidComp) & "," & sPsId & ",'3'"
                    mycommand.ExecuteNonQuery()

                    mycommand.CommandText = "Update PdIndexShJobMt Set idBillSAM = NULL Where idJobMt = " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidJobMt)
                    mycommand.ExecuteNonQuery()
                    ' Attempt to commit the transaction.
                    mytransaction.Commit()

                    MessageBox.Show("ยกเลิกรายการเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    BindData()
                    SumTotal()
                    mdLoadCommitt()
                Catch ex As Exception
                    ' Attempt to roll back the transaction.
                    Try
                        mytransaction.Rollback()
                        MessageBox.Show("Commit Exception Type: ระบบเกิดข้อผิดพลาด ไม่สามารถบันทึกรายการได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Catch e2x As Exception
                        'MessageBox.Show(ex.Message, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        MessageBox.Show("Commit Exception Type: ระบบเกิดข้อผิดพลาด ไม่สามารถบันทึกรายการได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Try
                    'Finally
                    '    myconnection.Close()
                End Try
            End Using

        End If

    End Sub
    Private Sub GVSaleMt_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVSaleMt.RowCellStyle

        If Not IsDBNull(GVSaleMt.GetRowCellValue(e.RowHandle, ColidPsCancel)) Then
            e.Appearance.BackColor = Color.Salmon
            e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Strikeout)
        End If

    End Sub

    Private Sub GVSaleMt_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVSaleMt.RowClick
        If e.RowHandle < 0 Then
            Exit Sub
        End If

        If Not IsDBNull(GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColidPsCancel)) Then
            MessageBox.Show("ผู้ยกเลิก : " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColPsCancel) & vbNewLine &
                            "ยกเลิกสาเหตุ : " & GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, ColCancelNote), sSystemName)
        End If
    End Sub

    Private Sub rptShow_Click(sender As Object, e As EventArgs) Handles rptShow.Click
        Dim dr As DataRowView
        Dim drDetail() As DataRow

        Dim vFrm As New FrmSlSaleTsSH(FrmSlSaleTsSH.eProcess.eView, dr, drDetail, 0, GVSaleMt.GetRowCellValue(GVSaleMt.FocusedRowHandle, "idSale"))

        If vFrm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub rdbMonth_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMonth.CheckedChanged
        If stload = 1 Then
            If Me.rdbMonth.Checked = True Then
                Me.dtpMonthS.Enabled = True
                Me.dtpMonthE.Enabled = True
            Else
                Me.dtpMonthS.Enabled = False
                Me.dtpMonthE.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbMonthNow_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMonthNow.CheckedChanged
        If stload = 1 Then
            If Me.rdbMonthNow.Checked = True Then
                Me.dtpMonthNow.Enabled = True
            Else
                Me.dtpMonthNow.Enabled = False
            End If
        End If
    End Sub


    Private Sub rdbYear_CheckedChanged(sender As Object, e As EventArgs) Handles rdbYear.CheckedChanged
        If stload = 1 Then
            If Me.rdbYear.Checked = True Then
                Me.dtpYear.Enabled = True
            Else
                Me.dtpYear.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbDate_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDate.CheckedChanged
        If stload = 1 Then
            If Me.rdbDate.Checked = True Then
                Me.dtpSaleS.Enabled = True
                Me.dtpSaleE.Enabled = True
            Else
                Me.dtpSaleS.Enabled = False
                Me.dtpSaleE.Enabled = False
            End If
        End If
    End Sub

    Private Sub chkComp_CheckedChanged(sender As Object, e As EventArgs) Handles chkComp.CheckedChanged
        If stload = 1 Then
            If chkComp.Checked = True Then
                cmbGroupComp.Enabled = True
            Else
                cmbGroupComp.Enabled = False
                fnFilterDataOnGrid()
            End If
        End If
    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stload = 1 Then
            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub ChkCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCus.CheckedChanged
        If stload = 1 Then
            If Me.ChkCus.Checked = True Then
                Me.txtCusName.Enabled = True
                txtCusName.Focus()
            Else
                Me.txtCusName.Enabled = False
                txtCusName.Text = ""
                fnFilterDataOnGrid()
            End If
        End If
    End Sub

    Private Sub txtDocRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCusName.KeyDown
        If e.KeyCode = Keys.Enter Then
            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub fnFilterDataOnGrid()
        Dim StrFilter As String = ""

        If chkComp.Checked = True Then
            StrFilter &= " AND [idComp] = " & cmbGroupComp.SelectedValue

        End If

        If ChkCus.Checked = True And txtCusName.Text.Trim <> "" Then
            StrFilter &= " AND [CusName] LIKE '%" & Trim(txtCusName.Text) & "%'"

        End If

        GVSaleMt.ActiveFilterString = " 1=1" + StrFilter
        txtCount.Text = Format(GVSaleMt.DataRowCount, "#,##0")
        txtCountDt.Text = Format(GetChildRowCount(GVSaleMt), "#,##0")

        SumTotal()
    End Sub

End Class