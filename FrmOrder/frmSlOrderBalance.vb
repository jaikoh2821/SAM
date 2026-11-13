Imports DevExpress.XtraGrid.Views.Base

Public Class frmSlOrderBalance
    Enum eProcess
        eOrderBal
    End Enum

    Dim xProcess As eProcess
    Dim stLoad As Integer = 0

    Sub New(ByVal aProcess As eProcess)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        xProcess = aProcess
    End Sub

    Private Sub frmSlOrderBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpYear.Value = Date.Today
        dtpMonthS.Value = Date.Today
        dtpDateS.Value = Date.Today
        dtpDateE.Value = Date.Today

        setCmbGroupComp(Me.cmbGroupComp)

        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()

        stLoad = 1
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub
    Private Sub BindData()
        Dim vWhere As String = ""
        Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")

        If Me.rdbDate.Checked = True Then
            Dim DateQTs As DateTime = Convert.ToDateTime(dtpDateS.Value, _cultureEnInfo)
            Dim DateQTe As DateTime = Convert.ToDateTime(dtpDateE.Value, _cultureEnInfo)

            vWhere &= "WHERE m.DateOrderD BETWEEN '" & DateQTs.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " &
                      "AND '" & DateQTe.AddDays(1).AddSeconds(-1).ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "' "
        ElseIf Me.rdbMonth.Checked = True Then
            Dim sDate As DateTime = Convert.ToDateTime(dtpMonthS.Value, _cultureEnInfo)
            Dim sMonth As Integer = sDate.Month
            Dim sYear As Integer = sDate.Year

            vWhere &= "WHERE Month(m.DateOrderD) = " & sMonth & " AND YEAR(m.DateOrderD) = " & sYear & " "
        ElseIf Me.rdbYear.Checked = True Then
            Dim sDate As DateTime = Convert.ToDateTime(dtpYear.Value, _cultureEnInfo)
            Dim sYear As Integer = sDate.Year
            vWhere &= "WHERE YEAR(m.DateOrderD) = " & sYear & " "
        End If

        If ChkCus.Checked = True And lblPartnerName.Text.Trim <> "" Then
            vWhere = vWhere & vbNewLine &
                     "AND m.idPartner = " & lblPartnerName.Tag
        End If

        If chkInvName.Checked = True Then
            vWhere = vWhere & vbNewLine &
                    "AND d.idInvMain = " & lblInvName.Tag
        End If

        Dim dt As New DataTable

        sCommand.CommandText = "WITH OrderSummary AS (SELECT ROW_NUMBER() OVER(ORDER BY (SELECT 1)) AS RowNum,m.idPartner, p.PartNerName, ISNULL(m.DocCode,'-') As DocCode," & vbNewLine &
                                                      "IIF(IsNull(m.idPOTs,0) = 0, ISNULL(m.DocRef,'-'), bMt.DocCode) As DocRef, m.DateRequireD," & vbNewLine &
                                                      "d.idSaleOrderDt, d.idInvMain, inv.InvName, d.Amount As AmtOrder, u.UnitName, ps.PsName As PsSale, m.DateOrderD, d.Price," & vbNewLine &
                                                      "ISNULL((SELECT SUM(Amount) " & vbNewLine &
                                                              "FROM SmSaleDtAll dt" & vbNewLine &
                                                              "Left Join SmSaleMt mt ON dt.idSale = mt.idSale" & vbNewLine &
                                                              "WHERE dt.idSaleOrderDt = d.idSaleOrderDt" & vbNewLine &
                                                              "AND mt.idPsCanCel Is NULL " & vbNewLine &
                                                              "AND idSlAVxST Is NULL" & vbNewLine &
                                                              "AND d.idPscancel Is NULL), 0) As AmtSale, d.Note, ISNULL(t.PayTspName, ts.PayTspName) As PayTspName " & vbNewLine &
                                                        "FROM SmSaleOrderDt d " & vbNewLine &
                                                        "LEFT JOIN SmSaleOrderMt m On d.idSaleOrder = m.idSaleOrder " & vbNewLine &
                                                        "LEFT JOIN dInventoryMain inv On d.idInvMain = inv.idInvMain " & vbNewLine &
                                                        "LEFT JOIN dInvUnit u On d.idUnit = u.idUnit  " & vbNewLine &
                                                        "LEFT JOIN vPersonxSelect ps ON m.idPsSale = ps.idPs" & vbNewLine &
                                                        "LEFT JOIN dPartNer p ON m.idPartner = p.idPartner" & vbNewLine &
                                                        "LEFT JOIN dCustomer c ON p.idCus = c.idCus" & vbNewLine &
                                                        "LEFT JOIN vCusAdrSetTransport t On c.idCus = t.idCus And m.idComp = t.idComp" & vbNewLine &
                                                        "LEFT JOIN dPayTspType ts ON c.idPayTsp = ts.idPayTsp" & vbNewLine &
                                                        "LEFT JOIN PkPOBuyMt bMt ON ISNULL(m.idPOTs,0) = bMt.idPOTs" & vbNewLine &
                                                    vWhere & vbNewLine &
                                                        "AND m.idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
                                                        "AND d.idPsCancel Is NULL" & vbNewLine &
                                                        "AND m.idPsCancel Is NULL" & vbNewLine &
                                                    ")" & vbNewLine &
                                                    "SELECT *, (AmtOrder - AmtSale) AS AmtOrderBal" & vbNewLine &
                                                    "FROM OrderSummary" & vbNewLine &
                                                    "WHERE (AmtOrder - AmtSale) > 0" & vbNewLine &
                                                    "ORDER BY DateOrderD ASC"
        sAdapter.Fill(dt)

        GCSlOrderBal.DataSource = dt
        txtCount.Text = Format(GVSlOrderBal.DataRowCount, "#,##0")

        If dt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบรายการข้อมูลสั่งซื้อคงค้าง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub GVSlOrderBal_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVSlOrderBal.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub
    Private Sub rdbMonth_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMonth.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbMonth.Checked = True Then
                Me.dtpMonthS.Enabled = True
                mdCnOpen()
                mdLoadShow()
                BindData()
                mdLoadCommitt()
            Else
                Me.dtpMonthS.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbYear_CheckedChanged(sender As Object, e As EventArgs) Handles rdbYear.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbYear.Checked = True Then
                Me.dtpYear.Enabled = True
                mdCnOpen()
                mdLoadShow()
                BindData()
                mdLoadCommitt()
            Else
                Me.dtpYear.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbDate_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDate.CheckedChanged
        If stLoad = 1 Then
            If rdbDate.Checked = True Then
                Me.dtpDateS.Enabled = True
                Me.dtpDateE.Enabled = True
                mdCnOpen()
                mdLoadShow()
                BindData()
                mdLoadCommitt()
            Else
                Me.dtpDateS.Enabled = False
                Me.dtpDateE.Enabled = False
            End If
        End If
    End Sub

    Private Sub dtpDateS_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateS.ValueChanged
        If stLoad = 1 Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub dtpDateE_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateE.ValueChanged
        If stLoad = 1 Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub dtpMonthS_ValueChanged(sender As Object, e As EventArgs) Handles dtpMonthS.ValueChanged
        If stLoad = 1 Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub dtpYear_ValueChanged(sender As Object, e As EventArgs) Handles dtpYear.ValueChanged
        If stLoad = 1 Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub ChkCus_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCus.CheckedChanged
        If stLoad = 1 Then
            If Me.ChkCus.Checked = True Then
                Me.btnPartner.Enabled = True
            Else
                Me.btnPartner.Enabled = False
                lblPartnerName.Text = ""
                mdCnOpen()
                mdLoadShow()
                BindData()
                mdLoadCommitt()
            End If
        End If
    End Sub

    Private Sub chkInvName_CheckedChanged(sender As Object, e As EventArgs) Handles chkInvName.CheckedChanged
        If stLoad = 1 Then
            If Me.chkInvName.Checked = True Then
                btnInvName.Enabled = True
            Else
                btnInvName.Enabled = False
                lblInvName.Text = ""
                mdCnOpen()
                mdLoadShow()
                BindData()
                mdLoadCommitt()
            End If
        End If
    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub rdbCusName_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCusName.CheckedChanged, rdbInvName.CheckedChanged
        If stLoad = 1 Then
            OrderByGroup()
        End If
    End Sub
    Sub OrderByGroup()
        If rdbInvName.Checked = True Then
            ColInvName.GroupIndex = 0
        ElseIf rdbCusName.Checked = True Then
            ColPartnerName.GroupIndex = 0
        ElseIf rdbNoGroup.Checked = True Then
            ColInvName.GroupIndex = -1
            ColPartnerName.GroupIndex = -1
        End If

        GVSlOrderBal.ExpandAllGroups()
    End Sub

    Private Sub rptAmtSale_Click(sender As Object, e As EventArgs) Handles rptAmtSale.Click
        If CDbl(GVSlOrderBal.GetDataRow(GVSlOrderBal.FocusedRowHandle).Item("AmtSale")) > 0 Then
            Dim vFrm As New frmDetailAmtOrderSale(frmDetailAmtOrderSale.eProcess.eSale,
                                                  GVSlOrderBal.GetDataRow(GVSlOrderBal.FocusedRowHandle).Item("DocCode"),
                                                  GVSlOrderBal.GetDataRow(GVSlOrderBal.FocusedRowHandle).Item("DocRef"),
                                                  GVSlOrderBal.GetDataRow(GVSlOrderBal.FocusedRowHandle).Item("InvName"),
                                                  GVSlOrderBal.GetDataRow(GVSlOrderBal.FocusedRowHandle).Item("idSaleOrderDt"))
            vFrm.ShowDialog()
        Else
            MessageBox.Show("รายการนี้ยังไม่มีการเปิดบิลขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        'Dim path As String = "SlOrderBalance.xlsx"
        'GCSlOrderBal.ExportToXlsx(path)

        '' Open the created XLSX file with the default application.
        'Process.Start(path)

        ' ใส่ไว้ก่อนบรรทัด ExportToXlsx
        Dim path As String = "SlOrderBalance.xlsx"
        Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(GCSlOrderBal.MainView, DevExpress.XtraGrid.Views.Grid.GridView)

        ' 1. บังคับตั้งค่าการ Export ให้เก็บรายละเอียดทุอย่าง
        gv.OptionsPrint.AutoWidth = False

        ' 2. ถ้าคอลัมน์ลำดับเป็นคอลัมน์ที่ไม่มี FieldName (สร้างลอยๆ) 
        ' ให้ลองใช้คำสั่ง ForceDataRefresh ก่อน
        gv.LayoutChanged()

        ' 3. ใช้ Options สำหรับการ Export แบบดั้งเดิม (DataAware)
        ' บางครั้ง WYSIWYG อาจจะมีปัญหากับ Unbound Column
        Dim options As New DevExpress.XtraPrinting.XlsxExportOptionsEx()
        options.ExportType = DevExpress.Export.ExportType.DataAware
        options.AllowGrouping = DevExpress.Utils.DefaultBoolean.False

        Try
            GCSlOrderBal.ExportToXlsx(path, options)
            Process.Start(path)
        Catch ex As Exception
            MessageBox.Show("กรุณาปิดไฟล์ Excel เดิมก่อนทำการ Export ใหม่")
        End Try
    End Sub

    Private Sub btnInvName_Click(sender As Object, e As EventArgs) Handles btnInvName.Click
        Dim vFrm As New frmAllInvSelect(frmAllInvSelect.eProcess.eAll, cmbGroupComp.SelectedValue)

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblInvName.Tag = vFrm.sdt1.Rows(0).Item("idInvMain")
            lblInvName.Text = vFrm.sdt1.Rows(0).Item("InvName")
        End If
    End Sub

    Private Sub btnPartner_Click(sender As Object, e As EventArgs) Handles btnPartner.Click

        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelectAllChkSt, cmbGroupComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblPartnerName.Tag = vFrm.idPartner 'Change idCus to idPartner 6/1/2564
            lblPartnerName.Text = vFrm.CusName
        End If


    End Sub

    Private Sub lblPartnerName_TextChanged(sender As Object, e As EventArgs) Handles lblPartnerName.TextChanged
        If stLoad = 1 Then
            If lblPartnerName.Text.Trim <> "" Then
                mdCnOpen()
                mdLoadShow()
                BindData()
                mdLoadCommitt()
            End If
        End If
    End Sub

    Private Sub lblInvName_TextChanged(sender As Object, e As EventArgs) Handles lblInvName.TextChanged
        If stLoad = 1 Then
            If lblInvName.Text.Trim <> "" Then
                mdCnOpen()
                mdLoadShow()
                BindData()
                mdLoadCommitt()
            End If
        End If
    End Sub
End Class