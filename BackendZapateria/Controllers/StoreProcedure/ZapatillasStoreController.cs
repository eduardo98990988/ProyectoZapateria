using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RequestRespons.Response.T_Producto;

namespace BackendZapateria.Controllers.StoreProcedure
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZapatillasStoreController : ControllerBase
    {
        private readonly string con;
        public ZapatillasStoreController(IConfiguration configuration)
        {
            con = configuration.GetConnectionString("conexion");
        }
        [HttpGet]
        public IEnumerable<ResponseVerModelos> Get()
        {
            List<ResponseVerModelos> materiales = new();

            using (SqlConnection connection = new(con))
            {
                connection.Open();
                using (SqlCommand cmd = new("MirarZapatos", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ResponseVerModelos p = new ResponseVerModelos
                            {
                                //Id = Convert.ToInt32(reader["Id"]),
                                //Nombre = reader["Nombre"].ToString(),
                                //Precio = Convert.ToDecimal(reader["Precio"]),
                                //Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                //Descripcion = reader["Descripcion"].ToString(),
                                //FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"])
                                IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                NombreProd = reader["NombreProd"].ToString(),
                                PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                                NombreModelo = reader["NombreModelo"].ToString(),
                                Talla = reader["Talla"].ToString(),
                                Color = reader["Color"].ToString(),
                            };

                            materiales.Add(p);
                        }
                    }
                }
            }
            return materiales;
        }
    }
}
