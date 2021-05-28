using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class PilatesRepository : Repository<Pilates>, IPilatesRepository
    {
        public PilatesRepository(AppContext context) : base(context)
        {

        }
        private AppContext AppContext { get { return context as AppContext; } }


    }
}