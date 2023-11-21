using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class Calculette
    {
        public int First_Num { get; set; }
        public int Last_Num { get; set; }
        public string First_Serie { get; set; }
        public string Last_Serie { get; set; }
        public bool Btn_Plus_Clicked {  get; set; }
        public bool Btn_Multiplier_Clicked { get; set; }
        public bool Btn_Exe_Clicked { get; set; }
        public bool Btn_Soustraire_Clicked { get; set; }
        public Calculette()
        {
            Btn_Plus_Clicked = false;
            Btn_Multiplier_Clicked = false;
            Btn_Exe_Clicked = false;
            Btn_Soustraire_Clicked = false;
        }

        public string Calculer(string chantTexte)
        {
            string snumber = First_Num.ToString();

            if (Btn_Soustraire_Clicked)
            {
                chantTexte = snumber;
                Btn_Soustraire_Clicked = false;
            }
            else
            {
                chantTexte += snumber;
            }
            return chantTexte;
        }
    }
}
