Imports System.Net
Public Class frmCusRpt
    Dim CustomerRpt As New DataTable

    Private Sub btnShowDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDoc.Click
        CustomerRpt.Clear()
        mdCnOpen()

        Dim sDt As New DataTable

        sCommand.CommandText = "SELECT dbo.vPerson.PsName,SmMkCusPs.idCus FROM dbo.SmMkCusPs LEFT OUTER JOIN dbo.vPerson ON dbo.SmMkCusPs.idPs = dbo.vPerson.idPs "
        sAdapter.Fill(sDt)
        If RadioButton1.Checked = True Then
            sCommand.CommandText = "SELECT C.CusName_, C.Address, C.Tel, '' AS PsName, Pv.PvName, C.Latitude, C.Longitude, stPicCard AS CheckDoc1, stPicRegist AS CheckDoc2, stCusComm AS CheckDoc3, stCusBusiness AS CheckDoc4, stCusBusinessEtc AS CheckDoc5, Pv.PvName AS GroupByData, C.idCus, C.stAddress  FROM dbo.vCustomer AS C LEFT OUTER JOIN dbo.dProvinceFixSale AS Pv ON C.idPv = Pv.idPv "
            sAdapter.Fill(CustomerRpt)
        Else
            sCommand.CommandText = "SELECT C.CusName_, C.Address, C.Tel,Pv.PvName AS PsName , Pv.PvName, C.Latitude, C.Longitude, stPicCard AS CheckDoc1, stPicRegist AS CheckDoc2, stCusComm AS CheckDoc3, stCusBusiness AS CheckDoc4, stCusBusinessEtc AS CheckDoc5, vPerson.PsName AS GroupByData, C.idCus, C.stAddress FROM SmMkCusPs LEFT OUTER JOIN dbo.vPerson ON dbo.SmMkCusPs.idPs = dbo.vPerson.idPs LEFT JOIN dbo.vCustomer AS C ON C.idCus = SmMkCusPs.idCus  LEFT OUTER JOIN dbo.dProvinceFixSale AS Pv ON C.idPv = Pv.idPv "
            sAdapter.Fill(CustomerRpt)
        End If

        CustomerRpt.Columns.Add("CheckPic1", Type.GetType("System.Double"))
        CustomerRpt.Columns.Add("CheckPic2", Type.GetType("System.Double"))
        CustomerRpt.Columns.Add("CheckPic3", Type.GetType("System.Double"))
        CustomerRpt.Columns.Add("cCheckDoc1", Type.GetType("System.Double"))
        CustomerRpt.Columns.Add("cCheckDoc2", Type.GetType("System.Double"))
        CustomerRpt.Columns.Add("cCheckDoc3", Type.GetType("System.Double"))
        CustomerRpt.Columns.Add("cCheckDoc4", Type.GetType("System.Double"))
        CustomerRpt.Columns.Add("cCheckDoc5", Type.GetType("System.Double"))

        For i As Integer = 0 To CustomerRpt.Rows.Count - 1
            CustomerRpt.Rows(i).Item("Latitude") = CustomerRpt.Rows(i).Item("Latitude") & "," & CustomerRpt.Rows(i).Item("Longitude")
            CustomerRpt.Rows(i).Item("CheckPic1") = 1
            CustomerRpt.Rows(i).Item("CheckPic2") = 1
            CustomerRpt.Rows(i).Item("CheckPic3") = 1
            CustomerRpt.Rows(i).Item("cCheckDoc1") = 1
            CustomerRpt.Rows(i).Item("cCheckDoc2") = 1
            CustomerRpt.Rows(i).Item("cCheckDoc3") = 1
            CustomerRpt.Rows(i).Item("cCheckDoc4") = 1
            CustomerRpt.Rows(i).Item("cCheckDoc5") = 1
        Next

        For i As Integer = 0 To CustomerRpt.Rows.Count - 1
            If RadioButton1.Checked = True Then
                For j As Integer = 0 To sDt.Rows.Count - 1
                    If CustomerRpt.Rows(i).Item("idCus") = sDt.Rows(j).Item("idCus") Then
                        CustomerRpt.Rows(i).Item("PsName") &= sDt.Rows(j).Item("PsName") & ","
                    End If
                Next
                If CustomerRpt.Rows(i).Item("PsName").ToString.Trim <> "" Then
                    CustomerRpt.Rows(i).Item("PsName") = CustomerRpt.Rows(i).Item("PsName").ToString.Substring(0, CustomerRpt.Rows(i).Item("PsName").ToString.Length - 1)
                End If
            End If
            If CustomerRpt.Rows(i).Item("CheckDoc1") Is DBNull.Value Then
                CustomerRpt.Rows(i).Item("CheckDoc1") = 0
            End If
            If CustomerRpt.Rows(i).Item("CheckDoc1") = 1 Then
                CustomerRpt.Rows(i).Item("cCheckDoc1") = 0
            Else
                CustomerRpt.Rows(i).Item("cCheckDoc1") = 1
            End If

            If CustomerRpt.Rows(i).Item("CheckDoc2") Is DBNull.Value Then
                CustomerRpt.Rows(i).Item("CheckDoc2") = 0
            End If
            If CustomerRpt.Rows(i).Item("CheckDoc2") = 1 Then
                CustomerRpt.Rows(i).Item("cCheckDoc2") = 0
            Else
                CustomerRpt.Rows(i).Item("cCheckDoc2") = 1
            End If

            If CustomerRpt.Rows(i).Item("CheckDoc3") Is DBNull.Value Then
                CustomerRpt.Rows(i).Item("CheckDoc3") = 0
            End If
            If CustomerRpt.Rows(i).Item("CheckDoc3") = 1 Then
                CustomerRpt.Rows(i).Item("cCheckDoc3") = 0
            Else
                CustomerRpt.Rows(i).Item("cCheckDoc3") = 1
            End If

            If CustomerRpt.Rows(i).Item("CheckDoc4") Is DBNull.Value Then
                CustomerRpt.Rows(i).Item("CheckDoc4") = 0
            End If
            If CustomerRpt.Rows(i).Item("CheckDoc4") = 1 Then
                CustomerRpt.Rows(i).Item("cCheckDoc4") = 0
            Else
                CustomerRpt.Rows(i).Item("cCheckDoc4") = 1
            End If

            If CustomerRpt.Rows(i).Item("CheckDoc5") Is DBNull.Value Then
                CustomerRpt.Rows(i).Item("CheckDoc5") = 0
            End If
            If CustomerRpt.Rows(i).Item("CheckDoc5") = 1 Then
                CustomerRpt.Rows(i).Item("cCheckDoc5") = 0
            Else
                CustomerRpt.Rows(i).Item("cCheckDoc5") = 1
            End If

            If CustomerRpt.Rows(i).Item("Latitude").ToString.Trim = "," Then
                CustomerRpt.Rows(i).Item("Latitude") = "-"
            End If
            If CustomerRpt.Rows(i).Item("Tel").ToString.Trim = "" Then
                CustomerRpt.Rows(i).Item("Tel") = "-"
            End If
        Next
        countpicrow()
        For i As Integer = 0 To CustomerRpt.Rows.Count - 1
            If CustomerRpt.Rows(i).Item("CusName_").ToString.Trim = "" Or CustomerRpt.Rows(i).Item("GroupByData").ToString.Trim = "" Then
                CustomerRpt.Rows(i).Delete()
            End If
        Next

        CustomerRpt.AcceptChanges()
        For i As Integer = 0 To CustomerRpt.Rows.Count - 1
            If CustomerRpt.Rows(i).Item("PsName").ToString.Trim = "" Then
                CustomerRpt.Rows(i).Item("PsName") = "ไม่พบเจ้าหน้าที่ขาย"
            End If
            If CustomerRpt.Rows(i).Item("stAddress").ToString.Trim = "4" Then
                If RadioButton1.Checked = True Then
                    CustomerRpt.Rows(i).Item("GroupByData") = "- ลูกค้าต่างประเทศ"
                Else
                    CustomerRpt.Rows(i).Item("PsName") = "- ลูกค้าต่างประเทศ"
                End If
            End If
            If CustomerRpt.Rows(i).Item("PvName").ToString.Trim = "-" And CustomerRpt.Rows(i).Item("stAddress").ToString.Trim <> "4" Then
                If RadioButton1.Checked = True Then
                    CustomerRpt.Rows(i).Item("GroupByData") = "- ไม่ได้กำหนดที่อยู่"
                Else
                    CustomerRpt.Rows(i).Item("PsName") = "- ไม่ได้กำหนดที่อยู่"
                End If
            End If
        Next
        Dim type2 As String = ""
        Dim vFrm As New FrmReportView
        Dim vRpt As New crpCusRpt

        vRpt.SetDataSource(CustomerRpt)
        If RadioButton1.Checked = True Then
            type2 = "จัดกลุ่มตามจังหวัดที่อยู่ลูกค้า"
            vRpt.SetParameterValue(vRpt.Parameter_Flag.ParameterFieldName, "1")
        Else
            type2 = "จัดกลุ่มตามเจ้าหน้าที่ขาย"
            vRpt.SetParameterValue(vRpt.Parameter_Flag.ParameterFieldName, "0")
        End If

        vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
        vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, mdPsPrint)
        vRpt.SetParameterValue(vRpt.Parameter_GroupType.ParameterFieldName, type2)
        vFrm.crView.ReportSource = vRpt
        'vFrm.ppDisplayGroupTree = True
        vFrm.Show()
        Me.Close()
    End Sub

    Private Sub countpicrow()
        Dim LocationFile As String = ""
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT FtpName,FtpPath FROM cfgFtpPath WHERE FtpName IN('CusLocation','CusEvent','CusOwner')"
        sAdapter.Fill(sDt)

        For l As Integer = 0 To sDt.Rows.Count - 1
            If sDt.Rows(l).Item("FtpName") = "CusLocation" Then
                LocationFile = sDt.Rows(l).Item("FtpPath")
            End If
        Next

        Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/" & LocationFile), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        Dim ftpFiles As New ArrayList()
        Dim i As Integer = 0
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Dim Response As FtpWebResponse = ftp.GetResponse()
        Dim responseStream As IO.Stream = Response.GetResponseStream()
        Dim str() As String
        Dim str2() As String
        Dim str3() As String
        Dim strname As String = ""
        Dim reader = New IO.StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"))
        Dim pidcus As String
        Dim k As Integer = 0
        Dim j As Integer = 0
        Dim noPicOwn As Integer = 0
        Dim noPicLocation As Integer = 0
        Dim noPicEvent As Integer = 0
        ftpFiles.Clear()
        While Not (reader.EndOfStream)
            ftpFiles.Add(reader.ReadLine())
        End While

        For i = 0 To CustomerRpt.Rows.Count - 1
            pidcus = CustomerRpt.Rows(i).Item("idCus")
            For j = 0 To ftpFiles.Count - 1
                str = ftpFiles.Item(j).ToString().Split("-")
                If (str(0) = pidcus) Then
                    CustomerRpt.Rows(i).Item("CheckPic2") = 0
                    Exit For
                End If
            Next

            'dgvDataCus.Rows(i).Cells(colPicLocation.Name).Value = k.ToString
            k = 0
        Next
        For l As Integer = 0 To sDt.Rows.Count - 1
            If sDt.Rows(l).Item("FtpName") = "CusEvent" Then
                LocationFile = sDt.Rows(l).Item("FtpPath")
            End If
        Next
        ftp = DirectCast(WebRequest.Create("ftp://" & sHost & "/" & LocationFile), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftpFiles.Clear()
        i = 0
        k = 0
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Response = ftp.GetResponse()
        responseStream = Response.GetResponseStream()
        reader = New IO.StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"))

        While Not (reader.EndOfStream)
            ftpFiles.Add(reader.ReadLine())
        End While

        For i = 0 To CustomerRpt.Rows.Count - 1
            pidcus = CustomerRpt.Rows(i).Item("idCus")
            For j = 0 To ftpFiles.Count - 1
                str2 = ftpFiles.Item(j).ToString().Split("-")
                If (str2(0) = pidcus) Then
                    CustomerRpt.Rows(i).Item("CheckPic3") = 0
                    Exit For
                End If
            Next
            'dgvDataCus.Rows(i).Cells(colPicEvent.Name).Value = k.ToString
            k = 0
        Next

        For l As Integer = 0 To sDt.Rows.Count - 1
            If sDt.Rows(l).Item("FtpName") = "CusOwner" Then
                LocationFile = sDt.Rows(l).Item("FtpPath")
            End If
        Next
        ftp = DirectCast(WebRequest.Create("ftp://" & sHost & "/" & LocationFile), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftpFiles.Clear()
        i = 0
        k = 0
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Response = ftp.GetResponse()
        responseStream = Response.GetResponseStream()
        reader = New IO.StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"))

        While Not (reader.EndOfStream)
            ftpFiles.Add(reader.ReadLine())
        End While

        For i = 0 To CustomerRpt.Rows.Count - 1
            pidcus = CustomerRpt.Rows(i).Item("idCus")
            For j = 0 To ftpFiles.Count - 1
                str3 = ftpFiles.Item(j).ToString().Split("-")
                If (str3(0) = pidcus) Then
                    CustomerRpt.Rows(i).Item("CheckPic1") = 0
                    Exit For
                End If
            Next
            'dgvDataCus.Rows(i).Cells(colPicOwner.Name).Value = k.ToString
            k = 0
        Next

        reader.Close()
        responseStream.Close()
        Response.Close()

    End Sub
End Class