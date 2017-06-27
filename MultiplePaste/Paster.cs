using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MultiplePaste
{
    public abstract class Paster
    {
        private List<string> selectedFiles;

        public Paster(List<string> files)
        {
            selectedFiles = files ;
        }
  
        public List<string> getSelectedFiles()
        {
            return selectedFiles;
        }

        public string getCurrentDirectoryPath()
        {
            string path = null;
            path = Directory.GetCurrentDirectory();
            return path;
        }

        public abstract bool paste();
    }
}
