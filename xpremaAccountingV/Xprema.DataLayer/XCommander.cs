using System;
using System.IO;
using System.Windows.Forms;

namespace Xprema.DataLayer
{
    public class XCommander
    {
        public static db _db = new db();
        public static string Path = Application.StartupPath + @"\Data.xprema";

        public static bool CreateFile()
        {
            if (!File.Exists(Path))
            {
                _db.WriteXmlSchema(Path);
                return true;
            }
            ReadFile();
            return true;
        }

        public static bool ReadFile()
        {
            try
            {
                _db = new db();

                _db.ReadXml(Path);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                CreateFile();
                ReadFile();
                return true;
            }
        }

        //public static bool Commit()
        //{
        //    _db.WriteXml(Path);

        //    return true;
        //}

        public static bool SaveChanges()
        {
            _db.WriteXml(Path);

            return true;
        }
    }
}