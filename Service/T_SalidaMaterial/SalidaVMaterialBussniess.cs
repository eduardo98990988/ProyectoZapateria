using AutoMapper;
using Bussniess.T_Material;
using DBModelZapateria;
using IBussniess.T_Material;
using IBussniess.T_SalidaMaterial;
using IRepository.T_Material;
using IRepository.T_Produccion;
using IRepository.T_Unidad;
using Repositori.T_Material;
using Repositori.T_Produccion;
using Repositori.T_Unidad;
using RequestRespons.Request.T_Material;
using RequestRespons.Request.T_SalidaMaterial;
using RequestRespons.Response.T_Material;
using RequestRespons.Response.T_SalidaMaterial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_SalidaMaterial
{
    public class SalidaVMaterialBussniess : ISalidaVMaterialBussniess
    {
        #region
        private readonly ISalidaMaterialBussniess _salidaMaterialBussniess;
        private readonly IMaterialBussniess _materialBussniess;
        private readonly IUnidadRespository _unidadRespository;
        private readonly IMaterialRepository _materialRepository;
        private readonly IProduccionRepository _produccionRepository;
        private readonly IMapper _mapper;

        public SalidaVMaterialBussniess (IMapper mapper)
        {
            _mapper = _mapper;
            _salidaMaterialBussniess = new SalidaMaterialBussniess(mapper);
            _materialBussniess = new MaterialBussniess(mapper);
            _unidadRespository = new UnidadRepository();
            _materialRepository = new MaterialRepository();
            _produccionRepository = new ProduccionRepository();

        }

        #endregion
        public ResponseSalidaMaterial Create(RequestVSalIdaMaterial entity)
        {
            ResponseVMaterial responseVMaterial = new ResponseVMaterial();
            ResponseMaterial responseMaterial = new ResponseMaterial();
            ResponseSalidaMaterial responseSalidaMaterial = new ResponseSalidaMaterial();
            Material material = new Material();
            material = _materialRepository.buscarMaterial(entity.NombreMaterial);

            if(material.IdMaterial == 0)

            {
                responseSalidaMaterial.message = "No Existe tal Material";
                return responseSalidaMaterial;

            }
            else
            {
                if(material.Stock==0)
                {
                    responseSalidaMaterial.message = "No Hay Material Por favor haga un pedido al Proveedor";
                    return responseSalidaMaterial;
                }
                else
                {
                    if(entity.Cantidad>material.Stock)
                    {
                        responseSalidaMaterial.message = "Su peticion es mayor al sctock que hay ";
                        return responseSalidaMaterial;
                    }
                    else
                    {
                        if(entity.FechaSalida>DateTime.Now && entity.FechaSalida < DateTime.Now)
                        {
                            responseSalidaMaterial.message = "Su peticion tiene que ser el dia de hoy  ";
                            return responseSalidaMaterial;
                        }
                        else
                        {
                            RequestSalidaMaterial requesSalidaMaterial = new RequestSalidaMaterial();
                            RequestSalidaMaterial requestSalidaMaterial = _mapper.Map<RequestSalidaMaterial>(entity);
                            Produccion produccion = new Produccion();
                            Unidad unidad = new Unidad();
                            produccion = _produccionRepository.BuscarProduccion(entity.CodigoProduccion);
                            unidad = _unidadRespository.BuscarUnidad(entity.NombreUnidad);

                            requestSalidaMaterial.IdProduccion = produccion.IdProduccion;
                            requestSalidaMaterial.IdMaterial = material.IdMaterial;
                            requestSalidaMaterial.IdUnidad = unidad.IdUnidad;

                            ResponseVSalidaMaterial responseVSalidaMaterial1 = _salidaMaterialBussniess.Create(requestSalidaMaterial);
                            material.Stock -= entity.Cantidad;
                            RequestMaterial requestMaterial = _mapper.Map<RequestMaterial>(material);
                            ResponseVMaterial responseVMaterial1 = _materialBussniess.Update(requestMaterial);
                            responseSalidaMaterial = _mapper.Map<ResponseSalidaMaterial>(responseVSalidaMaterial1);
                            responseSalidaMaterial.message = "Se creo La salida del Material";
                            responseSalidaMaterial.salidaMaterials.Add(responseVSalidaMaterial1);
                            return responseSalidaMaterial;

                        }
                    }
                }
            }
            throw new NotImplementedException();
        }

        public List<ResponseSalidaMaterial> CreateMultiple(List<RequestVSalIdaMaterial> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVSalIdaMaterial> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseSalidaMaterial> GetAll()
        {
            throw new NotImplementedException();
        }

        public ResponseSalidaMaterial GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseSalidaMaterial Update(RequestVSalIdaMaterial entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseSalidaMaterial> UpdateMultiple(List<RequestVSalIdaMaterial> lista)
        {
            throw new NotImplementedException();
        }
    }
}
