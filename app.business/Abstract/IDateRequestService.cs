using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IDateRequestService
    {
        Task<OprationResult> CreateAsync(DateRequest entity);
        Task<OprationResult> DeleteAsync(DateRequest entity);
        Task<ReturnedClass<DateRequest>> GetByIdAsync(int id);
        OprationResult UpdateAsync(DateRequest entity);
        Task<ReturnedClass<DateRequest>> GetAll();
        Task<ReturnedClass<DateRequest>> GetByEntityAsync(DateRequest entity);
    }
}