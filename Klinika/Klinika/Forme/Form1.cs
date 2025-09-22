using Klinika.Forme;

namespace Klinika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new FormaKlinike();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<ZaposleniView> z = new List<ZaposleniView>();
            z = DTOManager.VratiSveZaposlene();
            FormaZaposleni form = new FormaZaposleni(z);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<PacijentDetailed> p = new List<PacijentDetailed>();
            p = DTOManager.VratiSvePacijente();
            FormaPacijenti form = new FormaPacijenti(p);
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<RacunView> r = new List<RacunView>();
            r = DTOManager.VratiSveRacune();
            FormaRacuni form = new FormaRacuni(r);
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<UslugaView> usluge = DTOManager.VratiSveUsluge();
            FormaSveUsluge forma = new FormaSveUsluge(usluge);
            forma.ShowDialog();
        }
    }
}
