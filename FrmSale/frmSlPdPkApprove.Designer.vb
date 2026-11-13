<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlPdPkApprove
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_show = New System.Windows.Forms.Button
        Me.dgvData = New System.Windows.Forms.DataGridView
        Me.CHKcheck = New System.Windows.Forms.CheckBox
        Me.CHKapp = New System.Windows.Forms.CheckBox
        Me.txtsname = New System.Windows.Forms.TextBox
        Me.CHKname = New System.Windows.Forms.CheckBox
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colselect = New System.Windows.Forms.DataGridViewImageColumn
        Me.colcancel = New System.Windows.Forms.DataGridViewImageColumn
        Me.PdPkName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceRetail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceBill = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceWholeSale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PerBox = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPsCheck = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPsApp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idPdPk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateCheck = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idPdT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateApp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idPsCheck = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idPsApp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(607, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 422
        Me.Label2.Text = "ยังไม่ได้อนุมัติ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(623, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 421
        Me.Label1.Text = "ยังไม่ได้ตรวจสอบ"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btn_show)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(844, 44)
        Me.Panel2.TabIndex = 420
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(621, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 413
        Me.Label3.Text = "รายการทั้งหมด"
        '
        'btn_show
        '
        Me.btn_show.AutoSize = True
        Me.btn_show.BackColor = System.Drawing.Color.DimGray
        Me.btn_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_show.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_show.ForeColor = System.Drawing.Color.White
        Me.btn_show.Image = Global.SAM.My.Resources.Resources.Find
        Me.btn_show.Location = New System.Drawing.Point(3, 1)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(108, 40)
        Me.btn_show.TabIndex = 400
        Me.btn_show.Text = "แสดงข้อมูล"
        Me.btn_show.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_show.UseVisualStyleBackColor = False
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.colselect, Me.colcancel, Me.PdPkName, Me.PriceRetail, Me.PriceBill, Me.PriceWholeSale, Me.PerBox, Me.colPsCheck, Me.colPsApp, Me.idPdPk, Me.DateCheck, Me.idPdT, Me.DateApp, Me.idPsCheck, Me.idPsApp})
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvData.Location = New System.Drawing.Point(0, 122)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.Size = New System.Drawing.Size(844, 460)
        Me.dgvData.TabIndex = 419
        '
        'CHKcheck
        '
        Me.CHKcheck.AutoSize = True
        Me.CHKcheck.Location = New System.Drawing.Point(478, 20)
        Me.CHKcheck.Name = "CHKcheck"
        Me.CHKcheck.Size = New System.Drawing.Size(139, 17)
        Me.CHKcheck.TabIndex = 416
        Me.CHKcheck.Text = "สถานะยังไม่ได้ตรวจสอบ"
        Me.CHKcheck.UseVisualStyleBackColor = True
        '
        'CHKapp
        '
        Me.CHKapp.AutoSize = True
        Me.CHKapp.Location = New System.Drawing.Point(478, 48)
        Me.CHKapp.Name = "CHKapp"
        Me.CHKapp.Size = New System.Drawing.Size(123, 17)
        Me.CHKapp.TabIndex = 415
        Me.CHKapp.Text = "สถานะยังไม่ได้อนุมัติ"
        Me.CHKapp.UseVisualStyleBackColor = True
        '
        'txtsname
        '
        Me.txtsname.Enabled = False
        Me.txtsname.Location = New System.Drawing.Point(172, 31)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(197, 20)
        Me.txtsname.TabIndex = 430
        '
        'CHKname
        '
        Me.CHKname.AutoSize = True
        Me.CHKname.Location = New System.Drawing.Point(92, 34)
        Me.CHKname.Name = "CHKname"
        Me.CHKname.Size = New System.Drawing.Size(65, 17)
        Me.CHKname.TabIndex = 429
        Me.CHKname.Text = "ชื่อสินค้า"
        Me.CHKname.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "เลือก"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 35
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "ยกเลิก"
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 50
        '
        'colautonum
        '
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.Width = 35
        '
        'colselect
        '
        Me.colselect.HeaderText = "เลือก"
        Me.colselect.Image = Global.SAM.My.Resources.Resources.Doc16
        Me.colselect.Name = "colselect"
        Me.colselect.Width = 35
        '
        'colcancel
        '
        Me.colcancel.HeaderText = "ยกเลิก"
        Me.colcancel.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.colcancel.Name = "colcancel"
        Me.colcancel.Width = 50
        '
        'PdPkName
        '
        Me.PdPkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PdPkName.DataPropertyName = "PdPkName"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PdPkName.DefaultCellStyle = DataGridViewCellStyle2
        Me.PdPkName.HeaderText = "ชื่อสินค้า"
        Me.PdPkName.Name = "PdPkName"
        Me.PdPkName.ReadOnly = True
        Me.PdPkName.Width = 184
        '
        'PriceRetail
        '
        Me.PriceRetail.DataPropertyName = "PriceRetail"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PriceRetail.DefaultCellStyle = DataGridViewCellStyle3
        Me.PriceRetail.HeaderText = "ราคาปลีก"
        Me.PriceRetail.Name = "PriceRetail"
        Me.PriceRetail.Width = 80
        '
        'PriceBill
        '
        Me.PriceBill.DataPropertyName = "PriceBill"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PriceBill.DefaultCellStyle = DataGridViewCellStyle4
        Me.PriceBill.HeaderText = "ราคาหน้าบิล"
        Me.PriceBill.Name = "PriceBill"
        Me.PriceBill.Width = 90
        '
        'PriceWholeSale
        '
        Me.PriceWholeSale.DataPropertyName = "PriceWholeSale"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PriceWholeSale.DefaultCellStyle = DataGridViewCellStyle5
        Me.PriceWholeSale.HeaderText = "ราคาส่ง"
        Me.PriceWholeSale.Name = "PriceWholeSale"
        Me.PriceWholeSale.Width = 70
        '
        'PerBox
        '
        Me.PerBox.DataPropertyName = "PerBox"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PerBox.DefaultCellStyle = DataGridViewCellStyle6
        Me.PerBox.HeaderText = "จำนวนขายต่อกล่อง"
        Me.PerBox.Name = "PerBox"
        Me.PerBox.Width = 120
        '
        'colPsCheck
        '
        Me.colPsCheck.DataPropertyName = "PsChk"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPsCheck.DefaultCellStyle = DataGridViewCellStyle7
        Me.colPsCheck.HeaderText = "ผู้ตรวจสอบ"
        Me.colPsCheck.Name = "colPsCheck"
        Me.colPsCheck.Width = 90
        '
        'colPsApp
        '
        Me.colPsApp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPsApp.DataPropertyName = "PsApp"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPsApp.DefaultCellStyle = DataGridViewCellStyle8
        Me.colPsApp.HeaderText = "ผู้อนุมัติ"
        Me.colPsApp.Name = "colPsApp"
        '
        'idPdPk
        '
        Me.idPdPk.DataPropertyName = "idPdPk"
        Me.idPdPk.HeaderText = "idPdPk"
        Me.idPdPk.Name = "idPdPk"
        Me.idPdPk.Visible = False
        '
        'DateCheck
        '
        Me.DateCheck.DataPropertyName = "DateChk"
        Me.DateCheck.HeaderText = "DateCheck"
        Me.DateCheck.Name = "DateCheck"
        Me.DateCheck.Visible = False
        '
        'idPdT
        '
        Me.idPdT.DataPropertyName = "idPdT"
        Me.idPdT.HeaderText = "idPdT"
        Me.idPdT.Name = "idPdT"
        Me.idPdT.Visible = False
        '
        'DateApp
        '
        Me.DateApp.DataPropertyName = "DateApp"
        Me.DateApp.HeaderText = "DateApp"
        Me.DateApp.Name = "DateApp"
        Me.DateApp.Visible = False
        '
        'idPsCheck
        '
        Me.idPsCheck.DataPropertyName = "idPsChk"
        Me.idPsCheck.HeaderText = "idPsCheck"
        Me.idPsCheck.Name = "idPsCheck"
        Me.idPsCheck.Visible = False
        '
        'idPsApp
        '
        Me.idPsApp.DataPropertyName = "idPsApp"
        Me.idPsApp.HeaderText = "idPsApp"
        Me.idPsApp.Name = "idPsApp"
        Me.idPsApp.Visible = False
        '
        'frmSlPdPkApprove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 582)
        Me.Controls.Add(Me.txtsname)
        Me.Controls.Add(Me.CHKname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.CHKcheck)
        Me.Controls.Add(Me.CHKapp)
        Me.Name = "frmSlPdPkApprove"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSlPdPkApprove"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_show As System.Windows.Forms.Button
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents CHKcheck As System.Windows.Forms.CheckBox
    Friend WithEvents CHKapp As System.Windows.Forms.CheckBox
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents CHKname As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colselect As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colcancel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PdPkName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceRetail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceBill As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceWholeSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PerBox As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsCheck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsApp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPdPk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCheck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPdT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateApp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPsCheck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPsApp As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
