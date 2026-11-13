<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkMeetCusRpt
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnShowDoc = New System.Windows.Forms.Button
        Me.DateTime_Ts1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTime_Ts2 = New System.Windows.Forms.DateTimePicker
        Me.RdSDay = New System.Windows.Forms.RadioButton
        Me.RdSMonth = New System.Windows.Forms.RadioButton
        Me.DayOfMonth = New System.Windows.Forms.DateTimePicker
        Me.RdGrTitleCus = New System.Windows.Forms.RadioButton
        Me.RdGrEmp = New System.Windows.Forms.RadioButton
        Me.RdGrCus = New System.Windows.Forms.RadioButton
        Me.RdGrDay = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnShowDoc)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 195)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(418, 40)
        Me.Panel2.TabIndex = 586
        '
        'btnShowDoc
        '
        Me.btnShowDoc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnShowDoc.BackColor = System.Drawing.Color.DimGray
        Me.btnShowDoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShowDoc.ForeColor = System.Drawing.Color.White
        Me.btnShowDoc.Image = Global.SAM.My.Resources.Resources.Printers
        Me.btnShowDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowDoc.Location = New System.Drawing.Point(0, 0)
        Me.btnShowDoc.Name = "btnShowDoc"
        Me.btnShowDoc.Size = New System.Drawing.Size(118, 38)
        Me.btnShowDoc.TabIndex = 584
        Me.btnShowDoc.Tag = ""
        Me.btnShowDoc.Text = "       พิมพ์เอกสาร"
        Me.btnShowDoc.UseVisualStyleBackColor = False
        '
        'DateTime_Ts1
        '
        Me.DateTime_Ts1.Location = New System.Drawing.Point(93, 9)
        Me.DateTime_Ts1.Name = "DateTime_Ts1"
        Me.DateTime_Ts1.Size = New System.Drawing.Size(142, 20)
        Me.DateTime_Ts1.TabIndex = 579
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 581
        Me.Label1.Text = "ถึง"
        '
        'DateTime_Ts2
        '
        Me.DateTime_Ts2.Location = New System.Drawing.Point(263, 9)
        Me.DateTime_Ts2.Name = "DateTime_Ts2"
        Me.DateTime_Ts2.Size = New System.Drawing.Size(142, 20)
        Me.DateTime_Ts2.TabIndex = 580
        '
        'RdSDay
        '
        Me.RdSDay.AutoSize = True
        Me.RdSDay.Checked = True
        Me.RdSDay.Location = New System.Drawing.Point(12, 12)
        Me.RdSDay.Name = "RdSDay"
        Me.RdSDay.Size = New System.Drawing.Size(80, 17)
        Me.RdSDay.TabIndex = 582
        Me.RdSDay.TabStop = True
        Me.RdSDay.Text = "ระหว่างวันที่"
        Me.RdSDay.UseVisualStyleBackColor = True
        '
        'RdSMonth
        '
        Me.RdSMonth.AutoSize = True
        Me.RdSMonth.Location = New System.Drawing.Point(12, 40)
        Me.RdSMonth.Name = "RdSMonth"
        Me.RdSMonth.Size = New System.Drawing.Size(80, 17)
        Me.RdSMonth.TabIndex = 583
        Me.RdSMonth.Text = "ประจำเดือน"
        Me.RdSMonth.UseVisualStyleBackColor = True
        '
        'DayOfMonth
        '
        Me.DayOfMonth.CustomFormat = "MMMM / yyyy"
        Me.DayOfMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DayOfMonth.Location = New System.Drawing.Point(93, 39)
        Me.DayOfMonth.Name = "DayOfMonth"
        Me.DayOfMonth.ShowUpDown = True
        Me.DayOfMonth.Size = New System.Drawing.Size(142, 20)
        Me.DayOfMonth.TabIndex = 584
        '
        'RdGrTitleCus
        '
        Me.RdGrTitleCus.AutoSize = True
        Me.RdGrTitleCus.Checked = True
        Me.RdGrTitleCus.Location = New System.Drawing.Point(24, 18)
        Me.RdGrTitleCus.Name = "RdGrTitleCus"
        Me.RdGrTitleCus.Size = New System.Drawing.Size(140, 17)
        Me.RdGrTitleCus.TabIndex = 585
        Me.RdGrTitleCus.TabStop = True
        Me.RdGrTitleCus.Text = "จัดกลุ่มตามหัวข้อที่เข้าพบ"
        Me.RdGrTitleCus.UseVisualStyleBackColor = True
        '
        'RdGrEmp
        '
        Me.RdGrEmp.AutoSize = True
        Me.RdGrEmp.Location = New System.Drawing.Point(24, 41)
        Me.RdGrEmp.Name = "RdGrEmp"
        Me.RdGrEmp.Size = New System.Drawing.Size(118, 17)
        Me.RdGrEmp.TabIndex = 587
        Me.RdGrEmp.Text = "จัดกลุ่มตามพนักงาน"
        Me.RdGrEmp.UseVisualStyleBackColor = True
        '
        'RdGrCus
        '
        Me.RdGrCus.AutoSize = True
        Me.RdGrCus.Location = New System.Drawing.Point(24, 65)
        Me.RdGrCus.Name = "RdGrCus"
        Me.RdGrCus.Size = New System.Drawing.Size(96, 17)
        Me.RdGrCus.TabIndex = 586
        Me.RdGrCus.Text = "จัดกลุ่มตามคู่ค้า"
        Me.RdGrCus.UseVisualStyleBackColor = True
        '
        'RdGrDay
        '
        Me.RdGrDay.AutoSize = True
        Me.RdGrDay.Location = New System.Drawing.Point(24, 89)
        Me.RdGrDay.Name = "RdGrDay"
        Me.RdGrDay.Size = New System.Drawing.Size(98, 17)
        Me.RdGrDay.TabIndex = 588
        Me.RdGrDay.Text = "จัดกลุ่มตามวันที่"
        Me.RdGrDay.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RdGrDay)
        Me.GroupBox2.Controls.Add(Me.RdGrCus)
        Me.GroupBox2.Controls.Add(Me.RdGrEmp)
        Me.GroupBox2.Controls.Add(Me.RdGrTitleCus)
        Me.GroupBox2.Location = New System.Drawing.Point(106, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 114)
        Me.GroupBox2.TabIndex = 588
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "การจัดกลุ่ม"
        '
        'frmMkMeetCusRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(418, 235)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DayOfMonth)
        Me.Controls.Add(Me.RdSMonth)
        Me.Controls.Add(Me.RdSDay)
        Me.Controls.Add(Me.DateTime_Ts1)
        Me.Controls.Add(Me.DateTime_Ts2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMkMeetCusRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานการเข้าพบคู่ค้า"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnShowDoc As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RdGrDay As System.Windows.Forms.RadioButton
    Friend WithEvents RdGrCus As System.Windows.Forms.RadioButton
    Friend WithEvents RdGrEmp As System.Windows.Forms.RadioButton
    Friend WithEvents RdGrTitleCus As System.Windows.Forms.RadioButton
    Friend WithEvents DayOfMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents RdSMonth As System.Windows.Forms.RadioButton
    Friend WithEvents RdSDay As System.Windows.Forms.RadioButton
    Friend WithEvents DateTime_Ts2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTime_Ts1 As System.Windows.Forms.DateTimePicker
End Class
