using System.Collections.Generic;
using System.Threading.Tasks;
using app.entity;

namespace app.business.Abstract
{
    public interface IProductService
    {
        Task<Product> GetByID(int id);
        Task<List<Product>> GetAll();
        void Create(Product entity);
        Task<Product> CreateAsync(Product entity);
        void Update(Product entity,int[] categoryIDs);
        void Update(Product entity);
        Task UpdateAsync(Product entityToUpdate,Product entity);
        void Delete(Product entity);
        Task DeleteAsync(Product entity); 
        void DeleteByID(int ID);
        Product GetProductDetails(int id);
        Product GetProductDetailsByName(string productName);
        List<Product> GetProductsByCategory(string name,int pagelist,int page);
        int GetCountByCategory(string categoryName);
    }
}