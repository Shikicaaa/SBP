using Klinika.Entiteti;
using Klinika.Forme;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Mapping;
using NHibernate.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Klinika
{
    internal class DTOManager
    {
        public static void DodajAdministratora(AdministratorDetailed admin)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction t = s.BeginTransaction())
                    {
                        Entiteti.AdministrativnoOsoblje administrator = new Entiteti.AdministrativnoOsoblje()
                        {
                            JMBG = admin.JMBG,
                            Ime = admin.Ime,
                            Prezime = admin.Prezime,
                            DatumRodjenja = admin.DatumRodjenja,
                            Adresa = admin.Adresa,
                            KontaktTelefon = admin.KontaktTelefon,
                            Email = admin.Email,
                            DatumZaposlenja = admin.DatumZaposlenja,
                            Tip = "Administracija"
                        };
                        s.Save(administrator);
                        t.Commit();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public static List<UslugaView> VratiSveUsluge()
        {
            var uslugeView = new List<UslugaView>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    var usluge = session.Query<Usluga>().ToList();
                    foreach (var usluga in usluge)
                    {
                        uslugeView.Add(new UslugaView(usluga.UslugaID, usluga.Naziv, usluga.Cena));
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return uslugeView;
        }
        public static void DodajLaboranta(LaborantDetailed laborant)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction t = s.BeginTransaction())
                    {
                        Entiteti.Laborant novLaborant = new Entiteti.Laborant()
                        {
                            JMBG = laborant.JMBG,
                            Ime = laborant.Ime,
                            Prezime = laborant.Prezime,
                            DatumRodjenja = laborant.DatumRodjenja,
                            Adresa = laborant.Adresa,
                            KontaktTelefon = laborant.KontaktTelefon,
                            Email = laborant.Email,
                            DatumZaposlenja = laborant.DatumZaposlenja,
                            Tip = "Laborant"
                        };

                        s.Save(novLaborant);
                        t.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public static void DodajMedicinskuSestru(MedicinskaSestraDetailed sestra)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction t = s.BeginTransaction())
                    {
                        Entiteti.MedicinskaSestra novaSestra = new Entiteti.MedicinskaSestra()
                        {
                            JMBG = sestra.JMBG,
                            Ime = sestra.Ime,
                            Prezime = sestra.Prezime,
                            DatumRodjenja = sestra.DatumRodjenja,
                            Adresa = sestra.Adresa,
                            KontaktTelefon = sestra.KontaktTelefon,
                            Email = sestra.Email,
                            DatumZaposlenja = sestra.DatumZaposlenja,
                            Tip = "MedicinskaSestra"
                        };

                        s.Save(novaSestra);
                        t.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public static void DodajLekara(LekarDetailed lekar)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction t = s.BeginTransaction())
                    {
                        Entiteti.Lekar noviLekar = new Entiteti.Lekar()
                        {
                            JMBG = lekar.JMBG,
                            Ime = lekar.Ime,
                            Prezime = lekar.Prezime,
                            DatumRodjenja = lekar.DatumRodjenja,
                            Adresa = lekar.Adresa,
                            KontaktTelefon = lekar.KontaktTelefon,
                            Email = lekar.Email,
                            DatumZaposlenja = lekar.DatumZaposlenja,
                            Tip = "Lekar",

                            Specijalizacija = lekar.Specijalizacija,
                            BRLicence = lekar.BRLicence
                        };

                        s.Save(noviLekar);
                        t.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public static List<ZaposleniView> VratiSveZaposlene()
        {
            var zaposleniView = new List<ZaposleniView>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IEnumerable<Entiteti.Zaposleni> zaposleni = from l in session.Query<Entiteti.Zaposleni>() select l;
                    foreach (var z in zaposleni)
                    {
                        zaposleniView.Add(new ZaposleniView(z.JMBG, z.Ime, z.Prezime, z.Tip));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return zaposleniView;
        }
        public static List<RacunView> VratiSveRacune()
        {
            var racuniView = new List<RacunView>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IEnumerable<Entiteti.Racun> racuni = from r in session.Query<Entiteti.Racun>() select r;
                    foreach (var r in racuni)
                    {
                        racuniView.Add(new RacunView(
                            r.RacunID, r.NacinPlacanja, r.IznosOsiguranja,
                            r.IznosPacijent, r.Datum
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return racuniView;
        }
        public static void DodajRacun(Racun r)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    s.Save(r);
                    s.Flush();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska pri dodavanju racuna: " + ex.Message);
                throw;
            }
        }
        public static void ObrisiRacun(int racunId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Racun r = s.Load<Racun>(racunId);
                    s.Delete(r);
                    s.Flush();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska pri brisanju racuna: " + ex.Message);
                throw;
            }
        }
        public static List<Lekar> VratiLekare()
        {
            try
            {
                using(ISession s = DataLayer.GetSession())
                {
                    var lekari = s.Query<Lekar>()
                        .Where(l => l.Tip == "Lekar")
                        .ToList();
                    return lekari;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static string VratiIzabranogZa(string brojKartona)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Lekar l = s.Query<Pacijent>()
                        .Where(p => p.BrojKartona == brojKartona)
                        .Select(p => p.IzabraniLekar).FirstOrDefault();
                    if (l == null)
                    {
                        return "Nema izabranog lekara!";
                    }
                    return $"{l.Ime} {l.Prezime} {l.JMBG}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
                throw;
            }
        }
        public static int PacijentPreglediCount(string brojKartona)
        {
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    var pacijent = session.Query<Pacijent>()
                                .Where(p => p.BrojKartona == brojKartona)
                                .FirstOrDefault();
                    if (pacijent == null) return 0;
                    return pacijent.Termini.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public static Pacijent VratiP(string brojKartona)
        {
            using(ISession session = DataLayer.GetSession())
            {
                Pacijent p = session.Get<Pacijent>(brojKartona);
                return p;
            }
        }
        public static void IzmeniPacijenta(string brojKartona, string adresa, string kontakt, string email, Lekar l)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                using (ITransaction tx = s.BeginTransaction())
                {
                    Pacijent p = s.Get<Pacijent>(brojKartona);
                    p.Adresa = adresa == "" ? p.Adresa : adresa;
                    p.KontaktTelefon = kontakt == "" ? p.KontaktTelefon : kontakt;
                    p.Email = email == "" ? p.Email : email;
                    p.IzabraniLekar = l == null ? p.IzabraniLekar : l;
                    s.Update(p);
                    tx.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static PacijentDetailed VratiPacijenta(string brojKartona)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Pacijent p = s.Get<Pacijent>(brojKartona);
                    if (p == null) { MessageBox.Show("Nije nadjen"); return null; }
                    return new PacijentDetailed(
                        p.BrojKartona,
                        p.Ime,
                        p.Prezime,
                        p.Pol,
                        p.Adresa,
                        p.DatumRodjenja,
                        p.KontaktTelefon,
                        p.Email,
                        p.BrojRFZO,
                        p.ImaRFZO,
                        (p.IzabraniLekar != null ? p.IzabraniLekar.JMBG : "Nema izabranog lekara")
                    );
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static Lekar GetLekar(string jmbg)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Lekar lekar = s.Get<Lekar>(jmbg);
                    if (lekar == null)
                    {
                        return null;
                    }
                    return lekar;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static Pacijent GetPacijent(string brkartona)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Pacijent pacijent = s.Get<Pacijent>(brkartona);
                    if (pacijent == null)
                    {
                        return null;
                    }
                    return pacijent;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static RacunDetailed VratiDetaljniRacun(int idRacuna)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Racun racun = s.Get<Racun>(idRacuna);
                    if (racun == null) { MessageBox.Show("Nije nadjen"); return null; }
                    IList<StavkaRacunaView> stavke = new List<StavkaRacunaView>();
                    foreach (StavkaRacuna stavka in racun.StavkaRacuna)
                    {
                        stavke.Add(new StavkaRacunaView(new UslugaView(stavka.Usluga.UslugaID, stavka.Usluga.Naziv, stavka.Usluga.Cena), racun.RacunID, stavka.Popust, stavka.Kolicina));
                    }
                    return new RacunDetailed(
                        racun.RacunID,
                        racun.NacinPlacanja,
                        racun.IznosOsiguranja,
                        racun.IznosPacijent,
                        racun.Datum,
                        new PacijentView(
                            racun.Pacijent.BrojKartona,
                            racun.Pacijent.Ime,
                            racun.Pacijent.Prezime,
                            racun.Pacijent.KontaktTelefon
                        ),
                        new LekarView(
                            racun.Lekar.JMBG,
                            racun.Lekar.Ime,
                            racun.Lekar.Prezime,
                            racun.Lekar.Tip,
                            racun.Lekar.Specijalizacija,
                            racun.Lekar.BRLicence
                        ),
                        stavke
                    );

                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static List<PacijentDetailed> VratiSvePacijente()
        {
            var pacijentiView = new List<PacijentDetailed>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IEnumerable<Entiteti.Pacijent> pacijenti = from p in session.Query<Pacijent>() select p;
                    foreach (var p in pacijenti)
                    {
                        pacijentiView.Add(new PacijentDetailed(p.BrojKartona, p.Ime, p.Prezime, p.Pol, p.Adresa, p.DatumRodjenja, p.KontaktTelefon, p.Email, p.BrojRFZO, p.ImaRFZO, (p.IzabraniLekar != null ? p.IzabraniLekar.JMBG : "Nema izabranog")));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return pacijentiView;
        }
        public static List<KlinikaDetailed> VratiSveKlinike()
        {
            var klinikeView = new List<KlinikaDetailed>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IEnumerable<Entiteti.KlinikaC> klinike = from k in session.Query<Entiteti.KlinikaC>() select k;

                    foreach (var klinika in klinike)
                    {
                        var klinikaDto = new KlinikaDetailed(klinika.KlinikaID, klinika.Naziv);
                        foreach (var lokacija in klinika.Lokacije)
                        {
                            klinikaDto.Lokacije.Add(new LokacijaDetailed
                            {
                                LokacijaID = lokacija.LokacijaID,
                                Adresa = lokacija.Adresa,
                                RadnoVreme = lokacija.RadnoVreme
                            });
                        }
                        klinikeView.Add(new KlinikaDetailed(klinika.KlinikaID, klinika.Naziv));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return klinikeView;
        }
        public static ZaposleniDetailed VratiDetaljeZaposlenog(string jmbg)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Zaposleni zaposleni = s.Get<Zaposleni>(jmbg);

                    if (zaposleni == null) { MessageBox.Show("Nije nadjen"); return null; }

                    if (zaposleni is Lekar)
                    {
                        Lekar l = (Lekar)zaposleni;
                        return new LekarDetailed
                        {
                            //zaj polja
                            JMBG = l.JMBG,
                            Ime = l.Ime,
                            Prezime = l.Prezime,
                            KontaktTelefon = l.KontaktTelefon,
                            Adresa = l.Adresa,
                            //Pisebna polha
                            Specijalizacija = l.Specijalizacija,
                            BRLicence = l.BRLicence,
                            Odeljenja = l.NadleznaOdeljenja.Select(o => new OdeljenjeDetailed { OdeljenjeID = o.OdeljenjeID, Naziv = o.Naziv }).ToList()
                        };
                    }
                    else if (zaposleni is Laborant)
                    {
                        Laborant lab = (Laborant)zaposleni;
                        return new LaborantDetailed
                        {
                            //zaj polja
                            JMBG = lab.JMBG,
                            Ime = lab.Ime,
                            Prezime = lab.Prezime,
                            KontaktTelefon = lab.KontaktTelefon,
                            Adresa = lab.Adresa,
                            //Pisebna polha
                            Sertifikati = lab.Sertifikati.Select(sert => new SertifikatDetailed { Naziv = sert.Naziv, DatumIzdavanja = sert.DatumIzdavanja }).ToList(),
                            OblastiRada = lab.OblastiRada.Select(o => new OblastRadaDetailed { Naziv = o.Naziv }).ToList()
                        };
                    }
                    else if (zaposleni is MedicinskaSestra)
                    {
                        //zaj polja
                        MedicinskaSestra sestra = (MedicinskaSestra)zaposleni;
                        return new MedicinskaSestraDetailed
                        {
                            JMBG = sestra.JMBG,
                            Ime = sestra.Ime,
                            Prezime = sestra.Prezime,
                            KontaktTelefon = sestra.KontaktTelefon,
                            Adresa = sestra.Adresa,
                            Sertifikati = sestra.Sertifikati.Select(sert => new SertifikatDetailed { Naziv = sert.Naziv, DatumIzdavanja = sert.DatumIzdavanja }).ToList(),
                            OblastiRada = sestra.OblastiRada.Select(o => new OblastRadaDetailed { Naziv = o.Naziv }).ToList()
                        };
                    }


                    return null; // Fallback
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static void ObrisiZaposlenog(string jmbg)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction t = s.BeginTransaction())
                    {
                        Zaposleni z = s.Load<Zaposleni>(jmbg);
                        s.Delete(z);
                        t.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public static List<ZaposleniView> VratiZaposlene()
        {
            var zaposleniView = new List<ZaposleniView>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IQuery query = session.CreateQuery("SELECT DISTINCT z FROM Zaposleni z");

                    var zaposleni = query.List<Zaposleni>();
                    foreach (var z in zaposleni.Distinct())
                    {
                        zaposleniView.Add(new ZaposleniView(z.JMBG, z.Ime, z.Prezime, z.Tip));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return zaposleniView;
        }
        public static Lokacija VratiLokacijuPoAdresi(string adresa)
        {
            try
            {
                using(ISession s = DataLayer.GetSession())
                {
                    var lokacija = s.Query<Lokacija>()
                        .Where(l => l.Adresa == adresa)
                        .FirstOrDefault();
                    if (lokacija != null) return lokacija;
                    return null;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static List<ZaposleniView> VratiZaposleneKlinike(int klinikaId)
        {
            var zaposleniView = new List<ZaposleniView>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    List<Zaposleni> zaposleni = session.Query<KlinikaC>() // 1. Počni od tabele Klinika
                        .Where(k => k.KlinikaID == klinikaId)          // 2. Nađi kliniku sa zadatim ID-jem
                        .SelectMany(k => k.Odeljenja)                 // 3. Uzmi sva odeljenja te klinike
                        .SelectMany(o => o.Zaposleni)                 // 4. Iz tih odeljenja, uzmi sve zaposlene
                        .Distinct()                                   // 5. Ukloni duplikate (ako zaposleni radi na više odeljenja u istoj klinici)
                        .ToList();


                    foreach (var z in zaposleni)
                    {
                        zaposleniView.Add(new ZaposleniView(z.JMBG, z.Ime, z.Prezime, z.Tip));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return zaposleniView;
        }
        public static Odeljenje VratiOdeljenjePoNazivu(string naziv)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Odeljenje odeljenje = s.Query<Odeljenje>()
                        .Where(o => o.Naziv == naziv).FirstOrDefault();
                    return odeljenje;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static Zaposleni VratiZaposlenog(string jmbg)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Zaposleni zaposleni = s.Get<Zaposleni>(jmbg);
                    return zaposleni;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static Lokacija DodajLokaciju(string adresa, string radnovreme = "")
        {
            try
            {
                using(ISession s = DataLayer.GetSession())
                {
                    using (ITransaction t = s.BeginTransaction())
                    {
                        Lokacija novaLokacija = new Lokacija(adresa, radnovreme);
                        s.Save(novaLokacija);
                        t.Commit();
                        MessageBox.Show("Nova lokacija dodata!");
                        return novaLokacija;
                    }
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static void IzmeniKliniku(int klinikaId, string naziv, List<Odeljenje> odeljenja, List<Zaposleni> zaposleni, Lokacija l)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction t = s.BeginTransaction())
                    {
                        KlinikaC klinikaZaIzmenu = s.Get<KlinikaC>(klinikaId);
                        if (klinikaZaIzmenu == null)
                        {
                            MessageBox.Show("Ne postoji klinika sa tim ID-jem");
                            return;
                        }
                        klinikaZaIzmenu.Naziv = naziv;
                        klinikaZaIzmenu.Odeljenja.Clear();
                        foreach (var odeljenje in odeljenja)
                        {
                            var persistentOdeljenje = s.Merge(odeljenje);
                            klinikaZaIzmenu.Odeljenja.Add(persistentOdeljenje);
                        }
                        var persistentLokacija = s.Merge(l);
                        klinikaZaIzmenu.Lokacije.Clear();
                        klinikaZaIzmenu.Lokacije.Add(persistentLokacija);
                        t.Commit();
                        MessageBox.Show("Uspesno izmenjena klinika!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska pri dodavanju klinike: " + ex.Message);
                throw;
            }
        }
        public static void DodajKliniku(string naziv, List<Odeljenje> odeljenja, List<Zaposleni> zaposleni, Lokacija l)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using(ITransaction t = s.BeginTransaction())
                    {
                        KlinikaC novaKlinika = new KlinikaC(naziv, zaposleni, odeljenja, l);
                        s.Save(novaKlinika);
                        t.Commit();
                        MessageBox.Show("Uspesno dodata klinika!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska pri dodavanju klinike: " + ex.Message);
                throw;
            }
        }
        public static void ObrisiKliniku(int klinikaId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction t = s.BeginTransaction())
                    {
                        KlinikaC klinikaZaBrisanje = s.Load<KlinikaC>(klinikaId);
                        klinikaZaBrisanje.Odeljenja.Clear();

                        s.Delete(klinikaZaBrisanje);

                        t.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška pri brisanju klinike: " + ex.Message);
                throw;
            }
        }
        public static void DodajUslugu(string naziv, double cena)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction t = s.BeginTransaction())
                    {
                        Usluga novaUsluga = new Usluga(naziv, cena);
                        s.Save(novaUsluga);
                        t.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska pri dodavanju usluge: " + ex.Message);
                throw;
            }
        }
        public static void IzmeniCenuUsluge(int uslugaId, double novaCena)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                using (ITransaction t = s.BeginTransaction())
                {
                    Usluga usluga = s.Get<Usluga>(uslugaId);

                    if (usluga == null)
                        throw new Exception("Usluga sa datim ID-em ne postoji.");

                    usluga.Cena = novaCena;

                    s.Update(usluga);

                    t.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška pri izmeni cene: " + ex.Message);
                throw;
            }
        }

        public static void ObrisiUslugu(int uslugaId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction t = s.BeginTransaction())
                    {
                        Usluga u = s.Load<Usluga>(uslugaId);
                        s.Delete(u);
                        t.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska pri brisanju usluge: " + ex.Message);
                throw;
            }
        }
        public static List<LokacijaDetailed> VratiLokacijeKlinike(int klinikaId)
        {
            var lokacijeView = new List<LokacijaDetailed>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var klinika = s.Get<KlinikaC>(klinikaId);

                    if (klinika != null)
                    {
                        foreach (var l in klinika.Lokacije)
                        {
                            lokacijeView.Add(new LokacijaDetailed
                            {
                                LokacijaID = l.LokacijaID,
                                Adresa = l.Adresa,
                                RadnoVreme = l.RadnoVreme
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return lokacijeView;
        }
        public static Lekar VratiNadleznog(int odeljenjeId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var odeljenje = s.Get<Odeljenje>(odeljenjeId);
                    if (odeljenje != null && odeljenje.NadlezniLekar != null)
                    {
                        NHibernateUtil.Initialize(odeljenje.NadlezniLekar);
                        return odeljenje.NadlezniLekar;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static List<OdeljenjeView> VratiOdeljenja(int klinikaId)
        {
            var odeljenjaView = new List<OdeljenjeView>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var klinika = s.Get<KlinikaC>(klinikaId);

                    if (klinika != null)
                    {
                        foreach (var o in klinika.Odeljenja)
                        {
                            odeljenjaView.Add(new OdeljenjeView(o.OdeljenjeID, o.Naziv, o.BrSobe.ToString(), o.NadlezniLekar));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return odeljenjaView;
        }
        public static void DodajSertifikatSestra(string jmbg, int idSertifikata)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    using (var tx = session.BeginTransaction())
                    {
                        MedicinskaSestra z = session.Get<MedicinskaSestra>(jmbg);
                        if (z == null) throw new Exception("Zaposleni nije pronadjen");
                        Sertifikat s = session.Query<Sertifikat>().Where(s => s.SertifikatID == idSertifikata).First();


                        if (z.Sertifikati.Contains(s)) return;
                        z.Sertifikati.Add(s);

                        session.SaveOrUpdate(s);
                        session.Update(z);
                        tx.Commit();
                    }
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        public static void ObrisiSertifikatSestra(string jmbg, int idSertifikata)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    using (var tx = session.BeginTransaction())
                    {
                        MedicinskaSestra z = session.Get<MedicinskaSestra>(jmbg);
                        if (z == null) throw new Exception("Zaposleni nije pronadjen");

                        var sert = z.Sertifikati.FirstOrDefault(s => s.SertifikatID == idSertifikata);
                        if (sert != null)
                        {
                            z.Sertifikati.Remove(sert);
                        }
                        tx.Commit();
                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); return; }
        }
        public static void DodajSertifikatLaborant(string jmbg, int idSertifikata)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    using (var tx = session.BeginTransaction())
                    {
                        Laborant z = session.Get<Laborant>(jmbg);
                        if (z == null) throw new Exception("Zaposleni nije pronadjen");

                        Sertifikat sert = session.Query<Sertifikat>().Where(s => s.SertifikatID == idSertifikata).First();


                        if (z.Sertifikati.Contains(sert)) return;
                        z.Sertifikati.Add(sert);

                        session.SaveOrUpdate(sert);
                        session.Update(z);
                        try
                        {
                            tx.Commit();    

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Postoji vec.");
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public static void ObrisiSertifikatLaborant(string jmbg, int idSertifikata)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    using (var tx = session.BeginTransaction())
                    {
                        Laborant z = session.Get<Laborant>(jmbg);
                        if (z == null) throw new Exception("Zaposleni nije pronadjen");

                        var sert = z.Sertifikati.FirstOrDefault(s => s.SertifikatID == idSertifikata);
                        if (sert != null)
                        {
                            z.Sertifikati.Remove(sert);
                        }
                        tx.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static void DodajSpecijalizaciju(string jmbg, string specijalizacija)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    using (var tx = session.BeginTransaction())
                    {
                        Lekar lekar = session.Get<Lekar>(jmbg);
                        if (lekar == null) throw new Exception("Lekar nije pronadjen");

                        lekar.Specijalizacija = specijalizacija;
                        session.Update(lekar);
                        try
                        {
                            tx.Commit();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Postoji vec.");
                            throw;
                        }
                    }
                }

            }catch(Exception ex) { MessageBox.Show(ex.Message); throw; }
        }

        public static void ObrisiSpecijalizaciju(string jmbg)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    using (var tx = session.BeginTransaction())
                    {
                        Lekar lekar = session.Get<Lekar>(jmbg);
                        if (lekar == null) throw new Exception("Lekar nije pronadjen");

                        lekar.Specijalizacija = null;
                        session.Update(lekar);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static void DodajOblastRadaSestra(string jmbg, int idOblasti)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    using (var tx = session.BeginTransaction())
                    {
                        MedicinskaSestra z = session.Get<MedicinskaSestra>(jmbg);
                        if (z == null) throw new Exception("Zaposleni nije pronadjen");

                        OblastRada sert = session.Query<OblastRada>().Where(s => s.OblastRadaID == idOblasti).First();



                        if (z.OblastiRada.Contains(sert)) return;
                        z.OblastiRada.Add(sert);

                        session.SaveOrUpdate(sert);
                        session.Update(z);
                        try
                        {
                            tx.Commit();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Postoji vec.");
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public static void ObrisiOblastRadaSestra(string jmbg, int idOblasti)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    using (var tx = session.BeginTransaction())
                    {
                        MedicinskaSestra z = session.Get<MedicinskaSestra>(jmbg);
                        if (z == null) throw new Exception("Zaposleni nije pronadjen");

                        var sert = z.OblastiRada.FirstOrDefault(s => s.OblastRadaID == idOblasti);
                        if (sert != null)
                        {
                            z.OblastiRada.Remove(sert);
                        }
                        tx.Commit();
                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); throw; }
        }
        public static void DodajOblastRadaLaborant(string jmbg, int idOblasti)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    using (var tx = session.BeginTransaction())
                    {
                        Laborant z = session.Get<Laborant>(jmbg);
                        if (z == null) throw new Exception("Zaposleni nije pronadjen");

                        OblastRada sert = session.Query<OblastRada>().Where(s => s.OblastRadaID == idOblasti).First();


                        if (z.OblastiRada.Contains(sert)) return;
                        z.OblastiRada.Add(sert);

                        session.SaveOrUpdate(sert);
                        session.Update(z);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public static void ObrisiOblastRadaLaborant(string jmbg, int idOblasti)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    using (var tx = session.BeginTransaction())
                    {
                        Laborant z = session.Get<Laborant>(jmbg);
                        if (z == null) throw new Exception("Zaposleni nije pronadjen");

                        var sert = z.OblastiRada.FirstOrDefault(s => s.OblastRadaID == idOblasti);
                        if (sert != null)
                        {
                            z.OblastiRada.Remove(sert);
                        }
                        tx.Commit();
                    }
                }
                
            }catch(Exception ex) { MessageBox.Show(ex.Message); return; }
        }
        public static List<Pacijent> VratiPacijenteLekara(string jmbg)
        {
            try
            {
                using(ISession s = DataLayer.GetSession())
                {
                    var pacijenti = s.Query<Pacijent>()
                             .Where(p => p.IzabraniLekar.JMBG == jmbg)
                             .ToList();
                    return pacijenti;

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static List<OdeljenjeView> VratiNadredjenoOdeljenje(string jmbg)
        {
            var odeljenjaView = new List<OdeljenjeView>();
            try
            {
                using(ISession s = DataLayer.GetSession())
                {
                    var lekar = s.Query<Lekar>().Where(l => l.JMBG == jmbg).First();
                    foreach(var o in lekar.NadleznaOdeljenja)
                    {
                        odeljenjaView.Add(new OdeljenjeView(o.OdeljenjeID, o.Naziv, o.BrSobe, lekar));
                    }
                }
                return odeljenjaView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static void Nadredi(string jmbg, int odeljenjeid)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                using (var tx = s.BeginTransaction())
                {
                    var lekar = s.Query<Lekar>().First(l => l.JMBG == jmbg);
                    var odeljenje = s.Get<Odeljenje>(odeljenjeid);

                    if (odeljenje.NadlezniLekar?.JMBG == lekar.JMBG)
                    {
                        odeljenje.NadlezniLekar = null;
                        MessageBox.Show("Uspesno obrisano nadredjenje!");
                    }
                    else
                    {
                        odeljenje.NadlezniLekar = lekar;
                        MessageBox.Show("Uspesno dodato nadredjenje!");
                    }

                    s.Update(odeljenje);
                    tx.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static void PromeniSpecijalizaciju(string jmbg, string spec)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var lekar = s.Query<Lekar>().Where(l => l.JMBG == jmbg).First();
                    lekar.Specijalizacija = spec;
                    s.Update(lekar);
                    MessageBox.Show("Uspesno promenjena specijalizacija!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static List<OdeljenjeView> VratiOdeljenja()
        {
            var odeljenjaView = new List<OdeljenjeView>();
            try
            {
                using(ISession s = DataLayer.GetSession())
                {
                    var odeljenja = s.Query<Odeljenje>().ToList();
                    foreach (var o in odeljenja)
                    {
                        odeljenjaView.Add(new OdeljenjeView(o.OdeljenjeID, o.Naziv, o.BrSobe, o.NadlezniLekar));
                    }
                    return odeljenjaView;
                }
            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static List<OblastRada> VratiOblastiSestre(string jmbg)
        {
            List<OblastRada> or = new List<OblastRada>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var r = s.Query<MedicinskaSestra>().Where(r => r.JMBG == jmbg).First();
                    foreach (OblastRada o in r.OblastiRada)
                    {
                        or.Add(o);
                    }
                    return or;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static List<Sertifikat> VratiSertifikateSestre(string jmbg)
        {
            List<Sertifikat> or = new List<Sertifikat>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var r = s.Query<MedicinskaSestra>().Where(r => r.JMBG == jmbg).First();
                    foreach (Sertifikat o in r.Sertifikati)
                    {
                        or.Add(o);
                    }
                    return or;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static List<OblastRada> VratiOblastiLaboranta(string jmbg)
        {
            List<OblastRada> or = new List<OblastRada>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var r = s.Query<Laborant>().Where(r => r.JMBG == jmbg).First();
                    foreach (OblastRada o in r.OblastiRada)
                    {
                        or.Add(o);
                    }
                    return or;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static List<Sertifikat> VratiSertifikateLaboranta(string jmbg)
        {
            List<Sertifikat> or = new List<Sertifikat>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var r = s.Query<Laborant>().Where(r => r.JMBG == jmbg).First();
                    foreach (Sertifikat o in r.Sertifikati)
                    {
                        or.Add(o);
                    }
                    return or;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static void ObrisiPacijenta(string brkart)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Pacijent r = s.Query<Pacijent>().Where(p => p.BrojKartona == brkart).First();
                    s.Delete(r);
                    s.Flush();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska pri brisanju pacijenta: " + ex.Message);
                throw;
            }
        }
        public static void DodajPacijenta(
            string brkart, string ime, string prezime,
            char pol, string adresa, DateTime datumrodj,
            string kontakttel, string mail, string brojrfzo,
            char imarfzo, Lekar izabrani
        )
        {
            using (ISession s = DataLayer.GetSession())
            {
                using (ITransaction t = s.BeginTransaction())
                {
                    Pacijent noviPacijent = new Pacijent(brkart, ime, prezime, pol, adresa, datumrodj, kontakttel, mail, brojrfzo, imarfzo, izabrani);
                    s.Save(noviPacijent);
                    t.Commit();
                }
            }
        }
        public static Lekar VratiLekara(string jmbg)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Lekar l = s.Query<Lekar>().Where(l => l.JMBG == jmbg).First();
                    return l;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static MedicinskaSestra VratiSestru(string jmbg)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    MedicinskaSestra l = s.Query<MedicinskaSestra>().Where(l => l.JMBG == jmbg).First();
                    return l;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static Laborant VratiLaboranta(string jmbg)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Laborant l = s.Query<Laborant>().Where(l => l.JMBG == jmbg).First();
                    return l;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static void DodajOblast(string naziv)
        {
            using (ISession s = DataLayer.GetSession())
            {
                using (ITransaction t = s.BeginTransaction())
                {
                    OblastRada o = new OblastRada(naziv);
                    s.Save(o);
                    t.Commit();
                }
            }
        }
        public static void DodajSertifikat(string naziv)
        {
            using (ISession s = DataLayer.GetSession())
            {
                using (ITransaction t = s.BeginTransaction())
                {
                    Sertifikat o = new Sertifikat(naziv);
                    s.Save(o);
                    t.Commit();
                }
            }
        }
        public static List<OblastRada> VratiOblastiRada()
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var q = s.Query<OblastRada>().ToList();
                    return q;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static List<Sertifikat> VratiSertifikate()
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var q = s.Query<Sertifikat>().ToList();
                    return q;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        // TODO OBAVI PREGLED, NAPLATI, OSIGURANJA DA SE DODAJU\
        public static void ZakaziTermin(Termin termin) 
        {
            try
            {
                using (ISession session = DataLayer.GetSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    session.Save(termin);
                    tx.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static List<Termin> VratiTermine()
        {
            try
            {
                using(ISession s = DataLayer.GetSession())
                {
                    var termini = s.Query<Termin>()
                           .Fetch(t => t.Pacijent)
                           .Fetch(t => t.Lekar)
                           .Fetch(t => t.Odeljenje)
                           .ToList();
                    return termini;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static void ObaviPregled(int idTermina, Pregled p)
        {
            try
            {
                using (ISession session = DataLayer.GetSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    Termin termin = session.Query<Termin>().Where(t => t.TerminID == idTermina).First();
                    termin.Status = "Realizovan";
                    p.Termin = termin;
                    session.SaveOrUpdate(p);
                    tx.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static void ObaviAnalizu(int idPregleda, LaboratorijskaAnaliza a)
        {
            try
            {
                using (ISession session = DataLayer.GetSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    Pregled pregled = session.Query<Pregled>().Where(t => t.PregledID == idPregleda).First();
                    a.Pregled = pregled;
                    a.Lekar = pregled.Lekar;
                    a.Pacijent = pregled.Pacijent;
                    session.SaveOrUpdate(a);
                    tx.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static void ObrisiTermin(int idTermina)
        {
            try
            {
                using (ISession session = DataLayer.GetSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    Termin t = session.Get<Termin>(idTermina);
                    session.Delete(t);
                    tx.Commit();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void IzbaciRacun(Racun r, List<StavkaRacuna> stavke)
        {
            try
            {
                using (ISession session = DataLayer.GetSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    Racun racun = r;
                    foreach (var stavka in stavke)
                    {
                        Usluga persistentUsluga = session.Merge(stavka.Usluga);
                        StavkaRacuna novaStavka = new StavkaRacuna
                        {
                            Racun = r,
                            Usluga = persistentUsluga,
                            Kolicina = stavka.Kolicina,
                            Popust = stavka.Popust
                        };

                        r.StavkaRacuna.Add(novaStavka);
                    }

                    session.SaveOrUpdate(racun);
                    tx.Commit();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static List<OsiguravajucaKuca> VratiOsiguravajuceKuce()
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var kuce = s.Query<OsiguravajucaKuca>().ToList();

                    return kuce;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static void DodajOsiguranje(string naziv)
        {
            try
            {
                using(ISession s = DataLayer.GetSession())
                using(ITransaction tx = s.BeginTransaction())
                {
                    OsiguravajucaKuca osiguranje = new OsiguravajucaKuca();
                    osiguranje.Naziv = naziv;
                    s.Save(osiguranje);
                    tx.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static List<Osiguranje> VratiOsiguranja(int broj_kuce)
        {
            try
            {
                using(ISession s = DataLayer.GetSession())
                {
                    var osiguranja = s.Query<Osiguranje>()
                              .Where(p => p.Kuca.BrojKuce == broj_kuce)
                              .ToList();
                    return osiguranja;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
