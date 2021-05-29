using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IRecipeService
    {
        Task<OprationResult> CreateAsync(Recipe entity);
        OprationResult DeleteAsync(Recipe entity);
        Task<ReturnedClass<Recipe>> GetByIdAsync(int id);
        Task<OprationResult> UpdateAsync(Recipe entity);
        Task<ReturnedClass<Recipe>> GetAll();
        Task<ReturnedClass<Recipe>> GetByEntityAsync(Recipe entity);
    }
}