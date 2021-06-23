using System.Linq;
using System.Threading.Tasks;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class PackageRequestRepository:Repository<PackageRequest>, IPackageRequestRepository
    {
        public PackageRequestRepository(DbContext context):base(context)
        {
            
        }
        private AppContext appContext{get{return context as AppContext;}}

        public async Task<ReturnedClass<PackageRequest>> GetByCustomerId(int id)
        {
            try
            {
                var reuslt =await appContext.packageRequests.Where(i=>i.CustomerId==id).ToListAsync();
                return new ReturnedClass<PackageRequest>(OprationResult.ok,_values:reuslt);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<PackageRequest>(OprationResult.canceled);                
            }
        }
    }
}