using System;
using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.data.Abstract
{
    public interface IMounthRepository : IRepository<Mounth>
    {
        Task<ReturnedClass<Mounth>> ExistThisMounth(int mounth);
        Task<ReturnedClass<Mounth>> CreateWithReturned(Mounth m);
        Task<ReturnedClass<Mounth>> GetDateInOneMounth(int currentMounth);
    }
}