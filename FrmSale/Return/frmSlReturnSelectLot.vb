Public Class frmSlReturnSelectLot
    Public pidLot As Integer
    Public pPdName As String
    Public pidPd As Integer
    Public pUnitName As String
    Public pidUnit As Integer
    Public pDateGen As String
    Public pCost As Double
    Public pdtType As Integer

    Dim LotDt As New DataTable
    Dim eEvent As eProcess
    Dim stPage As String = 0

    Enum eProcess
        eShowLot
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal vLotDt As DataTable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eShowLot
                stPage = 1
                LotDt = vLotDt
        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmSlReturnSelectLot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Sub BindData()
        mdLoadShow()
        GCData.DataSource = LotDt
        GvShowData.ExpandAllGroups()
        mdLoadCommitt()
    End Sub

    'Select Lot
    Private Sub RepositoryItemButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick
        pidLot = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColidLot)
        pPdName = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColPdPkName)
        pidPd = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColidPdPk)
        pUnitName = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColUnit)
        pidUnit = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColidUnit)
        pDateGen = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColDateGen)
        pCost = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColPricePerUnit)
        pdtType = GvShowData.GetRowCellValue(GvShowData.FocusedRowHandle, ColdtType)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class