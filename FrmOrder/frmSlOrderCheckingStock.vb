Public Class frmSlOrderCheckingStock
    Dim flDt As New DataTable
    Public Pdidpk As String
    Public OrderAmt As Integer
    Public UnitPk As Integer
    Public Perbox As Integer
    Public AmtWeight As Integer
    Public OrderUnit As Integer

    Private Sub frmSlOrderCheckingStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindCus()
        BindPsSale()
        BindPdPk()
    End Sub

    Private Sub btnSFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSFindAll.Click
        mdLoadShow()
        BindData()
        CalOrderKg()
        stStockPd()
        mdLoadCommitt()
    End Sub

    Sub BindData()
        Dim vWhere As String = ""
        'Check เฉพาะรายการที่ผ่าน 3 ขั้นตอน + stSet is Null
        vWhere = vWhere & " mt.idPsAccept is Not NULL AND mt.idPsCheck is Not NULL AND mt.idPsApp is Not NULL " & _
                          "AND dt.stSet is NULL AND dt.idSale IS NULL "


        '---check search condition---'
        If Me.rdbCus.Checked = True Then
            vWhere = vWhere & " AND mt.idCus = '" & Me.cmbCus.SelectedValue & "' "
        ElseIf Me.rdbPsSale.Checked = True Then
            vWhere = vWhere & " AND mt.idPsSale = '" & Me.cmbPsSale.SelectedValue & "' "
        ElseIf Me.rdbPd.Checked = True Then
            vWhere = vWhere & " AND dt.idPdPk = '" & Me.CmbPd.SelectedValue & "' "
        ElseIf Me.rdbAll.Checked = True Then
            'vWhere = " mt.idPsAccept is Not NULL AND mt.idPsCheck is Not NULL AND mt.idPsApp is Not NULL " & _
            '         "AND dt.stSet is NULL"
        End If


        '---check order by ---'
        If Me.rdbDateOrder.Checked = True Then
            vWhere = vWhere & " Order By mt.DateOrder"
        ElseIf Me.rdbDateReq.Checked = True Then
            vWhere = vWhere & " Order By mt.DateRequire"
        End If


        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select mt.idSaleOrder, mt.DateOrder, mt.DateRequire, Pd.PdPkName, " & _
                               "dt.Amount, dt.idPkUnit, '' As KgOrder, mt.DocCode, c.CusName_, " & _
                               "Ap.ApName, Pv.PvName, dt.idPdPk, " & _
                               "u.PkUnitname, dt.Perbox, dt.Weight, dt.idUnitW, mt.PsSale " & _
                               "From vSmSaleOrderMt mt INNER JOIN SmSaleOrderDt dt ON mt.idSaleOrder = dt.idSaleOrder " & _
                               "LEFT OUTER JOIN vCustomer c ON mt.idCus = c.idCus " & _
                               "INNER JOIN vPackingPdSet Pd ON dt.idPdPk = Pd.idPdPk " & _
                               "INNER JOIN dPackingUnit u ON dt.idPkUnit = u.idPkUnit " & _
                               "INNER JOIN dProvinceFixSale Pv ON c.idPv = Pv.idPv " & _
                               "INNER JOIN dAp Ap ON c.idAp=Ap.idAp Where " & vWhere
        sAdapter.Fill(sDt)
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูล", sSystemName)
            dgvOrder.DataSource = sDt
            Exit Sub
        Else
            dgvOrder.DataSource = sDt
            ksbCountRowDgv(dgvOrder, colCount.Name)
            mdConvertDateInGrid(dgvOrder, ColDateOrder)
            mdConvertDateInGrid(dgvOrder, ColDateReq)
        End If
    End Sub

    Sub CalOrderKg()
        Dim Kg As Double = 0.0
        For i As Integer = 0 To dgvOrder.Rows.Count - 1
            '--check idPkUnit
            If dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 1 Or dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 2 Or dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 4 Or dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 6 Then
                'กระป๋อง + ซอง + ถุง + กระสอบ
                If dgvOrder.Rows(i).Cells("ColidWeightUnit").Value = 1 Then
                    'weight: กรัม
                    Kg = (dgvOrder.Rows(i).Cells("ColWeight").Value / 1000) * dgvOrder.Rows(i).Cells("ColAmount").Value
                    dgvOrder.Rows(i).Cells("ColKgOrder").Value = Format(Kg, "#,##0.00")
                ElseIf dgvOrder.Rows(i).Cells("ColidWeightUnit").Value = 2 Then
                    'weight: Kg
                    Kg = dgvOrder.Rows(i).Cells("ColWeight").Value * dgvOrder.Rows(i).Cells("ColAmount").Value
                    dgvOrder.Rows(i).Cells("ColKgOrder").Value = Format(Kg, "#,##0.00")
                End If
            ElseIf dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 3 Then
                'กล่อง: *Perbox
                If dgvOrder.Rows(i).Cells("ColidWeightUnit").Value = 1 Then
                    'weight: กรัม
                    Kg = (dgvOrder.Rows(i).Cells("ColWeight").Value / 1000) * dgvOrder.Rows(i).Cells("ColAmount").Value * dgvOrder.Rows(i).Cells("ColPerbox").Value
                    dgvOrder.Rows(i).Cells("ColKgOrder").Value = Format(Kg, "#,##0.00")
                ElseIf dgvOrder.Rows(i).Cells("ColidWeightUnit").Value = 2 Then
                    'weight: Kg
                    Kg = dgvOrder.Rows(i).Cells("ColWeight").Value * dgvOrder.Rows(i).Cells("ColAmount").Value * dgvOrder.Rows(i).Cells("ColPerbox").Value
                    dgvOrder.Rows(i).Cells("ColKgOrder").Value = Format(Kg, "#,##0.00")
                End If
            ElseIf dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 5 Then
                'กิโลกรัม
                dgvOrder.Rows(i).Cells("ColKgOrder").Value = dgvOrder.Rows(i).Cells("ColAmount").Value
            End If
        Next
    End Sub

    Sub stStockPd()
        'select stock All Pd to sDt
        mdCnOpen()
        Dim vPkDt As New DataTable
        vPkDt.Clear()
        sCommand.CommandText = "Select idPdPk, Amount, idPdT From vPackingPdSet Order By idPdPk"
        sAdapter.Fill(vPkDt)
        pDataOngrid()

        For i As Integer = 0 To dgvOrder.Rows.Count - 1
            'Case1:check stock vPackingPdSet
            Dim orderAmt As Integer = 0
            Dim WeightKg As Double = 0
            Dim stAmtStock As Integer = 0
            Dim AmtNoUpD As Double = 0

            Dim sum_W As Double 'น้ำหนักทั้งหมด
            Dim MixPerc As Double
            Dim chk_MixPerc As Double 'ค่าน้ำหนักส่วนผสมเพื่อนำไปเปรียบเทียบ
            Dim idPd As Integer
            Dim Order_BalanceAVS As Double
            Dim Order_BalanceOther As Double
            Dim chk_Status As Integer
            Dim chk_AVS As Integer 'check AVS เก็บค่าว่าพอหรือไม่  0=ไม่พอ  1=พอ
            Dim chk_Other As Integer 'check บริษัทอื่นๆ เก็บค่าว่าพอหรือไม่  0=ไม่พอ  1=พอ
            Dim idPdPk_ As Integer = 0
            Dim stExiti As Integer = 0
            Dim Order_BalanceProcess As Double

            If dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 1 Or dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 2 Or dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 4 Or dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 6 Then
                orderAmt = dgvOrder.Rows(i).Cells("ColAmount").Value
            ElseIf dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 3 Then
                'แปลง box-->กระป๋อง/ซอง/ถุง/กระสอบ
                orderAmt = dgvOrder.Rows(i).Cells("ColAmount").Value * dgvOrder.Rows(i).Cells("ColPerbox").Value
            ElseIf dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 5 Then
                'แปลง kg-->กระป๋อง/ซอง/ถุง/กระสอบ เพื่อเช็ค stock vPackingPdSet
                If dgvOrder.Rows(i).Cells("ColidWeightUnit").Value = 1 Then
                    'gum
                    WeightKg = dgvOrder.Rows(i).Cells("ColWeight").Value / 1000
                ElseIf dgvOrder.Rows(i).Cells("ColidWeightUnit").Value = 2 Then
                    'kg
                    WeightKg = dgvOrder.Rows(i).Cells("ColWeight").Value
                End If
                orderAmt = dgvOrder.Rows(i).Cells("ColAmount").Value / WeightKg
            End If

            'loop check stock in sDt
            For m As Integer = 0 To vPkDt.Rows.Count - 1
                '******** 1st Case: check stock vPackingPdSet ***************'
                If dgvOrder.Rows(i).Cells("ColidPdPk").Value = vPkDt.Rows(m).Item("idPdPk") Then
                    idPdPk_ = dgvOrder.Rows(i).Cells("ColidPdPk").Value
                    AmtNoUpD = vPkDt.Rows(m).Item("Amount")
                    'If i = 1 Then
                    '    MessageBox.Show(vPkDt.Rows(m).Item("idPdPk"))
                    '    ' Dim testidPdPk As String = vPkDt.Rows(m).Item("idPdPk")
                    'End If

                    If orderAmt <= vPkDt.Rows(m).Item("Amount") Then
                        dgvOrder.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow 'พอ
                        dgvOrder.Rows(i).Cells("ColDetail").Style.BackColor = Color.White
                        vPkDt.Rows(m).Item("Amount") = vPkDt.Rows(m).Item("Amount") - orderAmt

                    Else
                        stAmtStock = 1 'ไม่พอ
                    End If

                    If stAmtStock = 1 Then
                        Dim Formula_Dt As New DataTable
                        Formula_Dt.Clear()
                        sCommand.CommandText = "Select idFl,idPd,MixPerc From SlPdIngredient Where idPdT=" & vPkDt.Rows(m).Item("idPdT") & ""
                        sAdapter.Fill(Formula_Dt)

                        ' Dim test As String = vPkDt.Rows(m).Item("idPdT")
                        'MessageBox.Show(i & "/" & sDt.Rows(m).Item("idPdT"))

                        Formula_Dt.DefaultView.Sort = "idFl ASC"
                        If Formula_Dt.Rows.Count = 0 Then
                            'MessageBox.Show("มีบางรายการที่ไม่พบข้อมูลส่วนผสมสินค้า จึงไม่สามารถแสดงสถานะสีได้", sSystemName)
                            Exit For 'Exit for m
                            stExiti = 1
                        End If

                        '******** 2st Case:check material AVS only ***************'
                        'pDataOngrid(sDt.Rows(m).Item("idPdT"))
                        chk_MixPerc = 0
                        sum_W = 0
                        Dim W_Kg As Double = 0.0
                        If dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 1 Or dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 2 Or dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 4 Or dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 6 Then 'กระป๋อง หรือ ซอง
                            Order_BalanceAVS = dgvOrder.Rows(i).Cells("ColAmount").Value - AmtNoUpD
                            sum_W = Order_BalanceAVS * dgvOrder.Rows(i).Cells("ColWeight").Value
                            If dgvOrder.Rows(i).Cells("ColidWeightUnit").Value = 1 Then 'กรัม แปลงเป็น กก
                                sum_W = sum_W / 1000
                            End If
                        ElseIf dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 3 Then 'กล่อง
                            'Perbox = dgvExpenseOrder.Rows(rowi).Cells("ColPerBox").Value
                            Order_BalanceAVS = (dgvOrder.Rows(i).Cells("ColAmount").Value * dgvOrder.Rows(i).Cells("ColPerbox").Value) - AmtNoUpD
                            sum_W = Order_BalanceAVS * dgvOrder.Rows(i).Cells("ColWeight").Value
                            If dgvOrder.Rows(i).Cells("ColidWeightUnit").Value = 1 Then 'กรัม แปลงเป็น กก
                                sum_W = sum_W / 1000
                            End If
                        ElseIf dgvOrder.Rows(i).Cells("ColidPkUnit").Value = 5 Then 'กก
                            If dgvOrder.Rows(i).Cells("ColidWeightUnit").Value = 1 Then 'กรัม แปลงเป็น กก
                                W_Kg = dgvOrder.Rows(i).Cells("ColWeight").Value / 1000
                            Else
                                W_Kg = dgvOrder.Rows(i).Cells("ColWeight").Value
                            End If
                            Order_BalanceAVS = dgvOrder.Rows(i).Cells("ColAmount").Value - (AmtNoUpD * W_Kg)
                            sum_W = Order_BalanceAVS
                        End If

                        Dim idPdT_ As Integer = vPkDt.Rows(m).Item("idPdT")
                        Dim count As Integer = 0 'ตัวนับจำนวนส่วนผสมในแต่ละสูตร
                        Dim j As Integer = 0
                        Dim idFl_ As Integer
                        For k As Integer = 0 To Formula_Dt.Rows.Count - 1 'loop เช็คทุกสูตร
                            idFl_ = Formula_Dt.Rows.Item(k).Item("idFl")
                            chk_AVS = 0
                            count = 0
                            For j = k To Formula_Dt.Rows.Count - 1
                                If idFl_ = Formula_Dt.Rows.Item(j).Item("idFl") Then
                                    idPd = Formula_Dt.Rows.Item(j).Item("idPd")
                                    MixPerc = Formula_Dt.Rows.Item(j).Item("MixPerc")
                                    chk_MixPerc = sum_W * (MixPerc / 100)
                                    'check ส่วนผสมใน stock AVS
                                    For n As Integer = 0 To flDt.Rows.Count - 1
                                        If idPdT_ = flDt.Rows.Item(n).Item("idPdT") Then ' check idPdT ที่เหมือนกัน
                                            If idPd = flDt.Rows.Item(n).Item("idPd") Then
                                                If chk_MixPerc <= flDt.Rows(n).Item("Balance_avs") Then
                                                    chk_AVS = chk_AVS + 1 'พอ
                                                Else
                                                    chk_AVS = chk_AVS + 0 'ไม่พอ
                                                End If
                                                Exit For
                                            End If
                                        End If
                                    Next
                                    count += 1 'ตัวนับวัตถุดิบทั้งหมดในสูตรนั้นว่า มีพอครบทุกตัว ?
                                Else
                                    j = j - 1
                                    Exit For
                                End If
                            Next
                            If count = chk_AVS Then
                                dgvOrder.Rows(i).DefaultCellStyle.BackColor = Color.Khaki ' material avs stock พอ
                                dgvOrder.Rows(i).Cells("ColDetail").Style.BackColor = Color.White
                                chk_Status = 1 'พอ
                                'ลดค่าใน avs stock ของส่วนผสมนั้นๆ
                                For rowi As Integer = 0 To Formula_Dt.Rows.Count - 1
                                    If idFl_ = Formula_Dt.Rows.Item(rowi).Item("idFl") Then
                                        idPd = Formula_Dt.Rows.Item(rowi).Item("idPd")
                                        MixPerc = Formula_Dt.Rows.Item(rowi).Item("MixPerc")
                                        chk_MixPerc = sum_W * (MixPerc / 100)

                                        For n As Integer = 0 To flDt.Rows.Count - 1
                                            If idPdT_ = flDt.Rows.Item(n).Item("idPdT") Then
                                                If idPd = flDt.Rows.Item(n).Item("idPd") Then
                                                    'ลบค่าใน avs stock ของส่วนผสมนั้นๆ
                                                    flDt.Rows(n).Item("Balance_avs") = flDt.Rows(n).Item("Balance_avs") - chk_MixPerc
                                                    Exit For
                                                End If
                                            End If
                                        Next
                                        For rowN As Integer = 0 To vPkDt.Rows.Count - 1
                                            If idPdPk_ = vPkDt.Rows(rowN).Item("idPdPk") Then
                                                vPkDt.Rows(rowN).Item("Amount") = 0
                                                Exit For
                                            End If
                                        Next
                                    End If
                                Next
                                '--??--'
                                Exit For
                            End If
                            k = j
                        Next

                        If count <> chk_AVS Then
                            'MessageBox.Show("ส่วนผสมใน AVS ไม่เพียงพอต่อความต้องการ ", sSystemName)
                            chk_Status = 0 'ไม่พอ
                        End If

                        '******** 3nd Case: check material Green + Flo ***************'
                        '###### ใน AVS ไม่พอ >>> Check บริษัท อื่นๆ #####################
                        If chk_Status = 0 Then
                            For k As Integer = 0 To Formula_Dt.Rows.Count - 1
                                chk_Other = 0
                                count = 0
                                For j = k To Formula_Dt.Rows.Count - 1
                                    If Formula_Dt.Rows.Item(k).Item("idFl") = Formula_Dt.Rows.Item(j).Item("idFl") Then
                                        idFl_ = Formula_Dt.Rows.Item(k).Item("idFl")
                                        idPd = Formula_Dt.Rows.Item(j).Item("idPd")
                                        MixPerc = Formula_Dt.Rows.Item(j).Item("MixPerc")
                                        chk_MixPerc = sum_W * (MixPerc / 100)
                                        'check ส่วนผสมใน stock AVS
                                        For n As Integer = 0 To flDt.Rows.Count - 1
                                            If idPdT_ = flDt.Rows.Item(n).Item("idPdT") Then
                                                If idPd = flDt.Rows.Item(n).Item("idPd") Then
                                                    'คำนวณค่าที่เหลือ ที่ต้องการนำไปcheckกับบริษัทอื่นๆ
                                                    Order_BalanceOther = chk_MixPerc - flDt.Rows(n).Item("Balance_avs")
                                                    If Order_BalanceOther <= flDt.Rows(n).Item("SumOther") Then
                                                        chk_Other = chk_Other + 1 'พอ
                                                    Else
                                                        chk_Other = chk_Other + 0 'ไม่พอ
                                                    End If
                                                    Exit For
                                                End If
                                            End If
                                        Next
                                        count += 1
                                    Else
                                        j = j - 1
                                        Exit For
                                    End If
                                Next
                                If count = chk_Other Then
                                    dgvOrder.Rows(i).DefaultCellStyle.BackColor = Color.MediumPurple ' material avs + green + Flo พอ
                                    dgvOrder.Rows(i).Cells("ColDetail").Style.BackColor = Color.White
                                    chk_Status = 1 'พอ

                                    For x As Integer = 0 To Formula_Dt.Rows.Count - 1
                                        If idFl_ = Formula_Dt.Rows.Item(x).Item("idFl") Then
                                            idPd = Formula_Dt.Rows.Item(x).Item("idPd")
                                            MixPerc = Formula_Dt.Rows.Item(x).Item("MixPerc")
                                            chk_MixPerc = sum_W * (MixPerc / 100)

                                            For n As Integer = 0 To flDt.Rows.Count - 1
                                                If idPdT_ = flDt.Rows.Item(n).Item("idPdT") Then
                                                    If idPd = flDt.Rows.Item(n).Item("idPd") Then
                                                        Order_BalanceOther = chk_MixPerc - flDt.Rows(n).Item("Balance_avs")
                                                        flDt.Rows(n).Item("Balance_avs") = 0
                                                        flDt.Rows(n).Item("SumOther") = flDt.Rows(n).Item("SumOther") - Order_BalanceOther
                                                        Exit For
                                                    End If
                                                End If
                                            Next

                                            For rowN As Integer = 0 To vPkDt.Rows.Count - 1
                                                If idPdPk_ = vPkDt.Rows(rowN).Item("idPdPk") Then
                                                    vPkDt.Rows(rowN).Item("Amount") = 0
                                                    Exit For
                                                End If

                                            Next
                                        End If
                                    Next

                                    Exit For
                                End If
                                k = j
                            Next
                            If count <> chk_Other Then
                                chk_Status = 0 'ไม่พอ
                            End If
                        End If

                        '******** 4nd Case: check between processes Green + Flo ***************'
                        '###### บริษัท อื่นๆ ไม่พอ >>>> check เมล็ดระหว่างกระบวนการ Green + Flo #####################
                        If chk_Status = 0 Then
                            For k As Integer = 0 To Formula_Dt.Rows.Count - 1
                                chk_Other = 0
                                count = 0
                                For j = k To Formula_Dt.Rows.Count - 1
                                    If Formula_Dt.Rows.Item(k).Item("idFl") = Formula_Dt.Rows.Item(j).Item("idFl") Then
                                        idFl_ = Formula_Dt.Rows.Item(k).Item("idFl")
                                        idPd = Formula_Dt.Rows.Item(j).Item("idPd")
                                        MixPerc = Formula_Dt.Rows.Item(j).Item("MixPerc")
                                        chk_MixPerc = sum_W * (MixPerc / 100)
                                        'check ส่วนผสมใน stock AVS
                                        For n As Integer = 0 To flDt.Rows.Count - 1
                                            If idPdT_ = flDt.Rows.Item(n).Item("idPdT") Then
                                                If idPd = flDt.Rows.Item(n).Item("idPd") Then
                                                    'คำนวณค่าที่เหลือ ที่ต้องการนำไปcheckกับบริษัทอื่นๆ
                                                    Order_BalanceProcess = chk_MixPerc - flDt.Rows(n).Item("Balance_avs") - flDt.Rows(n).Item("SumOther")
                                                    If Order_BalanceProcess <= flDt.Rows(n).Item("BalancePc_") Then
                                                        chk_Other = chk_Other + 1 'พอ
                                                    Else
                                                        chk_Other = chk_Other + 0 'ไม่พอ
                                                    End If
                                                    Exit For
                                                End If
                                            End If
                                        Next
                                        count += 1
                                    Else
                                        j = j - 1
                                        Exit For
                                    End If
                                Next
                                If count = chk_Other Then
                                    dgvOrder.Rows(i).DefaultCellStyle.BackColor = Color.DarkOrange ' material avs + green + Flo พอ
                                    dgvOrder.Rows(i).Cells("ColDetail").Style.BackColor = Color.White
                                    chk_Status = 1 'พอ

                                    For x As Integer = 0 To Formula_Dt.Rows.Count - 1
                                        If idFl_ = Formula_Dt.Rows.Item(x).Item("idFl") Then
                                            idPd = Formula_Dt.Rows.Item(x).Item("idPd")
                                            MixPerc = Formula_Dt.Rows.Item(x).Item("MixPerc")
                                            chk_MixPerc = sum_W * (MixPerc / 100)

                                            For n As Integer = 0 To flDt.Rows.Count - 1
                                                If idPdT_ = flDt.Rows.Item(n).Item("idPdT") Then
                                                    If idPd = flDt.Rows.Item(n).Item("idPd") Then
                                                        Order_BalanceOther = chk_MixPerc - flDt.Rows(n).Item("Balance_avs")
                                                        Order_BalanceProcess = Order_BalanceOther - flDt.Rows(n).Item("SumOther")
                                                        flDt.Rows(n).Item("BalancePc_") = flDt.Rows(n).Item("BalancePc_") - Order_BalanceProcess
                                                        flDt.Rows(n).Item("Balance_avs") = 0
                                                        flDt.Rows(n).Item("SumOther") = 0
                                                        Exit For
                                                    End If
                                                End If
                                            Next

                                            For rowN As Integer = 0 To vPkDt.Rows.Count - 1
                                                If idPdPk_ = vPkDt.Rows(rowN).Item("idPdPk") Then
                                                    vPkDt.Rows(rowN).Item("Amount") = 0
                                                    Exit For
                                                End If

                                            Next
                                        End If
                                    Next

                                    Exit For
                                End If
                                k = j
                            Next
                            If count <> chk_Other Then
                                dgvOrder.Rows(i).DefaultCellStyle.BackColor = Color.Salmon
                                dgvOrder.Rows(i).Cells("ColDetail").Style.BackColor = Color.White
                                chk_Status = 0 'ไม่พอ
                            End If
                        End If
                    End If
                    '--เจอสินค้าที่ค้นหาและตรวจสอบ stock แล้ว
                    Exit For
                End If
            Next
            If stExiti = 1 Then
                Exit For 'exit for i
            End If
        Next
    End Sub


    Private Sub pDataOngrid()
        mdCnOpen()
        Dim vDt_ As New DataTable
        Dim vFields As String = ""
        vDt_.Clear()

        vFields = "idPd, PdName, SeedTypeName, "
        vFields &= "ISNULL((SELECT SUM(Amount) FROM dbo.PkPdLotStock WHERE idPd = vSsProductStoreBalance.idPd),0.00) As AvStock, "
        vFields &= "isnull(S6,0.00) as S6,"
        vFields &= "ISNULL((SELECT SUM(EstimateW) AS Expr1 FROM dbo.vPdIndexJobDt WHERE (stCancel IS NULL) AND (idPd = vSsProductStoreBalance.idPd) " & _
                " AND (idSeedType = vSsProductStoreBalance.idSeedType) AND (idCompb = vSsProductStoreBalance.idCompb) And (idJobLine <> '0' And idJobLine <> '9' " & _
                " And idJobLine <> '10')),0.00) AS EstimateW,0.00 as BalancePc, "
        vFields &= " ISNULL((isnull(S1NOW,0.00)+isnull(WIP1,0.00)+isnull(Bake,0.00)+isnull(S2,0.00)+isnull(S3,0.00)+isnull(S4,0.00)+isnull(WIP4,0.00)" & _
              "+isnull(S5,0.00)+isnull(S6,0.00)),0.00) as StoreBalance,SalePrice,0.00 as SaleValue,idCompb "

        sCommand.CommandText = "Select " & vFields & " From vSsProductStoreBalance WHERE idPd IS NOT NULL Order By StoreBalance"
        sAdapter.Fill(vDt_)

        pDataAll()

        For Each vDr As DataRow In vDt_.Rows
            vDr.Item("SaleValue") = vDr.Item("SalePrice") * vDr.Item("StoreBalance")
            vDr.Item("BalancePc") = vDr.Item("StoreBalance") - vDr.Item("S6")
        Next

        For i As Integer = 0 To vDt_.Rows.Count - 1
            For j As Integer = 0 To flDt.Rows.Count - 1
                If vDt_.Rows(i).Item("PdName") = flDt.Rows(j).Item("PdName") Then
                    If vDt_.Rows(i).Item("idCompb") = 2 Then
                        flDt.Rows(j).Item("Balance_Green") = Format(vDt_.Rows(i).Item("StoreBalance"), "#,##0.00")
                        flDt.Rows(j).Item("BalancePC_Green") = Format(vDt_.Rows(i).Item("BalancePc"), "#,##0.00")
                        flDt.Rows(j).Item("S6_Green") = Format(vDt_.Rows(i).Item("S6"), "#,##0.00")
                    End If
                    If vDt_.Rows(i).Item("idCompb") = 1 Then
                        flDt.Rows(j).Item("Balance_Flo") = Format(vDt_.Rows(i).Item("StoreBalance"), "#,##0.00")
                        flDt.Rows(j).Item("BalancePC_Flo") = Format(vDt_.Rows(i).Item("BalancePc"), "#,##0.00")
                        flDt.Rows(j).Item("S6_Flo") = Format(vDt_.Rows(i).Item("S6"), "#,##0.00")
                    End If

                    ' If vDt_.Rows(i).Item("idCompb") = 8 Then
                    flDt.Rows(j).Item("Balance_avs") = Format(vDt_.Rows(i).Item("AvStock"), "#,##0.00")
                    'End If
                    flDt.Rows(j).Item("StoreBalance_") = Format(flDt.Rows(j).Item("Balance_Green") + flDt.Rows(j).Item("Balance_Flo") + flDt.Rows(j).Item("Balance_avs"), "#,##0.00")
                    flDt.Rows(j).Item("BalancePc_") = Format(flDt.Rows(j).Item("BalancePC_Green") + flDt.Rows(j).Item("BalancePC_Flo"), "#,##0.00")
                End If
            Next
        Next

        For n As Integer = 0 To flDt.Rows.Count - 1
            flDt.Rows(n).Item("SumOther") = Format(flDt.Rows(n).Item("S6_Green") + flDt.Rows(n).Item("S6_Flo"), "#,##0.00")
        Next

    End Sub

    Private Sub pDataAll()
        flDt.Clear()
        sCommand.CommandText = "Select Distinct  i.idPdT,v.idPd,v.PdName,v.SeedTypeName,0.00 As BalancePC_Green,0.00 As BalancePC_Flo,0.00 As S6_Green,0.00 As S6_Flo " & _
                               ",0.00 As Balance_Green,0.00 As Balance_Flo,0.00 As Balance_avs,0.00 As StoreBalance_,0.00 As SumOther ,0.00 As BalancePc_  From vSeedProduct v " & _
                               "LEFT JOIN SlPdIngredient i ON i.idPd = v.idPd " & _
                               "LEFT JOIN vSsProductStoreBalance s ON i.idPd = s.idPd " & _
                               " WHERE (i.idPdT IS NOT NULL) Order By v.SeedTypeName"
        sAdapter.Fill(flDt)
    End Sub

    Private Sub BindCus()
        mdCnOpen()
        Dim sDt As New DataTable
        'sCommand.CommandText = "Select distinct ord.idCus, c.CusName_ From SmSaleOrderMt ord INNER JOIN vCustomer c " & _
        '                       "ON ord.idCus=c.idCus ORDER BY c.CusName_"
        sCommand.CommandText = "Select distinct ord.idCus, c.CusName_ From SmSaleOrderMt ord " & _
                               "INNER JOIN SmSaleOrderDt dt ON ord.idSaleOrder = dt.idSaleOrder " & _
                               "INNER JOIN vCustomer c ON ord.idCus = c.idCus " & _
                               "Where ord.idPsAccept is Not NULL AND ord.idPsCheck is Not NULL " & _
                               "AND ord.idPsApp is Not NULL AND dt.stSet is NULL AND dt.idSale IS NULL ORDER BY c.CusName_"
        sAdapter.Fill(sDt)

        With cmbCus
            .DisplayMember = "CusName_"
            .ValueMember = "idCus"
            .DataSource = sDt
        End With
    End Sub

    Private Sub BindPsSale()
        mdCnOpen()
        Dim sDt As New DataTable
        'sCommand.CommandText = "Select distinct ord.idPsSale, p.PsName From SmSaleOrderMt ord INNER JOIN vPerson p " & _
        '                       "ON ord.idPsSale=p.idPs ORDER BY p.PsName"
        sCommand.CommandText = "Select distinct ord.idPsSale, p.PsName From SmSaleOrderMt ord " & _
                               "INNER JOIN SmSaleOrderDt dt ON ord.idSaleOrder = dt.idSaleOrder " & _
                               "INNER JOIN vPerson p ON ord.idPsSale=p.idPs " & _
                               "Where ord.idPsAccept is Not NULL AND ord.idPsCheck is Not NULL " & _
                               "AND ord.idPsApp is Not NULL AND dt.stSet is NULL AND dt.idSale IS NULL ORDER BY p.PsName"
        sAdapter.Fill(sDt)

        With cmbPsSale
            .DisplayMember = "PsName"
            .ValueMember = "idPsSale"
            .DataSource = sDt
        End With
    End Sub

    Private Sub BindPdPk()
        mdCnOpen()
        Dim sDt As New DataTable
        'sCommand.CommandText = "Select distinct d.idPdPk, p.PdPkName From SmSaleOrderDt d INNER JOIN vPackingPdSet p " & _
        '                       "ON d.idPdPk = p.idPdPk ORDER BY p.PdPkName"
        sCommand.CommandText = "Select distinct d.idPdPk, p.PdPkName From SmSaleOrderDt d " & _
                               "INNER JOIN SmSaleOrderMt mt ON d.idSaleOrder = mt.idSaleOrder " & _
                               "INNER JOIN vPackingPdSet p ON d.idPdPk = p.idPdPk " & _
                               "Where mt.idPsAccept is Not NULL AND mt.idPsCheck is Not NULL " & _
                               "AND mt.idPsApp is Not NULL AND d.stSet is NULL AND d.idSale IS NULL ORDER BY  p.PdPkName"
        sAdapter.Fill(sDt)

        With CmbPd
            .DisplayMember = "PdPkName"
            .ValueMember = "idPdPk"
            .DataSource = sDt
        End With
    End Sub

    Private Sub rdbCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCus.CheckedChanged
        If Me.rdbCus.Checked = True Then
            Me.cmbCus.Enabled = True
        Else
            Me.cmbCus.Enabled = False
        End If
    End Sub

    Private Sub rdbPsSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPsSale.CheckedChanged
        If Me.rdbPsSale.Checked = True Then
            Me.cmbPsSale.Enabled = True
        Else
            Me.cmbPsSale.Enabled = False
        End If
    End Sub

    Private Sub rdbPd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPd.CheckedChanged
        If Me.rdbPd.Checked = True Then
            Me.CmbPd.Enabled = True
        Else
            Me.CmbPd.Enabled = False
        End If
    End Sub

    Private Sub rdbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAll.CheckedChanged
        If Me.rdbAll.Checked = True Then
            Me.cmbCus.Enabled = False
            Me.cmbPsSale.Enabled = False
            Me.CmbPd.Enabled = False
        End If
    End Sub

    Private Sub dgvOrder_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrder.CellClick
        '----PdTStock Check----'
        If dgvOrder.Columns(e.ColumnIndex).Name = Me.ColPdPkName.Name Then
            Dim vFrm As New frmPdTStockCheck
            Pdidpk = dgvOrder.CurrentRow.Cells("ColidPdPk").Value
            OrderAmt = dgvOrder.CurrentRow.Cells("ColAmount").Value
            UnitPk = dgvOrder.CurrentRow.Cells("ColidPkUnit").Value
            Perbox = dgvOrder.CurrentRow.Cells("ColPerbox").Value
            OrderUnit = dgvOrder.CurrentRow.Cells("ColidPkUnit").Value
            vFrm.ShowText(Pdidpk, OrderAmt, UnitPk, Perbox, OrderUnit)
            vFrm.Show()
        End If
    End Sub

    Private Sub dgvOrder_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrder.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvOrder.Columns(e.ColumnIndex).Name = ColDetail.Name Then
            Dim vFrm As New frmPdTStockCheck
            Pdidpk = dgvOrder.CurrentRow.Cells("ColidPdPk").Value
            OrderAmt = dgvOrder.CurrentRow.Cells("ColAmount").Value
            UnitPk = dgvOrder.CurrentRow.Cells("ColidPkUnit").Value
            Perbox = dgvOrder.CurrentRow.Cells("ColPerbox").Value
            OrderUnit = dgvOrder.CurrentRow.Cells("ColidPkUnit").Value
            vFrm.ShowText(Pdidpk, OrderAmt, UnitPk, Perbox, OrderUnit)
            vFrm.Show()
        End If
    End Sub

   
End Class