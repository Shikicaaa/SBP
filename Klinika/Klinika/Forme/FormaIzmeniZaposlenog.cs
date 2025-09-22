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
    public partial class FormaIzmeniZaposlenog : Form
    {
        private ZaposleniDetailed zaposleni;
        public FormaIzmeniZaposlenog(ZaposleniDetailed zaposleni)
        {
            InitializeComponent();
            this.zaposleni = zaposleni;
        }

        private void FormaIzmeniZaposlenog_Load(object sender, EventArgs e)
        {
            tbJMBG.Text = zaposleni.JMBG;
            tbIme.Text = zaposleni.Ime;
            tbPrezime.Text = zaposleni.Prezime;
            textBox1.Text = zaposleni.Adresa;
            textBox2.Text = zaposleni.KontaktTelefon;

            panelLekar.Visible = false;
            panelLaborant.Visible = false;

            if (this.zaposleni is LekarDetailed lekar)
            {
                panelLekar.Visible = true;
                foreach (var odeljenje in lekar.Odeljenja)
                {
                    listaOdeljenja.Items.Add(odeljenje.Naziv);
                }
            }
            else if (this.zaposleni is LaborantDetailed laborant)
            {
                panelLaborant.Visible = true;
                foreach (var sertifikat in laborant.Sertifikati)
                {
                    listaSertifikata.Items.Add($"{sertifikat.Naziv} ({sertifikat.DatumIzdavanja.ToShortDateString()})");
                }
                foreach(var oblast in laborant.OblastiRada)
                {
                    listaOblasti.Items.Add($"{oblast.Naziv} ({oblast.Naziv})");
                }
            }
        }
    }
}
