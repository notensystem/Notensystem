using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notensystem.Controls
{
    public partial class Import : BaseDialog
    {

       

        public Import()
        {
            InitializeComponent();
        }

        private void button_OpenFileDialog_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog.Filter = "Excel Files (.csv)|*.csv";
            openFileDialog.FilterIndex = 1;

            openFileDialog.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
           openFileDialog.ShowDialog();

           System.IO.FileInfo fInfo = new System.IO.FileInfo(openFileDialog.FileName);

           string strFileName = fInfo.Name;

           string strFilePath = fInfo.DirectoryName;

           textBoxPath.Text = strFilePath + strFileName;
            // Process input if the user clicked OK.
           
           
            
        }
    }
}
