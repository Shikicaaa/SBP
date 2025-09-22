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

        private void FormaPacijenti_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
