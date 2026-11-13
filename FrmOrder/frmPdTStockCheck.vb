Public Class frmPdTStockCheck
    Dim idPdT As String
    Dim idPdPkStock As String
    Dim orderAmount As Integer
    Dim idUnitPk As Integer
    Dim PdPerbox As Integer
    Dim OrUnit As Integer
    'Dim PdUnitW_s As Integer

    Public pIdT_Fl As Integer
    Public pd_Fl As String
    Public pPlant_Fl As String
    Public pPlantType_Fl As String
    Public pSeedT_Fl As Integer
  

    Public F_id As Integer
    Public F_name As String
    Public F_Note As String

    Dim stPdPage_1 As Integer = 0 'มีสินค้าคงเหลือพอ
    Dim stPdPage_2 As Integer = 0 'ต้องเอาวัตถุดิบในสต็อก AVS มารวม 
    Dim stPdPage_3 As Integer = 0 'ต้องเอาสำเร็จรูปจากบริษัทอื่นมารวม
    Dim stPdPage_4 As Integer = 0 'ต้องเอาระหว่างกระบวนการอื่นมารวม

    Dim stChange As Integer = 0 'สถานะ checkchange

    Public Sub ShowText(ByVal idpdPk As String, ByVal OrderAmt As Integer, ByVal unitPk As Integer, ByVal Perbox As Integer, ByVal OrderUnit As Integer)
        idPdPkStock = idpdPk
        orderAmount = OrderAmt
        idUnitPk = unitPk
        PdPerbox = Perbox
        OrUnit = OrderUnit
    End Sub

    Private Sub frmPdTStockCheck_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        mdLoadShow()
        mdCnOpen()
        Dim Dt As New DataTable

        Dt.Clear()
        sCommand.CommandText = "Select idPdT, PdPkName, Amount,PkUnitName, PdTradeName, PlantTypeName, " & _
                               " PlantName, Weight, idUnitW From vPackingPdSet Where idPdPk='" & idPdPkStock & "'"
        sAdapter.Fill(Dt)
        If Dt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลวัตถุดิบส่วนผสมของสินค้า", sSystemName)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Exit Sub
        Else
            idPdT = Dt.Rows(0).Item("idPdT")
            pIdT_Fl = Dt.Rows(0).Item("idPdT")
            pd_Fl = Dt.Rows(0).Item("PdTradeName")
            pPlant_Fl = Dt.Rows(0).Item("PlantName")
            pPlantType_Fl = Dt.Rows(0).Item("PlantTypeName")
            Me.lblPdPkName.Text = Dt.Rows(0).Item("PdPkName")
            Me.txtlAmount.Text = Dt.Rows(0).Item("Amount")
            Format(Me.txtlAmount.Text, "#,##0.000")
            Me.lblPkUnit.Text = Dt.Rows(0).Item("PkUnitName")
            Me.txtOrder.Text = orderAmount

            Dim PdWeight_kg As Double = 0
            If Dt.Rows(0).Item("idUnitW") = 1 Then
                PdWeight_kg = Dt.Rows(0).Item("Weight") / 1000
            ElseIf Dt.Rows(0).Item("idUnitW") = 2 Then
                PdWeight_kg = Dt.Rows(0).Item("Weight")
            End If

            If OrUnit = 1 Then 'กระป๋อง           
                Me.txtOdWeight.Text = orderAmount * PdWeight_kg
                Format(Me.txtOdWeight.Text, "#,##0.000")
                Me.lblOdUnit.Text = "กระป๋อง"
            ElseIf OrUnit = 2 Then 'ซอง
                Me.txtOdWeight.Text = orderAmount * PdWeight_kg
                Format(Me.txtOdWeight.Text, "#,##0.000")
                Me.lblOdUnit.Text = "ซอง"
            ElseIf OrUnit = 3 Then 'กล่อง
                Me.txtOdWeight.Text = orderAmount * (PdPerbox * PdWeight_kg)
                Format(Me.txtOdWeight.Text, "#,##0.000")
                Me.lblOdUnit.Text = "กล่อง"
            ElseIf OrUnit = 5 Then 'กิโลกรัม
                Me.txtOdWeight.Text = orderAmount
                Format(Me.txtOdWeight.Text, "#,##0.000")
                Me.lblOdUnit.Text = "กิโลกรัม"
                Me.Label12.Visible = False
                Me.txtOdWeight.Visible = False
                Me.Label13.Visible = False
            End If
        End If

        pDataOngrid(idPdT)
        DGV_re(idPdT)
        CheckStock()
        Check_stPdPage()
        stChange = 1
        ' Me.DGV_formula.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Gray
        Me.DGV_formula.Columns("colSelect").DefaultCellStyle.BackColor = Color.White
        mdLoadCommitt()
    End Sub

    Private Sub pDataOngrid(ByVal idPdT As String)
        mdCnOpen()
        Dim vDt As New DataTable
        Dim vFields As String = ""
        vDt.Clear()

        'vFields = "s.idPd, s.PdName,s.SeedTypeName,"
        'vFields &= "ISNULL((SELECT AvStock FROM dbo.vSeedProduct WHERE (idPd = s.idPd) " & _
        '          "AND (idSeedType = s.idSeedType)),0.00) As AvStock,"

        'vFields &= " ISNULL((SELECT SUM(EstimateW) AS Expr1 FROM dbo.vPdIndexJobDt WHERE (stCancel IS NULL) AND (idPd = s.idPd) " & _
        '        " AND (idSeedType = s.idSeedType) AND (idCompb = s.idCompb) And (idJobLine <> 0 And idJobLine <> 9 " & _
        '        " And idJobLine <> 10)),0.00) AS EstimateW,0.00 as BalancePc,"

        'vFields &= "isnull(s.S6,0.00) as S6,"
        'vFields &= " ISNULL((isnull(s.S1NOW,0.00)+isnull(s.WIP1,0.00)+isnull(s.Bake,0.00)+isnull(s.S2,0.00)+isnull(s.S3,0.00)+isnull(s.S4,0.00)+isnull(s.WIP4,0.00)" & _
        '      "+isnull(s.S5,0.00)+isnull(s.S6,0.00)),0.00) as StoreBalance,s.SalePrice,0.00 as SaleValue,s.idCompb"
        vFields = "s.idPd, s.PdName, s.SeedTypeName, "
        vFields &= "ISNULL((SELECT SUM(Amount) FROM dbo.PkPdLotStock WHERE idPd = s.idPd),0.00) As AvStock, "
        vFields &= "isnull(s.S6,0.00) as S6,"
        vFields &= "ISNULL((SELECT SUM(EstimateW) AS Expr1 FROM dbo.vPdIndexJobDt WHERE (stCancel IS NULL) AND (idPd = s.idPd) " & _
                " AND (idSeedType = s.idSeedType) AND (idCompb = s.idCompb) And (idJobLine <> 0 And idJobLine <> 9 " & _
                " And idJobLine <> 10)),0.00) AS EstimateW,0.00 as BalancePc, "
        vFields &= " ISNULL((isnull(s.S1NOW,0.00)+isnull(s.WIP1,0.00)+isnull(s.Bake,0.00)+isnull(s.S2,0.00)+isnull(s.S3,0.00)+isnull(s.S4,0.00)+isnull(s.WIP4,0.00)" & _
              "+isnull(s.S5,0.00)+isnull(s.S6,0.00)),0.00) as StoreBalance,s.SalePrice,0.00 as SaleValue,s.idCompb "


        'sCommand.CommandText = "Select " & vFields & " From vSsProductStoreBalance s INNER JOIN SlPdIngredient i ON i.idPd = s.idPd Where " & _
        '                        "(isnull(S1NOW,0.00)+isnull(WIP1,0.00)+isnull(Bake,0.00)+isnull(S2,0.00)+isnull(S3,0.00)" & _
        '                        "+isnull(S4,0.00)+isnull(WIP4,0.00)+isnull(S5,0.00)+isnull(S6,0.00) > 0) AND i.idPdT = '" & idPdT & "' Order By StoreBalance"
        sCommand.CommandText = "Select " & vFields & " From vSsProductStoreBalance s INNER JOIN SlPdIngredient i ON i.idPd = s.idPd Where " & _
                               "i.idPdT = '" & idPdT & "' Order By StoreBalance"

        sAdapter.Fill(vDt)

        'Me.msgtest.Text = idPdT
        For Each vDr As DataRow In vDt.Rows
            vDr.Item("SaleValue") = vDr.Item("SalePrice") * vDr.Item("StoreBalance")
            vDr.Item("BalancePc") = vDr.Item("StoreBalance") - vDr.Item("S6")
        Next

        If vDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลวัตถุดิบส่วนผสมของสินค้า", sSystemName)
            Exit Sub
        Else
            Dim vDv As DataView
            Dim vDt_ As New DataTable
            vDv = vDt.DefaultView
            vDt_ = vDv.Table

            pDataAll(idPdT)

            For Each vdr As DataRow In vDt_.Rows
                For Each Dgv As DataGridViewRow In dgvAll.Rows
                    Dim dgv1 As String = Dgv.Cells(colPdName_.Name).Value.ToString
                    Dim vdr1 As String = vdr.Item("PdName").ToString

                    If Dgv.Cells(colPdName_.Name).Value = vdr.Item("PdName") Then

                        If vdr.Item("idCompb") = 2 Then
                            Dgv.Cells(colEstimateW_Green.Name).Value = vdr.Item("EstimateW")
                            Dgv.Cells(colBalancePC_Green.Name).Value = vdr.Item("BalancePc")
                            Dgv.Cells(colS6_Green.Name).Value = vdr.Item("S6")
                            Dgv.Cells(colStoreBalance_Green.Name).Value = vdr.Item("StoreBalance")
                        End If
                        If vdr.Item("idCompb") = 1 Then
                            Dgv.Cells(colEstimateW_Flo.Name).Value = vdr.Item("EstimateW")
                            Dgv.Cells(colBalancePC_Flo.Name).Value = vdr.Item("BalancePc")
                            Dgv.Cells(colS6_Flo.Name).Value = vdr.Item("S6")
                            Dgv.Cells(colStoreBalance_Flo.Name).Value = vdr.Item("StoreBalance")
                        End If

                        'If vdr.Item("idCompb") = 8 Then
                        Dgv.Cells(colStoreBalance_avs.Name).Value = vdr.Item("AvStock")
                        'End If

                        Dgv.Cells(colEstimateW_.Name).Value = Dgv.Cells(colEstimateW_Green.Name).Value + Dgv.Cells(colEstimateW_Flo.Name).Value
                        Dgv.Cells(colBalancePc_.Name).Value = Dgv.Cells(colBalancePC_Green.Name).Value + Dgv.Cells(colBalancePC_Flo.Name).Value
                        Dgv.Cells(colS6_.Name).Value = Dgv.Cells(colS6_Green.Name).Value + Dgv.Cells(colS6_Flo.Name).Value + Dgv.Cells(colStoreBalance_avs.Name).Value
                        Dgv.Cells(colStoreBalance_.Name).Value = Dgv.Cells(colStoreBalance_Green.Name).Value + Dgv.Cells(colStoreBalance_Flo.Name).Value + Dgv.Cells(colStoreBalance_avs.Name).Value

                    End If
                Next
            Next
            ksbCountRowDgv(dgvAll, colCount.Name)
        End If
    End Sub

    Private Sub pDataAll(ByVal idPdT As String)
        Dim vDt As New DataTable
        Dim vFields As String = ""

        vFields = "Distinct s.idPd, s.PdName,s.SeedTypeName"
        'sCommand.CommandText = "Select " & vFields & " From vSsProductStoreBalance s INNER JOIN SlPdIngredient i ON i.idPd = s.idPd Where " & _
        '                              "(isnull(S1NOW,0.00)+isnull(WIP1,0.00)+isnull(Bake,0.00)+isnull(S2,0.00)+isnull(S3,0.00)" & _
        '                              "+isnull(S4,0.00)+isnull(WIP4,0.00)+isnull(S5,0.00)+isnull(S6,0.00) > 0) AND i.idPdT = '" & idPdT & "' Order By SeedTypeName"
        sCommand.CommandText = "Select Distinct v.idPd,v.PdName,v.SeedTypeName From vSeedProduct v " & _
                                 "LEFT JOIN SlPdIngredient i ON i.idPd = v.idPd " & _
                                 "LEFT JOIN vSsProductStoreBalance s ON i.idPd = s.idPd " & _
                                 "Where i.idPdT = " & idPdT & " Order By v.SeedTypeName"
        'sAdapter.Fill(vDt)

        ' sCommand.CommandText = "Select Distinct PdName,SeedTypeName From vSsProductStoreBalance "
        sAdapter.Fill(vDt)
        dgvAll.DataSource = vDt

    End Sub

    Private Sub CheckStock()
        Dim orderReq As Integer = 0 'order ของลูกค้าเป็นกระป๋อง/ซอง
        Dim WeightKg As Double = 0
        Dim stChkStock As Integer = 0 'สถานะสินค้าใน stock

        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Amount, idPkUnit, Weight, idUnitW, Perbox From vPackingPdSet Where idPdPk='" & idPdPkStock & "'"
        sAdapter.Fill(sDt)

        If idUnitPk = 1 Or idUnitPk = 2 Or idUnitPk = 4 Or idUnitPk = 6 Then
            orderReq = orderAmount
        ElseIf idUnitPk = 3 Then
            orderReq = orderAmount * PdPerbox
        ElseIf idUnitPk = 5 Then
            If sDt.Rows(0).Item("idUnitW") = 1 Then
                WeightKg = sDt.Rows(0).Item("Weight") / 1000
            Else
                WeightKg = sDt.Rows(0).Item("Weight")
            End If
            orderReq = orderAmount / WeightKg
        End If

        '********** 1st Case:check stock vPackingPdSet ************'
        If orderReq <= sDt.Rows(0).Item("Amount") Then
            Me.txtlAmount.BackColor = Color.Green 'case1
            stPdPage_1 = 1
            Me.GroupBox4.Enabled = False
            'Me.Chb_MatOther.Enabled = False
            'Me.Chb_PdOther.Enabled = False
        Else
            'Me.txtlAmount.BackColor = Color.Red
            stChkStock = 1 'สินค้าไม่พอ
        End If


        If stChkStock = 1 Then
            '****** 2nd Case:check stock AVS **********'
            Dim Balance2 As Double = 0
            Dim BlOrderKg As Double = 0

            For i As Integer = 0 To DGV_formula.Rows.Count - 1
                Dim stMtAVS As Integer = 0
                Dim stAVS_S6 As Integer = 0
                Dim stAllGreenFlo As Integer = 0

                mdCnOpen()
                Dim Dt_Fl As New DataTable
                Dt_Fl.Clear()
                sCommand.CommandText = "Select idPd, MixPerc From SlPdIngredient Where idFL='" & DGV_formula.Rows(i).Cells("colidFL").Value & "'"
                Dt_Fl.Columns.Add("CalPerc", System.Type.GetType("System.Double"))
                sAdapter.Fill(Dt_Fl)


                'แปลงหน่วย order ----->Kg
                If idUnitPk = 1 Or idUnitPk = 2 Or idUnitPk = 4 Or idUnitPk = 6 Then 'กระป๋อง/ซอง
                    If Me.rdbPoor.Checked = True Then
                        'คำนวณจาก order ที่ขาด
                        Balance2 = orderAmount - sDt.Rows(0).Item("Amount")
                    ElseIf Me.rdbAll.Checked = True Then
                        'คำนวณจาก order ทั้งหมด
                        Balance2 = orderAmount
                    End If

                    If sDt.Rows(0).Item("idUnitW") = 1 Then
                        WeightKg = sDt.Rows(0).Item("Weight") / 1000
                    Else
                        WeightKg = sDt.Rows(0).Item("Weight")
                    End If
                    BlOrderKg = Balance2 * WeightKg 'order เป็น Kg
                ElseIf idUnitPk = 3 Then 'กล่อง
                    If Me.rdbPoor.Checked = True Then
                        'คำนวณจาก order ที่ขาด
                        Balance2 = (orderAmount * PdPerbox) - sDt.Rows(0).Item("Amount")
                    ElseIf Me.rdbAll.Checked = True Then
                        'คำนวณจาก order ทั้งหมด
                        Balance2 = (orderAmount * PdPerbox)
                    End If

                    If sDt.Rows(0).Item("idUnitW") = 1 Then
                        WeightKg = sDt.Rows(0).Item("Weight") / 1000
                    Else
                        WeightKg = sDt.Rows(0).Item("Weight")
                    End If
                    BlOrderKg = Balance2 * WeightKg
                ElseIf idUnitPk = 5 Then 'Kg
                    'Balance2 = Nothing
                    BlOrderKg = orderAmount
                End If

                Dim stFor As Integer = 0
                Dim stFind As Integer = 0
                For j As Integer = 0 To Dt_Fl.Rows.Count - 1
                    Dt_Fl.Rows(j).Item("CalPerc") = (BlOrderKg * Dt_Fl.Rows(j).Item("MixPerc")) / 100
                    For k As Integer = 0 To dgvAll.Rows.Count - 1
                        If dgvAll.Rows(k).Cells("ColidPd").Value = Dt_Fl.Rows(j).Item("idPd") Then
                            stFind = 1
                            If Dt_Fl.Rows(j).Item("CalPerc") > dgvAll.Rows(k).Cells("colStoreBalance_avs").Value Then
                                stMtAVS = 1 'มีวัตถุดิบอย่างน้อย 1 รายการไม่พอ : stMtAVS = 0 หมายถึง พอ
                                stFor = 1
                                Exit For
                            End If
                        End If
                    Next
                    'End dgvAll: Check all material AVS
                    If stFind = 0 Then
                        stMtAVS = 1
                    End If
                    If stFor = 1 Then
                        Exit For
                    End If
                Next
                'End dt_fl: All idpd for 1 fomula||material AVS

                If stMtAVS = 0 Then
                    'มีสินค้าวัตถุดิบในสต็อก AVS พอ
                    DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.Khaki 'case2
                    DGV_formula.Rows(i).Cells("colSelect").Style.BackColor = Color.White
                    stPdPage_2 = 1
                Else
                    'มีสินค้าวัตถุดิบในสต็อก AVS ไม่พอ
                    '----- Next >>> check material บริษัทอื่น colS6_Green+colS6_Flo'
                    Dim stFind2 As Integer = 0
                    Dim stFor2 As Integer = 0
                    For j As Integer = 0 To Dt_Fl.Rows.Count - 1
                        Dt_Fl.Rows(j).Item("CalPerc") = (BlOrderKg * Dt_Fl.Rows(j).Item("MixPerc")) / 100
                        For k As Integer = 0 To dgvAll.Rows.Count - 1
                            If dgvAll.Rows(k).Cells("ColidPd").Value = Dt_Fl.Rows(j).Item("idPd") Then
                                stFind2 = 1
                                Dim TotalStock As Double = (dgvAll.Rows(k).Cells("colS6_Green").Value + dgvAll.Rows(k).Cells("colS6_Flo").Value)
                                If Dt_Fl.Rows(j).Item("CalPerc") > TotalStock Then
                                    stAVS_S6 = 1 'มีวัตถุดิบอย่างน้อย 1 รายการไม่พอ
                                    stFor2 = 1
                                    Exit For
                                End If
                            End If
                        Next
                        'End dgvAll: Check all material AVS + S6 (Green+Flo)
                        If stFind2 = 0 Then
                            stAVS_S6 = 1
                        End If
                        If stFor2 = 1 Then
                            Exit For
                        End If
                    Next
                    'End dt_fl: All idPd for 1 fomula||material material AVS + S6 (Green+Flo)

                    If stAVS_S6 = 0 Then
                        'มีสินค้าวัตถุดิบใน stock บริษัทอื่น (S6_Green+ S6_Flo) พอ
                        DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.MediumPurple 'case3
                        DGV_formula.Rows(i).Cells("colSelect").Style.BackColor = Color.White
                        stPdPage_3 = 1
                    Else
                        'มัสินค้าวัตถุดิบใน stock บริษัทอื่น (S6_Green+ S6_Flo)ไม่พอ
                        '----- Next >>> check material ที่กำลังผลิต  (colBalancePc_Green + colBalancePc_Flo)'
                        Dim stFor3 As Integer = 0
                        Dim stFind3 As Integer = 0
                        For j As Integer = 0 To Dt_Fl.Rows.Count - 1
                            Dt_Fl.Rows(j).Item("CalPerc") = (BlOrderKg * Dt_Fl.Rows(j).Item("MixPerc")) / 100
                            For k As Integer = 0 To dgvAll.Rows.Count - 1
                                If dgvAll.Rows(k).Cells("ColidPd").Value = Dt_Fl.Rows(j).Item("idPd") Then
                                    stFind3 = 1
                                    Dim AllGreen_Flo As Double = (dgvAll.Rows(k).Cells("colBalancePC_Green").Value + dgvAll.Rows(k).Cells("colBalancePC_Flo").Value)
                                    If Dt_Fl.Rows(j).Item("CalPerc") > AllGreen_Flo Then
                                        stAllGreenFlo = 1 'มีวัตถุดิบอย่างน้อย 1 รายการไม่พอ
                                        stFor3 = 1
                                        Exit For
                                    End If
                                End If
                            Next
                            'End dgvAll: Check all material AVS + S6 (Green+Flo) + Pd(Green+Flo)
                            If stFind3 = 0 Then
                                stAllGreenFlo = 1
                            End If
                            If stFor3 = 1 Then
                                Exit For
                            End If
                        Next
                        'End dt_fl: All idPd for 1 fomula||material AVS + S6 (Green+Flo) + Pd(Green+Flo)

                        If stAllGreenFlo = 0 Then
                            'มีสินค้าวัตถุดิบที่กำลังผลิต พอ (วัตถุดิบระหว่างกระบวนการ)
                            DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.Coral 'case4
                            DGV_formula.Rows(i).Cells("colSelect").Style.BackColor = Color.White
                            stPdPage_4 = 1
                        Else
                            'ไม่มีสินค้าวัตถุดิบ || "ต้องสั่งผลิต"
                            DGV_formula.Rows(i).DefaultCellStyle.BackColor = Color.LightPink 'case5
                            DGV_formula.Rows(i).Cells("colSelect").Style.BackColor = Color.White
                        End If                    
                    End If
                End If              
            Next
        End If
        'Me.DGV_formula.Columns("colSelect").DefaultCellStyle.BackColor = Color.White
    End Sub

    Public Sub DGV_re(ByVal idPdT As String)
        mdCnOpen()
        Dim sDt_re As New DataTable
        sDt_re.Clear()
        sCommand.CommandText = "Select SlPdFormula.idFL,SlPdFormula.FlName,SlPdFormula.Note,SlPdFormula.idPsUpdate,SlPdFormula.DateUpdate,vPerson.PsName " & _
                                "From SlPdFormula INNER JOIN vPerson " & _
                                " ON SlPdFormula.idPsUpdate=vPerson.idPs  WHERE SlPdFormula.idPdT = " & idPdT & " Order By SlPdFormula.FlName"
        sAdapter.Fill(sDt_re)
        Me.DGV_formula.DataSource = sDt_re

        For i As Integer = 0 To DGV_formula.Rows.Count - 1
            With DGV_formula.Rows(i)
                .Cells("colDate").Value = ksbStringToDate(DGV_formula.Rows(i).Cells("colDate").Value)
            End With
        Next
    End Sub

    Private Sub DGV_formula_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_formula.CellClick
        If Me.DGV_formula.Columns(e.ColumnIndex).Name = Me.colSelect.Name Then
            F_id = Me.DGV_formula.Rows(e.RowIndex).Cells(colidFL.Name).Value
            F_name = Me.DGV_formula.Rows(e.RowIndex).Cells(colFlName.Name).Value
            F_Note = Me.DGV_formula.Rows(e.RowIndex).Cells(colnote.Name).Value
            'Dim aDt As New DataTable
            'mdCnOpen()
            'aDt.Clear()
            'sCommand.CommandText = "Select "
            'sAdapter.Fill(aDt)

            Dim frm_I As New frmPdIngredient
            frm_I.ShowText(pd_Fl, pPlant_Fl, pPlantType_Fl, pIdT_Fl, pSeedT_Fl)
            frm_I.getFl(F_id, F_name, F_Note)
            frm_I.ShowDialog()

        End If
    End Sub


    Private Sub Check_stPdPage()
        If stPdPage_1 = 1 Then
            Me.txt_stPd.Text = "มีสินค้าขายคงเหลือใน Stock"
        ElseIf stPdPage_2 = 1 Then
            Me.txt_stPd.Text = "มีสินค้าวัตถุดิบคงเหลือใน Stock"
        ElseIf stPdPage_3 = 1 Then
            Me.txt_stPd.Text = "มีสินค้าวัตถุดิบคงเหลือใน Stock บริษัทอื่น"
        ElseIf stPdPage_4 = 1 Then
            Me.txt_stPd.Text = "มีสินค้าวัตถุดิบที่กำลังผลิต"
        Else
            Me.txt_stPd.Text = "ไม่มีสินค้าวัตถุดิบ ต้องสั่งผลิต"
        End If
    End Sub

    Private Sub rdbPoor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPoor.CheckedChanged
        If Me.rdbPoor.Checked = True Then
            If stChange = 1 Then
                'pDataOngrid(idPdT)
                'DGV_re(idPdT)
                CheckStock()
                Check_stPdPage()
            End If        
        End If
    End Sub

    Private Sub rdbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAll.CheckedChanged
        If Me.rdbAll.Checked = True Then
            If stChange = 1 Then
                'pDataOngrid(idPdT)
                'DGV_re(idPdT)
                CheckStock()
                Check_stPdPage()
            End If
        End If
    End Sub
End Class