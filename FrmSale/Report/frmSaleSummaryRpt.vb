Public Class frmSaleSummaryRpt

    Private Sub frmSaleSummaryRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpDate.Value = Date.Today
        Me.dtpMonth.Value = Date.Today
        Me.dtpYear.Value = Date.Today
        Me.dtpDateS.Value = Date.Today
        Me.dtpDateE.Value = Date.Today

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        mdLoadShow()
        Dim strDate As String = ""
        Dim ptDate As String = ""
        Dim vWhere As String = ""
        Dim vWhereLess As String = ""
        Dim stChart = 0
        Dim NotShow As Integer = 0 '1=no Show

        If rdbDate.Checked = True Then
            vWhere = vWhere & " m.DateSale = '" & ksbDateToString(dtpDate.Value.ToShortDateString) & "' "
            vWhereLess = vWhereLess & " m.DateSale < '" & ksbDateToString(dtpDate.Value.ToShortDateString) & "' "
            ptDate = "วันที่ :  " & dtpDate.Value.ToShortDateString
        ElseIf rdbMonth.Checked = True Then
            Dim month As String = ""
            Dim MonthShow As String = ""
            If Me.dtpMonth.Value.Month.ToString.Length = 1 Then
                MonthShow = Microsoft.VisualBasic.Right(Me.dtpMonth.Text, 4) & "0" & Me.dtpMonth.Value.Month
            ElseIf Me.dtpMonth.Value.Month.ToString.Length = 2 Then
                MonthShow = Microsoft.VisualBasic.Right(Me.dtpMonth.Text, 4) & Me.dtpMonth.Value.Month
            End If

            vWhere = vWhere & "SUBSTRING(m.DateSale,1,6) = '" & MonthShow & "' "
            vWhereLess = vWhereLess & "SUBSTRING(m.DateSale,1,6) < '" & MonthShow & "' "
            ptDate = "เดือน :  " & dtpMonth.Text
        ElseIf rdbYear.Checked = True Then
            vWhere = vWhere & " SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "'"
            vWhereLess = vWhereLess & " SUBSTRING(m.DateSale, 1, 4) < '" & Me.dtpYear.Text & "' "
            ptDate = "ปี : " & dtpYear.Text
        ElseIf rdbDateB.Checked = True Then
            vWhere = vWhere & "m.DateSale Between '" & ksbDateToString(dtpDateS.Value.ToShortDateString) & "' " & _
            "And '" & ksbDateToString(dtpDateE.Value.ToShortDateString) & "' "
            vWhereLess = vWhereLess & "m.DateSale < '" & ksbDateToString(dtpDateS.Value.ToShortDateString) & "' "
            ptDate = "ระหว่างวันที่ : " & dtpDateS.Value.ToShortDateString & " ถึง " & dtpDateE.Value.ToShortDateString
        End If

        Dim type As Integer
        Dim ptType As String = ""

        If rbType1.Checked = True Then
            type = 1
            ptType = rbType1.Text
        ElseIf rbType2.Checked = True Then
            type = 0
            ptType = rbType2.Text
        ElseIf rbType3.Checked = True Then
            type = 2
            ptType = rbType3.Text
        End If

        Dim ptData As String = ""
        Dim strSQL As String = ""

        If Me.rdbSalePv.Checked = True Then 'ยอดขายพนักงานขายแยกตามจังหวัด

            Dim vWhereType As String = ""
            If type = 1 Then
                vWhereType = " AND m.stRight = '1' "
            ElseIf type = 0 Then
                vWhereType = " AND m.stRight = '0' "
            Else
                vWhereType = ""
            End If

            ptData = rdbSalePv.Text
            strSQL = "SELECT m.idPsSale, m.PsSale, m.CusName, m.TotalSale As TotalNet, pv.PvName As province, " & _
                     "r.RegionName As Region FROM vSmSaleMt AS m LEFT OUTER JOIN " & _
                     "dCustomer AS c ON m.idCus = c.idCus " & _
                     "LEFT OUTER JOIN dProvinceFixSale AS pv ON c.idPv = pv.idPv " & _
                     "LEFT OUTER JOIN dRegion AS r ON pv.idRegion = r.idRegion " & _
                     "WHERE " & vWhere & vWhereType & "  AND (m.idPsCancel IS NULL) AND " & _
                     "(m.idComp = '" & sIdComp & "')"

            Dim SaleSummaryPsSale As New DataTable
            SaleSummaryPsSale.Clear()
            mdCnOpen()
            sCommand.CommandText = strSQL
            sAdapter.Fill(SaleSummaryPsSale)

            For i As Integer = 0 To SaleSummaryPsSale.Rows.Count - 1
                If IsDBNull(SaleSummaryPsSale.Rows(i).Item("Region")) Then
                    SaleSummaryPsSale.Rows(i).Item("Region") = "ต่างประเทศ"
                End If

                If SaleSummaryPsSale.Rows(i).Item("province") = "-" Then
                    SaleSummaryPsSale.Rows(i).Item("province") = "ต่างประเทศ"
                End If
            Next

            If SaleSummaryPsSale.Rows.Count = 0 Then
                mdLoadCommitt()
                MessageBox.Show("ไม่พบข้อมูลที่สามารถแสดงรายงานได้", sSystemName)
            Else
                Dim vFrm As New frmReportView
                Dim vRpt As New crpSaleSummaryPsSale
                vRpt.SetDataSource(SaleSummaryPsSale)

                vRpt.SetParameterValue(vRpt.Parameter_ptTitle.ParameterFieldName, "รายงานยอดขายพนักงานขายแยกตามภาคและจังหวัด")
                vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
                vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, "ผู้สั่งพิมพ์เอกสาร : " & sPsName)
                vRpt.SetParameterValue(vRpt.Parameter_ptDate.ParameterFieldName, ptDate)
                vRpt.SetParameterValue(vRpt.Parameter_ptType.ParameterFieldName, "ประเภทบิล : " & ptType)
                vRpt.SetParameterValue(vRpt.Parameter_ptData.ParameterFieldName, "ข้อมูล : " & ptData)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
            End If
        ElseIf Me.rdbPdPkNotSale.Checked = True Then 'สินค้าที่ไม่มียอดขาย

            Dim TypePd As String = "'"
            Dim vWhereType As String = ""
            If type = 1 Then
                vWhereType = "AND stRight = '1'"
            ElseIf type = 0 Then
                vWhereType = "AND stRight = '0'"
            Else
                vWhereType = ""
            End If

            ptData = rdbPdPkNotSale.Text


            Dim SaleSummaryNoPdSale As New DataTable
            SaleSummaryNoPdSale.Clear()
            mdCnOpen()

            If Me.rdbGen.Checked = True Then
                TypePd = Me.rdbGen.Text
                strSQL = "SELECT idPdPk, PdPkName As Data, '' As LastDate, 0 As CountDay FROM vPackingPdSet " & _
                         "WHERE idPdPk NOT IN (SELECT DISTINCT d.idPdPk FROM SmSaleDt d INNER JOIN SmSaleMt m " & _
                         "ON d.idSale = m.idSale Where " & vWhere & vWhereType & " AND m.idComp = '" & sIdComp & "') " & _
                         "Order By PdPkName"
            ElseIf Me.rdbMat.Checked = True Then 'สินค้าวัตถุดิบ
                TypePd = Me.rdbMat.Text
                strSQL = "SELECT idPd As idPdPk, PdName As Data, '' As LastDate, 0 As CountDay FROM vSeedProduct " & _
                         "WHERE idPd <> 0 AND PdName <>'' AND idPd NOT IN (SELECT DISTINCT d.idPd " & _
                         "FROM SmSaleDtPd d INNER JOIN SmSaleMt m ON d.idSale = m.idSale " & _
                         "Where " & vWhere & vWhereType & " AND m.idComp = " & sIdComp & ") Order By PdName"
            ElseIf Me.rdbOther.Checked = True Then 'สินค้าอื่นๆ
                TypePd = Me.rdbOther.Text
                strSQL = "SELECT idPdo As idPdPk, Title As Data, '' As LastDate, 0 As CountDay FROM SmPdOtherD " & _
                         "WHERE idPdo NOT IN (SELECT DISTINCT d.idPdo FROM SmSaleDtOther d INNER JOIN SmSaleMt m " & _
                         "ON d.idSale = m.idSale Where " & vWhere & vWhereType & " AND m.idComp = '" & sIdComp & "') " & _
                         "Order By Title"
            End If

            sCommand.CommandText = strSQL
            sAdapter.Fill(SaleSummaryNoPdSale)


            For i As Integer = 0 To SaleSummaryNoPdSale.Rows.Count - 1
                Dim sDt As New DataTable
                Dim sqlDate As String = ""
                sDt.Clear()

                If Me.rdbGen.Checked = True Then
                    sqlDate = "SELECT MAX(m.DateSale) As Lastdate From SmSaleMt m LEFT OUTER JOIN SmSaleDt d " & _
                              "ON m.idSale=d.idSale Where " & vWhereLess & vWhereType & " AND m.idComp = '" & sIdComp & "' " & _
                              "AND d.idPdPk = '" & SaleSummaryNoPdSale.Rows(i).Item("idPdPk") & "'"
                ElseIf Me.rdbMat.Checked = True Then 'สินค้าวัตถุดิบ
                    sqlDate = "SELECT MAX(m.DateSale) As Lastdate From SmSaleMt m LEFT OUTER JOIN SmSaleDtPd d " & _
                              "ON m.idSale = d.idSale Where " & vWhereLess & vWhereType & " AND m.idComp = '" & sIdComp & "' " & _
                              "AND d.idPd = '" & SaleSummaryNoPdSale.Rows(i).Item("idPdPk") & "'"
                ElseIf Me.rdbOther.Checked = True Then 'สินค้าอื่นๆ
                    sqlDate = "SELECT MAX(m.DateSale) As Lastdate From SmSaleMt m LEFT OUTER JOIN SmSaleDtOther d " & _
                              "ON m.idSale = d.idSale Where " & vWhereLess & vWhereType & " AND m.idComp = '" & sIdComp & "' " & _
                              "AND d.idPdo = '" & SaleSummaryNoPdSale.Rows(i).Item("idPdPk") & "'"
                End If


                sCommand.CommandText = sqlDate
                sAdapter.Fill(sDt)


                If IsDBNull(sDt.Rows(0).Item("Lastdate")) Then
                    SaleSummaryNoPdSale.Rows(i).Item("LastDate") = "ไม่พบข้อมูลขาย"
                    SaleSummaryNoPdSale.Rows(i).Item("CountDay") = 0
                Else
                    SaleSummaryNoPdSale.Rows(i).Item("LastDate") = ksbStringToDate(sDt.Rows(0).Item("Lastdate"))

                    Dim LastDate As Date = ksbStringToDate(sDt.Rows(0).Item("Lastdate"))
                    SaleSummaryNoPdSale.Rows(i).Item("CountDay") = DateDiff(DateInterval.Day, LastDate, Date.Today)
                End If
                'SaleSummaryNoPdSale.DefaultView.Sort = "LastDate"
            Next

            If SaleSummaryNoPdSale.Rows.Count = 0 Then
                mdLoadCommitt()
                MessageBox.Show("ไม่พบข้อมูลที่สามารถแสดงรายงานได้", sSystemName)
            Else
                Dim vFrm As New frmReportView
                Dim vRpt As New crpSaleSummaryNoPdSale
                vRpt.SetDataSource(SaleSummaryNoPdSale)

                vRpt.SetParameterValue(vRpt.Parameter_ptTitle.ParameterFieldName, "รายงานรายการสินค้าที่ไม่มียอดขาย")
                vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
                vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, "ผู้สั่งพิมพ์เอกสาร : " & sPsName)
                vRpt.SetParameterValue(vRpt.Parameter_ptDate.ParameterFieldName, ptDate)
                vRpt.SetParameterValue(vRpt.Parameter_ptType.ParameterFieldName, "ประเภทบิล : " & ptType)
                vRpt.SetParameterValue(vRpt.Parameter_ptData.ParameterFieldName, "ข้อมูล : " & ptData)
                vRpt.SetParameterValue(vRpt.Parameter_ptTypePd.ParameterFieldName, "ประเภทสินค้า : " & TypePd)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
                Me.Close()
            End If
        ElseIf Me.rdbCusNotSale.Checked = True Then 'ลูกค้าที่ไม่มียอดขาย
            NotShow = 1

            Dim vWhereType As String = ""
            If type = 1 Then
                vWhereType = "AND stRight = '1'"
            ElseIf type = 0 Then
                vWhereType = "AND stRight = '0'"
            Else
                vWhereType = ""
            End If

            ptData = rdbCusNotSale.Text
            strSQL = "SELECT idCus, CusName_ As Data, '' As LastDate, 0 As CountDay FROM vCustomer WHERE idCus NOT IN " & _
                     "(SELECT DISTINCT m.idCus FROM SmSaleMt m Where " & vWhere & vWhereType & " " & _
                     "AND m.idComp = '" & sIdComp & "') Order By CusName_"

            Dim SaleSummaryNoPdSale As New DataTable
            SaleSummaryNoPdSale.Clear()
            mdCnOpen()
            sCommand.CommandText = strSQL
            sAdapter.Fill(SaleSummaryNoPdSale)

            For i As Integer = 0 To SaleSummaryNoPdSale.Rows.Count - 1
                Dim sDt As New DataTable
                Dim sqlDate As String = ""
                sDt.Clear()

                sqlDate = "SELECT MAX(m.DateSale) As Lastdate From SmSaleMt m Where " & vWhereLess & vWhereType & " " & _
                          "AND m.idComp = '" & sIdComp & "' AND m.idCus = '" & SaleSummaryNoPdSale.Rows(i).Item("idCus") & "'"

                sCommand.CommandText = sqlDate
                sAdapter.Fill(sDt)


                If IsDBNull(sDt.Rows(0).Item("Lastdate")) Then
                    SaleSummaryNoPdSale.Rows(i).Item("LastDate") = "ไม่พบข้อมูลขาย"
                    SaleSummaryNoPdSale.Rows(i).Item("CountDay") = 0
                Else
                    SaleSummaryNoPdSale.Rows(i).Item("LastDate") = ksbStringToDate(sDt.Rows(0).Item("Lastdate"))

                    Dim LastDate As Date = ksbStringToDate(sDt.Rows(0).Item("Lastdate"))
                    SaleSummaryNoPdSale.Rows(i).Item("CountDay") = DateDiff(DateInterval.Day, LastDate, Date.Today)
                End If
                'SaleSummaryNoPdSale.DefaultView.Sort = "LastDate"
            Next

            If SaleSummaryNoPdSale.Rows.Count = 0 Then
                mdLoadCommitt()
                MessageBox.Show("ไม่พบข้อมูลที่สามารถแสดงรายงานได้", sSystemName)
            Else
                Dim vFrm As New frmReportView
                Dim vRpt As New crpSaleSummaryNoPdSale
                vRpt.SetDataSource(SaleSummaryNoPdSale)

                vRpt.SetParameterValue(vRpt.Parameter_ptTitle.ParameterFieldName, "รายงานรายการลูกค้าที่ไม่มียอดขาย")
                vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
                vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, "ผู้สั่งพิมพ์เอกสาร : " & sPsName)
                vRpt.SetParameterValue(vRpt.Parameter_ptDate.ParameterFieldName, ptDate)
                vRpt.SetParameterValue(vRpt.Parameter_ptType.ParameterFieldName, "ประเภทบิล : " & ptType)
                vRpt.SetParameterValue(vRpt.Parameter_ptData.ParameterFieldName, "ข้อมูล : " & ptData)
                vRpt.SetParameterValue(vRpt.Parameter_ptTypePd.ParameterFieldName, "ประเภทสินค้า : - ")
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
                Me.Close()
            End If

        Else 'crp ตัวเดียวกัน
            Dim TypePd As String = "'"

            If rbCus.Checked = True Then
                'Dim vWhereType As String = ""
                'If type = 1 Then
                '    vWhereType = "AND stRight = '1'"
                'ElseIf type = 0 Then
                '    vWhereType = "AND stRight = '0'"
                'Else
                '    vWhereType = ""
                'End If

                'ptData = rbCus.Text
                'strSQL = "Select CusName AS Data,SUM(TotalNet) AS TotalNet From vSmSaleMt WHERE substring(DateSale,1," & subStrDate & ") = '" & strDate & "'" & vWhereType & " GROUP BY CusName"
            ElseIf rbPd.Checked = True Then '--ยอดขายรายสินค้า---'
                Me.GroupBox5.Visible = True 'select Type Of Pd

                Dim vWhereType As String = ""
                If type = 1 Then
                    vWhereType = " AND m.stRight = '1' "
                ElseIf type = 0 Then
                    vWhereType = " AND m.stRight = '0' "
                Else
                    vWhereType = ""
                End If

                Dim vOrderBy As String = ""
                If Me.rdbMaxMin.Checked = True Then
                    vOrderBy = " Order By TotalNet DESC"
                    stChart = 1
                ElseIf Me.rdbMinMax.Checked = True Then
                    vOrderBy = " Order By TotalNet ASC"
                    stChart = 2
                End If

                ptData = rbPd.Text

                If Me.rdbGen.Checked = True Then
                    TypePd = Me.rdbGen.Text
                    strSQL = "SELECT Data, TotalNet FROM (SELECT PdPkName As Data, " & _
                          "SUM(ToTal) AS TotalNet FROM (SELECT idPdPk, PdPkName, ToTal " & _
                          "FROM (SELECT d.idPdPk, p.PdPkName, SUM(d.Price * d.Amount) AS ToTal FROM " & _
                          "SmSaleMt AS m LEFT OUTER JOIN SmSaleDt AS d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
                          "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & vWhere & vWhereType & " " & _
                          "AND (d.idPkUnit <> '3') AND (m.idPsCancel IS NULL) AND (m.idComp = '" & sIdComp & "') " & _
                          "GROUP BY d.idPdPk, p.PdPkName) AS a UNION SELECT idPdPk, PdPkName, ToTal " & _
                          "FROM (SELECT d.idPdPk, p.PdPkName, SUM(d.Price * d.Amount * d.Perbox) AS ToTal " & _
                          "FROM SmSaleMt AS m LEFT OUTER JOIN SmSaleDt AS d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
                          "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE " & vWhere & vWhereType & " " & _
                          "AND (d.idPkUnit = '3') AND (m.idPsCancel IS NULL) AND (m.idComp = '" & sIdComp & "') " & _
                          "GROUP BY d.idPdPk, p.PdPkName) AS b) AS result " & _
                          "GROUP BY idPdPk, PdPkName) As c WHERE (TotalNet > 0) " & vOrderBy
                ElseIf Me.rdbMat.Checked = True Then 'สินค้าวัตถุดิบ
                    TypePd = Me.rdbMat.Text
                    strSQL = "SELECT Data, TotalNet FROM (SELECT PdName As Data, " & _
                             "SUM(ToTal) AS TotalNet FROM (SELECT idPd, PdName, ToTal " & _
                             "FROM (SELECT d.idPd, p.PdName, SUM(d.Price * d.Amount) AS ToTal  FROM SmSaleDtPd d " & _
                             "LEFT OUTER JOIN SmSaleMt m ON d.idSale = m.idSale " & _
                             "LEFT OUTER JOIN vSeedProduct p ON d.idPd = p.idPd WHERE " & vWhere & vWhereType & " " & _
                             "AND (m.idPsCancel IS NULL) AND (m.idComp = '" & sIdComp & "') " & _
                             "GROUP BY d.idPd, p.PdName) AS a) AS result " & _
                             "GROUP BY idPd, PdName) As c WHERE TotalNet > 0 " & vOrderBy
                ElseIf Me.rdbOther.Checked = True Then 'สินค้าอื่นๆ
                    TypePd = Me.rdbOther.Text
                    strSQL = "SELECT Data, TotalNet FROM (SELECT Title As Data, " & _
                             "SUM(ToTal) AS TotalNet FROM (SELECT idPdo, Title, ToTal " & _
                             "FROM (SELECT d.idPdo, p.Title, SUM(d.Price * d.Amount) AS ToTal  FROM SmSaleDtOther d " & _
                             "LEFT OUTER JOIN SmSaleMt m ON d.idSale = m.idSale " & _
                             "LEFT OUTER JOIN SmPdOtherD p ON d.idPdo = p.idPdo WHERE " & vWhere & vWhereType & " " & _
                             "AND (m.idPsCancel IS NULL) AND (m.idComp = '" & sIdComp & "') " & _
                             "GROUP BY d.idPdo, p.Title) AS a) AS result " & _
                             "GROUP BY idPdo, Title) As c WHERE TotalNet > 0 " & vOrderBy
                End If


            ElseIf rbPlant.Checked = True Then
                'Dim vWhereType As String = ""
                'If type = 1 Then
                '    vWhereType = "AND vSSM.stRight = '1'"
                'ElseIf type = 0 Then
                '    vWhereType = "AND vSSM.stRight = '0'"
                'Else
                '    vWhereType = ""
                'End If

                'ptData = rbPlant.Text
                'strSQL = "Select vPPS.PlantName AS Data,(SSD.Amount * SSD.Price) AS TotalNet,SSD.idPkUnit,SSD.Perbox From vSmSaleMt vSSM,SmSaleDt SSD,vPackingPdSet vPPS WHERE vSSM.idSale = SSD.idSale AND SSD.idPdPk = vPPS.idPdPk AND substring(vSSM.DateSale,1," & subStrDate & ") = '" & strDate & "'" & vWhereType
            ElseIf rbSale.Checked = True Then '--ยอดขายรายพนักงาน---'
                TypePd = "-"
                Dim vWhereType As String = ""
                If type = 1 Then
                    vWhereType = "AND stRight = '1'"
                ElseIf type = 0 Then
                    vWhereType = "AND stRight = '0'"
                Else
                    vWhereType = ""
                End If

                Dim vOrderBy As String = ""
                If Me.rdbMaxMin.Checked = True Then
                    vOrderBy = " Order By TotalNet DESC"
                    stChart = 1
                ElseIf Me.rdbMinMax.Checked = True Then
                    vOrderBy = " Order By TotalNet ASC"
                    stChart = 2
                End If

                ptData = rbSale.Text
                strSQL = "Select m.PsSale AS Data, SUM(m.TotalSale) AS TotalNet From vSmSaleMt m " & _
                         "WHERE " & vWhere & vWhereType & "  AND (m.idPsCancel IS NULL) AND " & _
                         "(m.idComp = '" & sIdComp & "') GROUP BY m.PsSale " & vOrderBy
            End If

            Dim MyTable As New DataTable
            MyTable.Clear()
            mdCnOpen()
            sCommand.CommandText = strSQL
            sAdapter.Fill(MyTable)

            If MyTable.Rows.Count = 0 Then
                mdLoadCommitt()
                MessageBox.Show("ไม่พบข้อมูลที่สามารถแสดงรายงานได้", sSystemName)
            Else
                Dim vFrm As New frmReportView
                Dim vRpt As New crpSaleSummary
                vRpt.SetDataSource(MyTable)

                vRpt.SetParameterValue(vRpt.Parameter_ptTitle.ParameterFieldName, "รายงานสรุปยอดขาย")
                vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
                vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, "ผู้สั่งพิมพ์เอกสาร : " & sPsName)
                vRpt.SetParameterValue(vRpt.Parameter_ptDate.ParameterFieldName, ptDate)
                vRpt.SetParameterValue(vRpt.Parameter_ptStChart.ParameterFieldName, stChart)
                vRpt.SetParameterValue(vRpt.Parameter_ptNotShow.ParameterFieldName, NotShow)
                vRpt.SetParameterValue(vRpt.Parameter_ptType.ParameterFieldName, "ประเภทบิล : " & ptType)
                vRpt.SetParameterValue(vRpt.Parameter_ptData.ParameterFieldName, "ข้อมูล : " & ptData)
                vRpt.SetParameterValue(vRpt.Parameter_ptTypePd.ParameterFieldName, "ประเภทสินค้า : " & TypePd)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
                Me.Close()
            End If
        End If
        mdLoadCommitt()


    End Sub

    Private Sub rbMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMonth.CheckedChanged
        If Me.rdbMonth.Checked Then
            dtpMonth.Enabled = True
        Else
            dtpMonth.Enabled = False
        End If
    End Sub

    Private Sub rdbYear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbYear.CheckedChanged
        If Me.rdbYear.Checked = True Then
            dtpYear.Enabled = True
        Else
            dtpYear.Enabled = False
        End If
    End Sub

    Private Sub rdbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDate.CheckedChanged
        If Me.rdbDate.Checked = True Then
            Me.dtpDate.Enabled = True
        Else
            Me.dtpDate.Enabled = False
        End If
    End Sub

    Private Sub rdbDateB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDateB.CheckedChanged
        If Me.rdbDateB.Checked = True Then
            Me.dtpDateS.Enabled = True
            Me.dtpDateE.Enabled = True
        Else
            Me.dtpDateS.Enabled = False
            Me.dtpDateE.Enabled = False
        End If
    End Sub

    Private Sub rdbPdPkNotSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPdPkNotSale.CheckedChanged
        If Me.rdbPdPkNotSale.Checked = True Then
            Me.GroupBox4.Visible = False
            Me.GroupBox5.Visible = True
        Else
            Me.GroupBox4.Visible = True
        End If
    End Sub

    Private Sub rdbCusNotSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCusNotSale.CheckedChanged
        If Me.rdbCusNotSale.Checked = True Then
            Me.GroupBox4.Visible = False
            Me.GroupBox5.Visible = False 'No select Type Of Pd
        Else
            Me.GroupBox4.Visible = True
        End If
    End Sub

    Private Sub rdbSalePv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSalePv.CheckedChanged
        If Me.rdbSalePv.Checked = True Then
            Me.GroupBox4.Visible = False
            Me.GroupBox5.Visible = False 'No select Type Of Pd
        Else
            Me.GroupBox4.Visible = True
        End If
    End Sub

    Private Sub rbSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSale.CheckedChanged
        If Me.rbSale.Checked = True Then
            Me.GroupBox5.Visible = False 'No select Type Of Pd
        End If
    End Sub

    Private Sub rbPd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPd.CheckedChanged
        If Me.rbPd.Checked = True Then
            Me.GroupBox5.Visible = True
        End If
    End Sub
End Class