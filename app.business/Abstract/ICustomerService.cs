using System.Collections.Generic;
using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface ICustomerService 
    {
        Task<OprationResult> CreateAsync(Customer entity);
        Task<OprationResult> DeleteAsync(Customer entity);
        Task<ReturnedClass<Customer>> GetByIdAsync(int id);
        Task<OprationResult> UpdateAsync(Customer entity);
        Task<ReturnedClass<Customer>> GetAll();
        Task<ReturnedClass<Customer>> GetByEntityAsync(Customer entity);
        Task<ReturnedClass<Customer>> GetCustomerByIdWithDiet(int? id);
        ReturnedClass<Customer> GetCustomerDietCount(int id);
        Task<OprationResult> InitilazeCustomer(Customer customer);
        Task<ReturnedClass<Customer>> GetCustomerByUserId(string UserId);
        Task<OprationResult> InitilazeDiet(int customerId);
        Task<OprationResult> InitilazePilates(int customerId);
        Task<OprationResult> InitilazeAnamnezForm(int DietId);
        Task<OprationResult> ReduceDietPackage(int customerId);
        Task<ReturnedClass<Customer>> GetCustomerForHome();
        Task<ReturnedClass<Customer>> GetCustomerForCustomerHome(int id);
        Task<OprationResult> ownWeekControlWithByUserId(string userId,int weekId);
        Task<OprationResult> onPiatesControlWithByUserId(string userId,int weekId);
        Task<OprationResult> ReduceRemaningPackage(int customerId);
    }
}