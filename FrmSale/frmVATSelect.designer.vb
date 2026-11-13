<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVATSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVATSelect))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbFull9x11 = New System.Windows.Forms.RadioButton()
        Me.rdbPrinted = New System.Windows.Forms.RadioButton()
        Me.rdbFull = New System.Windows.Forms.RadioButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnInclud = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPObyVAT = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPOnoVAT = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbWeight = New System.Windows.Forms.RadioButton()
        Me.rdbNoWeight = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbFull9x11)
        Me.GroupBox1.Controls.Add(Me.rdbPrinted)
        Me.GroupBox1.Controls.Add(Me.rdbFull)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 80)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ขนาดและฟอร์มเอกสาร"
        '
        'rdbFull9x11
        '
        Me.rdbFull9x11.AutoSize = True
        Me.rdbFull9x11.Checked = True
        Me.rdbFull9x11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFull9x11.Location = New System.Drawing.Point(22, 24)
        Me.rdbFull9x11.Name = "rdbFull9x11"
        Me.rdbFull9x11.Size = New System.Drawing.Size(145, 18)
        Me.rdbFull9x11.TabIndex = 14
        Me.rdbFull9x11.TabStop = True
        Me.rdbFull9x11.Text = "แบบ Full Form (9 x11)"
        Me.rdbFull9x11.UseVisualStyleBackColor = True
        '
        'rdbPrinted
        '
        Me.rdbPrinted.AutoSize = True
        Me.rdbPrinted.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPrinted.Location = New System.Drawing.Point(22, 52)
        Me.rdbPrinted.Name = "rdbPrinted"
        Me.rdbPrinted.Size = New System.Drawing.Size(144, 18)
        Me.rdbPrinted.TabIndex = 13
        Me.rdbPrinted.Text = "แบบ Pre-printed Form"
        Me.rdbPrinted.UseVisualStyleBackColor = True
        '
        'rdbFull
        '
        Me.rdbFull.AutoSize = True
        Me.rdbFull.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFull.Location = New System.Drawing.Point(180, 24)
        Me.rdbFull.Name = "rdbFull"
        Me.rdbFull.Size = New System.Drawing.Size(129, 18)
        Me.rdbFull.TabIndex = 12
        Me.rdbFull.Text = "แบบ Full Form (A4)"
        Me.rdbFull.UseVisualStyleBackColor = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnInclud)
        Me.PanelControl1.Controls.Add(Me.btnPObyVAT)
        Me.PanelControl1.Controls.Add(Me.btnPOnoVAT)
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(366, 313)
        Me.PanelControl1.TabIndex = 723
        '
        'btnInclud
        '
        Me.btnInclud.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInclud.Appearance.Options.UseFont = True
        Me.btnInclud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInclud.Image = CType(resources.GetObject("btnInclud.Image"), System.Drawing.Image)
        Me.btnInclud.Location = New System.Drawing.Point(99, 248)
        Me.btnInclud.Name = "btnInclud"
        Me.btnInclud.Size = New System.Drawing.Size(160, 38)
        Me.btnInclud.TabIndex = 716
        Me.btnInclud.Text = "แบบไม่รวม VAT"
        '
        'btnPObyVAT
        '
        Me.btnPObyVAT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPObyVAT.Appearance.Options.UseFont = True
        Me.btnPObyVAT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPObyVAT.Image = CType(resources.GetObject("btnPObyVAT.Image"), System.Drawing.Image)
        Me.btnPObyVAT.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnPObyVAT.Location = New System.Drawing.Point(99, 206)
        Me.btnPObyVAT.Name = "btnPObyVAT"
        Me.btnPObyVAT.Size = New System.Drawing.Size(160, 38)
        Me.btnPObyVAT.TabIndex = 714
        Me.btnPObyVAT.Text = "แบบยอดเต็มตามราคา"
        '
        'btnPOnoVAT
        '
        Me.btnPOnoVAT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPOnoVAT.Appearance.Options.UseFont = True
        Me.btnPOnoVAT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPOnoVAT.Image = CType(resources.GetObject("btnPOnoVAT.Image"), System.Drawing.Image)
        Me.btnPOnoVAT.Location = New System.Drawing.Point(99, 163)
        Me.btnPOnoVAT.Name = "btnPOnoVAT"
        Me.btnPOnoVAT.Size = New System.Drawing.Size(160, 38)
        Me.btnPOnoVAT.TabIndex = 713
        Me.btnPOnoVAT.Text = "แบบถอด VAT"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rdbWeight)
        Me.GroupBox2.Controls.Add(Me.rdbNoWeight)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 53)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "การแสดงชื่อสินค้า"
        '
        'rdbWeight
        '
        Me.rdbWeight.AutoSize = True
        Me.rdbWeight.Checked = True
        Me.rdbWeight.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbWeight.Location = New System.Drawing.Point(22, 21)
        Me.rdbWeight.Name = "rdbWeight"
        Me.rdbWeight.Size = New System.Drawing.Size(144, 18)
        Me.rdbWeight.TabIndex = 14
        Me.rdbWeight.TabStop = True
        Me.rdbWeight.Text = "แบบมีน้ำหนักในชื่อสินค้า"
        Me.rdbWeight.UseVisualStyleBackColor = True
        '
        'rdbNoWeight
        '
        Me.rdbNoWeight.AutoSize = True
        Me.rdbNoWeight.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNoWeight.Location = New System.Drawing.Point(180, 21)
        Me.rdbNoWeight.Name = "rdbNoWeight"
        Me.rdbNoWeight.Size = New System.Drawing.Size(157, 18)
        Me.rdbNoWeight.TabIndex = 12
        Me.rdbNoWeight.Text = "แบบไม่มีน้ำหนักในชื่อสินค้า"
        Me.rdbNoWeight.UseVisualStyleBackColor = True
        '
        'frmVATSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(366, 313)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVATSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกรูปแบบเอกสาร"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbPrinted As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFull As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFull9x11 As System.Windows.Forms.RadioButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdbWeight As RadioButton
    Friend WithEvents rdbNoWeight As RadioButton
    Friend WithEvents btnPObyVAT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPOnoVAT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInclud As DevExpress.XtraEditors.SimpleButton
End Class
