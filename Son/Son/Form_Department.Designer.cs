
namespace Son
{
    partial class Form_Department
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
            this.Exit = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.departmentName = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TotalDepatment = new System.Windows.Forms.Label();
            this.Remove_Course = new System.Windows.Forms.Button();
            this.Add_Course = new System.Windows.Forms.Button();
            this.IDManage = new System.Windows.Forms.Label();
            this.LabelAddCourse = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.turn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(1193, 35);
            this.Exit.Margin = new System.Windows.Forms.Padding(5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(55, 32);
            this.Exit.TabIndex = 109;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Green;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(841, 139);
            this.Search.Margin = new System.Windows.Forms.Padding(5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(273, 49);
            this.Search.TabIndex = 108;
            this.Search.Text = "SHOW TABLE";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // departmentName
            // 
            this.departmentName.FormattingEnabled = true;
            this.departmentName.Items.AddRange(new object[] {
            "Computer Science",
            "Economics",
            "Chemistry and Biochemistry"});
            this.departmentName.Location = new System.Drawing.Point(268, 454);
            this.departmentName.Name = "departmentName";
            this.departmentName.Size = new System.Drawing.Size(335, 24);
            this.departmentName.TabIndex = 107;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(733, 196);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(515, 446);
            this.dataGridView2.TabIndex = 106;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TotalDepatment
            // 
            this.TotalDepatment.BackColor = System.Drawing.Color.LightSalmon;
            this.TotalDepatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalDepatment.Location = new System.Drawing.Point(999, 645);
            this.TotalDepatment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalDepatment.Name = "TotalDepatment";
            this.TotalDepatment.Size = new System.Drawing.Size(249, 48);
            this.TotalDepatment.TabIndex = 104;
            this.TotalDepatment.Text = "Total Department:";
            this.TotalDepatment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Remove_Course
            // 
            this.Remove_Course.BackColor = System.Drawing.Color.Crimson;
            this.Remove_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Remove_Course.ForeColor = System.Drawing.Color.White;
            this.Remove_Course.Location = new System.Drawing.Point(397, 504);
            this.Remove_Course.Margin = new System.Windows.Forms.Padding(5);
            this.Remove_Course.Name = "Remove_Course";
            this.Remove_Course.Size = new System.Drawing.Size(155, 57);
            this.Remove_Course.TabIndex = 103;
            this.Remove_Course.Text = "Remove";
            this.Remove_Course.UseVisualStyleBackColor = false;
            this.Remove_Course.Click += new System.EventHandler(this.Remove_Course_Click);
            // 
            // Add_Course
            // 
            this.Add_Course.BackColor = System.Drawing.Color.RoyalBlue;
            this.Add_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Add_Course.ForeColor = System.Drawing.Color.White;
            this.Add_Course.Location = new System.Drawing.Point(223, 504);
            this.Add_Course.Margin = new System.Windows.Forms.Padding(5);
            this.Add_Course.Name = "Add_Course";
            this.Add_Course.Size = new System.Drawing.Size(155, 57);
            this.Add_Course.TabIndex = 102;
            this.Add_Course.Text = "Add";
            this.Add_Course.UseVisualStyleBackColor = false;
            this.Add_Course.Click += new System.EventHandler(this.Add_Course_Click);
            // 
            // IDManage
            // 
            this.IDManage.AutoSize = true;
            this.IDManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IDManage.Location = new System.Drawing.Point(134, 383);
            this.IDManage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDManage.Name = "IDManage";
            this.IDManage.Size = new System.Drawing.Size(100, 20);
            this.IDManage.TabIndex = 101;
            this.IDManage.Text = "Student Id:";
            // 
            // LabelAddCourse
            // 
            this.LabelAddCourse.AutoSize = true;
            this.LabelAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelAddCourse.Location = new System.Drawing.Point(67, 454);
            this.LabelAddCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAddCourse.Name = "LabelAddCourse";
            this.LabelAddCourse.Size = new System.Drawing.Size(167, 20);
            this.LabelAddCourse.TabIndex = 98;
            this.LabelAddCourse.Text = "Department Name:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(268, 383);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(252, 22);
            this.id.TabIndex = 110;
            // 
            // turn_back
            // 
            this.turn_back.BackColor = System.Drawing.Color.Red;
            this.turn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turn_back.ForeColor = System.Drawing.Color.White;
            this.turn_back.Location = new System.Drawing.Point(14, 14);
            this.turn_back.Margin = new System.Windows.Forms.Padding(5);
            this.turn_back.Name = "turn_back";
            this.turn_back.Size = new System.Drawing.Size(130, 35);
            this.turn_back.TabIndex = 112;
            this.turn_back.Text = "Turn Back";
            this.turn_back.UseVisualStyleBackColor = false;
            this.turn_back.Click += new System.EventHandler(this.turn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(514, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 44);
            this.label1.TabIndex = 113;
            this.label1.Text = "DEPARTMENT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(125, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(467, 167);
            this.dataGridView1.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSalmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(262, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 36);
            this.label3.TabIndex = 160;
            this.label3.Text = "Students List";
            // 
            // Form_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1401, 738);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.turn_back);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.departmentName);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.TotalDepatment);
            this.Controls.Add(this.Remove_Course);
            this.Controls.Add(this.Add_Course);
            this.Controls.Add(this.IDManage);
            this.Controls.Add(this.LabelAddCourse);
            this.Name = "Form_Department";
            this.Text = "Department";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Search;
        public System.Windows.Forms.ComboBox departmentName;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label TotalDepatment;
        private System.Windows.Forms.Button Remove_Course;
        private System.Windows.Forms.Button Add_Course;
        private System.Windows.Forms.Label IDManage;
        private System.Windows.Forms.Label LabelAddCourse;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button turn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}