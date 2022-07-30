using DSCC.CW1._7902.API.Models;
using DSCC.CW1._7902.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DSCC.CW1._7902.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : BaseController<Position, PositionsRepository>
    {
        public PositionsController(PositionsRepository repository) : base(repository)
        {

        }
    }
}
