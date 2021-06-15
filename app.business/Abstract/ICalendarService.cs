using System;
using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface ICalendarService
    {
        Task<OprationResult> CreateAsync(Calendar entity);
        Task<OprationResult> DeleteAsync(Calendar entity);
        Task<ReturnedClass<Calendar>> GetByIdAsync(int id);
        Task<OprationResult> UpdateAsync(Calendar entity);
        Task<ReturnedClass<Calendar>> GetAll();
        Task<ReturnedClass<Calendar>> GetByEntityAsync(Calendar entity);
        Task<OprationResult> MakeDate(Calendar c);
        Task<ReturnedClass<Calendar>> GetDates(DateTime day);

    }
}