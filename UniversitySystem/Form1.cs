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
    public partial class frmHeadquarter : Form
    {

        UniversityContext db = new UniversityContext();
        int headquarterID=0; 


        public frmHeadquarter()
        {
            InitializeComponent();
            consultHeadquarters(this.txtFilter.Text);

             dgvDetail.Columns[0].Visible = false;

            dgvDetail.Columns[1].HeaderText = "Nombre";
            dgvDetail.Columns[2].HeaderText = "Dirección";
            dgvDetail.Columns[3].HeaderText = "Teléfono";
        }

        private void consultHeadquarters(string filtrar)
        {
           
            var headquarter = new List<Headquarters>();
            if (filtrar == "")
            {

                 headquarter = db.Headquarter.ToList();
            }
            else
            {
                headquarter = db.Headquarter.Where(h => h.Name.Contains(filtrar) ).ToList();
            }

            var headquarterList = new BindingList<Headquarters>(headquarter);

            dgvDetail.DataSource = headquarterList;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

            var headquarter = new Headquarters
            {
                Name = this.txtName.Text,
                Address = this.txtAddress.Text,
                Phone = long.Parse(this.txtPhone.Text)

            };
                if (headquarter.Name!=null && headquarter.Address!=null )
                {
                 
                    db.Headquarter.Add(headquarter);
                    db.SaveChanges();
                    consultHeadquarters(this.txtFilter.Text);
                    limpiar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ex.Message);
            }



        }

        private void limpiar()
        {
            this.headquarterID = 0;
            this.txtName.Clear();
            this.txtPhone.Clear();
            this.txtAddress.Clear();
        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            headquarterID= int.Parse(dgvDetail.Rows[int.Parse(dgvDetail.SelectedCells[0].RowIndex.ToString())].Cells[0].Value.ToString());

            var headquarter = db.Headquarter.Find(headquarterID);

            this.txtName.Text = headquarter.Name;
            this.txtAddress.Text = headquarter.Address;
            this.txtPhone.Text = headquarter.Phone.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (headquarterID != 0)
            {
                var headquarter = db.Headquarter.Find(headquarterID);

                headquarter.Name = this.txtName.Text;
                headquarter.Address = this.txtAddress.Text;
                headquarter.Phone = long.Parse(this.txtPhone.Text);
                db.SaveChanges();

                this.limpiar();
                consultHeadquarters(this.txtFilter.Text);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una sede");
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var headquarter = db.Headquarter.Find(headquarterID);
            if (MessageBox.Show(string.Format("¿Está seguro que desea borrar a {0}?",headquarter.Name).ToString(),"Pregunta",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk)==DialogResult.Yes)
            {
                db.Headquarter.Remove(headquarter);
                db.SaveChanges();
                this.limpiar();
                consultHeadquarters(this.txtFilter.Text);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            consultHeadquarters(this.txtFilter.Text);
        }
    }
}
