using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



// $G$ THE-001 (0) your grade on diagrams document - 100 please see comments inside the document. (50% of your grade).

namespace WindowsFormsFacebook
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}