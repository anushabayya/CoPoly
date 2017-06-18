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
            bool result;
            List<string> filePath = new List<string>();
            List<string> folderPath = new List<string>();
            List<string> selectedFiles = getSelectedFiles();
            foreach(string path in selectedFiles)
            {
                var ext = System.IO.Path.GetExtension(path);
                if (ext == String.Empty)
                    folderPath.Add(path);
                else
                    filePath.Add(path);
            }
            if(filePath.Count != 0)
            {
                Paster pasteObj = new FilePaster(filePath);
                result = pasteObj.paste();
            }
            if(folderPath.Count != 0)
            {
                Paster pasteObj = new FolderPaster(folderPath);
                result = pasteObj.paste();
            }
        }

        public List<string> getSelectedFiles()
        {
            int index = 0;
            List<string> selectedFile = new List<string>();
            foreach(int iterator in FilePath.SelectedIndices)
            {
                string item = FilePath.Items[iterator].ToString();
                selectedFile.Add(item);
                index++;
            }
            return selectedFile;
        }
    }
}
