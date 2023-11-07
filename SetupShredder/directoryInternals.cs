using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SetupShredder;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace SetupShredder
{
    public partial class mainWindow
    {
        public Boolean directoryIsValid = false;
        private void directory_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(directory_textBox.Text) == true)
            {
                logSS((directory_textBox.Text + " is valid"));
                directory_validationLabel.ForeColor = Color.Green;
                directory_validationLabel.Text = "Valid";
                directoryIsValid = true;
                shredder_runButton.Enabled = true;
            }
            else if (Directory.Exists(directory_textBox.Text) == false)
            {
                directory_validationLabel.ForeColor = Color.Red;
                directory_validationLabel.Text = "Invalid";
                directoryIsValid = false;
                shredder_runButton.Enabled = false;
            }
        }

        private void directory_browsePathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            directory_textBox.Text = dialog.SelectedPath;
        }
    }
}
