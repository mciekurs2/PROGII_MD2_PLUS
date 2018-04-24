using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace md2
{
    public class ErrorMessages
    {
        public static string ErrorOne = "Please eneter values";
        public static string ErrorTwo = "Temporary Text";

        public static void ShowError(string error)
        {
            MessageBox.Show(error);
        }

    }
}
