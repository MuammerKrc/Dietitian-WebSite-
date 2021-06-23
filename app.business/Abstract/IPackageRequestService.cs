using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IPackageRequestService
    {
        Task<OprationResult> CreateAsync(PackageRequest entity);
        Task<OprationResult> DeleteAsync(PackageRequest entity);
        Task<ReturnedClass<PackageRequest>> GetByIdAsync(int id);
        OprationResult UpdateAsync(PackageRequest entity);
        Task<ReturnedClass<PackageRequest>> GetAll();
        Task<ReturnedClass<PackageRequest>> GetByEntityAsync(PackageRequest entity);
        Task<ReturnedClass<PackageRequest>> GetByCustomerId(int id);
    }
}