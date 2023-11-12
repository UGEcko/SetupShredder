
namespace SetupShredder
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.basePanel = new System.Windows.Forms.Panel();
            this.shredder_optionsPanel = new System.Windows.Forms.Panel();
            this.keywords_setDefaultKeywordButton = new System.Windows.Forms.Button();
            this.option_resetDefaultToDefaultButton = new System.Windows.Forms.Button();
            this.options_sendToBinButton = new System.Windows.Forms.CheckBox();
            this.options_logFilesToStorageButton = new System.Windows.Forms.CheckBox();
            this.options_label = new System.Windows.Forms.Label();
            this.shredder_filesListBox = new System.Windows.Forms.ListBox();
            this.directory_browsePathButton = new System.Windows.Forms.Button();
            this.shredder_optionsButton = new System.Windows.Forms.Button();
            this.shredder_runButton = new System.Windows.Forms.Button();
            this.keywords_resetButton = new System.Windows.Forms.Button();
            this.keywords_removeAllButton = new System.Windows.Forms.Button();
            this.keywords_removeButton = new System.Windows.Forms.Button();
            this.keywords_addButton = new System.Windows.Forms.Button();
            this.keywords_textbox = new System.Windows.Forms.TextBox();
            this.keywords_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keywords_label = new System.Windows.Forms.Label();
            this.directory_validationLabel = new System.Windows.Forms.Label();
            this.directory_textBox = new System.Windows.Forms.TextBox();
            this.shredder_gotofileButton = new System.Windows.Forms.Button();
            this.shredder_deleteButton = new System.Windows.Forms.Button();
            this.SetupShredderLabel = new System.Windows.Forms.Label();
            this.basePanel.SuspendLayout();
            this.shredder_optionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.Controls.Add(this.shredder_optionsPanel);
            this.basePanel.Controls.Add(this.shredder_filesListBox);
            this.basePanel.Controls.Add(this.directory_browsePathButton);
            this.basePanel.Controls.Add(this.shredder_optionsButton);
            this.basePanel.Controls.Add(this.shredder_runButton);
            this.basePanel.Controls.Add(this.keywords_resetButton);
            this.basePanel.Controls.Add(this.keywords_removeAllButton);
            this.basePanel.Controls.Add(this.keywords_removeButton);
            this.basePanel.Controls.Add(this.keywords_addButton);
            this.basePanel.Controls.Add(this.keywords_textbox);
            this.basePanel.Controls.Add(this.keywords_listbox);
            this.basePanel.Controls.Add(this.label1);
            this.basePanel.Controls.Add(this.keywords_label);
            this.basePanel.Controls.Add(this.directory_validationLabel);
            this.basePanel.Controls.Add(this.directory_textBox);
            this.basePanel.Controls.Add(this.shredder_gotofileButton);
            this.basePanel.Controls.Add(this.shredder_deleteButton);
            this.basePanel.Location = new System.Drawing.Point(12, 12);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(776, 426);
            this.basePanel.TabIndex = 0;
            // 
            // shredder_optionsPanel
            // 
            this.shredder_optionsPanel.BackColor = System.Drawing.Color.LightGray;
            this.shredder_optionsPanel.Controls.Add(this.keywords_setDefaultKeywordButton);
            this.shredder_optionsPanel.Controls.Add(this.option_resetDefaultToDefaultButton);
            this.shredder_optionsPanel.Controls.Add(this.options_sendToBinButton);
            this.shredder_optionsPanel.Controls.Add(this.options_logFilesToStorageButton);
            this.shredder_optionsPanel.Controls.Add(this.options_label);
            this.shredder_optionsPanel.Location = new System.Drawing.Point(374, 3);
            this.shredder_optionsPanel.Name = "shredder_optionsPanel";
            this.shredder_optionsPanel.Size = new System.Drawing.Size(399, 423);
            this.shredder_optionsPanel.TabIndex = 3;
            this.shredder_optionsPanel.Visible = false;
            // 
            // keywords_setDefaultKeywordButton
            // 
            this.keywords_setDefaultKeywordButton.BackColor = System.Drawing.Color.White;
            this.keywords_setDefaultKeywordButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywords_setDefaultKeywordButton.Location = new System.Drawing.Point(8, 360);
            this.keywords_setDefaultKeywordButton.Name = "keywords_setDefaultKeywordButton";
            this.keywords_setDefaultKeywordButton.Size = new System.Drawing.Size(259, 27);
            this.keywords_setDefaultKeywordButton.TabIndex = 22;
            this.keywords_setDefaultKeywordButton.Text = "Set current keywords to default";
            this.keywords_setDefaultKeywordButton.UseVisualStyleBackColor = false;
            this.keywords_setDefaultKeywordButton.Click += new System.EventHandler(this.keywords_setDefaultKeywordButton_Click);
            // 
            // option_resetDefaultToDefaultButton
            // 
            this.option_resetDefaultToDefaultButton.BackColor = System.Drawing.Color.White;
            this.option_resetDefaultToDefaultButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_resetDefaultToDefaultButton.Location = new System.Drawing.Point(8, 393);
            this.option_resetDefaultToDefaultButton.Name = "option_resetDefaultToDefaultButton";
            this.option_resetDefaultToDefaultButton.Size = new System.Drawing.Size(259, 27);
            this.option_resetDefaultToDefaultButton.TabIndex = 21;
            this.option_resetDefaultToDefaultButton.Text = "Reset keywords default to default";
            this.option_resetDefaultToDefaultButton.UseVisualStyleBackColor = false;
            this.option_resetDefaultToDefaultButton.Click += new System.EventHandler(this.option_resetDefaultToDefaultButton_Click);
            // 
            // options_sendToBinButton
            // 
            this.options_sendToBinButton.AutoSize = true;
            this.options_sendToBinButton.Checked = true;
            this.options_sendToBinButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.options_sendToBinButton.Location = new System.Drawing.Point(8, 47);
            this.options_sendToBinButton.Name = "options_sendToBinButton";
            this.options_sendToBinButton.Size = new System.Drawing.Size(290, 17);
            this.options_sendToBinButton.TabIndex = 2;
            this.options_sendToBinButton.Text = "Send deleted files to recycle bin (otherwise permanently)";
            this.options_sendToBinButton.UseVisualStyleBackColor = true;
            // 
            // options_logFilesToStorageButton
            // 
            this.options_logFilesToStorageButton.AutoSize = true;
            this.options_logFilesToStorageButton.Location = new System.Drawing.Point(8, 70);
            this.options_logFilesToStorageButton.Name = "options_logFilesToStorageButton";
            this.options_logFilesToStorageButton.Size = new System.Drawing.Size(160, 17);
            this.options_logFilesToStorageButton.TabIndex = 1;
            this.options_logFilesToStorageButton.Text = "Log found files to fileStorage";
            this.options_logFilesToStorageButton.UseVisualStyleBackColor = true;
            // 
            // options_label
            // 
            this.options_label.AutoSize = true;
            this.options_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options_label.Location = new System.Drawing.Point(3, 0);
            this.options_label.Name = "options_label";
            this.options_label.Size = new System.Drawing.Size(84, 25);
            this.options_label.TabIndex = 0;
            this.options_label.Text = "Options";
            // 
            // shredder_filesListBox
            // 
            this.shredder_filesListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.shredder_filesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shredder_filesListBox.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shredder_filesListBox.FormattingEnabled = true;
            this.shredder_filesListBox.HorizontalScrollbar = true;
            this.shredder_filesListBox.ItemHeight = 20;
            this.shredder_filesListBox.Items.AddRange(new object[] {
            "Files found are listed here. Run Setup Shredder to find files"});
            this.shredder_filesListBox.Location = new System.Drawing.Point(377, 15);
            this.shredder_filesListBox.Name = "shredder_filesListBox";
            this.shredder_filesListBox.ScrollAlwaysVisible = true;
            this.shredder_filesListBox.Size = new System.Drawing.Size(383, 362);
            this.shredder_filesListBox.TabIndex = 17;
            this.shredder_filesListBox.SelectedIndexChanged += new System.EventHandler(this.shredder_filesListBox_SelectedIndexChanged);
            // 
            // directory_browsePathButton
            // 
            this.directory_browsePathButton.BackColor = System.Drawing.Color.White;
            this.directory_browsePathButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directory_browsePathButton.Location = new System.Drawing.Point(6, 50);
            this.directory_browsePathButton.Name = "directory_browsePathButton";
            this.directory_browsePathButton.Size = new System.Drawing.Size(46, 19);
            this.directory_browsePathButton.TabIndex = 16;
            this.directory_browsePathButton.Text = "Browse";
            this.directory_browsePathButton.UseVisualStyleBackColor = false;
            this.directory_browsePathButton.Click += new System.EventHandler(this.directory_browsePathButton_Click);
            // 
            // shredder_optionsButton
            // 
            this.shredder_optionsButton.BackColor = System.Drawing.Color.White;
            this.shredder_optionsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shredder_optionsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.shredder_optionsButton.Location = new System.Drawing.Point(6, 379);
            this.shredder_optionsButton.Name = "shredder_optionsButton";
            this.shredder_optionsButton.Size = new System.Drawing.Size(365, 30);
            this.shredder_optionsButton.TabIndex = 15;
            this.shredder_optionsButton.Text = "Options";
            this.shredder_optionsButton.UseVisualStyleBackColor = false;
            this.shredder_optionsButton.Click += new System.EventHandler(this.shredder_optionsButton_Click);
            // 
            // shredder_runButton
            // 
            this.shredder_runButton.BackColor = System.Drawing.Color.White;
            this.shredder_runButton.Enabled = false;
            this.shredder_runButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shredder_runButton.Location = new System.Drawing.Point(6, 347);
            this.shredder_runButton.Name = "shredder_runButton";
            this.shredder_runButton.Size = new System.Drawing.Size(365, 30);
            this.shredder_runButton.TabIndex = 14;
            this.shredder_runButton.Text = "Run Setup Shredder";
            this.shredder_runButton.UseVisualStyleBackColor = false;
            this.shredder_runButton.Click += new System.EventHandler(this.shredder_runButton_Click);
            // 
            // keywords_resetButton
            // 
            this.keywords_resetButton.BackColor = System.Drawing.Color.White;
            this.keywords_resetButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywords_resetButton.Location = new System.Drawing.Point(6, 302);
            this.keywords_resetButton.Name = "keywords_resetButton";
            this.keywords_resetButton.Size = new System.Drawing.Size(144, 30);
            this.keywords_resetButton.TabIndex = 13;
            this.keywords_resetButton.Text = "Reset";
            this.keywords_resetButton.UseVisualStyleBackColor = false;
            this.keywords_resetButton.Click += new System.EventHandler(this.keywords_resetButton_Click);
            // 
            // keywords_removeAllButton
            // 
            this.keywords_removeAllButton.BackColor = System.Drawing.Color.White;
            this.keywords_removeAllButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywords_removeAllButton.Location = new System.Drawing.Point(6, 269);
            this.keywords_removeAllButton.Name = "keywords_removeAllButton";
            this.keywords_removeAllButton.Size = new System.Drawing.Size(144, 30);
            this.keywords_removeAllButton.TabIndex = 12;
            this.keywords_removeAllButton.Text = "Remove All";
            this.keywords_removeAllButton.UseVisualStyleBackColor = false;
            this.keywords_removeAllButton.Click += new System.EventHandler(this.keywords_removeAllButton_Click);
            // 
            // keywords_removeButton
            // 
            this.keywords_removeButton.BackColor = System.Drawing.Color.White;
            this.keywords_removeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywords_removeButton.Location = new System.Drawing.Point(6, 233);
            this.keywords_removeButton.Name = "keywords_removeButton";
            this.keywords_removeButton.Size = new System.Drawing.Size(144, 30);
            this.keywords_removeButton.TabIndex = 11;
            this.keywords_removeButton.Text = "Remove";
            this.keywords_removeButton.UseVisualStyleBackColor = false;
            this.keywords_removeButton.Click += new System.EventHandler(this.keywords_removeButton_Click);
            // 
            // keywords_addButton
            // 
            this.keywords_addButton.BackColor = System.Drawing.Color.White;
            this.keywords_addButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywords_addButton.Location = new System.Drawing.Point(6, 197);
            this.keywords_addButton.Name = "keywords_addButton";
            this.keywords_addButton.Size = new System.Drawing.Size(144, 30);
            this.keywords_addButton.TabIndex = 10;
            this.keywords_addButton.Text = "Add";
            this.keywords_addButton.UseVisualStyleBackColor = false;
            this.keywords_addButton.Click += new System.EventHandler(this.keywords_addButton_Click);
            // 
            // keywords_textbox
            // 
            this.keywords_textbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywords_textbox.Location = new System.Drawing.Point(6, 170);
            this.keywords_textbox.Name = "keywords_textbox";
            this.keywords_textbox.Size = new System.Drawing.Size(144, 21);
            this.keywords_textbox.TabIndex = 9;
            this.keywords_textbox.Text = "Enter text...";
            // 
            // keywords_listbox
            // 
            this.keywords_listbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.keywords_listbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keywords_listbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywords_listbox.FormattingEnabled = true;
            this.keywords_listbox.ItemHeight = 16;
            this.keywords_listbox.Location = new System.Drawing.Point(156, 170);
            this.keywords_listbox.Name = "keywords_listbox";
            this.keywords_listbox.Size = new System.Drawing.Size(215, 162);
            this.keywords_listbox.TabIndex = 8;
            this.keywords_listbox.SelectedIndexChanged += new System.EventHandler(this.keywords_listbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Directory";
            // 
            // keywords_label
            // 
            this.keywords_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.keywords_label.AutoSize = true;
            this.keywords_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywords_label.Location = new System.Drawing.Point(3, 151);
            this.keywords_label.Name = "keywords_label";
            this.keywords_label.Size = new System.Drawing.Size(59, 16);
            this.keywords_label.TabIndex = 6;
            this.keywords_label.Text = "Keywords";
            // 
            // directory_validationLabel
            // 
            this.directory_validationLabel.AutoSize = true;
            this.directory_validationLabel.BackColor = System.Drawing.Color.Transparent;
            this.directory_validationLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directory_validationLabel.ForeColor = System.Drawing.Color.Red;
            this.directory_validationLabel.Location = new System.Drawing.Point(322, 50);
            this.directory_validationLabel.Name = "directory_validationLabel";
            this.directory_validationLabel.Size = new System.Drawing.Size(49, 19);
            this.directory_validationLabel.TabIndex = 2;
            this.directory_validationLabel.Text = "Invalid";
            // 
            // directory_textBox
            // 
            this.directory_textBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.directory_textBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directory_textBox.Location = new System.Drawing.Point(58, 50);
            this.directory_textBox.Name = "directory_textBox";
            this.directory_textBox.Size = new System.Drawing.Size(258, 21);
            this.directory_textBox.TabIndex = 1;
            this.directory_textBox.Text = "Enter directory path...";
            this.directory_textBox.TextChanged += new System.EventHandler(this.directory_textBox_TextChanged);
            // 
            // shredder_gotofileButton
            // 
            this.shredder_gotofileButton.BackColor = System.Drawing.Color.White;
            this.shredder_gotofileButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shredder_gotofileButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.shredder_gotofileButton.Location = new System.Drawing.Point(377, 379);
            this.shredder_gotofileButton.Name = "shredder_gotofileButton";
            this.shredder_gotofileButton.Size = new System.Drawing.Size(190, 30);
            this.shredder_gotofileButton.TabIndex = 18;
            this.shredder_gotofileButton.Text = "Go to file";
            this.shredder_gotofileButton.UseVisualStyleBackColor = false;
            this.shredder_gotofileButton.Click += new System.EventHandler(this.shredder_gotofileButton_Click);
            // 
            // shredder_deleteButton
            // 
            this.shredder_deleteButton.BackColor = System.Drawing.Color.White;
            this.shredder_deleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shredder_deleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.shredder_deleteButton.Location = new System.Drawing.Point(570, 379);
            this.shredder_deleteButton.Name = "shredder_deleteButton";
            this.shredder_deleteButton.Size = new System.Drawing.Size(190, 30);
            this.shredder_deleteButton.TabIndex = 19;
            this.shredder_deleteButton.Text = "Delete";
            this.shredder_deleteButton.UseVisualStyleBackColor = false;
            this.shredder_deleteButton.Click += new System.EventHandler(this.shredder_deleteButton_Click);
            // 
            // SetupShredderLabel
            // 
            this.SetupShredderLabel.AutoSize = true;
            this.SetupShredderLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupShredderLabel.Location = new System.Drawing.Point(7, 424);
            this.SetupShredderLabel.Name = "SetupShredderLabel";
            this.SetupShredderLabel.Size = new System.Drawing.Size(167, 28);
            this.SetupShredderLabel.TabIndex = 0;
            this.SetupShredderLabel.Text = "Setup Shredder";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.SetupShredderLabel);
            this.Controls.Add(this.basePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "mainWindow";
            this.Text = "Setup Shredder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainWindow_FormClosed);
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.basePanel.ResumeLayout(false);
            this.basePanel.PerformLayout();
            this.shredder_optionsPanel.ResumeLayout(false);
            this.shredder_optionsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Label SetupShredderLabel;
        private System.Windows.Forms.TextBox directory_textBox;
        private System.Windows.Forms.Label directory_validationLabel;
        private System.Windows.Forms.Panel shredder_optionsPanel;
        private System.Windows.Forms.Label keywords_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox keywords_listbox;
        private System.Windows.Forms.Button keywords_removeAllButton;
        private System.Windows.Forms.Button keywords_removeButton;
        private System.Windows.Forms.Button keywords_addButton;
        private System.Windows.Forms.TextBox keywords_textbox;
        private System.Windows.Forms.Button keywords_resetButton;
        private System.Windows.Forms.Button shredder_optionsButton;
        private System.Windows.Forms.Button shredder_runButton;
        private System.Windows.Forms.Label options_label;
        private System.Windows.Forms.Button directory_browsePathButton;
        private System.Windows.Forms.CheckBox options_logFilesToStorageButton;
        private System.Windows.Forms.ListBox shredder_filesListBox;
        private System.Windows.Forms.Button shredder_deleteButton;
        private System.Windows.Forms.Button shredder_gotofileButton;
        private System.Windows.Forms.CheckBox options_sendToBinButton;
        private System.Windows.Forms.Button option_resetDefaultToDefaultButton;
        private System.Windows.Forms.Button keywords_setDefaultKeywordButton;
    }
}

