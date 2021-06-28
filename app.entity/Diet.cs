using System;
using System.Collections.Generic;

namespace app.entity
{
    public class Diet : BaseClass
    {
        public bool Active { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public AnamnezForm AnamnezForm { get; set; }
        public List<DietWekkly> DietWekklies { get; set; }
        public List<CombineDietRecipe> CombineDietRecipes { get; set; }
    }
}