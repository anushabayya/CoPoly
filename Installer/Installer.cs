using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Installer
{
    public partial class Installer : Form
    {
        public Installer()
        {
            InitializeComponent();
        }

        private void FileBrowse(object sender, EventArgs e)
        {
            //here open the file browse dialog for user
            string folderName;

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                //Here update the text control with the obtained folder path
                folderName = folderDialog.SelectedPath;

                //show it to the user in the text box
                this.FOLDER_BASE_PATH_TEXT_BOX.Text = folderName;
            }
        }

        private void InstallMultiPaste(object sender, EventArgs e)
        {
            //get the folder path here
            string folderPath = this.FOLDER_BASE_PATH_TEXT_BOX.Text;

            String formattedPath = FormatFolderPath(folderPath);

            //check for the folder availability here
            bool folderExists = Directory.Exists(folderPath);

            formattedPath = Path.Combine(formattedPath, "MultiplePaste.exe");

            if (!folderExists)
            {
                MessageBox.Show("Folder doesn't exist", "Folder error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //The folder is valid
            //Thus copy our multi paste exe to the specified folder
            bool exeCopied = CopyExeToFolder();
            if (exeCopied)
            {
                //add the folder entry to the registry
                RegistryKey myKey = Registry.ClassesRoot.CreateSubKey("Directory\\Background\\shell\\Multiple Paste\\command");

                try
                {
                    if (myKey != null)
                    {
                        myKey.SetValue("", formattedPath);
                        myKey.Close();
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("Installed successfully!", "Installation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("There was an error during installation.", "Installation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
                
        private bool CopyExeToFolder()
        {
            bool retVal = false;

            //try to copy the file here
            try
            {
                String sourceFile = "./../../exe/MultiplePaste.exe";

                string destinationFile = this.FOLDER_BASE_PATH_TEXT_BOX.Text;
                string fileName = "MultiplePaste.exe";

                destinationFile = Path.Combine(destinationFile, fileName);
                string sourceFullPath = Path.GetFullPath(sourceFile);
                File.Copy(sourceFile, destinationFile, true);
                retVal = true;
            }
            catch(UnauthorizedAccessException)
            {
                MessageBox.Show("You don't have required permissions to the installation folder.", "Copy error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("The installation folder path is too long. Make sure it doesn't exceed 260 characters.", "Copy error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("The installation directory doesn't exist. ", "Copy error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Fatal error. contact our support team.", "Folder error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return retVal;
        }
        private String FormatFolderPath(string folderPath)
        {
            //we need to split the name with '\' as delimiter
            
            String[] folderPathStringArray = folderPath.Split('\\');
            String retString = "";

            //loop through the array and append double slashes in between
            for (int i = 0; i < folderPathStringArray.Length; i++)
            {
                if (folderPathStringArray[i].Length == 0)
                {
                    retString += "\\";
                    continue;
                }
                retString += folderPathStringArray[i];
                if (i != folderPathStringArray.Length - 1)
                    retString += "\\\\";
            }

            return retString;
        }
    }
}
