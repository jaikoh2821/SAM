Imports DevExpress.XtraSplashScreen

Public Class frmDebtorData
    Public DateBF As DateTime = Date.Now
    Dim stLoad As Integer = 0

    Private Sub frmDebtorData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdLoadShow()
        setCmbGroupComp(cmbGroupComp)
        BindData()
        stLoad = 1
        mdLoadCommitt()
    End Sub

    Private Sub frmDebtorData_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.txtCusName.Focus()
    End Sub

    Sub BindData()
        mdCnOpen()

        ' ColAmtDebt.Caption = "ยอดหนี้ยกมาจากปี " & CInt(Me.dtpYear.Text) - 1
        'Dim sDt As New DataTable
        'sCommand.CommandText = "SELECT s.idCus, c.CusName_, " & _
        '                        "ISNULL((SELECT BrForward FROM SmDebtorData WHERE idCus = s.idCus AND idComp = s.idComp " & _
        '                        "AND dYear = " & CInt(Me.dtpYear.Text) & "), 0.00) As BrForward, " & _
        '                        "(SELECT DateBF FROM SmDebtorData WHERE idCus = s.idCus AND idComp = s.idComp " & _
        '                        "AND dYear = " & CInt(Me.dtpYear.Text) & ") As DateBF, c.stActive " & vbNewLine &
        '                        "FROM SmMkCusPs s LEFT OUTER JOIN vCustomer c  ON s.idCus = c.idCus " & _
        '                        "WHERE c.stDel <> 1 AND s.idComp = " & sIdComp & " AND c.CusName_ like '%" & Trim(Me.txtCusName.Text) & "%'"
        'sAdapter.Fill(sDt)

        Dim ds0 As New DataSet
        Dim MainDt As New DataTable
        Dim SubDt As New DataTable

        MainDt.Rows.Clear()
        sCommand.CommandText = "SELECT s.idCus, c.CusName_, ISNULL(d.DebtBalance, 0.00) As DebtBalance, c.stActive  " & vbNewLine &
                               "FROM SmMkCusPs s LEFT OUTER JOIN vCustomer c  ON s.idCus = c.idCus " & vbNewLine &
                               "LEFT OUTER JOIN SmDebtorData d ON s.idCus = d.idCus AND s.idComp = d.idComp " & vbNewLine &
                               "WHERE c.stDel <> 1 AND s.idComp = " & cmbGroupComp.SelectedValue & ""
        sAdapter.Fill(MainDt)

        SubDt.Rows.Clear()
        sCommand.CommandText = "SELECT s.idCus, l.DateBF, l.AmountTs, p.PsName As PsTs, l.DateTs  " & vbNewLine &
                               "FROM SmMkCusPs s LEFT OUTER JOIN vCustomer c ON s.idCus = c.idCus " & vbNewLine &
                               "LEFT  JOIN SmDebtorData d ON s.idCus = d.idCus AND s.idComp = d.idComp " & vbNewLine &
                               "LEFT  JOIN SmDebtorDataLog l ON d.idDebt = l.idDebt " & vbNewLine &
                               "LEFT  JOIN vPersonxSelect p ON l.idPsTs = p.idPs  " & vbNewLine &
                               "WHERE d.idDebt IS NOT NULL AND l.stBF = 1 AND c.stDel <> 1 AND s.idComp = " & cmbGroupComp.SelectedValue & " " & _
                               "ORDER BY l.DateBF"
        sAdapter.Fill(SubDt)

        'pyMainDt = MainDt
        ds0.Tables.Clear()
        ds0.Tables.Add(MainDt)
        ds0.Tables.Add(SubDt)

        Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idCus")
        Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idCus")

        ds0.Relations.Add("ประวัติการยกยอดหนี้", keyColumn, foreignColumn)

        If ds0.Tables(0).Rows.Count <= 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลลูกค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        GCData.DataSource = ds0.Tables(0)
        GCData.ForceInitialize()

        GCData.LevelTree.Nodes.Add("ประวัติการยกยอดหนี้", GVLog)
        GVLog.ExpandAllGroups()
        'SumTotal()

        Dim Total As Double = 0.0
        For i As Integer = 0 To MainDt.Rows.Count - 1
            Total += MainDt.Rows(i).Item("DebtBalance")
        Next

        Me.lblSumDebt.Text = "ยอดหนี้รวม: " & Format(Total, "#,##0.00##") & " บาท "
        lblCount.Text = "จำนวนลูกค้า " & Format(MainDt.Rows.Count, "#,##0") & " ราย"

    End Sub


    'Add-Data
    Private Sub rbeditDebt_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rbeditDebt.ButtonClick
        Dim vFrm As New frmDebtorDataADD(frmDebtorDataADD.eProcess.eNew, GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColidCus), _
                                         GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColCusName), _
                                         GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColAmtDebt))
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            SplashScreenManager.CloseForm(False)
        End If
        ' End If
    End Sub

    Private Sub GvShowData_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GvShowData.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub GVLog_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVLog.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum2" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub GvShowData_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GvShowData.RowCellStyle
        If GvShowData.GetRowCellValue(e.RowHandle, ColstActive) = 1 Then
            e.Appearance.BackColor = Color.LightPink
        End If
    End Sub

    Private Sub btnSFindAll_Click(sender As Object, e As EventArgs) Handles btnSFindAll.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        BindData()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stLoad = 1 Then
            SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
            BindData()
            txtCusName.Text = ""
            SplashScreenManager.CloseForm(False)
            txtCusName.Focus()
        End If
    End Sub


    Private Sub txtCusName_TextChanged(sender As Object, e As EventArgs) Handles txtCusName.TextChanged
        GvShowData.ActiveFilterString = " [CusName_] like '%" & Trim(txtCusName.Text) & "%' "
        lblCount.Text = "จำนวนลูกค้า " & Format(GvShowData.DataRowCount, "#,##0") & " ราย"
    End Sub
End Class