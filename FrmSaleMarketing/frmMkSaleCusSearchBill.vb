Public Class frmMkSaleCusSearchBill
    Dim eEvent As eProcess
    Dim idPdTs As Integer
    Dim PdTNames As String = ""
    Dim idCuss As Integer
    Dim CusNames As String = ""

    Enum eProcess
        eView
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idPdT As Integer, ByVal PdTName As String, ByVal idCus As Integer, ByVal CusName As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eView
                idPdTs = idPdT
                PdTNames = PdTName
                idCuss = idCus
                CusNames = CusName
        End Select
        eEvent = aProcess
    End Sub


    Private Sub frmMkSaleCusSearchBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        Me.lblPdTName.Text = PdTNames
        Me.lblPdTName.Tag = idPdTs
        Me.lblCusName.Text = CusNames
        Me.lblCusName.Tag = idCuss

        BindData()
        mdLoadCommitt()
    End Sub

    Sub BindData()
        Dim vWhere As String = ""
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select TOP 100 mt.idSale, mt.DateSale, dt.Price FROM SmSaleDt dt " & _
                               "LEFT OUTER JOIN SmSaleMt mt ON dt.idSale = mt.idSale LEFT OUTER JOIN " & _
                               "vPackingPdSet p ON dt.idPdPk = p.idPdPk WHERE p.idPdT = " & Me.lblPdTName.Tag & " " & _
                               "AND mt.idCus = " & Me.lblCusName.Tag & " AND mt.idPsCancel IS NULL ORDER BY DateSale DESC "
        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบประวัติการซื้อขายสินค้า", sSystemName)
            dgvBillH.DataSource = sDt
            Me.Close()
            Exit Sub
        Else
            dgvBillH.DataSource = sDt
            mdConvertDateInGrid(dgvBillH, ColDateSale)
        End If

    End Sub

    Private Sub dgvBillH_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBillH.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvBillH.Columns(e.ColumnIndex).Name = ColBill.Name Then
            Dim vFrm As New frmSlSaleTs(frmSlSaleTs.eProcess.eView, dgvBillH.Rows(e.RowIndex).Cells("ColidSale").Value, 0)
            vFrm.ShowDialog()
        End If
    End Sub
End Class