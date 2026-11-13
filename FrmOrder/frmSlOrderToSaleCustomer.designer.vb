<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlOrderToSaleCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlOrderToSaleCustomer))
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim GridFormatRule7 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression7 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule8 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression8 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule9 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression9 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule10 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression10 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule11 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression11 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule12 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression12 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.GCSaleOrder = New DevExpress.XtraGrid.GridControl()
        Me.GVSaleOrder = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidSaleOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidCancel1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptBtnSel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColDetail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDetail = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColPartnerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateOrderD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateReq = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidPartner = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVSaleOrderDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GCSaleOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSaleOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptBtnSel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSaleOrderDt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 612
        Me.Label5.Text = "จำนวนรายการ"
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(108, 9)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(84, 26)
        Me.txtCount.TabIndex = 613
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.txtCount)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(340, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 41)
        Me.Panel3.TabIndex = 600
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.txtCusName)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(540, 61)
        Me.PanelControl1.TabIndex = 727
        '
        'txtCusName
        '
        Me.txtCusName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCusName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCusName.Location = New System.Drawing.Point(166, 12)
        Me.txtCusName.Multiline = True
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(203, 38)
        Me.txtCusName.TabIndex = 190
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(126, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 14)
        Me.Label2.TabIndex = 970
        Me.Label2.Text = "ลูกค้า"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Appearance.Options.UseFont = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.Panel3)
        Me.PanelControl3.Controls.Add(Me.btnRefresh)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 61)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(540, 41)
        Me.PanelControl3.TabIndex = 795
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefresh.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRefresh.Location = New System.Drawing.Point(2, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(106, 35)
        Me.btnRefresh.TabIndex = 583
        Me.btnRefresh.Text = " Refresh"
        '
        'GCSaleOrder
        '
        Me.GCSaleOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSaleOrder.Location = New System.Drawing.Point(0, 102)
        Me.GCSaleOrder.MainView = Me.GVSaleOrder
        Me.GCSaleOrder.Name = "GCSaleOrder"
        Me.GCSaleOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptDetail, Me.rptBtnSel})
        Me.GCSaleOrder.Size = New System.Drawing.Size(540, 402)
        Me.GCSaleOrder.TabIndex = 796
        Me.GCSaleOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSaleOrder, Me.GVSaleOrderDt})
        '
        'GVSaleOrder
        '
        Me.GVSaleOrder.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSaleOrder.Appearance.Empty.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GVSaleOrder.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleOrder.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleOrder.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSaleOrder.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GVSaleOrder.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSaleOrder.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GVSaleOrder.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleOrder.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleOrder.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleOrder.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVSaleOrder.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSaleOrder.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GVSaleOrder.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleOrder.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GVSaleOrder.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSaleOrder.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.Preview.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.Preview.Options.UseFont = True
        Me.GVSaleOrder.Appearance.Preview.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVSaleOrder.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSaleOrder.Appearance.Row.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.Row.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSaleOrder.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVSaleOrder.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSaleOrder.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSaleOrder.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSaleOrder.ColumnPanelRowHeight = 35
        Me.GVSaleOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidSaleOrder, Me.ColidCancel1, Me.ColidComp, Me.ColSelect, Me.ColDetail, Me.ColPartnerName, Me.ColDateOrderD, Me.ColDateReq, Me.colidPartner})
        Me.GVSaleOrder.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVSaleOrder.GridControl = Me.GCSaleOrder
        Me.GVSaleOrder.Name = "GVSaleOrder"
        Me.GVSaleOrder.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSaleOrder.OptionsView.EnableAppearanceOddRow = True
        Me.GVSaleOrder.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSaleOrder.OptionsView.ShowGroupPanel = False
        Me.GVSaleOrder.OptionsView.ShowIndicator = False
        Me.GVSaleOrder.PaintStyleName = "MixedXP"
        Me.GVSaleOrder.RowHeight = 25
        '
        'ColidSaleOrder
        '
        Me.ColidSaleOrder.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidSaleOrder.AppearanceCell.Options.UseFont = True
        Me.ColidSaleOrder.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidSaleOrder.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColidSaleOrder.AppearanceHeader.Options.UseFont = True
        Me.ColidSaleOrder.AppearanceHeader.Options.UseForeColor = True
        Me.ColidSaleOrder.Caption = "idSaleOrder"
        Me.ColidSaleOrder.FieldName = "idSaleOrder"
        Me.ColidSaleOrder.Name = "ColidSaleOrder"
        '
        'ColidCancel1
        '
        Me.ColidCancel1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidCancel1.AppearanceCell.Options.UseFont = True
        Me.ColidCancel1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidCancel1.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColidCancel1.AppearanceHeader.Options.UseFont = True
        Me.ColidCancel1.AppearanceHeader.Options.UseForeColor = True
        Me.ColidCancel1.Caption = "idCancel"
        Me.ColidCancel1.FieldName = "idPsCancel"
        Me.ColidCancel1.Name = "ColidCancel1"
        '
        'ColidComp
        '
        Me.ColidComp.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidComp.AppearanceCell.Options.UseFont = True
        Me.ColidComp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidComp.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColidComp.AppearanceHeader.Options.UseFont = True
        Me.ColidComp.AppearanceHeader.Options.UseForeColor = True
        Me.ColidComp.Caption = "idComp"
        Me.ColidComp.FieldName = "idComp"
        Me.ColidComp.Name = "ColidComp"
        '
        'ColSelect
        '
        Me.ColSelect.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColSelect.AppearanceCell.Options.UseFont = True
        Me.ColSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColSelect.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColSelect.AppearanceHeader.Options.UseFont = True
        Me.ColSelect.AppearanceHeader.Options.UseForeColor = True
        Me.ColSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSelect.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColSelect.Caption = "เลือก"
        Me.ColSelect.ColumnEdit = Me.rptBtnSel
        Me.ColSelect.MaxWidth = 45
        Me.ColSelect.MinWidth = 45
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.Visible = True
        Me.ColSelect.VisibleIndex = 0
        Me.ColSelect.Width = 45
        '
        'rptBtnSel
        '
        Me.rptBtnSel.AutoHeight = False
        Me.rptBtnSel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptBtnSel.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.rptBtnSel.Name = "rptBtnSel"
        Me.rptBtnSel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColDetail
        '
        Me.ColDetail.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDetail.AppearanceCell.Options.UseFont = True
        Me.ColDetail.AppearanceCell.Options.UseTextOptions = True
        Me.ColDetail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDetail.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDetail.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColDetail.AppearanceHeader.Options.UseFont = True
        Me.ColDetail.AppearanceHeader.Options.UseForeColor = True
        Me.ColDetail.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDetail.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDetail.Caption = "รายละเอียด"
        Me.ColDetail.ColumnEdit = Me.rptDetail
        Me.ColDetail.MaxWidth = 55
        Me.ColDetail.MinWidth = 55
        Me.ColDetail.Name = "ColDetail"
        Me.ColDetail.Visible = True
        Me.ColDetail.VisibleIndex = 1
        Me.ColDetail.Width = 55
        '
        'rptDetail
        '
        Me.rptDetail.AutoHeight = False
        Me.rptDetail.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptDetail.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.rptDetail.Name = "rptDetail"
        Me.rptDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColPartnerName
        '
        Me.ColPartnerName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColPartnerName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPartnerName.AppearanceCell.Options.UseBackColor = True
        Me.ColPartnerName.AppearanceCell.Options.UseFont = True
        Me.ColPartnerName.AppearanceCell.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPartnerName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPartnerName.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColPartnerName.AppearanceHeader.Options.UseFont = True
        Me.ColPartnerName.AppearanceHeader.Options.UseForeColor = True
        Me.ColPartnerName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPartnerName.Caption = "ชื่อลูกค้า"
        Me.ColPartnerName.FieldName = "PartnerName"
        Me.ColPartnerName.MinWidth = 170
        Me.ColPartnerName.Name = "ColPartnerName"
        Me.ColPartnerName.OptionsColumn.AllowEdit = False
        Me.ColPartnerName.OptionsColumn.ReadOnly = True
        Me.ColPartnerName.Visible = True
        Me.ColPartnerName.VisibleIndex = 2
        Me.ColPartnerName.Width = 307
        '
        'ColDateOrderD
        '
        Me.ColDateOrderD.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDateOrderD.AppearanceCell.Options.UseFont = True
        Me.ColDateOrderD.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateOrderD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateOrderD.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDateOrderD.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColDateOrderD.AppearanceHeader.Options.UseFont = True
        Me.ColDateOrderD.AppearanceHeader.Options.UseForeColor = True
        Me.ColDateOrderD.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateOrderD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateOrderD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDateOrderD.Caption = "จน.รายการ   สั่งซื้อทั้งหมด"
        Me.ColDateOrderD.FieldName = "AllOrder"
        Me.ColDateOrderD.MaxWidth = 90
        Me.ColDateOrderD.MinWidth = 90
        Me.ColDateOrderD.Name = "ColDateOrderD"
        Me.ColDateOrderD.OptionsColumn.AllowEdit = False
        Me.ColDateOrderD.OptionsColumn.ReadOnly = True
        Me.ColDateOrderD.OptionsColumn.TabStop = False
        Me.ColDateOrderD.Visible = True
        Me.ColDateOrderD.VisibleIndex = 3
        Me.ColDateOrderD.Width = 90
        '
        'ColDateReq
        '
        Me.ColDateReq.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDateReq.AppearanceCell.Options.UseFont = True
        Me.ColDateReq.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateReq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateReq.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDateReq.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColDateReq.AppearanceHeader.Options.UseFont = True
        Me.ColDateReq.AppearanceHeader.Options.UseForeColor = True
        Me.ColDateReq.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateReq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateReq.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDateReq.Caption = "จน.รายการที่ผ่านอนุมัติ"
        Me.ColDateReq.FieldName = "PassOrder"
        Me.ColDateReq.MaxWidth = 90
        Me.ColDateReq.MinWidth = 90
        Me.ColDateReq.Name = "ColDateReq"
        Me.ColDateReq.OptionsColumn.AllowEdit = False
        Me.ColDateReq.OptionsColumn.ReadOnly = True
        Me.ColDateReq.OptionsColumn.TabStop = False
        Me.ColDateReq.Visible = True
        Me.ColDateReq.VisibleIndex = 4
        Me.ColDateReq.Width = 90
        '
        'colidPartner
        '
        Me.colidPartner.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colidPartner.AppearanceCell.Options.UseFont = True
        Me.colidPartner.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colidPartner.AppearanceHeader.Options.UseFont = True
        Me.colidPartner.Caption = "idPartner"
        Me.colidPartner.FieldName = "idPartner"
        Me.colidPartner.Name = "colidPartner"
        '
        'GVSaleOrderDt
        '
        Me.GVSaleOrderDt.ColumnPanelRowHeight = 35
        Me.GVSaleOrderDt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        GridFormatRule7.Name = "Format0"
        FormatConditionRuleExpression7.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleExpression7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleExpression7.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression7.Appearance.Options.UseFont = True
        FormatConditionRuleExpression7.Expression = "[status] = 'พร้อมขาย'"
        FormatConditionRuleExpression7.PredefinedName = "Green Text"
        GridFormatRule7.Rule = FormatConditionRuleExpression7
        GridFormatRule8.ApplyToRow = True
        GridFormatRule8.Name = "Format4"
        FormatConditionRuleExpression8.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleExpression8.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression8.Expression = "[status] = 'พร้อมขาย'"
        GridFormatRule8.Rule = FormatConditionRuleExpression8
        GridFormatRule9.Name = "Format1"
        FormatConditionRuleExpression9.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleExpression9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleExpression9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        FormatConditionRuleExpression9.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression9.Appearance.Options.UseFont = True
        FormatConditionRuleExpression9.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression9.Expression = "[status] = 'อยู่ระหว่างผลิต'"
        GridFormatRule9.Rule = FormatConditionRuleExpression9
        GridFormatRule10.ApplyToRow = True
        GridFormatRule10.Name = "Format6"
        FormatConditionRuleExpression10.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleExpression10.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression10.Expression = "[status] = 'อยู่ระหว่างผลิต'"
        GridFormatRule10.Rule = FormatConditionRuleExpression10
        GridFormatRule11.Name = "Format3"
        FormatConditionRuleExpression11.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleExpression11.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleExpression11.Appearance.ForeColor = System.Drawing.Color.Olive
        FormatConditionRuleExpression11.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression11.Appearance.Options.UseFont = True
        FormatConditionRuleExpression11.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression11.Expression = "[status] = 'รอผลิต'"
        GridFormatRule11.Rule = FormatConditionRuleExpression11
        GridFormatRule12.ApplyToRow = True
        GridFormatRule12.Name = "Format5"
        FormatConditionRuleExpression12.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleExpression12.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression12.Expression = "[status] = 'รอผลิต'"
        GridFormatRule12.Rule = FormatConditionRuleExpression12
        Me.GVSaleOrderDt.FormatRules.Add(GridFormatRule7)
        Me.GVSaleOrderDt.FormatRules.Add(GridFormatRule8)
        Me.GVSaleOrderDt.FormatRules.Add(GridFormatRule9)
        Me.GVSaleOrderDt.FormatRules.Add(GridFormatRule10)
        Me.GVSaleOrderDt.FormatRules.Add(GridFormatRule11)
        Me.GVSaleOrderDt.FormatRules.Add(GridFormatRule12)
        Me.GVSaleOrderDt.GridControl = Me.GCSaleOrder
        Me.GVSaleOrderDt.Name = "GVSaleOrderDt"
        Me.GVSaleOrderDt.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVSaleOrderDt.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GVSaleOrderDt.OptionsView.ShowGroupPanel = False
        Me.GVSaleOrderDt.OptionsView.ShowIndicator = False
        '
        'frmSlOrderToSaleCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(540, 504)
        Me.Controls.Add(Me.GCSaleOrder)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSlOrderToSaleCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกลูกค้าที่มีรายการสั่งซื้อ (Order) เพื่อเปิดบิลขายสินค้า"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GCSaleOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSaleOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptBtnSel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSaleOrderDt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCSaleOrder As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSaleOrder As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidSaleOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidCancel1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptBtnSel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColDetail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDetail As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColPartnerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateOrderD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateReq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVSaleOrderDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colidPartner As DevExpress.XtraGrid.Columns.GridColumn
End Class
