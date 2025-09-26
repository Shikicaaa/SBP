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
    public partial class FormaPacijenti : Form
    {
        public List<PacijentDetailed> p = new List<PacijentDetailed>();
        public FormaPacijenti(List<PacijentDetailed> pacijenti)
        {
            InitializeComponent();
            p = pacijenti;
        }
        private void OsveziFormu()
        {
            listView1.Items.Clear();
            p = DTOManager.VratiSvePacijente();
            foreach (PacijentDetailed pacijent in p)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    pacijent.BrojKartona, pacijent.Ime, pacijent.Prezime,
                    pacijent.DatumRodjenja.ToString(), pacijent.Pol.ToString(),
                    pacijent.Adresa, pacijent.KontaktTelefon, pacijent.Email
                });
                listView1.Items.Add(item);
            }
        }
        private void FormaPacijenti_Load(object sender, EventArgs e)
        {
            OsveziFormu();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string br_kartona = item.SubItems[0].Text;
                var pacijent = DTOManager.VratiPacijenta(br_kartona);
                string jmbg_izabranog = pacijent.IzabraniLekarJMBG;
                tbBrPregleda.Text = DTOManager.PacijentPreglediCount(br_kartona).ToString();
                tbIzabrani.Text = DTOManager.VratiIzabranogZa(br_kartona);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string br_kartona = item.SubItems[0].Text;
                DTOManager.ObrisiPacijenta(br_kartona);
                OsveziFormu();
            }
            else
            {
                MessageBox.Show("Odaberite bar jednog pacijenta.");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaDodajPacijenta forma = new FormaDodajPacijenta();
            forma.ShowDialog();
            OsveziFormu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string br_kartona = item.SubItems[0].Text;
                FormaZakaziTermin forma = new FormaZakaziTermin(br_kartona);
                forma.ShowDialog();
                return;
            }
            MessageBox.Show("Morate da selektujete bar 1 pacijenta!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string br_kartona = item.SubItems[0].Text;
                FormaIzmeniPacijenta forma = new FormaIzmeniPacijenta(br_kartona);
                forma.ShowDialog();
                OsveziFormu();
                return;
            }
            MessageBox.Show("Morate da selektujete bar 1 pacijenta!");
        }
    }
}
