using System;
using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class CalendarManager : ICalendarService
    {
        private IUnitOfWork work;
        public CalendarManager(IUnitOfWork _unitOfWork)
        {
            work = _unitOfWork;
        }

        public Task<OprationResult> CreateAsync(Calendar entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<OprationResult> DeleteAsync(Calendar entity)
        {
            try
            {
                if (entity.Id > 0)
                {
                    var reuslt = work.Calendar.DeleteAsync(entity);

                    if (reuslt == OprationResult.ok)
                    {
                        var saveResult = await work.SaveAsync();
                        if (saveResult == OprationResult.Saved)
                        {
                            return OprationResult.ok;
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

        public Task<ReturnedClass<Calendar>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Calendar>> GetByEntityAsync(Calendar entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<Calendar>> GetByIdAsync(int id)
        {
            try
            {
                var reuslt =await work.Calendar.GetByIdAsync(id);
                return reuslt;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Calendar>(OprationResult.canceled);
            }
        }

        public async Task<ReturnedClass<Calendar>> GetDates(DateTime day)
        {
            try
            {
                var result = await work.Calendar.GetDates(day);
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Calendar>(OprationResult.canceled);
            }
        }

        public async Task<OprationResult> MakeDate(Calendar c)
        {
            try
            {
                var checkResult = await work.Calendar.CheckDate(c);
                if (checkResult == OprationResult.ok)
                {
                    var result = await work.Calendar.CreateAsync(c);
                    if (result == OprationResult.ok)
                    {
                        var SaveResult = await work.SaveAsync();
                        if (SaveResult == OprationResult.Saved)
                        {
                            return OprationResult.ok;
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

        public async Task<OprationResult> UpdateAsync(Calendar entity)
        {
            try
            {
                if ((entity.DietWekklyId > 0 && entity.Id > 0) || (entity.PilatesWeekId > 0 && entity.Id > 0))
                {
                    var result = work.Calendar.UpdateAsync(entity);
                    if (result == OprationResult.ok)
                    {
                        var SaveResult = await work.SaveAsync();
                        if (SaveResult == OprationResult.Saved)
                        {
                            return OprationResult.ok;
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
    }
}