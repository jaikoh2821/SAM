<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLotSelect))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLotNo = New System.Windows.Forms.TextBox()
        Me.lblInvName = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GCLot = New DevExpress.XtraGrid.GridControl()
        Me.GVLot = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehouseName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptWh = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ColPdAge = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode_PO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidWh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompRec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInvName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColstCountStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnitW = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.GCLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptWh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.txtLotNo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(746, 33)
        Me.PanelControl1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(237, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ค้นหา Lot No."
        '
        'txtLotNo
        '
        Me.txtLotNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtLotNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLotNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotNo.Location = New System.Drawing.Point(334, 5)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Size = New System.Drawing.Size(171, 23)
        Me.txtLotNo.TabIndex = 5
        '
        'lblInvName
        '
        Me.lblInvName.BackColor = System.Drawing.Color.Transparent
        Me.lblInvName.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblInvName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvName.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblInvName.Location = New System.Drawing.Point(47, 0)
        Me.lblInvName.Name = "lblInvName"
        Me.lblInvName.Size = New System.Drawing.Size(504, 33)
        Me.lblInvName.TabIndex = 6
        Me.lblInvName.Text = "ชื่อสินค้า"
        Me.lblInvName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblInvName.Visible = False
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.lblInvName)
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Controls.Add(Me.Label2)
        Me.PanelControl3.Controls.Add(Me.Panel8)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 33)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(746, 33)
        Me.PanelControl3.TabIndex = 741
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Image = CType(resources.GetObject("LabelControl1.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(15, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 32)
        Me.LabelControl1.TabIndex = 613
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 33)
        Me.Label2.TabIndex = 614
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.txtCount)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(590, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(156, 33)
        Me.Panel8.TabIndex = 612
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(48, 5)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(60, 23)
        Me.txtCount.TabIndex = 610
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(110, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 14)
        Me.Label1.TabIndex = 596
        Me.Label1.Text = "รายการ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(4, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 14)
        Me.Label4.TabIndex = 594
        Me.Label4.Text = "จำนวน"
        '
        'GCLot
        '
        Me.GCLot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCLot.Location = New System.Drawing.Point(0, 66)
        Me.GCLot.MainView = Me.GVLot
        Me.GCLot.Name = "GCLot"
        Me.GCLot.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptSelect, Me.rptWh})
        Me.GCLot.Size = New System.Drawing.Size(746, 489)
        Me.GCLot.TabIndex = 742
        Me.GCLot.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVLot})
        '
        'GVLot
        '
        Me.GVLot.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVLot.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVLot.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVLot.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVLot.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVLot.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVLot.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVLot.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVLot.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVLot.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVLot.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVLot.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVLot.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVLot.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVLot.Appearance.Empty.Options.UseBackColor = True
        Me.GVLot.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GVLot.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVLot.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVLot.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVLot.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVLot.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVLot.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVLot.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVLot.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVLot.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVLot.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVLot.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVLot.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVLot.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVLot.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVLot.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVLot.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVLot.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVLot.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVLot.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVLot.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVLot.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVLot.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVLot.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVLot.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVLot.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVLot.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVLot.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVLot.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVLot.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVLot.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVLot.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVLot.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVLot.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVLot.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVLot.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVLot.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVLot.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVLot.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVLot.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVLot.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVLot.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVLot.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVLot.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVLot.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVLot.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVLot.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVLot.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVLot.Appearance.GroupRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GVLot.Appearance.GroupRow.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.GVLot.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GVLot.Appearance.GroupRow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVLot.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVLot.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVLot.Appearance.GroupRow.Options.UseFont = True
        Me.GVLot.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVLot.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVLot.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVLot.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVLot.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVLot.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVLot.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVLot.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVLot.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVLot.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVLot.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVLot.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVLot.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVLot.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVLot.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVLot.Appearance.OddRow.Options.UseBackColor = True
        Me.GVLot.Appearance.OddRow.Options.UseForeColor = True
        Me.GVLot.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GVLot.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVLot.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVLot.Appearance.Preview.Options.UseBackColor = True
        Me.GVLot.Appearance.Preview.Options.UseFont = True
        Me.GVLot.Appearance.Preview.Options.UseForeColor = True
        Me.GVLot.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVLot.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVLot.Appearance.Row.Options.UseBackColor = True
        Me.GVLot.Appearance.Row.Options.UseForeColor = True
        Me.GVLot.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVLot.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVLot.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVLot.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVLot.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVLot.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVLot.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVLot.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVLot.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVLot.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVLot.Appearance.VertLine.Options.UseBackColor = True
        Me.GVLot.ColumnPanelRowHeight = 35
        Me.GVLot.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSelect, Me.colLotNo, Me.colAmount, Me.ColAmtBal, Me.colUnitName, Me.colWarehouseName, Me.ColPdAge, Me.ColDocCode_PO, Me.ColidLot, Me.ColidWh, Me.colProductName, Me.CompRec, Me.ColInvName, Me.ColstCountStock, Me.ColWeight, Me.ColidUnitW})
        Me.GVLot.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVLot.GridControl = Me.GCLot
        Me.GVLot.GroupCount = 1
        Me.GVLot.GroupFormat = " [#image]{1} {2}"
        Me.GVLot.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", Nothing, "(คงเหลือ {0:#,##0.####})")})
        Me.GVLot.Name = "GVLot"
        Me.GVLot.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GVLot.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVLot.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVLot.OptionsView.EnableAppearanceEvenRow = True
        Me.GVLot.OptionsView.EnableAppearanceOddRow = True
        Me.GVLot.OptionsView.RowAutoHeight = True
        Me.GVLot.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVLot.OptionsView.ShowGroupPanel = False
        Me.GVLot.OptionsView.ShowIndicator = False
        Me.GVLot.PaintStyleName = "MixedXP"
        Me.GVLot.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        Me.GVLot.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colProductName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ColSelect
        '
        Me.ColSelect.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColSelect.AppearanceCell.Options.UseFont = True
        Me.ColSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColSelect.AppearanceHeader.Options.UseFont = True
        Me.ColSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSelect.Caption = "เลือก"
        Me.ColSelect.ColumnEdit = Me.rptSelect
        Me.ColSelect.MaxWidth = 45
        Me.ColSelect.MinWidth = 45
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.Visible = True
        Me.ColSelect.VisibleIndex = 0
        Me.ColSelect.Width = 64
        '
        'rptSelect
        '
        Me.rptSelect.AutoHeight = False
        Me.rptSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.arrow_modify_old_undo_icone_3957_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptSelect.Name = "rptSelect"
        Me.rptSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colLotNo
        '
        Me.colLotNo.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colLotNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colLotNo.AppearanceCell.Options.UseBackColor = True
        Me.colLotNo.AppearanceCell.Options.UseFont = True
        Me.colLotNo.AppearanceCell.Options.UseTextOptions = True
        Me.colLotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colLotNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colLotNo.AppearanceHeader.Options.UseFont = True
        Me.colLotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colLotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLotNo.Caption = "Lot No."
        Me.colLotNo.FieldName = "LotNo"
        Me.colLotNo.MinWidth = 40
        Me.colLotNo.Name = "colLotNo"
        Me.colLotNo.OptionsColumn.AllowEdit = False
        Me.colLotNo.OptionsColumn.ReadOnly = True
        Me.colLotNo.OptionsColumn.TabStop = False
        Me.colLotNo.Visible = True
        Me.colLotNo.VisibleIndex = 1
        Me.colLotNo.Width = 374
        '
        'colAmount
        '
        Me.colAmount.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAmount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colAmount.AppearanceCell.Options.UseBackColor = True
        Me.colAmount.AppearanceCell.Options.UseFont = True
        Me.colAmount.AppearanceCell.Options.UseTextOptions = True
        Me.colAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAmount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colAmount.AppearanceHeader.Options.UseFont = True
        Me.colAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAmount.Caption = "จน. คงเหลือในสต๊อก"
        Me.colAmount.DisplayFormat.FormatString = "#,##0.####"
        Me.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.MinWidth = 55
        Me.colAmount.Name = "colAmount"
        Me.colAmount.OptionsColumn.AllowEdit = False
        Me.colAmount.OptionsColumn.ReadOnly = True
        Me.colAmount.OptionsColumn.TabStop = False
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 2
        Me.colAmount.Width = 184
        '
        'ColAmtBal
        '
        Me.ColAmtBal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColAmtBal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmtBal.AppearanceCell.Options.UseBackColor = True
        Me.ColAmtBal.AppearanceCell.Options.UseFont = True
        Me.ColAmtBal.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtBal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtBal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmtBal.AppearanceHeader.Options.UseFont = True
        Me.ColAmtBal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtBal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmtBal.Caption = "จน. ที่ใช้ได้"
        Me.ColAmtBal.DisplayFormat.FormatString = "#,##0.####"
        Me.ColAmtBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmtBal.FieldName = "AmtStockBal"
        Me.ColAmtBal.MinWidth = 65
        Me.ColAmtBal.Name = "ColAmtBal"
        Me.ColAmtBal.OptionsColumn.AllowEdit = False
        Me.ColAmtBal.OptionsColumn.ReadOnly = True
        Me.ColAmtBal.Visible = True
        Me.ColAmtBal.VisibleIndex = 3
        Me.ColAmtBal.Width = 122
        '
        'colUnitName
        '
        Me.colUnitName.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colUnitName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colUnitName.AppearanceCell.Options.UseBackColor = True
        Me.colUnitName.AppearanceCell.Options.UseFont = True
        Me.colUnitName.AppearanceCell.Options.UseTextOptions = True
        Me.colUnitName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colUnitName.AppearanceHeader.Options.UseFont = True
        Me.colUnitName.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitName.Caption = "หน่วย"
        Me.colUnitName.FieldName = "UnitName"
        Me.colUnitName.MinWidth = 35
        Me.colUnitName.Name = "colUnitName"
        Me.colUnitName.OptionsColumn.AllowEdit = False
        Me.colUnitName.OptionsColumn.ReadOnly = True
        Me.colUnitName.OptionsColumn.TabStop = False
        Me.colUnitName.Visible = True
        Me.colUnitName.VisibleIndex = 4
        Me.colUnitName.Width = 128
        '
        'colWarehouseName
        '
        Me.colWarehouseName.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colWarehouseName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colWarehouseName.AppearanceCell.Options.UseBackColor = True
        Me.colWarehouseName.AppearanceCell.Options.UseFont = True
        Me.colWarehouseName.AppearanceCell.Options.UseTextOptions = True
        Me.colWarehouseName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colWarehouseName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colWarehouseName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWarehouseName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colWarehouseName.AppearanceHeader.Options.UseFont = True
        Me.colWarehouseName.AppearanceHeader.Options.UseTextOptions = True
        Me.colWarehouseName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWarehouseName.Caption = "คลังสินค้า"
        Me.colWarehouseName.ColumnEdit = Me.rptWh
        Me.colWarehouseName.FieldName = "full_lock"
        Me.colWarehouseName.MinWidth = 100
        Me.colWarehouseName.Name = "colWarehouseName"
        Me.colWarehouseName.OptionsColumn.AllowEdit = False
        Me.colWarehouseName.OptionsColumn.ReadOnly = True
        Me.colWarehouseName.OptionsColumn.TabStop = False
        Me.colWarehouseName.Visible = True
        Me.colWarehouseName.VisibleIndex = 5
        Me.colWarehouseName.Width = 433
        '
        'rptWh
        '
        Me.rptWh.Appearance.Options.UseTextOptions = True
        Me.rptWh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rptWh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.rptWh.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rptWh.Name = "rptWh"
        '
        'ColPdAge
        '
        Me.ColPdAge.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ColPdAge.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPdAge.AppearanceCell.Options.UseBackColor = True
        Me.ColPdAge.AppearanceCell.Options.UseFont = True
        Me.ColPdAge.AppearanceCell.Options.UseTextOptions = True
        Me.ColPdAge.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPdAge.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPdAge.AppearanceHeader.Options.UseFont = True
        Me.ColPdAge.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPdAge.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPdAge.Caption = "อายุสินค้า"
        Me.ColPdAge.FieldName = "PDAge"
        Me.ColPdAge.MinWidth = 65
        Me.ColPdAge.Name = "ColPdAge"
        Me.ColPdAge.OptionsColumn.AllowEdit = False
        Me.ColPdAge.OptionsColumn.ReadOnly = True
        Me.ColPdAge.OptionsColumn.TabStop = False
        Me.ColPdAge.Visible = True
        Me.ColPdAge.VisibleIndex = 6
        Me.ColPdAge.Width = 343
        '
        'ColDocCode_PO
        '
        Me.ColDocCode_PO.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ColDocCode_PO.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocCode_PO.AppearanceCell.Options.UseBackColor = True
        Me.ColDocCode_PO.AppearanceCell.Options.UseFont = True
        Me.ColDocCode_PO.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode_PO.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode_PO.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode_PO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode_PO.Caption = "ผลิตตาม PO"
        Me.ColDocCode_PO.FieldName = "DocCode_PO"
        Me.ColDocCode_PO.MinWidth = 85
        Me.ColDocCode_PO.Name = "ColDocCode_PO"
        Me.ColDocCode_PO.OptionsColumn.AllowEdit = False
        Me.ColDocCode_PO.OptionsColumn.ReadOnly = True
        Me.ColDocCode_PO.Width = 85
        '
        'ColidLot
        '
        Me.ColidLot.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidLot.AppearanceCell.Options.UseFont = True
        Me.ColidLot.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidLot.AppearanceHeader.Options.UseFont = True
        Me.ColidLot.AppearanceHeader.Options.UseTextOptions = True
        Me.ColidLot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidLot.Caption = "idLot"
        Me.ColidLot.FieldName = "idLot"
        Me.ColidLot.Name = "ColidLot"
        Me.ColidLot.OptionsColumn.AllowEdit = False
        Me.ColidLot.OptionsColumn.ReadOnly = True
        '
        'ColidWh
        '
        Me.ColidWh.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidWh.AppearanceCell.Options.UseFont = True
        Me.ColidWh.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidWh.AppearanceHeader.Options.UseFont = True
        Me.ColidWh.Caption = "idWh"
        Me.ColidWh.FieldName = "idWh"
        Me.ColidWh.Name = "ColidWh"
        '
        'colProductName
        '
        Me.colProductName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colProductName.AppearanceCell.Options.UseFont = True
        Me.colProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colProductName.AppearanceHeader.Options.UseFont = True
        Me.colProductName.Caption = "ชื่อสินค้า"
        Me.colProductName.FieldName = "InvNameShow"
        Me.colProductName.Name = "colProductName"
        Me.colProductName.OptionsColumn.TabStop = False
        Me.colProductName.Visible = True
        Me.colProductName.VisibleIndex = 5
        '
        'CompRec
        '
        Me.CompRec.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CompRec.AppearanceCell.Options.UseFont = True
        Me.CompRec.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CompRec.AppearanceHeader.Options.UseFont = True
        Me.CompRec.Caption = "CompRec"
        Me.CompRec.FieldName = "CompRec"
        Me.CompRec.Name = "CompRec"
        '
        'ColInvName
        '
        Me.ColInvName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColInvName.AppearanceCell.Options.UseFont = True
        Me.ColInvName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColInvName.AppearanceHeader.Options.UseFont = True
        Me.ColInvName.Caption = "InvName"
        Me.ColInvName.FieldName = "InvName"
        Me.ColInvName.Name = "ColInvName"
        '
        'ColstCountStock
        '
        Me.ColstCountStock.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColstCountStock.AppearanceCell.Options.UseFont = True
        Me.ColstCountStock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColstCountStock.AppearanceHeader.Options.UseFont = True
        Me.ColstCountStock.Caption = "stCountStock"
        Me.ColstCountStock.FieldName = "stCountStock"
        Me.ColstCountStock.Name = "ColstCountStock"
        '
        'ColWeight
        '
        Me.ColWeight.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColWeight.AppearanceCell.Options.UseFont = True
        Me.ColWeight.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColWeight.AppearanceHeader.Options.UseFont = True
        Me.ColWeight.Caption = "Weight"
        Me.ColWeight.FieldName = "Weight"
        Me.ColWeight.Name = "ColWeight"
        '
        'ColidUnitW
        '
        Me.ColidUnitW.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidUnitW.AppearanceCell.Options.UseFont = True
        Me.ColidUnitW.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidUnitW.AppearanceHeader.Options.UseFont = True
        Me.ColidUnitW.Caption = "idUnitW"
        Me.ColidUnitW.FieldName = "idUnitW"
        Me.ColidUnitW.Name = "ColidUnitW"
        '
        'frmLotSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(746, 555)
        Me.Controls.Add(Me.GCLot)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLotSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือก Lot สินค้า"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.GCLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptWh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtLotNo As System.Windows.Forms.TextBox
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GCLot As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVLot As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rptSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehouseName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents txtCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblInvName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidWh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompRec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColInvName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColstCountStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidUnitW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rptWh As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents ColPdAge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents ColAmtBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode_PO As DevExpress.XtraGrid.Columns.GridColumn
End Class
