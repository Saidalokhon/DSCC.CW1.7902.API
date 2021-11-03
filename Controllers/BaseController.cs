using DSCC.CW1._7902.API.Models;
using DSCC.CW1._7902.API.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DSCC.CW1._7902.API.Controllers
{
    // Create abstract class for base controller that extends ControllerBase abstract
    // class (which is a base class for an MVC controller without view support).
    // The type constraints are set to TEntity, which is IModel and TRepository, which
    // is IRepository interface
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TModel, TRepository> : ControllerBase
        where TModel : class, IModel
        where TRepository : IRepository<TModel>
    {
        // Create readonly IRepository instance.
        private readonly TRepository _repository;

        // Create constructor which mplements IRepository instance.
        public BaseController(TRepository repository)
        {
            _repository = repository;
        }

        // The following code defines CRUD methods, that use _repository instance
        // to access the SQL database.

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TModel>>> Get()
        {
            return await _repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TModel>> Get(int id)
        {
            var model = await _repository.Get(id);
            if (model == null)
            {
                return NotFound();
            }
            return model;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TModel entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await _repository.Update(entity);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TModel>> Post(TModel entity)
        {
            await _repository.Add(entity);
            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TModel>> Delete(int id)
        {
            var entity = await _repository.Delete(id);
            if (entity == null)
            {
                return NotFound();
            }
            return entity;
        }
    }
}
