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


            try
            {
                var resultID = ManagerHelper.IdControlWithReurned<Diet>(id);
                if (!ManagerHelper.OperationControl(resultID.oprationResult))
                {
                    return resultID;
                }

                var result = await work.Diets.GetDietByIdWithWeekAndRecipe((int)id);
                if (!ManagerHelper.OperationControl(result.oprationResult))
                {
                    result.oprationResult=OprationResult.canceled;
                    return result;
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
                    return new ReturnedClass<Diet>(OprationResult.canceled);
                }
                var result = await work.Diets.UpdateJustRecipe(_DietId, recipes);
                if(!ManagerHelper.OperationControl(result.oprationResult))
                {
                    result.oprationResult=OprationResult.canceled;
                    return result;
                }
                var result2 = await work.SaveAsync();
                if(!ManagerHelper.OperationControl(result2))
                {
                    result.oprationResult=OprationResult.canceled;
                    return result;
                }
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
                            var result3 = await work.Diets.GetWithAnamnezForm(DietId);
                            result3.oprationResult = OprationResult.ok;
                            return result3;
                        }
                        else
                        {
                            Registeranamnez.oprationResult = OprationResult.canceled;
                            return Registeranamnez;
                        }
                    }
                    else
                    {
                        result.oprationResult = OprationResult.canceled;
                        return result;
                    }
                }
                else
                {
                    result.oprationResult = OprationResult.canceled;
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