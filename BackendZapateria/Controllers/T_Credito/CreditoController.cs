using AutoMapper;
using Bussniess.T_Credito;
using IBussniess.T_Credito;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_Credito;
using RequestRespons.Response.T_Credito;
using RequestResponse.Request;
using RequestResponse.Response;

namespace BackendZapateria.Controllers.T_Credito
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditoController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly ICreditoBussniess _CreditoBussniess;
        private readonly IMapper _mapper;

        public CreditoController(IMapper mapper)
        {
            _mapper = mapper;
            _CreditoBussniess = new CreditoBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_CreditoBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestCredito entity)
        {
            return Ok(_CreditoBussniess.Create(entity));
        }
        [HttpPost("filter")]
        public IActionResult GetByFilter([FromBody] RequestFilterGeneric request)
        {
            ReponseFilterGeneric<ResponseCredito> filterCredito = _CreditoBussniess.GetByFilter(request);
            return Ok(filterCredito);
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestCredito entity)
        {
            return Ok(_CreditoBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_CreditoBussniess.Delete(id));

        }
    }
}
