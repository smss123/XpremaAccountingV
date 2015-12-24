using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xprema.DataLayer;

namespace Xprema.ConnectorLayer
{
   public class CommandStoreTransaction
    {


        public bool NewStor(db.StoreTransactionRow row)
        {
            var r = XCommander._db.StoreTransaction.NewStoreTransactionRow();
            row.ItemID = row.ItemID;
            row.DateOfTransaction = row.DateOfTransaction;
            row.QtyIn = row.QtyIn;
            row.QtyOut = row.QtyOut;
            row.Description = row.Description;
            row.StoreID = row.StoreID;
            XCommander._db.StoreTransaction.AddStoreTransactionRow(r);

            XCommander.SaveChanges();
            r = null;
            return true;

        }

        public bool EditStoreTransaction(db.StoreTransactionRow row)
        {
            var r = XCommander._db.StoreTransaction.FindByID(row.ID);
            row.ItemID = row.ItemID;
            row.DateOfTransaction = row.DateOfTransaction;
            row.QtyIn = row.QtyIn;
            row.QtyOut = row.QtyOut;
            row.Description = row.Description;
            row.StoreID = row.StoreID;


            XCommander.SaveChanges();
            r = null;
            return true;
        }

        public bool DeleteStoreTransaction(db.StoreTransactionRow row)
        {
            var r = XCommander._db.StoreTransaction.FindByID(row.ID);
            r.Delete();



            XCommander.SaveChanges();
            r = null;
            return true;
        }

        //public List<db.StoreTransactionRow> ListCategoryRows()
        //{
        //    return XCommander._db.StoreTransaction.ToList();
        //}


        public List<db.StoreTransactionRow> ListStoreTransactionRows()
        {
            try
            {
                return XCommander._db.StoreTransaction.ToList();

            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<db.StoreTransactionRow> ListStoreTransactionRows_ByStoreId(int storeid)
        {
            try
            {

                var lst = XCommander._db.StoreTransaction.Where (c=> c.StoreID == storeid );
                return lst.ToList();

            }
            catch (Exception)
            {

                return null;
            }
        }


    }
}
