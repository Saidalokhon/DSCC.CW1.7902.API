using DSCC.CW1._7902.API.Models;
using DSCC.CW1._7902.API.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DSCC.CW1._7902.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<T> : ControllerBase
        where T : class, IModel
    {
        private readonly IRepository<T> _repository;

        public BaseController(IRepository<T> repository)
        {
            _repository = repository;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T>>> Get() =>
            await _repository.Get();

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<T>> Get(int id) =>
            await _repository.Get(id) is null ? NotFound() : await _repository.Get(id);

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<ActionResult<T>> Put(int id, T entity) =>
            id != entity.Id ? BadRequest() : await _repository.Update(entity);

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<T>> Post(T entity) =>
            await _repository.Add(entity);

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<T>> Delete(int id) => 
            await _repository.Delete(id) is null ? NotFound() : await _repository.Delete(id);
    }
}
