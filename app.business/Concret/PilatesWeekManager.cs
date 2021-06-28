using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class PilatesWeekManager : IPilatesWeekService
    {
        private readonly IUnitOfWork work;
        public PilatesWeekManager(IUnitOfWork _work)
        {
            work = _work;
        }
        public async Task<OprationResult> CreateAsync(PilatesWeek entity)
        {
            try
            {
                var resultCreate = await work.PilatesWeek.CreateAsync(entity);
                if (resultCreate == OprationResult.ok)
                {
                    var resultSave = await work.SaveAsync();
                    if (resultSave == OprationResult.Saved)
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

        public OprationResult DeleteAsync(PilatesWeek entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<PilatesWeek>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<PilatesWeek>> GetByEntityAsync(PilatesWeek entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<PilatesWeek>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<PilatesWeek>> GetWithIncludeOthers(int id)
        {
            try
            {
                var reuslt = await work.PilatesWeek.GetWithIncludeOthers(id);
                return reuslt;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public async Task<OprationResult> makeIsDone(int weekId)
        {
            try
            {
                var result = await work.PilatesWeek.makeIsDone(weekId);
                if (result == OprationResult.ok)
                {
                    var SaveResult = await work.SaveAsync();
                    if (SaveResult == OprationResult.Saved)
                    {
                        return OprationResult.ok;
                    }
                }
                return result;
            }
            catch (System.Exception)
            {
                return OprationResult.canceled;
            }
        }

        public async Task<OprationResult> makeNotDone(int weekId)
        {
            try
            {
                try
                {
                    var result = await work.PilatesWeek.makeNotDone(weekId);
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
            catch (System.Exception)
            {

                throw;
            }
        }

        public OprationResult UpdateAsync(PilatesWeek entity)
        {
            throw new System.NotImplementedException();
        }
    }
}