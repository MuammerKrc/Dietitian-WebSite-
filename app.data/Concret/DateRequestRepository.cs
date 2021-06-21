using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class DateRequestRepository : Repository<DateRequest>, IDateRequestRepository
    {
        public DateRequestRepository(DbContext _context) : base(_context)
        {

        }
        private AppContext appContext{get{return context as AppContext;}}

    }
}