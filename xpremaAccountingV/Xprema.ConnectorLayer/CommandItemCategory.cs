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
            XCommander.SaveChanges();
            return true;

        }

        public bool EditItemCategory(db.ItemCategoryRow row)
        {
            var r = XCommander._db.ItemCategory.FindByID(row.ID);
            r.CategoryName = row.CategoryName;
            r.Description = row.Description;

            XCommander.SaveChanges();
            r = null;
            return true;
        }

        public bool DeleteItemCategory(db.ItemCategoryRow row)
        {
            var r = XCommander._db.ItemCategory.FindByID(row.ID);
            r.Delete();

            XCommander.SaveChanges();
            r = null;
            return true;
        }


        #region "     Queries       "

        public db.ItemCategoryRow SingleCategory(int categoryId)
        {
            try
            {
                var r = XCommander._db.ItemCategory.FindByID(categoryId);
                return r;
            }
            catch (System.Exception)
            {

                return null;
            }
        }

        public db.ItemCategoryRow SingleCategory(string categoryname)
        {
            try
            {
                var r = XCommander._db.ItemCategory.Single(c => c.CategoryName == categoryname);
                return r;
            }
            catch (System.Exception)
            {

                return null;
            }
        }
        public List<db.ItemCategoryRow> ListCategoryRows()
        {
            try
            {
                return XCommander._db.ItemCategory.ToList();
            }
            catch (System.Exception)
            {

                return null;
            }
        }

        #endregion 
    }
}