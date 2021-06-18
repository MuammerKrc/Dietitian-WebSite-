using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class MyCartRepository : Repository<MyCart>, IMyCartRepository
    {
        public MyCartRepository(DbContext context) : base(context)
        {
        }
        private AppContext appContext{get{return context as AppContext;}}
    }
}