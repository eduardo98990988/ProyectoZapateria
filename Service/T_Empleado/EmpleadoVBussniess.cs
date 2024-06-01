using AutoMapper;
using Bussniess.T_Persona;
using IBussniess.T_Empleado;
using IBussniess.T_Persona;
using IRepository.T_Persona;
using RequestRespons.Request.T_Empleado;
using RequestResponse.Request;
using RequestResponse.Request.T_Empleado;
using RequestResponse.Request.T_Persona;
using RequestResponse.Response;
using RequestResponse.Response.T_Empleado;
using RequestResponse.Response.T_Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Empleado
{
    public class EmpleadoVBussniess : IEmpleadoVBussniess
    {
        private readonly IPersonaBussniess _personaBussniess;
        private readonly IEmpleadoBussniess _empleadoBussniess;
        private readonly IPersonaRepository _personaRepository;
        private readonly IMapper _mapper;

        public EmpleadoVBussniess (IMapper mapper)
        {
            _mapper = mapper;
            _personaBussniess = new PersonaBussniess(mapper);
            _empleadoBussniess = new EmpleadoBussniess(mapper);


        }
        public ResponseEmpleado Create(RequestVEmpleado entity)
        {
            RequestPersona requestPersona = _mapper.Map<RequestPersona>(entity);
            ResponsePersona responsePersona  = _personaBussniess.Create(requestPersona);
            if(responsePersona == null) throw new NotImplementedException("No se pudo crear tu perfil");
            RequestEmpleado requestVEmpleado = new RequestEmpleado();
            requestVEmpleado.IdPersona = responsePersona.IdPersona;
            RequestEmpleado requestEmpleado = _mapper.Map<RequestEmpleado>(requestVEmpleado);
            requestEmpleado.ImagenEmpleado = "jjjjjj";
            ResponseVEmpleado responseEmpleado = _empleadoBussniess.Create(requestEmpleado);

            if (responseEmpleado == null) throw new NotImplementedException("No se pudo crear tu perfil de Empleado");
            ResponseEmpleado responseEmpleado1 = _mapper.Map<ResponseEmpleado>(responseEmpleado);
            responseEmpleado1.message = "Se creo el Empleado";
            responseEmpleado1.empleado.Add(responseEmpleado);
            return responseEmpleado1;

            
        }

        public List<ResponseEmpleado> CreateMultiple(List<RequestVEmpleado> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVEmpleado> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseEmpleado> GetAll()
        {
            throw new NotImplementedException();
        }

        public ReponseFilterGeneric<ResponseEmpleado> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseEmpleado GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseEmpleado Update(RequestVEmpleado entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseEmpleado> UpdateMultiple(List<RequestVEmpleado> lista)
        {
            throw new NotImplementedException();
        }
    }
}
