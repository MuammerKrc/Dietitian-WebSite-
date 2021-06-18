using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using app.entity;
using app.data.Abstract;

namespace app.data.Concret
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {

        public ProductRepository(AppContext context) : base(context)
        {

        }
        public AppContext AppContext { get { return context as AppContext; } }
  
    }
}