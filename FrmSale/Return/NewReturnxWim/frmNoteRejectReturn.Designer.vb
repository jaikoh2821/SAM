<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoteRejectReturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNoteRejectReturn))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.lblPartner = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.btnOk)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 169)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(308, 36)
        Me.Panel4.TabIndex = 642
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(155, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 31)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "ยกเลิก"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(32, 42)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(238, 115)
        Me.txtNote.TabIndex = 643
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Appearance.Options.UseFont = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.lblPartner)
        Me.PanelControl3.Controls.Add(Me.txtNote)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(308, 169)
        Me.PanelControl3.TabIndex = 732
        '
        'btnOk
        '
        Me.btnOk.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Appearance.Options.UseFont = True
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.Location = New System.Drawing.Point(58, 2)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(95, 31)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "ตกลง"
        '
        'lblPartner
        '
        Me.lblPartner.BackColor = System.Drawing.Color.Transparent
        Me.lblPartner.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartner.ForeColor = System.Drawing.Color.Navy
        Me.lblPartner.Location = New System.Drawing.Point(12, 9)
        Me.lblPartner.Name = "lblPartner"
        Me.lblPartner.Size = New System.Drawing.Size(275, 26)
        Me.lblPartner.TabIndex = 969
        Me.lblPartner.Text = "ระบุหมายเหตุ Reject รายการรับคืน"
        Me.lblPartner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmNoteRejectReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(308, 205)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.Panel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNoteRejectReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ยืนยัน Reject รายการหรือไม่"
        Me.Panel4.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNote As TextBox
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblPartner As Label
End Class
