using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.Entiteti
{
    public class KlinikaC
    {
        public virtual int KlinikaID { get; set; }
        public virtual string Naziv { get; set; }
        public virtual IList<Zaposleni> Zaposleni { get; set; }
        public virtual IList<Odeljenje> Odeljenja { get; set; }
        public virtual IList<Lokacija> Lokacije { get; set; }

        public KlinikaC()
        {
            Zaposleni = new List<Zaposleni>();
            Odeljenja = new List<Odeljenje>();
            Lokacije = new List<Lokacija>();
        }
        public KlinikaC(string naziv, List<Zaposleni> zaposleni, List<Odeljenje> odeljenja, Lokacija l)
        {
            Zaposleni = zaposleni;
            Odeljenja = odeljenja;
            Naziv = naziv;
            Lokacije = new List<Lokacija>();
            Lokacije.Add(l);
        }
    }
}
