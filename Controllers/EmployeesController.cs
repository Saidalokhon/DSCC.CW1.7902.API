using DSCC.CW1._7902.API.Models;
using DSCC.CW1._7902.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DSCC.CW1._7902.API.Controllers
{
    // Create EmployeesController class, that extends BaseController. As a
    // generic parameters Employee model and EmployeesRepository are passsed.

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : BaseController<Employee, EmployeesRepository>
    {
        public EmployeesController(EmployeesRepository repository) : base(repository)
        {

        }
    }
}
