using AutoMapper;
using Bussniess.T_Proveedor;
using IBussniess.T_Proveedor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_Proveedor;
using RequestRespons.Response.T_Orden;
using RequestRespons.Response.T_Proveedor;
using RequestResponse.Request;
using RequestResponse.Response;

namespace BackendZapateria.Controllers.T_Proveedor
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IProveedorBussniess _ProveedorBussniess;
        private readonly IProveedorVBussniess _ProveedorVBussniess;
        private readonly IMapper _mapper;

        public ProveedorController(IMapper mapper)
        {
            _mapper = mapper;
            _ProveedorBussniess = new ProveedorBussniess(mapper);
            _ProveedorVBussniess = new ProveedorVBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ProveedorVBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestProveedor entity)
        {
            return Ok(_ProveedorBussniess.Create(entity));
        }
        [HttpPost("filter")]
        public IActionResult GetByfilter([FromBody]RequestFilterGeneric request)
        {
            ReponseFilterGeneric<ResponseVProveedor> filterOrden = _ProveedorBussniess.GetByFilter(request);
            return Ok(filterOrden);
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestProveedor entity)
        {
            return Ok(_ProveedorBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_ProveedorBussniess.Delete(id));

        }
    }
}
