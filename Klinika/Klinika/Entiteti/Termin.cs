using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.Entiteti
{
    public class Termin
    {
        #region Property
        public virtual int TerminID { get; set; }
        public virtual string Status { get; set; }
        public virtual DateTime Datum { get; set; }
        #endregion
        #region Veze
        public virtual Lekar Lekar { get; set; }
        public virtual Pacijent Pacijent { get; set; }
        public virtual Odeljenje Odeljenje { get; set; }
        public virtual Pregled Pregled { get; set; }
        #endregion
        public Termin()
        {

        }
        public Termin(string status, DateTime datum, Lekar lekar, Pacijent p, Odeljenje o)
        {
            Status = status;
            Datum = datum;
            Lekar = lekar;
            Pacijent = p;
            Odeljenje = o;
        }
    }
}
