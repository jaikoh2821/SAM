<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerSelect
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerSelect))
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPsSale = New System.Windows.Forms.Label()
        Me.lblSale = New System.Windows.Forms.Label()
        Me.RbCusPs = New System.Windows.Forms.RadioButton()
        Me.Rball = New System.Windows.Forms.RadioButton()
        Me.rdbFrgOnly = New System.Windows.Forms.RadioButton()
        Me.rdbFrgSale = New System.Windows.Forms.RadioButton()
        Me.rdbInOnly = New System.Windows.Forms.RadioButton()
        Me.rdbInSale = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbPv = New System.Windows.Forms.ComboBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.ChkCus = New System.Windows.Forms.CheckBox()
        Me.ChkTel = New System.Windows.Forms.CheckBox()
        Me.ChkPv = New System.Windows.Forms.CheckBox()
        Me.GC_Customer = New DevExpress.XtraGrid.GridControl()
        Me.GV_Customer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColSelectChk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptChkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ColidCus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmpher = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProvince = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidPsAccpet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidTspS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCusInComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidPayTsp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSupTsp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSupName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddressS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidFm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidPartner = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidRefAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPsRecName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstRight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colflag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GvProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnShowdata = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GC_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptChkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCusName
        '
        Me.txtCusName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCusName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCusName.Enabled = False
        Me.txtCusName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusName.Location = New System.Drawing.Point(78, 17)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(141, 21)
        Me.txtCusName.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.txtCount)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(935, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(199, 43)
        Me.Panel3.TabIndex = 613
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(108, 8)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(84, 26)
        Me.txtCount.TabIndex = 2
        Me.txtCount.TabStop = False
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(6, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 612
        Me.Label5.Text = "จำนวนรายการ"
        '
        'lblPsSale
        '
        Me.lblPsSale.BackColor = System.Drawing.Color.Transparent
        Me.lblPsSale.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblPsSale.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPsSale.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPsSale.Location = New System.Drawing.Point(279, 0)
        Me.lblPsSale.Name = "lblPsSale"
        Me.lblPsSale.Size = New System.Drawing.Size(407, 43)
        Me.lblPsSale.TabIndex = 0
        Me.lblPsSale.Text = "ชื่อ พนักงานขาย"
        Me.lblPsSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPsSale.Visible = False
        '
        'lblSale
        '
        Me.lblSale.BackColor = System.Drawing.Color.Transparent
        Me.lblSale.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblSale.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSale.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSale.Location = New System.Drawing.Point(124, 0)
        Me.lblSale.Name = "lblSale"
        Me.lblSale.Size = New System.Drawing.Size(155, 43)
        Me.lblSale.TabIndex = 609
        Me.lblSale.Text = "ลูกค้าของเจ้าหน้าที่ขาย :"
        Me.lblSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSale.Visible = False
        '
        'RbCusPs
        '
        Me.RbCusPs.AutoSize = True
        Me.RbCusPs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RbCusPs.Location = New System.Drawing.Point(475, 12)
        Me.RbCusPs.Name = "RbCusPs"
        Me.RbCusPs.Size = New System.Drawing.Size(154, 17)
        Me.RbCusPs.TabIndex = 600
        Me.RbCusPs.TabStop = True
        Me.RbCusPs.Text = "เลือกลูกค้าที่ผูกกับเจ้าหน้าที่"
        Me.RbCusPs.UseVisualStyleBackColor = True
        Me.RbCusPs.Visible = False
        '
        'Rball
        '
        Me.Rball.AutoSize = True
        Me.Rball.BackColor = System.Drawing.Color.Transparent
        Me.Rball.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rball.Location = New System.Drawing.Point(475, 35)
        Me.Rball.Name = "Rball"
        Me.Rball.Size = New System.Drawing.Size(110, 17)
        Me.Rball.TabIndex = 2
        Me.Rball.TabStop = True
        Me.Rball.Text = "เลือกลูกค้าทั้งหมด"
        Me.Rball.UseVisualStyleBackColor = False
        Me.Rball.Visible = False
        '
        'rdbFrgOnly
        '
        Me.rdbFrgOnly.AutoSize = True
        Me.rdbFrgOnly.BackColor = System.Drawing.Color.Transparent
        Me.rdbFrgOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFrgOnly.Location = New System.Drawing.Point(475, 58)
        Me.rdbFrgOnly.Name = "rdbFrgOnly"
        Me.rdbFrgOnly.Size = New System.Drawing.Size(132, 17)
        Me.rdbFrgOnly.TabIndex = 3
        Me.rdbFrgOnly.TabStop = True
        Me.rdbFrgOnly.Text = "เฉพาะลูกค้าต่างประเทศ"
        Me.rdbFrgOnly.UseVisualStyleBackColor = False
        Me.rdbFrgOnly.Visible = False
        '
        'rdbFrgSale
        '
        Me.rdbFrgSale.AutoSize = True
        Me.rdbFrgSale.BackColor = System.Drawing.Color.Transparent
        Me.rdbFrgSale.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbFrgSale.Location = New System.Drawing.Point(475, 12)
        Me.rdbFrgSale.Name = "rdbFrgSale"
        Me.rdbFrgSale.Size = New System.Drawing.Size(214, 17)
        Me.rdbFrgSale.TabIndex = 603
        Me.rdbFrgSale.TabStop = True
        Me.rdbFrgSale.Text = "ลูกค้าต่างประเทศที่ผูกติดกับเจ้าหน้าที่ขาย"
        Me.rdbFrgSale.UseVisualStyleBackColor = False
        Me.rdbFrgSale.Visible = False
        '
        'rdbInOnly
        '
        Me.rdbInOnly.AutoSize = True
        Me.rdbInOnly.BackColor = System.Drawing.Color.Transparent
        Me.rdbInOnly.Location = New System.Drawing.Point(475, 60)
        Me.rdbInOnly.Name = "rdbInOnly"
        Me.rdbInOnly.Size = New System.Drawing.Size(133, 17)
        Me.rdbInOnly.TabIndex = 8
        Me.rdbInOnly.TabStop = True
        Me.rdbInOnly.Text = "เฉพาะลูกค้าในประเทศ"
        Me.rdbInOnly.UseVisualStyleBackColor = False
        Me.rdbInOnly.Visible = False
        '
        'rdbInSale
        '
        Me.rdbInSale.AutoSize = True
        Me.rdbInSale.BackColor = System.Drawing.Color.Transparent
        Me.rdbInSale.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbInSale.Location = New System.Drawing.Point(475, 12)
        Me.rdbInSale.Name = "rdbInSale"
        Me.rdbInSale.Size = New System.Drawing.Size(209, 17)
        Me.rdbInSale.TabIndex = 1
        Me.rdbInSale.TabStop = True
        Me.rdbInSale.Text = "ลูกค้าในประเทศที่ผูกติดกับเจ้าหน้าที่ขาย"
        Me.rdbInSale.UseVisualStyleBackColor = False
        Me.rdbInSale.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(867, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 18)
        Me.Label1.TabIndex = 615
        Me.Label1.Text = ": ลูกค้าที่มีสถานะไม่ Active"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightPink
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(835, 58)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(28, 20)
        Me.Panel6.TabIndex = 614
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CmbPv)
        Me.GroupBox1.Controls.Add(Me.txtCusName)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.ChkCus)
        Me.GroupBox1.Controls.Add(Me.ChkTel)
        Me.GroupBox1.Controls.Add(Me.ChkPv)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CmbPv
        '
        Me.CmbPv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbPv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbPv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPv.Enabled = False
        Me.CmbPv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPv.FormattingEnabled = True
        Me.CmbPv.Location = New System.Drawing.Point(293, 18)
        Me.CmbPv.Name = "CmbPv"
        Me.CmbPv.Size = New System.Drawing.Size(141, 21)
        Me.CmbPv.TabIndex = 5
        '
        'txtTel
        '
        Me.txtTel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtTel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtTel.Enabled = False
        Me.txtTel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(78, 43)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(141, 21)
        Me.txtTel.TabIndex = 3
        '
        'ChkCus
        '
        Me.ChkCus.AutoSize = True
        Me.ChkCus.Checked = True
        Me.ChkCus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCus.Location = New System.Drawing.Point(10, 18)
        Me.ChkCus.Name = "ChkCus"
        Me.ChkCus.Size = New System.Drawing.Size(66, 17)
        Me.ChkCus.TabIndex = 0
        Me.ChkCus.Text = "ชื่อลูกค้า"
        Me.ChkCus.UseVisualStyleBackColor = True
        '
        'ChkTel
        '
        Me.ChkTel.AutoSize = True
        Me.ChkTel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTel.Location = New System.Drawing.Point(10, 46)
        Me.ChkTel.Name = "ChkTel"
        Me.ChkTel.Size = New System.Drawing.Size(44, 17)
        Me.ChkTel.TabIndex = 2
        Me.ChkTel.Text = "Tel."
        Me.ChkTel.UseVisualStyleBackColor = True
        '
        'ChkPv
        '
        Me.ChkPv.AutoSize = True
        Me.ChkPv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPv.Location = New System.Drawing.Point(233, 20)
        Me.ChkPv.Name = "ChkPv"
        Me.ChkPv.Size = New System.Drawing.Size(56, 17)
        Me.ChkPv.TabIndex = 4
        Me.ChkPv.Text = "จังหวัด"
        Me.ChkPv.UseVisualStyleBackColor = True
        '
        'GC_Customer
        '
        Me.GC_Customer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_Customer.Location = New System.Drawing.Point(0, 133)
        Me.GC_Customer.MainView = Me.GV_Customer
        Me.GC_Customer.Name = "GC_Customer"
        Me.GC_Customer.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsSelect, Me.rptChkEdit})
        Me.GC_Customer.Size = New System.Drawing.Size(1134, 389)
        Me.GC_Customer.TabIndex = 3
        Me.GC_Customer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Customer, Me.GvProduct})
        '
        'GV_Customer
        '
        Me.GV_Customer.Appearance.EvenRow.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GV_Customer.Appearance.EvenRow.Options.UseFont = True
        Me.GV_Customer.Appearance.FocusedCell.BackColor = System.Drawing.Color.Wheat
        Me.GV_Customer.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GV_Customer.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_Customer.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_Customer.Appearance.FocusedRow.BackColor = System.Drawing.Color.Wheat
        Me.GV_Customer.Appearance.FocusedRow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GV_Customer.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_Customer.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_Customer.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GV_Customer.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_Customer.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GV_Customer.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_Customer.Appearance.Row.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GV_Customer.Appearance.Row.Options.UseBackColor = True
        Me.GV_Customer.Appearance.Row.Options.UseFont = True
        Me.GV_Customer.Appearance.SelectedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GV_Customer.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_Customer.ColumnPanelRowHeight = 30
        Me.GV_Customer.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSelect, Me.ColSelectChk, Me.ColidCus, Me.GridColumn2, Me.colNote, Me.ColAmpher, Me.ColProvince, Me.ColAddress, Me.ColTel, Me.GridColumn3, Me.GridColumn4, Me.colidPsAccpet, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.ColidTspS, Me.GridColumn9, Me.colCusInComp, Me.ColidPayTsp, Me.colidSupTsp, Me.ColSupName, Me.GridColumn10, Me.colAddressS, Me.colidFm, Me.colidPartner, Me.colidRefAddress, Me.colPsRecName, Me.colstRight, Me.colflag})
        Me.GV_Customer.GridControl = Me.GC_Customer
        Me.GV_Customer.GroupFormat = "[#image]{1} {2}"
        Me.GV_Customer.Name = "GV_Customer"
        Me.GV_Customer.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV_Customer.OptionsView.ShowGroupPanel = False
        Me.GV_Customer.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV_Customer.OptionsView.ShowIndicator = False
        '
        'colSelect
        '
        Me.colSelect.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colSelect.AppearanceCell.Options.UseBackColor = True
        Me.colSelect.Caption = "เลือก"
        Me.colSelect.ColumnEdit = Me.rpsSelect
        Me.colSelect.MaxWidth = 40
        Me.colSelect.MinWidth = 40
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Visible = True
        Me.colSelect.VisibleIndex = 0
        Me.colSelect.Width = 40
        '
        'rpsSelect
        '
        Me.rpsSelect.AutoHeight = False
        Me.rpsSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.arrow_modify_old_undo_icone_3957_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rpsSelect.Name = "rpsSelect"
        Me.rpsSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColSelectChk
        '
        Me.ColSelectChk.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.ColSelectChk.AppearanceCell.Options.UseBackColor = True
        Me.ColSelectChk.Caption = "เลือก"
        Me.ColSelectChk.ColumnEdit = Me.rptChkEdit
        Me.ColSelectChk.FieldName = "chk"
        Me.ColSelectChk.MaxWidth = 40
        Me.ColSelectChk.MinWidth = 40
        Me.ColSelectChk.Name = "ColSelectChk"
        Me.ColSelectChk.Width = 40
        '
        'rptChkEdit
        '
        Me.rptChkEdit.AutoHeight = False
        Me.rptChkEdit.Name = "rptChkEdit"
        '
        'ColidCus
        '
        Me.ColidCus.Caption = "idCus"
        Me.ColidCus.FieldName = "idCus"
        Me.ColidCus.Name = "ColidCus"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn2.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn2.Caption = "ชื่อลูกค้า"
        Me.GridColumn2.FieldName = "CusName_"
        Me.GridColumn2.MinWidth = 10
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.OptionsColumn.TabStop = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 272
        '
        'colNote
        '
        Me.colNote.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colNote.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colNote.AppearanceCell.Options.UseBackColor = True
        Me.colNote.AppearanceCell.Options.UseFont = True
        Me.colNote.AppearanceHeader.Options.UseTextOptions = True
        Me.colNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNote.Caption = "หมายเหตุ"
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        Me.colNote.OptionsColumn.AllowEdit = False
        Me.colNote.OptionsColumn.ReadOnly = True
        Me.colNote.OptionsColumn.TabStop = False
        Me.colNote.Visible = True
        Me.colNote.VisibleIndex = 2
        Me.colNote.Width = 218
        '
        'ColAmpher
        '
        Me.ColAmpher.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColAmpher.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmpher.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.ColAmpher.AppearanceCell.Options.UseBackColor = True
        Me.ColAmpher.AppearanceCell.Options.UseFont = True
        Me.ColAmpher.AppearanceCell.Options.UseForeColor = True
        Me.ColAmpher.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmpher.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmpher.Caption = "อำเภอ"
        Me.ColAmpher.FieldName = "ApName"
        Me.ColAmpher.Name = "ColAmpher"
        Me.ColAmpher.OptionsColumn.AllowEdit = False
        Me.ColAmpher.OptionsColumn.ReadOnly = True
        Me.ColAmpher.OptionsColumn.TabStop = False
        Me.ColAmpher.Visible = True
        Me.ColAmpher.VisibleIndex = 3
        Me.ColAmpher.Width = 125
        '
        'ColProvince
        '
        Me.ColProvince.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColProvince.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColProvince.AppearanceCell.Options.UseBackColor = True
        Me.ColProvince.AppearanceCell.Options.UseFont = True
        Me.ColProvince.AppearanceCell.Options.UseTextOptions = True
        Me.ColProvince.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProvince.Caption = "จังหวัด"
        Me.ColProvince.FieldName = "PvName"
        Me.ColProvince.MinWidth = 10
        Me.ColProvince.Name = "ColProvince"
        Me.ColProvince.OptionsColumn.AllowEdit = False
        Me.ColProvince.OptionsColumn.ReadOnly = True
        Me.ColProvince.OptionsColumn.TabStop = False
        Me.ColProvince.Visible = True
        Me.ColProvince.VisibleIndex = 4
        Me.ColProvince.Width = 111
        '
        'ColAddress
        '
        Me.ColAddress.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColAddress.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAddress.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.ColAddress.AppearanceCell.Options.UseBackColor = True
        Me.ColAddress.AppearanceCell.Options.UseFont = True
        Me.ColAddress.AppearanceCell.Options.UseForeColor = True
        Me.ColAddress.AppearanceCell.Options.UseTextOptions = True
        Me.ColAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColAddress.Caption = "ที่อยู่"
        Me.ColAddress.FieldName = "Address"
        Me.ColAddress.MinWidth = 10
        Me.ColAddress.Name = "ColAddress"
        Me.ColAddress.OptionsColumn.AllowEdit = False
        Me.ColAddress.OptionsColumn.ReadOnly = True
        Me.ColAddress.OptionsColumn.TabStop = False
        Me.ColAddress.Visible = True
        Me.ColAddress.VisibleIndex = 5
        Me.ColAddress.Width = 221
        '
        'ColTel
        '
        Me.ColTel.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTel.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTel.AppearanceCell.Options.UseBackColor = True
        Me.ColTel.AppearanceCell.Options.UseFont = True
        Me.ColTel.Caption = "เบอร์โทรศัพท์"
        Me.ColTel.FieldName = "Tel"
        Me.ColTel.Name = "ColTel"
        Me.ColTel.OptionsColumn.AllowEdit = False
        Me.ColTel.OptionsColumn.ReadOnly = True
        Me.ColTel.OptionsColumn.TabStop = False
        Me.ColTel.Visible = True
        Me.ColTel.VisibleIndex = 6
        Me.ColTel.Width = 107
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "ผู้ติดต่อ"
        Me.GridColumn3.FieldName = "CusNameCon_"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "stActive"
        Me.GridColumn4.FieldName = "stActive"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'colidPsAccpet
        '
        Me.colidPsAccpet.Caption = "idPsAccpet"
        Me.colidPsAccpet.FieldName = "idPsAccpet"
        Me.colidPsAccpet.Name = "colidPsAccpet"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "idPsCheck"
        Me.GridColumn5.FieldName = "idPsCheck"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "idPsApprove"
        Me.GridColumn6.FieldName = "idPsApprove"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "idCusType"
        Me.GridColumn7.FieldName = "idCusType"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "ระดับลูกค้า"
        Me.GridColumn8.FieldName = "CusType"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'ColidTspS
        '
        Me.ColidTspS.Caption = "idTspS"
        Me.ColidTspS.FieldName = "idTspS"
        Me.ColidTspS.Name = "ColidTspS"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "เบอร์ผู้ติดต่อ"
        Me.GridColumn9.FieldName = "MobileCon"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'colCusInComp
        '
        Me.colCusInComp.Caption = "colCusInComp"
        Me.colCusInComp.FieldName = "CusInComp"
        Me.colCusInComp.Name = "colCusInComp"
        '
        'ColidPayTsp
        '
        Me.ColidPayTsp.Caption = "idPayTsp"
        Me.ColidPayTsp.FieldName = "idPayTspS"
        Me.ColidPayTsp.Name = "ColidPayTsp"
        '
        'colidSupTsp
        '
        Me.colidSupTsp.Caption = "idSupTsp"
        Me.colidSupTsp.FieldName = "idSupTspS"
        Me.colidSupTsp.Name = "colidSupTsp"
        '
        'ColSupName
        '
        Me.ColSupName.Caption = "SupName"
        Me.ColSupName.FieldName = "SupNameS"
        Me.ColSupName.Name = "ColSupName"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "stAddress"
        Me.GridColumn10.FieldName = "stAddress"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'colAddressS
        '
        Me.colAddressS.Caption = "AddressS"
        Me.colAddressS.FieldName = "AddressS"
        Me.colAddressS.Name = "colAddressS"
        '
        'colidFm
        '
        Me.colidFm.Caption = "idFm"
        Me.colidFm.FieldName = "idFm"
        Me.colidFm.Name = "colidFm"
        '
        'colidPartner
        '
        Me.colidPartner.Caption = "idPartner"
        Me.colidPartner.FieldName = "idPartner"
        Me.colidPartner.Name = "colidPartner"
        '
        'colidRefAddress
        '
        Me.colidRefAddress.Caption = "idRefAddress"
        Me.colidRefAddress.FieldName = "idRefAdrS"
        Me.colidRefAddress.Name = "colidRefAddress"
        '
        'colPsRecName
        '
        Me.colPsRecName.Caption = "PsRecName"
        Me.colPsRecName.FieldName = "PsRecName"
        Me.colPsRecName.Name = "colPsRecName"
        '
        'colstRight
        '
        Me.colstRight.Caption = "GridColumn1"
        Me.colstRight.FieldName = "stRight"
        Me.colstRight.Name = "colstRight"
        '
        'colflag
        '
        Me.colflag.Caption = "flag"
        Me.colflag.FieldName = "flag"
        Me.colflag.Name = "colflag"
        '
        'GvProduct
        '
        Me.GvProduct.Appearance.FocusedCell.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GvProduct.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GvProduct.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvProduct.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvProduct.Appearance.FocusedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GvProduct.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvProduct.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvProduct.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvProduct.Appearance.HeaderPanel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GvProduct.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GvProduct.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvProduct.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvProduct.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GvProduct.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GvProduct.DetailHeight = 600
        Me.GvProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GvProduct.GridControl = Me.GC_Customer
        Me.GvProduct.Name = "GvProduct"
        Me.GvProduct.OptionsView.ColumnAutoWidth = False
        Me.GvProduct.OptionsView.ShowGroupPanel = False
        Me.GvProduct.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.GvProduct.OptionsView.ShowIndicator = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lblPsSale)
        Me.Panel1.Controls.Add(Me.lblSale)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1134, 43)
        Me.Panel1.TabIndex = 723
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnShowdata)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(124, 43)
        Me.Panel2.TabIndex = 614
        '
        'btnShowdata
        '
        Me.btnShowdata.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowdata.Appearance.Options.UseFont = True
        Me.btnShowdata.Image = CType(resources.GetObject("btnShowdata.Image"), System.Drawing.Image)
        Me.btnShowdata.Location = New System.Drawing.Point(3, 3)
        Me.btnShowdata.Name = "btnShowdata"
        Me.btnShowdata.Size = New System.Drawing.Size(120, 37)
        Me.btnShowdata.TabIndex = 0
        Me.btnShowdata.Text = "แสดงข้อมูล"
        '
        'btn_save
        '
        Me.btn_save.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Appearance.Options.UseFont = True
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(128, 3)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(89, 37)
        Me.btn_save.TabIndex = 185
        Me.btn_save.Text = "ตกลง"
        Me.btn_save.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel4.Controls.Add(Me.rdbInSale)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.rdbFrgOnly)
        Me.Panel4.Controls.Add(Me.rdbInOnly)
        Me.Panel4.Controls.Add(Me.RbCusPs)
        Me.Panel4.Controls.Add(Me.Rball)
        Me.Panel4.Controls.Add(Me.rdbFrgSale)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1134, 90)
        Me.Panel4.TabIndex = 724
        '
        'frmCustomerSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1134, 522)
        Me.Controls.Add(Me.GC_Customer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomerSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกข้อมูลลูกค้า"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GC_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptChkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents RbCusPs As System.Windows.Forms.RadioButton
    Friend WithEvents Rball As System.Windows.Forms.RadioButton
    Friend WithEvents lblSale As System.Windows.Forms.Label
    Friend WithEvents lblPsSale As System.Windows.Forms.Label
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdbFrgOnly As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFrgSale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbInOnly As System.Windows.Forms.RadioButton
    Friend WithEvents rdbInSale As System.Windows.Forms.RadioButton
    Friend WithEvents ChkPv As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCus As System.Windows.Forms.CheckBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents ChkTel As System.Windows.Forms.CheckBox
    Friend WithEvents CmbPv As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GC_Customer As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Customer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColSelectChk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptChkEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColidCus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmpher As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProvince As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidPsAccpet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidTspS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCusInComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidPayTsp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidSupTsp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSupName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddressS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GvProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidFm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidPartner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidRefAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPsRecName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstRight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colflag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnShowdata As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class
