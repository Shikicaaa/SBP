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
    public partial class FormaOdeljenja : Form
    {
        List<OdeljenjeView> odeljenja;
        public FormaOdeljenja(List<OdeljenjeView> o)
        {
            InitializeComponent();
            odeljenja = o;
        }

        private void FormaOdeljenja_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach(OdeljenjeView o in odeljenja)
            {
                Lekar l = DTOManager.VratiNadleznog(o.OdeljenjeID);
                ListViewItem item = new ListViewItem(new string[]
                {
                    o.OdeljenjeID.ToString(), o.Naziv, o.BrSobe.ToString(),
                    l == null ? "" : l.JMBG,
                    l == null ? "" : l.Ime,
                    l == null ? "" : l.Prezime
                });
                listView1.Items.Add(item);
            }
        }
    }
}
