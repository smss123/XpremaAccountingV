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
    public partial class AddItemCategoryFrm : DevExpress.XtraEditors.XtraForm
    {
        public AddItemCategoryFrm()
        {
            InitializeComponent();
        }

        private void AddItemCategoryFrm_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            HelperCommand.BeginProcess(this);
            CommandItemCategory cmd = new CommandItemCategory();
            var row = XCommander._db.ItemCategory.NewItemCategoryRow();
            row.CategoryName=categoryNameTextEdit.Text;
            row.Description = descriptionTextEdit.Text;
           if( cmd.NewItemCategory(row))
           {
               HelperCommand.EndProcess(this);
               HelperCommand.ShowMessageBoxAlert(HelperCommand.Messages.SavedMessage, "");
               //Message Box Hererow
           }
           HelperCommand.EndProcess(this);
        }
    }
}