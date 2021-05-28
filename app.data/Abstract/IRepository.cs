using System.Collections.Generic;
using System.Threading.Tasks;
using app.data.Concret;

namespace app.data.Abstract
{
    public interface IRepository<T> where T : class
    {
        Task<OprationResult> CreateAsync(T entity);
        OprationResult DeleteAsync(T entity);
        Task<ReturnedClass<T>> GetByIdAsync(int id);
        OprationResult UpdateAsync(T entity);
        Task<ReturnedClass<T>> GetAll();
        Task<ReturnedClass<T>> GetByEntityAsync(T entity);
    }
}