Imports System.Data.SqlClient
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors

Public Class frmQtTs
    Dim eEvent As eProcess
    Dim idQT As Integer = 0 'ViewData
    Dim idQTxx As Integer = 0 'idQt ครั้งก่อน//case ทำ Qt จากรายการเดิม
    Dim MainDt As New DataTable
    Dim Result As DialogResult
    Private _dt As New DataTable
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")

    Enum eProcess
        eNew
        eviewData
        ' eCancel
        eEdit
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idQT_ As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eNew
                Me.lblDateTs.Text = Date.Today
                Me.lblPsTs.Text = sPsName
                Me.lblPsTs.Tag = sPsId
                Me.dtpQtDateS.Value = Date.Today
                Me.dtpQtDateE.Value = Date.Today
        End Select
        eEvent = aProcess
        idQT = idQT_
    End Sub

    Private Sub frmQtTs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setCmbGroupComp(cmbGroupComp)

        mdCnOpen()
        mdLoadShow()
        SetDatainRpt()
        cmbTps()
        Me.txtPsCus.Tag = 0
        MainDt.Columns.Add("idQtDt", System.Type.GetType("System.Int64"))
        MainDt.Columns.Add("ProductName", System.Type.GetType("System.String"))
        MainDt.Columns.Add("Amt", System.Type.GetType("System.Double"))
        MainDt.Columns.Add("idUnit", System.Type.GetType("System.Int32"))
        MainDt.Columns.Add("PriceBfDis", System.Type.GetType("System.Double"))
        MainDt.Columns.Add("PercDisc", System.Type.GetType("System.Double"))
        MainDt.Columns.Add("BathDisc", System.Type.GetType("System.Double"))
        MainDt.Columns.Add("Price", System.Type.GetType("System.Double"))
        MainDt.Columns.Add("Total", System.Type.GetType("System.Double"))
        MainDt.Columns.Add("Note", System.Type.GetType("System.String"))
        MainDt.Columns.Add("idInvMain", System.Type.GetType("System.Int64"))
        MainDt.Columns.Add("idInvGroup", System.Type.GetType("System.Int32"))
        MainDt.Columns.Add("idSubType", System.Type.GetType("System.Int32"))

        If eEvent <> eProcess.eNew Then
            '------Show SmQtMt----'
            Dim vDt As New DataTable
            vDt.Clear()
            sCommand.CommandText = "Select mt.idComp, mt.QTCode, mt.NumOfQT, mt.NumOfDayQT, " & vbNewLine & _
                                   "FORMAT(mt.DateQTsD, 'd', 'th') As DateQTsD, FORMAT(mt.DateQTeD, 'd', 'th') As DateQTeD," & _
                                   "mt.PaymentQT, mt.idCus, mt.CusName, mt.CusAddress, mt.CusConn, mt.CusConnTel,  " & vbNewLine & _
                                   "mt.idPsQT, p2.PsName as PsQT, mt.stPrice, p1.PsName As PsTs, mt.DateTsD, mt.Note, mt.TotalNet " & vbNewLine & _
                                   "From SmQtMt mt " & _
                                   "LEFT OUTER JOIN vPersonxSelect p1 ON mt.idPsTs = p1.idPs " & _
                                   "LEFT OUTER JOIN vPersonxSelect p2 ON mt.idPsQT = p2.idPs " & vbNewLine & _
                                   "WHERE idQT = " & idQT
            '"LEFT OUTER JOIN vCustomer c ON mt.idCus = c.idCus " & _
            sAdapter.Fill(vDt)

            Me.cmbGroupComp.SelectedValue = vDt.Rows(0).Item("idComp")
            Me.cmbGroupComp.Enabled = False
            Me.lblDocCode.Text = vDt.Rows(0).Item("QTCode")
            Me.lblNumofQT.Text = vDt.Rows(0).Item("NumOfQT")
            Me.txtDayOfQT.Text = vDt.Rows(0).Item("NumOfDayQT")
            Me.dtpQtDateS.Value = vDt.Rows(0).Item("DateQTsD")
            Me.dtpQtDateE.Value = vDt.Rows(0).Item("DateQTeD")
            cmbPayment.SelectedValue = vDt.Rows(0).Item("PaymentQT")
            Me.txtPsCus.Tag = vDt.Rows(0).Item("idCus")
            Me.txtPsCus.Text = vDt.Rows(0).Item("CusName")
            Me.mAddr.Text = vDt.Rows(0).Item("CusAddress")
            Me.txtCusCon.Text = vDt.Rows(0).Item("CusConn")
            Me.txtCusConTel.Text = vDt.Rows(0).Item("CusConnTel")
            Me.lblPsQT.Text = vDt.Rows(0).Item("PsQT")
            Me.lblPsQT.Tag = vDt.Rows(0).Item("idPsQT")
            If vDt.Rows(0).Item("stPrice") = 1 Then
                Me.rdbBill.Checked = True
            ElseIf vDt.Rows(0).Item("stPrice") = 2 Then
                Me.rdbRetail.Checked = True
            ElseIf vDt.Rows(0).Item("stPrice") = 3 Then
                Me.rdbWhole.Checked = True
            End If
            Me.lblDateTs.Text = vDt.Rows(0).Item("DateTsD")
            Me.lblPsTs.Text = vDt.Rows(0).Item("PsTs")
            Me.txtNote.Text = vDt.Rows(0).Item("Note")
            Me.txtTotalNet.Text = Format(vDt.Rows(0).Item("TotalNet"), "#,##0.00")


            '----Show SmQtDt on dgv -----'
            Dim QtOldDt As New DataTable
            QtOldDt.Clear()
            sCommand.CommandText = "SELECT d.idQTDt, d.idQT, d.idInvMain, inv.InvName, d.Amount, u.UnitName, " & _
                                   "d.PriceBfDis, d.DisPerc, d.DisBath, d.Price, (d.Amount * d.Price) As Exp, d.NoteDt, " & vbNewLine & _
                                   "d.idUnit, inv.idInvGroup, inv.idSubType " & vbNewLine & _
                                   "FROM SmQtDt d " & vbNewLine & _
                                   "LEFT OUTER JOIN SmQtMt mt ON d.idQT = mt.idQT " & vbNewLine & _
                                   "LEFT OUTER JOIN dInventoryMain inv ON d.idInvMain = inv.idInvMain " & vbNewLine & _
                                   "LEFT OUTER JOIN dInvUnit u ON d.idUnit = u.idUnit " & vbNewLine & _
                                   "WHERE mt.idQT = " & idQT
            sAdapter.Fill(QtOldDt)

            For i As Integer = 0 To QtOldDt.Rows.Count - 1
                Dim drNew As DataRow = MainDt.NewRow()
                drNew("idQtDt") = QtOldDt.Rows(i).Item("idQTDt")
                drNew("ProductName") = QtOldDt.Rows(i).Item("InvName")
                drNew("Amt") = QtOldDt.Rows(i).Item("Amount") 'จำนวนเสนอราคา
                drNew("idUnit") = QtOldDt.Rows(i).Item("idUnit")
                drNew("PriceBfDis") = QtOldDt.Rows(i).Item("PriceBfDis") 'ราคาปกติ
                drNew("PercDisc") = QtOldDt.Rows(i).Item("DisPerc") 'ส่วนลด %
                drNew("BathDisc") = QtOldDt.Rows(i).Item("DisBath") 'ส่วนลด (บาท)
                drNew("Price") = QtOldDt.Rows(i).Item("Price") 'ราคาขาย
                drNew("Total") = QtOldDt.Rows(i).Item("Exp") 'รวมเป็นเงิน
                drNew("Note") = QtOldDt.Rows(i).Item("NoteDt")
                drNew("idInvMain") = QtOldDt.Rows(i).Item("idInvMain")
                drNew("idInvGroup") = QtOldDt.Rows(i).Item("idInvGroup")
                drNew("idSubType") = QtOldDt.Rows(i).Item("idSubType")

                MainDt.Rows.Add(drNew)
                GcPdQt.DataSource = MainDt

                Dim dt As DataTable = getDataLookup(QtOldDt.Rows(i).Item("idUnit"), QtOldDt.Rows(i).Item("idInvMain"))
                GvPdQt.SetRowCellValue(i, ColUnit.Name, QtOldDt.Rows(i).Item("idUnit"))
                rptUnit.DropDownRows = dt.Rows.Count
            Next

            SumTotalNew()

            If eEvent = eProcess.eviewData Then 'view  // Cancel Or eEvent = eProcess.eCancel
                Me.btnPsQT.Visible = False
                Me.txtDayOfQT.Enabled = False
                Me.dtpQtDateS.Enabled = False
                Me.dtpQtDateE.Enabled = False
                Me.cmbPayment.Enabled = False
                Me.txtNote.Enabled = False
                Me.GroupBox4.Enabled = False
                Me.btnCustomer.Visible = False
                Me.txtPsCus.Enabled = False
                Me.mAddr.Enabled = False
                Me.txtCusCon.Enabled = False
                Me.txtCusConTel.Enabled = False
                Me.btnSave.Visible = False
                Me.btnNewQt.Visible = False
                Me.btnSelectBack.Visible = False
                ColDel.Visible = False

                ColAmount.OptionsColumn.ReadOnly = True
                ColAmount.OptionsColumn.AllowEdit = False
                ColUnit.OptionsColumn.ReadOnly = True
                ColUnit.OptionsColumn.AllowEdit = False
                ColPriceBfDis.OptionsColumn.ReadOnly = True
                ColPriceBfDis.OptionsColumn.AllowEdit = False
                ColPercDiscount.OptionsColumn.ReadOnly = True
                ColPercDiscount.OptionsColumn.AllowEdit = False
                ColBathDiscount.OptionsColumn.ReadOnly = True
                ColBathDiscount.OptionsColumn.AllowEdit = False
                ColPrice.OptionsColumn.ReadOnly = True
                ColPrice.OptionsColumn.AllowEdit = False
                ColNote.OptionsColumn.ReadOnly = True
                ColNote.OptionsColumn.AllowEdit = False
            End If

        End If
        mdLoadCommitt()
    End Sub

    Private Sub SetDatainRpt()
        sCommand.CommandText = "SELECT unit.idUnit, unit.UnitName " & vbNewLine & _
                               "FROM  dInvUnit unit " & _
                               "WHERE stDel IS NULL "
        sAdapter.Fill(_dt)

        rptUnit.Columns.Clear()
        rptUnit.Columns.Add(New LookUpColumnInfo("UnitName"))
        rptUnit.DataSource = _dt

        rptUnit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub cmbTps()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select * From SmPaymentTermsD"
        sAdapter.Fill(sDt)
        With cmbPayment
            .DisplayMember = "PaymentTerms"
            .ValueMember = "idPM"
            .DataSource = sDt
        End With
    End Sub


    Private Sub btnPsQT_Click(sender As Object, e As EventArgs) Handles btnPsQT.Click
        Dim vFrm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPsQT.Tag = vFrm.mId
            Me.lblPsQT.Text = vFrm.mName
        End If
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelect, cmbGroupComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            MainDt.Rows.Clear()
            MainDt.AcceptChanges()
            GvPdQt.RefreshData()
            txtTotalNet.Text = "0"

            Me.lblNumofQT.Text = "1"
            Me.txtPsCus.Tag = vFrm.idCus
            Me.txtPsCus.Text = vFrm.CusName
            Me.mAddr.Text = vFrm.AddressS
            Me.txtCusCon.Text = vFrm.CusNameCon
            Me.txtCusConTel.Text = vFrm.MobileCon

            mdCnOpen()
            Dim dt As New DataTable
            dt.Clear()
            sCommand.CommandText = "Select idPM From SmMkCusPs " & _
                                   "Where idComp = " & Me.cmbGroupComp.SelectedValue & " AND idCus =" & vFrm.idCus
            sAdapter.Fill(dt)

            If dt.Rows.Count <> 0 Then
                Me.cmbPayment.SelectedValue = dt.Rows(0).Item("idPM")
            Else
                Me.cmbPayment.SelectedValue = 49 'Default credit 30 days
            End If
        End If
    End Sub

    Private Sub txtPsCus_EditValueChanged(sender As Object, e As EventArgs) Handles txtPsCus.EditValueChanged
        If Me.txtPsCus.Text.Trim = "" Then
            Me.txtPsCus.Tag = 0
            Me.lblNumofQT.Text = "1"

            MainDt.Rows.Clear()
            MainDt.AcceptChanges()
            GvPdQt.RefreshData()
            txtTotalNet.Text = "0"
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Me.txtDayOfQT.Text = "" Then
            MessageBox.Show("กรุณากรอกจำนวนวันที่ยื่นราคา", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            Me.txtDayOfQT.Focus()
            Exit Sub
        ElseIf Me.lblPsQT.Text = "" Then
            MessageBox.Show("กรุณาระบุผู้เสนอราคา", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            btnPsQT.Focus()
            Exit Sub
        ElseIf Me.txtPsCus.Text = "" Then
            MessageBox.Show("กรุณาระบุลุกค้า", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            txtPsCus.Focus()
            Exit Sub
        ElseIf Me.GvPdQt.RowCount = 0 Then
            MessageBox.Show("กรุณาเลือกรายการเสนอราคาอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            Exit Sub
        Else
            For i As Integer = 0 To GvPdQt.RowCount - 1
                If GvPdQt.GetDataRow(i).Item("Amt") = 0 Then
                    MessageBox.Show("กรุณาระบุจำนวนให้ถูกต้อง", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Next

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

                    If eEvent = eProcess.eNew Then 'NewData   
                        AddSmQtMt(mycommand)
                    Else 'EditData
                        UpdateSmQtMt(mycommand)
                    End If

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

        End If
    End Sub

    Sub AddSmQtMt(ByVal vCommand As SqlCommand)
        Dim getDate As String = CType(Date.Today, String)
        Dim Prefixcode As String = (Microsoft.VisualBasic.Right(getDate, 2))
        Dim QTCode As String = ""
        Dim stPrice As Integer = 0

        If Me.rdbWhole.Checked = True Then
            stPrice = "3"
        ElseIf Me.rdbRetail.Checked = True Then
            stPrice = "2"
        ElseIf Me.rdbBill.Checked = True Then
            stPrice = "1"
        End If

        Dim dtpQtDateSD As DateTime = Convert.ToDateTime(dtpQtDateS.Value, _cultureEnInfo)
        Dim dtpQtDateED As DateTime = Convert.ToDateTime(dtpQtDateE.Value, _cultureEnInfo)
        QTCode = getQTCode(Prefixcode)
        Dim query As String = "Insert Into SmQtMt(QTCode, NumOfQT, NumOfDayQT, DateQtsD, DateQteD, PaymentQT, idCus, " & vbNewLine & _
                              "CusName, CusAddress, CusConn, CusConnTel, idPsQT, stPrice, idPsTs, DateTsD, TotalNet, Note, idComp) " & vbNewLine & _
                               "Values('" & QTCode & "', " & CInt(lblNumofQT.Text) & ", " & CInt(Me.txtDayOfQT.Text) & ", " & vbNewLine & _
                               "'" & dtpQtDateSD.ToString("yyyy-MM-dd", _cultureEnInfo) & "', " & _
                               "'" & dtpQtDateED.ToString("yyyy-MM-dd", _cultureEnInfo) & "', " & _
                               "" & Me.cmbPayment.SelectedValue & ", " & Me.txtPsCus.Tag & ", '" & txtPsCus.Text.Trim & "', " & vbNewLine & _
                               "'" & mAddr.Text.Trim & "', '" & txtCusCon.Text.Trim & "', '" & txtCusConTel.Text.Trim & "'," & Me.lblPsQT.Tag & ",  " & _
                               "" & stPrice & ", " & sPsId & ", GETDATE(), " & CDbl(Me.txtTotalNet.Text) & ", " & _
                               "'" & Trim(Me.txtNote.Text) & "', " & Me.cmbGroupComp.SelectedValue & ")"
        vCommand.CommandText = query

        Dim query2 As String = "Select @@Identity"
        vCommand.ExecuteNonQuery()
        vCommand.CommandText = query2
        idQT = vCommand.ExecuteScalar()

        '----ADD Data to SmQtDt-----'
        AddSmQtDt(idQT, vCommand)
    End Sub

    Sub AddSmQtDt(ByVal idQT As Integer, ByVal xCommand As SqlCommand)
        '---insert SmQtDt Table---'
        For i As Integer = 0 To GvPdQt.RowCount - 1
            xCommand.CommandText = "Insert Into SmQtDt(idQT, idInvMain, Amount, idUnit, PriceBfDis, DisPerc, DisBath, Price, NoteDt) " & _
                                   "Values(" & idQT & ", " & CInt(GvPdQt.GetDataRow(i).Item("idInvMain")) & ", " & _
                                   "" & CDbl(GvPdQt.GetDataRow(i).Item("Amt")) & ", " & _
                                   "" & CInt(GvPdQt.GetDataRow(i).Item("idUnit")) & ", " & _
                                   "" & CDbl(GvPdQt.GetDataRow(i).Item("PriceBfDis")) & ", " & _
                                   "" & CDbl(GvPdQt.GetDataRow(i).Item("PercDisc")) & ", " & _
                                   "" & CDbl(GvPdQt.GetDataRow(i).Item("BathDisc")) & ", " & _
                                   "" & CDbl(GvPdQt.GetDataRow(i).Item("Price")) & ", " & _
                                   "'" & GvPdQt.GetDataRow(i).Item("Note") & "')"
            xCommand.ExecuteNonQuery()
        Next
    End Sub

    Sub UpdateSmQtMt(ByVal vCommand As SqlCommand)
        Dim stPrice As Integer = 0
        If Me.rdbWhole.Checked = True Then
            stPrice = "3"
        ElseIf Me.rdbRetail.Checked = True Then
            stPrice = "2"
        ElseIf Me.rdbBill.Checked = True Then
            stPrice = "1"
        End If

        Dim dtpQtDateSD As DateTime = Convert.ToDateTime(dtpQtDateS.Value, _cultureEnInfo)
        Dim dtpQtDateED As DateTime = Convert.ToDateTime(dtpQtDateE.Value, _cultureEnInfo)
        '---Update SmSaleMt Table---'
        vCommand.CommandText = "UPDATE SmQtMt SET NumOfDayQT = " & CInt(Me.txtDayOfQT.Text) & ", " & _
                               "DateQTsD = '" & dtpQtDateSD.ToString("yyyy-MM-dd", _cultureEnInfo) & "', " & _
                               "DateQTeD = '" & dtpQtDateED.ToString("yyyy-MM-dd", _cultureEnInfo) & "', " & _
                               "PaymentQT = " & Me.cmbPayment.SelectedValue & ", idCus = " & txtPsCus.Tag & ", " & vbNewLine & _
                               "CusName = '" & txtPsCus.Text.Trim & "', CusAddress = '" & mAddr.Text.Trim & "', " & vbNewLine & _
                               "CusConn = '" & txtCusCon.Text.Trim & "', CusConnTel = '" & txtCusConTel.Text.Trim & "', " & vbNewLine & _
                               "idPsQt ='" & Me.lblPsQT.Tag & "',  stPrice = " & stPrice & ", idPsTs = " & sPsId & ", DateTsD = GETDATE(),  " & _
                               "TotalNet = " & CDbl(Me.txtTotalNet.Text) & ", Note = '" & txtNote.Text & "' " & _
                               "WHERE idQT = " & idQT
        vCommand.ExecuteNonQuery()
        UpdateSmQtDt(vCommand)
    End Sub

    Sub UpdateSmQtDt(ByVal xCommand As SqlCommand)
        Dim dv As New DataView(MainDt)

        'Old-Dt >>> Update
        Dim StridQtDt As String = ""
        dv.RowFilter = "idQtDt <> 0"
        For i As Integer = 0 To dv.Count - 1
            StridQtDt &= dv.Item(i).Item("idQtDt") & ","
            xCommand.CommandText = "UPDATE SmQtDt SET Amount = " & CDbl(dv.Item(i).Item("Amt")) & ", " & vbNewLine & _
                                   "idUnit = " & CInt(dv.Item(i).Item("idUnit")) & ", " & vbNewLine & _
                                   "PriceBfDis = " & CDbl(dv.Item(i).Item("PriceBfDis")) & ", " & vbNewLine & _
                                   "DisPerc = " & CDbl(dv.Item(i).Item("PercDisc")) & ", " & vbNewLine & _
                                   "DisBath = " & CDbl(dv.Item(i).Item("BathDisc")) & ", " & vbNewLine & _
                                   "Price = " & CDbl(dv.Item(i).Item("Price")) & ", " & vbNewLine & _
                                   "NoteDt = '" & dv.Item(i).Item("Note") & "'" & vbNewLine & _
                                   "WHERE idQtDt = " & dv.Item(i).Item("idQtDt")
            xCommand.ExecuteNonQuery()
        Next

        'Old-Dt >>> Delete
        Dim WHERExDel As String = ""
        If StridQtDt <> "" Then
            WHERExDel = " AND idQtDt NOT IN (" & StridQtDt.Substring(0, StridQtDt.Length - 1) & ")"

        End If


        xCommand.CommandText = "Delete SmQtDt Where idQT =  " & idQT & WHERExDel
        xCommand.ExecuteNonQuery()

        'New-Dt >>> Insert
        dv.RowFilter = "idQtDt = 0"
        For i As Integer = 0 To dv.Count - 1
            xCommand.CommandText = "Insert Into SmQtDt(idQT, idInvMain, Amount, idUnit, PriceBfDis, DisPerc, DisBath, Price, NoteDt) " & _
                                  "Values(" & idQT & ", " & CInt(dv.Item(i).Item("idInvMain")) & ", " & _
                                  "" & CDbl(dv.Item(i).Item("Amt")) & ", " & _
                                  "" & CInt(dv.Item(i).Item("idUnit")) & ", " & _
                                  "" & CDbl(dv.Item(i).Item("PriceBfDis")) & ", " & _
                                  "" & CDbl(dv.Item(i).Item("PercDisc")) & ", " & _
                                  "" & CDbl(dv.Item(i).Item("BathDisc")) & ", " & _
                                  "" & CDbl(dv.Item(i).Item("Price")) & ", " & _
                                  "'" & dv.Item(i).Item("Note") & "')"
            xCommand.ExecuteNonQuery()
        Next

        '  AddSmQtDt(idQT, xCommand)
    End Sub

    '-------------------- GEN DocNum --------------------'
    Function getQTCode(ByVal Prefixcode As String) As String
        Dim DocNum As String = ""
        Dim nextOrder As String = ""

        mdCnOpen()
        Dim sDt As New DataTable
        sDs.Tables.Clear()
        sCommand.CommandText = "SELECT MAX(QTCode) as max_QTCode FROM SmQtMt"
        sAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_QTCode")) = True Then
            DocNum = "QT" & Prefixcode & "00001"
        Else
            Dim max_QTCode As String = sDt.Rows(0).Item("max_QTCode")
            Dim yearDoc As String = sDt.Rows(0).Item("max_QTCode").ToString.Substring(2, 2)
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_QTCode"), 5)

            If Prefixcode <> yearDoc Then
                DocNum = "QT" & Prefixcode & "00001"
            Else
                Dim temp As Integer
                temp = CInt(RunningCode) + 1
                If temp < 10 Then
                    nextOrder = "0000" & CStr(temp)
                ElseIf temp < 100 Then
                    nextOrder = "000" & CStr(temp)
                ElseIf temp < 1000 Then
                    nextOrder = "00" & CStr(temp)
                ElseIf temp < 10000 Then
                    nextOrder = "0" & CStr(temp)
                Else
                    nextOrder = CStr(temp)
                End If
                DocNum = "QT" & Prefixcode & nextOrder
            End If
        End If
        Return DocNum
    End Function

    Private Sub btnNewQt_Click(sender As Object, e As EventArgs) Handles btnNewQt.Click
        If Me.txtPsCus.Text = "" Then
            MessageBox.Show("กรุณระบุลูกค้าก่อน เลือกรายการสินค้า", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim vFrm As New frmAllInvSelect(frmAllInvSelect.eProcess.eMaltiSelect, cmbGroupComp.SelectedValue)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            For i As Integer = 0 To vFrm.sdt1.Rows.Count - 1
                Dim SetPrice As Double = 0.0
                Select Case vFrm.sdt1.Rows(i).Item("idInvGroup")
                    Case 2 'FG
                        If Me.rdbWhole.Checked = True Then
                            SetPrice = vFrm.sdt1.Rows(i).Item("PriceBill_fg")
                        ElseIf Me.rdbRetail.Checked = True Then
                            SetPrice = vFrm.sdt1.Rows(i).Item("PriceRetail_fg")
                        ElseIf Me.rdbBill.Checked = True Then
                            SetPrice = vFrm.sdt1.Rows(i).Item("PriceWholesale_fg")
                        End If
                    Case 3, 28, 33, 36, 37, 38, 39 'เบ็ดเตล็ด/Hormaone/Fresh/ปุ๋ย/ยา/สารขับใข/อุปกรณ์เกษตร
                        SetPrice = vFrm.sdt1.Rows(i).Item("PricePdo_pdo")
                    Case 29 'Plastic
                        If Me.cmbPayment.SelectedValue = 49 Then 'credit 30
                            SetPrice = vFrm.sdt1.Rows(i).Item("CreditThirty_pdo")
                        ElseIf Me.cmbPayment.SelectedValue = 50 Then 'credit 60
                            SetPrice = vFrm.sdt1.Rows(i).Item("CreditSixty_pdo")
                        Else 'Other
                            SetPrice = vFrm.sdt1.Rows(i).Item("PricePdo_pdo")
                        End If
                    Case 42 'เมล็ดดอกไม้บรรจุซอง
                        SetPrice = vFrm.sdt1.Rows(i).Item("PriceSeedFg_sfg")
                End Select

                Dim drNew As DataRow = MainDt.NewRow()
                drNew("idQtDt") = 0
                drNew("ProductName") = vFrm.sdt1.Rows(i).Item("InvName")
                drNew("Amt") = 1 'จำนวนเสนอราคา
                drNew("idUnit") = vFrm.sdt1.Rows(i).Item("idUnit")
                drNew("PriceBfDis") = SetPrice 'ราคาปกติ
                drNew("PercDisc") = 0.0 'ส่วนลด %
                drNew("BathDisc") = 0.0 'ส่วนลด (บาท)
                drNew("Price") = SetPrice 'ราคาขาย
                drNew("Total") = SetPrice 'รวมเป็นเงิน
                drNew("Note") = ""
                drNew("idInvMain") = vFrm.sdt1.Rows(i).Item("idInvMain")
                drNew("idInvGroup") = vFrm.sdt1.Rows(i).Item("idInvGroup")
                drNew("idSubType") = vFrm.sdt1.Rows(i).Item("idSubType")

                MainDt.Rows.Add(drNew)
                GcPdQt.DataSource = MainDt

                Dim dt As DataTable = getDataLookup(vFrm.sdt1.Rows(i).Item("idUnit"), vFrm.sdt1.Rows(i).Item("idInvMain"))
                GvPdQt.SetRowCellValue(i, ColUnit.Name, vFrm.sdt1.Rows(i).Item("idUnit"))
                rptUnit.DropDownRows = dt.Rows.Count
            Next
            SumTotalNew()
        End If
    End Sub

    Private Sub GvPdQt_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GvPdQt.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub GvPdQt_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvPdQt.CellValueChanged
        Dim dr As DataRow = GvPdQt.GetDataRow(GvPdQt.FocusedRowHandle)

        'Amount/price Change
        If e.Column.Name = ColAmount.Name Or e.Column.Name = ColPriceBfDis.Name Then
            SumcolAmountExpNewGrid()
        End If

        'PriceSale
        If e.Column.Name = ColPrice.Name Then
            'If IsDBNull(dr.Item("Price")) Then
            '    dr.Item("Price") = 0.0
            'End If

            If dr.Item("PriceBfDis") = 0 Then
                dr.Item("PriceBfDis") = dr.Item("Price")
            End If

            SumcolAmountExpNewGrid()
        End If

        'Discount %
        If e.Column.Name = ColPercDiscount.Name Then
            'If IsDBNull(dr.Item("PercDisc")) Then
            '    dr.Item("PercDisc") = 0.0
            'End If

            If dr.Item("PercDisc") > 100 Then
                MessageBox.Show("จำนวนส่วนลดเกิน 100% ไม่ได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dr.Item("PercDisc") = 0.0
            Else
                If dr.Item("PercDisc") <> 0.0 Then
                    dr.Item("BathDisc") = 0.0
                End If
            End If
            dr.Item("PercDisc") = Format(CDbl(dr.Item("PercDisc")), "#,##0.00")
            SumcolAmountExpNewGrid()
        End If

        'Discount Bath
        If e.Column.Name = ColBathDiscount.Name Then
            If dr.Item("BathDisc") > dr.Item("PriceBfDis") Then
                MessageBox.Show("จำนวนส่วนลดมากกว่าราคาปกติไม่ได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dr.Item("BathDisc") = 0.0
            End If

            dr.Item("BathDisc") = Format(CDbl(dr.Item("BathDisc")), "#,##0.00")
            If dr.Item("BathDisc") <> 0.0 Then
                dr.Item("PercDisc") = 0.0
            End If

            SumcolAmountExpNewGrid()
        End If
    End Sub

    Private Sub SumcolAmountExpNewGrid()
        Dim dr As DataRow = GvPdQt.GetDataRow(GvPdQt.FocusedRowHandle)

        '------------Calculate ส่วนลด (%)------------
        If CDbl(GvPdQt.GetFocusedRowCellValue(ColPercDiscount)) = 0.0 Then
            dr.Item("Price") = GvPdQt.GetFocusedRowCellValue(ColPriceBfDis)
        ElseIf CDbl(GvPdQt.GetFocusedRowCellValue(ColPercDiscount)) > 0.0 Then
            dr.Item("Price") = GvPdQt.GetFocusedRowCellValue(ColPriceBfDis) - (GvPdQt.GetFocusedRowCellValue(ColPriceBfDis) * GvPdQt.GetFocusedRowCellValue(ColPercDiscount)) / 100
        Else 'ส่วนลดติดลย
            dr.Item("PercDisc") = 0.0
            dr.Item("Price") = GvPdQt.GetFocusedRowCellValue(ColPriceBfDis)
        End If

        '------------Calculate ส่วนลด (Bath)------------
        If CDbl(GvPdQt.GetFocusedRowCellValue(ColBathDiscount)) > 0.0 Then
            dr.Item("Price") = GvPdQt.GetFocusedRowCellValue(ColPriceBfDis) - GvPdQt.GetFocusedRowCellValue(ColBathDiscount)
        Else
            dr.Item("BathDisc") = 0.0
            If dr.Item("PercDisc") = 0.0 Then
                dr.Item("Price") = GvPdQt.GetFocusedRowCellValue(ColPriceBfDis)
            End If
        End If

        dr.Item("Total") = GvPdQt.GetFocusedRowCellValue(ColPrice) * GvPdQt.GetFocusedRowCellValue("Amt")
        dr.Item("Price") = Format(CDbl(GvPdQt.GetFocusedRowCellValue(ColPrice)), "#,##0.00##")
        dr.Item("PriceBfDis") = Format(CDbl(GvPdQt.GetFocusedRowCellValue(ColPriceBfDis)), "#,##0.00##")
        dr.Item("Total") = Format(CDbl(GvPdQt.GetFocusedRowCellValue(ColExp)), "#,##0.00##")

        SumTotalNew()
    End Sub

    Private Sub SumTotalNew()
        Dim Total As Double = 0.0
        For i As Integer = 0 To GvPdQt.RowCount - 1
            Total += GvPdQt.GetDataRow(i).Item("Total")
        Next

        txtTotalNet.Text = Format(Total, "#,##0.00##")
    End Sub

    Private Sub rdbBill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbBill.CheckedChanged
        If Me.rdbBill.Checked = True Then
            mdCnOpen()
            For i As Integer = 0 To GvPdQt.RowCount - 1
                If GvPdQt.GetDataRow(i).Item("idInvGroup") = 2 Then 'สินค้า FG
                    Dim dt As New DataTable
                    dt.Clear()
                    sCommand.CommandText = "Select PriceBill From dPackingPdSet Where idPdPk = " & GvPdQt.GetDataRow(i).Item("idSubType")
                    sAdapter.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        GvPdQt.GetDataRow(i).Item("PriceBfDis") = dt.Rows(0).Item("PriceBill")

                        '----- Check ส่วนลด  ------'
                        If GvPdQt.GetDataRow(i).Item("PercDisc") > 0 Then 'ส่วนลด %
                            GvPdQt.GetDataRow(i).Item("BathDisc") = 0
                            GvPdQt.GetDataRow(i).Item("Price") = GvPdQt.GetDataRow(i).Item("PriceBfDis") - (GvPdQt.GetDataRow(i).Item("PriceBfDis") * GvPdQt.GetDataRow(i).Item("PercDisc")) / 100
                        ElseIf GvPdQt.GetDataRow(i).Item("BathDisc") > 0 Then ' ส่วนลด บาท
                            GvPdQt.GetDataRow(i).Item("PercDisc") = 0
                            GvPdQt.GetDataRow(i).Item("Price") = GvPdQt.GetDataRow(i).Item("PriceBfDis") - GvPdQt.GetDataRow(i).Item("BathDisc")
                        Else 'ไม่มีส่วนลด
                            GvPdQt.GetDataRow(i).Item("Price") = GvPdQt.GetDataRow(i).Item("PriceBfDis")
                        End If

                        GvPdQt.GetDataRow(i).Item("Total") = GvPdQt.GetDataRow(i).Item("Price") * GvPdQt.GetDataRow(i).Item("Amt")
                    End If
                End If
            Next

            SumTotalNew()
        End If 'End rdbbill Check
    End Sub

    Private Sub rdbWhole_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbWhole.CheckedChanged
        If Me.rdbWhole.Checked = True Then
            mdCnOpen()
            For i As Integer = 0 To GvPdQt.RowCount - 1
                If GvPdQt.GetDataRow(i).Item("idInvGroup") = 2 Then 'สินค้า FG
                    Dim dt As New DataTable
                    dt.Clear()
                    sCommand.CommandText = "Select PriceWholesale From dPackingPdSet Where idPdPk = " & GvPdQt.GetDataRow(i).Item("idSubType")
                    sAdapter.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        GvPdQt.GetDataRow(i).Item("PriceBfDis") = dt.Rows(0).Item("PriceWholesale")
                        
                        '----- Check ส่วนลด  ------'
                        If GvPdQt.GetDataRow(i).Item("PercDisc") > 0 Then 'ส่วนลด %
                            GvPdQt.GetDataRow(i).Item("BathDisc") = 0
                            GvPdQt.GetDataRow(i).Item("Price") = GvPdQt.GetDataRow(i).Item("PriceBfDis") - (GvPdQt.GetDataRow(i).Item("PriceBfDis") * GvPdQt.GetDataRow(i).Item("PercDisc")) / 100
                        ElseIf GvPdQt.GetDataRow(i).Item("BathDisc") > 0 Then ' ส่วนลด บาท
                            GvPdQt.GetDataRow(i).Item("PercDisc") = 0
                            GvPdQt.GetDataRow(i).Item("Price") = GvPdQt.GetDataRow(i).Item("PriceBfDis") - GvPdQt.GetDataRow(i).Item("BathDisc")
                        Else 'ไม่มีส่วนลด
                            GvPdQt.GetDataRow(i).Item("Price") = GvPdQt.GetDataRow(i).Item("PriceBfDis")
                        End If

                        GvPdQt.GetDataRow(i).Item("Total") = GvPdQt.GetDataRow(i).Item("Price") * GvPdQt.GetDataRow(i).Item("Amt")
                    End If
                End If
            Next

            SumTotalNew()
        End If 'End rdbwhole Check
    End Sub

    Private Sub rdbRetail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbRetail.CheckedChanged
        If Me.rdbRetail.Checked = True Then
            mdCnOpen()
            For i As Integer = 0 To GvPdQt.RowCount - 1
                If GvPdQt.GetDataRow(i).Item("idInvGroup") = 2 Then 'สินค้า FG
                    Dim dt As New DataTable
                    dt.Clear()
                    sCommand.CommandText = "Select PriceRetail From dPackingPdSet Where idPdPk = " & GvPdQt.GetDataRow(i).Item("idSubType")
                    sAdapter.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        GvPdQt.GetDataRow(i).Item("PriceBfDis") = dt.Rows(0).Item("PriceRetail")

                        '----- Check ส่วนลด  ------'
                        If GvPdQt.GetDataRow(i).Item("PercDisc") > 0 Then 'ส่วนลด %
                            GvPdQt.GetDataRow(i).Item("BathDisc") = 0
                            GvPdQt.GetDataRow(i).Item("Price") = GvPdQt.GetDataRow(i).Item("PriceBfDis") - (GvPdQt.GetDataRow(i).Item("PriceBfDis") * GvPdQt.GetDataRow(i).Item("PercDisc")) / 100
                        ElseIf GvPdQt.GetDataRow(i).Item("BathDisc") > 0 Then ' ส่วนลด บาท
                            GvPdQt.GetDataRow(i).Item("PercDisc") = 0
                            GvPdQt.GetDataRow(i).Item("Price") = GvPdQt.GetDataRow(i).Item("PriceBfDis") - GvPdQt.GetDataRow(i).Item("BathDisc")
                        Else 'ไม่มีส่วนลด
                            GvPdQt.GetDataRow(i).Item("Price") = GvPdQt.GetDataRow(i).Item("PriceBfDis")
                        End If

                        GvPdQt.GetDataRow(i).Item("Total") = GvPdQt.GetDataRow(i).Item("Price") * GvPdQt.GetDataRow(i).Item("Amt")
                    End If
                End If
            Next
            SumTotalNew()
        End If
    End Sub

    Private Sub cmbPayment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPayment.SelectedIndexChanged
        Dim vField As String = ""
        If Me.cmbPayment.SelectedValue = 49 Then 'credit 30
            vField = "CreditThirty"
        ElseIf Me.cmbPayment.SelectedValue = 50 Then 'credit 60
            vField = "CreditSixty"
        Else 'Other
            vField = "Price"
        End If

        mdCnOpen()
        For i As Integer = 0 To GvPdQt.RowCount - 1
            If GvPdQt.GetDataRow(i).Item("idInvGroup") = 29 Then 'สินค้า Plastic
                Dim PriceTempDt As New DataTable
                PriceTempDt.Clear()
                sCommand.CommandText = "SELECT ISNULL(" & vField & ", 0.00) As PdoxPrice FROM SmPdOtherD WHERE idPdO = " & GvPdQt.GetDataRow(i).Item("idSubType")
                sAdapter.Fill(PriceTempDt)

                GvPdQt.GetDataRow(i).Item("PriceBfDis") = PriceTempDt.Rows(0).Item("PdoxPrice")
                '----- Check ส่วนลด  ------'
                If GvPdQt.GetDataRow(i).Item("PercDisc") > 0 Then 'ส่วนลด %
                    GvPdQt.GetDataRow(i).Item("BathDisc") = 0
                    GvPdQt.GetDataRow(i).Item("Price") = GvPdQt.GetDataRow(i).Item("PriceBfDis") - (GvPdQt.GetDataRow(i).Item("PriceBfDis") * GvPdQt.GetDataRow(i).Item("PercDisc")) / 100
                ElseIf GvPdQt.GetDataRow(i).Item("BathDisc") > 0 Then ' ส่วนลด บาท
                    GvPdQt.GetDataRow(i).Item("PercDisc") = 0
                    GvPdQt.GetDataRow(i).Item("Price") = GvPdQt.GetDataRow(i).Item("PriceBfDis") - GvPdQt.GetDataRow(i).Item("BathDisc")
                Else 'ไม่มีส่วนลด
                    GvPdQt.GetDataRow(i).Item("Price") = GvPdQt.GetDataRow(i).Item("PriceBfDis")
                End If
                GvPdQt.GetDataRow(i).Item("Total") = GvPdQt.GetDataRow(i).Item("Price") * GvPdQt.GetDataRow(i).Item("Amt")
            End If
        Next
    End Sub

    Private Sub txtDayOfQT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDayOfQT.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> ".") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtDayOfQT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDayOfQT.TextChanged
        If Me.txtDayOfQT.Text <> "0" Then
            Dim DateQTs As Date = dtpQtDateS.Value
            Me.dtpQtDateE.Value = DateQTs.AddDays(CInt(Me.txtDayOfQT.Text))
        End If
    End Sub

    Private Sub dtpQtDateS_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpQtDateS.ValueChanged
        If Me.txtDayOfQT.Text <> "0" Then
            Dim DateQTs As Date = dtpQtDateS.Value
            Me.dtpQtDateE.Value = DateQTs.AddDays(CInt(Me.txtDayOfQT.Text))
        End If
    End Sub

    Private Sub rptDel_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptDel.ButtonClick
        If lbrMsg.MsgQuestion("คุณต้องการลบรายการใช่หรือไม่?") = True Then
            Dim dr As DataRow = GvPdQt.GetDataRow(GvPdQt.FocusedRowHandle)
            dr.Delete()

            MainDt.AcceptChanges()
            SumTotalNew()
        End If
    End Sub

    Private Sub btnSelectBack_Click(sender As Object, e As EventArgs) Handles btnSelectBack.Click
        'If Me.txtPsCus.Text = "" Then
        '    MessageBox.Show("กรุณาระบุลูกค้า ก่อนทำการเลือกใบเสนอราคาครั้งก่อน", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        '    Exit Sub
        'End If

        Dim vFrm As New frmQtData(frmQtData.eProcess.eSelect, Me.txtPsCus.Tag, Me.txtPsCus.Text.Trim, Me.cmbGroupComp.SelectedValue, idQT)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            idQTxx = vFrm.MasterDt.Rows(0).Item("idQT")
            lblNumofQT.Text = CInt(vFrm.MasterDt.Rows(0).Item("NumOfQT")) + 1
            cmbPayment.SelectedValue = vFrm.MasterDt.Rows(0).Item("PaymentQT")
            txtPsCus.Text = vFrm.MasterDt.Rows(0).Item("CusName")
            mAddr.Text = vFrm.MasterDt.Rows(0).Item("CusAddress")
            txtCusCon.Text = vFrm.MasterDt.Rows(0).Item("CusConn")
            txtCusConTel.Text = vFrm.MasterDt.Rows(0).Item("CusConnTel")
            lblPsQT.Text = vFrm.MasterDt.Rows(0).Item("PsQT")
            lblPsQT.Tag = vFrm.MasterDt.Rows(0).Item("idPsQT")
            If vFrm.MasterDt.Rows(0).Item("stPrice") = 1 Then
                Me.rdbBill.Checked = True
            ElseIf vFrm.MasterDt.Rows(0).Item("stPrice") = 2 Then
                Me.rdbRetail.Checked = True
            ElseIf vFrm.MasterDt.Rows(0).Item("stPrice") = 3 Then
                Me.rdbWhole.Checked = True
            End If

            'Set list Detail
            MainDt.Rows.Clear()
            Dim QtOldDt As New DataTable
            QtOldDt.Clear()
            sCommand.CommandText = "SELECT d.idQTDt, d.idQT, d.idInvMain, inv.InvName, d.Amount, u.UnitName, " & _
                                   "d.PriceBfDis, d.DisPerc, d.DisBath, d.Price, (d.Amount * d.Price) As Exp, d.NoteDt, " & vbNewLine & _
                                   "d.idUnit, inv.idInvGroup, inv.idSubType " & vbNewLine & _
                                   "FROM SmQtDt d " & vbNewLine & _
                                   "LEFT OUTER JOIN SmQtMt mt ON d.idQT = mt.idQT " & vbNewLine & _
                                   "LEFT OUTER JOIN dInventoryMain inv ON d.idInvMain = inv.idInvMain " & vbNewLine & _
                                   "LEFT OUTER JOIN dInvUnit u ON d.idUnit = u.idUnit " & vbNewLine & _
                                   "WHERE mt.idQT = " & vFrm.MasterDt.Rows(0).Item("idQT")
            sAdapter.Fill(QtOldDt)

            For i As Integer = 0 To QtOldDt.Rows.Count - 1
                Dim drNew As DataRow = MainDt.NewRow()
                drNew("idQtDt") = 0
                drNew("ProductName") = QtOldDt.Rows(i).Item("InvName")
                drNew("Amt") = QtOldDt.Rows(i).Item("Amount") 'จำนวนเสนอราคา
                drNew("idUnit") = QtOldDt.Rows(i).Item("idUnit")
                drNew("PriceBfDis") = QtOldDt.Rows(i).Item("PriceBfDis") 'ราคาปกติ
                drNew("PercDisc") = QtOldDt.Rows(i).Item("DisPerc") 'ส่วนลด %
                drNew("BathDisc") = QtOldDt.Rows(i).Item("DisBath") 'ส่วนลด (บาท)
                drNew("Price") = QtOldDt.Rows(i).Item("Price") 'ราคาขาย
                drNew("Total") = QtOldDt.Rows(i).Item("Exp") 'รวมเป็นเงิน
                drNew("Note") = QtOldDt.Rows(i).Item("NoteDt")
                drNew("idInvMain") = QtOldDt.Rows(i).Item("idInvMain")
                drNew("idInvGroup") = QtOldDt.Rows(i).Item("idInvGroup")
                drNew("idSubType") = QtOldDt.Rows(i).Item("idSubType")

                MainDt.Rows.Add(drNew)
                GcPdQt.DataSource = MainDt

                Dim dt As DataTable = getDataLookup(QtOldDt.Rows(i).Item("idUnit"), QtOldDt.Rows(i).Item("idInvMain"))
                GvPdQt.SetRowCellValue(i, ColUnit.Name, QtOldDt.Rows(i).Item("idUnit"))
                rptUnit.DropDownRows = dt.Rows.Count
            Next
            SumTotalNew()
        End If
    End Sub

    Private Function getDataLookup(ByVal idUnit As Integer, ByVal idInvMain As Integer) As DataTable
        Dim dtS As DataTable = _dt.Clone
        Dim drs() As DataRow
        Dim StrUnit As String = ""

        mdCnOpen()
        Dim temp_ As New DataTable
        sCommand.CommandText = "SELECT idUnit, idInvGroup FROM  dInventoryMain WHERE idInvMain = " & idInvMain
        sAdapter.Fill(temp_)
        mdLoadCommitt()
        ' Dim idInvGroup As Integer = temp_.Rows(0).Item("idInvGroup")

        If temp_.Rows(0).Item("idInvGroup") = 1 Then
            If temp_.Rows(0).Item("idUnit") = 2 Then
                drs = _dt.Select("idUnit IN (1,2) ")
            Else
                drs = _dt.Select("idUnit IN (" & temp_.Rows(0).Item("idUnit") & ")")
            End If
        Else
            Dim idUnitSub As New DataTable
            sCommand.CommandText = "SELECT idUnit, idSubUnit FROM dInvUnitSub WHERE idInvMain = " & idInvMain
            sAdapter.Fill(idUnitSub)
            If idUnitSub.Rows.Count > 0 Then
                If idUnit = idUnitSub.Rows(0).Item("idSubUnit") Then
                    StrUnit &= idUnitSub.Rows(0).Item("idSubUnit").ToString + ","
                    For i As Integer = 0 To idUnitSub.Rows.Count - 1
                        StrUnit &= idUnitSub.Rows(i).Item("idUnit").ToString
                        StrUnit &= ","
                    Next
                Else
                    StrUnit &= idUnit.ToString + ","
                    For i As Integer = 0 To idUnitSub.Rows.Count - 1
                        StrUnit &= idUnitSub.Rows(i).Item("idSubUnit").ToString
                        StrUnit &= ","
                    Next
                End If
                drs = _dt.Select("idUnit in(" & StrUnit & ")")
            Else
                drs = _dt.Select("idUnit = " & idUnit)
            End If
        End If

        For Each dr As DataRow In drs
            dtS.ImportRow(dr)
        Next

        Return dtS
    End Function

    Private Sub GvPdQt_ShownEditor(sender As Object, e As EventArgs) Handles GvPdQt.ShownEditor
        Dim view As ColumnView = DirectCast(sender, ColumnView)
        If view.FocusedColumn.FieldName = "idUnit" Then
            Dim editor As LookUpEdit = CType(view.ActiveEditor, LookUpEdit)
            Dim idUnit As Integer = view.GetFocusedRowCellValue("idUnit")

            Dim idInvMain As Integer = view.GetFocusedRowCellValue("idInvMain")
            Dim dt As DataTable = getDataLookup(idUnit, idInvMain)
            editor.Properties.DataSource = dt
            rptUnit.DropDownRows = dt.Rows.Count
        End If
    End Sub

    Private Sub cmbGroupComp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedIndexChanged
        If idQTxx <> 0 Then 'New Qt FROM Old QT // data differance company >> clear data
            idQTxx = 0
            lblNumofQT.Text = "1"
            cmbPayment.SelectedIndex = 0
            lblPsQT.Text = ""
            lblPsQT.Tag = 0
            Me.rdbBill.Checked = True

            MainDt.Rows.Clear()
            GcPdQt.DataSource = MainDt

            'For i As Integer = 0 To QtOldDt.Rows.Count - 1
            '    Dim drNew As DataRow = MainDt.NewRow()
            '    drNew("idQtDt") = 0
            '    drNew("ProductName") = QtOldDt.Rows(i).Item("InvName")
            '    drNew("Amt") = QtOldDt.Rows(i).Item("Amount") 'จำนวนเสนอราคา
            '    drNew("idUnit") = QtOldDt.Rows(i).Item("idUnit")
            '    drNew("PriceBfDis") = QtOldDt.Rows(i).Item("PriceBfDis") 'ราคาปกติ
            '    drNew("PercDisc") = QtOldDt.Rows(i).Item("DisPerc") 'ส่วนลด %
            '    drNew("BathDisc") = QtOldDt.Rows(i).Item("DisBath") 'ส่วนลด (บาท)
            '    drNew("Price") = QtOldDt.Rows(i).Item("Price") 'ราคาขาย
            '    drNew("Total") = QtOldDt.Rows(i).Item("Exp") 'รวมเป็นเงิน
            '    drNew("Note") = QtOldDt.Rows(i).Item("NoteDt")
            '    drNew("idInvMain") = QtOldDt.Rows(i).Item("idInvMain")
            '    drNew("idInvGroup") = QtOldDt.Rows(i).Item("idInvGroup")
            '    drNew("idSubType") = QtOldDt.Rows(i).Item("idSubType")

            '    MainDt.Rows.Add(drNew)
            '    GcPdQt.DataSource = MainDt

            '    Dim dt As DataTable = getDataLookup(QtOldDt.Rows(i).Item("idUnit"), QtOldDt.Rows(i).Item("idInvMain"))
            '    GvPdQt.SetRowCellValue(i, ColUnit.Name, QtOldDt.Rows(i).Item("idUnit"))
            '    rptUnit.DropDownRows = dt.Rows.Count
            'Next
        End If
    End Sub




  
  
End Class


