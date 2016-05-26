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
    public partial class UploadAssignment : UserControl
    {
        private string file;
        public UploadAssignment()
        {
            InitializeComponent();
        }

        private void CancelAssignBTn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void UploadassignBtn_Click(object sender, EventArgs e)
        {
            Boolean ok = true;
            if(file == "")
            {
                MessageBox.Show("Attachment Assignment File");
                ok = false;
            }
            if(assignNameTxt.Text == "")
            {
                MessageBox.Show("Add Assignment name");
                ok = false;
            }
            if(deadlineDatePick.Value == null)
            {

                MessageBox.Show("Confirm Deadline");
                ok = false;
            }
            if (ok)
            {
                new Models.UploadAssignment().uploadAssignment(assignNameTxt.Text, assignBodytxt.Text, deadlineDatePick.Value, file);
                Globals.ThisAddIn.uploadssignmentPane.Visible = false;
            }
        }

        private void BrowsefileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
            }
        }
    }
}
