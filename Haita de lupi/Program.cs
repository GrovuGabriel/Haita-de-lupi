using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haita_de_lupi
{
    internal static class Program
    {
        


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new button());
        }

    }
    public static class caracter
    {
        public static bool baiat = true;
        public static int hp=3;
        public static bool usor=true;
        public static double frica = 0;
    }
    
}
