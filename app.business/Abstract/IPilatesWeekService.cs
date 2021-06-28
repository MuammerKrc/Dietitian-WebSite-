using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IPilatesWeekService
    {
        Task<OprationResult> CreateAsync(PilatesWeek entity);
        OprationResult DeleteAsync(PilatesWeek entity);
        Task<ReturnedClass<PilatesWeek>> GetByIdAsync(int id);
        OprationResult UpdateAsync(PilatesWeek entity);
        Task<ReturnedClass<PilatesWeek>> GetAll();
        Task<ReturnedClass<PilatesWeek>> GetByEntityAsync(PilatesWeek entity);
        Task<ReturnedClass<PilatesWeek>> GetWithIncludeOthers(int id);
        Task<OprationResult> makeIsDone(int weekId);
        Task<OprationResult> makeNotDone(int weekId);
    }
}