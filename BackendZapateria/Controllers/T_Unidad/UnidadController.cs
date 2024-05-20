using AutoMapper;
using Bussniess.T_Unidad;
using IBussniess.T_Unidad;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponse.Request.T_Unidad;

namespace BackendZapateria.Controllers.T_Unidad
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly iUnidadBussniess _UnidadBussniess;
        private readonly IMapper _mapper;

        public UnidadController(IMapper mapper)
        {
            _mapper = mapper;
            _UnidadBussniess = new UnidadBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_UnidadBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestUnidad entity)
        {
            return Ok(_UnidadBussniess.Create(entity));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestUnidad entity)
        {
            return Ok(_UnidadBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_UnidadBussniess.Delete(id));

        }
    }
}
