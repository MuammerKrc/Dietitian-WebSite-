using System.Collections.Generic;
using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface IProductService
    {
        Task<OprationResult> CreateAsync(Product entity);
        OprationResult DeleteAsync(Product entity);
        Task<ReturnedClass<Product>> GetByIdAsync(int id);
        OprationResult UpdateAsync(Product entity);
        Task<ReturnedClass<Product>> GetAll();
        Task<ReturnedClass<Product>> GetByEntityAsync(Product entity);
    }
}