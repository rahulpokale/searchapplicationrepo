using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SearchApplication
{
    public partial class Form1 : Form
    {
        private bool continueSearch = true;
        private string fileName_userInput = "";
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            continueSearch = true;
            count = 0;
            List<string> directoryList = new List<string>();
            try
            {
                fileName_userInput = filenameTextBox.Text;
                listOfFiles_listView.Clear();
                listOfFiles_listView.Columns.Add("List of files found").Width = 1000;
                clear_btn.Visible = false;
                stop_btn.Enabled = true;
                stop_btn.BackColor = Color.OrangeRed;

                // Validate the user input folder path text to search
                if (string.IsNullOrWhiteSpace(folderNameTextBox.Text))
                {
                    MessageBox.Show("Please provide the proper folder path to search !");
                    return;
                }

                // Validate the user input file name text to search
                if (string.IsNullOrWhiteSpace(fileName_userInput))
                {
                    MessageBox.Show("Please provide the file name to search !");
                    return;
                }

                //Running the search in a new thread
                new Thread(() =>
                {
                    SearchFiles(folderNameTextBox.Text);
                }).Start();

                folderInSearch_Lbl.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //To search the files for the User given Input
        private void SearchFiles(string directoryPath)
        {
            //Finding the directories
            DirectoryInfo directory = new DirectoryInfo(directoryPath);
            if (directory.Exists)
            {
                SetText(directory.FullName);
                try
                {
                    //Getting the files in the directory and loop through all the file
                    foreach (var file in directory.GetFiles())
                    {
                        if (file.Exists)
                        {
                            //Stop search when click on stop button
                            if (!continueSearch)
                            {
                                break;
                            }
                            if (file.Name.StartsWith(fileName_userInput)) // match with the user given filename.
                            {
                                // Adding the Matching file name paths to List view
                                AddToListView(file.FullName);
                            }
                        }
                    }
                }
                catch (UnauthorizedAccessException uex)
                {
                    Console.WriteLine(uex);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                if (includeSubFolderCheckBox.Checked)
                {
                    foreach (var subDirectory in directory.GetDirectories())
                    {
                        //Stop search when click on stop button
                        if (!continueSearch)
                        {
                            break;
                        }

                        if (!subDirectory.Name.ToLower().StartsWith("$recycle.bin")) // COnditon is to skip the recycle bin folders
                        {
                            SearchFiles(subDirectory.FullName);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please provide the proper folder path to search !");
                return;
            }
        }

        //To Invoke the List view in order to avoid the Cross-thread operation error
        private void AddToListView(string text)
        {
            if (listOfFiles_listView.InvokeRequired)
            {
                listOfFiles_listView.Invoke(new Action<string>(AddToListView), text);
            }
            else
            {
                count++;
                listOfFiles_listView.Items.Add(new ListViewItem(new[] { count + ". " + text }));
            }
        }

        //To Invoke the Label in order to avoid the Cross-thread operation error
        private void SetText(string text)
        {
            if (folderInSearch_Lbl.InvokeRequired)
            {
                folderInSearch_Lbl.Invoke(new Action<string>(SetText), text);
            }
            else
            {
                folderInSearch_Lbl.Text = text;
            }
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            continueSearch = false;
            clear_btn.Visible = true;
            stop_btn.Enabled = false;
            stop_btn.BackColor = Color.Gray;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            //Reset all the textbox, checkbox and lables
            filenameTextBox.ResetText();
            folderNameTextBox.ResetText();
            includeSubFolderCheckBox.Checked = true;
            listOfFiles_listView.Clear();
            folderInSearch_Lbl.ResetText();
            clear_btn.Visible = false;
        }
    }
}
