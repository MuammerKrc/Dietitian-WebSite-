using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IGeneralMsjService
    {
        Task<OprationResult> CreateAsync(GeneralMesaj entity);
        Task<OprationResult> DeleteAsync(GeneralMesaj entity);
        Task<ReturnedClass<GeneralMesaj>> GetByIdAsync(int id);
        OprationResult UpdateAsync(GeneralMesaj entity);
        Task<ReturnedClass<GeneralMesaj>> GetAll();
        Task<ReturnedClass<GeneralMesaj>> GetByEntityAsync(GeneralMesaj entity);
    }
}