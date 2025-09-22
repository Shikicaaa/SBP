using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.Entiteti
{
    public class RasporedjenU
    {
        public virtual Zaposleni Zaposleni { get; set; }
        public virtual Lokacija Lokacija { get; set; }
        public virtual DateTime Od { get; set; }
        public virtual DateTime Do { get; set; }
        #region override-ovi
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            RasporedjenU other = (RasporedjenU)obj;

            if (this.Zaposleni == null || other.Zaposleni == null ||
                this.Lokacija == null || other.Lokacija == null)
            {
                return false;
            }

            return this.Zaposleni.JMBG == other.Zaposleni.JMBG &&
                   this.Lokacija.LokacijaID == other.Lokacija.LokacijaID;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + (Zaposleni?.JMBG?.GetHashCode() ?? 0);
                hash = hash * 23 + (Lokacija?.LokacijaID.GetHashCode() ?? 0);

                return hash;
            }
        }
        #endregion
    }
}
