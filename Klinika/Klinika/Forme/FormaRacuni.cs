using NHibernate.Linq;
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
    public partial class FormaRacuni : Form
    {
        public List<RacunView> racuni = new List<RacunView>();
        public FormaRacuni(List<RacunView> racuni)
        {
            InitializeComponent();
            this.racuni = racuni;
        }
        private void UcitajRacune()
        {
            listView1.Items.Clear();
            foreach (RacunView racun in racuni)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    racun.RacunID.ToString(), racun.Cena.ToString(), racun.NacinPlacanja, racun.Datum.ToString()
                });
                listView1.Items.Add(item);
            }
        }
        private void FormaRacuni_Load(object sender, EventArgs e)
        {
            UcitajRacune();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                RacunDetailed racun = DTOManager.VratiDetaljniRacun(int.Parse(item.SubItems[0].Text));
                if (racun != null)
                {
                    listBox1.Items.Clear();
                    tbCena.Text = (racun.IznosOsiguranja + racun.IznosPacijent).ToString();
                    tbOsiguranje.Text = racun.IznosOsiguranja.ToString();
                    tbPacijent.Text = racun.IznosPacijent.ToString();
                    tbNacin.Text = racun.NacinPlacanja;
                    foreach (var stavka in racun.StavkaRacuna)
                    {
                        listBox1.Items.Add(stavka.Usluga.Naziv);
                    }
                    tbPacijentFull.Text = racun.Pacijent.Ime + " " + racun.Pacijent.Prezime;
                    PacijentDetailed pacijent = DTOManager.VratiPacijenta(racun.Pacijent.BrojKartona);
                    if (pacijent != null)
                    {
                        tbIzabrani.Text = pacijent.IzabraniLekarJMBG;
                        tbPacijentMail.Text = pacijent.Email;
                        tbPacOsiguranje.Text = (pacijent.ImaRFZO != 'f' ? pacijent.BrojRFZO : "Nema");
                        checkBox1.Checked = (pacijent.ImaRFZO != 'f' ? true : false);
                        tbPacBrKart.Text = pacijent.BrojKartona;
                    }
                }
            }
        }
    }
}
