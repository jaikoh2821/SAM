Public Class frmSlPdoDetail
    Dim idPdO_ As String = ""
    Dim dtComboType As New DataTable

    Private Sub frmSlPdoDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If idPdO_ = "" Then
            ShowDataOnCombo()
            fnSetForm(5)
            PnPlasticPrice.Enabled = False
            PnOther.Enabled = False
            PnNote.Enabled = False
            btnDel.Visible = False
        Else
            cmb_ProductType.Enabled = False
            btnDel.Visible = True
        End If
    End Sub

#Region "ComBoBox"
    Private Sub ShowDataOnCombo()
        mdCnOpen()
        dtComboType.Clear()

        sCommand.CommandText = "SELECT idPdoType, PdoTypeName, case when idPdoType = 1 then 0 else 1 end as sort FROM SmPdOtherTypeD ORDER BY sort"
        sAdapter.Fill(dtComboType)

        cmb_ProductType.DataSource = dtComboType
        cmb_ProductType.ValueMember = "idPdoType"          'เก็บค่า ลงฐานข้อมูล
        cmb_ProductType.DisplayMember = "PdoTypeName"     'นำข้อมูลในฐานข้อมูลมาแสดง

        Dim ComboSearch As New AutoCompleteStringCollection
        Dim ComboAddValue As String

        For i As Integer = 0 To dtComboType.Rows.Count - 1 'นับแถวในฐานข้อมูล
            ComboAddValue = dtComboType.Rows.Item(i).Item("PdoTypeName").ToString().Trim()  'ช่วยในการค้นหาจากการพิมพ์ข้อมูลผ่าน Combobox และเลือก Combobox 
            ComboSearch.Add(ComboAddValue)
        Next

        cmb_ProductType.AutoCompleteMode = AutoCompleteMode.Suggest
        cmb_ProductType.AutoCompleteSource = AutoCompleteSource.CustomSource
        cmb_ProductType.AutoCompleteCustomSource = ComboSearch
    End Sub

    Private Sub cmb_ProductType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_ProductType.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dv As New DataView(dtComboType)
            dv.RowFilter = "PdoTypeName='" & cmb_ProductType.Text.ToString.Trim & "'"
            If dv.Count = 0 Then
                MessageBox.Show("ประเภทสินค้าผิดรูปแบบ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmb_ProductType.Focus()
                cmb_ProductType.DroppedDown = True
                Exit Sub
            End If
            cmb_ProductType.SelectedValue = dv.Item(0).Item("idPdoType")
        End If
    End Sub

    Private Sub cmb_ProductType_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ProductType.SelectionChangeCommitted
        fnSetForm(sender.SelectedValue)
    End Sub

    Private Sub fnSetForm(ByVal cmbPdTypeSelectedValue As Integer)
        Select Case cmbPdTypeSelectedValue
            Case 3
                PnPlasticPrice.Visible = True
                PnOther.Visible = False
                Me.Size = New Point(667, 398)
                PnNote.Location = New Point(6, 254)
                GroupBox1.Size = New Point(640, 326)
                ksbControlClearTxt(PnOther, PnPlasticPrice, PnNote)
                cmb_VolumnUnit.Text = ""
                PnPlasticPrice.Enabled = True
                PnOther.Enabled = True
                PnNote.Enabled = True
                cmb_Unit.Visible = False
            Case 2
                PnPlasticPrice.Visible = False
                Label20.Visible = True
                txtVolumnOt.Visible = True
                cmb_VolumnUnit.Visible = True
                PnOther.Visible = True
                'PnOther.Size = New Point(667, 440)
                Me.Size = New Point(668, 344)
                Label20.Location = New Point(38, 40)
                txtVolumnOt.Location = New Point(116, 36)
                cmb_VolumnUnit.Location = New Point(206, 34)
                Label19.Location = New Point(25, 70)
                txtProductTitleOt.Location = New Point(116, 67)
                lbPriceBill.Location = New Point(33, 133)
                txtPriceBillOt.Location = New Point(118, 130)
                lbPerbox.Location = New Point(220, 133) '230 133
                txtPerboxOt.Location = New Point(342, 130)
                lbPricePerbox.Location = New Point(449, 132)
                txtPricePerboxOt.Location = New Point(529, 129)
                PnOther.Size = New Point(629, 162)
                PnNote.Location = New Point(6, 199)
                GroupBox1.Size = New Point(640, 271)
                ksbControlClearTxt(PnOther, PnPlasticPrice, PnNote)
                cmb_VolumnUnit.Text = ""
                lbUnit.Visible = False
                txtUnit.Visible = False
                cbChkPerbox.Visible = False
                txtPerboxOt.Enabled = True
                txtPricePerboxOt.Enabled = True
                PnPlasticPrice.Enabled = True
                PnOther.Enabled = True
                PnNote.Enabled = True
                cmb_Unit.Visible = False
            Case 5
                Label20.Visible = False
                txtVolumnOt.Visible = False
                cmb_VolumnUnit.Visible = False
                PnPlasticPrice.Visible = False
                PnOther.Visible = True
                PnOther.Size = New Point(629, 160)
                Me.Size = New Point(668, 343)
                Label19.Location = New Point(25, 39)
                txtProductTitleOt.Location = New Point(116, 36)
                lbPriceBill.Location = New Point(33, 100)
                txtPriceBillOt.Location = New Point(116, 98)
                lbPerbox.Location = New Point(147, 166)
                'txtPerboxOt.Location = New Point(270, 162)
                lbPricePerbox.Location = New Point(371, 165)
                txtPricePerboxOt.Location = New Point(451, 162)
                PnNote.Location = New Point(6, 197)
                GroupBox1.Size = New Point(640, 270)
                ksbControlClearTxt(PnOther, PnPlasticPrice, PnNote)
                cmb_VolumnUnit.Text = ""
                lbUnit.Location = New Point(223, 100)
                txtUnit.Location = New Point(270, 98)
                lbUnit.Visible = True
                txtUnit.Visible = True
                cmb_Unit.Visible = False
                cbChkPerbox.Location = New Point(33, 131)
                cbChkPerbox.Visible = True
                lbPerbox.Location = New Point(150, 131)
                txtPerboxOt.Location = New Point(270, 129)
                lbPricePerbox.Location = New Point(370, 131)
                txtPricePerboxOt.Location = New Point(450, 129)
                txtPerboxOt.Enabled = False
                txtPricePerboxOt.Enabled = False
                PnPlasticPrice.Enabled = True
                PnOther.Enabled = True
                PnNote.Enabled = True
            Case 6
                Label20.Visible = False
                txtVolumnOt.Visible = False
                cmb_VolumnUnit.Visible = False
                PnPlasticPrice.Visible = False
                PnOther.Visible = True
                PnOther.Size = New Point(629, 120)
                Me.Size = New Point(668, 313)
                Label19.Location = New Point(25, 39)
                txtProductTitleOt.Location = New Point(116, 36)
                lbPriceBill.Location = New Point(33, 100)
                txtPriceBillOt.Location = New Point(116, 98)
                lbPerbox.Location = New Point(147, 166)
                txtPerboxOt.Location = New Point(270, 162)
                lbPricePerbox.Location = New Point(371, 165)
                txtPricePerboxOt.Location = New Point(451, 162)
                PnNote.Location = New Point(6, 166)
                GroupBox1.Size = New Point(640, 240)
                ksbControlClearTxt(PnOther, PnPlasticPrice, PnNote)
                cmb_VolumnUnit.Text = ""
                lbUnit.Location = New Point(223, 100)
                txtUnit.Location = New Point(270, 98)
                lbUnit.Visible = True
                txtUnit.Visible = True
                cmb_Unit.Visible = False
                'cbChkPerbox.Location = New Point(33, 131)
                cbChkPerbox.Visible = False
                cbChkPerbox.Checked = False
                'lbPerbox.Location = New Point(150, 131)
                'txtPerboxOt.Location = New Point(270, 129)
                'lbPricePerbox.Location = New Point(370, 131)
                'txtPricePerboxOt.Location = New Point(450, 129)
                'txtPerboxOt.Enabled = False
                'txtPricePerboxOt.Enabled = False
                PnPlasticPrice.Enabled = True
                PnOther.Enabled = True
                PnNote.Enabled = True

            Case 7
                Label20.Visible = False
                txtVolumnOt.Visible = False
                cmb_VolumnUnit.Visible = False
                PnPlasticPrice.Visible = False
                PnOther.Visible = True
                PnOther.Size = New Point(629, 160)
                Me.Size = New Point(668, 343)
                Label19.Location = New Point(25, 39)
                txtProductTitleOt.Location = New Point(116, 36)
                lbPriceBill.Location = New Point(33, 100)
                txtPriceBillOt.Location = New Point(116, 98)
                lbPerbox.Location = New Point(147, 166)
                'txtPerboxOt.Location = New Point(270, 162)
                lbPricePerbox.Location = New Point(371, 165)
                txtPricePerboxOt.Location = New Point(451, 162)
                PnNote.Location = New Point(6, 197)
                GroupBox1.Size = New Point(640, 270)
                ksbControlClearTxt(PnOther, PnPlasticPrice, PnNote)
                cmb_VolumnUnit.Text = ""
                lbUnit.Location = New Point(223, 100)
                'txtUnit.Location = New Point(270, 98)
                lbUnit.Visible = True
                txtUnit.Visible = False
                cmb_Unit.Visible = True
                cmb_Unit.Location = New Point(270, 98)
                cbChkPerbox.Location = New Point(33, 131)
                cbChkPerbox.Visible = True
                lbPerbox.Location = New Point(150, 131)
                txtPerboxOt.Location = New Point(270, 129)
                lbPricePerbox.Location = New Point(370, 131)
                txtPricePerboxOt.Location = New Point(450, 129)
                txtPerboxOt.Enabled = False
                txtPricePerboxOt.Enabled = False
                PnPlasticPrice.Enabled = True
                PnOther.Enabled = True
                PnNote.Enabled = True
                'Label20.Visible = False
                'txtVolumnOt.Visible = False
                'cmb_VolumnUnit.Visible = False
                'PnPlasticPrice.Visible = False
                'PnOther.Visible = True
                'PnOther.Size = New Point(629, 160)
                'Me.Size = New Point(668, 343)
                'Label19.Location = New Point(25, 39)
                'txtProductTitleOt.Location = New Point(116, 36)
                'lbPriceBill.Location = New Point(33, 100)
                'txtPriceBillOt.Location = New Point(116, 98)
                'lbPerbox.Location = New Point(147, 166)
                'txtPerboxOt.Location = New Point(270, 162)
                'lbPricePerbox.Location = New Point(371, 165)
                'txtPricePerboxOt.Location = New Point(451, 162)
                'PnNote.Location = New Point(6, 197)
                'GroupBox1.Size = New Point(640, 270)
                'ksbControlClearTxt(PnOther, PnPlasticPrice, PnNote)
                'cmb_VolumnUnit.Text = ""
                'lbUnit.Location = New Point(223, 100)
                ''txtUnit.Location = New Point(270, 98)
                'txtUnit.Visible = False
                'cmb_Unit.Visible = True
                'cmb_Unit.Location = New Point(270, 98)
                'lbUnit.Visible = True
                'txtUnit.Visible = True
                'cbChkPerbox.Location = New Point(33, 131)
                'cbChkPerbox.Visible = True
                'lbPerbox.Location = New Point(150, 131)
                'txtPerboxOt.Location = New Point(270, 129)
                'lbPricePerbox.Location = New Point(370, 131)
                'txtPricePerboxOt.Location = New Point(450, 129)
                'txtPerboxOt.Enabled = True
                'txtPricePerboxOt.Enabled = False
                'PnPlasticPrice.Enabled = True
                'PnOther.Enabled = True
                'PnNote.Enabled = True
                'cbChkPerbox.Checked = False
        End Select
    End Sub
#End Region
#Region "SetData"
    Public Sub SetData(ByVal idPdO As String)
        idPdO_ = idPdO
        ShowDataOnCombo()
        Dim DtSetTxt As New DataTable
        DtSetTxt.Clear()
        sCommand.CommandText = "SELECT idPdoType, Look, Grade, PdoName, Phase, Thickness" & _
        ", Title, Width, Long, Weight, Note, Volumn, VolumnUnit, Price, CreditThirty " & _
        ", CreditSixty, Perbox, PricePerbox, Unit FROM SmPdOtherD  Where stDel is null And idPdo=" & idPdO
        sAdapter.Fill(DtSetTxt)

        fnSetForm(DtSetTxt.Rows(0).Item("idPdoType"))
        If DtSetTxt.Rows(0).Item("idPdoType") = 3 Then 'สินค้าพลาสติก
            cmb_ProductType.SelectedValue = DtSetTxt.Rows(0).Item("idPdoType")
            txtLookPt.Text = DtSetTxt.Rows(0).Item("Look")
            txtGradePt.Text = DtSetTxt.Rows(0).Item("Grade")
            txtProductNamePt.Text = DtSetTxt.Rows(0).Item("PdoName")
            txtPhasePt.Text = DtSetTxt.Rows(0).Item("Phase")
            txtThicknessPt.Text = DtSetTxt.Rows(0).Item("Thickness")
            txtProductTitlePt.Text = DtSetTxt.Rows(0).Item("Title")
            txtWidthPt.Text = DtSetTxt.Rows(0).Item("Width")
            txtLongPt.Text = DtSetTxt.Rows(0).Item("Long")
            txtWeightPt.Text = DtSetTxt.Rows(0).Item("Weight")
            txtCashPt.Text = DtSetTxt.Rows(0).Item("Price")
            txtCreditPt30.Text = DtSetTxt.Rows(0).Item("CreditThirty")
            txtCreditPt60.Text = DtSetTxt.Rows(0).Item("CreditSixty")
            txtNote.Text = IIf(IsDBNull(DtSetTxt.Rows(0).Item("Note")), "", DtSetTxt.Rows(0).Item("Note"))
        Else 'สินค้าอื่น ๆ
            
            If (DtSetTxt.Rows(0).Item("idPdoType") = 5 Or DtSetTxt.Rows(0).Item("idPdoType") = 6 Or DtSetTxt.Rows(0).Item("idPdoType") = 7) And IsDBNull(DtSetTxt.Rows(0).Item("Perbox")) Then
                txtPerboxOt.Clear()
                txtPricePerboxOt.Clear()
                cbChkPerbox.Checked = False

                If DtSetTxt.Rows(0).Item("idPdoType") = 7 Then
                    cmb_Unit.Text = DtSetTxt.Rows(0).Item("Unit")
                Else
                    txtUnit.Text = DtSetTxt.Rows(0).Item("Unit")
                End If

                'txtPerboxOt.Enabled = False
                'txtPricePerboxOt.Enabled = False
            ElseIf (DtSetTxt.Rows(0).Item("idPdoType") = 5 Or DtSetTxt.Rows(0).Item("idPdoType") = 7) And Not IsDBNull(DtSetTxt.Rows(0).Item("Perbox")) Then
                If DtSetTxt.Rows(0).Item("idPdoType") = 7 Then
                    cmb_Unit.Text = DtSetTxt.Rows(0).Item("Unit")
                Else
                    txtUnit.Text = DtSetTxt.Rows(0).Item("Unit")
                End If
                cbChkPerbox.Checked = True
                txtPerboxOt.Text = DtSetTxt.Rows(0).Item("Perbox")
                txtPricePerboxOt.Text = DtSetTxt.Rows(0).Item("PricePerbox")
            Else
                txtPerboxOt.Text = IIf(IsDBNull(DtSetTxt.Rows(0).Item("Perbox")), "", DtSetTxt.Rows(0).Item("Perbox"))
                txtPricePerboxOt.Text = IIf(IsDBNull(DtSetTxt.Rows(0).Item("PricePerbox")), "", DtSetTxt.Rows(0).Item("PricePerbox"))
            End If

            cmb_ProductType.SelectedValue = DtSetTxt.Rows(0).Item("idPdoType")
            txtProductNameOt.Text = DtSetTxt.Rows(0).Item("PdoName")
            txtProductTitleOt.Text = DtSetTxt.Rows(0).Item("Title")
            txtVolumnOt.Text = IIf(IsDBNull(DtSetTxt.Rows(0).Item("Volumn")), "", DtSetTxt.Rows(0).Item("Volumn"))
            cmb_VolumnUnit.Text = IIf(IsDBNull(DtSetTxt.Rows(0).Item("VolumnUnit")), "", DtSetTxt.Rows(0).Item("VolumnUnit"))
            txtPriceBillOt.Text = DtSetTxt.Rows(0).Item("Price")
            txtNote.Text = IIf(IsDBNull(DtSetTxt.Rows(0).Item("Note")), "", DtSetTxt.Rows(0).Item("Note"))

        End If

    End Sub
#End Region
#Region "SaveData"
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dv As New DataView(dtComboType)
        dv.RowFilter = "PdoTypeName='" & cmb_ProductType.Text.ToString.Trim & "'"
        If dv.Count = 0 Or cmb_ProductType.SelectedValue = 1 Then
            MessageBox.Show("กรุณาเลือกประเภทสินค้า", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmb_ProductType.Focus()
            cmb_ProductType.DroppedDown = True
            Exit Sub
        End If
        cmb_ProductType.SelectedValue = dv.Item(0).Item("idPdoType")

        Select Case cmb_ProductType.SelectedValue
            Case 3 'สินค้าพลาสติก
                If Not fnChkTxtIsNullOrEmpty(txtProductNamePt, txtLookPt, txtGradePt, txtProductTitlePt, txtWidthPt, txtLongPt, txtWeightPt, txtThicknessPt, txtCashPt, txtCreditPt30, txtCreditPt60) Then
                    Exit Sub
                End If
                If Not fnChkTxtZero(txtWidthPt, txtLongPt, txtWeightPt, txtCashPt, txtCreditPt30, txtCreditPt60) Then
                    Exit Sub
                End If
                ChkTxt_1Space(txtProductTitlePt) 'เช็คค่าว่างซ้ายขวา 1 เคาะ
            Case Else
                If cmb_ProductType.SelectedValue = 2 Then 'ฮอร์โมนพืช
                    If Not fnChkTxtIsNullOrEmpty(txtProductNameOt, txtProductTitleOt, txtVolumnOt, txtPriceBillOt, txtPerboxOt, txtPricePerboxOt) Then
                        Exit Sub
                    End If
                    If Not fnChkTxtZero(txtVolumnOt, txtPriceBillOt, txtPerboxOt, txtPricePerboxOt) Then
                        Exit Sub
                    End If
                    If cmb_VolumnUnit.Text = "" Then
                        MessageBox.Show("กรุณาระบุ หน่วยบรรจุ ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        cmb_VolumnUnit.Focus()
                        cmb_VolumnUnit.DroppedDown = True
                        Exit Sub
                    End If
                Else 'cmb_ProductType.SelectedValue = 5 อื่น ๆ, 6 บริการ, 7 ผลสด

                    If cmb_ProductType.SelectedValue = 7 Then
                        If cmb_Unit.Text = "" Then
                            MessageBox.Show("กรุณาระบุ หน่วยบรรจุ ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            cmb_Unit.Focus()
                            cmb_Unit.DroppedDown = True
                            Exit Sub
                        End If
                        If Not fnChkTxtIsNullOrEmpty(txtProductNameOt, txtProductTitleOt, txtPriceBillOt) Then Exit Sub
                    Else
                        If Not fnChkTxtIsNullOrEmpty(txtProductNameOt, txtProductTitleOt, txtPriceBillOt, txtUnit) Then Exit Sub
                    End If

                    'If Not fnChkTxtZero(txtPriceBillOt) Then Exit Sub

                    If cbChkPerbox.Checked Then
                        If Not fnChkTxtIsNullOrEmpty(txtPerboxOt, txtPricePerboxOt) Then Exit Sub
                        If Not fnChkTxtZero(txtPerboxOt, txtPricePerboxOt) Then Exit Sub
                    End If
                    End If
                ChkTxt_1Space(txtProductTitleOt) 'เช็คค่าว่างซ้ายขวา 1 เคาะ
        End Select

        Dim result As New DialogResult
        If idPdO_ = "" Then 'insert
            Dim DtPdDuplicate As New DataTable
            DtPdDuplicate.Clear()
            sCommand.CommandText = "SELECT COUNT(Title) As cnt FROM SmPdOtherD WHERE Title='" & IIf(cmb_ProductType.SelectedValue = 3, txtProductTitlePt.Text.Trim(), txtProductTitleOt.Text.Trim()) & "'"
            sAdapter.Fill(DtPdDuplicate)
            If DtPdDuplicate.Rows(0).Item("cnt") > 0 Then
                MessageBox.Show("ไม่สามารถเพิ่มข้อมูลสินค้านี้ได้เนื่องจาก" & Environment.NewLine & "- ข้อมูลสินค้านี้มีในระบบแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            result = MessageBox.Show("ต้องการบันทึกข้อมูล ใช่หรือไม่ ?", "SAM", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = Windows.Forms.DialogResult.Yes Then
                mdCnOpen()
                If cmb_ProductType.SelectedValue = 3 Then 'สินค้าพลาสติก
                    sCommand.CommandText = "INSERT INTO SmPdOtherD (idPdoType, Look, Grade, PdoName, Phase " & _
                                   ", Thickness, Title, Width, Long, Weight, Unit, Price " & _
                                   ", CreditThirty, CreditSixty, Note) VALUES (" & cmb_ProductType.SelectedValue & _
                                   ", '" & txtLookPt.Text.Trim() & "', '" & txtGradePt.Text.Trim() & "', '" & txtProductNamePt.Text.Trim() & "' " & _
                                   ", '" & txtPhasePt.Text.Trim() & "', '" & txtThicknessPt.Text.Trim() & "', '" & txtProductTitlePt.Text.Trim() & "'" & _
                                   ", " & txtWidthPt.Text.Trim() & ", " & txtLongPt.Text.Trim() & ", " & txtWeightPt.Text.Trim() & _
                                   ", 'ม้วน', " & txtCashPt.Text.Trim() & ", " & txtCreditPt30.Text.Trim() & ", " & txtCreditPt60.Text.Trim() & ", " & IIf(txtNote.Text.Trim() = "", "NULL", "'" & txtNote.Text.Trim() & "'") & ")"
                Else
                    If cmb_ProductType.SelectedValue = 2 Then 'ฮอร์โมนพืช
                        sCommand.CommandText = "INSERT INTO SmPdOtherD (idPdoType, PdoName, Title, Volumn, VolumnUnit " & _
                                        ", Price, Unit, Perbox, PricePerbox, Note) VALUES (" & cmb_ProductType.SelectedValue & ", '" & txtProductNameOt.Text.Trim() & "'" & _
                                        ", '" & txtProductTitleOt.Text.Trim() & "', " & txtVolumnOt.Text.Trim() & ", '" & cmb_VolumnUnit.Text.Trim() & "', " & txtPriceBillOt.Text.Trim() & ", 'ขวด' " & _
                                        ", " & txtPerboxOt.Text.Trim() & ", " & txtPricePerboxOt.Text.Trim() & ", " & IIf(txtNote.Text.Trim() = "", "NULL", "'" & txtNote.Text.Trim() & "'") & ")"
                    Else 'cmb_ProductType.SelectedValue = 5 อื่น ๆ, 6 บริการ, 7 ผลสด
                        Dim columnPerbox As String = ""
                        Dim valuePerbox As String = ""
                        If cbChkPerbox.Checked Then
                            columnPerbox = ", Perbox, PricePerbox"
                            valuePerbox = ", " & txtPerboxOt.Text.Trim() & ", " & txtPricePerboxOt.Text.Trim()
                        End If
                        Dim unit As String = ""
                        If cmb_ProductType.SelectedValue = 7 Then '7 ผลสด
                            unit = cmb_Unit.Text.Trim()
                        Else '5 อื่น ๆ, 6 บริการ
                            unit = txtUnit.Text.Trim()
                        End If
                        sCommand.CommandText = "INSERT INTO SmPdOtherD (idPdoType, PdoName, Title" & _
                                           ", Price, Unit, Note" & columnPerbox & ") VALUES (" & cmb_ProductType.SelectedValue & ", '" & txtProductNameOt.Text.Trim() & "'" & _
                                           ", '" & txtProductTitleOt.Text.Trim() & "', " & txtPriceBillOt.Text.Trim() & ", '" & unit & "'" & _
                                           ", " & IIf(txtNote.Text.Trim() = "", "NULL", "'" & txtNote.Text.Trim() & "'") & valuePerbox & ")"
                    End If
                End If
                sCommand.ExecuteNonQuery()
                MessageBox.Show("ระบบได้ทำการบันทึกข้อมูลเรียบร้อยแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else 'update
            Dim DtPdDuplicate As New DataTable
            DtPdDuplicate.Clear()
            sCommand.CommandText = "SELECT COUNT(Title) As cnt FROM SmPdOtherD WHERE Title='" & IIf(cmb_ProductType.SelectedValue = 3, txtProductTitlePt.Text.Trim(), txtProductTitleOt.Text.Trim()) & "' And idPdO <> " & idPdO_
            sAdapter.Fill(DtPdDuplicate)

            If DtPdDuplicate.Rows(0).Item("cnt") > 0 Then
                MessageBox.Show("ไม่สามารถแก้ไขข้อมูลนี้ได้เนื่องจาก" & Environment.NewLine & "- ข้อมูลสินค้านี้มีในระบบแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            result = MessageBox.Show("ต้องการบันทึกข้อมูล ใช่หรือไม่ ?", "SAM", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = Windows.Forms.DialogResult.Yes Then
                mdCnOpen()
                If cmb_ProductType.SelectedValue = 3 Then 'สินค้าพลาสติก
                    sCommand.CommandText = "UPDATE SmPdOtherD SET idPdoType=" & cmb_ProductType.SelectedValue & ", Look='" & txtLookPt.Text.Trim() & "', Grade='" & txtGradePt.Text.Trim() & "', PdoName='" & txtProductNamePt.Text.Trim() & "', Phase='" & txtPhasePt.Text.Trim() & "' " & _
                                   ", Thickness='" & txtThicknessPt.Text.Trim() & "', Title='" & txtProductTitlePt.Text.Trim() & "', Width=" & txtWidthPt.Text.Trim() & ", Long=" & txtLongPt.Text.Trim() & ", Weight=" & txtWeightPt.Text.Trim() & _
                                   ", Price=" & txtCashPt.Text.Trim() & ", CreditThirty=" & txtCreditPt30.Text.Trim() & ", CreditSixty=" & txtCreditPt60.Text.Trim() & ", Note=" & IIf(txtNote.Text.Trim() = "", "NULL", "'" & txtNote.Text.Trim() & "'") & _
                                   ", Volumn=NULL, VolumnUnit=NULL, Unit='ม้วน', Perbox=NULL, PricePerbox=NULL WHERE idPdO = " & idPdO_
                Else
                    'ฮอร์โมนพืช cmb_ProductType.SelectedValue = 3
                    Dim CnkUpdate As String = ", Volumn= " & txtVolumnOt.Text.Trim() & ", VolumnUnit='" & cmb_VolumnUnit.Text.Trim() & "', Unit='ขวด', Perbox=" & txtPerboxOt.Text.Trim() & ", PricePerbox=" & txtPricePerboxOt.Text.Trim()
                    'อื่น ๆ หรือ บริการ
                    Dim unit As String = ""
                    If cmb_ProductType.SelectedValue = 7 Then
                        unit = cmb_Unit.Text.Trim()
                    Else
                        unit = txtUnit.Text.Trim()
                    End If
                    If cmb_ProductType.SelectedValue = 5 Or cmb_ProductType.SelectedValue = 6 Or cmb_ProductType.SelectedValue = 7 Then CnkUpdate = ", Volumn=NULL, VolumnUnit=NULL, Unit='" & unit & "'"
                    If cbChkPerbox.Checked = True And (cmb_ProductType.SelectedValue = 5 Or cmb_ProductType.SelectedValue = 7) Then
                        CnkUpdate &= ", Perbox=" & txtPerboxOt.Text.Trim() & ", PricePerbox=" & txtPricePerboxOt.Text.Trim()
                    ElseIf cbChkPerbox.Checked = False And (cmb_ProductType.SelectedValue = 5 Or cmb_ProductType.SelectedValue = 6 Or cmb_ProductType.SelectedValue = 7) Then
                        CnkUpdate &= ", Perbox=NULL, PricePerbox=NULL"
                    End If

                    sCommand.CommandText = "UPDATE SmPdOtherD SET idPdoType=" & cmb_ProductType.SelectedValue & ", PdoName='" & txtProductNameOt.Text.Trim() & "', Title='" & txtProductTitleOt.Text.Trim() & "'" & CnkUpdate & _
                          ", Price=" & txtPriceBillOt.Text.Trim() & ", Note=" & IIf(txtNote.Text.Trim() = "", "NULL", "'" & txtNote.Text.Trim() & "'") & _
                          ", Look=NULL, Grade=NULL, Phase=NULL, Thickness=NULL, Width=NULL, Long=NULL" & _
                          ", Weight=NULL, CreditThirty=NULL, CreditSixty=NULL WHERE idPdO = " & idPdO_
                End If
                sCommand.ExecuteNonQuery()
                MessageBox.Show("ระบบได้ทำการบันทึกข้อมูลเรียบร้อยแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
#End Region
#Region "DeleteData"
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim DtProductUse As New DataTable 'สินค้าที่ถูกนำไปใช้แล้ว
        DtProductUse.Clear()
        sCommand.CommandText = "SELECT COUNT(idPdo) As cnt FROM SmSaleDtOther WHERE idPdO = " & idPdO_
        sAdapter.Fill(DtProductUse)
        If DtProductUse.Rows(0).Item("cnt") > 0 Then
            MessageBox.Show("ไม่สามารถลบข้อมูลนี้ได้เนื่องจาก" & Environment.NewLine & "- ข้อมูลสินค้านี้ถูกนำไปใช้แล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim Result As MsgBoxResult
        Result = MessageBox.Show("คุณต้องการลบข้อมูลนี้ ใช่หรือไม่  ?", "SAM", MessageBoxButtons.YesNo, _
                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If Result = MsgBoxResult.Yes Then
            mdCnOpen()
            sCommand.CommandText = "UPDATE SmPdOtherD SET stDel='1' WHERE idPdO = " & idPdO_ & Environment.NewLine
            sCommand.ExecuteNonQuery()
            MessageBox.Show("ระบบได้ทำการลบข้อมูลเรียบร้อยแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
#End Region
#Region "Even Text"
    Private Sub txtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtThicknessPt.KeyPress, txtWidthPt.KeyPress, txtLongPt.KeyPress, txtWeightPt.KeyPress, txtCashPt.KeyPress, txtCreditPt30.KeyPress, txtCreditPt60.KeyPress, txtVolumnOt.KeyPress, txtCashPt.KeyPress, txtPriceBillOt.KeyPress, txtPerboxOt.KeyPress, txtPricePerboxOt.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub fnChkFullStop_UseInTextChanged(ByVal txtName As TextBox, Optional ByVal PositionFullStop As Integer = 0)
        'เช็คทศนิยม
        If Not String.IsNullOrEmpty(txtName.Text) Then
            If PositionFullStop < 0 Then PositionFullStop = 0
            If txtName.Text.IndexOf(".", 1) And txtName.Text = "." Then
                txtName.Text = txtName.Text.Replace(".", "0.0")
                txtName.Select(2, 1)
                If PositionFullStop < 1 Then txtName.Text = ""
                Exit Sub
            End If

            Dim chknumber As Integer = 0
            For i As Integer = 0 To txtName.TextLength - 1
                If txtName.Text.Chars(i) = "." Then
                    chknumber += 1
                    If i = 0 Then
                        txtName.Text = txtName.Text.Remove(0, 1)
                        Exit For
                    ElseIf chknumber <> 1 Then
                        txtName.Text = txtName.Text.Remove(i, 1)
                        txtName.SelectionStart = txtName.TextLength
                        Try
                            'เซ็ตตำแหน่งทศนิยม 
                            txtName.Text = txtName.Text.Substring(0, (txtName.Text.IndexOf(".") + 1) + PositionFullStop)
                        Catch ex As Exception
                        End Try
                        Exit For
                    End If
                End If
            Next
            'เซ็ตตำแหน่งทศนิยม  
            If txtName.Text.IndexOf(".") <> -1 And (txtName.TextLength - 1 - txtName.Text.IndexOf(".")) > PositionFullStop Then
                txtName.Text = txtName.Text.Substring(0, (txtName.Text.IndexOf(".") + 1) + PositionFullStop)
                txtName.SelectionStart = txtName.TextLength
            End If
            'ตำแหน่ง = 0
            If PositionFullStop = 0 Then
                txtName.Text = txtName.Text.Replace(".", "")
                txtName.SelectionStart = txtName.TextLength
            End If
        End If
    End Sub

    Private Sub SetTxtNameUse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ProductType.TextChanged, txtLookPt.TextChanged, txtGradePt.TextChanged, txtProductNamePt.TextChanged, txtWidthPt.TextChanged, txtLongPt.TextChanged, txtWeightPt.TextChanged, cmb_VolumnUnit.TextChanged, txtProductNameOt.TextChanged, txtVolumnOt.TextChanged, txtPhasePt.TextChanged, txtThicknessPt.TextChanged
        Try
            Select Case cmb_ProductType.SelectedValue
                Case 3
                    txtProductTitlePt.Text = cmb_ProductType.Text.Trim() & IIf(String.IsNullOrEmpty(txtLookPt.Text.Trim()), "", " " & txtLookPt.Text.Trim()) & IIf(String.IsNullOrEmpty(txtGradePt.Text.Trim()), "", " เกรด " & txtGradePt.Text.Trim()) & IIf(String.IsNullOrEmpty(txtProductNamePt.Text.Trim()), "", " " & txtProductNamePt.Text.Trim()) & IIf(String.IsNullOrEmpty(txtWidthPt.Text.Trim()) Or String.IsNullOrEmpty(txtLongPt.Text.Trim()), "", " ขนาด " & txtWidthPt.Text.Trim() & "mX" & txtLongPt.Text.Trim() & "Y") & IIf(String.IsNullOrEmpty(txtWeightPt.Text.Trim()), "", " " & txtWeightPt.Text.Trim() & "กก./ม้วน") & IIf(String.IsNullOrEmpty(txtPhasePt.Text.Trim()), "", " ระยะเจาะรู " & txtPhasePt.Text.Trim() & " CM.") & IIf(String.IsNullOrEmpty(txtThicknessPt.Text.Trim()), "", " ความหนา " & txtThicknessPt.Text.Trim() & " mc.")
                Case Else
                    txtProductTitleOt.Text = IIf(cmb_ProductType.SelectedValue = 1 Or cmb_ProductType.SelectedValue = 5, "", cmb_ProductType.Text.Trim()) & IIf(String.IsNullOrEmpty(txtProductNameOt.Text.Trim()), "", " " & txtProductNameOt.Text.Trim()) & IIf(String.IsNullOrEmpty(txtVolumnOt.Text.Trim()), "", " " & txtVolumnOt.Text.Trim() & " " & cmb_VolumnUnit.Text)
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Function fnChkTxtIsNullOrEmpty(ByVal ParamArray TextName() As TextBox) As Boolean
        Dim stNotEmpty As Boolean = True
        Dim cntRow As Integer = 0
        For i As Integer = 0 To TextName.Length - 1
            If String.IsNullOrEmpty(TextName(i).Text().Trim()) Then
                cntRow = i + 1
                Select Case TextName(i).Name
                    Case txtProductNamePt.Name 'สินค้าทั่วไป
                        MessageBox.Show("กรุณาระบุชื่อสินค้า", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtLookPt.Name
                        MessageBox.Show("กรุณาระบุ ลักษณะ / สี", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtGradePt.Name
                        MessageBox.Show("กรุณาระบุ เกรด", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                        'Case txtPhasePt.Name
                        '    MessageBox.Show("กรุณาระบุ ระยะเจาะรู", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        '    Exit For
                    Case txtThicknessPt.Name
                        MessageBox.Show("กรุณาระบุ ความหนา", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtProductTitlePt.Name
                        MessageBox.Show("กรุณาตรวจสอบชื่อเรียก", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtWidthPt.Name
                        MessageBox.Show("กรุณาระบุ ความกว้าง", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtLongPt.Name
                        MessageBox.Show("กรุณาระบุ ความยาว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtWeightPt.Name
                        MessageBox.Show("กรุณาระบุ น้ำหนัก / ม้วน", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtCashPt.Name
                        MessageBox.Show("กรุณาระบุ เงินสด", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtCreditPt30.Name
                        MessageBox.Show("กรุณาระบุ เครดิต 30 วัน", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtCreditPt60.Name
                        MessageBox.Show("กรุณาระบุ เครดิต 60 วัน", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtProductNameOt.Name ' สินค้าอื่น ๆ
                        MessageBox.Show("กรุณาระบุชื่อสินค้า", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtProductTitleOt.Name
                        MessageBox.Show("กรุณาตรวจสอบชื่อเรียก", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtVolumnOt.Name
                        MessageBox.Show("กรุณาระบุ ขนาดบรรจุ ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtPriceBillOt.Name
                        MessageBox.Show("กรุณาระบุ ราคาหน้าบิล", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtPerboxOt.Name
                        MessageBox.Show("กรุณาระบุ จำนวนบรรจุ / ลัง", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtPricePerboxOt.Name
                        MessageBox.Show("กรุณาระบุ ราคา / ลัง", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtUnit.Name ' หน่วย
                        MessageBox.Show("กรุณาระบุ หน่วย", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                End Select
            End If 'end chkTxtEmpty
        Next 'For
        If cntRow <> 0 Then
            stNotEmpty = False
            TextName(cntRow - 1).Focus()
            TextName(cntRow - 1).SelectAll()
        End If
        Return stNotEmpty '= true ข้อมูลครบ
    End Function

    Private Function fnChkTxtZero(ByVal ParamArray TextName() As TextBox) As Boolean
        Dim stZero As Boolean = True
        Dim cntRow As Integer = 0
        For i As Integer = 0 To TextName.Length - 1
            If Convert.ToDouble(TextName(i).Text().Trim()) <= 0 Then
                cntRow = i + 1
                Select Case TextName(i).Name
                    Case txtWidthPt.Name 'สินค้าพลาสติก
                        MessageBox.Show("กรุณาระบุ ความกว้าง", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtLongPt.Name
                        MessageBox.Show("กรุณาระบุ ความยาว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtWeightPt.Name
                        MessageBox.Show("กรุณาระบุ น้ำหนัก / ม้วน", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtCashPt.Name
                        MessageBox.Show("กรุณาระบุ เงินสด", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtCreditPt30.Name
                        MessageBox.Show("กรุณาระบุ เครดิต 30 วัน", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtCreditPt60.Name
                        MessageBox.Show("กรุณาระบุ เครดิต 60 วัน", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtVolumnOt.Name 'สินค้าอื่น ๆ
                        MessageBox.Show("กรุณาระบุ ขนาดบรรจุ ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtPriceBillOt.Name
                        MessageBox.Show("กรุณาระบุ ราคาหน้าบิล", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtPerboxOt.Name
                        MessageBox.Show("กรุณาระบุ จำนวนบรรจุ / กล่อง", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    Case txtPricePerboxOt.Name
                        MessageBox.Show("กรุณาระบุ ราคา / กล่อง", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                End Select
            End If
        Next
        If cntRow <> 0 Then
            stZero = False
            TextName(cntRow - 1).Focus()
            TextName(cntRow - 1).SelectAll()
        End If
        Return stZero '= true ข้อมูลครบ
    End Function

    Private Sub ChkTxt_1Space(ByVal txtName As TextBox)
        txtName.Text = txtName.Text.Replace("      ", " ")
        txtName.Text = txtName.Text.Replace("     ", " ")
        txtName.Text = txtName.Text.Replace("    ", " ")
        txtName.Text = txtName.Text.Replace("   ", " ")
        txtName.Text = txtName.Text.Replace("  ", " ")
        txtName.Text = txtName.Text.Trim()
    End Sub

    Private Sub Set_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtThicknessPt.TextChanged, txtWidthPt.TextChanged, txtLongPt.TextChanged, txtWeightPt.TextChanged, txtCashPt.TextChanged, txtCreditPt30.TextChanged, txtCreditPt60.TextChanged, txtVolumnOt.TextChanged, txtCashPt.TextChanged, txtPriceBillOt.TextChanged, txtPricePerboxOt.TextChanged, txtPerboxOt.TextChanged
        Select Case sender.Name
            'พลาสติก
            Case txtThicknessPt.Name 'ความหนา
                fnChkFullStop_UseInTextChanged(txtThicknessPt, 0)
            Case txtWidthPt.Name 'กว้าง (m)
                fnChkFullStop_UseInTextChanged(txtWidthPt, 1)
            Case txtLongPt.Name 'ยาว (Y)
                fnChkFullStop_UseInTextChanged(txtLongPt, 2)
            Case txtWeightPt.Name 'น้ำหนัก / ม้วน
                fnChkFullStop_UseInTextChanged(txtWeightPt, 2)
            Case txtCashPt.Name 'เงินสด
                fnChkFullStop_UseInTextChanged(txtCashPt, 2)
            Case txtCreditPt30.Name 'เครดิต 30 วัน
                fnChkFullStop_UseInTextChanged(txtCreditPt30, 2)
            Case txtCreditPt60.Name 'เครดิต 60 วัน
                fnChkFullStop_UseInTextChanged(txtCreditPt60, 2)

                'สินค้าอื่น ๆ
            Case txtVolumnOt.Name 'ขนาดบรรจุ
                fnChkFullStop_UseInTextChanged(txtVolumnOt, 0)
            Case txtPriceBillOt.Name 'ราคาหน้าบิล
                fnChkFullStop_UseInTextChanged(txtPriceBillOt, 2)
            Case txtPerboxOt.Name 'จำนวนบรรจุ / ลัง
                fnChkFullStop_UseInTextChanged(txtPerboxOt, 0)
            Case txtPricePerboxOt.Name 'ราคา / ลัง
                fnChkFullStop_UseInTextChanged(txtPricePerboxOt, 2)
        End Select
    End Sub

    Private Sub cmb_StuffUnitOt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_VolumnUnit.KeyPress
        If e.KeyChar = Chr(Keys.Space) Then
            cmb_VolumnUnit.DroppedDown = True
        End If
    End Sub

    Private Sub ksbControlClearTxt(ByVal ParamArray control() As Control)
        Dim txt As System.Windows.Forms.TextBox
        Dim RichTxt As System.Windows.Forms.RichTextBox
        For i As Integer = 0 To control.Length - 1
            For Each c As Control In control(i).Controls
                If TypeOf c Is TextBox Then
                    txt = CType(c, TextBox)
                    txt.Clear()
                ElseIf TypeOf c Is RichTextBox Then
                    RichTxt = CType(c, RichTextBox)
                    RichTxt.Clear()
                End If
            Next
        Next
    End Sub
#End Region
    
    Private Sub cbChkPerbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbChkPerbox.CheckedChanged
        If cbChkPerbox.Checked Then
            txtPerboxOt.Enabled = True
            txtPricePerboxOt.Enabled = True
        Else
            txtPerboxOt.Enabled = False
            txtPricePerboxOt.Enabled = False
        End If
    End Sub
End Class