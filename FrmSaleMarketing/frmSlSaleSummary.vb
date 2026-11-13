Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmSlSaleSummary
    Dim stPage As Integer = 0

    Private Sub frmSlSaleSummary_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        mdLoadShow()
        Me.dtpYear.Value = Date.Today
        Dim monthDt As New DataTable
        Dim r As Integer = dgvMonth.Rows.Count() ' = 1 Header

        r = dgvMonth.Rows.Count()
        dgvMonth.Rows.Add()
        dgvMonth.Rows(r - 1).Cells("ColMonth").Value = "มกราคม"
        dgvMonth.Rows(r - 1).Cells("ColNumM").Value = "1"
        r = dgvMonth.Rows.Count()
        dgvMonth.Rows.Add()
        dgvMonth.Rows(r - 1).Cells("ColMonth").Value = "กุมภาพันธ์"
        dgvMonth.Rows(r - 1).Cells("ColNumM").Value = "2"
        r = dgvMonth.Rows.Count()
        dgvMonth.Rows.Add()
        dgvMonth.Rows(r - 1).Cells("ColMonth").Value = "มีนาคม"
        dgvMonth.Rows(r - 1).Cells("ColNumM").Value = "3"
        r = dgvMonth.Rows.Count()
        dgvMonth.Rows.Add()
        dgvMonth.Rows(r - 1).Cells("ColMonth").Value = "เมษายน"
        dgvMonth.Rows(r - 1).Cells("ColNumM").Value = "4"
        r = dgvMonth.Rows.Count()
        dgvMonth.Rows.Add()
        dgvMonth.Rows(r - 1).Cells("ColMonth").Value = "พฤษภาคม"
        dgvMonth.Rows(r - 1).Cells("ColNumM").Value = "5"
        r = dgvMonth.Rows.Count()
        dgvMonth.Rows.Add()
        dgvMonth.Rows(r - 1).Cells("ColMonth").Value = "มิถุนายน"
        dgvMonth.Rows(r - 1).Cells("ColNumM").Value = "6"
        r = dgvMonth.Rows.Count()
        dgvMonth.Rows.Add()
        dgvMonth.Rows(r - 1).Cells("ColMonth").Value = "กรกฎาคม"
        dgvMonth.Rows(r - 1).Cells("ColNumM").Value = "7"
        r = dgvMonth.Rows.Count()
        dgvMonth.Rows.Add()
        dgvMonth.Rows(r - 1).Cells("ColMonth").Value = "สิงหาคม"
        dgvMonth.Rows(r - 1).Cells("ColNumM").Value = "8"
        r = dgvMonth.Rows.Count()
        dgvMonth.Rows.Add()
        dgvMonth.Rows(r - 1).Cells("ColMonth").Value = "กันยายน"
        dgvMonth.Rows(r - 1).Cells("ColNumM").Value = "9"
        r = dgvMonth.Rows.Count()
        dgvMonth.Rows.Add()
        dgvMonth.Rows(r - 1).Cells("ColMonth").Value = "ตุลาคม"
        dgvMonth.Rows(r - 1).Cells("ColNumM").Value = "10"
        r = dgvMonth.Rows.Count()
        dgvMonth.Rows.Add()
        dgvMonth.Rows(r - 1).Cells("ColMonth").Value = "พฤศจิกายน"
        dgvMonth.Rows(r - 1).Cells("ColNumM").Value = "11"
        r = dgvMonth.Rows.Count()
        dgvMonth.Rows.Add()
        dgvMonth.Rows(r - 1).Cells("ColMonth").Value = "ธันวาคม"
        dgvMonth.Rows(r - 1).Cells("ColNumM").Value = "12"
        dgvMonth.AllowUserToAddRows = False

        SumMonth()
        ChartMonth()
        SummaryPlant()
        SummaryPdT()
        SummaryPdPk()
        SumPaSale()
        ChartPsSale()
        SumCusName()
        ChartCusName()
        stPage = 1
        mdLoadCommitt()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        mdLoadShow()
        SumMonth()
        ChartMonth()
        SummaryPlant()
        SummaryPdT()
        SummaryPdPk()
        SumPaSale()
        ChartPsSale()
        SumCusName()
        ChartCusName()
        mdLoadCommitt()
    End Sub

    Sub SumMonth()
        Me.dgvMonth.Columns("ColthisYear").HeaderText = "ยอดขายปี " & Me.dtpYear.Text
        Dim lastYear As Integer = Me.dtpYear.Text - 1
        Me.dgvMonth.Columns("ColLastyear").HeaderText = "ยอดขายปี " & lastYear

        For i As Integer = 0 To dgvMonth.Rows.Count - 1
            dgvMonth.Rows(i).Cells("ColthisYear").Value = 0.0
            dgvMonth.Rows(i).Cells("ColLastyear").Value = 0.0
            dgvMonth.Rows(i).Cells("ColGrowUp").Value = 0.0
            dgvMonth.Rows(i).Cells("ColRatio").Value = 0.0
        Next

        '****** This year ******'
        Dim vDt As New DataTable
        vDt.Clear()
        mdCnOpen()

        sCommand.CommandText = "Select SUBSTRING(DateSale, 5, 2) as month, SUM(TotalNet) as total " & _
                               "From vSmSaleMt Where (SUBSTRING(DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND idPsCancel IS Null AND idComp = '" & sIdComp & "' GROUP BY SUBSTRING(DateSale, 5, 2) "
        sAdapter.Fill(vDt)
        For i As Integer = 0 To vDt.Rows.Count - 1
            If vDt.Rows(i).Item("month") = "01" Then
                dgvMonth.Rows(0).Cells("ColthisYear").Value = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "02" Then
                dgvMonth.Rows(1).Cells("ColthisYear").Value = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "03" Then
                dgvMonth.Rows(2).Cells("ColthisYear").Value = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "04" Then
                dgvMonth.Rows(3).Cells("ColthisYear").Value = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "05" Then
                dgvMonth.Rows(4).Cells("ColthisYear").Value = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "06" Then
                dgvMonth.Rows(5).Cells("ColthisYear").Value = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "07" Then
                dgvMonth.Rows(6).Cells("ColthisYear").Value = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "08" Then
                dgvMonth.Rows(7).Cells("ColthisYear").Value = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "09" Then
                dgvMonth.Rows(8).Cells("ColthisYear").Value = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "10" Then
                dgvMonth.Rows(9).Cells("ColthisYear").Value = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "11" Then
                dgvMonth.Rows(10).Cells("ColthisYear").Value = vDt.Rows(i).Item("total")
            ElseIf vDt.Rows(i).Item("month") = "12" Then
                dgvMonth.Rows(11).Cells("ColthisYear").Value = vDt.Rows(i).Item("total")
            End If
        Next
        '****** End This year ******'

        '****** Last year ******'
        'Dim lastYear As Integer = Me.dtpYear.Text - 1
        Dim lastDt As New DataTable
        vDt.Clear()
        mdCnOpen()

        sCommand.CommandText = "Select SUBSTRING(DateSale, 5, 2) as month, SUM(TotalNet) as total " & _
                               "From vSmSaleMt Where (SUBSTRING(DateSale, 1, 4) = '" & lastYear & "') " & _
                               "AND idPsCancel IS Null AND idComp = '" & sIdComp & "' GROUP BY SUBSTRING(DateSale, 5, 2)"
        sAdapter.Fill(lastDt)
        For i As Integer = 0 To lastDt.Rows.Count - 1
            If lastDt.Rows(i).Item("month") = "01" Then
                dgvMonth.Rows(0).Cells("ColLastyear").Value = lastDt.Rows(i).Item("total")
            ElseIf lastDt.Rows(i).Item("month") = "02" Then
                dgvMonth.Rows(1).Cells("ColLastyear").Value = lastDt.Rows(i).Item("total")
            ElseIf lastDt.Rows(i).Item("month") = "03" Then
                dgvMonth.Rows(2).Cells("ColLastyear").Value = lastDt.Rows(i).Item("total")
            ElseIf lastDt.Rows(i).Item("month") = "04" Then
                dgvMonth.Rows(3).Cells("ColLastyear").Value = lastDt.Rows(i).Item("total")
            ElseIf lastDt.Rows(i).Item("month") = "05" Then
                dgvMonth.Rows(4).Cells("ColLastyear").Value = lastDt.Rows(i).Item("total")
            ElseIf lastDt.Rows(i).Item("month") = "06" Then
                dgvMonth.Rows(5).Cells("ColLastyear").Value = lastDt.Rows(i).Item("total")
            ElseIf lastDt.Rows(i).Item("month") = "07" Then
                dgvMonth.Rows(6).Cells("ColLastyear").Value = lastDt.Rows(i).Item("total")
            ElseIf lastDt.Rows(i).Item("month") = "08" Then
                dgvMonth.Rows(7).Cells("ColLastyear").Value = lastDt.Rows(i).Item("total")
            ElseIf lastDt.Rows(i).Item("month") = "09" Then
                dgvMonth.Rows(8).Cells("ColLastyear").Value = lastDt.Rows(i).Item("total")
            ElseIf lastDt.Rows(i).Item("month") = "10" Then
                dgvMonth.Rows(9).Cells("ColLastyear").Value = lastDt.Rows(i).Item("total")
            ElseIf lastDt.Rows(i).Item("month") = "11" Then
                dgvMonth.Rows(10).Cells("ColLastyear").Value = lastDt.Rows(i).Item("total")
            ElseIf lastDt.Rows(i).Item("month") = "12" Then
                dgvMonth.Rows(11).Cells("ColLastyear").Value = lastDt.Rows(i).Item("total")
            End If
        Next
        '****** End Last year ******'

        '****** Cal %สัดส่วน  & % เติบโต *****'
        Dim SumThisYear As Double = 0.0
        Dim SumLastYear As Double = 0.0
        Dim CntMonth As Double = 0
        Dim CntGrowUp As Double = 0

        For i As Integer = 0 To dgvMonth.Rows.Count - 1
            SumThisYear += dgvMonth.Rows(i).Cells("ColthisYear").Value
            SumLastYear += dgvMonth.Rows(i).Cells("ColLastyear").Value
            If dgvMonth.Rows(i).Cells("ColthisYear").Value <> 0.0 Then
                CntMonth += 1
            End If
        Next
        Me.txtSumthisY.Text = Format(SumThisYear, "#,##0.00")
        Me.txtSumLastY.Text = Format(SumLastYear, "#,##0.00")
        If SumLastYear = 0.0 Then
            Me.txtGrowUp.Text = "0.00"
        Else
            Me.txtGrowUp.Text = Format(((SumThisYear - SumLastYear) / SumLastYear) * 100, "#,##0.00")
        End If

        If CntMonth = 0 Then
            Me.txtAvgMonth.Text = 0.0
        Else
            Me.txtAvgMonth.Text = Format(SumThisYear / CntMonth, "#,##0.00")
        End If


        For i As Integer = 0 To dgvMonth.Rows.Count - 1
            If Me.txtSumthisY.Text = 0.0 Then
                dgvMonth.Rows(i).Cells("ColRatio").Value = 0.0
            Else
                dgvMonth.Rows(i).Cells("ColRatio").Value = (dgvMonth.Rows(i).Cells("ColthisYear").Value / CDbl(Me.txtSumthisY.Text)) * 100
            End If

            If dgvMonth.Rows(i).Cells("ColthisYear").Value = 0 Or dgvMonth.Rows(i).Cells("ColLastyear").Value = 0 Then
                dgvMonth.Rows(i).Cells("ColGrowUp").Value = 0.0
            Else
                dgvMonth.Rows(i).Cells("ColGrowUp").Value = ((dgvMonth.Rows(i).Cells("ColthisYear").Value - dgvMonth.Rows(i).Cells("ColLastyear").Value) / dgvMonth.Rows(i).Cells("ColLastyear").Value) * 100
            End If
        Next

    End Sub

    Sub ChartMonth()
        Dim SaleSummary As New DataTable
        Dim cntTotalNet As Integer = 0
        SaleSummary.Clear()
        mdCnOpen()

        SaleSummary.Columns.Add("Month", System.Type.GetType("System.String"))
        SaleSummary.Columns.Add("TotalNet", System.Type.GetType("System.Double"))

        For i As Integer = 0 To dgvMonth.Rows.Count - 1
            'If Me.dgvMonth.Rows(i).Cells("ColthisYear").Value > 0 Then
            SaleSummary.Rows.Add()
            SaleSummary.Rows(i).Item("Month") = dgvMonth.Rows(i).Cells("ColMonth").Value
            SaleSummary.Rows(i).Item("TotalNet") = Format(dgvMonth.Rows(i).Cells("ColthisYear").Value, "#,##0.00")
            If dgvMonth.Rows(i).Cells("ColthisYear").Value = 0 Then
                cntTotalNet += 1
            End If
            ' End If
        Next

        Me.Chart1.DataSource = SaleSummary
        Chart1.Series("Series1").XValueMember = "Month"
        Chart1.Series("Series1").YValueMembers = "TotalNet"
        Chart1.DataBind()
        If Me.rdbColumn.Checked = True Then
            'Column
            Chart1.Series("Series1").ChartType = SeriesChartType.Column
            Chart1.Series("Series1")("PointWidth") = "0.5"
            Chart1.Palette = ChartColorPalette.SemiTransparent

            Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
            Chart1.ChartAreas("ChartArea1").Area3DStyle.Inclination = 60
            Chart1.ChartAreas("ChartArea1").Area3DStyle.PointDepth = 20
            Chart1.ChartAreas("ChartArea1").Area3DStyle.PointGapDepth = 100
            Chart1.ChartAreas("ChartArea1").Area3DStyle.Rotation = 30
            Chart1.ChartAreas("ChartArea1").Area3DStyle.WallWidth = 10

            Chart1.Series("Series1").LabelForeColor = Color.Tomato
            Chart1.Series("Series1").Label = "#PERCENT{P2}"
            Chart1.Series("Series1").LabelAngle = 0
            Chart1.Series("Series1")("PieLabelStyle") = "Outside"
            Chart1.Series("Series1").BorderWidth = 1
            Chart1.Series("Series1").BorderColor = System.Drawing.Color.Black

            Chart1.Legends("Legend1").Enabled = False
            Chart1.Titles(0).Text = "รายงานสรุปยอดขายประจำปี " & Me.dtpYear.Text
            With Chart1.ChartAreas("ChartArea1").AxisY
                .TitleFont = New Font("Times New Roman", 10, FontStyle.Bold)
                .LabelStyle.Format = "##,#"
            End With

            With Chart1.ChartAreas("ChartArea1").AxisX
                .TitleFont = New Font("Times New Roman", 8, FontStyle.Bold)
                .MajorGrid.Enabled = False  ''ไม่แสดงเส้น Grid
            End With
        ElseIf Me.rdbPie.Checked = True Then
            'Pie
            Chart1.Series("Series1").ChartType = SeriesChartType.Pie
            Chart1.Palette = ChartColorPalette.BrightPastel
            Chart1.Series("Series1")("PointWidth") = "1"

            ' Chart1.Series("Series1")("PieDrawingStyle") = "SoftEdge"
            Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = False


            Chart1.Series("Series1").IsValueShownAsLabel = True
            Chart1.Series("Series1").LabelForeColor = Color.Tomato
            Chart1.Series("Series1").Label = "#PERCENT{P2}"
            Chart1.Series("Series1").LabelAngle = 0
            Chart1.Series("Series1")("PieLabelStyle") = "Outside"
            Chart1.Series("Series1").BorderWidth = 1
            Chart1.Series("Series1").BorderColor = System.Drawing.Color.Black
            Chart1.Series("Series1").LegendText = "#VALX (#VALY{C2})"

            'Chart1.Series("Series1").LegendText = "#VALX (#PERCENT)"
            'Chart1.Series("Series1").BorderColor = System.Drawing.Color.FromArgb(26, 59, 105)

            'Chart1.Width = 500
            Chart1.Legends("Legend1").Enabled = True
            Chart1.Legends("Legend1").LegendStyle = LegendStyle.Table
            Chart1.Legends("Legend1").Font = New Font("Times New Roman", 9, FontStyle.Regular)
            Chart1.Legends("Legend1").Docking = Docking.Right
            Chart1.Legends("Legend1").Alignment = System.Drawing.StringAlignment.Center

            'Chart1.Legends("Legend1").TableStyle = LegendTableStyle.Wide

            'Chart1.Series("Series1")("PieLabelStyle") = "Disabled"
            'Chart1.Series("Series1").Label = "#VALX : #VALY%"
            'Chart1.Series("Series1").Label = "#VALY%"
        End If

        'Me.Chart1.DataSource = SaleSummary
        'Chart1.Series("Series1").XValueMember = "Month"
        'Chart1.Series("Series1").YValueMembers = "TotalNet"
        'Chart1.DataBind()
        ''Chart1.Titles(0).Text = "รายงานสรุปยอดขาย" + ControlChars.Lf + "ประจำปี " & Me.dtpYear.Text
        'Chart1.Titles(0).Text = "รายงานสรุปยอดขายประจำปี " & Me.dtpYear.Text
        'With Chart1.ChartAreas("ChartArea1").AxisY
        '    .TitleFont = New Font("Times New Roman", 10, FontStyle.Bold)
        '    .LabelStyle.Format = "##,#"
        'End With

        'With Chart1.ChartAreas("ChartArea1").AxisX
        '    .TitleFont = New Font("Times New Roman", 8, FontStyle.Bold)
        '    .MajorGrid.Enabled = False  ''ไม่แสดงเส้น Grid
        '    '.IntervalAutoMode = IntervalAutoMode.FixedCount
        '    '.Interval = 1
        '    '    .majorgtickmark.interval = 1   ''กำหนดให้จำนวนที่จะแสดง
        '    '    .LabelAutoFitMaxFontSize = 8   '' กำหนดขนาดตัวอักษร
        '    ' .LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep45 ''กำหนดลักษณะการแสดงของหัวข้อ เช่น แนวนอน/ตั้ง 45/90 องศา
        'End With
        ''Dim vRpt As New crpSaleMonthChart
        ''If cntTotalNet <> 12 Then
        ''    vRpt.SetDataSource(SaleSummary)
        ''End If
        ''vRpt.SetParameterValue(vRpt.Parameter_Title.ParameterFieldName, "รายงานสรุปยอดขายประจำปี " & Me.dtpYear.Text)
        ''Me.CrystalReportViewer1.ReportSource = vRpt
    End Sub

    Sub ChartPsSale()
        Dim SaleSummary As New DataTable
        SaleSummary.Clear()
        mdCnOpen()

        SaleSummary.Columns.Add("PsSale", System.Type.GetType("System.String"))
        SaleSummary.Columns.Add("TotalNet", System.Type.GetType("System.Double"))

        For i As Integer = 0 To dgvPsSale.Rows.Count - 1
            'If Me.dgvPsSale.Rows(i).Cells("ColThisTS").Value > 0 Then
            SaleSummary.Rows.Add()
            SaleSummary.Rows(i).Item("PsSale") = dgvPsSale.Rows(i).Cells("ColPsSale").Value.ToString.Substring(0, 10)
            SaleSummary.Rows(i).Item("TotalNet") = dgvPsSale.Rows(i).Cells("ColThisTS").Value
            'End If

        Next

        Me.Chart2.DataSource = SaleSummary
        Chart2.Series("Series1").XValueMember = "PsSale"
        Chart2.Series("Series1").YValueMembers = "TotalNet"
        Chart2.DataBind()
        If Me.rdbColSale.Checked = True Then
            'Column
            Chart2.Series("Series1").ChartType = SeriesChartType.Column
            Chart2.Series("Series1")("PointWidth") = "0.5"
            Chart2.Palette = ChartColorPalette.SemiTransparent

            Chart2.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
            Chart2.ChartAreas("ChartArea1").Area3DStyle.Inclination = 60
            Chart2.ChartAreas("ChartArea1").Area3DStyle.PointDepth = 20
            Chart2.ChartAreas("ChartArea1").Area3DStyle.PointGapDepth = 100
            Chart2.ChartAreas("ChartArea1").Area3DStyle.Rotation = 30
            Chart2.ChartAreas("ChartArea1").Area3DStyle.WallWidth = 10
            Chart2.ChartAreas("ChartArea1").BackColor = Color.FromArgb(255, 224, 192)

            Chart2.Series("Series1").LabelForeColor = Color.Tomato
            Chart2.Series("Series1").Label = "#PERCENT{P2}"
            Chart2.Series("Series1").LabelAngle = 0
            Chart2.Series("Series1")("PieLabelStyle") = "Outside"
            Chart2.Series("Series1").BorderWidth = 1
            Chart2.Series("Series1").BorderColor = System.Drawing.Color.Black

            Chart2.Legends("Legend1").Enabled = False
            Chart2.Titles(0).Text = "รายงานสรุปยอดขายประจำปี " & Me.dtpYear.Text
            With Chart2.ChartAreas("ChartArea1").AxisY
                .TitleFont = New Font("Times New Roman", 10, FontStyle.Bold)
                .LabelStyle.Format = "##,#"
            End With

            With Chart2.ChartAreas("ChartArea1").AxisX
                .TitleFont = New Font("Times New Roman", 8, FontStyle.Bold)
                .MajorGrid.Enabled = False  ''ไม่แสดงเส้น Grid
            End With
        ElseIf Me.rdbPieSale.Checked = True Then
            'Pie
            Chart2.Series("Series1").ChartType = SeriesChartType.Pie
            Chart2.Palette = ChartColorPalette.BrightPastel
            Chart2.Series("Series1")("PointWidth") = "1"

            Chart2.ChartAreas("ChartArea1").Area3DStyle.Enable3D = False
            Chart2.ChartAreas("ChartArea1").BackColor = Color.Transparent

            Chart2.Series("Series1").IsValueShownAsLabel = True
            Chart2.Series("Series1").LabelForeColor = Color.Tomato
            Chart2.Series("Series1").Label = "#PERCENT{P2}"
            Chart2.Series("Series1").LabelAngle = 0
            Chart2.Series("Series1")("PieLabelStyle") = "Outside"
            Chart2.Series("Series1").BorderWidth = 1
            Chart2.Series("Series1").BorderColor = System.Drawing.Color.Black
            Chart2.Series("Series1").LegendText = "#VALX (#VALY{C2})"

            Chart2.Legends("Legend1").Enabled = True
            Chart2.Legends("Legend1").LegendStyle = LegendStyle.Table
            Chart2.Legends("Legend1").Font = New Font("Times New Roman", 9, FontStyle.Regular)
            Chart2.Legends("Legend1").Docking = Docking.Right
            Chart2.Legends("Legend1").Alignment = System.Drawing.StringAlignment.Center

        End If

        'Me.Chart2.DataSource = SaleSummary
        'Chart2.Series("Series1").XValueMember = "PsSale"
        'Chart2.Series("Series1").YValueMembers = "TotalNet"
        'Chart2.DataBind()
        'Chart2.Titles(0).Text = "รายงานสรุปยอดขายประจำปี " & Me.dtpYear.Text
        'With Chart2.ChartAreas("ChartArea1").AxisY
        '    .TitleFont = New Font("Times New Roman", 10, FontStyle.Bold)
        '    .LabelStyle.Format = "##,#"
        'End With

        'With Chart2.ChartAreas("ChartArea1").AxisX
        '    .TitleFont = New Font("Times New Roman", 8, FontStyle.Bold)
        '    .MajorGrid.Enabled = False  'ไม่แสดงเส้น Grid
        'End With
        ''Dim vRpt As New crpSalePsSaleChart
        ''vRpt.SetDataSource(SaleSummary)
        ''vRpt.SetParameterValue(vRpt.Parameter_Title.ParameterFieldName, "รายงานสรุปยอดขายประจำปี " & Me.dtpYear.Text)
        ''Me.CrystalReportViewer2.ReportSource = vRpt
    End Sub

    Sub ChartCusName()
        Dim SaleSummary As New DataTable
        SaleSummary.Clear()
        mdCnOpen()

        SaleSummary.Columns.Add("CusName", System.Type.GetType("System.String"))
        SaleSummary.Columns.Add("TotalNet", System.Type.GetType("System.Double"))

        If dgvCus.Rows.Count <> 0 Then
            For i As Integer = 0 To 9
                SaleSummary.Rows.Add()
                'SaleSummary.Rows(i).Item("CusName") = dgvCus.Rows(i).Cells("ColCusName").Value.ToString.Substring(0, 10)
                SaleSummary.Rows(i).Item("CusName") = dgvCus.Rows(i).Cells("ColCusName").Value
                SaleSummary.Rows(i).Item("TotalNet") = dgvCus.Rows(i).Cells("ColThisYC").Value
            Next
        End If

        Me.Chart3.DataSource = SaleSummary
        Chart3.Series("Series1").XValueMember = "CusName"
        Chart3.Series("Series1").YValueMembers = "TotalNet"
        Chart3.DataBind()
        If Me.rdbColCus.Checked = True Then
            'Column
            Chart3.Series("Series1").ChartType = SeriesChartType.Column
            Chart3.Series("Series1")("PointWidth") = "0.5"
            Chart3.Palette = ChartColorPalette.SemiTransparent

            Chart3.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
            Chart3.ChartAreas("ChartArea1").Area3DStyle.Inclination = 60
            Chart3.ChartAreas("ChartArea1").Area3DStyle.PointDepth = 20
            Chart3.ChartAreas("ChartArea1").Area3DStyle.PointGapDepth = 100
            Chart3.ChartAreas("ChartArea1").Area3DStyle.Rotation = 30
            Chart3.ChartAreas("ChartArea1").Area3DStyle.WallWidth = 10
            Chart3.ChartAreas("ChartArea1").BackColor = Color.MistyRose

            Chart3.Series("Series1").LabelForeColor = Color.Tomato
            Chart3.Series("Series1").Label = "#PERCENT{P2}"
            Chart3.Series("Series1").LabelAngle = 0
            Chart3.Series("Series1")("PieLabelStyle") = "Outside"
            Chart3.Series("Series1").BorderWidth = 1
            Chart3.Series("Series1").BorderColor = System.Drawing.Color.Black

            Chart3.Legends("Legend1").Enabled = False
            Chart3.Titles(0).Text = "รายงานสรุปยอดขายประจำปี " & Me.dtpYear.Text
            With Chart3.ChartAreas("ChartArea1").AxisY
                .TitleFont = New Font("Times New Roman", 10, FontStyle.Bold)
                .LabelStyle.Format = "##,#"
            End With

            With Chart3.ChartAreas("ChartArea1").AxisX
                .TitleFont = New Font("Times New Roman", 8, FontStyle.Bold)
                .MajorGrid.Enabled = False  ''ไม่แสดงเส้น Grid
            End With
        ElseIf Me.rdbPieCus.Checked = True Then
            'Pie
            Chart3.Series("Series1").ChartType = SeriesChartType.Pie
            Chart3.Palette = ChartColorPalette.BrightPastel
            Chart3.Series("Series1")("PointWidth") = "1"

            Chart3.ChartAreas("ChartArea1").Area3DStyle.Enable3D = False
            Chart3.ChartAreas("ChartArea1").BackColor = Color.Transparent

            Chart3.Series("Series1").IsValueShownAsLabel = True
            Chart3.Series("Series1").LabelForeColor = Color.Tomato
            Chart3.Series("Series1").Label = "#PERCENT{P2}"
            Chart3.Series("Series1").LabelAngle = 0
            Chart3.Series("Series1")("PieLabelStyle") = "Outside"
            Chart3.Series("Series1").BorderWidth = 1
            Chart3.Series("Series1").BorderColor = System.Drawing.Color.Black
            Chart3.Series("Series1").LegendText = "#VALX (#VALY{C2})"

            Chart3.Legends("Legend1").Enabled = True
            Chart3.Legends("Legend1").LegendStyle = LegendStyle.Table
            Chart3.Legends("Legend1").Font = New Font("Times New Roman", 9, FontStyle.Regular)
            Chart3.Legends("Legend1").Docking = Docking.Right
            Chart3.Legends("Legend1").Alignment = System.Drawing.StringAlignment.Center
        End If

        'Me.Chart3.DataSource = SaleSummary
        'Chart3.Series("Series1").XValueMember = "CusName"
        'Chart3.Series("Series1").YValueMembers = "TotalNet"
        'Chart3.DataBind()
        'Chart3.Titles(0).Text = "รายงานสรุปยอดขายประจำปี " & Me.dtpYear.Text
        'With Chart3.ChartAreas("ChartArea1").AxisY
        '    .TitleFont = New Font("Times New Roman", 10, FontStyle.Bold)
        '    .LabelStyle.Format = "##,#"
        'End With

        'With Chart3.ChartAreas("ChartArea1").AxisX
        '    .TitleFont = New Font("Times New Roman", 8, FontStyle.Bold)
        '    .MajorGrid.Enabled = False  'ไม่แสดงเส้น Grid
        'End With
        ''Dim vRpt As New crpSaleCusChart
        ''vRpt.SetDataSource(SaleSummary)
        ''vRpt.SetParameterValue(vRpt.Parameter_Title.ParameterFieldName, "รายงานสรุปยอดขายประจำปี " & Me.dtpYear.Text)
        ''Me.CrystalReportViewer3.ReportSource = vRpt
    End Sub

    Sub SummaryPlant()
        Me.dgvPlant.Columns("ColSumYear").HeaderText = "ยอดขายปี " & Me.dtpYear.Text
        Me.dgvPlant.Columns("Coljan").HeaderText = "มกราคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPlant.Columns("ColFeb").HeaderText = "กุมภาพันธ์ " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPlant.Columns("ColMar").HeaderText = "มีนาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPlant.Columns("ColApr").HeaderText = "เมษายน " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPlant.Columns("ColMay").HeaderText = "พฤษภาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPlant.Columns("ColJun").HeaderText = "มิถุนายน " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPlant.Columns("ColJul").HeaderText = "กรกฎาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPlant.Columns("ColAug").HeaderText = "สิงหาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPlant.Columns("ColSep").HeaderText = "กันยายน " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPlant.Columns("ColOct").HeaderText = "ตุลาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPlant.Columns("ColNov").HeaderText = "พฤศจิกายน " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPlant.Columns("ColDec").HeaderText = "ธันวาคม " & Me.dtpYear.Text.Substring(2, 2)
        Dim lastYear As Integer = Me.dtpYear.Text - 1
        Me.dgvPlant.Columns("ColLastYP").HeaderText = "ยอดขายปี " & lastYear
        Me.dgvPlant.Columns("ColJanL").HeaderText = "มกราคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPlant.Columns("ColFebL").HeaderText = "กุมภาพันธ์ " & lastYear.ToString.Substring(2, 2)
        Me.dgvPlant.Columns("ColMarL").HeaderText = "มีนาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPlant.Columns("ColAprL").HeaderText = "เมษายน " & lastYear.ToString.Substring(2, 2)
        Me.dgvPlant.Columns("ColMayL").HeaderText = "พฤษภาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPlant.Columns("ColJunL").HeaderText = "มิถุนายน " & lastYear.ToString.Substring(2, 2)
        Me.dgvPlant.Columns("ColJulL").HeaderText = "กรกฎาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPlant.Columns("ColAugL").HeaderText = "สิงหาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPlant.Columns("ColSepL").HeaderText = "กันยายน " & lastYear.ToString.Substring(2, 2)
        Me.dgvPlant.Columns("ColOctL").HeaderText = "ตุลาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPlant.Columns("ColNovL").HeaderText = "พฤศจิกายน " & lastYear.ToString.Substring(2, 2)
        Me.dgvPlant.Columns("ColDecL").HeaderText = "ธันวาคม " & lastYear.ToString.Substring(2, 2)


        Dim Dt As New DataTable
        Dt.Clear()
        mdCnOpen()
        'sCommand.CommandText = "SELECT a.idPlant, a.PlantName, b.SumThisY, '0.00' As ratioP, '0.00' As GrowUpP, c.SumLastY, '0.00' As Jan, '0.00' As JanL, '0.00' As Feb, " & _
        '                       "'0.00' As FebL, '0.00' As Mar, '0.00' As MarL, '0.00' As Apr, '0.00' As AprL, '0.00' As May, '0.00' As MayL, " & _
        '                       "'0.00' As Jun, '0.00' As JunL, '0.00' As Jul, '0.00' As JulL, '0.00' As Aug, '0.00' As AugL, " & _
        '                       "'0.00' As Sep, '0.00' As SepL, '0.00' As Oct, '0.00' As OctL, '0.00' As Nov, '0.00' As NovL, " & _
        '                       "'0.00' As Dec, '0.00' As DecL FROM (SELECT p.idPlant, p.PlantName " & _
        '                       "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
        '                       "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE idPsCancel IS Null AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') OR " & _
        '                       "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') GROUP BY p.idPlant, p.PlantName) AS a FULL OUTER JOIN " & _
        '                       "(SELECT p.idPlant, SUM(d.Price*d.Amount) AS SumThisY FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
        '                       "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
        '                       "WHERE idPsCancel IS Null AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') GROUP BY p.idPlant) AS b " & _
        '                       "ON a.idPlant = b.idPlant FULL OUTER JOIN (SELECT p.idPlant, SUM(d.Price*d.Amount) AS SumLastY " & _
        '                       "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
        '                       "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE idPsCancel IS Null AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
        '                       "GROUP BY p.idPlant) AS c ON a.idPlant = c.idPlant ORDER BY b.SumThisY DESC"
        sCommand.CommandText = "SELECT p.idPlant, p.PlantName, 0.00 As SumThisY, 0.00 As ratioP, 0.00 As GrowUpP, " & _
                               "0.00 As SumLastY, 0.00 As Jan, 0.00 As JanL, 0.00 As Feb, " & _
                               "0.00 As FebL, 0.00 As Mar, 0.00 As MarL, 0.00 As Apr, 0.00 As AprL, 0.00 As May, 0.00 As MayL, " & _
                               "0.00 As Jun, 0.00 As JunL, 0.00 As Jul, 0.00 As JulL, 0.00 As Aug, 0.00 As AugL, " & _
                               "0.00 As Sep, 0.00 As SepL, 0.00 As Oct, 0.00 As OctL, 0.00 As Nov, 0.00 As NovL, " & _
                               "0.00 As Dec, 0.00 As DecL FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE idPsCancel IS Null AND idComp = '" & sIdComp & "' " & _
                               "AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') OR " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') GROUP BY p.idPlant, p.PlantName"

        sAdapter.Fill(Dt)
        'Dt.Columns.Add("SumYear", System.Type.GetType("System.Double"))

        ''************Summary ThisYear**************'
        Dim sDtY As New DataTable
        sDtY.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(SumThisY) AS SumThisY FROM (SELECT p.idPlant, " & _
                               "SUM(d.Price * d.Amount) AS SumThisY FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idPkUnit <> '3') AND idComp = '" & sIdComp & "' AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "GROUP BY p.idPlant UNION SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS SumThisY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idPkUnit = '3') AND idComp = '" & sIdComp & "' AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDtY)
        For i As Integer = 0 To sDtY.Rows.Count - 1
            For j As Integer = 0 To Dt.Rows.Count - 1
                If Dt.Rows(j).Item("idPlant") = sDtY.Rows(i).Item("idPlant") Then
                    Dt.Rows(j).Item("SumThisY") = Format(sDtY.Rows(i).Item("SumThisY"), "#,##0.00")
                    Exit For
                End If
            Next
        Next

        ''************Summary LastYear**************'
        Dim sDt2 As New DataTable
        sDt2.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(SumLastY) AS SumLastY FROM (SELECT p.idPlant, " & _
                              "SUM(d.Price * d.Amount) AS SumLastY FROM SmSaleMt AS m INNER JOIN " & _
                              "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE (d.idPkUnit <> '3') AND idComp = '" & sIdComp & "' AND " & _
                              "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
                              "GROUP BY p.idPlant UNION SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS SumLastY " & _
                              "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                              "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idPkUnit = '3') AND " & _
                              "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
                              "AND idComp = '" & sIdComp & "' GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt2)
        For i As Integer = 0 To sDt2.Rows.Count - 1
            For j As Integer = 0 To Dt.Rows.Count - 1
                If Dt.Rows(j).Item("idPlant") = sDt2.Rows(i).Item("idPlant") Then
                    Dt.Rows(j).Item("SumLastY") = Format(sDt2.Rows(i).Item("SumLastY"), "#,##0.00")
                    Exit For
                End If
            Next
        Next

        If Dt.Rows.Count = 0 Then
            'MessageBox.Show("ไม่พบข้อมูลที่แสดงรายงานได้", sSystemName)
            dgvPlant.DataSource = Dt
            Exit Sub
        Else
            Dt.DefaultView.Sort = "[SumThisY] DESC"
            dgvPlant.DataSource = Dt
        End If
        'dgvPlant.Sort(dgvPlant.Columns(ColSumYear.Name), System.ComponentModel.ListSortDirection.Descending)

        '*********** %เติบโต & %สัดส่วน ***********'
        Dim SumThisYearP As Double = 0.0
        For i As Integer = 0 To dgvPlant.Rows.Count - 1
            If dgvPlant.Rows(i).Cells("ColSumYear").Value Is DBNull.Value Then
                dgvPlant.Rows(i).Cells("ColSumYear").Value = Format(0.0, "#,##0.00")
            End If
            SumThisYearP += dgvPlant.Rows(i).Cells("ColSumYear").Value
        Next

        For i As Integer = 0 To dgvPlant.Rows.Count - 1
            If SumThisYearP = 0.0 Then
                dgvPlant.Rows(i).Cells("ColRatioP").Value = Format(0.0, "#,##0.00")
            Else
                dgvPlant.Rows(i).Cells("ColRatioP").Value = Format((dgvPlant.Rows(i).Cells("ColSumYear").Value / SumThisYearP) * 100, "#,##0.00")
            End If

            ''If dgvPlant.Rows(i).Cells("ColSumYear").Value Is DBNull.Value Then
            ''    dgvPlant.Rows(i).Cells("ColSumYear").Value = Format(0.0, "#,##0.00")
            ''End If

            'If dgvPlant.Rows(i).Cells("ColLastYP").Value Is DBNull.Value Then
            '    dgvPlant.Rows(i).Cells("ColLastYP").Value = Format(0.0, "#,##0.00")
            'End If

            If dgvPlant.Rows(i).Cells("ColLastYP").Value = 0.0 Then
                dgvPlant.Rows(i).Cells("ColGrowUpP").Value = "0.00"
            Else
                dgvPlant.Rows(i).Cells("ColGrowUpP").Value = ((CDbl(dgvPlant.Rows(i).Cells("ColSumYear").Value) - CDbl(dgvPlant.Rows(i).Cells("ColLastYP").Value)) / CDbl(dgvPlant.Rows(i).Cells("ColLastYP").Value)) * 100

                'Dim GrowpUpCal As Double = CDbl(dgvPlant.Rows(i).Cells("ColSumYear").Value) - CDbl(dgvPlant.Rows(i).Cells("ColLastYP").Value)
                'dgvPlant.Rows(i).Cells("ColGrowUpP").Value = Format(GrowpUpCal, "#,##0.00")
            End If
        Next

        '************Jan**************'
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                               "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01') AND (m.idPsCancel IS NULL) AND " & _
                               "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                               "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') AND (SUBSTRING(m.DateSale, 5, 2) = '01') " & _
                               "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                               "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("Coljan").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                              "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                              "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
                              "AND (SUBSTRING(m.DateSale, 5, 2) = '01') AND (m.idPsCancel IS NULL) AND " & _
                              "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                              "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                              "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                              "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                              "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') AND (SUBSTRING(m.DateSale, 5, 2) = '01') " & _
                              "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                              "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColJanL").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Fab**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                               "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02') AND (m.idPsCancel IS NULL) AND " & _
                               "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                               "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') AND (SUBSTRING(m.DateSale, 5, 2) = '02') " & _
                               "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                               "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColFeb").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                              "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                              "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
                              "AND (SUBSTRING(m.DateSale, 5, 2) = '02') AND (m.idPsCancel IS NULL) AND " & _
                              "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                              "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                              "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                              "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                              "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') AND (SUBSTRING(m.DateSale, 5, 2) = '02') " & _
                              "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                              "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColFebL").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Mar**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                              "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                              "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                              "AND (SUBSTRING(m.DateSale, 5, 2) = '03') AND (m.idPsCancel IS NULL) AND " & _
                              "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                              "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                              "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                              "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                              "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') AND (SUBSTRING(m.DateSale, 5, 2) = '03') " & _
                              "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                              "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColMar").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                               "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03') AND (m.idPsCancel IS NULL) AND " & _
                               "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                               "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') AND (SUBSTRING(m.DateSale, 5, 2) = '03') " & _
                               "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                               "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColMarL").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Apr**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                              "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                              "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                              "AND (SUBSTRING(m.DateSale, 5, 2) = '04') AND (m.idPsCancel IS NULL) AND " & _
                              "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                              "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                              "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                              "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                              "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') AND (SUBSTRING(m.DateSale, 5, 2) = '04') " & _
                              "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                              "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColApr").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                              "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                              "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
                              "AND (SUBSTRING(m.DateSale, 5, 2) = '04') AND (m.idPsCancel IS NULL) AND " & _
                              "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                              "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                              "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                              "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                              "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') AND (SUBSTRING(m.DateSale, 5, 2) = '04') " & _
                              "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                              "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColAprL").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************May**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                             "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                             "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                             "AND (SUBSTRING(m.DateSale, 5, 2) = '05') AND (m.idPsCancel IS NULL) AND " & _
                             "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                             "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                             "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                             "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                             "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') AND (SUBSTRING(m.DateSale, 5, 2) = '05') " & _
                             "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                             "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColMay").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                            "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                            "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                            "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
                            "AND (SUBSTRING(m.DateSale, 5, 2) = '05') AND (m.idPsCancel IS NULL) AND " & _
                            "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                            "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                            "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                            "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                            "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') AND (SUBSTRING(m.DateSale, 5, 2) = '05') " & _
                            "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                            "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColMayL").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Jun**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                            "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                            "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                            "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                            "AND (SUBSTRING(m.DateSale, 5, 2) = '06') AND (m.idPsCancel IS NULL) AND " & _
                            "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                            "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                            "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                            "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                            "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') AND (SUBSTRING(m.DateSale, 5, 2) = '06') " & _
                            "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                            "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColJun").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                             "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                             "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
                             "AND (SUBSTRING(m.DateSale, 5, 2) = '06') AND (m.idPsCancel IS NULL) AND " & _
                             "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                             "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                             "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                             "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                             "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') AND (SUBSTRING(m.DateSale, 5, 2) = '06') " & _
                             "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                             "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColJunL").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Jul**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                            "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                            "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                            "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                            "AND (SUBSTRING(m.DateSale, 5, 2) = '07') AND (m.idPsCancel IS NULL) AND " & _
                            "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                            "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                            "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                            "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                            "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') AND (SUBSTRING(m.DateSale, 5, 2) = '07') " & _
                            "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                            "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColJul").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                             "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                             "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
                             "AND (SUBSTRING(m.DateSale, 5, 2) = '07') AND (m.idPsCancel IS NULL) AND " & _
                             "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                             "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                             "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                             "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                             "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') AND (SUBSTRING(m.DateSale, 5, 2) = '07') " & _
                             "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                             "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColJulL").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Aug**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                             "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                             "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                             "AND (SUBSTRING(m.DateSale, 5, 2) = '08') AND (m.idPsCancel IS NULL) AND " & _
                             "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                             "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                             "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                             "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                             "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') AND (SUBSTRING(m.DateSale, 5, 2) = '08') " & _
                             "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                             "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColAug").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                            "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                            "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                            "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
                            "AND (SUBSTRING(m.DateSale, 5, 2) = '08') AND (m.idPsCancel IS NULL) AND " & _
                            "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                            "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                            "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                            "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                            "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') AND (SUBSTRING(m.DateSale, 5, 2) = '08') " & _
                            "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                            "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColAugL").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Sep**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                            "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                            "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                            "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                            "AND (SUBSTRING(m.DateSale, 5, 2) = '09') AND (m.idPsCancel IS NULL) AND " & _
                            "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                            "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                            "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                            "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                            "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') AND (SUBSTRING(m.DateSale, 5, 2) = '09') " & _
                            "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                            "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColSep").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                            "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                            "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                            "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
                            "AND (SUBSTRING(m.DateSale, 5, 2) = '09') AND (m.idPsCancel IS NULL) AND " & _
                            "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                            "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                            "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                            "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                            "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') AND (SUBSTRING(m.DateSale, 5, 2) = '09') " & _
                            "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                            "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColSepL").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Oct**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                             "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                             "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                             "AND (SUBSTRING(m.DateSale, 5, 2) = '10') AND (m.idPsCancel IS NULL) AND " & _
                             "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                             "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                             "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                             "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                             "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') AND (SUBSTRING(m.DateSale, 5, 2) = '10') " & _
                             "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                             "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColOct").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                            "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                            "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                            "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
                            "AND (SUBSTRING(m.DateSale, 5, 2) = '10') AND (m.idPsCancel IS NULL) AND " & _
                            "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                            "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                            "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                            "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                            "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') AND (SUBSTRING(m.DateSale, 5, 2) = '10') " & _
                            "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                            "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColOctL").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Nov**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                              "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                              "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                              "AND (SUBSTRING(m.DateSale, 5, 2) = '11') AND (m.idPsCancel IS NULL) AND " & _
                              "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                              "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                              "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                              "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                              "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') AND (SUBSTRING(m.DateSale, 5, 2) = '11') " & _
                              "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                              "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColNov").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                            "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                            "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                            "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
                            "AND (SUBSTRING(m.DateSale, 5, 2) = '11') AND (m.idPsCancel IS NULL) AND " & _
                            "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                            "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                            "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                            "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                            "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') AND (SUBSTRING(m.DateSale, 5, 2) = '11') " & _
                            "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                            "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColNovL").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Dec**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                              "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                              "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                              "AND (SUBSTRING(m.DateSale, 5, 2) = '12') AND (m.idPsCancel IS NULL) AND " & _
                              "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                              "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                              "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                              "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                              "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') AND (SUBSTRING(m.DateSale, 5, 2) = '12') " & _
                              "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                              "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColDec").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                             "SUM(d.Price * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                             "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') " & _
                             "AND (SUBSTRING(m.DateSale, 5, 2) = '12') AND (m.idPsCancel IS NULL) AND " & _
                             "(d.idPkUnit <> '3') AND (m.idComp = '" & sIdComp & "') GROUP BY p.idPlant UNION " & _
                             "SELECT p.idPlant, SUM(d.Price * d.Amount * d.Perbox) AS Total FROM " & _
                             "SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                             "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & _
                             "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "') AND (SUBSTRING(m.DateSale, 5, 2) = '12') " & _
                             "AND (m.idPsCancel IS NULL) AND (d.idPkUnit = '3') AND (m.idComp = '" & sIdComp & "') " & _
                             "GROUP BY p.idPlant) AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColDecL").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next
    End Sub

    Sub SumPaSale()
        Me.dgvPsSale.Columns("ColThisTS").HeaderText = "ยอดขายปี " & Me.dtpYear.Text
        Dim lastYear As Integer = Me.dtpYear.Text - 1
        Me.dgvPsSale.Columns("ColLastYS").HeaderText = "ยอดขายปี " & lastYear
        Dim SumThisYear As Double = 0.0

        Dim SaleDt As New DataTable
        SaleDt.Clear()
        mdCnOpen()

        sCommand.CommandText = "SELECT a.idPsSale, a.PsSale, b.SumThisY, '0.00' as ratio, c.SumLastY, '0.00' as growUp " & _
                               "FROM (SELECT idPsSale, PsSale FROM vSmSaleMt WHERE idPsCancel IS Null AND idComp = '" & sIdComp & "' " & _
                               "AND (SUBSTRING(DateSale, 1, 4) = '" & Me.dtpYear.Text & "') OR " & _
                               "(SUBSTRING(DateSale, 1, 4) = '" & lastYear & "') GROUP BY " & _
                               "idPsSale, PsSale) AS a FULL OUTER JOIN (SELECT idPsSale, SUM(TotalNet) AS SumThisY FROM SmSaleMt " & _
                               "WHERE idPsCancel IS Null AND idComp = '" & sIdComp & "' " & _
                               "AND (SUBSTRING(DateSale, 1, 4) = '" & Me.dtpYear.Text & "') GROUP BY idPsSale) AS b " & _
                               "ON a.idPsSale = b.idPsSale FULL OUTER JOIN " & _
                               "(SELECT idPsSale, SUM(TotalNet) AS SumLastY FROM SmSaleMt " & _
                               "WHERE idPsCancel IS Null AND idComp = '" & sIdComp & "' AND (SUBSTRING(DateSale, 1, 4) = '" & lastYear & "') " & _
                               "GROUP BY idPsSale) AS c ON a.idPsSale = c.idPsSale ORDER BY b.SumThisY DESC"
        sAdapter.Fill(SaleDt)
        If SaleDt.Rows.Count = 0 Then
            'MessageBox.Show("ไม่พบข้อมูลที่แสดงรายงานได้", sSystemName)
            dgvPsSale.DataSource = SaleDt
            Exit Sub
        Else
            dgvPsSale.DataSource = SaleDt
        End If
        'ksbCountRowDgv(dgvPsSale, ColNumS.Name)

        For i As Integer = 0 To dgvPsSale.Rows.Count - 1
            If dgvPsSale.Rows(i).Cells("ColThisTS").Value Is DBNull.Value Then
                dgvPsSale.Rows(i).Cells("ColThisTS").Value = 0.0
            End If
            If dgvPsSale.Rows(i).Cells("ColLastYS").Value Is DBNull.Value Then
                dgvPsSale.Rows(i).Cells("ColLastYS").Value = 0.0
            End If
            SumThisYear += dgvPsSale.Rows(i).Cells("ColThisTS").Value
        Next

        For i As Integer = 0 To dgvPsSale.Rows.Count - 1
            If SumThisYear = 0.0 Then
                dgvPsSale.Rows(i).Cells("ColRatioS").Value = Format(0.0, "#,##0.00")
            Else
                dgvPsSale.Rows(i).Cells("ColRatioS").Value = Format((dgvPsSale.Rows(i).Cells("ColThisTS").Value / SumThisYear) * 100, "#,##0.00")
            End If

            If dgvPsSale.Rows(i).Cells("ColThisTS").Value = 0 Or dgvPsSale.Rows(i).Cells("ColLastYS").Value = 0 Then
                dgvPsSale.Rows(i).Cells("ColGrowS").Value = Format(0.0, "#,##0.00")
            Else
                dgvPsSale.Rows(i).Cells("ColGrowS").Value = Format(((dgvPsSale.Rows(i).Cells("ColThisTS").Value - dgvPsSale.Rows(i).Cells("ColLastYS").Value) / dgvPsSale.Rows(i).Cells("ColLastYS").Value) * 100, "#,##0.00")
            End If

        Next
    End Sub

    Sub SumCusName()
        Dim SumThisYear As Double = 0.0

        Me.dgvCus.Columns("ColThisYC").HeaderText = "ยอดขายปี " & Me.dtpYear.Text
        Dim lastYear As Integer = Me.dtpYear.Text - 1
        Me.dgvCus.Columns("ColLastYC").HeaderText = "ยอดขายปี " & lastYear
        Dim CusDt As New DataTable
        CusDt.Clear()
        mdCnOpen()

        sCommand.CommandText = "SELECT a.idCus, a.CusName, b.SumThisY, '0.00' as ratioC, c.SumLastY, '0.00' as GrowUpC " & _
                               "FROM (SELECT idCus, CusName FROM vSmSaleMt WHERE idPsCancel IS Null " & _
                               "AND idComp = '" & sIdComp & "' AND ((SUBSTRING(DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "OR (SUBSTRING(DateSale, 1, 4) = '" & lastYear & "')) GROUP BY idCus, CusName) AS a " & _
                               "LEFT OUTER JOIN (SELECT idCus, SUM(TotalNet) AS SumThisY FROM SmSaleMt " & _
                               "WHERE idPsCancel IS Null AND idComp = '" & sIdComp & "' " & _
                               "AND (SUBSTRING(DateSale, 1, 4) = '" & Me.dtpYear.Text & "') GROUP BY idCus) AS b " & _
                               "ON a.idCus = b.idCus LEFT OUTER JOIN (SELECT idCus, SUM(TotalNet) AS SumLastY " & _
                               "FROM SmSaleMt WHERE idPsCancel IS Null AND idComp = '" & sIdComp & "' " & _
                               "AND (SUBSTRING(DateSale, 1, 4) = '" & lastYear & "') " & _
                               "GROUP BY idCus) AS c ON a.idCus = c.idCus ORDER BY b.SumThisY DESC"
        sAdapter.Fill(CusDt)
        If CusDt.Rows.Count = 0 Then
            'MessageBox.Show("ไม่พบข้อมูลที่แสดงรายงานได้", sSystemName)
            dgvCus.DataSource = CusDt
            Exit Sub
        Else
            dgvCus.DataSource = CusDt
        End If
        'ksbCountRowDgv(dgvCus, ColNumC.Name)

        For i As Integer = 0 To dgvCus.Rows.Count - 1
            If dgvCus.Rows(i).Cells("ColThisYC").Value Is DBNull.Value Then
                dgvCus.Rows(i).Cells("ColThisYC").Value = 0.0
            End If
            If dgvCus.Rows(i).Cells("ColLastYC").Value Is DBNull.Value Then
                dgvCus.Rows(i).Cells("ColLastYC").Value = 0.0
            End If
            SumThisYear += dgvCus.Rows(i).Cells("ColThisYC").Value
        Next

        For i As Integer = 0 To dgvCus.Rows.Count - 1
            If SumThisYear = 0.0 Then
                dgvCus.Rows(i).Cells("ColRatioC").Value = Format(0.0, "#,##0.00")
            Else
                dgvCus.Rows(i).Cells("ColRatioC").Value = Format((dgvCus.Rows(i).Cells("ColThisYC").Value / SumThisYear) * 100, "#,##0.00")
            End If

            If dgvCus.Rows(i).Cells("ColThisYC").Value = 0 Or dgvCus.Rows(i).Cells("ColLastYC").Value = 0 Then
                dgvCus.Rows(i).Cells("ColGrowC").Value = Format(0.0, "#,##0.00")
            Else
                dgvCus.Rows(i).Cells("ColGrowC").Value = Format(((dgvCus.Rows(i).Cells("ColThisYC").Value - dgvCus.Rows(i).Cells("ColLastYC").Value) / dgvCus.Rows(i).Cells("ColLastYC").Value) * 100, "#,##0.00")
            End If
        Next
    End Sub

    Private Sub dgvPlant_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvPlant.RowPostPaint
        Me.dgvPlant("ColNumP", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Private Sub dgvPsSale_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvPsSale.RowPostPaint
        Me.dgvPsSale("ColNumS", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Private Sub dgvCus_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvCus.RowPostPaint
        Me.dgvCus("ColNumC", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Private Sub rdbPie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPie.CheckedChanged
        If stPage = 1 Then
            If Me.rdbPie.Checked = True Then
                SumMonth()
                ChartMonth()
            End If
        End If

    End Sub

    Private Sub rdbColumn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbColumn.CheckedChanged
        If Me.rdbColumn.Checked = True Then
            If stPage = 1 Then
                SumMonth()
                ChartMonth()
            End If

        End If
    End Sub

    Private Sub rdbColSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbColSale.CheckedChanged
        If Me.rdbColSale.Checked = True Then
            If stPage = 1 Then
                SumPaSale()
                ChartPsSale()
            End If
        End If
    End Sub

    Private Sub rdbPieSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPieSale.CheckedChanged
        If Me.rdbPieSale.Checked = True Then
            If stPage = 1 Then
                SumPaSale()
                ChartPsSale()
            End If
        End If
    End Sub

    Private Sub rdbColCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbColCus.CheckedChanged
        If Me.rdbColCus.Checked = True Then
            If stPage = 1 Then
                SumCusName()
                ChartCusName()
            End If
        End If
    End Sub

    Private Sub rdbPieCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPieCus.CheckedChanged
        If Me.rdbPieCus.Checked = True Then
            If stPage = 1 Then
                SumCusName()
                ChartCusName()
            End If
        End If
    End Sub

    Sub SummaryPdT()
        Me.dgvPdT.Columns("ColSumYearT").HeaderText = "ยอดขายปี " & Me.dtpYear.Text
        Me.dgvPdT.Columns("ColjanT").HeaderText = "มกราคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdT.Columns("ColFebT").HeaderText = "กุมภาพันธ์ " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdT.Columns("ColMarT").HeaderText = "มีนาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdT.Columns("ColAprT").HeaderText = "เมษายน " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdT.Columns("ColMayT").HeaderText = "พฤษภาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdT.Columns("ColJunT").HeaderText = "มิถุนายน " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdT.Columns("ColJulT").HeaderText = "กรกฎาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdT.Columns("ColAugT").HeaderText = "สิงหาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdT.Columns("ColSepT").HeaderText = "กันยายน " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdT.Columns("ColOctT").HeaderText = "ตุลาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdT.Columns("ColNovT").HeaderText = "พฤศจิกายน " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdT.Columns("ColDecT").HeaderText = "ธันวาคม " & Me.dtpYear.Text.Substring(2, 2)
        Dim lastYear As Integer = Me.dtpYear.Text - 1
        Me.dgvPdT.Columns("ColLastYPT").HeaderText = "ยอดขายปี " & lastYear.ToString
        Me.dgvPdT.Columns("ColJanLT").HeaderText = "มกราคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdT.Columns("ColFebLT").HeaderText = "กุมภาพันธ์ " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdT.Columns("ColMarLT").HeaderText = "มีนาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdT.Columns("ColAprLT").HeaderText = "เมษายน " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdT.Columns("ColMayLT").HeaderText = "พฤษภาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdT.Columns("ColJunLT").HeaderText = "มิถุนายน " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdT.Columns("ColJulLT").HeaderText = "กรกฎาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdT.Columns("ColAugLT").HeaderText = "สิงหาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdT.Columns("ColSepLT").HeaderText = "กันยายน " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdT.Columns("ColOctLT").HeaderText = "ตุลาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdT.Columns("ColNovLT").HeaderText = "พฤศจิกายน " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdT.Columns("ColDecLT").HeaderText = "ธันวาคม " & lastYear.ToString.Substring(2, 2)

        Dim Dt As New DataTable
        Dt.Clear()
        mdCnOpen()
        sCommand.CommandText = "SELECT p.idPdT, p.PdTradeName, 0.00 As SumThisY, 0.00 As ratioP, 0.00 As GrowUpP, " & _
                               "0.00 As SumLastY, 0.00 As Jan, 0.00 As JanL, 0.00 As Feb, " & _
                               "0.00 As FebL, 0.00 As Mar, 0.00 As MarL, 0.00 As Apr, 0.00 As AprL, 0.00 As May, 0.00 As MayL, " & _
                               "0.00 As Jun, 0.00 As JunL, 0.00 As Jul, 0.00 As JulL, 0.00 As Aug, 0.00 As AugL, " & _
                               "0.00 As Sep, 0.00 As SepL, 0.00 As Oct, 0.00 As OctL, 0.00 As Nov, 0.00 As NovL, " & _
                               "0.00 As Dec, 0.00 As DecL FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE idPsCancel IS Null AND idComp = '" & sIdComp & "' " & _
                               "AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' OR " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') GROUP BY p.idPdT, p.PdTradeName"
        sAdapter.Fill(Dt)

        '************Summary ThisYear**************'
        Dim sDtY As New DataTable
        sDtY.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS SumThisY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "GROUP BY p.idPdT"
        sAdapter.Fill(sDtY)
        For i As Integer = 0 To sDtY.Rows.Count - 1
            For j As Integer = 0 To Dt.Rows.Count - 1
                If Dt.Rows(j).Item("idPdT") = sDtY.Rows(i).Item("idPdT") Then
                    Dt.Rows(j).Item("SumThisY") = Format(sDtY.Rows(i).Item("SumThisY"), "#,##0.00")
                    Exit For
                End If
            Next
        Next

        ''************Summary LastYear**************'
        Dim sDt2 As New DataTable
        sDt2.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS SumLastY " & _
                                "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                                "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                                "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                                "AND m.idPsCancel IS NULL AND " & _
                                "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                                "GROUP BY p.idPdT"
        sAdapter.Fill(sDt2)
        For i As Integer = 0 To sDt2.Rows.Count - 1
            For j As Integer = 0 To Dt.Rows.Count - 1
                If Dt.Rows(j).Item("idPdT") = sDt2.Rows(i).Item("idPdT") Then
                    Dt.Rows(j).Item("SumLastY") = Format(sDt2.Rows(i).Item("SumLastY"), "#,##0.00")
                    Exit For
                End If
            Next
        Next

        If Dt.Rows.Count = 0 Then
            dgvPdT.DataSource = Dt
            Exit Sub
        Else
            Dt.DefaultView.Sort = "[SumThisY] DESC"
            dgvPdT.DataSource = Dt
        End If

        '*********** %เติบโต & %สัดส่วน ***********'
        Dim SumThisYearP As Double = 0.0
        For i As Integer = 0 To dgvPdT.Rows.Count - 1
            If dgvPdT.Rows(i).Cells("ColSumYearT").Value Is DBNull.Value Then
                dgvPdT.Rows(i).Cells("ColSumYearT").Value = Format(0.0, "#,##0.00")
            End If
            SumThisYearP += dgvPdT.Rows(i).Cells("ColSumYearT").Value
        Next

        For i As Integer = 0 To dgvPdT.Rows.Count - 1
            If SumThisYearP = 0.0 Then
                dgvPdT.Rows(i).Cells("ColRatioPT").Value = Format(0.0, "#,##0.00")
            Else
                dgvPdT.Rows(i).Cells("ColRatioPT").Value = Format((dgvPdT.Rows(i).Cells("ColSumYearT").Value / SumThisYearP) * 100, "#,##0.00")
            End If

            If dgvPdT.Rows(i).Cells("ColLastYPT").Value = 0.0 Then
                dgvPdT.Rows(i).Cells("ColGrowUpPT").Value = "0.00"
            Else
                dgvPdT.Rows(i).Cells("ColGrowUpPT").Value = ((CDbl(dgvPdT.Rows(i).Cells("ColSumYearT").Value) - CDbl(dgvPdT.Rows(i).Cells("ColLastYPT").Value)) / CDbl(dgvPdT.Rows(i).Cells("ColLastYPT").Value)) * 100
            End If
        Next

        '************Jan**************'
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                              "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                              "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                              "AND m.idPsCancel IS NULL AND " & _
                              "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                              "AND SUBSTRING(m.DateSale, 5, 2) = '01' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColjanT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                             "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                             "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                             "AND m.idPsCancel IS NULL AND " & _
                             "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                             "AND SUBSTRING(m.DateSale, 5, 2) = '01' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColJanLT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next


        '************Feb**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                              "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                              "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                              "AND m.idPsCancel IS NULL AND " & _
                              "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                              "AND SUBSTRING(m.DateSale, 5, 2) = '02' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColFebT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                             "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                             "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                             "AND m.idPsCancel IS NULL AND " & _
                             "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                             "AND SUBSTRING(m.DateSale, 5, 2) = '02' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColFebLT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Mar**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                              "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                              "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                              "AND m.idPsCancel IS NULL AND " & _
                              "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                              "AND SUBSTRING(m.DateSale, 5, 2) = '03' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColMarT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                             "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                             "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                             "AND m.idPsCancel IS NULL AND " & _
                             "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                             "AND SUBSTRING(m.DateSale, 5, 2) = '03' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColMarLT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Apr**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                              "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                              "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                              "AND m.idPsCancel IS NULL AND " & _
                              "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                              "AND SUBSTRING(m.DateSale, 5, 2) = '04' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColAprT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                             "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                             "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                             "AND m.idPsCancel IS NULL AND " & _
                             "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                             "AND SUBSTRING(m.DateSale, 5, 2) = '04' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColAprLT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next


        '************May**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                              "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                              "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                              "AND m.idPsCancel IS NULL AND " & _
                              "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                              "AND SUBSTRING(m.DateSale, 5, 2) = '05' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColMayT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                             "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                             "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                             "AND m.idPsCancel IS NULL AND " & _
                             "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                             "AND SUBSTRING(m.DateSale, 5, 2) = '05' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColMayLT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Jun**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                              "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                              "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                              "AND m.idPsCancel IS NULL AND " & _
                              "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                              "AND SUBSTRING(m.DateSale, 5, 2) = '06' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColJunT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                             "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                             "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                             "AND m.idPsCancel IS NULL AND " & _
                             "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                             "AND SUBSTRING(m.DateSale, 5, 2) = '06' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColJunLT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next


        '************Jul**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                              "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                              "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                              "AND m.idPsCancel IS NULL AND " & _
                              "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                              "AND SUBSTRING(m.DateSale, 5, 2) = '07' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColJulT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                             "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                             "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                             "AND m.idPsCancel IS NULL AND " & _
                             "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                             "AND SUBSTRING(m.DateSale, 5, 2) = '07' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColJulLT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Aug**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                              "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                              "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                              "AND m.idPsCancel IS NULL AND " & _
                              "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                              "AND SUBSTRING(m.DateSale, 5, 2) = '08' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColAugT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                             "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                             "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                             "AND m.idPsCancel IS NULL AND " & _
                             "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                             "AND SUBSTRING(m.DateSale, 5, 2) = '08' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColAugLT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Sep**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                              "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                              "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                              "AND m.idPsCancel IS NULL AND " & _
                              "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                              "AND SUBSTRING(m.DateSale, 5, 2) = '09' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColSepT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                             "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                             "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                             "AND m.idPsCancel IS NULL AND " & _
                             "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                             "AND SUBSTRING(m.DateSale, 5, 2) = '09' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColSepLT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Oct**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                              "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                              "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                              "AND m.idPsCancel IS NULL AND " & _
                              "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                              "AND SUBSTRING(m.DateSale, 5, 2) = '10' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColOctT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                             "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                             "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                             "AND m.idPsCancel IS NULL AND " & _
                             "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                             "AND SUBSTRING(m.DateSale, 5, 2) = '10' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColOctLT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Nov**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                              "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                              "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                              "AND m.idPsCancel IS NULL AND " & _
                              "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                              "AND SUBSTRING(m.DateSale, 5, 2) = '11' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColNovT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                             "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                             "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                             "AND m.idPsCancel IS NULL AND " & _
                             "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                             "AND SUBSTRING(m.DateSale, 5, 2) = '11' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColNovLT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Dec**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                              "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                              "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                              "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                              "AND m.idPsCancel IS NULL AND " & _
                              "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                              "AND SUBSTRING(m.DateSale, 5, 2) = '12' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColDecT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdT, SUM(d.Price * d.Amount) AS Total " & _
                             "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                             "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                             "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                             "AND m.idPsCancel IS NULL AND " & _
                             "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                             "AND SUBSTRING(m.DateSale, 5, 2) = '12' GROUP BY p.idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdT.Rows.Count - 1
                If dgvPdT.Rows(j).Cells("ColidPdT").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPdT.Rows(j).Cells("ColDecLT").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub dgvPdT_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvPdT.RowPostPaint
        Me.dgvPdT("ColNumPdT", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Sub SummaryPdPk()
        Me.dgvPdPk.Columns("ColSumYearPk").HeaderText = "ยอดขายปี " & Me.dtpYear.Text
        Me.dgvPdPk.Columns("ColjanPk").HeaderText = "มกราคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdPk.Columns("ColFebPk").HeaderText = "กุมภาพันธ์ " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdPk.Columns("ColMarPk").HeaderText = "มีนาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdPk.Columns("ColAprPk").HeaderText = "เมษายน " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdPk.Columns("ColMayPk").HeaderText = "พฤษภาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdPk.Columns("ColJunPk").HeaderText = "มิถุนายน " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdPk.Columns("ColJulPk").HeaderText = "กรกฎาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdPk.Columns("ColAugPk").HeaderText = "สิงหาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdPk.Columns("ColSepPk").HeaderText = "กันยายน " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdPk.Columns("ColOctPk").HeaderText = "ตุลาคม " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdPk.Columns("ColNovPk").HeaderText = "พฤศจิกายน " & Me.dtpYear.Text.Substring(2, 2)
        Me.dgvPdPk.Columns("ColDecPk").HeaderText = "ธันวาคม " & Me.dtpYear.Text.Substring(2, 2)
        Dim lastYear As Integer = Me.dtpYear.Text - 1
        Me.dgvPdPk.Columns("ColLastYPPk").HeaderText = "ยอดขายปี " & lastYear.ToString
        Me.dgvPdPk.Columns("ColJanLPk").HeaderText = "มกราคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdPk.Columns("ColFebLPk").HeaderText = "กุมภาพันธ์ " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdPk.Columns("ColMarLPk").HeaderText = "มีนาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdPk.Columns("ColAprLPk").HeaderText = "เมษายน " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdPk.Columns("ColMayLPk").HeaderText = "พฤษภาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdPk.Columns("ColJunLPk").HeaderText = "มิถุนายน " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdPk.Columns("ColJulLPk").HeaderText = "กรกฎาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdPk.Columns("ColAugLPk").HeaderText = "สิงหาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdPk.Columns("ColSepLPk").HeaderText = "กันยายน " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdPk.Columns("ColOctLPk").HeaderText = "ตุลาคม " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdPk.Columns("ColNovLPk").HeaderText = "พฤศจิกายน " & lastYear.ToString.Substring(2, 2)
        Me.dgvPdPk.Columns("ColDecLPk").HeaderText = "ธันวาคม " & lastYear.ToString.Substring(2, 2)

        Dim Dt As New DataTable
        Dt.Clear()
        mdCnOpen()
        sCommand.CommandText = "SELECT p.idPdPk, p.PdPkName, 0.00 As SumThisY, 0.00 As ratioP, 0.00 As GrowUpP, " & _
                               "0.00 As SumLastY, 0.00 As Jan, 0.00 As JanL, 0.00 As Feb, " & _
                               "0.00 As FebL, 0.00 As Mar, 0.00 As MarL, 0.00 As Apr, 0.00 As AprL, 0.00 As May, 0.00 As MayL, " & _
                               "0.00 As Jun, 0.00 As JunL, 0.00 As Jul, 0.00 As JulL, 0.00 As Aug, 0.00 As AugL, " & _
                               "0.00 As Sep, 0.00 As SepL, 0.00 As Oct, 0.00 As OctL, 0.00 As Nov, 0.00 As NovL, " & _
                               "0.00 As Dec, 0.00 As DecL FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE idPsCancel IS Null AND idComp = '" & sIdComp & "' " & _
                               "AND ((SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') OR " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "')) GROUP BY p.idPdPk, p.PdPkName"
        sAdapter.Fill(Dt)

        ''************Summary ThisYear**************'
        Dim sDtY As New DataTable
        sDtY.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS SumThisY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDtY)
        For i As Integer = 0 To sDtY.Rows.Count - 1
            For j As Integer = 0 To Dt.Rows.Count - 1
                If Dt.Rows(j).Item("idPdPk") = sDtY.Rows(i).Item("idPdPk") Then
                    Dt.Rows(j).Item("SumThisY") = Format(sDtY.Rows(i).Item("SumThisY"), "#,##0.00")
                    Exit For
                End If
            Next
        Next

        ''************Summary LastYear**************'
        Dim sDt2 As New DataTable
        sDt2.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS SumLastY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt2)
        For i As Integer = 0 To sDt2.Rows.Count - 1
            For j As Integer = 0 To Dt.Rows.Count - 1
                If Dt.Rows(j).Item("idPdPk") = sDt2.Rows(i).Item("idPdPk") Then
                    Dt.Rows(j).Item("SumLastY") = Format(sDt2.Rows(i).Item("SumLastY"), "#,##0.00")
                    Exit For
                End If
            Next
        Next

        If Dt.Rows.Count = 0 Then
            dgvPdPk.DataSource = Dt
            Exit Sub
        Else
            Dt.DefaultView.Sort = "[SumThisY] DESC"
            dgvPdPk.DataSource = Dt
        End If

        '*********** %เติบโต & %สัดส่วน ***********'
        Dim SumThisYearPPk As Double = 0.0
        For i As Integer = 0 To dgvPdPk.Rows.Count - 1
            If dgvPdPk.Rows(i).Cells("ColSumYearPk").Value Is DBNull.Value Then
                dgvPdPk.Rows(i).Cells("ColSumYearPk").Value = Format(0.0, "#,##0.00")
            End If
            SumThisYearPPk += dgvPdPk.Rows(i).Cells("ColSumYearPk").Value
        Next

        For i As Integer = 0 To dgvPdPk.Rows.Count - 1
            If SumThisYearPPk = 0.0 Then
                dgvPdPk.Rows(i).Cells("ColRatioPPk").Value = Format(0.0, "#,##0.00")
            Else
                dgvPdPk.Rows(i).Cells("ColRatioPPk").Value = Format((dgvPdPk.Rows(i).Cells("ColSumYearPk").Value / SumThisYearPPk) * 100, "#,##0.00")
            End If

            If dgvPdPk.Rows(i).Cells("ColLastYPPk").Value = 0.0 Then
                dgvPdPk.Rows(i).Cells("ColGrowUpPPk").Value = "0.00"
            Else
                dgvPdPk.Rows(i).Cells("ColGrowUpPPk").Value = ((CDbl(dgvPdPk.Rows(i).Cells("ColSumYearPk").Value) - CDbl(dgvPdPk.Rows(i).Cells("ColLastYPPk").Value)) / CDbl(dgvPdPk.Rows(i).Cells("ColLastYPPk").Value)) * 100
            End If
        Next

        '************Jan**************'
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '01' " & _
                               "GROUP BY p.idPdPk"

        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColjanPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '01' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColJanLPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next


        '************Feb**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '02' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColFebPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '02' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColFebLPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Mar**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '03' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColMarPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '03' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColMarLPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Apr**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '04' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColAprPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '04' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColAprLPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************May**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '05' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColMayPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '05' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColMayLPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Jun**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '06' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColJunPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '06' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColJunLPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Jul**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '07' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColJulPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '07' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColJulLPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Aug**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '08' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColAugPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '08' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColAugLPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next


        '************Sep**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '09' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColSepPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '09' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColSepLPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Oct**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '10' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColOctPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '10' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColOctLPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next


        '************Nov**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '11' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColNovPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '11' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColNovLPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Dec**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '12' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColDecPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, SUM(d.Price * d.Amount) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE m.idComp = '" & sIdComp & "' " & _
                               "AND m.idPsCancel IS NULL AND " & _
                               "SUBSTRING(m.DateSale, 1, 4) = '" & lastYear & "' " & _
                               "AND SUBSTRING(m.DateSale, 5, 2) = '12' " & _
                               "GROUP BY p.idPdPk"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPdPk.Rows.Count - 1
                If dgvPdPk.Rows(j).Cells("ColidPdPk").Value = sDt.Rows(i).Item("idPdPk") Then
                    dgvPdPk.Rows(j).Cells("ColDecLPk").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next


    End Sub

    Private Sub dgvPdPk_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvPdPk.RowPostPaint
        Me.dgvPdPk("ColNumPdPk", e.RowIndex).Value = e.RowIndex + 1
    End Sub

End Class