using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.data.Abstract
{
    public interface IPackageRequestRepository:IRepository<PackageRequest>
    {
        Task<ReturnedClass<PackageRequest>> GetByCustomerId(int id);
    }
}