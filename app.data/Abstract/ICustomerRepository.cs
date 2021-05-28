using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.data.Abstract
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        Task<ReturnedClass<Customer>> GetCustomerByIdWithDiet(int id);
        ReturnedClass<Customer> GetCustomerDietCount(int id);
    }
}