Public Class frmSlReturnRpt

    Private Sub frmSlReturnRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpSaleS.Value = Date.Today
        Me.dtpSaleE.Value = Date.Today
        Me.dtpMonthS.Value = Date.Today
        Me.dtpYear.Value = Date.Today
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim vWhere As String = ""
        Dim para_DateS As String = ""
        'Dim para_DateE As String = ""
        mdLoadShow()

        '---ช่วงวันที่---'
        If Me.rdbDate.Checked = True Then
            vWhere = vWhere & " mt.DateReturn Between '" & ksbDateToString(dtpSaleS.Value.ToShortDateString) & "' " & _
                    "And '" & ksbDateToString(dtpSaleE.Value.ToShortDateString) & "' "
        ElseIf Me.rdbMonth.Checked = True Then
            Dim YearMonthS As String = ""
            'Dim YearMonthE As String = ""

            If Me.dtpMonthS.Value.Month.ToString.Length = 1 Then
                YearMonthS = Microsoft.VisualBasic.Right(Me.dtpMonthS.Text, 4) & "0" & Me.dtpMonthS.Value.Month
            ElseIf Me.dtpMonthS.Value.Month.ToString.Length = 2 Then
                YearMonthS = Microsoft.VisualBasic.Right(Me.dtpMonthS.Text, 4) & Me.dtpMonthS.Value.Month
            End If


            'If Me.dtpMonthE.Value.Month.ToString.Length = 1 Then
            '    YearMonthE = Microsoft.VisualBasic.Right(Me.dtpMonthE.Text, 4) & "0" & Me.dtpMonthE.Value.Month
            'ElseIf Me.dtpMonthE.Value.Month.ToString.Length = 2 Then
            '    YearMonthE = Microsoft.VisualBasic.Right(Me.dtpMonthE.Text, 4) & Me.dtpMonthE.Value.Month
            'End If
            vWhere = vWhere & "SUBSTRING(mt.DateReturn,1,6) = '" & YearMonthS & "' "
        ElseIf Me.rdbYearC.Checked = True Then
            vWhere = vWhere & "SUBSTRING(mt.DateReturn, 1, 4) = '" & Me.dtpYear.Text & "'"
        End If


        '************* for Main Report (Start) *************'
        Dim ReturnRpt As New DataTable
        ReturnRpt.Clear()
        mdCnOpen()
        sCommand.CommandText = "Select mt.idSaleReturn, mt.DateReturn, c.CusName_, p.PsName As PsSaleName, " & _
                               "mt.ToTal, mt.DocNum, mt.DocRef, sl.DocCode, p2.PsName As PsReturn, mt.Note, " & _
                               "rt.ReturnCause FROM SmSaleReturnMt mt LEFT OUTER JOIN SmSaleMt sl ON mt.idSale = sl.idSale " & _
                               "LEFT OUTER JOIN vCustomer c ON mt.idCus = c.idCus " & _
                               "LEFT OUTER JOIN vPerson p ON mt.idPsSale = p.idPs " & _
                               "LEFT OUTER JOIN vPerson p2 ON mt.idPsReturn = p2.idPs " & _
                               "LEFT OUTER JOIN SmSaleReturnCause rt ON mt.idRtCause = rt.idRtCause " & _
                               "Where " & vWhere & " AND mt.idPsCancel Is Null ORDER BY DateReturn ASC"
        sAdapter.Fill(ReturnRpt)

        If ReturnRpt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่มีรายการคืนสินค้าที่สามารถแสดงรายงานได้", sSystemName)
        Else
            For i As Integer = 0 To ReturnRpt.Rows.Count - 1
                ReturnRpt.Rows(i).Item("DateReturn") = ksbStringToDate(ReturnRpt.Rows(i).Item("DateReturn"))
            Next

            '*************** for Main Report (End) *****************'

            '*************** for Audit Sub Report (Start) **********'
            Dim SubReturnRpt As New DataTable
            SubReturnRpt.Clear()

            'sCommand.CommandText = "SELECT dt.idSaleReturn, p.PdCode, p.PdPkName, dt.AmountReturn, u.PkUnitName, " & _
            '                       "dt.idPkUnit, dt.Price, p.Perbox FROM SmSaleReturnDt dt LEFT OUTER JOIN " & _
            '                       "vPackingPdSet p ON dt.idPdPk = p.idPdPk LEFT OUTER JOIN dPackingUnit u " & _
            '                       "ON dt.idPkUnit = u.idPkUnit"

            sCommand.CommandText = "SELECT dt.idSaleReturn, p.PdCode, p.PdPkName, dt.AmountReturn, u.PkUnitName, " & _
                                   "dt.idPkUnit, dt.Price, dt.RTValuePerc, dt.RTPrice, p.Perbox FROM SmSaleReturnDt dt LEFT OUTER JOIN " & _
                                   "vPackingPdSet p ON dt.idPdPk = p.idPdPk LEFT OUTER JOIN dPackingUnit u " & _
                                   "ON dt.idPkUnit = u.idPkUnit WHERE dt.idPdPk IS NOT NULL UNION " & _
                                   "SELECT dt.idSaleReturn, '' As PdCode, p.Title As PdPkName, dt.AmountReturn, " & _
                                   "dt.PdoUnit As PkUnitName, 0 As idPkUnit, dt.Price, dt.RTValuePerc, dt.RTPrice, p.Perbox " & _
                                   "FROM SmSaleReturnDt dt LEFT OUTER JOIN SmPdOtherD p ON dt.idPdo = p.idPdo " & _
                                   "WHERE dt.idPdo IS NOT NULL UNION SELECT dt.idSaleReturn, '' As PdCode, " & _
                                   "n.PdName As PdPkName, dt.AmountReturn, dt.PdoUnit As PkUnitName, " & _
                                   "0 As idPkUnit, dt.Price, dt.RTValuePerc, dt.RTPrice, 0 As Perbox " & _
                                   "FROM SmSaleReturnDt dt LEFT OUTER JOIN " & _
                                   "PkPdLotStock p ON dt.idPdLot = p.idPdLot LEFT OUTER JOIN vSeedProduct n " & _
                                   "ON p.idPd = n.idPd WHERE dt.idPdLot IS NOT NULL"

            sAdapter.Fill(SubReturnRpt)

            For i As Integer = 0 To SubReturnRpt.Rows.Count - 1
                If SubReturnRpt.Rows(i).Item("idPkUnit") = 3 Then 'กล่อง
                    SubReturnRpt.Rows(i).Item("RTPrice") = SubReturnRpt.Rows(i).Item("RTPrice") * SubReturnRpt.Rows(i).Item("Perbox")
                End If
            Next
            '*********** for Audit Sub Report (End) *****************'

            Dim vFrm As New frmReportView
            Dim vRpt As New crpSlReturnRpt
            '** for Main Report **'
            vRpt.SetDataSource(ReturnRpt)

            If Me.rdbDate.Checked = True Then
                para_DateS = "วันที่   " & dtpSaleS.Value.ToShortDateString & "  ถึง   " & dtpSaleE.Value.ToShortDateString
                'para_DateE = "ถึง     " & dtpSaleE.Value.ToShortDateString
            ElseIf Me.rdbMonth.Checked = True Then
                para_DateS = " เดือน  " & Me.dtpMonthS.Text
                'para_DateE = "ปี   " & Me.cmbYear.Text
            ElseIf Me.rdbYearC.Checked = True Then
                para_DateS = "ปี  " & Me.dtpYear.Text
            End If
            '** for Audit Sub Report **'
            vRpt.Subreports("SubReturnRpt").SetDataSource(SubReturnRpt)

            vRpt.SetParameterValue(vRpt.Parameter_DateS.ParameterFieldName, para_DateS)
            ' vRpt.SetParameterValue(vRpt.Parameter_DateF.ParameterFieldName, para_DateE)
            vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
            vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, sPsName)
            vFrm.crView.ReportSource = vRpt
            vFrm.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            vFrm.Show()
            mdLoadCommitt()
        End If 'End Check Row =0

    End Sub


    'Private Sub SelectMonth()
    '    mdCnOpen()
    '    Dim sDt As New DataTable
    '    sCommand.CommandText = "Select distinct SUBSTRING(DateReturn,5,2) as f_Month From SmSaleReturnMt ORDER BY f_Month"
    '    sAdapter.Fill(sDt)
    '    sDt.Columns.Add("MonthName")
    '    For i As Integer = 0 To sDt.Rows.Count - 1
    '        If sDt.Rows(i).Item("f_Month") = "01" Then
    '            sDt.Rows(i).Item("MonthName") = "มกราคม"
    '        ElseIf sDt.Rows(i).Item("f_Month") = "02" Then
    '            sDt.Rows(i).Item("MonthName") = "กุมภาพันธ์"
    '        ElseIf sDt.Rows(i).Item("f_Month") = "03" Then
    '            sDt.Rows(i).Item("MonthName") = "มีนาคม"
    '        ElseIf sDt.Rows(i).Item("f_Month") = "04" Then
    '            sDt.Rows(i).Item("MonthName") = "เมษายน"
    '        ElseIf sDt.Rows(i).Item("f_Month") = "05" Then
    '            sDt.Rows(i).Item("MonthName") = "พฤษภาคม"
    '        ElseIf sDt.Rows(i).Item("f_Month") = "06" Then
    '            sDt.Rows(i).Item("MonthName") = "มิถุนายน"
    '        ElseIf sDt.Rows(i).Item("f_Month") = "07" Then
    '            sDt.Rows(i).Item("MonthName") = "กรกฎาคม"
    '        ElseIf sDt.Rows(i).Item("f_Month") = "08" Then
    '            sDt.Rows(i).Item("MonthName") = "สิงหาคม"
    '        ElseIf sDt.Rows(i).Item("f_Month") = "09" Then
    '            sDt.Rows(i).Item("MonthName") = "กันยายน"
    '        ElseIf sDt.Rows(i).Item("f_Month") = "10" Then
    '            sDt.Rows(i).Item("MonthName") = "ตุลาคม"
    '        ElseIf sDt.Rows(i).Item("f_Month") = "11" Then
    '            sDt.Rows(i).Item("MonthName") = "พฤศจิกายน"
    '        ElseIf sDt.Rows(i).Item("f_Month") = "12" Then
    '            sDt.Rows(i).Item("MonthName") = "ธันวาคม"
    '        End If
    '    Next
    '    With cmbMonth
    '        .DisplayMember = "MonthName"
    '        .ValueMember = "f_Month"
    '        .DataSource = sDt
    '    End With
    'End Sub

    Private Sub rdbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDate.CheckedChanged
        If Me.rdbDate.Checked = True Then
            Me.dtpSaleS.Enabled = True
            Me.dtpSaleE.Enabled = True
        Else
            Me.dtpSaleS.Enabled = False
            Me.dtpSaleE.Enabled = False
        End If
    End Sub

    Private Sub rdbMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMonth.CheckedChanged
        If Me.rdbMonth.Checked = True Then
            Me.dtpMonthS.Enabled = True
            'Me.dtpMonthE.Enabled = True
        Else
            Me.dtpMonthS.Enabled = False
            ' Me.dtpMonthE.Enabled = False
        End If
    End Sub

    Private Sub rdbYearC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbYearC.CheckedChanged
        If Me.rdbYearC.Checked = True Then
            Me.dtpYear.Enabled = True
        Else
            Me.dtpYear.Enabled = False
        End If
    End Sub
End Class