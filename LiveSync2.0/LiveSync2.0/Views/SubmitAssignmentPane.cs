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
    public partial class SubmitAssignmentPane : UserControl
    {
        string  attachment = "";
        public SubmitAssignmentPane()
        {
            InitializeComponent();
        }

        private void submitBTn_Click(object sender, EventArgs e)
        {
            bool final = true;
            if(attachment == "")
            {
                MessageBox.Show("Attach Submission File");
                final = false;
            }
            if(nametxt.Text == "")
            {
                MessageBox.Show("Add Name");
                final = false;
            }
            if(erollmenttxt.Text == "")
            {
                MessageBox.Show("Add Enrollment Number");
                final = false;
            }
            if(final)
            {
                new SubmitAssingment().uploadAssignment(nametxt.Text + "\n" + erollmenttxt.Text, descrichtxt.Text, attachment);
                this.Dispose();
            }
        }

        private void CancelBTn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                attachment = openFileDialog1.FileName;
            }
        }
    }
}
