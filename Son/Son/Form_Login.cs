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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Giriş_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Student form1sec = new Form_Student();
            form1sec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Course form1sec = new Form_Course();
            form1sec.Show();
            this.Hide();
        }

        private void Department_Click(object sender, EventArgs e)
        {
            Form_Department form1sec = new Form_Department();
            form1sec.Show();
            this.Hide();
        }

        private void Teacher_Click(object sender, EventArgs e)
        {
            Teacher form1sec = new Teacher();
            form1sec.Show();
            this.Hide();

        }

        private void Score_Click(object sender, EventArgs e)
        {
            Form_Score form1sec = new Form_Score();
            form1sec.Show();
            this.Hide();
        }


        private void Views_Click(object sender, EventArgs e)
        {
            Views form1sec = new Views();
            form1sec.Show();
            this.Hide();
        }


        private void Stored_Procedure_Click(object sender, EventArgs e)
        {
            SP_Student form1sec = new SP_Student();
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

        private void Student_Click(object sender, EventArgs e)
        {
            Form_Student form1sec = new Form_Student();
            form1sec.Show();
            this.Hide();
        }
    }
}
