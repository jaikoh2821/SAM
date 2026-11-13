Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid

Public Class frmSlSaleDebt
    Public idSale As String = ""
    Public idSaleDt As New DataTable
    Dim DebtDt As New DataTable
    Public idSaleAll As String = ""

    Dim eEvent As eProcess
    Dim Deldt As New DataTable
    Dim idCusSel As Integer = 0
    Dim cusNSel As String = ""
    Dim didComp_ As Integer = 0
    Dim dCompname_ As String = ""

    Enum eProcess
        ' eViewBn
        eSelectBn
        '  eViewPay
        ' eSelectPay
        'eSelectAllBill
        eCustomer 'ระบุ Customer
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal dtChk As DataTable, ByVal idCus As Integer, ByVal CusName As String, _
            ByVal didComp As Integer, ByVal dCompname As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eSelectBn
                Deldt = dtChk
                idCusSel = idCus
                cusNSel = CusName
            Case eProcess.eCustomer 'ระบุ customer
                idCusSel = idCus
                cusNSel = CusName
        End Select
        eEvent = aProcess
        didComp_ = didComp
        dCompname_ = dCompname
    End Sub

    Private Sub frmSlSaleDebt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        If eEvent = eProcess.eSelectBn Then 'SelectBill
            Me.Text = "เลือกรายการขายเพื่อทำรายการออกใบวางบิล"
            '  ColCusName.Visible = False
            Me.btnShow.Visible = False
            Me.btnOK.Visible = True
            Me.lblCusName.Text = cusNSel
            Me.lblCusName.Tag = idCusSel
        ElseIf eEvent = eProcess.eCustomer Then 'ระบุ customer
            ColChk.Visible = False
            Me.btnOK.Visible = False
            Me.lblCusName.Text = cusNSel
            Me.lblCusName.Tag = idCusSel
        End If

        lblCompName.Text = dCompname_
        lblCompName.Tag = didComp_
        BindData()
        mdLoadCommitt()
    End Sub

    Sub BindData()
        ' Dim j As Integer = 0
        Dim vWhere As String = ""

        If eEvent = eProcess.eSelectBn Then 'SelectBill: Not Show บิลเงินสด / ชำระเงินก่อนรับสินค้า/ สินค้าตัวอย่าง 
            Dim StridSale As String = ""
            For i As Integer = 0 To Deldt.Rows.Count - 1
                StridSale &= Deldt.Rows(i).Item("idSale") & ","
            Next

            vWhere = vWhere & " AND idBN is Null AND idSale NOT IN (" & StridSale.Substring(0, StridSale.Length - 1) & ") "
            'ElseIf eEvent = eProcess.eCustomer Then 'ค้างชำระ แบบระบุลูกค้า
            '    vWhere = vWhere & " "
        End If

        mdCnOpen()

        DebtDt.Clear()
        sCommand.CommandText = "Select cast(0 as bit) As ChkKey, idSale, DocRef, DateSaleD, CusName, PaymentTerms, PsSale, TotalNet, " & vbNewLine & _
                               "TotalNet - ISNULL(TotalPay, 0.00) As AmtDebt, Note, ISNULL(TotalPay, 0.00) " & vbNewLine & _
                               "FROM vSmSaleMtx " & vbNewLine & _
                               "WHERE idComp = " & lblCompName.Tag & " AND idPsCancel is Null AND stPay <> '1' " & vbNewLine & _
                               "AND idPM NOT IN (53, 57) AND idSaleCode NOT IN (1, 18) " & vbNewLine & _
                               "AND DateSaleD > '2018-12-31' AND idCus = " & Me.lblCusName.Tag & vWhere
        sAdapter.Fill(DebtDt)

        gc2.DataSource = DebtDt
        If DebtDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลรายการบิลขายสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTotalNet.Text = "0.00"
            Exit Sub
        Else
            SumTotal()
        End If
    End Sub

    Private Sub gv2_CustomDrawCell(sender As Object, e As Views.Base.RowCellCustomDrawEventArgs) Handles gv2.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub


    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        BindData()
        SplashScreenManager.CloseForm(False)
    End Sub

    Sub SumTotal()
        Dim TotalNet As Double = 0.0
        For i As Integer = 0 To gv2.DataRowCount - 1
            TotalNet = TotalNet + gv2.GetDataRow(i).Item("AmtDebt")
        Next
        txtTotalNet.Text = Format(TotalNet, "#,##0.00")
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)

        Dim j As Integer = 0
        idSaleDt.Columns.Add("idSale", System.Type.GetType("System.Int32"))
        idSaleDt.Columns.Add("DocRef", System.Type.GetType("System.String"))
        idSaleDt.Columns.Add("DateSaleD", System.Type.GetType("System.DateTime"))
        idSaleDt.Columns.Add("PaymentTerms", System.Type.GetType("System.String"))
        idSaleDt.Columns.Add("PsSale", System.Type.GetType("System.String"))
        idSaleDt.Columns.Add("AmtDebt", System.Type.GetType("System.Double"))
        idSaleDt.Columns.Add("Note", System.Type.GetType("System.String"))


        Dim dv As New DataView(DebtDt)
        dv.RowFilter = "ChkKey=True"
        For i As Integer = 0 To dv.Count - 1
            idSaleDt.Rows.Add()
            idSaleDt.Rows(j).Item("idSale") = dv.Item(i).Item("idSale")
            idSaleDt.Rows(j).Item("DocRef") = dv.Item(i).Item("DocRef")
            idSaleDt.Rows(j).Item("DateSaleD") = dv.Item(i).Item("DateSaleD")
            idSaleDt.Rows(j).Item("PaymentTerms") = dv.Item(i).Item("PaymentTerms")
            idSaleDt.Rows(j).Item("PsSale") = dv.Item(i).Item("PsSale")
            idSaleDt.Rows(j).Item("AmtDebt") = dv.Item(i).Item("AmtDebt")
            idSaleDt.Rows(j).Item("Note") = dv.Item(i).Item("Note")

            j = j + 1
        Next

        SplashScreenManager.CloseForm(False)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    'Private Sub btnCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim vFrm As New frmCusDebtList(frmCusDebtList.eProcess.eSelectPay)
    '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        Dim CusnameShow As String = vFrm.PsCusName & " / " & vFrm.DebtCus
    '        lblShowCus.Tag = vFrm.idPsCus
    '        lblShowCus.Text = CusnameShow
    '    End If
    'End Sub

    'Bill Detail
    Private Sub rptbtnView_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptbtnView.ButtonClick
        ' Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eView, idSaleShow, Nothing, Nothing, Nothing, Nothing, Nothing, lblCompName.Tag)
        Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eView, gv2.GetRowCellValue(gv2.FocusedRowHandle, ColidSale), 0)
        vFrm.ShowDialog()
    End Sub

    Private Sub ChkDocRef_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDocRef.CheckedChanged
        If ChkDocRef.Checked = True Then
            Me.txtDocRef.Enabled = True
            Me.txtDocRef.Focus()
        Else
            Me.txtDocRef.Enabled = False
            Me.txtDocRef.Text = ""
        End If
    End Sub


    Private Sub txtDocRef_TextChanged(sender As Object, e As EventArgs) Handles txtDocRef.TextChanged
        gv2.ActiveFilterString = "[DocRef] like '%" & Trim(txtDocRef.Text) & "%'"
        SumTotal()
    End Sub
End Class