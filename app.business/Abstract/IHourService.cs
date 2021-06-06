using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IHourService
    {
        Task<OprationResult> CreateAsync(Hour entity);
        OprationResult DeleteAsync(Hour entity);
        Task<ReturnedClass<Hour>> GetByIdAsync(int id);
        Task<OprationResult> UpdateAsync(Hour entity);
        Task<ReturnedClass<Hour>> GetAll();
        Task<ReturnedClass<Hour>> GetByEntityAsync(Hour entity);
    }
}