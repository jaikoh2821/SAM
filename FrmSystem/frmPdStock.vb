Public Class frmPdStock
    Dim eEvent As eProcess
    Dim stPage As String
    Public idPdLot As String
    Dim idPd_ As String
    Dim stLoad As Integer = 0
    Public Lot_temp As New DataTable
    Public idPdLotCut_temp As New DataTable
    'New 14/1/2558 thong
    Enum eProcess
        eManage
        eView
        eSelect
        eSelectNoneZero
        eShowDt
        eCheckbox
        eSelectSale
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idPd As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eManage
                stPage = 1
            Case eProcess.eView
                stPage = 2
            Case eProcess.eSelect
                stPage = 3
            Case eProcess.eShowDt 'แสดงข้อมูล
                stPage = 4
            Case eProcess.eCheckbox 'เลือกหลาย Lot
                stPage = 5
            Case eProcess.eSelectNoneZero 'เลือก 0 ได้
                stPage = 6
            Case eProcess.eSelectSale 'เลือกขายสินค้าวัตถุดิบ
                stPage = 7
        End Select
        eEvent = aProcess
        idPd_ = idPd

    End Sub

    Private Sub frmPdStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindPlant()
        BindPlant2()
        If stPage = 1 Then
            'Manage
            Me.Text = "จัดการสต๊อกสินค้าวัตถุดิบ"
            'dgvShowData.Columns("ColNum").Visible = False
        ElseIf stPage = 2 Then
            'View
            Me.Text = "ข้อมูลสต๊อกสินค้าวัตถุดิบ"
            Me.btnNew.Visible = False
            dgvShowData.Columns("ColEdit").Visible = False
            dgvShowData.Columns("ColDel").Visible = False
            dgvShowData.Columns("ColChk").Visible = False
            'dgvShowData.Columns("ColNum").Visible = False
        ElseIf stPage = 3 Then
            'Select
            Me.Text = "เลือกรายการสต๊อกสินค้าวัตถุดิบ"
            Me.btnNew.Visible = False
            dgvShowData.Columns("ColSelect").Visible = True
            dgvShowData.Columns("ColEdit").Visible = False
            dgvShowData.Columns("ColDel").Visible = False
            dgvShowData.Columns("ColNum").Visible = False
            dgvShowData.Columns("ColChk").Visible = False
        ElseIf stPage = 6 Then
            'Select 0
            Me.Text = "เลือกรายการสต๊อกสินค้าวัตถุดิบ"
            Me.btnNew.Visible = False
            dgvShowData.Columns("ColSelect").Visible = True
            dgvShowData.Columns("ColEdit").Visible = False
            dgvShowData.Columns("ColDel").Visible = False
            dgvShowData.Columns("ColNum").Visible = False
            dgvShowData.Columns("ColChk").Visible = False
        ElseIf stPage = 4 Or stPage = 5 Then
            mdLoadShow()
            'ShowDetail
            Me.btnNew.Visible = False
            dgvShowData.Columns("ColEdit").Visible = False
            dgvShowData.Columns("ColDel").Visible = False
            dgvShowData.Columns("ColChk").Visible = False
            If stPage = 4 Then
                Me.Text = "รายละเอียดสต๊อกสินค้าวัตถุดิบ"
                dgvShowData.Columns("ColChk").Visible = False
                Me.btn_OK.Visible = False
            ElseIf stPage = 5 Then 'Checkbox
                dgvShowData.Columns("ColChk").Visible = True
                Me.dgvShowData.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
                Me.Text = "เลือกสต๊อกสินค้าวัตถุดิบ"
                Me.btn_OK.Visible = True

                Lot_temp.Columns.Add("idPdLot", Type.GetType("System.String"))
                Lot_temp.Columns.Add("LotNo", System.Type.GetType("System.String"))
                Lot_temp.Columns.Add("LotRefCode", Type.GetType("System.String"))
                Lot_temp.Columns.Add("PdName", System.Type.GetType("System.String"))
                Lot_temp.Columns.Add("Amount", System.Type.GetType("System.Double"))
                Lot_temp.Columns.Add("idPd", System.Type.GetType("System.Int32"))
            End If

            Me.ChkPdname.Checked = True
            mdCnOpen()
            Dim sDt_ As New DataTable
            sCommand.CommandText = "Select Distinct idPd, idSeedType From vSeedProduct Where idPd = '" & idPd_ & "'"
            sAdapter.Fill(sDt_)

            Me.ChkPlantType.Checked = True
            Me.cmbPlant.SelectedValue = sDt_.Rows(0).Item("idSeedType")
            Me.cmbPdName.SelectedValue = sDt_.Rows(0).Item("idPd")
            Me.ChkPlantType.Enabled = False
            Me.cmbPlant.Enabled = False
            Me.ChkPdname.Enabled = False
            Me.cmbPdName.Enabled = False

            Dim vWhere As String = ""
            If Me.ChkNoPd.Checked = True Then
                vWhere = vWhere & " AND s.Amount > '0' "
            End If

            If stPage = 5 Then 'Checkbox
                If idPdLotCut_temp.Rows.Count <> 0 Then
                    For i As Integer = 0 To idPdLotCut_temp.Rows.Count - 1
                        vWhere = vWhere & " AND s.idPdLot <> '" & idPdLotCut_temp.Rows(i).Item("idPdLot") & "' "
                    Next
                End If
            End If

            mdCnOpen()
            Dim sDt As New DataTable
            sCommand.CommandText = "Select s.DateRec, s.idPdLot, s.LotNum, s.LotCodeRef, s.idPd, p.PdName, p.SeedTypeName, " & _
                                    "s.AmountRec, s.AmountUse, s.Amount, s.Grad, s.Grow, '' as Grow_, " & _
                                    "s.Humid, '' as Humid_, s.Pure, '' as Pure_, " & _
                                    "s.DocPackCode, s.GrowRec, s.HumidRec, " & _
                                     "s.PureRec, s.GrowAA, s.GrowTZ, s.GrowPaper, s.GrowSand, " & _
                                    "s.Note From PkPdLotStock s LEFT OUTER JOIN vSeedProduct p " & _
                                    "ON s.idPd = p.idPd Where s.idPd ='" & Me.cmbPdName.SelectedValue & "' " & vWhere & "Order by p.SeedTypeName"
            sAdapter.Fill(sDt)

            'sDt.Columns.Add("Grow_", System.Type.GetType("System.Double"))

            If sDt.Rows.Count = 0 Then
                mdLoadCommitt()
                MessageBox.Show("ไม่พบข้อมูลสต๊อกสินค้าวัตถุดิบ", sSystemName)
                If (stPage = 4 Or stPage = 5) And stLoad = 0 Then
                    Me.Close()
                End If
                dgvShowData.DataSource = sDt
                Exit Sub
            Else
                For i As Integer = 0 To sDt.Rows.Count - 1
                    sDt.Rows(i).Item("Grow_") = Val(sDt.Rows(i).Item("Grow"))
                    sDt.Rows(i).Item("Humid_") = Val(sDt.Rows(i).Item("Humid"))
                    sDt.Rows(i).Item("Pure_") = Val(sDt.Rows(i).Item("Pure"))
                Next
                dgvShowData.DataSource = sDt
                ksbCountRowDgv(dgvShowData, ColNum.Name)
                mdConvertDateInGrid(dgvShowData, ColDateRec)
                'ksbDgvConvertDateFormat(dgvShowData, ColDateRec.Name)
                If stPage = 4 Then
                    stLoad = 1
                End If
            End If
            SumTotal()
            mdLoadCommitt()
        ElseIf stPage = 7 Then 'เลือกรายการ เพื่อขายสินค้าวัตถุดิบ
            'Select
            Me.Text = "เลือกรายการสินค้าวัตถุดิบ"
            Me.btnNew.Visible = False
            dgvShowData.Columns("ColSelect").Visible = True
            dgvShowData.Columns("ColEdit").Visible = False
            dgvShowData.Columns("ColDel").Visible = False
            dgvShowData.Columns("ColNum").Visible = False
            dgvShowData.Columns("ColChk").Visible = False
            Me.TabControl1.Controls.Remove(TabPage2)
            mdLoadShow()
            BindData()
            SumTotal()
            mdLoadCommitt()
        End If
    End Sub

    Sub SumTotal()
        Dim SumW As Double = 0.0
        For i As Integer = 0 To dgvShowData.Rows.Count - 1
            SumW += dgvShowData.Rows(i).Cells("ColAmount").Value
        Next
        Me.txtSumW.Text = Format(SumW, "#,##0.00")
        Me.txtCount.Text = Format(dgvShowData.Rows.Count, "#,###")
    End Sub

    Private Sub BindPd()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Distinct idPd, PdName From vSeedProduct Where " & _
                              "idSeedType = '" & Me.cmbPlant.SelectedValue & "' Order By PdName Asc"
        sAdapter.Fill(sDt)

        With cmbPdName
            .DisplayMember = "PdName"
            .ValueMember = "idPd"
            .DataSource = sDt
        End With
    End Sub

    Private Sub BindPlant()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Distinct idSeedType, SeedTypeName From vSeedProduct Order By SeedTypeName Asc"
        sAdapter.Fill(sDt)

        With cmbPlant
            .DisplayMember = "SeedTypeName"
            .ValueMember = "idSeedType"
            .DataSource = sDt
        End With
    End Sub

    Private Sub ChkPlantType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPlantType.CheckedChanged
        If Me.ChkPlantType.Checked = True Then
            Me.cmbPlant.Enabled = True
            Me.cmbPlant.Focus()
            Me.ChkPdname.Enabled = True
            ' Me.cmbPdName.Enabled = True
        Else
            Me.cmbPlant.Enabled = False
            Me.ChkPdname.Enabled = False
            Me.ChkPdname.Checked = False
            Me.cmbPdName.Enabled = False
            Me.cmbPdName.SelectedValue = 0
        End If
    End Sub

    Private Sub ChkPdname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPdname.CheckedChanged
        If Me.ChkPdname.Checked = True Then
            Me.cmbPdName.Enabled = True
            Me.cmbPdName.Focus()
        Else
            Me.cmbPdName.Enabled = False
        End If
    End Sub

    Private Sub ChkGrade_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkGrade.CheckedChanged
        If Me.ChkGrade.Checked = True Then
            Me.txtGrade.Enabled = True
            Me.txtGrade.Focus()
        Else
            Me.txtGrade.Enabled = False
        End If
    End Sub

    Private Sub ChkGrow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkGrow.CheckedChanged
        If Me.ChkGrow.Checked = True Then
            Me.txtGrowS.Enabled = True
            Me.txtGrowE.Enabled = True
            Me.txtGrowS.Focus()
        Else
            Me.txtGrowS.Enabled = False
            Me.txtGrowE.Enabled = False
        End If
    End Sub

    Private Sub ChkHumid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkHumid.CheckedChanged
        If Me.ChkHumid.Checked = True Then
            Me.txtHumidS.Enabled = True
            Me.txtHumidE.Enabled = True
            Me.txtHumidS.Focus()
        Else
            Me.txtHumidS.Enabled = False
            Me.txtHumidE.Enabled = False
        End If
    End Sub

    Private Sub ChkPure_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPure.CheckedChanged
        If Me.ChkPure.Checked = True Then
            Me.txtPureS.Enabled = True
            Me.txtPureE.Enabled = True
            Me.txtPureS.Focus()
        Else
            Me.txtPureS.Enabled = False
            Me.txtPureE.Enabled = False

        End If
    End Sub


    Sub BindData()
        mdCnOpen()
        mdLoadShow()
        Dim vWhere As String = " "

        If Me.ChkPdNameL.Checked = True Then
            Dim tx As String = txtPdNameL.Text
            Dim tx_a As String() = tx.Split(" ")
            Dim a_and As String = ""
            Dim strPdPk As String = ""
            If tx_a.Length > 0 Then
                For Each txt As String In tx_a
                    If Not txt.Equals("") Then
                        strPdPk += a_and & "" & String.Format(" PdName Like '%{0}%' ", txt)
                    End If
                    a_and = " and "
                Next
            End If

            If strPdPk <> "" Then
                vWhere = vWhere & " WHERE " & strPdPk
            End If
        End If

        If Me.ChkLotLefCode.Checked = True Then
            If vWhere = " " Then
                vWhere = "Where s.LotCodeRef= '" & Me.txtLotSerial.Text & "' "
            Else
                vWhere = vWhere & "AND s.LotCodeRef= '" & Me.txtLotSerial.Text & "' "
            End If
        End If

        If Me.ChkLotNum.Checked = True Then
            If vWhere = " " Then
                vWhere = "Where s.LotNum = '" & Me.txtLotNum.Text & "' "
            Else
                vWhere = vWhere & "AND s.LotNum = '" & Me.txtLotNum.Text & "'"
            End If

        End If

        If Me.ChkPlantType.Checked = True Then
            If vWhere = " " Then
                vWhere = "Where p.idSeedType= '" & Me.cmbPlant.SelectedValue & "' "
            Else
                vWhere = vWhere & "AND p.idSeedType= '" & Me.cmbPlant.SelectedValue & "'"
            End If

        End If

        If Me.ChkPdname.Checked = True Then
            If vWhere = " " Then
                vWhere = "Where s.idPd= '" & Me.cmbPdName.SelectedValue & "' "
            Else
                vWhere = vWhere & "AND s.idPd= '" & Me.cmbPdName.SelectedValue & "' "
            End If
        End If

        If Me.ChkGrade.Checked = True Then
            If vWhere = " " Then
                vWhere = "Where s.Grad= '" & Trim(Me.txtGrade.Text) & "' "
            Else
                vWhere = vWhere & "AND s.Grad= '" & Trim(Me.txtGrade.Text) & "' "
            End If
        End If


        If Me.ChkNoPd.Checked = True Then
            If vWhere = " " Then
                vWhere = "Where s.Amount > '0' "
            Else
                vWhere = vWhere & "AND s.Amount > '0' "
            End If

        End If

        Dim vOrderBy As String = ""
        If stPage = 7 Then 'SelectSale
            vOrderBy = " s.DateRec "
        Else
            vOrderBy = " p.SeedTypeName "
        End If


        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "Select s.idPdLot, s.LotNum, s.LotCodeRef, s.idPd, p.PdName, p.SeedTypeName, " & _
                               "s.AmountRec, s.AmountUse, s.Amount, s.Grad, s.Grow, '' as Grow_, " & _
                               "s.Humid, '' as Humid_, s.Pure, '' as Pure_, " & _
                               "s.DateRec, s.DocPackCode, s.GrowRec, s.HumidRec, " & _
                               "s.PureRec, s.GrowAA, s.GrowTZ, s.GrowPaper, s.GrowSand, " & _
                               "s.Note From PkPdLotStock s LEFT OUTER JOIN vSeedProduct p " & _
                               "ON s.idPd = p.idPd " & vWhere & " Order by " & vOrderBy

        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสต๊อกสินค้าวัตถุดิบ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvShowData.DataSource = sDt
            'dgvShowData.Rows.Clear()
            Exit Sub
        Else
            For i As Integer = 0 To sDt.Rows.Count - 1
                sDt.Rows(i).Item("Grow_") = Val(sDt.Rows(i).Item("Grow"))
                sDt.Rows(i).Item("Humid_") = Val(sDt.Rows(i).Item("Humid"))
                sDt.Rows(i).Item("Pure_") = Val(sDt.Rows(i).Item("Pure"))
            Next

            If Me.ChkGrow.Checked = True Then
                If Val(Me.txtGrowS.Text) > Val(Me.txtGrowE.Text) Then
                    mdLoadCommitt()
                    MessageBox.Show("กรุณาระบุช่วงความงอกให้ถูกต้อง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    sDt.Clear()
                    dgvShowData.DataSource = sDt
                    'SumTotal()
                    Exit Sub
                Else
                    For i As Integer = 0 To sDt.Rows.Count - 1
                        If sDt.Rows(i).Item("Grow_") < Val(Me.txtGrowS.Text) Or sDt.Rows(i).Item("Grow_") > Val(Me.txtGrowE.Text) Then
                            sDt.Rows(i).Delete()
                        End If
                    Next
                    sDt.AcceptChanges()
                End If

            End If

            If Me.ChkHumid.Checked = True Then
                If Val(Me.txtHumidS.Text) > Val(Me.txtHumidE.Text) Then
                    mdLoadCommitt()
                    MessageBox.Show("กรุณาระบุช่วงความชื้นให้ถูกต้อง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    sDt.Clear()
                    dgvShowData.DataSource = sDt
                    'SumTotal()
                    Exit Sub
                Else
                    For i As Integer = 0 To sDt.Rows.Count - 1
                        If sDt.Rows(i).Item("Humid_") < Val(Me.txtHumidS.Text) Or sDt.Rows(i).Item("Humid_") > Val(Me.txtHumidE.Text) Then
                            sDt.Rows(i).Delete()
                        End If
                    Next
                    sDt.AcceptChanges()
                End If

            End If

            If Me.ChkPure.Checked = True Then
                If Val(Me.txtPureS.Text) > Val(Me.txtPureE.Text) Then
                    mdLoadCommitt()
                    MessageBox.Show("กรุณาระบุช่วงความบริสุทธิ์ให้ถูกต้อง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    sDt.Clear()
                    dgvShowData.DataSource = sDt
                    'SumTotal()
                    Exit Sub
                Else
                    For i As Integer = 0 To sDt.Rows.Count - 1
                        If sDt.Rows(i).Item("Pure_") < Val(Me.txtPureS.Text) Or sDt.Rows(i).Item("Pure_") > Val(Me.txtPureE.Text) Then
                            sDt.Rows(i).Delete()
                        End If
                    Next
                    sDt.AcceptChanges()
                End If
            End If

            dgvShowData.DataSource = sDt
            ksbCountRowDgv(dgvShowData, ColNum.Name)
            mdConvertDateInGrid(dgvShowData, ColDateRec)
            'ksbDgvConvertDateFormat(dgvShowData, ColDateRec.Name)
        End If

        mdLoadCommitt()
    End Sub

    Private Sub btnSFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSFindAll.Click
        BindData()
        SumTotal()
    End Sub

    Private Sub ChkNoPd_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNoPd.CheckedChanged
        BindData()
        SumTotal()
    End Sub

    Private Sub txtPdNameL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPdNameL.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindData()
            SumTotal()
        End If
    End Sub

    Private Sub txtLotSerial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLotSerial.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindData()
            SumTotal()
        End If
    End Sub

    Private Sub txtLotNum_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLotNum.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindData()
            SumTotal()
        End If
    End Sub

    'Private Sub dgvShowData_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvShowData.CellClick
    '    'Link to PdMixFG
    '    If dgvShowData.Columns(e.ColumnIndex).Name = Me.ColPdName.Name Then
    '        'Column PsName
    '        Dim vFrm As New frmPdMixFG(frmPdMixFG.eProcess.eLink, dgvShowData.CurrentRow.Cells("ColidPd").Value)
    '        vFrm.Show()
    '    End If
    'End Sub

    Private Sub dgvShowData_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvShowData.CellContentClick

        ''EditData
        'If dgvShowData.Columns(e.ColumnIndex).Name = ColEdit.Name Then
        '    Dim vFrm As New frmPdStockDetail(frmPdStockDetail.eProcess.eEdit, dgvShowData.CurrentRow.Cells("ColidPdLot").Value)
        '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        BindData()
        '    End If
        'End If

        'SelectData
        If dgvShowData.Columns(e.ColumnIndex).Name = Me.ColSelect.Name Then
            If dgvShowData.CurrentRow.Cells("ColAmount").Value = 0 And stPage = 3 Then
                MessageBox.Show("ไม่สามารถเลือกรายการที่มีน้ำหนักคงเหลือเท่ากับ 0 ได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                idPdLot = dgvShowData.Rows(e.RowIndex).Cells(ColidPdLot.Name).Value
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub dgvShowData_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvShowData.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If dgvShowData.CurrentCell.RowIndex < 0 Then
                Exit Sub
            End If

            If dgvShowData.Columns(dgvShowData.CurrentCell.ColumnIndex).Name = ColSelect.Name Then
                If dgvShowData.CurrentRow.Cells("ColAmount").Value = 0 And stPage = 3 Then
                    MessageBox.Show("ไม่สามารถเลือกรายการที่มีน้ำหนักคงเหลือเท่ากับ 0 ได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    idPdLot = dgvShowData.Rows(dgvShowData.CurrentCell.RowIndex).Cells(ColidPdLot.Name).Value
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub cmbPlant_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlant.SelectedIndexChanged
        BindPd()
    End Sub

    Private Sub ChkLotNum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkLotLefCode.CheckedChanged
        If Me.ChkLotLefCode.Checked = True Then
            Me.txtLotSerial.Enabled = True
            Me.txtLotSerial.Focus()
        Else
            Me.txtLotSerial.Enabled = False

        End If
    End Sub

    Private Sub dgvShowData_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvShowData.CellFormatting
        'If e.ColumnIndex = Me.dgvShowData.Columns("ColDateRec").Index AndAlso (e.Value IsNot Nothing) Then
        With Me.dgvShowData.Rows(e.RowIndex).Cells(e.ColumnIndex)
            .ToolTipText = "คลิกที่ชื่อสินค้าเพื่อแสดงส่วนผสม"
        End With

        'End If
    End Sub

    Private Sub ChkLotNum_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkLotNum.CheckedChanged
        If Me.ChkLotNum.Checked = True Then
            Me.txtLotNum.Enabled = True
            Me.txtLotNum.Focus()
        Else
            Me.txtLotNum.Enabled = False
        End If
    End Sub

    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click
        If stPage = 5 Then 'Checkbox
            Dim d As Integer = 0
            For i As Integer = 0 To Me.dgvShowData.Rows.Count - 1
                If Me.dgvShowData.Rows(i).Cells("ColChk").Value = True Then
                    Lot_temp.Rows.Add()
                    Lot_temp.Rows(d).Item("idPdLot") = Me.dgvShowData.Rows(i).Cells("ColidPdLot").Value
                    Lot_temp.Rows(d).Item("LotNo") = Me.dgvShowData.Rows(i).Cells("ColLotNum").Value
                    Lot_temp.Rows(d).Item("LotRefCode") = Me.dgvShowData.Rows(i).Cells("ColLotCodeRef").Value
                    Lot_temp.Rows(d).Item("PdName") = Me.dgvShowData.Rows(i).Cells("ColPdName").Value
                    Lot_temp.Rows(d).Item("Amount") = Me.dgvShowData.Rows(i).Cells("ColAmount").Value
                    Lot_temp.Rows(d).Item("idPd") = Me.dgvShowData.Rows(i).Cells("ColidPd").Value
                    d = d + 1
                End If
            Next
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub



    ''' MinMax

    Private Sub ChkPlantType2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPlantType2.CheckedChanged
        If ChkPlantType2.Checked = True Then
            BindPlant()
            cmbPlant2.Enabled = True
            ChkPdname2.Enabled = True
        Else
            cmbPlant2.Enabled = False
            ChkPdname2.Enabled = False
        End If
    End Sub

    Private Sub ChkPdname2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPdname2.CheckedChanged
        If ChkPdname2.Checked = True Then
            BindPd()
            cmbPdName2.Enabled = True
        Else
            cmbPdName2.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ShowDataOnGrid()
    End Sub

    Private Sub ShowDataOnGrid()
        mdCnOpen()
        mdLoadShow()
        Dim sDt As New DataTable
        Dim vWhere As String = "WHERE 1=1 AND PdName <>  '-'  "

        If ChkPlantType2.Checked = True Then
            vWhere &= " AND  idSeed = " & cmbPlant2.SelectedValue
        End If
        If ChkPdname2.Checked = True Then
            vWhere &= " AND  idSeedType = " & cmbPdName2.SelectedValue
        End If
        If CHKFixMinMax.Checked = True Then
            vWhere &= " AND  MinOld <> 0 AND MaxOld <> 0 "
        End If
        If CHKMin.Checked = True Then
            vWhere &= " AND  MinOld <> 0 AND MaxOld <> 0 AND MinOld >= (SELECT SUM(Amount) AS AmountSum FROM dbo.PkPdLotStock WHERE (idPd = derivedtbl_1.idPd)) "
        End If
        If CHKMax.Checked = True Then
            vWhere &= " AND  MinOld <> 0 AND MaxOld <> 0 AND MaxOld <= (SELECT SUM(Amount) AS AmountSum FROM dbo.PkPdLotStock WHERE (idPd = derivedtbl_1.idPd)) "
        End If

        mdCnOpen()
        sCommand.CommandText = "SELECT idPd, PdName, (SELECT SUM(Amount) AS AmountSum FROM dbo.PkPdLotStock WHERE (idPd = derivedtbl_1.idPd)) AS Amount , MinOld, MaxOld, idSeed, idSeedType,Note FROM (SELECT   dS.idPd, dS.PdName, dS.MinPacking AS MinOld, dS.MaxPacking AS MaxOld, vS.idSeed, dS.idSeedType , '' AS Note " & _
        " FROM dbo.dSeedProduct AS dS LEFT OUTER JOIN dbo.vSeedProduct AS vS ON dS.idPd = vS.idPd) AS derivedtbl_1  " & vWhere
        sAdapter.Fill(sDt)

        For i As Integer = 0 To sDt.Rows.Count - 1
            If sDt.Rows(i).Item("MinOld") Is DBNull.Value Then
                sDt.Rows(i).Item("MinOld") = "0"
            End If
            If sDt.Rows(i).Item("Amount") Is DBNull.Value Then
                sDt.Rows(i).Item("Amount") = "0"
            End If

            If sDt.Rows(i).Item("MaxOld") Is DBNull.Value Then
                sDt.Rows(i).Item("MaxOld") = "0"
            End If

            If sDt.Rows(i).Item("Amount") <= sDt.Rows(i).Item("MinOld") Then
                sDt.Rows(i).Item("Note") = "มีจำนวนน้อยกว่ากำหนด"
            End If

            If sDt.Rows(i).Item("Amount") >= sDt.Rows(i).Item("MaxOld") Then
                sDt.Rows(i).Item("Note") = "มีจำนวนมากกว่ากำหนด"
            End If

            If sDt.Rows(i).Item("MaxOld") = 0 And sDt.Rows(i).Item("MinOld") = 0 Then
                sDt.Rows(i).Item("Note") = "ยังไม่ได้กำหนดค่า"
            End If
        Next

        dgvPd.DataSource = sDt

        For i As Integer = 0 To dgvPd.Rows.Count - 1
            If dgvPd.Rows(i).Cells(Note.Name).Value.ToString = "มีจำนวนมากกว่ากำหนด" Then
                dgvPd.Rows(i).Cells(Note.Name).Style.BackColor = Color.Salmon
            End If
            If dgvPd.Rows(i).Cells(Note.Name).Value.ToString = "มีจำนวนน้อยกว่ากำหนด" Then
                dgvPd.Rows(i).Cells(Note.Name).Style.BackColor = Color.CornflowerBlue
            End If
        Next
        lbtotal.Text = "รายการทั้งหมด " & dgvPd.Rows.Count.ToString & " รายการ"
        If dgvPd.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบรายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        mdLoadCommitt()
    End Sub

    Private Sub cmbPlant2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlant2.SelectedIndexChanged
        BindPd2()
    End Sub

    Private Sub BindPd2()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Distinct idSeedType, SeedTypeName From vSeedProduct Where idSeed = '" & Me.cmbPlant2.SelectedValue & "' Order By SeedTypeName Asc"
        sAdapter.Fill(sDt)

        With cmbPdName2
            .DisplayMember = "SeedTypeName"
            .ValueMember = "idSeedType"
            .DataSource = sDt
        End With
    End Sub

    Private Sub BindPlant2()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Distinct idSeed, SeedName From vSeedProduct Order By SeedName Asc"
        sAdapter.Fill(sDt)

        With cmbPlant2
            .DisplayMember = "SeedName"
            .ValueMember = "idSeed"
            .DataSource = sDt
        End With
    End Sub


    Private Sub dgvExpense_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvPd.RowPostPaint
        Me.dgvPd("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub


    Private Sub ChkPdNameL_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPdNameL.CheckedChanged
        If Me.ChkPdNameL.Checked = True Then
            Me.txtPdNameL.Enabled = True
        Else
            Me.txtPdNameL.Enabled = False
        End If
    End Sub




End Class

