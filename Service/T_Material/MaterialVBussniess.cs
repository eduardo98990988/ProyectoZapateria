using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Material;
using IRepository.T_Unidad;
using Repositori.T_Unidad;
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
    public class MaterialVBussniess : IMaterialVBussniess
    {
        private readonly IMaterialBussniess _materialBussniess;
        private readonly IUnidadRespository _unidadRespository;
        private readonly IMapper _mapper;
        public MaterialVBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _unidadRespository = new UnidadRepository();
            _materialBussniess = new MaterialBussniess(mapper);
        }
        public ResponseMaterial Create(RequestVMaterial entity)
        {
            Unidad unidad = new Unidad();
            unidad = _unidadRespository.BuscarUnidad(entity.NombreUnidad);
            if (unidad == null) throw new NotImplementedException("No se encontro la unidad llamada"); 
            RequestMaterial material = _mapper.Map<RequestMaterial>(entity);
            material.IdUnidad = unidad.IdUnidad;
            RequestMaterial requestMaterial = _mapper.Map<RequestMaterial>(material);
            ResponseVMaterial responseVMaterial = _materialBussniess.Create(requestMaterial);
            if(responseVMaterial == null) throw new NotImplementedException("No se pudo crear el Material"); 
            ResponseMaterial responseMaterial = _mapper.Map<ResponseMaterial>(responseVMaterial);
            responseMaterial.message = "Se creo el Material";
            responseMaterial.materials.Add(responseVMaterial);
            return responseMaterial;
           
        }

        public List<ResponseMaterial> CreateMultiple(List<RequestVMaterial> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVMaterial> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseMaterial> GetAll()
        {
            throw new NotImplementedException();
        }

        public ReponseFilterGeneric<ResponseMaterial> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseMaterial GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseMaterial Update(RequestVMaterial entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseMaterial> UpdateMultiple(List<RequestVMaterial> lista)
        {
            throw new NotImplementedException();
        }
    }
}
