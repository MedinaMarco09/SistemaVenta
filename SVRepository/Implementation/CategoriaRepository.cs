
using System.Data;

using Microsoft.Data.SqlClient;
using SVRepository.DB;
using SVRepository.Entities;
using SVRepository.Interfaces;

namespace SVRepository.Implementation
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly Conexion _conexion;
        //private readonly Conexion con = new Conexion(); //instancias
        public CategoriaRepository(Conexion conexion) // constructor es el primer metodo que se ejecuta esta clase medida repository
        {
            _conexion = conexion;
            //con.Obtener()
        }
        public async Task<List<Categoria>> Lista(string buscar = "")
        {
            List<Categoria> lista = new List<Categoria>();
            using (var con = _conexion.ObtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaCategoria", con);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())//Using crear una variable y que muere despues de usarla
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Categoria
                        {   
                            IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                            Nombre = dr["Nombre"].ToString(),
                            Activo = Convert.ToInt32(dr["Activo"]),
                            RefMedida = new Medida
                            { IdMedida = Convert.ToInt32(dr["IdMedida"]),
                            Nombre = dr["NombreMedida"].ToString()
                            }

                        });
                    }
                }
            }
            return lista;
        }
        public async Task<string> Crear(Categoria objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_crearCategoria", con);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@IdMedida", objeto.RefMedida.IdMedida);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar,100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch
                {
                    respuesta = "Error(rp): No se pudo procesar";
                }
                

            }
            return respuesta;
        }

        public async Task<string> Editar(Categoria objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarCategoria", con);
                cmd.Parameters.AddWithValue("@IdCategoria", objeto.IdCategoria);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@IdMedida", objeto.RefMedida.IdMedida);
                cmd.Parameters.AddWithValue("@Activo", objeto.Activo);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch
                {
                    respuesta = "Error(rp): No se pudo procesar";
                }


            }
            return respuesta;
        }

        
    }
}
