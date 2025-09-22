using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.Entiteti
{
    public class Lokacija
    {
        public virtual int LokacijaID { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string RadnoVreme { get; set; }
        public virtual KlinikaC Klinika { get; set; }
        public virtual IList<Odeljenje> Odeljenja { get; set; }
        public virtual IList<RasporedjenU> Zaposleni { get; set; }

        public Lokacija()
        {
            Odeljenja = new List<Odeljenje>();
            Zaposleni = new List<RasporedjenU>();
        }
    }
}
