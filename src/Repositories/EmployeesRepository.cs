using DSCC.CW1._7902.API.Data;
using DSCC.CW1._7902.API.Models;

namespace DSCC.CW1._7902.API.Repository
{
    public class EmployeesRepository : BaseRepository<Employee>
    {

        public EmployeesRepository(CompanyContext context) : base(context)
        {

        }
    }
}