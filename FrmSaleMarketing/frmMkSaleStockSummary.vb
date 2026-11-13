Public Class frmMkSaleStockSummary
    Dim flag As String = 0
    Private Sub frmMkSaleStockSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

    End Sub
    Private Sub BindPd()
        mdCnOpen()
        Dim sDt_Temp_View As New DataTable
        Dim sDt3_2 As New DataTable
        Dim yaerS As String = Microsoft.VisualBasic.Right(Date3.Text, 4)
        sCommand.CommandText = " SELECT Distinct DB2.idPlantType,P.PlantTypeName,0 as Flag ,DB2.totalnet AS NUM FROM " & _
        " (SELECT DB1.idPlantType , SUM(Totalnet) AS totalnet " & _
        " FROM (Select Pack.idPlantType , MONTH (t1.DateSale) AS MonthS ,SUM((SmD.Amount * Pack.Weight)/1000) AS Totalnet  " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
        " WHERE(t1.idPsCancel Is NULL And SmD.idUnitW = 1 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " ) " & _
        "   group by Pack.idPlantType,t1.DateSale " & _
        " UNION    " & _
        " Select Pack.idPlantType , MONTH (t1.DateSale)  AS MonthS ,SUM(SmD.Amount * Pack.Weight) AS Totalnet   " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv   " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
        " WHERE(t1.idPsCancel Is NULL And SmD.idUnitW = 2 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " ) " & _
        " group by Pack.idPlantType,t1.DateSale) as DB1  group by DB1.idPlantType ) AS DB2 LEFT JOIN vPackingPdSet P ON P.idPlantType = DB2.idPlantType WHERE DB2.idPlantType IS NOT NULL ORDER BY DB2.totalnet DESC "
        sAdapter.Fill(sDt_Temp_View)
        
        dgvData.DataSource = sDt_Temp_View

    End Sub
    Private Sub BindPd2(ByVal idPlantType As String)
        mdCnOpen()
        Dim sDt_Temp_View2 As New DataTable
        Dim sDt3_2 As New DataTable
        Dim yaerS As String = Microsoft.VisualBasic.Right(Date3.Text, 4)
        sCommand.CommandText = " SELECT Distinct DB2.idPdT,P.PdTradeName,0 as Flag ,DB2.totalnet AS NUM FROM " & _
        " (SELECT DB1.idPdT , SUM(Totalnet) AS totalnet " & _
        " FROM (Select Pack.idPdT , MONTH (t1.DateSale) AS MonthS ,SUM((SmD.Amount * Pack.Weight)/1000) AS Totalnet  " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
        " WHERE(t1.idPsCancel Is NULL And SmD.idUnitW = 1 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " ) " & _
        "   group by Pack.idPdT,t1.DateSale " & _
        " UNION    " & _
        " Select Pack.idPdT , MONTH (t1.DateSale)  AS MonthS ,SUM(SmD.Amount * Pack.Weight) AS Totalnet   " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv   " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
        " WHERE(t1.idPsCancel Is NULL And SmD.idUnitW = 2 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " ) " & _
        " group by Pack.idPdT,t1.DateSale) as DB1  group by DB1.idPdT ) AS DB2 LEFT JOIN vPackingPdSet P ON P.idPdT = DB2.idPdT WHERE DB2.idPdT IS NOT NULL AND P.idPlantType = " & idPlantType & " ORDER BY DB2.totalnet DESC "
        sAdapter.Fill(sDt_Temp_View2)
        dgvData2.DataSource = sDt_Temp_View2
    End Sub
    Private Sub BindPd3(ByVal idPdT As String)
        mdCnOpen()
        Dim sDt_Temp_View3 As New DataTable
        Dim sDt3_2 As New DataTable
        Dim yaerS As String = Microsoft.VisualBasic.Right(Date3.Text, 4)
        sCommand.CommandText = " SELECT Distinct DB2.idPdPk,P.PdPkName,0 as Flag ,DB2.totalnet AS NUM FROM " & _
        " (SELECT DB1.idPdPk , SUM(Totalnet) AS totalnet " & _
        " FROM (Select Pack.idPdPk , MONTH (t1.DateSale) AS MonthS ,SUM((SmD.Amount * Pack.Weight)/1000) AS Totalnet  " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
        " WHERE(t1.idPsCancel Is NULL And SmD.idUnitW = 1 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " ) " & _
        "   group by Pack.idPdPk,t1.DateSale " & _
        " UNION    " & _
        " Select Pack.idPdPk , MONTH (t1.DateSale)  AS MonthS ,SUM(SmD.Amount * Pack.Weight) AS Totalnet   " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv   " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
        " WHERE(t1.idPsCancel Is NULL And SmD.idUnitW = 2 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " ) " & _
        " group by Pack.idPdPk,t1.DateSale) as DB1  group by DB1.idPdPk ) AS DB2 LEFT JOIN vPackingPdSet P ON P.idPdPk = DB2.idPdPk WHERE DB2.idPdPk IS NOT NULL AND P.idPdT = " & idPdT & "  ORDER BY DB2.totalnet DESC "
        sAdapter.Fill(sDt_Temp_View3)
        dgvData3.DataSource = sDt_Temp_View3
    End Sub

    Private Sub btnSchPd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchPd.Click
        mdLoadShow()
        ShowData()
        mdLoadCommitt()
    End Sub


    Private Sub ShowData()
        Dim sDt As New DataTable
        Dim sDt2 As New DataTable
        Dim sDt3 As New DataTable
        Dim sDt4 As New DataTable
        Dim sDt_Temp As New DataTable
        mdCnOpen()
        Dim vWhere As String = ""
        Dim vWhere2 As String = ""
        Dim yaerS As String = Microsoft.VisualBasic.Right(Date3.Text, 4)
        Dim yaerE As String = (CType(Microsoft.VisualBasic.Right(Date3.Text, 4), Integer) - 1).ToString
        Dim NameChart As String = ""

        For i As Integer = 0 To dgvData.Rows.Count - 1
            If dgvData.Rows(i).Cells(Flag1.Name).Value = 1 Then
                vWhere = " Pack.idPlantType = " & dgvData.Rows(i).Cells(idPlantType.Name).Value.ToString
                NameChart = dgvData.Rows(i).Cells(PlantTypeName.Name).Value.ToString
                Exit For
            End If
        Next
        For i As Integer = 0 To dgvData2.Rows.Count - 1
            If dgvData2.Rows(i).Cells(Flag2.Name).Value = 1 Then
                vWhere = " Pack.idPdT = " & dgvData2.Rows(i).Cells(idPdT.Name).Value.ToString
                NameChart = dgvData2.Rows(i).Cells(PdTradeName.Name).Value.ToString
                Exit For
            End If
        Next
        For i As Integer = 0 To dgvData3.Rows.Count - 1
            If dgvData3.Rows(i).Cells(Flag3.Name).Value = 1 Then
                vWhere = " Pack.idPdPk = " & dgvData3.Rows(i).Cells(idPdPk.Name).Value.ToString
                NameChart = dgvData3.Rows(i).Cells(PdPkName.Name).Value.ToString
                Exit For
            End If
        Next
        

        sCommand.CommandText = " SELECT MonthS ,SUM(Totalnet) AS totalnet, '' MONTHNAMES " & _
        " FROM (Select MONTH (t1.DateSale) AS MonthS ,SUM((SmD.Amount * Pack.Weight)/1000) AS Totalnet " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
        " WHERE ( t1.idPsCancel Is NULL And SmD.idUnitW = 1 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " AND " & vWhere & " ) " & _
        " group by t1.DateSale " & _
        " UNION " & _
        " Select MONTH (t1.DateSale)  AS MonthS ,SUM(SmD.Amount * Pack.Weight) AS Totalnet    " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
        " WHERE ( t1.idPsCancel Is NULL And SmD.idUnitW = 2 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " AND " & vWhere & " ) " & _
        " group by t1.DateSale) as DB1 GROUP BY MonthS ORDER BY MonthS   "
            sAdapter.Fill(sDt)

        sCommand.CommandText = " SELECT MonthS ,SUM(Totalnet) AS totalnet, '' MONTHNAMES " & _
        " FROM (Select MONTH (t1.DateSale) AS MonthS ,SUM((SmD.Amount * Pack.Weight)/1000) AS Totalnet " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
        " WHERE ( t1.idPsCancel Is NULL And SmD.idUnitW = 1 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerE & " AND " & vWhere & " ) " & _
        " group by t1.DateSale " & _
        " UNION " & _
        " Select MONTH (t1.DateSale)  AS MonthS ,SUM(SmD.Amount * Pack.Weight) AS Totalnet    " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
        " WHERE ( t1.idPsCancel Is NULL And SmD.idUnitW = 2 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerE & " AND " & vWhere & " ) " & _
        " group by t1.DateSale) as DB1 GROUP BY MonthS ORDER BY MonthS   "
            sAdapter.Fill(sDt2)

        sCommand.CommandText = " SELECT MONTHS ,FORMAT(Sum(Amount), 'N3') AS Amount " & _
                " FROM " & _
                " (SELECT CONVERT(INT, SUBSTRING (MY.YM,5,2)) AS months,SUBSTRING (MY.YM,0,5) AS years, ((MY.Amount*Pack.Weight)/1000) AS Amount,Pack.PdPkName FROM PdPkStockMY MY LEFT JOIN vPackingPdSet Pack ON Pack.idpdpk = MY.idpdpk WHERE " & vWhere & " AND Pack.idUnitW = 1   " & _
                " UNION " & _
                " SELECT CONVERT(INT, SUBSTRING (MY.YM,5,2)) AS months,SUBSTRING (MY.YM,0,5) AS years, (MY.Amount*Pack.Weight) AS Amount ,Pack.PdPkName FROM PdPkStockMY MY LEFT JOIN vPackingPdSet Pack ON Pack.idpdpk = MY.idpdpk WHERE " & vWhere & " AND Pack.idUnitW = 2 " & _
                " ) AS DB1 WHERE(years = " & yaerS & ") GROUP BY MONTHS "
            sAdapter.Fill(sDt3)

        sCommand.CommandText = " SELECT MONTHS ,FORMAT(Sum(Amount), 'N3') AS Amount " & _
              " FROM " & _
              " (SELECT CONVERT(INT, SUBSTRING (MY.YM,5,2)) AS months,SUBSTRING (MY.YM,0,5) AS years, ((MY.Amount*Pack.Weight)/1000) AS Amount,Pack.PdPkName FROM PdPkStockMY MY LEFT JOIN vPackingPdSet Pack ON Pack.idpdpk = MY.idpdpk WHERE " & vWhere & " AND Pack.idUnitW = 1   " & _
              " UNION " & _
              " SELECT CONVERT(INT, SUBSTRING (MY.YM,5,2)) AS months,SUBSTRING (MY.YM,0,5) AS years, (MY.Amount*Pack.Weight) AS Amount ,Pack.PdPkName FROM PdPkStockMY MY LEFT JOIN vPackingPdSet Pack ON Pack.idpdpk = MY.idpdpk WHERE " & vWhere & " AND Pack.idUnitW = 2 " & _
              " ) AS DB1 WHERE(years = " & yaerE & ") GROUP BY MONTHS "
            sAdapter.Fill(sDt4)



            sDt_Temp.Columns.Add("MonthS", Type.GetType("System.String"))
            sDt_Temp.Columns.Add("totalnet", Type.GetType("System.Double"))
            sDt_Temp.Columns.Add("MONTHNAMES", Type.GetType("System.String"))
            sDt_Temp.Columns.Add("totalnet2", Type.GetType("System.Double"))
            sDt_Temp.Columns.Add("MONTHNAMES2", Type.GetType("System.String"))
            sDt_Temp.Columns.Add("totalnet3", Type.GetType("System.Double"))
            sDt_Temp.Columns.Add("MONTHNAMES3", Type.GetType("System.String"))
            sDt_Temp.Columns.Add("totalnet4", Type.GetType("System.Double"))
            sDt_Temp.Columns.Add("MONTHNAMES4", Type.GetType("System.String"))


            sDt_Temp.Rows.Add("1", 0.0, "", 0.0, "")
            sDt_Temp.Rows.Add("2", 0.0, "", 0.0, "")
            sDt_Temp.Rows.Add("3", 0.0, "", 0.0, "")
            sDt_Temp.Rows.Add("4", 0.0, "", 0.0, "")
            sDt_Temp.Rows.Add("5", 0.0, "", 0.0, "")
            sDt_Temp.Rows.Add("6", 0.0, "", 0.0, "")
            sDt_Temp.Rows.Add("7", 0.0, "", 0.0, "")
            sDt_Temp.Rows.Add("8", 0.0, "", 0.0, "")
            sDt_Temp.Rows.Add("9", 0.0, "", 0.0, "")
            sDt_Temp.Rows.Add("10", 0.0, "", 0.0, "")
            sDt_Temp.Rows.Add("11", 0.0, "", 0.0, "")
            sDt_Temp.Rows.Add("12", 0.0, "", 0.0, "")

            For i As Integer = 0 To sDt_Temp.Rows.Count - 1
                sDt_Temp.Rows(i).Item("MONTHNAMES") = MonthNameToCode(sDt_Temp.Rows(i).Item("MonthS"))
                sDt_Temp.Rows(i).Item("MONTHNAMES2") = MonthNameToCode(sDt_Temp.Rows(i).Item("MonthS"))
                sDt_Temp.Rows(i).Item("MONTHNAMES3") = MonthNameToCode(sDt_Temp.Rows(i).Item("MonthS"))
                sDt_Temp.Rows(i).Item("MONTHNAMES4") = MonthNameToCode(sDt_Temp.Rows(i).Item("MonthS"))
            Next

            For i As Integer = 0 To sDt_Temp.Rows.Count - 1
                For j As Integer = 0 To sDt.Rows.Count - 1
                    If sDt_Temp.Rows(i).Item("MonthS") = sDt.Rows(j).Item("MonthS") Then
                        sDt_Temp.Rows(i).Item("totalnet") = sDt.Rows(j).Item("totalnet")
                    End If
                Next
                For j As Integer = 0 To sDt2.Rows.Count - 1
                    If sDt_Temp.Rows(i).Item("MonthS") = sDt2.Rows(j).Item("MonthS") Then
                        sDt_Temp.Rows(i).Item("totalnet2") = sDt2.Rows(j).Item("totalnet")
                    End If
                Next
                For j As Integer = 0 To sDt3.Rows.Count - 1
                    If sDt_Temp.Rows(i).Item("MonthS") = sDt3.Rows(j).Item("MONTHS") Then
                        sDt_Temp.Rows(i).Item("totalnet3") = sDt3.Rows(j).Item("Amount")
                    End If
                Next
                For j As Integer = 0 To sDt4.Rows.Count - 1
                    If sDt_Temp.Rows(i).Item("MonthS") = sDt4.Rows(j).Item("MONTHS") Then
                        sDt_Temp.Rows(i).Item("totalnet4") = sDt4.Rows(j).Item("Amount")
                    End If
                Next
            Next



            Chart1.DataSource = sDt_Temp
            Chart1.Series(0).Name = "0"
            Chart1.Series(1).Name = "1"
            Chart1.Series(2).Name = "2"
            Chart1.Series(3).Name = "3"
            Dim NameSeries As String = ""
            Dim NameSeries2 As String = ""
            Dim NameSeries3 As String = ""
            Dim NameSeries4 As String = ""

            NameSeries = "จำนวนยอดขายปี " & yaerS
            NameSeries2 = "จำนวนสต๊อกคงเหลือปี " & yaerS
            NameSeries3 = "จำนวนยอดขายปี " & yaerE
            NameSeries4 = "จำนวนสต๊อกคงเหลือปี " & yaerE

            Chart1.Series(0).Name = NameSeries
            Chart1.Series(1).Name = NameSeries2
            Chart1.Series(2).Name = NameSeries3
            Chart1.Series(3).Name = NameSeries4
            Chart1.Series(0).XValueMember = "MONTHNAMES"
            Chart1.Series(0).YValueMembers = "totalnet"
            Chart1.Series(1).XValueMember = "MONTHNAMES3"
            Chart1.Series(1).YValueMembers = "totalnet3"
            Chart1.Series(2).XValueMember = "MONTHNAMES2"
            Chart1.Series(2).YValueMembers = "totalnet2"
            Chart1.Series(3).XValueMember = "MONTHNAMES4"
            Chart1.Series(3).YValueMembers = "totalnet4"
            Chart1.DataBind()
            Chart1.Series(0).Label = "#VALY{#,##0.000}"
            Chart1.Series(1).Label = "#VALY{#,##0.000}"
            Chart1.Series(2).Label = "#VALY{#,##0.000}"
            Chart1.Series(3).Label = "#VALY{#,##0.000}"
        Chart1.Titles(0).Text = " แผนภูมิเปรียบเทียบระหว่างจำนวนยอดขายและสต๊อกคงเหลือ ( " & NameChart & " ) (กก.) "

            Dim sDt_ToTal As New DataTable
            mdCnOpen()
            sCommand.CommandText = " SELECT SUM(Totalnet) AS totalnet " & _
            " FROM (Select MONTH (t1.DateSale) AS MonthS ,SUM((SmD.Amount * Pack.Weight)/1000) AS Totalnet " & _
            " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
            " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
            " WHERE(t1.idPsCancel Is NULL And SmD.idUnitW = 1 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " ) " & _
            " group by t1.DateSale " & _
            " UNION " & _
            " Select MONTH (t1.DateSale)  AS MonthS ,SUM(SmD.Amount * Pack.Weight) AS Totalnet  " & _
            " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
            " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
            " WHERE(t1.idPsCancel Is NULL And SmD.idUnitW = 2 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " ) " & _
            " group by t1.DateSale) as DB1 "
            sAdapter.Fill(sDt_ToTal)
        LB1.Text = "ยอดรวมน้ำหนัก " & FormatNumber(sDt_ToTal.Rows(0).Item("totalnet"), 3, , , TriState.True) & " กิโลกรัม"

            Dim sDt_ToTal2 As New DataTable
            mdCnOpen()
            sCommand.CommandText = " SELECT SUM(Totalnet) AS totalnet " & _
            " FROM (Select MONTH (t1.DateSale) AS MonthS ,SUM(SmD.Price*SmD.Amount) AS Totalnet " & _
            " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
            " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
            " WHERE(t1.idPsCancel Is NULL And SmD.idUnitW = 1 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " ) " & _
            " group by t1.DateSale " & _
            " UNION " & _
            " Select MONTH (t1.DateSale)  AS MonthS ,SUM(SmD.Price*SmD.Amount) AS Totalnet  " & _
            " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
            " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
            " WHERE(t1.idPsCancel Is NULL And SmD.idUnitW = 2 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " ) " & _
            " group by t1.DateSale) as DB1 "
            sAdapter.Fill(sDt_ToTal2)
        LB2.Text = "ยอดขาย " & FormatNumber(sDt_ToTal2.Rows(0).Item("totalnet"), 2, , , TriState.True) & " บาท"


    End Sub

    Function MonthNameToCode(ByVal MonthString As String) As String
        Dim MonthName As String = ""
        Select Case MonthString
            Case "1"
                MonthName = "มกราคม"
            Case "2"
                MonthName = "กุมภาพันธ์"
            Case "3"
                MonthName = "มีนาคม"
            Case "4"
                MonthName = "เมษายน"
            Case "5"
                MonthName = "พฤษภาคม"
            Case "6"
                MonthName = "มิถุนายน"
            Case "7"
                MonthName = "กรกฏาคม"
            Case "8"
                MonthName = "สิงหาคม"
            Case "9"
                MonthName = "กันยายน"
            Case "10"
                MonthName = "ตุลาคม"
            Case "11"
                MonthName = "พฤศจิกายน"
            Case "12"
                MonthName = "ธันวาคม"
        End Select
        Return MonthName
    End Function

    Private Sub dgvData_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        mdLoadShow()
        For i As Integer = 0 To dgvData.Rows.Count - 1
            dgvData.Rows(i).Cells(Flag1.Name).Value = 0
        Next
        If dgvData.Columns(e.ColumnIndex).Name = CHK1.Name Then
            If dgvData.Rows(e.RowIndex).Cells(Flag1.Name).Value = 0 Then
                dgvData.Rows(e.RowIndex).Cells(Flag1.Name).Value = 1
            End If
        End If

        For i As Integer = 0 To dgvData.Rows.Count - 1
            dgvData.Rows(i).Cells(CHK1.Name).Value = False
            If dgvData.Rows(i).Cells(Flag1.Name).Value = 1 Then
                dgvData.Rows(i).Cells(CHK1.Name).Value = True
            End If
        Next
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Distinct '' AS idPdPk, '' AS PdPkName, 0 as Flag , 0 AS Num  From vPackingPdSet P"
        sAdapter.Fill(sDt)
        sDt.Clear()
        BindPd2(dgvData.Rows(e.RowIndex).Cells(idPlantType.Name).Value)
        dgvData3.DataSource = sDt
        mdLoadCommitt()
    End Sub

    Private Sub dgvData2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData2.CellContentClick
        mdLoadShow()
        For i As Integer = 0 To dgvData2.Rows.Count - 1
            dgvData2.Rows(i).Cells(Flag2.Name).Value = 0
        Next
        If dgvData2.Columns(e.ColumnIndex).Name = CHK2.Name Then
            If dgvData2.Rows(e.RowIndex).Cells(Flag2.Name).Value = 0 Then
                dgvData2.Rows(e.RowIndex).Cells(Flag2.Name).Value = 1
            End If
        End If

        For i As Integer = 0 To dgvData2.Rows.Count - 1
            dgvData2.Rows(i).Cells(CHK2.Name).Value = False
            If dgvData2.Rows(i).Cells(Flag2.Name).Value = 1 Then
                dgvData2.Rows(i).Cells(CHK2.Name).Value = True
            End If
        Next
        BindPd3(dgvData2.Rows(e.RowIndex).Cells(idPdT.Name).Value)
        mdLoadCommitt()
    End Sub

    Private Sub dgvData3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData3.CellContentClick
        mdLoadShow()
        For i As Integer = 0 To dgvData3.Rows.Count - 1
            dgvData3.Rows(i).Cells(Flag3.Name).Value = 0
        Next
        If dgvData3.Columns(e.ColumnIndex).Name = CHK3.Name Then
            If dgvData3.Rows(e.RowIndex).Cells(Flag3.Name).Value = 0 Then
                dgvData3.Rows(e.RowIndex).Cells(Flag3.Name).Value = 1
            End If
        End If

        For i As Integer = 0 To dgvData3.Rows.Count - 1
            dgvData3.Rows(i).Cells(CHK3.Name).Value = False
            If dgvData3.Rows(i).Cells(Flag3.Name).Value = 1 Then
                dgvData3.Rows(i).Cells(CHK3.Name).Value = True
            End If
        Next
        mdLoadCommitt()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB2.Click

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub frmMkSaleStockSummary_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Date3.Value = Date.Today
        Date3.Format = DateTimePickerFormat.Custom
        Date3.CustomFormat = "yyyy"
        Dim yaerS As String = Microsoft.VisualBasic.Right(Date3.Text, 4)
        Dim sDt As New DataTable
        Dim sDt_ToTal As New DataTable
        mdLoadShow()
        mdCnOpen()
        sCommand.CommandText = " SELECT SUM(Totalnet) AS totalnet " & _
        " FROM (Select MONTH (t1.DateSale) AS MonthS ,SUM((SmD.Amount * Pack.Weight)/1000) AS Totalnet " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
        " WHERE(t1.idPsCancel Is NULL And SmD.idUnitW = 1 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " ) " & _
        " group by t1.DateSale " & _
        " UNION " & _
        " Select MONTH (t1.DateSale)  AS MonthS ,SUM(SmD.Amount * Pack.Weight) AS Totalnet  " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
        " WHERE(t1.idPsCancel Is NULL And SmD.idUnitW = 2 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " ) " & _
        " group by t1.DateSale) as DB1 "
        sAdapter.Fill(sDt_ToTal)
        LB1.Text = "ยอดรวมน้ำหนัก " & FormatNumber(sDt_ToTal.Rows(0).Item("totalnet"), 3, , , TriState.True) & " กิโลกรัม"

        Dim sDt_ToTal2 As New DataTable
        mdCnOpen()
        sCommand.CommandText = " SELECT SUM(Totalnet) AS totalnet " & _
        " FROM (Select MONTH (t1.DateSale) AS MonthS ,SUM(SmD.Price*SmD.Amount) AS Totalnet " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
        " WHERE(t1.idPsCancel Is NULL And SmD.idUnitW = 1 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " ) " & _
        " group by t1.DateSale " & _
        " UNION " & _
        " Select MONTH (t1.DateSale)  AS MonthS ,SUM(SmD.Price*SmD.Amount) AS Totalnet  " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk inner JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv  " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
        " WHERE(t1.idPsCancel Is NULL And SmD.idUnitW = 2 And SmD.idPkUnit <> 3 And Year(t1.DateSale) = " & yaerS & " ) " & _
        " group by t1.DateSale) as DB1 "
        sAdapter.Fill(sDt_ToTal2)
        LB2.Text = "ยอดขาย " & FormatNumber(sDt_ToTal2.Rows(0).Item("totalnet"), 2, , , TriState.True) & " บาท"
        BindPd()
        flag = 1

        mdLoadCommitt()
    End Sub

    Private Sub Date3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Date3_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Date3.ValueChanged
        If flag = 1 Then
            BindPd()
        End If
    End Sub
End Class