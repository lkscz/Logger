using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    public class LireFichiers
    {
        private static  List<string> ligneFichiers = new List<string>();
        public static void ParcourirFichiers()
        {
            string path = @"C:/anthony.chassier.txt";

            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                ligneFichiers.Add(line);
            }
        }
        public static void SauverFichiers()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string cheminFichier = openFileDialog.FileName;
                
                File.WriteAllLines(cheminFichier, ligneFichiers.ToArray());
            }
        }




    }   
}
