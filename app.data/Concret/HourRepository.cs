using System.Linq;
using System.Threading.Tasks;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class HourRepository : Repository<Hour>, IHourRepository
    {
        public HourRepository(DbContext context) : base(context)
        {

        }

        public AppContext appContext { get { return context as AppContext; } }

        public async Task<ReturnedClass<Hour>> GetDate(int DayId, int startingHour, int finishedHOur,int weekId,string currentHour)
        {
            try
            {
                var result = await appContext.Days.Where(i => i.Id == DayId)
                                                    .Include(i => i.Hours)
                                                    .FirstOrDefaultAsync();

                Hour newDate = new Hour()
                {
                    StartingHour = startingHour,
                    FinishedHour = finishedHOur,
                    DayId = DayId,
                    DietWekklyId=weekId,
                    CurrentHour=currentHour
                };
                foreach (var item in result.Hours)
                {
                    if (((item.StartingHour <= startingHour && item.FinishedHour >= startingHour) || (item.StartingHour <= finishedHOur && item.FinishedHour >= finishedHOur)))
                    {
                        return new ReturnedClass<Hour>(OprationResult.Have, _value: item);
                    }
                }
                var resultCreate = await appContext.Hours.AddAsync(newDate);
                var returnedValue = resultCreate.Entity;
                return new ReturnedClass<Hour>(OprationResult.successful, _value: returnedValue);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Hour>(OprationResult.ineffective);
            }
        }


    }
}