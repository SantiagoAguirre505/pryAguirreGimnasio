using pryAguirreGimnasio;

namespace pryAguirreGimnasio
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (frmSplash splash = new frmSplash())
            {
                splash.ShowDialog(); // blocks here until splash closes itself
            }
            Application.Run(new frmInicio());
        }
    }
}