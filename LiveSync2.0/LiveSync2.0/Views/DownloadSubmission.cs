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
    }
}
