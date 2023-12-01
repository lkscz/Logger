using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadLogFiles;

namespace UnitTestErrorELENA
{
    [TestClass]
    public class UnitTestElenaData
    {
        [TestMethod]
        public void FirstDateAndTime()
        {
            var logerrorelena = new ErrorELENA();

            var logLines = "2023-11-27 09:18:12";

            Assert.IsTrue(logerrorelena.FirstDate(logLines));
            Assert.AreEqual(new DateTime(2023, 11, 27, 09, 18, 12), logerrorelena.DateTimeBeginning);
        }

        [TestMethod]
        public void LastDateAndTime()
        {
            var logerrorelena = new ErrorELENA();

            var logLines = "2023-11-27 09:19:12.5599;XEN-10;oceane.brizard;";
           
            Assert.IsTrue(logerrorelena.LastDate(logLines));
            Assert.AreEqual(new DateTime(2023, 11, 27, 09, 19, 12), logerrorelena.DateTimeEnd);
        }

        [TestMethod]
        public void ErrorLineOK()
        {
            var logerrorelena = new ErrorELENA();

            var logLines = @"à GestionSinistre.Business.ExchangeManager.bgw_Delete_DoWork(Object sender, DoWorkEventArgs e) dans D:\a\1\s\GestionSinistre.Business\MANAGER\Exchange\ExchangeManager.cs:ligne 844";

            Assert.AreEqual(true, logerrorelena.ErrorLine(logLines));
            Assert.AreEqual(844, logerrorelena.LineNumber);
        }

        [TestMethod]
        public void ErrorLineKO()
        {
            var logerrorelena = new ErrorELENA();
            var logLines = "Invalid log entry";
            Assert.IsFalse(logerrorelena.ErrorLine(logLines));
        }

        [TestMethod]
        public void NameServer()
        {
            var logerrorelena = new ErrorELENA();
            var logLines = "2023-11-27 09:19:12.5599;XEN-10;oceane.brizard;";

            Assert.IsTrue(logerrorelena.NameOfTheServer(logLines));
            Assert.AreEqual("XEN-10", logerrorelena.ServerName);
        }

        [TestMethod]
        public void NameOfTheUser()
        {
            var logerrorelena = new ErrorELENA();
            var logLines = "2023-11-27 09:19:12.5599;XEN-10;oceane.brizard;";

            Assert.IsTrue(!logerrorelena.NameOfTheUser(logLines));
            Assert.AreEqual("oceane.brizard", logerrorelena.UserName);
        }
    }
}
