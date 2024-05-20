using AutoMapper;
using DBModelZapateria;
using IBussniess.T_SalidaMaterial;
using IRepository.T_SalidaMaterial;
using Repositori.T_SalidaMaterial;
using RequestRespons.Request.T_SalidaMaterial;
using RequestRespons.Response.T_SalidaMaterial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_SalidaMaterial
{
    public class SalidaMaterialBussniess : ISalidaMaterialBussniess
    {
        #region Inyeccion de Dependencias

        private readonly ISalidaMaterialRepository _SalidaMaterialRepository;
        private readonly IMapper _mapper;

        public SalidaMaterialBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _SalidaMaterialRepository = new SalidaMaterialRepository();

        }

        public ResponseVSalidaMaterial Create(RequestSalidaMaterial entity)
        {
            SalidaMaterial SalidaMaterial = _mapper.Map<SalidaMaterial>(entity);
            SalidaMaterial = _SalidaMaterialRepository.Create(SalidaMaterial);
            ResponseVSalidaMaterial ResponseVSalidaMaterial = _mapper.Map<ResponseVSalidaMaterial>(SalidaMaterial);
            return ResponseVSalidaMaterial;
        }

        public List<ResponseVSalidaMaterial> CreateMultiple(List<RequestSalidaMaterial> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _SalidaMaterialRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestSalidaMaterial> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVSalidaMaterial> GetAll()
        {
            List<SalidaMaterial> SalidaMaterial = _SalidaMaterialRepository.GetAll();
            List<ResponseVSalidaMaterial> ResponseVSalidaMaterial = _mapper.Map<List<ResponseVSalidaMaterial>>(SalidaMaterial);
            return ResponseVSalidaMaterial;

        }

        public ResponseVSalidaMaterial GetById(object id)
        {
            SalidaMaterial SalidaMaterial = _SalidaMaterialRepository.GetByID(id);
            ResponseVSalidaMaterial ResponseVSalidaMaterial = _mapper.Map<ResponseVSalidaMaterial>(SalidaMaterial);
            return ResponseVSalidaMaterial;

        }

        public ResponseVSalidaMaterial Update(RequestSalidaMaterial entity)
        {
            SalidaMaterial SalidaMaterial = _mapper.Map<SalidaMaterial>(entity);
            SalidaMaterial = _SalidaMaterialRepository.Update(SalidaMaterial);
            ResponseVSalidaMaterial ResponseVSalidaMaterial = _mapper.Map<ResponseVSalidaMaterial>(SalidaMaterial);
            return ResponseVSalidaMaterial;
        }

        public List<ResponseVSalidaMaterial> UpdateMultiple(List<RequestSalidaMaterial> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
