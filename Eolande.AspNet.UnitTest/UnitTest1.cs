using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Reflection;
using System.Collections.Generic;
using Eolande.AspNet.IBll;

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
            Assert.AreEqual<string>(x, "\"GetMessage\"");
        }



    }
}
