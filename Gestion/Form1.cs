using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_search_Click(object sender, EventArgs e)
        {
            // LireLettres.RemplirListeLettres();
            // lirefichier
            LireFichiers.ParcourirFichiers();
        }

        private void Search_Bar_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            LireFichiers.SauverFichiers();
        }

        private void Btn_Letters_Click(object sender, EventArgs e)
        {
            
            LireLettres lireLettres = new LireLettres();

            var textsplit = TBX_SearchBar.Text.Split(',');

            lireLettres.RemplirListeLettres(textsplit);
        }
        
    }
}
