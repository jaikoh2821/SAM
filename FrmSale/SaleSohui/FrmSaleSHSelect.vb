Public Class FrmSaleSHSelect

    Enum eProcess
        eSel
    End Enum

    Dim xProcess As eProcess
    Dim gidComp As Integer = 0
    Dim stLoad As Integer = 0
    Public dtSel As New DataTable
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim dtBindData As New DataTable
    Dim xstridSale As String = ""
    Dim xstrZoneName As String = ""
    Sub New(ByVal aProcess As eProcess, ByVal stridSale As String, ByVal idComp As Integer, ByVal strZoneName As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        xProcess = aProcess
        gidComp = idComp
        xstridSale = stridSale
        xstrZoneName = strZoneName
    End Sub
    Private Sub FrmSaleSHSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpSaleS.Value = Date.Now
        initDataTable(dtSel)

        mdCnOpen()
        Dim dt As New DataTable
        sCommand.CommandText = "SELECT idSeasonPd, SeasonCode +' : '+ SeasonName As SeasonName FROM dSeasonOfProduce WHERE stDel Is NULL Order By idSeasonPd DESC"
        sAdapter.Fill(dt)
        cmbSeason.DisplayMember = "SeasonName"
        cmbSeason.ValueMember = "idSeasonPd"
        cmbSeason.DataSource = dt

        If xstrZoneName <> "" Then
            cbZone.Checked = True
            txtZoneName.Text = xstrZoneName
            txtZoneName.Enabled = True
        End If

        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()

        stLoad = 1
    End Sub

    Private Sub initDataTable(sender As Object)
        sender.Columns.Add("idSale", System.Type.GetType("System.Int32"))
        sender.Columns.Add("DocRef", System.Type.GetType("System.String"))
        sender.Columns.Add("idPartner", System.Type.GetType("System.Int32"))
        sender.Columns.Add("PartnerNameBill", System.Type.GetType("System.String"))
        sender.Columns.Add("TotalNet", System.Type.GetType("System.Double"))
        sender.Columns.Add("idJobMt", System.Type.GetType("System.Int32"))
        sender.Columns.Add("ZoneName", System.Type.GetType("System.String"))
        sender.Columns.Add("DateSaleD", System.Type.GetType("System.DateTime"))
    End Sub

    Private Sub BindData()

        Dim strWhere As String = ""

        strWhere = "AND sMt.idSale Not In(" & xstridSale & ")"


        If cbDateSale.Checked = True Then
            Dim sDateMN As DateTime = Convert.ToDateTime(dtpSaleS.Value, _cultureEnInfo)
            Dim sMonthMN As Integer = sDateMN.Month
            Dim sYearMN As Integer = sDateMN.Year

            strWhere = strWhere & " AND MONTH(sMt.DateSaleD) = " & sMonthMN & vbNewLine &
                                  " AND YEAR(sMt.DateSaleD) = " & sYearMN
        End If

        If cbSeason.Checked = True Then
            strWhere = strWhere & " And iMt.idSeasonPd = " & cmbSeason.SelectedValue
        End If

        If cbZone.Checked = True Then
            strWhere = strWhere & " And f.ZoneName Like '%" & txtZoneName.Text.Trim & "%'"
        End If
        dtBindData.Clear()
        sCommand.CommandText = "SELECT CONVERT(bit,0) As Chk, sMt.idSale, sMt.DocRef, sMt.idPartner, sMt.PartnerNameBill, sMt.DateSaleD, sMt.TotalNet, sMt.idJobMt, f.ZoneName, s.SeasonCode, s.idSeasonPd" & vbNewLine &
                               "FROM SmSaleMt sMt " & vbNewLine &
                               "LEFT JOIN PdIndexShJobMt jMt On sMt.idJobMt = jMt.idJobMt" & vbNewLine &
                               "LEFT JOIN PdIndexJobDt jDt On jMt.idJob = jDt.idJob" & vbNewLine &
                               "LEFT JOIN PdIndexMt iMt ON jDt.idIndex = iMt.idIndex" & vbNewLine &
                               "LEFT JOIN vFarmer f ON jDt.idFm = f.idFm" & vbNewLine &
                               "LEFT JOIN dSeasonOfProduce s ON iMt.idSeasonPd = s.idSeasonPd" & vbNewLine &
                               "WHERE ISNULL(sMt.idJobMt,0) <> 0 " & vbNewLine &
                               "AND ISNULL(sMt.idJobMt,0) <> 1 " & vbNewLine &
                               "AND sMt.idComp = " & gidComp & vbNewLine &
                               "AND sMt.stGroup Is NULL" & vbNewLine &
                               strWhere
        sAdapter.Fill(dtBindData)

        If dtBindData.Rows.Count = 0 Then
            GCSaleSH.DataSource = Nothing
            MessageBox.Show("ไม่พบข้อมูลใบแจ้งหนี้สินค้าโสหุ้ย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GCSaleSH.DataSource = dtBindData
            txtCount.Text = Format(dtBindData.Rows.Count, "#,##0")
            GVSaleSH.ExpandAllGroups()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub cbCus_CheckedChanged(sender As Object, e As EventArgs) Handles cbZone.CheckedChanged
        If stLoad = 1 Then
            If Me.cbZone.Checked = True Then
                Me.txtZoneName.Enabled = True
                Me.txtZoneName.Focus()
            Else
                Me.txtZoneName.Enabled = False
                txtZoneName.Text = ""
            End If

            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub cbDateSale_CheckedChanged(sender As Object, e As EventArgs) Handles cbDateSale.CheckedChanged
        If stLoad = 1 Then
            If Me.cbDateSale.Checked = True Then
                Me.dtpSaleS.Enabled = True
                Me.dtpSaleS.Focus()
            Else
                Me.dtpSaleS.Enabled = False
            End If

            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub


    Private Sub txtCusName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtZoneName.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub dtpSaleS_ValueChanged(sender As Object, e As EventArgs) Handles dtpSaleS.ValueChanged
        If stLoad = 1 Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If

    End Sub

    Private Sub cbSeason_CheckedChanged(sender As Object, e As EventArgs) Handles cbSeason.CheckedChanged
        If stLoad = 1 Then
            If Me.cbSeason.Checked = True Then
                Me.cmbSeason.Enabled = True
            Else
                Me.cmbSeason.Enabled = False
            End If

            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub cmbSeason_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbSeason.SelectedValueChanged
        If stLoad = 1 Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub cbSelAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbSelAll.CheckedChanged
        If cbSelAll.Checked = True Then
            Dim stCheck As Integer = 0
            For i As Integer = 0 To GVSaleSH.RowCount - 1
                GVSaleSH.SetRowCellValue(i, ColSel, 1)
            Next
        Else
            For i As Integer = 0 To GVSaleSH.RowCount - 1
                GVSaleSH.SetRowCellValue(i, ColSel, 0)
            Next
        End If
    End Sub

    Private Sub btnSFindAll_Click(sender As Object, e As EventArgs) Handles btnSFindAll.Click
        Dim dv As New DataView(dtBindData)
        dv.RowFilter = "Chk=True"
        For i As Integer = 0 To dv.Count - 1
            Dim dr_ As DataRow = dtSel.NewRow
            dr_("idSale") = dv.Item(i).Item("idSale")
            dr_("DocRef") = dv.Item(i).Item("DocRef")
            dr_("PartnerNameBill") = dv.Item(i).Item("PartnerNameBill")
            dr_("idPartner") = dv.Item(i).Item("idPartner")
            dr_("TotalNet") = dv.Item(i).Item("TotalNet")
            dr_("idJobMt") = dv.Item(i).Item("idJobMt")
            dr_("ZoneName") = dv.Item(i).Item("ZoneName")
            dr_("DateSaleD") = dv.Item(i).Item("DateSaleD")
            dtSel.Rows.Add(dr_)
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class