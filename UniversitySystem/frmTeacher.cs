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
    public partial class frmTeacher : Form
    {
        UniversityContext db = new UniversityContext();
        int teacherID = 0;
        public frmTeacher()
        {
            InitializeComponent();
            consultTeachers(this.txtFilter.Text);
            customizeDataGrid();
          
        }

        private void customizeDataGrid()
        {
            dgvDetail.Columns[0].Visible = false;

            dgvDetail.Columns[1].HeaderText = "Nombre";
            dgvDetail.Columns[2].HeaderText = "Apellido";
        }

        private void consultTeachers(string filter)
        {
            var teacher = new List<Teacher>();
            if (filter == "")
            {

                teacher = db.Teacher.ToList();
            }
            else
            {
                teacher = db.Teacher.Where(t => string.Concat(t.Name," ",t.LastName).Contains(filter)).ToList();
            }

            var TeacherList = new BindingList<Teacher>(teacher);

            dgvDetail.DataSource = TeacherList;
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                var teacher = new Teacher
                {
                    Name = this.txtName.Text,
                    LastName = this.txtLastName.Text,

                };
                if (teacher.Name != null && teacher.LastName != null)
                {

                    db.Teacher.Add(teacher);
                    db.SaveChanges();
                    consultTeachers(this.txtFilter.Text);
                    limpiar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (teacherID != 0)
            {
                var teacher = db.Teacher
                .Find(teacherID);

                teacher.Name = this.txtName.Text;
                teacher.LastName = this.txtLastName.Text;
                db.SaveChanges();

                this.limpiar();
                consultTeachers(this.txtFilter.Text);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una profesor");
            }
        }

        private void limpiar()
        {
            teacherID = 0;
            this.txtName.Clear();
            this.txtLastName.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var teacher = db.Teacher.Find(teacherID);
            if (MessageBox.Show(string.Format("¿Está seguro que desea borrar a {0} {1}?", teacher.Name,teacher.LastName).ToString(), "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                db.Teacher.Remove(teacher);
                db.SaveChanges();
                this.limpiar();
                consultTeachers(this.txtFilter.Text);
            }
        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            teacherID = int.Parse(dgvDetail.Rows[int.Parse(dgvDetail.SelectedCells[0].RowIndex.ToString())].Cells[0].Value.ToString());

            var teacher = db.Teacher.Find(teacherID);

            this.txtName.Text = teacher.Name;
            this.txtLastName.Text = teacher.LastName;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            consultTeachers(this.txtFilter.Text);
        }
    }
}
