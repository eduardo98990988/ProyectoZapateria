using AutoMapper;
using Bussniess.T_Usuario;
using IBussniess.T_Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponse.Request.T_Usuario;
using RequestResponse.Response.Login;
using RequestResponse.Response.T_Usuario;

namespace BackendZapateria.Controllers.T_Usuario
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IUsuarioBussniess _UsuarioBussniess;
        private readonly IMapper _mapper;

        public UsuarioController(IMapper mapper)
        {
            _mapper = mapper;
            _UsuarioBussniess = new UsuarioBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_UsuarioBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestUsuario entity)
        {
            ResponseVUsuario requestUsuario = _UsuarioBussniess.Create(entity);
             
            if (requestUsuario != null)
            {

            }

            return Ok();
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestUsuario entity)
        {
            return Ok(_UsuarioBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_UsuarioBussniess.Delete(id));

        }
    }
}
