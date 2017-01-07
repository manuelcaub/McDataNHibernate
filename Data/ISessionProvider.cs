using NHibernate;

namespace Data
{
    public interface ISessionProvider
    {
        ISession OpenSession();
    }
}
