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
    }
}