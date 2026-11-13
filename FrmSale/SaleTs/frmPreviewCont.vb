Public Class frmPreviewCont

    Enum eProcess
        ePreview_PP 'Preprinted Form
        ePreview_ShowLot 'ShowLot
        ePreview_Blank 'Blank Form
        ePreview_BlankNocomp 'Blank Form No company
    End Enum

    Dim xProcess As eProcess
    Dim gStridSale As String = ""
    Dim gStWeight As Integer = 0
    Sub New(ByVal aProcess As eProcess, ByVal stridSale As String, ByVal stWeight As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        My.Application.ChangeCulture("th-TH")

        xProcess = aProcess
        gStridSale = stridSale
        gStWeight = stWeight
    End Sub

    Private Sub frmPreviewCont_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdCnOpen()

        '--------SmSaleMt Part @Header ZONE-----------
        Dim dtSmSaleMt As New DataTable
        sCommand.CommandText = "Select m.idSale, m.DocRef" & vbNewLine &
                               "FROM SmSaleMt m" & vbNewLine &
                               "WHERE m.idSale IN (" & gStridSale & ")" & vbNewLine &
                               "AND m.idPsCancel Is NULL"

        ' Fill ข้อมูลเข้าไปใน dtHeaderData (ตัวแปรชั่วคราว)
        sAdapter.Fill(dtSmSaleMt) ' <-- เปลี่ยนจาก dtSmSaleMt เป็น dtHeaderData
        GCIVList.DataSource = dtSmSaleMt

        BindData(gStridSale)
    End Sub

    Private Sub GVIVList_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVIVList.RowClick
        'BindData(GVIVList.GetRowCellValue(GVIVList.FocusedRowHandle, colidSale))
    End Sub

    Private Sub BindData(ByVal StridSale As String)
        mdCnOpen()
        Dim vWhere As String = ""
        Dim ds As New DataSet
        '--------SmSaleMt Part @Header ZONE-----------
        Dim dtHeaderData As New DataTable("dtSmSaleMt") ' DataTable สำหรับ Header
        sCommand.CommandText = "Select m.idSale, m.DateTsD, CONVERT(VARCHAR(10), m.DateSaleD, 103) As DateSaleD, '' As strTotalxTsp," & vbNewLine &
                               "devsk.fncStrDateToDateTime(m.DatePay) As DatePay, m.idCus, m.idComp," & vbNewLine &
                               "m.DocCode, m.DocRef, r.RegionName, m.Total, m.TotalNet, m.PartnerNameBill, m.PsSale, m.strCredit, m.Transport, m.idPsSale, " & vbNewLine &
                               "c.address, m.AddressS, (CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As Tel, m.DatePay, " & vbNewLine &
                               "c.Fax, m.idPsSale, m.idPsSet, m.idPsSend, ISNULL(m.idCus,0) As idCus, m.PsRecName," & vbNewLine &
                               "m.TelOfAddrSent, ISNULL(m.stFromS, 1) As stFromS, CASE WHEN m.Note <> '' THEN 'หมายเหตุ ' + m.Note Else '' END As Note," & vbNewLine &
                               "IIF(m.TaxCode IS NULL, '', 'เลขประจำตัวผู้เสียภาษี : ' + m.TaxCode) As TaxCode," & vbNewLine &
                               "CASE WHEN ts.idPayTsp = 1 THEN '' ELSE ISNULL(t.PayTspName, ts.PayTspName) END As PayTspName" & vbNewLine &
                               "FROM vSmSaleMt m" & vbNewLine &
                               "LEFT JOIN dPartner pn ON m.idPartner = pn.idPartner" & vbNewLine &
                               "LEFT JOIN dCustomer c ON m.idCus = c.idCus " & vbNewLine &
                               "LEFT JOIN SmMkCusPs p ON p.idCus = m.idCus AND p.idComp = m.idComp" & vbNewLine &
                               "LEFT JOIN SmRegionDComp r On r.idRegion = p.idRegionC AND r.idComp = m.idComp" & vbNewLine &
                               "LEFT JOIN SmRegionPsSaleComp ps ON ps.idRegionC = r.idRegion AND ps.idComp = m.idComp AND ps.idPsSale = m.idPsSale" & vbNewLine &
                               "LEFT JOIN vCusAdrSetTransport t On c.idCus = t.idCus And m.idComp = t.idComp" & vbNewLine &
                               "LEFT JOIN dPayTspType ts On c.idPayTsp = ts.idPayTsp" & vbNewLine &
                               "WHERE m.idSale In (" & StridSale & ")"

        ' Fill ข้อมูลเข้าไปใน dtHeaderData (ตัวแปรชั่วคราว)
        sAdapter.Fill(dtHeaderData) ' <-- เปลี่ยนจาก dtSmSaleMt เป็น dtHeaderData
        dtHeaderData.TableName = "dtSmSaleMt" ' กำหนดชื่อ (ถ้าจำเป็น)

        Dim dtItemData As New DataTable("dtSmSaleDtAll") ' ชื่อต้องตรงกับ Report
        '-----Group By Product And Price
        sCommand.CommandText = "--Select ROW_NUMBER() OVER(PARTITION BY d.idSale ORDER BY Case When d.idProduct = 9766 Then 1 Else 0 End ASC, d.ProductName, d.Price DESC) As No," & vbNewLine &
                                "SELECT ROW_NUMBER() OVER(PARTITION BY d.idSale " & vbNewLine &
                                    "ORDER BY " & vbNewLine &
                                        "CASE WHEN pk.idType = 1 THEN 0 ELSE 1 END," & vbNewLine &
                                        "CASE WHEN pk.idType = 1 AND (pk.shCode IS NULL OR pk.shNo IS NULL) THEN 1 WHEN pk.idType = 1 THEN 0 END," & vbNewLine &
                                        "CASE WHEN pk.idType = 1 THEN pk.shCode END," & vbNewLine &
                                        "CASE WHEN pk.idType = 1 THEN pk.shNo END," & vbNewLine &
                                        "CASE WHEN pk.idType <> 1 OR pk.idType IS NULL THEN oDt.idSaleOrderDt END) AS No, " & vbNewLine &
                               "d.idSale, d.idProduct, d.ProductName, d.Price, SUM(d.Amount) As AmountAllSale, d.Price*SUM(d.Amount) As TotalDt," & vbNewLine &
                               "ISNULL(unit.UnitShort, unit.UnitName) As UnitName, unit.UnitName As UnitNameLong, " & vbNewLine &
                               "-- รวม LotNo และ Amount โดย FORMAT Amount เป็นทศนิยม 2 ตำแหน่ง" & vbNewLine &
                               "STRING_AGG( d.LotNo + ' (' + FORMAT(d.Amount, 'N2') + ')', ', ') WITHIN GROUP (ORDER BY d.LotNo) AS [LotDetailUsed] ," & vbNewLine &
                               "ISNULL(pk.PdPkName3, d.ProductName) As ProductNoWeight, oMt.DocCode, oMt.DateRequireD, ISNULL(oMt.DocRef, oMt.DocCode) As CodeOrder, CONVERT(VARCHAR(10), oMt.DateRequireD, 103)  As DateOrder" & vbNewLine &
                               "FROM SmSaleDtAll d " & vbNewLine &
                               "LEFT JOIN dInvUnit unit ON d.idUnit = unit.idUnit " & vbNewLine &
                               "LEFT JOIN dInventoryMain inv ON inv.idInvMain = d.idProduct AND inv.idInvGroup = 2" & vbNewLine &
                               "LEFT JOIN vPackingPdSet pk ON inv.idSubType = pk.idPdPk" & vbNewLine &
                               "LEFT JOIN SmSaleOrderDt oDt ON d.idSaleOrderDt = oDt.idSaleOrderDt" & vbNewLine &
                               "LEFT JOIN SmSaleOrderMt oMt ON oDt.idSaleOrder = oMt.idSaleOrder" & vbNewLine &
                               "WHERE d.idSale IN( " & StridSale & ")" & vbNewLine &
                               "GROUP BY d.idSale, d.Price, d.idProduct, d.ProductName, unit.UnitShort, unit.UnitName, " & vbNewLine &
                               "pk.PdPkName3, oMt.DocCode, oMt.DateRequireD, oMt.DocRef, pk.idType, pk.shNo, pk.shCode, oDt.idSaleOrderDt" & vbNewLine &
                               "Order By CASE WHEN pk.idType = 1 THEN 0" & vbNewLine &
                               "Else 1 End," & vbNewLine &
                               "Case WHEN pk.idType = 1 And (pk.shCode Is NULL Or pk.shNo Is NULL)" & vbNewLine &
                               "THEN 1 WHEN pk.idType = 1 THEN 0 End," & vbNewLine &
                               "Case WHEN pk.idType = 1 THEN pk.shCode End," & vbNewLine &
                               "Case WHEN pk.idType = 1 THEN pk.shNo End," & vbNewLine &
                               "Case WHEN pk.idType <> 1 Or pk.idType Is NULL" & vbNewLine &
                               "THEN ISNULL(oDt.idSaleOrderDt,0) End"

        sAdapter.Fill(dtItemData) ' <-- เปลี่ยนจาก dtSmSaleDtAll เป็น dtItemData

        ' 4. **เพิ่ม DataTable ใหม่** เข้าไปใน DataSet ใหม่
        dtItemData.TableName = "dtSmSaleDtAll" ' กำหนดชื่อ (ถ้าจำเป็น)

        If gStWeight = 1 Then
            dtItemData.Columns("ProductName").Expression = "ProductNoWeight"
        End If

        '-------------------------- Footer Detail -------------------------------'
        ' ใช้ For Each วนลูปทุกแถวใน dtHeaderData
        For Each row As DataRow In dtHeaderData.Rows
            Dim shippingAmount As Double = 0

            Dim shippingRows As DataRow() = dtItemData.Select("idProduct = '9766' OR ProductName = 'ค่าขนส่ง'")

            If shippingRows.Length > 0 Then
                Dim shippingRow As DataRow = shippingRows(0)

                ' เก็บยอดเงิน
                shippingAmount = Convert.ToDecimal(shippingRow("TotalDt")).ToString("N2")

                ' ลบออกจาก DataTable
                dtItemData.Rows.Remove(shippingRow)
            End If

            ' เช็คเงื่อนไข stFromS ของแต่ละแถว
            If row("stFromS").ToString() = "0" Then

                ' ดึงค่า Note เดิมเก็บไว้ในตัวแปรชั่วคราว
                Dim currentNote As String = row("Note").ToString()

                ' ต่อ String โดยใช้ตัวแปรชั่วคราว
                currentNote &= "\"

                If Not IsDBNull(row("PsRecName")) AndAlso row("PsRecName").ToString() <> "" Then
                    currentNote &= "ส่ง : " & row("PsRecName").ToString()
                End If

                currentNote &= "\" & row("AddressS").ToString()

                If row("TelOfAddrSent").ToString() <> "" Then
                    currentNote &= "\โทร. " & row("TelOfAddrSent").ToString()
                Else
                    currentNote &= "\โทร. - "
                End If

                ' อัปเดตกลับเข้าไปใน row ปัจจุบัน
                row("Note") = currentNote
            End If

            ' 2. เพิ่ม Row ค่าขนส่งลงใน dtItemData ด้านล่างสุด
            ' ดึงค่า Note เดิมเก็บไว้ในตัวแปรชั่วคราว
            Dim strTotalxTsp As String = ""
            strTotalxTsp &= "รวมเป็นเงิน    " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & Format(row.Item("TotalNet") - shippingAmount, "#,##0.00")

            If shippingAmount > 0 Then
                strTotalxTsp &= "\"
                strTotalxTsp &= "ค่าขนส่ง-ขาย" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & Format(shippingAmount, "#,##0.00")
            End If
            row("strTotalxTsp") = strTotalxTsp
        Next


        '------------------------------ END Footer --------------------------------------'

        ds.Tables.Add(dtHeaderData)
        ds.Tables.Add(dtItemData)

        ds.Relations.Add(ds.Tables("dtSmSaleMt").Columns("idSale"), ds.Tables("dtSmSaleDtAll").Columns("idSale"))

        If xProcess = eProcess.ePreview_PP Then
            Dim vRpt As New crp9x11PPForm
            vRpt.SetDataSource(ds)
            'vRpt.SetParameterValue(vRpt.Parameter_TypProductName.ParameterFieldName, gStWeight)

            CrPreview.ReportSource = vRpt
            CrPreview.Show()
        ElseIf xProcess = eProcess.ePreview_ShowLot Then
            Dim vRpt As New crp9x11ShowLot
            vRpt.SetDataSource(ds)
            'vRpt.SetParameterValue(vRpt.Parameter_TypProductName.ParameterFieldName, gStWeight)

            CrPreview.ReportSource = vRpt
            CrPreview.Show()

        ElseIf xProcess = eProcess.ePreview_Blank Then

            Dim AddressComp As String = ""
            Dim CompnameEng As String = ""
            Dim AddressEng As String = ""
            Dim TelComp As String = ""
            Dim FaxComp As String = ""
            Dim TexCode As String = ""
            Dim stSignPsSale As Integer = 0

            Dim dt As New DataTable
            mdCnOpen2()
            sCommand.CommandText = "Select Address_, Tel, Fax, TaxCode, CompName, ISNULL(CompNameEng, '') As CompNameEng, " & vbNewLine &
                                    "ISNULL(AddressEng_, '') As  AddressEng " & vbNewLine &
                                    "From vCompany " & vbNewLine &
                                    "Where idComp = " & dtHeaderData.Rows(0).Item("idComp")
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

            Dim vRpt As New crp9x11BlankForm
            vRpt.SetDataSource(ds)
            ' vRpt.SetParameterValue(vRpt.Parameter_TypProductName.ParameterFieldName, gStWeight)
            vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, dt.Rows(0).Item("CompName"))
            vRpt.SetParameterValue(vRpt.Parameter_CompNameEng.ParameterFieldName, CompnameEng)
            vRpt.SetParameterValue(vRpt.Parameter_AddressCompEng.ParameterFieldName, AddressEng)
            vRpt.SetParameterValue(vRpt.Parameter_AddressComp.ParameterFieldName, AddressComp)
            vRpt.SetParameterValue(vRpt.Parameter_CompTel.ParameterFieldName, TelComp)
            vRpt.SetParameterValue(vRpt.Parameter_CompFax.ParameterFieldName, If(FaxComp = "", "-", FaxComp))
            vRpt.SetParameterValue(vRpt.Parameter_TaxCode.ParameterFieldName, TexCode)
            CrPreview.ReportSource = vRpt
            CrPreview.Show()
        ElseIf xProcess = eProcess.ePreview_BlankNocomp Then

            Dim TelComp As String = ""


            Dim dt As New DataTable
            mdCnOpen2()
            sCommand.CommandText = "Select Address_, Tel, Fax, TaxCode, CompName, ISNULL(CompNameEng, '') As CompNameEng, " & vbNewLine &
                                    "ISNULL(AddressEng_, '') As  AddressEng " & vbNewLine &
                                    "From vCompany " & vbNewLine &
                                    "Where idComp = " & dtHeaderData.Rows(0).Item("idComp")
            sAdapter.Fill(dt)

            If IsDBNull(Trim(dt.Rows(0).Item("Tel"))) Then
                TelComp = "-"
            Else
                TelComp = Trim(dt.Rows(0).Item("Tel"))
            End If

            If IsDBNull(dt.Rows(0).Item("Fax")) Then
                TelComp = TelComp & " แฟ็กซ์ -"
            Else
                TelComp = TelComp & " แฟ็กซ์ " & Trim(dt.Rows(0).Item("Fax"))
            End If

            Dim vRpt As New crp9x11BlankFormNoComp
            vRpt.SetDataSource(ds)
            'vRpt.SetParameterValue(vRpt.Parameter_TypProductName.ParameterFieldName, gStWeight)
            vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, dt.Rows(0).Item("CompName"))
            vRpt.SetParameterValue(vRpt.Parameter_CompTel.ParameterFieldName, TelComp)
            CrPreview.ReportSource = vRpt
            CrPreview.Show()
        End If

    End Sub

    Private Sub GVIVList_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVIVList.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub
End Class