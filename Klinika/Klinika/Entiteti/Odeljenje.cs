using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.Entiteti
{
    public class Odeljenje
    {
        public virtual int OdeljenjeID { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string BrSobe { get; set; }
        public virtual string RadnoVreme { get; set; }
        public virtual IList<Pregled> Pregledi {get; set; }
        public virtual Lekar NadlezniLekar { get; set; }
        public virtual IList<Zaposleni> Zaposleni { get; set; }
        public virtual IList<KlinikaC> Klinike { get; set; }
        public virtual IList<Usluga> Usluge { get; set; }

        public Odeljenje()
        {
            Usluge = new List<Usluga>();
            Pregledi = new List<Pregled>();
            Zaposleni = new List<Zaposleni>();
            Klinike = new List<KlinikaC>();
        }
    }
}
