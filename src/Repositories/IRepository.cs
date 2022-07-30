using DSCC.CW1._7902.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DSCC.CW1._7902.API.Repository
{
    public interface IRepository<T> where T : class, IModel
    {
        Task<List<T>> Get();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
