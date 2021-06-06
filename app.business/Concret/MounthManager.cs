using System;
using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class MounthManager : IMounthService
    {
        public MounthManager(IUnitOfWork _work)
        {
            work = _work;
        }
        private IUnitOfWork work;
        public Task<OprationResult> CreateAsync(Mounth entity)
        {
            throw new System.NotImplementedException();
        }

        public OprationResult DeleteAsync(Mounth entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Mounth>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Mounth>> GetByEntityAsync(Mounth entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Mounth>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public OprationResult UpdateAsync(Mounth entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<Mounth>> GetDateInOneMounth(int currnetMounth)
        {
            try
            {
                var result = await work.Mounth.GetDateInOneMounth(currnetMounth);
                if (result.oprationResult == OprationResult.successful)
                {
                    result.oprationResult=OprationResult.ok;
                }
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Mounth>(OprationResult.canceled);
            }
        }

        public async Task<ReturnedClass<Hour>> MakeDate(int mounth, int day, int startingHour, int finishedHOur, int weekId, string currentHour)
        {
            try
            {
                var result = await CheckMounth(mounth);
                if (result.oprationResult == OprationResult.Have || result.oprationResult == OprationResult.Saved)
                {
                    var resultCheckDay = await CheckDay(result.value.Id, day);
                    if (resultCheckDay.oprationResult == OprationResult.Saved)
                    {
                        var resultCheckHour = await CheckHour(resultCheckDay.value.Id, startingHour, finishedHOur, weekId, currentHour);
                        return resultCheckHour;
                    }
                    else
                    {
                        return new ReturnedClass<Hour>(OprationResult.NotSaved);
                    }
                }
                else
                {
                    return new ReturnedClass<Hour>(OprationResult.NotSaved);
                }
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Hour>(OprationResult.canceled);
            }
        }
        private async Task<ReturnedClass<Mounth>> CheckMounth(int _mounth)
        {
            try
            {
                var resultCheckMounth = await work.Mounth.ExistThisMounth(_mounth);
                if (resultCheckMounth.oprationResult == OprationResult.DontHave)
                {
                    var resultCreateMounth = await CreateMounth(_mounth);
                    return resultCreateMounth;
                }
                return resultCheckMounth;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Mounth>(OprationResult.canceled);
            }

        }
        private async Task<ReturnedClass<Mounth>> CreateMounth(int _mounth)
        {
            try
            {
                Mounth m1 = new Mounth()
                {
                    CurrentMounth = _mounth
                };
                var resultMounth = await work.Mounth.CreateWithReturned(m1);
                if (resultMounth.oprationResult == OprationResult.successful)
                {
                    var saveresult = await work.SaveAsync();
                    if (saveresult == OprationResult.Saved)
                    {
                        resultMounth.oprationResult = OprationResult.Saved;
                        return resultMounth;
                    }
                    else
                    {
                        resultMounth.oprationResult = OprationResult.NotSaved;
                        return resultMounth;
                    }
                }
                else
                {
                    return resultMounth;
                }
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Mounth>(OprationResult.canceled);
            }
        }

        private async Task<ReturnedClass<Day>> CheckDay(int _mounthId, int _day)
        {
            try
            {
                var result = await work.Day.CheckAndCreate(_mounthId, _day);

                if (result.oprationResult != OprationResult.ineffective)
                {
                    var resultSave = await work.SaveAsync();
                    if (resultSave == OprationResult.Saved)
                    {
                        result.oprationResult = OprationResult.Saved;
                        return result;
                    }
                    else
                    {
                        result.oprationResult = OprationResult.NotSaved;
                        return result;
                    }
                }
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Day>(OprationResult.canceled);
            }
        }
        private async Task<ReturnedClass<Hour>> CheckHour(int DayId, int startingHour, int finishedHour, int weekId, string currentHour)
        {
            try
            {
                var result = await work.Hour.GetDate(DayId, startingHour, finishedHour, weekId, currentHour);
                if (result.oprationResult == OprationResult.successful)
                {
                    var resultSave = await work.SaveAsync();
                    if (resultSave == OprationResult.Saved)
                    {
                        result.oprationResult = OprationResult.Saved;
                        return result;
                    }
                    result.oprationResult = OprationResult.NotSaved;
                    return result;
                }
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Hour>(OprationResult.canceled);
            }
        }

    }
}