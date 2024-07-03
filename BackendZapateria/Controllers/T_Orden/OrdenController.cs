using AutoMapper;
using Bussniess.T_Orden;
using IBussniess.T_Orden;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_Orden;
using RequestRespons.Response.T_Orden;
using RequestResponse.Request;
using RequestResponse.Response;
using RequestResponse.Response.T_Rol;


namespace BackendZapateria.Controllers.T_Orden
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IOrdenBussniess _OrdenBussniess;
        private readonly IOrdenVBussniess _OrdenVBussniess;
        private readonly IMapper _mapper;

        public OrdenController(IMapper mapper)
        {
            _mapper = mapper;
            _OrdenBussniess = new OrdenBussniess(mapper);
            _OrdenVBussniess = new OrdenVBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_OrdenVBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestOrden entity)
        {
            return Ok(_OrdenBussniess.Create(entity));
        }
        [HttpPost("filter")]
        public IActionResult GetFilter([FromBody] RequestFilterGeneric request)
        {
            ReponseFilterGeneric<ResponseVOrden> filterRol = _OrdenBussniess.GetByFilter(request);
            return Ok(filterRol);
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestOrden entity)
        {
            return Ok(_OrdenBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_OrdenBussniess.Delete(id));

        }
    }
}
