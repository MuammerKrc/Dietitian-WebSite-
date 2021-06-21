using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IAnamnezFormService
    {
        Task<OprationResult> CreateAsync(AnamnezForm entity);
        OprationResult DeleteAsync(AnamnezForm entity);
        Task<ReturnedClass<AnamnezForm>> GetByIdAsync(int id);
        Task<OprationResult> UpdateAsync(AnamnezForm entity);
        Task<ReturnedClass<AnamnezForm>> GetAll();
        Task<ReturnedClass<AnamnezForm>> GetByEntityAsync(AnamnezForm entity);

    }
}