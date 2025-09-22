using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.Entiteti
{
    public class Pacijent
    {
        #region Property
        public virtual string BrojKartona { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual char Pol { get; set; }
        public virtual string Adresa { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string KontaktTelefon { get; set; }
        public virtual string Email { get; set; }
        public virtual string BrojRFZO { get; set; }
        public virtual char ImaRFZO { get; set; }
        public virtual Lekar IzabraniLekar { get; set; }
        #endregion

        #region Veze
        public virtual IList<Termin> Termini { get; set;}
        public virtual IList<Pregled> Pregledi { get; set; }
        public virtual IList<LaboratorijskaAnaliza> LaboratorijskeAnalize { get; set; }
        public virtual IList<Racun> Racuni { get; set; }
        public virtual IList<Osiguranje> PrivatnaOsiguranja { get; set; }
        #endregion
        public Pacijent()
        {
            Termini = new List<Termin>();
            Pregledi = new List<Pregled>();
            LaboratorijskeAnalize = new List<LaboratorijskaAnaliza>();
            Racuni = new List<Racun>();
            PrivatnaOsiguranja = new List<Osiguranje>();
        }
    }
}
