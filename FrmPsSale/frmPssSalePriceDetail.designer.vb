<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPssSalePriceDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPssSalePriceDetail))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.GCPrice = New DevExpress.XtraGrid.GridControl()
        Me.GVPrice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSaleDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidProduct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotalNet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptbtnEditApv = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.rptChkEditApv = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GCPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptbtnEditApv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptChkEditApv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.lblTag)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(964, 35)
        Me.PanelControl2.TabIndex = 606
        '
        'lblTag
        '
        Me.lblTag.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTag.AutoSize = True
        Me.lblTag.BackColor = System.Drawing.Color.Transparent
        Me.lblTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTag.ForeColor = System.Drawing.Color.Navy
        Me.lblTag.Image = Global.SAM.My.Resources.Resources.document_32x32
        Me.lblTag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTag.Location = New System.Drawing.Point(15, 7)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(194, 20)
        Me.lblTag.TabIndex = 1
        Me.lblTag.Text = "      รายการขายแยกตามบิล"
        '
        'GCPrice
        '
        Me.GCPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCPrice.Location = New System.Drawing.Point(0, 35)
        Me.GCPrice.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.GCPrice.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GCPrice.MainView = Me.GVPrice
        Me.GCPrice.Name = "GCPrice"
        Me.GCPrice.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptbtnEditApv, Me.rptChkEditApv})
        Me.GCPrice.Size = New System.Drawing.Size(964, 516)
        Me.GCPrice.TabIndex = 607
        Me.GCPrice.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPrice})
        '
        'GVPrice
        '
        Me.GVPrice.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVPrice.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVPrice.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVPrice.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVPrice.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVPrice.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVPrice.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVPrice.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVPrice.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVPrice.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVPrice.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVPrice.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVPrice.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVPrice.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVPrice.Appearance.Empty.Options.UseBackColor = True
        Me.GVPrice.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GVPrice.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVPrice.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVPrice.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVPrice.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVPrice.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVPrice.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVPrice.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVPrice.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVPrice.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVPrice.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVPrice.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVPrice.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVPrice.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVPrice.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVPrice.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVPrice.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVPrice.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GVPrice.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVPrice.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVPrice.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVPrice.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVPrice.Appearance.FocusedRow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVPrice.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVPrice.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVPrice.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVPrice.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVPrice.Appearance.FooterPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVPrice.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVPrice.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVPrice.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVPrice.Appearance.FooterPanel.Options.UseFont = True
        Me.GVPrice.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVPrice.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVPrice.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVPrice.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVPrice.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVPrice.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVPrice.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVPrice.Appearance.GroupButton.Options.UseImage = True
        Me.GVPrice.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVPrice.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVPrice.Appearance.GroupFooter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVPrice.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVPrice.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVPrice.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVPrice.Appearance.GroupFooter.Options.UseFont = True
        Me.GVPrice.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVPrice.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVPrice.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVPrice.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVPrice.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVPrice.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVPrice.Appearance.GroupRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GVPrice.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVPrice.Appearance.GroupRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVPrice.Appearance.GroupRow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVPrice.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVPrice.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVPrice.Appearance.GroupRow.Options.UseFont = True
        Me.GVPrice.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVPrice.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVPrice.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVPrice.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GVPrice.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVPrice.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVPrice.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVPrice.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVPrice.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVPrice.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVPrice.Appearance.HideSelectionRow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVPrice.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVPrice.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVPrice.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVPrice.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVPrice.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GVPrice.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVPrice.Appearance.OddRow.Options.UseBackColor = True
        Me.GVPrice.Appearance.OddRow.Options.UseForeColor = True
        Me.GVPrice.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GVPrice.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVPrice.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVPrice.Appearance.Preview.Options.UseBackColor = True
        Me.GVPrice.Appearance.Preview.Options.UseFont = True
        Me.GVPrice.Appearance.Preview.Options.UseForeColor = True
        Me.GVPrice.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVPrice.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVPrice.Appearance.Row.Options.UseBackColor = True
        Me.GVPrice.Appearance.Row.Options.UseForeColor = True
        Me.GVPrice.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVPrice.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVPrice.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVPrice.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVPrice.Appearance.SelectedRow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVPrice.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVPrice.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVPrice.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVPrice.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVPrice.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVPrice.Appearance.VertLine.Options.UseBackColor = True
        Me.GVPrice.AppearancePrint.FooterPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVPrice.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.GVPrice.ColumnPanelRowHeight = 38
        Me.GVPrice.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColidSaleDt, Me.ColidProduct, Me.ColDocSale, Me.ColProductName, Me.ColAmount, Me.ColUnit, Me.ColPrice, Me.ColTotalNet})
        Me.GVPrice.GridControl = Me.GCPrice
        Me.GVPrice.GroupCount = 1
        Me.GVPrice.GroupFormat = "[#image]{1} {2}"
        Me.GVPrice.Name = "GVPrice"
        Me.GVPrice.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVPrice.OptionsView.EnableAppearanceEvenRow = True
        Me.GVPrice.OptionsView.EnableAppearanceOddRow = True
        Me.GVPrice.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVPrice.OptionsView.ShowFooter = True
        Me.GVPrice.OptionsView.ShowGroupPanel = False
        Me.GVPrice.OptionsView.ShowIndicator = False
        Me.GVPrice.PaintStyleName = "UltraFlat"
        Me.GVPrice.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ColDocSale, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.FieldName = "Num"
        Me.ColNum.MaxWidth = 60
        Me.ColNum.MinWidth = 50
        Me.ColNum.Name = "ColNum"
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 67
        '
        'ColidSaleDt
        '
        Me.ColidSaleDt.Caption = "idSaleDt"
        Me.ColidSaleDt.FieldName = "idSaleDt"
        Me.ColidSaleDt.Name = "ColidSaleDt"
        '
        'ColidProduct
        '
        Me.ColidProduct.Caption = "idProduct"
        Me.ColidProduct.FieldName = "idProduct"
        Me.ColidProduct.Name = "ColidProduct"
        '
        'ColDocSale
        '
        Me.ColDocSale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocSale.AppearanceCell.BorderColor = System.Drawing.Color.Gray
        Me.ColDocSale.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ColDocSale.AppearanceCell.Options.UseBackColor = True
        Me.ColDocSale.AppearanceCell.Options.UseBorderColor = True
        Me.ColDocSale.AppearanceCell.Options.UseFont = True
        Me.ColDocSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColDocSale.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ColDocSale.AppearanceHeader.Options.UseFont = True
        Me.ColDocSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocSale.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocSale.Caption = "บิลขาย"
        Me.ColDocSale.FieldName = "DocSale"
        Me.ColDocSale.MaxWidth = 100
        Me.ColDocSale.MinWidth = 80
        Me.ColDocSale.Name = "ColDocSale"
        Me.ColDocSale.OptionsColumn.AllowEdit = False
        Me.ColDocSale.OptionsColumn.ReadOnly = True
        Me.ColDocSale.Visible = True
        Me.ColDocSale.VisibleIndex = 1
        Me.ColDocSale.Width = 80
        '
        'ColProductName
        '
        Me.ColProductName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColProductName.AppearanceCell.BorderColor = System.Drawing.Color.Gray
        Me.ColProductName.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ColProductName.AppearanceCell.Options.UseBackColor = True
        Me.ColProductName.AppearanceCell.Options.UseBorderColor = True
        Me.ColProductName.AppearanceCell.Options.UseFont = True
        Me.ColProductName.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColProductName.AppearanceHeader.Options.UseFont = True
        Me.ColProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProductName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColProductName.Caption = "ชื่อสินค้า"
        Me.ColProductName.FieldName = "ProductName"
        Me.ColProductName.MinWidth = 200
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.OptionsColumn.AllowEdit = False
        Me.ColProductName.OptionsColumn.ReadOnly = True
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 1
        Me.ColProductName.Width = 280
        '
        'ColAmount
        '
        Me.ColAmount.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColAmount.AppearanceCell.BorderColor = System.Drawing.Color.Gray
        Me.ColAmount.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ColAmount.AppearanceCell.Options.UseBackColor = True
        Me.ColAmount.AppearanceCell.Options.UseBorderColor = True
        Me.ColAmount.AppearanceCell.Options.UseFont = True
        Me.ColAmount.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmount.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColAmount.AppearanceHeader.Options.UseFont = True
        Me.ColAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmount.Caption = "จำนวนขาย"
        Me.ColAmount.DisplayFormat.FormatString = "#,##0.##"
        Me.ColAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmount.FieldName = "Amount"
        Me.ColAmount.MaxWidth = 110
        Me.ColAmount.MinWidth = 90
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.OptionsColumn.AllowEdit = False
        Me.ColAmount.OptionsColumn.ReadOnly = True
        Me.ColAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "รวม = {0:#,##0.##}")})
        Me.ColAmount.Visible = True
        Me.ColAmount.VisibleIndex = 2
        Me.ColAmount.Width = 90
        '
        'ColUnit
        '
        Me.ColUnit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColUnit.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ColUnit.AppearanceCell.Options.UseBackColor = True
        Me.ColUnit.AppearanceCell.Options.UseFont = True
        Me.ColUnit.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnit.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColUnit.AppearanceHeader.Options.UseFont = True
        Me.ColUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColUnit.Caption = "หน่วยขาย"
        Me.ColUnit.FieldName = "UnitName"
        Me.ColUnit.MaxWidth = 80
        Me.ColUnit.MinWidth = 60
        Me.ColUnit.Name = "ColUnit"
        Me.ColUnit.OptionsColumn.AllowEdit = False
        Me.ColUnit.OptionsColumn.ReadOnly = True
        Me.ColUnit.Visible = True
        Me.ColUnit.VisibleIndex = 3
        Me.ColUnit.Width = 80
        '
        'ColPrice
        '
        Me.ColPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColPrice.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ColPrice.AppearanceCell.Options.UseBackColor = True
        Me.ColPrice.AppearanceCell.Options.UseFont = True
        Me.ColPrice.AppearanceCell.Options.UseTextOptions = True
        Me.ColPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPrice.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPrice.AppearanceHeader.Options.UseFont = True
        Me.ColPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColPrice.Caption = "ราคาขาย"
        Me.ColPrice.DisplayFormat.FormatString = "N2"
        Me.ColPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPrice.FieldName = "Price"
        Me.ColPrice.MaxWidth = 80
        Me.ColPrice.MinWidth = 60
        Me.ColPrice.Name = "ColPrice"
        Me.ColPrice.OptionsColumn.AllowEdit = False
        Me.ColPrice.OptionsColumn.ReadOnly = True
        Me.ColPrice.Visible = True
        Me.ColPrice.VisibleIndex = 4
        Me.ColPrice.Width = 80
        '
        'ColTotalNet
        '
        Me.ColTotalNet.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTotalNet.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ColTotalNet.AppearanceCell.Options.UseBackColor = True
        Me.ColTotalNet.AppearanceCell.Options.UseFont = True
        Me.ColTotalNet.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotalNet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotalNet.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColTotalNet.AppearanceHeader.Options.UseFont = True
        Me.ColTotalNet.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTotalNet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTotalNet.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColTotalNet.Caption = "รวมเป็นเงิน"
        Me.ColTotalNet.DisplayFormat.FormatString = "N2"
        Me.ColTotalNet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotalNet.FieldName = "TotalNet"
        Me.ColTotalNet.MaxWidth = 160
        Me.ColTotalNet.MinWidth = 150
        Me.ColTotalNet.Name = "ColTotalNet"
        Me.ColTotalNet.OptionsColumn.AllowEdit = False
        Me.ColTotalNet.OptionsColumn.ReadOnly = True
        Me.ColTotalNet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalNet", "รวม = {0:N2}")})
        Me.ColTotalNet.Visible = True
        Me.ColTotalNet.VisibleIndex = 5
        Me.ColTotalNet.Width = 150
        '
        'rptbtnEditApv
        '
        Me.rptbtnEditApv.AutoHeight = False
        Me.rptbtnEditApv.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources._011_yes_128_16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptbtnEditApv.Name = "rptbtnEditApv"
        Me.rptbtnEditApv.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'rptChkEditApv
        '
        Me.rptChkEditApv.AutoHeight = False
        Me.rptChkEditApv.Name = "rptChkEditApv"
        '
        'frmPssSalePriceDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 551)
        Me.Controls.Add(Me.GCPrice)
        Me.Controls.Add(Me.PanelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPssSalePriceDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายละเอียดยอดขาย"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.GCPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptbtnEditApv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptChkEditApv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTag As System.Windows.Forms.Label
    Friend WithEvents GCPrice As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPrice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidProduct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalNet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptbtnEditApv As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptChkEditApv As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColidSaleDt As DevExpress.XtraGrid.Columns.GridColumn
End Class
