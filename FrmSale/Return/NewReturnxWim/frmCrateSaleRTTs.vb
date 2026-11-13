Imports System.Data.SqlClient

Public Class frmCrateSaleRTTs
    Dim xProcess As eProcess
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim Result As DialogResult
    'Dim chxCompany As Integer = 0

    Enum eProcess
        eCrateBill 'สร้างบิลรับคืน
        eEditBill 'แก้ไขบิล
        eViewBill 'ดูข้อมูลบิล
        eCancelBill 'ยกเลิกบิล
    End Enum

    Dim idSalexWaitRT As Integer = 0
    Dim dtWaitReturn As New DataTable
    Dim stLoad As Integer = 0
    Dim Year As String = Microsoft.VisualBasic.Right(Date.Now.ToString("yyyy"), 2)
    Dim Month As String = Microsoft.VisualBasic.Left(Date.Now.ToString("MM"), 2)
    Dim dtDel As New DataTable
    Dim idFM As Integer = 0
    Dim idCus As Integer = 0
    Dim idPsSale As Integer = 0
    Dim idWaitReturnMt As Integer = 0
    Sub New(ByVal aProcess As eProcess, ByVal gidSalexWaitRT As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        xProcess = aProcess
        idSalexWaitRT = gidSalexWaitRT
    End Sub

    Private Sub frmApvSaleReturnTs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        stLbl_DateTs.Text = "วันที่ทำรายการ : " & Date.Today
        stLbl_PsTs.Text = "ผู้ทำรายการ : " & sPsName
        stLbl_PsTs.Tag = sPsId


        LoadReturnDocCode()


        ColBoxNo.OptionsColumn.ReadOnly = True
        ColBoxNo.OptionsColumn.AllowEdit = False

        ColAmtRT.OptionsColumn.ReadOnly = True
        ColAmtRT.OptionsColumn.AllowEdit = False

        ColLotno.OptionsColumn.ReadOnly = True
        ColLotno.OptionsColumn.AllowEdit = False

        ColInvName.OptionsColumn.ReadOnly = True
        ColInvName.OptionsColumn.AllowEdit = False

        Select Case xProcess
            Case eProcess.eEditBill
                Me.Text = "แก้ไขบิลรับคืนวัสดุและสินค้า"
                btnReject.Visible = False

            Case eProcess.eViewBill
                Me.Text = "ข้อมูลบิลรับคืนวัสดุและสินค้า"
                btnReject.Visible = False
                btnSave.Visible = False
                ColRTPrice.OptionsColumn.AllowEdit = False
                ColRTPrice.OptionsColumn.ReadOnly = True
                ColRTPrice.AppearanceCell.BackColor = Color.Gainsboro

                ColRTValue.OptionsColumn.AllowEdit = False
                ColRTValue.OptionsColumn.ReadOnly = True
                ColRTValue.AppearanceCell.BackColor = Color.Gainsboro

                ColPriceSale.OptionsColumn.AllowEdit = False
                ColPriceSale.OptionsColumn.ReadOnly = True
                ColPriceSale.AppearanceCell.BackColor = Color.Gainsboro

                btnPsSale.Enabled = False
                txtNote.ReadOnly = True
                cmbDRCode.Enabled = False
                txtDocRef.ReadOnly = True
                dtpWaitReturn.Enabled = False

            Case eProcess.eCancelBill
                Me.Text = "ยกเลิกบิลรับคืนวัสดุและสินค้า"
                btnReject.Visible = False
                ColRTPrice.OptionsColumn.AllowEdit = False
                ColRTPrice.OptionsColumn.ReadOnly = True
                ColRTPrice.AppearanceCell.BackColor = Color.Gainsboro

                ColRTValue.OptionsColumn.AllowEdit = False
                ColRTValue.OptionsColumn.ReadOnly = True
                ColRTValue.AppearanceCell.BackColor = Color.Gainsboro

                ColPriceSale.OptionsColumn.AllowEdit = False
                ColPriceSale.OptionsColumn.ReadOnly = True
                ColPriceSale.AppearanceCell.BackColor = Color.Gainsboro

                btnPsSale.Enabled = False
                txtNote.ReadOnly = True
                cmbDRCode.Enabled = False
                txtDocRef.ReadOnly = True
                dtpWaitReturn.Enabled = False

                btnSave.Image = My.Resources.Resources.ImgNotprocess
                btnSave.Text = "  ยกเลิก"

        End Select




        mdCnOpen()
        mdLoadShow()
        BindData()
        SumTotal()
        mdLoadCommitt()

        stLoad = 1
    End Sub

    Private Sub LoadReturnDocCode()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idRTDocCode, ReturnCode From SmSaleReturnCode WHERE stDel Is NULL "
        sAdapter.Fill(sDt)

        With cmbDRCode
            .DisplayMember = "ReturnCode"
            .ValueMember = "idRTDocCode"
            .DataSource = sDt
        End With


    End Sub

    Private Sub BindData()

        Dim dt As New DataTable

        If xProcess = eProcess.eCrateBill Then

            sCommand.CommandText = "SELECT mt.DocCode, mt.idWaitReturn, dt.idWaitReturnDt, mt.idComp, comp.CompName, inv.InvName, c.ReturnCause, dt.idInvMain, mt.idWaitReturn,dt.AmountReturn,dt.idLot, dt.LotNo, dt.BoxNo, ISNULL(mt.ReturnNo,'') As ReturnNo, p.PartnerName, dt.idWaitReturnDt, dt.idWh, " & vbNewLine &
                                  "u.UnitName, PsTs.PsName As PsTsName, PsSale.PsName As PsSaleName, PsRT.PsName As PsRTName, dt.idRtCause, mt.idComp, u.UnitName, devsk.StrWareHouse(dt.idWh,'') As WareHouseName," & vbNewLine &
                                  "mt.DocCode, mt.DateWaitReturn, mt.idPartner, mt.idPsSale, mt.idPsReturn, mt.Note, mt.DateTs," & vbNewLine &
                                  " PriceSale, RTValueSAM As RTValue, RTPriceSAM As RTPrice," & vbNewLine &
                                  " (AmountReturn*ROUND(RTPrice,2)) As Total, idSaleDt, ISNULL(p.idFM, 0) As idFM, ISNULL(p.idCus,0) As idCus, dt.idUnit " & vbNewLine &
                                  "FROM WimWaitReturnDt dt" & vbNewLine &
                                  "LEFT JOIN WimWaitReturnMt mt ON dt.idWaitReturn = mt.idWaitReturn" & vbNewLine &
                                  "LEFT JOIN dInventoryMain inv ON dt.idInvMain = inv.idInvMain" & vbNewLine &
                                  "LEFT JOIN dInvUnit u ON dt.idUnit = u.idUnit" & vbNewLine &
                                  "LEFT JOIN SmSaleReturnCause c ON dt.idRtCause = c.idRtCause" & vbNewLine &
                                  "LEFT JOIN vPerSonxselect PsTs ON mt.idPsTs = PsTs.idPs" & vbNewLine &
                                  "LEFT JOIN vPersonxSelect PsSale ON mt.idPsSale = PsSale.idPs" & vbNewLine &
                                  "LEFT JOIN vPersonxSelect PsRT ON mt.idPsReturn = PsRT.idPs" & vbNewLine &
                                  "LEFT JOIN PchInvAndProject.dbo.dCompany As comp ON mt.idComp = comp.idComp" & vbNewLine &
                                  "LEFT JOIN dPartner p ON mt.idPartner = p.idPartner" & vbNewLine &
                                  "WHERE mt.idWaitReturn = " & idSalexWaitRT
            sAdapter.Fill(dt)
            lblDocWaitReturn.Text = "เลขที่รายการรอรับคืน :         " & dt.Rows(0).Item("DocCode")
            lblCompName.Text = dt.Rows(0).Item("CompName")
            lblCompName.Tag = dt.Rows(0).Item("idComp")

            dtpWaitReturn.Value = dt.Rows(0).Item("DateWaitReturn")
            lblPartner.Text = "ลูกค้า : " & dt.Rows(0).Item("PartnerName")
            lblPartner.Tag = dt.Rows(0).Item("idPartner")
            lblPsSaleName.Text = " เจ้าหน้าที่ขาย : " & dt.Rows(0).Item("PsSaleName")
            idCus = dt.Rows(0).Item("idCus")
            idFM = dt.Rows(0).Item("idFM")

            idPsSale = dt.Rows(0).Item("idPsSale")

            lblPsReturn.Text = If(IsDBNull(dt.Rows(0).Item("PsRTName")), "", dt.Rows(0).Item("PsRTName"))
            lblPsReturn.Tag = dt.Rows(0).Item("idPsReturn")

            Dim strUrl As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & lblCompName.Tag & ".jpg"
            PictureBox1.Image = getImg(strUrl)


            GCReturn.DataSource = dt

        ElseIf xProcess = eProcess.eEditBill Or xProcess = eProcess.eViewBill Or eProcess.eCancelBill Then

            If xProcess = eProcess.eEditBill Then
                sCommand.CommandText = "SELECT ISNULL([devsk].[WimCheckstUseRecieveWait] (" & idSalexWaitRT & " , 3) ,0) As stRec"
                Dim stRec As Integer = sCommand.ExecuteScalar

                If stRec = 1 Then
                    lblOnlyPrice.Visible = True

                    btnReject.Visible = False
                    btnPsSale.Enabled = False
                    txtNote.ReadOnly = True
                    cmbDRCode.Enabled = False
                    txtDocRef.ReadOnly = True
                    dtpWaitReturn.Enabled = False
                End If
            End If


            sCommand.CommandText = "SELECT sMt.DocNum, sMt.idRTDocCode, sMt.DocRef, mt.DocCode, mt.idWaitReturn, dt.idWaitReturnDt, sMt.idComp, comp.CompName, inv.InvName, c.ReturnCause, dt.idInvMain, " & vbNewLine &
                                    "mt.idWaitReturn, dt.AmountReturn,dt.idLot, dt.LotNo, dt.BoxNo, ISNULL(mt.ReturnNo,'') As ReturnNo, p.PartnerName, dt.idWh, " & vbNewLine &
                                    "PsTs.PsName As PsTsName, PsSale.PsName As PsSaleName, PsRT.PsName As PsRTName, dt.idRtCause, mt.idComp, u.UnitName, devsk.StrWareHouse(dt.idWh,'') As WareHouseName," & vbNewLine &
                                    "mt.DocCode, sMt.DateReturnD As DateWaitReturn, mt.idPartner, mt.idPsSale, mt.idPsReturn, sMt.Note, mt.DateTs," & vbNewLine &
                                    "sDt.Price As PriceSale, sDt.RTValuePerc As RTValue, sDt.RTPrice, sDt.idSaleReturnDt, PsTsBill.PsName As PsTsBill, sMt.DateTsD, " & vbNewLine &
                                    "(sDt.AmountReturn*ROUND(sDt.RTPrice,2)) As Total, dt.idSaleDt, ISNULL(p.idFM, 0) As idFM, ISNULL(p.idCus,0) As idCus, dt.idUnit" & vbNewLine &
                                    "From SmSaleReturnDt sDt " & vbNewLine &
                                    "Left Join SmSaleReturnMt sMt ON sDt.idSaleReturn = sMt.idSaleReturn" & vbNewLine &
                                    "Left Join WimWaitReturnDt dt ON sDt.idWaitReturnDt = dt.idWaitReturnDt" & vbNewLine &
                                    "Left Join WimWaitReturnMt mt ON dt.idWaitReturn = mt.idWaitReturn" & vbNewLine &
                                    "Left Join dInventoryMain inv ON dt.idInvMain = inv.idInvMain" & vbNewLine &
                                    "Left Join dInvUnit u ON dt.idUnit = u.idUnit" & vbNewLine &
                                    "Left Join SmSaleReturnCause c ON dt.idRtCause = c.idRtCause" & vbNewLine &
                                    "Left Join vPerSonxselect PsTs ON mt.idPsTs = PsTs.idPs" & vbNewLine &
                                    "Left Join vPersonxSelect PsSale ON mt.idPsSale = PsSale.idPs" & vbNewLine &
                                    "Left Join vPersonxSelect PsRT ON mt.idPsReturn = PsRT.idPs" & vbNewLine &
                                     "Left Join vPersonxSelect PsTsBill ON sMt.idPsTs = PsTsBill.idPs" & vbNewLine &
                                    "Left Join PchInvAndProject.dbo.dCompany As comp ON sMt.idComp = comp.idComp" & vbNewLine &
                                    "Left Join dPartner p ON mt.idPartner = p.idPartner" & vbNewLine &
                                    "WHERE sMt.idSaleReturn = " & idSalexWaitRT

                sAdapter.Fill(dt)


                idWaitReturnMt = dt.Rows(0).Item("idWaitReturn")

                lblDocCode.Text = dt.Rows(0).Item("DocNum")
                cmbDRCode.SelectedValue = dt.Rows(0).Item("idRTDocCode")
                txtDocRef.Text = dt.Rows(0).Item("DocRef")

                lblDocWaitReturn.Text = "เลขที่รายการรอรับคืน :   " & dt.Rows(0).Item("DocCode")
                lblCompName.Text = dt.Rows(0).Item("CompName")
                lblCompName.Tag = dt.Rows(0).Item("idComp")

                dtpWaitReturn.Value = dt.Rows(0).Item("DateWaitReturn")
                lblPartner.Text = "ลูกค้า : " & dt.Rows(0).Item("PartnerName")
                lblPartner.Tag = dt.Rows(0).Item("idPartner")
                lblPsSaleName.Text = " เจ้าหน้าที่ขาย : " & dt.Rows(0).Item("PsSaleName")
                idCus = dt.Rows(0).Item("idCus")
                idFM = dt.Rows(0).Item("idFM")

                idPsSale = dt.Rows(0).Item("idPsSale")

                lblPsReturn.Text = If(IsDBNull(dt.Rows(0).Item("PsRTName")), "", dt.Rows(0).Item("PsRTName"))
                lblPsReturn.Tag = dt.Rows(0).Item("idPsReturn")

                txtNote.Text = dt.Rows(0).Item("Note")

                stLbl_DateTs.Text = "วันที่ทำรายการ : " & dt.Rows(0).Item("DateTsD")
                stLbl_PsTs.Text = "ผู้ทำรายการ : " & dt.Rows(0).Item("PsTsBill")


                GCReturn.DataSource = dt
                Dim strUrl As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & lblCompName.Tag & ".jpg"
                PictureBox1.Image = getImg(strUrl)
            End If


    End Sub
    Private Function getImg(ByVal url As String) As System.Drawing.Image
        Dim MyWebClient As New System.Net.WebClient
        Try
            Dim ImageInBytes() As Byte = MyWebClient.DownloadData(url)
            Dim ImageStream As New IO.MemoryStream(ImageInBytes)
            Dim pic As System.Drawing.Image = New System.Drawing.Bitmap(ImageStream)
            Return pic
        Catch ex As Exception
            Dim pic As System.Drawing.Image = SAM.My.Resources.Resources.noimage
            Return pic
        End Try
    End Function

    Private Sub GVReturnDt_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVReturn.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum" Then
            If e.RowHandle < 0 Then
                e.DisplayText = "#"
            Else
                e.DisplayText = (e.RowHandle + 1).ToString
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Me.txtDocRef.Text = "" Then
            MessageBox.Show("กรุณากรอกเลขที่อ้างอิง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtDocRef.Focus()
            Exit Sub
        End If



        Using myconnection As New SqlConnection(conStr)
            myconnection.Open()
            Dim mytransaction As SqlTransaction
            Dim mycommand As New SqlCommand()
            Dim myAdapter As New SqlDataAdapter(mycommand)
            ' Start a local transaction
            mytransaction = myconnection.BeginTransaction()

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            mycommand.Connection = myconnection
            mycommand.Transaction = mytransaction
            Try

                If xProcess = eProcess.eCrateBill Then

                    '-----Check ซ้ำ ปัญหาที่เปิดรายการมาแล้วบันทึกพร้อมกัน-----
                    Dim dtDup As New DataTable
                    mycommand.CommandText = "SELECT idWaitRecMt " & vbNewLine &
                                            "FROM WimWaitRecMt " & vbNewLine &
                                            "WHERE idMt = " & idSalexWaitRT & vbNewLine &
                                            "AND ProcessID = 3 " & vbNewLine &
                                            "AND stCancel Is NULL"
                    myAdapter.Fill(dtDup)


                    If dtDup.Rows.Count > 0 Then
                        MessageBox.Show("กรุณาตรวจสอบ !!!" & vbNewLine &
                            "รายการรับคืนนี้ถูกสร้างบิล และส่งไปรอรับของเข้าคลังแล้ว" & vbNewLine &
                            "ไม่สามารถบันทึกซ้ำได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If


                    If lblCompName.Tag = 10 Then
                        '-------Insert SmSaleReturnMt--------
                        'Case รับคืนจาก บ.สตาร์อะกริเทค (idComp = 10)
                        '--STEP 1: Create Bill ลูกค้า คืน สตาร์
                        Dim YearRT As Integer = dtpWaitReturn.Value.Year
                        If YearRT < 2500 Then
                            YearRT = YearRT + 543
                        End If
                        Dim MonthRT As Integer = dtpWaitReturn.Value.Month
                        Dim getDate As String = CType(YearRT, String)

                        Dim Prefixcode As String = (Microsoft.VisualBasic.Right(getDate, 2))
                        Dim DocNumCusxST As String = getDocNum(Prefixcode, mycommand)
                        Dim dateReturn As DateTime = Convert.ToDateTime(dtpWaitReturn.Value, _cultureEnInfo)

                        mycommand.CommandText = "INSERT INTO SmSaleReturnMt(idRTDocCode, DocNum, YearRT, MonthRT, DateReturnD, DocRef,idPsSale, idPsReturn, idPsTs, DateTsD, Note, idComp, idPartner, idCus, idFM, DateReturnSys, idWaitReturn, Total) " & vbNewLine &
                                            "Values(" & cmbDRCode.SelectedValue & ", '" & DocNumCusxST & "', " & YearRT & ", " & MonthRT & ", '" & dateReturn.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "', '" & txtDocRef.Text.Trim & "', " & vbNewLine &
                                             idPsSale & ", " & lblPsReturn.Tag & ", " & sPsId & ", GETDATE(), '" & txtNote.Text.Trim & "', " & lblCompName.Tag & ", " & lblPartner.Tag & "," & idCus & ", " & idFM & vbNewLine &
                                             ", GETDATE()," & idSalexWaitRT & "," & CDbl(txtTotal.Text.Trim) & ")"
                        mycommand.ExecuteNonQuery()

                        Dim qr2 As String = "Select @@Identity"
                        mycommand.CommandText = qr2

                        Dim idRTCusxST = mycommand.ExecuteScalar()

                        '--STEP 2: Create Bill สตาร์ คืน AV (AUTO)
                        '--Auto Gen Bill Return Between ST to AV (idComp = 4)
                        Dim YAndM As String = Microsoft.VisualBasic.Left(ksbDateToString(Date.Today), 6)
                        Dim YAndM_Cut As String = Microsoft.VisualBasic.Right(YAndM, 4)

                        Dim DocNumSTxAV As String = getDocNum(Prefixcode, mycommand)

                        Dim sDocRef As String = "CN" & " " & YAndM_Cut

                        Dim nextOrder As String = ""

                        Dim sDt As New DataTable
                        mycommand.CommandText = "SELECT MAX(DocRef) as max_DocRef " & vbNewLine &
                                                "FROM SmSaleReturnMt " &
                                                "WHERE SUBSTRING(DocRef,1,7) = '" & sDocRef & "' AND idComp = 4 AND idPartner = 2851"
                        myAdapter.Fill(sDt)

                        If IsDBNull(sDt.Rows(0).Item("max_DocRef")) = True Then
                            sDocRef = "CN" & " " & YAndM_Cut & "001"
                        Else
                            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocRef"), 3)
                            Dim temp As Integer
                            temp = CInt(RunningCode) + 1

                            If temp < 100 Then
                                nextOrder = "00" & CStr(temp)
                            ElseIf temp < 1000 Then
                                nextOrder = "0" & CStr(temp)
                            Else
                                nextOrder = CStr(temp)
                            End If

                            sDocRef = "CN" & YAndM_Cut & nextOrder
                        End If

                        mycommand.CommandText = "INSERT INTO SmSaleReturnMt(idRTDocCode, DocNum, YearRT, MonthRT, DateReturnD, DocRef,idPsSale, idPsReturn, idPsTs, DateTsD, Note, idComp, idPartner, idCus, idFM, DateReturnSys, idWaitReturn, Total, idRtAVxST) " & vbNewLine &
                                                "VALUES(" & cmbDRCode.SelectedValue & ", '" & DocNumSTxAV & "', " & YearRT & ", " & MonthRT & ", '" & dateReturn.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "', '" & sDocRef & "', " & vbNewLine &
                                             idPsSale & ", " & lblPsReturn.Tag & ", " & sPsId & ", GETDATE(), '" & txtNote.Text.Trim & "', " & 4 & ", 2851,2873, 0" & vbNewLine &
                                             ", GETDATE()," & idSalexWaitRT & "," & CDbl(txtTotal.Text.Trim) & "," & idRTCusxST & ")"
                        mycommand.ExecuteNonQuery()

                        Dim qr3 As String = "Select @@Identity"
                        mycommand.CommandText = qr3

                        Dim idRTSTxAV As Integer = mycommand.ExecuteScalar()
                        '-------------END SmSaleReturnMt----------------
                        '-------------Insert SmSaleReturnDt-------------
                        '--STEP 3: Insert Dt of Customer To ST
                        If GVReturn.DataRowCount > 0 Then 'มีรายการคืนสินค้า'----ADD Data to SmSaleReturnDt-----'
                            For i As Integer = 0 To GVReturn.DataRowCount - 1
                                Dim dr As DataRow = GVReturn.GetDataRow(i)
                                mycommand.CommandText = "INSERT INTO SmSaleReturnDt(No, idSaleReturn, idSaleDt, idLotSale, AmountReturn, AmtRTBal, " &
                                                    "Price, RTValuePerc, RTPrice, idUnit, idWh, LotNoRT, idInvMain, idLot, idWaitReturnDt) " &
                                                    "Values(" & i + 1 & "," & idRTCusxST & ", " &
                                                    dr.Item("idSaleDt") & ", " &
                                                    dr.Item("idLot") & ", " &
                                                    CDbl(dr.Item("AmountReturn")) & ", " & CDbl(dr.Item("AmountReturn")) & "," &
                                                    CDbl(dr.Item("PriceSale")) & ", " & CDbl(dr.Item("RTValue")) & ", " &
                                                    CDbl(dr.Item("RTPrice")) & ", '" & dr.Item("idUnit") & "', " &
                                                    "90, '" & dr.Item("LotNo") & "'," &
                                                    dr.Item("idInvMain") & "," & dr.Item("idLot") & "," & dr.Item("idWaitReturnDt") & ")"
                                mycommand.ExecuteNonQuery()

                                Dim qr4 As String = "Select @@Identity"
                                mycommand.CommandText = qr4

                                Dim idRtDtAVxST As Integer = mycommand.ExecuteScalar()

                                mycommand.CommandText = "Insert Into SmSaleReturnDt(No, idSaleReturn, idSaleDt, idLotSale, AmountReturn, AmtRTBal, " &
                                                   "Price, RTValuePerc, RTPrice, idUnit, idWh, LotNoRT, idInvMain, idLot, idWaitReturnDt, idRtDtAVxST) " &
                                                   "Values(" & i + 1 & "," & idRTSTxAV & ", " &
                                                   dr.Item("idSaleDt") & ", " &
                                                   dr.Item("idLot") & ", " &
                                                   CDbl(dr.Item("AmountReturn")) & ", " & CDbl(dr.Item("AmountReturn")) & "," &
                                                   CDbl(dr.Item("PriceSale")) & ", " & CDbl(dr.Item("RTValue")) & ", " &
                                                   Math.Round(CDbl(dr.Item("RTPrice")), 2, MidpointRounding.AwayFromZero) & ", '" & dr.Item("idUnit") & "', " &
                                                   dr.Item("idWh") & ", '" & dr.Item("LotNo") & "'," &
                                                   dr.Item("idInvMain") & "," & dr.Item("idLot") & "," & dr.Item("idWaitReturnDt") & "," & idRtDtAVxST & ")"
                                mycommand.ExecuteNonQuery()

                            Next
                        End If

                        mycommand.CommandText = "UPDATE WimWaitReturnMt SET idPsApprove = " & sPsId & " , DateApprove = GETDATE() WHERE idWaitReturn = " & idSalexWaitRT
                        mycommand.ExecuteNonQuery()


                        'STEP 3 : Exec Stored (ส่งไปรอรับเข้าคลัง AV)
                        mycommand.CommandText = "EXECUTE WaitRecieveTs '3','SmSaleReturnMt','SmSaleReturnDt','idSaleReturn'," & idRTCusxST & ",4 ," & sPsId & " ,'1'"
                        mycommand.ExecuteNonQuery()

                        '--STEP 4: Insert Dt of ST To AV
                        '--------------END SmSaleReturnDt---------------
                    Else
                        '--------STEP 1 : Insert Into SmSaleReturnMt/SmSaleReturnDt
                        Dim YearRT As Integer = dtpWaitReturn.Value.Year
                        If YearRT < 2500 Then
                            YearRT = YearRT + 543
                        End If
                        Dim MonthRT As Integer = dtpWaitReturn.Value.Month
                        Dim getDate As String = CType(YearRT, String)
                        Dim DocNum As String = (Microsoft.VisualBasic.Right(getDate, 2))

                        Dim Prefixcode As String = (Microsoft.VisualBasic.Right(getDate, 2))
                        DocNum = getDocNum(Prefixcode, mycommand)
                        Dim dateReturn As DateTime = Convert.ToDateTime(dtpWaitReturn.Value, _cultureEnInfo)

                        mycommand.CommandText = "Insert Into SmSaleReturnMt(idRTDocCode, DocNum, YearRT, MonthRT, DateReturnD, DocRef,idPsSale, idPsReturn, idPsTs, DateTsD, Note, idComp, idPartner, idCus, idFM, DateReturnSys, idWaitReturn, Total) " & vbNewLine &
                                            "Values(" & cmbDRCode.SelectedValue & ", '" & DocNum & "', " & YearRT & ", " & MonthRT & ", '" & dateReturn.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "', '" & txtDocRef.Text.Trim & "', " & vbNewLine &
                                             idPsSale & ", " & lblPsReturn.Tag & ", " & sPsId & ", GETDATE(), '" & txtNote.Text.Trim & "', " & lblCompName.Tag & ", " & lblPartner.Tag & "," & idCus & ", " & idFM & vbNewLine &
                                             ", GETDATE()," & idSalexWaitRT & "," & CDbl(txtTotal.Text.Trim) & ")"
                        mycommand.ExecuteNonQuery()
                        Dim qr2 As String = "Select @@Identity"
                        mycommand.CommandText = qr2

                        Dim idSaleReturn = mycommand.ExecuteScalar()

                        If GVReturn.DataRowCount > 0 Then 'มีรายการคืนสินค้า'----ADD Data to SmSaleReturnDt-----'
                            For i As Integer = 0 To GVReturn.DataRowCount - 1
                                Dim dr As DataRow = GVReturn.GetDataRow(i)

                                mycommand.CommandText = "Insert Into SmSaleReturnDt(No, idSaleReturn, idSaleDt, idLotSale, AmountReturn, AmtRTBal, " &
                                                    "Price, RTValuePerc, RTPrice, idUnit, idWh, LotNoRT, idInvMain, idLot, idWaitReturnDt) " &
                                                    "Values(" & i + 1 & "," & idSaleReturn & ", " &
                                                    dr.Item("idSaleDt") & ", " &
                                                    dr.Item("idLot") & ", " &
                                                    CDbl(dr.Item("AmountReturn")) & ", " & CDbl(dr.Item("AmountReturn")) & "," &
                                                    CDbl(dr.Item("PriceSale")) & ", " & CDbl(dr.Item("RTValue")) & ", " &
                                                    CDbl(dr.Item("RTPrice")) & ", '" & dr.Item("idUnit") & "', " &
                                                    dr.Item("idWh") & ", '" & dr.Item("LotNo") & "'," &
                                                    dr.Item("idInvMain") & "," & dr.Item("idLot") & "," & dr.Item("idWaitReturnDt") & ")"
                                mycommand.ExecuteNonQuery()

                                mycommand.CommandText = "UPDATE WimWaitReturnDt SET RTValueSAM = " & CDbl(dr.Item("RTValue")) & ", RTPriceSAM = " & CDbl(dr.Item("RTPrice")) & " WHERE idWaitReturnDt = " & dr.Item("idWaitReturnDt")
                                mycommand.ExecuteNonQuery()

                            Next
                        End If

                        mycommand.CommandText = "UPDATE WimWaitReturnMt SET idPsApprove = " & sPsId & " , DateApprove = GETDATE() WHERE idWaitReturn = " & idSalexWaitRT
                        mycommand.ExecuteNonQuery()


                        'STEP 3 : Exec Stored 
                        mycommand.CommandText = "EXECUTE WaitRecieveTs '3','SmSaleReturnMt','SmSaleReturnDt','idSaleReturn'," & idSaleReturn & "," &
                                            lblCompName.Tag & " ," & sPsId & " ,'1'"
                        mycommand.ExecuteNonQuery()
                    End If



                ElseIf xProcess = eProcess.eEditBill Then

                    Dim dateReturn As DateTime = Convert.ToDateTime(dtpWaitReturn.Value, _cultureEnInfo)
                    mycommand.CommandText = "Update SmSaleReturnMt SET " & vbNewLine &
                                            "idRTDocCode = " & cmbDRCode.SelectedValue & vbNewLine &
                                            ", DateReturnD = '" & dateReturn.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "'" & vbNewLine &
                                            ", DocRef  ='" & txtDocRef.Text.Trim & "'" & vbNewLine &
                                            ", idPsTs = " & sPsId & vbNewLine &
                                            ", DateTsD = GETDATE()" & vbNewLine &
                                            ", Note = '" & txtNote.Text.Trim & "'" & vbNewLine &
                                            ", Total =  " & CDbl(txtTotal.Text.Trim) & vbNewLine &
                                            "WHERE idSaleReturn = " & idSalexWaitRT 'Case Edit ส่ง idSaleReturn มาจากหน้า Data

                    mycommand.ExecuteNonQuery()

                    If GVReturn.DataRowCount > 0 Then 'มีรายการคืนสินค้า'----ADD Data to SmSaleReturnDt-----'
                        For i As Integer = 0 To GVReturn.DataRowCount - 1
                            Dim dr As DataRow = GVReturn.GetDataRow(i)

                            mycommand.CommandText = "Update SmSaleReturnDt SET " & vbNewLine &
                                                    "Price = " & CDbl(dr.Item("PriceSale")) & vbNewLine &
                                                    ", RTValuePerc = " & CDbl(dr.Item("RTValue")) & vbNewLine &
                                                    ", RTPrice = " & CDbl(dr.Item("RTPrice")) & vbNewLine &
                                                    "Where idSaleReturnDt = " & dr.Item("idSaleReturnDt")

                            mycommand.ExecuteNonQuery()

                            mycommand.CommandText = "UPDATE WimWaitReturnDt Set RTValueSAM = " & CDbl(dr.Item("RTValue")) & ", RTPriceSAM = " & CDbl(dr.Item("RTPrice")) & " WHERE idWaitReturnDt = " & dr.Item("idWaitReturnDt")
                            mycommand.ExecuteNonQuery()

                        Next
                    End If

                ElseIf xProcess = eProcess.eCancelBill Then
                    Result = MsgBox("คุณต้องการยกเลิกรายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
                    If Result = Windows.Forms.DialogResult.Yes Then
                        Dim CancelNote As String = ""
                        CancelNote = InputBox("ระบุสาเหตุการยกเลิก", sSystemName)
                        If CancelNote.Length = 0 Then
                            MessageBox.Show("กรุณาระบุสาเหตุการยกเลิก", sSystemName)
                            Exit Sub
                        Else

                            mycommand.CommandText = "Update SmSaleReturnMt Set idPsCancel = " & sPsId & " , CancelNote = '" & CancelNote.Trim & "' " & vbNewLine &
                                            "Where idSaleReturn = " & idSalexWaitRT
                            mycommand.ExecuteNonQuery()

                            mycommand.CommandText = "Update WimWaitReturnMt Set idPsApprove = NULL , DateApprove = NULL" & vbNewLine &
                                                    "Where idWaitReturn = " & idWaitReturnMt
                            mycommand.ExecuteNonQuery()


                            mycommand.CommandText = "Update WimWaitRecMt Set stCancel = 1 " & vbNewLine &
                                                    "Where idMt = " & idSalexWaitRT & " AND ProcessID = 3"
                            mycommand.ExecuteNonQuery()


                            If lblCompName.Tag = 10 Then
                                mycommand.CommandText = "Update SmSaleReturnMt Set idPsCancel = " & sPsId & " , CancelNote = 'บิลรับคืน ST ถูกยกเลิก (AUTO)' " & vbNewLine &
                                                        "Where idRtAvxST = " & idSalexWaitRT
                                mycommand.ExecuteNonQuery()
                            End If
                        End If

                    End If
                End If


                ' Attempt to commit the transaction.
                mytransaction.Commit()
                mdLoadCommitt()
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()

            Catch ex As Exception
                ' Attempt to roll back the transaction.
                Try

                    mytransaction.Rollback()
                    mdLoadCommitt()
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                    sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                Catch e2x As Exception

                    mdLoadCommitt()
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                    sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                End Try
            Finally
                myconnection.Close()
            End Try
        End Using
    End Sub

    Function getDocNum(ByVal Prefixcode As String, ByVal vCommand As SqlCommand) As String
        Dim vAdapter = New SqlDataAdapter(vCommand)
        Dim DocNum As String = ""
        Dim nextOrder As String = ""
        Dim CodeYear As String = ""

        ' mdCnOpen()
        Dim sDt As New DataTable
        sDt.Clear()
        vCommand.CommandText = "SELECT MAX(DocNum) as max_DocNum FROM SmSaleReturnMt"
        vAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocNum")) = True Then
            DocNum = "SR" & Prefixcode & "/" & "00001"
        Else
            Dim max_DocCode As String = sDt.Rows(0).Item("max_DocNum")
            ' Dim yearDoc As String = Microsoft.VisualBasic.Left(sDt.Rows(0).Item("max_DocNum"), 2)
            Dim yearDoc As String = sDt.Rows(0).Item("max_DocNum").ToString.Substring(2, 2)
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocNum"), 5)

            If Prefixcode <> yearDoc Then
                DocNum = "SR" & Prefixcode & "/" & "00001"
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
                DocNum = "SR" & Prefixcode & "/" & nextOrder
            End If
        End If
        Return DocNum
    End Function

    Private Sub GVReturn_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVReturn.CellValueChanged
        If stLoad = 1 Then
            If e.Column.Name = ColRTValue.Name Then

                If GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, ColRTValue) > 100 Then
                    MessageBox.Show(" % มูลค่าคืนสินค้า ไม่สามารถเกิน 100", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GVReturn.SetRowCellValue(GVReturn.FocusedRowHandle, ColRTValue, 0.0)
                    GVReturn.SetRowCellValue(GVReturn.FocusedRowHandle, ColRTPrice, 0.0)
                Else
                    Dim CalValue As Double = (GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, ColPriceSale) * GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, ColRTValue)) / 100
                    GVReturn.SetRowCellValue(GVReturn.FocusedRowHandle, ColRTPrice, CalValue)
                End If
                SumcolAmountExp()
                SumTotal()
                'GVReturn.SetRowCellValue(GVReturn.FocusedRowHandle, ColRTPrice, GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, "PriceSale") - (GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, "PriceSale") * (GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, "RTPrice") / 100)))
                'GVReturn.SetRowCellValue(GVReturn.FocusedRowHandle, ColTotal, GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, "RTPrice") * GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, "AmountReturn"))
            End If

            If e.Column.Name = ColRTPrice.Name Then
                SumcolAmountExp()
                SumTotal()
            End If

            If e.Column.Name = ColPriceSale.Name Then

                If IsDBNull(GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, ColPriceSale)) Then
                    GVReturn.SetFocusedRowCellValue(ColPriceSale, 0)
                End If

                If IsDBNull(GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, ColRTValue)) Then
                    GVReturn.SetFocusedRowCellValue(ColRTValue, 0)
                End If

                '  Math.Round(CDbl(dr.Item("RTPrice")), 2, MidpointRounding.AwayFromZero)
                Dim CalValue As Double = (Math.Round(GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, ColPriceSale), 2, MidpointRounding.AwayFromZero) * GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, ColRTValue)) / 100
                GVReturn.SetRowCellValue(GVReturn.FocusedRowHandle, ColRTPrice, CalValue)
            End If
        End If
    End Sub

    Private Sub SumcolAmountExp()

        If GVReturn.FocusedRowHandle >= 0 Then
            Dim SumRow As Double = Math.Round(GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, ColRTPrice), 2, MidpointRounding.AwayFromZero) * GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, ColAmtRT)
            GVReturn.SetRowCellValue(GVReturn.FocusedRowHandle, ColTotal, SumRow)
        End If

    End Sub

    Private Sub SumTotal()
        Dim Total As Double = 0.0
        Dim CntReturn As Integer = 0

        For i As Integer = 0 To GVReturn.DataRowCount - 1
            Total += GVReturn.GetDataRow(i).Item("Total")
            CntReturn += GVReturn.GetDataRow(i).Item("AmountReturn")
        Next

        txtTotal.Text = Format(Total, "#,##0.00")
        txtCntReturn.Text = Format(CntReturn, "#,##0")
    End Sub

    Private Sub btnPsSale_Click(sender As Object, e As EventArgs) Handles btnPsSale.Click
        Dim vFrm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPsReturn.Tag = vFrm.mId
            Me.lblPsReturn.Text = vFrm.mName
        End If
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
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

                Dim vFrm As New frmNoteRejectReturn
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    'STEP 3 : Exec Stored 
                    mycommand.CommandText = "UPDATE WimWaitReturnMt Set idPsCheck = NULL, DateCheck = NULL, idPsApprove = NULL, DateApprove = NULL," & vbNewLine &
                                            "idReject = " & sPsId & ", DateReject = GETDATE(), NoteReject = '" & vFrm.txtReject & "'" & vbNewLine &
                                            "WHERE idWaitReturn = " & idSalexWaitRT
                    mycommand.ExecuteNonQuery()

                    ' Attempt to commit the transaction.
                    mytransaction.Commit()
                    mdLoadCommitt()
                    MessageBox.Show("Reject รายการรับคืนเรียบร้อยแล้ว " & vbNewLine &
                                    "กรุณารอทางคลังตรวจสอบและแก้ไขรายการ", sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If




            Catch ex As Exception
                ' Attempt to roll back the transaction.
                Try
                    mytransaction.Rollback()
                    mdLoadCommitt()
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                    sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                Catch e2x As Exception
                    mdLoadCommitt()
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้",
                                    sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                End Try
            Finally
                myconnection.Close()
            End Try
        End Using
    End Sub

End Class