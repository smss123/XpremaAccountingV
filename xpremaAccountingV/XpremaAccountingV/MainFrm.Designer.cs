namespace XpremaAccountingV
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ItemBtn = new DevExpress.XtraBars.BarButtonItem();
            this.CustomerBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.StorBtn = new DevExpress.XtraBars.BarButtonItem();
            this.StoreTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.المبيعات = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.AddStoreTransactionBTn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ItemBtn,
            this.CustomerBtn,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.StorBtn,
            this.StoreTransaction,
            this.AddStoreTransactionBTn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.المبيعات,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5});
            this.ribbonControl1.Size = new System.Drawing.Size(815, 140);
            // 
            // ItemBtn
            // 
            this.ItemBtn.Caption = "الأصناف";
            this.ItemBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("ItemBtn.Glyph")));
            this.ItemBtn.Id = 1;
            this.ItemBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ItemBtn.LargeGlyph")));
            this.ItemBtn.Name = "ItemBtn";
            this.ItemBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemBtn_ItemClick);
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.Caption = "الزبائن";
            this.CustomerBtn.Id = 2;
            this.CustomerBtn.Name = "CustomerBtn";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "فواتير المبيعات";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "مرتجع المبيعات";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // StorBtn
            // 
            this.StorBtn.Caption = "المخازن";
            this.StorBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("StorBtn.Glyph")));
            this.StorBtn.Id = 7;
            this.StorBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("StorBtn.LargeGlyph")));
            this.StorBtn.Name = "StorBtn";
            this.StorBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.StorBtn_ItemClick);
            // 
            // StoreTransaction
            // 
            this.StoreTransaction.Caption = "حركات المخازن";
            this.StoreTransaction.Glyph = ((System.Drawing.Image)(resources.GetObject("StoreTransaction.Glyph")));
            this.StoreTransaction.Id = 8;
            this.StoreTransaction.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("StoreTransaction.LargeGlyph")));
            this.StoreTransaction.Name = "StoreTransaction";
            this.StoreTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.StoreTransaction_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "الدليل";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.ItemBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.CustomerBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = " الدليل";
            // 
            // المبيعات
            // 
            this.المبيعات.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.المبيعات.Name = "المبيعات";
            this.المبيعات.Text = "المبيعات";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "المبيعات";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "المشتريات";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "المخازن";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.StorBtn);
            this.ribbonPageGroup3.ItemLinks.Add(this.AddStoreTransactionBTn);
            this.ribbonPageGroup3.ItemLinks.Add(this.StoreTransaction);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "المخازن";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "سندات";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Location = new System.Drawing.Point(0, 140);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.Size = new System.Drawing.Size(140, 233);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "القائمة السريعة";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // AddStoreTransactionBTn
            // 
            this.AddStoreTransactionBTn.Caption = "تعديل المخزون";
            this.AddStoreTransactionBTn.Glyph = ((System.Drawing.Image)(resources.GetObject("AddStoreTransactionBTn.Glyph")));
            this.AddStoreTransactionBTn.Id = 9;
            this.AddStoreTransactionBTn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("AddStoreTransactionBTn.LargeGlyph")));
            this.AddStoreTransactionBTn.Name = "AddStoreTransactionBTn";
            this.AddStoreTransactionBTn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddStoreTransactionBTn_ItemClick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 373);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "MainFrm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem ItemBtn;
        private DevExpress.XtraBars.BarButtonItem CustomerBtn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem StorBtn;
        private DevExpress.XtraBars.BarButtonItem StoreTransaction;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage المبيعات;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraBars.BarButtonItem AddStoreTransactionBTn;
    }
}