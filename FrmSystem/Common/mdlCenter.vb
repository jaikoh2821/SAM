Imports System.Configuration
Imports System.Net
Imports System.IO
Imports System.IO.Directory
Imports System.Data.SqlClient
Imports DevExpress.XtraSplashScreen

Module mdlCenter
    Public lbrDb As New KsbLibrary.Database.DatabaseManage() ' My.Settings.DbServ, "GR_Group", My.Settings.DbUser, My.Settings.DbPw
    Public lbrMsg As New KsbLibrary.StructureOfProcess.MsgCenter("SAM System")
    Public sSystemName As String = "SAM System"
    Public sProgressbar As New KsbLibrary.Controls.ProgessBarFrm
    Dim mProgressbar As New KsbLibrary.Controls.ProgessBarFrm
    Public sCompRoot, sCompbId, sCompbProvince As Integer : Public sProvinceName As String : Public sCompName, sCompCode As String
    Public SIdCompStr As String
    Public sIdComp As Integer
    Public sIdGroupComp As Integer = -1
    Public sPsId As Integer = 0 : Public sPsCode As String : Public sPsName As String : Public sPsNickName As String
    Public sUser As String = "" : Public sUserName As String = "" : Public sAccountId As Integer = 0
    Private mPicPath, mPicTmpArtwork, mPicTmpPackage, mPicTmpCus, mPicPs, mPicSlip, mPicReceipt, mPicSstkPd, mPicSstkTon, mPicPdPd, mPicPdTon, mPicPdLabel, mPicPdPackage, mPicBookBank, mPicPdArtWork, mPicPdSeeds As String
    Public sChkPicPath As Boolean
    Dim mLoading As New frmLoading ' KsbLibrary.Controls.LoadProcessing '
    ' Dim mFrmLoad As New GrTeamSystem.ASG_Loading()
    Dim sDtMenu As New DataTable

    Public sFrmMain As New MainMenu
    Public lbrPOP As New KsbLibrary.Database.DatabaseManage

    Public sCn As New SqlConnection
    Public sSql As String
    Public sCommand As New SqlCommand()
    Public sAdapter As New SqlDataAdapter()
    Public sBindingSrc As BindingSource
    Public sDs As New DataSet()
    Public tempDateSale As String = ""
    Dim msgNewUpdate As Integer = 0
    Dim timeChkUpd As DateTime = DateTime.Now

    Public conStr As String = ConfigurationManager.ConnectionStrings("SAM.My.MySettings.cnSPM").ConnectionString
    Public connStrxP As String = ConfigurationManager.ConnectionStrings("SAM.My.MySettings.cnSPM").ConnectionString
    Public connection As New SqlConnection  '(conStr)

    Public Sub mdCnOpenTest()  ' GR_GroupTest
        connection = New SqlConnection
        With connection
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = conStr
            .Open()
        End With
        sCommand = New SqlCommand(sSql, connection)
        sAdapter = New SqlDataAdapter(sCommand)
    End Sub

    Public Function mdCnOpenQueryIdentityTest(ByVal query As String) As Integer
        Dim query2 As String = "Select @@Identity"
        Dim ID As Integer
        Dim connect As String = ConfigurationManager.ConnectionStrings("GR_GroupTest").ConnectionString  'conStr
        Dim ans As String = ""
        Try
            sCn = New SqlConnection
            With sCn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = connect   ' conStr
                .Open()
            End With

            Using conn As New SqlConnection(connect)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = query2
                    ID = cmd.ExecuteScalar()
                End Using
            End Using
            Return ID
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

#Region "Ftp"
    Private sFtpIpServ As String
    ' Private sFtpUser As String
    Private sFtpPassword As String
    'Public sFtpCusCheckPath As String
    'Public sTmpPicCheckPath As String '= sPathScan
    ' Public sConnectFtpResult As Boolean = False
    Public sPicPathClient As String = "C:\tmpPicSAM\"

    Public sHost As String = ConfigurationManager.AppSettings("FtpHost")
    Public sFtpUser As String = ConfigurationManager.AppSettings("FtpUser")
    Public sFtpPass As String = ConfigurationManager.AppSettings("FtpPass")
    Public sAprBaseUrl As String = ConfigurationManager.AppSettings("ApproveBaseUrl")
    Public sFtpPathMain = "/spm/"


    Public Enum ePicFTP
        Fm
        FmL
        FmBankAccount
        FmPerC
        FmHomedD
        Person
        PersonCard
        Slip
        Receipt
        SstkPd
        SstkTon
        PdPd
        PdTon
        PdLabel
        PdPackage
        BookBankComp
        PdArtWork
        PdSeeds
        tmpArtwork
        tmpPackage
        tmpCus
    End Enum
    '  เชื่อมต่อไปยัง FTP
    Public Function mdConnectFTP() As Boolean
        ftpCon(sFtpIpServ, sFtpUser, sFtpPassword)
        If ftpConnectAbleCheck() = False Then
            MsgBox("ไม่สามารถติดต่อการส่งข้อมูล รูป จาก Server ได้")
            '  sConnectFtpResult = False
            Return False
        End If
        'sConnectFtpResult = True
        Return True

    End Function
    Public Function mdPicConvert(ByVal aPicPath As ePicPath, ByVal aPicFrom As String, ByVal aId As String) As String
        Dim vW, vH As Integer
        Select Case aPicPath
            Case ePicPath.Fm, ePicPath.FmL, ePicPath.Ps, ePicPath.SstkPd, ePicPath.SstkTon, ePicPath.PdPd, ePicPath.PdTon, ePicPath.PdLabel, ePicPath.PdPackage : vW = 170 : vH = 200
            Case ePicPath.FmBankAccount, ePicPath.HomeDoc, ePicPath.PersCard, ePicPath.Slip, ePicPath.Receipt, ePicPath.PsCard : vW = 300 : vH = 200
        End Select
        Dim vPath As String = mdPicPathClient(aPicPath) & "cvt\"
        mdPathChkAndCreate(vPath)
        Dim vPtb As New PictureBox
        vPtb.Image = Image.FromFile(aPicFrom)
        Dim vBmp As New Bitmap(200, 250)
        Dim vG As Graphics = Graphics.FromImage(vBmp)
        vG.DrawImage(vPtb.Image, 0, 0, vBmp.Width, vBmp.Height)
        vPtb.Image = vBmp
        vPath &= aId & ".jpg"
        vPtb.Image.Save(vPath)
        Return vPath
    End Function
    Public Sub mdUpload_POP(ByVal aModule As String, ByVal aFileName As String, ByVal aFileFrom As String, Optional ByVal aType As String = ".pdf")
        mdLoadShow()
        Dim vPathFtp As String = "/POP/Doc/SPM/" & aModule
        If aFileFrom <> "" Then
            Dim vFTP As New KsbLibrary.FTP.FTPclient(sHost, sFtpUser, sFtpPass)
            If vFTP.Upload(aFileFrom, vPathFtp & "/" & aFileName & aType) = True Then
                ' lbrMsg.MsgInformation("ส่งรูปเก็บที่ Server เรียบร้อยแล้ว")
            Else
                lbrMsg.MsgError("ไม่สามารถส่ง File ไปเก็บที่ Server ได้ ")
            End If
        End If
        mdLoadCommitt()
    End Sub
    Public Sub mdUploadPic(ByVal aPathFtp As ePicFTP, ByVal aPicName As String, ByVal aPicFrom As String)
        mdLoadShow()
        Dim vPathFtp As String = mdFtpPathGet(aPathFtp)
        If aPicFrom <> "" Then
            If ftpUp("/images/" & vPathFtp & "/" & aPicName & ".jpg", aPicFrom) = True Then
                ' lbrMsg.MsgInformation("ส่งรูปเก็บที่ Server เรียบร้อยแล้ว")
            Else
                lbrMsg.MsgError("ไม่สามารถส่ง File " & aPicFrom & " ไปเก็บที่ Server ได้ ")
            End If
        End If
        mdLoadCommitt()
    End Sub
    Public Sub mdFtpDel(ByVal aPathFtp As ePicFTP, ByVal aPicName As String)
        mdLoadShow()
        Dim vPathFtp As String = mdFtpPathGet(aPathFtp)
        ftpDel("/images/" & vPathFtp & "/" & aPicName & ".jpg")
        mdLoadCommitt()
    End Sub
    Public Function mdFtpPathGet(ByVal aPathFtp As ePicFTP) As String
        Dim vPathFtp As String = ""
        Select Case aPathFtp
            Case ePicFTP.Fm : vPathFtp = ""
            Case ePicFTP.FmBankAccount : vPathFtp = ""
            Case ePicFTP.FmHomedD : vPathFtp = ""
            Case ePicFTP.FmL : vPathFtp = ""
            Case ePicFTP.FmPerC : vPathFtp = ""
            Case ePicFTP.Person : vPathFtp = mPicPs
            Case ePicFTP.PersonCard : vPathFtp = ""
            Case ePicFTP.Slip : vPathFtp = mPicSlip
            Case ePicFTP.Receipt : vPathFtp = mPicReceipt
            Case ePicFTP.SstkPd : vPathFtp = mPicSstkPd
            Case ePicFTP.SstkTon : vPathFtp = mPicSstkTon
            Case ePicFTP.PdPd : vPathFtp = mPicPdPd
            Case ePicFTP.PdTon : vPathFtp = mPicPdTon
            Case ePicFTP.PdLabel : vPathFtp = mPicPdLabel
            Case ePicFTP.PdPackage : vPathFtp = mPicPdPackage
            Case ePicFTP.BookBankComp : vPathFtp = mPicBookBank
            Case ePicFTP.PdArtWork : vPathFtp = mPicPdArtWork
            Case ePicFTP.PdSeeds : vPathFtp = mPicPdSeeds
            Case ePicFTP.tmpArtwork : vPathFtp = mPicTmpArtwork
            Case ePicFTP.tmpPackage : vPathFtp = mPicTmpPackage
            Case ePicFTP.tmpCus : vPathFtp = mPicTmpCus
        End Select
        Return vPathFtp
    End Function
#End Region

#Region "Processing"
    Public Sub mdLoadShow()
        '   mFrmLoad.ASG_LoadingStart()

        Cursor.Current = Cursors.WaitCursor
        mLoading.Visible = True
        'mLoading.LoadShow()
        mLoading.Refresh()
    End Sub

    Public Sub mdLoadCommitt()
        ' mFrmLoad.ASG_LoadingEnd()
        
        SplashScreenManager.CloseForm(False)

        mLoading.Visible = False
        '  mLoading.LoadCommitt()
        Cursor.Current = Cursors.Default
    End Sub

    Public Sub mdProgressShow(ByVal aMaxValue As Integer)
        mProgressbar = New KsbLibrary.Controls.ProgessBarFrm(aMaxValue)

        mProgressbar.Visible = True
    End Sub

    Public Sub mdProgressAddV(ByVal aValue As Integer)
        mProgressbar.pptValue = aValue
    End Sub

    Public Sub mdProgressAddPlus(ByVal aValue As Integer)
        mProgressbar.pptValue += aValue
    End Sub

    Public Sub mdProgressCommitt()
        mProgressbar.Visible = False
    End Sub

#End Region

    Public Sub mdCore_Connect()
        ''      If lbrPOP.mCnSqlServ.State <> ConnectionState.Open Then
        lbrPOP.Connecting(My.Settings.cnCore, KsbLibrary.Database.DatabaseManage.DbType.SqlServer)
        '   End If       
        Try
            sCommand = New SqlCommand(sSql, lbrPOP.mCnSqlServ)
            sAdapter = New SqlDataAdapter(sCommand)
        Catch ex As Exception
            mdLoadCommitt()
            lbrMsg.MsgNotConnect("มีการผิดพลาดในการเชื่อมต่อข้อมูล")
        End Try

    End Sub
#Region "POP"
    Public Sub mdCnOpen2()
        mdPOP_Connect()
    End Sub

    Public Sub mdPOP_Connect()

        ' If lbrPOP.mCnSqlServ.State <> ConnectionState.Open Then
        lbrPOP.Connecting(My.Settings.cnPOP, KsbLibrary.Database.DatabaseManage.DbType.SqlServer)
        '    End If
        'sCn = New SqlConnection
        'With sCn
        '    If .State = ConnectionState.Open Then .Close()
        '    .ConnectionString = My.Settings.cnPOP
        '    .Open()
        'End With
        Try
            sCommand = New SqlCommand(sSql, lbrPOP.mCnSqlServ)
            sAdapter = New SqlDataAdapter(sCommand)
        Catch ex As Exception
            mdLoadCommitt()
            lbrMsg.MsgNotConnect("มีการผิดพลาดในการเชื่อมต่อข้อมูล")
        End Try

    End Sub

    Public Function mdPOP_CompId()
        Return sCompbId + 1
    End Function

    Public Function mdPOP_NumRP(Optional ByVal aDate As String = "") As String
        mdPOP_Connect()
        Dim vCodeFormat, vMax, vYear As String
        If aDate = "" Then aDate = Today.ToShortDateString
        Dim vDate As Date = CDate(aDate) 'IIf(aDate = "", Today, CDate(aDate))
        vYear = ksbChkTypeDate(vDate.Year) '.Substring(2, 2)
        vCodeFormat = "RP" & vYear.Substring(2, 2) & "/"
        vMax = lbrPOP.SQLExecuteReturnValue("Select Max(Right(DocCode,4)) As MaxCode  from tsPchInvRecMt Where SubString(DocDate,3,2) = '" & vYear.Substring(2, 2) & "'  And  idComp = " & mdPOP_CompId())
        vCodeFormat = IIf(Val(vMax) = 0, vCodeFormat & Format(1, "0000"), vCodeFormat & Format(Val(vMax) + 1, "0000"))
        lbrPOP.mCnSqlServ.Close()
        Return vCodeFormat
    End Function

    Public Function mdPOP_NumBill(ByVal aYear As String) As String
        mdPOP_Connect()
        aYear = aYear.Substring(2, 2)
        Dim vNum As String = lbrPOP.SQLExecuteReturnValue("Max", "BillCode", "tsPchInvRecMt", "substring(BillCode,1,2)= " & aYear & " And " & " idComp =" & mdPOP_CompId())
        If vNum = "0" Then
            vNum = aYear & "0001"
        Else
            vNum = aYear & Format(Val(vNum.Substring(2, vNum.Length - 2)) + 1, "0000")
        End If

        lbrPOP.mCnSqlServ.Close()
        Return vNum
    End Function
#End Region

#Region "Start"
    Public Sub mdTfData()
        mdLoadShow()
        lbrDb.DeleteExecute("dCustomer")
        Dim vDt As New DataTable : lbrDb.DtSet(vDt, "DISTINCT CusName, Address, ZipCode,Tel, Fax, Note", "dCustomer_", , "CusName")
        Dim vField As String = "CusName|Address|ZipCode|Tel|Fax|Note"
        Dim vType As String = "0|0|0|0|0|0"
        Dim vValue As String = ""
        mdProgressShow(vDt.Rows.Count + 2)
        Try

            lbrDb.BeginTransaction()
            For Each vDr As DataRow In vDt.Rows
                vValue = pReplaceTrim(vDr.Item("CusName")) & "|" & pReplaceTrim(vDr.Item("Address")) & "|" & pReplaceTrim(vDr.Item("ZipCode")) & "|" & pReplaceTrim(vDr.Item("Tel")) & "|" & pReplaceTrim(vDr.Item("Fax")) & "|" & pReplaceTrim(vDr.Item("Note"))
                lbrDb.InsertToDb("dCustomer", vField, vType, vValue, True)
                mdProgressAddPlus(1)
            Next
            lbrDb.CommitTransaction()
            mdProgressCommitt()
            mdLoadCommitt()
            lbrMsg.MsgInformation("Complete")

        Catch ex As Exception
            lbrDb.RollbackTransaction()
            lbrMsg.MsgWarning(ex.Message)
        End Try
        Application.Exit()
    End Sub

    Private Sub mdTfPd()
        mdLoadShow()
        lbrDb.DeleteExecute("dCustomer")
        Dim vDt As New DataTable : lbrDb.DtSet(vDt, "DISTINCT CusName, Address, ZipCode,Tel, Fax, Note", "dCustomer_", , "CusName")
        Dim vField As String = "CusName|Address|ZipCode|Tel|Fax|Note"
        Dim vType As String = "0|0|0|0|0|0"
        Dim vValue As String = ""
        mdProgressShow(vDt.Rows.Count + 2)
        Try

            lbrDb.BeginTransaction()
            For Each vDr As DataRow In vDt.Rows
                vValue = pReplaceTrim(vDr.Item("CusName")) & "|" & pReplaceTrim(vDr.Item("Address")) & "|" & pReplaceTrim(vDr.Item("ZipCode")) & "|" & pReplaceTrim(vDr.Item("Tel")) & "|" & pReplaceTrim(vDr.Item("Fax")) & "|" & pReplaceTrim(vDr.Item("Note"))
                lbrDb.InsertToDb("dCustomer", vField, vType, vValue, True)
                mdProgressAddPlus(1)
            Next
            lbrDb.CommitTransaction()
            mdProgressCommitt()
            mdLoadCommitt()
            lbrMsg.MsgInformation("Complete")

        Catch ex As Exception
            lbrDb.RollbackTransaction()
            lbrMsg.MsgWarning(ex.Message)
        End Try
        Application.Exit()
    End Sub

    Private Function pReplaceTrim(ByVal aStr As String) As String
        Return Replace(RTrim(aStr), "'", " ")
    End Function

    Private Sub pTfCode()
        mdLoadShow()
        Dim vDt As New DataTable : lbrDb.DtSet(vDt, "Distinct CNOCM1,CusName", "dCustomer_", , "CusName")
        mdProgressShow(vDt.Rows.Count + 2)
        For Each vDr As DataRow In vDt.Rows
            lbrDb.UpdateExecute("dCustomer", "CusCode='" & pReplaceTrim(vDr.Item("CNOCM1")) & "'", "CusName='" & pReplaceTrim(vDr.Item("CusName")) & "'")
            mdProgressAddPlus(1)
        Next

        mdProgressCommitt()
        mdLoadCommitt()
        lbrMsg.MsgInformation("Complete")
    End Sub

    'Public Function mdConnectSPM() As Boolean
    '    mdLoadShow()
    '    Try
    '        If lbrDbSPM.mCnSqlServ.State = ConnectionState.Closed Then
    '            lbrDbSPM.Connecting(My.Settings.cnSPM, KsbLibrary.Database.DatabaseManage.DbType.SqlServer)
    '        End If
    '    Catch ex As Exception
    '        mdLoadCommitt()
    '        lbrMsg.MsgNotConnect()
    '        Application.Exit()
    '        Return False
    '    End Try
    '    mdLoadCommitt()
    'End Function
    'Public Sub mdConnectSPM_Close()
    '    If lbrDbSPM.mCnSqlServ.State = ConnectionState.Open Then
    '        lbrDbSPM.mCnSqlServ.Close()

    '    End If
    'End Sub
    Public Function StrWareHouse(ByVal idWh As Integer, ByVal StrWh As String) As String
        ' Dim StrWh As String = ""
        Dim sDt As New DataTable
        Dim idParrent As Integer = -1
        sCommand.CommandText = "SELECT WareHouseName, idParrent FROM  SsWarehouse WHERE idWh = " & idWh
        sAdapter.Fill(sDt)
        If idWh > 0 Then
            StrWh = sDt.Rows(0).Item("WareHouseName") & "|" & StrWh
            idParrent = sDt.Rows(0).Item("idParrent")
        Else
            StrWh = "   - "
            idParrent = 0
        End If
        If idParrent <> 0 Then
            Return StrWareHouse(sDt.Rows(0).Item("idParrent"), StrWh)
        Else
            Return StrWh.Substring(0, StrWh.Length - 1)
        End If

    End Function
    Public Function mdConnectDb() As Boolean

        Try
            lbrDb.Connecting(My.Settings.cnSPM, KsbLibrary.Database.DatabaseManage.DbType.SqlServer)
            sCommand = New System.Data.SqlClient.SqlCommand("", lbrDb.mCnSqlServ)
            sAdapter = New System.Data.SqlClient.SqlDataAdapter(sCommand)
        Catch ex As Exception
            mdLoadCommitt()
            lbrMsg.MsgNotConnect()
            Application.Exit()
            Return False
        End Try
        ' pTfCode()
        mdSetConfig()

        '  ksbSetDateTimeClient(lbrDb)


        ' sChkPicPath   = mdConnectFTP()
        Return True
    End Function

    Public Sub mdConnectDbSPM()
        With lbrDb.mCnSqlServ
            If DateTime.Now > timeChkUpd.AddHours(1) Then 'AddHours
                msgNewUpdate = 0
            End If
        End With
        Try
            sCommand = New System.Data.SqlClient.SqlCommand("", lbrDb.mCnSqlServ)
            sAdapter = New System.Data.SqlClient.SqlDataAdapter(sCommand)
        Catch ex As Exception
            mdLoadCommitt()
            lbrMsg.MsgNotConnect("มีการผิดพลาดในการเชื่อมต่อข้อมูล")
        End Try

    End Sub

    Public Sub mdCnOpen()
        With lbrDb.mCnSqlServ
            If DateTime.Now > timeChkUpd.AddHours(1) Then 'AddHours
                msgNewUpdate = 0
            End If

            'If msgNewUpdate = 0 And My.Application.Deployment.CheckForUpdate Then 'My.Application.Deployment.CheckForUpdate
            '    mdLoadCommitt()
            '    Dim mResult As DialogResult
            '    mResult = MessageBox.Show("ระบบมีการอัพเดตเวอร์ชั่นใหม่ กรุณาปิดโปรแกรมแล้วเข้าใหม่ " & vbNewLine & "เพื่อทำการอัพเดตเวอร์ชั่นล่าสุด " &
            '                             "คุณต้องการปิดโปรแกรมทันทีหรือไม่?" & vbNewLine & vbNewLine &
            '                             " - กรุณากดปุ่ม YES หากต้องการปิดโปรแกรม และอัพเดตเวอร์ชั่นใหม่ทันที" & vbNewLine &
            '                             " - กรุณากดปุ่ม NO หากต้องการปิดโปรแกรม และอัพเดตเวอร์ชั่นใหม่ภายหลัง",
            '                sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            '    If mResult = DialogResult.Yes Then
            '        Application.Exit()
            '    ElseIf mResult = DialogResult.No Then
            '        msgNewUpdate = 1
            '        timeChkUpd = DateTime.Now
            '    End If
            'End If

            lbrDb.Connecting(My.Settings.cnSPM, KsbLibrary.Database.DatabaseManage.DbType.SqlServer)
        End With
        Try
            sCommand = New System.Data.SqlClient.SqlCommand("", lbrDb.mCnSqlServ)
            sAdapter = New System.Data.SqlClient.SqlDataAdapter(sCommand)
        Catch ex As Exception
            mdLoadCommitt()
            lbrMsg.MsgNotConnect("มีการผิดพลาดในการเชื่อมต่อข้อมูล")
        End Try

    End Sub


    Public Sub mdStartSet()
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException
    End Sub

    Public Sub CurrentDomain_UnhandledException(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs) 'UnhandledExceptionEventArgs
        mdConnectionError(CType(e.ExceptionObject, SqlClient.SqlException))
    End Sub

    Public Function mdConnectionError(ByVal aEx As SqlClient.SqlException) As Boolean
        If ksbConnectionErrorChk(aEx) = True Then
            'lbrMsg.MsgDisConnectAndNewConnect()
            If mdConnectDb() = True Then
                lbrMsg.MsgConnectToServerComplete()
                Return True
            End If
        Else
            ' lbrMsg.MsgError(aEx.Message)
        End If
        Return False
    End Function


    Private Sub mdSetConfig()
        
        pPicConfigGet()
    End Sub
    Public Sub mdRptLoadBegin()
        Dim vFrm As New FrmReportView
        ' vFrm.Visible = False
        vFrm.Show()
        '    vFrm.Close()
    End Sub

#End Region

#Region "CmbSet"

    'Public Sub mdGridExColumnMoneySet(ByRef aGridEx As Janus.Windows.GridEX.GridEXTable, ByRef aName As String, ByVal aCaption As String, Optional ByVal aWidth As Integer = 75)
    '    aGridEx.Columns(aName).Caption = aCaption : aGridEx.Columns(aName).Width = 75 : aGridEx.Columns(aName).FormatString = "#,##0.00"
    '    aGridEx.Columns(aName).TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
    '    aGridEx.Columns(aName).AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
    '    aGridEx.Columns(aName).TotalFormatMode = Janus.Windows.GridEX.FormatMode.UseStringFormat
    '    aGridEx.Columns(aName).TotalFormatString = "{0:c}"
    'End Sub

    Public Enum eData
        Province
        Aumphur
        Tumbon
        Plant
        PlantType
        Product
    End Enum
    Public Function mdTblToCmb(ByVal aCmb As ComboBox, ByVal aDataList As eData, Optional ByVal aWhere As String = "") As ComboBox
        Dim vDt As New DataTable : Dim vId As String = "" : Dim vName As String = ""
        Select Case aDataList
            Case eData.Province : vId = "idPv" : vName = "PvName"
            Case eData.Aumphur : vId = "idAp" : vName = "ApName"
            Case eData.Tumbon : vId = "idTb" : vName = "TbName"
            Case eData.Plant : vId = "idSeed" : vName = "SeedName"
            Case eData.PlantType : vId = "idSeedType" : vName = "SeedTypeName"
            Case eData.Product : vId = "idPd" : vName = "PdName"
        End Select

        lbrDb.CmbSetData(aCmb, vName, vId, mdTblToDt(vDt, aDataList, aWhere))
       
        If aCmb.Items.Count = 0 Then aCmb.Text = ""
        aCmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        aCmb.AutoCompleteSource = AutoCompleteSource.ListItems
        Return aCmb
    End Function
    Public Function mdTblToDt(ByVal aDt As DataTable, ByVal aDataList As eData, Optional ByVal aWhere As String = "") As DataTable
        Select Case aDataList
            Case eData.Province : lbrDb.DtSet("Select idPv,PvName From dProvinceFixSale ", aDt) 'Where idProvince <> 0
            Case eData.Aumphur : lbrDb.DtSet("Select idAp,ApName From dAp  " & IIf(aWhere <> "", " Where idPv = " & aWhere & " OR idAp = 0", ""), aDt)
            Case eData.Tumbon : lbrDb.DtSet("Select idTb,TbName From dTb  " & IIf(aWhere <> "", " Where idAp = " & aWhere & " OR idTb = 0", ""), aDt)
            Case eData.Plant : lbrDb.DtSet("Select idSeed,SeedName From dSeed Where stDel is null " & IIf(aWhere <> "", "And idSeedKind = " & aWhere, "") & " Order By SeedName", aDt)
            Case eData.PlantType : lbrDb.DtSet("Select * From dSeedType Where stDel is null And idSeedType <> 0 " & IIf(aWhere <> "", "And idSeed = " & aWhere, "") & " Order By SeedTypeName", aDt)
            Case eData.Product : lbrDb.DtSet("Select idPd,PdCode + ' : ' + PdName as PdName From dSeedProduct Where stDel is Null " & IIf(aWhere <> "", " And (idSeedType = " & aWhere & " OR idPd = 0)", "") & "  Order By PdCode", aDt)
        End Select
        Return aDt
    End Function
#End Region


#Region "Menu"
    Public Sub mdMenuLock(ByVal aObject As Object)
        aObject.Enabled = False
    End Sub
    Public Sub mdMenuUnlock(ByVal aObject As Object)
        aObject.Enabled = True
    End Sub
    Public Sub mdMenuAccess(ByVal aMainMenu As MenuStrip)

        For Each vMnu As Object In aMainMenu.Items
            If vMnu.tag = "h" Then
                For Each vvMnu As Object In vMnu.DropDownItems
                    If vvMnu.tag = "h" Then
                        For Each vvvMnu As Object In vvMnu.DropDownItems
                            If vvvMnu.tag = "h" Then
                                For Each vvvvMnu As Object In vvvMnu.DropDownItems
                                    mdMenuLock(vvvvMnu)
                                Next
                            Else
                                mdMenuLock(vvvMnu)
                            End If
                        Next
                    Else
                        mdMenuLock(vvMnu)
                    End If
                Next
            End If

        Next
        lbrDb.DtSet("Select * From UaAccountAccess where idUa = " & sAccountId, sDtMenu)

        Dim vChkH_1 As Boolean = False : Dim vChkH_2 As Boolean = False : Dim vChkH_3 As Boolean
        For Each vMnu As Object In aMainMenu.Items
            If vMnu.tag = "h" Then
                vChkH_1 = False

                For Each vvMnu As Object In vMnu.DropDownItems
                    If vvMnu.tag = "h" Then
                        vChkH_2 = False

                        For Each vvvMnu As Object In vvMnu.DropDownItems
                            If vvvMnu.tag = "h" Then
                                vChkH_3 = False

                                For Each vvvvMnu As Object In vvvMnu.DropDownItems

                                    For Each vDr As DataRow In sDtMenu.Rows
                                        If TypeOf vvvvMnu Is ToolStripMenuItem And vDr.Item("MenuCode") = vvvvMnu.tag Then
                                            mdMenuUnlock(vvvvMnu)
                                            vChkH_3 = True
                                            vChkH_2 = True
                                            vChkH_1 = True
                                        End If
                                    Next

                                Next
                                If vChkH_3 = False Then
                                    mdMenuLock(vvvMnu)
                                Else
                                    mdMenuUnlock(vvvMnu)
                                End If
                            Else
                                For Each vDr As DataRow In sDtMenu.Rows
                                    If TypeOf vvvMnu Is ToolStripMenuItem And vDr.Item("MenuCode") = vvvMnu.tag Then
                                        mdMenuUnlock(vvvMnu)
                                        vChkH_2 = True
                                        vChkH_1 = True
                                    End If
                                Next
                            End If

                        Next
                        If vChkH_2 = False Then
                            mdMenuLock(vvMnu)
                        Else
                            mdMenuUnlock(vvMnu)
                        End If
                    Else
                        For Each vDr As DataRow In sDtMenu.Rows
                            If TypeOf vvMnu Is ToolStripMenuItem And vDr.Item("MenuCode") = vvMnu.tag Then
                                mdMenuUnlock(vvMnu)
                                vChkH_1 = True
                            End If
                        Next
                    End If
                Next
                If vChkH_1 = False Then
                    mdMenuLock(vMnu)
                Else
                    mdMenuUnlock(vMnu)
                End If
            End If
        Next
    End Sub

  
#End Region

#Region "Pic"
    Public Enum ePicPath
        Fm
        FmL
        Ps
        PsCard
        HomeDoc
        PersCard
        FmBankAccount
        Slip
        Receipt
        SstkPd
        SstkTon
        PdPd
        PdTon
        PdLabel
        PdPackage
        BookBankComp
        PdArtWork
        PdSeeds
    End Enum
    Public Function mdServImgGet(ByVal aPic As ePicFTP, ByVal aImgName As String) As Image
        'mdLoadShow()
        Dim objImage As MemoryStream
        Dim objwebClient As WebClient
        Dim vPathF As String = "http://siamadvancehost.com/SPM" & mdPicPathFTP(aPic) & aImgName & ".jpg"
        Dim vImg As Image

        Try
            objwebClient = New WebClient()
            objImage = New MemoryStream(objwebClient.DownloadData(vPathF))
            vImg = Image.FromStream(objImage)

            objwebClient.Dispose()
            '_Image = Image.FromFile(sURL)
            Return vImg
        Catch ex As Exception
            '_Image = dfPersonImage
            vImg = Nothing
            Return vImg
        End Try
        ' mdLoadCommitt()
    End Function
    Private Sub pPicConfigGet()
        If mPicPath = "" Then
            Dim vDt As New DataTable
            lbrDb.DtSet(vDt, "PicPath,FdFm,FdFmLover,FdPerson,FdPersonCard,FdFmHomeDoc,FdFmPersCard,FdFmBankAccount,FdSlip,FdReceipt,FtpAddress,FtpUser,FtpPw,FdSstkPd,FdSstkTon,FdPdPd,FdPdTon,FdPdTPd,FdPdTTon,FdBookBank", "cfgSystem")
            With vDt.Rows(0)
                mPicPath = .Item("PicPath")
                '  mPicFm = .Item("FdFm")
                ' mPicFmL = .Item("FdFmLover")
                mPicPs = .Item("FdPerson")
                ' mPicPsCard = .Item("FdPersonCard")
                ' mPicHomeD = .Item("FdFmHomeDoc")
                'mPicPersC = .Item("FdFmPersCard")
                'mPicFmBankAccount = .Item("FdFmBankAccount")
                mPicSlip = .Item("FdSlip")
                mPicReceipt = .Item("FdReceipt")
                mPicSstkPd = .Item("FdSstkPd")
                mPicSstkTon = .Item("FdSstkTon")
                mPicPdPd = .Item("FdPdPd")
                mPicPdTon = .Item("FdPdTon")
                mPicPdLabel = .Item("FdPdTPd")
                mPicPdPackage = .Item("FdPdTTon")
                mPicBookBank = .Item("FdBookBank")
                sFtpIpServ = .Item("FtpAddress")
                sFtpUser = .Item("FtpUser")
                sFtpPassword = .Item("FtpPw")
                mPicPdArtWork = "pPdArtWork"
                mPicPdSeeds = "pPdSeeds"
                mPicTmpArtwork = "pTmpArtwork"
                mPicTmpPackage = "pTmpPackage"
                mPicTmpCus = "pTmpCus"
            End With

        End If
    End Sub
    Public Function mdPicPathFTP(ByVal aPic As ePicFTP) As String
        Select Case aPic
            '    Case ePicFTP.Fm : Return mPicPath & mPicFm & "/"
            ' Case ePicFTP.FmL : Return mPicPath & mPicFmL & "/"
            Case ePicFTP.Person : Return mPicPath & mPicPs & "/"
                '   Case ePicFTP.FmHomedD : Return mPicPath & mPicHomeD & "/"
                '   Case ePicFTP.FmPerC : Return mPicPath & mPicPersC & "/"
                '   Case ePicFTP.FmBankAccount : Return mPicPath & mPicFmBankAccount & "/"
            Case ePicFTP.Slip : Return mPicPath & mPicSlip & "/"
            Case ePicFTP.Receipt : Return mPicPath & mPicReceipt & "/"
            Case ePicFTP.SstkPd : Return mPicPath & mPicSstkPd & "/"
            Case ePicFTP.SstkTon : Return mPicPath & mPicSstkTon & "/"
            Case ePicFTP.PdPd : Return mPicPath & mPicPdPd & "/"
            Case ePicFTP.PdTon : Return mPicPath & mPicPdTon & "/"
            Case ePicFTP.PdLabel : Return mPicPath & mPicPdLabel & "/"
            Case ePicFTP.PdPackage : Return mPicPath & mPicPdPackage & "/"
                '   Case ePicFTP.PersonCard : Return mPicPath & mPicPsCard & "/"
            Case ePicFTP.BookBankComp : Return mPicPath & mPicBookBank & "/"
            Case ePicFTP.PdArtWork : Return mPicPath & mPicPdArtWork & "/"
            Case ePicFTP.PdSeeds : Return mPicPath & mPicPdSeeds & "/"
            Case ePicFTP.tmpArtwork : Return mPicPath & "pTmpArtwork" & "/"
            Case ePicFTP.tmpPackage : Return mPicPath & "pTmpPackage" & "/"
            Case ePicFTP.tmpCus : Return mPicPath & "pTmpCus" & "/"
            Case Else : Return Nothing
        End Select
    End Function
    Public Function mdPicPathClient(ByVal aPic As ePicPath) As String
        Dim vPath As String = ""
        Select Case aPic
            ' Case ePicPath.Fm : vPath = sPicPathClient & mPicFm & "\"
            ' Case ePicPath.FmL : vPath = sPicPathClient & mPicFmL & "\"
            Case ePicPath.Ps : vPath = sPicPathClient & mPicPs & "\"
                'Case ePicPath.HomeDoc : vPath = sPicPathClient & mPicHomeD & "\"
                'Case ePicPath.PersCard : vPath = sPicPathClient & mPicPersC & "\"
                'Case ePicPath.FmBankAccount : vPath = sPicPathClient & mPicFmBankAccount & "\"
            Case ePicPath.Slip : vPath = sPicPathClient & mPicSlip & "\"
            Case ePicPath.Receipt : vPath = sPicPathClient & mPicReceipt & "\"
            Case ePicPath.SstkPd : vPath = sPicPathClient & mPicSstkPd & "\"
            Case ePicPath.SstkTon : vPath = sPicPathClient & mPicSstkTon & "\"
            Case ePicPath.PdPd : vPath = sPicPathClient & mPicPdPd & "\"
            Case ePicPath.PdTon : vPath = sPicPathClient & mPicPdTon & "\"
            Case ePicPath.PdLabel : vPath = sPicPathClient & mPicPdPd & "\"
            Case ePicPath.PdPackage : vPath = sPicPathClient & mPicPdTon & "\"
                '   Case ePicPath.PsCard : vPath = sPicPathClient & mPicPsCard & "\"
            Case ePicPath.BookBankComp : vPath = sPicPathClient & mPicBookBank & "\"
        End Select
        mdPathChkAndCreate(vPath)
        Return vPath
    End Function
    Public Sub mdPicSet(ByVal aFtp As ePicFTP, ByVal aClient As ePicPath, ByVal aPtb As PictureBox, ByVal aId As String)
        mdLoadShow()
        Dim vPathC As String = mdPicPathClient(aClient) & aId & ".jpg"
        If mdFileChk(vPathC) = False Then
            Dim vPathF As String = mdPicPathFTP(aFtp)
            If ftpDown(vPathF & aId & ".jpg", vPathC) = True Then
                aPtb.Image = Image.FromFile(vPathC)
            Else
                aPtb.Image = Nothing
            End If
        Else
            aPtb.Image = Image.FromFile(vPathC)
        End If

        '  If mdFileChk(vPathC) = True Then aPtb.Image = Image.FromFile(vPathC)
        mdLoadCommitt()
    End Sub
    Public Function mdPicDownToClient(ByVal aFtp As ePicFTP, ByVal aClient As ePicPath, ByVal aId As String) As Boolean
        mdLoadShow()
        Dim vPathC As String = mdPicPathClient(aClient) & aId & ".jpg"
        If mdFileChk(vPathC) = False Then
            Dim vPathF As String = mdPicPathFTP(aFtp)
            If ftpDown(vPathF & aId & ".jpg", vPathC) = True Then Return True
        Else
            Return True
        End If
        Return False
        mdLoadCommitt()
    End Function

    Public Sub mdPathChkAndCreate(ByVal aPath As String)
        'Dim vDir2 As System.IO.Directory
        If Directory.Exists(aPath) = False Then
            Directory.CreateDirectory(aPath)
        End If
    End Sub

    Public Sub mdPathTmpDelete()
        ' Dim vDir As System.IO.Directory
        If Directory.Exists(sPicPathClient) = True Then
            Try
                Directory.Delete(sPicPathClient, True)
            Catch
            End Try
        End If
        If Directory.Exists("C:\GrSystemTemp") = True Then
            Try
                Directory.Delete("C:\GrSystemTemp", True)
            Catch
            End Try
        End If
    End Sub

    Public Function mdFileChk(ByVal aPath As String) As Boolean
        ' Dim vFile As System.IO.File
        Return File.Exists(aPath)
    End Function

#End Region

#Region "User"
    Public Sub mdUserChk(ByVal ParamArray aObj() As Object)
        If sUser = "user" Then
            For Each vObj As Object In aObj
                vObj.Enabled = False
            Next
        End If
    End Sub
    Public Sub mdUserSetData(ByRef aId As Object, ByRef aCode As Object, ByRef aName As Object)
        aId = sPsId
        aCode = sPsCode
        aName = sPsName
    End Sub
    Public Sub mdUserSetData(ByRef aId As Object, ByRef aCodeName As Object)
        aId = sPsId
        aCodeName = sPsCode & " : " & sPsName
    End Sub
    Public Sub mdUserSetData(ByRef aTxt As TextBox)
        aTxt.Tag = sPsId
        aTxt.Text = sPsCode & " : " & sPsName
    End Sub
    Public Sub mdUserSetData(ByRef aLbl As Label)
        aLbl.Tag = sPsId
        aLbl.Text = sPsCode & " : " & sPsName
    End Sub
    Public Function mdPsPrint() As String
        Return "ผู้สั่งพิมพ์เอกสาร : " & sPsName
    End Function
#End Region


#Region "Ua"

    Public Sub mdUaSystemSetCmbAndDgv(ByRef aCmb As ComboBox, ByRef aDgv As DataGridView)
        mdLoadShow()
        Dim mDtSystem As New DataTable
        With mDtSystem
            .Columns.Add("sCode")
            .Columns.Add("sName")
            For i As Integer = 1 To 10
                .Rows.Add()
            Next
            .Rows(0).Item("sCode") = "Pd"
            .Rows(0).Item("sName") = "ระบบการผลิต"
            .Rows(1).Item("sCode") = "Ss"
            .Rows(1).Item("sName") = "ระบบคลังเมล็ด"
            .Rows(2).Item("sCode") = "Sh"
            .Rows(2).Item("sName") = "ระบบโสหุ้ย"
            .Rows(3).Item("sCode") = "Rs"
            .Rows(3).Item("sName") = "ระบบวิจัย"
            .Rows(4).Item("sCode") = "Ct"
            .Rows(4).Item("sName") = "ระบบส่วนกลาง"
            .Rows(5).Item("sCode") = "Sl"
            .Rows(5).Item("sName") = "ระบบขายสินค้า"
            .Rows(6).Item("sCode") = "Old"
            .Rows(6).Item("sName") = "ระบบข้อมูลผลิตเดิม"
            .Rows(7).Item("sCode") = "Fn"
            .Rows(7).Item("sName") = "ระบบการเงิน"
            .Rows(8).Item("sCode") = "Sv"
            .Rows(8).Item("sName") = "ระบบบริการ"
            .Rows(9).Item("sCode") = "all"
            .Rows(9).Item("sName") = "ทั้งหมด"

            lbrDb.CmbSetData(aCmb, "sName", "sCode", mDtSystem)

            Dim vDtSystem As New DataTable
            lbrDb.DtSet("Select * From MenuData Order By MenuName", vDtSystem)
            lbrDb.SetDataInDgv("MenuCode,MenuName", aDgv, vDtSystem)

            aCmb.SelectedValue = "all"
            mdUaDgvSystemSet(aCmb.SelectedValue, aDgv)
            mdLoadCommitt()
        End With
    End Sub
    Public Sub mdUaDgvSystemSet(ByVal aSystemCode As String, ByVal aDgv As DataGridView)
        For Each iDgvr As DataGridViewRow In aDgv.Rows
            If mdUaSpliteMenuCode(iDgvr.Cells("MenuCode").Value) <> aSystemCode And aSystemCode <> "all" Then
                iDgvr.Visible = False
            Else
                iDgvr.Visible = True
            End If
        Next
    End Sub
    Public Function mdUaSpliteMenuCode(ByVal aMenuCode As String) As String
        Return aMenuCode.Substring(0, aMenuCode.Length - 3)
    End Function

#End Region

    Enum eMailType
        SeedsStore
        SeedsPay
        Sale
        Test
    End Enum
    Public Function mdMailAddressTo(ByVal aMailType As eMailType) As String
        Dim vResult As String = "anawaya@hotmail.co.th:kittiponggreen@gmail.com:chatchaav@hotmail.com"
        ' If aMailType <> eMailType.SeedsStore Then vResult &= ":kittiponggreen@gmail.com:chatchaav@hotmail.com"   boonsong@advanceseeds.com
        Select Case sCompbId
            Case 1 'Flotech
                vResult &= ":chayapatt@flotechseeds.com:paween@flotechseeds.com:paweenteps@gmail.com:kanokwan@flotechseeds.com"
                Select Case aMailType
                    Case eMailType.SeedsStore : vResult &= ":anuwat_seeds@grseeds.com:nui_2311@grseeds.com:rattikarn@flotechseeds.com"
                    Case eMailType.Sale : vResult &= ":boonsong@advanceseeds.com:peek_pee88@advanceseeds.com"
                    Case eMailType.Test : vResult = "bomber@flotechseeds.com"
                End Select
            Case 2 'Green
                Select Case aMailType
                    Case eMailType.SeedsStore : vResult &= ":supachai_gr@grseeds.com:wissanu_gr@grseeds.com:peeraporn19@grseeds.com:niramon_tik@hotmail.com:nui_2311@grseeds.com"  'phaiwan_jo@grseeds.com:
                    Case eMailType.Sale : vResult &= ":boonsong@advanceseeds.com:peek_pee88@advanceseeds.com"
                    Case eMailType.SeedsPay : vResult &= ":supachai_gr@grseeds.com:phaiwan_jo@grseeds.com"
                End Select
        End Select
        Return vResult
    End Function
    Public Function mdCrpToPdf(ByVal aModule As String, ByVal aRtp As Object, ByVal aName As String) As String
        Dim vPath As String = sPicPathClient & "PDF\" & aModule
        mdPathChkAndCreate(vPath)
        vPath &= "\" & aName & ".pdf"
        Try
            Dim crExportFile As CrystalDecisions.Shared.ExportOptions
            Dim crDiskFileDisetinationOptions As New CrystalDecisions.Shared.DiskFileDestinationOptions
            Dim crFormatTypePdf As New CrystalDecisions.Shared.PdfRtfWordFormatOptions

            crDiskFileDisetinationOptions.DiskFileName = vPath   '\POP\" & mCode & "
            crExportFile = aRtp.ExportOptions
            With crExportFile
                .ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                .ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
                .DestinationOptions = crDiskFileDisetinationOptions
                .FormatOptions = crFormatTypePdf
            End With
            aRtp.Export()
            Return vPath
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "From System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
        '*****Open File.pdf******
        'Dim Proc As New System.Diagnostics.Process
        'Proc.StartInfo.WorkingDirectory = "C:\"
        'Proc.StartInfo.FileName = "File.pdf"
        'Proc.Start()
        '***********Delet File.pdf********
        'Dim Flie As IO.FileInfo = New IO.FileInfo("c:\File.pdf")
        'Flie.Delete()
    End Function
    Function CheckDigitOnly(ByVal index As Integer) As Boolean
        Select Case index
            Case 47 To 58 ' เลข 0 - 9
                CheckDigitOnly = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                CheckDigitOnly = False
            Case Else
                CheckDigitOnly = True
                lbrMsg.MsgWarning("สามารถกรอกข้อมูลได้แค่ตัวเลข")
        End Select
    End Function
    Public Sub mdDgvConvertNumberFormat(ByVal dgv As DataGridView, ByVal column As DataGridViewTextBoxColumn)
        For Each vDgr As DataGridViewRow In dgv.Rows
            If vDgr.Cells(column.Name).Value IsNot DBNull.Value Then
                vDgr.Cells(column.Name).Value = ksbStringToDate(vDgr.Cells(column.Name).Value)
            End If
        Next
    End Sub
    Public Sub mdDgvConvertNumberFormat(ByVal dgv As DataGridView, ByVal column As String)
        For i As Integer = 0 To dgv.Rows.Count - 1
            Dim pay As Double = dgv.Rows(i).Cells(column).Value
            dgv.Rows(i).Cells(column).Value = FormatNumber(dgv.Rows(i).Cells(column).Value, , TriState.True)
        Next
    End Sub
    Public Function mdCnOpenQueryIdentity(ByVal query As String) As Integer
        Dim query2 As String = "Select @@Identity"
        Dim ID As Integer
        Dim connect As String = My.Settings.cnSPM  'conStr
        Dim ans As String = ""
        Try
            sCn = New SqlConnection
            With sCn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = My.Settings.cnSPM   ' conStr
                .Open()
            End With

            Using conn As New SqlConnection(connect)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = query2
                    ID = cmd.ExecuteScalar()
                End Using
            End Using
            Return ID
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Sub mdConvertDateInGrid(ByVal dgv As DataGridView, ByVal column As DataGridViewTextBoxColumn)
        For Each vDgr As DataGridViewRow In dgv.Rows
            If vDgr.Cells(column.Name).Value IsNot DBNull.Value Then
                vDgr.Cells(column.Name).Value = ksbStringToDate(vDgr.Cells(column.Name).Value)
            End If
        Next
    End Sub

    'Public Sub mdSlSetDoc(ByVal idsend As String)
    '    Dim sDt As New DataTable
    '    Dim ScreenData As String = ""
    '    Dim DocName As String = ""
    '    Dim Docnumber As Integer = 0
    '    mdCnOpen()
    '    sCommand.CommandText = "Select  SST.idCus , SST.idPsSend, SST.AddressFrom, SST.AddressTo, SST.idComp, SST.DateRec, SST.DateSend, STD.Transport, P.PsName AS PsSet, P2.PsName AS PsSend " & _
    '                           "From dbo.SmSendTs AS SST LEFT OUTER JOIN dbo.SmTransportD AS STD ON SST.idTS = STD.idTS LEFT OUTER JOIN dbo.vPerson AS P ON P.idPs = SST.idPsSet LEFT OUTER JOIN dbo.vPerson AS P2 ON P2.idPs = SST.idPsSend Where SST.idSend = '" & idsend & "'"
    '    sAdapter.Fill(sDt)
    '    Dim idCus As String = sDt.Rows(0).Item("idCus")
    '    Dim idPs As String = sDt.Rows(0).Item("idPsSend")

    '    Dim sDt2 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select CusNameCon,CusName_ " & _
    '                           "From vCustomer Where idCus = '" & idCus & "'"
    '    sAdapter.Fill(sDt2)

    '    Dim sDt3 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select PsName " & _
    '                           "From vPerson Where idPs = '" & idPs & "'"
    '    sAdapter.Fill(sDt3)

    '    Dim sDt_Comp As New DataTable
    '    mdCnOpen2()
    '    sCommand.CommandText = "Select Address, Tel, Fax, CompName " & _
    '                           "From dCompany Where idComp = '" & sIdComp & "'"
    '    sAdapter.Fill(sDt_Comp)
    '    Dim sDt5 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select idSale " & _
    '                           "From SmSendDt Where idSend = '" & idsend & "'"
    '    sAdapter.Fill(sDt5)

    '    ScreenData = "(0"
    '    For i As Integer = 0 To sDt5.Rows.Count - 1
    '        ScreenData += "," + sDt5.Rows(i).Item("idSale").ToString
    '    Next
    '    ScreenData += ")"

    '    Dim dItemSet As New DataTable
    '    dItemSet.Clear()
    '    mdCnOpen()
    '    sCommand.CommandText = "Select Pd.PdPkName,SUM(SsD.Amount) AS Amount, Pd.PkUnitName  "
    '    sCommand.CommandText += "From dbo.SmSaleDt AS SsD LEFT OUTER JOIN dbo.vPackingPdSet AS Pd ON SsD.idPdPk = Pd.idPdPk "
    '    sCommand.CommandText += "WHERE (SsD.idSale IN " + ScreenData + ") GROUP BY SsD.idPdPk ,Pd.PdPkName, Pd.PkUnitName "
    '    dItemSet.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))

    '    sAdapter.Fill(dItemSet)

    '    Dim sDt1 As New DataTable
    '    sCommand.CommandText = "Select DocCode " & _
    '                            "From SmSaleMt Where (idSale IN " + ScreenData + ")"
    '    sAdapter.Fill(sDt1)
    '    Docnumber = sDt1.Rows.Count
    '    DocName = sDt1.Rows(0).Item("DocCode").ToString
    '    For i As Integer = 1 To sDt1.Rows.Count - 1
    '        DocName += "," + sDt1.Rows(i).Item("DocCode").ToString
    '    Next


    '    Dim URL As String = "http://" & sHost & "/spm/Center/Logo/" & sIdComp & ".jpg"
    '    Dim client As New System.Net.WebClient
    '    Dim buffer As Byte()
    '    Dim pic() As Byte

    '    Try
    '        buffer = client.DownloadData(URL)
    '        Dim stream As New System.IO.MemoryStream(buffer)
    '        Dim binReader As New IO.BinaryReader(stream)
    '        pic = binReader.ReadBytes(stream.Length)
    '        dItemSet.Rows(0).Item("picComp") = pic
    '    Catch ex As Exception
    '        MessageBox.Show("Error")
    '    End Try

    '    Dim vFrm As New FrmReportView
    '    Dim vRpt As New crpSlSet
    '    vRpt.SetDataSource(dItemSet)

    '    vRpt.SetParameterValue(vRpt.Parameter_CompNameHead.ParameterFieldName, sDt_Comp.Rows(0).Item("CompName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_AddressCompHead.ParameterFieldName, sDt_Comp.Rows(0).Item("Address"))
    '    vRpt.SetParameterValue(vRpt.Parameter_Telhead.ParameterFieldName, sDt_Comp.Rows(0).Item("Tel"))
    '    vRpt.SetParameterValue(vRpt.Parameter_Faxhead.ParameterFieldName, sDt_Comp.Rows(0).Item("Fax"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, sDt_Comp.Rows(0).Item("CompName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsSentName.ParameterFieldName, sDt3.Rows(0).Item("PsName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompAddress.ParameterFieldName, sDt.Rows(0).Item("AddressFrom"))

    '    vRpt.SetParameterValue(vRpt.Parameter_DocNameSet.ParameterFieldName, DocName)
    '    vRpt.SetParameterValue(vRpt.Parameter_NumTs.ParameterFieldName, Docnumber)

    '    vRpt.SetParameterValue(vRpt.Parameter_Datesend.ParameterFieldName, ksbStringToDate(sDt.Rows(0).Item("DateSend")))
    '    vRpt.SetParameterValue(vRpt.Parameter_Daterec.ParameterFieldName, ksbStringToDate(sDt.Rows(0).Item("DateRec")))
    '    vRpt.SetParameterValue(vRpt.Parameter_ts.ParameterFieldName, sDt.Rows(0).Item("Transport"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsSet.ParameterFieldName, sDt.Rows(0).Item("PsSet"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsSend.ParameterFieldName, sDt.Rows(0).Item("PsSend"))

    '    vRpt.SetParameterValue(vRpt.Parameter_CompRecName.ParameterFieldName, sDt2.Rows(0).Item("CusName_"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsRecName.ParameterFieldName, sDt2.Rows(0).Item("CusNameCon"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompRecAddress.ParameterFieldName, sDt.Rows(0).Item("AddressTo"))

    '    vFrm.crView.ReportSource = vRpt
    '    vFrm.Show()


    'End Sub
    'Public Sub mdSlSendDoc(ByVal idsend As String)
    '    Dim sDt As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select  idCus, idPsSend, AddressFrom, AddressTo, idComp " & _
    '                           "From SmSendTs Where idSend = '" & idsend & "'"
    '    sAdapter.Fill(sDt)
    '    Dim idCus As String = sDt.Rows(0).Item("idCus")
    '    Dim idPs As String = sDt.Rows(0).Item("idPsSend")

    '    Dim sDt2 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select CusNameCon,CusName_ " & _
    '                           "From vCustomer Where idCus = '" & idCus & "'"
    '    sAdapter.Fill(sDt2)

    '    Dim sDt3 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select PsName " & _
    '                           "From vPerson Where idPs = '" & idPs & "'"
    '    sAdapter.Fill(sDt3)

    '    Dim sDt4 As New DataTable
    '    mdPOP_Connect()
    '    sCommand.CommandText = "Select CompName " & _
    '                           "From dCompany Where idComp = '" & sIdComp & "'"
    '    sAdapter.Fill(sDt4)

    '    '--------------------------ออกใบปะสินค้า-----------------------------'
    '    Dim vFrm As New FrmReportView
    '    Dim vRpt As New crpSlSend
    '    vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, sDt4.Rows(0).Item("CompName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsSentName.ParameterFieldName, sDt3.Rows(0).Item("PsName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompAddress.ParameterFieldName, sDt.Rows(0).Item("AddressFrom"))


    '    vRpt.SetParameterValue(vRpt.Parameter_CompRecName.ParameterFieldName, sDt2.Rows(0).Item("CusName_"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsRecName.ParameterFieldName, sDt2.Rows(0).Item("CusNameCon"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompRecAddress.ParameterFieldName, sDt.Rows(0).Item("AddressTo"))

    '    vFrm.crView.ReportSource = vRpt
    '    vFrm.Show()
    'End Sub


    'Public Sub ShowcrpSlSet(ByVal idsend As String)
    '    Dim sDt As New DataTable
    '    Dim ScreenData As String = ""
    '    Dim DocName As String = ""
    '    Dim Docnumber As Integer = 0
    '    mdCnOpen()
    '    sCommand.CommandText = "Select  SST.idCus , SST.idPsSend, SST.AddressFrom, SST.AddressTo, SST.idComp, SST.DateRec, SST.DateSend, STD.Transport, P.PsName AS PsSet, P2.PsName AS PsSend " & _
    '                           "From dbo.SmSendTs AS SST LEFT OUTER JOIN dbo.SmTransportD AS STD ON SST.idTS = STD.idTS LEFT OUTER JOIN dbo.vPerson AS P ON P.idPs = SST.idPsSet LEFT OUTER JOIN dbo.vPerson AS P2 ON P2.idPs = SST.idPsSend Where SST.idSend = '" & idsend & "'"
    '    sAdapter.Fill(sDt)
    '    Dim idCus As String = sDt.Rows(0).Item("idCus")
    '    Dim idPs As String = sDt.Rows(0).Item("idPsSend")

    '    Dim sDt2 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select CusNameCon,CusName_ " & _
    '                           "From vCustomer Where idCus = '" & idCus & "'"
    '    sAdapter.Fill(sDt2)

    '    Dim sDt3 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select PsName " & _
    '                           "From vPerson Where idPs = '" & idPs & "'"
    '    sAdapter.Fill(sDt3)

    '    Dim sDt_Comp As New DataTable
    '    mdCnOpen2()
    '    sCommand.CommandText = "Select Address, Tel, Fax, CompName " & _
    '                           "From dCompany Where idComp = '" & sIdComp & "'"
    '    sAdapter.Fill(sDt_Comp)
    '    Dim sDt5 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select idSale " & _
    '                           "From SmSendDt Where idSend = '" & idsend & "'"
    '    sAdapter.Fill(sDt5)

    '    ScreenData = "(0"
    '    For i As Integer = 0 To sDt5.Rows.Count - 1
    '        ScreenData += "," + sDt5.Rows(i).Item("idSale").ToString
    '    Next
    '    ScreenData += ")"

    '    Dim dItemSet As New DataTable
    '    dItemSet.Clear()
    '    mdCnOpen()
    '    sCommand.CommandText = "Select Pd.PdPkName,SUM(SsD.Amount) AS Amount, Pd.PkUnitName  "
    '    sCommand.CommandText += "From dbo.SmSaleDt AS SsD LEFT OUTER JOIN dbo.vPackingPdSet AS Pd ON SsD.idPdPk = Pd.idPdPk "
    '    sCommand.CommandText += "WHERE (SsD.idSale IN " + ScreenData + ") GROUP BY SsD.idPdPk ,Pd.PdPkName, Pd.PkUnitName "
    '    dItemSet.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))

    '    sAdapter.Fill(dItemSet)

    '    Dim sDt1 As New DataTable
    '    sCommand.CommandText = "Select DocCode " & _
    '                            "From SmSaleMt Where (idSale IN " + ScreenData + ")"
    '    sAdapter.Fill(sDt1)
    '    Docnumber = sDt1.Rows.Count
    '    DocName = sDt1.Rows(0).Item("DocCode").ToString
    '    For i As Integer = 1 To sDt1.Rows.Count - 1
    '        DocName += "," + sDt1.Rows(i).Item("DocCode").ToString
    '    Next


    '    Dim URL As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & sIdComp & ".jpg"
    '    Dim client As New System.Net.WebClient
    '    Dim buffer As Byte()
    '    Dim pic() As Byte

    '    Try
    '        buffer = client.DownloadData(URL)
    '        Dim stream As New System.IO.MemoryStream(buffer)
    '        Dim binReader As New IO.BinaryReader(stream)
    '        pic = binReader.ReadBytes(stream.Length)
    '        dItemSet.Rows(0).Item("picComp") = pic
    '    Catch ex As Exception
    '        MessageBox.Show("Error")
    '    End Try

    '    Dim vFrm As New FrmReportView
    '    Dim vRpt As New crpSlSet
    '    vRpt.SetDataSource(dItemSet)

    '    vRpt.SetParameterValue(vRpt.Parameter_CompNameHead.ParameterFieldName, sDt_Comp.Rows(0).Item("CompName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_AddressCompHead.ParameterFieldName, sDt_Comp.Rows(0).Item("Address"))
    '    vRpt.SetParameterValue(vRpt.Parameter_Telhead.ParameterFieldName, sDt_Comp.Rows(0).Item("Tel"))
    '    vRpt.SetParameterValue(vRpt.Parameter_Faxhead.ParameterFieldName, sDt_Comp.Rows(0).Item("Fax"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, sDt_Comp.Rows(0).Item("CompName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsSentName.ParameterFieldName, sDt3.Rows(0).Item("PsName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompAddress.ParameterFieldName, sDt.Rows(0).Item("AddressFrom"))

    '    vRpt.SetParameterValue(vRpt.Parameter_DocNameSet.ParameterFieldName, DocName)
    '    vRpt.SetParameterValue(vRpt.Parameter_NumTs.ParameterFieldName, Docnumber)

    '    vRpt.SetParameterValue(vRpt.Parameter_Datesend.ParameterFieldName, ksbStringToDate(sDt.Rows(0).Item("DateSend")))
    '    vRpt.SetParameterValue(vRpt.Parameter_Daterec.ParameterFieldName, ksbStringToDate(sDt.Rows(0).Item("DateRec")))
    '    vRpt.SetParameterValue(vRpt.Parameter_ts.ParameterFieldName, sDt.Rows(0).Item("Transport"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsSet.ParameterFieldName, sDt.Rows(0).Item("PsSet"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsSend.ParameterFieldName, sDt.Rows(0).Item("PsSend"))

    '    vRpt.SetParameterValue(vRpt.Parameter_CompRecName.ParameterFieldName, sDt2.Rows(0).Item("CusName_"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsRecName.ParameterFieldName, sDt2.Rows(0).Item("CusNameCon"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompRecAddress.ParameterFieldName, sDt.Rows(0).Item("AddressTo"))

    '    vFrm.crView.ReportSource = vRpt
    '    vFrm.Show()


    'End Sub

    'Public Sub ShowcrpSlSend(ByVal idsend As String)
    '    Dim sDt As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select  idCus, idPsSend, AddressFrom, AddressTo, idComp " & _
    '                           "From SmSendTs Where idSend = '" & idsend & "'"
    '    sAdapter.Fill(sDt)
    '    Dim idCus As String = sDt.Rows(0).Item("idCus")
    '    Dim idPs As String = sDt.Rows(0).Item("idPsSend")

    '    Dim sDt2 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select CusNameCon,CusName_ " & _
    '                           "From vCustomer Where idCus = '" & idCus & "'"
    '    sAdapter.Fill(sDt2)

    '    Dim sDt3 As New DataTable
    '    mdCnOpen()
    '    sCommand.CommandText = "Select PsName " & _
    '                           "From vPerson Where idPs = '" & idPs & "'"
    '    sAdapter.Fill(sDt3)

    '    Dim sDt4 As New DataTable
    '    mdCnOpen2()
    '    sCommand.CommandText = "Select CompName " & _
    '                           "From dCompany Where idComp = '" & sIdComp & "'"
    '    sAdapter.Fill(sDt4)

    '    '--------------------------ออกใบปะสินค้า-----------------------------'
    '    Dim vFrm As New FrmReportView
    '    Dim vRpt As New crpSlSend
    '    vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, sDt4.Rows(0).Item("CompName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsSentName.ParameterFieldName, sDt3.Rows(0).Item("PsName"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompAddress.ParameterFieldName, sDt.Rows(0).Item("AddressFrom"))


    '    vRpt.SetParameterValue(vRpt.Parameter_CompRecName.ParameterFieldName, sDt2.Rows(0).Item("CusName_"))
    '    vRpt.SetParameterValue(vRpt.Parameter_PsRecName.ParameterFieldName, sDt2.Rows(0).Item("CusNameCon"))
    '    vRpt.SetParameterValue(vRpt.Parameter_CompRecAddress.ParameterFieldName, sDt.Rows(0).Item("AddressTo"))

    '    vFrm.crView.ReportSource = vRpt
    '    vFrm.Show()
    'End Sub

    Public Function ShowCrpInvoice(ByVal idSale As String, ByVal status As Boolean) As DataTable
        Dim SumVAT As String
        Dim stSignPsSale As Integer = 0
        Dim stSignPsSet As Integer = 0
        Dim stSignPsSent As Integer = 0
        Dim AddressComp As String = ""
        Dim TelComp As String = ""
        Dim FaxComp As String = ""
        Dim TexCode As String = ""

        Dim dt As New DataTable
        mdCnOpen2()
        sCommand.CommandText = "Select c.Address, c.Tel, c.Fax, c.TaxCode, c.PostCode, p.ProvinceName, ISNULL(c.CompNameEng, '') As CompNameEng " & _
                               "From dCompany c LEFT OUTER JOIN dProvinceFix p ON c.idProvince = p.idProvince Where idComp='" & sIdComp & "'"
        sAdapter.Fill(dt)
        AddressComp = dt.Rows(0).Item("Address") & " จ." & dt.Rows(0).Item("ProvinceName") & dt.Rows(0).Item("PostCode")
        If IsDBNull(Trim(dt.Rows(0).Item("Tel"))) Then
            TelComp = "-"
        Else
            TelComp = Trim(dt.Rows(0).Item("Tel"))
        End If

        If IsDBNull(dt.Rows(0).Item("Fax")) Then
            FaxComp = "-"
        Else
            FaxComp = Trim(dt.Rows(0).Item("Fax"))
        End If

        If IsDBNull(dt.Rows(0).Item("TaxCode")) Then
            TexCode = "-"
        Else
            TexCode = dt.Rows(0).Item("TaxCode")
        End If


        Dim MyTable As New DataTable
        MyTable.Clear()
        mdCnOpen()
        sCommand.CommandText = "Select m.idSale, m.DateTs, m.DateSale, m.DatePay, m.DocCode, m.DocRef, m.Total, " & _
                                "m.DiscountAmout, m.DiscountPerc, m.TotalNet, m.CusName, m.PsSent,  m.PsSale,  " & _
                                "m.PsTs,  m.PsSet, m.PaymentTerms,m.Transport, m.note, d.idPdPk, d.Amount, d.Price, " & _
                                "d.DiscountPerc as DisPerclist, p.PdPkName, d.PerBox, d.idPkUnit, u.PkUnitName, " & _
                                "p.PdCode, c.address, c.AddressS, c.Tel, c.Fax, v.CusNameCon_, " & _
                                "v.MobileCon, m.idPsSale, m.idTs, m.idPsSet, m.idPsSend FROM vSmSaleMt m " & _
                                "LEFT OUTER JOIN SmSaleDt d ON m.idSale = d.idSale LEFT OUTER JOIN " & _
                                "vPackingPdSet p ON d.idPdPk = p.idPdPk LEFT OUTER JOIN dCustomer c " & _
                                "ON m.idCus=c.idCus LEFT OUTER JOIN vCustomer v ON c.idCus = v.idCus " & _
                                "LEFT OUTER JOIN dPackingUnit u ON u.idPkUnit = d.idPkUnit WHERE m.idSale ='" & idSale & "'"

        MyTable.Columns.Add("picComp", System.Type.GetType("System.Byte[]"))
        MyTable.Columns.Add("picSignPsSale", System.Type.GetType("System.Byte[]"))
        MyTable.Columns.Add("picSignPsSet", System.Type.GetType("System.Byte[]"))
        MyTable.Columns.Add("picSignPsSent", System.Type.GetType("System.Byte[]"))
        MyTable.Columns.Add("AddressComp", System.Type.GetType("System.String"))
        MyTable.Columns.Add("TelComp", System.Type.GetType("System.String"))
        MyTable.Columns.Add("FaxComp", System.Type.GetType("System.String"))
        MyTable.Columns.Add("TexCode", System.Type.GetType("System.String"))
        sAdapter.Fill(MyTable)



        Dim URL As String = "http://" & sHost & sFtpPathMain & "Center/Logo/" & sIdComp & ".jpg"
        Dim client As New System.Net.WebClient
        Dim buffer As Byte()
        Dim pic() As Byte

        Try
            buffer = client.DownloadData(URL)
            Dim stream As New System.IO.MemoryStream(buffer)
            Dim binReader As New IO.BinaryReader(stream)
            pic = binReader.ReadBytes(stream.Length)
            For i As Integer = 0 To MyTable.Rows.Count - 1
                MyTable.Rows(i).Item("picComp") = pic
            Next

        Catch ex As Exception
            ' Noimage
        End Try

        '---sign PsSale Pic---'
        Dim URL2 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & MyTable.Rows(0).Item("idPsSale") & ".png"
        'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
        Try
            buffer = client.DownloadData(URL2)
            Dim stream As New System.IO.MemoryStream(buffer)
            Dim binReader As New IO.BinaryReader(stream)
            pic = binReader.ReadBytes(stream.Length)
            For i As Integer = 0 To MyTable.Rows.Count - 1
                MyTable.Rows(i).Item("picSignPsSale") = pic
            Next

        Catch ex As Exception
            stSignPsSale = 1
            ' Noimage
        End Try

        '---sign PsSet Pic---'
        If IsDBNull(MyTable.Rows(0).Item("idPsSet")) Then
            stSignPsSet = 1
        ElseIf MyTable.Rows(0).Item("idPsSet") = Nothing Then
            stSignPsSet = 1
        Else
            Dim URL3 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & MyTable.Rows(0).Item("idPsSet") & ".png"
            'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
            Try
                buffer = client.DownloadData(URL3)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                For i As Integer = 0 To MyTable.Rows.Count - 1
                    MyTable.Rows(i).Item("picSignPsSet") = pic
                Next
            Catch ex As Exception
                stSignPsSet = 1
                ' Noimage
            End Try

        End If

        '---sign PsSent Pic---'
        If IsDBNull(MyTable.Rows(0).Item("idPsSend")) Then
            stSignPsSent = 1
        ElseIf MyTable.Rows(0).Item("idPsSend") = Nothing Then
            stSignPsSent = 1
        Else
            Dim URL4 As String = "http://" & sHost & sFtpPathMain & "images/eSign/" & MyTable.Rows(0).Item("idPsSend") & ".png"
            'Dim URL2 As String = "http://siamadvancehost.com/spm/images/eSign/1.png"
            Try
                buffer = client.DownloadData(URL4)
                Dim stream As New System.IO.MemoryStream(buffer)
                Dim binReader As New IO.BinaryReader(stream)
                pic = binReader.ReadBytes(stream.Length)
                For i As Integer = 0 To MyTable.Rows.Count - 1
                    MyTable.Rows(i).Item("picSignPsSend") = pic
                Next

            Catch ex As Exception
                stSignPsSent = 1
                ' Noimage
            End Try

        End If

        For i As Integer = 0 To MyTable.Rows.Count - 1
            MyTable.Rows(i).Item("DateTs") = ksbStringToDate(MyTable.Rows(i).Item("DateTs"))
            MyTable.Rows(i).Item("DateSale") = ksbStringToDate(MyTable.Rows(i).Item("DateSale"))
            MyTable.Rows(i).Item("DatePay") = ksbStringToDate(MyTable.Rows(i).Item("DatePay"))
            MyTable.Rows(i).Item("AddressComp") = AddressComp
            MyTable.Rows(i).Item("TelComp") = TelComp
            MyTable.Rows(i).Item("FaxComp") = FaxComp
            MyTable.Rows(i).Item("TexCode") = TexCode

            If MyTable.Rows(i).Item("idTs") = 1 Then
                MyTable.Rows(i).Item("Transport") = "-"
            End If

            If IsDBNull(MyTable.Rows(i).Item("PerBox")) Then
                MyTable.Rows(i).Item("PerBox") = 1
            End If

            If MyTable.Rows(i).Item("idPkUnit") = 3 Then
                MyTable.Rows(i).Item("Price") = MyTable.Rows(i).Item("Price") * MyTable.Rows(i).Item("PerBox")
            End If

            If IsDBNull(MyTable.Rows(i).Item("DisPerclist")) Then
                MyTable.Rows(i).Item("DisPerclist") = 0
            End If
        Next
        SumVAT = 0

        If status = False Then
            Dim vFrm As New frmReportView
            Dim vRpt As New crpInvoice
            vRpt.SetDataSource(MyTable)
            vRpt.SetParameterValue(vRpt.Parameter_idSale.ParameterFieldName, idSale)
            vRpt.SetParameterValue(vRpt.Parameter_CompName.ParameterFieldName, sCompName)
            vRpt.SetParameterValue(vRpt.Parameter_CompNameEng.ParameterFieldName, dt.Rows(0).Item("CompNameEng"))
            ' vRpt.SetParameterValue(vRpt.Parameter_VAT.ParameterFieldName, SumVAT)
            vRpt.SetParameterValue(vRpt.Parameter_stSignPsSale.ParameterFieldName, stSignPsSale)
            'vRpt.SetParameterValue(vRpt.Parameter_stSignPsSet.ParameterFieldName, stSignPsSet)
            'vRpt.SetParameterValue(vRpt.Parameter_stSignPsSent.ParameterFieldName, stSignPsSent)
            'vRpt.SetParameterValue(vRpt.Parameter_PsPrint.ParameterFieldName, sPsName)
            vFrm.crView.ReportSource = vRpt
            vFrm.Show()
        End If

        Return MyTable
    End Function



    '************************ Function-InvLot : New System ************************'
    'Stock update
    Public Sub InvLotMainUpdate(ByVal UpdateType As Integer, ByVal idInvmain As Integer, ByVal idLot As Integer, ByVal Qty As Double, _
                                ByVal NoteType As String, ByVal idRef As Integer, ByVal RefSys As String, ByVal RefTable As String, _
                                ByVal LotNo As String, ByVal idWh As Integer, ByVal cCommand As SqlCommand)
        Dim sDt As New DataTable
        Dim dtAll As New DataTable
        Dim NewPdPkAmount As Double = 0.0
        Dim cAdapter = New SqlDataAdapter(cCommand)

        cCommand.CommandText = "SELECT Amount FROM dInvLotRefWh WHERE idLot =" & idLot & " AND idWh = " & idWh
        cAdapter.Fill(sDt)

        cCommand.CommandText = "SELECT Sum(Amount) As Amount FROM dInvLotRefWh WHERE idLot =" & idLot
        cAdapter.Fill(dtAll)

        If UpdateType = 1 Then 'เพิ่ม
            NewPdPkAmount = sDt.Rows(0).Item("Amount") + Qty

        ElseIf UpdateType = 2 Then 'ลด
            NewPdPkAmount = sDt.Rows(0).Item("Amount") - Qty

        ElseIf UpdateType = 3 Then 'เท่ากับ
            NewPdPkAmount = Qty

        End If

        '---Update new Amount into dLotMain & dInvLotRefWh ----'
        'cCommand.CommandText = "Update dInvLotmain Set idPsUpdate = '" & sPsId & "', DateUpdate = GETDATE() " & _
        '                       "WHERE idLot = " & idLot
        'cCommand.ExecuteNonQuery()

        cCommand.CommandText = "Update dInvLotRefWh Set Amount =" & NewPdPkAmount & " WHERE idLot = " & idLot & " AND idWh = " & idWh
        cCommand.ExecuteNonQuery()


        'StockCard-Inventory
        InvLotStockCard(UpdateType, idInvmain, idLot, Qty, dtAll.Rows(0).Item("Amount"), NoteType, idRef, RefSys, RefTable, LotNo, idWh, cCommand)
    End Sub

    'Stock Card
    Public Sub InvLotStockCard(ByVal CardType As Integer, ByVal idInvmain As Integer, ByVal idLot As Integer, ByVal Qty As Double, ByVal AmountOld As Double,
                                 ByVal NoteType As String, ByVal idRef As Integer, ByVal RefSys As String, ByVal RefTable As String,
                                 ByVal LotNo As String, ByVal idWh As Integer, ByVal xCommand As SqlCommand)
        Dim field_sql As String = ""
        Dim NewBalance As Double = 0.0
        Dim xAdapter = New SqlDataAdapter(xCommand)

        xCommand.CommandText = "Update dInvLotmain Set idPsUpdate = " & sPsId & ", DateUpdate = GETDATE() " & _
                              "WHERE idLot = " & idLot
        xCommand.ExecuteNonQuery()

        Dim dt As New DataTable
        xCommand.CommandText = "SELECT IsNULL(Sum(wh.Amount),0) As SumInv" & vbNewLine &
                                "FROM dInvLotRefWh wh" & vbNewLine &
                                "LEFT JOIN dInvLotMain lm  ON  wh.idLot = lm.idLot" & vbNewLine &
                                "Where lm.idInvMain = " & idInvmain & vbNewLine &
                                "AND lm.CompRec = (SELECT CompRec FROM dInvLotMain WHERE idLot = " & idLot & ")" & vbNewLine &
                                "AND lm.stDel Is NULL"
        xAdapter.Fill(dt)

        Select Case CardType
            Case 1 'เพิ่ม Stock
                field_sql = "QtyIn"
                NewBalance = AmountOld + Qty
            Case 2 'ลด Stock
                field_sql = "QtyOut"
                NewBalance = AmountOld - Qty
            Case 3 'Car old balancele
                field_sql = "QtyIn"
                NewBalance = Qty
        End Select

        '---insert dInvLotStockCard Table---'
        xCommand.CommandText = "Insert Into dInvLotStockCard(idInvMain, idLot, LotNo, idWh, typeTs, " & field_sql & ", QtyBalance, Note, idPsTs, " &
                               "DateTs, idRef, RefSys, RefTable, QtyBalInv) " &
                               "Values(" & idInvmain & ", " & idLot & ", '" & LotNo & "', " & idWh & ", " & CardType & ", " & CDbl(Qty) & ", " &
                               "" & NewBalance & ", '" & NoteType & "', " & sPsId & ", GETDATE(), " & idRef & ", '" & RefSys & "', '" & RefTable & "', " &
                               dt.Rows(0).Item("SumInv") & ")"
        xCommand.ExecuteNonQuery()
    End Sub


    '*************************** Function : Stock-Material ******************************'
    'Stock update
    Public Sub mdPdMixStockUpdate(ByVal UpdateType As Integer, ByVal idPdLot As Integer, ByVal AmountTs As Double,
                                 ByVal NoteType As String, ByVal idRef As Integer, ByVal cCommand As SqlCommand) 'AmounntTs:Kg
        Dim sDt As New DataTable
        Dim NewBalance As Double = 0.0
        Dim cAdapter = New SqlDataAdapter(cCommand)

        'mdCnOpen()
        cCommand.CommandText = "Select Amount From PkPdLotStock Where idPdLot = '" & idPdLot & "'"
        cAdapter.Fill(sDt)

        If UpdateType = 1 Then 'เพิ่ม
            NewBalance = sDt.Rows(0).Item("Amount") + AmountTs
        ElseIf UpdateType = 2 Then 'ลด
            NewBalance = sDt.Rows(0).Item("Amount") - AmountTs
        ElseIf UpdateType = 3 Then 'เท่ากับ
            NewBalance = AmountTs
        End If

        '---Update new Amount into PkPdLotStock----'
        cCommand.CommandText = "Update PkPdLotStock Set Amount =" & NewBalance & " Where idPdLot = '" & idPdLot & "'"
        cCommand.ExecuteNonQuery()

        'StockCard
        mdPdMixStockCard(UpdateType, idPdLot, AmountTs, NewBalance, NoteType, idRef, cCommand)
    End Sub

    'Stock Card
    Public Sub mdPdMixStockCard(ByVal CardType As Integer, ByVal idPdLot As Integer, ByVal AmountTs As Double, ByVal New_Balance As Double, ByVal NoteType As String,
                              ByVal idRef As Integer, ByVal xCommand As SqlCommand)
        Dim field_sql As String = ""

        If CardType = 1 Then 'เพิ่ม Stock
            field_sql = "AmountAdd"

        ElseIf CardType = 2 Then 'ลด Stock
            field_sql = "AmountCut"

        ElseIf CardType = 3 Then 'เท่ากับ Stock
            field_sql = "AmountAdd"

        End If

        '---insert PdMixStockCard Table---'
        xCommand.CommandText = "Insert Into PdMixStockCard(idLot, DateTs, " & field_sql & ", Balance, Note, idRef, idPsTs) " &
                               "Values('" & idPdLot & "', '" & ksbDateToString(Date.Today) & "', " &
                               "" & CDbl(AmountTs) & ", " & New_Balance & " , '" & NoteType & "', " &
                               "'" & idRef & "', '" & sPsId & "')"
        xCommand.ExecuteNonQuery()
    End Sub

    '*************************** Function : Stock-PdPk ******************************'
    'Stock update
    Public Sub mdPdPkLotStockUpdate(ByVal UpdateType As Integer, ByVal idPdPkLot As Integer, ByVal AmountTs As Integer, ByVal NoteType As String, ByVal idRef As Integer, ByVal xCommand As SqlCommand) 'AmounntTs:PkUnit
        Dim sDt As New DataTable
        Dim NewPdPkAmount As Integer = 0
        Dim xAdapter = New SqlDataAdapter(xCommand)
        'mdCnOpen()
        xCommand.CommandText = "Select Amount From dPackingPdSetLot Where idPdPkLot = " & idPdPkLot
        xAdapter.Fill(sDt)

        If UpdateType = 1 Then 'เพิ่ม
            NewPdPkAmount = sDt.Rows(0).Item("Amount") + AmountTs
        ElseIf UpdateType = 2 Then 'ลด
            NewPdPkAmount = sDt.Rows(0).Item("Amount") - AmountTs
        ElseIf UpdateType = 3 Then 'เท่ากับ
            NewPdPkAmount = AmountTs
        End If

        '---Update new Amount into PkPdLotStock----'
        xCommand.CommandText = "Update dPackingPdSetLot Set Amount =" & NewPdPkAmount & ", " &
                               "idPsUpdate = '" & sPsId & "', DateUpdate = '" & ksbDateToString(Date.Today) & "' " &
                               "Where idPdPkLot = " & idPdPkLot
        xCommand.ExecuteNonQuery()

        'call StockCard
        PdPkLotStockCard(UpdateType, idPdPkLot, AmountTs, NewPdPkAmount, NoteType, idRef, xCommand)
    End Sub

    'Stock Card
    Public Sub PdPkLotStockCard(ByVal CardType As Integer, ByVal idPdPkLot As Integer, ByVal AmountTs As Double, ByVal New_Balance As Double, ByVal NoteType As String, ByVal idRef As Integer, ByVal cCommand As SqlCommand)
        Dim field_sql As String = ""

        If CardType = 1 Then 'เพิ่ม Stock
            field_sql = "AmountAdd"

        ElseIf CardType = 2 Then 'ลด Stock
            field_sql = "AmountCut"
        ElseIf CardType = 3 Then 'เท่ากับ Stock
            field_sql = "AmountAdd"
        End If

        '---insert PdMixStockCard Table---'
        ' mdCnOpen()
        cCommand.CommandText = "Insert Into PdPkStockCard(idPdPkLot, DateTs, " & field_sql & " ,Balance, Note, idRef, idPsTs) " &
                               "Values('" & idPdPkLot & "', '" & ksbDateToString(Date.Today) & "', " &
                               "" & CDbl(AmountTs) & ", " & New_Balance & ", '" & NoteType & "', " &
                               "'" & idRef & "', '" & sPsId & "')"
        cCommand.ExecuteNonQuery()
    End Sub


    '*************************** Function : Stock-PdOther  ******************************'
    'Stock update
    Public Sub mdPdoLotStockUpdate(ByVal UpdateType As Integer, ByVal idPdoLot As Integer, ByVal AmountTs As Double, ByVal NoteType As String, ByVal idRef As Integer, ByVal xCommand As SqlCommand) 'AmounntTs:PkUnit
        Dim sDt As New DataTable
        Dim NewPdPkAmount As Double = 0.0
        Dim myAdapter = New SqlDataAdapter(xCommand)
        'mdCnOpen()
        xCommand.CommandText = "Select Amount From SmPdOtherDLot Where idPdOLot = " & idPdoLot
        myAdapter.Fill(sDt)

        If UpdateType = 1 Then 'เพิ่ม
            NewPdPkAmount = sDt.Rows(0).Item("Amount") + AmountTs
        ElseIf UpdateType = 2 Then 'ลด
            NewPdPkAmount = sDt.Rows(0).Item("Amount") - AmountTs
        ElseIf UpdateType = 3 Then 'เท่ากับ
            NewPdPkAmount = AmountTs
        End If

        '---Update new Amount into SmPdOtherDLot----'
        xCommand.CommandText = "Update SmPdOtherDLot Set Amount =" & NewPdPkAmount & ", " &
                               "idPsUpdate = '" & sPsId & "', DateUpdate = '" & ksbDateToString(Date.Today) & "' " &
                               "Where idPdOLot = " & idPdoLot
        xCommand.ExecuteNonQuery()

        'StockCard โครงสร้างเก่า
        PdPdoLotStockCard(UpdateType, idPdoLot, AmountTs, NewPdPkAmount, NoteType, idRef, xCommand)
    End Sub
    'Stock Card
    Public Sub PdPdoLotStockCard(ByVal CardType As Integer, ByVal idPdoLot As Integer, ByVal AmountTs As Double, ByVal New_Balance As Double, ByVal NoteType As String, ByVal idRef As Integer, ByVal xCommand As SqlCommand)
        Dim field_sql As String = ""

        If CardType = 1 Then 'เพิ่ม Stock
            field_sql = "AmountAdd"

        ElseIf CardType = 2 Then 'ลด Stock
            field_sql = "AmountCut"

        ElseIf CardType = 3 Then 'เท่ากับ Stock
            field_sql = "AmountAdd"

        End If

        '---insert PdoStockCard Table---'
        'mdCnOpen()
        xCommand.CommandText = "Insert Into SmPdOStockCrad(idLot, DateTs, " & field_sql & " ,Balance, Note, idRef, idPsTs) " &
                               "Values('" & idPdoLot & "', '" & ksbDateToString(Date.Today) & "', " &
                               "" & CDbl(AmountTs) & ", " & New_Balance & ", '" & NoteType & "', " &
                               "'" & idRef & "', '" & sPsId & "')"
        xCommand.ExecuteNonQuery()
    End Sub

    '************************** แจ้งเตือนรายการ Order ******************************'
    Public Sub mdAlertSaleOrder()
        Dim Result As DialogResult
        mdCore_Connect()
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT idUser FROM MenuUserPs WHERE idPs = " & sPsId & ""
        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            Exit Sub 'End Check Process : No Permission
        Else
            Dim sDt2 As New DataTable
            sDt2.Clear()
            sCommand.CommandText = "SELECT * FROM MenuUserSet WHERE idUser = " & sDt.Rows(0).Item("idUser") & " " & _
                                   "AND MenuCode = 'Sts032'"
            sAdapter.Fill(sDt2)
            If sDt2.Rows.Count = 0 Then
                Exit Sub 'End Check Process : No Permission
            Else ' has Permission Of OrderToSale
                mdCnOpen()
                Dim sDt3 As New DataTable
                sDt3.Clear()
                sCommand.CommandText = "SELECT COUNT(idsaleOrderDt) As NumOfOrder FROM SmSaleOrderDt dt LEFT OUTER JOIN SmSaleOrderMt mt " & _
                                       "ON dt.idSaleOrder = mt.idSaleOrder WHERE mt.idpsCancel IS NULL " & _
                                       "AND dt.stAllSale IS NULL AND idComp = " & sIdComp & ""
                sAdapter.Fill(sDt3)
                If sDt3.Rows.Count > 0 Then
                    If sDt3.Rows(0).Item("NumOfOrder") > 0 Then
                        Result = MsgBox("มีรายการสั่งซื้อ (Order) ของ " & sCompName & vbCrLf & "รอการจัดการอยู่จำนวน " & Format(sDt3.Rows(0).Item("NumOfOrder"), "#,##0") & " รายการ", MsgBoxStyle.OkCancel)
                        If Result = Windows.Forms.DialogResult.OK Then
                            Dim vFrm As New frmSlOrderToSale(frmSlOrderToSale.eProcess.eNew, "", 0, 0, "")
                            vFrm.Show()
                        End If
                    End If
                End If 'End sDt3

            End If 'End sDt2
        End If 'End sDt1
    End Sub

    Public Function schGrid(ByVal txt As String, ByVal field() As String) As String
        Dim ar() As String = txt.Trim().Split(" ")
        Dim msg As String = ""
        Dim b As String = ""
        For Each fd As String In field
            Dim a As String = ""
            msg &= b & "("
            For Each tx As String In ar
                msg &= a & "[" & fd & "] LIKE '%" & tx & "%'"
                a = " AND "
            Next
            msg &= ")"
            b = " OR "
        Next
        Return msg
    End Function

    'Set CoboBox Compamy
    Public Sub setCmbGroupComp(ByVal cCombobox As Object)
        mdCnOpen2()
        Dim sDt As New DataTable

        If sIdGroupComp = 0 And sIdComp = 0 Then
            sCommand.CommandText = "SELECT (CASE parentid WHEN 0 THEN m.groupName ELSE c.CompName END) AS CompName, m.idcomp " & vbNewLine &
                                    "FROM dGroupCompMap m " & vbNewLine &
                                    "LEFT JOIN dCompany c On c.idComp = m.idcomp" & vbNewLine &
                                    "WHERE c.stDel Is NULL AND m.stActive = 1 AND m.parentid <> 0 "

        ElseIf sIdGroupComp <> 0 And sIdComp = 0 Then
            sCommand.CommandText = "SELECT (CASE parentid WHEN 0 THEN m.groupName ELSE c.CompName END) AS CompName, m.idcomp " & vbNewLine &
                                    "FROM dGroupCompMap m " & vbNewLine &
                                    "LEFT JOIN dCompany c On c.idComp = m.idcomp " & vbNewLine &
                                    "WHERE c.stDel Is NULL AND m.stActive = 1 AND m.parentid = " & sIdGroupComp
        Else
            sCommand.CommandText = "SELECT (CASE parentid WHEN 0 THEN m.groupName ELSE c.CompName END) AS CompName, m.idcomp " & vbNewLine &
                                   "FROM dGroupCompMap m " & vbNewLine &
                                   "LEFT JOIN dCompany c On c.idComp = m.idcomp " & vbNewLine &
                                   "WHERE c.stDel Is NULL AND m.stActive = 1 AND m.idcomp = " & sIdComp
        End If

        sAdapter.Fill(sDt)

        cCombobox.DataSource = sDt
        cCombobox.DisplayMember = "CompName"
        cCombobox.ValueMember = "idcomp"

        cCombobox.SelectedItem = 1

    End Sub

    Public Sub Ctrl_TabStop(ByRef MainCtrl As Control)
        Dim subCtrl() As Control
        Dim CtrlCnt As Integer = MainCtrl.Controls.Count
        Try
            ReDim subCtrl(CtrlCnt - 1)
            Dim CtrlNr As Integer = 0
            For Each mySubCtrl As Control In MainCtrl.Controls
                If mySubCtrl.Controls.Count > 0 Then Ctrl_TabStop(mySubCtrl)
                subCtrl(CtrlNr) = mySubCtrl
                CtrlNr = CtrlNr + 1
            Next

            Dim eoloop As Boolean = False
            Dim tmpCtrl As Control
            Do While (Not eoloop)
                eoloop = True
                For i As Integer = 1 To subCtrl.Length - 1
                    If Not (subCtrl(i) Is Nothing Or subCtrl(i - 1) Is Nothing) Then
                        If (subCtrl(i - 1).Top > subCtrl(i).Top) Or (subCtrl(i - 1).Top = subCtrl(i).Top And subCtrl(i - 1).Left > subCtrl(i).Left) Then
                            tmpCtrl = subCtrl(i)
                            subCtrl(i) = subCtrl(i - 1)
                            subCtrl(i - 1) = tmpCtrl
                            eoloop = False
                        End If
                    End If
                Next i
            Loop 'eoloop

            For i As Integer = 0 To CtrlCnt - 1
                If Not subCtrl(i) Is Nothing Then subCtrl(i).TabIndex = i
            Next i

            subCtrl(0).Focus()
        Catch ex As Exception
        End Try
    End Sub


End Module
