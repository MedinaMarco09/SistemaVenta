using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace SVPresentation
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
            var Host = CreateHostbuilder().Build();
            Application.Run(new Form1());
        }

        static IHostBuilder CreateHostbuilder() => Host.CreateDefaultBuilder()//Configuracion Host para app settings json
            .ConfigureAppConfiguration((context, config) => {                //- context: Proporciona información sobre el host actual.- config: Permite modificar la configuración.
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            });
    }
}