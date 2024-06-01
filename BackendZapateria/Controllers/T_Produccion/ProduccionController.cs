using AutoMapper;
using Bussniess.T_Produccion;
using IBussniess.T_Produccion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponse.Request;
using RequestResponse.Request.T_Produccion;
using RequestResponse.Response;
using RequestResponse.Response.T_Produccion;

namespace BackendZapateria.Controllers.T_Produccion
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduccionController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IProduccionBussniess _ProduccionBussniess;
        private readonly IMapper _mapper;

        public ProduccionController(IMapper mapper)
        {
            _mapper = mapper;
            _ProduccionBussniess = new ProduccionBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ProduccionBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestProduccion entity)
        {
            return Ok(_ProduccionBussniess.Create(entity));
        }
        [HttpPost("filter")]
        public IActionResult GetByFilter([FromBody] RequestFilterGeneric request)
        {
            ReponseFilterGeneric<ResponseVProduccion> filterProduccion = _ProduccionBussniess.GetByFilter(request);
            return Ok(filterProduccion);
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestProduccion entity)
        {
            return Ok(_ProduccionBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_ProduccionBussniess.Delete(id));

        }
    }
}
