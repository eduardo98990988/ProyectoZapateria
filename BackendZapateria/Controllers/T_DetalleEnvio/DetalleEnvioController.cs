using AutoMapper;
using Bussniess.T_DetalleEnvio;
using IBussniess.T_DetalleEnvio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_DetalleEnvio;

namespace BackendZapateria.Controllers.T_DetalleEnvio
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleEnvioController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IDetalleEnvioBussniess _DetalleEnvioBussniess;
        private readonly IMapper _mapper;

        public DetalleEnvioController(IMapper mapper)
        {
            _mapper = mapper;
            _DetalleEnvioBussniess = new DetalleEnvioBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_DetalleEnvioBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestDetalleEnvio entity)
        {
            return Ok(_DetalleEnvioBussniess.Create(entity));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestDetalleEnvio entity)
        {
            return Ok(_DetalleEnvioBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_DetalleEnvioBussniess.Delete(id));

        }
    }
}
