using System.Collections.Generic;
using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork work;
        public CategoryManager(IUnitOfWork _unitOfWork)
        {
            work=_unitOfWork;
        }

        public Task<OprationResult> CreateAsync(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public OprationResult DeleteAsync(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<Category>> GetAll()
        {
            try
            {
                var result =await work.Categories.GetAll();
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Category>(OprationResult.canceled);                
            }
        }

        public Task<ReturnedClass<Category>> GetByEntityAsync(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<Category>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public OprationResult UpdateAsync(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}