Public Class frmMkTargetYear
    Dim strDate As String = ""
    Dim strDateY As String = ""
    Dim strDateM As String = ""
    Dim Mouth() As String = {"มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน", "กรกฏาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม"}
    Dim SumTotalNetY As Double
    Private Sub frmMkTargetYear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdCnOpen()
    End Sub
    Private Sub Load_Data()
        If txt_Y.Text = "" Then
            MessageBox.Show("ปี")
            Exit Sub
        End If
        mdLoadShow()
        Dim vWhere As String = ""
        vWhere = "Where s.YM = '" & strDate & "'"
        Dim dMk As New DataTable
        dMk.Clear()
        sCommand.CommandText = "SELECT s.Target FROM SmMkTarget as s " & vWhere & " AND s.idComp = " & sIdComp
        sAdapter.Fill(dMk)
        If dMk.Rows.Count <> 0 Then
            'txt_Target.Text = dMk.Rows(0).Item("Target")
            txt_TargetY.Text = FormatNumber(dMk.Rows(0).Item("Target"), , TriState.True)
        ElseIf dMk.Rows.Count = 0 Then
            txt_TargetY.Text = ""
            MessageBox.Show("ไม่มีข้อมูล")
        End If
        Dim dMkP As New DataTable
        dMkP.Clear()
        sCommand.CommandText = "SELECT  (CASE substring(s.YM,5,6) when '01' then 'มกราคม' when '02' then 'กุมภาพันธ์' when '03' then 'มีนาคม' when '04' then 'เมษายน' " & _
        "when '05' then 'พฤษภาคม' when '06' then 'มิถุนายน' when '07' then 'กรกฏาคม' when '08' then 'สิงหาคม' when '09' then 'กันยายน' when '10' then 'ตุลาคม' " & _
        "when '11' then 'พฤศจิกายน' when '12' then 'ธันวาคม' END) as Mouth,s.YM,s.Target FROM SmMkTarget as s Where substring(s.YM,1,4) = '" & strDate & "' AND substring(s.YM,5,6) <> '' AND s.idComp = " & sIdComp
        sAdapter.Fill(dMkP)
        DGV_YM.DataSource = dMkP
        ksbCountRowDgv(DGV_YM, colautonum.Name)
        Dim dST As New DataTable
        dST.Clear()
        strDateY = strDate - 1
        dST.Clear()
        sCommand.CommandText = "SELECT SUM(TotalNet) AS TotalNet FROM vSmSaleMt WHERE (SUBSTRING(DateSale, 1, 4) = '" & strDateY & "')"
        sAdapter.Fill(dST)
        SumTotalNetY = dST.Rows(0).Item("TotalNet")
        'txtdatey = frm.txt_DateY
        lb_Y.Text = "ยอดขายปี " & strDate - 1
        txt_TotalNetY.Text = FormatNumber(dST.Rows(0).Item("TotalNet"), 0)
        Dim target As Double = txt_TargetY.Text.Replace(",", String.Empty)
        Dim PerY As Double = (SumTotalNetY / target) * 100
        lb_PerY.Text = "เปอร์เซ็นส่วนต่างยอดขาย " & strDate - 1
        txt_PerY.Text = Format(PerY, "##0.00") & " %"
        mdLoadCommitt()
    End Sub
    Private Sub btn_YM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_YM.Click
        btn_save.Enabled = True
        Dim dST As New DataTable
        dST.Clear()
        Dim frm As New frmMYSelect(frmMYSelect.eProcess.eY)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            btn_addYM.Enabled = True
            strDate = frm.str_Date
            txt_Y.Text = frm.txt_Date
            Load_Data()
        End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txt_TargetY.Text = "" Then
            MessageBox.Show("กรุณาระบุเป้ายอดขาย")
            Exit Sub
        End If
        Dim target As Double = txt_TargetY.Text.Replace(",", String.Empty)
        If MessageBox.Show("ต้องการบันทึกข้อมูลหรือไม่", "บันทึกข้อมูล", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            sCommand.CommandText = "DELETE FROM SmMkTarget WHERE YM= '" & strDate & "' AND idComp = " & sIdComp
            sCommand.ExecuteNonQuery()
            sCommand.CommandText = "INSERT INTO  SmMkTarget (YM,Target,idComp) VALUES ('" & strDate & "'," & target & "," & sIdComp & ")"
            sCommand.ExecuteNonQuery()
            MessageBox.Show("บันทึกเรียบร้อยแล้ว")
            Load_Data()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txt_TargetY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_TargetY.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข")
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub btn_addYM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addYM.Click
        Dim frm As New frmMkTarget(frmMkTarget.eProcess.eAdd)
        frm.get_value(strDate)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            Load_Data()
        End If
    End Sub
    Public Sub NumberFormat(ByVal Text As TextBox)
        If Len(Text.Text) > 0 Then
            Text.Text = FormatNumber(CDbl(Text.Text), 0)
            Dim x As Integer = Text.SelectionStart.ToString
            If x = 0 Then
                Text.SelectionStart = Len(Text.Text)
                Text.SelectionLength = 0
            Else
                Text.SelectionStart = x
                Text.SelectionLength = 0
            End If
        End If
    End Sub
    'Public Sub NumberFormat(ByVal Text As TextBox)
    '    Dim temptext As TextBox = Text
    '    If Len(temptext.Text) > 0 Then
    '        'if no decimal then add decimal - maybe let user choose this option
    '        If temptext.Text.Contains(".") Then
    '        Else
    '            If temptext.TextLength > 1 Then
    '                Dim tempstr As String = temptext.Text.Substring(0, temptext.TextLength - 2)
    '                Dim tempstrlast2 As String = temptext.Text.Substring(temptext.TextLength - 2, 2)
    '                temptext.Text = CDec(tempstr & "." & tempstrlast2)
    '            Else
    '                temptext.Text = ".0" & temptext.Text
    '            End If
    '        End If
    '        ' changed this from 0 to -1 this gives you the decimal value
    '        temptext.Text = FormatNumber(CDbl(temptext.Text), -1)
    '        Dim x As Integer = temptext.SelectionStart.ToString
    '        If x = 0 Then
    '            temptext.SelectionStart = Len(temptext.Text)
    '            temptext.SelectionLength = 0
    '        Else
    '            temptext.SelectionStart = x
    '            temptext.SelectionLength = 0
    '        End If
    '    End If
    '    Text.Text = temptext.Text
    'End Sub
    Private Sub txt_TargetY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TargetY.TextChanged
        NumberFormat(txt_TargetY)
        'txt_TargetY.Text = Format(CDbl(txt_TargetY.Text), "#,###,###,##0.00")
        If txt_TargetY.Text <> "" Then
            Dim target As Double = txt_TargetY.Text.Replace(",", String.Empty)
            'txt_TargetY.Text = Format(target, "#,###,###,##0.00")
            Dim PerY As Double = ((target - SumTotalNetY) / SumTotalNetY) * 100
            lb_PerY.Text = "เปอร์เซ็นส่วนต่างยอดขาย " & strDate - 1
            txt_PerY.Text = Format(PerY, "##0.00") & " %"
        End If
    End Sub

    Private Sub DGV_YM_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_YM.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If DGV_YM.Columns(e.ColumnIndex).Name = coledit.Name Then
            Dim frm As New frmMkTarget(frmMkTarget.eProcess.eUpdate)
            frm.get_value(DGV_YM.Rows(e.RowIndex).Cells(colYM.Name).Value)
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                Load_Data()
            End If
        End If
    End Sub
End Class