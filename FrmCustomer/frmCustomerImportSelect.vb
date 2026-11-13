Public Class frmCustomerImportSelect
    Dim mCusSame As String = "" : Dim mAddress As String = ""
    Sub New(Optional ByVal aCusSame As String = "", Optional ByVal aAddress As String = "")

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If aCusSame <> "" Then
            mCusSame = aCusSame
            mAddress = aAddress
            pnlTitle.Visible = False
            colSelect.Visible = False
            colCancel.Visible = False
            btnAdd.Visible = True
            btnBack.Visible = True
            btnSearch.Visible = False
            btnSelectAll.Visible = False
            Me.Text = "ข้อมูลที่ได้เลือกไปแล้ว มีชื่อใกล้เคียงกันกับ " & aCusSame
        End If

    End Sub
    Private Sub pSetData()
        If chbCut.Checked = False And chbNon.Checked = False And chbSelect.Checked = False Then lbrMsg.MsgWarning("ยังไม่ได้ระบุการแสดงข้อมูล") : Exit Sub
        mdLoadShow()
        Dim vWhere As String = ""
        If mCusSame = "" Then
            If txtCondition.Text <> "" Then vWhere = " CusName Like '%" & txtCondition.Text & "%' And "
            vWhere &= " ( "
            If chbNon.Checked = True Then vWhere &= " stDel is Null OR  "
            If chbSelect.Checked = True Then vWhere &= " stDel = '0' OR  "
            If chbCut.Checked = True Then vWhere &= " stDel = '1' OR  "
            If vWhere <> "" Then vWhere = vWhere.Substring(0, vWhere.Length - 4) & " ) "
        Else
            vWhere = " stDel ='0' And ( "
            If mAddress <> "" Then vWhere &= " AddressOld = '" & mAddress & "' OR  "
            vWhere &= " CusName Like '%" & mCusSame & "%' OR  "
            'For i As Integer = 0 To mCusSame.Length - 3
            '    vWhere &= " CusName Like '%" & mCusSame.Substring(0, mCusSame.Length - (i)) & "%' OR  "
            'Next

            Dim vSplit() As String = mCusSame.Split(" ")
            If vSplit.Length > 0 Then
                For i As Integer = 0 To vSplit.Length - 1
                    vWhere &= " CusName Like '%" & vSplit(i) & "%' OR  "
                Next
            End If
            If vWhere <> "" Then vWhere = vWhere.Substring(0, vWhere.Length - 4) & " ) "
        End If
        Dim vDt As New DataTable : lbrDb.DtSet(vDt, "idCus,CusCode,CusName,AddressOld,Note,stDel", "dCustomer", vWhere, "CusName")
        Dim vDv As DataView = vDt.DefaultView
        vDv.RowFilter = " stDel is Null" : txtNon.Text = ksbNumFormat(vDv.Count, , False)
        vDv.RowFilter = " stDel = '0'" : txtSelect.Text = ksbNumFormat(vDv.Count, , False)
        vDv.RowFilter = " stDel = '1'" : txtCut.Text = ksbNumFormat(vDv.Count, , False)
        vDv.RowFilter = ""
        dgvData.DataSource = vDt
        ksbCountRowDgv(dgvData, colCount.Name)

        ksbDgvSetStColorFromValue(dgvData, colStDel.Name, Color.LightGreen, "0")
        ksbDgvSetStColorFromValue(dgvData, colStDel.Name, Color.Salmon, "1")
      
        If mCusSame <> "" Then
            If dgvData.Rows.Count = 0 Then Me.DialogResult = Windows.Forms.DialogResult.OK : Me.Close()
            If dgvData.Rows.Count > 0 Then lbrMsg.MsgWarning("กรุณาตรวจสอบข้อมูลที่ได้เลือกมา ไม่ให้ซ้ำกับข้อมูลที่ได้เคยเลือกไปแล้ว " & vbCrLf & "เพื่อไม่ให้มีปัญหาการซ้ำกันของข้อมูล")
        End If
        mdLoadCommitt()
    End Sub
  
    Private Sub frmCustomerImportSelect_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        pSetData()
    End Sub
    Private Sub txtCondition_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCondition.KeyDown
        If e.KeyCode = Keys.Enter Then pSetData()
    End Sub

    Private Sub dgvData_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellClick
        Select Case dgvData.Columns(e.ColumnIndex).Name
            Case colSelect.Name
                Select Case dgvData.Rows(e.RowIndex).Cells(colStDel.Name).Value.ToString
                    Case "0"
                        If lbrMsg.MsgQuestion("รายการนี้ได้ เลือก ไปแล้ว ต้องการยกเลิก ใช่หรือไม่") = False Then Exit Sub
                        lbrDb.UpdateExecute("dCustomer", "stDel = Null", "idCus=" & dgvData.Rows(e.RowIndex).Cells(colIdCus.Name).Value)
                        lbrMsg.MsgInformation("ยกเลิกรายการแล้ว")
                        pSetData()
                    Case "1"
                        If lbrMsg.MsgQuestion("รายการนี้ได้ คัดออก ไปแล้ว ต้องการให้กลับมาคัดเลือกใหม่ ใช่หรือไม่") = False Then Exit Sub
                        lbrDb.UpdateExecute("dCustomer", "stDel = Null", "idCus=" & dgvData.Rows(e.RowIndex).Cells(colIdCus.Name).Value)
                        lbrMsg.MsgInformation("ย้ายสถานะรายการแล้ว")
                        pSetData()
                    Case ""
                        Dim vFrm As New frmCustomerImportSelect(dgvData.Rows(e.RowIndex).Cells(colCusName.Name).Value.ToString, dgvData.Rows(e.RowIndex).Cells(colAddressOld.Name).Value.ToString)
                        If vFrm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                            'Dim vFrmD As New frmCustomerDetail(dgvData.Rows(e.RowIndex).Cells(colIdCus.Name).Value, KsbLibrary.eProcess.Edit, True)
                            'vFrmD.ShowDialog()
                            If lbrMsg.MsgQuestion("ต้องการเพิ่มรายการนี้ ใช่หรือไม่") = False Then Exit Sub
                            lbrDb.UpdateExecute("dCustomer", "stDel ='0' ", "idCus = " & dgvData.Rows(e.RowIndex).Cells(colIdCus.Name).Value)
                            pSetData()
                        End If
                End Select
             
            Case colCancel.Name
                If lbrMsg.MsgQuestion("ต้องการคัดรายการนี้ออก ใช่หรือไม่") = False Then Exit Sub
                lbrDb.UpdateExecute("dCustomer", "stDel = '1'", "idCus=" & dgvData.Rows(e.RowIndex).Cells(colIdCus.Name).Value)
                lbrMsg.MsgInformation("ทำการคัดรายการออกแล้ว")
                pSetData()
        End Select
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        pSetData()
    End Sub

    Private Sub rdbList_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbList.CheckedChanged
        If rdbList.Checked = True Then
            lbrMsg.MsgInformation("ถ้าเลือกระบุทีละหลายรายการ จะไม่มีระบบตรวจสอบการซ้ำของข้อมูลที่เลือกไปแล้ว")
        End If
        colChb.Visible = rdbList.Checked
        btnSelectAll.Enabled = rdbList.Checked

        colSelect.Visible = rdbOnce.Checked
    End Sub
    Private Sub rdbOnce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbOnce.CheckedChanged
      

        colSelect.Visible = rdbOnce.Checked
    End Sub
    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        Dim vCount As Integer = 0
        For Each vDgvr As DataGridViewRow In dgvData.Rows
            If vDgvr.Cells(colChb.Name).Value = True Then vCount += 1
        Next
        If vCount = 0 Then lbrMsg.MsgWarning("ยังไม่ได้เลือกรายการ") : Exit Sub

        If lbrMsg.MsgSaveQuestion("ต้องการบันทึกการเลือกข้อมูลที่ระบุทั้งหมด ใช่หรือไม่") = False Then Exit Sub
        Dim vIdCus As String = ""
        For Each vDgvr As DataGridViewRow In dgvData.Rows
            If vDgvr.Cells(colChb.Name).Value = True Then
                vIdCus &= "idCus = " & vDgvr.Cells(colIdCus.Name).Value & " OR "
            End If
        Next
        If vIdCus <> "" Then vIdCus = vIdCus.Substring(0, vIdCus.Length - 3)
        lbrDb.UpdateExecute("dCustomer", "stDel ='0' ", vIdCus)
        lbrMsg.MsgSaveComplete()
        pSetData()

    End Sub

    Private Sub dgvData_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        dgvData.EndEdit(DataGridViewDataErrorContexts.CurrentCellChange)
        If dgvData.Rows(e.RowIndex).Cells(colChb.Name).Value = True And dgvData.Rows(e.RowIndex).Cells(colStDel.Name).Value.ToString <> "" Then
            lbrMsg.MsgWarning("รายการนี้เลือกไปแล้ว ไม่สามารถเลือกได้")
            dgvData.Rows(e.RowIndex).Cells(colChb.Name).Value = False
        End If

    End Sub

    Private Sub dgvData_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseClick

    End Sub
End Class