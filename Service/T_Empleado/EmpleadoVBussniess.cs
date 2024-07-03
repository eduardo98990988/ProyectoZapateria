using AutoMapper;
using Bussniess.T_Persona;
using Bussniess.T_Usuario;
using DBModelZapateria;
using IBussniess.T_Empleado;
using IBussniess.T_Persona;
using IBussniess.T_Usuario;
using IRepository.T_Empleado;
using IRepository.T_Persona;
using IRepository.T_Usuario;
using Repositori.T_Empleado;
using Repositori.T_Usuario;
using RequestRespons.Request.T_Empleado;
using RequestResponse.Request;
using RequestResponse.Request.T_Empleado;
using RequestResponse.Request.T_Persona;
using RequestResponse.Request.T_Usuario;
using RequestResponse.Response;
using RequestResponse.Response.T_Empleado;
using RequestResponse.Response.T_Persona;
using RequestResponse.Response.T_Usuario;
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
        private readonly IEmpleadoRepository _empleadoRepository;
        private readonly IEmpleadoVRespository _empleadoVRepository;
        private readonly IUsuarioRepository _UsuarioRepository;
        private readonly IUsuarioBussniess _UsuarioBussniess;
        private readonly IPersonaRepository _personaRepository;
        private readonly IMapper _mapper;

        public EmpleadoVBussniess (IMapper mapper)
        {
            _mapper = mapper;
            _personaBussniess = new PersonaBussniess(mapper);
            _empleadoRepository = new EmpleadoRepository();
            _UsuarioBussniess = new UsuarioBussniess(mapper);
            _empleadoVRepository = new EmpleadoVRespository();
            _UsuarioRepository = new UsuarioRepository();
            _empleadoBussniess = new EmpleadoBussniess(mapper);


        }
        public ResponseEmpleado Create(RequestVEmpleado entity)
        {
            RequestPersona requestPersona = _mapper.Map<RequestPersona>(entity);
            ResponsePersona responsePersona  = _personaBussniess.Create(requestPersona);
            if(responsePersona == null) throw new NotImplementedException("No se pudo crear tu perfil");
            RequestEmpleado requestVEmpleado = new RequestEmpleado();
            requestVEmpleado.IdPersona = responsePersona.IdPersona;
            requestVEmpleado.ApellidoEmp = entity.ApellidoEmp;
            RequestEmpleado requestEmpleado = _mapper.Map<RequestEmpleado>(requestVEmpleado);
            requestEmpleado.ImagenEmpleado = "jjjjjj";
            requestEmpleado.Salario = entity.Salario;
            ResponseVEmpleado responseEmpleado = _empleadoBussniess.Create(requestEmpleado);

            if (responseEmpleado == null) throw new NotImplementedException("No se pudo crear tu perfil de Empleado");
            RequestUsuario requestUsuario = _mapper.Map<RequestUsuario>(entity);
            requestUsuario.Estado = true;
            //requestUsuario.Email = entity.Email;
            requestUsuario.Irol = 1002;
            requestUsuario.IdPersona = responsePersona.IdPersona;
            ResponseVUsuario responseVUsuario = _UsuarioBussniess.Create(requestUsuario);
            if (responseVUsuario == null) throw new NotImplementedException("No se pudo crear su perfil para Usuario");
            ResponseEmpleado responseEmpleado1 = _mapper.Map<ResponseEmpleado>(responseVUsuario);
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

            List<ResponseEmpleado> response = new List<ResponseEmpleado>();
            ResponseEmpleado empleado = new();
            empleado.empleado = new List<ResponseVEmpleado>();

            List<VistEmpleado> vistEmpleado = _empleadoVRepository.GetAll();
            empleado.empleado = _mapper.Map<List<ResponseVEmpleado>>(vistEmpleado);
            empleado.message = "Lista de Registros de los Empleados";
            response.Add(empleado);
            return response;

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
