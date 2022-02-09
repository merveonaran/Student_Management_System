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
    public partial class FrmTeacherUpdate : Form
    {
        public FrmTeacherUpdate()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TeacherTableAdapter ta = new DataSet1TableAdapters.TeacherTableAdapter();
            ta.UpdateTeacher (textFName.Text, textLName.Text, phoneText.Text, Convert.ToInt16(label7.Text));

            MessageBox.Show("Update Process Has Been Performed !");

            this.Close();
        }
    }
}
