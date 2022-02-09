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
    public partial class Form_Course : Form
    {
        public Form_Course()
        {
            InitializeComponent();
        }


        private void Form_Course_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.DepartmentTableAdapter ta = new DataSet1TableAdapters.DepartmentTableAdapter();
            dataGridView2.DataSource = ta.GetDepartment();

        }

        private void Search_Click(object sender, EventArgs e)
        {

            DataSet1TableAdapters.CourseTableAdapter ta = new DataSet1TableAdapters.CourseTableAdapter();
            dataGridView1.DataSource = ta.GetCourse();
            int a = dataGridView1.Rows.Count - 1;
            TotalCourses.Text = "Total Course: " + a;
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

        private void turn_back_Click(object sender, EventArgs e)
        {
            Form_Login form1sec = new Form_Login();
            form1sec.Show();
            this.Hide();
        }

        private void Add_Course_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet1TableAdapters.CourseTableAdapter ta = new DataSet1TableAdapters.CourseTableAdapter();
                ta.AddCourse(Convert.ToInt32(textBox1.Text), labelText.Text, hours.SelectedIndex + 1);
                dataGridView1.DataSource = ta.GetCourse();
                labelText.Clear();
                hours.ResetText();

                int a = dataGridView1.Rows.Count - 1;
                TotalCourses.Text = "Total Course: " + a;
            }

            catch
            {
                MessageBox.Show("The department with this number was not found!");
            }
        }
        public void getirCourse()
        {
            DataSet1TableAdapters.CourseTableAdapter taStudent = new DataSet1TableAdapters.CourseTableAdapter();
            dataGridView1.DataSource = taStudent.GetCourse();
        }



        private void Remove_Course_Click(object sender, EventArgs e)
        {

                DialogResult result1 = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    DataGridViewRow select_row = dataGridView1.CurrentRow;
                    int cNo = Convert.ToInt16(select_row.Cells["course_id"].Value.ToString());
                    DataSet1TableAdapters.CourseTableAdapter ta = new DataSet1TableAdapters.CourseTableAdapter();
                    ta.DeleteCourse(cNo);
                    getirCourse();
                int a = dataGridView1.Rows.Count - 1;
                TotalCourses.Text = "Total Course: " + a;
            }
                else
                {
                    MessageBox.Show("Not Deleted !");
                }

            
        }
    }
}
