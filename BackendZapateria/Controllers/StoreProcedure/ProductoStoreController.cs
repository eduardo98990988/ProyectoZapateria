using DBModelZapateria;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RequestRespons.Response.T_Producto;
using System.Drawing;
using System.Runtime.InteropServices;

namespace BackendZapateria.Controllers.StoreProcedure
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoStoreController : ControllerBase
    {
        //private readonly _dbZapateriaModelContext db;
        //public ProductoStoreController ( _dbZapateriaModelContext context)
        //{
        //    db = context;
        //}
        //[HttpGet]
        //public async Task<IActionResult>Get()
        //{
        //    var result = await db.Productos.FromSqlRaw("EXEC MirarProductosAcabados").ToListAsync();
        //    return Ok(result);
        //}
        private readonly string con;
        public ProductoStoreController(IConfiguration configuration)
        {
            con = configuration.GetConnectionString("conexion");
        }
        [HttpGet]
        public IEnumerable<ResponseProcedureProducto> Get()
        {
            List<ResponseProcedureProducto> productos = new();

            using (SqlConnection connection = new(con))
            {
                connection.Open();
                using (SqlCommand cmd = new("MirarProductosAcabados", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ResponseProcedureProducto p = new ResponseProcedureProducto
                            {
                                //Id = Convert.ToInt32(reader["Id"]),
                                //Nombre = reader["Nombre"].ToString(),
                                //Precio = Convert.ToDecimal(reader["Precio"]),
                                //Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                //Descripcion = reader["Descripcion"].ToString(),
                                //FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"])

                                NombreProd = reader["NombreProd"].ToString(),
                                PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),

                                Stock = Convert.ToInt32(reader["Stock"]),
                                NombreModelo = reader["NombreModelo"].ToString(),
                                Color = reader["Color"].ToString(),
                                Material = reader["Material"].ToString(),
                            };

                            productos.Add(p);
                        }
                    }
                }
            }
            return productos;
        }



    }
}
