namespace FourtBitsBank_0._0._1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Utils.displayMenu();
            Application.Run(Utils.mainForm);
        }
    }
}