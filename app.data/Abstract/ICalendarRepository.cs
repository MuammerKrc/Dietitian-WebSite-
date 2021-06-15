using System;
using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.data.Abstract
{
    public interface ICalendarRepository : IRepository<Calendar>
    {
        Task<OprationResult> CheckDate(Calendar c);
        Task<ReturnedClass<Calendar>> GetDates(DateTime day);

    }
}