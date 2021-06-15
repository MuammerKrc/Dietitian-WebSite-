using System.Linq;
using System.Threading.Tasks;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class DietMenüRepository : Repository<DietMenü>, IDietMenüRepository
    {
        public DietMenüRepository(AppContext context) : base(context)
        {

        }
        private AppContext appContext { get { return context as AppContext; } }

        public async Task<ReturnedClass<DietMenü>> UpdateWithRecipe(DietMenü entity, int[] recipes)
        {
            if (entity.Id <= 0)
            {
                return new ReturnedClass<DietMenü>(OprationResult.NotFound);
            }
            try
            {
                var result = await appContext.DietMenüs
                                        .Where(m => m.Id == entity.Id)
                                        .Include(m => m.CombineDietMenüRecipes)
                                        .ThenInclude(m => m.Recipe)
                                        .SingleOrDefaultAsync();

                if (result != null)
                {
                    result.FullName = entity.FullName;
                    result.Gender = entity.Gender;
                    result.Path = entity.Path;
                    result.TwoMeals = entity.TwoMeals;
                    result.Weight = entity.Weight;
                    result.Content=entity.Content;
                    result.CombineDietMenüRecipes = recipes.ToList().Select(Ids => new CombineDietMenüRecipe
                    {
                        DietMenüId = entity.Id,
                        RecipeId = (int)Ids
                    }).ToList();
                    return new ReturnedClass<DietMenü>(OprationResult.ok, _value: result);
                }
                else
                {
                    return new ReturnedClass<DietMenü>(OprationResult.NotFound);
                }

            }
            catch (System.Exception)
            {
                return new ReturnedClass<DietMenü>(OprationResult.canceled);
            }
        }
        public ReturnedClass<DietMenü> CreateDietMenüReturned(DietMenü entity)
        {
            try
            {
                var result = appContext.DietMenüs.Add(entity);
                DietMenü asd = result.Entity;

                return new ReturnedClass<DietMenü>(OprationResult.ok, _value: asd);
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
                var result = await appContext.DietMenüs
                                    .Include(m => m.CombineDietMenüRecipes)
                                    .ThenInclude(m => m.Recipe)
                                    .ToListAsync();

                return new ReturnedClass<DietMenü>(OprationResult.ok, _values: result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<DietMenü>(OprationResult.canceled);
            }
        }

        public async Task<ReturnedClass<DietMenü>> GEtAllWithOption(string Adı, int MinWeight, int MaxWeight, int Cinsiyet, int Meal, int[] recipeIds)
        {
            try
            {
                var product = appContext
                            .DietMenüs
                            .AsNoTracking()
                            .AsQueryable();

                if (Adı != null)
                {
                    if (Adı.Length >= 3)
                    {
                        product = product
                      .Where(i => i.FullName.ToLower().Contains(Adı.ToLower())).AsQueryable();
                    }
                }
                if (MinWeight > 0)
                {
                    product = product.Where(i => i.Weight >= MinWeight).AsQueryable();
                }

                if (MaxWeight > 0 && MaxWeight > MinWeight)
                {
                    product.Where(i => i.Weight <= MaxWeight);
                }
                if (Cinsiyet == 1 || Cinsiyet == 2)
                {
                    if (Cinsiyet == 1)
                    {
                        product = product.Where(i => i.Gender == true).AsQueryable();
                    }
                    else
                    {
                        product = product.Where(i => i.Gender == false).AsQueryable();
                    }
                }
                if (Meal == 1 || Meal == 2)
                {
                    if (Meal == 1)
                    {
                        product = product.Where(i => i.TwoMeals == true).AsQueryable();
                    }
                    else
                    {
                        product = product.Where(i => i.TwoMeals == false).AsQueryable();
                    }
                }
                product = product.Include(m => m.CombineDietMenüRecipes).ThenInclude(m => m.Recipe).AsQueryable();

                if (recipeIds != null)
                {
                    if (recipeIds.Count() > 0)
                    {
                        foreach (var item in recipeIds)
                        {
                            product = product.Where(i => i.CombineDietMenüRecipes.Any(i =>i.RecipeId==item));
                        }
                    }
                }



                var results = await product.ToListAsync();

                return new ReturnedClass<DietMenü>(OprationResult.ok, _values: results);
            }
            catch (System.Exception)
            {

                return new ReturnedClass<DietMenü>(OprationResult.canceled);
            }
        }
    }
}