using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Modelo;
using IRepository.T_Modelo;
using Repositori.T_Modelo;
using RequestRespons.Request.T_Modelo;
using RequestRespons.Response.T_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Modelo
{
    public class ModeloBussniess : IModeloBussniess
    {
        #region Inyeccion de Dependencias

        private readonly IModeloRepository _ModeloRepository;
        private readonly IMapper _mapper;

        public ModeloBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _ModeloRepository = new ModeloRepository();

        }

        public ResponseModelo Create(RequestModelo entity)
        {
            Modelo Modelo = _mapper.Map<Modelo>(entity);
            Modelo = _ModeloRepository.Create(Modelo);
            ResponseModelo responseModelo = _mapper.Map<ResponseModelo>(Modelo);
            return responseModelo;
        }

        public List<ResponseModelo> CreateMultiple(List<RequestModelo> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _ModeloRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestModelo> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseModelo> GetAll()
        {
            List<Modelo> Modelo = _ModeloRepository.GetAll();
            List<ResponseModelo> responseModelo = _mapper.Map<List<ResponseModelo>>(Modelo);
            return responseModelo;

        }

        public ResponseModelo GetById(object id)
        {
            Modelo Modelo = _ModeloRepository.GetByID(id);
            ResponseModelo responseModelo = _mapper.Map<ResponseModelo>(Modelo);
            return responseModelo;

        }

        public ResponseModelo Update(RequestModelo entity)
        {
            Modelo Modelo = _mapper.Map<Modelo>(entity);
            Modelo = _ModeloRepository.Update(Modelo);
            ResponseModelo responseModelo = _mapper.Map<ResponseModelo>(Modelo);
            return responseModelo;
        }

        public List<ResponseModelo> UpdateMultiple(List<RequestModelo> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
