using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class GeneralMsjManager : IGeneralMsjService
    {
        private IUnitOfWork work { get; set; }
        public GeneralMsjManager(IUnitOfWork _work)
        {
            work = _work;
        }
        public async Task<OprationResult> CreateAsync(GeneralMesaj entity)
        {
            try
            {
                var result = await work.GeneralMsj.CreateAsync(entity);
                if (result == OprationResult.ok)
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

        public async Task<OprationResult> DeleteAsync(GeneralMesaj entity)
        {
            try
            {
                var result = await work.GeneralMsj.GetByIdAsync(entity.Id);
                if (result.oprationResult == OprationResult.ok)
                {
                    if (result.value != null)
                    {
                        var resultDelete = work.GeneralMsj.DeleteAsync(result.value);
                        if(resultDelete==OprationResult.ok)
                        {
                            var resultSave =await work.SaveAsync();
                            if(resultSave==OprationResult.Saved)
                            {
                                return OprationResult.ok;
                            }
                        }
                    }
                }
                return OprationResult.canceled;
            }
            catch (System.Exception)
            {
                return OprationResult.canceled;
            }
        }

        public async Task<ReturnedClass<GeneralMesaj>> GetAll()
        {
            try
            {
                return await work.GeneralMsj.GetAll();
            }
            catch (System.Exception)
            {
                return new ReturnedClass<GeneralMesaj>(OprationResult.canceled);
            }
        }

        public Task<ReturnedClass<GeneralMesaj>> GetByEntityAsync(GeneralMesaj entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<GeneralMesaj>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public OprationResult UpdateAsync(GeneralMesaj entity)
        {
            throw new System.NotImplementedException();
        }
    }
}