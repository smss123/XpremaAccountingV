using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xprema.DataLayer;

namespace Xprema.ConnectorLayer
{
   public class CommandStors
    {
       public bool NewStor(db.StorsRow row)
        {
            var r = XCommander._db.Stors.NewStorsRow();
            row.StoreName = row.StoreName;
            row.Description = row.Description;
            XCommander._db.Stors.AddStorsRow(r);
            XCommander.Commit();
            return true;

        }

        public bool EditStors(db.StorsRow row)
        {
            var r = XCommander._db.Stors.FindByID(row.ID);
            r.StoreName = row.StoreName;
            r.Description = row.Description;
            XCommander.Commit();
            return true;
        }

        public bool DeleteStors(db.StorsRow row)
        {
            var r = XCommander._db.Stors.FindByID(row.ID);
            r.Delete();
            XCommander.Commit();
            return true;
        }

        public List<db.StorsRow> ListCategoryRows()
        {
            return XCommander._db.Stors.ToList();
        }

    }
}
