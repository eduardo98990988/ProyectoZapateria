using DBModelZapateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.T_Material
{
    public interface IMaterialRepository : ICrudRepository<Material>
    {
        public Material buscarMaterial(string nombreMaterial);
    }
}
