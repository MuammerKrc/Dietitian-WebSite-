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
                var result = await work.DietWekkly.CreateAsync(entity);
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

        public async Task<ReturnedClass<DietWekkly>> GetByIDWithDietMenü(int id)
        {
            if (id == 0)
            {
                return new ReturnedClass<DietWekkly>(OprationResult.NotFound);
            }
            try
            {
                var result = await work.DietWekkly.GetByIDWithDietMenü(id);
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<DietWekkly>(OprationResult.canceled);
            }
        }

        public async Task<OprationResult> MakeActive(int weekId)
        {
            try
            {
                var result = await work.DietWekkly.MakeActive(weekId);
                if (result == OprationResult.ok)
                {
                    var saveResult = await work.SaveAsync();
                    if (saveResult == OprationResult.Saved)
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

        public async Task<OprationResult> makeIsDone(int weekId)
        {
            try
            {
                var result = await work.DietWekkly.makeIsDone(weekId);
                if (result == OprationResult.ok)
                {
                    var saveResult = await work.SaveAsync();
                    if (saveResult == OprationResult.Saved)
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
        public async Task<OprationResult> makeNotDone(int weekId)
        {
            try
            {
                try
                {
                    var result = await work.DietWekkly.makeNotDone(weekId);
                    if (result == OprationResult.ok)
                    {
                        var saveResult = await work.SaveAsync();
                        if (saveResult == OprationResult.Saved)
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
        public async Task<OprationResult> UpdateAsync(DietWekkly entity)
        {
            try
            {
                var result = work.DietWekkly.UpdateAsync(entity);
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
                return OprationResult.NotSaved;
            }

        }

        public async Task<OprationResult> UpdateJustDate(int dietWeekId, string currentHour)
        {
            try
            {
                var result = await work.DietWekkly.UpdateJustDate(dietWeekId, currentHour);
                if (result.oprationResult == OprationResult.ok)
                {
                    return await work.SaveAsync();
                }
                return result.oprationResult;
            }
            catch (System.Exception)
            {
                return OprationResult.canceled;
            }
        }

        public async Task<ReturnedClass<DietWekkly>> UpdateJustDietMenü(int dietWeekId, int dietid)
        {
            try
            {
                if (dietid <= 0)
                {

                    return new ReturnedClass<DietWekkly>(OprationResult.NotFound);
                }
                var result = await work.DietWekkly.UpdateJustDietMenü(dietWeekId, dietid);
                var result1 = await work.SaveAsync();
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<DietWekkly>(OprationResult.canceled);
            }
        }

    }
}