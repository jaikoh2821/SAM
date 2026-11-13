Public Class frmPsSaleCommSummary
    Dim Status As Integer
    Private Sub frmPsSaleCommSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdCnOpen()
        'Load_Comm()
    End Sub
    Dim d_Comm As New DataTable
    Dim d_CommP As New DataTable
    Private Sub Load_Comm(ByVal vWhere As String)
        d_Comm.Clear()
        sCommand.CommandText = "SELECT DateComm, PayComm, Comm FROM SmPsSaleComm Where " & _
                               "DateComm = '" & vWhere & "' AND idComp = " & sIdComp & " Order by PayComm DESC"
        sAdapter.Fill(d_Comm)
        d_CommP.Clear()
        sCommand.CommandText = "SELECT DateCommP, PayCommP, CommP, idPdT FROM SmPsSaleCommProduct " & _
                               "Where DateCommP = '" & vWhere & "' AND idComp = " & sIdComp & " Order by PayCommP DESC"
        sAdapter.Fill(d_CommP)
    End Sub
    Dim dY, dYPd As New DataTable
    Private Sub Load_CommY(ByVal vWhere As String)
        dY.Clear()
        dYPd.Clear()
        sCommand.CommandText = "SELECT DateComm, PayComm, Comm FROM SmPsSaleComm WHERE " & _
                                "(SUBSTRING(DateComm, 1, 4) = '" & vWhere & "') AND idComp = " & sIdComp & " ORDER BY PayComm DESC"
        sAdapter.Fill(dY)
        sCommand.CommandText = "SELECT DateCommP, PayCommP, CommP, idPdT FROM SmPsSaleCommProduct " & _
                               "WHERE (SUBSTRING(DateCommP, 1, 4) = '" & vWhere & "') AND idComp = " & sIdComp & " ORDER BY PayCommP DESC"
        sAdapter.Fill(dYPd)
    End Sub
    Dim vComm As New DataView
    Dim VTable As New DataView
    Dim rMyTableY As New DataTable
    Dim strDate As String
    Private Sub Load_Data()
        If txt_YM.Text = "" Then
            MessageBox.Show("กรุณาเลือกเดือน/ปี")
            Exit Sub
        End If
        mdLoadShow()
        Dim subStrDate As Integer
        Dim ptDate As String
        'Dim month As String
        'If dtpMonth.Value.Month < 10 Then
        'month = "0" & dtpMonth.Value.Month
        'Else
        'month = dtpMonth.Value.Month
        'End If
        'strDate = (dtpMonth.Value.Year + 543) & month
        subStrDate = 6
        ptDate = txt_YM.Text
        Dim ptData As String = ""
        Dim strSQL As String = ""
        Dim strSQL2 As String = ""
        'ptData = rbPd.Text
        strSQL = "Select vSSM.PsSale, vPPS.PdPkName AS Data,ISNULL((SSD.Amount * SSD.Price),0) AS TotalNet, " & _
                  "SSD.idPkUnit,SSD.Perbox,vPPS.idPdT From vSmSaleMt vSSM,SmSaleDt SSD,vPackingPdSet vPPS " & _
                  "WHERE vSSM.idSale = SSD.idSale AND SSD.idPdPk = vPPS.idPdPk AND " & _
                  "substring(vSSM.DateSale,1," & subStrDate & ") = '" & strDate & "' AND " & _
                  "vSSM.idComp = " & sIdComp & "Order by vSSM.PsSale,TotalNet DESC"
        strSQL2 = "Select PsSale ,SUM(TotalSale) AS TotalNet From vSmSaleMt WHERE " & _
                  "substring(DateSale,1," & subStrDate & ") = '" & strDate & "' AND idComp = " & sIdComp & " GROUP BY PsSale"
        Dim MyTable As New DataTable
        Dim MyTable2 As New DataTable
        Dim MyTable3 As New DataTable
        MyTable.Clear()
        MyTable2.Clear()
        MyTable3.Clear()
        mdCnOpen()
        sCommand.CommandText = strSQL2
        sAdapter.Fill(MyTable)
        sCommand.CommandText = strSQL
        sAdapter.Fill(MyTable3)
        MyTable2.Columns.Add("PsSale")
        MyTable2.Columns.Add("Data")
        MyTable2.Columns.Add("TotalNet", System.Type.GetType("System.Decimal"))
        MyTable2.Columns.Add("idPdT", GetType(Integer))
        'MyTable2.Columns.Add("Comm", System.Type.GetType("System.Decimal"))
        'MyTable2.Columns.Add("TotalComm", System.Type.GetType("System.Decimal"))

        Dim sum As Decimal
        Dim sum2 As Decimal
        Dim dubList As New List(Of Integer)
        Dim checkDup As Integer
        For i As Integer = 0 To MyTable3.Rows.Count - 1
            checkDup = 0
            If dubList.Count > 0 Then
                If dubList.Contains(i) Then
                    checkDup = 1
                End If
            End If

            If checkDup = 0 Then
                sum = 0
                For j As Integer = 0 To MyTable3.Rows.Count - 1
                    If (MyTable3.Rows(i).Item("Data") = MyTable3.Rows(j).Item("Data")) And (MyTable3.Rows(i).Item("PsSale") = MyTable3.Rows(j).Item("PsSale")) Then
                        sum2 = 0
                        If MyTable3.Rows(j).Item("idPkUnit") = 3 Then
                            sum2 = MyTable3.Rows(j).Item("TotalNet") * MyTable3.Rows(j).Item("Perbox")
                        Else
                            sum2 = MyTable3.Rows(j).Item("TotalNet")
                        End If
                        sum += sum2
                        dubList.Add(j)
                    End If
                Next
                Dim r As DataRow = MyTable2.NewRow()
                r("PsSale") = MyTable3.Rows(i).Item("PsSale")
                r("Data") = MyTable3.Rows(i).Item("Data")
                r("TotalNet") = Format(sum, "###,###,##0.00")
                r("idPdT") = MyTable3.Rows(i).Item("idPdT")

                MyTable2.Rows.Add(r)
            End If
        Next
        MyTable.Columns.Add("Comm", System.Type.GetType("System.Decimal"))
        'MyTable.Columns.Add("TotalComm")
        MyTable.Columns.Add("TotalComm", System.Type.GetType("System.Decimal"))
        MyTable2.Columns.Add("Comm", System.Type.GetType("System.Decimal"))
        MyTable2.Columns.Add("TotalComm", System.Type.GetType("System.Decimal"))
        Load_Comm(strDate)
        Dim totalcomm As Double
        For i As Integer = 0 To MyTable.Rows.Count - 1
            totalcomm = 0
            If d_Comm.Rows.Count <> 0 Then
                For j As Integer = 0 To d_Comm.Rows.Count - 1
                    If MyTable.Rows(i).Item("ToTalNet") >= d_Comm.Rows(j).Item("PayComm") Then
                        totalcomm = (MyTable.Rows(i).Item("ToTalNet") * d_Comm.Rows(j).Item("Comm")) / 100
                        MyTable.Rows(i).Item("Comm") = d_Comm.Rows(j).Item("Comm")
                        MyTable.Rows(i).Item("TotalComm") = Format(totalcomm, "###,###,##0.00")
                        Exit For
                    End If
                    If j = d_Comm.Rows.Count - 1 Then
                        MyTable.Rows(i).Item("Comm") = 0.0
                        MyTable.Rows(i).Item("TotalComm") = 0.0
                    End If
                Next
            Else
                MyTable.Rows(i).Item("Comm") = 0.0
                MyTable.Rows(i).Item("TotalComm") = 0.0
            End If
            'MyTable2.Rows(i).Item("ToTalNet") = Format(MyTable2.Rows(i).Item("ToTalNet"), "###,###,##0.00")
        Next
        For i As Integer = 0 To MyTable2.Rows.Count - 1
            totalcomm = 0
            If d_CommP.Rows.Count <> 0 Then
                For j As Integer = 0 To d_CommP.Rows.Count - 1
                    If (MyTable2.Rows(i).Item("ToTalNet") >= d_CommP.Rows(j).Item("PayCommP")) And (MyTable2.Rows(i).Item("idPdT") = d_CommP.Rows(j).Item("idPdT")) Then
                        totalcomm = (MyTable2.Rows(i).Item("ToTalNet") * d_CommP.Rows(j).Item("CommP")) / 100
                        MyTable2.Rows(i).Item("Comm") = d_CommP.Rows(j).Item("CommP")
                        MyTable2.Rows(i).Item("TotalComm") = Format(totalcomm, "###,###,##0.00")
                        Exit For
                    End If
                    If j = d_CommP.Rows.Count - 1 Then
                        MyTable2.Rows(i).Item("Comm") = 0.0
                        MyTable2.Rows(i).Item("TotalComm") = 0.0
                    End If
                Next
            Else
                MyTable2.Rows(i).Item("Comm") = 0.0
                MyTable2.Rows(i).Item("TotalComm") = 0.0
            End If
            'MyTable2.Rows(i).Item("ToTalNet") = Format(MyTable2.Rows(i).Item("ToTalNet"), "###,###,##0.00")
        Next
        MyTable.Columns.Add("TotalCommPdT", System.Type.GetType("System.Decimal"))
        MyTable.Columns.Add("AllTotalComm", System.Type.GetType("System.Decimal"))
        Dim totalcommpdt As Double
        For i As Integer = 0 To MyTable.Rows.Count - 1
            totalcommpdt = 0
            For j As Integer = 0 To MyTable2.Rows.Count - 1
                If MyTable.Rows(i).Item("PsSale") = MyTable2.Rows(j).Item("PsSale") Then
                    totalcommpdt += MyTable2.Rows(j).Item("TotalComm")
                End If
            Next
            MyTable.Rows(i).Item("TotalCommPdT") = totalcommpdt
            MyTable.Rows(i).Item("AllTotalComm") = MyTable.Rows(i).Item("TotalComm") + MyTable.Rows(i).Item("TotalCommPdT")
        Next
        'For i As Integer = 0 To MyTable.Rows.Count - 1
        'Dim a As String = Format(MyTable.Rows(i).Item("TotalNet"), "###,###,##0.00")
        'MyTable.Rows(i).Item("TotalNet") = a.ToString
        'Next
        VTable = New DataView(MyTable)
        VTable2 = New DataView(MyTable2)
        'Dim VTable2 As New DataView
        If Status = 0 Then
            VTable.Sort = "AllTotalComm DESC,TotalNet DESC"
            DGV_CommSum.DataSource = VTable
            ksbCountRowDgv(DGV_CommSum, colautonum.Name)
            txt_SumTotalNet.Text = Format(SumDgv(DGV_CommSum, colTotalNet.Name), "###,###,##0.00")
            txt_SumTotalComm.Text = Format(SumDgv(DGV_CommSum, colTotalComm.Name), "###,###,##0.00")
            txt_SumTotalCommPd.Text = Format(SumDgv(DGV_CommSum, colTotalCommPdT.Name), "###,###,##0.00")
            txt_SumAllTotalComm.Text = Format(SumDgv(DGV_CommSum, colAllTotalComm.Name), "###,###,##0.00")
            mdLoadCommitt()
        Else
            'ptData = "เจ้าหน้าที่ขาย"
            VTable = New DataView(MyTable)
            VTable.Sort = "TotalNet DESC"
            Dim vRpt As New crpPsSaleCommDoc
            vRpt.SetDataSource(VTable)
            vRpt.SetParameterValue(vRpt.Parameter_ptTitle.ParameterFieldName, "รายงานสรุปยอดค่าคอมมิสชั่นเจ้าหน้าที่ขาย")
            vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
            vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, mdPsPrint())
            vRpt.SetParameterValue(vRpt.Parameter_ptDate.ParameterFieldName, ptDate)
            'vRpt.SetParameterValue(vRpt.Parameter_ptData.ParameterFieldName, "ข้อมูล : " & ptData)
            mdRptShow(vRpt)
            'Else
            'Dim vRpt As New crpPsSaleCommProductDoc
            'vRpt.SetDataSource(MyTable2)
            'vRpt.SetParameterValue(vRpt.Parameter_ptTitle.ParameterFieldName, "รายงานสรุปยอดค่าคอมมิสชั่น")
            'vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
            'vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, mdPsPrint())
            'vRpt.SetParameterValue(vRpt.Parameter_ptDate.ParameterFieldName, ptDate)
            'vRpt.SetParameterValue(vRpt.Parameter_ptData.ParameterFieldName, "ข้อมูล : " & ptData)
            'mdRptShow(vRpt)
            'End If
        End If
    End Sub
    Dim dAll As New DataTable
    Private Sub Load_Data2()
        Dim strMonth() As String = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Dim numMonth() As String = {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"}
        If txt_Y.Text = "" Then
            MessageBox.Show("กรุณาเลือกปี")
            Exit Sub
        End If
        mdLoadShow()
        Dim ptDate As String
        ptDate = txt_Y.Text

        Dim strSql As String
        strSql = "SELECT PsSale, ISNULL(SUM(CASE WHEN substring(DateSale, 1, 4) = '" & strDate & "' AND idComp = " & sIdComp & " THEN TotalSale END),0.00) AS TotalNetY," & _
                "ISNULL((SUM(CASE WHEN substring(DateSale, 1, 6) = '" & strDate & "01' AND idComp = " & sIdComp & " THEN TotalSale END)), 0.00) AS TotalNetJan, " & _
                "ISNULL((SUM(CASE WHEN substring(DateSale, 1, 6) = '" & strDate & "02' AND idComp = " & sIdComp & " THEN TotalSale END)), 0.00) AS TotalNetFeb, " & _
                "ISNULL((SUM(CASE WHEN substring(DateSale, 1, 6) = '" & strDate & "03' AND idComp = " & sIdComp & " THEN TotalSale END)), 0.00) AS TotalNetMar, " & _
                "ISNULL((SUM(CASE WHEN substring(DateSale, 1, 6) = '" & strDate & "04' AND idComp = " & sIdComp & " THEN TotalSale END)), 0.00) AS TotalNetApr, " & _
                "ISNULL((SUM(CASE WHEN substring(DateSale, 1, 6) = '" & strDate & "05' AND idComp = " & sIdComp & " THEN TotalSale END)), 0.00) AS TotalNetMay, " & _
                "ISNULL((SUM(CASE WHEN substring(DateSale, 1, 6) = '" & strDate & "06' AND idComp = " & sIdComp & " THEN TotalSale END)), 0.00) AS TotalNetJun, " & _
                "ISNULL((SUM(CASE WHEN substring(DateSale, 1, 6) = '" & strDate & "07' AND idComp = " & sIdComp & " THEN TotalSale END)), 0.00) AS TotalNetJul, " & _
                "ISNULL((SUM(CASE WHEN substring(DateSale, 1, 6) = '" & strDate & "08' AND idComp = " & sIdComp & " THEN TotalSale END)), 0.00) AS TotalNetAug, " & _
                "ISNULL((SUM(CASE WHEN substring(DateSale, 1, 6) = '" & strDate & "09' AND idComp = " & sIdComp & " THEN TotalSale END)), 0.00) AS TotalNetSep, " & _
                "ISNULL((SUM(CASE WHEN substring(DateSale, 1, 6) = '" & strDate & "10' AND idComp = " & sIdComp & " THEN TotalSale END)), 0.00) AS TotalNetOct, " & _
                "ISNULL((SUM(CASE WHEN substring(DateSale, 1, 6) = '" & strDate & "11' AND idComp = " & sIdComp & " THEN TotalSale END)), 0.00) AS TotalNetNov, " & _
                "ISNULL((SUM(CASE WHEN substring(DateSale, 1, 6) = '" & strDate & "12' AND idComp = " & sIdComp & " THEN TotalSale END)), 0.00) AS TotalNetDec " & _
                "FROM vSmSaleMt Where idComp = " & sIdComp & " GROUP BY PsSale"
        mdCnOpen()
        dAll.Clear()
        sCommand.CommandText = strSql
        sAdapter.Fill(dAll)
        Dim MyTableY As New DataTable
        MyTableY.Clear()
        MyTableY.Columns.Add("PsSale")
        MyTableY.Columns.Add("TotalNetY", System.Type.GetType("System.Decimal"))
        MyTableY.Columns.Add("TotalCommY", System.Type.GetType("System.Decimal"))
        MyTableY.Columns.Add("TotalCommPdY", System.Type.GetType("System.Decimal"))
        MyTableY.Columns.Add("AllTotalCommY", System.Type.GetType("System.Decimal"))
        For i As Integer = 0 To dAll.Rows.Count - 1
            Dim r As DataRow = MyTableY.NewRow()
            r("PsSale") = dAll.Rows(i).Item("PsSale")
            r("TotalNetY") = dAll.Rows(i).Item("TotalNetY")
            r("TotalCommPdY") = 0
            MyTableY.Rows.Add(r)
        Next
        For i As Integer = 0 To strMonth.Length - 1
            MyTableY.Columns.Add("TotalComm" & strMonth(i), System.Type.GetType("System.Decimal"))
        Next
        Load_CommY(strDate)
        Dim TotalCommY As Double
        Dim TotalComm As Double
        For i As Integer = 0 To dAll.Rows.Count - 1
            TotalCommY = 0
            For j As Integer = 0 To strMonth.Length - 1
                TotalComm = Cal_TotalComm(i, "TotalNet" & strMonth(j), strDate & numMonth(j))
                MyTableY.Rows(i).Item("TotalComm" & strMonth(j)) = TotalComm
                TotalCommY += TotalComm
            Next
            MyTableY.Rows(i).Item("TotalCommY") = TotalCommY
        Next
        For i As Integer = 0 To strMonth.Length - 1
            MyTableY.Columns.Add("TotalCommPd" & strMonth(i), System.Type.GetType("System.Decimal"))
            MyTableY.Columns.Add("AllTotalComm" & strMonth(i), System.Type.GetType("System.Decimal"))
        Next
        Dim dPd As New DataTable
        Dim strSqlYPd As String
        For k As Integer = 0 To numMonth.Length - 1
            strSqlYPd = "Select vSSM.PsSale, vPPS.PdPkName AS Data,ISNULL((SSD.Amount * SSD.Price),0) AS TotalNet, " & _
                        "SSD.idPkUnit,SSD.Perbox,vPPS.idPdT From vSmSaleMt vSSM,SmSaleDt SSD,vPackingPdSet vPPS WHERE " & _
                        "vSSM.idSale = SSD.idSale AND SSD.idPdPk = vPPS.idPdPk AND " & _
                        "substring(vSSM.DateSale,1,6) = '" & strDate & numMonth(k) & "' AND " & _
                        "vSSM.idComp = " & sIdComp & " Order by vSSM.PsSale,TotalNet DESC"
            dPd.Clear()
            sCommand.CommandText = strSqlYPd
            sAdapter.Fill(dPd)
            Dim MyTableYPd As New DataTable
            MyTableYPd.Clear()
            MyTableYPd = Cal_TotalCommPd(dPd, strDate & numMonth(k))
            Dim totalcommpdt As Double
            For i As Integer = 0 To MyTableY.Rows.Count - 1
                totalcommpdt = 0
                For j As Integer = 0 To MyTableYPd.Rows.Count - 1
                    Dim a As String = MyTableY.Rows(i).Item("PsSale")
                    Dim b As String = MyTableYPd.Rows(j).Item("PsSale")
                    If MyTableY.Rows(i).Item("PsSale") = MyTableYPd.Rows(j).Item("PsSale") Then
                        totalcommpdt += MyTableYPd.Rows(j).Item("TotalCommPd")
                    End If
                Next
                MyTableY.Rows(i).Item("TotalCommPd" & strMonth(k)) = totalcommpdt
                MyTableY.Rows(i).Item("AllTotalComm" & strMonth(k)) = MyTableY.Rows(i).Item("TotalComm" & strMonth(k)) + MyTableY.Rows(i).Item("TotalCommPd" & strMonth(k))
                MyTableY.Rows(i).Item("TotalCommPdY") += totalcommpdt
            Next
        Next
        For i As Integer = 0 To MyTableY.Rows.Count - 1
            For j As Integer = 0 To strMonth.Length - 1
                MyTableY.Rows(i).Item("AllTotalCommY") = MyTableY.Rows(i).Item("TotalCommY") + MyTableY.Rows(i).Item("TotalCommPdY")
            Next
        Next
        rMyTableY.Clear()
        rMyTableY = MyTableY
        Dim vCommY As New DataView
        vCommY = New DataView(MyTableY)
        vCommY.Sort = "AllTotalCommY DESC,TotalNetY DESC"
        DGV_CommY.DataSource = vCommY
        ksbCountRowDgv(DGV_CommY, col_autonum2.Name)
        txt_SumTotalNetY.Text = Format(SumDgv(DGV_CommY, col_TotalNetY.Name), "###,###,##0.00")
        txt_SumTotalCommY.Text = Format(SumDgv(DGV_CommY, col_TotalCommY.Name), "###,###,##0.00")
        txt_SumTotalCommPdY.Text = Format(SumDgv(DGV_CommY, col_TotalCommPdY.Name), "###,###,##0.00")
        txt_SumAllTotalCommY.Text = Format(SumDgv(DGV_CommY, col_AllTotalCommY.Name), "###,###,##0.00")
        mdLoadCommitt()
    End Sub
    Private Function Cal_TotalComm(ByVal index As Integer, ByVal colTotalnet As String, ByVal strDateComm As String) As Double
        Dim totalcomm As Double = 0
        If dY.Rows.Count <> 0 Then
            For j As Integer = 0 To dY.Rows.Count - 1
                If dAll.Rows(index).Item(colTotalnet) >= dY.Rows(j).Item("PayComm") And dY.Rows(j).Item("DateComm") = strDateComm Then
                    totalcomm = (dAll.Rows(index).Item(colTotalnet) * dY.Rows(j).Item("Comm")) / 100
                    Exit For
                End If
                If j = d_Comm.Rows.Count - 1 Then
                    totalcomm = 0
                End If
            Next
        Else
            totalcomm = 0
        End If
        Return totalcomm
    End Function
    Private Function Cal_TotalCommPd(ByVal dTable As DataTable, ByVal strDateComm As String) As DataTable
        Dim dTotalPd As New DataTable
        dTotalPd.Clear()
        dTotalPd.Columns.Add("PsSale")
        dTotalPd.Columns.Add("Data")
        dTotalPd.Columns.Add("TotalNetPd", System.Type.GetType("System.Decimal"))
        dTotalPd.Columns.Add("idPdT", GetType(Integer))
        Dim sum As Decimal
        Dim sum2 As Decimal
        Dim dubList As New List(Of Integer)
        Dim checkDup As Integer
        For i As Integer = 0 To dTable.Rows.Count - 1
            checkDup = 0
            If dubList.Count > 0 Then
                If dubList.Contains(i) Then
                    checkDup = 1
                End If
            End If
            If checkDup = 0 Then
                sum = 0
                For j As Integer = 0 To dTable.Rows.Count - 1
                    If (dTable.Rows(i).Item("Data") = dTable.Rows(j).Item("Data")) And (dTable.Rows(i).Item("PsSale") = dTable.Rows(j).Item("PsSale")) Then
                        sum2 = 0
                        If dTable.Rows(j).Item("idPkUnit") = 3 Then
                            sum2 = dTable.Rows(j).Item("TotalNet") * dTable.Rows(j).Item("Perbox")
                        Else
                            sum2 = dTable.Rows(j).Item("TotalNet")
                        End If
                        sum += sum2
                        dubList.Add(j)
                    End If
                Next
                Dim r As DataRow = dTotalPd.NewRow()
                r("PsSale") = dTable.Rows(i).Item("PsSale")
                r("Data") = dTable.Rows(i).Item("Data")
                r("TotalNetPd") = sum
                r("idPdT") = dTable.Rows(i).Item("idPdT")
                dTotalPd.Rows.Add(r)
            End If
        Next
        Dim totalcomm As Double
        dTotalPd.Columns.Add("TotalCommPd", System.Type.GetType("System.Decimal"))
        For i As Integer = 0 To dTotalPd.Rows.Count - 1
            totalcomm = 0
            If dYPd.Rows.Count <> 0 Then
                For j As Integer = 0 To dYPd.Rows.Count - 1
                    If (dTotalPd.Rows(i).Item("TotalNetPd") >= dYPd.Rows(j).Item("PayCommP")) And (dTotalPd.Rows(i).Item("idPdT") = dYPd.Rows(j).Item("idPdT")) And dYPd.Rows(j).Item("DateCommP") = strDateComm Then
                        totalcomm = (dTotalPd.Rows(i).Item("TotalNetPd") * dYPd.Rows(j).Item("CommP")) / 100
                        dTotalPd.Rows(i).Item("TotalCommPd") = totalcomm
                        Exit For
                    End If
                    If j = dYPd.Rows.Count - 1 Then
                        dTotalPd.Rows(i).Item("TotalCommPd") = 0.0
                    End If
                Next
            Else
                dTotalPd.Rows(i).Item("TotalCommPd") = 0.0
            End If
        Next

        Return dTotalPd
    End Function

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        If txt_YM.Text = "" Then
            MessageBox.Show("กรุณาเลือกเดือน/ปี")
            Exit Sub
        End If
        mdLoadShow()
        'Status = 1
        'Load_Data()
        VTable.Sort = "AllTotalComm DESC"
        Dim vRpt As New crpPsSaleCommDoc
        vRpt.SetDataSource(VTable)
        vRpt.SetParameterValue(vRpt.Parameter_ptTitle.ParameterFieldName, "รายงานสรุปยอดค่าคอมมิสชั่นเจ้าหน้าที่ขาย")
        vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
        vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, mdPsPrint())
        vRpt.SetParameterValue(vRpt.Parameter_ptDate.ParameterFieldName, txt_YM.Text)
        'vRpt.SetParameterValue(vRpt.Parameter_ptData.ParameterFieldName, "ข้อมูล : " & ptData)
        mdRptShow(vRpt)
        mdLoadCommitt()
    End Sub
    Dim VTable2 As New DataView
    Private Sub DGV_CommSum_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_CommSum.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If DGV_CommSum.Columns(e.ColumnIndex).Name = colSelect.Name Then
            txt_PsSale.Text = DGV_CommSum.Rows(e.RowIndex).Cells(colPsSale.Name).Value
            VTable2.RowFilter = "PsSale = '" & DGV_CommSum.Rows(e.RowIndex).Cells(colPsSale.Name).Value & "'"
            VTable2.Sort = "TotalComm DESC,TotalNet DESC"
            DGV_CommSum2.DataSource = VTable2
            ksbCountRowDgv(DGV_CommSum2, colautonum2.Name)
        End If
        
    End Sub

    Private Sub btn_YM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_YM.Click
        Dim frm As New frmMYSelect(frmMYSelect.eProcess.eYM)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            strDate = frm.str_Date
            txt_YM.Text = frm.txt_Date
            Status = 0
            Load_Data()
        End If
    End Sub

    Private Sub btn_Y_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Y.Click
        Dim frm As New frmMYSelect(frmMYSelect.eProcess.eY)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            strDate = frm.str_Date
            txt_Y.Text = frm.txt_Date
            Status = 0
            Load_Data2()
        End If
    End Sub

    Private Sub TapPage1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage1 Then
            Me.Size = New Size(739, 620)
        ElseIf TabControl1.SelectedTab Is TabPage2 Then
            Me.Size = New Size(1000, 620)
        End If
    End Sub

    Private Sub btn_print2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print2.Click
        If txt_Y.Text = "" Then
            MessageBox.Show("กรุณาเลือกปี")
            Exit Sub
        End If
        mdLoadShow()
        Dim cprTable As New DataTable
        Dim vCprTable As New DataView
        Dim strMonth() As String = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Dim numMonth() As String = {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"}
        cprTable.Columns.Add("PsSale")
        cprTable.Columns.Add("TotalNetY", GetType(Integer))
        cprTable.Columns.Add("TotalCommY", GetType(Integer))
        cprTable.Columns.Add("TotalCommPdY", GetType(Integer))
        cprTable.Columns.Add("AllTotalCommY", GetType(Integer))
        For i As Integer = 0 To strMonth.Length - 1
            cprTable.Columns.Add("AllTotalComm" & strMonth(i), GetType(Integer))
        Next
        For i As Integer = 0 To rMyTableY.Rows.Count - 1
            Dim r As DataRow = cprTable.NewRow()
            r("PsSale") = rMyTableY.Rows(i).Item("PsSale")
            r("TotalNetY") = rMyTableY.Rows(i).Item("TotalNetY")
            r("TotalCommY") = rMyTableY.Rows(i).Item("TotalCommY")
            r("TotalCommPdY") = rMyTableY.Rows(i).Item("TotalCommPdY")
            r("AllTotalCommY") = rMyTableY.Rows(i).Item("AllTotalCommY")
            For j As Integer = 0 To strMonth.Length - 1
                r("AllTotalComm" & strMonth(j)) = rMyTableY.Rows(i).Item("AllTotalComm" & strMonth(j))
            Next
            cprTable.Rows.Add(r)
        Next
        Dim ptDate As String
        ptDate = "ปี " & txt_Y.Text
        vCprTable = New DataView(cprTable)
        vCprTable.Sort = "AllTotalCommY DESC"
        Dim vRpt As New crpPsSaleCommDocYear
        vRpt.SetDataSource(vCprTable)
        vRpt.SetParameterValue(vRpt.Parameter_ptTitle.ParameterFieldName, "รายงานสรุปยอดค่าคอมมิสชั่นเจ้าหน้าที่ขาย")
        vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
        vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, mdPsPrint())
        vRpt.SetParameterValue(vRpt.Parameter_ptDate.ParameterFieldName, ptDate)
        mdRptShow(vRpt)
        mdLoadCommitt()
    End Sub

    Private Function SumDgv(ByVal dgv As DataGridView, ByVal colName As String) As Double
        Dim SumCol As Double = 0
        For i As Integer = 0 To dgv.Rows.Count - 1
            SumCol += dgv.Rows(i).Cells(colName).Value
        Next
        Return SumCol
    End Function
    
End Class