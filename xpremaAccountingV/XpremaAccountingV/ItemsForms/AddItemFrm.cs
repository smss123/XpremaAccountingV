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
    public partial class AddItemFrm : DevExpress.XtraEditors.XtraForm
    {
        public AddItemFrm()
        {
            InitializeComponent();
        }

        private void AddItemFrm_Load(object sender, EventArgs e)
        {
            categoryIDLookUpEdit.Properties.DataSource = XCommander._db.ItemCategory.ToList();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelperCommand.BeginProcess(this);
            CommandItems cmd = new CommandItems();
            var row = XCommander._db.Items.NewItemsRow();
            row.ItemNumber = itemNumberTextEdit.Text;
            row.ItemBasicName = itemBasicNameTextEdit.Text;
            row.ItemTradeName = itemBasicNameTextEdit.Text;
            row.ItemUnit = itemUnitTextEdit.Text;
            row.ItemSaleAmount = double.Parse(itemSaleAmountSpinEdit.Text);
            row.ItemPayAmount = double.Parse(itemPayAmountSpinEdit.Text);
            row.CategoryID = int.Parse(categoryIDLookUpEdit.EditValue.ToString());
            row.Description = descriptionTextEdit.Text;


            if (cmd.NewItems(row))
            {
                HelperCommand.EndProcess(this);
                HelperCommand.ShowMessageBoxAlert(HelperCommand.Messages.SavedMessage, "");
                //Message Box Hererow
            }
            HelperCommand.EndProcess(this);
        }
    }
}