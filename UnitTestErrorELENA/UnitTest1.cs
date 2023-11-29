using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadLogFiles;

namespace UnitTestErrorELENA
{
    [TestClass]
    public class ElenaData
    {
       


        [TestMethod]
        public void FirstDateAndTime()
        {
            {
                var logerrorelena = new ErrorELENA();

                var logLines = ("2023-11-27 09:18:12.5599;XEN-10;oceane.brizard;GestionSinistre.DefaultElenaLogger;Le rdv est déjà supprimé;Warn;\"Status Code: NotFound");
                
                Assert.IsTrue(logerrorelena.FirstDate());
                Assert.AreEqual(new DateTime(2023, 11, 27, 09, 18, 12), logerrorelena.DateTimeBeginning);
               //Assert.AreEqual(DateTime.Now.Hour, result.Hour);
                //Assert.AreEqual(DateTime.Now.Minute, result.Minute);
            }
        }

        [TestMethod]
        public void LastDateAndTime()
        {
            var logerrorelena = new ErrorELENA();

            var logLines = (@"2023-11-27 09:19:12.5599;XEN-10;oceane.brizard;");
           
            string line = "Invalid log entry";
            Assert.IsTrue(logerrorelena.LastDate());
            Assert.AreEqual(new DateTime(2023, 11, 27, 09, 19, 12), logerrorelena.DateTimeEnd);
        }

        [TestMethod]
        public void ErrorLine()
        {
            var logerrorelena = new ErrorELENA();

            var logLines = ("Microsoft.Graph.ServiceException: Code: ErrorItemNotFound");

            string line = "Invalid log entry";

            Assert.IsTrue(logerrorelena.ErrorLine());
            Assert.AreEqual("844", logerrorelena.Lines);
        }

        [TestMethod]
        public void NameOfTheServer()
        {
            var logerrorelena = new ErrorELENA();

            var logLines = ("2023-11-27 09:19:12.5599;XEN-10;oceane.brizard;");

            string line = "Invalid log entry";

            Assert.IsTrue(logerrorelena.NameOfTheServer());
            Assert.AreEqual("XEN-10", logerrorelena.ServerName);
        }

        [TestMethod]
        public void NameOfTheUser()
        {
            var logerrorelena = new ErrorELENA();

            var logLines = ("2023-11-27 09:19:12.5599;XEN-10;oceane.brizard;");

            string line = "Invalid log entry";

            Assert.IsTrue(!logerrorelena.NameOfTheUser());
            Assert.AreEqual("oceane.brizard", logerrorelena.UserName);
        }
    }
}
