Public Class frmSlPrice
    Dim stPage As String = 0
    Dim eEvent As eProcess
    Dim idProduct As Integer = 0
    Dim idPartner As Integer = 0
    Dim idComp As Integer = 0
    Public PriceSelect As Double = 0.0

    Enum eProcess
        eViewPrice
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal vIdProduct As Integer, ByVal vidPartner As Integer, ByVal vidComp As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        My.Application.ChangeCulture("th-TH")

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eViewPrice
                stPage = 1
                idProduct = vIdProduct
                idPartner = vidPartner
                idComp = vidComp
        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmSlPrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdCnOpen()
        Dim sDt As New DataTable
        sDt.Clear()
        'If stBillType = 1 Then ' สินค้าทั่วไป
        '    sCommand.CommandText = "SELECT TOP 10 mt.DateSale, dt.Price FROM SmSaleDt dt " & _
        '                           "LEFT OUTER JOIN SmSaleMt mt ON dt.idsale = mt.idSale WHERE " & _
        '                           "mt.idCus = " & idCus & " AND idPdPk = " & idProduct & " " & _
        '                           "Order by mt.DateSale DESC"
        'ElseIf stBillType = 2 Or stBillType = 4 Then ' -ขายสินค้าอื่นๆ
        '    sCommand.CommandText = "SELECT TOP 10  mt.DateSale, dt.Price FROM SmSaleDtOther dt " & _
        '                           "LEFT OUTER JOIN SmSaleMt mt ON dt.idsale = mt.idSale WHERE " & _
        '                           "mt.idCus = " & idCus & " AND idPdO = " & idProduct & " Order by " & _
        '                           "mt.DateSale DESC"
        'ElseIf stBillType = 3 Then ' -ขายเมล็ด
        '    sCommand.CommandText = "Select TOP 10 mt.DateSale, dt.Price FROM SmSaleDtPd dt LEFT OUTER " & _
        '                           "JOIN SmSaleMt mt ON dt.idsale = mt.idSale WHERE mt.idCus = " & idCus & " " & _
        '                           "AND dt.idPd = " & idProduct & " Order by mt.DateSale DESC"

        'End If

        sCommand.CommandText = "Select TOP 10 mt.DateSaleD, dt.Price " & vbNewLine & _
                                "FROM SmSaleDtAll dt  " & vbNewLine & _
                                "LEFT OUTER JOIN SmSaleMt mt ON dt.idsale = mt.idSale" & vbNewLine & _
                                "WHERE mt.idPartner = " & idPartner & " " & vbNewLine & _
                                "AND mt.idComp = " & idComp & vbNewLine & _
                                "AND dt.idProduct = " & idProduct & vbNewLine & _
                                "AND ISNULL(dt.Price,0) > 0" & vbNewLine & _
                                "Order by mt.DateSale DESC"

        sAdapter.Fill(sDt)

        'For i As Integer = 0 To sDt.Rows.Count - 1
        '    sDt.Rows(i).Item("DateSale") = ksbStringToDate(sDt.Rows(i).Item("DateSale"))
        'Next
        GridControl1.DataSource = sDt

    End Sub

    Private Sub GVPrice_DoubleClick(sender As Object, e As EventArgs) Handles GVPrice.DoubleClick
        If GVPrice.RowCount > 0 Then
            PriceSelect = GVPrice.GetRowCellValue(GVPrice.FocusedRowHandle, ColPrice)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        Me.Close()
    End Sub

    Private Sub GridControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If GVPrice.RowCount > 0 Then
                PriceSelect = GVPrice.GetRowCellValue(GVPrice.FocusedRowHandle, ColPrice)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
            Me.Close()
        End If
    End Sub

    Private Sub GVPrice_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVPrice.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub
End Class