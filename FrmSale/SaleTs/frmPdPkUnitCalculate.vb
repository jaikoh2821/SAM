Public Class frmPdPkUnitCalculate
    Dim idPkPd As String
    Dim PdWeight As Double = 0
    Dim UnitW As Integer
    Public PdAmount As Integer = 0
    ' Public PdUnit As Integer = 0
    Dim PdUnit As Integer
    Dim Perboxs As Integer
    Dim WeightReq As Integer

    Public Sub ShowText(ByVal Pdidpk As String, ByVal UnitPk As Integer, ByVal Perbox As Integer)
        idPkPd = Pdidpk
        PdUnit = UnitPk
        Perboxs = Perbox
    End Sub

    Public Sub ShowTextSlOrder(ByVal Pdidpk As String, ByVal UnitPk As Integer, ByVal Perbox As Integer, ByVal AmtWeight As Integer)
        idPkPd = Pdidpk
        PdUnit = UnitPk
        Perboxs = Perbox
        WeightReq = AmtWeight
    End Sub

    Private Sub frmPdPkUnitCalculate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idPdPk, PdPkName, Weight, idUnitW, PkUnitName, idPkUnit, Perbox From vPackingPdSet Where idPdPk='" & idPkPd & "'"
        sAdapter.Fill(sDt)
        If sDt.Rows.Count <> 0 Then
            Me.lblPdPkName.Text = Trim(sDt.Rows(0).Item("PdPkName"))
            Me.lblUnit.Text = Trim(sDt.Rows(0).Item("PkUnitName"))
            Me.lblUnit.Tag = Trim(sDt.Rows(0).Item("idPkUnit"))
            Me.lblUnitUp.Text = Trim(sDt.Rows(0).Item("PkUnitName"))
            Me.lblUnitDown.Text = Trim(sDt.Rows(0).Item("PkUnitName"))
            If IsDBNull(sDt.Rows(0).Item("Perbox")) Then
                Me.lblPerbox.Text = Perboxs
            Else
                Me.lblPerbox.Text = Trim(sDt.Rows(0).Item("Perbox"))
            End If

            Me.lblUnitPerbox.Text = Trim(sDt.Rows(0).Item("PkUnitName"))
            UnitW = sDt.Rows(0).Item("idUnitW")
            PdWeight = sDt.Rows(0).Item("Weight")
            Me.txtAmount.Text = Format(0, "#,##0.00")
            If PdUnit = 5 Then 'หน่วยเป็นกิโล
                Dim Kg As Double = 0
                If UnitW = 1 Then
                    Kg = PdWeight / 1000
                Else
                    Kg = PdWeight
                End If
                Me.txtWeight.Text = Format(WeightReq, "#,##0.00")
                Me.txtAmount.Text = Format(CDbl(Me.txtWeight.Text) / Kg, "#,##0.00")
                If CDbl(Me.lblPerbox.Text) = 0 Then
                    Me.txtBox.Text = "-"
                Else
                    Me.txtBox.Text = CDbl(Me.txtAmount.Text) / CDbl(Me.lblPerbox.Text)
                    Me.txtBox.Text = Format(CDbl(Me.txtBox.Text), "#,##0.00")
                End If

            End If

            '---Cal weight/box---'
            Dim Wkg As Double = 0
            If UnitW = 1 Then
                Wkg = PdWeight / 1000
            Else
                Wkg = PdWeight
            End If
            Me.lblWeightBox.Text = Format(Wkg * CDbl(Me.lblPerbox.Text), "#,##0.00")
        End If
        'Me.txtWeight.Text = 0
        mdLoadCommitt()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If PdUnit = 3 Then 'กล่อง
            If Microsoft.VisualBasic.Right(Me.txtBox.Text, 2) <> "00" Then
                If Me.rdbUp.Checked = True Then
                    PdAmount = Me.lblAmtUp.Text
                ElseIf Me.rdbDown.Checked = True Then
                    PdAmount = Me.lblAmtDown.Text
                End If
            Else
                PdAmount = Me.txtBox.Text
            End If
        ElseIf PdUnit = 1 Or PdUnit = 2 Or PdUnit = 4 Or PdUnit = 6 Then
            If Microsoft.VisualBasic.Right(Me.txtAmount.Text, 2) <> "00" Then
                If Me.rdbUp.Checked = True Then
                    PdAmount = Me.lblAmtUp.Text
                ElseIf Me.rdbDown.Checked = True Then
                    PdAmount = Me.lblAmtDown.Text
                End If
            Else
                PdAmount = Me.txtAmount.Text
            End If
        Else
            PdAmount = Me.txtWeight.Text
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtWeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeight.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If

        If e.KeyChar = Chr(Keys.Enter) Then
            If PdUnit = 3 Then 'กล่อง
                If Microsoft.VisualBasic.Right(Me.txtBox.Text, 2) <> "00" Then
                    If Me.rdbUp.Checked = True Then
                        PdAmount = Me.lblAmtUp.Text
                    ElseIf Me.rdbDown.Checked = True Then
                        PdAmount = Me.lblAmtDown.Text
                    End If
                Else
                    PdAmount = Me.txtBox.Text
                End If
            Else 'หน่วยอื่นๆ
                If Microsoft.VisualBasic.Right(Me.txtAmount.Text, 2) <> "00" Then
                    If Me.rdbUp.Checked = True Then
                        PdAmount = Me.lblAmtUp.Text
                    ElseIf Me.rdbDown.Checked = True Then
                        PdAmount = Me.lblAmtDown.Text
                    End If
                Else
                    PdAmount = Me.txtAmount.Text
                End If
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
    End Sub

    Private Sub txtWeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWeight.TextChanged
        If Me.txtWeight.Text = "" Then
            Me.txtWeight.Text = 0
        End If
        mdLoadShow()
        If Me.txtWeight.Text <> "" Then
            Dim Kg As Double = 0
            If UnitW = 1 Then
                Kg = PdWeight / 1000
            Else
                Kg = PdWeight
            End If
            'Me.txtWeight.Text = Format(Me.txtWeight.Text, "#,##0.00")
            Me.txtAmount.Text = Format(CDbl(Me.txtWeight.Text) / Kg, "#,##0.00")
            If CDbl(Me.lblPerbox.Text) = 0 Then
                Me.txtBox.Text = "-"
            Else
                Me.txtBox.Text = CDbl(Me.txtAmount.Text) / CDbl(Me.lblPerbox.Text)
                Me.txtBox.Text = Format(CDbl(Me.txtBox.Text), "#,##0.00")
            End If

            If PdUnit = 3 Then 'กล่อง
                Dim BoxInt As Integer = 0
                Me.txtAmount.Enabled = False
                If Microsoft.VisualBasic.Right(Me.txtBox.Text, 2) <> "00" Then
                    Me.rdbDown.Visible = True
                    Me.rdbUp.Visible = True
                    Me.lblUnitUp.Text = "กล่อง"
                    Me.lblUnitDown.Text = "กล่อง"
                    Me.lblUnitUp.Visible = True
                    Me.lblUnitDown.Visible = True
                    BoxInt = CDbl(Me.txtBox.Text)
                    If CInt(Microsoft.VisualBasic.Right(Me.txtBox.Text, 2)) > 50 Then
                        Me.lblAmtUp.Text = Format(BoxInt, "#,##0")
                        Me.lblAmtDown.Text = Format(BoxInt - 1, "#,##0")
                    Else
                        Me.lblAmtUp.Text = Format(BoxInt + 1, "#,##0")
                        Me.lblAmtDown.Text = Format(BoxInt, "#,##0")
                    End If
                    Me.lblAmtUp.Visible = True
                    Me.lblAmtDown.Visible = True
                End If
            ElseIf PdUnit = 1 Or PdUnit = 2 Or PdUnit = 4 Or PdUnit = 6 Then
                Dim AmtInt As Integer = 0
                Me.txtBox.Enabled = False
                If Microsoft.VisualBasic.Right(Me.txtAmount.Text, 2) <> "00" Then
                    Me.rdbDown.Visible = True
                    Me.rdbUp.Visible = True
                    'Me.lblUnitUp.Text = "กระป๋อง"
                    'Me.lblUnitDown.Text = "กระป๋อง"
                    Me.lblUnitUp.Visible = True
                    Me.lblUnitDown.Visible = True
                    AmtInt = CDbl(Me.txtWeight.Text) / Kg
                    If CInt(Microsoft.VisualBasic.Right(Me.txtAmount.Text, 2)) > 50 Then
                        Me.lblAmtUp.Text = Format(AmtInt, "#,##0")
                        Me.lblAmtDown.Text = Format(AmtInt - 1, "#,##0")
                    Else
                        Me.lblAmtUp.Text = Format(AmtInt + 1, "#,##0")
                        Me.lblAmtDown.Text = Format(AmtInt, "#,##0")
                    End If

                    Me.lblAmtUp.Visible = True
                    Me.lblAmtDown.Visible = True
                End If

                If Perboxs = 0 Then
                    Me.txtBox.Text = "-"
                End If
            End If
        End If
        mdLoadCommitt()
    End Sub
End Class