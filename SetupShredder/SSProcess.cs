using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using SetupShredder;
using System.IO;
using Microsoft.VisualBasic.FileIO;


namespace SetupShredder
{
    public partial class mainWindow
    {
        // ------- SHREDDER RUN BUTTON ----------
        private void shredder_runButton_Click(object sender, EventArgs e)
        {
            // Turn keywords into usable array for foreach
            string[] keywordsArray = keywords_listbox.Items.Cast<string>().ToArray();
            try
            {
                logSS("Attempting to shred some installers...");
                shredder_filesListBox.Items.Clear();
                var files = Directory.GetFiles(directory_textBox.Text, "*.*", System.IO.SearchOption.TopDirectoryOnly);
                List<string> filteredFiles = new List<string>();

                foreach(string keyword in keywordsArray)
                {
                    filteredFiles.AddRange(files.Where(s => s.Contains(keyword)));
                }

                int fileCount = filteredFiles.Count();

                if(fileCount >= 1)
                {
                    logSS("Found " + fileCount + " files, writing to logStorage.");
                    foreach(string item in filteredFiles)
                    {
                        if(options_logFilesToStorageButton.Checked == true)
                        {
                            updateLogStorage(item);
                        }
                        shredder_filesListBox.Items.Add(item);
                    }
                }
                else if(fileCount == 0)
                {
                    logSS("Found no files with the keywords: '" + keywords_listbox.Items + "'");
                }
                
            }
            catch (Exception ex)
            {
                logSS("Shredder run error:" + ex.Message);
            }
        }

        // --------- OPTIONS BUTTON ----------
        public Boolean optionsToggle = false;
        private void shredder_optionsButton_Click(object sender, EventArgs e)
        {
            if(optionsToggle == false)
            {
                optionsToggle = true;
                logSS("Opening options panel...");
                shredder_optionsPanel.Visible = true;
                shredder_optionsButton.BackColor = Color.LightGray;
            } 
            else
            {
                optionsToggle = false;
                logSS("Closing options panel...");
                shredder_optionsPanel.Visible = false;
                shredder_optionsButton.BackColor = Color.White;
            }
            
        }

        private void option_resetDefaultToDefaultButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(defaultPath, string.Empty);
            updateDefault("Setup\nInstall\nInstaller");
            logSS("Reset keywords to default");
        }

        public string selectedFile = "";
        public int selectedFileIndex = 0;
        // ------- FILES LIST SELECTION HANDLER -------------
        private void shredder_filesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shredder_filesListBox.SelectedIndex != -1)
            {
                selectedFileIndex = shredder_filesListBox.SelectedIndex;
            selectedFile = shredder_filesListBox.SelectedItem.ToString();
            logSS("Selected '" + selectedFile + "'");
            }
            else
            {
                selectedFileIndex = -1;
                selectedFile = "";
            }
        }

        // ------- GO TO FILE BUTTON ------------
        private void shredder_gotofileButton_Click(object sender, EventArgs e)
        {
            if(File.Exists(selectedFile) == true)
            {
                logSS("Opening explorer to '" + selectedFile + "'");
                try
                {
                    string argument = "/select, \"" + selectedFile + "\"";
                    System.Diagnostics.Process.Start("explorer.exe", argument);
                } 
                catch (Exception ex)
                {
                    Console.WriteLine("Error (GoToFile) : " + ex.Message);
                }
            }
            else
            {
                logSS("You must select a valid file in the list");
            }
        }
        // --------- DELETE BUTTON ----------
        private void shredder_deleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFile) && selectedFileIndex >= 0)
            {
                logSS("Deleting '" + selectedFile + "'");
                if(options_sendToBinButton.Checked == true)
                {
                    FileSystem.DeleteFile(selectedFile, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                } else if (options_sendToBinButton.Checked == false)
                {
                    FileSystem.DeleteFile(selectedFile, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
                }
                shredder_filesListBox.Items.RemoveAt(selectedFileIndex);
            }
            else
            {
                logSS("You must select a valid file in the list");
            }
        }

    }
}
