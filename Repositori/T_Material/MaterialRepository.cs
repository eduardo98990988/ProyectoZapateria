using DBModelZapateria;
using IRepository.T_Material;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Material
{
    public class MaterialRepository : CrudRepository<Material>, IMaterialRepository
    {
        public Material buscarMaterial(string nombreMaterial)
        {
           Material? material = db.Materials.Where(x=>x.NombreMaterial== nombreMaterial).FirstOrDefault();
            return material;
        }

        public ReponseFilterGeneric<Material> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
