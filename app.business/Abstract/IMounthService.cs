using System;
using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IMounthService
    {
        Task<OprationResult> CreateAsync(Mounth entity);
        OprationResult DeleteAsync(Mounth entity);
        Task<ReturnedClass<Mounth>> GetByIdAsync(int id);
        OprationResult UpdateAsync(Mounth entity);
        Task<ReturnedClass<Mounth>> GetAll();
        Task<ReturnedClass<Mounth>> GetByEntityAsync(Mounth entity);
        Task<ReturnedClass<Hour>> MakeDate(int mounth, int day, int startingHour, int finishedHOur,int weekId,string currentHour);
        Task<ReturnedClass<Mounth>> GetDateInOneMounth(int currnetMounth);
    }
}