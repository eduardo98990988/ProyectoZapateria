using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Material;
using IRepository.T_Material;
using Repositori.T_Material;
using RequestRespons.Request.T_Material;
using RequestRespons.Response.T_Material;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Material
{
    public class MaterialBussniess : IMaterialBussniess
    {
        #region Inyeccion de Dependencias

        private readonly IMaterialRepository _MaterialRepository;
        private readonly IMapper _mapper;

        public MaterialBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _MaterialRepository = new MaterialRepository();

        }

        public ResponseVMaterial Create(RequestMaterial entity)
        {
            Material Material = _mapper.Map<Material>(entity);
            Material = _MaterialRepository.Create(Material);
            ResponseVMaterial ResponseVMaterial = _mapper.Map<ResponseVMaterial>(Material);
            return ResponseVMaterial;
        }

        public List<ResponseVMaterial> CreateMultiple(List<RequestMaterial> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _MaterialRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestMaterial> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVMaterial> GetAll()
        {
            List<Material> Material = _MaterialRepository.GetAll();
            List<ResponseVMaterial> ResponseVMaterial = _mapper.Map<List<ResponseVMaterial>>(Material);
            return ResponseVMaterial;

        }

        public ReponseFilterGeneric<ResponseVMaterial> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseVMaterial GetById(object id)
        {
            Material Material = _MaterialRepository.GetByID(id);
            ResponseVMaterial ResponseVMaterial = _mapper.Map<ResponseVMaterial>(Material);
            return ResponseVMaterial;

        }

        public ResponseVMaterial Update(RequestMaterial entity)
        {
            Material Material = _mapper.Map<Material>(entity);
            Material = _MaterialRepository.Update(Material);
            ResponseVMaterial ResponseVMaterial = _mapper.Map<ResponseVMaterial>(Material);
            return ResponseVMaterial;
        }

        public List<ResponseVMaterial> UpdateMultiple(List<RequestMaterial> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
