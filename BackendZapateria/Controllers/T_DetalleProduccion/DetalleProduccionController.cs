using AutoMapper;
using Bussniess.T_DetalleProduccion;
using IBussniess.T_DetalleProduccion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_DetalleProduccion;

namespace BackendZapateria.Controllers.T_DetalleProduccion
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleProduccionController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IDetalleProduccionBussniess _DetalleProduccionBussniess;
        private readonly IMapper _mapper;

        public DetalleProduccionController(IMapper mapper)
        {
            _mapper = mapper;
            _DetalleProduccionBussniess = new DetalleProduccionBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_DetalleProduccionBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestDetalleProduccion entity)
        {
            return Ok(_DetalleProduccionBussniess.Create(entity));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestDetalleProduccion entity)
        {
            return Ok(_DetalleProduccionBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_DetalleProduccionBussniess.Delete(id));

        }
    }
}
