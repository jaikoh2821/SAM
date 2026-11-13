<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPdMixStockCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPdMixStockCard))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPdPk = New System.Windows.Forms.Button()
        Me.lblLotNum = New System.Windows.Forms.Label()
        Me.lblPdName = New System.Windows.Forms.Label()
        Me.lblPlantName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChkDateStock = New System.Windows.Forms.CheckBox()
        Me.dtpStockE = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpStockS = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.btnShow)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 131)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1108, 32)
        Me.Panel3.TabIndex = 657
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtCount)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(834, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(272, 30)
        Me.Panel5.TabIndex = 600
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(115, 5)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(98, 24)
        Me.txtCount.TabIndex = 595
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 594
        Me.Label5.Text = "จำนวนรายการ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(213, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 596
        Me.Label3.Text = "รายการ"
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.DimGray
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(0, 0)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(115, 30)
        Me.btnShow.TabIndex = 580
        Me.btnShow.Tag = ""
        Me.btnShow.Text = "       แสดงข้อมูล"
        Me.btnShow.UseVisualStyleBackColor = False
        Me.btnShow.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPdPk)
        Me.GroupBox2.Controls.Add(Me.lblLotNum)
        Me.GroupBox2.Controls.Add(Me.lblPdName)
        Me.GroupBox2.Controls.Add(Me.lblPlantName)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ChkDateStock)
        Me.GroupBox2.Controls.Add(Me.dtpStockE)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtpStockS)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(289, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(554, 113)
        Me.GroupBox2.TabIndex = 658
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายละเอียด Lot สินค้าวัตถุดิบ"
        '
        'btnPdPk
        '
        Me.btnPdPk.BackColor = System.Drawing.Color.DimGray
        Me.btnPdPk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPdPk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPdPk.ForeColor = System.Drawing.Color.White
        Me.btnPdPk.Image = CType(resources.GetObject("btnPdPk.Image"), System.Drawing.Image)
        Me.btnPdPk.Location = New System.Drawing.Point(475, 21)
        Me.btnPdPk.Name = "btnPdPk"
        Me.btnPdPk.Size = New System.Drawing.Size(28, 25)
        Me.btnPdPk.TabIndex = 670
        Me.btnPdPk.Tag = "Add"
        Me.btnPdPk.UseVisualStyleBackColor = False
        '
        'lblLotNum
        '
        Me.lblLotNum.BackColor = System.Drawing.Color.Gainsboro
        Me.lblLotNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLotNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblLotNum.Location = New System.Drawing.Point(91, 51)
        Me.lblLotNum.Name = "lblLotNum"
        Me.lblLotNum.Size = New System.Drawing.Size(141, 20)
        Me.lblLotNum.TabIndex = 663
        Me.lblLotNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPdName
        '
        Me.lblPdName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPdName.Location = New System.Drawing.Point(91, 23)
        Me.lblPdName.Name = "lblPdName"
        Me.lblPdName.Size = New System.Drawing.Size(381, 20)
        Me.lblPdName.TabIndex = 662
        Me.lblPdName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlantName
        '
        Me.lblPlantName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPlantName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlantName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPlantName.Location = New System.Drawing.Point(303, 50)
        Me.lblPlantName.Name = "lblPlantName"
        Me.lblPlantName.Size = New System.Drawing.Size(169, 20)
        Me.lblPlantName.TabIndex = 661
        Me.lblPlantName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 660
        Me.Label6.Text = "ชื่อสินค้า"
        '
        'ChkDateStock
        '
        Me.ChkDateStock.AutoSize = True
        Me.ChkDateStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkDateStock.Location = New System.Drawing.Point(90, 85)
        Me.ChkDateStock.Name = "ChkDateStock"
        Me.ChkDateStock.Size = New System.Drawing.Size(95, 17)
        Me.ChkDateStock.TabIndex = 643
        Me.ChkDateStock.Text = "วันที่ทำรายการ"
        Me.ChkDateStock.UseVisualStyleBackColor = True
        '
        'dtpStockE
        '
        Me.dtpStockE.Enabled = False
        Me.dtpStockE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpStockE.Location = New System.Drawing.Point(346, 82)
        Me.dtpStockE.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpStockE.Name = "dtpStockE"
        Me.dtpStockE.Size = New System.Drawing.Size(126, 20)
        Me.dtpStockE.TabIndex = 607
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 659
        Me.Label4.Text = "ประเภทพืช"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(325, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 605
        Me.Label2.Text = "ถึง"
        '
        'dtpStockS
        '
        Me.dtpStockS.Enabled = False
        Me.dtpStockS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpStockS.Location = New System.Drawing.Point(192, 83)
        Me.dtpStockS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpStockS.Name = "dtpStockS"
        Me.dtpStockS.Size = New System.Drawing.Size(131, 20)
        Me.dtpStockS.TabIndex = 601
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 658
        Me.Label1.Text = "Group/Serial"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 163)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnSelect})
        Me.GridControl2.Size = New System.Drawing.Size(1108, 353)
        Me.GridControl2.TabIndex = 670
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.Row.BackColor2 = System.Drawing.Color.DodgerBlue
        Me.GridView2.Appearance.Row.Options.UseTextOptions = True
        Me.GridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn31})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ลำดับ"
        Me.GridColumn1.FieldName = "ColNum"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn1.OptionsColumn.FixedWidth = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 52
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "เลือก"
        Me.GridColumn17.ColumnEdit = Me.btnSelect
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.FixedWidth = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 1
        Me.GridColumn17.Width = 48
        '
        'btnSelect
        '
        Me.btnSelect.AutoHeight = False
        Me.btnSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.CamearSelect, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "เลขที่ Lot"
        Me.GridColumn18.FieldName = "LotNum"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.FixedWidth = True
        Me.GridColumn18.Width = 99
        '
        'GridColumn19
        '
        Me.GridColumn19.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn19.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn19.Caption = "วันที่ทำรายการ"
        Me.GridColumn19.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.GridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn19.FieldName = "DateTs"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn19.OptionsColumn.FixedWidth = True
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 2
        Me.GridColumn19.Width = 98
        '
        'GridColumn20
        '
        Me.GridColumn20.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn20.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn20.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn20.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn20.Caption = "รับเข้า"
        Me.GridColumn20.DisplayFormat.FormatString = "#,##0.00##"
        Me.GridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn20.FieldName = "AmountAdd"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn20.OptionsColumn.FixedWidth = True
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 4
        Me.GridColumn20.Width = 78
        '
        'GridColumn21
        '
        Me.GridColumn21.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn21.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn21.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn21.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn21.Caption = "เบิกออก"
        Me.GridColumn21.DisplayFormat.FormatString = "#,##0.00##"
        Me.GridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn21.FieldName = "AmountCut"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn21.OptionsColumn.FixedWidth = True
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 5
        Me.GridColumn21.Width = 65
        '
        'GridColumn22
        '
        Me.GridColumn22.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn22.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn22.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn22.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn22.Caption = "คงเหลือ"
        Me.GridColumn22.DisplayFormat.FormatString = "#,##0.00##"
        Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn22.FieldName = "Balance"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn22.OptionsColumn.FixedWidth = True
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 6
        Me.GridColumn22.Width = 82
        '
        'GridColumn23
        '
        Me.GridColumn23.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridColumn23.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn23.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn23.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn23.Caption = "รายการ"
        Me.GridColumn23.FieldName = "Note"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 3
        Me.GridColumn23.Width = 298
        '
        'GridColumn24
        '
        Me.GridColumn24.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn24.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn24.Caption = "ผู้ทำรายการ"
        Me.GridColumn24.FieldName = "PsTs"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn24.OptionsColumn.FixedWidth = True
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 7
        Me.GridColumn24.Width = 162
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "ชื่อสินค้าสำเร็จรูป"
        Me.GridColumn25.FieldName = "PdName"
        Me.GridColumn25.Name = "GridColumn25"
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "หน่วย"
        Me.GridColumn26.FieldName = "PdName"
        Me.GridColumn26.Name = "GridColumn26"
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "idTs"
        Me.GridColumn27.FieldName = "idTs"
        Me.GridColumn27.Name = "GridColumn27"
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "idPdPk"
        Me.GridColumn28.FieldName = "idPkPk"
        Me.GridColumn28.Name = "GridColumn28"
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "idPkUnit"
        Me.GridColumn29.FieldName = "idPkUnit"
        Me.GridColumn29.Name = "GridColumn29"
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "idRef"
        Me.GridColumn30.FieldName = "idRef"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Width = 215
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "idPkPkLot"
        Me.GridColumn31.FieldName = "idLot"
        Me.GridColumn31.Name = "GridColumn31"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1108, 131)
        Me.Panel1.TabIndex = 671
        '
        'frmPdMixStockCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1108, 516)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPdMixStockCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Card สินค้าวัตถุดิบ"
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkDateStock As System.Windows.Forms.CheckBox
    Friend WithEvents dtpStockE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpStockS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPlantName As System.Windows.Forms.Label
    Friend WithEvents lblPdName As System.Windows.Forms.Label
    Friend WithEvents lblLotNum As System.Windows.Forms.Label
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPdPk As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
