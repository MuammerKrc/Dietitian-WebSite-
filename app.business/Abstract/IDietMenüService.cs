using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IDietMenüService
    {
        Task<OprationResult> CreateAsync(DietMenü entity);
        OprationResult DeleteAsync(DietMenü entity);
        Task<ReturnedClass<DietMenü>> GetByIdAsync(int id);
        Task<OprationResult> UpdateAsync(DietMenü entity);
        Task<ReturnedClass<DietMenü>> GetAll();
        Task<ReturnedClass<DietMenü>> GetByEntityAsync(DietMenü entity);
    }
}