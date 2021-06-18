using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IMyCartService
    {
        Task<OprationResult> CreateAsync(MyCart entity);
        OprationResult DeleteAsync(MyCart entity);
        Task<ReturnedClass<MyCart>> GetByIdAsync(int id);
        OprationResult UpdateAsync(MyCart entity);
        Task<ReturnedClass<MyCart>> GetAll();
        Task<ReturnedClass<MyCart>> GetByEntityAsync(MyCart entity);
    }
}