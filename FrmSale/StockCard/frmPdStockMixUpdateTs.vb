Public Class frmPdStockMixUpdateTs
    Dim idPdLot_ As Integer = 0
    Dim Amount_ As Double = 0
    Dim AmountUse As Double = 0.0
    Dim eEvent As eProcess
    Dim stPage = 0
    Dim idPacking_ As Integer = 0
    Dim Result As DialogResult

    Enum eProcess
        eShowData
        eDelete
        eShowDataCard
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idPacking As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eShowData
                stPage = 1
            Case eProcess.eDelete
                stPage = 2
            Case eProcess.eShowDataCard
                stPage = 3
        End Select
        eEvent = aProcess
        idPacking_ = idPacking

    End Sub

    Private Sub frmPdStockMixUpdateTs_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If stPage = 1 Then
            Dim vFrm As New frmPdStock(frmPdStock.eProcess.eSelect, "")
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.idPdLot_ = vFrm.idPdLot
                'Me.Show()

                mdCnOpen()
                Dim sDt As New DataTable
                sDt.Clear()
                sCommand.CommandText = "Select s.idPdLot, s.LotNum, s.LotCodeRef, p.PdName, p.SeedTypeName, s.Amount, " & _
                                        "s.AmountUse From PkPdLotStock s " & _
                                       "LEFT OUTER JOIN vSeedProduct p " & _
                                       "ON s.idPd = p.idPd Where idPdLot = '" & idPdLot_ & "'"
                sAdapter.Fill(sDt)

                Me.txtLotNo.Text = sDt.Rows(0).Item("LotNum").ToString
                Me.lblPlantName.Text = sDt.Rows(0).Item("SeedTypeName")
                Me.lblPdName.Text = sDt.Rows(0).Item("PdName")
                Me.lblSerial.Text = sDt.Rows(0).Item("LotCodeRef")
                Me.txtWeightBf.Text = sDt.Rows(0).Item("Amount")
                AmountUse = sDt.Rows(0).Item("AmountUse")
                Me.lblPsTs.Text = sPsName
                Me.lblPsTs.Tag = sPsId
                Me.lblDateTs.Text = Date.Today

                '---Bind Data to Datagrid----'
                mdCnOpen()
                Dim vDt As New DataTable
                vDt.Clear()
                sCommand.CommandText = "Select m.idPacking, m.DateUpdate, m.AmountBf, m.AmountTs, m.AmountBl, " & _
                                       "m.Note, p.PsName As PsUpdate From PkPdMixPacking m " & _
                                       "LEFT OUTER JOIN vPerson p ON m.idPsUpdate = p.idPs Where m.idPdLot = '" & idPdLot_ & "'"
                sAdapter.Fill(vDt)

                If vDt.Rows.Count = 0 Then
                    'MessageBox.Show("ไม่พบข้อมูล", sSystemName)
                    dgvShowData.DataSource = vDt
                    Exit Sub
                Else
                    dgvShowData.DataSource = vDt
                    ksbCountRowDgv(dgvShowData, ColNum.Name)
                    ksbDgvConvertDateFormat(dgvShowData, ColDateUpdate.Name)
                    'ConvertDateInGrid(dgvShowData, ColDateUpdate)
                End If
            Else
                Me.Close()
            End If 'End Result OK
        ElseIf stPage = 2 Then
            Me.Text = "ยกเลิกรายการเบิกสต๊อกวัตถุดิบ"
            mdCnOpen()
            Dim sDt As New DataTable
            sDt.Clear()
            sCommand.CommandText = "Select u.idPdLot, s.LotNum, s.LotCodeRef, p.PdName, p.SeedTypeName, " & _
                                   "u.DateUpdate, ps.PsName as PsUpdate, ps2.PsName as PsTs, s.AmountUse, " & _
                                   "u.DateTs, u.AmountBf, u.AmountTs, u.AmountBl, u.Note From PkPdMixPacking u " & _
                                   "LEFT OUTER JOIN PkPdLotStock s ON u.idPdLot = s.idPdLot " & _
                                   "LEFT OUTER JOIN vSeedProduct p ON s.idPd = p.idPd " & _
                                   "LEFT OUTER JOIN vPerson ps ON u.idPsUpdate = ps.idPs " & _
                                   "LEFT OUTER JOIN vPerson ps2 ON u.idPsTs = ps2.idPs Where u.idPacking = '" & idPacking_ & "'"
            sAdapter.Fill(sDt)

            idPdLot_ = sDt.Rows(0).Item("idPdLot").ToString
            AmountUse = sDt.Rows(0).Item("AmountUse")
            Me.txtLotNo.Text = sDt.Rows(0).Item("LotNum").ToString
            Me.lblPlantName.Text = sDt.Rows(0).Item("SeedTypeName").ToString
            Me.lblPdName.Text = sDt.Rows(0).Item("PdName").ToString
            Me.lblSerial.Text = sDt.Rows(0).Item("LotCodeRef").ToString
            Me.dtpUpdate.Value = ksbStringToDate(sDt.Rows(0).Item("DateUpdate"))
            Me.lblPsUpdate.Text = sDt.Rows(0).Item("PsUpdate").ToString
            Me.lblPsTs.Text = sDt.Rows(0).Item("PsTs").ToString
            Me.lblDateTs.Text = ksbStringToDate(sDt.Rows(0).Item("DateTs"))
            Me.txtWeightBf.Text = Format(sDt.Rows(0).Item("AmountBf"), "#,##0.00")
            Me.txtWeightTs.Text = Format(sDt.Rows(0).Item("AmountTs"), "#,##0.00")
            Me.txtWeightBl.Text = Format(sDt.Rows(0).Item("AmountBl"), "#,##0.00")
            Me.txtNote.Text = sDt.Rows(0).Item("Note").ToString
            Me.dtpUpdate.Enabled = False
            Me.txtWeightTs.Enabled = False
            Me.txtNote.Enabled = False
            Me.btnPsUpdate.Enabled = False
            Me.btnSave.Visible = False
            Me.btnDelete.Visible = True


            '---Bind Data to Datagrid----'
            mdCnOpen()
            Dim vDt As New DataTable
            vDt.Clear()
            sCommand.CommandText = "Select m.idPacking, m.DateUpdate, m.AmountBf, m.AmountTs, m.AmountBl, " & _
                                   "m.Note, p.PsName As PsUpdate From PkPdMixPacking m " & _
                                   "LEFT OUTER JOIN vPerson p ON m.idPsUpdate = p.idPs Where m.idPdLot = '" & idPdLot_ & "'"
            sAdapter.Fill(vDt)

            If vDt.Rows.Count = 0 Then
                'MessageBox.Show("ไม่พบข้อมูล", sSystemName)
                dgvShowData.DataSource = vDt
                Exit Sub
            Else
                dgvShowData.DataSource = vDt
                ksbCountRowDgv(dgvShowData, ColNum.Name)
                ' ConvertDateInGrid(dgvShowData, ColDateUpdate)
            End If
        ElseIf stPage = 3 Then
            Me.Text = "รายการเบิกสต๊อกวัตถุดิบ"
            mdCnOpen()
            Dim sDt As New DataTable
            sDt.Clear()
            sCommand.CommandText = "Select u.idPdLot, s.LotNum, s.LotCodeRef, p.PdName, p.SeedTypeName, " & _
                                   "u.DateUpdate, ps.PsName as PsUpdate, ps2.PsName as PsTs, s.AmountUse, " & _
                                   "u.DateTs, u.AmountBf, u.AmountTs, u.AmountBl, u.Note From PkPdMixPacking u " & _
                                   "LEFT OUTER JOIN PkPdLotStock s ON u.idPdLot = s.idPdLot " & _
                                   "LEFT OUTER JOIN vSeedProduct p ON s.idPd = p.idPd " & _
                                   "LEFT OUTER JOIN vPerson ps ON u.idPsUpdate = ps.idPs " & _
                                   "LEFT OUTER JOIN vPerson ps2 ON u.idPsTs = ps2.idPs Where u.idPacking = '" & idPacking_ & "'"
            sAdapter.Fill(sDt)

            idPdLot_ = sDt.Rows(0).Item("idPdLot").ToString
            AmountUse = sDt.Rows(0).Item("AmountUse")
            Me.txtLotNo.Text = sDt.Rows(0).Item("LotNum").ToString
            Me.lblPlantName.Text = sDt.Rows(0).Item("SeedTypeName").ToString
            Me.lblPdName.Text = sDt.Rows(0).Item("PdName").ToString
            Me.lblSerial.Text = sDt.Rows(0).Item("LotCodeRef").ToString
            Me.dtpUpdate.Value = ksbStringToDate(sDt.Rows(0).Item("DateUpdate"))
            Me.lblPsUpdate.Text = sDt.Rows(0).Item("PsUpdate").ToString
            Me.lblPsTs.Text = sDt.Rows(0).Item("PsTs").ToString
            Me.lblDateTs.Text = ksbStringToDate(sDt.Rows(0).Item("DateTs"))
            Me.txtWeightBf.Text = Format(sDt.Rows(0).Item("AmountBf"), "#,##0.00")
            Me.txtWeightTs.Text = Format(sDt.Rows(0).Item("AmountTs"), "#,##0.00")
            Me.txtWeightBl.Text = Format(sDt.Rows(0).Item("AmountBl"), "#,##0.00")
            Me.txtNote.Text = sDt.Rows(0).Item("Note").ToString
            Me.dtpUpdate.Enabled = False
            Me.txtWeightTs.Enabled = False
            Me.txtNote.Enabled = False
            Me.btnPsUpdate.Enabled = False
            Me.btnSave.Visible = False
            Me.btnDelete.Visible = False


            '---Bind Data to Datagrid----'
            mdCnOpen()
            Dim vDt As New DataTable
            vDt.Clear()
            sCommand.CommandText = "Select m.idPacking, devsk.fncStrDateToDateTime(m.DateUpdate) As DateUpdate, m.AmountBf, m.AmountTs, m.AmountBl, " & _
                                   "m.Note, p.PsName As PsUpdate From PkPdMixPacking m " & _
                                   "LEFT OUTER JOIN vPerson p ON m.idPsUpdate = p.idPs Where m.idPdLot = '" & idPdLot_ & "'"
            sAdapter.Fill(vDt)

            If vDt.Rows.Count = 0 Then
                'MessageBox.Show("ไม่พบข้อมูล", sSystemName)
                dgvShowData.DataSource = vDt
                Exit Sub
            Else
                dgvShowData.DataSource = vDt
                ksbCountRowDgv(dgvShowData, ColNum.Name)
                'ConvertDateInGrid(dgvShowData, ColDateUpdate)
            End If

        End If 'End stPage

    End Sub


    Private Sub btnPsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPsUpdate.Click
        Dim vFrm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPsUpdate.Tag = vFrm.mId
            Me.lblPsUpdate.Text = vFrm.mName
        End If
    End Sub

    Private Sub txtWeightBf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWeightBf.TextChanged
        If Trim(Me.txtWeightBf.Text) = "" Then
            Me.txtWeightBf.Text = 0
        End If

        If Trim(Me.txtWeightTs.Text) = "" Then
            Me.txtWeightTs.Text = 0
        End If

        Amount_ = CDbl(Trim(Me.txtWeightBf.Text)) - CDbl(Trim(Me.txtWeightTs.Text))
        Me.txtWeightBl.Text = Format(Amount_, "#,##0.00")
    End Sub

    Private Sub txtWeightTs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWeightTs.TextChanged
        If Trim(Me.txtWeightBf.Text) = "" Then
            Me.txtWeightBf.Text = 0
        End If

        If Trim(Me.txtWeightTs.Text) = "" Then
            Me.txtWeightTs.Text = 0
        End If

        Amount_ = CDbl(Trim(Me.txtWeightBf.Text)) - CDbl(Trim(Me.txtWeightTs.Text))
        Me.txtWeightBl.Text = Format(Amount_, "#,##0.00")
    End Sub

    Private Sub txtWeightTs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeightTs.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '----insert---'
        If Me.lblPsUpdate.Text = "" Then
            MessageBox.Show("กรุณาระบุผู้ดำเนินการ", sSystemName)
            Exit Sub
        ElseIf Me.txtWeightTs.Text = "0" Then
            MessageBox.Show("กรุณาระบุน้ำหนักใช้ไป", sSystemName)
            Exit Sub
        ElseIf CDbl(Me.txtWeightTs.Text) > CDbl(Me.txtWeightBf.Text) Then
            MessageBox.Show("น้ำหนักใช้ไปมากกว่าน้ำหนักคงเหลือ ไม่สามารถทำรายการได้", sSystemName)
            Exit Sub
        Else
            mdCnOpen()
            Dim CheckDt As New DataTable
            CheckDt.Clear()
            sCommand.CommandText = "Select idPacking From PkPdMixPacking Where idPdLot = '" & idPdLot_ & "' " & _
                                   "AND DateUpdate ='" & ksbDateToString(dtpUpdate.Value.ToShortDateString) & "'"
            sAdapter.Fill(CheckDt)

            If CheckDt.Rows.Count <> 0 Then
                Result = MsgBox("มีการเบิกสต๊อกในวันที่ดังกล่าวไปแล้ว คุณต้องการทำรายการเบิกสต๊อกอีกครั้งหรือไม่", MsgBoxStyle.YesNo)
                If Result = Windows.Forms.DialogResult.Yes Then
                    mdLoadShow()
                    AddPkPdMixPacking() '---Add New data to PkPdMixPacking---'
                    UpdatePkPdLotStock() '---Update PkPdLotStock---'
                    mdLoadCommitt()

                    MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            Else
                mdLoadShow()
                AddPkPdMixPacking() '---Add New data to PkPdMixPacking---'
                UpdatePkPdLotStock() '---Update PkPdLotStock---'
                mdLoadCommitt()

                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If


        End If

    End Sub

    Sub AddPkPdMixPacking()
        mdCnOpen()
        sCommand.CommandText = "Insert Into PkPdMixPacking(idPdLot, DateUpdate, DateTs, AmountBf, AmountTs,AmountBl, " & _
                               "idPsUpdate, idPsTs, Note) Values('" & idPdLot_ & "', " & _
                               "'" & ksbDateToString(dtpUpdate.Value.ToShortDateString) & "', " & _
                                "'" & ksbDateToString(lblDateTs.Text) & "', '" & CDbl(Me.txtWeightBf.Text) & "', " & _
                                "'" & CDbl(Me.txtWeightTs.Text) & "', '" & CDbl(Me.txtWeightBl.Text) & "', " & _
                                "'" & Me.lblPsUpdate.Tag & "', '" & Me.lblPsTs.Tag & "', '" & Trim(Me.txtNote.Text) & "')"
        Dim idVal As Integer = mdCnOpenQueryIdentity(sCommand.CommandText)
        ' PdMixStockCard(2, idPdLot_, CDbl(Me.txtWeightTs.Text), "WIM: ทำรายการเบิกวัตถุดิบ", idVal)
       
    End Sub

    Sub UpdatePkPdLotStock()
        Dim AmtUseUpdate As Double = 0.0

        AmtUseUpdate = AmountUse + CDbl(Me.txtWeightTs.Text)

        mdCnOpen()
        sCommand.CommandText = "Update PkPdLotStock Set AmountUse='" & AmtUseUpdate & "', " & _
                               "Amount='" & CDbl(Me.txtWeightBl.Text) & "', idPsUpdate ='" & sPsId & "', " & _
                               "DateUpdate ='" & ksbDateToString(Date.Today) & "' Where idPdLot ='" & idPdLot_ & "'"
        sCommand.ExecuteNonQuery()


    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Result = MsgBox("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", MsgBoxStyle.YesNo)

        If Result = Windows.Forms.DialogResult.Yes Then
            mdCnOpen()
            Dim delDt As New DataTable
            delDt.Clear()
            sCommand.CommandText = "Select Max(idPacking) as Max_idPacking From PkPdMixPacking Where idPdLot = '" & idPdLot_ & "'"
            sAdapter.Fill(delDt)

            If idPacking_ = delDt.Rows(0).Item("Max_idPacking").ToString Then
                '---Update PkPdLotStock: return amount value----'
                Dim AmtUseReturn As Double = 0.0
                Dim NewAmount As Double = 0.0

                AmtUseReturn = AmountUse - CDbl(Me.txtWeightTs.Text)
                NewAmount = CDbl(Me.txtWeightBf.Text)

                sCommand.CommandText = "Update PkPdLotStock Set AmountUse='" & AmtUseReturn & "', " & _
                                       "Amount='" & NewAmount & "', idPsUpdate ='" & sPsId & "', " & _
                                       "DateUpdate ='" & ksbDateToString(Date.Today) & "' Where idPdLot ='" & idPdLot_ & "'"
                sCommand.ExecuteNonQuery()

                '---Delete PkPdMixPacking---'
                sCommand.CommandText = "Delete PkPdMixPacking Where idPacking ='" & idPacking_ & "'"
                sCommand.ExecuteNonQuery()

                MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", sSystemName)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                '---Not Delete---'
                MessageBox.Show("รายการดังกล่าว ไม่ใช่รายการเบิกสต๊อกล่าสุดของ Lot จึงไม่สามารถลบได้", sSystemName)
                Exit Sub
            End If
        End If 'Ebd DialogResult

    End Sub

    Private Sub frmPdStockMixUpdateTs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class