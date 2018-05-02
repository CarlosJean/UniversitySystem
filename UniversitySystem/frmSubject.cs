using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystem
{
    public partial class frmSubject : Form
    {
        UniversityContext db = new UniversityContext();
        int subjectID = 0;

        public frmSubject()
        {
            InitializeComponent();
           consultSubjects(this.txtFilter.Text);
            customizeDataGrid();
            loadTeachers();

        }

        private void loadTeachers()
        {
            var teachers = db.Teacher.ToList();

            cmbTeachers.DataSource = teachers;
            cmbTeachers.DisplayMember = "FullName";
            cmbTeachers.ValueMember = "TeacherId";
        }

        private void customizeDataGrid()
        {
            dgvDetail.Columns[0].Visible = false;

            dgvDetail.Columns[1].HeaderText = "Nombre";
            dgvDetail.Columns[2].HeaderText = "Profesor";
        }

        private void consultSubjects(string filter)
        {
          

            if (filter == "")
            {
                var subject = (from t in db.Teacher
                               join s in db.Subject on t.TeacherId equals s.Teacher.TeacherId
                               select new {Codigo=s.SubjectID, Nombre = s.Name, Profesor = string.Concat(s.Teacher.Name, " ", s.Teacher.LastName), Horario = s.Schedule }).ToList();
                dgvDetail.DataSource = subject;

            }
            else
            {
                var subject = (from t in db.Teacher
                               join s in db.Subject.Where(s => s.Name.Contains(filter)) on t.TeacherId equals s.Teacher.TeacherId
                               select new { Nombre = s.Name, Profesor = string.Concat(s.Teacher.Name, " ", s.Teacher.LastName), Horario = s.Schedule }).ToList();
                dgvDetail.DataSource = subject;

            }
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var subject = new Subject
                {
                    Name = this.txtName.Text,
                    Schedule = this.txtSchedule.Text,
                    Teacher = db.Teacher.Find(int.Parse(this.cmbTeachers.SelectedValue.ToString()))
                };

                if (subject.Name != null && subject.Schedule != null)
                {
                    db.Subject.Add(subject);
                    db.SaveChanges();
                    limpiar();
                    consultSubjects(this.txtFilter.Text);

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ex.ToString());
            }
          

        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            subjectID = int.Parse(dgvDetail.Rows[int.Parse(dgvDetail.SelectedCells[0].RowIndex.ToString())].Cells[0].Value.ToString());

            var subject = db.Subject.Find(subjectID);

            this.txtName.Text = subject.Name;
            this.txtSchedule.Text = subject.Schedule;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                if (subjectID != 0)
                {
                    var subject = db.Subject.Find(subjectID);

                    subject.Name = this.txtName.Text;
                    subject.Schedule = this.txtSchedule.Text;
                    subject.Teacher = db.Teacher.Find(int.Parse(this.cmbTeachers.SelectedValue.ToString()));
                    db.SaveChanges();

                    this.limpiar();
                    consultSubjects(this.txtFilter.Text);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una sede.","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                if (ex is NullReferenceException)
                {
                    MessageBox.Show("Debe dar doble click al elemento que desea seleccionar.");

                }
            }
       
        }

        private void limpiar()
        {
            this.subjectID = 0;
            this.txtName.Clear();
            this.txtSchedule.Clear();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var subject = db.Subject.Find(subjectID);
                if (MessageBox.Show(string.Format("¿Está seguro que desea borrar a {0}?", subject.Name).ToString(), "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    db.Subject.Remove(subject);
                    db.SaveChanges();
                    this.limpiar();
                    consultSubjects(this.txtFilter.Text);
                }

            }
            catch (Exception ex)
            {

                if (ex is NullReferenceException)
                {
                    MessageBox.Show("Debe dar doble click al elemento que desea seleccionar.");

                }
            }
          

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            consultSubjects(this.txtFilter.Text);
        }

        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
