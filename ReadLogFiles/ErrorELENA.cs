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
        private const string SERVERNAME = "";
        private const string USERNAME = "";

        public ErrorELENA()
        {

        }

        #region Proprietes
        public DateTime DateTimeBeginning { get; set; }

        public DateTime DateTimeEnd { get; set; }

        public int LineNumber { get; set; }

        public string UserName { get; set; }

        public string ServerName { get; set; }
        #endregion

        public bool FirstDate(string line)
        {
            DateTime dateTimeRetour = DateTime.Now;
            bool firstDateFound = IsDateTime(line, out dateTimeRetour);
            DateTimeBeginning = dateTimeRetour;
            return firstDateFound;
        }

        public bool LastDate(string line)
        {

            DateTime dateTimeRetour = DateTime.Now;
            bool firstDateFound = IsDateTime(line, out dateTimeRetour);
            DateTimeEnd = dateTimeRetour;
            return firstDateFound;
        }

        public bool IsDateTime(string line, out DateTime dateTime)
        {
            var lineSplit = line.Split(';');
            string firstDateTime = lineSplit[0].Substring(0,19);
            DateTime fdateTime = DateTime.Now;
            var firstDateFound = DateTime.TryParse(firstDateTime, out dateTime);
            return firstDateFound;
        }

        public bool ErrorLine(string line)
        {
            var delimiterFound = line.Contains(DELIMITERLINE);
            if (delimiterFound)
            {
                var lineSplit = line.Split(new string[] { DELIMITERLINE }, StringSplitOptions.None);
                bool lineNumberFound = int.TryParse(lineSplit[1], out int iline);
                LineNumber = iline;
                return lineNumberFound;
            }

            return false;
        }

        public bool NameOfTheServer(string line)
        {
            var tabLines = line.Split(';');
            if (tabLines.Length >= 2)
            {
                string serverName = tabLines[1];
                if (IsDateTime(tabLines[0], out DateTime test))
                {
                    ServerName = serverName;
                    return true;
                }
            }
            return false;
        }

        public bool NameOfTheUser(string line)
        {
            var tabLines = line.Split(';');
            if (tabLines.Length >= 2)
            {
                string userName = tabLines[2];
                if (IsDateTime(tabLines[0], out DateTime test))
                {
                    UserName = userName;
                    return true;
                }
            }
            return false;
        }
    }
}
