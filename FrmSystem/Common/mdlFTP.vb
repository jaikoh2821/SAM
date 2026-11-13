Imports System.Collections.Generic
Imports KsbLibrary.FTP

Imports System
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Text.ASCIIEncoding
Imports System.Net.Sockets
Imports System.Configuration
Imports System.Resources
Module mdlFTP
    Public sFTP As FTPclient
    Public sEmPath As String
    Public sScanPath As String


    'new for check connectAble


    Private clientSocket As Socket = Nothing


    '------------------
    Public Sub ftpPicList(ByVal aLV As ListView)
        Dim vDir As New FTPdirectory("spm", "/images/pSlSelect/")
        Dim vFileName As String
        For Each vf As FTPfileInfo In vDir.GetFiles()
            If (vf.Extension = ".jpg") Then
                vFileName = vf.FullName
                'vf.MoveTo(vFileName.Substring(0, vFileName.Length - 4) & ".jpg")
            End If
        Next

        'Dim dir As New DirectoryInfo("C:\Temp")
        'Dim fileName As String
        'For Each f As FileInfo In dir.GetFiles
        '    If (f.Extension = ".txt") Then
        '        fileName = f.FullName
        '        f.MoveTo(fileName.Substring(0, fileName.Length - 4) & ".text")
        '    End If
        'Next

    End Sub
    Public Sub ftpCon(ByVal argHostname As String, ByVal argUser As String, ByVal argPassword As String) 
        sFTP = New FTPclient(argHostname, argUser, argPassword)
        sFTP.Hostname = argHostname
        sFTP.Username = argUser
        sFTP.Password = argPassword
    End Sub
    Public Function ftpDown(ByVal argHostFile As String, ByVal argSaveFile As String) As Boolean
        'download a file (permitting overwrite)
        'FTP.Download("/pub/ftpfile.bin", "C:\test\ftp\ftpfile.bin", True)

        Try
            sFTP.Download(argHostFile, argSaveFile, True)
            Return True
        Catch
            Return False
            '    '     lbrMsg.MsgError("มีการผิดพลาดในขั้นตอนการ Download รูป")
        End Try
    End Function
    Public Function ftpUp(ByVal argHostFile As String, ByVal argUpFile As String) As Boolean
        'upload a file
        Try
            Return sFTP.Upload(argUpFile, argHostFile)
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function ftpCheckFileExist(ByVal argInputFile As String) As Boolean
        If sFTP.FtpFileExists(argInputFile) Then Return True
    End Function
    Public Sub ftpRename(ByVal argOldName As String, ByVal argNewName As String)

        'rename a file
        sFTP.FtpRename(argOldName, argNewName)
    End Sub
    Public Sub ftpDel(ByVal argInputName As String)
        'delete a file
        sFTP.FtpDelete(argInputName)

    End Sub
    Public Sub ftpUser()

        'get a simple listing of the root directory /
        Dim result As List(Of String) = sFTP.ListDirectory("/")
        'display in console
        Console.WriteLine("Directory listing of /")
        For Each line As String In result
            Console.WriteLine(line)
        Next

        'Get the detailed directory listing of /pub/
        Dim dirList As FTPdirectory = sFTP.ListDirectoryDetail("/pub/")

        'filter out only the files in the list
        Dim filesOnly As FTPdirectory = dirList.GetFiles()

        'download these files
        For Each file As FTPfileInfo In filesOnly
            sFTP.Download(file, "C:\test\ftp\" & file.Filename, True)
        Next

    End Sub
    Public Function ftpCheckDirExist(ByVal argFolderName As String) As Boolean
        Dim found As Boolean

        Dim rootdir As FTPdirectory = sFTP.ListDirectoryDetail("/pub/")
        For Each dir As FTPfileInfo In rootdir.GetDirectories()
            If UCase(dir.NameOnly) = argFolderName Then
                'found it
                MsgBox("Target FTP Dir Status : Found ")
                found = True
                Exit For
            End If

        Next
        If found = True Then Return True Else Return False

    End Function
    Public Function ftpCheckDir(ByVal argDirForCheck As String) As Boolean

        Dim tmpRoot() As String = argDirForCheck.Split("/")

        'For i As Int16 = 0 To tmpRoot.Length - 1
        'MsgBox(tmpRoot(i))
        ' Next

        Dim getDir As String = tmpRoot(UBound(tmpRoot) - 1)
        Dim getRoot As String = Mid(argDirForCheck, 1, argDirForCheck.Length - (getDir.Length + 1))
        'MsgBox("in ftpCheckDir " & getRoot & " , " & getDir)

        Dim rootdir As FTPdirectory = sFTP.ListDirectoryDetail(getRoot)

        For Each dir As FTPfileInfo In rootdir.GetDirectories()
            If UCase(dir.NameOnly) = UCase(getDir) Then
                'found it
                'MsgBox("")
                Return True
                Exit Function

            End If

        Next
        Return False
    End Function
    Public Function chkConnectAble(ByVal argDirForCheck As String) As Boolean

        Dim tmpRoot() As String = argDirForCheck.Split("/")

        'For i As Int16 = 0 To tmpRoot.Length - 1
        'MsgBox(tmpRoot(i))
        ' Next

        Dim getDir As String = tmpRoot(UBound(tmpRoot) - 1)
        Dim getRoot As String = Mid(argDirForCheck, 1, argDirForCheck.Length - (getDir.Length + 1))
        'MsgBox("ftpCheckDir " & getRoot & " , " & getDir)

        Dim bbb As Boolean = sFTP.ListDirectoryDetailForCheck(getRoot)
        Return bbb


    End Function
    Public Function ftpConnectAbleCheck() As Boolean


        Dim tf As Boolean = chkConnectAble("/")
        Return tf

    End Function

End Module
