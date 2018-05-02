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
    public partial class frmAssignTeacherToSubject : Form
    {
        UniversityContext db = new UniversityContext();
        
        public frmAssignTeacherToSubject()
        {
            InitializeComponent();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            var subject = db.Subject.Find(this.txtSubjectId.Text);

            this.txtSubject.Text = subject.Name;
            
        }
    }
}
