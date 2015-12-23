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
using Xprema.DataLayer;

namespace XpremaAccountingV.ItemsForms
{
    public partial class FrmManageITEM : DevExpress.XtraEditors.XtraForm
    {
        public FrmManageITEM()
        {
            InitializeComponent();
        }

        private void AddBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HelperCommand.Show(new AddItemFrm());
        }

        private void FrmManageITEM_Load(object sender, EventArgs e)
        {
            HelperCommand.BeginProcess(this);
                       
            itemCategoryRowBindingSource.DataSource = XCommander._db.ItemCategory.ToList();
            itemsRowBindingSource.DataSource = XCommander._db.Items.ToList();
            HelperCommand.EndProcess(this);
            
        } 

        private void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmManageITEM_Load(null, null);
        }

        private void SaveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Validate();
            itemsRowBindingSource.EndEdit();
            XCommander.Commit();
            HelperCommand.ShowMessageBoxAlert(HelperCommand.Messages.Done, "");
        }
    }
}