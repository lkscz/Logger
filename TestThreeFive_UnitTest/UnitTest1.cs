using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ThreeFive
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUn()
        {
            Lettres lettres = new Lettres();
            Assert.AreEqual("1", lettres.GetLettre(1, 1));
        }

        [TestMethod]
        public void TestDeux()
        {
            Lettres lettres = new Lettres();
            Assert.AreEqual("2", lettres.GetLettre(2, 2));
        }

        [TestMethod]
        public void TestTrois()
        {
            Lettres lettres = new Lettres();
            Assert.AreEqual("Three", lettres.GetLettre(3, 3));
        }

        [TestMethod]
        public void TestCinq()
        {
            Lettres lettres = new Lettres();
            Assert.AreEqual("Five", lettres.GetLettre(5, 5));
        }

        [TestMethod]
        public void TestUn_a_Deux()
        {
            Lettres lettres = new Lettres();
            Assert.AreEqual("12", lettres.GetLettre(1, 2));
        }

        [TestMethod]
        public void TestUn_a_Trois()
        {
            Lettres lettres = new Lettres();
            Assert.AreEqual("12Three", lettres.GetLettre(1, 3));
        }

        [TestMethod]
        public void TestUn_a_Quatre()
        {
            Lettres lettres = new Lettres();
            Assert.AreEqual("12Three4", lettres.GetLettre(1, 4));
        }

        [TestMethod]
        public void TestQuinze()
        {
            Lettres lettres = new Lettres();
            Assert.AreEqual("12Three4FiveThree78ThreeFive11Three1314ThreeFive", lettres.GetLettre(1, 15));
        }

        //[TestMethod]
        //public void TestSix()
        //{
        //    Lettres lettres = new Lettres();
        //    Assert.AreEqual("Three", lettres.RenommerChiffres(3));
        //}

        //[TestMethod]
        //public void TestSept()
        //{
        //    Lettres lettres = new Lettres();
        //    Assert.AreEqual("1234567", lettres.GetLettre(1234567));
        //}

        //[TestMethod]
        //public void TestHuit()
        //{
        //    Lettres lettres = new Lettres();
        //    Assert.AreEqual("12345678", lettres.GetLettre(12345678));
        //}

        //[TestMethod]
        //public void TestNeuf()
        //{
        //    Lettres lettres = new Lettres();
        //    Assert.AreEqual("Three", lettres.RenommerChiffres(3));
        //}

        //[TestMethod]
        //public void TestDix()
        //{
        //    Lettres lettres = new Lettres();
        //    Assert.AreEqual("Five", lettres.RenommerChiffres(5));
        //}

        //[TestMethod]
        //public void TestOnze()
        //{
        //    Lettres lettres = new Lettres();
        //    Assert.AreEqual("1234567891011", lettres.GetLongLettre(1234567891011));
        //}

        //[TestMethod]
        //public void TestDouze()
        //{
        //    Lettres lettres = new Lettres();
        //    Assert.AreEqual("Three", lettres.RenommerChiffres(3));
        //}

        //[TestMethod]
        //public void TestTreize()
        //{
        //    Lettres lettres = new Lettres();
        //    Assert.AreEqual("12Three4FiveThree", lettres.GetLongLettre(12345678910111213));
        //}

        //[TestMethod]
        //public void TestQuatorze()
        //{
        //    Lettres lettres = new Lettres();
        //    Assert.AreEqual("1234567891011121314", lettres.GetLongLettre(1234567891011121314));
        //}


    }
}
