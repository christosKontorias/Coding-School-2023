namespace Session_10 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.studentGrid = new System.Windows.Forms.DataGridView();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bsStudents = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.gradeGrid = new System.Windows.Forms.DataGridView();
            this.colGradeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGradeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsGrades = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.courseGrid = new System.Windows.Forms.DataGridView();
            this.colCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduledCourseGrid = new System.Windows.Forms.DataGridView();
            this.colScheduledCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCallendar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCourses = new System.Windows.Forms.BindingSource(this.components);
            this.bsScheduledCourses = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledCourseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsScheduledCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // studentGrid
            // 
            this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentID,
            this.colStudentName,
            this.colRegistrationNumber,
            this.colAge});
            this.studentGrid.Location = new System.Drawing.Point(12, 40);
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.RowTemplate.Height = 25;
            this.studentGrid.Size = new System.Drawing.Size(345, 150);
            this.studentGrid.TabIndex = 0;
            // 
            // colStudentID
            // 
            this.colStudentID.DataPropertyName = "ID";
            this.colStudentID.HeaderText = "ID";
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.Visible = false;
            // 
            // colStudentName
            // 
            this.colStudentName.DataPropertyName = "Name";
            this.colStudentName.HeaderText = "Name";
            this.colStudentName.Name = "colStudentName";
            // 
            // colRegistrationNumber
            // 
            this.colRegistrationNumber.DataPropertyName = "RegistrationNumber";
            this.colRegistrationNumber.HeaderText = "Registration Number";
            this.colRegistrationNumber.Name = "colRegistrationNumber";
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grades";
            // 
            // gradeGrid
            // 
            this.gradeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGradeID,
            this.colGradeValue});
            this.gradeGrid.Location = new System.Drawing.Point(13, 239);
            this.gradeGrid.Name = "gradeGrid";
            this.gradeGrid.RowTemplate.Height = 25;
            this.gradeGrid.Size = new System.Drawing.Size(345, 150);
            this.gradeGrid.TabIndex = 3;
            // 
            // colGradeID
            // 
            this.colGradeID.DataPropertyName = "ID";
            this.colGradeID.HeaderText = "ID";
            this.colGradeID.Name = "colGradeID";
            this.colGradeID.Visible = false;
            // 
            // colGradeValue
            // 
            this.colGradeValue.DataPropertyName = "GradeValue";
            this.colGradeValue.HeaderText = "Grade";
            this.colGradeValue.Name = "colGradeValue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(439, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Courses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(439, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Scheduled Courses";
            // 
            // courseGrid
            // 
            this.courseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourseID,
            this.colCode,
            this.colSubject});
            this.courseGrid.Location = new System.Drawing.Point(439, 40);
            this.courseGrid.Name = "courseGrid";
            this.courseGrid.RowTemplate.Height = 25;
            this.courseGrid.Size = new System.Drawing.Size(345, 150);
            this.courseGrid.TabIndex = 6;
            // 
            // colCourseID
            // 
            this.colCourseID.DataPropertyName = "ID";
            this.colCourseID.HeaderText = "ID";
            this.colCourseID.Name = "colCourseID";
            this.colCourseID.Visible = false;
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
            // scheduledCourseGrid
            // 
            this.scheduledCourseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduledCourseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colScheduledCourseID,
            this.colCallendar});
            this.scheduledCourseGrid.Location = new System.Drawing.Point(439, 239);
            this.scheduledCourseGrid.Name = "scheduledCourseGrid";
            this.scheduledCourseGrid.RowTemplate.Height = 25;
            this.scheduledCourseGrid.Size = new System.Drawing.Size(345, 150);
            this.scheduledCourseGrid.TabIndex = 7;
            // 
            // colScheduledCourseID
            // 
            this.colScheduledCourseID.DataPropertyName = "ID";
            this.colScheduledCourseID.HeaderText = "ID";
            this.colScheduledCourseID.Name = "colScheduledCourseID";
            this.colScheduledCourseID.Visible = false;
            // 
            // colCallendar
            // 
            this.colCallendar.DataPropertyName = "Callendar";
            this.colCallendar.HeaderText = "Date";
            this.colCallendar.Name = "colCallendar";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(358, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(449, 415);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(262, 415);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 10;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.scheduledCourseGrid);
            this.Controls.Add(this.courseGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gradeGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledCourseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsScheduledCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView studentGrid;
        private Label label1;
        private BindingSource bsStudents;
        private Label label2;
        private DataGridView gradeGrid;
        private BindingSource bsGrades;
        private Label label3;
        private Label label4;
        private DataGridView courseGrid;
        private DataGridView scheduledCourseGrid;
        private BindingSource bsCourses;
        private BindingSource bsScheduledCourses;
        private Button btnSave;
        private Button btnLoad;
        private Button btnPopulate;
        private DataGridViewTextBoxColumn colStudentID;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colRegistrationNumber;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colCourseID;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn colScheduledCourseID;
        private DataGridViewTextBoxColumn colCallendar;
        private DataGridViewTextBoxColumn colGradeID;
        private DataGridViewTextBoxColumn colGradeValue;
    }
}