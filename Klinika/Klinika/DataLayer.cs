using System;
using NHibernate;
using NHibernate.Driver;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Klinika.Mapiranja;

namespace Klinika
{
    public class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static readonly object objLock = new object();

        public static ISession GetSession()
        {
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }

            return _factory.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleDataClientConfiguration.Oracle10
                .Driver<OracleManagedDataClientDriver>()
                .ShowSql()
                .ConnectionString(c =>
                    c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S19503;Password=matematika03"));

                return Fluently.Configure()
                    .Database(cfg)
                    .Mappings(m => m.FluentMappings
                        .AddFromAssembly(typeof(KlinikaMap).Assembly)
                    )
                    .BuildSessionFactory();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.ToString(), "Greska DataLayer",
                                                    System.Windows.Forms.MessageBoxButtons.OK,
                                                    System.Windows.Forms.MessageBoxIcon.Error);

                throw;
            }
        }
    }
}