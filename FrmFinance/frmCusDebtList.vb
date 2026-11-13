Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid

Public Class frmCusDebtList
    Dim eEvent As eProcess
    Public idPsCus As Integer = 0
    Public PsCusName As String = ""
    Public DebtCus As Double = 0.0
    Public idCompTs As Integer = 0
    Public CompNameTs As String = ""

    Public pidSale As Integer = 0
    Public pDocRef As String = ""
    Public pDateSaleD As DateTime
    Public pPayment As String = ""
    Public pPsSale As String = ""
    Public pNote As String = ""


    Dim stload As Integer = 0
    Dim stTab2 As Integer = 0
    Dim sDt As New DataTable

    Enum eProcess
        eSelectBn
        ' eSelectPay
    End Enum

    Sub New(ByVal aProcess As eProcess)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eSelectBn
                Me.Text = "เลือกลูกค้าที่ต้องการทำรายการออกใบวางบิล"
        End Select

        eEvent = aProcess
    End Sub

    Private Sub frmCusDebtList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        setCmbGroupComp(cmbGroupComp)
        setCmbGroupComp(cmbGroupComp1)
        'AddHandler rdbDateSale.CheckedChanged, AddressOf rdbDateSale_CheckedChanged
        'AddHandler rdbCus.CheckedChanged, AddressOf rdbDateSale_CheckedChanged
        'AddHandler rdbDebt.CheckedChanged, AddressOf rdbDateSale_CheckedChanged

        BindData()
        stload = 1
        mdLoadCommitt()
    End Sub

    Private Sub frmCusDebtList_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.txtCus.Focus()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If Me.TabControl1.SelectedIndex = 0 Then
            Me.txtCus.Focus()
        ElseIf Me.TabControl1.SelectedIndex = 1 Then
            If stTab2 = 0 Then
                SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                BindDataDocSale()
                stTab2 = 1
                SplashScreenManager.CloseForm(False)
            End If
            txtDocSale.Focus()
        End If
    End Sub


#Region "Tab_I"

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        BindData()
        SplashScreenManager.CloseForm(False)
    End Sub

    Sub BindData()
        mdCnOpen()
        If eEvent = eProcess.eSelectBn Then  'eSelectBn
            '"SUM(ISNULL(mt.TotalPay,0)) as Sumpay, " & vbNewLine & _

            sDt.Clear()
            sCommand.CommandText = "SELECT DISTINCT mt.idCus, c.CusName_, (Sum(IsnuLL(mt.ToTalNet,0)) - Sum(ISNULL(mt.TotalPay,0))) As AmtDebt, " & vbNewLine & _
                                    "(SELECT TOP 1 DateSaleD FROM SmSaleMt WHERE Year(DateSaleD) >= 2019 AND idPM NOT IN (53, 57)" & vbNewLine & _
                                    "AND idSaleCode NOT IN (1,18) AND idPsCancel Is NULL AND idBN is Null " & vbNewLine & _
                                    "AND idCus = mt.idCus Order by DateSaleD ASC) As MinDateSale " & vbNewLine & _
                                    "FROM SmSaleMt As mt" & vbNewLine & _
                                    "LEFT JOIN vCustomer c ON mt.idCus = c.idCus" & vbNewLine & _
                                    "WHERE  mt.idComp = " & cmbGroupComp.SelectedValue & vbNewLine & _
                                    "AND Year(mt.DateSaleD) >= 2019 " & vbNewLine & _
                                    "AND mt.idPM NOT IN (53, 57) " & vbNewLine & _
                                    "AND mt.idSaleCode NOT IN (1,18) " & vbNewLine & _
                                    "AND (mt.ToTalNet - mt.TotalPay) > 0 " & vbNewLine & _
                                    "AND mt.idPsCancel Is NULL AND mt.idBN is Null AND mt.stPay <> '1' " & vbNewLine & _
                                    "GROUP BY mt.idCus, c.CusName_ "
            'Else
            '    sCommand.CommandText = "SELECT DISTINCT mt.idCus, mt.CusName, SUM(mt.TotalNet) AS TotalN, " & _
            '                           "SUM(mt.TotalPay) as sumpay" & vbNewLine & _
            '                           "FROM SmSaleMt mt" & _
            '                           "WHERE Year(mt.DateSaleD) >= 2019 " & vWhere & " GROUP BY mt.idCus, mt.CusName " & OrderBy
        End If
        sAdapter.Fill(sDt)

        gc2.DataSource = sDt
        If sDt.Rows.Count = 0 Then
            SplashScreenManager.CloseForm(False)
            MessageBox.Show("ไม่พบข้อมูลค้างชำระ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTotalNet.Text = "0.00"
            Exit Sub
        Else
            FilterGridview_Tabi()
        End If
    End Sub

    Private Sub FilterGridview_Tabi()
        gv2.ActiveFilterString = "[CusName_] like '%" & Trim(txtCus.Text) & "%'"

        Dim TotalNet As Double = 0.0
        For i As Integer = 0 To gv2.DataRowCount - 1
            TotalNet = TotalNet + gv2.GetDataRow(i).Item("AmtDebt")
        Next
        txtTotalNet.Text = Format(TotalNet, "#,##0.00")
    End Sub

    Private Sub txtCus_TextChanged(sender As Object, e As EventArgs) Handles txtCus.TextChanged
        FilterGridview_Tabi()
    End Sub

    Private Sub rdbDateSale_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdbDateSale.CheckedChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            gv2.BeginSort()
            gv2.ClearSorting()
            ColMinDate.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            gv2.EndSort()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub rdbCus_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCus.CheckedChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            gv2.BeginSort()
            gv2.ClearSorting()
            ColCusName.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            gv2.EndSort()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub rdbDebt_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDebt.CheckedChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            gv2.BeginSort()
            gv2.ClearSorting()
            colDebt.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            gv2.EndSort()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub gv2_CustomDrawCell(sender As Object, e As Views.Base.RowCellCustomDrawEventArgs) Handles gv2.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    'Select
    Private Sub rptbtnSelect_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptbtnSelect.ButtonClick
        idPsCus = gv2.GetRowCellValue(gv2.FocusedRowHandle, ColidCus)
        PsCusName = gv2.GetRowCellValue(gv2.FocusedRowHandle, ColCusName)
        DebtCus = gv2.GetRowCellValue(gv2.FocusedRowHandle, colDebt)
        idCompTs = cmbGroupComp.SelectedValue
        CompNameTs = cmbGroupComp.Text.Trim

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    'View Detail
    Private Sub rptbtnView_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptbtnView.ButtonClick
        Dim tempDt As New DataTable
        Dim vFrm As New frmSlSaleDebt(frmSlSaleDebt.eProcess.eCustomer, tempDt, gv2.GetRowCellValue(gv2.FocusedRowHandle, ColidCus), _
                                      gv2.GetRowCellValue(gv2.FocusedRowHandle, ColCusName), cmbGroupComp.SelectedValue, cmbGroupComp.Text.Trim)
        vFrm.ShowDialog()
    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    'Private Sub rdbDateSale_CheckedChanged(sender As Object, e As EventArgs)
    '    If Me.rdbDateSale.Checked = True Then
    '        'Dim dv As DataView
    '        'dv = sDt.DefaultView
    '        'dv.Sort = "MinDateSale DESC"
    '        'sDt = dv.ToTable

    '        gv2.BeginSort()
    '        gv2.ClearSorting()
    '        ColMinDate.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
    '        gv2.EndSort()
    '    ElseIf Me.rdbCus.Checked = True Then
    '        'Dim dv As DataView
    '        'dv = sDt.DefaultView
    '        'dv.Sort = "CusName ASC"
    '        'sDt = dv.ToTable

    '        gv2.BeginSort()
    '        gv2.ClearSorting()
    '        ColCusName.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
    '        gv2.EndSort()
    '    ElseIf Me.rdbDebt.Checked = True Then
    '        gv2.BeginSort()
    '        gv2.ClearSorting()
    '        colDebt.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
    '        gv2.EndSort()
    '    End If
    'End Sub
#End Region

#Region "Tab_II"

    Sub BindDataDocSale()
        mdCnOpen()
        Dim sDt2 As New DataTable
        sCommand.CommandText = "Select mt.idSale, mt.idCus, mt.DocRef, Format(mt.DateSaleD, 'd', 'th') As DateSale, c.CusName_, " & vbNewLine & _
                               "pm.PaymentTerms, p.PsName As PsSale, mt.TotalNet, (ISNULL(mt.TotalNet,0) - ISNULL(mt.TotalPay,0)) As AmtDebtmt, mt.Note " & _
                               "From SmSaleMt mt " & vbNewLine & _
                               "LEFT JOIN vCustomer c ON mt.idCus = c.idCus" & vbNewLine & _
                               "LEFT JOIn vPersonxSelect p ON mt.idPsSale = p.idPs" & vbNewLine & _
                               "LEFT JOIN SmPaymentTermsD pm ON mt.idPm = pm.idPM" & vbNewLine & _
                               "WHERE Year(mt.DateSaleD) >= 2019  " & _
                               "AND mt.idPM NOT IN (53,57) " & vbNewLine & _
                               "AND mt.idSaleCode NOT IN (1,18) " & vbNewLine & _
                               "AND mt.idComp = " & cmbGroupComp1.SelectedValue & vbNewLine & _
                               "AND (ISNULL(mt.TotalNet,0) - ISNULL(mt.TotalPay,0)) > 0" & vbNewLine & _
                               "AND mt.idPsCancel Is NULL AND mt.idBN is Null AND mt.stPay <> '1' " & vbNewLine & _
                               "Order by mt.DateSaleD"
        sAdapter.Fill(sDt2)

        GcBillSale.DataSource = sDt2
        If sDt2.Rows.Count = 0 Then
            SplashScreenManager.CloseForm(False)
            MessageBox.Show("ไม่พบข้อมูลรายการบิลขายค้างชำระ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtToTalS.Text = "0.00"
            Exit Sub
        Else
            FilterGridview_Tabii()
        End If

    End Sub

    Private Sub FilterGridview_Tabii()
        GvBillSale.ActiveFilterString = "[DocRef] like '%" & Trim(txtDocSale.Text) & "%'"

        Dim TotalNet As Double = 0.0
        For i As Integer = 0 To GvBillSale.DataRowCount - 1
            TotalNet = TotalNet + GvBillSale.GetDataRow(i).Item("AmtDebtmt")
        Next
        txtToTalS.Text = Format(TotalNet, "#,##0.00")
    End Sub

    Private Sub btnShowS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowS.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        BindDataDocSale()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub rptSelectBill_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptSelectBill.ButtonClick
        idPsCus = GvBillSale.GetRowCellValue(GvBillSale.FocusedRowHandle, ColidCus2)
        PsCusName = GvBillSale.GetRowCellValue(GvBillSale.FocusedRowHandle, ColCusName2)
        DebtCus = GvBillSale.GetRowCellValue(GvBillSale.FocusedRowHandle, ColAmtDebt)
        idCompTs = cmbGroupComp1.SelectedValue
        CompNameTs = cmbGroupComp1.Text.Trim

        pidSale = GvBillSale.GetRowCellValue(GvBillSale.FocusedRowHandle, ColidSale)
        pDocRef = GvBillSale.GetRowCellValue(GvBillSale.FocusedRowHandle, ColDocRef2)
        pDateSaleD = GvBillSale.GetRowCellValue(GvBillSale.FocusedRowHandle, ColDateSaleD)
        pPayment = GvBillSale.GetRowCellValue(GvBillSale.FocusedRowHandle, ColPayment)
        pPsSale = GvBillSale.GetRowCellValue(GvBillSale.FocusedRowHandle, ColPsSale)
        pNote = GvBillSale.GetRowCellValue(GvBillSale.FocusedRowHandle, ColNote2)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub txtDocSale_TextChanged(sender As Object, e As EventArgs) Handles txtDocSale.TextChanged
        FilterGridview_Tabii()
    End Sub

    Private Sub GvBillSale_CustomDrawCell(sender As Object, e As Views.Base.RowCellCustomDrawEventArgs) Handles GvBillSale.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum2" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub cmbGroupComp1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroupComp1.SelectedIndexChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindDataDocSale()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

#End Region
   


  
End Class