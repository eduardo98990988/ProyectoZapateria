using AutoMapper;
using DBModelZapateria;
using RequestResponse.Request.T_Persona;
using RequestResponse.Request.T_Rol;
using RequestResponse.Response.T_Persona;
using RequestResponse.Response.T_Rol;
using RequestResponse.Response.T_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityAutoMapper
{
    public class UtilAutomapperProfile : Profile
    {
        public UtilAutomapperProfile() 
        
        {
            #region Persona
            CreateMap<Persona,RequestPersona>().ReverseMap();
            CreateMap<RequestPersona, Persona>().ReverseMap();
            CreateMap<ResponsePersona, Persona>().ReverseMap();
            CreateMap<Persona, ResponsePersona>().ReverseMap();
            #endregion Persona
            #region Usuario
            CreateMap<Usuario,ResponseVUsuario>().ReverseMap();
            CreateMap<ResponseVUsuario, Usuario>().ReverseMap();

            CreateMap<Usuario, ResponseUsuario>().ReverseMap();
            CreateMap<ResponseUsuario, Usuario>().ReverseMap();

            CreateMap<ResponseUsuario, ResponseVUsuario>().ReverseMap();
            CreateMap<ResponseVUsuario, ResponseUsuario>().ReverseMap();



            #endregion Usuario
            #region Rol
            CreateMap<RequestRol,Rol>().ReverseMap();
            CreateMap<Rol, RequestRol>().ReverseMap();

            CreateMap<ResponseRol, Rol>().ReverseMap();
            CreateMap<Rol, ResponseRol>().ReverseMap();

            #endregion Rol 

        }
    }
}
