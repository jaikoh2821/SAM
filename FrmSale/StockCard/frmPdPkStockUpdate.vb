Public Class frmPdPkStockUpdate
    Public idPdPk As String
    Public PdCodeS As String
    Public PdPkName As String
    Public Weight As Double
    Public Unit As String
    Public idUnit As String
    Public idPkUnit As String
    Public PerBox As Integer
    Public PriceBill As Double
    Public PriveWh As Double
    Public PriceRetail As Double
    Public Barcode As String
    Dim pidPd As String
    Dim namePs As String
    Dim idps As String = ""
    Dim sDt_dataTemp As New DataTable
    Dim current_row As Integer = 0
    Dim current_column As Integer = 0
    Dim flag As String
    Dim pidPdPk As String
    Dim idpswork As String = ""
    Dim lastrow As Integer
    Dim newrow As Integer = 0
    Dim pidUpdate As String
    Dim ptype As String = "0"
    Dim pPsNamecomm As String
    Dim pPsAction As String
    Dim pNote As String
    Dim DataPdOrder As New DataTable
    Dim lastIndexColCell As Integer = 0


    Private Sub frmPdPkSelect_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Create_TableTamp()
        If ptype = "1" Then
            fillnewdata()
        End If
    End Sub

    Private Sub ShowdataOnGrid()
        mdLoadShow()
        Dim vWhere As String = " "
        'If ChkPd.Checked = True And ChkWeight.Checked = False Then
        '    vWhere = " Where PdPkName Like '%" & txtPdName.Text & "%' Order by PdPkName"
        'ElseIf ChkPd.Checked = False And ChkWeight.Checked = True Then
        '    vWhere = " Where Weight = '" & cmbWeight.SelectedValue & "' AND idUnitW='" & CmbUnitW.SelectedValue & "' Order by PdPkName"
        'ElseIf ChkPd.Checked = True And ChkWeight.Checked = True Then
        '    vWhere = " Where PdPkName Like '%" & txtPdName.Text & "%' And Weight = '" & cmbWeight.SelectedValue & "' " & _
        '             "AND idUnitW='" & CmbUnitW.SelectedValue & "' Order by PdPkName"
        'End If

        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idPdPk, PdCode, Barcode, PdPkName, Weight, UnitW, idUnitW, idPkUnit, PkUnitName, PriceBill, PriceWholesale, " & _
                                  "PriceRetail, PerBox, Amount ,'0' AS ChangeAmount,'' AS note,NULL as AfterAmount From vPackingPdSet" & vWhere
        sAdapter.Fill(sDt)
        dgvPd.DataSource = sDt
        If sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูล", sSystemName)
            Exit Sub
        End If
        For i As Integer = 0 To dgvPd.Rows.Count - 1
            For j As Integer = 0 To sDt_dataTemp.Rows.Count - 1
                If dgvPd.Rows(i).Cells(idPd.Name).Value = sDt_dataTemp.Rows(j).Item(0) Then
                    dgvPd.Rows(i).Cells(Operetor.Name).Value = sDt_dataTemp.Rows(j).Item(1)
                    dgvPd.Rows(i).Cells(ChangeAmount.Name).Value = sDt_dataTemp.Rows(j).Item(2)
                    dgvPd.Rows(i).Cells(AfterAmount.Name).Value = sDt_dataTemp.Rows(j).Item(3)
                    dgvPd.Rows(i).Cells(note.Name).Value = sDt_dataTemp.Rows(j).Item(4)
                End If
            Next
        Next
        mdLoadCommitt()
    End Sub

    Private Sub txtPdName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'mdLoadShow()
        'If e.KeyCode = Keys.Enter Then
        '    mdLoadShow()
        '    Dim vWhere As String = " "
        '    If ChkPd.Checked = True And ChkWeight.Checked = False Then
        '        vWhere = " Where PdPkName Like '%" & txtPdName.Text & "%' Order by PdPkName"
        '    ElseIf ChkPd.Checked = False And ChkWeight.Checked = True Then
        '        vWhere = " Where Weight = '" & cmbWeight.SelectedValue & "' AND idUnitW='" & CmbUnitW.SelectedValue & "' Order by PdPkName"
        '    ElseIf ChkPd.Checked = True And ChkWeight.Checked = True Then
        '        vWhere = " Where PdPkName Like '%" & txtPdName.Text & "%' And Weight = '" & cmbWeight.SelectedValue & "' " & _
        '                 "AND idUnitW='" & CmbUnitW.SelectedValue & "' Order by PdPkName"
        '    End If

        '    mdCnOpen()
        '    Dim sDt As New DataTable
        '    sCommand.CommandText = "Select idPdPk, PdCode, Barcode, PdPkName, Weight, UnitW, idUnitW, idPkUnit, PkUnitName, PriceBill, PriceWholesale, " & _
        '                           "PriceRetail, PerBox, Amount ,'0' AS ChangeAmount From vPackingPdSet" & vWhere
        '    sAdapter.Fill(sDt)
        '    dgvPd.DataSource = sDt
        '    If sDt.Rows.Count = 0 Then
        '        MessageBox.Show("ไม่พบข้อมูล", sSystemName)
        '        Exit Sub
        '    End If

        '    mdLoadCommitt()
        'End If
    End Sub
    Public Sub Create_TableTamp()
        sDt_dataTemp = New DataTable
        sDt_dataTemp.Columns.Add("idPd", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("PdName", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("Before", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("OP", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("Change", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("After", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("note", System.Type.GetType("System.String"))
        mdCnOpen()
        sCommand.CommandText = "SELECT CoDt.idPdPk AS idPd, PdSt.Barcode, PdSt.PdCode, PdSt.PdPkName AS PdName,PdSt.PkUnitName, PdSt.Amount AS Before, '=' AS OP, '' AS Change, '' AS After, PdDt.Note AS note FROM dbo.PkPdCountFormDt AS CoDt LEFT OUTER JOIN dbo.vPackingPdSet AS PdSt ON CoDt.idPdPk = PdSt.idPdPk LEFT OUTER JOIN dbo.PkPdPkUpdateDt AS PdDt ON PdDt.idPdPk = PdSt.idPdPk WHERE (PdSt.PdPkName = '') "
        sAdapter.Fill(DataPdOrder)
    End Sub

    Private Sub dgvPd_RowLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPd.RowLeave
        'If dgvPd.Rows(e.RowIndex).Cells(note.Name).Value Is DBNull.Value Then
        'MessageBox.Show("dsf;kdsjfolkdsjf")
        'dgvPd.CurrentCell = dgvPd.Item("note", 1)
        'End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim sDt As New DataTable
        Dim flag As Integer = 0
        Dim str As String = "ไม่สามารถบันทึกได้"
        For i As Integer = 0 To dgvPd.Rows.Count - 1
            dgvPd.Rows(i).DefaultCellStyle.BackColor = Color.White
        Next


        If idps = "" Then
            MessageBox.Show("กรุณาเลือกพนักงานผู้ออกคำสั่ง", sSystemName)
        Else
            If idpswork = "" Then
                MessageBox.Show("กรุณาเลือกพนักงานผู้ปฏิบัติงาน", sSystemName)
            Else
                If txtnote.Text = "" Then
                    MessageBox.Show("กรุณากรอกหมายเหตุการปฏิบัติงาน", sSystemName)
                Else
                    For i As Integer = 0 To dgvPd.Rows.Count - 2
                        If dgvPd.Rows(i).Cells("Operetor").Value = "" Then
                            dgvPd.Rows(i).DefaultCellStyle.BackColor = Color.Salmon
                            str = "ไม่สามารถบันทึกได้ กรอกข้อมูลไม่สมบูรณ์"
                            flag = 1
                        End If
                        If dgvPd.Rows(i).Cells("note").Value = "" Then
                            dgvPd.Rows(i).DefaultCellStyle.BackColor = Color.Salmon
                            str = "ไม่สามารถบันทึกได้ กรอกข้อมูลไม่สมบูรณ์"
                            flag = 1
                        End If
                        If dgvPd.Rows(i).Cells("OP").Value = "1" Then
                            dgvPd.Rows(i).DefaultCellStyle.BackColor = Color.Salmon
                            str = "ไม่สามารถบันทึกได้ มีรายการที่เป็นช่องว่าง"
                            flag = 1
                        End If
                        If CType(dgvPd.Rows(i).Cells("AfterAmount").Value, Integer) < 0 Then
                            dgvPd.Rows(i).DefaultCellStyle.BackColor = Color.Salmon
                            flag = 1
                            str = "ไม่สามารถบันทึกได้ ตัวเลขยอดคงเหลือติดลบ"
                        End If
                    Next

                    If flag = 1 Then
                        MessageBox.Show(str, sSystemName)
                    End If

                    If flag = 0 Then
                        mdLoadShow()
                        mdCnOpen()
                        sCommand.CommandText = "INSERT INTO PkPdPkUpdateMt (DateTs, idPsTs, idPsCommand,idPsAction,Note,stCount) VALUES ('" & ksbDateToString(Date.Now.Date) & "','" & sPsId.ToString & "' ,'" & idps & "' ,'" & idpswork & "','" & txtnote.Text & "','Pk')"
                        Dim idUpdate As Integer = mdCnOpenQueryIdentity(sCommand.CommandText)
                        'selectmax
                        For i As Integer = 0 To dgvPd.Rows.Count - 2
                            sCommand.CommandText = "INSERT INTO PkPdPkUpdateDt (idUpdate, idPdPkLot, AmountBefore, Operate, AmountOperate, AmountAfter, Note) VALUES (" & idUpdate.ToString & "," & dgvPd.Rows(i).Cells(idPd.Name).Value.ToString & "," & dgvPd.Rows(i).Cells(Amount.Name).Value.ToString & " , '" & dgvPd.Rows(i).Cells(Operetor.Name).Value.ToString & "'," & dgvPd.Rows(i).Cells(ChangeAmount.Name).Value.ToString & "," & dgvPd.Rows(i).Cells(AfterAmount.Name).Value.ToString & ", '" & dgvPd.Rows(i).Cells(note.Name).Value.ToString & "')"
                            sCommand.ExecuteNonQuery()
                            Dim OP_Temp As Integer = 1
                            Dim sDt_LotTemp As New DataTable
                            sCommand.CommandText = "SELECT idPdPk FROM dPackingPdSetLot WHERE idPdPkLot = " & dgvPd.Rows(i).Cells(idPd.Name).Value.ToString
                            sAdapter.Fill(sDt_LotTemp)
                            Dim idPkTemp As String = sDt_LotTemp.Rows(0).Item("idPdPk").ToString
                            Dim temp1 As Integer = CType(dgvPd.Rows(i).Cells(idPd.Name).Value.ToString, Integer)
                            Dim temp2 As Integer = CType(dgvPd.Rows(i).Cells(ChangeAmount.Name).Value.ToString, Integer)
                            If dgvPd.Rows(i).Cells(Operetor.Name).Value.ToString = "+" Then
                                OP_Temp = 1
                                'mdPdPkLotStockUpdate(1, dgvPd.Rows(i).Cells(idPd.Name).Value.ToString, dgvPd.Rows(i).Cells(ChangeAmount.Name).Value.ToString, "WIM: ปรับปรุงสต๊อก(เพิ่ม)", idUpdate)
                            End If
                            If dgvPd.Rows(i).Cells(Operetor.Name).Value.ToString = "-" Then
                                OP_Temp = 2
                                ' mdPdPkLotStockUpdate(2, dgvPd.Rows(i).Cells(idPd.Name).Value.ToString, dgvPd.Rows(i).Cells(ChangeAmount.Name).Value.ToString, "WIM: ปรับปรุงสต๊อก(ลด)", idUpdate)
                            End If
                            If dgvPd.Rows(i).Cells(Operetor.Name).Value.ToString = "=" Then
                                OP_Temp = 3
                                ' mdPdPkLotStockUpdate(3, dgvPd.Rows(i).Cells(idPd.Name).Value.ToString, dgvPd.Rows(i).Cells(AfterAmount.Name).Value.ToString, "WIM: ปรับปรุงสต๊อก(เท่ากับ)", idUpdate)
                            End If

                            'mdPdPkStockUpdate(OP_Temp, temp1, temp2, "Packing: ปรับปรุงสต๊อกสินค้าสำเร็จรูป", idUpdate, "")
                            'sCommand.CommandText = "UPDATE dPackingPdSetLot SET Amount = " & dgvPd.Rows(i).Cells(AfterAmount.Name).Value.ToString & " WHERE idPdPkLot = " & dgvPd.Rows(i).Cells(idPd.Name).Value.ToString
                            'sCommand.ExecuteNonQuery()
                            sCommand.CommandText = "UPDATE dPackingPdSet SET Amount = (SELECT SUM(AMOUNT) FROM dPackingPdSetLot WHERE idPdPk = " & idPkTemp & " ) WHERE idPdPk = " & idPkTemp
                            sCommand.ExecuteNonQuery()

                        Next
                        mdLoadCommitt()
                        MessageBox.Show("บันทึกข้อมูลเรียบร้อย", sSystemName)
                        Me.Close()
                    Else
                        MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้ การกรอกข้อมูลไม่สมบูรณ์", sSystemName)
                    End If

                End If
            End If
        End If



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Pscommand.Click
        Dim frm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            namePs = frm.mName
            idps = frm.mId
            txtPsCommand.Text = namePs
        End If
    End Sub


    Private Sub dgvPd_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPd.CellEndEdit
        If dgvPd.Columns(e.ColumnIndex).Name = ChangeAmount.Name Then
            If dgvPd.Rows(e.RowIndex).Cells("Operetor").Value <> "" Then

                If dgvPd.Rows(e.RowIndex).Cells("Operetor").Value = "+" Then
                    dgvPd.Rows(e.RowIndex).Cells("AfterAmount").Value = (CType(dgvPd.Rows(e.RowIndex).Cells("ChangeAmount").Value, Double) + CType(dgvPd.Rows(e.RowIndex).Cells("Amount").Value, Double)).ToString
                End If
                If dgvPd.Rows(e.RowIndex).Cells("Operetor").Value = "-" Then
                    dgvPd.Rows(e.RowIndex).Cells("AfterAmount").Value = (CType(dgvPd.Rows(e.RowIndex).Cells("Amount").Value, Double) - CType(dgvPd.Rows(e.RowIndex).Cells("ChangeAmount").Value, Double)).ToString
                    If CType(dgvPd.Rows(e.RowIndex).Cells("AfterAmount").Value, Double) < 0 Then
                        dgvPd.Rows(e.RowIndex).Cells("AfterAmount").Value = dgvPd.Rows(e.RowIndex).Cells("Amount").Value
                        dgvPd.Rows(e.RowIndex).Cells("ChangeAmount").Value = "0"
                        MessageBox.Show("ข้อมูลผิดพลาดจำนวนสินค้าไม่สามารถมีน้อยกว่า 0 ชิ้นได้", sSystemName)
                        dgvPd.CurrentCell = dgvPd.Rows(e.RowIndex).Cells("ChangeAmount")
                        dgvPd.BeginEdit(True)
                    End If
                End If
                If dgvPd.Rows(e.RowIndex).Cells("Operetor").Value = "=" Then
                    dgvPd.Rows(e.RowIndex).Cells("AfterAmount").Value = dgvPd.Rows(e.RowIndex).Cells("ChangeAmount").Value
                End If
            End If
        End If

        If dgvPd.Columns(e.ColumnIndex).Name = Operetor.Name Then
            If dgvPd.Rows(e.RowIndex).Cells("ChangeAmount").Value.ToString <> "" Then
                If dgvPd.Rows(e.RowIndex).Cells("Operetor").Value = "+" Then
                    dgvPd.Rows(e.RowIndex).Cells("AfterAmount").Value = (CType(dgvPd.Rows(e.RowIndex).Cells("ChangeAmount").Value, Double) + CType(dgvPd.Rows(e.RowIndex).Cells("Amount").Value, Double)).ToString
                End If
                If dgvPd.Rows(e.RowIndex).Cells("Operetor").Value = "-" Then
                    dgvPd.Rows(e.RowIndex).Cells("AfterAmount").Value = (CType(dgvPd.Rows(e.RowIndex).Cells("Amount").Value, Double) - CType(dgvPd.Rows(e.RowIndex).Cells("ChangeAmount").Value, Double)).ToString
                    If CType(dgvPd.Rows(e.RowIndex).Cells("AfterAmount").Value, Double) < 0 Then
                        dgvPd.Rows(e.RowIndex).Cells("AfterAmount").Value = dgvPd.Rows(e.RowIndex).Cells("Amount").Value
                        dgvPd.Rows(e.RowIndex).Cells("ChangeAmount").Value = "0"
                        MessageBox.Show("ข้อมูลผิดพลาดจำนวนสินค้าไม่สามารถมีน้อยกว่า 0 ชิ้นได้", sSystemName)
                        dgvPd.CurrentCell = dgvPd.Rows(e.RowIndex).Cells("ChangeAmount")
                        dgvPd.BeginEdit(True)
                    End If
                End If
                If dgvPd.Rows(e.RowIndex).Cells("Operetor").Value = "=" Then
                    dgvPd.Rows(e.RowIndex).Cells("AfterAmount").Value = dgvPd.Rows(e.RowIndex).Cells("ChangeAmount").Value
                End If
            End If
        End If


        If dgvPd.Columns(e.ColumnIndex).Name = barcode_pd.Name Then
            mdCnOpen()
            Dim sDt As New DataTable
            sCommand.CommandText = "Select idPdPk, PdCode, Barcode, Amount, PdPkName From vPackingPdSet WHERE Barcode = '" + dgvPd.Rows(e.RowIndex).Cells("barcode_pd").Value + "'"
            sAdapter.Fill(sDt)
            If sDt.Rows.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", sSystemName)
                dgvPd.CurrentRow.Cells("idPd").Value = Nothing
                dgvPd.CurrentRow.Cells("Pd_Code").Value = Nothing
                dgvPd.CurrentRow.Cells("barcode_pd").Value = Nothing
                dgvPd.CurrentRow.Cells("AfterAmount").Value = Nothing
                dgvPd.CurrentRow.Cells("colPdName").Value = Nothing
                dgvPd.CurrentRow.Cells("Amount").Value = Nothing
                dgvPd.CurrentRow.Cells("ChangeAmount").Value = Nothing
                dgvPd.CurrentRow.Cells("OP").Value = Nothing
                dgvPd.CurrentRow.Cells("operetor").Value = Nothing
                Try
                    dgvPd.Rows.RemoveAt(lastrow)
                Catch ex As Exception
                End Try
            Else
                Dim flag2 As Integer = 0
                For i As Integer = 0 To dgvPd.Rows.Count - 2
                    If dgvPd.Rows(i).Cells("idPd").Value = sDt.Rows(0).Item("idPdPk") Then
                        flag2 = 1
                        Exit For
                    End If
                Next
                If flag2 = 0 Then
                    dgvPd.CurrentRow.Cells("idPd").Value = sDt.Rows(0).Item("idPdPk")
                    dgvPd.CurrentRow.Cells("Pd_Code").Value = sDt.Rows(0).Item("PdCode")
                    dgvPd.CurrentRow.Cells("barcode_pd").Value = sDt.Rows(0).Item("Barcode")
                    dgvPd.CurrentRow.Cells("AfterAmount").Value = sDt.Rows(0).Item("Amount")
                    dgvPd.CurrentRow.Cells("colPdName").Value = sDt.Rows(0).Item("PdPkName")
                    dgvPd.CurrentRow.Cells("Amount").Value = sDt.Rows(0).Item("Amount")
                    dgvPd.CurrentRow.Cells("ChangeAmount").Value = "0"
                    dgvPd.CurrentRow.Cells("OP").Value = "1"
                    dgvPd.CurrentRow.Cells("operetor").Value = Nothing
                Else
                    MessageBox.Show("ข้อมูลซ้ำกรุณาเลือกข้อมูลใหม่", sSystemName)
                End If
            End If
        End If

        If dgvPd.Columns(e.ColumnIndex).Name = Pd_Code.Name Then
            mdCnOpen()
            Dim sDt As New DataTable
            sCommand.CommandText = "Select idPdPk, PdCode, Barcode, Amount, PdPkName From vPackingPdSet WHERE PdCode = '" + dgvPd.Rows(e.RowIndex).Cells("Pd_Code").Value + "'"
            sAdapter.Fill(sDt)
            If sDt.Rows.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", sSystemName)
                dgvPd.CurrentRow.Cells("idPd").Value = Nothing
                dgvPd.CurrentRow.Cells("Pd_Code").Value = Nothing
                dgvPd.CurrentRow.Cells("barcode_pd").Value = Nothing
                dgvPd.CurrentRow.Cells("AfterAmount").Value = Nothing
                dgvPd.CurrentRow.Cells("colPdName").Value = DBNull.Value
                dgvPd.CurrentRow.Cells("Amount").Value = Nothing
                dgvPd.CurrentRow.Cells("ChangeAmount").Value = Nothing
                dgvPd.CurrentRow.Cells("OP").Value = "1"
                dgvPd.CurrentRow.Cells("operetor").Value = Nothing
                Try
                    dgvPd.Rows.RemoveAt(lastrow)
                Catch ex As Exception
                End Try

            Else
                Dim flag2 As Integer = 0
                For i As Integer = 0 To dgvPd.Rows.Count - 2
                    If dgvPd.Rows(i).Cells("idPd").Value = sDt.Rows(0).Item("idPdPk") Then
                        flag2 = 1
                        Exit For
                    End If
                Next
                If flag2 = 0 Then
                    dgvPd.CurrentRow.Cells("idPd").Value = sDt.Rows(0).Item("idPdPk")
                    dgvPd.CurrentRow.Cells("Pd_Code").Value = sDt.Rows(0).Item("PdCode")
                    dgvPd.CurrentRow.Cells("barcode_pd").Value = sDt.Rows(0).Item("Barcode")
                    dgvPd.CurrentRow.Cells("AfterAmount").Value = sDt.Rows(0).Item("Amount")
                    dgvPd.CurrentRow.Cells("colPdName").Value = sDt.Rows(0).Item("PdPkName")
                    dgvPd.CurrentRow.Cells("Amount").Value = sDt.Rows(0).Item("Amount")
                    dgvPd.CurrentRow.Cells("ChangeAmount").Value = "0"
                    dgvPd.CurrentRow.Cells("OP").Value = "1"
                    dgvPd.CurrentRow.Cells("operetor").Value = Nothing
                Else
                    MessageBox.Show("ข้อมูลซ้ำกรุณาเลือกข้อมูลใหม่", sSystemName)
                End If
            End If
        End If
        changimg()

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PsAction.Click
        Dim frm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            namePs = frm.mName
            idpswork = frm.mId
            txtPsAction.Text = namePs
        End If
    End Sub


    'Private Sub dgvPd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPd.CellContentClick
    '    Dim frm As New frmPdPkStockUpdateHistory
    '    Dim frm2 As New frmPdPkPerBoxCal
    '    Dim pnamePd As String
    '    Dim BeforeAmount As String
    '    Dim pBarcode As String = ""
    '    Dim pCode As String = ""
    '    Dim punit As String = ""
    '    Dim ans As DialogResult
    '    Dim pidPdPkLot As String = ""
    '    If e.RowIndex < 0 Then
    '        Exit Sub
    '    End If

    '    If dgvPd.Columns(e.ColumnIndex).Name = perboxcol.Name Then
    '        idPdPk = CStr(dgvPd.Rows(e.RowIndex).Cells(idPd.Name).Value)
    '        pnamePd = dgvPd.Rows(e.RowIndex).Cells(colPdName.Name).Value
    '        If idPdPk <> "" Then
    '            frm2.Get_Box(idPdPk, pnamePd)
    '            frm2.ShowDialog()
    '            If frm2.DialogResult = Windows.Forms.DialogResult.OK Then
    '                dgvPd.Rows(e.RowIndex).Cells(ChangeAmount.Name).Value = frm2.perboxAftercal
    '                dgvPd.Rows(e.RowIndex).Cells(AfterAmount.Name).Value = frm2.perboxAftercal
    '            End If
    '        End If
    '    End If

    '    If dgvPd.Columns(e.ColumnIndex).Name = coldelete.Name Then
    '        ans = MessageBox.Show("ยืนยันการลบ", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '        If ans = vbYes Then
    '            dgvPd.Rows.RemoveAt(e.RowIndex)
    '        End If
    '    End If

    '    If dgvPd.Columns(e.ColumnIndex).Name = btn_add.Name Then
    '        Dim sDt_pddata As New DataTable
    '        Dim flag As Integer = 0
    '        Dim vFrm As New frmPdPkSelect(frmPdPkSelect.eProcess.ePdLotSelect)
    '        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            idPdPk = vFrm.idPdPk
    '            pCode = vFrm.PdCodeS
    '            pBarcode = vFrm.Barcode
    '            punit = vFrm.PkUnitName
    '            pidPdPkLot = vFrm.pidPdPkLot
    '        End If
    '        For i As Integer = 0 To dgvPd.Rows.Count - 2
    '            If dgvPd.Rows(i).Cells("idPd").Value = idPdPk Then
    '                flag = 1
    '                Exit For
    '            End If
    '        Next
    '        If flag = 0 Then
    '            Try
    '                mdCnOpen()
    '                Dim sDt As New DataTable
    '                sCommand.CommandText = "Select p.idPdPk,p.PdPkName,lot.Amount,lot.LotNum From dPackingPdSetLot lot LEFT JOIN vPackingPdSet p ON lot.idPdPk = p.idPdPk WHERE lot.idPdPkLot =  " & pidPdPkLot
    '                sAdapter.Fill(sDt_pddata)
    '                dgvPd.Rows.Add(Nothing, pidPdPkLot, sDt_pddata.Rows(0).Item("LotNum").ToString, pBarcode, pCode, Nothing, sDt_pddata.Rows(0).Item(1).ToString, punit, sDt_pddata.Rows(0).Item(2).ToString, Nothing, "0", Nothing, sDt_pddata.Rows(0).Item(2).ToString, "", "", Nothing)
    '                DataPdOrder.Rows.Add(Nothing, pidPdPkLot, sDt_pddata.Rows(0).Item("LotNum").ToString, pBarcode, pCode, Nothing, sDt_pddata.Rows(0).Item(1).ToString, punit, sDt_pddata.Rows(0).Item(2).ToString, Nothing, "0", sDt_pddata.Rows(0).Item(2).ToString, "", "", Nothing)
    '                'For i As Integer = 0 To dgvPd.Rows.Count - 2
    '                '    dgvPd.Rows(i).Cells("Operetor").Value = "+"
    '                'Next
    '            Catch ex As Exception
    '                Exit Sub
    '            End Try

    '        Else
    '            MessageBox.Show("สินค้าซ้ำกรุณาเลือกสินค้าชนิดอื่น", sSystemName)
    '        End If
    '    End If

    '    If dgvPd.Columns(e.ColumnIndex).Name = colSelect.Name Then
    '        idPdPk = CStr(dgvPd.Rows(e.RowIndex).Cells(idPd.Name).Value)
    '        pnamePd = dgvPd.Rows(e.RowIndex).Cells(colPdName.Name).Value
    '        BeforeAmount = dgvPd.Rows(e.RowIndex).Cells(Amount.Name).Value

    '        frm.Get_data(idPdPk, pnamePd)
    '        frm.ShowDialog()
    '    End If
    'End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_operetor.Click
        Dim f2 As New Form
        Dim ComboBox1 As New ComboBox
        Dim LabelUserName As New Label
        Dim ButtonOK As New Button
        Dim ButtonCancel As New Button

        With f2
            .MinimizeBox = False
            .MaximizeBox = False
            .AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
            .AutoSize = True
        End With
        With LabelUserName
            .Parent = f2
            .Left = 5
            .Top = 5
            .Width = 200
            .Height = 13
            .Text = "*เลือกตัวดำเนินการ:"
        End With
        With ComboBox1
            .Parent = f2
            .Items.Add("+")
            .Items.Add("-")
            .Items.Add("=")
            .Left = 5
            .Top = 18
            .Width = 156
            .Height = 20
        End With
        With ButtonOK
            .Parent = f2
            .Left = 14
            .Top = 68
            .Width = 75
            .Height = 23
            .Text = "OK"
            .DialogResult = DialogResult.OK
        End With
        With ButtonCancel
            .Parent = f2
            .Left = 95
            .Top = 68
            .Width = 75
            .Height = 23
            .Text = "Cancel"
            .DialogResult = DialogResult.Cancel
        End With
        If dgvPd.Rows.Count > 1 Then
            f2.StartPosition = FormStartPosition.CenterScreen
            f2.ShowDialog()
            If f2.DialogResult = Windows.Forms.DialogResult.OK Then
                For i As Integer = 0 To dgvPd.Rows.Count - 2
                    dgvPd.Rows(i).Cells("Operetor").Value = ComboBox1.SelectedItem
                Next
                For i As Integer = 0 To dgvPd.Rows.Count - 1
                    If dgvPd.Rows(i).Cells("Operetor").Value = "+" Then
                        dgvPd.Rows(i).Cells("AfterAmount").Value = (CType(dgvPd.Rows(i).Cells("ChangeAmount").Value, Double) + CType(dgvPd.Rows(i).Cells("Amount").Value, Double)).ToString
                    End If
                    If dgvPd.Rows(i).Cells("Operetor").Value = "-" Then
                        dgvPd.Rows(i).Cells("AfterAmount").Value = (CType(dgvPd.Rows(i).Cells("Amount").Value, Double) - CType(dgvPd.Rows(i).Cells("ChangeAmount").Value, Double)).ToString
                    End If
                    If dgvPd.Rows(i).Cells("Operetor").Value = "=" Then
                        dgvPd.Rows(i).Cells("AfterAmount").Value = dgvPd.Rows(i).Cells("ChangeAmount").Value
                    End If
                Next
            End If
        Else
            MessageBox.Show("กรุณาเลือกสินค้าก่อนทำการแก้ไขตัวดำเนินการ", sSystemName)
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_note.Click
        Dim str As String
        If dgvPd.Rows.Count > 1 Then
            str = InputBox("กรอกหมายเหตุ", sSystemName)
            If str <> "" Then
                For i As Integer = 0 To dgvPd.Rows.Count - 2
                    dgvPd.Rows(i).Cells("note").Value = str
                Next
            End If
        Else
            MessageBox.Show("กรุณาเลือกสินค้าก่อนใส่เหตุผล", sSystemName)
        End If
    End Sub

    Private Sub changimg()
        For i As Integer = 0 To dgvPd.Rows.Count - 1
            dgvPd.Rows(i).Cells(colSelect.Name).Value = My.Resources.ResourceManager.GetObject("gdEdit")
        Next
        For i As Integer = 0 To dgvPd.Rows.Count - 1
            dgvPd.Rows(i).Cells(coldelete.Name).Value = My.Resources.ResourceManager.GetObject("cross_circle_frame")
        Next
    End Sub

    Private Sub dgvPd_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvPd.RowsAdded
        changimg()
    End Sub

    Private Sub frmPdPkStockUpdate_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        changimg()
    End Sub

    Private Sub dgvPd_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPd.CellClick
        lastrow = newrow
        newrow = e.RowIndex
        dgvPd.EndEdit()
    End Sub

    Public Sub Get_type(ByVal type As Integer, ByVal idupdate As String)
        pidUpdate = idupdate
        ptype = type
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT P1.PsName AS Ts,P2.PsName AS Command ,P3.PsName AS Action,PdMt.Note FROM dbo.PkPdPkUpdateMt AS PdMt LEFT JOIN vPerson AS P1 ON P1.idPs = PdMt.idPsTs LEFT JOIN vPerson AS P2 ON P2.idPs = PdMt.idPsCommand LEFT JOIN vPerson AS P3 ON P3.idPs = PdMt.idPsAction WHERE PdMt.idUpdate = " + pidUpdate
        sAdapter.Fill(sDt)

        pPsNamecomm = sDt.Rows(0).Item("Command")
        pPsAction = sDt.Rows(0).Item("Action")
        pNote = sDt.Rows(0).Item("Note")
    End Sub

    Private Sub fillnewdata()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT PdDt.idPdPk AS idPd, PdLot.LotNum ,PdSt.Barcode , PdSt.PdCode, PdSt.PdPkName AS PdName,PdSt.PkUnitName, PdDt.AmountBefore AS Before, PdDt.Operate AS OP, PdDt.AmountOperate AS Change, PdDt.AmountAfter AS After, PdDt.Note AS note FROM PkPdPkUpdateDt AS PdDt LEFT OUTER JOIN dPackingPdSetLot PdLot ON PdLot.idPdPkLot = PdDt.idPdPkLot LEFT JOIN  vPackingPdSet AS PdSt ON PdLot.idPdPk = PdSt.idPdPk WHERE PdDt.idUpdate = " & pidUpdate
        sAdapter.Fill(sDt)
        dgvPd.DataSource = sDt
        For i As Integer = 0 To dgvPd.Rows.Count - 1
            dgvPd.Rows(i).Cells(Operetor.Name).Value = dgvPd.Rows(i).Cells(OP.Name).Value
        Next
        For i As Integer = 0 To dgvPd.Rows.Count - 1
            dgvPd.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
        Next
        txtnote.Text = pNote
        txtPsCommand.Text = pPsNamecomm
        txtPsAction.Text = pPsAction
        txtnote.Enabled = False
        dgvPd.Columns(coldelete.Name).Visible = False
        dgvPd.Columns(btn_add.Name).Visible = False
        dgvPd.Columns(Operetor.Name).ReadOnly = True
        dgvPd.Columns(perboxcol.Name).Visible = False
        dgvPd.AllowUserToOrderColumns = False
        dgvPd.AllowUserToAddRows = False
        btn_Pscommand.Visible = False
        btn_PsAction.Visible = False
        btn_save.Visible = False
        btn_operetor.Visible = False
        btn_note.Visible = False
        btn_docimport.Visible = False
        colSelect.Visible = False
        'dgvPd.Enabled = False
    End Sub

    Private Sub dgvPd_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvPd.EditingControlShowing
        With Me.dgvPd
            If .CurrentCell.OwningColumn.Name = ChangeAmount.Name Then
                Dim tb As TextBox = CType(e.Control, TextBox)
                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If
        End With
        
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Me.dgvPd.CurrentCell.OwningColumn.Name = ChangeAmount.Name Then
            If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Or Asc(e.KeyChar) = 46 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If
    End Sub

    'Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_docimport.Click
    '    'Dim frm As New frmStockCountDocList(frmStockCountDocList.eProcess.eSelect, "Pk")
    '    'Dim pidDoc As String = ""
    '    'frm.ShowDialog()
    '    'If frm.DialogResult = Windows.Forms.DialogResult.OK Then
    '    '    pidDoc = frm.idDoc
    '    '    DataPdOrder.Clear()
    '    '    fillDataFromDoc(pidDoc)
    '    'End If

    'End Sub

    Private Sub fillDataFromDoc(ByVal pidDoc As String)
        mdCnOpen()
        sCommand.CommandText = "SELECT CoDt.idPdPk AS idPd, PdSt.Barcode, PdSt.PdCode, PdSt.PdPkName AS PdName,PdSt.PkUnitName, PdSt.Amount AS Before, '=' AS OP, '0' AS Change, '0' AS After,'' AS note FROM dbo.PkPdCountFormDt AS CoDt LEFT OUTER JOIN dbo.vPackingPdSet AS PdSt ON CoDt.idPdPk = PdSt.idPdPk LEFT OUTER JOIN dbo.PkPdPkUpdateDt AS PdDt ON PdDt.idPdPk = PdSt.idPdPk WHERE (CoDt.idForm = '" + pidDoc + "') "
        sAdapter.Fill(DataPdOrder)
        dgvPd.DataSource = DataPdOrder
        For i As Integer = 0 To dgvPd.Rows.Count - 1
            dgvPd.Rows(i).Cells(Operetor.Name).Value = dgvPd.Rows(i).Cells(OP.Name).Value
        Next
    End Sub


    Private Sub dgvPd_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvPd.KeyDown
        Dim pBarcode As String = ""
        Dim pCode As String = ""
        Dim punit As String = ""
        Dim pidPdPkLot As String = ""
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If dgvPd.Columns(dgvPd.CurrentCell.ColumnIndex).Name = btn_add.Name Then
                Dim sDt_pddata As New DataTable
                Dim flag As Integer = 0
                Dim vFrm As New frmPdPkSelect(frmPdPkSelect.eProcess.ePdLotSelect)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    idPdPk = vFrm.idPdPk
                    pCode = vFrm.PdCodeS
                    pBarcode = vFrm.Barcode
                    punit = vFrm.PkUnitName
                    pidPdPkLot = vFrm.pidPdPkLot
                End If
                For i As Integer = 0 To dgvPd.Rows.Count - 2
                    If dgvPd.Rows(i).Cells("idPd").Value = idPdPk Then
                        flag = 1
                        Exit For
                    End If
                Next
                If flag = 0 Then
                    Try
                        mdCnOpen()
                        Dim sDt As New DataTable
                        sCommand.CommandText = "Select p.idPdPk,p.PdPkName,lot.Amount,lot.LotNum From dPackingPdSetLot lot LEFT JOIN vPackingPdSet p ON lot.idPdPk = p.idPdPk WHERE lot.idPdPkLot =  " & pidPdPkLot
                        sAdapter.Fill(sDt_pddata)
                        dgvPd.Rows.Add(Nothing, pidPdPkLot, sDt_pddata.Rows(0).Item("LotNum").ToString, pBarcode, pCode, Nothing, sDt_pddata.Rows(0).Item(1).ToString, punit, sDt_pddata.Rows(0).Item(2).ToString, Nothing, "0", Nothing, sDt_pddata.Rows(0).Item(2).ToString, "", "", Nothing)

                        'DataPdOrder.Rows.Add(Nothing, pidPdPkLot, sDt_pddata.Rows(0).Item("LotNum").ToString, pBarcode, pCode, Nothing, sDt_pddata.Rows(0).Item(1).ToString, punit, sDt_pddata.Rows(0).Item(2).ToString, Nothing, "0", sDt_pddata.Rows(0).Item(2).ToString, "", "", Nothing)
                        'For i As Integer = 0 To dgvPd.Rows.Count - 2
                        '    dgvPd.Rows(i).Cells("Operetor").Value = "+"
                        'Next
                    Catch ex As Exception
                        Exit Sub
                    End Try

                Else
                    MessageBox.Show("สินค้าซ้ำกรุณาเลือกสินค้าชนิดอื่น", sSystemName)
                End If
                dgvPd.CurrentCell = dgvPd(dgvPd.Columns.Item(Operetor.Name).Index, dgvPd.CurrentCell.RowIndex - 1)

            End If
        End If
    End Sub

    'Private Sub dgvPd_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPd.CellEnter
    '    If sender.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly Then
    '        If lastIndexColCell > e.ColumnIndex Then
    '            SendKeys.Send("+{TAB}")
    '        Else
    '            SendKeys.Send("{TAB}")
    '        End If
    '    End If
    '    lastIndexColCell = e.ColumnIndex
    'End Sub
End Class