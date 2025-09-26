using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.Entiteti
{
    public class StavkaRacuna
    {
        #region Property
        public virtual Usluga Usluga { get; set; }
        public virtual Racun Racun { get; set; }
        public virtual double Popust { get; set; }
        public virtual double Kolicina { get;set; }
        #endregion
        #region override-ovi
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            StavkaRacuna other = (StavkaRacuna)obj;

            if (this.Usluga == null || other.Usluga == null ||
                this.Racun == null || other.Racun == null)
            {
                return false;
            }

            return this.Usluga.UslugaID == other.Usluga.UslugaID &&
                   this.Racun.RacunID == other.Racun.RacunID;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + (Racun?.RacunID.GetHashCode() ?? 0);
                hash = hash * 23 + (Usluga?.UslugaID.GetHashCode() ?? 0);

                return hash;
            }
        }
        #endregion
        public StavkaRacuna() { }
        public StavkaRacuna(Usluga u, double popust = 0, double kolicina = 1)
        {
            Usluga = u;
            Popust = popust;
            Kolicina = kolicina;
        }
    }
    public class Racun
    {
        #region Property
        public virtual int RacunID { get; set; }
        public virtual string NacinPlacanja { get; set; }
        public virtual double IznosOsiguranja { get; set; }
        public virtual double IznosPacijent { get; set; }
        public virtual double Cena { get; set; }
        public virtual DateTime Datum { get; set; }
        #endregion
        #region Veze
        public virtual Pacijent Pacijent { get; set; }
        public virtual Lekar Lekar { get; set; }
        public virtual IList<StavkaRacuna> StavkaRacuna { get; set; }

        #endregion
        public Racun()
        {
            StavkaRacuna = new List<StavkaRacuna>();
        }
        public Racun(string nacin, double iznosO, double iznosP, Pacijent p, Lekar l)
        {
            NacinPlacanja = nacin;
            IznosOsiguranja = iznosO;
            IznosPacijent = iznosP;
            Cena = iznosO + iznosP;
            Pacijent = p;
            Lekar = l;
            StavkaRacuna = new List<StavkaRacuna>();
        }
    }
}
