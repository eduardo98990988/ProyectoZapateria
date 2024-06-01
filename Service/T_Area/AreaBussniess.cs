using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Area;
using IRepository.T_Area;
using Repositori.T_Area;
using RequestRespons.Request.T_Area;
using RequestRespons.Response.T_Area;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Area
{
    public class AreaBussniess : IAreaBussniess
    {
        #region Inyeccion de Dependencias

        private readonly IAreaRepository _AreaRepository;
        private readonly IMapper _mapper;

        public AreaBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _AreaRepository = new AreaRepository();

        }

        public ResponseArea Create(RequestArea entity)
        {
            Area Area = _mapper.Map<Area>(entity);
            Area = _AreaRepository.Create(Area);
            ResponseArea responseArea = _mapper.Map<ResponseArea>(Area);
            return responseArea;
        }

        public List<ResponseArea> CreateMultiple(List<RequestArea> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _AreaRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestArea> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseArea> GetAll()
        {
            List<Area> Area = _AreaRepository.GetAll();
            List<ResponseArea> responseArea = _mapper.Map<List<ResponseArea>>(Area);
            return responseArea;

        }

        public ReponseFilterGeneric<ResponseArea> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseArea GetById(object id)
        {
            Area Area = _AreaRepository.GetByID(id);
            ResponseArea responseArea = _mapper.Map<ResponseArea>(Area);
            return responseArea;

        }

        public ResponseArea Update(RequestArea entity)
        {
            Area Area = _mapper.Map<Area>(entity);
            Area = _AreaRepository.Update(Area);
            ResponseArea responseArea = _mapper.Map<ResponseArea>(Area);
            return responseArea;
        }

        public List<ResponseArea> UpdateMultiple(List<RequestArea> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
