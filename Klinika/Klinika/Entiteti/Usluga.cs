using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.Entiteti
{
    public class Usluga
    {
        public virtual int UslugaID { get; set; }
        public virtual string Naziv { get; set; }
        public virtual double Cena { get; set; }

        public virtual IList<StavkaRacuna> StavkaRacuna { get; set; }


        public Usluga()
        {
            StavkaRacuna = new List<StavkaRacuna>();
        }
        public Usluga(string naziv, double cena)
        {
            Naziv = naziv;
            Cena = cena;
        }
    }
}
