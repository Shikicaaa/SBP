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
    public partial class FormaIzmeniPacijenta : Form
    {
        string br_kartona;
        public FormaIzmeniPacijenta(string kart)
        {
            InitializeComponent();
            br_kartona = kart;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                Lekar l = DTOManager.GetLekar(listView1.SelectedItems[0].SubItems[0].Text);
                DTOManager.IzmeniPacijenta(br_kartona, tbAdresa.Text, tbKontakt.Text, tbEmail.Text, l);
                this.Close();
            }MessageBox.Show("IZaberite jednog lekara!");
        }

        private void FormaIzmeniPacijenta_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<Lekar> lekari = DTOManager.VratiLekare();
            foreach (var l in lekari)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    l.JMBG, $"{l.Ime} {l.Prezime}", l.Specijalizacija
                });
                listView1.Items.Add(item);
            }
        }
    }
}
