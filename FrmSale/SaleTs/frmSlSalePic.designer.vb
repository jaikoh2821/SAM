<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlSalePic
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlSalePic))
        Me.btn_OK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSelectImgPd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelImgPd = New DevExpress.XtraEditors.SimpleButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ofdUpImg = New System.Windows.Forms.OpenFileDialog()
        Me.Lv = New System.Windows.Forms.ListView()
        Me.Img1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_OK
        '
        Me.btn_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_OK.Appearance.Options.UseFont = True
        Me.btn_OK.Image = CType(resources.GetObject("btn_OK.Image"), System.Drawing.Image)
        Me.btn_OK.Location = New System.Drawing.Point(3, 2)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(87, 30)
        Me.btn_OK.TabIndex = 673
        Me.btn_OK.Text = "บันทึก"
        '
        'btnSelectImgPd
        '
        Me.btnSelectImgPd.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectImgPd.Appearance.Options.UseFont = True
        Me.btnSelectImgPd.Image = CType(resources.GetObject("btnSelectImgPd.Image"), System.Drawing.Image)
        Me.btnSelectImgPd.Location = New System.Drawing.Point(249, 3)
        Me.btnSelectImgPd.Name = "btnSelectImgPd"
        Me.btnSelectImgPd.Size = New System.Drawing.Size(87, 30)
        Me.btnSelectImgPd.TabIndex = 670
        Me.btnSelectImgPd.Text = "เพิ่มรูป"
        '
        'btnDelImgPd
        '
        Me.btnDelImgPd.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelImgPd.Appearance.Options.UseFont = True
        Me.btnDelImgPd.Image = CType(resources.GetObject("btnDelImgPd.Image"), System.Drawing.Image)
        Me.btnDelImgPd.Location = New System.Drawing.Point(337, 3)
        Me.btnDelImgPd.Name = "btnDelImgPd"
        Me.btnDelImgPd.Size = New System.Drawing.Size(87, 30)
        Me.btnDelImgPd.TabIndex = 669
        Me.btnDelImgPd.Text = "ลบรูป"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(5, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(216, 16)
        Me.Label7.TabIndex = 667
        Me.Label7.Text = "ไฟล์รูปภาพอ้างอิงรายการขายสินค้า"
        '
        'ofdUpImg
        '
        Me.ofdUpImg.Filter = "*.jpg|*.jpg"
        '
        'Lv
        '
        Me.Lv.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Lv.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.Lv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lv.LargeImageList = Me.Img1
        Me.Lv.Location = New System.Drawing.Point(0, 35)
        Me.Lv.MultiSelect = False
        Me.Lv.Name = "Lv"
        Me.Lv.Size = New System.Drawing.Size(427, 392)
        Me.Lv.TabIndex = 674
        Me.Lv.TileSize = New System.Drawing.Size(250, 30)
        Me.Lv.UseCompatibleStateImageBehavior = False
        '
        'Img1
        '
        Me.Img1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.Img1.ImageSize = New System.Drawing.Size(32, 32)
        Me.Img1.TransparentColor = System.Drawing.Color.Transparent
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.btn_OK)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(0, 427)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(427, 35)
        Me.PanelControl3.TabIndex = 723
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnSelectImgPd)
        Me.PanelControl1.Controls.Add(Me.Label7)
        Me.PanelControl1.Controls.Add(Me.btnDelImgPd)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(427, 35)
        Me.PanelControl1.TabIndex = 724
        '
        'frmSlSalePic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(427, 462)
        Me.Controls.Add(Me.Lv)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSlSalePic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รูปภาพอ้างอิงรายการขายสินค้า"
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ofdUpImg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Lv As System.Windows.Forms.ListView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Img1 As System.Windows.Forms.ImageList
    Friend WithEvents btn_OK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSelectImgPd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelImgPd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
