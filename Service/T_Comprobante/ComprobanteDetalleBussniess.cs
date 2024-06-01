using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Comprobante;
using IRepository.T_Comprobante;
using Repositori.T_Comprobante;
using RequestResponse.Request;
using RequestResponse.Request.T_Comprobante;
using RequestResponse.Response;
using RequestResponse.Response.T_Comprobante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Comprobante
{
    public class ComprobanteDetalleBussniess : IComprobanteDetalleBussniess
    {
        #region Inyeccion de Dependencias
        private readonly IComprobanteDetalleRepository _ComprobanteDetalleRepository;
        private readonly IMapper _mapper;

        public ComprobanteDetalleBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _ComprobanteDetalleRepository = new ComprobanteDetalleRepository();

        }
        #endregion
        public ResponseVComprobanteDetalle Create(RequestComprobanteDetalle entity)
        {
            ComprobanteDetalle ComprobanteProveedor = _mapper.Map<ComprobanteDetalle>(entity);
            ComprobanteProveedor = _ComprobanteDetalleRepository.Create(ComprobanteProveedor);
            ResponseVComprobanteDetalle ResponseVComprobanteProveedor = _mapper.Map<ResponseVComprobanteDetalle>(ComprobanteProveedor);
            return ResponseVComprobanteProveedor;
            throw new NotImplementedException();
        }

        public List<ResponseVComprobanteDetalle> CreateMultiple(List<RequestComprobanteDetalle> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestComprobanteDetalle> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVComprobanteDetalle> GetAll()
        {
            throw new NotImplementedException();
        }

        public ReponseFilterGeneric<ResponseVComprobanteDetalle> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseVComprobanteDetalle GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseVComprobanteDetalle Update(RequestComprobanteDetalle entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseVComprobanteDetalle> UpdateMultiple(List<RequestComprobanteDetalle> lista)
        {
            throw new NotImplementedException();
        }
    }
}
