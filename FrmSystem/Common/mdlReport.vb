Module mdlReport
    Public Sub mdRptShow(ByVal aRpt As Object, Optional ByVal aDisplayGroupTree As Boolean = False)
        mdLoadShow()
        Dim vFrmRpt As New FrmReportView
        vFrmRpt.crView.ReportSource = aRpt
        vFrmRpt.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        vFrmRpt.Show()
        mdLoadCommitt()
    End Sub
    Public Sub mdRptSlPdPackage()
        Dim MyTable As New DataTable
        MyTable.Clear()
        mdCnOpen()
        mdLoadShow()
        'sCommand.CommandText = "Select idPk,idPdT,PdTradeName,Trademark,PkUnitName,Weight,UnitW,Detail,PlantName,PlantTypeName From vPackingPd "
        sCommand.CommandText = "Select vS.PdTradeName,vS.Trademark,dPP.Weight,dUW.UnitW,dPP.Note,vS.PlantName,vS.PlantTypeName,dPD.idPkUnit,dPP.idPdPk,dPD.idPkDetail From vSlPdTradeNameD vS,dPackingPdSet dPP,dPackingDetail dPD,dUnitW dUW WHERE vS.idPdT = dPP.idPdT AND dPP.idPkDetail = dPD.idPkDetail AND dPP.idUnitW = dUW.idUnitW Order by vS.PdTradeName ASC"
        MyTable.Columns.Add("PkUnitName", System.Type.GetType("System.String"))
        MyTable.Columns.Add("ImgLabel", System.Type.GetType("System.Byte[]"))
        MyTable.Columns.Add("ImgPackage", System.Type.GetType("System.Byte[]"))

        sAdapter.Fill(MyTable)
        mdProgressShow(MyTable.Rows.Count + 5)
        For Each vDr As DataRow In MyTable.Rows
            mdProgressAddPlus(1)
            Dim URL_ImgLabel As String = "http://" & sHost & "/spm/images/pPdLabel/" & vDr.Item("idPdPk") & ".jpg"
            Dim URL_ImgPackage As String = "http://" & sHost & "/spm/images/pPkDetail/" & vDr.Item("idPkDetail") & ".jpg"

            Dim client As New System.Net.WebClient
            Dim buffer As Byte()

            Dim pic() As Byte

            Try
                buffer = client.DownloadData(URL_ImgLabel)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                vDr.Item("ImgLabel") = pic
            Catch ex As Exception
                ' Noimage
            End Try

            Try
                buffer = client.DownloadData(URL_ImgPackage)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                vDr.Item("ImgPackage") = pic
            Catch ex As Exception
                ' Noimage
            End Try

            If vDr.Item("idPkUnit") = 1 Then
                vDr.Item("PkUnitName") = "กระป๋อง"
            ElseIf vDr.Item("idPkUnit") = 2 Then
                vDr.Item("PkUnitName") = "ซอง"
            Else
                vDr.Item("PkUnitName") = "กล่อง"
            End If

        Next

        '   Dim vFrm As New frmCrpSlPdPacking
        Dim vRpt As New crpSlPdPacking
        vRpt.SetDataSource(MyTable)
        vRpt.SetParameterValue(vRpt.Parameter_ptTitle.ParameterFieldName, "รายงานข้อมูลสินค้าบรรจุขาย")
        vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
        vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, mdPsPrint)
        '   vFrm.crpViewSlPdPacking.ReportSource = vRpt
        ' vFrm.Show()
        mdRptShow(vRpt, True)
        mdProgressCommitt()
        mdLoadCommitt()
    End Sub

    Public Sub mdRptSlPdTradeName()
        mdCnOpen()
        mdLoadShow()
        Dim MyTable As New DataTable
        MyTable.Clear()
        sCommand.CommandText = "Select idPdT,PdTradeName,Trademark,PP,Detail,PlantName,PlantTypeName From vSlPdTradeNameD "
        MyTable.Columns.Add("ImgSticker", System.Type.GetType("System.Byte[]"))

        sAdapter.Fill(MyTable)

        For Each vDr As DataRow In MyTable.Rows
            Dim URL As String = "http://" & sHost & "/spm/images/pPdArtWork/" & vDr.Item("idPdT") & ".jpg"

            Dim client As New System.Net.WebClient
            Dim buffer As Byte()

            Dim pic() As Byte

            Try
                buffer = client.DownloadData(URL)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                vDr.Item("ImgSticker") = pic
            Catch ex As Exception
                ' Noimage
            End Try

        Next

        Dim vRpt As New crpSlPdTradeName
        vRpt.SetDataSource(MyTable)
        vRpt.SetParameterValue(vRpt.Parameter_ptTitle.ParameterFieldName, "รายงานข้อมูลสินค้า")
        vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
        vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, mdPsPrint)

        mdRptShow(vRpt, True)
        mdLoadCommitt()
    End Sub
    Public Function mdRptSlInvoice(ByVal idSale As String, ByVal status As Boolean) As DataTable   'ShowCrpInvoice
        Dim SumVAT As String
        Dim stSignPsSale As Integer = 0
        Dim stSignPsSet As Integer = 0
        Dim stSignPsSent As Integer = 0
        Dim AddressComp As String = ""
        Dim TelComp As String = ""
        Dim FaxComp As String = ""
        Dim TexCode As String = ""

        Dim dt As New DataTable
        mdCnOpen2()
        sCommand.CommandText = "Select c.Address, c.Tel, c.Fax, c.TaxCode, c.PostCode, p.ProvinceName " & _
                               "From dCompany c INNER JOIN dProvinceFix p ON c.idProvince = p.idProvince Where idComp='" & sIdComp & "'"
        sAdapter.Fill(dt)
        AddressComp = dt.Rows(0).Item("Address") & " จ." & dt.Rows(0).Item("ProvinceName") & dt.Rows(0).Item("PostCode")
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


        Dim MyTable As New DataTable
        MyTable.Clear()
        mdCnOpen()
        sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
                                "m.DiscountAmout, m.DiscountPerc, m.TotalNet, m.CusName, m.PsSent,  m.PsSale,  " & _
                                "m.PsTs,  m.PsSet, m.PaymentTerms,m.Transport, m.note, d.idPdPk, d.Amount, d.Price, " & _
                                "d.DiscountPerc as DisPerclist, p.PdPkName, d.PerBox, d.idPkUnit, u.PkUnitName, " & _
                                "p.PdCode, c.address, c.AddressS, c.Tel, c.Fax, v.CusNameCon_, " & _
                                "v.MobileCon, m.idPsSale, m.idTs, m.idPsSet, m.idPsSend FROM vSmSaleMt m " & _
                                "LEFT OUTER JOIN SmSaleDt d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
                                "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
                                "ON m.idCus=c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit WHERE m.idSale ='" & idSale & "'"

        MyTable.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))
        MyTable.Columns.Add("picSignPsSale", System.Type.GetType("System.Byte[]"))
        MyTable.Columns.Add("picSignPsSet", System.Type.GetType("System.Byte[]"))
        MyTable.Columns.Add("picSignPsSent", System.Type.GetType("System.Byte[]"))
        MyTable.Columns.Add("AddressComp", System.Type.GetType("System.String"))
        MyTable.Columns.Add("TelComp", System.Type.GetType("System.String"))
        MyTable.Columns.Add("FaxComp", System.Type.GetType("System.String"))
        MyTable.Columns.Add("TexCode", System.Type.GetType("System.String"))
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

            If MyTable.Rows(i).Item("idTs") = 1 Then
                MyTable.Rows(i).Item("Transport") = "-"
            End If

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

        If status = False Then
            Dim vFrm As New FrmReportView
            Dim vRpt As New crpInvoice
            vRpt.SetDataSource(MyTable)
            vRpt.SetParameterValue(vRpt.Parameter_idSale.ParameterFieldName, idSale)
            vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, sCompName)
            'vRpt.SetParameterValue(vRpt.Parameter_Total_ThChar.ParameterFieldName, "")
            'vRpt.SetParameterValue(vRpt.Parameter_VAT.ParameterFieldName, SumVAT)
            vRpt.SetParameterValue(vRpt.Parameter_stSignPsSale.ParameterFieldName, stSignPsSale)
            'vRpt.SetParameterValue(vRpt.Parameter_stSignPsSet.ParameterFieldName, stSignPsSet)
            'vRpt.SetParameterValue(vRpt.Parameter_stSignPsSent.ParameterFieldName, stSignPsSent)
            'vRpt.SetParameterValue(vRpt.Parameter_PsPrint.ParameterFieldName, sPsName)
            vFrm.crView.ReportSource = vRpt
            vFrm.Show()
        End If

        Return MyTable
    End Function

    'Public Sub mdRptSlSet(ByVal idsend As String)
    '    Dim sDt As New DataTable
    '    Dim ScreenData As String = ""
    '    Dim DocName As String = ""
    '    Dim Docnumber As Integer = 0
    '    mdCnOpen()
    '    sCommand.CommandText = "Select  SST.idCus , SST.idPsSend, SST.AddressFrom, SST.AddressTo, SST.idComp, SST.DateRec, SST.DateSend, STD.Transport, P.PsName AS PsSet, P2.PsName AS PsSend " & _
    '                           "From dbo.SmSendTs AS SST LEFT OUTER JOIN dbo.SmTransportD AS STD ON SST.idTS = STD.idTS LEFT OUTER JOIN dbo.vPerson AS P ON P.idPs = SST.idPsSet LEFT OUTER JOIN dbo.vPerson AS P2 ON P2.idPs = SST.idPsSend Where SST.idSend = '" & idsend & "'"
    '    sAdapter.Fill(sDt)
    '    Dim idCus As String = sDt.Rows(0).Item("idCus")
    '    Dim idPs As String = sDt.Rows(0).Item("idPsSend")

    '    Dim sDt2 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select CusNameCon,CusName_ " & _
    '                           "From vCustomer Where idCus = '" & idCus & "'"
    '    sAdapter.Fill(sDt2)

    '    Dim sDt3 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select PsName " & _
    '                           "From vPerson Where idPs = '" & idPs & "'"
    '    sAdapter.Fill(sDt3)

    '    Dim sDt_Comp As New DataTable
    '    mdCnOpen2()
    '    sCommand.CommandText = "Select Address, Tel, Fax, CompName " & _
    '                           "From dCompany Where idComp = '" & sIdComp & "'"
    '    sAdapter.Fill(sDt_Comp)
    '    Dim sDt5 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select idSale " & _
    '                           "From SmSendDt Where idSend = '" & idsend & "'"
    '    sAdapter.Fill(sDt5)

    '    ScreenData = "(0"
    '    For i As Integer = 0 To sDt5.Rows.Count - 1
    '        ScreenData += "," + sDt5.Rows(i).Item("idSale").ToString
    '    Next
    '    ScreenData += ")"

    '    Dim dItemSet As New DataTable
    '    dItemSet.Clear()
    '    mdCnOpen()
    '    sCommand.CommandText = "Select Pd.PdPkName,SUM(SsD.Amount) AS Amount, Pd.PkUnitName  "
    '    sCommand.CommandText += "From dbo.SmSaleDt AS SsD LEFT OUTER JOIN dbo.vPackingPdSet AS Pd ON SsD.idPdPk = Pd.idPdPk "
    '    sCommand.CommandText += "WHERE (SsD.idSale IN " + ScreenData + ") GROUP BY SsD.idPdPk ,Pd.PdPkName, Pd.PkUnitName "
    '    dItemSet.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))

    '    sAdapter.Fill(dItemSet)

    '    Dim sDt1 As New DataTable
    '    sCommand.CommandText = "Select DocCode " & _
    '                            "From SmSaleMt Where (idSale IN " + ScreenData + ")"
    '    sAdapter.Fill(sDt1)
    '    Docnumber = sDt1.Rows.Count
    '    DocName = sDt1.Rows(0).Item("DocCode").ToString
    '    For i As Integer = 1 To sDt1.Rows.Count - 1
    '        DocName += "," + sDt1.Rows(i).Item("DocCode").ToString
    '    Next


    '    Dim URL As String = "http://" & sHost & "/spm/Center/Logo/" & sIdComp & ".jpg"
    '    Dim client As New System.Net.WebClient
    '    Dim buffer As Byte()
    '    Dim pic() As Byte

    '    Try
    '        buffer = client.DownloadData(URL)
    '        Dim stream As New System.IO.MemoryStream(buffer)
    '        Dim binReader As New IO.BinaryReader(stream)
    '        pic = binReader.ReadBytes(stream.Length)
    '        dItemSet.Rows(0).Item("picComp") = pic
    '    Catch ex As Exception
    '        MessageBox.Show("Error")
    '    End Try

    '    Dim vFrm As New FrmReportView
    '    Dim vRpt As New crpSlSet
    '    vRpt.SetDataSource(dItemSet)

    '    vRpt.SetParameterValue(vRpt.Parameter_CompNameHead.ParameterFieldName, sDt_Comp.Rows(0).Item("CompName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_AddressCompHead.ParameterFieldName, sDt_Comp.Rows(0).Item("Address"))
    '    vRpt.SetParameterValue(vRpt.Parameter_Telhead.ParameterFieldName, sDt_Comp.Rows(0).Item("Tel"))
    '    vRpt.SetParameterValue(vRpt.Parameter_Faxhead.ParameterFieldName, sDt_Comp.Rows(0).Item("Fax"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, sDt_Comp.Rows(0).Item("CompName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsSentName.ParameterFieldName, sDt3.Rows(0).Item("PsName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompAddress.ParameterFieldName, sDt.Rows(0).Item("AddressFrom"))

    '    vRpt.SetParameterValue(vRpt.Parameter_DocNameSet.ParameterFieldName, DocName)
    '    vRpt.SetParameterValue(vRpt.Parameter_NumTs.ParameterFieldName, Docnumber)

    '    vRpt.SetParameterValue(vRpt.Parameter_Datesend.ParameterFieldName, ksbStringToDate(sDt.Rows(0).Item("DateSend")))
    '    vRpt.SetParameterValue(vRpt.Parameter_Daterec.ParameterFieldName, ksbStringToDate(sDt.Rows(0).Item("DateRec")))
    '    vRpt.SetParameterValue(vRpt.Parameter_ts.ParameterFieldName, sDt.Rows(0).Item("Transport"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsSet.ParameterFieldName, sDt.Rows(0).Item("PsSet"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsSend.ParameterFieldName, sDt.Rows(0).Item("PsSend"))

    '    vRpt.SetParameterValue(vRpt.Parameter_CompRecName.ParameterFieldName, sDt2.Rows(0).Item("CusName_"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsRecName.ParameterFieldName, sDt2.Rows(0).Item("CusNameCon"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompRecAddress.ParameterFieldName, sDt.Rows(0).Item("AddressTo"))

    '    vFrm.crView.ReportSource = vRpt
    '    vFrm.Show()


    'End Sub
    'Public Sub mdRptSlSend(ByVal idsend As String)
    '    Dim sDt As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select  idCus, idPsSend, AddressFrom, AddressTo, idComp " & _
    '                           "From SmSendTs Where idSend = '" & idsend & "'"
    '    sAdapter.Fill(sDt)
    '    Dim idCus As String = sDt.Rows(0).Item("idCus")
    '    Dim idPs As String = sDt.Rows(0).Item("idPsSend")

    '    Dim sDt2 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select CusNameCon,CusName_ " & _
    '                           "From vCustomer Where idCus = '" & idCus & "'"
    '    sAdapter.Fill(sDt2)

    '    Dim sDt3 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select PsName " & _
    '                           "From vPerson Where idPs = '" & idPs & "'"
    '    sAdapter.Fill(sDt3)

    '    Dim sDt4 As New DataTable
    '    mdCnOpen2()
    '    sCommand.CommandText = "Select CompName " & _
    '                           "From dCompany Where idComp = '" & sIdComp & "'"
    '    sAdapter.Fill(sDt4)

    '    '--------------------------ออกใบปะสินค้า-----------------------------'
    '    Dim vFrm As New FrmReportView
    '    Dim vRpt As New crpSlSend
    '    vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, sDt4.Rows(0).Item("CompName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsSentName.ParameterFieldName, sDt3.Rows(0).Item("PsName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompAddress.ParameterFieldName, sDt.Rows(0).Item("AddressFrom"))


    '    vRpt.SetParameterValue(vRpt.Parameter_CompRecName.ParameterFieldName, sDt2.Rows(0).Item("CusName_"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsRecName.ParameterFieldName, sDt2.Rows(0).Item("CusNameCon"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompRecAddress.ParameterFieldName, sDt.Rows(0).Item("AddressTo"))

    '    vFrm.crView.ReportSource = vRpt
    '    vFrm.Show()
    'End Sub


End Module
