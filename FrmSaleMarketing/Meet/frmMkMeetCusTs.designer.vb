<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkMeetCusTs
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
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btn_save = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTitleCus = New System.Windows.Forms.TextBox
        Me.txtCus = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEmp = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDetailMeet = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTime_Ts1 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Rd_Abroad = New System.Windows.Forms.RadioButton
        Me.Rd_InThai = New System.Windows.Forms.RadioButton
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.Controls.Add(Me.btn_save)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 258)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(397, 40)
        Me.Panel3.TabIndex = 622
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(0, 1)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(81, 38)
        Me.btn_save.TabIndex = 415
        Me.btn_save.Tag = ""
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 623
        Me.Label1.Text = "หัวข้อการเข้าพบคู่ค้า  : "
        '
        'txtTitleCus
        '
        Me.txtTitleCus.Enabled = False
        Me.txtTitleCus.Location = New System.Drawing.Point(129, 44)
        Me.txtTitleCus.Name = "txtTitleCus"
        Me.txtTitleCus.Size = New System.Drawing.Size(213, 20)
        Me.txtTitleCus.TabIndex = 624
        '
        'txtCus
        '
        Me.txtCus.Enabled = False
        Me.txtCus.Location = New System.Drawing.Point(117, 46)
        Me.txtCus.Name = "txtCus"
        Me.txtCus.Size = New System.Drawing.Size(213, 20)
        Me.txtCus.TabIndex = 627
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 626
        Me.Label2.Text = "วันที่เข้าพบ  :"
        '
        'txtEmp
        '
        Me.txtEmp.Enabled = False
        Me.txtEmp.Location = New System.Drawing.Point(129, 154)
        Me.txtEmp.Name = "txtEmp"
        Me.txtEmp.Size = New System.Drawing.Size(213, 20)
        Me.txtEmp.TabIndex = 630
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 629
        Me.Label3.Text = "คู่ค้าที่เข้าพบ  :"
        '
        'txtDetailMeet
        '
        Me.txtDetailMeet.Location = New System.Drawing.Point(129, 71)
        Me.txtDetailMeet.Multiline = True
        Me.txtDetailMeet.Name = "txtDetailMeet"
        Me.txtDetailMeet.Size = New System.Drawing.Size(243, 75)
        Me.txtDetailMeet.TabIndex = 632
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 633
        Me.Label4.Text = "รายละเอียด  : "
        '
        'DateTime_Ts1
        '
        Me.DateTime_Ts1.Location = New System.Drawing.Point(129, 17)
        Me.DateTime_Ts1.Name = "DateTime_Ts1"
        Me.DateTime_Ts1.Size = New System.Drawing.Size(147, 20)
        Me.DateTime_Ts1.TabIndex = 634
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 635
        Me.Label5.Text = "พนักงานที่เข้าพบ  :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rd_Abroad)
        Me.GroupBox2.Controls.Add(Me.Rd_InThai)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtCus)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 75)
        Me.GroupBox2.TabIndex = 638
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "เลือกคู่ค้า"
        '
        'Rd_Abroad
        '
        Me.Rd_Abroad.AutoSize = True
        Me.Rd_Abroad.Location = New System.Drawing.Point(229, 17)
        Me.Rd_Abroad.Name = "Rd_Abroad"
        Me.Rd_Abroad.Size = New System.Drawing.Size(99, 17)
        Me.Rd_Abroad.TabIndex = 1
        Me.Rd_Abroad.Text = "คู่ค้าต่างประเทศ"
        Me.Rd_Abroad.UseVisualStyleBackColor = True
        '
        'Rd_InThai
        '
        Me.Rd_InThai.AutoSize = True
        Me.Rd_InThai.Checked = True
        Me.Rd_InThai.Location = New System.Drawing.Point(121, 17)
        Me.Rd_InThai.Name = "Rd_InThai"
        Me.Rd_InThai.Size = New System.Drawing.Size(96, 17)
        Me.Rd_InThai.TabIndex = 0
        Me.Rd_InThai.TabStop = True
        Me.Rd_InThai.Text = "คู่ค้าในประเทศ"
        Me.Rd_InThai.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.Image = Global.SAM.My.Resources.Resources.Find16
        Me.Button2.Location = New System.Drawing.Point(330, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 24)
        Me.Button2.TabIndex = 636
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DimGray
        Me.Button3.Image = Global.SAM.My.Resources.Resources.Find16
        Me.Button3.Location = New System.Drawing.Point(342, 151)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 25)
        Me.Button3.TabIndex = 637
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Image = Global.SAM.My.Resources.Resources.Find16
        Me.Button1.Location = New System.Drawing.Point(342, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 25)
        Me.Button1.TabIndex = 625
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmMkMeetCusTs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(397, 298)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtDetailMeet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTime_Ts1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTitleCus)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMkMeetCusTs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ทำรายการบันทีกการเข้าพบคู่ค้า"
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTitleCus As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtCus As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDetailMeet As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTime_Ts1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Rd_Abroad As System.Windows.Forms.RadioButton
    Friend WithEvents Rd_InThai As System.Windows.Forms.RadioButton
End Class
