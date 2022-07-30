using DSCC.CW1._7902.API.Models;
using DSCC.CW1._7902.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DSCC.CW1._7902.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : BaseController<Employee, EmployeesRepository>
    {
        public EmployeesController(EmployeesRepository repository) : base(repository)
        {

        }
    }
}
