using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class AnamnezManager : IAnamnezFormService
    {
        private IUnitOfWork work;
        public AnamnezManager(IUnitOfWork _work)
        {
            work = _work;
        }
        public async Task<OprationResult> CreateAsync(AnamnezForm entity)
        {
            try
            {
                var result =await work.AnamnezForm.CreateAsync(entity);
                if(result==OprationResult.ok)
                {
                    var SaveResult =await work.SaveAsync();
                    if(SaveResult==OprationResult.Saved)
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

        

        public OprationResult DeleteAsync(AnamnezForm entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<AnamnezForm>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<AnamnezForm>> GetByEntityAsync(AnamnezForm entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<AnamnezForm>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }


        public async Task<OprationResult> UpdateAsync(AnamnezForm entity)
        {
            try
            {
                var DataResult = work.AnamnezForm.UpdateAsync(entity);
                if(DataResult!=OprationResult.ok)
                {
                    return OprationResult.canceled;
                }
                var SaveResult = await work.SaveAsync();
                if(SaveResult!=OprationResult.Saved)
                {
                    return OprationResult.canceled;
                }
                return OprationResult.ok;
            }
            catch (System.Exception)
            {
                return OprationResult.canceled;
            }
        }
    }
}