using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Son
{
    public partial class SP_Student : Form
    {
        public SP_Student()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.sp_StudentTableAdapter ta = new DataSet1TableAdapters.sp_StudentTableAdapter();
            DataGridView1.DataSource = ta.GetSp();
        }

        private void turn_back_Click(object sender, EventArgs e)
        {
            Form_Login form1sec = new Form_Login();
            form1sec.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {

            DialogResult result2 = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
            if (result2 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("No Exit!!");
            }
        }
    }
}
