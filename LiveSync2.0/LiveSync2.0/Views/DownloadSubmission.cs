using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveSync2._0.Models;

namespace LiveSync2._0.Views
{
    public partial class DownloadSubmission : UserControl
    {
        public DownloadSubmission()
        {
            InitializeComponent();
        }

        private void CancelBTn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void cusRBTN_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void defRBTN_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void saveSubBTn_Click(object sender, EventArgs e)
        {
            if (defRBTN.Checked)
            {
                new DownloadSubmissionsConfig().getData(0, DateTime.Now, DateTime.Now);
                
            }
            if(cusRBTN.Checked)
            {
                new DownloadSubmissionsConfig().getData(1, dateTimePicker1.Value, dateTimePicker2.Value);
                
            }
            Globals.ThisAddIn.downloadSubmissionsPane.Visible = false;
           Globals.ThisAddIn.downloadSubmissionsConfig.Visible = true;
        }
    }
}
