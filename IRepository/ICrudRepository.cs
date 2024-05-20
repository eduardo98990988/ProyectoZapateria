using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface ICrudRepository<T> : IDisposable
    {
        List<T> GetAll();

        T Create(T entity);
        T Update(T entity);

        T GetByID(object id);
        int Delete (object id);

        List<T> CreateMultiple(List<T> lista);

        List<T> UpdateMultiple(List<T> lista);

        int DeleteMultiple(List<T> lista);

        ReponseFilterGeneric<T> GetByFilter(RequestFilterGeneric request);

    }
}
