Public Class frmPsSaleSummaryPerson

    Private Sub frmPssSaleSummaryMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpMonthS.Value = Date.Today
        Me.dtpMonthE.Value = Date.Today

        BindPsSale()
    End Sub

    Private Sub BindPsSale()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT Distinct idPsSale, PsSale FROM vSmSaleMt WHERE idPsCancel IS NULL " & _
                               "AND idComp = " & sIdComp & " ORDER By PsSale"
        sAdapter.Fill(sDt)

        With cmbPsSale
            .DisplayMember = "PsSale"
            .ValueMember = "idPsSale"
            .DataSource = sDt
        End With
    End Sub

    Private Sub btnSchPd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchPd.Click
        mdLoadShow()
        BindData()
        SumTotal()
        mdLoadCommitt()
    End Sub

    Private Sub BindData()
        Dim YearMonthS As String = ""
        Dim YearMonthE As String = ""

        If Me.dtpMonthS.Value.Month.ToString.Length = 1 Then
            YearMonthS = Microsoft.VisualBasic.Right(Me.dtpMonthS.Text, 4) & "0" & Me.dtpMonthS.Value.Month
        ElseIf Me.dtpMonthS.Value.Month.ToString.Length = 2 Then
            YearMonthS = Microsoft.VisualBasic.Right(Me.dtpMonthS.Text, 4) & Me.dtpMonthS.Value.Month
        End If


        If Me.dtpMonthE.Value.Month.ToString.Length = 1 Then
            YearMonthE = Microsoft.VisualBasic.Right(Me.dtpMonthE.Text, 4) & "0" & Me.dtpMonthE.Value.Month
        ElseIf Me.dtpMonthE.Value.Month.ToString.Length = 2 Then
            YearMonthE = Microsoft.VisualBasic.Right(Me.dtpMonthE.Text, 4) & Me.dtpMonthE.Value.Month
        End If

        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT mt.idCus, mt.CusName, c.Address, SUM(mt.TotalNet) AS TotalSale " & _
                               "FROM vSmSaleMt mt LEFT OUTER JOIN vCustomer c ON mt.idCus = c.idCus " & _
                               "WHERE mt.idPsCancel IS NULL AND mt.idComp = " & sIdComp & " " & _
                               "AND mt.idPsSale = " & Me.cmbPsSale.SelectedValue & " AND " & _
                               "SUBSTRING(mt.DateSale,1,6) Between '" & YearMonthS & "' And '" & YearMonthE & "' " & _
                               "GROUP BY mt.idCus, mt.CusName, c.Address ORDER BY TotalSale DESC"
        sAdapter.Fill(sDt)
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลลูกค้าที่ผูกกับเจ้าหน้าที่ขายนี้", sSystemName)
            dgvCus.DataSource = sDt
            Exit Sub
        Else
            dgvCus.DataSource = sDt
            ksbCountRowDgv(dgvCus, ColNum.Name)
        End If

    End Sub

    Sub SumTotal()
        Dim TotalNet As Double = 0.0
        For i As Integer = 0 To dgvCus.Rows.Count - 1
            TotalNet += dgvCus.Rows(i).Cells("ColTotalSale").Value
        Next
        txtTotalNet.Text = Format(TotalNet, "#,##0.00")
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        mdLoadShow()
        Dim YearMonthS As String = ""
        Dim YearMonthE As String = ""

        If Me.dtpMonthS.Value.Month.ToString.Length = 1 Then
            YearMonthS = Microsoft.VisualBasic.Right(Me.dtpMonthS.Text, 4) & "0" & Me.dtpMonthS.Value.Month
        ElseIf Me.dtpMonthS.Value.Month.ToString.Length = 2 Then
            YearMonthS = Microsoft.VisualBasic.Right(Me.dtpMonthS.Text, 4) & Me.dtpMonthS.Value.Month
        End If


        If Me.dtpMonthE.Value.Month.ToString.Length = 1 Then
            YearMonthE = Microsoft.VisualBasic.Right(Me.dtpMonthE.Text, 4) & "0" & Me.dtpMonthE.Value.Month
        ElseIf Me.dtpMonthE.Value.Month.ToString.Length = 2 Then
            YearMonthE = Microsoft.VisualBasic.Right(Me.dtpMonthE.Text, 4) & Me.dtpMonthE.Value.Month
        End If

        Dim vTitleDate As String = Me.dtpMonthS.Text & " - " & Me.dtpMonthE.Text
        Dim PsSaleSum As New DataTable
        PsSaleSum.Clear()
        mdCnOpen()

        sCommand.CommandText = "SELECT mt.idCus, mt.CusName, c.Address, SUM(mt.TotalNet) AS TotalSale " & _
                               "FROM vSmSaleMt mt LEFT OUTER JOIN vCustomer c ON mt.idCus = c.idCus " & _
                               "WHERE mt.idPsCancel IS NULL AND mt.idComp = " & sIdComp & " " & _
                               "AND mt.idPsSale = " & Me.cmbPsSale.SelectedValue & " AND " & _
                               "SUBSTRING(mt.DateSale,1,6) Between '" & YearMonthS & "' And '" & YearMonthE & "' " & _
                               "GROUP BY mt.idCus, mt.CusName, c.Address ORDER BY TotalSale DESC"

        sAdapter.Fill(PsSaleSum)

        If PsSaleSum.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่มีข้อมูลรายงานของเจ้าหน้าที่ขายรายบุคคลนี้", sSystemName)
            PsSaleSum.Clear()
            Exit Sub
        Else
            Dim vFrm As New frmReportView
            Dim vRpt As New CrpPsSaleSummaryPerson
            vRpt.SetDataSource(PsSaleSum)
            vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
            vRpt.SetParameterValue(vRpt.Parameter_DateS.ParameterFieldName, vTitleDate)
            vRpt.SetParameterValue(vRpt.Parameter_ptPsSale.ParameterFieldName, Me.cmbPsSale.Text)
            ' vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, "ผู้สั่งพิมพ์เอกสาร : " & sPsName)

            vFrm.crView.ReportSource = vRpt
            vFrm.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            vFrm.Show()
        End If
        mdLoadCommitt()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class