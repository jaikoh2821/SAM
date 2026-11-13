Public Class frmPdStockDetail
    Dim eEvent As eProcess
    Dim stPage As String
    Dim idPdLot_ As String
    Dim Result As DialogResult
    Dim Amount_ As Double = 0
    Dim pidWhSent As String = "NULL"

    Enum eProcess
        eAdd
        eEdit
        eDelete
        eShow
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idPdLot As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eAdd
                stPage = 1
            Case eProcess.eEdit
                stPage = 2
                'Case eProcess.eDelete
                '    stPage = 3
            Case eProcess.eShow
                stPage = 3
        End Select
        eEvent = aProcess
        idPdLot_ = idPdLot
    End Sub

    Private Sub frmPdStockDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If stPage = 1 Then
            'Add
            BindPlant()
            BindUnit()
            'BindPd()
            Me.lblPsUpdate.Text = sPsName
            Me.lblPsUpdate.Tag = sPsId
            Me.lblDateUpdate.Text = Date.Today
            Me.DateBookStart.Value = Date.Today
            Me.DateBookEnd.Value = Date.Today
            Me.DateGrowCheck.Value = Date.Today

        ElseIf stPage = 2 Or stPage = 3 Then
            'Edit
            Me.Text = "แก้ไขข้อมูล Lot สินค้าวัตถุดิบ"

            Dim vDt As New DataTable
            vDt.Clear()
            sCommand.CommandText = "Select s.idPdLot,s.LotNum, s.LotCodeRef, s.idPd, p.PdName, p.idSeedType, p.SeedTypeName, s.DateRec, " & _
                                    "s.DocPackCode, s.GrowRec, s.HumidRec, s.PureRec, s.Grad, s.Grow, " & _
                                    "s.Humid, s.Pure, s.GrowAA, s.GrowTZ, s.GrowPaper,s.AddressRec,s.idCus,c.CusName_, " & _
                                    "s.GrowSand,s.GrowAggie,s.PureAggieEX,s.PureAggie,DateGrowCheck,DateBookStart,DateBookEnd,s.AmountRec, s.AmountUse, s.Amount, s.DateUpdate, s.idPsUpdate, " & _
                                    "s.Note, v.PsName AS PsUpdate,WareHouseName,s.idWh,s.idUnitW " & _
                                   "From PkPdLotStock s LEFT OUTER JOIN vSeedProduct p " & _
                                   "ON s.idPd = p.idPd LEFT OUTER JOIN vPerson v " & _
                                   "ON s.idPsUpdate = v.idPs LEFT JOIN SsWarehouse Wh ON Wh.idWh = s.idWh " & _
                                   "LEFT JOIN vCustomer c ON c.idCus = s.idCus Where idPdLot = '" & idPdLot_ & "'"

            sAdapter.Fill(vDt)

            BindPlant()
            BindUnit()
            Me.cmbPlant.Text = vDt.Rows(0).Item("SeedTypeName")
            Me.cmbPdName.Enabled = True
            BindPd()
            Me.cmbUnitSet.SelectedValue = vDt.Rows(0).Item("idUnitW").ToString
            Me.cmbPdName.Text = vDt.Rows(0).Item("PdName").ToString
            Me.txtLotCodeRef.Text = vDt.Rows(0).Item("LotCodeRef").ToString
            Me.txtLotNo.Text = vDt.Rows(0).Item("LotNum").ToString

            If IsDBNull(vDt.Rows(0).Item("DateBookStart")) Then
                vDt.Rows(0).Item("DateBookStart") = ""
            End If


            If vDt.Rows(0).Item("DateBookStart") = "" Then
                ChkDate.Checked = False
            Else
                ChkDate.Checked = True
                Me.DateBookStart.Value = ksbStringToDate(vDt.Rows(0).Item("DateBookStart")).ToString
                Me.DateBookEnd.Value = ksbStringToDate(vDt.Rows(0).Item("DateBookEnd")).ToString
            End If



            Me.dtpDateRec.Value = ksbStringToDate(vDt.Rows(0).Item("DateRec")).ToString
            Me.txtDoxPackCode.Text = vDt.Rows(0).Item("DocPackCode").ToString
            Me.txtGrade.Text = vDt.Rows(0).Item("Grad").ToString

            If IsDBNull(vDt.Rows(0).Item("idCus")) Then
                vDt.Rows(0).Item("idCus") = 0
            End If
            If vDt.Rows(0).Item("idCus").ToString <> 0 Then
                Chk_Cus.Checked = True
                txtCusName.Text = vDt.Rows(0).Item("CusName_")
                txtCusName.Tag = vDt.Rows(0).Item("idCus")
            Else
                Chk_Cus.Checked = False
            End If

            If IsDBNull(vDt.Rows(0).Item("DateGrowCheck")) Then
                vDt.Rows(0).Item("DateGrowCheck") = ""
            End If


            If vDt.Rows(0).Item("DateGrowCheck") = "" Then
                ChkDateGrow.Checked = True
            Else
                ChkDateGrow.Checked = False
                Me.DateGrowCheck.Value = ksbStringToDate(vDt.Rows(0).Item("DateGrowCheck")).ToString
            End If

            If IsDBNull(vDt.Rows(0).Item("AddressRec")) Then
                txtAddress.Text = ""
            Else
                txtAddress.Text = vDt.Rows(0).Item("AddressRec")
            End If


            If Trim(vDt.Rows(0).Item("GrowRec").ToString) = "" Or Trim(vDt.Rows(0).Item("GrowRec").ToString) = "-" Then
                Me.txtGrowRec.Value = 0
            ElseIf vDt.Rows(0).Item("GrowRec").ToString = "WW" Then
                Chk3_1.Checked = True
            ElseIf vDt.Rows(0).Item("GrowRec").ToString = "NN" Then
                Chk3_2.Checked = True
            Else
                Me.txtGrowRec.Value = vDt.Rows(0).Item("GrowRec")
            End If

            If Trim(vDt.Rows(0).Item("Grow").ToString) = "" Or Trim(vDt.Rows(0).Item("Grow").ToString) = "-" Then
                Me.txtGrow.Value = 0
            ElseIf vDt.Rows(0).Item("Grow").ToString = "WW" Then
                Chk1_1.Checked = True
            ElseIf vDt.Rows(0).Item("Grow").ToString = "NN" Then
                Chk1_2.Checked = True
            Else
                Me.txtGrow.Value = vDt.Rows(0).Item("Grow")
            End If





            If Trim(vDt.Rows(0).Item("GrowAA").ToString) = "" Or Trim(vDt.Rows(0).Item("GrowAA").ToString) = "-" Then
                Me.txtAA.Value = 0
            ElseIf vDt.Rows(0).Item("GrowAA").ToString = "WW" Then
                Chk4_1.Checked = True
            ElseIf vDt.Rows(0).Item("GrowAA").ToString = "NN" Then
                Chk4_2.Checked = True
            Else
                Me.txtAA.Value = vDt.Rows(0).Item("GrowAA")
            End If

            If Trim(vDt.Rows(0).Item("GrowTZ").ToString) = "" Or Trim(vDt.Rows(0).Item("GrowTZ").ToString) = "-" Then
                Me.txtTZ.Value = 0
            ElseIf vDt.Rows(0).Item("GrowTZ").ToString = "WW" Then
                Chk5_1.Checked = True
            ElseIf vDt.Rows(0).Item("GrowTZ").ToString = "NN" Then
                Chk5_2.Checked = True
            Else
                Me.txtTZ.Value = vDt.Rows(0).Item("GrowTZ")
            End If


            If Trim(vDt.Rows(0).Item("GrowPaper").ToString) = "" Or Trim(vDt.Rows(0).Item("GrowPaper").ToString) = "-" Then
                Me.txtPaper.Value = 0
            ElseIf vDt.Rows(0).Item("GrowPaper").ToString = "WW" Then
                Chk6_1.Checked = True
            ElseIf vDt.Rows(0).Item("GrowPaper").ToString = "NN" Then
                Chk6_2.Checked = True
            Else
                Me.txtPaper.Value = vDt.Rows(0).Item("GrowPaper")
            End If


            If Trim(vDt.Rows(0).Item("GrowSand").ToString) = "" Or Trim(vDt.Rows(0).Item("GrowSand").ToString) = "-" Then
                Me.txtSand.Value = 0
            ElseIf vDt.Rows(0).Item("GrowSand").ToString = "WW" Then
                Chk7_1.Checked = True
            ElseIf vDt.Rows(0).Item("GrowSand").ToString = "NN" Then
                Chk7_2.Checked = True
            Else
                Me.txtSand.Value = vDt.Rows(0).Item("GrowSand")
            End If


            If Trim(vDt.Rows(0).Item("GrowAggie").ToString) = "" Or Trim(vDt.Rows(0).Item("GrowAggie").ToString) = "-" Then
                Me.txtGrowAggie.Value = 0
            ElseIf vDt.Rows(0).Item("GrowAggie").ToString = "WW" Then
                Chk2_1.Checked = True
            ElseIf vDt.Rows(0).Item("GrowAggie").ToString = "NN" Then
                Chk2_2.Checked = True
            Else
                Me.txtGrowAggie.Value = vDt.Rows(0).Item("GrowAggie")
            End If


            If Trim(vDt.Rows(0).Item("HumidRec").ToString) = "" Or Trim(vDt.Rows(0).Item("HumidRec").ToString) = "-" Then
                Me.txtHmRec.Value = 0
            ElseIf vDt.Rows(0).Item("HumidRec").ToString = "WW" Then
                Chk9_1.Checked = True
            ElseIf vDt.Rows(0).Item("HumidRec").ToString = "NN" Then
                Chk9_2.Checked = True
            Else
                Me.txtHmRec.Value = vDt.Rows(0).Item("HumidRec")
            End If

            If Trim(vDt.Rows(0).Item("Humid").ToString) = "" Or Trim(vDt.Rows(0).Item("Humid").ToString) = "-" Then
                Me.txtHumid.Value = 0
            ElseIf vDt.Rows(0).Item("Humid").ToString = "WW" Then
                Chk8_1.Checked = True
            ElseIf vDt.Rows(0).Item("Humid").ToString = "NN" Then
                Chk8_2.Checked = True
            Else
                Me.txtHumid.Value = vDt.Rows(0).Item("Humid")
            End If


            If Trim(vDt.Rows(0).Item("PureAggieEX").ToString) = "" Or Trim(vDt.Rows(0).Item("PureAggieEX").ToString) = "-" Then
                Me.txtPureAggieEX.Value = 0
            ElseIf vDt.Rows(0).Item("PureAggieEX").ToString = "WW" Then
                Chk10_1.Checked = True
            ElseIf vDt.Rows(0).Item("PureAggieEX").ToString = "NN" Then
                Chk10_2.Checked = True
            Else
                Me.txtPureAggieEX.Value = vDt.Rows(0).Item("PureAggieEX")
            End If


            If Trim(vDt.Rows(0).Item("Pure").ToString) = "" Or Trim(vDt.Rows(0).Item("Pure").ToString) = "-" Then
                Me.txtPure.Value = 0
            ElseIf vDt.Rows(0).Item("Pure").ToString = "WW" Then
                Chk12_1.Checked = True
            ElseIf vDt.Rows(0).Item("Pure").ToString = "NN" Then
                Chk12_2.Checked = True
            Else
                Me.txtPure.Value = vDt.Rows(0).Item("Pure")
            End If

            If Trim(vDt.Rows(0).Item("PureAggie").ToString) = "" Or Trim(vDt.Rows(0).Item("PureAggie").ToString) = "-" Then
                Me.txtPureAggie.Value = 0
            ElseIf vDt.Rows(0).Item("PureAggie").ToString = "WW" Then
                Chk11_1.Checked = True
            ElseIf vDt.Rows(0).Item("PureAggie").ToString = "NN" Then
                Chk11_2.Checked = True
            Else
                Me.txtPureAggie.Value = vDt.Rows(0).Item("PureAggie")
            End If




            'Me.txtHmRec.Text = vDt.Rows(0).Item("HumidRec").ToString
            'Me.txtPureRec.Text = vDt.Rows(0).Item("PureRec").ToString


            'Me.txtAA.Text = vDt.Rows(0).Item("GrowAA").ToString
            'Me.txtTZ.Text = vDt.Rows(0).Item("GrowTZ").ToString
            'Me.txtPaper.Text = vDt.Rows(0).Item("GrowPaper").ToString
            'Me.txtSand.Text = vDt.Rows(0).Item("GrowSand").ToString
            'Me.txtHumid.Text = vDt.Rows(0).Item("Humid").ToString
            'Me.txtPureAggie.Text = vDt.Rows(0).Item("Pure").ToString
            Me.txtAmtRec.Text = vDt.Rows(0).Item("AmountRec").ToString
            Me.txtAmtUse.Text = vDt.Rows(0).Item("AmountUse").ToString
            Me.txtAmount.Text = vDt.Rows(0).Item("Amount").ToString

            If IsDBNull(vDt.Rows(0).Item("Note")) Then
                Me.txtNote.Text = ""
            Else
                Me.txtNote.Text = vDt.Rows(0).Item("Note")
            End If

            If IsDBNull(vDt.Rows(0).Item("WareHouseName")) Then
                Me.txtInvName.Text = ""
            Else
                Me.txtInvName.Text = vDt.Rows(0).Item("WareHouseName")
                pidWhSent = vDt.Rows(0).Item("idWh")
            End If

            Me.lblPsUpdate.Text = vDt.Rows(0).Item("PsUpdate")
            Me.lblDateUpdate.Text = ksbStringToDate(vDt.Rows(0).Item("DateUpdate"))
            Me.btnDelete.Visible = True

            'If stPage = 3 Then
            '    Me.Text = "ลบข้อมูล Lot สินค้าวัตถุดิบ"
            '    Me.btn_save.Visible = False

            '    Me.cmbPlant.Enabled = False
            '    Me.cmbPdName.Enabled = False
            '    Me.txtLotCodeRef.Enabled = False
            '    Me.txtGrade.Enabled = False
            '    Me.txtGrow.Enabled = False
            '    Me.txtHumid.Enabled = False
            '    Me.txtPure.Enabled = False
            '    Me.txtAmount.Enabled = False
            '    Me.dtpDateRec.Enabled = False
            '    Me.txtDoxPackCode.Enabled = False
            '    Me.txtAA.Enabled = False
            '    Me.txtTZ.Enabled = False
            '    Me.txtPaper.Enabled = False
            '    Me.txtSand.Enabled = False
            '    Me.txtAmtRec.Enabled = False
            '    Me.txtAmtUse.Enabled = False
            '    Me.txtNote.Enabled = False
            '    Me.txtGrowRec.Enabled = False
            '    Me.txtHmRec.Enabled = False
            '    Me.txtPureRec.Enabled = False
            'End If
        End If


        If stPage = 3 Then
            GroupBox1.Enabled = False
            cmbPlant.Enabled = False
            cmbPdName.Enabled = False
            txtLotCodeRef.Enabled = False
            dtpDateRec.Enabled = False
            txtLotNo.Enabled = False
            txtDoxPackCode.Enabled = False
            txtGrade.Enabled = False
            txtInvName.Enabled = False
            Button1.Enabled = False
            txtAmtRec.Enabled = False
            txtAmtUse.Enabled = False
            txtAmount.Enabled = False

            txtAddress.Enabled = False
            DateBookStart.Enabled = False
            DateBookEnd.Enabled = False
            ChkDate.Enabled = False
            Chk_Cus.Enabled = False
            txtNote.Enabled = False
            txtCusName.Enabled = False
            btn_SelectCus.Enabled = False
            btnDelete.Visible = False
            btn_save.Visible = False


        End If

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

    Private Sub BindUnit()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select * From dUnitW "
        sAdapter.Fill(sDt)

        With cmbUnitSet
            .DisplayMember = "UnitWFull"
            .ValueMember = "idUnitW"
            .DataSource = sDt
        End With
    End Sub

    Private Sub BindPd()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Distinct idPd, PdName From vSeedProduct Where idSeedType = '" & Me.cmbPlant.SelectedValue & "' Order By PdName Asc"
        sAdapter.Fill(sDt)

        With cmbPdName
            .DisplayMember = "PdName"
            .ValueMember = "idPd"
            .DataSource = sDt
        End With
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If Me.txtLotCodeRef.Text = "" Then
            MessageBox.Show("กรุณาระบุ Group/Serial", sSystemName)
            Exit Sub
            'ElseIf Me.txtDoxPackCode.Text = "" Then
            '    MessageBox.Show("กรุณาระบุเลขที่แพ็ค", sSystemName)
            '    Exit Sub
        ElseIf Me.txtLotNo.Text = "" Then
            MessageBox.Show("กรุณาระบุ Lot No.", sSystemName)
            Exit Sub

        ElseIf Me.txtGrade.Text = "" Then
            MessageBox.Show("กรุณาระบุเกรด", sSystemName)
            Exit Sub
            'ElseIf Me.txtGrow.Text = "" Then
            '    MessageBox.Show("กรุณาระบุความงอก", sSystemName)
            '    Exit Sub
            'ElseIf Me.txtAA.Text = "" Then
            '    MessageBox.Show("กรุณาระบุความงอก AA", sSystemName)
            '    Exit Sub
            'ElseIf Me.txtTZ.Text = "" Then
            '    MessageBox.Show("กรุณาระบุความงอก TZ", sSystemName)
            '    Exit Sub
            'ElseIf Me.txtPaper.Text = "" Then
            '    MessageBox.Show("กรุณาระบุความงอก Paper", sSystemName)
            '    Exit Sub
            'ElseIf Me.txtSand.Text = "" Then
            '    MessageBox.Show("กรุณาระบุความงอก Sand", sSystemName)
            '    Exit Sub
            'ElseIf Me.txtHumid.Text = "" Then
            '    MessageBox.Show("กรุณาระบุความชื้น", sSystemName)
            '    Exit Sub
            'ElseIf Me.txtPure.Text = "" Then
            '    MessageBox.Show("กรุณาระบุความบริสุทธิ์", sSystemName)
            '    Exit Sub
        ElseIf Me.txtAmtRec.Text = "" Then
            MessageBox.Show("กรุณาระบุน้ำหนักรับมา", sSystemName)
            Me.txtAmount.Focus()
            Exit Sub
        ElseIf Me.txtAmtUse.Text = "" Then
            MessageBox.Show("กรุณาระบุน้ำหนักใช้ไป", sSystemName)
            Me.txtAmount.Focus()
            Exit Sub
            'ElseIf Me.txtGrowRec.Text = "" Then
            '    MessageBox.Show("กรุณาระบุความงอกรับมา", sSystemName)
            '    Me.txtAmount.Focus()
            '    Exit Sub
            'ElseIf Me.txtHmRec.Text = "" Then
            '    MessageBox.Show("กรุณาระบุความชื้นรับมา", sSystemName)
            '    Me.txtAmount.Focus()
            '    Exit Sub
            'ElseIf Me.txtPureRec.Text = "" Then
            '    MessageBox.Show("กรุณาระบุความบริสุทธิ์รับมา", sSystemName)
            '    Me.txtAmount.Focus()
            '    Exit Sub
        Else
            If stPage = 1 Then
                If Trim(Me.txtDoxPackCode.Text) <> "" And Trim(Me.txtDoxPackCode.Text) <> "-" Then
                    mdCnOpen()
                    Dim dt As New DataTable
                    sCommand.CommandText = "Select LotCodeRef, DocPackCode From PkPdLotStock"
                    sAdapter.Fill(dt)

                    For i As Integer = 0 To dt.Rows.Count - 1
                        'If Trim(Me.txtLotCodeRef.Text) = dt.Rows(i).Item("LotCodeRef") Then
                        '    '            'MessageBox.Show("เลขที่อ้างอิงซ้ำกับข้อมูลเดิม" & dRefDt.Rows(i).Item("DateSale"), sSystemName)
                        '    MessageBox.Show("Group/Serial ซ้ำกับข้อมูลเดิม", sSystemName)
                        '    Me.txtLotCodeRef.Focus()
                        '    Exit Sub
                        If Not IsDBNull(dt.Rows(i).Item("DocPackCode")) Then
                            If Trim(Me.txtDoxPackCode.Text) = dt.Rows(i).Item("DocPackCode") Then
                                MessageBox.Show("เลขที่ใบแพ็คซ้ำกับข้อมูลเดิม", sSystemName)
                                Me.txtLotCodeRef.Focus()
                                Exit Sub
                            End If
                        End If

                    Next
                End If

                mdLoadShow()
                AddPkPdLotStock()
                mdLoadCommitt()
            ElseIf stPage = 2 Then
                If Trim(Me.txtDoxPackCode.Text) <> "" And Trim(Me.txtDoxPackCode.Text) <> "-" Then
                    mdCnOpen()
                    Dim dt As New DataTable
                    sCommand.CommandText = "Select LotCodeRef, DocPackCode From PkPdLotStock Where idPdLot <> '" & idPdLot_ & "'"
                    sAdapter.Fill(dt)

                    For i As Integer = 0 To dt.Rows.Count - 1
                        ' If Trim(Me.txtLotCodeRef.Text) = dt.Rows(i).Item("LotCodeRef") Then
                        ''            'MessageBox.Show("เลขที่อ้างอิงซ้ำกับข้อมูลเดิม" & dRefDt.Rows(i).Item("DateSale"), sSystemName)
                        'MessageBox.Show("Group/Serial ซ้ำกับข้อมูลเดิม", sSystemName)
                        'Me.txtLotCodeRef.Focus()
                        'Exit Sub
                        If Not IsDBNull(dt.Rows(i).Item("DocPackCode")) Then
                            If Trim(Me.txtDoxPackCode.Text) = dt.Rows(i).Item("DocPackCode") Then
                                MessageBox.Show("เลขที่ใบแพ็คซ้ำกับข้อมูลเดิม", sSystemName)
                                Me.txtLotCodeRef.Focus()
                                Exit Sub
                            End If
                        End If

                    Next
                End If

                mdLoadShow()
                UpDatePkPdLotStock()
                mdLoadCommitt()
            End If

            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Sub AddPkPdLotStock()
        '---insert PkPdLotStock Table---'
        mdCnOpen()
        Dim pDateBookStart As String = ""
        Dim pDateBookEnd As String = ""
        Dim pDateGrowCheck As String = ""
        Dim pGrow As String = ""
        Dim pGrowRec As String = ""
        Dim pGrowAggie As String = ""
        Dim pGrowAA As String = ""
        Dim pGrowTZ As String = ""
        Dim pGrowPaper As String = ""
        Dim pGrowSand As String = ""
        Dim pHumid As String = ""
        Dim pHumidRec As String = ""
        Dim pPureAggieEX As String = ""
        Dim pPureAggie As String = ""
        Dim pPure As String = ""

        If Chk12_1.Checked Then
            pPure = "WW"
        ElseIf Chk12_2.Checked Then
            pPure = "NN"
        Else
            pPure = txtPure.Value
        End If

        If Chk11_1.Checked Then
            pPureAggie = "WW"
        ElseIf Chk11_2.Checked Then
            pPureAggie = "NN"
        Else
            pPureAggie = txtPureAggie.Value
        End If

        If Chk10_1.Checked Then
            pPureAggieEX = "WW"
        ElseIf Chk10_2.Checked Then
            pPureAggieEX = "NN"
        Else
            pPureAggieEX = txtPureAggieEX.Value
        End If

        If Chk9_1.Checked Then
            pHumidRec = "WW"
        ElseIf Chk9_2.Checked Then
            pHumidRec = "NN"
        Else
            pHumidRec = txtHmRec.Value
        End If

        If Chk8_1.Checked Then
            pHumid = "WW"
        ElseIf Chk8_2.Checked Then
            pHumid = "NN"
        Else
            pHumid = txtHumid.Value
        End If

        If Chk7_1.Checked Then
            pGrowSand = "WW"
        ElseIf Chk7_2.Checked Then
            pGrowSand = "NN"
        Else
            pGrowSand = txtSand.Value
        End If

        If Chk6_1.Checked Then
            pGrowPaper = "WW"
        ElseIf Chk6_2.Checked Then
            pGrowPaper = "NN"
        Else
            pGrowPaper = txtPaper.Value
        End If

        If Chk5_1.Checked Then
            pGrowTZ = "WW"
        ElseIf Chk5_2.Checked Then
            pGrowTZ = "NN"
        Else
            pGrowTZ = txtTZ.Value
        End If

        If Chk4_1.Checked Then
            pGrowAA = "WW"
        ElseIf Chk4_2.Checked Then
            pGrowAA = "NN"
        Else
            pGrowAA = txtAA.Value
        End If

        If Chk3_1.Checked Then
            pGrowRec = "WW"
        ElseIf Chk3_2.Checked Then
            pGrowRec = "NN"
        Else
            pGrowRec = txtGrowRec.Value
        End If

        If Chk2_1.Checked Then
            pGrowAggie = "WW"
        ElseIf Chk2_2.Checked Then
            pGrowAggie = "NN"
        Else
            pGrowAggie = txtGrowAggie.Value
        End If

        If Chk1_1.Checked Then
            pGrow = "WW"
        ElseIf Chk1_2.Checked Then
            pGrow = "NN"
        Else
            pGrow = txtGrow.Value
        End If

        If ChkDate.Checked Then
            pDateBookStart = ksbDateToString(DateBookStart.Value)
            pDateBookEnd = ksbDateToString(DateBookEnd.Value)
        End If
        If ChkDateGrow.Checked = False Then
            pDateGrowCheck = ksbDateToString(DateGrowCheck.Value)
        End If
        If Chk_Cus.Checked = False Then
            txtCusName.Tag = 0
        End If

        sCommand.CommandText = "Insert Into PkPdLotStock(LotNum,LotCodeRef, idPd, DateRec, DocPackCode, GrowRec, HumidRec, PureRec, Grad, Grow, Humid, Pure, " & _
                               "GrowAA, GrowTZ, GrowPaper, GrowSand, AmountRec, AmountUse, Amount, DateUpdate, idPsUpdate, Note, idWh," & _
                               " AddressRec,idCus,DateBookStart,DateBookEnd,DateGrowCheck,GrowAggie,PureAggieEX,PureAggie) " & _
                               "Values('" & Trim(txtLotNo.Text) & "' , '" & Trim(Me.txtLotCodeRef.Text) & "', '" & Me.cmbPdName.SelectedValue & "', " & _
                               "'" & ksbDateToString(dtpDateRec.Value.ToShortDateString) & "', '" & Trim(Me.txtDoxPackCode.Text) & "', " & _
                               "'" & pGrowRec & "','" & pHumidRec & "', '" & pPure & "', " & _
                               "'" & Trim(Me.txtGrade.Text) & "','" & pGrow & "', " & _
                               "'" & pHumid & "','" & pPure & "', '" & pGrowAA & "', " & _
                               "'" & pGrowTZ & "', '" & pGrowPaper & "', '" & pGrowSand & "', " & _
                               "" & CDbl(Trim(Me.txtAmtRec.Value.ToString)) & ", " & CDbl(Trim(Me.txtAmtUse.Value.ToString)) & ", " & Amount_ & ", " & _
                               "'" & ksbDateToString(Date.Today) & "', '" & Trim(Me.lblPsUpdate.Tag) & "', '" & Trim(Me.txtNote.Text) & "', " & pidWhSent & ", " & _
                               "'" & txtAddress.Text & "'," & txtCusName.Tag & ",'" & pDateBookStart & "','" & pDateBookEnd & "'," & _
                               "'" & pDateGrowCheck & "','" & pGrowAggie & "', '" & pPureAggieEX & "', '" & pPureAggie & "')"
        Dim idVal As Integer = mdCnOpenQueryIdentity(sCommand.CommandText)
        ' mdPdMixStockUpdate(3, idVal, Amount_, "WIM-2", idVal)


        'sCommand.CommandText = "Delete From PkPdLotStock"
        'sCommand.ExecuteNonQuery()

    End Sub

    Sub UpDatePkPdLotStock()
        '---update PkPdLotStock Table---'
        Dim pDateBookStart As String = ""
        Dim pDateBookEnd As String = ""
        Dim pDateGrowCheck As String = ""
        Dim pGrow As String = ""
        Dim pGrowRec As String = ""
        Dim pGrowAggie As String = ""
        Dim pGrowAA As String = ""
        Dim pGrowTZ As String = ""
        Dim pGrowPaper As String = ""
        Dim pGrowSand As String = ""
        Dim pHumid As String = ""
        Dim pHumidRec As String = ""
        Dim pPureAggieEX As String = ""
        Dim pPureAggie As String = ""
        Dim pPure As String = ""

        If Chk12_1.Checked Then
            pPure = "WW"
        ElseIf Chk12_2.Checked Then
            pPure = "NN"
        Else
            pPure = txtPure.Value
        End If

        If Chk11_1.Checked Then
            pPureAggie = "WW"
        ElseIf Chk11_2.Checked Then
            pPureAggie = "NN"
        Else
            pPureAggie = txtPureAggie.Value
        End If

        If Chk10_1.Checked Then
            pPureAggieEX = "WW"
        ElseIf Chk10_2.Checked Then
            pPureAggieEX = "NN"
        Else
            pPureAggieEX = txtPureAggieEX.Value
        End If

        If Chk9_1.Checked Then
            pHumidRec = "WW"
        ElseIf Chk9_2.Checked Then
            pHumidRec = "NN"
        Else
            pHumidRec = txtHmRec.Value
        End If

        If Chk8_1.Checked Then
            pHumid = "WW"
        ElseIf Chk8_2.Checked Then
            pHumid = "NN"
        Else
            pHumid = txtHumid.Value
        End If

        If Chk7_1.Checked Then
            pGrowSand = "WW"
        ElseIf Chk7_2.Checked Then
            pGrowSand = "NN"
        Else
            pGrowSand = txtSand.Value
        End If

        If Chk6_1.Checked Then
            pGrowPaper = "WW"
        ElseIf Chk6_2.Checked Then
            pGrowPaper = "NN"
        Else
            pGrowPaper = txtPaper.Value
        End If

        If Chk5_1.Checked Then
            pGrowTZ = "WW"
        ElseIf Chk5_2.Checked Then
            pGrowTZ = "NN"
        Else
            pGrowTZ = txtTZ.Value
        End If

        If Chk4_1.Checked Then
            pGrowAA = "WW"
        ElseIf Chk4_2.Checked Then
            pGrowAA = "NN"
        Else
            pGrowAA = txtAA.Value
        End If

        If Chk3_1.Checked Then
            pGrowRec = "WW"
        ElseIf Chk3_2.Checked Then
            pGrowRec = "NN"
        Else
            pGrowRec = txtGrowRec.Value
        End If

        If Chk2_1.Checked Then
            pGrowAggie = "WW"
        ElseIf Chk2_2.Checked Then
            pGrowAggie = "NN"
        Else
            pGrowAggie = txtGrowAggie.Value
        End If

        If Chk1_1.Checked Then
            pGrow = "WW"
        ElseIf Chk1_2.Checked Then
            pGrow = "NN"
        Else
            pGrow = txtGrow.Value
        End If

        If ChkDate.Checked Then
            pDateBookStart = ksbDateToString(DateBookStart.Value)
            pDateBookEnd = ksbDateToString(DateBookEnd.Value)
        End If
        If ChkDateGrow.Checked = False Then
            pDateGrowCheck = ksbDateToString(DateGrowCheck.Value)
        End If

        If Chk_Cus.Checked = False Then
            txtCusName.Tag = 0
        End If

        mdCnOpen()
        sCommand.CommandText = "Update PkPdLotStock Set LotNum = '" & Trim(txtLotNo.Text) & "', LotCodeRef ='" & Trim(Me.txtLotCodeRef.Text) & "', idPd='" & Me.cmbPdName.SelectedValue & "', " & _
                                "DateRec='" & ksbDateToString(dtpDateRec.Value.ToShortDateString) & "', " & _
                                "DocPackCode='" & Trim(Me.txtDoxPackCode.Text) & "', GrowRec='" & pGrowRec & "'," & _
                                "HumidRec='" & pHumidRec & "', " & _
                                "Grad='" & Trim(Me.txtGrade.Text) & "', Grow='" & pGrow & "', " & _
                                "Humid='" & pHumid & "', Pure='" & pPure & "', " & _
                                "GrowAA='" & pGrowAA & "', GrowTZ='" & pGrowTZ & "', " & _
                                "GrowPaper='" & pGrowPaper & "', GrowSand='" & pGrowSand & "', " & _
                                "AmountRec='" & CDbl(Trim(Me.txtAmtRec.Text)) & "', AmountUse='" & CDbl(Trim(Me.txtAmtUse.Text)) & "', " & _
                                "Amount ='" & CDbl(Trim(Me.txtAmount.Text)) & "', Note='" & Trim(Me.txtNote.Text) & "', " & _
                                "DateUpdate='" & ksbDateToString(Date.Today) & "', idPsUpdate='" & sPsId & "' " & _
                                ", idWh= " & pidWhSent & " " & _
                                ", AddressRec= '" & txtAddress.Text & "' " & _
                                ", idCus= " & txtCusName.Tag & " " & _
                                ", DateBookStart= '" & pDateBookStart & "' " & _
                                ", DateBookEnd= '" & pDateBookEnd & "' " & _
                                ", DateGrowCheck= '" & pDateGrowCheck & "' " & _
                                ", GrowAggie= '" & pGrowAggie & "' " & _
                                ", PureAggieEX= '" & pPureAggieEX & "' " & _
                                ", PureAggie= '" & pPureAggie & "' " & _
                                "Where idPdLot='" & idPdLot_ & "'"
        sCommand.ExecuteNonQuery()

        'Dim idVal As Integer = mdCnOpenQueryIdentity(sCommand.CommandText)
        'mdPdMixStockUpdate(3, idPdLot_, CDbl(Trim(Me.txtAmount.Text)), "WIM: แก้ไขสินค้าวัตถุดิบ", 0)

    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub cmbPlant_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlant.SelectedIndexChanged
        BindPd()
        If Me.cmbPlant.SelectedValue <> Nothing Then
            Me.cmbPdName.Enabled = True
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Result = MsgBox("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
        If Result = Windows.Forms.DialogResult.Yes Then
            mdCnOpen()
            Dim DelDt As New DataTable
            DelDt.Clear()
            sCommand.CommandText = "Select idLotRef From PkPdLotStock Where idPdLot ='" & idPdLot_ & "'"
            sAdapter.Fill(DelDt)

            If Not IsDBNull(DelDt.Rows(0).Item("idLotRef")) Then
                MessageBox.Show("รายการนี้ไม่สามารถลบได้  หากต้องการลบรายการนี้จะต้องไปยกเลิกรายการรับสินค้าส่วนผสมเข้าคลังก่อน", sSystemName)
                Exit Sub
            Else
                '-------- Check PkPdMixPacking: Lot using ---------'
                Dim ChkLotDt As New DataTable
                ChkLotDt.Clear()
                sCommand.CommandText = "Select idPdLot From PkPdMixPacking Where idPdLot ='" & idPdLot_ & "'"
                sAdapter.Fill(ChkLotDt)
                If ChkLotDt.Rows.Count <> 0 Then
                    '*** Lot ถูกนำไปใช้ : don't delete
                    MessageBox.Show("Lot นี้มีข้อมูลการเบิกใช้ไปแล้ว ไม่สามารถลบได้", sSystemName)
                    Exit Sub
                Else
                    '*** Lot ไม่ถูกนำไปใช้ : delete
                    sCommand.CommandText = "Delete PkPdLotStock Where idPdLot ='" & idPdLot_ & "'"
                    sCommand.ExecuteNonQuery()

                    MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", sSystemName)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If 'End Check idLotRef
        End If
    End Sub


    Private Sub txtAmtRec_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtAmtUse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub


    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    '    mdCnOpen()
    '    Dim dt As New DataTable
    '    sCommand.CommandText = "Select idPdLot, GrowRec FROM PkPdLotStock"
    '    sAdapter.Fill(dt)

    '    For i As Integer = 0 To dt.Rows.Count - 1
    '        sCommand.CommandText = "UPDATE PkPdLotStock Set GrowPaper ='" & dt.Rows(i).Item("GrowRec") & "' WHERE idPdLot='" & dt.Rows(i).Item("idPdLot") & "'"
    '        sCommand.ExecuteNonQuery()
    '    Next

    '    MessageBox.Show("success")
    'End Sub

    Private Sub txtAmtRec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub txtAmtUse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Trim(Me.txtAmtRec.Text) = "" Then
            Me.txtAmtRec.Text = 0
        End If

        If Trim(Me.txtAmtUse.Text) = "" Then
            Me.txtAmtUse.Text = 0
        End If

        Amount_ = CDbl(Me.txtAmtRec.Value) - CDbl(Me.txtAmtUse.Value)
        Me.txtAmount.Text = Format(Amount_, "#,##0.00")
    End Sub


    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim vFrm As New frmInvManageAll(frmInvManageAll.eProcess.eSelect)
    '    vFrm.ShowDialog()
    '    If vFrm.DialogResult = Windows.Forms.DialogResult.OK Then
    '        pidWhSent = vFrm.pidWhSent
    '        txtInvName.Text = vFrm.pInvNameSent
    '    End If
    'End Sub

   
    Private Sub ChkDate_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDate.CheckedChanged
        If ChkDate.Checked = True Then
            DateBookStart.Enabled = True
            DateBookEnd.Enabled = True
        Else
            DateBookStart.Enabled = False
            DateBookEnd.Enabled = False
        End If
    End Sub

    Private Sub Chk1_1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk1_1.CheckedChanged
        If Chk1_1.Checked = True Then
            Chk1_2.Checked = False
            txtGrow.Enabled = False
        Else
            If Chk1_2.Checked = False Then
                txtGrow.Enabled = True
            Else
                txtGrow.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk1_2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk1_2.CheckedChanged
        If Chk1_2.Checked = True Then
            Chk1_1.Checked = False
            txtGrow.Enabled = False
        Else
            If Chk1_1.Checked = False Then
                txtGrow.Enabled = True
            Else
                txtGrow.Enabled = False
            End If
        End If
    End Sub

    Private Sub Chk2_1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk2_1.CheckedChanged
        If Chk2_1.Checked = True Then
            Chk2_2.Checked = False
            txtGrowAggie.Enabled = False
        Else
            If Chk2_2.Checked = False Then
                txtGrowAggie.Enabled = True
            Else
                txtGrowAggie.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk2_2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk2_2.CheckedChanged
        If Chk2_2.Checked = True Then
            Chk2_1.Checked = False
            txtGrowAggie.Enabled = False
        Else
            If Chk2_1.Checked = False Then
                txtGrowAggie.Enabled = True
            Else
                txtGrowAggie.Enabled = False
            End If
        End If
    End Sub

    Private Sub Chk3_1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk3_1.CheckedChanged
        If Chk3_1.Checked = True Then
            Chk3_2.Checked = False
            txtGrowRec.Enabled = False
        Else
            If Chk3_2.Checked = False Then
                txtGrowRec.Enabled = True
            Else
                txtGrowRec.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk3_2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk3_2.CheckedChanged
        If Chk3_2.Checked = True Then
            Chk3_1.Checked = False
            txtGrowRec.Enabled = False
        Else
            If Chk3_1.Checked = False Then
                txtGrowRec.Enabled = True
            Else
                txtGrowRec.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk4_1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk4_1.CheckedChanged
        If Chk4_1.Checked = True Then
            Chk4_2.Checked = False
            txtAA.Enabled = False
        Else
            If Chk4_2.Checked = False Then
                txtAA.Enabled = True
            Else
                txtAA.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk4_2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk4_2.CheckedChanged
        If Chk4_2.Checked = True Then
            Chk4_1.Checked = False
            txtAA.Enabled = False
        Else
            If Chk4_1.Checked = False Then
                txtAA.Enabled = True
            Else
                txtAA.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk5_1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk5_1.CheckedChanged
        If Chk5_1.Checked = True Then
            Chk5_2.Checked = False
            txtTZ.Enabled = False
        Else
            If Chk5_2.Checked = False Then
                txtTZ.Enabled = True
            Else
                txtTZ.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk5_2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk5_2.CheckedChanged
        If Chk5_2.Checked = True Then
            Chk5_1.Checked = False
            txtTZ.Enabled = False
        Else
            If Chk5_1.Checked = False Then
                txtTZ.Enabled = True
            Else
                txtTZ.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk6_1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk6_1.CheckedChanged
        If Chk6_1.Checked = True Then
            Chk6_2.Checked = False
            txtPaper.Enabled = False
        Else
            If Chk6_2.Checked = False Then
                txtPaper.Enabled = True
            Else
                txtPaper.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk6_2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk6_2.CheckedChanged
        If Chk6_2.Checked = True Then
            Chk6_1.Checked = False
            txtPaper.Enabled = False
        Else
            If Chk6_1.Checked = False Then
                txtPaper.Enabled = True
            Else
                txtPaper.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk7_1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk7_1.CheckedChanged
        If Chk7_1.Checked = True Then
            Chk7_2.Checked = False
            txtSand.Enabled = False
        Else
            If Chk7_2.Checked = False Then
                txtSand.Enabled = True
            Else
                txtSand.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk7_2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk7_2.CheckedChanged
        If Chk7_2.Checked = True Then
            Chk7_1.Checked = False
            txtSand.Enabled = False
        Else
            If Chk7_1.Checked = False Then
                txtSand.Enabled = True
            Else
                txtSand.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk8_1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk8_1.CheckedChanged
        If Chk8_1.Checked = True Then
            Chk8_2.Checked = False
            txtHumid.Enabled = False
        Else
            If Chk8_2.Checked = False Then
                txtHumid.Enabled = True
            Else
                txtHumid.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk9_1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk9_1.CheckedChanged
        If Chk9_1.Checked = True Then
            Chk9_2.Checked = False
            txtHmRec.Enabled = False
        Else
            If Chk9_2.Checked = False Then
                txtHmRec.Enabled = True
            Else
                txtHmRec.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk8_2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk8_2.CheckedChanged
        If Chk8_2.Checked = True Then
            Chk8_1.Checked = False
            txtHumid.Enabled = False
        Else
            If Chk8_1.Checked = False Then
                txtHumid.Enabled = True
            Else
                txtHumid.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk9_2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk9_2.CheckedChanged
        If Chk9_2.Checked = True Then
            Chk9_1.Checked = False
            txtHmRec.Enabled = False
        Else
            If Chk9_1.Checked = False Then
                txtHmRec.Enabled = True
            Else
                txtHmRec.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk10_1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk10_1.CheckedChanged
        If Chk10_1.Checked = True Then
            Chk10_2.Checked = False
            txtPureAggieEX.Enabled = False
        Else
            If Chk10_2.Checked = False Then
                txtPureAggieEX.Enabled = True
            Else
                txtPureAggieEX.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk10_2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk10_2.CheckedChanged
        If Chk10_2.Checked = True Then
            Chk10_1.Checked = False
            txtPureAggieEX.Enabled = False
        Else
            If Chk10_1.Checked = False Then
                txtPureAggieEX.Enabled = True
            Else
                txtPureAggieEX.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk11_1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk11_1.CheckedChanged
        If Chk11_1.Checked = True Then
            Chk11_2.Checked = False
            txtPureAggie.Enabled = False
        Else
            If Chk11_2.Checked = False Then
                txtPureAggie.Enabled = True
            Else
                txtPureAggie.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk11_2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk11_2.CheckedChanged
        If Chk11_2.Checked = True Then
            Chk11_1.Checked = False
            txtPureAggie.Enabled = False
        Else
            If Chk11_1.Checked = False Then
                txtPureAggie.Enabled = True
            Else
                txtPureAggie.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk12_1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk12_1.CheckedChanged
        If Chk12_1.Checked = True Then
            Chk12_2.Checked = False
            txtPure.Enabled = False
        Else
            If Chk12_2.Checked = False Then
                txtPure.Enabled = True
            Else
                txtPure.Enabled = False
            End If

        End If
    End Sub

    Private Sub Chk12_2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk12_2.CheckedChanged
        If Chk12_2.Checked = True Then
            Chk12_1.Checked = False
            txtPure.Enabled = False
        Else
            If Chk12_1.Checked = False Then
                txtPure.Enabled = True
            Else
                txtPure.Enabled = False
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_SelectCus.Click
        'Dim frm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelect)
        'frm.StartPosition = FormStartPosition.CenterScreen
        'frm.ShowDialog()
        'If frm.DialogResult = Windows.Forms.DialogResult.OK Then
        '    txtCusName.Tag = frm.idCus
        '    txtCusName.Text = frm.CusName
        'End If

    End Sub

    Private Sub ChkDateGrow_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDateGrow.CheckedChanged
        If ChkDateGrow.Checked = True Then
            DateGrowCheck.Enabled = False
        Else
            DateGrowCheck.Enabled = True
        End If
    End Sub

    Private Sub Chk_Cus_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Cus.CheckedChanged
        If Chk_Cus.Checked = True Then
            btn_SelectCus.Enabled = True
        Else
            btn_SelectCus.Enabled = False
        End If
    End Sub

    Private Sub txtAmtRec_ValueChanged(sender As Object, e As EventArgs) Handles txtAmtRec.ValueChanged
        
        Amount_ = CDbl(Me.txtAmtRec.Value) - CDbl(Me.txtAmtUse.Value)
        Me.txtAmount.Value = Amount_
    End Sub

    Private Sub txtAmtUse_ValueChanged(sender As Object, e As EventArgs) Handles txtAmtUse.ValueChanged
        Amount_ = CDbl(Me.txtAmtRec.Value) - CDbl(Me.txtAmtUse.Value)
        Me.txtAmount.Value = Amount_
    End Sub
End Class