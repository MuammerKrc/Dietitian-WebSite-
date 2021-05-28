using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class DietWekklyRepository : Repository<DietWekkly>, IDietWekklyRepository
    {
        public DietWekklyRepository(AppContext _context) : base(_context)
        {
            
        }
        private AppContext appContext { get { return context as AppContext; } }

        
    }
}