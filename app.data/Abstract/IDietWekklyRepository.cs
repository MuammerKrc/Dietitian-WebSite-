using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.data.Abstract
{
    public interface IDietWekklyRepository:IRepository<DietWekkly>
    {
        Task<ReturnedClass<DietWekkly>> GetByIDWithDietMenü(int id);
        Task<ReturnedClass<DietWekkly>> UpdateJustDietMenü(int dietWeekId,int dietid);
        Task<ReturnedClass<DietWekkly>> UpdateJustDate(int dietWeekId,string CurrentHour);
        Task<OprationResult> MakeActive(int weekId);
    }
}