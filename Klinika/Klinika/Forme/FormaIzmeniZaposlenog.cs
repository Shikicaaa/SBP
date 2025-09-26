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
        private string jmbg;
        List<OdeljenjeView> odeljenja;
        List<OdeljenjeView> odeljenjaLekara;
        List<Pacijent> izabraniLekar;
        public FormaIzmeniZaposlenog(string jmbg)
        {
            InitializeComponent();
            this.jmbg = jmbg;

        }
        private void Osvezi()
        {
            odeljenja = DTOManager.VratiOdeljenja();
            odeljenjaLekara = DTOManager.VratiNadredjenoOdeljenje(jmbg);
            izabraniLekar = DTOManager.VratiPacijenteLekara(jmbg);
            lvPacijenti.Items.Clear();
            foreach (var i in izabraniLekar)
            {
                lvPacijenti.Items.Add(new ListViewItem(new string[]
                {
                    i.BrojKartona, i.Ime, i.Prezime
                }));
            }
            lvNadredjeneSobe.Items.Clear();
            foreach (var i in odeljenjaLekara)
            {
                lvNadredjeneSobe.Items.Add(new ListViewItem(new string[]
                {
                    i.OdeljenjeID.ToString(), i.BrSobe
                }));
            }
            mogucaOdeljenja.Items.Clear();
            foreach (var i in odeljenja)
            {
                if (!odeljenjaLekara.Contains(i))
                {
                    mogucaOdeljenja.Items.Add(new ListViewItem(new string[]
                    {
                        i.OdeljenjeID.ToString(), i.BrSobe
                    }));
                }
            }
        }
        private void FormaIzmeniZaposlenog_Load(object sender, EventArgs e)
        {
            Osvezi();
            tbSpecijalizacija.Text = DTOManager.VratiLekara(jmbg).Specijalizacija;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mogucaOdeljenja.SelectedItems.Count > 0)
            {
                DTOManager.Nadredi(jmbg, int.Parse(mogucaOdeljenja.SelectedItems[0].SubItems[0].Text));
                Osvezi();
            }
            else
            {
                MessageBox.Show("Odaberite bar 1 odeljenje.");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DTOManager.PromeniSpecijalizaciju(jmbg, tbSpecijalizacija.Text);
        }
    }
}
