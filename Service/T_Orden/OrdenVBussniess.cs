using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Orden;
using IRepository.T_Cliente;
using IRepository.T_Empleado;
using Repositori.T_Cliente;
using Repositori.T_Empleado;
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
    public class OrdenVBussniess : IOrdenVBussniess
    {
        private readonly IOrdenBussniess _ordenBussniess;
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmpleadoRepository _empleadoRepository;
        private readonly IMapper _mapper;

        public OrdenVBussniess (IMapper mapper)
        {
            _mapper = mapper;
            _clienteRepository = new ClienteRepository();
            _empleadoRepository = new EmpleadoRepository();
            _ordenBussniess = new OrdenBussniess(mapper);
        }
        public ResponseOrden Create(RequestVOrden entity)
        {
            Cliente cliente = new Cliente();
            cliente = _clienteRepository.buscarCliente(entity.NombreCliente);
            if (cliente == null) 
            {
                throw new NotImplementedException("No se encontro al cliente ");
            }
            cliente.IdCliente = entity.IdCliente;
            Empleado empleado = new Empleado();
            empleado = _empleadoRepository.BuscarEmpleado(entity.NombreEmpleado);
            if (empleado == null)
            {
                throw new NotImplementedException("No se encontro al empleado ");
            }
            empleado.IdEmpleado = entity.IdEmpleado;
            RequestOrden request = _mapper.Map<RequestOrden>(empleado);
            request = _mapper.Map<RequestOrden>(cliente);

            ResponseVOrden orden = _ordenBussniess.Create(request);
            ResponseOrden responseVOrden = _mapper.Map<ResponseOrden>(orden);
            responseVOrden.message = "Se creo el Orden";
            responseVOrden.ordens.Add(orden);
            return responseVOrden;
        }

        public List<ResponseOrden> CreateMultiple(List<RequestVOrden> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVOrden> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseOrden> GetAll()
        {
            throw new NotImplementedException();
        }

        public ReponseFilterGeneric<ResponseOrden> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseOrden GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseOrden Update(RequestVOrden entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseOrden> UpdateMultiple(List<RequestVOrden> lista)
        {
            throw new NotImplementedException();
        }
    }
}
