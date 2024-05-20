using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Credito;
using IRepository.T_Credito;
using Repositori.T_Credito;
using RequestRespons.Request.T_Credito;
using RequestRespons.Response.T_Credito;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Credito
{
    public class CreditoBussniess : ICreditoBussniess
    {
        #region Inyeccion de Dependencias

        private readonly ICreditoRepository _CreditoRepository;
        private readonly IMapper _mapper;

        public CreditoBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _CreditoRepository = new CreditoRepository();

        }

        public ResponseCredito Create(RequestCredito entity)
        {
            Credito Credito = _mapper.Map<Credito>(entity);
            Credito = _CreditoRepository.Create(Credito);
            ResponseCredito responseCredito = _mapper.Map<ResponseCredito>(Credito);
            return responseCredito;
        }

        public List<ResponseCredito> CreateMultiple(List<RequestCredito> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _CreditoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestCredito> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseCredito> GetAll()
        {
            List<Credito> Credito = _CreditoRepository.GetAll();
            List<ResponseCredito> responseCredito = _mapper.Map<List<ResponseCredito>>(Credito);
            return responseCredito;

        }

        public ResponseCredito GetById(object id)
        {
            Credito Credito = _CreditoRepository.GetByID(id);
            ResponseCredito responseCredito = _mapper.Map<ResponseCredito>(Credito);
            return responseCredito;

        }

        public ResponseCredito Update(RequestCredito entity)
        {
            Credito Credito = _mapper.Map<Credito>(entity);
            Credito = _CreditoRepository.Update(Credito);
            ResponseCredito responseCredito = _mapper.Map<ResponseCredito>(Credito);
            return responseCredito;
        }

        public List<ResponseCredito> UpdateMultiple(List<RequestCredito> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
