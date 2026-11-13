Imports System.Windows.Forms.DataVisualization.Charting
Imports DevExpress.XtraSplashScreen

Public Class frmSaleDateChart

    ' Dim vToday As String = Format(Now, "yyyyMMdd").ToString()
    'ksbDateToString(FormatDateTime(Date.Today, "dd/MM/yyyy"))
    'Dim DToday As String = ksbStringToDate(vToday)
    '  Dim vDToday As Date = DToday
    Dim stload As Integer = 0
    Dim DailyDt As New DataTable
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")

    Private Sub frmSaleDateChart_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mdLoadShow()
        setCmbGroupComp(cmbGroupComp)
        'Dim Day20 As String = DateAdd(DateInterval.Day, -19, vDToday)
        ' DailyDt.Columns.Add("vDayStr", System.Type.GetType("System.String"))
        DailyDt.Columns.Add("vDayDate", System.Type.GetType("System.String"))
        DailyDt.Columns.Add("TotalNet", System.Type.GetType("System.Double"))

        SumDaily()

        Timer1.Interval = 300000   '1000 ms = 1 sec so 60000 ms = 1 min >>> 5 min
        Label1.Text = "Last Update : " & DateTime.Now.ToString
        stload = 1
        mdLoadCommitt()
        ' Timer1.Start() 'Timer starts functioning
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        Timer1.Enabled = False
        Label1.Text = "Last Update : " & DateTime.Now.ToString
        SumDaily()
        Timer1.Enabled = True
        SplashScreenManager.CloseForm(False)

    End Sub

    Sub SumDaily()
        mdCnOpen()

        ' Dim DayDiff As String = ""
        ' Dim DayDiffStr As String = ""
        ' Dim ToDayDate As DateTime = Convert.ToDateTime(Date.Today, _cultureEnInfo)

        For i As Integer = 0 To 19
            ' DayDiff = DateAdd(DateInterval.Day, -(19 - i), Date.Today)
            ' DateDifffm = Format(DayDiff, "dd/MM/yyyy").ToString
            ' DayDiffStr = Format(DateAdd(DateInterval.Day, -(19 - i), vDToday), "yyyyMMdd").ToString()
            DailyDt.Rows.Add()
            'DailyDt.Rows(i).Item("vDayStr") = DateAdd(DateInterval.Day, -(19 - i), Date.Today).ToString("dd/MM/YYYY")
            DailyDt.Rows(i).Item("vDayDate") = DateAdd(DateInterval.Day, -(19 - i), Date.Today).ToString("dd/MM/yyyy")
            DailyDt.Rows(i).Item("TotalNet") = 0
        Next

        Try

            For i As Integer = 0 To DailyDt.Rows.Count - 1
                Dim DateFmt As Date = DailyDt.Rows(i).Item("vDayDate")
                Dim tempDt As New DataTable
                tempDt.Clear()
                sCommand.CommandText = "SELECT SUM(TotalNet - ISNULL(SumService, 0.0)) as total " & vbNewLine & _
                                       "FROM SmSaleMt " & vbNewLine & _
                                       "WHERE DateSaleD = '" & DateFmt.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " & _
                                       "AND idPsCancel IS Null AND idSaleCode NOT IN (1, 18) " & vbNewLine & _
                                       "AND idComp = " & cmbGroupComp.SelectedValue & ""
                sAdapter.Fill(tempDt)
                DailyDt.Rows(i).Item("TotalNet") = tempDt.Rows(0).Item("total")
            Next
        Catch ex As Exception
            ' nothing
        End Try

        Me.Chart1.DataSource = DailyDt
        'Chart1.Series("Series1").XValueMember = "vDayDate"
        'Chart1.Series("Series1").YValueMembers = "TotalNet"
        Chart1.DataBind()

        'Chart1.Series("Series1")("PointWidth") = "0.5"
        'Chart1.Series("Series1").LabelForeColor = Color.Black

        ' Chart1.Legends("Legend1").Enabled = False
        Chart1.Titles(0).Text = "กราฟสรุปยอดขายตั้งแต่วันที่ " & DailyDt.Rows(0).Item("vDayDate") & " - " & DailyDt.Rows(19).Item("vDayDate")
        'With Chart1.ChartAreas("ChartArea1").AxisY
        '    .TitleFont = New Font("Times New Roman", 14, FontStyle.Bold)
        '    .LabelStyle.Format = "##,#"
        'End With

        'With Chart1.ChartAreas("ChartArea1").AxisX
        '    .TitleFont = New Font("Times New Roman", 14, FontStyle.Bold)
        '    .MajorGrid.Enabled = False  ''ไม่แสดงเส้น Grid
        'End With
        'mdLoadCommitt()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        Timer1.Enabled = False
        Label1.Text = "Last Update : " & DateTime.Now.ToString
        SumDaily()
        Timer1.Enabled = True
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub cmbGroupComp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedIndexChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            Timer1.Enabled = False
            Label1.Text = "Last Update : " & DateTime.Now.ToString
            SumDaily()
            Timer1.Enabled = True
            SplashScreenManager.CloseForm(False)
        End If
    End Sub
End Class