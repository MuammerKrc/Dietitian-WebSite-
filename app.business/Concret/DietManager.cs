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
                if (id == null)
                {
                    return new ReturnedClass<Diet>(OprationResult.canceled);
                }
                if (id <= 0)
                {
                    return new ReturnedClass<Diet>(OprationResult.canceled);
                }
                var result = await work.Diets.GetDietByIdWithWeekAndRecipe((int)id);
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
                if (result.oprationResult == OprationResult.ok)
                {
                    var result2 = await work.SaveAsync();
                    if (!ManagerHelper.OperationControl(result2))
                    {
                        result.oprationResult = OprationResult.canceled;
                        return result;
                    }
                    return new ReturnedClass<Diet>(OprationResult.ok);
                }
                return new ReturnedClass<Diet>(OprationResult.canceled);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Diet>(OprationResult.canceled);
            }
        }


    }
}