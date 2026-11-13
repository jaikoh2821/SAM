Public Class frmPdIngredient

    Dim list_idPd As New List(Of Integer), list_namePlant As New List(Of String)

    Public pIdT_I As Integer
    Public pd_I As String
    Public pPlant_I As String
    Public pPlantType_I As String
    Public pSeedT_I As Integer

    Public F_idFl As Integer
    Public F_FlName As String
    Public F_Note_I As String

    Dim aDt As New DataTable

    Private Sub frmIngredientPd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pdCode As String
        Dim pdName As String
        Dim NameCode As String
        mdCnOpen()
        aDt.Clear()
        sCommand.CommandText = " Select SlPdIngredient.idPd As colidPd ,vSeedProduct.PdName As PdCodeName,vSeedProduct.PdName As PdName,vSeedProduct.PdCode As PdCode,SlPdIngredient.MixPerc " & _
                            " From SlPdIngredient INNER JOIN vSeedProduct ON SlPdIngredient.idPd=vSeedProduct.idPd  Where SlPdIngredient.idPdT =" & pIdT_I & " And SlPdIngredient.idFl =" & F_idFl & " "
        sAdapter.Fill(aDt)
        If aDt.Rows.Count <> 0 Then
            Me.DataGridView1.DataSource = aDt
            chk_newData = 1
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                With DataGridView1.Rows(i)
                    pdCode = .Cells("PdCode").Value.ToString
                    pdName = .Cells("PdName").Value.ToString
                    NameCode = pdCode + " : " + pdName
                    .Cells("colproduct").Value = NameCode

                End With
            Next
        End If
    End Sub

    'Private Sub btn_sel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sel.Click
    '    If Me.txt_name.Text = "" Then
    '        MessageBox.Show("กรุณาเลือกสินค้า")
    '    Else
    '        Dim frm_P As New frmPdProduceSelect
    '        frm_P.ShowText(Me.txt_name.Text)
    '        frm_P.ShowStatus(pSeedT_I)
    '        frm_P.ShowDialog()

    '        If frm_P.DialogResult = Windows.Forms.DialogResult.OK Then
    '            Me.list_idPd = frm_P.list_id
    '            Me.list_namePlant = frm_P.list_name
    '        End If
    '        ShowDGV()
    '    End If

    'End Sub
    Dim row_id As String()
    Dim chk_newData As Integer

    Private Sub ShowDGV()
        Dim status_chk As Integer = 0
        For i As Integer = 0 To list_idPd.Count - 1
            status_chk = 0 'set Default

            For j As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                If list_idPd.Item(i) = DataGridView1.Rows(j).Cells("colidPd").Value Then
                    status_chk = 1
                    Exit For
                End If
            Next
            If status_chk = 0 Then 'No information
                If chk_newData = 1 Then 'มีข้อมูลเดิม
                    DataGridView1.DataBindings.Clear()
                    row_id = New String() {list_idPd.Item(i), list_namePlant.Item(i)}
                    aDt.Rows.Add(row_id)
                    Me.DataGridView1.DataSource = aDt
                Else
                    row_id = New String() {list_idPd.Item(i), list_namePlant.Item(i)}
                    Me.DataGridView1.Rows.Add(row_id)
                End If

            End If
        Next
    End Sub

    'Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

    '    Dim chk_db As Integer = 0
    '    Dim idpdT As Integer
    '    Dim idpd As Integer
    '    Dim Mix As Double
    '    Dim MixPerc As Double = 0
    '    Dim sum_mix As Double = 0
    '    Dim chk_o As Integer = 0
    '    Dim chkId_dgv As Integer = 0
    '    Dim chkId_dt As Integer = 0
    '    Dim chk_n As Integer = 0

    '    Try
    '        If Me.txt_FL.Text = "" Then
    '            MessageBox.Show("กรุณาระบุชื่อสูตร")
    '        Else
    '            If Me.DataGridView1.Rows.Count = 0 Then 'haven't DGV
    '                MessageBox.Show("กรุณาเลือกสินค้าส่วนผสม")
    '            Else
    '                For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
    '                    MixPerc = DataGridView1.Rows(i).Cells("ingredient").Value
    '                    If MixPerc = 0.0 Then 'check ingredient = 0?
    '                        chk_o = 1
    '                        Exit Try
    '                    End If
    '                    sum_mix = MixPerc + sum_mix
    '                Next

    '                If sum_mix = 100.0 Then
    '                    'insert SlPdFormula
    '                    mdCnOpen()

    '                    Dim date_string As String = Format(Now, "Short date").ToString()
    '                    Dim Date_Update As String = ksbDateToString(date_string)
    '                    Dim saveFL_Dt As New DataTable
    '                    saveFL_Dt.Clear()
    '                    sCommand.CommandText = " Select idFL,FlName From SlPdFormula Where idPdT =" & pIdT_I & " "
    '                    sAdapter.Fill(saveFL_Dt)
    '                    Dim chkname As Integer = 0
    '                    If saveFL_Dt.Rows.Count <> 0 Then 'have Formala Name at idPdT


    '                        For n As Integer = 0 To saveFL_Dt.Rows.Count - 1
    '                            Dim chk_name As String = saveFL_Dt.Rows.Item(n).Item("idFL").ToString
    '                            If F_idFl = chk_name Then 'update
    '                                chkname = 1 'have information
    '                                Exit For
    '                            End If
    '                        Next

    '                        If chkname = 1 Then 'update
    '                            sCommand.CommandText = "UPDATE SlPdFormula SET  FlName = '" & Me.txt_FL.Text & "',Note='" & Me.txt_note.Text & "'" & _
    '                                                    ",idPsUpdate='" & sPsId & "',DateUpdate='" & Date_Update & "' Where idFL='" & F_idFl & "' "
    '                            sCommand.ExecuteNonQuery()
    '                        Else 'insert chkname = 0

    '                            For n As Integer = 0 To saveFL_Dt.Rows.Count - 1
    '                                Dim name_Fl As String = saveFL_Dt.Rows.Item(n).Item("FlName").ToString
    '                                If Me.txt_FL.Text = name_Fl Then 'ชื่อซ้ำ
    '                                    chk_n = 1
    '                                    Exit Try
    '                                End If
    '                            Next
    '                            If chk_n = 0 Then
    '                                sCommand.CommandText = "INSERT INTO SlPdFormula (idPdT,FlName,Note,idPsUpdate,DateUpdate)" & _
    '                                                                                        "VALUES ('" & pIdT_I & "','" & Me.txt_FL.Text & "','" & Me.txt_note.Text & "','" & sPsId & "','" & Date_Update & "')"
    '                                sCommand.ExecuteNonQuery()
    '                            End If

    '                        End If

    '                    Else 'haven't Formala Name at idPdT >> insert
    '                        sCommand.CommandText = "INSERT INTO SlPdFormula (idPdT,FlName,Note,idPsUpdate,DateUpdate)" & _
    '                                                                        "VALUES ('" & pIdT_I & "','" & Me.txt_FL.Text & "','" & Me.txt_note.Text & "','" & sPsId & "','" & Date_Update & "')"
    '                        sCommand.ExecuteNonQuery()
    '                    End If

    '                    'insert SlPdIngredient
    '                    Dim save_Dt As New DataTable
    '                    save_Dt.Clear()
    '                    sCommand.CommandText = " Select idFL As colidFL,idPdT As colidPdT,idPd As colidPd ,MixPerc From SlPdIngredient Where idPdT =" & pIdT_I & " "
    '                    sAdapter.Fill(save_Dt)

    '                    For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1 'check update or insert
    '                        chk_db = 0
    '                        chkId_dgv = DataGridView1.Rows(i).Cells("colidPd").Value
    '                        For j As Integer = 0 To save_Dt.Rows.Count - 1
    '                            chkId_dt = save_Dt.Rows(j).Item(colidPd.Name)
    '                            Dim chk_idFL As Integer = save_Dt.Rows.Item(j).Item("colidFL")
    '                            Dim chk_idPdT As Integer = save_Dt.Rows.Item(j).Item("colidPdT")
    '                            If chkId_dgv = chkId_dt And chk_idFL = F_idFl And chk_idPdT = pIdT_I Then
    '                                chk_db = 1 'update
    '                                Exit For
    '                            End If
    '                        Next

    '                        If chk_db = 0 Then 'No information
    '                            Dim idFL_Dt As New DataTable
    '                            idFL_Dt.Clear()
    '                            sCommand.CommandText = " Select MAX(idFL) As CountMax From SlPdFormula Where idPdT =" & pIdT_I & " And FlName = '" & Me.txt_FL.Text & "' "
    '                            sAdapter.Fill(idFL_Dt)

    '                            Dim idfl As Integer = idFL_Dt.Rows.Item(0).Item("CountMax").ToString

    '                            idpdT = pIdT_I
    '                            idpd = DataGridView1.Rows(i).Cells("colidPd").Value
    '                            Mix = DataGridView1.Rows(i).Cells("ingredient").Value

    '                            sCommand.CommandText = "INSERT INTO SlPdIngredient (idFL,idPdT,idPd,MixPerc) VALUES ('" & idfl & "','" & idpdT & "','" & idpd & "','" & Mix & "')"
    '                            sCommand.ExecuteNonQuery()
    '                        Else
    '                            idpdT = pIdT_I
    '                            idpd = DataGridView1.Rows(i).Cells("colidPd").Value
    '                            Mix = DataGridView1.Rows(i).Cells("ingredient").Value
    '                            sCommand.CommandText = "UPDATE SlPdIngredient SET   MixPerc = '" & Mix & "' Where idPdT='" & idpdT & "' And idPd = '" & idpd & "' And idFL = '" & F_idFl & "' "
    '                            sCommand.ExecuteNonQuery()
    '                        End If
    '                    Next
    '                    MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว")
    '                    Me.DialogResult = Windows.Forms.DialogResult.OK
    '                    Me.Close()

    '                Else
    '                    MessageBox.Show("จำนวนส่วนผสมรวมทั้งหมดไม่เท่ากับ100%")
    '                End If

    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("กรุณาระบุจำนวนส่วนผสมรวมในแต่ละรายการให้ครบ")
    '    End Try


    '    If chk_o = 1 Then
    '        MessageBox.Show("จำนวนส่วนผสมบางรายการมีค่าเป็น 0")
    '    End If

    '    If chk_n = 1 Then
    '        MessageBox.Show("บันทึกไม่ได้เนื่องจากมีชื่อสูตรนี้แล้ว")
    '    End If

    'End Sub

    Private Sub DataGridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Me.DataGridView1.Columns(2).DefaultCellStyle.Format = "##0.00"
    End Sub

    Dim Result As DialogResult

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        With DataGridView1
            If .CurrentCell.OwningColumn.DataPropertyName = "MixPerc" Then
                Dim tb As TextBox = CType(e.Control, TextBox)
                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If
        End With
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Public Sub ShowText(ByVal pd As String, ByVal pPlant As String, ByVal pPlantType As String, ByVal pIdT As String, ByVal pSeedT As String)
        pd_I = pd
        pPlant_I = pPlant
        pPlantType_I = pPlantType
        pIdT_I = pIdT
        pSeedT_I = pSeedT

        Me.txt_name.Text = pd_I
        Me.txt_plant.Text = pPlant_I
        Me.txt_type.Text = pPlantType_I
    End Sub

    Public Sub getFl(ByVal F_id As Integer, ByVal F_name As String, ByVal F_Note As String)
        F_idFl = F_id
        F_FlName = F_name
        F_Note = F_Note

        Me.txt_FL.Text = F_FlName
        Me.txt_note.Text = F_Note
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If Me.DataGridView1.Columns(e.ColumnIndex).Name = Me.coldelete.Name Then
            Result = MsgBox("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
            If Result = Windows.Forms.DialogResult.Yes Then
                Dim del_Dt As New DataTable
                del_Dt.Clear()
                sCommand.CommandText = " Select MixPerc From SlPdIngredient Where idPdT ='" & pIdT_I & "'   And idPd = '" & DataGridView1.Rows(e.RowIndex).Cells("colidPd").Value & "' "
                sAdapter.Fill(del_Dt)

                If del_Dt.Rows.Count <> 0 Then 'have information
                    sCommand.CommandText = "DELETE FROM SlPdIngredient WHERE idPd = '" & DataGridView1.Rows(e.RowIndex).Cells("colidPd").Value & "' And idpdT = '" & pIdT_I & "' And idFL = '" & F_idFl & "'"
                    sCommand.ExecuteNonQuery()
                    DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                Else
                    DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                End If
            End If
        End If
    End Sub

End Class