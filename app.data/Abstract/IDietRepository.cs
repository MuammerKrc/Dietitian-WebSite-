using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.data.Abstract
{
    public interface IDietRepository:IRepository<Diet>
    {
         Task<ReturnedClass<Diet>> GetDietByIdWithWeekAndRecipe(int id);
         Task<ReturnedClass<Diet>> UpdateJustRecipe(int DietId,int[] recipes);
         Task<ReturnedClass<Diet>> ControlAnamnezForm(int DietId);
         Task<ReturnedClass<Diet>> GetWithAnamnezForm(int DietId);
         Task<OprationResult> InitilazeDiet(Diet d);
    }
}