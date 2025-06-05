using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SVRepository.DB;
using SVRepository.Entities;
using SVRepository.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SVRepository.Implementation
{
    internal class ProductoRepository : IProductoRepository
    {
        private readonly Conexion _conexion;
        //private readonly Conexion con = new Conexion(); //instancias
        public ProductoRepository(Conexion conexion) // constructor es el primer metodo que se ejecuta esta clase medida repository
        {
            _conexion = conexion;
            //con.Obtener()
        }
        public async Task<List<Producto>> Lista(string buscar = "")
        {
            List<Producto> lista = new List<Producto>();
            using (var con = _conexion.ObtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaProducto", con);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())//Using crear una variable y que muere despues de usarla
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Producto
                        {
                            IdProducto = Convert.ToInt32(dr["IdProducto"]),
                            RefCategoria = new Categoria
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Nombre = dr["NombreCategoria"].ToString()
                            },
                            Codigo = dr["Codigo"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
                            PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                            PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),//REVISAR *** Se cambio (int)Convert porque no dejaba entero a decimal, REVISAR*** UPDATE Revisado, habia un error en las entidades de producto!
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            Activo = Convert.ToInt32(dr["Activo"])

                        });
                    }
                }
            }
            return lista;
        }
        public async Task<string> Crear(Producto objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSQLConexion())
            {
                con.Open();
                
                var cmd = new SqlCommand("sp_crearProducto", con);
                cmd.Parameters.AddWithValue("@IdCategoria", objeto.RefCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("@Codigo", objeto.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);
                cmd.Parameters.AddWithValue("@PrecioCompra", objeto.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", objeto.PrecioVenta);
                cmd.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch
                {
                    respuesta = "Error(rpProduct): No se pudo procesar";
                }


            }
            return respuesta;
        }

        public async Task<string> Editar(Producto objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSQLConexion())
            {
                con.Open();

                var cmd = new SqlCommand("sp_editarProducto", con);
                cmd.Parameters.AddWithValue("@IdProducto", objeto.IdProducto);
                cmd.Parameters.AddWithValue("@IdCategoria", objeto.RefCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("@Codigo", objeto.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);
                cmd.Parameters.AddWithValue("@PrecioCompra", objeto.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", objeto.PrecioVenta);
                cmd.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
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
                    respuesta = "Error(rpProducto): No se pudo procesar";
                }


            }
            return respuesta;
        }

        public async Task<Producto> Obtener(string codigo) //Metodo para obtener en detalle de venta
        {

            Producto objeto = new Producto();

            using (var con = _conexion.ObtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_obtenerProducto", con);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        objeto = new Producto
                        {
                            IdProducto = Convert.ToInt32(dr["IdProducto"]),
                            RefCategoria = new Categoria
                            {
                                Nombre = dr["NombreCategoria"].ToString(),
                                RefMedida = new Medida
                                {
                                    Equivalente = dr["Equivalente"].ToString(),
                                    Valor = Convert.ToInt32(dr["Valor"])
                                }
                            },
                            Codigo = dr["Codigo"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
                            PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                            Cantidad = Convert.ToInt32(dr["Cantidad"])
                        };
                    }
                }
            }
            return objeto;
        }
    }
}
