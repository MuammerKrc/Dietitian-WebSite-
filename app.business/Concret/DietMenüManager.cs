using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class DietMenüManager : IDietMenüService
    {
        private IUnitOfWork work;
        public DietMenüManager(IUnitOfWork _work)
        {
            work=_work;
        }
        public Task<OprationResult> CreateAsync(DietMenü entity)
        {
            throw new System.NotImplementedException();
        }

        public OprationResult DeleteAsync(DietMenü entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<DietMenü>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<DietMenü>> GetByEntityAsync(DietMenü entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<DietMenü>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<OprationResult> UpdateAsync(DietMenü entity)
        {
            throw new System.NotImplementedException();
        }
    }
}