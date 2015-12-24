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

namespace XpremaAccountingV.StorsForms
{
    public partial class ManageStore : DevExpress.XtraEditors.XtraForm
    {
        public ManageStore()
        {
            InitializeComponent();
        }

        private void AddBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HelperCommand.Show(new AddStor());
        }

        private void SaveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Validate();
            storsRowBindingSource.EndEdit();
            XCommander.Commit();
            HelperCommand.ShowMessageBoxAlert(HelperCommand.Messages.Done, "");
        }

        private void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageStore_Load(null, null);

        }

        private void ManageStore_Load(object sender, EventArgs e)
        {
              HelperCommand.BeginProcess(this);
            
            storsRowBindingSource.DataSource = XCommander._db.Stors.ToList();
            HelperCommand.EndProcess(this);
            
        }
    }
}