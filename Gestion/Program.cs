using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Gestion
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RemplirListeLettres();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());//
        }
        /// <summary>
        /// 
        /// </summary>
        /// 

        //
        private static SortedList<string, int> listelignes = new SortedList<string, int>();
        private static void RemplirListeLettres()
        {
            string[] listedeligne = new string[] { "A", "A", "A", "B", "A", "C", "C" };

            for (int i = 0; i < listedeligne.Length; i++)
            {
                

                string ligne = listedeligne[i];
                LireLigne(ligne);
            }


            //string ligne0 = listedeligne[0];
            //LireLigne(ligne0);
            //string ligne1 = listedeligne[1];
            //LireLigne(ligne1);
            //string ligne2 = listedeligne[2];
            //LireLigne(ligne2);
            //string ligne3 = listedeligne[3];
            //LireLigne(ligne3);
            //string ligne4 = listedeligne[4];
            //LireLigne(ligne4);
            //string ligne5 = listedeligne[5];
            //LireLigne(ligne5);
            //string ligne6 = listedeligne[6];
            //LireLigne(ligne6);


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

            if(listelignes.ContainsKey(lettre))
            {
                int nombreLettres = listelignes[lettre]++;
                listelignes[lettre] = nombreLettres;
            }
            else
            {
                listelignes.Add(lettre.ToLower(),1);
            }
        }
        private static void CreateLigneB(string ligne)
        {
            List<string> ligneB = new List<string>();
            ligneB.Add(ligne);
            listelignes.Add(ligneB);
        }
        private static void CreateLigneC(string ligne)
        {
            List<string> ligneC = new List<string>();
            ligneC.Add(ligne);
            listelignes.Add(ligneC);
        }

        // A count as one but if another A is found, add it to the first one to make 

    }


}