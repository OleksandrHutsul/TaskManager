namespace TaskManager
{
    internal static class Program
    {
        public static bool isUserLoggedIn = false;
        public static int userId = 0;
        public static string userName = "";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new SignUp());
        }
    }
}