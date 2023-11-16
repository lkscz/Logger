using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion
{
    public static class ReadLetters
    {
        private static SortedList<string, string> lineslist = new SortedList<string, string>();
        public static void FillLettersList()
        {
            string[] listedelignes = new string[] { "A", "B", "B", "T", "Y", "T", "I", "I", "D", "O" };

            for (int i = 0; i < listedelignes.Length; i++)
            {
                string ligne = listedelignes[i];
                ReadLine(ligne);
            }
        }

        private static void ReadLine(string ligne)
        {
            //if (ligne == "A")
            //{
            //    CreateLigneA(ligne);
            //}

            //if (ligne == "B")
            //{
            //    CreateLigneB(ligne);
            //}

            //if(ligne == "T")
            //{
            //    CreateLigneT(ligne);
            //}

            //if (ligne == "I") 
            //{
            //    CreateLigneI(ligne);           
            //}

            //if (ligne == "Y")
            //{
            //    CreateLigneY(ligne);
            //}

            //if (ligne == "D")
            //{
            //    CreateLigneD(ligne);
            //}

            //if (ligne == "O")
            //{
            //    CreateLigneO(ligne);
            //}
            
        }


    }
}
