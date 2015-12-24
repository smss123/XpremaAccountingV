namespace XpremaAccountingV.StorsForms
{
    partial class AddStoreTransactionFrm
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
            System.Windows.Forms.Label dateOfTransactionLabel;
            System.Windows.Forms.Label storeIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStoreTransactionFrm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.AddBtn = new DevExpress.XtraBars.BarButtonItem();
            this.RefreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.SaveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.storeIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.db_StoreTransactionRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storsRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfTransactionDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.itemsRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colQtyIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            dateOfTransactionLabel = new System.Windows.Forms.Label();
            storeIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeIDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_StoreTransactionRowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storsRowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfTransactionDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfTransactionDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateOfTransactionLabel
            // 
            dateOfTransactionLabel.AutoSize = true;
            dateOfTransactionLabel.Location = new System.Drawing.Point(118, 27);
            dateOfTransactionLabel.Name = "dateOfTransactionLabel";
            dateOfTransactionLabel.Size = new System.Drawing.Size(39, 13);
            dateOfTransactionLabel.TabIndex = 0;
            dateOfTransactionLabel.Text = "التاريخ:";
            // 
            // storeIDLabel
            // 
            storeIDLabel.AutoSize = true;
            storeIDLabel.Location = new System.Drawing.Point(808, 27);
            storeIDLabel.Name = "storeIDLabel";
            storeIDLabel.Size = new System.Drawing.Size(43, 13);
            storeIDLabel.TabIndex = 2;
            storeIDLabel.Text = "المخزن:";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.AddBtn,
            this.RefreshBtn,
            this.SaveBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(871, 140);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Caption = "جديد";
            this.AddBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("AddBtn.Glyph")));
            this.AddBtn.Id = 1;
            this.AddBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("AddBtn.LargeGlyph")));
            this.AddBtn.Name = "AddBtn";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Caption = "تحديث البيانات";
            this.RefreshBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Glyph")));
            this.RefreshBtn.Id = 2;
            this.RefreshBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.LargeGlyph")));
            this.RefreshBtn.Name = "RefreshBtn";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Caption = "حفظ التغيرات";
            this.SaveBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Glyph")));
            this.SaveBtn.Id = 3;
            this.SaveBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("SaveBtn.LargeGlyph")));
            this.SaveBtn.Name = "SaveBtn";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "الأدوات";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.RefreshBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.SaveBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "الأدوات";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(storeIDLabel);
            this.groupControl1.Controls.Add(this.storeIDLookUpEdit);
            this.groupControl1.Controls.Add(dateOfTransactionLabel);
            this.groupControl1.Controls.Add(this.dateOfTransactionDateEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 140);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(871, 67);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "البيانات";
            // 
            // storeIDLookUpEdit
            // 
            this.storeIDLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.db_StoreTransactionRowBindingSource, "StoreID", true));
            this.storeIDLookUpEdit.Location = new System.Drawing.Point(675, 24);
            this.storeIDLookUpEdit.MenuManager = this.ribbonControl1;
            this.storeIDLookUpEdit.Name = "storeIDLookUpEdit";
            this.storeIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.storeIDLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StoreName", "المخزن", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.storeIDLookUpEdit.Properties.DataSource = this.storsRowBindingSource;
            this.storeIDLookUpEdit.Properties.DisplayMember = "StoreName";
            this.storeIDLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.storeIDLookUpEdit.Properties.ValueMember = "ID";
            this.storeIDLookUpEdit.Size = new System.Drawing.Size(127, 20);
            this.storeIDLookUpEdit.TabIndex = 3;
            // 
            // db_StoreTransactionRowBindingSource
            // 
            this.db_StoreTransactionRowBindingSource.DataSource = typeof(Xprema.DataLayer.db.StoreTransactionRow);
            // 
            // storsRowBindingSource
            // 
            this.storsRowBindingSource.DataSource = typeof(Xprema.DataLayer.db.StorsRow);
            // 
            // dateOfTransactionDateEdit
            // 
            this.dateOfTransactionDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.db_StoreTransactionRowBindingSource, "DateOfTransaction", true));
            this.dateOfTransactionDateEdit.EditValue = null;
            this.dateOfTransactionDateEdit.Location = new System.Drawing.Point(12, 24);
            this.dateOfTransactionDateEdit.MenuManager = this.ribbonControl1;
            this.dateOfTransactionDateEdit.Name = "dateOfTransactionDateEdit";
            this.dateOfTransactionDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOfTransactionDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOfTransactionDateEdit.Size = new System.Drawing.Size(100, 20);
            this.dateOfTransactionDateEdit.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.db_StoreTransactionRowBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 207);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemLookUpEdit});
            this.gridControl1.Size = new System.Drawing.Size(871, 329);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colItemID,
            this.colQtyIn,
            this.colQtyOut,
            this.colDescription,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 53;
            // 
            // colItemID
            // 
            this.colItemID.ColumnEdit = this.ItemLookUpEdit;
            this.colItemID.FieldName = "ItemID";
            this.colItemID.Name = "colItemID";
            this.colItemID.Visible = true;
            this.colItemID.VisibleIndex = 1;
            this.colItemID.Width = 76;
            // 
            // ItemLookUpEdit
            // 
            this.ItemLookUpEdit.AutoHeight = false;
            this.ItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemNumber", "رقم الصننف", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemBasicName", "اسم الصنف", 89, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ItemLookUpEdit.DataSource = this.itemsRowBindingSource;
            this.ItemLookUpEdit.DisplayMember = "ItemNumber";
            this.ItemLookUpEdit.Name = "ItemLookUpEdit";
            this.ItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ItemLookUpEdit.ValueMember = "ID";
            // 
            // itemsRowBindingSource
            // 
            this.itemsRowBindingSource.DataSource = typeof(Xprema.DataLayer.db.ItemsRow);
            // 
            // colQtyIn
            // 
            this.colQtyIn.FieldName = "QtyIn";
            this.colQtyIn.Name = "colQtyIn";
            this.colQtyIn.Visible = true;
            this.colQtyIn.VisibleIndex = 4;
            this.colQtyIn.Width = 52;
            // 
            // colQtyOut
            // 
            this.colQtyOut.FieldName = "QtyOut";
            this.colQtyOut.Name = "colQtyOut";
            this.colQtyOut.Visible = true;
            this.colQtyOut.VisibleIndex = 5;
            this.colQtyOut.Width = 44;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 339;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "اسم الصنف";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 241;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "الوحدة";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 45;
            // 
            // AddStoreTransactionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 536);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "AddStoreTransactionFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "AddStoreTransactionFrm";
            this.Load += new System.EventHandler(this.AddStoreTransactionFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeIDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_StoreTransactionRowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storsRowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfTransactionDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfTransactionDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsRowBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.LookUpEdit storeIDLookUpEdit;
        private System.Windows.Forms.BindingSource db_StoreTransactionRowBindingSource;
        private DevExpress.XtraEditors.DateEdit dateOfTransactionDateEdit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyIn;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyOut;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private System.Windows.Forms.BindingSource storsRowBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpEdit;
        private System.Windows.Forms.BindingSource itemsRowBindingSource;
    }
}