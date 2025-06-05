
using Microsoft.Extensions.DependencyInjection;

using SVServices.Implementation;
using SVServices.Interfaces;

namespace SVServices
{
    public static class DependencyInjection
    {
        public static void RegisterServicesDependecies(this IServiceCollection services) //Metodo encontrado en Program.cs
        {
            services.AddTransient<IMedidaService, MedidaService>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IProductoService, ProductoService>();
            services.AddTransient<INegocioService, NegocioService>();
            services.AddTransient<ICloudinaryService, CloudinaryService>();
            services.AddTransient<IRolService, RolService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<ICorreoService, CorreoService>();
            services.AddTransient<IVentaService, VentaService>();
            services.AddTransient<IMenuRolService, MenuRolService>();


        }
    }
}
