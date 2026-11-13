Public Class frmCusMapSetDetail
    Dim idCus As Integer
    Public checkChange As Integer = 0

    Public Sub setValues(ByVal id As Integer, ByVal cusName As String, ByVal address As String, ByVal psName As String, ByVal lat As String, ByVal lng As String)
        idCus = id
        lbCusName.Text &= cusName
        lbAddress.Text &= address
        lbPsName.Text &= psName
        tbLatitude.Text = lat
        tbLongitude.Text = lng

        If tbLatitude.Text <> "" And tbLongitude.Text <> "" Then
            WebBrowser1.DocumentText = My.Resources.ResourceManager.GetObject("cusMapSet")
        End If

        tbLatitude.Select()

    End Sub

    Private Sub saveData()
        Dim lat As Double
        Dim lng As Double

        If tbLatitude.Text <> "" And Double.TryParse(tbLatitude.Text, lat) = False Then
            MessageBox.Show("บันทึกไม่ได้เนื่องจากค่า Latitude ไม่ใช่จำนวนเลข", sSystemName)
            WebBrowser1.DocumentText = ""
        ElseIf lat < -90 Or lat > 90 Then
            MessageBox.Show("บันทึกไม่ได้เนื่องจากค่า Latitude ไม่ถูกต้อง (Latitude ต้องมีค่าตั้งแต่ -90 ถึง 90)", sSystemName)
            WebBrowser1.DocumentText = ""
        ElseIf tbLongitude.Text <> "" And Double.TryParse(tbLongitude.Text, lng) = False Then
            MessageBox.Show("บันทึกไม่ได้เนื่องจากค่า Longitude ไม่ใช่จำนวนเลข", sSystemName)
            WebBrowser1.DocumentText = ""
        ElseIf lng < -180 Or lng > 180 Then
            MessageBox.Show("บันทึกไม่ได้เนื่องจากค่า Longitude ไม่ถูกต้อง (Longitude ต้องมีค่าตั้งแต่ -180 ถึง 180)", sSystemName)
            WebBrowser1.DocumentText = ""
        Else
            If tbLatitude.Text <> "" Then
                tbLatitude.Text = lat
            End If

            If tbLongitude.Text <> "" Then
                tbLongitude.Text = lng
            End If

            mdCnOpen()
            sCommand.CommandText = "UPDATE dCustomer SET  Latitude = '" & tbLatitude.Text & "',Longitude = '" & tbLongitude.Text & "' Where idCus = " & idCus
            sCommand.ExecuteNonQuery()

            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName)
            checkChange = 1

            If tbLatitude.Text <> "" And tbLongitude.Text <> "" Then
                WebBrowser1.DocumentText = My.Resources.ResourceManager.GetObject("cusMapSet")
            Else
                WebBrowser1.DocumentText = ""
            End If

        End If

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        saveData()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        WebBrowser1.Document.InvokeScript("setLatLng", New Object() {tbLatitude.Text, tbLongitude.Text})
    End Sub

    Private Sub tbLatitude_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbLatitude.KeyPress
        If (e.KeyChar = Chr(Keys.Enter)) Then
            saveData()
        End If
    End Sub

    Private Sub tbLongitude_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbLongitude.KeyPress
        If (e.KeyChar = Chr(Keys.Enter)) Then
            saveData()
        End If
    End Sub
End Class