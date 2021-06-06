using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.data.Abstract
{
    public interface IHourRepository:IRepository<Hour>
    {
        Task<ReturnedClass<Hour>> GetDate(int DayId, int startingHour, int finishedHOur,int weekId,string currentHour);
    }
}