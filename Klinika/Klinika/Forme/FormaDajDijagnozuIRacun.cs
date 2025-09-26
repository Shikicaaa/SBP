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
    public partial class FormaDajDijagnozuIRacun : Form
    {
        Lekar l;
        List<Termin>? termini;
        List<UslugaView>? usluge;
        double cena = 0.0;
        public FormaDajDijagnozuIRacun(Lekar lekar)
        {
            InitializeComponent();
            l = lekar;

        }

        private void FormaDajDijagnozuIRacun_Load(object sender, EventArgs e)
        {
            termini = DTOManager.VratiTermine();
            usluge = DTOManager.VratiSveUsluge();
            listView1.Items.Clear();
            foreach (var termin in termini)
            {
                listView1.Items.Add(new ListViewItem(new string[]{
                    termin.TerminID.ToString(), termin.Pacijent.BrojKartona, termin.Odeljenje.Naziv
                }));
            }
            listView2.Items.Clear();
            foreach (var usluga in usluge)
            {
                listView2.Items.Add(new ListViewItem(new string[]{
                    usluga.UslugaID.ToString(), usluga.Naziv, usluga.Cena.ToString()
                }));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView3.SelectedItems[0];

                listView3.Items.Remove(selectedItem);

                listView2.Items.Add(selectedItem);

                cena -= double.Parse(selectedItem.SubItems[2].Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView2.SelectedItems[0];

                listView2.Items.Remove(selectedItem);

                listView3.Items.Add(selectedItem);

                cena += double.Parse(selectedItem.SubItems[2].Text);
            }
            textBox1.Text = cena.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && listView3.Items.Count > 0)
            {
                double ukupanIznos;
                double iznosOsiguranja;
                if (double.TryParse(textBox1.Text, out ukupanIznos) && double.TryParse(textBox2.Text, out iznosOsiguranja))
                {
                    if (iznosOsiguranja > ukupanIznos)
                    {
                        MessageBox.Show("Ne može osiguranje da plati više nego što treba!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Molimo unesite ispravne numeričke vrednosti u oba polja.");
                    return;
                }
                    Pacijent p = DTOManager.VratiP(listView1.SelectedItems[0].SubItems[1].Text);
                Odeljenje o = DTOManager.VratiOdeljenjePoNazivu(listView1.SelectedItems[0].SubItems[2].Text);
                DTOManager.ObaviPregled(int.Parse(listView1.SelectedItems[0].SubItems[0].Text), new Pregled(
                    rtbOpis.Text, rtbDijagnoza.Text, rtbTerapija.Text, rtbPreporuka.Text, p, o, l
                ));
                MessageBox.Show("Uspesno obavljen Pregled!");
                List<StavkaRacuna> stavke = new List<StavkaRacuna>();
                foreach (ListViewItem item in listView3.Items)
                {
                    stavke.Add(new StavkaRacuna(new Usluga(item.SubItems[1].Text, double.Parse(item.SubItems[2].Text)), 0, 1));
                }
                Racun r = new Racun(radioButton1.Checked ? "Kartica" : "Cash", double.Parse(textBox2.Text), double.Parse(textBox1.Text) - double.Parse(textBox2.Text), p, l);
                DTOManager.IzbaciRacun(r, stavke);
                MessageBox.Show("Uspesno dodat racun!");
            }
        }
    }
}
