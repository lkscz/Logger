using System;
using System.Collections.Generic;
using Gestion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LireLettersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_A4_B1_C2_Temoin()
        {
            string[] listedeligne = new string[] { "A", "A", "A", "B", "A", "C", "C" };
            LireLettres lireLettres = new LireLettres();

            lireLettres.RemplirListeLettres(listedeligne);

            Assert.AreEqual(lireLettres.listelignes["A"], 4);
            Assert.AreEqual(lireLettres.listelignes["B"], 1);
            Assert.AreEqual(lireLettres.listelignes["C"], 2);
        }

        [TestMethod]
        public void TestMethod_A4_B1_C2_Test()
        {
            string[] listedeligne = new string[] {"A", "A", "A", "B", "A", "C", "C", "T", "Y", "H", "TYD", "TYD", "çUine8n", "Quand on y pense", "disque dur externe, SSD ou undisque dur  interne ?" };
            LireLettres lireLettres = new LireLettres();

            lireLettres.RemplirListeLettres(listedeligne);

            Assert.AreEqual(lireLettres.listelignes["A"], 4);
            Assert.AreEqual(lireLettres.listelignes["B"], 1);
            Assert.AreEqual(lireLettres.listelignes["C"], 2);
            Assert.AreEqual(lireLettres.listelignes["T"], 1);
            Assert.AreEqual(lireLettres.listelignes["Y"], 1);
            Assert.AreEqual(lireLettres.listelignes["H"], 1);
            Assert.AreEqual(lireLettres.listelignes["TYD"], 2);
            Assert.AreEqual(lireLettres.listelignes["çUine8n"], 1);
            Assert.AreEqual(lireLettres.listelignes["Quand on y pense"], 1);
            Assert.AreEqual(lireLettres.listelignes["disque dur externe, SSD ou undisque dur  interne ?"], 1);
        }   
    }
}
