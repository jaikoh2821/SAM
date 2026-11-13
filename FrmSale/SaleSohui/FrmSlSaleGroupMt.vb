Imports DevExpress.XtraGrid.Views.Base

Public Class FrmSlSaleGroupMt
    Enum eProcess
        eNew
        eView
    End Enum

    Dim xProcess As eProcess
    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        xProcess = aProcess
    End Sub

    Private Sub FrmSlSaleGroupMt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If xProcess = eProcess.eNew Then
            btnNew.PerformClick()
        End If

        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim vFrm As New FrmSlSaleGroupDt(FrmSlSaleGroupDt.eProcess.eNew, 0)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            mdCnOpen()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub BindData()
        Dim ds As New DataSet

        Dim dtSaleGroupMt As New DataTable
        sCommand.CommandText = "SELECT mt.idGroupMt, comp.CompCode, DocCodeGroup, DateDocGroup, PartnerNameGroup, TotalNet, DateTs, p.PsName As PsTs " & vbNewLine &
                                "FROM SmSaleGroupMt mt " & vbNewLine &
                                "LEFT JOIN vPersonxSelect p ON mt.idPsTs = p.idPs" & vbNewLine &
                                "LEFT JOIN PchInvAndProject.dbo.dCompany comp ON mt.idComp = comp.idComp"
        sAdapter.Fill(dtSaleGroupMt)

        dtSaleGroupMt.TableName = "mt"
        ds.Tables.Add(dtSaleGroupMt)


        Dim dtSaleGroupDt As New DataTable
        sCommand.CommandText = "SELECT dt.idGroupMt, dt.DocRef, dt.TotalBill, dt.PartnerNameBill, 'บาท' As UnitName" & vbNewLine &
                                "FROM SmSaleGroupDt dt "
        sAdapter.Fill(dtSaleGroupDt)

        dtSaleGroupDt.TableName = "dt"
        ds.Tables.Add(dtSaleGroupDt)

        ds.Relations.Add("Level1", ds.Tables("mt").Columns("idGroupMt"), ds.Tables("dt").Columns("idGroupMt"))

        Dim bs As New BindingSource
        bs.DataSource = dtSaleGroupMt
        GCSaleGroup.DataSource = bs
    End Sub

    Private Sub GVSlGroupMt_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GVSlGroupMt.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If
    End Sub

    Private Sub GVSlGroupDt_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GVSlGroupDt.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNumDt" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        mdCnOpen()
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub
End Class