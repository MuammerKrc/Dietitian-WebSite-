using System;
using System.Linq;
using System.Threading.Tasks;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class CalendarRepository : Repository<Calendar>, ICalendarRepository
    {
        public CalendarRepository(AppContext context) : base(context)
        {

        }
        private AppContext appContext { get { return context as AppContext; } }

        public async Task<OprationResult> CheckDate(Calendar c)
        {
            try
            {
                var result = await appContext.Calendars.Where(i => i.CurrentYear == c.CurrentYear && i.CurrentMounth == c.CurrentMounth && i.CurrentDay == c.CurrentDay).ToListAsync();
                bool temp = false;

                if (result != null)
                {
                    if (result.Count > 0)
                    {
                        foreach (var item in result)
                        {
                            if (((item.StartingHour < c.StartingHour && item.FinishedHour > c.StartingHour) || (item.StartingHour < c.FinishedHour && item.FinishedHour > c.FinishedHour)))
                            {
                                temp = true;
                                break;
                            }
                        }
                    }
                }
                if (temp)
                {
                    return OprationResult.canceled;
                }
                return OprationResult.ok;
            }
            catch (System.Exception)
            {
                return OprationResult.canceled;
            }
        }

        public async Task<ReturnedClass<Calendar>> GetDates(DateTime Time)
        {
            try
            {
                var result = appContext.Calendars.Where(i => i.CurrentYear == Time.Year).AsQueryable();

                result=result.Where(i=>i.CurrentMounth==Time.Month).AsQueryable();
                result=result.Where(i=>i.CurrentDay==Time.Day);

                var k=await result.ToListAsync();


                return new ReturnedClass<Calendar>(OprationResult.ok, _values: k);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Calendar>(OprationResult.canceled);
            }
        }
    }
}