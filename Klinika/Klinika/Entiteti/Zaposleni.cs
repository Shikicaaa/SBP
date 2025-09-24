using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Klinika.Entiteti
{
    public abstract class Zaposleni
    {
        #region Property
        public virtual string JMBG { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string KontaktTelefon { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DatumZaposlenja { get; set; }
        public virtual string Tip { get; set; } //Administracija, Lekar, Laborant, Sestra
        #endregion

        #region Veze
        public virtual IList<RasporedjenU> RasporedjenU { get; set; }
        public virtual IList<Odeljenje> Odeljenja { get; set; }

        #endregion

        #region Konstruktori
        public Zaposleni()
        {
            RasporedjenU = new List<RasporedjenU>();
            Odeljenja = new List<Odeljenje>();
        }
        #endregion
    }

    public class Lekar : Zaposleni
    {
        public virtual string BRLicence { get; set; }
        public virtual string Specijalizacija { get; set; }

        public virtual IList<Pregled> Pregledi { get; set; }
        public virtual IList<Termin> Termini { get; set; }
        public virtual IList<Racun> Racuni { get; set; }
        public virtual IList<Odeljenje> NadleznaOdeljenja { get; set; }
        public Lekar() : base()
        {
            Pregledi = new List<Pregled>();
            Termini = new List<Termin>();
            Racuni = new List<Racun>();
            NadleznaOdeljenja = new List<Odeljenje>();
        }
    }
    public class Sertifikat
    {
        public virtual int SertifikatID { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual DateTime DatumIzdavanja { get; set; }
        public virtual IList<Zaposleni> Zaposleni { get; set; }
        public Sertifikat()
        {
            Zaposleni = new List<Zaposleni>();
        }
        public Sertifikat(int id, string naziv, DateTime datumizdavanja)
        {
            SertifikatID = id;
            Naziv = naziv;
            DatumIzdavanja = datumizdavanja;
            Zaposleni = new List<Zaposleni>();
        }
    }
    public class OblastRada
    {
        public virtual int OblastRadaID { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual IList<Zaposleni> Zaposleni { get; set; }
        public OblastRada()
        {
            Zaposleni = new List<Zaposleni>();
        }
        public OblastRada(int id, string naziv)
        {
            Zaposleni = new List<Zaposleni>();
            OblastRadaID = id;
            Naziv = naziv;
        }
    }
    public class MedicinskaSestra : Zaposleni
    {
        public virtual IList<OblastRada> OblastiRada { get; set; }
        public virtual IList<Sertifikat> Sertifikati { get; set; }
        public MedicinskaSestra() : base()
        {
            OblastiRada = new List<OblastRada>();
            Sertifikati = new List<Sertifikat>();
            
        }
    }
    public class Laborant : Zaposleni
    {
        public virtual IList<OblastRada> OblastiRada { get; set; }
        public virtual IList<Sertifikat> Sertifikati { get; set; }
        public virtual IList<LaboratorijskaAnaliza> LabAnalize { get; set; }
        public Laborant() : base()
        {
            LabAnalize = new List<LaboratorijskaAnaliza>();
            OblastiRada = new List<OblastRada>();
            Sertifikati = new List<Sertifikat>();

        }
    }
    public class AdministrativnoOsoblje : Zaposleni
    {
        public AdministrativnoOsoblje() : base() { }
    }
}
