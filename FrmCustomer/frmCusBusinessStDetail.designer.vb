<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusBusinessStDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusBusinessStDetail))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbNote = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_save = New System.Windows.Forms.Button
        Me.cbBuy = New System.Windows.Forms.CheckBox
        Me.cbSale = New System.Windows.Forms.CheckBox
        Me.lbCusName = New System.Windows.Forms.Label
        Me.lbAddress = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbPsName = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 619
        Me.Label3.Text = "ที่อยู่ : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 618
        Me.Label2.Text = "ชื่อลูกค้า : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 620
        Me.Label1.Text = "หมายเหตุ"
        '
        'tbNote
        '
        Me.tbNote.Location = New System.Drawing.Point(157, 254)
        Me.tbNote.Multiline = True
        Me.tbNote.Name = "tbNote"
        Me.tbNote.Size = New System.Drawing.Size(205, 57)
        Me.tbNote.TabIndex = 621
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 331)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 40)
        Me.Panel1.TabIndex = 622
        '
        'btn_save
        '
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(0, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 36)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'cbBuy
        '
        Me.cbBuy.AutoSize = True
        Me.cbBuy.Location = New System.Drawing.Point(157, 217)
        Me.cbBuy.Name = "cbBuy"
        Me.cbBuy.Size = New System.Drawing.Size(46, 17)
        Me.cbBuy.TabIndex = 623
        Me.cbBuy.Text = "ผู้ซื้อ"
        Me.cbBuy.UseVisualStyleBackColor = True
        '
        'cbSale
        '
        Me.cbSale.AutoSize = True
        Me.cbSale.Location = New System.Drawing.Point(219, 217)
        Me.cbSale.Name = "cbSale"
        Me.cbSale.Size = New System.Drawing.Size(51, 17)
        Me.cbSale.TabIndex = 624
        Me.cbSale.Text = "ผู้ขาย"
        Me.cbSale.UseVisualStyleBackColor = True
        '
        'lbCusName
        '
        Me.lbCusName.Location = New System.Drawing.Point(154, 34)
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(208, 30)
        Me.lbCusName.TabIndex = 625
        Me.lbCusName.Text = "lbCusName"
        '
        'lbAddress
        '
        Me.lbAddress.Location = New System.Drawing.Point(154, 74)
        Me.lbAddress.Name = "lbAddress"
        Me.lbAddress.Size = New System.Drawing.Size(208, 60)
        Me.lbAddress.TabIndex = 626
        Me.lbAddress.Text = "lbAddress"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 627
        Me.Label4.Text = "สถานะ : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 628
        Me.Label5.Text = "เจ้าหน้าที่ขายที่ดูแล : "
        '
        'lbPsName
        '
        Me.lbPsName.Location = New System.Drawing.Point(154, 146)
        Me.lbPsName.Name = "lbPsName"
        Me.lbPsName.Size = New System.Drawing.Size(208, 60)
        Me.lbPsName.TabIndex = 629
        Me.lbPsName.Text = "lbPsName"
        '
        'frmCusBusinessStDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(484, 371)
        Me.Controls.Add(Me.lbPsName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbAddress)
        Me.Controls.Add(Me.lbCusName)
        Me.Controls.Add(Me.cbSale)
        Me.Controls.Add(Me.cbBuy)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbNote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "frmCusBusinessStDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายละเอียดสถานะการซื้อขายของคู่ค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbNote As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents cbBuy As System.Windows.Forms.CheckBox
    Friend WithEvents cbSale As System.Windows.Forms.CheckBox
    Friend WithEvents lbCusName As System.Windows.Forms.Label
    Friend WithEvents lbAddress As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbPsName As System.Windows.Forms.Label
End Class
