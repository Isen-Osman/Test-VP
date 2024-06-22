using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForm
{
    public partial class DodadiStudentForm : Form
    {
        public StudentClass studentClass;
        public DodadiStudentForm()
        {
            InitializeComponent();
        }

        private void btnDodadiStudent_Click(object sender, EventArgs e)
        {
            studentClass = new StudentClass(lbIndeks.Text,lbImeiPrezime.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbIndeks_Validating(object sender, CancelEventArgs e)
        {
            if(lbIndeks.Text.Length == 6) {

                errorProvider1.SetError(lbIndeks, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(lbIndeks, "Mora da sodrzi tocno 6 znaci");
                e.Cancel = true;
            }
        }

        private void lbIme_Validating(object sender, CancelEventArgs e)
        {
            if(lbImeiPrezime.Text.Length > 3) {
                errorProvider1.SetError(lbImeiPrezime, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(lbImeiPrezime, "Napisete ime i prezime");
                e.Cancel = true;
            }
        }

        private void lbImeiPrezime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
