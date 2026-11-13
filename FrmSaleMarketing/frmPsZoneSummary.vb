Public Class frmPsZoneSummary
    Dim NameSeriesold As String = ""
    Dim NameSeries As String = ""
    Dim NameSeriesold2 As String = ""
    Dim NameSeries2 As String = ""
    Dim Datestart As String = ""
    Dim Dateend As String = ""
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_6.Click
        Dim frm As New frmPsZoneDetail
        frm.idRg = 6
        frm.RgName = "ภาคตะวันออกเฉียงเหนือตอนบน"
        If RB1.Checked Then
            frm.DateS = 1
        Else
            frm.YearS = 1
        End If
        frm.DateStart = Datestart
        frm.DateEnd = Dateend
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        frm.Datetext = NameSeries
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        frm.ShowDialog()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_5.Click
        Dim frm As New frmPsZoneDetail
        frm.idRg = 5
        frm.RgName = "ภาคตะวันออก"
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        If RB1.Checked Then
            frm.DateS = 1
        Else
            frm.YearS = 1
        End If
        frm.DateStart = Datestart
        frm.DateEnd = Dateend
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        frm.Datetext = NameSeries
        frm.ShowDialog()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB7.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_7.Click
        Dim frm As New frmPsZoneDetail
        frm.RgName = "ภาคตะวันออกเฉียงเหนือตอนล่าง"
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        frm.idRg = 7
        If RB1.Checked Then
            frm.DateS = 1
        Else
            frm.YearS = 1
        End If
        frm.DateStart = Datestart
        frm.DateEnd = Dateend
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        frm.Datetext = NameSeries
        frm.ShowDialog()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB6.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB5.Click

    End Sub

    Private Sub Panel7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_2.Click
        Dim frm As New frmPsZoneDetail
        frm.RgName = "ภาคเหนือตอนล่าง"
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        If RB1.Checked Then
            frm.DateS = 1
        Else
            frm.YearS = 1
        End If
        frm.DateStart = Datestart
        frm.DateEnd = Dateend
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        frm.Datetext = NameSeries
        frm.idRg = 2
        frm.ShowDialog()
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_4.Click
        Dim frm As New frmPsZoneDetail
        frm.idRg = 4
        frm.RgName = "ภาคกลาง"
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        If RB1.Checked Then
            frm.DateS = 1
        Else
            frm.YearS = 1
        End If
        frm.DateStart = Datestart
        frm.DateEnd = Dateend
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        frm.Datetext = NameSeries
        frm.ShowDialog()
    End Sub

    Private Sub Panel14_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub frmPsZoneSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Date1.Value = Date.Today
        Date2.Value = Date.Today
        Date3.Value = Date.Today
        Date3.Format = DateTimePickerFormat.Custom
        Date3.CustomFormat = "yyyy"

        Date1.Format = DateTimePickerFormat.Custom
        Date1.CustomFormat = "MMMMyyyy"
        Date2.Format = DateTimePickerFormat.Custom
        Date2.CustomFormat = "MMMMyyyy"
        filldata()
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB4.Click

    End Sub

    Private Sub Panel12_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel12.Paint

    End Sub

    Private Sub btnSchPd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchPd.Click
        mdLoadShow()
        filldata()
        mdLoadCommitt()
    End Sub
    Private Sub filldata()
        Dim sDt As New DataTable
        Dim sDt2 As New DataTable
        mdCnOpen()
        Dim vWhere As String = ""
        Dim vWhere2 As String = ""
        Datestart = ksbDateToString(DateSerial(Year(Date1.Value), Month(Date1.Value) + 1, 0))
        Datestart = Datestart.Remove(6, 2)
        Datestart &= "01"
        Dateend = ksbDateToString(DateSerial(Year(Date2.Value), Month(Date2.Value) + 1, 0))




        Dim Datestart2 As String = ksbDateToString(DateSerial(Year(Date1.Value) - 1, Month(Date1.Value) + 1, 0))
        Datestart2 = Datestart2.Remove(6, 2)
        Datestart2 &= "01"
        Dim Dateend2 As String = ksbDateToString(DateSerial(Year(Date2.Value) - 1, Month(Date2.Value) + 1, 0))

        If RB1.Checked Then
            vWhere &= " AND (sm.DateSale BETWEEN  '" & Datestart & "' AND '" & Dateend & "' ) "
            vWhere2 &= " AND (sm.DateSale BETWEEN  '" & Datestart2 & "' AND '" & Dateend2 & "' ) "
        Else
            vWhere &= " AND (SUBSTRING (sm.DateSale,0,5) = " & Microsoft.VisualBasic.Right(Date3.Text, 4) & " ) "
            vWhere2 &= " AND (SUBSTRING (sm.DateSale,0,5) = " & (CType(Microsoft.VisualBasic.Right(Date3.Text, 4), Integer) - 1).ToString & " ) "
        End If
        sCommand.CommandText = " SELECT Sum(total) AS Total,SmR.RegionName,SmR.idRegion FROM " & _
        "(select sum(totalnet) AS total,vc.cusname,vc.idcus,vc.idpv  " & _
        "FROM vSmSaleMt Sm LEFT JOIN vcustomer vc On vc.idcus = sm.idcus WHERE sm.idPsCancel IS NULL " & vWhere & " Group by vc.cusname,vc.idcus,vc.idpv) as DB1 Left JOIn dProvinceFixSale P ON P.idPv = DB1.idPv " & _
        "Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale Group by SmR.RegionName,SmR.idRegion ORDER BY SmR.idRegion "
        sAdapter.Fill(sDt)
        Dim Alltotal As Double = 0.0
        For i As Integer = 0 To sDt.Rows.Count - 1
            Alltotal = Alltotal + sDt.Rows(i).Item("Total")
        Next
        sCommand.CommandText = " SELECT Sum(total) AS Total,SmR.RegionName,SmR.idRegion FROM " & _
       "(select sum(totalnet) AS total,vc.cusname,vc.idcus,vc.idpv " & _
       "FROM vSmSaleMt Sm LEFT JOIN vcustomer vc On vc.idcus = sm.idcus WHERE sm.idPsCancel IS NULL " & vWhere2 & " Group by vc.cusname,vc.idcus,vc.idpv) as DB1 Left JOIn dProvinceFixSale P ON P.idPv = DB1.idPv " & _
       "Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale Group by SmR.RegionName,SmR.idRegion ORDER BY SmR.idRegion "
        sAdapter.Fill(sDt2)

        Dim Rg1 As String = FormatNumber(sDt.Rows(1).Item("Total"), 2, , , TriState.True)
        Dim Rg2 As String = FormatNumber(sDt.Rows(2).Item("Total"), 2, , , TriState.True)
        Dim Rg3 As String = FormatNumber(sDt.Rows(3).Item("Total"), 2, , , TriState.True)
        Dim Rg4 As String = FormatNumber(sDt.Rows(4).Item("Total"), 2, , , TriState.True)
        Dim Rg5 As String = FormatNumber(sDt.Rows(5).Item("Total"), 2, , , TriState.True)
        Dim Rg6 As String = FormatNumber(sDt.Rows(6).Item("Total"), 2, , , TriState.True)
        Dim Rg7 As String = FormatNumber(sDt.Rows(7).Item("Total"), 2, , , TriState.True)
        Dim Rg8 As String = FormatNumber(sDt.Rows(8).Item("Total"), 2, , , TriState.True)
        Dim Rg9 As String = FormatNumber(sDt.Rows(9).Item("Total"), 2, , , TriState.True)
        Dim Rg10 As String = FormatNumber(sDt.Rows(10).Item("Total"), 2, , , TriState.True)
        Dim Rg11 As String = FormatNumber(sDt.Rows(0).Item("Total"), 2, , , TriState.True)

        LB1.Text = " ยอดขาย " & Rg1 & " บาท"
        LB2.Text = " ยอดขาย " & Rg2 & " บาท"
        LB3.Text = " ยอดขาย " & Rg3 & " บาท"
        LB4.Text = " ยอดขาย " & Rg4 & " บาท"
        LB5.Text = " ยอดขาย " & Rg5 & " บาท"
        LB6.Text = " ยอดขาย " & Rg6 & " บาท"
        LB7.Text = " ยอดขาย " & Rg7 & " บาท"
        LB8.Text = " ยอดขาย " & Rg8 & " บาท"
        LB9.Text = " ยอดขาย " & Rg9 & " บาท"
        LB10.Text = " ยอดขาย " & Rg10 & " บาท"
        LB11.Text = " ยอดขาย " & Rg11 & " บาท"

        Dim totalnet As Double = CType(Rg1, Double) + CType(Rg2, Double) + CType(Rg3, Double) + CType(Rg4, Double) + CType(Rg5, Double) + CType(Rg6, Double) + CType(Rg7, Double) + CType(Rg8, Double) + CType(Rg9, Double) + CType(Rg10, Double) + CType(Rg11, Double)


        Dim Rg_1 As String = FormatNumber((CType(Rg1, Double) / totalnet) * 100, 2, , , TriState.True)
        Dim Rg_2 As String = FormatNumber((CType(Rg2, Double) / totalnet) * 100, 2, , , TriState.True)
        Dim Rg_3 As String = FormatNumber((CType(Rg3, Double) / totalnet) * 100, 2, , , TriState.True)
        Dim Rg_4 As String = FormatNumber((CType(Rg4, Double) / totalnet) * 100, 2, , , TriState.True)
        Dim Rg_5 As String = FormatNumber((CType(Rg5, Double) / totalnet) * 100, 2, , , TriState.True)
        Dim Rg_6 As String = FormatNumber((CType(Rg6, Double) / totalnet) * 100, 2, , , TriState.True)
        Dim Rg_7 As String = FormatNumber((CType(Rg7, Double) / totalnet) * 100, 2, , , TriState.True)
        Dim Rg_8 As String = FormatNumber((CType(Rg8, Double) / totalnet) * 100, 2, , , TriState.True)
        Dim Rg_9 As String = FormatNumber((CType(Rg9, Double) / totalnet) * 100, 2, , , TriState.True)
        Dim Rg_10 As String = FormatNumber((CType(Rg10, Double) / totalnet) * 100, 2, , , TriState.True)
        Dim Rg_11 As String = FormatNumber((CType(Rg11, Double) / totalnet) * 100, 2, , , TriState.True)

        LB_1.Text = "ภาคเหนือตอนบน " & Rg_1.ToString & " % "
        LB_2.Text = "ภาคเหนือตอนล่าง " & Rg_2.ToString & " % "
        LB_3.Text = "กรุงเทพฯและปริมณฑล " & Rg_3.ToString & " % "
        LB_4.Text = "ภาคกลาง " & Rg_4.ToString & " % "
        LB_5.Text = "ภาคตะวันออก " & Rg_5.ToString & " % "
        LB_6.Text = "ภาคตะวันออกเฉียงเหนือตอนบน " & Rg_6.ToString & " % "
        LB_7.Text = "ภาคตะวันออกเฉียงเหนือตอนล่าง " & Rg_7.ToString & " % "
        LB_8.Text = "ภาคใต้ตอนบน " & Rg_8.ToString & " % "
        LB_9.Text = "ภาคใต้ตอนล่าง " & Rg_9.ToString & " % "
        LB_10.Text = "ภาคตะวันตก " & Rg_10.ToString & " % "
        LB_11.Text = "ลูกค้าต่างประเทศ " & Rg_11.ToString & " % "

        sDt.Columns.Add("RegionName2", Type.GetType("System.String"))
        sDt.Columns.Add("Total2", Type.GetType("System.Double"))

        For i As Integer = 0 To sDt2.Rows.Count - 1
            sDt.Rows(i).Item("RegionName2") = sDt2.Rows(i).Item("RegionName")
            sDt.Rows(i).Item("Total2") = sDt2.Rows(i).Item("Total")
            If sDt.Rows(i).Item("RegionName2") Is DBNull.Value Then
                sDt.Rows(i).Item("RegionName") = "ต่างประเทศ"
                sDt.Rows(i).Item("RegionName2") = "ต่างประเทศ"
            End If

        Next


        Chart1.DataSource = sDt
        Chart1.Series(0).Name = "0"
        Chart1.Series(1).Name = "1"
        NameSeriesold2 = NameSeries2
        If RB1.Checked Then
            NameSeries = "ระหว่างเดือน " & Date1.Text & " ถึง " & Date2.Text
            NameSeries2 = "ระหว่างเดือน " & Date1.Text.Substring(0, Date1.Text.Length - 4) & (CType(Microsoft.VisualBasic.Right(Date1.Text, 4), Integer) - 1).ToString & " ถึง " & Date2.Text.Substring(0, Date2.Text.Length - 4) & (CType(Microsoft.VisualBasic.Right(Date2.Text, 4), Integer) - 1).ToString
        Else
            NameSeries = "ปี " & Microsoft.VisualBasic.Right(Date3.Text, 4)
            NameSeries2 = "ปี " & (CType(Microsoft.VisualBasic.Right(Date3.Text, 4), Integer) - 1).ToString
        End If
        Chart1.Series(0).Name = NameSeries
        Chart1.Series(1).Name = NameSeries2
        Chart1.Series(NameSeries).XValueMember = "RegionName"
        Chart1.Series(NameSeries).YValueMembers = "Total"
        Chart1.Series(NameSeries2).XValueMember = "RegionName2"
        Chart1.Series(NameSeries2).YValueMembers = "Total2"
        Chart1.DataBind()
        Chart1.Series(NameSeries).Label = "#PERCENT{P2}"
        Chart1.Series(NameSeries2).Label = "#PERCENT{P2}"
        lbtotal.Text = "ยอดรวมทั้งหมด " & Alltotal.ToString("N2") & " บาท"


    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB8.Click

    End Sub

    Private Sub LB3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB3.Click

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub RBDateSend2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB1.CheckedChanged
        If RB1.Checked = True Then
            Date1.Enabled = True
            Date2.Enabled = True
        Else
            Date1.Enabled = False
            Date2.Enabled = False
        End If
    End Sub

    Private Sub RB2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB2.CheckedChanged
        If RB2.Checked = True Then
            Date3.Enabled = True
        Else
            Date3.Enabled = False
        End If
    End Sub

    Private Sub LB_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_1.Click
        Dim frm As New frmPsZoneDetail
        frm.idRg = 1
        frm.RgName = "ภาคเหนือตอนบน"

        If RB1.Checked Then
            frm.DateS = 1
        Else
            frm.YearS = 1
        End If
        frm.DateStart = Datestart
        frm.DateEnd = Dateend
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        frm.Datetext = NameSeries
        frm.ShowDialog()
    End Sub

    Private Sub LB_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_10.Click
        Dim frm As New frmPsZoneDetail
        frm.idRg = 10
        frm.RgName = "ภาคตะวันตก"
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        If RB1.Checked Then
            frm.DateS = 1
        Else
            frm.YearS = 1
        End If
        frm.DateStart = Datestart
        frm.DateEnd = Dateend
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        frm.Datetext = NameSeries
        frm.ShowDialog()

    End Sub

    Private Sub LB_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_8.Click
        Dim frm As New frmPsZoneDetail
        frm.idRg = 8
        frm.RgName = "ภาคใต้ตอนบน"
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        If RB1.Checked Then
            frm.DateS = 1
        Else
            frm.YearS = 1
        End If
        frm.DateStart = Datestart
        frm.DateEnd = Dateend
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        frm.Datetext = NameSeries
        frm.ShowDialog()
    End Sub

    Private Sub LB_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_9.Click
        Dim frm As New frmPsZoneDetail
        frm.idRg = 9
        frm.RgName = "ภาคใต้ตอนล่าง"
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        If RB1.Checked Then
            frm.DateS = 1
        Else
            frm.YearS = 1
        End If
        frm.DateStart = Datestart
        frm.DateEnd = Dateend
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        frm.Datetext = NameSeries
        frm.ShowDialog()
    End Sub

    Private Sub LB_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_3.Click
        Dim frm As New frmPsZoneDetail
        frm.idRg = 3
        frm.RgName = "กรุงเทพฯและปริมณฑล"
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        If RB1.Checked Then
            frm.DateS = 1
        Else
            frm.YearS = 1
        End If
        frm.DateStart = Datestart
        frm.DateEnd = Dateend
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        frm.Datetext = NameSeries
        frm.ShowDialog()
    End Sub

    Private Sub LB_11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_11.Click
        Dim frm As New frmPsZoneDetail
        frm.idRg = 11
        frm.RgName = "ลูกค้าต่างประเทศ"
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        If RB1.Checked Then
            frm.DateS = 1
        Else
            frm.YearS = 1
        End If
        frm.DateStart = Datestart
        frm.DateEnd = Dateend
        frm.Year = Microsoft.VisualBasic.Right(Date3.Text, 4)
        frm.Datetext = NameSeries
        frm.ShowDialog()
    End Sub

    Private Sub Panel17_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel17.Paint

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Panel21_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel21.Paint

    End Sub

    Private Sub Panel15_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel15.Paint

    End Sub

    Private Sub lbtotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbtotal.Click

    End Sub
End Class