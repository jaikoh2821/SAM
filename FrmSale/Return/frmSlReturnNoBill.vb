Imports DevExpress.XtraSplashScreen

Public Class frmSlReturnNoBill

    Public dtSmSale As New DataTable
    Dim eEvent As eProcess
    Dim idSaleCutDt As New DataTable
    Dim DefaultDate As Date
    Dim gidComp As Integer = 0
    Dim gLotNo As String = ""
    Dim gidPartner As Integer = 0
    Dim gPartnerName As String = ""
    Dim stOpen As Integer = 0
    Public gidInvGroup As Integer = 0
    Dim idProduct As Integer = 0
    Dim sDt_Temp As New DataTable
    Enum eProcess
        eTs153
        eAddNew
        ' eDelete
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal vDateMFG As Date, ByVal idComp As Integer, ByVal LotNo As String,
            ByVal idPartner As Integer, ByVal PartnerName As String, ByVal idSaleDt As DataTable, ByVal tidProduct As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eTs153
                'stPage = 1
                DefaultDate = vDateMFG
        End Select

        gidComp = idComp
        eEvent = aProcess
        gLotNo = LotNo
        gidPartner = idPartner
        gPartnerName = PartnerName
        idSaleCutDt = idSaleDt
        idProduct = tidProduct
    End Sub

    Private Sub frmSlReturnNoBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        fnAddDataTable(dtSmSale)
        If eEvent = eProcess.eTs153 Then
            Me.dtpDateMFG.Value = DefaultDate

            txtLotNo.Text = Trim(gLotNo)

            mdCnOpen()
            mdLoadShow()
            fnFindLotNoInSmSale()
            mdLoadCommitt()
        ElseIf eEvent = eProcess.eAddNew Then
            PanelControl1.Visible = False
            Me.NVNewLot.Visible = True
            Me.NVNewLot.Expanded = True
            Me.NVLotxSmSale.Visible = False
            'ChkOld.Visible = False

            Me.NVLotxSmSale.Visible = False

            NavBarControl1.Size = New Size(912, 200)
            Me.Size = New Size(928, 300)

            DefaultDate = Date.Now
        End If


    End Sub

    Private Sub frmSlReturnNoBill_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If lblPdName.Text <> "" Then
            txtAmount.Focus()
        End If
    End Sub

    Private Sub fnAddDataTable(ByVal dt As DataTable)

        dt.Columns.Add("idSale", System.Type.GetType("System.Int64"))
        dt.Columns.Add("idSaleDt", System.Type.GetType("System.Int64"))
        dt.Columns.Add("DocRef", System.Type.GetType("System.String"))
        dt.Columns.Add("idLot", System.Type.GetType("System.Int64"))
        dt.Columns.Add("LotNo", System.Type.GetType("System.String"))
        dt.Columns.Add("idProduct", System.Type.GetType("System.Int64"))
        dt.Columns.Add("ProductName", System.Type.GetType("System.String"))
        dt.Columns.Add("idUnit", System.Type.GetType("System.Int64"))
        dt.Columns.Add("UnitName", System.Type.GetType("System.String"))
        dt.Columns.Add("PriceSale", System.Type.GetType("System.Double")) 'ราคาขาย
        dt.Columns.Add("AmtSale", System.Type.GetType("System.Double")) 'จำนวนขาย
        dt.Columns.Add("DateGen", System.Type.GetType("System.DateTime"))
        dt.Columns.Add("AmountRT", System.Type.GetType("System.Double"))
        dt.Columns.Add("idInvGroup", System.Type.GetType("System.Int64"))
    End Sub


    Private Sub fnFindLotNoInSmSale()

        Dim vWhere As String = ""
        If idSaleCutDt.Rows.Count > 0 Then
            Dim stridCut As String = ""

            For i As Integer = 1 To idSaleCutDt.Rows.Count - 1
                stridCut = stridCut & " AND (dt.idSaleDt <> " & idSaleCutDt.Rows(i).Item("idSaleDt") & ") "
            Next

            vWhere = vWhere & " AND (dt.idSaleDt <> " & idSaleCutDt.Rows(0).Item("idSaleDt") & stridCut & ") "
        End If

        'If Me.ChkOld.Checked = False Then ' Sale in 2 years
        '    Dim vDateToday As String = Date.Today.ToShortDateString
        '    Dim Date2Year As String = CDate(vDateToday).AddYears(-2)
        '    vWhere = vWhere & " AND mt.DateSale >= '" & ksbDateToString(Date2Year) & "' "
        'End If

        If gidComp = 4 Or gidComp = 10 Then
            vWhere = vWhere & " AND lm.CompRec IN (4,10) "
        Else
            vWhere = vWhere & " AND lm.CompRec = " & gidComp
        End If

        If idProduct <> 0 And gLotNo = "" Then
            vWhere = vWhere & "AND dt.idProduct = " & idProduct
        ElseIf idProduct <> 0 And gLotNo <> "" Then
            vWhere = vWhere & "AND dt.idProduct = " & idProduct
            vWhere = vWhere & "AND dt.LotNo = '" & Trim(txtLotNo.Text.Trim) & "'"
        Else
            vWhere = vWhere & "AND dt.LotNo = '" & Trim(txtLotNo.Text.Trim) & "'"
        End If

        '--- Find Lot สินค้า ---'
        Dim sDt As New DataTable

        sCommand.CommandText = "SELECT CONVERT(bit,0) As chk, mt.DocRef, dt.idSaleDt, mt.idSale, dt.idLot, dt.LotNo, dt.idProduct, dt.idUnit, dt.ProductName, inv.idInvGroup, " & vbNewLine &
                                "lm.DateGen, unit.UnitName, dt.Price, dt.Amount As AmtSale, mt.PartnerNameBill As PartnerName, mt.idPartner" & vbNewLine &
                                "FROM SmSaleDtAll As dt" & vbNewLine &
                                "LEFT JOIN SmSaleMt As mt ON dt.idSale = mt.idSale" & vbNewLine &
                                "LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine &
                                "LEFT JOIN dInvLotMain As lm ON dt.idLot = lm.idLot" & vbNewLine &
                                "LEFT JOIN dInventoryMain As inv ON lm.idInvMain = inv.idInvMain" & vbNewLine &
                                "WHERE ISNULL(lm.stDel,0) = 0  " & vbNewLine &
                                "AND mt.idPsCancel Is NULL" & vbNewLine &
                                "AND mt.idPartner = " & gidPartner & vbNewLine &
                                vWhere & vbNewLine &
                                "Order By DocRef ASC"
        sAdapter.Fill(sDt)


        '---- กรณีที่ Lot No (Case: =) ไม่มีรายการขายของลูกค้าคนนี้
        If sDt.Rows.Count = 0 Then

            '-----เชค Lot No (Case: Like '%%') ของลูกค้าคนนี้
            Dim vWhereLike As String = ""
            If idSaleCutDt.Rows.Count > 0 Then
                Dim stridCut As String = ""

                For i As Integer = 1 To idSaleCutDt.Rows.Count - 1
                    stridCut = stridCut & " AND (dt.idSaleDt <> " & idSaleCutDt.Rows(i).Item("idSaleDt") & ") "
                Next

                vWhereLike = vWhereLike & " AND (dt.idSaleDt <> " & idSaleCutDt.Rows(0).Item("idSaleDt") & stridCut & ") "
            End If

            If gidComp = 4 Or gidComp = 10 Then
                vWhereLike = vWhereLike & " AND lm.CompRec IN (4,10) "
            Else
                vWhereLike = vWhereLike & " AND lm.CompRec = " & gidComp
            End If

            If idProduct <> 0 And gLotNo = "" Then
                vWhereLike = vWhereLike & "AND dt.idProduct = " & idProduct
            ElseIf idProduct <> 0 And gLotNo <> "" Then
                vWhereLike = vWhereLike & "AND dt.idProduct = " & idProduct
                vWhereLike = vWhereLike & "AND dt.LotNo = '%" & Trim(txtLotNo.Text.Trim) & "%'"
            Else
                vWhereLike = vWhereLike & "AND dt.LotNo Like '%" & Trim(txtLotNo.Text.Trim) & "%'"
            End If

            Dim sDtLike As New DataTable
            sCommand.CommandText = "SELECT CONVERT(bit,0) As chk, mt.DocRef, dt.idSaleDt, mt.idSale, dt.idLot, dt.LotNo, dt.idProduct, dt.idUnit, dt.ProductName, inv.idInvGroup, " & vbNewLine &
                                "lm.DateGen, unit.UnitName, dt.Price, dt.Amount As AmtSale, mt.PartnerNameBill As PartnerName, mt.idPartner" & vbNewLine &
                                "FROM SmSaleDtAll As dt" & vbNewLine &
                                "LEFT JOIN SmSaleMt As mt ON dt.idSale = mt.idSale" & vbNewLine &
                                "LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine &
                                "LEFT JOIN dInvLotMain As lm ON dt.idLot = lm.idLot" & vbNewLine &
                                "LEFT JOIN dInventoryMain As inv ON lm.idInvMain = inv.idInvMain" & vbNewLine &
                                "WHERE ISNULL(lm.stDel,0) = 0  " & vbNewLine &
                                "AND mt.idPsCancel Is NULL" & vbNewLine &
                                "AND mt.idPartner = " & gidPartner & vbNewLine &
                                vWhereLike & vbNewLine &
                                "Order By DocRef ASC"

            sAdapter.Fill(sDtLike)


            '-- Check Case: = ของลูกค้ารายอื่น
            If sDtLike.Rows.Count = 0 Then
                
                sDt.Clear()
                sCommand.CommandText = "SELECT distinct CONVERT(bit,0) As chk, dt.idLot, dt.LotNo, dt.idProduct, dt.idUnit, dt.ProductName, inv.idInvGroup, " & vbNewLine &
                                    "lm.DateGen, unit.UnitName, 0 As idSale, 0 As idSaleDt, mt.DocRef, dt.Amount As AmtSale, dt.Price" & vbNewLine &
                                    "FROM SmSaleDtAll As dt" & vbNewLine &
                                    "LEFT JOIN SmSaleMt As mt ON dt.idSale = mt.idSale" & vbNewLine &
                                    "LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine &
                                    "LEFT JOIN dInvLotMain As lm ON dt.idLot = lm.idLot" & vbNewLine &
                                    "LEFT JOIN dInventoryMain As inv ON lm.idInvMain = inv.idInvMain" & vbNewLine &
                                    "WHERE ISNULL(lm.stDel,0) = 0  " & vbNewLine &
                                    "AND mt.idPsCancel Is NULL" & vbNewLine &
                                    vWhere

                sAdapter.Fill(sDt)

                If sDt.Rows.Count > 0 Then

                    Me.NVLotxSmSale.Expanded = True
                    Me.NVLotxSmSale.Visible = True
                    'ChkOld.Visible = True
                    Me.NVNewLot.Visible = False
                    GCData.DataSource = sDt

                    NavBarControl1.Size = New Size(912, 526)
                    Me.Size = New Size(928, 611)

                    ColDocRef.Visible = False
                    ColAmtSale.Visible = False
                    ColUnitName.Visible = False
                Else

                    '-----เชค Lot No (Case: Like '%%') ของลูกค้าคนอื่น
                    sDtLike.Clear()
                    sCommand.CommandText = "SELECT distinct CONVERT(bit,0) As chk, dt.idLot, dt.LotNo, dt.idProduct, dt.idUnit, dt.ProductName, inv.idInvGroup, " & vbNewLine &
                                    "lm.DateGen, unit.UnitName, 0 As idSale, 0 As idSaleDt, mt.DocRef, dt.Amount As AmtSale, dt.Price" & vbNewLine &
                                    "FROM SmSaleDtAll As dt" & vbNewLine &
                                    "LEFT JOIN SmSaleMt As mt ON dt.idSale = mt.idSale" & vbNewLine &
                                    "LEFT JOIN dInvUnit As unit ON dt.idUnit = unit.idUnit" & vbNewLine &
                                    "LEFT JOIN dInvLotMain As lm ON dt.idLot = lm.idLot" & vbNewLine &
                                    "LEFT JOIN dInventoryMain As inv ON lm.idInvMain = inv.idInvMain" & vbNewLine &
                                    "WHERE ISNULL(lm.stDel,0) = 0  " & vbNewLine &
                                    "AND mt.idPsCancel Is NULL" & vbNewLine &
                                    vWhereLike

                    sAdapter.Fill(sDtLike)

                    If sDtLike.Rows.Count > 0 Then
                        ColPartnerName.Visible = False

                        Me.NVLotxSmSale.Expanded = True
                        Me.NVLotxSmSale.Visible = True
                        Me.NVNewLot.Visible = False

                        NavBarControl1.Size = New Size(912, 526)
                        Me.Size = New Size(928, 611)

                        GCData.DataSource = sDtLike

                        sDt_Temp = sDtLike
                        stOpen = 1
                        Exit Sub

                    Else

                        Dim vWhereLM As String = ""
                        If gidComp = 4 Or gidComp = 10 Then
                            vWhereLM = vWhereLM & " AND lm.CompRec IN (4,10) "
                        Else
                            vWhereLM = vWhereLM & " AND lm.CompRec = " & gidComp
                        End If

                        ' ถ้าหาแล้วไม่เจอจริงๆ ให้่หาจาก dInvLotMain
                        Dim dtLotMain As New DataTable
                        sCommand.CommandText = "SELECT distinct CONVERT(bit,0) As chk, lm.idLot, lm.LotNo, lm.idInvMain As idProduct, inv.idUnit, inv.InvName As ProductName, inv.idInvGroup, " & vbNewLine &
                                    "lm.DateGen, unit.UnitName, 0 As idSale, 0 As idSaleDt, '' As DocRef, 1 As AmtSale, 0 As Price" & vbNewLine &
                                    "FROM dInvLotMain As lm " & vbNewLine &
                                    "LEFT JOIN dInventoryMain As inv ON lm.idInvMain = inv.idInvMain" & vbNewLine &
                                    "LEFT JOIN dInvUnit unit ON inv.idUnit = unit.idUnit" & vbNewLine &
                                    "WHERE ISNULL(lm.stDel,0) = 0  " & vbNewLine &
                                   "AND lm.LotNo Like '%" & txtLotNo.Text.Trim & "%'" & vbNewLine &
                                   vWhereLM

                        sAdapter.Fill(dtLotMain)


                        If dtLotMain.Rows.Count > 0 Then
                            ColPartnerName.Visible = False

                            Me.NVLotxSmSale.Expanded = True
                            Me.NVLotxSmSale.Visible = True
                            Me.NVNewLot.Visible = False

                            NavBarControl1.Size = New Size(912, 526)
                            Me.Size = New Size(928, 611)

                            GCData.DataSource = dtLotMain

                            sDt_Temp = dtLotMain
                            stOpen = 1
                            Exit Sub

                        Else
                            Me.NVNewLot.Visible = True
                            Me.NVNewLot.Expanded = True
                            'ChkOld.Visible = False
                            btnAddLot.Visible = False
                            btnBlackSelectLot.Visible = False

                            Me.NVLotxSmSale.Visible = False

                            NavBarControl1.Size = New Size(912, 200)
                            Me.Size = New Size(928, 300)
                        End If

                    End If
                End If

            Else

                ColPartnerName.Visible = False

                Me.NVLotxSmSale.Expanded = True
                Me.NVLotxSmSale.Visible = True
                Me.NVNewLot.Visible = False

                NavBarControl1.Size = New Size(912, 526)
                Me.Size = New Size(928, 611)

                GCData.DataSource = sDtLike

                sDt_Temp = sDtLike
                stOpen = 1
                Exit Sub

            End If

        ElseIf sDt.Rows.Count = 1 Then
                ' มีรายการขายของ Lot No ของลูกค้าที่เลือก เพียง Row เดียว ส่งกลับไปเลย
                Dim drtemp As DataRow = dtSmSale.NewRow()

                drtemp("idSale") = sDt.Rows(0).Item("idSale")
                drtemp("idSaleDt") = sDt.Rows(0).Item("idSaleDt")
                drtemp("DocRef") = sDt.Rows(0).Item("DocRef")
                drtemp("idLot") = sDt.Rows(0).Item("idLot")
                drtemp("LotNo") = sDt.Rows(0).Item("LotNo")
                drtemp("idProduct") = sDt.Rows(0).Item("idProduct")
                drtemp("ProductName") = sDt.Rows(0).Item("ProductName")
                drtemp("idUnit") = sDt.Rows(0).Item("idUnit")
                drtemp("UnitName") = sDt.Rows(0).Item("UnitName")
                drtemp("PriceSale") = sDt.Rows(0).Item("Price")
                drtemp("AmtSale") = sDt.Rows(0).Item("AmtSale")
                drtemp("DateGen") = sDt.Rows(0).Item("DateGen")
                drtemp("idInvGroup") = sDt.Rows(0).Item("idInvGroup")
                drtemp("AmountRT") = 1

                dtSmSale.Rows.Add(drtemp)


                Me.NVLotxSmSale.Expanded = True
                Me.NVLotxSmSale.Visible = True
                'ChkOld.Visible = True
                Me.NVNewLot.Visible = False

                NavBarControl1.Size = New Size(912, 526)
                Me.Size = New Size(928, 611)


                If stOpen = 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else

                    'If gidPartner = sDt.Rows(0).Item("idPartner") Then
                    '    If ChkOld.Checked = False Then
                    '        NVLotxSmSale.Caption = "รายการขายของ" & gPartnerName & " ย้อนหลัง 2 ปี"
                    '    ElseIf ChkOld.Checked = True Then
                    '        NVLotxSmSale.Caption = "รายการขายของ" & gPartnerName & " ย้อนหลังมากกว่า 2 ปี"
                    '    End If
                    'Else
                    '    If ChkOld.Checked = False Then
                    '        NVLotxSmSale.Caption = "รายการขายของลูกค้ารายอื่น ย้อนหลัง 2 ปี"
                    '    ElseIf ChkOld.Checked = True Then
                    '        NVLotxSmSale.Caption = "รายการขายของลูกค้ารายอื่น ย้อนหลังมากกว่า 2 ปี"
                    '    End If
                    'End If

                    GCData.DataSource = sDt
                End If

            Else
                ' มีรายการขายของ Lot No ของลูกค้าที่เลือก มีหลาย Row ให้เลือก
                ColPartnerName.Visible = False
            'If ChkOld.Checked = False Then
            '    NVLotxSmSale.Caption = "รายการขายของ" & gPartnerName & " ย้อนหลัง 2 ปี"
            'ElseIf ChkOld.Checked = True Then
            '    NVLotxSmSale.Caption = "รายการขายของ" & gPartnerName & " ย้อนหลังมากกว่า 2 ปี"
            'End If

            Me.NVLotxSmSale.Expanded = True
            Me.NVLotxSmSale.Visible = True
            'ChkOld.Visible = True
            Me.NVNewLot.Visible = False

            GCData.DataSource = sDt

            NavBarControl1.Size = New Size(912, 526)
            Me.Size = New Size(928, 611)

        End If


        sDt_Temp = sDt
        stOpen = 1

    End Sub

    Private Sub btnAddLot_Click(sender As Object, e As EventArgs) Handles btnAddLot.Click
        Me.NVNewLot.Visible = True
        Me.NVNewLot.Expanded = True
        Me.NVLotxSmSale.Visible = False
        'ChkOld.Visible = False

        Me.NVLotxSmSale.Visible = False

        NavBarControl1.Size = New Size(912, 200)
        Me.Size = New Size(928, 300)
    End Sub

    Private Sub btnBlackSelectLot_Click(sender As Object, e As EventArgs) Handles btnBlackSelectLot.Click
        Me.NVLotxSmSale.Expanded = True
        Me.NVLotxSmSale.Visible = True
        'ChkOld.Visible = True
        Me.NVNewLot.Visible = False

        NavBarControl1.Size = New Size(912, 526)
        Me.Size = New Size(928, 611)
    End Sub

    'Select Lot
    Private Sub rptSelect_Click(sender As Object, e As EventArgs) Handles rptSelect.Click
        Dim drtemp As DataRow = dtSmSale.NewRow()

        drtemp("idSale") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColidSale)
        drtemp("idSaleDt") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColidSaleDt)
        drtemp("DocRef") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColDocRef)
        drtemp("idLot") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, colidLot)
        drtemp("LotNo") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColLotno)
        drtemp("idProduct") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, colidProduct)
        drtemp("ProductName") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColProductName)
        drtemp("idUnit") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, colidUnit)
        drtemp("UnitName") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColUnitName)
        drtemp("PriceSale") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColPrice)
        drtemp("AmtSale") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColAmtSale)
        drtemp("DateGen") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColDateGen)
        drtemp("AmountRT") = 1
        drtemp("idInvGroup") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, idInvGroup)
        dtSmSale.Rows.Add(drtemp)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub GvShowData_KeyDown(sender As Object, e As KeyEventArgs) Handles GvShowData.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim drtemp As DataRow = dtSmSale.NewRow()

            drtemp("idSale") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColidSale)
            drtemp("idSaleDt") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColidSaleDt)
            drtemp("DocRef") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColDocRef)
            drtemp("idLot") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, colidLot)
            drtemp("LotNo") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColLotno)
            drtemp("idProduct") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, colidProduct)
            drtemp("ProductName") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColProductName)
            drtemp("idUnit") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, colidUnit)
            drtemp("UnitName") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColUnitName)
            drtemp("PriceSale") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColPrice)
            drtemp("AmtSale") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColAmtSale)
            drtemp("DateGen") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColDateGen)
            drtemp("AmountRT") = 1
            drtemp("idInvGroup") = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, idInvGroup)
            dtSmSale.Rows.Add(drtemp)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub txtCost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCost.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtLotNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLotNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            fnFindLotNoInSmSale()
        End If
    End Sub

    Private Sub txtLotNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLotNo.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
                e.Handled = False
                e.KeyChar = Char.ToUpper(e.KeyChar)
            Case 8, 13 ' Backspace = 8, Enter = 13, Delete = 46, - = 45
                e.Handled = False
            Case Else
                e.Handled = True
                'mdLoadCommitt()
                'MessageBox.Show("กรุณาระบุข้อมูลเป็นภาษาอังกฤษหรือตัวเลขเท่านั้น", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub

    'Private Sub GvShowData_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GvShowData.RowCellClick

    '    MessageBox.Show("จำนวนขาย : " & Format(GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColAmtSale), "#,##0.####") & " " & _
    '                                  GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColUnitName) & vbCrLf & _
    '                    "ราคาต่อหน่วย : " & Format(GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColPrice), "#,##0.####") & " บาท", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

    'End Sub

    Private Sub btnFindPd_Click(sender As Object, e As EventArgs) Handles btnFindPd.Click
        Dim vFrm As New frmAllInvSelect(frmAllInvSelect.eProcess.eAll, gidComp)

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then

            lblPdName.Tag = vFrm.sdt1.Rows(0).Item("idInvMain")
            lblPdName.Text = vFrm.sdt1.Rows(0).Item("InvName")
            lblUnit.Tag = vFrm.sdt1.Rows(0).Item("idUnit")
            lblUnit.Text = vFrm.sdt1.Rows(0).Item("UnitName")
            gidInvGroup = vFrm.sdt1.Rows(0).Item("idInvGroup")
            Me.dtpDateMFG.Value = DefaultDate
            Me.txtAmount.Focus()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If eEvent = eProcess.eTs153 Then
            If Trim(Me.txtLotNo.Text) = "" Then
                MessageBox.Show("กรุณาระบุ Lot No. ที่รับคืน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.txtLotNo.Focus()
                Exit Sub
            ElseIf Me.lblPdName.Text = "" Then
                MessageBox.Show("กรุณาระบุชื่อสินค้าที่รับคืน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.btnFindPd.Focus()
                Exit Sub
            ElseIf Me.dtpDateMFG.Value.ToShortDateString > Date.Today Then
                MessageBox.Show("กรุณาระบุวันที่ผลิตสินค้าที่รับคืนให้ถูกต้อง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.btnFindPd.Focus()
                Exit Sub
            ElseIf CDbl(Trim(txtAmount.Text)) = 0 Then
                MessageBox.Show("กรุณาระบุจำนวนรับคืน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.txtAmount.Focus()
                Exit Sub

            End If

            Dim drtemp As DataRow = dtSmSale.NewRow()

            drtemp("idSale") = 0
            drtemp("idSaleDt") = 0
            drtemp("DocRef") = ""
            drtemp("idLot") = 0
            drtemp("LotNo") = Trim(txtLotNo.Text)
            drtemp("idProduct") = lblPdName.Tag
            drtemp("ProductName") = lblPdName.Text
            drtemp("idUnit") = lblUnit.Tag
            drtemp("UnitName") = lblUnit.Text
            drtemp("PriceSale") = 0
            drtemp("AmtSale") = 0
            drtemp("DateGen") = DefaultDate
            drtemp("AmountRT") = CDbl(Trim(txtAmount.Text))
            drtemp("idInvGroup") = gidInvGroup

            dtSmSale.Rows.Add(drtemp)


            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        ElseIf eEvent = eProcess.eAddNew Then

            Dim drtemp As DataRow = dtSmSale.NewRow()

            drtemp("idSale") = 0
            drtemp("idSaleDt") = 0
            drtemp("DocRef") = ""
            drtemp("idLot") = 0
            drtemp("LotNo") = ""
            drtemp("idProduct") = lblPdName.Tag
            drtemp("ProductName") = lblPdName.Text
            drtemp("idUnit") = lblUnit.Tag
            drtemp("UnitName") = lblUnit.Text
            drtemp("PriceSale") = 0
            drtemp("AmtSale") = 0
            drtemp("DateGen") = DefaultDate
            drtemp("AmountRT") = CDbl(Trim(txtAmount.Text))
            drtemp("idInvGroup") = gidInvGroup

            dtSmSale.Rows.Add(drtemp)


            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim dv As New DataView(sDt_Temp)
        dv.RowFilter = "chk=True"
        For i As Integer = 0 To dv.Count - 1
            Dim dr_ As DataRow = dtSmSale.NewRow


            dr_("idSale") = dv.Item(i).Item("idSale")
            dr_("idSaleDt") = dv.Item(i).Item("idSaleDt")
            dr_("DocRef") = dv.Item(i).Item("DocRef")
            dr_("idLot") = dv.Item(i).Item("idLot")
            dr_("LotNo") = dv.Item(i).Item("LotNo")
            dr_("idProduct") = dv.Item(i).Item("idProduct")
            dr_("ProductName") = dv.Item(i).Item("ProductName")
            dr_("idUnit") = dv.Item(i).Item("idUnit")
            dr_("UnitName") = dv.Item(i).Item("UnitName")
            dr_("PriceSale") = dv.Item(i).Item("Price")
            dr_("AmtSale") = dv.Item(i).Item("AmtSale")
            dr_("DateGen") = dv.Item(i).Item("DateGen")
            dr_("idInvGroup") = dv.Item(i).Item("idInvGroup")
            dr_("AmountRT") = 1


            dtSmSale.Rows.Add(dr_)

        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    'Private Sub ChkOld_CheckedChanged(sender As Object, e As EventArgs) Handles ChkOld.CheckedChanged
    '    mdCnOpen()
    '    SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
    '    fnFindLotNoInSmSale()
    '    SplashScreenManager.CloseForm(False)
    'End Sub

End Class