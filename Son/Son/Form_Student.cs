using Son.DataSet1TableAdapters;
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
    public partial class Form_Student : Form
    {
        public Form_Student()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.StudentTableAdapter ta = new DataSet1TableAdapters.StudentTableAdapter();
            ta.AddStudent(textFName.Text, textLName.Text, dateBrithTime.Text, comboBox1.Text, phoneText.Text, address.Text);
            DataGridView1.DataSource = ta.GetStudent();

            textFName.Clear();
            textLName.Clear();
            comboBox1.ResetText();
            phoneText.Clear();
            address.ResetText();

        }

        public void getirStudent()
        {
            DataSet1TableAdapters.StudentTableAdapter taStudent = new DataSet1TableAdapters.StudentTableAdapter();
            DataGridView1.DataSource = taStudent.GetStudent();
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                DataGridViewRow select_row = DataGridView1.CurrentRow;
                int sNo = Convert.ToInt16(select_row.Cells["student_id"].Value.ToString());
                DataSet1TableAdapters.StudentTableAdapter ta = new DataSet1TableAdapters.StudentTableAdapter();
                ta.DeleteStudent(sNo);
                getirStudent();
                TotalStudentLabel.Text = "Total Student: " + DataGridView1.Rows.Count;
            }
            else
            {
                MessageBox.Show("Not Deleted !");
            }
        }



    
        private void ResetButton_Click(object sender, EventArgs e)
        {

            id.Clear();
            textFName.Clear();
            textLName.Clear();
            comboBox1.ResetText();
            phoneText.Clear();
            TotalStudentLabel.Text = "Total Student: " + DataGridView1.Rows.Count;
            address.ResetText();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            DataGridViewRow select_row = DataGridView1.CurrentRow;

            FrmStudentUpdate f = new FrmStudentUpdate();

            f.textFName.Text = select_row.Cells["student_firstname"].Value.ToString();
            f.textLName.Text = select_row.Cells["student_lastname"].Value.ToString();
            f.dateBrithTime.Text = select_row.Cells["student_birthdate"].Value.ToString();
            f.textBox2.Text = select_row.Cells["student_gender"].Value.ToString();
            f.phoneText.Text = select_row.Cells["student_phone"].Value.ToString();
            f.address.Text = select_row.Cells["student_address"].Value.ToString();
            f.label7.Text = select_row.Cells["student_id"].Value.ToString();

            f.ShowDialog();
            getirStudent();

        

        }

        private void Search_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.StudentTableAdapter ta = new DataSet1TableAdapters.StudentTableAdapter();
            DataGridView1.DataSource = ta.GetStudent();
            TotalStudentLabel.Text = "Total Student: " + DataGridView1.Rows.Count;

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
    }
}
