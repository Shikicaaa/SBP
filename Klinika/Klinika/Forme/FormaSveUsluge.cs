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
    public partial class FormaSveUsluge : Form
    {
        List<UslugaView> usluge;
        public FormaSveUsluge(List<UslugaView> usluge)
        {
            InitializeComponent();
            this.usluge = usluge;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaUsluge forma = new FormaUsluge(false, "", -1);
            forma.ShowDialog();
            OsveziUsluge();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int idUsluge = int.Parse(item.SubItems[0].Text);
                DTOManager.ObrisiUslugu(idUsluge);
                MessageBox.Show($"Uspesno obrisana usluga sa ID={idUsluge}");
                OsveziUsluge();

            }
            else
            {
                MessageBox.Show("Morate da odaberete uslugu prvo.");
            }
        }
        private void OsveziUsluge()
        {
            usluge = DTOManager.VratiSveUsluge();
            listView1.Items.Clear();
            foreach (UslugaView v in usluge)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    v.UslugaID.ToString(), v.Naziv, v.Cena.ToString()
                });
                listView1.Items.Add(item);
            }
        }
        private void FormaSveUsluge_Load(object sender, EventArgs e)
        {
            OsveziUsluge();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int idUsluge = int.Parse(item.SubItems[0].Text);
                string nazivUsluge = item.SubItems[1].Text;
                FormaUsluge forma = new FormaUsluge(true, nazivUsluge, idUsluge);
                forma.ShowDialog();
                OsveziUsluge();
            }
            else
            {
                MessageBox.Show("Morate da odaberete uslugu prvo.");
            }
        }
    }
}
