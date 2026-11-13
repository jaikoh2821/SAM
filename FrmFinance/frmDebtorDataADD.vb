Imports System.Data.SqlClient
Imports DevExpress.XtraSplashScreen

Public Class frmDebtorDataADD
    Dim eEvent As eProcess
    Dim idCusR As Integer = 0
    Dim CusnameR As String = ""
    Dim AmtDebtR As Double = 0.0
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")

    Enum eProcess
        eNew
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal vidCus As Integer, ByVal vCusName As String, ByVal AmtDebt As Double)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eNew
                idCusR = vidCus
                CusnameR = vCusName
                AmtDebtR = AmtDebt
        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmDebtorDataADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblCus.Text = CusnameR
        Me.lblCus.Tag = idCusR
        Me.spEditDebt.Text = AmtDebtR
        Me.dtpBF.Value = frmDebtorData.DateBF

        Me.spEditDebt.Focus()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CDbl(Me.spEditDebt.Text) = 0.0 Then
            MessageBox.Show("กรุณาระบุยอดหนี้ยกมา ให้ถูกต้อง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Check DateBF
        Dim CheckDt As New DataTable
        CheckDt.Clear()
        sCommand.CommandText = "SELECT TOP 1 l.DateBF FROM SmDebtorDataLog l " & vbNewLine &
                               "LEFT OUTER JOIN SmDebtorData d ON l.idDebt = d.idDebt " & vbNewLine &
                               "WHERE l.stBF = 1 AND l.idCus = " & idCusR & " AND d.idComp = " & sIdComp & " ORDER BY l.DATEBF DESC"
        sAdapter.Fill(CheckDt)
        If CheckDt.Rows.Count > 0 Then
            If CDate(dtpBF.Value.ToShortDateString) < CDate(CheckDt.Rows(0).Item("DateBF")) Then
                MessageBox.Show("มีข้อมูลยกยอดหนี้ล่าสุดวันที่ " & CheckDt.Rows(0).Item("DateBF") & vbNewLine &
                                "ระบบไม่สามารถยกยอดหนี้ย้อนหลังได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If


        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        Using myconnection As New SqlConnection(conStr)
            myconnection.Open()
            Dim mycommand As New SqlCommand()
            Dim mytransaction As SqlTransaction
            Dim myAdapter = New SqlDataAdapter(mycommand)

            ' Start a local transaction
            mytransaction = myconnection.BeginTransaction()

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            mycommand.Connection = myconnection
            mycommand.Transaction = mytransaction
            Try

                Dim DateBForward As Date = Convert.ToDateTime(dtpBF.Value, _cultureEnInfo)
                mycommand.CommandText = "exec sp_SmDebtorData " & idCusR & ", 24, 0, " & sIdComp & ", " & CDbl(Me.spEditDebt.Text) & ", " & _
                                        "" & sPsId & ", '" & DateBForward.ToString("yyyy-MM-dd", _cultureEnInfo) & "'"
                mycommand.ExecuteNonQuery()

                'Dim CheckDt As New DataTable
                'Dim idDebtLast As Integer = 0
                'CheckDt.Clear()
                'mycommand.CommandText = "Select idDebt From SmDebtorData WHERE idCus = " & idCusR & " AND idComp = " & sIdComp
                'myAdapter.Fill(CheckDt)
                ''idSaleReturn = sDt.Rows(0).Item("MaxidSaleReturn")

                'If CheckDt.Rows.Count = 0 Then 'ยังไม่พบข้อมูล
                '    Dim query As String = "INSERT INTO SmDebtorData(idCus, idComp, BrForward, DebtBalance) " & _
                '                            "Values(" & idCusR & ", " & sIdComp & ", " & CDbl(Me.spEditDebt.Text) & ", " & CDbl(Me.spEditDebt.Text) & ")"
                '    mycommand.CommandText = query

                '    Dim query2 As String = "Select @@Identity"
                '    mycommand.ExecuteNonQuery()
                '    mycommand.CommandText = query2
                '    idDebtLast = mycommand.ExecuteScalar()
                'Else
                '    mycommand.CommandText = "Update SmDebtorData SET BrForward = " & CDbl(Me.spEditDebt.Text) & ", " & _
                '                            "DebtBalance = " & CDbl(Me.spEditDebt.Text) & " WHERE idDebt = " & CheckDt.Rows(0).Item("idDebt")
                '    mycommand.ExecuteNonQuery()

                '    idDebtLast = CheckDt.Rows(0).Item("idDebt")
                'End If

                ''--- insert Log ---'
                'Dim DateBForward As DateTime = Convert.ToDateTime(dtpBF.Value, _cultureEnInfo)

                'mycommand.CommandText = "INSERT INTO SmDebtorDataLog(idDebt, idCus, idSystem, idTypeTs, AmountTs, " & _
                '                        "BalanceTs, idPsTs, DateTs, stBF, DateBF) " & _
                '                        "Values(" & idDebtLast & ", " & idCusR & ", 24, 0, " & CDbl(Me.spEditDebt.Text) & ", " & _
                '                        "" & CDbl(Me.spEditDebt.Text) & ", " & sPsId & ", GETDATE(), 1, " & _
                '                        "'" & DateBForward.ToString("yyyy-MM-dd", _cultureEnInfo) & "')"
                'mycommand.ExecuteNonQuery()

                'Set Date Default
                frmDebtorData.DateBF = Me.dtpBF.Value

                ' Attempt to commit the transaction.
                mytransaction.Commit()
                SplashScreenManager.CloseForm(False)
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()

            Catch ex As Exception
                ' Attempt to roll back the transaction.
                Try
                    mytransaction.Rollback()
                    SplashScreenManager.CloseForm(False)
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
                                    sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                Catch e2x As Exception
                    SplashScreenManager.CloseForm(False)
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
                                    sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                End Try
            Finally
                myconnection.Close()
            End Try
        End Using


    End Sub

End Class