Public Class frmInvMovePdPkShowData
    Private idUpdateView As String
    Private isView As Boolean = False

    Public Sub viewUpdate(ByVal idUpdate As String)
        isView = True
        idUpdateView = idUpdate

        GroupBox2.Enabled = False
    End Sub

    Private Sub bindData()
        Dim sDt, sDt1 As New DataTable
        Dim ds As New DataSet

        Dim where As String = " Where 1=1 "

        If chkCmdName.Checked Then
            where &= "AND  idPsCommand = '" & txtPsCmd.Tag & "' "
        End If

        If chkActName.Checked Then
            where &= "AND  idPsAction = '" & txtPsAct.Tag & "' "
        End If

        If chkTsName.Checked Then
            where &= "AND  idPsTs = '" & txtPsTs.Tag & "' "
        End If

        If chkOldInv.Checked Then
            where &= "AND  idWhOld = '" & cbOldInv.SelectedValue & "' "
        End If

        If chkNewInv.Checked Then
            where &= "AND  idWhNew = '" & cbNewInv.SelectedValue & "' "
        End If

        If chkLotNum.Checked And txtLotNum.Text <> "" Then
            where &= "AND lot.LotNum LIKE '%" & txtLotNum.Text & "%' "
        End If

        If chkPdName.Checked And txtPdName.Text <> "" Then
            where &= "AND lot.PdPkName LIKE '%" & txtPdName.Text & "%' "
        End If

        If chkDate.Checked Then
            If rdbDate.Checked Then
                If fromDate.Value > toDate.Value Then
                    MessageBox.Show("กรุณาเลือก วันที่สุดท้ายมากกว่าหรืเท่ากับ วันที่เริ่มต้น")
                Else
                    Dim firstDate As String = ksbDateToString(fromDate.Value.ToShortDateString)
                    Dim lastDate As String = ksbDateToString(toDate.Value.ToShortDateString)

                    where &= "AND cast(mt.DateTs as integer) between " & firstDate & " and " & lastDate & " "
                End If
            ElseIf rdbMonth.Checked Then
                Dim firstDateMonth As Integer = ksbDateToString(monthDate.Value.ToShortDateString)
                Dim test As String = monthDate.Value.Month
                firstDateMonth = (firstDateMonth \ 100) * 100 + 1

                Dim lastDateMonth As Integer = firstDateMonth + 30

                where &= "AND cast(mt.DateTs as integer) between " & firstDateMonth & " and " & lastDateMonth & " "
            ElseIf rdbYear.Checked Then
                Dim firstMonthYear As Integer = ksbDateToString(yearDate.Value.ToShortDateString)
                firstMonthYear = (firstMonthYear \ 10000) * 10000 + 101

                Dim lastMonthYear = firstMonthYear + 1130

                where &= "AND cast(mt.DateTs as integer) between " & firstMonthYear & " and " & lastMonthYear & " "
            End If
        End If

        If isView Then
            where &= "AND mt.idUPdate=" & idUpdateView & " "
        End If

        mdCnOpen()
        mdLoadShow()

        Dim get_cmd_name As String = "(SELECT PsName FROM vPerson WHERE idPs = idPsCommand) AS cmdName "
        Dim get_act_name As String = "(SELECT PsName FROM vPerson WHERE idPs = idPsAction) AS actName "
        Dim get_ts_name As String = "(SELECT PsName FROM vPerson WHERE idPs = idPsTs) AS tsName "

        sCommand.CommandText = "SELECT DISTINCT  mt.idUpdate,devsk.fncStrDateToDateTime(mt.DateTs) AS DateTs,DocCode,mt.note," &
                                get_cmd_name & "," & get_act_name & "," & get_ts_name &
                                "FROM SsWarehouseMoveProductMt as mt " &
                                "INNER JOIN SsWarehouseMoveProductDt as dt ON mt.idUpdate = dt.idUpdate " &
                                "LEFT JOIN vPackingPdSetLot AS lot ON lot.idPdPkLot = dt.idPdPkLot " &
                                where
        sAdapter.Fill(sDt)

        Dim get_new_inv_name As String = "(SELECT WareHouseName FROM SsWarehouse WHERE idWh = idWhNew) AS newWhName "
        Dim get_old_inv_name As String = "(SELECT WareHouseName FROM SsWarehouse WHERE idWh = idWhOld) AS oldWhName "

        sCommand.CommandText = "SELECT mt.idUpdate,dt.Amount,dt.note,lot.PdPkName,lot.LotNum,lot.PkUnitName," &
                                get_new_inv_name & "," & get_old_inv_name & "," & get_cmd_name & "," & get_act_name & "," & get_ts_name &
                                "FROM SsWarehouseMoveProductMt as mt " &
                                "INNER JOIN SsWarehouseMoveProductDt as dt ON mt.idUpdate = dt.idUpdate " &
                                "LEFT JOIN vPackingPdSetLot AS lot ON lot.idPdPkLot = dt.idPdPkLot " &
                                where
        sAdapter.Fill(sDt1)

        ds.Tables.Clear()
        ds.Tables.Add(sDt)
        ds.Tables.Add(sDt1)

        Dim keyColumn As DataColumn = ds.Tables(0).Columns("idUpdate")
        Dim foreignColumn As DataColumn = ds.Tables(1).Columns("idUpdate")
        ds.Relations.Add("ข้อมูลการย้ายคลัง", keyColumn, foreignColumn)
        showDataList.DataSource = ds.Tables(0)
        showDataList.ForceInitialize()

        showDataList.LevelTree.Nodes.Add("ข้อมูลการย้ายคลัง", dgvLvl1)

        mdLoadCommitt()
    End Sub

    Private Sub frmInvMovePdPkShowData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bindData()
        fromDate.Value = Date.Today
        toDate.Value = Date.Today
        monthDate.Value = Date.Today
        yearDate.Value = Date.Today
    End Sub

    Private Sub chkCmdName_CheckedChanged(sender As Object, e As EventArgs) Handles chkCmdName.CheckedChanged
        btnPsCmd.Enabled = chkCmdName.Checked
    End Sub

    Private Sub chkActName_CheckedChanged(sender As Object, e As EventArgs) Handles chkActName.CheckedChanged
        btnPsAct.Enabled = chkActName.Checked
    End Sub

    Private Sub chkTsName_CheckedChanged(sender As Object, e As EventArgs) Handles chkTsName.CheckedChanged
        btnPsTs.Enabled = chkTsName.Checked
    End Sub

    Private Sub btnSFindAll_Click(sender As Object, e As EventArgs) Handles btnSFindAll.Click
        bindData()
    End Sub

    Private Sub getInvList(sender As Object)
        Dim ds As New DataTable

        mdCnOpen()

        sCommand.CommandText = "SELECT WareHouseName,idWh FROM SsWarehouse WHERE stWh='0' ORDER BY WareHouseName"
        sAdapter.Fill(ds)

        If ds.Rows.Count > 0 Then
            With sender
                .DisplayMember = "WareHouseName"
                .ValueMember = "idWh"
                .DataSource = ds
            End With
        End If
    End Sub

    Private Sub chkOldInv_CheckedChanged(sender As Object, e As EventArgs) Handles chkOldInv.CheckedChanged
        cbOldInv.Enabled = chkOldInv.Checked
        If chkOldInv.Checked And cbOldInv.Items.Count = 0 Then
            getInvList(cbOldInv)
        End If
    End Sub

    Private Sub chkNewInv_CheckedChanged(sender As Object, e As EventArgs) Handles chkNewInv.CheckedChanged
        cbNewInv.Enabled = chkNewInv.Checked
        If chkNewInv.Checked And cbNewInv.Items.Count = 0 Then
            getInvList(cbNewInv)
        End If
    End Sub

    Private Sub chkLotNum_CheckedChanged(sender As Object, e As EventArgs) Handles chkLotNum.CheckedChanged
        txtLotNum.Enabled = chkLotNum.Checked
    End Sub

    Private Sub chkPdName_CheckedChanged(sender As Object, e As EventArgs) Handles chkPdName.CheckedChanged
        txtPdName.Enabled = chkPdName.Checked
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkDate.CheckedChanged
        gbDate.Enabled = chkDate.Checked
    End Sub

    Private Sub rdbDate_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDate.CheckedChanged
        fromDate.Enabled = rdbDate.Checked
        toDate.Enabled = rdbDate.Checked
    End Sub

    Private Sub rdbMonth_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMonth.CheckedChanged
        monthDate.Enabled = rdbMonth.Checked
    End Sub

    Private Sub rdbYear_CheckedChanged(sender As Object, e As EventArgs) Handles rdbYear.CheckedChanged
        yearDate.Enabled = rdbYear.Checked
    End Sub

    Private Sub choose_ps(sender As Object)
        Dim frm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            sender.Text = frm.mName
            sender.Tag = frm.mId
        End If
    End Sub

    Private Sub btnPsCmd_Click(sender As Object, e As EventArgs) Handles btnPsCmd.Click
        choose_ps(txtPsCmd)
    End Sub

    Private Sub btnPsAct_Click(sender As Object, e As EventArgs) Handles btnPsAct.Click
        choose_ps(txtPsAct)
    End Sub

    Private Sub btnPsTs_Click(sender As Object, e As EventArgs) Handles btnPsTs.Click
        choose_ps(txtPsTs)
    End Sub
End Class