using WinFormsApp1.Models;

namespace WinFormsApp1
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
            Application.Run(new Form1());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserModel userModel = new UserModel() { Username = "JohnDoe" };
            UserViewForm userViewForm = new UserViewForm(new UserController(userModel, new UserViewForm()));

            Application.Run(userViewForm);
        }
    }
}