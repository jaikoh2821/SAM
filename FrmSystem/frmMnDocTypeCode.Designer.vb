<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMnDocTypeCode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMnDocTypeCode))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnType = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.GCDocType = New DevExpress.XtraGrid.GridControl()
        Me.GVDoctype = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDocType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ColNote_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ColstRight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptStRight = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colDel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.rptnvName = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.rptNoteDt = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GVWaitRecDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode_PO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInvName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmountWait = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColWhName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clidWaitRecDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clidWaitRecMt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clidLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clidInvMain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clAmountRec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clAmountWaitBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clidUnitNew = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clidWh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clstWait = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clidSaleOrderDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clidFl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidWhNewMove = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidDt = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GCDocType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDoctype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDocType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptStRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptnvName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptNoteDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVWaitRecDt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(107, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 16)
        Me.Label10.TabIndex = 969
        Me.Label10.Text = "บริษัท"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(155, 12)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(203, 22)
        Me.cmbGroupComp.TabIndex = 968
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.btnType)
        Me.PanelControl3.Controls.Add(Me.cmbGroupComp)
        Me.PanelControl3.Controls.Add(Me.Label10)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(512, 43)
        Me.PanelControl3.TabIndex = 736
        '
        'btnType
        '
        Me.btnType.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnType.Appearance.Options.UseFont = True
        Me.btnType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnType.Image = CType(resources.GetObject("btnType.Image"), System.Drawing.Image)
        Me.btnType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnType.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnType.Location = New System.Drawing.Point(399, 10)
        Me.btnType.Name = "btnType"
        Me.btnType.Size = New System.Drawing.Size(101, 27)
        Me.btnType.TabIndex = 970
        Me.btnType.Text = "เพิ่มประเภท"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.Panel2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 503)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(512, 35)
        Me.PanelControl1.TabIndex = 737
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnOK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 35)
        Me.Panel2.TabIndex = 30
        '
        'btnOK
        '
        Me.btnOK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnOK.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnOK.Location = New System.Drawing.Point(2, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(97, 29)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "บันทึก"
        '
        'GCDocType
        '
        Me.GCDocType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCDocType.Location = New System.Drawing.Point(0, 43)
        Me.GCDocType.MainView = Me.GVDoctype
        Me.GCDocType.Name = "GCDocType"
        Me.GCDocType.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptnvName, Me.rptNoteDt, Me.rptDel, Me.rptDocType, Me.rptStRight, Me.rptNote})
        Me.GCDocType.Size = New System.Drawing.Size(512, 460)
        Me.GCDocType.TabIndex = 738
        Me.GCDocType.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDoctype, Me.GVWaitRecDt})
        '
        'GVDoctype
        '
        Me.GVDoctype.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVDoctype.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVDoctype.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDoctype.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDoctype.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDoctype.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVDoctype.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVDoctype.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDoctype.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDoctype.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDoctype.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDoctype.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVDoctype.Appearance.Empty.Options.UseBackColor = True
        Me.GVDoctype.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDoctype.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDoctype.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDoctype.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVDoctype.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDoctype.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVDoctype.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVDoctype.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDoctype.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDoctype.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDoctype.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDoctype.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVDoctype.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDoctype.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDoctype.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVDoctype.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDoctype.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVDoctype.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDoctype.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDoctype.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVDoctype.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDoctype.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDoctype.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVDoctype.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVDoctype.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDoctype.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDoctype.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDoctype.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVDoctype.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVDoctype.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDoctype.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDoctype.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVDoctype.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVDoctype.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDoctype.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDoctype.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDoctype.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDoctype.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVDoctype.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDoctype.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDoctype.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVDoctype.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVDoctype.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDoctype.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDoctype.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDoctype.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVDoctype.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVDoctype.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDoctype.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDoctype.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDoctype.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVDoctype.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVDoctype.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDoctype.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVDoctype.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVDoctype.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDoctype.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVDoctype.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDoctype.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDoctype.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDoctype.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVDoctype.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDoctype.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVDoctype.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVDoctype.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVDoctype.Appearance.Preview.Options.UseBackColor = True
        Me.GVDoctype.Appearance.Preview.Options.UseFont = True
        Me.GVDoctype.Appearance.Preview.Options.UseForeColor = True
        Me.GVDoctype.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDoctype.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.Row.Options.UseBackColor = True
        Me.GVDoctype.Appearance.Row.Options.UseForeColor = True
        Me.GVDoctype.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDoctype.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVDoctype.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDoctype.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVDoctype.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVDoctype.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDoctype.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVDoctype.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVDoctype.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVDoctype.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVDoctype.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVDoctype.Appearance.VertLine.Options.UseBackColor = True
        Me.GVDoctype.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVDoctype.ColumnPanelRowHeight = 35
        Me.GVDoctype.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNo, Me.ColDocCode, Me.ColDocType, Me.ColNote_, Me.ColstRight, Me.colDel})
        Me.GVDoctype.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVDoctype.GridControl = Me.GCDocType
        Me.GVDoctype.Name = "GVDoctype"
        Me.GVDoctype.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVDoctype.OptionsView.EnableAppearanceEvenRow = True
        Me.GVDoctype.OptionsView.EnableAppearanceOddRow = True
        Me.GVDoctype.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GVDoctype.OptionsView.RowAutoHeight = True
        Me.GVDoctype.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVDoctype.OptionsView.ShowGroupPanel = False
        Me.GVDoctype.PaintStyleName = "MixedXP"
        Me.GVDoctype.RowHeight = 22
        '
        'colNo
        '
        Me.colNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colNo.AppearanceCell.Options.UseFont = True
        Me.colNo.AppearanceCell.Options.UseTextOptions = True
        Me.colNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colNo.AppearanceHeader.Options.UseFont = True
        Me.colNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNo.Caption = "No"
        Me.colNo.MaxWidth = 35
        Me.colNo.MinWidth = 35
        Me.colNo.Name = "colNo"
        Me.colNo.Visible = True
        Me.colNo.VisibleIndex = 0
        Me.colNo.Width = 35
        '
        'ColDocCode
        '
        Me.ColDocCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocCode.AppearanceCell.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.Caption = "รหัสเอกสาร"
        Me.ColDocCode.FieldName = "DocCode"
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 1
        Me.ColDocCode.Width = 314
        '
        'ColDocType
        '
        Me.ColDocType.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocType.AppearanceCell.Options.UseFont = True
        Me.ColDocType.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocType.AppearanceHeader.Options.UseFont = True
        Me.ColDocType.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocType.Caption = "ประเภท"
        Me.ColDocType.ColumnEdit = Me.rptDocType
        Me.ColDocType.FieldName = "idDocType"
        Me.ColDocType.Name = "ColDocType"
        Me.ColDocType.Visible = True
        Me.ColDocType.VisibleIndex = 2
        Me.ColDocType.Width = 426
        '
        'rptDocType
        '
        Me.rptDocType.AutoHeight = False
        Me.rptDocType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rptDocType.DisplayMember = "DocTypeName"
        Me.rptDocType.Name = "rptDocType"
        Me.rptDocType.NullText = ""
        Me.rptDocType.PopupFormMinSize = New System.Drawing.Size(40, 0)
        Me.rptDocType.ShowFooter = False
        Me.rptDocType.ShowHeader = False
        Me.rptDocType.ValueMember = "idDocType"
        '
        'ColNote_
        '
        Me.ColNote_.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNote_.AppearanceCell.Options.UseFont = True
        Me.ColNote_.AppearanceCell.Options.UseTextOptions = True
        Me.ColNote_.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColNote_.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNote_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNote_.AppearanceHeader.Options.UseFont = True
        Me.ColNote_.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNote_.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNote_.Caption = "หมายเหตุ"
        Me.ColNote_.ColumnEdit = Me.rptNote
        Me.ColNote_.FieldName = "Note"
        Me.ColNote_.Name = "ColNote_"
        Me.ColNote_.Visible = True
        Me.ColNote_.VisibleIndex = 3
        Me.ColNote_.Width = 770
        '
        'rptNote
        '
        Me.rptNote.Name = "rptNote"
        '
        'ColstRight
        '
        Me.ColstRight.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColstRight.AppearanceHeader.Options.UseFont = True
        Me.ColstRight.AppearanceHeader.Options.UseTextOptions = True
        Me.ColstRight.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColstRight.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColstRight.Caption = "สถานะถูกหลัก"
        Me.ColstRight.ColumnEdit = Me.rptStRight
        Me.ColstRight.FieldName = "stRight"
        Me.ColstRight.MaxWidth = 55
        Me.ColstRight.MinWidth = 55
        Me.ColstRight.Name = "ColstRight"
        Me.ColstRight.Visible = True
        Me.ColstRight.VisibleIndex = 4
        Me.ColstRight.Width = 55
        '
        'rptStRight
        '
        Me.rptStRight.AutoHeight = False
        Me.rptStRight.Name = "rptStRight"
        '
        'colDel
        '
        Me.colDel.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colDel.AppearanceCell.Options.UseFont = True
        Me.colDel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colDel.AppearanceHeader.Options.UseFont = True
        Me.colDel.AppearanceHeader.Options.UseTextOptions = True
        Me.colDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDel.Caption = "ลบ"
        Me.colDel.ColumnEdit = Me.rptDel
        Me.colDel.MaxWidth = 35
        Me.colDel.MinWidth = 35
        Me.colDel.Name = "colDel"
        Me.colDel.Visible = True
        Me.colDel.VisibleIndex = 5
        Me.colDel.Width = 35
        '
        'rptDel
        '
        Me.rptDel.AutoHeight = False
        Me.rptDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptDel.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptDel.Name = "rptDel"
        Me.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'rptnvName
        '
        Me.rptnvName.Appearance.Options.UseTextOptions = True
        Me.rptnvName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rptnvName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.rptnvName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rptnvName.Name = "rptnvName"
        '
        'rptNoteDt
        '
        Me.rptNoteDt.Appearance.Options.UseTextOptions = True
        Me.rptNoteDt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rptNoteDt.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.rptNoteDt.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rptNoteDt.Name = "rptNoteDt"
        '
        'GVWaitRecDt
        '
        Me.GVWaitRecDt.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GVWaitRecDt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVWaitRecDt.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GVWaitRecDt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVWaitRecDt.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVWaitRecDt.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVWaitRecDt.Appearance.HideSelectionRow.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GVWaitRecDt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVWaitRecDt.ColumnPanelRowHeight = 25
        Me.GVWaitRecDt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColDocCode_PO, Me.ColLotNo, Me.ColInvName, Me.ColAmountWait, Me.ColUnitName, Me.ColWhName, Me.ColNote, Me.clidWaitRecDt, Me.clidWaitRecMt, Me.clidLot, Me.clidInvMain, Me.clAmountRec, Me.clAmountWaitBal, Me.clidUnitNew, Me.clidWh, Me.clstWait, Me.clidSaleOrderDt, Me.clidFl, Me.ColidWhNewMove, Me.colidDt})
        Me.GVWaitRecDt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVWaitRecDt.GridControl = Me.GCDocType
        Me.GVWaitRecDt.Name = "GVWaitRecDt"
        Me.GVWaitRecDt.OptionsView.ShowGroupPanel = False
        Me.GVWaitRecDt.RowHeight = 22
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.MaxWidth = 55
        Me.ColNum.MinWidth = 55
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 55
        '
        'ColDocCode_PO
        '
        Me.ColDocCode_PO.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.ColDocCode_PO.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocCode_PO.AppearanceCell.Options.UseBackColor = True
        Me.ColDocCode_PO.AppearanceCell.Options.UseFont = True
        Me.ColDocCode_PO.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocCode_PO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColDocCode_PO.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode_PO.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode_PO.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode_PO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode_PO.Caption = "เลขที่ PO"
        Me.ColDocCode_PO.FieldName = "DocCode_PO"
        Me.ColDocCode_PO.Name = "ColDocCode_PO"
        Me.ColDocCode_PO.OptionsColumn.AllowEdit = False
        Me.ColDocCode_PO.OptionsColumn.AllowSize = False
        Me.ColDocCode_PO.Visible = True
        Me.ColDocCode_PO.VisibleIndex = 1
        Me.ColDocCode_PO.Width = 155
        '
        'ColLotNo
        '
        Me.ColLotNo.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.ColLotNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColLotNo.AppearanceCell.Options.UseBackColor = True
        Me.ColLotNo.AppearanceCell.Options.UseFont = True
        Me.ColLotNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColLotNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColLotNo.AppearanceHeader.Options.UseFont = True
        Me.ColLotNo.Caption = "Lot No."
        Me.ColLotNo.FieldName = "LotNo"
        Me.ColLotNo.Name = "ColLotNo"
        Me.ColLotNo.OptionsColumn.AllowEdit = False
        Me.ColLotNo.OptionsColumn.FixedWidth = True
        Me.ColLotNo.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.ColLotNo.Visible = True
        Me.ColLotNo.VisibleIndex = 2
        Me.ColLotNo.Width = 157
        '
        'ColInvName
        '
        Me.ColInvName.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.ColInvName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColInvName.AppearanceCell.Options.UseBackColor = True
        Me.ColInvName.AppearanceCell.Options.UseFont = True
        Me.ColInvName.AppearanceCell.Options.UseTextOptions = True
        Me.ColInvName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColInvName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColInvName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColInvName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColInvName.AppearanceHeader.Options.UseFont = True
        Me.ColInvName.Caption = "รายการ"
        Me.ColInvName.ColumnEdit = Me.rptnvName
        Me.ColInvName.FieldName = "InvName"
        Me.ColInvName.MinWidth = 120
        Me.ColInvName.Name = "ColInvName"
        Me.ColInvName.OptionsColumn.AllowEdit = False
        Me.ColInvName.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.ColInvName.Visible = True
        Me.ColInvName.VisibleIndex = 3
        Me.ColInvName.Width = 503
        '
        'ColAmountWait
        '
        Me.ColAmountWait.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.ColAmountWait.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmountWait.AppearanceCell.Options.UseBackColor = True
        Me.ColAmountWait.AppearanceCell.Options.UseFont = True
        Me.ColAmountWait.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmountWait.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmountWait.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmountWait.AppearanceHeader.Options.UseFont = True
        Me.ColAmountWait.Caption = "จำนวนรอรับ"
        Me.ColAmountWait.DisplayFormat.FormatString = "#,##0.00####"
        Me.ColAmountWait.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmountWait.FieldName = "AmountWait"
        Me.ColAmountWait.Name = "ColAmountWait"
        Me.ColAmountWait.OptionsColumn.AllowEdit = False
        Me.ColAmountWait.OptionsColumn.FixedWidth = True
        Me.ColAmountWait.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.ColAmountWait.Visible = True
        Me.ColAmountWait.VisibleIndex = 4
        Me.ColAmountWait.Width = 100
        '
        'ColUnitName
        '
        Me.ColUnitName.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.ColUnitName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColUnitName.AppearanceCell.Options.UseBackColor = True
        Me.ColUnitName.AppearanceCell.Options.UseFont = True
        Me.ColUnitName.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnitName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColUnitName.AppearanceHeader.Options.UseFont = True
        Me.ColUnitName.Caption = "หน่วย"
        Me.ColUnitName.FieldName = "UnitName"
        Me.ColUnitName.Name = "ColUnitName"
        Me.ColUnitName.OptionsColumn.AllowEdit = False
        Me.ColUnitName.OptionsColumn.FixedWidth = True
        Me.ColUnitName.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.ColUnitName.Visible = True
        Me.ColUnitName.VisibleIndex = 5
        Me.ColUnitName.Width = 80
        '
        'ColWhName
        '
        Me.ColWhName.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.ColWhName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColWhName.AppearanceCell.Options.UseBackColor = True
        Me.ColWhName.AppearanceCell.Options.UseFont = True
        Me.ColWhName.AppearanceCell.Options.UseTextOptions = True
        Me.ColWhName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColWhName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColWhName.AppearanceHeader.Options.UseFont = True
        Me.ColWhName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColWhName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColWhName.Caption = "คลังที่รอรับเข้า"
        Me.ColWhName.FieldName = "WareHouseName"
        Me.ColWhName.Name = "ColWhName"
        Me.ColWhName.Visible = True
        Me.ColWhName.VisibleIndex = 6
        Me.ColWhName.Width = 246
        '
        'ColNote
        '
        Me.ColNote.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.ColNote.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNote.AppearanceCell.Options.UseBackColor = True
        Me.ColNote.AppearanceCell.Options.UseFont = True
        Me.ColNote.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNote.AppearanceHeader.Options.UseFont = True
        Me.ColNote.Caption = "หมายเหตุ"
        Me.ColNote.ColumnEdit = Me.rptNoteDt
        Me.ColNote.FieldName = "Note"
        Me.ColNote.Name = "ColNote"
        Me.ColNote.OptionsColumn.AllowEdit = False
        Me.ColNote.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.ColNote.Visible = True
        Me.ColNote.VisibleIndex = 7
        Me.ColNote.Width = 336
        '
        'clidWaitRecDt
        '
        Me.clidWaitRecDt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.clidWaitRecDt.AppearanceCell.Options.UseFont = True
        Me.clidWaitRecDt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clidWaitRecDt.AppearanceHeader.Options.UseFont = True
        Me.clidWaitRecDt.Caption = "idWaitRecDt"
        Me.clidWaitRecDt.FieldName = "idWaitRecDt"
        Me.clidWaitRecDt.Name = "clidWaitRecDt"
        Me.clidWaitRecDt.OptionsColumn.AllowEdit = False
        Me.clidWaitRecDt.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clidWaitRecDt.Width = 74
        '
        'clidWaitRecMt
        '
        Me.clidWaitRecMt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.clidWaitRecMt.AppearanceCell.Options.UseFont = True
        Me.clidWaitRecMt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clidWaitRecMt.AppearanceHeader.Options.UseFont = True
        Me.clidWaitRecMt.Caption = "idWaitRecMt"
        Me.clidWaitRecMt.FieldName = "idWaitRecMt"
        Me.clidWaitRecMt.Name = "clidWaitRecMt"
        Me.clidWaitRecMt.OptionsColumn.AllowEdit = False
        Me.clidWaitRecMt.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clidWaitRecMt.Width = 74
        '
        'clidLot
        '
        Me.clidLot.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.clidLot.AppearanceCell.Options.UseFont = True
        Me.clidLot.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clidLot.AppearanceHeader.Options.UseFont = True
        Me.clidLot.Caption = "idLot"
        Me.clidLot.FieldName = "idLot"
        Me.clidLot.Name = "clidLot"
        Me.clidLot.OptionsColumn.AllowEdit = False
        Me.clidLot.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clidLot.Width = 74
        '
        'clidInvMain
        '
        Me.clidInvMain.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.clidInvMain.AppearanceCell.Options.UseFont = True
        Me.clidInvMain.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clidInvMain.AppearanceHeader.Options.UseFont = True
        Me.clidInvMain.Caption = "idInvMain"
        Me.clidInvMain.FieldName = "idInvMain"
        Me.clidInvMain.Name = "clidInvMain"
        Me.clidInvMain.OptionsColumn.AllowEdit = False
        Me.clidInvMain.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clidInvMain.Width = 70
        '
        'clAmountRec
        '
        Me.clAmountRec.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.clAmountRec.AppearanceCell.Options.UseFont = True
        Me.clAmountRec.AppearanceCell.Options.UseTextOptions = True
        Me.clAmountRec.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clAmountRec.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clAmountRec.AppearanceHeader.Options.UseFont = True
        Me.clAmountRec.Caption = "AmountRec"
        Me.clAmountRec.DisplayFormat.FormatString = "N2"
        Me.clAmountRec.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clAmountRec.FieldName = "AmountRec"
        Me.clAmountRec.Name = "clAmountRec"
        Me.clAmountRec.OptionsColumn.AllowEdit = False
        Me.clAmountRec.OptionsColumn.FixedWidth = True
        Me.clAmountRec.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.clAmountRec.Width = 100
        '
        'clAmountWaitBal
        '
        Me.clAmountWaitBal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.clAmountWaitBal.AppearanceCell.Options.UseFont = True
        Me.clAmountWaitBal.AppearanceCell.Options.UseTextOptions = True
        Me.clAmountWaitBal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clAmountWaitBal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clAmountWaitBal.AppearanceHeader.Options.UseFont = True
        Me.clAmountWaitBal.Caption = "AmountWaitBal"
        Me.clAmountWaitBal.DisplayFormat.FormatString = "N2"
        Me.clAmountWaitBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clAmountWaitBal.FieldName = "AmountWaitBal"
        Me.clAmountWaitBal.Name = "clAmountWaitBal"
        Me.clAmountWaitBal.OptionsColumn.AllowEdit = False
        Me.clAmountWaitBal.OptionsColumn.FixedWidth = True
        Me.clAmountWaitBal.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.clAmountWaitBal.Width = 100
        '
        'clidUnitNew
        '
        Me.clidUnitNew.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.clidUnitNew.AppearanceCell.Options.UseFont = True
        Me.clidUnitNew.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clidUnitNew.AppearanceHeader.Options.UseFont = True
        Me.clidUnitNew.Caption = "idUnitNew"
        Me.clidUnitNew.FieldName = "idUnitNew"
        Me.clidUnitNew.Name = "clidUnitNew"
        Me.clidUnitNew.OptionsColumn.AllowEdit = False
        Me.clidUnitNew.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clidUnitNew.Width = 41
        '
        'clidWh
        '
        Me.clidWh.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.clidWh.AppearanceCell.Options.UseFont = True
        Me.clidWh.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clidWh.AppearanceHeader.Options.UseFont = True
        Me.clidWh.Caption = "idWh"
        Me.clidWh.FieldName = "idWh"
        Me.clidWh.Name = "clidWh"
        Me.clidWh.OptionsColumn.AllowEdit = False
        Me.clidWh.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clidWh.Width = 41
        '
        'clstWait
        '
        Me.clstWait.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.clstWait.AppearanceCell.Options.UseFont = True
        Me.clstWait.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clstWait.AppearanceHeader.Options.UseFont = True
        Me.clstWait.Caption = "stWait"
        Me.clstWait.FieldName = "stWait"
        Me.clstWait.Name = "clstWait"
        Me.clstWait.OptionsColumn.AllowEdit = False
        Me.clstWait.Width = 48
        '
        'clidSaleOrderDt
        '
        Me.clidSaleOrderDt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.clidSaleOrderDt.AppearanceCell.Options.UseFont = True
        Me.clidSaleOrderDt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clidSaleOrderDt.AppearanceHeader.Options.UseFont = True
        Me.clidSaleOrderDt.Caption = "idSaleOrderDt"
        Me.clidSaleOrderDt.FieldName = "idSaleOrderDt"
        Me.clidSaleOrderDt.Name = "clidSaleOrderDt"
        Me.clidSaleOrderDt.OptionsColumn.AllowEdit = False
        Me.clidSaleOrderDt.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        '
        'clidFl
        '
        Me.clidFl.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.clidFl.AppearanceCell.Options.UseFont = True
        Me.clidFl.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clidFl.AppearanceHeader.Options.UseFont = True
        Me.clidFl.Caption = "idFl"
        Me.clidFl.FieldName = "idFl"
        Me.clidFl.Name = "clidFl"
        Me.clidFl.OptionsColumn.AllowEdit = False
        Me.clidFl.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        '
        'ColidWhNewMove
        '
        Me.ColidWhNewMove.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidWhNewMove.AppearanceCell.Options.UseFont = True
        Me.ColidWhNewMove.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidWhNewMove.AppearanceHeader.Options.UseFont = True
        Me.ColidWhNewMove.Caption = "idWhNewMove"
        Me.ColidWhNewMove.FieldName = "idWhNewMove"
        Me.ColidWhNewMove.Name = "ColidWhNewMove"
        '
        'colidDt
        '
        Me.colidDt.Caption = "idDt"
        Me.colidDt.FieldName = "idDt"
        Me.colidDt.Name = "colidDt"
        '
        'frmMnDocTypeCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(512, 538)
        Me.Controls.Add(Me.GCDocType)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMnDocTypeCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "จัดการประเภทเอกสาร"
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GCDocType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDoctype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDocType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptStRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptnvName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptNoteDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVWaitRecDt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbGroupComp As ComboBox
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCDocType As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDoctype As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptnvName As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents rptNoteDt As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GVWaitRecDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode_PO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColInvName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmountWait As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColWhName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clidWaitRecDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clidWaitRecMt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clidLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clidInvMain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clAmountRec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clAmountWaitBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clidUnitNew As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clidWh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clstWait As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clidSaleOrderDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clidFl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidWhNewMove As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDocType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColstRight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptStRight As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColNote_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
End Class
