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
        public Task<OprationResult> CreateAsync(Recipe entity)
        {
            throw new System.NotImplementedException();
        }

        public OprationResult DeleteAsync(Recipe entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<Recipe>> GetAll()
        {
            try
            {
                var result =await work.Recipe.GetAll();
                if(result.oprationResult==OprationResult.ineffective)
                {
                    return result;
                }
                result.oprationResult=OprationResult.ok;
                return result;
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