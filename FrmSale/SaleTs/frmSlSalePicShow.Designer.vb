<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlSalePicShow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlSalePicShow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblNumOfPic = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrv = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.btnPreview)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 539)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 33)
        Me.Panel1.TabIndex = 1
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.DimGray
        Me.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreview.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPreview.ForeColor = System.Drawing.Color.White
        Me.btnPreview.Image = Global.SAM.My.Resources.Resources.Image_Viewer_icon
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(0, 0)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(183, 33)
        Me.btnPreview.TabIndex = 583
        Me.btnPreview.Tag = ""
        Me.btnPreview.Text = "      ใช้โปรแกรม Preview"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.Controls.Add(Me.lblNumOfPic)
        Me.Panel2.Controls.Add(Me.btnNext)
        Me.Panel2.Controls.Add(Me.btnPrv)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(434, 34)
        Me.Panel2.TabIndex = 2
        '
        'lblNumOfPic
        '
        Me.lblNumOfPic.AutoSize = True
        Me.lblNumOfPic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblNumOfPic.ForeColor = System.Drawing.Color.White
        Me.lblNumOfPic.Location = New System.Drawing.Point(189, 7)
        Me.lblNumOfPic.Name = "lblNumOfPic"
        Me.lblNumOfPic.Size = New System.Drawing.Size(58, 20)
        Me.lblNumOfPic.TabIndex = 0
        Me.lblNumOfPic.Text = "1 Of 1"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.DimGray
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNext.Enabled = False
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Image = Global.SAM.My.Resources.Resources.ArrowRight
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNext.Location = New System.Drawing.Point(339, 0)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(95, 34)
        Me.btnNext.TabIndex = 583
        Me.btnNext.Tag = ""
        Me.btnNext.Text = "รูปถัดไป"
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrv
        '
        Me.btnPrv.BackColor = System.Drawing.Color.DimGray
        Me.btnPrv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrv.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrv.Enabled = False
        Me.btnPrv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrv.ForeColor = System.Drawing.Color.White
        Me.btnPrv.Image = Global.SAM.My.Resources.Resources.ArrowLeft
        Me.btnPrv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrv.Location = New System.Drawing.Point(0, 0)
        Me.btnPrv.Name = "btnPrv"
        Me.btnPrv.Size = New System.Drawing.Size(112, 34)
        Me.btnPrv.TabIndex = 582
        Me.btnPrv.Tag = ""
        Me.btnPrv.Text = "         รูปก่อนหน้า"
        Me.btnPrv.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.SAM.My.Resources.Resources.noimage
        Me.PictureBox1.Location = New System.Drawing.Point(0, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(434, 505)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmSlSalePicShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 572)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSlSalePicShow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แสดงรูปบิลขาย"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrv As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblNumOfPic As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
End Class
