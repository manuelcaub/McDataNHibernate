using System.Collections.Generic;
using NHibernate;
using System.Linq;
using NHibernate.Linq;

namespace Data
{
    public class CoreDao <TEntity>
    {
        private readonly ISessionProvider _sessionProvider;

        public CoreDao(ISessionProvider sessionProvider)
        {
            _sessionProvider = sessionProvider;
        }

        public IList<TEntity> Get()
        {
            using (ISession session = _sessionProvider.OpenSession())
            {
                return session.Query<TEntity>().ToList();
            }
        }

        public void Put(TEntity t)
        {
            using (ISession session = _sessionProvider.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    session.SaveOrUpdate(t);
                    tx.Commit();
                }
            }
        }
    }
}
