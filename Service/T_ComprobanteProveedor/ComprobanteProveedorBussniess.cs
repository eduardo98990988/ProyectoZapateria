using AutoMapper;
using DBModelZapateria;
using IBussniess.T_ComprobanteProveedor;
using IRepository.T_Comprobante;
using IRepository.T_ComprobanteProveedor;
using Repositori.T_Comprobante;
using Repositori.T_ComprobanteProveedor;
using RequestRespons.Request.T_ComprobanteProveedor;
using RequestRespons.Response.T_ComprobanteProveedor;
using RequestResponse.Request.T_Comprobante;
using RequestResponse.Response.T_Comprobante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_ComprobanteProveedor
{
    public class ComprobanteProveedorBussniess  : IComprobanteProveedorBussniess
    {
        #region Inyeccion de Dependencias
        private readonly IComprobanteProveedorRepository _ComprobanteProveedorRepository;
        private readonly IMapper _mapper;

        public ComprobanteProveedorBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _ComprobanteProveedorRepository = new ComprobanteProveedorRepository();

        }

        #endregion Fin Inyeccion de Dependencias
        public ResponseVComprobanteProveedor Create(RequestComprobanteProveedor entity)
        {
            ComprobanteProvedor ComprobanteProveedor = _mapper.Map<ComprobanteProvedor>(entity);
            ComprobanteProveedor = _ComprobanteProveedorRepository.Create(ComprobanteProveedor);
            ResponseVComprobanteProveedor ResponseVComprobanteProveedor = _mapper.Map<ResponseVComprobanteProveedor>(ComprobanteProveedor);
            return ResponseVComprobanteProveedor;

        }

        public List<ResponseVComprobanteProveedor> CreateMultiple(List<RequestComprobanteProveedor> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestComprobanteProveedor> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVComprobanteProveedor> GetAll()
        {
            List<ComprobanteProvedor> ComprobanteProveedor = _ComprobanteProveedorRepository.GetAll();
            List<ResponseVComprobanteProveedor> ResponseVComprobanteProveedor = _mapper.Map<List<ResponseVComprobanteProveedor>>(ComprobanteProveedor);
            return ResponseVComprobanteProveedor;
        }

        public ResponseVComprobanteProveedor GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseVComprobanteProveedor Update(RequestComprobanteProveedor entity)
        {
            ComprobanteProvedor ComprobanteProveedor = _mapper.Map<ComprobanteProvedor>(entity);
            ComprobanteProveedor = _ComprobanteProveedorRepository.Update(ComprobanteProveedor);
            ResponseVComprobanteProveedor ResponseVComprobanteProveedor = _mapper.Map<ResponseVComprobanteProveedor>(ComprobanteProveedor);
            return ResponseVComprobanteProveedor;
        }

        public List<ResponseVComprobanteProveedor> UpdateMultiple(List<RequestComprobanteProveedor> lista)
        {
            throw new NotImplementedException();
        }
    }
}
