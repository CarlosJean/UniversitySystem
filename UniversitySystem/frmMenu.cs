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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHeadquarter frm = new frmHeadquarter();
            frm.Show();
        }

        private void profesoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTeacher frm = new frmTeacher();
            frm.Show();
        }

        private void asignaciónDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherSubjectAssignament frm = new frmTeacherSubjectAssignament();
            frm.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubject frm = new frmSubject();
            frm.Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void asignaciónDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssignTeacherToSubject frm = new frmAssignTeacherToSubject();
            frm.Show();
        }

        private void estudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStudent frm = new frmStudent();
            frm.Show();
        }

        private void seleccionDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectSelection frm = new frmSubjectSelection();
            frm.Show();
        }

        private void retiroDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectRetirement frm = new frmSubjectRetirement();
            frm.Show();

        }
    }
}
