using AutoMapper;
using Bussniess.T_Modelo;
using IBussniess.T_Modelo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_Modelo;


namespace BackendZapateria.Controllers.T_Modelo
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeloController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IModeloBussniess _ModeloBussniess;
        private readonly IMapper _mapper;

        public ModeloController(IMapper mapper)
        {
            _mapper = mapper;
            _ModeloBussniess = new ModeloBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ModeloBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestModelo entity)
        {
            return Ok(_ModeloBussniess.Create(entity));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestModelo entity)
        {
            return Ok(_ModeloBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_ModeloBussniess.Delete(id));

        }
    }
}
