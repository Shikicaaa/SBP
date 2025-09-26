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
    public partial class FormaZakaziTermin : Form
    {
        private string brkartona;
        public FormaZakaziTermin(string brkartona)
        {
            InitializeComponent();
            this.brkartona = brkartona;
        }

        private void FormaZakaziTermin_Load(object sender, EventArgs e)
        {
            List<Lekar> lekari = DTOManager.VratiLekare();
            List<OdeljenjeView> odeljenja = DTOManager.VratiOdeljenja();

            lvLekari.Items.Clear();
            foreach (var l in lekari)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    l.JMBG, $"{l.Ime} {l.Prezime}"
                });
                lvLekari.Items.Add(item);
            }
            lvOdeljenja.Items.Clear();
            foreach (var l in odeljenja)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    l.OdeljenjeID.ToString(), l.Naziv
                });
                lvOdeljenja.Items.Add(item);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lvLekari.SelectedItems.Count > 0 && lvOdeljenja.SelectedItems.Count > 0)
            {
                DateTime datumZakazivanja = dateTimePicker1.Value;
                Pacijent p = DTOManager.VratiP(brkartona);
                Lekar l = DTOManager.GetLekar(lvLekari.SelectedItems[0].SubItems[0].Text);
                Odeljenje o = DTOManager.VratiOdeljenjePoNazivu(lvOdeljenja.SelectedItems[0].SubItems[1].Text);

                DTOManager.ZakaziTermin(new Termin(
                "Zakazan", datumZakazivanja, l, p, o
                ));
                MessageBox.Show("Uspesno zakazan termin!");
                this.Close();
            }
        }
    }
}
