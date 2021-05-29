namespace app.entity
{
    public class CombineDietRecipe
    {
        public int DietId{get;set;}
        public Diet Diet{get;set;}
        public int RecipeId{get;set;}
        public Recipe Recipe{get;set;}
    }
}