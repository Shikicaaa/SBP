using Klinika.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinika
{
    public partial class FormaKlinike : Form
    {
        public FormaKlinike()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormaKlinike_Load(object sender, EventArgs e)
        {
            try
            {
                this.listView1.Items.Clear();

                List<KlinikaDetailed> Klinike = DTOManager.VratiSveKlinike();

                foreach (KlinikaDetailed k in Klinike)
                {
                    List<ZaposleniView> zaposleni = DTOManager.VratiZaposleneKlinike(k.KlinikaID);
                    ListViewItem item = new ListViewItem(new string[] { k.KlinikaID.ToString(), k.Naziv, (k.Lokacije.Count > 0 ? k.Lokacije[0].ToString()! : ""), zaposleni.Count().ToString() });
                    this.listView1.Items.Add(item);
                }
                this.listView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                tbNazivKlinike.Text = item.SubItems[1].Text;
                lbLokacije.Items.Clear();
                List<LokacijaDetailed> lokacije = DTOManager.VratiLokacijeKlinike(int.Parse(item.SubItems[0].Text));
                foreach(LokacijaDetailed l in lokacije)
                {
                    lbLokacije.Items.Add(l.Adresa);
                }
                tbBrZaposlenih.Text = item.SubItems[3].Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem item = listView1.SelectedItems[0];
                    int id = int.Parse(item.SubItems[0].Text);
                    List<Klinika.ZaposleniView> zaposleni = DTOManager.VratiZaposleneKlinike(id);
                    FormaZaposleni f = new FormaZaposleni(zaposleni);
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Molimo odaberite kliniku iz liste.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske: " + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int id = int.Parse(item.SubItems[0].Text);
                List<OdeljenjeView> odeljenja = DTOManager.VratiOdeljenja(id);
                if(odeljenja != null)
                {
                    FormaOdeljenja forma = new FormaOdeljenja(odeljenja);
                    forma.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nema odeljenja u klinici.");
                }
            }
            else
            {
                MessageBox.Show("Odaberite bar 1 kliniku.");
            }
        }
    }
}
