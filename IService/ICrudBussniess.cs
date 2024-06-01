using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess
{
    public interface ICrudBussniess <T,Y>:IDisposable
    {
        List<Y> GetAll();
        Y GetById(object id);

        Y Create(T entity);

        Y Update(T entity);

        int Delete(object id);

        List<Y> CreateMultiple(List<T> lista);

        List<Y> UpdateMultiple (List<T> lista);

        int DeleteMultiple (List<T> lista);
       ReponseFilterGeneric <Y> GetByFilter(RequestFilterGeneric request);




    }
}
