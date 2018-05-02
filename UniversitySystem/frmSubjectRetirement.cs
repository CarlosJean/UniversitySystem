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
    public partial class frmSubjectRetirement : Form
    {
        UniversityContext db = new UniversityContext();
        public frmSubjectRetirement()
        {
            InitializeComponent();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                var student = db.Student.Find(int.Parse(this.txtStudentID.Text));
                this.txtName.Text = student.Name + " " + student.LastName;

                var studentSubjects = student.Subjects;
                foreach (Subject subject in student.Subjects)
                {
                    dgvSelectedSubjects.Rows.Add(subject.SubjectID.ToString(), subject.Name, subject.Schedule, subject.Teacher.FullName);
                }

            }
            catch (Exception)
            {
            }
           

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.txtName.Clear();
            this.txtStudentID.Clear();

            this.txtName.Focus();
            dgvSelectedSubjects.Rows.Clear();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            var subject = db.Subject.Find(int.Parse(dgvSelectedSubjects.Rows[dgvSelectedSubjects
                          .SelectedCells[0].RowIndex].Cells[0].Value.ToString()));

            var student = db.Student.Find(int.Parse(this.txtStudentID.Text));

            var studentSubjects = student.Subjects;


            if (MessageBox.Show(string.Format("¿Desea eliminar {0} de este horario?",subject.Name),"Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                student.Subjects.Remove(subject);
                db.SaveChanges();

               student = db.Student.Find(int.Parse(this.txtStudentID.Text));

                dgvSelectedSubjects.Rows.Clear();

                 studentSubjects = student.Subjects;
                foreach (Subject subj in student.Subjects)
                {
                    dgvSelectedSubjects.Rows.Add(subj.SubjectID.ToString(), subj.Name, subj.Schedule, subj.Teacher.FullName);
                }
            }
        }
    }
}
