using System.Linq;
using System.Threading.Tasks;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class DietRepository:Repository<Diet>,IDietRepository
    {
        public DietRepository(AppContext context):base(context)
        {
            
        }
        private AppContext appContext{get{return context as AppContext;}}

        public async Task<ReturnedClass<Diet>> GetDietByIdWithWeekAndRecipe(int id)
        {
              try
            {
                var result = await appContext.Diets.Where(i => i.Id == id)
                               .Include(m => m.DietWekklies)
                               .Include(m => m.CombineDietRecipes)
                               .AsNoTracking()
                               .FirstOrDefaultAsync();

                return new ReturnedClass<Diet>(OprationResult.successful, _value: result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Diet>(OprationResult.ineffective);
            }
        }
    }
}