using System.Collections.Generic;
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

        public async Task<ReturnedClass<Diet>> UpdateJustRecipe(int DietId, int[] recipes)
        {
            try
            {
                var result=await appContext.Diets.Where(i=>i.Id==DietId)
                                                .Include(m=>m.CombineDietRecipes)
                                                .ThenInclude(m=>m.Recipe)
                                                .AsSplitQuery()
                                                .AsNoTracking()
                                                .SingleOrDefaultAsync();
                
                if(result!=null)
                {
                    List<int> temp=new List<int>();
                    List<CombineDietRecipe> all=result.CombineDietRecipes.ToList()??new List<CombineDietRecipe>();
                    temp=recipes.ToList();
                    foreach (var item in all)
                    {
                        if(!temp.Contains(item.RecipeId))
                        {
                            temp.Add(item.RecipeId);
                        }
                    }
                    result.CombineDietRecipes=temp.Select(m=>new CombineDietRecipe{
                        DietId=result.Id,
                        RecipeId=(int)m
                    }).ToList();
                }
                return new ReturnedClass<Diet>(OprationResult.successful,_value:result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Diet>(OprationResult.ineffective);                
            }
        }
    }

    
}