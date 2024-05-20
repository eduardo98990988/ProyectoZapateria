using AutoMapper;
using Bussniess.T_Empleado;
using IBussniess.T_Empleado;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponse.Request.T_Empleado;

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
