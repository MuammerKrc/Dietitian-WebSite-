using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class DietManager : IDietService
    {
        private IUnitOfWork work;
        public DietManager(IUnitOfWork _work)
        {
            work = _work;
        }
        public Task<OprationResult> CreateAsync(Diet entity)
        {
            throw new System.NotImplementedException();
        }

        public OprationResult DeleteAsync(Diet entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Diet>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Diet>> GetByEntityAsync(Diet entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Diet>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<Diet>> GetDietByIdWithWeekAndRecipe(int? id)
        {
            if (id == null || id == 0)
            {
                return new ReturnedClass<Diet>(OprationResult.NotFound);
            }

            try
            {
                var result = await work.Diets.GetDietByIdWithWeekAndRecipe((int)id);
                if (result.oprationResult == OprationResult.ineffective)
                {
                    return result;
                }
                else if (result.value == null)
                {
                    return result;
                }
                if (result.value == null)
                {
                    return new ReturnedClass<Diet>(OprationResult.NotFound);
                }
                result.oprationResult = OprationResult.ok;
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Diet>(OprationResult.canceled);
            }
        }

        public Task<OprationResult> UpdateAsync(Diet entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<Diet>> UpdateJustRecipe(int _DietId, int[] recipes)
        {
            try
            {
                if (_DietId <= 0)
                {
                    return new ReturnedClass<Diet>(OprationResult.NotFound);
                }
                var result = await work.Diets.UpdateJustRecipe(_DietId, recipes);
                var result2 = await work.SaveAsync();
                return new ReturnedClass<Diet>(OprationResult.ok);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Diet>(OprationResult.canceled);
            }
        }

        public async Task<ReturnedClass<Diet>> UpdateOrCreateAnamnezForm(int DietId)
        {
            try
            {
                var result = await work.Diets.ControlAnamnezForm(DietId);
                if (result.oprationResult == OprationResult.Have)
                {
                    result.oprationResult = OprationResult.successful;
                    return result;
                }
                else if (result.oprationResult == OprationResult.DontHave)
                {
                    AnamnezForm anamnez = new AnamnezForm();
                    var anamnezResult = await work.AnamnezForm.CreateWithRuturned(anamnez);
                    var resultSave = await work.SaveAsync();
                    if (resultSave == OprationResult.Saved)
                    {
                        var Registeranamnez = await work.Diets.RegisterAnamnezForm(DietId, anamnezResult.value.Id);
                        var resultSave2 = await work.SaveAsync();
                        if (resultSave2 == OprationResult.Saved)
                        {
                            var result3 =await work.Diets.GetWithAnamnezForm(DietId);
                            result3.oprationResult=OprationResult.ok;
                            return result3;
                        }
                        else
                        {
                            Registeranamnez.oprationResult=OprationResult.NotSaved;
                            return Registeranamnez;
                        }
                    }
                    else
                    {
                        result.oprationResult = OprationResult.NotSaved;
                        return result;
                    }
                }
                else
                {
                    result.oprationResult = OprationResult.NotFound;
                    return result;
                }
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Diet>(OprationResult.canceled);
            }
        }
    }
}