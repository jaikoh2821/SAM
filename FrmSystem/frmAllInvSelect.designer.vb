<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAllInvSelect
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAllInvSelect))
        Me.btnSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.packagingPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gc2 = New DevExpress.XtraGrid.GridControl()
        Me.gv2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSelectMalti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.col_select = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvMain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInvCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInvName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idInvGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInvGroupName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_unitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_idUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idSubType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShortName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPriceBill_fg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPriceWholesale_fg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPriceRetail_fg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPrice_pdo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCreditThirty_pdo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCreditSixty_pdo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPrice_sfg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnMalti = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.txtInvName = New System.Windows.Forms.TextBox()
        Me.ChkInvName = New System.Windows.Forms.CheckBox()
        Me.ChkInvGroup = New System.Windows.Forms.CheckBox()
        Me.cmbInvName = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbType = New System.Windows.Forms.CheckBox()
        CType(Me.btnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.packagingPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.gc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GB1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.AutoHeight = False
        Me.btnSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.arrow_modify_old_undo_icone_3957_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'packagingPanel
        '
        Me.packagingPanel.Controls.Add(Me.Panel2)
        Me.packagingPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.packagingPanel.Location = New System.Drawing.Point(0, 0)
        Me.packagingPanel.Name = "packagingPanel"
        Me.packagingPanel.Size = New System.Drawing.Size(884, 556)
        Me.packagingPanel.TabIndex = 714
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.gc2)
        Me.Panel2.Controls.Add(Me.PanelControl3)
        Me.Panel2.Controls.Add(Me.PanelControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(884, 556)
        Me.Panel2.TabIndex = 712
        '
        'gc2
        '
        Me.gc2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc2.Location = New System.Drawing.Point(0, 122)
        Me.gc2.MainView = Me.gv2
        Me.gc2.Name = "gc2"
        Me.gc2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnSelect, Me.rptCheckEdit})
        Me.gc2.Size = New System.Drawing.Size(884, 434)
        Me.gc2.TabIndex = 1
        Me.gc2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv2})
        '
        'gv2
        '
        Me.gv2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gv2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gv2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gv2.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gv2.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gv2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.gv2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.gv2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gv2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gv2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gv2.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv2.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gv2.Appearance.Empty.Options.UseBackColor = True
        Me.gv2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.gv2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gv2.Appearance.EvenRow.Options.UseBackColor = True
        Me.gv2.Appearance.EvenRow.Options.UseForeColor = True
        Me.gv2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gv2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gv2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gv2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gv2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gv2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv2.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gv2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gv2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gv2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gv2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gv2.Appearance.FixedLine.Options.UseBackColor = True
        Me.gv2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gv2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gv2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gv2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gv2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gv2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gv2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gv2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gv2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gv2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gv2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gv2.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gv2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gv2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gv2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gv2.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv2.Appearance.GroupButton.Options.UseBackColor = True
        Me.gv2.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gv2.Appearance.GroupButton.Options.UseForeColor = True
        Me.gv2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.gv2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.gv2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gv2.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gv2.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gv2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gv2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gv2.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gv2.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gv2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.gv2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.gv2.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv2.Appearance.GroupRow.Options.UseBackColor = True
        Me.gv2.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gv2.Appearance.GroupRow.Options.UseForeColor = True
        Me.gv2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.gv2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.gv2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gv2.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gv2.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gv2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gv2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gv2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gv2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gv2.Appearance.HorzLine.Options.UseBackColor = True
        Me.gv2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.gv2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gv2.Appearance.OddRow.Options.UseBackColor = True
        Me.gv2.Appearance.OddRow.Options.UseForeColor = True
        Me.gv2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.gv2.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gv2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gv2.Appearance.Preview.Options.UseBackColor = True
        Me.gv2.Appearance.Preview.Options.UseFont = True
        Me.gv2.Appearance.Preview.Options.UseForeColor = True
        Me.gv2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.gv2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gv2.Appearance.Row.Options.UseBackColor = True
        Me.gv2.Appearance.Row.Options.UseForeColor = True
        Me.gv2.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv2.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gv2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gv2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.gv2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gv2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gv2.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gv2.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gv2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gv2.Appearance.VertLine.Options.UseBackColor = True
        Me.gv2.ColumnPanelRowHeight = 32
        Me.gv2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSelectMalti, Me.col_select, Me.colidInvMain, Me.ColInvCode, Me.ColInvName, Me.idInvGroup, Me.ColInvGroupName, Me.col_unitName, Me.col_idUnit, Me.idSubType, Me.colShortName, Me.col_amount, Me.ColPriceBill_fg, Me.ColPriceWholesale_fg, Me.ColPriceRetail_fg, Me.ColPrice_pdo, Me.ColCreditThirty_pdo, Me.ColCreditSixty_pdo, Me.ColPrice_sfg})
        Me.gv2.GridControl = Me.gc2
        Me.gv2.Name = "gv2"
        Me.gv2.OptionsView.EnableAppearanceEvenRow = True
        Me.gv2.OptionsView.EnableAppearanceOddRow = True
        Me.gv2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gv2.OptionsView.ShowGroupPanel = False
        Me.gv2.OptionsView.ShowIndicator = False
        Me.gv2.PaintStyleName = "MixedXP"
        '
        'ColSelectMalti
        '
        Me.ColSelectMalti.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColSelectMalti.AppearanceHeader.Options.UseFont = True
        Me.ColSelectMalti.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSelectMalti.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSelectMalti.Caption = "เลือก"
        Me.ColSelectMalti.ColumnEdit = Me.rptCheckEdit
        Me.ColSelectMalti.FieldName = "ChkKey"
        Me.ColSelectMalti.Name = "ColSelectMalti"
        Me.ColSelectMalti.Visible = True
        Me.ColSelectMalti.VisibleIndex = 1
        Me.ColSelectMalti.Width = 49
        '
        'rptCheckEdit
        '
        Me.rptCheckEdit.AutoHeight = False
        Me.rptCheckEdit.Name = "rptCheckEdit"
        '
        'col_select
        '
        Me.col_select.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_select.AppearanceHeader.Options.UseFont = True
        Me.col_select.AppearanceHeader.Options.UseTextOptions = True
        Me.col_select.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_select.Caption = "เลือก"
        Me.col_select.ColumnEdit = Me.btnSelect
        Me.col_select.Name = "col_select"
        Me.col_select.OptionsColumn.FixedWidth = True
        Me.col_select.Visible = True
        Me.col_select.VisibleIndex = 0
        Me.col_select.Width = 50
        '
        'colidInvMain
        '
        Me.colidInvMain.Caption = "idInvMain"
        Me.colidInvMain.FieldName = "idInvMain"
        Me.colidInvMain.Name = "colidInvMain"
        '
        'ColInvCode
        '
        Me.ColInvCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColInvCode.AppearanceCell.Options.UseBackColor = True
        Me.ColInvCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColInvCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColInvCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColInvCode.AppearanceHeader.Options.UseFont = True
        Me.ColInvCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColInvCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColInvCode.Caption = "รหัสสินค้า"
        Me.ColInvCode.FieldName = "InvCode"
        Me.ColInvCode.Name = "ColInvCode"
        Me.ColInvCode.OptionsColumn.AllowEdit = False
        Me.ColInvCode.OptionsColumn.ReadOnly = True
        Me.ColInvCode.OptionsColumn.TabStop = False
        Me.ColInvCode.Visible = True
        Me.ColInvCode.VisibleIndex = 2
        Me.ColInvCode.Width = 120
        '
        'ColInvName
        '
        Me.ColInvName.AppearanceCell.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ColInvName.AppearanceCell.Options.UseBackColor = True
        Me.ColInvName.AppearanceCell.Options.UseTextOptions = True
        Me.ColInvName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColInvName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColInvName.AppearanceHeader.Options.UseFont = True
        Me.ColInvName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColInvName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColInvName.Caption = "รายการสินค้า"
        Me.ColInvName.FieldName = "InvName"
        Me.ColInvName.Name = "ColInvName"
        Me.ColInvName.OptionsColumn.AllowEdit = False
        Me.ColInvName.OptionsColumn.TabStop = False
        Me.ColInvName.Visible = True
        Me.ColInvName.VisibleIndex = 3
        Me.ColInvName.Width = 339
        '
        'idInvGroup
        '
        Me.idInvGroup.Caption = "idInvGroup"
        Me.idInvGroup.FieldName = "idInvGroup"
        Me.idInvGroup.Name = "idInvGroup"
        Me.idInvGroup.Width = 106
        '
        'ColInvGroupName
        '
        Me.ColInvGroupName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColInvGroupName.AppearanceCell.Options.UseBackColor = True
        Me.ColInvGroupName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColInvGroupName.AppearanceHeader.Options.UseFont = True
        Me.ColInvGroupName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColInvGroupName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColInvGroupName.Caption = "ประเภท"
        Me.ColInvGroupName.FieldName = "InvGroupName"
        Me.ColInvGroupName.MaxWidth = 180
        Me.ColInvGroupName.MinWidth = 120
        Me.ColInvGroupName.Name = "ColInvGroupName"
        Me.ColInvGroupName.OptionsColumn.AllowEdit = False
        Me.ColInvGroupName.OptionsColumn.TabStop = False
        Me.ColInvGroupName.Visible = True
        Me.ColInvGroupName.VisibleIndex = 5
        Me.ColInvGroupName.Width = 123
        '
        'col_unitName
        '
        Me.col_unitName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_unitName.AppearanceCell.Options.UseBackColor = True
        Me.col_unitName.AppearanceCell.Options.UseTextOptions = True
        Me.col_unitName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_unitName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_unitName.AppearanceHeader.Options.UseFont = True
        Me.col_unitName.AppearanceHeader.Options.UseTextOptions = True
        Me.col_unitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_unitName.Caption = "หน่วย"
        Me.col_unitName.FieldName = "UnitName"
        Me.col_unitName.MinWidth = 70
        Me.col_unitName.Name = "col_unitName"
        Me.col_unitName.OptionsColumn.AllowEdit = False
        Me.col_unitName.OptionsColumn.TabStop = False
        Me.col_unitName.Visible = True
        Me.col_unitName.VisibleIndex = 6
        Me.col_unitName.Width = 79
        '
        'col_idUnit
        '
        Me.col_idUnit.Caption = "idUnit"
        Me.col_idUnit.FieldName = "idUnit"
        Me.col_idUnit.Name = "col_idUnit"
        '
        'idSubType
        '
        Me.idSubType.Caption = "idSubType"
        Me.idSubType.FieldName = "idSubType"
        Me.idSubType.Name = "idSubType"
        Me.idSubType.Width = 118
        '
        'colShortName
        '
        Me.colShortName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colShortName.AppearanceCell.Options.UseBackColor = True
        Me.colShortName.AppearanceCell.Options.UseTextOptions = True
        Me.colShortName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colShortName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colShortName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colShortName.AppearanceHeader.Options.UseFont = True
        Me.colShortName.AppearanceHeader.Options.UseTextOptions = True
        Me.colShortName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colShortName.Caption = "ชื่อย่อ"
        Me.colShortName.FieldName = "ShortName"
        Me.colShortName.MinWidth = 50
        Me.colShortName.Name = "colShortName"
        Me.colShortName.OptionsColumn.AllowEdit = False
        Me.colShortName.OptionsColumn.ReadOnly = True
        Me.colShortName.OptionsColumn.TabStop = False
        Me.colShortName.Visible = True
        Me.colShortName.VisibleIndex = 4
        Me.colShortName.Width = 51
        '
        'col_amount
        '
        Me.col_amount.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.col_amount.AppearanceCell.Options.UseBackColor = True
        Me.col_amount.AppearanceCell.Options.UseTextOptions = True
        Me.col_amount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_amount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_amount.AppearanceHeader.Options.UseFont = True
        Me.col_amount.AppearanceHeader.Options.UseTextOptions = True
        Me.col_amount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_amount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.col_amount.Caption = "จำนวนคงเหลือ"
        Me.col_amount.DisplayFormat.FormatString = "#,##0.00##"
        Me.col_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_amount.FieldName = "amount"
        Me.col_amount.MinWidth = 70
        Me.col_amount.Name = "col_amount"
        Me.col_amount.OptionsColumn.AllowEdit = False
        Me.col_amount.Width = 71
        '
        'ColPriceBill_fg
        '
        Me.ColPriceBill_fg.Caption = "PriceBill"
        Me.ColPriceBill_fg.FieldName = "PriceBill"
        Me.ColPriceBill_fg.Name = "ColPriceBill_fg"
        '
        'ColPriceWholesale_fg
        '
        Me.ColPriceWholesale_fg.Caption = "PriceWholesale"
        Me.ColPriceWholesale_fg.FieldName = "PriceWholesale"
        Me.ColPriceWholesale_fg.Name = "ColPriceWholesale_fg"
        '
        'ColPriceRetail_fg
        '
        Me.ColPriceRetail_fg.Caption = "PriceRetail"
        Me.ColPriceRetail_fg.FieldName = "PriceRetail"
        Me.ColPriceRetail_fg.Name = "ColPriceRetail_fg"
        '
        'ColPrice_pdo
        '
        Me.ColPrice_pdo.Caption = "PricePdo"
        Me.ColPrice_pdo.FieldName = "PricePdo"
        Me.ColPrice_pdo.Name = "ColPrice_pdo"
        '
        'ColCreditThirty_pdo
        '
        Me.ColCreditThirty_pdo.Caption = "CreditThirty"
        Me.ColCreditThirty_pdo.FieldName = "CreditThirty"
        Me.ColCreditThirty_pdo.Name = "ColCreditThirty_pdo"
        '
        'ColCreditSixty_pdo
        '
        Me.ColCreditSixty_pdo.Caption = "CreditSixty"
        Me.ColCreditSixty_pdo.FieldName = "CreditSixty"
        Me.ColCreditSixty_pdo.Name = "ColCreditSixty_pdo"
        '
        'ColPrice_sfg
        '
        Me.ColPrice_sfg.Caption = "PriceSeedFg"
        Me.ColPrice_sfg.FieldName = "PriceSeedFg"
        Me.ColPrice_sfg.Name = "ColPrice_sfg"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.btnMalti)
        Me.PanelControl3.Controls.Add(Me.Panel8)
        Me.PanelControl3.Controls.Add(Me.btnSearch)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 88)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(884, 34)
        Me.PanelControl3.TabIndex = 717
        '
        'btnMalti
        '
        Me.btnMalti.BackColor = System.Drawing.Color.DimGray
        Me.btnMalti.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMalti.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMalti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMalti.ForeColor = System.Drawing.Color.White
        Me.btnMalti.Image = Global.SAM.My.Resources.Resources.arrow_down_icon
        Me.btnMalti.Location = New System.Drawing.Point(104, 0)
        Me.btnMalti.Name = "btnMalti"
        Me.btnMalti.Size = New System.Drawing.Size(140, 34)
        Me.btnMalti.TabIndex = 611
        Me.btnMalti.TabStop = False
        Me.btnMalti.Tag = "Add"
        Me.btnMalti.Text = " เลือกรายการที่ระบุ"
        Me.btnMalti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMalti.UseVisualStyleBackColor = False
        Me.btnMalti.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.txtCount)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(659, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(225, 34)
        Me.Panel8.TabIndex = 610
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(60, 6)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(100, 23)
        Me.txtCount.TabIndex = 610
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(166, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 596
        Me.Label1.Text = "รายการ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 594
        Me.Label4.Text = "จำนวน"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DimGray
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = Global.SAM.My.Resources.Resources.refresh_24x24
        Me.btnSearch.Location = New System.Drawing.Point(0, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(104, 34)
        Me.btnSearch.TabIndex = 392
        Me.btnSearch.TabStop = False
        Me.btnSearch.Tag = "Add"
        Me.btnSearch.Text = " Refresh"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        Me.btnSearch.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GB1)
        Me.PanelControl1.Controls.Add(Me.GroupBox3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(884, 88)
        Me.PanelControl1.TabIndex = 0
        '
        'GB1
        '
        Me.GB1.BackColor = System.Drawing.Color.Transparent
        Me.GB1.Controls.Add(Me.txtInvName)
        Me.GB1.Controls.Add(Me.ChkInvName)
        Me.GB1.Controls.Add(Me.ChkInvGroup)
        Me.GB1.Controls.Add(Me.cmbInvName)
        Me.GB1.Location = New System.Drawing.Point(110, 6)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(405, 78)
        Me.GB1.TabIndex = 711
        Me.GB1.TabStop = False
        Me.GB1.Text = "ค้นหา"
        '
        'txtInvName
        '
        Me.txtInvName.Enabled = False
        Me.txtInvName.Location = New System.Drawing.Point(122, 47)
        Me.txtInvName.Name = "txtInvName"
        Me.txtInvName.Size = New System.Drawing.Size(268, 21)
        Me.txtInvName.TabIndex = 4
        '
        'ChkInvName
        '
        Me.ChkInvName.AutoSize = True
        Me.ChkInvName.Checked = True
        Me.ChkInvName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkInvName.Location = New System.Drawing.Point(23, 49)
        Me.ChkInvName.Name = "ChkInvName"
        Me.ChkInvName.Size = New System.Drawing.Size(97, 17)
        Me.ChkInvName.TabIndex = 3
        Me.ChkInvName.Text = "ชื่อสินค้า/ชื่อย่อ"
        Me.ChkInvName.UseVisualStyleBackColor = True
        '
        'ChkInvGroup
        '
        Me.ChkInvGroup.AutoSize = True
        Me.ChkInvGroup.Checked = True
        Me.ChkInvGroup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkInvGroup.Location = New System.Drawing.Point(23, 21)
        Me.ChkInvGroup.Name = "ChkInvGroup"
        Me.ChkInvGroup.Size = New System.Drawing.Size(62, 17)
        Me.ChkInvGroup.TabIndex = 1
        Me.ChkInvGroup.Text = "ประเภท"
        Me.ChkInvGroup.UseVisualStyleBackColor = True
        '
        'cmbInvName
        '
        Me.cmbInvName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInvName.FormattingEnabled = True
        Me.cmbInvName.Location = New System.Drawing.Point(122, 20)
        Me.cmbInvName.Name = "cmbInvName"
        Me.cmbInvName.Size = New System.Drawing.Size(268, 21)
        Me.cmbInvName.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cbType)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(93, 78)
        Me.GroupBox3.TabIndex = 712
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "จัดกลุ่มตาม"
        '
        'cbType
        '
        Me.cbType.AutoSize = True
        Me.cbType.Location = New System.Drawing.Point(21, 20)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(62, 17)
        Me.cbType.TabIndex = 0
        Me.cbType.TabStop = False
        Me.cbType.Text = "ประเภท"
        Me.cbType.UseVisualStyleBackColor = True
        '
        'frmAllInvSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(884, 556)
        Me.Controls.Add(Me.packagingPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAllInvSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกสินค้า/วัสดุ"
        CType(Me.btnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.packagingPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.gc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents packagingPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents gc2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColInvGroupName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColInvName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_unitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_select As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInvName As System.Windows.Forms.TextBox
    Friend WithEvents ChkInvName As System.Windows.Forms.CheckBox
    Friend WithEvents ChkInvGroup As System.Windows.Forms.CheckBox
    Friend WithEvents cmbInvName As System.Windows.Forms.ComboBox
    Friend WithEvents col_idUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPriceBill_fg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents idInvGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents idSubType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidInvMain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShortName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents txtCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColSelectMalti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbType As System.Windows.Forms.CheckBox
    Friend WithEvents ColPriceWholesale_fg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPriceRetail_fg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrice_pdo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCreditThirty_pdo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCreditSixty_pdo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrice_sfg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnMalti As System.Windows.Forms.Button
    Friend WithEvents rptCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColInvCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
