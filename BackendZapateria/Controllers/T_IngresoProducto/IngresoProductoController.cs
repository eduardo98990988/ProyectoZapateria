using AutoMapper;
using Bussniess.T_IngresoProducto;
using IBussniess.T_IngresoProducto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_IngresoProducto;

namespace BackendZapateria.Controllers.T_IngresoProducto
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresoProductoController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IIngresoProductoBussniess _IngresoProductoBussniess;
        private readonly IMapper _mapper;

        public IngresoProductoController(IMapper mapper)
        {
            _mapper = mapper;
            _IngresoProductoBussniess = new IngresoProductoBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_IngresoProductoBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestIngresoProducto entity)
        {
            return Ok(_IngresoProductoBussniess.Create(entity));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestIngresoProducto entity)
        {
            return Ok(_IngresoProductoBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_IngresoProductoBussniess.Delete(id));

        }
    }
}
