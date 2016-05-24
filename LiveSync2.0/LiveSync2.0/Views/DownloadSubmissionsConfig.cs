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
    public partial class DownloadSubmissionsConfig : UserControl
    {
        DateTime start, end;
        int check = 0;
        public DownloadSubmissionsConfig()
        {
            InitializeComponent();
        }

        private void saveLocalBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(saveLocalBtn.Checked)
            {
                if(check == 0)
                {
                    new DownloadSubmissions();
                }
                else
                {
                    new DownloadSubmissions(this.start,this.end);
                }
            }
            else if(saveODbtn.Checked)
            {
                if (check == 0)
                {
                    new DownloadSubOnedrive().SaveEmail();
                }
                else
                {
                    new DownloadSubOnedrive().SaveEmail(this.start,this.end);
                }
            }

            this.Visible = false;

        }
        public void getData(int val,DateTime start,DateTime end)
        {
            check = val;
            this.start = start;
            this.end = end;
        }
    }
}
