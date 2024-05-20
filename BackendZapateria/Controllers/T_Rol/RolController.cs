using AutoMapper;
using Bussniess.T_Rol;
using IBussniess.T_Rol;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponse.Request.T_Rol;
using RequestResponse.Request.T_Usuario;

namespace BackendZapateria.Controllers.T_Rol
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IRolBussniess _rolBussniess;
        private readonly IMapper _mapper;

        public RolController(IMapper mapper)
        {
            _mapper = mapper;
            _rolBussniess = new RolBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_rolBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestRol entity)
        {
            return Ok(_rolBussniess.Create(entity));
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_rolBussniess.GetById(id));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestRol entity)
        {
            return Ok(_rolBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_rolBussniess.Delete(id));

        }

    }
}
