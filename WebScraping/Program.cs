using System;
using System.Linq;
using System.Windows.Forms;
using WebScraping.Forms;

namespace WebScraping
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
            Application.Run(new RPA());
        }
    }
}