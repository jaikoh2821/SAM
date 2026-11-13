Public Class frmPkPackingTs
    Dim PkgDt As New DataTable 'เก็บ Package ที่เลือก
    Dim LotUseDt As New DataTable 'เก็บ lot ที่ใช้ เพื่อลง DB
    Dim idPdT_ As Integer = 0
    Dim PdTName As String = ""
    Dim AmountPkTs_gum As Double = 0 'จำนวนที่ต้องการบรรจุ(กรัม)
    Dim AmountPkTs_kg As Double = 0 'จำนวนที่ต้องการบรรจุ(กิโลกรัม)
    Dim idFl_Now As Integer = 0 'สูตรที่เลือก
    Dim stPage As Integer = 0
    Dim idPacking_sent As Integer = 0
    Dim stIntr As Integer = 0
    Dim UsePkOpen As Integer = 0 'สถานะการใช้ฝา
    Dim stConfirm As Integer = 0 'ตรวจสอบสถานะยืนยัน
    Dim stFlChk As Integer = 0 'สถานะ load tabindex 2
    Dim stLoad As Integer = 0
    'Public idPdLotCut As New DataTable 'เก็บ idPdLot ที่เลือกมาแล้ว

    Dim Result As DialogResult
    Dim eEvent As eProcess

    Enum eProcess
        eNew
        eviewData
        eCancel
        eConfirm
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idPacking As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eNew
                stPage = 1
            Case eProcess.eviewData
                stPage = 2
                idPacking_sent = idPacking
            Case eProcess.eCancel
                stPage = 3
                idPacking_sent = idPacking
            Case eProcess.eConfirm
                stPage = 4
                idPacking_sent = idPacking
        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmPdPackingTs_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If stPage = 1 Then 'New
            PkgDt.Columns.Add("idPdPk", System.Type.GetType("System.String"))
            PkgDt.Columns.Add("idPkUnit", System.Type.GetType("System.String"))
            PkgDt.Columns.Add("PkName", System.Type.GetType("System.String"))
            PkgDt.Columns.Add("Weight", System.Type.GetType("System.Double"))
            PkgDt.Columns.Add("UnitW", System.Type.GetType("System.String"))
            PkgDt.Columns.Add("idUnitW", System.Type.GetType("System.String"))
            PkgDt.Columns.Add("status", System.Type.GetType("System.String"))
            PkgDt.Columns.Add("PackageAmt", System.Type.GetType("System.Double"))
            PkgDt.Columns.Add("AmtTs", System.Type.GetType("System.Double"))
            PkgDt.Columns.Add("TotalW", System.Type.GetType("System.Double"))
            PkgDt.Columns.Add("idPkDetail", System.Type.GetType("System.Int32"))
            PkgDt.Columns.Add("idLabel", System.Type.GetType("System.Int32"))
            PkgDt.Columns.Add("idPkDtOpen", System.Type.GetType("System.Int32"))

            LotUseDt.Columns.Add("idPdMixLot", System.Type.GetType("System.Int32"))
            LotUseDt.Columns.Add("Amount", System.Type.GetType("System.Double"))

            'idPdLotCut.Columns.Add("idPdLot", System.Type.GetType("System.Int32"))

            Me.lblDateTs.Text = Date.Today
            Me.lblPsTs.Text = sPsName
            Me.lblPsTs.Tag = sPsId

            ''--- Select PdTrandName ---'
            'Dim vFrm As New frmSlPdTradeSelectPacking
            'If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    mdLoadShow()

            '    If vFrm.stOrder = 1 Then
            '        Me.lblOrderAmt.Text = Format(vFrm.OrderAmt, "#,##0")
            '        Me.lblOrderAmt.Visible = True
            '        Me.Label35.Visible = True
            '        Me.Label38.Visible = True
            '    Else
            '        Me.lblOrderAmt.Visible = False
            '        Me.Label35.Visible = False
            '        Me.Label38.Visible = False
            '    End If


            '    Me.idPdT_ = vFrm.pIdT
            '    Me.PdTName = vFrm.pName

            '    Me.lblPdTName.Tag = idPdT_
            '    Me.lblPdTName.Text = PdTName

            '    Me.dtpDatePacking.Value = Date.Today
            '    Me.dtpCombine.Value = Date.Today

            '    Dim stFlMsg As Integer = 0
            '    Dim stPkMsg As Integer = 0
            '    '--- Show Formula ---'
            '    mdCnOpen()
            '    Dim sDt As New DataTable
            '    sDt.Clear()
            '    sCommand.CommandText = "Select idFL, FlName, Note From SlPdFormula " & _
            '                           "WHERE idPdT = " & Me.lblPdTName.Tag & " Order By FlName"
            '    sAdapter.Fill(sDt)

            '    If sDt.Rows.Count <> 0 Then
            '        Me.DGV_formula.DataSource = sDt
            '        Me.lblMsg.Visible = False
            '    Else
            '        Me.DGV_formula.DataSource = sDt
            '        Me.lblMsg.Visible = True
            '        stFlMsg = 1 'ไม่มีสูตร
            '    End If
            '    Me.DGV_formula.Enabled = False

            '    ''--- Check Fl Status---'
            '    'For i As Integer = 0 To DGV_formula.Rows.Count - 1
            '    '    Dim stFlCheck As Integer = 0
            '    '    Dim fDt As New DataTable
            '    '    sCommand.CommandText = "Select Sl.idPd, (SELECT SUM(Amount) AS Expr1 FROM PkPdLotStock " & _
            '    '                           "WHERE idPd = Sl.idPd) AS StockAmt " & _
            '    '                           "From SlPdIngredient Sl Where Sl.idPdT =" & Me.lblPdTName.Tag & " " & _
            '    '                           "And Sl.idFl =" & DGV_formula.Rows(i).Cells(colidFL.Name).Value & " "
            '    '    sAdapter.Fill(fDt)
            '    '    For f As Integer = 0 To fDt.Rows.Count - 1
            '    '        If IsDBNull(fDt.Rows(f).Item("StockAmt")) Then
            '    '            stFlCheck = 1
            '    '        End If
            '    '    Next

            '    '    If stFlCheck = 1 Then 'ไม่สามารถผลิตได้ Color LemonChiffon
            '    '        DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '    '    Else 'สามารถผลิตได้ color green
            '    '        DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.PaleGreen
            '    '    End If
            '    'Next

            '    '---Show Packing List ---'
            '    Dim vDt As New DataTable
            '    vDt.Clear()
            '    sCommand.CommandText = "Select dPD.idPkDetail, dPD.SizeName, vPP.Weight, u.UnitW, " & _
            '                           "vPP.idUnitW, ISNull(dPD.Amount,0) As Amount, " & _
            '                           "'0' as AmtTs, dPD.idPkUnit,vPP.idPdPk, vPP.PdPkName " & _
            '                           "From dPackingDetail dPD " & _
            '                           "INNER JOIN vPackingPdSet vPP ON vPP.idPkDetail = dPD.idPkDetail " & _
            '                           "INNER JOIN dUnitW u ON vPP.idUnitW = u.idUnitW " & _
            '                           "WHERE dPD.idPkUnit <> 7 AND vPP.idPdT = " & Me.lblPdTName.Tag & " ORDER BY " & _
            '                           "u.UnitW, vPP.Weight DESC"
            '    sAdapter.Fill(vDt)

            '    If vDt.Rows.Count = 0 Then
            '        Me.lblNoPakage.Visible = True
            '        Me.dgvPkPdSet.DataSource = vDt
            '        stPkMsg = 1 'ไม่มี Pk
            '        'Exit Sub
            '    Else
            '        Me.lblNoPakage.Visible = False
            '        Me.dgvPkPdSet.DataSource = vDt
            '    End If

            '    For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
            '        If dgvPkPdSet.Rows(i).Cells("idPdPk").Value = vFrm.pidPdPk Then
            '            dgvPkPdSet.Rows(i).Cells("colSelect").Value = True
            '            Me.dgvPkPdSet.Rows(i).Cells(key.Name).Value = 1
            '            dgvPkPdSet.Rows(i).DefaultCellStyle.ForeColor = Color.DodgerBlue
            '        End If
            '    Next

            '    '----------Show Box-----------'
            '    Dim BoxDt As New DataTable
            '    BoxDt.Clear()
            '    sCommand.CommandText = "SELECT idPkDetail, 'กล่อง ' + SizeName + ' (' + CONVERT(varchar, Width) + " & _
            '                           "' x ' + CONVERT(varchar, Length) + ' x ' + CONVERT(varchar, Height) + ')' " & _
            '                           "As SizeName , Amount, 0 As AmtTs FROM dPackingDetail WHERE idPkUnit = 3"
            '    sAdapter.Fill(BoxDt)

            '    If BoxDt.Rows.Count = 0 Then
            '        Me.DGV_Box.DataSource = BoxDt
            '    Else
            '        Me.DGV_Box.DataSource = BoxDt

            '        DGV_Box.Rows(0).DefaultCellStyle.ForeColor = Color.DodgerBlue
            '        DGV_Box.Rows(0).Cells(ColSelectBox.Name).Value = True
            '        DGV_Box.Rows(0).Cells(ColSelectBox.Name).ReadOnly = True
            '    End If

            '    Me.TabControl1.SelectedIndex = 2
            '    Me.TabControl1.SelectedIndex = 0

            '    mdLoadCommitt()
            '    If stFlMsg = 1 And stPkMsg = 0 Then
            '        MessageBox.Show("ไม่พบข้อมูลสูตรสินค้าของ : " & Me.lblPdTName.Text, sSystemName)
            '    ElseIf stFlMsg = 0 And stPkMsg = 1 Then
            '        MessageBox.Show("ไม่พบข้อมูล Packing ของ : " & Me.lblPdTName.Text, sSystemName)
            '    ElseIf stFlMsg = 1 And stPkMsg = 1 Then
            '        MessageBox.Show("ไม่พบข้อมูล Package และข้อมูลสูตรสินค้าของ : " & Me.lblPdTName.Text, sSystemName)
            '    End If
            '    Exit Sub
            'End If
        Else 'ViewData & Cancel
            mdLoadShow()
            Me.Text = "รายละเอียดรายการ Packing สินค้าสำเร็จรูป"
            Me.TabControl1.SelectedIndex = 1
            Me.TabControl1.SelectedIndex = 2
            Me.TabControl1.SelectedIndex = 3
            Me.TabControl1.SelectedIndex = 0
            Dim idFL_Show As Integer = 0

            '*****Show data from PkPackingMt******'
            mdCnOpen()
            Dim vDt As New DataTable
            vDt.Clear()
            sCommand.CommandText = "SELECT mt.idPdT, Pd.PdTradeName, mt.JobNo, mt.DatePacking, " & _
                                   "DateCombine, Grad, DateTest, DateExp, " & _
                                   "p1.PsName as PsCommand, p2.PsName as PsPacking, mt.DateTs, " & _
                                   "p3.PsName as PsTs, mt.Note, mt.idFl, mt.TotalAmount, mt.stConfirm " & _
                                   "FROM PkPackingMt mt LEFT OUTER JOIN vSlPdTradeNameD Pd " & _
                                   "ON mt.idPdT = Pd.idPdT LEFT OUTER JOIN vPerson p1 " & _
                                   "ON mt.idPsCommand = p1.idPs LEFT OUTER JOIN vPerson p2 " & _
                                   "ON mt.idPsPacking = p2.idPs LEFT OUTER JOIN vPerson p3 " & _
                                   "ON mt.idPsTs = p3.idPs WHERE idPacking = '" & idPacking_sent & "'"
            sAdapter.Fill(vDt)

            If Not IsDBNull(vDt.Rows(0).Item("stConfirm")) Then
                stConfirm = vDt.Rows(0).Item("stConfirm")
            End If
            Me.lblPdTName.Text = vDt.Rows(0).Item("PdTradeName")
            Me.lblPdTName.Tag = vDt.Rows(0).Item("idPdT")
            Me.lblJobNo.Text = vDt.Rows(0).Item("JobNo")
            Me.dtpDatePacking.Value = ksbStringToDate(vDt.Rows(0).Item("DatePacking"))
            If Not IsDBNull(vDt.Rows(0).Item("DateCombine")) Then
                Me.dtpCombine.Value = ksbStringToDate(vDt.Rows(0).Item("DateCombine"))
            End If
            If Not IsDBNull(vDt.Rows(0).Item("Grad")) Then
                If vDt.Rows(0).Item("Grad") = "A" Then
                    Me.rdbA.Checked = True
                ElseIf vDt.Rows(0).Item("Grad") = "B" Then
                    Me.rdbB.Checked = True
                End If
            End If
            If Not IsDBNull(vDt.Rows(0).Item("DateTest")) Then
                Me.dtpTest.Value = ksbStringToDate(vDt.Rows(0).Item("DateTest"))
            End If
            If Not IsDBNull(vDt.Rows(0).Item("DateExp")) Then
                Me.dtpExp.Value = ksbStringToDate(vDt.Rows(0).Item("DateExp"))
            End If
            Me.lblPsCommand.Text = vDt.Rows(0).Item("PsCommand")
            Me.lblPsPacking.Text = vDt.Rows(0).Item("PsPacking")
            Me.lblDateTs.Text = ksbStringToDate(vDt.Rows(0).Item("DateTs"))
            Me.lblPsTs.Text = vDt.Rows(0).Item("PsTs")
            Me.txtNote.Text = vDt.Rows(0).Item("Note")
            Me.txtAmtTotal.Text = Format(vDt.Rows(0).Item("TotalAmount"), "#,##0.00")
            idFL_Show = vDt.Rows(0).Item("idFl")
            Me.btnFindPdT.Visible = False
            Me.dtpDatePacking.Enabled = False
            Me.dtpCombine.Enabled = False
            Me.rdbA.Enabled = False
            Me.rdbB.Enabled = False
            Me.dtpTest.Enabled = False
            Me.dtpExp.Enabled = False
            Me.btnPsCommand.Visible = False
            Me.btnPsPacking.Visible = False
            Me.txtNote.Enabled = False
            Me.btn_save.Visible = False
            Me.rdbSelect.Visible = False
            Me.rdbAutoSelect.Visible = False
            Me.btnLot.Visible = False

            If stPage = 3 Then 'Cancel
                Me.btnDelete.Visible = True
            End If

            '*****Show data on DGV_formula******'
            Dim FlDt As New DataTable
            FlDt.Clear()
            sCommand.CommandText = "Select idFL, FlName, Note From SlPdFormula " & _
                                   "WHERE idPdT = " & Me.lblPdTName.Tag & " Order By FlName"
            sAdapter.Fill(FlDt)

            Me.DGV_formula.DataSource = FlDt
            Me.lblMsg.Visible = False

            For i As Integer = 0 To Me.DGV_formula.Rows.Count - 1
                If DGV_formula.Rows(i).Cells("colidFL").Value = idFL_Show Then
                    DGV_formula.Rows(i).Cells(ColSelectFl.Name).Value = True
                    DGV_formula.CurrentCell = DGV_formula.Item("colFlName", i)
                End If
            Next
            DGV_formula.Enabled = False

            '*****Show data on dgvPkPdSet******'
            Dim idPkUnitCheck As Integer = 0 'Check หน่วย Pk ที่เลือก
            Dim PklistDt As New DataTable
            PklistDt.Clear()

            sCommand.CommandText = "Select dPD.idPkDetail, dPD.SizeName, vPP.Weight, u.UnitW, vPP.idUnitW, 0 As Amount, " & _
                                   "'0' as AmtTs, dPD.idPkUnit,vPP.idPdPk, vPP.PdPkName From dPackingDetail dPD " & _
                                   "INNER JOIN vPackingPdSet vPP ON vPP.idPkDetail = dPD.idPkDetail " & _
                                   "INNER JOIN dUnitW u ON vPP.idUnitW = u.idUnitW " & _
                                   "WHERE dPD.idPkUnit <> 7 AND vPP.idPdT = " & Me.lblPdTName.Tag & " ORDER BY " & _
                                   "u.UnitW, vPP.Weight DESC"
            sAdapter.Fill(PklistDt)

            Me.lblNoPakage.Visible = False
            Me.dgvPkPdSet.DataSource = PklistDt

            Dim idPdPkBox As Integer = 0
            Dim PackingDt As New DataTable
            PackingDt.Clear()
            sCommand.CommandText = "Select idPdPk, AmtDemand, AmtSuccess From PkPackingDt Where idPacking = '" & idPacking_sent & "'"
            sAdapter.Fill(PackingDt)

            For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
                For n As Integer = 0 To PackingDt.Rows.Count - 1
                    If dgvPkPdSet.Rows(i).Cells("idPdPk").Value = PackingDt.Rows(n).Item("idPdPk") Then
                        idPdPkBox = PackingDt.Rows(n).Item("idPdPk")

                        dgvPkPdSet.Rows(i).Cells("colSelect").Value = True
                        Me.dgvPkPdSet.Rows(i).Cells(key.Name).Value = 1
                        Me.dgvPkPdSet.CurrentCell = Me.dgvPkPdSet.Item("colSizeName", i)
                        ' Dim test As Double = PackingDt.Rows(n).Item("AmtDemand")

                        dgvPkPdSet.Rows(i).Cells("colAmtTs").Value = PackingDt.Rows(n).Item("AmtDemand")
                        dgvPkPdSet.Rows(i).Cells("ColAmtPk").Value = PackingDt.Rows(n).Item("AmtSuccess")
                        dgvPkPdSet.Rows(i).DefaultCellStyle.ForeColor = Color.DodgerBlue
                        idPkUnitCheck = dgvPkPdSet.Rows(i).Cells("idPkUnit").Value
                    End If
                Next
            Next

            dgvPkPdSet.Columns("ColAmtPk").HeaderText = "จน.ที่เบิกใช้ (ชิ้น)"
            dgvPkPdSet.Columns("colSelect").ReadOnly = True

            dgvPkPdSet.Enabled = False
            dgvPkPdSet.Columns("colAmtTs").Visible = False
            dgvPkPdSet.Columns("colSelect").Visible = True
            dgvPkPdSet.Columns("ColAmtPk").ReadOnly = True


            '*****Show data on DGV_Label******'
            Dim LabelDt As New DataTable
            LabelDt.Clear()
            sCommand.CommandText = "SELECT dt.idLabel, lb.LabelNameUse, CONVERT(varchar, lb.SizeW) + ' x ' + " & _
                                   "CONVERT(varchar, lb.SizeH) + ' ' + lb.Unit As WH, dt.AmtSuccess As Amount " & _
                                   "FROM dPackingLabel lb INNER JOIN PkPackingDt dt " & _
                                   "ON lb.idLabel = dt.idLabel WHERE dt.idPacking = '" & idPacking_sent & "'  "
            sAdapter.Fill(LabelDt)
            Me.DGV_Label.DataSource = LabelDt
            Me.rdbOnlyPk.Visible = False
            Me.rdbAllPk.Visible = False
            Me.DGV_Label.Columns("ColSelectLb").Visible = False
            Me.DGV_Label.Columns("ColAmtLb").HeaderText = "จน.ที่เบิกใช้ (ชิ้น)"
            Me.DGV_Label.Enabled = False

            '*****Show data on dgvPkOpen******'
            Dim PkOpenDt As New DataTable
            PkOpenDt.Clear()
            sCommand.CommandText = "SELECT dt.idLid As idPkDetail2,  PKD.SizeName, dt.AmtSuccess As Amount " & _
                                   "FROM dPackingDetail PKD INNER JOIN PkPackingDt dt " & _
                                   "ON PKD.idPkDetail = dt.idLid WHERE dt.idPacking = '" & idPacking_sent & "'  "
            sAdapter.Fill(PkOpenDt)
            Me.dgvPkOpen.DataSource = PkOpenDt
            Me.dgvPkOpen.Columns("ColSelectPkOp").Visible = False
            Me.dgvPkOpen.Columns("ColAmtPkOp").HeaderText = "จน.ที่เบิกใช้ (ชิ้น)"
            Me.dgvPkOpen.Enabled = False


            '*****Show data on DGV_Ingredient******'
            Dim NameCode As String = ""
            Dim aDt As New DataTable
            aDt.Clear()
            sCommand.CommandText = "Select Sl.idPd, p.PdCode + ' : ' + p.PdName As PdCodeName, Sl.MixPerc, '0' As WUse " & _
                                   "From SlPdIngredient Sl INNER JOIN vSeedProduct p ON Sl.idPd = p.idPd  " & _
                                   "Where Sl.idPdT =" & Me.lblPdTName.Tag & " " & _
                                   "And Sl.idFl =" & idFL_Show & " "
            sAdapter.Fill(aDt)
            Me.DGV_Ingredient.DataSource = aDt
            SumWOfLot()
            Me.DGV_Ingredient.Columns("ColStock").Visible = False
            Me.DGV_Ingredient.Columns("ColSelectLot").Visible = False
            Me.DGV_Ingredient.Columns("ColSumWUse").Visible = False
            DGV_Ingredient.CurrentCell = DGV_Ingredient.Item("ingredient", 0)
            CalWeight()

            '*****Show data on DGV_Lot******'
            Dim lotShowDt As New DataTable
            lotShowDt.Clear()
            sCommand.CommandText = "Select l.idPdMixLot, p.LotNum, p.LotCodeRef, s.PdName, l.Amount, p.idPd " & _
                                   "From PkPackingLotDt l LEFT OUTER JOIN PkPdLotStock p ON l.idPdMixLot = p.idPdLot " & _
                                   "LEFT OUTER JOIN vSeedProduct s ON p.idPd = s.idPd Where l.idPacking = '" & idPacking_sent & "'"
            sAdapter.Fill(lotShowDt)
            Me.DGV_Lot.DataSource = lotShowDt
            Me.DGV_Lot.Columns("ColLotAmount").Visible = False
            Me.DGV_Lot.Columns("ColDel").Visible = False
            For i As Integer = 0 To Me.DGV_Lot.Rows.Count - 1
                Me.DGV_Lot.Rows(i).Cells("ColuRealUse").Value = Me.DGV_Lot.Rows(i).Cells("ColLotAmount").Value
            Next
            ksbCountRowDgv(DGV_Lot, ColNum.Name)
            Me.DGV_Lot.ReadOnly = True
            SumWOfLot()

            '*****Show data on dgvResult******'
            Dim ResultDt As New DataTable
            ResultDt.Clear()
            sCommand.CommandText = "Select dt.idPdPk, v.PdPkName, dt.AmtDemand, dt.AmtSuccess, v.PkUnitName, " & _
                                   "dt.idPkDetail, idLabel, idLid " & _
                                   "FROM PkPackingDt dt LEFT OUTER JOIN vPackingPdSet v ON dt.idPdPk = v.idPdPk " & _
                                   "WHERE idPacking = '" & idPacking_sent & "'"
            sAdapter.Fill(ResultDt)
            Me.dgvResult.DataSource = ResultDt
            dgvResult.CurrentCell = dgvResult.Item("ColAmt", 0)
            dgvResult.Rows(0).Height = 40

            'Me.Label16.Visible = False
            'Me.Label17.Visible = False
            'Me.Label18.Visible = False
            'Me.Label21.Visible = False

            '*****Show data on Perbox******'
            Dim PerboxDt As New DataTable
            PerboxDt.Clear()
            sCommand.CommandText = "SELECT Perbox FROM vPackingPdSet WHERE idPdPk = " & idPdPkBox & ""
            sAdapter.Fill(PerboxDt)

            If IsDBNull(PerboxDt.Rows(0).Item("Perbox")) Then
                Me.lblPerbox.Text = 0
            Else
                Me.lblPerbox.Text = PerboxDt.Rows(0).Item("Perbox")
            End If

            '***** Show data on DGV_Box ******'
            Dim BoxShowDt As New DataTable
            BoxShowDt.Clear()
            sCommand.CommandText = "SELECT d.idPkDetail, 'กล่อง ' + d.SizeName + ' (' + CONVERT(varchar, d.Width) + " & _
                                   "' x ' + CONVERT(varchar, d.Length) + ' x ' + CONVERT(varchar, d.Height) + ')' " & _
                                   "As SizeName , 0 As Amount, dt.AmtBox As AmtTs FROM PkPackingDt dt LEFT OUTER JOIN " & _
                                   "dPackingDetail d ON dt.idBox = d.idPkDetail WHERE dt.idPacking = '" & idPacking_sent & "'"
            sAdapter.Fill(BoxShowDt)

            Me.DGV_Box.DataSource = BoxShowDt
            Me.DGV_Box.Columns("ColSelectBox").Visible = False
            Me.DGV_Box.Columns("ColStockBox").Visible = False
            Me.DGV_Box.Columns("ColAmtBox").HeaderText = "จน.ที่เบิกใช้ (ชิ้น)"
            Me.DGV_Box.Enabled = False

            '***** Show data AmtBox ******'
            Dim AmtBoxLbDt As New DataTable
            AmtBoxLbDt.Clear()
            sCommand.CommandText = "SELECT AmtBoxLabel FROM PkPackingDt WHERE idPacking = '" & idPacking_sent & "'"
            sAdapter.Fill(AmtBoxLbDt)
            Me.lblBoxLabel.Text = Me.DGV_Label.Rows(0).Cells("ColLabelName").Value & " (" & Me.DGV_Label.Rows(0).Cells("ColWH").Value & ") "
            Me.lblBoxLabel.Tag = Me.DGV_Label.Rows(0).Cells("ColidLabel").Value
            If Not IsDBNull(AmtBoxLbDt.Rows(0).Item("AmtBoxLabel")) Then
                Me.txtAmtBoxLbl.Text = Format(AmtBoxLbDt.Rows(0).Item("AmtBoxLabel"), "#,##0")
            End If
            Me.txtAmtBoxLbl.Enabled = False


            '---Show เบิกใช้หน่วยเพิ่มเติม---'
            Dim PkAndLbDt As New DataTable
            PkAndLbDt.Clear()
            sCommand.CommandText = "Select AmtPkIncrease, AmtLbIncrease, AmtLidIncrease, AmtBoxIncrease, " & _
                                   "NoteIncrease FROM PkPackingDt WHERE idPacking = '" & idPacking_sent & "'"
            sAdapter.Fill(PkAndLbDt)

            If IsDBNull(PkAndLbDt.Rows(0).Item("AmtPkIncrease")) Then
                Me.txtAddPk.Text = "0"
            Else
                Me.txtAddPk.Text = Format(PkAndLbDt.Rows(0).Item("AmtPkIncrease"), "#,##0")
            End If

            If IsDBNull(PkAndLbDt.Rows(0).Item("AmtLbIncrease")) Then
                Me.txtAddlabel.Text = "0"
            Else
                Me.txtAddlabel.Text = Format(PkAndLbDt.Rows(0).Item("AmtLbIncrease"), "#,##0")
            End If

            If IsDBNull(PkAndLbDt.Rows(0).Item("AmtLidIncrease")) Then
                Me.txtAddPkOp.Text = "0"
            Else
                Me.txtAddPkOp.Text = Format(PkAndLbDt.Rows(0).Item("AmtLidIncrease"), "#,##0")
            End If

            If IsDBNull(PkAndLbDt.Rows(0).Item("AmtBoxIncrease")) Then
                Me.txtAddBox.Text = "0"
            Else
                Me.txtAddBox.Text = Format(PkAndLbDt.Rows(0).Item("AmtBoxIncrease"), "#,##0")
            End If

            If IsDBNull(PkAndLbDt.Rows(0).Item("NoteIncrease")) Then
                Me.txtNoteAdd.Text = ""
            Else
                Me.txtNoteAdd.Text = PkAndLbDt.Rows(0).Item("NoteIncrease")
            End If

            Me.GroupBox2.Visible = True
            If stPage = 4 Then 'eConfirm
                Me.txtAddPk.Enabled = True
                Me.txtAddlabel.Enabled = True
                Me.txtAddBox.Enabled = True
                Me.btnConfirm.Visible = True
                Me.txtNoteAdd.Enabled = True
                Me.txtNoteAdd.Focus()
                If idPkUnitCheck = 1 Then
                    Me.txtAddPkOp.Enabled = True
                End If
            End If

            mdLoadCommitt()
        End If 'End stPage
    End Sub


    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub CalPackage()
        Me.dgvResult.Rows.Clear()
        PkgDt.Clear()
        LotUseDt.Clear()
        Me.txtAmtBoxLbl.Text = "0"
        For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
            Me.DGV_Box.Rows(i).Cells("ColAmtBox").Value = 0
        Next

        Dim b As Integer = 0
        Dim j As Integer = 0
        'For i As Integer = 0 To DGV_Lot.Rows.Count - 1
        '    Me.DGV_Lot.Rows(i).Cells("ColuRealUse").Value = 0
        'Next

        'If Me.DGV_Lot.Rows.Count = 0 Then
        '    mdLoadCommitt()
        '    MessageBox.Show("กรูณาเลือก Lot สินค้าวัตถุดิบที่เบิกใช้ก่อน ระบบจึงจะสามารถคำนวณจำนวนสินค้าสำเร็จรูปได้", sSystemName)
        '    Exit Sub
        'End If

        For i As Integer = 0 To Me.DGV_Lot.Rows.Count - 1
            Me.DGV_Lot.Rows(i).Cells("ColSt").Value = 0     
        Next

        Dim stCheckFl As Integer = 0
        '--Check Fomula Select---'
        For i As Integer = 0 To Me.DGV_formula.Rows.Count - 1
            If Me.DGV_formula.Rows(i).Cells(ColSelectFl.Name).Value = True Then
                stCheckFl = 1
            End If
        Next

        If stCheckFl = 0 Then
            Me.dgvResult.Rows.Clear()

            Me.txtAmtBoxLbl.Text = "0"
            For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
                Me.DGV_Box.Rows(i).Cells("ColAmtBox").Value = 0
            Next
            Exit Sub
        End If


        Dim stCheckPk As Integer = 0
        '---Check Select Checkbox----'
        For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
            If Me.dgvPkPdSet.Rows(i).Cells(colSelect.Name).Value = True Then
                stCheckPk = 1
            End If
        Next

        If stCheckPk = 0 Then 'No Checkbox is check
            Exit Sub
        Else 'Check
            If Me.DGV_formula.Rows.Count = 0 Then
                mdLoadCommitt()
                MessageBox.Show("ไม่พบข้อมูลสูตรสินค้าของสินค้าสำเร็จรูปนี้ ระบบจึงไม่สามารถคำนวณ Package สินค้าได้", sSystemName)
                Exit Sub
            End If

            If Me.DGV_Lot.Rows.Count = 0 Then
                mdLoadCommitt()
                MessageBox.Show("กรูณาเลือก Lot สินค้าวัตถุดิบที่เบิกใช้ก่อน ระบบจึงจะสามารถคำนวณจำนวนสินค้าสำเร็จรูปได้", sSystemName)
                Exit Sub
            End If
        End If

        Dim stPk As Integer = 0 '0=Pk พอทั้งหมด, 1=Pk เป็น 0 หรือ Nill ไม่สามารถผลิตได้, 2=Pk ไม่พอ ผลิตได้บางส่วน
        Dim stLb As Integer = 0 '0=Lb พอทั้งหมด, 1=Lb เป็น 0 หรือ Nill ไม่สามารถผลิตได้, 2=Lb ไม่พอ ผลิตได้บางส่วน
        Dim stPkOp As Integer = 0 '0=PkOp พอทั้งหมด, 1=PkOp เป็น 0 หรือ Nill ไม่สามารถผลิตได้, 2=PkOp ไม่พอ ผลิตได้บางส่วน
        Dim stStock As Integer = 0 '0=ทุกตัวพอ, 1=มีอย่างน้อย 1 ตัว เป็น 0 ไม่สามารถผลิตได้, 2=มีอย่างน้อย 1 ตัวไม่พอ ผลิตได้บางส่วน
        Dim stBox As Integer = 0 '0=ทุกตัวพอ, 1=มีอย่างน้อย 1 ตัว เป็น 0 ไม่สามารถผลิตได้, 2=มีอย่างน้อย 1 ตัวไม่พอ ผลิตได้บางส่วน

        '---CheckPackage---'
        Dim AmtPk As Integer = 0
        Dim AmtDmd As Integer = 0 'จำนวนสินค้าที่ต้องการ
        For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
            If Me.dgvPkPdSet.Rows(i).Cells(colSelect.Name).Value = True Then
                AmtDmd = Me.dgvPkPdSet.Rows(i).Cells("colAmtTs").Value
                If IsDBNull(Me.dgvPkPdSet.Rows(i).Cells("ColAmtPk").Value) Then
                    AmtPk = 0
                    stPk = 1 'ไม่มี Pk ไม่สามารถผลิตได้
                ElseIf Me.dgvPkPdSet.Rows(i).Cells("ColAmtPk").Value = Nothing Then
                    AmtPk = 0
                    stPk = 1 'ไม่มี Pk ไม่สามารถผลิตได้
                ElseIf Me.dgvPkPdSet.Rows(i).Cells("ColAmtPk").Value = 0 Then
                    AmtPk = 0
                    stPk = 1 'ไม่มี Pk ไม่สามารถผลิตได้
                Else
                    AmtPk = Me.dgvPkPdSet.Rows(i).Cells("ColAmtPk").Value
                    If AmtDmd < AmtPk Then
                        stPk = 0 'Pk พอทั้งหมด
                    Else
                        stPk = 2 'Pk ไม่พอ ผลิตได้บางส่วน
                    End If
                End If
            End If
        Next


        '---CheckLabel---'
        Dim AmtLb As Integer = 0
        For i As Integer = 0 To Me.DGV_Label.Rows.Count - 1
            If Me.DGV_Label.Rows(i).Cells(ColSelectLb.Name).Value = True Then
                If IsDBNull(Me.DGV_Label.Rows(i).Cells("ColAmtLb").Value) Then
                    AmtLb = 0
                    stLb = 1 'ไม่มี Lb ไม่สามารถผลิตได้
                ElseIf Me.DGV_Label.Rows(i).Cells("ColAmtLb").Value = Nothing Then
                    AmtLb = 0
                    stLb = 1 'ไม่มี Lb ไม่สามารถผลิตได้
                ElseIf Me.DGV_Label.Rows(i).Cells("ColAmtLb").Value = 0 Then
                    AmtLb = 0
                    stLb = 1 'ไม่มี Lb ไม่สามารถผลิตได้
                Else
                    AmtLb = Me.DGV_Label.Rows(i).Cells("ColAmtLb").Value
                    If AmtDmd < AmtLb Then
                        stLb = 0 'Lb พอทั้งหมด
                    Else
                        stLb = 2 'Lb ไม่พอ ผลิตได้บางส่วน
                    End If
                End If
            End If
        Next

        Dim idLabelUse As Integer = 0
        For i As Integer = 0 To Me.DGV_Label.Rows.Count - 1
            If Me.DGV_Label.Rows(i).Cells(ColSelectLb.Name).Value = True Then
                idLabelUse = Me.DGV_Label.Rows(i).Cells("ColidLabel").Value
            End If
        Next

        '---CheckPkOpen--'
        Dim AmtPOpen As Integer = 0
        Dim idPkDetailOp As Integer = 0
        If UsePkOpen = 1 Then
            For i As Integer = 0 To Me.dgvPkOpen.Rows.Count - 1
                If Me.dgvPkOpen.Rows(i).Cells(ColSelectPkOp.Name).Value = True Then
                    If IsDBNull(Me.dgvPkOpen.Rows(i).Cells("ColAmtPkOp").Value) Then
                        AmtPOpen = 0
                        stPkOp = 1 'ไม่มี PkOp ไม่สามารถผลิตได้
                    ElseIf Me.dgvPkOpen.Rows(i).Cells("ColAmtPkOp").Value = Nothing Then
                        AmtPOpen = 0
                        stPkOp = 1 'ไม่มี PkOp ไม่สามารถผลิตได้
                    ElseIf Me.dgvPkOpen.Rows(i).Cells("ColAmtPkOp").Value = 0 Then
                        AmtPOpen = 0
                        stPkOp = 1 'ไม่มี PkOp ไม่สามารถผลิตได้
                    Else
                        AmtPOpen = Me.dgvPkOpen.Rows(i).Cells("ColAmtPkOp").Value
                        If AmtDmd < AmtPOpen Then
                            stPkOp = 0 'Lb พอทั้งหมด
                        Else
                            stPkOp = 2 'PkOp ไม่พอ ผลิตได้บางส่วน
                        End If
                    End If

                    idPkDetailOp = Me.dgvPkOpen.Rows(i).Cells("ColidPkDetailOp").Value
                End If
            Next

            'Dim idPkDetailOp As Integer = 0
            'For i As Integer = 0 To Me.dgvPkOpen.Rows.Count - 1
            '    If Me.dgvPkOpen.Rows(i).Cells(ColSelectLb.Name).Value = True Then
            '        idLabelUse = Me.DGV_Label.Rows(i).Cells("ColidLabel").Value
            '    End If
            'Next
        End If


        For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
            '----Package Select---'
            If Me.dgvPkPdSet.Rows(i).Cells(colSelect.Name).Value = True Then
                '--- Insert Selected into PkgDt(Datatable)---'
                PkgDt.Rows.Add()
                PkgDt.Rows(j).Item("idPdPk") = Me.dgvPkPdSet.Rows(i).Cells("idPdPk").Value
                PkgDt.Rows(j).Item("idPkDetail") = Me.dgvPkPdSet.Rows(i).Cells("ColidPkDetail").Value
                PkgDt.Rows(j).Item("idPkUnit") = Me.dgvPkPdSet.Rows(i).Cells("idPkUnit").Value
                PkgDt.Rows(j).Item("PkName") = Me.dgvPkPdSet.Rows(i).Cells("ColPdPkName").Value
                PkgDt.Rows(j).Item("Weight") = Me.dgvPkPdSet.Rows(i).Cells("colWeight").Value
                PkgDt.Rows(j).Item("UnitW") = Me.dgvPkPdSet.Rows(i).Cells("colUnitW").Value
                PkgDt.Rows(j).Item("idUnitW") = Me.dgvPkPdSet.Rows(i).Cells("ColidUnitW").Value
                PkgDt.Rows(j).Item("AmtTs") = Me.dgvPkPdSet.Rows(i).Cells("colAmtTs").Value
                PkgDt.Rows(j).Item("TotalW") = Me.dgvPkPdSet.Rows(i).Cells("ColTotalW").Value
                PkgDt.Rows(j).Item("status") = 0
                PkgDt.Rows(j).Item("PackageAmt") = 0
                PkgDt.Rows(j).Item("idLabel") = idLabelUse
                PkgDt.Rows(j).Item("idPkDtOpen") = idPkDetailOp
                j = j + 1
            End If
        Next

        If PkgDt.Rows.Count = 0 Then
            'mdLoadCommitt()
            'MessageBox.Show("กรุณาเลือกหน่วยบรรจุย่อยที่ต้องการคำนวณอย่างน้อย 1 รายการ", sSystemName)
            Exit Sub
        End If

        '------ดึง LotStock ของ ส่วนผสมมาเก็บใน LotStTemp------'
        'Dim lotDt As New DataTable
        Dim s As Integer = 0
        Dim LotStTemp As New DataTable
        LotStTemp.Columns.Add("idPd", System.Type.GetType("System.String"))
        LotStTemp.Columns.Add("idPdLot", System.Type.GetType("System.String"))
        LotStTemp.Columns.Add("Amount", System.Type.GetType("System.Double"))

        For m As Integer = 0 To DGV_Lot.Rows.Count - 1
            LotStTemp.Rows.Add()
            LotStTemp.Rows(s).Item("idPd") = Me.DGV_Lot.Rows(m).Cells("ColidPdUse").Value
            LotStTemp.Rows(s).Item("idPdLot") = Me.DGV_Lot.Rows(m).Cells("ColidPdLot").Value
            LotStTemp.Rows(s).Item("Amount") = Me.DGV_Lot.Rows(m).Cells("ColuRealUse").Value
            s = s + 1
        Next
        'Next

        '----------- Select LotStock by idPd in Ingredient -----------'
        'mdCnOpen()
        For m As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1 'loop สัดส่วนของส่วนผสม
            ' MessageBox.Show(DGV_Ingredient.Rows(m).Cells("ColAmgKg").Value & "/" & DGV_Ingredient.Rows(m).Cells("ColSumWUse").Value)

            If DGV_Ingredient.Rows(m).Cells("ColWUse").Value = 0 Then
                stStock = 1 'มีอย่างน้อย 1 ตัว เป็น 0 ไม่สามารถผลิตได้
            ElseIf CDbl(DGV_Ingredient.Rows(m).Cells("ColAmgKg").Value) > CDbl(DGV_Ingredient.Rows(m).Cells("ColWUse").Value) Then
                stStock = 2 'ส่วนผสมอย่างน้อย 1 ตัวไม่พอทั้งหมด --> ผลิตได้บางส่วน
            End If
        Next


        If stStock = 1 Or stPk = 1 Or stLb = 1 Then 'มีอย่างน้อย 1 ตัว เป็น 0 ไม่สามารถผลิตได้ : Exit Func
            If UsePkOpen = 1 Then
                If stPkOp = 1 Then
                    Me.txtAmtTotal.Text = "0"
                    'mdLoadCommitt()
                    'MessageBox.Show("มีสินค้าวัตถุดิบบางตัวที่ยังไม่ได้เลือก Lot ที่ต้องการเบิกใช้ ระบบจึงยังไม่สามารถคำนวณ Package ได้", sSystemName)
                    Me.lblMagLot.Visible = True
                    Exit Sub
                End If
            Else
                Me.txtAmtTotal.Text = "0"
                'mdLoadCommitt()
                'MessageBox.Show("มีสินค้าวัตถุดิบบางตัวที่ยังไม่ได้เลือก Lot ที่ต้องการเบิกใช้ ระบบจึงยังไม่สามารถคำนวณ Package ได้", sSystemName)
                Me.lblMagLot.Visible = True
                Exit Sub
            End If
        ElseIf stStock = 0 And stPk = 0 And stLb = 0 Then 'วัตถุดิบทุกตัวพอ + Pk พอ + Label พอ + ฝาพอ
            Dim stCalAll As Integer = 0 'Check ผลิตได้/ไม่ได้
            If UsePkOpen = 1 Then
                If stPkOp = 0 Then 'PkOp ผลิตได้ทั้งหมด
                    stCalAll = 1
                ElseIf stPkOp = 2 Then 'PkOp ผลิตได้บางส่วน
                    stCalAll = 2
                End If
            Else
                stCalAll = 1
            End If

            If stCalAll = 1 Then
                Me.lblMagLot.Visible = False
                'คำนวณจำนวนชิ้นที่ได้
                For i As Integer = 0 To Me.PkgDt.Rows.Count - 1 'loop Package
                    If PkgDt.Rows(i).Item("status") = 0 And AmountPkTs_kg > 0 Then
                        If PkgDt.Rows(i).Item("PackageAmt") <> PkgDt.Rows(i).Item("AmtTs") Then
                            'จำนวนชิ้น Package ที่ได้
                            PkgDt.Rows(i).Item("PackageAmt") = Math.Floor(PkgDt.Rows(i).Item("TotalW") / PkgDt.Rows(i).Item("Weight"))
                            PkgDt.Rows(i).Item("status") = 1
                        End If
                    End If

                    ''Show data to table
                    'If PkgDt.Rows(i).Item("idPkUnit") = 1 Then
                    '    dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระป่อง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"))
                    'ElseIf PkgDt.Rows(i).Item("idPkUnit") = 2 Then
                    '    dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ซอง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"))
                    'ElseIf PkgDt.Rows(i).Item("idPkUnit") = 4 Then
                    '    dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระสอบ", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"))
                    'ElseIf PkgDt.Rows(i).Item("idPkUnit") = 5 Then
                    '    dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กิโลกรัม", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"))
                    'ElseIf PkgDt.Rows(i).Item("idPkUnit") = 6 Then
                    '    dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ถุง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"))
                    'End If

                    If PkgDt.Rows(i).Item("idPkUnit") = 1 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระป่อง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 2 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ซอง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 4 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระสอบ", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 5 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กก.", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 6 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ถุง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    End If
                Next

                'Dim b As Integer = 0
                'LotUseDt.Clear()
                'ตัด Stock ที่ใช้ไป ตาม idPd

                For i As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1 'loop สัดส่วนของส่วนผสม
                    Dim AmtDemand As Double = Me.DGV_Ingredient.Rows(i).Cells("ColAmgKg").Value

                    For k As Integer = 0 To LotStTemp.Rows.Count - 1 'loop StockTemp
                        If LotStTemp.Rows(k).Item("idPd") = Me.DGV_Ingredient.Rows(i).Cells("colidPd").Value Then
                            If AmtDemand > 0 And LotStTemp.Rows(k).Item("Amount") > 0 Then
                                If LotStTemp.Rows(k).Item("Amount") >= AmtDemand Then
                                    LotStTemp.Rows(k).Item("Amount") = LotStTemp.Rows(k).Item("Amount") - AmtDemand

                                    '--- insert lot use to datattable---'
                                    LotUseDt.Rows.Add()
                                    LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(k).Item("idPdLot")
                                    LotUseDt.Rows(b).Item("Amount") = AmtDemand
                                    b = b + 1
                                    AmtDemand = 0

                                    Exit For 'Next ส่วนผสม
                                Else 'Lot ไม่พอ use Next Lot
                                    'Dim lotBalance As Double = 0
                                    AmtDemand = AmtDemand - LotStTemp.Rows(k).Item("Amount")

                                    '--- insert lot use to datattable---'
                                    LotUseDt.Rows.Add()
                                    LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(k).Item("idPdLot")
                                    LotUseDt.Rows(b).Item("Amount") = LotStTemp.Rows(k).Item("Amount")
                                    b = b + 1
                                    LotStTemp.Rows(k).Item("Amount") = 0
                                End If
                            Else
                                Exit For 'ไปตัด stock ส่วนผสมต่อไป
                            End If 'End Check Demand & LotStock
                        End If
                    Next
                Next

                For i As Integer = 0 To LotUseDt.Rows.Count - 1
                    For y As Integer = 0 To DGV_Lot.Rows.Count - 1
                        If LotUseDt.Rows(i).Item("idPdMixLot") = Me.DGV_Lot.Rows(y).Cells("ColidPdLot").Value Then
                            Me.DGV_Lot.Rows(y).Cells("ColuRealUse").Value = LotUseDt.Rows(i).Item("Amount")
                            Me.DGV_Lot.Rows(y).Cells("ColSt").Value = 1
                        End If
                    Next
                Next
                For i As Integer = 0 To Me.DGV_Lot.Rows.Count - 1
                    If Me.DGV_Lot.Rows(i).Cells("ColSt").Value = 0 Then
                        Me.DGV_Lot.Rows(i).Cells("ColuRealUse").Value = 0
                    End If
                Next
                SumWOfLot()
            ElseIf stCalAll = 2 Then 'ฝาไม่พอ ผลิตได้บางส่วน
                Me.lblMagLot.Visible = False

                For i As Integer = 0 To Me.PkgDt.Rows.Count - 1 'loop Package Select
                    Dim AmtComplete As Integer = 0 'จำนวนชิ้นที่ได้
                    Dim stPackage As Integer = 0 'สถานะ Pk : 0=ผลิตได้, 1=ผลิตไม่ได้

                    While stPackage = 0 And AmtComplete < PkgDt.Rows(i).Item("AmtTs")
                        'Check status ส่วนผสม
                        For k As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1 'loop ingredient
                            '---คำนวณสัดส่วนน้ำหนัก/ชิ้น/1 Package ---'
                            Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value = PkgDt.Rows(i).Item("Weight") * (Me.DGV_Ingredient.Rows(k).Cells("ingredient").Value / 100)
                            If PkgDt.Rows(i).Item("idUnitW") = 1 Then 'กรัม
                                Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value = Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value / 1000
                            End If

                            '---SUM LotStock แยกตาม idPd ---'
                            Dim SumOfidPd As Double = 0
                            For m As Integer = 0 To LotStTemp.Rows.Count - 1 'loop StockTemp
                                If LotStTemp.Rows(m).Item("idPd") = Me.DGV_Ingredient.Rows(k).Cells("colidPd").Value Then
                                    SumOfidPd = SumOfidPd + LotStTemp.Rows(m).Item("Amount")
                                End If
                            Next

                            If Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value > SumOfidPd Then
                                stPackage = 1 'มีอย่างน้อย 1 ส่วนผสมไม่พอ:=ชิ้นปัจจุบันทำไม่ได้
                            End If
                        Next


                        'ตัด stock + เพิ่มจำนวนที่ผลิตได้
                        If stPackage = 0 Then
                            For k As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1 'loop ingredient
                                Dim AmtDemand As Double = Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value

                                For m As Integer = 0 To LotStTemp.Rows.Count - 1 'loop StockTemp
                                    If LotStTemp.Rows(m).Item("idPd") = Me.DGV_Ingredient.Rows(k).Cells("colidPd").Value Then
                                        If AmtDemand > 0 And LotStTemp.Rows(m).Item("Amount") > 0 Then
                                            If Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value <= LotStTemp.Rows(m).Item("Amount") Then
                                                LotStTemp.Rows(m).Item("Amount") = LotStTemp.Rows(m).Item("Amount") - AmtDemand


                                                '--- insert lot use to datatable---'
                                                Dim stLot As Integer = 0
                                                If LotUseDt.Rows.Count = 0 Then 'ยังไม่มีข้อมูล LotUse
                                                    LotUseDt.Rows.Add()
                                                    LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                    LotUseDt.Rows(b).Item("Amount") = AmtDemand
                                                    b = b + 1
                                                Else 'มีข้อมูล LotUse แล้ว
                                                    '----------Lot เดียวกัน------------'
                                                    For y As Integer = 0 To LotUseDt.Rows.Count - 1
                                                        If LotUseDt.Rows(y).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot") Then
                                                            LotUseDt.Rows(y).Item("Amount") = LotUseDt.Rows(y).Item("Amount") + AmtDemand
                                                            stLot = 1 'Lot เดียวกัน update แล้ว
                                                        End If
                                                    Next

                                                    '----------Lot อื่น------------'
                                                    If stLot <> 1 Then 'ยังไม่ได้ update
                                                        LotUseDt.Rows.Add()
                                                        LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                        LotUseDt.Rows(b).Item("Amount") = AmtDemand
                                                        b = b + 1
                                                    End If
                                                End If

                                                AmtDemand = 0
                                                Exit For 'ไปตัด stock ส่วนผสมต่อไป
                                            Else 'จำนวนที่ต้องใช้ > LotStock
                                                'Dim lotBalance As Double = 0
                                                AmtDemand = AmtDemand - LotStTemp.Rows(m).Item("Amount")

                                                '--- insert lot use to datatable---'
                                                Dim stLot As Integer = 0
                                                If LotUseDt.Rows.Count = 0 Then 'ยังไม่มีข้อมูล LotUse
                                                    LotUseDt.Rows.Add()
                                                    LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                    LotUseDt.Rows(b).Item("Amount") = LotStTemp.Rows(m).Item("Amount")
                                                    b = b + 1
                                                Else 'มีข้อมูล LotUse แล้ว
                                                    '----------Lot เดียวกัน------------'
                                                    For y As Integer = 0 To LotUseDt.Rows.Count - 1
                                                        If LotUseDt.Rows(y).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot") Then
                                                            LotUseDt.Rows(y).Item("Amount") = LotUseDt.Rows(y).Item("Amount") + LotStTemp.Rows(m).Item("Amount")
                                                            stLot = 1 'Lot เดียวกัน update แล้ว
                                                        End If
                                                    Next

                                                    '----------Lot อื่น------------'
                                                    If stLot <> 1 Then 'ยังไม่ได้ update
                                                        LotUseDt.Rows.Add()
                                                        LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                        LotUseDt.Rows(b).Item("Amount") = LotStTemp.Rows(m).Item("Amount")
                                                        b = b + 1
                                                    End If
                                                End If
                                                LotStTemp.Rows(m).Item("Amount") = 0

                                            End If 'End Check พอ/ไม่พอ
                                        End If
                                    End If 'End Check ว่าส่วนผสมเดียวกัน

                                Next 'End loop StockTemp
                            Next

                            If UsePkOpen = 1 Then
                                If AmtPk > 0 And AmtLb > 0 And AmtPOpen > 0 Then
                                    AmtComplete = AmtComplete + 1
                                    AmtPk = AmtPk - 1
                                    AmtLb = AmtLb - 1
                                    AmtPOpen = AmtPOpen - 1
                                Else
                                    Exit While 'Pk / Lb ไม่พอ จบการทำงาน
                                End If
                            Else
                                If AmtPk > 0 And AmtLb > 0 Then
                                    AmtComplete = AmtComplete + 1
                                    AmtPk = AmtPk - 1
                                    AmtLb = AmtLb - 1
                                Else
                                    Exit While 'Pk / Lb ไม่พอ จบการทำงาน
                                End If
                            End If 'End usepkOp

                        End If
                    End While

                    PkgDt.Rows(i).Item("PackageAmt") = AmtComplete
                    PkgDt.Rows(i).Item("status") = 1

                    'Show data to table
                    If PkgDt.Rows(i).Item("idPkUnit") = 1 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระป่อง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 2 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ซอง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 4 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระสอบ", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 5 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กก.", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 6 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ถุง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    End If

                Next 'End package ---> Next Package Select

                For i As Integer = 0 To LotUseDt.Rows.Count - 1
                    For y As Integer = 0 To DGV_Lot.Rows.Count - 1
                        If LotUseDt.Rows(i).Item("idPdMixLot") = Me.DGV_Lot.Rows(y).Cells("ColidPdLot").Value Then
                            Me.DGV_Lot.Rows(y).Cells("ColuRealUse").Value = LotUseDt.Rows(i).Item("Amount")
                            Me.DGV_Lot.Rows(y).Cells("ColSt").Value = 1
                        End If
                    Next
                Next
                For i As Integer = 0 To Me.DGV_Lot.Rows.Count - 1
                    If Me.DGV_Lot.Rows(i).Cells("ColSt").Value = 0 Then
                        Me.DGV_Lot.Rows(i).Cells("ColuRealUse").Value = 0
                    End If
                Next
                SumWOfLot()

            End If

        ElseIf stStock = 2 Or stPk = 2 Or stLb = 2 Then 'มีอย่างน้อย 1 ตัว / Pk / Label ไม่พอ ผลิตได้บางส่วน
            Dim stCal As Integer = 0
            If UsePkOpen = 1 Then
                If stPkOp = 1 Then
                    Me.txtAmtTotal.Text = "0"
                    'mdLoadCommitt()
                    'MessageBox.Show("มีสินค้าวัตถุดิบบางตัวที่ยังไม่ได้เลือก Lot ที่ต้องการเบิกใช้ ระบบจึงยังไม่สามารถคำนวณ Package ได้", sSystemName)
                    Me.lblMagLot.Visible = True
                    Exit Sub
                Else '0/2
                    stCal = 1
                End If
            Else
                stCal = 1
            End If

            If stCal = 1 Then
                Me.lblMagLot.Visible = False

                For i As Integer = 0 To Me.PkgDt.Rows.Count - 1 'loop Package Select
                    Dim AmtComplete As Integer = 0 'จำนวนชิ้นที่ได้
                    Dim stPackage As Integer = 0 'สถานะ Pk : 0=ผลิตได้, 1=ผลิตไม่ได้

                    While stPackage = 0 And AmtComplete < PkgDt.Rows(i).Item("AmtTs")
                        'Check status ส่วนผสม
                        For k As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1 'loop ingredient
                            '---คำนวณสัดส่วนน้ำหนัก/ชิ้น/1 Package ---'
                            Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value = PkgDt.Rows(i).Item("Weight") * (Me.DGV_Ingredient.Rows(k).Cells("ingredient").Value / 100)
                            If PkgDt.Rows(i).Item("idUnitW") = 1 Then 'กรัม
                                Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value = Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value / 1000
                            End If

                            '---SUM LotStock แยกตาม idPd ---'
                            Dim SumOfidPd As Double = 0
                            For m As Integer = 0 To LotStTemp.Rows.Count - 1 'loop StockTemp
                                If LotStTemp.Rows(m).Item("idPd") = Me.DGV_Ingredient.Rows(k).Cells("colidPd").Value Then
                                    SumOfidPd = SumOfidPd + LotStTemp.Rows(m).Item("Amount")
                                End If
                            Next

                            If Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value > SumOfidPd Then
                                stPackage = 1 'มีอย่างน้อย 1 ส่วนผสมไม่พอ:=ชิ้นปัจจุบันทำไม่ได้
                            End If
                        Next


                        'ตัด stock + เพิ่มจำนวนที่ผลิตได้
                        If stPackage = 0 Then
                            For k As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1 'loop ingredient
                                Dim AmtDemand As Double = Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value

                                For m As Integer = 0 To LotStTemp.Rows.Count - 1 'loop StockTemp
                                    If LotStTemp.Rows(m).Item("idPd") = Me.DGV_Ingredient.Rows(k).Cells("colidPd").Value Then
                                        If AmtDemand > 0 And LotStTemp.Rows(m).Item("Amount") > 0 Then
                                            If Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value <= LotStTemp.Rows(m).Item("Amount") Then
                                                LotStTemp.Rows(m).Item("Amount") = LotStTemp.Rows(m).Item("Amount") - AmtDemand


                                                '--- insert lot use to datatable---'
                                                Dim stLot As Integer = 0
                                                If LotUseDt.Rows.Count = 0 Then 'ยังไม่มีข้อมูล LotUse
                                                    LotUseDt.Rows.Add()
                                                    LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                    LotUseDt.Rows(b).Item("Amount") = AmtDemand
                                                    b = b + 1
                                                Else 'มีข้อมูล LotUse แล้ว
                                                    '----------Lot เดียวกัน------------'
                                                    For y As Integer = 0 To LotUseDt.Rows.Count - 1
                                                        If LotUseDt.Rows(y).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot") Then
                                                            LotUseDt.Rows(y).Item("Amount") = LotUseDt.Rows(y).Item("Amount") + AmtDemand
                                                            stLot = 1 'Lot เดียวกัน update แล้ว
                                                        End If
                                                    Next

                                                    '----------Lot อื่น------------'
                                                    If stLot <> 1 Then 'ยังไม่ได้ update
                                                        LotUseDt.Rows.Add()
                                                        LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                        LotUseDt.Rows(b).Item("Amount") = AmtDemand
                                                        b = b + 1
                                                    End If
                                                End If

                                                AmtDemand = 0
                                                Exit For 'ไปตัด stock ส่วนผสมต่อไป
                                            Else 'จำนวนที่ต้องใช้ > LotStock
                                                'Dim lotBalance As Double = 0
                                                AmtDemand = AmtDemand - LotStTemp.Rows(m).Item("Amount")

                                                '--- insert lot use to datatable---'
                                                Dim stLot As Integer = 0
                                                If LotUseDt.Rows.Count = 0 Then 'ยังไม่มีข้อมูล LotUse
                                                    LotUseDt.Rows.Add()
                                                    LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                    LotUseDt.Rows(b).Item("Amount") = LotStTemp.Rows(m).Item("Amount")
                                                    b = b + 1
                                                Else 'มีข้อมูล LotUse แล้ว
                                                    '----------Lot เดียวกัน------------'
                                                    For y As Integer = 0 To LotUseDt.Rows.Count - 1
                                                        If LotUseDt.Rows(y).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot") Then
                                                            LotUseDt.Rows(y).Item("Amount") = LotUseDt.Rows(y).Item("Amount") + LotStTemp.Rows(m).Item("Amount")
                                                            stLot = 1 'Lot เดียวกัน update แล้ว
                                                        End If
                                                    Next

                                                    '----------Lot อื่น------------'
                                                    If stLot <> 1 Then 'ยังไม่ได้ update
                                                        LotUseDt.Rows.Add()
                                                        LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                        LotUseDt.Rows(b).Item("Amount") = LotStTemp.Rows(m).Item("Amount")
                                                        b = b + 1
                                                    End If
                                                End If
                                                LotStTemp.Rows(m).Item("Amount") = 0

                                            End If 'End Check พอ/ไม่พอ
                                        End If
                                    End If 'End Check ว่าส่วนผสมเดียวกัน

                                Next 'End loop StockTemp
                            Next

                            If UsePkOpen = 1 Then
                                If AmtPk > 0 And AmtLb > 0 And AmtPOpen > 0 Then
                                    AmtComplete = AmtComplete + 1
                                    AmtPk = AmtPk - 1
                                    AmtLb = AmtLb - 1
                                    AmtPOpen = AmtPOpen - 1
                                Else
                                    Exit While 'Pk / Lb ไม่พอ จบการทำงาน
                                End If
                            Else
                                If AmtPk > 0 And AmtLb > 0 Then
                                    AmtComplete = AmtComplete + 1
                                    AmtPk = AmtPk - 1
                                    AmtLb = AmtLb - 1
                                Else
                                    Exit While 'Pk / Lb ไม่พอ จบการทำงาน
                                End If
                            End If 'End usepkOp

                        End If
                    End While

                    PkgDt.Rows(i).Item("PackageAmt") = AmtComplete
                    PkgDt.Rows(i).Item("status") = 1

                    'Show data to table
                    If PkgDt.Rows(i).Item("idPkUnit") = 1 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระป่อง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 2 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ซอง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 4 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระสอบ", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 5 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กก.", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 6 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ถุง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    End If

                    'Me. dgvResult.CurrentCell.Value=
                Next 'End package ---> Next Package Select

                For i As Integer = 0 To LotUseDt.Rows.Count - 1
                    For y As Integer = 0 To DGV_Lot.Rows.Count - 1
                        If LotUseDt.Rows(i).Item("idPdMixLot") = Me.DGV_Lot.Rows(y).Cells("ColidPdLot").Value Then
                            Me.DGV_Lot.Rows(y).Cells("ColuRealUse").Value = LotUseDt.Rows(i).Item("Amount")
                            Me.DGV_Lot.Rows(y).Cells("ColSt").Value = 1
                        End If
                    Next
                Next

                For i As Integer = 0 To Me.DGV_Lot.Rows.Count - 1
                    If Me.DGV_Lot.Rows(i).Cells("ColSt").Value = 0 Then
                        Me.DGV_Lot.Rows(i).Cells("ColuRealUse").Value = 0
                    End If
                Next
                SumWOfLot()

            End If 'End stCal
        End If

        dgvResult.CurrentCell = dgvResult.Item("ColAmt", 0)
        dgvResult.Rows(0).Height = 40
        Dim AmtTotal As Integer = 0
        For i As Integer = 0 To Me.dgvResult.Rows.Count - 1
            AmtTotal = AmtTotal + Me.dgvResult.Rows(i).Cells("ColAmt").Value
        Next
        Me.txtAmtTotal.Text = Format(AmtTotal, "#,##0")

        '--------- Cal Amount Box & BoxLabel -----------'
        If CInt(Me.lblPerbox.Text) <> 0 Then
            Dim AmountBox As Integer = 0
            AmountBox = Me.dgvResult.Rows(0).Cells("ColAmt").Value / CInt(Me.lblPerbox.Text)
            Me.txtAmtBoxLbl.Text = Format(AmountBox, "#,##0")
            For n As Integer = 0 To DGV_Box.Rows.Count - 1
                If Me.DGV_Box.Rows(n).Cells("ColSelectBox").Value = True Then
                    Me.DGV_Box.Rows(n).Cells("ColAmtBox").Value = Format(AmountBox, "#,##0")
                End If
            Next

            Me.DGV_Box.Enabled = True
            Me.txtAmtBoxLbl.Enabled = True
        Else
            mdLoadCommitt()
            MessageBox.Show("ระบบไม่มีข้อมูล จำนวนต่อกล่อง ของสินค้านี้ จึงไม่สามารถคำนวณจำนวนกล่อง และฉลากติดกล่องที่ใช้ได้", sSystemName)
            Exit Sub
        End If


        mdLoadCommitt()
        If stStock = 2 Then
            MessageBox.Show("ผลิตสินค้าสำเร็จรูปได้บางส่วนของจำนวนที่ต้องการ " & vbCrLf & vbCrLf & "สามารถผลิตได้เพียง : " & Me.txtAmtTotal.Text & " ชิ้น", sSystemName)
        End If
    End Sub

    'Private Sub btnCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCal.Click
    '    'If Me.txtAmount.Text = "" Then
    '    '    MessageBox.Show("กรุณาระบุจำนวนที่ต้องการบรรจุเป็น Package ก่อนการคำนวณ", sSystemName)
    '    '    Exit Sub
    '    'End If

    '    ' mdPdMixStockUpdate(3, 41, 0.74, "เบิกสต๊อกวัตถุดิบ", 30)
    '    ' mdPdPkStockUpdate(2, 3, 20, "ขายสินค้า", 102)

    '    mdLoadShow()
    '    CalPackage()
    '    mdLoadCommitt()
    '    ' Me.txtAmount.Focus()
    'End Sub

    

    Private Sub CalPackageAuto()
        Me.lblMagLot.Visible = False

        Dim stCheckFl As Integer = 0
        '--Check Fomula Select---'
        For i As Integer = 0 To Me.DGV_formula.Rows.Count - 1
            If Me.DGV_formula.Rows(i).Cells(ColSelectFl.Name).Value = True Then
                stCheckFl = 1
            End If
        Next

        If stCheckFl = 0 Then
            mdLoadCommitt()
            MessageBox.Show("กรุณาเลือกสูตรของสินค้าก่อน ระบบจึงจะสามารถเลือก Lot อัตโนมัติได้", sSystemName)
            Me.dgvResult.Rows.Clear()
            Me.txtAmtBoxLbl.Text = "0"
            For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
                Me.DGV_Box.Rows(i).Cells("ColAmtBox").Value = 0
            Next

            Me.txtAmtBoxLbl.Text = "0"
            For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
                Me.DGV_Box.Rows(i).Cells("ColAmtBox").Value = 0
            Next
            Exit Sub
        End If


        Dim stCheckPk As Integer = 0
        '---Check Select Checkbox----'
        For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
            If Me.dgvPkPdSet.Rows(i).Cells(colSelect.Name).Value = True Then
                stCheckPk = 1
            End If
        Next

        If stCheckPk = 0 Then 'No Checkbox is check
            Exit Sub
        Else 'Check
            If Me.DGV_formula.Rows.Count = 0 Then
                mdLoadCommitt()
                MessageBox.Show("ไม่พบข้อมูลสูตรสินค้าของสินค้าสำเร็จรูปนี้ ระบบจึงไม่สามารถคำนวณ Package สินค้าได้", sSystemName)
                Exit Sub
            End If
        End If


        Dim stPk As Integer = 0 '0=Pk พอทั้งหมด, 1=Pk เป็น 0 หรือ Nill ไม่สามารถผลิตได้, 2=Pk ไม่พอ ผลิตได้บางส่วน
        Dim stLb As Integer = 0 '0=Lb พอทั้งหมด, 1=Lb เป็น 0 หรือ Nill ไม่สามารถผลิตได้, 2=Lb ไม่พอ ผลิตได้บางส่วน
        Dim stPkOp As Integer = 0 '0=PkOp พอทั้งหมด, 1=PkOp เป็น 0 หรือ Nill ไม่สามารถผลิตได้, 2=PkOp ไม่พอ ผลิตได้บางส่วน
        Dim stStock As Integer = 0 '0=ทุกตัวพอ, 1=มีอย่างน้อย 1 ตัว เป็น 0 ไม่สามารถผลิตได้, 2=มีอย่างน้อย 1 ตัวไม่พอ ผลิตได้บางส่วน

        '---CheckPackage---'
        Dim AmtPk As Integer = 0
        Dim AmtDmd As Integer = 0 'จำนวนสินค้าที่ต้องการ
        For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
            If Me.dgvPkPdSet.Rows(i).Cells(colSelect.Name).Value = True Then
                AmtDmd = Me.dgvPkPdSet.Rows(i).Cells("colAmtTs").Value
                If IsDBNull(Me.dgvPkPdSet.Rows(i).Cells("ColAmtPk").Value) Then
                    AmtPk = 0
                    stPk = 1 'ไม่มี Pk ไม่สามารถผลิตได้
                ElseIf Me.dgvPkPdSet.Rows(i).Cells("ColAmtPk").Value = Nothing Then
                    AmtPk = 0
                    stPk = 1 'ไม่มี Pk ไม่สามารถผลิตได้
                ElseIf Me.dgvPkPdSet.Rows(i).Cells("ColAmtPk").Value = 0 Then
                    AmtPk = 0
                    stPk = 1 'ไม่มี Pk ไม่สามารถผลิตได้
                Else
                    AmtPk = Me.dgvPkPdSet.Rows(i).Cells("ColAmtPk").Value
                    If AmtDmd < AmtPk Then
                        stPk = 0 'Pk พอทั้งหมด
                    Else
                        stPk = 2 'Pk ไม่พอ ผลิตได้บางส่วน
                    End If
                End If
            End If
        Next


        '---CheckLabel---'
        Dim AmtLb As Integer = 0
        For i As Integer = 0 To Me.DGV_Label.Rows.Count - 1
            If Me.DGV_Label.Rows(i).Cells(ColSelectLb.Name).Value = True Then
                If IsDBNull(Me.DGV_Label.Rows(i).Cells("ColAmtLb").Value) Then
                    AmtLb = 0
                    stLb = 1 'ไม่มี Lb ไม่สามารถผลิตได้
                ElseIf Me.DGV_Label.Rows(i).Cells("ColAmtLb").Value = Nothing Then
                    AmtLb = 0
                    stLb = 1 'ไม่มี Lb ไม่สามารถผลิตได้
                ElseIf Me.DGV_Label.Rows(i).Cells("ColAmtLb").Value = 0 Then
                    AmtLb = 0
                    stLb = 1 'ไม่มี Lb ไม่สามารถผลิตได้
                Else
                    AmtLb = Me.DGV_Label.Rows(i).Cells("ColAmtLb").Value
                    If AmtDmd < AmtLb Then
                        stLb = 0 'Lb พอทั้งหมด
                    Else
                        stLb = 2 'Lb ไม่พอ ผลิตได้บางส่วน
                    End If
                End If
            End If
        Next

        '---CheckPkOpen--'
        Dim AmtPOpen As Integer = 0
        Dim idPkDetailOp As Integer = 0
        If UsePkOpen = 1 Then
            For i As Integer = 0 To Me.dgvPkOpen.Rows.Count - 1
                If Me.dgvPkOpen.Rows(i).Cells(ColSelectPkOp.Name).Value = True Then
                    If IsDBNull(Me.dgvPkOpen.Rows(i).Cells("ColAmtPkOp").Value) Then
                        AmtPOpen = 0
                        stPkOp = 1 'ไม่มี PkOp ไม่สามารถผลิตได้
                    ElseIf Me.dgvPkOpen.Rows(i).Cells("ColAmtPkOp").Value = Nothing Then
                        AmtPOpen = 0
                        stPkOp = 1 'ไม่มี PkOp ไม่สามารถผลิตได้
                    ElseIf Me.dgvPkOpen.Rows(i).Cells("ColAmtPkOp").Value = 0 Then
                        AmtPOpen = 0
                        stPkOp = 1 'ไม่มี PkOp ไม่สามารถผลิตได้
                    Else
                        AmtPOpen = Me.dgvPkOpen.Rows(i).Cells("ColAmtPkOp").Value
                        If AmtDmd < AmtPOpen Then
                            stPkOp = 0 'Lb พอทั้งหมด
                        Else
                            stPkOp = 2 'PkOp ไม่พอ ผลิตได้บางส่วน
                        End If
                    End If

                    idPkDetailOp = Me.dgvPkOpen.Rows(i).Cells("ColidPkDetailOp").Value
                End If
            Next
        End If



        Me.dgvResult.Rows.Clear()
        Me.txtAmtBoxLbl.Text = "0"
        For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
            Me.DGV_Box.Rows(i).Cells("ColAmtBox").Value = 0
        Next
        PkgDt.Clear()
        LotUseDt.Clear()

        Dim b As Integer = 0
        Dim j As Integer = 0
        'Dim stStock As Integer = 0 '0=ทุกตัวพอ, 1=มีอย่างน้อย 1 ตัว เป็น 0 ไม่สามารถผลิตได้, 2=มีอย่างน้อย 1 ตัวไม่พอ ผลิตได้บางส่วน

        Dim idLabelUse As Integer = 0
        For i As Integer = 0 To Me.DGV_Label.Rows.Count - 1
            If Me.DGV_Label.Rows(i).Cells(ColSelectLb.Name).Value = True Then
                idLabelUse = Me.DGV_Label.Rows(i).Cells("ColidLabel").Value
            End If
        Next

        For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
            '----Package Select---'
            If Me.dgvPkPdSet.Rows(i).Cells(colSelect.Name).Value = True Then
                '--- Insert Selected into PkgDt(Datatable)---'
                PkgDt.Rows.Add()
                PkgDt.Rows(j).Item("idPdPk") = Me.dgvPkPdSet.Rows(i).Cells("idPdPk").Value
                PkgDt.Rows(j).Item("idPkDetail") = Me.dgvPkPdSet.Rows(i).Cells("ColidPkDetail").Value
                PkgDt.Rows(j).Item("idPkUnit") = Me.dgvPkPdSet.Rows(i).Cells("idPkUnit").Value
                PkgDt.Rows(j).Item("PkName") = Me.dgvPkPdSet.Rows(i).Cells("ColPdPkName").Value
                PkgDt.Rows(j).Item("Weight") = Me.dgvPkPdSet.Rows(i).Cells("colWeight").Value
                PkgDt.Rows(j).Item("UnitW") = Me.dgvPkPdSet.Rows(i).Cells("colUnitW").Value
                PkgDt.Rows(j).Item("idUnitW") = Me.dgvPkPdSet.Rows(i).Cells("ColidUnitW").Value
                PkgDt.Rows(j).Item("AmtTs") = Me.dgvPkPdSet.Rows(i).Cells("colAmtTs").Value
                PkgDt.Rows(j).Item("TotalW") = Me.dgvPkPdSet.Rows(i).Cells("ColTotalW").Value
                PkgDt.Rows(j).Item("status") = 0
                PkgDt.Rows(j).Item("PackageAmt") = 0
                PkgDt.Rows(j).Item("idLabel") = idLabelUse
                PkgDt.Rows(j).Item("idPkDtOpen") = idPkDetailOp

                j = j + 1
            End If
        Next

        If PkgDt.Rows.Count = 0 Then
            'mdLoadCommitt()
            'MessageBox.Show("กรุณาเลือกหน่วยบรรจุย่อยที่ต้องการคำนวณอย่างน้อย 1 รายการ", sSystemName)
            Exit Sub
        End If

        '------ดึง LotStock ของ ส่วนผสมมาเก็บใน LotStTemp------'
        Dim lotDt As New DataTable
        Dim s As Integer = 0
        Dim LotStTemp As New DataTable
        LotStTemp.Columns.Add("idPd", System.Type.GetType("System.String"))
        LotStTemp.Columns.Add("idPdLot", System.Type.GetType("System.String"))
        LotStTemp.Columns.Add("Amount", System.Type.GetType("System.Double"))
        For k As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1 'loop ingredient
            lotDt.Clear()
            sCommand.CommandText = "SELECT idPd, idPdLot, Amount From PkPdLotStock Where idPd= '" & Me.DGV_Ingredient.Rows(k).Cells("colidPd").Value & "' " & _
                                   "AND Amount <> 0 Order by DateRec"
            sAdapter.Fill(lotDt)
            For m As Integer = 0 To lotDt.Rows.Count - 1
                LotStTemp.Rows.Add()
                LotStTemp.Rows(s).Item("idPd") = lotDt.Rows(m).Item("idPd")
                LotStTemp.Rows(s).Item("idPdLot") = lotDt.Rows(m).Item("idPdLot")
                LotStTemp.Rows(s).Item("Amount") = lotDt.Rows(m).Item("Amount")
                s = s + 1
            Next
        Next

        '----------- Select LotStock by idPd in Ingredient -----------'
        Dim sumDt As New DataTable
        mdCnOpen()
        For m As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1 'loop สัดส่วนของส่วนผสม
            sumDt.Clear()
            sCommand.CommandText = "SELECT SUM(Amount) AS AmountTotal From PkPdLotStock Where " & _
                                   "idPd= '" & Me.DGV_Ingredient.Rows(m).Cells("colidPd").Value & "'"
            sAdapter.Fill(sumDt)

            'Check สัดส่วนที่ต้องใช้ กับ จำนวนคงเหลือใน stock
            If IsDBNull(sumDt.Rows(0).Item("AmountTotal")) Then
                stStock = 1 'มีอย่างน้อย 1 ตัว เป็น 0 ไม่สามารถผลิตได้
            ElseIf sumDt.Rows(0).Item("AmountTotal") = 0 Then
                stStock = 1 'มีอย่างน้อย 1 ตัว เป็น 0 ไม่สามารถผลิตได้
            ElseIf DGV_Ingredient.Rows(m).Cells("ColAmgKg").Value > sumDt.Rows(0).Item("AmountTotal") Then
                stStock = 2 'ส่วนผสมอย่างน้อย 1 ตัวไม่พอทั้งหมด --> ผลิตได้บางส่วน
            End If
        Next


        If stStock = 1 Or stPk = 1 Or stLb = 1 Then 'มีอย่างน้อย 1 ตัว เป็น 0 ไม่สามารถผลิตได้ : Exit Func
            If UsePkOpen = 1 Then
                If stPkOp = 1 Then
                    mdLoadCommitt()
                    MessageBox.Show("สินค้าวัตถุดิบอย่างน้อย 1 ตัวไม่มีข้อมูล Lot สินค้าวัตถุดิบ จึงไม่สามารถคำนวณ Package ได้", sSystemName)
                    Exit Sub
                End If
            Else
                mdLoadCommitt()
                MessageBox.Show("สินค้าวัตถุดิบอย่างน้อย 1 ตัวไม่มีข้อมูล Lot สินค้าวัตถุดิบ จึงไม่สามารถคำนวณ Package ได้", sSystemName)
                Exit Sub
            End If
        ElseIf stStock = 0 And stPk = 0 And stLb = 0 Then 'วัตถุดิบทุกตัวพอ + Pk พอ + Lb พอ ทั้งหมด
            Dim stCalAll As Integer = 0 'Check ผลิตได้/ไม่ได้
            If UsePkOpen = 1 Then
                If stPkOp = 0 Then 'PkOp ผลิตได้ทั้งหมด
                    stCalAll = 1
                ElseIf stPkOp = 2 Then 'PkOp ผลิตได้บางส่วน
                    stCalAll = 2
                End If
            Else
                stCalAll = 1
            End If

            If stCalAll = 1 Then 'ผลิตได้ทั้งหมด
                'คำนวณจำนวนชิ้นที่ได้
                For i As Integer = 0 To Me.PkgDt.Rows.Count - 1 'loop Package
                    If PkgDt.Rows(i).Item("status") = 0 And AmountPkTs_kg > 0 Then
                        If PkgDt.Rows(i).Item("PackageAmt") <> PkgDt.Rows(i).Item("AmtTs") Then
                            'จำนวนชิ้น Package ที่ได้
                            PkgDt.Rows(i).Item("PackageAmt") = Math.Floor(PkgDt.Rows(i).Item("TotalW") / PkgDt.Rows(i).Item("Weight"))
                            PkgDt.Rows(i).Item("status") = 1
                        End If
                    End If

                    'Show data to table
                    'If PkgDt.Rows(i).Item("idPkUnit") = 1 Then
                    '    dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระป่อง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"))
                    'ElseIf PkgDt.Rows(i).Item("idPkUnit") = 2 Then
                    '    dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ซอง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"))
                    'ElseIf PkgDt.Rows(i).Item("idPkUnit") = 4 Then
                    '    dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระสอบ", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"))
                    'ElseIf PkgDt.Rows(i).Item("idPkUnit") = 5 Then
                    '    dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กิโลกรัม", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"))
                    'ElseIf PkgDt.Rows(i).Item("idPkUnit") = 6 Then
                    '    dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ถุง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"))
                    'End If

                    If PkgDt.Rows(i).Item("idPkUnit") = 1 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระป่อง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 2 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ซอง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 4 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระสอบ", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 5 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กก.", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 6 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ถุง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    End If
                Next

                'Dim b As Integer = 0
                'LotUseDt.Clear()
                'ตัด Stock ที่ใช้ไป ตาม idPd

                For i As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1 'loop สัดส่วนของส่วนผสม
                    Dim AmtDemand As Double = Me.DGV_Ingredient.Rows(i).Cells("ColAmgKg").Value

                    For k As Integer = 0 To LotStTemp.Rows.Count - 1 'loop StockTemp
                        If LotStTemp.Rows(k).Item("idPd") = Me.DGV_Ingredient.Rows(i).Cells("colidPd").Value Then
                            If AmtDemand > 0 And LotStTemp.Rows(k).Item("Amount") > 0 Then
                                If LotStTemp.Rows(k).Item("Amount") >= AmtDemand Then
                                    LotStTemp.Rows(k).Item("Amount") = LotStTemp.Rows(k).Item("Amount") - AmtDemand

                                    '--- insert lot use to datattable---'
                                    LotUseDt.Rows.Add()
                                    LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(k).Item("idPdLot")
                                    LotUseDt.Rows(b).Item("Amount") = AmtDemand
                                    b = b + 1
                                    AmtDemand = 0

                                    Exit For 'Next ส่วนผสม
                                Else 'Lot ไม่พอ use Next Lot
                                    'Dim lotBalance As Double = 0
                                    AmtDemand = AmtDemand - LotStTemp.Rows(k).Item("Amount")

                                    '--- insert lot use to datattable---'
                                    LotUseDt.Rows.Add()
                                    LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(k).Item("idPdLot")
                                    LotUseDt.Rows(b).Item("Amount") = LotStTemp.Rows(k).Item("Amount")
                                    b = b + 1
                                    LotStTemp.Rows(k).Item("Amount") = 0
                                End If
                            Else
                                Exit For 'ไปตัด stock ส่วนผสมต่อไป
                            End If 'End Check Demand & LotStock
                        End If
                    Next
                Next

                '----Insert LotUse To DGV_Lot ----'
                For i As Integer = 0 To LotUseDt.Rows.Count - 1
                    Dim detailDt As New DataTable
                    detailDt.Clear()
                    sCommand.CommandText = "SELECT l.LotNum, l.LotCodeRef, s.PdName, l.Amount, l.idPd " & _
                                           "FROM PkPdLotStock l LEFT OUTER JOIN vSeedProduct s " & _
                                           "ON l.idPd = s.idPd WHERE l.idPdLot = '" & LotUseDt.Rows(i).Item("idPdMixLot") & "'"
                    sAdapter.Fill(detailDt)

                    'DGVL_Lot Row add
                    With DGV_Lot
                        Dim rc As Integer = DGV_Lot.RowCount
                        .Rows.Add()
                        '.Rows(rc).Cells("ColNum").Value = rc + 1
                        .Rows(rc).Cells("colidPdLot").Value = LotUseDt.Rows(i).Item("idPdMixLot")
                        .Rows(rc).Cells("colLotNo").Value = detailDt.Rows(0)("LotNum")
                        .Rows(rc).Cells("colLotRef").Value = detailDt.Rows(0)("LotCodeRef")
                        .Rows(rc).Cells("colPdName").Value = detailDt.Rows(0)("PdName")
                        .Rows(rc).Cells("colLotAmount").Value = detailDt.Rows(0)("Amount")
                        .Rows(rc).Cells("ColuRealUse").Value = LotUseDt.Rows(i).Item("Amount")
                        .Rows(rc).Cells("ColidPdUse").Value = detailDt.Rows(0)("idPd")
                    End With
                Next
                DGV_Lot.Sort(DGV_Lot.Columns("ColPdName"), System.ComponentModel.ListSortDirection.Ascending)
                ksbCountRowDgv(DGV_Lot, ColNum.Name)
                SumWOfLot()
            ElseIf stCalAll = 2 Then 'ฝาไม่พอ ผลิตได้บางส่วน
                For i As Integer = 0 To Me.PkgDt.Rows.Count - 1 'loop Package Select
                    Dim AmtComplete As Integer = 0 'จำนวนชิ้นที่ได้
                    Dim stPackage As Integer = 0 'สถานะ Pk : 0=ผลิตได้, 1=ผลิตไม่ได้

                    While stPackage = 0 And AmtComplete < PkgDt.Rows(i).Item("AmtTs")
                        'Check status ส่วนผสม
                        For k As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1 'loop ingredient
                            '---คำนวณสัดส่วนน้ำหนัก/ชิ้น/1 Package ---'
                            Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value = PkgDt.Rows(i).Item("Weight") * (Me.DGV_Ingredient.Rows(k).Cells("ingredient").Value / 100)
                            If PkgDt.Rows(i).Item("idUnitW") = 1 Then 'กรัม
                                Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value = Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value / 1000
                            End If

                            '---SUM LotStock แยกตาม idPd ---'
                            Dim SumOfidPd As Double = 0
                            For m As Integer = 0 To LotStTemp.Rows.Count - 1 'loop StockTemp
                                If LotStTemp.Rows(m).Item("idPd") = Me.DGV_Ingredient.Rows(k).Cells("colidPd").Value Then
                                    SumOfidPd = SumOfidPd + LotStTemp.Rows(m).Item("Amount")
                                End If
                            Next

                            If Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value > SumOfidPd Then
                                stPackage = 1 'มีอย่างน้อย 1 ส่วนผสมไม่พอ:=ชิ้นปัจจุบันทำไม่ได้
                            End If
                        Next


                        'ตัด stock + เพิ่มจำนวนที่ผลิตได้
                        If stPackage = 0 Then
                            For k As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1 'loop ingredient
                                Dim AmtDemand As Double = Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value

                                For m As Integer = 0 To LotStTemp.Rows.Count - 1 'loop StockTemp
                                    If LotStTemp.Rows(m).Item("idPd") = Me.DGV_Ingredient.Rows(k).Cells("colidPd").Value Then
                                        If AmtDemand > 0 And LotStTemp.Rows(m).Item("Amount") > 0 Then
                                            If Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value <= LotStTemp.Rows(m).Item("Amount") Then
                                                LotStTemp.Rows(m).Item("Amount") = LotStTemp.Rows(m).Item("Amount") - AmtDemand


                                                '--- insert lot use to datatable---'
                                                Dim stLot As Integer = 0
                                                If LotUseDt.Rows.Count = 0 Then 'ยังไม่มีข้อมูล LotUse
                                                    LotUseDt.Rows.Add()
                                                    LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                    LotUseDt.Rows(b).Item("Amount") = AmtDemand
                                                    b = b + 1
                                                Else 'มีข้อมูล LotUse แล้ว
                                                    '----------Lot เดียวกัน------------'
                                                    For y As Integer = 0 To LotUseDt.Rows.Count - 1
                                                        If LotUseDt.Rows(y).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot") Then
                                                            LotUseDt.Rows(y).Item("Amount") = LotUseDt.Rows(y).Item("Amount") + AmtDemand
                                                            stLot = 1 'Lot เดียวกัน update แล้ว
                                                        End If
                                                    Next

                                                    '----------Lot อื่น------------'
                                                    If stLot <> 1 Then 'ยังไม่ได้ update
                                                        LotUseDt.Rows.Add()
                                                        LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                        LotUseDt.Rows(b).Item("Amount") = AmtDemand
                                                        b = b + 1
                                                    End If
                                                End If

                                                AmtDemand = 0
                                                Exit For 'ไปตัด stock ส่วนผสมต่อไป
                                            Else 'จำนวนที่ต้องใช้ > LotStock
                                                'Dim lotBalance As Double = 0
                                                AmtDemand = AmtDemand - LotStTemp.Rows(m).Item("Amount")

                                                '--- insert lot use to datatable---'
                                                Dim stLot As Integer = 0
                                                If LotUseDt.Rows.Count = 0 Then 'ยังไม่มีข้อมูล LotUse
                                                    LotUseDt.Rows.Add()
                                                    LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                    LotUseDt.Rows(b).Item("Amount") = LotStTemp.Rows(m).Item("Amount")
                                                    b = b + 1
                                                Else 'มีข้อมูล LotUse แล้ว
                                                    '----------Lot เดียวกัน------------'
                                                    For y As Integer = 0 To LotUseDt.Rows.Count - 1
                                                        If LotUseDt.Rows(y).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot") Then
                                                            LotUseDt.Rows(y).Item("Amount") = LotUseDt.Rows(y).Item("Amount") + LotStTemp.Rows(m).Item("Amount")
                                                            stLot = 1 'Lot เดียวกัน update แล้ว
                                                        End If
                                                    Next

                                                    '----------Lot อื่น------------'
                                                    If stLot <> 1 Then 'ยังไม่ได้ update
                                                        LotUseDt.Rows.Add()
                                                        LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                        LotUseDt.Rows(b).Item("Amount") = LotStTemp.Rows(m).Item("Amount")
                                                        b = b + 1
                                                    End If
                                                End If
                                                LotStTemp.Rows(m).Item("Amount") = 0

                                            End If 'End Check พอ/ไม่พอ
                                        End If
                                    End If 'End Check ว่าส่วนผสมเดียวกัน

                                Next 'End loop StockTemp
                            Next

                            If UsePkOpen = 1 Then
                                If AmtPk > 0 And AmtLb > 0 And AmtPOpen > 0 Then
                                    AmtComplete = AmtComplete + 1
                                    AmtPk = AmtPk - 1
                                    AmtLb = AmtLb - 1
                                    AmtPOpen = AmtPOpen - 1
                                Else
                                    Exit While 'Pk / Lb ไม่พอ จบการทำงาน
                                End If
                            Else
                                If AmtPk > 0 And AmtLb > 0 Then
                                    AmtComplete = AmtComplete + 1
                                    AmtPk = AmtPk - 1
                                    AmtLb = AmtLb - 1
                                Else
                                    Exit While 'Pk / Lb ไม่พอ จบการทำงาน
                                End If
                            End If 'End usepkOp


                        End If
                    End While

                    PkgDt.Rows(i).Item("PackageAmt") = AmtComplete
                    PkgDt.Rows(i).Item("status") = 1

                    '----Insert LotUse To DGV_Lot ----'
                    For t As Integer = 0 To LotUseDt.Rows.Count - 1
                        Dim detailDt As New DataTable
                        detailDt.Clear()
                        sCommand.CommandText = "SELECT l.LotNum, l.LotCodeRef, s.PdName, l.Amount, l.idPd " & _
                                               "FROM PkPdLotStock l LEFT OUTER JOIN vSeedProduct s " & _
                                               "ON l.idPd = s.idPd WHERE l.idPdLot = '" & LotUseDt.Rows(t).Item("idPdMixLot") & "'"
                        sAdapter.Fill(detailDt)

                        'DGVL_Lot Row add
                        With DGV_Lot
                            Dim rc As Integer = DGV_Lot.RowCount
                            .Rows.Add()
                            ' .Rows(rc).Cells("ColNum").Value = rc + 1
                            .Rows(rc).Cells("colidPdLot").Value = LotUseDt.Rows(t).Item("idPdMixLot")
                            .Rows(rc).Cells("colLotNo").Value = detailDt.Rows(0)("LotNum")
                            .Rows(rc).Cells("colLotRef").Value = detailDt.Rows(0)("LotCodeRef")
                            .Rows(rc).Cells("colPdName").Value = detailDt.Rows(0)("PdName")
                            .Rows(rc).Cells("colLotAmount").Value = detailDt.Rows(0)("Amount")
                            .Rows(rc).Cells("ColuRealUse").Value = LotUseDt.Rows(t).Item("Amount")
                            .Rows(rc).Cells("ColidPdUse").Value = detailDt.Rows(0)("idPd")
                        End With
                    Next
                    DGV_Lot.Sort(DGV_Lot.Columns("ColPdName"), System.ComponentModel.ListSortDirection.Ascending)
                    ksbCountRowDgv(DGV_Lot, ColNum.Name)
                    SumWOfLot()

                    'Show data to table
                    If PkgDt.Rows(i).Item("idPkUnit") = 1 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระป่อง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 2 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ซอง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 4 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระสอบ", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 5 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กก.", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 6 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ถุง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    End If

                    'Me. dgvResult.CurrentCell.Value=
                Next 'End package ---> Next Package Select
            End If 'End stCallAll

        ElseIf stStock = 2 Or stPk = 2 Or stLb = 2 Then 'มีอย่างน้อย 1 ตัว / Pk / Label ไม่พอ ผลิตได้บางส่วน
            Dim stCal As Integer = 0
            If UsePkOpen = 1 Then
                If stPkOp = 1 Then
                    mdLoadCommitt()
                    MessageBox.Show("สินค้าวัตถุดิบอย่างน้อย 1 ตัวไม่มีข้อมูล Lot สินค้าวัตถุดิบ จึงไม่สามารถคำนวณ Package ได้", sSystemName)
                    Exit Sub
                Else '0/2
                    stCal = 1
                End If
            Else
                stCal = 1
            End If

            'Dim b As Integer = 0 'ค่า loop LotUseDt
            'LotUseDt.Clear()

            If stCal = 1 Then
                For i As Integer = 0 To Me.PkgDt.Rows.Count - 1 'loop Package Select
                    Dim AmtComplete As Integer = 0 'จำนวนชิ้นที่ได้
                    Dim stPackage As Integer = 0 'สถานะ Pk : 0=ผลิตได้, 1=ผลิตไม่ได้

                    While stPackage = 0 And AmtComplete < PkgDt.Rows(i).Item("AmtTs")
                        'Check status ส่วนผสม
                        For k As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1 'loop ingredient
                            '---คำนวณสัดส่วนน้ำหนัก/ชิ้น/1 Package ---'
                            Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value = PkgDt.Rows(i).Item("Weight") * (Me.DGV_Ingredient.Rows(k).Cells("ingredient").Value / 100)
                            If PkgDt.Rows(i).Item("idUnitW") = 1 Then 'กรัม
                                Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value = Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value / 1000
                            End If

                            '---SUM LotStock แยกตาม idPd ---'
                            Dim SumOfidPd As Double = 0
                            For m As Integer = 0 To LotStTemp.Rows.Count - 1 'loop StockTemp
                                If LotStTemp.Rows(m).Item("idPd") = Me.DGV_Ingredient.Rows(k).Cells("colidPd").Value Then
                                    SumOfidPd = SumOfidPd + LotStTemp.Rows(m).Item("Amount")
                                End If
                            Next

                            If Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value > SumOfidPd Then
                                stPackage = 1 'มีอย่างน้อย 1 ส่วนผสมไม่พอ:=ชิ้นปัจจุบันทำไม่ได้
                            End If
                        Next


                        'ตัด stock + เพิ่มจำนวนที่ผลิตได้
                        If stPackage = 0 Then
                            For k As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1 'loop ingredient
                                Dim AmtDemand As Double = Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value

                                For m As Integer = 0 To LotStTemp.Rows.Count - 1 'loop StockTemp
                                    If LotStTemp.Rows(m).Item("idPd") = Me.DGV_Ingredient.Rows(k).Cells("colidPd").Value Then
                                        If AmtDemand > 0 And LotStTemp.Rows(m).Item("Amount") > 0 Then
                                            If Me.DGV_Ingredient.Rows(k).Cells("ColratioW").Value <= LotStTemp.Rows(m).Item("Amount") Then
                                                LotStTemp.Rows(m).Item("Amount") = LotStTemp.Rows(m).Item("Amount") - AmtDemand


                                                '--- insert lot use to datatable---'
                                                Dim stLot As Integer = 0
                                                If LotUseDt.Rows.Count = 0 Then 'ยังไม่มีข้อมูล LotUse
                                                    LotUseDt.Rows.Add()
                                                    LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                    LotUseDt.Rows(b).Item("Amount") = AmtDemand
                                                    b = b + 1
                                                Else 'มีข้อมูล LotUse แล้ว
                                                    '----------Lot เดียวกัน------------'
                                                    For y As Integer = 0 To LotUseDt.Rows.Count - 1
                                                        If LotUseDt.Rows(y).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot") Then
                                                            LotUseDt.Rows(y).Item("Amount") = LotUseDt.Rows(y).Item("Amount") + AmtDemand
                                                            stLot = 1 'Lot เดียวกัน update แล้ว
                                                        End If
                                                    Next

                                                    '----------Lot อื่น------------'
                                                    If stLot <> 1 Then 'ยังไม่ได้ update
                                                        LotUseDt.Rows.Add()
                                                        LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                        LotUseDt.Rows(b).Item("Amount") = AmtDemand
                                                        b = b + 1
                                                    End If
                                                End If

                                                AmtDemand = 0
                                                Exit For 'ไปตัด stock ส่วนผสมต่อไป
                                            Else 'จำนวนที่ต้องใช้ > LotStock
                                                'Dim lotBalance As Double = 0
                                                AmtDemand = AmtDemand - LotStTemp.Rows(m).Item("Amount")

                                                '--- insert lot use to datatable---'
                                                Dim stLot As Integer = 0
                                                If LotUseDt.Rows.Count = 0 Then 'ยังไม่มีข้อมูล LotUse
                                                    LotUseDt.Rows.Add()
                                                    LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                    LotUseDt.Rows(b).Item("Amount") = LotStTemp.Rows(m).Item("Amount")
                                                    b = b + 1
                                                Else 'มีข้อมูล LotUse แล้ว
                                                    '----------Lot เดียวกัน------------'
                                                    For y As Integer = 0 To LotUseDt.Rows.Count - 1
                                                        If LotUseDt.Rows(y).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot") Then
                                                            LotUseDt.Rows(y).Item("Amount") = LotUseDt.Rows(y).Item("Amount") + LotStTemp.Rows(m).Item("Amount")
                                                            stLot = 1 'Lot เดียวกัน update แล้ว
                                                        End If
                                                    Next

                                                    '----------Lot อื่น------------'
                                                    If stLot <> 1 Then 'ยังไม่ได้ update
                                                        LotUseDt.Rows.Add()
                                                        LotUseDt.Rows(b).Item("idPdMixLot") = LotStTemp.Rows(m).Item("idPdLot")
                                                        LotUseDt.Rows(b).Item("Amount") = LotStTemp.Rows(m).Item("Amount")
                                                        b = b + 1
                                                    End If
                                                End If
                                                LotStTemp.Rows(m).Item("Amount") = 0

                                            End If 'End Check พอ/ไม่พอ
                                        End If
                                    End If 'End Check ว่าส่วนผสมเดียวกัน

                                Next 'End loop StockTemp
                            Next

                            If UsePkOpen = 1 Then
                                If AmtPk > 0 And AmtLb > 0 And AmtPOpen > 0 Then
                                    AmtComplete = AmtComplete + 1
                                    AmtPk = AmtPk - 1
                                    AmtLb = AmtLb - 1
                                    AmtPOpen = AmtPOpen - 1
                                Else
                                    Exit While 'Pk / Lb ไม่พอ จบการทำงาน
                                End If
                            Else
                                If AmtPk > 0 And AmtLb > 0 Then
                                    AmtComplete = AmtComplete + 1
                                    AmtPk = AmtPk - 1
                                    AmtLb = AmtLb - 1
                                Else
                                    Exit While 'Pk / Lb ไม่พอ จบการทำงาน
                                End If
                            End If 'End usepkOp


                        End If
                    End While

                    PkgDt.Rows(i).Item("PackageAmt") = AmtComplete
                    PkgDt.Rows(i).Item("status") = 1

                    '----Insert LotUse To DGV_Lot ----'
                    For t As Integer = 0 To LotUseDt.Rows.Count - 1
                        Dim detailDt As New DataTable
                        detailDt.Clear()
                        sCommand.CommandText = "SELECT l.LotNum, l.LotCodeRef, s.PdName, l.Amount, l.idPd " & _
                                               "FROM PkPdLotStock l LEFT OUTER JOIN vSeedProduct s " & _
                                               "ON l.idPd = s.idPd WHERE l.idPdLot = '" & LotUseDt.Rows(t).Item("idPdMixLot") & "'"
                        sAdapter.Fill(detailDt)

                        'DGVL_Lot Row add
                        With DGV_Lot
                            Dim rc As Integer = DGV_Lot.RowCount
                            .Rows.Add()
                            ' .Rows(rc).Cells("ColNum").Value = rc + 1
                            .Rows(rc).Cells("colidPdLot").Value = LotUseDt.Rows(t).Item("idPdMixLot")
                            .Rows(rc).Cells("colLotNo").Value = detailDt.Rows(0)("LotNum")
                            .Rows(rc).Cells("colLotRef").Value = detailDt.Rows(0)("LotCodeRef")
                            .Rows(rc).Cells("colPdName").Value = detailDt.Rows(0)("PdName")
                            .Rows(rc).Cells("colLotAmount").Value = detailDt.Rows(0)("Amount")
                            .Rows(rc).Cells("ColuRealUse").Value = LotUseDt.Rows(t).Item("Amount")
                            .Rows(rc).Cells("ColidPdUse").Value = detailDt.Rows(0)("idPd")
                        End With
                    Next
                    DGV_Lot.Sort(DGV_Lot.Columns("ColPdName"), System.ComponentModel.ListSortDirection.Ascending)
                    ksbCountRowDgv(DGV_Lot, ColNum.Name)
                    SumWOfLot()

                    'Show data to table
                    If PkgDt.Rows(i).Item("idPkUnit") = 1 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระป่อง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 2 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ซอง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 4 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กระสอบ", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 5 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "กก.", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    ElseIf PkgDt.Rows(i).Item("idPkUnit") = 6 Then
                        dgvResult.Rows.Add(PkgDt.Rows(i).Item("idPdPk"), PkgDt.Rows(i).Item("PkName"), PkgDt.Rows(i).Item("AmtTs"), PkgDt.Rows(i).Item("PackageAmt"), "ถุง", PkgDt.Rows(i).Item("idPkDetail"), PkgDt.Rows(i).Item("idLabel"), PkgDt.Rows(i).Item("idPkDtOpen"))
                    End If

                    'Me. dgvResult.CurrentCell.Value=
                Next 'End package ---> Next Package Select
            End If 'End stCal

        End If

        'มีรายการ
        Dim AmtTotal As Integer = 0
        If dgvResult.Rows.Count > 0 Then
            dgvResult.CurrentCell = dgvResult.Item("ColAmt", 0)
            dgvResult.Rows(0).Height = 40

            For i As Integer = 0 To Me.dgvResult.Rows.Count - 1
                AmtTotal = AmtTotal + Me.dgvResult.Rows(i).Cells("ColAmt").Value
            Next
            '--------- Cal Amount Box & BoxLabel -----------'
            If CInt(Me.lblPerbox.Text) <> 0 Then
                Dim AmountBox As Integer = 0
                AmountBox = Me.dgvResult.Rows(0).Cells("ColAmt").Value / CInt(Me.lblPerbox.Text)
                Me.txtAmtBoxLbl.Text = Format(AmountBox, "#,##0")
                For n As Integer = 0 To DGV_Box.Rows.Count - 1
                    If Me.DGV_Box.Rows(n).Cells("ColSelectBox").Value = True Then
                        Me.DGV_Box.Rows(n).Cells("ColAmtBox").Value = Format(AmountBox, "#,##0")
                    End If
                Next

                Me.DGV_Box.Enabled = True
                Me.txtAmtBoxLbl.Enabled = True
            Else
                mdLoadCommitt()
                MessageBox.Show("ระบบไม่มีข้อมูล จำนวนต่อกล่อง ของสินค้านี้ จึงไม่สามารถคำนวณจำนวนกล่อง และฉลากติดกล่องที่ใช้ได้", sSystemName)
                Exit Sub
            End If

        End If
        Me.txtAmtTotal.Text = Format(AmtTotal, "#,##0")


        If stStock = 2 Then
            mdLoadCommitt()
            MessageBox.Show("ผลิตสินค้าสำเร็จรูปได้บางส่วนของจำนวนที่ต้องการ " & vbCrLf & vbCrLf & "สามารถผลิตได้เพียง : " & Me.txtAmtTotal.Text & " ชิ้น", sSystemName)
        End If

    End Sub


    Private Sub CalWeight()
        AmountPkTs_gum = 0
        AmountPkTs_kg = 0
        Dim stCheck As Integer = 0

        '---Check Select Checkbox Fl----'
        For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
            If Me.dgvPkPdSet.Rows(i).Cells(colSelect.Name).Value = True Then
                stCheck = 1
            End If
        Next

        If stCheck = 0 Then
            'No Checbox row Select
            '---คำนวณสัดส่วนน้ำหนัก (%)ตามสูตร---'
            For i As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1
                Me.DGV_Ingredient.Rows(i).Cells("ColAmgKg").Value = 0
            Next
            Me.dgvResult.Rows.Clear()
            Me.txtAmtBoxLbl.Text = "0"
            For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
                Me.DGV_Box.Rows(i).Cells("ColAmtBox").Value = 0
            Next

            Me.txtAmtBoxLbl.Text = "0"
            For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
                Me.DGV_Box.Rows(i).Cells("ColAmtBox").Value = 0
            Next
            Me.txtAmtTotal.Text = "0"
            Me.txtSumWeight.Text = "0"
            Exit Sub
        End If

        For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
            '----Package Select---'
            If Me.dgvPkPdSet.Rows(i).Cells(key.Name).Value = 1 Then
                '------Cheang row color ------'
                Me.dgvPkPdSet.Rows(i).DefaultCellStyle.ForeColor = Color.DodgerBlue

                Me.dgvPkPdSet.Rows(i).Cells("colTotalW").Value = Me.dgvPkPdSet.Rows(i).Cells("colWeight").Value * Me.dgvPkPdSet.Rows(i).Cells("colAmtTs").Value
                '--- Sum AmountTs ----'
                If Me.dgvPkPdSet.Rows(i).Cells("ColidUnitW").Value = 1 Then 'กรัม
                    AmountPkTs_gum = AmountPkTs_gum + Me.dgvPkPdSet.Rows(i).Cells("colTotalW").Value
                Else 'Kg
                    AmountPkTs_gum = AmountPkTs_gum + Me.dgvPkPdSet.Rows(i).Cells("colTotalW").Value * 1000
                End If
            Else
                Me.dgvPkPdSet.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                Me.dgvPkPdSet.Rows(i).Cells("colAmtTs").Value = 0
                Me.dgvPkPdSet.Rows(i).Cells("colTotalW").Value = 0
            End If
            'Me.dgvResult.Rows.Clear()
        Next
        AmountPkTs_kg = AmountPkTs_gum / 1000
        Me.txtSumWeight.Text = Format(AmountPkTs_kg, "#,##0.00")

        '---คำนวณสัดส่วนน้ำหนัก (%)ตามสูตร---'
        For i As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1
            Me.DGV_Ingredient.Rows(i).Cells("ColAmgKg").Value = AmountPkTs_kg * (Me.DGV_Ingredient.Rows(i).Cells("ingredient").Value / 100)
        Next

    End Sub

    Private Sub SumWOfLot()
        For i As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1
            Me.DGV_Ingredient.Rows(i).Cells("ColSumWUse").Value = 0
            Me.DGV_Ingredient.Rows(i).Cells("ColWUse").Value = 0
        Next


        For i As Integer = 0 To Me.DGV_Lot.Rows.Count - 1
            For j As Integer = 0 To Me.DGV_Ingredient.Rows.Count - 1
                Dim vTest As String = Me.DGV_Lot.Rows(i).Cells("ColidPdUse").Value & "/" & Me.DGV_Ingredient.Rows(j).Cells("colidPd").Value

                If Me.DGV_Lot.Rows(i).Cells("ColidPdUse").Value = Me.DGV_Ingredient.Rows(j).Cells("colidPd").Value Then
                    Dim SumW As Double = Me.DGV_Ingredient.Rows(j).Cells("ColSumWUse").Value
                    SumW = SumW + CDbl(Me.DGV_Lot.Rows(i).Cells("ColLotAmount").Value)

                    Dim WUse As Double = Me.DGV_Ingredient.Rows(j).Cells("ColWUse").Value
                    WUse = WUse + CDbl(Me.DGV_Lot.Rows(i).Cells("ColuRealUse").Value)

                    DGV_Ingredient.Rows(j).Cells("ColSumWUse").Value = Format(SumW, "#,##0.00")
                    DGV_Ingredient.Rows(j).Cells("ColWUse").Value = Format(WUse, "#,##0.00")

                    Exit For
                End If
            Next
        Next

    End Sub


    'Private Sub btnFindPdT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindPdT.Click
    '    Dim vFrm As New frmSlPdTradeSelectPacking()
    '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        If vFrm.stOrder = 1 Then
    '            Me.lblOrderAmt.Text = Format(vFrm.OrderAmt, "#,##0")
    '            Me.lblOrderAmt.Visible = True
    '            Me.Label35.Visible = True
    '            Me.Label38.Visible = True
    '        Else
    '            Me.lblOrderAmt.Visible = False
    '            Me.Label35.Visible = False
    '            Me.Label38.Visible = False
    '        End If

    '        Me.dgvResult.Rows.Clear()
    '        Me.txtAmtBoxLbl.Text = "0"
    '        For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
    '            Me.DGV_Box.Rows(i).Cells("ColAmtBox").Value = 0
    '        Next

    '        Me.DGV_formula.Enabled = False
    '        For i As Integer = 0 To DGV_formula.Rows.Count - 1
    '            DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.Gainsboro
    '        Next

    '        Me.rdbSelect.Checked = True
    '        mdCnOpen()
    '        Dim aDt As New DataTable
    '        sCommand.CommandText = "Select Sl.idPd, p.PdCode + ' : ' + p.PdName As PdCodeName, Sl.MixPerc, '0' as StockAmt, " & _
    '                               " '0' As DemandW, '0' As SelectLotW, '0' As WUse " & _
    '                               "From SlPdIngredient Sl INNER JOIN vSeedProduct p ON Sl.idPd = p.idPd  " & _
    '                               "Where Sl.idPdT =''" & _
    '                               "And Sl.idFl =''"
    '        sAdapter.Fill(aDt)
    '        Me.DGV_Ingredient.DataSource = aDt

    '        Me.idPdT_ = vFrm.pIdT
    '        Me.PdTName = vFrm.pName

    '        Me.lblPdTName.Tag = idPdT_
    '        Me.lblPdTName.Text = PdTName

    '        Me.dtpDatePacking.Value = Date.Today
    '        Me.dtpCombine.Value = Date.Today
    '        CalExpDate()

    '        Dim stFlMsg As Integer = 0
    '        Dim stPkMsg As Integer = 0
    '        '--- Show Formula ---'
    '        mdCnOpen()
    '        Dim sDt As New DataTable
    '        sDt.Clear()
    '        sCommand.CommandText = "Select idFL, FlName, Note From SlPdFormula " & _
    '                                  "WHERE idPdT = " & Me.lblPdTName.Tag & " Order By FlName"
    '        sAdapter.Fill(sDt)

    '        If sDt.Rows.Count <> 0 Then
    '            Me.DGV_formula.DataSource = sDt
    '            Me.lblMsg.Visible = False
    '        Else
    '            Me.DGV_formula.DataSource = sDt
    '            Me.lblMsg.Visible = True
    '            stFlMsg = 1 'ไม่มีสูตร
    '        End If

    '        ''--- Check Fl Status---'
    '        'For i As Integer = 0 To DGV_formula.Rows.Count - 1
    '        '    Dim stFlCheck As Integer = 0
    '        '    Dim fDt As New DataTable
    '        '    sCommand.CommandText = "Select Sl.idPd, (SELECT SUM(Amount) AS Expr1 FROM PkPdLotStock " & _
    '        '                           "WHERE idPd = Sl.idPd) AS StockAmt " & _
    '        '                           "From SlPdIngredient Sl Where Sl.idPdT =" & Me.lblPdTName.Tag & " " & _
    '        '                           "And Sl.idFl =" & DGV_formula.Rows(i).Cells(colidFL.Name).Value & " "
    '        '    sAdapter.Fill(fDt)
    '        '    For f As Integer = 0 To fDt.Rows.Count - 1
    '        '        If IsDBNull(fDt.Rows(f).Item("StockAmt")) Then
    '        '            stFlCheck = 1
    '        '        End If
    '        '    Next

    '        '    If stFlCheck = 1 Then 'ไม่สามารถผลิตได้ Color pink
    '        '        DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
    '        '    Else 'สามารถผลิตได้ color green
    '        '        DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.PaleGreen
    '        '    End If
    '        'Next


    '        '---Show Packing List ---'
    '        Dim vDt As New DataTable
    '        vDt.Clear()
    '        sCommand.CommandText = "Select dPD.idPkDetail, dPD.SizeName, vPP.Weight, u.UnitW, vPP.idUnitW, " & _
    '                               "ISNull(dPD.Amount,0) As Amount, " & _
    '                                "0 As AmtTs, dPD.idPkUnit, vPP.idPdPk, vPP.PdPkName " & _
    '                                "From dPackingDetail dPD " & _
    '                                "INNER JOIN vPackingPdSet vPP ON vPP.idPkDetail = dPD.idPkDetail " & _
    '                                "INNER JOIN dUnitW u ON vPP.idUnitW = u.idUnitW " & _
    '                                "WHERE vPP.idPdT = " & Me.lblPdTName.Tag & " ORDER BY " & _
    '                                "u.UnitW, vPP.Weight DESC"
    '        sAdapter.Fill(vDt)

    '        If vDt.Rows.Count = 0 Then
    '            Me.lblNoPakage.Visible = True
    '            Me.dgvPkPdSet.DataSource = vDt
    '            stPkMsg = 1 'ไม่มี Pk
    '            'Exit Sub
    '        Else
    '            Me.lblNoPakage.Visible = False
    '            Me.dgvPkPdSet.DataSource = vDt
    '        End If

    '        For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
    '            If dgvPkPdSet.Rows(i).Cells("idPdPk").Value = vFrm.pidPdPk Then
    '                dgvPkPdSet.Rows(i).Cells("colSelect").Value = True
    '                Me.dgvPkPdSet.Rows(i).Cells(key.Name).Value = 1
    '                dgvPkPdSet.Rows(i).DefaultCellStyle.ForeColor = Color.DodgerBlue
    '            End If
    '        Next

    '        '---Show Label List---'
    '        Me.rdbOnlyPk.Checked = True
    '        Dim LbDt As New DataTable
    '        LbDt.Clear()

    '        sCommand.CommandText = "SELECT p.idLabel, l.LabelNameUse, CONVERT(varchar, l.SizeW) + ' x ' + " & _
    '                               "CONVERT(varchar, l.SizeH) + ' ' + l.Unit As WH, ISNull(l.Amount,0) As Amount " & _
    '                               "FROM PkStickLabelSet AS p " & _
    '                               "LEFT OUTER JOIN dPackingLabel AS l ON p.idLabel = l.idLabel " & _
    '                               "WHERE p.idPdPk = ''"

    '        sAdapter.Fill(LbDt)

    '        Me.DGV_Label.DataSource = LbDt
    '        Me.lblNoLabel.Visible = False

    '        '---Show PkOpen List---'
    '        Dim PkOpenDt As New DataTable
    '        PkOpenDt.Clear()

    '        sCommand.CommandText = "SELECT dt.idLid As idPkDetail2,  PKD.SizeName, dt.AmtSuccess As Amount " & _
    '                               "FROM dPackingDetail PKD INNER JOIN PkPackingDt dt " & _
    '                               "ON PKD.idPkDetail = dt.idLid WHERE dt.idPacking = ''  "

    '        sAdapter.Fill(PkOpenDt)

    '        Me.dgvPkOpen.DataSource = PkOpenDt
    '        Me.lblNoPkOp.Visible = False


    '        Me.DGV_Lot.Rows.Clear()
    '        mdLoadCommitt()
    '        If stFlMsg = 1 And stPkMsg = 0 Then
    '            MessageBox.Show("ไม่พบข้อมูลสูตรสินค้าของ : " & Me.lblPdTName.Text, sSystemName)
    '        ElseIf stFlMsg = 0 And stPkMsg = 1 Then
    '            MessageBox.Show("ไม่พบข้อมูล Packing ของ : " & Me.lblPdTName.Text, sSystemName)
    '        ElseIf stFlMsg = 1 And stPkMsg = 1 Then
    '            MessageBox.Show("ไม่พบข้อมูล Package และข้อมูลสูตรสินค้าของ : " & Me.lblPdTName.Text, sSystemName)
    '        End If

    '    End If
    'End Sub

    Private Sub DGV_formula_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_formula.CellEndEdit
        If DGV_formula.Columns(e.ColumnIndex).Name = ColSelectFl.Name Then
            If DGV_formula.Rows(e.RowIndex).Cells(ColSelectFl.Name).Value = False And DGV_formula.Rows(e.RowIndex).Cells(ColFlag.Name).Value = 1 Then
                DGV_formula.Rows(e.RowIndex).Cells(ColSelectFl.Name).Value = True
            End If
        End If

    End Sub


    Private Sub DGV_formula_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_formula.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        '--------Checkbox----'

        Dim idFlCheck As Integer = 0
        If DGV_formula.Columns(e.ColumnIndex).Name = ColSelectFl.Name Then
            mdLoadShow()
            Me.DGV_Lot.Rows.Clear()
            Me.dgvResult.Rows.Clear()
            Me.txtAmtBoxLbl.Text = "0"
            For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
                Me.DGV_Box.Rows(i).Cells("ColAmtBox").Value = 0
            Next


            DGV_formula.Rows(e.RowIndex).Cells(ColFlag.Name).Value = 1
            DGV_formula.Rows(e.RowIndex).Cells(ColSelectFl.Name).Value = True
            For i As Integer = 0 To Me.DGV_formula.Rows.Count - 1
                If i <> e.RowIndex Then
                    DGV_formula.Rows(i).Cells(ColFlag.Name).Value = 0
                End If
            Next

            For i As Integer = 0 To Me.DGV_formula.Rows.Count - 1
                If DGV_formula.Rows(i).Cells(ColFlag.Name).Value <> 1 Then
                    DGV_formula.Rows(i).Cells(ColSelectFl.Name).Value = False
                End If
            Next

            Dim NameCode As String = ""
            idFl_Now = DGV_formula.Rows(e.RowIndex).Cells("colidFL").Value
            mdCnOpen()
            Dim aDt As New DataTable
            aDt.Clear()
            sCommand.CommandText = "Select Sl.idPd, p.PdCode + ' : ' + p.PdName As PdCodeName, Sl.MixPerc, " & _
                                   "(SELECT SUM(Amount) AS Expr1 FROM PkPdLotStock WHERE idPd = Sl.idPd) AS StockAmt, " & _
                                   "'0' As DemandW, '0' As SelectLotW, '0' As WUse " & _
                                   "From SlPdIngredient Sl INNER JOIN vSeedProduct p ON Sl.idPd = p.idPd  " & _
                                   "Where Sl.idPdT =" & Me.lblPdTName.Tag & " " & _
                                   "And Sl.idFl =" & idFl_Now & " "
            sAdapter.Fill(aDt)
            Me.DGV_Ingredient.DataSource = aDt
            DGV_Ingredient.Sort(DGV_Ingredient.Columns("ColPdCodeName"), System.ComponentModel.ListSortDirection.Ascending)

            CalWeight()
            stIntr = 1
            If Me.rdbSelect.Checked = True Then
                Me.btnLot.Visible = False
                If Me.DGV_Lot.Rows.Count = 0 Then
                    Me.btnCalPk.Visible = False
                Else
                    Me.btnCalPk.Visible = True
                End If
                DGV_Ingredient.Columns("ColSelectLot").Visible = True
                DGV_Lot.Columns("ColDel").Visible = True
                Me.DGV_Lot.ReadOnly = False
            ElseIf Me.rdbAutoSelect.Checked = True Then
                Me.btnCalPk.Visible = False
                DGV_Ingredient.Columns("ColSelectLot").Visible = False
                DGV_Lot.Columns("ColDel").Visible = False
            End If
            'Me.btnLot.Visible = True
            'CalPackage()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub dgvPkPdSet_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPkPdSet.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        '--------Checkbox----'
        If dgvPkPdSet.Columns(e.ColumnIndex).Name = colSelect.Name Then
            dgvPkPdSet.Rows(e.RowIndex).Cells(key.Name).Value = 1
            dgvPkPdSet.Rows(e.RowIndex).Cells(colSelect.Name).Value = True
            Me.DGV_Lot.Rows.Clear()
            Me.dgvResult.Rows.Clear()
            Me.txtAmtBoxLbl.Text = "0"
            For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
                Me.DGV_Box.Rows(i).Cells("ColAmtBox").Value = 0
            Next

            For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
                If i <> e.RowIndex Then
                    dgvPkPdSet.Rows(i).Cells(key.Name).Value = 0
                End If
            Next

            For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
                If dgvPkPdSet.Rows(i).Cells(key.Name).Value <> 1 Then
                    dgvPkPdSet.Rows(i).Cells(colSelect.Name).Value = False
                End If
            Next
            CalWeight()

            For i As Integer = 0 To DGV_formula.Rows.Count - 1
                DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.Gainsboro
            Next
            Me.DGV_formula.Enabled = False
            Me.DGV_Ingredient.Enabled = False

            For i As Integer = 0 To Me.DGV_Lot.Rows.Count - 1
                Me.DGV_Lot.Rows(i).Cells(ColuRealUse.Name).Value = 0
            Next

            Dim PerboxDt As New DataTable
            PerboxDt.Clear()
            sCommand.CommandText = "SELECT Perbox FROM vPackingPdSet WHERE idPdPk = " & dgvPkPdSet.Rows(e.RowIndex).Cells(idPdPk.Name).Value & ""
            sAdapter.Fill(PerboxDt)

            If IsDBNull(PerboxDt.Rows(0).Item("Perbox")) Then
                Me.lblPerbox.Text = 0
            Else
                Me.lblPerbox.Text = PerboxDt.Rows(0).Item("Perbox")
            End If

        End If
    End Sub

   
    Private Sub dgvPkPdSet_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPkPdSet.CellEndEdit
        If stPage = 1 Then 'New
            UsePkOpen = 0
            If dgvPkPdSet.Columns(e.ColumnIndex).Name = Me.colAmtTs.Name Then
                mdLoadShow()
                Me.rdbSelect.Checked = True
                CalWeight()

                '---Show PkDetailOpen List---'
                Dim PkOpDt As New DataTable

                PkOpDt.Clear()
                sCommand.CommandText = "SELECT R.idPkDetail2, PKD.SizeName, PKD.Amount " & _
                                       "FROM PkPackageRelateSet R LEFT OUTER JOIN " & _
                                       "dPackingDetail PKD ON R.idPkDetail2 = PKD.idPkDetail " & _
                                       "WHERE R.idPkDetail1 = '" & dgvPkPdSet.CurrentRow.Cells(ColidPkDetail.Name).Value & "'"
                sAdapter.Fill(PkOpDt)
                Me.dgvPkOpen.DataSource = PkOpDt

                If dgvPkPdSet.CurrentRow.Cells(idPkUnit.Name).Value = 1 Then 'กระป๋อง
                    UsePkOpen = 1
                    Me.dgvPkOpen.Enabled = True
                    If PkOpDt.Rows.Count <> 0 Then
                        Me.lblNoPkOp.Visible = False
                    Else
                        Me.lblNoPkOp.Visible = True
                    End If

                    If dgvPkOpen.Rows.Count > 0 Then
                        dgvPkOpen.Rows(0).DefaultCellStyle.ForeColor = Color.DodgerBlue
                        dgvPkOpen.Rows(0).Cells(ColSelectPkOp.Name).Value = True
                        'dgvPkOpen.Rows(0).Cells(ColSelectLb.Name).ReadOnly = True
                    End If
                Else
                    UsePkOpen = 0
                    Me.dgvPkOpen.Enabled = False
                    Me.lblNoPkOp.Visible = False
                End If

                '---Show Label List---'
                Dim LbDt As New DataTable
                LbDt.Clear()
                If Me.rdbOnlyPk.Checked = True Then
                    sCommand.CommandText = "SELECT p.idLabel, l.LabelNameUse, CONVERT(varchar, l.SizeW) + ' x ' + " & _
                                           "CONVERT(varchar, l.SizeH) + ' ' + l.Unit As WH, ISNull(l.Amount,0) As Amount " & _
                                           "FROM PkStickLabelSet AS p " & _
                                           "LEFT OUTER JOIN dPackingLabel AS l ON p.idLabel = l.idLabel " & _
                                           "WHERE p.idPdPk = '" & dgvPkPdSet.CurrentRow.Cells(idPdPk.Name).Value & "'"
                ElseIf Me.rdbAllPk.Checked = True Then
                    sCommand.CommandText = "SELECT idLabel, LabelNameUse, CONVERT(varchar, SizeW) + ' x ' + " & _
                                            "CONVERT(varchar, SizeH) + ' ' + Unit As WH, ISNull(Amount,0) As Amount " & _
                                           "FROM dPackingLabel WHERE stUser = 0 "
                End If
                sAdapter.Fill(LbDt)

                If LbDt.Rows.Count <> 0 Then
                    Me.DGV_Label.DataSource = LbDt
                    Me.lblNoLabel.Visible = False

                    If Me.rdbOnlyPk.Checked = True Then
                        'DGV_Label.Columns("ColSelectLb").Visible = False
                        DGV_Label.Rows(0).DefaultCellStyle.ForeColor = Color.DodgerBlue
                        DGV_Label.Rows(0).Cells(ColSelectLb.Name).Value = True
                        DGV_Label.Rows(0).Cells(ColSelectLb.Name).ReadOnly = True

                        'Show Label To BoxLabel
                        Me.lblBoxLabel.Text = DGV_Label.Rows(0).Cells(ColLabelName.Name).Value & _
                                              " (" & DGV_Label.Rows(0).Cells(ColWH.Name).Value & ")"
                        Me.lblBoxLabel.Tag = DGV_Label.Rows(0).Cells(ColidLabel.Name).Value
                    End If
                Else
                    Me.DGV_Label.DataSource = LbDt
                    Me.lblNoLabel.Visible = True
                End If



                DGV_formula.Enabled = True
                DGV_formula.ScrollBars = ScrollBars.Vertical
                DGV_Ingredient.Enabled = True

                '--- Check Fl Status---'
                For i As Integer = 0 To DGV_formula.Rows.Count - 1
                    Dim stFlCheck As Integer = 0
                    Dim fDt As New DataTable
                    sCommand.CommandText = "Select Sl.idPd, Sl.MixPerc, (SELECT SUM(Amount) AS Expr1 FROM PkPdLotStock " & _
                                           "WHERE idPd = Sl.idPd) AS StockAmt, '0' AS RatioUse " & _
                                           "From SlPdIngredient Sl Where Sl.idPdT =" & Me.lblPdTName.Tag & " " & _
                                           "And Sl.idFl =" & DGV_formula.Rows(i).Cells(colidFL.Name).Value & " "
                    'MessageBox.Show(Me.lblPdTName.Tag & "/" & DGV_formula.Rows(i).Cells(colidFL.Name).Value)
                    sAdapter.Fill(fDt)

                    For f As Integer = 0 To fDt.Rows.Count - 1
                        If IsDBNull(fDt.Rows(f).Item("StockAmt")) Then
                            stFlCheck = 1
                        ElseIf fDt.Rows(f).Item("StockAmt") = 0 Then
                            stFlCheck = 1
                        End If
                    Next

                    If stFlCheck = 1 Then 'ไม่สามารถผลิตได้ - ไม่มีวัตถุดิบใน Stock
                        DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.Pink
                    Else 'สามารถผลิตได้ --> Check เงื่อนไขต่อ ว่าผลิตได้ทั้งหมด /ผลิตได้บางส่วน
                        For f As Integer = 0 To fDt.Rows.Count - 1
                            fDt.Rows(f).Item("RatioUse") = CDbl(txtSumWeight.Text) * (fDt.Rows(f).Item("MixPerc") / 100)
                            If fDt.Rows(f).Item("StockAmt") < fDt.Rows(f).Item("RatioUse") Then
                                stFlCheck = 2 'ไม่พอ ผลิตได้บางส่วน 
                            End If
                        Next

                        If stFlCheck = 2 Then
                            DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon  'ไม่พอ ผลิตได้บางส่วน
                        Else
                            DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.PaleGreen  'พอ ผลิตได้ทั้งหมด
                        End If
                    End If
                Next

                mdLoadCommitt()
            End If

            If dgvPkPdSet.Columns(e.ColumnIndex).Name = colSelect.Name And dgvPkPdSet.Rows(e.RowIndex).Cells(key.Name).Value = 1 Then
                If dgvPkPdSet.Rows(e.RowIndex).Cells(colSelect.Name).Value = False Then
                    dgvPkPdSet.Rows(e.RowIndex).Cells(colSelect.Name).Value = True

                End If
            End If
        End If
    End Sub

    Private Sub dgvPkPdSet_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvPkPdSet.EditingControlShowing
        With Me.dgvPkPdSet
            If .CurrentCell.OwningColumn.Name = colAmtTs.Name Then
                Dim tb As TextBox = CType(e.Control, TextBox)
                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If
        End With
    End Sub

    

    Private Sub DGV_Lot_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV_Lot.EditingControlShowing
        With Me.DGV_Lot
            If .CurrentCell.OwningColumn.Name = ColuRealUse.Name Then
                Dim tb As TextBox = CType(e.Control, TextBox)
                AddHandler tb.KeyPress, AddressOf TextBox2_KeyPress
            End If
        End With
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Me.dgvPkPdSet.CurrentCell.OwningColumn.Name = colAmtTs.Name Then
            If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Or Asc(e.KeyChar) = 46 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Me.DGV_Lot.CurrentCell.OwningColumn.Name = ColuRealUse.Name Then
            If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If
    End Sub
   

    Private Sub DGV_Ingredient_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Ingredient.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        'Link to LotStock
        If DGV_Ingredient.Columns(e.ColumnIndex).Name = Me.ColStock.Name Then
            Dim vFrm As New frmPdStock(frmPdStock.eProcess.eShowDt, DGV_Ingredient.CurrentRow.Cells("colidPd").Value)
            vFrm.Show()
        End If
    End Sub

    Private Sub DGV_Ingredient_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Ingredient.CellContentClick
        '---Select Lot---'
        If DGV_Ingredient.Columns(e.ColumnIndex).Name = Me.ColSelectLot.Name Then
            If IsDBNull(DGV_Ingredient.Rows(e.RowIndex).Cells("ColStock").Value) Then
                MessageBox.Show("ไม่พบข้อมูล Stock สินค้าวัตถุดิบ", sSystemName)
                Exit Sub
            Else

                '--เก็บ idPdLot ที่มีแล้ว --'
                Dim s As Integer = 0
                Dim idPdLotCut As New DataTable 'เก็บ idPdLot ที่เลือกมาแล้ว
                idPdLotCut.Columns.Add("idPdLot", System.Type.GetType("System.Int32"))

                For i As Integer = 0 To DGV_Lot.Rows.Count - 1
                    idPdLotCut.Rows.Add()
                    idPdLotCut.Rows(s).Item("idPdLot") = DGV_Lot.Rows(i).Cells("ColidPdLot").Value
                    s = s + 1
                Next

                Dim vFrm As New frmPdStock(frmPdStock.eProcess.eCheckbox, DGV_Ingredient.CurrentRow.Cells("colidPd").Value)
                vFrm.idPdLotCut_temp = idPdLotCut
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    For i As Integer = 0 To vFrm.Lot_temp.Rows.Count - 1
                        DGV_Lot.Rows.Add(Nothing, vFrm.Lot_temp.Rows(i).Item("idPdLot"), vFrm.Lot_temp.Rows(i).Item("LotNo"), vFrm.Lot_temp.Rows(i).Item("LotRefCode"), vFrm.Lot_temp.Rows(i).Item("PdName"), vFrm.Lot_temp.Rows(i).Item("Amount"), vFrm.Lot_temp.Rows(i).Item("Amount"), vFrm.Lot_temp.Rows(i).Item("idPd"))
                    Next
                    DGV_Lot.Sort(DGV_Lot.Columns("ColPdName"), System.ComponentModel.ListSortDirection.Ascending)

                    ksbCountRowDgv(DGV_Lot, ColNum.Name)
                    mdLoadShow()
                    SumWOfLot()
                    CalWeight()
                    ' CalPackage()
                    Me.btnCalPk.Visible = True
                    mdLoadCommitt()
                    'DataGridView1.Sort(DataGridView1.Columns(1), ListSortDirection.Ascending)

                End If
            End If
        End If
    End Sub

    Private Sub btnPsCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPsCommand.Click
        Dim vFrm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPsCommand.Tag = vFrm.mId
            Me.lblPsCommand.Text = vFrm.mName
        End If
    End Sub

    Private Sub btnPsPacking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPsPacking.Click
        Dim vFrm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPsPacking.Tag = vFrm.mId
            Me.lblPsPacking.Text = vFrm.mName
        End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If Me.lblPsCommand.Text = "" Then
            MessageBox.Show("กรุณาระบุผู้สั่ง Packing", sSystemName)
            Me.TabControl1.SelectedIndex = 0
            Exit Sub
        ElseIf Me.lblPsPacking.Text = "" Then
            MessageBox.Show("กรุณาระบุผู้ดำเนินการ", sSystemName)
            Me.TabControl1.SelectedIndex = 0
            Exit Sub
        ElseIf Me.dgvResult.Rows.Count = 0 Then
            MessageBox.Show("ต้องมีรายการ Package ที่ระบบคำนวณได้อย่างน้อย 1 รายการ จึงจะสามารถบันทึกได้", sSystemName)
            Me.TabControl1.SelectedIndex = 3
            Exit Sub
        Else
            For i As Integer = 0 To DGV_Lot.Rows.Count - 1
                If DGV_Lot.Rows(i).Cells("ColuRealUse").Value = 0 Then
                    MessageBox.Show("มี Lot สินค้าวัตถุดิบที่ไม่ได้เบิกใช้ในตารางวัตถุดิบ กรุณาลบ Lot สินค้าดังกล่าวก่อนทำการบันทึกรายการอีกครั้ง", sSystemName)
                    Me.TabControl1.SelectedIndex = 2
                    Exit Sub
                End If
            Next

            For i As Integer = 0 To dgvResult.Rows.Count - 1
                If dgvResult.Rows(i).Cells("ColAmt").Value = 0 Then
                    MessageBox.Show("มีรายการ Package ที่ระบบคำนวณจำนวนที่ได้เท่ากับ 0 กรุณาตรวจสอบก่อนจะทำการบันทึกอีกครั้ง", sSystemName)
                    Me.TabControl1.SelectedIndex = 3
                    Exit Sub
                End If
            Next

            'Check stock of box
            For i As Integer = 0 To DGV_Box.Rows.Count - 1
                If DGV_Box.Rows(i).Cells("ColSelectBox").Value = True Then
                    If DGV_Box.Rows(i).Cells("ColAmtBox").Value > DGV_Box.Rows(i).Cells("ColStockBox").Value Then
                        MessageBox.Show("จำนวนกล่องใน Stock ไม่เพียงพอต่อความต้องการ จึงไม่สามารถผลิตสินค้าได้", sSystemName)
                        Me.TabControl1.SelectedIndex = 3
                        Exit Sub
                    End If
                End If
            Next

            'Check stock of sticker
            For i As Integer = 0 To DGV_Label.Rows.Count - 1
                If DGV_Label.Rows(i).Cells("ColSelectLb").Value = True Then
                    Dim lblTotalUse As Integer = dgvResult.Rows(0).Cells("ColAmt").Value + CInt(Me.txtAmtBoxLbl.Text)
                    If lblTotalUse > DGV_Label.Rows(i).Cells("ColAmtLb").Value Then
                        MessageBox.Show("จำนวนฉลากสินค้าใน Stock ไม่เพียงพอต่อความต้องการ (ฉลากสำหรับติดสินค้าและกล่องสินค้า) จึงไม่สามารถผลิตสินค้าได้", sSystemName)
                        Me.TabControl1.SelectedIndex = 3
                        Exit Sub
                    End If
                End If

            Next


            '----ADD Data to PkPackingMt-----'
            mdLoadShow()
            AddPkPackingMt()

            '***Select idPacking***'
            Dim idPacking As Integer = 0
            mdCnOpen()
            Dim sDt As New DataTable
            sDt.Clear()
            sCommand.CommandText = "Select Max(idpacking) as MaxidPacking From PkPackingMt"
            sAdapter.Fill(sDt)
            idPacking = sDt.Rows(0).Item("MaxidPacking")

            '----ADD Data to PkPackingDt-----'
            AddPkPackingDt(idPacking)

            '----ADD Data to PkPackingLotDt-----'
            AddPkPackingLotDt(idPacking)

           
            ''**** พิมพ์ใบ JobNo ****'
            ''************* for Main Report (Start) *************'
            'Dim PackingTsDt As New DataTable
            'PackingTsDt.Clear()
            'mdCnOpen()

            'sCommand.CommandText = "SELECT mt.idPacking, mt.JobNo, Pd.PdTradeName, fl.FlName, mt.DatePacking, " & _
            '               "mt.DateCombine, mt.Grad, mt.DateTest, Mt.DateExp, mt.TotalAmount, " & _
            '               "p2.PsName as PsCommand,  p3.PsName as PsPacking, p4.PsName as PsTs, " & _
            '               "mt.DateTs, mt.Note FROM PkPackingMt mt LEFT OUTER JOIN vSlPdTradeNameD Pd " & _
            '               "ON mt.idPdT = Pd.idPdT LEFT OUTER JOIN SlPdFormula fl " & _
            '               "ON mt.idFL = fl.idFL LEFT OUTER JOIN vPerson p2 ON mt.idPsCommand = p2.idPs " & _
            '               "LEFT OUTER JOIN vPerson p3 ON mt.idPsPacking = p3.idPs " & _
            '               "LEFT OUTER JOIN vPerson p4 ON mt.idPsTs = p4.idPs " & _
            '               "WHERE idPacking = '" & idPacking & "'"
            'sAdapter.Fill(PackingTsDt)
            'PackingTsDt.Rows(0).Item("DatePacking") = ksbStringToDate(PackingTsDt.Rows(0).Item("DatePacking"))
            'PackingTsDt.Rows(0).Item("DateTs") = ksbStringToDate(PackingTsDt.Rows(0).Item("DateTs"))
            'PackingTsDt.Rows(0).Item("DateCombine") = ksbStringToDate(PackingTsDt.Rows(0).Item("DateCombine"))
            'PackingTsDt.Rows(0).Item("DateTest") = ksbStringToDate(PackingTsDt.Rows(0).Item("DateTest"))
            'PackingTsDt.Rows(0).Item("DateExp") = ksbStringToDate(PackingTsDt.Rows(0).Item("DateExp"))
            ''*************** for Main Report (End) *****************'

            ''*************** for Audit 1st Sub Report (Start) **********'
            'Dim SubRptLotUse As New DataTable
            'SubRptLotUse.Clear()

            'sCommand.CommandText = "SELECT l.idPacking, s.LotNum As LotNo, s.LotCodeRef, p.PdName, " & _
            '                       "f.MixPerc, l.Amount as AmountUse, l.Note FROM PkPackingLotDt l " & _
            '                       "LEFT OUTER JOIN PkPdLotStock s ON l.idPdMixLot = s.idPdLot " & _
            '                       "LEFT OUTER JOIN vSeedProduct p ON s.idPd = p.idPd " & _
            '                       "LEFT OUTER JOIN SlPdIngredient f ON s.idPd = f.idPd " & _
            '                       "WHERE idPacking = '" & idPacking & "' AND f.idFl = '" & idFl_Now & "'"
            'sAdapter.Fill(SubRptLotUse)
            'For i As Integer = 0 To SubRptLotUse.Rows.Count - 1
            '    'If IsDBNull(SubRptLotUse.Rows(i).Item("LotNum")) Then
            '    '    SubRptLotUse.Rows(i).Item("LotNo") = SubRptLotUse.Rows(i).Item("LotCodeRef")
            '    'Else
            '    '    SubRptLotUse.Rows(i).Item("LotNo") = SubRptLotUse.Rows(i).Item("LotNum")
            '    'End If

            '    SubRptLotUse.Rows(i).Item("PdName") = SubRptLotUse.Rows(i).Item("PdName") & " : อัตราส่วนผสม " & SubRptLotUse.Rows(i).Item("MixPerc") & " % "
            'Next
            ''************************* for Audit 1st Sub Report (End) *************************'

            'Dim stHide As Integer = 0
            ''*************** for Audit 2nd Sub Report (Start) **********'
            'Dim SubRptPackage As New DataTable
            'SubRptPackage.Clear()

            'sCommand.CommandText = "SELECT dt.idPacking, dt.idPkDetail, dPD.SizeName, p.Weight, p.UnitW, " & _
            '                       "dt.AmtSuccess as Amount, p.PkUnitName, dPD.idPkUnit " & _
            '                       "FROM PkPackingDt dt LEFT OUTER JOIN dPackingDetail dPD " & _
            '                       "ON dt.idPkDetail = dPD.idPkDetail LEFT OUTER JOIN vPackingPdSet p " & _
            '                       "ON dt.idPdPk = p.idPdPk Where dt.idPacking = '" & idPacking & "'"
            'sAdapter.Fill(SubRptPackage)

            'If SubRptPackage.Rows(0).Item("idPkUnit") <> 1 Then 'กระป๋อง
            '    stHide = 1 'Hide Lid
            'End If
            ''************************* for Audit 2nd Sub Report (End) *************************'

            ''*************** for Audit 3rd Sub Report (Start) **********'
            'Dim SubRptPdPk As New DataTable
            'SubRptPdPk.Clear()
            'sCommand.CommandText = "SELECT dt.idPacking, dt.idPdPk, p.PdPkName, dt.AmtSuccess, p.PkUnitName " & _
            '                       "FROM PkPackingDt dt LEFT OUTER JOIN vPackingPdSet p ON dt.idPdPk = p.idPdPk " & _
            '                       "WHERE idPacking = '" & idPacking & "'"
            'sAdapter.Fill(SubRptPdPk)
            ''************************* for Audit 3rd Sub Report (End) *************************'

            ''*************** for Audit 4th Sub Report (Start) **********'
            'Dim SubRptLabel As New DataTable
            'SubRptLabel.Clear()
            'sCommand.CommandText = "SELECT dt.idPacking, dt.idLabel, l.LabelNameUse, dt.AmtSuccess, 'ชิ้น' As LbUnit, " & _
            '                       "dt.AmtBoxLabel FROM PkPackingDt dt LEFT OUTER JOIN dPackingLabel l ON " & _
            '                       "dt.idLabel = l.idLabel WHERE idPacking = '" & idPacking & "'"
            'sAdapter.Fill(SubRptLabel)
            ''************************* for Audit 3rd Sub Report (End) *************************'

            ''*************** for Audit 5th Sub Report (Start) **********'
            'Dim SubRptPkLid As New DataTable
            'SubRptPkLid.Clear()
            'sCommand.CommandText = "SELECT dt.idPacking, dt.idPkDetail, dPD.SizeName, dt.AmtSuccess AS Amount, u.PkUnitName " & _
            '                       "FROM PkPackingDt AS dt LEFT OUTER JOIN dPackingDetail AS dPD " & _
            '                       "ON dt.idLid = dPD.idPkDetail LEFT OUTER JOIN vPackingPdSet AS p " & _
            '                       "ON dt.idPdPk = p.idPdPk LEFT OUTER JOIN dPackingUnit AS u " & _
            '                       "ON dPD.idPkUnit = u.idPkUnit WHERE dt.idPacking = '" & idPacking & "'"
            'sAdapter.Fill(SubRptPkLid)
            ''************************* for Audit 3rd Sub Report (End) *************************'

            ''*************** for Audit 6th Sub Report (Start) **********'
            'Dim SubRptBox As New DataTable
            'SubRptBox.Clear()
            'sCommand.CommandText = "SELECT dt.idPacking, dt.idPkDetail As idBox, dPD.SizeName, dt.AmtBox, u.PkUnitName " & _
            '                       "FROM PkPackingDt AS dt LEFT OUTER JOIN dPackingDetail AS dPD " & _
            '                       "ON dt.idBox = dPD.idPkDetail LEFT OUTER JOIN vPackingPdSet AS p " & _
            '                       "ON dt.idPdPk = p.idPdPk LEFT OUTER JOIN dPackingUnit AS u " & _
            '                       "ON dPD.idPkUnit = u.idPkUnit WHERE dt.idPacking = '" & idPacking & "'"
            'sAdapter.Fill(SubRptBox)
            ''************************* for Audit 6th Sub Report (End) *************************'

            'Dim vFrm As New FrmReportView
            'Dim vRpt As New crpPackingDoc

            ''** for Main Report **'
            'vRpt.SetDataSource(PackingTsDt)

            ''** for Audit 1st Sub Report **'
            'vRpt.Subreports("SubRpt_LotStockUse").SetDataSource(SubRptLotUse)

            ''** for Audit 2nd Sub Report **'
            'vRpt.Subreports("SubRpt_Package").SetDataSource(SubRptPackage)

            ''** for Audit 3rd Sub Report **'
            'vRpt.Subreports("SubRpt_PdPk").SetDataSource(SubRptPdPk)

            ''** for Audit 4th Sub Report **'
            'vRpt.Subreports("SubRpt_Label").SetDataSource(SubRptLabel)

            ''** for Audit 5th Sub Report **'
            'vRpt.Subreports("SubRpt_PkLid").SetDataSource(SubRptPkLid)

            ''** for Audit 6th Sub Report **'
            'vRpt.Subreports("SubRpt_Box").SetDataSource(SubRptBox)

            'vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, sPsName)
            'vRpt.SetParameterValue(vRpt.Parameter_SubRpt_PkLid_stHide.ParameterFieldName, stHide)
            'vFrm.crView.ReportSource = vRpt
            'vFrm.crView.EnableDrillDown = False
            'vFrm.Show()

            mdLoadCommitt()
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    '-------------------- GEN JobNo --------------------'
    Function getJobNo(ByVal Prefixcode As String) As String
        Dim JobNo As String = ""
        Dim nextOrder As String = ""
        Dim CodeYear As String = ""

        mdCnOpen()
        Dim sDt As New DataTable
        sDs.Tables.Clear()
        sCommand.CommandText = "SELECT MAX(JobNo) as max_JobNo FROM PkPackingMt"
        sAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_JobNo")) = True Then
            JobNo = "PK" & Prefixcode & "/" & "00001"
        Else
            'Dim max_JobNo As String = sDt.Rows(0).Item("max_JobNo")
            Dim yearDoc As String = sDt.Rows(0).Item("max_JobNo").ToString.Substring(2, 2)
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_JobNo"), 5)

            If Prefixcode <> yearDoc Then
                JobNo = "PK" & Prefixcode & "/" & "00001"
            Else
                Dim temp As Integer
                temp = CInt(RunningCode) + 1
                If temp < 10 Then
                    nextOrder = "0000" & CStr(temp)
                ElseIf temp < 100 Then
                    nextOrder = "000" & CStr(temp)
                ElseIf temp < 1000 Then
                    nextOrder = "00" & CStr(temp)
                ElseIf temp < 10000 Then
                    nextOrder = "0" & CStr(temp)
                Else
                    nextOrder = CStr(temp)
                End If
                JobNo = "PK" & Prefixcode & "/" & nextOrder
            End If
        End If
        Return JobNo
    End Function


    Sub AddPkPackingMt()
        mdCnOpen()
        '---insert SmSaleMt Table---'
        Dim JobNo As String = ""
        Dim getDate As String = CType(Date.Today, String)
        Dim Prefixcode As String = ""
        Dim vGrad As String = ""
        If Me.rdbA.Checked = True Then
            vGrad = "A"
        ElseIf Me.rdbB.Checked = True Then
            vGrad = "B"
        End If

        Prefixcode = (Microsoft.VisualBasic.Right(getDate, 2))
        JobNo = getJobNo(Prefixcode)
        sCommand.CommandText = "Insert Into PkPackingMt(JobNo, idPdT, idFl, DatePacking, DateCombine, Grad, " & _
                               "DateTest, DateExp , TotalAmount, idPsCommand, " & _
                               "idPsPacking, idPsTs, DateTs, Note ) " & _
                               "Values('" & JobNo & "', '" & Me.lblPdTName.Tag & "', '" & idFl_Now & "', " & _
                               "'" & ksbDateToString(dtpDatePacking.Value.ToShortDateString) & "', " & _
                               "'" & ksbDateToString(dtpCombine.Value.ToShortDateString) & "', '" & vGrad & "', " & _
                               "'" & ksbDateToString(dtpTest.Value.ToShortDateString) & "', " & _
                               "'" & ksbDateToString(dtpExp.Value.ToShortDateString) & "', " & _
                               "" & CDbl(Me.txtAmtTotal.Text) & ", '" & Me.lblPsCommand.Tag & "', " & _
                               "'" & Me.lblPsPacking.Tag & "', '" & Me.lblPsTs.Tag & "', " & _
                               "'" & ksbDateToString(lblDateTs.Text) & "', '" & Me.txtNote.Text & "')"
        sCommand.ExecuteNonQuery()
    End Sub

    Sub AddPkPackingDt(ByVal idPacking As Integer)
        Dim idBox As Integer = 0
        Dim AmtBox As Integer = 0

        For i As Integer = 0 To DGV_Box.Rows.Count - 1
            If DGV_Box.Rows(i).Cells("ColSelectBox").Value = True Then
                idBox = DGV_Box.Rows(i).Cells("ColidPkDetailBox").Value
                AmtBox = DGV_Box.Rows(i).Cells("ColAmtBox").Value
            End If
        Next

        '---insert PkPackingDt Table---'
        mdCnOpen()
        For i As Integer = 0 To dgvResult.Rows.Count - 1
            sCommand.CommandText = "Insert Into PkPackingDt(idPacking, idPkDetail, idLabel, idPdPk, idLid, AmtDemand, AmtSuccess, " & _
                                   "idBox, AmtBox, AmtBoxLabel) " & _
                                   "Values('" & idPacking & "', '" & dgvResult.Rows(i).Cells("ColidPkDetail_R").Value & "', " & _
                                   "'" & dgvResult.Rows(i).Cells("ColidLabel_R").Value & "', " & _
                                   "'" & dgvResult.Rows(i).Cells("ColidPdPk").Value & "', '" & dgvResult.Rows(i).Cells("ColidPkDtOp_R").Value & "' " & _
                                   ",'" & dgvResult.Rows(i).Cells("ColAmtDmd").Value & "', '" & dgvResult.Rows(i).Cells("ColAmt").Value & "', " & _
                                   "" & idBox & ", " & AmtBox & ", " & CInt(Me.txtAmtBoxLbl.Text) & ")"
            sCommand.ExecuteNonQuery()

            '******** Open if use **********'
            '---update Stock PkDetail---'
            Dim sDt As New DataTable
            Dim NewPkAmt As Integer = 0
            sCommand.CommandText = "Select Amount, idPkUnit From dPackingDetail Where idPkDetail = '" & dgvResult.Rows(i).Cells("ColidPkDetail_R").Value & "'"
            sAdapter.Fill(sDt)

            NewPkAmt = sDt.Rows(0).Item("Amount") - dgvResult.Rows(i).Cells("ColAmt").Value

            sCommand.CommandText = "Update dPackingDetail Set Amount = " & NewPkAmt & ", " & _
                                   "idPsUpdate = '" & sPsId & "', DateUpdate = '" & ksbDateToString(Date.Today) & "' " & _
                                   "Where idPkDetail='" & dgvResult.Rows(i).Cells("ColidPkDetail_R").Value & "'"
            sCommand.ExecuteNonQuery()

            If sDt.Rows(0).Item("idPkUnit") = 1 Then 'กระป๋อง ----> เบิกฝาเพิ่ม
                '---update Stock PkDetail (Lid)---'
                Dim sDt3 As New DataTable
                Dim NewLidAmt As Integer = 0
                sCommand.CommandText = "Select Amount From dPackingDetail Where idPkDetail = '" & dgvResult.Rows(i).Cells("ColidPkDtOp_R").Value & "'"
                sAdapter.Fill(sDt3)

                NewLidAmt = sDt3.Rows(0).Item("Amount") - dgvResult.Rows(i).Cells("ColAmt").Value

                sCommand.CommandText = "Update dPackingDetail Set Amount = " & NewLidAmt & ", " & _
                                       "idPsUpdate = '" & sPsId & "', DateUpdate = '" & ksbDateToString(Date.Today) & "' " & _
                                       "Where idPkDetail='" & dgvResult.Rows(i).Cells("ColidPkDtOp_R").Value & "'"
                sCommand.ExecuteNonQuery()
            End If

            '---update Stock Label (LabelPk + LabelBox)---'
            Dim sDt2 As New DataTable
            Dim NewLbAmt As Integer = 0
            sCommand.CommandText = "Select Amount From dPackingLabel Where idLabel = '" & dgvResult.Rows(i).Cells("ColidLabel_R").Value & "'"
            sAdapter.Fill(sDt2)

            NewLbAmt = sDt2.Rows(0).Item("Amount") - (dgvResult.Rows(i).Cells("ColAmt").Value + CInt(txtAmtBoxLbl.Text))

            sCommand.CommandText = "Update dPackingLabel Set Amount = " & NewLbAmt & ", " & _
                                   "idPsUpdate = '" & sPsId & "', DateUpdate = '" & ksbDateToString(Date.Today) & "' " & _
                                   "Where idLabel = '" & dgvResult.Rows(i).Cells("ColidLabel_R").Value & "'"
            sCommand.ExecuteNonQuery()


            '---update Stock Box ------'
            Dim sDt4 As New DataTable
            Dim NewBoxAmt As Integer = 0
            sCommand.CommandText = "Select Amount From dPackingDetail Where idPkDetail = '" & idBox & "'"
            sAdapter.Fill(sDt4)

            NewBoxAmt = sDt4.Rows(0).Item("Amount") - AmtBox

            sCommand.CommandText = "Update dPackingDetail Set Amount = " & NewBoxAmt & ", " & _
                                   "idPsUpdate = '" & sPsId & "', DateUpdate = '" & ksbDateToString(Date.Today) & "' " & _
                                   "Where idPkDetail='" & idBox & "'"
            sCommand.ExecuteNonQuery()

        Next

    End Sub

    Sub AddPkPackingLotDt(ByVal idPacking As Integer)
        '---insert PkPackingLotDt Table---'
        mdCnOpen()
        For i As Integer = 0 To DGV_Lot.Rows.Count - 1
            sCommand.CommandText = "Insert Into  PkPackingLotDt(idPacking, idPdMixLot, Amount) " & _
                                   "Values('" & idPacking & "', '" & DGV_Lot.Rows(i).Cells("ColidPdLot").Value & "', " & _
                                   "'" & DGV_Lot.Rows(i).Cells("ColuRealUse").Value & "')"
            sCommand.ExecuteNonQuery()

            '******** Open if use **********'
            '---- Fucntion update Stock ----'
            'mdPdMixStockUpdate(2, DGV_Lot.Rows(i).Cells("ColidPdLot").Value, DGV_Lot.Rows(i).Cells("ColuRealUse").Value, "Packing: Packing สินค้าสำเร็จรูป ", idPacking)
        Next

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Result = MsgBox("คุณต้องการยกเลิกรายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
        If Result = Windows.Forms.DialogResult.Yes Then
            Dim CancelNote As String = " "
            CancelNote = InputBox("ระบุสาเหตุการยกเลิก", sSystemName)
            If CancelNote.Length = 0 Then
                MessageBox.Show("กรุณาระบุสาเหตุการยกเลิก", sSystemName)
                Exit Sub
            Else
                mdCnOpen()
                '----- Upadte PkPackingMt ----'
                sCommand.CommandText = "Update PkPackingMt Set idPsCancel='" & sPsId & "', " & _
                                       "CancelNote='" & CancelNote & "' Where idPacking ='" & idPacking_sent & "'"
                sCommand.ExecuteNonQuery()


                '---- Slect LotUse ---'
                Dim LotDelDt As New DataTable
                LotDelDt.Clear()
                sCommand.CommandText = "Select idPdMixLot, Amount From PkPackingLotDt " & _
                                       "WHERE idPacking = '" & idPacking_sent & "'"
                sAdapter.Fill(LotDelDt)

                '******** Open if use **********'
                ' ---return stock----'
                For i As Integer = 0 To LotDelDt.Rows.Count - 1
                    '---- Fucntion update Stock ----'
                    'mdPdMixStockUpdate(1, LotDelDt.Rows(i).Item("idPdMixLot"), LotDelDt.Rows(i).Item("Amount"), "Packing: ยกเลิกรายการ Packing สินค้าสำเร็จรูป ", idPacking_sent)
                Next

                'If stConfirm = 1 Then 'รายการ comfirm แล้ว ต้องคืนสินค้าสำเร็จรูป
                '    For i As Integer = 0 To dgvResult.Rows.Count - 1
                '        mdPdPkStockUpdate(2, dgvResult.Rows(i).Cells("ColidPdPk").Value, CInt(dgvResult.Rows(i).Cells("ColAmt").Value), "Packing: ยกเลิกรายการ Packing สินค้าสำเร็จรูป", idPacking_sent)
                '    Next
                'End If


                For i As Integer = 0 To dgvResult.Rows.Count - 1
                    '---update Stock PkDetail : return stock ---'
                    Dim sDt As New DataTable
                    Dim NewPkAmt As Integer = 0
                    sCommand.CommandText = "Select Amount, idPkUnit From dPackingDetail Where idPkDetail = '" & dgvResult.Rows(i).Cells("ColidPkDetail_R").Value & "'"
                    sAdapter.Fill(sDt)

                    NewPkAmt = sDt.Rows(0).Item("Amount") + dgvResult.Rows(i).Cells("ColAmt").Value + CInt(Me.txtAddPk.Text)

                    sCommand.CommandText = "Update dPackingDetail Set Amount = " & NewPkAmt & ", " & _
                                           "idPsUpdate = '" & sPsId & "', DateUpdate = '" & ksbDateToString(Date.Today) & "' " & _
                                           "Where idPkDetail='" & dgvResult.Rows(i).Cells("ColidPkDetail_R").Value & "'"
                    sCommand.ExecuteNonQuery()

                    If sDt.Rows(0).Item("idPkUnit") = 1 Then 'กระป๋อง ----> คืนฝากระป๋อง
                        '---update Stock PkDetail : return stock (ฝากระป๋อง)---'
                        Dim sDt3 As New DataTable
                        Dim NewPkOpAmt As Integer = 0
                        sCommand.CommandText = "Select Amount From dPackingDetail Where idPkDetail = '" & dgvResult.Rows(i).Cells("ColidPkDtOp_R").Value & "'"
                        sAdapter.Fill(sDt3)

                        NewPkOpAmt = sDt3.Rows(0).Item("Amount") + dgvResult.Rows(i).Cells("ColAmt").Value + CInt(Me.txtAddPkOp.Text)

                        sCommand.CommandText = "Update dPackingDetail Set Amount = " & NewPkOpAmt & ", " & _
                                               "idPsUpdate = '" & sPsId & "', DateUpdate = '" & ksbDateToString(Date.Today) & "' " & _
                                               "Where idPkDetail='" & dgvResult.Rows(i).Cells("ColidPkDtOp_R").Value & "'"
                        sCommand.ExecuteNonQuery()
                    End If


                    '---update Stock Label---'
                    Dim sDt2 As New DataTable
                    Dim NewLbAmt As Integer = 0
                    sCommand.CommandText = "Select Amount From dPackingLabel Where idLabel = '" & dgvResult.Rows(i).Cells("ColidLabel_R").Value & "'"
                    sAdapter.Fill(sDt2)

                    NewLbAmt = sDt2.Rows(0).Item("Amount") + dgvResult.Rows(i).Cells("ColAmt").Value + CInt(Me.txtAddlabel.Text) + CInt(txtAmtBoxLbl.Text)

                    sCommand.CommandText = "Update dPackingLabel Set Amount = " & NewLbAmt & ", " & _
                                           "idPsUpdate = '" & sPsId & "', DateUpdate = '" & ksbDateToString(Date.Today) & "' " & _
                                           "Where idLabel = '" & dgvResult.Rows(i).Cells("ColidLabel_R").Value & "'"
                    sCommand.ExecuteNonQuery()



                    '---update Stock PkDetail : return stock (กล่อง) ---'
                    Dim sDt4 As New DataTable
                    Dim NewBoxAmt As Integer = 0
                    sCommand.CommandText = "Select Amount From dPackingDetail Where idPkDetail = '" & DGV_Box.Rows(0).Cells("ColidPkDetailBox").Value & "'"
                    sAdapter.Fill(sDt4)

                    NewBoxAmt = sDt4.Rows(0).Item("Amount") + CInt(DGV_Box.Rows(0).Cells("ColAmtBox").Value)

                    sCommand.CommandText = "Update dPackingDetail Set Amount = " & NewBoxAmt & ", " & _
                                           "idPsUpdate = '" & sPsId & "', DateUpdate = '" & ksbDateToString(Date.Today) & "' " & _
                                           "Where idPkDetail='" & DGV_Box.Rows(0).Cells("ColidPkDetailBox").Value & "'"
                    sCommand.ExecuteNonQuery()
                Next

                MessageBox.Show("ยกเลิกรายการเรียบร้อยแล้ว", sSystemName)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End If

    End Sub

    Private Sub DGV_Lot_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Lot.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        '----Delete---'
        If DGV_Lot.Columns(e.ColumnIndex).Name = Me.ColDel.Name Then
            Result = MsgBox("คุณต้องการลบ Lot สินค้าวัตถุดิบนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
            If Result = Windows.Forms.DialogResult.Yes Then
                DGV_Lot.Rows.Remove(DGV_Lot.CurrentRow)
                ksbCountRowDgv(DGV_Lot, ColNum.Name)
                mdLoadShow()
                SumWOfLot()
                CalWeight()
                CalPackage()
                If DGV_Lot.Rows.Count = 0 Then
                    Me.btnCalPk.Visible = False
                End If
                mdLoadCommitt()
            End If
        End If
    End Sub

    Private Sub DGV_Lot_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Lot.CellEndEdit
        If DGV_Lot.Columns(e.ColumnIndex).Name = Me.ColuRealUse.Name Then
            If CDbl(Me.DGV_Lot.Rows(e.RowIndex).Cells(ColuRealUse.Name).Value) > CDbl(Me.DGV_Lot.Rows(e.RowIndex).Cells(ColLotAmount.Name).Value) Then
                mdLoadCommitt()
                MessageBox.Show("น้ำหนักที่เบิกมากกว่าน้ำหนักคงเหลือใน Stock กรุณากรอกใหม่อีกครั้ง", sSystemName)
                Exit Sub
            Else
                mdLoadShow()
                SumWOfLot()
                'CalWeight()
                'CalPackage()
                mdLoadCommitt()

            End If
        End If
    End Sub

    Private Sub btnLot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLot.Click
        mdLoadShow()
        Me.DGV_Lot.Rows.Clear()
        CalPackageAuto()
        SumWOfLot()
        mdLoadCommitt()
    End Sub

    Private Sub rdbAutoSelect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAutoSelect.CheckedChanged
        If stIntr = 1 Then
            If Me.rdbAutoSelect.Checked = True Then
                Me.DGV_Lot.Rows.Clear()
                Me.dgvResult.Rows.Clear()
                Me.txtAmtBoxLbl.Text = "0"
                For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
                    Me.DGV_Box.Rows(i).Cells("ColAmtBox").Value = 0
                Next
                Me.DGV_Box.Enabled = False
                Me.txtAmtBoxLbl.Enabled = False

                Me.btnLot.Visible = True
                Me.btnCalPk.Visible = False
                DGV_Ingredient.Columns("ColSelectLot").Visible = False
                DGV_Lot.Columns("ColDel").Visible = False
                Me.DGV_Lot.ReadOnly = True
            End If
        Else
            If Me.rdbAutoSelect.Checked = True Then
                Me.btnLot.Visible = True
            End If
        End If

    End Sub

    Private Sub rdbSelect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSelect.CheckedChanged
        If stIntr = 1 Then
            If Me.rdbSelect.Checked = True Then
                Me.DGV_Lot.Rows.Clear()
                Me.dgvResult.Rows.Clear()
                Me.txtAmtBoxLbl.Text = "0"
                For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
                    Me.DGV_Box.Rows(i).Cells("ColAmtBox").Value = 0
                Next
                Me.DGV_Box.Enabled = False
                Me.txtAmtBoxLbl.Enabled = False

                Me.btnLot.Visible = False
                If Me.DGV_Lot.Rows.Count = 0 Then
                    Me.btnCalPk.Visible = False
                Else
                    Me.btnCalPk.Visible = True
                End If

                DGV_Ingredient.Columns("ColSelectLot").Visible = True
                DGV_Lot.Columns("ColDel").Visible = True
                Me.DGV_Lot.ReadOnly = False
            End If
        Else
            If Me.rdbSelect.Checked = True Then
                Me.btnLot.Visible = False
            End If
        End If
    End Sub

    Private Sub btnCalPk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalPk.Click
        mdLoadShow()
        CalPackage()
        mdLoadCommitt()
    End Sub

    Private Sub rdbOnlyPk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbOnlyPk.CheckedChanged
        '---Show Label List---'

        For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
            If Me.dgvPkPdSet.Rows(i).Cells(colSelect.Name).Value = True Then
                Dim LbDt As New DataTable
                LbDt.Clear()
                If Me.rdbOnlyPk.Checked = True Then
                    sCommand.CommandText = "SELECT p.idLabel, l.LabelNameUse, CONVERT(varchar, l.SizeW) + ' x ' + " & _
                                           "CONVERT(varchar, l.SizeH) + ' ' + l.Unit As WH, ISNull(l.Amount,0) As Amount " & _
                                           "FROM PkStickLabelSet AS p " & _
                                           "LEFT OUTER JOIN dPackingLabel AS l ON p.idLabel = l.idLabel " & _
                                           "WHERE p.idPdPk = '" & dgvPkPdSet.Rows(i).Cells(idPdPk.Name).Value & "'"
                ElseIf Me.rdbAllPk.Checked = True Then
                    sCommand.CommandText = "SELECT idLabel, LabelNameUse, CONVERT(varchar, SizeW) + ' x ' + " & _
                                            "CONVERT(varchar, SizeH) + ' ' + Unit As WH, ISNull(Amount,0) As Amount " & _
                                           "FROM dPackingLabel WHERE stUser = 0 "
                End If
                sAdapter.Fill(LbDt)

                If LbDt.Rows.Count <> 0 Then
                    Me.DGV_Label.DataSource = LbDt
                    Me.lblNoLabel.Visible = False

                    If Me.rdbOnlyPk.Checked = True Then
                        'DGV_Label.Columns("ColSelectLb").Visible = False
                        DGV_Label.Rows(0).DefaultCellStyle.ForeColor = Color.DodgerBlue
                        DGV_Label.Rows(0).Cells(ColSelectLb.Name).Value = True
                        DGV_Label.Rows(0).Cells(ColSelectLb.Name).ReadOnly = True

                        'Show Label To BoxLabel
                        Me.lblBoxLabel.Text = DGV_Label.Rows(0).Cells(ColLabelName.Name).Value & _
                                              " (" & DGV_Label.Rows(0).Cells(ColWH.Name).Value & ")"
                        Me.lblBoxLabel.Tag = DGV_Label.Rows(0).Cells(ColidLabel.Name).Value
                    End If
                Else
                    Me.DGV_Label.DataSource = LbDt
                    Me.lblNoLabel.Visible = True
                End If

            End If
        Next

        '---Check select  case Label All---'
        Dim ChkStLb As Integer = 0
        If Me.rdbAllPk.Checked = True Then
            For i As Integer = 0 To Me.DGV_Label.Rows.Count - 1
                If DGV_Label.Rows(i).Cells(ColSelectLb.Name).Value = True Then
                    ChkStLb = 1
                    Exit For ' End Process
                End If
            Next

            If ChkStLb = 0 Then
                Me.DGV_formula.Enabled = False
                Me.dgvResult.Rows.Clear()
                Me.txtAmtBoxLbl.Text = "0"
                For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
                    Me.DGV_Box.Rows(i).Cells("ColAmtBox").Value = 0
                Next

                Me.DGV_Lot.Rows.Clear()

                Dim aDt As New DataTable
                sCommand.CommandText = "Select Sl.idPd, p.PdCode + ' : ' + p.PdName As PdCodeName, Sl.MixPerc, '0' as StockAmt, " & _
                                       " '0' As DemandW, '0' As SelectLotW, '0' As WUse " & _
                                       "From SlPdIngredient Sl INNER JOIN vSeedProduct p ON Sl.idPd = p.idPd  " & _
                                       "Where Sl.idPdT =''" & _
                                       "And Sl.idFl =''"
                sAdapter.Fill(aDt)
                Me.DGV_Ingredient.DataSource = aDt
            Else
                Me.DGV_formula.Enabled = True
            End If

            For i As Integer = 0 To Me.DGV_formula.Rows.Count - 1
                DGV_formula.Rows(i).Cells(ColSelectFl.Name).Value = False
                DGV_formula.Rows(i).Cells(ColFlag.Name).Value = 0
            Next
        Else
            Me.DGV_formula.Enabled = True
        End If

    End Sub

    Private Sub rdbAllPk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAllPk.CheckedChanged
        '---Show Label List---'
        For i As Integer = 0 To Me.dgvPkPdSet.Rows.Count - 1
            If Me.dgvPkPdSet.Rows(i).Cells(colSelect.Name).Value = True Then
                Dim LbDt As New DataTable
                LbDt.Clear()
                If Me.rdbOnlyPk.Checked = True Then
                    sCommand.CommandText = "SELECT p.idLabel, l.LabelNameUse, CONVERT(varchar, l.SizeW) + ' x ' + " & _
                                           "CONVERT(varchar, l.SizeH) + ' ' + l.Unit As WH, ISNull(l.Amount,0) As Amount " & _
                                           "FROM PkStickLabelSet AS p " & _
                                           "LEFT OUTER JOIN dPackingLabel AS l ON p.idLabel = l.idLabel " & _
                                           "WHERE p.idPdPk = '" & dgvPkPdSet.Rows(i).Cells(idPdPk.Name).Value & "'"
                ElseIf Me.rdbAllPk.Checked = True Then
                    sCommand.CommandText = "SELECT idLabel, LabelNameUse, CONVERT(varchar, SizeW) + ' x ' + " & _
                                            "CONVERT(varchar, SizeH) + ' ' + Unit As WH, ISNull(Amount,0) As Amount " & _
                                           "FROM dPackingLabel WHERE stUser = 0 "
                End If
                sAdapter.Fill(LbDt)

                If LbDt.Rows.Count <> 0 Then
                    Me.DGV_Label.DataSource = LbDt
                    Me.lblNoLabel.Visible = False
                    If Me.rdbOnlyPk.Checked = True Then
                        DGV_Label.Rows(0).DefaultCellStyle.ForeColor = Color.DodgerBlue
                        DGV_Label.Rows(0).Cells(ColSelectLb.Name).Value = True
                        DGV_Label.Rows(0).Cells(ColSelectLb.Name).ReadOnly = True
                    End If
                Else
                    Me.DGV_Label.DataSource = LbDt
                    Me.lblNoLabel.Visible = True
                End If
            End If
        Next

        '---Check select  case Label All---'
        Dim ChkStLb As Integer = 0
        If Me.rdbAllPk.Checked = True Then
            For i As Integer = 0 To Me.DGV_Label.Rows.Count - 1
                If DGV_Label.Rows(i).Cells(ColSelectLb.Name).Value = True Then
                    ChkStLb = 1
                    Exit For ' End Process
                End If
            Next

            If ChkStLb = 0 Then
                Me.DGV_formula.Enabled = False
                Me.dgvResult.Rows.Clear()
                Me.txtAmtBoxLbl.Text = "0"
                For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
                    Me.DGV_Box.Rows(i).Cells("ColAmtBox").Value = 0
                Next

                Me.DGV_Lot.Rows.Clear()

                Dim aDt As New DataTable
                sCommand.CommandText = "Select Sl.idPd, p.PdCode + ' : ' + p.PdName As PdCodeName, Sl.MixPerc, '0' as StockAmt, " & _
                                       " '0' As DemandW, '0' As SelectLotW, '0' As WUse " & _
                                       "From SlPdIngredient Sl INNER JOIN vSeedProduct p ON Sl.idPd = p.idPd  " & _
                                       "Where Sl.idPdT =''" & _
                                       "And Sl.idFl =''"
                sAdapter.Fill(aDt)
                Me.DGV_Ingredient.DataSource = aDt
            Else
                Me.DGV_formula.Enabled = True
            End If

            For i As Integer = 0 To Me.DGV_formula.Rows.Count - 1
                DGV_formula.Rows(i).Cells(ColSelectFl.Name).Value = False
                DGV_formula.Rows(i).Cells(ColFlag.Name).Value = 0
            Next
        Else
            Me.DGV_formula.Enabled = True
        End If
    End Sub

    Private Sub DGV_Label_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Label.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        '--------Checkbox----'
        If DGV_Label.Columns(e.ColumnIndex).Name = ColSelectLb.Name Then
            DGV_Label.Rows(e.RowIndex).Cells(ColKeyLb.Name).Value = 1
            DGV_Label.Rows(e.RowIndex).Cells(ColSelectLb.Name).Value = True
            'DGV_Label.Rows(e.RowIndex).Cells(ColAmtLabel.Name).Value = AmtLabel



            Dim ChkStLb As Integer = 0
            For i As Integer = 0 To Me.DGV_Label.Rows.Count - 1
                If i <> e.RowIndex Then
                    DGV_Label.Rows(i).Cells(ColKeyLb.Name).Value = 0
                    DGV_Label.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                    DGV_Label.Rows(i).Cells(ColSelectLb.Name).Value = False
                Else
                    DGV_Label.Rows(i).DefaultCellStyle.ForeColor = Color.DodgerBlue
                End If

                'If DGV_Label.Rows(i).Cells(ColSelectLb.Name).Value = True Then
                '    ChkStLb = 1
                'End If
            Next

            'Show Label To BoxLabel
            Me.lblBoxLabel.Text = DGV_Label.Rows(e.RowIndex).Cells(ColLabelName.Name).Value & _
                                  " (" & DGV_Label.Rows(e.RowIndex).Cells(ColWH.Name).Value & ")"
            Me.lblBoxLabel.Tag = DGV_Label.Rows(e.RowIndex).Cells(ColidLabel.Name).Value

            '---Check Status Checkbox---'
            'Dim ChkStLb As Integer = 0
            'For i As Integer = 0 To Me.DGV_Label.Rows.Count - 1
            '    If DGV_Label.Rows(i).Cells(ColSelectLb.Name).Value = True Then
            '        ChkStLb = 1
            '        Exit For ' End Process
            '    End If
            'Next

            'If ChkStLb = 0 Then
            '    Me.DGV_formula.Enabled = False
            '    Me.dgvResult.Rows.Clear()
            '    Me.DGV_Lot.Rows.Clear()

            '    Dim aDt As New DataTable
            '    sCommand.CommandText = "Select Sl.idPd, p.PdCode + ' : ' + p.PdName As PdCodeName, Sl.MixPerc, '0' as StockAmt, " & _
            '                           " '0' As DemandW, '0' As SelectLotW, '0' As WUse " & _
            '                           "From SlPdIngredient Sl INNER JOIN vSeedProduct p ON Sl.idPd = p.idPd  " & _
            '                           "Where Sl.idPdT =''" & _
            '                           "And Sl.idFl =''"
            '    sAdapter.Fill(aDt)
            '    Me.DGV_Ingredient.DataSource = aDt
            'Else
            '    Me.DGV_formula.Enabled = True
            'End If

            Me.DGV_formula.Enabled = True
            For i As Integer = 0 To Me.DGV_formula.Rows.Count - 1
                DGV_formula.Rows(i).Cells(ColSelectFl.Name).Value = False
                DGV_formula.Rows(i).Cells(ColFlag.Name).Value = 0
            Next

        End If
    End Sub

    Private Sub DGV_Label_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Label.CellEndEdit
        If DGV_Label.Columns(e.ColumnIndex).Name = ColSelectLb.Name Then
            If DGV_Label.Rows(e.RowIndex).Cells(ColSelectLb.Name).Value = False And DGV_Label.Rows(e.RowIndex).Cells(ColKeyLb.Name).Value = 1 Then
                DGV_Label.Rows(e.RowIndex).Cells(ColSelectLb.Name).Value = True
            End If
        End If

        'If DGV_formula.Columns(e.ColumnIndex).Name = ColSelectFl.Name Then
        '    If DGV_formula.Rows(e.RowIndex).Cells(ColSelectFl.Name).Value = False And DGV_formula.Rows(e.RowIndex).Cells(ColFlag.Name).Value = 1 Then
        '        DGV_formula.Rows(e.RowIndex).Cells(ColSelectFl.Name).Value = True
        '    End If
        'End If
    End Sub

    Private Sub txtAddPk_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddPk.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub


    Private Sub txtAddlabel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddlabel.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtAddPkOp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddPkOp.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub


    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Result = MsgBox("คุณต้องการยืนยันการ Packing สินค้ารายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
        If Result = Windows.Forms.DialogResult.Yes Then
            If txtAddPkOp.Enabled = True Then
                If (Me.txtAddPk.Text <> "0" Or Me.txtAddlabel.Text <> "0" Or Me.txtAddPkOp.Text <> "0" Or Me.txtAddBox.Text <> "0") And Trim(Me.txtNoteAdd.Text) = "" Then
                    MessageBox.Show("กรุณาระบุสาเหตุที่เบิกใช้วัสดุ Packing เพิ่มเติม", sSystemName)
                    Me.txtNoteAdd.Focus()
                    Exit Sub
                End If
            Else
                If (Me.txtAddPk.Text <> "0" Or Me.txtAddlabel.Text <> "0" Or Me.txtAddBox.Text <> "0") And Trim(Me.txtNoteAdd.Text) = "" Then
                    MessageBox.Show("กรุณาระบุสาเหตุที่เบิกใช้วัสดุ Packing เพิ่มเติม", sSystemName)
                    Me.txtNoteAdd.Focus()
                    Exit Sub
                End If
            End If

            '---Update PkPackingMt Table---'
            sCommand.CommandText = "Update PkPackingMt Set stConfirm = 1 WHERE idPacking = '" & idPacking_sent & "'"
            sCommand.ExecuteNonQuery()

            '*********** Open if use *************'
            '---Update vPackingPdSet : เพิ่ม Stock สินค้าสำเร็จรูป ---'
            For i As Integer = 0 To dgvResult.Rows.Count - 1
                ' mdPdPkStockUpdate(1, dgvResult.Rows(i).Cells("ColidPdPk").Value, CInt(dgvResult.Rows(i).Cells("ColAmt").Value), "Packing: Packing สินค้าสำเร็จรูป", idPacking_sent, "")
            Next


            '---Update PkPackingDt Table---'
            If (Me.txtAddPk.Text = "0" And Me.txtAddlabel.Text = "0" And Me.txtAddPkOp.Text = "0" And Me.txtAddBox.Text = "0") Then 'ไม่มีการเบิกเพิ่มทั้ง 4 วัสดุ
                sCommand.CommandText = "Update PkPackingDt Set  AmtPkIncrease = '" & Trim(Me.txtAddPk.Text) & "', " & _
                                       "AmtLbIncrease = '" & Trim(Me.txtAddlabel.Text) & "', " & _
                                       "AmtLidIncrease = '" & Trim(Me.txtAddPkOp.Text) & "', " & _
                                       "AmtBoxIncrease = '" & Trim(Me.txtAddBox.Text) & "', " & _
                                       "WHERE idPacking = '" & idPacking_sent & "'"
                sCommand.ExecuteNonQuery()
            Else 'มีการเบิกเพิ่ม
                Dim PkInc As String = ""
                Dim getDate As String = CType(Date.Today, String)
                Dim Prefixcode As String = ""

                Prefixcode = (Microsoft.VisualBasic.Right(getDate, 2))
                PkInc = getPkInc(Prefixcode)

                sCommand.CommandText = "Update PkPackingDt Set  AmtPkIncrease = '" & Trim(Me.txtAddPk.Text) & "', " & _
                                       "AmtLbIncrease = '" & Trim(Me.txtAddlabel.Text) & "', " & _
                                       "AmtLidIncrease = '" & Trim(Me.txtAddPkOp.Text) & "', " & _
                                       "AmtBoxIncrease = '" & Trim(Me.txtAddBox.Text) & "', " & _
                                       "NoteIncrease = '" & Me.txtNoteAdd.Text & "', " & _
                                       "DocCodeInc = '" & PkInc & "' WHERE idPacking = '" & idPacking_sent & "'"
                sCommand.ExecuteNonQuery()

                '******** Open if use **********'
                If Me.txtAddPk.Text <> "0" Then
                    '---update Stock PkDetail---'
                    Dim sDt As New DataTable
                    Dim NewPkAmt As Integer = 0
                    sCommand.CommandText = "Select Amount From dPackingDetail Where idPkDetail = '" & dgvResult.Rows(0).Cells("ColidPkDetail_R").Value & "'"
                    sAdapter.Fill(sDt)

                    NewPkAmt = sDt.Rows(0).Item("Amount") - CInt(Me.txtAddPk.Text)

                    sCommand.CommandText = "Update dPackingDetail Set Amount = " & NewPkAmt & ", " & _
                                           "idPsUpdate = '" & sPsId & "', DateUpdate = '" & ksbDateToString(Date.Today) & "' " & _
                                           "Where idPkDetail='" & dgvResult.Rows(0).Cells("ColidPkDetail_R").Value & "'"
                    sCommand.ExecuteNonQuery()
                End If

                If Me.txtAddlabel.Text <> "0" Then
                    '---update Stock Label---'
                    Dim sDt2 As New DataTable
                    Dim NewLbAmt As Integer = 0
                    sCommand.CommandText = "Select Amount From dPackingLabel Where idLabel = '" & dgvResult.Rows(0).Cells("ColidLabel_R").Value & "'"
                    sAdapter.Fill(sDt2)

                    NewLbAmt = sDt2.Rows(0).Item("Amount") - CInt(Me.txtAddlabel.Text)

                    sCommand.CommandText = "Update dPackingLabel Set Amount = " & NewLbAmt & ", " & _
                                           "idPsUpdate = '" & sPsId & "', DateUpdate = '" & ksbDateToString(Date.Today) & "' " & _
                                           "Where idLabel = '" & dgvResult.Rows(0).Cells("ColidLabel_R").Value & "'"
                    sCommand.ExecuteNonQuery()
                End If

                If Me.txtAddPkOp.Text <> "0" Then
                    '---update Stock PkDetail---'
                    Dim sDt As New DataTable
                    Dim NewPkAmtOp As Integer = 0
                    sCommand.CommandText = "Select Amount From dPackingDetail Where idPkDetail = '" & dgvResult.Rows(0).Cells("ColidPkDtOp_R").Value & "'"
                    sAdapter.Fill(sDt)

                    NewPkAmtOp = sDt.Rows(0).Item("Amount") - CInt(Me.txtAddPkOp.Text)

                    sCommand.CommandText = "Update dPackingDetail Set Amount = " & NewPkAmtOp & ", " & _
                                           "idPsUpdate = '" & sPsId & "', DateUpdate = '" & ksbDateToString(Date.Today) & "' " & _
                                           "Where idPkDetail='" & dgvResult.Rows(0).Cells("ColidPkDtOp_R").Value & "'"
                    sCommand.ExecuteNonQuery()
                End If

                If Me.txtAddBox.Text <> "0" Then
                    '---update Stock PkDetail---'
                    Dim sDt As New DataTable
                    Dim NewPkAmtBox As Integer = 0
                    sCommand.CommandText = "Select Amount From dPackingDetail Where idPkDetail = '" & DGV_Box.Rows(0).Cells("ColidPkDetailBox").Value & "'"
                    sAdapter.Fill(sDt)

                    NewPkAmtBox = sDt.Rows(0).Item("Amount") - CInt(Me.txtAddBox.Text)

                    sCommand.CommandText = "Update dPackingDetail Set Amount = " & NewPkAmtBox & ", " & _
                                           "idPsUpdate = '" & sPsId & "', DateUpdate = '" & ksbDateToString(Date.Today) & "' " & _
                                           "Where idPkDetail='" & DGV_Box.Rows(0).Cells("ColidPkDetailBox").Value & "'"
                    sCommand.ExecuteNonQuery()
                End If

                ''************** พิมพ์ใบเบิกวัสดุ ****************'
                'Dim crpPkMatDoc As New DataTable
                'crpPkMatDoc.Clear()

                'sCommand.CommandText = "SELECT  dt.DocCodeInc As PkIncDoc, mt.JobNo, mt.DatePacking, p.PdPkName, " & _
                '                       "p.PkUnitName, pk.SizeName, dt.AmtPkIncrease, l.LabelNameUse, " & _
                '                       "dt.AmtLbIncrease, dt.NoteIncrease, ps.PsName As PsPacking, " & _
                '                       "lid.sizename As LidName, dt.AmtLidIncrease, 'กล่อง ' + b.SizeName + ' " & _
                '                       "(' + CONVERT(varchar, b.Width) + ' x ' + CONVERT(varchar, b.Length) + " & _
                '                       "' x ' + CONVERT(varchar, b.Height) + ')' As BoxName, dt.AMtBoxIncrease " & _
                '                       "FROM PkPackingMt mt LEFT OUTER JOIN PkPackingDt dt " & _
                '                       "ON mt.idPacking = dt.idPacking LEFT OUTER JOIN vPackingPdSet p " & _
                '                       "ON dt.idPdPk = p.idPdPk LEFT OUTER JOIN dPackingDetail pk " & _
                '                       "ON dt.idPkDetail = pk.idPkDetail LEFT OUTER JOIN dPackingLabel l " & _
                '                       "ON dt.idLabel = l.idLabel LEFT OUTER JOIN vPerson ps " & _
                '                       "ON mt.idPsPacking = ps.idPs LEFT OUTER JOIN dPackingDetail lid " & _
                '                       "ON dt.idLid = lid.idPkDetail LEFT OUTER JOIN dPackingDetail b " & _
                '                       "ON dt.idBox = b.idPkDetail WHERE mt.idPacking = '" & idPacking_sent & "'"
                'sAdapter.Fill(crpPkMatDoc)

                'For i As Integer = 0 To crpPkMatDoc.Rows.Count - 1
                '    crpPkMatDoc.Rows(i).Item("DatePacking") = ksbStringToDate(crpPkMatDoc.Rows(i).Item("DatePacking"))
                '    If IsDBNull(crpPkMatDoc.Rows(i).Item("LidName")) Then
                '        crpPkMatDoc.Rows(i).Item("LidName") = "-"
                '    ElseIf crpPkMatDoc.Rows(i).Item("LidName") = "" Then
                '        crpPkMatDoc.Rows(i).Item("LidName") = "-"
                '    End If
                'Next

                'Dim vFrm As New FrmReportView
                'Dim vRpt As New crpPkMaterialDoc
                'vRpt.SetDataSource(crpPkMatDoc)

                'vRpt.SetParameterValue(vRpt.Parameter_PsPrint.ParameterFieldName, sPsName)
                'vFrm.crView.ReportSource = vRpt
                'vFrm.Show()
            End If

            MessageBox.Show("ระบบทำการยินยันรายการ Packing สินค้าเรียบร้อยแล้ว", sSystemName)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        End If

    End Sub

    Private Sub txtAddPk_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddPk.Leave
        If Me.txtAddPk.Text = "" Then
            Me.txtAddPk.Text = "0"
        End If
    End Sub

    Private Sub txtAddlabel_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddlabel.Leave
        If Me.txtAddlabel.Text = "" Then
            Me.txtAddlabel.Text = "0"
        End If
    End Sub

    Private Sub txtAddPkOp_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddPkOp.Leave
        If Me.txtAddPkOp.Text = "" Then
            Me.txtAddPkOp.Text = "0"
        End If
    End Sub

    '-------------------- GEN PackingInc --------------------'
    Function getPkInc(ByVal Prefixcode As String) As String
        Dim PkInc As String = ""
        Dim nextOrder As String = ""
        Dim CodeYear As String = ""

        mdCnOpen()
        Dim sDt As New DataTable
        sDs.Tables.Clear()
        sCommand.CommandText = "SELECT MAX(DocCodeInc) as max_DocCodeInc FROM PkPackingDt"
        sAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocCodeInc")) = True Then
            PkInc = "PKM" & Prefixcode & "/" & "0001"
        Else
            Dim yearDoc As String = sDt.Rows(0).Item("max_DocCodeInc").ToString.Substring(3, 2)
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocCodeInc"), 4)

            If Prefixcode <> yearDoc Then
                PkInc = "PKM" & Prefixcode & "/" & "0001"
            Else
                Dim temp As Integer
                temp = CInt(RunningCode) + 1
                If temp < 10 Then
                    nextOrder = "000" & CStr(temp)
                ElseIf temp < 100 Then
                    nextOrder = "00" & CStr(temp)
                ElseIf temp < 1000 Then
                    nextOrder = "0" & CStr(temp)
                Else
                    nextOrder = CStr(temp)
                End If
                PkInc = "PKM" & Prefixcode & "/" & nextOrder
            End If
        End If
        Return PkInc
    End Function

    Private Sub dgvPkOpen_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPkOpen.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        '--------Checkbox----'
        If dgvPkOpen.Columns(e.ColumnIndex).Name = ColSelectPkOp.Name Then
            dgvPkOpen.Rows(e.RowIndex).Cells(ColKeyOp.Name).Value = 1
            dgvPkOpen.Rows(e.RowIndex).Cells(ColSelectPkOp.Name).Value = True

            Dim ChkStLb As Integer = 0
            For i As Integer = 0 To Me.dgvPkOpen.Rows.Count - 1
                If i <> e.RowIndex Then
                    dgvPkOpen.Rows(i).Cells(ColKeyOp.Name).Value = 0
                    dgvPkOpen.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                    dgvPkOpen.Rows(i).Cells(ColSelectPkOp.Name).Value = False
                Else
                    dgvPkOpen.Rows(i).DefaultCellStyle.ForeColor = Color.DodgerBlue
                End If
            Next
        End If
    End Sub

    Private Sub dgvPkOpen_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPkOpen.CellEndEdit
        If dgvPkOpen.Columns(e.ColumnIndex).Name = ColSelectPkOp.Name Then
            If dgvPkOpen.Rows(e.RowIndex).Cells(ColSelectPkOp.Name).Value = False And dgvPkOpen.Rows(e.RowIndex).Cells(ColKeyOp.Name).Value = 1 Then
                dgvPkOpen.Rows(e.RowIndex).Cells(ColSelectPkOp.Name).Value = True
            End If
        End If
    End Sub

    Private Sub DGV_Box_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Box.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        '--------Checkbox----'
        If DGV_Box.Columns(e.ColumnIndex).Name = ColSelectBox.Name Then
            DGV_Box.Rows(e.RowIndex).Cells(ColKeyBox.Name).Value = 1
            DGV_Box.Rows(e.RowIndex).Cells(ColSelectBox.Name).Value = True
            DGV_Box.Rows(e.RowIndex).Cells(ColAmtBox.Name).Value = Format(CInt(txtAmtBoxLbl.Text), "#,##0")

            For i As Integer = 0 To Me.DGV_Box.Rows.Count - 1
                If i <> e.RowIndex Then
                    DGV_Box.Rows(i).Cells(ColKeyBox.Name).Value = 0
                    DGV_Box.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                    DGV_Box.Rows(i).Cells(ColSelectBox.Name).Value = False
                    DGV_Box.Rows(i).Cells(ColAmtBox.Name).Value = 0
                Else
                    DGV_Box.Rows(i).DefaultCellStyle.ForeColor = Color.DodgerBlue
                End If
            Next
        End If

    End Sub

    Private Sub DGV_Box_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Box.CellEndEdit
        If DGV_Box.Columns(e.ColumnIndex).Name = ColSelectBox.Name Then
            If DGV_Box.Rows(e.RowIndex).Cells(ColSelectBox.Name).Value = False And DGV_Box.Rows(e.RowIndex).Cells(ColKeyBox.Name).Value = 1 Then
                DGV_Box.Rows(e.RowIndex).Cells(ColSelectBox.Name).Value = True
            End If
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If stPage = 1 Then 'eNew
            If Me.TabControl1.SelectedIndex = 3 Then
                Me.btn_save.Visible = True
            Else
                Me.btn_save.Visible = False
            End If
            'ElseIf Me.TabControl1.SelectedIndex = 2 Then
            '    Me.btn_save.Visible = False

            'If stFlChk = 0 Then
            '    '--- Check Fl Status---'
            '    For i As Integer = 0 To DGV_formula.Rows.Count - 1
            '        Dim stFlCheck As Integer = 0
            '        Dim fDt As New DataTable
            '        sCommand.CommandText = "Select Sl.idPd, Sl.MixPerc, (SELECT SUM(Amount) AS Expr1 FROM PkPdLotStock " & _
            '                               "WHERE idPd = Sl.idPd) AS StockAmt, '0' AS RatioUse " & _
            '                               "From SlPdIngredient Sl Where Sl.idPdT =" & Me.lblPdTName.Tag & " " & _
            '                               "And Sl.idFl =" & DGV_formula.Rows(i).Cells(colidFL.Name).Value & " "
            '        'MessageBox.Show(Me.lblPdTName.Tag & "/" & DGV_formula.Rows(i).Cells(colidFL.Name).Value)
            '        sAdapter.Fill(fDt)

            '        For f As Integer = 0 To fDt.Rows.Count - 1
            '            If IsDBNull(fDt.Rows(f).Item("StockAmt")) Then
            '                stFlCheck = 1
            '            ElseIf fDt.Rows(f).Item("StockAmt") = 0 Then
            '                stFlCheck = 1
            '            End If
            '        Next

            '        If stFlCheck = 1 Then 'ไม่สามารถผลิตได้ - ไม่มีวัตถุดิบใน Stock
            '            DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.Pink
            '        Else 'สามารถผลิตได้ --> Check เงื่อนไขต่อ ว่าผลิตได้ทั้งหมด /ผลิตได้บางส่วน
            '            For f As Integer = 0 To fDt.Rows.Count - 1
            '                fDt.Rows(f).Item("RatioUse") = CDbl(txtSumWeight.Text) * (fDt.Rows(f).Item("MixPerc") / 100)
            '                If fDt.Rows(f).Item("StockAmt") < fDt.Rows(f).Item("RatioUse") Then
            '                    stFlCheck = 2 'ไม่พอ ผลิตได้บางส่วน 
            '                End If
            '            Next

            '            If stFlCheck = 2 Then
            '                DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon  'ไม่พอ ผลิตได้บางส่วน
            '            Else
            '                DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.PaleGreen  'พอ ผลิตได้ทั้งหมด
            '            End If
            '        End If
            '    Next
            'End If
            'stFlChk = 1


        End If

    End Sub

    Private Sub dtpCombine_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCombine.ValueChanged
        If stPage = 1 Then
            'Test Date
            Me.dtpTest.Value = Me.dtpCombine.Value.AddMonths(1)

            'Exp Date
            CalExpDate()
            stLoad = 1
        End If
    End Sub

    Sub CalExpDate() 'คำนวณวันหมดอายุ
        Dim vfield As String = ""
        If Me.rdbA.Checked = True Then
            vfield = " PdAge_GradA "
        Else
            vfield = " PdAge_GradB "
        End If
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT " & vfield & " As PdAge FROM SlPdTradeNameD WHERE idPdT = " & Me.lblPdTName.Tag & ""
        sAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("PdAge")) Then
            sDt.Rows(0).Item("PdAge") = 0
            mdLoadCommitt()
            MessageBox.Show("สินค้านี้ยังไม่ได้กำหนดวันหมดอายุของสินค้า ระบบจึงไม่สามารถคำนวณวันหมดอายุได้", sSystemName)
        End If
        Me.dtpExp.Value = Me.dtpCombine.Value.AddMonths(sDt.Rows(0).Item("PdAge"))
    End Sub

    Private Sub rdbA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbA.CheckedChanged
        If stPage = 1 Then
            If stLoad = 1 And Me.rdbA.Checked = True Then
                CalExpDate()
            End If
        End If
    End Sub

    Private Sub rdbB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbB.CheckedChanged
        If stPage = 1 Then
            If Me.rdbB.Checked = True Then
                CalExpDate()
            End If
        End If
    End Sub

End Class