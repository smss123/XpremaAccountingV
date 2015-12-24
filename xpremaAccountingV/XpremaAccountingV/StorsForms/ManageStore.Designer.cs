namespace XpremaAccountingV.StorsForms
{
    partial class ManageStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStore));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.AddBtn = new DevExpress.XtraBars.BarButtonItem();
            this.RefreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.SaveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.storsRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStoreName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storsRowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.ribbonControl1.Size = new System.Drawing.Size(712, 140);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 140);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(712, 307);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "سجلات المخازن";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.storsRowBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(708, 284);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // storsRowBindingSource
            // 
            this.storsRowBindingSource.DataSource = typeof(Xprema.DataLayer.db.StorsRow);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colStoreName,
            this.colDescription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 53;
            // 
            // colStoreName
            // 
            this.colStoreName.Caption = "اسم المخزن";
            this.colStoreName.FieldName = "StoreName";
            this.colStoreName.Name = "colStoreName";
            this.colStoreName.Visible = true;
            this.colStoreName.VisibleIndex = 0;
            this.colStoreName.Width = 221;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "الوصف";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 426;
            // 
            // ManageStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 447);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ManageStore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ManageStore";
            this.Load += new System.EventHandler(this.ManageStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storsRowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private System.Windows.Forms.BindingSource storsRowBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colStoreName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    }
}