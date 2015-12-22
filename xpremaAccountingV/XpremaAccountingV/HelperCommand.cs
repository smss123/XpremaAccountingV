using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace XpremaAccountingV
{
   public  class HelperCommand
    {
       //public static db.UserRow  CurrentUser ;
       //public static db.UserPermessionRow Permession;
       public static void BeginProcess(Control frm)
       {
           frm.Invoke((MethodInvoker)delegate {

               frm.Enabled = false;
               frm.Cursor = Cursors.WaitCursor;
           
           });
       }

       public static void EndProcess(Control frm)
       {
           frm.Invoke((MethodInvoker)delegate
           {

               frm.Enabled = true;
               frm.Cursor = Cursors.Default;

           });
       }

       public static void Show(Form frm)
       {
           Fill_Icon(frm);
           frm.ShowDialog();
       }

       public static void Fill_Icon(Form frm)
       {
           frm.Icon = Icon.ExtractAssociatedIcon(string.Format(@"{0}\{1}.exe", Application.StartupPath, Application.ProductName));
       }

       public static void ShowMessageBoxAlert(string msg, string caption)
       {
           XtraMessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
       }

       public class Messages
       {
           public const string DeleteMessage = "هل تريد الحذف?";
           public const string DeleteCaption = "Delete Action";

           public const string Done = "تم بنجاح !";

           public const string SaveConfMessage = "هل تريد الحفظ؟?";
           public const string SavedMessage = "تم الحفظ بنجاح";
           public const string SavedCaption = "Save Action";
           
       }
    }
}
