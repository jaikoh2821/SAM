<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlBnData
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlBnData))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotalNet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSFindAll = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkComp = New System.Windows.Forms.CheckBox()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.rdbYear = New System.Windows.Forms.RadioButton()
        Me.ChkCusName = New System.Windows.Forms.CheckBox()
        Me.rdbDate = New System.Windows.Forms.RadioButton()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.rdbMonth = New System.Windows.Forms.RadioButton()
        Me.dtpDateS = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDateE = New System.Windows.Forms.DateTimePicker()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.gc2 = New DevExpress.XtraGrid.GridControl()
        Me.gv2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidBN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptCheckSelect = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ColEdit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptBtnEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptBtnDoc = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColShow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptBtnShow = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptBtnCancel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColCompCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateDocD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCusName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidPsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCancelNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCompName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptCheckSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptBtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptBtnDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptBtnShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptBtnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.DimGray
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Image = Global.SAM.My.Resources.Resources.trainingCheckStateIcon
        Me.btnOK.Location = New System.Drawing.Point(295, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(92, 30)
        Me.btnOK.TabIndex = 586
        Me.btnOK.Tag = "Save"
        Me.btnOK.Text = " ตกลง"
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = False
        Me.btnOK.Visible = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.DimGray
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = Global.SAM.My.Resources.Resources.document_add
        Me.btnNew.Location = New System.Drawing.Point(115, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(180, 30)
        Me.btnNew.TabIndex = 585
        Me.btnNew.Tag = ""
        Me.btnNew.Text = " ทำรายการออกใบวางบิล"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = False
        Me.btnNew.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.txtTotalNet)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(825, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(259, 30)
        Me.Panel3.TabIndex = 581
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(92, 1)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(158, 27)
        Me.txtTotalNet.TabIndex = 579
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "รวมเป็นเงิน"
        '
        'btnSFindAll
        '
        Me.btnSFindAll.BackColor = System.Drawing.Color.DimGray
        Me.btnSFindAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSFindAll.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSFindAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSFindAll.ForeColor = System.Drawing.Color.White
        Me.btnSFindAll.Image = Global.SAM.My.Resources.Resources.refresh_24x24
        Me.btnSFindAll.Location = New System.Drawing.Point(0, 0)
        Me.btnSFindAll.Name = "btnSFindAll"
        Me.btnSFindAll.Size = New System.Drawing.Size(115, 30)
        Me.btnSFindAll.TabIndex = 580
        Me.btnSFindAll.Tag = ""
        Me.btnSFindAll.Text = " Refresh"
        Me.btnSFindAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSFindAll.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtCusName)
        Me.GroupBox1.Controls.Add(Me.ChkComp)
        Me.GroupBox1.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox1.Controls.Add(Me.dtpYear)
        Me.GroupBox1.Controls.Add(Me.rdbYear)
        Me.GroupBox1.Controls.Add(Me.ChkCusName)
        Me.GroupBox1.Controls.Add(Me.rdbDate)
        Me.GroupBox1.Controls.Add(Me.dtpMonth)
        Me.GroupBox1.Controls.Add(Me.rdbMonth)
        Me.GroupBox1.Controls.Add(Me.dtpDateS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpDateE)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(808, 79)
        Me.GroupBox1.TabIndex = 626
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เงื่อนไขการแสดงข้อมูล"
        '
        'ChkComp
        '
        Me.ChkComp.AutoSize = True
        Me.ChkComp.Location = New System.Drawing.Point(491, 18)
        Me.ChkComp.Name = "ChkComp"
        Me.ChkComp.Size = New System.Drawing.Size(54, 17)
        Me.ChkComp.TabIndex = 784
        Me.ChkComp.Text = "บริษัท"
        Me.ChkComp.UseVisualStyleBackColor = True
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Enabled = False
        Me.cmbGroupComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(549, 15)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(247, 23)
        Me.cmbGroupComp.TabIndex = 783
        '
        'dtpYear
        '
        Me.dtpYear.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.CausesValidation = False
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Enabled = False
        Me.dtpYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(311, 48)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(65, 20)
        Me.dtpYear.TabIndex = 626
        Me.dtpYear.Value = New Date(2020, 2, 26, 13, 36, 0, 0)
        '
        'rdbYear
        '
        Me.rdbYear.AutoSize = True
        Me.rdbYear.Location = New System.Drawing.Point(256, 50)
        Me.rdbYear.Name = "rdbYear"
        Me.rdbYear.Size = New System.Drawing.Size(32, 17)
        Me.rdbYear.TabIndex = 625
        Me.rdbYear.Text = "ปี"
        Me.rdbYear.UseVisualStyleBackColor = True
        '
        'ChkCusName
        '
        Me.ChkCusName.AutoSize = True
        Me.ChkCusName.Location = New System.Drawing.Point(491, 46)
        Me.ChkCusName.Name = "ChkCusName"
        Me.ChkCusName.Size = New System.Drawing.Size(51, 17)
        Me.ChkCusName.TabIndex = 606
        Me.ChkCusName.Text = "ลูกค้า"
        Me.ChkCusName.UseVisualStyleBackColor = True
        '
        'rdbDate
        '
        Me.rdbDate.AutoSize = True
        Me.rdbDate.Checked = True
        Me.rdbDate.Location = New System.Drawing.Point(30, 23)
        Me.rdbDate.Name = "rdbDate"
        Me.rdbDate.Size = New System.Drawing.Size(64, 17)
        Me.rdbDate.TabIndex = 608
        Me.rdbDate.TabStop = True
        Me.rdbDate.Text = "ช่วงวันที่"
        Me.rdbDate.UseVisualStyleBackColor = True
        '
        'dtpMonth
        '
        Me.dtpMonth.Checked = False
        Me.dtpMonth.CustomFormat = "MMMM /yyyy"
        Me.dtpMonth.Enabled = False
        Me.dtpMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(311, 20)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(135, 20)
        Me.dtpMonth.TabIndex = 621
        '
        'rdbMonth
        '
        Me.rdbMonth.AutoSize = True
        Me.rdbMonth.Location = New System.Drawing.Point(256, 21)
        Me.rdbMonth.Name = "rdbMonth"
        Me.rdbMonth.Size = New System.Drawing.Size(51, 17)
        Me.rdbMonth.TabIndex = 609
        Me.rdbMonth.Text = "เดือน"
        Me.rdbMonth.UseVisualStyleBackColor = True
        '
        'dtpDateS
        '
        Me.dtpDateS.CustomFormat = "ddMMMMyyyy"
        Me.dtpDateS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateS.Location = New System.Drawing.Point(97, 22)
        Me.dtpDateS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpDateS.Name = "dtpDateS"
        Me.dtpDateS.Size = New System.Drawing.Size(135, 20)
        Me.dtpDateS.TabIndex = 601
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 605
        Me.Label4.Text = "ถึง"
        '
        'dtpDateE
        '
        Me.dtpDateE.CustomFormat = "ddMMMMyyyy"
        Me.dtpDateE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateE.Location = New System.Drawing.Point(97, 48)
        Me.dtpDateE.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpDateE.Name = "dtpDateE"
        Me.dtpDateE.Size = New System.Drawing.Size(135, 20)
        Me.dtpDateE.TabIndex = 602
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1084, 101)
        Me.PanelControl1.TabIndex = 726
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.Panel3)
        Me.PanelControl3.Controls.Add(Me.btnOK)
        Me.PanelControl3.Controls.Add(Me.btnNew)
        Me.PanelControl3.Controls.Add(Me.btnSFindAll)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 101)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1084, 30)
        Me.PanelControl3.TabIndex = 727
        '
        'gc2
        '
        Me.gc2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc2.Location = New System.Drawing.Point(0, 131)
        Me.gc2.MainView = Me.gv2
        Me.gc2.Name = "gc2"
        Me.gc2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnSelect, Me.rptCheckSelect, Me.rptBtnDoc, Me.rptBtnShow, Me.rptBtnCancel, Me.rptBtnEdit})
        Me.gc2.Size = New System.Drawing.Size(1084, 411)
        Me.gc2.TabIndex = 728
        Me.gc2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv2})
        '
        'gv2
        '
        Me.gv2.Appearance.FocusedCell.BackColor = System.Drawing.Color.PeachPuff
        Me.gv2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gv2.Appearance.FocusedRow.BackColor = System.Drawing.Color.SandyBrown
        Me.gv2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gv2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gv2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gv2.Appearance.Row.Options.UseTextOptions = True
        Me.gv2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gv2.ColumnPanelRowHeight = 36
        Me.gv2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidBN, Me.ColNum, Me.ColSelect, Me.ColEdit, Me.ColDoc, Me.ColShow, Me.ColCancel, Me.ColCompCode, Me.ColDocCode, Me.ColDateDocD, Me.ColCusName, Me.ColTotal, Me.ColNote, Me.ColPsName, Me.ColidPsCancel, Me.ColPsCancel, Me.ColCancelNote, Me.ColidComp, Me.ColCompName})
        Me.gv2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Value1 = 0
        Me.gv2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gv2.GridControl = Me.gc2
        Me.gv2.Name = "gv2"
        Me.gv2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gv2.OptionsView.ShowGroupPanel = False
        Me.gv2.OptionsView.ShowIndicator = False
        '
        'ColidBN
        '
        Me.ColidBN.Caption = "idBN"
        Me.ColidBN.FieldName = "idBN"
        Me.ColidBN.Name = "ColidBN"
        Me.ColidBN.OptionsColumn.AllowEdit = False
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseForeColor = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.MaxWidth = 50
        Me.ColNum.MinWidth = 50
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 50
        '
        'ColSelect
        '
        Me.ColSelect.Caption = "เลือก"
        Me.ColSelect.ColumnEdit = Me.rptCheckSelect
        Me.ColSelect.FieldName = "ChkKey"
        Me.ColSelect.MaxWidth = 40
        Me.ColSelect.MinWidth = 40
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.Visible = True
        Me.ColSelect.VisibleIndex = 1
        Me.ColSelect.Width = 40
        '
        'rptCheckSelect
        '
        Me.rptCheckSelect.AutoHeight = False
        Me.rptCheckSelect.Name = "rptCheckSelect"
        '
        'ColEdit
        '
        Me.ColEdit.Caption = "แก้ไข"
        Me.ColEdit.ColumnEdit = Me.rptBtnEdit
        Me.ColEdit.MaxWidth = 40
        Me.ColEdit.MinWidth = 40
        Me.ColEdit.Name = "ColEdit"
        Me.ColEdit.Width = 40
        '
        'rptBtnEdit
        '
        Me.rptBtnEdit.AutoHeight = False
        Me.rptBtnEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.Computer_Edit, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptBtnEdit.Name = "rptBtnEdit"
        Me.rptBtnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColDoc
        '
        Me.ColDoc.Caption = "เอกสาร"
        Me.ColDoc.ColumnEdit = Me.rptBtnDoc
        Me.ColDoc.MaxWidth = 45
        Me.ColDoc.MinWidth = 45
        Me.ColDoc.Name = "ColDoc"
        Me.ColDoc.Visible = True
        Me.ColDoc.VisibleIndex = 2
        Me.ColDoc.Width = 45
        '
        'rptBtnDoc
        '
        Me.rptBtnDoc.AutoHeight = False
        Me.rptBtnDoc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.icon_billingsss_png_16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.rptBtnDoc.Name = "rptBtnDoc"
        Me.rptBtnDoc.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColShow
        '
        Me.ColShow.AppearanceCell.Options.UseTextOptions = True
        Me.ColShow.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColShow.AppearanceHeader.Options.UseTextOptions = True
        Me.ColShow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColShow.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColShow.Caption = "รายละเอียด"
        Me.ColShow.ColumnEdit = Me.rptBtnShow
        Me.ColShow.MaxWidth = 45
        Me.ColShow.MinWidth = 45
        Me.ColShow.Name = "ColShow"
        Me.ColShow.Visible = True
        Me.ColShow.VisibleIndex = 3
        Me.ColShow.Width = 45
        '
        'rptBtnShow
        '
        Me.rptBtnShow.AutoHeight = False
        Me.rptBtnShow.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.Open_16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.rptBtnShow.Name = "rptBtnShow"
        Me.rptBtnShow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColCancel
        '
        Me.ColCancel.Caption = "ยกเลิก"
        Me.ColCancel.ColumnEdit = Me.rptBtnCancel
        Me.ColCancel.MaxWidth = 40
        Me.ColCancel.MinWidth = 40
        Me.ColCancel.Name = "ColCancel"
        Me.ColCancel.Visible = True
        Me.ColCancel.VisibleIndex = 4
        Me.ColCancel.Width = 40
        '
        'rptBtnCancel
        '
        Me.rptBtnCancel.AutoHeight = False
        Me.rptBtnCancel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.cross_circle_frame, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.rptBtnCancel.Name = "rptBtnCancel"
        Me.rptBtnCancel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColCompCode
        '
        Me.ColCompCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCompCode.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColCompCode.AppearanceCell.Options.UseBackColor = True
        Me.ColCompCode.AppearanceCell.Options.UseForeColor = True
        Me.ColCompCode.Caption = "บริษัท"
        Me.ColCompCode.FieldName = "CompCode"
        Me.ColCompCode.MaxWidth = 60
        Me.ColCompCode.MinWidth = 60
        Me.ColCompCode.Name = "ColCompCode"
        Me.ColCompCode.OptionsColumn.AllowEdit = False
        Me.ColCompCode.OptionsColumn.ReadOnly = True
        Me.ColCompCode.Visible = True
        Me.ColCompCode.VisibleIndex = 5
        Me.ColCompCode.Width = 60
        '
        'ColDocCode
        '
        Me.ColDocCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocCode.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColDocCode.AppearanceCell.Options.UseBackColor = True
        Me.ColDocCode.AppearanceCell.Options.UseForeColor = True
        Me.ColDocCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocCode.Caption = "เลขที่รายการ"
        Me.ColDocCode.FieldName = "DocCode"
        Me.ColDocCode.MaxWidth = 90
        Me.ColDocCode.MinWidth = 90
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.OptionsColumn.AllowEdit = False
        Me.ColDocCode.OptionsColumn.ReadOnly = True
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 6
        Me.ColDocCode.Width = 90
        '
        'ColDateDocD
        '
        Me.ColDateDocD.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateDocD.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColDateDocD.AppearanceCell.Options.UseBackColor = True
        Me.ColDateDocD.AppearanceCell.Options.UseForeColor = True
        Me.ColDateDocD.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateDocD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateDocD.Caption = "วันที่เอกสาร"
        Me.ColDateDocD.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateDocD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateDocD.FieldName = "DateDocD"
        Me.ColDateDocD.MaxWidth = 80
        Me.ColDateDocD.MinWidth = 80
        Me.ColDateDocD.Name = "ColDateDocD"
        Me.ColDateDocD.OptionsColumn.AllowEdit = False
        Me.ColDateDocD.OptionsColumn.ReadOnly = True
        Me.ColDateDocD.Visible = True
        Me.ColDateDocD.VisibleIndex = 7
        Me.ColDateDocD.Width = 80
        '
        'ColCusName
        '
        Me.ColCusName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColCusName.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColCusName.AppearanceCell.Options.UseBackColor = True
        Me.ColCusName.AppearanceCell.Options.UseForeColor = True
        Me.ColCusName.AppearanceCell.Options.UseTextOptions = True
        Me.ColCusName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColCusName.Caption = "ลูกค้า"
        Me.ColCusName.FieldName = "CusName_"
        Me.ColCusName.MinWidth = 250
        Me.ColCusName.Name = "ColCusName"
        Me.ColCusName.OptionsColumn.AllowEdit = False
        Me.ColCusName.Visible = True
        Me.ColCusName.VisibleIndex = 8
        Me.ColCusName.Width = 250
        '
        'ColTotal
        '
        Me.ColTotal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTotal.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColTotal.AppearanceCell.Options.UseBackColor = True
        Me.ColTotal.AppearanceCell.Options.UseForeColor = True
        Me.ColTotal.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotal.Caption = "ยอดทั้งหมด"
        Me.ColTotal.DisplayFormat.FormatString = "N2"
        Me.ColTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotal.FieldName = "Total"
        Me.ColTotal.MinWidth = 100
        Me.ColTotal.Name = "ColTotal"
        Me.ColTotal.OptionsColumn.AllowEdit = False
        Me.ColTotal.OptionsColumn.ReadOnly = True
        Me.ColTotal.Visible = True
        Me.ColTotal.VisibleIndex = 9
        Me.ColTotal.Width = 120
        '
        'ColNote
        '
        Me.ColNote.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNote.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColNote.AppearanceCell.Options.UseBackColor = True
        Me.ColNote.AppearanceCell.Options.UseForeColor = True
        Me.ColNote.AppearanceCell.Options.UseTextOptions = True
        Me.ColNote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColNote.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNote.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNote.Caption = "คำอธิบายรายการ"
        Me.ColNote.FieldName = "Note"
        Me.ColNote.MinWidth = 150
        Me.ColNote.Name = "ColNote"
        Me.ColNote.OptionsColumn.AllowEdit = False
        Me.ColNote.Visible = True
        Me.ColNote.VisibleIndex = 10
        Me.ColNote.Width = 150
        '
        'ColPsName
        '
        Me.ColPsName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPsName.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColPsName.AppearanceCell.Options.UseBackColor = True
        Me.ColPsName.AppearanceCell.Options.UseForeColor = True
        Me.ColPsName.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPsName.Caption = "ผู้ทำรายการ"
        Me.ColPsName.FieldName = "PsName"
        Me.ColPsName.MinWidth = 120
        Me.ColPsName.Name = "ColPsName"
        Me.ColPsName.OptionsColumn.AllowEdit = False
        Me.ColPsName.Visible = True
        Me.ColPsName.VisibleIndex = 11
        Me.ColPsName.Width = 172
        '
        'ColidPsCancel
        '
        Me.ColidPsCancel.AppearanceCell.BackColor = System.Drawing.Color.PowderBlue
        Me.ColidPsCancel.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColidPsCancel.AppearanceCell.Options.UseBackColor = True
        Me.ColidPsCancel.AppearanceCell.Options.UseForeColor = True
        Me.ColidPsCancel.AppearanceCell.Options.UseTextOptions = True
        Me.ColidPsCancel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidPsCancel.Caption = "idPsCancel"
        Me.ColidPsCancel.FieldName = "idPsCancel"
        Me.ColidPsCancel.MinWidth = 100
        Me.ColidPsCancel.Name = "ColidPsCancel"
        Me.ColidPsCancel.OptionsColumn.AllowEdit = False
        Me.ColidPsCancel.Width = 100
        '
        'ColPsCancel
        '
        Me.ColPsCancel.AppearanceCell.BackColor = System.Drawing.Color.PowderBlue
        Me.ColPsCancel.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColPsCancel.AppearanceCell.Options.UseBackColor = True
        Me.ColPsCancel.AppearanceCell.Options.UseForeColor = True
        Me.ColPsCancel.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsCancel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPsCancel.Caption = "PsCancel"
        Me.ColPsCancel.FieldName = "PsCancel"
        Me.ColPsCancel.MaxWidth = 80
        Me.ColPsCancel.MinWidth = 80
        Me.ColPsCancel.Name = "ColPsCancel"
        Me.ColPsCancel.OptionsColumn.AllowEdit = False
        Me.ColPsCancel.Width = 80
        '
        'ColCancelNote
        '
        Me.ColCancelNote.Caption = "CancelNote"
        Me.ColCancelNote.FieldName = "CancelNote"
        Me.ColCancelNote.Name = "ColCancelNote"
        '
        'ColidComp
        '
        Me.ColidComp.Caption = "idComp"
        Me.ColidComp.FieldName = "idComp"
        Me.ColidComp.Name = "ColidComp"
        '
        'ColCompName
        '
        Me.ColCompName.Caption = "บริษัท"
        Me.ColCompName.FieldName = "CompName"
        Me.ColCompName.Name = "ColCompName"
        '
        'btnSelect
        '
        Me.btnSelect.AutoHeight = False
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'txtCusName
        '
        Me.txtCusName.Enabled = False
        Me.txtCusName.Location = New System.Drawing.Point(549, 45)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(247, 20)
        Me.txtCusName.TabIndex = 785
        '
        'frmSlBnData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1084, 542)
        Me.Controls.Add(Me.gc2)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSlBnData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลรายการออกใบวางบิล"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.gc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptCheckSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptBtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptBtnDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptBtnShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptBtnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSFindAll As System.Windows.Forms.Button
    Friend WithEvents txtTotalNet As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkCusName As System.Windows.Forms.CheckBox
    Friend WithEvents rdbDate As System.Windows.Forms.RadioButton
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdbMonth As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDateS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDateE As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents rdbYear As System.Windows.Forms.RadioButton
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gc2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidBN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptCheckSelect As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptBtnDoc As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColShow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptBtnShow As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptBtnCancel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateDocD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCusName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidPsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCancelNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
    Friend WithEvents ColEdit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptBtnEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColidComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkComp As System.Windows.Forms.CheckBox
    Friend WithEvents ColCompCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCompName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
End Class
