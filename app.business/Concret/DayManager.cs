using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class DayManager : IDayService
    {
        private IUnitOfWork work;
        public DayManager(IUnitOfWork _work)
        {
            work=_work;
        }

        public Task<OprationResult> CreateAsync(Day entity)
        {
            throw new System.NotImplementedException();
        }

        public OprationResult DeleteAsync(Day entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Day>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Day>> GetByEntityAsync(Day entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Day>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<OprationResult> UpdateAsync(Day entity)
        {
            throw new System.NotImplementedException();
        }
    }
}