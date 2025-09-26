using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.Entiteti
{
    public class Pregled
    {
        #region Property
        public virtual int PregledID { get; protected set; }
        public virtual string Opis { get; set; }
        public virtual string Dijagnoza { get; set; }
        public virtual string Terapija { get; set; }
        public virtual string Preporuka { get; set; }
        public virtual Pacijent Pacijent { get; set; }
        public virtual Odeljenje Odeljenje { get; set; }
        public virtual Lekar Lekar { get; set; }
        public virtual Termin Termin { get; set; }
        #endregion
        #region Veze
        public virtual IList<LaboratorijskaAnaliza> Analize { get; set; }
        #endregion
        public Pregled()
        {
            Analize = new List<LaboratorijskaAnaliza>();
        }
        public Pregled(string opis, string dijagnoza, string terapija, string preporuka, Pacijent p, Odeljenje o, Lekar l)
        {
            Opis = opis;
            Dijagnoza = dijagnoza;
            Terapija = terapija;
            Preporuka = preporuka;
            Pacijent = p;
            Lekar = l; 
            Analize = new List<LaboratorijskaAnaliza>();
            
        }
    }
}
