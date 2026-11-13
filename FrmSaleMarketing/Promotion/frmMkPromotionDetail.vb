Public Class frmMkPromotionDetail
    Dim Result As DialogResult
    Dim stLoad As Integer = 0
    Dim stPage As Integer = 0
    Dim idPro_rec As Integer = 0
    Dim stDetail As Integer = 0
    Dim eEvent As eProcess

    Enum eProcess
        eNew
        eEdit
        eview
        eCancel
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idPro As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eNew
                stPage = 1
            Case eProcess.eEdit
                stPage = 2
                idPro_rec = idPro
            Case eProcess.eview
                stPage = 3
                idPro_rec = idPro
            Case eProcess.eCancel
                stPage = 4
                idPro_rec = idPro
        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmMkPromotionDetail_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If stPage = 1 Then 'New
            cmbProType()
            Me.lblDateTs.Text = Date.Today
            Me.lblPsTs.Text = sPsName
            Me.lblPsTs.Tag = sPsId
            'Me.dtpDateS.Value = Date.Today
            'Me.dtpDateE.Value = Date.Today
        Else 'Edit + view + Cancel

            If stPage = 2 Then
                Me.Text = "แก้ไขรายละเอียดโปรโมชั่น"
            End If
            '*****Show data from SmPromotionMt******'
            mdCnOpen()
            Dim vDt As New DataTable
            vDt.Clear()
            sCommand.CommandText = "SELECT mt.ProName, mt.idProType, mt.Note, mt.idPsPro, p1.PsName As PsPro, " & _
                                   "p2.PsName As PsTs, mt.DateTs, mt.stProOpen, " & _
                                   "mt.stPdOfPro, stNoRebase, stBillPromotion " & _
                                   "FROM SmPromotionMt mt LEFT OUTER JOIN vPerson p1 ON " & _
                                   "mt.idPsPro = p1.idPs LEFT OUTER JOIN vPerson p2 ON mt.idPsTs = p2.idPs " & _
                                   "WHERE mt.idPromotion = '" & idPro_rec & "'"
            sAdapter.Fill(vDt)

            Me.txtProName.Text = vDt.Rows(0).Item("ProName")
            Me.txtNote.Text = vDt.Rows(0).Item("Note")
            Me.lblPsPmt.Text = vDt.Rows(0).Item("PsPro")
            Me.lblPsPmt.Tag = vDt.Rows(0).Item("idPsPro")
            Me.lblPsTs.Text = vDt.Rows(0).Item("PsTs")
            Me.lblDateTs.Text = ksbStringToDate(vDt.Rows(0).Item("DateTs"))

            If vDt.Rows(0).Item("stProOpen") = 0 Then
                Me.rdbOpen.Checked = True
            ElseIf vDt.Rows(0).Item("stProOpen") = 1 Then
                Me.rdbClose.Checked = True
            End If

            cmbProType()
            Me.cmbPmtType.SelectedValue = vDt.Rows(0).Item("idProType")
            Me.cmbPmtType.Enabled = False

            ''-----เงื่อนไขการคำนวณโปรโมชั่นรวม/แยกของพืชที่ผูก------'
            'If Not IsDBNull(vDt.Rows(0).Item("stConditionPd")) Then
            '    If vDt.Rows(0).Item("stConditionPd") = 0 Then
            '        Me.rdbSplit.Checked = True
            '    ElseIf vDt.Rows(0).Item("stConditionPd") = 1 Then
            '        Me.rdbSum.Checked = True
            '    End If
            'End If


            '-----สถานะการไม่รวมรีเบส--------'
            If Not IsDBNull(vDt.Rows(0).Item("stNoRebase")) Then
                If vDt.Rows(0).Item("stNoRebase") = 1 Then
                    Me.ChkStNoRebase.Checked = True
                End If
            End If


            '-----สถานะรูปแบบโปรโมชั่น------'
            If vDt.Rows(0).Item("stBillPromotion") = 0 Then
                Me.rdbBill.Checked = True
            ElseIf vDt.Rows(0).Item("stBillPromotion") = 1 Then
                Me.rdbSummary.Checked = True
                'ElseIf vDt.Rows(0).Item("stBillPromotion") = 2 Then
                '    Me.rdbMore1Y.Checked = True
                '    Me.txtYear.Text = vDt.Rows(0).Item("YearOfSum")
            End If


            If vDt.Rows(0).Item("stPdOfPro") = 0 Then 'ทั้งหมด
                Me.rdbAllPdT.Checked = True
            ElseIf vDt.Rows(0).Item("stPdOfPro") = 1 Then 'ผักซองทั้งหมด
                Me.rdbPack.Checked = True
            ElseIf vDt.Rows(0).Item("stPdOfPro") = 2 Then 'OP
                Me.rdbPack.Checked = True
                Me.ChkOP.Checked = True
                Me.ChkF1.Checked = False
            ElseIf vDt.Rows(0).Item("stPdOfPro") = 3 Then 'F1
                Me.rdbPack.Checked = True
                Me.ChkOP.Checked = False
                Me.ChkF1.Checked = True
            ElseIf vDt.Rows(0).Item("stPdOfPro") = 4 Then 'ผูกโดยใช้ idPdPk
                Me.rdbOnlyPdT.Checked = True
                '    stLoad = 1
                '    Me.rdbPdTName.Checked = True
                'ElseIf vDt.Rows(0).Item("stPdOfPro") = 5 Then 'ผูกโดยใช้ idPdN
                '    Me.rdbOnlyPdT.Checked = True
                '    Me.rdbPdName.Checked = True
                'ElseIf vDt.Rows(0).Item("stPdOfPro") = 6 Then 'ผูกโดยใช้ idPlant
                '    Me.rdbOnlyPdT.Checked = True
                '    Me.rdbPlant.Checked = True
            End If


            If vDt.Rows(0).Item("stPdOfPro") = 4 Then
                '*****Show data from SmPromotionDtPd******'
                Dim PdDt As New DataTable
                PdDt.Clear()
                'sCommand.CommandText = "SELECT a.idPdT, a.idPdN, a.idPlant, b.PdTradeName, c.PdNameTH, " & _
                '                       "d.SeedName FROM SmPromotionDtPd a LEFT OUTER JOIN " & _
                '                       "vSlPdTradeNameD b ON a.idPdT = b.idPdT " & _
                '                       "LEFT OUTER JOIN SlPdNameD c ON a.idPdN = c.idPdN " & _
                '                       "LEFT OUTER JOIN dSeed d ON a.idPlant = d.idSeed WHERE idPromotion = '" & idPro_rec & "'"

                sCommand.CommandText = "SELECT a.idPdPk, b.PdPkName, b.idPkUnit, b.PkUnitName " & _
                                       "FROM SmPromotionDtPd a LEFT OUTER JOIN " & _
                                       "vPackingPdSet b ON a.idPdPk = b.idPdPk WHERE idPromotion = '" & idPro_rec & "'"
                sAdapter.Fill(PdDt)

                For i As Integer = 0 To PdDt.Rows.Count - 1
                    DGV_PdT.Rows.Add(DGV_PdT.Rows.Count + 1, PdDt.Rows(i).Item("idPdPk"), PdDt.Rows(i).Item("PdPkName"), PdDt.Rows(i).Item("idPkUnit"), PdDt.Rows(i).Item("PkUnitName"))
                Next

                'If Me.rdbPdTName.Checked = True Then
                '    For i As Integer = 0 To PdDt.Rows.Count - 1
                '        DGV_PdT.Rows.Add(PdDt.Rows(i).Item("idPdT"), PdDt.Rows(i).Item("PdTradeName"))
                '    Next
                'ElseIf Me.rdbPdName.Checked = True Then
                '    For i As Integer = 0 To PdDt.Rows.Count - 1
                '        DGV_PdT.Rows.Add(PdDt.Rows(i).Item("idPdN"), PdDt.Rows(i).Item("PdNameTH"))
                '    Next
                'ElseIf Me.rdbPlant.Checked = True Then
                '    For i As Integer = 0 To PdDt.Rows.Count - 1
                '        DGV_PdT.Rows.Add(PdDt.Rows(i).Item("idPlant"), PdDt.Rows(i).Item("SeedName"))
                '    Next
                'E nd If
            End If


            '*****Show data from SmPromotionDt******'
            Dim sDt As New DataTable
            sDt.Clear()
            sCommand.CommandText = "SELECT dt.Price, dt.Weight, dt.idUnitW, dt.Amount, dt.idPkUnit, dt.SaleMin, " & _
                                   "dt.Salemax, dt.idInv, Inv.InvName_, dt.RewardAmount, dt.UnitReward, PriceDis FROM " & _
                                   "[GR_Group].[dbo].[SmPromotionDt] dt LEFT OUTER JOIN " & _
                                   "[PchInvAndProject].[dbo].[vInventory] inv " & _
                                   "ON dt.idInv = inv.idInv WHERE idPromotion = '" & idPro_rec & "'"
            sAdapter.Fill(sDt)

            For Each drRow As DataRow In sDt.Rows
                With DGV_ProDetail
                    Dim rc As Integer = DGV_ProDetail.RowCount - 1
                    .Rows.Add()

                    If Not IsDBNull(sDt.Rows(rc)("Price")) Then
                        Me.ChkPriceC.Checked = True
                        .Rows(rc).Cells("colPrice").Value = Format(sDt.Rows(rc)("Price"), "#,##0.##")
                    Else
                        Me.ChkPriceC.Checked = False
                    End If

                    'If Not IsDBNull(sDt.Rows(rc)("Weight")) Then
                    '    Me.ChkWeightC.Checked = True
                    '    .Rows(rc).Cells("colPk").Value = Format(sDt.Rows(rc)("Weight"), "#,##0.##")
                    '    ' .Rows(rc).Cells("ColidUnit").Value = sDt.Rows(rc)("idUnitW")
                    'Else
                    '    Me.ChkWeightC.Checked = False
                    'End If 

                    If Not IsDBNull(sDt.Rows(rc)("Amount")) Then
                        Me.ChkAmountC.Checked = True
                        .Rows(rc).Cells("ColAmount").Value = Format(sDt.Rows(rc)("Amount"), "#,##0")
                        ' .Rows(rc).Cells("ColPkUnit").Value = sDt.Rows(rc)("idPkUnit")
                    Else
                        Me.ChkAmountC.Checked = False
                    End If

                    If Not IsDBNull(sDt.Rows(rc)("SaleMin")) Then
                        If Me.cmbPmtType.SelectedValue = 1 Then 'รีเบส
                            Me.ChkBtnSale.Checked = True
                        Else
                            Me.ChkAmountC.Checked = True
                            Me.rdbBtnAmt.Checked = True
                        End If
                        .Rows(rc).Cells("colMin").Value = Format(sDt.Rows(rc)("SaleMin"), "#,##0")
                    Else
                        Me.ChkBtnSale.Checked = False
                        Me.rdbBtnAmt.Checked = False
                    End If

                    If Not IsDBNull(sDt.Rows(rc)("SaleMax")) Then
                        If sDt.Rows(rc)("SaleMax") = 0.0 Then
                            .Rows(rc).Cells("colMax").Value = Nothing
                        Else
                            .Rows(rc).Cells("colMax").Value = Format(sDt.Rows(rc)("SaleMax"), "#,##0")
                        End If
                    End If

                    If Not IsDBNull(sDt.Rows(rc)("idInv")) Then
                        .Rows(rc).Cells("ColidInv").Value = sDt.Rows(rc)("idInv")
                    End If

                    If Not IsDBNull(sDt.Rows(rc)("InvName_")) Then
                        .Rows(rc).Cells("colFree").Value = sDt.Rows(rc)("InvName_")
                    End If
                    If Not IsDBNull(sDt.Rows(rc)("RewardAmount")) Then
                        .Rows(rc).Cells("colReward").Value = Format(sDt.Rows(rc)("RewardAmount"), "#,##0")
                    End If
                    If Not IsDBNull(sDt.Rows(rc)("PriceDis")) Then
                        .Rows(rc).Cells("ColPriceDis").Value = Format(sDt.Rows(rc)("PriceDis"), "#,##0.##")
                    End If
                    If Not IsDBNull(sDt.Rows(rc)("UnitReward")) Then
                        .Rows(rc).Cells("colFreeUnit").Value = sDt.Rows(rc)("UnitReward")
                    End If

                    If Not IsDBNull(sDt.Rows(rc)("idUnitW")) Then
                        .Rows(rc).Cells("ColidUnit").Value = sDt.Rows(rc)("idUnitW")
                    End If

                    If Me.rdbPack.Checked = True Then 'Rebase ผักซอง + แผงผักซอง
                        If Not IsDBNull(sDt.Rows(rc)("idPkUnit")) Then
                            .Rows(rc).Cells("ColPkUnit").Value = "ซอง"
                            .Rows(rc).Cells("ColidPkUnit").Value = 2
                        End If
                    End If


                    If Not IsDBNull(sDt.Rows(rc)("UnitReward")) Then
                        .Rows(rc).Cells("ColUnitReward").Value = sDt.Rows(rc)("UnitReward")
                    End If


                    If Me.rdbAmtMin.Checked = False And Me.rdbBtnAmt.Checked = False Then
                        Me.ChkAmountC.Checked = False
                    End If

                End With
            Next

            If Me.rdbSummary.Checked = True Then 'แบบสะสม
                For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                    DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = 5 'Kg
                    DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = "กิโลกรัม" 'Kg
                Next
            ElseIf Me.rdbBill.Checked = True Then 'แบบรายบิล
                If rdbOnlyPdT.Checked = True Then
                    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value
                        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColPkUnitName.Name).Value
                    Next
                End If
            End If

            'Dim stDupUnit As Integer = 0
            ''-----Check idPkUnit -> Change PkUnit Promotion Detail-------'
            'For i As Integer = 1 To DGV_PdT.Rows.Count - 1
            '    If DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value <> DGV_PdT.Rows(i).Cells(ColidPkU.Name).Value Then
            '        stDupUnit = 1 'Case : Unit Not Same
            '    End If
            'Next

            'If stDupUnit = 1 Then 'Not Same
            '    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
            '        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = 5 'Kg
            '        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = "กิโลกรัม" 'Kg
            '    Next
            'ElseIf stDupUnit = 0 And DGV_PdT.Rows.Count > 0 Then 'Same
            '    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
            '        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value
            '        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColPkUnitName.Name).Value
            '    Next
            'End If

            If Me.cmbPmtType.SelectedValue = 1 Then 'Rebase
                Me.ChkBtnSale.Enabled = True
            Else 'Other
                Me.ChkBtnSale.Enabled = False
            End If

            If stPage = 3 Or stPage = 4 Then 'View + Cancel
                Me.btnSave.Visible = False
                Me.txtProName.Enabled = False
                Me.txtNote.Enabled = False
                Me.btnPsPmt.Visible = False
                Me.GroupBox2.Enabled = False
                Me.GroupBox1.Enabled = False
                Me.GroupBox4.Enabled = False
                Me.GroupBox5.Enabled = False
                Me.ChkStNoRebase.Enabled = False
                Me.DGV_ProDetail.ReadOnly = True
                Me.DGV_ProDetail.Columns("ColDelPro").Visible = False
                Me.DGV_ProDetail.AllowUserToAddRows = False
                DGV_ProDetail.Columns("ColSelect").Visible = False

                If stPage = 4 Then 'Cancel
                    Me.btnDelete.Visible = True
                    Me.Text = "ยกเลิกโปรโมชั่น"
                End If
            End If
        End If

        stDetail = 1
    End Sub

    Private Sub cmbProType()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT idProType, ProTypeName From SmPromotionType Order By idProType"
        sAdapter.Fill(sDt)

        With cmbPmtType
            .DisplayMember = "ProTypeName"
            .ValueMember = "idProType"
            .DataSource = sDt
        End With
    End Sub

    Private Sub btnSelectPdT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectPdT.Click
        Dim idCutS As New DataTable
        'idCutS.Columns.Add("fidCut", System.Type.GetType("System.Int32"))

        'For i As Integer = 0 To DGV_PdT.Rows.Count - 1
        '    idCutS.Rows.Add(Me.DGV_PdT.Rows(i).Cells(ColidPdT.Name).Value)
        'Next

        If Me.rdbPdTName.Checked = True Then
            Dim vFrm As New frmMkPromotionPdSelect(frmMkPromotionPdSelect.eProcess.ePdTName, idCutS)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                'DGV_PdT.Rows.Clear()

                Dim sDt As New DataTable
                sCommand.CommandText = "SELECT idPdPk, PdPkName, idPkUnit, PkUnitName From vPackingPdSet " & _
                                       "WHERE idType <> 1 AND idPdT = " & vFrm.idSentBack & ""
                sAdapter.Fill(sDt)

                For i As Integer = 0 To sDt.Rows.Count - 1
                    'Check ซ้ำ
                    Dim stDup As Integer = 0
                    For j As Integer = 0 To DGV_PdT.Rows.Count - 1
                        If sDt.Rows(i).Item("idPdPk") = DGV_PdT.Rows(j).Cells(ColidPdT.Name).Value Then
                            stDup = 1
                        End If
                    Next

                    If stDup = 0 Then
                        DGV_PdT.Rows.Add(DGV_PdT.Rows.Count + 1, sDt.Rows(i).Item("idPdPk"), sDt.Rows(i).Item("PdPkName"), sDt.Rows(i).Item("idPkUnit"), sDt.Rows(i).Item("PkUnitName"))
                    End If
                Next

                'Dim stDupUnit As Integer = 0
                ''-----Check idPkUnit -> Change PkUnit Promotion Detail-------'
                'For i As Integer = 1 To DGV_PdT.Rows.Count - 1
                '    If DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value <> DGV_PdT.Rows(i).Cells(ColidPkU.Name).Value Then
                '        stDupUnit = 1 'Case : Unit Not Same
                '    End If
                'Next

                'If stDupUnit = 1 Then 'Not Same
                '    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                '        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = 5 'Kg
                '        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = "กิโลกรัม" 'Kg
                '    Next
                'ElseIf stDupUnit = 0 And DGV_PdT.Rows.Count > 0 Then 'Same
                '    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                '        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value
                '        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColPkUnitName.Name).Value
                '    Next
                'End If

            End If
        ElseIf Me.rdbPdName.Checked = True Then
            Dim vFrm As New frmMkPromotionPdSelect(frmMkPromotionPdSelect.eProcess.ePdName, idCutS)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                'DGV_PdT.Rows.Clear()

                Dim sDt As New DataTable
                sCommand.CommandText = "SELECT pk.idPdPk, pk.PdPkName, pk.idPkUnit, pk.PkUnitName " & _
                                       "From vPackingPdSet pk LEFT OUTER JOIN " & _
                                       "vSlPdTradeNameD pd ON pk.idPdT = pd.idPdT " & _
                                       "WHERE pk.idType <> 1 AND pd.idPdN = " & vFrm.idSentBack & ""
                sAdapter.Fill(sDt)

                For i As Integer = 0 To sDt.Rows.Count - 1
                    'Check ซ้ำ
                    Dim stDup As Integer = 0
                    For j As Integer = 0 To DGV_PdT.Rows.Count - 1
                        If sDt.Rows(i).Item("idPdPk") = DGV_PdT.Rows(j).Cells(ColidPdT.Name).Value Then
                            stDup = 1
                        End If
                    Next

                    If stDup = 0 Then
                        DGV_PdT.Rows.Add(DGV_PdT.Rows.Count + 1, sDt.Rows(i).Item("idPdPk"), sDt.Rows(i).Item("PdPkName"), sDt.Rows(i).Item("idPkUnit"), sDt.Rows(i).Item("PkUnitName"))
                    End If
                Next

                'Dim stDupUnit As Integer = 0
                ''-----Check idPkUnit -> Change PkUnit Promotion Detail-------'
                'For i As Integer = 1 To DGV_PdT.Rows.Count - 1
                '    If DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value <> DGV_PdT.Rows(i).Cells(ColidPkU.Name).Value Then
                '        stDupUnit = 1 'Case : Unit Not Same
                '    End If
                'Next

                'If stDupUnit = 1 Then 'Not Same
                '    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                '        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = 5 'Kg
                '        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = "กิโลกรัม" 'Kg
                '    Next
                'ElseIf stDupUnit = 0 And DGV_PdT.Rows.Count > 0 Then 'Same
                '    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                '        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value
                '        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColPkUnitName.Name).Value
                '    Next
                'End If

            End If
        ElseIf Me.rdbPlant.Checked = True Then
            Dim vFrm As New frmMkPromotionPdSelect(frmMkPromotionPdSelect.eProcess.ePlant, idCutS)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                ' DGV_PdT.Rows.Clear()

                Dim sDt As New DataTable
                sCommand.CommandText = "SELECT pk.idPdPk, pk.PdPkName, pk.idPkUnit, pk.PkUnitName " & _
                                       "From vPackingPdSet pk LEFT OUTER JOIN " & _
                                       "vSlPdTradeNameD pd ON pk.idPdT = pd.idPdT " & _
                                       "WHERE pk.idType <> 1 AND pd.idPlant = " & vFrm.idSentBack & ""
                sAdapter.Fill(sDt)

                For i As Integer = 0 To sDt.Rows.Count - 1
                    'Check ซ้ำ
                    Dim stDup As Integer = 0
                    For j As Integer = 0 To DGV_PdT.Rows.Count - 1
                        If sDt.Rows(i).Item("idPdPk") = DGV_PdT.Rows(j).Cells(ColidPdT.Name).Value Then
                            stDup = 1
                        End If
                    Next

                    If stDup = 0 Then
                        DGV_PdT.Rows.Add(DGV_PdT.Rows.Count + 1, sDt.Rows(i).Item("idPdPk"), sDt.Rows(i).Item("PdPkName"), sDt.Rows(i).Item("idPkUnit"), sDt.Rows(i).Item("PkUnitName"))
                    End If
                Next

                'Dim stDupUnit As Integer = 0
                ''-----Check idPkUnit -> Change PkUnit Promotion Detail-------'
                'For i As Integer = 1 To DGV_PdT.Rows.Count - 1
                '    If DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value <> DGV_PdT.Rows(i).Cells(ColidPkU.Name).Value Then
                '        stDupUnit = 1 'Case : Unit Not Same
                '    End If
                'Next

                'If stDupUnit = 1 Then 'Not Same
                '    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                '        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = 5 'Kg
                '        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = "กิโลกรัม" 'Kg
                '    Next
                'ElseIf stDupUnit = 0 And DGV_PdT.Rows.Count > 0 Then 'Same
                '    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                '        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value
                '        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColPkUnitName.Name).Value
                '    Next
                'End If

            End If
        ElseIf Me.rdbPdPk.Checked = True Then
            Dim vFrm As New frmMkPromotionPdSelect(frmMkPromotionPdSelect.eProcess.ePdPk, idCutS)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

                'Check ซ้ำ
                Dim stDup As Integer = 0
                For j As Integer = 0 To DGV_PdT.Rows.Count - 1
                    If vFrm.idSentBack = DGV_PdT.Rows(j).Cells(ColidPdT.Name).Value Then
                        stDup = 1
                    End If
                Next

                If stDup = 0 Then
                    DGV_PdT.Rows.Add(DGV_PdT.Rows.Count + 1, vFrm.idSentBack, vFrm.PdPkName, vFrm.idPkUnit, vFrm.PkUnitName)
                End If

                'Dim stDupUnit As Integer = 0
                ''-----Check idPkUnit -> Change PkUnit Promotion Detail-------'
                'For i As Integer = 1 To DGV_PdT.Rows.Count - 1
                '    If DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value <> DGV_PdT.Rows(i).Cells(ColidPkU.Name).Value Then
                '        stDupUnit = 1 'Case : Unit Not Same
                '    End If
                'Next

                'If stDupUnit = 1 Then 'Not Same
                '    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                '        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = 5 'Kg
                '        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = "กิโลกรัม" 'Kg
                '    Next
                'ElseIf stDupUnit = 0 And DGV_PdT.Rows.Count > 0 Then 'Same
                '    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                '        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value
                '        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColPkUnitName.Name).Value
                '    Next
                'End If


            End If
        End If


    End Sub


    Private Sub rdbPack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPack.CheckedChanged
        If Me.rdbPack.Checked = True Then
            Me.GroupBox3.Enabled = True
            Me.ChkOP.Checked = True
            Me.ChkF1.Checked = True
            If Me.cmbPmtType.SelectedValue = 1 Then
                Me.ChkBtnSale.Checked = False
                'Me.ChkBtnSale.Enabled = False
                Me.ChkAmountC.Checked = True
                Me.rdbAmtMin.Checked = True
            End If
        Else
            Me.GroupBox3.Enabled = False
            Me.ChkOP.Checked = False
            Me.ChkF1.Checked = False
        End If
    End Sub


    Private Sub rdbOnlyPdT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbOnlyPdT.CheckedChanged
        If Me.rdbOnlyPdT.Checked = True Then
            Me.btnSelectPdT.Enabled = True
            Me.DGV_PdT.Enabled = True
            Me.GroupBox7.Enabled = True
            'Me.GroupBox8.Enabled = True
            Me.rdbPdPk.Checked = True
            ' Me.rdbSplit.Checked = True
        Else
            Me.rdbPdTName.Checked = False
            Me.rdbPdName.Checked = False
            Me.rdbPlant.Checked = False
            ' Me.rdbSplit.Checked = False
            ' Me.rdbSum.Checked = False
            Me.btnSelectPdT.Enabled = False
            Me.DGV_PdT.Enabled = False
            Me.GroupBox7.Enabled = False
            ' Me.GroupBox8.Enabled = False
            DGV_PdT.Rows.Clear()
        End If
    End Sub

    Private Sub cmbPmtType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPmtType.SelectedIndexChanged
        DGV_ProDetail.Rows.Clear()
        ClearDGV_ProDetail()
        If Me.cmbPmtType.SelectedValue = 1 Then 'คืนเงินปลายปี
            Me.ChkBtnSale.Checked = True
            If Me.rdbAllPdT.Checked = True Then
                Me.ChkBtnSale.Checked = True
            ElseIf Me.rdbPack.Checked = True Then
                Me.ChkAmountC.Checked = True
                Me.rdbBtnAmt.Checked = True
            End If
            Me.ChkPriceC.Enabled = True
            DGV_ProDetail.Columns("ColReward").Visible = True
            DGV_ProDetail.Columns("ColReward").HeaderText = "เงินคืนปลายปี (%)"
            'DGV_ProDetail.Columns("ColSelect").Visible = False
        ElseIf Me.cmbPmtType.SelectedValue = 2 Then 'โปรโมชั่นทอง
            Me.ChkBtnSale.Checked = False
            Me.ChkBtnSale.Enabled = False
            'Me.ChkWeightC.Checked = True
            Me.ChkAmountC.Checked = True
            Me.ChkPriceC.Enabled = True
            Me.ChkBtnSale.Checked = False

            ''---ADD UnitW---'
            'Dim combo As DataGridViewComboBoxCell = DGV_ProDetail.Rows(0).Cells("ColidUnit")
            'mdCnOpen()
            'Dim sDt As New DataTable
            'sCommand.CommandText = "Select idUnitW, UnitW From dUnitW"

            'sAdapter.Fill(sDt)
            'combo.DisplayMember = "UnitW"
            'combo.ValueMember = "idUnitW"
            'combo.DataSource = sDt
            'combo.Value = 1

            'DGV_ProDetail.Columns("ColAmount").Visible = True
            'DGV_ProDetail.Columns("ColAmount").HeaderText = "จำนวนซื้อ"
            'DGV_ProDetail.Columns("ColPkUnit").Visible = True

            ''---ADD PkUnit---'
            'Dim combo2 As DataGridViewComboBoxCell = DGV_ProDetail.Rows(0).Cells("ColPkUnit")
            'Dim sDt2 As New DataTable
            'sCommand.CommandText = "Select idPkUnit, PkUnitName From dPackingUnit WHERE idPkUnit <> 7"

            'sAdapter.Fill(sDt2)
            'combo2.DisplayMember = "PkUnitName"
            'combo2.ValueMember = "idPkUnit"
            'combo2.DataSource = sDt2
            'combo2.Value = 1

            DGV_ProDetail.Columns("ColSelect").Visible = True
            DGV_ProDetail.Columns("ColFree").Visible = True
            DGV_ProDetail.Columns("ColReward").Visible = True
            DGV_ProDetail.Columns("ColReward").HeaderText = "จำนวนแถม"
            'DGV_ProDetail.Columns("ColUnitReward").Visible = False
            'DGV_ProDetail.Columns("ColFreeUnit").Visible = False

        ElseIf Me.cmbPmtType.SelectedValue = 3 Then 'โปรโมชั่นแถมสินค้า
            Me.ChkBtnSale.Checked = False
            Me.ChkBtnSale.Enabled = False
            Me.ChkPriceC.Checked = True
            Me.ChkPriceC.Enabled = True
            Me.ChkAmountC.Checked = True
            Me.ChkBtnSale.Checked = False

            ''---ADD PkUnit---'
            'Dim combo2 As DataGridViewComboBoxCell = DGV_ProDetail.Rows(0).Cells("ColPkUnit")
            'Dim sDt2 As New DataTable
            'sCommand.CommandText = "Select idPkUnit, PkUnitName From dPackingUnit WHERE idPkUnit <> 7 AND " & _
            '                       "idPkUnit <> 5 AND idPkUnit <> 3"

            'sAdapter.Fill(sDt2)
            'combo2.DisplayMember = "PkUnitName"
            'combo2.ValueMember = "idPkUnit"
            'combo2.DataSource = sDt2

            DGV_ProDetail.Columns("ColReward").Visible = True
            DGV_ProDetail.Columns("ColReward").HeaderText = "จำนวนที่แถม"
            DGV_ProDetail.Columns("ColUnitReward").Visible = True
        ElseIf Me.cmbPmtType.SelectedValue = 4 Then 'โปรโมชั่นแถม(ของแถมไม่ใช่สินค้า)
            Me.ChkBtnSale.Checked = False
            Me.ChkBtnSale.Enabled = False
            Me.ChkPriceC.Enabled = True
            'Me.ChkWeightC.Checked = True
            Me.ChkAmountC.Checked = True
            Me.ChkBtnSale.Checked = False

            ''---ADD UnitW---'
            'Dim combo As DataGridViewComboBoxCell = DGV_ProDetail.Rows(0).Cells("ColidUnit")
            'mdCnOpen()
            'Dim sDt As New DataTable
            'sCommand.CommandText = "Select idUnitW, UnitW From dUnitW"

            'sAdapter.Fill(sDt)
            'combo.DisplayMember = "UnitW"
            'combo.ValueMember = "idUnitW"
            'combo.DataSource = sDt
            'combo.Value = 1

            ''---ADD PkUnit---'
            'Dim combo2 As DataGridViewComboBoxCell = DGV_ProDetail.Rows(0).Cells("ColPkUnit")
            'Dim sDt2 As New DataTable
            'sCommand.CommandText = "Select idPkUnit, PkUnitName From dPackingUnit WHERE idPkUnit <> 7"

            'sAdapter.Fill(sDt2)
            'combo2.DisplayMember = "PkUnitName"
            'combo2.ValueMember = "idPkUnit"
            'combo2.DataSource = sDt2

            DGV_ProDetail.Columns("ColSelect").Visible = True
            DGV_ProDetail.Columns("ColFree").Visible = True
            DGV_ProDetail.Columns("ColFree").HeaderText = "ของแถม"
            DGV_ProDetail.Columns("ColReward").Visible = True
            DGV_ProDetail.Columns("ColReward").HeaderText = "จำนวนของแถม"
            'DGV_ProDetail.Columns("ColUnitReward").Visible = False
            '  DGV_ProDetail.Columns("ColFreeUnit").Visible = True
        ElseIf Me.cmbPmtType.SelectedValue = 5 Then 'แถมแผงผักซอง
            Me.ChkBtnSale.Checked = False
            Me.ChkBtnSale.Enabled = False
            Me.ChkPriceC.Enabled = True
            Me.ChkAmountC.Checked = True
            Me.rdbBtnAmt.Checked = True

            DGV_ProDetail.Columns("ColSelect").Visible = True
            DGV_ProDetail.Columns("ColFree").Visible = True
            DGV_ProDetail.Columns("ColFree").HeaderText = "ของแถม"
            ' DGV_ProDetail.Rows(0).Cells("ColFree").Value = "แผงผักซอง"
            DGV_ProDetail.Columns("ColReward").Visible = True
            DGV_ProDetail.Columns("ColReward").HeaderText = "จำนวนของแถม"
            ' DGV_ProDetail.Columns("ColFreeUnit").Visible = True
            'DGV_ProDetail.Rows(0).Cells("ColFreeUnit").Value = "แผง"
        ElseIf Me.cmbPmtType.SelectedValue = 6 Then 'ราคาขาย
            Me.ChkPriceC.Enabled = False
            Me.ChkBtnSale.Enabled = False
            'Me.ChkWeightC.Checked = True
            Me.ChkAmountC.Checked = True
            Me.ChkBtnSale.Checked = False
            DGV_ProDetail.Columns("ColPriceDis").Visible = True
            'DGV_ProDetail.Columns("ColUnitReward").Visible = True
            ' DGV_ProDetail.Columns("ColUnitReward").HeaderText = "ราคาต่อหน่วย"


        End If
    End Sub

    Sub ClearDGV_ProDetail()
        DGV_ProDetail.Columns("ColPrice").Visible = False
        DGV_ProDetail.Columns("ColPk").Visible = False
        DGV_ProDetail.Columns("ColidUnit").Visible = False
        DGV_ProDetail.Columns("ColAmount").Visible = False
        DGV_ProDetail.Columns("ColPkUnit").Visible = False
        DGV_ProDetail.Columns("ColMin").Visible = False
        DGV_ProDetail.Columns("ColMax").Visible = False
        DGV_ProDetail.Columns("ColFree").Visible = False
        DGV_ProDetail.Columns("ColReward").Visible = False
        DGV_ProDetail.Columns("ColUnitReward").Visible = False
        DGV_ProDetail.Columns("ColFreeUnit").Visible = False
        DGV_ProDetail.Columns("ColPriceDis").Visible = False
        DGV_ProDetail.Columns("ColSelect").Visible = False

        Me.ChkAmountC.Checked = False
        Me.ChkPriceC.Checked = False
        'Me.ChkWeightC.Checked = False
        Me.ChkBtnSale.Checked = False

    End Sub

    Private Sub DGV_ProDetail_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_ProDetail.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        '------------Select Premium-------------'
        If DGV_ProDetail.Columns(e.ColumnIndex).Name = Me.ColSelect.Name Then
            Dim vFrm As New frmMkPromotionPremium
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                DGV_ProDetail.Rows(e.RowIndex).Cells("ColidInv").Value = vFrm.idInvN
                DGV_ProDetail.Rows(e.RowIndex).Cells("ColFree").Value = vFrm.InvName

            End If


        End If

        '------------Delete Pd in Grid-------------'
        If DGV_ProDetail.Columns(e.ColumnIndex).Name = Me.ColDelPro.Name Then
            Result = MsgBox("คุณต้องการลบเงื่อนไขโปรโมชั่นนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
            If Result = Windows.Forms.DialogResult.Yes Then
                If e.RowIndex < DGV_ProDetail.Rows.Count - 1 Then
                    DGV_ProDetail.Rows.Remove(DGV_ProDetail.Rows(e.RowIndex))
                End If

            End If
        End If

    End Sub

    Private Sub DGV_ProDetail_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_ProDetail.CellEndEdit

        '----Chang Format-----'
        If DGV_ProDetail.Columns(e.ColumnIndex).Name = Me.ColMin.Name Then
            If DGV_ProDetail.Rows(e.RowIndex).Cells("ColMin").Value <> "" Then
                Dim vMin As Double = DGV_ProDetail.Rows(e.RowIndex).Cells("ColMin").Value
                DGV_ProDetail.Rows(e.RowIndex).Cells("ColMin").Value = Format(vMin, "#,##0")
            End If
        End If

        If DGV_ProDetail.Columns(e.ColumnIndex).Name = Me.ColMax.Name Then
            If DGV_ProDetail.Rows(e.RowIndex).Cells("ColMax").Value <> "" Then
                Dim vMax As Double = DGV_ProDetail.Rows(e.RowIndex).Cells("ColMax").Value
                DGV_ProDetail.Rows(e.RowIndex).Cells("ColMax").Value = Format(vMax, "#,##0")
            End If
        End If

        If DGV_ProDetail.Columns(e.ColumnIndex).Name = Me.ColReward.Name Then
            If DGV_ProDetail.Rows(e.RowIndex).Cells("ColReward").Value <> "" Then
                Dim vReward As Double = DGV_ProDetail.Rows(e.RowIndex).Cells("ColReward").Value
                DGV_ProDetail.Rows(e.RowIndex).Cells("ColReward").Value = Format(vReward, "#,##0.##")
            End If
        End If

        If DGV_ProDetail.Columns(e.ColumnIndex).Name = Me.ColPk.Name Then
            If DGV_ProDetail.Rows(e.RowIndex).Cells("ColPk").Value <> "" Then
                Dim vPk As Double = DGV_ProDetail.Rows(e.RowIndex).Cells("ColPk").Value
                DGV_ProDetail.Rows(e.RowIndex).Cells("ColPk").Value = Format(vPk, "#,##0")
            End If
        End If

        If DGV_ProDetail.Columns(e.ColumnIndex).Name = Me.ColAmount.Name Then
            If DGV_ProDetail.Rows(e.RowIndex).Cells("ColAmount").Value <> "" Then
                Dim vAmount As Double = DGV_ProDetail.Rows(e.RowIndex).Cells("ColAmount").Value
                DGV_ProDetail.Rows(e.RowIndex).Cells("ColAmount").Value = Format(vAmount, "#,##0")
            End If
        End If

        If DGV_ProDetail.Columns(e.ColumnIndex).Name = Me.ColPrice.Name Then
            If DGV_ProDetail.Rows(e.RowIndex).Cells("ColPrice").Value <> "" Then
                Dim vPrice As Double = DGV_ProDetail.Rows(e.RowIndex).Cells("ColPrice").Value
                DGV_ProDetail.Rows(e.RowIndex).Cells("ColPrice").Value = Format(vPrice, "#,##0.##")
            End If
        End If

        If DGV_ProDetail.Columns(e.ColumnIndex).Name = Me.ColPriceDis.Name Then
            If DGV_ProDetail.Rows(e.RowIndex).Cells("ColPriceDis").Value <> "" Then
                Dim vPriceDis As Double = DGV_ProDetail.Rows(e.RowIndex).Cells("ColPriceDis").Value
                DGV_ProDetail.Rows(e.RowIndex).Cells("ColPriceDis").Value = Format(vPriceDis, "#,##0.##")
            End If
        End If

    End Sub

    Private Sub DGV_ProDetail_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV_ProDetail.EditingControlShowing
        With Me.DGV_ProDetail
            If .CurrentCell.OwningColumn.Name = ColMin.Name Then
                Dim tb As TextBox = CType(e.Control, TextBox)
                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If

            If .CurrentCell.OwningColumn.Name = ColMax.Name Then
                Dim tb As TextBox = CType(e.Control, TextBox)
                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If

            If .CurrentCell.OwningColumn.Name = ColReward.Name Then
                Dim tb As TextBox = CType(e.Control, TextBox)
                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If

            If .CurrentCell.OwningColumn.Name = ColPk.Name Then
                Dim tb As TextBox = CType(e.Control, TextBox)
                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If

            If .CurrentCell.OwningColumn.Name = ColAmount.Name Then
                Dim tb As TextBox = CType(e.Control, TextBox)
                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If

            If .CurrentCell.OwningColumn.Name = ColPrice.Name Then
                Dim tb As TextBox = CType(e.Control, TextBox)
                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If

            If .CurrentCell.OwningColumn.Name = ColPriceDis.Name Then
                Dim tb As TextBox = CType(e.Control, TextBox)
                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If

        End With
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Me.DGV_ProDetail.CurrentCell.OwningColumn.Name = ColMin.Name Then
            If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If

        If Me.DGV_ProDetail.CurrentCell.OwningColumn.Name = ColMax.Name Then
            If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If

        If Me.DGV_ProDetail.CurrentCell.OwningColumn.Name = ColReward.Name Then
            If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If

        If Me.DGV_ProDetail.CurrentCell.OwningColumn.Name = ColPk.Name Then 'No Dot
            If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Or Asc(e.KeyChar) = 46 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If

        If Me.DGV_ProDetail.CurrentCell.OwningColumn.Name = ColAmount.Name Then
            If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Or Asc(e.KeyChar) = 46 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If

        If Me.DGV_ProDetail.CurrentCell.OwningColumn.Name = ColPrice.Name Then
            If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If

        If Me.DGV_ProDetail.CurrentCell.OwningColumn.Name = ColPriceDis.Name Then
            If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If

    End Sub


    Private Sub DGV_ProDetail_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DGV_ProDetail.RowsAdded

        If stDetail = 1 Then
            If Me.rdbSummary.Checked = True Then 'แบบสะสม
                For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                    DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = 5 'Kg
                    DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = "กิโลกรัม" 'Kg
                Next
            ElseIf Me.rdbBill.Checked = True Then 'แบบรายบิล
                For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                    DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value
                    DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColPkUnitName.Name).Value
                Next
            End If
        End If

        'Dim stDupUnit As Integer = 0
        ''-----Check idPkUnit -> Change PkUnit Promotion Detail-------'
        'For i As Integer = 1 To DGV_PdT.Rows.Count - 1
        '    If DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value <> DGV_PdT.Rows(i).Cells(ColidPkU.Name).Value Then
        '        stDupUnit = 1 'Case : Unit Not Same
        '    End If
        'Next

        'If stDupUnit = 1 Then 'Not Same
        '    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
        '        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = 5 'Kg
        '        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = "กิโลกรัม" 'Kg
        '    Next
        'ElseIf stDupUnit = 0 And DGV_PdT.Rows.Count > 0 Then 'Same
        '    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
        '        If DGV_PdT.Rows.Count > 0 Then
        '            DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value
        '            DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColPkUnitName.Name).Value
        '        End If
        '    Next
        'End If

        'If Me.rdbAmtMin.Checked = True Or Me.rdbBtnAmt.Checked = True Then
        '    '---ADD PkUnit---'
        '    mdCnOpen()
        '    Dim combo2 As DataGridViewComboBoxCell = DGV_ProDetail.Rows(e.RowIndex).Cells("ColPkUnit")
        '    Dim sDt2 As New DataTable
        '    sCommand.CommandText = "Select idPkUnit, PkUnitName From dPackingUnit WHERE idPkUnit <> 7"

        '    sAdapter.Fill(sDt2)
        '    combo2.DisplayMember = "PkUnitName"
        '    combo2.ValueMember = "idPkUnit"
        '    combo2.DataSource = sDt2
        '    If Me.cmbPmtType.SelectedValue = 5 Then
        '        combo2.Value = 2
        '    Else
        '        combo2.Value = 1
        '    End If

        'End If

        'If Me.rdbBtnAmt.Checked = True Or Me.rdbBtnAmt.Checked = True Then
        '    '---ADD PkUnit---'
        '    mdCnOpen()
        '    Dim combo2 As DataGridViewComboBoxCell = DGV_ProDetail.Rows(e.RowIndex).Cells("ColPkUnit")
        '    Dim sDt2 As New DataTable
        '    sCommand.CommandText = "Select idPkUnit, PkUnitName From dPackingUnit WHERE idPkUnit <> 7"

        '    sAdapter.Fill(sDt2)
        '    combo2.DisplayMember = "PkUnitName"
        '    combo2.ValueMember = "idPkUnit"
        '    combo2.DataSource = sDt2
        '    If Me.cmbPmtType.SelectedValue = 5 Then
        '        combo2.Value = 2
        '    Else
        '        combo2.Value = 1
        '    End If

        'End If

        'If Me.ChkWeightC.Checked = True Then
        '    '---ADD UnitW---'
        '    Dim combo As DataGridViewComboBoxCell = DGV_ProDetail.Rows(e.RowIndex).Cells("ColidUnit")
        '    mdCnOpen()
        '    Dim sDt As New DataTable
        '    sCommand.CommandText = "Select idUnitW, UnitW From dUnitW"

        '    sAdapter.Fill(sDt)
        '    combo.DisplayMember = "UnitW"
        '    combo.ValueMember = "idUnitW"
        '    combo.DataSource = sDt
        '    combo.Value = 1
        'End If



        If Me.cmbPmtType.SelectedValue = 2 Then 'โปรโมชั่นทอง
            ''---ADD GoldUnit---'
            'Dim combo3 As DataGridViewComboBoxCell = DGV_ProDetail.Rows(e.RowIndex).Cells("ColUnitReward")
            'Dim sDt3 As New DataTable
            ''sDt3.Columns.Add("idRewardUnit", System.Type.GetType("System.String"))
            'sDt3.Columns.Add("RewardUnitName", System.Type.GetType("System.String"))

            'sDt3.Rows.Add("บาท")
            'sDt3.Rows.Add("สลึง")

            'combo3.DisplayMember = "RewardUnitName"
            'combo3.ValueMember = "RewardUnitName"
            'combo3.DataSource = sDt3
            'combo3.Value = "บาท"
        ElseIf Me.cmbPmtType.SelectedValue = 3 Then 'โปรโมชั่นแถมสินค้า
            '---ADD PkUnitReward---'
            Dim combo3 As DataGridViewComboBoxCell = DGV_ProDetail.Rows(e.RowIndex).Cells("ColUnitReward")
            Dim sDt3 As New DataTable
            sCommand.CommandText = "Select PkUnitName As RewardUnitName " & _
                                   "From dPackingUnit WHERE idPkUnit <> 7 AND idPkUnit <> 3 AND idPkUnit <> 5"
            sAdapter.Fill(sDt3)

            combo3.DisplayMember = "RewardUnitName"
            combo3.ValueMember = "RewardUnitName"
            combo3.DataSource = sDt3
            combo3.Value = "กระป๋อง"
        ElseIf Me.cmbPmtType.SelectedValue = 5 Then 'แถมแผงผักซอง
            DGV_ProDetail.Rows(e.RowIndex).Cells(ColidPkUnit.Name).Value = 2
            DGV_ProDetail.Rows(e.RowIndex).Cells(ColPkUnit.Name).Value = "ซอง"


            ' DGV_ProDetail.Rows(e.RowIndex).Cells("ColFree").Value = "แผงผักซอง"
            '  DGV_ProDetail.Rows(e.RowIndex).Cells("ColFreeUnit").Value = "แผง"
        ElseIf Me.cmbPmtType.SelectedValue = 6 Then 'ราคาขาย
            Dim combo3 As DataGridViewComboBoxCell = DGV_ProDetail.Rows(e.RowIndex).Cells("ColUnitReward")
            Dim sDt3 As New DataTable
            sCommand.CommandText = "Select PkUnitName As RewardUnitName " & _
                                   "From dPackingUnit WHERE idPkUnit <> 7"
            sAdapter.Fill(sDt3)

            combo3.DisplayMember = "RewardUnitName"
            combo3.ValueMember = "RewardUnitName"
            combo3.DataSource = sDt3
            combo3.Value = "กิโลกรัม"

        End If
    End Sub

    Private Sub btnPsPmt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPsPmt.Click
        Dim vFrm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPsPmt.Tag = vFrm.mId
            Me.lblPsPmt.Text = vFrm.mName
        End If
    End Sub

    Private Sub DGV_PdT_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_PdT.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        '------------Delete Pd in Grid-------------'
        If DGV_PdT.Columns(e.ColumnIndex).Name = Me.ColDel.Name Then
            DGV_PdT.Rows.Remove(DGV_PdT.CurrentRow)

            For i As Integer = 0 To DGV_PdT.Rows.Count - 1
                DGV_PdT.Rows(i).Cells("ColNum").Value = i + 1
            Next
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        mdLoadShow()
        If Me.txtProName.Text = "" Then
            mdLoadCommitt()
            MessageBox.Show("กรุณาระบุชื่อโปรโมชั่น", sSystemName)
            Me.txtProName.Focus()
            Exit Sub
        ElseIf Me.lblPsPmt.Text = "" Then
            mdLoadCommitt()
            MessageBox.Show("กรุณาระบุผู้กำหนดโปรโมชั่น", sSystemName)
            Me.btnPsPmt.Focus()
            Exit Sub
        ElseIf Me.rdbOnlyPdT.Checked = True And DGV_PdT.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("กรุณาเลือกรายการสินค้าที่ต้องการผูกกับโปรโมชั่นอย่างน้อย 1 รายการ", sSystemName)
            Exit Sub
        ElseIf Me.DGV_ProDetail.Rows.Count = 1 Then
            mdLoadCommitt()
            MessageBox.Show("กรุณาระบุเงื่อนไขของโปรโมชั่นอย่างน้อย 1 เงื่อนไข", sSystemName)
            Exit Sub
        Else 'ข้อมูลครบแล้ว -------> Save

            If stPage = 1 Then 'New
                AddSmPromotionMt()
                mdLoadCommitt()
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName)
            ElseIf stPage = 2 Then 'Edit
                UPDATESmPromotionMt()
                mdLoadCommitt()
                MessageBox.Show("บันทึกการแก้ไขข้อมูลเรียบร้อยแล้ว", sSystemName)
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Sub AddSmPromotionMt()
        '-----สถานะเปิด-ปิดการใช้โปร------'
        Dim vStOpen As Integer = 0
        If Me.rdbOpen.Checked = True Then
            vStOpen = 0
        ElseIf Me.rdbClose.Checked = True Then
            vStOpen = 1 'Close     
        End If

        '-----สถานะการผูกกับสินค้า------'
        Dim vStPdOfPro As Integer = 0
        If Me.rdbAllPdT.Checked = True Then
            vStPdOfPro = 0
        ElseIf Me.rdbPack.Checked = True Then 'ผักซอง
            If Me.ChkF1.Checked = True And Me.ChkOP.Checked = True Then 'OP+F1
                vStPdOfPro = 1
            ElseIf Me.ChkF1.Checked = False And Me.ChkOP.Checked = True Then 'F1
                vStPdOfPro = 2
            ElseIf Me.ChkF1.Checked = True And Me.ChkOP.Checked = False Then 'OP
                vStPdOfPro = 3
            End If
        ElseIf Me.rdbOnlyPdT.Checked = True Then 'บางรายการที่ระบุ
            vStPdOfPro = 4 'idPdPk

            'If Me.rdbPdTName.Checked = True Then
            '    vStPdOfPro = 4
            'ElseIf Me.rdbPdName.Checked = True Then
            '    vStPdOfPro = 5
            'ElseIf Me.rdbPlant.Checked = True Then
            '    vStPdOfPro = 6
            'End If
        End If

        ''-----สถานะคำนวณเงื่อนไขของสินค้า------'
        'Dim vStConditionPd As String = ""
        'If Me.rdbSplit.Checked = True Then
        '    vStConditionPd = "0"
        'ElseIf Me.rdbSum.Checked = True Then
        '    vStConditionPd = "1"
        'Else
        '    vStConditionPd = " Null"
        'End If

        '-----สถานะ Promotion กับ บิล------'
        Dim vStBillPromotion As Integer = 0
        If Me.rdbBill.Checked = True Then
            vStBillPromotion = 0
        ElseIf Me.rdbSummary.Checked = True Then
            vStBillPromotion = 1
        End If

        '----จำนวนปีที่สะสมโปรโมชั่น--------'
        'Dim vYear As String = ""
        'If Me.rdbMore1Y.Checked = True Then
        '    vYear = Me.txtYear.Text
        'Else
        '    vYear = " NULL"
        'End If

        '-----สถานะรีเบส -------------'
        Dim vStNoRebase As String = ""
        If Me.ChkStNoRebase.Checked = True Then
            vStNoRebase = "1" 'No Rebase
        Else
            vStNoRebase = " NULL"
        End If

        ''-----สถานะคำนวณเงื่อนไขของสินค้า------'
        'Dim vStPdLayer As String = ""
        'If Me.rdbPdTName.Checked = True Then
        '    vStPdLayer = "0"
        'ElseIf Me.rdbPdName.Checked = True Then
        '    vStPdLayer = "1"
        'ElseIf Me.rdbPlant.Checked = True Then
        '    vStPdLayer = "2"
        'Else
        '    vStPdLayer = " Null"
        'End If


        mdCnOpen()
        '---insert SmPromotionMt Table---'
        Dim query As String = "Insert Into SmPromotionMt(ProName, idProType, idPsPro, stProOpen, " & _
                              "stPdOfPro, idPsTs, DateTs, Note, idComp, stBillPromotion, " & _
                              "stNoRebase) Values('" & Trim(Me.txtProName.Text) & "', " & _
                              "'" & Me.cmbPmtType.SelectedValue & "', '" & Me.lblPsPmt.Tag & "', " & vStOpen & ", " & _
                              "'" & vStPdOfPro & "', '" & Me.lblPsTs.Tag & "', " & _
                              "'" & ksbDateToString(lblDateTs.Text) & "', " & _
                              "'" & Trim(Me.txtNote.Text) & "', " & sIdComp & ", " & _
                              "'" & vStBillPromotion & "', " & vStNoRebase & ")"
        'mdLoadCommitt()
        'MessageBox.Show(query)
        Dim idPromotion_last As Integer = 0
        idPromotion_last = mdCnOpenQueryIdentity(query)

        '--- Insert SmPromotionDt ----'
        AddSmPromotionDt(idPromotion_last)

        If Me.rdbOnlyPdT.Checked = True Then
            '--- Insert SmPromotionDtPd ----'
            AddSmPromotionDtPd(idPromotion_last)
        End If
    End Sub

    Sub AddSmPromotionDt(ByVal idPmt As Integer)
        '---insert SmPromotionDt Table---'

        For i As Integer = 0 To DGV_ProDetail.Rows.Count - 2
            Dim fInsert As String = ""
            Dim vInsert As String = ""
            Dim fInsert2 As String = ""
            Dim vInsert2 As String = ""

            If Me.rdbAmtMin.Checked = True Then
                fInsert2 = fInsert2 & ", Amount, idPkUnit"
                vInsert2 = vInsert2 & ", " & CDbl(DGV_ProDetail.Rows(i).Cells("ColAmount").Value) & ", " & _
                                      "" & CInt(DGV_ProDetail.Rows(i).Cells("ColidPkUnit").Value) & ""
            ElseIf Me.rdbBtnAmt.Checked = True Then
                fInsert2 = fInsert2 & ", SaleMin, SaleMax, idPkUnit"
                vInsert2 = vInsert2 & ", " & CDbl(DGV_ProDetail.Rows(i).Cells("ColMin").Value) & ", " & _
                                      "" & CDbl(DGV_ProDetail.Rows(i).Cells("ColMax").Value) & ", " & _
                                      "" & CInt(DGV_ProDetail.Rows(i).Cells("ColidPkUnit").Value) & ""
            End If

            If Me.ChkPriceC.Checked = True Then
                fInsert2 = fInsert2 & ", Price"
                vInsert2 = vInsert2 & ", " & CDbl(DGV_ProDetail.Rows(i).Cells("ColPrice").Value) & " "
            End If

            'If Me.ChkWeightC.Checked = True Then
            '    fInsert2 = fInsert2 & ", Weight, idUnitW"
            '    vInsert2 = vInsert2 & ", " & CDbl(DGV_ProDetail.Rows(i).Cells("ColPk").Value) & ", " & _
            '                          "" & CInt(DGV_ProDetail.Rows(i).Cells("ColidUnit").Value) & ""
            'End If

            If Me.ChkBtnSale.Checked = True Then
                fInsert2 = fInsert2 & ", SaleMin, SaleMax"
                vInsert2 = vInsert2 & ", " & CDbl(DGV_ProDetail.Rows(i).Cells("ColMin").Value) & ", " & _
                                      "" & CDbl(DGV_ProDetail.Rows(i).Cells("ColMax").Value) & ""

            End If

            If Me.cmbPmtType.SelectedValue = 1 Then 'คืนเงินปลายปี
                fInsert2 = fInsert2 & ", RewardAmount "
                vInsert2 = vInsert2 & ", " & CInt(DGV_ProDetail.Rows(i).Cells("ColReward").Value) & ""
            ElseIf Me.cmbPmtType.SelectedValue = 2 Then 'โปรโมชั่นทอง
                fInsert2 = fInsert2 & ", idInv, RewardAmount "
                vInsert2 = vInsert2 & ", " & CInt(DGV_ProDetail.Rows(i).Cells("ColidInv").Value) & ", " & _
                                      "'" & CInt(DGV_ProDetail.Rows(i).Cells("ColReward").Value) & "'"
            ElseIf Me.cmbPmtType.SelectedValue = 3 Then 'โปรโมชั่นแถมสินค้า
                fInsert2 = fInsert2 & ", RewardAmount, UnitReward "
                vInsert2 = vInsert2 & ", " & CInt(DGV_ProDetail.Rows(i).Cells("ColReward").Value) & ", " & _
                                      "'" & DGV_ProDetail.Rows(i).Cells("ColUnitReward").Value & "'"
            ElseIf Me.cmbPmtType.SelectedValue = 4 Then 'โปรโมชั่นแถม(ของแถมไม่ใช่สินค้า)
                fInsert2 = fInsert2 & ", idInv, RewardAmount "
                vInsert2 = vInsert2 & ", " & CInt(DGV_ProDetail.Rows(i).Cells("ColidInv").Value) & ", " & _
                                      "'" & CInt(DGV_ProDetail.Rows(i).Cells("ColReward").Value) & "'"
            ElseIf Me.cmbPmtType.SelectedValue = 5 Then 'แถมแผงผักซอง
                fInsert2 = fInsert2 & ", idInv, RewardAmount "
                vInsert2 = vInsert2 & ", " & CInt(DGV_ProDetail.Rows(i).Cells("ColidInv").Value) & ", " & _
                                      "'" & CInt(DGV_ProDetail.Rows(i).Cells("ColReward").Value) & "'"
            ElseIf Me.cmbPmtType.SelectedValue = 6 Then 'ราคาขาย
                fInsert2 = fInsert2 & ", PriceDis, UnitReward"
                vInsert2 = vInsert2 & ", " & CDbl(DGV_ProDetail.Rows(i).Cells("ColPriceDis").Value) & ", " & _
                                      "'" & DGV_ProDetail.Rows(i).Cells("ColUnitReward").Value & "' "

            End If

            fInsert = "(idPromotion " & fInsert2 & ") "
            vInsert = "(" & idPmt & vInsert2 & ")"

            mdCnOpen()
            sCommand.CommandText = "Insert Into SmPromotionDt" & fInsert & " Values" & vInsert
            sCommand.ExecuteNonQuery()
        Next
    End Sub

    Sub AddSmPromotionDtPd(ByVal idPmt As Integer)
        ' Dim vField As String = ""

        'If Me.rdbPdTName.Checked = True Then
        '    vField = " idPdT"
        'ElseIf Me.rdbPdName.Checked = True Then
        '    vField = " idPdN"
        'ElseIf Me.rdbPlant.Checked = True Then
        '    vField = " idPlant"
        'End If

        'For i As Integer = 0 To DGV_PdT.Rows.Count - 1
        '    sCommand.CommandText = "Insert Into SmPromotionDtPd(idPromotion, " & vField & ") Values(" & idPmt & ", " & _
        '                           "" & CInt(DGV_PdT.Rows(i).Cells("ColidPdT").Value) & " )"
        '    sCommand.ExecuteNonQuery()
        'Next
        For i As Integer = 0 To DGV_PdT.Rows.Count - 1
            sCommand.CommandText = "Insert Into SmPromotionDtPd(idPromotion, idPdPk) Values(" & idPmt & ", " & _
                                   "" & CInt(DGV_PdT.Rows(i).Cells("ColidPdT").Value) & " )"
            sCommand.ExecuteNonQuery()
        Next

    End Sub

    Sub UPDATESmPromotionMt()
        '-----สถานะเปิด-ปิดการใช้โปร------'
        Dim vStOpen As Integer = 0
        If Me.rdbOpen.Checked = True Then
            vStOpen = 0
        ElseIf Me.rdbClose.Checked = True Then
            vStOpen = 1 'Close     
        End If

        '-----สถานะการผูกกับสินค้า------'
        Dim vStPdOfPro As Integer = 0
        If Me.rdbAllPdT.Checked = True Then
            vStPdOfPro = 0
        ElseIf Me.rdbPack.Checked = True Then 'ผักซอง
            If Me.ChkF1.Checked = True And Me.ChkOP.Checked = True Then 'OP+F1
                vStPdOfPro = 1
            ElseIf Me.ChkF1.Checked = False And Me.ChkOP.Checked = True Then 'F1
                vStPdOfPro = 2
            ElseIf Me.ChkF1.Checked = True And Me.ChkOP.Checked = False Then 'OP
                vStPdOfPro = 3
            End If
        ElseIf Me.rdbOnlyPdT.Checked = True Then 'บางรายการที่ระบุ idPdPk
            vStPdOfPro = 4

            'If Me.rdbPdTName.Checked = True Then
            '    vStPdOfPro = 4
            'ElseIf Me.rdbPdName.Checked = True Then
            '    vStPdOfPro = 5
            'ElseIf Me.rdbPlant.Checked = True Then
            '    vStPdOfPro = 6
            'End If
        End If

        ''-----สถานะคำนวณเงื่อนไขของสินค้า------'
        'Dim vStConditionPd As String = ""
        'If Me.rdbSplit.Checked = True Then
        '    vStConditionPd = "0"
        'ElseIf Me.rdbSum.Checked = True Then
        '    vStConditionPd = "1"
        'Else
        '    vStConditionPd = " Null"
        'End If

        '-----สถานะ Promotion กับ บิล------'
        Dim vStBillPromotion As Integer = 0
        If Me.rdbBill.Checked = True Then
            vStBillPromotion = 0
        ElseIf Me.rdbSummary.Checked = True Then
            vStBillPromotion = 1
        End If

        ''----จำนวนปีที่สะสมโปรโมชั่น--------'
        'Dim vYear As String = ""
        'If Me.rdbMore1Y.Checked = True Then
        '    vYear = "YearOfSum = '" & Me.txtYear.Text & "'"
        'Else
        '    vYear = "YearOfSum = NULL"
        'End If

        '-----สถานะรีเบส -------------'
        Dim vStNoRebase As String = ""
        If Me.ChkStNoRebase.Checked = True Then
            vStNoRebase = "1" 'No Rebase
        Else
            vStNoRebase = " NULL"
        End If

        ''-----สถานะคำนวณเงื่อนไขของสินค้า------'
        'Dim vStPdLayer As String = ""
        'If Me.rdbPdTName.Checked = True Then
        '    vStPdLayer = "0"
        'ElseIf Me.rdbPdName.Checked = True Then
        '    vStPdLayer = "1"
        'ElseIf Me.rdbPlant.Checked = True Then
        '    vStPdLayer = "2"
        'Else
        '    vStPdLayer = " Null"
        'End If

        mdCnOpen()
        sCommand.CommandText = "Update SmPromotionMt Set ProName ='" & Trim(Me.txtProName.Text) & "', " & _
                               "idPsPro = '" & Me.lblPsPmt.Tag & "', stProOpen='" & vStOpen & "', " & _
                               "stPdOfPro = '" & vStPdOfPro & "', idPsTs = '" & sPsId & "', " & _
                               "DateTs='" & ksbDateToString(Date.Today) & "', " & _
                               "Note = '" & Trim(Me.txtNote.Text) & "', idComp = " & sIdComp & ", " & _
                               "stBillPromotion = '" & vStBillPromotion & "', " & _
                               "stNoRebase = " & vStNoRebase & " Where idPromotion ='" & idPro_rec & "'"
        sCommand.ExecuteNonQuery()

        '--- UPDATE SmPromotionDt ----'
        UPDATESmPromotionDt()

        '--- UPDATE SmPromotionDtPd ----'
        UPDATESmPromotionDtPd()
    End Sub

    Sub UPDATESmPromotionDt()
        mdCnOpen()
        '-----Delete Old Rows Data-----'
        sCommand.CommandText = "Delete SmPromotionDt Where idPromotion ='" & idPro_rec & "'"
        sCommand.ExecuteNonQuery()

        '-----Insert NEW Rows Data-----'
        AddSmPromotionDt(idPro_rec)
    End Sub

    Sub UPDATESmPromotionDtPd()
        mdCnOpen()
        '-----Delete Old Rows Data-----'
        sCommand.CommandText = "Delete SmPromotionDtPd Where idPromotion ='" & idPro_rec & "'"
        sCommand.ExecuteNonQuery()

        If Me.rdbOnlyPdT.Checked = True Then
            '--- UPDATE SmPromotionDtPd ----'
            AddSmPromotionDtPd(idPro_rec)
        End If
    End Sub

    Private Sub ChkPriceC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPriceC.CheckedChanged
        If Me.ChkPriceC.Checked = True Then
            DGV_ProDetail.Columns("ColPrice").Visible = True
            DGV_ProDetail.Columns("ColPrice").HeaderText = "ราคาชั้นต่ำ (บาท)"
        Else
            DGV_ProDetail.Columns("ColPrice").Visible = False
        End If
    End Sub

    'Private Sub ChkWeightC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.ChkWeightC.Checked = True Then
    '        DGV_ProDetail.Columns("ColPk").Visible = True
    '        DGV_ProDetail.Columns("ColPk").HeaderText = "ขนาด Package"
    '        DGV_ProDetail.Columns("ColidUnit").Visible = True

    '        For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
    '            '---ADD UnitW---'
    '            Dim combo As DataGridViewComboBoxCell = DGV_ProDetail.Rows(i).Cells("ColidUnit")
    '            mdCnOpen()
    '            Dim sDt As New DataTable
    '            sCommand.CommandText = "Select idUnitW, UnitW From dUnitW"

    '            sAdapter.Fill(sDt)
    '            combo.DisplayMember = "UnitW"
    '            combo.ValueMember = "idUnitW"
    '            combo.DataSource = sDt
    '            combo.Value = 1
    '        Next

    '    Else
    '        DGV_ProDetail.Columns("ColPk").Visible = False
    '        DGV_ProDetail.Columns("ColidUnit").Visible = False
    '    End If
    'End Sub

    Private Sub ChkAmountC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAmountC.CheckedChanged
        If Me.ChkAmountC.Checked = True Then
            Me.GroupBox6.Enabled = True
            Me.rdbAmtMin.Checked = True
        Else
            Me.GroupBox6.Enabled = False
            Me.rdbAmtMin.Checked = False
            Me.rdbBtnAmt.Checked = False
        End If
    End Sub

    Private Sub ChkBtnSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBtnSale.CheckedChanged
        If Me.ChkBtnSale.Checked = True Then
            'Me.ChkAmountC.Checked = False
            'Me.ChkAmountC.Enabled = False
            'Me.GroupBox6.Enabled = False
            'Me.rdbAmtMin.Checked = False
            Me.rdbBtnAmt.Checked = False
            Me.rdbBtnAmt.Enabled = False
            'Me.ChkPriceC.Enabled = False
            'Me.ChkPriceC.Checked = False
            'Me.ChkWeightC.Enabled = False
            'Me.ChkWeightC.Checked = False
            DGV_ProDetail.Columns("ColMin").Visible = True
            DGV_ProDetail.Columns("ColMin").HeaderText = "ยอดขายต่ำสุด"
            DGV_ProDetail.Columns("ColMax").Visible = True
            DGV_ProDetail.Columns("ColMax").HeaderText = "ยอดขายสูงสุด"
            DGV_ProDetail.Columns("ColPkUnit").Visible = False
        Else
            DGV_ProDetail.Columns("ColMin").Visible = False
            DGV_ProDetail.Columns("ColMax").Visible = False
            Me.rdbBtnAmt.Enabled = True
            'Me.ChkAmountC.Enabled = True
            'Me.GroupBox6.Enabled = True
            'Me.ChkPriceC.Enabled = True
            'Me.ChkWeightC.Enabled = True
        End If
    End Sub


    Private Sub rdbAmtMin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAmtMin.CheckedChanged
        If Me.rdbAmtMin.Checked = True Then
            DGV_ProDetail.Columns("ColAmount").Visible = True
            DGV_ProDetail.Columns("ColAmount").HeaderText = "จำนวนซื้อ"
            DGV_ProDetail.Columns("ColPkUnit").Visible = True

            If stDetail = 1 Then
                If Me.rdbSummary.Checked = True Then 'แบบสะสม
                    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = 5 'Kg
                        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = "กิโลกรัม" 'Kg
                    Next
                ElseIf Me.rdbBill.Checked = True Then 'แบบรายบิล
                    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value
                        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColPkUnitName.Name).Value
                    Next
                End If
            End If


            'For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
            '    '---ADD PkUnit---'
            '    Dim combo2 As DataGridViewComboBoxCell = DGV_ProDetail.Rows(i).Cells("ColPkUnit")
            '    Dim sDt2 As New DataTable
            '    sCommand.CommandText = "Select idPkUnit, PkUnitName From dPackingUnit WHERE idPkUnit <> 7"

            '    sAdapter.Fill(sDt2)
            '    combo2.DisplayMember = "PkUnitName"
            '    combo2.ValueMember = "idPkUnit"
            '    combo2.DataSource = sDt2
            '    If Me.cmbPmtType.SelectedValue = 5 Then
            '        combo2.Value = 2
            '    Else
            '        combo2.Value = 1
            '    End If
            'Next

        Else
            DGV_ProDetail.Columns("ColAmount").Visible = False
            DGV_ProDetail.Columns("ColPkUnit").Visible = False
        End If
    End Sub

    Private Sub rdbBtnAmt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbBtnAmt.CheckedChanged
        If Me.rdbBtnAmt.Checked = True Then
            DGV_ProDetail.Columns("ColMin").Visible = True
            DGV_ProDetail.Columns("ColMin").HeaderText = "จำนวนซื้อต่ำสุด"
            DGV_ProDetail.Columns("ColMax").Visible = True
            DGV_ProDetail.Columns("ColMax").HeaderText = "จำนวนซื้อสูงสุด"
            DGV_ProDetail.Columns("ColPkUnit").Visible = True

            If stDetail = 1 Then
                If Me.rdbSummary.Checked = True Then 'แบบสะสม
                    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = 5 'Kg
                        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = "กิโลกรัม" 'Kg
                    Next
                ElseIf Me.rdbBill.Checked = True Then 'แบบรายบิล
                    For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                        DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value
                        DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColPkUnitName.Name).Value
                    Next
                End If
            End If

            'For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
            '    '---ADD PkUnit---'
            '    Dim combo2 As DataGridViewComboBoxCell = DGV_ProDetail.Rows(i).Cells("ColPkUnit")
            '    Dim sDt2 As New DataTable
            '    sCommand.CommandText = "Select idPkUnit, PkUnitName From dPackingUnit WHERE idPkUnit <> 7"

            '    sAdapter.Fill(sDt2)
            '    combo2.DisplayMember = "PkUnitName"
            '    combo2.ValueMember = "idPkUnit"
            '    combo2.DataSource = sDt2
            '    If Me.cmbPmtType.SelectedValue = 5 Then
            '        combo2.Value = 2
            '    Else
            '        combo2.Value = 1
            '    End If

            'Next
        Else
            DGV_ProDetail.Columns("ColMin").Visible = False
            DGV_ProDetail.Columns("ColMax").Visible = False
            DGV_ProDetail.Columns("ColPkUnit").Visible = False
            If Me.cmbPmtType.SelectedValue <> 6 Then ' No Price Promotion
                Me.ChkBtnSale.Enabled = True
            End If

        End If
    End Sub

    Private Sub rdbAllPdT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAllPdT.CheckedChanged
        If Me.rdbAllPdT.Checked = True Then
            Me.ChkStNoRebase.Checked = False
            Me.ChkStNoRebase.Enabled = False
            If Me.cmbPmtType.SelectedValue = 1 Then
                'Me.ChkBtnSale.Enabled = True
                Me.ChkBtnSale.Checked = True
                Me.ChkAmountC.Checked = False
            End If
        Else
            Me.ChkStNoRebase.Enabled = True
        End If
    End Sub

    'Private Sub rdbPdTName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPdTName.CheckedChanged
    '    'DGV_PdT.Rows.Clear()
    '    'If stLoad = 1 Then
    '    '    If Me.rdbPdTName.Checked = True Then
    '    '        DGV_PdT.Columns(ColPdTName.Name).HeaderText = "ชื่อทางการค้า"
    '    '    End If
    '    'End If

    'End Sub

    'Private Sub rdbPdName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPdName.CheckedChanged

    '    'If Me.rdbPdName.Checked = True Then
    '    '    DGV_PdT.Rows.Clear()
    '    '    DGV_PdT.Columns("ColPdTName").HeaderText = "ชื่อสินค้า"
    '    'End If
    'End Sub

    'Private Sub rdbPlant_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPlant.CheckedChanged
    '    'If Me.rdbPlant.Checked = True Then
    '    '    DGV_PdT.Rows.Clear()
    '    '    DGV_PdT.Columns("ColPdTName").HeaderText = "ชื่อพืช"
    '    'End If
    'End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Result = MsgBox("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", MsgBoxStyle.YesNo)

        If Result = Windows.Forms.DialogResult.Yes Then
            Dim CancelNote As String = " "
            CancelNote = InputBox("ระบุสาเหตุการยกเลิก", sSystemName)
            If CancelNote.Length = 0 Then
                MessageBox.Show("กรุณาระบุสาเหตุการยกเลิก", sSystemName)
                Exit Sub
            Else
                sCommand.CommandText = "Update SmPromotionMt Set idPsCancel='" & sPsId & "', " & _
                                       "CancelNote='" & CancelNote & "' Where idPromotion ='" & idPro_rec & "'"
                sCommand.ExecuteNonQuery()
                'SumTotal()
                MessageBox.Show("ยกเลิกรายการเรียบร้อยแล้ว", sSystemName)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End If
    End Sub

    Private Sub rdbBill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbBill.CheckedChanged
        If Me.rdbBill.Checked = True And Me.ChkAmountC.Checked = True Then

            For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColidPkU.Name).Value
                DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = DGV_PdT.Rows(0).Cells(ColPkUnitName.Name).Value
            Next
        End If

    End Sub

    Private Sub rdbSummary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSummary.CheckedChanged
        If Me.rdbSummary.Checked = True And Me.ChkAmountC.Checked = True Then

            For i As Integer = 0 To DGV_ProDetail.Rows.Count - 1
                DGV_ProDetail.Rows(i).Cells(ColidPkUnit.Name).Value = 5 'Kg
                DGV_ProDetail.Rows(i).Cells(ColPkUnit.Name).Value = "กิโลกรัม" 'Kg
            Next

        End If
    End Sub
End Class