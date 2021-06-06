using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class HourManager : IHourService
    {
        private IUnitOfWork work;
        public HourManager(IUnitOfWork _unitOfWork)
        {
            work=_unitOfWork;
        }

        

        public Task<OprationResult> CreateAsync(Hour entity)
        {
            throw new System.NotImplementedException();
        }

        public OprationResult DeleteAsync(Hour entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Hour>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Hour>> GetByEntityAsync(Hour entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Hour>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<OprationResult> UpdateAsync(Hour entity)
        {
            throw new System.NotImplementedException();
        }
    }
}