using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Gestion
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());//
        }
        /// <summary>
        /// 
        /// </summary>
        /// 


        
    }

}


            // "A" count as one but if another "A" is found, add it to the first one to make "A" not oly one but two.
            // Same for "B" and "C", if the program finds another one than the first one, add it to the firt and make a list.
            // Then, when the list will be created, the list should be listed to make a list of list made of A*4; B*1; and C*2.
            //When this list of list will be created, I'll be finished.
            