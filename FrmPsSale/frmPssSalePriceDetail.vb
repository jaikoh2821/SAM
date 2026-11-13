Public Class frmPssSalePriceDetail
    Dim vWHERE_ As String = ""
    Dim Nametag As String = ""

    Sub New(ByVal vWHERE As String, ByVal vName As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        vWHERE_ = vWHERE
        Nametag = vName
    End Sub

    Private Sub frmPssSalePriceDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdLoadShow()
        lblTag.Text = "      รายการขายแยกตามบิล >> " & Nametag
        ShowDataOnGrid()
        mdLoadCommitt()
    End Sub

    Sub ShowDataOnGrid()
        mdCnOpen()
        'SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)

    
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT dt.idSaleDt, dt.idProduct, CONCAT(mt.DocRef, ', วันที่ขาย: ', FORMAT (mt.DateSaleD, 'd', 'th')) As DocSale, " & vbNewLine & _
                               "dt.ProductName, dt.Amount, dt.UnitName, dt.Price, dt.TotalNet" & vbNewLine & _
                               "FROM vSmSaleDtAllxPsSaleSum dt" & vbNewLine & _
                               "LEFT JOIN SmSaleMt AS mt ON dt.idSale = mt.idSale" & vbNewLine & _
                               "LEFT JOIN dInventoryMain inv ON dt.idProduct= inv.idInvMain" & vbNewLine & _
                               "WHERE mt.idSaleCode NOT IN (1,18) AND mt.idPsCancel Is NULL " & vWHERE_ & vbNewLine & _
                               "Order by DocSale, dt.ProductName"
        sAdapter.Fill(sDt)
        GCPrice.DataSource = sDt
        GVPrice.ExpandAllGroups()
        ' Me.txtCount.Text = Format(GVPdT.RowCount, "#,##0")
        ' SplashScreenManager.CloseForm(False)
    End Sub

End Class