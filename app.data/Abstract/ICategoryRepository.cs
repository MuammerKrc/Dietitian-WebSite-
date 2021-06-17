using app.entity;

namespace app.data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetCategoryWithProductsByID(int categoryID);
        void DeleteProductFromCategory(int proID,int catID);
    }
}