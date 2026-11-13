Public Class frmPdPkPriceData

    Private Sub btnSFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSFindAll.Click
        showDataOnGrid()

    End Sub
    Private Sub showDataOnGrid()
        mdCnOpen()
        Dim vWhere As String = ""
        Dim sDt As New DataTable
        If RdSMonth.Checked = True Then
            vWhere = " Where MONTH(DateTs) = MONTH('" & ksbDateToString(DayOfMonth.Value.ToShortDateString) & "') "

        ElseIf RdSDay.Checked = True Then
            vWhere = " Where DateTs Between '" & ksbDateToString(dtpDateS.Value.ToShortDateString) & "' And '" & ksbDateToString(dtpDateE.Value.ToShortDateString) & "' "

        End If
        If CbSPdName.Checked = True Then
            vWhere += " And PdTradeName LIKE '%" & txtSPdName.Text & "%' "

        End If
          sCommand.CommandText = "Select 0 As Num,PdTradeName,PriceRetail_Old,PriceBill_Old,PriceWholeSale_Old,PriceRetail_New,PriceBill_New,PriceWholeSale_New,DateTs,PsSet,PsTs,Note From vSmPkPriceTs" & vWhere
        sAdapter.Fill(sDt)
        dgvData.DataSource = sDt
        ksbCountRowDgv(dgvData, colNum.Name)
        For i As Integer = 0 To sDt.Rows.Count - 1
            Me.dgvData.Rows(i).Cells("colDateTs").Value = ksbStringToDate(Me.dgvData.Rows(i).Cells("colDateTs").Value)
        Next
        ' ksbDgvConvertDateFormat(dgvData, colDateTs.Name)
    End Sub

    Private Sub dgvData_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        
    End Sub


    Private Sub txtSPdName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSPdName.KeyDown
        If e.KeyCode = Keys.Enter Then
            showDataOnGrid()
        End If
    End Sub

    Private Sub RdSMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdSMonth.CheckedChanged
        dtpDateS.Enabled = False
        dtpDateE.Enabled = False
        DayOfMonth.Enabled = True
    End Sub

    Private Sub RdSDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdSDay.CheckedChanged
        dtpDateS.Enabled = True
        dtpDateE.Enabled = True
        DayOfMonth.Enabled = False
    End Sub

    Private Sub CbSPdName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbSPdName.CheckedChanged
        If CbSPdName.Checked = True Then
            txtSPdName.Enabled = True
        Else
            txtSPdName.Text = ""
            txtSPdName.Enabled = False
        End If

    End Sub
End Class