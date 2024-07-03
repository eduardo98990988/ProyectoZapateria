using AutoMapper;
using DBModelZapateria;
using RequestRespons.Request.T_Cliente;
using RequestRespons.Request.T_Empleado;
using RequestRespons.Request.T_Material;
using RequestRespons.Request.T_Modelo;
using RequestRespons.Request.T_Orden;
using RequestRespons.Request.T_Producto;
using RequestRespons.Request.T_Proveedor;
using RequestRespons.Request.T_SalidaMaterial;
using RequestRespons.Response.T_Cliente;
using RequestRespons.Response.T_DetalleCredito;
using RequestRespons.Response.T_DetalleProducto;
using RequestRespons.Response.T_Material;
using RequestRespons.Response.T_Modelo;
using RequestRespons.Response.T_Orden;
using RequestRespons.Response.T_Producto;
using RequestRespons.Response.T_Proveedor;
using RequestRespons.Response.T_SalidaMaterial;
using RequestResponse.Request;
using RequestResponse.Request.T_Empleado;
using RequestResponse.Request.T_Persona;
using RequestResponse.Request.T_Produccion;
using RequestResponse.Request.T_Rol;
using RequestResponse.Request.T_Unidad;
using RequestResponse.Request.T_Usuario;
using RequestResponse.Response;
using RequestResponse.Response.T_Empleado;
using RequestResponse.Response.T_Persona;
using RequestResponse.Response.T_Produccion;
using RequestResponse.Response.T_Rol;
using RequestResponse.Response.T_Unidad;
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

            CreateMap<RequestPersona, RequestUsuario>().ReverseMap();
            CreateMap<RequestUsuario, ResponsePersona>().ReverseMap();

            CreateMap<ResponseUsuario, RequestUsuario>().ReverseMap();
            CreateMap<RequestUsuario, ResponseUsuario>().ReverseMap();

            CreateMap<ResponseUsuario, Usuario>().ReverseMap();
            CreateMap<Usuario, ResponseUsuario>().ReverseMap();

            CreateMap<RequestUsuario, Usuario>().ReverseMap();
            CreateMap<Usuario, RequestUsuario>().ReverseMap();

            CreateMap<ResponseUsuario, VisUsuario>().ReverseMap();
            CreateMap<VisUsuario, ResponseUsuario>().ReverseMap();

            CreateMap<ResponseVUsuario, VisUsuario>().ReverseMap();
            CreateMap<VisUsuario, ResponseVUsuario>().ReverseMap();

            #endregion Usuario
            #region Rol
            CreateMap<RequestRol,Rol>().ReverseMap();
            CreateMap<Rol, RequestRol>().ReverseMap();

            CreateMap<ResponseRol, Rol>().ReverseMap();
            CreateMap<Rol, ResponseRol>().ReverseMap();

            CreateMap<ReponseFilterGeneric<ResponseRol>, Rol>().ReverseMap();

            CreateMap<ReponseFilterGeneric<ResponseRol>, ReponseFilterGeneric<Rol>>().ReverseMap();

            #endregion Rol 
            #region Empleado 
            CreateMap<RequestEmpleado, Empleado>().ReverseMap();
            CreateMap<Empleado, RequestEmpleado>().ReverseMap();
            CreateMap<RequestEmpleado, VistEmpleado>().ReverseMap();
            CreateMap<VistEmpleado, RequestEmpleado>().ReverseMap();
            CreateMap<ResponseVEmpleado, VistEmpleado>().ReverseMap();
            CreateMap<VistEmpleado, ResponseVEmpleado>().ReverseMap();
            CreateMap<ResponseEmpleado, VistEmpleado>().ReverseMap();
            CreateMap<VistEmpleado, ResponseEmpleado>().ReverseMap();

            CreateMap<RequestVEmpleado, RequestPersona>().ReverseMap();
            CreateMap<RequestPersona, RequestVEmpleado>().ReverseMap();

            CreateMap<ResponseVEmpleado, Empleado>().ReverseMap();
            CreateMap<Empleado, ResponseVEmpleado>().ReverseMap();

            CreateMap<ResponseEmpleado, Empleado>().ReverseMap();
            CreateMap<Empleado, ResponseEmpleado>().ReverseMap();

            CreateMap<RequestUsuario, RequestVEmpleado>().ReverseMap();
            CreateMap<RequestVEmpleado, RequestUsuario>().ReverseMap();

            CreateMap<ResponseEmpleado, ResponseVEmpleado>().ReverseMap();
            CreateMap<ResponseVEmpleado, ResponseEmpleado>().ReverseMap();

            CreateMap<ResponseVUsuario, ResponseEmpleado>().ReverseMap();
            CreateMap<ResponseEmpleado, ResponseVUsuario>().ReverseMap();

            CreateMap<ResponseVUsuario, ResponseVEmpleado>().ReverseMap();
            CreateMap<ResponseVEmpleado, ResponseVUsuario>().ReverseMap();

            CreateMap<ResponseUsuario, ResponseEmpleado>().ReverseMap();
            CreateMap<ResponseEmpleado, ResponseUsuario>().ReverseMap();

            CreateMap<ResponseUsuario, ResponseVEmpleado>().ReverseMap();
            CreateMap<ResponseVEmpleado, ResponseUsuario>().ReverseMap();

            CreateMap<RequestEmpleado, RequestVEmpleado>().ReverseMap();
            CreateMap<RequestVEmpleado, RequestEmpleado>().ReverseMap();

            CreateMap<RequestEmpleado, RequestPersona>().ReverseMap();
            CreateMap<RequestPersona, RequestEmpleado>().ReverseMap();

            CreateMap<RequestEmpleado, ResponseVEmpleado>().ReverseMap();
            CreateMap<ResponseVEmpleado, RequestEmpleado>().ReverseMap();

            CreateMap<ReponseFilterGeneric<ResponseRol>, Rol>().ReverseMap();

            CreateMap<ReponseFilterGeneric<ResponseRol>, ReponseFilterGeneric<Rol>>().ReverseMap();
            #endregion Empleado
            #region Cliente

            CreateMap<ResponseCliente, Cliente>().ReverseMap();
            CreateMap<Cliente, ResponseCliente>().ReverseMap();

            CreateMap<ResponseVCliente, Cliente>().ReverseMap();
            CreateMap<Cliente, ResponseVCliente>().ReverseMap();

            CreateMap<ResponseVCliente, ResponseCliente>().ReverseMap();
            CreateMap<ResponseCliente, ResponseVCliente>().ReverseMap();

            CreateMap<RequestCliente, Cliente>().ReverseMap();
            CreateMap<Cliente, RequestCliente>().ReverseMap();

            CreateMap<RequestVCliente, Cliente>().ReverseMap();
            CreateMap<Cliente, RequestVCliente>().ReverseMap();

            CreateMap<RequestVCliente, RequestPersona>().ReverseMap();
            CreateMap<RequestPersona, RequestVCliente>().ReverseMap();

            CreateMap<RequestCliente, ResponsePersona>().ReverseMap();
            CreateMap<RequestPersona, RequestCliente>().ReverseMap();

            CreateMap<RequestVCliente, ResponseCliente>().ReverseMap();
            CreateMap<ResponseCliente, RequestVCliente>().ReverseMap();

            CreateMap<RequestCliente, ResponsePersona>().ReverseMap();
            CreateMap<RequestPersona, RequestCliente>().ReverseMap();

            CreateMap<ResponseCliente, Cliente>().ReverseMap();
            CreateMap<Cliente, ResponseCliente>().ReverseMap();

            CreateMap<ResponseVCliente, Cliente>().ReverseMap();
            CreateMap<Cliente, ResponseVCliente>().ReverseMap();


            CreateMap<ResponseVCliente, VistCliente>().ReverseMap();
            CreateMap<VistCliente, ResponseVCliente>().ReverseMap();

            CreateMap<Cliente, VistCliente>().ReverseMap();
            CreateMap<Cliente, ResponseVCliente>().ReverseMap();

            CreateMap<ResponseCliente, VistCliente>().ReverseMap();
            CreateMap<Cliente, ResponseCliente>().ReverseMap();
            #endregion Cliente
            #region Produccion 
            CreateMap<RequestProduccion, Produccion>().ReverseMap();
            CreateMap<Produccion, RequestProduccion>().ReverseMap();

            CreateMap<ResponseProduccion, Produccion>().ReverseMap();
            CreateMap<Produccion, ResponseProduccion>().ReverseMap();

            CreateMap<ResponseVProduccion, Produccion>().ReverseMap();
            CreateMap<Produccion, ResponseVProduccion>().ReverseMap();


            CreateMap<ResponseVProduccion, VistProduccion>().ReverseMap();
            CreateMap<VistProduccion, ResponseVProduccion>().ReverseMap();

            CreateMap<Produccion, VistProduccion>().ReverseMap();
            CreateMap<Produccion, ResponseVProduccion>().ReverseMap();

            CreateMap<ResponseProduccion, VistProduccion>().ReverseMap();
            CreateMap<Produccion, ResponseProduccion>().ReverseMap();
            #endregion Produccion
            #region Orden
            CreateMap<RequestOrden, Orden>().ReverseMap();
            CreateMap<Orden, RequestOrden>().ReverseMap();

            CreateMap<ResponseOrden, Orden>().ReverseMap();
            CreateMap<Orden, ResponseOrden>().ReverseMap();

            CreateMap<ResponseVOrden, Orden>().ReverseMap();
            CreateMap<Orden, ResponseVOrden>().ReverseMap();


            CreateMap<ResponseVOrden, VistOrden>().ReverseMap();
            CreateMap<VistOrden, ResponseVOrden>().ReverseMap();

            CreateMap<Orden, VistOrden>().ReverseMap();
            CreateMap<Orden, ResponseVOrden>().ReverseMap();

            CreateMap<ResponseOrden, VistOrden>().ReverseMap();
            CreateMap<Orden, ResponseOrden>().ReverseMap();
            #endregion Orden
            #region Producto
            CreateMap<RequestProducto, Producto>().ReverseMap();
            CreateMap<Producto, RequestProducto>().ReverseMap();

            CreateMap<DetalleProducto, ResponseVDetalleProducto>().ReverseMap();
            CreateMap<ResponseVDetalleProducto, DetalleProducto>().ReverseMap();

            CreateMap<ResponseDetalleProducto, ResponseVDetalleProducto>().ReverseMap();
            CreateMap<ResponseVDetalleProducto, ResponseDetalleProducto>().ReverseMap();


            CreateMap<ResponseProducto, Producto>().ReverseMap();
            CreateMap<Producto, ResponseProducto>().ReverseMap();

            CreateMap<ResponseVProducto, Producto>().ReverseMap();
            CreateMap<Producto, ResponseVProducto>().ReverseMap();


            CreateMap<ReponseFilterGeneric<ResponseVProducto>, Producto>().ReverseMap();

            CreateMap<ReponseFilterGeneric<ResponseVProducto>, ReponseFilterGeneric<Producto>>().ReverseMap();

            CreateMap<ReponseFilterGeneric<ResponseProducto>, Producto>().ReverseMap();

            CreateMap<ReponseFilterGeneric<ResponseProducto>, ReponseFilterGeneric<Producto>>().ReverseMap();
            //CreateMap<ResponseVProducto, VistProducto>().ReverseMap();
            //CreateMap<VistProducto, ResponseVProducto>().ReverseMap();

            //CreateMap<Producto, VistProducto>().ReverseMap();
            //CreateMap<Producto, ResponseVProducto>().ReverseMap();

            //CreateMap<ResponseProducto, VistProducto>().ReverseMap();
            //CreateMap<Producto, ResponseProducto>().ReverseMap();
            #endregion Producto
            #region Modelo
            CreateMap<RequestModelo, Modelo>().ReverseMap();
            CreateMap<Modelo, RequestModelo>().ReverseMap();

            CreateMap<ResponseModelo, Modelo>().ReverseMap();
            CreateMap<Modelo, ResponseModelo>().ReverseMap();

            CreateMap<ResponseModelo, Modelo>().ReverseMap();
            CreateMap<Modelo, ResponseModelo>().ReverseMap();


            CreateMap<ReponseFilterGeneric<ResponseModelo>, Modelo>().ReverseMap();

            CreateMap<ReponseFilterGeneric<ResponseModelo>, ReponseFilterGeneric<Modelo>>().ReverseMap();

            CreateMap<ReponseFilterGeneric<ResponseModelo>, Modelo>().ReverseMap();

            CreateMap<ReponseFilterGeneric<ResponseModelo>, ReponseFilterGeneric<Modelo>>().ReverseMap();
            #endregion Modelo
            #region Proveedor
            CreateMap<RequestProveedor, Provedor>().ReverseMap();
            CreateMap<Provedor, RequestProveedor>().ReverseMap();

            CreateMap<ResponseProveedor, Provedor>().ReverseMap();
            CreateMap<Provedor, ResponseProveedor>().ReverseMap();

            CreateMap<ResponseVProveedor, Provedor>().ReverseMap();
            CreateMap<Provedor, ResponseVProveedor>().ReverseMap();

            CreateMap<ResponseVProveedor, VisProveedor>().ReverseMap();
            CreateMap<VisProveedor, ResponseVProveedor>().ReverseMap();

            CreateMap<ResponseProveedor, VisProveedor>().ReverseMap();
            CreateMap<VisProveedor, ResponseProveedor>().ReverseMap();


            CreateMap<ReponseFilterGeneric<ResponseProveedor>, Provedor>().ReverseMap();

            CreateMap<ReponseFilterGeneric<ResponseProveedor>, ReponseFilterGeneric<Provedor>>().ReverseMap();

            CreateMap<ReponseFilterGeneric<ResponseProveedor>, Provedor>().ReverseMap();

            CreateMap<ReponseFilterGeneric<ResponseProveedor>, ReponseFilterGeneric<Provedor>>().ReverseMap();
            #endregion Proveedor
            #region SalidaMaterial
            CreateMap<RequestSalidaMaterial, SalidaMaterial>().ReverseMap();
            CreateMap<SalidaMaterial, RequestSalidaMaterial>().ReverseMap();

            CreateMap<ResponseSalidaMaterial, SalidaMaterial>().ReverseMap();
            CreateMap<SalidaMaterial, ResponseSalidaMaterial>().ReverseMap();

            CreateMap<ResponseVSalidaMaterial, VistSalidaMaterial>().ReverseMap();
            CreateMap<VistSalidaMaterial, ResponseVSalidaMaterial>().ReverseMap();

            CreateMap<ResponseSalidaMaterial, VistSalidaMaterial>().ReverseMap();
            CreateMap<VistSalidaMaterial, ResponseSalidaMaterial>().ReverseMap();

            CreateMap<ResponseVSalidaMaterial, SalidaMaterial>().ReverseMap();
            CreateMap<SalidaMaterial, ResponseVSalidaMaterial>().ReverseMap();
            #endregion SalidaMaterial
            #region Material
            CreateMap<RequestMaterial, Material>().ReverseMap();
            CreateMap<Material, RequestMaterial>().ReverseMap();

            CreateMap<ResponseMaterial, Material>().ReverseMap();
            CreateMap<Material, ResponseMaterial>().ReverseMap();

      
            CreateMap<ResponseVMaterial, Material>().ReverseMap();
            CreateMap<Material, ResponseVMaterial>().ReverseMap();
            #endregion Material
            #region Unidad
            CreateMap<RequestUnidad, Unidad>().ReverseMap();
            CreateMap<Unidad, RequestUnidad>().ReverseMap();

            CreateMap<ResponseUnidad, Unidad>().ReverseMap();
            CreateMap<Unidad, ResponseUnidad>().ReverseMap();

            CreateMap<ResponseUnidad, Unidad>().ReverseMap();
            CreateMap<Unidad, ResponseUnidad>().ReverseMap();


            #endregion Unidad
            #region Detalle Credito
            CreateMap<DetalleCredio, ResponseVDetalleCredito>().ReverseMap();
            CreateMap<ResponseVDetalleCredito, DetalleCredio>().ReverseMap();

            CreateMap<ResponseUnidad, Unidad>().ReverseMap();
            CreateMap<Unidad, ResponseUnidad>().ReverseMap();

            CreateMap<ResponseUnidad, Unidad>().ReverseMap();
            CreateMap<Unidad, ResponseUnidad>().ReverseMap();


            #endregion Detalle Credito
        }
    }
}
