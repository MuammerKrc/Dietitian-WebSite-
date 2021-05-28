using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class DietWekklyManager : IDietWekklyService
    {
        private IUnitOfWork work;
        public DietWekklyManager(IUnitOfWork _work)
        {
            work = _work;
        }
        public async Task<OprationResult> CreateAsync(DietWekkly entity)
        {
            try
            {
                var result=await work.DietWekkly.CreateAsync(entity);
                await work.SaveAsync();
                return OprationResult.ok;
            
            }
            catch (System.Exception)
            {
                return OprationResult.NotSaved;
            }
        }

        public OprationResult DeleteAsync(DietWekkly entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<DietWekkly>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<DietWekkly>> GetByEntityAsync(DietWekkly entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<DietWekkly>> GetByIdAsync(int id)
        {
            return await work.DietWekkly.GetByIdAsync(id);
        }

        public OprationResult UpdateAsync(DietWekkly entity)
        {
            throw new System.NotImplementedException();
        }
    }
}