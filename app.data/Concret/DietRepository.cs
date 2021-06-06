using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class DietRepository : Repository<Diet>, IDietRepository
    {
        public DietRepository(AppContext context) : base(context)
        {

        }
        private AppContext appContext { get { return context as AppContext; } }



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
        
        public async Task<ReturnedClass<Diet>> ControlAnamnezForm(int DietId)
        {
            try
            {
                var result = await appContext.Diets
                                            .Where(i => i.Id == DietId)
                                            .Include(m => m.AnamnezForm)
                                            .AsSplitQuery()
                                            .AsNoTracking()
                                            .SingleOrDefaultAsync();

                if (result.AnamnezForm == null)
                {
                    return new ReturnedClass<Diet>(OprationResult.DontHave);
                }
                else
                {
                    return new ReturnedClass<Diet>(OprationResult.Have,result);
                }
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
                var result = await appContext.Diets.Where(i => i.Id == DietId)
                                                .Include(m => m.CombineDietRecipes)
                                                .ThenInclude(m => m.Recipe)
                                                .AsSplitQuery()
                                                .AsNoTracking()
                                                .SingleOrDefaultAsync();

                if (result != null)
                {
                    List<int> temp = new List<int>();
                    List<CombineDietRecipe> all = result.CombineDietRecipes.ToList() ?? new List<CombineDietRecipe>();
                    temp = recipes.ToList();
                    foreach (var item in all)
                    {
                        if (!temp.Contains(item.RecipeId))
                        {
                            temp.Add(item.RecipeId);
                        }
                    }
                    result.CombineDietRecipes = temp.Select(m => new CombineDietRecipe
                    {
                        DietId = result.Id,
                        RecipeId = (int)m
                    }).ToList();
                }
                return new ReturnedClass<Diet>(OprationResult.successful, _value: result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Diet>(OprationResult.ineffective);
            }
        }

        public async Task<ReturnedClass<Diet>> RegisterAnamnezForm(int DietId, int AnamnezID)
        {

            try
            {
                var result = await appContext.Diets
                                            .Where(i => i.Id == DietId)
                                            .Include(m => m.AnamnezForm)
                                            .AsSplitQuery()
                                            .SingleOrDefaultAsync();

                if (result.AnamnezForm == null)
                {
                    result.AnamnezFormId = AnamnezID;
                    return new ReturnedClass<Diet>(OprationResult.Added, result);
                }
                else
                {
                    return new ReturnedClass<Diet>(OprationResult.Have);
                }
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Diet>(OprationResult.ineffective);
            }

        }

        public async Task<ReturnedClass<Diet>> GetWithAnamnezForm(int DietId)
        {
            try
            {
                 var result = await appContext.Diets
                                            .Where(i => i.Id == DietId)
                                            .Include(m => m.AnamnezForm)
                                            .AsSplitQuery()
                                            .AsNoTracking()
                                            .SingleOrDefaultAsync();

                return new ReturnedClass<Diet>(OprationResult.successful,result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Diet>(OprationResult.NotSaved);                
            }
        }
    }


}