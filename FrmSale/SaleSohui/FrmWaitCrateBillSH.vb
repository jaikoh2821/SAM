
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmWaitCrateBillSH
    Dim xProcess As eProcess
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim stLoad As Integer = 0
    Dim ds0 As New DataSet
    'Dim dtWaitRecMt As New DataTable
    Dim dtWaitRecDt As New DataTable

    Enum eProcess
        eWaitXAdd
    End Enum

    Sub New(ByVal aProcess As eProcess)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eWaitXAdd
                Me.Text = "สร้างใบแจ้งหนี้/ใบวางบิล สินค้าโสหุ้ย"
        End Select

        xProcess = aProcess
    End Sub

    Private Sub frmRecPdList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nYear As Integer = Date.Today.Year
        dtpYear.Value = New Date(nYear, 1, 1)
        setCmbGroupComp(cmbGroupComp)

        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()


        dtWaitRecDt.Columns.Add("idWaitCutMt", System.Type.GetType("System.Int64"))
        dtWaitRecDt.Columns.Add("LotNo", System.Type.GetType("System.Int64"))
        dtWaitRecDt.Columns.Add("InvName", System.Type.GetType("System.String"))
        dtWaitRecDt.Columns.Add("idUnit", System.Type.GetType("System.Int64"))
        dtWaitRecDt.Columns.Add("UnitName", System.Type.GetType("System.String"))
        dtWaitRecDt.Columns.Add("AmountWaitRec", System.Type.GetType("System.Double"))

        stLoad = 1

    End Sub


    Private Sub btnShowdata_Click(sender As Object, e As EventArgs) Handles btnShowdata.Click
        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub BindData()
        ds0 = New DataSet

        Dim where As String = ""

        If chkComp.Checked = True Then
            Dim strComp As String = cmbGroupComp.SelectedValue

            If cmbGroupComp.SelectedValue = 3 Or cmbGroupComp.SelectedValue = 8 Then
                strComp = "3,8"
            End If

            where &= " AND comp.idComp  IN ( " & strComp & ")"
        Else
            If SIdCompStr = "3" Or SIdCompStr = "8" Then
                SIdCompStr = "3,8"
            End If

            where &= " AND comp.idComp IN (" & SIdCompStr & ") "
        End If


        If rdbDateTs.Checked = True Then
            Dim firstDate As DateTime = Convert.ToDateTime(dtpDateStart.Value, _cultureEnInfo)
            Dim lastDate As DateTime = Convert.ToDateTime(dtpDateNow.Value, _cultureEnInfo)
            where = where & " AND [devsk].[convertStrToDate](RecDate) Between '" & firstDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' " &
                              "And '" & lastDate.ToString("yyyy-MM-dd", _cultureEnInfo) & "' "
        End If

        If rdbYear.Checked = True Then
            Dim sDateY As DateTime = Convert.ToDateTime(dtpYear.Value, _cultureEnInfo)
            Dim sYearY As Integer = sDateY.Year
            where = where & " AND YEAR([devsk].[convertStrToDate](RecDate)) = " & sYearY
        End If

        If rdbMonth.Checked = True Then
            Dim sDateMN As DateTime = Convert.ToDateTime(dtpMonth.Value, _cultureEnInfo)
            Dim sMonthMN As Integer = sDateMN.Month
            Dim sYearMN As Integer = sDateMN.Year
            where = where & " AND MONTH([devsk].[convertStrToDate](RecDate)) = " & sMonthMN & vbNewLine &
                            " AND YEAR([devsk].[convertStrToDate](RecDate)) = " & sYearMN

        End If

        Dim dtWaitRecMt As New DataTable

        sCommand.CommandText = "Select comp.CompCode, comp.idComp, shMt.idJobMt , jDt.idJob, RecCode, [devsk].[convertStrToDate](RecDate) As RecDate, JobNo, p.PartnerName, Imt.StrainCode, SeedName + ' : ' + SeedTypeName As Seed, ps.PsName As PsTs, " & vbNewLine &
                                "(Select Sum(shDt.shPrice*shDt.shAmount ) From PdIndexShJobDt shDt Where shDt.idJobMt = shMt.idJobMt) As TotalMt" & vbNewLine &
                                "From PdIndexShJobMt shMt " & vbNewLine &
                                "Left Join PdIndexJobDt jDt ON shMt.idJob = jDt.idJob" & vbNewLine &
                                "Left Join dPartner p ON jDt.idFm = p.idFm" & vbNewLine &
                                "Left Join vPersonxSelect ps ON shMt.idPs = ps.idPs" & vbNewLine &
                                "Left Join PdIndexMt Imt ON jDt.idIndex = Imt.idIndex " & vbNewLine &
                                "Left Join dSeedType st ON Imt.idSeedType = st.idSeedType" & vbNewLine &
                                "Left Join dSeed s ON st.idSeed = s.idSeed" & vbNewLine &
                                "LEFT JOIN PchInvAndProject.dbo.dCompany comp ON shMt.idCompb = comp.idCompb  " & vbNewLine &
                                "WHERE shMt.idPsCancel Is NULL" & vbNewLine &
                                "AND shMt.idBillSAM IS NULL" & vbNewLine &
                                where


        sAdapter.Fill(dtWaitRecMt)
        dtWaitRecMt.TableName = "WaitCrBillMt"

        Dim dtWaitRecDt As New DataTable

        sCommand.CommandText = "Select shMt.idJobMt ,inv.InvName, inv.idInvMain, unit.idUnit, unit.UnitName, shDt.shPrice, shDt.shAmount,  shDt.shPrice*shDt.shAmount As TotalDt" & vbNewLine &
                                "From PdIndexShJobDt shDt" & vbNewLine &
                                "Left Join PdIndexShJobMt shMt ON shDt.idJobMt = shMt.idJobMt" & vbNewLine &
                                "Left Join dInventoryMain inv ON shDt.idSohui = inv.idSubType AND inv.idInvGroup = 40" & vbNewLine &
                                "Left Join dInvUnit unit ON inv.idUnit = unit.idUnit" & vbNewLine &
                                "LEFT JOIN PchInvAndProject.dbo.dCompany comp ON shMt.idCompb = comp.idCompb  " & vbNewLine &
                                "WHERE shMt.idPsCancel Is NULL" & vbNewLine &
                                "AND shMt.idBillSAM IS NULL" & vbNewLine &
                                 where


        sAdapter.Fill(dtWaitRecDt)
        dtWaitRecDt.TableName = "WaitCrBillDt"

        ds0.Tables.Clear()

        ds0.Tables.Add(dtWaitRecMt)
        ds0.Tables.Add(dtWaitRecDt)

        Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idJobMt")
        Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idJobMt")

        ds0.Relations.Add("รายการสินค้าโสหุ้ย", keyColumn, foreignColumn)

        If ds0.Tables(0).Rows.Count <= 0 Then
            MessageBox.Show("ไม่พบรายการเบิกโสหุ้ย ที่รอสร้างใบแจ้งหนี้/ใบวางบิล", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        GCWaitCrateBill.DataSource = ds0.Tables(0)
        GCWaitCrateBill.ForceInitialize()

        GCWaitCrateBill.LevelTree.Nodes.Add("รายการสินค้าโสหุ้ย", GVWaitCrateBillDt)
        txtCount.Text = Format(GVWaitCrateBillMt.DataRowCount, "#,##0")
    End Sub

    Private Sub GVWaitCrateBillDt_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GVWaitCrateBillDt.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If
    End Sub



    Private Sub fnFilterDataOnGrid()
        Dim StrFilter As String = ""

        If chkDocCode.Checked = True Then
            StrFilter &= " AND [RecCode] LIKE '%" & txtDocCode.Text.Trim & "%'"
        End If

        If cbJobNo.Checked = True Then
            StrFilter &= " AND [JobNo] LIKE '%" & txtJobNo.Text.Trim & "%'"
        End If

        If cbFarmer.Checked = True Then
            StrFilter &= " AND [PartnerName] LIKE '%" & txtFarmer.Text.Trim & "%'"
        End If

        If chkComp.Checked = True Then
            Dim strComp As String = cmbGroupComp.SelectedValue

            If cmbGroupComp.SelectedValue = 3 Or cmbGroupComp.SelectedValue = 8 Then
                strComp = "3,8"
            End If
            StrFilter &= " AND [idComp] IN( " & strComp & ")"
        End If

        GVWaitCrateBillMt.ActiveFilterString = " 1=1" + StrFilter
        txtCount.Text = Format(GVWaitCrateBillMt.DataRowCount, "#,##0")
    End Sub

    Private Function GetChildRowCount(ByRef View As GridView) As Integer
        Dim RowCount As Integer
        View.BeginUpdate()
        Try
            Dim dataRowCount As Integer = View.DataRowCount
            Dim rHandle As Integer
            For rHandle = 0 To dataRowCount - 1
                View.SetMasterRowExpanded(rHandle, True)
                Dim childView As ColumnView = View.GetDetailView(rHandle, 0)
                If Not IsNothing(childView) Then
                    RowCount = RowCount + childView.RowCount
                End If
            Next
        Catch ex As Exception
            'XtraMessageBox.Show(ex.Message, "DampoDesk", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            View.EndUpdate()
        End Try
        Return RowCount
    End Function

    Private Sub chkComp_CheckedChanged(sender As Object, e As EventArgs) Handles chkComp.CheckedChanged
        If stLoad = 1 Then
            If chkComp.Checked = True Then
                cmbGroupComp.Enabled = True
            Else
                cmbGroupComp.Enabled = False
            End If

            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub chkDocCode_CheckedChanged(sender As Object, e As EventArgs) Handles chkDocCode.CheckedChanged
        If stLoad = 1 Then
            If chkDocCode.Checked = True Then
                txtDocCode.Enabled = True
                txtDocCode.Focus()
            Else
                txtDocCode.Text = ""
                txtDocCode.Enabled = False
            End If

            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub cbJobNo_CheckedChanged(sender As Object, e As EventArgs) Handles cbJobNo.CheckedChanged
        If stLoad = 1 Then
            If cbJobNo.Checked = True Then
                txtJobNo.Enabled = True
                txtJobNo.Focus()
            Else
                txtJobNo.Text = ""
                txtJobNo.Enabled = False
            End If

            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub cbFarmer_CheckedChanged(sender As Object, e As EventArgs) Handles cbFarmer.CheckedChanged
        If stLoad = 1 Then
            If cbFarmer.Checked = True Then
                txtFarmer.Enabled = True
                txtFarmer.Focus()
            Else
                txtFarmer.Text = ""
                txtFarmer.Enabled = False
            End If

            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub txtDocCode_TextChanged(sender As Object, e As EventArgs) Handles txtDocCode.TextChanged
        If stLoad = 1 Then
            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub txtFarmer_TextChanged(sender As Object, e As EventArgs) Handles txtFarmer.TextChanged
        If stLoad = 1 Then
            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub txtJobNo_TextChanged(sender As Object, e As EventArgs) Handles txtJobNo.TextChanged
        If stLoad = 1 Then
            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub rdbDateTs_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDateTs.CheckedChanged
        If stLoad = 1 Then
            GCWaitCrateBill.DataSource = Nothing
            txtCount.Text = Format(GVWaitCrateBillMt.DataRowCount, "#,##0")

            If rdbDateTs.Checked = True Then
                dtpDateStart.Enabled = True
                dtpDateNow.Enabled = True
                rdbMonth.Checked = False
                rdbYear.Checked = False
            Else
                dtpDateStart.Enabled = False
                dtpDateNow.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbMonth_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMonth.CheckedChanged
        If stLoad = 1 Then
            GCWaitCrateBill.DataSource = Nothing
            txtCount.Text = Format(GVWaitCrateBillMt.DataRowCount, "#,##0")
            dtpMonth.Enabled = rdbMonth.Checked
            If rdbMonth.Checked = True Then
                rdbDateTs.Checked = False
            End If
        End If
    End Sub

    Private Sub rdbYear_CheckedChanged(sender As Object, e As EventArgs) Handles rdbYear.CheckedChanged
        If stLoad = 1 Then
            GCWaitCrateBill.DataSource = Nothing
            txtCount.Text = Format(GVWaitCrateBillMt.DataRowCount, "#,##0")
            dtpYear.Enabled = rdbYear.Checked
            If rdbYear.Checked = True Then
                rdbDateTs.Checked = False
            End If
        End If
    End Sub

    Private Sub rptBtnCrateBill_Click(sender As Object, e As EventArgs) Handles rptBtnCrateBill.Click
        Dim dr As DataRowView = GVWaitCrateBillMt.GetFocusedRow
        Dim drDetail() As DataRow = ds0.Tables("WaitCrBillDt").Select("idJobMt =" & dr.Item("idJobMt"))

        Dim vFrm As New FrmSlSaleTsSH(FrmSlSaleTsSH.eProcess.eCrBillFrWait, dr, drDetail, GVWaitCrateBillMt.GetRowCellValue(GVWaitCrateBillMt.FocusedRowHandle, "idJobMt"), 0)

        If vFrm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub GCWaitCrateBill_Click(sender As Object, e As EventArgs) Handles GCWaitCrateBill.Click

    End Sub
End Class