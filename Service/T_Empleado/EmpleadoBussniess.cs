using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Empleado;
using IRepository.T_Empleado;
using Repositori.T_Empleado;
using RequestResponse.Request.T_Empleado;
using RequestResponse.Response.T_Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Empleado
{
    public class EmpleadoBussniess : IEmpleadoBussniess 
    {
        #region Inyeccion de Dependencias
        private readonly IEmpleadoRepository _EmpleadoRepository;
        private readonly IMapper _mapper;

        public EmpleadoBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _EmpleadoRepository = new EmpleadoRepository();

        }

        #endregion Fin Inyeccion de Dependencias
        public ResponseVEmpleado Create(RequestEmpleado entity)
        {
            Empleado Empleado = _mapper.Map<Empleado>(entity);
            Empleado = _EmpleadoRepository.Create(Empleado);
            ResponseVEmpleado ResponseVEmpleado = _mapper.Map<ResponseVEmpleado>(Empleado);
            return ResponseVEmpleado;

        }

        public List<ResponseVEmpleado> CreateMultiple(List<RequestEmpleado> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestEmpleado> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVEmpleado> GetAll()
        {
            List<Empleado> Empleado = _EmpleadoRepository.GetAll();
            List<ResponseVEmpleado> ResponseVEmpleado = _mapper.Map<List<ResponseVEmpleado>>(Empleado);
            return ResponseVEmpleado;
        }

        public ResponseVEmpleado GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseVEmpleado Update(RequestEmpleado entity)
        {
            Empleado Empleado = _mapper.Map<Empleado>(entity);
            Empleado = _EmpleadoRepository.Update(Empleado);
            ResponseVEmpleado ResponseVEmpleado = _mapper.Map<ResponseVEmpleado>(Empleado);
            return ResponseVEmpleado;
        }

        public List<ResponseVEmpleado> UpdateMultiple(List<RequestEmpleado> lista)
        {
            throw new NotImplementedException();
        }
    }
}
