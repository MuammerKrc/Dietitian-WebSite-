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

        public async Task<OprationResult> DeleteAsync(PackageRequest entity)
        {
            try
            {
                var result =work.packageRequest.DeleteAsync(entity);
                if(result==OprationResult.ok)
                {
                    var saveResult =await work.SaveAsync();
                    if(saveResult==OprationResult.Saved)
                    {
                        return OprationResult.ok;
                    }

                }   
                return OprationResult.canceled;
            }
            catch (System.Exception)
            {
                
                throw;
            }
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

        public async Task<ReturnedClass<PackageRequest>> GetByIdAsync(int id)
        {
            try
            {
                var result =await work.packageRequest.GetByIdAsync(id);
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<PackageRequest>(OprationResult.canceled);                
            }
        }

        public OprationResult UpdateAsync(PackageRequest entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<PackageRequest>> GetByCustomerId(int id)
        {
            try
            {
                var reuslt =await  work.packageRequest.GetByCustomerId(id);
                return reuslt;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}