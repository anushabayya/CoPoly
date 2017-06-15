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
    }
}
