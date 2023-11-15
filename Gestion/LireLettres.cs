using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion
{
    public static class LireLettres
    {
        private static SortedList<string, int> listelignes = new SortedList<string, int>();
        public static void RemplirListeLettres()
        {
            string[] listedeligne = new string[] { "A", "A", "A", "B", "A", "C", "C" };

            for (int i = 0; i < listedeligne.Length; i++)
            {


                string ligne = listedeligne[i];
                LireLigne(ligne);
            }


        }

        private static void LireLigne(string ligne)
        {
            if (ligne == "A")
            {
                CreateLigneA(ligne);
            }

            if (ligne == "B")
            {
                CreateLigneB(ligne);
            }

            if (ligne == "C")
            {
                CreateLigneC(ligne);
            }
        }

        private static void CreateLigneA(string lettre)
        {
            //List<string> ligneA = new List<string>();
            //ligneA.Add(ligne);
            //listelignes.Add(ligneA);

            if (listelignes.ContainsKey(lettre))
            {
                listelignes[lettre]++;
            }
            else
            {
                listelignes.Add(lettre, 1);
            }
        }
        private static void CreateLigneB(string lettre)
        {
            if (listelignes.ContainsKey(lettre))
            {
                listelignes[lettre]++;

            }
            else
            {
                listelignes.Add(lettre, 1);
            }
        }
        private static void CreateLigneC(string lettre)
        {
            if (listelignes.ContainsKey(lettre))
            {
                listelignes[lettre]++;

            }
            else
            {
                listelignes.Add(lettre, 1);
            }
        }
    }

}
