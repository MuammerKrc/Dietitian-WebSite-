using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IDietService
    {
        Task<OprationResult> CreateAsync(Diet entity);
        OprationResult DeleteAsync(Diet entity);
        Task<ReturnedClass<Diet>> GetByIdAsync(int id);
        Task<OprationResult> UpdateAsync(Diet entity);
        Task<ReturnedClass<Diet>> GetAll();
        Task<ReturnedClass<Diet>> GetByEntityAsync(Diet entity);
        Task<ReturnedClass<Diet>> GetDietByIdWithWeekAndRecipe(int? id);
        Task<ReturnedClass<Diet>> UpdateJustRecipe(int _DietId, int[] recipes);

    }
}