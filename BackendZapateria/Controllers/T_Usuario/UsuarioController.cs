using AutoMapper;
using Bussniess.Login;
using Bussniess.T_Usuario;
using DBModelZapateria;
using IBussniess.Login;
using IBussniess.T_Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RequestResponse.Request.T_Usuario;
using RequestResponse.Response.Login;
using RequestResponse.Response.T_Usuario;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BackendZapateria.Controllers.T_Usuario
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IUsuarioBussniess _UsuarioBussniess;
        private readonly ILoginBussniess _loginBussniess;
        private readonly IUsuarioVBussniess _usuarioVBussniess;
        private readonly IMapper _mapper;

        public UsuarioController(IMapper mapper)
        {
            _mapper = mapper;
            _UsuarioBussniess = new UsuarioBussniess(mapper);
            _loginBussniess = new LoginBussniess(mapper);
            _usuarioVBussniess = new UsuarioVBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_usuarioVBussniess.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestUsuario entity)
        {
            ResponseUsuario responseUsuario = _usuarioVBussniess.Create(entity);
      

            //if (responseUsuario != null)
            ////{
            ////    responseUsuario.token = CreateToken(responseUsuario);

            ////    return Ok(responseUsuario);
            ////}

            return Ok(responseUsuario);
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestUsuario entity)
        {
            return Ok(_UsuarioBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_UsuarioBussniess.Delete(id));

        }
        private string CreateToken(VisUsuario responseUsuario)
        {
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            configurationBuild = configurationBuild.AddJsonFile("appsettings.json");
            IConfiguration configurationFile = configurationBuild.Build();

            int tiempoVida = int.Parse(configurationFile["Jwt:TimeJWTMin"]);

            var tokenHandler = new JwtSecurityTokenHandler();
            var byteKey = Encoding.UTF8.GetBytes(configurationFile["Jwt:Key"]);
            var tokenDes = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim("IdUsuario", responseUsuario.IdUsuario.ToString()),
                        new Claim("NombrePersona",responseUsuario.NombrePersona),
                        new Claim("NombreRol",responseUsuario.NombreRol)
                }),
                Expires = DateTime.UtcNow.AddMinutes(tiempoVida),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(byteKey),
                                                                SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDes);
            return tokenHandler.WriteToken(token);
        }
    }
}
