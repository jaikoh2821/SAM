Public Class frmSlSaleApprove
    Dim idSaleS As String
    Dim stBillTypeS As String
    Dim SumVAT As String
    Dim eEvent As eProcess
    Dim statusP As Integer = 0
    Dim AddressComp As String
    Dim CompnameEng As String
    Dim AddressEng As String
    Dim TelComp As String
    Dim FaxComp As String
    Dim TexCode As String
    Dim stSignPsSale As Integer = 0
    Dim stSignPsSet As Integer = 0
    Dim stSignPsSent As Integer = 0
    Dim stload As Integer = 0


    'Public Sub ShowText(ByVal idSaleShow As String)
    '    idSaleS = idSaleShow
    'End Sub

    Enum eProcess
        eView
        ePrint
        eAccept
        eCheck
        eApprove
    End Enum

    Sub New(ByVal mProcess As eProcess, ByVal idSaleShow As String, ByVal stBillType As String)

        ' This call is required by the Windows Form Designer.
        idSaleS = idSaleShow
        stBillTypeS = stBillType

        Dim dt As New DataTable
        mdCnOpen2()
        sCommand.CommandText = "Select Address_, Tel, Fax, TaxCode, ISNULL(CompNameEng, '') As CompNameEng, " & _
                               "ISNULL(AddressEng, '') As  AddressEng From vCompany Where idComp = " & sIdComp & ""
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
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Select Case mProcess
            Case eProcess.eView
                'nothing
                Me.Text = "เอกสารรายการขายสินค้า"
            Case eProcess.eAccept
                statusP = 1
                Me.Text = "รับทราบรายการขายสินค้า"
            Case eProcess.eCheck
                statusP = 2
                Me.Text = "ตรวจสอบรายการขายสินค้า"
            Case eProcess.eApprove
                statusP = 3
                Me.Text = "อนุมัติรายการขายสินค้า"
            Case eProcess.ePrint
                statusP = 4
                Me.Text = "พิมพ์เอกสารรายการขายสินค้า"
        End Select
        eEvent = mProcess
    End Sub

    Private Sub frmSlSaleApprove_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select PsAccept, DateAccept, PsCheck, DateChcek, PsApp, DateApp, DocRef From vSmSaleMt Where idSale='" & idSaleS & "'"
        sAdapter.Fill(sDt)
        If sDt.Rows.Count <> 0 Then
            If IsDBNull(sDt.Rows(0).Item("PsAccept")) = True Then
                Me.txtPsAccept.Text = ""
            Else
                Me.txtPsAccept.Text = sDt.Rows(0).Item("PsAccept")
            End If

            If IsDBNull(sDt.Rows(0).Item("DateAccept")) = True Then
                Me.txtDateAccept.Text = ""
            Else
                Me.txtDateAccept.Text = ksbStringToDate(sDt.Rows(0).Item("DateAccept"))
            End If

            If IsDBNull(sDt.Rows(0).Item("PsCheck")) = True Then
                Me.txtPsCheck.Text = ""
            Else
                Me.txtPsCheck.Text = sDt.Rows(0).Item("PsCheck")
            End If

            If IsDBNull(sDt.Rows(0).Item("DateChcek")) = True Then
                Me.txtDateCheck.Text = ""
            Else
                Me.txtDateCheck.Text = ksbStringToDate(sDt.Rows(0).Item("DateChcek"))
            End If

            If IsDBNull(sDt.Rows(0).Item("PsApp")) = True Then
                Me.txtPsApprove.Text = ""
            Else
                Me.txtPsApprove.Text = sDt.Rows(0).Item("PsApp")
            End If

            If IsDBNull(sDt.Rows(0).Item("DateApp")) = True Then
                Me.txtDateApprove.Text = ""
            Else
                Me.txtDateApprove.Text = ksbStringToDate(sDt.Rows(0).Item("DateApp"))
            End If
        End If

        If statusP = 1 Then
            Me.btnAccept.Visible = True
            Me.btnCheck.Visible = False
            Me.btnApprove.Visible = False
            Me.rdbAppr.Visible = False
            Me.rdbNoAppr.Visible = False
        ElseIf statusP = 2 Then
            Me.btnCheck.Visible = True
            Me.btnAccept.Visible = False
            Me.btnApprove.Visible = False
            Me.rdbAppr.Visible = False
            Me.rdbNoAppr.Visible = False
        ElseIf statusP = 3 Then
            Me.btnApprove.Visible = True
            Me.btnAccept.Visible = False
            Me.btnCheck.Visible = False
            Me.rdbAppr.Visible = True
            Me.rdbNoAppr.Visible = True
        ElseIf statusP = 0 Or statusP = 4 Then
            If statusP = 4 Then
                Me.CrystalReportViewer1.ShowPrintButton = True
                Me.btnNoVATpaper.Enabled = True
                Me.GroupBox3.Enabled = True
            End If
            stload = 1
            Dim FCode As String = Microsoft.VisualBasic.Left(sDt.Rows(0).Item("DocRef"), 2)
            If FCode = "IV" Or FCode = "OP" Or FCode = "CC" Then
                Me.rdbBorrow.Checked = True
            Else
                Me.rdbBorrow.Visible = False
                Me.rdbBillVat.Checked = True
            End If
        End If
    End Sub

    Private Sub rdbBillVat_CheckedChanged(sender As Object, e As EventArgs) Handles rdbBillVat.CheckedChanged
        If Me.rdbBillVat.Checked = True And stload = 1 Then
            mdCnOpen()
            mdLoadShow()

            stSignPsSale = 0
            stSignPsSet = 0
            stSignPsSent = 0

            '****พิมพ์ใบเสร็จ****-
            'Dim count As Integer = 0
            Dim MyTable As New DataTable
            MyTable.Clear()

            ' If stBillTypeS = "8" Or stBillTypeS = "9" Then  ' ขายสินค้ารวมทุกประเภท
            MyTable.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))
            MyTable.Columns.Add("AddressComp", System.Type.GetType("System.String"))
            MyTable.Columns.Add("TelComp", System.Type.GetType("System.String"))
            MyTable.Columns.Add("FaxComp", System.Type.GetType("System.String"))
            MyTable.Columns.Add("TexCode", System.Type.GetType("System.String"))
            MyTable.Columns.Add("picSignPsSale", System.Type.GetType("System.Byte[]"))
            MyTable.Columns.Add("picSignPsSet", System.Type.GetType("System.Byte[]"))
            MyTable.Columns.Add("picSignPsSent", System.Type.GetType("System.Byte[]"))

            MyTable.Columns.Add("idSale", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("DateTs", System.Type.GetType("System.String"))
            MyTable.Columns.Add("DateSale", System.Type.GetType("System.String"))
            MyTable.Columns.Add("DatePay", System.Type.GetType("System.String"))
            MyTable.Columns.Add("DocCode", System.Type.GetType("System.String"))
            MyTable.Columns.Add("DocRef", System.Type.GetType("System.String"))
            MyTable.Columns.Add("Total", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("DiscountAmout", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("DiscountPerc", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("TotalNet", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("CusName", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PsSent", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PsSale", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PsTs", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PsSet", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PaymentTerms", System.Type.GetType("System.String"))
            MyTable.Columns.Add("Transport", System.Type.GetType("System.String"))
            MyTable.Columns.Add("note", System.Type.GetType("System.String"))
            MyTable.Columns.Add("idPdPk", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("Amount", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("Price", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("DisPerclist", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("PdPkName", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PerBox", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("idPkUnit", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("PkUnitName", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PdCode", System.Type.GetType("System.String"))
            MyTable.Columns.Add("address", System.Type.GetType("System.String"))
            MyTable.Columns.Add("AddressS", System.Type.GetType("System.String"))
            MyTable.Columns.Add("Tel", System.Type.GetType("System.String"))
            MyTable.Columns.Add("Fax", System.Type.GetType("System.String"))
            MyTable.Columns.Add("CusNameCon_", System.Type.GetType("System.String"))
            MyTable.Columns.Add("MobileCon", System.Type.GetType("System.String"))
            MyTable.Columns.Add("idPsSale", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("idPsSet", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("idPsSend", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("idCus", System.Type.GetType("System.Int32"))



            '----- SmSaleDt ------'
            Dim sDt As New DataTable
            sDt.Clear()
            sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
                                   "m.DiscountAmout, m.DiscountPerc, m.TotalNet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
                                   "m.CusName, m.PsSent, m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
                                   "m.note, d.idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, p.PdPkName, " & _
                                   "ISNULL(d.PerBox, 0) As Perbox, d.idPkUnit, u.PkUnitName, p.PdCode, c.address, m.AddressS, " & _
                                   "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
                                   "m.idPsSend, m.idCus FROM SmSaleDt d LEFT OUTER JOIN " & _
                                   "vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                   "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
                                   "ON m.idCus=c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                   "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt)

            For i As Integer = 0 To sDt.Rows.Count - 1
                Dim rc As Integer = MyTable.Rows.Count
                MyTable.Rows.Add()

                MyTable.Rows(rc).Item("idSale") = sDt.Rows(i).Item("idSale")
                MyTable.Rows(rc).Item("DateTs") = sDt.Rows(i).Item("DateTs")
                MyTable.Rows(rc).Item("DateSale") = sDt.Rows(i).Item("DateSale")
                MyTable.Rows(rc).Item("DatePay") = sDt.Rows(i).Item("DatePay")
                MyTable.Rows(rc).Item("DocCode") = sDt.Rows(i).Item("DocCode")
                MyTable.Rows(rc).Item("DocRef") = sDt.Rows(i).Item("DocRef")
                MyTable.Rows(rc).Item("Total") = sDt.Rows(i).Item("Total")
                MyTable.Rows(rc).Item("DiscountAmout") = sDt.Rows(i).Item("DiscountAmout")
                MyTable.Rows(rc).Item("DiscountPerc") = sDt.Rows(i).Item("DiscountPerc")
                MyTable.Rows(rc).Item("TotalNet") = sDt.Rows(i).Item("TotalNet")
                MyTable.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusName")
                'If sDt.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt.Rows(i).Item("CusNameOwn") = "คุณ" & sDt.Rows(i).Item("CusNameOwn")
                '    End If
                '    MyTable.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusNameOwn") & " " & sDt.Rows(i).Item("LastNameOwn") & " (" & sDt.Rows(i).Item("CusName") & ")"
                'Else
                '    MyTable.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusName")
                'End If
                MyTable.Rows(rc).Item("PsSent") = sDt.Rows(i).Item("PsSent")
                MyTable.Rows(rc).Item("PsSale") = sDt.Rows(i).Item("PsSale")
                MyTable.Rows(rc).Item("PsTs") = sDt.Rows(i).Item("PsTs")
                MyTable.Rows(rc).Item("PsSet") = sDt.Rows(i).Item("PsSet")
                MyTable.Rows(rc).Item("PaymentTerms") = sDt.Rows(i).Item("PaymentTerms")
                MyTable.Rows(rc).Item("Transport") = sDt.Rows(i).Item("Transport")
                MyTable.Rows(rc).Item("note") = sDt.Rows(i).Item("note")
                MyTable.Rows(rc).Item("idPdPk") = sDt.Rows(i).Item("idPdPk")
                MyTable.Rows(rc).Item("Amount") = sDt.Rows(i).Item("Amount")
                MyTable.Rows(rc).Item("Price") = sDt.Rows(i).Item("Price")
                MyTable.Rows(rc).Item("DisPerclist") = sDt.Rows(i).Item("DisPerclist")
                MyTable.Rows(rc).Item("PdPkName") = sDt.Rows(i).Item("PdPkName")
                MyTable.Rows(rc).Item("PerBox") = sDt.Rows(i).Item("PerBox")
                MyTable.Rows(rc).Item("idPkUnit") = sDt.Rows(i).Item("idPkUnit")
                MyTable.Rows(rc).Item("PkUnitName") = sDt.Rows(i).Item("PkUnitName")
                MyTable.Rows(rc).Item("PdCode") = sDt.Rows(i).Item("PdCode")
                MyTable.Rows(rc).Item("address") = sDt.Rows(i).Item("address")
                MyTable.Rows(rc).Item("AddressS") = sDt.Rows(i).Item("AddressS")
                MyTable.Rows(rc).Item("Tel") = sDt.Rows(i).Item("Tel")
                MyTable.Rows(rc).Item("Fax") = sDt.Rows(i).Item("Fax")
                MyTable.Rows(rc).Item("CusNameCon_") = sDt.Rows(i).Item("CusNameCon_")
                MyTable.Rows(rc).Item("MobileCon") = sDt.Rows(i).Item("MobileCon")
                MyTable.Rows(rc).Item("idPsSale") = sDt.Rows(i).Item("idPsSale")
                MyTable.Rows(rc).Item("idPsSet") = sDt.Rows(i).Item("idPsSet")
                MyTable.Rows(rc).Item("idPsSend") = sDt.Rows(i).Item("idPsSend")
                MyTable.Rows(rc).Item("idCus") = sDt.Rows(i).Item("idCus")
            Next

            '----- SmSaleDtPd ------'
            Dim sDt2 As New DataTable
            sDt2.Clear()
            sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
                                      "m.DiscountAmout, m.DiscountPerc, m.TotalNet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
                                       "m.CusName, m.PsSent,  m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
                                      "m.note, d.idPdLot As idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, " & _
                                      "d.PdNameBill As PdPkName, 0 As PerBox, d.idUnit As idPkUnit, u.UnitW As PkUnitName, " & _
                                      "'' As PdCode, c.address, m.AddressS, " & _
                                      "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
                                      "m.idPsSend, m.idCus FROM SmSaleDtPd d LEFT OUTER JOIN " & _
                                      "vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                      "PkPdLotStock p ON d.idPdLot = p.idPdLot LEFT OUTER JOIN dCustomer c " & _
                                      "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                      "LEFT OUTER JOIN dUnitW u ON d.idUnit = u.idUnitW WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt2)

            For i As Integer = 0 To sDt2.Rows.Count - 1
                Dim rc As Integer = MyTable.Rows.Count
                MyTable.Rows.Add()

                MyTable.Rows(rc).Item("idSale") = sDt2.Rows(i).Item("idSale")
                MyTable.Rows(rc).Item("DateTs") = sDt2.Rows(i).Item("DateTs")
                MyTable.Rows(rc).Item("DateSale") = sDt2.Rows(i).Item("DateSale")
                MyTable.Rows(rc).Item("DatePay") = sDt2.Rows(i).Item("DatePay")
                MyTable.Rows(rc).Item("DocCode") = sDt2.Rows(i).Item("DocCode")
                MyTable.Rows(rc).Item("DocRef") = sDt2.Rows(i).Item("DocRef")
                MyTable.Rows(rc).Item("Total") = sDt2.Rows(i).Item("Total")
                MyTable.Rows(rc).Item("DiscountAmout") = sDt2.Rows(i).Item("DiscountAmout")
                MyTable.Rows(rc).Item("DiscountPerc") = sDt2.Rows(i).Item("DiscountPerc")
                MyTable.Rows(rc).Item("TotalNet") = sDt2.Rows(i).Item("TotalNet")
                MyTable.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusName")
                'If sDt2.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt2.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt2.Rows(i).Item("CusNameOwn") = "คุณ" & sDt2.Rows(i).Item("CusNameOwn")
                '    End If
                '    MyTable.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusNameOwn") & " " & sDt2.Rows(i).Item("LastNameOwn") & " (" & sDt2.Rows(i).Item("CusName") & ")"
                'Else
                '    MyTable.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusName")
                'End If
                MyTable.Rows(rc).Item("PsSent") = sDt2.Rows(i).Item("PsSent")
                MyTable.Rows(rc).Item("PsSale") = sDt2.Rows(i).Item("PsSale")
                MyTable.Rows(rc).Item("PsTs") = sDt2.Rows(i).Item("PsTs")
                MyTable.Rows(rc).Item("PsSet") = sDt2.Rows(i).Item("PsSet")
                MyTable.Rows(rc).Item("PaymentTerms") = sDt2.Rows(i).Item("PaymentTerms")
                MyTable.Rows(rc).Item("Transport") = sDt2.Rows(i).Item("Transport")
                MyTable.Rows(rc).Item("note") = sDt2.Rows(i).Item("note")
                MyTable.Rows(rc).Item("idPdPk") = sDt2.Rows(i).Item("idPdPk")
                MyTable.Rows(rc).Item("Amount") = sDt2.Rows(i).Item("Amount")
                MyTable.Rows(rc).Item("Price") = sDt2.Rows(i).Item("Price")
                MyTable.Rows(rc).Item("DisPerclist") = sDt2.Rows(i).Item("DisPerclist")
                MyTable.Rows(rc).Item("PdPkName") = sDt2.Rows(i).Item("PdPkName")
                MyTable.Rows(rc).Item("PerBox") = sDt2.Rows(i).Item("PerBox")
                MyTable.Rows(rc).Item("idPkUnit") = sDt2.Rows(i).Item("idPkUnit")
                MyTable.Rows(rc).Item("PkUnitName") = sDt2.Rows(i).Item("PkUnitName")
                MyTable.Rows(rc).Item("PdCode") = sDt2.Rows(i).Item("PdCode")
                MyTable.Rows(rc).Item("address") = sDt2.Rows(i).Item("address")
                MyTable.Rows(rc).Item("AddressS") = sDt2.Rows(i).Item("AddressS")
                MyTable.Rows(rc).Item("Tel") = sDt2.Rows(i).Item("Tel")
                MyTable.Rows(rc).Item("Fax") = sDt2.Rows(i).Item("Fax")
                MyTable.Rows(rc).Item("CusNameCon_") = sDt2.Rows(i).Item("CusNameCon_")
                MyTable.Rows(rc).Item("MobileCon") = sDt2.Rows(i).Item("MobileCon")
                MyTable.Rows(rc).Item("idPsSale") = sDt2.Rows(i).Item("idPsSale")
                MyTable.Rows(rc).Item("idPsSet") = sDt2.Rows(i).Item("idPsSet")
                MyTable.Rows(rc).Item("idPsSend") = sDt2.Rows(i).Item("idPsSend")
                MyTable.Rows(rc).Item("idCus") = sDt2.Rows(i).Item("idCus")
            Next


            '----- SmSaleDtOther ------'
            Dim sDt3 As New DataTable
            sDt3.Clear()
            sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
                                       "m.DiscountAmout, m.DiscountPerc, m.TotalNet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
                                       "m.CusName, m.PsSent,  m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
                                       "m.note, d.idPdo As idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, " & _
                                       "p.Title As PdPkName, ISNULL(d.PerBox, 0) As Perbox, d.idUnit As idPkUnit, u.UnitName As PkUnitName, " & _
                                       "'' As PdCode, c.address, m.AddressS, " & _
                                       "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
                                       "m.idPsSend, m.idCus FROM SmSaleDtOther d LEFT OUTER JOIN " & _
                                       "vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                       "SmPdOtherD p ON d.idPdo = p.idPdo LEFT OUTER JOIN dCustomer c " & _
                                       "ON m.idCus=c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                       "LEFT OUTER JOIN devsk.dInvUnit u ON d.idUnit = u.idUnit WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt3)

            For i As Integer = 0 To sDt3.Rows.Count - 1
                Dim rc As Integer = MyTable.Rows.Count
                MyTable.Rows.Add()

                MyTable.Rows(rc).Item("idSale") = sDt3.Rows(i).Item("idSale")
                MyTable.Rows(rc).Item("DateTs") = sDt3.Rows(i).Item("DateTs")
                MyTable.Rows(rc).Item("DateSale") = sDt3.Rows(i).Item("DateSale")
                MyTable.Rows(rc).Item("DatePay") = sDt3.Rows(i).Item("DatePay")
                MyTable.Rows(rc).Item("DocCode") = sDt3.Rows(i).Item("DocCode")
                MyTable.Rows(rc).Item("DocRef") = sDt3.Rows(i).Item("DocRef")
                MyTable.Rows(rc).Item("Total") = sDt3.Rows(i).Item("Total")
                MyTable.Rows(rc).Item("DiscountAmout") = sDt3.Rows(i).Item("DiscountAmout")
                MyTable.Rows(rc).Item("DiscountPerc") = sDt3.Rows(i).Item("DiscountPerc")
                MyTable.Rows(rc).Item("TotalNet") = sDt3.Rows(i).Item("TotalNet")
                MyTable.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
                'If sDt3.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt3.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt3.Rows(i).Item("CusNameOwn") = "คุณ" & sDt3.Rows(i).Item("CusNameOwn")
                '    End If
                '    MyTable.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusNameOwn") & " " & sDt3.Rows(i).Item("LastNameOwn") & " (" & sDt3.Rows(i).Item("CusName") & ")"
                'Else
                '    MyTable.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
                'End If
                MyTable.Rows(rc).Item("PsSent") = sDt3.Rows(i).Item("PsSent")
                MyTable.Rows(rc).Item("PsSale") = sDt3.Rows(i).Item("PsSale")
                MyTable.Rows(rc).Item("PsTs") = sDt3.Rows(i).Item("PsTs")
                MyTable.Rows(rc).Item("PsSet") = sDt3.Rows(i).Item("PsSet")
                MyTable.Rows(rc).Item("PaymentTerms") = sDt3.Rows(i).Item("PaymentTerms")
                MyTable.Rows(rc).Item("Transport") = sDt3.Rows(i).Item("Transport")
                MyTable.Rows(rc).Item("note") = sDt3.Rows(i).Item("note")
                MyTable.Rows(rc).Item("idPdPk") = sDt3.Rows(i).Item("idPdPk")
                MyTable.Rows(rc).Item("Amount") = sDt3.Rows(i).Item("Amount")
                MyTable.Rows(rc).Item("Price") = sDt3.Rows(i).Item("Price")
                MyTable.Rows(rc).Item("DisPerclist") = sDt3.Rows(i).Item("DisPerclist")
                MyTable.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("PdPkName")
                MyTable.Rows(rc).Item("PerBox") = sDt3.Rows(i).Item("PerBox")
                MyTable.Rows(rc).Item("idPkUnit") = sDt3.Rows(i).Item("idPkUnit")
                MyTable.Rows(rc).Item("PkUnitName") = sDt3.Rows(i).Item("PkUnitName")
                MyTable.Rows(rc).Item("PdCode") = sDt3.Rows(i).Item("PdCode")
                MyTable.Rows(rc).Item("address") = sDt3.Rows(i).Item("address")
                MyTable.Rows(rc).Item("AddressS") = sDt3.Rows(i).Item("AddressS")
                MyTable.Rows(rc).Item("Tel") = sDt3.Rows(i).Item("Tel")
                MyTable.Rows(rc).Item("Fax") = sDt3.Rows(i).Item("Fax")
                MyTable.Rows(rc).Item("CusNameCon_") = sDt3.Rows(i).Item("CusNameCon_")
                MyTable.Rows(rc).Item("MobileCon") = sDt3.Rows(i).Item("MobileCon")
                MyTable.Rows(rc).Item("idPsSale") = sDt3.Rows(i).Item("idPsSale")
                MyTable.Rows(rc).Item("idPsSet") = sDt3.Rows(i).Item("idPsSet")
                MyTable.Rows(rc).Item("idPsSend") = sDt3.Rows(i).Item("idPsSend")
                MyTable.Rows(rc).Item("idCus") = sDt3.Rows(i).Item("idCus")
            Next

            'Else 'Other Bill Sale
            '    If stBillTypeS = "4" Then 'ขายสินค้าอื่นๆ
            '        sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
            '                               "m.DiscountAmout, m.DiscountPerc, m.TotalNet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
            '                               "m.CusName, m.PsSent,  m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
            '                               "m.note, d.idPdo As idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, " & _
            '                               "p.Title As PdPkName, ISNULL(d.PerBox, 0) As Perbox, d.idUnit As idPkUnit, u.UnitName As PkUnitName, " & _
            '                               "'' As PdCode, c.address, c.AddressS, " & _
            '                               "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
            '                               "m.idPsSend, m.idCus FROM vSmSaleMt m LEFT OUTER JOIN " & _
            '                               "SmSaleDtOther d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                               "SmPdOtherD p ON d.idPdo = p.idPdo LEFT OUTER JOIN dCustomer c " & _
            '                               "ON m.idCus=c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                               "LEFT OUTER JOIN PchInvAndProject.dbo.dInvUnit u ON d.idUnit = u.idUnit WHERE m.idSale ='" & idSaleS & "'"
            '    ElseIf stBillTypeS = "7" Then 'ขายเมล็ด
            '        sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
            '                               "m.DiscountAmout, m.DiscountPerc, m.TotalNet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
            '                               "m.CusName, m.PsSent,  m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
            '                               "m.note, d.idPdLot As idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, " & _
            '                               "d.PdNameBill As PdPkName, 0 As PerBox, d.idUnit As idPkUnit, u.UnitW As PkUnitName, " & _
            '                               "'' As PdCode, c.address, c.AddressS, " & _
            '                               "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
            '                               "m.idPsSend, m.idCus FROM vSmSaleMt m LEFT OUTER JOIN " & _
            '                               "SmSaleDtPd d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                               "PkPdLotStock p ON d.idPdLot = p.idPdLot LEFT OUTER JOIN dCustomer c " & _
            '                               "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                               "LEFT OUTER JOIN dUnitW u ON d.idUnit = u.idUnitW WHERE m.idSale ='" & idSaleS & "'"
            '    Else 'Normal Sale
            '        sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
            '                               "m.DiscountAmout, m.DiscountPerc, m.Totalnet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
            '                               "m.CusName, m.PsSent,  m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
            '                               "m.note, d.idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, p.PdPkName, " & _
            '                               "ISNULL(d.PerBox, 0) As Perbox, d.idPkUnit, u.PkUnitName, p.PdCode, c.address, c.AddressS, " & _
            '                               "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
            '                               "m.idPsSend, m.idCus FROM vSmSaleMt m LEFT OUTER JOIN " & _
            '                               "SmSaleDt d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                               "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
            '                               "ON m.idCus=c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                               "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit WHERE m.idSale ='" & idSaleS & "'"
            '    End If

            '    MyTable.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))
            '    MyTable.Columns.Add("AddressComp", System.Type.GetType("System.String"))
            '    MyTable.Columns.Add("TelComp", System.Type.GetType("System.String"))
            '    MyTable.Columns.Add("FaxComp", System.Type.GetType("System.String"))
            '    MyTable.Columns.Add("TexCode", System.Type.GetType("System.String"))
            '    MyTable.Columns.Add("picSignPsSale", System.Type.GetType("System.Byte[]"))
            '    MyTable.Columns.Add("picSignPsSet", System.Type.GetType("System.Byte[]"))
            '    MyTable.Columns.Add("picSignPsSent", System.Type.GetType("System.Byte[]"))
            '    sAdapter.Fill(MyTable)

            'End If


            'Dim URL As String = "http://siamadvancehost.com/spm/Center/Logo/" & sIdComp & ".jpg"
            Dim URL As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & sIdComp & ".jpg"
            Dim client As New System.Net.WebClient
            Dim buffer As Byte()
            Dim pic() As Byte

            Try
                buffer = client.DownloadData(URL)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                For i As Integer = 0 To MyTable.Rows.Count - 1
                    MyTable.Rows(i).Item("picComp") = pic
                Next

            Catch ex As Exception
                ' Noimage
            End Try
            ' Next

            '---sign PsSale Pic---'
            Dim URL2 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & MyTable.Rows(0).Item("idPsSale") & ".png"
            'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/7.png"
            Try
                buffer = client.DownloadData(URL2)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                For i As Integer = 0 To MyTable.Rows.Count - 1
                    MyTable.Rows(i).Item("picSignPsSale") = pic
                Next

            Catch ex As Exception
                stSignPsSale = 1
                ' Noimage
            End Try

            '---sign PsSet Pic---'
            If IsDBNull(MyTable.Rows(0).Item("idPsSet")) Then
                stSignPsSet = 1
            ElseIf MyTable.Rows(0).Item("idPsSet") = Nothing Then
                stSignPsSet = 1
            Else
                Dim URL3 As String = "http://" & sHost & sFtpPathMain & "/images/eSign/" & MyTable.Rows(0).Item("idPsSet") & ".png"
                'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
                Try
                    buffer = client.DownloadData(URL3)
                    Dim stream As New System.IO.MemoryStream(buffer)
                    Dim binReader As New IO.BinaryReader(stream)
                    pic = binReader.ReadBytes(stream.Length)
                    For i As Integer = 0 To MyTable.Rows.Count - 1
                        MyTable.Rows(i).Item("picSignPsSet") = pic
                    Next
                Catch ex As Exception
                    stSignPsSet = 1
                    ' Noimage
                End Try

            End If

            '---sign PsSent Pic---'
            If IsDBNull(MyTable.Rows(0).Item("idPsSend")) Then
                stSignPsSent = 1
            ElseIf MyTable.Rows(0).Item("idPsSend") = Nothing Then
                stSignPsSent = 1
            Else
                Dim URL4 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & MyTable.Rows(0).Item("idPsSend") & ".png"
                'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
                Try
                    buffer = client.DownloadData(URL4)
                    Dim stream As New System.IO.MemoryStream(buffer)
                    Dim binReader As New IO.BinaryReader(stream)
                    pic = binReader.ReadBytes(stream.Length)
                    For i As Integer = 0 To MyTable.Rows.Count - 1
                        MyTable.Rows(i).Item("picSignPsSend") = pic
                    Next

                Catch ex As Exception
                    stSignPsSent = 1
                    ' Noimage
                End Try

            End If

            For i As Integer = 0 To MyTable.Rows.Count - 1
                If Not IsDBNull(MyTable.Rows(i).Item("DateTs")) Then
                    MyTable.Rows(i).Item("DateTs") = ksbStringToDate(MyTable.Rows(i).Item("DateTs"))
                End If
                If Not IsDBNull(MyTable.Rows(i).Item("DateSale")) Then
                    MyTable.Rows(i).Item("DateSale") = ksbStringToDate(MyTable.Rows(i).Item("DateSale"))
                End If
                If Not IsDBNull(MyTable.Rows(i).Item("DatePay")) Then
                    MyTable.Rows(i).Item("DatePay") = ksbStringToDate(MyTable.Rows(i).Item("DatePay"))
                End If

                MyTable.Rows(i).Item("AddressComp") = AddressComp
                MyTable.Rows(i).Item("TelComp") = TelComp
                MyTable.Rows(i).Item("FaxComp") = FaxComp
                MyTable.Rows(i).Item("TexCode") = TexCode

                If Not IsDBNull(MyTable.Rows(i).Item("idPdPk")) Then
                    MyTable.Rows(i).Item("Price") = (MyTable.Rows(i).Item("Price") * 100) / 107
                End If

                If IsDBNull(MyTable.Rows(i).Item("PerBox")) Then
                    MyTable.Rows(i).Item("PerBox") = 1
                End If

                If Not IsDBNull(MyTable.Rows(i).Item("idPkUnit")) Then
                    If MyTable.Rows(i).Item("idPkUnit") = 3 Then
                        MyTable.Rows(i).Item("Price") = MyTable.Rows(i).Item("Price") * MyTable.Rows(i).Item("PerBox")
                    End If
                End If

                If IsDBNull(MyTable.Rows(i).Item("DisPerclist")) Then
                    MyTable.Rows(i).Item("DisPerclist") = 0
                End If
            Next
            SumVAT = 1


            Dim vRpt As New crpReceiptInvoice
            vRpt.SetDataSource(MyTable)

            vRpt.SetParameterValue(vRpt.Parameter_idSale.ParameterFieldName, idSaleS)
            vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, sCompName)
            vRpt.SetParameterValue(vRpt.Parameter_VAT.ParameterFieldName, SumVAT)
            'vRpt.SetParameterValue(vRpt.Parameter_Total_ThChar.ParameterFieldName, "")
            vRpt.SetParameterValue(vRpt.Parameter_PsPrint.ParameterFieldName, sPsName)
            vRpt.SetParameterValue(vRpt.Parameter_stSignPsSale.ParameterFieldName, stSignPsSale)
            vRpt.SetParameterValue(vRpt.Parameter_stSignPsSet.ParameterFieldName, stSignPsSet)
            vRpt.SetParameterValue(vRpt.Parameter_stSignPsSent.ParameterFieldName, stSignPsSent)
            Me.CrystalReportViewer1.ReportSource = vRpt
            If statusP = 4 Then
                Me.CrystalReportViewer1.ShowPrintButton = True
            End If

            mdLoadCommitt()
        End If
    End Sub

    Private Sub rdbBillNoVat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbBillNoVat.CheckedChanged
        If Me.rdbBillNoVat.Checked = True And stload = 1 Then
            mdCnOpen()
            mdLoadShow()

            stSignPsSale = 0
            stSignPsSet = 0
            stSignPsSent = 0
            '****พิมพ์ใบเสร็จ****-
            'Dim count As Integer = 0
            Dim MyTable As New DataTable
            MyTable.Clear()

            ' If stBillTypeS = "8" Or stBillTypeS = "9" Then 'ขายสินค้ารวมทุกประเภท

            MyTable.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))
            MyTable.Columns.Add("AddressComp", System.Type.GetType("System.String"))
            MyTable.Columns.Add("TelComp", System.Type.GetType("System.String"))
            MyTable.Columns.Add("FaxComp", System.Type.GetType("System.String"))
            MyTable.Columns.Add("TexCode", System.Type.GetType("System.String"))
            MyTable.Columns.Add("picSignPsSale", System.Type.GetType("System.Byte[]"))
            MyTable.Columns.Add("picSignPsSet", System.Type.GetType("System.Byte[]"))
            MyTable.Columns.Add("picSignPsSent", System.Type.GetType("System.Byte[]"))

            MyTable.Columns.Add("idSale", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("DateTs", System.Type.GetType("System.String"))
            MyTable.Columns.Add("DateSale", System.Type.GetType("System.String"))
            MyTable.Columns.Add("DatePay", System.Type.GetType("System.String"))
            MyTable.Columns.Add("DocCode", System.Type.GetType("System.String"))
            MyTable.Columns.Add("DocRef", System.Type.GetType("System.String"))
            MyTable.Columns.Add("Total", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("DiscountAmout", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("DiscountPerc", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("TotalNet", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("CusName", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PsSent", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PsSale", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PsTs", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PsSet", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PaymentTerms", System.Type.GetType("System.String"))
            MyTable.Columns.Add("Transport", System.Type.GetType("System.String"))
            MyTable.Columns.Add("note", System.Type.GetType("System.String"))
            MyTable.Columns.Add("idPdPk", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("Amount", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("Price", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("DisPerclist", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("PdPkName", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PerBox", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("idPkUnit", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("PkUnitName", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PdCode", System.Type.GetType("System.String"))
            MyTable.Columns.Add("address", System.Type.GetType("System.String"))
            MyTable.Columns.Add("AddressS", System.Type.GetType("System.String"))
            MyTable.Columns.Add("Tel", System.Type.GetType("System.String"))
            MyTable.Columns.Add("Fax", System.Type.GetType("System.String"))
            MyTable.Columns.Add("CusNameCon_", System.Type.GetType("System.String"))
            MyTable.Columns.Add("MobileCon", System.Type.GetType("System.String"))
            MyTable.Columns.Add("idPsSale", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("idPsSet", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("idPsSend", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("idCus", System.Type.GetType("System.Int32"))


            '----- SmSaleDt ------'
            Dim sDt As New DataTable
            sDt.Clear()
            sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
                                       "m.DiscountAmout, m.DiscountPerc, m.TotalNet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
                                       "m.CusName, m.PsSent,  m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
                                       "m.note, d.idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, p.PdPkName, " & _
                                       "ISNULL(d.PerBox,0) As Perbox, d.idPkUnit, u.PkUnitName, p.PdCode, c.address, m.AddressS, " & _
                                       "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
                                       "m.idPsSend, m.idCus FROM SmSaleDt d LEFT OUTER JOIN " & _
                                       "vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                       "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
                                       "ON m.idCus=c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                       "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt)

            For i As Integer = 0 To sDt.Rows.Count - 1
                Dim rc As Integer = MyTable.Rows.Count
                MyTable.Rows.Add()

                MyTable.Rows(rc).Item("idSale") = sDt.Rows(i).Item("idSale")
                MyTable.Rows(rc).Item("DateTs") = sDt.Rows(i).Item("DateTs")
                MyTable.Rows(rc).Item("DateSale") = sDt.Rows(i).Item("DateSale")
                MyTable.Rows(rc).Item("DatePay") = sDt.Rows(i).Item("DatePay")
                MyTable.Rows(rc).Item("DocCode") = sDt.Rows(i).Item("DocCode")
                MyTable.Rows(rc).Item("DocRef") = sDt.Rows(i).Item("DocRef")
                MyTable.Rows(rc).Item("Total") = sDt.Rows(i).Item("Total")
                MyTable.Rows(rc).Item("DiscountAmout") = sDt.Rows(i).Item("DiscountAmout")
                MyTable.Rows(rc).Item("DiscountPerc") = sDt.Rows(i).Item("DiscountPerc")
                MyTable.Rows(rc).Item("TotalNet") = sDt.Rows(i).Item("TotalNet")
                MyTable.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusName")
                'If sDt.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt.Rows(i).Item("CusNameOwn") = "คุณ" & sDt.Rows(i).Item("CusNameOwn")
                '    End If
                '    MyTable.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusNameOwn") & " " & sDt.Rows(i).Item("LastNameOwn") & " (" & sDt.Rows(i).Item("CusName") & ")"
                'Else
                '    MyTable.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusName")
                'End If
                MyTable.Rows(rc).Item("PsSent") = sDt.Rows(i).Item("PsSent")
                MyTable.Rows(rc).Item("PsSale") = sDt.Rows(i).Item("PsSale")
                MyTable.Rows(rc).Item("PsTs") = sDt.Rows(i).Item("PsTs")
                MyTable.Rows(rc).Item("PsSet") = sDt.Rows(i).Item("PsSet")
                MyTable.Rows(rc).Item("PaymentTerms") = sDt.Rows(i).Item("PaymentTerms")
                MyTable.Rows(rc).Item("Transport") = sDt.Rows(i).Item("Transport")
                MyTable.Rows(rc).Item("note") = sDt.Rows(i).Item("note")
                MyTable.Rows(rc).Item("idPdPk") = sDt.Rows(i).Item("idPdPk")
                MyTable.Rows(rc).Item("Amount") = sDt.Rows(i).Item("Amount")
                MyTable.Rows(rc).Item("Price") = sDt.Rows(i).Item("Price")
                MyTable.Rows(rc).Item("DisPerclist") = sDt.Rows(i).Item("DisPerclist")
                MyTable.Rows(rc).Item("PdPkName") = sDt.Rows(i).Item("PdPkName")
                MyTable.Rows(rc).Item("PerBox") = sDt.Rows(i).Item("PerBox")
                MyTable.Rows(rc).Item("idPkUnit") = sDt.Rows(i).Item("idPkUnit")
                MyTable.Rows(rc).Item("PkUnitName") = sDt.Rows(i).Item("PkUnitName")
                MyTable.Rows(rc).Item("PdCode") = sDt.Rows(i).Item("PdCode")
                MyTable.Rows(rc).Item("address") = sDt.Rows(i).Item("address")
                MyTable.Rows(rc).Item("AddressS") = sDt.Rows(i).Item("AddressS")
                MyTable.Rows(rc).Item("Tel") = sDt.Rows(i).Item("Tel")
                MyTable.Rows(rc).Item("Fax") = sDt.Rows(i).Item("Fax")
                MyTable.Rows(rc).Item("CusNameCon_") = sDt.Rows(i).Item("CusNameCon_")
                MyTable.Rows(rc).Item("MobileCon") = sDt.Rows(i).Item("MobileCon")
                MyTable.Rows(rc).Item("idPsSale") = sDt.Rows(i).Item("idPsSale")
                MyTable.Rows(rc).Item("idPsSet") = sDt.Rows(i).Item("idPsSet")
                MyTable.Rows(rc).Item("idPsSend") = sDt.Rows(i).Item("idPsSend")
                MyTable.Rows(rc).Item("idCus") = sDt.Rows(i).Item("idCus")
            Next

            '----- SmSaleDtPd ------'
            Dim sDt2 As New DataTable
            sDt2.Clear()
            sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
                                      "m.DiscountAmout, m.DiscountPerc, m.TotalNet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
                                       "m.CusName, m.PsSent,  m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
                                      "m.note, d.idPdLot As idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, " & _
                                      "d.PdNameBill As PdPkName, 0 As PerBox, d.idUnit As idPkUnit, u.UnitW As PkUnitName, " & _
                                      "'' As PdCode, c.address, m.AddressS, " & _
                                      "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
                                      "m.idPsSend, m.idCus FROM SmSaleDtPd d LEFT OUTER JOIN " & _
                                      "vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                      "PkPdLotStock p ON d.idPdLot = p.idPdLot LEFT OUTER JOIN dCustomer c " & _
                                      "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                      "LEFT OUTER JOIN dUnitW u ON d.idUnit = u.idUnitW WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt2)

            For i As Integer = 0 To sDt2.Rows.Count - 1
                Dim rc As Integer = MyTable.Rows.Count
                MyTable.Rows.Add()

                MyTable.Rows(rc).Item("idSale") = sDt2.Rows(i).Item("idSale")
                MyTable.Rows(rc).Item("DateTs") = sDt2.Rows(i).Item("DateTs")
                MyTable.Rows(rc).Item("DateSale") = sDt2.Rows(i).Item("DateSale")
                MyTable.Rows(rc).Item("DatePay") = sDt2.Rows(i).Item("DatePay")
                MyTable.Rows(rc).Item("DocCode") = sDt2.Rows(i).Item("DocCode")
                MyTable.Rows(rc).Item("DocRef") = sDt2.Rows(i).Item("DocRef")
                MyTable.Rows(rc).Item("Total") = sDt2.Rows(i).Item("Total")
                MyTable.Rows(rc).Item("DiscountAmout") = sDt2.Rows(i).Item("DiscountAmout")
                MyTable.Rows(rc).Item("DiscountPerc") = sDt2.Rows(i).Item("DiscountPerc")
                MyTable.Rows(rc).Item("TotalNet") = sDt2.Rows(i).Item("TotalNet")
                MyTable.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusName")
                'If sDt2.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt2.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt2.Rows(i).Item("CusNameOwn") = "คุณ" & sDt2.Rows(i).Item("CusNameOwn")
                '    End If
                '    MyTable.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusNameOwn") & " " & sDt2.Rows(i).Item("LastNameOwn") & " (" & sDt2.Rows(i).Item("CusName") & ")"
                'Else
                '    MyTable.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusName")
                'End If
                MyTable.Rows(rc).Item("PsSent") = sDt2.Rows(i).Item("PsSent")
                MyTable.Rows(rc).Item("PsSale") = sDt2.Rows(i).Item("PsSale")
                MyTable.Rows(rc).Item("PsTs") = sDt2.Rows(i).Item("PsTs")
                MyTable.Rows(rc).Item("PsSet") = sDt2.Rows(i).Item("PsSet")
                MyTable.Rows(rc).Item("PaymentTerms") = sDt2.Rows(i).Item("PaymentTerms")
                MyTable.Rows(rc).Item("Transport") = sDt2.Rows(i).Item("Transport")
                MyTable.Rows(rc).Item("note") = sDt2.Rows(i).Item("note")
                MyTable.Rows(rc).Item("idPdPk") = sDt2.Rows(i).Item("idPdPk")
                MyTable.Rows(rc).Item("Amount") = sDt2.Rows(i).Item("Amount")
                MyTable.Rows(rc).Item("Price") = sDt2.Rows(i).Item("Price")
                MyTable.Rows(rc).Item("DisPerclist") = sDt2.Rows(i).Item("DisPerclist")
                MyTable.Rows(rc).Item("PdPkName") = sDt2.Rows(i).Item("PdPkName")
                MyTable.Rows(rc).Item("PerBox") = sDt2.Rows(i).Item("PerBox")
                MyTable.Rows(rc).Item("idPkUnit") = sDt2.Rows(i).Item("idPkUnit")
                MyTable.Rows(rc).Item("PkUnitName") = sDt2.Rows(i).Item("PkUnitName")
                MyTable.Rows(rc).Item("PdCode") = sDt2.Rows(i).Item("PdCode")
                MyTable.Rows(rc).Item("address") = sDt2.Rows(i).Item("address")
                MyTable.Rows(rc).Item("AddressS") = sDt2.Rows(i).Item("AddressS")
                MyTable.Rows(rc).Item("Tel") = sDt2.Rows(i).Item("Tel")
                MyTable.Rows(rc).Item("Fax") = sDt2.Rows(i).Item("Fax")
                MyTable.Rows(rc).Item("CusNameCon_") = sDt2.Rows(i).Item("CusNameCon_")
                MyTable.Rows(rc).Item("MobileCon") = sDt2.Rows(i).Item("MobileCon")
                MyTable.Rows(rc).Item("idPsSale") = sDt2.Rows(i).Item("idPsSale")
                MyTable.Rows(rc).Item("idPsSet") = sDt2.Rows(i).Item("idPsSet")
                MyTable.Rows(rc).Item("idPsSend") = sDt2.Rows(i).Item("idPsSend")
                MyTable.Rows(rc).Item("idCus") = sDt2.Rows(i).Item("idCus")
            Next


            '----- SmSaleDtOther ------'
            Dim sDt3 As New DataTable
            sDt3.Clear()
            sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
                                       "m.DiscountAmout, m.DiscountPerc, m.TotalNet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
                                       "m.CusName, m.PsSent,  m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
                                       "m.note, d.idPdo As idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, " & _
                                       "p.Title As PdPkName, ISNULL(d.PerBox, 0) As Perbox, d.idUnit As idPkUnit, u.UnitName As PkUnitName, " & _
                                       "'' As PdCode, c.address, m.AddressS, " & _
                                       "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
                                       "m.idPsSend, m.idCus FROM SmSaleDtOther d LEFT OUTER JOIN " & _
                                       "vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                       "SmPdOtherD p ON d.idPdo = p.idPdo LEFT OUTER JOIN dCustomer c " & _
                                       "ON m.idCus=c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                       "LEFT OUTER JOIN devsk.dInvUnit u ON d.idUnit = u.idUnit WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt3)

            For i As Integer = 0 To sDt3.Rows.Count - 1
                Dim rc As Integer = MyTable.Rows.Count
                MyTable.Rows.Add()

                MyTable.Rows(rc).Item("idSale") = sDt3.Rows(i).Item("idSale")
                MyTable.Rows(rc).Item("DateTs") = sDt3.Rows(i).Item("DateTs")
                MyTable.Rows(rc).Item("DateSale") = sDt3.Rows(i).Item("DateSale")
                MyTable.Rows(rc).Item("DatePay") = sDt3.Rows(i).Item("DatePay")
                MyTable.Rows(rc).Item("DocCode") = sDt3.Rows(i).Item("DocCode")
                MyTable.Rows(rc).Item("DocRef") = sDt3.Rows(i).Item("DocRef")
                MyTable.Rows(rc).Item("Total") = sDt3.Rows(i).Item("Total")
                MyTable.Rows(rc).Item("DiscountAmout") = sDt3.Rows(i).Item("DiscountAmout")
                MyTable.Rows(rc).Item("DiscountPerc") = sDt3.Rows(i).Item("DiscountPerc")
                MyTable.Rows(rc).Item("TotalNet") = sDt3.Rows(i).Item("TotalNet")
                MyTable.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
                'If sDt3.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt3.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt3.Rows(i).Item("CusNameOwn") = "คุณ" & sDt3.Rows(i).Item("CusNameOwn")
                '    End If
                '    MyTable.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusNameOwn") & " " & sDt3.Rows(i).Item("LastNameOwn") & " (" & sDt3.Rows(i).Item("CusName") & ")"
                'Else
                '    MyTable.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
                'End If
                MyTable.Rows(rc).Item("PsSent") = sDt3.Rows(i).Item("PsSent")
                MyTable.Rows(rc).Item("PsSale") = sDt3.Rows(i).Item("PsSale")
                MyTable.Rows(rc).Item("PsTs") = sDt3.Rows(i).Item("PsTs")
                MyTable.Rows(rc).Item("PsSet") = sDt3.Rows(i).Item("PsSet")
                MyTable.Rows(rc).Item("PaymentTerms") = sDt3.Rows(i).Item("PaymentTerms")
                MyTable.Rows(rc).Item("Transport") = sDt3.Rows(i).Item("Transport")
                MyTable.Rows(rc).Item("note") = sDt3.Rows(i).Item("note")
                MyTable.Rows(rc).Item("idPdPk") = sDt3.Rows(i).Item("idPdPk")
                MyTable.Rows(rc).Item("Amount") = sDt3.Rows(i).Item("Amount")
                MyTable.Rows(rc).Item("Price") = sDt3.Rows(i).Item("Price")
                MyTable.Rows(rc).Item("DisPerclist") = sDt3.Rows(i).Item("DisPerclist")
                MyTable.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("PdPkName")
                MyTable.Rows(rc).Item("PerBox") = sDt3.Rows(i).Item("PerBox")
                MyTable.Rows(rc).Item("idPkUnit") = sDt3.Rows(i).Item("idPkUnit")
                MyTable.Rows(rc).Item("PkUnitName") = sDt3.Rows(i).Item("PkUnitName")
                MyTable.Rows(rc).Item("PdCode") = sDt3.Rows(i).Item("PdCode")
                MyTable.Rows(rc).Item("address") = sDt3.Rows(i).Item("address")
                MyTable.Rows(rc).Item("AddressS") = sDt3.Rows(i).Item("AddressS")
                MyTable.Rows(rc).Item("Tel") = sDt3.Rows(i).Item("Tel")
                MyTable.Rows(rc).Item("Fax") = sDt3.Rows(i).Item("Fax")
                MyTable.Rows(rc).Item("CusNameCon_") = sDt3.Rows(i).Item("CusNameCon_")
                MyTable.Rows(rc).Item("MobileCon") = sDt3.Rows(i).Item("MobileCon")
                MyTable.Rows(rc).Item("idPsSale") = sDt3.Rows(i).Item("idPsSale")
                MyTable.Rows(rc).Item("idPsSet") = sDt3.Rows(i).Item("idPsSet")
                MyTable.Rows(rc).Item("idPsSend") = sDt3.Rows(i).Item("idPsSend")
                MyTable.Rows(rc).Item("idCus") = sDt3.Rows(i).Item("idCus")
            Next

            'Else 'Other Bill Sale

            '    If stBillTypeS = "4" Then 'ขายสินค้าอื่นๆ
            '        sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
            '                               "m.DiscountAmout, m.DiscountPerc, m.TotalNet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
            '                               "m.CusName, m.PsSent,  m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
            '                               "m.note, d.idPdo As idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, " & _
            '                               "p.Title As PdPkName, ISNULL(d.PerBox, 0) As Perbox, d.idUnit As idPkUnit, u.UnitName As PkUnitName, " & _
            '                               "'' As PdCode, c.address, c.AddressS, " & _
            '                               "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
            '                               "m.idPsSend, m.idCus FROM vSmSaleMt m LEFT OUTER JOIN " & _
            '                               "SmSaleDtOther d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                               "SmPdOtherD p ON d.idPdo = p.idPdo LEFT OUTER JOIN dCustomer c " & _
            '                               "ON m.idCus=c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                               "LEFT OUTER JOIN PchInvAndProject.dbo.dInvUnit u ON d.idUnit = u.idUnit WHERE m.idSale ='" & idSaleS & "'"
            '    ElseIf stBillTypeS = "7" Then 'ขายเมล็ด
            '        sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
            '                               "m.DiscountAmout, m.DiscountPerc, m.TotalNet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
            '                               "m.CusName, m.PsSent,  m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
            '                               "m.note, d.idPdLot As idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, " & _
            '                               "d.PdNameBill As PdPkName, 0 As PerBox, d.idUnit As idPkUnit, u.UnitW As PkUnitName, " & _
            '                               "'' As PdCode, c.address, c.AddressS, " & _
            '                               "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
            '                               "m.idPsSend, m.idCus FROM vSmSaleMt m LEFT OUTER JOIN " & _
            '                               "SmSaleDtPd d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                               "PkPdLotStock p ON d.idPdLot = p.idPdLot LEFT OUTER JOIN dCustomer c " & _
            '                               "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                               "LEFT OUTER JOIN dUnitW u ON d.idUnit = u.idUnitW WHERE m.idSale ='" & idSaleS & "'"
            '    Else 'Normal Sale
            '        sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
            '                               "m.DiscountAmout, m.DiscountPerc, m.TotalNet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
            '                               "m.CusName, m.PsSent,  m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
            '                               "m.note, d.idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, p.PdPkName, " & _
            '                               "ISNULL(d.PerBox, 0) As Perbox, d.idPkUnit, u.PkUnitName, p.PdCode, c.address, c.AddressS, " & _
            '                               "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
            '                               "m.idPsSend, m.idCus FROM vSmSaleMt m LEFT OUTER JOIN " & _
            '                               "SmSaleDt d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                               "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
            '                               "ON m.idCus=c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                               "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit WHERE m.idSale ='" & idSaleS & "'"
            '    End If

            '    MyTable.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))
            '    MyTable.Columns.Add("AddressComp", System.Type.GetType("System.String"))
            '    MyTable.Columns.Add("TelComp", System.Type.GetType("System.String"))
            '    MyTable.Columns.Add("FaxComp", System.Type.GetType("System.String"))
            '    MyTable.Columns.Add("TexCode", System.Type.GetType("System.String"))
            '    MyTable.Columns.Add("picSignPsSale", System.Type.GetType("System.Byte[]"))
            '    MyTable.Columns.Add("picSignPsSet", System.Type.GetType("System.Byte[]"))
            '    MyTable.Columns.Add("picSignPsSent", System.Type.GetType("System.Byte[]"))
            '    sAdapter.Fill(MyTable)


            ' End If


            '*************** Open if use Promotion Process ******************************'
            ''***** ADD Rows Promotion to InvPaperDt *****'
            ''Check Price Promotion
            'Dim pDt As New DataTable
            'pDt.Clear()
            'sCommand.CommandText = "SELECT u.idPromotion, u.idPdPkSale, p.PdPkname, u.DisCountPro " & _
            '                       "FROM SmPromotionUseMt u INNER JOIN vpackingPdSet p " & _
            '                       "ON u.idPdPkSale = p.idPdPk WHERE u.idSale='" & idSaleS & "' AND u.PricePro IS NOT NULL "
            'sAdapter.Fill(pDt)

            'If pDt.Rows.Count > 0 Then
            '    'blank row
            '    MyTable.Rows.Add(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                     0, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, 0, Nothing, _
            '                     Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, _
            '                     0, Nothing, 0, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                     Nothing, Nothing, Nothing, Nothing, Nothing)
            '    'Price Pro Header
            '    MyTable.Rows.Add(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                     0, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, 0, Nothing, _
            '                    Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, _
            '                    0, "------ ส่วนลดจากโปรโมชั่น ------", 0, Nothing, Nothing, Nothing, Nothing, _
            '                    Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            '    'ADD list price pro
            '    For i As Integer = 0 To pDt.Rows.Count - 1
            '        MyTable.Rows.Add(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                        0, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, 0, Nothing, _
            '                        Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 1, _
            '                        pDt.Rows(i).Item("DisCountPro"), _
            '                        0, "ส่วนลด " & pDt.Rows(i).Item("PdPkName"), 0, Nothing, "หน่วย", Nothing, Nothing, _
            '                        Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            '    Next
            'End If

            ''Check Promotion
            'Dim pDt2 As New DataTable
            'pDt2.Clear()
            'sCommand.CommandText = "SELECT u.idProUse, p.ProName, u.idInv , i.InvName_ , u.idPdPk, pk.PdPkName, " & _
            '                       "u.AmountFree, u.FreeUnit, u.cdtPrice, u.cdtAmount, u.cdtMin, u.cdtMax, " & _
            '                       "u.cdtUnit, u.CollectCut, p.stBillPromotion FROM [GR_Group].[dbo].[SmPromotionUseMt] u " & _
            '                       "LEFT OUTER JOIN [GR_Group].[dbo].[SmPromotionMt] p ON u.idPromotion = p.idPromotion " & _
            '                       "LEFT OUTER JOIN [GR_Group].[dbo].[SmPromotionType] t ON p.idProType = t.idProType " & _
            '                       "LEFT OUTER JOIN [GR_Group].[dbo].[vCustomer]  c ON u.idCus = c.idCus " & _
            '                       "LEFT OUTER JOIN [PchInvAndProject].[dbo].[vInventory] i ON u.idInv = i.idInv " & _
            '                       "LEFT OUTER JOIN [GR_Group].[dbo].[vPackingPdSet] pk ON u.idPdPk = pk.idPdPk " & _
            '                       "WHERE u.idSale = " & idSaleS & " AND u.stApprove = 1"

            'sAdapter.Fill(pDt2)
            'If pDt2.Rows.Count > 0 Then
            '    'blank row
            '    MyTable.Rows.Add(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                     0, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, 0, Nothing, _
            '                     Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, _
            '                     0, Nothing, 0, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                     Nothing, Nothing, Nothing, Nothing, Nothing)
            '    'Price Pro Header
            '    MyTable.Rows.Add(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                    0, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, 0, Nothing, _
            '                   Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, _
            '                   0, "------- ของแถมจากโปรโมชั่น ------", 0, Nothing, Nothing, Nothing, Nothing, _
            '                   Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            '    'ADD list ของแถม
            '    For i As Integer = 0 To pDt2.Rows.Count - 1
            '        Dim vPremium As String = ""
            '        If Not IsDBNull(pDt2.Rows(i).Item("InvName_")) Then 'idInv
            '            vPremium = pDt2.Rows(i).Item("InvName_")
            '        Else 'idPdPk
            '            vPremium = pDt2.Rows(i).Item("PdPkName")
            '        End If

            '        If pDt2.Rows(i).Item("FreeUnit") = "กระป๋อง" Then
            '            pDt2.Rows(i).Item("FreeUnit") = "กป."
            '        ElseIf pDt2.Rows(i).Item("FreeUnit") = "ซอง" Then
            '            pDt2.Rows(i).Item("FreeUnit") = "ซ."
            '        ElseIf pDt2.Rows(i).Item("FreeUnit") = "กระสอบ" Then
            '            pDt2.Rows(i).Item("FreeUnit") = "กส."
            '        ElseIf pDt2.Rows(i).Item("FreeUnit") = "ถุง" Then
            '            pDt2.Rows(i).Item("FreeUnit") = "ถ."
            '        End If

            '        Dim CntStr As String = " : "
            '        If Not IsDBNull(pDt2.Rows(i).Item("CdtAmount")) Then
            '            CntStr = CntStr & " ซื้อสินค้าจำนวน " & Format(pDt2.Rows(i).Item("CdtAmount"), "#,##0") & " " & pDt2.Rows(i).Item("CdtUnit")
            '        End If

            '        If Not IsDBNull(pDt2.Rows(i).Item("CdtMin")) Then
            '            If pDt2.Rows(0).Item("CdtMax") > 0 Then
            '                CntStr = CntStr & " ซื้อสินค้าจำนวน " & Format(pDt2.Rows(i).Item("CdtMin"), "#,##0") & " - " & Format(pDt2.Rows(i).Item("CdtMax"), "#,##0") _
            '                         & " " & pDt2.Rows(0).Item("CdtUnit")
            '            Else
            '                CntStr = CntStr & " ซื้อสินค้าตั้งแต่ " & Format(pDt2.Rows(i).Item("CdtMax"), "#,##0") & " " & pDt2.Rows(i).Item("CdtUnit") & " ขึ้นไป"
            '            End If
            '        End If

            '        If Not IsDBNull(pDt2.Rows(i).Item("CdtPrice")) Then
            '            CntStr = CntStr & " ราคาตั้งแต่ " & pDt2.Rows(i).Item("CdtPrice") & " บาทขึ้นไป "
            '        End If


            '        MyTable.Rows.Add(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                    0, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, 0, Nothing, _
            '                   Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                   pDt2.Rows(i).Item("AmountFree"), 0, _
            '                   0, vPremium, 0, Nothing, pDt2.Rows(i).Item("FreeUnit"), Nothing, Nothing, _
            '                   Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            '        'ADD Promotion Use
            '        MyTable.Rows.Add(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                    0, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, 0, Nothing, _
            '                   Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                   Nothing, 0, 0, "(" & pDt2.Rows(i).Item("ProName") & CntStr & ")", 0, Nothing, _
            '                   Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                   Nothing, Nothing, Nothing, Nothing)
            '    Next
            'End If

            ''Show Promotion Collect Of Customer
            'Dim pDt3 As New DataTable
            'pDt3.Clear()
            'sCommand.CommandText = "SELECT c.idPromotion, mt.ProName, c.Amount As Collect, dt.Amount, dt.Salemax, dt.SaleMin " & _
            '                       "FROM SmPromotionCollect c LEFT OUTER JOIN SmPromotionMt mt " & _
            '                       "ON c.idPromotion = mt.idPromotion LEFT OUTER JOIN SmPromotionDt dt " & _
            '                       "ON mt.idPromotion = dt.idPromotion WHERE idCus = " & MyTable.Rows(0).Item("idCus") & ""
            'sAdapter.Fill(pDt3)

            'If pDt3.Rows.Count > 0 Then
            '    'blank row
            '    MyTable.Rows.Add(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                     0, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, 0, Nothing, _
            '                     Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, _
            '                     0, Nothing, 0, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                     Nothing, Nothing, Nothing, Nothing, Nothing)

            '    'Pro Collect Header
            '    MyTable.Rows.Add(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '                  0, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, 0, Nothing, _
            '                 Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, _
            '                 0, "------- ยอดโปรโมชั่นสะสม ------", 0, Nothing, Nothing, Nothing, Nothing, _
            '                 Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            '    'ADD list โปรฯ สะสม
            '    For i As Integer = 0 To pDt3.Rows.Count - 1
            '        Dim AmtFull As String = ""
            '        If Not IsDBNull(pDt3.Rows(i).Item("Amount")) Then
            '            AmtFull = " (" & pDt3.Rows(i).Item("Amount") & " กก.)"
            '        ElseIf Not IsDBNull(pDt3.Rows(i).Item("SaleMin")) Then
            '            If pDt3.Rows(i).Item("SaleMax") <> 0 Then
            '                AmtFull = " (" & pDt3.Rows(i).Item("SaleMin") & " - " & pDt3.Rows(i).Item("SaleMax") & " กก.)"
            '            Else
            '                AmtFull = " (" & pDt3.Rows(i).Item("SaleMin") & " ขึ้นไป)"
            '            End If

            '        End If

            '        MyTable.Rows.Add(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '        0, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0, 0, Nothing, _
            '        Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '        pDt3.Rows(i).Item("Collect"), 0, 0, pDt3.Rows(i).Item("ProName") & AmtFull & " ยอดสะสมปัจจุบัน ", _
            '        0, Nothing, "กก.", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
            '        Nothing, Nothing, Nothing, Nothing, Nothing)

            '    Next
            'End If

            Dim URL As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & sIdComp & ".jpg"
            Dim client As New System.Net.WebClient
            Dim buffer As Byte()
            Dim pic() As Byte

            Try
                buffer = client.DownloadData(URL)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                For i As Integer = 0 To MyTable.Rows.Count - 1
                    MyTable.Rows(i).Item("picComp") = pic
                Next
            Catch ex As Exception
                ' Noimage
            End Try

            '---sign PsSale Pic---'
            Dim URL2 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & MyTable.Rows(0).Item("idPsSale") & ".png"
            'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
            Try
                buffer = client.DownloadData(URL2)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                For i As Integer = 0 To MyTable.Rows.Count - 1
                    MyTable.Rows(i).Item("picSignPsSale") = pic
                Next

            Catch ex As Exception
                stSignPsSale = 1
                ' Noimage
            End Try

            '---sign PsSet Pic---'
            If IsDBNull(MyTable.Rows(0).Item("idPsSet")) Then
                stSignPsSet = 1
            ElseIf MyTable.Rows(0).Item("idPsSet") = Nothing Then
                stSignPsSet = 1
            Else
                Dim URL3 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & MyTable.Rows(0).Item("idPsSet") & ".png"
                'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
                Try
                    buffer = client.DownloadData(URL3)
                    Dim stream As New System.IO.MemoryStream(buffer)
                    Dim binReader As New IO.BinaryReader(stream)
                    pic = binReader.ReadBytes(stream.Length)
                    For i As Integer = 0 To MyTable.Rows.Count - 1
                        MyTable.Rows(i).Item("picSignPsSet") = pic
                    Next
                Catch ex As Exception
                    stSignPsSet = 1
                    ' Noimage
                End Try

            End If

            '---sign PsSent Pic---'
            If IsDBNull(MyTable.Rows(0).Item("idPsSend")) Then
                stSignPsSent = 1
            ElseIf MyTable.Rows(0).Item("idPsSend") = Nothing Then
                stSignPsSent = 1
            Else
                Dim URL4 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & MyTable.Rows(0).Item("idPsSend") & ".png"
                'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
                Try
                    buffer = client.DownloadData(URL4)
                    Dim stream As New System.IO.MemoryStream(buffer)
                    Dim binReader As New IO.BinaryReader(stream)
                    pic = binReader.ReadBytes(stream.Length)
                    For i As Integer = 0 To MyTable.Rows.Count - 1
                        MyTable.Rows(i).Item("picSignPsSend") = pic
                    Next

                Catch ex As Exception
                    stSignPsSent = 1
                    ' Noimage
                End Try

            End If

            For i As Integer = 0 To MyTable.Rows.Count - 1
                If Not IsDBNull(MyTable.Rows(i).Item("DateTs")) Then
                    MyTable.Rows(i).Item("DateTs") = ksbStringToDate(MyTable.Rows(i).Item("DateTs"))
                End If
                If Not IsDBNull(MyTable.Rows(i).Item("DateSale")) Then
                    MyTable.Rows(i).Item("DateSale") = ksbStringToDate(MyTable.Rows(i).Item("DateSale"))
                End If
                If Not IsDBNull(MyTable.Rows(i).Item("DatePay")) Then
                    MyTable.Rows(i).Item("DatePay") = ksbStringToDate(MyTable.Rows(i).Item("DatePay"))
                End If

                MyTable.Rows(i).Item("AddressComp") = AddressComp
                MyTable.Rows(i).Item("TelComp") = TelComp
                MyTable.Rows(i).Item("FaxComp") = FaxComp
                MyTable.Rows(i).Item("TexCode") = TexCode

                If IsDBNull(MyTable.Rows(i).Item("PerBox")) Then
                    MyTable.Rows(i).Item("PerBox") = 1
                End If

                If Not IsDBNull(MyTable.Rows(i).Item("idPkUnit")) Then
                    If MyTable.Rows(i).Item("idPkUnit") = 3 Then
                        MyTable.Rows(i).Item("Price") = MyTable.Rows(i).Item("Price") * MyTable.Rows(i).Item("PerBox")
                    End If
                End If


                If IsDBNull(MyTable.Rows(i).Item("DisPerclist")) Then
                    MyTable.Rows(i).Item("DisPerclist") = 0
                End If
            Next
            SumVAT = 0

            Dim vRpt As New crpReceiptInvoice
            vRpt.SetDataSource(MyTable)
            vRpt.SetParameterValue(vRpt.Parameter_idSale.ParameterFieldName, idSaleS)
            vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, sCompName)
            'vRpt.SetParameterValue(vRpt.Parameter_Total_ThChar.ParameterFieldName, "")
            vRpt.SetParameterValue(vRpt.Parameter_VAT.ParameterFieldName, SumVAT)
            vRpt.SetParameterValue(vRpt.Parameter_PsPrint.ParameterFieldName, sPsName)
            vRpt.SetParameterValue(vRpt.Parameter_stSignPsSale.ParameterFieldName, stSignPsSale)
            vRpt.SetParameterValue(vRpt.Parameter_stSignPsSet.ParameterFieldName, stSignPsSet)
            vRpt.SetParameterValue(vRpt.Parameter_stSignPsSent.ParameterFieldName, stSignPsSent)
            Me.CrystalReportViewer1.ReportSource = vRpt

            If statusP = 4 Then
                Me.CrystalReportViewer1.ShowPrintButton = True
            End If

            mdLoadCommitt()
        End If
    End Sub

    Private Sub rdbSendDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSendDoc.CheckedChanged
        If Me.rdbSendDoc.Checked = True And stload = 1 Then
            mdCnOpen()

            mdLoadShow()
            Dim SumVAT As String
            Dim stSignPsSale As Integer = 0
            Dim stSignPsSet As Integer = 0
            Dim stSignPsSent As Integer = 0

            '****พิมพ์ใบส่งของ****-
            'Dim MyTable As New DataTable
            'MyTable.Clear()
            'mdCnOpen()
            'sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
            '                        "m.DiscountAmout, m.DiscountPerc, m.TotalNet, m.CusName, m.PsSent,  m.PsSale,  " & _
            '                        "m.PsTs,  m.PsSet, m.PaymentTerms,m.Transport, m.note, d.idPdPk, d.Amount, d.Price, " & _
            '                        "d.DiscountPerc as DisPerclist, p.PdPkName, d.PerBox, d.idPkUnit, u.PkUnitName, " & _
            '                        "p.PdCode, c.address, c.AddressS, c.Tel, c.Fax, v.CusNameCon_, " & _
            '                        "v.MobileCon, m.idPsSale, m.idTs, m.idPsSet, m.idPsSend FROM vSmSaleMt m " & _
            '                        "LEFT OUTER JOIN SmSaleDt d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                        "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
            '                        "ON m.idCus=c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                        "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit WHERE m.idSale ='" & idSaleS & "'"

            Dim MyTable As New DataTable
            MyTable.Clear()
            MyTable.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))
            MyTable.Columns.Add("AddressComp", System.Type.GetType("System.String"))
            MyTable.Columns.Add("TelComp", System.Type.GetType("System.String"))
            MyTable.Columns.Add("FaxComp", System.Type.GetType("System.String"))
            MyTable.Columns.Add("TexCode", System.Type.GetType("System.String"))
            MyTable.Columns.Add("picSignPsSale", System.Type.GetType("System.Byte[]"))
            MyTable.Columns.Add("picSignPsSet", System.Type.GetType("System.Byte[]"))
            MyTable.Columns.Add("picSignPsSent", System.Type.GetType("System.Byte[]"))

            MyTable.Columns.Add("idSale", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("DateTs", System.Type.GetType("System.String"))
            MyTable.Columns.Add("DateSale", System.Type.GetType("System.String"))
            MyTable.Columns.Add("DatePay", System.Type.GetType("System.String"))
            MyTable.Columns.Add("DocCode", System.Type.GetType("System.String"))
            MyTable.Columns.Add("DocRef", System.Type.GetType("System.String"))
            MyTable.Columns.Add("Total", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("DiscountAmout", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("DiscountPerc", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("TotalNet", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("CusName", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PsSent", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PsSale", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PsTs", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PsSet", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PaymentTerms", System.Type.GetType("System.String"))
            MyTable.Columns.Add("Transport", System.Type.GetType("System.String"))
            MyTable.Columns.Add("note", System.Type.GetType("System.String"))
            MyTable.Columns.Add("idPdPk", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("Amount", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("Price", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("DisPerclist", System.Type.GetType("System.Double"))
            MyTable.Columns.Add("PdPkName", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PerBox", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("idPkUnit", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("PkUnitName", System.Type.GetType("System.String"))
            MyTable.Columns.Add("PdCode", System.Type.GetType("System.String"))
            MyTable.Columns.Add("address", System.Type.GetType("System.String"))
            MyTable.Columns.Add("AddressS", System.Type.GetType("System.String"))
            MyTable.Columns.Add("Tel", System.Type.GetType("System.String"))
            MyTable.Columns.Add("Fax", System.Type.GetType("System.String"))
            MyTable.Columns.Add("CusNameCon_", System.Type.GetType("System.String"))
            MyTable.Columns.Add("MobileCon", System.Type.GetType("System.String"))
            MyTable.Columns.Add("idPsSale", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("idPsSet", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("idPsSend", System.Type.GetType("System.Int32"))
            MyTable.Columns.Add("idCus", System.Type.GetType("System.Int32"))


            '----- SmSaleDt ------'
            Dim sDt As New DataTable
            sDt.Clear()
            sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
                                   "m.DiscountAmout, m.DiscountPerc, m.TotalNet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
                                   "m.CusName, m.PsSent, m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
                                   "m.note, d.idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, p.PdPkName, " & _
                                   "ISNULL(d.PerBox, 0) As Perbox, d.idPkUnit, u.PkUnitName, p.PdCode, c.address, m.AddressS, " & _
                                   "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
                                   "m.idPsSend, m.idCus FROM SmSaleDt d LEFT OUTER JOIN " & _
                                   "vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                   "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
                                   "ON m.idCus=c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                   "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt)

            For i As Integer = 0 To sDt.Rows.Count - 1
                Dim rc As Integer = MyTable.Rows.Count
                MyTable.Rows.Add()

                MyTable.Rows(rc).Item("idSale") = sDt.Rows(i).Item("idSale")
                MyTable.Rows(rc).Item("DateTs") = sDt.Rows(i).Item("DateTs")
                MyTable.Rows(rc).Item("DateSale") = sDt.Rows(i).Item("DateSale")
                MyTable.Rows(rc).Item("DatePay") = sDt.Rows(i).Item("DatePay")
                MyTable.Rows(rc).Item("DocCode") = sDt.Rows(i).Item("DocCode")
                MyTable.Rows(rc).Item("DocRef") = sDt.Rows(i).Item("DocRef")
                MyTable.Rows(rc).Item("Total") = sDt.Rows(i).Item("Total")
                MyTable.Rows(rc).Item("DiscountAmout") = sDt.Rows(i).Item("DiscountAmout")
                MyTable.Rows(rc).Item("DiscountPerc") = sDt.Rows(i).Item("DiscountPerc")
                MyTable.Rows(rc).Item("TotalNet") = sDt.Rows(i).Item("TotalNet")
                MyTable.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusName")
                MyTable.Rows(rc).Item("PsSent") = sDt.Rows(i).Item("PsSent")
                MyTable.Rows(rc).Item("PsSale") = sDt.Rows(i).Item("PsSale")
                MyTable.Rows(rc).Item("PsTs") = sDt.Rows(i).Item("PsTs")
                MyTable.Rows(rc).Item("PsSet") = sDt.Rows(i).Item("PsSet")
                MyTable.Rows(rc).Item("PaymentTerms") = sDt.Rows(i).Item("PaymentTerms")
                MyTable.Rows(rc).Item("Transport") = sDt.Rows(i).Item("Transport")
                MyTable.Rows(rc).Item("note") = sDt.Rows(i).Item("note")
                MyTable.Rows(rc).Item("idPdPk") = sDt.Rows(i).Item("idPdPk")
                MyTable.Rows(rc).Item("Amount") = sDt.Rows(i).Item("Amount")
                MyTable.Rows(rc).Item("Price") = sDt.Rows(i).Item("Price")
                MyTable.Rows(rc).Item("DisPerclist") = sDt.Rows(i).Item("DisPerclist")
                MyTable.Rows(rc).Item("PdPkName") = sDt.Rows(i).Item("PdPkName")
                MyTable.Rows(rc).Item("PerBox") = sDt.Rows(i).Item("PerBox")
                MyTable.Rows(rc).Item("idPkUnit") = sDt.Rows(i).Item("idPkUnit")
                MyTable.Rows(rc).Item("PkUnitName") = sDt.Rows(i).Item("PkUnitName")
                MyTable.Rows(rc).Item("PdCode") = sDt.Rows(i).Item("PdCode")
                MyTable.Rows(rc).Item("address") = sDt.Rows(i).Item("address")
                MyTable.Rows(rc).Item("AddressS") = sDt.Rows(i).Item("AddressS")
                MyTable.Rows(rc).Item("Tel") = sDt.Rows(i).Item("Tel")
                MyTable.Rows(rc).Item("Fax") = sDt.Rows(i).Item("Fax")
                MyTable.Rows(rc).Item("CusNameCon_") = sDt.Rows(i).Item("CusNameCon_")
                MyTable.Rows(rc).Item("MobileCon") = sDt.Rows(i).Item("MobileCon")
                MyTable.Rows(rc).Item("idPsSale") = sDt.Rows(i).Item("idPsSale")
                MyTable.Rows(rc).Item("idPsSet") = sDt.Rows(i).Item("idPsSet")
                MyTable.Rows(rc).Item("idPsSend") = sDt.Rows(i).Item("idPsSend")
                MyTable.Rows(rc).Item("idCus") = sDt.Rows(i).Item("idCus")
            Next

            '----- SmSaleDtPd ------'
            Dim sDt2 As New DataTable
            sDt2.Clear()
            sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
                                      "m.DiscountAmout, m.DiscountPerc, m.TotalNet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
                                       "m.CusName, m.PsSent,  m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
                                      "m.note, d.idPdLot As idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, " & _
                                      "d.PdNameBill As PdPkName, 0 As PerBox, d.idUnit As idPkUnit, u.UnitW As PkUnitName, " & _
                                      "'' As PdCode, c.address, m.AddressS, " & _
                                      "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
                                      "m.idPsSend, m.idCus FROM SmSaleDtPd d LEFT OUTER JOIN " & _
                                      "vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                      "PkPdLotStock p ON d.idPdLot = p.idPdLot LEFT OUTER JOIN dCustomer c " & _
                                      "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                      "LEFT OUTER JOIN dUnitW u ON d.idUnit = u.idUnitW WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt2)

            For i As Integer = 0 To sDt2.Rows.Count - 1
                Dim rc As Integer = MyTable.Rows.Count
                MyTable.Rows.Add()

                MyTable.Rows(rc).Item("idSale") = sDt2.Rows(i).Item("idSale")
                MyTable.Rows(rc).Item("DateTs") = sDt2.Rows(i).Item("DateTs")
                MyTable.Rows(rc).Item("DateSale") = sDt2.Rows(i).Item("DateSale")
                MyTable.Rows(rc).Item("DatePay") = sDt2.Rows(i).Item("DatePay")
                MyTable.Rows(rc).Item("DocCode") = sDt2.Rows(i).Item("DocCode")
                MyTable.Rows(rc).Item("DocRef") = sDt2.Rows(i).Item("DocRef")
                MyTable.Rows(rc).Item("Total") = sDt2.Rows(i).Item("Total")
                MyTable.Rows(rc).Item("DiscountAmout") = sDt2.Rows(i).Item("DiscountAmout")
                MyTable.Rows(rc).Item("DiscountPerc") = sDt2.Rows(i).Item("DiscountPerc")
                MyTable.Rows(rc).Item("TotalNet") = sDt2.Rows(i).Item("TotalNet")
                MyTable.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusName")
                MyTable.Rows(rc).Item("PsSent") = sDt2.Rows(i).Item("PsSent")
                MyTable.Rows(rc).Item("PsSale") = sDt2.Rows(i).Item("PsSale")
                MyTable.Rows(rc).Item("PsTs") = sDt2.Rows(i).Item("PsTs")
                MyTable.Rows(rc).Item("PsSet") = sDt2.Rows(i).Item("PsSet")
                MyTable.Rows(rc).Item("PaymentTerms") = sDt2.Rows(i).Item("PaymentTerms")
                MyTable.Rows(rc).Item("Transport") = sDt2.Rows(i).Item("Transport")
                MyTable.Rows(rc).Item("note") = sDt2.Rows(i).Item("note")
                MyTable.Rows(rc).Item("idPdPk") = sDt2.Rows(i).Item("idPdPk")
                MyTable.Rows(rc).Item("Amount") = sDt2.Rows(i).Item("Amount")
                MyTable.Rows(rc).Item("Price") = sDt2.Rows(i).Item("Price")
                MyTable.Rows(rc).Item("DisPerclist") = sDt2.Rows(i).Item("DisPerclist")
                MyTable.Rows(rc).Item("PdPkName") = sDt2.Rows(i).Item("PdPkName")
                MyTable.Rows(rc).Item("PerBox") = sDt2.Rows(i).Item("PerBox")
                MyTable.Rows(rc).Item("idPkUnit") = sDt2.Rows(i).Item("idPkUnit")
                MyTable.Rows(rc).Item("PkUnitName") = sDt2.Rows(i).Item("PkUnitName")
                MyTable.Rows(rc).Item("PdCode") = sDt2.Rows(i).Item("PdCode")
                MyTable.Rows(rc).Item("address") = sDt2.Rows(i).Item("address")
                MyTable.Rows(rc).Item("AddressS") = sDt2.Rows(i).Item("AddressS")
                MyTable.Rows(rc).Item("Tel") = sDt2.Rows(i).Item("Tel")
                MyTable.Rows(rc).Item("Fax") = sDt2.Rows(i).Item("Fax")
                MyTable.Rows(rc).Item("CusNameCon_") = sDt2.Rows(i).Item("CusNameCon_")
                MyTable.Rows(rc).Item("MobileCon") = sDt2.Rows(i).Item("MobileCon")
                MyTable.Rows(rc).Item("idPsSale") = sDt2.Rows(i).Item("idPsSale")
                MyTable.Rows(rc).Item("idPsSet") = sDt2.Rows(i).Item("idPsSet")
                MyTable.Rows(rc).Item("idPsSend") = sDt2.Rows(i).Item("idPsSend")
                MyTable.Rows(rc).Item("idCus") = sDt2.Rows(i).Item("idCus")
            Next


            '----- SmSaleDtOther ------'
            Dim sDt3 As New DataTable
            sDt3.Clear()
            sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
                                       "m.DiscountAmout, m.DiscountPerc, m.TotalNet, v.idPreName, v.CusNameOwn, v.LastNameOwn, " & _
                                       "m.CusName, m.PsSent,  m.PsSale,  m.PsTs,  m.PsSet, m.PaymentTerms, m.Transport, " & _
                                       "m.note, d.idPdo As idPdPk, d.Amount, d.Price, d.DiscountPerc as DisPerclist, " & _
                                       "p.Title As PdPkName, ISNULL(d.PerBox, 0) As Perbox, d.idUnit As idPkUnit, u.UnitName As PkUnitName, " & _
                                       "'' As PdCode, c.address, m.AddressS, " & _
                                       "c.Tel, c.Fax, v.CusNameCon_, v.MobileCon, m.idPsSale, m.idPsSet, " & _
                                       "m.idPsSend, m.idCus FROM SmSaleDtOther d LEFT OUTER JOIN " & _
                                       "vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                       "SmPdOtherD p ON d.idPdo = p.idPdo LEFT OUTER JOIN dCustomer c " & _
                                       "ON m.idCus=c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                       "LEFT OUTER JOIN PchInvAndProject.dbo.dInvUnit u ON d.idUnit = u.idUnit WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt3)

            For i As Integer = 0 To sDt3.Rows.Count - 1
                Dim rc As Integer = MyTable.Rows.Count
                MyTable.Rows.Add()

                MyTable.Rows(rc).Item("idSale") = sDt3.Rows(i).Item("idSale")
                MyTable.Rows(rc).Item("DateTs") = sDt3.Rows(i).Item("DateTs")
                MyTable.Rows(rc).Item("DateSale") = sDt3.Rows(i).Item("DateSale")
                MyTable.Rows(rc).Item("DatePay") = sDt3.Rows(i).Item("DatePay")
                MyTable.Rows(rc).Item("DocCode") = sDt3.Rows(i).Item("DocCode")
                MyTable.Rows(rc).Item("DocRef") = sDt3.Rows(i).Item("DocRef")
                MyTable.Rows(rc).Item("Total") = sDt3.Rows(i).Item("Total")
                MyTable.Rows(rc).Item("DiscountAmout") = sDt3.Rows(i).Item("DiscountAmout")
                MyTable.Rows(rc).Item("DiscountPerc") = sDt3.Rows(i).Item("DiscountPerc")
                MyTable.Rows(rc).Item("TotalNet") = sDt3.Rows(i).Item("TotalNet")
                MyTable.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
                MyTable.Rows(rc).Item("PsSent") = sDt3.Rows(i).Item("PsSent")
                MyTable.Rows(rc).Item("PsSale") = sDt3.Rows(i).Item("PsSale")
                MyTable.Rows(rc).Item("PsTs") = sDt3.Rows(i).Item("PsTs")
                MyTable.Rows(rc).Item("PsSet") = sDt3.Rows(i).Item("PsSet")
                MyTable.Rows(rc).Item("PaymentTerms") = sDt3.Rows(i).Item("PaymentTerms")
                MyTable.Rows(rc).Item("Transport") = sDt3.Rows(i).Item("Transport")
                MyTable.Rows(rc).Item("note") = sDt3.Rows(i).Item("note")
                MyTable.Rows(rc).Item("idPdPk") = sDt3.Rows(i).Item("idPdPk")
                MyTable.Rows(rc).Item("Amount") = sDt3.Rows(i).Item("Amount")
                MyTable.Rows(rc).Item("Price") = sDt3.Rows(i).Item("Price")
                MyTable.Rows(rc).Item("DisPerclist") = sDt3.Rows(i).Item("DisPerclist")
                MyTable.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("PdPkName")
                MyTable.Rows(rc).Item("PerBox") = sDt3.Rows(i).Item("PerBox")
                MyTable.Rows(rc).Item("idPkUnit") = sDt3.Rows(i).Item("idPkUnit")
                MyTable.Rows(rc).Item("PkUnitName") = sDt3.Rows(i).Item("PkUnitName")
                MyTable.Rows(rc).Item("PdCode") = sDt3.Rows(i).Item("PdCode")
                MyTable.Rows(rc).Item("address") = sDt3.Rows(i).Item("address")
                MyTable.Rows(rc).Item("AddressS") = sDt3.Rows(i).Item("AddressS")
                MyTable.Rows(rc).Item("Tel") = sDt3.Rows(i).Item("Tel")
                MyTable.Rows(rc).Item("Fax") = sDt3.Rows(i).Item("Fax")
                MyTable.Rows(rc).Item("CusNameCon_") = sDt3.Rows(i).Item("CusNameCon_")
                MyTable.Rows(rc).Item("MobileCon") = sDt3.Rows(i).Item("MobileCon")
                MyTable.Rows(rc).Item("idPsSale") = sDt3.Rows(i).Item("idPsSale")
                MyTable.Rows(rc).Item("idPsSet") = sDt3.Rows(i).Item("idPsSet")
                MyTable.Rows(rc).Item("idPsSend") = sDt3.Rows(i).Item("idPsSend")
                MyTable.Rows(rc).Item("idCus") = sDt3.Rows(i).Item("idCus")
            Next


            'MyTable.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))
            'MyTable.Columns.Add("picSignPsSale", System.Type.GetType("System.Byte[]"))
            'MyTable.Columns.Add("picSignPsSet", System.Type.GetType("System.Byte[]"))
            'MyTable.Columns.Add("picSignPsSent", System.Type.GetType("System.Byte[]"))
            'MyTable.Columns.Add("AddressComp", System.Type.GetType("System.String"))
            'MyTable.Columns.Add("TelComp", System.Type.GetType("System.String"))
            'MyTable.Columns.Add("FaxComp", System.Type.GetType("System.String"))
            'MyTable.Columns.Add("TexCode", System.Type.GetType("System.String"))
            sAdapter.Fill(MyTable)


            Dim URL As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & sIdComp & ".jpg"
            Dim client As New System.Net.WebClient
            Dim buffer As Byte()
            Dim pic() As Byte

            Try
                buffer = client.DownloadData(URL)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                For i As Integer = 0 To MyTable.Rows.Count - 1
                    MyTable.Rows(i).Item("picComp") = pic
                Next

            Catch ex As Exception
                ' Noimage
            End Try

            '---sign PsSale Pic---'
            Dim URL2 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & MyTable.Rows(0).Item("idPsSale") & ".png"
            'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
            Try
                buffer = client.DownloadData(URL2)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                For i As Integer = 0 To MyTable.Rows.Count - 1
                    MyTable.Rows(i).Item("picSignPsSale") = pic
                Next

            Catch ex As Exception
                stSignPsSale = 1
                ' Noimage
            End Try

            '---sign PsSet Pic---'
            If IsDBNull(MyTable.Rows(0).Item("idPsSet")) Then
                stSignPsSet = 1
            ElseIf MyTable.Rows(0).Item("idPsSet") = Nothing Then
                stSignPsSet = 1
            Else
                Dim URL3 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & MyTable.Rows(0).Item("idPsSet") & ".png"
                'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
                Try
                    buffer = client.DownloadData(URL3)
                    Dim stream As New System.IO.MemoryStream(buffer)
                    Dim binReader As New IO.BinaryReader(stream)
                    pic = binReader.ReadBytes(stream.Length)
                    For i As Integer = 0 To MyTable.Rows.Count - 1
                        MyTable.Rows(i).Item("picSignPsSet") = pic
                    Next
                Catch ex As Exception
                    stSignPsSet = 1
                    ' Noimage
                End Try

            End If

            '---sign PsSent Pic---'
            If IsDBNull(MyTable.Rows(0).Item("idPsSend")) Then
                stSignPsSent = 1
            ElseIf MyTable.Rows(0).Item("idPsSend") = Nothing Then
                stSignPsSent = 1
            Else
                Dim URL4 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & MyTable.Rows(0).Item("idPsSend") & ".png"
                'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
                Try
                    buffer = client.DownloadData(URL4)
                    Dim stream As New System.IO.MemoryStream(buffer)
                    Dim binReader As New IO.BinaryReader(stream)
                    pic = binReader.ReadBytes(stream.Length)
                    For i As Integer = 0 To MyTable.Rows.Count - 1
                        MyTable.Rows(i).Item("picSignPsSend") = pic
                    Next

                Catch ex As Exception
                    stSignPsSent = 1
                    ' Noimage
                End Try

            End If

            For i As Integer = 0 To MyTable.Rows.Count - 1
                MyTable.Rows(i).Item("DateTs") = ksbStringToDate(MyTable.Rows(i).Item("DateTs"))
                MyTable.Rows(i).Item("DateSale") = ksbStringToDate(MyTable.Rows(i).Item("DateSale"))
                MyTable.Rows(i).Item("DatePay") = ksbStringToDate(MyTable.Rows(i).Item("DatePay"))
                MyTable.Rows(i).Item("AddressComp") = AddressComp
                MyTable.Rows(i).Item("TelComp") = TelComp
                MyTable.Rows(i).Item("FaxComp") = FaxComp
                MyTable.Rows(i).Item("TexCode") = TexCode

                'If MyTable.Rows(i).Item("idTs") = 1 Then
                '    MyTable.Rows(i).Item("Transport") = "-"
                'End If

                If IsDBNull(MyTable.Rows(i).Item("PerBox")) Then
                    MyTable.Rows(i).Item("PerBox") = 1
                End If

                If MyTable.Rows(i).Item("idPkUnit") = 3 Then
                    MyTable.Rows(i).Item("Price") = MyTable.Rows(i).Item("Price") * MyTable.Rows(i).Item("PerBox")
                End If

                If IsDBNull(MyTable.Rows(i).Item("DisPerclist")) Then
                    MyTable.Rows(i).Item("DisPerclist") = 0
                End If
            Next
            SumVAT = 0


            ' Dim MyTable As New DataTable
            ' MyTable = ShowCrpInvoice(idSaleS, True)

            Dim vRpt As New crpInvoice
            vRpt.SetDataSource(MyTable)
            vRpt.SetParameterValue(vRpt.Parameter_idSale.ParameterFieldName, idSaleS)
            vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, sCompName)
            vRpt.SetParameterValue(vRpt.Parameter_CompNameEng.ParameterFieldName, CompnameEng)
            vRpt.SetParameterValue(vRpt.Parameter_AddressCompEng.ParameterFieldName, AddressEng)
            'vRpt.SetParameterValue(vRpt.Parameter_VAT.ParameterFieldName, SumVAT)
            vRpt.SetParameterValue(vRpt.Parameter_stSignPsSale.ParameterFieldName, stSignPsSale)
            'vRpt.SetParameterValue(vRpt.Parameter_stSignPsSet.ParameterFieldName, stSignPsSet)
            'vRpt.SetParameterValue(vRpt.Parameter_stSignPsSent.ParameterFieldName, stSignPsSent)
            'vRpt.SetParameterValue(vRpt.Parameter_PsPrint.ParameterFieldName, sPsName)
            Me.CrystalReportViewer1.ReportSource = vRpt
            If statusP = 4 Then
                Me.CrystalReportViewer1.ShowPrintButton = True
            End If

            mdLoadCommitt()
        End If
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        mdCnOpen()
        Dim strSql As String = ""
        '---Update SmSaleMt Table---'
        sCommand.CommandText = "Update SmSaleMt Set idPsAccept='" & sPsId & "', DateAccept='" & ksbDateToString(Date.Today) & "' " & _
                               "Where idSale='" & idSaleS & "'"
        sCommand.ExecuteNonQuery()

        Dim sDt As New DataTable
        sCommand.CommandText = "Select idPsAccept, idPsCheck, idPsApp From SmSaleMt Where idSale='" & idSaleS & "'"
        sAdapter.Fill(sDt)
        If Not IsDBNull(sDt.Rows(0).Item("idPsAccept")) And Not IsDBNull(sDt.Rows(0).Item("idPsCheck")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp")) Then
            '----Update stApp----'
            sCommand.CommandText = "Update SmSaleMt Set stApp='1' Where idSale='" & idSaleS & "'"
            sCommand.ExecuteNonQuery()
            MessageBox.Show("กระบวนการนี้เป็นการยืนยันขั้นตอนลำดับสุดท้าย ลำดับที่ 3", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("รับทราบเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        mdCnOpen()
        '---Update SmSaleMt Table---'
        sCommand.CommandText = "Update SmSaleMt Set idPsCheck='" & sPsId & "', DateChcek ='" & ksbDateToString(Date.Today) & "' " & _
                               "Where idSale='" & idSaleS & "'"
        sCommand.ExecuteNonQuery()

        Dim sDt As New DataTable
        sCommand.CommandText = "Select idPsAccept, idPsCheck, idPsApp From SmSaleMt Where idSale='" & idSaleS & "'"
        sAdapter.Fill(sDt)
        If Not IsDBNull(sDt.Rows(0).Item("idPsAccept")) And Not IsDBNull(sDt.Rows(0).Item("idPsCheck")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp")) Then
            '----Update stApp----'
            sCommand.CommandText = "Update SmSaleMt Set stApp='1' Where idSale='" & idSaleS & "'"
            sCommand.ExecuteNonQuery()
            MessageBox.Show("กระบวนการนี้เป็นการยืนยันขั้นตอนลำดับสุดท้าย ลำดับที่ 3", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("ตรวจสอบเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprove.Click
        If Me.txtPsApprove.Text <> "" And Me.txtDateApprove.Text <> "" Then
            MessageBox.Show("รายการนี้ผ่านการอนุมัติแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.rdbAppr.Checked = True Then
            mdCnOpen()
            '---Update SmSaleMt Table---'
            sCommand.CommandText = "Update SmSaleMt Set idPsApp='" & sPsId & "', DateApp='" & ksbDateToString(Date.Today) & "' " & _
                                   "Where idSale='" & idSaleS & "'"
            sCommand.ExecuteNonQuery()

        ElseIf Me.rdbNoAppr.Checked = True Then
            mdCnOpen()
            '---Update SmSaleMt Table---'
            sCommand.CommandText = "Update SmSaleMt Set idPsApp='" & sPsId & "', DateApp='" & ksbDateToString(Date.Today) & "', " & _
                                   "stApp='0' Where idSale='" & idSaleS & "'"
            sCommand.ExecuteNonQuery()
            MessageBox.Show("ระบบยืนยันการไม่อนุมัติรายการเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Exit Sub
        Else
            MessageBox.Show("กรุณาเลือกอนุมัติ หรือไม่อนุมัติก่อนทำการบันทึก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim sDt As New DataTable
        sCommand.CommandText = "Select idPsAccept, idPsCheck, idPsApp From SmSaleMt Where idSale='" & idSaleS & "'"
        sAdapter.Fill(sDt)
        If Not IsDBNull(sDt.Rows(0).Item("idPsAccept")) And Not IsDBNull(sDt.Rows(0).Item("idPsCheck")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp")) Then
            '----Update stApp----'
            sCommand.CommandText = "Update SmSaleMt Set stApp='1' Where idSale='" & idSaleS & "'"
            sCommand.ExecuteNonQuery()
            MessageBox.Show("กระบวนการนี้เป็นการยืนยันขั้นตอนลำดับสุดท้าย ลำดับที่ 3", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Dim Dt As New DataTable
            sCommand.CommandText = "Select PsApp, DateApp From vSmSaleMt Where idSale='" & idSaleS & "'"
            sAdapter.Fill(Dt)

            If IsDBNull(Dt.Rows(0).Item("PsApp")) = True Then
                Me.txtPsApprove.Text = ""
            Else
                Me.txtPsApprove.Text = Dt.Rows(0).Item("PsApp")
            End If

            If IsDBNull(Dt.Rows(0).Item("DateApp")) = True Then
                Me.txtDateApprove.Text = ""
            Else
                Me.txtDateApprove.Text = ksbStringToDate(Dt.Rows(0).Item("DateApp"))
            End If
            MessageBox.Show("ตรวจสอบเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    'Private Sub rdbInvoicePaper_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.rdbInvoicePaper.Checked = True Then
    '        mdLoadShow()
    '        '**** พิมพ์ใบเสร็จ : กระดาษต่อเนื่อง ****-
    '        Dim count As Integer = 0
    '        Dim InvPaperDt As New DataTable
    '        InvPaperDt.Clear()
    '        mdCnOpen()

    '        sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
    '                               "ps.PsCode + ' : ' +  m.PsSale As PsSaleName, '' As RegionName, m.CusName, " & _
    '                               " c.address, c.Tel, m.Transport, d.idPdPk, p.PdPkName, d.Amount, d.Price, " & _
    '                               "d.DiscountPerc,  d.PerBox, d.idPkUnit, m.idPsSale FROM vSmSaleMt m " & _
    '                               "LEFT OUTER JOIN SmSaleDt d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
    '                               "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
    '                               "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
    '                               "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit " & _
    '                               "LEFT OUTER JOIN vPerson ps ON m.idPsSale = ps.idPs WHERE m.idSale ='" & idSaleS & "'"
    '        sAdapter.Fill(InvPaperDt)

    '        For i As Integer = 0 To InvPaperDt.Rows.Count - 1
    '            InvPaperDt.Rows(i).Item("DateTs") = ksbStringToDate(InvPaperDt.Rows(i).Item("DateTs"))
    '            InvPaperDt.Rows(i).Item("DateSale") = ksbStringToDate(InvPaperDt.Rows(i).Item("DateSale"))
    '            InvPaperDt.Rows(i).Item("DatePay") = ksbStringToDate(InvPaperDt.Rows(i).Item("DatePay"))
    '        Next


    '        Dim RegionDt As New DataTable
    '        RegionDt.Clear()
    '        sCommand.CommandText = "SELECT r.RegionName, s.idPsSale FROM SmRegionSaleSet AS s LEFT OUTER JOIN " & _
    '                               "SmRegionD AS r ON s.idRegion = r.idRegion Where " & _
    '                               "s.idPsSale = '" & InvPaperDt.Rows(0).Item("idPsSale") & "'"
    '        sAdapter.Fill(RegionDt)

    '        Dim Regionlist As String = ""
    '        For i As Integer = 0 To RegionDt.Rows.Count - 1
    '            If i = 0 Then
    '                Regionlist = RegionDt.Rows(i).Item("RegionName")
    '            Else
    '                Regionlist = Regionlist & ", " & RegionDt.Rows(i).Item("RegionName")
    '            End If
    '        Next
    '        InvPaperDt.Rows(0).Item("RegionName") = Regionlist


    '        For i As Integer = 0 To InvPaperDt.Rows.Count - 1
    '            If IsDBNull(InvPaperDt.Rows(i).Item("PerBox")) Then
    '                InvPaperDt.Rows(i).Item("PerBox") = 0
    '            End If

    '            If InvPaperDt.Rows(i).Item("idPkUnit") = 3 Then 'กล่อง
    '                InvPaperDt.Rows(i).Item("Price") = InvPaperDt.Rows(i).Item("Price") * InvPaperDt.Rows(i).Item("PerBox")
    '            End If


    '            If IsDBNull(InvPaperDt.Rows(i).Item("DiscountPerc")) Then
    '                InvPaperDt.Rows(i).Item("DiscountPerc") = 0
    '            End If
    '        Next
    '        'SumVAT = 0

    '        'Dim vFrm As New frmReportView
    '        'Dim vRpt As New crpReceiptInvoicePaper
    '        'vRpt.SetDataSource(InvPaperDt)
    '        ''(vRpt.SetParameterValue(vRpt.Parameter_idSale.ParameterFieldName, idSaleS))
    '        ''vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, sCompName)
    '        'vRpt.SetParameterValue(vRpt.Parameter_Total_ThChar.ParameterFieldName, "")
    '        ''vRpt.SetParameterValue(vRpt.Parameter_VAT.ParameterFieldName, SumVAT)
    '        ''vRpt.SetParameterValue(vRpt.Parameter_PsPrint.ParameterFieldName, sPsName)
    '        'vFrm.crView.ReportSource = vRpt
    '        'vFrm.Show()

    '        PrintToPrinter()

    '        'Dim vRpt As New crpReceiptInvoicePaper
    '        'vRpt.Load(Server.MapPath("crpReceiptInvoicePaper.rpt"))
    '        'vRpt.SetDatabaseLogon("sa", "sa", ".", "carRent")
    '        'vRpt.SetParameterValue("BondID", ViewState("BondDelID"))
    '        'vRpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
    '        'vRpt.PrintToPrinter(1, False, 1, 1)


    '        'Dim OrderDt As CrystalDecisions.Shared.ParameterValues = New CrystalDecisions.Shared.ParameterValues
    '        'Dim OrderDtDisVal As CrystalDecisions.Shared.ParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue()
    '        'Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo
    '        'Try
    '        '    Dim CR As New crpReceiptInvoicePaper
    '        '    'กำหนดเครื่องปริ้นที่ต้องการปริ้นหรือถ้าตั้ง Default อยู่แล้วก็ไม่ต้องก็ได้ครับ
    '        '    'CR.PrintOptions.PrinterName = "ชื่อเครื่องปริ้น"
    '        '    'กำหนดขนาดของกระดาษ ตามโค๊ดจะเป็น A4
    '        '    CR.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
    '        'ที่อยู่ของ Report 
    '        'CR.Load("C:\BillOrg.rpt", OpenReportMethod.OpenReportByTempCopy)
    '        'ติดต่อฐานข้อมูลของ Report
    '        'For Each Table As CrystalDecisions.CrystalReports.Engine.Table In CR.Database.Tables()
    '        '    ConInfo = Table.LogOnInfo
    '        '    ConInfo.ConnectionInfo.UserID = gReportUser '"sa"
    '        '    ConInfo.ConnectionInfo.Password = gReportPassword ' "123456789"
    '        '    ConInfo.ConnectionInfo.ServerName = gReportServer '"Server"
    '        '    ConInfo.ConnectionInfo.DatabaseName = gReportDatabase '"Database"
    '        '    Table.ApplyLogOnInfo(ConInfo)
    '        'Next

    '        'ตัวแปรที่ 1 ( Parameter 1)
    '        '    ' เพิ่มตัวแปรที่ต้องการส่งไป เช่น ต้องการให้รายงานแสดงตามวันที่ แผนก รายการ ฯ
    '        '    OrderDt = New CrystalDecisions.Shared.ParameterValues
    '        '    OrderDtDisVal = New CrystalDecisions.Shared.ParameterDiscreteValue()
    '        '    'Set OrderDate text field as the discrete value
    '        '    OrderDtDisVal.Value = "ค่าที่ต้องการส่งสำหรับตัวแปรที่ 1"
    '        '    OrderDt.Add(OrderDtDisVal)
    '        '    ' ส่งค่า ("DEPARTMENT" คือพารามิเตอร์ที่ต้องการให้แสดงครับ )
    '        '    CR.DataDefinition.ParameterFields("DEPARTMENT").ApplyCurrentValues(OrderDt)

    '        '    'ตัวแปรที่ 2 ( Parameter 2) เผื่อมีหลายๆตัวแปรครับ

    '        '    OrderDt = New ParameterValues
    '        '    OrderDtDisVal = New ParameterDiscreteValue()
    '        '    'Set OrderDate text field as the discrete value
    '        '    OrderDtDisVal.Value = "ค่าที่ต้องการส่งสำหรับตัวแปรที่ 2"
    '        '    OrderDt.Add(OrderDtDisVal)
    '        '    ' Apply current parameter values
    '        '    CR.DataDefinition.ParameterFields("BILLNO").ApplyCurrentValues(OrderDt)

    '        '    'Then I print the report using the PrintToPrinter method
    '        '    'ปริ้น ใช้ตามนี้เลยก็ได้ครับถ้าใช้แค่ 1 Copy
    '        '    CR.PrintToPrinter(1, False, 0, 0)
    '        'Catch ex As Exception
    '        '    MessageBox.Show(ex.Message, "Error Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        'End Try
    '        mdLoadCommitt()
    '    End If
    'End Sub

    'Private Sub PrintToPrinter()
    '    'Dim prd As New System.Drawing.Printing.PrintDocument
    '    'prd.PrinterSettings.PrinterName()
    '    'PrintReport(System.Windows.Forms.Application.StartupPath & "\crpReceiptInvoicePaper.rpt", PrinterSettings.PrinterName)
    'End Sub

    'Private Sub PrintReport(ByVal reportPath As String, ByVal PrinterName As String)
    '    Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
    '    rptDoc.Load(reportPath)

    '    Dim objPageMargins As CrystalDecisions.Shared.PageMargins
    '    objPageMargins = rptDoc.PrintOptions.PageMargins
    '    objPageMargins.bottomMargin = 100
    '    objPageMargins.leftMargin = 100
    '    objPageMargins.rightMargin = 100
    '    objPageMargins.topMargin = 100
    '    rptDoc.PrintOptions.ApplyPageMargins(objPageMargins)
    '    rptDoc.PrintOptions.PrinterName = PrinterName
    '    rptDoc.PrintToPrinter(1, False, 0, 0)
    'End Sub

    'Private Sub PrintReport(ByVal printerName As String)
    '    Dim margins As CrystalDecisions.Shared.PageMargins

    '    ' Get the PageMargins structure and set the 
    '    ' margins for the report.
    '    'margins = Report.PrintOptions.PageMargins
    '    'margins.bottomMargin = 350
    '    'margins.leftMargin = 350
    '    'margins.rightMargin = 350
    '    'margins.topMargin = 350
    '    ' Apply the page margins.
    '    Report.PrintOptions.ApplyPageMargins(margins)

    '    ' Select the printer.
    '    Report.PrintOptions.PrinterName = printerName

    '    ' Print the report. Set the startPageN and endPageN
    '    ' parameters to 0 to print all pages.
    '    Report.PrintToPrinter(1, False, 0, 0)
    'End Sub


    Private Sub btnNoVATpaper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoVATpaper.Click
        mdCnOpen()
        mdLoadShow()

        If Me.rdbReady.Checked = True Then

            '**** พิมพ์ใบเสร็จ : กระดาษต่อเนื่อง  (ปริ้นทันที)****'
            Dim count As Integer = 0
            Dim InvPaperDt As New DataTable
            InvPaperDt.Clear()

            '  If stBillTypeS = "8" Or stBillTypeS = "9" Then 'ขายสินค้ารวมทุกประเภท
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
            InvPaperDt.Columns.Add("PerBox", System.Type.GetType("System.Int32"))
            InvPaperDt.Columns.Add("idPkUnit", System.Type.GetType("System.Int32"))
            InvPaperDt.Columns.Add("idPsSale", System.Type.GetType("System.Int32"))
            InvPaperDt.Columns.Add("AddressS", System.Type.GetType("System.String"))
            InvPaperDt.Columns.Add("Note", System.Type.GetType("System.String"))
            InvPaperDt.Columns.Add("idTS", System.Type.GetType("System.Int32"))
            InvPaperDt.Columns.Add("ShortPkUnit", System.Type.GetType("System.String"))
            InvPaperDt.Columns.Add("DiscountAmout", System.Type.GetType("System.Double"))
            InvPaperDt.Columns.Add("DisCountPercAll", System.Type.GetType("System.Double"))

            '----- SmSaleDt ------'
            Dim sDt As New DataTable
            sDt.Clear()
            sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
                                     "ps.namea + ' ' +  '(' + ps.phone1+ ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
                                     "v.CusNameOwn, v.LastNameOwn, m.CusName, c.address, c.Tel, m.Transport, d.idPdPk, p.PdPkName, d.Amount, d.Price, " & _
                                     "d.DiscountPerc,  ISNULL(d.PerBox, 0) As Perbox, d.idPkUnit, m.idPsSale, m.AddressS, m.Note, m.idTS, " & _
                                     "u.ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM SmSaleDt d " & _
                                     "LEFT OUTER JOIN vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                     "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
                                     "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                     "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit " & _
                                     "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
                                     "WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt)

            For i As Integer = 0 To sDt.Rows.Count - 1
                Dim rc As Integer = InvPaperDt.Rows.Count
                InvPaperDt.Rows.Add()

                InvPaperDt.Rows(rc).Item("idSale") = sDt.Rows(i).Item("idSale")
                InvPaperDt.Rows(rc).Item("DocRef") = sDt.Rows(i).Item("DocRef")
                InvPaperDt.Rows(rc).Item("DateTs") = sDt.Rows(i).Item("DateTs")
                InvPaperDt.Rows(rc).Item("Payment") = sDt.Rows(i).Item("Payment")
                InvPaperDt.Rows(rc).Item("DatePay") = sDt.Rows(i).Item("DatePay")
                InvPaperDt.Rows(rc).Item("DateSale") = sDt.Rows(i).Item("DateSale")
                InvPaperDt.Rows(rc).Item("PsSaleName") = sDt.Rows(i).Item("PsSaleName")
                InvPaperDt.Rows(rc).Item("RegionName") = sDt.Rows(i).Item("RegionName")
                InvPaperDt.Rows(rc).Item("idCus") = sDt.Rows(i).Item("idCus")
                InvPaperDt.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusName")
                'If sDt.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt.Rows(i).Item("CusNameOwn") = "คุณ" & sDt.Rows(i).Item("CusNameOwn")
                '    End If
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusNameOwn") & " " & sDt.Rows(i).Item("LastNameOwn") & " (" & sDt.Rows(i).Item("CusName") & ")"
                'Else
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusName")
                'End If
                InvPaperDt.Rows(rc).Item("address") = sDt.Rows(i).Item("address")
                InvPaperDt.Rows(rc).Item("Tel") = sDt.Rows(i).Item("Tel")
                InvPaperDt.Rows(rc).Item("Transport") = sDt.Rows(i).Item("Transport")
                InvPaperDt.Rows(rc).Item("idPdPk") = sDt.Rows(i).Item("idPdPk")
                InvPaperDt.Rows(rc).Item("PdPkName") = sDt.Rows(i).Item("PdPkName")
                InvPaperDt.Rows(rc).Item("Amount") = sDt.Rows(i).Item("Amount")
                InvPaperDt.Rows(rc).Item("Price") = sDt.Rows(i).Item("Price")
                InvPaperDt.Rows(rc).Item("DiscountPerc") = sDt.Rows(i).Item("DiscountPerc")
                InvPaperDt.Rows(rc).Item("PerBox") = sDt.Rows(i).Item("PerBox")
                InvPaperDt.Rows(rc).Item("idPkUnit") = sDt.Rows(i).Item("idPkUnit")
                InvPaperDt.Rows(rc).Item("idPsSale") = sDt.Rows(i).Item("idPsSale")
                InvPaperDt.Rows(rc).Item("AddressS") = sDt.Rows(i).Item("AddressS")
                InvPaperDt.Rows(rc).Item("Note") = sDt.Rows(i).Item("Note")
                InvPaperDt.Rows(rc).Item("idTS") = sDt.Rows(i).Item("idTS")
                InvPaperDt.Rows(rc).Item("ShortPkUnit") = sDt.Rows(i).Item("ShortPkUnit")
                InvPaperDt.Rows(rc).Item("DiscountAmout") = sDt.Rows(i).Item("DiscountAmout")
                InvPaperDt.Rows(rc).Item("DisCountPercAll") = sDt.Rows(i).Item("DisCountPercAll")
            Next

            '----- SmSaleDtPd ------'
            Dim sDt2 As New DataTable
            sDt2.Clear()
            sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
                                    "ps.namea + ' ' +  '(' + ps.phone1+ ')' As PsSaleNmea, '' As RegionName, m.idCus, v.idPreName, " & _
                                     "v.CusNameOwn, v.LastNameOwn, m.CusName, c.address, c.Tel, m.Transport, d.idPdLot As idPdPk, " & _
                                     "d.PdNameBill As PdPkName, d.Amount, d.Price, d.DiscountPerc, 0 As PerBox, d.idUnit As idPkUnit, m.idPsSale, " & _
                                    "m.AddressS, m.Note, m.idTS, u.UnitW As ShortPkUnit, m.DiscountAmout, " & _
                                    "m.DiscountPerc As DisCountPercAll FROM SmSaleDtPd d " & _
                                    "LEFT OUTER JOIN vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                    "PkPdLotStock p ON d.idPdLot = p.idPdLot LEFT OUTER JOIN dCustomer c " & _
                                    "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                    "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
                                    "LEFT OUTER JOIN dUnitW u ON d.idUnit = u.idUnitW WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt2)

            For i As Integer = 0 To sDt2.Rows.Count - 1
                Dim rc As Integer = InvPaperDt.Rows.Count
                InvPaperDt.Rows.Add()

                InvPaperDt.Rows(rc).Item("idSale") = sDt2.Rows(i).Item("idSale")
                InvPaperDt.Rows(rc).Item("DocRef") = sDt2.Rows(i).Item("DocRef")
                InvPaperDt.Rows(rc).Item("DateTs") = sDt2.Rows(i).Item("DateTs")
                InvPaperDt.Rows(rc).Item("Payment") = sDt2.Rows(i).Item("Payment")
                InvPaperDt.Rows(rc).Item("DatePay") = sDt2.Rows(i).Item("DatePay")
                InvPaperDt.Rows(rc).Item("DateSale") = sDt2.Rows(i).Item("DateSale")
                InvPaperDt.Rows(rc).Item("PsSaleName") = sDt2.Rows(i).Item("PsSaleNmea")
                InvPaperDt.Rows(rc).Item("RegionName") = sDt2.Rows(i).Item("RegionName")
                InvPaperDt.Rows(rc).Item("idCus") = sDt2.Rows(i).Item("idCus")
                InvPaperDt.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusName")
                'If sDt2.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt2.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt2.Rows(i).Item("CusNameOwn") = "คุณ" & sDt2.Rows(i).Item("CusNameOwn")
                '    End If
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusNameOwn") & " " & sDt2.Rows(i).Item("LastNameOwn") & " (" & sDt2.Rows(i).Item("CusName") & ")"
                'Else
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusName")
                'End If
                InvPaperDt.Rows(rc).Item("address") = sDt2.Rows(i).Item("address")
                InvPaperDt.Rows(rc).Item("Tel") = sDt2.Rows(i).Item("Tel")
                InvPaperDt.Rows(rc).Item("Transport") = sDt2.Rows(i).Item("Transport")
                InvPaperDt.Rows(rc).Item("idPdPk") = sDt2.Rows(i).Item("idPdPk")
                InvPaperDt.Rows(rc).Item("PdPkName") = sDt2.Rows(i).Item("PdPkName")
                InvPaperDt.Rows(rc).Item("Amount") = sDt2.Rows(i).Item("Amount")
                InvPaperDt.Rows(rc).Item("Price") = sDt2.Rows(i).Item("Price")
                InvPaperDt.Rows(rc).Item("DiscountPerc") = sDt2.Rows(i).Item("DiscountPerc")
                InvPaperDt.Rows(rc).Item("PerBox") = sDt2.Rows(i).Item("PerBox")
                InvPaperDt.Rows(rc).Item("idPkUnit") = sDt2.Rows(i).Item("idPkUnit")
                InvPaperDt.Rows(rc).Item("idPsSale") = sDt2.Rows(i).Item("idPsSale")
                InvPaperDt.Rows(rc).Item("AddressS") = sDt2.Rows(i).Item("AddressS")
                InvPaperDt.Rows(rc).Item("Note") = sDt2.Rows(i).Item("Note")
                InvPaperDt.Rows(rc).Item("idTS") = sDt2.Rows(i).Item("idTS")
                InvPaperDt.Rows(rc).Item("ShortPkUnit") = sDt2.Rows(i).Item("ShortPkUnit")
                InvPaperDt.Rows(rc).Item("DiscountAmout") = sDt2.Rows(i).Item("DiscountAmout")
                InvPaperDt.Rows(rc).Item("DisCountPercAll") = sDt2.Rows(i).Item("DisCountPercAll")
            Next

            '----- SmSaleDtOther ------'
            Dim sDt3 As New DataTable
            sDt3.Clear()
            sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
                                     "ps.namea + ' ' +  '(' + ps.phone1+ ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
                                     "v.CusNameOwn, v.LastNameOwn, m.CusName, c.address, c.Tel, m.Transport, d.idPdo As idPdPk, p.Title As PdPkName, " & _
                                     "d.Amount, d.Price, d.DiscountPerc, ISNULL(d.PerBox, 0) As Perbox, d.idUnit As idPkUnit, m.idPsSale, " & _
                                     "m.AddressS, m.Note, m.idTS, u.UnitName As ShortPkUnit, m.DiscountAmout, " & _
                                     "m.DiscountPerc As DisCountPercAll FROM SmSaleDtOther d " & _
                                     "LEFT OUTER JOIN vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                     "SmPdOtherD p ON d.idPdo = p.idPdo LEFT OUTER JOIN dCustomer c " & _
                                     "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                     "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
                                     "LEFT OUTER JOIN PchInvAndProject.dbo.dInvUnit u ON d.idUnit = u.idUnit WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt3)

            For i As Integer = 0 To sDt3.Rows.Count - 1
                Dim rc As Integer = InvPaperDt.Rows.Count
                InvPaperDt.Rows.Add()

                InvPaperDt.Rows(rc).Item("idSale") = sDt3.Rows(i).Item("idSale")
                InvPaperDt.Rows(rc).Item("DocRef") = sDt3.Rows(i).Item("DocRef")
                InvPaperDt.Rows(rc).Item("DateTs") = sDt3.Rows(i).Item("DateTs")
                InvPaperDt.Rows(rc).Item("Payment") = sDt3.Rows(i).Item("Payment")
                InvPaperDt.Rows(rc).Item("DatePay") = sDt3.Rows(i).Item("DatePay")
                InvPaperDt.Rows(rc).Item("DateSale") = sDt3.Rows(i).Item("DateSale")
                InvPaperDt.Rows(rc).Item("PsSaleName") = sDt3.Rows(i).Item("PsSaleName")
                InvPaperDt.Rows(rc).Item("RegionName") = sDt3.Rows(i).Item("RegionName")
                InvPaperDt.Rows(rc).Item("idCus") = sDt3.Rows(i).Item("idCus")
                InvPaperDt.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
                'If sDt3.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt3.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt3.Rows(i).Item("CusNameOwn") = "คุณ" & sDt3.Rows(i).Item("CusNameOwn")
                '    End If
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusNameOwn") & " " & sDt3.Rows(i).Item("LastNameOwn") & " (" & sDt3.Rows(i).Item("CusName") & ")"
                'Else
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
                'End If
                InvPaperDt.Rows(rc).Item("address") = sDt3.Rows(i).Item("address")
                InvPaperDt.Rows(rc).Item("Tel") = sDt3.Rows(i).Item("Tel")
                InvPaperDt.Rows(rc).Item("Transport") = sDt3.Rows(i).Item("Transport")
                InvPaperDt.Rows(rc).Item("idPdPk") = sDt3.Rows(i).Item("idPdPk")
                InvPaperDt.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("PdPkName")
                InvPaperDt.Rows(rc).Item("Amount") = sDt3.Rows(i).Item("Amount")
                InvPaperDt.Rows(rc).Item("Price") = sDt3.Rows(i).Item("Price")
                InvPaperDt.Rows(rc).Item("DiscountPerc") = sDt3.Rows(i).Item("DiscountPerc")
                InvPaperDt.Rows(rc).Item("PerBox") = sDt3.Rows(i).Item("PerBox")
                InvPaperDt.Rows(rc).Item("idPkUnit") = sDt3.Rows(i).Item("idPkUnit")
                InvPaperDt.Rows(rc).Item("idPsSale") = sDt3.Rows(i).Item("idPsSale")
                InvPaperDt.Rows(rc).Item("AddressS") = sDt3.Rows(i).Item("AddressS")
                InvPaperDt.Rows(rc).Item("Note") = sDt3.Rows(i).Item("Note")
                InvPaperDt.Rows(rc).Item("idTS") = sDt3.Rows(i).Item("idTS")
                InvPaperDt.Rows(rc).Item("ShortPkUnit") = sDt3.Rows(i).Item("ShortPkUnit")
                InvPaperDt.Rows(rc).Item("DiscountAmout") = sDt3.Rows(i).Item("DiscountAmout")
                InvPaperDt.Rows(rc).Item("DisCountPercAll") = sDt3.Rows(i).Item("DisCountPercAll")
            Next


            'Else  ' Other Bill Sale
            '    If stBillTypeS = "4" Then 'ขายสินค้าอื่นๆ
            '        sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
            '                             "ps.namea + ' ' +  '(' + ps.phone1+ ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
            '                             "v.CusNameOwn, v.LastNameOwn, m.CusName, c.address, c.Tel, m.Transport, d.idPdo As idPdPk, p.Title As PdPkName, " & _
            '                             "d.Amount, d.Price, d.DiscountPerc, ISNULL(d.PerBox, 0) As Perbox, d.idUnit As idPkUnit, m.idPsSale, " & _
            '                             "c.AddressS, m.Note, m.idTS, " & _
            '                             "u.UnitName As ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM vSmSaleMt m " & _
            '                             "LEFT OUTER JOIN SmSaleDtOther d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                             "SmPdOtherD p ON d.idPdo = p.idPdo LEFT OUTER JOIN dCustomer c " & _
            '                             "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                             "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
            '                             "LEFT OUTER JOIN PchInvAndProject.dbo.dInvUnit u ON d.idUnit = u.idUnit WHERE m.idSale ='" & idSaleS & "'"

            '    ElseIf stBillTypeS = "7" Then 'ขายเมล็ด
            '        sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
            '                            "ps.namea + ' ' +  '(' + ps.phone1+ ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
            '                             "v.CusNameOwn, v.LastNameOwn, m.CusName, c.address, c.Tel, m.Transport, d.idPdLot As idPdPk, " & _
            '                             "d.PdNameBill As PdPkName, d.Amount, d.Price, d.DiscountPerc, 0 As PerBox, d.idUnit As idPkUnit, m.idPsSale, " & _
            '                            "c.AddressS, m.Note, m.idTS, " & _
            '                            "u.UnitW As ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM vSmSaleMt m " & _
            '                            "LEFT OUTER JOIN SmSaleDtPd d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                            "PkPdLotStock p ON d.idPdLot = p.idPdLot LEFT OUTER JOIN dCustomer c " & _
            '                            "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                            "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
            '                            "LEFT OUTER JOIN dUnitW u ON d.idUnit = u.idUnitW WHERE m.idSale ='" & idSaleS & "'"
            '    Else 'Normal Sale
            '        sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
            '                             "ps.namea + ' ' +  '(' + ps.phone1+ ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
            '                             "v.CusNameOwn, v.LastNameOwn, m.CusName, c.address, c.Tel, m.Transport, d.idPdPk, p.PdPkName, d.Amount, d.Price, " & _
            '                             "d.DiscountPerc,  ISNULL(d.PerBox, 0) As Perbox, d.idPkUnit, m.idPsSale, c.AddressS, m.Note, m.idTS, " & _
            '                             "u.ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM vSmSaleMt m " & _
            '                             "LEFT OUTER JOIN SmSaleDt d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                             "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
            '                             "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                             "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit " & _
            '                             "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
            '                             "WHERE m.idSale ='" & idSaleS & "'"
            '    End If

            '    sAdapter.Fill(InvPaperDt)

            '    'For i As Integer = 0 To InvPaperDt.Rows.Count - 1
            '    '    If InvPaperDt.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
            '    '        If InvPaperDt.Rows(i).Item("CusNameOwn") <> "" Then
            '    '            InvPaperDt.Rows(i).Item("CusNameOwn") = "คุณ" & InvPaperDt.Rows(i).Item("CusNameOwn")
            '    '        End If
            '    '        InvPaperDt.Rows(i).Item("CusName") = InvPaperDt.Rows(i).Item("CusNameOwn") & " " & InvPaperDt.Rows(i).Item("LastNameOwn") & " (" & InvPaperDt.Rows(i).Item("CusName") & ")"
            '    '    Else
            '    '        InvPaperDt.Rows(i).Item("CusName") = InvPaperDt.Rows(i).Item("CusName")
            '    '    End If
            '    'Next
            'End If


            For i As Integer = 0 To InvPaperDt.Rows.Count - 1
                InvPaperDt.Rows(i).Item("DateTs") = ksbStringToDate(InvPaperDt.Rows(i).Item("DateTs"))
                InvPaperDt.Rows(i).Item("DateSale") = ksbStringToDate(InvPaperDt.Rows(i).Item("DateSale"))
                InvPaperDt.Rows(i).Item("DatePay") = ksbStringToDate(InvPaperDt.Rows(i).Item("DatePay"))
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

                'If InvPaperDt.Rows(i).Item("DiscountAmout") = 0.0 Then
                '    InvPaperDt.Rows(i).Item("DiscountAmout") = 0
                'End If
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
                InvPaperDt.Rows(0).Item("RegionName") = Regionlist

                If IsDBNull(InvPaperDt.Rows(i).Item("PerBox")) Then
                    InvPaperDt.Rows(i).Item("PerBox") = 0
                End If

                If InvPaperDt.Rows(i).Item("idPkUnit") = 3 Then 'กล่อง
                    InvPaperDt.Rows(i).Item("Price") = InvPaperDt.Rows(i).Item("Price") * InvPaperDt.Rows(i).Item("PerBox")
                End If


                If IsDBNull(InvPaperDt.Rows(i).Item("DiscountPerc")) Then
                    InvPaperDt.Rows(i).Item("DiscountPerc") = 0
                End If
            Next


            Dim j As Integer
            Dim vRpt As New crpReceiptInvoicePaperSetUp
            vRpt.SetDataSource(InvPaperDt)


            Dim printDocument As New System.Drawing.Printing.PrintDocument
            vRpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName
            'vRpt.PrintOptions.de()

            Dim rawKind As Integer
            For j = 0 To printDocument.PrinterSettings.PaperSizes.Count - 1
                If printDocument.PrinterSettings.PaperSizes(j).PaperName = "A4" Then
                    rawKind = CInt(printDocument.PrinterSettings.PaperSizes(j).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(printDocument.PrinterSettings.PaperSizes(j)))
                    Exit For
                End If
            Next
            vRpt.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
            vRpt.PrintToPrinter(1, False, 0, 0)

        ElseIf Me.rdbPreview.Checked = True Then
            '**** พิมพ์ใบเสร็จ : กระดาษต่อเนื่อง  (Preview)****-

            Dim InvPaperDt As New DataTable
            InvPaperDt.Clear()

            ' If stBillTypeS = "8" Or stBillTypeS = "9" Then 'ขายสินค้ารวมทุกประเภท
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
            InvPaperDt.Columns.Add("PerBox", System.Type.GetType("System.Int32"))
            InvPaperDt.Columns.Add("idPkUnit", System.Type.GetType("System.Int32"))
            InvPaperDt.Columns.Add("idPsSale", System.Type.GetType("System.Int32"))
            InvPaperDt.Columns.Add("AddressS", System.Type.GetType("System.String"))
            InvPaperDt.Columns.Add("Note", System.Type.GetType("System.String"))
            InvPaperDt.Columns.Add("idTS", System.Type.GetType("System.Int32"))
            InvPaperDt.Columns.Add("ShortPkUnit", System.Type.GetType("System.String"))
            InvPaperDt.Columns.Add("DiscountAmout", System.Type.GetType("System.Double"))
            InvPaperDt.Columns.Add("DisCountPercAll", System.Type.GetType("System.Double"))

            '----- SmSaleDt ------'
            Dim sDt As New DataTable
            sDt.Clear()
            sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
                                     "ps.namea + ' ' +  '(' + ps.phone1+ ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
                                     "v.CusNameOwn, v.LastNameOwn, m.CusName, c.address, c.Tel, m.Transport, d.idPdPk, p.PdPkName, d.Amount, d.Price, " & _
                                     "d.DiscountPerc,  ISNULL(d.PerBox, 0) As Perbox, d.idPkUnit, m.idPsSale, c.AddressS, m.Note, m.idTS, " & _
                                     "u.ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM SmSaleDt d " & _
                                     "LEFT OUTER JOIN vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                     "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
                                     "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                     "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit " & _
                                     "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
                                     "WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt)

            For i As Integer = 0 To sDt.Rows.Count - 1
                Dim rc As Integer = InvPaperDt.Rows.Count
                InvPaperDt.Rows.Add()

                InvPaperDt.Rows(rc).Item("idSale") = sDt.Rows(i).Item("idSale")
                InvPaperDt.Rows(rc).Item("DocRef") = sDt.Rows(i).Item("DocRef")
                InvPaperDt.Rows(rc).Item("DateTs") = sDt.Rows(i).Item("DateTs")
                InvPaperDt.Rows(rc).Item("Payment") = sDt.Rows(i).Item("Payment")
                InvPaperDt.Rows(rc).Item("DatePay") = sDt.Rows(i).Item("DatePay")
                InvPaperDt.Rows(rc).Item("DateSale") = sDt.Rows(i).Item("DateSale")
                InvPaperDt.Rows(rc).Item("PsSaleName") = sDt.Rows(i).Item("PsSaleName")
                InvPaperDt.Rows(rc).Item("RegionName") = sDt.Rows(i).Item("RegionName")
                InvPaperDt.Rows(rc).Item("idCus") = sDt.Rows(i).Item("idCus")
                InvPaperDt.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusName")
                'If sDt.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt.Rows(i).Item("CusNameOwn") = "คุณ" & sDt.Rows(i).Item("CusNameOwn")
                '    End If
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusNameOwn") & " " & sDt.Rows(i).Item("LastNameOwn") & " (" & sDt.Rows(i).Item("CusName") & ")"
                'Else
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusName")
                'End If
                InvPaperDt.Rows(rc).Item("address") = sDt.Rows(i).Item("address")
                InvPaperDt.Rows(rc).Item("Tel") = sDt.Rows(i).Item("Tel")
                InvPaperDt.Rows(rc).Item("Transport") = sDt.Rows(i).Item("Transport")
                InvPaperDt.Rows(rc).Item("idPdPk") = sDt.Rows(i).Item("idPdPk")
                InvPaperDt.Rows(rc).Item("PdPkName") = sDt.Rows(i).Item("PdPkName")
                InvPaperDt.Rows(rc).Item("Amount") = sDt.Rows(i).Item("Amount")
                InvPaperDt.Rows(rc).Item("Price") = sDt.Rows(i).Item("Price")
                InvPaperDt.Rows(rc).Item("DiscountPerc") = sDt.Rows(i).Item("DiscountPerc")
                InvPaperDt.Rows(rc).Item("PerBox") = sDt.Rows(i).Item("PerBox")
                InvPaperDt.Rows(rc).Item("idPkUnit") = sDt.Rows(i).Item("idPkUnit")
                InvPaperDt.Rows(rc).Item("idPsSale") = sDt.Rows(i).Item("idPsSale")
                InvPaperDt.Rows(rc).Item("AddressS") = sDt.Rows(i).Item("AddressS")
                InvPaperDt.Rows(rc).Item("Note") = sDt.Rows(i).Item("Note")
                InvPaperDt.Rows(rc).Item("idTS") = sDt.Rows(i).Item("idTS")
                InvPaperDt.Rows(rc).Item("ShortPkUnit") = sDt.Rows(i).Item("ShortPkUnit")
                InvPaperDt.Rows(rc).Item("DiscountAmout") = sDt.Rows(i).Item("DiscountAmout")
                InvPaperDt.Rows(rc).Item("DisCountPercAll") = sDt.Rows(i).Item("DisCountPercAll")
            Next

            '----- SmSaleDtPd ------'
            Dim sDt2 As New DataTable
            sDt2.Clear()
            sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
                                    "ps.namea + ' ' +  '(' + ps.phone1+ ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
                                     "v.CusNameOwn, v.LastNameOwn, m.CusName, c.address, c.Tel, m.Transport, d.idPdLot As idPdPk, " & _
                                     "d.PdNameBill As PdPkName, d.Amount, d.Price, d.DiscountPerc, 0 As PerBox, d.idUnit As idPkUnit, m.idPsSale, " & _
                                    "c.AddressS, m.Note, m.idTS, " & _
                                    "u.UnitW As ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM SmSaleDtPd d " & _
                                    "LEFT OUTER JOIN vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                    "PkPdLotStock p ON d.idPdLot = p.idPdLot LEFT OUTER JOIN dCustomer c " & _
                                    "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                    "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
                                    "LEFT OUTER JOIN dUnitW u ON d.idUnit = u.idUnitW WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt2)

            For i As Integer = 0 To sDt2.Rows.Count - 1
                Dim rc As Integer = InvPaperDt.Rows.Count
                InvPaperDt.Rows.Add()

                InvPaperDt.Rows(rc).Item("idSale") = sDt2.Rows(i).Item("idSale")
                InvPaperDt.Rows(rc).Item("DocRef") = sDt2.Rows(i).Item("DocRef")
                InvPaperDt.Rows(rc).Item("DateTs") = sDt2.Rows(i).Item("DateTs")
                InvPaperDt.Rows(rc).Item("Payment") = sDt2.Rows(i).Item("Payment")
                InvPaperDt.Rows(rc).Item("DatePay") = sDt2.Rows(i).Item("DatePay")
                InvPaperDt.Rows(rc).Item("DateSale") = sDt2.Rows(i).Item("DateSale")
                InvPaperDt.Rows(rc).Item("PsSaleName") = sDt2.Rows(i).Item("PsSaleName")
                InvPaperDt.Rows(rc).Item("RegionName") = sDt2.Rows(i).Item("RegionName")
                InvPaperDt.Rows(rc).Item("idCus") = sDt2.Rows(i).Item("idCus")
                InvPaperDt.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusName")
                'If sDt2.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt2.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt2.Rows(i).Item("CusNameOwn") = "คุณ" & sDt2.Rows(i).Item("CusNameOwn")
                '    End If
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusNameOwn") & " " & sDt2.Rows(i).Item("LastNameOwn") & " (" & sDt2.Rows(i).Item("CusName") & ")"
                'Else
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusName")
                'End If
                InvPaperDt.Rows(rc).Item("address") = sDt2.Rows(i).Item("address")
                InvPaperDt.Rows(rc).Item("Tel") = sDt2.Rows(i).Item("Tel")
                InvPaperDt.Rows(rc).Item("Transport") = sDt2.Rows(i).Item("Transport")
                InvPaperDt.Rows(rc).Item("idPdPk") = sDt2.Rows(i).Item("idPdPk")
                InvPaperDt.Rows(rc).Item("PdPkName") = sDt2.Rows(i).Item("PdPkName")
                InvPaperDt.Rows(rc).Item("Amount") = sDt2.Rows(i).Item("Amount")
                InvPaperDt.Rows(rc).Item("Price") = sDt2.Rows(i).Item("Price")
                InvPaperDt.Rows(rc).Item("DiscountPerc") = sDt2.Rows(i).Item("DiscountPerc")
                InvPaperDt.Rows(rc).Item("PerBox") = sDt2.Rows(i).Item("PerBox")
                InvPaperDt.Rows(rc).Item("idPkUnit") = sDt2.Rows(i).Item("idPkUnit")
                InvPaperDt.Rows(rc).Item("idPsSale") = sDt2.Rows(i).Item("idPsSale")
                InvPaperDt.Rows(rc).Item("AddressS") = sDt2.Rows(i).Item("AddressS")
                InvPaperDt.Rows(rc).Item("Note") = sDt2.Rows(i).Item("Note")
                InvPaperDt.Rows(rc).Item("idTS") = sDt2.Rows(i).Item("idTS")
                InvPaperDt.Rows(rc).Item("ShortPkUnit") = sDt2.Rows(i).Item("ShortPkUnit")
                InvPaperDt.Rows(rc).Item("DiscountAmout") = sDt2.Rows(i).Item("DiscountAmout")
                InvPaperDt.Rows(rc).Item("DisCountPercAll") = sDt2.Rows(i).Item("DisCountPercAll")
            Next

            '----- SmSaleDtOther ------'
            Dim sDt3 As New DataTable
            sDt3.Clear()
            sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
                                     "ps.namea + ' ' +  '(' + ps.phone1+ ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
                                     "v.CusNameOwn, v.LastNameOwn, m.CusName, c.address, c.Tel, m.Transport, d.idPdo As idPdPk, p.Title As PdPkName, " & _
                                     "d.Amount, d.Price, d.DiscountPerc, ISNULL(d.PerBox,0) As Perbox , d.idUnit As idPkUnit, m.idPsSale, " & _
                                     "c.AddressS, m.Note, m.idTS, " & _
                                     "u.UnitName As ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM SmSaleDtOther d " & _
                                     "LEFT OUTER JOIN vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                     "SmPdOtherD p ON d.idPdo = p.idPdo LEFT OUTER JOIN dCustomer c " & _
                                     "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                     "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
                                     "LEFT OUTER JOIN PchInvAndProject.dbo.dInvUnit u ON d.idUnit = u.idUnit WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt3)

            For i As Integer = 0 To sDt3.Rows.Count - 1
                Dim rc As Integer = InvPaperDt.Rows.Count
                InvPaperDt.Rows.Add()

                InvPaperDt.Rows(rc).Item("idSale") = sDt3.Rows(i).Item("idSale")
                InvPaperDt.Rows(rc).Item("DocRef") = sDt3.Rows(i).Item("DocRef")
                InvPaperDt.Rows(rc).Item("DateTs") = sDt3.Rows(i).Item("DateTs")
                InvPaperDt.Rows(rc).Item("Payment") = sDt3.Rows(i).Item("Payment")
                InvPaperDt.Rows(rc).Item("DatePay") = sDt3.Rows(i).Item("DatePay")
                InvPaperDt.Rows(rc).Item("DateSale") = sDt3.Rows(i).Item("DateSale")
                InvPaperDt.Rows(rc).Item("PsSaleName") = sDt3.Rows(i).Item("PsSaleName")
                InvPaperDt.Rows(rc).Item("RegionName") = sDt3.Rows(i).Item("RegionName")
                InvPaperDt.Rows(rc).Item("idCus") = sDt3.Rows(i).Item("idCus")
                InvPaperDt.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
                'If sDt3.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt3.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt3.Rows(i).Item("CusNameOwn") = "คุณ" & sDt3.Rows(i).Item("CusNameOwn")
                '    End If
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusNameOwn") & " " & sDt3.Rows(i).Item("LastNameOwn") & " (" & sDt3.Rows(i).Item("CusName") & ")"
                'Else
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusName")
                'End If
                InvPaperDt.Rows(rc).Item("address") = sDt3.Rows(i).Item("address")
                InvPaperDt.Rows(rc).Item("Tel") = sDt3.Rows(i).Item("Tel")
                InvPaperDt.Rows(rc).Item("Transport") = sDt3.Rows(i).Item("Transport")
                InvPaperDt.Rows(rc).Item("idPdPk") = sDt3.Rows(i).Item("idPdPk")
                InvPaperDt.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("PdPkName")
                InvPaperDt.Rows(rc).Item("Amount") = sDt3.Rows(i).Item("Amount")
                InvPaperDt.Rows(rc).Item("Price") = sDt3.Rows(i).Item("Price")
                InvPaperDt.Rows(rc).Item("DiscountPerc") = sDt3.Rows(i).Item("DiscountPerc")
                InvPaperDt.Rows(rc).Item("PerBox") = sDt3.Rows(i).Item("PerBox")
                InvPaperDt.Rows(rc).Item("idPkUnit") = sDt3.Rows(i).Item("idPkUnit")
                InvPaperDt.Rows(rc).Item("idPsSale") = sDt3.Rows(i).Item("idPsSale")
                InvPaperDt.Rows(rc).Item("AddressS") = sDt3.Rows(i).Item("AddressS")
                InvPaperDt.Rows(rc).Item("Note") = sDt3.Rows(i).Item("Note")
                InvPaperDt.Rows(rc).Item("idTS") = sDt3.Rows(i).Item("idTS")
                InvPaperDt.Rows(rc).Item("ShortPkUnit") = sDt3.Rows(i).Item("ShortPkUnit")
                InvPaperDt.Rows(rc).Item("DiscountAmout") = sDt3.Rows(i).Item("DiscountAmout")
                InvPaperDt.Rows(rc).Item("DisCountPercAll") = sDt3.Rows(i).Item("DisCountPercAll")
            Next


            'Else 'Other Bill Sale

            '    If stBillTypeS = "4" Then 'ขายสินค้าอื่นๆ
            '        sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
            '                             "ps.namea + ' ' +  '(' + ps.phone1+ ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
            '                             "v.CusNameOwn, v.LastNameOwn, m.CusName, c.address, c.Tel, m.Transport, d.idPdo As idPdPk, p.Title As PdPkName, " & _
            '                             "d.Amount, d.Price, d.DiscountPerc, ISNULL(d.PerBox, 0) As Perbox, d.idUnit As idPkUnit, m.idPsSale, " & _
            '                             "c.AddressS, m.Note, m.idTS, " & _
            '                             " u.UnitName As ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM vSmSaleMt m " & _
            '                             "LEFT OUTER JOIN SmSaleDtOther d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                             "SmPdOtherD p ON d.idPdo = p.idPdo LEFT OUTER JOIN dCustomer c " & _
            '                             "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                             "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
            '                             "LEFT OUTER JOIN PchInvAndProject.dbo.dInvUnit u ON d.idUnit = u.idUnit WHERE m.idSale ='" & idSaleS & "'"

            '    ElseIf stBillTypeS = "7" Then  ' ขายเมล็ด
            '        sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
            '                            "ps.namea + ' ' +  '(' + ps.phone1 + ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
            '                             "v.CusNameOwn, v.LastNameOwn, m.CusName, c.address, c.Tel, m.Transport, d.idPdLot As idPdPk, " & _
            '                             "d.PdNameBill As PdPkName, d.Amount, d.Price, d.DiscountPerc, 0 As PerBox, d.idUnit As idPkUnit, m.idPsSale, " & _
            '                            "c.AddressS, m.Note, m.idTS, " & _
            '                            "u.UnitW As ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM vSmSaleMt m " & _
            '                            "LEFT OUTER JOIN SmSaleDtPd d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                            "PkPdLotStock p ON d.idPdLot = p.idPdLot LEFT OUTER JOIN dCustomer c " & _
            '                            "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                            "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
            '                            "LEFT OUTER JOIN dUnitW u ON d.idUnit = u.idUnitW WHERE m.idSale ='" & idSaleS & "'"
            '    Else 'Normal Sale
            '        sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
            '                             "ps.namea + ' ' +  '(' + ps.phone1 + ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
            '                             "v.CusNameOwn, v.LastNameOwn, m.CusName, c.address, c.Tel, m.Transport, d.idPdPk, p.PdPkName, d.Amount, d.Price, " & _
            '                             "d.DiscountPerc,  ISNUll(d.PerBox,0) As Perbox, d.idPkUnit, m.idPsSale, c.AddressS, m.Note, m.idTS, " & _
            '                             "u.ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM vSmSaleMt m " & _
            '                             "LEFT OUTER JOIN SmSaleDt d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                             "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
            '                             "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                             "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit " & _
            '                             "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
            '                             "WHERE m.idSale ='" & idSaleS & "'"
            '    End If

            '    sAdapter.Fill(InvPaperDt)

            '    'For i As Integer = 0 To InvPaperDt.Rows.Count - 1
            '    '    If InvPaperDt.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
            '    '        If InvPaperDt.Rows(i).Item("CusNameOwn") <> "" Then
            '    '            InvPaperDt.Rows(i).Item("CusNameOwn") = "คุณ" & InvPaperDt.Rows(i).Item("CusNameOwn")
            '    '        End If
            '    '        InvPaperDt.Rows(i).Item("CusName") = InvPaperDt.Rows(i).Item("CusNameOwn") & " " & InvPaperDt.Rows(i).Item("LastNameOwn") & " (" & InvPaperDt.Rows(i).Item("CusName") & ")"
            '    '    Else
            '    '        InvPaperDt.Rows(i).Item("CusName") = InvPaperDt.Rows(i).Item("CusName")
            '    '    End If
            '    'Next

            'End If


            For i As Integer = 0 To InvPaperDt.Rows.Count - 1
                InvPaperDt.Rows(i).Item("DateTs") = ksbStringToDate(InvPaperDt.Rows(i).Item("DateTs"))
                InvPaperDt.Rows(i).Item("DateSale") = ksbStringToDate(InvPaperDt.Rows(i).Item("DateSale"))
                InvPaperDt.Rows(i).Item("DatePay") = ksbStringToDate(InvPaperDt.Rows(i).Item("DatePay"))

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

                'If InvPaperDt.Rows(i).Item("DiscountAmout") = 0.0 Then
                '    InvPaperDt.Rows(i).Item("DiscountAmout") = 0
                'End If
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

                If InvPaperDt.Rows(i).Item("idPkUnit") = 3 Then 'กล่อง
                    InvPaperDt.Rows(i).Item("Price") = InvPaperDt.Rows(i).Item("Price") * InvPaperDt.Rows(i).Item("PerBox")
                End If


                If IsDBNull(InvPaperDt.Rows(i).Item("DiscountPerc")) Then
                    InvPaperDt.Rows(i).Item("DiscountPerc") = 0
                End If
            Next


            Dim vRpt As New crpReceiptInvoicePaper
            vRpt.SetDataSource(InvPaperDt)
            vRpt.SetParameterValue(vRpt.Parameter_stPayment.ParameterFieldName, 0)
            'vRpt.PrintOptions = no Printer
            'vRpt.PrintOptions.PaperSize = CType(getPaperSize("9.5 x 11 in").RawKind, CrystalDecisions.Shared.PaperSize)

            'Dim k As Integer = 0
            'Dim printDocument As New System.Drawing.Printing.PrintDocument
            'vRpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName

            'Dim rawKind As Integer
            'For k = 0 To printDocument.PrinterSettings.PaperSizes.Count - 1
            '    If printDocument.PrinterSettings.PaperSizes(k).PaperName = "9.5 x 11 in" Then
            '        rawKind = CInt(printDocument.PrinterSettings.PaperSizes(k).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(printDocument.PrinterSettings.PaperSizes(k)))
            '        Exit For
            '    End If
            'Next
            'vRpt.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
            'vRpt.PrintToPrinter(0, False, 1, 1)
            'Me.CrystalReportViewer1.ReportSource = vRpt
            ''mdLoadCommitt()
            ''CrystalReportViewer1.PrintReport()
            Dim vFrm As New FrmReportView
            vFrm.crView.ShowGroupTreeButton = False
            vFrm.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            vFrm.crView.ReportSource = vRpt
            vFrm.Show()

            'vFrm.crView.PrintReport()
        End If
        mdLoadCommitt()

    End Sub


    Public Function getPaperSize(ByVal sizeName As String) As System.Drawing.Printing.PaperSize
        Dim i As Integer = 0
        Dim PSize As New System.Drawing.Printing.PaperSize
        Dim printDoc As New System.Drawing.Printing.PrintDocument
        Dim pd As New System.Drawing.Printing.PrintDocument
        For i = 0 To printDoc.PrinterSettings.PaperSizes.Count - 1
            If (printDoc.PrinterSettings.PaperSizes(i).PaperName = sizeName) Then
                PSize = printDoc.PrinterSettings.PaperSizes(i)
            End If
            i += 1
        Next
        Return PSize
    End Function

    Private Sub rdbBorrow_CheckedChanged(sender As Object, e As EventArgs) Handles rdbBorrow.CheckedChanged
        If Me.rdbBorrow.Checked = True And stload = 1 Then
            mdCnOpen()
            mdLoadShow()

            '**** พิมพ์ใบเสร็จ : กระดาษต่อเนื่อง  (Preview)****-
            Dim InvPaperDt As New DataTable
            InvPaperDt.Clear()

            '  If stBillTypeS = "8" Or stBillTypeS = "9" Then  ' ขายสินค้ารวมทุกประเภท
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
            InvPaperDt.Columns.Add("PerBox", System.Type.GetType("System.Int32"))
            InvPaperDt.Columns.Add("idPkUnit", System.Type.GetType("System.Int32"))
            InvPaperDt.Columns.Add("idPsSale", System.Type.GetType("System.Int32"))
            InvPaperDt.Columns.Add("AddressS", System.Type.GetType("System.String"))
            InvPaperDt.Columns.Add("Note", System.Type.GetType("System.String"))
            InvPaperDt.Columns.Add("idTS", System.Type.GetType("System.Int32"))
            InvPaperDt.Columns.Add("ShortPkUnit", System.Type.GetType("System.String"))
            InvPaperDt.Columns.Add("DiscountAmout", System.Type.GetType("System.Double"))
            InvPaperDt.Columns.Add("DisCountPercAll", System.Type.GetType("System.Double"))

            '----- SmSaleDt ------'
            Dim sDt As New DataTable
            sDt.Clear()
            sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
                                     "ps.namea + ' ' +  '(' + ps.phone1 + ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
                                     "v.CusNameOwn, v.LastNameOwn, m.CusName, " & _
                                     "c.address, c.Tel, m.Transport, d.idPdPk, p.PdPkName, d.Amount, d.Price, " & _
                                     "d.DiscountPerc,  ISNULL(d.PerBox, 0) As Perbox, d.idPkUnit, m.idPsSale, m.AddressS, m.Note, m.idTS, " & _
                                     "u.ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM SmSaleDt d  " & _
                                     "LEFT OUTER JOIN vSmSaleMt m  ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                     "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
                                     "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                     "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit " & _
                                     "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
                                     "WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt)

            For i As Integer = 0 To sDt.Rows.Count - 1
                Dim rc As Integer = InvPaperDt.Rows.Count
                InvPaperDt.Rows.Add()
                InvPaperDt.Rows(rc).Item("idSale") = sDt.Rows(i).Item("idSale")
                InvPaperDt.Rows(rc).Item("DocRef") = sDt.Rows(i).Item("DocRef")
                InvPaperDt.Rows(rc).Item("DateTs") = sDt.Rows(i).Item("DateTs")
                InvPaperDt.Rows(rc).Item("Payment") = sDt.Rows(i).Item("Payment")
                InvPaperDt.Rows(rc).Item("DatePay") = sDt.Rows(i).Item("DatePay")
                InvPaperDt.Rows(rc).Item("DateSale") = sDt.Rows(i).Item("DateSale")
                InvPaperDt.Rows(rc).Item("PsSaleName") = sDt.Rows(i).Item("PsSaleName")
                InvPaperDt.Rows(rc).Item("RegionName") = sDt.Rows(i).Item("RegionName")
                InvPaperDt.Rows(rc).Item("idCus") = sDt.Rows(i).Item("idCus")
                InvPaperDt.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusName")
                'If sDt.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt.Rows(i).Item("CusNameOwn") = "คุณ" & sDt.Rows(i).Item("CusNameOwn")
                '    End If
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusNameOwn") & " " & sDt.Rows(i).Item("LastNameOwn") & " (" & sDt.Rows(i).Item("CusName") & ")"
                'Else
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt.Rows(i).Item("CusName")
                'End If
                InvPaperDt.Rows(rc).Item("address") = sDt.Rows(i).Item("address")
                InvPaperDt.Rows(rc).Item("Tel") = sDt.Rows(i).Item("Tel")
                InvPaperDt.Rows(rc).Item("Transport") = sDt.Rows(i).Item("Transport")
                InvPaperDt.Rows(rc).Item("idPdPk") = sDt.Rows(i).Item("idPdPk")
                InvPaperDt.Rows(rc).Item("PdPkName") = sDt.Rows(i).Item("PdPkName")
                InvPaperDt.Rows(rc).Item("Amount") = sDt.Rows(i).Item("Amount")
                InvPaperDt.Rows(rc).Item("Price") = sDt.Rows(i).Item("Price")
                InvPaperDt.Rows(rc).Item("DiscountPerc") = sDt.Rows(i).Item("DiscountPerc")
                InvPaperDt.Rows(rc).Item("PerBox") = sDt.Rows(i).Item("PerBox")
                InvPaperDt.Rows(rc).Item("idPkUnit") = sDt.Rows(i).Item("idPkUnit")
                InvPaperDt.Rows(rc).Item("idPsSale") = sDt.Rows(i).Item("idPsSale")
                InvPaperDt.Rows(rc).Item("AddressS") = sDt.Rows(i).Item("AddressS")
                InvPaperDt.Rows(rc).Item("Note") = sDt.Rows(i).Item("Note")
                InvPaperDt.Rows(rc).Item("idTS") = sDt.Rows(i).Item("idTS")
                InvPaperDt.Rows(rc).Item("ShortPkUnit") = sDt.Rows(i).Item("ShortPkUnit")
                InvPaperDt.Rows(rc).Item("DiscountAmout") = sDt.Rows(i).Item("DiscountAmout")
                InvPaperDt.Rows(rc).Item("DisCountPercAll") = sDt.Rows(i).Item("DisCountPercAll")
            Next

            '----- SmSaleDtPd ------'
            Dim sDt2 As New DataTable
            sDt2.Clear()
            sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
                                    "ps.namea + ' ' +  '(' + ps.phone1 + ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
                                     "v.CusNameOwn, v.LastNameOwn, m.CusName, " & _
                                    " c.address, c.Tel, m.Transport, d.idPdLot As idPdPk, d.PdNameBill As PdPkName, " & _
                                    "d.Amount, d.Price, d.DiscountPerc, 0 As PerBox, d.idUnit As idPkUnit, m.idPsSale, " & _
                                    "m.AddressS, m.Note, m.idTS, u.UnitW As ShortPkUnit, m.DiscountAmout, " & _
                                    "m.DiscountPerc As DisCountPercAll FROM SmSaleDtPd d  " & _
                                    "LEFT OUTER JOIN  vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                    "PkPdLotStock p ON d.idPdLot = p.idPdLot LEFT OUTER JOIN dCustomer c " & _
                                    "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                    "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
                                    "LEFT OUTER JOIN dUnitW u ON d.idUnit = u.idUnitW WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt2)

            For i As Integer = 0 To sDt2.Rows.Count - 1
                Dim rc As Integer = InvPaperDt.Rows.Count
                InvPaperDt.Rows.Add()

                InvPaperDt.Rows(rc).Item("idSale") = sDt2.Rows(i).Item("idSale")
                InvPaperDt.Rows(rc).Item("DocRef") = sDt2.Rows(i).Item("DocRef")
                InvPaperDt.Rows(rc).Item("DateTs") = sDt2.Rows(i).Item("DateTs")
                InvPaperDt.Rows(rc).Item("Payment") = sDt2.Rows(i).Item("Payment")
                InvPaperDt.Rows(rc).Item("DatePay") = sDt2.Rows(i).Item("DatePay")
                InvPaperDt.Rows(rc).Item("DateSale") = sDt2.Rows(i).Item("DateSale")
                InvPaperDt.Rows(rc).Item("PsSaleName") = sDt2.Rows(i).Item("PsSaleName")
                InvPaperDt.Rows(rc).Item("RegionName") = sDt2.Rows(i).Item("RegionName")
                InvPaperDt.Rows(rc).Item("idCus") = sDt2.Rows(i).Item("idCus")
                InvPaperDt.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusName")
                'If sDt2.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt2.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt2.Rows(i).Item("CusNameOwn") = "คุณ" & sDt2.Rows(i).Item("CusNameOwn")
                '    End If
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusNameOwn") & " " & sDt2.Rows(i).Item("LastNameOwn") & " (" & sDt2.Rows(i).Item("CusName") & ")"
                'Else
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt2.Rows(i).Item("CusName")
                'End If
                InvPaperDt.Rows(rc).Item("address") = sDt2.Rows(i).Item("address")
                InvPaperDt.Rows(rc).Item("Tel") = sDt2.Rows(i).Item("Tel")
                InvPaperDt.Rows(rc).Item("Transport") = sDt2.Rows(i).Item("Transport")
                InvPaperDt.Rows(rc).Item("idPdPk") = sDt2.Rows(i).Item("idPdPk")
                InvPaperDt.Rows(rc).Item("PdPkName") = sDt2.Rows(i).Item("PdPkName")
                InvPaperDt.Rows(rc).Item("Amount") = sDt2.Rows(i).Item("Amount")
                InvPaperDt.Rows(rc).Item("Price") = sDt2.Rows(i).Item("Price")
                InvPaperDt.Rows(rc).Item("DiscountPerc") = sDt2.Rows(i).Item("DiscountPerc")
                InvPaperDt.Rows(rc).Item("PerBox") = sDt2.Rows(i).Item("PerBox")
                InvPaperDt.Rows(rc).Item("idPkUnit") = sDt2.Rows(i).Item("idPkUnit")
                InvPaperDt.Rows(rc).Item("idPsSale") = sDt2.Rows(i).Item("idPsSale")
                InvPaperDt.Rows(rc).Item("AddressS") = sDt2.Rows(i).Item("AddressS")
                InvPaperDt.Rows(rc).Item("Note") = sDt2.Rows(i).Item("Note")
                InvPaperDt.Rows(rc).Item("idTS") = sDt2.Rows(i).Item("idTS")
                InvPaperDt.Rows(rc).Item("ShortPkUnit") = sDt2.Rows(i).Item("ShortPkUnit")
                InvPaperDt.Rows(rc).Item("DiscountAmout") = sDt2.Rows(i).Item("DiscountAmout")
                InvPaperDt.Rows(rc).Item("DisCountPercAll") = sDt2.Rows(i).Item("DisCountPercAll")
            Next

            '----- SmSaleDtOther ------'
            Dim sDt3 As New DataTable
            sDt3.Clear()
            sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
                                     "ps.namea + ' ' +  '(' + ps.phone1 + ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
                                     "v.CusNameOwn, v.LastNameOwn, m.CusName, " & _
                                     " c.address, c.Tel, m.Transport, d.idPdo As idPdPk, p.Title As PdPkName, " & _
                                     "d.Amount, d.Price, d.DiscountPerc, ISNULL(d.PerBox, 0) As Perbox, d.idUnit As idPkUnit, m.idPsSale, " & _
                                     "m.AddressS, m.Note, m.idTS, " & _
                                     "u.UnitName As ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM SmSaleDtOther d  " & _
                                     "LEFT OUTER JOIN  vSmSaleMt m ON d.idSale = m.idSale LEFT OUTER JOIN " & _
                                     "SmPdOtherD p ON d.idPdo = p.idPdo LEFT OUTER JOIN dCustomer c " & _
                                     "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                     "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
                                     "LEFT OUTER JOIN PchInvAndProject.dbo.dInvUnit u ON d.idUnit = u.idUnit WHERE m.idSale ='" & idSaleS & "'"
            sAdapter.Fill(sDt3)

            For i As Integer = 0 To sDt3.Rows.Count - 1
                Dim rc As Integer = InvPaperDt.Rows.Count
                InvPaperDt.Rows.Add()

                InvPaperDt.Rows(rc).Item("idSale") = sDt3.Rows(i).Item("idSale")
                InvPaperDt.Rows(rc).Item("DocRef") = sDt3.Rows(i).Item("DocRef")
                InvPaperDt.Rows(rc).Item("DateTs") = sDt3.Rows(i).Item("DateTs")
                InvPaperDt.Rows(rc).Item("Payment") = sDt3.Rows(i).Item("Payment")
                InvPaperDt.Rows(rc).Item("DatePay") = sDt3.Rows(i).Item("DatePay")
                InvPaperDt.Rows(rc).Item("DateSale") = sDt3.Rows(i).Item("DateSale")
                InvPaperDt.Rows(rc).Item("PsSaleName") = sDt3.Rows(i).Item("PsSaleName")
                InvPaperDt.Rows(rc).Item("RegionName") = sDt3.Rows(i).Item("RegionName")
                InvPaperDt.Rows(rc).Item("idCus") = sDt3.Rows(i).Item("idCus")
                InvPaperDt.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
                'If sDt3.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
                '    If sDt3.Rows(i).Item("CusNameOwn") <> "" Then
                '        sDt3.Rows(i).Item("CusNameOwn") = "คุณ" & sDt3.Rows(i).Item("CusNameOwn")
                '    End If
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusNameOwn") & " " & sDt3.Rows(i).Item("LastNameOwn") & " (" & sDt3.Rows(i).Item("CusName") & ")"
                'Else
                '    InvPaperDt.Rows(rc).Item("CusName") = sDt3.Rows(i).Item("CusName")
                'End If
                InvPaperDt.Rows(rc).Item("address") = sDt3.Rows(i).Item("address")
                InvPaperDt.Rows(rc).Item("Tel") = sDt3.Rows(i).Item("Tel")
                InvPaperDt.Rows(rc).Item("Transport") = sDt3.Rows(i).Item("Transport")
                InvPaperDt.Rows(rc).Item("idPdPk") = sDt3.Rows(i).Item("idPdPk")
                InvPaperDt.Rows(rc).Item("PdPkName") = sDt3.Rows(i).Item("PdPkName")
                InvPaperDt.Rows(rc).Item("Amount") = sDt3.Rows(i).Item("Amount")
                InvPaperDt.Rows(rc).Item("Price") = sDt3.Rows(i).Item("Price")
                InvPaperDt.Rows(rc).Item("DiscountPerc") = sDt3.Rows(i).Item("DiscountPerc")
                InvPaperDt.Rows(rc).Item("PerBox") = sDt3.Rows(i).Item("PerBox")
                InvPaperDt.Rows(rc).Item("idPkUnit") = sDt3.Rows(i).Item("idPkUnit")
                InvPaperDt.Rows(rc).Item("idPsSale") = sDt3.Rows(i).Item("idPsSale")
                InvPaperDt.Rows(rc).Item("AddressS") = sDt3.Rows(i).Item("AddressS")
                InvPaperDt.Rows(rc).Item("Note") = sDt3.Rows(i).Item("Note")
                InvPaperDt.Rows(rc).Item("idTS") = sDt3.Rows(i).Item("idTS")
                InvPaperDt.Rows(rc).Item("ShortPkUnit") = sDt3.Rows(i).Item("ShortPkUnit")
                InvPaperDt.Rows(rc).Item("DiscountAmout") = sDt3.Rows(i).Item("DiscountAmout")
                InvPaperDt.Rows(rc).Item("DisCountPercAll") = sDt3.Rows(i).Item("DisCountPercAll")
            Next

            'Else  ' Other Bill Sale

            '    If stBillTypeS = "4" Then ' ขายสินค้าอื่นๆ
            '        sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
            '                             "ps.namea + ' ' +  '(' + ps.phone1 + ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
            '                             "v.CusNameOwn, v.LastNameOwn, m.CusName, " & _
            '                             " c.address, c.Tel, m.Transport, d.idPdo As idPdPk, p.Title As PdPkName, " & _
            '                             "d.Amount, d.Price, d.DiscountPerc, ISNULL(d.PerBox, 0) As Perbox, d.idUnit As idPkUnit, m.idPsSale, " & _
            '                             "c.AddressS, m.Note, m.idTS, " & _
            '                             "u.UnitName As ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM vSmSaleMt m " & _
            '                             "LEFT OUTER JOIN SmSaleDtOther d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                             "SmPdOtherD p ON d.idPdo = p.idPdo LEFT OUTER JOIN dCustomer c " & _
            '                             "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                             "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
            '                             "LEFT OUTER JOIN PchInvAndProject.dbo.dInvUnit u ON d.idUnit = u.idUnit WHERE m.idSale ='" & idSaleS & "'"

            '    ElseIf stBillTypeS = "7" Then  ' ขายเมล็ด
            '        sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
            '                            "ps.namea + ' ' +  '(' + ps.phone1 + ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
            '                             "v.CusNameOwn, v.LastNameOwn, m.CusName, " & _
            '                            " c.address, c.Tel, m.Transport, d.idPdLot As idPdPk, d.PdNameBill As PdPkName, " & _
            '                            "d.Amount, d.Price, d.DiscountPerc, 0 As PerBox, d.idUnit As idPkUnit, m.idPsSale, " & _
            '                            "c.AddressS, m.Note, m.idTS, " & _
            '                            "u.UnitW As ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM vSmSaleMt m " & _
            '                            "LEFT OUTER JOIN SmSaleDtPd d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                            "PkPdLotStock p ON d.idPdLot = p.idPdLot LEFT OUTER JOIN dCustomer c " & _
            '                            "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                            "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
            '                            "LEFT OUTER JOIN dUnitW u ON d.idUnit = u.idUnitW WHERE m.idSale ='" & idSaleS & "'"
            '    Else 'Normal Sale
            '        sCommand.CommandText = "Select m.idSale, m.DocRef, m.DateTs, m.PaymentTerms As Payment, m.DatePay, m.DateSale, " & _
            '                             "ps.namea + ' ' +  '(' + ps.phone1 + ')' As PsSaleName, '' As RegionName, m.idCus, v.idPreName, " & _
            '                             "v.CusNameOwn, v.LastNameOwn, m.CusName, " & _
            '                             " c.address, c.Tel, m.Transport, d.idPdPk, p.PdPkName, d.Amount, d.Price, " & _
            '                             "d.DiscountPerc,  ISNULL(d.PerBox, 0) As Perbox, d.idPkUnit, m.idPsSale, c.AddressS, m.Note, m.idTS, " & _
            '                             "u.ShortPkUnit, m.DiscountAmout, m.DiscountPerc As DisCountPercAll FROM vSmSaleMt m " & _
            '                             "LEFT OUTER JOIN SmSaleDt d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
            '                             "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
            '                             "ON m.idCus = c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
            '                             "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit " & _
            '                             "LEFT OUTER JOIN HR_Seeds.hr.vw_employeedata ps ON m.idPsSale = ps.recid " & _
            '                             "WHERE m.idSale ='" & idSaleS & "'"
            '    End If

            '    sAdapter.Fill(InvPaperDt)
            '    'For i As Integer = 0 To InvPaperDt.Rows.Count - 1
            '    '    If InvPaperDt.Rows(i).Item("idPreName") = 9 Then ' ร้านค้า
            '    '        If InvPaperDt.Rows(i).Item("CusNameOwn") <> "" Then
            '    '            InvPaperDt.Rows(i).Item("CusNameOwn") = "คุณ" & InvPaperDt.Rows(i).Item("CusNameOwn")
            '    '        End If
            '    '        InvPaperDt.Rows(i).Item("CusName") = InvPaperDt.Rows(i).Item("CusNameOwn") & " " & InvPaperDt.Rows(i).Item("LastNameOwn") & " (" & InvPaperDt.Rows(i).Item("CusName") & ")"
            '    '    Else
            '    '        InvPaperDt.Rows(i).Item("CusName") = InvPaperDt.Rows(i).Item("CusName")
            '    '    End If
            '    'Next

            'End If

            ' ***************** All Case ********************'
            For i As Integer = 0 To InvPaperDt.Rows.Count - 1
                InvPaperDt.Rows(i).Item("DateTs") = ksbStringToDate(InvPaperDt.Rows(i).Item("DateTs"))
                InvPaperDt.Rows(i).Item("DateSale") = ksbStringToDate(InvPaperDt.Rows(i).Item("DateSale"))
                InvPaperDt.Rows(i).Item("DatePay") = ksbStringToDate(InvPaperDt.Rows(i).Item("DatePay"))

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


                'If InvPaperDt.Rows(i).Item("DiscountAmout") = 0.0 Then
                '    InvPaperDt.Rows(i).Item("DiscountAmout") = 0
                'End If
            Next

            'MessageBox.Show(InvPaperDt.Rows(0).Item("idPsSale"))
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

                If InvPaperDt.Rows(i).Item("idPkUnit") = 3 Then  ' กล่อง
                    InvPaperDt.Rows(i).Item("Price") = InvPaperDt.Rows(i).Item("Price") * InvPaperDt.Rows(i).Item("PerBox")
                End If


                If IsDBNull(InvPaperDt.Rows(i).Item("DiscountPerc")) Then
                    InvPaperDt.Rows(i).Item("DiscountPerc") = 0
                End If
            Next


            Dim vRpt As New crpReceiptInvoicePaper
            vRpt.SetDataSource(InvPaperDt)
            vRpt.SetParameterValue(vRpt.Parameter_stPayment.ParameterFieldName, 1)
            Me.CrystalReportViewer1.ReportSource = vRpt
            If statusP = 4 Then
                Me.CrystalReportViewer1.ShowPrintButton = True
            End If

            mdLoadCommitt()
        End If

    End Sub
End Class