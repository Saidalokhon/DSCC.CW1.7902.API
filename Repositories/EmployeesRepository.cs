using DSCC.CW1._7902.API.DbContexts;
using DSCC.CW1._7902.API.Models;

namespace DSCC.CW1._7902.API.Repository
{
    // Create EmployeesRepository class, that extends BaseRepository. As a
    // generic parameters Employee model and Company context are passsed.
    public class EmployeesRepository : BaseRepository<Employee, CompanyContext>
    {

        public EmployeesRepository(CompanyContext context) : base(context)
        {

        }
    }
}