using DBModelZapateria;
using IRepository.T_Producto;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Producto
{
    public class ProductoRepository : CrudRepository<Producto>, IProductoRepository
    {
        public Producto BsucarProducto(string nombreProducto)
        {
            Producto? producto = db.Productos.Where(x=>x.NombreProd==nombreProducto).FirstOrDefault();
            return producto;
            
           
        }

        public ReponseFilterGeneric<Producto> GetByFilter(RequestFilterGeneric request)
        {
            var query = dbset.Where(x => x.IdProducto == x.IdProducto);
            request.Filtros.ForEach(
                j =>
                {
                    if (!string.IsNullOrEmpty(j.Value))
                    {
                        switch (j.Name)
                        {
                            case "IdProducto":
                                query = query.Where(x => x.IdProducto == short.Parse(j.Value));
                                break;
                            case "CodigoProd":
                                query = query.Where(x => x.CodigoProd.ToLower().Contains(j.Value.ToLower()));
                                break;
                            case "NombreProd":
                                query = query.Where(x => x.NombreProd.ToLower().Contains(j.Value.ToLower()));
                                break;
                       

                        }
                    }
                }
                );
            ReponseFilterGeneric<Producto> res = new ReponseFilterGeneric<Producto>();
            res.TotalRegistros = query.Count();
            res.Lista = query

                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .ToList();

            return res;
        }
    }
}
