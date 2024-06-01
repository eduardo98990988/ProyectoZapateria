using AutoMapper;
using Bussniess.T_DetalleCredito;
using DBModelZapateria;
using IBussniess.T_Credito;
using IBussniess.T_DetalleCredito;
using IRepository.T_Cliente;
using IRepository.T_Orden;
using Repositori.T_Cliente;
using Repositori.T_Orden;
using RequestRespons.Request.T_Credito;
using RequestRespons.Request.T_DetalleCredito;
using RequestRespons.Request.T_Orden;
using RequestRespons.Response.T_Cliente;
using RequestRespons.Response.T_Credito;
using RequestRespons.Response.T_DetalleCredito;
using RequestRespons.Response.T_Orden;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Credito
{
    public class CreditoVBussniess : ICreditoVBussniess
    {
        #region Declaracion de Variables 
        private readonly ICreditoBussniess _creditoBussniess;
        private readonly IClienteRepository _clienteRepository;
        private readonly IOrdenRepository _ordenRepository;
        private readonly IDetalleCreditoBussniess _detalleCreditoBussniess;

        private readonly IMapper _mapper;

        public CreditoVBussniess (IMapper mapper)
        {
            _mapper = mapper;
            _creditoBussniess = new CreditoBussniess(mapper);
            _detalleCreditoBussniess = new DetalleCreditoBussniess(mapper);
            _clienteRepository = new ClienteRepository();
            _ordenRepository = new OrdenRepository();

        }

        #endregion Fin Declaracion de Variables 
        #region Crud
        public ResponseCredito Create(RequestVCredito entity)
        {
            RequestCredito requestCredito = new RequestCredito();
            Cliente responseCliente = new Cliente();
            responseCliente = _clienteRepository.buscarCliente(entity.NombreCliente);

            responseCliente.IdCliente = entity.IdCliente;
            RequestCredito requestCRedito = _mapper.Map<RequestCredito>(responseCliente);

            ResponseCredito responseC = _creditoBussniess.Create(requestCRedito);

            ResponseVDetalleCredito responseVDetalleCredito = _mapper.Map<ResponseVDetalleCredito>(responseC);
            responseVDetalleCredito.NombrePersona = entity.NombreCliente;
            Orden responseVorden = _ordenRepository.buscarCodigoOrden(entity.CodigoOrden);
            RequestDetalleCredito requestOrden = new RequestDetalleCredito();
            requestOrden.IdOrden = responseVorden.IdOrden;

            responseVDetalleCredito = _detalleCreditoBussniess.Create(requestOrden);

            ResponseCredito responseCredito = _mapper.Map<ResponseCredito>(responseVDetalleCredito);
            return responseCredito;

        }

        public List<ResponseCredito> CreateMultiple(List<RequestVCredito> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVCredito> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseCredito> GetAll()
        {
            throw new NotImplementedException();
        }

        public ReponseFilterGeneric<ResponseCredito> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseCredito GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseCredito Update(RequestVCredito entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseCredito> UpdateMultiple(List<RequestVCredito> lista)
        {
            throw new NotImplementedException();
        }
        #endregion Crud
    }
}
