using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.data.Abstract
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        Task<ReturnedClass<Customer>> GetCustomerByIdWithDiet(int id);
        ReturnedClass<Customer> GetCustomerDietCount(int id);
        Task<ReturnedClass<Customer>> GetByUserId(string userId);
        Task<OprationResult> updateDietPackages(int quantity,int customerId);
        Task<ReturnedClass<Customer>> GetCustomerForHome();
        Task<ReturnedClass<Customer>> GetCustomerForCustomerHome(int id);
        Task<OprationResult> ownWeekControlWithByUserId(string userId,int weekId);
    }
}