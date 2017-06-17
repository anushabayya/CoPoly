using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MultiplePaste
{
    class Paster
    {
        private string[] selectedFiles;

        public Paster(string[] files)
        {
            selectedFiles = files ;
        }
  
        public string[] getSelectedFiles()
        {
            return selectedFiles;
        }

        public string getCurrentDirectoryPath()
        {
            string path = null;
            path = System.IO.Directory.GetCurrentDirectory();
            return path;
        }

        public bool pasteFiles()
        {
            bool result = true;
            string filename = null,destFile = null;
            string currentDirectoryPath = getCurrentDirectoryPath();
            string[] files = getSelectedFiles();
            foreach(string sourcefilePath in files)
            {
                filename = Path.GetFileName(sourcefilePath);
                destFile = Path.Combine(currentDirectoryPath, filename);
                File.Copy(sourcefilePath, destFile);
            }
            return result;
        }
    }
}
