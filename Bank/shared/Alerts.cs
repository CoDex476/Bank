using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.shared
{
    public class Alerts
    {
        public static void ExceptionMessage(string exMessage)
        {
            MessageBox.Show("Error : " + exMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void InformationMessage(string exMessage)
        {
            MessageBox.Show(exMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void WarningMessage(string exMessage)
        {
            MessageBox.Show(exMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
