using AutoMapper;
using Bussniess.T_Transporte;
using IBussniess.T_Transporte;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_Transporte;


namespace BackendZapateria.Controllers.T_Transporte
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransporteController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly ITransporteBussniess _TransporteBussniess;
        private readonly IMapper _mapper;

        public TransporteController(IMapper mapper)
        {
            _mapper = mapper;
            _TransporteBussniess = new TransporteBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_TransporteBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestTransporte entity)
        {
            return Ok(_TransporteBussniess.Create(entity));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestTransporte entity)
        {
            return Ok(_TransporteBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_TransporteBussniess.Delete(id));

        }
    }
}
