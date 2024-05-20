using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Unidad;
using IRepository.T_Unidad;
using Repositori.T_Unidad;
using RequestResponse.Request.T_Unidad;
using RequestResponse.Response.T_Unidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Unidad
{
    public class UnidadBussniess : iUnidadBussniess
    {
        #region Inyeccion de Dependencias

        private readonly IUnidadRespository _UnidadRepository;
        private readonly IMapper _mapper;

        public UnidadBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _UnidadRepository = new UnidadRepository();

        }

        public ResponseUnidad Create(RequestUnidad entity)
        {
            Unidad Unidad = _mapper.Map<Unidad>(entity);
            Unidad = _UnidadRepository.Create(Unidad);
            ResponseUnidad responseUnidad = _mapper.Map<ResponseUnidad>(Unidad);
            return responseUnidad;
        }

        public List<ResponseUnidad> CreateMultiple(List<RequestUnidad> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _UnidadRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestUnidad> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseUnidad> GetAll()
        {
            List<Unidad> Unidad = _UnidadRepository.GetAll();
            List<ResponseUnidad> responseUnidad = _mapper.Map<List<ResponseUnidad>>(Unidad);
            return responseUnidad;

        }

        public ResponseUnidad GetById(object id)
        {
            Unidad Unidad = _UnidadRepository.GetByID(id);
            ResponseUnidad responseUnidad = _mapper.Map<ResponseUnidad>(Unidad);
            return responseUnidad;

        }

        public ResponseUnidad Update(RequestUnidad entity)
        {
            Unidad Unidad = _mapper.Map<Unidad>(entity);
            Unidad = _UnidadRepository.Update(Unidad);
            ResponseUnidad responseUnidad = _mapper.Map<ResponseUnidad>(Unidad);
            return responseUnidad;
        }

        public List<ResponseUnidad> UpdateMultiple(List<RequestUnidad> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
