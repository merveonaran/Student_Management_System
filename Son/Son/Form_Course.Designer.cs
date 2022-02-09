
namespace Son
{
    partial class Form_Course
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TotalCourses = new System.Windows.Forms.Label();
            this.Remove_Course = new System.Windows.Forms.Button();
            this.Add_Course = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.TextBox();
            this.HoursNumber = new System.Windows.Forms.Label();
            this.LabelAddCourse = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hours = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.turn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalCourses
            // 
            this.TotalCourses.BackColor = System.Drawing.Color.LightSalmon;
            this.TotalCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalCourses.Location = new System.Drawing.Point(1055, 613);
            this.TotalCourses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalCourses.Name = "TotalCourses";
            this.TotalCourses.Size = new System.Drawing.Size(249, 48);
            this.TotalCourses.TabIndex = 69;
            this.TotalCourses.Text = "Total Course:";
            this.TotalCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Remove_Course
            // 
            this.Remove_Course.BackColor = System.Drawing.Color.Crimson;
            this.Remove_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Remove_Course.ForeColor = System.Drawing.Color.White;
            this.Remove_Course.Location = new System.Drawing.Point(301, 553);
            this.Remove_Course.Margin = new System.Windows.Forms.Padding(5);
            this.Remove_Course.Name = "Remove_Course";
            this.Remove_Course.Size = new System.Drawing.Size(155, 57);
            this.Remove_Course.TabIndex = 67;
            this.Remove_Course.Text = "Remove";
            this.Remove_Course.UseVisualStyleBackColor = false;
            this.Remove_Course.Click += new System.EventHandler(this.Remove_Course_Click);
            // 
            // Add_Course
            // 
            this.Add_Course.BackColor = System.Drawing.Color.RoyalBlue;
            this.Add_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Add_Course.ForeColor = System.Drawing.Color.White;
            this.Add_Course.Location = new System.Drawing.Point(127, 553);
            this.Add_Course.Margin = new System.Windows.Forms.Padding(5);
            this.Add_Course.Name = "Add_Course";
            this.Add_Course.Size = new System.Drawing.Size(155, 57);
            this.Add_Course.TabIndex = 65;
            this.Add_Course.Text = "Add";
            this.Add_Course.UseVisualStyleBackColor = false;
            this.Add_Course.Click += new System.EventHandler(this.Add_Course_Click);
            // 
            // labelText
            // 
            this.labelText.Location = new System.Drawing.Point(275, 432);
            this.labelText.Margin = new System.Windows.Forms.Padding(4);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(367, 22);
            this.labelText.TabIndex = 57;
            // 
            // HoursNumber
            // 
            this.HoursNumber.AutoSize = true;
            this.HoursNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HoursNumber.Location = new System.Drawing.Point(104, 483);
            this.HoursNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HoursNumber.Name = "HoursNumber";
            this.HoursNumber.Size = new System.Drawing.Size(137, 20);
            this.HoursNumber.TabIndex = 55;
            this.HoursNumber.Text = "Hours Number:";
            // 
            // LabelAddCourse
            // 
            this.LabelAddCourse.AutoSize = true;
            this.LabelAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelAddCourse.Location = new System.Drawing.Point(112, 434);
            this.LabelAddCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAddCourse.Name = "LabelAddCourse";
            this.LabelAddCourse.Size = new System.Drawing.Size(129, 20);
            this.LabelAddCourse.TabIndex = 54;
            this.LabelAddCourse.Text = "Course Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(789, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(515, 446);
            this.dataGridView1.TabIndex = 71;
            // 
            // hours
            // 
            this.hours.FormattingEnabled = true;
            this.hours.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.hours.Location = new System.Drawing.Point(279, 479);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(197, 24);
            this.hours.TabIndex = 72;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Green;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(897, 107);
            this.Search.Margin = new System.Windows.Forms.Padding(5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(273, 49);
            this.Search.TabIndex = 93;
            this.Search.Text = "SHOW TABLE";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(1249, 29);
            this.Exit.Margin = new System.Windows.Forms.Padding(5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(55, 32);
            this.Exit.TabIndex = 97;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // turn_back
            // 
            this.turn_back.BackColor = System.Drawing.Color.Red;
            this.turn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turn_back.ForeColor = System.Drawing.Color.White;
            this.turn_back.Location = new System.Drawing.Point(14, 29);
            this.turn_back.Margin = new System.Windows.Forms.Padding(5);
            this.turn_back.Name = "turn_back";
            this.turn_back.Size = new System.Drawing.Size(142, 40);
            this.turn_back.TabIndex = 100;
            this.turn_back.Text = "Turn Back";
            this.turn_back.UseVisualStyleBackColor = false;
            this.turn_back.Click += new System.EventHandler(this.turn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(103, 375);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 108;
            this.label1.Text = "Department ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 375);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(573, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 44);
            this.label2.TabIndex = 114;
            this.label2.Text = "COURSE";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(97, 164);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(467, 167);
            this.dataGridView2.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSalmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(202, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 36);
            this.label3.TabIndex = 160;
            this.label3.Text = "Department List";
            // 
            // Form_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1756, 750);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.turn_back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TotalCourses);
            this.Controls.Add(this.Remove_Course);
            this.Controls.Add(this.Add_Course);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.HoursNumber);
            this.Controls.Add(this.LabelAddCourse);
            this.Name = "Form_Course";
            this.Text = "Form_Course";
            this.Load += new System.EventHandler(this.Form_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TotalCourses;
        private System.Windows.Forms.Button Remove_Course;
        private System.Windows.Forms.Button Add_Course;
        private System.Windows.Forms.TextBox labelText;
        private System.Windows.Forms.Label HoursNumber;
        private System.Windows.Forms.Label LabelAddCourse;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox hours;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button turn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
    }
}