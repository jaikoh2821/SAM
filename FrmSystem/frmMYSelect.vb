Public Class frmMYSelect
    Dim status As Integer
    Enum eProcess
        eYM
        eY
    End Enum
    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim datenow As New Date(Date.Now.Year, Date.Now.Month, 1)

        Select Case aProcess
            Case eProcess.eYM
                status = 0
                dtpMonth.Value = datenow
            Case eProcess.eY
                status = 1
                Label1.Text = "Ле"
                dtpMonth.Value = datenow
                dtpMonth.CustomFormat = "yyyy"
        End Select
    End Sub
    Private Sub frmMYSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public str_Date As String = ""
    Public txt_Date As String = ""
    Public str_DateY As String = ""
    Public txt_DateY As String = ""
    Public str_DateM As String = ""
    Public txt_DateM As String = ""
    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        str_Date = ""
        If status = 0 Then
            Dim month As String
            Dim datem As Date = dtpMonth.Value.AddMonths(-1)
            Dim datey As Date = dtpMonth.Value.AddYears(-1)
            If dtpMonth.Value.Month < 10 Then
                month = "0" & dtpMonth.Value.Month
            Else
                month = dtpMonth.Value.Month
            End If
            str_Date = (dtpMonth.Value.Year + 543) & month
            txt_Date = Format(dtpMonth.Value, "MMMM / yyyy")
            If datem.Month < 10 Then
                month = "0" & datem.Month
            Else
                month = datem.Month
            End If
            str_DateM = (datem.Year + 543) & month
            txt_DateM = Format(datem, "MMMM / yyyy")
            If datey.Month < 10 Then
                month = "0" & datey.Month
            Else
                month = datey.Month
            End If
            str_DateY = (datey.Year + 543) & month
            txt_DateY = Format(datey, "MMMM / yyyy")
        Else
            str_Date = dtpMonth.Value.Year + 543
            txt_Date = Format(dtpMonth.Value, "yyyy")
        End If
        'Datenow = dtpMonth.Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class