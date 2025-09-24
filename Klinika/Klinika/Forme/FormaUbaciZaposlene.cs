using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Klinika.Forme
{
    public partial class FormaUbaciZaposlene : Form
    {
        public FormaUbaciZaposlene()
        {
            InitializeComponent();
        }

        private void tbTip_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbTip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(
                tbIme.Text == "" || tbPrezime.Text == "" ||
                tbJMBG.Text == "" || tbAdresa.Text == "" ||
                tbEmail.Text == "" || tbKontaktTelefona.Text == ""
            )
            {
                MessageBox.Show("Unos nije validan, neko polje je prazno!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(comboBox1.Text == "Lekar")
            {
                string specijalizacija = Interaction.InputBox("Unesite Specijalizaciju", "Specijalizacija lekara", "Hirurg");
                string brLicence = Interaction.InputBox("Unesite broj licence", "Broj Licence lekara", "L12345678123");
                LekarDetailed noviLekar = new LekarDetailed()
                {
                    JMBG = tbJMBG.Text,
                    Ime = tbIme.Text,
                    Prezime = tbPrezime.Text,
                    DatumRodjenja = dtpRodjenje.Value,
                    Adresa = tbAdresa.Text,
                    KontaktTelefon = tbKontaktTelefona.Text,
                    Email = tbEmail.Text,
                    DatumZaposlenja = dtpDatumZaposlenja.Value,
                    Specijalizacija = specijalizacija,
                    BRLicence = brLicence
                };
                DTOManager.DodajLekara(noviLekar);

            }
            else if(comboBox1.Text == "Laborant")
            {
                LaborantDetailed noviLaborant = new LaborantDetailed()
                {
                    JMBG = tbJMBG.Text,
                    Ime = tbIme.Text,
                    Prezime = tbPrezime.Text,
                    DatumRodjenja = dtpRodjenje.Value,
                    Adresa = tbAdresa.Text,
                    KontaktTelefon = tbKontaktTelefona.Text,
                    Email = tbEmail.Text,
                    DatumZaposlenja = dtpDatumZaposlenja.Value
                };
                DTOManager.DodajLaboranta(noviLaborant);
            }
            else if (comboBox1.Text == "Medicinska Sestra")
            {
                MedicinskaSestraDetailed novaSestra = new MedicinskaSestraDetailed()
                {
                    JMBG = tbJMBG.Text,
                    Ime = tbIme.Text,
                    Prezime = tbPrezime.Text,
                    DatumRodjenja = dtpRodjenje.Value,
                    Adresa = tbAdresa.Text,
                    KontaktTelefon = tbKontaktTelefona.Text,
                    Email = tbEmail.Text,
                    DatumZaposlenja = dtpDatumZaposlenja.Value
                };
                DTOManager.DodajMedicinskuSestru(novaSestra);
            }
            else if (comboBox1.Text == "Administracija")
            {
                AdministratorDetailed noviAdmin = new AdministratorDetailed()
                {
                    JMBG = tbJMBG.Text,
                    Ime = tbIme.Text,
                    Prezime = tbPrezime.Text,
                    DatumRodjenja = dtpRodjenje.Value,
                    Adresa = tbAdresa.Text,
                    KontaktTelefon = tbKontaktTelefona.Text,
                    Email = tbEmail.Text,
                    DatumZaposlenja = dtpDatumZaposlenja.Value
                };
                DTOManager.DodajAdministratora(noviAdmin);
            }
            else
            {
                MessageBox.Show("Ne moze taj tip...", "Bezobrazno", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            this.Close();
        }
    }
}
