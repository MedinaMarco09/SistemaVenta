using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SVPresentation.Formularios;
using SVRepository;
using SVRepository.Implementation;
using SVRepository.Interfaces;
using SVServices;
using SVServices.Implementation;
using SVServices.Interfaces;

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
            var formService = Host.Services.GetRequiredService<frmCategoria>();


            Application.Run(formService);
        }

        static IHostBuilder CreateHostbuilder() => Host.CreateDefaultBuilder()//Configuracion Host para app settings json
            .ConfigureAppConfiguration((context, config) => {                //- context: Proporciona información sobre el host actual.
                                                                             //- config: Permite modificar la configuración.
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>/*Configurar services y la capa de repositorio de service*/
            {



                services.RegisterRepositoryDependecies();
                services.RegisterServicesDependecies();//Usar repositorio primero para dar vida y que medida use primero el
                                                       //repositorio y luego usar el servicio para luego la capa de presentacion

                services.AddTransient<frmCategoria>();
                
            });
    }
}

//((context,services)) para hacer referencia