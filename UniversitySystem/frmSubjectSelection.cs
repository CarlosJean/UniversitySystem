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
    public partial class frmSubjectSelection : Form
    {
        UniversityContext db = new UniversityContext();
        public frmSubjectSelection()
        {
            InitializeComponent();
            consultSubjects(this.txtFilter.Text);
            customizeDatagrid();
        }

        private void customizeDatagrid()
        {
            dgvDetail.Columns[0].Visible = false;
            dgvSelectedSubjects.Columns[0].Visible = false;
        }

        private void consultSubjects(string filter)
        {
            if (filter == "")
            {
                var subject = (from t in db.Teacher
                               join s in db.Subject on t.TeacherId equals s.Teacher.TeacherId
                               select new { Codigo = s.SubjectID, Nombre = s.Name, Profesor = string.Concat(s.Teacher.Name, " ", s.Teacher.LastName), Horario = s.Schedule }).ToList();
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

        private void frmSubjectSelection_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
        
            var student = db.Student.Find(int.Parse(this.txtStudentID.Text));
            if (student!=null)
            {

            this.txtName.Text = student.Name + " " + student.LastName;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            consultSubjects(this.txtFilter.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            dgvSelectedSubjects.Rows.Add(dgvDetail.Rows[Convert.ToInt32(dgvDetail.SelectedCells[0].RowIndex)].Cells[0].Value.ToString(), dgvDetail.Rows[Convert.ToInt32(dgvDetail.SelectedCells[0].RowIndex)].Cells[1].Value.ToString(), dgvDetail.Rows[Convert.ToInt32(dgvDetail.SelectedCells[0].RowIndex)].Cells[2].Value.ToString());
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            dgvSelectedSubjects.Rows.Remove(dgvSelectedSubjects.Rows[Convert.ToInt32(dgvSelectedSubjects.SelectedCells[0].RowIndex)]);

        }

        private void btnSavechanges_Click(object sender, EventArgs e)
        {

            var student = db.Student.Find(int.Parse(this.txtStudentID.Text));
            
             for (int i = 0; i <dgvSelectedSubjects.RowCount ; i++)
            {
               
                var subject = db.Subject.Find(int.Parse(dgvSelectedSubjects.Rows[i].Cells[0].Value.ToString()));
            subject.Students.Add(student);
            db.SaveChanges();
            }
        }
    }
}
