using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.IO;
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
            LinesByError = new SortedList<string, int>();
        }

        public List<string> Lines { get; set; }
        public List<string> LinesError { get; set; }
        public SortedList<string, int> LinesByError { get; set; }
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

        public void WriteLines(string cheminFichier)
        {
            File.WriteAllLines(cheminFichier, LinesError.ToArray());
        }

        public void StackErrors()
        {
            foreach(string line in LinesError)
            {
                if (LinesByError.ContainsKey(line))
                {
                    LinesByError[line]++;
                }
                else
                {
                    LinesByError.Add(line, 1);
                }
            }
        }
    }
}
