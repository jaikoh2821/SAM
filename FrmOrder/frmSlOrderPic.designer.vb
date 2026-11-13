<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlOrderPic
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
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnDelImgPd = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnSelectImgPd = New System.Windows.Forms.Button
        Me.Lv = New System.Windows.Forms.ListView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btn_OK = New System.Windows.Forms.Button
        Me.ofdUpImg = New System.Windows.Forms.OpenFileDialog
        Me.Img1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnDelImgPd)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnSelectImgPd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 38)
        Me.Panel1.TabIndex = 676
        '
        'btnDelImgPd
        '
        Me.btnDelImgPd.BackColor = System.Drawing.Color.DimGray
        Me.btnDelImgPd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelImgPd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDelImgPd.ForeColor = System.Drawing.Color.White
        Me.btnDelImgPd.Location = New System.Drawing.Point(367, 3)
        Me.btnDelImgPd.Name = "btnDelImgPd"
        Me.btnDelImgPd.Size = New System.Drawing.Size(55, 27)
        Me.btnDelImgPd.TabIndex = 668
        Me.btnDelImgPd.Text = "ลบรูป"
        Me.btnDelImgPd.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(4, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 17)
        Me.Label7.TabIndex = 667
        Me.Label7.Text = "ไฟล์รูปภาพอ้างอิงรายการสั่งซื้อสินค้า"
        '
        'btnSelectImgPd
        '
        Me.btnSelectImgPd.BackColor = System.Drawing.Color.DimGray
        Me.btnSelectImgPd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectImgPd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelectImgPd.ForeColor = System.Drawing.Color.White
        Me.btnSelectImgPd.Location = New System.Drawing.Point(315, 3)
        Me.btnSelectImgPd.Name = "btnSelectImgPd"
        Me.btnSelectImgPd.Size = New System.Drawing.Size(53, 28)
        Me.btnSelectImgPd.TabIndex = 666
        Me.btnSelectImgPd.Text = "เพิ่มรูป"
        Me.btnSelectImgPd.UseVisualStyleBackColor = False
        '
        'Lv
        '
        Me.Lv.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Lv.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.Lv.LargeImageList = Me.Img1
        Me.Lv.Location = New System.Drawing.Point(0, 38)
        Me.Lv.MultiSelect = False
        Me.Lv.Name = "Lv"
        Me.Lv.Size = New System.Drawing.Size(434, 391)
        Me.Lv.TabIndex = 677
        Me.Lv.TileSize = New System.Drawing.Size(250, 30)
        Me.Lv.UseCompatibleStateImageBehavior = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_OK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 426)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(434, 36)
        Me.Panel2.TabIndex = 675
        '
        'btn_OK
        '
        Me.btn_OK.AutoSize = True
        Me.btn_OK.BackColor = System.Drawing.Color.DimGray
        Me.btn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_OK.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_OK.ForeColor = System.Drawing.Color.White
        Me.btn_OK.Image = Global.SAM.My.Resources.Resources.Add28
        Me.btn_OK.Location = New System.Drawing.Point(0, 0)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(92, 34)
        Me.btn_OK.TabIndex = 672
        Me.btn_OK.Text = "  บันทึก"
        Me.btn_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_OK.UseVisualStyleBackColor = False
        '
        'ofdUpImg
        '
        Me.ofdUpImg.Filter = "*.jpg|*.jpg"
        '
        'Img1
        '
        Me.Img1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.Img1.ImageSize = New System.Drawing.Size(32, 32)
        Me.Img1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmSlOrderPic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(434, 462)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lv)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "frmSlOrderPic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รูปภาพอ้างอิงรายการสั่งซื้อสินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDelImgPd As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSelectImgPd As System.Windows.Forms.Button
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents Lv As System.Windows.Forms.ListView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ofdUpImg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Img1 As System.Windows.Forms.ImageList
End Class
