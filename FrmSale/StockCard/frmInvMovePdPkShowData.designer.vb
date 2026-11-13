<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvMovePdPkShowData
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvMovePdPkShowData))
        Me.dgvLvl1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.showDataList = New DevExpress.XtraGrid.GridControl()
        Me.dgvMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSFindAll = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbOldInv = New System.Windows.Forms.ComboBox()
        Me.chkPdName = New System.Windows.Forms.CheckBox()
        Me.txtPdName = New System.Windows.Forms.TextBox()
        Me.chkLotNum = New System.Windows.Forms.CheckBox()
        Me.txtLotNum = New System.Windows.Forms.TextBox()
        Me.chkOldInv = New System.Windows.Forms.CheckBox()
        Me.chkNewInv = New System.Windows.Forms.CheckBox()
        Me.cbNewInv = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkActName = New System.Windows.Forms.CheckBox()
        Me.chkCmdName = New System.Windows.Forms.CheckBox()
        Me.chkTsName = New System.Windows.Forms.CheckBox()
        Me.gbDate = New System.Windows.Forms.GroupBox()
        Me.rdbMonth = New System.Windows.Forms.RadioButton()
        Me.rdbYear = New System.Windows.Forms.RadioButton()
        Me.rdbDate = New System.Windows.Forms.RadioButton()
        Me.yearDate = New System.Windows.Forms.DateTimePicker()
        Me.monthDate = New System.Windows.Forms.DateTimePicker()
        Me.toDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fromDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPsCmd = New System.Windows.Forms.TextBox()
        Me.btnPsCmd = New System.Windows.Forms.Button()
        Me.txtPsAct = New System.Windows.Forms.TextBox()
        Me.txtPsTs = New System.Windows.Forms.TextBox()
        Me.btnPsTs = New System.Windows.Forms.Button()
        Me.btnPsAct = New System.Windows.Forms.Button()
        CType(Me.dgvLvl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showDataList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLvl1
        '
        Me.dgvLvl1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.dgvLvl1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dgvLvl1.Appearance.Row.Options.UseTextOptions = True
        Me.dgvLvl1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dgvLvl1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15})
        Me.dgvLvl1.GridControl = Me.showDataList
        Me.dgvLvl1.Name = "dgvLvl1"
        Me.dgvLvl1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "เลขที่ Lot"
        Me.GridColumn8.FieldName = "LotNum"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.FixedWidth = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        Me.GridColumn8.Width = 89
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "ฃื่อสินค้า"
        Me.GridColumn9.FieldName = "PdPkName"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 273
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "คลังเดิม"
        Me.GridColumn10.FieldName = "oldWhName"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        Me.GridColumn10.Width = 148
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "คลังที่ย้ายเข้า"
        Me.GridColumn11.FieldName = "newWhName"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        Me.GridColumn11.Width = 134
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "จำนวน"
        Me.GridColumn12.FieldName = "Amount"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.FixedWidth = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 4
        Me.GridColumn12.Width = 51
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "หน่วย"
        Me.GridColumn13.FieldName = "PkUnitName"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.FixedWidth = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 5
        Me.GridColumn13.Width = 59
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "หมายเหตุ"
        Me.GridColumn14.FieldName = "note"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 6
        Me.GridColumn14.Width = 129
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "GridColumn15"
        Me.GridColumn15.FieldName = "idUpdate"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'showDataList
        '
        Me.showDataList.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.dgvLvl1
        GridLevelNode1.RelationName = "Level1"
        Me.showDataList.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.showDataList.Location = New System.Drawing.Point(0, 160)
        Me.showDataList.MainView = Me.dgvMain
        Me.showDataList.Name = "showDataList"
        Me.showDataList.Size = New System.Drawing.Size(1077, 363)
        Me.showDataList.TabIndex = 5
        Me.showDataList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvMain, Me.dgvLvl1})
        '
        'dgvMain
        '
        Me.dgvMain.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.dgvMain.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dgvMain.Appearance.Row.Options.UseTextOptions = True
        Me.dgvMain.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dgvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.dgvMain.GridControl = Me.showDataList
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "เวลาที่ทำรายการ"
        Me.GridColumn1.FieldName = "DateTs"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 85
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "เลขที่เอกสาร"
        Me.GridColumn2.FieldName = "DocCode"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 89
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ผู้ทำรายการ"
        Me.GridColumn3.FieldName = "tsName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 164
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "ผู้สั่งงาน"
        Me.GridColumn4.FieldName = "cmdName"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 150
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "ผู้ปฏิบัติงาน"
        Me.GridColumn5.FieldName = "actName"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 153
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "หมายเหตุ"
        Me.GridColumn6.FieldName = "note"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 242
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "GridColumn7"
        Me.GridColumn7.FieldName = "idUpdate"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.Controls.Add(Me.btnSFindAll)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 124)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1077, 36)
        Me.Panel3.TabIndex = 4
        Me.Panel3.TabStop = True
        '
        'btnSFindAll
        '
        Me.btnSFindAll.BackColor = System.Drawing.Color.DimGray
        Me.btnSFindAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSFindAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSFindAll.ForeColor = System.Drawing.Color.White
        Me.btnSFindAll.Image = CType(resources.GetObject("btnSFindAll.Image"), System.Drawing.Image)
        Me.btnSFindAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSFindAll.Location = New System.Drawing.Point(3, 0)
        Me.btnSFindAll.Name = "btnSFindAll"
        Me.btnSFindAll.Size = New System.Drawing.Size(115, 36)
        Me.btnSFindAll.TabIndex = 581
        Me.btnSFindAll.Tag = ""
        Me.btnSFindAll.Text = "       แสดงข้อมูล"
        Me.btnSFindAll.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1077, 124)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkDate)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.gbDate)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1053, 114)
        Me.GroupBox2.TabIndex = 607
        Me.GroupBox2.TabStop = False
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Location = New System.Drawing.Point(2, 7)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(95, 17)
        Me.chkDate.TabIndex = 21
        Me.chkDate.Text = "วันที่ทำรายการ"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbOldInv)
        Me.GroupBox4.Controls.Add(Me.chkPdName)
        Me.GroupBox4.Controls.Add(Me.txtPdName)
        Me.GroupBox4.Controls.Add(Me.chkLotNum)
        Me.GroupBox4.Controls.Add(Me.txtLotNum)
        Me.GroupBox4.Controls.Add(Me.chkOldInv)
        Me.GroupBox4.Controls.Add(Me.chkNewInv)
        Me.GroupBox4.Controls.Add(Me.cbNewInv)
        Me.GroupBox4.Location = New System.Drawing.Point(631, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(416, 103)
        Me.GroupBox4.TabIndex = 667
        Me.GroupBox4.TabStop = False
        '
        'cbOldInv
        '
        Me.cbOldInv.Enabled = False
        Me.cbOldInv.FormattingEnabled = True
        Me.cbOldInv.Location = New System.Drawing.Point(87, 44)
        Me.cbOldInv.Name = "cbOldInv"
        Me.cbOldInv.Size = New System.Drawing.Size(108, 21)
        Me.cbOldInv.TabIndex = 23
        '
        'chkPdName
        '
        Me.chkPdName.AutoSize = True
        Me.chkPdName.Location = New System.Drawing.Point(10, 70)
        Me.chkPdName.Name = "chkPdName"
        Me.chkPdName.Size = New System.Drawing.Size(65, 17)
        Me.chkPdName.TabIndex = 9
        Me.chkPdName.Text = "ชื่อสินค้า"
        Me.chkPdName.UseVisualStyleBackColor = True
        '
        'txtPdName
        '
        Me.txtPdName.Enabled = False
        Me.txtPdName.Location = New System.Drawing.Point(87, 71)
        Me.txtPdName.Name = "txtPdName"
        Me.txtPdName.Size = New System.Drawing.Size(323, 20)
        Me.txtPdName.TabIndex = 25
        '
        'chkLotNum
        '
        Me.chkLotNum.AutoSize = True
        Me.chkLotNum.Location = New System.Drawing.Point(10, 20)
        Me.chkLotNum.Name = "chkLotNum"
        Me.chkLotNum.Size = New System.Drawing.Size(68, 17)
        Me.chkLotNum.TabIndex = 10
        Me.chkLotNum.Text = "เลขที่ Lot"
        Me.chkLotNum.UseVisualStyleBackColor = True
        '
        'txtLotNum
        '
        Me.txtLotNum.Enabled = False
        Me.txtLotNum.Location = New System.Drawing.Point(87, 18)
        Me.txtLotNum.Name = "txtLotNum"
        Me.txtLotNum.Size = New System.Drawing.Size(108, 20)
        Me.txtLotNum.TabIndex = 24
        '
        'chkOldInv
        '
        Me.chkOldInv.AutoSize = True
        Me.chkOldInv.Location = New System.Drawing.Point(10, 45)
        Me.chkOldInv.Name = "chkOldInv"
        Me.chkOldInv.Size = New System.Drawing.Size(63, 17)
        Me.chkOldInv.TabIndex = 11
        Me.chkOldInv.Text = "คลังเดิม"
        Me.chkOldInv.UseVisualStyleBackColor = True
        '
        'chkNewInv
        '
        Me.chkNewInv.AutoSize = True
        Me.chkNewInv.Location = New System.Drawing.Point(210, 46)
        Me.chkNewInv.Name = "chkNewInv"
        Me.chkNewInv.Size = New System.Drawing.Size(86, 17)
        Me.chkNewInv.TabIndex = 12
        Me.chkNewInv.Text = "คลังที่ย้ายเข้า"
        Me.chkNewInv.UseVisualStyleBackColor = True
        '
        'cbNewInv
        '
        Me.cbNewInv.Enabled = False
        Me.cbNewInv.FormattingEnabled = True
        Me.cbNewInv.Location = New System.Drawing.Point(302, 44)
        Me.cbNewInv.Name = "cbNewInv"
        Me.cbNewInv.Size = New System.Drawing.Size(108, 21)
        Me.cbNewInv.TabIndex = 22
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnPsAct)
        Me.GroupBox3.Controls.Add(Me.btnPsTs)
        Me.GroupBox3.Controls.Add(Me.btnPsCmd)
        Me.GroupBox3.Controls.Add(Me.txtPsTs)
        Me.GroupBox3.Controls.Add(Me.txtPsAct)
        Me.GroupBox3.Controls.Add(Me.txtPsCmd)
        Me.GroupBox3.Controls.Add(Me.chkActName)
        Me.GroupBox3.Controls.Add(Me.chkCmdName)
        Me.GroupBox3.Controls.Add(Me.chkTsName)
        Me.GroupBox3.Location = New System.Drawing.Point(387, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(231, 103)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'chkActName
        '
        Me.chkActName.AutoSize = True
        Me.chkActName.Location = New System.Drawing.Point(11, 45)
        Me.chkActName.Name = "chkActName"
        Me.chkActName.Size = New System.Drawing.Size(79, 17)
        Me.chkActName.TabIndex = 7
        Me.chkActName.Text = "ผู้ปฏิบัติงาน"
        Me.chkActName.UseVisualStyleBackColor = True
        '
        'chkCmdName
        '
        Me.chkCmdName.AutoSize = True
        Me.chkCmdName.Location = New System.Drawing.Point(11, 19)
        Me.chkCmdName.Name = "chkCmdName"
        Me.chkCmdName.Size = New System.Drawing.Size(62, 17)
        Me.chkCmdName.TabIndex = 6
        Me.chkCmdName.Text = "ผู้สั่งงาน"
        Me.chkCmdName.UseVisualStyleBackColor = True
        '
        'chkTsName
        '
        Me.chkTsName.AutoSize = True
        Me.chkTsName.Location = New System.Drawing.Point(11, 71)
        Me.chkTsName.Name = "chkTsName"
        Me.chkTsName.Size = New System.Drawing.Size(81, 17)
        Me.chkTsName.TabIndex = 8
        Me.chkTsName.Text = "ผู้ทำรายการ"
        Me.chkTsName.UseVisualStyleBackColor = True
        '
        'gbDate
        '
        Me.gbDate.Controls.Add(Me.rdbMonth)
        Me.gbDate.Controls.Add(Me.rdbYear)
        Me.gbDate.Controls.Add(Me.rdbDate)
        Me.gbDate.Controls.Add(Me.yearDate)
        Me.gbDate.Controls.Add(Me.monthDate)
        Me.gbDate.Controls.Add(Me.toDate)
        Me.gbDate.Controls.Add(Me.Label4)
        Me.gbDate.Controls.Add(Me.fromDate)
        Me.gbDate.Enabled = False
        Me.gbDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.gbDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbDate.Location = New System.Drawing.Point(6, 8)
        Me.gbDate.Name = "gbDate"
        Me.gbDate.Size = New System.Drawing.Size(369, 102)
        Me.gbDate.TabIndex = 666
        Me.gbDate.TabStop = False
        '
        'rdbMonth
        '
        Me.rdbMonth.AutoSize = True
        Me.rdbMonth.Location = New System.Drawing.Point(6, 52)
        Me.rdbMonth.Name = "rdbMonth"
        Me.rdbMonth.Size = New System.Drawing.Size(55, 17)
        Me.rdbMonth.TabIndex = 625
        Me.rdbMonth.Text = "เดือน"
        Me.rdbMonth.UseVisualStyleBackColor = True
        '
        'rdbYear
        '
        Me.rdbYear.AutoSize = True
        Me.rdbYear.Location = New System.Drawing.Point(6, 79)
        Me.rdbYear.Name = "rdbYear"
        Me.rdbYear.Size = New System.Drawing.Size(33, 17)
        Me.rdbYear.TabIndex = 624
        Me.rdbYear.Text = "ปี"
        Me.rdbYear.UseVisualStyleBackColor = True
        '
        'rdbDate
        '
        Me.rdbDate.AutoSize = True
        Me.rdbDate.Checked = True
        Me.rdbDate.Location = New System.Drawing.Point(6, 24)
        Me.rdbDate.Name = "rdbDate"
        Me.rdbDate.Size = New System.Drawing.Size(49, 17)
        Me.rdbDate.TabIndex = 623
        Me.rdbDate.TabStop = True
        Me.rdbDate.Text = "วันที่"
        Me.rdbDate.UseVisualStyleBackColor = True
        '
        'yearDate
        '
        Me.yearDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.yearDate.CausesValidation = False
        Me.yearDate.CustomFormat = "yyyy"
        Me.yearDate.Enabled = False
        Me.yearDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.yearDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.yearDate.Location = New System.Drawing.Point(70, 79)
        Me.yearDate.Name = "yearDate"
        Me.yearDate.ShowUpDown = True
        Me.yearDate.Size = New System.Drawing.Size(65, 20)
        Me.yearDate.TabIndex = 622
        Me.yearDate.Value = New Date(2018, 2, 14, 0, 0, 0, 0)
        '
        'monthDate
        '
        Me.monthDate.Checked = False
        Me.monthDate.CustomFormat = "MMMM/ yyyy"
        Me.monthDate.Enabled = False
        Me.monthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.monthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.monthDate.Location = New System.Drawing.Point(70, 48)
        Me.monthDate.Name = "monthDate"
        Me.monthDate.Size = New System.Drawing.Size(129, 20)
        Me.monthDate.TabIndex = 610
        Me.monthDate.Value = New Date(2018, 2, 14, 0, 0, 0, 0)
        '
        'toDate
        '
        Me.toDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.toDate.Location = New System.Drawing.Point(226, 20)
        Me.toDate.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.toDate.Name = "toDate"
        Me.toDate.Size = New System.Drawing.Size(129, 20)
        Me.toDate.TabIndex = 607
        Me.toDate.Value = New Date(2018, 2, 14, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(201, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 605
        Me.Label4.Text = "ถึง"
        '
        'fromDate
        '
        Me.fromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.fromDate.Location = New System.Drawing.Point(70, 20)
        Me.fromDate.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.fromDate.Name = "fromDate"
        Me.fromDate.Size = New System.Drawing.Size(129, 20)
        Me.fromDate.TabIndex = 601
        Me.fromDate.Value = New Date(2018, 2, 14, 0, 0, 0, 0)
        '
        'txtPsCmd
        '
        Me.txtPsCmd.Enabled = False
        Me.txtPsCmd.Location = New System.Drawing.Point(94, 17)
        Me.txtPsCmd.Name = "txtPsCmd"
        Me.txtPsCmd.Size = New System.Drawing.Size(100, 20)
        Me.txtPsCmd.TabIndex = 6
        '
        'btnPsCmd
        '
        Me.btnPsCmd.Enabled = False
        Me.btnPsCmd.Image = Global.SAM.My.Resources.Resources.Find16
        Me.btnPsCmd.Location = New System.Drawing.Point(201, 15)
        Me.btnPsCmd.Name = "btnPsCmd"
        Me.btnPsCmd.Size = New System.Drawing.Size(24, 24)
        Me.btnPsCmd.TabIndex = 6
        Me.btnPsCmd.UseVisualStyleBackColor = True
        '
        'txtPsAct
        '
        Me.txtPsAct.Enabled = False
        Me.txtPsAct.Location = New System.Drawing.Point(94, 42)
        Me.txtPsAct.Name = "txtPsAct"
        Me.txtPsAct.Size = New System.Drawing.Size(100, 20)
        Me.txtPsAct.TabIndex = 9
        '
        'txtPsTs
        '
        Me.txtPsTs.Enabled = False
        Me.txtPsTs.Location = New System.Drawing.Point(94, 67)
        Me.txtPsTs.Name = "txtPsTs"
        Me.txtPsTs.Size = New System.Drawing.Size(100, 20)
        Me.txtPsTs.TabIndex = 10
        '
        'btnPsTs
        '
        Me.btnPsTs.Enabled = False
        Me.btnPsTs.Image = Global.SAM.My.Resources.Resources.Find16
        Me.btnPsTs.Location = New System.Drawing.Point(201, 65)
        Me.btnPsTs.Name = "btnPsTs"
        Me.btnPsTs.Size = New System.Drawing.Size(24, 24)
        Me.btnPsTs.TabIndex = 11
        Me.btnPsTs.UseVisualStyleBackColor = True
        '
        'btnPsAct
        '
        Me.btnPsAct.Enabled = False
        Me.btnPsAct.Image = Global.SAM.My.Resources.Resources.Find16
        Me.btnPsAct.Location = New System.Drawing.Point(201, 40)
        Me.btnPsAct.Name = "btnPsAct"
        Me.btnPsAct.Size = New System.Drawing.Size(24, 24)
        Me.btnPsAct.TabIndex = 12
        Me.btnPsAct.UseVisualStyleBackColor = True
        '
        'frmInvMovePdPkShowData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1077, 523)
        Me.Controls.Add(Me.showDataList)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmInvMovePdPkShowData"
        Me.Text = "แสดงข้อมูลการย้ายคลัง"
        CType(Me.dgvLvl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showDataList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbDate.ResumeLayout(False)
        Me.gbDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSFindAll As System.Windows.Forms.Button
    Friend WithEvents showDataList As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvLvl1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkNewInv As System.Windows.Forms.CheckBox
    Friend WithEvents chkOldInv As System.Windows.Forms.CheckBox
    Friend WithEvents chkLotNum As System.Windows.Forms.CheckBox
    Friend WithEvents chkPdName As System.Windows.Forms.CheckBox
    Friend WithEvents chkTsName As System.Windows.Forms.CheckBox
    Friend WithEvents chkActName As System.Windows.Forms.CheckBox
    Friend WithEvents chkCmdName As System.Windows.Forms.CheckBox
    Friend WithEvents cbOldInv As System.Windows.Forms.ComboBox
    Friend WithEvents cbNewInv As System.Windows.Forms.ComboBox
    Friend WithEvents txtLotNum As System.Windows.Forms.TextBox
    Friend WithEvents txtPdName As System.Windows.Forms.TextBox
    Friend WithEvents gbDate As System.Windows.Forms.GroupBox
    Friend WithEvents yearDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents monthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents toDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents rdbMonth As System.Windows.Forms.RadioButton
    Friend WithEvents rdbYear As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDate As System.Windows.Forms.RadioButton
    Friend WithEvents txtPsCmd As System.Windows.Forms.TextBox
    Friend WithEvents btnPsCmd As System.Windows.Forms.Button
    Friend WithEvents btnPsAct As System.Windows.Forms.Button
    Friend WithEvents btnPsTs As System.Windows.Forms.Button
    Friend WithEvents txtPsTs As System.Windows.Forms.TextBox
    Friend WithEvents txtPsAct As System.Windows.Forms.TextBox
End Class
