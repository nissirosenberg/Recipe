using CPUFramework;
using RecipeSystem;


namespace RecipesWinForms

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
            DBManager.SetConnectionString("Server=.\\SQLExpress01;Database=HeartyHearthDB;Trusted_Connection=true");
            Application.Run(new frmMain());
        }
    }
}