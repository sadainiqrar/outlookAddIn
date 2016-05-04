using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSync2._0.Views
{
    public partial class SaveLocalView : UserControl
    {
        public SaveLocalView()
        {
            InitializeComponent();
        }

        private void CancelsaveBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void defaultsaveRBTN_CheckedChanged(object sender, EventArgs e)
        {
            customPathtxt.Visible = false;
            folderComboBox.Visible = false;
            BrowseFolderBTn.Visible = false;
        }

        private void liveSyncRBTN_CheckedChanged(object sender, EventArgs e)
        {
            customPathtxt.Visible = false;
            BrowseFolderBTn.Visible = false;
            folderComboBox.Visible = true;
        }

        private void CustomSaveBtn_CheckedChanged(object sender, EventArgs e)
        {
            customPathtxt.Visible = true;
            BrowseFolderBTn.Visible = true;
            folderComboBox.Visible = false;
        }
    }
}
