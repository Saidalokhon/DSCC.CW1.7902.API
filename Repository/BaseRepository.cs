using DSCC.CW1._7902.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DSCC.CW1._7902.API.Repository
{
    // Create abstract class for base repository that implements IRepository interface.
    // The type constraints are set to TEntity, which is IModel and TContext, which is
    // DbContext.
    public abstract class BaseRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IModel
        where TContext : DbContext
    {
        // Create readonly DbContext instance.
        private readonly TContext _context;

        // Create constructor which mplements DbContext instance.
        public BaseRepository(TContext context)
        {
            _context = context;
        }

        // 'Create'
        public async Task<TEntity> Add(TEntity entity)
        {
            // Set TEntity to specific model class (Employee, Position).
            _context.Set<TEntity>().Add(entity);
            // Save changes that are made.
            await _context.SaveChangesAsync();
            // Return the model.
            return entity;
        }

        // 'Delete'
        public async Task<TEntity> Delete(int id)
        {
            // Set TEntity to specific model class and find the data by its Id.
            var entity = await _context.Set<TEntity>().FindAsync(id);
            // If entity is not present in the database, return null.
            if (entity == null)
            {
                return entity;
            }

            // Otherwise, remove it.
            _context.Set<TEntity>().Remove(entity);
            // Save changes that are made.
            await _context.SaveChangesAsync();

            // Return the model.
            return entity;
        }

        // 'Retrieve'
        public async Task<TEntity> Get(int id)
        {
            // Set TEntity to specific model class, find the data by its Id, and return it.
            return await _context.Set<TEntity>().FindAsync(id);
        }

        // 'Retrieve all'
        public async Task<List<TEntity>> GetAll()
        {
            // Set TEntity to specific model class, get all the data, and return it as a List.
            return await _context.Set<TEntity>().ToListAsync();
        }

        // 'Update'
        public async Task<TEntity> Update(TEntity entity)
        {
            // Set model's state as 'Modified'.
            _context.Entry(entity).State = EntityState.Modified;
            // Save changes that are made.
            await _context.SaveChangesAsync();
            // Return the model.
            return entity;
        }
    }
}
