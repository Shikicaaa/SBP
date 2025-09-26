using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Klinika.Entiteti;

namespace Klinika.Mapiranja
{
    public class ZaposleniMap : ClassMap<Zaposleni>
    {
        public ZaposleniMap()
        {
            Table("ZAPOSLENI");
            Id(x => x.JMBG).GeneratedBy.Assigned();

            //DiscriminateSubClassesOnColumn("TIPZAPOSLENOG");

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.DatumRodjenja, "DATUMRODJENJA");
            Map(x => x.KontaktTelefon, "KONTAKTTELEFON");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Email, "EMAIL");
            Map(x => x.DatumZaposlenja, "DATUMZAPOSLENJA");

            Map(x => x.Tip, "TIPZAPOSLENOG");

            HasMany(x => x.RasporedjenU)
                .KeyColumn("ZAPOSLENIJMBG")
                .Cascade.All()
                .Inverse();

            HasManyToMany(x => x.Odeljenja)
                .Table("RADI_U")
                .ParentKeyColumn("ZAPOSLENIJMBG")
                .ChildKeyColumn("ODELJENJEID")
                .Inverse();
        }
    }
    public class LekarMap : SubclassMap<Lekar>
    {
        public LekarMap()
        {
            Table("LEKAR");
            KeyColumn("JMBG");

            Map(x => x.BRLicence, "BROJLICENCE");
            Map(x => x.Specijalizacija, "SPECIJALIZACIJA").Nullable();

            HasMany(x => x.Termini).KeyColumn("LEKARJMBG").Inverse().Cascade.All();
            HasMany(x => x.Racuni).KeyColumn("LEKARJMBG").Inverse().Cascade.All();
            HasMany(x => x.NadleznaOdeljenja).KeyColumn("ODGOVORNILEKARJMBG").Inverse().Cascade.All();
        }
    }
    public class LaborantMap : SubclassMap<Laborant>
    {
        public LaborantMap()
        {
            Table("LABORANT");
            KeyColumn("JMBG");

            HasMany(x => x.LabAnalize).KeyColumn("LABORANTJMBG").Inverse().Cascade.All();

            HasManyToMany(x => x.OblastiRada)
                .Table("POKRIVA_OBLAST")
                .ParentKeyColumn("JMBG_ZAPOSLENOG")
                .ChildKeyColumn("OBLASTRADAID")
                .Cascade.All();

            HasManyToMany(x => x.Sertifikati)
                .Table("POSEDUJE_SERTIFIKAT")
                .ParentKeyColumn("JMBG_ZAPOSLENOG")
                .ChildKeyColumn("SERTIFIKATID")
                .Cascade.All();
        }
    }
    public class MedicinskaSestraMap : SubclassMap<MedicinskaSestra>
    {
        public MedicinskaSestraMap()
        {
            Table("MEDICINSKASESTRA");
            KeyColumn("JMBG");

            HasManyToMany(x => x.OblastiRada)
                .Table("POKRIVA_OBLAST")
                .ParentKeyColumn("JMBG_ZAPOSLENOG")
                .ChildKeyColumn("OBLASTRADAID")
                .Cascade.All();

            HasManyToMany(x => x.Sertifikati)
                .Table("POSEDUJE_SERTIFIKAT")
                .ParentKeyColumn("JMBG_ZAPOSLENOG")
                .ChildKeyColumn("SERTIFIKATID")
                .Cascade.All();
        }
    }
    public class LokacijaMap : ClassMap<Lokacija>
    {
        public LokacijaMap() 
        {
            Table("LOKACIJA");
            Id(x => x.LokacijaID, "LOKACIJAID").GeneratedBy.Identity();
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.RadnoVreme, "RADNOVREME").Not.Nullable();

            HasMany(x => x.Zaposleni).KeyColumn("LOKACIJAID").Inverse().Cascade.All();

            HasManyToMany(x => x.Odeljenja)
                .Table("LOKACIJA_ODELJENJE")
                .ParentKeyColumn("LOKACIJAID")
                .ChildKeyColumn("ODELJENJEID")
                .Cascade.All();

            HasManyToMany(x => x.Klinike)
                .Table("KLINIKA_LOKACIJA")
                .ParentKeyColumn("LokacijaID")
                .ChildKeyColumn("KlinikaID")
                .Inverse()
                .Cascade.All();
        }
    }
    public class KlinikaMap : ClassMap<KlinikaC>
    {
        public KlinikaMap()
        {
            Table("KLINIKA");
            Id(x => x.KlinikaID, "KLINIKAID").GeneratedBy.Sequence("KLINIKA_SEQ");
            Map(x => x.Naziv, "NAZIV");

            HasManyToMany(x => x.Odeljenja)
                .Table("PRIPADA_KLINICI")
                .ParentKeyColumn("KLINIKAID")
                .ChildKeyColumn("ODELJENJEID")
                .Cascade.All();

            HasManyToMany(x => x.Lokacije)
                .Table("KLINIKA_LOKACIJA")
                .ParentKeyColumn("KlinikaID")
                .ChildKeyColumn("LokacijaID")
                .Cascade.All();

        }
    }
    public class OdeljenjeMap : ClassMap<Odeljenje>
    {
        public OdeljenjeMap()
        {
            Table("ODELJENJE");
            Id(x => x.OdeljenjeID, "ODELJENJEID").GeneratedBy.Identity();
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.BrSobe, "BROJEVIPROSTORIJA");
            Map(x => x.RadnoVreme, "RADNOVREME");

            References(x => x.NadlezniLekar, "ODGOVORNILEKARJMBG");

            HasMany(x => x.Pregledi).KeyColumn("ODELJENJEID").Inverse().Cascade.All();

            HasManyToMany(x => x.Klinike)
                .Table("PRIPADA_KLINICI")
                .ParentKeyColumn("ODELJENJEID")
                .ChildKeyColumn("KLINIKAID")
                .Inverse();

            HasManyToMany(x => x.Zaposleni)
                .Table("RADI_U")
                .ParentKeyColumn("ODELJENJEID")
                .ChildKeyColumn("ZAPOSLENIJMBG")
                .Cascade.All();

            HasManyToMany(x => x.Usluge)
                .Table("OBAVLJA_SE_U")
                .ParentKeyColumn("ODELJENJEID")
                .ChildKeyColumn("USLUGAID")
                .Cascade.All()
                .Inverse();


        }
    }
    public class PacijentMap : ClassMap<Pacijent>
    {
        public PacijentMap()
        {
            Table("PACIJENT");
            Id(x => x.BrojKartona, "BROJKARTONA").GeneratedBy.Assigned();
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Pol, "POL");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.DatumRodjenja, "DATUMRODJENJA");
            Map(x => x.KontaktTelefon, "KONTAKTTELEFON");
            Map(x => x.Email, "EMAIL");
            Map(x => x.BrojRFZO, "BROJRFZO");
            Map(x => x.ImaRFZO, "IMARFZO");
            References(x => x.IzabraniLekar, "IzabraniLekarJMBG");

            HasMany(x => x.Termini).KeyColumn("PACIJENTBROJKARTONA").Inverse().Cascade.None();
            HasMany(x => x.LaboratorijskeAnalize).KeyColumn("PACIJENTBROJKARTONA").Inverse().Cascade.None();
            HasMany(x => x.Racuni).KeyColumn("PACIJENTBROJKARTONA").Inverse().Cascade.None();
            HasMany(x => x.PrivatnaOsiguranja).KeyColumn("BROJKARTONA").Inverse().Cascade.None();
        }
    }
    public class PregledMap : ClassMap<Pregled>
    {
        public PregledMap()
        {
            Table("PREGLED");
            Id(x => x.PregledID, "PREGLEDID").GeneratedBy.Sequence("PREGLED_SEQ");
            Map(x => x.Opis, "OPISTEGOBA");
            Map(x => x.Dijagnoza, "DIJAGNOZA");
            Map(x => x.Terapija, "TERAPIJA");
            Map(x => x.Preporuka, "PREPORUKA");

            References(x => x.Termin, "TERMINID").Unique();
            References(x => x.Odeljenje, "ODELJENJEID");

            HasManyToMany(x => x.Analize)
            .Table("PREGLED_ANALIZA")
            .ParentKeyColumn("PREGLEDID")
            .ChildKeyColumn("ANALIZAID");
        }
    }
    public class TerminMap : ClassMap<Termin>
    {
        public TerminMap()
        {
            Table("TERMIN");
            Id(x => x.TerminID, "TERMINID").GeneratedBy.Sequence("TERMIN_SEQ");
            Map(x => x.Status, "STATUS");
            Map(x => x.Datum, "DATUMVREME");

            References(x => x.Lekar, "LEKARJMBG");
            References(x => x.Pacijent, "PACIJENTBROJKARTONA");
            References(x => x.Odeljenje, "ODELJENJEID");

            HasOne(x => x.Pregled).PropertyRef(p => p.Termin).Cascade.All();
        }
    }
    public class RacunMap : ClassMap<Racun>
    {
        public RacunMap()
        {
            Table("RACUN");
            Id(x => x.RacunID, "RACUNID").GeneratedBy.Sequence("RACUN_SEQ");
            Map(x => x.NacinPlacanja, "NACINPLACANJA");
            Map(x => x.IznosOsiguranja, "IZNOSOSIGURANJE");
            Map(x => x.IznosPacijent, "IZNOSPACIJENT");
            Map(x => x.Cena, "UKUPANIZNOS");
            Map(x => x.Datum, "DATUMIZDAVANJA");

            References(x => x.Pacijent, "PACIJENTBROJKARTONA");
            References(x => x.Lekar, "LEKARJMBG");

            HasMany(x => x.StavkaRacuna).KeyColumn("RACUNID").Inverse().Cascade.All();
        }
    }
    public class UslugaMap : ClassMap<Usluga>
    {
        public UslugaMap()
        {
            Table("USLUGA");
            Id(x => x.UslugaID, "USLUGAID").GeneratedBy.Sequence("USLUGA_SEQ");
            Map(x => x.Naziv, "NAZIVUSLUGE");
            Map(x => x.Cena, "CENA");

            HasMany(x => x.StavkaRacuna).KeyColumn("USLUGAID").Inverse().Cascade.All();
            HasManyToMany(x => x.Odeljenja)
                .Table("OBAVLJA_SE_U")
                .ParentKeyColumn("USLUGAID")
                .ChildKeyColumn("ODELJENJEID")
                .Cascade.All();
        }
    }
    public class OsiguravajucaKucaMap : ClassMap<OsiguravajucaKuca>
    {
        public OsiguravajucaKucaMap()
        {
            Table("OSIGURAVAJUCAKUCA");
            Id(x => x.BrojKuce, "KUCAID").GeneratedBy.Identity();
            Map(x => x.Naziv, "NAZIV");

            HasMany(x => x.Polise).KeyColumn("KUCAID").Inverse().Cascade.All();
        }
    }
    public class OsiguranjeMap : ClassMap<Osiguranje>
    {
        public OsiguranjeMap()
        {
            Table("POLISAOSIGURANJA");
            Id(x => x.brojPolice, "BROJPOLISE").GeneratedBy.Assigned();
            Map(x => x.DatumIsteka, "DATUMISTEKA");
            References(x => x.Pacijent, "BROJKARTONA");
            References(x => x.Kuca, "KUCAID");
            
        }
    }
    public class SertifikatMap : ClassMap<Sertifikat>
    {
        public SertifikatMap()
        {
            Table("SERTIFIKAT");
            Id(x => x.SertifikatID, "SERTIFIKATID").GeneratedBy.Sequence("SERTIFIKAT_SEQ");
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.DatumIzdavanja, "DATUMIZDAVANJA");

            HasManyToMany(x => x.Zaposleni)
                .Table("POSEDUJE_SERTIFIKAT")
                .ParentKeyColumn("SERTIFIKATID")
                .ChildKeyColumn("JMBG_ZAPOSLENOG")
                .Inverse()
                .Cascade.All();
        }
    }
    public class OblastRadaMap : ClassMap<OblastRada>
    {
        public OblastRadaMap()
        {
            Table("OBLASTRADA");
            Id(x => x.OblastRadaID, "OBLASTRADAID").GeneratedBy.Sequence("OBLAST_SEQ");
            Map(x => x.Naziv, "NAZIV");

            HasManyToMany(x => x.Zaposleni)
                .Table("POKRIVA_OBLAST")
                .ParentKeyColumn("OBLASTRADAID")
                .ChildKeyColumn("JMBG_ZAPOSLENOG")
                .Inverse()
                .Cascade.All();
        }
    }
    public class RasporedjenUMap : ClassMap<RasporedjenU>
    {
        public RasporedjenUMap()
        {
            Table("RASPOREDJEN_U");
            CompositeId()
                .KeyReference(x => x.Zaposleni, "ZAPOSLENIJMBG")
                .KeyReference(x => x.Lokacija, "LOKACIJAID")
                .KeyProperty(x => x.Od, "DatumOd");

            //Map(x => x.Do, "VremeDo");
        }
    }
    public class StavkaRacunaMap : ClassMap<StavkaRacuna>
    {
        public StavkaRacunaMap()
        {
            Table("STAVKA_RACUNA");
            CompositeId()
                .KeyReference(x => x.Racun, "RACUNID")
                .KeyReference(x => x.Usluga, "USLUGAID");

            Map(x => x.Popust, "POPUST");
            Map(x => x.Kolicina, "KOLICINA");
        }
    }
    public class LaboratorijskaAnalizaMap : ClassMap<LaboratorijskaAnaliza>
    {
        public LaboratorijskaAnalizaMap()
        {
            Table("LABORATORIJSKAANALIZA");

            Id(x => x.AnalizaID, "AnalizaID").GeneratedBy.Sequence("ANALIZA_SEQ");

            Map(x => x.Vrsta, "Vrsta");
            Map(x => x.RefVrednosti, "ReferentneVrednosti");
            Map(x => x.Rezultat, "Rezultat");
            Map(x => x.DatumUzorkovanja, "DatumUzorkovanja");
            Map(x => x.DatumUvida, "DatumRezultata");
            Map(x => x.Komentar, "Komentar");

            References(x => x.Laborant, "LaborantJMBG");
            References(x => x.Pacijent, "PacijentBrojKartona");
        }
    }
    public class AdministrativnoOsobljeMap : SubclassMap<AdministrativnoOsoblje>
    {
        public AdministrativnoOsobljeMap()
        {
            Table("ADMINISTRATIVNOOSOBLJE");
            KeyColumn("JMBG");
        }
    }
}
