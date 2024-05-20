using AutoMapper;
using Bussniess.T_SalidaMaterial;
using IBussniess.T_SalidaMaterial;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_SalidaMaterial;

namespace BackendZapateria.Controllers.T_SalidaMaterial
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalidaMaterialController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly ISalidaMaterialBussniess _SalidaMaterialBussniess;
        private readonly IMapper _mapper;

        public SalidaMaterialController(IMapper mapper)
        {
            _mapper = mapper;
            _SalidaMaterialBussniess = new SalidaMaterialBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_SalidaMaterialBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestSalidaMaterial entity)
        {
            return Ok(_SalidaMaterialBussniess.Create(entity));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestSalidaMaterial entity)
        {
            return Ok(_SalidaMaterialBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_SalidaMaterialBussniess.Delete(id));

        }
    }
}
