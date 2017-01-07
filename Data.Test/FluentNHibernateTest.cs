using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.McFluentNHibernate;
using Data.McFluentNHibernate.Model;

namespace Data.Test
{
    [TestClass]
    public class FluentNHibernateTest
    {
        [TestMethod]
        public void CoreDaoTest()
        {
            FluentNHibernateHelper.Connect();
            CoreDao<Product> dao = new CoreDao<Product>(new SessionProviderFNH());
            dao.Put(new Product { Name = "PS2", Description = "VideoConsole"});
            dao.Put(new Product { Name = "PS3", Description = "VideoConsole"});
            IList<Product> products = dao.Get();
        }

        [TestMethod]
        public void NHibernateTest()
        {
            throw new NotImplementedException();
            //NHibernateHelper.Connect(new DataConfig
            //{
                
            //});
        }
    }
}
