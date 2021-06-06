using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IDayService
    {
        Task<OprationResult> CreateAsync(Day entity);
        OprationResult DeleteAsync(Day entity);
        Task<ReturnedClass<Day>> GetByIdAsync(int id);
        Task<OprationResult> UpdateAsync(Day entity);
        Task<ReturnedClass<Day>> GetAll();
        Task<ReturnedClass<Day>> GetByEntityAsync(Day entity);
    }
}