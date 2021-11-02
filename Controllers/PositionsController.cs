using DSCC.CW1._7902.API.Models;
using DSCC.CW1._7902.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DSCC.CW1._7902.API.Controllers
{
    // Create PositionsController class, that extends BaseController. As a
    // generic parameters Position model and PositionsRepository are passsed.

    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : BaseController<Position, PositionsRepository>
    {
        public PositionsController(PositionsRepository repository) : base(repository)
        {

        }
    }
}
