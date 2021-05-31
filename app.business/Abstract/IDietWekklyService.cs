using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IDietWekklyService
    {
        Task<OprationResult> CreateAsync(DietWekkly entity);
        OprationResult DeleteAsync(DietWekkly entity);
        Task<ReturnedClass<DietWekkly>> GetByIdAsync(int id);
        Task<OprationResult> UpdateAsync(DietWekkly entity);
        Task<ReturnedClass<DietWekkly>> GetAll();
        Task<ReturnedClass<DietWekkly>> GetByEntityAsync(DietWekkly entity);
        Task<ReturnedClass<DietWekkly>> GetByIDWithDietMenü(int? id);
        Task<ReturnedClass<DietWekkly>> UpdateJustDietMenü(int dietWeekId,int dietid);

    }
}