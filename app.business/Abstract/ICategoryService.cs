using System.Collections.Generic;
using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.business.Abstract
{
    public interface ICategoryService
    {
        Task<OprationResult> CreateAsync(Category entity);
        OprationResult DeleteAsync(Category entity);
        Task<ReturnedClass<Category>> GetByIdAsync(int id);
        OprationResult UpdateAsync(Category entity);
        Task<ReturnedClass<Category>> GetAll();
        Task<ReturnedClass<Category>> GetByEntityAsync(Category entity);
    }
}