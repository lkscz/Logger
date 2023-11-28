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
        ReadFiles readFiles;
        public Form()
        {
            InitializeComponent();
            readFiles = new ReadFiles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowErrorBox.Text = "Error";
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
                    readFiles.Lines.Add(line);
                }
                readFiles.FillLinesError();
                AlimenterTextBoxError(readFiles.LinesError.ToArray());
            }
        }

        private void AlimenterTextBoxError(string[] lines)
        {
            textBox2.Text = string.Join(Environment.NewLine, lines);
        }

        private void ShowErrorBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Files_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox2.Text);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
