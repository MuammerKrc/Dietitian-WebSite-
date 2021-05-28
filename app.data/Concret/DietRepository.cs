using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class DietRepository : Repository<Diet>, IDietRepository
    {
        public DietRepository(AppContext context) : base(context)
        {

        }
        private AppContext appContext{get{return context as AppContext;}}


    }
}