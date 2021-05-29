using app.data.Abstract;
using app.entity;

namespace app.data.Concret
{
    public class RecipeRepository:Repository<Recipe>,IRecipeRepository
    {
        public RecipeRepository(AppContext context):base(context)
        {
            
        }
        private AppContext appContext{get{return context as AppContext;}}
    }
}