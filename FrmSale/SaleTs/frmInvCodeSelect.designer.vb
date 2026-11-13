<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvCodeSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvCodeSelect))
        Me.ColidInvMain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GVInvCode = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colShortName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCInvCode = New DevExpress.XtraGrid.GridControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInvCode = New System.Windows.Forms.TextBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.rptSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVInvCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCInvCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColidInvMain
        '
        Me.ColidInvMain.Caption = "idInvMain"
        Me.ColidInvMain.FieldName = "idInvMain"
        Me.ColidInvMain.Name = "ColidInvMain"
        '
        'colInvName
        '
        Me.colInvName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colInvName.AppearanceCell.Options.UseBackColor = True
        Me.colInvName.AppearanceCell.Options.UseTextOptions = True
        Me.colInvName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colInvName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvName.AppearanceHeader.Options.UseFont = True
        Me.colInvName.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvName.Caption = "ชื่อสินค้า"
        Me.colInvName.FieldName = "InvName"
        Me.colInvName.Name = "colInvName"
        Me.colInvName.OptionsColumn.AllowEdit = False
        Me.colInvName.OptionsColumn.ReadOnly = True
        Me.colInvName.OptionsColumn.TabStop = False
        Me.colInvName.Visible = True
        Me.colInvName.VisibleIndex = 2
        Me.colInvName.Width = 715
        '
        'colInvCode
        '
        Me.colInvCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colInvCode.AppearanceCell.Options.UseBackColor = True
        Me.colInvCode.AppearanceCell.Options.UseTextOptions = True
        Me.colInvCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvCode.AppearanceHeader.Options.UseFont = True
        Me.colInvCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvCode.Caption = "รหัสสินค้า"
        Me.colInvCode.FieldName = "InvCode"
        Me.colInvCode.MinWidth = 40
        Me.colInvCode.Name = "colInvCode"
        Me.colInvCode.OptionsColumn.AllowEdit = False
        Me.colInvCode.OptionsColumn.ReadOnly = True
        Me.colInvCode.OptionsColumn.TabStop = False
        Me.colInvCode.Visible = True
        Me.colInvCode.VisibleIndex = 1
        Me.colInvCode.Width = 358
        '
        'rptSelect
        '
        Me.rptSelect.AutoHeight = False
        Me.rptSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.arrow_modify_old_undo_icone_3957_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptSelect.Name = "rptSelect"
        Me.rptSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColSelect
        '
        Me.ColSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColSelect.AppearanceHeader.Options.UseFont = True
        Me.ColSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSelect.Caption = "เลือก"
        Me.ColSelect.ColumnEdit = Me.rptSelect
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.Visible = True
        Me.ColSelect.VisibleIndex = 0
        Me.ColSelect.Width = 123
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(43, 4)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(60, 23)
        Me.txtCount.TabIndex = 610
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(105, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 596
        Me.Label1.Text = "รายการ"
        '
        'GVInvCode
        '
        Me.GVInvCode.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVInvCode.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVInvCode.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVInvCode.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVInvCode.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVInvCode.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVInvCode.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVInvCode.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVInvCode.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVInvCode.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVInvCode.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVInvCode.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVInvCode.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVInvCode.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVInvCode.Appearance.Empty.Options.UseBackColor = True
        Me.GVInvCode.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GVInvCode.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVInvCode.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVInvCode.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVInvCode.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVInvCode.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVInvCode.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVInvCode.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVInvCode.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVInvCode.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVInvCode.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVInvCode.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVInvCode.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVInvCode.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVInvCode.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVInvCode.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVInvCode.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVInvCode.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVInvCode.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVInvCode.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVInvCode.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVInvCode.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVInvCode.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVInvCode.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVInvCode.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVInvCode.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVInvCode.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVInvCode.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVInvCode.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVInvCode.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVInvCode.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVInvCode.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVInvCode.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVInvCode.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVInvCode.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVInvCode.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVInvCode.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVInvCode.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVInvCode.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVInvCode.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVInvCode.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVInvCode.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVInvCode.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVInvCode.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVInvCode.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVInvCode.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVInvCode.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVInvCode.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVInvCode.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVInvCode.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVInvCode.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVInvCode.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVInvCode.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVInvCode.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVInvCode.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVInvCode.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVInvCode.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVInvCode.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVInvCode.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVInvCode.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVInvCode.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVInvCode.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVInvCode.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVInvCode.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVInvCode.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVInvCode.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVInvCode.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVInvCode.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVInvCode.Appearance.OddRow.Options.UseBackColor = True
        Me.GVInvCode.Appearance.OddRow.Options.UseForeColor = True
        Me.GVInvCode.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GVInvCode.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVInvCode.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVInvCode.Appearance.Preview.Options.UseBackColor = True
        Me.GVInvCode.Appearance.Preview.Options.UseFont = True
        Me.GVInvCode.Appearance.Preview.Options.UseForeColor = True
        Me.GVInvCode.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVInvCode.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVInvCode.Appearance.Row.Options.UseBackColor = True
        Me.GVInvCode.Appearance.Row.Options.UseForeColor = True
        Me.GVInvCode.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVInvCode.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVInvCode.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVInvCode.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVInvCode.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVInvCode.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVInvCode.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVInvCode.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVInvCode.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVInvCode.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVInvCode.Appearance.VertLine.Options.UseBackColor = True
        Me.GVInvCode.ColumnPanelRowHeight = 35
        Me.GVInvCode.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSelect, Me.colInvCode, Me.colInvName, Me.colShortName, Me.ColidInvMain})
        Me.GVInvCode.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVInvCode.GridControl = Me.GCInvCode
        Me.GVInvCode.GroupFormat = " [#image]{1} {2}"
        Me.GVInvCode.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", Nothing, "(คงเหลือ {0:#,##0.####})")})
        Me.GVInvCode.Name = "GVInvCode"
        Me.GVInvCode.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GVInvCode.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVInvCode.OptionsView.EnableAppearanceEvenRow = True
        Me.GVInvCode.OptionsView.EnableAppearanceOddRow = True
        Me.GVInvCode.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVInvCode.OptionsView.ShowGroupPanel = False
        Me.GVInvCode.OptionsView.ShowIndicator = False
        Me.GVInvCode.PaintStyleName = "MixedXP"
        Me.GVInvCode.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'colShortName
        '
        Me.colShortName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colShortName.AppearanceCell.Options.UseBackColor = True
        Me.colShortName.AppearanceCell.Options.UseTextOptions = True
        Me.colShortName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colShortName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colShortName.AppearanceHeader.Options.UseFont = True
        Me.colShortName.AppearanceHeader.Options.UseTextOptions = True
        Me.colShortName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colShortName.Caption = "ชื่อย่อ"
        Me.colShortName.FieldName = "ShortName"
        Me.colShortName.Name = "colShortName"
        Me.colShortName.OptionsColumn.AllowEdit = False
        Me.colShortName.OptionsColumn.ReadOnly = True
        Me.colShortName.OptionsColumn.TabStop = False
        Me.colShortName.Visible = True
        Me.colShortName.VisibleIndex = 3
        Me.colShortName.Width = 132
        '
        'GCInvCode
        '
        Me.GCInvCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCInvCode.Location = New System.Drawing.Point(0, 78)
        Me.GCInvCode.MainView = Me.GVInvCode
        Me.GCInvCode.Name = "GCInvCode"
        Me.GCInvCode.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptSelect})
        Me.GCInvCode.Size = New System.Drawing.Size(563, 485)
        Me.GCInvCode.TabIndex = 745
        Me.GCInvCode.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVInvCode})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(-1, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 594
        Me.Label4.Text = "จำนวน"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.txtCount)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(410, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(153, 33)
        Me.Panel8.TabIndex = 612
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.Panel8)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 45)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(563, 33)
        Me.PanelControl3.TabIndex = 744
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "รหัสสินค้า"
        '
        'txtInvCode
        '
        Me.txtInvCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtInvCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtInvCode.Location = New System.Drawing.Point(185, 12)
        Me.txtInvCode.Name = "txtInvCode"
        Me.txtInvCode.Size = New System.Drawing.Size(202, 21)
        Me.txtInvCode.TabIndex = 5
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.txtInvCode)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(563, 45)
        Me.PanelControl1.TabIndex = 743
        '
        'frmInvCodeSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 563)
        Me.Controls.Add(Me.GCInvCode)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvCodeSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหารหัสสินค้า"
        CType(Me.rptSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVInvCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCInvCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColidInvMain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GVInvCode As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCInvCode As DevExpress.XtraGrid.GridControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtInvCode As System.Windows.Forms.TextBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colShortName As DevExpress.XtraGrid.Columns.GridColumn
End Class
