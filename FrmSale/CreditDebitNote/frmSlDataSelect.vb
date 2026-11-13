Public Class frmSlDataSelect

    Public idSale As Integer = 0
    Dim sDt As New DataTable
    Public dtPublic As New DataTable
    Public DateSaleD As String = ""
    Dim DocRef As String = ""
    Dim idComp As Integer = 0
    Dim idPartner As Integer = 0
    Dim vWhere As String = ""
    Enum eProcess
        eSlDataSelect
    End Enum

    Dim Process As eProcess

    Sub New(ByVal aProcess As eProcess, ByVal gDocRef As String, ByVal gidComp As Integer, ByVal gidPartner As Integer, ByVal gWhere As String)
        InitializeComponent()

        DocRef = gDocRef
        idComp = gidComp
        idPartner = gidPartner
        vWhere = gWhere

        initDataTable(dtPublic)
    End Sub

    Private Sub frmSlDataSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDocCode.Text = Trim(DocRef)

        mdLoadShow()
        mdCnOpen()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub initDataTable(sender As Object)
        sender.Columns.Add("idSaleDt", System.Type.GetType("System.Int64"))
        sender.Columns.Add("InvCode", System.Type.GetType("System.String"))
        sender.Columns.Add("idProduct", System.Type.GetType("System.Int64"))
        sender.Columns.Add("ProductName", System.Type.GetType("System.String"))
        sender.Columns.Add("LotNo", System.Type.GetType("System.String"))
        sender.Columns.Add("idUnit", System.Type.GetType("System.Int64"))
        sender.Columns.Add("UnitName", System.Type.GetType("System.String"))
        sender.Columns.Add("AmtSale", System.Type.GetType("System.Double"))
        sender.Columns.Add("PriceSale", System.Type.GetType("System.Double"))


    End Sub


    Private Sub BindData()

        Select Case Process
            Case eProcess.eSlDataSelect
                sCommand.CommandText = "SELECT CONVERT(bit,0) As chk, PartnerNameBill, Total, mt.idSale, p.PsName As PsSaleName, mt.DateSaleD, mt.DocRef, " & vbNewLine & _
                                        "inv.InvName As ProductName, dt.Amount As AmtSale, inv.InvCode, mt.PartnerNameBill, " & vbNewLine & _
                                        "unit.UnitName, dt.Price, dt.idProduct, dt.LotNo, dt.idSaleDt, dt.LotNo, dt.idUnit" & vbNewLine & _
                                        "FROM SmSaleDtAll dt" & vbNewLine & _
                                        "LEFT JOIN SmSaleMt mt ON dt.idSale = mt.idSale" & vbNewLine & _
                                        "LEFT JOIN dInventoryMain inv ON dt.idProduct = inv.idInvMain" & vbNewLine & _
                                        "LEFT JOIN dInvUnit unit ON dt.idUnit = unit.idUnit" & vbNewLine & _
                                        "LEFT JOIN vPersonxSelect p ON mt.idPsSale = p.idPs" & vbNewLine & _
                                        "WHERE DocRef = '" & DocRef & "' AND mt.idComp =" & idComp & vbNewLine & _
                                        "AND mt.idPartner = " & idPartner & vbNewLine & _
                                        vWhere
        End Select

        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูลขาย เลขที่อ้างอ้ง '" & DocRef & "'", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Exit Sub
        Else
            'ถ้ามี Lot เดียวให้ส่งกลับเลยโดยไม่ต้องเปิด Form
            lblDateSaleD.Text = sDt.Rows(0).Item("DateSaleD")
            lblPsCus.Text = sDt.Rows(0).Item("PartnerNameBill")
            DateSaleD = sDt.Rows(0).Item("DateSaleD")
            idSale = sDt.Rows(0).Item("idSale")
            GCSale.DataSource = sDt

        End If
    End Sub

    Private Sub rptSelect_Click(sender As Object, e As EventArgs) Handles rptSelect.Click
        'idSale = GVSale.GetRowCellValue(GVSale.FocusedRowHandle, colidSale)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        Dim chk As Integer = 0
        For i As Integer = 0 To GVSale.DataRowCount - 1

            If GVSale.GetDataRow(i).Item("chk") = False Then
                chk = chk + 1
            End If

            If chk > 0 Then
                'GVSale.SetFocusedRowCellValue("chk", True)
                GVSale.SetRowCellValue(i, "chk", True)
            Else
                GVSale.SetRowCellValue(i, "chk", False)
                'GVSale.SetFocusedRowCellValue("chk", False)
            End If
        Next

        'Dim dv As New DataView(sDt)
        'dv.RowFilter = "chk=True"
        'For i As Integer = 0 To dv.Count - 1
        '    Dim dr_ As DataRow = dtPublic.NewRow
        '    dr_("idSaleDt") = dv.Item(i).Item("idSaleDt")
        '    dr_("InvCode") = dv.Item(i).Item("InvCode")
        '    dr_("idProduct") = dv.Item(i).Item("idProduct")
        '    dr_("ProductName") = dv.Item(i).Item("ProductName")
        '    dr_("LotNo") = dv.Item(i).Item("LotNo")
        '    dr_("AmtSale") = dv.Item(i).Item("AmtSale")
        '    dr_("idUnit") = dv.Item(i).Item("idUnit")
        '    dr_("UnitName") = dv.Item(i).Item("UnitName")
        '    dr_("PriceSale") = dv.Item(i).Item("Price")
        '    dtPublic.Rows.Add(dr_)
        'Next


        'Me.DialogResult = Windows.Forms.DialogResult.OK
        'Me.Close()


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        For i As Integer = 0 To GVSale.DataRowCount - 1

            If GVSale.GetDataRow(i).Item("chk") = True Then
                Dim dr_ As DataRow = dtPublic.NewRow
                dr_("idSaleDt") = GVSale.GetDataRow(i).Item("idSaleDt")
                dr_("InvCode") = GVSale.GetDataRow(i).Item("InvCode")
                dr_("idProduct") = GVSale.GetDataRow(i).Item("idProduct")
                dr_("ProductName") = GVSale.GetDataRow(i).Item("ProductName")
                dr_("LotNo") = GVSale.GetDataRow(i).Item("LotNo")
                dr_("AmtSale") = GVSale.GetDataRow(i).Item("AmtSale")
                dr_("idUnit") = GVSale.GetDataRow(i).Item("idUnit")
                dr_("UnitName") = GVSale.GetDataRow(i).Item("UnitName")
                dr_("PriceSale") = GVSale.GetDataRow(i).Item("Price")
                dtPublic.Rows.Add(dr_)
            End If

        Next





        'Dim dv As New DataView(sDt)
        'dv.RowFilter = "chk=True"
        'For i As Integer = 0 To dv.Count - 1
        '    Dim dr_ As DataRow = dtPublic.NewRow
        '    dr_("idSaleDt") = dv.Item(i).Item("idSaleDt")
        '    dr_("InvCode") = dv.Item(i).Item("InvCode")
        '    dr_("idProduct") = dv.Item(i).Item("idProduct")
        '    dr_("ProductName") = dv.Item(i).Item("ProductName")
        '    dr_("LotNo") = dv.Item(i).Item("LotNo")
        '    dr_("AmtSale") = dv.Item(i).Item("AmtSale")
        '    dr_("idUnit") = dv.Item(i).Item("idUnit")
        '    dr_("UnitName") = dv.Item(i).Item("UnitName")
        '    dr_("PriceSale") = dv.Item(i).Item("Price")
        '    dtPublic.Rows.Add(dr_)
        'Next


        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class