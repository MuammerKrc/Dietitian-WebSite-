using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class RecipeManager : IRecipeService
    {
        private IUnitOfWork work;
        public RecipeManager(IUnitOfWork _work)
        {
            work=_work;
        }
        public async Task<OprationResult> CreateAsync(Recipe entity)
        {
            try
            {
                var result = await work.Recipe.CreateAsync(entity);
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

        public OprationResult DeleteAsync(Recipe entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<Recipe>> GetAll()
        {
            try
            {
                return await work.Recipe.GetAll();
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Recipe>(OprationResult.canceled);
            }
        }

        public Task<ReturnedClass<Recipe>> GetByEntityAsync(Recipe entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Recipe>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<OprationResult> UpdateAsync(Recipe entity)
        {
            throw new System.NotImplementedException();
        }
    }
}