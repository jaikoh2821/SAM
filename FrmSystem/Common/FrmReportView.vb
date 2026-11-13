Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmReportView
    Dim mReport As New ReportDocument
    Dim mPath As String
    Dim mDt As New DataTable
    Dim mPv As New ParameterValues
    Dim mPdv As New ParameterDiscreteValue
    Dim mParameterFields As String
    Dim mParameterValues As String
    Dim mChkSendParameter As Boolean = False
    Public mNotPath As Boolean = True
    Public WriteOnly Property ppPathSet() As String
        Set(ByVal value As String)
            mReport.Load(value)
        End Set
    End Property
    Public WriteOnly Property ppDataTableSet() As DataTable
        Set(ByVal value As DataTable)
            mReport.SetDataSource(value)
        End Set
    End Property
    Public WriteOnly Property ppParameterFieldsSet() As String
        Set(ByVal value As String)
            mParameterFields = value
        End Set
    End Property
    Public WriteOnly Property ppParameterValuesSending() As String
        Set(ByVal value As String)
            mParameterValues = value
            mChkSendParameter = True
        End Set
    End Property

    'Public WriteOnly Property ppDisplayGroupTree() As Boolean
    '    Set(ByVal value As Boolean)
    '        crView.DisplayGroupTree = value
    '    End Set
    'End Property

    Private Sub FrmReportView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If mNotPath = False Then pSetData()
    End Sub

    Private Sub pSetData()
        crView.ReportSource = mReport
    End Sub
    Public Sub pParameterProcess(ByVal aParameterNames As String, ByVal aParameterValues As String)
        Dim vPn() As String = aParameterNames.Split("|")
        Dim vPv() As String = aParameterValues.Split("|")
        For i As Integer = 0 To vPn.Length - 1
            pSendParameterToRpt(vPv(i), vPn(i))
        Next
    End Sub
    Private Sub pSendParameterToRpt(ByVal aValue As String, ByVal aParameterName As String)
        mPdv.Value = aValue
        mPv.Add(mPdv)
        mReport.DataDefinition.ParameterFields(aParameterName).ApplyCurrentValues(mPv)
    End Sub


End Class