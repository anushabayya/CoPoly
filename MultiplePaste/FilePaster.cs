using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MultiplePaste
{
    class FilePaster : Paster
    {
        public FilePaster(List<string> files) : base(files) { }

        public override bool paste()
        {
            bool result = true;
            string filename = null, destFile = null;
            string currentDirectoryPath = getCurrentDirectoryPath();
            List<string> files = getSelectedFiles();
            foreach (string sourcefilePath in files)
            {
                filename = Path.GetFileName(sourcefilePath);
                destFile = Path.Combine(currentDirectoryPath, filename);
                File.Copy(sourcefilePath, destFile,true);
            }
            return result;
        }
    }
}
