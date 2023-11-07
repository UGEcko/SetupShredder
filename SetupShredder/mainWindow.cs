using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SetupShredder;
using System.IO;


namespace SetupShredder
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            logSS("============== NEW INSTANCE ==============");
            InitializeComponent();
            // Other stuff that can be messed up if not set at runtime
            shredder_optionsButton.BackColor = Color.White;
        }
        
        // Logging application initiations
        private void mainWindow_Load(object sender, EventArgs e)
        {
            logSS("Loaded");
        }

        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            logSS("Closing SetupShredder...");
        }

        private void mainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            logSS("Closed.");
        }







        // Other stuff TBD



    }
}
