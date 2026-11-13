<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkGiftDocSelect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMkGiftDocSelect))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.RBAllAddress = New System.Windows.Forms.RadioButton
        Me.RBAdress2 = New System.Windows.Forms.RadioButton
        Me.RBAdress = New System.Windows.Forms.RadioButton
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btn_show = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.RBAllAddress)
        Me.GroupBox3.Controls.Add(Me.RBAdress2)
        Me.GroupBox3.Controls.Add(Me.RBAdress)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(333, 100)
        Me.GroupBox3.TabIndex = 682
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "จ่าหน้าซองถึง"
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.IndianRed
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.SAM.My.Resources.Resources.font
        Me.Button4.Location = New System.Drawing.Point(191, 11)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 44)
        Me.Button4.TabIndex = 685
        Me.Button4.Text = "ดาวน์โหลด Font"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'RBAllAddress
        '
        Me.RBAllAddress.AutoSize = True
        Me.RBAllAddress.Location = New System.Drawing.Point(15, 74)
        Me.RBAllAddress.Name = "RBAllAddress"
        Me.RBAllAddress.Size = New System.Drawing.Size(144, 17)
        Me.RBAllAddress.TabIndex = 676
        Me.RBAllAddress.Text = "ทั้งชื่อบริษัทและชื่อผู้ติดต่อ"
        Me.RBAllAddress.UseVisualStyleBackColor = True
        '
        'RBAdress2
        '
        Me.RBAdress2.AutoSize = True
        Me.RBAdress2.Checked = True
        Me.RBAdress2.Location = New System.Drawing.Point(15, 48)
        Me.RBAdress2.Name = "RBAdress2"
        Me.RBAdress2.Size = New System.Drawing.Size(66, 17)
        Me.RBAdress2.TabIndex = 674
        Me.RBAdress2.TabStop = True
        Me.RBAdress2.Text = "ชื่อบริษัท"
        Me.RBAdress2.UseVisualStyleBackColor = True
        '
        'RBAdress
        '
        Me.RBAdress.AutoSize = True
        Me.RBAdress.Location = New System.Drawing.Point(15, 23)
        Me.RBAdress.Name = "RBAdress"
        Me.RBAdress.Size = New System.Drawing.Size(72, 17)
        Me.RBAdress.TabIndex = 673
        Me.RBAdress.Text = "ชื่อผู้ติดต่อ"
        Me.RBAdress.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.DimGray
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(65, 228)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(253, 40)
        Me.Button3.TabIndex = 684
        Me.Button3.Text = "พิมพ์เอกสาร ส.ค.ส. (ที่อยู่ต่างประเทศ)"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(65, 182)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(253, 40)
        Me.Button2.TabIndex = 683
        Me.Button2.Text = "พิมพ์เอกสาร ส.ค.ส. (ขนาด A4)"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(65, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 40)
        Me.Button1.TabIndex = 404
        Me.Button1.Text = "พิมพ์เอกสาร ส.ค.ส. (ขนาด 5x7)"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_show
        '
        Me.btn_show.AutoSize = True
        Me.btn_show.BackColor = System.Drawing.Color.DimGray
        Me.btn_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_show.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_show.ForeColor = System.Drawing.Color.White
        Me.btn_show.Image = CType(resources.GetObject("btn_show.Image"), System.Drawing.Image)
        Me.btn_show.Location = New System.Drawing.Point(65, 274)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(253, 40)
        Me.btn_show.TabIndex = 403
        Me.btn_show.Text = "พิมพ์เอกสารเป็นสติ๊กเกอร์"
        Me.btn_show.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_show.UseVisualStyleBackColor = False
        '
        'frmMkGiftDocSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(369, 331)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_show)
        Me.Name = "frmMkGiftDocSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกการพิมพ์"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_show As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RBAdress2 As System.Windows.Forms.RadioButton
    Friend WithEvents RBAdress As System.Windows.Forms.RadioButton
    Friend WithEvents RBAllAddress As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
