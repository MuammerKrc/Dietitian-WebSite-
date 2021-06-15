using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IDietMenüService
    {
        Task<OprationResult> CreateAsync(DietMenü entity);
        OprationResult DeleteAsync(DietMenü entity);
        Task<ReturnedClass<DietMenü>> GetByIdAsync(int id);
        Task<OprationResult> UpdateAsync(DietMenü entity);
        Task<ReturnedClass<DietMenü>> GetAll();
        Task<ReturnedClass<DietMenü>> GetByEntityAsync(DietMenü entity);
        Task<ReturnedClass<DietMenü>> CreateUpdateWithRecipe(DietMenü entity, int[] recipes);
        Task<ReturnedClass<DietMenü>> GetAllWithRecpe();
        Task<ReturnedClass<DietMenü>> GEtAllWithOption(string Adı, int MinWeight, int MaxWeight, int Cinsiyet, int Meal, int[] recipeIds);
        Task<OprationResult> InitilazeDietMenü(DietMenü dietMenü, int[] recipeIds);
        Task<OprationResult> UpdateDietmenü(DietMenü dietMenü, int[] recipeIds);
    }
}