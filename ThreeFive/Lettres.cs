using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ThreeFive
{
    public class Lettres
    {
        public string GetLettre(int chiffre, int chiffre2)
        {
            string chiffrePartielle = "";


            while (chiffre<=chiffre2)
            {
                chiffrePartielle += RenommerChiffres(chiffre);
                chiffre++;
            }

            return chiffrePartielle;
        }

        private string RenommerChiffres(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "ThreeFive";
            }
            else if (number % 3 == 0)
            {
                return "Three";
            }
            else if (number % 5 == 0)
            {
                return "Five";
            }
            else 
            {
                return number.ToString();
            }
        }
    }
}
