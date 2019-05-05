using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sidebar
{
    static class Program
    {
        // CLASS VARS /////////////////////////////////////////////////////////////////////////////

        // the registry-key-address
        public const string keyAddr = "SOFTWARE\\Barn\\SideBar";

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            
            FrmPreferences manager = new FrmPreferences();
            Application.Run( manager);
            
            

        }
    }
}
