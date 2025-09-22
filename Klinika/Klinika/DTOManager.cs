using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Linq;
using Klinika.Entiteti;

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
                        p.IzabraniLekar.JMBG
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
        public static List<ZaposleniView> VratiZaposleneKlinike(int klinikaId)
        {
            var zaposleniView = new List<ZaposleniView>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IQuery query = session.CreateQuery(
                        "SELECT DISTINCT z FROM Odeljenje o " +
                        "JOIN o.Klinike k " +
                        "JOIN o.Zaposleni z " +
                        "WHERE k.KlinikaID = :klinikaId"
                    );
                    query.SetParameter("klinikaId", klinikaId);

                    var zaposleni = query.List<Zaposleni>();

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
                    var lokacije = s.Query<Lokacija>()
                                    .Where(l => l.Odeljenja.Any(o => o.Klinike.Any(k => k.KlinikaID == klinikaId)))
                                    .ToList();

                    foreach (var l in lokacije)
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return lokacijeView;
        }
        public static List<OdeljenjeView> VratiOdeljenja(int klinikaId)
        {
            var odeljenja = new List<OdeljenjeView>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var odlj = s.Query<Odeljenje>()
                        .Where(o => o.Klinike.Any(k => k.KlinikaID == klinikaId)).ToList();
                    foreach (var o in odlj)
                    {
                        odeljenja.Add(new OdeljenjeView(o.OdeljenjeID, o.Naziv, o.BrSobe, o.NadlezniLekar));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return odeljenja;
        }
        public static void DodajSertifikatSestra(string jmbg, string nazivSertifikata, DateTime datumIzdavanja)
        {
            using (var session = DataLayer.GetSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    MedicinskaSestra z = session.Get<MedicinskaSestra>(jmbg);
                    if (z == null) throw new Exception("Zaposleni nije pronadjen");

                    Sertifikat sert = new Sertifikat
                    {
                        Naziv = nazivSertifikata,
                        DatumIzdavanja = datumIzdavanja
                    };

                    z.Sertifikati.Add(sert);
                    sert.Zaposleni.Add(z);

                    session.SaveOrUpdate(sert);
                    session.Update(z);
                    tx.Commit();
                }
            }
        }

        public static void ObrisiSertifikatSestra(string jmbg, string nazivSertifikata)
        {
            using (var session = DataLayer.GetSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    MedicinskaSestra z = session.Get<MedicinskaSestra>(jmbg);
                    if (z == null) throw new Exception("Zaposleni nije pronadjen");

                    var sert = z.Sertifikati.FirstOrDefault(s => s.Naziv == nazivSertifikata);
                    if (sert != null)
                    {
                        z.Sertifikati.Remove(sert);
                        sert.Zaposleni.Remove(z);

                        session.Delete(sert);
                        session.Update(z);
                        tx.Commit();
                    }
                }
            }
        }
        public static void DodajSertifikatLaborant(string jmbg, string nazivSertifikata, DateTime datumIzdavanja)
        {
            using (var session = DataLayer.GetSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    Laborant z = session.Get<Laborant>(jmbg);
                    if (z == null) throw new Exception("Zaposleni nije pronadjen");

                    Sertifikat sert = new Sertifikat
                    {
                        Naziv = nazivSertifikata,
                        DatumIzdavanja = datumIzdavanja
                    };

                    z.Sertifikati.Add(sert);
                    sert.Zaposleni.Add(z);

                    session.SaveOrUpdate(sert);
                    session.Update(z);
                    tx.Commit();
                }
            }
        }

        public static void ObrisiSertifikatLaborant(string jmbg, string nazivSertifikata)
        {
            using (var session = DataLayer.GetSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    Laborant z = session.Get<Laborant>(jmbg);
                    if (z == null) throw new Exception("Zaposleni nije pronadjen");

                    var sert = z.Sertifikati.FirstOrDefault(s => s.Naziv == nazivSertifikata);
                    if (sert != null)
                    {
                        z.Sertifikati.Remove(sert);
                        sert.Zaposleni.Remove(z);

                        session.Delete(sert);
                        session.Update(z);
                        tx.Commit();
                    }
                }
            }
        }
        public static void DodajSpecijalizaciju(string jmbg, string specijalizacija)
        {
            using (var session = DataLayer.GetSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    Lekar lekar = session.Get<Lekar>(jmbg);
                    if (lekar == null) throw new Exception("Lekar nije pronadjen");

                    lekar.Specijalizacija = specijalizacija;
                    session.Update(lekar);
                    tx.Commit();
                }
            }
        }

        public static void ObrisiSpecijalizaciju(string jmbg)
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
        public static void DodajOblastRadaSestra(string jmbg, string nazivOblasti)
        {
           using (var session = DataLayer.GetSession())
           {
                using (var tx = session.BeginTransaction())
                {
                    MedicinskaSestra z = session.Get<MedicinskaSestra>(jmbg);
                    if (z == null) throw new Exception("Zaposleni nije pronađen");

                    var oblast = new OblastRada { Naziv = nazivOblasti };
                    z.OblastiRada.Add(oblast);
                    oblast.Zaposleni.Add(z);
                    session.SaveOrUpdate(oblast);
                    session.Update(z);
                    tx.Commit();
                }
           }
        }

        public static void ObrisiOblastRadaSestra(string jmbg, string nazivOblasti)
        {
            using (var session = DataLayer.GetSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    MedicinskaSestra z = session.Get<MedicinskaSestra>(jmbg);
                    if (z == null) throw new Exception("Zaposleni nije pronađen");

                    var oblast = z.OblastiRada.FirstOrDefault(o => o.Naziv == nazivOblasti);
                    if (oblast != null)
                    {
                        z.OblastiRada.Remove(oblast);
                        oblast.Zaposleni.Remove(z);

                        session.Delete(oblast);
                        session.Update(z);
                        tx.Commit();
                    }
                }
            }
        }
        public static void DodajOblastRadaLaborant(string jmbg, string nazivOblasti)
        {
            using (var session = DataLayer.GetSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    Laborant z = session.Get<Laborant>(jmbg);
                    if (z == null) throw new Exception("Zaposleni nije pronađen");

                    var oblast = new OblastRada { Naziv = nazivOblasti };
                    z.OblastiRada.Add(oblast);
                    oblast.Zaposleni.Add(z);
                    session.SaveOrUpdate(oblast);
                    session.Update(z);
                    tx.Commit();
                }
            }
        }

        public static void ObrisiOblastRadaLaborant(string jmbg, string nazivOblasti)
        {
            using (var session = DataLayer.GetSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    Laborant z = session.Get<Laborant>(jmbg);
                    if (z == null) throw new Exception("Zaposleni nije pronađen");

                    var oblast = z.OblastiRada.FirstOrDefault(o => o.Naziv == nazivOblasti);
                    if (oblast != null)
                    {
                        z.OblastiRada.Remove(oblast);
                        oblast.Zaposleni.Remove(z);

                        session.Delete(oblast);
                        session.Update(z);
                        tx.Commit();
                    }
                }
            }
        }
    }
}
