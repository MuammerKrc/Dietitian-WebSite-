using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.data.Abstract
{
    public interface IPilatesWeekRepository : IRepository<PilatesWeek>
    {
        Task<ReturnedClass<PilatesWeek>> GetWithIncludeOthers(int id);
        Task<OprationResult> makeIsDone(int weekId);
        Task<OprationResult> makeNotDone(int weekId);

    }
}