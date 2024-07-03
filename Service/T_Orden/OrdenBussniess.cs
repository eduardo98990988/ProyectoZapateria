using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Orden;
using IRepository.T_Orden;
using Repositori.T_Orden;
using RequestRespons.Request.T_Orden;
using RequestRespons.Response.T_Orden;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Orden
{
    public class OrdenBussniess : IOrdenBussniess
    {
        #region Inyeccion de Dependencias

        private readonly IOrdenRepository _OrdenRepository;
        private readonly IMapper _mapper;

        public OrdenBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _OrdenRepository = new OrdenRepository();

        }

        public ResponseVOrden Create(RequestOrden entity)
        {
            Orden Orden = _mapper.Map<Orden>(entity);
            Orden = _OrdenRepository.Create(Orden);
            ResponseVOrden ResponseVOrden = _mapper.Map<ResponseVOrden>(Orden);
            return ResponseVOrden;
        }

        public List<ResponseVOrden> CreateMultiple(List<RequestOrden> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _OrdenRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestOrden> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVOrden> GetAll()
        {
            List<Orden> Orden = _OrdenRepository.GetAll();
            List<ResponseVOrden> ResponseVOrden = _mapper.Map<List<ResponseVOrden>>(Orden);
            return ResponseVOrden;

        }

        public List<VistOrden> GetAllVist()
        {
            List<VistOrden> vistEmpleado = _OrdenRepository.GetAllVist();
            return vistEmpleado;
        }

        public ReponseFilterGeneric<ResponseVOrden> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseVOrden GetById(object id)
        {
            Orden Orden = _OrdenRepository.GetByID(id);
            ResponseVOrden ResponseVOrden = _mapper.Map<ResponseVOrden>(Orden);
            return ResponseVOrden;

        }

        public ResponseVOrden Update(RequestOrden entity)
        {
            Orden Orden = _mapper.Map<Orden>(entity);
            Orden = _OrdenRepository.Update(Orden);
            ResponseVOrden ResponseVOrden = _mapper.Map<ResponseVOrden>(Orden);
            return ResponseVOrden;
        }

        public List<ResponseVOrden> UpdateMultiple(List<RequestOrden> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
