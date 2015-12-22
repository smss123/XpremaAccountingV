using System.Collections.Generic;
using System.Linq;
using Xprema.DataLayer;

namespace Xprema.ConnectorLayer
{
    public class CommandItemCategory
    {
        public bool NewItemCategory(db.ItemCategoryRow row)
        {
            //var r = XCommander._db.ItemCategory.NewItemCategoryRow();
            //row.CategoryName = row.CategoryName;
            //row.Description = row.Description;
            XCommander._db.ItemCategory.AddItemCategoryRow(row);
            XCommander.Commit();
            return true;
            
        }

        public bool EditItemCategory(db.ItemCategoryRow row)
        {
            var r = XCommander._db.ItemCategory.FindByID(row.ID);
            r.CategoryName = row.CategoryName;
            r.Description = row.Description;
            XCommander.Commit();
            return true;
        }

        public bool DeleteItemCategory(db.ItemCategoryRow row)
        {
            var r = XCommander._db.ItemCategory.FindByID(row.ID);
            r.Delete();
            XCommander.Commit();
            return true;
        }

        public List<db.ItemCategoryRow> ListCategoryRows()
        {
            return XCommander._db.ItemCategory.ToList();
        }
    }
}