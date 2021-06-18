using System.Collections.Generic;
using System.Linq;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;


namespace app.data.Concret
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppContext context):base(context)
        {
            
        }
        private AppContext AppContext{get{return context as AppContext;}}


    }
}