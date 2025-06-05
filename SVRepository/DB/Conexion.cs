using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SVRepository.DB
{
    public class Conexion
    {
        private readonly IConfiguration _configuracion;//Variable para acceder a los archivos appsettings.json
        private readonly string _cadenaSql;

        public Conexion(IConfiguration configuracion)//Lee el archivo de configuracion(appsettings)
        {
            _configuracion = configuracion;
            _cadenaSql = _configuracion.GetConnectionString("CadenaSql")!; //nodo, !no es valor null
        }   

        public SqlConnection ObtenerSQLConexion()
        {
            return new SqlConnection(_cadenaSql);
        }
    }
}

//private readonly Conexion _conexion;

//public Repository(Conexion conexion)
//{
//    _conexion = conexion;

//}

// **************************************************************************
// *                   Repository y Service                                 *
// **************************************************************************

//private readonly I"Entidad"Repository _"entidad"Repository; //Inyeccion de instancias

//public "Entidad"Service(I"Entidad"Repository "entidad"Repository) //constructor
//{
//    _"entidad"Repository = "entidad"Repository;
//}