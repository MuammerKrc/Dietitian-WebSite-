using System.Collections.Generic;

namespace app.entity
{
    public class Category : BaseClass
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}