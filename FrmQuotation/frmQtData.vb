Imports DevExpress.XtraSplashScreen

Public Class frmQtData
    Public idQT As Integer = 0
    Public MasterDt As New DataTable
    Dim CopyMainDt As New DataTable
    Dim eEvent As eProcess
    Dim stload As Integer = 0
    Dim idCus_ As Integer = 0
    Dim idComp_ As Integer = 0
    Dim idQtxCut_ As Integer = 0
    Dim pCusName_ As String = ""

    Enum eProcess
        eNew
        eViewData
        eCancel
        eSelect
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idCus As Integer, ByVal pCusName As String, ByVal idComp As Integer, ByVal idQtxCut As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eNew
                Me.Text = "ทำรายการ/แก้ไขรายการใบเสนอราคา"
                ColView.Visible = False
                ColCancel1.Visible = False
                ColDoc.Visible = False
                ColSelect.Visible = False
            Case eProcess.eViewData
                Me.Text = "ข้อมูลรายการใบเสนอราคา"
                ColEdit1.Visible = False
                ColCancel1.Visible = False
                Me.btnNew.Visible = False
                ColSelect.Visible = False
            Case eProcess.eCancel
                Me.Text = "ยกเลิกรายการใบเสนอราคา"
                ColEdit1.Visible = False
                ColView.Visible = False
                ColDoc.Visible = False
                Me.btnNew.Visible = False
                ColSelect.Visible = False
            Case eProcess.eSelect
                Me.Text = "เลือกรายการใบเสนอราคาครั้งก่อน"
                ColView.Visible = False
                ColCancel1.Visible = False
                ColDoc.Visible = False
                ColEdit1.Visible = False
                Me.btnNew.Visible = False
                GroupBox1.Visible = False
                idCus_ = idCus
                idComp_ = idComp
                idQtxCut_ = idQtxCut
                pCusName_ = pCusName
                If idCus_ <> 0 Then
                    ChkCus.Visible = False
                    txtCusName.Visible = False
                End If
        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmQtData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        Me.dtpQTs.Value = Date.Today
        Me.dtpQTe.Value = Date.Today
        Me.dtpMonthS.Value = Date.Today
        Me.dtpYear.Value = Date.Today
        BindData()
        stload = 1
        mdLoadCommitt()
    End Sub

    Private Sub rdbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDate.CheckedChanged
        If stload = 1 Then
            If Me.rdbDate.Checked = True Then
                Me.dtpQTs.Enabled = True
                Me.dtpQTe.Enabled = True
                SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                BindData()
                SplashScreenManager.CloseForm(False)
            Else
                Me.dtpQTs.Enabled = False
                Me.dtpQTe.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMonth.CheckedChanged
        If stload = 1 Then
            If Me.rdbMonth.Checked = True Then
                Me.dtpMonthS.Enabled = True
                SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                BindData()
                SplashScreenManager.CloseForm(False)
            Else
                Me.dtpMonthS.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbYear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbYear.CheckedChanged
        If stload = 1 Then
            If Me.rdbYear.Checked = True Then
                Me.dtpYear.Enabled = True
                SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                BindData()
                SplashScreenManager.CloseForm(False)
            Else
                Me.dtpYear.Enabled = False
            End If
        End If
    End Sub

    Private Sub ChkQtCode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkQtCode.CheckedChanged
        If Me.ChkQtCode.Checked = True Then
            Me.txtQTCode.Enabled = True
            txtQTCode.Focus()
        Else
            Me.txtQTCode.Enabled = False
            txtQTCode.Text = ""
        End If
    End Sub

    Private Sub ChkCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCus.CheckedChanged
        If Me.ChkCus.Checked = True Then
            Me.txtCusName.Enabled = True
            Me.txtCusName.Focus()
        Else
            Me.txtCusName.Enabled = False
            Me.txtCusName.Text = ""
        End If
    End Sub

    Private Sub ChkPsSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPsSale.CheckedChanged
        If Me.ChkPsSale.Checked = True Then
            Me.txtPsQT.Enabled = True
            Me.txtPsQT.Focus()
        Else
            Me.txtPsQT.Enabled = False
            Me.txtPsQT.Text = ""
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim vFrm As New frmQtTs(frmQtTs.eProcess.eNew, Nothing)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            BindData()
        End If
    End Sub

    Private Sub txtQTCode_TextChanged(sender As Object, e As EventArgs) Handles txtQTCode.TextChanged
        FilterGridview()
    End Sub

    Private Sub txtCusName_TextChanged(sender As Object, e As EventArgs) Handles txtCusName.TextChanged
        FilterGridview()
    End Sub

    Private Sub txtPsQT_TextChanged(sender As Object, e As EventArgs) Handles txtPsQT.TextChanged
        FilterGridview()
    End Sub

    Sub BindData()
        mdCnOpen()
        Dim vWhere As String = ""
        Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")

        If Me.rdbDate.Checked = True Then
            Dim DateQTs As DateTime = Convert.ToDateTime(dtpQTs.Value, _cultureEnInfo)
            Dim DateQTe As DateTime = Convert.ToDateTime(dtpQTe.Value, _cultureEnInfo)

            vWhere &= "WHERE mt.DateQTsD BETWEEN '" & DateQTs.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " & _
                      "AND '" & DateQTe.AddDays(1).AddSeconds(-1).ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "' "
        ElseIf Me.rdbMonth.Checked = True Then
            Dim sDate As DateTime = Convert.ToDateTime(dtpMonthS.Value, _cultureEnInfo)
            Dim sMonth As Integer = sDate.Month
            Dim sYear As Integer = sDate.Year

            vWhere &= "WHERE Month(mt.DateQTsD) = " & sMonth & " AND YEAR(mt.DateQTsD) = " & sYear & " "
        ElseIf Me.rdbYear.Checked = True Then
            Dim sDate As DateTime = Convert.ToDateTime(dtpYear.Value, _cultureEnInfo)
            Dim sYear As Integer = sDate.Year
            vWhere &= "WHERE YEAR(mt.DateQTsD) = " & sYear & " "
        End If


        If eEvent = eProcess.eNew Or eEvent = eProcess.eSelect Then 'New & Edit / Select
            vWhere &= " AND mt.idPsCancel IS NULL "
        End If

        If eEvent = eProcess.eSelect Then
            vWhere &= " AND mt.idComp = " & idComp_ & " AND mt.idQT <> " & idQtxCut_
            'If idCus_ <> 0 Then 'Cus in DB
            vWhere &= " AND mt.idCus = " & idCus_
            'Else
            '    vWhere &= " AND mt.CusName = '" & pCusName_ & "'"
            'End If
        Else
            vWhere &= " AND mt.idComp IN (" & SIdCompStr & ") "
        End If

        Dim ds0 As New DataSet
        Dim MainDt As New DataTable  ' SmQtMt
        Dim SubDt As New DataTable  ' SmQtDt

        MainDt.Clear()
        sCommand.CommandText = "Select mt.idPsCancel, p1.PsName As PsCancel, mt.CancelNote, mt.idQT, cp.CompCode, mt.NumOfQT, mt.DateQTsD, " & _
                               "mt.QTCode, mt.CusName, mt.CusAddress, mt.CusConn, mt.CusConnTel, p2.PsName as PsQT, mt.TotalNet, " & _
                               "pt.PaymentTerms As Payment, mt.Note, mt.idComp, cp.CompName, mt.idPsQT, mt.stPrice, mt.PaymentQT " & _
                               "From SmQtMt mt " & _
                               "LEFT OUTER JOIN vPersonxSelect p1 ON mt.idPsCancel = p1.idPs " & _
                               "LEFT OUTER JOIN vPersonxSelect p2 ON mt.idPsQT = p2.idPs " & _
                               "LEFT OUTER JOIN SmPaymentTermsD pt ON mt.PaymentQT = pt.idPM " & _
                               "LEFT JOIN PchInvAndProject.dbo.dCompany cp ON mt.idComp = cp.idComp " & vbNewLine & _
                               "" & vWhere & " Order by mt.QTCode"
        '"LEFT OUTER JOIN vCustomer c ON mt.idCus = c.idCus " & _
        sAdapter.Fill(MainDt)

        '----------------------- Dt table ----------------------------'
        SubDt.Clear()
        sCommand.CommandText = "SELECT d.idQTDt, d.idQT, d.idInvMain, inv.InvName, d.Amount, u.UnitName, " & _
                               "d.PriceBfDis, d.DisPerc, d.DisBath, d.Price, (d.Amount * d.Price) As Exp, d.NoteDt " & _
                               "FROM SmQtDt d " & _
                               "LEFT OUTER JOIN SmQtMt mt ON d.idQT = mt.idQT " & vbNewLine & _
                               "LEFT OUTER JOIN dInventoryMain inv ON d.idInvMain = inv.idInvMain " & vbNewLine & _
                               "LEFT OUTER JOIN dInvUnit u ON d.idUnit = u.idUnit " & vbNewLine & _
                               "" & vWhere & " "
        sAdapter.Fill(SubDt)

        ds0.Tables.Clear()
        ds0.Tables.Add(MainDt)
        ds0.Tables.Add(SubDt)
        CopyMainDt = MainDt

        Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idQT")
        Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idQT")

        ds0.Relations.Add("รายการ", keyColumn, foreignColumn)

        GridControl1.DataSource = ds0.Tables(0)
        GridControl1.ForceInitialize()

        GridControl1.LevelTree.Nodes.Add("รายการ", GVSaleQtDt)


        'SumTotal()
        FilterGridview()
        mdLoadCommitt()
        If MainDt.Rows.Count = 0 Then
            If eEvent = eProcess.eSelect Then
                MessageBox.Show("ไม่พบข้อมูลรายการใบเสนอราคาครั้งก่อน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Me.Close()
            Else
                MessageBox.Show("ไม่พบข้อมูลรายการใบเสนอราคา", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub FilterGridview()
        Dim StrFilter As String = ""

        'QTCode
        If Me.ChkQtCode.Checked = True Then
            StrFilter &= " AND [QTCode] like '%" & Trim(Me.txtQTCode.Text) & "%' "
        End If

        'Customer
        If Me.ChkCus.Checked = True Then
            StrFilter &= " AND [CusName] like '%" & txtCusName.Text.Trim & "%'"
        End If

        'PsQT
        If Me.ChkPsSale.Checked = True Then
            StrFilter &= " AND [PsQT] like '%" & txtPsQT.Text.Trim & "%'"
        End If

        GVSaleQT.ActiveFilterString = "1=1 " & StrFilter

        Dim totalNet As Double = 0.0
        For i As Integer = 0 To GVSaleQT.DataRowCount - 1
            totalNet = totalNet + GVSaleQT.GetDataRow(i).Item("TotalNet")
        Next
        txtTotalNet.Text = Format(totalNet, "#,###0.00##")
        txtCount.Text = Format(GVSaleQT.DataRowCount, "#,##0")
    End Sub

    Private Sub btnSFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSFindAll.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        BindData()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub GVSaleQT_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVSaleQT.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub GVSaleQT_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVSaleQT.RowCellStyle
        If Not IsDBNull(GVSaleQT.GetRowCellValue(e.RowHandle, ColidPsCancel1)) Then
            e.Appearance.BackColor = Color.Salmon
            e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Strikeout)
        End If
    End Sub

    Private Sub GVSaleQT_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVSaleQT.RowClick
        If e.RowHandle < 0 Then
            Exit Sub
        End If

        If Not IsDBNull(GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColidPsCancel1)) Then
            MessageBox.Show("ผู้ยกเลิก : " & GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColPsCancel1) & vbNewLine & "ยกเลิกสาเหตุ : " & GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColCancelNote), sSystemName)
        End If
    End Sub

    ' Edit
    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles rptEdit.Click
        If IsDBNull(GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColidPsCancel1)) = True Then
            Dim vFrm As New frmQtTs(frmQtTs.eProcess.eEdit, GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColidQT1))
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                BindData()
            End If
        End If
    End Sub

    'View
    Private Sub RepositoryItemButtonEdit8_Click(sender As Object, e As EventArgs) Handles rpbEditDetail.Click
        If IsDBNull(GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColidPsCancel1)) = True Then
            Dim vFrm As New frmQtTs(frmQtTs.eProcess.eviewData, GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColidQT1))
            vFrm.ShowDialog()
        End If
    End Sub

    'Doc
    Private Sub RepositoryItemButtonEdit2_Click(sender As Object, e As EventArgs) Handles rptEditDoc.Click
        If IsDBNull(GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColidPsCancel1)) = True Then
            mdCnOpen()
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            Dim idQT As Integer = GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColidQT1)       
            Dim stSignPsQT As Integer = 0

            '**** พิมพ์เอกสารเสนอราคา ****'
            Dim QTDT As New DataTable
            QTDT.Clear()
            sCommand.CommandText = "SELECT mt.idQT, mt.QTCode, FORMAT(mt.DateQTsD, 'd', 'th') As DateQTs, " & vbNewLine & _
                                   "FORMAT (mt.DateQTeD, 'd', 'th') As DateQTe, mt.NumOfDayQT, pt.PaymentTerms, c.CusName_, " & vbNewLine & _
                                   "c.Address, c.Tel, C.Fax, p1.PsFullName As PsQT, mt.idPsQT, mt.Note, " & vbNewLine & _
                                   "Pd.InvName, dt.Amount, u.UnitName As Unit, dt.Price, dt.PriceBfDis, " & vbNewLine & _
                                   "(CASE WHEN DisPerc <> 0 THEN ((DisPerc*PriceBfDis)/100) ELSE DisBath END) As DisCount," & vbNewLine & _
                                   "cp.CompName, mt.idcomp, cp.Address As AddressComp, ISNULL(cp.Tel, '-') As TelComp, " & vbNewLine & _
                                   "ISNULL(cp.Fax, '-') As FaxComp, ISNULL(cp.TaxCode, '-') As TaxComp, ISNULL(cp.PostCode,'') AS PostCode, pv.ProvinceName " & vbNewLine & _
                                   "FROM SmQtDt dt " & vbNewLine & _
                                   "LEFT JOIN SmQtMt mt ON dt.idQT = mt.idQT " & vbNewLine & _
                                   "LEFT JOIN vPersonxSelect p1 ON mt.idPsQT = p1.idPs " & vbNewLine & _
                                   "LEFT JOIN SmPaymentTermsD pt ON mt.PaymentQT = pt.idPM " & vbNewLine & _
                                   "LEFT JOIN vCustomer c ON mt.idCus = c.idCus " & vbNewLine & _
                                   "LEFT JOIN dInventoryMain pd ON dt.idInvMain = pd.idInvMain " & vbNewLine & _
                                   "LEFT JOIN dInvUnit u ON dt.idUnit = u.idUnit " & vbNewLine & _
                                   "LEFT JOIN PchInvAndProject.dbo.dCompany cp ON mt.idComp = cp.idComp " & vbNewLine & _
                                   "INNER JOIN PchInvAndProject.dbo.dProvinceFix pv ON cp.idProvince = pv.idProvince " & vbNewLine & _
                                   "WHERE mt.idQT = " & idQT
        
            QTDT.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))
            QTDT.Columns.Add("picSignPsQT", System.Type.GetType("System.Byte[]"))
            sAdapter.Fill(QTDT)


            QTDT.Rows(0).Item("AddressComp") = QTDT.Rows(0).Item("AddressComp") & " จ." & QTDT.Rows(0).Item("ProvinceName") & QTDT.Rows(0).Item("PostCode")
        
            Dim URL As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & QTDT.Rows(0).Item("idComp") & ".jpg"
            Dim client As New System.Net.WebClient
            Dim buffer As Byte()
            Dim pic() As Byte

            Try
                buffer = client.DownloadData(URL)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                For i As Integer = 0 To QTDT.Rows.Count - 1
                    QTDT.Rows(i).Item("picComp") = pic
                Next
            Catch ex As Exception
                ' Noimage
            End Try

            '---sign PsQT Pic---'
            Dim URL2 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & QTDT.Rows(0).Item("idPsQT") & ".png"
            Try
                buffer = client.DownloadData(URL2)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                For i As Integer = 0 To QTDT.Rows.Count - 1
                    QTDT.Rows(i).Item("picSignPsQT") = pic
                Next

            Catch ex As Exception
                stSignPsQT = 1
                ' Noimage
            End Try

            SplashScreenManager.CloseForm(False)
            Dim vFrm As New FrmReportView
            Dim vRpt As New crpQt
            vRpt.SetDataSource(QTDT)
            vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, QTDT.Rows(0).Item("CompName"))
            vRpt.SetParameterValue(vRpt.Parameter_stSignPsQT.ParameterFieldName, stSignPsQT)
            vFrm.crView.ReportSource = vRpt
            vFrm.Show()
        End If
    End Sub

    'Cancel
    Private Sub RepositoryItemButtonEdit6_Click(sender As Object, e As EventArgs) Handles rptEditCancel.Click
        If IsDBNull(GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColidPsCancel1)) = True Then
            Dim CancelNote As String = " "
            CancelNote = InputBox("ระบุสาเหตุการยกเลิก", sSystemName)

            If CancelNote <> "" And CancelNote <> "0" And CancelNote <> "-" And CancelNote.Length > 5 Then
                mdCnOpen()
                SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
                sCommand.CommandText = "Update SmQtMt Set idPsCancel= " & sPsId & ", CancelNote= '" & CancelNote & "' " & vbNewLine & _
                                       "WHERE idQT = " & GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColidQT1)
                sCommand.ExecuteNonQuery()

                BindData()
                SplashScreenManager.CloseForm(False)
                MessageBox.Show("ยกเลิกรายการเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("กรุณาระบุสาเหตุการยกเลิกให้ชัดเจน", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'Dim vFrm As New frmQtTs(frmQtTs.eProcess.eCancel, GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColidQT1))
            'If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    BindData()
            'End If
        End If
    End Sub

    'Select
    Private Sub rpbEditSelect_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbEditSelect.ButtonClick
        MasterDt.Columns.Add("idQT", System.Type.GetType("System.Int64"))
        MasterDt.Columns.Add("NumOfQT", System.Type.GetType("System.Int32"))
        MasterDt.Columns.Add("PaymentQT", System.Type.GetType("System.String"))
        MasterDt.Columns.Add("PsQT", System.Type.GetType("System.String"))
        MasterDt.Columns.Add("idPsQT", System.Type.GetType("System.Int32"))
        MasterDt.Columns.Add("stPrice", System.Type.GetType("System.Int32"))
        MasterDt.Columns.Add("CusName", System.Type.GetType("System.String"))
        MasterDt.Columns.Add("CusAddress", System.Type.GetType("System.String"))
        MasterDt.Columns.Add("CusConn", System.Type.GetType("System.String"))
        MasterDt.Columns.Add("CusConnTel", System.Type.GetType("System.String"))

        Dim dr_ As DataRow = MasterDt.NewRow
        dr_("idQT") = GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColidQT1)
        dr_("NumOfQT") = GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColNumOfQT)
        dr_("PaymentQT") = GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColPaymentQT)
        dr_("PsQT") = GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColPsQT)
        dr_("idPsQT") = GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColidPsQT)
        dr_("stPrice") = GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColStPeice)
        dr_("CusName") = GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColCusName)
        dr_("CusAddress") = GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColCusAddress)
        dr_("CusConn") = GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColCusConn)
        dr_("CusConnTel") = GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColCusConnTel)
        MasterDt.Rows.Add(dr_)

        'idQT = GVSaleQT.GetRowCellValue(GVSaleQT.FocusedRowHandle, ColidQT1)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub ChkGroupComp_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGroupComp.CheckedChanged
        CheckGroup()
    End Sub

    Private Sub ChkGroupCus_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGroupCus.CheckedChanged
        CheckGroup()
    End Sub

    Sub CheckGroup()
        Select Case ChkGroupComp.Checked
            Case True
                ColCompName.GroupIndex = 0
                If Me.ChkGroupCus.Checked = True Then
                    ColCusName.GroupIndex = 1
                Else
                    ColCusName.GroupIndex = -1
                End If
            Case False
                ColCompName.GroupIndex = -1
                If Me.ChkGroupCus.Checked = True Then
                    ColCusName.GroupIndex = 0
                Else
                    ColCusName.GroupIndex = -1
                End If
        End Select
        GVSaleQT.ExpandAllGroups()
    End Sub

    Private Sub dtpQTs_ValueChanged(sender As Object, e As EventArgs) Handles dtpQTs.ValueChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub dtpQTe_ValueChanged(sender As Object, e As EventArgs) Handles dtpQTe.ValueChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub dtpMonthS_ValueChanged(sender As Object, e As EventArgs) Handles dtpMonthS.ValueChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub

    Private Sub dtpYear_ValueChanged(sender As Object, e As EventArgs) Handles dtpYear.ValueChanged
        If stload = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
    End Sub
End Class