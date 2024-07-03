using AutoMapper;
using Bussniess.T_Persona;
using DBModelZapateria;
using IBussniess.T_Cliente;
using IBussniess.T_Persona;
using IRepository.T_Cliente;
using Repositori.T_Cliente;
using RequestRespons.Request.T_Cliente;
using RequestRespons.Response.T_Cliente;
using RequestResponse.Request;
using RequestResponse.Request.T_Persona;
using RequestResponse.Response;
using RequestResponse.Response.T_Persona;
using RequestResponse.Response.T_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Cliente
{
    public class ClienteVBussniess : IClienteVBussniess
    {
        #region Declaracion de Variables

        private readonly IPersonaBussniess _personaBussniess;
        private readonly IClienteVRepository _clienteVRepository;
        private readonly IClienteBussniess _clienteBussniess;
        private readonly IMapper _mapper;

        public ClienteVBussniess (IMapper mapper)
        {
            _mapper = mapper;
            _personaBussniess = new PersonaBussniess(mapper);
            _clienteBussniess = new ClienteBussniess(mapper);

            _clienteVRepository = new ClienteVRepository();
        }
        #endregion Fin Declaracion de Variables
        #region Crud
        public ResponseCliente Create(RequestVCliente entity)
        {
            ResponseCliente respClietne = new ResponseCliente();
            RequestPersona requPerosna = _mapper.Map<RequestPersona>(entity);
            ResponsePersona responsPerosna = _personaBussniess.Create(requPerosna);

            RequestCliente requCliente = _mapper.Map<RequestCliente>(responsPerosna);
            requCliente.Estado = true;
            responsPerosna.IdPersona = requCliente.IdPersona;
            requCliente.IdPersona = responsPerosna.IdPersona;
            requCliente.FechaNacimiento = entity.FechaNacimiento;
            requCliente.NombreCliente = entity.NombrePersona;
            ResponseVCliente responseVCliente = _clienteBussniess.Create(requCliente);

            ResponseCliente responseCliente = _mapper.Map<ResponseCliente>(responseVCliente);
            responseCliente.message = "Se creo Correctamente";
            responseCliente.clientes.Add(responseVCliente);
            return responseCliente;
        }

        public List<ResponseCliente> CreateMultiple(List<RequestVCliente> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVCliente> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseCliente> GetAll()
        {
            List<ResponseCliente> response = new List<ResponseCliente>();
            ResponseCliente cliente = new ResponseCliente();

            cliente.clientes = new List<ResponseVCliente>();

            List<VistCliente> vistCliente = _clienteVRepository.GetAll();
            cliente.clientes = _mapper.Map<List<ResponseVCliente>>(vistCliente);
            cliente.message = "Lista de los Clientes";
            response.Add(cliente);
            return response;
        }

        public ReponseFilterGeneric<ResponseCliente> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseCliente GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseCliente Update(RequestVCliente entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseCliente> UpdateMultiple(List<RequestVCliente> lista)
        {
            throw new NotImplementedException();
        }
        #endregion Crud



    }
}
