using DSCC.CW1._7902.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DSCC.CW1._7902.API.Repository
{
    public abstract class BaseRepository<TModel, TContext> : IRepository<TModel>
        where TModel : class, IModel
        where TContext : DbContext
    {
        private readonly TContext _context;

        public BaseRepository(TContext context)
        {
            _context = context;
        }

        public async Task<TModel> Add(TModel entity)
        {
            _context.Set<TModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        
        public async Task<TModel> Delete(int id)
        {
            var entity = await _context.Set<TModel>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _context.Set<TModel>().Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
        
        public async Task<TModel> Get(int id)
        {
            return await _context.Set<TModel>().FindAsync(id);
        }
        
        public async Task<List<TModel>> GetAll()
        {
            return await _context.Set<TModel>().ToListAsync();
        }
        
        public async Task<TModel> Update(TModel entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
