using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            TextBox.Text += "9";
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            TextBox.Text += "8";
        }
        
        private void Btn_7_Click(object sender, EventArgs e)
        {
            TextBox.Text += "7";
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            TextBox.Text += "6";
        }
        
        private void Btn_5_Click(object sender, EventArgs e)
        {
            TextBox.Text += "5";
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            TextBox.Text += "4";
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            TextBox.Text += "3";
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            TextBox.Text += "2";
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            TextBox.Text += "1";
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            TextBox.Text += "0";
        }

        
        private void Btn_Virgule_Click(object sender, EventArgs e)
        {
            TextBox.Text += ",";
        }

        private void Btn_Multiplier_Click(object sender, EventArgs e)
        {
            TextBox.Text += "*";
        }

        private void Btn_Diviser_Click(object sender, EventArgs e)
        {
            TextBox.Text += "/";
        }

        private void Btn_Supprimer_Click_1(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            TextBox.Clear();
        }
        private void GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            TextBox.Text += "+";
        }

        private void Btn_Moins_Click(object sender, EventArgs e)
        {
            TextBox.Text += "-";
        }

        private void Btn_Execute_Click(object sender, EventArgs e)
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

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length != 0) 
            {
                TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1); 
            }
           
        }

        private bool parentheseOuverte = false;
        private void Btn_Parentheses_Click(object sender, EventArgs e)
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
        
    }
}
