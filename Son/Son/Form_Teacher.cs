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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
            DataSet1TableAdapters.CourseTableAdapter ta = new DataSet1TableAdapters.CourseTableAdapter();
            dataGridView2.DataSource = ta.GetCourse();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet1TableAdapters.TeacherTableAdapter ta = new DataSet1TableAdapters.TeacherTableAdapter();
                ta.AddTeacher(textFName.Text, textLName.Text, phoneText.Text, Convert.ToInt32(textBox1.Text));
                DataGridView1.DataSource = ta.GetTeacher();

                textFName.Clear();
                textLName.Clear();
                phoneText.Clear();
            }

            catch
            {
                MessageBox.Show("Course with this number not found!");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TeacherTableAdapter ta = new DataSet1TableAdapters.TeacherTableAdapter();
            DataGridView1.DataSource = ta.GetTeacher();
            TotalTeacherLabel.Text = "Total Teacher: " + DataGridView1.Rows.Count;
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


        public void getirTeacher()
        {
            DataSet1TableAdapters.TeacherTableAdapter taStudent = new DataSet1TableAdapters.TeacherTableAdapter();
            DataGridView1.DataSource = taStudent.GetTeacher();
        }


        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                DataGridViewRow select_row = DataGridView1.CurrentRow;
                int tNo = Convert.ToInt16(select_row.Cells["teacher_id"].Value.ToString());
                DataSet1TableAdapters.TeacherTableAdapter ta = new DataSet1TableAdapters.TeacherTableAdapter();
                ta.DeleteTeacher(tNo);
                getirTeacher();
            }
            else
            {
                MessageBox.Show("Not Deleted !");
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            DataGridViewRow select_row = DataGridView1.CurrentRow;

            FrmTeacherUpdate f = new FrmTeacherUpdate();
            f.textFName.Text = select_row.Cells["teacher_name"].Value.ToString();
            f.textLName.Text = select_row.Cells["teacher_lastname"].Value.ToString();
            f.phoneText.Text = select_row.Cells["teacher_phone"].Value.ToString();
            f.label7.Text = select_row.Cells["teacher_id"].Value.ToString();

            f.ShowDialog();
            getirTeacher();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textFName.Clear();
            textLName.Clear();
            phoneText.Clear();
            TotalTeacherLabel.Text = "Total Teacher: " + DataGridView1.Rows.Count;
        }
    }
}
