Imports DevExpress.XtraSplashScreen
Public Class frmVATSelect
    Dim idSaleS As String
    'Dim SumVAT As Integer
    Dim AddressComp As String = ""
    Dim CompnameEng As String = ""
    Dim CompnameTH As String = ""
    Dim AddressEng As String = ""
    Dim TelComp As String = ""
    Dim FaxComp As String = ""
    Dim TexCode As String = ""
    Dim gidComp As Integer = 0

    Public Sub ShowText(ByVal idSaleShow As String, ByVal idComp As Integer)
        idSaleS = idSaleShow
        gidComp = idComp
    End Sub

    Private Sub frmVATSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        mdCnOpen2()
        sCommand.CommandText = "Select Address_, Tel, Fax, TaxCode, ISNULL(CompNameEng, '') As CompNameEng, CompName," &
                               "ISNULL(AddressEng_, '') As  AddressEng From vCompany Where idComp IN (" & gidComp & ")"
        sAdapter.Fill(dt)

        AddressComp = dt.Rows(0).Item("Address_")
        CompnameEng = dt.Rows(0).Item("CompNameEng")
        AddressEng = dt.Rows(0).Item("AddressEng")
        CompnameTH = dt.Rows(0).Item("CompName")
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
    End Sub

    Private Function getImg(ByVal url As String) As System.Drawing.Image
        Dim MyWebClient As New System.Net.WebClient
        Dim ImageInBytes() As Byte = MyWebClient.DownloadData(url)
        Dim ImageStream As New IO.MemoryStream(ImageInBytes)
        Dim pic As System.Drawing.Image = New System.Drawing.Bitmap(ImageStream)
        Return pic

    End Function


    Private Sub btnPOnoVAT_Click(sender As Object, e As EventArgs) Handles btnPOnoVAT.Click
        If Me.rdbFull.Checked = True Then
            viewPrint(1, 1)
        ElseIf Me.rdbFull9x11.Checked = True Then
            viewPrint(1, 2)
        Else
            PrePrintForm(1)
        End If
    End Sub

    Private Sub btnPObyVAT_Click(sender As Object, e As EventArgs) Handles btnPObyVAT.Click
        If Me.rdbFull.Checked = True Then
            viewPrint(2, 1)
        ElseIf Me.rdbFull9x11.Checked = True Then
            viewPrint(2, 2)
        Else
            PrePrintForm(2)
        End If
    End Sub

    Private Sub btnInclud_Click(sender As Object, e As EventArgs) Handles btnInclud.Click
        If Me.rdbFull.Checked = True Then
            viewPrint(3, 1)
        ElseIf Me.rdbFull9x11.Checked = True Then
            viewPrint(3, 2)
        Else
            PrePrintForm(3)
        End If
    End Sub

    Private Sub viewPrint(ByVal vatType As Integer, ByVal paperType As Integer)

        mdCnOpen()
        'SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        mdLoadShow()
        Dim stSignPsSale As Integer = 0

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
        DeliveryDoc.Columns.Add("DiscountBath", System.Type.GetType("System.Double"))
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

        Dim sDt3 As New DataTable
        sDt3.Clear()
        sCommand.CommandText = "Select m.idSale, m.DateTsD As DateTs, m.DateSaleD As DateSale, " & vbNewLine &
                               "devsk.fncStrDateToDateTime(m.DatePay) As DatePay, m.DocCode, m.DocRef, m.Total, m.DiscountAmout, " & vbNewLine &
                               "m.DiscountPerc, m.TotalNet, m.PartnerNameBill As CusName, m.PsSale, m.PaymentTerms, m.Transport, m.note, " & vbNewLine &
                               "idProduct, d.Amount, d.Price, d.PriceBfDis, ISNULL(d.DiscountPerc,0.00) As DisPerc, ISNULL(d.DiscountBath,0.00) As DiscountBath, " & vbNewLine &
                               "d.ProductName, d.idInvGroup, d.Lotno, d.idUnit, unit.UnitName, '' As PdCode, " & vbNewLine &
                               "c.address, m.AddressS, (CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As Tel, " & vbNewLine &
                               "c.Fax, c.TaxCode, m.idPsSale, m.idPsSet, m.idPsSend, ISNULL(m.idCus,0) As idCus, m.PsRecName, m.TelOfAddrSent, ISNULL(m.stFromS, 1) As stFromS, " & vbNewLine &
                               "(CASE WHEN d.DiscountPerc <> 0 THEN ((d.DiscountPerc*d.PriceBfDis)/100) ELSE d.DiscountBath END) As DisCount, ISNULL(pk.PdPkName3, d.ProductName) As PdPkName3" & vbNewLine &
                               "FROM vSmSaleDtAll d " & vbNewLine &
                               "LEFT OUTER JOIN vSmSaleMt m ON d.idSale = m.idSale " & vbNewLine &
                               "LEFT OUTER JOIN dPartner pn ON m.idPartner = pn.idPartner" & vbNewLine &
                               "LEFT OUTER JOIN dCustomer c ON m.idCus=c.idCus " & vbNewLine &
                               "LEFT JOIN dInvUnit As unit ON d.idUnit = unit.idUnit" & vbNewLine &
                               "LEFT JOIN dInventoryMain inv ON inv.idInvMain = d.idProduct AND inv.idInvGroup = 2" & vbNewLine &
                               "LEFT JOIN vPackingPdSet pk ON inv.idSubType = pk.idPdPk" & vbNewLine &
                               "WHERE m.idSale = " & idSaleS
        sAdapter.Fill(sDt3)

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
            DeliveryDoc.Rows(rc).Item("DiscountPerc") = sDt3.Rows(i).Item("DisCount")
            DeliveryDoc.Rows(rc).Item("TotalNet") = sDt3.Rows(i).Item("TotalNet")
            DeliveryDoc.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
            DeliveryDoc.Rows(rc).Item("PsSale") = sDt3.Rows(i).Item("PsSale")
            DeliveryDoc.Rows(rc).Item("PaymentTerms") = sDt3.Rows(i).Item("PaymentTerms")
            DeliveryDoc.Rows(rc).Item("Transport") = sDt3.Rows(i).Item("Transport")
            'DeliveryDoc.Rows(rc).Item("note") = sDt3.Rows(i).Item("note")
            DeliveryDoc.Rows(rc).Item("idPdPk") = sDt3.Rows(i).Item("idProduct")
            DeliveryDoc.Rows(rc).Item("Amount") = sDt3.Rows(i).Item("Amount")
            DeliveryDoc.Rows(rc).Item("Price") = sDt3.Rows(i).Item("Price")
            DeliveryDoc.Rows(rc).Item("DisPerc") = sDt3.Rows(i).Item("DisCount")
            DeliveryDoc.Rows(rc).Item("DiscountBath") = sDt3.Rows(i).Item("DisCount")

            If sDt3.Rows(i).Item("idInvGroup") = 30 Then 'ค่าขนส่ง
                DeliveryDoc.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("ProductName")
            Else
                If rdbWeight.Checked = True Then
                    DeliveryDoc.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("ProductName") & vbNewLine & "Lot No. : " & sDt3.Rows(i).Item("Lotno")
                ElseIf rdbNoWeight.Checked = True Then
                    DeliveryDoc.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("PdPkName3") & vbNewLine & "Lot No. : " & sDt3.Rows(i).Item("Lotno")
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
        Next

        '-------------------------- Footer Detail -------------------------------'
        If sDt3.Rows(0).Item("stFromS") = "0" Then 'Address row
            DeliveryDoc.Rows.Add() 'empty row
            Dim rowi As Integer = DeliveryDoc.Rows.Count
            DeliveryDoc.Rows.Add()
            If Not IsDBNull(sDt3.Rows(0).Item("PsRecName")) Then
                DeliveryDoc.Rows(rowi).Item("PdPkName") = "ส่ง : " & sDt3.Rows(0).Item("PsRecName")
            Else
                DeliveryDoc.Rows(rowi).Item("PdPkName") = "ส่ง : "
            End If

            DeliveryDoc.Rows.Add()
            DeliveryDoc.Rows(rowi + 1).Item("PdPkName") = sDt3.Rows(0).Item("AddressS")
            DeliveryDoc.Rows.Add()
            If sDt3.Rows(0).Item("TelOfAddrSent") <> "" Then
                DeliveryDoc.Rows(rowi + 2).Item("PdPkName") = "โทร. " & sDt3.Rows(0).Item("TelOfAddrSent")
            Else
                DeliveryDoc.Rows(rowi + 2).Item("PdPkName") = "โทร. - "
            End If
        End If


        If sDt3.Rows(0).Item("note") <> "" Then 'Address row
            Dim strArr() As String
            strArr = sDt3.Rows(0).Item("Note").Split("\")

            DeliveryDoc.Rows.Add() 'empty row
            Dim rowN As Integer = DeliveryDoc.Rows.Count
            DeliveryDoc.Rows.Add()
            DeliveryDoc.Rows(rowN).Item("PdPkName") = "หมายเหตุ : " & strArr(0)

            For ai As Integer = 1 To strArr.Length - 1
                rowN = rowN + 1
                DeliveryDoc.Rows.Add()
                DeliveryDoc.Rows(rowN).Item("PdPkName") = strArr(ai)
            Next
        End If
        '------------------------------ END Footer --------------------------------------'

        Dim URL As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & gidComp & ".jpg"
        Dim client As New System.Net.WebClient
        Dim buffer As Byte()
        Dim pic() As Byte

        Try
            buffer = client.DownloadData(URL)
            Dim stream As New System.IO.MemoryStream(buffer)
            Dim binReader As New IO.BinaryReader(stream)
            pic = binReader.ReadBytes(stream.Length)
            For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                DeliveryDoc.Rows(i).Item("picComp") = pic
            Next
        Catch ex As Exception
            ' Noimage
        End Try

        If gidComp = 11 Then 'siamAdvanceHost
            '---sign PsSale Pic---'
            Dim URL2 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & DeliveryDoc.Rows(0).Item("idPsSale") & ".png"
            'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
            Try
                buffer = client.DownloadData(URL2)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                For i As Integer = 0 To DeliveryDoc.Rows.Count - 1
                    DeliveryDoc.Rows(i).Item("picSignPsSale") = pic
                Next
            Catch ex As Exception
                stSignPsSale = 1
                'Noimage
            End Try
        Else
            stSignPsSale = 1 'Noimage
        End If



        Dim RegionDt As New DataTable
        RegionDt.Clear()
        sCommand.CommandText = "Select r.RegionName, ps.idPsSale" & vbNewLine &
                                "From SmRegionDComp r" & vbNewLine &
                                "Left Join SmMkCusPs p ON p.idRegionC = r.idRegion" & vbNewLine &
                                "Left Join SmRegionPsSaleComp ps ON ps.idRegionC = r.idRegion " & vbNewLine &
                                "WHERE ps.idComp = " & gidComp & vbNewLine &
                                "And p.idCus = " & DeliveryDoc.Rows(0).Item("idCus") & vbNewLine &
                                "AND ps.idPsSale = " & DeliveryDoc.Rows(0).Item("idPsSale")

        'sCommand.CommandText = "Select r.RegionName, s.idPsSale  " & vbNewLine & _
        '                       "FROM SmRegionSaleSet As s  " & vbNewLine & _
        '                       "LEFT OUTER JOIN SmRegionD As r On s.idRegion = r.idRegion " & vbNewLine & _
        '                       "Where s.idPsSale = '" & DeliveryDoc.Rows(0).Item("idPsSale") & "'"
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
            DeliveryDoc.Rows(i).Item("RegianName") = Regionlist
        Next

        Select Case paperType
            Case 1 'A4
                Dim vRpt As New crpInvoice
                vRpt.SetDataSource(DeliveryDoc)
                vRpt.SetParameterValue(vRpt.Parameter_idSale.ParameterFieldName, idSaleS)
                vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, CompnameTH)
                vRpt.SetParameterValue(vRpt.Parameter_CompNameEng.ParameterFieldName, CompnameEng)
                vRpt.SetParameterValue(vRpt.Parameter_AddressCompEng.ParameterFieldName, AddressEng)
                vRpt.SetParameterValue(vRpt.Parameter_AddressComp.ParameterFieldName, AddressComp)
                vRpt.SetParameterValue(vRpt.Parameter_CompTel.ParameterFieldName, TelComp)
                vRpt.SetParameterValue(vRpt.Parameter_CompFax.ParameterFieldName, FaxComp)
                vRpt.SetParameterValue(vRpt.Parameter_TaxCode.ParameterFieldName, TexCode)
                vRpt.SetParameterValue(vRpt.Parameter_stSignPsSale.ParameterFieldName, stSignPsSale)
                vRpt.SetParameterValue(vRpt.Parameter_ptVATType.ParameterFieldName, vatType.ToString)

                '--show from cystalreport--'
                Dim vFrmRpt As New FrmReportView
                vFrmRpt.crView.ReportSource = vRpt
                vFrmRpt.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
                vFrmRpt.crView.ShowExportButton = False
                vFrmRpt.crView.ShowGroupTreeButton = False
                vFrmRpt.Show()
            Case 2 '9x11
                Dim vRpt As New crpInvoice9x11
                vRpt.SetDataSource(DeliveryDoc)
                vRpt.SetParameterValue(vRpt.Parameter_idSale.ParameterFieldName, idSaleS)
                vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, CompnameTH)
                vRpt.SetParameterValue(vRpt.Parameter_CompNameEng.ParameterFieldName, CompnameEng)
                vRpt.SetParameterValue(vRpt.Parameter_AddressCompEng.ParameterFieldName, AddressEng)
                vRpt.SetParameterValue(vRpt.Parameter_AddressComp.ParameterFieldName, AddressComp)
                vRpt.SetParameterValue(vRpt.Parameter_CompTel.ParameterFieldName, TelComp)
                vRpt.SetParameterValue(vRpt.Parameter_CompFax.ParameterFieldName, FaxComp)
                vRpt.SetParameterValue(vRpt.Parameter_TaxCode.ParameterFieldName, TexCode)
                vRpt.SetParameterValue(vRpt.Parameter_stSignPsSale.ParameterFieldName, stSignPsSale)
                vRpt.SetParameterValue(vRpt.Parameter_ptVATType.ParameterFieldName, vatType.ToString)

                '--show from cystalreport--'
                Dim vFrmRpt As New FrmReportView
                vFrmRpt.crView.ReportSource = vRpt
                vFrmRpt.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
                vFrmRpt.crView.ShowExportButton = False
                vFrmRpt.crView.ShowGroupTreeButton = False
                vFrmRpt.Show()
        End Select
        mdLoadCommitt()
        'SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub PrePrintForm(ByVal vatType As Integer)
        mdCnOpen()
        mdLoadShow()
        'SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)

        '**** พิมพ์ใบเสร็จ : กระดาษต่อเนื่อง  (Preview)****-

        Dim InvPaperDt As New DataTable
        InvPaperDt.Clear()

        InvPaperDt.Columns.Add("idSale", System.Type.GetType("System.Int32"))
        InvPaperDt.Columns.Add("DocRef", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("DateTs", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("Payment", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("DatePay", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("DateSale", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("PsSaleName", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("RegionName", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("idCus", System.Type.GetType("System.Int32"))
        InvPaperDt.Columns.Add("CusName", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("address", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("Tel", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("Transport", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("idPdPk", System.Type.GetType("System.Int32"))
        InvPaperDt.Columns.Add("PdPkName", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("Amount", System.Type.GetType("System.Int32"))
        InvPaperDt.Columns.Add("Price", System.Type.GetType("System.Double"))
        InvPaperDt.Columns.Add("DiscountPerc", System.Type.GetType("System.Double"))
        InvPaperDt.Columns.Add("DiscountBath", System.Type.GetType("System.Double"))
        InvPaperDt.Columns.Add("PerBox", System.Type.GetType("System.Int32"))
        InvPaperDt.Columns.Add("idPkUnit", System.Type.GetType("System.Int32"))
        InvPaperDt.Columns.Add("idPsSale", System.Type.GetType("System.Int32"))
        InvPaperDt.Columns.Add("AddressS", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("Note", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("idTS", System.Type.GetType("System.Int32"))
        InvPaperDt.Columns.Add("ShortPkUnit", System.Type.GetType("System.String"))
        InvPaperDt.Columns.Add("DiscountAmout", System.Type.GetType("System.Double"))
        InvPaperDt.Columns.Add("DisCountPercAll", System.Type.GetType("System.Double"))
        InvPaperDt.Columns.Add("PriceBfDis", System.Type.GetType("System.Double"))
        InvPaperDt.Columns.Add("PsRecName", System.Type.GetType("System.String"))


        '----- vSmSaleDetail------'
        Dim sDt3 As New DataTable
        sDt3.Clear()
        sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTsD As DateTs, m.DateSaleD As DateSale, " & vbNewLine &
                              "devsk.fncStrDateToDateTime(m.DatePay) As DatePay, m.PaymentTerms As Payment, " & vbNewLine &
                              "ps.namea + ' ' +  '(' + ps.phone1+ ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & vbNewLine &
                              "v.CusNameOwn, v.LastNameOwn,  m.PartnerNameBill As CusName, v.address, " & vbNewLine &
                              "(CASE v.TelOffice WHEN '' THEN v.Mobile1 ELSE v.TelOffice END) As Tel, m.Transport, d.idProduct, " & vbNewLine &
                              "d.ProductName, d.Amount, d.Price, d.idUnit, ISNULL(d.DiscountPerc,0.00) As DiscountPerc, ISNULL(d.DiscountBath,0.00) As DiscountBath," & vbNewLine &
                              "m.idPsSale, v.AddressS, m.Note, m.idTS, unit.UnitShort, m.DiscountAmout, m.DiscountPerc As DisCountPercAll, " & vbNewLine &
                              "d.PriceBfDis, m.PsRecName, m.TelOfAddrSent, ISNULL(m.stFromS, 1) As stFromS, " & vbNewLine &
                              "(CASE WHEN d.DiscountPerc <> 0 THEN ((d.DiscountPerc*d.PriceBfDis)/100) ELSE d.DiscountBath END) As DisCount, ISNULL(pk.PdPkName3, d.ProductName) As PdPkName3" & vbNewLine &
                              "FROM vSmSaleDtAll d " & vbNewLine &
                              "LEFT OUTER JOIN vSmSaleMt m ON d.idSale = m.idSale " & vbNewLine &
                              "LEFT JOIN dPartner pn ON m.idPartner = pn.idPartner " & vbNewLine &
                              "LEFT OUTER JOIN vCustomer v ON pn.idCus = v.idCus " & vbNewLine &
                              "LEFT JOIN dInvUnit As unit ON d.idUnit = unit.idUnit" & vbNewLine &
                              "LEFT JOIN dInventoryMain inv ON inv.idInvMain = d.idProduct AND inv.idInvGroup = 2" & vbNewLine &
                              "LEFT JOIN vPackingPdSet pk ON inv.idSubType = pk.idPdPk" & vbNewLine &
                              "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid WHERE m.idSale = " & idSaleS
        sAdapter.Fill(sDt3)

        For i As Integer = 0 To sDt3.Rows.Count - 1
            Dim rc As Integer = InvPaperDt.Rows.Count
            InvPaperDt.Rows.Add()

            InvPaperDt.Rows(rc).Item("idSale") = sDt3.Rows(i).Item("idSale")
            InvPaperDt.Rows(rc).Item("DocRef") = sDt3.Rows(i).Item("DocRef")
            InvPaperDt.Rows(rc).Item("Payment") = sDt3.Rows(i).Item("Payment")
            InvPaperDt.Rows(rc).Item("DateTs") = Format(sDt3.Rows(i).Item("DateTs"), "dd/MM/yyyy")
            InvPaperDt.Rows(rc).Item("DateSale") = Format(sDt3.Rows(i).Item("DateSale"), "dd/MM/yyyy")
            InvPaperDt.Rows(rc).Item("DatePay") = Format(sDt3.Rows(i).Item("DatePay"), "dd/MM/yyyy")
            InvPaperDt.Rows(rc).Item("PsSaleName") = sDt3.Rows(i).Item("PsSaleName")
            InvPaperDt.Rows(rc).Item("RegionName") = sDt3.Rows(i).Item("RegionName")
            InvPaperDt.Rows(rc).Item("idCus") = sDt3.Rows(i).Item("idCus")
            InvPaperDt.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
            InvPaperDt.Rows(rc).Item("address") = sDt3.Rows(i).Item("address")
            InvPaperDt.Rows(rc).Item("Tel") = sDt3.Rows(i).Item("Tel")
            InvPaperDt.Rows(rc).Item("Transport") = sDt3.Rows(i).Item("Transport")
            InvPaperDt.Rows(rc).Item("idPdPk") = sDt3.Rows(i).Item("idProduct")
            'InvPaperDt.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("ProductName")

            If rdbWeight.Checked = True Then
                InvPaperDt.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("ProductName")
            ElseIf rdbNoWeight.Checked = True Then
                InvPaperDt.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("PdPkName3")
            End If


            InvPaperDt.Rows(rc).Item("Amount") = sDt3.Rows(i).Item("Amount")
            InvPaperDt.Rows(rc).Item("Price") = sDt3.Rows(i).Item("Price")
            InvPaperDt.Rows(rc).Item("DiscountPerc") = sDt3.Rows(i).Item("DisCount")
            InvPaperDt.Rows(rc).Item("DiscountBath") = sDt3.Rows(i).Item("DisCount")
            'InvPaperDt.Rows(rc).Item("PerBox") = sDt3.Rows(i).Item("PerBox")
            InvPaperDt.Rows(rc).Item("idPkUnit") = sDt3.Rows(i).Item("idUnit")
            InvPaperDt.Rows(rc).Item("idPsSale") = sDt3.Rows(i).Item("idPsSale")
            ' InvPaperDt.Rows(rc).Item("AddressS") = sDt3.Rows(i).Item("AddressS")
            ' InvPaperDt.Rows(rc).Item("Note") = sDt3.Rows(i).Item("Note")
            InvPaperDt.Rows(rc).Item("idTS") = sDt3.Rows(i).Item("idTS")
            InvPaperDt.Rows(rc).Item("ShortPkUnit") = sDt3.Rows(i).Item("UnitShort")
            InvPaperDt.Rows(rc).Item("DiscountAmout") = sDt3.Rows(i).Item("DiscountAmout")
            InvPaperDt.Rows(rc).Item("DisCountPercAll") = sDt3.Rows(i).Item("DisCountPercAll")
            InvPaperDt.Rows(rc).Item("PriceBfDis") = sDt3.Rows(i).Item("PriceBfDis")
            'If Not IsDBNull(sDt3.Rows(i).Item("PsRecName")) Then
            '    InvPaperDt.Rows(rc).Item("PsRecName") = sDt3.Rows(i).Item("PsRecName")
            'End If
        Next

        '-------------------------- Footer Detail -------------------------------'

        If sDt3.Rows(0).Item("stFromS") = "0" Then 'Address row
            InvPaperDt.Rows.Add() 'empty row
            Dim rowi As Integer = InvPaperDt.Rows.Count
            InvPaperDt.Rows.Add()
            If Not IsDBNull(sDt3.Rows(0).Item("PsRecName")) Then
                InvPaperDt.Rows(rowi).Item("PdPkName") = "ส่ง : " & sDt3.Rows(0).Item("PsRecName")
            Else
                InvPaperDt.Rows(rowi).Item("PdPkName") = "ส่ง : "
            End If

            InvPaperDt.Rows.Add()
            InvPaperDt.Rows(rowi + 1).Item("PdPkName") = sDt3.Rows(0).Item("AddressS")
            InvPaperDt.Rows.Add()
            If sDt3.Rows(0).Item("TelOfAddrSent") <> "" Then
                InvPaperDt.Rows(rowi + 2).Item("PdPkName") = "โทร. " & sDt3.Rows(0).Item("TelOfAddrSent")
            Else
                InvPaperDt.Rows(rowi + 2).Item("PdPkName") = "โทร. - "
            End If
        End If

        If sDt3.Rows(0).Item("note") <> "" Then 'Address row
            Dim strArr() As String
            strArr = sDt3.Rows(0).Item("Note").Split("\")

            InvPaperDt.Rows.Add() 'empty row
            Dim rowN As Integer = InvPaperDt.Rows.Count
            InvPaperDt.Rows.Add()
            InvPaperDt.Rows(rowN).Item("PdPkName") = "หมายเหตุ : " & strArr(0)

            For ai As Integer = 1 To strArr.Length - 1
                rowN = rowN + 1
                InvPaperDt.Rows.Add()
                InvPaperDt.Rows(rowN).Item("PdPkName") = strArr(ai)
            Next
        End If
        '------------------------------ END Footer --------------------------------------'

        For i As Integer = 0 To InvPaperDt.Rows.Count - 1
            'InvPaperDt.Rows(i).Item("DateTs") = ksbStringToDate(InvPaperDt.Rows(i).Item("DateTs"))
            'InvPaperDt.Rows(i).Item("DateSale") = ksbStringToDate(InvPaperDt.Rows(i).Item("DateSale"))
            'InvPaperDt.Rows(i).Item("DatePay") = ksbStringToDate(InvPaperDt.Rows(i).Item("DatePay"))

            If IsDBNull(InvPaperDt.Rows(i).Item("AddressS")) Then
                InvPaperDt.Rows(i).Item("AddressS") = "-"
            ElseIf InvPaperDt.Rows(i).Item("AddressS") = Nothing Then
                InvPaperDt.Rows(i).Item("AddressS") = "-"
            End If

            If IsDBNull(InvPaperDt.Rows(i).Item("Note")) Then
                InvPaperDt.Rows(i).Item("Note") = "-"
            ElseIf InvPaperDt.Rows(i).Item("Note") = Nothing Then
                InvPaperDt.Rows(i).Item("Note") = "-"
            End If

            If IsDBNull(InvPaperDt.Rows(i).Item("idTS")) Then
                InvPaperDt.Rows(i).Item("Transport") = "-"
            ElseIf InvPaperDt.Rows(i).Item("idTS") = 1 Then
                InvPaperDt.Rows(i).Item("Transport") = "-"
            End If
        Next


        Dim RegionDt As New DataTable
        RegionDt.Clear()
        sCommand.CommandText = "SELECT r.RegionName, s.idPsSale FROM SmRegionSaleSet AS s LEFT OUTER JOIN " & _
                               "SmRegionD AS r ON s.idRegion = r.idRegion Where " & _
                               "s.idPsSale = '" & InvPaperDt.Rows(0).Item("idPsSale") & "'"
        sAdapter.Fill(RegionDt)

        Dim Regionlist As String = ""
        For i As Integer = 0 To RegionDt.Rows.Count - 1
            If i = 0 Then
                Regionlist = RegionDt.Rows(i).Item("RegionName")
            Else
                Regionlist = Regionlist & ", " & RegionDt.Rows(i).Item("RegionName")
            End If
        Next

        For i As Integer = 0 To InvPaperDt.Rows.Count - 1
            InvPaperDt.Rows(i).Item("RegionName") = Regionlist

            If IsDBNull(InvPaperDt.Rows(i).Item("PerBox")) Then
                InvPaperDt.Rows(i).Item("PerBox") = 0
            End If

            'If InvPaperDt.Rows(i).Item("idPkUnit") = 3 Then 'กล่อง
            '    InvPaperDt.Rows(i).Item("Price") = InvPaperDt.Rows(i).Item("Price") * InvPaperDt.Rows(i).Item("PerBox")
            'End If


            If IsDBNull(InvPaperDt.Rows(i).Item("DiscountPerc")) Then
                InvPaperDt.Rows(i).Item("DiscountPerc") = 0
            End If
        Next


        Dim vRpt As New crpReceiptInvoicePaper
        vRpt.SetDataSource(InvPaperDt)
        vRpt.SetParameterValue(vRpt.Parameter_stPayment.ParameterFieldName, 0)
        vRpt.SetParameterValue(vRpt.Parameter_ptVATType.ParameterFieldName, vatType.ToString)

        Dim vFrm As New FrmReportView
        vFrm.crView.ShowGroupTreeButton = False
        vFrm.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        vFrm.crView.ShowExportButton = False
        vFrm.crView.ShowGroupTreeButton = False
        vFrm.crView.ReportSource = vRpt
        vFrm.Show()

        'SplashScreenManager.CloseForm(False)
        mdLoadCommitt()
    End Sub


End Class