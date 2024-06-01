using AutoMapper;
using Bussniess.T_Material;
using IBussniess.T_Material;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_Material;
using RequestRespons.Response.T_Material;
using RequestResponse.Request;
using RequestResponse.Response;


namespace BackendZapateria.Controllers.T_Material
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IMaterialBussniess _MaterialBussniess;
        private readonly IMapper _mapper;

        public MaterialController(IMapper mapper)
        {
            _mapper = mapper;
            _MaterialBussniess = new MaterialBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_MaterialBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestMaterial entity)
        {
            return Ok(_MaterialBussniess.Create(entity));
        }
        [HttpPost("filter")]
        public IActionResult GetByFilter([FromBody]RequestFilterGeneric request)
        {
            ReponseFilterGeneric<ResponseVMaterial> filterMaterial = _MaterialBussniess.GetByFilter(request);
            return Ok(filterMaterial);
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestMaterial entity)
        {
            return Ok(_MaterialBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_MaterialBussniess.Delete(id));

        }
    }
}
