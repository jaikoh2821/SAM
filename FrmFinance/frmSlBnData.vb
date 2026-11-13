Imports DevExpress.XtraSplashScreen

Public Class frmSlBnData
    Public idBnDt As New DataTable
    Dim eEvent As eProcess
    Dim idCus_ As Integer = 0
    Dim Cusname_ As String = "'"
    Dim DelDt As New DataTable
    Dim stload As Integer = 0
    Dim sDt As New DataTable
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")

    Enum eProcess
        eView
        eCancel
        eNew
        eSelect
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idCus As Integer, ByVal CusName As String, ByVal ChkidBn As DataTable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If eProcess.eSelect Then
            idCus_ = idCus
            Cusname_ = CusName
            DelDt = ChkidBn
        End If

        eEvent = aProcess
    End Sub

    Private Sub frmSlBnData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        setCmbGroupComp(cmbGroupComp)

        If eEvent = eProcess.eView Then
            ColCancel.Visible = False
            ColSelect.Visible = False
            ' ColEdit.Visible = False
        ElseIf eEvent = eProcess.eCancel Then
            ColSelect.Visible = False
            ColDoc.Visible = False
            ColShow.Visible = False
            '  ColEdit.Visible = False
        ElseIf eEvent = eProcess.eNew Then
            ColSelect.Visible = False
            ColDoc.Visible = False
            ColShow.Visible = False
            ColCancel.Visible = False
            Me.btnNew.Visible = True
        ElseIf eEvent = eProcess.eSelect Then 'eSelect
            ColDoc.Visible = False
            '  ColEdit.Visible = False
            ColShow.Visible = False
            ColCancel.Visible = False
            Me.btnOK.Visible = True
            Me.rdbDate.Checked = False
            Me.dtpDateS.Enabled = False
            Me.dtpDateE.Enabled = False
            Me.dtpMonth.Enabled = False
            Me.rdbDate.Enabled = False
            Me.rdbMonth.Enabled = False
            Me.ChkCusName.Checked = True
            Me.ChkCusName.Enabled = False
            Me.txtCusName.Text = Cusname_
            Me.txtCusName.Tag = idCus_
        End If

        BindData()
        stload = 1
        mdLoadCommitt()
    End Sub


    Private Sub btnSFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSFindAll.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        BindData()
        SplashScreenManager.CloseForm(False)
    End Sub

    Sub BindData()
        Dim vWhere As String = ""
        Dim stridBN As String = ""

        If eEvent = eProcess.eSelect Then 'Select Bn
            For i As Integer = 0 To DelDt.Rows.Count - 1
                stridBN &= DelDt.Rows(i).Item("idChk") & ","
            Next
            vWhere &= " AND m.idBN NOT IN (" & stridBN.Substring(0, stridBN.Length - 1) & ") " & vbNewLine & _
                      " AND m.idPsCancel Is Null AND m.idCus = " & txtCusName.Tag & " AND m.stPayBn IS NULL"
        End If

        mdCnOpen()
        sDt.Rows.Clear()
        sCommand.CommandText = "SELECT cast(0 as bit) As ChkKey, m.idBN, cp.CompCode, m.DocCode, CONVERT(DATE, m.DateDocD) As DateDocD, c.CusName_, m.Total, m.Note, " & vbNewLine & _
                               "p.PsName, m.idPsCancel, m.CancelNote, p2.PsName as PsCancel, m.idComp, cp.CompName " & vbNewLine & _
                               "FROM SmSaleBnMt m " & vbNewLine & _
                               "LEFT JOIN vCustomer c ON m.idCus = c.idCus " & vbNewLine & _
                               "LEFT JOIN vPersonxSelect p ON m.idPsTs = p.idPs " & vbNewLine & _
                               "LEFT JOIN vPersonxSelect p2 ON m.idPsCancel = p2.idPs " & vbNewLine & _
                               "LEFT JOIN PchInvAndProject.dbo.dCompany cp ON m.idComp = cp.idComp" & vbNewLine & _
                               "WHERE m.idComp IN (" & SIdCompStr & ")  Order by m.DocCode"
        sAdapter.Fill(sDt)
        'FORMAT(m.DateDocD, 'd', 'th') As 

        gc2.DataSource = sDt
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลรายการวางบิล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            FilterGridview()
        End If
    End Sub


    Private Sub FilterGridview()
        Dim StrFilter As String = ""
        If rdbDate.Checked = True Then
            Dim firstDate As DateTime = Convert.ToDateTime(dtpDateS.Value, _cultureEnInfo)
            Dim lastDate As DateTime = Convert.ToDateTime(dtpDateE.Value, _cultureEnInfo)
            StrFilter = " [DateDocD]  >= #" & firstDate.ToString("yyyy/MM/dd", _cultureEnInfo) & "#" & _
                         " AND [DateDocD]  <= #" & lastDate.ToString("yyyy/MM/dd", _cultureEnInfo) & "#"

        ElseIf rdbMonth.Checked = True Then
            StrFilter = " [DateDocD] like '%" & dtpMonth.Value.ToString("M/yyyy") & "%'"
        ElseIf rdbYear.Checked = True Then
            StrFilter = " [DateDocD] like '%" & dtpYear.Value.ToString("yyyy") & "%'"
        End If

        If ChkComp.Checked = True Then
            StrFilter &= " AND [idComp] = " & cmbGroupComp.SelectedValue & ""
        End If

        If Me.ChkCusName.Checked = True Then
            StrFilter &= " AND [CusName_] like '%" & txtCusName.Text.Trim & "%'"
        End If


        gv2.ActiveFilterString = StrFilter

        Dim totalNet As Double = 0.0
        For i As Integer = 0 To gv2.DataRowCount - 1
            totalNet = totalNet + gv2.GetDataRow(i).Item("Total")
        Next
        txtTotalNet.Text = Format(totalNet, "#,###0.00##")
    End Sub

    'Document
    Private Sub rptBtnDoc_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptBtnDoc.ButtonClick
        If IsDBNull(gv2.GetRowCellValue(gv2.FocusedRowHandle, ColidPsCancel)) Then

            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            '****พิมพ์เอกสาร****'
            Dim vAddress As String = ""
            Dim vContact As String = ""
            Dim dt As New DataTable
            mdCnOpen2()
            sCommand.CommandText = "Select c.Address, ISNULL(c.Tel, '') As Tel, ISNULL(c.Fax, '') As Fax, c.TaxCode, c.PostCode, p.ProvinceName " & _
                                   "From dCompany c " & vbNewLine & _
                                   "INNER JOIN dProvinceFix p ON c.idProvince = p.idProvince " & vbNewLine & _
                                   "Where idComp = " & gv2.GetRowCellValue(gv2.FocusedRowHandle, ColidComp)
            sAdapter.Fill(dt)

            If dt.Rows(0).Item("Tel") = "" Then
                dt.Rows(0).Item("Tel") = "-"
            End If
            If dt.Rows(0).Item("Fax") = "" Then
                dt.Rows(0).Item("Fax") = "-"
            End If

            vAddress = dt.Rows(0).Item("Address").ToString & " จ." & dt.Rows(0).Item("ProvinceName").ToString & " " & dt.Rows(0).Item("PostCode")
            vContact = "Tel: " & Trim(dt.Rows(0).Item("Tel")) & "  Fax: " & dt.Rows(0).Item("Fax").ToString


            Dim SlBnNotedt As New DataTable
            SlBnNotedt.Clear()
            mdCnOpen()

            sCommand.CommandText = "SELECT m.idBN, m.DocCode, FORMAT (m.DateDocD, 'd', 'th') As DateDoc, p.PsName, FORMAT (m.DateTsD, 'd', 'th') As DateTs, s.DocRef as SaleCode,  " & vbNewLine & _
                                   "FORMAT (s.DateSaleD, 'd', 'th') As DateSale, d.Amount, c.CusName_, c.Address, c.Tel, c.Fax, m.Note, " & vbNewLine & _
                                   " pm.PaymentTerms As Payment, p.PsName As PsTs, p2.PsName As PsSale  " & vbNewLine & _
                                   "FROM SmSaleBnMt m " & vbNewLine & _
                                   "LEFT JOIN SmSaleBnDt d ON m.idBn = d.idBn " & vbNewLine & _
                                   "LEFT JOIn SmSaleMt s ON d.idSale = s.idSale " & vbNewLine & _
                                   "LEFT JOIN vCustomer c ON m.idCus = c.idCus " & vbNewLine & _
                                   "LEFT JOIN vPersonxSelect p ON m.idPsTs = p.idPs " & vbNewLine & _
                                   "LEFT JOIN vPersonxSelect p2 ON s.idPsSale = p2.idPs " & vbNewLine & _
                                   "LEFT JOIN SmPaymentTermsD pm ON s.idPm = pm.idPM" & vbNewLine & _
                                   "Where m.idBn = " & gv2.GetRowCellValue(gv2.FocusedRowHandle, ColidBN) & " " & vbNewLine & _
                                   "Order By s.DateSale ASC"

            sAdapter.Fill(SlBnNotedt)

            'For i As Integer = 0 To SlBnNotedt.Rows.Count - 1
            '    SlBnNotedt.Rows(i).Item("DateSale") = SlBnNotedt.Rows(i).Item("DateSale")
            'Next

            SlBnNotedt.Columns.Add("PicComp", System.Type.GetType("System.Byte[]"))
            SlBnNotedt.Columns.Add("PicsignPrint", System.Type.GetType("System.Byte[]"))

            Dim URL As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & gv2.GetRowCellValue(gv2.FocusedRowHandle, ColidComp) & ".jpg"
            Dim client As New System.Net.WebClient
            Dim buffer As Byte()
            Dim pic() As Byte

            Try
                buffer = client.DownloadData(URL)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                For i As Integer = 0 To SlBnNotedt.Rows.Count - 1
                    SlBnNotedt.Rows(i).Item("PicComp") = pic
                Next
            Catch ex As Exception
                ' Noimage
            End Try

            Dim stPsPrint As Integer = 0
            Dim URL2 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & sPsId & ".png"
            Try
                buffer = client.DownloadData(URL2)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                For i As Integer = 0 To SlBnNotedt.Rows.Count - 1
                    SlBnNotedt.Rows(i).Item("PicsignPrint") = pic
                Next
                stPsPrint = 1

            Catch ex As Exception
                ' Noimage
                stPsPrint = 0
            End Try


            Dim vFrm As New FrmReportView
            Dim vRpt As New crpBillingNote
            vRpt.SetDataSource(SlBnNotedt)
            vRpt.SetParameterValue(vRpt.Parameter_ptCompName.ParameterFieldName, gv2.GetRowCellValue(gv2.FocusedRowHandle, ColCompName))
            vRpt.SetParameterValue(vRpt.Parameter_ptCompAddress.ParameterFieldName, vAddress.ToString)
            vRpt.SetParameterValue(vRpt.Parameter_ptCompContact.ParameterFieldName, vContact.ToString)
            vRpt.SetParameterValue(vRpt.Parameter_stSignPrint.ParameterFieldName, stPsPrint)
            vRpt.SetParameterValue(vRpt.Parameter_PsPrint.ParameterFieldName, sPsName)
            vFrm.crView.ReportSource = vRpt

            SplashScreenManager.CloseForm(False)
            vFrm.Show()
        End If
    End Sub

    'Show
    Private Sub rptBtnShow_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptBtnShow.ButtonClick
        If IsDBNull(gv2.GetRowCellValue(gv2.FocusedRowHandle, ColidPsCancel)) Then
            Dim vFrm As New frmSlBnTs(frmSlBnTs.eProcess.eviewData, gv2.GetRowCellValue(gv2.FocusedRowHandle, ColidBN))
            vFrm.Show()
        End If
    End Sub

    'Cancel
    Private Sub rptBtnCancel_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptBtnCancel.ButtonClick
        If IsDBNull(gv2.GetRowCellValue(gv2.FocusedRowHandle, ColidPsCancel)) Then
            Dim result As DialogResult
            result = MessageBox.Show("ต้องการลบข้อมูลนี้ใช่หรือไม่?", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.No Then
                Exit Sub
            ElseIf result = Windows.Forms.DialogResult.Yes Then
                Dim CancelNote As String = " "
                CancelNote = InputBox("ระบุสาเหตุการยกเลิก", sSystemName)
                If CancelNote.Length = 0 Then
                    MessageBox.Show("กรุณาระบุสาเหตุการยกเลิก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    mdCnOpen()
                    sCommand.CommandText = "Update SmSaleBnMt Set idPsCancel = " & sPsId & ", " & vbNewLine & _
                                           "CancelNote = '" & CancelNote & "' " & vbNewLine & _
                                           "WHERE idBN = " & gv2.GetRowCellValue(gv2.FocusedRowHandle, ColidBN)
                    sCommand.ExecuteNonQuery()

                    sCommand.CommandText = "Update SmSaleMt Set idBN = Null " & vbNewLine & _
                                           "WHERE idBN = " & gv2.GetRowCellValue(gv2.FocusedRowHandle, ColidBN)
                    sCommand.ExecuteNonQuery()

                    SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                    BindData()
                    SplashScreenManager.CloseForm(False)
                    MessageBox.Show("ยกเลิกรายการเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub


    Private Sub gv2_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gv2.RowClick
        If e.RowHandle < 0 Then
            Exit Sub
        End If

        If Not IsDBNull(gv2.GetRowCellValue(gv2.FocusedRowHandle, ColidPsCancel)) Then
            MessageBox.Show("ผู้ยกเลิก : " & gv2.GetRowCellValue(gv2.FocusedRowHandle, ColPsCancel) & vbNewLine & _
                            "ยกเลิกสาเหตุ : " & gv2.GetRowCellValue(gv2.FocusedRowHandle, ColCancelNote), sSystemName, _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub rdbDate_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDate.CheckedChanged
        If Me.rdbDate.Checked = True Then
            Me.dtpDateS.Enabled = True
            Me.dtpDateE.Enabled = True
            FilterGridview()
        Else
            Me.dtpDateS.Enabled = False
            Me.dtpDateE.Enabled = False
        End If
    End Sub

    Private Sub rdbMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMonth.CheckedChanged
        If Me.rdbMonth.Checked = True Then
            Me.dtpMonth.Enabled = True
            FilterGridview()
        Else
            Me.dtpMonth.Enabled = False
        End If
    End Sub

    Private Sub ChkCusName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCusName.CheckedChanged
        If Me.ChkCusName.Checked = True Then
            Me.txtCusName.Enabled = True
            Me.txtCusName.Focus()
        Else
            Me.txtCusName.Enabled = False
            txtCusName.Text = ""
        End If
    End Sub


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim vFrm As New frmSlBnTs(frmSlBnTs.eProcess.eNewBill, Nothing)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim j As Integer = 0
        idBnDt.Columns.Add("idBnSelect", System.Type.GetType("System.Int32"))

        Dim dv As New DataView(sDt)
        dv.RowFilter = "ChkKey=True"
        For i As Integer = 0 To dv.Count - 1
            idBnDt.Rows.Add()
            idBnDt.Rows(j).Item("idBnSelect") = dv.Item(i).Item("idBN")
            j = j + 1
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub txtCusName_TextChanged(sender As Object, e As EventArgs) Handles txtCusName.TextChanged
        FilterGridview()
    End Sub

    Private Sub rdbYear_CheckedChanged(sender As Object, e As EventArgs) Handles rdbYear.CheckedChanged
        If Me.rdbYear.Checked = True Then
            Me.dtpYear.Enabled = True
            FilterGridview()
        Else
            Me.dtpYear.Enabled = False
        End If
    End Sub

    Private Sub rdbYear_Resize(sender As Object, e As EventArgs) Handles rdbYear.Resize
        FilterGridview()
    End Sub

    Private Sub dtpDateS_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateS.ValueChanged
        If stload = 1 Then
            FilterGridview()
        End If
    End Sub

    Private Sub dtpDateE_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateE.ValueChanged
        If stload = 1 Then
            FilterGridview()
        End If
    End Sub

    Private Sub dtpMonth_ValueChanged(sender As Object, e As EventArgs) Handles dtpMonth.ValueChanged
        If stload = 1 Then
            FilterGridview()
        End If
    End Sub

    Private Sub dtpYear_ValueChanged(sender As Object, e As EventArgs) Handles dtpYear.ValueChanged
        If stload = 1 Then
            FilterGridview()
        End If
    End Sub

    Private Sub gv2_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gv2.RowCellStyle

        If Not IsDBNull(gv2.GetRowCellValue(e.RowHandle, ColidPsCancel)) Then
            e.Appearance.BackColor = Color.Salmon
            e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Strikeout)
        End If
        'End If

    End Sub

    Private Sub gv2_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gv2.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub ChkComp_CheckedChanged(sender As Object, e As EventArgs) Handles ChkComp.CheckedChanged
        If ChkComp.Checked = True Then
            cmbGroupComp.Enabled = True
        Else
            cmbGroupComp.Enabled = False
        End If
        FilterGridview()
    End Sub

    Private Sub cmbGroupComp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedIndexChanged
        If stload = 1 Then
            FilterGridview()
        End If
    End Sub

   
End Class