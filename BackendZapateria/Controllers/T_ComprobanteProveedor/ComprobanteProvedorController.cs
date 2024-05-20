using AutoMapper;
using Bussniess.T_Comprobante;
using Bussniess.T_ComprobanteProveedor;
using IBussniess.T_Comprobante;
using IBussniess.T_ComprobanteProveedor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_ComprobanteProveedor;
using RequestResponse.Request.T_Comprobante;

namespace BackendZapateria.Controllers.T_ComprobanteProveedor
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobanteProvedorController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IComprobanteProveedorBussniess _ComprobanteProveedorBussniess;
        private readonly IMapper _mapper;

        public ComprobanteProvedorController(IMapper mapper)
        {
            _mapper = mapper;
            _ComprobanteProveedorBussniess = new ComprobanteProveedorBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ComprobanteProveedorBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestComprobanteProveedor entity)
        {
            return Ok(_ComprobanteProveedorBussniess.Create(entity));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestComprobanteProveedor entity)
        {
            return Ok(_ComprobanteProveedorBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_ComprobanteProveedorBussniess.Delete(id));

        }
    }
}
