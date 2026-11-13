Public Class frmMkGiftCusRpt

    Private Sub SelectYear()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select distinct SUBSTRING(DateGift,1,4) as f_year From MkGiftCusMt ORDER BY f_year"
        sAdapter.Fill(sDt)
        With cmbYear
            .DisplayMember = "f_year"
            .ValueMember = "f_year"
            .DataSource = sDt
        End With
    End Sub

    Private Sub SelectMYear()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select distinct SUBSTRING(DateGift,1,4) as f_year From MkGiftCusMt ORDER BY f_year"
        sAdapter.Fill(sDt)
        With cmbMY
            .DisplayMember = "f_year"
            .ValueMember = "f_year"
            .DataSource = sDt
        End With
    End Sub

    Private Sub SelectMonth()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select distinct SUBSTRING(DateGift,5,2) as f_Month From MkGiftCusMt ORDER BY f_Month"
        sAdapter.Fill(sDt)
        sDt.Columns.Add("MonthName")
        For i As Integer = 0 To sDt.Rows.Count - 1
            If sDt.Rows(i).Item("f_Month") = "01" Then
                sDt.Rows(i).Item("MonthName") = "มกราคม"
            ElseIf sDt.Rows(i).Item("f_Month") = "02" Then
                sDt.Rows(i).Item("MonthName") = "กุมภาพันธ์"
            ElseIf sDt.Rows(i).Item("f_Month") = "03" Then
                sDt.Rows(i).Item("MonthName") = "มีนาคม"
            ElseIf sDt.Rows(i).Item("f_Month") = "04" Then
                sDt.Rows(i).Item("MonthName") = "เมษายน"
            ElseIf sDt.Rows(i).Item("f_Month") = "05" Then
                sDt.Rows(i).Item("MonthName") = "พฤษภาคม"
            ElseIf sDt.Rows(i).Item("f_Month") = "06" Then
                sDt.Rows(i).Item("MonthName") = "มิถุนายน"
            ElseIf sDt.Rows(i).Item("f_Month") = "07" Then
                sDt.Rows(i).Item("MonthName") = "กรกฎาคม"
            ElseIf sDt.Rows(i).Item("f_Month") = "08" Then
                sDt.Rows(i).Item("MonthName") = "สิงหาคม"
            ElseIf sDt.Rows(i).Item("f_Month") = "09" Then
                sDt.Rows(i).Item("MonthName") = "กันยายน"
            ElseIf sDt.Rows(i).Item("f_Month") = "10" Then
                sDt.Rows(i).Item("MonthName") = "ตุลาคม"
            ElseIf sDt.Rows(i).Item("f_Month") = "11" Then
                sDt.Rows(i).Item("MonthName") = "พฤศจิกายน"
            ElseIf sDt.Rows(i).Item("f_Month") = "12" Then
                sDt.Rows(i).Item("MonthName") = "ธันวาคม"
            End If
        Next
        With cmbMonth
            .DisplayMember = "MonthName"
            .ValueMember = "f_Month"
            .DataSource = sDt
        End With
    End Sub

    Private Sub rdbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDate.CheckedChanged
        If Me.rdbDate.Checked = True Then
            Me.dtpSaleS.Enabled = True
            Me.dtpSaleE.Enabled = True
            Me.cmbMonth.Enabled = False
            Me.cmbMY.Enabled = False
            Me.cmbYear.Enabled = False
        End If
    End Sub

    Private Sub rdbMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMonth.CheckedChanged
        If Me.rdbMonth.Checked = True Then
            Me.dtpSaleS.Enabled = False
            Me.dtpSaleE.Enabled = False
            Me.cmbMonth.Enabled = True
            Me.cmbMY.Enabled = True
            SelectMonth()
            SelectMYear()
            Me.cmbYear.Enabled = False
        End If
    End Sub

    Private Sub rdbYear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbYear.CheckedChanged
        If Me.rdbYear.Checked = True Then
            Me.dtpSaleS.Enabled = False
            Me.dtpSaleE.Enabled = False
            Me.cmbMonth.Enabled = False
            Me.cmbMY.Enabled = False
            Me.cmbYear.Enabled = True
            SelectYear()
        End If
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim vWhere As String = ""

        '---ช่วงวันที่---'
        If Me.rdbDate.Checked = True Then
            vWhere = "DateGift Between '" & ksbDateToString(dtpSaleS.Value.ToShortDateString) & "' And '" & ksbDateToString(dtpSaleE.Value.ToShortDateString) & "' "
        ElseIf Me.rdbMonth.Checked = True Then
            vWhere = "SUBSTRING(DateGift,5,2) = '" & cmbMonth.SelectedValue & "' And SUBSTRING(DateGift,1,4)= '" & cmbMY.SelectedValue & "' "
        ElseIf Me.rdbYear.Checked = True Then
            vWhere = "SUBSTRING(DateGift,1,4) = '" & cmbYear.SelectedValue & "' "
        End If

        '--- No Cancel ---'
        vWhere = vWhere & " AND idPsCancel is Null "


        '----Group----'
        If Me.rdbCus.Checked = True Then
            '---- by Customer ---'
            mdLoadShow()
            vWhere = vWhere & " AND mt.idSup is Null"

            Dim GiftDt As New DataTable
            GiftDt.Clear()
            mdCnOpen()
            sCommand.CommandText = "Select mt.idGift, mt.idCus, cus.CusName_, mt.idSup, sup.SupName, dt.idInv, dt.Amount, " & _
                                    "mt.DateGift, cd.idGC, cd.Cause, mt.idPsCommand, mt.idPsGift, Inv.InvName_, Inv.UnitName, " & _
                                    "p1.PsName as PsGift,  p2.PsName as PsCommand From GR_Group.dbo.MkGiftCusMt mt " & _
                                    "INNER JOIN GR_Group.dbo.vPerson p1 ON mt.idPsGift = p1.idPs " & _
                                    "INNER JOIN GR_Group.dbo.MkGiftCusDt dt ON dt.idGift = mt.idGift " & _
                                    "INNER JOIN GR_Group.dbo.MkGiftCauseD cd ON cd.idGC = mt.idGC " & _
                                    "INNER JOIN PchInvAndProject.dbo.vInventory Inv ON dt.idInv = Inv.idInv " & _
                                    "LEFT OUTER JOIN GR_Group.dbo.vPerson p2 ON mt.idPsCommand = p2.idPs " & _
                                    "LEFT OUTER JOIN PchInvAndProject.dbo.vSupplier sup ON mt.idSup=sup.idSup " & _
                                    "LEFT OUTER JOIN GR_Group.dbo.vCustomer cus ON mt.idCus=cus.idCus Where " & vWhere & " Order By cus.CusName_"
            sAdapter.Fill(GiftDt)

            If GiftDt.Rows.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูลสำหรับการแสดงรายงาน", sSystemName)
                Exit Sub
            End If

            'GiftDt.Columns.Add("InvName_", System.Type.GetType("System.String"))
            'GiftDt.Columns.Add("UnitName", System.Type.GetType("System.String"))

            For i As Integer = 0 To GiftDt.Rows.Count - 1
                GiftDt.Rows(i).Item("DateGift") = ksbStringToDate(GiftDt.Rows(i).Item("DateGift"))

                'mdCnOpen2()
                ''--- get GiftName & UnitName
                'Dim dt As New DataTable
                'dt.Clear()
                'sCommand.CommandText = "Select InvName_,UnitName FROM vInventory WHERE idInv = '" & GiftDt.Rows(i).Item("idInv") & "'"
                'sAdapter.Fill(dt)
                'GiftDt.Rows(i).Item("InvName_") = dt.Rows(0).Item("InvName_")
                'GiftDt.Rows(i).Item("UnitName") = dt.Rows(0).Item("UnitName")
            Next


            Dim vFrm As New frmReportView
            Dim vRpt As New crpMkGiftCus
            vRpt.SetDataSource(GiftDt)

            Dim para_DateS As String = ""
            If Me.rdbDate.Checked = True Then
                para_DateS = "ระหว่างวันที่ " & dtpSaleS.Value.ToShortDateString & " ถึง " & dtpSaleE.Value.ToShortDateString
            ElseIf Me.rdbMonth.Checked = True Then
                para_DateS = "เดือน " & Me.cmbMonth.Text & " ปี พ.ศ. " & Me.cmbMY.Text
            ElseIf Me.rdbYear.Checked = True Then
                para_DateS = "ปี พ.ศ. " & Me.cmbYear.Text
            End If

            vRpt.SetParameterValue(vRpt.Parameter_DateS.ParameterFieldName, para_DateS)
            vRpt.SetParameterValue(vRpt.Parameter_GroupType.ParameterFieldName, "แบบจัดกลุ่มตามลูกค้า")
            vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
            vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, sPsName)
            ' vFrm.CrystalReportViewer1.ReportSource = vRpt
            ' vFrm.Show()
            mdRptShow(vRpt)
            mdLoadCommitt()
        ElseIf Me.rdbSupp.Checked = True Then
            '---- by Supplier ---'
            mdLoadShow()
            vWhere = vWhere & " AND mt.idCus is Null"

            Dim GiftDt As New DataTable
            GiftDt.Clear()
            mdCnOpen()
            sCommand.CommandText = "Select mt.idGift, mt.idCus, mt.idSup, sup.SupName as CusName_, dt.idInv, dt.Amount, " & _
                                    "mt.DateGift, cd.idGC, cd.Cause, mt.idPsCommand, mt.idPsGift, Inv.InvName_, Inv.UnitName, " & _
                                    "p1.PsName as PsGift,  p2.PsName as PsCommand From GR_Group.dbo.MkGiftCusMt mt " & _
                                    "INNER JOIN GR_Group.dbo.vPerson p1 ON mt.idPsGift = p1.idPs " & _
                                    "INNER JOIN GR_Group.dbo.MkGiftCusDt dt ON dt.idGift = mt.idGift " & _
                                    "INNER JOIN GR_Group.dbo.MkGiftCauseD cd ON cd.idGC = mt.idGC " & _
                                    "INNER JOIN PchInvAndProject.dbo.vInventory Inv ON dt.idInv = Inv.idInv " & _
                                    "LEFT OUTER JOIN GR_Group.dbo.vPerson p2 ON mt.idPsCommand = p2.idPs " & _
                                    "LEFT OUTER JOIN PchInvAndProject.dbo.vSupplier sup ON mt.idSup=sup.idSup " & _
                                    "LEFT OUTER JOIN GR_Group.dbo.vCustomer cus ON mt.idCus=cus.idCus Where " & vWhere & " Order By cus.CusName_"
            sAdapter.Fill(GiftDt)

            If GiftDt.Rows.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูลสำหรับการแสดงรายงาน", sSystemName)
                Exit Sub
            End If

            'GiftDt.Columns.Add("InvName_", System.Type.GetType("System.String"))
            'GiftDt.Columns.Add("UnitName", System.Type.GetType("System.String"))

            For i As Integer = 0 To GiftDt.Rows.Count - 1
                GiftDt.Rows(i).Item("DateGift") = ksbStringToDate(GiftDt.Rows(i).Item("DateGift"))

                'mdCnOpen2()
                ''--- get GiftName & UnitName
                'Dim dt As New DataTable
                'dt.Clear()
                'sCommand.CommandText = "Select InvName_,UnitName FROM vInventory WHERE idInv = '" & GiftDt.Rows(i).Item("idInv") & "'"
                'sAdapter.Fill(dt)
                'GiftDt.Rows(i).Item("InvName_") = dt.Rows(0).Item("InvName_")
                'GiftDt.Rows(i).Item("UnitName") = dt.Rows(0).Item("UnitName")
            Next


            Dim vFrm As New frmReportView
            Dim vRpt As New crpMkGiftCus
            vRpt.SetDataSource(GiftDt)

            Dim para_DateS As String = ""
            If Me.rdbDate.Checked = True Then
                para_DateS = "ระหว่างวันที่ " & dtpSaleS.Value.ToShortDateString & " ถึง " & dtpSaleE.Value.ToShortDateString
            ElseIf Me.rdbMonth.Checked = True Then
                para_DateS = "เดือน " & Me.cmbMonth.Text & " ปี พ.ศ. " & Me.cmbMY.Text
            ElseIf Me.rdbYear.Checked = True Then
                para_DateS = "ปี พ.ศ. " & Me.cmbYear.Text
            End If

            vRpt.SetParameterValue(vRpt.Parameter_DateS.ParameterFieldName, para_DateS)
            vRpt.SetParameterValue(vRpt.Parameter_GroupType.ParameterFieldName, "แบบจัดกลุ่มตาม Supplier")
            vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
            vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, sPsName)
           mdRptShow(vRpt)
            mdLoadCommitt()

        ElseIf Me.rdbGift.Checked = True Then
            '---- by Gift ---'
            mdLoadShow()
            If Me.rdbCusSelect.Checked = True Then
                vWhere = vWhere & " AND mt.idSup is Null"
            ElseIf Me.rdbSupSelect.Checked = True Then
                vWhere = vWhere & " AND mt.idCus is Null"
            End If


            Dim GiftDt As New DataTable
            GiftDt.Clear()
            mdCnOpen()
            sCommand.CommandText = "Select mt.idGift, mt.idCus, cus.CusName_, mt.idSup, sup.SupName, dt.idInv, dt.Amount, " & _
                                    "mt.DateGift, cd.idGC, cd.Cause, mt.idPsCommand, mt.idPsGift, Inv.InvName_, Inv.UnitName, " & _
                                    "p1.PsName as PsGift,  p2.PsName as PsCommand From MkGiftCusMt mt " & _
                                    "INNER JOIN GR_Group.dbo.vPerson p1 ON mt.idPsGift = p1.idPs " & _
                                    "INNER JOIN GR_Group.dbo.MkGiftCusDt dt ON dt.idGift = mt.idGift " & _
                                    "INNER JOIN GR_Group.dbo.MkGiftCauseD cd ON cd.idGC = mt.idGC " & _
                                    "INNER JOIN PchInvAndProject.dbo.vInventory Inv ON dt.idInv = Inv.idInv " & _
                                    "LEFT OUTER JOIN GR_Group.dbo.vPerson p2 ON mt.idPsCommand = p2.idPs " & _
                                    "LEFT OUTER JOIN PchInvAndProject.dbo.vSupplier sup ON mt.idSup=sup.idSup " & _
                                    "LEFT OUTER JOIN GR_Group.dbo.vCustomer cus ON mt.idCus=cus.idCus Where " & vWhere & " Order By cus.CusName_"
            sAdapter.Fill(GiftDt)

            If GiftDt.Rows.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูลสำหรับการแสดงรายงาน", sSystemName)
                Exit Sub
            End If

            'GiftDt.Columns.Add("InvName_", System.Type.GetType("System.String"))
            'GiftDt.Columns.Add("UnitName", System.Type.GetType("System.String"))

            For i As Integer = 0 To GiftDt.Rows.Count - 1
                GiftDt.Rows(i).Item("DateGift") = ksbStringToDate(GiftDt.Rows(i).Item("DateGift"))
                If IsDBNull(GiftDt.Rows(i).Item("idCus")) = True Then
                    GiftDt.Rows(i).Item("CusName_") = GiftDt.Rows(i).Item("SupName")
                ElseIf IsDBNull(GiftDt.Rows(i).Item("idSup")) = True Then
                    GiftDt.Rows(i).Item("CusName_") = GiftDt.Rows(i).Item("CusName_")
                End If

                'mdCnOpen2()
                ''--- get GiftName & UnitName
                'Dim dt As New DataTable
                'dt.Clear()
                'sCommand.CommandText = "Select InvName_,UnitName FROM vInventory WHERE idInv = '" & GiftDt.Rows(i).Item("idInv") & "'"
                'sAdapter.Fill(dt)
                'GiftDt.Rows(i).Item("InvName_") = dt.Rows(0).Item("InvName_")
                'GiftDt.Rows(i).Item("UnitName") = dt.Rows(0).Item("UnitName")
            Next


            Dim vFrm As New frmReportView
            Dim vRpt As New crpMkGiftInv
            vRpt.SetDataSource(GiftDt)

            Dim para_DateS As String = ""
            If Me.rdbDate.Checked = True Then
                para_DateS = "ระหว่างวันที่ " & dtpSaleS.Value.ToShortDateString & " ถึง " & dtpSaleE.Value.ToShortDateString
            ElseIf Me.rdbMonth.Checked = True Then
                para_DateS = "เดือน " & Me.cmbMonth.Text & " ปี พ.ศ. " & Me.cmbMY.Text
            ElseIf Me.rdbYear.Checked = True Then
                para_DateS = "ปี พ.ศ. " & Me.cmbYear.Text
            End If

            vRpt.SetParameterValue(vRpt.Parameter_DateS.ParameterFieldName, para_DateS)
            vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
            vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, sPsName)
            If Me.rdbAll.Checked = True Then
                vRpt.SetParameterValue(vRpt.Parameter_GroupType.ParameterFieldName, "แบบจัดกลุ่มตามสิ่งของ / ทั้งหมด")
            ElseIf Me.rdbCusSelect.Checked = True Then
                vRpt.SetParameterValue(vRpt.Parameter_GroupType.ParameterFieldName, "แบบจัดกลุ่มตามสิ่งของ / เฉพาะลูกค้า")
            ElseIf Me.rdbSupSelect.Checked = True Then
                vRpt.SetParameterValue(vRpt.Parameter_GroupType.ParameterFieldName, "แบบจัดกลุ่มตามสิ่งของ / เฉพาะ Supplier")
            End If
           mdRptShow(vRpt)
            mdLoadCommitt()
        ElseIf Me.rdbObject.Checked = True Then
            '--- By GiftCuse --- '
            mdLoadShow()

            If Me.rdbCusSelect.Checked = True Then
                vWhere = vWhere & " AND mt.idSup is Null"
            ElseIf Me.rdbSupSelect.Checked = True Then
                vWhere = vWhere & " AND mt.idCus is Null"
            End If

            Dim GiftDt As New DataTable
            GiftDt.Clear()
            mdCnOpen()
            sCommand.CommandText = "Select mt.idGift, mt.idCus, cus.CusName_, mt.idSup, sup.SupName, dt.idInv, dt.Amount, " & _
                                   "mt.DateGift, cd.idGC, cd.Cause, mt.idPsCommand, mt.idPsGift, Inv.InvName_, Inv.UnitName, " & _
                                   "p1.PsName as PsGift,  p2.PsName as PsCommand From MkGiftCusMt mt " & _
                                   "INNER JOIN GR_Group.dbo.vPerson p1 ON mt.idPsGift = p1.idPs " & _
                                   "INNER JOIN GR_Group.dbo.MkGiftCusDt dt ON dt.idGift = mt.idGift " & _
                                   "INNER JOIN GR_Group.dbo.MkGiftCauseD cd ON cd.idGC = mt.idGC " & _
                                   "INNER JOIN PchInvAndProject.dbo.vInventory Inv ON dt.idInv = Inv.idInv " & _
                                   "LEFT OUTER JOIN GR_Group.dbo.vPerson p2 ON mt.idPsCommand = p2.idPs " & _
                                   "LEFT OUTER JOIN PchInvAndProject.dbo.vSupplier sup ON mt.idSup=sup.idSup " & _
                                   "LEFT OUTER JOIN GR_Group.dbo.vCustomer cus ON mt.idCus=cus.idCus Where " & vWhere & " Order By mt.DateGift, cus.CusName_"
            sAdapter.Fill(GiftDt)

            If GiftDt.Rows.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูลสำหรับการแสดงรายงาน", sSystemName)
                Exit Sub
            End If
          
            For i As Integer = 0 To GiftDt.Rows.Count - 1
                GiftDt.Rows(i).Item("DateGift") = ksbStringToDate(GiftDt.Rows(i).Item("DateGift"))
                If IsDBNull(GiftDt.Rows(i).Item("idCus")) = True Then
                    GiftDt.Rows(i).Item("CusName_") = GiftDt.Rows(i).Item("SupName")
                ElseIf IsDBNull(GiftDt.Rows(i).Item("idSup")) = True Then
                    GiftDt.Rows(i).Item("CusName_") = GiftDt.Rows(i).Item("CusName_")
                End If
            Next


            Dim vFrm As New frmReportView
            Dim vRpt As New crpMkGiftCause
            vRpt.SetDataSource(GiftDt)

            Dim para_DateS As String = ""
            If Me.rdbDate.Checked = True Then
                para_DateS = "ระหว่างวันที่ " & dtpSaleS.Value.ToShortDateString & " ถึง " & dtpSaleE.Value.ToShortDateString
            ElseIf Me.rdbMonth.Checked = True Then
                para_DateS = "เดือน " & Me.cmbMonth.Text & " ปี พ.ศ. " & Me.cmbMY.Text
            ElseIf Me.rdbYear.Checked = True Then
                para_DateS = "ปี พ.ศ. " & Me.cmbYear.Text
            End If

            vRpt.SetParameterValue(vRpt.Parameter_DateS.ParameterFieldName, para_DateS)
            vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
            If Me.rdbAll.Checked = True Then
                vRpt.SetParameterValue(vRpt.Parameter_GroupType.ParameterFieldName, "แบบจัดกลุ่มตามสิ่งของ / ทั้งหมด")
            ElseIf Me.rdbCusSelect.Checked = True Then
                vRpt.SetParameterValue(vRpt.Parameter_GroupType.ParameterFieldName, "แบบจัดกลุ่มตามสิ่งของ / เฉพาะลูกค้า")
            ElseIf Me.rdbSupSelect.Checked = True Then
                vRpt.SetParameterValue(vRpt.Parameter_GroupType.ParameterFieldName, "แบบจัดกลุ่มตามสิ่งของ / เฉพาะ Supplier")
            End If
            vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, sPsName)
              mdRptShow(vRpt)
            mdLoadCommitt()
        End If

    End Sub

    Private Sub rdbGift_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbGift.CheckedChanged
        If Me.rdbGift.Checked = True Then
            Me.GroupBox1.Enabled = True
        Else
            Me.GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub rdbObject_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbObject.CheckedChanged
        If Me.rdbObject.Checked = True Then
            Me.GroupBox1.Enabled = True
        Else
            Me.GroupBox1.Enabled = False
        End If
    End Sub
End Class