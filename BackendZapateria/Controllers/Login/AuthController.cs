using AutoMapper;
using Bussniess.Login;
using IBussniess.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RequestResponse.Request.Login;
using RequestResponse.Response.Login;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BackendZapateria.Controllers.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        #region Declaracion de Variables 
        private readonly ILoginBussniess _loginBussniess;
        private readonly IMapper _mapper;

        public AuthController (IMapper mapper)
        {
            _mapper = mapper;
            _loginBussniess = new LoginBussniess(mapper);
        }

        #endregion Fin Declaracion de Variabkles

        [HttpPost]
        public IActionResult Login([FromBody] RequestLogin entity)
        {
            ResponseLogin responseLogin = _loginBussniess.Login(entity);
            if(responseLogin.Success)
            {
                responseLogin.Token = CreateToken(responseLogin);
                return Ok(responseLogin);
            }
            return Ok(responseLogin);
        }
        private string CreateToken(ResponseLogin responseLogin)
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
                        new Claim("IdUsuario", responseLogin.VWUsuario.IdUsuario.ToString()),
                        new Claim("NombrePersona",responseLogin.Persona.NombrePersona),
                        new Claim("NombreRol",responseLogin.nameRol)
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
