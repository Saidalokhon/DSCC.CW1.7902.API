using DSCC.CW1._7902.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DSCC.CW1._7902.API.Repository
{
    // Create abstract class for base repository that implements IRepository interface.
    // The type constraints are IModel and TContext, which is DbContext.
    public abstract class BaseRepository<TModel, TContext> : IRepository<TModel>
        where TModel : class, IModel
        where TContext : DbContext
    {
        #region Private variables and constructor
        // Create readonly DbContext instance.
        private readonly TContext _context;

        // Create constructor which mplements DbContext instance.
        public BaseRepository(TContext context)
        {
            _context = context;
        }
        #endregion
        #region Create
        // 'Create'
        public async Task<TModel> Add(TModel entity)
        {
            // Set TModel to specific model class (Employee, Position).
            _context.Set<TModel>().Add(entity);
            // Save changes that are made.
            await _context.SaveChangesAsync();
            // Return the model.
            return entity;
        }
        #endregion
        #region Delete
        // 'Delete'
        public async Task<TModel> Delete(int id)
        {
            // Set TModel to specific model class and find the data by its Id.
            var entity = await _context.Set<TModel>().FindAsync(id);
            // If entity is not present in the database, return null.
            if (entity == null)
            {
                return entity;
            }

            // Otherwise, remove it.
            _context.Set<TModel>().Remove(entity);
            // Save changes that are made.
            await _context.SaveChangesAsync();

            // Return the model.
            return entity;
        }
        #endregion
        #region Retrieve
        // 'Retrieve'
        public async Task<TModel> Get(int id)
        {
            // Set TModel to specific model class, find the data by its Id, and return it.
            return await _context.Set<TModel>().FindAsync(id);
        }
        #endregion
        #region Retrieve all
        // 'Retrieve all'
        public async Task<List<TModel>> GetAll()
        {
            // Set TModel to specific model class, get all the data, and return it as a List.
            return await _context.Set<TModel>().ToListAsync();
        }
        #endregion
        #region Update
        // 'Update'
        public async Task<TModel> Update(TModel entity)
        {
            // Set model's state as 'Modified'.
            _context.Entry(entity).State = EntityState.Modified;
            // Save changes that are made.
            await _context.SaveChangesAsync();
            // Return the model.
            return entity;
        }
        #endregion
    }
}
