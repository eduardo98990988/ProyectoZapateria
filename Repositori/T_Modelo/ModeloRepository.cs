using DBModelZapateria;
using IRepository.T_Modelo;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Modelo
{
    public class ModeloRepository : CrudRepository<Modelo>, IModeloRepository
    {
        public ReponseFilterGeneric<Modelo> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
