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
    public partial class FormaDodajKliniku : Form
    {
        List<OdeljenjeView> odeljenja = new List<OdeljenjeView>();
        List<ZaposleniView> zaposleni = new List<ZaposleniView>();
        bool EditKlinika = false;
        int idKlinike = -1;
        public FormaDodajKliniku(bool izmena, int idKlinike)
        {
            InitializeComponent();
            EditKlinika = izmena;
            this.idKlinike = idKlinike; 
        }

        private void FormaDodajKliniku_Load(object sender, EventArgs e)
        {
            odeljenja = DTOManager.VratiOdeljenja();
            zaposleni = DTOManager.VratiZaposlene();

            lbMogucaOdeljenja.Items.Clear();
            foreach (var o in odeljenja)
            {
                lbMogucaOdeljenja.Items.Add(o.Naziv);
            }
            lbMoguciZaposleni.Items.Clear();
            foreach (var z in zaposleni)
            {
                lbMoguciZaposleni.Items.Add($"{z.JMBG}");
            }
            if (EditKlinika) {
                button3.Text = "Izmeni";
                this.Text = "Izmena Klinike";
            }
            else { button3.Text = "Upisi"; this.Text = "Dodavanje Klinike"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbMogucaOdeljenja.SelectedItems.Count > 0)
            {
                lbOdeljenja.Items.Add(lbMogucaOdeljenja.SelectedItems[0]!.ToString()!);
                lbMogucaOdeljenja.Items.Remove(lbMogucaOdeljenja.SelectedItems[0]!.ToString()!);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbOdeljenja.SelectedItems.Count > 0)
            {
                lbMogucaOdeljenja.Items.Add(lbOdeljenja.SelectedItems[0]!.ToString()!);
                lbOdeljenja.Items.Remove(lbOdeljenja.SelectedItems[0]!.ToString()!);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbNaziv.Text == "")
            {
                MessageBox.Show("Naziv je prazan.");
                return;
            }
            if (lbOdeljenja.Items.Count == 0)
            {
                MessageBox.Show("Nema odeljenja u klinici.");
                return;
            }
            if (lbZaposleni.Items.Count == 0)
            {
                MessageBox.Show("Nema zaposlenih u klinici.");
                return;
            }
            if (tbLokacija.Text == "")
            {
                MessageBox.Show("Lokacija je prazna");
                return;
            }
            List<Zaposleni> z = new List<Zaposleni>();
            foreach (var zaposleni in lbZaposleni.Items)
            {
                z.Add(DTOManager.VratiZaposlenog(zaposleni.ToString()!));
            }
            List<Odeljenje> o = new List<Odeljenje>();
            foreach (var odeljenje in lbOdeljenja.Items)
            {
                o.Add(DTOManager.VratiOdeljenjePoNazivu(odeljenje.ToString()!));
            }
            Lokacija l = DTOManager.DodajLokaciju(tbLokacija.Text, tbRadnoVreme.Text);
            if (!EditKlinika)
            {
                DTOManager.DodajKliniku(tbNaziv.Text, o, z, l);
            }
            else
            {
                DTOManager.IzmeniKliniku(idKlinike, tbNaziv.Text, o, z, l);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbZaposleni.SelectedItems.Count > 0)
            {
                lbMoguciZaposleni.Items.Add(lbZaposleni.SelectedItems[0]!.ToString()!);
                lbZaposleni.Items.Remove(lbZaposleni.SelectedItems[0]!.ToString()!);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lbMoguciZaposleni.SelectedItems.Count > 0)
            {
                lbZaposleni.Items.Add(lbMoguciZaposleni.SelectedItems[0]!.ToString()!);
                lbMoguciZaposleni.Items.Remove(lbMoguciZaposleni.SelectedItems[0]!.ToString()!);
            }
        }
    }
}
