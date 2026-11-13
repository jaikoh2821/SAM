<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusMapSetDetail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusMapSetDetail))
        Me.lbPsName = New System.Windows.Forms.Label
        Me.lbAddress = New System.Windows.Forms.Label
        Me.lbCusName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_save = New System.Windows.Forms.Button
        Me.tbLatitude = New System.Windows.Forms.TextBox
        Me.tbLongitude = New System.Windows.Forms.TextBox
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbPsName
        '
        Me.lbPsName.AutoSize = True
        Me.lbPsName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPsName.Location = New System.Drawing.Point(12, 54)
        Me.lbPsName.Name = "lbPsName"
        Me.lbPsName.Size = New System.Drawing.Size(121, 17)
        Me.lbPsName.TabIndex = 618
        Me.lbPsName.Text = "เจ้าหน้าที่ขายที่ดูแล : "
        '
        'lbAddress
        '
        Me.lbAddress.AutoSize = True
        Me.lbAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAddress.Location = New System.Drawing.Point(12, 30)
        Me.lbAddress.Name = "lbAddress"
        Me.lbAddress.Size = New System.Drawing.Size(42, 17)
        Me.lbAddress.TabIndex = 617
        Me.lbAddress.Text = "ที่อยู่ : "
        '
        'lbCusName
        '
        Me.lbCusName.AutoSize = True
        Me.lbCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusName.Location = New System.Drawing.Point(12, 6)
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(64, 17)
        Me.lbCusName.TabIndex = 616
        Me.lbCusName.Text = "ชื่อลูกค้า : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 619
        Me.Label1.Text = "Latitude"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 620
        Me.Label2.Text = "Longitude"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 542)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 40)
        Me.Panel1.TabIndex = 621
        '
        'btn_save
        '
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(0, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 36)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'tbLatitude
        '
        Me.tbLatitude.Location = New System.Drawing.Point(87, 16)
        Me.tbLatitude.MaxLength = 50
        Me.tbLatitude.Name = "tbLatitude"
        Me.tbLatitude.Size = New System.Drawing.Size(131, 20)
        Me.tbLatitude.TabIndex = 622
        '
        'tbLongitude
        '
        Me.tbLongitude.Location = New System.Drawing.Point(87, 47)
        Me.tbLongitude.MaxLength = 50
        Me.tbLongitude.Name = "tbLongitude"
        Me.tbLongitude.Size = New System.Drawing.Size(131, 20)
        Me.tbLongitude.TabIndex = 623
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(832, 454)
        Me.WebBrowser1.TabIndex = 624
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.WebBrowser1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(834, 456)
        Me.Panel2.TabIndex = 625
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.tbLatitude)
        Me.Panel3.Controls.Add(Me.tbLongitude)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(575, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(259, 86)
        Me.Panel3.TabIndex = 626
        '
        'frmCusMapSetDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(834, 582)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbPsName)
        Me.Controls.Add(Me.lbAddress)
        Me.Controls.Add(Me.lbCusName)
        Me.Name = "frmCusMapSetDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "กำหนดพิกัดตำแหน่งคู่ค้าในแผนที่"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbPsName As System.Windows.Forms.Label
    Friend WithEvents lbAddress As System.Windows.Forms.Label
    Friend WithEvents lbCusName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents tbLatitude As System.Windows.Forms.TextBox
    Friend WithEvents tbLongitude As System.Windows.Forms.TextBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
