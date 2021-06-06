using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.data.Abstract
{
    public interface IDayRepository:IRepository<Day>
    {
        Task<ReturnedClass<Day>> CheckAndCreate(int _MounthId, int Day);
    }
}