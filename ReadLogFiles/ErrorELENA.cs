using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReadLogFiles
{
    public class ErrorELENA
    {
        private const string DELIMITERLINE = ".cs:ligne ";
        private const string PREMIEREDATE = "";
        private const string DERNIEREDATE = "";

        public ErrorELENA()
        {

        }

        #region Proprietes
        public DateTime DateTimeBeginning { get; set; }

        public DateTime DateTimeEnd { get; set; }

        public int Lines { get; set; }

        public string UserName { get; set; }

        public string ServerName { get; set; }
        #endregion

        public bool FirstDate(string firstDateTime)
        {
            var firstDateFound = firstDateTime.Contains(PREMIEREDATE);
            string maChaine = "Partie1, Partie2, Partie3";
            string[] parties = maChaine.Split(';');
            if (!firstDateFound) return false;
        }

        public bool LastDate(string lastDateTime)
        {
            var lastDateFound = lastDateTime.Contains(DERNIEREDATE);
            string myString = "Partie1, Partie2, Partie3";
            string[] parties = myString.Split(';');
            if (!lastDateFound) return false;
        }

        public bool ErrorLine(string Line)
        {
            var delimiterFound = Line.Contains(DELIMITERLINE);
            if (!delimiterFound) return false;

            return false;
        }

        public bool NameOfTheServer()
        {
            return false;
        }

        public bool NameOfTheUser()
        {
            return false;
        }
    }
}
