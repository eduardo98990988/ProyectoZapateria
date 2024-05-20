using AutoMapper;
using Bussniess.T_Area;
using IBussniess.T_Area;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_Area;

namespace BackendZapateria.Controllers.T_Area
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IAreaBussniess _AreaBussniess;
        private readonly IMapper _mapper;

        public AreaController(IMapper mapper)
        {
            _mapper = mapper;
            _AreaBussniess = new AreaBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_AreaBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestArea entity)
        {
            return Ok(_AreaBussniess.Create(entity));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestArea entity)
        {
            return Ok(_AreaBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_AreaBussniess.Delete(id));

        }
    }
}
