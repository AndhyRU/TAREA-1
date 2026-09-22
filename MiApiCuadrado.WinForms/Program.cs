using System.Net.Http;
using MiApiCuadrado.WinForms.Services;

namespace MiApiCuadrado.WinForms
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

            var HttpClient = new HttpClient
            {
                BaseAddress = new Uri("https://atreaapi-cdbcfmcffuaec7hf.centralus-01.azurewebsites.net/")
            };

            var estudianteService =
               new EstudianteService(HttpClient);

            Application.Run(new FormEstudiantes(estudianteService));
        }
    }
}