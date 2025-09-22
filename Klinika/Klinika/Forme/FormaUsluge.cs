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
    public partial class FormaUsluge : Form
    {
        bool izmena = false;
        string naziv = "";
        int id = -1;
        public FormaUsluge(bool izmena, string naziv, int id)
        {
            InitializeComponent();
            this.izmena = izmena;
            this.naziv = naziv;
            this.id = id;
            if (izmena)
            {
                tbNaziv.Enabled = false;
                tbNaziv.Text = this.naziv;
            }
            else
            {
                tbNaziv.Enabled = true;
                tbNaziv.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!izmena)
            {
                DTOManager.DodajUslugu(tbNaziv.Text, Double.Parse(tbCena.Text));
                tbNaziv.Text = "";
                tbCena.Text = "";
                this.Close();
            }
            else
            {
                DTOManager.IzmeniCenuUsluge(this.id, double.Parse(tbCena.Text));
                MessageBox.Show("Uspesno izmenjena cena.");
                this.Close();
            }
        }

        private void tbCena_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsAsciiDigit((char)e.KeyValue))
            {
                e.Handled = true;
            }
        }

        private void FormaUsluge_Load(object sender, EventArgs e)
        {

        }
    }
}
