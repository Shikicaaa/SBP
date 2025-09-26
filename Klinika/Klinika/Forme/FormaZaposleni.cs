using Klinika.Entiteti;
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
    public partial class FormaZaposleni : Form
    {
        public List<Klinika.ZaposleniView> zap;
        public FormaZaposleni(List<Klinika.ZaposleniView> zaposleni)
        {
            zap = zaposleni;
            InitializeComponent();
        }

        private void OsveziListu()
        {
            zap = DTOManager.VratiZaposlene();
            listView1.Items.Clear();
            foreach (var z in zap)
            {
                ListViewItem zaposleniItem = new ListViewItem(z.JMBG);
                zaposleniItem.SubItems.Add(z.Ime);
                zaposleniItem.SubItems.Add(z.Prezime);
                zaposleniItem.SubItems.Add(z.Tip);
                listView1.Items.Add(zaposleniItem);
            }
        }
        private void FormaZaposleni_Load(object sender, EventArgs e)
        {
            OsveziListu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaUbaciZaposlene form = new FormaUbaciZaposlene();
            form.ShowDialog();
            OsveziListu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string jmbg = item.SubItems[0].Text;
                DTOManager.ObrisiZaposlenog(jmbg);
                MessageBox.Show($"Uspesno obrisan zaposleni JMBG:{jmbg}");
                OsveziListu();
            }
            else
            {
                MessageBox.Show("Mora prvo da bude selektovan 1 zaposleni");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                string tipZaposlenog = selectedItem.SubItems[3].Text;
                string jmbg = selectedItem.SubItems[0].Text;
                if (tipZaposlenog == "MedicinskaSestra")
                {
                    FormaSertifikati forma = new FormaSertifikati(jmbg, 1);
                    forma.ShowDialog();
                }
                else if (tipZaposlenog == "Laborant")
                {
                    FormaSertifikati forma = new FormaSertifikati(jmbg, 2);
                    forma.ShowDialog();
                }
                else if (tipZaposlenog == "Lekar")
                {
                    FormaIzmeniZaposlenog forma = new FormaIzmeniZaposlenog(jmbg);
                    forma.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Mora prvo da bude selektovan 1 zaposleni");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            ListViewItem item = listView1.SelectedItems[0];
            string tip = item.SubItems[3].Text;
            if (tip == "Lekar" || tip == "Laborant")
            {
                button4.Visible = true;
            }
            else
            {
                button4.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            string tip = item.SubItems[3].Text;
            if (tip == "Lekar")
            {
                Lekar l = DTOManager.VratiLekara(item.SubItems[0].Text);
                FormaDajDijagnozuIRacun forma = new FormaDajDijagnozuIRacun(l);
                forma.Show();
            }else if(tip == "Laborant")
            {
                // uradi analize i naplati
            }
        }
    }
}
