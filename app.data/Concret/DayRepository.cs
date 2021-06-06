using System.Linq;
using System.Threading.Tasks;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class DayRepository : Repository<Day>, IDayRepository
    {
        public DayRepository(DbContext context) : base(context)
        {

        }
        private AppContext appContext { get { return context as AppContext; } }

        public async Task<ReturnedClass<Day>> CheckAndCreate(int _MounthId, int Day)
        {
            try
            {
                var result = await appContext.Mounths.Where(i => i.Id == _MounthId)
                                                    .Include(m => m.Days)
                                                    .AsSplitQuery()
                                                    .FirstOrDefaultAsync();
                Day day = new Day()
                {
                    CurrentDay = Day,
                    MounthId = _MounthId
                };
                if (result != null)
                {
                    foreach (var item in result.Days)
                    {
                        if (item.CurrentDay == Day)
                        {
                            return new ReturnedClass<Day>(OprationResult.Have, item);
                        }
                    }
                }
                var resultDays = await appContext.Days.AddAsync(day);
                var registerDays = resultDays.Entity;
                return new ReturnedClass<Day>(OprationResult.ok,registerDays);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Day>(OprationResult.ineffective);
            }
        }
    }
}