namespace XpremaAccountingV.ItemsForms
{
    partial class FrmManageITEM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageITEM));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.AddBtn = new DevExpress.XtraBars.BarButtonItem();
            this.RefreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.SaveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.itemsRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemBasicName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemTradeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemPayAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemSaleAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.itemCategoryRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsRowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.AddBtn,
            this.RefreshBtn,
            this.SaveBtn,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(786, 140);
            // 
            // AddBtn
            // 
            this.AddBtn.Caption = "جديد";
            this.AddBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("AddBtn.Glyph")));
            this.AddBtn.Id = 1;
            this.AddBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("AddBtn.LargeGlyph")));
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddBtn_ItemClick);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Caption = "تحديث البيانات";
            this.RefreshBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Glyph")));
            this.RefreshBtn.Id = 2;
            this.RefreshBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.LargeGlyph")));
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RefreshBtn_ItemClick);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Caption = "حفظ التغيرات";
            this.SaveBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Glyph")));
            this.SaveBtn.Id = 3;
            this.SaveBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("SaveBtn.LargeGlyph")));
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveBtn_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "اضافة تصنيف جديد";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "سجل التصنيفات";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "الأدوات";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.AddBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.RefreshBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.SaveBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "الأدوات";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "التصنيفات";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 140);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(786, 289);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "سجل الأصناف";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.itemsRowBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(782, 266);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // itemsRowBindingSource
            // 
            this.itemsRowBindingSource.DataSource = typeof(Xprema.DataLayer.db.ItemsRow);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colItemNumber,
            this.colItemBasicName,
            this.colItemTradeName,
            this.colItemUnit,
            this.colItemPayAmount,
            this.colItemSaleAmount,
            this.colDescription,
            this.colCategoryID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colItemNumber
            // 
            this.colItemNumber.Caption = "رقم الصنف";
            this.colItemNumber.FieldName = "ItemNumber";
            this.colItemNumber.Name = "colItemNumber";
            this.colItemNumber.Visible = true;
            this.colItemNumber.VisibleIndex = 0;
            this.colItemNumber.Width = 95;
            // 
            // colItemBasicName
            // 
            this.colItemBasicName.Caption = "اسم الصنف";
            this.colItemBasicName.FieldName = "ItemBasicName";
            this.colItemBasicName.Name = "colItemBasicName";
            this.colItemBasicName.Visible = true;
            this.colItemBasicName.VisibleIndex = 1;
            this.colItemBasicName.Width = 175;
            // 
            // colItemTradeName
            // 
            this.colItemTradeName.Caption = "الاسم التجاري";
            this.colItemTradeName.FieldName = "ItemTradeName";
            this.colItemTradeName.Name = "colItemTradeName";
            this.colItemTradeName.Visible = true;
            this.colItemTradeName.VisibleIndex = 2;
            this.colItemTradeName.Width = 163;
            // 
            // colItemUnit
            // 
            this.colItemUnit.Caption = "الوحدة";
            this.colItemUnit.FieldName = "ItemUnit";
            this.colItemUnit.Name = "colItemUnit";
            this.colItemUnit.Visible = true;
            this.colItemUnit.VisibleIndex = 3;
            this.colItemUnit.Width = 51;
            // 
            // colItemPayAmount
            // 
            this.colItemPayAmount.Caption = "سعر البيع";
            this.colItemPayAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colItemPayAmount.FieldName = "ItemPayAmount";
            this.colItemPayAmount.Name = "colItemPayAmount";
            this.colItemPayAmount.Visible = true;
            this.colItemPayAmount.VisibleIndex = 4;
            this.colItemPayAmount.Width = 69;
            // 
            // colItemSaleAmount
            // 
            this.colItemSaleAmount.Caption = "سعر الشراء";
            this.colItemSaleAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colItemSaleAmount.FieldName = "ItemSaleAmount";
            this.colItemSaleAmount.Name = "colItemSaleAmount";
            this.colItemSaleAmount.Visible = true;
            this.colItemSaleAmount.VisibleIndex = 5;
            this.colItemSaleAmount.Width = 65;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "الوصف";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 84;
            // 
            // colCategoryID
            // 
            this.colCategoryID.Caption = "التصنيف";
            this.colCategoryID.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 7;
            this.colCategoryID.Width = 62;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "التصنيف", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.itemCategoryRowBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "CategoryName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // itemCategoryRowBindingSource
            // 
            this.itemCategoryRowBindingSource.DataSource = typeof(Xprema.DataLayer.db.ItemCategoryRow);
            // 
            // FrmManageITEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 429);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmManageITEM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجلات الأصناف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmManageITEM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsRowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryRowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem AddBtn;
        private DevExpress.XtraBars.BarButtonItem RefreshBtn;
        private DevExpress.XtraBars.BarButtonItem SaveBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource itemsRowBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colItemNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colItemBasicName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemTradeName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colItemPayAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colItemSaleAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource itemCategoryRowBindingSource;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}