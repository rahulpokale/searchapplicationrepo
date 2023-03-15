namespace SearchApplication
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.folderNameTextBox = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.Label();
            this.folderPath = new System.Windows.Forms.Label();
            this.includeSubFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.searchingFilepaths_lbl = new System.Windows.Forms.Label();
            this.listOfFiles_listView = new System.Windows.Forms.ListView();
            this.folderInSearch_Lbl = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.AccessibleName = "                 ";
            this.filenameTextBox.Location = new System.Drawing.Point(187, 73);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(468, 22);
            this.filenameTextBox.TabIndex = 1;
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.Location = new System.Drawing.Point(187, 131);
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.Size = new System.Drawing.Size(468, 22);
            this.folderNameTextBox.TabIndex = 2;
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(33, 73);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(113, 16);
            this.fileName.TabIndex = 3;
            this.fileName.Text = "Enter the filename";
            // 
            // folderPath
            // 
            this.folderPath.AutoSize = true;
            this.folderPath.Location = new System.Drawing.Point(36, 131);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(133, 16);
            this.folderPath.TabIndex = 4;
            this.folderPath.Text = "Enter the folder name";
            // 
            // includeSubFolderCheckBox
            // 
            this.includeSubFolderCheckBox.AutoSize = true;
            this.includeSubFolderCheckBox.Checked = true;
            this.includeSubFolderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeSubFolderCheckBox.Location = new System.Drawing.Point(187, 172);
            this.includeSubFolderCheckBox.Name = "includeSubFolderCheckBox";
            this.includeSubFolderCheckBox.Size = new System.Drawing.Size(141, 20);
            this.includeSubFolderCheckBox.TabIndex = 5;
            this.includeSubFolderCheckBox.Text = "Include sub folders";
            this.includeSubFolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.Green;
            this.start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.Color.White;
            this.start_btn.Location = new System.Drawing.Point(187, 213);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(103, 36);
            this.start_btn.TabIndex = 6;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.Gray;
            this.stop_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop_btn.Enabled = false;
            this.stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_btn.ForeColor = System.Drawing.Color.White;
            this.stop_btn.Location = new System.Drawing.Point(328, 213);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(99, 36);
            this.stop_btn.TabIndex = 7;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // searchingFilepaths_lbl
            // 
            this.searchingFilepaths_lbl.AutoSize = true;
            this.searchingFilepaths_lbl.Location = new System.Drawing.Point(184, 252);
            this.searchingFilepaths_lbl.Name = "searchingFilepaths_lbl";
            this.searchingFilepaths_lbl.Size = new System.Drawing.Size(0, 16);
            this.searchingFilepaths_lbl.TabIndex = 8;
            // 
            // listOfFiles_listView
            // 
            this.listOfFiles_listView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listOfFiles_listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfFiles_listView.GridLines = true;
            this.listOfFiles_listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listOfFiles_listView.HideSelection = false;
            this.listOfFiles_listView.LabelWrap = false;
            this.listOfFiles_listView.Location = new System.Drawing.Point(39, 290);
            this.listOfFiles_listView.MinimumSize = new System.Drawing.Size(100, 100);
            this.listOfFiles_listView.Name = "listOfFiles_listView";
            this.listOfFiles_listView.ShowGroups = false;
            this.listOfFiles_listView.Size = new System.Drawing.Size(667, 266);
            this.listOfFiles_listView.TabIndex = 9;
            this.listOfFiles_listView.UseCompatibleStateImageBehavior = false;
            this.listOfFiles_listView.UseWaitCursor = true;
            this.listOfFiles_listView.View = System.Windows.Forms.View.Details;
            // 
            // folderInSearch_Lbl
            // 
            this.folderInSearch_Lbl.AutoSize = true;
            this.folderInSearch_Lbl.Location = new System.Drawing.Point(36, 262);
            this.folderInSearch_Lbl.Name = "folderInSearch_Lbl";
            this.folderInSearch_Lbl.Size = new System.Drawing.Size(103, 16);
            this.folderInSearch_Lbl.TabIndex = 10;
            this.folderInSearch_Lbl.Text = "Folder in search";
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.Silver;
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.Black;
            this.clear_btn.Location = new System.Drawing.Point(478, 213);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(99, 36);
            this.clear_btn.TabIndex = 11;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Visible = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "  ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 588);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.folderInSearch_Lbl);
            this.Controls.Add(this.listOfFiles_listView);
            this.Controls.Add(this.searchingFilepaths_lbl);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.includeSubFolderCheckBox);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.folderNameTextBox);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.TextBox folderNameTextBox;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label folderPath;
        private System.Windows.Forms.CheckBox includeSubFolderCheckBox;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Label searchingFilepaths_lbl;
        private System.Windows.Forms.ListView listOfFiles_listView;
        private System.Windows.Forms.Label folderInSearch_Lbl;
        private System.Windows.Forms.Button clear_btn;
    }
}

