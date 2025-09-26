using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.Entiteti
{
    public class LaboratorijskaAnaliza
    {
        #region Property
        public virtual int AnalizaID { get; protected set; }
        public virtual string Vrsta { get; set; }
        public virtual string RefVrednosti { get; set; }
        public virtual string Rezultat { get; set; }
        public virtual DateTime DatumUzorkovanja { get; set; }
        public virtual DateTime DatumUvida { get; set; }
        public virtual string Komentar { get; set; }

        #endregion
        #region Veze
        public virtual Lekar Lekar { get; set; }
        public virtual Laborant Laborant { get; set; }
        public virtual Pacijent Pacijent { get; set; }
        public virtual Pregled Pregled { get; set; }

        #endregion
        #region override-ovi
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            LaboratorijskaAnaliza other = (LaboratorijskaAnaliza)obj;

            if (this.Pregled == null || other.Pregled == null)
                return false;

            return this.Pregled.PregledID == other.Pregled.PregledID && this.Vrsta == other.Vrsta;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + (Pregled?.PregledID.GetHashCode() ?? 0);
                hash = hash * 23 + (Vrsta?.GetHashCode() ?? 0);
                return hash;
            }
        }
        #endregion
        public LaboratorijskaAnaliza()
        {

        }
        public LaboratorijskaAnaliza(string vrsta, string refVrednosti, string rezultat, DateTime uzorkovanje, DateTime uvid, string komentar, Laborant l)
        {
            Vrsta = vrsta;
            RefVrednosti = refVrednosti;
            Rezultat = rezultat;
            DatumUzorkovanja = uzorkovanje;
            DatumUvida = uvid;
            Komentar = komentar;
            Laborant = l;
        }

    }
}
