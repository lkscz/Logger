using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadLogFiles
{
    public class ReadFiles
    {
        public ReadFiles()
        {
            Lines = new List<string>();
            LinesError = new List<string>();
        }

        public List<string> Lines { get; set; }
        public List<string> LinesError { get; set; }

        private const string ERROR = "error";


        public bool ErrorFinder(string line, string search)
        {
            return (line.ToLower().Contains(search));
        }

        public void FillLinesError()
        {
            try
            {
                foreach (string line in Lines)
                {
                    if (ErrorFinder(line, ERROR))
                    {
                        LinesError.Add(line);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
