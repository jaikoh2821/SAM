Imports System.Drawing.Printing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPrintCont

    Dim stLoad As Integer = 0
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Private Sub frmPrintCont_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setCmbGroupComp(Me.cmbGroupComp)
        cmbDRefCode()

        ' สมมติว่าสร้าง DataTable ไว้เป็นตัวแปรระดับฟอร์ม (Form-level variables)
        Dim dtLeft As New DataTable()   ' สำหรับฝั่งซ้าย (รายการที่ค้นพบ)
        Dim dtRight As New DataTable()  ' สำหรับฝั่งขวา (รายการที่เลือกพิมพ์)

        ' 1. จำลองโครงสร้างคอลัมน์ (ให้ตรงกับงานจริงของคุณ)
        ' คอลัมน์ "เลือก" ฝั่งซ้าย ให้เป็น Boolean เพื่อแสดงเป็น Checkbox
        dtLeft.Columns.Add("Sel", GetType(Boolean))
        dtLeft.Columns.Add("DocRef", GetType(String))
        dtLeft.Columns.Add("TotalNet", GetType(Decimal))
        dtLeft.Columns.Add("idSale", GetType(Integer))

        ' ฝั่งขวาไม่ต้องมี Checkbox ก็ได้ หรือจะมีไว้เผื่อติ๊กออกก็ได้ครับ
        dtRight.Columns.Add("DocRef", GetType(String))
        dtRight.Columns.Add("TotalNet", GetType(Decimal))
        dtRight.Columns.Add("idSale", GetType(Integer))
        ' 2. ผูก DataTable เข้ากับ GridControl
        GCIVList.DataSource = dtLeft
        GCSaleSel.DataSource = dtRight

        stLoad = 1
    End Sub

    Private Sub cmbDRefCode()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idSaleCode, SaleCode " & vbNewLine &
                                "From SmSaleDocCode " & vbNewLine &
                                "WHERE idSaleCode IN (SELECT idSaleCode  " & vbNewLine &
                                                     "From SmSaleCodeComp " & vbNewLine &
                                                     "WHERE idComp = " & cmbGroupComp.SelectedValue & ")" & vbNewLine &
                                "AND stDel Is NULL"
        sAdapter.Fill(sDt)

        With cmbDRCode
            .DisplayMember = "SaleCode"
            .ValueMember = "idSaleCode"
            .DataSource = sDt
        End With

        With cmbDRCode2
            .DisplayMember = "SaleCode"
            .ValueMember = "idSaleCode"
            .DataSource = sDt
        End With

        If sDt.Rows.Count = 0 Then
            MessageBox.Show("บริษัทนี้ยังไม่ได้กำหนดรหัสเอกสาร จึงไม่สามารถพิมพ์เอกสารขายได้" & vbNewLine &
                            "กรุณาแจ้งผู้พัฒนาระบบ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Exit Sub
        End If

    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            cmbDRefCode()

            ClearSearchGrid()
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim stridSale As String = ""
        Dim stWeight As Integer = 0

        If GVSaleSel.DataRowCount = 0 Then
            MessageBox.Show("กรุณาเลือกอย่างน้อย 1 บิลขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            stridSale = ""
            stWeight = 0

            For i As Integer = 0 To GVSaleSel.DataRowCount - 1
                If i = 0 Then
                    stridSale = GVSaleSel.GetRowCellValue(0, "idSale")
                Else
                    stridSale = stridSale & "," & GVSaleSel.GetRowCellValue(i, "idSale")
                End If
            Next

            If rdbWeight.Checked = True Then
                stWeight = 1
            End If
        End If

        'If cbPreview.Checked = True Then

        '    Dim vFrm As New frmPreviewCont(frmPreviewCont.eProcess.ePrintCont, stridSale, stWeight)
        '    vFrm.Show()

        'Else
        '    fnPrintBill(stridSale, stWeight)
        'End If

        Dim stPreview As Integer = 0
        If cbPreview.Checked = True Then
            stPreview = 1
        End If

        Dim vFrm As New frmSelFormCont(frmSelFormCont.eProcess.eSelForm, stridSale, stWeight, stPreview)
        vFrm.Show()

    End Sub

    Private Sub fnPrintBill(ByVal StridSale As String, ByVal gStWeight As Integer)
        mdCnOpen()
        Dim vWhere As String = ""
        Dim ds As New DataSet
        '--------SmSaleMt Part @Header ZONE-----------
        Dim dtHeaderData As New DataTable("dtSmSaleMt") ' DataTable สำหรับ Header
        sCommand.CommandText = "Select m.idSale, m.DateTsD, m.DateSaleD, devsk.fncStrDateToDateTime(m.DatePay) As DatePay, m.idCus, m.idComp," & vbNewLine &
                               "m.DocCode, m.DocRef, r.RegionName, m.Total, m.TotalNet, m.PartnerNameBill, m.PsSale, m.strCredit, m.Transport, m.note, m.idPsSale, " & vbNewLine &
                               "c.address, m.AddressS, (CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As Tel, m.DatePay, " & vbNewLine &
                               "c.Fax, c.TaxCode, m.idPsSale, m.idPsSet, m.idPsSend, ISNULL(m.idCus,0) As idCus, m.PsRecName," & vbNewLine &
                               "m.TelOfAddrSent, ISNULL(m.stFromS, 1) As stFromS" & vbNewLine &
                               "FROM vSmSaleMt m" & vbNewLine &
                               "LEFT JOIN dPartner pn ON m.idPartner = pn.idPartner" & vbNewLine &
                               "LEFT JOIN dCustomer c ON m.idCus = c.idCus " & vbNewLine &
                               "LEFT JOIN SmMkCusPs p ON p.idCus = m.idCus AND p.idComp = m.idComp" & vbNewLine &
                               "LEFT JOIN SmRegionDComp r On r.idRegion = p.idRegionC AND r.idComp = m.idComp" & vbNewLine &
                               "LEFT JOIN SmRegionPsSaleComp ps ON ps.idRegionC = r.idRegion AND ps.idComp = m.idComp AND ps.idPsSale = m.idPsSale" & vbNewLine &
                               "WHERE m.idSale IN (" & StridSale & ")"

        ' Fill ข้อมูลเข้าไปใน dtHeaderData (ตัวแปรชั่วคราว)
        sAdapter.Fill(dtHeaderData) ' <-- เปลี่ยนจาก dtSmSaleMt เป็น dtHeaderData
        dtHeaderData.TableName = "dtSmSaleMt" ' กำหนดชื่อ (ถ้าจำเป็น)

        Dim dtItemData As New DataTable("dtSmSaleDtAll") ' ชื่อต้องตรงกับ Report
        '-----Group By Product And Price
        sCommand.CommandText = "SELECT ROW_NUMBER() OVER(PARTITION BY d.idSale ORDER BY d.ProductName, d.Price DESC) As No, d.idSale, d.idProduct, d.ProductName, d.Price, SUM(d.Amount) AS AmountAllSale, d.Price*SUM(d.Amount) AS TotalDt," & vbNewLine &
                               "ISNULL(unit.UnitShort, unit.UnitName) As UnitName,  unit.UnitName As UnitNameLong," & vbNewLine &
                               "-- รวม LotNo และ Amount โดย FORMAT Amount เป็นทศนิยม 2 ตำแหน่ง" & vbNewLine &
                               "STRING_AGG( d.LotNo + ' (' + FORMAT(d.Amount, 'N2') + ')', ', ') WITHIN GROUP (ORDER BY d.LotNo) AS [LotDetailUsed] ," & vbNewLine &
                               "ISNULL(pk.PdPkName3, d.ProductName) As ProductNoWeight, oMt.DocCode, oMt.DateRequireD, oMt.DocCode As CodeOrder, oMt.DateRequireD As DateOrder" & vbNewLine &
                               "FROM SmSaleDtAll d " & vbNewLine &
                               "LEFT JOIN dInvUnit unit ON d.idUnit = unit.idUnit " & vbNewLine &
                               "LEFT JOIN dInventoryMain inv ON inv.idInvMain = d.idProduct AND inv.idInvGroup = 2" & vbNewLine &
                               "LEFT JOIN vPackingPdSet pk ON inv.idSubType = pk.idPdPk" & vbNewLine &
                               "LEFT JOIN SmSaleOrderDt oDt ON d.idSaleOrderDt = oDt.idSaleOrderDt" & vbNewLine &
                               "LEFT JOIN SmSaleOrderMt oMt ON oDt.idSaleOrder = oMt.idSaleOrder" & vbNewLine &
                               "WHERE d.idSale IN( " & StridSale & ")" & vbNewLine &
                               "GROUP BY d.idSale, d.idProduct, d.ProductName, d.Price, unit.UnitShort, unit.UnitName, pk.PdPkName3, oMt.DocCode, oMt.DateRequireD" & vbNewLine &
                               "Order By d.idSale ASC"

        ' Fill ข้อมูลเข้าไปใน dtItemData (ตัวแปรชั่วคราว)
        sAdapter.Fill(dtItemData)


        If dtHeaderData.Rows(0).Item("stFromS") = "0" Then 'Address row
            dtItemData.Rows.Add() 'empty row
            Dim rowi As Integer = dtItemData.Rows.Count
            dtItemData.Rows.Add()
            If Not IsDBNull(dtItemData.Rows(0).Item("PsRecName")) Then
                dtItemData.Rows(rowi).Item("PdPkName") = "ส่ง : " & dtHeaderData.Rows(0).Item("PsRecName")
            Else
                dtItemData.Rows(rowi).Item("PdPkName") = "ส่ง : "
            End If

            dtItemData.Rows.Add()
            dtItemData.Rows(rowi + 1).Item("PdPkName") = dtHeaderData.Rows(0).Item("AddressS")
            dtItemData.Rows.Add()
            If dtItemData.Rows(0).Item("TelOfAddrSent") <> "" Then
                dtItemData.Rows(rowi + 2).Item("PdPkName") = "โทร. " & dtHeaderData.Rows(0).Item("TelOfAddrSent")
            Else
                dtItemData.Rows(rowi + 2).Item("PdPkName") = "โทร. - "
            End If
        End If
        ' 4. **เพิ่ม DataTable ใหม่** เข้าไปใน DataSet ใหม่
        dtItemData.TableName = "dtSmSaleDtAll" ' กำหนดชื่อ (ถ้าจำเป็น)

        ds.Tables.Add(dtHeaderData)
        ds.Tables.Add(dtItemData)

        ds.Relations.Add(ds.Tables("dtSmSaleMt").Columns("idSale"), ds.Tables("dtSmSaleDtAll").Columns("idSale"))

        Dim vRpt As New crp9x11BlankForm
        vRpt.SetDataSource(ds)
        vRpt.SetParameterValue(vRpt.Parameter_TypProductName.ParameterFieldName, gStWeight)

        vRpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        vRpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter

        ' 2. ดึงค่า Margins มาเซ็ตเป็น 0 เพื่อดึงให้หัวกระดาษขยับขึ้นไปเข้าล็อกฟอร์มเดิม
        Dim margins As CrystalDecisions.Shared.PageMargins = vRpt.PrintOptions.PageMargins
        margins.topMargin = 0       ' บีบขอบบนให้ชิดที่สุดเพื่อแก้ปัญหาหัวกระดาษเลื่อนลง
        margins.bottomMargin = 0
        margins.leftMargin = 0
        margins.rightMargin = 0
        vRpt.PrintOptions.ApplyPageMargins(margins)

        vRpt.PrintToPrinter(1, False, 0, 0)
        MessageBox.Show("กรุณารอระบบพิมพ์สักครู่ !!", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSFindAll_Click(sender As Object, e As EventArgs) Handles btnSFindAll.Click
        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub txtDocRef2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDocRef2.KeyDown, txtDocRef1.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub BindData()
        Dim firstDate As DateTime = Convert.ToDateTime(dtpDateSale1.Value, _cultureEnInfo)
        Dim lastDate As DateTime = Convert.ToDateTime(dtpDateSale2.Value, _cultureEnInfo)

        Dim vWhere As String = ""

        If txtDocRef1.Text.Trim <> "" And txtDocRef2.Text.Trim <> "" Then
            vWhere = "AND m.DocRef Between '" & cmbDRCode.Text & " " & txtDocRef1.Text.Trim & "'" & vbNewLine &
                                                "AND '" & cmbDRCode.Text & " " & txtDocRef2.Text.Trim & "'"
        ElseIf txtDocRef1.Text.Trim <> "" And txtDocRef2.Text.Trim = "" Then
            vWhere = "AND m.DocRef = '" & cmbDRCode.Text & " " & txtDocRef1.Text.Trim & "'"
        End If

        '--------SmSaleMt Part @Header ZONE-----------
        Dim dtSmSaleMt As New DataTable
        sCommand.CommandText = "Select CONVERT(bit,0) As Sel, m.idSale, m.DocRef, m.TotalNet" & vbNewLine &
                               "FROM SmSaleMt m" & vbNewLine &
                               "WHERE m.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                               "AND m.DateSaleD Between '" & firstDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "'" & vbNewLine &
                                                "AND '" & lastDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "'" & vbNewLine &
                              vWhere & vbNewLine &
                               "AND m.idPsCancel Is NULL"

        ' Fill ข้อมูลเข้าไปใน dtHeaderData (ตัวแปรชั่วคราว)
        sAdapter.Fill(dtSmSaleMt) ' <-- เปลี่ยนจาก dtSmSaleMt เป็น dtHeaderData

        If dtSmSaleMt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูลการขายที่เลือก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            GCIVList.DataSource = dtSmSaleMt
        End If
    End Sub

    Private Sub GVIVList_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVIVList.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub GVSaleSel_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVSaleSel.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNo" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    ' Event ตอนที่เปิดฉากคลิกเลือกในคอลัมน์ Checkbox
    Private Sub GVIVList_ShownEditor(sender As Object, e As EventArgs) Handles GVIVList.ShownEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)

        ' เช็กว่ากำลังคลิกที่คอลัมน์เลือกใช่ไหม (เปลี่ยน "IsSelected" ให้ตรงกับ FieldName จริงของคุณ)
        If view.FocusedColumn.FieldName = "Sel" AndAlso TypeOf view.ActiveEditor Is DevExpress.XtraEditors.CheckEdit Then
            Dim edit As DevExpress.XtraEditors.CheckEdit = CType(view.ActiveEditor, DevExpress.XtraEditors.CheckEdit)

            ' ลบ Event เก่าออกก่อนเพื่อกันมันซ้อนกัน (เคล็ดลับความปลอดภัย)
            RemoveHandler edit.EditValueChanged, AddressOf CheckEdit_EditValueChanged
            ' ผูก Event ใหม่เข้าไป
            AddHandler edit.EditValueChanged, AddressOf CheckEdit_EditValueChanged
        End If
    End Sub

    Private Sub CheckEdit_EditValueChanged(sender As Object, e As EventArgs)
        ' 1. สั่งให้บันทึกค่าลง DataTable ฝั่งซ้ายทันทีเรียลไทม์
        GVIVList.PostEditor()

        ' 2. ดึงข้อมูลของแถวปัจจุบันที่เพิ่งติ๊ก
        Dim sourceRow As DataRow = GVIVList.GetFocusedDataRow()
        If sourceRow IsNot Nothing Then

            ' ดึงชื่อฟิลด์ (เปลี่ยน "DocNo" และ "TotalAmount" ให้ตรงกับของจริงนะครับ)
            Dim DocRef As String = sourceRow("DocRef").ToString()
            Dim isChecked As Boolean = Convert.ToBoolean(sourceRow("Sel"))

            ' ดึง DataTable ฝั่งขวาออกมารอจัดการ
            Dim dtRight As DataTable = CType(GCSaleSel.DataSource, DataTable)
            If dtRight Is Nothing Then Exit Sub

            If isChecked Then
                ' --- กรณีติ๊กถูก -> เอาไปโผล่ฝั่งขวาทันที ---
                Dim foundRows As DataRow() = dtRight.Select($"DocRef = '{DocRef}'")
                If foundRows.Length = 0 Then
                    Dim newRow As DataRow = dtRight.NewRow()
                    newRow("DocRef") = sourceRow("DocRef")
                    newRow("TotalNet") = sourceRow("TotalNet")
                    newRow("idSale") = sourceRow("idSale")
                    dtRight.Rows.Add(newRow)
                End If
            Else
                ' --- กรณีติ๊กออก -> ลบฝั่งขวาทันที ---
                Dim foundRows As DataRow() = dtRight.Select($"DocRef = '{DocRef}'")
                For Each rowToDelete As DataRow In foundRows
                    dtRight.Rows.Remove(rowToDelete)
                Next
            End If

            ' --- โดค้ดเช็กสถานะปุ่ม SelectAll อัตโนมัติ (ใส่ท้ายฟังก์ชันคลิกเรียลไทม์) ---
            Dim dtLeft As DataTable = CType(GCIVList.DataSource, DataTable)
            If dtLeft IsNot Nothing Then
                ' นับจำนวนแถวทั้งหมด เทียบกับ จำนวนแถวที่ถูกติ๊กถูก
                Dim totalRows As Integer = dtLeft.Rows.Count
                Dim checkedRows As Integer = dtLeft.Select("Sel = True").Length

                ' ถอด Event ออกชั่วคราวเพื่อไม่ให้ลูปมันซ้อนกันเองตอนเปลี่ยนค่า
                RemoveHandler chkAll.CheckedChanged, AddressOf chkAll_CheckedChanged

                If totalRows = checkedRows AndAlso totalRows > 0 Then
                    chkAll.Checked = True  ' ติ๊กถูก SelectAll อัตโนมัติถ้า User เลือกครบทุกแถวแล้ว
                Else
                    chkAll.Checked = False ' เอาติ๊กออกถ้ามีบางแถวไม่ได้ถูกเลือก
                End If

                ' ผูก Event กลับเข้าไปเหมือนเดิม
                AddHandler chkAll.CheckedChanged, AddressOf chkAll_CheckedChanged
            End If

            ' 3. สั่ง Refresh ฝั่งขวาทันที หน้าจอจะอัปเดตเรียลไทม์
            GCSaleSel.RefreshDataSource()
        End If
    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        ' 1. ดึง DataTable ของทั้งสองฝั่งออกมารอจัดการ
        Dim dtLeft As DataTable = CType(GCIVList.DataSource, DataTable)
        Dim dtRight As DataTable = CType(GCSaleSel.DataSource, DataTable)

        If dtLeft Is Nothing OrElse dtRight Is Nothing Then Exit Sub

        ' ปิดการ Refresh หน้าจอชั่วคราวขณะลูปใส่ข้อมูล เพื่อความลื่นไหล (ไม่กระตุก)
        GVIVList.BeginUpdate()
        GVSaleSel.BeginUpdate()

        Try
            If chkAll.Checked Then
                ' -------------------------------------------------------
                ' [กรณี USER ติ๊กถูก SelectAll] -> ติ๊กฝั่งซ้ายทั้งหมด + โยนไปฝั่งขวา
                ' -------------------------------------------------------
                For Each row As DataRow In dtLeft.Rows
                    ' สั่งให้ฝั่งซ้ายติ๊กถูก (เปลี่ยน "IsSelected" ให้ตรงกับ FieldName จริงของคุณ)
                    row("Sel") = True

                    Dim DocRef As String = row("DocRef").ToString()
                    ' เช็กก่อนว่าฝั่งขวามีเลขที่เอกสารนี้หรือยัง ถ้ายังไม่มีให้เพิ่มเข้าไป
                    Dim foundRows As DataRow() = dtRight.Select($"DocRef = '{DocRef}'")
                    If foundRows.Length = 0 Then
                        Dim newRow As DataRow = dtRight.NewRow()
                        newRow("DocRef") = row("DocRef")
                        newRow("TotalNet") = row("TotalNet")
                        newRow("idSale") = row("idSale")
                        dtRight.Rows.Add(newRow)
                    End If
                Next
            Else
                ' -------------------------------------------------------
                ' [กรณี USER เอาติ๊กออก SelectAll] -> เอาติ๊กฝั่งซ้ายออก + เคลียร์ฝั่งขวาว่างเปล่า
                ' -------------------------------------------------------
                For Each row As DataRow In dtLeft.Rows
                    row("Sel") = False
                Next

                ' ลบข้อมูลฝั่งขวาออกทั้งหมด
                dtRight.Rows.Clear()
            End If

        Finally
            ' เปิดการทำงานหน้าจอ และสั่งให้อัปเดตข้อมูลแสดงผลทันที
            GVIVList.EndUpdate()
            GVSaleSel.EndUpdate()

            ' บังคับให้ Grid ทั้งสองฝั่งดึงข้อมูลล่าสุดจาก DataTable มาโชว์บนจอ
            GCIVList.RefreshDataSource()
            GCSaleSel.RefreshDataSource()
        End Try
    End Sub

    Private Sub txtDocRef1_TextChanged(sender As Object, e As EventArgs) Handles txtDocRef1.TextChanged, txtDocRef2.TextChanged
        If stLoad = 1 Then
            ClearSearchGrid()
        End If
    End Sub

    Private Sub ClearSearchGrid()
        If GCIVList.DataSource IsNot Nothing Then
            ' 1. สั่งเคลียร์ที่ตัว DataTable (ข้อมูลจะหายไป แต่โครงสร้างตารางและคอลัมน์ยังอยู่)
            Dim dt1 As DataTable = TryCast(GCIVList.DataSource, DataTable)
            If dt1 IsNot Nothing Then dt1.Clear()
        End If

        If GCSaleSel.DataSource IsNot Nothing Then
            ' 2. ทำแบบเดียวกันกับกริลฝั่งขวา
            Dim dt2 As DataTable = TryCast(GCSaleSel.DataSource, DataTable)
            If dt2 IsNot Nothing Then dt2.Clear()
        End If


    End Sub

    Private Sub dtpDateSale1_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateSale1.ValueChanged, dtpDateSale2.ValueChanged
        If stLoad = 1 Then
            ClearSearchGrid()
            txtDocRef1.Text = ""
            txtDocRef2.Text = ""
        End If
    End Sub

    Private Sub cmbDRCode_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbDRCode.SelectedValueChanged, cmbDRCode2.SelectedValueChanged
        If stLoad = 1 Then
            ClearSearchGrid()
            txtDocRef1.Text = ""
            txtDocRef2.Text = ""
        End If
    End Sub
End Class