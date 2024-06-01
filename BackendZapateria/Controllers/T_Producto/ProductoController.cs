using AutoMapper;
using Bussniess.T_Producto;
using IBussniess.T_Producto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_Producto;
using RequestRespons.Response.T_Producto;
using RequestResponse.Request;
using RequestResponse.Response;

namespace BackendZapateria.Controllers.T_Producto
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IProductoBussniess _ProductoBussniess;
        private readonly IMapper _mapper;

        public ProductoController(IMapper mapper)
        {
            _mapper = mapper;
            _ProductoBussniess = new ProductoBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ProductoBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestProducto entity)
        {
            return Ok(_ProductoBussniess.Create(entity));
        }
        [HttpPost("filter")]
        public IActionResult GetBYFilter([FromBody] RequestFilterGeneric request)
        {
            ReponseFilterGeneric<ResponseVProducto> filterProducto = _ProductoBussniess.GetByFilter(request);
            return Ok(filterProducto);
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestProducto entity)
        {
            return Ok(_ProductoBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_ProductoBussniess.Delete(id));

        }
    }
}
