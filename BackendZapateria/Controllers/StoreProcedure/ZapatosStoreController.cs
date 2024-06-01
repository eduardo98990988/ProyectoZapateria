using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RequestRespons.Response.T_Material;

namespace BackendZapateria.Controllers.StoreProcedure
{
    public class ZapatosStoreController
    {
        private readonly string con;
        public MaterialStoreController(IConfiguration configuration)
        {
            con = configuration.GetConnectionString("conexion");
        }
        [HttpGet]
        public IEnumerable<ResponseProcedureMaterial> Get()
        {
            List<ResponseProcedureMaterial> materiales = new();

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
                            ResponseProcedureMaterial p = new ResponseProcedureMaterial
                            {
                                //Id = Convert.ToInt32(reader["Id"]),
                                //Nombre = reader["Nombre"].ToString(),
                                //Precio = Convert.ToDecimal(reader["Precio"]),
                                //Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                //Descripcion = reader["Descripcion"].ToString(),
                                //FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"])
                                IdMaterial = Convert.ToInt32(reader["IdMaterial"]),
                                NombreMaterial = reader["NombreProd"].ToString(),
                                Estado = reader["NombreProd"].ToString(),
                                Stock = Convert.ToInt32(reader["IdMaterial"])
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
