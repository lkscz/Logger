using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadLogFiles
{
    public partial class Form : System.Windows.Forms.Form
    {
        ReadFiles ReadFiles;
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowErrorBox.Text = "Error";
            ReadFiles = new ReadFiles();
        }

        public void btn_Find_Error_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string cheminFichier = openFileDialog.FileName;
                var lines = File.ReadAllLines(cheminFichier);
                foreach (var line in lines)
                {
                    ReadFiles.Lines.Add(line);
                }
            }
        }

        private void ShowErrorBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
