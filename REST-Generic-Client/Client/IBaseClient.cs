using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_Generic_Client.Client
{
    public interface IBaseClient<T> : IDisposable
    {
        Task<List<T>> GetAll();

        Task<T> Get(int? id);

        Task Create(T item);

        Task Update(int? id, T item);

        Task Delete(int id);
    }
}
