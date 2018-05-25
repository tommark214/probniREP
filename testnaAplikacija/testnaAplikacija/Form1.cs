using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testnaAplikacija
{
    public partial class Form1 : Form
    {

        TIm novi = null;
        Student noviStudent = null;

        BindingList<TIm> listaTimova = new BindingList<TIm>();
        BindingList<Student> studenti = new BindingList<Student>();

        public Form1()
        {
            InitializeComponent();

            cmbTimovi.DataSource = listaTimova;
            cmbTimovi.DisplayMember = "OznakaTima";


            lbPopisTimova.DataSource = listaTimova;
            lbStudentiTima.DataSource = studenti;
        }

        private void btnSpremiTim_Click(object sender, EventArgs e)
        {
            novi = new TIm();
            novi.OznakaTima = txtOznakaTima.Text;
            novi.NazivProjekta = txtNazivProjekta.Text;

            listaTimova.Add(novi);

        }

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            noviStudent = new Student();

            noviStudent.Ime = txtIme.Text;
            noviStudent.Prezime = txtPrezime.Text;
            noviStudent.pripadajuciTim = (cmbTimovi.SelectedItem as TIm).OznakaTima;

            studenti.Add(noviStudent);
        }

        private void lbPopisTimova_SelectedIndexChanged(object sender, EventArgs e)
        {
            int odabir = lbPopisTimova.SelectedIndex;

            if (odabir == lbStudentiTima.SelectedIndex)
            {
                
            }

        }
    }
}
