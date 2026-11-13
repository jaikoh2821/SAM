<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMYSelect
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
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btn_find = New System.Windows.Forms.Button
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpMonth
        '
        Me.dtpMonth.CustomFormat = "MMMM/yyyy"
        Me.dtpMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(89, 12)
        Me.dtpMonth.MinimumSize = New System.Drawing.Size(4, 30)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.ShowUpDown = True
        Me.dtpMonth.Size = New System.Drawing.Size(134, 30)
        Me.dtpMonth.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "เดือน/ปี"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.Controls.Add(Me.btn_find)
        Me.Panel3.Location = New System.Drawing.Point(1, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(283, 40)
        Me.Panel3.TabIndex = 637
        '
        'btn_find
        '
        Me.btn_find.BackColor = System.Drawing.Color.DimGray
        Me.btn_find.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_find.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_find.ForeColor = System.Drawing.Color.White
        Me.btn_find.Image = Global.SAM.My.Resources.Resources.Add28
        Me.btn_find.Location = New System.Drawing.Point(2, 1)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(107, 38)
        Me.btn_find.TabIndex = 414
        Me.btn_find.Tag = ""
        Me.btn_find.Text = "ตกลง"
        Me.btn_find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_find.UseVisualStyleBackColor = False
        '
        'frmMYSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(284, 88)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpMonth)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMYSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกเดือน/ปี"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_find As System.Windows.Forms.Button
End Class
