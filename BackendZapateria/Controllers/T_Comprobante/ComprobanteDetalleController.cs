using AutoMapper;
using Bussniess.T_Comprobante;
using IBussniess.T_Comprobante;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponse.Request.T_Comprobante;


namespace BackendZapateria.Controllers.T_Comprobante
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobanteDetalleController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IComprobanteDetalleBussniess _ComprobanteDetalleBussniess;
        private readonly IMapper _mapper;

        public ComprobanteDetalleController(IMapper mapper)
        {
            _mapper = mapper;
            _ComprobanteDetalleBussniess = new ComprobanteDetalleBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ComprobanteDetalleBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestComprobanteDetalle entity)
        {
            return Ok(_ComprobanteDetalleBussniess.Create(entity));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestComprobanteDetalle entity)
        {
            return Ok(_ComprobanteDetalleBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_ComprobanteDetalleBussniess.Delete(id));

        }
    }
}
