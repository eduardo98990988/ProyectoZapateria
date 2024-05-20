using AutoMapper;
using Bussniess.T_Persona;
using Bussniess.T_Rol;
using IBussniess.T_Persona;
using IBussniess.T_Rol;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponse.Request.T_Persona;
using RequestResponse.Request.T_Rol;

namespace BackendZapateria.Controllers.T_Persona
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IPersonaBussniess _PersonaBussniess;
        private readonly IMapper _mapper;

        public PersonaController(IMapper mapper)
        {
            _mapper = mapper;
            _PersonaBussniess = new PersonaBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_PersonaBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestPersona entity)
        {
            return Ok(_PersonaBussniess.Create(entity));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestPersona entity)
        {
            return Ok(_PersonaBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_PersonaBussniess.Delete(id));

        }
    }
}
