using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PlanettePalette
{
    static class Program
    {
        static internal Form1 MainApp;
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            Log.InitializeLog();
            Log.WriteNormal("PROGRAM", "Application.Start()");
            MainApp = new Form1();
            Application.Run(MainApp);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Log.WriteException(e.Exception);
            MainApp.ErrorState.Text = e.Exception.Message;
            MainApp._tickCount = 0;
            MainApp.ErrorTimer.Start();
        }
    }
}
