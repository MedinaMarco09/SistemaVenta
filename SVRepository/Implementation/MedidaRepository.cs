
using System.Data;
using Microsoft.Data.SqlClient;
using SVRepository.DB;
using SVRepository.Entities;
using SVRepository.Interfaces;

namespace SVRepository.Implementation
{
    public class MedidaRepository : IMedidaRepository  //Metodo para realizar la operacion de la lista de medida de nuestra base de datos
    {
        private readonly Conexion _conexion;
        //private readonly Conexion con = new Conexion(); //instancias
        public MedidaRepository(Conexion conexion) // constructor es el primer metodo que se ejecuta esta clase medida repository
        {
            _conexion = conexion;
            //con.Obtener()
        }
        public async Task<List<Medida>> Lista()
        {
            List<Medida>lista = new List<Medida>();
            using (var con = _conexion.ObtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaMedida", con);
                cmd.CommandType = CommandType.StoredProcedure;
                using(var dr = await cmd.ExecuteReaderAsync())//Using crear una variable y que muere despues de usarla
                {
                    while(await dr.ReadAsync())
                    {
                        lista.Add(new Medida
                        {
                            IdMedida = Convert.ToInt32(dr["IdMedida"]),
                            Nombre = dr["Nombre"].ToString(),
                            Abreviatura = dr["Nombre"].ToString(),
                            Equivalente = dr["Nombre"].ToString(),
                            Valor = Convert.ToInt32(dr["Valor"])

                        });
                    }
                }
            }
            return lista;
        }
    }
}
