
namespace Son
{
    partial class SP_Student
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.turn_back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.TotalStudentLabel = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(623, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(333, 44);
            this.label7.TabIndex = 138;
            this.label7.Text = "Stored Procedure";
            // 
            // turn_back
            // 
            this.turn_back.BackColor = System.Drawing.Color.Red;
            this.turn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turn_back.ForeColor = System.Drawing.Color.White;
            this.turn_back.Location = new System.Drawing.Point(184, 50);
            this.turn_back.Margin = new System.Windows.Forms.Padding(5);
            this.turn_back.Name = "turn_back";
            this.turn_back.Size = new System.Drawing.Size(135, 41);
            this.turn_back.TabIndex = 137;
            this.turn_back.Text = "Turn Back";
            this.turn_back.UseVisualStyleBackColor = false;
            this.turn_back.Click += new System.EventHandler(this.turn_back_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(1499, 50);
            this.Exit.Margin = new System.Windows.Forms.Padding(5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(47, 33);
            this.Exit.TabIndex = 135;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGridView1.Location = new System.Drawing.Point(410, 220);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 80;
            this.DataGridView1.Size = new System.Drawing.Size(832, 427);
            this.DataGridView1.TabIndex = 131;
            // 
            // TotalStudentLabel
            // 
            this.TotalStudentLabel.AutoEllipsis = true;
            this.TotalStudentLabel.BackColor = System.Drawing.Color.DarkOrchid;
            this.TotalStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalStudentLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalStudentLabel.Location = new System.Drawing.Point(1029, 642);
            this.TotalStudentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalStudentLabel.Name = "TotalStudentLabel";
            this.TotalStudentLabel.Size = new System.Drawing.Size(212, 55);
            this.TotalStudentLabel.TabIndex = 133;
            this.TotalStudentLabel.Text = "Total Student:";
            this.TotalStudentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Green;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(683, 162);
            this.Search.Margin = new System.Windows.Forms.Padding(5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(273, 49);
            this.Search.TabIndex = 132;
            this.Search.Text = "SHOW TABLE";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SP_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1731, 762);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.turn_back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.TotalStudentLabel);
            this.Controls.Add(this.Search);
            this.Name = "SP_Student";
            this.Text = "SP_Student";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button turn_back;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label TotalStudentLabel;
        private System.Windows.Forms.Button Search;
    }
}