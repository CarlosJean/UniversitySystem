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
    public partial class frmTeacherSubjectAssignament : Form
    {
        UniversityContext db = new UniversityContext();
        int subjectID = 0;
        public frmTeacherSubjectAssignament()
        {
            InitializeComponent();
            consultSubjects(this.txtFilter.Text);
        }

        private void consultSubjects(string filter)
        {  var subject = new List<Subject>();
            if (filter == "")
            {

                subject = db.Subject.ToList();
            }
            else
            {
                subject = db.Subject.Where(h => h.Name.Contains(filter)).ToList();
            }

            var subjectList = new BindingList<Subject>(subject);

            dgvDetail.DataSource = subjectList;

        }

        private void btnSelectTeacher_Click(object sender, EventArgs e)
        {
            frmTeacherSelection frm = new frmTeacherSelection();
            frm.Show();
        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            subjectID = int.Parse(dgvDetail.Rows[int.Parse(dgvDetail.SelectedCells[0].RowIndex.ToString())].Cells[0].Value.ToString());

            var subject = db.Subject.Find(subjectID);

            
            this.txtSubject.Text = subject.Name;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
           
            var teacher = db.Teacher.Find(int.Parse(this.txtTeacherId.Text));
            var subject = db.Subject.Find(subjectID);
           
            teacher.Subjects.Add(subject);
            
                db.SaveChanges();
                consultSubjects(this.txtFilter.Text);

            if (MessageBox.Show(string.Format("¿Desea agregar más materias a {0} {1}?", teacher.Name, teacher.LastName), "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SelectedSubject.subjectID = 0;
                this.txtSubject.Clear();
                this.txtFilter.Clear();
            }
            else
            { 
                limpiar();
            }
        }

        private void limpiar()
        {
            this.txtFilter.Clear();
            this.txtSubject.Clear();
            this.txtTeacher.Clear();
            this.txtTeacherId.Clear();
            subjectID = 0;
            SelectedSubject.subjectID = 0;
            SelectedSubject.subjectName = "";
        }

        private void frmTeacherSubjectAssignament_Activated(object sender, EventArgs e)
        {
            if (SelectedSubject.subjectID!= 0 && SelectedSubject.subjectName!="")
            {
                this.txtTeacherId.Text = SelectedSubject.subjectID.ToString();
                this.txtTeacher.Text = SelectedSubject.subjectName.ToString();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
