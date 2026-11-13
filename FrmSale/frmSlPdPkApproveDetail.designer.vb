<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlPdPkApproveDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlPdPkApproveDetail))
        Me.labelcheck = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDateApp = New System.Windows.Forms.TextBox
        Me.txtDateCheck = New System.Windows.Forms.TextBox
        Me.txtApp = New System.Windows.Forms.TextBox
        Me.txtCheck = New System.Windows.Forms.TextBox
        Me.txtPerBox = New System.Windows.Forms.TextBox
        Me.txtPriceWholeSale = New System.Windows.Forms.TextBox
        Me.txtPriceBill = New System.Windows.Forms.TextBox
        Me.txtPriceRetail = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Img1 = New System.Windows.Forms.PictureBox
        Me.btn_app = New System.Windows.Forms.Button
        Me.btn_Check = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        CType(Me.Img1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelcheck
        '
        Me.labelcheck.AutoSize = True
        Me.labelcheck.ForeColor = System.Drawing.Color.Red
        Me.labelcheck.Location = New System.Drawing.Point(60, 389)
        Me.labelcheck.Name = "labelcheck"
        Me.labelcheck.Size = New System.Drawing.Size(0, 13)
        Me.labelcheck.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(272, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 20)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "วันที่"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(272, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 20)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "วันที่"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "ผู้ตรวจสอบ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 365)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "ผู้อนุมัติ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "จำนวนขายต่อกล่อง"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "ราคาส่ง"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "ราคาหน้าบิล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "ราคาปลีก"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "ชื่อสินค้า"
        '
        'txtDateApp
        '
        Me.txtDateApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDateApp.Location = New System.Drawing.Point(313, 359)
        Me.txtDateApp.Name = "txtDateApp"
        Me.txtDateApp.ReadOnly = True
        Me.txtDateApp.Size = New System.Drawing.Size(100, 26)
        Me.txtDateApp.TabIndex = 35
        '
        'txtDateCheck
        '
        Me.txtDateCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDateCheck.Location = New System.Drawing.Point(313, 311)
        Me.txtDateCheck.Name = "txtDateCheck"
        Me.txtDateCheck.ReadOnly = True
        Me.txtDateCheck.Size = New System.Drawing.Size(100, 26)
        Me.txtDateCheck.TabIndex = 34
        '
        'txtApp
        '
        Me.txtApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtApp.Location = New System.Drawing.Point(93, 359)
        Me.txtApp.Name = "txtApp"
        Me.txtApp.ReadOnly = True
        Me.txtApp.Size = New System.Drawing.Size(149, 26)
        Me.txtApp.TabIndex = 33
        '
        'txtCheck
        '
        Me.txtCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCheck.Location = New System.Drawing.Point(94, 311)
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.ReadOnly = True
        Me.txtCheck.Size = New System.Drawing.Size(148, 26)
        Me.txtCheck.TabIndex = 29
        '
        'txtPerBox
        '
        Me.txtPerBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPerBox.Location = New System.Drawing.Point(146, 187)
        Me.txtPerBox.Name = "txtPerBox"
        Me.txtPerBox.ReadOnly = True
        Me.txtPerBox.Size = New System.Drawing.Size(102, 26)
        Me.txtPerBox.TabIndex = 28
        Me.txtPerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPriceWholeSale
        '
        Me.txtPriceWholeSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPriceWholeSale.Location = New System.Drawing.Point(100, 146)
        Me.txtPriceWholeSale.Name = "txtPriceWholeSale"
        Me.txtPriceWholeSale.ReadOnly = True
        Me.txtPriceWholeSale.Size = New System.Drawing.Size(148, 26)
        Me.txtPriceWholeSale.TabIndex = 27
        Me.txtPriceWholeSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPriceBill
        '
        Me.txtPriceBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPriceBill.Location = New System.Drawing.Point(100, 107)
        Me.txtPriceBill.Name = "txtPriceBill"
        Me.txtPriceBill.ReadOnly = True
        Me.txtPriceBill.Size = New System.Drawing.Size(148, 26)
        Me.txtPriceBill.TabIndex = 26
        Me.txtPriceBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPriceRetail
        '
        Me.txtPriceRetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPriceRetail.Location = New System.Drawing.Point(100, 65)
        Me.txtPriceRetail.Name = "txtPriceRetail"
        Me.txtPriceRetail.ReadOnly = True
        Me.txtPriceRetail.Size = New System.Drawing.Size(148, 26)
        Me.txtPriceRetail.TabIndex = 25
        Me.txtPriceRetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName.Location = New System.Drawing.Point(100, 24)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(346, 26)
        Me.txtName.TabIndex = 24
        '
        'Img1
        '
        Me.Img1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Img1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Img1.ErrorImage = Nothing
        Me.Img1.Location = New System.Drawing.Point(452, 0)
        Me.Img1.Name = "Img1"
        Me.Img1.Size = New System.Drawing.Size(428, 476)
        Me.Img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img1.TabIndex = 32
        Me.Img1.TabStop = False
        '
        'btn_app
        '
        Me.btn_app.AutoSize = True
        Me.btn_app.BackColor = System.Drawing.Color.DimGray
        Me.btn_app.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_app.Enabled = False
        Me.btn_app.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_app.ForeColor = System.Drawing.Color.White
        Me.btn_app.Image = CType(resources.GetObject("btn_app.Image"), System.Drawing.Image)
        Me.btn_app.Location = New System.Drawing.Point(234, 1)
        Me.btn_app.Name = "btn_app"
        Me.btn_app.Size = New System.Drawing.Size(111, 40)
        Me.btn_app.TabIndex = 31
        Me.btn_app.Text = "อนุมัติสินค้า"
        Me.btn_app.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_app.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_app.UseVisualStyleBackColor = False
        '
        'btn_Check
        '
        Me.btn_Check.AutoSize = True
        Me.btn_Check.BackColor = System.Drawing.Color.DimGray
        Me.btn_Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Check.Enabled = False
        Me.btn_Check.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_Check.ForeColor = System.Drawing.Color.White
        Me.btn_Check.Image = CType(resources.GetObject("btn_Check.Image"), System.Drawing.Image)
        Me.btn_Check.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Check.Location = New System.Drawing.Point(59, 1)
        Me.btn_Check.Name = "btn_Check"
        Me.btn_Check.Size = New System.Drawing.Size(138, 40)
        Me.btn_Check.TabIndex = 30
        Me.btn_Check.Text = "ตรวจสอบสินค้า"
        Me.btn_Check.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Check.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_Check)
        Me.Panel2.Controls.Add(Me.btn_app)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 432)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(452, 44)
        Me.Panel2.TabIndex = 421
        '
        'frmSlPdPkApproveDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 476)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.labelcheck)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDateApp)
        Me.Controls.Add(Me.txtDateCheck)
        Me.Controls.Add(Me.txtApp)
        Me.Controls.Add(Me.txtCheck)
        Me.Controls.Add(Me.txtPerBox)
        Me.Controls.Add(Me.txtPriceWholeSale)
        Me.Controls.Add(Me.txtPriceBill)
        Me.Controls.Add(Me.txtPriceRetail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Img1)
        Me.Name = "frmSlPdPkApproveDetail"
        Me.Text = "frmSlPdPkApproveDetail"
        CType(Me.Img1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelcheck As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDateApp As System.Windows.Forms.TextBox
    Friend WithEvents txtDateCheck As System.Windows.Forms.TextBox
    Friend WithEvents txtApp As System.Windows.Forms.TextBox
    Friend WithEvents Img1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_app As System.Windows.Forms.Button
    Friend WithEvents btn_Check As System.Windows.Forms.Button
    Friend WithEvents txtCheck As System.Windows.Forms.TextBox
    Friend WithEvents txtPerBox As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceWholeSale As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceBill As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceRetail As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
