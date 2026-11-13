<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreviewCont
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreviewCont))
        Me.GCIVList = New DevExpress.XtraGrid.GridControl()
        Me.GVIVList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocYear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GvLotFrom = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidJobRecPack = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPackCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFmName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColZoneName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColKg_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tpPreview = New DevExpress.XtraTab.XtraTabPage()
        Me.CrPreview = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.GCIVList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVIVList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvLotFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tpPreview.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCIVList
        '
        Me.GCIVList.Dock = System.Windows.Forms.DockStyle.Left
        Me.GCIVList.Location = New System.Drawing.Point(0, 0)
        Me.GCIVList.MainView = Me.GVIVList
        Me.GCIVList.Name = "GCIVList"
        Me.GCIVList.Size = New System.Drawing.Size(171, 711)
        Me.GCIVList.TabIndex = 680
        Me.GCIVList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVIVList, Me.GvLotFrom})
        '
        'GVIVList
        '
        Me.GVIVList.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVIVList.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVIVList.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVIVList.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVIVList.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVIVList.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVIVList.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVIVList.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVIVList.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVIVList.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVIVList.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVIVList.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVIVList.Appearance.Empty.Options.UseBackColor = True
        Me.GVIVList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVIVList.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVIVList.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVIVList.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVIVList.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVIVList.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVIVList.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVIVList.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVIVList.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVIVList.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVIVList.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVIVList.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVIVList.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVIVList.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVIVList.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVIVList.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVIVList.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVIVList.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVIVList.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVIVList.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVIVList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVIVList.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVIVList.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVIVList.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVIVList.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVIVList.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVIVList.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVIVList.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVIVList.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVIVList.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVIVList.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVIVList.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVIVList.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVIVList.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVIVList.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVIVList.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVIVList.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVIVList.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVIVList.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVIVList.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVIVList.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVIVList.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVIVList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVIVList.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVIVList.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVIVList.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVIVList.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVIVList.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVIVList.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVIVList.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVIVList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVIVList.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVIVList.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVIVList.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVIVList.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVIVList.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVIVList.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVIVList.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVIVList.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVIVList.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVIVList.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.OddRow.Options.UseBackColor = True
        Me.GVIVList.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVIVList.Appearance.OddRow.Options.UseForeColor = True
        Me.GVIVList.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVIVList.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVIVList.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVIVList.Appearance.Preview.Options.UseBackColor = True
        Me.GVIVList.Appearance.Preview.Options.UseFont = True
        Me.GVIVList.Appearance.Preview.Options.UseForeColor = True
        Me.GVIVList.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVIVList.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.Row.Options.UseBackColor = True
        Me.GVIVList.Appearance.Row.Options.UseForeColor = True
        Me.GVIVList.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVIVList.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVIVList.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVIVList.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVIVList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVIVList.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVIVList.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVIVList.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVIVList.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVIVList.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVIVList.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVIVList.Appearance.VertLine.Options.UseBackColor = True
        Me.GVIVList.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVIVList.ColumnPanelRowHeight = 36
        Me.GVIVList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColDocYear, Me.colidSale})
        Me.GVIVList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVIVList.GridControl = Me.GCIVList
        Me.GVIVList.GroupFormat = "[#image]{1} {2}"
        Me.GVIVList.GroupRowHeight = 28
        Me.GVIVList.Name = "GVIVList"
        Me.GVIVList.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVIVList.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVIVList.OptionsView.EnableAppearanceEvenRow = True
        Me.GVIVList.OptionsView.EnableAppearanceOddRow = True
        Me.GVIVList.OptionsView.RowAutoHeight = True
        Me.GVIVList.OptionsView.ShowGroupPanel = False
        Me.GVIVList.OptionsView.ShowIndicator = False
        Me.GVIVList.PaintStyleName = "Style3D"
        Me.GVIVList.RowHeight = 22
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.Caption = "#"
        Me.ColNum.MaxWidth = 35
        Me.ColNum.MinWidth = 35
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 35
        '
        'ColDocYear
        '
        Me.ColDocYear.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDocYear.AppearanceCell.Options.UseFont = True
        Me.ColDocYear.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocYear.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocYear.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocYear.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ColDocYear.AppearanceHeader.Options.UseFont = True
        Me.ColDocYear.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocYear.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocYear.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocYear.Caption = "เลขที่เอกสารขาย"
        Me.ColDocYear.FieldName = "DocRef"
        Me.ColDocYear.Name = "ColDocYear"
        Me.ColDocYear.OptionsColumn.AllowEdit = False
        Me.ColDocYear.OptionsColumn.ReadOnly = True
        Me.ColDocYear.Visible = True
        Me.ColDocYear.VisibleIndex = 1
        Me.ColDocYear.Width = 20
        '
        'colidSale
        '
        Me.colidSale.Caption = "idSale"
        Me.colidSale.FieldName = "idSale"
        Me.colidSale.Name = "colidSale"
        '
        'GvLotFrom
        '
        Me.GvLotFrom.ColumnPanelRowHeight = 24
        Me.GvLotFrom.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidJobRecPack, Me.ColidLot, Me.ColPackCode, Me.ColFmName, Me.ColZoneName, Me.ColKg_})
        Me.GvLotFrom.GridControl = Me.GCIVList
        Me.GvLotFrom.Name = "GvLotFrom"
        Me.GvLotFrom.OptionsView.ShowGroupPanel = False
        '
        'ColidJobRecPack
        '
        Me.ColidJobRecPack.Caption = "idJobRecPack"
        Me.ColidJobRecPack.FieldName = "idJobRecPack"
        Me.ColidJobRecPack.Name = "ColidJobRecPack"
        '
        'ColidLot
        '
        Me.ColidLot.Caption = "idLot"
        Me.ColidLot.FieldName = "idLot"
        Me.ColidLot.Name = "ColidLot"
        '
        'ColPackCode
        '
        Me.ColPackCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPackCode.AppearanceCell.Options.UseBackColor = True
        Me.ColPackCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColPackCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPackCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPackCode.AppearanceHeader.Options.UseFont = True
        Me.ColPackCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPackCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPackCode.Caption = "Pack Code"
        Me.ColPackCode.FieldName = "PackCode"
        Me.ColPackCode.Name = "ColPackCode"
        Me.ColPackCode.OptionsColumn.AllowEdit = False
        Me.ColPackCode.OptionsColumn.ReadOnly = True
        Me.ColPackCode.Visible = True
        Me.ColPackCode.VisibleIndex = 0
        Me.ColPackCode.Width = 160
        '
        'ColFmName
        '
        Me.ColFmName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColFmName.AppearanceCell.Options.UseBackColor = True
        Me.ColFmName.AppearanceCell.Options.UseTextOptions = True
        Me.ColFmName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColFmName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColFmName.AppearanceHeader.Options.UseFont = True
        Me.ColFmName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColFmName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColFmName.Caption = "เกษตรกร"
        Me.ColFmName.FieldName = "FmName"
        Me.ColFmName.Name = "ColFmName"
        Me.ColFmName.OptionsColumn.AllowEdit = False
        Me.ColFmName.OptionsColumn.ReadOnly = True
        Me.ColFmName.Visible = True
        Me.ColFmName.VisibleIndex = 1
        Me.ColFmName.Width = 160
        '
        'ColZoneName
        '
        Me.ColZoneName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColZoneName.AppearanceCell.Options.UseBackColor = True
        Me.ColZoneName.AppearanceCell.Options.UseTextOptions = True
        Me.ColZoneName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColZoneName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColZoneName.AppearanceHeader.Options.UseFont = True
        Me.ColZoneName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColZoneName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColZoneName.Caption = "พื้นที่"
        Me.ColZoneName.FieldName = "ZoneName"
        Me.ColZoneName.Name = "ColZoneName"
        Me.ColZoneName.OptionsColumn.AllowEdit = False
        Me.ColZoneName.OptionsColumn.ReadOnly = True
        Me.ColZoneName.Visible = True
        Me.ColZoneName.VisibleIndex = 2
        Me.ColZoneName.Width = 160
        '
        'ColKg_
        '
        Me.ColKg_.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColKg_.AppearanceCell.Options.UseBackColor = True
        Me.ColKg_.AppearanceCell.Options.UseTextOptions = True
        Me.ColKg_.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColKg_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColKg_.AppearanceHeader.Options.UseFont = True
        Me.ColKg_.AppearanceHeader.Options.UseTextOptions = True
        Me.ColKg_.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColKg_.Caption = "น้ำหนัก (Kg)"
        Me.ColKg_.DisplayFormat.FormatString = "N2"
        Me.ColKg_.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColKg_.FieldName = "Kg_"
        Me.ColKg_.MinWidth = 90
        Me.ColKg_.Name = "ColKg_"
        Me.ColKg_.OptionsColumn.AllowEdit = False
        Me.ColKg_.OptionsColumn.ReadOnly = True
        Me.ColKg_.Visible = True
        Me.ColKg_.VisibleIndex = 3
        Me.ColKg_.Width = 90
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.XtraTabControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Appearance.Options.UseFont = True
        Me.XtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(171, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.PaintStyleName = "PropertyView"
        Me.XtraTabControl1.SelectedTabPage = Me.tpPreview
        Me.XtraTabControl1.Size = New System.Drawing.Size(1013, 711)
        Me.XtraTabControl1.TabIndex = 755
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpPreview})
        '
        'tpPreview
        '
        Me.tpPreview.Appearance.Header.BackColor = System.Drawing.Color.Lavender
        Me.tpPreview.Appearance.Header.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpPreview.Appearance.Header.Options.UseBackColor = True
        Me.tpPreview.Appearance.HeaderActive.BackColor = System.Drawing.Color.PowderBlue
        Me.tpPreview.Appearance.HeaderActive.BackColor2 = System.Drawing.Color.LightSkyBlue
        Me.tpPreview.Appearance.HeaderActive.Options.UseBackColor = True
        Me.tpPreview.Controls.Add(Me.CrPreview)
        Me.tpPreview.Image = CType(resources.GetObject("tpPreview.Image"), System.Drawing.Image)
        Me.tpPreview.Name = "tpPreview"
        Me.tpPreview.Size = New System.Drawing.Size(1011, 671)
        Me.tpPreview.Text = "Invoice Preview"
        '
        'CrPreview
        '
        Me.CrPreview.ActiveViewIndex = -1
        Me.CrPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrPreview.Location = New System.Drawing.Point(0, 0)
        Me.CrPreview.Name = "CrPreview"
        Me.CrPreview.ShowGroupTreeButton = False
        Me.CrPreview.Size = New System.Drawing.Size(1011, 671)
        Me.CrPreview.TabIndex = 1
        Me.CrPreview.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmPreviewCont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.GCIVList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPreviewCont"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCIVList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVIVList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvLotFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tpPreview.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCIVList As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVIVList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColDocYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GvLotFrom As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidJobRecPack As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPackCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFmName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColZoneName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColKg_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpPreview As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CrPreview As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
End Class
