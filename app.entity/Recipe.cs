using System.Collections.Generic;

namespace app.entity
{
    public class Recipe:BaseClass
    {
        public string Name{get;set;}
        public string Content{get;set;}
        public bool Active{get;set;}
        public List<CombineDietMen├╝Recipe> CombineDietMen├╝Recipes{get;set;}
        public List<CombineDietRecipe> CombineDietRecipes{get;set;}
    }
}