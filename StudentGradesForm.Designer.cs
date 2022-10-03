namespace Class_Grade_System
{
    partial class StudentGradesForm
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
            this.GradeDisplayGrid = new System.Windows.Forms.DataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddNewCourselbl = new System.Windows.Forms.Label();
            this.CourseNametxtbox = new System.Windows.Forms.TextBox();
            this.CourseNamelbl = new System.Windows.Forms.Label();
            this.CourseGradelbl = new System.Windows.Forms.Label();
            this.CourseGradetxtbox = new System.Windows.Forms.TextBox();
            this.CourseCreditlbl = new System.Windows.Forms.Label();
            this.CourseCredittxtbox = new System.Windows.Forms.TextBox();
            this.SaveCoursebtn = new System.Windows.Forms.Button();
            this.CancelCoursebtn = new System.Windows.Forms.Button();
            this.DeleteCoursebtn = new System.Windows.Forms.Button();
            this.DeleteCourselbl = new System.Windows.Forms.Label();
            this.LowestGradlbl = new System.Windows.Forms.Label();
            this.HighestGradelbl = new System.Windows.Forms.Label();
            this.AvgGradelbl = new System.Windows.Forms.Label();
            this.LowestGradeValuelbl = new System.Windows.Forms.Label();
            this.HighestGradeValuelbl = new System.Windows.Forms.Label();
            this.AvgGradeValuelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GradeDisplayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GradeDisplayGrid
            // 
            this.GradeDisplayGrid.AllowUserToAddRows = false;
            this.GradeDisplayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GradeDisplayGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.CourseGrade,
            this.CourseCredit});
            this.GradeDisplayGrid.Location = new System.Drawing.Point(230, 27);
            this.GradeDisplayGrid.Name = "GradeDisplayGrid";
            this.GradeDisplayGrid.ReadOnly = true;
            this.GradeDisplayGrid.RowHeadersWidth = 51;
            this.GradeDisplayGrid.RowTemplate.Height = 24;
            this.GradeDisplayGrid.Size = new System.Drawing.Size(402, 197);
            this.GradeDisplayGrid.TabIndex = 0;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 6;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Width = 125;
            // 
            // CourseGrade
            // 
            this.CourseGrade.HeaderText = "Course Grade";
            this.CourseGrade.MinimumWidth = 6;
            this.CourseGrade.Name = "CourseGrade";
            this.CourseGrade.ReadOnly = true;
            this.CourseGrade.Width = 125;
            // 
            // CourseCredit
            // 
            this.CourseCredit.HeaderText = "Course Credit";
            this.CourseCredit.MinimumWidth = 6;
            this.CourseCredit.Name = "CourseCredit";
            this.CourseCredit.ReadOnly = true;
            this.CourseCredit.Width = 125;
            // 
            // AddNewCourselbl
            // 
            this.AddNewCourselbl.AutoSize = true;
            this.AddNewCourselbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddNewCourselbl.Location = new System.Drawing.Point(-3, 9);
            this.AddNewCourselbl.Name = "AddNewCourselbl";
            this.AddNewCourselbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddNewCourselbl.Size = new System.Drawing.Size(143, 20);
            this.AddNewCourselbl.TabIndex = 1;
            this.AddNewCourselbl.Text = "Add new course";
            this.AddNewCourselbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseNametxtbox
            // 
            this.CourseNametxtbox.Location = new System.Drawing.Point(101, 40);
            this.CourseNametxtbox.Name = "CourseNametxtbox";
            this.CourseNametxtbox.Size = new System.Drawing.Size(123, 22);
            this.CourseNametxtbox.TabIndex = 1;
            // 
            // CourseNamelbl
            // 
            this.CourseNamelbl.AutoSize = true;
            this.CourseNamelbl.Location = new System.Drawing.Point(-2, 43);
            this.CourseNamelbl.Name = "CourseNamelbl";
            this.CourseNamelbl.Size = new System.Drawing.Size(90, 16);
            this.CourseNamelbl.TabIndex = 3;
            this.CourseNamelbl.Text = "Course name:";
            // 
            // CourseGradelbl
            // 
            this.CourseGradelbl.AutoSize = true;
            this.CourseGradelbl.Location = new System.Drawing.Point(-1, 79);
            this.CourseGradelbl.Name = "CourseGradelbl";
            this.CourseGradelbl.Size = new System.Drawing.Size(92, 16);
            this.CourseGradelbl.TabIndex = 5;
            this.CourseGradelbl.Text = "Course grade:";
            // 
            // CourseGradetxtbox
            // 
            this.CourseGradetxtbox.Location = new System.Drawing.Point(101, 79);
            this.CourseGradetxtbox.Name = "CourseGradetxtbox";
            this.CourseGradetxtbox.Size = new System.Drawing.Size(123, 22);
            this.CourseGradetxtbox.TabIndex = 2;
            // 
            // CourseCreditlbl
            // 
            this.CourseCreditlbl.AutoSize = true;
            this.CourseCreditlbl.Location = new System.Drawing.Point(-1, 125);
            this.CourseCreditlbl.Name = "CourseCreditlbl";
            this.CourseCreditlbl.Size = new System.Drawing.Size(89, 16);
            this.CourseCreditlbl.TabIndex = 7;
            this.CourseCreditlbl.Text = "Course credit:";
            // 
            // CourseCredittxtbox
            // 
            this.CourseCredittxtbox.Location = new System.Drawing.Point(101, 125);
            this.CourseCredittxtbox.Name = "CourseCredittxtbox";
            this.CourseCredittxtbox.Size = new System.Drawing.Size(123, 22);
            this.CourseCredittxtbox.TabIndex = 3;
            // 
            // SaveCoursebtn
            // 
            this.SaveCoursebtn.Location = new System.Drawing.Point(123, 153);
            this.SaveCoursebtn.Name = "SaveCoursebtn";
            this.SaveCoursebtn.Size = new System.Drawing.Size(86, 37);
            this.SaveCoursebtn.TabIndex = 4;
            this.SaveCoursebtn.Text = "Save";
            this.SaveCoursebtn.UseVisualStyleBackColor = true;
            this.SaveCoursebtn.Click += new System.EventHandler(this.SaveCoursebtn_Click);
            // 
            // CancelCoursebtn
            // 
            this.CancelCoursebtn.Location = new System.Drawing.Point(7, 153);
            this.CancelCoursebtn.Name = "CancelCoursebtn";
            this.CancelCoursebtn.Size = new System.Drawing.Size(86, 37);
            this.CancelCoursebtn.TabIndex = 5;
            this.CancelCoursebtn.Text = "Cancel";
            this.CancelCoursebtn.UseVisualStyleBackColor = true;
            this.CancelCoursebtn.Click += new System.EventHandler(this.CancelCoursebtn_Click);
            // 
            // DeleteCoursebtn
            // 
            this.DeleteCoursebtn.Location = new System.Drawing.Point(1, 246);
            this.DeleteCoursebtn.Name = "DeleteCoursebtn";
            this.DeleteCoursebtn.Size = new System.Drawing.Size(127, 23);
            this.DeleteCoursebtn.TabIndex = 6;
            this.DeleteCoursebtn.Text = "Delete Course";
            this.DeleteCoursebtn.UseVisualStyleBackColor = true;
            this.DeleteCoursebtn.Click += new System.EventHandler(this.DeleteCoursebtn_Click);
            // 
            // DeleteCourselbl
            // 
            this.DeleteCourselbl.AutoSize = true;
            this.DeleteCourselbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DeleteCourselbl.Location = new System.Drawing.Point(-3, 214);
            this.DeleteCourselbl.Name = "DeleteCourselbl";
            this.DeleteCourselbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeleteCourselbl.Size = new System.Drawing.Size(143, 20);
            this.DeleteCourselbl.TabIndex = 11;
            this.DeleteCourselbl.Text = "Delete a course";
            this.DeleteCourselbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LowestGradlbl
            // 
            this.LowestGradlbl.AutoSize = true;
            this.LowestGradlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LowestGradlbl.Location = new System.Drawing.Point(226, 246);
            this.LowestGradlbl.Name = "LowestGradlbl";
            this.LowestGradlbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LowestGradlbl.Size = new System.Drawing.Size(132, 20);
            this.LowestGradlbl.TabIndex = 12;
            this.LowestGradlbl.Text = "Lowest Grade:";
            this.LowestGradlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HighestGradelbl
            // 
            this.HighestGradelbl.AutoSize = true;
            this.HighestGradelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HighestGradelbl.Location = new System.Drawing.Point(226, 287);
            this.HighestGradelbl.Name = "HighestGradelbl";
            this.HighestGradelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HighestGradelbl.Size = new System.Drawing.Size(137, 20);
            this.HighestGradelbl.TabIndex = 13;
            this.HighestGradelbl.Text = "Highest Grade:";
            this.HighestGradelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvgGradelbl
            // 
            this.AvgGradelbl.AutoSize = true;
            this.AvgGradelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AvgGradelbl.Location = new System.Drawing.Point(222, 324);
            this.AvgGradelbl.Name = "AvgGradelbl";
            this.AvgGradelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AvgGradelbl.Size = new System.Drawing.Size(140, 20);
            this.AvgGradelbl.TabIndex = 14;
            this.AvgGradelbl.Text = "Average Grade:";
            this.AvgGradelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LowestGradeValuelbl
            // 
            this.LowestGradeValuelbl.AutoSize = true;
            this.LowestGradeValuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LowestGradeValuelbl.Location = new System.Drawing.Point(375, 246);
            this.LowestGradeValuelbl.Name = "LowestGradeValuelbl";
            this.LowestGradeValuelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LowestGradeValuelbl.Size = new System.Drawing.Size(21, 20);
            this.LowestGradeValuelbl.TabIndex = 15;
            this.LowestGradeValuelbl.Text = "A";
            this.LowestGradeValuelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HighestGradeValuelbl
            // 
            this.HighestGradeValuelbl.AutoSize = true;
            this.HighestGradeValuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HighestGradeValuelbl.Location = new System.Drawing.Point(375, 287);
            this.HighestGradeValuelbl.Name = "HighestGradeValuelbl";
            this.HighestGradeValuelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HighestGradeValuelbl.Size = new System.Drawing.Size(21, 20);
            this.HighestGradeValuelbl.TabIndex = 16;
            this.HighestGradeValuelbl.Text = "A";
            this.HighestGradeValuelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvgGradeValuelbl
            // 
            this.AvgGradeValuelbl.AutoSize = true;
            this.AvgGradeValuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AvgGradeValuelbl.Location = new System.Drawing.Point(377, 324);
            this.AvgGradeValuelbl.Name = "AvgGradeValuelbl";
            this.AvgGradeValuelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AvgGradeValuelbl.Size = new System.Drawing.Size(21, 20);
            this.AvgGradeValuelbl.TabIndex = 17;
            this.AvgGradeValuelbl.Text = "A";
            this.AvgGradeValuelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 355);
            this.Controls.Add(this.AvgGradeValuelbl);
            this.Controls.Add(this.HighestGradeValuelbl);
            this.Controls.Add(this.LowestGradeValuelbl);
            this.Controls.Add(this.AvgGradelbl);
            this.Controls.Add(this.HighestGradelbl);
            this.Controls.Add(this.LowestGradlbl);
            this.Controls.Add(this.DeleteCourselbl);
            this.Controls.Add(this.DeleteCoursebtn);
            this.Controls.Add(this.CancelCoursebtn);
            this.Controls.Add(this.SaveCoursebtn);
            this.Controls.Add(this.CourseCreditlbl);
            this.Controls.Add(this.CourseCredittxtbox);
            this.Controls.Add(this.CourseGradelbl);
            this.Controls.Add(this.CourseGradetxtbox);
            this.Controls.Add(this.CourseNamelbl);
            this.Controls.Add(this.CourseNametxtbox);
            this.Controls.Add(this.AddNewCourselbl);
            this.Controls.Add(this.GradeDisplayGrid);
            this.Name = "StudentGradesForm";
            this.Text = "Student Grades";
            ((System.ComponentModel.ISupportInitialize)(this.GradeDisplayGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GradeDisplayGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCredit;
        private System.Windows.Forms.Label AddNewCourselbl;
        private System.Windows.Forms.TextBox CourseNametxtbox;
        private System.Windows.Forms.Label CourseNamelbl;
        private System.Windows.Forms.Label CourseGradelbl;
        private System.Windows.Forms.TextBox CourseGradetxtbox;
        private System.Windows.Forms.Label CourseCreditlbl;
        private System.Windows.Forms.TextBox CourseCredittxtbox;
        private System.Windows.Forms.Button SaveCoursebtn;
        private System.Windows.Forms.Button CancelCoursebtn;
        private System.Windows.Forms.Button DeleteCoursebtn;
        private System.Windows.Forms.Label DeleteCourselbl;
        private System.Windows.Forms.Label LowestGradlbl;
        private System.Windows.Forms.Label HighestGradelbl;
        private System.Windows.Forms.Label AvgGradelbl;
        private System.Windows.Forms.Label LowestGradeValuelbl;
        private System.Windows.Forms.Label HighestGradeValuelbl;
        private System.Windows.Forms.Label AvgGradeValuelbl;
    }
}