<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlPrice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlPrice))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GVPrice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GVPrice
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(284, 262)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPrice})
        '
        'GVPrice
        '
        Me.GVPrice.Appearance.EvenRow.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GVPrice.Appearance.EvenRow.Options.UseFont = True
        Me.GVPrice.Appearance.FocusedCell.BackColor = System.Drawing.Color.PowderBlue
        Me.GVPrice.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVPrice.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVPrice.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVPrice.Appearance.FocusedRow.BackColor = System.Drawing.Color.PowderBlue
        Me.GVPrice.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVPrice.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVPrice.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVPrice.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GVPrice.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVPrice.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.PowderBlue
        Me.GVPrice.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVPrice.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVPrice.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVPrice.Appearance.SelectedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GVPrice.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVPrice.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColDateSale, Me.ColPrice})
        Me.GVPrice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVPrice.GridControl = Me.GridControl1
        Me.GVPrice.Name = "GVPrice"
        Me.GVPrice.OptionsView.RowAutoHeight = True
        Me.GVPrice.OptionsView.ShowGroupPanel = False
        Me.GVPrice.OptionsView.ShowIndicator = False
        Me.GVPrice.PaintStyleName = "MixedXP"
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 50
        '
        'ColDateSale
        '
        Me.ColDateSale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ColDateSale.AppearanceCell.Options.UseBackColor = True
        Me.ColDateSale.AppearanceCell.Options.UseFont = True
        Me.ColDateSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateSale.AppearanceHeader.Options.UseFont = True
        Me.ColDateSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale.Caption = "วันที่ขาย"
        Me.ColDateSale.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateSale.FieldName = "DateSaleD"
        Me.ColDateSale.Name = "ColDateSale"
        Me.ColDateSale.OptionsColumn.AllowEdit = False
        Me.ColDateSale.OptionsColumn.ReadOnly = True
        Me.ColDateSale.Visible = True
        Me.ColDateSale.VisibleIndex = 1
        Me.ColDateSale.Width = 112
        '
        'ColPrice
        '
        Me.ColPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPrice.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ColPrice.AppearanceCell.Options.UseBackColor = True
        Me.ColPrice.AppearanceCell.Options.UseFont = True
        Me.ColPrice.AppearanceCell.Options.UseTextOptions = True
        Me.ColPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrice.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ColPrice.AppearanceHeader.Options.UseFont = True
        Me.ColPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrice.Caption = "ราคาขาย"
        Me.ColPrice.DisplayFormat.FormatString = "#,###0.00##"
        Me.ColPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColPrice.FieldName = "Price"
        Me.ColPrice.Name = "ColPrice"
        Me.ColPrice.OptionsColumn.AllowEdit = False
        Me.ColPrice.OptionsColumn.ReadOnly = True
        Me.ColPrice.Visible = True
        Me.ColPrice.VisibleIndex = 2
        Me.ColPrice.Width = 120
        '
        'frmSlPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.GridControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSlPrice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ราคาขายล่าสุด"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPrice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrice As DevExpress.XtraGrid.Columns.GridColumn
End Class
