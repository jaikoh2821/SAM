Public Class frmSlReturnSaleList
    Dim idSaleCutDt As New DataTable
    Dim idPartner As Integer = 0
    Public getDt As New DataTable
    Dim sDtCopy As New DataTable
    Dim stPage As String = 0
    Dim eEvent As eProcess
    Dim stLoad As Integer = 0
    Dim idComp As Integer = 0
    Dim gDocCode As String = ""
    Dim gidPsSale As Integer = 0
    Dim gPsSaleName As String = ""
    Dim gCustomer As String = ""
    Enum eProcess
        eSelectReturn
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idSaleDt As DataTable, ByVal didPartner As Integer, ByVal vCusName As String, _
            ByVal didComp As Integer, ByVal dDocCode As String, ByVal idPsSale As Integer, ByVal PsSaleName As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eSelectReturn
                stPage = 1
        End Select

        eEvent = aProcess
        idPartner = didPartner
        idSaleCutDt = idSaleDt

        idComp = didComp
        gDocCode = dDocCode
        gidPsSale = idPsSale
        gPsSaleName = PsSaleName
        gCustomer = vCusName
    End Sub


    Private Sub frmSlReturnSaleList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        initDataTable(getDt)

        txtDocRef.Text = Trim(gDocCode)

        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()

        stLoad = 1
    End Sub

    Private Sub initDataTable(sender As Object)

        sender.Columns.Add("ChkKey", System.Type.GetType("System.Boolean"))
        sender.Columns.Add("idSaleDt", System.Type.GetType("System.String"))
        sender.Columns.Add("idSale", System.Type.GetType("System.Int64"))
        sender.Columns.Add("idLot", System.Type.GetType("System.Int64"))
        sender.Columns.Add("DocRef", System.Type.GetType("System.String"))
        sender.Columns.Add("LotNo", System.Type.GetType("System.String"))
        sender.Columns.Add("idProduct", System.Type.GetType("System.Int64"))
        sender.Columns.Add("ProductName", System.Type.GetType("System.String"))
        sender.Columns.Add("UnitName", System.Type.GetType("System.String"))
        sender.Columns.Add("AmtSale", System.Type.GetType("System.Double"))
        sender.Columns.Add("DateGen", System.Type.GetType("System.String"))
        sender.Columns.Add("PriceSale", System.Type.GetType("System.Double"))
        sender.Columns.Add("idUnit", System.Type.GetType("System.Int64"))
        sender.Columns.Add("AmountRT", System.Type.GetType("System.Int64"))
        sender.Columns.Add("idInvGroup", System.Type.GetType("System.Int64"))
    End Sub

    Private Sub BindData()
        Dim vWHERE As String = ""

        If idSaleCutDt.Rows.Count > 0 Then
            Dim stridCut As String = ""

            For i As Integer = 1 To idSaleCutDt.Rows.Count - 1
                stridCut = stridCut & " AND (dt.idSaleDt <> " & idSaleCutDt.Rows(i).Item("idSaleDt") & ") "
            Next

            vWHERE = vWHERE & " AND (dt.idSaleDt <> " & idSaleCutDt.Rows(0).Item("idSaleDt") & stridCut & ") "
        End If

        Dim sDt As New DataTable

        sCommand.CommandText = "SELECT cast(0 as bit) as ChkKey, dt.idSaleDt, dt.idLot, mt.idSale, mt.DocRef, dt.LotNo, mt.DateSaleD As DateSale, d.idInvGroup," & vbNewLine & _
                               "dt.ProductName, dt.idProduct, dt.Amount - ISNUll((Select SUM(rd.AmountReturn) " & vbNewLine & _
                                                                                "From SmSaleReturnDt rd " & vbNewLine & _
                                                                                "LEFT JOIN SmSaleReturnMt rm ON rd.idSaleReturn = rm.idSaleReturn " & vbNewLine & _
                                                                                "WHERE rd.idSaleDt = dt.idSaleDt AND rm.idPsCancel IS NULL), 0.00) As BalanceRT," & vbNewLine & _
                               "dt.Amount, dt.idUnit, dt.UnitName, main.DateGen, dt.Price, dt.idWh, p.PartnerName " & vbNewLine & _
                               "FROM vSmSaleDtAll dt " & vbNewLine & _
                               "LEFT OUTER JOIN SmSaleMt mt ON dt.idSale = mt.idSale " & vbNewLine & _
                               "LEFT OUTER JOIN dInvLotMain main ON dt.idLot = main.idLot " & vbNewLine & _
                               "LEFT OUTER JOIN dInventoryMain d ON main.idInvMain = d.idInvMain " & vbNewLine & _
                               "LEFT JOIN dPartner p ON mt.idPartner = p.idPartner" & vbNewLine & _
                               "WHERE d.idInvGroup <> 30 " & vbNewLine & _
                               "AND mt.idPartner = " & idPartner & vbNewLine & _
                               "AND mt.idComp = " & idComp & vbNewLine & _
                               "AND mt.idPsCancel iS NULL " & vbNewLine & _
                               "AND mt.DocRef Like '%" & Trim(txtDocRef.Text) & "%'" & vbNewLine & _
                               vWHERE

        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูลเลขที่บิลขาย " & gDocCode, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Exit Sub
        Else

            GCData.DataSource = sDt
            GvShowData.ExpandAllGroups()
        End If

        sDtCopy = sDt

    End Sub

    Private Sub txtDocRef_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDocRef.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindData()
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        getDt.Rows.Clear()
        For i As Integer = 0 To sDtCopy.Rows.Count - 1

            If sDtCopy.Rows(i).Item("ChkKey") = True Then

                Dim drtemp As DataRow = getDt.NewRow()

                drtemp("idSale") = sDtCopy.Rows(i).Item("idSale")
                drtemp("idSaleDt") = sDtCopy.Rows(i).Item("idSaleDt")
                drtemp("DocRef") = sDtCopy.Rows(i).Item("DocRef")
                drtemp("idLot") = sDtCopy.Rows(i).Item("idLot")
                drtemp("LotNo") = sDtCopy.Rows(i).Item("LotNo")
                drtemp("idProduct") = sDtCopy.Rows(i).Item("idProduct")
                drtemp("ProductName") = sDtCopy.Rows(i).Item("ProductName")
                drtemp("idUnit") = sDtCopy.Rows(i).Item("idUnit")
                drtemp("UnitName") = sDtCopy.Rows(i).Item("UnitName")
                drtemp("PriceSale") = sDtCopy.Rows(i).Item("Price")
                drtemp("AmtSale") = sDtCopy.Rows(i).Item("BalanceRT")
                drtemp("DateGen") = sDtCopy.Rows(i).Item("DateGen")
                drtemp("AmountRT") = 1
                drtemp("idInvGroup") = sDtCopy.Rows(i).Item("idInvGroup")

                getDt.Rows.Add(drtemp)

            End If
        Next

        If getDt.Rows.Count = 0 Then

            MessageBox.Show("กรุณาเลือกล็อตสินค้าอย่างน้อย 1 รายการ", sSystemName)
            Exit Sub
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class