namespace Travail1
{
    internal static class Program
    {
        static bool menuOk = false;
        static string joueur1Nom;
        static string joueur2Nom;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FormDebut frmMenu = new FormDebut();
            Application.Run(frmMenu);
            if (menuOk)
            {
                Application.Run(new FormJeu(joueur1Nom, joueur2Nom));
            }
        }
        public static void menuValidation(string joueur1, string joueur2)
        {
            joueur1Nom = joueur1;
            joueur2Nom = joueur2;
            menuOk = true;
        }
    }
}
