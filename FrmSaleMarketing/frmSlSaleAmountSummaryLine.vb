Public Class frmSlSaleAmountSummaryLine
    Dim stLoad As Integer = 0
    Dim CountChk As Integer = 0
    Dim stDel As Integer = 0

    Private Sub frmSlSaleAmountSummaryLine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        Me.dtpThisYearS.Value = Date.Today
        Me.dtpYear.Value = Date.Today
        cmbPlantNameAmt()
        ChartLineMonthAmt()

        BindDataPdAmt()
        mdLoadCommitt()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        mdLoadShow()
        ChartLineMonthAmt()
        mdLoadCommitt()
    End Sub

    Private Sub cmbPlantNameAmt()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT distinct idPlant, PlantName From vSlPdTradeNameD Order By PlantName"
        sAdapter.Fill(sDt)

        With Cmbplant
            .DisplayMember = "PlantName"
            .ValueMember = "idPlant"
            .DataSource = sDt
        End With
    End Sub

    Private Sub cmbPdTradeNameAmt()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idPdT, PdTradeName From vSlPdTradeNameD " & _
                               "WHERE idPlant = '" & Me.Cmbplant.SelectedValue & "' Order By PdTradeName"
        'sCommand.CommandText = "SELECT Pd.idPdT, Pd.PdTradeName, SUM(d.Price * d.Amount) AS Total " & _
        '                           "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
        '                           "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
        '                           "ON d.idPdPk = p.idPdPk INNER JOIN vSlPdTradeNameD As Pd " & _
        '                           "ON p.idPdT = Pd.idPdT WHERE m.idComp = '" & sIdComp & "' " & _
        '                           "AND m.idPsCancel IS NULL AND " & _
        '                           "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
        '                           "GROUP BY Pd.idPdT, Pd.PdTradeName Order By Total DESC"
        sAdapter.Fill(sDt)
        'For i As Integer = 0 To sDt.Rows.Count - 1
        '    sDt.Rows(i).Item("PdTradeName") = sDt.Rows(i).Item("PdTradeName") & " : " & Format(sDt.Rows(i).Item("Total"), "#,##0.00")
        'Next

        With cmbPdT
            .DisplayMember = "PdTradeName"
            .ValueMember = "idPdT"
            .DataSource = sDt
        End With
    End Sub

    Private Sub cmbPdPkNameAmt()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idPdPk, PdPkName From vPackingPdSet Where idPdT = '" & Me.cmbPdT.SelectedValue & "' Order By PdPkName"
        'sCommand.CommandText = "SELECT p.idPdPk, p.PdPkName, SUM(d.Price * d.Amount) AS Total " & _
        '                                  "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
        '                                  "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
        '                                  "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
        '                                  "AND m.idPsCancel IS NULL AND " & _
        '                                  "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
        '                                  "AND p.IdPdT = '" & Me.cmbPdT.SelectedValue & "' " & _
        '                                  "GROUP BY p.idPdPk, p.PdPkname Order By Total DESC"
        sAdapter.Fill(sDt)
        'For i As Integer = 0 To sDt.Rows.Count - 1
        '    sDt.Rows(i).Item("PdPkName") = sDt.Rows(i).Item("PdPkName") & " : " & Format(sDt.Rows(i).Item("Total"), "#,##0.00")
        'Next
        If sDt.Rows.Count = 0 Then
            Me.cmbPdPk.Text = ""
        End If
        With cmbPdPk
            .DisplayMember = "PdPkName"
            .ValueMember = "idPdPk"
            .DataSource = sDt
        End With
    End Sub


    Private Sub ChkPdPk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPdPk.CheckedChanged
        If Me.ChkPdPk.Checked = True Then
            Me.cmbPdPk.Enabled = True
        Else
            Me.cmbPdPk.Enabled = False
        End If
    End Sub

    Private Sub cmbPdT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPdT.SelectedIndexChanged
        cmbPdPkNameAmt()
    End Sub

    Sub ChartLineMonthAmt()
        Dim MonthSummary As New DataTable
        MonthSummary.Clear()
        MonthSummary.Columns.Add("IdMonth", System.Type.GetType("System.String"))
        MonthSummary.Columns.Add("Month", System.Type.GetType("System.String"))
        MonthSummary.Columns.Add("TotalNet", System.Type.GetType("System.Double"))

        MonthSummary.Rows.Add("01", "มกราคม", 0)
        MonthSummary.Rows.Add("02", "กุมภาพันธ์", 0)
        MonthSummary.Rows.Add("03", "มีนาคม", 0)
        MonthSummary.Rows.Add("04", "เมษายน", 0)
        MonthSummary.Rows.Add("05", "พฤษภาคม", 0)
        MonthSummary.Rows.Add("06", "มิถุนายน", 0)
        MonthSummary.Rows.Add("07", "กรกฎาคม", 0)
        MonthSummary.Rows.Add("08", "สิงหาคม", 0)
        MonthSummary.Rows.Add("09", "กันยายน", 0)
        MonthSummary.Rows.Add("10", "ตุลาคม", 0)
        MonthSummary.Rows.Add("11", "พฤศจิกายน", 0)
        MonthSummary.Rows.Add("12", "ธันวาคม", 0)

        Chart1.Series.Clear()
        mdCnOpen()
        Dim vWhere As String = " AND p.idPlant = '" & Me.Cmbplant.SelectedValue & "' "
        If Me.ChkPd.Checked = True Then
            vWhere = vWhere & " AND p.idPdT = '" & Me.cmbPdT.SelectedValue & "' "
        End If

        If Me.ChkPdPk.Checked = True Then
            vWhere = vWhere & " AND d.idPdPk = '" & Me.cmbPdPk.SelectedValue & "' "
        End If

        '***************************This Year*****************************************'
        Dim thisYear As String = Me.dtpYear.Text
        Dim vDt As New DataTable
        vDt.Clear()
        sCommand.CommandText = "SELECT month, SUM(Total) AS total FROM (SELECT " & _
                               "SUBSTRING(m.DateSale, 5, 2) AS month, SUM(d.Weight * d.Amount) " & _
                               "AS total FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 2 AND m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "" & vWhere & " GROUP BY SUBSTRING(m.DateSale, 5, 2) UNION " & _
                               "SELECT SUBSTRING(m.DateSale, 5, 2) AS month, SUM(d.Weight*d.Amount/1000) " & _
                               "AS total FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d .idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 1 " & _
                               "AND m.idComp = '" & sIdComp & "' AND m.idPsCancel IS NULL " & _
                               "AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "" & vWhere & " GROUP BY SUBSTRING(m.DateSale, 5, 2)) AS result GROUP BY month"
        sAdapter.Fill(vDt)

        For i As Integer = 0 To vDt.Rows.Count - 1
            If vDt.Rows(i).Item("month") = "01" Then
                MonthSummary.Rows(0).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "02" Then
                MonthSummary.Rows(1).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "03" Then
                MonthSummary.Rows(2).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "04" Then
                MonthSummary.Rows(3).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "05" Then
                MonthSummary.Rows(4).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "06" Then
                MonthSummary.Rows(5).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "07" Then
                MonthSummary.Rows(6).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "08" Then
                MonthSummary.Rows(7).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "09" Then
                MonthSummary.Rows(8).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "10" Then
                MonthSummary.Rows(9).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "11" Then
                MonthSummary.Rows(10).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "12" Then
                MonthSummary.Rows(11).Item("TotalNet") = vDt.Rows(i).Item("total")
            End If
        Next

        Chart1.Series.Add(thisYear)
        Chart1.Series(thisYear).ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series(thisYear).Points.DataBindXY(MonthSummary.DefaultView, "Month", MonthSummary.DefaultView, "TotalNet")
        Chart1.Series(thisYear).IsVisibleInLegend = True
        Chart1.Series(thisYear).IsValueShownAsLabel = False
        Chart1.Series(thisYear).ToolTip = "จำนวนขาย: #VALY{##,##0.00} (Kg)"
        Chart1.Series(thisYear).BorderWidth = 3

        '***************************YearPrv1*****************************************'
        Dim YearPrv1 As String = CInt(Me.dtpYear.Text) - 1
        For i As Integer = 0 To MonthSummary.Rows.Count - 1
            MonthSummary.Rows(i).Item("TotalNet") = 0
        Next

        vDt.Clear()
        sCommand.CommandText = "SELECT month, SUM(Total) AS total FROM (SELECT " & _
                                "SUBSTRING(m.DateSale, 5, 2) AS month, SUM(d.Weight * d.Amount) " & _
                                "AS total FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                                "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                                "ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 2 AND m.idComp = '" & sIdComp & "' " & _
                                "AND m.idPsCancel IS NULL AND " & _
                                "SUBSTRING(m.DateSale, 1, 4) = '" & YearPrv1 & "' " & _
                                "" & vWhere & " GROUP BY SUBSTRING(m.DateSale, 5, 2) UNION " & _
                                "SELECT SUBSTRING(m.DateSale, 5, 2) AS month, SUM(d.Weight*d.Amount/1000) " & _
                                "AS total FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                                "ON m.idSale = d .idSale INNER JOIN vPackingPdSet AS p " & _
                                "ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 1 " & _
                                "AND m.idComp = '" & sIdComp & "' AND m.idPsCancel IS NULL " & _
                                "AND (SUBSTRING(m.DateSale, 1, 4) = '" & YearPrv1 & "') " & _
                                "" & vWhere & " GROUP BY SUBSTRING(m.DateSale, 5, 2)) AS result GROUP BY month"
        sAdapter.Fill(vDt)

        For i As Integer = 0 To vDt.Rows.Count - 1
            If vDt.Rows(i).Item("month") = "01" Then
                MonthSummary.Rows(0).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "02" Then
                MonthSummary.Rows(1).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "03" Then
                MonthSummary.Rows(2).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "04" Then
                MonthSummary.Rows(3).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "05" Then
                MonthSummary.Rows(4).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "06" Then
                MonthSummary.Rows(5).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "07" Then
                MonthSummary.Rows(6).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "08" Then
                MonthSummary.Rows(7).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "09" Then
                MonthSummary.Rows(8).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "10" Then
                MonthSummary.Rows(9).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "11" Then
                MonthSummary.Rows(10).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "12" Then
                MonthSummary.Rows(11).Item("TotalNet") = vDt.Rows(i).Item("total")
            End If
        Next


        Chart1.Series.Add(YearPrv1)
        Chart1.Series(YearPrv1).ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series(YearPrv1).Points.DataBindXY(MonthSummary.DefaultView, "Month", MonthSummary.DefaultView, "TotalNet")
        Chart1.Series(YearPrv1).IsVisibleInLegend = True
        Chart1.Series(YearPrv1).IsValueShownAsLabel = False
        Chart1.Series(YearPrv1).ToolTip = "จำนวนขาย: #VALY{##,##0.00} (Kg)"
        Chart1.Series(YearPrv1).BorderWidth = 2


        '***************************YearPrv2*****************************************'
        Dim YearPrv2 As String = CInt(Me.dtpYear.Text) - 2
        For i As Integer = 0 To MonthSummary.Rows.Count - 1
            MonthSummary.Rows(i).Item("TotalNet") = 0
        Next

        vDt.Clear()
        sCommand.CommandText = "SELECT month, SUM(Total) AS total FROM (SELECT " & _
                               "SUBSTRING(m.DateSale, 5, 2) AS month, SUM(d.Weight * d.Amount) " & _
                               "AS total FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 2 AND m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & YearPrv2 & "' " & _
                               "" & vWhere & " GROUP BY SUBSTRING(m.DateSale, 5, 2) UNION " & _
                               "SELECT SUBSTRING(m.DateSale, 5, 2) AS month, SUM(d.Weight*d.Amount/1000) " & _
                               "AS total FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d .idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 1 " & _
                               "AND m.idComp = '" & sIdComp & "' AND m.idPsCancel IS NULL " & _
                               "AND (SUBSTRING(m.DateSale, 1, 4) = '" & YearPrv2 & "') " & _
                               "" & vWhere & " GROUP BY SUBSTRING(m.DateSale, 5, 2)) AS result GROUP BY month"

        sAdapter.Fill(vDt)
        For i As Integer = 0 To vDt.Rows.Count - 1
            If vDt.Rows(i).Item("month") = "01" Then
                MonthSummary.Rows(0).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "02" Then
                MonthSummary.Rows(1).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "03" Then
                MonthSummary.Rows(2).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "04" Then
                MonthSummary.Rows(3).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "05" Then
                MonthSummary.Rows(4).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "06" Then
                MonthSummary.Rows(5).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "07" Then
                MonthSummary.Rows(6).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "08" Then
                MonthSummary.Rows(7).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "09" Then
                MonthSummary.Rows(8).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "10" Then
                MonthSummary.Rows(9).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "11" Then
                MonthSummary.Rows(10).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "12" Then
                MonthSummary.Rows(11).Item("TotalNet") = vDt.Rows(i).Item("total")
            End If
        Next

        Chart1.Series.Add(YearPrv2)
        Chart1.Series(YearPrv2).ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series(YearPrv2).Points.DataBindXY(MonthSummary.DefaultView, "Month", MonthSummary.DefaultView, "TotalNet")
        Chart1.Series(YearPrv2).IsVisibleInLegend = True
        Chart1.Series(YearPrv2).IsValueShownAsLabel = False
        Chart1.Series(YearPrv2).ToolTip = "จำนวนขาย: #VALY{##,##0.00} (Kg)"
        Chart1.Series(YearPrv2).BorderWidth = 2

        '***************************YearPrv3*****************************************'
        Dim YearPrv3 As String = CInt(Me.dtpYear.Text) - 3
        For i As Integer = 0 To MonthSummary.Rows.Count - 1
            MonthSummary.Rows(i).Item("TotalNet") = 0
        Next

        vDt.Clear()
        sCommand.CommandText = "SELECT month, SUM(Total) AS total FROM (SELECT " & _
                               "SUBSTRING(m.DateSale, 5, 2) AS month, SUM(d.Weight * d.Amount) " & _
                               "AS total FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 2 AND m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & YearPrv3 & "' " & _
                               "" & vWhere & " GROUP BY SUBSTRING(m.DateSale, 5, 2) UNION " & _
                               "SELECT SUBSTRING(m.DateSale, 5, 2) AS month, SUM(d.Weight*d.Amount/1000) " & _
                               "AS total FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d .idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 1 " & _
                               "AND m.idComp = '" & sIdComp & "' AND m.idPsCancel IS NULL " & _
                               "AND (SUBSTRING(m.DateSale, 1, 4) = '" & YearPrv3 & "') " & _
                               "" & vWhere & " GROUP BY SUBSTRING(m.DateSale, 5, 2)) AS result GROUP BY month"

        sAdapter.Fill(vDt)
        For i As Integer = 0 To vDt.Rows.Count - 1
            If vDt.Rows(i).Item("month") = "01" Then
                MonthSummary.Rows(0).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "02" Then
                MonthSummary.Rows(1).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "03" Then
                MonthSummary.Rows(2).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "04" Then
                MonthSummary.Rows(3).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "05" Then
                MonthSummary.Rows(4).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "06" Then
                MonthSummary.Rows(5).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "07" Then
                MonthSummary.Rows(6).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "08" Then
                MonthSummary.Rows(7).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "09" Then
                MonthSummary.Rows(8).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "10" Then
                MonthSummary.Rows(9).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "11" Then
                MonthSummary.Rows(10).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "12" Then
                MonthSummary.Rows(11).Item("TotalNet") = vDt.Rows(i).Item("total")
            End If
        Next

        Chart1.Series.Add(YearPrv3)
        Chart1.Series(YearPrv3).ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series(YearPrv3).Points.DataBindXY(MonthSummary.DefaultView, "Month", MonthSummary.DefaultView, "TotalNet")
        Chart1.Series(YearPrv3).IsVisibleInLegend = True
        Chart1.Series(YearPrv3).IsValueShownAsLabel = False
        Chart1.Series(YearPrv3).ToolTip = "จำนวนขาย: #VALY{##,##0.00} (Kg)"
        Chart1.Series(YearPrv3).BorderWidth = 2
        Chart1.Series(YearPrv3).Color = Color.Plum


        '***************************YearPrv4*****************************************'
        Dim YearPrv4 As String = CInt(Me.dtpYear.Text) - 4
        For i As Integer = 0 To MonthSummary.Rows.Count - 1
            MonthSummary.Rows(i).Item("TotalNet") = 0
        Next

        vDt.Clear()
        sCommand.CommandText = "SELECT month, SUM(Total) AS total FROM (SELECT " & _
                                 "SUBSTRING(m.DateSale, 5, 2) AS month, SUM(d.Weight * d.Amount) " & _
                                 "AS total FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                                 "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                                 "ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 2 AND m.idComp = '" & sIdComp & "' " & _
                                 "AND m.idPsCancel IS NULL AND " & _
                                 "SUBSTRING(m.DateSale, 1, 4) = '" & YearPrv4 & "' " & _
                                 "" & vWhere & " GROUP BY SUBSTRING(m.DateSale, 5, 2) UNION " & _
                                 "SELECT SUBSTRING(m.DateSale, 5, 2) AS month, SUM(d.Weight*d.Amount/1000) " & _
                                 "AS total FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                                 "ON m.idSale = d .idSale INNER JOIN vPackingPdSet AS p " & _
                                 "ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 1 " & _
                                 "AND m.idComp = '" & sIdComp & "' AND m.idPsCancel IS NULL " & _
                                 "AND (SUBSTRING(m.DateSale, 1, 4) = '" & YearPrv4 & "') " & _
                                 "" & vWhere & " GROUP BY SUBSTRING(m.DateSale, 5, 2)) AS result GROUP BY month"

        sAdapter.Fill(vDt)

        For i As Integer = 0 To vDt.Rows.Count - 1
            If vDt.Rows(i).Item("month") = "01" Then
                MonthSummary.Rows(0).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "02" Then
                MonthSummary.Rows(1).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "03" Then
                MonthSummary.Rows(2).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "04" Then
                MonthSummary.Rows(3).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "05" Then
                MonthSummary.Rows(4).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "06" Then
                MonthSummary.Rows(5).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "07" Then
                MonthSummary.Rows(6).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "08" Then
                MonthSummary.Rows(7).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "09" Then
                MonthSummary.Rows(8).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "10" Then
                MonthSummary.Rows(9).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "11" Then
                MonthSummary.Rows(10).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "12" Then
                MonthSummary.Rows(11).Item("TotalNet") = vDt.Rows(i).Item("total")
            End If
        Next

        Chart1.Series.Add(YearPrv4)
        Chart1.Series(YearPrv4).ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series(YearPrv4).Points.DataBindXY(MonthSummary.DefaultView, "Month", MonthSummary.DefaultView, "TotalNet")
        Chart1.Series(YearPrv4).IsVisibleInLegend = True
        Chart1.Series(YearPrv4).IsValueShownAsLabel = False
        Chart1.Series(YearPrv4).ToolTip = "จำนวนขาย: #VALY{##,##0.00} (Kg)"
        Chart1.Series(YearPrv4).BorderWidth = 2
        Chart1.Series(YearPrv4).Color = Color.MediumPurple

        '***************************YearPrv5*****************************************'
        Dim YearPrv5 As String = CInt(Me.dtpYear.Text) - 5
        For i As Integer = 0 To MonthSummary.Rows.Count - 1
            MonthSummary.Rows(i).Item("TotalNet") = 0
        Next

        vDt.Clear()
        sCommand.CommandText = "SELECT month, SUM(Total) AS total FROM (SELECT " & _
                                 "SUBSTRING(m.DateSale, 5, 2) AS month, SUM(d.Weight * d.Amount) " & _
                                 "AS total FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                                 "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                                 "ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 2 AND m.idComp = '" & sIdComp & "' " & _
                                 "AND m.idPsCancel IS NULL AND " & _
                                 "SUBSTRING(m.DateSale, 1, 4) = '" & YearPrv5 & "' " & _
                                 "" & vWhere & " GROUP BY SUBSTRING(m.DateSale, 5, 2) UNION " & _
                                 "SELECT SUBSTRING(m.DateSale, 5, 2) AS month, SUM(d.Weight*d.Amount/1000) " & _
                                 "AS total FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                                 "ON m.idSale = d .idSale INNER JOIN vPackingPdSet AS p " & _
                                 "ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 1 " & _
                                 "AND m.idComp = '" & sIdComp & "' AND m.idPsCancel IS NULL " & _
                                 "AND (SUBSTRING(m.DateSale, 1, 4) = '" & YearPrv5 & "') " & _
                                 "" & vWhere & " GROUP BY SUBSTRING(m.DateSale, 5, 2)) AS result GROUP BY month"

        sAdapter.Fill(vDt)
        For i As Integer = 0 To vDt.Rows.Count - 1
            If vDt.Rows(i).Item("month") = "01" Then
                MonthSummary.Rows(0).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "02" Then
                MonthSummary.Rows(1).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "03" Then
                MonthSummary.Rows(2).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "04" Then
                MonthSummary.Rows(3).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "05" Then
                MonthSummary.Rows(4).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "06" Then
                MonthSummary.Rows(5).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "07" Then
                MonthSummary.Rows(6).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "08" Then
                MonthSummary.Rows(7).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "09" Then
                MonthSummary.Rows(8).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "10" Then
                MonthSummary.Rows(9).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "11" Then
                MonthSummary.Rows(10).Item("TotalNet") = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "12" Then
                MonthSummary.Rows(11).Item("TotalNet") = vDt.Rows(i).Item("total")
            End If
        Next


        Chart1.Series.Add(YearPrv5)
        Chart1.Series(YearPrv5).ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series(YearPrv5).Points.DataBindXY(MonthSummary.DefaultView, "Month", MonthSummary.DefaultView, "TotalNet")
        Chart1.Series(YearPrv5).IsVisibleInLegend = True
        Chart1.Series(YearPrv5).IsValueShownAsLabel = False
        Chart1.Series(YearPrv5).ToolTip = "จำนวนขาย: #VALY{##,##0.00} (Kg)"
        Chart1.Series(YearPrv5).BorderWidth = 3
        Chart1.Series(YearPrv5).Color = Color.Green

        If Me.ChkPdPk.Checked = False Then
            If Me.ChkPd.Checked = False Then 'idPlant
                Chart1.Titles(0).Text = "กราฟเปรียบเทียบจำนวนขาย (Kg) " & Trim(Me.Cmbplant.Text) & " ระหว่างปี " & YearPrv5 & " - " & Me.dtpYear.Text
            Else 'idPdT
                Chart1.Titles(0).Text = "กราฟเปรียบเทียบจำนวนขาย (Kg) " & Trim(Me.cmbPdT.Text) & " ระหว่างปี " & YearPrv5 & " - " & Me.dtpYear.Text
            End If
        Else 'idPdPk
            Chart1.Titles(0).Text = "กราฟเปรียบเทียบจำนวนขาย (Kg) " & Trim(cmbPdPk.Text) & " ระหว่างปี " & YearPrv5 & " - " & Me.dtpYear.Text
        End If

        With Chart1.ChartAreas("ChartArea1").AxisY
            .TitleFont = New Font("Times New Roman", 10, FontStyle.Bold)
            .LabelStyle.Format = "##,#"
        End With

        With Chart1.ChartAreas("ChartArea1").AxisX
            .TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)
        End With
    End Sub

    '--------------------------------------------End 1st Tab-------------------------------------'

    Sub BindDataPdAmt()
        stLoad = 1

        Dim vdtpYear As String = ""
        If Me.dtpThisYearS.Text = "" Then
            vdtpYear = (Microsoft.VisualBasic.Right(Date.Today, 4))
        Else
            vdtpYear = Me.dtpThisYearS.Text
        End If


        Dim Dt As New DataTable
        Dt.Clear()
        mdCnOpen()
        If Me.rdbPlant.Checked = True Then 'idPlant
            dgvData.Columns("colPName").HeaderText = "ชื่อพืช"
            sCommand.CommandText = "SELECT idP, PName, SUM(SumThisY) AS SumThisY FROM " & _
                                   "(SELECT p.idPlant AS idP, p.PlantName AS PName, " & _
                                   "SUM(d.Weight * d.Amount) AS SumThisY FROM SmSaleMt AS m INNER JOIN " & _
                                   "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                                   "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 2 " & _
                                   "AND m.idComp = '" & sIdComp & "' AND m.idPsCancel IS NULL " & _
                                   "AND SUBSTRING(m.DateSale, 1, 4) = '" & vdtpYear & "' " & _
                                   "GROUP BY p.idPlant, p.PlantName UNION SELECT p.idPlant AS idP, " & _
                                   "p.PlantName AS PName, SUM(d.Weight * d.Amount / 1000) AS SumThisY " & _
                                   "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                                   "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                                   "d.idUnitW = 1 AND m.idComp = '" & sIdComp & "' " & _
                                   "AND m.idPsCancel IS NULL AND " & _
                                   "SUBSTRING(m.DateSale, 1, 4) = '" & vdtpYear & "' " & _
                                   "GROUP BY p.idPlant, p.PlantName) AS result GROUP BY idP, PName"
            sAdapter.Fill(Dt)

        ElseIf Me.rdbPdT.Checked = True Then 'idPdT
            dgvData.Columns("colPName").HeaderText = "ชื่อสินค้า"
            sCommand.CommandText = "SELECT idP, PName, SUM(SumThisY) AS SumThisY FROM " & _
                                   "(SELECT p.idPdT AS idP, p.PdTradeName AS PName, " & _
                                   "SUM(d.Weight * d.Amount) AS SumThisY FROM SmSaleMt AS m INNER JOIN " & _
                                   "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                                   "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 2 " & _
                                   "AND m.idComp = '" & sIdComp & "' AND m.idPsCancel IS NULL " & _
                                   "AND SUBSTRING(m.DateSale, 1, 4) = '" & vdtpYear & "' " & _
                                   "GROUP BY p.idPdT, p.PdTradeName UNION SELECT p.idPdT AS idP, " & _
                                   "p.PdTradeName AS PName, SUM(d.Weight * d.Amount / 1000) AS SumThisY " & _
                                   "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                                   "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                                   "d.idUnitW = 1 AND m.idComp = '" & sIdComp & "' " & _
                                   "AND m.idPsCancel IS NULL AND " & _
                                   "SUBSTRING(m.DateSale, 1, 4) = '" & vdtpYear & "' " & _
                                   "GROUP BY p.idPdT, p.PdTradeName) AS result GROUP BY idP, PName"
            sAdapter.Fill(Dt)
        Else 'idPdPk
            dgvData.Columns("colPName").HeaderText = "ชื่อสินค้าแบบ Package"
            sCommand.CommandText = "SELECT idP, PName, SUM(SumThisY) AS SumThisY FROM " & _
                                   "(SELECT d.idPdPk AS idP, p.PdPkName AS PName, " & _
                                   "SUM(d.Weight * d.Amount) AS SumThisY FROM SmSaleMt AS m INNER JOIN " & _
                                   "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                                   "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 2 " & _
                                   "AND m.idComp = '" & sIdComp & "' AND m.idPsCancel IS NULL " & _
                                   "AND SUBSTRING(m.DateSale, 1, 4) = '" & vdtpYear & "' " & _
                                   "GROUP BY d.idPdPk, p.PdPkName UNION SELECT d.idPdPk AS idP, " & _
                                   "p.PdPkName AS PName, SUM(d.Weight * d.Amount / 1000) AS SumThisY " & _
                                   "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                                   "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                                   "d.idUnitW = 1 AND m.idComp = '" & sIdComp & "' " & _
                                   "AND m.idPsCancel IS NULL AND " & _
                                   "SUBSTRING(m.DateSale, 1, 4) = '" & vdtpYear & "' GROUP BY " & _
                                   "d.idPdPk, p.PdPkName) AS result GROUP BY idP, PName"
            sAdapter.Fill(Dt)
        End If

        If Dt.Rows.Count = 0 Then
            dgvData.DataSource = Dt
            Exit Sub
        Else
            If Me.rdbTotalNet.Checked = True Then
                Dt.DefaultView.Sort = "[SumThisY] DESC"
            ElseIf Me.rdbPdnameO.Checked = True Then
                Dt.DefaultView.Sort = "[PName] ASC"
            End If
            dgvData.DataSource = Dt
        End If

        Dim vTitle As String = ""
        If Me.rdbPlant.Checked = True Then
            vTitle = Me.rdbPlant.Text
        ElseIf Me.rdbPdT.Checked = True Then
            vTitle = Me.rdbPdT.Text
        Else
            vTitle = Me.rdbPdPk.Text
        End If

        Chart2.Titles(0).Text = "กราฟเปรียบเทียบจำนวนขาย (Kg) จำแนกตาม" & vTitle & " ปี " & vdtpYear
        Chart2.Legends(0).Title = vTitle

        With Chart2.ChartAreas("ChartArea1").AxisY
            .TitleFont = New Font("Times New Roman", 9, FontStyle.Bold)
            .LabelStyle.Format = "##,#"
        End With

        With Chart2.ChartAreas("ChartArea1").AxisX
            .TitleFont = New Font("Times New Roman", 10, FontStyle.Bold)
        End With

    End Sub

    Private Sub rdbPdPk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPdPk.CheckedChanged
        If Me.rdbPdPk.Checked = True And stLoad = 1 Then
            CountChk = 0
            BindDataPdAmt()
            Chart2.Series.Clear()
        End If
    End Sub

    Private Sub rdbPdT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPdT.CheckedChanged
        If Me.rdbPdT.Checked = True And stLoad = 1 Then
            CountChk = 0
            BindDataPdAmt()
            Chart2.Series.Clear()
        End If

    End Sub

    Private Sub dtpThisYearS_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpThisYearS.ValueChanged
        If stLoad = 1 Then
            CountChk = 0
            BindDataPdAmt()
            Chart2.Series.Clear()
        End If
    End Sub

    Private Sub btnShowS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowS.Click
        mdLoadShow()
        ChartLinePdAmt()
        mdLoadCommitt()
    End Sub

    Sub ChartLinePdAmt()
        Chart2.Series.Clear()

        '---DataTabel เก็บสินค้าที่เลือก 10 รายการ---'
        Dim PdSelect As New DataTable
        PdSelect.Clear()
        PdSelect.Columns.Add("idP", System.Type.GetType("System.String"))
        PdSelect.Columns.Add("PName", System.Type.GetType("System.String"))

        For i As Integer = 0 To dgvData.Rows.Count - 1
            If dgvData.Rows(i).Cells(ColSelect.Name).Value = True Then
                PdSelect.Rows.Add(dgvData.Rows(i).Cells(colidP.Name).Value, dgvData.Rows(i).Cells(colPName.Name).Value)
            End If
        Next

        Dim PdSummary As New DataTable
        PdSummary.Clear()
        PdSummary.Columns.Add("IdMonth", System.Type.GetType("System.String"))
        PdSummary.Columns.Add("Month", System.Type.GetType("System.String"))
        PdSummary.Columns.Add("TotalNet", System.Type.GetType("System.Double"))

        PdSummary.Rows.Add("01", "มกราคม", 0)
        PdSummary.Rows.Add("02", "กุมภาพันธ์", 0)
        PdSummary.Rows.Add("03", "มีนาคม", 0)
        PdSummary.Rows.Add("04", "เมษายน", 0)
        PdSummary.Rows.Add("05", "พฤษภาคม", 0)
        PdSummary.Rows.Add("06", "มิถุนายน", 0)
        PdSummary.Rows.Add("07", "กรกฎาคม", 0)
        PdSummary.Rows.Add("08", "สิงหาคม", 0)
        PdSummary.Rows.Add("09", "กันยายน", 0)
        PdSummary.Rows.Add("10", "ตุลาคม", 0)
        PdSummary.Rows.Add("11", "พฤศจิกายน", 0)
        PdSummary.Rows.Add("12", "ธันวาคม", 0)


        mdCnOpen()
        '****************** Loop Add Line *****************************************'
        For i As Integer = 0 To PdSelect.Rows.Count - 1
            Dim vWhere As String = ""
            If Me.rdbPlant.Checked = True Then 'idPlant
                vWhere = " AND p.idPlant = '" & PdSelect.Rows(i).Item("idP") & "' "
            ElseIf Me.rdbPdT.Checked = True Then 'idPdT
                vWhere = " AND p.idPdT = '" & PdSelect.Rows(i).Item("idP") & "' "
            ElseIf Me.rdbPdPk.Checked = True Then  'idPdPk
                vWhere = " AND d.idPdPk = '" & PdSelect.Rows(i).Item("idP") & "' "
            End If

            For j As Integer = 0 To PdSummary.Rows.Count - 1
                PdSummary.Rows(j).Item("TotalNet") = 0
            Next

            Dim vDt As New DataTable
            vDt.Clear()
            sCommand.CommandText = "SELECT month, SUM(Total) AS total FROM (SELECT " & _
                                   "SUBSTRING(m.DateSale, 5, 2) AS month, SUM(d.Weight * d.Amount) " & _
                                   "AS total FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                                   "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                                   "ON d.idPdPk = p.idPdPk WHERE d.idUnitW = 2 " & _
                                   "AND m.idComp = '" & sIdComp & "' AND m.idPsCancel IS NULL " & _
                                   "AND SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpThisYearS.Text & "' " & _
                                   "" & vWhere & " GROUP BY SUBSTRING(m.DateSale, 5, 2) UNION " & _
                                   "SELECT SUBSTRING(m.DateSale, 5, 2) AS month, " & _
                                   "SUM(d.Weight*d.Amount/1000) AS total FROM SmSaleMt AS m " & _
                                   "INNER JOIN SmSaleDt AS d ON m.idSale = d .idSale INNER JOIN " & _
                                   "vPackingPdSet AS p ON d .idPdPk = p.idPdPk WHERE " & _
                                   "d.idUnitW = 1 AND m.idComp = '" & sIdComp & "' " & _
                                   "AND m.idPsCancel IS NULL AND " & _
                                   "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpThisYearS.Text & "' " & _
                                   "" & vWhere & " GROUP BY SUBSTRING(m.DateSale, 5, 2)) AS result GROUP BY month"
            sAdapter.Fill(vDt)

            For j As Integer = 0 To vDt.Rows.Count - 1
                If vDt.Rows(j).Item("month") = "01" Then
                    PdSummary.Rows(0).Item("TotalNet") = vDt.Rows(j).Item("total")
                ElseIf vDt.Rows(j).Item("month") = "02" Then
                    PdSummary.Rows(1).Item("TotalNet") = vDt.Rows(j).Item("total")
                ElseIf vDt.Rows(j).Item("month") = "03" Then
                    PdSummary.Rows(2).Item("TotalNet") = vDt.Rows(j).Item("total")
                ElseIf vDt.Rows(j).Item("month") = "04" Then
                    PdSummary.Rows(3).Item("TotalNet") = vDt.Rows(j).Item("total")
                ElseIf vDt.Rows(j).Item("month") = "05" Then
                    PdSummary.Rows(4).Item("TotalNet") = vDt.Rows(j).Item("total")
                ElseIf vDt.Rows(j).Item("month") = "06" Then
                    PdSummary.Rows(5).Item("TotalNet") = vDt.Rows(j).Item("total")
                ElseIf vDt.Rows(j).Item("month") = "07" Then
                    PdSummary.Rows(6).Item("TotalNet") = vDt.Rows(j).Item("total")
                ElseIf vDt.Rows(j).Item("month") = "08" Then
                    PdSummary.Rows(7).Item("TotalNet") = vDt.Rows(j).Item("total")
                ElseIf vDt.Rows(j).Item("month") = "09" Then
                    PdSummary.Rows(8).Item("TotalNet") = vDt.Rows(j).Item("total")
                ElseIf vDt.Rows(j).Item("month") = "10" Then
                    PdSummary.Rows(9).Item("TotalNet") = vDt.Rows(j).Item("total")
                ElseIf vDt.Rows(j).Item("month") = "11" Then
                    PdSummary.Rows(10).Item("TotalNet") = vDt.Rows(j).Item("total")
                ElseIf vDt.Rows(j).Item("month") = "12" Then
                    PdSummary.Rows(11).Item("TotalNet") = vDt.Rows(j).Item("total")
                End If
            Next

            Dim LinePdName As String = PdSelect.Rows(i).Item("PName")
            Chart2.Series.Add(LinePdName)
            Chart2.Series(LinePdName).ChartType = DataVisualization.Charting.SeriesChartType.Line
            Chart2.Series(LinePdName).Points.DataBindXY(PdSummary.DefaultView, "Month", PdSummary.DefaultView, "TotalNet")
            Chart2.Series(LinePdName).IsVisibleInLegend = True
            Chart2.Series(LinePdName).IsValueShownAsLabel = False
            Chart2.Series(LinePdName).ToolTip = "จำนวนขาย : #VALY{##,##0.00} (Kg)"
            Chart2.Series(LinePdName).BorderWidth = 2
        Next
    End Sub

    Private Sub dgvData_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellValueChanged
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvData.Columns(e.ColumnIndex).Name = ColSelect.Name Then
            If CountChk < 10 And dgvData.Rows(e.RowIndex).Cells(ColSelect.Name).Value = True Then 'Check + Get10
                CountChk = CountChk + 1
                dgvData.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
                ' MessageBox.Show(CountChk)
            ElseIf CountChk < 10 And dgvData.Rows(e.RowIndex).Cells(ColSelect.Name).Value = False Then 'Uncheck + Get10
                CountChk = CountChk - 1
                dgvData.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)
                dgvData.Rows(e.RowIndex).Cells("ColSelect").Style.BackColor = Color.White
                If CountChk < 0 Then
                    CountChk = 0
                End If
            ElseIf CountChk >= 10 And dgvData.Rows(e.RowIndex).Cells(ColSelect.Name).Value = True Then 'Check + NoGet10
                MessageBox.Show("สามารถเลือกพืช หรือสินค้า หรือสินค้าแบบ Package ได้มากสุด 10 รายการ " & _
                                vbCrLf & "      กรุณากดปุ่มแสดงข้อมูล เพื่อดูกราฟเปรียบเทียบยอดขาย", sSystemName)
                stDel = 1
                dgvData.Rows(e.RowIndex).Cells(ColSelect.Name).Value = False
            ElseIf CountChk >= 10 And dgvData.Rows(e.RowIndex).Cells(ColSelect.Name).Value = False Then 'UnCheck + NoGet10
                If stDel = 0 Then
                    CountChk = CountChk - 1
                    dgvData.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)
                    dgvData.Rows(e.RowIndex).Cells("ColSelect").Style.BackColor = Color.White
                End If
                stDel = 0
            End If

            Chart2.Series.Clear()
            'mdLoadShow()
            'ChartLinePd()
            'mdLoadCommitt()
        End If
    End Sub

    Private Sub rdbTotalNet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTotalNet.CheckedChanged
        If Me.rdbTotalNet.Checked = True And stLoad = 1 Then
            CountChk = 0
            BindDataPdAmt()
            Chart2.Series.Clear()
        End If
    End Sub

    Private Sub rdbPdnameO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPdnameO.CheckedChanged
        If Me.rdbPdnameO.Checked = True And stLoad = 1 Then
            CountChk = 0
            BindDataPdAmt()
            Chart2.Series.Clear()
        End If
    End Sub

    Private Sub Cmbplant_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbplant.SelectedIndexChanged
        cmbPdTradeNameAmt()
    End Sub

    Private Sub ChkPd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPd.CheckedChanged
        If Me.ChkPd.Checked = True Then
            Me.cmbPdT.Enabled = True
            Me.ChkPdPk.Enabled = True
        Else
            Me.cmbPdT.Enabled = False
            Me.ChkPdPk.Enabled = False
            Me.ChkPdPk.Checked = False
        End If
    End Sub

    Private Sub rdbPlant_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPlant.CheckedChanged
        If Me.rdbPlant.Checked = True And stLoad = 1 Then
            CountChk = 0
            BindDataPdAmt()
            Chart2.Series.Clear()
        End If
    End Sub
End Class