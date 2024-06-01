using DBModelZapateria;
using IRepository.T_Rol;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Rol
{
    public class RolRepository : CrudRepository<Rol>, IRolRepository
    {
        public ReponseFilterGeneric<Rol> GetByFilter(RequestFilterGeneric request)
        {
            var query = dbset.Where(x => x.Irol == x.Irol);
            request.Filtros.ForEach(
                j =>
                {
                    if (!string.IsNullOrEmpty(j.Value))
                    {
                        switch (j.Name)
                        {
                            case "Irol":
                                query = query.Where(x => x.Irol == short.Parse(j.Value));
                                break;
                            case "NombreRol":
                                query = query.Where(x => x.NombreRol.ToLower().Contains(j.Value.ToLower()));
                                break;

                        }
                    }
                }
                );
            ReponseFilterGeneric<Rol> res = new ReponseFilterGeneric<Rol>();
            res.TotalRegistros = query.Count();
            res.Lista = query

                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .ToList();

            return res;
        }
    }
}
