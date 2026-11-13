Public Class frmMkTarget
    Dim status As Integer
    Dim chkstart As Boolean = False
    Dim Mouth() As String = {"มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน", "กรกฏาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม"}
    Enum eProcess
        eAdd
        eUpdate
    End Enum
    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim datenow As New Date(Date.Now.Year, Date.Now.Month, 1)
        Select Case aProcess
            Case eProcess.eUpdate
                status = 0
                cbMouth.Enabled = False
                btn_del.Visible = True
            Case eProcess.eAdd
                status = 1
                'btn_addPdT.Enabled = True
                'btn_save.Enabled = True
        End Select
    End Sub
    Sub get_value(ByVal str_date As String)
        strDate = str_date
    End Sub
    Private Sub frmMkTarget_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdCnOpen()
        Load_cbMouth()
        'Load_Data2()
        'Load_Data()
    End Sub
    Dim strDate As String = ""
    Dim strDateY As String = ""
    Dim strDateM As String = ""
    Private Sub Load_cbMouth()
        Dim dMouth As New DataTable
        dMouth.Columns.Add("NameMouth")
        dMouth.Columns.Add("idMouth")
        Dim r As DataRow = dMouth.NewRow()
        r("NameMouth") = "มกราคม/" & strDate.Substring(0, 4)
        r("idMouth") = "01"
        dMouth.Rows.Add(r)
        r = dMouth.NewRow()
        r("NameMouth") = "กุมภาพันธ์/" & strDate.Substring(0, 4)
        r("idMouth") = "02"
        dMouth.Rows.Add(r)
        r = dMouth.NewRow()
        r("NameMouth") = "มีนาคม/" & strDate.Substring(0, 4)
        r("idMouth") = "03"
        dMouth.Rows.Add(r)
        r = dMouth.NewRow()
        r("NameMouth") = "เมษายน/" & strDate.Substring(0, 4)
        r("idMouth") = "04"
        dMouth.Rows.Add(r)
        r = dMouth.NewRow()
        r("NameMouth") = "พฤษภาคม/" & strDate.Substring(0, 4)
        r("idMouth") = "05"
        dMouth.Rows.Add(r)
        r = dMouth.NewRow()
        r("NameMouth") = "มิถุนายน/" & strDate.Substring(0, 4)
        r("idMouth") = "06"
        dMouth.Rows.Add(r)
        r = dMouth.NewRow()
        r("NameMouth") = "กรกฏาคม/" & strDate.Substring(0, 4)
        r("idMouth") = "07"
        dMouth.Rows.Add(r)
        r = dMouth.NewRow()
        r("NameMouth") = "สิงหาคม/" & strDate.Substring(0, 4)
        r("idMouth") = "08"
        dMouth.Rows.Add(r)
        r = dMouth.NewRow()
        r("NameMouth") = "กันยายน/" & strDate.Substring(0, 4)
        r("idMouth") = "09"
        dMouth.Rows.Add(r)
        r = dMouth.NewRow()
        r("NameMouth") = "ตุลาคม/" & strDate.Substring(0, 4)
        r("idMouth") = "10"
        dMouth.Rows.Add(r)
        r = dMouth.NewRow()
        r("NameMouth") = "พฤศจิกายน/" & strDate.Substring(0, 4)
        r("idMouth") = "11"
        dMouth.Rows.Add(r)
        r = dMouth.NewRow()
        r("NameMouth") = "ธันวาคม/" & strDate.Substring(0, 4)
        r("idMouth") = "12"
        dMouth.Rows.Add(r)
        cbMouth.DataSource = dMouth
        cbMouth.DisplayMember = "NameMouth"
        cbMouth.ValueMember = "idMouth"
        chkstart = True
        If status = 0 Then
            cbMouth.SelectedValue = strDate.Substring(4, 2)
        Else
            Load_AddStart()
        End If
    End Sub
    Private Sub Load_AddStart()
        Dim dST As New DataTable
        dST.Clear()
        'txt_YM.Text = frm.txt_Date
        strDateY = (strDate.Substring(0, 4) - 1) & "01"
        dST.Clear()
        sCommand.CommandText = "SELECT SUM(TotalNet) AS TotalNet FROM vSmSaleMt WHERE (SUBSTRING(DateSale, 1, 6) = '" & strDateY & "')"
        sAdapter.Fill(dST)
        SumTotalNetY = dST.Rows(0).Item("TotalNet")
        txtdatey = Mouth(CInt(strDateY.Substring(4, 2)) - 1) & "/" & strDateY.Substring(0, 4)
        lb_Y.Text = "ยอดขาย " & txtdatey
        txt_TotalNetY.Text = Format(dST.Rows(0).Item("TotalNet"), "###,###,##0.00")
        Dim dateM As String = String.Format("{0,2}", cbMouth.SelectedValue.ToString - 1)
        dateM = dateM.Replace(" ", "0")
        strDateM = (strDate.Substring(0, 4) - 1) & "12"
        'strDateM = strDate
        dST.Clear()
        sCommand.CommandText = "SELECT SUM(TotalNet) AS TotalNet FROM vSmSaleMt WHERE (SUBSTRING(DateSale, 1, 6) = '" & strDateM & "')"
        sAdapter.Fill(dST)
        SumTotalNetM = dST.Rows(0).Item("TotalNet")
        txtdatem = Mouth(CInt(strDateM.Substring(4, 2)) - 1) & "/" & strDateM.Substring(0, 4)
        lb_M.Text = "ยอดขาย " & txtdatem
        txt_TotalNetM.Text = Format(dST.Rows(0).Item("TotalNet"), "###,###,##0.00")
        strDate = strDate & "01"
        Load_Data()
    End Sub
    Private Sub Load_Data2()
        Dim dST As New DataTable
        dST.Clear()
        'txt_YM.Text = frm.txt_Date
        If status = 1 Then
            strDateY = (strDate.Substring(0, 4) - 1) & cbMouth.SelectedValue.ToString
        Else
            strDateY = (strDate.Substring(0, 4) - 1) & cbMouth.SelectedValue.ToString
        End If
        dST.Clear()
        sCommand.CommandText = "SELECT SUM(TotalNet) AS TotalNet FROM vSmSaleMt WHERE (SUBSTRING(DateSale, 1, 6) = '" & strDateY & "')"
        sAdapter.Fill(dST)
        SumTotalNetY = dST.Rows(0).Item("TotalNet")
        txtdatey = Mouth(CInt(strDateY.Substring(4, 2)) - 1) & "/" & strDateY.Substring(0, 4)
        lb_Y.Text = "ยอดขาย " & txtdatey
        txt_TotalNetY.Text = Format(dST.Rows(0).Item("TotalNet"), "###,###,##0.00")
        Dim dateM As String = String.Format("{0,2}", cbMouth.SelectedValue.ToString - 1)
        dateM = dateM.Replace(" ", "0")
        If status = 1 Then
            If cbMouth.SelectedValue = "01" Then
                strDateM = (strDate.Substring(0, 4) - 1) & "12"
            Else
                strDateM = strDate.Substring(0, 4) & dateM
            End If
        Else
            If cbMouth.SelectedValue = "01" Then
                strDateM = (strDate.Substring(0, 4) - 1) & "12"
            Else
                strDateM = strDate.Substring(0, 4) & dateM
            End If

        End If
        'strDateM = strDate
        dST.Clear()
        sCommand.CommandText = "SELECT SUM(TotalNet) AS TotalNet FROM vSmSaleMt WHERE (SUBSTRING(DateSale, 1, 6) = '" & strDateM & "')"
        sAdapter.Fill(dST)
        If dST.Rows(0).Item("TotalNet") Is DBNull.Value Then
            SumTotalNetM = 0
            txtdatem = Mouth(CInt(strDateM.Substring(4, 2)) - 1) & "/" & strDateM.Substring(0, 4)
            lb_M.Text = "ยอดขาย " & txtdatem
            txt_TotalNetM.Text = "0.00"
        Else
            SumTotalNetM = dST.Rows(0).Item("TotalNet")
            txtdatem = Mouth(CInt(strDateM.Substring(4, 2)) - 1) & "/" & strDateM.Substring(0, 4)
            lb_M.Text = "ยอดขาย " & txtdatem
            txt_TotalNetM.Text = Format(dST.Rows(0).Item("TotalNet"), "###,###,##0.00")
        End If
        If status = 1 Then
            Dim MDate As String = String.Format("{0,2}", cbMouth.SelectedValue.ToString)
            MDate = MDate.Replace(" ", "0")
            strDate = strDateM.Substring(0, 4) & MDate
        End If
        Load_Data()
    End Sub
    Private Sub Load_Data()
        'If txt_YM.Text = "" Then
        '    MessageBox.Show("กรุณาเลือกเดือน/ปี")
        '    Exit Sub
        'End If
        mdLoadShow()
        Dim vWhere As String = ""
        vWhere = "Where s.YM = '" & strDate & "'"
        Dim dMk As New DataTable
        dMk.Clear()
        sCommand.CommandText = "SELECT s.Target FROM SmMkTarget as s " & vWhere & " AND s.idComp = " & sIdComp
        sAdapter.Fill(dMk)
        If dMk.Rows.Count <> 0 Then
            'txt_Target.Text = dMk.Rows(0).Item("Target")
            txt_Target.Text = FormatNumber(dMk.Rows(0).Item("Target"), , TriState.True)
        ElseIf dMk.Rows.Count = 0 Then
            txt_Target.Text = ""
            'MessageBox.Show("ไม่มีข้อมูล")
        End If
        Dim dMkP As New DataTable
        dMkP.Clear()
        sCommand.CommandText = "SELECT s.idPdT, s.Target, s.TargetKg, v.PdTradeName FROM SmMkTargetPd as s INNER JOIN vSlPdTradeNameD as v ON s.idPdT = v.idPdT " & vWhere & " AND s.idComp = " & sIdComp
        sAdapter.Fill(dMkP)
        DGV_MK.DataSource = dMkP
        Dim dST As New DataTable
        Dim sumtotalnet As Double
        For i As Integer = 0 To DGV_MK.Rows.Count - 1
            Dim a As Integer = DGV_MK.Rows(i).Cells(colidPdT.Name).Value
            dST.Clear()
            sCommand.CommandText = "Select vPPS.idPdT,vPPS.PdPkName AS Data,(SSD.Amount * SSD.Price) AS TotalNet,SSD.idPkUnit,SSD.Perbox From vSmSaleMt vSSM,SmSaleDt SSD,vPackingPdSet vPPS WHERE vSSM.idSale = SSD.idSale AND SSD.idPdPk = vPPS.idPdPk AND substring(vSSM.DateSale,1,6) = '" & strDateY & "' AND vPPS.idPdT = " & DGV_MK.Rows(i).Cells(colidPdT.Name).Value & " AND vSSM.idComp = " & sIdComp
            sAdapter.Fill(dST)
            sumtotalnet = 0
            For j As Integer = 0 To dST.Rows.Count - 1
                If dST.Rows(j).Item("idPkUnit") = 3 Then
                    sumtotalnet += dST.Rows(j).Item("TotalNet") * dST.Rows(j).Item("Perbox")
                Else
                    sumtotalnet += dST.Rows(j).Item("TotalNet")
                End If
            Next
            DGV_MK.Rows(i).Cells(colPayY.Name).Value = sumtotalnet
            dST.Clear()
            sCommand.CommandText = "Select vPPS.idPdT,vPPS.PdPkName AS Data,(SSD.Amount * SSD.Price) AS TotalNet,SSD.idPkUnit,SSD.Perbox From vSmSaleMt vSSM,SmSaleDt SSD,vPackingPdSet vPPS WHERE vSSM.idSale = SSD.idSale AND SSD.idPdPk = vPPS.idPdPk AND substring(vSSM.DateSale,1,6) = '" & strDateM & "' AND vPPS.idPdT = " & DGV_MK.Rows(i).Cells(colidPdT.Name).Value & " AND vSSM.idComp = " & sIdComp
            sAdapter.Fill(dST)
            sumtotalnet = 0
            For j As Integer = 0 To dST.Rows.Count - 1
                If dST.Rows(j).Item("idPkUnit") = 3 Then
                    sumtotalnet += dST.Rows(j).Item("TotalNet") * dST.Rows(j).Item("Perbox")
                Else
                    sumtotalnet += dST.Rows(j).Item("TotalNet")
                End If
            Next
            DGV_MK.Rows(i).Cells(colPayM.Name).Value = sumtotalnet
        Next
        mdLoadCommitt()
    End Sub
    Private Sub btn_addPdT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addPdT.Click
        Dim vWhere As String = ""
        Dim frm_s As New frmPdTSerach(frmPdTSerach.eProcess.eMul)
        frm_s.getDGV(DGV_MK)
        frm_s.ShowDialog()
        If frm_s.strPdT <> "" Then
            mdLoadShow()
            vWhere = "Where v.idPdT IN (" & frm_s.strPdT & ")"
            mdCnOpen()
            Dim dPdT As New DataTable
            sCommand.CommandText = "Select v.idPdT ,v.PdTradeName ,s.Target ,s.TargetKg FROM vSlPdTradeNameD as v LEFT JOIN SmMkTargetPd as s ON v.idPdT = s.idPdT  AND substring(s.YM,1,6) = '" & strDate & "'  " & vWhere & " Order by PdTradeName ASC"
            sAdapter.Fill(dPdT)
            DGV_MK.DataSource = dPdT
            Dim dST As New DataTable
            Dim sumtotalnet As Double
            For i As Integer = 0 To DGV_MK.Rows.Count - 1
                Dim a As Integer = DGV_MK.Rows(i).Cells(colidPdT.Name).Value
                dST.Clear()
                sCommand.CommandText = "Select vPPS.idPdT,vPPS.PdPkName AS Data,(SSD.Amount * SSD.Price) AS TotalNet,SSD.idPkUnit,SSD.Perbox From vSmSaleMt vSSM,SmSaleDt SSD,vPackingPdSet vPPS WHERE vSSM.idSale = SSD.idSale AND SSD.idPdPk = vPPS.idPdPk AND substring(vSSM.DateSale,1,6) = '" & strDateY & "' AND vPPS.idPdT = " & DGV_MK.Rows(i).Cells(colidPdT.Name).Value & " AND vSSM.idComp = " & sIdComp
                sAdapter.Fill(dST)
                sumtotalnet = 0
                For j As Integer = 0 To dST.Rows.Count - 1
                    If dST.Rows(j).Item("idPkUnit") = 3 Then
                        sumtotalnet += dST.Rows(j).Item("TotalNet") * dST.Rows(j).Item("Perbox")
                    Else
                        sumtotalnet += dST.Rows(j).Item("TotalNet")
                    End If
                Next
                DGV_MK.Rows(i).Cells(colPayY.Name).Value = sumtotalnet
                dST.Clear()
                sCommand.CommandText = "Select vPPS.idPdT,vPPS.PdPkName AS Data,(SSD.Amount * SSD.Price) AS TotalNet,SSD.idPkUnit,SSD.Perbox From vSmSaleMt vSSM,SmSaleDt SSD,vPackingPdSet vPPS WHERE vSSM.idSale = SSD.idSale AND SSD.idPdPk = vPPS.idPdPk AND substring(vSSM.DateSale,1,6) = '" & strDateM & "' AND vPPS.idPdT = " & DGV_MK.Rows(i).Cells(colidPdT.Name).Value & " AND vSSM.idComp = " & sIdComp
                sAdapter.Fill(dST)
                sumtotalnet = 0
                For j As Integer = 0 To dST.Rows.Count - 1
                    If dST.Rows(j).Item("idPkUnit") = 3 Then
                        sumtotalnet += dST.Rows(j).Item("TotalNet") * dST.Rows(j).Item("Perbox")
                    Else
                        sumtotalnet += dST.Rows(j).Item("TotalNet")
                    End If
                Next
                DGV_MK.Rows(i).Cells(colPayM.Name).Value = sumtotalnet
            Next
        End If
        mdLoadCommitt()
    End Sub

    Private Sub DGV_MK_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGV_MK.DataError
        If StrComp(e.Exception.Message, "Input string was not in a correct format.") = 0 Then
            MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", sSystemName)
            'This will change the number back to original
            DGV_MK.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
        End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim sumtarget As Double = 0
        If txt_Target.Text = "" Then
            MessageBox.Show("กรุณาระบุเป้ายอดขาย")
            Exit Sub
        End If
        Dim target As Double = txt_Target.Text.Replace(",", String.Empty)
        If DGV_MK.Rows.Count > 0 Then
            For i As Integer = 0 To DGV_MK.Rows.Count - 1
                'If DGV_MK.Rows(i).Cells(colTarget.Name).Value Is DBNull.Value Then

                'End If
                If DGV_MK.Rows(i).Cells(colTarget.Name).Value Is DBNull.Value And DGV_MK.Rows(i).Cells(colTargetKg.Name).Value Is DBNull.Value Then
                    MessageBox.Show("กรุณาเป้ายอดขายสินค้า อย่างใดอย่างหนึ่ง")
                    Exit Sub
                Else
                    If DGV_MK.Rows(i).Cells(colTarget.Name).Value Is DBNull.Value Then
                        sumtarget += 0
                    Else
                        sumtarget += DGV_MK.Rows(i).Cells(colTarget.Name).Value
                    End If
                End If
            Next
        End If
        If txt_Target.Text < sumtarget Then
            MessageBox.Show("เป้ายอดขายรวม น้อยกว่า เป้ายอดขายสินค้า")
            Exit Sub
        End If
        Dim dMk As New DataTable
        dMk.Clear()
        sCommand.CommandText = "SELECT s.Target FROM SmMkTarget as s Where s.YM = '" & strDate & "'" & " AND s.idComp = " & sIdComp
        sAdapter.Fill(dMk)
        If dMk.Rows.Count > 0 Then
            MessageBox.Show("เป้ายอดขายเดือน " & cbMouth.SelectedText.ToString & "มีการบันทึกแล้ว")
            Exit Sub
        End If
        If MessageBox.Show("ต้องการบันทึกข้อมูลหรือไม่", "บันทึกข้อมูล", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            sCommand.CommandText = "DELETE FROM SmMkTarget WHERE YM= '" & strDate & "' AND idComp = " & sIdComp
            sCommand.ExecuteNonQuery()
            sCommand.CommandText = "INSERT INTO  SmMkTarget (YM,Target,idComp) VALUES ('" & strDate & "'," & target & "," & sIdComp & ")"
            sCommand.ExecuteNonQuery()
            sCommand.CommandText = "DELETE FROM SmMkTargetPd WHERE YM= '" & strDate & "' AND idComp = " & sIdComp
            sCommand.ExecuteNonQuery()
            For i As Integer = 0 To DGV_MK.Rows.Count - 1
                Dim t, tKg As Double
                If DGV_MK.Rows(i).Cells(colTarget.Name).Value Is DBNull.Value Then
                    t = 0
                Else
                    t = DGV_MK.Rows(i).Cells(colTarget.Name).Value
                End If
                If DGV_MK.Rows(i).Cells(colTargetKg.Name).Value Is DBNull.Value Then
                    tKg = 0
                Else
                    tKg = DGV_MK.Rows(i).Cells(colTargetKg.Name).Value
                End If
                sCommand.CommandText = "INSERT INTO  SmMkTargetPd (YM,idPdT,Target,idComp,TargetKg) VALUES ('" & strDate & "'," & DGV_MK.Rows(i).Cells(colidPdT.Name).Value & "," & t & "," & sIdComp & "," & tKg & ")"
                sCommand.ExecuteNonQuery()
            Next
            MessageBox.Show("บันทึกเรียบร้อยแล้ว")
            Load_Data()
        Else
            Exit Sub
        End If
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub DGV_MK_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_MK.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If DGV_MK.Columns(e.ColumnIndex).Name = coldel.Name Then
            DGV_MK.Rows.RemoveAt(e.RowIndex)
            DGV_MK.Refresh()
        End If
    End Sub

    Private Sub txt_Target_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Target.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข")
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
    Dim vSTY As New DataView
    Dim vSTM As New DataView
    Dim SumTotalNetY As Double
    Dim SumTotalNetM As Double
    Dim txtdatey As String
    Dim txtdatem As String
    Private Sub btn_YM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dST As New DataTable
        dST.Clear()
        Dim frm As New frmMYSelect(frmMYSelect.eProcess.eYM)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            btn_addPdT.Enabled = True
            btn_save.Enabled = True
            txt_Target.Enabled = True
            strDate = frm.str_Date
            'txt_YM.Text = frm.txt_Date
            strDateY = frm.str_DateY
            dST.Clear()
            sCommand.CommandText = "SELECT SUM(TotalNet) AS TotalNet FROM vSmSaleMt WHERE (SUBSTRING(DateSale, 1, 6) = '" & strDateY & "')"
            sAdapter.Fill(dST)
            SumTotalNetY = dST.Rows(0).Item("TotalNet")
            txtdatey = frm.txt_DateY
            lb_Y.Text = "ยอดขาย " & frm.txt_DateY
            txt_TotalNetY.Text = Format(dST.Rows(0).Item("TotalNet"), "###,###,##0.00")
            strDateM = frm.str_DateM
            dST.Clear()
            sCommand.CommandText = "SELECT SUM(TotalNet) AS TotalNet FROM vSmSaleMt WHERE (SUBSTRING(DateSale, 1, 6) = '" & strDateM & "')"
            sAdapter.Fill(dST)
            SumTotalNetM = dST.Rows(0).Item("TotalNet")
            txtdatem = frm.txt_DateM
            lb_M.Text = "ยอดขาย " & frm.txt_DateM
            txt_TotalNetM.Text = Format(dST.Rows(0).Item("TotalNet"), "###,###,##0.00")
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
    Private Sub txt_Target_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Target.TextChanged
        NumberFormat(txt_Target)
        If txt_Target.Text <> "" Then
            Dim target As Double = txt_Target.Text.Replace(",", String.Empty)
            'txt_Target.Text = FormatNumber(target, 0)
            Dim PerY As Double = ((target - SumTotalNetY) / SumTotalNetY) * 100
            Dim PerM As Double = ((target - SumTotalNetM) / SumTotalNetM) * 100
            lb_PerY.Text = "เปอร์เซ็นส่วนต่างยอดขาย " & txtdatey
            txt_PerY.Text = Format(PerY, "##0.00") & " %"
            lb_PerM.Text = "เปอร์เซ็นส่วนต่างยอดขาย " & txtdatem
            txt_PerM.Text = Format(PerM, "##0.00") & " %"
        End If
    End Sub

    Private Sub cbMouth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMouth.SelectedIndexChanged
        If chkstart Then
            Load_Data2()
        End If

    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        If MessageBox.Show("ต้องการลบข้อมูลหรือไม่", "บันทึกข้อมูล", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            sCommand.CommandText = "DELETE FROM SmMkTarget WHERE YM= '" & strDate & "' AND idComp = " & sIdComp
            sCommand.ExecuteNonQuery()
            sCommand.CommandText = "DELETE FROM SmMkTargetPd WHERE YM= '" & strDate & "' AND idComp = " & sIdComp
            sCommand.ExecuteNonQuery()
            MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว")
        Else
            Exit Sub
        End If
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class