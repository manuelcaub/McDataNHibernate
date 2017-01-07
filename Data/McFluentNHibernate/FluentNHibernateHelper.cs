using System.IO;
using Data.McFluentNHibernate.Model;
using FluentNHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;

namespace Data.McFluentNHibernate
{
    public static class FluentNHibernateHelper

    {
        public static ISessionFactory SessionFactory { get; private set; }

        public static void Connect()
        {
            if (SessionFactory == null)
            {
                if (File.Exists("Test.db"))
                {
                    File.Delete("Test.db");
                }

                SessionFactory = Fluently.Configure()
                    .Database(SQLiteConfiguration.Standard.UsingFile("Test.db"))
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Product>())
                    .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true))
                    .BuildSessionFactory();
            }
        }
    }
}
