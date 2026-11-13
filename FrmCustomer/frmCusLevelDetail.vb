Public Class frmCusLevelDetail
    Dim wtype As Integer
    Dim pname As String
    Dim pnote As String
    Dim prprice As String
    Dim pbprice As String
    Dim pwprice As String
    Dim pIdType As String

    Public Sub Get_Type(ByVal type As Integer)
        wtype = type
    End Sub

    Public Sub Get_Value(ByVal Id As String, ByVal name As String, ByVal note As String, ByVal pr As String, ByVal pb As String, ByVal pw As String, ByVal Cr As String)
        pname = name
        pnote = note
        prprice = pr
        pbprice = pb
        pwprice = pw
        pIdType = Id
        txtname.Text = pname
        txtnote.Text = pnote
        txtpr.Text = prprice
        txtpb.Text = pbprice
        txtpw.Text = pwprice
        txtCreditTotal.Text = Cr
    End Sub

    Sub mdLoadShow()

    End Sub
    Sub mdLoadCommitt()

    End Sub
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        mdLoadShow()
        mdCnOpen()
        Dim prvalue As Double
        Dim pbvalue As Double
        Dim pwvalue As Double

        If txtpr.Text = "" Then
            prvalue = 0
        Else
            prvalue = CType(txtpr.Text, Double)
        End If
        If txtpb.Text = "" Then
            pbvalue = 0
        Else
            pbvalue = CType(txtpb.Text, Double)
        End If
        If txtpw.Text = "" Then
            pwvalue = 0
        Else
            pwvalue = CType(txtpw.Text, Double)
        End If
        If wtype = 1 Then
            If check_name() And check_empty() Then
                sCommand.CommandText = "INSERT INTO dCusType (CusType, Note, PriceRetail, PriceBill, PriceWholeSale, CreditTotal) VALUES ('" + txtname.Text + "','" + txtnote.Text + "','" + prvalue.ToString + "','" + pbvalue.ToString + "','" + pwvalue.ToString + "', '" & txtCreditTotal.Text & "')"
                sCommand.ExecuteNonQuery()
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                If check_name() Then
                Else
                    MessageBox.Show("ชื่อระดับซ้ำ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                If txtname.Text = "" Then
                    MessageBox.Show("กรุณาใส่ชื่อระดับ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                If txtnote.Text = "" Then
                    MessageBox.Show("กรุณาใส่คำอธิบายระดับ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                If txtCreditTotal.Text = "" Then
                    MessageBox.Show("กรุณาใส่ค่าวงเงินเครดิต", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Else
            If txtCreditTotal.Text = "" Then
                MessageBox.Show("กรุณาใส่ค่าวงเงินเครดิต", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If check_name2() And check_empty() Then
                sCommand.CommandText = "UPDATE dCusType SET CusType='" + txtname.Text + "', Note='" + txtnote.Text + "', PriceRetail='" + prvalue.ToString + "', PriceBill='" + pbvalue.ToString + "', PriceWholeSale='" + pwvalue.ToString + "', CreditTotal='" & Replace(txtCreditTotal.Text, ",", "") & "' WHERE idCusType =  " + pIdType
                sCommand.ExecuteNonQuery()
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                If check_name2() Then
                Else
                    MessageBox.Show("ชื่อระดับซ้ำ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                If txtname.Text = "" Then
                    MessageBox.Show("กรุณาใส่ชื่อระดับ", "SAM", MessageBoxButtons.OK,MessageBoxIcon.Warning)
                End If
                If txtnote.Text = "" Then
                    MessageBox.Show("กรุณาใส่คำอธิบายระดับ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
        mdLoadCommitt()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim answer As DialogResult
        Dim sDt_temp As New DataTable

        
        If wtype = 1 Then
            Me.Close()
        Else
            answer = MessageBox.Show("คุณต้องการลบระดับนี้ ใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = vbYes Then
                mdLoadShow()
                mdCnOpen()
                sCommand.CommandText = "DELETE FROM dCusType WHERE idCusType = " + pIdType
                If wtype <> 1 Then
                    mdLoadShow()
                    mdCnOpen()
                    sDt_temp.Clear()
                    sCommand.CommandText = "Select COUNT(*) FROM dCustomer WHERE idCusType =" + pIdType
                    sAdapter.Fill(sDt_temp)
                    If sDt_temp.Rows(0).Item(0) = 0 Then
                        sCommand.ExecuteNonQuery()
                        MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        MessageBox.Show("ไม่สามารถลบข้อมูลนี้ได้เนื่องจาก" & Environment.NewLine & "  -  ข้อมูลถุกนำไปใช้แล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
                
                mdLoadCommitt()
            End If
        End If

    End Sub

    Private Sub txtpw_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpw.Leave
        Dim value As Double
        If txtpw.Text = "" Then
            Exit Sub
        Else
            value = CType(txtpw.Text, Double)
        End If
        If value > 100 Or value < 0 Then
            MessageBox.Show("% ราคาไม่สามารถเกิน 100 หรือน้อยกว่า 0 ได้")
            txtpw.Focus()
        End If
    End Sub

    Private Sub txtpw_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpw.KeyPress
        If CheckDigitOnly(Asc(e.KeyChar)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtpb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpb.Leave
        Dim value As Double
        If txtpb.Text = "" Then
            Exit Sub
        Else
            value = CType(txtpb.Text, Double)
        End If
        If value > 100 Or value < 0 Then
            MessageBox.Show("% ราคาไม่สามารถเกิน 100 หรือน้อยกว่า 0 ได้")
            txtpb.Focus()
        End If
    End Sub

    Private Sub txtpb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpb.KeyPress
        If CheckDigitOnly(Asc(e.KeyChar)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtpr_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpr.Leave
        Dim value As Double
        If txtpr.Text = "" Then
            Exit Sub
        Else
            value = CType(txtpr.Text, Double)
        End If
        If value > 100 Or value < 0 Then
            MessageBox.Show("% ราคาไม่สามารถเกิน 100 หรือน้อยกว่า 0 ได้")
            txtpr.Focus()
        End If
    End Sub

    Private Sub txtpr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpr.KeyPress
        If CheckDigitOnly(Asc(e.KeyChar)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub frmCusLevelDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim sDt_temp As New DataTable

        'If wtype <> 1 Then
        '    mdLoadShow()
        '    mdCnOpen()
        '    sDt_temp.Clear()
        '    sCommand.CommandText = "Select COUNT(*) FROM dCustomer WHERE idCusType =" + pIdType
        '    sAdapter.Fill(sDt_temp)
        '    If sDt_temp.Rows(0).Item(0) = 0 Then
        '        btn_save.Enabled = True
        '        btn_delete.Enabled = True
        '    Else
        '        'Label6.Visible = True
        '        'btn_delete.Enabled = False
        '    End If
        '    mdLoadCommitt()
        'Else
        '    btn_save.Enabled = True
        '    btn_delete.Text = "ยกเลิก"
        'End If
        
    End Sub
    Function check_empty() As Boolean
        If txtname.Text = "" Or txtnote.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Function check_name() As Boolean
        Dim sDt_temp2 As New DataTable
        mdCnOpen()
        sCommand.CommandText = "Select COUNT(*) FROM dCusType WHERE  CusType = '" + txtname.Text + "'"
        sAdapter.Fill(sDt_temp2)
        If sDt_temp2.Rows(0).Item(0) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function check_name2() As Boolean
        Dim sDt_temp2 As New DataTable
        mdCnOpen()
        sCommand.CommandText = "Select COUNT(*) FROM dCusType WHERE  CusType = '" + txtname.Text + "' AND idCusType <> " + pIdType
        sAdapter.Fill(sDt_temp2)
        If sDt_temp2.Rows(0).Item(0) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtCreditTotal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCreditTotal.KeyPress
        If CheckDigitOnly(Asc(e.KeyChar)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
End Class