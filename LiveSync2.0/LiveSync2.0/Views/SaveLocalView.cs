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
    public partial class SaveLocalView : UserControl
    {
        public SaveLocalView()
        {
            InitializeComponent();
        }
        private void NextsaveBtn_Click(object sender, EventArgs e)
        {
            

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
           
        }

        private void NextsaveBtn_Click_1(object sender, EventArgs e)
        {


            ////////////////////////////////////////////////

            if (dateCbtn.Checked)
            {
                DateTime start = dateTimePicker1.Value;
                DateTime end = dateTimePicker2.Value;
                new DownloadEmails(start, end);
            }
            else
            {
                new DownloadEmails();
            }

            Globals.ThisAddIn.saveFilesPaneLocal.Visible = false;
        }

        private void dateCbtn_CheckedChanged_1(object sender, EventArgs e)
        {
            if (dateGBOX.Visible == false)
                dateGBOX.Visible = true;
            else
                dateGBOX.Visible = false;
        }
    }
}
