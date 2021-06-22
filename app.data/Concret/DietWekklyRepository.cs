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
                                    .ThenInclude(m=>m.AnamnezForm)
                                    .AsSplitQuery()                                    

                                    .Include(m=>m.Diet)
                                    .ThenInclude(m=>m.Customer)
                                    .ThenInclude(m=>m.Pilates)
                                    .AsSplitQuery()
                                    
                                    .Include(m=>m.Calendar)
                                    .AsSplitQuery()

                                    .Include(m=>m.DietMenü)
                                    .ThenInclude(m=>m.CombineDietMenüRecipes)
                                    .AsSplitQuery()

                                    .AsNoTracking()
                                    .SingleOrDefaultAsync();
                return new ReturnedClass<DietWekkly>(OprationResult.ok,_value:result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<DietWekkly>(OprationResult.canceled);                
            }
        }

        public async Task<OprationResult> MakeActive(int weekId)
        {
           try
           {
               var cmd="Update DietWekklies set Active=@p0 where Id=@p1";
               var result =await appContext.Database.ExecuteSqlRawAsync(cmd,1,weekId);
               if(result==1)
               {
                   return OprationResult.ok;
               }
               return OprationResult.canceled;
           }
           catch (System.Exception)
           {
                return OprationResult.canceled;
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
                return new ReturnedClass<DietWekkly>(OprationResult.ok,result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<DietWekkly>(OprationResult.canceled);
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
                    
                }
                return new ReturnedClass<DietWekkly>(OprationResult.ok,_value:result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<DietWekkly>(OprationResult.canceled);                
            }
        }
    }
}