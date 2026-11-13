Public Class frmDetailAmtOrderSale
    Enum eProcess
        eSale
    End Enum

    Dim xProcess As eProcess
    Dim stLoad As Integer = 0
    Dim strDocCodeRef As String = ""
    Dim strInvName As String = ""
    Dim gidSaleOrderDt As Integer = 0

    Sub New(ByVal aProcess As eProcess, ByVal DocCode As String, ByVal DocRef As String, ByVal InvName As String, ByVal idSaleOrderDt As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        xProcess = aProcess
        strDocCodeRef = DocCode & " (" & DocRef & ")"
        strInvName = InvName
        gidSaleOrderDt = idSaleOrderDt
    End Sub

    Private Sub frmDetailAmtOrdeSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDocCodeRef.Text = "เลขที่คำสั่งซื้อ (อ้างอิง) : " & strDocCodeRef
        lblInvName.Text = "ชื่อสินค้า : " & strInvName

        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub BindData()
        Dim dt As New DataTable
        sCommand.CommandText = "SELECT mt.idSale, dt.idSaleDt, mt.DateSaleD, mt.DocCode, mt.DocRef, dt.Amount, dt.LotNo, u.UnitName, p.PsName As PsTsName, mt.TimeTs" & vbNewLine &
                                "FROM SmSaleDtAll dt" & vbNewLine &
                                "LEFT JOIN SmSaleMt mt ON dt.idSale = mt.idSale" & vbNewLine &
                                "LEFT JOIN dInvUnit u ON dt.idUnit = u.idUnit" & vbNewLine &
                                "LEFT JOIN vPersonxSelect p ON mt.idPsTs = p.idPs" & vbNewLine &
                                "WHERE mt.idPsCanCel Is NULL " & vbNewLine &
                                "AND mt.idSlAVxST Is NULL" & vbNewLine &
                                "AND dt.idSaleDtAVxST Is NULL" & vbNewLine &
                                "AND mt.idPscancel Is NULL" & vbNewLine &
                                "AND dt.idSaleOrderDt = " & gidSaleOrderDt & vbNewLine &
                                "Order by mt.DateSaleD ASC"
        sAdapter.Fill(dt)

        GCOrderSale.DataSource = dt
    End Sub

    Private Sub GVOrderSale_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVOrderSale.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub
End Class