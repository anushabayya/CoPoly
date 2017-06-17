using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace MultiplePaste
{
    public partial class CoPoly : Form
    {
        public CoPoly()
        {
            InitializeComponent();
        }

        private void CoPoly_Load(object sender, EventArgs e)
        {
            StringCollection files = null;
            if (Clipboard.ContainsFileDropList())
            {
                files = Clipboard.GetFileDropList();
            }
            foreach (string filePath in files)
            {
                FilePath.Items.Add(filePath);
            }
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            string[] selectedFiles = getSelectedFiles();
            Paster pasteObj = new Paster(selectedFiles);
            bool result = pasteObj.pasteFiles();
        }

        public string[] getSelectedFiles()
        {
            int index = 0;
            string[] selectedFile = new string[FilePath.SelectedIndices.Count];
            foreach(int iterator in FilePath.SelectedIndices)
            {
                string item = FilePath.Items[iterator].ToString();
                selectedFile[index] = item;
                index++;
            }
            return selectedFile;
        }
    }
}
