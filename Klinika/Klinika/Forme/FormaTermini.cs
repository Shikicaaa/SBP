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
    public partial class FormaTermini : Form
    {
        public FormaTermini()
        {
            InitializeComponent();
        }
        private void Osvezi()
        {
            List<Termin> termini = DTOManager.VratiTermine();
            listView1.Items.Clear();
            foreach (var item in termini)
            {
                listView1.Items.Add(new ListViewItem(new string[]
                {
                    item.TerminID.ToString(),
                    item.Status,
                    item.Datum.ToString(),
                    item.Pacijent.Ime + " " + item.Pacijent.Prezime,
                    item.Lekar.Ime + " " + item.Lekar.Prezime,
                    item.Odeljenje.Naziv
                }));
            }
        }
        private void FormaTermini_Load(object sender, EventArgs e)
        {
            Osvezi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DTOManager.ObrisiTermin(int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                MessageBox.Show("Uspesno otkazan termin!");
                Osvezi();
            }else
                MessageBox.Show("Odaberite bar 1 termin");

        }
    }
}
