Public Class frmCustomerOld
    Sub New(ByVal aName As String, ByVal aTel As String, ByVal aAddress As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "ข้อมูลจากระบบเดิมของ " & aName
        txtTel.Text = aTel
        txtAddress.Text = aAddress
    End Sub
End Class