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
    public partial class FormaOsiguranja : Form
    {
        public FormaOsiguranja()
        {
            InitializeComponent();
        }

        private void FormaOsiguranja_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<OsiguravajucaKuca> kuce = DTOManager.VratiOsiguravajuceKuce();

            if (kuce != null)
            {
                foreach (var kuca in kuce)
                {
                    listView1.Items.Add(new ListViewItem(new string[]
                    {
                        kuca.BrojKuce.ToString(), kuca.Naziv
                    }));
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                DTOManager.DodajOsiguranje(textBox1.Text);
                MessageBox.Show("Dodata Osiguravajuca kuca");
            }
        }
    }
}
