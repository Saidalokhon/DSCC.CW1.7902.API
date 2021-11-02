using DSCC.CW1._7902.API.DbContexts;
using DSCC.CW1._7902.API.Models;

namespace DSCC.CW1._7902.API.Repository
{
    // Create PositionsRepository class, that extends BaseRepository. As a
    // generic parameters Posiiton model and Company context are passsed.
    public class PositionsRepository : BaseRepository<Position, CompanyContext>
    {
        public PositionsRepository(CompanyContext context) : base(context)
        {
            
        }
    }
}
