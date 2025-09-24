using Klinika.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinika.Forme
{
    public partial class FormaDodajPacijenta : Form
    {
        List<Lekar> lekari = new List<Lekar>();
        public FormaDodajPacijenta()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormaDodajPacijenta_Load(object sender, EventArgs e)
        {
            lekari = DTOManager.VratiLekare();
            lvLekari.Items.Clear();
            foreach (Lekar l in lekari)
            {
                lvLekari.Items.Add(new ListViewItem(new string[]
                {
                    l.Ime, l.Prezime, l.JMBG, l.Specijalizacija
                }));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string brkart = tbBrojKartona.Text;
            string ime = tbIme.Text;
            string prezime = tbPrezime.Text;
            char pol = (rbMusko.Checked ? 'M' : 'Z');
            string adresa = tbAdresa.Text;
            DateTime datumrodj = datumRodjPicker.Value;
            string kontakttel = tbKontaktTel.Text;
            string mail = tbEmail.Text;
            string rfzo = tbBrojrfzo.Text;
            char imarfzo = (rbImaRfzo.Checked ? 'D' : 'N');
            Lekar izabrani = null;
            if(lvLekari.SelectedItems.Count > 0)
            {
                ListViewItem item = lvLekari.SelectedItems[0];
                string jmbg = item.SubItems[2].Text;
                izabrani = DTOManager.VratiLekara(jmbg);
            }
            if (brkart.Length < 1 || ime.Length < 1 || prezime.Length < 1 || adresa.Length < 1 || datumrodj == null || kontakttel.Length < 1 || mail.Length < 1 || rfzo.Length < 1)
            {
                MessageBox.Show("Nisu sva potrebna polja popunjena!");
                return;
            }
            try
            {
                DTOManager.DodajPacijenta(brkart, ime, prezime, pol, adresa, datumrodj, kontakttel, mail, rfzo, imarfzo, izabrani);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
