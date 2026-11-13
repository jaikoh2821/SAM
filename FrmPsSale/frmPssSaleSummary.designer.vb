<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPssSaleSummary
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPssSaleSummary))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DGV_AllSale = New System.Windows.Forms.DataGridView()
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colidPsSale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPsSale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalNet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colratio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpE = New System.Windows.Forms.DateTimePicker()
        Me.dtpS = New System.Windows.Forms.DateTimePicker()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.rbMonth = New System.Windows.Forms.RadioButton()
        Me.rbYear = New System.Windows.Forms.RadioButton()
        Me.rbDay = New System.Windows.Forms.RadioButton()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbPackage = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbAmount = New System.Windows.Forms.RadioButton()
        Me.rbTotalNet = New System.Windows.Forms.RadioButton()
        Me.rbPdt = New System.Windows.Forms.RadioButton()
        Me.rbSeed = New System.Windows.Forms.RadioButton()
        Me.pbPsSale = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_ShowChart = New System.Windows.Forms.Button()
        Me.txt_numchart = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ChkOnlyPriceLow = New System.Windows.Forms.CheckBox()
        Me.cmbInvGroup = New System.Windows.Forms.ComboBox()
        Me.ChkNoPriceLow = New System.Windows.Forms.CheckBox()
        Me.rdbSelectType = New System.Windows.Forms.RadioButton()
        Me.rdbAllType = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbRatio = New System.Windows.Forms.RadioButton()
        Me.rbName = New System.Windows.Forms.RadioButton()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.GridSale = New DevExpress.XtraGrid.GridControl()
        Me.DGV_Sale = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_SeedName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_PdPkName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_TotalNet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptHyperLinkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.col_ratio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_Amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_PkUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_idPdT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_PdTName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_idPdPk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GvProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidCusDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidProduct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNumDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPdPkName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColShortName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSumThisYDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSumLastYDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_dtType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_monthSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCTemp = New DevExpress.XtraGrid.GridControl()
        Me.gvTemp = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel9 = New System.Windows.Forms.Panel()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_AllSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pbPsSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.GridSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Sale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptHyperLinkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Lavender
        ChartArea1.BackColor = System.Drawing.Color.Lavender
        ChartArea1.Name = "ChartArea1"
        ChartArea1.Position.Auto = False
        ChartArea1.Position.Height = 75.0!
        ChartArea1.Position.Width = 90.0!
        ChartArea1.Position.Y = 25.0!
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.MarkerSize = 7
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(410, 421)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'DGV_AllSale
        '
        Me.DGV_AllSale.AllowUserToAddRows = False
        Me.DGV_AllSale.AllowUserToResizeRows = False
        Me.DGV_AllSale.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_AllSale.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_AllSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_AllSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.colSelect, Me.colidPsSale, Me.colPsSale, Me.colTotalNet, Me.colratio})
        Me.DGV_AllSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_AllSale.Location = New System.Drawing.Point(0, 23)
        Me.DGV_AllSale.Name = "DGV_AllSale"
        Me.DGV_AllSale.ReadOnly = True
        Me.DGV_AllSale.RowHeadersVisible = False
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.DGV_AllSale.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_AllSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_AllSale.Size = New System.Drawing.Size(341, 424)
        Me.DGV_AllSale.TabIndex = 1
        '
        'colautonum
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        Me.colautonum.DefaultCellStyle = DataGridViewCellStyle2
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.ReadOnly = True
        Me.colautonum.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colautonum.Width = 40
        '
        'colSelect
        '
        Me.colSelect.HeaderText = "เลือก"
        Me.colSelect.Name = "colSelect"
        Me.colSelect.ReadOnly = True
        Me.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colSelect.Width = 40
        '
        'colidPsSale
        '
        Me.colidPsSale.DataPropertyName = "idPs"
        Me.colidPsSale.HeaderText = "idSale"
        Me.colidPsSale.Name = "colidPsSale"
        Me.colidPsSale.ReadOnly = True
        Me.colidPsSale.Visible = False
        '
        'colPsSale
        '
        Me.colPsSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPsSale.DataPropertyName = "PsName"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        Me.colPsSale.DefaultCellStyle = DataGridViewCellStyle3
        Me.colPsSale.HeaderText = "เจ้าหน้าที่ขาย"
        Me.colPsSale.Name = "colPsSale"
        Me.colPsSale.ReadOnly = True
        '
        'colTotalNet
        '
        Me.colTotalNet.DataPropertyName = "TotalNet"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Format = "#,##0.00"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.colTotalNet.DefaultCellStyle = DataGridViewCellStyle4
        Me.colTotalNet.HeaderText = "ยอดขายรวม"
        Me.colTotalNet.Name = "colTotalNet"
        Me.colTotalNet.ReadOnly = True
        Me.colTotalNet.Width = 90
        '
        'colratio
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        Me.colratio.DefaultCellStyle = DataGridViewCellStyle5
        Me.colratio.HeaderText = "สัดส่วน"
        Me.colratio.Name = "colratio"
        Me.colratio.ReadOnly = True
        Me.colratio.Width = 50
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.DimGray
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.Enabled = False
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(103, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(122, 32)
        Me.btnPrint.TabIndex = 401
        Me.btnPrint.Text = "พิมพ์เอกสาร"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.DimGray
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Image = Global.SAM.My.Resources.Resources.Doc281
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(0, 0)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(103, 32)
        Me.btnShow.TabIndex = 399
        Me.btnShow.Text = "แสดงข้อมูล"
        Me.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpE)
        Me.GroupBox1.Controls.Add(Me.dtpS)
        Me.GroupBox1.Controls.Add(Me.dtpMonth)
        Me.GroupBox1.Controls.Add(Me.rbMonth)
        Me.GroupBox1.Controls.Add(Me.rbYear)
        Me.GroupBox1.Controls.Add(Me.rbDay)
        Me.GroupBox1.Controls.Add(Me.dtpYear)
        Me.GroupBox1.Location = New System.Drawing.Point(100, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 122)
        Me.GroupBox1.TabIndex = 625
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เลือกช่วงข้อมูล"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "ถึง"
        '
        'dtpE
        '
        Me.dtpE.CustomFormat = "ddMMMMyyyy"
        Me.dtpE.Enabled = False
        Me.dtpE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpE.Location = New System.Drawing.Point(66, 46)
        Me.dtpE.Name = "dtpE"
        Me.dtpE.Size = New System.Drawing.Size(143, 20)
        Me.dtpE.TabIndex = 6
        '
        'dtpS
        '
        Me.dtpS.CustomFormat = "ddMMMMyyyy"
        Me.dtpS.Enabled = False
        Me.dtpS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpS.Location = New System.Drawing.Point(66, 21)
        Me.dtpS.Name = "dtpS"
        Me.dtpS.Size = New System.Drawing.Size(143, 20)
        Me.dtpS.TabIndex = 6
        '
        'dtpMonth
        '
        Me.dtpMonth.CustomFormat = "MMMM/yyyy"
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(66, 72)
        Me.dtpMonth.MinimumSize = New System.Drawing.Size(4, 20)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.ShowUpDown = True
        Me.dtpMonth.Size = New System.Drawing.Size(143, 20)
        Me.dtpMonth.TabIndex = 0
        '
        'rbMonth
        '
        Me.rbMonth.AutoSize = True
        Me.rbMonth.Checked = True
        Me.rbMonth.Location = New System.Drawing.Point(8, 72)
        Me.rbMonth.Name = "rbMonth"
        Me.rbMonth.Size = New System.Drawing.Size(60, 17)
        Me.rbMonth.TabIndex = 4
        Me.rbMonth.TabStop = True
        Me.rbMonth.Text = "เดือน : "
        Me.rbMonth.UseVisualStyleBackColor = True
        '
        'rbYear
        '
        Me.rbYear.AutoSize = True
        Me.rbYear.Location = New System.Drawing.Point(8, 96)
        Me.rbYear.Name = "rbYear"
        Me.rbYear.Size = New System.Drawing.Size(41, 17)
        Me.rbYear.TabIndex = 5
        Me.rbYear.Text = "ปี : "
        Me.rbYear.UseVisualStyleBackColor = True
        '
        'rbDay
        '
        Me.rbDay.AutoSize = True
        Me.rbDay.Location = New System.Drawing.Point(8, 24)
        Me.rbDay.Name = "rbDay"
        Me.rbDay.Size = New System.Drawing.Size(55, 17)
        Me.rbDay.TabIndex = 4
        Me.rbDay.Text = "วันที : "
        Me.rbDay.UseVisualStyleBackColor = True
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Enabled = False
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(66, 96)
        Me.dtpYear.MinimumSize = New System.Drawing.Size(4, 20)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(60, 20)
        Me.dtpYear.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(341, 23)
        Me.Panel2.TabIndex = 650
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ยอดขายรวมเจ้าหน้าที่ขาย"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(431, 24)
        Me.Panel3.TabIndex = 651
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(220, 0)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(168, 24)
        Me.txtSearch.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(168, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ค้นหา :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(8, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ยอดขายเจ้าหน้าที่ขาย"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbPackage)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.rbPdt)
        Me.GroupBox2.Controls.Add(Me.rbSeed)
        Me.GroupBox2.Location = New System.Drawing.Point(323, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 72)
        Me.GroupBox2.TabIndex = 652
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "แสดงยอดตาม"
        '
        'rdbPackage
        '
        Me.rdbPackage.AutoSize = True
        Me.rdbPackage.Location = New System.Drawing.Point(103, 18)
        Me.rdbPackage.Name = "rdbPackage"
        Me.rdbPackage.Size = New System.Drawing.Size(84, 17)
        Me.rdbPackage.TabIndex = 4
        Me.rdbPackage.Text = "ชื่อ Package"
        Me.rdbPackage.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbAmount)
        Me.GroupBox3.Controls.Add(Me.rbTotalNet)
        Me.GroupBox3.Location = New System.Drawing.Point(108, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(180, 46)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'rbAmount
        '
        Me.rbAmount.AutoSize = True
        Me.rbAmount.Enabled = False
        Me.rbAmount.Location = New System.Drawing.Point(93, 19)
        Me.rbAmount.Name = "rbAmount"
        Me.rbAmount.Size = New System.Drawing.Size(76, 17)
        Me.rbAmount.TabIndex = 2
        Me.rbAmount.TabStop = True
        Me.rbAmount.Text = "จำนวนขาย"
        Me.rbAmount.UseVisualStyleBackColor = True
        '
        'rbTotalNet
        '
        Me.rbTotalNet.AutoSize = True
        Me.rbTotalNet.Enabled = False
        Me.rbTotalNet.Location = New System.Drawing.Point(20, 19)
        Me.rbTotalNet.Name = "rbTotalNet"
        Me.rbTotalNet.Size = New System.Drawing.Size(63, 17)
        Me.rbTotalNet.TabIndex = 1
        Me.rbTotalNet.TabStop = True
        Me.rbTotalNet.Text = "ยอดขาย"
        Me.rbTotalNet.UseVisualStyleBackColor = True
        '
        'rbPdt
        '
        Me.rbPdt.AutoSize = True
        Me.rbPdt.Location = New System.Drawing.Point(18, 41)
        Me.rbPdt.Name = "rbPdt"
        Me.rbPdt.Size = New System.Drawing.Size(85, 17)
        Me.rbPdt.TabIndex = 1
        Me.rbPdt.Text = "ชื่อทางการค้า"
        Me.rbPdt.UseVisualStyleBackColor = True
        '
        'rbSeed
        '
        Me.rbSeed.AutoSize = True
        Me.rbSeed.Checked = True
        Me.rbSeed.Location = New System.Drawing.Point(18, 18)
        Me.rbSeed.Name = "rbSeed"
        Me.rbSeed.Size = New System.Drawing.Size(53, 17)
        Me.rbSeed.TabIndex = 0
        Me.rbSeed.TabStop = True
        Me.rbSeed.Text = "ชื่อพืช"
        Me.rbSeed.UseVisualStyleBackColor = True
        '
        'pbPsSale
        '
        Me.pbPsSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPsSale.ErrorImage = Global.SAM.My.Resources.Resources.User_male_icon
        Me.pbPsSale.Image = Global.SAM.My.Resources.Resources.User_male_icon
        Me.pbPsSale.InitialImage = Global.SAM.My.Resources.Resources.User_male_icon
        Me.pbPsSale.Location = New System.Drawing.Point(5, 15)
        Me.pbPsSale.Name = "pbPsSale"
        Me.pbPsSale.Size = New System.Drawing.Size(91, 104)
        Me.pbPsSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPsSale.TabIndex = 653
        Me.pbPsSale.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Chart1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 24)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(412, 423)
        Me.Panel4.TabIndex = 654
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel5.Controls.Add(Me.btn_ShowChart)
        Me.Panel5.Controls.Add(Me.txt_numchart)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(412, 24)
        Me.Panel5.TabIndex = 652
        '
        'btn_ShowChart
        '
        Me.btn_ShowChart.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_ShowChart.Enabled = False
        Me.btn_ShowChart.Location = New System.Drawing.Point(176, 0)
        Me.btn_ShowChart.Name = "btn_ShowChart"
        Me.btn_ShowChart.Size = New System.Drawing.Size(52, 24)
        Me.btn_ShowChart.TabIndex = 2
        Me.btn_ShowChart.Text = "Show"
        Me.btn_ShowChart.UseVisualStyleBackColor = True
        '
        'txt_numchart
        '
        Me.txt_numchart.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_numchart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_numchart.Location = New System.Drawing.Point(148, 0)
        Me.txt_numchart.Name = "txt_numchart"
        Me.txt_numchart.Size = New System.Drawing.Size(28, 22)
        Me.txt_numchart.TabIndex = 1
        Me.txt_numchart.Text = "5"
        Me.txt_numchart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "กราฟ  |  จำนวนข้อมูล"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.PanelControl2)
        Me.Panel7.Controls.Add(Me.Label23)
        Me.Panel7.Controls.Add(Me.cmbGroupComp)
        Me.Panel7.Controls.Add(Me.GroupBox5)
        Me.Panel7.Controls.Add(Me.pbPsSale)
        Me.Panel7.Controls.Add(Me.GroupBox1)
        Me.Panel7.Controls.Add(Me.GroupBox4)
        Me.Panel7.Controls.Add(Me.GroupBox2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1184, 165)
        Me.Panel7.TabIndex = 657
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnPrint)
        Me.PanelControl2.Controls.Add(Me.btnShow)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 133)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1184, 32)
        Me.PanelControl2.TabIndex = 776
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(325, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 13)
        Me.Label23.TabIndex = 774
        Me.Label23.Text = "ข้อมูลบริษัท"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(394, 22)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(222, 21)
        Me.cmbGroupComp.TabIndex = 775
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ChkOnlyPriceLow)
        Me.GroupBox5.Controls.Add(Me.cmbInvGroup)
        Me.GroupBox5.Controls.Add(Me.ChkNoPriceLow)
        Me.GroupBox5.Controls.Add(Me.rdbSelectType)
        Me.GroupBox5.Controls.Add(Me.rdbAllType)
        Me.GroupBox5.Location = New System.Drawing.Point(622, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(254, 122)
        Me.GroupBox5.TabIndex = 657
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ประเภทสินค้า"
        '
        'ChkOnlyPriceLow
        '
        Me.ChkOnlyPriceLow.AutoSize = True
        Me.ChkOnlyPriceLow.Location = New System.Drawing.Point(133, 94)
        Me.ChkOnlyPriceLow.Name = "ChkOnlyPriceLow"
        Me.ChkOnlyPriceLow.Size = New System.Drawing.Size(84, 17)
        Me.ChkOnlyPriceLow.TabIndex = 6
        Me.ChkOnlyPriceLow.Text = "สินค้าผักซอง"
        Me.ChkOnlyPriceLow.UseVisualStyleBackColor = True
        Me.ChkOnlyPriceLow.Visible = False
        '
        'cmbInvGroup
        '
        Me.cmbInvGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInvGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbInvGroup.FormattingEnabled = True
        Me.cmbInvGroup.Location = New System.Drawing.Point(38, 64)
        Me.cmbInvGroup.Name = "cmbInvGroup"
        Me.cmbInvGroup.Size = New System.Drawing.Size(201, 21)
        Me.cmbInvGroup.TabIndex = 972
        '
        'ChkNoPriceLow
        '
        Me.ChkNoPriceLow.AutoSize = True
        Me.ChkNoPriceLow.Location = New System.Drawing.Point(39, 94)
        Me.ChkNoPriceLow.Name = "ChkNoPriceLow"
        Me.ChkNoPriceLow.Size = New System.Drawing.Size(78, 17)
        Me.ChkNoPriceLow.TabIndex = 5
        Me.ChkNoPriceLow.Text = "สินค้าทั่วไป"
        Me.ChkNoPriceLow.UseVisualStyleBackColor = True
        Me.ChkNoPriceLow.Visible = False
        '
        'rdbSelectType
        '
        Me.rdbSelectType.AutoSize = True
        Me.rdbSelectType.Location = New System.Drawing.Point(18, 45)
        Me.rdbSelectType.Name = "rdbSelectType"
        Me.rdbSelectType.Size = New System.Drawing.Size(80, 17)
        Me.rdbSelectType.TabIndex = 4
        Me.rdbSelectType.Text = "ระบุประเภท"
        Me.rdbSelectType.UseVisualStyleBackColor = True
        '
        'rdbAllType
        '
        Me.rdbAllType.AutoSize = True
        Me.rdbAllType.Checked = True
        Me.rdbAllType.Location = New System.Drawing.Point(18, 19)
        Me.rdbAllType.Name = "rdbAllType"
        Me.rdbAllType.Size = New System.Drawing.Size(84, 17)
        Me.rdbAllType.TabIndex = 1
        Me.rdbAllType.TabStop = True
        Me.rdbAllType.Text = "สินค้าทั้งหมด"
        Me.rdbAllType.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbRatio)
        Me.GroupBox4.Controls.Add(Me.rbName)
        Me.GroupBox4.Location = New System.Drawing.Point(885, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(93, 122)
        Me.GroupBox4.TabIndex = 656
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "เรียงข้อมูลตาม"
        Me.GroupBox4.Visible = False
        '
        'rbRatio
        '
        Me.rbRatio.AutoSize = True
        Me.rbRatio.Checked = True
        Me.rbRatio.Location = New System.Drawing.Point(22, 63)
        Me.rbRatio.Name = "rbRatio"
        Me.rbRatio.Size = New System.Drawing.Size(58, 17)
        Me.rbRatio.TabIndex = 1
        Me.rbRatio.TabStop = True
        Me.rbRatio.Text = "สัดส่วน"
        Me.rbRatio.UseVisualStyleBackColor = True
        '
        'rbName
        '
        Me.rbName.AutoSize = True
        Me.rbName.Location = New System.Drawing.Point(22, 27)
        Me.rbName.Name = "rbName"
        Me.rbName.Size = New System.Drawing.Size(38, 17)
        Me.rbName.TabIndex = 0
        Me.rbName.Text = "ชื่อ"
        Me.rbName.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Controls.Add(Me.Panel10)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 165)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1184, 447)
        Me.Panel8.TabIndex = 658
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Panel4)
        Me.Panel11.Controls.Add(Me.Panel5)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(772, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(412, 447)
        Me.Panel11.TabIndex = 2
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.GridSale)
        Me.Panel10.Controls.Add(Me.GCTemp)
        Me.Panel10.Controls.Add(Me.Panel3)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(341, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(431, 447)
        Me.Panel10.TabIndex = 1
        '
        'GridSale
        '
        Me.GridSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSale.Location = New System.Drawing.Point(0, 24)
        Me.GridSale.MainView = Me.DGV_Sale
        Me.GridSale.Name = "GridSale"
        Me.GridSale.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptHyperLinkEdit})
        Me.GridSale.Size = New System.Drawing.Size(431, 423)
        Me.GridSale.TabIndex = 675
        Me.GridSale.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DGV_Sale, Me.GvProduct})
        '
        'DGV_Sale
        '
        Me.DGV_Sale.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DGV_Sale.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DGV_Sale.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_Sale.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.DGV_Sale.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DGV_Sale.Appearance.FocusedRow.Options.UseForeColor = True
        Me.DGV_Sale.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.DGV_Sale.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DGV_Sale.ColumnPanelRowHeight = 34
        Me.DGV_Sale.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColID, Me.col_SeedName, Me.col_PdPkName, Me.col_TotalNet, Me.col_ratio, Me.col_Amount, Me.col_PkUnitName, Me.col_idPdT, Me.col_PdTName, Me.col_idPdPk})
        Me.DGV_Sale.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.DGV_Sale.GridControl = Me.GridSale
        Me.DGV_Sale.IndicatorWidth = 35
        Me.DGV_Sale.Name = "DGV_Sale"
        Me.DGV_Sale.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.DGV_Sale.OptionsView.ShowGroupPanel = False
        '
        'ColID
        '
        Me.ColID.Caption = "ID"
        Me.ColID.FieldName = "ID"
        Me.ColID.Name = "ColID"
        '
        'col_SeedName
        '
        Me.col_SeedName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_SeedName.AppearanceCell.Options.UseBackColor = True
        Me.col_SeedName.AppearanceHeader.Options.UseFont = True
        Me.col_SeedName.Caption = "ชื่อพืช"
        Me.col_SeedName.FieldName = "Data"
        Me.col_SeedName.Name = "col_SeedName"
        Me.col_SeedName.OptionsColumn.AllowEdit = False
        Me.col_SeedName.OptionsColumn.ReadOnly = True
        Me.col_SeedName.Width = 230
        '
        'col_PdPkName
        '
        Me.col_PdPkName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_PdPkName.AppearanceCell.Options.UseBackColor = True
        Me.col_PdPkName.AppearanceCell.Options.UseTextOptions = True
        Me.col_PdPkName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_PdPkName.AppearanceHeader.Options.UseFont = True
        Me.col_PdPkName.AppearanceHeader.Options.UseTextOptions = True
        Me.col_PdPkName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_PdPkName.Caption = "ชื่อ Package"
        Me.col_PdPkName.FieldName = "Data"
        Me.col_PdPkName.Name = "col_PdPkName"
        Me.col_PdPkName.OptionsColumn.AllowEdit = False
        Me.col_PdPkName.OptionsColumn.ReadOnly = True
        Me.col_PdPkName.Visible = True
        Me.col_PdPkName.VisibleIndex = 0
        Me.col_PdPkName.Width = 230
        '
        'col_TotalNet
        '
        Me.col_TotalNet.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.col_TotalNet.AppearanceCell.Options.UseBackColor = True
        Me.col_TotalNet.AppearanceCell.Options.UseTextOptions = True
        Me.col_TotalNet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_TotalNet.AppearanceHeader.Options.UseFont = True
        Me.col_TotalNet.AppearanceHeader.Options.UseTextOptions = True
        Me.col_TotalNet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_TotalNet.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.col_TotalNet.Caption = "ยอดขาย"
        Me.col_TotalNet.ColumnEdit = Me.rptHyperLinkEdit
        Me.col_TotalNet.DisplayFormat.FormatString = "#,##0.00##"
        Me.col_TotalNet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_TotalNet.FieldName = "TotalNet"
        Me.col_TotalNet.MinWidth = 85
        Me.col_TotalNet.Name = "col_TotalNet"
        Me.col_TotalNet.Visible = True
        Me.col_TotalNet.VisibleIndex = 1
        Me.col_TotalNet.Width = 85
        '
        'rptHyperLinkEdit
        '
        Me.rptHyperLinkEdit.AutoHeight = False
        Me.rptHyperLinkEdit.Name = "rptHyperLinkEdit"
        '
        'col_ratio
        '
        Me.col_ratio.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_ratio.AppearanceCell.Options.UseBackColor = True
        Me.col_ratio.AppearanceCell.Options.UseTextOptions = True
        Me.col_ratio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_ratio.AppearanceHeader.Options.UseFont = True
        Me.col_ratio.AppearanceHeader.Options.UseTextOptions = True
        Me.col_ratio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_ratio.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.col_ratio.Caption = "สัดส่วน"
        Me.col_ratio.FieldName = "ratio"
        Me.col_ratio.MinWidth = 50
        Me.col_ratio.Name = "col_ratio"
        Me.col_ratio.OptionsColumn.AllowEdit = False
        Me.col_ratio.Visible = True
        Me.col_ratio.VisibleIndex = 2
        Me.col_ratio.Width = 60
        '
        'col_Amount
        '
        Me.col_Amount.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_Amount.AppearanceCell.Options.UseBackColor = True
        Me.col_Amount.AppearanceHeader.Options.UseFont = True
        Me.col_Amount.AppearanceHeader.Options.UseTextOptions = True
        Me.col_Amount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_Amount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.col_Amount.Caption = "จำนวนขาย"
        Me.col_Amount.ColumnEdit = Me.rptHyperLinkEdit
        Me.col_Amount.DisplayFormat.FormatString = "#,##0.00##"
        Me.col_Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_Amount.FieldName = "Amount"
        Me.col_Amount.MinWidth = 65
        Me.col_Amount.Name = "col_Amount"
        Me.col_Amount.Width = 80
        '
        'col_PkUnitName
        '
        Me.col_PkUnitName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_PkUnitName.AppearanceCell.Options.UseBackColor = True
        Me.col_PkUnitName.AppearanceCell.Options.UseTextOptions = True
        Me.col_PkUnitName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_PkUnitName.AppearanceHeader.Options.UseFont = True
        Me.col_PkUnitName.Caption = "หน่วย"
        Me.col_PkUnitName.FieldName = "PkUnitName"
        Me.col_PkUnitName.MinWidth = 50
        Me.col_PkUnitName.Name = "col_PkUnitName"
        Me.col_PkUnitName.OptionsColumn.AllowEdit = False
        Me.col_PkUnitName.Width = 55
        '
        'col_idPdT
        '
        Me.col_idPdT.AppearanceHeader.Options.UseFont = True
        Me.col_idPdT.Caption = "idPdT"
        Me.col_idPdT.Name = "col_idPdT"
        Me.col_idPdT.Width = 152
        '
        'col_PdTName
        '
        Me.col_PdTName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_PdTName.AppearanceCell.Options.UseBackColor = True
        Me.col_PdTName.AppearanceHeader.Options.UseFont = True
        Me.col_PdTName.Caption = "ชื่อสินค้า"
        Me.col_PdTName.FieldName = "Data"
        Me.col_PdTName.Name = "col_PdTName"
        Me.col_PdTName.OptionsColumn.AllowEdit = False
        Me.col_PdTName.OptionsColumn.ReadOnly = True
        Me.col_PdTName.Width = 230
        '
        'col_idPdPk
        '
        Me.col_idPdPk.AppearanceHeader.Options.UseFont = True
        Me.col_idPdPk.Caption = "idPdPk"
        Me.col_idPdPk.Name = "col_idPdPk"
        Me.col_idPdPk.Width = 139
        '
        'GvProduct
        '
        Me.GvProduct.Appearance.FocusedCell.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GvProduct.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GvProduct.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvProduct.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvProduct.Appearance.FocusedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GvProduct.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvProduct.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvProduct.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvProduct.Appearance.HeaderPanel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GvProduct.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GvProduct.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvProduct.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvProduct.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GvProduct.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GvProduct.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidCusDt, Me.ColidProduct, Me.ColNumDt, Me.ColPdPkName, Me.ColShortName, Me.ColSumThisYDt, Me.ColSumLastYDt, Me.col_dtType, Me.col_monthSale})
        Me.GvProduct.DetailHeight = 600
        Me.GvProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GvProduct.GridControl = Me.GridSale
        Me.GvProduct.Name = "GvProduct"
        Me.GvProduct.OptionsView.ColumnAutoWidth = False
        Me.GvProduct.OptionsView.ShowGroupPanel = False
        Me.GvProduct.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.GvProduct.OptionsView.ShowIndicator = False
        Me.GvProduct.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ColSumThisYDt, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'ColidCusDt
        '
        Me.ColidCusDt.Caption = "idCus"
        Me.ColidCusDt.FieldName = "idCus"
        Me.ColidCusDt.Name = "ColidCusDt"
        Me.ColidCusDt.Width = 40
        '
        'ColidProduct
        '
        Me.ColidProduct.Caption = "idProduct"
        Me.ColidProduct.FieldName = "idProduct"
        Me.ColidProduct.Name = "ColidProduct"
        '
        'ColNumDt
        '
        Me.ColNumDt.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNumDt.AppearanceCell.Options.UseBackColor = True
        Me.ColNumDt.AppearanceCell.Options.UseTextOptions = True
        Me.ColNumDt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNumDt.Caption = "ลำดับ"
        Me.ColNumDt.Name = "ColNumDt"
        Me.ColNumDt.OptionsColumn.AllowEdit = False
        Me.ColNumDt.OptionsColumn.ReadOnly = True
        Me.ColNumDt.Visible = True
        Me.ColNumDt.VisibleIndex = 0
        Me.ColNumDt.Width = 70
        '
        'ColPdPkName
        '
        Me.ColPdPkName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPdPkName.AppearanceCell.Options.UseBackColor = True
        Me.ColPdPkName.Caption = "ชื่อสินค้า"
        Me.ColPdPkName.FieldName = "PdPkName"
        Me.ColPdPkName.Name = "ColPdPkName"
        Me.ColPdPkName.OptionsColumn.AllowEdit = False
        Me.ColPdPkName.OptionsColumn.ReadOnly = True
        Me.ColPdPkName.Visible = True
        Me.ColPdPkName.VisibleIndex = 1
        Me.ColPdPkName.Width = 419
        '
        'ColShortName
        '
        Me.ColShortName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColShortName.AppearanceCell.Options.UseBackColor = True
        Me.ColShortName.AppearanceCell.Options.UseTextOptions = True
        Me.ColShortName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColShortName.Caption = "ชื่อย่อ"
        Me.ColShortName.FieldName = "ShortName"
        Me.ColShortName.Name = "ColShortName"
        Me.ColShortName.OptionsColumn.AllowEdit = False
        Me.ColShortName.OptionsColumn.ReadOnly = True
        Me.ColShortName.Visible = True
        Me.ColShortName.VisibleIndex = 2
        Me.ColShortName.Width = 70
        '
        'ColSumThisYDt
        '
        Me.ColSumThisYDt.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColSumThisYDt.AppearanceCell.Options.UseBackColor = True
        Me.ColSumThisYDt.AppearanceCell.Options.UseTextOptions = True
        Me.ColSumThisYDt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColSumThisYDt.Caption = "ยอดขายปีปัจจุบัน"
        Me.ColSumThisYDt.DisplayFormat.FormatString = "N2"
        Me.ColSumThisYDt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSumThisYDt.FieldName = "SumThisY"
        Me.ColSumThisYDt.Name = "ColSumThisYDt"
        Me.ColSumThisYDt.OptionsColumn.AllowFocus = False
        Me.ColSumThisYDt.OptionsColumn.ReadOnly = True
        Me.ColSumThisYDt.Visible = True
        Me.ColSumThisYDt.VisibleIndex = 3
        Me.ColSumThisYDt.Width = 185
        '
        'ColSumLastYDt
        '
        Me.ColSumLastYDt.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColSumLastYDt.AppearanceCell.Options.UseBackColor = True
        Me.ColSumLastYDt.AppearanceCell.Options.UseTextOptions = True
        Me.ColSumLastYDt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColSumLastYDt.Caption = "ยอดขายปีที่แล้ว"
        Me.ColSumLastYDt.DisplayFormat.FormatString = "N2"
        Me.ColSumLastYDt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSumLastYDt.FieldName = "SumLastY"
        Me.ColSumLastYDt.Name = "ColSumLastYDt"
        Me.ColSumLastYDt.OptionsColumn.AllowEdit = False
        Me.ColSumLastYDt.OptionsColumn.ReadOnly = True
        Me.ColSumLastYDt.Visible = True
        Me.ColSumLastYDt.VisibleIndex = 4
        Me.ColSumLastYDt.Width = 185
        '
        'col_dtType
        '
        Me.col_dtType.Caption = "ประเภทสินค้า"
        Me.col_dtType.FieldName = "dtType"
        Me.col_dtType.Name = "col_dtType"
        '
        'col_monthSale
        '
        Me.col_monthSale.Caption = "col_monthSale"
        Me.col_monthSale.FieldName = "monthSale"
        Me.col_monthSale.Name = "col_monthSale"
        '
        'GCTemp
        '
        Me.GCTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCTemp.Location = New System.Drawing.Point(0, 24)
        Me.GCTemp.MainView = Me.gvTemp
        Me.GCTemp.Name = "GCTemp"
        Me.GCTemp.Size = New System.Drawing.Size(431, 423)
        Me.GCTemp.TabIndex = 674
        Me.GCTemp.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTemp, Me.GridView2})
        '
        'gvTemp
        '
        Me.gvTemp.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.gvTemp.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvTemp.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvTemp.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvTemp.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvTemp.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvTemp.ColumnPanelRowHeight = 45
        Me.gvTemp.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.gvTemp.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvTemp.GridControl = Me.GCTemp
        Me.gvTemp.IndicatorWidth = 35
        Me.gvTemp.Name = "gvTemp"
        Me.gvTemp.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvTemp.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvTemp.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "idSeed"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.Caption = "ชื่อพืช"
        Me.GridColumn2.FieldName = "Data"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Width = 210
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "ชื่อ Package"
        Me.GridColumn3.FieldName = "Data"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 210
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn4.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn4.Caption = "ยอดขาย"
        Me.GridColumn4.DisplayFormat.FormatString = "###,###.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn4.FieldName = "TotalNet"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 85
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn5.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn5.Caption = "สัดส่วน"
        Me.GridColumn5.FieldName = "ratio"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 71
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn6.Caption = "จำนวนขาย"
        Me.GridColumn6.FieldName = "Amount"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Width = 66
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn7.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.Caption = "หน่วย"
        Me.GridColumn7.FieldName = "PkUnitName"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Width = 65
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.Options.UseFont = True
        Me.GridColumn8.Caption = "idPdT"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Width = 152
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Options.UseFont = True
        Me.GridColumn9.Caption = "ชื่อสินค้า"
        Me.GridColumn9.FieldName = "Data"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Width = 210
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Options.UseFont = True
        Me.GridColumn10.Caption = "idPdPk"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Width = 139
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19})
        Me.GridView2.DetailHeight = 600
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GCTemp
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsView.ShowIndicator = False
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn16, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "idCus"
        Me.GridColumn11.FieldName = "idCus"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Width = 40
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "idProduct"
        Me.GridColumn12.FieldName = "idProduct"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn13.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn13.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.Caption = "ลำดับ"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 70
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn14.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn14.Caption = "ชื่อสินค้า"
        Me.GridColumn14.FieldName = "PdPkName"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        Me.GridColumn14.Width = 419
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn15.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn15.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.Caption = "ชื่อย่อ"
        Me.GridColumn15.FieldName = "ShortName"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 2
        Me.GridColumn15.Width = 70
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn16.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn16.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn16.Caption = "ยอดขายปีปัจจุบัน"
        Me.GridColumn16.DisplayFormat.FormatString = "N2"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn16.FieldName = "SumThisY"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowFocus = False
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 3
        Me.GridColumn16.Width = 185
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn17.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn17.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn17.Caption = "ยอดขายปีที่แล้ว"
        Me.GridColumn17.DisplayFormat.FormatString = "N2"
        Me.GridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn17.FieldName = "SumLastY"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 4
        Me.GridColumn17.Width = 185
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "ประเภทสินค้า"
        Me.GridColumn18.FieldName = "dtType"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "col_monthSale"
        Me.GridColumn19.FieldName = "monthSale"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.DGV_AllSale)
        Me.Panel9.Controls.Add(Me.Panel2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(341, 447)
        Me.Panel9.TabIndex = 0
        '
        'frmPssSaleSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1184, 612)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPssSaleSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สรุปสัดส่วนยอดขายของเจ้าหน้าที่ขาย"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_AllSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pbPsSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.GridSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Sale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptHyperLinkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents DGV_AllSale As System.Windows.Forms.DataGridView
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbYear As System.Windows.Forms.RadioButton
    Friend WithEvents rbMonth As System.Windows.Forms.RadioButton
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPdt As System.Windows.Forms.RadioButton
    Friend WithEvents rbSeed As System.Windows.Forms.RadioButton
    Friend WithEvents pbPsSale As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_numchart As System.Windows.Forms.TextBox
    Friend WithEvents btn_ShowChart As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpS As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbDay As System.Windows.Forms.RadioButton
    Friend WithEvents dtpE As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAmount As System.Windows.Forms.RadioButton
    Friend WithEvents rbTotalNet As System.Windows.Forms.RadioButton
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbSelectType As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAllType As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPackage As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbRatio As System.Windows.Forms.RadioButton
    Friend WithEvents rbName As System.Windows.Forms.RadioButton
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GCTemp As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTemp As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridSale As DevExpress.XtraGrid.GridControl
    Friend WithEvents DGV_Sale As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_SeedName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_PdPkName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_TotalNet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_ratio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_Amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_PkUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_idPdT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_PdTName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_idPdPk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GvProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidCusDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidProduct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNumDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPdPkName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColShortName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSumThisYDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSumLastYDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_dtType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_monthSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colidPsSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotalNet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colratio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents rptHyperLinkEdit As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents cmbInvGroup As System.Windows.Forms.ComboBox
    Friend WithEvents ChkOnlyPriceLow As System.Windows.Forms.CheckBox
    Friend WithEvents ChkNoPriceLow As System.Windows.Forms.CheckBox
End Class
