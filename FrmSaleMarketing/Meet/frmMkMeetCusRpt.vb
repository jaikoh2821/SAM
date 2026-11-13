Public Class frmMkMeetCusRpt

    Private Sub btnShowDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDoc.Click
        Dim ReportFormat As String = ""
        Dim vWhere As String = ""
        Dim MeetRpt As New DataTable
        MeetRpt.Clear()
        mdCnOpen()

        Dim grTitle As String = ""
        If RdGrTitleCus.Checked = True Then
            ReportFormat = "แบบจัดกลุ่มตามหัวข้อที่เข้าพบ"
            grTitle = "sMD.MeetName"
        ElseIf RdGrEmp.Checked = True Then
            ReportFormat = "แบบจัดกลุ่มตามพนักงานที่เข้าพบ"
            grTitle = "P.PsName"
        ElseIf RdGrCus.Checked = True Then
            ReportFormat = "แบบจัดกลุ่มตามคู่ค้าที่เข้าพบ"
            grTitle = "C.CusName_"
        ElseIf RdGrDay.Checked = True Then
            ReportFormat = "แบบจัดกลุ่มตามวันที่"
            grTitle = "sM.DateMeet"
        End If

        Dim SQL As String = ""
        SQL &= "SELECT sM.MeetDetail, sM.DateMeet, sMD.MeetName, C.CusName_, P.PsName, sM.idTs, sM.stAddress AS Country, " & grTitle & " As GrTitle  "
        SQL &= " FROM dbo.SmMkMeet AS sM INNER JOIN dbo.SmMkMeetData AS sMD  ON sM.idMeet = sMD.idMeet INNER JOIN dbo.vCustomer AS C "
        SQL &= " ON sM.idCus = C.idCus INNER JOIN dbo.vPerson AS P ON sM.idPs = P.idPs "

        If RdSDay.Checked = True Then
            SQL &= " WHERE sM.DateMeet BETWEEN '" & ksbDateToString(DateTime_Ts1.Value.ToShortDateString) & "' AND '" & ksbDateToString(DateTime_Ts2.Value.ToShortDateString) & "'  ORDER BY sM.DateMeet,sM.idTs ASC"
        ElseIf RdSMonth.Checked = True Then
            SQL &= " WHERE sM.DateMeet LIKE '%" & Microsoft.VisualBasic.Left(ksbDateToString(DayOfMonth.Value.ToShortDateString), 6) & "%'  ORDER BY  sM.DateMeet, sM.idTs ASC "
        End If

        sCommand.CommandText = SQL
        sAdapter.Fill(MeetRpt)

        For i As Integer = 0 To MeetRpt.Rows.Count - 1
            MeetRpt.Rows(i).Item("DateMeet") = ksbStringToDate(MeetRpt.Rows(i).Item("DateMeet"))
            If RdGrDay.Checked = True Then
                MeetRpt.Rows(i).Item("GrTitle") = ConvertToDateThai(ksbStringToDate(MeetRpt.Rows(i).Item("GrTitle")))
            End If
        Next

        If MeetRpt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูลการเข้าพบคู่ค้าในช่วงนี้", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Dim vFrm As New frmReportView
            Dim vRpt As New crpMkMeetCus
            vRpt.SetDataSource(MeetRpt)

            If RdSDay.Checked = True Then
                vRpt.SetParameterValue(vRpt.Parameter_sDay.ParameterFieldName, "ระหว่างวันที่   " & DateTime_Ts1.Value.ToString("d  MMMM  yyyy") & "   ถึง   " & DateTime_Ts2.Value.ToString("d  MMMM  yyyy"))
                vRpt.SetParameterValue(vRpt.Parameter_sMonth.ParameterFieldName, "")
            Else
                vRpt.SetParameterValue(vRpt.Parameter_sDay.ParameterFieldName, "")
                vRpt.SetParameterValue(vRpt.Parameter_sMonth.ParameterFieldName, "ประจำเดือน   " & DayOfMonth.Value.ToString("MMMM  yyyy"))
            End If
            vRpt.SetParameterValue(vRpt.Parameter_TitleCus.ParameterFieldName, "รายงานการเข้าพบคู่ค้า")
            vRpt.SetParameterValue(vRpt.Parameter_cntRow.ParameterFieldName, "รายการเข้าพบคู่ค้าทั้งหมด    " & Format(MeetRpt.Rows.Count, "#,##0") & "    รายการ")
            vRpt.SetParameterValue(vRpt.Parameter_RptFormat.ParameterFieldName, "รูปแบบรายงาน  " & ReportFormat)
            vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
            vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, mdPsPrint())

            vFrm.crView.ReportSource = vRpt
            'vFrm.ppDisplayGroupTree = True
            vFrm.Show()
        End If

    End Sub

    Private Sub RdSDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdSDay.CheckedChanged
        If RdSDay.Checked = True Then
            DateTime_Ts1.Enabled = True
            DateTime_Ts2.Enabled = True
            DayOfMonth.Enabled = False
        Else
            DateTime_Ts1.Enabled = False
            DateTime_Ts2.Enabled = False
            DayOfMonth.Enabled = True
        End If

    End Sub

    Private Function ConvertToDateThai(ByVal dtDate As DateTime) As String
        Dim dtTo As New DateTime(dtDate.Year, dtDate.Month, dtDate.Day)
        Dim wDay As String = ""
        wDay = Weekday(dtTo)
        Select Case wDay
            Case 1 : wDay = "วัน อาทิตย์"
            Case 2 : wDay = "วัน จันทร์"
            Case 3 : wDay = "วัน อังคาร"
            Case 4 : wDay = "วัน พุธ"
            Case 5 : wDay = "วัน พฤหัสบดี"
            Case 6 : wDay = "วัน ศุกร์"
            Case 7 : wDay = "วัน เสาร์"
        End Select
        Return wDay & "  " & dtDate.Day & "  " & DayOfMonth.Value.ToString("MMMM  yyyy")
    End Function
End Class