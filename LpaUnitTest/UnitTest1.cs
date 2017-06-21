using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LPA.Controllers;
using LPA.Domain;
using System.Collections.Generic;

namespace LpaUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        UitslagController uitslagCon = new UitslagController();
        private Uitslag uitslag;
        [TestInitialize]
        public void TestInitialize()
        {
        }

        [TestMethod]
        public void TestMethod1()
        {
            uitslagCon.createUitslag("unitTest", "2017-1-1");
            Assert.AreEqual(uitslag.naam, "unitTest");
            Assert.AreEqual(uitslag.datum, "2017-1-1");
        }
    }
}
