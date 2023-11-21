using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        Calculette calculette;
        public Form1()
        {
            InitializeComponent();
            calculette = new Calculette();
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Number_Clicked(9);
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Number_Clicked(8);
        }
        
        private void Btn_7_Click(object sender, EventArgs e)
        {
            Number_Clicked(7);
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Number_Clicked(6);
        }
        
        private void Btn_5_Click(object sender, EventArgs e)
        {
            Number_Clicked(5);
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Number_Clicked(4);
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Number_Clicked(3);
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Number_Clicked(2);
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Number_Clicked(1);
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            Number_Clicked(0);
        }

        public void Number_Clicked(int number)
        {
            Number_Click(number);
        }

        private void Number_Click(int number)
        {
            string snumber = number.ToString();

            if (calculette.Btn_Plus_Clicked)
            {
                TextBox.Text = snumber;
                calculette.Btn_Plus_Clicked = false;
            }
            else
            {
                TextBox.Text += snumber;
            }
        }

        public void Soustraire_Clicked(int soustraire)
        {
        }


        private void Btn_Virgule_Click(object sender, EventArgs e)
        {
            TextBox.Text += ",";
        }

        private void Btn_Multiplier_Click(object sender, EventArgs e)
        {
            TextBox.Text = calculette.Calculer(TextBox.Text);
        }

        //public int Number_Del_Multiplier()
        //{
        //    string valeurTexte = TextBox.Text;
        //    int valeurEntiere;

        //    if (!int.TryParse(valeurTexte, out valeurEntiere))
        //    {

        //    }

        //    Btn_Multiplier_Clicked = true;
        //    return valeurEntiere;
        //}

        private void Btn_Diviser_Click(object sender, EventArgs e)
        {
            TextBox.Text += "/";
        }

        public void Btn_Supprimer_Click_1(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        public void ClearTextBox()
        {
            TextBox.Clear();
        }
        public void GroupBox_Enter(object sender, EventArgs e)
        {

        }

        public void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void Btn_Plus_Click(object sender, EventArgs e)
        {
            calculette.First_Num = Number_Del_Plus();
        }

        public int Number_Del_Plus()
        {
            return Ajouter();
        }

        private int Ajouter()
        {
            string valeurTexte = TextBox.Text;
            int valeurEntiere;

            if (!int.TryParse(valeurTexte, out valeurEntiere))
            {
                MessageBox.Show("La conversion a échouée . Assurez-vous d'entrer un nombre valide");
            }

            calculette.Btn_Plus_Clicked = true;
            return valeurEntiere;
        }

        public void Btn_Moins_Click(object sender, EventArgs e)
        {
            TextBox.Text = calculette.Calculer(TextBox.Text);
        }

        public void Btn_Execute_Click(object sender, EventArgs e)
        {
            calculette.Last_Num = Number_Del_Plus();
            int somme = Additioner(calculette.First_Num, calculette.Last_Num);
            TextBox.Text = somme.ToString();
        }

        public double EvaluateExpression(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        public void Compute()
        {
            try
            {
                var dataTable = new DataTable();
                var result = dataTable.Compute(TextBox.Text, "");
                TextBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de calcul : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Btn_Clear_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length != 0) 
            {
                Clear();
            }           
        }

        public void Clear()
        {
            TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length -1);
        }

        public bool parentheseOuverte = false;
        public void Btn_Parentheses_Click(object sender, EventArgs e)
        {
            if (parentheseOuverte)
            {
                TextBox.Text += ")";    
                parentheseOuverte = false;
            }
            else
            {
                TextBox.Text += "(";
                parentheseOuverte = true;
            }
        }

        public int Additioner(int a, int b)
        {
            return a + b;
        }

        public int Multiplier(int a, int b)
        {
            return a * b;
        }

        public int Soustraire(int a, int b)
        {
            return a - b;
        }

        public void listBoxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
