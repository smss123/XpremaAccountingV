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

namespace XpremaAccountingV.StorsForms
{
    public partial class AddStor : DevExpress.XtraEditors.XtraForm
    {
        public AddStor()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            HelperCommand.BeginProcess(this);
            CommandStors cmd = new CommandStors();
            var row = XCommander._db.Stors.NewStorsRow();
            row.StoreName = storeNameTextEdit.Text;
            row.Description = descriptionTextEdit.Text;
            if (cmd.NewStor(row))
            {
                HelperCommand.EndProcess(this);
                HelperCommand.ShowMessageBoxAlert(HelperCommand.Messages.SavedMessage, "");
                //Message Box Hererow
            }
            HelperCommand.EndProcess(this);
        }
    }
}