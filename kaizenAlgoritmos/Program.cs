using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaizenAlgoritmos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Principal miPrincipal = new Principal();
            //miPrincipal.Width = Screen.PrimaryScreen.Bounds.Width - 100;
            //miPrincipal.Height = Screen.PrimaryScreen.Bounds.Height - 100;
            Application.Run(miPrincipal);
            //Github es genial!
        }
    }
}
