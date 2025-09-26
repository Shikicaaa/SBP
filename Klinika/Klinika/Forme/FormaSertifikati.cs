using Klinika.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinika.Forme
{
    public partial class FormaSertifikati : Form
    {
        private MedicinskaSestra s;
        private Laborant l;
        private List<Sertifikat> sertifikati;
        private List<OblastRada> oblastirada;
        private List<Sertifikat> sertifikatiRadnika;
        private List<OblastRada> oblastiradaRadnika;
        int tip;
        string jmbg;
        public FormaSertifikati(string jmbg, int tip = 1)
        {
            InitializeComponent();
            if (tip == 1)
            {
                s = DTOManager.VratiSestru(jmbg);
                l = null;
            }
            else
            {
                s = null;
                l = DTOManager.VratiLaboranta(jmbg);
            }
            this.tip = tip;
            this.jmbg = jmbg;
        }

        private void OsveziPolja()
        {
            sertifikatiRadnika = tip == 1 ? DTOManager.VratiSertifikateSestre(jmbg) : DTOManager.VratiSertifikateLaboranta(jmbg);
            oblastiradaRadnika = tip == 1 ? DTOManager.VratiOblastiSestre(jmbg) : DTOManager.VratiOblastiLaboranta(jmbg);

            listView1.Items.Clear();
            foreach (var s in sertifikati)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    s.SertifikatID.ToString(), s.Naziv
                });
                listView1.Items.Add(item);
            }
            listView2.Items.Clear();
            foreach (var s in oblastirada)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    s.OblastRadaID.ToString(), s.Naziv
                });
                listView2.Items.Add(item);
            }
            listView3.Items.Clear();
            foreach(var s in sertifikatiRadnika)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    s.SertifikatID.ToString(), s.Naziv
                });
                listView3.Items.Add(item);
            }
            listView4.Items.Clear();
            foreach (var s in oblastiradaRadnika)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    s.OblastRadaID.ToString(), s.Naziv
                });
                listView4.Items.Add(item);
            }

        }
        private void FormaSpecijalizacija_Load(object sender, EventArgs e)
        {
            sertifikati = DTOManager.VratiSertifikate();
            oblastirada = DTOManager.VratiOblastiRada();
            OsveziPolja();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (tip == 1) //sestra
                {
                    DTOManager.DodajSertifikatSestra(this.jmbg, int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                }
                else
                {
                    DTOManager.DodajSertifikatLaborant(this.jmbg, int.Parse(listView1.SelectedItems[0].SubItems[0].Text));

                }
                OsveziPolja();
            }
            else return;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbNazivSertifikata.Text.Length > 0)
                {
                    DTOManager.DodajSertifikat(tbNazivSertifikata.Text);
                    MessageBox.Show("Uspesno!");
                }
                OsveziPolja();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbNazivOblasti.Text.Length > 0)
                {
                    DTOManager.DodajOblast(tbNazivOblasti.Text);
                    MessageBox.Show("Uspesno!");
                }

                OsveziPolja();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (tip == 1) //sestra
                {
                    DTOManager.ObrisiSertifikatSestra(this.jmbg, int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show("Uspesno!");
                }
                else
                {
                    DTOManager.ObrisiSertifikatLaborant(this.jmbg, int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show("Uspesno!");
                }
            }
            else MessageBox.Show("Mora biti odabran bar 1 sertifikat.");
            OsveziPolja();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                if (tip == 1) //sestra
                {
                    DTOManager.ObrisiOblastRadaSestra(this.jmbg, int.Parse(listView2.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show("Uspesno!");
                }
                else
                {
                    DTOManager.ObrisiOblastRadaLaborant(this.jmbg, int.Parse(listView2.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show("Uspesno!");
                }
            }
            else MessageBox.Show("Mora biti odabrana bar 1 oblast rada.");
            OsveziPolja();
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                if (tip == 1) //sestra
                {
                    DTOManager.DodajOblastRadaSestra(this.jmbg, int.Parse(listView2.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show("Uspesno!");
                }
                else
                {
                    DTOManager.DodajOblastRadaLaborant(this.jmbg, int.Parse(listView2.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show("Uspesno!");
                }
                OsveziPolja();
            }
            else return;
        }
    }
}
