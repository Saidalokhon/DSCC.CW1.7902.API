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
        private T entity;

        public BaseController(IRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<T>>> Get() =>
            await _repository.Get();

        [HttpGet("{id}")]
        public async Task<ActionResult<T>> Get(int id) =>
            null != (entity = await _repository.Get(id)) ? NotFound() : entity;

        [HttpPut("{id}")]
        public async Task<ActionResult<T>> Put(int id, T entity) =>
            id != entity.Id ? BadRequest(entity) : await _repository.Update(entity);

        [HttpPost]
        public async Task<ActionResult<T>> Post(T entity) =>
            await _repository.Add(entity);

        [HttpDelete("{id}")]
        public async Task<ActionResult<T>> Delete(int id) => 
            null != (entity = await _repository.Delete(id)) ? NotFound() : entity;
    }
}
