Imports DevExpress.XtraSplashScreen

Public Class frmSlOrderData
    Dim CopyMainDt As New DataTable
    Public idSaleOrderShow As String
    Public idCus As Integer
    Dim stload As Integer = 0
    Dim eEvent As eProcess

    Enum eProcess
        eView
        eCancel
        eAccept
        eCheck
        eApprove
        eNew
        eViewOrder 'Detail for OrderToSale
        eCloseOrder
    End Enum

    Sub New(ByVal aProcess As eProcess)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eNew
                Me.Text = "ทำรายการ/แก้ไขการสั่งซื้อสินค้า"
                Me.btnNew.Visible = True
                ColChk.Visible = False
                ColAct.Visible = False
                ColCheck.Visible = False
                ColApprove.Visible = False
                ColCancel.Visible = False
                ColEdit.Visible = True
                ColDoc.Visible = False
                ColShowDetail.Visible = False
                GroupBox2.Visible = False
                Panel6.Visible = False
                Panel2.Visible = False
            Case eProcess.eView
                'nothing
                ColChk.Visible = False
                ColAct.Visible = False
                ColCheck.Visible = False
                ColApprove.Visible = False
                ColCancel.Visible = False
                ColEdit.Visible = False
                ColDoc.Visible = False
                ColShowDetail.Visible = True
                Panel6.Visible = False
                Panel2.Visible = False
            Case eProcess.eCancel
                Me.Text = "ยกเลิกรายการสั่งซื้อสินค้า"
                ColChk.Visible = False
                ColAct.Visible = False
                ColCheck.Visible = False
                ColApprove.Visible = False
                ColCancel.Visible = True
                ColEdit.Visible = False
                ColDoc.Visible = False
                ColShowDetail.Visible = False
                Panel6.Visible = False
                Panel2.Visible = False
            Case eProcess.eAccept
                ' stPage = 2
                ColChk.Visible = False
                ColAct.Visible = True
                ColCheck.Visible = False
                ColApprove.Visible = False
                ColCancel.Visible = False
                ColEdit.Visible = False
                ColDoc.Visible = False
                ColShowDetail.Visible = False
                'Panel6.Visible = False
                Panel2.Visible = False
            Case eProcess.eCheck
                'stPage = 3
                ColChk.Visible = False
                ColAct.Visible = False
                ColCheck.Visible = True
                ColApprove.Visible = False
                ColCancel.Visible = False
                ColEdit.Visible = False
                ColDoc.Visible = False
                ColShowDetail.Visible = False
                Panel2.Visible = False
            Case eProcess.eApprove
                ' stPage = 4
                ColChk.Visible = True
                ColAct.Visible = False
                ColCheck.Visible = False
                ColApprove.Visible = True
                ColCancel.Visible = False
                ColEdit.Visible = False
                ColDoc.Visible = False
                ColShowDetail.Visible = False
                Me.btnApprove.Visible = True
                Panel2.Visible = False
            Case eProcess.eViewOrder
                'stPage = 6
                ColChk.Visible = False
                ColAct.Visible = False
                ColCheck.Visible = False
                ColApprove.Visible = False
                ColCancel.Visible = False
                ColEdit.Visible = False
                ColDoc.Visible = False
                ColShowDetail.Visible = True
                ColPartnerName.Visible = False
                Panel2.Visible = False
                Panel6.Visible = False
            Case eProcess.eCloseOrder
                Me.Text = "ทำรายการปิดการสั่งซื้อ"
                ColChk.Visible = False
                ColAct.Visible = False
                ColCheck.Visible = False
                ColApprove.Visible = False
                ColCancel.Visible = False
                ColEdit.Visible = False
                ColDoc.Visible = False
                ColShowDetail.Visible = False
                ColClose.Visible = True
                GroupBox2.Visible = False
                Panel2.Visible = False
                Panel6.Visible = False
        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmSlOrderData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtpYear.Value = Date.Now
        mdLoadShow()
        BindData()
        stload = 1
        mdLoadCommitt()
    End Sub

    Private Sub GVSaleMt_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVSaleOrderMt.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Sub BindData()
        mdCnOpen()
        Dim vWhere As String = ""
        Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")

        If Me.rdbDate.Checked = True Then
            Dim DateQTs As DateTime = Convert.ToDateTime(dtpDateS.Value, _cultureEnInfo)
            Dim DateQTe As DateTime = Convert.ToDateTime(dtpDateE.Value, _cultureEnInfo)

            vWhere &= "WHERE m.DateOrderD BETWEEN '" & DateQTs.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " & _
                      "AND '" & DateQTe.AddDays(1).AddSeconds(-1).ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "' "
        ElseIf Me.rdbMonth.Checked = True Then
            Dim sDate As DateTime = Convert.ToDateTime(dtpMonthS.Value, _cultureEnInfo)
            Dim sMonth As Integer = sDate.Month
            Dim sYear As Integer = sDate.Year

            vWhere &= "WHERE Month(m.DateOrderD) = " & sMonth & " AND YEAR(m.DateOrderD) = " & sYear & " "
        ElseIf Me.rdbYear.Checked = True Then
            Dim sDate As DateTime = Convert.ToDateTime(dtpYear.Value, _cultureEnInfo)
            Dim sYear As Integer = sDate.Year
            vWhere &= "WHERE YEAR(m.DateOrderD) = " & sYear & " "
        End If

        'If eEvent = eProcess.eAccept Then
        '    vWhere = vWhere & " AND m.idPsAccept Is Null And m.idPsCancel Is Null And (m.stApp <> '0' or m.stApp Is Null) "
        'ElseIf eEvent = eProcess.eCheck Then
        '    vWhere = vWhere & " AND m.idPsCheck Is Null And m.idPsCancel Is Null And (m.stApp <> '0' or m.stApp Is Null) "
        'ElseIf eEvent = eProcess.eApprove Then
        '    vWhere = vWhere & " AND m.idPsApp Is Null And m.stApp Is Null And m.idPsCancel Is Null "
        If eEvent = eProcess.eNew Then
            vWhere = vWhere & "And m.idPsCancel Is Null AND m.stOrd IS NULL"
        End If

        If eEvent = eProcess.eViewOrder Then
            'vWhere &= " AND mt.idComp = " & idComp_ & " AND mt.idCus = " & idCus_ & " AND mt.idQT <> " & idQtxCut_
        Else
            vWhere &= " AND m.idComp IN (" & SIdCompStr & ") "
        End If

        Dim vWhereClose As String = ""
        If eEvent = eProcess.eCloseOrder Then
            'vWhereClose = "Where (AmtSale < Amount OR (AmtSale = 0))"
            vWhere = vWhere & "And m.idPsCancel Is Null AND ISNULL(m.stOrd,0) <> 1"
        End If

        If chkApp.Checked = True Then
            vWhere = vWhere & "AND ISNULL(stApp,0) = 1"
        Else
            vWhere = vWhere & "AND (m.stApp IS NOT NULL OR m.stApp IS NULL)"
        End If



        Dim ds0 As New DataSet
        Dim MainDt As New DataTable  ' SaleOrderMt
        Dim SubDt As New DataTable  ' SaleOrderDt

        MainDt.Clear()
        sCommand.CommandText = "SELECT cast(0 as bit) as ChkKey, m.idSaleOrder, cp.CompCode, c.PartnerName, m.DateOrderD, m.DateRequireD, " & vbNewLine &
                               "m.DateTsD, m.TimeTs, m.DocCode, ISNULL(m.DocRef,'-') As DocRef, m.Note, p1.PsName As PsSale, " & vbNewLine &
                               "(CASE m.idPsOrder WHEN 0 THEN 'System' ELSE P2.PsName END) As PsOrder, ISNULL(m.stApp,0) As stApp,  " & vbNewLine &
                               "(CASE ISNULL(m.stSysOrder,0) WHEN  0 THEN 'PC' WHEN 1 THEN 'Mobile' WHEN 2 THEN 'Web Browser' WHEN 3 THEN 'PO System' END) AS stSysText, " & vbNewLine &
                               "m.idPsCancel, m.CancelNote, p3.PsName As PsCancel, m.stOrd, ISNULL(m.stSysOrder,0) As stSysOrder, " & vbNewLine &
                               "m.idComp, cp.CompName, (CASE m.idPsTs WHEN 0 THEN 'System' ELSE p4.PsName END) As PsTs, 0 As stOrdCal, " & vbNewLine &
                               "CASE WHEN ISNULL(m.stApp,0) = 1 THEN 'อนุมัติแล้ว' ELSE 'รออนุมัติ' END Status" & vbNewLine &
                               "From SmSaleOrderMt m " & vbNewLine &
                               "LEFT JOIN dPartner c ON m.idPartner = c.idPartner " & vbNewLine &
                               "LEFT JOIN vPersonxSelect p1 ON m.idPsSale = p1.idPs " & vbNewLine &
                               "LEFT JOIN vPersonxSelect p2 ON m.idPsOrder = p2.idPs " & vbNewLine &
                               "LEFT JOIN vPersonxSelect p3 ON m.idPsCancel = p3.idPs " & vbNewLine &
                               "LEFT JOIN vPersonxSelect p4 ON m.idPsTs = p4.idPs " & vbNewLine &
                               "LEFT JOIN PchInvAndProject.dbo.dCompany cp ON m.idComp = cp.idComp " & vbNewLine & vWhere & " Order by m.DocCode"
        sAdapter.Fill(MainDt)

        '----------------------- Dt table ----------------------------'
        SubDt.Clear()
        sCommand.CommandText = "With A As(SELECT ROW_NUMBER() OVER(PARTITION BY d.idSaleOrder ORDER BY d.idSaleOrderDt) As Num, " & vbNewLine &
                               "d.idSaleOrder, d.idSaleOrderDt, d.idInvMain, p.InvCode, p.InvName, d.Amount, u.UnitName, d.Note, " & vbNewLine &
                               "ISNULL((SELECT SUM(Amount) " & vbNewLine &
                                       "FROM SmSaleDtAll dt" & vbNewLine &
                                       "LEFT JOIN SmSaleMt mt ON dt.idSale = mt.idSale" & vbNewLine &
                                      "Where dt.idSaleOrderDt = d.idSaleOrderDt" & vbNewLine &
                                       "And mt.idPsCanCel IS NULL " & vbNewLine &
                                       "And idSlAVxST Is NULL" & vbNewLine &
                                       "AND d.idPscancel Is NULL),0) As AmtSale " & vbNewLine &
                               "FROM SmSaleOrderDt d " & vbNewLine &
                               "LEFT OUTER JOIN SmSaleOrderMt m On d.idSaleOrder = m.idSaleOrder " & vbNewLine &
                               "LEFT OUTER JOIN dInventoryMain p On d.idInvMain = p.idInvMain " & vbNewLine &
                               "LEFT OUTER JOIN dInvUnit u On d.idUnit = u.idUnit  " & vbNewLine &
                               vWhere & vbNewLine &
                               "AND d.idPsCancel Is NULL) " & vbNewLine &
                               "SELECT *, (Amount-AmtSale) As AmtBal " & vbNewLine &
                               "FROM A " & vbNewLine &
                              vWhereClose & vbNewLine &
                               "Order by idSaleOrderDt ASC"
        sAdapter.Fill(SubDt)

        'SubDt.Columns.Add("AmtBal", GetType(Double), "Amount - AmtSale")

        ds0.Tables.Clear()
        ds0.Tables.Add(MainDt)
        ds0.Tables.Add(SubDt)
        CopyMainDt = MainDt

        Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idSaleOrder")
        Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idSaleOrder")

        ds0.Relations.Add("รายการสั่งซื้อสินค้า", keyColumn, foreignColumn)

        ' วนลูปทุกแถวใน Master Table (MainDt)
        For Each rowMt As DataRow In MainDt.Rows
            ' ดึงรายการลูก (Detail) ผ่าน Relation ที่เราสร้างไว้
            Dim childRows() As DataRow = rowMt.GetChildRows("รายการสั่งซื้อสินค้า")

            If childRows.Length > 0 Then
                Dim totalItems As Integer = childRows.Length
                Dim soldFullCount As Integer = 0
                Dim notSoldCount As Integer = 0

                For Each rowDt As DataRow In childRows
                    ' ใช้ชื่อคอลัมน์จาก Query ของคุณ (Amount และ AmtSale)
                    Dim qtyOrder As Double = If(IsDBNull(rowDt("Amount")), 0, Convert.ToDouble(rowDt("Amount")))
                    Dim qtySold As Double = If(IsDBNull(rowDt("AmtSale")), 0, Convert.ToDouble(rowDt("AmtSale")))

                    ' ตรรกะเช็ครายบรรทัด
                    If qtySold >= qtyOrder AndAlso qtyOrder > 0 Then
                        soldFullCount += 1 ' ขายครบ หรือ เกิน
                    ElseIf qtySold <= 0 Then
                        notSoldCount += 1  ' ยังไม่มีการขาย
                    End If
                Next

                ' สรุปค่า stOrd ให้กับแถว Master
                If soldFullCount = totalItems Then
                    rowMt("stOrdCal") = 1 ' ทุกรายการในบิลขายครบหมดแล้ว
                ElseIf notSoldCount = totalItems Then
                    rowMt("stOrdCal") = 0 ' ทุกรายการในบิลยังไม่มีการขายเลย
                Else
                    rowMt("stOrdCal") = 2 ' มีบางรายการขายแล้ว หรือขายไปบางส่วน (เข้าเงื่อนไขรูปที่คุณส่งมา)
                End If
            Else
                ' กรณีบิลไม่มีรายการสินค้า
                rowMt("stOrdCal") = 0
            End If
        Next

        GridControl1.DataSource = ds0.Tables(0)
        GridControl1.ForceInitialize()

        GridControl1.LevelTree.Nodes.Add("รายการสั่งซื้อสินค้า", GVSaleOrderDt)

        FilterGridview()
        mdLoadCommitt()
        If MainDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูลรายการสั่งซื้อ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FilterGridview()
        Dim StrFilter As String = ""

        If rdbWeb.Checked = True Then
            StrFilter &= " And [stSysOrder] = 2 "
        ElseIf rdbPc.Checked = True Then
            StrFilter &= " And [stSysOrder] = 0 "
        ElseIf rdbPO.Checked = True Then
            StrFilter &= " And [stSysOrder] = 3 "
        End If


        'CusName
        If Me.ChkCus.Checked = True Then
            StrFilter &= " And [PartnerName] Like '%" & Trim(Me.txtCusName.Text) & "%' "
        End If

        'DocCode
        If Me.chkDocCode.Checked = True Then
            StrFilter &= " AND [DocCode] like '%" & txtDocCode.Text.Trim & "%'"
        End If

        GVSaleOrderMt.ActiveFilterString = "1=1 " & StrFilter
        txtCount.Text = Format(GVSaleOrderMt.DataRowCount, "#,##0")
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim vFrm As New frmSlOrderTs(frmSlOrderTs.eProcess.eAdd, 0)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
            btnNew.PerformClick()
        End If
    End Sub

    Private Sub GVSaleMt_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVSaleOrderMt.RowCellStyle
        If eEvent = eProcess.eNew Or eEvent = eProcess.eView Or eEvent = eProcess.eViewOrder Then
            If IsDBNull(GVSaleOrderMt.GetRowCellValue(e.RowHandle, ColidCancel1)) Then
                If Not IsDBNull(GVSaleOrderMt.GetRowCellValue(e.RowHandle, ColstOrd_cal)) Then
                    If GVSaleOrderMt.GetRowCellValue(e.RowHandle, ColstOrd_cal) = 1 Then 'ขายทุกรายการแล้ว
                        e.Appearance.BackColor = Color.YellowGreen
                    ElseIf GVSaleOrderMt.GetRowCellValue(e.RowHandle, ColstOrd_cal) = 2 Then 'ขายบางรายการ
                        e.Appearance.BackColor = Color.Khaki
                    End If
                End If
            End If
        End If

        If Not IsDBNull(GVSaleOrderMt.GetRowCellValue(e.RowHandle, ColidCancel1)) Then
            e.Appearance.BackColor = Color.Salmon
            e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Strikeout)
        End If
    End Sub

    'Sub BindDataFromOrder()
    '    mdCnOpen()
    '    Dim ds0 As New DataSet
    '    Dim MainDt As New DataTable  ' SaleOrderMt
    '    Dim SubDt As New DataTable  ' SaleOrderDt

    '    MainDt.Clear()
    '    MainDt.Clear()
    '    sCommand.CommandText = "Select Distinct mt.idSaleOrder, mt.CusName_, mt.DateOrder, mt.DateRequire, " & _
    '                           "mt.DateTs, mt.TimeTs, mt.DocCode, mt.Note, mt.PsSale, mt.PsOrder, mt.stSysOrder, " & _
    '                           "mt.idPsCancel, mt.CancelNote, mt.PsCancel, mt.PsAccept, mt.DateAccept, " & _
    '                           "mt.PsCheck, mt.DateCheck, mt.PsApp, mt.DateApp, '' As typeOrder, mt.stOrd " & _
    '                           "From vSmSaleOrderMt mt LEFT OUTER JOIN SmSaleOrderDt dt ON mt.idSaleOrder = dt.idSaleOrder " & _
    '                           "Where mt.idComp = '" & sIdComp & "' AND mt.idPsCancel Is Null AND dt.stAllSale IS " & _
    '                           "NULL AND mt.idCus = " & idCus & " AND mt.DateOrder > '25580101' Order by mt.DocCode"
    '    sAdapter.Fill(MainDt)
    '    MainDt.Columns.Add("ChkKey", System.Type.GetType("System.Boolean"))
    '    For i As Integer = 0 To MainDt.Rows.Count - 1
    '        If Not IsDBNull(MainDt.Rows(i).Item("DateOrder")) Then
    '            MainDt.Rows(i).Item("DateOrder") = ksbStringToDate(MainDt.Rows(i).Item("DateOrder"))
    '        End If
    '        If Not IsDBNull(MainDt.Rows(i).Item("DateRequire")) Then
    '            MainDt.Rows(i).Item("DateRequire") = ksbStringToDate(MainDt.Rows(i).Item("DateRequire"))
    '        End If
    '        If Not IsDBNull(MainDt.Rows(i).Item("DateTs")) Then
    '            MainDt.Rows(i).Item("DateTs") = ksbStringToDate(MainDt.Rows(i).Item("DateTs"))
    '        End If
    '        If Not IsDBNull(MainDt.Rows(i).Item("DateAccept")) Then
    '            MainDt.Rows(i).Item("DateAccept") = ksbStringToDate(MainDt.Rows(i).Item("DateAccept"))
    '        End If
    '        If Not IsDBNull(MainDt.Rows(i).Item("DateCheck")) Then
    '            MainDt.Rows(i).Item("DateCheck") = ksbStringToDate(MainDt.Rows(i).Item("DateTs"))
    '        End If
    '        If Not IsDBNull(MainDt.Rows(i).Item("DateApp")) Then
    '            MainDt.Rows(i).Item("DateApp") = ksbStringToDate(MainDt.Rows(i).Item("DateTs"))
    '        End If

    '        If IsDBNull(MainDt.Rows(i).Item("stSysOrder")) Then
    '            MainDt.Rows(i).Item("typeOrder") = "PC"
    '        ElseIf MainDt.Rows(i).Item("stSysOrder") = 1 Then
    '            MainDt.Rows(i).Item("typeOrder") = "Mobile"
    '        ElseIf MainDt.Rows(i).Item("stSysOrder") = 2 Then
    '            MainDt.Rows(i).Item("typeOrder") = "Web Browser"
    '        End If

    '        MainDt.Rows(i).Item("ChkKey") = False
    '    Next

    '    '----------------------- Dt table ----------------------------'
    '    SubDt.Clear()
    '    sCommand.CommandText = "SELECT dt.idSaleOrder, dt.idPdPk, p.PdCode, p.PdPkName, dt.Amount, u.PkUnitName, " & _
    '                           "dt.Price, dt.Amount*dt.Price As ExSump, dt.Note " & _
    '                           "FROM SmSaleOrderDt dt LEFT OUTER JOIN vSmSaleOrderMt mt ON dt.idSaleOrder = mt.idSaleOrder " & _
    '                           "LEFT OUTER JOIN vPackingPdSet p ON dt.idPdPk = p.idPdPk " & _
    '                           "LEFT OUTER JOIN dPackingUnit u ON dt.idPkUnit = u.idPkUnit Where mt.idComp = '" & sIdComp & "' " & _
    '                           "AND mt.idPsCancel Is Null AND dt.stAllSale IS " & _
    '                           "NULL AND mt.idCus = " & idCus & " AND mt.DateOrder > '25580101' Order by mt.DocCode"
    '    sAdapter.Fill(SubDt)

    '    ' CopyMainDt = MainDt
    '    ds0.Tables.Clear()
    '    ds0.Tables.Add(MainDt)
    '    ds0.Tables.Add(SubDt)

    '    Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idSaleOrder")
    '    Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idSaleOrder")

    '    ds0.Relations.Add("รายการ", keyColumn, foreignColumn)

    '    GridControl1.DataSource = ds0.Tables(0)
    '    GridControl1.ForceInitialize()

    '    GridControl1.LevelTree.Nodes.Add("รายการ", GVSaleDt)
    'End Sub

    Private Sub GVSaleMt_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVSaleOrderMt.RowClick
        If e.RowHandle < 0 Then
            Exit Sub
        End If

        If Not IsDBNull(GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColidCancel1)) Then
            MessageBox.Show("ผู้ยกเลิก : " & GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColPsCancel1) & vbNewLine & "ยกเลิกสาเหตุ : " & GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColCancelNote), sSystemName)
        End If
    End Sub

    '---- Cancel ----'
    Private Sub RepositoryItemButtonEdit6_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit6.Click
        If GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColstOrd_cal) = 0 And
            eEvent = eProcess.eCancel Then 'รายการยังไม่ถูกขาย + enum cancel
            Dim CancelNote As String = " "
            CancelNote = InputBox("ระบุสาเหตุการยกเลิก", sSystemName)

            If CancelNote <> "" And CancelNote <> "0" And CancelNote <> "-" And CancelNote.Length > 5 Then
                mdCnOpen()
                SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                sCommand.CommandText = "Update SmSaleOrderMt Set stOrd = NULL, idPsCancel = " & sPsId & ", CancelNote = '" & CancelNote & "' " &
                                       "WHERE idSaleOrder = " & GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColidSaleOrder)
                sCommand.ExecuteNonQuery()
                BindData()
                SplashScreenManager.CloseForm(False)
                MessageBox.Show("ยกเลิกรายการเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("กรุณาระบุสาเหตุการยกเลิกให้ชัดเจน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Else
            MessageBox.Show("รายการนี้ไม่สามารถทำการยกเลิกได้ เนื่องจากรายการนี้อยู่ในขั้นตอนการขายสินค้าแล้ว" & vbNewLine &
                            "หากต้องการยกเลิก กรุณายกเลิกรายการขายสินค้าก่อน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

    '----ShowData---'
    Private Sub RepositoryItemButtonEdit8_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit8.Click
        If IsDBNull(GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColidCancel1)) = True Then
            idSaleOrderShow = GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColidSaleOrder)
            Dim vFrm As New frmSlOrderTs(frmSlOrderTs.eProcess.eShow, idSaleOrderShow)
            vFrm.ShowDialog()
        End If
    End Sub

    '-----Edit----'
    Private Sub rptEdit_Click(sender As Object, e As EventArgs) Handles rptEdit.Click
        If IsDBNull(GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, colstOrd)) = True Then
            If GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColstApp) = 1 Then
                MessageBox.Show("รายการนี้ไม่สามารถแก้ไขได้" & vbNewLine &
                                "เนื่องจากถูกอนุมติรายการสั่งซื้อแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim vFrm As New frmSlOrderTs(frmSlOrderTs.eProcess.eEdit, GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColidSaleOrder))
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                BindData()
                SplashScreenManager.CloseForm(False)
            End If
        Else
            MessageBox.Show("รายการนี้ไม่สามารถแก้ไขได้ เนื่องจากรายการนี้อยู่ในขั้นตอนการขายสินค้าแล้ว" & vbNewLine &
                            "หากต้องการแก้ไข กรุณายกเลิกรายการขายสินค้าก่อน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub
    '---- Accept -----'
    'Private Sub RepositoryItemButtonEdit3_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit3.Click
    '    If IsDBNull(GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColidCancel1)) = True Then
    '        idSaleOrderShow = GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColidSaleOrder)
    '        Dim vFrm As New frmSlOrderTs(frmSlOrderTs.eProcess.eAccept, idSaleOrderShow)
    '        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
    '            BindData()
    '            SplashScreenManager.CloseForm(False)
    '        End If
    '    End If
    'End Sub

    '------ Check -----'
    'Private Sub RepositoryItemButtonEdit4_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit4.Click
    '    If IsDBNull(GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColidCancel1)) = True Then
    '        idSaleOrderShow = GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColidSaleOrder)
    '        Dim vFrm As New frmSlOrderTs(frmSlOrderTs.eProcess.eCheck, idSaleOrderShow)
    '        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
    '            BindData()
    '            SplashScreenManager.CloseForm(False)
    '        End If

    '    End If
    'End Sub

    '----- Approve -----'
    'Private Sub RepositoryItemButtonEdit5_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit5.Click
    '    If IsDBNull(GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColidCancel1)) = True Then

    '        idSaleOrderShow = GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColidSaleOrder)
    '        Dim vFrm As New frmSlOrderTs(frmSlOrderTs.eProcess.eApprove, idSaleOrderShow)
    '        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
    '            BindData()
    '            SplashScreenManager.CloseForm(False)
    '        End If
    '    End If
    'End Sub

    'Private Sub btnApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprove.Click
    '    Dim stMsg As Integer = 0

    '    Dim ChkRow As Integer = 0
    '    For i As Integer = 0 To CopyMainDt.Rows.Count - 1
    '        If CopyMainDt.Rows(i).Item("ChkKey") = True Then
    '            ChkRow = 1 ' มีอย่างน้อย 1 รายการที่เลือก
    '        End If
    '    Next

    '    If ChkRow = 0 Then
    '        MessageBox.Show("กรุณาเลือกรายการที่ต้องการอนุมัติอย่างน้อย 1 รายการ", sSystemName)
    '        Exit Sub
    '    End If


    '    For i As Integer = 0 To CopyMainDt.Rows.Count - 1
    '        If CopyMainDt.Rows(i).Item("ChkKey") = True Then
    '            mdCnOpen()
    '            '---Update SmSaleOrderMt Table---'
    '            sCommand.CommandText = "Update SmSaleOrderMt Set idPsApp = '" & sPsId & "', DateApp='" & ksbDateToString(Date.Today) & "' " & _
    '                                   "Where idSaleOrder='" & GVSaleOrderMt.GetRowCellValue(i, ColidSaleOrder) & "'"
    '            sCommand.ExecuteNonQuery()

    '            Dim sDt As New DataTable
    '            sCommand.CommandText = "Select idPsAccept, idPsCheck, idPsApp From SmSaleOrderMt Where idSaleOrder='" & GVSaleOrderMt.GetRowCellValue(i, ColidSaleOrder) & "'"
    '            sAdapter.Fill(sDt)
    '            If Not IsDBNull(sDt.Rows(0).Item("idPsAccept")) And Not IsDBNull(sDt.Rows(0).Item("idPsCheck")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp")) Then
    '                '----Update stApp----'
    '                sCommand.CommandText = "Update SmSaleOrderMt Set stApp='1' Where idSaleOrder='" & GVSaleOrderMt.GetRowCellValue(i, ColidSaleOrder) & "'"
    '                sCommand.ExecuteNonQuery()
    '                stMsg = 1
    '            End If
    '        End If
    '    Next

    '    If stMsg = 1 Then
    '        MessageBox.Show("กระบวนการนี้มีบางรายการ เป็นการยืนยันขั้นตอนลำดับสุดท้าย ลำดับที่ 3", sSystemName)
    '    Else
    '        MessageBox.Show("อนุมัติเรียบร้อยแล้ว", sSystemName)
    '    End If
    '    BindData()
    'End Sub

    Private Sub rdbDate_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDate.CheckedChanged
        If stload = 1 Then
            If rdbDate.Checked = True Then
                Me.dtpDateS.Enabled = True
                Me.dtpDateE.Enabled = True
                SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                BindData()
                SplashScreenManager.CloseForm(False)
            Else
                Me.dtpDateS.Enabled = False
                Me.dtpDateE.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbMonth_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMonth.CheckedChanged
        If stload = 1 Then
            If Me.rdbMonth.Checked = True Then
                Me.dtpMonthS.Enabled = True
                SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                BindData()
                SplashScreenManager.CloseForm(False)
            Else
                Me.dtpMonthS.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbYear_CheckedChanged(sender As Object, e As EventArgs) Handles rdbYear.CheckedChanged
        If stload = 1 Then
            If Me.rdbYear.Checked = True Then
                Me.dtpYear.Enabled = True
                SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                BindData()
                SplashScreenManager.CloseForm(False)
            Else
                Me.dtpYear.Enabled = False
            End If
        End If
    End Sub

    Private Sub dtpDateS_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateS.ValueChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub dtpDateE_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateE.ValueChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub dtpMonthS_ValueChanged(sender As Object, e As EventArgs) Handles dtpMonthS.ValueChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub dtpYear_ValueChanged(sender As Object, e As EventArgs) Handles dtpYear.ValueChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub ChkCus_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCus.CheckedChanged
        If Me.ChkCus.Checked = True Then
            Me.txtCusName.Enabled = True
            Me.txtCusName.Focus()
        Else
            Me.txtCusName.Enabled = False
            Me.txtCusName.Text = ""
        End If
    End Sub

    Private Sub chkDocCode_CheckedChanged(sender As Object, e As EventArgs) Handles chkDocCode.CheckedChanged
        If Me.chkDocCode.Checked = True Then
            Me.txtDocCode.Enabled = True
            Me.txtDocCode.Focus()
        Else
            Me.txtDocCode.Enabled = False
            Me.txtDocCode.Text = ""
        End If
    End Sub

    Sub CheckGroup()
        Select Case ChkGroupComp.Checked
            Case True
                ColCompName.GroupIndex = 0
                If Me.ChkGroupCus.Checked = True Then
                    ColPartnerName.GroupIndex = 1
                Else
                    ColPartnerName.GroupIndex = -1
                End If
            Case False
                ColCompName.GroupIndex = -1
                If Me.ChkGroupCus.Checked = True Then
                    ColPartnerName.GroupIndex = 0
                Else
                    ColPartnerName.GroupIndex = -1
                End If
        End Select
        GVSaleOrderMt.ExpandAllGroups()
    End Sub

    Private Sub ChkGroupComp_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGroupComp.CheckedChanged
        CheckGroup()
    End Sub

    Private Sub ChkGroupCus_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGroupCus.CheckedChanged
        CheckGroup()
    End Sub

    Private Sub rdbAll_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAll.CheckedChanged
        If stload = 1 And rdbAll.Checked = True Then
            FilterGridview()
        End If
    End Sub

    Private Sub rdbWeb_CheckedChanged(sender As Object, e As EventArgs) Handles rdbWeb.CheckedChanged
        If stload = 1 And rdbWeb.Checked = True Then
            FilterGridview()
        End If
    End Sub

    Private Sub rdbPc_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPc.CheckedChanged
        If stload = 1 And rdbPc.Checked = True Then
            FilterGridview()
        End If
    End Sub

    Private Sub rdbPO_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPO.CheckedChanged
        If stload = 1 And rdbPO.Checked = True Then
            FilterGridview()
        End If
    End Sub


    Private Sub txtCusName_TextChanged(sender As Object, e As EventArgs) Handles txtCusName.TextChanged
        FilterGridview()
    End Sub

    Private Sub txtDocCode_TextChanged(sender As Object, e As EventArgs) Handles txtDocCode.TextChanged
        FilterGridview()
    End Sub

    Public Function CalculateStOrd(dtDetails As DataTable) As Integer
        ' 1. ตรวจสอบก่อนว่ามีรายการสินค้าไหม ถ้าไม่มีให้เป็นสถานะ 0
        If dtDetails Is Nothing OrElse dtDetails.Rows.Count = 0 Then
            Return 0
        End If

        Dim totalItems As Integer = dtDetails.Rows.Count
        Dim soldFullCount As Integer = 0
        Dim notSoldCount As Integer = 0

        For Each row As DataRow In dtDetails.Rows
            ' ดึงค่าจาก Column Amount (ยอดสั่ง) และ AmtSale (ยอดที่ขายแล้ว)
            ' ตรวจสอบค่า Null ด้วยเพื่อป้องกัน Error
            Dim qtyOrder As Decimal = If(IsDBNull(row("Amount")), 0, Convert.ToDecimal(row("Amount")))
            Dim qtySold As Decimal = If(IsDBNull(row("AmtSale")), 0, Convert.ToDecimal(row("AmtSale")))

            If qtySold >= qtyOrder AndAlso qtyOrder > 0 Then
                ' รายการนี้ขายครบแล้ว
                soldFullCount += 1
            ElseIf qtySold <= 0 Then
                ' รายการนี้ยังไม่ได้ขายเลย
                notSoldCount += 1
            End If
        Next

        ' --- ตัดสินสถานะ stOrd ---
        If soldFullCount = totalItems Then
            ' ทุกรายการขายครบหมด
            Return 1
        ElseIf notSoldCount = totalItems Then
            ' ทุกรายการยังไม่ถูกขายเลย
            Return 0
        Else
            ' มีบางรายการขายแล้ว หรือขายไปแค่บางส่วน
            Return 2
        End If
    End Function

    Private Sub rptClose_Click(sender As Object, e As EventArgs) Handles rptClose.Click
        If IsDBNull(GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, colstOrd)) = True Then
            Dim vFrm As New frmSlOrderTs(frmSlOrderTs.eProcess.eClose, GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColidSaleOrder))
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                BindData()
                SplashScreenManager.CloseForm(False)
            End If
        End If
    End Sub

    Private Sub rptAmtSale_Click(sender As Object, e As EventArgs) Handles rptAmtSale.Click
        Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GridControl1.FocusedView

        If CDbl(detailView.GetRowCellValue(detailView.FocusedRowHandle, ColAmtSale)) > 0 Then

            ' ตรวจสอบว่าปัจจุบันอยู่ใน Detail View จริงหรือไม่ และมี Parent View หรือไม่
            If detailView IsNot Nothing AndAlso detailView.ParentView IsNot Nothing Then

                ' เข้าถึง Parent View
                Dim parentView As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(detailView.ParentView, DevExpress.XtraGrid.Views.Grid.GridView)

                ' ดึงข้อมูลจากแถวที่ถูกเลือก (Focused Row) ของชั้นแม่
                ' หมายเหตุ: ต้องใช้ GetParentRowHandle เพื่อหา Handle ของแถวแม่ที่สัมพันธ์กับแถวลูกนี้
                Dim parentRowHandle As Integer = detailView.SourceRowHandle

                Dim vFrm As New frmDetailAmtOrderSale(frmDetailAmtOrderSale.eProcess.eSale,
                                                     parentView.GetRowCellValue(parentRowHandle, "DocCode"),
                                                     parentView.GetRowCellValue(parentRowHandle, "DocRef"),
                                                     detailView.GetRowCellValue(detailView.FocusedRowHandle, ColInvName),
                                                     detailView.GetRowCellValue(detailView.FocusedRowHandle, ColidSaleOrderDt))
                vFrm.ShowDialog()

            End If
        Else
            MessageBox.Show("รายการนี้ยังไม่มีการเปิดบิลขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit1.Click
        If IsDBNull(GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, colstOrd)) = True Then
            'If GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColstApp) = 1 Then
            '    MessageBox.Show("รายการนี้ไม่สามารถแก้ไขได้" & vbNewLine &
            '                    "เนื่องจากถูกอนุมติรายการสั่งซื้อแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If

            Dim vFrm As New frmSlOrderTs(frmSlOrderTs.eProcess.eEdit, GVSaleOrderMt.GetRowCellValue(GVSaleOrderMt.FocusedRowHandle, ColidSaleOrder))
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                BindData()
                SplashScreenManager.CloseForm(False)
            End If
        Else
            MessageBox.Show("รายการนี้ไม่สามารถแก้ไขได้ เนื่องจากรายการนี้อยู่ในขั้นตอนการขายสินค้าแล้ว" & vbNewLine &
                            "หากต้องการแก้ไข กรุณายกเลิกรายการขายสินค้าก่อน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

    Private Sub chkApp_CheckedChanged(sender As Object, e As EventArgs) Handles chkApp.CheckedChanged
        BindData()
    End Sub
End Class

