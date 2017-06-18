using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MultiplePaste
{
    class FolderPaster : Paster
    {
        public FolderPaster(List<string> files) : base(files)
        {
        }

        private static void DirectoryCopy(string source, string destination, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(source);
            DirectoryInfo[] dirs = dir.GetDirectories();
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + source);
            }
            //    if (!Directory.Exists(destination))
            //   {
            //       Directory.CreateDirectory(destination);
            //   }
            string dirName = Path.GetFileName(source).TrimEnd(Path.DirectorySeparatorChar);
            string sourceDirName = dirName;
            string folderPath = Path.Combine(destination, sourceDirName);
            Directory.CreateDirectory(folderPath);
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string path = Path.Combine(folderPath, file.Name);

                // Copy the file.
                file.CopyTo(path, false);
            }
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string path = Path.Combine(folderPath, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, path, copySubDirs);
                }
            }

        }

        public override bool paste()
        {
            bool result = true;
            string sourceDirectoryPath = null;
            string destDirectoryPath = getCurrentDirectoryPath();
            List<string> folders = getSelectedFiles();
            foreach(string folderPath in folders)
            {
                sourceDirectoryPath = folderPath;
                DirectoryCopy(sourceDirectoryPath, destDirectoryPath, true);
            }
            return result;
        }
    }
}
