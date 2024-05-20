using AutoMapper;
using Bussniess.T_DetalleCredito;
using IBussniess.T_DetalleCredito;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_DetalleCredito;

namespace BackendZapateria.Controllers.T_DetalleCredito
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleCreditoController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IDetalleCreditoBussniess _DetalleCreditoBussniess;
        private readonly IMapper _mapper;

        public DetalleCreditoController(IMapper mapper)
        {
            _mapper = mapper;
            _DetalleCreditoBussniess = new DetalleCreditoBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_DetalleCreditoBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestDetalleCredito entity)
        {
            return Ok(_DetalleCreditoBussniess.Create(entity));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestDetalleCredito entity)
        {
            return Ok(_DetalleCreditoBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_DetalleCreditoBussniess.Delete(id));

        }
    }
}
