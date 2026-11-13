<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusPicAdd
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
        Me.rb1 = New System.Windows.Forms.RadioButton
        Me.rb2 = New System.Windows.Forms.RadioButton
        Me.rb3 = New System.Windows.Forms.RadioButton
        Me.txtpicname = New System.Windows.Forms.TextBox
        Me.btnSelectImgPd = New System.Windows.Forms.Button
        Me.btnDelImgPd = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.ptbPd = New System.Windows.Forms.PictureBox
        Me.ofdUpImg = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbtotal = New System.Windows.Forms.Label
        CType(Me.ptbPd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rb1.Location = New System.Drawing.Point(128, 125)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(70, 24)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Text = "สถานที่"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rb2.Location = New System.Drawing.Point(128, 155)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(90, 24)
        Me.rb2.TabIndex = 1
        Me.rb2.TabStop = True
        Me.rb2.Text = "การจัดงาน"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rb3.Location = New System.Drawing.Point(128, 95)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(72, 24)
        Me.rb3.TabIndex = 2
        Me.rb3.TabStop = True
        Me.rb3.Text = "เจ้าของ"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'txtpicname
        '
        Me.txtpicname.Location = New System.Drawing.Point(128, 69)
        Me.txtpicname.Name = "txtpicname"
        Me.txtpicname.Size = New System.Drawing.Size(206, 20)
        Me.txtpicname.TabIndex = 3
        '
        'btnSelectImgPd
        '
        Me.btnSelectImgPd.BackColor = System.Drawing.Color.DimGray
        Me.btnSelectImgPd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectImgPd.ForeColor = System.Drawing.Color.White
        Me.btnSelectImgPd.Location = New System.Drawing.Point(713, 23)
        Me.btnSelectImgPd.Name = "btnSelectImgPd"
        Me.btnSelectImgPd.Size = New System.Drawing.Size(40, 23)
        Me.btnSelectImgPd.TabIndex = 605
        Me.btnSelectImgPd.Text = "เลือก"
        Me.btnSelectImgPd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelectImgPd.UseVisualStyleBackColor = False
        '
        'btnDelImgPd
        '
        Me.btnDelImgPd.BackColor = System.Drawing.Color.DimGray
        Me.btnDelImgPd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelImgPd.Enabled = False
        Me.btnDelImgPd.ForeColor = System.Drawing.Color.White
        Me.btnDelImgPd.Location = New System.Drawing.Point(753, 23)
        Me.btnDelImgPd.Name = "btnDelImgPd"
        Me.btnDelImgPd.Size = New System.Drawing.Size(29, 23)
        Me.btnDelImgPd.TabIndex = 604
        Me.btnDelImgPd.Text = "ลบ"
        Me.btnDelImgPd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelImgPd.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(418, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(368, 25)
        Me.Label19.TabIndex = 603
        Me.Label19.Text = "                                     รูปตัวอย่าง"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 606
        Me.Label1.Text = "ชื่อรูป"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 607
        Me.Label2.Text = "หมวดหมู่"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.SAM.My.Resources.Resources.Del28
        Me.Button1.Location = New System.Drawing.Point(105, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 38)
        Me.Button1.TabIndex = 609
        Me.Button1.Text = "ยกเลิก"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btn_save.Location = New System.Drawing.Point(3, 6)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 38)
        Me.btn_save.TabIndex = 608
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'ptbPd
        '
        Me.ptbPd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbPd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbPd.Location = New System.Drawing.Point(418, 47)
        Me.ptbPd.Name = "ptbPd"
        Me.ptbPd.Size = New System.Drawing.Size(368, 274)
        Me.ptbPd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbPd.TabIndex = 602
        Me.ptbPd.TabStop = False
        '
        'ofdUpImg
        '
        Me.ofdUpImg.Filter = "*.jpg|*.jpg"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rb3)
        Me.GroupBox1.Controls.Add(Me.txtpicname)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 299)
        Me.GroupBox1.TabIndex = 610
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลรูปภาพ"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbtotal)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 246)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 50)
        Me.Panel1.TabIndex = 610
        '
        'lbtotal
        '
        Me.lbtotal.AutoSize = True
        Me.lbtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbtotal.ForeColor = System.Drawing.Color.Crimson
        Me.lbtotal.Location = New System.Drawing.Point(768, 17)
        Me.lbtotal.Name = "lbtotal"
        Me.lbtotal.Size = New System.Drawing.Size(92, 17)
        Me.lbtotal.TabIndex = 429
        Me.lbtotal.Text = "รายการทั้งหมด "
        '
        'frmCusPicAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(798, 345)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSelectImgPd)
        Me.Controls.Add(Me.ptbPd)
        Me.Controls.Add(Me.btnDelImgPd)
        Me.Controls.Add(Me.Label19)
        Me.Name = "frmCusPicAdd"
        Me.Text = "ข้อมูลรูปภาพลูกค้า"
        CType(Me.ptbPd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents txtpicname As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectImgPd As System.Windows.Forms.Button
    Friend WithEvents ptbPd As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelImgPd As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ofdUpImg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbtotal As System.Windows.Forms.Label
End Class
