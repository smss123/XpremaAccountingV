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
using XpremaAccountingV.ItemsForms;
using XpremaAccountingV.StorsForms;

namespace XpremaAccountingV
{
    public partial class MainFrm : DevExpress.XtraEditors.XtraForm
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void ItemBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HelperCommand.Show(new FrmManageITEM());
            
        }

        private void StorBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HelperCommand.Show(new ManageStore());
        }

        private void AddStoreTransactionBTn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HelperCommand.Show(new AddStoreTransactionFrm());
        }

        private void StoreTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HelperCommand.Show(new AddStoreTransactionFrm());
        }
    }
}