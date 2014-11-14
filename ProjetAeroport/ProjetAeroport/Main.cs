// Main.cs 
// Description du programme : 
// Programmé par Alexis Coté et Antony Garand ~ Tous drois réservé ~
// Le : 14 novembre 2014         
// Historique des modifications
// Par :
// Le : 
// Modif : 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetAeroport
{
    /// <summary>
    /// Gere la creation du form.
    /// </summary>
    static class Main
    {
        /// <summary>
        /// Point d'entré du programme
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
