using Klinika.Entiteti;
using Klinika.Mapiranja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    #region Klinika
    public class KlinikaView
    {
        public int KlinikaID { get; set; }
        public string Naziv { get; set; }

        public KlinikaView(int id, string naziv)
        {
            KlinikaID = id;
            Naziv = naziv;
        }
    }

    public class OsiguravajucaKucaView
    {
        public virtual int BrojKuce { get; set; }
        public virtual string Naziv { get; set; }
        public virtual List<OsiguranjeView> Polise { get; set; }
        public OsiguravajucaKucaView(int brojkuce, string naziv, List<OsiguranjeView> polise)
        {
            BrojKuce = brojkuce;
            Naziv = naziv;
            Polise = polise;
        }
        public OsiguravajucaKucaView() { }
    }
    public class OsiguranjeView
    {
        public virtual int BrojPolice { get; set; }
        public virtual DateTime DatumIsteka { get; set; }
        public virtual string BrojKartonaPacijenta { get; set; }

        // Prazan konstruktor za lakše korišćenje
        public OsiguranjeView() { }
        public OsiguranjeView(int brojPolice, DateTime datumIsteka)
        {
            BrojPolice = brojPolice;
            DatumIsteka = datumIsteka;
        }
    }
    public class KlinikaDetailed
    {
        public int KlinikaID { get; set; }
        public string Naziv { get; set; }
        public IList<LokacijaDetailed> Lokacije { get; set; }
        public IList<ZaposleniDetailed> Zaposleni { get; set; }
        public IList<OdeljenjeDetailed> Odeljenja { get; set; }
        public KlinikaDetailed()
        {
            Lokacije = new List<LokacijaDetailed>();
            Zaposleni = new List<ZaposleniDetailed>();
            Odeljenja = new List<OdeljenjeDetailed>();
        }

        public KlinikaDetailed(int id, string naziv) : this()
        {
            KlinikaID = id;
            Naziv = naziv;
        }
    }
    #endregion
    #region Pacijent
    public class PacijentView
    {
        public string BrojKartona { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KontaktTelefon { get; set; }

        public PacijentView(string brojKartona, string ime, string prezime, string kontakt)
        {
            BrojKartona = brojKartona;
            Ime = ime;
            Prezime = prezime;
            KontaktTelefon = kontakt;
        }
    }
    public class PacijentDetailed
    {
        public string BrojKartona { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public char Pol { get; set; }
        public string Adresa { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string KontaktTelefon { get; set; }
        public string Email { get; set; }
        public string BrojRFZO { get; set; }
        public char ImaRFZO { get; set; }
        public string IzabraniLekarJMBG { get; set; }

        public PacijentDetailed(string bk, string ime, string prezime, char p, string adresa, DateTime datumrodj, string kontakt, string email, string rfzo, char imarfzo, string lekarjmbg) {
            BrojKartona = bk;
            Ime = ime;
            Prezime = prezime;
            Pol = p;
            Adresa = adresa;
            DatumRodjenja = datumrodj;
            KontaktTelefon = kontakt;
            Email = email;
            BrojRFZO = rfzo;
            ImaRFZO = imarfzo;
            IzabraniLekarJMBG = lekarjmbg;
        }
    }
    #endregion
    #region Zaposleni
    public abstract class ZaposleniDetailed
    {
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string KontaktTelefon { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string Tip { get; protected set; }
    }

    public class ZaposleniView
    {
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Tip { get; set; }

        public ZaposleniView(string jmbg, string ime, string prezime, string tip)
        {
            JMBG = jmbg;
            Ime = ime;
            Prezime = prezime;
            Tip = tip;
        }
    }
    public class LekarView : ZaposleniView
    {
        public string BRLicence { get; set; }
        public string Specijalizacija { get; set; }
        public LekarView(string jmbg, string ime, string prezime, string tip, string spec, string brlic) : base(jmbg, ime, prezime, tip)
        {
            BRLicence = brlic;
            Specijalizacija = spec;
        }
    }
    public class LekarDetailed : ZaposleniDetailed
    {
        public string BRLicence { get; set; }
        public string Specijalizacija { get; set; }
        public IList<PregledDetailed> Pregledi { get; set; }
        public IList<TerminDetailed> Termini { get; set; }
        public IList<RacunDetailed> Racuni { get; set; }
        public IList<OdeljenjeDetailed> Odeljenja { get; set; }

        public LekarDetailed() { 
            Tip = "Lekar"; 
            Pregledi = new List<PregledDetailed>();
            Termini = new List<TerminDetailed>();
            Racuni = new List<RacunDetailed>();
            Odeljenja = new List<OdeljenjeDetailed>();
        }
    }

    public class AdministratorDetailed : ZaposleniDetailed
    {

    }
    public class SertifikatBasic
    {
        public int SertifikatID { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public SertifikatBasic() { }
    }
    public class SertifikatDetailed
    {
        public int SertifikatID { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public IList<ZaposleniDetailed> Zaposleni { get; set; }
        public SertifikatDetailed()
        {
            Zaposleni = new List<ZaposleniDetailed>();
        }

    }
    public class OblastRadaView
    {
        public int OblastRadaID { get; set; }
        public string Naziv { get; set; }
        public OblastRadaView() { }
    }
    public class OblastRadaDetailed
    {
        public int OblastRadaID { get; set; }
        public string Naziv { get; set; }
        public IList<ZaposleniDetailed> Zaposleni { get; set; }
        public OblastRadaDetailed() 
        {
            Zaposleni = new List<ZaposleniDetailed>();
        }
    }
    public class LaborantDetailed : ZaposleniDetailed
    {
        public IList<OblastRadaDetailed> OblastiRada { get; set; }
        public IList<SertifikatDetailed> Sertifikati { get; set; }
        public IList<LaboratorijskaAnalizaDetailed> LabAnalize { get; set; }
        public LaborantDetailed() 
        { 
            Tip = "Laborant"; 
            OblastiRada = new List<OblastRadaDetailed>();
            Sertifikati = new List<SertifikatDetailed>();
            LabAnalize = new List<LaboratorijskaAnalizaDetailed>();
        }
    }

    public class MedicinskaSestraDetailed : ZaposleniDetailed
    {
        public IList<OblastRadaDetailed> OblastiRada { get; set; }
        public IList<SertifikatDetailed> Sertifikati { get; set; }
        public MedicinskaSestraDetailed() 
        { 
            Tip = "MedicinskaSestra";
            OblastiRada = new List<OblastRadaDetailed>();
            Sertifikati = new List<SertifikatDetailed>();
        }
    }
    #endregion

    #region Lokacija
    public class LokacijaDetailed
    {
        public int LokacijaID { get; set; }
        public string Adresa { get; set; }
        public string RadnoVreme { get; set; }
        public KlinikaDetailed Klinika { get; set; }

        public LokacijaDetailed() { }
    }
    #endregion
    #region Odeljenja
    public class OdeljenjeView
    {
        public int OdeljenjeID { get; set; }
        public string Naziv { get; set; }
        public string BrSobe { get; set; }
        public Lekar NadlezniLekar { get; set; }
        public OdeljenjeView(int id, string naziv, string brsobe, Lekar Nadlezni)
        {
            OdeljenjeID = id;
            Naziv = naziv;
            BrSobe = brsobe;
            NadlezniLekar = Nadlezni;
        }
    }
    public class OdeljenjeDetailed
    {
        public int OdeljenjeID { get; set; }
        public string Naziv { get; set; }
        public string BrSobe { get; set; }
        public Lekar NadlezniLekar { get; set; }
        public IList<PregledDetailed> Pregledi { get; set; }
        public IList<ZaposleniDetailed> Zaposleni { get; set; }
        public IList<KlinikaDetailed> Klinike { get; set; }
        public OdeljenjeDetailed()
        {
            Pregledi = new List<PregledDetailed>();
            Zaposleni = new List<ZaposleniDetailed>();
            Klinike = new List<KlinikaDetailed>();
        }
    }
    #endregion
    #region Pregled
    public class PregledDetailed
    {
        public int PregledID { get; set; }
        public string Opis { get; set; }
        public string Dijagnoza { get; set; }
        public string Terapija { get; set; }
        public PacijentDetailed Pacijent { get; set; }
        public OdeljenjeDetailed Odeljenje { get; set; }
        public LekarDetailed Lekar { get; set; }
        public TerminDetailed Termin { get; set; }

        public IList<LaboratorijskaAnalizaDetailed> Analize { get; set; }

        public PregledDetailed()
        {
            Analize = new List<LaboratorijskaAnalizaDetailed>();
        }
    }
    #endregion
    #region Termin
    public class TerminView
    {
        public int TerminID { get; set; }
        public string Status { get; set; }
        public DateTime Datum { get; set; }
        public TerminView() { }
    }
    public class TerminDetailed
    {
        public int TerminID { get; set; }
        public string Status { get; set; }
        public DateTime Datum { get; set; }
        public LekarDetailed Lekar { get; set; }
        public PacijentDetailed Pacijent { get; set; }
        public OdeljenjeDetailed Odeljenje { get; set; }
        public PregledDetailed Pregled { get;set;}
    }
    #endregion
    #region LaboratorijskaAnaliza
    public class LaboratorijskaAnalizaView
    {
        public string Vrsta { get; set; }
        public string RefVrednosti { get; set; }
        public string Rezultat { get;set; }
        public DateTime DatumUzorkovanja { get; set; }
        public DateTime DatumUvida { get;set ; }
        public string Komentar { get;set; }
        public LaboratorijskaAnalizaView() { }
    }
    public class LaboratorijskaAnalizaDetailed
    {
        public string Vrsta { get; set; }
        public string RefVrednosti { get; set; }
        public string Rezultat { get; set; }
        public DateTime DatumUzorkovanja { get; set; }
        public DateTime DatumUvida { get; set; }
        public string Komentar { get; set; }
    }
    #endregion
    #region Racun
    public class StavkaRacunaView
    {
        public UslugaView Usluga { get; set; }
        public int RacunID { get; set; }
        public double Popust { get; set; }
        public double Kolicina { get; set; }
        public StavkaRacunaView(UslugaView u, int id, double pop, double kol)
        {
            Usluga = u;
            RacunID = id;
            Popust = pop;
            Kolicina = kol;
        }
    }
    public class StavkaRacunaDetailed
    {
        public UslugaDetailed Usluga { get; set; }
        public RacunDetailed Racun { get; set; }
        public double Popust { get; set; }
        public double Kolicina { get; set; }
        public StavkaRacunaDetailed() { }
    }
    public class RacunView
    {
        public int RacunID { get; set; }
        public string NacinPlacanja { get; set; }
        public double IznosOsiguranja { get; set; }
        public double IznosPacijent { get; set; }
        public double Cena { get; set; }
        public DateTime Datum { get; set; }
        public RacunView(int id, string nacin, double iznoso, double iznosp, DateTime datum) {
            RacunID = id;
            NacinPlacanja = nacin;
            IznosOsiguranja = iznoso;
            IznosPacijent = iznosp;
            Cena = iznoso + iznosp;
            Datum = datum;
        }
    }
    public class RacunDetailed
    {
        public int RacunID { get; set; }
        public string NacinPlacanja { get; set; }
        public double IznosOsiguranja { get; set; }
        public double IznosPacijent { get; set; }
        public double Cena { get; set; }
        public DateTime Datum { get; set; }
        public PacijentView Pacijent { get; set; }
        public LekarView Lekar { get; set; }
        public IList<StavkaRacunaView> StavkaRacuna {get;set;}
        public RacunDetailed(int id, string nacin, double iznoso, double iznosp, DateTime datum, PacijentView p, LekarView l, IList<StavkaRacunaView> stavke) 
        {
            RacunID = id;
            NacinPlacanja = nacin;
            IznosOsiguranja = iznoso;
            IznosPacijent = iznosp;
            Datum = datum;
            Pacijent = p;
            Lekar = l;
            StavkaRacuna = stavke;
        }
    }
    #endregion
    #region Usluga
    public class UslugaView
    {
        public int UslugaID { get; set; }
        public string Naziv { get; set; }
        public double Cena { get; set; }
        public UslugaView(int id, string naz, double cen)
        {
            UslugaID = id;
            Naziv = naz;
            Cena = cen;
        }
    }
    public class UslugaDetailed
    {
        public int UslugaID { get; set; }
        public string Naziv { get; set; }
        public double Cena { get; set; }

        public IList<StavkaRacunaDetailed> StavkaRacuna { get; set; }


        public UslugaDetailed()
        {
            StavkaRacuna = new List<StavkaRacunaDetailed>();
        }
    }
    #endregion
}
