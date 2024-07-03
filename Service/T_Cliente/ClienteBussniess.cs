using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Cliente;
using IRepository.T_Cliente;
using IRepository.T_Comprobante;
using Repositori.T_Cliente;
using Repositori.T_Comprobante;
using RequestRespons.Request.T_Cliente;
using RequestRespons.Response.T_Cliente;
using RequestResponse.Request;
using RequestResponse.Request.T_Comprobante;
using RequestResponse.Response;
using RequestResponse.Response.T_Comprobante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Cliente
{
    public class ClienteBussniess : IClienteBussniess
    {
        #region Inyeccion de Dependencias
        private readonly IClienteRepository _ClienteRepository;
        private readonly IMapper _mapper;

        public ClienteBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _ClienteRepository = new ClienteRepository();

        }

        #endregion Fin Inyeccion de Dependencias
        public ResponseVCliente Create(RequestCliente entity)
        {
            Cliente Cliente = _mapper.Map<Cliente>(entity);
            Cliente = _ClienteRepository.Create(Cliente);
            ResponseVCliente ResponseVCliente = _mapper.Map<ResponseVCliente>(Cliente);
            return ResponseVCliente;

        }

        public List<ResponseVCliente> CreateMultiple(List<RequestCliente> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestCliente> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVCliente> GetAll()
        {
            List<Cliente> Cliente = _ClienteRepository.GetAll();
            List<ResponseVCliente> ResponseVCliente = _mapper.Map<List<ResponseVCliente>>(Cliente);
            return ResponseVCliente;
        }

        public List<VistCliente> GetAllVist()
        {
            List<VistCliente> vistCliente = _ClienteRepository.GetAllVist();
            return vistCliente;
        }

        public ReponseFilterGeneric<ResponseVCliente> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseVCliente GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseVCliente Update(RequestCliente entity)
        {
            Cliente Cliente = _mapper.Map<Cliente>(entity);
            Cliente = _ClienteRepository.Update(Cliente);
            ResponseVCliente ResponseVCliente = _mapper.Map<ResponseVCliente>(Cliente);
            return ResponseVCliente;
        }

        public List<ResponseVCliente> UpdateMultiple(List<RequestCliente> lista)
        {
            throw new NotImplementedException();
        }
    }
}
