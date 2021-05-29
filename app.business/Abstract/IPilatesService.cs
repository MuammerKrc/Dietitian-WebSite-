using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IPilatesService
    {
         Task<OprationResult> CreateAsync(Pilates entity);
        OprationResult DeleteAsync(Pilates entity);
        Task<ReturnedClass<Pilates>> GetByIdAsync(int id);
        Task<OprationResult> UpdateAsync(Pilates entity);
        Task<ReturnedClass<Pilates>> GetAll();
        Task<ReturnedClass<Pilates>> GetByEntityAsync(Pilates entity);
    }
}