using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class PackageRequestManager : IPackageRequestService
    {
        public PackageRequestManager(IUnitOfWork _work)
        {
            work = _work;
        }
        private IUnitOfWork work;
        public async Task<OprationResult> CreateAsync(PackageRequest entity)
        {
            try
            {
                var result =await work.packageRequest.CreateAsync(entity);
                if(result==OprationResult.ok)
                {
                    var resultSave =await work.SaveAsync();
                    if(resultSave==OprationResult.Saved)
                    {
                        return OprationResult.ok;
                    }
                }
                return OprationResult.canceled;
            }
            catch (System.Exception)
            {
                return OprationResult.canceled;                
            }
        }

        public OprationResult DeleteAsync(PackageRequest entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<PackageRequest>> GetAll()
        {
            try
            {
                var result =await work.packageRequest.GetAll();
                if(result.oprationResult==OprationResult.ok)
                {
                    result.oprationResult=OprationResult.ok;
                    return result;
                }
                result.oprationResult=OprationResult.canceled;
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<PackageRequest>(OprationResult.canceled);
            }
        }

        public Task<ReturnedClass<PackageRequest>> GetByEntityAsync(PackageRequest entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<PackageRequest>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public OprationResult UpdateAsync(PackageRequest entity)
        {
            throw new System.NotImplementedException();
        }
    }
}