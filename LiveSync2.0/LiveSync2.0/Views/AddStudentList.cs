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
    public partial class AddStudentList : Form
    {
        public AddStudentList()
        {
            InitializeComponent();
        }

        private void cancelBTn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
