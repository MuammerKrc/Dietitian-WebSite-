using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class GeneralMsjRepository : Repository<GeneralMesaj>, IGeneralMsjRepository
    {
        public GeneralMsjRepository(DbContext context) : base(context)
        {

        }
        private AppContext appContext{get{return context as AppContext;}}
    }
}