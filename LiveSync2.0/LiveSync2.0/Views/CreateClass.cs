using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSync2._0.Views
{
    public partial class CreateClass : Form
    {
        public CreateClass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddListBtn_Click(object sender, EventArgs e)
        {
            new AddStudentList().Visible = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void CreateClass_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AddListBtn.Visible = true;
            AddExcelBtn.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            AddListBtn.Visible = false;
            AddExcelBtn.Visible = true;
        }
    }
}
