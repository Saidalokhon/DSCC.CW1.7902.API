using DSCC.CW1._7902.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DSCC.CW1._7902.API.DbContexts
{
    // Create database context class that inherits DbContext instance
    public class CompanyContext : DbContext
    {
        // Create constructor for CompanyContext class
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        // Add DbSets (Positions, Employees tables)
        public DbSet<Position> Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
