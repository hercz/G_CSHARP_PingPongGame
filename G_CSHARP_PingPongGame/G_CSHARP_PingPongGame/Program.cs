using System;
using System.Windows.Forms;

namespace G_CSHARP_PingPongGame
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
            Application.Run(new PingPongGameForm());
        }
    }
}
