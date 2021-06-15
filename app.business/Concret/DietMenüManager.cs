using System.Linq;
using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class DietMenüManager : IDietMenüService
    {
        private IUnitOfWork work;
        public DietMenüManager(IUnitOfWork _work)
        {
            work = _work;
        }
        public Task<OprationResult> CreateAsync(DietMenü entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<DietMenü>> CreateUpdateWithRecipe(DietMenü entity, int[] recipes)
        {
            try
            {
                if (entity.Id <= 0)
                {
                    var result = work.dietMenüs.CreateDietMenüReturned(entity);
                    var result1 = await work.SaveAsync();
                    var resultWithRecipe = await work.dietMenüs.UpdateWithRecipe(result.value, recipes);
                    var result2 = await work.SaveAsync();
                    return new ReturnedClass<DietMenü>(OprationResult.ok, _value: resultWithRecipe.value);
                }
                else
                {
                    var result = await work.dietMenüs.UpdateWithRecipe(entity, recipes);
                    var result1 = await work.SaveAsync();
                    return new ReturnedClass<DietMenü>(OprationResult.ok, _value: result.value);
                }
            }
            catch (System.Exception)
            {
                return new ReturnedClass<DietMenü>(OprationResult.canceled);
            }

        }



        public OprationResult DeleteAsync(DietMenü entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<DietMenü>> GetAll()
        {

            return await work.dietMenüs.GetAll();
        }

        public async Task<ReturnedClass<DietMenü>> GEtAllWithOption(string Adı, int MinWeight, int MaxWeight, int Cinsiyet, int Meal, int[] recipeIds)
        {
            try
            {
                var result = await work.dietMenüs.GEtAllWithOption(Adı, MinWeight, MaxWeight, Cinsiyet, Meal, recipeIds);
                result.oprationResult = OprationResult.ok;
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<DietMenü>(OprationResult.canceled);
            }
        }

        public async Task<ReturnedClass<DietMenü>> GetAllWithRecpe()
        {
            try
            {
                var result = await work.dietMenüs.GetAllWithRecpe();
                result.oprationResult = OprationResult.ok;
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<DietMenü>(OprationResult.canceled);
            }
        }

        public Task<ReturnedClass<DietMenü>> GetByEntityAsync(DietMenü entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<DietMenü>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<OprationResult> UpdateAsync(DietMenü entity)
        {
            throw new System.NotImplementedException();
        }
        public async Task<OprationResult> InitilazeDietMenü(DietMenü dietMenü, int[] recipeIds)
        {
            try
            {
                var result = await work.dietMenüs.CreateAsync(dietMenü);
                if (result == OprationResult.ok)
                {
                    var saveResult = await work.SaveAsync();
                    if (saveResult == OprationResult.Saved)
                    {
                        var result2 = await work.dietMenüs.UpdateWithRecipe(dietMenü, recipeIds);
                        if (result2.oprationResult == OprationResult.ok)
                        {
                            var saveResult2 = await work.SaveAsync();
                            if (saveResult == OprationResult.Saved)
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
        public async Task<OprationResult> UpdateDietmenü(DietMenü dietMenü, int[] recipeIds)
        {
            try
            {
                var result = await work.dietMenüs.UpdateWithRecipe(dietMenü, recipeIds);
                if(result.oprationResult==OprationResult.ok)
                {
                    var SaveResult =await work.SaveAsync();
                    if(SaveResult==OprationResult.Saved)
                    {
                        return   OprationResult.ok;
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