namespace UniversitySystem
{
    partial class frmSubjectSelection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.grbSelectedSubjects = new System.Windows.Forms.GroupBox();
            this.dgvSelectedSubjects = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSavechanges = new System.Windows.Forms.Button();
            this.subjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.grbSelectedSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(12, 51);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(142, 17);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Código de estudiante";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(160, 51);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(186, 22);
            this.txtStudentID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 116);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(323, 22);
            this.txtName.TabIndex = 3;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(399, 41);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(89, 44);
            this.btnSearchStudent.TabIndex = 4;
            this.btnSearchStudent.Text = "Buscar ";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // grbDetails
            // 
            this.grbDetails.Controls.Add(this.txtFilter);
            this.grbDetails.Controls.Add(this.lblFilter);
            this.grbDetails.Controls.Add(this.dgvDetail);
            this.grbDetails.Location = new System.Drawing.Point(15, 170);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Size = new System.Drawing.Size(575, 254);
            this.grbDetails.TabIndex = 14;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Detalle";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(128, 23);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(438, 30);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(6, 33);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(60, 25);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filtrar";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(6, 73);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersVisible = false;
            this.dgvDetail.RowTemplate.Height = 24;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(560, 162);
            this.dgvDetail.TabIndex = 0;
            // 
            // grbSelectedSubjects
            // 
            this.grbSelectedSubjects.Controls.Add(this.dgvSelectedSubjects);
            this.grbSelectedSubjects.Location = new System.Drawing.Point(15, 430);
            this.grbSelectedSubjects.Name = "grbSelectedSubjects";
            this.grbSelectedSubjects.Size = new System.Drawing.Size(575, 254);
            this.grbSelectedSubjects.TabIndex = 15;
            this.grbSelectedSubjects.TabStop = false;
            this.grbSelectedSubjects.Text = "Materias seleccionadas";
            // 
            // dgvSelectedSubjects
            // 
            this.dgvSelectedSubjects.AllowUserToAddRows = false;
            this.dgvSelectedSubjects.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectedSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSelectedSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectID,
            this.teacher,
            this.schedule});
            this.dgvSelectedSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedSubjects.Location = new System.Drawing.Point(3, 18);
            this.dgvSelectedSubjects.Name = "dgvSelectedSubjects";
            this.dgvSelectedSubjects.ReadOnly = true;
            this.dgvSelectedSubjects.RowHeadersVisible = false;
            this.dgvSelectedSubjects.RowTemplate.Height = 24;
            this.dgvSelectedSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedSubjects.Size = new System.Drawing.Size(569, 233);
            this.dgvSelectedSubjects.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(596, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 44);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(596, 510);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(89, 44);
            this.btnQuitar.TabIndex = 17;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnSavechanges
            // 
            this.btnSavechanges.Location = new System.Drawing.Point(584, 37);
            this.btnSavechanges.Name = "btnSavechanges";
            this.btnSavechanges.Size = new System.Drawing.Size(145, 53);
            this.btnSavechanges.TabIndex = 18;
            this.btnSavechanges.Text = "Guardar cambios";
            this.btnSavechanges.UseVisualStyleBackColor = true;
            this.btnSavechanges.Click += new System.EventHandler(this.btnSavechanges_Click);
            // 
            // subjectID
            // 
            this.subjectID.HeaderText = "Codigo de materia";
            this.subjectID.Name = "subjectID";
            this.subjectID.ReadOnly = true;
            // 
            // teacher
            // 
            this.teacher.HeaderText = "Profesor";
            this.teacher.Name = "teacher";
            this.teacher.ReadOnly = true;
            // 
            // schedule
            // 
            this.schedule.HeaderText = "Horario";
            this.schedule.Name = "schedule";
            this.schedule.ReadOnly = true;
            // 
            // frmSubjectSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 700);
            this.Controls.Add(this.btnSavechanges);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbSelectedSubjects);
            this.Controls.Add(this.grbDetails);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudentID);
            this.MaximizeBox = false;
            this.Name = "frmSubjectSelection";
            this.Text = "Selección de materias";
            this.Load += new System.EventHandler(this.frmSubjectSelection_Load);
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.grbSelectedSubjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.GroupBox grbSelectedSubjects;
        private System.Windows.Forms.DataGridView dgvSelectedSubjects;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnSavechanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedule;
    }
}