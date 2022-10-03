namespace Class_Grade_System
{
    partial class StudentListForm
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
            this.StudentDisplayGrid = new System.Windows.Forms.DataGridView();
            this.DeleteStudentlbl = new System.Windows.Forms.Label();
            this.DeleteStudentbtn = new System.Windows.Forms.Button();
            this.CancelStudentbtn = new System.Windows.Forms.Button();
            this.SaveStudentbtn = new System.Windows.Forms.Button();
            this.StudentPhoneNumberlbl = new System.Windows.Forms.Label();
            this.StudentPhoneNumbertxtbox = new System.Windows.Forms.TextBox();
            this.StudentIDlbl = new System.Windows.Forms.Label();
            this.StutentIDtxtbox = new System.Windows.Forms.TextBox();
            this.StudentNamelbl = new System.Windows.Forms.Label();
            this.StudentNametxtbox = new System.Windows.Forms.TextBox();
            this.AddNewStudentlbl = new System.Windows.Forms.Label();
            this.StudentLastNamelbl = new System.Windows.Forms.Label();
            this.StudentLastNametxtbox = new System.Windows.Forms.TextBox();
            this.ShowStudentbtn = new System.Windows.Forms.Button();
            this.ShowStudentlbl = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDisplayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentDisplayGrid
            // 
            this.StudentDisplayGrid.AllowUserToAddRows = false;
            this.StudentDisplayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDisplayGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.StudentLastName,
            this.StudentID,
            this.StudentPhone});
            this.StudentDisplayGrid.Location = new System.Drawing.Point(12, 143);
            this.StudentDisplayGrid.Name = "StudentDisplayGrid";
            this.StudentDisplayGrid.ReadOnly = true;
            this.StudentDisplayGrid.RowHeadersWidth = 51;
            this.StudentDisplayGrid.RowTemplate.Height = 24;
            this.StudentDisplayGrid.Size = new System.Drawing.Size(753, 151);
            this.StudentDisplayGrid.TabIndex = 0;
            // 
            // DeleteStudentlbl
            // 
            this.DeleteStudentlbl.AutoSize = true;
            this.DeleteStudentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DeleteStudentlbl.Location = new System.Drawing.Point(11, 313);
            this.DeleteStudentlbl.Name = "DeleteStudentlbl";
            this.DeleteStudentlbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeleteStudentlbl.Size = new System.Drawing.Size(150, 20);
            this.DeleteStudentlbl.TabIndex = 22;
            this.DeleteStudentlbl.Text = "Delete a Student";
            this.DeleteStudentlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteStudentbtn
            // 
            this.DeleteStudentbtn.Location = new System.Drawing.Point(20, 336);
            this.DeleteStudentbtn.Name = "DeleteStudentbtn";
            this.DeleteStudentbtn.Size = new System.Drawing.Size(127, 23);
            this.DeleteStudentbtn.TabIndex = 8;
            this.DeleteStudentbtn.Text = "Delete Student";
            this.DeleteStudentbtn.UseVisualStyleBackColor = true;
            this.DeleteStudentbtn.Click += new System.EventHandler(this.DeleteStudentbtn_Click);
            // 
            // CancelStudentbtn
            // 
            this.CancelStudentbtn.Location = new System.Drawing.Point(563, 79);
            this.CancelStudentbtn.Name = "CancelStudentbtn";
            this.CancelStudentbtn.Size = new System.Drawing.Size(86, 37);
            this.CancelStudentbtn.TabIndex = 6;
            this.CancelStudentbtn.Text = "Cancel";
            this.CancelStudentbtn.UseVisualStyleBackColor = true;
            // 
            // SaveStudentbtn
            // 
            this.SaveStudentbtn.Location = new System.Drawing.Point(679, 79);
            this.SaveStudentbtn.Name = "SaveStudentbtn";
            this.SaveStudentbtn.Size = new System.Drawing.Size(86, 37);
            this.SaveStudentbtn.TabIndex = 5;
            this.SaveStudentbtn.Text = "Save";
            this.SaveStudentbtn.UseVisualStyleBackColor = true;
            this.SaveStudentbtn.Click += new System.EventHandler(this.SaveStudentbtn_Click);
            // 
            // StudentPhoneNumberlbl
            // 
            this.StudentPhoneNumberlbl.AutoSize = true;
            this.StudentPhoneNumberlbl.Location = new System.Drawing.Point(595, 42);
            this.StudentPhoneNumberlbl.Name = "StudentPhoneNumberlbl";
            this.StudentPhoneNumberlbl.Size = new System.Drawing.Size(49, 16);
            this.StudentPhoneNumberlbl.TabIndex = 18;
            this.StudentPhoneNumberlbl.Text = "Phone:";
            // 
            // StudentPhoneNumbertxtbox
            // 
            this.StudentPhoneNumbertxtbox.Location = new System.Drawing.Point(650, 39);
            this.StudentPhoneNumbertxtbox.MinimumSize = new System.Drawing.Size(123, 22);
            this.StudentPhoneNumbertxtbox.Name = "StudentPhoneNumbertxtbox";
            this.StudentPhoneNumbertxtbox.Size = new System.Drawing.Size(123, 22);
            this.StudentPhoneNumbertxtbox.TabIndex = 4;
            // 
            // StudentIDlbl
            // 
            this.StudentIDlbl.AutoSize = true;
            this.StudentIDlbl.Location = new System.Drawing.Point(437, 42);
            this.StudentIDlbl.Name = "StudentIDlbl";
            this.StudentIDlbl.Size = new System.Drawing.Size(23, 16);
            this.StudentIDlbl.TabIndex = 16;
            this.StudentIDlbl.Text = "ID:";
            // 
            // StutentIDtxtbox
            // 
            this.StutentIDtxtbox.Location = new System.Drawing.Point(466, 39);
            this.StutentIDtxtbox.Name = "StutentIDtxtbox";
            this.StutentIDtxtbox.Size = new System.Drawing.Size(123, 22);
            this.StutentIDtxtbox.TabIndex = 3;
            // 
            // StudentNamelbl
            // 
            this.StudentNamelbl.AutoSize = true;
            this.StudentNamelbl.Location = new System.Drawing.Point(3, 42);
            this.StudentNamelbl.Name = "StudentNamelbl";
            this.StudentNamelbl.Size = new System.Drawing.Size(92, 16);
            this.StudentNamelbl.TabIndex = 14;
            this.StudentNamelbl.Text = "Student name:";
            // 
            // StudentNametxtbox
            // 
            this.StudentNametxtbox.Location = new System.Drawing.Point(105, 39);
            this.StudentNametxtbox.Name = "StudentNametxtbox";
            this.StudentNametxtbox.Size = new System.Drawing.Size(123, 22);
            this.StudentNametxtbox.TabIndex = 1;
            // 
            // AddNewStudentlbl
            // 
            this.AddNewStudentlbl.AutoSize = true;
            this.AddNewStudentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddNewStudentlbl.Location = new System.Drawing.Point(6, 9);
            this.AddNewStudentlbl.Name = "AddNewStudentlbl";
            this.AddNewStudentlbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddNewStudentlbl.Size = new System.Drawing.Size(148, 20);
            this.AddNewStudentlbl.TabIndex = 12;
            this.AddNewStudentlbl.Text = "Add new student";
            this.AddNewStudentlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentLastNamelbl
            // 
            this.StudentLastNamelbl.AutoSize = true;
            this.StudentLastNamelbl.Location = new System.Drawing.Point(229, 42);
            this.StudentLastNamelbl.Name = "StudentLastNamelbl";
            this.StudentLastNamelbl.Size = new System.Drawing.Size(72, 16);
            this.StudentLastNamelbl.TabIndex = 24;
            this.StudentLastNamelbl.Text = "Last name:";
            // 
            // StudentLastNametxtbox
            // 
            this.StudentLastNametxtbox.Location = new System.Drawing.Point(308, 39);
            this.StudentLastNametxtbox.Name = "StudentLastNametxtbox";
            this.StudentLastNametxtbox.Size = new System.Drawing.Size(123, 22);
            this.StudentLastNametxtbox.TabIndex = 2;
            // 
            // ShowStudentbtn
            // 
            this.ShowStudentbtn.Location = new System.Drawing.Point(572, 336);
            this.ShowStudentbtn.Name = "ShowStudentbtn";
            this.ShowStudentbtn.Size = new System.Drawing.Size(127, 23);
            this.ShowStudentbtn.TabIndex = 7;
            this.ShowStudentbtn.Text = "Show student";
            this.ShowStudentbtn.UseVisualStyleBackColor = true;
            this.ShowStudentbtn.Click += new System.EventHandler(this.ShowStudentbtn_Click);
            // 
            // ShowStudentlbl
            // 
            this.ShowStudentlbl.AutoSize = true;
            this.ShowStudentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ShowStudentlbl.Location = new System.Drawing.Point(507, 313);
            this.ShowStudentlbl.Name = "ShowStudentlbl";
            this.ShowStudentlbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowStudentlbl.Size = new System.Drawing.Size(237, 20);
            this.ShowStudentlbl.TabIndex = 26;
            this.ShowStudentlbl.Text = "Show student grades sheet";
            this.ShowStudentlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // StudentLastName
            // 
            this.StudentLastName.HeaderText = "Last Name";
            this.StudentLastName.MinimumWidth = 6;
            this.StudentLastName.Name = "StudentLastName";
            this.StudentLastName.ReadOnly = true;
            this.StudentLastName.Width = 125;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "ID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Width = 125;
            // 
            // StudentPhone
            // 
            this.StudentPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StudentPhone.HeaderText = "Phone";
            this.StudentPhone.MinimumWidth = 6;
            this.StudentPhone.Name = "StudentPhone";
            this.StudentPhone.ReadOnly = true;
            this.StudentPhone.Width = 75;
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.ShowStudentlbl);
            this.Controls.Add(this.ShowStudentbtn);
            this.Controls.Add(this.StudentLastNamelbl);
            this.Controls.Add(this.StudentLastNametxtbox);
            this.Controls.Add(this.DeleteStudentlbl);
            this.Controls.Add(this.DeleteStudentbtn);
            this.Controls.Add(this.CancelStudentbtn);
            this.Controls.Add(this.SaveStudentbtn);
            this.Controls.Add(this.StudentPhoneNumberlbl);
            this.Controls.Add(this.StudentPhoneNumbertxtbox);
            this.Controls.Add(this.StudentIDlbl);
            this.Controls.Add(this.StutentIDtxtbox);
            this.Controls.Add(this.StudentNamelbl);
            this.Controls.Add(this.StudentNametxtbox);
            this.Controls.Add(this.AddNewStudentlbl);
            this.Controls.Add(this.StudentDisplayGrid);
            this.Name = "StudentListForm";
            this.Text = "Grade System";
            ((System.ComponentModel.ISupportInitialize)(this.StudentDisplayGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentDisplayGrid;
        private System.Windows.Forms.Label DeleteStudentlbl;
        private System.Windows.Forms.Button DeleteStudentbtn;
        private System.Windows.Forms.Button CancelStudentbtn;
        private System.Windows.Forms.Button SaveStudentbtn;
        private System.Windows.Forms.Label StudentPhoneNumberlbl;
        private System.Windows.Forms.TextBox StudentPhoneNumbertxtbox;
        private System.Windows.Forms.Label StudentIDlbl;
        private System.Windows.Forms.TextBox StutentIDtxtbox;
        private System.Windows.Forms.Label StudentNamelbl;
        private System.Windows.Forms.TextBox StudentNametxtbox;
        private System.Windows.Forms.Label AddNewStudentlbl;
        private System.Windows.Forms.Label StudentLastNamelbl;
        private System.Windows.Forms.TextBox StudentLastNametxtbox;
        private System.Windows.Forms.Button ShowStudentbtn;
        private System.Windows.Forms.Label ShowStudentlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPhone;
    }
}