using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public bool Btn_Moins_Clicked { get; set; } 
        public bool Btn_Diviser_Clicked { get; set; }
        public ESigne Signe { get; set; }
        public Calculette()
        {
            Btn_Plus_Clicked = false;
            Btn_Multiplier_Clicked = false;
            Btn_Exe_Clicked = false;
            Btn_Moins_Clicked = false;
            Btn_Diviser_Clicked = false;
        }
       
        public string Calcul()
        {
            

            int calcul = 0;

            switch (Signe)
            {
                case ESigne.ADDITION:
                    Last_Num = Ajouter();
                    calcul = Additioner(First_Num, Last_Num);
                    calcul.ToString();
                    break;
                case ESigne.SOUSTRACTION:
                    Last_Num = Enlever();
                    calcul = Soustraire(First_Num, Last_Num);
                    calcul.ToString();
                    break;
                case ESigne.MULTIPLICATION:
                    Last_Num = Multiplier();
                    calcul = Multiplication(First_Num, Last_Num);
                    calcul.ToString();
                    break;
                case ESigne.DIVISION:
                    Last_Num = Diviser();
                    calcul = Division(First_Num, Last_Num);
                    calcul.ToString();
                    break;
                default:
                    break;

            }
            return calcul.ToString();
        }

        public string Calculer(string chantTexte)
        {
            int calcul = Additioner(First_Num, Last_Num);
            chantTexte = calcul.ToString();

            string snumber = First_Num.ToString();

            if (Btn_Moins_Clicked)
            {
                chantTexte = snumber;
                Btn_Moins_Clicked = false;
            }
            else
            {
                chantTexte += snumber;
            }
            return chantTexte;
        }

        public int AfterClickButtonSign(string textboxValue, ESigne signe)
        {
            string valeurTexte = textboxValue;
            int valeurEntiere;

            if (!int.TryParse(valeurTexte, out valeurEntiere))
            {
                MessageBox.Show("La conversion a échouée . Assurez-vous d'entrer un nombre valide");
            }

            Signe = signe;
            return valeurEntiere;
        }
        public int Ajouter(string textboxValue)
        {
            string valeurTexte = textboxValue;
            int valeurEntiere;

            if (!int.TryParse(valeurTexte, out valeurEntiere))
            {
                MessageBox.Show("La conversion a échouée . Assurez-vous d'entrer un nombre valide");
            }

            Btn_Plus_Clicked = true;
            return valeurEntiere;
        }
        public int Enlever(string textboxValue)
        {
            string valeurTexte = textboxValue;
            int valeurEntiere;

            if (!int.TryParse(valeurTexte, out valeurEntiere))
            {
                MessageBox.Show("La conversion a échoué. Assurez-vous d'avoir entré un nombre valide");
            }

            Btn_Moins_Clicked = true;
            return valeurEntiere;
        }

        public int Multiplier(string textboxValue)
        {
            string valeurTexte = textboxValue;
            int valeurEntiere;

            if (!int.TryParse(valeurTexte, out valeurEntiere))
            {
                MessageBox.Show("La conversion a échoué. Assurez-vous s'avoir entré un nombre valide");
            }

            Btn_Multiplier_Clicked = true;
            return valeurEntiere;
        }

        public int Diviser(string textboxValue)
        {
            string valeurTexte = textboxValue;
            int valeurEntiere;

            if (!int.TryParse(valeurTexte, out valeurEntiere))
            {
                MessageBox.Show("La conversion a échoué. Assurez-vous d'avoir entré un nombre valide");
            }

            Btn_Diviser_Clicked = true;
            return valeurEntiere;
        }
       
        public int Additioner(int a, int b)
        {
            return a + b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Soustraire(int a, int b)
        {
            return a - b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
