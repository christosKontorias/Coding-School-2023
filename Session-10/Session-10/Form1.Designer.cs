namespace Session_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.labelStudents = new System.Windows.Forms.Label();
            this.labelGrades = new System.Windows.Forms.Label();
            this.labelCourses = new System.Windows.Forms.Label();
            this.labelScheduledCourses = new System.Windows.Forms.Label();
            this.GridViewStudents = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentRegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStudents = new System.Windows.Forms.BindingSource(this.components);
            this.GridViewGrades = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGradeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridViewCourses = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridViewScheduledCourses = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewScheduledCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(667, 319);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudents.Location = new System.Drawing.Point(4, 9);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(88, 28);
            this.labelStudents.TabIndex = 3;
            this.labelStudents.Text = "Students";
            // 
            // labelGrades
            // 
            this.labelGrades.AutoSize = true;
            this.labelGrades.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGrades.Location = new System.Drawing.Point(510, 8);
            this.labelGrades.Name = "labelGrades";
            this.labelGrades.Size = new System.Drawing.Size(73, 28);
            this.labelGrades.TabIndex = 4;
            this.labelGrades.Text = "Grades";
            // 
            // labelCourses
            // 
            this.labelCourses.AutoSize = true;
            this.labelCourses.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCourses.Location = new System.Drawing.Point(12, 200);
            this.labelCourses.Name = "labelCourses";
            this.labelCourses.Size = new System.Drawing.Size(80, 28);
            this.labelCourses.TabIndex = 6;
            this.labelCourses.Text = "Courses";
            // 
            // labelScheduledCourses
            // 
            this.labelScheduledCourses.AutoSize = true;
            this.labelScheduledCourses.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScheduledCourses.Location = new System.Drawing.Point(292, 182);
            this.labelScheduledCourses.Name = "labelScheduledCourses";
            this.labelScheduledCourses.Size = new System.Drawing.Size(171, 28);
            this.labelScheduledCourses.TabIndex = 10;
            this.labelScheduledCourses.Text = "ScheduledCourses";
            // 
            // GridViewStudents
            // 
            this.GridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.StudentName,
            this.StudentAge,
            this.StudentRegistrationNumber});
            this.GridViewStudents.Location = new System.Drawing.Point(4, 40);
            this.GridViewStudents.Name = "GridViewStudents";
            this.GridViewStudents.RowTemplate.Height = 25;
            this.GridViewStudents.Size = new System.Drawing.Size(445, 139);
            this.GridViewStudents.TabIndex = 12;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "Name";
            this.StudentName.HeaderText = "Name";
            this.StudentName.Name = "StudentName";
            // 
            // StudentAge
            // 
            this.StudentAge.DataPropertyName = "Age";
            this.StudentAge.HeaderText = "Age";
            this.StudentAge.Name = "StudentAge";
            // 
            // StudentRegistrationNumber
            // 
            this.StudentRegistrationNumber.DataPropertyName = "RegistrationNumber";
            this.StudentRegistrationNumber.HeaderText = "Registration Number";
            this.StudentRegistrationNumber.Name = "StudentRegistrationNumber";
            // 
            // GridViewGrades
            // 
            this.GridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colGradeValue});
            this.GridViewGrades.Location = new System.Drawing.Point(510, 39);
            this.GridViewGrades.Name = "GridViewGrades";
            this.GridViewGrades.RowTemplate.Height = 25;
            this.GridViewGrades.Size = new System.Drawing.Size(251, 140);
            this.GridViewGrades.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Grades ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // colGradeValue
            // 
            this.colGradeValue.DataPropertyName = "GradeValue";
            this.colGradeValue.HeaderText = "Grade ";
            this.colGradeValue.Name = "colGradeValue";
            // 
            // GridViewCourses
            // 
            this.GridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colSubject});
            this.GridViewCourses.Location = new System.Drawing.Point(12, 241);
            this.GridViewCourses.Name = "GridViewCourses";
            this.GridViewCourses.RowTemplate.Height = 25;
            this.GridViewCourses.Size = new System.Drawing.Size(244, 150);
            this.GridViewCourses.TabIndex = 14;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            // 
            // colSubject
            // 
            this.colSubject.DataPropertyName = "Subject";
            this.colSubject.HeaderText = "Subject";
            this.colSubject.Name = "colSubject";
            // 
            // GridViewScheduledCourses
            // 
            this.GridViewScheduledCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewScheduledCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.colDate});
            this.GridViewScheduledCourses.Location = new System.Drawing.Point(292, 241);
            this.GridViewScheduledCourses.Name = "GridViewScheduledCourses";
            this.GridViewScheduledCourses.RowTemplate.Height = 25;
            this.GridViewScheduledCourses.Size = new System.Drawing.Size(302, 150);
            this.GridViewScheduledCourses.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Scheduled Courses ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Callendar";
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridViewScheduledCourses);
            this.Controls.Add(this.GridViewCourses);
            this.Controls.Add(this.GridViewGrades);
            this.Controls.Add(this.GridViewStudents);
            this.Controls.Add(this.labelScheduledCourses);
            this.Controls.Add(this.labelCourses);
            this.Controls.Add(this.labelGrades);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewScheduledCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button btnLoad;
        private Label labelStudents;
        private Label labelGrades;
        private Label labelCourses;
        private Label labelScheduledCourses;
        private DataGridView GridViewStudents;
        private BindingSource bsStudents;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn StudentAge;
        private DataGridViewTextBoxColumn StudentRegistrationNumber;
        private DataGridView GridViewGrades;
        private DataGridView GridViewCourses;
        private DataGridView GridViewScheduledCourses;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colGradeValue;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn colDate;
    }
}