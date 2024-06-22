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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodadiStudent_Click(object sender, EventArgs e)
        {
            DodadiStudentForm dodadiStudentForm = new DodadiStudentForm();

            if(dodadiStudentForm.ShowDialog() == DialogResult.OK)
            {
                lbStudenti.Items.Add(dodadiStudentForm.studentClass);

            }
           
        }

        private void btnDodadiUplati_Click(object sender, EventArgs e)
        {
            if(lbStudenti.SelectedItems.Count > 0)
            {
                StudentClass student = lbStudenti.SelectedItem as StudentClass;
                student.dodadiUplata(new UplataClass(nudUplati.Value));
                UpdateDetails();
            }
        }

        private void lbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDetails();

        }
        public void UpdateDetails()
        {
            if (lbStudenti.SelectedItems.Count > 0)
            {
                StudentClass student = lbStudenti.SelectedItem as StudentClass;
                lbStudentInfo.Text = student.Details();

            }

        }

        private void btnIzbrisiUplati_Click(object sender, EventArgs e)
        {
            if(lbStudenti.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("dali si siguren","siguren li si", MessageBoxButtons.YesNo) == DialogResult.Yes)
                { 
                 StudentClass student = lbStudenti.SelectedItem as StudentClass ;
                    student.uplataClasses = new List<UplataClass>();
                    UpdateDetails();
                
                }
                

            }
        }
    }
}
