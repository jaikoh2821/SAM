<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSlSaleGroupDt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSlSaleGroupDt))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpGroupBill = New System.Windows.Forms.DateTimePicker()
        Me.btnCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.lblPartnerName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSelDoc = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.GCSaleSH = New DevExpress.XtraGrid.GridControl()
        Me.GVSaleSH = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCusName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotalNet1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColBathText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPricePerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColidPartner = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVSaleDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidSaleMt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDiscountBath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColExp = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GCSaleSH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSaleSH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSaleDt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.txtNote)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.dtpGroupBill)
        Me.PanelControl1.Controls.Add(Me.btnCustomer)
        Me.PanelControl1.Controls.Add(Me.lblPartnerName)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.cmbGroupComp)
        Me.PanelControl1.Controls.Add(Me.Label28)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(984, 76)
        Me.PanelControl1.TabIndex = 725
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 14)
        Me.Label3.TabIndex = 977
        Me.Label3.Text = "ใบแจ้งหนี้"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(577, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 976
        Me.Label2.Text = "หมายเหตุ"
        '
        'txtNote
        '
        Me.txtNote.Enabled = False
        Me.txtNote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(637, 11)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(183, 51)
        Me.txtNote.TabIndex = 975
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 14)
        Me.Label1.TabIndex = 974
        Me.Label1.Text = "วันที่รวบรวม"
        '
        'dtpGroupBill
        '
        Me.dtpGroupBill.CustomFormat = "ddMMMMyyyy"
        Me.dtpGroupBill.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpGroupBill.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpGroupBill.Location = New System.Drawing.Point(84, 40)
        Me.dtpGroupBill.Name = "dtpGroupBill"
        Me.dtpGroupBill.Size = New System.Drawing.Size(174, 22)
        Me.dtpGroupBill.TabIndex = 973
        '
        'btnCustomer
        '
        Me.btnCustomer.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCustomer.Appearance.Options.UseFont = True
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCustomer.Location = New System.Drawing.Point(518, 11)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(25, 22)
        Me.btnCustomer.TabIndex = 970
        '
        'lblPartnerName
        '
        Me.lblPartnerName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPartnerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPartnerName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPartnerName.Location = New System.Drawing.Point(331, 12)
        Me.lblPartnerName.Name = "lblPartnerName"
        Me.lblPartnerName.Size = New System.Drawing.Size(185, 50)
        Me.lblPartnerName.TabIndex = 972
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(292, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 14)
        Me.Label6.TabIndex = 971
        Me.Label6.Text = "ลูกค้า"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(84, 12)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(174, 22)
        Me.cmbGroupComp.TabIndex = 968
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label28.Location = New System.Drawing.Point(40, 15)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(38, 14)
        Me.Label28.TabIndex = 969
        Me.Label28.Text = "บริษัท"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 35)
        Me.Panel1.TabIndex = 726
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSelDoc)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(97, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(140, 35)
        Me.Panel3.TabIndex = 589
        '
        'btnSelDoc
        '
        Me.btnSelDoc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelDoc.Appearance.Options.UseFont = True
        Me.btnSelDoc.Image = CType(resources.GetObject("btnSelDoc.Image"), System.Drawing.Image)
        Me.btnSelDoc.Location = New System.Drawing.Point(2, 2)
        Me.btnSelDoc.Name = "btnSelDoc"
        Me.btnSelDoc.Size = New System.Drawing.Size(134, 30)
        Me.btnSelDoc.TabIndex = 1
        Me.btnSelDoc.Text = "เลือกใบแจ้งหนี้"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(97, 35)
        Me.Panel2.TabIndex = 588
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 30)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "บันทึก"
        '
        'GCSaleSH
        '
        Me.GCSaleSH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSaleSH.Location = New System.Drawing.Point(0, 111)
        Me.GCSaleSH.MainView = Me.GVSaleSH
        Me.GCSaleSH.Name = "GCSaleSH"
        Me.GCSaleSH.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptDel})
        Me.GCSaleSH.Size = New System.Drawing.Size(984, 540)
        Me.GCSaleSH.TabIndex = 727
        Me.GCSaleSH.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSaleSH, Me.GVSaleDt})
        '
        'GVSaleSH
        '
        Me.GVSaleSH.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleSH.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleSH.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleSH.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleSH.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleSH.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSaleSH.Appearance.Empty.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSaleSH.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSaleSH.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleSH.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleSH.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleSH.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleSH.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleSH.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleSH.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleSH.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleSH.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleSH.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVSaleSH.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.FooterPanel.Options.UseFont = True
        Me.GVSaleSH.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSaleSH.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSaleSH.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleSH.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleSH.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVSaleSH.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.GroupFooter.Options.UseFont = True
        Me.GVSaleSH.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleSH.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleSH.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleSH.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleSH.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleSH.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleSH.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleSH.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSaleSH.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleSH.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleSH.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleSH.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSaleSH.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSaleSH.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSaleSH.Appearance.Preview.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.Preview.Options.UseFont = True
        Me.GVSaleSH.Appearance.Preview.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleSH.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.Row.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.Row.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleSH.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSaleSH.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVSaleSH.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSaleSH.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSaleSH.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleSH.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVSaleSH.ColumnPanelRowHeight = 35
        Me.GVSaleSH.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColidSale, Me.ColDocRef, Me.ColDateSale, Me.ColCusName, Me.ColTotalNet1, Me.ColBathText, Me.ColPricePerUnit, Me.ColTotal, Me.ColDel, Me.ColidPartner})
        Me.GVSaleSH.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        GridFormatRule1.Name = "stWaitCut"
        FormatConditionRuleExpression1.Expression = "[stWaitCut] = 'Draft'"
        FormatConditionRuleExpression1.PredefinedName = "Red Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        Me.GVSaleSH.FormatRules.Add(GridFormatRule1)
        Me.GVSaleSH.GridControl = Me.GCSaleSH
        Me.GVSaleSH.Name = "GVSaleSH"
        Me.GVSaleSH.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSaleSH.OptionsView.EnableAppearanceOddRow = True
        Me.GVSaleSH.OptionsView.RowAutoHeight = True
        Me.GVSaleSH.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSaleSH.OptionsView.ShowFooter = True
        Me.GVSaleSH.OptionsView.ShowGroupPanel = False
        Me.GVSaleSH.OptionsView.ShowIndicator = False
        Me.GVSaleSH.RowHeight = 25
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.ColNum.MinWidth = 45
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 105
        '
        'ColidSale
        '
        Me.ColidSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidSale.AppearanceCell.Options.UseFont = True
        Me.ColidSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidSale.AppearanceHeader.Options.UseFont = True
        Me.ColidSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColidSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidSale.Caption = "idSale"
        Me.ColidSale.FieldName = "idSale"
        Me.ColidSale.Name = "ColidSale"
        '
        'ColDocRef
        '
        Me.ColDocRef.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocRef.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocRef.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRef.AppearanceCell.Options.UseFont = True
        Me.ColDocRef.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocRef.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.Caption = "เลขที่ใบแจ้งหนี้"
        Me.ColDocRef.FieldName = "DocRef"
        Me.ColDocRef.Name = "ColDocRef"
        Me.ColDocRef.OptionsColumn.AllowEdit = False
        Me.ColDocRef.OptionsColumn.ReadOnly = True
        Me.ColDocRef.Visible = True
        Me.ColDocRef.VisibleIndex = 1
        Me.ColDocRef.Width = 198
        '
        'ColDateSale
        '
        Me.ColDateSale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateSale.AppearanceCell.Options.UseBackColor = True
        Me.ColDateSale.AppearanceCell.Options.UseFont = True
        Me.ColDateSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateSale.AppearanceHeader.Options.UseFont = True
        Me.ColDateSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale.Caption = "วันที่เอกสารแจ้งหนี้"
        Me.ColDateSale.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateSale.FieldName = "DateSaleD"
        Me.ColDateSale.Name = "ColDateSale"
        Me.ColDateSale.OptionsColumn.AllowEdit = False
        Me.ColDateSale.OptionsColumn.ReadOnly = True
        Me.ColDateSale.Visible = True
        Me.ColDateSale.VisibleIndex = 2
        Me.ColDateSale.Width = 197
        '
        'ColCusName
        '
        Me.ColCusName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColCusName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCusName.AppearanceCell.Options.UseBackColor = True
        Me.ColCusName.AppearanceCell.Options.UseFont = True
        Me.ColCusName.AppearanceCell.Options.UseTextOptions = True
        Me.ColCusName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColCusName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCusName.AppearanceHeader.Options.UseFont = True
        Me.ColCusName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCusName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCusName.Caption = "รายละเอียด"
        Me.ColCusName.CustomizationCaption = " "
        Me.ColCusName.FieldName = "PartnerNameBill"
        Me.ColCusName.Name = "ColCusName"
        Me.ColCusName.OptionsColumn.AllowEdit = False
        Me.ColCusName.OptionsColumn.ReadOnly = True
        Me.ColCusName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "PartnerNameBill", "จำนวนเงินรวมทั้งสิ้น")})
        Me.ColCusName.Visible = True
        Me.ColCusName.VisibleIndex = 3
        Me.ColCusName.Width = 646
        '
        'ColTotalNet1
        '
        Me.ColTotalNet1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTotalNet1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTotalNet1.AppearanceCell.Options.UseBackColor = True
        Me.ColTotalNet1.AppearanceCell.Options.UseFont = True
        Me.ColTotalNet1.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotalNet1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotalNet1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTotalNet1.AppearanceHeader.Options.UseFont = True
        Me.ColTotalNet1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTotalNet1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTotalNet1.Caption = "จำนวนเงิน"
        Me.ColTotalNet1.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColTotalNet1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotalNet1.FieldName = "TotalNet"
        Me.ColTotalNet1.Name = "ColTotalNet1"
        Me.ColTotalNet1.OptionsColumn.AllowEdit = False
        Me.ColTotalNet1.OptionsColumn.ReadOnly = True
        Me.ColTotalNet1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalNet", "{0:#,##0.00##}")})
        Me.ColTotalNet1.Visible = True
        Me.ColTotalNet1.VisibleIndex = 4
        Me.ColTotalNet1.Width = 302
        '
        'ColBathText
        '
        Me.ColBathText.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColBathText.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColBathText.AppearanceCell.Options.UseBackColor = True
        Me.ColBathText.AppearanceCell.Options.UseFont = True
        Me.ColBathText.AppearanceCell.Options.UseTextOptions = True
        Me.ColBathText.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColBathText.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColBathText.AppearanceHeader.Options.UseFont = True
        Me.ColBathText.AppearanceHeader.Options.UseTextOptions = True
        Me.ColBathText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColBathText.Caption = "หน่วย"
        Me.ColBathText.FieldName = "BathText"
        Me.ColBathText.Name = "ColBathText"
        Me.ColBathText.OptionsColumn.AllowEdit = False
        Me.ColBathText.OptionsColumn.ReadOnly = True
        Me.ColBathText.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "BathText", "บาท")})
        Me.ColBathText.Visible = True
        Me.ColBathText.VisibleIndex = 5
        Me.ColBathText.Width = 165
        '
        'ColPricePerUnit
        '
        Me.ColPricePerUnit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPricePerUnit.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPricePerUnit.AppearanceCell.Options.UseBackColor = True
        Me.ColPricePerUnit.AppearanceCell.Options.UseFont = True
        Me.ColPricePerUnit.AppearanceCell.Options.UseTextOptions = True
        Me.ColPricePerUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPricePerUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPricePerUnit.AppearanceHeader.Options.UseFont = True
        Me.ColPricePerUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPricePerUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPricePerUnit.Caption = "ราคาต่อหน่วย"
        Me.ColPricePerUnit.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPricePerUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPricePerUnit.Name = "ColPricePerUnit"
        Me.ColPricePerUnit.OptionsColumn.AllowEdit = False
        Me.ColPricePerUnit.OptionsColumn.ReadOnly = True
        '
        'ColTotal
        '
        Me.ColTotal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTotal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTotal.AppearanceCell.Options.UseBackColor = True
        Me.ColTotal.AppearanceCell.Options.UseFont = True
        Me.ColTotal.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTotal.AppearanceHeader.Options.UseFont = True
        Me.ColTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTotal.Caption = "รวมจำนวนเงิน"
        Me.ColTotal.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotal.Name = "ColTotal"
        Me.ColTotal.OptionsColumn.AllowEdit = False
        Me.ColTotal.OptionsColumn.ReadOnly = True
        '
        'ColDel
        '
        Me.ColDel.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDel.AppearanceCell.Options.UseBackColor = True
        Me.ColDel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDel.AppearanceHeader.Options.UseFont = True
        Me.ColDel.Caption = "ลบ"
        Me.ColDel.ColumnEdit = Me.rptDel
        Me.ColDel.MaxWidth = 35
        Me.ColDel.MinWidth = 35
        Me.ColDel.Name = "ColDel"
        Me.ColDel.Visible = True
        Me.ColDel.VisibleIndex = 6
        Me.ColDel.Width = 35
        '
        'rptDel
        '
        Me.rptDel.AutoHeight = False
        Me.rptDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptDel.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptDel.Name = "rptDel"
        Me.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColidPartner
        '
        Me.ColidPartner.Caption = "idPartner"
        Me.ColidPartner.FieldName = "idPartnerBill"
        Me.ColidPartner.Name = "ColidPartner"
        '
        'GVSaleDt
        '
        Me.GVSaleDt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleDt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleDt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.Empty.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSaleDt.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSaleDt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleDt.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleDt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleDt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVSaleDt.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleDt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleDt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleDt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleDt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSaleDt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSaleDt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSaleDt.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleDt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSaleDt.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSaleDt.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSaleDt.Appearance.Preview.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.Preview.Options.UseFont = True
        Me.GVSaleDt.Appearance.Preview.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.Row.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.Row.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVSaleDt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSaleDt.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleDt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVSaleDt.ColumnPanelRowHeight = 25
        Me.GVSaleDt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidSaleMt, Me.ColProductName, Me.ColAmount, Me.ColUnit, Me.ColDiscount, Me.ColDiscountBath, Me.ColPrice, Me.ColExp})
        Me.GVSaleDt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVSaleDt.GridControl = Me.GCSaleSH
        Me.GVSaleDt.Name = "GVSaleDt"
        Me.GVSaleDt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSaleDt.OptionsView.EnableAppearanceOddRow = True
        Me.GVSaleDt.OptionsView.ShowGroupPanel = False
        Me.GVSaleDt.OptionsView.ShowIndicator = False
        Me.GVSaleDt.PaintStyleName = "MixedXP"
        Me.GVSaleDt.RowHeight = 25
        '
        'ColidSaleMt
        '
        Me.ColidSaleMt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidSaleMt.AppearanceCell.Options.UseFont = True
        Me.ColidSaleMt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidSaleMt.AppearanceHeader.Options.UseFont = True
        Me.ColidSaleMt.Caption = "idSaleDt"
        Me.ColidSaleMt.FieldName = "idSale"
        Me.ColidSaleMt.Name = "ColidSaleMt"
        '
        'ColProductName
        '
        Me.ColProductName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColProductName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColProductName.AppearanceCell.Options.UseBackColor = True
        Me.ColProductName.AppearanceCell.Options.UseFont = True
        Me.ColProductName.AppearanceCell.Options.UseTextOptions = True
        Me.ColProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColProductName.AppearanceHeader.Options.UseFont = True
        Me.ColProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProductName.Caption = "รายการ"
        Me.ColProductName.FieldName = "ProductName"
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.OptionsColumn.AllowEdit = False
        Me.ColProductName.OptionsColumn.ReadOnly = True
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 0
        Me.ColProductName.Width = 544
        '
        'ColAmount
        '
        Me.ColAmount.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColAmount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmount.AppearanceCell.Options.UseBackColor = True
        Me.ColAmount.AppearanceCell.Options.UseFont = True
        Me.ColAmount.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmount.AppearanceHeader.Options.UseFont = True
        Me.ColAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmount.Caption = "จำนวนขาย"
        Me.ColAmount.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmount.FieldName = "Amount"
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.OptionsColumn.AllowFocus = False
        Me.ColAmount.OptionsColumn.ReadOnly = True
        Me.ColAmount.Visible = True
        Me.ColAmount.VisibleIndex = 1
        Me.ColAmount.Width = 106
        '
        'ColUnit
        '
        Me.ColUnit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColUnit.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColUnit.AppearanceCell.Options.UseBackColor = True
        Me.ColUnit.AppearanceCell.Options.UseFont = True
        Me.ColUnit.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColUnit.AppearanceHeader.Options.UseFont = True
        Me.ColUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnit.Caption = "หน่วย"
        Me.ColUnit.FieldName = "UnitName"
        Me.ColUnit.Name = "ColUnit"
        Me.ColUnit.OptionsColumn.AllowEdit = False
        Me.ColUnit.OptionsColumn.ReadOnly = True
        Me.ColUnit.Visible = True
        Me.ColUnit.VisibleIndex = 2
        Me.ColUnit.Width = 106
        '
        'ColDiscount
        '
        Me.ColDiscount.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDiscount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDiscount.AppearanceCell.Options.UseBackColor = True
        Me.ColDiscount.AppearanceCell.Options.UseFont = True
        Me.ColDiscount.AppearanceCell.Options.UseTextOptions = True
        Me.ColDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColDiscount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDiscount.AppearanceHeader.Options.UseFont = True
        Me.ColDiscount.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDiscount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDiscount.Caption = "ส่วนลด (%)"
        Me.ColDiscount.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDiscount.FieldName = "Discount"
        Me.ColDiscount.Name = "ColDiscount"
        Me.ColDiscount.OptionsColumn.AllowEdit = False
        Me.ColDiscount.OptionsColumn.ReadOnly = True
        Me.ColDiscount.Visible = True
        Me.ColDiscount.VisibleIndex = 3
        Me.ColDiscount.Width = 131
        '
        'ColDiscountBath
        '
        Me.ColDiscountBath.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDiscountBath.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDiscountBath.AppearanceCell.Options.UseBackColor = True
        Me.ColDiscountBath.AppearanceCell.Options.UseFont = True
        Me.ColDiscountBath.AppearanceCell.Options.UseTextOptions = True
        Me.ColDiscountBath.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColDiscountBath.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDiscountBath.AppearanceHeader.Options.UseFont = True
        Me.ColDiscountBath.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDiscountBath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDiscountBath.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDiscountBath.Caption = "ส่วนลด (บาท)"
        Me.ColDiscountBath.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColDiscountBath.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDiscountBath.FieldName = "DiscountBath"
        Me.ColDiscountBath.Name = "ColDiscountBath"
        Me.ColDiscountBath.OptionsColumn.AllowEdit = False
        Me.ColDiscountBath.OptionsColumn.ReadOnly = True
        Me.ColDiscountBath.Visible = True
        Me.ColDiscountBath.VisibleIndex = 4
        Me.ColDiscountBath.Width = 124
        '
        'ColPrice
        '
        Me.ColPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPrice.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPrice.AppearanceCell.Options.UseBackColor = True
        Me.ColPrice.AppearanceCell.Options.UseFont = True
        Me.ColPrice.AppearanceCell.Options.UseTextOptions = True
        Me.ColPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPrice.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPrice.AppearanceHeader.Options.UseFont = True
        Me.ColPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrice.Caption = "ราคา"
        Me.ColPrice.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPrice.FieldName = "Price"
        Me.ColPrice.Name = "ColPrice"
        Me.ColPrice.OptionsColumn.AllowEdit = False
        Me.ColPrice.OptionsColumn.ReadOnly = True
        Me.ColPrice.Visible = True
        Me.ColPrice.VisibleIndex = 5
        Me.ColPrice.Width = 95
        '
        'ColExp
        '
        Me.ColExp.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColExp.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColExp.AppearanceCell.Options.UseBackColor = True
        Me.ColExp.AppearanceCell.Options.UseFont = True
        Me.ColExp.AppearanceCell.Options.UseTextOptions = True
        Me.ColExp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColExp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColExp.AppearanceHeader.Options.UseFont = True
        Me.ColExp.AppearanceHeader.Options.UseTextOptions = True
        Me.ColExp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColExp.Caption = "รวมเป็นเงิน"
        Me.ColExp.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColExp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColExp.FieldName = "ExSump"
        Me.ColExp.Name = "ColExp"
        Me.ColExp.OptionsColumn.AllowEdit = False
        Me.ColExp.OptionsColumn.ReadOnly = True
        Me.ColExp.Visible = True
        Me.ColExp.VisibleIndex = 6
        Me.ColExp.Width = 127
        '
        'FrmSlSaleGroupDt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 651)
        Me.Controls.Add(Me.GCSaleSH)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSlSaleGroupDt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ทำรายการรวบรวมใบแจ้งหนี้สินค้าโสหุ้ย"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GCSaleSH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSaleSH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSaleDt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSelDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCSaleSH As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSaleSH As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCusName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalNet1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColBathText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPricePerUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GVSaleDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidSaleMt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDiscountBath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColExp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbGroupComp As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents btnCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblPartnerName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColidPartner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpGroupBill As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNote As TextBox
    Friend WithEvents Label3 As Label
End Class
