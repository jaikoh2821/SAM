Public Class frmSelFormCont
    Dim xProcess As eProcess
    Enum eProcess
        eSelForm
    End Enum

    Dim stridSale As String = ""
    Dim stWeightShow As Integer = 0
    Dim stPreView As Integer = 0
    Sub New(ByVal aProcess As eProcess, ByVal idSale As String, ByVal stWeight As Integer, ByVal stPV As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        stPreView = stPV
        stWeightShow = stWeight
        stridSale = idSale
    End Sub
    Private Sub frmSelFormCont_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If rdbPPForm.Checked = True And stPreView = 1 Then
            Dim vFrm As New frmPreviewCont(frmPreviewCont.eProcess.ePreview_PP, stridSale, stWeightShow)
            vFrm.Show()
        ElseIf rdbShowLot.Checked = True And stPreView = 1 Then
            Dim vFrm As New frmPreviewCont(frmPreviewCont.eProcess.ePreview_ShowLot, stridSale, stWeightShow)
            vFrm.Show()
        ElseIf rdbBlankForm.Checked = True And stPreView = 1 Then
            Dim vFrm As New frmPreviewCont(frmPreviewCont.eProcess.ePreview_Blank, stridSale, stWeightShow)
            vFrm.Show()
        ElseIf rdbBlankNoComp.Checked = True And stPreView = 1 Then
            Dim vFrm As New frmPreviewCont(frmPreviewCont.eProcess.ePreview_BlankNocomp, stridSale, stWeightShow)
            vFrm.Show()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class