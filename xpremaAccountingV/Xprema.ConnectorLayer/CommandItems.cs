using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xprema.DataLayer;

namespace Xprema.ConnectorLayer
{
   public class CommandItems
    {
        public bool NewStor(db.ItemsRow row)
        {
            var r = XCommander._db.Items.NewItemsRow();
            row.ItemBasicName = row.ItemBasicName;
            row.ItemTradeName = row.ItemTradeName;
            row.ItemUnit = row.ItemUnit;
            row.ItemPayAmount = row.ItemPayAmount;
            row.ItemSaleAmount = row.ItemSaleAmount;
            row.Description = row.Description;
            row.CategoryID = row.CategoryID;
            row.ItemNumber = row.ItemNumber;
            XCommander._db.Items.AddItemsRow(r);
            XCommander.Commit();
            return true;

        }

        public bool EditItems(db.ItemsRow row)
        {
            var r = XCommander._db.Items.FindByID(row.ID);
            row.ItemBasicName = row.ItemBasicName;
            row.ItemTradeName = row.ItemTradeName;
            row.ItemUnit = row.ItemUnit;
            row.ItemPayAmount = row.ItemPayAmount;
            row.ItemSaleAmount = row.ItemSaleAmount;
            row.Description = row.Description;
            row.CategoryID = row.CategoryID;
            row.ItemNumber = row.ItemNumber;
            r.Description = row.Description;
            row.ItemNumber = row.ItemNumber;
            XCommander.Commit();
            return true;
        }

        public bool DeleteItems(db.ItemsRow row)
        {
            var r = XCommander._db.Items.FindByID(row.ID);
            r.Delete();
            XCommander.Commit();
            return true;
        }

        public List<db.ItemsRow> ListCategoryRows()
        {
            return XCommander._db.Items.ToList();
        }

    }
}
