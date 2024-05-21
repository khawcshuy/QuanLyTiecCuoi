using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTiecCuoi.Private;

namespace QuanLyTiecCuoi.Login
{
    public abstract class RJMessageBox
    {
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption, buttons))
            result = msgForm.ShowDialog();
            return result;
        }
    }
}
