using System.Collections.Generic;
using System.Threading.Tasks;
using app.entity;

namespace app.business.Abstract
{
    public interface ICategoryService
    {
        void Create(Category entity);
        void Delete(Category entity);
        void DeleteByID(int id);

        Task<Category> GetByID(int id);
        Task<List<Category>> GetAll();
        Task<Category> CreateAsync(Category entity);

        void Update(Category entity);
        Category GetCategoryWithProductsByID(int categoryID);
        void DeleteProductFromCategory(int proID,int catID);
    }
}