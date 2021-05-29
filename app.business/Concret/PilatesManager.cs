using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class PilatesManager : IPilatesService
    {
        private IUnitOfWork work;
        public PilatesManager(IUnitOfWork _work)
        {
            work=_work;
        }
        public Task<OprationResult> CreateAsync(Pilates entity)
        {
            throw new System.NotImplementedException();
        }

        public OprationResult DeleteAsync(Pilates entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Pilates>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Pilates>> GetByEntityAsync(Pilates entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Pilates>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<OprationResult> UpdateAsync(Pilates entity)
        {
            throw new System.NotImplementedException();
        }
    }
}