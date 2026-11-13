Public Class frmCrateSaleRTData
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim xProcess As eProcess
    Dim stLoad As Integer = 0
    Enum eProcess
        eBillTs
        eMNBill
    End Enum

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        xProcess = aProcess
    End Sub

    Private Sub frmApvSaleReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpReturnS.Value = Date.Today
        dtpReturnE.Value = Date.Today
        dtpMonth.Value = Date.Today
        dtpYear.Value = Date.Today

        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()

        stLoad = 1

    End Sub

    Private Sub BindData()
        Dim vWhere As String = " WHERE mt.idComp IN( " & SIdCompStr & ")"

        If xProcess = eProcess.eBillTs Then
            vWhere = vWhere & vbNewLine &
                     "AND mt.idPsCancel Is NULL " & vbNewLine &
                     "AND mt.idReject Is NULL " & vbNewLine &
                     "AND mt.idPsCheck Is Not NULL"
            'vWhere = vWhere & vbNewLine &
            '       "AND mt.idPsCancel Is NULL " & vbNewLine &
            '       "AND mt.idReject Is NULL "
        End If

        Dim strDate As String = ""
        If rdbDateReturn.Checked = True Then
            strDate = "mt.DateWaitReturn"
        ElseIf rdbDateTs.Checked = True Then
            strDate = "mt.DateTs"
        End If

        If Me.rdbDate.Checked = True Then

            Dim firstDate As DateTime = Convert.ToDateTime(dtpReturnS.Value, _cultureEnInfo)
            Dim lastDate As DateTime = Convert.ToDateTime(dtpReturnE.Value, _cultureEnInfo)

            vWhere = vWhere & " And " & strDate & " Between '" & firstDate.ToString("yyyy-MM-dd 00:00:00.000", _cultureEnInfo) & "' " &
                              "And '" & lastDate.ToString("yyyy-MM-dd 23:59:00.000", _cultureEnInfo) & "' "

        ElseIf Me.rdbMonth.Checked = True Then

            Dim sDateS As DateTime = Convert.ToDateTime(dtpMonth.Value, _cultureEnInfo)
            Dim sMonthS As Integer = sDateS.Month
            Dim sYearY As Integer = sDateS.Year

            vWhere = vWhere & " AND YEAR(" & strDate & ") = " & sYearY & "AND MONTH(" & strDate & ") = " & sMonthS

        ElseIf Me.rdbYear.Checked = True Then
            Dim sDateY As DateTime = Convert.ToDateTime(dtpYear.Value, _cultureEnInfo)
            Dim sYearY As Integer = sDateY.Year
            vWhere = vWhere & " AND YEAR(" & strDate & ") = " & sYearY

        End If

        Dim ds0 As New DataSet
        Dim MainDt As New DataTable  ' SaleReturnMt
        Dim SubDt As New DataTable  ' SaleReturnDt

        sCommand.CommandText = "SELECT PsTs.PsName As PsTsName, PsSale.PsName As PsSaleName, PsRT.PsName As PsRTName, " & vbNewLine &
                                "mt.idComp, comp.CompCode, mt.idWaitReturn, PsCC.PsName As PsCancel, mt.CancelNote, mt.ReturnNo, " & vbNewLine &
                                "DocCode, DateWaitReturn, PartnerName, mt.DateTs, " & vbNewLine &
                                "CASE WHEN (SELECT Top 1 idRefLot From WimWaitReturnDt dt Where dt.idWaitReturn = mt.idWaitReturn ) <> NULL Then '1' ELSE '0' END As stBill" & vbNewLine &
                                "FROM WimWaitReturnMt mt " & vbNewLine &
                                "LEFT JOIN dPartner p ON mt.idPartner = p.idPartner" & vbNewLine &
                                "LEFT JOIN vPerSonxselect PsTs ON mt.idPsTs = PsTs.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect PsSale ON mt.idPsSale = PsSale.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect PsRT ON mt.idPsReturn = PsRT.idPs" & vbNewLine &
                                "LEFT JOIN vPersonxSelect PsCC ON mt.idPsCancel = PsCC.idPs" & vbNewLine &
                                "LEFT JOIN PchInvAndProject.dbo.dCompany As comp ON mt.idComp = comp.idComp  " & vbNewLine &
                                "LEFT JOIN SmSaleReturnMt sMt ON mt.idWaitReturn = sMt.idWaitReturn AND sMt.idPsCancel Is NULL " & vbNewLine &
                                vWhere & vbNewLine &
                                "And sMt.idSaleReturn Is NULL" & vbNewLine &
                                "Order by mt.DocCode DESC"


        sAdapter.Fill(MainDt)

        MainDt.Columns.Add("ChkKey", System.Type.GetType("System.Boolean"))

        For i As Integer = 0 To MainDt.Rows.Count - 1
            MainDt.Rows(i).Item("ChkKey") = False
        Next

        Dim tempDt As New DataTable

        sCommand.CommandText = "SELECT inv.InvName, mt.idWaitReturn, dt.AmountReturn, dt.LotNo, dt.BoxNo, u.UnitName, c.ReturnCause, devsk.StrWareHouse(dt.idWh,'') As WareHouseName" & vbNewLine &
                                "FROM WimWaitReturnDt dt" & vbNewLine &
                                "LEFT JOIN WimWaitReturnMt mt ON dt.idWaitReturn = mt.idWaitReturn" & vbNewLine &
                                "LEFT JOIN dInventoryMain inv ON dt.idInvMain = inv.idInvMain" & vbNewLine &
                                "LEFT JOIN SmSaleReturnCause c ON dt.idRtCause = c.idRtCause" & vbNewLine &
                                "LEFT JOIN dInvUnit u ON dt.idUnit = u.idUnit" & vbNewLine &
                                 "LEFT JOIN SmSaleReturnMt sMt ON mt.idWaitReturn = sMt.idWaitReturn AND sMt.idPsCancel Is NULL " & vbNewLine &
                                 vWhere & vbNewLine &
                                "And sMt.idSaleReturn Is NULL"

        sAdapter.Fill(tempDt)

        ds0.Tables.Clear()
        ds0.Tables.Add(MainDt)
        ds0.Tables.Add(tempDt)

        Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idWaitReturn")
        Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idWaitReturn")

        ds0.Relations.Add("รายการ", keyColumn, foreignColumn)

        If ds0.Tables(0).Rows.Count <= 0 Then
            MessageBox.Show("ไม่พบข้อมูลรายการรับคืนสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        GCWaitRT.DataSource = ds0.Tables(0)
        GCWaitRT.ForceInitialize()

        GCWaitRT.LevelTree.Nodes.Add("รายการ", GVReturnDt)

        txtCount.Text = Format(GVReturnMt.DataRowCount, "#,##0")
        stLoad = 1
    End Sub

    Private Sub rptApv_Click(sender As Object, e As EventArgs) Handles rptApv.Click
        Dim vFrm As New frmCrateSaleRTTs(frmCrateSaleRTTs.eProcess.eCrateBill, GVReturnMt.GetRowCellValue(GVReturnMt.FocusedRowHandle, "idWaitReturn"))
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub


    Private Sub GVReturnMt_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVReturnMt.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNumMt" Then

            e.DisplayText = (e.RowHandle + 1).ToString

        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub rdbMonthNow_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMonth.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbMonth.Checked = True Then
                Me.dtpMonth.Enabled = True
            Else
                Me.dtpMonth.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbYear_CheckedChanged(sender As Object, e As EventArgs) Handles rdbYear.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbYear.Checked = True Then
                Me.dtpYear.Enabled = True
            Else
                Me.dtpYear.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbDate_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDate.CheckedChanged
        If stLoad = 1 Then
            If Me.rdbDate.Checked = True Then
                Me.dtpReturnS.Enabled = True
                Me.dtpReturnE.Enabled = True
            Else
                Me.dtpReturnS.Enabled = False
                Me.dtpReturnE.Enabled = False
            End If
        End If
    End Sub

End Class