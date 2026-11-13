Imports DevExpress.XtraSplashScreen
Public Class frmSaleRpt
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")

    Private Sub frmSaleRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpSaleS.Value = Date.Today
        Me.dtpSaleE.Value = Date.Today
        Me.dtpMonth.Value = Date.Today
        Me.dtpYear.Value = Date.Today

        setCmbGroupComp(Me.cmbGroupComp)
        cmbDocType() ' set Combobox รหัสเอกสาร
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        mdCnOpen()
        mdLoadShow()
        'SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)

        Dim vWhere As String = " "
        Dim vWhereMt As String = ""
        Dim para_ReportType As String = ""
        Dim para_HeadCol1 As String = ""
        Dim para_HeadCol2 As String = ""
        Dim para_HeadCol3 As String = ""
        Dim para_DateS As String = ""
        Dim para_TotalPrice As Decimal = 0.0
        Dim para_TotalDis As Decimal = 0.0
        Dim para_TotalAmt As Decimal = 0.0
        Dim vField As String = "mt.DateSaleD"

        '---ช่วงวันที่---'
        If Me.rdbDate.Checked = True Then
            'vWhere = vWhere & " smt.DateSale Between " & ksbDateToString(dtpSaleS.Value.ToShortDateString) & " AND " & ksbDateToString(dtpSaleE.Value.ToShortDateString) & " "
            'para_DateS = "วันที่ " & dtpSaleS.Value.ToShortDateString & " ถึง " & dtpSaleE.Value.ToShortDateString

            Dim firstDate As DateTime = Convert.ToDateTime(dtpSaleS.Value, _cultureEnInfo)
            Dim lastDate As DateTime = Convert.ToDateTime(dtpSaleE.Value, _cultureEnInfo)

            vWhere = vWhere & " AND " & vField & " Between '" & firstDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " & _
                              "And '" & lastDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' "

            para_DateS = "วันที่ " & dtpSaleS.Value.ToShortDateString & " ถึง " & dtpSaleE.Value.ToShortDateString

        ElseIf Me.rdbMonth.Checked = True Then
            'Dim MonthShow As String = ""
            'If Me.dtpMonth.Value.Month.ToString.Length = 1 Then
            '    MonthShow = Microsoft.VisualBasic.Right(Me.dtpMonth.Text, 4) & "0" & Me.dtpMonth.Value.Month
            'ElseIf Me.dtpMonth.Value.Month.ToString.Length = 2 Then
            '    MonthShow = Microsoft.VisualBasic.Right(Me.dtpMonth.Text, 4) & Me.dtpMonth.Value.Month
            'End If
            'vWhere = vWhere & " SUBSTRING(smt.DateSale,1,6) = '" & MonthShow & "'"
            'para_DateS = "เดือน " & Me.dtpMonth.Text

            Dim sDateMN As DateTime = Convert.ToDateTime(dtpMonth.Value, _cultureEnInfo)
            Dim sMonthMN As Integer = sDateMN.Month
            Dim sYearMN As Integer = sDateMN.Year
            vWhere = vWhere & " AND Month(" & vField & ") = " & sMonthMN & " AND YEAR(" & vField & ") = " & sYearMN
            para_DateS = "เดือน " & Me.dtpMonth.Text

        ElseIf Me.rdbYear.Checked = True Then
            Dim sDateY As DateTime = Convert.ToDateTime(dtpYear.Value, _cultureEnInfo)
            Dim sYearY As Integer = sDateY.Year
            vWhere = vWhere & " AND YEAR(" & vField & ") = " & sYearY

            'vWhere &= " SUBSTRING(smt.DateSale,1,4) = '" & Microsoft.VisualBasic.Right(Me.dtpYear.Text, 4) & "'"
            para_DateS = "ปี " & Me.dtpYear.Text
        End If

        If Me.CheckDocType.Checked = True Then 'รหัสเอกสาร
            Dim dataTypeP As Object = ccbtDocType.Properties.Items.GetCheckedValues()
            Dim tWhere As String = " AND ("
            For i As Integer = 0 To dataTypeP.Count - 1

                If i = dataTypeP.Count - 1 Then
                    tWhere &= "mt.idSaleCode = " & dataTypeP(i) & " )"
                Else
                    tWhere &= "mt.idSaleCode = " & dataTypeP(i) & " OR "
                End If
            Next
            vWhere &= tWhere
        End If

        If Me.CheckRefNo.Checked = True Then 'เลขที่อ้างอิง
            vWhere &= " AND mt.DocRef = '" & txtRefNo.Text & "'"
        End If

        If Me.CheckDocNo.Checked = True Then 'เลขที่เอกสาร
            vWhere &= " AND mt.DocCode = '" & txtDocNo.Text & "'"
        End If

        If Me.CheckCus.Checked = True Then 'ลูกค้า
            vWhere &= " AND mt.idCus = " & lblCus.Tag & ""
        End If

        If Me.CheckPsSale.Checked = True Then 'เจ้าหน้าที่ขาย
            vWhere &= " AND mt.idPsSale = " & lblPsSale.Tag & ""
        End If

        If Me.cbPsOrder.Checked = True Then 'ผู้สั่งซื้อ
            vWhere &= " AND ISNULL(mt.idPsOrder,0) = " & lblPsOrder.Tag
        End If


        vWhereMt &= vWhere ' set Query MT

        If Me.CheckPdNo.Checked = True Then 'รหัสสินค้า
            vWhere &= " AND pk.PdCode = '" & txtPdNo.Text & "'"
        End If

        If Me.chkLotNo.Checked = True Then 'รหัสสินค้า
            vWhere &= " AND dt.LotNo = '" & Trim(txtLotNo.Text) & "'"
        End If

        If Me.CheckPdName.Checked = True Then 'ชื่อสินค้า
            vWhere &= " AND dt.idProduct = " & lblPdName.Tag & ""
        End If

        Dim PdWHERE As String = ""
        If Me.CheckGen.Checked = True Then 'สินค้าสำเร็จรูป
            If PdWHERE <> "" Then
                PdWHERE = PdWHERE & " OR main.idInvGroup = 2 "
            Else
                PdWHERE = PdWHERE & " main.idInvGroup = 2 "
            End If
        End If

        If Me.CheckOther.Checked = True Then 'สินค้าอื่นๆ
            If PdWHERE <> "" Then
                PdWHERE = PdWHERE & " OR main.idInvGroup IN (Select idInvGroup From dInvGroup Where stPdOther Is Not Null) "
            Else
                PdWHERE = PdWHERE & " main.idInvGroup IN (Select idInvGroup From dInvGroup Where stPdOther Is Not Null) "
            End If
        End If

        If Me.CheckMat.Checked = True Then 'สินค้าวัตถุดิบ
            If PdWHERE <> "" Then
                PdWHERE = PdWHERE & " OR main.idInvGroup = 1 "
            Else
                PdWHERE = PdWHERE & " main.idInvGroup = 1 "
            End If
        End If

        If Me.ChkTsp.Checked = True Then
            If PdWHERE <> "" Then
                PdWHERE = PdWHERE & " OR main.idInvGroup = 30 "
            Else
                PdWHERE = PdWHERE & " main.idInvGroup = 30"
            End If
        End If

        If Me.cbMeterial.Checked = True Then
            If PdWHERE <> "" Then
                PdWHERE = PdWHERE & " OR (main.idInvGroup NOT IN (1,2,30) AND main.idInvGroup Not IN (Select idInvGroup From dInvGroup Where stPdOther Is Not Null))"
            Else
                PdWHERE = PdWHERE & " (main.idInvGroup NOT IN (1,2,30) AND main.idInvGroup Not IN (Select idInvGroup From dInvGroup Where stPdOther Is Not Null)) "
            End If
        End If

        If PdWHERE <> "" Then
            vWhere = vWhere & " AND (" & PdWHERE & " ) "
        End If

        If Me.CheckGen.Checked = True Then
            If Me.rdbGenPN.Checked = True Then 'สินค้าทั่วไป
                vWhere = vWhere & " AND pk.idType = '0' "
            ElseIf Me.rdbGenPC.Checked = True Then 'สินค้าผักซอง
                vWhere = vWhere & "AND pk.idType = '1' "
            End If
        End If

        Dim SaleRptMt As New DataTable("SaleRptMt")
        Dim SaleRptDt As New DataTable("SaleRptDt")
        Dim SaleSummaryNoPdSale As New DataTable
        Dim Tsp As New DataTable

        SaleSummaryNoPdSale.Columns.Add("LastDate", System.Type.GetType("System.String"))
        SaleRptDt.Clear()

        If cbSlAVxST.Checked = True Then
            vWhere = vWhere & " AND ISNULL(mt.idSlAVxST,0) <> 0"
        Else
            vWhere = vWhere & " AND ISNULL(mt.idSlAVxST,0) = 0"
        End If

        If Me.rdbDaily.Checked = True Then 'ประจำวัน GroupName = รหัสสินค้า+ชื่อสินค้า , DataName1 = ชื่อลูกค้า, DataName2 = ชื่อเจ้าหน้าที่ขาย
            sCommand.CommandText = " SELECT FORMAT(mt.DateSaleD, 'd', 'th') As DateSale, CONCAT(pk.PdCode,' ', CONCAT(main.InvName,' Lot No. ',dt.LotNo)) As GroupName , " & vbNewLine &
                                      "CONCAT(mt.PartnerNameBill, ' : ' ,mt.DocRef) As DataName1, unit.UnitName, w.WareHouseName," & vbNewLine &
                                      "HR_Seeds.hr.employeename(mt.idPsSale,8003) As DataName2, dt.Amount, dt.PriceBfDis, CASE WHEN dt.DisCountPerc <> 0 THEN ((dt.PriceBfDis * dt.DisCountPerc)/100)  ELSE  dt.DisCountBath END As DisCountPerc, " & vbNewLine &
                                      "dt.LotNo" & vbNewLine &
                                      "FROM SmSaleDtAll As dt " & vbNewLine &
                                      "LEFT JOIN SmSaleMt mt ON dt.idSale = mt.idSale " & vbNewLine &
                                      "LEFT JOIN dInventoryMain As main ON dt.idProduct = main.idInvMain" & vbNewLine &
                                      "LEFT JOIN dPackingPdSet As pk ON main.idSubType = pk.idPdPk AND main.idInvGroup = 2" & vbNewLine &
                                      "LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine &
                                      "LEFT JOIN dPartner As pn ON mt.idPartner = pn.idPartner" & vbNewLine &
                                      "LEFT JOIN SsWareHouse w ON dt.idWh = w.idWh" & vbNewLine &
                                      "WHERE mt.idPsCancel is null " & vbNewLine &
                                      "AND mt.idComp = " & cmbGroupComp.SelectedValue & " " & vWhere & "" & vbNewLine &
                                      "ORDER BY mt.DateSaleD  ASC"

            sAdapter.Fill(SaleRptDt)
            para_ReportType = Me.rdbPd.Text
            para_HeadCol1 = "รายการสินค้า"
            'para_HeadCol2 = "ลูกค้า"
            para_HeadCol3 = "เจ้าหน้าที่ขาย"

            para_ReportType = Me.rdbDaily.Text

        ElseIf Me.rdbPsSale.Checked = True Then  'ตามเจ้าหน้าที่ขาย' GroupName = ชื่อเจ้าหน้าที่ขาย , DataName1 = รหัสสินค้า+ชื่อสินค้า , DataName2 = ชื่อลูกค้า

            sCommand.CommandText = " SELECT FORMAT(mt.DateSaleD, 'd', 'th') As DateSale , CONCAT(pk.PdCode,' ', dt.ProductName) As DataName1, " & vbNewLine &
                                   " mt.PartnerNameBill As DataName2, HR_Seeds.hr.employeename(mt.idPsSale,8003) As GroupName, dt.Amount, dt.PriceBfDis, " & vbNewLine &
                                   " CASE WHEN dt.DisCountPerc <> 0 THEN ((dt.PriceBfDis * dt.DisCountPerc)/100)  ELSE  dt.DisCountBath END As DisCountPerc " & vbNewLine &
                                   " FROM SmSaleDtAll dt " & vbNewLine &
                                   " LEFT OUTER JOIN SmSaleMt mt ON dt.idSale = mt.idSale " & vbNewLine &
                                   " LEFT JOIN dInventoryMain As main ON dt.idProduct = main.idInvMain" & vbNewLine &
                                   " LEFT JOIN dPackingPdSet As pk ON main.idSubType = pk.idPdPk AND main.idInvGroup = 2" & vbNewLine &
                                   " LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine &
                                   " LEFT JOIN dPartner As pn ON mt.idPartner = pn.idPartner" & vbNewLine &
                                   " WHERE mt.idPsCancel is null " & vbNewLine &
                                   " AND mt.idComp = '" & cmbGroupComp.SelectedValue & "' " & vWhere & "" & vbNewLine &
                                   " ORDER BY mt.DateSaleD ASC , pk.PdCode ASC "

            sAdapter.Fill(SaleRptDt)
            para_ReportType = Me.rdbPsSale.Text
            para_HeadCol1 = "รายการสินค้า"
            para_HeadCol2 = "ลูกค้า"

        ElseIf Me.rdbCus.Checked = True Then 'ตามลูกค้า' GroupName = ชื่อลูกค้า , DataName1 = รหัสสินค้า+ชื่อสินค้า , DataName2 = ชื่อเจ้าหน้าที่ขาย
            sCommand.CommandText = " SELECT FORMAT(mt.DateSaleD, 'd', 'th') As DateSale, CONCAT(pk.PdCode,' ', dt.ProductName) As DataName1 ,mt.PartnerNameBill As GroupName, " & vbNewLine &
                                   " HR_Seeds.hr.employeename(mt.idPsSale,8003) As DataName2, dt.Amount, dt.PriceBfDis, CASE WHEN dt.DisCountPerc <> 0 THEN ((dt.PriceBfDis * dt.DisCountPerc)/100)  ELSE  dt.DisCountBath END As DisCountPerc " & vbNewLine &
                                   " FROM SmSaleDtAll As dt " & vbNewLine &
                                   " LEFT OUTER JOIN SmSaleMt As mt ON dt.idSale = mt.idSale " & vbNewLine &
                                   " LEFT JOIN dInventoryMain As main ON dt.idProduct = main.idInvMain" & vbNewLine &
                                   " LEFT JOIN dPackingPdSet As pk ON main.idSubType = pk.idPdPk AND main.idInvGroup = 2" & vbNewLine &
                                   " LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine &
                                   " LEFT JOIN dPartner As pn ON mt.idPartner = pn.idPartner" & vbNewLine &
                                   " WHERE mt.idPsCancel is null AND mt.idComp = '" & cmbGroupComp.SelectedValue & "' " & vWhere & "" &
                                   " ORDER BY mt.DateSaleD ASC ,pk.PdCode ASC "

            sAdapter.Fill(SaleRptDt)
            para_ReportType = Me.rdbCus.Text
            para_HeadCol1 = "รายการสินค้า"
            para_HeadCol2 = "เจ้าหน้าที่ขาย"

        ElseIf Me.rdbPsOrder.Checked = True Then 'ตามผู้สั่ง' GroupName = ชื่อผู้สั่ง , DataName1 = รหัสสินค้า+ชื่อสินค้า , DataName2 = ชื่อลูกค้า
            sCommand.CommandText = " SELECT FORMAT(mt.DateSaleD, 'd', 'th') As DateSale, CONCAT(pk.PdCode,' ', dt.ProductName) As DataName1 ,CONCAT('ผู้สั่ง : ','',ISNULL(PsFullName,'-')) As GroupName, " & vbNewLine &
                                   " mt.PartnerNameBill As DataName2, dt.Amount, dt.PriceBfDis, CASE WHEN dt.DisCountPerc <> 0 THEN ((dt.PriceBfDis * dt.DisCountPerc)/100)  ELSE  dt.DisCountBath END As DisCountPerc " & vbNewLine &
                                   " FROM SmSaleDtAll As dt " & vbNewLine &
                                   " LEFT OUTER JOIN SmSaleMt As mt ON dt.idSale = mt.idSale " & vbNewLine &
                                   " LEFT JOIN dInventoryMain As main ON dt.idProduct = main.idInvMain" & vbNewLine &
                                   " LEFT JOIN dPackingPdSet As pk ON main.idSubType = pk.idPdPk AND main.idInvGroup = 2" & vbNewLine &
                                   " LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine &
                                   " LEFT JOIN dPartner As pn ON mt.idPartner = pn.idPartner" & vbNewLine &
                                   " LEFT JOIN vPersonxSelect p ON mt.idPsOrder = p.idPs" & vbNewLine &
                                   " WHERE mt.idPsCancel is null AND mt.idComp = '" & cmbGroupComp.SelectedValue & "' " & vWhere & "" &
                                   " ORDER BY mt.DateSaleD ASC ,pk.PdCode ASC "

            sAdapter.Fill(SaleRptDt)
            para_ReportType = Me.rdbPsOrder.Text
            para_HeadCol1 = "รายการสินค้า"
            para_HeadCol2 = "ลูกค้า"

        ElseIf Me.rdbPd.Checked = True Then 'ตามสินค้า' GroupName = รหัสสินค้า+ชื่อสินค้า , DataName1 = ชื่อลูกค้า, DataName2 = ชื่อเจ้าหน้าที่ขาย
            sCommand.CommandText = " SELECT FORMAT(mt.DateSaleD, 'd', 'th') As DateSale, CONCAT(pk.PdCode,' ', dt.ProductName) As GroupName , mt.PartnerNameBill As DataName1," & vbNewLine & _
                                   " HR_Seeds.hr.employeename(mt.idPsSale,8003) As DataName2, dt.Amount, dt.PriceBfDis, " & vbNewLine & _
                                   " CASE WHEN dt.DisCountPerc <> 0 THEN ((dt.PriceBfDis * dt.DisCountPerc)/100)  ELSE  dt.DisCountBath END As DisCountPerc " & _
                                   " FROM vSmSaleDtAll dt " & _
                                   " LEFT OUTER JOIN SmSaleMt mt ON dt.idSale = mt.idSale " & _
                                   " LEFT JOIN dInventoryMain As main ON dt.idProduct = main.idInvMain" & vbNewLine & _
                                   " LEFT JOIN dPackingPdSet As pk ON main.idSubType = pk.idPdPk AND main.idInvGroup = 2" & vbNewLine & _
                                   " LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine & _
                                   " LEFT JOIN dPartner As pn ON mt.idPartner = pn.idPartner" & vbNewLine & _
                                   " WHERE mt.idPsCancel is null AND mt.idComp = '" & cmbGroupComp.SelectedValue & "' " & vWhere & "" & _
                                   " ORDER BY mt.DateSaleD ASC , pk.PdCode ASC "
            sAdapter.Fill(SaleRptDt)

            para_ReportType = Me.rdbPd.Text
            para_HeadCol1 = "ลูกค้า"
            para_HeadCol2 = "เจ้าหน้าที่ขาย"

        ElseIf Me.rdbDoc.Checked = True Then 'ตามเอกสาร' GroupName = รหัสสินค้า+ชื่อสินค้า , DataName1 = ชื่อลูกค้า, DataName2 = ชื่อเจ้าหน้าที่ขาย
            sCommand.CommandText = " SELECT FORMAT(mt.DateSaleD, 'd', 'th') As DateSale, CONCAT(pk.PdCode,' ', dt.ProductName) As GroupName ,mt.PartnerNameBill As DataName1, HR_Seeds.hr.employeename(mt.idPsSale,8003) As DataName2, " & vbNewLine & _
                                   " dt.Amount, dt.PriceBfDis, CASE WHEN dt.DisCountPerc <> 0 THEN ((dt.PriceBfDis * dt.DisCountPerc)/100)   ELSE  dt.DisCountBath END As DisCountPerc, " & vbNewLine & _
                                   " mt.DocCode, mt.DocRef, dt.LotNo, mt.idSale" & vbNewLine & _
                                   " FROM vSmSaleDtAll dt " & vbNewLine & _
                                   " LEFT OUTER JOIN SmSaleMt mt ON dt.idSale = mt.idSale " & vbNewLine & _
                                   " LEFT JOIN dInventoryMain As main ON dt.idProduct = main.idInvMain" & vbNewLine & _
                                   " LEFT JOIN dPackingPdSet As pk ON main.idSubType = pk.idPdPk AND main.idInvGroup = 2" & vbNewLine & _
                                   " LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine & _
                                   " LEFT JOIN dPartner As pn ON mt.idPartner = pn.idPartner" & vbNewLine & _
                                   " WHERE mt.idPsCancel is null AND mt.idComp = '" & cmbGroupComp.SelectedValue & "' " & vWhere & "" & _
                                   " ORDER BY mt.DateSaleD ASC, pk.PdCode ASC "
            sAdapter.Fill(SaleRptDt) ' Query DT 

            sCommand.CommandText = " SELECT Distinct mt.DateSale As DD, mt.idSale, FORMAT(mt.DateSaleD, 'd', 'th') As DateSale, mt.idSale, mt.DocCode, mt.DocRef, mt.PartnerNameBill As CusName, HR_Seeds.hr.employeename(mt.idPsSale,8003) As PsSale " & vbNewLine & _
                                   " FROM SmSaleMt mt" & vbNewLine & _
                                   " LEFT OUTER JOIN vSmSaleDtAll dt ON mt.idSale = dt.idSale " & vbNewLine & _
                                   " LEFT JOIN dInventoryMain As main ON dt.idProduct = main.idInvMain" & vbNewLine & _
                                   " LEFT JOIN dPartner As pn ON mt.idPartner = pn.idPartner" & vbNewLine & _
                                   " WHERE mt.idPsCancel is null AND mt.idComp = '" & cmbGroupComp.SelectedValue & "' " & vWhere & "" & _
                                   " ORDER BY mt.DocRef"

            sAdapter.Fill(SaleRptMt) ' Query MT

            For i As Integer = 0 To SaleRptMt.Rows.Count - 1
                SaleRptMt.Rows(i).Item("DateSale") = SaleRptMt.Rows(i).Item("DateSale")
            Next

            For i As Integer = 0 To SaleRptDt.Rows.Count - 1

                para_TotalPrice += SaleRptDt.Rows(i).Item("Amount") * (SaleRptDt.Rows(i).Item("PriceBfDis") - SaleRptDt.Rows(i).Item("DisCountPerc"))
                para_TotalDis += SaleRptDt.Rows(i).Item("DisCountPerc")
                para_TotalAmt += SaleRptDt.Rows(i).Item("Amount")

            Next

            para_ReportType = Me.rdbDoc.Text
            para_HeadCol1 = "ลูกค้า"
            para_HeadCol2 = "เจ้าหน้าที่ขาย"

        ElseIf Me.rdbCusNoSale.Checked = True Then 'ตามรายการลูกค้าที่ไม่มียอดขาย' 
            sCommand.CommandText = " SELECT pn.idCus, PartnerName AS Data,(SELECT MAX(DateSaleD) FROM SmSaleMt " & vbNewLine & _
                            " WHERE idPsCancel IS NULL AND idComp = '" & cmbGroupComp.SelectedValue & "' AND idPartner = pn.idPartner) AS DateSale ,( " & vbNewLine & _
                            " SELECT DATEDIFF(DAY,MAX(DateSaleD), getdate()) " & vbNewLine & _
                            " FROM SmSaleMt WHERE idPsCancel IS NULL AND idComp = '" & cmbGroupComp.SelectedValue & "' AND idPartner = pn.idPartner ) AS CountDay " & vbNewLine & _
                            " FROM dPartner pn WHERE pn.idPartner NOT IN ( SELECT distinct idPartner " & vbNewLine & _
                            " FROM SmSaleMt mt WHERE mt.idPsCancel IS NULL AND mt.idComp = '" & cmbGroupComp.SelectedValue & "' " & vbNewLine & _
                            " " & vWhereMt & " ) AND pn.stDel IS NULL AND pn.idCus Is NOT NULL" & vbNewLine & _
                            " ORDER BY PartnerName ASC "
            sAdapter.Fill(SaleSummaryNoPdSale)

            For i As Integer = 0 To SaleSummaryNoPdSale.Rows.Count - 1

                If String.IsNullOrEmpty(SaleSummaryNoPdSale.Rows(i).Item("DateSale").ToString) Then
                    SaleSummaryNoPdSale.Rows(i).Item("LastDate") = "ไม่ระบุ  "
                Else

                    SaleSummaryNoPdSale.Rows(i).Item("LastDate") = Format(SaleSummaryNoPdSale.Rows(i).Item("DateSale"), "dd/MM/yyyy")
                End If
            Next
            para_ReportType = Me.rdbCusNoSale.Text

        ElseIf Me.rdbTsp.Checked = True Then 'ตามการขนส่ง'

            sCommand.CommandText = " SELECT ts.TspTypeName As Transport, DocRef,DocCode, Format(mt.DateSaleD, 'd', 'th' ) As DateSale, DatePay, mt.PartnerNameBill As CusName, ap.ApName," & vbNewLine & _
                                   " pv.PvName As ProvinceName, TotalNet, HR_Seeds.hr.employeename(mt.idPsSale,8003) As PsSale    " & vbNewLine & _
                                   " FROM SmSaleMt As mt  " & vbNewLine & _
                                   " LEFT JOIN dTspType ts ON mt.idTS = ts.idTspType" & vbNewLine & _
                                   " LEFT OUTER JOIN dPartner pn ON mt.idPartner = pn.idPartner" & vbNewLine & _
                                   " LEFT JOIN dAp ap ON pn.pidAp = ap.idAp" & vbNewLine & _
                                   " LEFT JOIN dProvinceFixSale As pv ON pn.pidPv = pv.idPv" & vbNewLine & _
                                   " WHERE mt.idComp = " & cmbGroupComp.SelectedValue & vWhereMt & " ORDER BY CusName ASC "
            sAdapter.Fill(SaleRptDt)

            For i As Integer = 0 To SaleRptDt.Rows.Count - 1
                SaleRptDt.Rows(i).Item("DatePay") = ksbStringToDate(SaleRptDt.Rows(i).Item("DatePay"))
            Next

        End If

        If SaleRptDt.Rows.Count = 0 And Me.rdbCusNoSale.Checked = False Then
            'SplashScreenManager.CloseForm(False)
            mdLoadCommitt()
            MessageBox.Show("ไม่มีรายการขายที่สามารถแสดงรายงานได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            SaleRptDt.Clear()
            Exit Sub
        Else
            Dim vFrm As New FrmReportView
            If Me.rdbDaily.Checked = True Then 'รายงานประจำวัน
                Dim vRpt As New crpSaleDaily
                vRpt.SetDataSource(SaleRptDt)
                vRpt.SetParameterValue(vRpt.Parameter_DateS.ParameterFieldName, para_DateS)
                vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, cmbGroupComp.Text)
                vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, sPsName)
                vRpt.SetParameterValue(vRpt.Parameter_ptHeadCol1.ParameterFieldName, para_HeadCol1)
                vRpt.SetParameterValue(vRpt.Parameter_ptHeadCol2.ParameterFieldName, para_HeadCol2)
                vRpt.SetParameterValue(vRpt.Parameter_ptHeadCol3.ParameterFieldName, para_HeadCol3)
                vRpt.SetParameterValue(vRpt.Parameter_ptReportType.ParameterFieldName, para_ReportType)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()

            ElseIf Me.rdbDoc.Checked = True Then 'รายงานตามเอกสาร
                Dim vRpt As New crpSaleDocCode
                vRpt.SetDataSource(SaleRptMt)
                vRpt.Subreports("subReport").Database.Tables("SaleRptDt").SetDataSource(SaleRptDt)
                vRpt.SetParameterValue(vRpt.Parameter_DateS.ParameterFieldName, para_DateS)
                vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, cmbGroupComp.Text)
                vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, sPsName)
                vRpt.SetParameterValue(vRpt.Parameter_ptHeadCol1.ParameterFieldName, para_HeadCol1)
                vRpt.SetParameterValue(vRpt.Parameter_ptHeadCol2.ParameterFieldName, para_HeadCol2)
                vRpt.SetParameterValue(vRpt.Parameter_TotalPrice.ParameterFieldName, para_TotalPrice)
                vRpt.SetParameterValue(vRpt.Parameter_TotalDis.ParameterFieldName, para_TotalDis)
                vRpt.SetParameterValue(vRpt.Parameter_TotalAmt.ParameterFieldName, para_TotalAmt)
                vRpt.SetParameterValue(vRpt.Parameter_ptReportType.ParameterFieldName, para_ReportType)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()

            ElseIf Me.rdbCusNoSale.Checked = True Then 'ตามรายการลูกค้าที่ไม่มียอดขาย
                Dim vRpt As New crpSaleSummaryNoCusSale
                vRpt.SetDataSource(SaleSummaryNoPdSale)
                vRpt.SetParameterValue(vRpt.Parameter_DateS.ParameterFieldName, para_DateS)
                vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, cmbGroupComp.Text)
                vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, sPsName)
                vRpt.SetParameterValue(vRpt.Parameter_ptReportType.ParameterFieldName, para_ReportType)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()

            ElseIf Me.rdbTsp.Checked = True Then 'ตามประเภทการขนส่ง

                Dim vRpt As New crpSaleGroupByTspNew
                vRpt.SetDataSource(SaleRptDt)
                vRpt.SetParameterValue(vRpt.Parameter_DateS.ParameterFieldName, para_DateS)
                vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, cmbGroupComp.Text)
                vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, sPsName)
                vRpt.SetParameterValue(vRpt.Parameter_ptReportType.ParameterFieldName, para_ReportType)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
            Else
                Dim vRpt As New crpSaleCusPdPsSale 'รายงานตามเจ้าหน้าที่ขาย, ลูกค้า, สินค้า
                vRpt.SetDataSource(SaleRptDt)
                vRpt.SetParameterValue(vRpt.Parameter_DateS.ParameterFieldName, para_DateS)
                vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, cmbGroupComp.Text)
                vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, sPsName)
                vRpt.SetParameterValue(vRpt.Parameter_ptHeadCol1.ParameterFieldName, para_HeadCol1)
                vRpt.SetParameterValue(vRpt.Parameter_ptHeadCol2.ParameterFieldName, para_HeadCol2)
                vRpt.SetParameterValue(vRpt.Parameter_ptReportType.ParameterFieldName, para_ReportType)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
            End If
        End If
        mdLoadCommitt()
        'SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub cmbDocType()
        mdCnOpen()
        Dim sDt As New DataTable
        'AND SaleCode <> 'XY'
        sCommand.CommandText = "Select idSaleCode, SaleCode From SmSaleDocCode WHERE idSaleCode IN (SELECT idSaleCode From " & _
                               "SmSaleCodeComp WHERE idComp = " & cmbGroupComp.SelectedValue & ")"
        sAdapter.Fill(sDt)
        With ccbtDocType
            .Properties.DisplayMember = "SaleCode"
            .Properties.ValueMember = "idSaleCode"
            .Properties.DataSource = sDt
        End With
    End Sub

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelect, cmbGroupComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblCus.Tag = vFrm.idCus
            lblCus.Text = vFrm.CusName
        End If
    End Sub

    Private Sub btnPsSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPsSale.Click
        Dim vFrm As New frmPsSaleSelect(frmPsSaleSelect.eProcess.eNormal, Nothing, "", "", 1, cmbGroupComp.SelectedValue)
        'vFrm.GetidComp(cmbGroupComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblPsSale.Tag = vFrm.idPs
            lblPsSale.Text = vFrm.SaleName
        End If
    End Sub

    Private Sub btnPd_Click(sender As Object, e As EventArgs) Handles btnPd.Click
        Dim vFrm As New frmAllInvSelect(frmAllInvSelect.eProcess.eAll, cmbGroupComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblPdName.Tag = vFrm.sdt1.Rows(0).Item("idInvMain")
            lblPdName.Text = vFrm.sdt1.Rows(0).Item("InvName")
        End If
    End Sub

    'Private Sub ChkSalefReg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.CheckRegion.Checked = True Then
    '        Me.cmbSaleReg.Enabled = True
    '    Else
    '        Me.cmbSaleReg.Enabled = False
    '    End If
    'End Sub


    Private Sub rdbMonth_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdbMonth.CheckedChanged
        If Me.rdbMonth.Checked = True Then
            Me.dtpMonth.Enabled = True
        Else
            Me.dtpMonth.Enabled = False
        End If
    End Sub

    Private Sub rdbYear_CheckedChanged(sender As Object, e As EventArgs) Handles rdbYear.CheckedChanged
        If Me.rdbYear.Checked = True Then
            Me.dtpYear.Enabled = True
        Else
            Me.dtpYear.Enabled = False
        End If
    End Sub

    Private Sub rdbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDate.CheckedChanged
        If Me.rdbDate.Checked = True Then
            Me.dtpSaleS.Enabled = True
            Me.dtpSaleE.Enabled = True
        Else
            Me.dtpSaleS.Enabled = False
            Me.dtpSaleE.Enabled = False
        End If
    End Sub

    Private Sub CheckDocType_CheckedChanged(sender As Object, e As EventArgs) Handles CheckDocType.CheckedChanged
        If Me.CheckDocType.Checked = True Then
            Me.ccbtDocType.Enabled = True
        Else
            Me.ccbtDocType.Enabled = False
        End If
    End Sub

    Private Sub CheckRefNo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckRefNo.CheckedChanged
        If Me.CheckRefNo.Checked = True Then
            Me.txtRefNo.Enabled = True
            txtRefNo.Focus()
        Else
            Me.txtRefNo.Text = ""
            Me.txtRefNo.Enabled = False
        End If
    End Sub

    Private Sub CheckDocNo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckDocNo.CheckedChanged
        If Me.CheckDocNo.Checked = True Then
            Me.txtDocNo.Enabled = True
            txtDocNo.Focus()
        Else
            Me.txtDocNo.Text = ""
            Me.txtDocNo.Enabled = False
        End If
    End Sub

    Private Sub CheckPdNo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPdNo.CheckedChanged
        If Me.CheckPdNo.Checked = True Then
            Me.txtPdNo.Enabled = True
            txtPdNo.Focus()
        Else
            Me.txtPdNo.Text = ""
            Me.txtPdNo.Enabled = False
        End If
    End Sub

    Private Sub CheckPdName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPdName.CheckedChanged
        If Me.CheckPdName.Checked = True Then
            Me.btnPd.Enabled = True
        Else
            Me.btnPd.Enabled = False
            lblPdName.Text = ""
        End If
    End Sub

    Private Sub ChkCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCus.CheckedChanged
        If Me.CheckCus.Checked = True Then
            Me.btnCustomer.Enabled = True
        Else
            Me.btnCustomer.Enabled = False
            lblCus.Text = ""
        End If
    End Sub

    Private Sub ChkPsSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckPsSale.CheckedChanged
        If Me.CheckPsSale.Checked = True Then
            Me.btnPsSale.Enabled = True
        Else
            Me.btnPsSale.Enabled = False
            lblPsSale.Text = ""
        End If
    End Sub

    Private Sub rdbGen_CheckedChanged(sender As Object, e As EventArgs) Handles CheckGen.CheckedChanged
        If CheckGen.Checked = True Then
            DirectCast(rdbGenPA, RadioButton).Checked = True
            DirectCast(rdbGenPA, RadioButton).Enabled = True
            DirectCast(rdbGenPN, RadioButton).Enabled = True
            DirectCast(rdbGenPC, RadioButton).Enabled = True
        Else
            DirectCast(rdbGenPA, RadioButton).Checked = False
            DirectCast(rdbGenPN, RadioButton).Checked = False
            DirectCast(rdbGenPC, RadioButton).Checked = False
            DirectCast(rdbGenPA, RadioButton).Enabled = False
            DirectCast(rdbGenPN, RadioButton).Enabled = False
            DirectCast(rdbGenPC, RadioButton).Enabled = False

            If Me.CheckGen.Checked = False And Me.CheckOther.Checked = False And Me.CheckMat.Checked = False And Me.ChkTsp.Checked = False Then
                MessageBox.Show("กรุณาระบุประเภทสินค้าอย่างน้อย 1 ประเภท", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.CheckGen.Checked = True
            End If

        End If
    End Sub

    Private Sub CheckOther_CheckedChanged(sender As Object, e As EventArgs) Handles CheckOther.CheckedChanged
        If Me.CheckGen.Checked = False And Me.CheckOther.Checked = False And Me.CheckMat.Checked = False And Me.ChkTsp.Checked = False And cbMeterial.Checked = False Then
            MessageBox.Show("กรุณาระบุประเภทสินค้าอย่างน้อย 1 ประเภท", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.CheckOther.Checked = True
        End If
    End Sub

    Private Sub CheckMat_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMat.CheckedChanged
        If Me.CheckGen.Checked = False And Me.CheckOther.Checked = False And Me.CheckMat.Checked = False And Me.ChkTsp.Checked = False And cbMeterial.Checked = False Then
            MessageBox.Show("กรุณาระบุประเภทสินค้าอย่างน้อย 1 ประเภท", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.CheckMat.Checked = True
        End If
    End Sub

    Private Sub ChkTsp_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTsp.CheckedChanged
        If Me.CheckGen.Checked = False And Me.CheckOther.Checked = False And Me.CheckMat.Checked = False And Me.ChkTsp.Checked = False And cbMeterial.Checked = False Then
            MessageBox.Show("กรุณาระบุประเภทสินค้าอย่างน้อย 1 ประเภท", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.CheckMat.Checked = True
        End If
    End Sub

    Private Sub cbMeterial_CheckedChanged(sender As Object, e As EventArgs) Handles cbMeterial.CheckedChanged
        If Me.CheckGen.Checked = False And Me.CheckOther.Checked = False And Me.CheckMat.Checked = False And Me.ChkTsp.Checked = False And cbMeterial.Checked = False Then
            MessageBox.Show("กรุณาระบุประเภทสินค้าอย่างน้อย 1 ประเภท", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.CheckMat.Checked = True
        End If
    End Sub

    Private Sub rdbCusNoSale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCusNoSale.CheckedChanged
        If Me.rdbCusNoSale.Checked = True Then
            Me.rdbYear.Checked = True
            Me.rdbDate.Enabled = False
            Me.rdbMonth.Enabled = False
            Me.CheckRefNo.Enabled = False
            Me.CheckDocNo.Enabled = False
            Me.CheckPdNo.Enabled = False
            Me.CheckPdName.Enabled = False
            Me.CheckDocType.Enabled = False
            Me.CheckCus.Enabled = False
            Me.CheckPsSale.Enabled = False
            Me.CheckRefNo.Checked = False
            Me.CheckDocNo.Checked = False
            Me.CheckPdNo.Checked = False
            Me.CheckPdName.Checked = False
            Me.CheckDocType.Checked = False
            Me.CheckCus.Checked = False
            Me.CheckPsSale.Checked = False
            Me.GroupBox4.Enabled = False
        Else
            Me.rdbDate.Enabled = True
            Me.rdbMonth.Enabled = True
            Me.CheckRefNo.Enabled = True
            Me.CheckDocNo.Enabled = True
            Me.CheckPdNo.Enabled = True
            Me.CheckPdName.Enabled = True
            Me.CheckDocType.Enabled = True
            Me.CheckCus.Enabled = True
            Me.CheckPsSale.Enabled = True
            Me.GroupBox4.Enabled = True
        End If
    End Sub

    Private Sub chkLotNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkLotNo.CheckedChanged
        If Me.chkLotNo.Checked = True Then
            Me.txtLotNo.Enabled = True
            txtLotNo.Focus()
        Else
            Me.txtLotNo.Text = ""
            Me.txtLotNo.Enabled = False
        End If
    End Sub

    Private Sub btnPsOrder_Click(sender As Object, e As EventArgs) Handles btnPsOrder.Click
        Dim frm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPsOrder.Text = frm.mName
            Me.lblPsOrder.Tag = frm.mId
        End If
    End Sub

    Private Sub cbPsOrder_CheckedChanged(sender As Object, e As EventArgs) Handles cbPsOrder.CheckedChanged
        If Me.cbPsOrder.Checked = True Then
            Me.btnPsOrder.Enabled = True
        Else
            Me.btnPsOrder.Enabled = False
            lblPsOrder.Text = ""
        End If
    End Sub
End Class