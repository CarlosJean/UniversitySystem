namespace UniversitySystem
{
    partial class frmSubjectRetirement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.grbSelectedSubjects = new System.Windows.Forms.GroupBox();
            this.dgvSelectedSubjects = new System.Windows.Forms.DataGridView();
            this.SubjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.grbSelectedSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(444, 20);
            this.btnClean.Margin = new System.Windows.Forms.Padding(2);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(109, 43);
            this.btnClean.TabIndex = 34;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(444, 206);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(67, 36);
            this.btnQuitar.TabIndex = 33;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // grbSelectedSubjects
            // 
            this.grbSelectedSubjects.Controls.Add(this.dgvSelectedSubjects);
            this.grbSelectedSubjects.Location = new System.Drawing.Point(11, 124);
            this.grbSelectedSubjects.Margin = new System.Windows.Forms.Padding(2);
            this.grbSelectedSubjects.Name = "grbSelectedSubjects";
            this.grbSelectedSubjects.Padding = new System.Windows.Forms.Padding(2);
            this.grbSelectedSubjects.Size = new System.Drawing.Size(431, 206);
            this.grbSelectedSubjects.TabIndex = 32;
            this.grbSelectedSubjects.TabStop = false;
            this.grbSelectedSubjects.Text = "Materias seleccionadas";
            // 
            // dgvSelectedSubjects
            // 
            this.dgvSelectedSubjects.AllowUserToAddRows = false;
            this.dgvSelectedSubjects.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectedSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSelectedSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectCode,
            this.SubjectName,
            this.Schedule,
            this.teacher});
            this.dgvSelectedSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedSubjects.Location = new System.Drawing.Point(2, 15);
            this.dgvSelectedSubjects.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSelectedSubjects.Name = "dgvSelectedSubjects";
            this.dgvSelectedSubjects.ReadOnly = true;
            this.dgvSelectedSubjects.RowHeadersVisible = false;
            this.dgvSelectedSubjects.RowTemplate.Height = 24;
            this.dgvSelectedSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedSubjects.Size = new System.Drawing.Size(427, 189);
            this.dgvSelectedSubjects.TabIndex = 0;
            // 
            // SubjectCode
            // 
            this.SubjectCode.HeaderText = "Codigo materia";
            this.SubjectCode.Name = "SubjectCode";
            this.SubjectCode.ReadOnly = true;
            // 
            // SubjectName
            // 
            this.SubjectName.HeaderText = "Materia";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // Schedule
            // 
            this.Schedule.HeaderText = "Horario";
            this.Schedule.Name = "Schedule";
            this.Schedule.ReadOnly = true;
            // 
            // teacher
            // 
            this.teacher.HeaderText = "Profesor";
            this.teacher.Name = "teacher";
            this.teacher.ReadOnly = true;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(298, 20);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(67, 36);
            this.btnSearchStudent.TabIndex = 31;
            this.btnSearchStudent.Text = "Buscar ";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 81);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(243, 20);
            this.txtName.TabIndex = 30;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(119, 28);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(140, 20);
            this.txtStudentID.TabIndex = 29;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 81);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Nombre";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(8, 28);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(107, 13);
            this.lblStudentID.TabIndex = 27;
            this.lblStudentID.Text = "Código de estudiante";
            // 
            // frmSubjectRetirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 339);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.grbSelectedSubjects);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudentID);
            this.MaximizeBox = false;
            this.Name = "frmSubjectRetirement";
            this.Text = "Retiro de materias";
            this.grbSelectedSubjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.GroupBox grbSelectedSubjects;
        private System.Windows.Forms.DataGridView dgvSelectedSubjects;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher;
    }
}