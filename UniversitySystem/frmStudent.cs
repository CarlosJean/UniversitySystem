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
    public partial class frmStudent : Form
    {
        UniversityContext db = new UniversityContext();
        int studentID = 0;
        public frmStudent()
        {
            InitializeComponent();
            consultStudents(this.txtFilter.Text);
            customizeDataGrid();
            loadHeadquarters();

        }

        private void customizeDataGrid()
        {
            dgvDetail.Columns[0].Visible = false;

            dgvDetail.Columns[1].HeaderText = "Estudiante";
            dgvDetail.Columns[2].HeaderText = "Sede";
        }

        private void loadHeadquarters()
        {

            var headquarters = db.Headquarter.ToList();

            cmbHeadquarters.DisplayMember = "Name";
            cmbHeadquarters.ValueMember = "HeadquartersId";
            cmbHeadquarters.DataSource = headquarters;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                var student = new Student
                {
                    Name = this.txtName.Text,
                    LastName = this.txtLastName.Text,
                    Headquarter = db.Headquarter.Find(int.Parse(this.cmbHeadquarters.SelectedValue.ToString()))

                };
                if (student.Name != null && student.LastName != null)
                {

                    db.Student.Add(student);
                    db.SaveChanges();
                    consultStudents(this.txtFilter.Text);
                    limpiar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void consultStudents(string filter)
        {
            //var student = new List<Student>();
            if (filter == "")
            {

                var student = (from h in db.Headquarter
                              join s in db.Student on h.HeadquartersId equals s.Headquarter.HeadquartersId
                              select new { IDEstudiante=s.StudentID, Estudiante= string.Concat(s.Name," ",s.LastName), Sede= h.Name}).ToList();

                dgvDetail.DataSource = student;
                //db.Student.ToList();
            }
            else
            {
                var student = (from h in db.Headquarter
                               join s in db.Student.Where(s => string.Concat(s.Name, " ", s.LastName).Contains(filter)) on h.HeadquartersId equals s.Headquarter.HeadquartersId
                              
                              select new { IDEstudiante = s.StudentID, Estudiante = string.Concat(s.Name, " ", s.LastName), Sede = h.Name }).ToList();
                dgvDetail.DataSource = student;
            }

            //var TeacherList = new BindingList<Student>(student);

           // dgvDetail.DataSource = TeacherList;

        }

        private void limpiar()
        {
            this.txtName.Clear();
            this.txtLastName.Clear();
            this.txtFilter.Clear();
            studentID = 0;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            consultStudents(this.txtFilter.Text);
        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            studentID = int.Parse(dgvDetail.Rows[int.Parse(dgvDetail.SelectedCells[0].RowIndex.ToString())].Cells[0].Value.ToString());

            var student = db.Student.Find(studentID);

            this.txtName.Text = student.Name;
            this.txtLastName.Text = student.LastName;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (studentID != 0)
            {
                var student = db.Student
                .Find(studentID);

                student.Name = this.txtName.Text;
                student.LastName = this.txtLastName.Text;
                student.Headquarter = db.Headquarter.Find(int.Parse(this.cmbHeadquarters.SelectedValue.ToString()));
                db.SaveChanges();

                this.limpiar();
                consultStudents(this.txtFilter.Text);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una estudiante");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentID != 0)
                {
                    var student = db.Student.Find(studentID);
                    if (MessageBox.Show(string.Format("¿Está seguro que desea borrar a {0} {1}?", student.Name, student.LastName).ToString(), "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        db.Student.Remove(student);
                        db.SaveChanges();
                        this.limpiar();
                        consultStudents(this.txtFilter.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un estudiante","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error"+ex);
            }
           
        }
    }

    
}
