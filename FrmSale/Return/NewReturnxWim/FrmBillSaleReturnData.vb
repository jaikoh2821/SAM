Imports DevExpress.XtraPrinting

Public Class FrmBillSaleReturnData
    Dim xProcess As eProcess
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim stLoad As Integer = 0
    Dim CopyMainDt As New DataTable
    Enum eProcess
        eEdit
        eView
        eCancel
    End Enum

    Sub New(ByVal aProcess As eProcess)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess


            Case eProcess.eView
                Me.Text = "ข้อมูลรายการคืนสินค้า"
                rptEdit.Buttons(0).Image = My.Resources.Resources.gv_document_open
                ColEdit.Caption = "ข้อมูล"
                ColDoc.Visible = True
                ColCancel.Visible = False
                btnExcel.Visible = True
            Case eProcess.eEdit
                Me.Text = "แก้ไขบิลรับคืนสินค้า"
                ColCancel.Visible = False
            Case eProcess.eCancel
                ColDoc.Visible = False
                ColEdit.Visible = False

        End Select

        xProcess = aProcess
    End Sub
    Private Sub FrmBillSaleReturnData_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.dtpReturnS.Value = Date.Today
        Me.dtpReturnE.Value = Date.Today
        Me.dtpMonthS.Value = Date.Today
        Me.dtpMonthE.Value = Date.Today
        Me.dtpYear.Value = Date.Today
        setCmbGroupComp(cmbGroupComp)

        stLoad = 1
    End Sub

    Private Sub BindData()


        Dim vWhere As String = ""

        Dim vField As String = ""

        If Me.rdbDateSale.Checked = True Then
            vField = "mt.DateReturnD"
        ElseIf Me.rdbDateTs.Checked = True Then
            vField = "mt.DateTsD"
        End If

        'Date Return
        If Me.rdbDate.Checked = True Then

            Dim firstDate As DateTime = Convert.ToDateTime(dtpReturnS.Value, _cultureEnInfo)
            Dim lastDate As DateTime = Convert.ToDateTime(dtpReturnE.Value, _cultureEnInfo)

            vWhere = vWhere & " AND " & vField & " Between '" & firstDate.ToString("yyyy-MM-dd 00:00:00.000", _cultureEnInfo) & "' " &
                              "And '" & lastDate.ToString("yyyy-MM-dd 23:59:00.000", _cultureEnInfo) & "' "

        ElseIf Me.rdbMonth.Checked = True Then

            Dim sDateS As DateTime = Convert.ToDateTime(dtpMonthS.Value, _cultureEnInfo)
            Dim sMonthS As Integer = sDateS.Month
            Dim sYearS As Integer = sDateS.Year
            Dim sDateE As DateTime = Convert.ToDateTime(dtpMonthE.Value, _cultureEnInfo)
            Dim sMonthE As Integer = sDateE.Month
            Dim sYearE As Integer = sDateE.Year

            vWhere = vWhere & " AND YEAR(" & vField & ") * 100 + MONTH(" & vField & ") " &
                              "BETWEEN " & sYearS & " * 100 + " & sMonthS & " AND " & sYearE & " * 100 + " & sMonthE & ""

        ElseIf Me.rdbYear.Checked = True Then

            Dim sDateY As DateTime = Convert.ToDateTime(dtpYear.Value, _cultureEnInfo)
            Dim sYearY As Integer = sDateY.Year
            vWhere = vWhere & " AND YEAR(" & vField & ") = " & sYearY

        End If

        If cbRtAVxST.Checked = True Then
            vWhere = vWhere & " AND ISNULL(mt.idRtAVxST,0) <> 0"
        Else
            vWhere = vWhere & " AND ISNULL(mt.idRtAVxST,0) = 0"
        End If

        If cbCancel.Checked = False Then
            vWhere = vWhere & "AND mt.idPsCancel Is NULL"
        End If

        Dim ds0 As New DataSet
        Dim MainDt As New DataTable  ' SaleReturnMt
        Dim SubDt As New DataTable  ' SaleReturnDt

        MainDt.Rows.Clear()
        sCommand.CommandText = "Select mt.idPsCancel, p1.PsName As PsCancel, mt.CancelNote, mt.idSaleReturn, CONVERT(Date, mt.DateReturnD) As DateReturn,  " & vbNewLine &
                               "mt.DocNum,  p.PartnerName, IsNULL(ap.ApName, '-') As ApName, ISNULL(pv.PvName, '-' ) As ProvinceName , ISNULL(p2.PsName, '-') as PsSale, mt.Total,  " & vbNewLine &
                               "ca.ReturnCause, mt.idRTDocCode, mt.Note, ConCat(cd.ReturnCode,' ',mt.DocRef) As DocRef, comp.CompCode, mt.idComp, p3.PsName As PsTsName,  " & vbNewLine &
                               "ISNULL(mt.idRtAVxST,0) As idRtAVxST, comp.CompName, mt.idWaitReturn, mt.idPsCancel, mt.CancelNote, p1.PsName As PsCancel" & vbNewLine &
                               "From SmSaleReturnMt mt " & vbNewLine &
                               "LEFT JOIN dPartner p ON mt.idPartner = p.idPartner  " & vbNewLine &
                               "LEFT JOIN dAp ap ON p.pidAp = ap.idAp" & vbNewLine &
                               "LEFT JOIN dProvinceFixSale As pv ON p.pidPv = pv.idPv" & vbNewLine &
                               "LEFT JOIN vPersonxSelect p1 ON mt.idPsCancel = p1.idPs " & vbNewLine &
                               "LEFT JOIN vPersonxSelect p2 ON mt.idPsSale = p2.idPs" & vbNewLine &
                               "LEFT JOIN vPersonxSelect p3 ON mt.idPsTs = p3.idPs" & vbNewLine &
                               "LEFT JOIN SmSaleReturnCause ca ON mt.idRtCause = ca.idRtCause  " & vbNewLine &
                               "LEFT JOIN SmSaleReturnCode  cd ON mt. idRTDocCode = cd.idRTDocCode" & vbNewLine &
                               "LEFT JOIN PchInvAndProject.dbo.dCompany comp ON mt.idComp = comp.idComp" & vbNewLine &
                               " WHERE mt.idComp IN ( " & SIdCompStr & ")" & vbNewLine &
                               vWhere & vbNewLine &
                               " Order by mt.DateReturnD DESC, mt.DocNum DESC"
        sAdapter.Fill(MainDt)

        SubDt.Rows.Clear()

        sCommand.CommandText = "Select dt.idSaleReturnDt, dt.idSaleReturn, dt.idSaleDt, dt.LotNoRT, " & vbNewLine &
                                "inv.InvName, dt.AmountReturn, unit.UnitName, dt.RTValuePerc, dt.RTPrice," & vbNewLine &
                                "(dt.AmountReturn*dt.RTPrice) As Exp, " & vbNewLine &
                                "CASE WHEN mt.idWaitReturn Is Not NULL Then (Select TOP 1 DocRef 
											From SmSaleMt sMt 
											LEFT JOIN SmSaleDtAll sDt ON sMt.idSale = sDt.idSale 
											LEFT JOIN WImWaitReturnDt wDt ON sDt.idSaleDt = wDt.idSaleDt 
											Where wDt.idSaleDt = dt.idSaleDt
                                             AND sMt.idPsCancel is NULL) Else  IsNULL(smt.DocRef,'')  END As DocRef" & vbNewLine &
                                "FROM SmSaleReturnDt dt " & vbNewLine &
                                "LEFT OUTER JOIN SmSaleReturnMt mt ON dt.idSaleReturn = mt.idSaleReturn  " & vbNewLine &
                                "LEFT JOIN dInventoryMain inv ON dt.idInvMain = inv.idInvMain" & vbNewLine &
                                "LEFT JOIN dInvUnit unit ON dt.idUnit = unit.idUnit" & vbNewLine &
                                "LEFT JOIN SmSaleMt smt ON dt.idSale = smt.idSale" & vbNewLine &
                                "WHERE mt.idComp IN ( " & SIdCompStr & ")" & vbNewLine &
                                vWhere & vbNewLine &
                                "Order By dt.No ASC"

        sAdapter.Fill(SubDt)

        CopyMainDt = MainDt
        ds0.Tables.Clear()
        ds0.Tables.Add(MainDt)
        ds0.Tables.Add(SubDt)

        Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idSaleReturn")
        Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idSaleReturn")

        ds0.Relations.Add("รายการคืน", keyColumn, foreignColumn)

        If ds0.Tables(0).Rows.Count <= 0 Then
            MessageBox.Show("ไม่พบข้อมูลรายการคืนสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        GridControl1.DataSource = ds0.Tables(0)
        GridControl1.ForceInitialize()

        GridControl1.LevelTree.Nodes.Add("รายการคืน", GVReturnDt)
        GVReturnDt.ExpandAllGroups()
        SumTotal()
    End Sub
    Sub SumTotal()
        Dim TotalNet As Double = 0.0
        For i As Integer = 0 To CopyMainDt.Rows.Count - 1
            If IsDBNull(CopyMainDt.Rows(i).Item("PsCancel")) = True Then
                TotalNet += CopyMainDt.Rows(i).Item("Total")
            End If
        Next
        txtTotalNet.Text = Format(TotalNet, "#,##0.00##")
    End Sub

    Private Sub GVReturnMt_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVReturnMt.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub GVReturnMt_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVReturnMt.RowClick
        If e.RowHandle < 0 Then
            Exit Sub
        End If

        If Not IsDBNull(GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidCancel)) Then
            MessageBox.Show("ผู้ยกเลิก : " & GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColPsCancel) & vbNewLine &
                            "ยกเลิกสาเหตุ : " & GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColCancelNote), sSystemName)
        End If
    End Sub

    Private Sub GVReturnMt_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVReturnMt.RowCellStyle

        If Not IsDBNull(GVReturnMt.GetRowCellValue(e.RowHandle, ColidCancel)) Then
            e.Appearance.BackColor = Color.Salmon
            e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Strikeout)
        End If
    End Sub



    Private Sub btnShowdata_Click(sender As Object, e As EventArgs) Handles btnShowdata.Click
        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub fnFilterDataOnGrid()
        Dim StrFilter As String = ""

        If chkComp.Checked = True Then
            StrFilter &= " AND [idComp] = " & cmbGroupComp.SelectedValue
        End If

        If ChkCus.Checked = True Then
            StrFilter &= " AND [PartnerName] LIKE '%" & Trim(txtCusName.Text) & "%'"
        End If

        If ChkPsSale.Checked = True Then
            StrFilter &= " AND [PsSale] LIKE '%" & Trim(txtPsSale.Text) & "%'"
        End If

        If chkPsTs.Checked = True Then
            StrFilter &= " AND [PsTsName] LIKE '%" & Trim(txtPsTsName.Text) & "%'"
        End If

        If chkDocCode.Checked = True Then
            StrFilter &= " AND [DocRef] LIKE '%" & Trim(txtDocCode.Text) & "%'"
        End If


        GVReturnMt.ActiveFilterString = " 1=1 " + StrFilter

        Dim TotalNet As Double = 0.0
        For i As Integer = 0 To GVReturnMt.DataRowCount - 1
            If IsDBNull(GVReturnMt.GetDataRow(i).Item("PsCancel")) = True Then
                TotalNet += GVReturnMt.GetDataRow(i).Item("Total")
            End If
        Next
        txtTotalNet.Text = Format(TotalNet, "#,##0.00##")
    End Sub

    Private Sub rdbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDate.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbDate.Checked = True Then
                Me.dtpReturnS.Enabled = True
                Me.dtpReturnE.Enabled = True
                mdCnOpen()
                mdLoadShow()
                BindData()
                mdLoadCommitt()
            Else
                Me.dtpReturnS.Enabled = False
                Me.dtpReturnE.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMonth.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbMonth.Checked = True Then
                Me.dtpMonthS.Enabled = True
                Me.dtpMonthE.Enabled = True
                mdCnOpen()
                mdLoadShow()
                BindData()
                mdLoadCommitt()
            Else
                Me.dtpMonthS.Enabled = False
                Me.dtpMonthE.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbYear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbYear.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbYear.Checked = True Then
                Me.dtpYear.Enabled = True
                mdCnOpen()
                mdLoadShow()
                BindData()
                mdLoadCommitt()
            Else
                Me.dtpYear.Enabled = False
            End If
        End If
    End Sub


    Private Sub ChkCus_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCus.CheckedChanged
        If stLoad = 1 Then
            If ChkCus.Checked = True Then
                txtCusName.Enabled = True
                txtCusName.Focus()
            Else
                txtCusName.Enabled = False
                txtCusName.Text = ""
            End If

            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub chkComp_CheckedChanged(sender As Object, e As EventArgs) Handles chkComp.CheckedChanged
        If stLoad = 1 Then
            If chkComp.Checked = True Then
                cmbGroupComp.Enabled = True
            Else
                cmbGroupComp.Enabled = False
            End If

            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub txtCusName_TextChanged(sender As Object, e As EventArgs) Handles txtCusName.TextChanged, txtPsSale.TextChanged, txtPsTsName.TextChanged
        If stLoad = 1 Then
            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub ChkPsSale_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPsSale.CheckedChanged
        If stLoad = 1 Then
            If ChkPsSale.Checked = True Then
                txtPsSale.Enabled = True
                txtPsSale.Focus()
            Else
                txtPsSale.Enabled = False
                txtPsSale.Text = ""
            End If

            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub dtpYear_ValueChanged(sender As Object, e As EventArgs) Handles dtpYear.ValueChanged
        If stLoad = 1 Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub chkPsTs_CheckedChanged(sender As Object, e As EventArgs) Handles chkPsTs.CheckedChanged
        If stLoad = 1 Then
            If chkPsTs.Checked = True Then
                txtPsTsName.Enabled = True
                txtPsTsName.Focus()
            Else
                txtPsTsName.Enabled = False
                txtPsTsName.Text = ""
            End If

            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub chkDocCode_CheckedChanged(sender As Object, e As EventArgs) Handles chkDocCode.CheckedChanged
        If stLoad = 1 Then
            If chkDocCode.Checked = True Then
                txtDocCode.Enabled = True
                txtDocCode.Focus()
            Else
                txtDocCode.Enabled = False
                txtDocCode.Text = ""
            End If

            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub txtDocCode_TextChanged(sender As Object, e As EventArgs) Handles txtDocCode.TextChanged
        If stLoad = 1 Then
            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub rptDoc_Click(sender As Object, e As EventArgs) Handles rptDoc.Click

        Dim AddressComp As String = ""
        Dim CompnameEng As String = ""
        Dim AddressEng As String = ""
        Dim TelComp As String = ""
        Dim FaxComp As String = ""
        Dim TexCode As String = ""
        Dim stSignPsSale As Integer = 0

        Dim dt As New DataTable
        mdCnOpen2()
        sCommand.CommandText = "Select Address_, Tel, Fax, TaxCode, ISNULL(CompNameEng, '') As CompNameEng, " & vbNewLine &
                               "ISNULL(AddressEng_, '') As  AddressEng 
                               From vCompany Where idComp = " & GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, colidComp) & ""
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

        '****พิมพ์ใบรับคืน****-
        Dim DeliveryDoc As New DataTable
        DeliveryDoc.Clear()
        DeliveryDoc.Columns.Add("DateReturn", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("DocCode", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))
        DeliveryDoc.Columns.Add("idCus", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("CusName", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("idPsSale", System.Type.GetType("System.Int32"))
        DeliveryDoc.Columns.Add("PsSale", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("RegionName", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("TaxCode", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("Address", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("Tel", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("Fax", System.Type.GetType("System.String"))


        DeliveryDoc.Columns.Add("InvName", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("InvCode", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("Amount", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("UnitName", System.Type.GetType("System.String"))
        DeliveryDoc.Columns.Add("PriceSale", System.Type.GetType("System.Double"))
        DeliveryDoc.Columns.Add("RTPrice", System.Type.GetType("System.Double"))
        mdCnOpen()


        Dim sDt3 As New DataTable
        sDt3.Clear()

        sCommand.CommandText = "Select inv.InvName, ic.InvCode, AmountReturn, RTPrice, p.PartnerName, dt.LotNoRT, dt.RTPrice, dt.Price As PriceSale,
                                cd.ReturnCode + ' ' + mt.DocRef As DocRef, mt.DateReturnD, unit.UnitName, ps.PsName As PsSale, mt.Note, mt.idPsSale, mt.idCus," & vbNewLine &
                                "c.Fax, c.TaxCode, p.pAddress As Address, p.pTel As Tel" & vbNewLine &
                             "FROM SmSaleReturnDt dt " & vbNewLine &
                             "LEFT JOIN SmSaleReturnMt mt ON dt.idSaleReturn = mt.idSaleReturn " & vbNewLine &
                             "LEFT JOIN dPartner p ON mt.idPartner = p.idPartner" & vbNewLine &
                             "LEFT JOIN dInventoryMain inv ON dt.idInvMain = inv.idInvMain" & vbNewLine &
                             "LEFT JOIN dInvCode ic ON inv.idInvMain = ic.idInvMain" & vbNewLine &
                             "LEFT JOIN dCustomer c ON mt.idCus = c.idCus " &
                             "LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine &
                             "LEFT JOIN vPersonxSelect ps ON mt.idPsSale = ps.idPs" & vbNewLine &
                             "LEFT JOIN SmSaleReturnCode  cd ON mt.idRTDocCode = cd.idRTDocCode" & vbNewLine &
                             "WHERE mt.idSaleReturn = " & GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidSaleRT)
        sAdapter.Fill(sDt3)
        '(CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END)
        For i As Integer = 0 To sDt3.Rows.Count - 1
            Dim rc As Integer = DeliveryDoc.Rows.Count
            DeliveryDoc.Rows.Add()
            DeliveryDoc.Rows(rc).Item("DateReturn") = Format(sDt3.Rows(i).Item("DateReturnD"), "dd/MM/yyyy")
            DeliveryDoc.Rows(rc).Item("DocCode") = sDt3.Rows(i).Item("DocRef")
            DeliveryDoc.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("PartnerName")
            DeliveryDoc.Rows(rc).Item("PsSale") = sDt3.Rows(i).Item("PsSale")
            DeliveryDoc.Rows(rc).Item("idCus") = sDt3.Rows(i).Item("idCus")
            DeliveryDoc.Rows(rc).Item("idPsSale") = sDt3.Rows(i).Item("idPsSale")
            DeliveryDoc.Rows(rc).Item("Address") = sDt3.Rows(i).Item("Address")
            DeliveryDoc.Rows(rc).Item("TaxCode") = sDt3.Rows(i).Item("TaxCode")
            DeliveryDoc.Rows(rc).Item("Tel") = sDt3.Rows(i).Item("Tel")
            If sDt3.Rows(i).Item("Fax") = "" Then
                DeliveryDoc.Rows(rc).Item("Fax") = "-"
            Else
                DeliveryDoc.Rows(rc).Item("Fax") = sDt3.Rows(i).Item("Fax")
            End If

            '----Detail
            DeliveryDoc.Rows(rc).Item("InvCode") = sDt3.Rows(i).Item("InvCode")
            DeliveryDoc.Rows(rc).Item("InvName") = sDt3.Rows(i).Item("InvName") & vbNewLine & " Lot No. : " & sDt3.Rows(i).Item("LotNoRT")
            DeliveryDoc.Rows(rc).Item("UnitName") = sDt3.Rows(i).Item("UnitName")
            DeliveryDoc.Rows(rc).Item("Amount") = sDt3.Rows(i).Item("AmountReturn")
            DeliveryDoc.Rows(rc).Item("PriceSale") = sDt3.Rows(i).Item("PriceSale")
            DeliveryDoc.Rows(rc).Item("RTPrice") = sDt3.Rows(i).Item("RTPrice")

        Next


        Dim URL As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, colidComp) & ".jpg"
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


        Dim RegionDt As New DataTable
        RegionDt.Clear()

        sCommand.CommandText = "Select r.RegionName, ps.idPsSale" & vbNewLine &
                                "From SmRegionDComp r" & vbNewLine &
                                "Left Join SmMkCusPs p ON p.idRegionC = r.idRegion" & vbNewLine &
                                "Left Join SmRegionPsSaleComp ps ON ps.idRegionC = r.idRegion " & vbNewLine &
                                "WHERE ps.idComp = " & GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, colidComp) & vbNewLine &
                                "And p.idCus = " & DeliveryDoc.Rows(0).Item("idCus") & vbNewLine &
                                "AND ps.idPsSale = " & DeliveryDoc.Rows(0).Item("idPsSale")


        sAdapter.Fill(RegionDt)
        Dim Regionlist As String = ""
        For i As Integer = 0 To RegionDt.Rows.Count - 1
            If i = 0 Then
                Regionlist = RegionDt.Rows(i).Item("RegionName")
            Else
                Regionlist = Regionlist & ", " & RegionDt.Rows(i).Item("RegionName")
            End If
        Next
        For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
            DeliveryDoc.Rows(i).Item("RegionName") = Regionlist
        Next

        Dim vRpt As New crpSaleReturn
        vRpt.SetDataSource(DeliveryDoc)
        'vRpt.SetParameterValue(vRpt.Parameter_idSale.ParameterFieldName, GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ))
        vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColCompName))
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

    Private Sub btnExecl_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        'If GVReturnMt.DataRowCount = 0 Then
        '    MessageBox.Show("ไม่พบข้อมูลที่สามารถออก Excel ได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'Else
        '    Dim path As String = "ReturnData.xlsx"
        '    GridControl1.ExportToXlsx(path)

        '    ' Open the created XLSX file with the default application.
        '    Process.Start(path)
        'End If
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\ReturnData.xlsx"
        'Dim path As String = "C:\Users\Public\PurchaseData.xlsx"

        'Customize Export options
        Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
        advOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG
        advOptions.SheetName = "RTData_" & Date.Today.ToShortDateString
        GVReturnMt.OptionsPrint.PrintDetails = True
        GVReturnMt.OptionsPrint.ExpandAllDetails = True
        GVReturnMt.Columns(1).Visible = False
        GVReturnMt.Columns(2).Visible = False
        GVReturnMt.Columns(3).Visible = False


        GridControl1.ExportToXlsx(path, advOptions)

        ' Open the created XLSX file with the default application.
        Process.Start(path)


    End Sub


    Private Sub rptEdit_Click(sender As Object, e As EventArgs) Handles rptEdit.Click

        Dim idSaleReturn As Integer = GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidSaleReturn_)

        If xProcess = eProcess.eEdit Then

            If IsDBNull(GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidWaitReturn)) Then
                If GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidRTDocCode) = 1 Then '153
                    Dim vFrm As New frmSlReturnTs(frmSlReturnTs.eProcess.eEdit, idSaleReturn)
                    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        mdCnOpen()
                        mdLoadShow()
                        BindData()
                        mdLoadCommitt()
                    End If
                ElseIf GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidRTDocCode) = 2 Then 'JU
                    Dim vFrm As New frmSlReturnTsJU(frmSlReturnTsJU.eProcess.eEdit, idSaleReturn)
                    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        mdCnOpen()
                        mdLoadShow()
                        BindData()
                        mdLoadCommitt()
                    End If
                ElseIf GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidRTDocCode) = 8 Then '151
                    Dim vFrm As New frmSlReturnTs(frmSlReturnTs.eProcess.eEdit151, idSaleReturn)
                    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        mdCnOpen()
                        mdLoadShow()
                        BindData()
                        mdLoadCommitt()
                    End If
                End If
            Else
                'mdCnOpen()
                'sCommand.CommandText = "SELECT ISNULL([devsk].[WimCheckstUseRecieveWait] (" & GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidSaleReturn_) & " , 3) ,0) As stRec"
                'Dim stRec As Integer = sCommand.ExecuteScalar

                'If stRec = 1 Then
                '    MessageBox.Show("รายการนี้ถูกรับเข้าคลังแล้ว ไม่สามารถแก้ไขได้", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                '    mdLoadCommitt()
                '    Exit Sub
                'Else
                Dim vFrm As New frmCrateSaleRTTs(frmCrateSaleRTTs.eProcess.eEditBill, idSaleReturn)
                    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        mdCnOpen()
                        mdLoadShow()
                        BindData()
                        mdLoadCommitt()
                    End If
                'End If

            End If


        ElseIf xProcess = eProcess.eView Then

            If IsDBNull(GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidWaitReturn)) Then
                If GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidRTDocCode) = 1 Or
                    GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidRTDocCode) = 8 Then '153/151
                    Dim vFrm As New frmSlReturnTs(frmSlReturnTs.eProcess.eviewData, idSaleReturn)
                    vFrm.ShowDialog()
                ElseIf GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidRTDocCode) = 2 Then 'JU
                    Dim vFrm As New frmSlReturnTsJU(frmSlReturnTsJU.eProcess.eviewData, idSaleReturn)
                    vFrm.ShowDialog()
                End If
            Else
                Dim vFrm As New frmCrateSaleRTTs(frmCrateSaleRTTs.eProcess.eViewBill, idSaleReturn)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    mdCnOpen()
                    mdLoadShow()
                    BindData()
                    mdLoadCommitt()
                    End
                End If
            End If
        End If



    End Sub

    Private Sub FrmBillSaleReturnData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()

        stLoad = 1
    End Sub

    Private Sub rptCancel_Click(sender As Object, e As EventArgs) Handles rptCancel.Click
        Dim idSaleReturn As Integer = GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidSaleReturn_)

        If IsDBNull(GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidWaitReturn)) Then
            If GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidRTDocCode) = 1 Or
                GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidRTDocCode) = 8 Then '153/151
                Dim vFrm As New frmSlReturnTs(frmSlReturnTs.eProcess.eCancel, idSaleReturn)
                vFrm.ShowDialog()
            ElseIf GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidRTDocCode) = 2 Then 'JU
                Dim vFrm As New frmSlReturnTsJU(frmSlReturnTsJU.eProcess.eCancel, idSaleReturn)
                vFrm.ShowDialog()
            End If
        Else

            mdCnOpen()
            sCommand.CommandText = "SELECT ISNULL([devsk].[WimCheckstUseRecieveWait] (" & GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, ColidSaleReturn_) & " , 3) ,0) As stRec"
            Dim stRec As Integer = sCommand.ExecuteScalar

            If stRec = 1 Then
                MessageBox.Show("รายการนี้ถูกรับเข้าคลังแล้ว ไม่สามารถแก้ไขได้", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                mdLoadCommitt()
                Exit Sub
            End If

            Dim vFrm As New frmCrateSaleRTTs(frmCrateSaleRTTs.eProcess.eCancelBill, idSaleReturn)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                mdCnOpen()
                mdLoadShow()
                BindData()
                mdLoadCommitt()
            End If
        End If
    End Sub
End Class