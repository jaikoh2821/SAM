<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelFormCont
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelFormCont))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdbShowLot = New System.Windows.Forms.RadioButton()
        Me.rdbBlankNoComp = New System.Windows.Forms.RadioButton()
        Me.rdbPPForm = New System.Windows.Forms.RadioButton()
        Me.rdbBlankForm = New System.Windows.Forms.RadioButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 166)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(313, 29)
        Me.Panel4.TabIndex = 643
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnOK)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(154, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(78, 29)
        Me.Panel3.TabIndex = 589
        '
        'btnOK
        '
        Me.btnOK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(3, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(73, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "ตกลง"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(232, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(81, 29)
        Me.Panel2.TabIndex = 588
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(3, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(74, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "ยกเลิก"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.rdbShowLot)
        Me.GroupBox4.Controls.Add(Me.rdbBlankNoComp)
        Me.GroupBox4.Controls.Add(Me.rdbPPForm)
        Me.GroupBox4.Controls.Add(Me.rdbBlankForm)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 139)
        Me.GroupBox4.TabIndex = 718
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "เงื่อนไข"
        '
        'rdbShowLot
        '
        Me.rdbShowLot.AutoSize = True
        Me.rdbShowLot.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbShowLot.Location = New System.Drawing.Point(52, 47)
        Me.rdbShowLot.Name = "rdbShowLot"
        Me.rdbShowLot.Size = New System.Drawing.Size(78, 18)
        Me.rdbShowLot.TabIndex = 16
        Me.rdbShowLot.Text = "Show Lot"
        Me.rdbShowLot.UseVisualStyleBackColor = True
        '
        'rdbBlankNoComp
        '
        Me.rdbBlankNoComp.AutoSize = True
        Me.rdbBlankNoComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbBlankNoComp.Location = New System.Drawing.Point(52, 95)
        Me.rdbBlankNoComp.Name = "rdbBlankNoComp"
        Me.rdbBlankNoComp.Size = New System.Drawing.Size(157, 18)
        Me.rdbBlankNoComp.TabIndex = 15
        Me.rdbBlankNoComp.Text = "Blank Form No Company"
        Me.rdbBlankNoComp.UseVisualStyleBackColor = True
        '
        'rdbPPForm
        '
        Me.rdbPPForm.AutoSize = True
        Me.rdbPPForm.Checked = True
        Me.rdbPPForm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPPForm.Location = New System.Drawing.Point(52, 23)
        Me.rdbPPForm.Name = "rdbPPForm"
        Me.rdbPPForm.Size = New System.Drawing.Size(113, 18)
        Me.rdbPPForm.TabIndex = 14
        Me.rdbPPForm.TabStop = True
        Me.rdbPPForm.Text = "Preprinted Form"
        Me.rdbPPForm.UseVisualStyleBackColor = True
        '
        'rdbBlankForm
        '
        Me.rdbBlankForm.AutoSize = True
        Me.rdbBlankForm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbBlankForm.Location = New System.Drawing.Point(52, 71)
        Me.rdbBlankForm.Name = "rdbBlankForm"
        Me.rdbBlankForm.Size = New System.Drawing.Size(84, 18)
        Me.rdbBlankForm.TabIndex = 12
        Me.rdbBlankForm.Text = "Blank Form"
        Me.rdbBlankForm.UseVisualStyleBackColor = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupBox4)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(313, 166)
        Me.PanelControl1.TabIndex = 723
        '
        'frmSelFormCont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(313, 195)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelFormCont"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกรูปแบบกระดาษ"
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rdbBlankNoComp As RadioButton
    Friend WithEvents rdbPPForm As RadioButton
    Friend WithEvents rdbBlankForm As RadioButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents rdbShowLot As RadioButton
End Class
