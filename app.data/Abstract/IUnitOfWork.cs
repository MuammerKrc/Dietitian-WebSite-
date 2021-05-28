using System;
using System.Threading.Tasks;

namespace app.data.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        ICustomerRepository Customers{get;}
        IPilatesRepository Piates{get;}
        IDietRepository Diets{get;}
        
        IDietWekklyRepository DietWekkly{get;}
        Task<OprationResult> SaveAsync();
    }
}