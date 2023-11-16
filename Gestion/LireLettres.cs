using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion
{
    public class LireLettres
    {
        public LireLettres() 
        {
            listelignes = new SortedList<string, int>();
        }
        public SortedList<string, int> listelignes { get; set; }
        public void RemplirListeLettres(string[] listedeligne)
        {
            for (int i = 0; i < listedeligne.Length; i++)
            {
                string ligne = listedeligne[i];
                //LireLigne(ligne);
                CreateLigne(ligne);
            }


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lettre"></param>
        private void CreateLigne(string lettre)
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
    }

    

    
}
