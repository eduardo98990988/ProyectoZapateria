using AutoMapper;
using Bussniess.T_Cliente;
using Bussniess.T_Comprobante;
using IBussniess.T_Cliente;
using IBussniess.T_Comprobante;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_Cliente;
using RequestResponse.Request.T_Comprobante;

namespace BackendZapateria.Controllers.T_Cliente
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IClienteBussniess _ClienteBussniess;
        private readonly IMapper _mapper;

        public ClienteController(IMapper mapper)
        {
            _mapper = mapper;
            _ClienteBussniess = new ClienteBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ClienteBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestCliente entity)
        {
            return Ok(_ClienteBussniess.Create(entity));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestCliente entity)
        {
            return Ok(_ClienteBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_ClienteBussniess.Delete(id));

        }
    }
}
