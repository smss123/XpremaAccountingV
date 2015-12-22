using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Xprema.ConnectorLayer;
using Xprema.DataLayer;
namespace XpremaAccountingV.ItemsForms
{
    public partial class manageItemCategoryFrm : DevExpress.XtraEditors.XtraForm
    {
        public manageItemCategoryFrm()
        {
            InitializeComponent();
        }

        private void manageItemCategoryFrm_Load(object sender, EventArgs e)
        {
            HelperCommand.BeginProcess(this);
            
            itemCategoryRowBindingSource.DataSource = XCommander._db.ItemCategory.ToList();
            HelperCommand.EndProcess(this);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HelperCommand.Show(new AddItemCategoryFrm());
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            manageItemCategoryFrm_Load(null, null);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Validate();
            itemCategoryRowBindingSource.EndEdit();
            XCommander.Commit();
            HelperCommand.ShowMessageBoxAlert(HelperCommand.Messages.Done, "");
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
            

        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}