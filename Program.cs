using System;
using System.Windows.Forms;

namespace EduRelief
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Global Error Catcher
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(OnThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(OnUnhandledException);

            Application.Run(new WelcomePage());
        }

        private static void OnThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show("An error occurred: " + e.Exception.Message + "\n\n" + e.Exception.StackTrace, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            MessageBox.Show("A fatal error occurred: " + ex.Message + "\n\n" + ex.StackTrace, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}