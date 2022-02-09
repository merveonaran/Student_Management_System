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
    public partial class Form_Department : Form
    {
        public Form_Department()
        {
            InitializeComponent();
            DataSet1TableAdapters.StudentTableAdapter ta = new DataSet1TableAdapters.StudentTableAdapter();
            dataGridView1.DataSource = ta.GetStudent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet1TableAdapters.DepartmentTableAdapter ta = new DataSet1TableAdapters.DepartmentTableAdapter();
            dataGridView2.DataSource = ta.GetDepartment();
        }

        private void Add_Course_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet1TableAdapters.DepartmentTableAdapter ta = new DataSet1TableAdapters.DepartmentTableAdapter();
                ta.AddDepartment(departmentName.Text, Convert.ToInt32(id.Text));
                dataGridView2.DataSource = ta.GetDepartment();

                departmentName.ResetText();
                id.Clear();

                int a = dataGridView2.RowCount - 1;
                TotalDepatment.Text = "Total Department: " + a;
            }

            catch
            {
                MessageBox.Show("Student with this number not found!");
            }
            
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


        public void getirDepartment()
        {
            DataSet1TableAdapters.DepartmentTableAdapter taDepartment = new DataSet1TableAdapters.DepartmentTableAdapter();
            dataGridView2.DataSource = taDepartment.GetDepartment();
        }


        private void Remove_Course_Click(object sender, EventArgs e)
        {
                DialogResult result1 = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    DataGridViewRow select_row = dataGridView2.CurrentRow;
                    int dNo = Convert.ToInt16(select_row.Cells["department_id"].Value.ToString());
                    DataSet1TableAdapters.DepartmentTableAdapter ta = new DataSet1TableAdapters.DepartmentTableAdapter();
                    ta.DeleteDepartment(dNo);
                    getirDepartment();
                int a = dataGridView2.RowCount - 1;
                TotalDepatment.Text = "Total Department: " + a;
            }
                else
                {
                    MessageBox.Show("Not Deleted !");
                }
            
            
        }

        private void Search_Click(object sender, EventArgs e)
        {

            DataSet1TableAdapters.DepartmentTableAdapter taDepartment = new DataSet1TableAdapters.DepartmentTableAdapter();
            dataGridView2.DataSource = taDepartment.GetDepartment();
            int a  = dataGridView2.RowCount - 1;
            TotalDepatment.Text = "Total Department: " + a;
        }

  
    }
}
