Public Class frmSlSaleAmountSummary
    Dim lastYear As Integer
    Dim stload As Integer = 0

    Private Sub frmSlSaleAmountSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        Me.dtpYear.Value = Date.Today
        'Me.TabControl1.SelectedIndex = 2
        'Me.TabControl1.SelectedIndex = 0

        'Main'
        '****** This year ******'
        lastYear = Me.dtpYear.Text - 1

        Dim vDt As New DataTable
        vDt.Clear()
        mdCnOpen()

        sCommand.CommandText = "SELECT SUM(SumThisY) AS SumThisY FROM (SELECT  SUM(d.Weight * d.Amount) AS SumThisY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND " & _
                               "(m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') UNION " & _
                               "SELECT SUM(d.Weight * d.Amount / 1000) AS SumThisY FROM SmSaleMt AS m " & _
                               "INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) AND " & _
                               "(m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) " & _
                               "AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "')) AS result"
        sAdapter.Fill(vDt)
        Me.txtSumthisY.Text = Format(vDt.Rows(0).Item("SumThisY"), "#,##0.00")

        '****** Last year ******'
        vDt.Clear()
        sCommand.CommandText = "SELECT SUM(SumThisY) AS SumThisY FROM (SELECT  SUM(d.Weight * d.Amount) AS SumThisY " & _
                              "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                              "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND " & _
                              "(m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                              "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') UNION " & _
                              "SELECT SUM(d.Weight * d.Amount / 1000) AS SumThisY FROM SmSaleMt AS m " & _
                              "INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                              "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) AND " & _
                              "(m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) " & _
                              "AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "')) AS result"
        sAdapter.Fill(vDt)
        Me.txtSumLastY.Text = Format(vDt.Rows(0).Item("SumThisY"), "#,##0.00")

        '****** Cal  % เติบโต *****'
        If CDbl(Me.txtSumLastY.Text) = 0.0 Then
            Me.txtGrowUp.Text = "0.00"
        Else
            Me.txtGrowUp.Text = Format(((CDbl(Me.txtSumthisY.Text) - CDbl(Me.txtSumLastY.Text)) / CDbl(Me.txtSumLastY.Text)) * 100, "#,##0.00")
        End If

        BindUnit()
        SummaryPlant()
        SummaryPdT()
        SummaryPdPk()
        BindPsSale()
        BindCustomer()
        stload = 1

        mdLoadCommitt()
    End Sub

    Private Sub BindUnit()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT idPkUnit, PkUnitName FROM dPackingUnit WHERE idPkUnit <> 7 " & _
                               "AND idPkUnit <> 5 AND idPkUnit <> 3"
        sAdapter.Fill(sDt)

        With CmbUnit
            .DisplayMember = "PkUnitName"
            .ValueMember = "idPkUnit"
            .DataSource = sDt
            '.SelectedValue = 1
        End With
    End Sub

    Private Sub BindPkDetail()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT idPkDetail, SizeName FROM dPackingDetail WHERE idPkUnit = " & CmbUnit.SelectedValue & ""
        sAdapter.Fill(sDt)

        With CmbPkDetail
            .DisplayMember = "SizeName"
            .ValueMember = "idPkDetail"
            .DataSource = sDt
        End With
    End Sub

    Private Sub CmbUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbUnit.SelectedIndexChanged
        BindPkDetail()
        'mdLoadShow()
        'lastYear = Me.dtpYear.Text - 1
        'If Me.rdbKg.Checked = True Then
        '    SummaryPdPk()
        'Else
        '    SummaryPdPkUnit()
        'End If
        'mdLoadCommitt()
    End Sub

    'Private Sub CmbUnit_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbUnit.SelectedValueChanged
    '    BindPkDetail()
    'End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        mdLoadShow()
        lastYear = Me.dtpYear.Text - 1
        SummaryPlant()
        SummaryPdT()
        If Me.rdbKg.Checked = True Then
            SummaryPdPk()
        Else
            SummaryPdPkUnit()
        End If
        BindPsSale()
        BindCustomer()
        mdLoadCommitt()
    End Sub

    Sub SummaryPlant()
        Me.dgvPlant.Columns("ColSumYear").HeaderText = "จน.ขายปี " & Me.dtpYear.Text & " (Kg)"
        Me.dgvPlant.Columns("Coljan").HeaderText = "มกราคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColFeb").HeaderText = "กุมภาพันธ์ " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColMar").HeaderText = "มีนาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColApr").HeaderText = "เมษายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColMay").HeaderText = "พฤษภาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColJun").HeaderText = "มิถุนายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColJul").HeaderText = "กรกฎาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColAug").HeaderText = "สิงหาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColSep").HeaderText = "กันยายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColOct").HeaderText = "ตุลาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColNov").HeaderText = "พฤศจิกายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColDec").HeaderText = "ธันวาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        'Dim lastYear As Integer = Me.dtpYear.Text - 1
        Me.dgvPlant.Columns("ColLastYP").HeaderText = "จน.ขายปี " & lastYear.ToString & " (Kg)"
        Me.dgvPlant.Columns("ColJanL").HeaderText = "มกราคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColFebL").HeaderText = "กุมภาพันธ์ " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColMarL").HeaderText = "มีนาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColAprL").HeaderText = "เมษายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColMayL").HeaderText = "พฤษภาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColJunL").HeaderText = "มิถุนายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColJulL").HeaderText = "กรกฎาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColAugL").HeaderText = "สิงหาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColSepL").HeaderText = "กันยายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColOctL").HeaderText = "ตุลาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColNovL").HeaderText = "พฤศจิกายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPlant.Columns("ColDecL").HeaderText = "ธันวาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"

        Dim Dt As New DataTable
        Dt.Clear()
        mdCnOpen()
        sCommand.CommandText = "SELECT p.idPlant, p.PlantName, 0.00 As SumThisY, 0.00 As ratioP, 0.00 As GrowUpP, " & _
                               "0.00 As SumLastY, 0.00 As Jan, 0.00 As JanL, 0.00 As Feb, " & _
                               "0.00 As FebL, 0.00 As Mar, 0.00 As MarL, 0.00 As Apr, 0.00 As AprL, 0.00 As May, 0.00 As MayL, " & _
                               "0.00 As Jun, 0.00 As JunL, 0.00 As Jul, 0.00 As JulL, 0.00 As Aug, 0.00 As AugL, " & _
                               "0.00 As Sep, 0.00 As SepL, 0.00 As Oct, 0.00 As OctL, 0.00 As Nov, 0.00 As NovL, " & _
                               "0.00 As Dec, 0.00 As DecL FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE idPsCancel IS Null AND idComp = '" & sIdComp & "' " & _
                               "AND ((SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') OR " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "')) GROUP BY p.idPlant, p.PlantName"
        sAdapter.Fill(Dt)

        ''************Summary ThisYear**************'
        Dim sDtY As New DataTable
        sDtY.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(SumThisY) AS SumThisY FROM (SELECT p.idPlant, " & _
                               "SUM(d.Weight * d.Amount) AS SumThisY FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "GROUP BY p.idPlant UNION SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS SumThisY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS SumLastY FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "GROUP BY p.idPlant UNION SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS SumLastY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
            dgvPlant.DataSource = Dt
            Exit Sub
        Else
            Dt.DefaultView.Sort = "[SumThisY] DESC"
            dgvPlant.DataSource = Dt
        End If

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

            If dgvPlant.Rows(i).Cells("ColLastYP").Value = 0.0 Then
                dgvPlant.Rows(i).Cells("ColGrowUpP").Value = "0.00"
            Else
                dgvPlant.Rows(i).Cells("ColGrowUpP").Value = ((CDbl(dgvPlant.Rows(i).Cells("ColSumYear").Value) - CDbl(dgvPlant.Rows(i).Cells("ColLastYP").Value)) / CDbl(dgvPlant.Rows(i).Cells("ColLastYP").Value)) * 100

            End If
        Next

        '************Jan**************'
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPlant.Rows.Count - 1
                If dgvPlant.Rows(j).Cells("ColidPlant").Value = sDt.Rows(i).Item("idPlant") Then
                    dgvPlant.Rows(j).Cells("ColAprL").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next


        ' ************May**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPlant, SUM(Total) AS Total FROM (SELECT p.idPlant, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12') GROUP BY p.idPlant UNION " & _
                               "SELECT p.idPlant, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12')) GROUP BY p.idPlant) " & _
                               "AS result GROUP BY idPlant"
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

    Private Sub dgvPlant_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvPlant.RowPostPaint
        Me.dgvPlant("ColNumP", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Sub SummaryPdT()
        Me.dgvPdT.Columns("ColSumYearT").HeaderText = "จน.ขายปี " & Me.dtpYear.Text & " (Kg)"
        Me.dgvPdT.Columns("ColjanT").HeaderText = "มกราคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColFebT").HeaderText = "กุมภาพันธ์ " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColMarT").HeaderText = "มีนาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColAprT").HeaderText = "เมษายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColMayT").HeaderText = "พฤษภาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColJunT").HeaderText = "มิถุนายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColJulT").HeaderText = "กรกฎาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColAugT").HeaderText = "สิงหาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColSepT").HeaderText = "กันยายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColOctT").HeaderText = "ตุลาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColNovT").HeaderText = "พฤศจิกายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColDecT").HeaderText = "ธันวาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        'Dim lastYear As Integer = Me.dtpYear.Text - 1
        Me.dgvPdT.Columns("ColLastYPT").HeaderText = "จน.ขายปี " & lastYear.ToString & " (Kg)"
        Me.dgvPdT.Columns("ColJanLT").HeaderText = "มกราคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColFebLT").HeaderText = "กุมภาพันธ์ " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColMarLT").HeaderText = "มีนาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColAprLT").HeaderText = "เมษายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColMayLT").HeaderText = "พฤษภาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColJunLT").HeaderText = "มิถุนายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColJulLT").HeaderText = "กรกฎาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColAugLT").HeaderText = "สิงหาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColSepLT").HeaderText = "กันยายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColOctLT").HeaderText = "ตุลาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColNovLT").HeaderText = "พฤศจิกายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdT.Columns("ColDecLT").HeaderText = "ธันวาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"

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
                               "AND ((SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') OR " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "')) GROUP BY p.idPdT, p.PdTradeName"
        sAdapter.Fill(Dt)


        ''************Summary ThisYear**************'
        Dim sDtY As New DataTable
        sDtY.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(SumThisY) AS SumThisY FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS SumThisY FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "GROUP BY p.idPdT UNION SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS SumThisY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(SumLastY) AS SumLastY FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS SumLastY FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "GROUP BY p.idPdT UNION SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS SumLastY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12') GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12')) GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        Me.dgvPdPk.Columns("ColSumYearPk").HeaderText = "จน.ขายปี " & Me.dtpYear.Text & " (Kg)"
        Me.dgvPdPk.Columns("ColjanPk").HeaderText = "มกราคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColFebPk").HeaderText = "กุมภาพันธ์ " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColMarPk").HeaderText = "มีนาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColAprPk").HeaderText = "เมษายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColMayPk").HeaderText = "พฤษภาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColJunPk").HeaderText = "มิถุนายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColJulPk").HeaderText = "กรกฎาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColAugPk").HeaderText = "สิงหาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColSepPk").HeaderText = "กันยายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColOctPk").HeaderText = "ตุลาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColNovPk").HeaderText = "พฤศจิกายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColDecPk").HeaderText = "ธันวาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        'Dim lastYear As Integer = Me.dtpYear.Text - 1
        Me.dgvPdPk.Columns("ColLastYPPk").HeaderText = "จน.ขายปี " & lastYear.ToString & " (Kg)"
        Me.dgvPdPk.Columns("ColJanLPk").HeaderText = "มกราคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColFebLPk").HeaderText = "กุมภาพันธ์ " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColMarLPk").HeaderText = "มีนาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColAprLPk").HeaderText = "เมษายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColMayLPk").HeaderText = "พฤษภาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColJunLPk").HeaderText = "มิถุนายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColJulLPk").HeaderText = "กรกฎาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColAugLPk").HeaderText = "สิงหาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColSepLPk").HeaderText = "กันยายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColOctLPk").HeaderText = "ตุลาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColNovLPk").HeaderText = "พฤศจิกายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPdPk.Columns("ColDecLPk").HeaderText = "ธันวาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
      
        Dim vWHERE As String = ""
        If Me.ChkUnit.Checked = True Then
            vWHERE = vWHERE & " AND p.idPkUnit = " & Me.CmbUnit.SelectedValue & " "
        End If

        If Me.ChkPkDetail.Checked = True Then
            vWHERE = vWHERE & " AND p.idPkDetail = " & Me.CmbPkDetail.SelectedValue & " "
        End If

        If Me.ChkShortN.Checked = True Then
            vWHERE = vWHERE & " AND p.ShortName Like '%" & txtShortN.Text & "%' "
        End If

        mdCnOpen()
        Dim Dt As New DataTable
        Dt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, p.PdPkName, p.ShortName, 0.00 As SumThisY, 0.00 As ratioP, 0.00 As GrowUpP, " & _
                               "0.00 As SumLastY, 0.00 As Jan, 0.00 As JanL, 0.00 As Feb, " & _
                               "0.00 As FebL, 0.00 As Mar, 0.00 As MarL, 0.00 As Apr, 0.00 As AprL, 0.00 As May, 0.00 As MayL, " & _
                               "0.00 As Jun, 0.00 As JunL, 0.00 As Jul, 0.00 As JulL, 0.00 As Aug, 0.00 As AugL, " & _
                               "0.00 As Sep, 0.00 As SepL, 0.00 As Oct, 0.00 As OctL, 0.00 As Nov, 0.00 As NovL, " & _
                               "0.00 As Dec, 0.00 As DecL FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE idPsCancel IS Null AND idComp = '" & sIdComp & "' " & _
                               "AND ((SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') OR " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY p.idPdPk, p.PdPkName, p.ShortName"
        sAdapter.Fill(Dt)

        ''************Summary ThisYear**************'
        Dim sDtY As New DataTable
        sDtY.Clear()
        sCommand.CommandText = "SELECT idPdPk, SUM(SumThisY) AS SumThisY FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS SumThisY FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk " & _
                               "UNION SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS SumThisY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d " & _
                               "ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(SumLastY) AS SumLastY FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS SumLastY FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet " & _
                               "AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " " & _
                               "GROUP BY d.idPdPk UNION SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS SumLastY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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

        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01')) AND p.PdPkName Like '%" & txtPdName.Text & "%' " & _
                               "" & vWHERE & " GROUP BY d.idPdPk) AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02') AND " & _
                               "p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03')) AND p.PdPkName Like '%" & txtPdName.Text & "%' " & _
                               "" & vWHERE & " GROUP BY d.idPdPk) AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06')) " & _
                               " AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                              "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
                               "AS result GROUP BY idPdPk"
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
        sCommand.CommandText = "SELECT idPdPk, SUM(Total) AS Total FROM (SELECT d.idPdPk, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12') " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk UNION " & _
                               "SELECT d.idPdPk, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk) " & _
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

    Sub SummaryPdPkUnit()
        Me.dgvPdPk.Columns("ColSumYearPk").HeaderText = "จน.ขายปี " & Me.dtpYear.Text & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColjanPk").HeaderText = "มกราคม " & Me.dtpYear.Text.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColFebPk").HeaderText = "กุมภาพันธ์ " & Me.dtpYear.Text.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColMarPk").HeaderText = "มีนาคม " & Me.dtpYear.Text.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColAprPk").HeaderText = "เมษายน " & Me.dtpYear.Text.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColMayPk").HeaderText = "พฤษภาคม " & Me.dtpYear.Text.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColJunPk").HeaderText = "มิถุนายน " & Me.dtpYear.Text.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColJulPk").HeaderText = "กรกฎาคม " & Me.dtpYear.Text.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColAugPk").HeaderText = "สิงหาคม " & Me.dtpYear.Text.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColSepPk").HeaderText = "กันยายน " & Me.dtpYear.Text.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColOctPk").HeaderText = "ตุลาคม " & Me.dtpYear.Text.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColNovPk").HeaderText = "พฤศจิกายน " & Me.dtpYear.Text.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColDecPk").HeaderText = "ธันวาคม " & Me.dtpYear.Text.Substring(2, 2) & " (ชิ้น)"

        Me.dgvPdPk.Columns("ColLastYPPk").HeaderText = "จน.ขายปี " & lastYear.ToString & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColJanLPk").HeaderText = "มกราคม " & lastYear.ToString.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColFebLPk").HeaderText = "กุมภาพันธ์ " & lastYear.ToString.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColMarLPk").HeaderText = "มีนาคม " & lastYear.ToString.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColAprLPk").HeaderText = "เมษายน " & lastYear.ToString.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColMayLPk").HeaderText = "พฤษภาคม " & lastYear.ToString.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColJunLPk").HeaderText = "มิถุนายน " & lastYear.ToString.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColJulLPk").HeaderText = "กรกฎาคม " & lastYear.ToString.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColAugLPk").HeaderText = "สิงหาคม " & lastYear.ToString.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColSepLPk").HeaderText = "กันยายน " & lastYear.ToString.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColOctLPk").HeaderText = "ตุลาคม " & lastYear.ToString.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColNovLPk").HeaderText = "พฤศจิกายน " & lastYear.ToString.Substring(2, 2) & " (ชิ้น)"
        Me.dgvPdPk.Columns("ColDecLPk").HeaderText = "ธันวาคม " & lastYear.ToString.Substring(2, 2) & " (ชิ้น)"


        Dim vWHERE As String = ""
        If Me.ChkUnit.Checked = True Then
            vWHERE = vWHERE & " AND p.idPkUnit = " & Me.CmbUnit.SelectedValue & " "
        End If

        If Me.ChkPkDetail.Checked = True Then
            vWHERE = vWHERE & " AND p.idPkDetail = " & Me.CmbPkDetail.SelectedValue & " "
        End If

        If Me.ChkShortN.Checked = True Then
            vWHERE = vWHERE & " AND p.ShortName Like '%" & txtShortN.Text & "%' "
        End If

        mdCnOpen()
        Dim Dt As New DataTable
        Dt.Clear()
        sCommand.CommandText = "SELECT p.idPdPk, p.PdPkName, p.ShortName, 0.00 As SumThisY, 0.00 As ratioP, 0.00 As GrowUpP, " & _
                               "0.00 As SumLastY, 0.00 As Jan, 0.00 As JanL, 0.00 As Feb, " & _
                               "0.00 As FebL, 0.00 As Mar, 0.00 As MarL, 0.00 As Apr, 0.00 As AprL, 0.00 As May, 0.00 As MayL, " & _
                               "0.00 As Jun, 0.00 As JunL, 0.00 As Jul, 0.00 As JulL, 0.00 As Aug, 0.00 As AugL, " & _
                               "0.00 As Sep, 0.00 As SepL, 0.00 As Oct, 0.00 As OctL, 0.00 As Nov, 0.00 As NovL, " & _
                               "0.00 As Dec, 0.00 As DecL FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE idPsCancel IS Null AND idComp = '" & sIdComp & "' " & _
                               "AND ((SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') OR " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "')) AND " & _
                               "p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY p.idPdPk, p.PdPkName, p.ShortName"
        sAdapter.Fill(Dt)

        ''************Summary ThisYear**************'
        Dim sDtY As New DataTable
        sDtY.Clear()
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS SumThisY FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE m.idComp = '" & sIdComp & "' AND " & _
                               "m.idPsCancel IS NULL AND SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk"
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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS SumLastY FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE m.idComp = '" & sIdComp & "' AND " & _
                               "m.idPsCancel IS NULL AND SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                                "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"
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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                                "AND (SUBSTRING(m.DateSale, 5, 2) = '08')) " & _
                                "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & " GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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
        sCommand.CommandText = "SELECT d.idPdPk, SUM(d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p ON d.idPdPk = p.idPdPk " & _
                               "WHERE (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12')) " & _
                               "AND p.PdPkName Like '%" & txtPdName.Text & "%' " & vWHERE & "  GROUP BY d.idPdPk"

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

    Private Sub BindPsSale()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT idPsSale, PsSale, SUM(SumThisY) AS SumThisY, '' AS SaleName " & _
                               "FROM (SELECT m.idPsSale, m.PsSale, SUM(d.Weight * d.Amount) AS SumThisY " & _
                               "FROM vSmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "GROUP BY m.idPsSale, m.PsSale UNION SELECT m.idPsSale, m.PsSale, " & _
                               "SUM(d.Weight * d.Amount / 1000) AS SumThisY FROM vSmSaleMt AS m " & _
                               "INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) " & _
                               "AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "GROUP BY m.idPsSale, m.PsSale) AS result GROUP BY idPsSale, " & _
                               "PsSale ORDER BY SumThisY DESC"
        sAdapter.Fill(sDt)

        For i As Integer = 0 To sDt.Rows.Count - 1
            sDt.Rows(i).Item("SaleName") = sDt.Rows(i).Item("PsSale") & " : " & Format(sDt.Rows(i).Item("SumThisY"), "#,##0.00").ToString & " Kg"
        Next

        With cmbPsSale
            .DisplayMember = "SaleName"
            .ValueMember = "idPsSale"
            .DataSource = sDt
        End With
    End Sub

    Private Sub cmbPsSale_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPsSale.SelectedIndexChanged
        mdLoadShow()
        SummaryPsSale()
        Me.dgvPsSale.Focus()
        mdLoadCommitt()
    End Sub

    Sub SummaryPsSale()
        Me.dgvPsSale.Columns("ColSumYearS").HeaderText = "จน.ขายปี " & Me.dtpYear.Text & " (Kg)"
        Me.dgvPsSale.Columns("ColjanS").HeaderText = "มกราคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColFebS").HeaderText = "กุมภาพันธ์ " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColMarS").HeaderText = "มีนาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColAprS").HeaderText = "เมษายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColMayS").HeaderText = "พฤษภาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColJunS").HeaderText = "มิถุนายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColJulS").HeaderText = "กรกฎาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColAugS").HeaderText = "สิงหาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColSepS").HeaderText = "กันยายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColOctS").HeaderText = "ตุลาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColNovS").HeaderText = "พฤศจิกายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColDecS").HeaderText = "ธันวาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        'Dim lastYear As Integer = Me.dtpYear.Text - 1
        Me.dgvPsSale.Columns("ColLastYPS").HeaderText = "จน.ขายปี " & lastYear.ToString & " (Kg)"
        Me.dgvPsSale.Columns("ColJanLS").HeaderText = "มกราคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColFebLS").HeaderText = "กุมภาพันธ์ " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColMarLS").HeaderText = "มีนาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColAprLS").HeaderText = "เมษายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColMayLS").HeaderText = "พฤษภาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColJunLS").HeaderText = "มิถุนายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColJulLS").HeaderText = "กรกฎาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColAugLS").HeaderText = "สิงหาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColSepLS").HeaderText = "กันยายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColOctLS").HeaderText = "ตุลาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColNovLS").HeaderText = "พฤศจิกายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvPsSale.Columns("ColDecLS").HeaderText = "ธันวาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"

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
                               "AND ((SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') OR " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT, p.PdTradeName"
        sAdapter.Fill(Dt)


        ''************Summary ThisYear**************'
        Dim sDtY As New DataTable
        sDtY.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(SumThisY) AS SumThisY FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS SumThisY FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT " & _
                               "UNION SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS SumThisY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') AND " & _
                               "m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(SumLastY) AS SumLastY FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS SumLastY FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT " & _
                               "UNION SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS SumLastY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "'GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
            dgvPsSale.DataSource = Dt
            Exit Sub
        Else
            Dt.DefaultView.Sort = "[SumThisY] DESC"
            dgvPsSale.DataSource = Dt
        End If

        '*********** %เติบโต & %สัดส่วน ***********'
        Dim SumThisYearPS As Double = 0.0
        For i As Integer = 0 To dgvPsSale.Rows.Count - 1
            If dgvPsSale.Rows(i).Cells("ColSumYearS").Value Is DBNull.Value Then
                dgvPsSale.Rows(i).Cells("ColSumYearS").Value = Format(0.0, "#,##0.00")
            End If
            SumThisYearPS += dgvPsSale.Rows(i).Cells("ColSumYearS").Value
        Next

        For i As Integer = 0 To dgvPsSale.Rows.Count - 1
            If SumThisYearPS = 0.0 Then
                dgvPsSale.Rows(i).Cells("ColRatioPS").Value = Format(0.0, "#,##0.00")
            Else
                dgvPsSale.Rows(i).Cells("ColRatioPS").Value = Format((dgvPsSale.Rows(i).Cells("ColSumYearS").Value / SumThisYearPS) * 100, "#,##0.00")
            End If

            If dgvPsSale.Rows(i).Cells("ColLastYPS").Value = 0.0 Then
                dgvPsSale.Rows(i).Cells("ColGrowUpPS").Value = "0.00"
            Else
                dgvPsSale.Rows(i).Cells("ColGrowUpPS").Value = ((CDbl(dgvPsSale.Rows(i).Cells("ColSumYearS").Value) - CDbl(dgvPsSale.Rows(i).Cells("ColLastYPS").Value)) / CDbl(dgvPsSale.Rows(i).Cells("ColLastYPS").Value)) * 100
            End If
        Next

        '************Jan**************'
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColjanS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColJanLS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Feb**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColFebS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColFebLS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Mar**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColMarS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColMarLS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Apr**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColAprS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColAprLS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************May**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColMayS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColMayLS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next


        '************Jun**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "'  GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "'  GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColJunS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "'  GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "'  GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColJunLS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Jul**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColJulS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColJulLS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Aug**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColAugS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColAugLS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Sep**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColSepS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColSepLS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Oct**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColOctS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColOctLS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Nov**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColNovS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColNovLS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Dec**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColDecS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12') " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12')) " & _
                               "AND m.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvPsSale.Rows.Count - 1
                If dgvPsSale.Rows(j).Cells("ColidPdTS").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvPsSale.Rows(j).Cells("ColDecLS").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

    End Sub


    Private Sub dgvPsSale_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvPsSale.RowPostPaint
        Me.dgvPsSale("ColNumS", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Private Sub BindCustomer()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT idCus, CusName, SUM(SumThisY) AS SumThisY, '' AS CusNameShow " & _
                               "FROM (SELECT m.idCus, m.CusName, SUM(d.Weight * d.Amount) AS SumThisY " & _
                               "FROM vSmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale " & _
                               "WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') AND " & _
                               "(m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "GROUP BY m.idCus, m.CusName UNION SELECT m.idCus, m.CusName, " & _
                               "SUM(d.Weight * d.Amount / 1000) AS SumThisY FROM vSmSaleMt AS m " & _
                               "INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) " & _
                               "AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "GROUP BY m.idCus, m.CusName) AS result GROUP BY idCus, " & _
                               "CusName ORDER BY SumThisY DESC"
        sAdapter.Fill(sDt)

        For i As Integer = 0 To sDt.Rows.Count - 1
            sDt.Rows(i).Item("CusNameShow") = sDt.Rows(i).Item("CusName") & " : " & Format(sDt.Rows(i).Item("SumThisY"), "#,##0.00").ToString & " Kg"
        Next

        With cmbCustomer
            .DisplayMember = "CusNameShow"
            .ValueMember = "idCus"
            .DataSource = sDt
        End With
    End Sub

    Private Sub cmbCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomer.SelectedIndexChanged
        mdLoadShow()
        SummaryCustomer()
        Me.dgvCustomer.Focus()
        mdLoadCommitt()
    End Sub

    Sub SummaryCustomer()
        Me.dgvCustomer.Columns("ColSumYearC").HeaderText = "จน.ขายปี " & Me.dtpYear.Text & " (Kg)"
        Me.dgvCustomer.Columns("ColjanC").HeaderText = "มกราคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColFebC").HeaderText = "กุมภาพันธ์ " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColMarC").HeaderText = "มีนาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColAprC").HeaderText = "เมษายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColMayC").HeaderText = "พฤษภาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColJunC").HeaderText = "มิถุนายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColJulC").HeaderText = "กรกฎาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColAugC").HeaderText = "สิงหาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColSepC").HeaderText = "กันยายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColOctC").HeaderText = "ตุลาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColNovC").HeaderText = "พฤศจิกายน " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColDecC").HeaderText = "ธันวาคม " & Me.dtpYear.Text.Substring(2, 2) & " (Kg)"
        'Dim lastYear As Integer = Me.dtpYear.Text - 1
        Me.dgvCustomer.Columns("ColLastYPC").HeaderText = "จน.ขายปี " & lastYear.ToString & " (Kg)"
        Me.dgvCustomer.Columns("ColJanLC").HeaderText = "มกราคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColFebLC").HeaderText = "กุมภาพันธ์ " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColMarLC").HeaderText = "มีนาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColAprLC").HeaderText = "เมษายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColMayLC").HeaderText = "พฤษภาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColJunLC").HeaderText = "มิถุนายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColJulLC").HeaderText = "กรกฎาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColAugLC").HeaderText = "สิงหาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColSepLC").HeaderText = "กันยายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColOctLC").HeaderText = "ตุลาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColNovLC").HeaderText = "พฤศจิกายน " & lastYear.ToString.Substring(2, 2) & " (Kg)"
        Me.dgvCustomer.Columns("ColDecLC").HeaderText = "ธันวาคม " & lastYear.ToString.Substring(2, 2) & " (Kg)"

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
                               "AND ((SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') OR " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT, p.PdTradeName"
        sAdapter.Fill(Dt)


        '************Summary ThisYear**************'
        Dim sDtY As New DataTable
        sDtY.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(SumThisY) AS SumThisY FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS SumThisY FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT " & _
                               "UNION SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS SumThisY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') AND " & _
                               "m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
        sCommand.CommandText = "SELECT idPdT, SUM(SumLastY) AS SumLastY FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS SumLastY FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT " & _
                               "UNION SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS SumLastY " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "'GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
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
            dgvCustomer.DataSource = Dt
            Exit Sub
        Else
            Dt.DefaultView.Sort = "[SumThisY] DESC"
            dgvCustomer.DataSource = Dt
        End If

        '*********** %เติบโต & %สัดส่วน ***********'
        Dim SumThisYearPC As Double = 0.0
        For i As Integer = 0 To dgvCustomer.Rows.Count - 1
            If dgvCustomer.Rows(i).Cells("ColSumYearC").Value Is DBNull.Value Then
                dgvCustomer.Rows(i).Cells("ColSumYearC").Value = Format(0.0, "#,##0.00")
            End If
            SumThisYearPC += dgvCustomer.Rows(i).Cells("ColSumYearC").Value
        Next

        For i As Integer = 0 To dgvCustomer.Rows.Count - 1
            If SumThisYearPC = 0.0 Then
                dgvCustomer.Rows(i).Cells("ColRatioPC").Value = Format(0.0, "#,##0.00")
            Else
                dgvCustomer.Rows(i).Cells("ColRatioPC").Value = Format((dgvCustomer.Rows(i).Cells("ColSumYearC").Value / SumThisYearPC) * 100, "#,##0.00")
            End If

            If dgvCustomer.Rows(i).Cells("ColLastYPC").Value = 0.0 Then
                dgvCustomer.Rows(i).Cells("ColGrowUpPC").Value = "0.00"
            Else
                dgvCustomer.Rows(i).Cells("ColGrowUpPC").Value = ((CDbl(dgvCustomer.Rows(i).Cells("ColSumYearC").Value) - CDbl(dgvCustomer.Rows(i).Cells("ColLastYPC").Value)) / CDbl(dgvCustomer.Rows(i).Cells("ColLastYPC").Value)) * 100
            End If
        Next

        '************Jan**************'
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColjanC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '01')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColJanLC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Feb**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColFebC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '02')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColFebLC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Mar**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColMarC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '03')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColMarLC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Apr**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColAprC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '04')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColAprLC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************May**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColMayC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '05')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColMayLC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next


        '************Jun**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "'  GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "'  GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColJunC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "'  GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '06')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "'  GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColJunLC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Jul**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColJulC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '07')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColJulLC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Aug**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColAugC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '08')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColAugLC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Sep**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColSepC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '09')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColSepLC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Oct**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColOctC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '10')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColOctLC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Nov**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColNovC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '11')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColNovLC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        '************Dec**************'
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & Me.dtpYear.Text & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColDecC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

        sDt.Clear()
        sCommand.CommandText = "SELECT idPdT, SUM(Total) AS Total FROM (SELECT p.idPdT, " & _
                               "SUM(d.Weight * d.Amount) AS Total FROM SmSaleMt AS m INNER JOIN " & _
                               "SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN vPackingPdSet AS p " & _
                               "ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 2) AND (m.idComp = '" & sIdComp & "') " & _
                               "AND (m.idPsCancel IS NULL) AND (SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "') " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12') " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT UNION " & _
                               "SELECT p.idPdT, SUM(d.Weight * d.Amount / 1000) AS Total " & _
                               "FROM SmSaleMt AS m INNER JOIN SmSaleDt AS d ON m.idSale = d.idSale INNER JOIN " & _
                               "vPackingPdSet AS p ON d.idPdPk = p.idPdPk WHERE (d.idUnitW = 1) " & _
                               "AND (m.idComp = '" & sIdComp & "') AND (m.idPsCancel IS NULL) AND " & _
                               "(SUBSTRING(m.DateSale, 1, 4) = '" & lastYear.ToString & "' " & _
                               "AND (SUBSTRING(m.DateSale, 5, 2) = '12')) " & _
                               "AND m.idCus = '" & Me.cmbCustomer.SelectedValue & "' GROUP BY p.idPdT) " & _
                               "AS result GROUP BY idPdT"
        sAdapter.Fill(sDt)
        For i As Integer = 0 To sDt.Rows.Count - 1
            For j As Integer = 0 To dgvCustomer.Rows.Count - 1
                If dgvCustomer.Rows(j).Cells("ColidPdTC").Value = sDt.Rows(i).Item("idPdT") Then
                    dgvCustomer.Rows(j).Cells("ColDecLC").Value = sDt.Rows(i).Item("Total")
                    Exit For
                End If
            Next
        Next

    End Sub


    Private Sub dgvCustomer_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvCustomer.RowPostPaint
        Me.dgvCustomer("ColNumC", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    'Private Sub rdbOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbOther.CheckedChanged
    '    If Me.rdbOther.Checked = True Then
    '        mdLoadShow()
    '        lastYear = Me.dtpYear.Text - 1
    '        SummaryPdPkUnit()
    '        mdLoadCommitt()
    '    End If
    'End Sub

    'Private Sub rdbKg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbKg.CheckedChanged
    '    If Me.rdbKg.Checked = True And stload = 1 Then
    '        mdLoadShow()
    '        lastYear = Me.dtpYear.Text - 1
    '        SummaryPdPk()
    '        mdLoadCommitt()
    '    End If
    'End Sub

    Private Sub txtPdName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPdName.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            If Me.rdbKg.Checked = True Then
                SummaryPdPk()
            Else
                SummaryPdPkUnit()
            End If
            mdLoadCommitt()
        End If
    End Sub

    'Private Sub TabPage3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage3.Click
    '    Me.txtPdName.Focus()
    'End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If Me.TabControl1.SelectedIndex = 2 Then
            Me.txtPdName.Focus()
        End If
    End Sub

    Private Sub ChkUnit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkUnit.CheckedChanged
        If Me.ChkUnit.Checked = True Then
            Me.CmbUnit.Enabled = True
        Else
            Me.CmbUnit.Enabled = False
            Me.ChkPkDetail.Checked = False
            Me.CmbPkDetail.Enabled = False
        End If
    End Sub

    Private Sub ChkPkDetail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPkDetail.CheckedChanged
        If Me.ChkPkDetail.Checked = True Then
            Me.CmbPkDetail.Enabled = True
        Else
            Me.CmbPkDetail.Enabled = False
        End If
    End Sub

    Private Sub ChkShortN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkShortN.CheckedChanged
        If Me.ChkShortN.Checked = True Then
            Me.txtShortN.Enabled = True
            Me.txtShortN.Focus()
        Else
            Me.txtShortN.Enabled = False
        End If
    End Sub

    Private Sub btnShowPk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPk.Click
        mdLoadShow()
        lastYear = Me.dtpYear.Text - 1
        If Me.rdbKg.Checked = True Then
            SummaryPdPk()
        Else
            SummaryPdPkUnit()
        End If
        mdLoadCommitt()
    End Sub

    Sub PrintPkData()
        Dim AmountSummaryPk As New DataTable
        AmountSummaryPk.Clear()
        AmountSummaryPk.Columns.Add("idPdPk", Type.GetType("System.Int32"))
        AmountSummaryPk.Columns.Add("PdPkName", Type.GetType("System.String"))
        AmountSummaryPk.Columns.Add("ShortName", Type.GetType("System.String"))
        AmountSummaryPk.Columns.Add("SumThisY", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("RatioP", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("GrowUpP", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("SumLastY", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("Jan", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("JanL", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("Feb", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("FebL", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("Mar", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("MarL", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("Apr", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("AprL", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("May", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("MayL", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("Jun", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("JunL", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("Jul", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("JulL", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("Aug", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("AugL", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("Sep", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("SepL", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("Oct", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("OctL", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("Nov", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("NovL", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("Dec", Type.GetType("System.Double"))
        AmountSummaryPk.Columns.Add("DecL", Type.GetType("System.Double"))

        For i As Integer = 0 To dgvPdPk.Rows.Count - 1
            Dim rc As Integer = AmountSummaryPk.Rows.Count
            AmountSummaryPk.Rows.Add()
            AmountSummaryPk.Rows(rc).Item("idPdPk") = dgvPdPk.Rows(i).Cells("ColidPdPk").Value
            AmountSummaryPk.Rows(rc).Item("PdPkName") = dgvPdPk.Rows(i).Cells("ColPdPkName").Value
            AmountSummaryPk.Rows(rc).Item("ShortName") = dgvPdPk.Rows(i).Cells("ColShortName").Value
            AmountSummaryPk.Rows(rc).Item("SumThisY") = dgvPdPk.Rows(i).Cells("ColSumYearPk").Value
            AmountSummaryPk.Rows(rc).Item("RatioP") = dgvPdPk.Rows(i).Cells("ColRatioPPk").Value
            AmountSummaryPk.Rows(rc).Item("GrowUpP") = dgvPdPk.Rows(i).Cells("ColGrowUpPPk").Value
            AmountSummaryPk.Rows(rc).Item("SumLastY") = dgvPdPk.Rows(i).Cells("ColLastYPPk").Value
            AmountSummaryPk.Rows(rc).Item("Jan") = dgvPdPk.Rows(i).Cells("ColJanPk").Value
            AmountSummaryPk.Rows(rc).Item("JanL") = dgvPdPk.Rows(i).Cells("ColJanLPk").Value
            AmountSummaryPk.Rows(rc).Item("Feb") = dgvPdPk.Rows(i).Cells("ColFebPk").Value
            AmountSummaryPk.Rows(rc).Item("FebL") = dgvPdPk.Rows(i).Cells("ColFebLPk").Value
            AmountSummaryPk.Rows(rc).Item("Mar") = dgvPdPk.Rows(i).Cells("ColMarPk").Value
            AmountSummaryPk.Rows(rc).Item("MarL") = dgvPdPk.Rows(i).Cells("ColMarLPk").Value
            AmountSummaryPk.Rows(rc).Item("Apr") = dgvPdPk.Rows(i).Cells("ColAprPk").Value
            AmountSummaryPk.Rows(rc).Item("AprL") = dgvPdPk.Rows(i).Cells("ColAprLPk").Value
            AmountSummaryPk.Rows(rc).Item("May") = dgvPdPk.Rows(i).Cells("ColMayPk").Value
            AmountSummaryPk.Rows(rc).Item("MayL") = dgvPdPk.Rows(i).Cells("ColMayLPk").Value
            AmountSummaryPk.Rows(rc).Item("Jun") = dgvPdPk.Rows(i).Cells("ColJunPk").Value
            AmountSummaryPk.Rows(rc).Item("JunL") = dgvPdPk.Rows(i).Cells("ColJunLPk").Value
            AmountSummaryPk.Rows(rc).Item("Jul") = dgvPdPk.Rows(i).Cells("ColJulPk").Value
            AmountSummaryPk.Rows(rc).Item("JulL") = dgvPdPk.Rows(i).Cells("ColJulLPk").Value
            AmountSummaryPk.Rows(rc).Item("Aug") = dgvPdPk.Rows(i).Cells("ColAugPk").Value
            AmountSummaryPk.Rows(rc).Item("AugL") = dgvPdPk.Rows(i).Cells("ColAugLPk").Value
            AmountSummaryPk.Rows(rc).Item("Sep") = dgvPdPk.Rows(i).Cells("ColSepPk").Value
            AmountSummaryPk.Rows(rc).Item("SepL") = dgvPdPk.Rows(i).Cells("ColSepLPk").Value
            AmountSummaryPk.Rows(rc).Item("Oct") = dgvPdPk.Rows(i).Cells("ColOctPk").Value
            AmountSummaryPk.Rows(rc).Item("OctL") = dgvPdPk.Rows(i).Cells("ColOctLPk").Value
            AmountSummaryPk.Rows(rc).Item("Nov") = dgvPdPk.Rows(i).Cells("ColNovPk").Value
            AmountSummaryPk.Rows(rc).Item("NovL") = dgvPdPk.Rows(i).Cells("ColNovLPk").Value
            AmountSummaryPk.Rows(rc).Item("Dec") = dgvPdPk.Rows(i).Cells("ColDecPk").Value
            AmountSummaryPk.Rows(rc).Item("DecL") = dgvPdPk.Rows(i).Cells("ColDecLPk").Value
        Next


        If AmountSummaryPk.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่มีข้อมูลที่สามารถแสดงรายงานได้", sSystemName)
            AmountSummaryPk.Clear()
            Exit Sub
        Else
            Dim vUnit As String = ""
            Dim vFrm As New frmReportView
            Dim vRpt As New crpSlSaleAmountSummaryPackage
            vRpt.SetDataSource(AmountSummaryPk)
            vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
            vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, sPsName)
            If Me.txtPdName.Text = "" Then
                vRpt.SetParameterValue(vRpt.Parameter_PdName.ParameterFieldName, "-")
            Else
                vRpt.SetParameterValue(vRpt.Parameter_PdName.ParameterFieldName, Me.txtPdName.Text)
            End If
            vRpt.SetParameterValue(vRpt.Parameter_DateS.ParameterFieldName, "ประจำปี  " & Me.dtpYear.Text)
            If Me.rdbKg.Checked = True Then
                vRpt.SetParameterValue(vRpt.Parameter_UnitShow.ParameterFieldName, Me.rdbKg.Text)
                vUnit = " (Kg)"
            Else
                vRpt.SetParameterValue(vRpt.Parameter_UnitShow.ParameterFieldName, Me.rdbOther.Text)
                vUnit = " (ชิ้น)"
            End If
            If Me.ChkUnit.Checked = True Then
                vRpt.SetParameterValue(vRpt.Parameter_Unit.ParameterFieldName, Me.CmbUnit.Text)
            Else
                vRpt.SetParameterValue(vRpt.Parameter_Unit.ParameterFieldName, "-")
            End If
            If Me.ChkPkDetail.Checked = True Then
                vRpt.SetParameterValue(vRpt.Parameter_PkDetail.ParameterFieldName, Me.CmbPkDetail.Text)
            Else
                vRpt.SetParameterValue(vRpt.Parameter_PkDetail.ParameterFieldName, "-")
            End If
            If Me.ChkShortN.Checked = True Then
                vRpt.SetParameterValue(vRpt.Parameter_ShName.ParameterFieldName, Me.txtShortN.Text)
            Else
                vRpt.SetParameterValue(vRpt.Parameter_ShName.ParameterFieldName, "-")
            End If
            vRpt.SetParameterValue(vRpt.Parameter_ThisY.ParameterFieldName, "ปี " & Me.dtpYear.Text)
            vRpt.SetParameterValue(vRpt.Parameter_LastY.ParameterFieldName, "ปี " & lastYear.ToString)
            vRpt.SetParameterValue(vRpt.Parameter_Jan.ParameterFieldName, "ม.ค. " & Me.dtpYear.Text.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_JanL.ParameterFieldName, "ม.ค. " & lastYear.ToString.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_Feb.ParameterFieldName, "ก.พ. " & Me.dtpYear.Text.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_FebL.ParameterFieldName, "ก.พ. " & lastYear.ToString.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_Mar.ParameterFieldName, "มี.ค. " & Me.dtpYear.Text.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_MarL.ParameterFieldName, "มี.ค. " & lastYear.ToString.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_Apr.ParameterFieldName, "เม.ย. " & Me.dtpYear.Text.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_AprL.ParameterFieldName, "เม.ย. " & lastYear.ToString.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_May.ParameterFieldName, "พ.ค. " & Me.dtpYear.Text.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_MayL.ParameterFieldName, "พ.ค. " & lastYear.ToString.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_Jun.ParameterFieldName, "มิ.ย. " & Me.dtpYear.Text.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_JunL.ParameterFieldName, "มิ.ย. " & lastYear.ToString.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_Jul.ParameterFieldName, "ก.ค. " & Me.dtpYear.Text.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_JulL.ParameterFieldName, "ก.ค. " & lastYear.ToString.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_Aug.ParameterFieldName, "ส.ค. " & Me.dtpYear.Text.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_AugL.ParameterFieldName, "ส.ค. " & lastYear.ToString.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_Sep.ParameterFieldName, "ก.ย. " & Me.dtpYear.Text.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_SepL.ParameterFieldName, "ก.ย. " & lastYear.ToString.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_Oct.ParameterFieldName, "ต.ค. " & Me.dtpYear.Text.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_OctL.ParameterFieldName, "ต.ค. " & lastYear.ToString.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_Nov.ParameterFieldName, "พ.ย. " & Me.dtpYear.Text.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_NovL.ParameterFieldName, "พ.ย. " & lastYear.ToString.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_Dec.ParameterFieldName, "ธ.ค. " & Me.dtpYear.Text.Substring(2, 2))
            vRpt.SetParameterValue(vRpt.Parameter_DecL.ParameterFieldName, "ธ.ค. " & lastYear.ToString.Substring(2, 2))
            vFrm.crView.ReportSource = vRpt
            vFrm.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            vFrm.Show()
        End If

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        mdLoadShow()
        lastYear = Me.dtpYear.Text - 1
        PrintPkData()
        mdLoadCommitt()
    End Sub
End Class