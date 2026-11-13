Public Class frmCustomerEvent
    Public idcus As String = ""
    Dim sDt_Cus As New DataTable
    Dim vWhere As String
    Private Sub btn_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_select.Click
        Dim frm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelect, sIdComp)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            idcus = frm.idCus
            btn_show.Enabled = True
            sDt_Cus.Clear()
            mdCnOpen()
            Dim sDt As New DataTable
            sCommand.CommandText = "SELECT * FROM vCustomer WHERE idCus = " & idcus

            sAdapter.Fill(sDt)

            txtCusName.Text = sDt.Rows(0).Item("CusName")
            txtAddress.Text = sDt.Rows(0).Item("Address")
            txtAp.Text = sDt.Rows(0).Item("ApName")
            txtPv.Text = sDt.Rows(0).Item("ProvinceName")
            txtTel.Text = sDt.Rows(0).Item("Tel")
            txtMobile.Text = sDt.Rows(0).Item("Mobile1")
            ShowDataOnGride()
        End If
        
    End Sub

    Private Sub ShowDataOnGride()
        '' select data
        

        sDt_Cus.Clear()
        Dim Result_SaleDt As New DataTable
        Dim Result_MeetDt As New DataTable
        Dim Result_ReceptionDt As New DataTable


        Result_SaleDt = Select_SaleDt(idcus)
        Result_MeetDt = Select_MeetDt(idcus)
        Result_ReceptionDt = Select_ReceptionDt(idcus)

        adddata(Result_SaleDt)
        adddata(Result_MeetDt)
        adddata(Result_ReceptionDt)


        dgvdata.DataSource = sDt_Cus


        'For i As Integer = 0 To dgvdata.Rows.Count - 1
        '    dgvdata.Rows(i).Cells(DateTs.Name).Value = ksbStringToDate(dgvdata.Rows(i).Cells(DateTs.Name).Value)
        'Next

        If sDt_Cus.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบรายการ")
        End If
        dgvdata.Sort(dgvdata.Columns("DateTs"), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub adddata(ByVal sDt As DataTable)

        Dim idTs As String = ""
        Dim TsNum As String = ""
        Dim DateTs As String = ""
        Dim PsTs As String = ""
        Dim pType As String = ""
        Dim sType As String = ""
        


        For i As Integer = 0 To sDt.Rows.Count - 1
            If sDt.Rows(i).Item(0) IsNot DBNull.Value Then
                idTs = sDt.Rows(i).Item(0).ToString
            Else
                idTs = ""
            End If
            If sDt.Rows(i).Item(1) IsNot DBNull.Value Then
                TsNum = sDt.Rows(i).Item(1).ToString
            Else
                TsNum = ""
            End If
            If sDt.Rows(i).Item(2) IsNot DBNull.Value Then
                DateTs = ksbStringToDate(sDt.Rows(i).Item(2))
            Else
                DateTs = ""
            End If
            If sDt.Rows(i).Item(3) IsNot DBNull.Value Then
                PsTs = sDt.Rows(i).Item(3).ToString
            Else
                PsTs = ""
            End If
            If sDt.Rows(i).Item(4) IsNot DBNull.Value Then
                pType = sDt.Rows(i).Item(4).ToString
            Else
                pType = ""
            End If
            If sDt.Rows(i).Item(5) IsNot DBNull.Value Then
                sType = sDt.Rows(i).Item(5).ToString
            Else
                sType = ""
            End If
           
            sType = returntype(pType)
            sDt_Cus.Rows.Add(idTs, TsNum, DateTs, PsTs, pType, sType)

        Next

    End Sub

    Function returntype(ByVal numtype As String)
        Dim type = ""
        If numtype = "1" Then
            type = "การซื้อขายสินค้า"
        End If
        If numtype = "2" Then
            type = "การเข้าพบคู่ค้า"
        End If
        If numtype = "3" Then
            type = "การจัดเลี้ยงรับรองคู่ค้า"
        End If
        Return type
    End Function

    Private Sub frmCustomerEvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sDt_Cus.Columns.Add("idTs", System.Type.GetType("System.String"))
        sDt_Cus.Columns.Add("TsNum", System.Type.GetType("System.String"))
        sDt_Cus.Columns.Add("DateTs", System.Type.GetType("System.String"))
        sDt_Cus.Columns.Add("PsTs", System.Type.GetType("System.String"))
        sDt_Cus.Columns.Add("pType", System.Type.GetType("System.String"))
        sDt_Cus.Columns.Add("sType", System.Type.GetType("System.String"))
        DateTimePicker1.Value = Date.Today
        DateTimePicker2.Value = Date.Today
        DateTimePicker3.Value = Date.Today
        DateTimePicker3.Format = DateTimePickerFormat.Custom
        DateTimePicker3.CustomFormat = "MMMMyyyy"
    End Sub

    Function Select_SaleDt(ByVal pidCus As String) As DataTable
        vWhere = " "
        If chk_day.Checked = True Then
            vWhere &= " AND DateSale Between '" & ksbDateToString(DateTimePicker1.Value) & "' AND '" & ksbDateToString(DateTimePicker2.Value) & "'"
        End If

        If chk_month.Checked = True Then
            vWhere &= " AND  MONTH(DateSale) = " & Format(DateTimePicker3.Value.Month, "00") & " AND YEAR(DateSale) = " & (CType(DateTimePicker3.Value.Year, Integer) + 543).ToString & " "
        End If

        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT idSale, DocRef, DateSale, P.PsName ,'1' AS pType,'' AS sType " & _
                        " FROM dbo.vSmSaleMt S LEFT JOIN vPerson P ON P.idPs = S.idPsSale " & _
                        " WHERE (idPsCancel Is NULL) AND idCus = " & pidCus & " " & vWhere
        sAdapter.Fill(sDt)
        sAdapter.Fill(sDt)

        Return (sDt)
    End Function

    Function Select_MeetDt(ByVal pidCus As String) As DataTable
        vWhere = " "
        If chk_day.Checked = True Then
            vWhere &= " AND DateMeet Between '" & ksbDateToString(DateTimePicker1.Value) & "' AND '" & ksbDateToString(DateTimePicker2.Value) & "'"
        End If

        If chk_month.Checked = True Then
            vWhere &= " AND  MONTH(DateMeet) = " & Format(DateTimePicker3.Value.Month, "00") & " AND YEAR(DateMeet) = " & (CType(DateTimePicker3.Value.Year, Integer) + 543).ToString & " "
        End If
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT idTs,'-' AS DocRef, DateMeet, P.PsName ,'2' AS pType,'' AS sType " & _
                        " FROM dbo.SmMkMeet S LEFT JOIN vPerson P ON P.idPs = S.idPs " & _
                        " WHERE idCus = " & pidCus & " " & vWhere
        sAdapter.Fill(sDt)
        sAdapter.Fill(sDt)
        Return (sDt)
    End Function

    Function Select_ReceptionDt(ByVal pidCus As String) As DataTable
        vWhere = " "
        If chk_day.Checked = True Then
            vWhere &= " AND T.DateExpense Between '" & ksbDateToString(DateTimePicker1.Value) & "' AND '" & ksbDateToString(DateTimePicker2.Value) & "'"
        End If

        If chk_month.Checked = True Then
            vWhere &= " AND  MONTH(T.DateExpense) = " & Format(DateTimePicker3.Value.Month, "00") & " AND YEAR(T.DateExpense) = " & (CType(DateTimePicker3.Value.Year, Integer) + 543).ToString & " "
        End If

        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT C.idExpense, T.NumTs, T.DateExpense, P.PsName,'3' AS pType,'' AS sType " & _
                        " FROM  dbo.SmPsSaleExpenseTsCus AS C LEFT OUTER JOIN dbo.SmPsSaleExpenseTs AS T ON T.idExpense = C.idExpense " & _
                        " LEFT JOIN vPerson P ON P.idPs = T.idPsSale " & _
                        " WHERE (T.TypeExpense = 2) AND (T.idPsCancel IS NOT NULL) AND C.idCus = " & pidCus & " " & vWhere
        sAdapter.Fill(sDt)
        Return (sDt)
    End Function

    Private Sub dgvExpense_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvdata.RowPostPaint
        Me.dgvdata("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Private Sub chk_day_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_day.CheckedChanged
        If chk_day.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            DateTimePicker3.Enabled = False
        Else
            DateTimePicker3.Enabled = True
        End If
    End Sub

    Private Sub chk_month_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_month.CheckedChanged
        If chk_month.Checked = True Then
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            DateTimePicker3.Enabled = True
        Else
            DateTimePicker3.Enabled = False
        End If
    End Sub

    Private Sub btn_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show.Click
        ShowDataOnGride()
    End Sub
End Class