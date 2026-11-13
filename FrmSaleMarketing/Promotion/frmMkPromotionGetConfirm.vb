Public Class frmMkPromotionGetConfirm
    Dim Result As DialogResult
    Dim idSale As Integer = 0
    Dim stPage As Integer = 0
    Dim eEvent As eProcess

    Enum eProcess
        eComfirm
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idSaleRec As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eComfirm 'confirm 
                stPage = 1
                idSale = idSaleRec
        End Select
        eEvent = aProcess
    End Sub


    Private Sub frmMkPromotionGetConfirm_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

        'Show Main Data
        mdCnOpen()
        Dim sDt As New DataTable
        sDt.Clear()

        sCommand.CommandText = "SELECT s.DocCode, s.DateSale, c.CusName_, u.idCus, s.PsSale, " & _
                               "u.idProUse, p.ProName, u.idPromotion, t.ProTypeName, p.idProType, '' As Condition, " & _
                               "u.idInv As idFree, i.InvName As FreeName, u.AmountFree, u.FreeUnit, u.cdtPrice, " & _
                               "u.cdtAmount, u.cdtMin, u.cdtMax, u.cdtUnit, u.CollectCut, p.stBillPromotion " & _
                               "FROM [GR_Group].[dbo].[SmPromotionUseMt] u " & _
                               "LEFT OUTER JOIN [GR_Group].[dbo].[vSmSaleMt] s ON u.idSale = s.idSale " & _
                               "LEFT OUTER JOIN [GR_Group].[dbo].[SmPromotionMt] p ON u.idPromotion = p.idPromotion " & _
                               "LEFT OUTER JOIN [GR_Group].[dbo].[SmPromotionType] t ON p.idProType = t.idProType " & _
                               "LEFT OUTER JOIN [GR_Group].[dbo].[vPerson]  ps ON u.idPsSale = ps.idPs " & _
                               "LEFT OUTER JOIN [GR_Group].[dbo].[vCustomer]  c ON u.idCus = c.idCus " & _
                               "LEFT OUTER JOIN [PchInvAndProject].[dbo].[vInventory] i ON u.idInv = i.idInv " & _
                               "WHERE u.idSale = " & idSale & ""
        sAdapter.Fill(sDt)

        Me.lblDocCode.Text = sDt.Rows(0).Item("DocCode")
        Me.lblDateSale.Text = ksbStringToDate(sDt.Rows(0).Item("DateSale"))
        Me.lblCustomer.Text = sDt.Rows(0).Item("CusName_")
        Me.lblCustomer.Tag = sDt.Rows(0).Item("idCus")
        Me.lblPsSale.Text = sDt.Rows(0).Item("PsSale")
        Me.lblDateTs.Text = Date.Today
        Me.lblPsTs.Text = sPsName
        Me.lblPsTs.Tag = sPsId

        Dim stColPk As Integer = 0
        For i As Integer = 0 To sDt.Rows.Count - 1
            Dim rc As Integer = dgvProGet.Rows.Count
            dgvProGet.Rows.Add()
            dgvProGet.Rows(rc).Cells("ColidProUse").Value = sDt.Rows(i).Item("idProUse")
            dgvProGet.Rows(rc).Cells("ColProName").Value = sDt.Rows(i).Item("ProName")
            dgvProGet.Rows(rc).Cells("ColidPromotion").Value = sDt.Rows(i).Item("idPromotion")
            dgvProGet.Rows(rc).Cells("ColProTypeName").Value = sDt.Rows(i).Item("ProTypeName")
            dgvProGet.Rows(rc).Cells("ColidProType").Value = sDt.Rows(i).Item("idProType")
            If sDt.Rows(i).Item("idProType") = 3 Then 'แถมสินค้าบริษัท
                stColPk = 1 'Show
            End If

            Dim CntStr As String = ""
            If Not IsDBNull(sDt.Rows(i).Item("CdtAmount")) Then
                CntStr = CntStr & " ซื้อสินค้าจำนวน " & Format(sDt.Rows(i).Item("CdtAmount"), "#,##0") & " " & sDt.Rows(i).Item("CdtUnit")
            End If

            If Not IsDBNull(sDt.Rows(i).Item("CdtMin")) Then
                If sDt.Rows(0).Item("CdtMax") > 0 Then
                    CntStr = CntStr & " ซื้อสินค้าจำนวน " & Format(sDt.Rows(i).Item("CdtMin"), "#,##0") & " - " & Format(sDt.Rows(i).Item("CdtMax"), "#,##0") _
                             & " " & sDt.Rows(0).Item("CdtUnit")
                Else
                    CntStr = CntStr & " ซื้อสินค้าตั้งแต่ " & Format(sDt.Rows(i).Item("CdtMax"), "#,##0") & " " & sDt.Rows(i).Item("CdtUnit") & " ขึ้นไป"
                End If
            End If

            If Not IsDBNull(sDt.Rows(i).Item("CdtPrice")) Then
                CntStr = CntStr & " ราคาตั้งแต่ " & sDt.Rows(i).Item("CdtPrice") & " บาทขึ้นไป "
            End If

            dgvProGet.Rows(rc).Cells("ColCondition").Value = CntStr
            dgvProGet.Rows(rc).Cells("ColidFree").Value = sDt.Rows(i).Item("idFree")
            dgvProGet.Rows(rc).Cells("ColFreeName").Value = sDt.Rows(i).Item("FreeName")
            dgvProGet.Rows(rc).Cells("ColAmtFree").Value = sDt.Rows(i).Item("AmountFree")
            dgvProGet.Rows(rc).Cells("ColFreeUnit").Value = sDt.Rows(i).Item("FreeUnit")
            dgvProGet.Rows(rc).Cells("ColCollectCut").Value = sDt.Rows(i).Item("CollectCut")
            dgvProGet.Rows(rc).Cells("ColstBillPromotion").Value = sDt.Rows(i).Item("stBillPromotion")
        Next

        If stColPk = 1 Then
            dgvProGet.Columns("ColSelectPk").Visible = True
        End If


        'If sDt.Rows(0).Item("idProType") = 3 Then
        '    Me.btnPk.Visible = True
        'End If
        'Me.dtpPromotion.Value = Date.Today
        'Me.lblCustomer.Text = sDt.Rows(0).Item("CusName_")
        'Me.lblPsSale.Text = sDt.Rows(0).Item("PsSale")

        'Dim CntStr As String = ""
        'If Not IsDBNull(sDt.Rows(0).Item("CdtAmount")) Then
        '    CntStr = CntStr & " ซื้อสินค้าจำนวน " & Format(sDt.Rows(0).Item("CdtAmount"), "#,##0") & " " & sDt.Rows(0).Item("CdtUnit")
        'End If

        'If Not IsDBNull(sDt.Rows(0).Item("CdtMin")) Then
        '    If sDt.Rows(0).Item("CdtMax") > 0 Then
        '        CntStr = CntStr & " ซื้อสินค้าจำนวน " & Format(sDt.Rows(0).Item("CdtMin"), "#,##0") & " - " & Format(sDt.Rows(0).Item("CdtMax"), "#,##0") _
        '                 & " " & sDt.Rows(0).Item("CdtUnit")
        '    Else
        '        CntStr = CntStr & " ซื้อสินค้าตั้งแต่ " & Format(sDt.Rows(0).Item("CdtMax"), "#,##0") & " " & sDt.Rows(0).Item("CdtUnit") & " ขึ้นไป"
        '    End If
        'End If

        'If Not IsDBNull(sDt.Rows(0).Item("CdtPrice")) Then
        '    CntStr = CntStr & " ราคาตั้งแต่ " & sDt.Rows(0).Item("CdtPrice") & " บาทขึ้นไป "
        'End If

        'Me.lblCondition.Text = CntStr
        'If Not IsDBNull(sDt.Rows(0).Item("InvName")) Then
        '    Me.lblFreeName.Text = sDt.Rows(0).Item("InvName")
        '    Me.lblFreeName.Tag = sDt.Rows(0).Item("idInv")
        'End If
        'Me.lblAmtFree.Text = Format(sDt.Rows(0).Item("AmountFree"), "#,##0")
        'Me.lblUnit.Text = sDt.Rows(0).Item("FreeUnit")




    End Sub

    'Private Sub btnPk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim sDt As New DataTable
    '    sCommand.CommandText = "Select idPdPk From SmPromotionDtPd WHERE idPromotion = " & Me.lblDocCode.Tag & ""
    '    sAdapter.Fill(sDt)

    '    Dim idPdPklist As String = ""

    '    idPdPklist = idPdPklist & sDt.Rows(0).Item("idPdPk")
    '    For i As Integer = 1 To sDt.Rows.Count - 1
    '        idPdPklist = idPdPklist & "|" & sDt.Rows(i).Item("idPdPk")
    '    Next

    '    Dim vFrm As New frmPdPkSelect(frmPdPkSelect.eProcess.ePromotion)
    '    vFrm.ShowText(idPdPklist)
    '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        Me.lblFreeName.Text = vFrm.PdPkName
    '        Me.lblFreeName.Tag = vFrm.idPdPk
    '    End If

    'End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        'Check idPdPk Select
        For i As Integer = 0 To dgvProGet.Rows.Count - 1
            If IsDBNull(dgvProGet.Rows(i).Cells("ColidFree").Value) Then
                If dgvProGet.Rows(i).Cells("ColidPromotion").Value = 3 Then 'ขอแถมบริษัท
                    mdLoadCommitt()
                    MessageBox.Show("มีรายการแถมสินค้าบริษัทบางรายการ ที่ยังไม่ได้เลือกรายการที่ต้องการแถม", sSystemName)
                    Exit Sub
                End If
            End If

        Next


        '---UPDATE Status Approve Promotion BillSale
        sCommand.CommandText = "UPDATE SmSaleMt SET idPsAppPromotion = " & sPsId & ", " & _
                               "DateAppPromotion = '" & ksbDateToString(Date.Today) & "'  WHERE idSale = " & idSale & ""
        sCommand.ExecuteNonQuery()

        For i As Integer = 0 To dgvProGet.Rows.Count - 1
            ' ----UPDATE Status Confirm-----'
            Dim vIdPdPk As String = ""
            If dgvProGet.Rows(i).Cells("ColidProType").Value = 3 Then 'แถมสินค้าบริษัท
                vIdPdPk = ", idPdPk = " & dgvProGet.Rows(i).Cells("ColidFree").Value & " "
            End If


            sCommand.CommandText = "UPDATE SmPromotionUseMt SET stApprove = 1 " & vIdPdPk & " " & _
                                   "WHERE idProUse = " & dgvProGet.Rows(i).Cells("ColidProUse").Value & ""
            sCommand.ExecuteNonQuery()
        Next

        MessageBox.Show("อนุมัติรายการโปรโมชั่นเรียบร้อยแล้ว", sSystemName)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()


    End Sub

    Private Sub dgvProGet_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProGet.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvProGet.Columns(e.ColumnIndex).Name = ColSelectPk.Name Then
            If dgvProGet.Rows(e.RowIndex).Cells("ColidProType").Value = 3 Then 'แถมสินค้าบริษัท ----> เลือก
                Dim sDt As New DataTable
                sCommand.CommandText = "Select idPdPk From SmPromotionDtPd WHERE " & _
                                       "idPromotion = " & dgvProGet.Rows(e.RowIndex).Cells("ColidPromotion").Value & ""
                sAdapter.Fill(sDt)

                Dim idPdPklist As String = ""

                idPdPklist = idPdPklist & sDt.Rows(0).Item("idPdPk")
                For i As Integer = 1 To sDt.Rows.Count - 1
                    idPdPklist = idPdPklist & "|" & sDt.Rows(i).Item("idPdPk")
                Next

                Dim vFrm As New frmPdPkSelect(frmPdPkSelect.eProcess.ePromotion)
                vFrm.ShowText(idPdPklist)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    dgvProGet.Rows(e.RowIndex).Cells("ColidFree").Value = vFrm.idPdPk
                    dgvProGet.Rows(e.RowIndex).Cells("ColFreeName").Value = vFrm.PdPkName
                End If


            Else 'Other
                MessageBox.Show("รายการนี้ไม่ใช่โปรโมชั่นแถมสินค้าบริษัท จึงไม่สามารถเลือกสินค้าที่แถมได้", sSystemName)
            End If
        End If


        If dgvProGet.Columns(e.ColumnIndex).Name = ColDel.Name Then 'Not Approve Promotion

            Result = MsgBox("คุณต้องการที่จะไม่อนุมัติรายการโปรโมชั่นนี้ใช่หรือไม่? ", MsgBoxStyle.YesNo)
            If Result = Windows.Forms.DialogResult.Yes Then
                sCommand.CommandText = "UPDATE SmPromotionUseMt SET stApprove = 0 WHERE " & _
                                       "idProUse = " & dgvProGet.Rows(e.RowIndex).Cells("ColidProUse").Value & ""
                sCommand.ExecuteNonQuery()

                'Return Collect
                If dgvProGet.Rows(e.RowIndex).Cells("ColstBillPromotion").Value = 1 Then 'สะสม
                    Dim NewCollect As Double = 0
                    Dim CollectDt As New DataTable
                    sCommand.CommandText = "SELECT Amount FROM SmPromotionCollect WHERE " & _
                                           "idPromotion = " & dgvProGet.Rows(e.RowIndex).Cells("ColidPromotion").Value & " AND " & _
                                           "idCus = " & Me.lblCustomer.Tag & ""
                    sAdapter.Fill(CollectDt)

                    If CollectDt.Rows.Count <> 0 Then
                        Dim SumAmount As Integer = CollectDt.Rows(0).Item("Amount") + dgvProGet.Rows(e.RowIndex).Cells("ColCollectCut").Value
                        sCommand.CommandText = "UPDATE SmPromotionCollect SET Amount = " & SumAmount & " " & _
                                               "WHERE idPromotion = " & dgvProGet.Rows(e.RowIndex).Cells("ColidPromotion").Value & " AND " & _
                                               "idCus = " & Me.lblCustomer.Tag & " "
                        sCommand.ExecuteNonQuery()
                    End If

                End If

                dgvProGet.Rows.Remove(dgvProGet.CurrentRow)

            End If
        End If

    End Sub
End Class