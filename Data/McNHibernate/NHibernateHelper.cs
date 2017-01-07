using System.IO;
using NHibernate;
using NHibernate.Cfg;

namespace Data.McNHibernate
{
    public static class NHibernateHelper
    {
        public static ISessionFactory SessionFactory { get; private set; }

        private static Configuration Configure(DataConfig cfg)
        {
            return new Configuration()
                .SetProperty(Environment.ConnectionProvider, cfg.ConnectionProvider)
                .SetProperty(Environment.Dialect, cfg.Dialect)
                .SetProperty(Environment.ConnectionDriver, cfg.ConnectionDriver)
                .SetProperty(Environment.FormatSql, cfg.FormatSql.ToString())
                .SetProperty(Environment.ShowSql, cfg.ShowSql.ToString())
                .SetProperty(Environment.ConnectionString, "Server=" + cfg.Server + ";Port=" + cfg.Port + ";Database=" + cfg.Database + ";Uid=" + cfg.User + ";Pwd=" + cfg.Password)
                .SetProperty(Environment.ConnectionStringName, cfg.ConnectionStringName)
                .AddDirectory(new DirectoryInfo(Directory.GetCurrentDirectory()));
        }

        public static void Connect(DataConfig cfg)
        {
            SessionFactory = Configure(cfg).BuildSessionFactory();
        }
    }
}
