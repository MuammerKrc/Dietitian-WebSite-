using System.Linq;
using System.Threading.Tasks;
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

        public async Task<ReturnedClass<DietWekkly>> GetByIDWithDietMenü(int id)
        {
            try
            {
                var result =await appContext.DietWekklies
                                    .Where(m=>m.Id==id)
                                    
                                    .Include(m=>m.Diet)
                                    .ThenInclude(m=>m.Customer)
                                    .AsSplitQuery()
                                    
                                    .Include(m=>m.DietMenü)
                                    .ThenInclude(m=>m.CombineDietMenüRecipes)
                                    .AsSplitQuery()

                                    .AsNoTracking()
                                    .SingleOrDefaultAsync();
                return new ReturnedClass<DietWekkly>(OprationResult.successful,_value:result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<DietWekkly>(OprationResult.ineffective);                
            }
        }

        public async Task<ReturnedClass<DietWekkly>> UpdateJustDate(int dietWeekId, string CurrentHour)
        {
            try
            {
                var result =await appContext.DietWekklies
                                            .FirstOrDefaultAsync(i=>i.Active);
                if(result!=null)
                {
                    result.DateTime=CurrentHour;
                    result.GivedDate=true;
                }
                return new ReturnedClass<DietWekkly>(OprationResult.successful,result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<DietWekkly>(OprationResult.ineffective);
            }
        }

        public async Task<ReturnedClass<DietWekkly>> UpdateJustDietMenü(int dietWeekId,int dietid)
        {
            try
            {
                var result =await appContext.DietWekklies
                                            .Where(i=>i.Id==dietWeekId)
                                            .Include(m=>m.DietMenü)
                                            .FirstOrDefaultAsync();

                if(result!=null)
                {
                    
                    result.DietMenüId=dietid;                    
                }
                return new ReturnedClass<DietWekkly>(OprationResult.successful,_value:result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<DietWekkly>(OprationResult.ineffective);                
            }
        }
    }
}