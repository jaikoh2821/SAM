Imports DevExpress.XtraSplashScreen

Public Class frmSlOrderToSaleCustomer
    Public idPartner As Integer = 0
    Public PartnerName As String = ""
    Dim gidComp As Integer = 0

    Enum eProcess
        eSelect
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idComp As String, ByVal CompName As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        gidComp = idComp
        Me.Text = "เลือกลูกค้า " & CompName & " ที่มีรายการสั่งซื้อ เพื่อเปิดบิลขายสินค้า"
    End Sub

    Private Sub frmSlOrderToSaleCustomer_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()

        Me.txtCusName.Focus()
    End Sub

    Sub BindData()

        Dim sDt As New DataTable
        sDt.Clear()

        sCommand.CommandText = "SELECT idPartner, PartnerName, ' ' As AllOrder, ' ' As PassOrder, MIN(FirstDateOrder) AS FirstDateOrder, 0 As CountDay, pAddress " & vbNewLine &
                                "FROM (SELECT TOP 100 PERCENT d.idPartner, d.PartnerName, d.pAddress, '' AS FirstDateOrder " & vbNewLine &
                                        "FROM SmSaleOrderMt mt " & vbNewLine &
                                        "INNER JOIN dPartner AS d ON mt.idPartner = d.idPartner " & vbNewLine &
                                        "LEFT OUTER JOIN SmSaleOrderDt dt ON mt.idSaleOrder = dt.idSaleOrder " & vbNewLine &
                                        "WHERE mt.idPsCancel Is NULL" & vbNewLine &
                                        "AND mt.idComp = " & gidComp & vbNewLine &
                                        "AND dt.stAllSale IS NULL " & vbNewLine &
                                        "AND Year(mt.DateOrderD) >= 2024 " & vbNewLine &
                                        "ORDER BY mt.DateOrderD) AS derivedtbl_1" & vbNewLine &
                                "WHERE PartnerName Like '%%'" & vbNewLine &
                                "GROUP BY idPartner, PartnerName , pAddress" & vbNewLine &
                                "ORDER BY FirstDateOrder"
        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลลูกค้าที่มีรายการสั่งซื้อ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            For i As Integer = 0 To sDt.Rows.Count - 1
                '---Count All Order----'
                Dim vDt As New DataTable
                vDt.Clear()
                sCommand.CommandText = "SELECT COUNT(a.idSaleOrder) As AllOrder " & vbNewLine & _
                                        "FROM (SELECT Distinct mt.idSaleOrder " & vbNewLine & _
                                       "FROM SmSaleOrderMt mt " & vbNewLine & _
                                       "LEFT JOIN SmSaleOrderDt dt ON mt.idSaleOrder = dt.idSaleOrder" & vbNewLine & _
                                       "WHERE mt.idPsCancel Is NULL And mt.idComp = " & gidComp & vbNewLine & _
                                       "AND dt.stAllSale IS NULL AND mt.idPartner = " & sDt.Rows(i).Item("idPartner") & ") As a"
                sAdapter.Fill(vDt)
                sDt.Rows(i).Item("AllOrder") = vDt.Rows(0).Item("AllOrder")

                vDt.Clear()
                sCommand.CommandText = "SELECT COUNT(a.idSaleOrder) As PassOrder " & vbNewLine & _
                                       "FROM (SELECT Distinct mt.idSaleOrder " & vbNewLine & _
                                       "FROM SmSaleOrderMt mt " & vbNewLine & _
                                       "LEFT OUTER JOIN SmSaleOrderDt dt ON mt.idSaleOrder = dt.idSaleOrder " & vbNewLine & _
                                       "WHERE mt.idPsCancel IS NULL AND mt.idComp = " & gidComp & vbNewLine & _
                                       "AND dt.stAllSale IS NULL " & vbNewLine & _
                                       "AND mt.idPsAccept IS Not NUll  " & vbNewLine & _
                                       "AND mt.idPsCheck Is NOT NUll " & vbNewLine & _
                                       "AND mt.idPsApp Is Not Null " & vbNewLine & _
                                       "AND mt.stApp = 1 " & vbNewLine & _
                                       "AND mt.idPartner = " & sDt.Rows(i).Item("idPartner") & ") As a"
                sAdapter.Fill(vDt)
                sDt.Rows(i).Item("PassOrder") = vDt.Rows(0).Item("PassOrder")
            Next

            GCSaleOrder.DataSource = sDt
        End If
    End Sub

    Private Sub rptDetail_Click(sender As Object, e As EventArgs) Handles rptDetail.Click
        Dim vFrm As New frmSlOrderData(frmSlOrderData.eProcess.eViewOrder)
        vFrm.idCus = GVSaleOrder.GetRowCellValue(GVSaleOrder.FocusedRowHandle, "idPartner")
        vFrm.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        mdCnOpen()
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        BindData()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub rptBtnSel_Click(sender As Object, e As EventArgs) Handles rptBtnSel.Click
        idPartner = GVSaleOrder.GetRowCellValue(GVSaleOrder.FocusedRowHandle, "idPartner")
        PartnerName = GVSaleOrder.GetRowCellValue(GVSaleOrder.FocusedRowHandle, "PartnerName")

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class