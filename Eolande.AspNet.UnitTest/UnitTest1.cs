using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Reflection;
using System.Collections.Generic;
using Eolande.AspNet.IBll;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Type;
using NHibernate.SqlCommand;
using Eolande.AspNet.Domain;

namespace Eolande.AspNet.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var user = new Web.UserHelper();
            var x = user.GetMessage();
            Assert.AreEqual<string>(x, "GetMessage");
        }

        [TestMethod]
        public void TestMethod2()
        {
            ISessionFactory sessionFactory;
            var cfg = new NHibernate.Cfg.Configuration();
            sessionFactory = cfg.Configure().BuildSessionFactory();
            var session = sessionFactory.OpenSession();
            var query=session.CreateCriteria(typeof(SysUserDomain));
            var x = query.List<SysUserDomain>();
            sessionFactory.Close();

        }

    }
}
