<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlPdApprove
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
        Me.CHKname = New System.Windows.Forms.CheckBox
        Me.CHKtype = New System.Windows.Forms.CheckBox
        Me.CHKapp = New System.Windows.Forms.CheckBox
        Me.CHKcheck = New System.Windows.Forms.CheckBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txttype = New System.Windows.Forms.TextBox
        Me.dgvData = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_show = New System.Windows.Forms.Button
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colselect = New System.Windows.Forms.DataGridViewImageColumn
        Me.colcancel = New System.Windows.Forms.DataGridViewImageColumn
        Me.colPdTradeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPlantTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTrademark = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPsAdd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPsCheck = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPsApp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idPdT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colidSeedType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateCheck = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateApp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idPsCheck = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idPsApp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idPlant = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CHKname
        '
        Me.CHKname.AutoSize = True
        Me.CHKname.Location = New System.Drawing.Point(108, 13)
        Me.CHKname.Name = "CHKname"
        Me.CHKname.Size = New System.Drawing.Size(65, 17)
        Me.CHKname.TabIndex = 1
        Me.CHKname.Text = "ชื่อสินค้า"
        Me.CHKname.UseVisualStyleBackColor = True
        '
        'CHKtype
        '
        Me.CHKtype.AutoSize = True
        Me.CHKtype.Location = New System.Drawing.Point(108, 38)
        Me.CHKtype.Name = "CHKtype"
        Me.CHKtype.Size = New System.Drawing.Size(78, 17)
        Me.CHKtype.TabIndex = 2
        Me.CHKtype.Text = "ประเภทพืช"
        Me.CHKtype.UseVisualStyleBackColor = True
        '
        'CHKapp
        '
        Me.CHKapp.AutoSize = True
        Me.CHKapp.Location = New System.Drawing.Point(478, 38)
        Me.CHKapp.Name = "CHKapp"
        Me.CHKapp.Size = New System.Drawing.Size(123, 17)
        Me.CHKapp.TabIndex = 3
        Me.CHKapp.Text = "สถานะยังไม่ได้อนุมัติ"
        Me.CHKapp.UseVisualStyleBackColor = True
        '
        'CHKcheck
        '
        Me.CHKcheck.AutoSize = True
        Me.CHKcheck.Location = New System.Drawing.Point(478, 13)
        Me.CHKcheck.Name = "CHKcheck"
        Me.CHKcheck.Size = New System.Drawing.Size(139, 17)
        Me.CHKcheck.TabIndex = 4
        Me.CHKcheck.Text = "สถานะยังไม่ได้ตรวจสอบ"
        Me.CHKcheck.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(209, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(197, 20)
        Me.txtName.TabIndex = 403
        '
        'txttype
        '
        Me.txttype.Enabled = False
        Me.txttype.Location = New System.Drawing.Point(209, 35)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(197, 20)
        Me.txttype.TabIndex = 404
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
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.colselect, Me.colcancel, Me.colPdTradeName, Me.colPlantTypeName, Me.colTrademark, Me.colPP, Me.colPsAdd, Me.colPsCheck, Me.colPsApp, Me.idPdT, Me.colidSeedType, Me.DateCheck, Me.DateApp, Me.idPsCheck, Me.idPsApp, Me.idPlant})
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvData.Location = New System.Drawing.Point(0, 114)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.Size = New System.Drawing.Size(864, 353)
        Me.dgvData.TabIndex = 409
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btn_show)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(864, 44)
        Me.Panel2.TabIndex = 410
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(621, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
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
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "เลือก"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "ยกเลือกการตรวจสอบ"
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(623, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 411
        Me.Label1.Text = "ยังไม่ได้ตรวจสอบ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(607, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 412
        Me.Label2.Text = "ยังไม่ได้อนุมัติ"
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
        'colPdTradeName
        '
        Me.colPdTradeName.DataPropertyName = "PdTradeName"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colPdTradeName.DefaultCellStyle = DataGridViewCellStyle2
        Me.colPdTradeName.HeaderText = "ชื่อสินค้า"
        Me.colPdTradeName.Name = "colPdTradeName"
        Me.colPdTradeName.ReadOnly = True
        Me.colPdTradeName.Width = 150
        '
        'colPlantTypeName
        '
        Me.colPlantTypeName.DataPropertyName = "PlantTypeName"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colPlantTypeName.DefaultCellStyle = DataGridViewCellStyle3
        Me.colPlantTypeName.HeaderText = "ประเภทพืช"
        Me.colPlantTypeName.Name = "colPlantTypeName"
        Me.colPlantTypeName.ReadOnly = True
        Me.colPlantTypeName.Width = 90
        '
        'colTrademark
        '
        Me.colTrademark.DataPropertyName = "Trademark"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colTrademark.DefaultCellStyle = DataGridViewCellStyle4
        Me.colTrademark.HeaderText = "ตราการค้า"
        Me.colTrademark.Name = "colTrademark"
        '
        'colPP
        '
        Me.colPP.DataPropertyName = "PP"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colPP.DefaultCellStyle = DataGridViewCellStyle5
        Me.colPP.HeaderText = "เลขที่พพ"
        Me.colPP.Name = "colPP"
        '
        'colPsAdd
        '
        Me.colPsAdd.DataPropertyName = "PsAdd"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPsAdd.DefaultCellStyle = DataGridViewCellStyle6
        Me.colPsAdd.HeaderText = "ผู้เพิ่มข้อมูล"
        Me.colPsAdd.Name = "colPsAdd"
        '
        'colPsCheck
        '
        Me.colPsCheck.DataPropertyName = "PsCheck"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPsCheck.DefaultCellStyle = DataGridViewCellStyle7
        Me.colPsCheck.HeaderText = "ผู้ตรวจสอบ"
        Me.colPsCheck.Name = "colPsCheck"
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
        'idPdT
        '
        Me.idPdT.DataPropertyName = "idPdT"
        Me.idPdT.HeaderText = "idPdT"
        Me.idPdT.Name = "idPdT"
        Me.idPdT.Visible = False
        '
        'colidSeedType
        '
        Me.colidSeedType.DataPropertyName = "idSeedType"
        Me.colidSeedType.HeaderText = "idSeedType"
        Me.colidSeedType.Name = "colidSeedType"
        Me.colidSeedType.Visible = False
        '
        'DateCheck
        '
        Me.DateCheck.DataPropertyName = "DateCheck"
        Me.DateCheck.HeaderText = "DateCheck"
        Me.DateCheck.Name = "DateCheck"
        Me.DateCheck.Visible = False
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
        Me.idPsCheck.DataPropertyName = "idPsCheck"
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
        'idPlant
        '
        Me.idPlant.DataPropertyName = "idPlant"
        Me.idPlant.HeaderText = "idPlant"
        Me.idPlant.Name = "idPlant"
        Me.idPlant.Visible = False
        '
        'frmSlPdApprove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(864, 467)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.CHKcheck)
        Me.Controls.Add(Me.CHKapp)
        Me.Controls.Add(Me.CHKtype)
        Me.Controls.Add(Me.CHKname)
        Me.Name = "frmSlPdApprove"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSlPdApprove"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CHKname As System.Windows.Forms.CheckBox
    Friend WithEvents CHKtype As System.Windows.Forms.CheckBox
    Friend WithEvents CHKapp As System.Windows.Forms.CheckBox
    Friend WithEvents CHKcheck As System.Windows.Forms.CheckBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txttype As System.Windows.Forms.TextBox
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_show As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colselect As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colcancel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colPdTradeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlantTypeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTrademark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsAdd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsCheck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsApp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPdT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidSeedType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCheck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateApp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPsCheck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPsApp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPlant As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
