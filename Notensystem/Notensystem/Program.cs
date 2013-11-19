using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notensystem.Core;

namespace Notensystem.Controls
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ViewModel viewModel = new ViewModel();

            if (viewModel.CanLogin())
            {
                Application.Run(new MainForm(viewModel));
            }
            else
            {
                MessageBox.Show(ApplicationEnvironment.GetString("UserInvalid"), ApplicationEnvironment.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
