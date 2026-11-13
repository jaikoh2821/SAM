<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoading
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MainLayoutPanel = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.MainLayoutPanel.Appearance.Options.UseBackColor = True
        Me.MainLayoutPanel.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MainLayoutPanel.AppearanceCaption.Options.UseFont = True
        Me.MainLayoutPanel.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MainLayoutPanel.AppearanceDescription.Options.UseFont = True
        Me.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayoutPanel.ImageHorzOffset = 20
        Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainLayoutPanel.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.Size = New System.Drawing.Size(248, 73)
        Me.MainLayoutPanel.TabIndex = 198
        Me.MainLayoutPanel.Text = "progressPanel1"
        '
        'frmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(248, 73)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(550, 340)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoading"
        Me.Opacity = 0.65R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents MainLayoutPanel As DevExpress.XtraWaitForm.ProgressPanel

End Class
