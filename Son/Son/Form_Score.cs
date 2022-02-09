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
    public partial class Form_Score : Form
    {
        public Form_Score()
        {
            InitializeComponent();
            DataSet1TableAdapters.Student_CourseTableAdapter ta = new DataSet1TableAdapters.Student_CourseTableAdapter();
            dataGridView2.DataSource = ta.GetStudent_Course();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet1TableAdapters.ScoreTableAdapter ta = new DataSet1TableAdapters.ScoreTableAdapter();
                ta.AddScore(Convert.ToInt32(textBox1.Text), textCName.Text, Convert.ToInt32(textScore.Text));
                DataGridView1.DataSource = ta.GetScore();

                textBox1.Clear();
                textCName.Clear();
                textScore.Clear();
            }

            catch
            {
                MessageBox.Show("Student with this number not found !");
            }

        }

        public void getirScore()
        {
            DataSet1TableAdapters.ScoreTableAdapter taDepartment = new DataSet1TableAdapters.ScoreTableAdapter();
            DataGridView1.DataSource = taDepartment.GetScore();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                DataGridViewRow select_row = DataGridView1.CurrentRow;
                int scNo = Convert.ToInt16(select_row.Cells["score_id"].Value.ToString());
                DataSet1TableAdapters.ScoreTableAdapter ta = new DataSet1TableAdapters.ScoreTableAdapter();
                ta.DeleteScore(scNo);
                getirScore();
                //TotalStudentLabel.Text = "Total Student: " + dataGridView2.Rows.Count;
            }
            else
            {
                MessageBox.Show("Not Deleted !");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow select_row = DataGridView1.CurrentRow;

            FrmScoreUpdate f = new FrmScoreUpdate();

            f.textBox1.Text = select_row.Cells["student_id"].Value.ToString();
            f.Score.Text = select_row.Cells["score"].Value.ToString();

            f.ShowDialog();
            getirScore();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textCName.Clear();
            textScore.Clear();

            TotalScoreLabel.Text = "Total Student: " + DataGridView1.Rows.Count;

        }

        private void Search_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ScoreTableAdapter ta = new DataSet1TableAdapters.ScoreTableAdapter();
            DataGridView1.DataSource = ta.GetScore();
            TotalScoreLabel.Text = "Total Student: " + DataGridView1.Rows.Count;
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
