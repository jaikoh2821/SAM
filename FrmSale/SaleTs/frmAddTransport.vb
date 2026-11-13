Public Class frmAddTransport
    Public idSaleMt As Integer = 0
    Dim txtService As Double = 0.0

    Private Sub frmAddTransport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdCnOpen()
        cmbTransport()
        cmbPayTps()

        Me.CmbTs.SelectedValue = 21

        BindData()
    End Sub

    Private Sub frmAddTransport_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtPrice.Focus()
        txtPrice.SelectAll()
    End Sub

    Private Sub BindData()
        Dim dt As New DataTable
        sCommand.CommandText = "SELECT mt.idTs, mt.idSupTsp, mt.idPayTsp, sup.SupName, dt.Price, IsnULL(TotalNet,0) As TotalNet," & vbNewLine & _
                                "ISNULL((SELECT Price FROM SmSaleDtAll WHERE idProduct = 9766 AND idSaleDt = dt.idSaleDt),0) As Service" & vbNewLine & _
                                "FROM SmSaleMt mt" & vbNewLine & _
                                "LEFT JOIN SmSaleDtAll dt ON mt.idSale = dt.idSale AND dt.idProduct = 9766" & vbNewLine & _
                                "LEFT JOIN PchInvAndProject.dbo.dSupplier sup ON mt.idSupTsp = sup.idSup" & vbNewLine & _
                                "WHERE mt.idSale = " & idSaleMt
        sAdapter.Fill(dt)

        txtService = dt.Rows(0).Item("Service")
        txtPrice.Text = Format(dt.Rows(0).Item("Service"), "#,##0.####")

        If Not IsDBNull(dt.Rows(0).Item("idTs")) Then
            CmbTs.SelectedValue = dt.Rows(0).Item("idTs")
        End If

        If Not IsDBNull(dt.Rows(0).Item("idPayTsp")) Then
            cmbTypePayTrp.SelectedValue = dt.Rows(0).Item("idPayTsp")
        End If

        If Not IsDBNull(dt.Rows(0).Item("idSupTsp")) Then
            Me.lblTspComp.Tag = dt.Rows(0).Item("idSupTsp")
            Me.lblTspComp.Text = dt.Rows(0).Item("SupName")
        End If

    End Sub

    Private Sub CmbTs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTs.SelectedIndexChanged
        If Me.CmbTs.SelectedValue = 21 Then ' บริษัทขนส่ง
            Me.btnTspComp.Enabled = True
            Me.cmbTypePayTrp.Enabled = True
            txtPrice.Enabled = True
        Else
            Me.btnTspComp.Enabled = False
            Me.cmbTypePayTrp.Enabled = False
            Me.lblTspComp.Tag = Nothing
            Me.lblTspComp.Text = ""
            Me.cmbTypePayTrp.SelectedValue = 1
            txtPrice.Enabled = False
        End If
    End Sub

    Private Sub cmbTransport()

        Dim sDt As New DataTable
        sCommand.CommandText = "Select idTspType, TspTypeName From dTspType WHERE idTspType = 1 OR idTspType = 7 OR idTspType = 15 " & _
                               "OR idTspType = 16 OR idTspType = 21 Order By idTspType"
        sAdapter.Fill(sDt)
        With CmbTs
            .DisplayMember = "TspTypeName"
            .ValueMember = "idTspType"
            .DataSource = sDt
        End With
    End Sub


    Private Sub btnTspComp_Click(sender As Object, e As EventArgs) Handles btnTspComp.Click
        Dim vFrm As New frmTspCompSelect(frmTspCompSelect.eProcess.eAll)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblTspComp.Tag = vFrm.idSup
            Me.lblTspComp.Text = vFrm.SupName
        End If
    End Sub

    Private Sub cmbPayTps()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select * From dPayTspType"
        sAdapter.Fill(sDt)
        With cmbTypePayTrp
            .DisplayMember = "PayTspName"
            .ValueMember = "idPayTsp"
            .DataSource = sDt
        End With
    End Sub

    Private Sub txtDocRef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        mdCnOpen()

        Dim dt As New DataTable
        sCommand.CommandText = "SELECT idSaleDt " & vbNewLine &
                                "FROM SmSaleDtAll" & vbNewLine &
                                "WHERE idSale = " & idSaleMt & vbNewLine &
                                "AND idProduct = 9766"
        sAdapter.Fill(dt)

        sCommand.CommandText = "Update SmSaleMt SET " & vbNewLine &
                                "Total = (ISNULL(Total,0) -" & txtService & ") + " & CDbl(txtPrice.Text.Trim) & vbNewLine &
                                ",TotalNet = (ISNULL(TotalNet,0) -" & txtService & ") + " & CDbl(txtPrice.Text.Trim) & vbNewLine &
                                "WHERE idSale = " & idSaleMt
        sCommand.ExecuteNonQuery()

        If dt.Rows.Count > 0 Then
            sCommand.CommandText = "Update SmSaleDtAll SET " & vbNewLine &
                                    "PriceBfDis = " & CDbl(txtPrice.Text.Trim) & vbNewLine &
                                    ",Price = " & CDbl(txtPrice.Text.Trim) & vbNewLine &
                                    ",TotalDt = " & CDbl(txtPrice.Text.Trim) & vbNewLine &
                                    "WHERE idSaleDt = " & dt.Rows(0).Item("idSaleDt")
            sCommand.ExecuteNonQuery()

        Else
            '--------- 
            Dim dtCount As New DataTable
            sCommand.CommandText = "SELECT idSaleDt " & vbNewLine &
                                  "FROM SmSaleDtAll" & vbNewLine &
                                  "WHERE idSale = " & idSaleMt
            sAdapter.Fill(dtCount)

            Dim PayTsP As String = "NULL"
            Dim SupTsp As String = "NULL"

            If CmbTs.SelectedValue = 21 Then
                PayTsP = cmbTypePayTrp.SelectedValue
                SupTsp = Me.lblTspComp.Tag
            End If

            sCommand.CommandText = "Update SmSaleMt SET idTs = " & CmbTs.SelectedValue & vbNewLine &
                                    ", idPayTsp = " & PayTsP & vbNewLine &
                                   ", idSupTsp = " & SupTsp & vbNewLine &
                                   "WHERE idSale = " & idSaleMt
            sCommand.ExecuteNonQuery()

            If CmbTs.SelectedValue = 21 And cmbTypePayTrp.SelectedValue = 2 Then
                sCommand.CommandText = "INSERT Into SmSaleDtAll(idSale, idProduct, ProductName, idLot, LotNo, Amount, idUnit," & vbNewLine &
                                        "PriceBfDis, DiscountPerc, DiscountBath, Price, stCutStock, No, DtType, TotalDt)" & vbNewLine &
                                        "VALUES(@idSale, @idProduct, @ProductName, @idLot, @LotNo, @Amount, @idUnit," & vbNewLine &
                                        "@PriceBfDis, @DiscountPerc, @DiscountBath, @Price, @stCutStock, @No, @DtType, @TotalDt)"


                With sCommand.Parameters
                    .Add("@idSale", SqlDbType.Int).Value = idSaleMt
                    .Add("@idProduct", SqlDbType.Int).Value = 9766
                    .Add("@ProductName", SqlDbType.VarChar).Value = "ค่าขนส่ง"
                    .Add("@idLot", SqlDbType.Int).Value = 0
                    .Add("@LotNo", SqlDbType.VarChar).Value = ""
                    .Add("@Amount", SqlDbType.Float).Value = 1
                    .Add("@idUnit", SqlDbType.Int).Value = 16
                    .Add("@PriceBfDis", SqlDbType.Float).Value = CDbl(txtPrice.Text)
                    .Add("@DiscountPerc", SqlDbType.Float).Value = 0
                    .Add("@DiscountBath", SqlDbType.Float).Value = 0
                    .Add("@Price", SqlDbType.Float).Value = CDbl(txtPrice.Text)
                    .Add("@stCutStock", SqlDbType.Int).Value = 0 ' Send to cut On WimWaitCut
                    .Add("@No", SqlDbType.Int).Value = dtCount.Rows.Count + 1
                    .Add("@DtType", SqlDbType.Int).Value = 4
                    .Add("@idWh", SqlDbType.Int).Value = 0
                    .Add("@TotalDt", SqlDbType.Float).Value = CDbl(txtPrice.Text)
                End With

                sCommand.ExecuteNonQuery()
                sCommand.Parameters.Clear()
            End If
        End If

        Dim dtTransport As New DataTable
        sCommand.CommandText = "SELECT Price " & vbNewLine &
                                "FROM SmSaleDtAll" & vbNewLine &
                                "WHERE idSale = " & idSaleMt & vbNewLine &
                                "AND idProduct = 9766"
        sAdapter.Fill(dtTransport)

        If dtTransport.Rows.Count <> 0 Then
            sCommand.CommandText = "Update SmSaleMt SET " & vbNewLine &
                                    " SumService = " & dtTransport.Rows(0).Item("Price") & vbNewLine &
                                    "WHERE idSale = " & idSaleMt
            sCommand.ExecuteNonQuery()
        End If

        MessageBox.Show("บันทึกข้อมูลค่าขนส่ง เรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class