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
        public bool NewItems(db.ItemsRow row)
        {
            //var r = XCommander._db.Items.NewItemsRow();
            //row.ItemBasicName = row.ItemBasicName;
            //row.ItemTradeName = row.ItemTradeName;
            //row.ItemUnit = row.ItemUnit;
            //row.ItemPayAmount = row.ItemPayAmount;
            //row.ItemSaleAmount = row.ItemSaleAmount;
            //row.Description = row.Description;
            //row.CategoryID = row.CategoryID;
            //row.ItemNumber = row.ItemNumber;
            XCommander._db.Items.AddItemsRow(row);
            XCommander.SaveChanges();
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

            XCommander.SaveChanges();
            r = null;
            return true;
        }

        public bool DeleteItems(db.ItemsRow row)
        {
            var r = XCommander._db.Items.FindByID(row.ID);
            r.Delete();

            XCommander.SaveChanges();
            r = null;
            return true;
        }

        //public List<db.ItemsRow> ListCategoryRows()
        //{
        //    return XCommander._db.Items.ToList();
        //}


        #region  "      Queries           "

        public db.ItemsRow GetOneItemOnley(int itemid)
        {
            try
            {
                var r = XCommander._db.Items.FindByID(itemid);
                return r;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public db.ItemsRow GetOneItemOnley(string itemname)
        {
            try
            {
                var r = XCommander._db.Items.Single(c => c.ItemBasicName == itemname);
                return r;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<db.ItemsRow> ListItemsRows()
        {
            try
            {
                return XCommander._db.Items.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<db.ItemsRow> ListItemsRows_ByCategoryId(int categoryid)
        {
            try
            {
                var lst = XCommander._db.Items.Where (c=> c.CategoryID == categoryid );
                return lst.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }
        #endregion
    }
}
