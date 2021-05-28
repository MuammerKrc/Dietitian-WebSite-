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
        Task<ReturnedClass<Customer>> GetCustomerByIdWithDiet(int id);
        ReturnedClass<Customer> GetCustomerDietCount(int id);
    }
}