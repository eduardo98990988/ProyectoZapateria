﻿using AutoMapper;
using Bussniess.T_Empleado;
using IBussniess.T_Empleado;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponse.Request;
using RequestResponse.Request.T_Empleado;
using RequestResponse.Response;
using RequestResponse.Response.T_Empleado;

namespace BackendZapateria.Controllers.T_Empleado
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IEmpleadoBussniess _EmpleadoBussniess;
        private readonly IMapper _mapper;

        public EmpleadoController(IMapper mapper)
        {
            _mapper = mapper;
            _EmpleadoBussniess = new EmpleadoBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_EmpleadoBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestEmpleado entity)
        {
            return Ok(_EmpleadoBussniess.Create(entity));
        }
        [HttpPost("filter")]
        public IActionResult GetByFilter([FromBody] RequestFilterGeneric request)
        {
            ReponseFilterGeneric<ResponseVEmpleado> filterEmpleado = _EmpleadoBussniess.GetByFilter(request);
            return Ok(filterEmpleado);
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestEmpleado entity)
        {
            return Ok(_EmpleadoBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_EmpleadoBussniess.Delete(id));

        }
    }
}
