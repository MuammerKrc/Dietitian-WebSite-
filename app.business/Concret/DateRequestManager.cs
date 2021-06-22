using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class DateRequestManager : IDateRequestService
    {
        private readonly IUnitOfWork work;
        public DateRequestManager(IUnitOfWork _unitOfWork)
        {
            work = _unitOfWork;
        }
        public async Task<OprationResult> CreateAsync(DateRequest entity)
        {
            try
            {
                var CreateResult = await work.DateRequest.CreateAsync(entity);
                if (CreateResult == OprationResult.ok)
                {
                    var SaveResult = await work.SaveAsync();
                    if (SaveResult == OprationResult.Saved)
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

        public OprationResult DeleteAsync(DateRequest entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<DateRequest>> GetAll()
        {
            try
            {
                var result = await work.DateRequest.GetAll();
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<DateRequest>(OprationResult.canceled);
            }
        }

        public Task<ReturnedClass<DateRequest>> GetByEntityAsync(DateRequest entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<DateRequest>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public OprationResult UpdateAsync(DateRequest entity)
        {
            throw new System.NotImplementedException();
        }
    }
}