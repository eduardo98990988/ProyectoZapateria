using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Persona;
using IRepository.T_Persona;
using Repositori.T_Persona;
using RequestResponse.Request.T_Persona;
using RequestResponse.Response.T_Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Persona
{
    public class PersonaBussniess : IPersonaBussniess
    {
        #region Inyeccion de Dependencias
        private readonly IPersonaRepository _personaRepository;
        private readonly IMapper _mapper;

        public PersonaBussniess (IMapper mapper)
        {
            _mapper = mapper;
            _personaRepository = new PersonaRepository ();

        }

        #endregion Fin Inyeccion de Dependencias
        public ResponsePersona Create(RequestPersona entity)
        {
            Persona persona = _mapper.Map<Persona>(entity);
            persona = _personaRepository.Create(persona);
            ResponsePersona responsePersona = _mapper.Map<ResponsePersona>(persona);
            return responsePersona;
            
        }

        public List<ResponsePersona> CreateMultiple(List<RequestPersona> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestPersona> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponsePersona> GetAll()
        {
            List<Persona> persona = _personaRepository.GetAll();
            List<ResponsePersona> responsePersona = _mapper.Map<List<ResponsePersona>>(persona);
            return responsePersona;
        }

        public ResponsePersona GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponsePersona Update(RequestPersona entity)
        {
            Persona persona = _mapper.Map<Persona>(entity);
            persona = _personaRepository.Update(persona);
            ResponsePersona responsePersona = _mapper.Map<ResponsePersona>(persona);
            return responsePersona;
        }

        public List<ResponsePersona> UpdateMultiple(List<RequestPersona> lista)
        {
            throw new NotImplementedException();
        }
    }
}
