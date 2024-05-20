using AutoMapper;
using Bussniess.T_DetalleOrden;
using IBussniess.T_DetalleOrden;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_DetalleOrden;

namespace BackendZapateria.Controllers.T_DetalleOrden
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleOrdenController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IDetalleOrdenBussniess _DetalleOrdenBussniess;
        private readonly IMapper _mapper;

        public DetalleOrdenController(IMapper mapper)
        {
            _mapper = mapper;
            _DetalleOrdenBussniess = new DetalleOrdenBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_DetalleOrdenBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestDetalleOrden entity)
        {
            return Ok(_DetalleOrdenBussniess.Create(entity));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestDetalleOrden entity)
        {
            return Ok(_DetalleOrdenBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_DetalleOrdenBussniess.Delete(id));

        }
    }
}
