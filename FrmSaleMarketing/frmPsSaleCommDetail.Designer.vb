<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPsSaleCommDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPsSaleCommDetail))
        Me.txt_Pay = New System.Windows.Forms.TextBox
        Me.txt_Comm = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_PdtName = New System.Windows.Forms.TextBox
        Me.btn_seed = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btn_del = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Pay
        '
        Me.txt_Pay.Location = New System.Drawing.Point(102, 41)
        Me.txt_Pay.Name = "txt_Pay"
        Me.txt_Pay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Pay.Size = New System.Drawing.Size(134, 20)
        Me.txt_Pay.TabIndex = 1
        '
        'txt_Comm
        '
        Me.txt_Comm.Location = New System.Drawing.Point(102, 67)
        Me.txt_Comm.Name = "txt_Comm"
        Me.txt_Comm.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Comm.Size = New System.Drawing.Size(134, 20)
        Me.txt_Comm.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ชื่อสินค้า"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ยอดขาย"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "คอมมิสชั่น (%)"
        '
        'txt_PdtName
        '
        Me.txt_PdtName.Location = New System.Drawing.Point(102, 15)
        Me.txt_PdtName.Name = "txt_PdtName"
        Me.txt_PdtName.Size = New System.Drawing.Size(100, 20)
        Me.txt_PdtName.TabIndex = 8
        Me.txt_PdtName.Visible = False
        '
        'btn_seed
        '
        Me.btn_seed.BackColor = System.Drawing.Color.DimGray
        Me.btn_seed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_seed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_seed.ForeColor = System.Drawing.Color.White
        Me.btn_seed.Image = CType(resources.GetObject("btn_seed.Image"), System.Drawing.Image)
        Me.btn_seed.Location = New System.Drawing.Point(208, 12)
        Me.btn_seed.Name = "btn_seed"
        Me.btn_seed.Size = New System.Drawing.Size(28, 25)
        Me.btn_seed.TabIndex = 630
        Me.btn_seed.Tag = "Add"
        Me.btn_seed.UseVisualStyleBackColor = False
        Me.btn_seed.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.Controls.Add(Me.btn_del)
        Me.Panel3.Controls.Add(Me.btn_save)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 111)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(291, 40)
        Me.Panel3.TabIndex = 631
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.DimGray
        Me.btn_del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_del.ForeColor = System.Drawing.Color.White
        Me.btn_del.Image = Global.SAM.My.Resources.Resources.ImgNotprocess
        Me.btn_del.Location = New System.Drawing.Point(91, 0)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(67, 38)
        Me.btn_del.TabIndex = 415
        Me.btn_del.Tag = ""
        Me.btn_del.Text = "ลบ"
        Me.btn_del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_del.UseVisualStyleBackColor = False
        Me.btn_del.Visible = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(3, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(82, 38)
        Me.btn_save.TabIndex = 414
        Me.btn_save.Tag = ""
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'frmPsSaleCommDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(291, 151)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_seed)
        Me.Controls.Add(Me.txt_PdtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Comm)
        Me.Controls.Add(Me.txt_Pay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPsSaleCommDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "กำหนดค่าคอมมิสชั่นเจ้าหน้าที่ขาย"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Pay As System.Windows.Forms.TextBox
    Friend WithEvents txt_Comm As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_PdtName As System.Windows.Forms.TextBox
    Friend WithEvents btn_seed As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
End Class
