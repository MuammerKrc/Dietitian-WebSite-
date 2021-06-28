using System.Linq;
using System.Threading.Tasks;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class PilatesWeekRepository : Repository<PilatesWeek>, IPilatesWeekRepository
    {
        public PilatesWeekRepository(DbContext context) : base(context)
        {
        }
        private AppContext appContext { get { return context as AppContext; } }

        public async Task<ReturnedClass<PilatesWeek>> GetWithIncludeOthers(int id)
        {
            try
            {
                var result = await appContext.PilatesWeeks
                                    .Where(m => m.Id == id)
                                    .Include(m => m.calendar)
                                    .AsSplitQuery()

                                    .Include(m => m.Pilates)
                                    .ThenInclude(m => m.Customer)
                                    .ThenInclude(m => m.Diet)
                                    .ThenInclude(m => m.AnamnezForm)
                                    .AsSplitQuery()

                                    .AsNoTracking()
                                    .SingleOrDefaultAsync();


                return new ReturnedClass<PilatesWeek>(OprationResult.ok, _value: result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<PilatesWeek>(OprationResult.canceled);
            }
        }
        public async Task<OprationResult> makeIsDone(int weekId)
        {
            try
            {
                var cmd = "Update PilatesWeeks set IsDone=1 where Id=@p0";
                var result = await appContext.Database.ExecuteSqlRawAsync(cmd, weekId);
                if (result == 1)
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
        public async Task<OprationResult> makeNotDone(int weekId)
        {
            try
            {
                var cmd = "Update PilatesWeeks set IsDone=0 where Id=@p0";
                var result = await appContext.Database.ExecuteSqlRawAsync(cmd, weekId);
                if (result == 1)
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
    }
}