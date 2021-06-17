using System.Collections.Generic;
using app.entity;

namespace app.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        int GetCountByCategory(string categoryName);
        Product GetProductDetails(int id);
        Product GetProductDetailsByName(string productname);
        List<Product> GetProductByCategory(string name, int pagelist, int page);
        List<Product> GetPopularProduct();
        void update(Product entity,int[] categoryIDs);
    }
}