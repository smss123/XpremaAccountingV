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
    public partial class AddStoreTransactionFrm : DevExpress.XtraEditors.XtraForm
    {
        public AddStoreTransactionFrm()
        {
            InitializeComponent();
        }

        private void AddStoreTransactionFrm_Load(object sender, EventArgs e)
        {
            HelperCommand.BeginProcess(this);
            storsRowBindingSource.DataSource = XCommander._db.Stors.ToList();

            itemsRowBindingSource.DataSource = XCommander._db.Items.ToList();
            HelperCommand.EndProcess(this);

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}