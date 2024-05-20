using AutoMapper;
using Bussniess.T_Persona;
using IBussniess.T_Cliente;
using IBussniess.T_Persona;
using RequestRespons.Request.T_Cliente;
using RequestRespons.Response.T_Cliente;
using RequestResponse.Request.T_Persona;
using RequestResponse.Response.T_Persona;
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
        private readonly IClienteBussniess _clienteBussniess;
        private readonly IMapper _mapper;

        public ClienteVBussniess (IMapper mapper)
        {
            _mapper = mapper;
            _personaBussniess = new PersonaBussniess(mapper);
            _clienteBussniess = new ClienteBussniess(mapper);
        }

        public ResponseCliente Create(RequestVCliente entity)
        {
            ResponseCliente respClietne = new ResponseCliente();
            RequestPersona responsPerosna = _mapper.Map<RequestPersona>(entity);
            ResponsePersona requestPersona = _personaBussniess.Create(responsPerosna);

            responsPerosna.IdPersona = entity.IdPersona;
            RequestCliente requCliente = _mapper.Map<RequestCliente>(responsPerosna);
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

        #endregion Fin Declaracion de Variables

    }
}
