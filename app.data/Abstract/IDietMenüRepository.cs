using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.data.Abstract
{
    public interface IDietMenüRepository:IRepository<DietMenü>
    {
        Task<ReturnedClass<DietMenü>> UpdateWithRecipe(DietMenü entity,int[] recipes);
        ReturnedClass<DietMenü> CreateDietMenüReturned(DietMenü entity);
        Task<ReturnedClass<DietMenü>> GetAllWithRecpe();
        Task<ReturnedClass<DietMenü>> GEtAllWithOption(string Adı,int MinWeight,int MaxWeight,int Cinsiyet,int Meal,int[] recipeIds);
    }
}