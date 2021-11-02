using DSCC.CW1._7902.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DSCC.CW1._7902.API.Repository
{
    // Create interface for repositories. In this project Generic Repository Pattern
    // was implemented. The type (T) constraint must be a reference type. In this 
    // case it is IModel interface.
    public interface IRepository<T> where T : class, IModel
    {
        // Add required CRUD methods.
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
