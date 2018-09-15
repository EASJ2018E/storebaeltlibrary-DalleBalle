using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltBilletLibrary;

namespace StorebaeltLibTest
{
    [TestClass]
    public class StorebaeltBilTest
    {
        [TestMethod]
        public void StandardPris()
        {
            StorebaeltBil bil = new StorebaeltBil("AB12345", new DateTime(2018, 9, 14), false);

            Assert.AreEqual(240, bil.Pris());
        }

        [TestMethod]
        public void MedBrobizzPris()
        {
            StorebaeltBil bil = new StorebaeltBil("AB12345", new DateTime(2018, 9, 14), true);

            Assert.AreEqual(228, bil.Pris());
        }

        [TestMethod]
        public void MedWeekendrabatPris()
        {
            StorebaeltBil bil = new StorebaeltBil("AB12345", new DateTime(2018, 9, 15), false);

            Assert.AreEqual(192, bil.Pris());
        }

        [TestMethod]
        public void MedBrobizzOgWeekendrabatPris()
        {
            StorebaeltBil bil = new StorebaeltBil("AB12345", new DateTime(2018, 9, 15), true);

            Assert.AreEqual((decimal)182.4, bil.Pris());
        }
    }
}
