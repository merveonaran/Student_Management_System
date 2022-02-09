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
    public partial class FrmScoreUpdate : Form
    {
        public FrmScoreUpdate()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ScoreTableAdapter ta = new DataSet1TableAdapters.ScoreTableAdapter();
            ta.UpdateScore(textSName.Text, Convert.ToInt16(Score.Text), Convert.ToInt16(textBox1.Text));

            MessageBox.Show("Update Process Has Been Performed !");

            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
