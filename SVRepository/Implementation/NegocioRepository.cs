

using Microsoft.Data.SqlClient;
using System.Data;
using SVRepository.DB;
using SVRepository.Entities;
using SVRepository.Interfaces;

namespace SVRepository.Implementation
{
    public class NegocioRepository : INegocioRepository
    {
        private readonly Conexion _conexion;
        //private readonly Conexion con = new Conexion(); //instancias
        public NegocioRepository(Conexion conexion) // constructor es el primer metodo que se ejecuta esta clase medida repository
        {
            _conexion = conexion;
            //con.Obtener()
        }
        public async Task<Negocio> Obtener()
        {
            Negocio objeto = new Negocio();
            using (var con = _conexion.ObtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_obtenerNegocio", con);//procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())//Using crear una variable y que muere despues de usarla
                {
                    if (await dr.ReadAsync())
                    {
                        objeto = new Negocio()
                        {
                            RazonSocial = dr["RazonSocial"].ToString(),
                            RFC = dr["RFC"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Celular = dr["Celular"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            SimboloMoneda = dr["SimboloMoneda"].ToString(),
                            NombreLogo = dr["NombreLogo"].ToString(),
                            UrlLogo = dr["UrlLogo"].ToString(),

                        };

                    }
                }
            }
            return objeto;
        }

        

        public async Task Editar(Negocio objeto)
        {
            using (var con = _conexion.ObtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarNegocio", con);
                cmd.Parameters.AddWithValue("@RazonSocial", objeto.RazonSocial);
                cmd.Parameters.AddWithValue("@RFC", objeto.RFC);
                cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                cmd.Parameters.AddWithValue("@Celular", objeto.Celular);
                cmd.Parameters.AddWithValue("@Correo", objeto.Correo);
                cmd.Parameters.AddWithValue("@SimboloMoneda", objeto.SimboloMoneda);
                cmd.Parameters.AddWithValue("@NombreLogo", objeto.NombreLogo);
                cmd.Parameters.AddWithValue("@UrlLogo", objeto.UrlLogo);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    await cmd.ExecuteNonQueryAsync();
                }
                catch
                {
                    throw;
                }


            }
        }


    }
}
