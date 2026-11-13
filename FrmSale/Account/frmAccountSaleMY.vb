Imports DevExpress.XtraSplashScreen


Public Class frmAccountSaleMY
    Dim Result As DialogResult
    Dim stload As Integer = 0
    ' Dim stPage As String = 0
    Dim eEvent As eProcess

    Enum eProcess
        eAdd
        eCompare
    End Enum

    Sub New(ByVal aProcess As eProcess)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eCompare
                Me.Text = "เปรียบเทียบยอดขายทางบัญชีและยอดขายจากระบบ SAM"
                Me.Panel3.Visible = True
                dgvSaleValue.Columns("ColSumSAM").Visible = True
                dgvSaleValue.Columns("ColDiff").Visible = True
                Me.btnSave.Visible = False
                dgvSaleValue.Columns("ColSaleValue").DefaultCellStyle.BackColor = Color.PowderBlue
                dgvSaleValue.Columns("ColSaleValue").ReadOnly = True
        End Select
        eEvent = aProcess
    End Sub

    Private Sub tmpAccountSaleMY_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mdLoadShow()
        Me.dtpYear.Value = Date.Today
        setCmbGroupComp(cmbGroupComp)

        Dim r As Integer = dgvSaleValue.Rows.Count() ' = 1 Header
        r = dgvSaleValue.Rows.Count()
        dgvSaleValue.Rows.Add()
        dgvSaleValue.Rows(r).Cells("ColMonth").Value = "มกราคม"
        dgvSaleValue.Rows(r).Cells("ColNumM").Value = "01"
        dgvSaleValue.Rows(r).Cells("ColSalevalue").Value = 0.0
        r = dgvSaleValue.Rows.Count()
        dgvSaleValue.Rows.Add()
        dgvSaleValue.Rows(r).Cells("ColMonth").Value = "กุมภาพันธ์"
        dgvSaleValue.Rows(r).Cells("ColNumM").Value = "02"
        dgvSaleValue.Rows(r).Cells("ColSalevalue").Value = 0.0
        r = dgvSaleValue.Rows.Count()
        dgvSaleValue.Rows.Add()
        dgvSaleValue.Rows(r).Cells("ColMonth").Value = "มีนาคม"
        dgvSaleValue.Rows(r).Cells("ColNumM").Value = "03"
        dgvSaleValue.Rows(r).Cells("ColSalevalue").Value = 0.0
        r = dgvSaleValue.Rows.Count()
        dgvSaleValue.Rows.Add()
        dgvSaleValue.Rows(r).Cells("ColMonth").Value = "เมษายน"
        dgvSaleValue.Rows(r).Cells("ColNumM").Value = "04"
        dgvSaleValue.Rows(r).Cells("ColSalevalue").Value = 0.0
        r = dgvSaleValue.Rows.Count()
        dgvSaleValue.Rows.Add()
        dgvSaleValue.Rows(r).Cells("ColMonth").Value = "พฤษภาคม"
        dgvSaleValue.Rows(r).Cells("ColNumM").Value = "05"
        dgvSaleValue.Rows(r).Cells("ColSalevalue").Value = 0.0
        r = dgvSaleValue.Rows.Count()
        dgvSaleValue.Rows.Add()
        dgvSaleValue.Rows(r).Cells("ColMonth").Value = "มิถุนายน"
        dgvSaleValue.Rows(r).Cells("ColNumM").Value = "06"
        dgvSaleValue.Rows(r).Cells("ColSalevalue").Value = 0.0
        r = dgvSaleValue.Rows.Count()
        dgvSaleValue.Rows.Add()
        dgvSaleValue.Rows(r).Cells("ColMonth").Value = "กรกฎาคม"
        dgvSaleValue.Rows(r).Cells("ColNumM").Value = "07"
        dgvSaleValue.Rows(r).Cells("ColSalevalue").Value = 0.0
        r = dgvSaleValue.Rows.Count()
        dgvSaleValue.Rows.Add()
        dgvSaleValue.Rows(r).Cells("ColMonth").Value = "สิงหาคม"
        dgvSaleValue.Rows(r).Cells("ColNumM").Value = "08"
        dgvSaleValue.Rows(r).Cells("ColSalevalue").Value = 0.0
        r = dgvSaleValue.Rows.Count()
        dgvSaleValue.Rows.Add()
        dgvSaleValue.Rows(r).Cells("ColMonth").Value = "กันยายน"
        dgvSaleValue.Rows(r).Cells("ColNumM").Value = "09"
        dgvSaleValue.Rows(r).Cells("ColSalevalue").Value = 0.0
        r = dgvSaleValue.Rows.Count()
        dgvSaleValue.Rows.Add()
        dgvSaleValue.Rows(r).Cells("ColMonth").Value = "ตุลาคม"
        dgvSaleValue.Rows(r).Cells("ColNumM").Value = "10"
        dgvSaleValue.Rows(r).Cells("ColSalevalue").Value = 0.0
        r = dgvSaleValue.Rows.Count()
        dgvSaleValue.Rows.Add()
        dgvSaleValue.Rows(r).Cells("ColMonth").Value = "พฤศจิกายน"
        dgvSaleValue.Rows(r).Cells("ColNumM").Value = "11"
        dgvSaleValue.Rows(r).Cells("ColSalevalue").Value = 0.0
        r = dgvSaleValue.Rows.Count()
        dgvSaleValue.Rows.Add()
        dgvSaleValue.Rows(r).Cells("ColMonth").Value = "ธันวาคม"
        dgvSaleValue.Rows(r).Cells("ColNumM").Value = "12"
        dgvSaleValue.Rows(r).Cells("ColSalevalue").Value = 0.0

        stload = 1
        BindData()
        mdLoadCommitt()
    End Sub

    Sub BindData()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select SUBSTRING(YM, 5, 2) as month, SumValue From tmpAccountSaleMY WHERE " & _
                               "SUBSTRING(YM,1,4) = '" & Me.dtpYear.Text & "' AND idComp = " & Me.cmbGroupComp.SelectedValue
        sAdapter.Fill(sDt)

        If sDt.Rows.Count > 0 Then
            For i As Integer = 0 To sDt.Rows.Count - 1
                If sDt.Rows(i).Item("month") = "01" Then
                    dgvSaleValue.Rows(0).Cells("ColSalevalue").Value = sDt.Rows(i).Item("SumValue")
                ElseIf sDt.Rows(i).Item("month") = "02" Then
                    dgvSaleValue.Rows(1).Cells("ColSalevalue").Value = sDt.Rows(i).Item("SumValue")
                ElseIf sDt.Rows(i).Item("month") = "03" Then
                    dgvSaleValue.Rows(2).Cells("ColSalevalue").Value = sDt.Rows(i).Item("SumValue")
                ElseIf sDt.Rows(i).Item("month") = "04" Then
                    dgvSaleValue.Rows(3).Cells("ColSalevalue").Value = sDt.Rows(i).Item("SumValue")
                ElseIf sDt.Rows(i).Item("month") = "05" Then
                    dgvSaleValue.Rows(4).Cells("ColSalevalue").Value = sDt.Rows(i).Item("SumValue")
                ElseIf sDt.Rows(i).Item("month") = "06" Then
                    dgvSaleValue.Rows(5).Cells("ColSalevalue").Value = sDt.Rows(i).Item("SumValue")
                ElseIf sDt.Rows(i).Item("month") = "07" Then
                    dgvSaleValue.Rows(6).Cells("ColSalevalue").Value = sDt.Rows(i).Item("SumValue")
                ElseIf sDt.Rows(i).Item("month") = "08" Then
                    dgvSaleValue.Rows(7).Cells("ColSalevalue").Value = sDt.Rows(i).Item("SumValue")
                ElseIf sDt.Rows(i).Item("month") = "09" Then
                    dgvSaleValue.Rows(8).Cells("ColSalevalue").Value = sDt.Rows(i).Item("SumValue")
                ElseIf sDt.Rows(i).Item("month") = "10" Then
                    dgvSaleValue.Rows(9).Cells("ColSalevalue").Value = sDt.Rows(i).Item("SumValue")
                ElseIf sDt.Rows(i).Item("month") = "11" Then
                    dgvSaleValue.Rows(10).Cells("ColSalevalue").Value = sDt.Rows(i).Item("SumValue")
                ElseIf sDt.Rows(i).Item("month") = "12" Then
                    dgvSaleValue.Rows(11).Cells("ColSalevalue").Value = sDt.Rows(i).Item("SumValue")
                End If
            Next
        End If

        If eEvent = eProcess.eCompare Then  'Compare
            Dim vDt As New DataTable
            vDt.Clear()
            sCommand.CommandText = "Select monthSale as month, SUM(TotalSale) as total " & _
                                   "From vSmSaleMt Where idSaleCode NOT IN (1,18) AND (YearSale = '" & Me.dtpYear.Text & "') " & _
                                   "AND idPsCancel IS Null AND idComp = " & Me.cmbGroupComp.SelectedValue & " GROUP BY monthSale"
            sAdapter.Fill(vDt)
            For i As Integer = 0 To vDt.Rows.Count - 1
                If vDt.Rows(i).Item("month") = "01" Then
                    dgvSaleValue.Rows(0).Cells("ColSumSAM").Value = vDt.Rows(i).Item("total")
                    dgvSaleValue.Rows(0).Cells("ColDiff").Value = CDbl(dgvSaleValue.Rows(0).Cells("ColSalevalue").Value) - CDbl(dgvSaleValue.Rows(0).Cells("ColSumSAM").Value)
                ElseIf vDt.Rows(i).Item("month") = "02" Then
                    dgvSaleValue.Rows(1).Cells("ColSumSAM").Value = vDt.Rows(i).Item("total")
                    dgvSaleValue.Rows(1).Cells("ColDiff").Value = CDbl(dgvSaleValue.Rows(1).Cells("ColSalevalue").Value) - CDbl(dgvSaleValue.Rows(1).Cells("ColSumSAM").Value)
                ElseIf vDt.Rows(i).Item("month") = "03" Then
                    dgvSaleValue.Rows(2).Cells("ColSumSAM").Value = vDt.Rows(i).Item("total")
                    dgvSaleValue.Rows(2).Cells("ColDiff").Value = CDbl(dgvSaleValue.Rows(2).Cells("ColSalevalue").Value) - CDbl(dgvSaleValue.Rows(2).Cells("ColSumSAM").Value)
                ElseIf vDt.Rows(i).Item("month") = "04" Then
                    dgvSaleValue.Rows(3).Cells("ColSumSAM").Value = vDt.Rows(i).Item("total")
                    dgvSaleValue.Rows(3).Cells("ColDiff").Value = CDbl(dgvSaleValue.Rows(3).Cells("ColSalevalue").Value) - CDbl(dgvSaleValue.Rows(3).Cells("ColSumSAM").Value)
                ElseIf vDt.Rows(i).Item("month") = "05" Then
                    dgvSaleValue.Rows(4).Cells("ColSumSAM").Value = vDt.Rows(i).Item("total")
                    dgvSaleValue.Rows(4).Cells("ColDiff").Value = CDbl(dgvSaleValue.Rows(4).Cells("ColSalevalue").Value) - CDbl(dgvSaleValue.Rows(4).Cells("ColSumSAM").Value)
                ElseIf vDt.Rows(i).Item("month") = "06" Then
                    dgvSaleValue.Rows(5).Cells("ColSumSAM").Value = vDt.Rows(i).Item("total")
                    dgvSaleValue.Rows(5).Cells("ColDiff").Value = CDbl(dgvSaleValue.Rows(5).Cells("ColSalevalue").Value) - CDbl(dgvSaleValue.Rows(5).Cells("ColSumSAM").Value)
                ElseIf vDt.Rows(i).Item("month") = "07" Then
                    dgvSaleValue.Rows(6).Cells("ColSumSAM").Value = vDt.Rows(i).Item("total")
                    dgvSaleValue.Rows(6).Cells("ColDiff").Value = CDbl(dgvSaleValue.Rows(6).Cells("ColSalevalue").Value) - CDbl(dgvSaleValue.Rows(6).Cells("ColSumSAM").Value)
                ElseIf vDt.Rows(i).Item("month") = "08" Then
                    dgvSaleValue.Rows(7).Cells("ColSumSAM").Value = vDt.Rows(i).Item("total")
                    dgvSaleValue.Rows(7).Cells("ColDiff").Value = CDbl(dgvSaleValue.Rows(7).Cells("ColSalevalue").Value) - CDbl(dgvSaleValue.Rows(7).Cells("ColSumSAM").Value)
                ElseIf vDt.Rows(i).Item("month") = "09" Then
                    dgvSaleValue.Rows(8).Cells("ColSumSAM").Value = vDt.Rows(i).Item("total")
                    dgvSaleValue.Rows(8).Cells("ColDiff").Value = CDbl(dgvSaleValue.Rows(8).Cells("ColSalevalue").Value) - CDbl(dgvSaleValue.Rows(8).Cells("ColSumSAM").Value)
                ElseIf vDt.Rows(i).Item("month") = "10" Then
                    dgvSaleValue.Rows(9).Cells("ColSumSAM").Value = vDt.Rows(i).Item("total")
                    dgvSaleValue.Rows(9).Cells("ColDiff").Value = CDbl(dgvSaleValue.Rows(9).Cells("ColSalevalue").Value) - CDbl(dgvSaleValue.Rows(9).Cells("ColSumSAM").Value)
                ElseIf vDt.Rows(i).Item("month") = "11" Then
                    dgvSaleValue.Rows(10).Cells("ColSumSAM").Value = vDt.Rows(i).Item("total")
                    dgvSaleValue.Rows(10).Cells("ColDiff").Value = CDbl(dgvSaleValue.Rows(10).Cells("ColSalevalue").Value) - CDbl(dgvSaleValue.Rows(10).Cells("ColSumSAM").Value)
                ElseIf vDt.Rows(i).Item("month") = "12" Then
                    dgvSaleValue.Rows(11).Cells("ColSumSAM").Value = vDt.Rows(i).Item("total")
                    dgvSaleValue.Rows(11).Cells("ColDiff").Value = CDbl(dgvSaleValue.Rows(11).Cells("ColSalevalue").Value) - CDbl(dgvSaleValue.Rows(11).Cells("ColSumSAM").Value)
                End If
            Next
        End If

        SumTotal()
    End Sub

    Private Sub dgvSaleValue_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSaleValue.CellEndEdit
        Try
            dgvSaleValue.Rows(e.RowIndex).Cells("ColSalevalue").Value = Format(CDbl(dgvSaleValue.Rows(e.RowIndex).Cells("ColSalevalue").Value), "#,##0.00")
        Catch ex As Exception
            MessageBox.Show("รูปแบบยอดขายไม่ถูกต้อง กรุณากรอกข้อมูลใหม่", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dgvSaleValue.Rows(e.RowIndex).Cells("ColSalevalue").Value = "0.00"
        End Try
        SumTotal()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Result = MsgBox("คุณต้องการบันทึกข้อมูลใช่หรือไม่", MsgBoxStyle.YesNo)
        If Result = Windows.Forms.DialogResult.Yes Then
            mdCnOpen()
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            For i As Integer = 0 To dgvSaleValue.Rows.Count - 1
                Dim sDt2 As New DataTable
                sCommand.CommandText = "Select SumValue FROM tmpAccountSaleMY WHERE " & _
                                       "YM = '" & Me.dtpYear.Text & dgvSaleValue.Rows(i).Cells("ColNumM").Value & "' " & _
                                       "AND idComp = " & sIdComp
                sAdapter.Fill(sDt2)

                If sDt2.Rows.Count = 0 Then
                    sCommand.CommandText = "INSERT INTO tmpAccountSaleMY (YM, SumValue, idComp) VALUES " & _
                                        " ('" & Me.dtpYear.Text & dgvSaleValue.Rows(i).Cells("ColNumM").Value & "', " & _
                                        "" & CDbl(dgvSaleValue.Rows(i).Cells("ColSalevalue").Value) & ", " & sIdComp & ")"
                    sCommand.ExecuteNonQuery()
                Else
                    '---update new section of seed ----'
                    sCommand.CommandText = "Update tmpAccountSaleMY Set SumValue = " & CDbl(dgvSaleValue.Rows(i).Cells("ColSalevalue").Value) & " " & _
                                           "Where YM = '" & Me.dtpYear.Text & dgvSaleValue.Rows(i).Cells("ColNumM").Value & "' "
                    sCommand.ExecuteNonQuery()
                End If
            Next
            SplashScreenManager.CloseForm(False)
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dtpYear_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpYear.ValueChanged
        If stload = 1 Then
            For i As Integer = 0 To dgvSaleValue.Rows.Count - 1
                dgvSaleValue.Rows(i).Cells("ColSalevalue").Value = 0.0
                dgvSaleValue.Rows(i).Cells("ColSumSAM").Value = 0.0
                dgvSaleValue.Rows(i).Cells("ColDiff").Value = 0.0
            Next
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub cmbGroupComp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedIndexChanged
        If stload = 1 Then
            For i As Integer = 0 To dgvSaleValue.Rows.Count - 1
                dgvSaleValue.Rows(i).Cells("ColSalevalue").Value = 0.0
                dgvSaleValue.Rows(i).Cells("ColSumSAM").Value = 0.0
                dgvSaleValue.Rows(i).Cells("ColDiff").Value = 0.0
            Next
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub dgvSaleValue_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvSaleValue.EditingControlShowing
        With Me.dgvSaleValue
            If .CurrentCell.OwningColumn.Name = ColSaleValue.Name Then
                Dim tb As TextBox = CType(e.Control, TextBox)
                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If
        End With
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Me.dgvSaleValue.CurrentCell.OwningColumn.Name = ColSaleValue.Name Then
            If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If
    End Sub

    Sub SumTotal()
        Dim TotalNet As Double = 0.0
        Dim TotalSAM As Double = 0.0
        Dim totalDiff As Double = 0.0
        For i As Integer = 0 To dgvSaleValue.Rows.Count - 1
            TotalNet += dgvSaleValue.Rows(i).Cells("ColSaleValue").Value
            If eEvent = eProcess.eCompare Then 'Compare
                TotalSAM += dgvSaleValue.Rows(i).Cells("ColSumSAM").Value
                totalDiff += dgvSaleValue.Rows(i).Cells("ColDiff").Value
            End If
        Next
        txtTotalNet.Text = Format(TotalNet, "#,##0.00##")
        txtTotalSAM.Text = Format(TotalSAM, "#,##0.00##")
        txtDiff.Text = Format(totalDiff, "#,##0.00##")
    End Sub


End Class