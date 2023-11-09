using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

using SetupShredder;
using System.IO;

namespace SetupShredder
{
    public partial class mainWindow
    {
        private void keywords_addButton_Click(object sender, EventArgs e)
        {
            if (!keywords_listbox.Items.Contains(keywords_textbox.Text))
            {
                keywords_listbox.Items.Add(keywords_textbox.Text);
                logSS("Added '" + keywords_textbox.Text + "' to keywords Listbox");
            }
            else
            {
                logSS("Cannot add empty or already existing keywords");
            }
        }

        private void keywords_removeButton_Click(object sender, EventArgs e)
        {
            keywords_listbox.Items.Remove(keywords_listbox.SelectedItem);
            logSS("Removed '" + keywords_listbox.SelectedItem + "' from keywords Listbox");
        }

        private void keywords_removeAllButton_Click(object sender, EventArgs e)
        {
            keywords_listbox.Items.Clear();
            keywords_listbox.Items.AddRange(new object[] { // Was too lazy to make it work on this version without keywords, a period works as every file must be defined with a . with its filetype following.
            "."
            });
            logSS("Removed all items from keywords Listbox");
        }

        private void keywords_resetButton_Click(object sender, EventArgs e)
        {
            string[] defaultLines = File.ReadAllLines(defaultPath);
            // Just copied from the Designer file, GOATED for resetting shit to default
            keywords_listbox.Items.Clear();
            foreach (string line in defaultLines)
            {
                keywords_listbox.Items.Add(line);
            }
            logSS("Reset keywords to default");
        }

        private void keywords_setDefaultKeywordButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(defaultPath, string.Empty); // Overwrite the file so it can update only current keywords
            Array.ForEach(keywords_listbox.Items.Cast<string>().ToArray(), updateDefault); // Change items to a string, then to an array to update to the default file
            logSS("Set keywords");
        }

        private void keywords_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            logSS("Selected '" + keywords_listbox.SelectedItem + "' keyword");
        }
    }
}
