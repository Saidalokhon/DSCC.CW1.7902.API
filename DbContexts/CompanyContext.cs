using DSCC.CW1._7902.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DSCC.CW1._7902.API.DbContexts
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        public DbSet<Position> Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
