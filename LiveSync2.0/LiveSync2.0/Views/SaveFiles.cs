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
    public partial class SaveFiles : UserControl
    {
        public SaveFiles()
        {
            InitializeComponent();
        }

        private void NextsaveBtn_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.saveFilesOneDrive.Visible = false;
            Globals.ThisAddIn.saveFilesPaneLocal.Visible = false;
            Globals.ThisAddIn.saveLocalView.Visible = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void groupCBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (classCBOX.Visible == false)
                classCBOX.Visible = true;
            else
                classCBOX.Visible = false;
        }

        private void dateCbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dateGBOX.Visible == false)
                dateGBOX.Visible = true;
            else
                dateGBOX.Visible = false;
        }
    }
}
