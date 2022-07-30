using DSCC.CW1._7902.API.DbContexts;
using DSCC.CW1._7902.API.Models;

namespace DSCC.CW1._7902.API.Repository
{
    public class PositionsRepository : BaseRepository<Position, CompanyContext>
    {
        public PositionsRepository(CompanyContext context) : base(context)
        {

        }
    }
}