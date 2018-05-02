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
    public partial class frmTeacherSelection : Form
    {
        UniversityContext db = new UniversityContext();
        public frmTeacherSelection()
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
                teacher = db.Teacher.Where(h => h.Name.Contains(filter)).ToList();
            }

            var headquarterList = new BindingList<Teacher>(teacher);

            dgvDetail.DataSource = headquarterList;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            consultTeachers(this.txtFilter.Text);
        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedSubject.subjectID = int.Parse(dgvDetail.Rows[int.Parse(dgvDetail.SelectedCells[0].RowIndex.ToString())].Cells[0].Value.ToString());

            SelectedSubject.subjectName = dgvDetail.Rows[int.Parse(dgvDetail.SelectedCells[0].RowIndex.ToString())].Cells[1].Value.ToString();

            frmTeacherSubjectAssignament frm = new frmTeacherSubjectAssignament();

          /*  frm.txtTeacher.Text = dgvDetail.Rows[int.Parse(dgvDetail.SelectedCells[0].RowIndex.ToString())].Cells[1].Value.ToString();
            frm.txtTeacherId.Text = dgvDetail.Rows[int.Parse(dgvDetail.SelectedCells[0].RowIndex.ToString())].Cells[0].Value.ToString();
            */

            frm.Activate();
            this.Hide();


        }
    }
}
