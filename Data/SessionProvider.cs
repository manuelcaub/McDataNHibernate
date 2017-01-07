using Data.McFluentNHibernate;
using Data.McNHibernate;
using NHibernate;

namespace Data
{
    public class SessionProviderNH : ISessionProvider
    {
        public ISession OpenSession()
        {
            return NHibernateHelper.SessionFactory.OpenSession();
        }
    }

    public class SessionProviderFNH : ISessionProvider
    {
        public ISession OpenSession()
        {
            return FluentNHibernateHelper.SessionFactory.OpenSession();
        }
    }
}
