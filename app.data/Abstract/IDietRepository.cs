using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.data.Abstract
{
    public interface IDietRepository:IRepository<Diet>
    {
         Task<ReturnedClass<Diet>> GetDietByIdWithWeekAndRecipe(int id);
    }
}